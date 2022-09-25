using System;
using System.IO;
using Ionic.Crc;

namespace Ionic.Zip;

internal class ZipCrypto
{
	private uint[] _Keys = new uint[3] { 305419896u, 591751049u, 878082192u };

	private CRC32 crc32 = new CRC32();

	private byte MagicByte
	{
		get
		{
			ushort num = (ushort)((ushort)(_Keys[2] & 0xFFFFu) | 2u);
			return (byte)(num * (num ^ 1) >> 8);
		}
	}

	private ZipCrypto()
	{
	}

	public static ZipCrypto ForWrite(string password)
	{
		ZipCrypto zipCrypto = new ZipCrypto();
		if (password == null)
		{
			throw new BadPasswordException("This entry requires a password.");
		}
		zipCrypto.InitCipher(password);
		return zipCrypto;
	}

	public static ZipCrypto ForRead(string password, ZipEntry e)
	{
		Stream archiveStream = e._archiveStream;
		e._WeakEncryptionHeader = new byte[12];
		byte[] weakEncryptionHeader = e._WeakEncryptionHeader;
		ZipCrypto zipCrypto = new ZipCrypto();
		if (password == null)
		{
			throw new BadPasswordException("This entry requires a password.");
		}
		zipCrypto.InitCipher(password);
		ZipEntry.ReadWeakEncryptionHeader(archiveStream, weakEncryptionHeader);
		byte[] array = zipCrypto.DecryptMessage(weakEncryptionHeader, weakEncryptionHeader.Length);
		if (array[11] != (byte)((e._Crc32 >> 24) & 0xFF))
		{
			if ((e._BitField & 8) != 8)
			{
				throw new BadPasswordException("The password did not match.");
			}
			if (array[11] != (byte)((e._TimeBlob >> 8) & 0xFF))
			{
				throw new BadPasswordException("The password did not match.");
			}
		}
		return zipCrypto;
	}

	public byte[] DecryptMessage(byte[] cipherText, int length)
	{
		if (cipherText == null)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (length > cipherText.Length)
		{
			throw new ArgumentOutOfRangeException("length", "Bad length during Decryption: the length parameter must be smaller than or equal to the size of the destination array.");
		}
		byte[] array = new byte[length];
		for (int i = 0; i < length; i++)
		{
			byte b = (byte)(cipherText[i] ^ MagicByte);
			UpdateKeys(b);
			array[i] = b;
		}
		return array;
	}

	public byte[] EncryptMessage(byte[] plainText, int length)
	{
		if (plainText == null)
		{
			throw new ArgumentNullException("plaintext");
		}
		if (length > plainText.Length)
		{
			throw new ArgumentOutOfRangeException("length", "Bad length during Encryption: The length parameter must be smaller than or equal to the size of the destination array.");
		}
		byte[] array = new byte[length];
		for (int i = 0; i < length; i++)
		{
			byte byteValue = plainText[i];
			array[i] = (byte)(plainText[i] ^ MagicByte);
			UpdateKeys(byteValue);
		}
		return array;
	}

	public void InitCipher(string passphrase)
	{
		byte[] array = SharedUtilities.StringToByteArray(passphrase);
		for (int i = 0; i < passphrase.Length; i++)
		{
			UpdateKeys(array[i]);
		}
	}

	private void UpdateKeys(byte byteValue)
	{
		_Keys[0] = (uint)crc32.ComputeCrc32((int)_Keys[0], byteValue);
		_Keys[1] = _Keys[1] + (byte)_Keys[0];
		_Keys[1] = _Keys[1] * 134775813 + 1;
		_Keys[2] = (uint)crc32.ComputeCrc32((int)_Keys[2], (byte)(_Keys[1] >> 24));
	}
}
