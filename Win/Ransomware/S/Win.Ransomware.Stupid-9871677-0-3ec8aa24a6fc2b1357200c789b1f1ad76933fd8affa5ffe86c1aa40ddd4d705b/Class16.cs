using Ionic.Zlib;

internal class Class16
{
	public byte[] byte_0;

	public byte[] byte_1;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public GClass5 gclass5_0;

	public Class16(int size, CompressionLevel compressLevel, CompressionStrategy strategy, int ix)
	{
		byte_0 = new byte[size];
		int num = size + (size / 32768 + 1) * 5 * 2;
		byte_1 = new byte[num];
		gclass5_0 = new GClass5();
		gclass5_0.method_9(compressLevel, bool_0: false);
		gclass5_0.byte_1 = byte_1;
		gclass5_0.byte_0 = byte_0;
		int_1 = ix;
	}
}
