using System;
using System.IO;

namespace SevenZip.Compression.LZMA;

public static class SevenZipHelper
{
	private static int dictionary = 8388608;

	private static bool eos = false;

	private static CoderPropID[] propIDs = new CoderPropID[8]
	{
		CoderPropID.DictionarySize,
		CoderPropID.PosStateBits,
		CoderPropID.LitContextBits,
		CoderPropID.LitPosBits,
		CoderPropID.Algorithm,
		CoderPropID.NumFastBytes,
		CoderPropID.MatchFinder,
		CoderPropID.EndMarker
	};

	private static object[] properties = new object[8] { dictionary, 2, 3, 0, 2, 128, "bt4", eos };

	public static byte[] Compress(byte[] inputBytes)
	{
		MemoryStream memoryStream = new MemoryStream(inputBytes);
		MemoryStream memoryStream2 = new MemoryStream();
		Encoder encoder = new Encoder();
		encoder.SetCoderProperties(propIDs, properties);
		encoder.WriteCoderProperties(memoryStream2);
		long length = memoryStream.Length;
		for (int i = 0; i < 8; i++)
		{
			memoryStream2.WriteByte((byte)(length >> 8 * i));
		}
		encoder.Code(memoryStream, memoryStream2, -1L, -1L, null);
		return memoryStream2.ToArray();
	}

	public static byte[] Decompress(byte[] inputBytes)
	{
		MemoryStream memoryStream = new MemoryStream(inputBytes);
		Decoder decoder = new Decoder();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[5];
		if (memoryStream.Read(array, 0, 5) != 5)
		{
			throw new Exception("input .lzma is too short");
		}
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			if (num2 >= 0)
			{
				num |= (long)((ulong)(byte)num2 << 8 * i);
				continue;
			}
			throw new Exception("Can't Read 1");
		}
		decoder.SetDecoderProperties(array);
		long inSize = memoryStream.Length - memoryStream.Position;
		decoder.Code(memoryStream, memoryStream2, inSize, num, null);
		return memoryStream2.ToArray();
	}
}
