using System.Collections.Generic;
using System.Threading;

namespace Lexplorer;

internal class Class17 : Class13
{
	private Dictionary<string, int> keyboardCodes = new Dictionary<string, int>
	{
		{ "NONE", 0 },
		{ "LBUTTON", 1 },
		{ "RBUTTON", 2 },
		{ "CANCEL", 3 },
		{ "MBUTTON", 4 },
		{ "XBUTTON1", 5 },
		{ "XBUTTON2", 6 },
		{ "LBUTTON, XBUTTON2", 7 },
		{ "BACK", 8 },
		{ "TAB", 9 },
		{ "LINEFEED", 10 },
		{ "LBUTTON, LINEFEED", 11 },
		{ "CLEAR", 12 },
		{ "RETURN", 13 },
		{ "RBUTTON, CLEAR", 14 },
		{ "RBUTTON, RETURN", 15 },
		{ "SHIFTKEY", 16 },
		{ "CONTROLKEY", 17 },
		{ "MENU", 18 },
		{ "PAUSE", 19 },
		{ "CAPITAL", 20 },
		{ "KANAMODE", 21 },
		{ "RBUTTON, CAPITAL", 22 },
		{ "JUNJAMODE", 23 },
		{ "FINALMODE", 24 },
		{ "HANJAMODE", 25 },
		{ "RBUTTON, FINALMODE", 26 },
		{ "ESCAPE", 27 },
		{ "IMECONVERT", 28 },
		{ "IMENONCONVERT", 29 },
		{ "IMEACEEPT", 30 },
		{ "IMEMODECHANGE", 31 },
		{ "SPACE", 32 },
		{ "PAGEUP", 33 },
		{ "NEXT", 34 },
		{ "END", 35 },
		{ "HOME", 36 },
		{ "LEFT", 37 },
		{ "UP", 38 },
		{ "RIGHT", 39 },
		{ "DOWN", 40 },
		{ "SELECT", 41 },
		{ "PRINT", 42 },
		{ "EXECUTE", 43 },
		{ "PRINTSCREEN", 44 },
		{ "INSERT", 45 },
		{ "DELETE", 46 },
		{ "HELP", 47 },
		{ "D0", 48 },
		{ "D1", 49 },
		{ "D2", 50 },
		{ "D3", 51 },
		{ "D4", 52 },
		{ "D5", 53 },
		{ "D6", 54 },
		{ "D7", 55 },
		{ "D8", 56 },
		{ "D9", 57 },
		{ "RBUTTON, D8", 58 },
		{ "RBUTTON, D9", 59 },
		{ "MBUTTON, D8", 60 },
		{ "MBUTTON, D9", 61 },
		{ "XBUTTON2, D8", 62 },
		{ "XBUTTON2, D9", 63 },
		{ "64", 64 },
		{ "A", 65 },
		{ "B", 66 },
		{ "C", 67 },
		{ "D", 68 },
		{ "E", 69 },
		{ "F", 70 },
		{ "G", 71 },
		{ "H", 72 },
		{ "I", 73 },
		{ "J", 74 },
		{ "K", 75 },
		{ "L", 76 },
		{ "M", 77 },
		{ "N", 78 },
		{ "O", 79 },
		{ "P", 80 },
		{ "Q", 81 },
		{ "R", 82 },
		{ "S", 83 },
		{ "T", 84 },
		{ "U", 85 },
		{ "V", 86 },
		{ "W", 87 },
		{ "X", 88 },
		{ "Y", 89 },
		{ "Z", 90 },
		{ "LWIN", 91 },
		{ "RWIN", 92 },
		{ "APPS", 93 },
		{ "RBUTTON, RWIN", 94 },
		{ "SLEEP", 95 },
		{ "NUMPAD0", 96 },
		{ "NUMPAD1", 97 },
		{ "NUMPAD2", 98 },
		{ "NUMPAD3", 99 },
		{ "NUMPAD4", 100 },
		{ "NUMPAD5", 101 },
		{ "NUMPAD6", 102 },
		{ "NUMPAD7", 103 },
		{ "NUMPAD8", 104 },
		{ "NUMPAD9", 105 },
		{ "MULTIPLY", 106 },
		{ "ADD", 107 },
		{ "SEPARATOR", 108 },
		{ "SUBTRACT", 109 },
		{ "DECIMAL", 110 },
		{ "DIVIDE", 111 },
		{ "F1", 112 },
		{ "F2", 113 },
		{ "F3", 114 },
		{ "F4", 115 },
		{ "F5", 116 },
		{ "F6", 117 },
		{ "F7", 118 },
		{ "F8", 119 },
		{ "F9", 120 },
		{ "F10", 121 },
		{ "F11", 122 },
		{ "F12", 123 },
		{ "F13", 124 },
		{ "F14", 125 },
		{ "F15", 126 },
		{ "F16", 127 },
		{ "F17", 128 },
		{ "F18", 129 },
		{ "F19", 130 },
		{ "F20", 131 },
		{ "F21", 132 },
		{ "F22", 133 },
		{ "F23", 134 },
		{ "F24", 135 },
		{ "BACK, F17", 136 },
		{ "BACK, F18", 137 },
		{ "BACK, F19", 138 },
		{ "BACK, F20", 139 },
		{ "BACK, F21", 140 },
		{ "BACK, F22", 141 },
		{ "BACK, F23", 142 },
		{ "BACK, F24", 143 },
		{ "NUMLOCK", 144 },
		{ "SCROLL", 145 },
		{ "RBUTTON, NUMLOCK", 146 },
		{ "RBUTTON, SCROLL", 147 },
		{ "MBUTTON, NUMLOCK", 148 },
		{ "MBUTTON, SCROLL", 149 },
		{ "XBUTTON2, NUMLOCK", 150 },
		{ "XBUTTON2, SCROLL", 151 },
		{ "BACK, NUMLOCK", 152 },
		{ "BACK, SCROLL", 153 },
		{ "LINEFEED, NUMLOCK", 154 },
		{ "LINEFEED, SCROLL", 155 },
		{ "CLEAR, NUMLOCK", 156 },
		{ "CLEAR, SCROLL", 157 },
		{ "RBUTTON, CLEAR, NUMLOCK", 158 },
		{ "RBUTTON, CLEAR, SCROLL", 159 },
		{ "LSHIFTKEY", 160 },
		{ "RSHIFTKEY", 161 },
		{ "LCONTROLKEY", 162 },
		{ "RCONTROLKEY", 163 },
		{ "LMENU", 164 },
		{ "RMENU", 165 },
		{ "BROWSERBACK", 166 },
		{ "BROWSERFORWARD", 167 },
		{ "BROWSERREFRESH", 168 },
		{ "BROWSERSTOP", 169 },
		{ "BROWSERSEARCH", 170 },
		{ "BROWSERFAVORITES", 171 },
		{ "BROWSERHOME", 172 },
		{ "VOLUMEMUTE", 173 },
		{ "VOLUMEDOWN", 174 },
		{ "VOLUMEUP", 175 },
		{ "MEDIANEXTTRACK", 176 },
		{ "MEDIAPREVIOUSTRACK", 177 },
		{ "MEDIASTOP", 178 },
		{ "MEDIAPLAYPAUSE", 179 },
		{ "LAUNCHMAIL", 180 },
		{ "SELECTMEDIA", 181 },
		{ "LAUNCHAPPLICATION1", 182 },
		{ "LAUNCHAPPLICATION2", 183 },
		{ "BACK, MEDIANEXTTRACK", 184 },
		{ "BACK, MEDIAPREVIOUSTRACK", 185 },
		{ "OEM1", 186 },
		{ "OEMPLUS", 187 },
		{ "OEMCOMMA", 188 },
		{ "OEMMINUS", 189 },
		{ "OEMPERIOD", 190 },
		{ "OEMQUESTION", 191 },
		{ "OEMTILDE", 192 },
		{ "LBUTTON, OEMTILDE", 193 },
		{ "RBUTTON, OEMTILDE", 194 },
		{ "CANCEL, OEMTILDE", 195 },
		{ "MBUTTON, OEMTILDE", 196 },
		{ "XBUTTON1, OEMTILDE", 197 },
		{ "XBUTTON2, OEMTILDE", 198 },
		{ "LBUTTON, XBUTTON2, OEMTILDE", 199 },
		{ "BACK, OEMTILDE", 200 },
		{ "TAB, OEMTILDE", 201 },
		{ "LINEFEED, OEMTILDE", 202 },
		{ "LBUTTON, LINEFEED, OEMTILDE", 203 },
		{ "CLEAR, OEMTILDE", 204 },
		{ "RETURN, OEMTILDE", 205 },
		{ "RBUTTON, CLEAR, OEMTILDE", 206 },
		{ "RBUTTON, RETURN, OEMTILDE", 207 },
		{ "SHIFTKEY, OEMTILDE", 208 },
		{ "CONTROLKEY, OEMTILDE", 209 },
		{ "MENU, OEMTILDE", 210 },
		{ "PAUSE, OEMTILDE", 211 },
		{ "CAPITAL, OEMTILDE", 212 },
		{ "KANAMODE, OEMTILDE", 213 },
		{ "RBUTTON, CAPITAL, OEMTILDE", 214 },
		{ "JUNJAMODE, OEMTILDE", 215 },
		{ "FINALMODE, OEMTILDE", 216 },
		{ "HANJAMODE, OEMTILDE", 217 },
		{ "RBUTTON, FINALMODE, OEMTILDE", 218 },
		{ "OEMOPENBRACKETS", 219 },
		{ "OEM5", 220 },
		{ "OEM6", 221 },
		{ "OEM7", 222 },
		{ "OEM8", 223 },
		{ "SPACE, OEMTILDE", 224 },
		{ "PAGEUP, OEMTILDE", 225 },
		{ "OEMBACKSLASH", 226 },
		{ "LBUTTON, OEMBACKSLASH", 227 },
		{ "HOME, OEMTILDE", 228 },
		{ "PROCESSKEY", 229 },
		{ "MBUTTON, OEMBACKSLASH", 230 },
		{ "PACKET", 231 },
		{ "DOWN, OEMTILDE", 232 },
		{ "SELECT, OEMTILDE", 233 },
		{ "BACK, OEMBACKSLASH", 234 },
		{ "TAB, OEMBACKSLASH", 235 },
		{ "PRINTSCREEN, OEMTILDE", 236 },
		{ "BACK, PROCESSKEY", 237 },
		{ "CLEAR, OEMBACKSLASH", 238 },
		{ "BACK, PACKET", 239 },
		{ "D0, OEMTILDE", 240 },
		{ "D1, OEMTILDE", 241 },
		{ "SHIFTKEY, OEMBACKSLASH", 242 },
		{ "CONTROLKEY, OEMBACKSLASH", 243 },
		{ "D4, OEMTILDE", 244 },
		{ "SHIFTKEY, PROCESSKEY", 245 },
		{ "ATTN", 246 },
		{ "CRSEL", 247 },
		{ "EXSEL", 248 },
		{ "ERASEEOF", 249 },
		{ "PLAY", 250 },
		{ "ZOOM", 251 },
		{ "NONAME", 252 },
		{ "PA1", 253 },
		{ "OEMCLEAR", 254 },
		{ "LBUTTON, OEMCLEAR", 255 }
	};

