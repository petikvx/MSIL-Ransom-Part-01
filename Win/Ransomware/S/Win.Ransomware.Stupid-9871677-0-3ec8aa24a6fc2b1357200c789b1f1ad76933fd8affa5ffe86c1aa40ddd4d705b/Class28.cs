using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class28
{
	private static readonly byte[] byte_0 = Encoding.ASCII.GetBytes("o6806642kbM7c5");

	public static string smethod_0(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("plainText");
		}
		if (string.IsNullOrEmpty(string_1))
		{
			throw new ArgumentNullException("sharedSecret");
		}
		string result = "";
		RijndaelManaged rijndaelManaged = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, byte_0);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
			memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
			using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				using StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.Write(string_0);
			}
			result = Convert.ToBase64String(memoryStream.ToArray());
			return result;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return result;
		}
		finally
		{
			rijndaelManaged?.Clear();
		}
	}
}
