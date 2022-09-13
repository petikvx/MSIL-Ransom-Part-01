using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Crc;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
[ComVisible(true)]
public class CRC32
{
	private uint dwPolynomial;

	private long _TotalBytesRead;

	private bool reverseBits;

	private uint[] crc32Table;

	private const int BUFFER_SIZE = 8192;

	private uint _register;

	public extern long TotalBytesRead { get; }

	public int Crc32Result
	{
		get
		{
			while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
			}
			/*Error: Unexpected end of block*/;
		}
	}

	public extern int GetCrc32(Stream input);

	public extern int GetCrc32AndCopy(Stream input, Stream output);

	public extern int ComputeCrc32(int W, byte B);

	internal extern int _InternalComputeCrc32(uint W, byte B);

	public extern void SlurpBlock(byte[] block, int offset, int count);

	public extern void UpdateCRC(byte b);

	public extern void UpdateCRC(byte b, int n);

	private unsafe static uint ReverseBits(uint data)
	{
		//Discarded unreachable code: IL_0007
		//IL_0001: Expected native int or pointer, but got F8
		_ = *(ushort*)(nint)((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private static extern byte ReverseBits(byte data);

	private extern void GenerateLookupTable();

	private extern uint gf2_matrix_times(uint[] matrix, uint vec);

	private extern void gf2_matrix_square(uint[] square, uint[] mat);

	public extern void Combine(int crc, int length);

	public extern CRC32();

	public extern CRC32(bool reverseBits);

	public extern CRC32(int polynomial, bool reverseBits);

	public extern void Reset();
}
