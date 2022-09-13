using System;
using System.IO;
using System.Text;

namespace Ionic.Zlib;

public class GZipStream : Stream
{
	public DateTime? LastModified;

	private int _headerByteCount;

	internal ZlibBaseStream _baseStream;

	private bool _disposed;

	private bool _firstReadDone;

	private string _FileName;

	private string _Comment;

	private int _Crc32;

	internal static readonly DateTime _unixEpoch;

	internal static readonly Encoding iso8859dash1;

	public extern string Comment { get; set; }

	public string FileName
	{
		get; set
		{
			//Discarded unreachable code: IL_0010, IL_0016, IL_001c, IL_0021, IL_0027, IL_0029, IL_002f
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Incompatible stack heights: 0 vs 2
			while (true)
			{
				IntPtr intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
				_003F val = /*Error near IL_0002: Stack underflow*// (nint)intPtr;
				_003F val2 = checked(/*Error near IL_0004: Stack underflow*/ + val);
				_ = ((object[])/*Error near IL_0006: Stack underflow*/)[(nint)val2];
				_ = 89;
			}
		}
	}

	public extern int Crc32 { get; }

	public virtual extern FlushType FlushMode { get; set; }

	public extern int BufferSize { get; set; }

	public virtual extern long TotalIn { get; }

	public virtual extern long TotalOut { get; }

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override extern long Length { get; }

	public override extern long Position { get; set; }

	public extern GZipStream(Stream stream, CompressionMode mode);

	public extern GZipStream(Stream stream, CompressionMode mode, CompressionLevel level);

	public extern GZipStream(Stream stream, CompressionMode mode, bool leaveOpen);

	public extern GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen);

	protected override extern void Dispose(bool disposing);

	public override extern void Flush();

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	public override extern void Write(byte[] buffer, int offset, int count);

	private extern int EmitHeader();

	public static byte[] CompressString(string s)
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_001b, IL_0020
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ != 0);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public static extern byte[] CompressBuffer(byte[] b);

	public static extern string UncompressString(byte[] compressed);

	public static extern byte[] UncompressBuffer(byte[] compressed);

	unsafe static GZipStream()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and F4
		while (true)
		{
			short num = (short)/*Error near IL_0001: Stack underflow*/;
			if (!((float)(/*Error near IL_0003: Stack underflow*/ / num) < *(float*)(nint)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/))
			{
				/*Error: Could not find block for branch target IL_000b*/;
			}
		}
	}
}
