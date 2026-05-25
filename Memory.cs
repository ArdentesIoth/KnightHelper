using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

public class Memory
{
    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    private static extern void CloseHandle(IntPtr hObject);

    private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
    private Process process;
    private IntPtr processHandle;

    public bool Attach(string procName)
    {
        Process[] processes = Process.GetProcessesByName(procName);
        if (processes.Length == 0) return false;

        process = processes[0];
        processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);
        return processHandle != IntPtr.Zero;
    }

    public void Detach()
    {
        if (processHandle != IntPtr.Zero)
            CloseHandle(processHandle);
    }

    public IntPtr GetModuleBase(string moduleName)
    {
        foreach (ProcessModule module in process.Modules)
        {
            if (module.ModuleName.ToLower() == moduleName.ToLower())
                return module.BaseAddress;
        }
        return IntPtr.Zero;
    }

    // Pointer chain oku: base + offset1 + offset2 +...
    public IntPtr ReadPointer(IntPtr baseAddress, int[] offsets)
    {
        IntPtr address = baseAddress;
        foreach (int offset in offsets)
        {
            address = Read<IntPtr>(address) + offset;
        }
        return address;
    }

    public T Read<T>(IntPtr address) where T : struct
    {
        int size = Marshal.SizeOf(typeof(T));
        byte[] buffer = new byte[size];
        int bytesRead = 0;
        ReadProcessMemory((int)processHandle, address, buffer, size, ref bytesRead);

        GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
        T data = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
        handle.Free();
        return data;
    }

    public bool Write<T>(IntPtr address, T value) where T : struct
    {
        int size = Marshal.SizeOf(typeof(T));
        byte[] buffer = new byte[size];
        IntPtr ptr = Marshal.AllocHGlobal(size);
        Marshal.StructureToPtr(value, ptr, true);
        Marshal.Copy(ptr, buffer, 0, size);
        Marshal.FreeHGlobal(ptr);

        int bytesWritten = 0;
        return WriteProcessMemory((int)processHandle, address, buffer, size, ref bytesWritten);
    }

    public string ReadString(IntPtr address, int length, Encoding encoding = null)
    {
        encoding = encoding ?? Encoding.UTF8;
        byte[] buffer = new byte[length];
        int bytesRead = 0;
        ReadProcessMemory((int)processHandle, address, buffer, length, ref bytesRead);
        return encoding.GetString(buffer).Split('\0')[0];
    }
}