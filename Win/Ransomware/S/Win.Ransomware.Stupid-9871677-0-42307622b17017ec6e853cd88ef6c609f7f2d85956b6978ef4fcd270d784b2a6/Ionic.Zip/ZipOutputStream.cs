using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip;

public class ZipOutputStream : Stream
{
	private EncryptionAlgorithm _encryption;

	private ZipEntryTimestamp _timestamp;

	internal string _password;

	private string _comment;

	private Stream _outputStream;

	private ZipEntry _currentEntry;

	internal Zip64Option _zip64;

	private Dictionary<string, ZipEntry> _entriesWritten;

	private int _entryCount;

	private ZipOption _alternateEncodingUsage;

	private Encoding _alternateEncoding;

	private bool _leaveUnderlyingStreamOpen;

	private bool _disposed;

	private bool _exceptionPending;

	private bool _anyEntriesUsedZip64;

	private bool _directoryNeededZip64;

	private CountingStream _outputCounter;

	private Stream _encryptor;

	private Stream _deflater;

	private CrcCalculatorStream _entryOutputStream;

	private bool _needToWriteEntryHeader;

	private string _name;

	private bool _DontIgnoreCase;

	internal ParallelDeflateOutputStream ParallelDeflater;

	private long _ParallelDeflateThreshold;

	private int _maxBufferPairs;

	public extern string Password { set; }

	public extern EncryptionAlgorithm Encryption { get; set; }

	public extern int CodecBufferSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CompressionStrategy Strategy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public ZipEntryTimestamp Timestamp
	{
		get; set
		{
			//Discarded unreachable code: IL_0002, IL_000f, IL_0012, IL_001b, IL_0028, IL_0031, IL_0036, IL_003b, IL_0043
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and F4
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			/*Error: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0001: Unknown opcode: 0xFD*/;
		}
	}

	public extern CompressionLevel CompressionLevel
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public CompressionMethod CompressionMethod
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
		}
	}

	public string Comment
	{
		get
		{
			//Discarded unreachable code: IL_000b
			while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
			}
			/*Error near IL_0006: Invalid metadata token*/;
		}
		set
		{
			//Discarded unreachable code: IL_0005, IL_0013, IL_0018, IL_0021
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}
	}

	public extern Zip64Option EnableZip64 { get; set; }

	public bool OutputUsedZip64
	{
		get
		{
			//Discarded unreachable code: IL_0006
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
		}
	}

	public extern bool IgnoreCase { get; set; }

	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool UseUnicodeAsNecessary
	{
		get
		{
			//Discarded unreachable code: IL_0011, IL_001c, IL_0025, IL_002a, IL_0030
			//IL_0001: Invalid comparison between Unknown and I
			//IL_000c: Incompatible stack heights: 0 vs 1
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I8, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got I4
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected I4, but got Unknown
			while (true)
			{
				nuint num = (nuint)/*Error near IL_0001: Stack underflow*/;
				if ((nint)/*Error near IL_0006: Stack underflow*/ <= (nint)num && /*Error near IL_000b: Stack underflow*/< /*Error near IL_000b: Stack underflow*/)
				{
					_ = (sbyte)/*Error near IL_000c: Stack underflow*/;
				}
			}
		}
		set; }

	[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
	public extern Encoding ProvisionalAlternateEncoding { get; set; }

	public unsafe Encoding AlternateEncoding
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_000f, IL_0016, IL_001e, IL_002b
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I
			//IL_0011: Invalid comparison between Unknown and O
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got I4
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			_ = *(uint*)(nint)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: Invalid metadata token*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error: Unexpected end of block*/;
		}
	}

	public extern ZipOption AlternateEncodingUsage { get; set; }

	public static extern Encoding DefaultEncoding { get; }

	public long ParallelDeflateThreshold
	{
		get
		{
			//Discarded unreachable code: IL_0008, IL_0017
			/*OpCode not supported: Ckfinite*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
		set
		{
			//Discarded unreachable code: IL_0006, IL_000b, IL_0013, IL_001a, IL_0026, IL_002b, IL_0036
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Invalid comparison between Unknown and I4
			_ = ~/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public extern int ParallelDeflateMaxBufferPairs { get; set; }

	internal extern Stream OutputStream { get; }

	internal extern string Name { get; }

	public override extern bool CanRead { get; }

	public override bool CanSeek
	{
		get
		{
			//Discarded unreachable code: IL_000b, IL_0010, IL_0014
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected F8, but got I4
			while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
			}
			checked
			{
				_ = /*Error near IL_0006: Stack underflow*/+ /*Error near IL_0006: Stack underflow*/;
				/*Error near IL_0006: Invalid metadata token*/;
			}
		}
	}

	public override extern bool CanWrite { get; }

	public override extern long Length { get; }

	public override extern long Position { get; set; }

	public unsafe ZipOutputStream(Stream stream)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Incompatible stack heights: 0 vs 1
		while (true)
		{
			short num = checked((short)/*Error: ldloc 2 (out-of-bounds)*/);
			if ((int)/*Error near IL_0007: Stack underflow*/ <= (int)num)
			{
				_ = /*Error near IL_0008: Stack underflow*/<< (int)/*Error near IL_0008: Stack underflow*/;
				if (*(long*)(nint)/*Error near IL_0008: ldloc 1 (out-of-bounds)*/ == 0L)
				{
					break;
				}
			}
		}
		_ = ((Array)/*Error near IL_0011: Stack underflow*/).LongLength;
		_ = 876372547;
		/*Error: Unexpected end of block*/;
	}

	public extern ZipOutputStream(string fileName);

	public extern ZipOutputStream(Stream stream, bool leaveOpen);

	private extern void _Init(Stream stream, bool leaveOpen, string name);

	public override extern string ToString();

	private extern void InsureUniqueEntry(ZipEntry ze1);

	public extern bool ContainsEntry(string name);

	public override void Write(byte[] buffer, int offset, int count)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0016, IL_002a, IL_002f, IL_0035, IL_003a
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected F4, but got I4
		//IL_001f: Expected I4, but got O
		//IL_0022: Expected F8, but got I8
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	public extern ZipEntry PutNextEntry(string entryName);

	private extern void _InitiateCurrentEntry(bool finishing);

	private extern void _FinishCurrentEntry();

	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0006
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public override extern void Flush();

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);
}
