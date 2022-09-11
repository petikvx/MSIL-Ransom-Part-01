using System;
using System.IO;
using System.Reflection;
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

		public Inflater(byte[] byte_0)
		{
			input = new StreamManipulator();
			outputWindow = new OutputWindow();
			mode = 2;
			input.SetInput(byte_0, 0, byte_0.Length);
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
				return DecodeHuffman();
			default:
				return false;
			case 12:
				return false;
			}
		}

		public int Inflate(byte[] byte_0, int int_0, int int_1)
		{
			int num = 0;
			do
			{
				if (mode != 11)
				{
					int num2 = outputWindow.CopyOutput(byte_0, int_0, int_1);
					int_0 += num2;
					num += num2;
					int_1 -= num2;
					if (int_1 == 0)
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

		public int PeekBits(int int_0)
		{
			if (bits_in_buffer < int_0)
			{
				if (window_start == window_end)
				{
					return -1;
				}
				buffer |= (uint)(((window[window_start++] & 0xFF) | ((window[window_start++] & 0xFF) << 8)) << bits_in_buffer);
				bits_in_buffer += 16;
			}
			return (int)(buffer & ((1 << int_0) - 1));
		}

		public void DropBits(int int_0)
		{
			buffer >>= int_0;
			bits_in_buffer -= int_0;
		}

		public void SkipToByteBoundary()
		{
			buffer >>= bits_in_buffer & 7;
			bits_in_buffer &= -8;
		}

		public int CopyBytes(byte[] byte_0, int int_0, int int_1)
		{
			int num = 0;
			while (bits_in_buffer > 0 && int_1 > 0)
			{
				byte_0[int_0++] = (byte)buffer;
				buffer >>= 8;
				bits_in_buffer -= 8;
				int_1--;
				num++;
			}
			if (int_1 == 0)
			{
				return num;
			}
			int num2 = window_end - window_start;
			if (int_1 > num2)
			{
				int_1 = num2;
			}
			Array.Copy(window, window_start, byte_0, int_0, int_1);
			window_start += int_1;
			if (((uint)(window_start - window_end) & (true ? 1u : 0u)) != 0)
			{
				buffer = window[window_start++] & 0xFFu;
				bits_in_buffer = 8;
			}
			return num + int_1;
		}

		public void SetInput(byte[] byte_0, int int_0, int int_1)
		{
			if (window_start < window_end)
			{
				throw new InvalidOperationException();
			}
			int num = int_0 + int_1;
			if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
			{
				if (((uint)int_1 & (true ? 1u : 0u)) != 0)
				{
					buffer |= (uint)((byte_0[int_0++] & 0xFF) << bits_in_buffer);
					bits_in_buffer += 8;
				}
				window = byte_0;
				window_start = int_0;
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

		public void Write(int int_0)
		{
			if (windowFilled++ == 32768)
			{
				throw new InvalidOperationException();
			}
			window[windowEnd++] = (byte)int_0;
			windowEnd &= 32767;
		}

		private void SlowRepeat(int int_0, int int_1, int int_2)
		{
			while (int_1-- > 0)
			{
				window[windowEnd++] = window[int_0++];
				windowEnd &= 32767;
				int_0 &= 0x7FFF;
			}
		}

		public void Repeat(int int_0, int int_1)
		{
			if ((windowFilled += int_0) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (windowEnd - int_1) & 0x7FFF;
			int num2 = 32768 - int_0;
			if (num <= num2 && windowEnd < num2)
			{
				if (int_0 <= int_1)
				{
					Array.Copy(window, num, window, windowEnd, int_0);
					windowEnd += int_0;
				}
				else
				{
					while (int_0-- > 0)
					{
						window[windowEnd++] = window[num++];
					}
				}
			}
			else
			{
				SlowRepeat(num, int_0, int_1);
			}
		}

		public int CopyStored(StreamManipulator streamManipulator_0, int int_0)
		{
			int_0 = Math.Min(Math.Min(int_0, 32768 - windowFilled), streamManipulator_0.AvailableBytes);
			int num = 32768 - windowEnd;
			int num2;
			if (int_0 > num)
			{
				num2 = streamManipulator_0.CopyBytes(window, windowEnd, num);
				if (num2 == num)
				{
					num2 += streamManipulator_0.CopyBytes(window, 0, int_0 - num);
				}
			}
			else
			{
				num2 = streamManipulator_0.CopyBytes(window, windowEnd, int_0);
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

		public int CopyOutput(byte[] byte_0, int int_0, int int_1)
		{
			int num = windowEnd;
			if (int_1 > windowFilled)
			{
				int_1 = windowFilled;
			}
			else
			{
				num = (windowEnd - windowFilled + int_1) & 0x7FFF;
			}
			int num2 = int_1;
			int num3 = int_1 - num;
			if (num3 > 0)
			{
				Array.Copy(window, 32768 - num3, byte_0, int_0, num3);
				int_0 += num3;
				int_1 = num;
			}
			Array.Copy(window, num - int_1, byte_0, int_0, int_1);
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

		public InflaterHuffmanTree(byte[] byte_0)
		{
			BuildTree(byte_0);
		}

		private void BuildTree(byte[] byte_0)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			foreach (int num in byte_0)
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
			for (int l = 0; l < byte_0.Length; l++)
			{
				int num9 = byte_0[l];
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

		public int GetSymbol(StreamManipulator streamManipulator_0)
		{
			int num;
			int num2;
			if ((num = streamManipulator_0.PeekBits(9)) >= 0)
			{
				if ((num2 = tree[num]) >= 0)
				{
					streamManipulator_0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int num3 = -(num2 >> 4);
				int int_ = num2 & 0xF;
				if ((num = streamManipulator_0.PeekBits(int_)) >= 0)
				{
					num2 = tree[num3 | (num >> 9)];
					streamManipulator_0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				int availableBits = streamManipulator_0.AvailableBits;
				num = streamManipulator_0.PeekBits(availableBits);
				num2 = tree[num3 | (num >> 9)];
				if ((num2 & 0xF) <= availableBits)
				{
					streamManipulator_0.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			int availableBits2 = streamManipulator_0.AvailableBits;
			num = streamManipulator_0.PeekBits(availableBits2);
			num2 = tree[num];
			if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
			{
				streamManipulator_0.DropBits(num2 & 0xF);
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

		public bool Decode(StreamManipulator streamManipulator_0)
		{
			while (true)
			{
				switch (mode)
				{
				case 5:
				{
					int int_ = repBits[repSymbol];
					int num = streamManipulator_0.PeekBits(int_);
					if (num >= 0)
					{
						streamManipulator_0.DropBits(int_);
						num += repMin[repSymbol];
						while (num-- > 0)
						{
							litdistLens[ptr++] = lastLen;
						}
						if (ptr == this.num)
						{
							return true;
						}
						goto IL_00a0;
					}
					return false;
				}
				case 4:
				{
					int symbol;
					while (((symbol = blTree.GetSymbol(streamManipulator_0)) & -16) == 0)
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
						int num2 = streamManipulator_0.PeekBits(3);
						if (num2 >= 0)
						{
							streamManipulator_0.DropBits(3);
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
					blnum = streamManipulator_0.PeekBits(4);
					if (blnum >= 0)
					{
						blnum += 4;
						streamManipulator_0.DropBits(4);
						blLens = new byte[19];
						ptr = 0;
						mode = 3;
						goto case 3;
					}
					return false;
				case 1:
					dnum = streamManipulator_0.PeekBits(5);
					if (dnum >= 0)
					{
						dnum++;
						streamManipulator_0.DropBits(5);
						this.num = lnum + dnum;
						litdistLens = new byte[this.num];
						mode = 2;
						goto case 2;
					}
					return false;
				case 0:
					lnum = streamManipulator_0.PeekBits(5);
					if (lnum >= 0)
					{
						lnum += 257;
						streamManipulator_0.DropBits(5);
						mode = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_00a0:
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

		public static short BitReverse(int int_0)
		{
			return (short)((bit4Reverse[int_0 & 0xF] << 12) | (bit4Reverse[(int_0 >> 4) & 0xF] << 8) | (bit4Reverse[(int_0 >> 8) & 0xF] << 4) | bit4Reverse[int_0 >> 12]);
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

		public ZipStream(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}

	private static bool PublicKeysMatch(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	private static ICryptoTransform GetAesTransform(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	private static ICryptoTransform GetDesTransform(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	public static byte[] Unzip(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !PublicKeysMatch(executingAssembly, callingAssembly))
		{
			return null;
		}
		ZipStream zipStream = new ZipStream(byte_0);
		byte[] array = new byte[0];
		int num = zipStream.ReadInt();
		if (num == 67324752)
		{
			short num2 = (short)zipStream.ReadShort();
			int num3 = zipStream.ReadShort();
			int num4 = zipStream.ReadShort();
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			zipStream.ReadInt();
			zipStream.ReadInt();
			zipStream.ReadInt();
			int num5 = zipStream.ReadInt();
			int num6 = zipStream.ReadShort();
			int num7 = zipStream.ReadShort();
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				zipStream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				zipStream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[zipStream.Length - zipStream.Position];
			zipStream.Read(array2, 0, array2.Length);
			Inflater inflater = new Inflater(array2);
			array = new byte[num5];
			inflater.Inflate(array, 0, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = zipStream.ReadInt();
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = zipStream.ReadInt();
					num11 = zipStream.ReadInt();
					byte[] array3 = new byte[num10];
					zipStream.Read(array3, 0, array3.Length);
					new Inflater(array3).Inflate(array, i, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 199, 67, 136, 196, 58, 41, 6, 90 };
				byte[] byte_2 = new byte[8] { 103, 233, 220, 17, 195, 25, 62, 122 };
				using ICryptoTransform cryptoTransform = GetDesTransform(byte_, byte_2, bool_0: true);
				array = Unzip(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
			if (num8 == 3)
			{
				byte[] byte_3 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_4 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using ICryptoTransform cryptoTransform2 = GetAesTransform(byte_3, byte_4, bool_0: true);
				array = Unzip(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		zipStream.Close();
		zipStream = null;
		return array;
	}
}
