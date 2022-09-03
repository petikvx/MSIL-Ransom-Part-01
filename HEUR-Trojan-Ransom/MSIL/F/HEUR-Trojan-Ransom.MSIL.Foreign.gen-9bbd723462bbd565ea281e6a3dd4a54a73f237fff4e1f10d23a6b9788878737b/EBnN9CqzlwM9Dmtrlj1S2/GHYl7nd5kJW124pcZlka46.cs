using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace EBnN9CqzlwM9Dmtrlj1S2;

public class GHYl7nd5kJW124pcZlka46
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
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref nJJGN4eenOboJqdJwbbL45 lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int ChangeDisplaySettings(ref nJJGN4eenOboJqdJwbbL45 lpDevMode, int dwFlags);

	public static nJJGN4eenOboJqdJwbbL45 g5dZZ5Q57KrBLVjD2i80215()
	{
		nJJGN4eenOboJqdJwbbL45 nJJGN4eenOboJqdJwbbL46 = default(nJJGN4eenOboJqdJwbbL45);
		nJJGN4eenOboJqdJwbbL46.dmDeviceName = new string(new char[32]);
		nJJGN4eenOboJqdJwbbL46.dmFormName = new string(new char[32]);
		nJJGN4eenOboJqdJwbbL46.dmSize = checked((short)Conversion.Fix(Marshal.SizeOf((object)nJJGN4eenOboJqdJwbbL46)));
		return nJJGN4eenOboJqdJwbbL46;
	}
}
