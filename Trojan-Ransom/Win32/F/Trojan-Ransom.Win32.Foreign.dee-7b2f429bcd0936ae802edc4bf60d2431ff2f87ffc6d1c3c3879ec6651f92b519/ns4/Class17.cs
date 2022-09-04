using System.Runtime.InteropServices;

namespace ns4;

internal class Class17
{
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

	public static void smethod_0()
	{
		string string_ = "Shell_traywnd";
		string string_2 = "";
		int int_ = FindWindowA(ref string_, ref string_2);
		SetWindowPos(int_, 0, 0, 0, 0, 0, 128);
	}
}
