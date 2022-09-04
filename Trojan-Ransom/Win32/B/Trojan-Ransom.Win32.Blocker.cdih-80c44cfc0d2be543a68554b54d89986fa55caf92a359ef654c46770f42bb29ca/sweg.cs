using System;

public class sweg
{
	private const int STEPSIZE = 8;

	public const int COPYLENGTH = 8;

	public const int ML_BITS = 4;

	public const uint ML_MASK = 15u;

	public const int RUN_BITS = 4;

	public const uint RUN_MASK = 15u;

	private static readonly sbyte[] m_DecArray = new sbyte[8] { 0, 3, 2, 3, 0, 0, 0, 0 };

	private static readonly sbyte[] m_Dec2table = new sbyte[8] { 0, 0, 0, -1, 0, 1, 2, 3 };

	public static byte[] go(byte[] compressed)
	{
		int num = compressed.Length;
		byte[] array;
		int num2;
		do
		{
			num *= 4;
			array = new byte[num];
			num2 = Decompress(compressed, array, compressed.Length);
		}
		while (num2 < 0 || array.Length < num2);
		byte[] array2 = new byte[num2];
		Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
		num2 = array2.Length - 16;
		byte[] array3 = new byte[num2];
		Buffer.BlockCopy(array2, 16, array3, 0, array3.Length);
		for (int i = 0; i < array3.Length; i++)
		{
			array3[i] ^= array2[i % 16];
		}
		return array3;
	}

	public unsafe static void CopyMemory(byte* dst, byte* src, long length)
	{
		while (length >= 16L)
		{
			*(long*)dst = *(long*)src;
			dst += 8;
			src += 8;
			*(long*)dst = *(long*)src;
			dst += 8;
			src += 8;
			length -= 16L;
		}
		if (length >= 8L)
		{
			*(long*)dst = *(long*)src;
			dst += 8;
			src += 8;
			length -= 8L;
		}
		if (length >= 4L)
		{
			*(int*)dst = *(int*)src;
			dst += 4;
			src += 4;
			length -= 4L;
		}
		if (length >= 2L)
		{
			*(short*)dst = *(short*)src;
			dst += 2;
			src += 2;
			length -= 2L;
		}
		if (length != 0L)
		{
			*dst = *src;
		}
	}

	public unsafe static int Decompress(byte[] compressedBuffer, byte[] decompressedBuffer, int compressedSize)
	{
		fixed (byte* compressedBuffer2 = compressedBuffer)
		{
			fixed (byte* decompressedBuffer2 = decompressedBuffer)
			{
				return Decompress(compressedBuffer2, decompressedBuffer2, compressedSize, decompressedBuffer.Length);
			}
		}
	}

	public unsafe static int Decompress(byte[] compressedBuffer, int compressedPosition, byte[] decompressedBuffer, int decompressedPosition, int compressedSize)
	{
		fixed (byte* compressedBuffer2 = &compressedBuffer[compressedPosition])
		{
			fixed (byte* decompressedBuffer2 = &decompressedBuffer[decompressedPosition])
			{
				return Decompress(compressedBuffer2, decompressedBuffer2, compressedSize, decompressedBuffer.Length);
			}
		}
	}

	public unsafe static int Decompress(byte* compressedBuffer, byte* decompressedBuffer, int compressedSize, int maxDecompressedSize)
	{
		fixed (sbyte* ptr8 = m_DecArray)
		{
			fixed (sbyte* ptr7 = m_Dec2table)
			{
				byte* ptr = compressedBuffer;
				byte* ptr2 = ptr + compressedSize;
				byte* ptr3 = decompressedBuffer;
				byte* ptr4 = ptr3 + maxDecompressedSize;
				while (true)
				{
					if (ptr < ptr2)
					{
						byte b = *(ptr++);
						int num;
						if ((num = b >> 4) == 15L)
						{
							int num2 = 255;
							while (ptr < ptr2 && num2 == 255)
							{
								num2 = *(ptr++);
								num += num2;
							}
						}
						byte* ptr5 = ptr3 + num;
						if (ptr5 <= ptr4 - 8 && ptr + num <= ptr2 - 8)
						{
							do
							{
								*(long*)ptr3 = *(long*)ptr;
								ptr3 += 8;
								ptr += 8;
							}
							while (ptr3 < ptr5);
							ptr -= ptr3 - ptr5;
							ptr3 = ptr5;
							byte* ptr6 = ptr5 - (int)(*(ushort*)ptr);
							ptr += 2;
							if (ptr6 < decompressedBuffer)
							{
								break;
							}
							if ((num = b & 0xF) == 15L)
							{
								while (ptr < ptr2)
								{
									int num3 = *(ptr++);
									num += num3;
									if (num3 != 255)
									{
										break;
									}
								}
							}
							if (ptr3 - ptr6 < 8L)
							{
								sbyte b2 = ptr7[ptr3 - ptr6];
								*(ptr3++) = *(ptr6++);
								*(ptr3++) = *(ptr6++);
								*(ptr3++) = *(ptr6++);
								*(ptr3++) = *(ptr6++);
								ptr6 -= ptr8[ptr3 - ptr6];
								*(int*)ptr3 = *(int*)ptr6;
								ptr3 += 4;
								ptr6 -= b2;
							}
							else
							{
								*(long*)ptr3 = *(long*)ptr6;
								ptr3 += 8;
								ptr6 += 8;
							}
							ptr5 = ptr3 + num - 4;
							if (ptr5 > ptr4 - 8)
							{
								if (ptr5 > ptr4)
								{
									break;
								}
								if (ptr3 < ptr4 - 8)
								{
									do
									{
										*(long*)ptr3 = *(long*)ptr6;
										ptr3 += 8;
										ptr6 += 8;
									}
									while (ptr3 < ptr4 - 8);
								}
								while (ptr3 < ptr5)
								{
									*(ptr3++) = *(ptr6++);
								}
								ptr3 = ptr5;
								if (ptr3 == ptr4)
								{
									break;
								}
								continue;
							}
							if (ptr3 < ptr5)
							{
								do
								{
									*(long*)ptr3 = *(long*)ptr6;
									ptr3 += 8;
									ptr6 += 8;
								}
								while (ptr3 < ptr5);
							}
							ptr3 = ptr5;
							continue;
						}
						if (ptr5 > ptr4 || ptr + num > ptr2)
						{
							break;
						}
						CopyMemory(ptr3, ptr, num);
						ptr3 += num;
						ptr += num;
						if (ptr < ptr2)
						{
							break;
						}
					}
					return (int)(ptr3 - decompressedBuffer);
				}
				return (int)(-(ptr - compressedBuffer));
			}
		}
	}
}
