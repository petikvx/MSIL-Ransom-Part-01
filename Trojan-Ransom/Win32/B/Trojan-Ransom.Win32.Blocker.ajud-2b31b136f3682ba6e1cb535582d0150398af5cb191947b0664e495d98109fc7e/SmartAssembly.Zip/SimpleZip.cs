using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace SmartAssembly.Zip;

public class SimpleZip
{
	internal sealed class Inflater
	{
		private const int DECODE_HEADER = 0;

		private const int DECODE_DICT = 1;

		private const int DECODE_BLOCKS = 2;

		private const int DECODE_STORED_LEN1 = 3;

		private const int DECODE_STORED_LEN2 = 4;

		private const int DECODE_STORED = 5;

		private const int DECODE_DYN_HEADER = 6;

		private const int DECODE_HUFFMAN = 7;

		private const int DECODE_HUFFMAN_LENBITS = 8;

		private const int DECODE_HUFFMAN_DIST = 9;

		private const int DECODE_HUFFMAN_DISTBITS = 10;

		private const int DECODE_CHKSUM = 11;

		private const int FINISHED = 12;

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

		public Inflater(byte[] bytes)
		{
			input = new StreamManipulator();
			outputWindow = new OutputWindow();
			mode = 2;
			input.SetInput(bytes, 0, bytes.Length);
		}

