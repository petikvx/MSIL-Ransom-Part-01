using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MOISHE.Core;

public class Session
{
	[CompilerGenerated]
	private RSAParameters A;

	[CompilerGenerated]
	private byte[] A;

	[CompilerGenerated]
	private byte[] a;

	public RSAParameters KeyPair
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
		[CompilerGenerated]
		set
		{
			this.A = value;
		}
	}

	public byte[] DEK
	{
		[CompilerGenerated]
		get
		{
			return A;
		}
		[CompilerGenerated]
		set
		{
			A = value;
		}
	}

	public byte[] IV
	{
		[CompilerGenerated]
		get
		{
			return a;
		}
		[CompilerGenerated]
		set
		{
			a = value;
		}
	}

	public Session(RSAParameters keypair)
		: this()
	{
		KeyPair = keypair;
	}

	public Session()
	{
		RefreshKey();
	}

	public void RefreshKey()
	{
		RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		byte[] array = new byte[32];
		byte[] array2 = new byte[16];
		randomNumberGenerator.GetBytes(array);
		randomNumberGenerator.GetBytes(array2);
		DEK = array;
		IV = array2;
	}

	public EncryptionMetadata CreateMetadata()
	{
		EncryptionMetadata encryptionMetadata = new EncryptionMetadata();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(KeyPair);
		encryptionMetadata.EncryptedKey = rSACryptoServiceProvider.Encrypt(DEK, fOAEP: false);
		encryptionMetadata.EncryptedIV = rSACryptoServiceProvider.Encrypt(IV, fOAEP: false);
		encryptionMetadata.PublicKey = ExportPublicKey();
		return encryptionMetadata;
	}

	public byte[] ExportPublicKey()
	{
		return KeyGenerator.ExportPublicKey(KeyPair);
	}

	public byte[] ExportPrivateKey()
	{
		return KeyGenerator.ExportPrivateKey(KeyPair);
	}

	public CryptoStream CreateEncryptor(Stream underlying, PaddingMode padding)
	{
		Aes aes = Aes.Create();
		aes.Padding = padding;
		return new CryptoStream(underlying, aes.CreateEncryptor(DEK, IV), CryptoStreamMode.Write);
	}

	public CryptoStream CreateDecryptor(Stream underlying, PaddingMode padding)
	{
		Aes aes = Aes.Create();
		aes.Padding = padding;
		return new CryptoStream(underlying, aes.CreateDecryptor(DEK, IV), CryptoStreamMode.Write);
	}
}
