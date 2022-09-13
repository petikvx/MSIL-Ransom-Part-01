using System;

namespace Ionic.Zlib;

internal sealed class InfTree
{
	private const int MANY = 1440;

	private const int Z_OK = 0;

	private const int Z_STREAM_END = 1;

	private const int Z_NEED_DICT = 2;

	private const int Z_ERRNO = -1;

	private const int Z_STREAM_ERROR = -2;

	private const int Z_DATA_ERROR = -3;

	private const int Z_MEM_ERROR = -4;

	private const int Z_BUF_ERROR = -5;

	private const int Z_VERSION_ERROR = -6;

	internal const int fixed_bl = 9;

	internal const int fixed_bd = 5;

	internal static readonly int[] fixed_tl;

	internal static readonly int[] fixed_td;

	internal static readonly int[] cplens;

	internal static readonly int[] cplext;

	internal static readonly int[] cpdist;

	internal static readonly int[] cpdext;

	internal const int BMAX = 15;

	internal int[] hn;

	internal int[] v;

	internal int[] c;

	internal int[] r;

	internal int[] u;

	internal int[] x;

	private unsafe int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
	{
		//Discarded unreachable code: IL_001e, IL_0023, IL_002d, IL_0032
		//IL_000a: Expected O, but got I8
		//IL_000b: Invalid comparison between Unknown and I
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected F4, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			IntPtr intPtr = (nint)((Array)8849898417731603503L).LongLength;
			if ((nint)/*Error near IL_0010: Stack underflow*/ <= (nint)intPtr)
			{
				int num = *(int*)checked((int)/*Error near IL_0011: Stack underflow*/);
				_003F val = /*Error near IL_0014: Stack underflow*// (double)(uint)num;
				((float[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/] = (float)val;
				if ((int)/*Error near IL_001b: Stack underflow*/ == 0)
				{
					break;
				}
			}
		}
		nint num2 = (nint)/*Error near IL_001c: Stack underflow*/;
		_ = ((ushort[])/*Error near IL_001d: Stack underflow*/)[num2];
		/*Error near IL_001d: Unknown opcode: 0xFB*/;
	}

	internal extern int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z);

	internal extern int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z);

	internal static extern int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z);

	private extern void initWorkArea(int vsize);

	public InfTree()
	{
		//Discarded unreachable code: IL_0005
		//IL_0009: Invalid comparison between Unknown and Ref
		/*Error: Invalid metadata token*/;
	}
}
