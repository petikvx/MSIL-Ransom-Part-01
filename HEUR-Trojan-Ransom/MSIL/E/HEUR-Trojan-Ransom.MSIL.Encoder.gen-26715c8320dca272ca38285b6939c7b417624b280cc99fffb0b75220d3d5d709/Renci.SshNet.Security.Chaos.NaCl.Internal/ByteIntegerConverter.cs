namespace Renci.SshNet.Security.Chaos.NaCl.Internal;

internal static class ByteIntegerConverter
{
	internal static uint LoadLittleEndian32(byte[] buf, int offset)
	{
		return (uint)(buf[offset] | (buf[offset + 1] << 8) | (buf[offset + 2] << 16) | (buf[offset + 3] << 24));
	}

	internal static void StoreLittleEndian32(byte[] buf, int offset, uint value)
	{
		buf[offset] = (byte)value;
		buf[offset + 1] = (byte)(value >> 8);
		buf[offset + 2] = (byte)(value >> 16);
		buf[offset + 3] = (byte)(value >> 24);
	}

	internal static ulong LoadBigEndian64(byte[] buf, int offset)
	{
		return buf[offset + 7] | ((ulong)buf[offset + 6] << 8) | ((ulong)buf[offset + 5] << 16) | ((ulong)buf[offset + 4] << 24) | ((ulong)buf[offset + 3] << 32) | ((ulong)buf[offset + 2] << 40) | ((ulong)buf[offset + 1] << 48) | ((ulong)buf[offset] << 56);
	}

	internal static void StoreBigEndian64(byte[] buf, int offset, ulong value)
	{
		buf[offset + 7] = (byte)value;
		buf[offset + 6] = (byte)(value >> 8);
		buf[offset + 5] = (byte)(value >> 16);
		buf[offset + 4] = (byte)(value >> 24);
		buf[offset + 3] = (byte)(value >> 32);
		buf[offset + 2] = (byte)(value >> 40);
		buf[offset + 1] = (byte)(value >> 48);
		buf[offset] = (byte)(value >> 56);
	}

	internal static void Array8LoadLittleEndian32(out Array8<uint> output, byte[] input, int inputOffset)
	{
		output.x0 = LoadLittleEndian32(input, inputOffset);
		output.x1 = LoadLittleEndian32(input, inputOffset + 4);
		output.x2 = LoadLittleEndian32(input, inputOffset + 8);
		output.x3 = LoadLittleEndian32(input, inputOffset + 12);
		output.x4 = LoadLittleEndian32(input, inputOffset + 16);
		output.x5 = LoadLittleEndian32(input, inputOffset + 20);
		output.x6 = LoadLittleEndian32(input, inputOffset + 24);
		output.x7 = LoadLittleEndian32(input, inputOffset + 28);
	}

	internal static void Array16LoadBigEndian64(out Array16<ulong> output, byte[] input, int inputOffset)
	{
		output.x0 = LoadBigEndian64(input, inputOffset);
		output.x1 = LoadBigEndian64(input, inputOffset + 8);
		output.x2 = LoadBigEndian64(input, inputOffset + 16);
		output.x3 = LoadBigEndian64(input, inputOffset + 24);
		output.x4 = LoadBigEndian64(input, inputOffset + 32);
		output.x5 = LoadBigEndian64(input, inputOffset + 40);
		output.x6 = LoadBigEndian64(input, inputOffset + 48);
		output.x7 = LoadBigEndian64(input, inputOffset + 56);
		output.x8 = LoadBigEndian64(input, inputOffset + 64);
		output.x9 = LoadBigEndian64(input, inputOffset + 72);
		output.x10 = LoadBigEndian64(input, inputOffset + 80);
		output.x11 = LoadBigEndian64(input, inputOffset + 88);
		output.x12 = LoadBigEndian64(input, inputOffset + 96);
		output.x13 = LoadBigEndian64(input, inputOffset + 104);
		output.x14 = LoadBigEndian64(input, inputOffset + 112);
		output.x15 = LoadBigEndian64(input, inputOffset + 120);
	}

	internal static void Array16LoadLittleEndian32(out Array16<uint> output, byte[] input, int inputOffset)
	{
		output.x0 = LoadLittleEndian32(input, inputOffset);
		output.x1 = LoadLittleEndian32(input, inputOffset + 4);
		output.x2 = LoadLittleEndian32(input, inputOffset + 8);
		output.x3 = LoadLittleEndian32(input, inputOffset + 12);
		output.x4 = LoadLittleEndian32(input, inputOffset + 16);
		output.x5 = LoadLittleEndian32(input, inputOffset + 20);
		output.x6 = LoadLittleEndian32(input, inputOffset + 24);
		output.x7 = LoadLittleEndian32(input, inputOffset + 28);
		output.x8 = LoadLittleEndian32(input, inputOffset + 32);
		output.x9 = LoadLittleEndian32(input, inputOffset + 36);
		output.x10 = LoadLittleEndian32(input, inputOffset + 40);
		output.x11 = LoadLittleEndian32(input, inputOffset + 44);
		output.x12 = LoadLittleEndian32(input, inputOffset + 48);
		output.x13 = LoadLittleEndian32(input, inputOffset + 52);
		output.x14 = LoadLittleEndian32(input, inputOffset + 56);
		output.x15 = LoadLittleEndian32(input, inputOffset + 60);
	}

	internal static void Array16StoreLittleEndian32(byte[] output, int outputOffset, ref Array16<uint> input)
	{
		StoreLittleEndian32(output, outputOffset, input.x0);
		StoreLittleEndian32(output, outputOffset + 4, input.x1);
		StoreLittleEndian32(output, outputOffset + 8, input.x2);
		StoreLittleEndian32(output, outputOffset + 12, input.x3);
		StoreLittleEndian32(output, outputOffset + 16, input.x4);
		StoreLittleEndian32(output, outputOffset + 20, input.x5);
		StoreLittleEndian32(output, outputOffset + 24, input.x6);
		StoreLittleEndian32(output, outputOffset + 28, input.x7);
		StoreLittleEndian32(output, outputOffset + 32, input.x8);
		StoreLittleEndian32(output, outputOffset + 36, input.x9);
		StoreLittleEndian32(output, outputOffset + 40, input.x10);
		StoreLittleEndian32(output, outputOffset + 44, input.x11);
		StoreLittleEndian32(output, outputOffset + 48, input.x12);
		StoreLittleEndian32(output, outputOffset + 52, input.x13);
		StoreLittleEndian32(output, outputOffset + 56, input.x14);
		StoreLittleEndian32(output, outputOffset + 60, input.x15);
	}
}
