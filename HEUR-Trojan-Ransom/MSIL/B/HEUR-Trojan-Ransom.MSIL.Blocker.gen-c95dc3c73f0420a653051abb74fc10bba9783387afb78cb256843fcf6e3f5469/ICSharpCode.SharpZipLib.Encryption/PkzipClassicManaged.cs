using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption;

public sealed class PkzipClassicManaged : PkzipClassic
{
	private byte[] njyKTNIWKULdUAHpKWCLmsTjmYLr;

	public override int BlockSize
	{
		get
		{
			return 8;
		}
		set
		{
			if (value != 8)
			{
				throw new CryptographicException("Block size is invalid");
			}
		}
	}

	public override byte[] Key
	{
		get
		{
			if (njyKTNIWKULdUAHpKWCLmsTjmYLr == null)
			{
				GenerateKey();
			}
			return (byte[])njyKTNIWKULdUAHpKWCLmsTjmYLr.Clone();
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length != 12)
			{
				throw new CryptographicException("Key size is illegal");
			}
			njyKTNIWKULdUAHpKWCLmsTjmYLr = (byte[])value.Clone();
		}
	}

	public override KeySizes[] LegalBlockSizes => new KeySizes[1]
	{
		new KeySizes(8, 8, 0)
	};

	public override KeySizes[] LegalKeySizes => new KeySizes[1]
	{
		new KeySizes(96, 96, 0)
	};

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		njyKTNIWKULdUAHpKWCLmsTjmYLr = rgbKey;
		return new wlYAjnegygJlvaIJeQFUmgHiQYWHc(Key);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		njyKTNIWKULdUAHpKWCLmsTjmYLr = rgbKey;
		return new ShIttzIlmvEjBjrbkaEvgiNheXXI(Key);
	}

	public override void GenerateIV()
	{
	}

	public override void GenerateKey()
	{
		njyKTNIWKULdUAHpKWCLmsTjmYLr = new byte[12];
		new Random().NextBytes(njyKTNIWKULdUAHpKWCLmsTjmYLr);
	}
}
