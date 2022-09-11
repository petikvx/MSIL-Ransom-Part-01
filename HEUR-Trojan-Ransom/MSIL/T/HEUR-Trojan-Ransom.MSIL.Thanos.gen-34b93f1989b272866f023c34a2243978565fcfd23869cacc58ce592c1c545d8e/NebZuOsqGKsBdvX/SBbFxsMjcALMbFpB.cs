using System;
using System.Security.Cryptography;
using System.Text;

namespace NebZuOsqGKsBdvX;

public static class SBbFxsMjcALMbFpB
{
	private static bool ohiOrfahRieW = false;

	private static readonly string LbirWOnykY = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+MCsyMkQwR3FjWG93ZDdQVGlUU0xaQ2ZpZloyb1RUT0JjZ3pzWk0zbDZVWS8ya2o2NGVReGJOV0F6azJDMTFseFQwUVh5SUd5bXNzVTZiMDVnVVVMUlprL3FtcWNhRWZNeEVzOWJaU2FoSFE4YVQvRXludFVHaXpqaVFWWXVqK05QOU9xRngveFdGa1FnQUpEakxXTEpjcjdNUGJBOWpnWFh6QkZkcXRGLzJFUmYzczBNR3RPdmxQT0tqVXg5NkY3bXBpbmphbUNkdW4zbFJ0YUVyRWRYTlh1eUVtVDdmdkh1aHVwRDVTNjI4U0NCSnlZeGVWQmVPVkxXNzFZRm5Ta0NhS0Ywb0o3bUhCRnN5by85dThTb21HNy9jZCtzS2oxTFVQRlFLMk8yMFNza282S2lvdE1KTHVHWk56K25tbDN3Q0FmTzVVak9NV3NCU3BvT3EvS3NRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string FFibVRaXAx(string string_0)
	{
		int pivFjsKbfwP = 0;
		string GEDlTByoUilY = "";
		IHypgQaPUo(LbirWOnykY, out pivFjsKbfwP, out GEDlTByoUilY);
		byte[] inArray = ZnRqAKitIdwb(Encoding.UTF8.GetBytes(string_0), pivFjsKbfwP, GEDlTByoUilY);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ZnRqAKitIdwb(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int num = mlpjTswXpdo(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException($"Maximum data length is {num}", "data");
		}
		if (!JvJucMqLbGDb(int_0))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, ohiOrfahRieW);
	}

	private static int mlpjTswXpdo(int int_0)
	{
		if (ohiOrfahRieW)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool JvJucMqLbGDb(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void IHypgQaPUo(string RuzUlxyCtvRB, out int pivFjsKbfwP, out string GEDlTByoUilY)
	{
		pivFjsKbfwP = 0;
		GEDlTByoUilY = "";
		if (RuzUlxyCtvRB == null || RuzUlxyCtvRB.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(RuzUlxyCtvRB);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				pivFjsKbfwP = int.Parse(array[0]);
				GEDlTByoUilY = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
