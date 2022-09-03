using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace v0uQA2;

public class IE1I346
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref n5gQq45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref n5gQq45 lpDevMode, int dwFlags);

	public static n5gQq45 JXubH215()
	{
		n5gQq45 n5gQq46 = default(n5gQq45);
		n5gQq46.dmDeviceName = new string(new char[32]);
		n5gQq46.dmFormName = new string(new char[32]);
		n5gQq46.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)n5gQq46)));
		return n5gQq46;
	}
}
