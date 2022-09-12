namespace K4os.Compression.LZ4.Streams;

public class LZ4EncoderSettings
{
	internal static LZ4EncoderSettings Default = new LZ4EncoderSettings();

	public long? ContentLength { get; set; }

	public bool ChainBlocks { get; set; } = true;


	public int BlockSize { get; set; } = 65536;


	public bool ContentChecksum => false;

	public bool BlockChecksum => false;

	public uint? Dictionary => null;

	public LZ4Level CompressionLevel { get; set; }

	public int ExtraMemory { get; set; }
}
