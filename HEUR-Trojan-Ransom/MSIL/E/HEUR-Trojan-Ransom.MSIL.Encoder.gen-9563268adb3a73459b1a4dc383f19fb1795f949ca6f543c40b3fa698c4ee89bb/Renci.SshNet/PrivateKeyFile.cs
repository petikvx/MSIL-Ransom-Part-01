using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Security;
using Renci.SshNet.Security.Cryptography;
using Renci.SshNet.Security.Cryptography.Ciphers;
using Renci.SshNet.Security.Cryptography.Ciphers.Modes;
using Renci.SshNet.Security.Cryptography.Ciphers.Paddings;

namespace Renci.SshNet;

public class PrivateKeyFile : IDisposable
{
	private class SshDataReader : SshData
	{
		public SshDataReader(byte[] data)
		{
			Load(data);
		}

		public new uint ReadUInt32()
		{
			return base.ReadUInt32();
		}

		public new string ReadString(Encoding encoding)
		{
			return base.ReadString(encoding);
		}

		public new byte[] ReadBytes(int length)
		{
			return base.ReadBytes(length);
		}

		public new byte[] ReadBytes()
		{
			return base.ReadBytes();
		}

		public BigInteger ReadBigIntWithBits()
		{
			int num = (int)base.ReadUInt32();
			num = (num + 7) / 8;
			byte[] array = base.ReadBytes(num);
			byte[] array2 = new byte[array.Length + 1];
			Buffer.BlockCopy(array, 0, array2, 1, array.Length);
			return new BigInteger(array2.Reverse());
		}

		protected override void LoadData()
		{
		}

		protected override void SaveData()
		{
		}
	}

	private static readonly Regex PrivateKeyRegex = new Regex("^-+ *BEGIN (?<keyName>\\w+( \\w+)*) PRIVATE KEY *-+\\r?\\n((Proc-Type: 4,ENCRYPTED\\r?\\nDEK-Info: (?<cipherName>[A-Z0-9-]+),(?<salt>[A-F0-9]+)\\r?\\n\\r?\\n)|(Comment: \"?[^\\r\\n]*\"?\\r?\\n))?(?<data>([a-zA-Z0-9/+=]{1,80}\\r?\\n)+)-+ *END \\k<keyName> PRIVATE KEY *-+", RegexOptions.Multiline | RegexOptions.Compiled);

	private Key _key;

	private bool _isDisposed;

	public HostAlgorithm HostKey { get; private set; }

	public PrivateKeyFile(Stream privateKey)
	{
		Open(privateKey, null);
	}

	public PrivateKeyFile(string fileName)
		: this(fileName, null)
	{
	}

