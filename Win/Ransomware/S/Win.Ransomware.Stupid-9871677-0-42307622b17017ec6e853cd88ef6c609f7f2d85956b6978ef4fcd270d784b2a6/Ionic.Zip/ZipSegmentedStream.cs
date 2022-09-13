using System.IO;
using System.Runtime.CompilerServices;

namespace Ionic.Zip;

internal class ZipSegmentedStream : Stream
{
	private enum RwMode
	{
		None,
		ReadOnly,
		Write
	}

	private RwMode rwMode;

	private bool _exceptionPending;

	private string _baseName;

	private string _baseDir;

	private string _currentName;

	private string _currentTempName;

	private uint _currentDiskNumber;

	private uint _maxDiskNumber;

	private int _maxSegmentSize;

	private Stream _innerStream;

	public unsafe bool ContiguousWrite
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected F8, but got I4
			while (true)
			{
				if (/*Error near IL_0001: Stack underflow*/ << (int)/*Error near IL_0001: Stack underflow*/ != 0)
				{
					_003F val = /*Error near IL_0007: Stack underflow*/* /*Error near IL_0007: Stack underflow*/;
					if (/*Error near IL_000c: Stack underflow*/ != val)
					{
						break;
					}
				}
			}
			*(double*)(nint)checked(/*Error near IL_000d: Stack underflow*/ * /*Error near IL_000d: Stack underflow*/) = 3.0;
			return (byte)(int)/*OpCode not supported: Nop*/ != 0;
		}
		[CompilerGenerated]
		set;
	}

	public extern uint CurrentSegment { get; private set; }

	public extern string CurrentName { get; }

	public extern string CurrentTempName { get; }

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override bool CanWrite
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_0009
			//IL_0000: Unsupported input type for neg.
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = 0 - /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public unsafe override long Length
	{
		get
		{
			//Discarded unreachable code: IL_001a
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got F8
			while (true)
			{
				float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
				nuint num2 = checked((nuint)((sbyte[])/*Error near IL_0003: Stack underflow*/)[num]);
				_003F val = /*Error near IL_0005: Stack underflow*/| num2;
				sbyte num3 = *(sbyte*)6;
				short num4 = ((byte[])/*Error near IL_000e: Stack underflow*/)[val + num3];
				_003F val2 = /*Error near IL_0010: ldloc 3 (out-of-bounds)*/;
				((object[])/*Error near IL_0013: Stack underflow*/)[num4] = (double)val2;
				int num5 = checked((int)/*Error near IL_0014: Stack underflow*/);
				((int[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/] = num5;
			}
		}
	}

	public override extern long Position { get; set; }

	private extern ZipSegmentedStream();

	public static extern ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber);

	public static extern ZipSegmentedStream ForWriting(string name, int maxSegmentSize);

	public static extern Stream ForUpdate(string name, uint diskNumber);

	private extern string _NameForSegment(uint diskNumber);

	public extern uint ComputeSegment(int length);

	public unsafe override string ToString()
	{
		//IL_0007: Expected I8, but got I4
		sbyte num = ((sbyte[])/*Error near IL_0006: Stack underflow*/)[-2.4302392E+22f];
		*(long*)(nint)/*Error near IL_0007: Stack underflow*/ = num;
		_ = *(int*)(nint)/*Error near IL_0007: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private extern void _SetReadStream();

	public override extern int Read(byte[] buffer, int offset, int count);

	private extern void _SetWriteStream(uint increment);

	public override extern void Write(byte[] buffer, int offset, int count);

	public extern long TruncateBackward(uint diskNumber, long offset);

	public override extern void Flush();

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	protected override extern void Dispose(bool disposing);
}
