using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Y46XxIXpl2sZ2;

public class Ar20I46
{
	public const int ENUM_CURRENT_SETTINGS = -1;

	public const int DISP_CHANGE_SUCCESSFUL = 0;

	public const int DISP_CHANGE_BADDUALVIEW = -6;

	public const int DISP_CHANGE_BADFLAGS = -4;

	public const int DISP_CHANGE_BADMODE = -2;

	public const int DISP_CHANGE_BADPARAM = -5;

	public const int DISP_CHANGE_FAILED = -1;

	public const int DISP_CHANGE_NOTUPDATED = -3;

	public const int DISP_CHANGE_RESTART = 1;

	public const int DMDO_DEFAULT = 0;

	public const int DMDO_90 = 1;

	public const int DMDO_180 = 2;

	public const int DMDO_270 = 3;

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref gnt7045 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref gnt7045 lpDevMode, int dwFlags);

	public static gnt7045 smethod_0()
	{
		gnt7045 gnt7046 = default(gnt7045);
		gnt7046.dmDeviceName = new string(new char[32]);
		gnt7046.dmFormName = new string(new char[32]);
		gnt7046.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)gnt7046)));
		return gnt7046;
	}
}
