using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zip;

public class ZipInputStream : Stream
{
	private Stream _inputStream;

	private Encoding _provisionalAlternateEncoding;

	private ZipEntry _currentEntry;

	private bool _firstEntry;

	private bool _needSetup;

	private ZipContainer _container;

	private CrcCalculatorStream _crcStream;

	private long _LeftToRead;

	internal string _Password;

	private long _endOfEntry;

	private string _name;

	private bool _leaveUnderlyingStreamOpen;

	private bool _closed;

	private bool _findRequired;

	private bool _exceptionPending;

	public extern Encoding ProvisionalAlternateEncoding { get; set; }

	public int CodecBufferSize
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0009, IL_0015, IL_0023
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_001d: Expected O, but got I4
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				/*Error: stloc 0 (out-of-bounds)*/;
			}
		}
		[CompilerGenerated]
		set;
	}

	public extern string Password { set; }

	internal extern Stream ReadStream { get; }

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override long Length
	{
		get
		{
			//Discarded unreachable code: IL_000a, IL_0016, IL_001e, IL_0025, IL_002a, IL_002f, IL_0034
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0002: Stack underflow*/+ /*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	public override long Position
	{
		get
		{
			//Discarded unreachable code: IL_0011, IL_0018
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				ushort num;
				checked
				{
					num = (ushort)unchecked(/*Error near IL_0002: Stack underflow*/ / /*Error near IL_0002: Stack underflow*/);
				}
				_003F val = /*Error near IL_0004: Stack underflow*/% num;
				if (/*Error near IL_0009: Stack underflow*/ < val)
				{
					/*Error near IL_000a: ldarg 1 (out-of-bounds)*/;
					/*Error near IL_000b: stloc 2 (out-of-bounds)*/;
				}
			}
		}
		set; }

	public extern ZipInputStream(Stream stream);

	public extern ZipInputStream(string fileName);

	public ZipInputStream(Stream stream, bool leaveOpen)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_000c, IL_001c, IL_0026
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I8
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFC*/;
	}

	private extern void _Init(Stream stream, bool leaveOpen, string name);

	public unsafe override string ToString()
	{
		//IL_0003: Expected O, but got I4
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		return (string)(ushort)/*Error near IL_0002: Stack underflow*/;
	}

	private unsafe void SetupStream()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				short num = (short)unchecked((int)checked((uint)unchecked((int)(*(byte*)checked((sbyte)(ushort)/*Error near IL_0001: Stack underflow*/)))));
				_003F val = /*Error near IL_0007: Stack underflow*/* num;
				if (/*Error near IL_000c: Stack underflow*/ <= val)
				{
					/*Error: Could not find block for branch target IL_000c*/;
				}
			}
		}
	}

	public override extern int Read(byte[] buffer, int offset, int count);

	public extern ZipEntry GetNextEntry();

	protected override extern void Dispose(bool disposing);

	public override extern void Flush();

	public override void Write(byte[] buffer, int offset, int count)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0017, IL_001b, IL_0023, IL_002e, IL_0033
		//IL_0004: Incompatible stack heights: 0 vs 2
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Incompatible stack heights: 1 vs 0
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Incompatible stack heights: 0 vs 1
		while (true)
		{
			/*Error: ldloca 0 (out-of-bounds)*/;
		}
	}

	public override extern long Seek(long offset, SeekOrigin origin);

	public override void SetLength(long value)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0016
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Incompatible stack heights: 0 vs 1
		_ = /*Error near IL_0002: Stack underflow*/>> (int)/*Error near IL_0002: Stack underflow*/;
		_ = 6;
		/*Error near IL_0004: Invalid metadata token*/;
	}
}
