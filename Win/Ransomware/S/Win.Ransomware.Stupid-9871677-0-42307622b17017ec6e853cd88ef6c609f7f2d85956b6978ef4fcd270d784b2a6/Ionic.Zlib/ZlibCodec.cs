using System.Runtime.InteropServices;

namespace Ionic.Zlib;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
public sealed class ZlibCodec
{
	public byte[] InputBuffer;

	public int NextIn;

	public int AvailableBytesIn;

	public long TotalBytesIn;

	public byte[] OutputBuffer;

	public int NextOut;

	public int AvailableBytesOut;

	public long TotalBytesOut;

	public string Message;

	internal DeflateManager dstate;

	internal InflateManager istate;

	internal uint _Adler32;

	public CompressionLevel CompressLevel;

	public int WindowBits;

	public CompressionStrategy Strategy;

	public unsafe int Adler32
	{
		get
		{
			//IL_0006: Expected native int or pointer, but got F4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Invalid comparison between Unknown and I4
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			int num3;
			do
			{
				double num = *(double*)unchecked((nint)(-3.0598125E+13f));
				int num2 = checked((int)((double[])/*Error near IL_0008: Stack underflow*/)[num]);
				num3 = /*Error near IL_000b: Stack underflow*/^ num2;
			}
			while ((int)/*Error near IL_0011: Stack underflow*/ > num3);
			_ = /*Error near IL_0012: Stack underflow*/>> (int)/*Error near IL_0012: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	public extern ZlibCodec();

	public extern ZlibCodec(CompressionMode mode);

	public extern int InitializeInflate();

	public extern int InitializeInflate(bool expectRfc1950Header);

	public extern int InitializeInflate(int windowBits);

	public extern int InitializeInflate(int windowBits, bool expectRfc1950Header);

	public int Inflate(FlushType flush)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0014
		//IL_0008: Invalid comparison between Unknown and I4
		/*Error: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public extern int EndInflate();

	public extern int SyncInflate();

	public int InitializeDeflate()
	{
		//IL_0004: Expected O, but got I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		this = (ZlibCodec)checked((uint)/*Error near IL_0001: Stack underflow*/);
		_003F val = /*Error near IL_0005: Stack underflow*/% /*Error near IL_0005: Stack underflow*/;
		checked
		{
			_ = (long)unchecked(-(/*Error near IL_0006: Stack underflow*/ >> (int)val));
			/*Error: Unexpected end of block*/;
		}
	}

	public extern int InitializeDeflate(CompressionLevel level);

	public extern int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header);

	public int InitializeDeflate(CompressionLevel level, int bits)
	{
		//Discarded unreachable code: IL_0002
		//IL_0012: Expected I4, but got I8
		/*Error near IL_0001: Unknown opcode: 0xF9*/;
	}

	public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
	{
		//Discarded unreachable code: IL_0009, IL_000f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (long)(/*Error near IL_0001: Stack underflow*/ & /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	private extern int _InternalInitializeDeflate(bool wantRfc1950Header);

	public extern int Deflate(FlushType flush);

	public extern int EndDeflate();

	public extern void ResetDeflate();

	public extern int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy);

	public extern int SetDictionary(byte[] dictionary);

	internal void flush_pending()
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0013
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	internal extern int read_buf(byte[] buf, int start, int size);
}
