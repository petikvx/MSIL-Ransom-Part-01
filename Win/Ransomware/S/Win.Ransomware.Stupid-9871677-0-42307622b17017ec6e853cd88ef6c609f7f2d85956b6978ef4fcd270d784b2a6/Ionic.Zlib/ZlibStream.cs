using System.IO;

namespace Ionic.Zlib;

public class ZlibStream : Stream
{
	internal ZlibBaseStream _baseStream;

	private bool _disposed;

	public virtual extern FlushType FlushMode { get; set; }

	public extern int BufferSize { get; set; }

	public virtual extern long TotalIn { get; }

	public virtual extern long TotalOut { get; }

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override long Length
	{
		get
		{
			//Discarded unreachable code: IL_0007, IL_0014, IL_0019, IL_0024, IL_0029, IL_0030
			//IL_0003: Expected O, but got I4
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			_ = (int)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override extern long Position { get; set; }

	public extern ZlibStream(Stream stream, CompressionMode mode);

	public extern ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level);

	public extern ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen);

	public extern ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen);

	protected override extern void Dispose(bool disposing);

	public override extern void Flush();

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern long Seek(long offset, SeekOrigin origin);

	public override void SetLength(long value)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	public override extern void Write(byte[] buffer, int offset, int count);

	public static extern byte[] CompressString(string s);

	public static extern byte[] CompressBuffer(byte[] b);

	public static extern string UncompressString(byte[] compressed);

	public static extern byte[] UncompressBuffer(byte[] compressed);
}
