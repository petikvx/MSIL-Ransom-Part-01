using System;
using System.Runtime.InteropServices;

namespace Analysis;

public static class PrintColor
{
	public static string GRAY = "\u001b[1;37m";

	public static string DGRAY = "\u001b[1;90m";

	private static string RED = "\u001b[1;31m";

	public static string LRED = "\u001b[1;31m";

	private static string GREEN = "\u001b[1;32m";

	private static string LGREEN = "\u001b[1;32m";

	public static string YELLOW = "\u001b[33m";

	private static string LYELLOW = "\u001b[1;33m";

	private static string BLUE = "\u001b[34m";

	public static string LBLUE = "\u001b[1;34m";

	private static string MAGENTA = "\u001b[1:35m";

	private static string CYAN = "\u001b[36m";

	private static string LCYAN = "\u001b[1;36m";

	public static string NOCOLOR = "\u001b[0m";

	public static string ansi_color_bad = RED;

	public static string ansi_color_good = GREEN;

	public static string ansi_color_gray = GRAY;

	public static string ansi_color_yellow = YELLOW;

	public static string ansi_users_active = CYAN;

	public static string ansi_users_disabled = BLUE;

	public static string ansi_current_user = MAGENTA;

	private const int STD_OUTPUT_HANDLE = -11;

	[DllImport("Kernel32.dll")]
	private static extern int SetConsoleTextAttribute(IntPtr hConsoleOutput, short wAttributes);

	[DllImport("Kernel32.dll")]
	private static extern IntPtr GetStdHandle(int nStdHandle);

	public static void PrintLineSeparator()
	{
		SetConsoleTextColor(ConTextColor.GRAY);
		Console.WriteLine("   =================================================================================================");
		Console.WriteLine();
	}

	public static void SetConsoleTextColor(ConTextColor color)
	{
		SetConsoleTextAttribute(GetStdHandle(-11), (short)color);
	}
}
