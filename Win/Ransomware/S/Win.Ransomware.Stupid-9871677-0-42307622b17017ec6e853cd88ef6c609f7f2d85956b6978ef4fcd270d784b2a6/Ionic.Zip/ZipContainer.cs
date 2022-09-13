using System;
using System.IO;
using System.Text;
using Ionic.Zlib;

namespace Ionic.Zip;

internal class ZipContainer
{
	private ZipFile _zf;

	private ZipOutputStream _zos;

	private ZipInputStream _zis;

	public unsafe ZipFile ZipFile
	{
		get
		{
			IntPtr intPtr = *(IntPtr*)4;
			*(int*)(nint)/*Error near IL_0004: Stack underflow*/ = (int)(nint)intPtr;
			((sbyte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (sbyte)/*Error near IL_0006: Stack underflow*/;
			switch (/*Error near IL_000b: Stack underflow*/)
			{
			default:
				;
				break;
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public extern ZipOutputStream ZipOutputStream { get; }

	public extern string Name { get; }

	public unsafe string Password
	{
		get
		{
			//IL_0009: Expected I, but got O
			((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0001: ldloca 0 (out-of-bounds)*/;
			*(double*)(nint)/*Error near IL_0005: Stack underflow*/ = (double)val;
			*(IntPtr*)(nuint)/*Error near IL_0006: Stack underflow*/ = (IntPtr)null;
			return (string)/*Error near IL_000b: Stack underflow*/;
		}
	}

	public extern Zip64Option Zip64 { get; }

	public extern int BufferSize { get; }

	public ParallelDeflateOutputStream ParallelDeflater
	{
		get; set
		{
			//Discarded unreachable code: IL_0008, IL_0011
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				/*Error: stloc 0 (out-of-bounds)*/;
				/*Error near IL_0002: ldloc 3 (out-of-bounds)*/;
			}
		}
	}

	public extern long ParallelDeflateThreshold { get; }

	public extern int ParallelDeflateMaxBufferPairs { get; }

	public extern int CodecBufferSize { get; }

	public extern CompressionStrategy Strategy { get; }

	public extern Zip64Option UseZip64WhenSaving { get; }

	public extern Encoding AlternateEncoding { get; }

	public Encoding DefaultEncoding
	{
		get
		{
			//Discarded unreachable code: IL_0015, IL_001d
			//IL_0018: Expected F4, but got I4
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/== /*Error near IL_000a: Stack underflow*/)
			{
			}
			((long[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/] = (long)/*Error near IL_000c: Stack underflow*/;
			_ = (sbyte)((float[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/];
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	public extern ZipOption AlternateEncodingUsage { get; }

	public extern Stream ReadStream { get; }

	public extern ZipContainer(object o);
}
