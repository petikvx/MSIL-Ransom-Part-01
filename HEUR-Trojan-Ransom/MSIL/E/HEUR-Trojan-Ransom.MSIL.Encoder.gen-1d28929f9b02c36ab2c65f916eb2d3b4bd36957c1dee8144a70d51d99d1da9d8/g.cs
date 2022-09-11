using System.Security.Cryptography;
using System.Text;

public class g : i
{
	public readonly object a = new UTF8Encoding();

	public byte[] b;

	public const uint c = 2654435769u;

	public byte[] EncryptionKey
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	public byte[] b()
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.KeySize = 192;
		tripleDESCryptoServiceProvider.GenerateKey();
		object key = tripleDESCryptoServiceProvider.Key;
		tripleDESCryptoServiceProvider.Dispose();
		EncryptionKey = (byte[])key;
		return (byte[])key;
	}

	public byte[] GetEncryptionKey()
	{
		return EncryptionKey;
	}

	public byte[] a(byte[] byte_0, byte[] byte_1)
	{
		try
		{
			return _003CModule_003E.a((object)this, (object)byte_0, (object)byte_1);
		}
		catch
		{
			return null;
		}
	}
}
