using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace ns1;

public class GClass2
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref GStruct2 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref GStruct2 lpDevMode, int dwFlags);

	public static GStruct2 wGQw9rWcY6IJndbD215()
	{
		GStruct2 gStruct = default(GStruct2);
		gStruct.dmDeviceName = new string(new char[32]);
		gStruct.dmFormName = new string(new char[32]);
		gStruct.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)gStruct)));
		return gStruct;
	}
}
