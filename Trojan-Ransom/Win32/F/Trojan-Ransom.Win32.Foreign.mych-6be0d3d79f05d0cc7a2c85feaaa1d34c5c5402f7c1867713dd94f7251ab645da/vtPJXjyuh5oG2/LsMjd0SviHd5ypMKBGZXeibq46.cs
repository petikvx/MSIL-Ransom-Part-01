using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace vtPJXjyuh5oG2;

public class LsMjd0SviHd5ypMKBGZXeibq46
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref y3VNrsB4j5LLdppQVTgQ6pBf45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref y3VNrsB4j5LLdppQVTgQ6pBf45 lpDevMode, int dwFlags);

	public static y3VNrsB4j5LLdppQVTgQ6pBf45 OHKZPFfZgiJtbMJOGzIih215()
	{
		y3VNrsB4j5LLdppQVTgQ6pBf45 y3VNrsB4j5LLdppQVTgQ6pBf46 = default(y3VNrsB4j5LLdppQVTgQ6pBf45);
		y3VNrsB4j5LLdppQVTgQ6pBf46.dmDeviceName = new string(new char[32]);
		y3VNrsB4j5LLdppQVTgQ6pBf46.dmFormName = new string(new char[32]);
		y3VNrsB4j5LLdppQVTgQ6pBf46.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)y3VNrsB4j5LLdppQVTgQ6pBf46)));
		return y3VNrsB4j5LLdppQVTgQ6pBf46;
	}
}
