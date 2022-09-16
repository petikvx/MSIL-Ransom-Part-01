using System.Security.Cryptography;
using System.Text;

namespace qtFMSUyUZbDNyWbv;

public static class XetdJScssFcBdcy
{
	public static string omANRJYclmtHt(string ZibnSTxnRKOL)
	{
		byte[] array = Encoding.UTF8.GetBytes(ZibnSTxnRKOL);
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

	public static byte[] YcQJnubvdaF(byte[] YsfCsuDGueiG)
	{
		using SHA256Managed sHA256Managed = new SHA256Managed();
		return sHA256Managed.ComputeHash(YsfCsuDGueiG);
	}
}
