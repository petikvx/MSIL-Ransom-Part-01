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
		byte[] data;
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
			data = DecryptKey(text2 switch
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
			data = array;
		}
		switch (text)
		{
		default:
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Key '{0}' is not supported.", new object[1] { text }));
		case "SSH2 ENCRYPTED":
		{
			SshDataReader sshDataReader = new SshDataReader(data);
			if (sshDataReader.ReadUInt32() != 1064303083)
			{
				throw new SshException("Invalid SSH2 private key.");
			}
			sshDataReader.ReadUInt32();
			string text4 = sshDataReader.ReadString(SshData.Ascii);
			string text5 = sshDataReader.ReadString(SshData.Ascii);
			int num = (int)sshDataReader.ReadUInt32();
			byte[] data2;
			if (text5 == "none")
			{
				data2 = sshDataReader.ReadBytes(num);
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
				data2 = new TripleDesCipher(GetCipherKey(passPhrase, 24), new CbcCipherMode(new byte[8]), new PKCS7Padding()).Decrypt(sshDataReader.ReadBytes(num));
			}
			sshDataReader = new SshDataReader(data2);
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
		case "DSA":
			_key = new DsaKey(data);
			HostKey = new KeyHostAlgorithm("ssh-dss", _key);
			break;
		case "RSA":
			_key = new RsaKey(data);
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
