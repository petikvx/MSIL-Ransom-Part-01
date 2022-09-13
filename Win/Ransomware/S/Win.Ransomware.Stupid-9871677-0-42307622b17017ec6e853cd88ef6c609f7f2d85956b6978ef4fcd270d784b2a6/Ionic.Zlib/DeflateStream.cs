using System.IO;

namespace Ionic.Zlib;

public class DeflateStream : Stream
{
	internal ZlibBaseStream _baseStream;

	internal Stream _innerStream;

	private bool _disposed;

	public virtual FlushType FlushMode
	{
		get
		{
			//Discarded unreachable code: IL_000b, IL_0011, IL_0016
			//IL_0006: Expected native int or pointer, but got O
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected F8, but got Unknown
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
			}
			_ = null;
			/*Error near IL_0006: Invalid metadata token*/;
		}
		set; }

	public extern int BufferSize { get; set; }

	public extern CompressionStrategy Strategy { get; set; }

	public virtual long TotalIn
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_000e
			//IL_0009: Invalid comparison between Unknown and I
			/*Error: Invalid metadata token*/;
		}
	}

	public virtual extern long TotalOut { get; }

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override extern long Length { get; }

	public override long Position
	{
		get
		{
			//Discarded unreachable code: IL_0015, IL_001f, IL_002a, IL_0031
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got I4
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/<= /*Error near IL_000a: Stack underflow*/|| (int)/*Error near IL_000f: Stack underflow*/ != 0)
			{
			}
			checked
			{
				_ = /*Error near IL_0010: Stack underflow*/* /*Error near IL_0010: Stack underflow*/;
				/*Error near IL_0010: Invalid metadata token*/;
			}
		}
		set; }

	public extern DeflateStream(Stream stream, CompressionMode mode);

	public extern DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level);

	public extern DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen);

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0016, IL_0017, IL_001c, IL_002c, IL_0032, IL_0038, IL_003d
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Incompatible stack heights: 0 vs 1
		//IL_002d: Expected native int or pointer, but got O
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected override extern void Dispose(bool disposing);

	public override void Flush()
	{
		//Discarded unreachable code: IL_0012, IL_0017, IL_001d, IL_0023, IL_002a, IL_0033, IL_0038
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got I4
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		_003F val = /*Error near IL_000a: Stack underflow*/^ 3;
		_ = ((uint[])/*Error near IL_000d: Stack underflow*/)[val];
		/*Error near IL_000d: Invalid metadata token*/;
	}

	public override extern int Read(byte[] buffer, int offset, int count);

	public override long Seek(long offset, SeekOrigin origin)
	{
		//Discarded unreachable code: IL_0005, IL_001a
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	public override extern void SetLength(long value);

	public unsafe override void Write(byte[] buffer, int offset, int count)
	{
		//IL_0007: Invalid comparison between Unknown and I4
		byte num;
		do
		{
			num = *(byte*)checked((short)(double)/*Error near IL_0002: Stack underflow*/);
		}
		while ((int)/*Error near IL_000c: Stack underflow*/ < (int)num);
	}

	public static extern byte[] CompressString(string s);

	public static extern byte[] CompressBuffer(byte[] b);

	public static extern string UncompressString(byte[] compressed);

	public static extern byte[] UncompressBuffer(byte[] compressed);
}
