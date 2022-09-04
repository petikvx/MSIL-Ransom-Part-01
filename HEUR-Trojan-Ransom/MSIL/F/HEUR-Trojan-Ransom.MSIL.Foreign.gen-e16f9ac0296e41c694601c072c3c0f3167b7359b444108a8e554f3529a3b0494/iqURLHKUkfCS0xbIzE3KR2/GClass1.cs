using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace iqURLHKUkfCS0xbIzE3KR2;

public class GClass1
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref RSy6moxZBIfIir45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref RSy6moxZBIfIir45 lpDevMode, int dwFlags);

	public static RSy6moxZBIfIir45 TZZnz0wLRy7E5j215()
	{
		RSy6moxZBIfIir45 rSy6moxZBIfIir = default(RSy6moxZBIfIir45);
		rSy6moxZBIfIir.dmDeviceName = new string(new char[32]);
		rSy6moxZBIfIir.dmFormName = new string(new char[32]);
		rSy6moxZBIfIir.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)rSy6moxZBIfIir)));
		return rSy6moxZBIfIir;
	}
}
