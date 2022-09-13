namespace Ionic.Zlib;

internal sealed class InflateManager
{
	private enum InflateManagerMode
	{
		METHOD,
		FLAG,
		DICT4,
		DICT3,
		DICT2,
		DICT1,
		DICT0,
		BLOCKS,
		CHECK4,
		CHECK3,
		CHECK2,
		CHECK1,
		DONE,
		BAD
	}

	private const int PRESET_DICT = 32;

	private const int Z_DEFLATED = 8;

	private InflateManagerMode mode;

	internal ZlibCodec _codec;

	internal int method;

	internal uint computedCheck;

	internal uint expectedCheck;

	internal int marker;

	private bool _handleRfc1950HeaderBytes;

	internal int wbits;

	internal InflateBlocks blocks;

	private static readonly byte[] mark;

	internal extern bool HandleRfc1950HeaderBytes { get; set; }

	public extern InflateManager();

	public extern InflateManager(bool expectRfc1950HeaderBytes);

	internal extern int Reset();

	internal extern int End();

	internal extern int Initialize(ZlibCodec codec, int w);

	internal extern int Inflate(FlushType flush);

	internal extern int SetDictionary(byte[] dictionary);

	internal extern int Sync();

	internal unsafe int SyncPoint(ZlibCodec z)
	{
		//IL_0019: Expected I8, but got O
		//IL_002f: Invalid comparison between I and F4
		//IL_002f: Incompatible stack heights: 0 vs 3
		while (true)
		{
			if ((int)/*Error: ldloc 1 (out-of-bounds)*/ != 0 || /*Error near IL_000c: Stack underflow*/<= /*Error near IL_000c: Stack underflow*/)
			{
				continue;
			}
			((short[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = (short)/*Error near IL_000e: Stack underflow*/;
			if (/*Error near IL_0013: Stack underflow*/ < /*Error near IL_0013: Stack underflow*/)
			{
				((long[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = (long)"";
				_ = (ulong)/*Error near IL_001a: Stack underflow*/;
				_ = (float)(*(int*)0uL);
				if (!(4f >= 1.3491678E-31f))
				{
					/*Error: Could not find block for branch target IL_0034*/;
				}
			}
		}
	}
}
