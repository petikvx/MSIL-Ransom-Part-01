using K4os.Compression.LZ4.Engine;
using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Encoders;

public class LZ4FastChainEncoder : LZ4EncoderBase
{
	private unsafe readonly LZ4_xx.LZ4_stream_t* _context;

	public unsafe LZ4FastChainEncoder(int blockSize, int extraBlocks = 0)
		: base(chaining: true, blockSize, extraBlocks)
	{
		_context = (LZ4_xx.LZ4_stream_t*)Mem.AllocZero(sizeof(LZ4_xx.LZ4_stream_t));
	}

	protected unsafe override void ReleaseUnmanaged()
	{
		base.ReleaseUnmanaged();
		Mem.Free(_context);
	}

	protected unsafe override int EncodeBlock(byte* source, int sourceLength, byte* target, int targetLength)
	{
		return LZ4_64.LZ4_compress_fast_continue(_context, source, target, sourceLength, targetLength, 1);
	}

	protected unsafe override int CopyDict(byte* target, int length)
	{
		return LZ4_xx.LZ4_saveDict(_context, target, length);
	}
}
