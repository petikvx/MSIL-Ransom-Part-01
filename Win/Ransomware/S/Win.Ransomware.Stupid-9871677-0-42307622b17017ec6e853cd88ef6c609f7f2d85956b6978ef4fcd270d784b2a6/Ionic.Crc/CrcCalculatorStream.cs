using System;
using System.IO;

namespace Ionic.Crc;

public class CrcCalculatorStream : Stream, IDisposable
{
	private static readonly long UnsetLengthLimit;

	internal Stream _innerStream;

	private CRC32 _Crc32;

	private long _lengthLimit;

	private bool _leaveOpen;

	public extern long TotalBytesSlurped { get; }

	public extern int Crc { get; }

	public extern bool LeaveOpen { get; set; }

	public override extern bool CanRead { get; }

	public unsafe override bool CanSeek
	{
		get
		{
			//Discarded unreachable code: IL_000e, IL_0013, IL_0018, IL_001d
			//IL_0004: Invalid comparison between Unknown and I4
			ushort num;
			do
			{
				num = *(ushort*)checked((sbyte)/*Error near IL_0001: Stack underflow*/);
			}
			while ((int)/*Error near IL_0009: Stack underflow*/ > (int)(byte)num);
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	public override bool CanWrite
	{
		get
		{
			//Discarded unreachable code: IL_000b, IL_0010, IL_0015, IL_001a, IL_001c, IL_0025, IL_002a, IL_0030, IL_0036
			//IL_002b: Invalid comparison between Unknown and I
			while (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/)
			{
			}
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public unsafe override long Length
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_000d, IL_0013, IL_0019, IL_002b, IL_002d
			//IL_000e: Invalid comparison between Unknown and I
			//IL_0026: Incompatible stack heights: 0 vs 1
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			_ = ~(*(float*)(nint)/*Error near IL_0001: Stack underflow*/);
			_ = 3;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public override long Position
	{
		get
		{
			//Discarded unreachable code: IL_0005
			/*Error: Invalid metadata token*/;
		}
		set
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_0015
			//IL_0007: Expected I8, but got I4
			//IL_0009: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}
	}

	public extern CrcCalculatorStream(Stream stream);

	public extern CrcCalculatorStream(Stream stream, bool leaveOpen);

	public extern CrcCalculatorStream(Stream stream, long length);

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0016, IL_001d
		_ = (nuint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32);

	private extern CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32);

	public override int Read(byte[] buffer, int offset, int count)
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_001d, IL_0026, IL_002b, IL_002e, IL_0033, IL_003b, IL_0040
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got F4
		//IL_0043: Invalid comparison between I4 and Unknown
		short num = checked((short)/*Error near IL_0004: Stack underflow*/);
		_ = /*Error near IL_0005: Stack underflow*/- num;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public override extern void Write(byte[] buffer, int offset, int count);

	public override void Flush()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000c
		/*Error: Invalid metadata token*/;
	}

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	extern void IDisposable.Dispose();

	public override extern void Close();

	unsafe static CrcCalculatorStream()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
			{
				ushort num = (ushort)/*Error near IL_0008: Stack underflow*/;
				_003F val = /*Error near IL_0009: Stack underflow*// num;
				if (/*Error near IL_000c: Stack underflow*/ != val)
				{
					break;
				}
			}
		}
		_ = ((IntPtr[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/];
		/*Error near IL_0014: Invalid metadata token*/;
	}
}
