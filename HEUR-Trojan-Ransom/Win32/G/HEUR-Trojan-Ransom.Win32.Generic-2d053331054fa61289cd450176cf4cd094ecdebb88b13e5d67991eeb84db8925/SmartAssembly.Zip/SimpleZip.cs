using System;
using System.IO;
using System.Security.Cryptography;

namespace SmartAssembly.Zip;

public static class SimpleZip
{
	internal sealed class Inflater
	{
		private static readonly int[] CPLENS = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static readonly int[] CPLEXT = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static readonly int[] CPDIST = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static readonly int[] CPDEXT = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		private int mode;

		private int neededBits;

		private int repLength;

		private int repDist;

		private int uncomprLen;

		private bool isLastBlock;

		private StreamManipulator input;

		private OutputWindow outputWindow;

		private InflaterDynHeader dynHeader;

		private InflaterHuffmanTree litlenTree;

		private InflaterHuffmanTree distTree;

		public Inflater(byte[] p0)
		{
			input = new StreamManipulator();
			outputWindow = new OutputWindow();
			mode = 2;
			input.SetInput(p0, 0, p0.Length);
		}

		private bool DecodeHuffmen()
		{
			int num = outputWindow.GetFreeSpace();
			while (num >= 258)
			{
				switch (mode)
				{
				case 7:
				{
					int symbol;
					while (((symbol = litlenTree.GetSymbol(input)) & -256) == 0)
					{
						outputWindow.Write(symbol);
						if (--num < 258)
						{
							return true;
						}
					}
					if (symbol >= 257)
					{
						repLength = CPLENS[symbol - 257];
						neededBits = CPLEXT[symbol - 257];
						goto case 8;
					}
					if (symbol < 0)
					{
						return false;
					}
					distTree = null;
					litlenTree = null;
					mode = 2;
					return true;
				}
				case 8:
					if (neededBits > 0)
					{
						mode = 8;
						int num3 = input.PeekBits(neededBits);
						if (num3 < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repLength += num3;
					}
					mode = 9;
					goto case 9;
				case 9:
				{
					int symbol = distTree.GetSymbol(input);
					if (symbol >= 0)
					{
						repDist = CPDIST[symbol];
						neededBits = CPDEXT[symbol];
						goto case 10;
					}
					return false;
				}
				case 10:
					if (neededBits > 0)
					{
						mode = 10;
						int num2 = input.PeekBits(neededBits);
						if (num2 < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repDist += num2;
					}
					outputWindow.Repeat(repLength, repDist);
					num -= repLength;
					mode = 7;
					break;
				}
			}
			return true;
		}

		private bool Decode()
		{
			switch (mode)
			{
			case 2:
			{
				if (isLastBlock)
				{
					mode = 12;
					return false;
				}
				int num = input.PeekBits(3);
				if (num < 0)
				{
					return false;
				}
				input.DropBits(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					isLastBlock = true;
				}
				switch (num >> 1)
				{
				case 0:
					input.SkipToByteBoundary();
					mode = 3;
					break;
				case 1:
					litlenTree = InflaterHuffmanTree.defLitLenTree;
					distTree = InflaterHuffmanTree.defDistTree;
					mode = 7;
					break;
				case 2:
					dynHeader = new InflaterDynHeader();
					mode = 6;
					break;
				}
				return true;
			}
			case 3:
				if ((uncomprLen = input.PeekBits(16)) < 0)
				{
					return false;
				}
				input.DropBits(16);
				mode = 4;
				goto case 4;
			case 4:
				if (input.PeekBits(16) < 0)
				{
					return false;
				}
				input.DropBits(16);
				mode = 5;
				goto case 5;
			case 5:
			{
				int num2 = outputWindow.CopyStored(input, uncomprLen);
				uncomprLen -= num2;
				if (uncomprLen == 0)
				{
					mode = 2;
					return true;
				}
				return !input.IsNeedingInput;
			}
			case 6:
				if (!dynHeader.Decode(input))
				{
					return false;
				}
				litlenTree = dynHeader.BuildLitLenTree();
				distTree = dynHeader.BuildDistTree();
				mode = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return DecodeHuffmen();
			default:
				return false;
			case 12:
				return false;
			}
		}

		public int Inflate(byte[] p0, int p1, int p2)
		{
			int num = 0;
			do
			{
				if (mode != 11)
				{
					int num2 = outputWindow.CopyOutput(p0, p1, p2);
					p1 += num2;
					num += num2;
					p2 -= num2;
					if (p2 == 0)
					{
						return num;
					}
				}
			}
			while (Decode() || (outputWindow.GetAvailable() > 0 && mode != 11));
			return num;
		}
	}

	internal sealed class StreamManipulator
	{
		private byte[] window;

		private int window_start;

		private int window_end;

		private uint buffer;

		private int bits_in_buffer;

		public int AvailableBits => bits_in_buffer;

		public int AvailableBytes => window_end - window_start + (bits_in_buffer >> 3);

		public bool IsNeedingInput => window_start == window_end;

		public int PeekBits(int p0)
		{
			if (bits_in_buffer < p0)
			{
				if (window_start == window_end)
				{
					return -1;
				}
				buffer |= (uint)(((window[window_start++] & 0xFF) | ((window[window_start++] & 0xFF) << 8)) << bits_in_buffer);
				bits_in_buffer += 16;
			}
			return (int)(buffer & ((1 << p0) - 1));
		}

		public void DropBits(int p0)
		{
			buffer >>= p0;
			bits_in_buffer -= p0;
		}

		public void SkipToByteBoundary()
		{
			buffer >>= bits_in_buffer & 7;
			bits_in_buffer &= -8;
		}

		public int CopyBytes(byte[] p0, int p1, int p2)
		{
			int num = 0;
			while (bits_in_buffer > 0 && p2 > 0)
			{
				p0[p1++] = (byte)buffer;
				buffer >>= 8;
				bits_in_buffer -= 8;
				p2--;
				num++;
			}
			if (p2 == 0)
			{
				return num;
			}
			int num2 = window_end - window_start;
			if (p2 > num2)
			{
				p2 = num2;
			}
			Array.Copy(window, window_start, p0, p1, p2);
			window_start += p2;
			if (((uint)(window_start - window_end) & (true ? 1u : 0u)) != 0)
			{
				buffer = window[window_start++] & 0xFFu;
				bits_in_buffer = 8;
			}
			return num + p2;
		}

		public void SetInput(byte[] p0, int p1, int p2)
		{
			if (window_start < window_end)
			{
				throw new InvalidOperationException();
			}
			int num = p1 + p2;
			if (0 <= p1 && p1 <= num && num <= p0.Length)
			{
				if (((uint)p2 & (true ? 1u : 0u)) != 0)
				{
					buffer |= (uint)((p0[p1++] & 0xFF) << bits_in_buffer);
					bits_in_buffer += 8;
				}
				window = p0;
				window_start = p1;
				window_end = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	internal sealed class OutputWindow
	{
		private byte[] window = new byte[32768];

		private int windowEnd;

		private int windowFilled;

		public void Write(int p0)
		{
			if (windowFilled++ == 32768)
			{
				throw new InvalidOperationException();
			}
			window[windowEnd++] = (byte)p0;
			windowEnd &= 32767;
		}

		private void SlowRepeat(int p0, int p1)
		{
			while (p1-- > 0)
			{
				window[windowEnd++] = window[p0++];
				windowEnd &= 32767;
				p0 &= 0x7FFF;
			}
		}

		public void Repeat(int p0, int p1)
		{
			if ((windowFilled += p0) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (windowEnd - p1) & 0x7FFF;
			int num2 = 32768 - p0;
			if (num <= num2 && windowEnd < num2)
			{
				if (p0 <= p1)
				{
					Array.Copy(window, num, window, windowEnd, p0);
					windowEnd += p0;
				}
				else
				{
					while (p0-- > 0)
					{
						window[windowEnd++] = window[num++];
					}
				}
			}
			else
			{
				SlowRepeat(num, p0);
			}
		}

		public int CopyStored(StreamManipulator p0, int p1)
		{
			p1 = Math.Min(Math.Min(p1, 32768 - windowFilled), p0.AvailableBytes);
			int num = 32768 - windowEnd;
			int num2;
			if (p1 > num)
			{
				num2 = p0.CopyBytes(window, windowEnd, num);
				if (num2 == num)
				{
					num2 += p0.CopyBytes(window, 0, p1 - num);
				}
			}
			else
			{
				num2 = p0.CopyBytes(window, windowEnd, p1);
			}
			windowEnd = (windowEnd + num2) & 0x7FFF;
			windowFilled += num2;
			return num2;
		}

		public int GetFreeSpace()
		{
			return 32768 - windowFilled;
		}

		public int GetAvailable()
		{
			return windowFilled;
		}

		public int CopyOutput(byte[] p0, int p1, int p2)
		{
			int num = windowEnd;
			if (p2 > windowFilled)
			{
				p2 = windowFilled;
			}
			else
			{
				num = (windowEnd - windowFilled + p2) & 0x7FFF;
			}
			int num2 = p2;
			int num3 = p2 - num;
			if (num3 > 0)
			{
				Array.Copy(window, 32768 - num3, p0, p1, num3);
				p1 += num3;
				p2 = num;
			}
			Array.Copy(window, num - p2, p0, p1, p2);
			windowFilled -= num2;
			if (windowFilled < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}
	}

	internal sealed class InflaterHuffmanTree
	{
		private short[] tree;

		public static readonly InflaterHuffmanTree defLitLenTree;

		public static readonly InflaterHuffmanTree defDistTree;

		static InflaterHuffmanTree()
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

		public InflaterHuffmanTree(byte[] p0)
		{
			BuildTree(p0);
		}

		private void BuildTree(byte[] p0)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			foreach (int num in p0)
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
			tree = new short[num3];
			int num6 = 512;
			for (int num7 = 15; num7 >= 10; num7--)
			{
				int num8 = num2 & 0x1FF80;
				num2 -= array[num7] << 16 - num7;
				for (int k = num2 & 0x1FF80; k < num8; k += 128)
				{
					tree[DeflaterHuffman.BitReverse(k)] = (short)((-num6 << 4) | num7);
					num6 += 1 << num7 - 9;
				}
			}
			for (int l = 0; l < p0.Length; l++)
			{
				int num9 = p0[l];
				if (num9 == 0)
				{
					continue;
				}
				num2 = array2[num9];
				int num10 = DeflaterHuffman.BitReverse(num2);
				if (num9 <= 9)
				{
					do
					{
						tree[num10] = (short)((l << 4) | num9);
						num10 += 1 << num9;
					}
					while (num10 < 512);
				}
				else
				{
					int num11 = tree[num10 & 0x1FF];
					int num12 = 1 << (num11 & 0xF);
					num11 = -(num11 >> 4);
					do
					{
						tree[num11 | (num10 >> 9)] = (short)((l << 4) | num9);
						num10 += 1 << num9;
					}
					while (num10 < num12);
				}
				array2[num9] = num2 + (1 << 16 - num9);
			}
		}

		public int GetSymbol(StreamManipulator p0)
		{
			int num;
			int num2;
			if ((num = p0.PeekBits(9)) >= 0)
			{
				if ((num2 = tree[num]) >= 0)
				{
					p0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int p = num2 & 0xF;
				if ((num = p0.PeekBits(p)) >= 0)
				{
					num2 = tree[num3 | (num >> 9)];
					p0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = p0.AvailableBits;
				num = p0.PeekBits(availableBits);
				num2 = tree[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					p0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int availableBits2 = p0.AvailableBits;
			num = p0.PeekBits(availableBits2);
			num2 = tree[num];
			if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
			{
				p0.DropBits(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class InflaterDynHeader
	{
		private static readonly int[] repMin = new int[3] { 3, 3, 11 };

		private static readonly int[] repBits = new int[3] { 2, 3, 7 };

		private byte[] blLens;

		private byte[] litdistLens;

		private InflaterHuffmanTree blTree;

		private int mode;

		private int lnum;

		private int dnum;

		private int blnum;

		private int num;

		private int repSymbol;

		private byte lastLen;

		private int ptr;

		private static readonly int[] BL_ORDER = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		public bool Decode(StreamManipulator p0)
		{
			while (true)
			{
				switch (mode)
				{
				case 5:
				{
					int p = repBits[repSymbol];
					int num = p0.PeekBits(p);
					if (num >= 0)
					{
						p0.DropBits(p);
						num += repMin[repSymbol];
						while (num-- > 0)
						{
							litdistLens[ptr++] = lastLen;
						}
						if (ptr == this.num)
						{
							return true;
						}
						goto IL_00a2;
					}
					return false;
				}
				case 4:
				{
					int symbol;
					while (((symbol = blTree.GetSymbol(p0)) & -16) == 0)
					{
						litdistLens[ptr++] = (lastLen = (byte)symbol);
						if (ptr == this.num)
						{
							return true;
						}
					}
					if (symbol >= 0)
					{
						if (symbol >= 17)
						{
							lastLen = 0;
						}
						repSymbol = symbol - 16;
						mode = 5;
						goto case 5;
					}
					return false;
				}
				case 3:
					while (ptr < blnum)
					{
						int num2 = p0.PeekBits(3);
						if (num2 >= 0)
						{
							p0.DropBits(3);
							blLens[BL_ORDER[ptr]] = (byte)num2;
							ptr++;
							continue;
						}
						return false;
					}
					blTree = new InflaterHuffmanTree(blLens);
					blLens = null;
					ptr = 0;
					mode = 4;
					goto case 4;
				case 2:
					blnum = p0.PeekBits(4);
					if (blnum >= 0)
					{
						blnum += 4;
						p0.DropBits(4);
						blLens = new byte[19];
						ptr = 0;
						mode = 3;
						goto case 3;
					}
					return false;
				case 1:
					dnum = p0.PeekBits(5);
					if (dnum >= 0)
					{
						dnum++;
						p0.DropBits(5);
						this.num = lnum + dnum;
						litdistLens = new byte[this.num];
						mode = 2;
						goto case 2;
					}
					return false;
				case 0:
					lnum = p0.PeekBits(5);
					if (lnum >= 0)
					{
						lnum += 257;
						p0.DropBits(5);
						mode = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_00a2:
				mode = 4;
			}
		}

		public InflaterHuffmanTree BuildLitLenTree()
		{
			byte[] array = new byte[lnum];
			Array.Copy(litdistLens, 0, array, 0, lnum);
			return new InflaterHuffmanTree(array);
		}

		public InflaterHuffmanTree BuildDistTree()
		{
			byte[] array = new byte[dnum];
			Array.Copy(litdistLens, lnum, array, 0, dnum);
			return new InflaterHuffmanTree(array);
		}
	}

	internal sealed class DeflaterHuffman
	{
		private static readonly int[] BL_ORDER;

		private static readonly byte[] bit4Reverse;

		private static readonly short[] staticLCodes;

		private static readonly byte[] staticLLength;

		private static readonly short[] staticDCodes;

		private static readonly byte[] staticDLength;

		public static short BitReverse(int p0)
		{
			return (short)((bit4Reverse[p0 & 0xF] << 12) | (bit4Reverse[(p0 >> 4) & 0xF] << 8) | (bit4Reverse[(p0 >> 8) & 0xF] << 4) | bit4Reverse[p0 >> 12]);
		}

		static DeflaterHuffman()
		{
			BL_ORDER = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			bit4Reverse = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			staticLCodes = new short[286];
			staticLLength = new byte[286];
			int num = 0;
			while (num < 144)
			{
				staticLCodes[num] = BitReverse(48 + num << 8);
				staticLLength[num++] = 8;
			}
			while (num < 256)
			{
				staticLCodes[num] = BitReverse(256 + num << 7);
				staticLLength[num++] = 9;
			}
			while (num < 280)
			{
				staticLCodes[num] = BitReverse(-256 + num << 9);
				staticLLength[num++] = 7;
			}
			while (num < 286)
			{
				staticLCodes[num] = BitReverse(-88 + num << 8);
				staticLLength[num++] = 8;
			}
			staticDCodes = new short[30];
			staticDLength = new byte[30];
			for (num = 0; num < 30; num++)
			{
				staticDCodes[num] = BitReverse(num << 11);
				staticDLength[num] = 5;
			}
		}
	}

	internal sealed class ZipStream : MemoryStream
	{
		public int ReadShort()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int ReadInt()
		{
			return ReadShort() | (ReadShort() << 16);
		}

		public ZipStream(byte[] p0)
			: base(p0, writable: false)
		{
		}
	}

	private static ICryptoTransform GetAesTransform(byte[] p0, byte[] p1, bool p2)
	{
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		return p2 ? aesCryptoServiceProvider.CreateDecryptor(p0, p1) : aesCryptoServiceProvider.CreateEncryptor(p0, p1);
	}

	public static byte[] Unzip(byte[] p0)
	{
		ZipStream zipStream = new ZipStream(p0);
		byte[] array = new byte[0];
		int num = zipStream.ReadInt();
		int num2 = num >> 24;
		if (num - (num2 << 24) == 8223355)
		{
			switch (num2)
			{
			case 1:
			{
				int num3 = zipStream.ReadInt();
				array = new byte[num3];
				int num5;
				for (int i = 0; i < num3; i += num5)
				{
					int num4 = zipStream.ReadInt();
					num5 = zipStream.ReadInt();
					byte[] array2 = new byte[num4];
					zipStream.Read(array2, 0, array2.Length);
					new Inflater(array2).Inflate(array, i, num5);
				}
				break;
			}
			default:
				throw new ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.");
			case 3:
			{
				byte[] p = new byte[16]
				{
					209, 187, 86, 181, 128, 102, 49, 174, 50, 170,
					253, 108, 83, 33, 38, 254
				};
				byte[] p2 = new byte[16]
				{
					181, 187, 11, 196, 157, 207, 41, 3, 133, 123,
					241, 71, 115, 220, 139, 10
				};
				using (ICryptoTransform cryptoTransform = GetAesTransform(p, p2, p2: true))
				{
					array = Unzip(cryptoTransform.TransformFinalBlock(p0, 4, p0.Length - 4));
				}
				break;
			}
			}
			zipStream.Close();
			zipStream = null;
			return array;
		}
		throw new FormatException("Unknown Header");
	}
}