	private int GetKeyCode(string keycode)
	{
		int result = 0;
		if (int.TryParse(keycode, out result))
		{
			return result;
		}
		if (keyboardCodes.ContainsKey(keycode.ToUpper()))
		{
			return keyboardCodes[keycode.ToUpper()];
		}
		return -1;
	}

	public Class17()
	{
		methodTable.Add("KEYDOWN", KeyDown);
		methodTable.Add("KEYUP", KeyUp);
		methodTable.Add("KEYPRESS", KeyPress);
	}

	private bool KeyDown(Class10 props, bool forced)
	{
		int num = 0;
		int num2 = int.Parse(props["D"]);
		try
		{
			num = GetKeyCode(props["V"]);
		}
		catch
		{
			return false;
		}
		Class3.KeyDown(num);
		if (num2 > 0)
		{
			Thread.Sleep(num2);
		}
		return true;
	}

	private bool KeyUp(Class10 props, bool forced)
	{
		int num = int.Parse(props["D"]);
		int num2 = 0;
		try
		{
			num2 = GetKeyCode(props["V"]);
		}
		catch
		{
			return false;
		}
		Class3.KeyUp(num2);
		if (num > 0)
		{
			Thread.Sleep(num);
		}
		return true;
	}

	private bool KeyPress(Class10 props, bool forced)
	{
		int num = 0;
		try
		{
			num = GetKeyCode(props["V"]);
		}
		catch
		{
			return false;
		}
		Class3.KeyDown(num);
		Thread.Sleep(100);
		Class3.KeyUp(num);
		return true;
	}

	public override string ToString()
	{
		return $"Command type: KEYBOARD, Method={base.ExecutionMethodName}";
	}
}
