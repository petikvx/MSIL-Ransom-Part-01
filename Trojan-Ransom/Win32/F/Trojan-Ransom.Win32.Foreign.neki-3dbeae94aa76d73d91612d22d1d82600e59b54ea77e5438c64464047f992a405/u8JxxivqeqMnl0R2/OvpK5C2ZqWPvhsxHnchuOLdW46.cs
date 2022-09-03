using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace u8JxxivqeqMnl0R2;

public class OvpK5C2ZqWPvhsxHnchuOLdW46
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref ozvy9HIEbTbWk1GKtTouTlbU45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref ozvy9HIEbTbWk1GKtTouTlbU45 lpDevMode, int dwFlags);

	public static ozvy9HIEbTbWk1GKtTouTlbU45 EJDCfQKMneZToBYFuHmOajba215()
	{
		ozvy9HIEbTbWk1GKtTouTlbU45 ozvy9HIEbTbWk1GKtTouTlbU46 = default(ozvy9HIEbTbWk1GKtTouTlbU45);
		ozvy9HIEbTbWk1GKtTouTlbU46.dmDeviceName = new string(new char[32]);
		ozvy9HIEbTbWk1GKtTouTlbU46.dmFormName = new string(new char[32]);
		ozvy9HIEbTbWk1GKtTouTlbU46.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)ozvy9HIEbTbWk1GKtTouTlbU46)));
		return ozvy9HIEbTbWk1GKtTouTlbU46;
	}
}
