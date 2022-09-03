using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace GHs4oIAglbclBqBUl2;

public class IkADlZEhIN46
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref cg6L80I9Pz45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref cg6L80I9Pz45 lpDevMode, int dwFlags);

	public static cg6L80I9Pz45 s0JPOjP6xv215()
	{
		cg6L80I9Pz45 cg6L80I9Pz46 = default(cg6L80I9Pz45);
		cg6L80I9Pz46.dmDeviceName = new string(new char[32]);
		cg6L80I9Pz46.dmFormName = new string(new char[32]);
		cg6L80I9Pz46.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)cg6L80I9Pz46)));
		return cg6L80I9Pz46;
	}
}
