using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PenterWare.Utils;

internal class CryptoUtils
{
	public static string SHA256File(string filepath)
	{
		string empty = string.Empty;
		if (File.Exists(filepath))
		{
			using (SHA256 sHA = SHA256.Create())
			{
				using FileStream inputStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				return HashBytesToString(sHA.ComputeHash(inputStream));
			}
		}
		return empty;
	}

	public static string HashBytesToString(byte[] hashBytes)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < hashBytes.Length; i++)
		{
			stringBuilder.Append(hashBytes[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}
}
