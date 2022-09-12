using System;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class InflaterHuffmanTree
{
	public static InflaterHuffmanTree defDistTree;

	public static InflaterHuffmanTree defLitLenTree;

	private const int lcrJmiEcfyehRGMqUfcTjIHgHJQ = 15;

	private short[] BdqqDQIwXmEcfPNdfvDfGXIJqwD;

	static InflaterHuffmanTree()
	{
		try
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			defLitLenTree = new InflaterHuffmanTree(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			defDistTree = new InflaterHuffmanTree(array);
		}
		catch (Exception)
		{
			throw new SharpZipBaseException("InflaterHuffmanTree: static tree length illegal");
		}
	}

	public InflaterHuffmanTree(byte[] codeLengths)
	{
		TdQTbUAcXZCEeQMESSEDcjhjhgeh(codeLengths);
	}

	private void TdQTbUAcXZCEeQMESSEDcjhjhgeh(byte[] codeLengths)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in codeLengths)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		BdqqDQIwXmEcfPNdfvDfGXIJqwD = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			for (int k = num2 & 0x1FF80; k < num8; k += 128)
			{
				BdqqDQIwXmEcfPNdfvDfGXIJqwD[DeflaterHuffman.BitReverse(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < codeLengths.Length; l++)
		{
			int num9 = codeLengths[l];
			if (num9 == 0)
			{
				continue;
			}
			num2 = array2[num9];
			int num10 = DeflaterHuffman.BitReverse(num2);
			if (num9 > 9)
			{
				int num11 = BdqqDQIwXmEcfPNdfvDfGXIJqwD[num10 & 0x1FF];
				int num12 = 1 << (num11 & 0xF);
				num11 = -(num11 >> 4);
				do
				{
					BdqqDQIwXmEcfPNdfvDfGXIJqwD[num11 | (num10 >> 9)] = (short)((l << 4) | num9);
					num10 += 1 << num9;
				}
				while (num10 < num12);
			}
			else
			{
				do
				{
					BdqqDQIwXmEcfPNdfvDfGXIJqwD[num10] = (short)((l << 4) | num9);
					num10 += 1 << num9;
				}
				while (num10 < 512);
			}
			array2[num9] = num2 + (1 << 16 - num9);
		}
	}

	public int GetSymbol(StreamManipulator input)
	{
		int num = input.PeekBits(9);
		int num2;
		if (num >= 0)
		{
			num2 = BdqqDQIwXmEcfPNdfvDfGXIJqwD[num];
			if (num2 < 0)
			{
				int num3 = -(num2 >> 4);
				int bitCount = num2 & 0xF;
				num = input.PeekBits(bitCount);
				if (num >= 0)
				{
					num2 = BdqqDQIwXmEcfPNdfvDfGXIJqwD[num3 | (num >> 9)];
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = input.AvailableBits;
				num = input.PeekBits(availableBits);
				num2 = BdqqDQIwXmEcfPNdfvDfGXIJqwD[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			input.DropBits(num2 & 0xF);
			return num2 >> 4;
		}
		int availableBits2 = input.AvailableBits;
		num = input.PeekBits(availableBits2);
		num2 = BdqqDQIwXmEcfPNdfvDfGXIJqwD[num];
		if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
		{
			input.DropBits(num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}
}
