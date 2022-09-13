using System;
using System.IO;

namespace Ionic.Zip;

internal class OffsetStream : Stream, IDisposable
{
	private long _originalPosition;

	private Stream _innerStream;

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override extern long Length { get; }

	public override extern long Position { get; set; }

	public extern OffsetStream(Stream s);

	public override int Read(byte[] buffer, int offset, int count)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0012
		//IL_0002: Expected O, but got I4
		//IL_0008: Invalid comparison between Unknown and I
		short num = (short)/*Error near IL_0001: Stack underflow*/;
		((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public override extern void Write(byte[] buffer, int offset, int count);

	public override extern void Flush();

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	extern void IDisposable.Dispose();

	public override extern void Close();
}
