using Ionic.Crc;

namespace Ionic.Zip;

internal class ZipCrypto
{
	private uint[] _Keys;

	private CRC32 crc32;

	private extern byte MagicByte { get; }

	private extern ZipCrypto();

	public static extern ZipCrypto ForWrite(string password);

	public static ZipCrypto ForRead(string password, ZipEntry e)
	{
		//Discarded unreachable code: IL_000b, IL_000e, IL_0013, IL_001f, IL_0026
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between I4 and Unknown
		_ = ((int[])/*Error near IL_0002: Stack underflow*/)[3];
		_ = ~checked((nint)/*Error near IL_0004: Stack underflow*/);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public extern byte[] DecryptMessage(byte[] cipherText, int length);

	public extern byte[] EncryptMessage(byte[] plainText, int length);

	public extern void InitCipher(string passphrase);

	private extern void UpdateKeys(byte byteValue);
}
