using System.IO;

namespace Ionic.Zip;

public class CountingStream : Stream
{
	private Stream _s;

	private long _bytesWritten;

	private long _bytesRead;

	private long _initialOffset;

	public extern Stream WrappedStream { get; }

	public extern long BytesWritten { get; }

	public long BytesRead
	{
		get
		{
			checked
			{
				_ = (short)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0002: Invalid metadata token*/;
			}
		}
	}

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override extern long Length { get; }

	public long ComputedPosition
	{
		get
		{
			while (/*Error near IL_0008: Stack underflow*/ > /*Error near IL_0008: Stack underflow*/)
			{
			}
			long num = ((long[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
			_ = ((long[])/*Error near IL_000b: Stack underflow*/)[num];
			/*Error: Unexpected end of block*/;
		}
	}

	public override extern long Position { get; set; }

	public extern CountingStream(Stream stream);

	public extern void Adjust(long delta);

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern void Write(byte[] buffer, int offset, int count);

	public override extern void Flush();

	public override extern long Seek(long offset, SeekOrigin origin);

	public unsafe override void SetLength(long value)
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
