using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Az0XUyIG2;

public class jPpGUqJn7WZ46
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref A7hFqCiFhwJ45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref A7hFqCiFhwJ45 lpDevMode, int dwFlags);

	public static A7hFqCiFhwJ45 EEOlPh2XZfW215()
	{
		A7hFqCiFhwJ45 a7hFqCiFhwJ = default(A7hFqCiFhwJ45);
		a7hFqCiFhwJ.dmDeviceName = new string(new char[32]);
		a7hFqCiFhwJ.dmFormName = new string(new char[32]);
		a7hFqCiFhwJ.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)a7hFqCiFhwJ)));
		return a7hFqCiFhwJ;
	}
}
