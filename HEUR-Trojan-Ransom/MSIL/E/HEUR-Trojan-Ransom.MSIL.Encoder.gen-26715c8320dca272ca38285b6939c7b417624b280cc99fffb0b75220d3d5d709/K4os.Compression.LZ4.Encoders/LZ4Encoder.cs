namespace K4os.Compression.LZ4.Encoders;

public static class LZ4Encoder
{
	public static ILZ4Encoder Create(bool chaining, LZ4Level level, int blockSize, int extraBlocks = 0)
	{
		if (chaining)
		{
			if (level != 0)
			{
				return CreateHighEncoder(level, blockSize, extraBlocks);
			}
			return CreateFastEncoder(blockSize, extraBlocks);
		}
		return CreateBlockEncoder(level, blockSize);
	}

	private static ILZ4Encoder CreateBlockEncoder(LZ4Level level, int blockSize)
	{
		return new LZ4BlockEncoder(level, blockSize);
	}

	private static ILZ4Encoder CreateFastEncoder(int blockSize, int extraBlocks)
	{
		return new LZ4FastChainEncoder(blockSize, extraBlocks);
	}

	private static ILZ4Encoder CreateHighEncoder(LZ4Level level, int blockSize, int extraBlocks)
	{
		return new LZ4HighChainEncoder(level, blockSize, extraBlocks);
	}
}
