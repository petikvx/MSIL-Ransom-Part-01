namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Salsa;

internal class Salsa20
{
	public const uint SalsaConst0 = 1634760805u;

	public const uint SalsaConst1 = 857760878u;

	public const uint SalsaConst2 = 2036477234u;

	public const uint SalsaConst3 = 1797285236u;

	internal static void HSalsa20(byte[] output, int outputOffset, byte[] key, int keyOffset, byte[] nonce, int nonceOffset)
	{
		Array16<uint> output2 = default(Array16<uint>);
		output2.x0 = 1634760805u;
		output2.x1 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset);
		output2.x2 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 4);
		output2.x3 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 8);
		output2.x4 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 12);
		output2.x5 = 857760878u;
		output2.x6 = ByteIntegerConverter.LoadLittleEndian32(nonce, nonceOffset);
		output2.x7 = ByteIntegerConverter.LoadLittleEndian32(nonce, nonceOffset + 4);
		output2.x8 = ByteIntegerConverter.LoadLittleEndian32(nonce, nonceOffset + 8);
		output2.x9 = ByteIntegerConverter.LoadLittleEndian32(nonce, nonceOffset + 12);
		output2.x10 = 2036477234u;
		output2.x11 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 16);
		output2.x12 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 20);
		output2.x13 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 24);
		output2.x14 = ByteIntegerConverter.LoadLittleEndian32(key, keyOffset + 28);
		output2.x15 = 1797285236u;
		SalsaCore.HSalsa(out output2, ref output2, 20);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset, output2.x0);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 4, output2.x5);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 8, output2.x10);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 12, output2.x15);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 16, output2.x6);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 20, output2.x7);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 24, output2.x8);
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 28, output2.x9);
	}
}
