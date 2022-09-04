using System.Runtime.InteropServices;

public sealed class resolution
{
	private const int int_0 = -1;

	private const int int_1 = 1;

	private const long long_0 = 2L;

	private const int int_2 = 32;

	private const int int_3 = 32;

	private const int int_4 = 0;

	private const int int_5 = 1;

	private const int int_6 = -1;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumDisplaySettingsA(int int_7, int int_8, ref Form1.DEVMODE devmode_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ChangeDisplaySettingsA(ref Form1.DEVMODE devmode_0, long long_1);

	public static void changeRes(int theWidth, int theHeight)
	{
		Form1.DEVMODE devmode_ = default(Form1.DEVMODE);
		devmode_.dmDeviceName = new string(new char[33]);
		devmode_.dmFormName = new string(new char[33]);
		devmode_.dmSize = checked((short)Marshal.SizeOf(typeof(Form1.DEVMODE)));
		if (0 != EnumDisplaySettingsA(0, -1, ref devmode_))
		{
			devmode_.dmPelsWidth = theWidth;
			devmode_.dmPelsHeight = theHeight;
			devmode_.dmPelsWidth = theWidth;
			devmode_.dmPelsHeight = theHeight;
			int num = ChangeDisplaySettingsA(ref devmode_, 2L);
			if (num != -1)
			{
				num = ChangeDisplaySettingsA(ref devmode_, 1L);
			}
		}
	}
}
