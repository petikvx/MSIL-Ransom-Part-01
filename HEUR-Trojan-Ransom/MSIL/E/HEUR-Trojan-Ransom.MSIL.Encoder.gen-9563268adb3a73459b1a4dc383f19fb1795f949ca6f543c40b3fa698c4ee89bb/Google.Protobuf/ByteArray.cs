using System;

namespace Google.Protobuf;

internal static class ByteArray
{
	private const int CopyThreshold = 12;

	internal static void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
	{
		if (count > 12)
		{
			Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
			return;
		}
		int num = srcOffset + count;
		for (int i = srcOffset; i < num; i++)
		{
			dst[dstOffset++] = src[i];
		}
	}

	internal static void Reverse(byte[] bytes)
	{
		int num = 0;
		int num2 = bytes.Length - 1;
		while (num < num2)
		{
			byte b = bytes[num];
			bytes[num] = bytes[num2];
			bytes[num2] = b;
			num++;
			num2--;
		}
	}
}
