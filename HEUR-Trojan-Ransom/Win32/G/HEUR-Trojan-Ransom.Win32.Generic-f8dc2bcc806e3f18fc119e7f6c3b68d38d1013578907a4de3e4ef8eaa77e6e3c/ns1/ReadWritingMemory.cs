using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class ReadWritingMemory
{
	private const int PROCESS_ALL_ACCESS = 127231;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern float WriteProcessMemory_1(int hProcess, int lpBaseAddress, ref float lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern long WriteProcessMemory_2(int hProcess, int lpBaseAddress, ref long lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern float ReadProcessMemory_1(int hProcess, int lpBaseAddress, ref float lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern long ReadProcessMemory_2(int hProcess, int lpBaseAddress, ref long lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	public static bool WriteDMAInteger(string Process, int Address, int[] Offsets, int Value, int Level, int nsize = 4)
	{
		checked
		{
			try
			{
				int address = Address;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = Level;
					if (num2 > num3)
					{
						break;
					}
					address = ReadInteger(Process, address, nsize) + Offsets[num - 1];
					num++;
				}
				WriteInteger(Process, address, Value, nsize);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static int ReadDMAInteger(string Process, int Address, int[] Offsets, int Level, int nsize = 4)
	{
		checked
		{
			int result = default(int);
			try
			{
				int address = Address;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = Level;
					if (num2 > num3)
					{
						break;
					}
					address = ReadInteger(Process, address, nsize) + Offsets[num - 1];
					num++;
				}
				int num4 = ReadInteger(Process, address, nsize);
				result = num4;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static bool WriteDMAFloat(string Process, int Address, int[] Offsets, float Value, int Level, int nsize = 4)
	{
		checked
		{
			try
			{
				int address = Address;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = Level;
					if (num2 > num3)
					{
						break;
					}
					address = (int)Math.Round(ReadFloat(Process, address, nsize) + (float)Offsets[num - 1]);
					num++;
				}
				WriteFloat(Process, address, Value, nsize);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static float ReadDMAFloat(string Process, int Address, int[] Offsets, int Level, int nsize = 4)
	{
		checked
		{
			float result = default(float);
			try
			{
				int address = Address;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = Level;
					if (num2 > num3)
					{
						break;
					}
					address = (int)Math.Round(ReadFloat(Process, address, nsize) + (float)Offsets[num - 1]);
					num++;
				}
				float num4 = ReadFloat(Process, address, nsize);
				result = num4;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static bool WriteDMALong(string Process, int Address, int[] Offsets, long Value, int Level, int nsize = 4)
	{
		checked
		{
			try
			{
				int address = Address;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = Level;
					if (num2 > num3)
					{
						break;
					}
					address = (int)(ReadLong(Process, address, nsize) + Offsets[num - 1]);
					num++;
				}
				WriteLong(Process, address, Value, nsize);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static long ReadDMALong(string Process, int Address, int[] Offsets, int Level, int nsize = 4)
	{
		checked
		{
			long result = default(long);
			try
			{
				int address = Address;
				int num = 1;
				while (true)
				{
					int num2 = num;
					int num3 = Level;
					if (num2 > num3)
					{
						break;
					}
					address = (int)(ReadLong(Process, address, nsize) + Offsets[num - 1]);
					num++;
				}
				long num4 = ReadLong(Process, address, nsize);
				result = num4;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static void WriteNOPs(string ProcessName, long Address, int NOPNum)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length == 0)
		{
			return;
		}
		IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		checked
		{
			while (true)
			{
				int num3 = num2;
				int num4 = NOPNum;
				if (num3 <= num4)
				{
					int hProcess = (int)intPtr;
					int lpBaseAddress = (int)(Address + num);
					int lpBuffer = 144;
					int lpNumberOfBytesWritten = 0;
					WriteProcessMemory(hProcess, lpBaseAddress, ref lpBuffer, 1, ref lpNumberOfBytesWritten);
					num++;
					num2++;
					continue;
				}
				break;
			}
		}
	}

	public static void WriteXBytes(string ProcessName, long Address, string Value)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length == 0)
		{
			return;
		}
		IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		checked
		{
			int num3 = (int)Math.Round(Math.Round((double)Strings.Len(Value) / 2.0));
			int num4 = 1;
			while (true)
			{
				int num5 = num4;
				int num6 = num3;
				if (num5 <= num6)
				{
					byte b = (byte)Math.Round(Conversion.Val("&H" + Strings.Mid(Value, num2, 2)));
					int hProcess = (int)intPtr;
					int lpBaseAddress = (int)(Address + num);
					int lpBuffer = b;
					int lpNumberOfBytesWritten = 0;
					WriteProcessMemory(hProcess, lpBaseAddress, ref lpBuffer, 1, ref lpNumberOfBytesWritten);
					b = (byte)lpBuffer;
					num++;
					num2 += 2;
					num4++;
					continue;
				}
				break;
			}
		}
	}

	public static void WriteInteger(string ProcessName, int Address, int Value, int nsize = 4)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length != 0)
		{
			IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
			if (!(intPtr == IntPtr.Zero))
			{
				int hProcess = (int)intPtr;
				int lpBuffer = Value;
				int lpNumberOfBytesWritten = 0;
				WriteProcessMemory(hProcess, Address, ref lpBuffer, nsize, ref lpNumberOfBytesWritten);
			}
		}
	}

	public static void WriteFloat(string ProcessName, int Address, float Value, int nsize = 4)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length != 0)
		{
			IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
			if (!(intPtr == IntPtr.Zero))
			{
				float lpBuffer = Value;
				int hProcess = (int)intPtr;
				int lpNumberOfBytesWritten = 0;
				WriteProcessMemory_1(hProcess, Address, ref lpBuffer, nsize, ref lpNumberOfBytesWritten);
			}
		}
	}

	public static void WriteLong(string ProcessName, int Address, long Value, int nsize = 4)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length != 0)
		{
			IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
			if (!(intPtr == IntPtr.Zero))
			{
				long lpBuffer = Value;
				int hProcess = (int)intPtr;
				int lpNumberOfBytesWritten = 0;
				WriteProcessMemory_2(hProcess, Address, ref lpBuffer, nsize, ref lpNumberOfBytesWritten);
			}
		}
	}

	public static int ReadInteger(string ProcessName, int Address, int nsize = 4)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length != 0)
		{
			IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
			if (!(intPtr == IntPtr.Zero))
			{
				int hProcess = (int)intPtr;
				int lpNumberOfBytesWritten = 0;
				int lpBuffer = default(int);
				ReadProcessMemory(hProcess, Address, ref lpBuffer, nsize, ref lpNumberOfBytesWritten);
				return lpBuffer;
			}
		}
		int result = default(int);
		return result;
	}

	public static float ReadFloat(string ProcessName, int Address, int nsize = 4)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length != 0)
		{
			IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
			if (!(intPtr == IntPtr.Zero))
			{
				int hProcess = (int)intPtr;
				int lpNumberOfBytesWritten = 0;
				float lpBuffer = default(float);
				ReadProcessMemory_1(hProcess, Address, ref lpBuffer, nsize, ref lpNumberOfBytesWritten);
				return lpBuffer;
			}
		}
		float result = default(float);
		return result;
	}

	public static long ReadLong(string ProcessName, int Address, int nsize = 4)
	{
		if (ProcessName.EndsWith(".exe"))
		{
			ProcessName = ProcessName.Replace(".exe", "");
		}
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length != 0)
		{
			IntPtr intPtr = (IntPtr)OpenProcess(127231, 0, processesByName[0].Id);
			if (!(intPtr == IntPtr.Zero))
			{
				int hProcess = (int)intPtr;
				int lpNumberOfBytesWritten = 0;
				long lpBuffer = default(long);
				ReadProcessMemory_2(hProcess, Address, ref lpBuffer, nsize, ref lpNumberOfBytesWritten);
				return lpBuffer;
			}
		}
		long result = default(long);
		return result;
	}
}
