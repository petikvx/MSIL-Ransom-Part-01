using System;
using System.IO;
using Ionic.Crc;

namespace Ionic.Zlib;

internal class ZlibBaseStream : Stream
{
	internal enum StreamMode
	{
		Writer,
		Reader,
		Undefined
	}

	protected internal ZlibCodec _z;

	protected internal StreamMode _streamMode;

	protected internal FlushType _flushMode;

	protected internal ZlibStreamFlavor _flavor;

	protected internal CompressionMode _compressionMode;

	protected internal CompressionLevel _level;

	protected internal bool _leaveOpen;

	protected internal byte[] _workingBuffer;

	protected internal int _bufferSize;

	protected internal byte[] _buf1;

	protected internal Stream _stream;

	protected internal CompressionStrategy Strategy;

	private CRC32 crc;

	protected internal string _GzipFileName;

	protected internal string _GzipComment;

	protected internal DateTime _GzipMtime;

	protected internal int _gzipHeaderByteCount;

	private bool nomoreinput;

	internal unsafe int Crc32
	{
		get
		{
			while (true)
			{
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				if ((long)(~checked((ulong)unchecked((uint)/*Error near IL_0002: Stack underflow*/))) < (long)(short)null)
				{
					/*Error: Could not find block for branch target IL_000c*/;
				}
			}
		}
	}

	protected internal extern bool _wantCompress { get; }

	private extern ZlibCodec z { get; }

	private extern byte[] workingBuffer { get; }

	public override bool CanRead
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected I4, but got Unknown
			byte num = ((byte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			switch (/*Error near IL_0003: Stack underflow*/ / num)
			{
			default:
				;
				break;
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override long Length
	{
		get
		{
			//Discarded unreachable code: IL_000d, IL_000f, IL_0015, IL_001a, IL_0024, IL_0029
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I4, but got Unknown
			while (/*Error near IL_0008: Stack underflow*/ >= /*Error near IL_0008: Stack underflow*/)
			{
			}
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	public override extern long Position { get; set; }

	public extern ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen);

	public override extern void Write(byte[] buffer, int offset, int count);

	private unsafe void finish()
	{
		//IL_0010: Expected F8, but got I4
		//IL_0014: Expected I8, but got I4
		//IL_0016: Invalid comparison between Unknown and I4
		do
		{
			((double[])/*Error near IL_0002: ldloca 0 (out-of-bounds)*/)[(object)""] = 2.0;
			*(IntPtr*)(nint)/*Error near IL_0011: Stack underflow*/ = (IntPtr)4;
			short num = ((byte[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/];
			*(long*)(nint)/*Error near IL_0014: Stack underflow*/ = num;
		}
		while ((int)/*Error near IL_001b: Stack underflow*/ >= 6);
		ushort num2 = checked((ushort)/*Error near IL_001c: Stack underflow*/);
		((short[])/*Error near IL_001d: Stack underflow*/)[/*Error near IL_001d: Stack underflow*/] = (short)num2;
	}

	private extern void end();

	public override extern void Close();

	public unsafe override void Flush()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		switch (((ushort[])/*Error near IL_0004: Stack underflow*/)[4])
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	private extern string ReadZeroTerminatedString();

	private extern int _ReadAndValidateGzipHeader();

	public override extern int Read(byte[] buffer, int offset, int count);

	public static extern void CompressString(string s, Stream compressor);

	public static void CompressBuffer(byte[] b, Stream compressor)
	{
		//Discarded unreachable code: IL_0015, IL_001a, IL_001e, IL_0023, IL_0025, IL_002b, IL_0030, IL_0036, IL_0037
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I
		//IL_0029: Incompatible stack heights: 1 vs 0
		//IL_0029: Incompatible stack heights: 0 vs 1
		//IL_0038: Incompatible stack heights: 0 vs 1
		_003F val2;
		do
		{
			_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
			int num = ((int[])/*Error near IL_0003: Stack underflow*/)[val];
			val2 = /*Error near IL_0004: Stack underflow*/- num;
		}
		while (checked((short)(/*Error near IL_0005: Stack underflow*/ + val2)) == 0);
		checked
		{
			_ = (long)(sbyte)/*Error near IL_000c: ldarg 3 (out-of-bounds)*/;
			_ = 3;
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	public static extern string UncompressString(byte[] compressed, Stream decompressor);

	public static extern byte[] UncompressBuffer(byte[] compressed, Stream decompressor);
}
