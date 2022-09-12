using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Trainer
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern byte ReadProcessMemory(int Handle, int Address, ref byte Value, int Size = 2, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern int ReadProcessMemory_1(int Handle, int Address, ref int Value, int Size = 4, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern float ReadProcessMemory_2(int Handle, int Address, ref float Value, int Size = 4, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern double ReadProcessMemory_3(int Handle, int Address, ref double Value, int Size = 8, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern byte WriteProcessMemory(int Handle, int Address, ref byte Value, int Size = 2, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern int WriteProcessMemory_1(int Handle, int Address, ref int Value, int Size = 4, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern float WriteProcessMemory_2(int Handle, int Address, ref float Value, int Size = 2, ref int Bytes = 0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern double WriteProcessMemory_3(int Handle, int Address, ref double Value, int Size = 2, ref int Bytes = 0);

	public static byte ReadByte(string EXENAME, int Address)
	{
		byte Value = default(byte);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				ReadProcessMemory(num, Address, ref Value, 2, ref Bytes);
			}
		}
		return Value;
	}

	public static int ReadInteger(string EXENAME, int Address)
	{
		int Value = default(int);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				ReadProcessMemory_1(num, Address, ref Value, 4, ref Bytes);
			}
		}
		return Value;
	}

	public static float ReadFloat(string EXENAME, int Address)
	{
		float Value = default(float);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				ReadProcessMemory_2(num, Address, ref Value, 4, ref Bytes);
			}
		}
		return Value;
	}

	public static double ReadDouble(string EXENAME, int Address)
	{
		double num2 = default(double);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				byte Value = checked((byte)Math.Round(num2));
				int Bytes = 0;
				ReadProcessMemory(num, Address, ref Value, 2, ref Bytes);
				return (int)Value;
			}
		}
		return num2;
	}

	public static byte ReadPointerByte(string EXENAME, int Pointer, params int[] Offset)
	{
		byte Value = default(byte);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes;
				foreach (int num2 in Offset)
				{
					int address = Pointer;
					Bytes = 0;
					ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
					Pointer = checked(Pointer + num2);
				}
				int address2 = Pointer;
				Bytes = 0;
				ReadProcessMemory(num, address2, ref Value, 2, ref Bytes);
			}
		}
		return Value;
	}

	public static int ReadPointerInteger(string EXENAME, int Pointer, params int[] Offset)
	{
		int Value = default(int);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes;
				foreach (int num2 in Offset)
				{
					int address = Pointer;
					Bytes = 0;
					ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
					Pointer = checked(Pointer + num2);
				}
				int address2 = Pointer;
				Bytes = 0;
				ReadProcessMemory_1(num, address2, ref Value, 4, ref Bytes);
			}
		}
		return Value;
	}

	public static float ReadPointerFloat(string EXENAME, int Pointer, params int[] Offset)
	{
		float Value = default(float);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes;
				foreach (int num2 in Offset)
				{
					int address = Pointer;
					Bytes = 0;
					ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
					Pointer = checked(Pointer + num2);
				}
				int address2 = Pointer;
				Bytes = 0;
				ReadProcessMemory_2(num, address2, ref Value, 4, ref Bytes);
			}
		}
		return Value;
	}

	public static double ReadPointerDouble(string EXENAME, int Pointer, params int[] Offset)
	{
		double Value = default(double);
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes;
				foreach (int num2 in Offset)
				{
					int address = Pointer;
					Bytes = 0;
					ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
					Pointer = checked(Pointer + num2);
				}
				int address2 = Pointer;
				Bytes = 0;
				ReadProcessMemory_3(num, address2, ref Value, 8, ref Bytes);
			}
		}
		return Value;
	}

	public static void WriteByte(string EXENAME, int Address, byte Value)
	{
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				WriteProcessMemory(num, Address, ref Value, 2, ref Bytes);
			}
		}
	}

	public static void WriteInteger(string EXENAME, int Address, int Value)
	{
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				WriteProcessMemory_1(num, Address, ref Value, 4, ref Bytes);
			}
		}
	}

	public static void WriteFloat(string EXENAME, int Address, float Value)
	{
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				WriteProcessMemory_2(num, Address, ref Value, 2, ref Bytes);
			}
		}
	}

	public static void WriteDouble(string EXENAME, int Address, double Value)
	{
		if (Process.GetProcessesByName(EXENAME).Length != 0)
		{
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes = 0;
				WriteProcessMemory_3(num, Address, ref Value, 2, ref Bytes);
			}
		}
	}

	public static void WritePointerByte(string EXENAME, int Pointer, byte Value, params int[] Offset)
	{
		if (Process.GetProcessesByName(EXENAME).Length == 0)
		{
			return;
		}
		int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
		if (num != 0)
		{
			int Bytes;
			foreach (int num2 in Offset)
			{
				int address = Pointer;
				Bytes = 0;
				ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
				Pointer = checked(Pointer + num2);
			}
			int address2 = Pointer;
			Bytes = 0;
			WriteProcessMemory(num, address2, ref Value, 2, ref Bytes);
		}
	}

	public static void WritePointerInteger(string EXENAME, int Pointer, int Value, params int[] Offset)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Process.GetProcessesByName(EXENAME).Length == 0)
			{
				return;
			}
			int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
			if (num != 0)
			{
				int Bytes;
				foreach (int num2 in Offset)
				{
					int address = Pointer;
					Bytes = 0;
					ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
					Pointer = checked(Pointer + num2);
				}
				int address2 = Pointer;
				Bytes = 0;
				WriteProcessMemory_1(num, address2, ref Value, 4, ref Bytes);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Wolfteam kapalı", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public static void WritePointerFloat(string EXENAME, int Pointer, float Value, params int[] Offset)
	{
		if (Process.GetProcessesByName(EXENAME).Length == 0)
		{
			return;
		}
		int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
		if (num != 0)
		{
			int Bytes;
			foreach (int num2 in Offset)
			{
				int address = Pointer;
				Bytes = 0;
				ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
				Pointer = checked(Pointer + num2);
			}
			int address2 = Pointer;
			Bytes = 0;
			WriteProcessMemory_2(num, address2, ref Value, 2, ref Bytes);
		}
	}

	public static void WritePointerDouble(string EXENAME, int Pointer, double Value, params int[] Offset)
	{
		if (Process.GetProcessesByName(EXENAME).Length == 0)
		{
			return;
		}
		int num = (int)Process.GetProcessesByName(EXENAME)[0].Handle;
		if (num != 0)
		{
			int Bytes;
			foreach (int num2 in Offset)
			{
				int address = Pointer;
				Bytes = 0;
				ReadProcessMemory_1(num, address, ref Pointer, 4, ref Bytes);
				Pointer = checked(Pointer + num2);
			}
			int address2 = Pointer;
			Bytes = 0;
			WriteProcessMemory_3(num, address2, ref Value, 2, ref Bytes);
		}
	}
}
