using System;
using System.Runtime.InteropServices;

public sealed class ToggleDesktopIcon
{
	private enum Enum4 : uint
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6
	}

	private enum Enum5
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = 5,
		const_6 = 6,
		const_7 = 7,
		const_8 = 8,
		const_9 = 9,
		const_10 = 10,
		const_11 = 11,
		const_12 = 11
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr intptr_0, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	public static void Toggle(bool z)
	{
		IntPtr intptr_ = FindWindow("ProgMan", null);
		intptr_ = GetWindow(intptr_, 5u);
		if (!z)
		{
			ShowWindow(intptr_, 0);
		}
		else
		{
			ShowWindow(intptr_, 4);
		}
	}
}
