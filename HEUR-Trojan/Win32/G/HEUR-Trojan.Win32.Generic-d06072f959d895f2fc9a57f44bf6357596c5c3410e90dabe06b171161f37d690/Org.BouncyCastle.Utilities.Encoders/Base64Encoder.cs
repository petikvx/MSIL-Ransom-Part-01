using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders;

public class Base64Encoder : IEncoder
{
	protected readonly byte[] encodingTable = new byte[64]
	{
		65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
		75, 76, 77, 78, 79, 80, 81, 82, 83, 84,
		85, 86, 87, 88, 89, 90, 97, 98, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108, 109, 110,
		111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
		121, 122, 48, 49, 50, 51, 52, 53, 54, 55,
		56, 57, 43, 47
	};

	protected byte padding = 61;

	protected readonly byte[] decodingTable = new byte[128];

	protected void InitialiseDecodingTable()
	{
		Arrays.Fill(decodingTable, byte.MaxValue);
		for (int i = 0; i < encodingTable.Length; i++)
		{
			decodingTable[encodingTable[i]] = (byte)i;
		}
	}

	public Base64Encoder()
	{
		InitialiseDecodingTable();
	}

	public int Encode(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
	{
		int num = inOff;
		int num2 = inOff + inLen - 2;
		int num3 = outOff;
		while (num < num2)
		{
			uint num4 = inBuf[num++];
			uint num5 = inBuf[num++];
			uint num6 = inBuf[num++];
			outBuf[num3++] = encodingTable[(num4 >> 2) & 0x3F];
			outBuf[num3++] = encodingTable[((num4 << 4) | (num5 >> 4)) & 0x3F];
			outBuf[num3++] = encodingTable[((num5 << 2) | (num6 >> 6)) & 0x3F];
			outBuf[num3++] = encodingTable[num6 & 0x3F];
		}
		switch (inLen - (num - inOff))
		{
		case 2:
		{
			uint num8 = inBuf[num++];
			uint num9 = inBuf[num++];
			outBuf[num3++] = encodingTable[(num8 >> 2) & 0x3F];
			outBuf[num3++] = encodingTable[((num8 << 4) | (num9 >> 4)) & 0x3F];
			outBuf[num3++] = encodingTable[(num9 << 2) & 0x3F];
			outBuf[num3++] = padding;
			break;
		}
		case 1:
		{
			uint num7 = inBuf[num++];
			outBuf[num3++] = encodingTable[(num7 >> 2) & 0x3F];
			outBuf[num3++] = encodingTable[(num7 << 4) & 0x3F];
			outBuf[num3++] = padding;
			outBuf[num3++] = padding;
			break;
		}
		}
		return num3 - outOff;
	}

	public int Encode(byte[] buf, int off, int len, Stream outStream)
	{
		if (len < 0)
		{
			return 0;
		}
		byte[] array = new byte[72];
		int num = len;
		while (num > 0)
		{
			int num2 = System.Math.Min(54, num);
			int count = Encode(buf, off, num2, array, 0);
			outStream.Write(array, 0, count);
			off += num2;
			num -= num2;
		}
		return (len + 2) / 3 * 4;
	}

	private bool Ignore(char c)
	{
		if (c != '\n' && c != '\r' && c != '\t')
		{
			return c == ' ';
		}
		return true;
	}

	public int Decode(byte[] data, int off, int length, Stream outStream)
	{
		byte[] array = new byte[54];
		int num = 0;
		int num2 = 0;
		int num3 = off + length;
		while (num3 > off && Ignore((char)data[num3 - 1]))
		{
			num3--;
		}
		int i = off;
		int num4 = num3 - 4;
		i = NextI(data, i, num4);
		while (true)
		{
			if (i < num4)
			{
				byte b = decodingTable[data[i++]];
				i = NextI(data, i, num4);
				byte b2 = decodingTable[data[i++]];
				i = NextI(data, i, num4);
				byte b3 = decodingTable[data[i++]];
				i = NextI(data, i, num4);
				byte b4 = decodingTable[data[i++]];
				if ((b | b2 | b3 | b4) < 128)
				{
					array[num++] = (byte)((b << 2) | (b2 >> 4));
					array[num++] = (byte)((b2 << 4) | (b3 >> 2));
					array[num++] = (byte)((b3 << 6) | b4);
					if (num == array.Length)
					{
						outStream.Write(array, 0, num);
						num = 0;
					}
					num2 += 3;
					i = NextI(data, i, num4);
					continue;
				}
				throw new IOException("invalid characters encountered in base64 data");
			}
			if (num > 0)
			{
				outStream.Write(array, 0, num);
			}
			break;
		}
		int num5 = NextI(data, i, num3);
		int num6 = NextI(data, num5 + 1, num3);
		int num7 = NextI(data, num6 + 1, num3);
		int num8 = NextI(data, num7 + 1, num3);
		return num2 + DecodeLastBlock(outStream, (char)data[num5], (char)data[num6], (char)data[num7], (char)data[num8]);
	}

	private int NextI(byte[] data, int i, int finish)
	{
		while (i < finish && Ignore((char)data[i]))
		{
			i++;
		}
		return i;
	}

	public int DecodeString(string data, Stream outStream)
	{
		int num = 0;
		int num2 = data.Length;
		while (num2 > 0 && Ignore(data[num2 - 1]))
		{
			num2--;
		}
		int num3 = 0;
		int num4 = num2 - 4;
		num3 = NextI(data, 0, num4);
		while (num3 < num4)
		{
			byte b = decodingTable[(uint)data[num3++]];
			num3 = NextI(data, num3, num4);
			byte b2 = decodingTable[(uint)data[num3++]];
			num3 = NextI(data, num3, num4);
			byte b3 = decodingTable[(uint)data[num3++]];
			num3 = NextI(data, num3, num4);
			byte b4 = decodingTable[(uint)data[num3++]];
			if ((b | b2 | b3 | b4) < 128)
			{
				outStream.WriteByte((byte)((b << 2) | (b2 >> 4)));
				outStream.WriteByte((byte)((b2 << 4) | (b3 >> 2)));
				outStream.WriteByte((byte)((b3 << 6) | b4));
				num += 3;
				num3 = NextI(data, num3, num4);
				continue;
			}
			throw new IOException("invalid characters encountered in base64 data");
		}
		return num + DecodeLastBlock(outStream, data[num2 - 4], data[num2 - 3], data[num2 - 2], data[num2 - 1]);
	}

	private int DecodeLastBlock(Stream outStream, char c1, char c2, char c3, char c4)
	{
		if (c3 == padding)
		{
			if (c4 != padding)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			byte b = decodingTable[(uint)c1];
			byte b2 = decodingTable[(uint)c2];
			if ((b | b2) >= 128)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			outStream.WriteByte((byte)((b << 2) | (b2 >> 4)));
			return 1;
		}
		if (c4 == padding)
		{
			byte b3 = decodingTable[(uint)c1];
			byte b4 = decodingTable[(uint)c2];
			byte b5 = decodingTable[(uint)c3];
			if ((b3 | b4 | b5) >= 128)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			outStream.WriteByte((byte)((b3 << 2) | (b4 >> 4)));
			outStream.WriteByte((byte)((b4 << 4) | (b5 >> 2)));
			return 2;
		}
		byte b6 = decodingTable[(uint)c1];
		byte b7 = decodingTable[(uint)c2];
		byte b8 = decodingTable[(uint)c3];
		byte b9 = decodingTable[(uint)c4];
		if ((b6 | b7 | b8 | b9) >= 128)
		{
			throw new IOException("invalid characters encountered at end of base64 data");
		}
		outStream.WriteByte((byte)((b6 << 2) | (b7 >> 4)));
		outStream.WriteByte((byte)((b7 << 4) | (b8 >> 2)));
		outStream.WriteByte((byte)((b8 << 6) | b9));
		return 3;
	}

	private int NextI(string data, int i, int finish)
	{
		while (i < finish && Ignore(data[i]))
		{
			i++;
		}
		return i;
	}
}
