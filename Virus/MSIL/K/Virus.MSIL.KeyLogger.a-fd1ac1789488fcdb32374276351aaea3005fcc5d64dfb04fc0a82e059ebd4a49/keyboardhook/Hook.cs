using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace keyboardhook;

public static class Hook
{
	private static class API
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr SetWindowsHookEx(int idHook, HookDel lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);
	}

	public enum VK
	{
		VK_LBUTTON = 1,
		VK_RBUTTON = 2,
		VK_MBUTTON = 4,
		VK_BACK = 8,
		VK_TAB = 9,
		VK_RETURN = 13,
		VK_SHIFT = 16,
		VK_CONTROL = 17,
		VK_PAUSE = 19,
		VK_CAPITAL = 20,
		VK_ESCAPE = 27,
		VK_SPACE = 32,
		VK_PRIOR = 33,
		VK_NEXT = 34,
		VK_END = 35,
		VK_HOME = 36,
		VK_LEFT = 37,
		VK_UP = 38,
		VK_RIGHT = 39,
		VK_DOWN = 40,
		VK_SNAPSHOT = 44,
		VK_INSERT = 45,
		VK_DELETE = 46,
		VK_0 = 48,
		VK_1 = 49,
		VK_2 = 50,
		VK_3 = 51,
		VK_4 = 52,
		VK_5 = 53,
		VK_6 = 54,
		VK_7 = 55,
		VK_8 = 56,
		VK_9 = 57,
		VK_A = 65,
		VK_B = 66,
		VK_C = 67,
		VK_D = 68,
		VK_E = 69,
		VK_F = 70,
		VK_G = 71,
		VK_H = 72,
		VK_I = 73,
		VK_J = 74,
		VK_K = 75,
		VK_L = 76,
		VK_M = 77,
		VK_N = 78,
		VK_O = 79,
		VK_P = 80,
		VK_Q = 81,
		VK_R = 82,
		VK_S = 83,
		VK_T = 84,
		VK_U = 85,
		VK_V = 86,
		VK_W = 87,
		VK_X = 88,
		VK_Y = 89,
		VK_Z = 90,
		VK_NUMPAD0 = 96,
		VK_NUMPAD1 = 97,
		VK_NUMPAD2 = 98,
		VK_NUMPAD3 = 99,
		VK_NUMPAD4 = 100,
		VK_NUMPAD5 = 101,
		VK_NUMPAD6 = 102,
		VK_NUMPAD7 = 103,
		VK_NUMPAD8 = 104,
		VK_NUMPAD9 = 105,
		VK_SEPERATOR = 108,
		VK_SUBTRACT = 109,
		VK_NPDECIMAL = 110,
		VK_DECIMAL = 190,
		VK_NPDIVIDE = 111,
		VK_DIVIDE = 191,
		VK_COMMA = 188,
		VK_COM = 192,
		VK_SUB = 189,
		VK_EQUAL = 187,
		VK_BACKSLASH = 220,
		VK_OPBRACKET = 219,
		VK_CLBRACKET = 221,
		VK_SEMICOLON = 186,
		VK_QUOTE = 222,
		VK_MULT = 106,
		VK_PLUS = 107,
		VK_WINDOW = 91,
		VK_WINDOW2 = 92,
		VK_F1 = 112,
		VK_F2 = 113,
		VK_F3 = 114,
		VK_F4 = 115,
		VK_F5 = 116,
		VK_F6 = 117,
		VK_F7 = 118,
		VK_F8 = 119,
		VK_F9 = 120,
		VK_F10 = 121,
		VK_F11 = 122,
		VK_F12 = 123,
		VK_NUMLOCK = 144,
		VK_SCROLL = 145,
		VK_LSHIFT = 160,
		VK_RSHIFT = 161,
		VK_LALT = 164,
		VK_RALT = 165,
		VK_BTNRTCLICK = 93,
		VK_LCONTROL = 162,
		VK_RCONTROL = 163
	}

	public delegate IntPtr HookDel(int nCode, IntPtr wParam, IntPtr lParam);

	public delegate void KeyHandler(IntPtr wParam, IntPtr lParam);

	private static IntPtr hhk = IntPtr.Zero;

	private static HookDel hd;

	private static KeyHandler kh;

	public static void CreateHook(KeyHandler _kh)
	{
		Process currentProcess = Process.GetCurrentProcess();
		ProcessModule mainModule = currentProcess.MainModule;
		hd = HookFunc;
		kh = _kh;
		hhk = API.SetWindowsHookEx(13, hd, API.GetModuleHandle(mainModule.ModuleName), 0u);
	}

	public static bool DestroyHook()
	{
		return API.UnhookWindowsHookEx(hhk);
	}

	private static IntPtr HookFunc(int nCode, IntPtr wParam, IntPtr lParam)
	{
		int num = wParam.ToInt32();
		if (nCode >= 0 && (num == 256 || num == 260))
		{
			kh(wParam, lParam);
		}
		return API.CallNextHookEx(hhk, nCode, wParam, lParam);
	}
}
