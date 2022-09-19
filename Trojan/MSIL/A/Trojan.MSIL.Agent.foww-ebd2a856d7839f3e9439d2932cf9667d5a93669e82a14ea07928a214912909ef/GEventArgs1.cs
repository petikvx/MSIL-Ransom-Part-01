using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GEventArgs1 : KeyPressEventArgs
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private int int_0;

	public bool IsNonChar
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public int Timestamp
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	internal GEventArgs1(char keyChar, int timestamp)
		: base(keyChar)
	{
		IsNonChar = keyChar == '\0';
		Timestamp = timestamp;
	}

	public GEventArgs1(char keyChar)
		: this(keyChar, Environment.TickCount)
	{
	}

	internal static IEnumerable<GEventArgs1> smethod_0(Struct1 data)
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
		Class11.smethod_1(virtualKeyCode, scanCode, 0, out var chars);
		if (chars != null)
		{
			char[] array = chars;
			foreach (char keyChar in array)
			{
				yield return new GEventArgs1(keyChar);
			}
		}
	}

	internal static IEnumerable<GEventArgs1> smethod_1(Struct1 data)
	{
		IntPtr wParam = data.WParam;
		IntPtr lParam = data.LParam;
		if ((int)wParam != 256)
		{
			yield break;
		}
		Struct2 keyboardHookStruct = (Struct2)Marshal.PtrToStructure(lParam, typeof(Struct2));
		int virtualKeyCode = keyboardHookStruct.int_0;
		int scanCode = keyboardHookStruct.int_1;
		int fuState = keyboardHookStruct.int_2;
		if (virtualKeyCode == 231)
		{
			char keyChar = (char)scanCode;
			yield return new GEventArgs1(keyChar, keyboardHookStruct.int_3);
			yield break;
		}
		Class11.smethod_1(virtualKeyCode, scanCode, fuState, out var chars);
		if (chars != null)
		{
			char[] array = chars;
			foreach (char keyChar2 in array)
			{
				yield return new GEventArgs1(keyChar2, keyboardHookStruct.int_3);
			}
		}
	}
}
