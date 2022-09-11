using System;

namespace White.Core.WindowsAPI;

public struct KeyboardInput
{
	public enum KeyUpDown
	{
		KEYEVENTF_KEYDOWN,
		KEYEVENTF_EXTENDEDKEY,
		KEYEVENTF_KEYUP
	}

	public enum SpecialKeys
	{
		SHIFT = 16,
		CONTROL = 17,
		ALT = 18,
		LEFT_ALT = 164,
		RIGHT_ALT = 165,
		RETURN = 13,
		RIGHT = 39,
		BACKSPACE = 8,
		LEFT = 37,
		ESCAPE = 27,
		TAB = 9,
		HOME = 36,
		END = 35,
		UP = 38,
		DOWN = 40,
		INSERT = 45,
		DELETE = 46,
		CAPS = 20,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		PAGEUP = 33,
		PAGEDOWN = 34,
		PRINT = 42,
		PRINTSCREEN = 44,
		SPACE = 32,
		NUMLOCK = 144,
		SCROLL = 145,
		LWIN = 91,
		RWIN = 92
	}

	private readonly short wVk;

	private readonly short wScan;

	private readonly KeyUpDown dwFlags;

	private readonly int time;

	private readonly IntPtr dwExtraInfo;

	public KeyboardInput(short wVk, KeyUpDown dwFlags, IntPtr dwExtraInfo)
	{
		this.wVk = wVk;
		wScan = 0;
		this.dwFlags = dwFlags;
		time = 0;
		this.dwExtraInfo = dwExtraInfo;
	}
}
