namespace Ionic.Zlib;

internal sealed class Tree
{
	private static readonly int HEAP_SIZE;

	internal static readonly int[] ExtraLengthBits;

	internal static readonly int[] ExtraDistanceBits;

	internal static readonly int[] extra_blbits;

	internal static readonly sbyte[] bl_order;

	internal const int Buf_size = 16;

	private static readonly sbyte[] _dist_code;

	internal static readonly sbyte[] LengthCode;

	internal static readonly int[] LengthBase;

	internal static readonly int[] DistanceBase;

	internal short[] dyn_tree;

	internal int max_code;

	internal StaticTree staticTree;

	internal static extern int DistanceCode(int dist);

	internal extern void gen_bitlen(DeflateManager s);

	internal extern void build_tree(DeflateManager s);

	internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
	{
		//Discarded unreachable code: IL_0005, IL_0009, IL_0010, IL_0017
		//IL_0012: Incompatible stack heights: 0 vs 1
		//IL_001f: Expected native int or pointer, but got F4
		/*Error: Invalid metadata token*/;
	}

	internal static int bi_reverse(int code, int len)
	{
		//Discarded unreachable code: IL_000b, IL_0010
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (uint)/*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public extern Tree();
}
