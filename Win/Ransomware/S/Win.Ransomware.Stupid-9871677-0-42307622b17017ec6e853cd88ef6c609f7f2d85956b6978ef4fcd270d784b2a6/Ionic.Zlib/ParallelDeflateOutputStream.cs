using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Ionic.Crc;

namespace Ionic.Zlib;

public class ParallelDeflateOutputStream : Stream
{
	[Flags]
	private enum TraceBits : uint
	{
		None = 0u,
		NotUsed1 = 1u,
		EmitLock = 2u,
		EmitEnter = 4u,
		EmitBegin = 8u,
		EmitDone = 0x10u,
		EmitSkip = 0x20u,
		EmitAll = 0x3Au,
		Flush = 0x40u,
		Lifecycle = 0x80u,
		Session = 0x100u,
		Synch = 0x200u,
		Instance = 0x400u,
		Compress = 0x800u,
		Write = 0x1000u,
		WriteEnter = 0x2000u,
		WriteTake = 0x4000u,
		All = uint.MaxValue
	}

	private static readonly int IO_BUFFER_SIZE_DEFAULT;

	private static readonly int BufferPairsPerCore;

	private List<WorkItem> _pool;

	private bool _leaveOpen;

	private bool emitting;

	private Stream _outStream;

	private int _maxBufferPairs;

	private int _bufferSize;

	private AutoResetEvent _newlyCompressedBlob;

	private object _outputLock;

	private bool _isClosed;

	private bool _firstWriteDone;

	private int _currentlyFilling;

	private int _lastFilled;

	private int _lastWritten;

	private int _latestCompressed;

	private int _Crc32;

	private CRC32 _runningCrc;

	private object _latestLock;

	private Queue<int> _toWrite;

	private Queue<int> _toFill;

	private long _totalBytesProcessed;

	private CompressionLevel _compressLevel;

	private volatile Exception _pendingException;

	private bool _handlingException;

	private object _eLock;

	private TraceBits _DesiredTrace;

	public CompressionStrategy Strategy
	{
		[CompilerGenerated]
		get
		{
			while (true)
			{
				if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/&& /*Error near IL_000a: Stack underflow*/< /*Error near IL_000a: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_000a*/;
				}
			}
		}
		[CompilerGenerated]
		private set;
	}

	public int MaxBufferPairs
	{
		get; set
		{
			//Discarded unreachable code: IL_000a, IL_0011
			while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
			}
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	public extern int BufferSize { get; set; }

	public int Crc32
	{
		get
		{
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
			}
			/*Error near IL_0005: ldloc 2 (out-of-bounds)*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public extern long BytesProcessed { get; }

	public unsafe override bool CanSeek
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected F8, but got I
			((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
			_003F val;
			checked
			{
				byte num = (byte)unchecked(/*Error near IL_0002: Stack underflow*/ % /*Error near IL_0002: Stack underflow*/);
				val = /*Error near IL_0005: Stack underflow*/- num;
			}
			sbyte num2 = *(sbyte*)(nint)checked(/*Error near IL_0009: Stack underflow*/ + unchecked((nuint)(ulong)val));
			nint num3 = (nint)3;
			((double[])/*Error near IL_000d: Stack underflow*/)[num2] = num3;
			switch (/*Error near IL_0012: Stack underflow*/)
			{
			default:
				;
				break;
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public unsafe override bool CanRead
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected F8, but got I
			_003F val = checked(/*Error near IL_0002: Stack underflow*/ - /*Error near IL_0002: Stack underflow*/);
			sbyte num = *(sbyte*)(nint)checked(/*Error near IL_0006: Stack underflow*/ + unchecked((nuint)(ulong)val));
			nint num2 = (nint)3;
			((double[])/*Error near IL_000a: Stack underflow*/)[num] = num2;
			switch (/*Error near IL_000f: Stack underflow*/)
			{
			default:
				;
				break;
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public unsafe override bool CanWrite
	{
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected F8, but got I
			nint num = (nint)/*Error near IL_0001: Stack underflow*/;
			sbyte num2 = *(sbyte*)(nint)checked(/*Error near IL_0003: Stack underflow*/ + num);
			nint num3 = (nint)3;
			((double[])/*Error near IL_0007: Stack underflow*/)[num2] = num3;
			switch (/*Error near IL_000c: Stack underflow*/)
			{
			default:
				;
				break;
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public override long Length
	{
		get
		{
			/*Error: Unexpected end of block*/;
		}
	}

	public override long Position
	{
		get
		{
			//Discarded unreachable code: IL_0010, IL_001a, IL_0020, IL_002c, IL_0031
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I8, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			_003F val;
			do
			{
				val = checked(/*Error near IL_0002: Stack underflow*/ * /*Error near IL_0002: Stack underflow*/* /*Error near IL_0002: ldloca 0 (out-of-bounds)*/);
			}
			while (/*Error near IL_000a: Stack underflow*/ != val);
			/*Error near IL_000b: Invalid metadata token*/;
		}
		set; }

	public extern ParallelDeflateOutputStream(Stream stream);

	public extern ParallelDeflateOutputStream(Stream stream, CompressionLevel level);

	public ParallelDeflateOutputStream(Stream stream, bool leaveOpen)
	{
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
	}

	public extern ParallelDeflateOutputStream(Stream stream, CompressionLevel level, bool leaveOpen);

	public extern ParallelDeflateOutputStream(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen);

	private extern void _InitializePoolOfWorkItems();

	public override extern void Write(byte[] buffer, int offset, int count);

	private void _FlushFinish()
	{
		//Discarded unreachable code: IL_0002, IL_0010, IL_0015, IL_001f
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got I4
		//IL_0020: Unsupported input type for neg.
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (uint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xF8*/;
		}
	}

	private extern void _Flush(bool lastInput);

	public override void Flush()
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	public override extern void Close();

	public new extern void Dispose();

	protected override void Dispose(bool disposing)
	{
		_ = (double)/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	public extern void Reset(Stream stream);

	private extern void EmitPendingBuffers(bool doAll, bool mustWait);

	private extern void _DeflateOne(object wi);

	private extern bool DeflateOneSegment(WorkItem workitem);

	[Conditional("Trace")]
	private extern void TraceOutput(TraceBits bits, string format, params object[] varParams);

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	unsafe static ParallelDeflateOutputStream()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0009: Expected O, but got I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		ushort num;
		checked
		{
			_ = (ulong)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
			num = (ushort)unchecked((sbyte)/*Error near IL_0003: Stack underflow*/);
		}
		if ((int)/*Error near IL_0006: Stack underflow*/ > (int)num)
		{
			byte num2 = checked((byte)/*Error near IL_0007: Stack underflow*/);
			((object[])/*Error near IL_0009: Stack underflow*/)[num2] = 8;
			_ = ((uint[])(ulong)(/*Error near IL_000a: Stack underflow*/ / /*Error near IL_000a: Stack underflow*/))[0.0 - *(double*)1u - 3];
			/*Error near IL_0015: Invalid metadata token*/;
		}
		throw /*Error near IL_0021: Stack underflow*/;
	}
}
