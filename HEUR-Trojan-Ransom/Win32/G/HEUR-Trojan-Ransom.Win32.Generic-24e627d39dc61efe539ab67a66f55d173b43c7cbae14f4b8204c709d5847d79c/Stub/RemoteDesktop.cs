using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Stub;

public class RemoteDesktop
{
	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool BitBlt(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, IntPtr intptr_1, int int_4, int int_5, uint uint_0);

	public static void Capture(Size size_0, int int_0)
	{
	}

	public static ImageCodecInfo GetEncoderInfo(string string_0)
	{
		return null;
	}

	static RemoteDesktop()
	{
		Class0.smethod_13();
	}
}
