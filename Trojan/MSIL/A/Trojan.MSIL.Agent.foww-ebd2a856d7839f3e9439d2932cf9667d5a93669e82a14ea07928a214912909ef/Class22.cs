using System;
using System.Collections.Generic;
using System.Windows.Forms;

internal class Class22
{
	private readonly byte[] byte_0;

	private Class22(byte[] keyboardStateNative)
	{
		byte_0 = keyboardStateNative;
	}

	public static Class22 smethod_0()
	{
		byte[] array = new byte[256];
		Class11.GetKeyboardState(array);
		return new Class22(array);
	}

	internal byte[] method_0()
	{
		return byte_0;
	}

	public bool method_1(Keys key)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(method_4(key));
	}

	public bool method_2(Keys key)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return smethod_2(method_4(key));
	}

	public bool method_3(IEnumerable<Keys> keys)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		foreach (Keys key in keys)
		{
			if (!method_1(key))
			{
				return true;
			}
		}
		return false;
	}

	private byte method_4(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)key;
		if (num < 0 || num > 255)
		{
			throw new ArgumentOutOfRangeException("key", key, "The value must be between 0 and 255.");
		}
		return byte_0[num];
	}

	private static bool smethod_1(byte value)
	{
		return value >> 7 != 0;
	}

	private static bool smethod_2(byte value)
	{
		return (value & 1) != 0;
	}
}
