using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace CYMMwi9zGBGeGSvfYuB2;

public class hWm1w3KbI0E346
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref kOi523r7DYBk45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref kOi523r7DYBk45 lpDevMode, int dwFlags);

	public static kOi523r7DYBk45 aMeWvH7k9flM215()
	{
		kOi523r7DYBk45 kOi523r7DYBk46 = default(kOi523r7DYBk45);
		kOi523r7DYBk46.dmDeviceName = new string(new char[32]);
		kOi523r7DYBk46.dmFormName = new string(new char[32]);
		kOi523r7DYBk46.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)kOi523r7DYBk46)));
		return kOi523r7DYBk46;
	}
}
