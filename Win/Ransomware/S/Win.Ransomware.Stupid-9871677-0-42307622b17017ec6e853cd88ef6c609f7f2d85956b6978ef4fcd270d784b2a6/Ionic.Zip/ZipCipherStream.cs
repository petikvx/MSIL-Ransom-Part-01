using System.IO;

namespace Ionic.Zip;

internal class ZipCipherStream : Stream
{
	private ZipCrypto _cipher;

	private Stream _s;

	private CryptoMode _mode;

	public override extern bool CanRead { get; }

	public unsafe override bool CanSeek
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_000d, IL_001c
			//IL_0001: Invalid comparison between Unknown and F4
			//IL_0010: Expected F4, but got I4
			//IL_0016: Expected I4, but got I8
			float num;
			do
			{
				num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			}
			while (!((float)/*Error near IL_0003: Stack underflow*/ < num));
			*(_003F*)(nint)/*Error near IL_0022: Stack underflow*/ = /*Error near IL_0022: Stack underflow*/;
			/*Error near IL_0022: ldloc 0 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	public override bool CanWrite
	{
		get
		{
			//Discarded unreachable code: IL_0005
			while (true)
			{
			}
		}
	}

	public override extern long Length { get; }

	public override extern long Position { get; set; }

	public extern ZipCipherStream(Stream s, ZipCrypto cipher, CryptoMode mode);

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern void Write(byte[] buffer, int offset, int count);

	public override extern void Flush();

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);
}