		private unsafe bool DecodeHuffman()
		{
			void* ptr = stackalloc byte[12];
			int num = outputWindow.GetFreeSpace();
			while (num >= 258)
			{
				*(int*)((byte*)ptr + 8) = mode;
				switch (*(int*)((byte*)ptr + 8))
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
						*(int*)ptr = input.PeekBits(neededBits);
						if (*(int*)ptr < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repLength += *(int*)ptr;
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
						*(int*)((byte*)ptr + 4) = input.PeekBits(neededBits);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							return false;
						}
						input.DropBits(neededBits);
						repDist += *(int*)((byte*)ptr + 4);
					}
					outputWindow.Repeat(repLength, repDist);
					num -= repLength;
					mode = 7;
					break;
				}
			}
			return true;
		}

		private unsafe bool Decode()
		{
			void* ptr = stackalloc byte[12];
			switch (mode)
			{
			case 2:
				if (isLastBlock)
				{
					mode = 12;
					return false;
				}
				*(int*)ptr = input.PeekBits(3);
				if (*(int*)ptr < 0)
				{
					return false;
				}
				input.DropBits(3);
				if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
				{
					isLastBlock = true;
				}
				switch (*(int*)ptr >> 1)
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
			case 3:
				if ((uncomprLen = input.PeekBits(16)) < 0)
				{
					return false;
				}
				input.DropBits(16);
				mode = 4;
				goto case 4;
			case 4:
				*(int*)((byte*)ptr + 4) = input.PeekBits(16);
				if (*(int*)((byte*)ptr + 4) < 0)
				{
					return false;
				}
				input.DropBits(16);
				mode = 5;
				goto case 5;
			case 5:
				*(int*)((byte*)ptr + 8) = outputWindow.CopyStored(input, uncomprLen);
				uncomprLen -= *(int*)((byte*)ptr + 8);
				if (uncomprLen == 0)
				{
					mode = 2;
					return true;
				}
				return !input.IsNeedingInput;
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

		public unsafe int Inflate(byte[] buf, int offset, int len)
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = 0;
			do
			{
				if (mode != 11)
				{
					*(int*)((byte*)ptr + 4) = outputWindow.CopyOutput(buf, offset, len);
					offset += *(int*)((byte*)ptr + 4);
					*(int*)ptr += *(int*)((byte*)ptr + 4);
					len -= *(int*)((byte*)ptr + 4);
					if (len == 0)
					{
						return *(int*)ptr;
					}
				}
			}
			while (Decode() || (outputWindow.GetAvailable() > 0 && mode != 11));
			return *(int*)ptr;
		}
	}

	internal sealed class StreamManipulator
	{
		private byte[] window;

		private int window_start = 0;

		private int window_end = 0;

		private uint buffer = 0u;

		private int bits_in_buffer = 0;

		public int AvailableBits => bits_in_buffer;

		public int AvailableBytes => window_end - window_start + (bits_in_buffer >> 3);

		public bool IsNeedingInput => window_start == window_end;

		public int PeekBits(int n)
		{
			if (bits_in_buffer < n)
			{
				if (window_start == window_end)
				{
					return -1;
				}
				buffer |= (uint)(((window[window_start++] & 0xFF) | ((window[window_start++] & 0xFF) << 8)) << bits_in_buffer);
				bits_in_buffer += 16;
			}
			return (int)(buffer & ((1 << n) - 1));
		}

		public void DropBits(int n)
		{
			buffer >>= n;
			bits_in_buffer -= n;
		}

		public void SkipToByteBoundary()
		{
			buffer >>= bits_in_buffer & 7;
			bits_in_buffer &= -8;
		}

		public unsafe int CopyBytes(byte[] output, int offset, int length)
		{
			void* ptr = stackalloc byte[8];
			*(int*)ptr = 0;
			while (bits_in_buffer > 0 && length > 0)
			{
				output[offset++] = (byte)buffer;
				buffer >>= 8;
				bits_in_buffer -= 8;
				length--;
				(*(int*)ptr)++;
			}
			if (length == 0)
			{
				return *(int*)ptr;
			}
			*(int*)((byte*)ptr + 4) = window_end - window_start;
			if (length > *(int*)((byte*)ptr + 4))
			{
				length = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(window, window_start, output, offset, length);
			window_start += length;
			if (((uint)(window_start - window_end) & (true ? 1u : 0u)) != 0)
			{
				buffer = window[window_start++] & 0xFFu;
				bits_in_buffer = 8;
			}
			return *(int*)ptr + length;
		}

		public void Reset()
		{
			bits_in_buffer = 0;
			window_end = 0;
			window_start = 0;
			buffer = 0u;
		}

		public void SetInput(byte[] buf, int off, int len)
		{
			if (window_start < window_end)
			{
				throw new InvalidOperationException();
			}
			int num = off + len;
			if (0 <= off && off <= num && num <= buf.Length)
			{
				if (((uint)len & (true ? 1u : 0u)) != 0)
				{
					buffer |= (uint)((buf[off++] & 0xFF) << bits_in_buffer);
					bits_in_buffer += 8;
				}
				window = buf;
				window_start = off;
				window_end = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	internal sealed class OutputWindow
	{
		private const int WINDOW_SIZE = 32768;

		private const int WINDOW_MASK = 32767;

		private byte[] window = new byte[32768];

		private int windowEnd = 0;

		private int windowFilled = 0;

		public void Write(int abyte)
		{
			if (windowFilled++ == 32768)
			{
				throw new InvalidOperationException();
			}
			window[windowEnd++] = (byte)abyte;
			windowEnd &= 32767;
		}

		private void SlowRepeat(int repStart, int len, int dist)
		{
			while (len-- > 0)
			{
				window[windowEnd++] = window[repStart++];
				windowEnd &= 32767;
				repStart &= 0x7FFF;
			}
		}

		public void Repeat(int len, int dist)
		{
			if ((windowFilled += len) > 32768)
			{
				throw new InvalidOperationException();
			}
			int num = (windowEnd - dist) & 0x7FFF;
			int num2 = 32768 - len;
			if (num <= num2 && windowEnd < num2)
			{
				if (len <= dist)
				{
					Array.Copy(window, num, window, windowEnd, len);
					windowEnd += len;
				}
				else
				{
					while (len-- > 0)
					{
						window[windowEnd++] = window[num++];
					}
				}
			}
			else
			{
				SlowRepeat(num, len, dist);
			}
		}

		public unsafe int CopyStored(StreamManipulator input, int len)
		{
			void* ptr = stackalloc byte[8];
			len = Math.Min(Math.Min(len, 32768 - windowFilled), input.AvailableBytes);
			*(int*)((byte*)ptr + 4) = 32768 - windowEnd;
			if (len > *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr = input.CopyBytes(window, windowEnd, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr += input.CopyBytes(window, 0, len - *(int*)((byte*)ptr + 4));
				}
			}
			else
			{
				*(int*)ptr = input.CopyBytes(window, windowEnd, len);
			}
			windowEnd = (windowEnd + *(int*)ptr) & 0x7FFF;
			windowFilled += *(int*)ptr;
			return *(int*)ptr;
		}

		public void CopyDict(byte[] dict, int offset, int len)
		{
			if (windowFilled > 0)
			{
				throw new InvalidOperationException();
			}
			if (len > 32768)
			{
				offset += len - 32768;
				len = 32768;
			}
			Array.Copy(dict, offset, window, 0, len);
			windowEnd = len & 0x7FFF;
		}

		public int GetFreeSpace()
		{
			return 32768 - windowFilled;
		}

		public int GetAvailable()
		{
			return windowFilled;
		}

		public unsafe int CopyOutput(byte[] output, int offset, int len)
		{
			void* ptr = stackalloc byte[12];
			*(int*)ptr = windowEnd;
			if (len > windowFilled)
			{
				len = windowFilled;
			}
			else
			{
				*(int*)ptr = (windowEnd - windowFilled + len) & 0x7FFF;
			}
			*(int*)((byte*)ptr + 4) = len;
			*(int*)((byte*)ptr + 8) = len - *(int*)ptr;
			if (*(int*)((byte*)ptr + 8) > 0)
			{
				Array.Copy(window, 32768 - *(int*)((byte*)ptr + 8), output, offset, *(int*)((byte*)ptr + 8));
				offset += *(int*)((byte*)ptr + 8);
				len = *(int*)ptr;
			}
			Array.Copy(window, *(int*)ptr - len, output, offset, len);
			windowFilled -= *(int*)((byte*)ptr + 4);
			if (windowFilled < 0)
			{
				throw new InvalidOperationException();
			}
			return *(int*)((byte*)ptr + 4);
		}

		public void Reset()
		{
			windowEnd = 0;
			windowFilled = 0;
		}
	}

	internal sealed class InflaterHuffmanTree
	{
		private const int MAX_BITLEN = 15;

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

		public InflaterHuffmanTree(byte[] codeLengths)
		{
			BuildTree(codeLengths);
		}

		private unsafe void BuildTree(byte[] codeLengths)
		{
			void* ptr = stackalloc byte[68];
			int[] array = new int[16];
			int[] array2 = new int[16];
			*(int*)ptr = 0;
			while (*(int*)ptr < codeLengths.Length)
			{
				*(int*)((byte*)ptr + 4) = codeLengths[*(int*)ptr];
				if (*(int*)((byte*)ptr + 4) > 0)
				{
					int[] array3;
					int[] array4 = (array3 = array);
					int num = *(int*)((byte*)ptr + 4);
					nint num2 = num;
					array4[num] = array3[num2] + 1;
				}
				(*(int*)ptr)++;
			}
			*(int*)((byte*)ptr + 8) = 0;
			*(int*)((byte*)ptr + 12) = 512;
			*(int*)((byte*)ptr + 16) = 1;
			while (*(int*)((byte*)ptr + 16) <= 15)
			{
				array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
				*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
				if (*(int*)((byte*)ptr + 16) >= 10)
				{
					*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
					*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
					*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
				}
				(*(int*)((byte*)ptr + 16))++;
			}
			tree = new short[*(int*)((byte*)ptr + 12)];
			*(int*)((byte*)ptr + 28) = 512;
			*(int*)((byte*)ptr + 32) = 15;
			while (*(int*)((byte*)ptr + 32) >= 10)
			{
				*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
				*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
				while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
				{
					tree[DeflaterHuffman.BitReverse(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
					*(int*)((byte*)ptr + 44) += 128;
				}
				(*(int*)((byte*)ptr + 32))--;
			}
			*(int*)((byte*)ptr + 48) = 0;
			while (*(int*)((byte*)ptr + 48) < codeLengths.Length)
			{
				*(int*)((byte*)ptr + 52) = codeLengths[*(int*)((byte*)ptr + 48)];
				if (*(int*)((byte*)ptr + 52) != 0)
				{
					*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
					*(int*)((byte*)ptr + 56) = DeflaterHuffman.BitReverse(*(int*)((byte*)ptr + 8));
					if (*(int*)((byte*)ptr + 52) <= 9)
					{
						do
						{
							tree[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
							*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
						}
						while (*(int*)((byte*)ptr + 56) < 512);
					}
					else
					{
						*(int*)((byte*)ptr + 60) = tree[*(int*)((byte*)ptr + 56) & 0x1FF];
						*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
						*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
						do
						{
							tree[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
							*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
						}
						while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
					}
					array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
				}
				(*(int*)((byte*)ptr + 48))++;
			}
		}

		public unsafe int GetSymbol(StreamManipulator input)
		{
			void* ptr = stackalloc byte[16];
			int num;
			int num2;
			if ((num = input.PeekBits(9)) >= 0)
			{
				if ((num2 = tree[num]) >= 0)
				{
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)ptr = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = num2 & 0xF;
				if ((num = input.PeekBits(*(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = tree[*(int*)ptr | (num >> 9)];
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)((byte*)ptr + 8) = input.AvailableBits;
				num = input.PeekBits(*(int*)((byte*)ptr + 8));
				num2 = tree[*(int*)ptr | (num >> 9)];
				if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
				{
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			*(int*)((byte*)ptr + 12) = input.AvailableBits;
			num = input.PeekBits(*(int*)((byte*)ptr + 12));
			num2 = tree[num];
			if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				input.DropBits(num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
	}

	internal sealed class InflaterDynHeader
	{
		private const int LNUM = 0;

		private const int DNUM = 1;

		private const int BLNUM = 2;

		private const int BLLENS = 3;

		private const int LENS = 4;

		private const int REPS = 5;

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

		public unsafe bool Decode(StreamManipulator input)
		{
			void* ptr = stackalloc byte[8];
			while (true)
			{
				switch (mode)
				{
				case 5:
				{
					*(int*)((byte*)ptr + 4) = repBits[repSymbol];
					int num = input.PeekBits(*(int*)((byte*)ptr + 4));
					if (num >= 0)
					{
						input.DropBits(*(int*)((byte*)ptr + 4));
						num += repMin[repSymbol];
						while (num-- > 0)
						{
							litdistLens[this.ptr++] = lastLen;
						}
						if (this.ptr == this.num)
						{
							return true;
						}
						goto IL_0080;
					}
					return false;
				}
				case 4:
				{
					int symbol;
					while (((symbol = blTree.GetSymbol(input)) & -16) == 0)
					{
						litdistLens[this.ptr++] = (lastLen = (byte)symbol);
						if (this.ptr == this.num)
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
					while (this.ptr < blnum)
					{
						*(int*)ptr = input.PeekBits(3);
						if (*(int*)ptr >= 0)
						{
							input.DropBits(3);
							blLens[BL_ORDER[this.ptr]] = (byte)(*(uint*)ptr);
							this.ptr++;
							continue;
						}
						return false;
					}
					blTree = new InflaterHuffmanTree(blLens);
					blLens = null;
					this.ptr = 0;
					mode = 4;
					goto case 4;
				case 2:
					blnum = input.PeekBits(4);
					if (blnum >= 0)
					{
						blnum += 4;
						input.DropBits(4);
						blLens = new byte[19];
						this.ptr = 0;
						mode = 3;
						goto case 3;
					}
					return false;
				case 1:
					dnum = input.PeekBits(5);
					if (dnum >= 0)
					{
						dnum++;
						input.DropBits(5);
						this.num = lnum + dnum;
						litdistLens = new byte[this.num];
						mode = 2;
						goto case 2;
					}
					return false;
				case 0:
					lnum = input.PeekBits(5);
					if (lnum >= 0)
					{
						lnum += 257;
						input.DropBits(5);
						mode = 1;
						goto case 1;
					}
					return false;
				}
				continue;
				IL_0080:
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

	internal sealed class Deflater
	{
		private const int IS_FLUSHING = 4;

		private const int IS_FINISHING = 8;

		private const int BUSY_STATE = 16;

		private const int FLUSHING_STATE = 20;

		private const int FINISHING_STATE = 28;

		private const int FINISHED_STATE = 30;

		private int state = 16;

		private long totalOut = 0L;

		private DeflaterPending pending;

		private DeflaterEngine engine;

		public long TotalOut => totalOut;

		public bool IsFinished
		{
			get
			{
				if (state == 30)
				{
					return pending.IsFlushed;
				}
				return false;
			}
		}

		public bool IsNeedingInput => engine.NeedsInput();

		public Deflater()
		{
			pending = new DeflaterPending();
			engine = new DeflaterEngine(pending);
		}

		public void Finish()
		{
			state |= 12;
		}

		public void SetInput(byte[] buffer)
		{
			engine.SetInput(buffer);
		}

		public unsafe int Deflate(byte[] output)
		{
			void* ptr = stackalloc byte[20];
			*(int*)ptr = 0;
			*(int*)((byte*)ptr + 4) = output.Length;
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
			while (true)
			{
				*(int*)((byte*)ptr + 12) = pending.Flush(output, *(int*)ptr, *(int*)((byte*)ptr + 4));
				*(int*)ptr += *(int*)((byte*)ptr + 12);
				totalOut += *(int*)((byte*)ptr + 12);
				*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
				if (*(int*)((byte*)ptr + 4) == 0 || state == 30)
				{
					break;
				}
				if (engine.Deflate((state & 4) != 0, (state & 8) != 0))
				{
					continue;
				}
				if (state != 16)
				{
					if (state == 20)
					{
						*(int*)((byte*)ptr + 16) = 8 + (-pending.BitCount & 7);
						while (*(int*)((byte*)ptr + 16) > 0)
						{
							pending.WriteBits(2, 10);
							*(int*)((byte*)ptr + 16) -= 10;
						}
						state = 16;
					}
					else if (state == 28)
					{
						pending.AlignToByte();
						state = 30;
					}
					continue;
				}
				return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
	}

	internal sealed class DeflaterHuffman
	{
		public sealed class Tree
		{
			public short[] freqs;

			public byte[] length;

			public int minNumCodes;

			public int numCodes;

			private short[] codes;

			private int[] bl_counts;

			private int maxLength;

			private DeflaterHuffman dh;

			public Tree(DeflaterHuffman dh, int elems, int minCodes, int maxLength)
			{
				this.dh = dh;
				minNumCodes = minCodes;
				this.maxLength = maxLength;
				freqs = new short[elems];
				bl_counts = new int[maxLength];
			}

			public void WriteSymbol(int code)
			{
				dh.pending.WriteBits(codes[code] & 0xFFFF, length[code]);
			}

			public void SetStaticCodes(short[] stCodes, byte[] stLength)
			{
				codes = stCodes;
				length = stLength;
			}

			public unsafe void BuildCodes()
			{
				void* ptr = stackalloc byte[16];
				int[] array = new int[maxLength];
				*(int*)ptr = 0;
				codes = new short[freqs.Length];
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < maxLength)
				{
					array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
					*(int*)ptr += bl_counts[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
					(*(int*)((byte*)ptr + 4))++;
				}
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < numCodes)
				{
					*(int*)((byte*)ptr + 12) = length[*(int*)((byte*)ptr + 8)];
					if (*(int*)((byte*)ptr + 12) > 0)
					{
						codes[*(int*)((byte*)ptr + 8)] = BitReverse(array[*(int*)((byte*)ptr + 12) - 1]);
						int[] array2;
						int[] array3 = (array2 = array);
						int num = *(int*)((byte*)ptr + 12) - 1;
						nint num2 = num;
						array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}

			private unsafe void BuildLength(int[] childs)
			{
				void* ptr = stackalloc byte[36];
				length = new byte[freqs.Length];
				*(int*)ptr = childs.Length / 2;
				*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
				*(int*)((byte*)ptr + 8) = 0;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < maxLength)
				{
					bl_counts[*(int*)((byte*)ptr + 12)] = 0;
					(*(int*)((byte*)ptr + 12))++;
				}
				int[] array = new int[*(int*)ptr];
				array[*(int*)ptr - 1] = 0;
				*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
				int[] array2;
				nint num2;
				while (*(int*)((byte*)ptr + 16) >= 0)
				{
					if (childs[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
					{
						*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
						if (*(int*)((byte*)ptr + 20) > maxLength)
						{
							*(int*)((byte*)ptr + 20) = maxLength;
							(*(int*)((byte*)ptr + 8))++;
						}
						array[childs[2 * *(int*)((byte*)ptr + 16)]] = (array[childs[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
					}
					else
					{
						*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
						int[] array3 = (array2 = bl_counts);
						int num = *(int*)((byte*)ptr + 24) - 1;
						num2 = num;
						array3[num] = array2[num2] + 1;
						length[childs[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
					}
					(*(int*)((byte*)ptr + 16))--;
				}
				if (*(int*)((byte*)ptr + 8) == 0)
				{
					return;
				}
				int num3 = maxLength - 1;
				while (true)
				{
					if (bl_counts[--num3] != 0)
					{
						do
						{
							int[] array4 = (array2 = bl_counts);
							int num4 = num3;
							num2 = num4;
							array4[num4] = array2[num2] - 1;
							int[] array5 = (array2 = bl_counts);
							int num5 = ++num3;
							num2 = num5;
							array5[num5] = array2[num2] + 1;
							*(int*)((byte*)ptr + 8) -= 1 << maxLength - 1 - num3;
						}
						while (*(int*)((byte*)ptr + 8) > 0 && num3 < maxLength - 1);
						if (*(int*)((byte*)ptr + 8) <= 0)
						{
							break;
						}
					}
				}
				int[] array6 = (array2 = bl_counts);
				int num6 = maxLength - 1;
				num2 = num6;
				array6[num6] = array2[num2] + *(int*)((byte*)ptr + 8);
				int[] array7 = (array2 = bl_counts);
				int num7 = maxLength - 2;
				num2 = num7;
				array7[num7] = array2[num2] - *(int*)((byte*)ptr + 8);
				int num8 = 2 * *(int*)((byte*)ptr + 4);
				*(int*)((byte*)ptr + 28) = maxLength;
				while (*(int*)((byte*)ptr + 28) != 0)
				{
					*(int*)((byte*)ptr + 32) = bl_counts[*(int*)((byte*)ptr + 28) - 1];
					while (*(int*)((byte*)ptr + 32) > 0)
					{
						int num9 = 2 * childs[num8++];
						if (childs[num9 + 1] == -1)
						{
							length[childs[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
							(*(int*)((byte*)ptr + 32))--;
						}
					}
					(*(int*)((byte*)ptr + 28))--;
				}
			}

			public unsafe void BuildTree()
			{
				void* ptr = stackalloc byte[36];
				*(int*)ptr = freqs.Length;
				int[] array = new int[*(int*)ptr];
				int num = 0;
				int num2 = 0;
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
				{
					*(int*)((byte*)ptr + 8) = freqs[*(int*)((byte*)ptr + 4)];
					if (*(int*)((byte*)ptr + 8) != 0)
					{
						int num3 = num++;
						int num4;
						while (num3 > 0 && freqs[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
						{
							array[num3] = array[num4];
							num3 = num4;
						}
						array[num3] = *(int*)((byte*)ptr + 4);
						num2 = *(int*)((byte*)ptr + 4);
					}
					(*(int*)((byte*)ptr + 4))++;
				}
				while (num < 2)
				{
					int num5 = ((num2 < 2) ? (++num2) : 0);
					array[num++] = num5;
				}
				numCodes = Math.Max(num2 + 1, minNumCodes);
				*(int*)((byte*)ptr + 12) = num;
				int[] array2 = new int[4 * num - 2];
				int[] array3 = new int[2 * num - 1];
				int num6 = *(int*)((byte*)ptr + 12);
				*(int*)((byte*)ptr + 16) = 0;
				while (*(int*)((byte*)ptr + 16) < num)
				{
					*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
					array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
					array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
					array3[*(int*)((byte*)ptr + 16)] = freqs[*(int*)((byte*)ptr + 20)] << 8;
					array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
					(*(int*)((byte*)ptr + 16))++;
				}
				do
				{
					*(int*)((byte*)ptr + 24) = array[0];
					int num7 = array[--num];
					int num8 = 0;
					int num9;
					for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
					{
						if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
						{
							num9++;
						}
						array[num8] = array[num9];
						num8 = num9;
					}
					int num10 = array3[num7];
					while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
					{
						array[num9] = array[num8];
					}
					array[num9] = num7;
					*(int*)((byte*)ptr + 28) = array[0];
					num7 = num6++;
					array2[2 * num7] = *(int*)((byte*)ptr + 24);
					array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
					*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
					num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
					num8 = 0;
					for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
					{
						if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
						{
							num9++;
						}
						array[num8] = array[num9];
						num8 = num9;
					}
					while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
					{
						array[num9] = array[num8];
					}
					array[num9] = num7;
				}
				while (num > 1);
				BuildLength(array2);
			}

			public unsafe int GetEncodedLength()
			{
				void* ptr = stackalloc byte[8];
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < freqs.Length)
				{
					*(int*)ptr += freqs[*(int*)((byte*)ptr + 4)] * length[*(int*)((byte*)ptr + 4)];
					(*(int*)((byte*)ptr + 4))++;
				}
				return *(int*)ptr;
			}

			public unsafe void CalcBLFreq(Tree blTree)
			{
				void* ptr = stackalloc byte[20];
				*(int*)((byte*)ptr + 8) = -1;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < numCodes)
				{
					int num = 1;
					*(int*)((byte*)ptr + 16) = length[*(int*)((byte*)ptr + 12)];
					if (*(int*)((byte*)ptr + 16) == 0)
					{
						*(int*)ptr = 138;
						*(int*)((byte*)ptr + 4) = 3;
					}
					else
					{
						*(int*)ptr = 6;
						*(int*)((byte*)ptr + 4) = 3;
						if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
						{
							short[] array;
							short[] array2 = (array = blTree.freqs);
							int num2 = *(int*)((byte*)ptr + 16);
							nint num3 = num2;
							array2[num2] = (short)(array[num3] + 1);
							num = 0;
						}
					}
					*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
					(*(int*)((byte*)ptr + 12))++;
					while (*(int*)((byte*)ptr + 12) < numCodes && *(int*)((byte*)ptr + 8) == length[*(int*)((byte*)ptr + 12)])
					{
						(*(int*)((byte*)ptr + 12))++;
						if (++num >= *(int*)ptr)
						{
							break;
						}
					}
					if (num < *(int*)((byte*)ptr + 4))
					{
						short[] array;
						short[] array3 = (array = blTree.freqs);
						int num4 = *(int*)((byte*)ptr + 8);
						nint num3 = num4;
						array3[num4] = (short)(array[num3] + (short)num);
					}
					else if (*(int*)((byte*)ptr + 8) != 0)
					{
						short[] array;
						(array = blTree.freqs)[16] = (short)(array[16] + 1);
					}
					else if (num <= 10)
					{
						short[] array;
						(array = blTree.freqs)[17] = (short)(array[17] + 1);
					}
					else
					{
						short[] array;
						(array = blTree.freqs)[18] = (short)(array[18] + 1);
					}
				}
			}

			public unsafe void WriteTree(Tree blTree)
			{
				void* ptr = stackalloc byte[20];
				*(int*)((byte*)ptr + 8) = -1;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < numCodes)
				{
					int num = 1;
					*(int*)((byte*)ptr + 16) = length[*(int*)((byte*)ptr + 12)];
					if (*(int*)((byte*)ptr + 16) == 0)
					{
						*(int*)ptr = 138;
						*(int*)((byte*)ptr + 4) = 3;
					}
					else
					{
						*(int*)ptr = 6;
						*(int*)((byte*)ptr + 4) = 3;
						if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
						{
							blTree.WriteSymbol(*(int*)((byte*)ptr + 16));
							num = 0;
						}
					}
					*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
					(*(int*)((byte*)ptr + 12))++;
					while (*(int*)((byte*)ptr + 12) < numCodes && *(int*)((byte*)ptr + 8) == length[*(int*)((byte*)ptr + 12)])
					{
						(*(int*)((byte*)ptr + 12))++;
						if (++num >= *(int*)ptr)
						{
							break;
						}
					}
					if (num < *(int*)((byte*)ptr + 4))
					{
						while (num-- > 0)
						{
							blTree.WriteSymbol(*(int*)((byte*)ptr + 8));
						}
					}
					else if (*(int*)((byte*)ptr + 8) != 0)
					{
						blTree.WriteSymbol(16);
						dh.pending.WriteBits(num - 3, 2);
					}
					else if (num <= 10)
					{
						blTree.WriteSymbol(17);
						dh.pending.WriteBits(num - 3, 3);
					}
					else
					{
						blTree.WriteSymbol(18);
						dh.pending.WriteBits(num - 11, 7);
					}
				}
			}
		}

		private const int BUFSIZE = 16384;

		private const int LITERAL_NUM = 286;

		private const int DIST_NUM = 30;

		private const int BITLEN_NUM = 19;

		private const int REP_3_6 = 16;

		private const int REP_3_10 = 17;

		private const int REP_11_138 = 18;

		private const int EOF_SYMBOL = 256;

		private static readonly int[] BL_ORDER;

		private static readonly byte[] bit4Reverse;

		private DeflaterPending pending;

		private Tree literalTree;

		private Tree distTree;

		private Tree blTree;

		private short[] d_buf;

		private byte[] l_buf;

		private int last_lit;

		private int extra_bits;

		private static readonly short[] staticLCodes;

		private static readonly byte[] staticLLength;

		private static readonly short[] staticDCodes;

		private static readonly byte[] staticDLength;

		public static short BitReverse(int toReverse)
		{
			return (short)((bit4Reverse[toReverse & 0xF] << 12) | (bit4Reverse[(toReverse >> 4) & 0xF] << 8) | (bit4Reverse[(toReverse >> 8) & 0xF] << 4) | bit4Reverse[toReverse >> 12]);
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

		public DeflaterHuffman(DeflaterPending pending)
		{
			this.pending = pending;
			literalTree = new Tree(this, 286, 257, 15);
			distTree = new Tree(this, 30, 1, 15);
			blTree = new Tree(this, 19, 4, 7);
			d_buf = new short[16384];
			l_buf = new byte[16384];
		}

		public void Init()
		{
			last_lit = 0;
			extra_bits = 0;
		}

		private int Lcode(int len)
		{
			if (len == 255)
			{
				return 285;
			}
			int num = 257;
			while (len >= 8)
			{
				num += 4;
				len >>= 1;
			}
			return num + len;
		}

		private int Dcode(int distance)
		{
			int num = 0;
			while (distance >= 4)
			{
				num += 2;
				distance >>= 1;
			}
			return num + distance;
		}

		public void SendAllTrees(int blTreeCodes)
		{
			blTree.BuildCodes();
			literalTree.BuildCodes();
			distTree.BuildCodes();
			pending.WriteBits(literalTree.numCodes - 257, 5);
			pending.WriteBits(distTree.numCodes - 1, 5);
			pending.WriteBits(blTreeCodes - 4, 4);
			for (int i = 0; i < blTreeCodes; i++)
			{
				pending.WriteBits(blTree.length[BL_ORDER[i]], 3);
			}
			literalTree.WriteTree(blTree);
			distTree.WriteTree(blTree);
		}

		public unsafe void CompressBlock()
		{
			void* ptr = stackalloc byte[20];
			*(int*)ptr = 0;
			while (*(int*)ptr < last_lit)
			{
				*(int*)((byte*)ptr + 4) = l_buf[*(int*)ptr] & 0xFF;
				int num = d_buf[*(int*)ptr];
				if (num-- != 0)
				{
					*(int*)((byte*)ptr + 8) = Lcode(*(int*)((byte*)ptr + 4));
					literalTree.WriteSymbol(*(int*)((byte*)ptr + 8));
					*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
					if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
					{
						pending.WriteBits(*(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
					}
					*(int*)((byte*)ptr + 16) = Dcode(num);
					distTree.WriteSymbol(*(int*)((byte*)ptr + 16));
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
					if (*(int*)((byte*)ptr + 12) > 0)
					{
						pending.WriteBits(num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
					}
				}
				else
				{
					literalTree.WriteSymbol(*(int*)((byte*)ptr + 4));
				}
				(*(int*)ptr)++;
			}
			literalTree.WriteSymbol(256);
		}

		public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			pending.WriteBits(lastBlock ? 1 : 0, 3);
			pending.AlignToByte();
			pending.WriteShort(storedLength);
			pending.WriteShort(~storedLength);
			pending.WriteBlock(stored, storedOffset, storedLength);
			Init();
		}

		public unsafe void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			void* ptr = stackalloc byte[24];
			short[] freqs;
			(freqs = literalTree.freqs)[256] = (short)(freqs[256] + 1);
			literalTree.BuildTree();
			distTree.BuildTree();
			literalTree.CalcBLFreq(blTree);
			distTree.CalcBLFreq(blTree);
			blTree.BuildTree();
			*(int*)ptr = 4;
			*(int*)((byte*)ptr + 4) = 18;
			while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
			{
				if (blTree.length[BL_ORDER[*(int*)((byte*)ptr + 4)]] > 0)
				{
					*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
				}
				(*(int*)((byte*)ptr + 4))--;
			}
			*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + blTree.GetEncodedLength() + literalTree.GetEncodedLength() + distTree.GetEncodedLength() + extra_bits;
			*(int*)((byte*)ptr + 12) = extra_bits;
			*(int*)((byte*)ptr + 16) = 0;
			while (*(int*)((byte*)ptr + 16) < 286)
			{
				*(int*)((byte*)ptr + 12) += literalTree.freqs[*(int*)((byte*)ptr + 16)] * staticLLength[*(int*)((byte*)ptr + 16)];
				(*(int*)((byte*)ptr + 16))++;
			}
			*(int*)((byte*)ptr + 20) = 0;
			while (*(int*)((byte*)ptr + 20) < 30)
			{
				*(int*)((byte*)ptr + 12) += distTree.freqs[*(int*)((byte*)ptr + 20)] * staticDLength[*(int*)((byte*)ptr + 20)];
				(*(int*)((byte*)ptr + 20))++;
			}
			if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
			{
				*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
			}
			if (storedOffset >= 0 && storedLength + 4 < *(int*)((byte*)ptr + 8) >> 3)
			{
				FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
			}
			else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
			{
				pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
				literalTree.SetStaticCodes(staticLCodes, staticLLength);
				distTree.SetStaticCodes(staticDCodes, staticDLength);
				CompressBlock();
				Init();
			}
			else
			{
				pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
				SendAllTrees(*(int*)ptr);
				CompressBlock();
				Init();
			}
		}

		public bool IsFull()
		{
			return last_lit >= 16384;
		}

		public bool TallyLit(int lit)
		{
			d_buf[last_lit] = 0;
			l_buf[last_lit++] = (byte)lit;
			short[] freqs;
			short[] array = (freqs = literalTree.freqs);
			nint num = lit;
			array[lit] = (short)(freqs[num] + 1);
			return IsFull();
		}

		public unsafe bool TallyDist(int dist, int len)
		{
			void* ptr = stackalloc byte[8];
			d_buf[last_lit] = (short)dist;
			l_buf[last_lit++] = (byte)(len - 3);
			*(int*)ptr = Lcode(len - 3);
			short[] freqs;
			short[] array = (freqs = literalTree.freqs);
			int num = *(int*)ptr;
			nint num2 = num;
			array[num] = (short)(freqs[num2] + 1);
			if (*(int*)ptr >= 265 && *(int*)ptr < 285)
			{
				extra_bits += (*(int*)ptr - 261) / 4;
			}
			*(int*)((byte*)ptr + 4) = Dcode(dist - 1);
			short[] array2 = (freqs = distTree.freqs);
			int num3 = *(int*)((byte*)ptr + 4);
			num2 = num3;
			array2[num3] = (short)(freqs[num2] + 1);
			if (*(int*)((byte*)ptr + 4) >= 4)
			{
				extra_bits += *(int*)((byte*)ptr + 4) / 2 - 1;
			}
			return IsFull();
		}
	}

	internal sealed class DeflaterEngine
	{
		private const int MAX_MATCH = 258;

		private const int MIN_MATCH = 3;

		private const int WSIZE = 32768;

		private const int WMASK = 32767;

		private const int HASH_SIZE = 32768;

		private const int HASH_MASK = 32767;

		private const int HASH_SHIFT = 5;

		private const int MIN_LOOKAHEAD = 262;

		private const int MAX_DIST = 32506;

		private const int TOO_FAR = 4096;

		private int ins_h;

		private short[] head;

		private short[] prev;

		private int matchStart;

		private int matchLen;

		private bool prevAvailable;

		private int blockStart;

		private int strstart;

		private int lookahead;

		private byte[] window;

		private byte[] inputBuf;

		private int totalIn;

		private int inputOff;

		private int inputEnd;

		private DeflaterPending pending;

		private DeflaterHuffman huffman;

		public DeflaterEngine(DeflaterPending pending)
		{
			this.pending = pending;
			huffman = new DeflaterHuffman(pending);
			window = new byte[65536];
			head = new short[32768];
			prev = new short[32768];
			strstart = 1;
			blockStart = 1;
		}

		private void UpdateHash()
		{
			ins_h = (window[strstart] << 5) ^ window[strstart + 1];
		}

		private int InsertString()
		{
			int num = ((ins_h << 5) ^ window[strstart + 2]) & 0x7FFF;
			short num2 = (prev[strstart & 0x7FFF] = head[num]);
			head[num] = (short)strstart;
			ins_h = num;
			return num2 & 0xFFFF;
		}

		private unsafe void SlideWindow()
		{
			void* ptr = stackalloc byte[16];
			Array.Copy(window, 32768, window, 0, 32768);
			matchStart -= 32768;
			strstart -= 32768;
			blockStart -= 32768;
			*(int*)ptr = 0;
			while (*(int*)ptr < 32768)
			{
				*(int*)((byte*)ptr + 4) = head[*(int*)ptr] & 0xFFFF;
				head[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
				(*(int*)ptr)++;
			}
			*(int*)((byte*)ptr + 8) = 0;
			while (*(int*)((byte*)ptr + 8) < 32768)
			{
				*(int*)((byte*)ptr + 12) = prev[*(int*)((byte*)ptr + 8)] & 0xFFFF;
				prev[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
				(*(int*)((byte*)ptr + 8))++;
			}
		}

		public void FillWindow()
		{
			if (strstart >= 65274)
			{
				SlideWindow();
			}
			while (lookahead < 262 && inputOff < inputEnd)
			{
				int num = 65536 - lookahead - strstart;
				if (num > inputEnd - inputOff)
				{
					num = inputEnd - inputOff;
				}
				Array.Copy(inputBuf, inputOff, window, strstart + lookahead, num);
				inputOff += num;
				totalIn += num;
				lookahead += num;
			}
			if (lookahead >= 3)
			{
				UpdateHash();
			}
		}

		private unsafe bool FindLongestMatch(int curMatch)
		{
			void* ptr = stackalloc byte[22];
			int num = 128;
			*(int*)ptr = 128;
			short[] array = prev;
			int num2 = strstart;
			*(int*)((byte*)ptr + 4) = strstart + matchLen;
			*(int*)((byte*)ptr + 8) = Math.Max(matchLen, 2);
			*(int*)((byte*)ptr + 12) = Math.Max(strstart - 32506, 0);
			*(int*)((byte*)ptr + 16) = strstart + 258 - 1;
			((byte*)ptr)[20] = window[*(int*)((byte*)ptr + 4) - 1];
			((byte*)ptr)[21] = window[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) >= 8)
			{
				num >>= 2;
			}
			if (*(int*)ptr > lookahead)
			{
				*(int*)ptr = lookahead;
			}
			do
			{
				if (window[curMatch + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || window[curMatch + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || window[curMatch] != window[num2] || window[curMatch + 1] != window[num2 + 1])
				{
					continue;
				}
				int num3 = curMatch + 2;
				num2 += 2;
				while (window[++num2] == window[++num3] && window[++num2] == window[++num3] && window[++num2] == window[++num3] && window[++num2] == window[++num3] && window[++num2] == window[++num3] && window[++num2] == window[++num3] && window[++num2] == window[++num3] && window[++num2] == window[++num3] && num2 < *(int*)((byte*)ptr + 16))
				{
				}
				if (num2 > *(int*)((byte*)ptr + 4))
				{
					matchStart = curMatch;
					*(int*)((byte*)ptr + 4) = num2;
					*(int*)((byte*)ptr + 8) = num2 - strstart;
					if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
					{
						break;
					}
					((byte*)ptr)[20] = window[*(int*)((byte*)ptr + 4) - 1];
					((byte*)ptr)[21] = window[*(int*)((byte*)ptr + 4)];
				}
				num2 = strstart;
			}
			while ((curMatch = array[curMatch & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
			matchLen = Math.Min(*(int*)((byte*)ptr + 8), lookahead);
			return matchLen >= 3;
		}

		private unsafe bool DeflateSlow(bool flush, bool finish)
		{
			void* ptr = stackalloc byte[12];
			if (lookahead < 262 && !flush)
			{
				return false;
			}
			do
			{
				if (lookahead >= 262 || flush)
				{
					if (lookahead != 0)
					{
						if (strstart >= 65274)
						{
							SlideWindow();
						}
						*(int*)ptr = matchStart;
						int num = matchLen;
						if (lookahead >= 3)
						{
							*(int*)((byte*)ptr + 4) = InsertString();
							if (*(int*)((byte*)ptr + 4) != 0 && strstart - *(int*)((byte*)ptr + 4) <= 32506 && FindLongestMatch(*(int*)((byte*)ptr + 4)) && matchLen <= 5 && matchLen == 3 && strstart - matchStart > 4096)
							{
								matchLen = 2;
							}
						}
						if (num >= 3 && matchLen <= num)
						{
							huffman.TallyDist(strstart - 1 - *(int*)ptr, num);
							num -= 2;
							do
							{
								strstart++;
								lookahead--;
								if (lookahead >= 3)
								{
									InsertString();
								}
							}
							while (--num > 0);
							strstart++;
							lookahead--;
							prevAvailable = false;
							matchLen = 2;
						}
						else
						{
							if (prevAvailable)
							{
								huffman.TallyLit(window[strstart - 1] & 0xFF);
							}
							prevAvailable = true;
							strstart++;
							lookahead--;
						}
						continue;
					}
					if (prevAvailable)
					{
						huffman.TallyLit(window[strstart - 1] & 0xFF);
					}
					prevAvailable = false;
					huffman.FlushBlock(window, blockStart, strstart - blockStart, finish);
					blockStart = strstart;
					return false;
				}
				return true;
			}
			while (!huffman.IsFull());
			*(int*)((byte*)ptr + 8) = strstart - blockStart;
			if (prevAvailable)
			{
				(*(int*)((byte*)ptr + 8))--;
			}
			bool flag = finish && lookahead == 0 && !prevAvailable;
			huffman.FlushBlock(window, blockStart, *(int*)((byte*)ptr + 8), flag);
			blockStart += *(int*)((byte*)ptr + 8);
			return !flag;
		}

		public bool Deflate(bool flush, bool finish)
		{
			bool flag;
			do
			{
				FillWindow();
				bool flush2 = flush && inputOff == inputEnd;
				flag = DeflateSlow(flush2, finish);
			}
			while (pending.IsFlushed && flag);
			return flag;
		}

		public void SetInput(byte[] buffer)
		{
			inputBuf = buffer;
			inputOff = 0;
			inputEnd = buffer.Length;
		}

		public bool NeedsInput()
		{
			return inputEnd == inputOff;
		}
	}

	internal sealed class DeflaterPending
	{
		protected byte[] buf = new byte[65536];

		private int start = 0;

		private int end = 0;

		private uint bits = 0u;

		private int bitCount = 0;

		public int BitCount => bitCount;

		public bool IsFlushed => end == 0;

		public void WriteShort(int s)
		{
			buf[end++] = (byte)s;
			buf[end++] = (byte)(s >> 8);
		}

		public void WriteBlock(byte[] block, int offset, int len)
		{
			Array.Copy(block, offset, buf, end, len);
			end += len;
		}

		public void AlignToByte()
		{
			if (bitCount > 0)
			{
				buf[end++] = (byte)bits;
				if (bitCount > 8)
				{
					buf[end++] = (byte)(bits >> 8);
				}
			}
			bits = 0u;
			bitCount = 0;
		}

		public void WriteBits(int b, int count)
		{
			bits |= (uint)(b << bitCount);
			bitCount += count;
			if (bitCount >= 16)
			{
				buf[end++] = (byte)bits;
				buf[end++] = (byte)(bits >> 8);
				bits >>= 16;
				bitCount -= 16;
			}
		}

		public int Flush(byte[] output, int offset, int length)
		{
			if (bitCount >= 8)
			{
				buf[end++] = (byte)bits;
				bits >>= 8;
				bitCount -= 8;
			}
			if (length > end - start)
			{
				length = end - start;
				Array.Copy(buf, start, output, offset, length);
				start = 0;
				end = 0;
			}
			else
			{
				Array.Copy(buf, start, output, offset, length);
				start += length;
			}
			return length;
		}
	}

	internal sealed class ZipStream : MemoryStream
	{
		public void WriteShort(int value)
		{
			WriteByte((byte)((uint)value & 0xFFu));
			WriteByte((byte)((uint)(value >> 8) & 0xFFu));
		}

		public void WriteInt(int value)
		{
			WriteShort(value);
			WriteShort(value >> 16);
		}

		public int ReadShort()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int ReadInt()
		{
			return ReadShort() | (ReadShort() << 16);
		}

		public ZipStream()
		{
		}

		public ZipStream(byte[] buffer)
			: base(buffer, writable: false)
		{
		}
	}

	public static string ExceptionMessage;

	private static bool PublicKeysMatch(Assembly executingAssembly, Assembly callingAssembly)
	{
		byte[] publicKey = executingAssembly.GetName().GetPublicKey();
		byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	public unsafe static byte[] Unzip(byte[] buffer)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !PublicKeysMatch(executingAssembly, callingAssembly))
		{
			return null;
		}
		ZipStream zipStream = new ZipStream(buffer);
		byte[] array = new byte[0];
		*(int*)ptr = zipStream.ReadInt();
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)zipStream.ReadShort();
			*(int*)((byte*)ptr + 4) = zipStream.ReadShort();
			*(int*)((byte*)ptr + 8) = zipStream.ReadShort();
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			zipStream.ReadInt();
			zipStream.ReadInt();
			zipStream.ReadInt();
			*(int*)((byte*)ptr + 12) = zipStream.ReadInt();
			*(int*)((byte*)ptr + 16) = zipStream.ReadShort();
			*(int*)((byte*)ptr + 20) = zipStream.ReadShort();
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 16)];
				zipStream.Read(buffer2, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer3 = new byte[*(int*)((byte*)ptr + 20)];
				zipStream.Read(buffer3, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[zipStream.Length - zipStream.Position];
			zipStream.Read(array2, 0, array2.Length);
			Inflater inflater = new Inflater(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			inflater.Inflate(array, 0, array.Length);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = zipStream.ReadInt();
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = zipStream.ReadInt();
					*(int*)((byte*)ptr + 40) = zipStream.ReadInt();
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					zipStream.Read(array3, 0, array3.Length);
					Inflater inflater2 = new Inflater(array3);
					inflater2.Inflate(array, *(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 40));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] key = new byte[8] { 231, 113, 87, 134, 45, 254, 224, 162 };
				byte[] iv = new byte[8] { 235, 241, 81, 190, 37, 128, 93, 61 };
				using DESCryptoIndirector dESCryptoIndirector = new DESCryptoIndirector();
				using ICryptoTransform cryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(key, iv, decrypt: true);
				byte[] buffer4 = cryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = Unzip(buffer4);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] key2 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] iv2 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using AESCryptoIndirector aESCryptoIndirector = new AESCryptoIndirector();
				using ICryptoTransform cryptoTransform2 = aESCryptoIndirector.GetAESCryptoTransform(key2, iv2, decrypt: true);
				byte[] buffer5 = cryptoTransform2.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = Unzip(buffer5);
			}
		}
		zipStream.Close();
		zipStream = null;
		return array;
	}

	public static byte[] Zip(byte[] buffer)
	{
		return Zip(buffer, 1, null, null);
	}

	public static byte[] ZipAndEncrypt(byte[] buffer, byte[] key, byte[] iv)
	{
		return Zip(buffer, 2, key, iv);
	}

	public static byte[] ZipAndAES(byte[] buffer, byte[] key, byte[] iv)
	{
		return Zip(buffer, 3, key, iv);
	}

	private unsafe static byte[] Zip(byte[] buffer, int version, byte[] key, byte[] iv)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			ZipStream zipStream = new ZipStream();
			switch (version)
			{
			case 0:
			{
				Deflater deflater2 = new Deflater();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = buffer.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ buffer[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				zipStream.WriteInt(67324752);
				zipStream.WriteShort(20);
				zipStream.WriteShort(0);
				zipStream.WriteShort(8);
				zipStream.WriteInt((int)(*(long*)ptr));
				zipStream.WriteInt((int)num);
				*(long*)((byte*)ptr + 8) = zipStream.Position;
				zipStream.WriteInt(0);
				zipStream.WriteInt(buffer.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				zipStream.WriteShort(bytes.Length);
				zipStream.WriteShort(0);
				zipStream.Write(bytes, 0, bytes.Length);
				deflater2.SetInput(buffer);
				while (!deflater2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = deflater2.Deflate(array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					zipStream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				deflater2.Finish();
				while (!deflater2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = deflater2.Deflate(array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					zipStream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = deflater2.TotalOut;
				zipStream.WriteInt(33639248);
				zipStream.WriteShort(20);
				zipStream.WriteShort(20);
				zipStream.WriteShort(0);
				zipStream.WriteShort(8);
				zipStream.WriteInt((int)(*(long*)ptr));
				zipStream.WriteInt((int)num);
				zipStream.WriteInt((int)(*(long*)((byte*)ptr + 16)));
				zipStream.WriteInt(buffer.Length);
				zipStream.WriteShort(bytes.Length);
				zipStream.WriteShort(0);
				zipStream.WriteShort(0);
				zipStream.WriteShort(0);
				zipStream.WriteShort(0);
				zipStream.WriteInt(0);
				zipStream.WriteInt(0);
				zipStream.Write(bytes, 0, bytes.Length);
				zipStream.WriteInt(101010256);
				zipStream.WriteShort(0);
				zipStream.WriteShort(0);
				zipStream.WriteShort(1);
				zipStream.WriteShort(1);
				zipStream.WriteInt(46 + bytes.Length);
				zipStream.WriteInt((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)));
				zipStream.WriteShort(0);
				zipStream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				zipStream.WriteInt((int)(*(long*)((byte*)ptr + 16)));
				break;
			}
			case 1:
				zipStream.WriteInt(25000571);
				zipStream.WriteInt(buffer.Length);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < buffer.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, buffer.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(buffer, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = zipStream.Position;
					zipStream.WriteInt(0);
					zipStream.WriteInt(array5.Length);
					Deflater deflater = new Deflater();
					deflater.SetInput(array5);
					while (!deflater.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = deflater.Deflate(array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						zipStream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					deflater.Finish();
					while (!deflater.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = deflater.Deflate(array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						zipStream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = zipStream.Position;
					zipStream.Position = *(long*)((byte*)ptr + 24);
					zipStream.WriteInt((int)deflater.TotalOut);
					zipStream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				zipStream.WriteInt(41777787);
				byte[] array3 = Zip(buffer, 1, null, null);
				using (DESCryptoIndirector dESCryptoIndirector = new DESCryptoIndirector())
				{
					using ICryptoTransform cryptoTransform2 = dESCryptoIndirector.GetDESCryptoTransform(key, iv, decrypt: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					zipStream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				zipStream.WriteInt(58555003);
				byte[] array = Zip(buffer, 1, null, null);
				using (AESCryptoIndirector aESCryptoIndirector = new AESCryptoIndirector())
				{
					using ICryptoTransform cryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(key, iv, decrypt: false);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					zipStream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			zipStream.Flush();
			zipStream.Close();
			return zipStream.ToArray();
		}
		catch (Exception ex)
		{
			ExceptionMessage = "ERR 2003: " + ex.Message;
			throw;
		}
	}
}