	public PrivateKeyFile(string fileName, string passPhrase)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException("fileName");
		}
		using FileStream privateKey = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		Open(privateKey, passPhrase);
	}

	public PrivateKeyFile(Stream privateKey, string passPhrase)
	{
		Open(privateKey, passPhrase);
	}

	private void Open(Stream privateKey, string passPhrase)
	{
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		Match match;
		using (StreamReader streamReader = new StreamReader(privateKey))
		{
			string input = streamReader.ReadToEnd();
			match = PrivateKeyRegex.Match(input);
		}
		if (!match.Success)
		{
			throw new SshException("Invalid private key file.");
		}
		string text = match.Result("${keyName}");
		string text2 = match.Result("${cipherName}");
		string text3 = match.Result("${salt}");
		byte[] array = Convert.FromBase64String(match.Result("${data}"));
		byte[] array3;
		if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3))
		{
			if (string.IsNullOrEmpty(passPhrase))
			{
				throw new SshPassPhraseNullOrEmptyException("Private key is encrypted but passphrase is empty.");
			}
			byte[] array2 = new byte[text3.Length / 2];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Convert.ToByte(text3.Substring(i * 2, 2), 16);
			}
			array3 = DecryptKey(text2 switch
			{
				"AES-256-CBC" => new CipherInfo(256, (byte[] key, byte[] iv) => new AesCipher(key, new CbcCipherMode(iv), new PKCS7Padding())), 
				"AES-192-CBC" => new CipherInfo(192, (byte[] key, byte[] iv) => new AesCipher(key, new CbcCipherMode(iv), new PKCS7Padding())), 
				"AES-128-CBC" => new CipherInfo(128, (byte[] key, byte[] iv) => new AesCipher(key, new CbcCipherMode(iv), new PKCS7Padding())), 
				"DES-CBC" => new CipherInfo(64, (byte[] key, byte[] iv) => new DesCipher(key, new CbcCipherMode(iv), new PKCS7Padding())), 
				"DES-EDE3-CFB" => new CipherInfo(192, (byte[] key, byte[] iv) => new TripleDesCipher(key, new CfbCipherMode(iv), new PKCS7Padding())), 
				"DES-EDE3-CBC" => new CipherInfo(192, (byte[] key, byte[] iv) => new TripleDesCipher(key, new CbcCipherMode(iv), new PKCS7Padding())), 
				_ => throw new SshException(string.Format(CultureInfo.CurrentCulture, "Private key cipher \"{0}\" is not supported.", new object[1] { text2 })), 
			}, array, passPhrase, array2);
		}
		else
		{
			array3 = array;
		}
		switch (text)
		{
		case "SSH2 ENCRYPTED":
		{
			SshDataReader sshDataReader = new SshDataReader(array3);
			if (sshDataReader.ReadUInt32() != 1064303083)
			{
				throw new SshException("Invalid SSH2 private key.");
			}
			sshDataReader.ReadUInt32();
			string text4 = sshDataReader.ReadString(SshData.Ascii);
			string text5 = sshDataReader.ReadString(SshData.Ascii);
			int num = (int)sshDataReader.ReadUInt32();
			byte[] data;
			if (text5 == "none")
			{
				data = sshDataReader.ReadBytes(num);
			}
			else
			{
				if (!(text5 == "3des-cbc"))
				{
					throw new SshException($"Cipher method '{text2}' is not supported.");
				}
				if (string.IsNullOrEmpty(passPhrase))
				{
					throw new SshPassPhraseNullOrEmptyException("Private key is encrypted but passphrase is empty.");
				}
				data = new TripleDesCipher(GetCipherKey(passPhrase, 24), new CbcCipherMode(new byte[8]), new PKCS7Padding()).Decrypt(sshDataReader.ReadBytes(num));
			}
			sshDataReader = new SshDataReader(data);
			if (sshDataReader.ReadUInt32() > num - 4)
			{
				throw new SshException("Invalid passphrase.");
			}
			if (text4 == "if-modn{sign{rsa-pkcs1-sha1},encrypt{rsa-pkcs1v2-oaep}}")
			{
				BigInteger exponent = sshDataReader.ReadBigIntWithBits();
				BigInteger d = sshDataReader.ReadBigIntWithBits();
				BigInteger modulus = sshDataReader.ReadBigIntWithBits();
				BigInteger inverseQ = sshDataReader.ReadBigIntWithBits();
				BigInteger q = sshDataReader.ReadBigIntWithBits();
				BigInteger p = sshDataReader.ReadBigIntWithBits();
				_key = new RsaKey(modulus, exponent, d, p, q, inverseQ);
				HostKey = new KeyHostAlgorithm("ssh-rsa", _key);
				break;
			}
			if (text4 == "dl-modp{sign{dsa-nist-sha1},dh{plain}}")
			{
				if (sshDataReader.ReadUInt32() != 0)
				{
					throw new SshException("Invalid private key");
				}
				BigInteger p2 = sshDataReader.ReadBigIntWithBits();
				BigInteger g = sshDataReader.ReadBigIntWithBits();
				BigInteger q2 = sshDataReader.ReadBigIntWithBits();
				BigInteger y = sshDataReader.ReadBigIntWithBits();
				BigInteger x = sshDataReader.ReadBigIntWithBits();
				_key = new DsaKey(p2, q2, g, y, x);
				HostKey = new KeyHostAlgorithm("ssh-dss", _key);
				break;
			}
			throw new NotSupportedException($"Key type '{text4}' is not supported.");
		}
		case "OPENSSH":
			_key = ParseOpenSshV1Key(array3, passPhrase);
			HostKey = new KeyHostAlgorithm(_key.ToString(), _key);
			break;
		case "EC":
			_key = new EcdsaKey(array3);
			HostKey = new KeyHostAlgorithm(_key.ToString(), _key);
			break;
		case "DSA":
			_key = new DsaKey(array3);
			HostKey = new KeyHostAlgorithm("ssh-dss", _key);
			break;
		default:
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Key '{0}' is not supported.", new object[1] { text }));
		case "RSA":
			_key = new RsaKey(array3);
			HostKey = new KeyHostAlgorithm("ssh-rsa", _key);
			break;
		}
	}

	private static byte[] GetCipherKey(string passphrase, int length)
	{
		List<byte> list = new List<byte>();
		using (MD5 mD = CryptoAbstraction.CreateMD5())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(passphrase);
			byte[] array = mD.ComputeHash(bytes);
			list.AddRange(array);
			while (list.Count < length)
			{
				array = bytes.Concat(array);
				array = mD.ComputeHash(array);
				list.AddRange(array);
			}
		}
		return list.ToArray().Take(length);
	}

	private static byte[] DecryptKey(CipherInfo cipherInfo, byte[] cipherData, string passPhrase, byte[] binarySalt)
	{
		if (cipherInfo == null)
		{
			throw new ArgumentNullException("cipherInfo");
		}
		if (cipherData == null)
		{
			throw new ArgumentNullException("cipherData");
		}
		if (binarySalt == null)
		{
			throw new ArgumentNullException("binarySalt");
		}
		List<byte> list = new List<byte>();
		using (MD5 mD = CryptoAbstraction.CreateMD5())
		{
			byte[] array = Encoding.UTF8.GetBytes(passPhrase).Concat(binarySalt.Take(8));
			byte[] array2 = mD.ComputeHash(array);
			list.AddRange(array2);
			while (list.Count < cipherInfo.KeySize / 8)
			{
				array2 = array2.Concat(array);
				array2 = mD.ComputeHash(array2);
				list.AddRange(array2);
			}
		}
		return cipherInfo.Cipher(list.ToArray(), binarySalt).Decrypt(cipherData);
	}

	private ED25519Key ParseOpenSshV1Key(byte[] keyFileData, string passPhrase)
	{
		SshDataReader sshDataReader = new SshDataReader(keyFileData);
		byte[] bytes = Encoding.UTF8.GetBytes("openssh-key-v1\0");
		byte[] right = sshDataReader.ReadBytes(bytes.Length);
		if (!bytes.IsEqualTo(right))
		{
			throw new SshException("This openssh key does not contain the 'openssh-key-v1' format magic header");
		}
		string text = sshDataReader.ReadString(Encoding.UTF8);
		string text2 = sshDataReader.ReadString(Encoding.UTF8);
		uint num = sshDataReader.ReadUInt32();
		byte[] salt = null;
		int rounds = 0;
		if ((int)num > 0)
		{
			int length = (int)sshDataReader.ReadUInt32();
			salt = sshDataReader.ReadBytes(length);
			rounds = (int)sshDataReader.ReadUInt32();
		}
		if (sshDataReader.ReadUInt32() != 1)
		{
			throw new SshException("At this time only one public key in the openssh key is supported.");
		}
		sshDataReader.ReadUInt32();
		string text3 = sshDataReader.ReadString(Encoding.UTF8);
		if (text3 != "ssh-ed25519")
		{
			throw new SshException("openssh key type: " + text3 + " is not supported");
		}
		int length2 = (int)sshDataReader.ReadUInt32();
		byte[] array = sshDataReader.ReadBytes(length2);
		int length3 = (int)sshDataReader.ReadUInt32();
		byte[] array2 = sshDataReader.ReadBytes(length3);
		if (text == "aes256-cbc")
		{
			if (string.IsNullOrEmpty(passPhrase))
			{
				throw new SshPassPhraseNullOrEmptyException("Private key is encrypted but passphrase is empty.");
			}
			if (string.IsNullOrEmpty(text2) || text2 != "bcrypt")
			{
				throw new SshException("kdf " + text2 + " is not supported for openssh key file");
			}
			byte[] bytes2 = Encoding.UTF8.GetBytes(passPhrase);
			byte[] array3 = new byte[48];
			new BCrypt().Pbkdf(bytes2, salt, rounds, array3);
			byte[] array4 = new byte[32];
			Array.Copy(array3, 0, array4, 0, 32);
			byte[] array5 = new byte[16];
			Array.Copy(array3, 32, array5, 0, 16);
			array2 = new AesCipher(array4, new CbcCipherMode(array5), new PKCS7Padding()).Decrypt(array2);
		}
		else if (text != "none")
		{
			throw new SshException("cipher name " + text + " for openssh key file is not supported");
		}
		length3 = array2.Length;
		if (length3 % 8 != 0)
		{
			throw new SshException("The private key section must be a multiple of the block size (8)");
		}
		SshDataReader sshDataReader2 = new SshDataReader(array2);
		int num2 = (int)sshDataReader2.ReadUInt32();
		int num3 = (int)sshDataReader2.ReadUInt32();
		if (num2 != num3)
		{
			throw new SshException("The checkints differed, the openssh key was not correctly decoded.");
		}
		sshDataReader2.ReadString(Encoding.UTF8);
		int length4 = (int)sshDataReader2.ReadUInt32();
		sshDataReader2.ReadBytes(length4);
		sshDataReader2.ReadUInt32();
		byte[] sk = sshDataReader2.ReadBytes(32);
		sshDataReader2.ReadBytes(32);
		sshDataReader2.ReadString(Encoding.UTF8);
		byte[] array6 = sshDataReader2.ReadBytes();
		for (int i = 0; i < array6.Length; i++)
		{
			if (array6[i] != i + 1)
			{
				throw new SshException("Padding of openssh key format contained wrong byte at position: " + i);
			}
		}
		return new ED25519Key(array.Reverse(), sk);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed && disposing)
		{
			Key key = _key;
			if (key != null)
			{
				((IDisposable)key).Dispose();
				_key = null;
			}
			_isDisposed = true;
		}
	}

	~PrivateKeyFile()
	{
		Dispose(disposing: false);
	}
}
