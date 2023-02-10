using System;
using System.IO;
using System.Runtime.CompilerServices;
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

		public Inflater(byte[] P_0)
		{
			input = new StreamManipulator();
			outputWindow = new OutputWindow();
			mode = 2;
			input.SetInput(P_0, 0, P_0.Length);
		}

		private bool DecodeHuffman()
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
					if (symbol < 257)
					{
						if (symbol < 0)
						{
							return false;
						}
						distTree = null;
						litlenTree = null;
						mode = 2;
						return true;
					}
					repLength = CPLENS[symbol - 257];
					neededBits = CPLEXT[symbol - 257];
					goto case 8;
				}
				case 8:
					if (neededBits > 0)
					{
						mode = 8;
						int num2 = input.PeekBits(neededBits);
						if (num2 < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repLength += num2;
					}
					mode = 9;
					goto case 9;
				case 9:
				{
					int symbol = distTree.GetSymbol(input);
					if (symbol < 0)
					{
						return false;
					}
					repDist = CPDIST[symbol];
					neededBits = CPDEXT[symbol];
					break;
				}
				case 10:
					break;
				default:
					continue;
				}
				if (neededBits > 0)
				{
					mode = 10;
					int num3 = input.PeekBits(neededBits);
					if (num3 < 0)
					{
						return false;
					}
					input.DropBits(neededBits);
					repDist += num3;
				}
				outputWindow.Repeat(repLength, repDist);
				num -= repLength;
				mode = 7;
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
				return !input.get_IsNeedingInput();
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
				return DecodeHuffman();
			case 12:
				return false;
			default:
				return false;
			}
		}

		public int Inflate(byte[] P_0, int P_1, int P_2)
		{
			int num = 0;
			do
			{
				if (mode != 11)
				{
					int num2 = outputWindow.CopyOutput(P_0, P_1, P_2);
					P_1 += num2;
					num += num2;
					P_2 -= num2;
					if (P_2 == 0)
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

		public int PeekBits(int P_0)
		{
			if (bits_in_buffer < P_0)
			{
				if (window_start == window_end)
				{
					return -1;
				}
				buffer |= (uint)(((window[window_start++] & 0xFF) | ((window[window_start++] & 0xFF) << 8)) << bits_in_buffer);
				bits_in_buffer += 16;
			}
			return (int)(buffer & ((1 << P_0) - 1));
		}

		public void DropBits(int P_0)
		{
			buffer >>= P_0;
			bits_in_buffer -= P_0;
		}

		[SpecialName]
		public int get_AvailableBits()
		{
			return bits_in_buffer;
		}

		[SpecialName]
		public int get_AvailableBytes()
		{
			return window_end - window_start + (bits_in_buffer >> 3);
		}

		public void SkipToByteBoundary()
		{
			buffer >>= bits_in_buffer & 7;
			bits_in_buffer &= -8;
		}

		[SpecialName]
		public bool get_IsNeedingInput()
		{
			return window_start == window_end;
		}

		public int CopyBytes(byte[] P_0, int P_1, int P_2)
		{
			int num = 0;
			while (bits_in_buffer > 0 && P_2 > 0)
			{
				P_0[P_1++] = (byte)buffer;
				buffer >>= 8;
				bits_in_buffer -= 8;
				P_2--;
				num++;
			}
			if (P_2 == 0)
			{
				return num;
			}
			int num2 = window_end - window_start;
			if (P_2 > num2)
			{
				P_2 = num2;
			}
			Array.Copy(window, window_start, P_0, P_1, P_2);
			window_start += P_2;
			if (((uint)(window_start - window_end) & (true ? 1u : 0u)) != 0)
			{
				buffer = window[window_start++] & 0xFFu;
				bits_in_buffer = 8;
			}
			return num + P_2;
		}

		public void SetInput(byte[] P_0, int P_1, int P_2)
		{
			if (window_start < window_end)
			{
				throw new InvalidOperationException();
			}
			int num = P_1 + P_2;
			if (0 > P_1 || P_1 > num || num > P_0.Length)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (((uint)P_2 & (true ? 1u : 0u)) != 0)
			{
				buffer |= (uint)((P_0[P_1++] & 0xFF) << bits_in_buffer);
				bits_in_buffer += 8;
			}
			window = P_0;
			window_start = P_1;
			window_end = num;
		}
	}

	internal sealed class OutputWindow
	{
		private byte[] window = new byte[32768];

		private int windowEnd;

		private int windowFilled;

		public void Write(int P_0)
		{
			if (windowFilled++ == 32768)
			{
				throw new InvalidOperationException();
			}
			window[windowEnd++] = (byte)P_0;
			windowEnd &= 32767;
		}

		private void SlowRepeat(int P_0, int P_1)
		{
			while (P_1-- > 0)
			{
				window[windowEnd++] = window[P_0++];
				windowEnd &= 32767;
				P_0 &= 0x7FFF;
			}
		}

		public void Repeat(int P_0, int P_1)
		{
			if ((windowFilled += P_0) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (windowEnd - P_1) & 0x7FFF;
			int num2 = 32768 - P_0;
			if (num <= num2 && windowEnd < num2)
			{
				if (P_0 <= P_1)
				{
					Array.Copy(window, num, window, windowEnd, P_0);
					windowEnd += P_0;
				}
				else
				{
					while (P_0-- > 0)
					{
						window[windowEnd++] = window[num++];
					}
				}
			}
			else
			{
				SlowRepeat(num, P_0);
			}
		}

		public int CopyStored(StreamManipulator P_0, int P_1)
		{
			P_1 = Math.Min(Math.Min(P_1, 32768 - windowFilled), P_0.get_AvailableBytes());
			int num = 32768 - windowEnd;
			int num2;
			if (P_1 > num)
			{
				num2 = P_0.CopyBytes(window, windowEnd, num);
				if (num2 == num)
				{
					num2 += P_0.CopyBytes(window, 0, P_1 - num);
				}
			}
			else
			{
				num2 = P_0.CopyBytes(window, windowEnd, P_1);
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

		public int CopyOutput(byte[] P_0, int P_1, int P_2)
		{
			int num = windowEnd;
			if (P_2 > windowFilled)
			{
				P_2 = windowFilled;
			}
			else
			{
				num = (windowEnd - windowFilled + P_2) & 0x7FFF;
			}
			int num2 = P_2;
			int num3 = P_2 - num;
			if (num3 > 0)
			{
				Array.Copy(window, 32768 - num3, P_0, P_1, num3);
				P_1 += num3;
				P_2 = num;
			}
			Array.Copy(window, num - P_2, P_0, P_1, P_2);
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

		public InflaterHuffmanTree(byte[] P_0)
		{
			BuildTree(P_0);
		}

		private void BuildTree(byte[] P_0)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			foreach (int num in P_0)
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
			for (int l = 0; l < P_0.Length; l++)
			{
				int num9 = P_0[l];
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

		public int GetSymbol(StreamManipulator P_0)
		{
			int num;
			int num2;
			if ((num = P_0.PeekBits(9)) >= 0)
			{
				if ((num2 = tree[num]) >= 0)
				{
					P_0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int num4 = num2 & 0xF;
				if ((num = P_0.PeekBits(num4)) >= 0)
				{
					num2 = tree[num3 | (num >> 9)];
					P_0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = P_0.get_AvailableBits();
				num = P_0.PeekBits(availableBits);
				num2 = tree[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					P_0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int availableBits2 = P_0.get_AvailableBits();
			num = P_0.PeekBits(availableBits2);
			num2 = tree[num];
			if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
			{
				P_0.DropBits(num2 & 0xF);
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

		public bool Decode(StreamManipulator P_0)
		{
			while (true)
			{
				switch (mode)
				{
				default:
					continue;
				case 0:
					lnum = P_0.PeekBits(5);
					if (lnum < 0)
					{
						return false;
					}
					lnum += 257;
					P_0.DropBits(5);
					mode = 1;
					goto case 1;
				case 1:
					dnum = P_0.PeekBits(5);
					if (dnum < 0)
					{
						return false;
					}
					dnum++;
					P_0.DropBits(5);
					this.num = lnum + dnum;
					litdistLens = new byte[this.num];
					mode = 2;
					goto case 2;
				case 2:
					blnum = P_0.PeekBits(4);
					if (blnum < 0)
					{
						return false;
					}
					blnum += 4;
					P_0.DropBits(4);
					blLens = new byte[19];
					ptr = 0;
					mode = 3;
					goto case 3;
				case 3:
					while (ptr < blnum)
					{
						int num = P_0.PeekBits(3);
						if (num < 0)
						{
							return false;
						}
						P_0.DropBits(3);
						blLens[BL_ORDER[ptr]] = (byte)num;
						ptr++;
					}
					blTree = new InflaterHuffmanTree(blLens);
					blLens = null;
					ptr = 0;
					mode = 4;
					goto case 4;
				case 4:
				{
					int symbol;
					while (((symbol = blTree.GetSymbol(P_0)) & -16) == 0)
					{
						litdistLens[ptr++] = (lastLen = (byte)symbol);
						if (ptr == this.num)
						{
							return true;
						}
					}
					if (symbol < 0)
					{
						return false;
					}
					if (symbol >= 17)
					{
						lastLen = 0;
					}
					repSymbol = symbol - 16;
					mode = 5;
					break;
				}
				case 5:
					break;
				}
				int num2 = repBits[repSymbol];
				int num3 = P_0.PeekBits(num2);
				if (num3 < 0)
				{
					return false;
				}
				P_0.DropBits(num2);
				num3 += repMin[repSymbol];
				while (num3-- > 0)
				{
					litdistLens[ptr++] = lastLen;
				}
				if (ptr == this.num)
				{
					break;
				}
				mode = 4;
			}
			return true;
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

		public static short BitReverse(int P_0)
		{
			return (short)((bit4Reverse[P_0 & 0xF] << 12) | (bit4Reverse[(P_0 >> 4) & 0xF] << 8) | (bit4Reverse[(P_0 >> 8) & 0xF] << 4) | bit4Reverse[P_0 >> 12]);
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

		public ZipStream(byte[] P_0)
			: base(P_0, writable: false)
		{
		}
	}

	private static ICryptoTransform GetAesTransform(byte[] P_0, byte[] P_1, bool P_2)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		return P_2 ? rijndaelManaged.CreateDecryptor(P_0, P_1) : rijndaelManaged.CreateEncryptor(P_0, P_1);
	}

	public static byte[] Unzip(byte[] P_0)
	{
		ZipStream zipStream = new ZipStream(P_0);
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
					byte[] array4 = new byte[num4];
					zipStream.Read(array4, 0, array4.Length);
					new Inflater(array4).Inflate(array, i, num5);
				}
				break;
			}
			case 3:
			{
				byte[] array2 = new byte[16]
				{
					191, 102, 20, 254, 242, 20, 243, 198, 209, 180,
					94, 133, 160, 3, 129, 170
				};
				byte[] array3 = new byte[16]
				{
					170, 174, 80, 82, 215, 137, 211, 179, 164, 152,
					196, 111, 46, 132, 113, 216
				};
				using (ICryptoTransform cryptoTransform = GetAesTransform(array2, array3, true))
				{
					array = Unzip(cryptoTransform.TransformFinalBlock(P_0, 4, P_0.Length - 4));
				}
				break;
			}
			default:
				throw new ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.");
			}
			zipStream.Close();
			zipStream = null;
			return array;
		}
		throw new FormatException("Unknown Header");
	}
}
