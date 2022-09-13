using System;
using System.Runtime.InteropServices;

internal class Class35
{
	private const uint uint_0 = 13u;

	public static string smethod_0()
	{
		if (Class42.IsClipboardFormatAvailable(13u) && Class42.OpenClipboard(IntPtr.Zero))
		{
			string result = string.Empty;
			IntPtr clipboardData = Class42.GetClipboardData(13u);
			if (!clipboardData.Equals((object?)(nint)IntPtr.Zero))
			{
				IntPtr intPtr = Class42.GlobalLock(clipboardData);
				if (!intPtr.Equals((object?)(nint)IntPtr.Zero))
				{
					try
					{
						result = Marshal.PtrToStringUni(intPtr);
						Class42.GlobalUnlock(intPtr);
					}
					catch (Exception value)
					{
						Console.WriteLine(value);
					}
				}
			}
			Class42.CloseClipboard();
			return result;
		}
		return null;
	}
}
