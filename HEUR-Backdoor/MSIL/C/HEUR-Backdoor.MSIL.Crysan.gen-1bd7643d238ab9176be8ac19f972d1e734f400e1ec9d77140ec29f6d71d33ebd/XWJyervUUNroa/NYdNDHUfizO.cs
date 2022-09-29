using System.Security.Cryptography;
using System.Text;

namespace XWJyervUUNroa;

public static class NYdNDHUfizO
{
	public static string ikSzAtlGnRZDw(string nazptMITzhoko)
	{
		byte[] array = Encoding.UTF8.GetBytes(nazptMITzhoko);
		using (SHA256Managed sHA256Managed = new SHA256Managed())
		{
			array = sHA256Managed.ComputeHash(array);
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString().ToUpper();
	}

	public static byte[] XYElysCTzJwdKa(byte[] eJrOVUbYKSOxoYd)
	{
		using SHA256Managed sHA256Managed = new SHA256Managed();
		return sHA256Managed.ComputeHash(eJrOVUbYKSOxoYd);
	}
}
