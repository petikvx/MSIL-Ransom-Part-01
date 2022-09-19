using System.Security.Cryptography;
using System.Text;

public static class GClass31
{
	public static string smethod_0(string input)
	{
		byte[] array = Encoding.UTF8.GetBytes(input);
		using (SHA256Managed sHA256Managed = new SHA256Managed())
		{
			array = sHA256Managed.ComputeHash(array, 0, array.Length);
		}
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString().ToUpper();
	}
}
