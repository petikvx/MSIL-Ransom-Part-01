namespace Ionic.Zlib;

internal sealed class DeflateManager
{
	internal delegate BlockState CompressFunc(FlushType flush);

	internal class Config
	{
		internal int GoodLength;

		internal int MaxLazy;

		internal int NiceLength;

		internal int MaxChainLength;

		internal DeflateFlavor Flavor;

		private static readonly Config[] Table;

		private extern Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor);

		public static extern Config Lookup(CompressionLevel level);

		static extern Config();
	}

	private static readonly int MEM_LEVEL_MAX;

	private static readonly int MEM_LEVEL_DEFAULT;

	private CompressFunc DeflateFunction;

	private static readonly string[] _ErrorMessage;

	private static readonly int PRESET_DICT;

	private static readonly int INIT_STATE;

	private static readonly int BUSY_STATE;

	private static readonly int FINISH_STATE;

	private static readonly int Z_DEFLATED;

	private static readonly int STORED_BLOCK;

	private static readonly int STATIC_TREES;

	private static readonly int DYN_TREES;

	private static readonly int Z_BINARY;

	private static readonly int Z_ASCII;

	private static readonly int Z_UNKNOWN;

	private static readonly int Buf_size;

	private static readonly int MIN_MATCH;

	private static readonly int MAX_MATCH;

	private static readonly int MIN_LOOKAHEAD;

	private static readonly int HEAP_SIZE;

	private static readonly int END_BLOCK;

	internal ZlibCodec _codec;

	internal int status;

	internal byte[] pending;

	internal int nextPending;

	internal int pendingCount;

	internal sbyte data_type;

	internal int last_flush;

	internal int w_size;

	internal int w_bits;

	internal int w_mask;

	internal byte[] window;

	internal int window_size;

	internal short[] prev;

	internal short[] head;

	internal int ins_h;

	internal int hash_size;

	internal int hash_bits;

	internal int hash_mask;

	internal int hash_shift;

	internal int block_start;

	private Config config;

	internal int match_length;

	internal int prev_match;

	internal int match_available;

	internal int strstart;

	internal int match_start;

	internal int lookahead;

	internal int prev_length;

	internal CompressionLevel compressionLevel;

	internal CompressionStrategy compressionStrategy;

	internal short[] dyn_ltree;

	internal short[] dyn_dtree;

	internal short[] bl_tree;

	internal Tree treeLiterals;

	internal Tree treeDistances;

	internal Tree treeBitLengths;

	internal short[] bl_count;

	internal int[] heap;

	internal int heap_len;

	internal int heap_max;

	internal sbyte[] depth;

	internal int _lengthOffset;

	internal int lit_bufsize;

	internal int last_lit;

	internal int _distanceOffset;

	internal int opt_len;

	internal int static_len;

	internal int matches;

	internal int last_eob_len;

	internal short bi_buf;

	internal int bi_valid;

	private bool Rfc1950BytesEmitted;

	private bool _WantRfc1950HeaderBytes;

	internal bool WantRfc1950HeaderBytes
	{
		get
		{
			//IL_0007: Invalid comparison between Unknown and I4
			while (true)
			{
				short num2;
				checked
				{
					sbyte num = (sbyte)/*Error near IL_0001: Stack underflow*/;
					((int[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
					num2 = (short)(double)/*Error near IL_0004: Stack underflow*/;
				}
				if ((int)/*Error near IL_000c: Stack underflow*/ >= (int)num2)
				{
					/*Error: Could not find block for branch target IL_000c*/;
				}
			}
		}
		set; }

	internal extern DeflateManager();

	private extern void _InitializeLazyMatch();

	private extern void _InitializeTreeData();

	internal extern void _InitializeBlocks();

	internal unsafe void pqdownheap(short[] tree, int k)
	{
		//Discarded unreachable code: IL_0011, IL_0016
		//IL_0003: Unsupported input type for neg.
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected F8, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			/*Error: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
		}
		while (0 - /*Error near IL_0004: Stack underflow*/!= 0);
		*(_003F*)(nint)/*Error near IL_000b: Stack underflow*/ = /*Error near IL_000b: Stack underflow*/;
		((object[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/] = (object)/*Error near IL_000c: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
	{
		_ = -1;
		/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	internal void scan_tree(short[] tree, int max_code)
	{
		while (true)
		{
		}
	}

	internal extern int build_bl_tree();

	internal extern void send_all_trees(int lcodes, int dcodes, int blcodes);

	internal extern void send_tree(short[] tree, int max_code);

	private void put_bytes(byte[] p, int start, int len)
	{
		/*Error: stloc 0 (out-of-bounds)*/;
	}

	internal extern void send_code(int c, short[] tree);

	internal extern void send_bits(int value, int length);

	internal extern void _tr_align();

	internal extern bool _tr_tally(int dist, int lc);

	internal void send_compressed_block(short[] ltree, short[] dtree)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0010, IL_0015, IL_001f, IL_0024, IL_0029, IL_0037
		/*Error: Invalid metadata token*/;
	}

	internal extern void set_data_type();

	internal extern void bi_flush();

	internal extern void bi_windup();

	internal extern void copy_block(int buf, int len, bool header);

	internal void flush_block_only(bool eof)
	{
		//IL_0004: Expected O, but got Unknown
		_ = 0;
		/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	internal extern BlockState DeflateNone(FlushType flush);

	internal extern void _tr_stored_block(int buf, int stored_len, bool eof);

	internal extern void _tr_flush_block(int buf, int stored_len, bool eof);

	private extern void _fillWindow();

	internal BlockState DeflateFast(FlushType flush)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (nint)(~/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	internal extern BlockState DeflateSlow(FlushType flush);

	internal extern int longest_match(int cur_match);

	internal extern int Initialize(ZlibCodec codec, CompressionLevel level);

	internal extern int Initialize(ZlibCodec codec, CompressionLevel level, int bits);

	internal extern int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy);

	internal extern int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy);

	internal void Reset()
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0017, IL_001c, IL_0021, IL_0027, IL_002d, IL_0036
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
		_ = ((object[])/*Error near IL_0002: Stack underflow*/)[val];
		/*Error near IL_0004: Invalid metadata token*/;
	}

	internal extern int End();

	private extern void SetDeflater();

	internal extern int SetParams(CompressionLevel level, CompressionStrategy strategy);

	internal extern int SetDictionary(byte[] dictionary);

	internal extern int Deflate(FlushType flush);
}
