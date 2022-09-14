using System.Security.Cryptography;
using System.Text;

namespace ns22;

public static class GClass30
{
	public static string smethod_0(string string_0)
	{
		byte[] array = Encoding.UTF8.GetBytes(string_0);
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

	public static byte[] smethod_1(byte[] byte_0)
	{
		using SHA256Managed sHA256Managed = new SHA256Managed();
		return sHA256Managed.ComputeHash(byte_0);
	}
}
