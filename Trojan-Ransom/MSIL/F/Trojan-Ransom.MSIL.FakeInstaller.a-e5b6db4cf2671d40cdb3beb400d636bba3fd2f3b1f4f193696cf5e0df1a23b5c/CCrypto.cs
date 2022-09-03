using System.Security.Cryptography;
using System.Text;

public static class CCrypto
{
	public static string GetCrypted(int ini)
	{
		UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
		byte[] bytes = unicodeEncoding.GetBytes(ini.ToString());
		SHA1Managed sHA1Managed = new SHA1Managed();
		byte[] array = sHA1Managed.ComputeHash(bytes);
		string text = "";
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			text += b;
		}
		return text;
	}
}
