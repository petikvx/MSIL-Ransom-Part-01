namespace Ionic.Zlib;

internal sealed class InflateBlocks
{
	private enum InflateBlockMode
	{
		TYPE,
		LENS,
		STORED,
		TABLE,
		BTREE,
		DTREE,
		CODES,
		DRY,
		DONE,
		BAD
	}

	private const int MANY = 1440;

	internal static readonly int[] border;

	private InflateBlockMode mode;

	internal int left;

	internal int table;

	internal int index;

	internal int[] blens;

	internal int[] bb;

	internal int[] tb;

	internal InflateCodes codes;

	internal int last;

	internal ZlibCodec _codec;

	internal int bitk;

	internal int bitb;

	internal int[] hufts;

	internal byte[] window;

	internal int end;

	internal int readAt;

	internal int writeAt;

	internal object checkfn;

	internal uint check;

	internal InfTree inftree;

	internal extern InflateBlocks(ZlibCodec codec, object checkfn, int w);

	internal extern uint Reset();

	internal extern int Process(int r);

	internal void Free()
	{
		//IL_0010: Invalid comparison between I4 and F8
		//IL_0010: Incompatible stack heights: 0 vs 1
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_ = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while (902250599.0 != 6.606817876915693E+94);
		_ = /*Error near IL_0016: Stack underflow*/* /*Error near IL_0016: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	internal extern void SetDictionary(byte[] d, int start, int n);

	internal extern int SyncPoint();

	internal extern int Flush(int r);
}
