using K4os.Compression.LZ4.Engine;
using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Encoders;

public class LZ4HighChainEncoder : LZ4EncoderBase
{
	private unsafe readonly LZ4_64_HC.LZ4HC_CCtx_t* _context;

	public unsafe LZ4HighChainEncoder(LZ4Level level, int blockSize, int extraBlocks = 0)
		: base(chaining: true, blockSize, extraBlocks)
	{
		if (level < LZ4Level.L03_HC)
		{
			level = LZ4Level.L03_HC;
		}
		if (level > LZ4Level.L12_MAX)
		{
			level = LZ4Level.L12_MAX;
		}
		_context = (LZ4_64_HC.LZ4HC_CCtx_t*)Mem.AllocZero(sizeof(LZ4_64_HC.LZ4HC_CCtx_t));
		LZ4_64_HC.LZ4_resetStreamHC(_context, (int)level);
	}

	protected unsafe override void ReleaseUnmanaged()
	{
		base.ReleaseUnmanaged();
		Mem.Free(_context);
	}

	protected unsafe override int EncodeBlock(byte* source, int sourceLength, byte* target, int targetLength)
	{
		return LZ4_64_HC.LZ4_compress_HC_continue(_context, source, target, sourceLength, targetLength);
	}

	protected unsafe override int CopyDict(byte* target, int length)
	{
		return LZ4_64_HC.LZ4_saveDictHC(_context, target, length);
	}
}
