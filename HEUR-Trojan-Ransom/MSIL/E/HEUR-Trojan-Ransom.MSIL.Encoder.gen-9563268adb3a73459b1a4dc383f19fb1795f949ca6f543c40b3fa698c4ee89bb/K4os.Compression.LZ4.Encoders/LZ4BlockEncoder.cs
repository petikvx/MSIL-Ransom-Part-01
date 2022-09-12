namespace K4os.Compression.LZ4.Encoders;

public class LZ4BlockEncoder : LZ4EncoderBase
{
	private readonly LZ4Level _level;

	public LZ4BlockEncoder(LZ4Level level, int blockSize)
		: base(chaining: false, blockSize, 0)
	{
		_level = level;
	}

	protected unsafe override int EncodeBlock(byte* source, int sourceLength, byte* target, int targetLength)
	{
		return LZ4Codec.Encode(source, sourceLength, target, targetLength, _level);
	}

	protected unsafe override int CopyDict(byte* target, int dictionaryLength)
	{
		return 0;
	}
}
