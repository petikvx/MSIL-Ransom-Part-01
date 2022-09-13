namespace Ionic.Zlib;

internal class WorkItem
{
	public byte[] buffer;

	public byte[] compressed;

	public int crc;

	public int index;

	public int ordinal;

	public int inputBytesAvailable;

	public int compressedBytesAvailable;

	public ZlibCodec compressor;

	public extern WorkItem(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix);
}
