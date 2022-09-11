using System;
using System.Security.Cryptography;
using System.Text;

namespace tmhhYTpfSQZiU;

public static class pJGeopaXzOxDALp
{
	private static bool GmCqtGGnGpsg = false;

	private static readonly string xYUScEtgToCeJE = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+MCsyMkQwR3FjWG93ZDdQVGlUU0xaQ2ZpZloyb1RUT0JjZ3pzWk0zbDZVWS8ya2o2NGVReGJOV0F6azJDMTFseFQwUVh5SUd5bXNzVTZiMDVnVVVMUlprL3FtcWNhRWZNeEVzOWJaU2FoSFE4YVQvRXludFVHaXpqaVFWWXVqK05QOU9xRngveFdGa1FnQUpEakxXTEpjcjdNUGJBOWpnWFh6QkZkcXRGLzJFUmYzczBNR3RPdmxQT0tqVXg5NkY3bXBpbmphbUNkdW4zbFJ0YUVyRWRYTlh1eUVtVDdmdkh1aHVwRDVTNjI4U0NCSnlZeGVWQmVPVkxXNzFZRm5Ta0NhS0Ywb0o3bUhCRnN5by85dThTb21HNy9jZCtzS2oxTFVQRlFLMk8yMFNza282S2lvdE1KTHVHWk56K25tbDN3Q0FmTzVVak9NV3NCU3BvT3EvS3NRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string xQGIuBQpwzhHS(string string_0)
	{
		int nytfzYXfVOGZ = 0;
		string ROaMzYZPTcAb = "";
		RyzmzcfsMBzrSM(xYUScEtgToCeJE, out nytfzYXfVOGZ, out ROaMzYZPTcAb);
		byte[] inArray = ebTXlNaWjhHtgT(Encoding.UTF8.GetBytes(string_0), nytfzYXfVOGZ, ROaMzYZPTcAb);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ebTXlNaWjhHtgT(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = YviMvHesLFSyb(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!eETtHIIiVwiSp(int_0))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, GmCqtGGnGpsg);
	}

	private static int YviMvHesLFSyb(int int_0)
	{
		if (GmCqtGGnGpsg)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool eETtHIIiVwiSp(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void RyzmzcfsMBzrSM(string SEpGoVJxQq, out int nytfzYXfVOGZ, out string ROaMzYZPTcAb)
	{
		nytfzYXfVOGZ = 0;
		ROaMzYZPTcAb = "";
		if (SEpGoVJxQq == null || SEpGoVJxQq.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(SEpGoVJxQq);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				nytfzYXfVOGZ = int.Parse(array[0]);
				ROaMzYZPTcAb = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
