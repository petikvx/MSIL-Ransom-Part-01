namespace K4os.Compression.LZ4.Encoders;

public static class LZ4Decoder
{
	public static ILZ4Decoder Create(bool chaining, int blockSize, int extraBlocks = 0)
	{
		if (chaining)
		{
			return CreateChainDecoder(blockSize, extraBlocks);
		}
		return CreateBlockDecoder(blockSize);
	}

	private static ILZ4Decoder CreateChainDecoder(int blockSize, int extraBlocks)
	{
		return new LZ4ChainDecoder(blockSize, extraBlocks);
	}

	private static ILZ4Decoder CreateBlockDecoder(int blockSize)
	{
		return new LZ4BlockDecoder(blockSize);
	}
}
