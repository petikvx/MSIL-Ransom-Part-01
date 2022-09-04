using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class SimpleZip
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

		private static readonly int[] CPLENS;

		private static readonly int[] CPLEXT;

		private static readonly int[] CPDIST;

		private static readonly int[] CPDEXT;

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
			try
			{
				input = new StreamManipulator();
				outputWindow = new OutputWindow();
				mode = 2;
				input.SetInput(bytes, 0, bytes.Length);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, bytes);
				throw;
			}
		}

		private bool DecodeHuffman()
		{
			int num = default(int);
			int num2 = default(int);
			int symbol = default(int);
			int num4 = default(int);
			int num3 = default(int);
			try
			{
				num = outputWindow.GetFreeSpace();
				while (num >= 258)
				{
					num2 = mode;
					switch (num2)
					{
					case 7:
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
					case 8:
						if (neededBits > 0)
						{
							mode = 8;
							num4 = input.PeekBits(neededBits);
							if (num4 < 0)
							{
								return false;
							}
							input.DropBits(neededBits);
							repLength += num4;
						}
						mode = 9;
						goto case 9;
					case 9:
						symbol = distTree.GetSymbol(input);
						if (symbol >= 0)
						{
							repDist = CPDIST[symbol];
							neededBits = CPDEXT[symbol];
							goto case 10;
						}
						return false;
					case 10:
						if (neededBits > 0)
						{
							mode = 10;
							num3 = input.PeekBits(neededBits);
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
						break;
					}
				}
				return true;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, symbol, num4, num3, num2, this);
				throw;
			}
		}

		private bool Decode()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				num = mode;
				switch (num)
				{
				case 2:
					if (isLastBlock)
					{
						mode = 12;
						return false;
					}
					num2 = input.PeekBits(3);
					if (num2 < 0)
					{
						return false;
					}
					input.DropBits(3);
					if (((uint)num2 & (true ? 1u : 0u)) != 0)
					{
						isLastBlock = true;
					}
					num = num2 >> 1;
					switch (num)
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
					num = (uncomprLen = input.PeekBits(16));
					if (num < 0)
					{
						return false;
					}
					input.DropBits(16);
					mode = 4;
					goto case 4;
				case 4:
					num3 = input.PeekBits(16);
					if (num3 < 0)
					{
						return false;
					}
					input.DropBits(16);
					mode = 5;
					goto case 5;
				case 5:
					num4 = outputWindow.CopyStored(input, uncomprLen);
					uncomprLen -= num4;
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num2, num3, num4, num, this);
				throw;
			}
		}

		public int Inflate(byte[] buf, int offset, int len)
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				num = 0;
				do
				{
					if (mode != 11)
					{
						num2 = outputWindow.CopyOutput(buf, offset, len);
						offset += num2;
						num += num2;
						len -= num2;
						if (len == 0)
						{
							return num;
						}
					}
				}
				while (Decode() || (outputWindow.GetAvailable() > 0 && mode != 11));
				return num;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, num2, this, buf, offset, len);
				throw;
			}
		}

		static Inflater()
		{
			try
			{
				CPLENS = new int[29]
				{
					3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
					15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
					67, 83, 99, 115, 131, 163, 195, 227, 258
				};
				CPLEXT = new int[29]
				{
					0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
					1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
					4, 4, 4, 4, 5, 5, 5, 5, 0
				};
				CPDIST = new int[30]
				{
					1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
					33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
					1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
				};
				CPDEXT = new int[30]
				{
					0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
					4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
					9, 9, 10, 10, 11, 11, 12, 12, 13, 13
				};
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	internal sealed class StreamManipulator
	{
		private byte[] window;

		private int window_start = 0;

		private int window_end = 0;

		private uint buffer = 0u;

		private int bits_in_buffer = 0;

		public int AvailableBits
		{
			get
			{
				try
				{
					return bits_in_buffer;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public int AvailableBytes
		{
			get
			{
				try
				{
					return window_end - window_start + (bits_in_buffer >> 3);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public bool IsNeedingInput
		{
			get
			{
				try
				{
					return window_start == window_end;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public int PeekBits(int n)
		{
			int num2 = default(int);
			try
			{
				if (bits_in_buffer < n)
				{
					if (window_start == window_end)
					{
						return -1;
					}
					uint num = buffer;
					byte[] array = window;
					num2 = window_start++;
					int num3 = array[num2] & 0xFF;
					byte[] array2 = window;
					num2 = window_start++;
					buffer = num | (uint)((num3 | ((array2[num2] & 0xFF) << 8)) << bits_in_buffer);
					bits_in_buffer += 16;
				}
				return (int)(buffer & ((1 << n) - 1));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num2, this, n);
				throw;
			}
		}

		public void DropBits(int n)
		{
			try
			{
				buffer >>= n;
				bits_in_buffer -= n;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, n);
				throw;
			}
		}

		public void SkipToByteBoundary()
		{
			try
			{
				buffer >>= bits_in_buffer & 7;
				bits_in_buffer &= -8;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int CopyBytes(byte[] output, int offset, int length)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				num = 0;
				while (bits_in_buffer > 0 && length > 0)
				{
					output[offset++] = (byte)buffer;
					buffer >>= 8;
					bits_in_buffer -= 8;
					length--;
					num++;
				}
				if (length == 0)
				{
					return num;
				}
				num2 = window_end - window_start;
				if (length > num2)
				{
					length = num2;
				}
				Array.Copy(window, window_start, output, offset, length);
				window_start += length;
				if (((uint)(window_start - window_end) & (true ? 1u : 0u)) != 0)
				{
					byte[] array = window;
					num3 = window_start++;
					buffer = array[num3] & 0xFFu;
					bits_in_buffer = 8;
				}
				return num + length;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, num2, num3, this, output, offset, length);
				throw;
			}
		}

		public void Reset()
		{
			int num = default(int);
			try
			{
				num = 0;
				bits_in_buffer = 0;
				num = 0;
				window_end = 0;
				num = 0;
				window_start = 0;
				buffer = 0u;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		public void SetInput(byte[] buf, int off, int len)
		{
			int num = default(int);
			try
			{
				if (window_start < window_end)
				{
					throw new InvalidOperationException();
				}
				num = off + len;
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, this, buf, off, len);
				throw;
			}
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
			int num = default(int);
			try
			{
				num = windowFilled++;
				if (num == 32768)
				{
					throw new InvalidOperationException();
				}
				byte[] array = window;
				num = windowEnd++;
				array[num] = (byte)abyte;
				windowEnd &= 32767;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, abyte);
				throw;
			}
		}

		private void SlowRepeat(int repStart, int len, int dist)
		{
			int num = default(int);
			try
			{
				while (len-- > 0)
				{
					byte[] array = window;
					num = windowEnd++;
					array[num] = window[repStart++];
					windowEnd &= 32767;
					repStart &= 0x7FFF;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, this, repStart, len, dist);
				throw;
			}
		}

		public void Repeat(int len, int dist)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				num = (windowFilled += len);
				if (num > 32768)
				{
					throw new InvalidOperationException();
				}
				num2 = (windowEnd - dist) & 0x7FFF;
				num3 = 32768 - len;
				if (num2 <= num3 && windowEnd < num3)
				{
					if (len <= dist)
					{
						Array.Copy(window, num2, window, windowEnd, len);
						windowEnd += len;
						return;
					}
					while (len-- > 0)
					{
						byte[] array = window;
						num = windowEnd++;
						array[num] = window[num2++];
					}
				}
				else
				{
					SlowRepeat(num2, len, dist);
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num2, num3, num, this, len, dist);
				throw;
			}
		}

		public int CopyStored(StreamManipulator input, int len)
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				len = Math.Min(Math.Min(len, 32768 - windowFilled), input.AvailableBytes);
				num = 32768 - windowEnd;
				if (len > num)
				{
					num2 = input.CopyBytes(window, windowEnd, num);
					if (num2 == num)
					{
						num2 += input.CopyBytes(window, 0, len - num);
					}
				}
				else
				{
					num2 = input.CopyBytes(window, windowEnd, len);
				}
				windowEnd = (windowEnd + num2) & 0x7FFF;
				windowFilled += num2;
				return num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num2, num, this, input, len);
				throw;
			}
		}

		public void CopyDict(byte[] dict, int offset, int len)
		{
			try
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, dict, offset, len);
				throw;
			}
		}

		public int GetFreeSpace()
		{
			try
			{
				return 32768 - windowFilled;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int GetAvailable()
		{
			try
			{
				return windowFilled;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int CopyOutput(byte[] output, int offset, int len)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				num = windowEnd;
				if (len > windowFilled)
				{
					len = windowFilled;
				}
				else
				{
					num = (windowEnd - windowFilled + len) & 0x7FFF;
				}
				num2 = len;
				num3 = len - num;
				if (num3 > 0)
				{
					Array.Copy(window, 32768 - num3, output, offset, num3);
					offset += num3;
					len = num;
				}
				Array.Copy(window, num - len, output, offset, len);
				windowFilled -= num2;
				if (windowFilled < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, num2, num3, this, output, offset, len);
				throw;
			}
		}

		public void Reset()
		{
			int num = default(int);
			try
			{
				num = 0;
				windowEnd = 0;
				windowFilled = 0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
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
			byte[] array = default(byte[]);
			int num = default(int);
			try
			{
				array = new byte[288];
				num = 0;
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, array, num);
				throw;
			}
		}

		public InflaterHuffmanTree(byte[] codeLengths)
		{
			try
			{
				BuildTree(codeLengths);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, codeLengths);
				throw;
			}
		}

		private void BuildTree(byte[] codeLengths)
		{
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int i = default(int);
			int num = default(int);
			int[] array3 = default(int[]);
			nint num3 = default(nint);
			int num4 = default(int);
			int num5 = default(int);
			int j = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int k = default(int);
			int l = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			try
			{
				array = new int[16];
				array2 = new int[16];
				for (i = 0; i < codeLengths.Length; i++)
				{
					num = codeLengths[i];
					if (num > 0)
					{
						int[] array4 = (array3 = array);
						int num2 = num;
						num3 = num2;
						array4[num2] = array3[num3] + 1;
					}
				}
				num4 = 0;
				num5 = 512;
				for (j = 1; j <= 15; j++)
				{
					array2[j] = num4;
					num4 += array[j] << 16 - j;
					if (j >= 10)
					{
						num6 = array2[j] & 0x1FF80;
						num7 = num4 & 0x1FF80;
						num5 += num7 - num6 >> 16 - j;
					}
				}
				tree = new short[num5];
				num8 = 512;
				for (num9 = 15; num9 >= 10; num9--)
				{
					num10 = num4 & 0x1FF80;
					num4 -= array[num9] << 16 - num9;
					num11 = num4 & 0x1FF80;
					for (k = num11; k < num10; k += 128)
					{
						tree[DeflaterHuffman.BitReverse(k)] = (short)((-num8 << 4) | num9);
						num8 += 1 << num9 - 9;
					}
				}
				for (l = 0; l < codeLengths.Length; l++)
				{
					num12 = codeLengths[l];
					if (num12 == 0)
					{
						continue;
					}
					num4 = array2[num12];
					num13 = DeflaterHuffman.BitReverse(num4);
					if (num12 <= 9)
					{
						do
						{
							tree[num13] = (short)((l << 4) | num12);
							num13 += 1 << num12;
						}
						while (num13 < 512);
					}
					else
					{
						num14 = tree[num13 & 0x1FF];
						num15 = 1 << (num14 & 0xF);
						num14 = -(num14 >> 4);
						do
						{
							tree[num14 | (num13 >> 9)] = (short)((l << 4) | num12);
							num13 += 1 << num12;
						}
						while (num13 < num15);
					}
					array2[num12] = num4 + (1 << 16 - num12);
				}
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[23]
				{
					array, array2, i, num, num4, num5, j, num6, num7, num8,
					num9, num10, num11, k, l, num12, num13, num14, num15, array3,
					num3, this, codeLengths
				});
				throw;
			}
		}

		public int GetSymbol(StreamManipulator input)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int availableBits = default(int);
			int availableBits2 = default(int);
			try
			{
				if ((num = input.PeekBits(9)) >= 0)
				{
					if ((num2 = tree[num]) >= 0)
					{
						input.DropBits(num2 & 0xF);
						return num2 >> 4;
					}
					num3 = -(num2 >> 4);
					num4 = num2 & 0xF;
					if ((num = input.PeekBits(num4)) >= 0)
					{
						num2 = tree[num3 | (num >> 9)];
						input.DropBits(num2 & 0xF);
						return num2 >> 4;
					}
					availableBits = input.AvailableBits;
					num = input.PeekBits(availableBits);
					num2 = tree[num3 | (num >> 9)];
					if ((num2 & 0xF) <= availableBits)
					{
						input.DropBits(num2 & 0xF);
						return num2 >> 4;
					}
					return -1;
				}
				availableBits2 = input.AvailableBits;
				num = input.PeekBits(availableBits2);
				num2 = tree[num];
				if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
				{
					input.DropBits(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num, num2, num3, num4, availableBits, availableBits2, this, input);
				throw;
			}
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

		private static readonly int[] repMin;

		private static readonly int[] repBits;

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

		private static readonly int[] BL_ORDER;

		public bool Decode(StreamManipulator input)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int symbol = default(int);
			byte b = default(byte);
			int num5 = default(int);
			try
			{
				while (true)
				{
					num = mode;
					switch (num)
					{
					case 5:
						num2 = repBits[repSymbol];
						num3 = input.PeekBits(num2);
						if (num3 >= 0)
						{
							input.DropBits(num2);
							num3 += repMin[repSymbol];
							while (num3-- > 0)
							{
								byte[] array = litdistLens;
								num = ptr++;
								array[num] = lastLen;
							}
							if (ptr == this.num)
							{
								return true;
							}
							goto IL_009b;
						}
						return false;
					case 4:
						while (((symbol = blTree.GetSymbol(input)) & -16) == 0)
						{
							byte[] array2 = litdistLens;
							num = ptr++;
							int num4 = num;
							b = (lastLen = (byte)symbol);
							array2[num4] = b;
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
					case 3:
						while (ptr < blnum)
						{
							num5 = input.PeekBits(3);
							if (num5 >= 0)
							{
								input.DropBits(3);
								blLens[BL_ORDER[ptr]] = (byte)num5;
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
						blnum = input.PeekBits(4);
						if (blnum >= 0)
						{
							blnum += 4;
							input.DropBits(4);
							blLens = new byte[19];
							ptr = 0;
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
					IL_009b:
					mode = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num5, symbol, num2, num3, num, b, this, input);
				throw;
			}
		}

		public InflaterHuffmanTree BuildLitLenTree()
		{
			byte[] array = default(byte[]);
			try
			{
				array = new byte[lnum];
				Array.Copy(litdistLens, 0, array, 0, lnum);
				return new InflaterHuffmanTree(array);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, array, this);
				throw;
			}
		}

		public InflaterHuffmanTree BuildDistTree()
		{
			byte[] array = default(byte[]);
			try
			{
				array = new byte[dnum];
				Array.Copy(litdistLens, lnum, array, 0, dnum);
				return new InflaterHuffmanTree(array);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, array, this);
				throw;
			}
		}

		static InflaterDynHeader()
		{
			try
			{
				repMin = new int[3] { 3, 3, 11 };
				repBits = new int[3] { 2, 3, 7 };
				BL_ORDER = new int[19]
				{
					16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
					11, 4, 12, 3, 13, 2, 14, 1, 15
				};
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
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

		public long TotalOut
		{
			get
			{
				try
				{
					return totalOut;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public bool IsFinished
		{
			get
			{
				try
				{
					if (state == 30)
					{
						return pending.IsFlushed;
					}
					return false;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public bool IsNeedingInput
		{
			get
			{
				try
				{
					return engine.NeedsInput();
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public Deflater()
		{
			try
			{
				pending = new DeflaterPending();
				engine = new DeflaterEngine(pending);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public void Finish()
		{
			try
			{
				state |= 12;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public void SetInput(byte[] buffer)
		{
			try
			{
				engine.SetInput(buffer);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, buffer);
				throw;
			}
		}

		public int Deflate(byte[] output)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				num = 0;
				num2 = output.Length;
				num3 = num2;
				while (true)
				{
					num4 = pending.Flush(output, num, num2);
					num += num4;
					totalOut += num4;
					num2 -= num4;
					if (num2 == 0 || state == 30)
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
							for (num5 = 8 + (-pending.BitCount & 7); num5 > 0; num5 -= 10)
							{
								pending.WriteBits(2, 10);
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
					return num3 - num2;
				}
				return num3 - num2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, num, num2, num3, num4, num5, this, output);
				throw;
			}
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
				try
				{
					this.dh = dh;
					minNumCodes = minCodes;
					this.maxLength = maxLength;
					freqs = new short[elems];
					bl_counts = new int[maxLength];
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, this, dh, elems, minCodes, maxLength);
					throw;
				}
			}

			public void WriteSymbol(int code)
			{
				try
				{
					dh.pending.WriteBits(codes[code] & 0xFFFF, length[code]);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, code);
					throw;
				}
			}

			public void SetStaticCodes(short[] stCodes, byte[] stLength)
			{
				try
				{
					codes = stCodes;
					length = stLength;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, this, stCodes, stLength);
					throw;
				}
			}

			public void BuildCodes()
			{
				int[] array = default(int[]);
				int num = default(int);
				int i = default(int);
				int j = default(int);
				int num2 = default(int);
				int[] array2 = default(int[]);
				nint num4 = default(nint);
				try
				{
					array = new int[maxLength];
					num = 0;
					codes = new short[freqs.Length];
					for (i = 0; i < maxLength; i++)
					{
						array[i] = num;
						num += bl_counts[i] << 15 - i;
					}
					for (j = 0; j < numCodes; j++)
					{
						num2 = length[j];
						if (num2 > 0)
						{
							codes[j] = BitReverse(array[num2 - 1]);
							int[] array3 = (array2 = array);
							int num3 = num2 - 1;
							num4 = num3;
							array3[num3] = array2[num4] + (1 << 16 - num2);
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, array, num, i, j, num2, array2, num4, this);
					throw;
				}
			}

			private void BuildLength(int[] childs)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int i = default(int);
				int[] array = default(int[]);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				int[] array2 = default(int[]);
				nint num9 = default(nint);
				int num10 = default(int);
				int num15 = default(int);
				int num16 = default(int);
				int num17 = default(int);
				int num18 = default(int);
				try
				{
					length = new byte[freqs.Length];
					num = childs.Length / 2;
					num2 = (num + 1) / 2;
					num3 = 0;
					for (i = 0; i < maxLength; i++)
					{
						bl_counts[i] = 0;
					}
					array = new int[num];
					array[num - 1] = 0;
					for (num4 = num - 1; num4 >= 0; num4--)
					{
						if (childs[2 * num4 + 1] != -1)
						{
							num5 = array[num4] + 1;
							if (num5 > maxLength)
							{
								num5 = maxLength;
								num3++;
							}
							num6 = (array[childs[2 * num4]] = (array[childs[2 * num4 + 1]] = num5));
						}
						else
						{
							num7 = array[num4];
							int[] array3 = (array2 = bl_counts);
							int num8 = num7 - 1;
							num9 = num8;
							array3[num8] = array2[num9] + 1;
							length[childs[2 * num4]] = (byte)array[num4];
						}
					}
					if (num3 == 0)
					{
						return;
					}
					num10 = maxLength - 1;
					while (true)
					{
						if (bl_counts[--num10] != 0)
						{
							do
							{
								int[] array4 = (array2 = bl_counts);
								int num11 = num10;
								num9 = num11;
								array4[num11] = array2[num9] - 1;
								int[] array5 = (array2 = bl_counts);
								int num12 = ++num10;
								num9 = num12;
								array5[num12] = array2[num9] + 1;
								num3 -= 1 << maxLength - 1 - num10;
							}
							while (num3 > 0 && num10 < maxLength - 1);
							if (num3 <= 0)
							{
								break;
							}
						}
					}
					int[] array6 = (array2 = bl_counts);
					int num13 = maxLength - 1;
					num9 = num13;
					array6[num13] = array2[num9] + num3;
					int[] array7 = (array2 = bl_counts);
					int num14 = maxLength - 2;
					num9 = num14;
					array7[num14] = array2[num9] - num3;
					num15 = 2 * num2;
					for (num16 = maxLength; num16 != 0; num16--)
					{
						num17 = bl_counts[num16 - 1];
						while (num17 > 0)
						{
							num18 = 2 * childs[num15++];
							if (childs[num18 + 1] == -1)
							{
								length[childs[num18]] = (byte)num16;
								num17--;
							}
						}
					}
				}
				catch (Exception caughtException)
				{
					StackFrameHelper.CreateExceptionN(caughtException, new object[18]
					{
						num, num2, num3, i, array, num4, num5, num7, num10, num15,
						num16, num17, num18, num6, array2, num9, this, childs
					});
					throw;
				}
			}

			public void BuildTree()
			{
				int num = default(int);
				int[] array = default(int[]);
				int num2 = default(int);
				int num3 = default(int);
				int i = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				int num8 = default(int);
				int[] array2 = default(int[]);
				int[] array3 = default(int[]);
				int num9 = default(int);
				int j = default(int);
				int num10 = default(int);
				int num11 = default(int);
				int num12 = default(int);
				int num13 = default(int);
				int num14 = default(int);
				int num15 = default(int);
				int num16 = default(int);
				int num17 = default(int);
				try
				{
					num = freqs.Length;
					array = new int[num];
					num2 = 0;
					num3 = 0;
					for (i = 0; i < num; i++)
					{
						num4 = freqs[i];
						if (num4 != 0)
						{
							num5 = num2++;
							while (num5 > 0 && freqs[array[num6 = (num5 - 1) / 2]] > num4)
							{
								array[num5] = array[num6];
								num5 = num6;
							}
							array[num5] = i;
							num3 = i;
						}
					}
					while (num2 < 2)
					{
						num7 = ((num3 < 2) ? (++num3) : 0);
						array[num2++] = num7;
					}
					numCodes = Math.Max(num3 + 1, minNumCodes);
					num8 = num2;
					array2 = new int[4 * num2 - 2];
					array3 = new int[2 * num2 - 1];
					num9 = num8;
					for (j = 0; j < num2; j++)
					{
						num10 = (array2[2 * j] = array[j]);
						array2[2 * j + 1] = -1;
						array3[j] = freqs[num10] << 8;
						array[j] = j;
					}
					do
					{
						num11 = array[0];
						num12 = array[--num2];
						num13 = 0;
						for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
						{
							if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
							{
								num14++;
							}
							array[num13] = array[num14];
							num13 = num14;
						}
						num15 = array3[num12];
						while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
						{
							array[num14] = array[num13];
						}
						array[num14] = num12;
						num16 = array[0];
						num12 = num9++;
						array2[2 * num12] = num11;
						array2[2 * num12 + 1] = num16;
						num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
						num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
						num13 = 0;
						for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
						{
							if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
							{
								num14++;
							}
							array[num13] = array[num14];
							num13 = num14;
						}
						while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
						{
							array[num14] = array[num13];
						}
						array[num14] = num12;
					}
					while (num2 > 1);
					BuildLength(array2);
				}
				catch (Exception caughtException)
				{
					StackFrameHelper.CreateExceptionN(caughtException, new object[23]
					{
						num, array, num2, num3, i, num4, num5, num6, num7, num8,
						array2, array3, num9, j, num10, num11, num12, num13, num14, num15,
						num16, num17, this
					});
					throw;
				}
			}

			public int GetEncodedLength()
			{
				int num = default(int);
				int i = default(int);
				try
				{
					num = 0;
					for (i = 0; i < freqs.Length; i++)
					{
						num += freqs[i] * length[i];
					}
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num, i, this);
					throw;
				}
			}

			public void CalcBLFreq(Tree blTree)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				short[] array = default(short[]);
				nint num8 = default(nint);
				try
				{
					num = -1;
					num2 = 0;
					while (num2 < numCodes)
					{
						num3 = 1;
						num4 = length[num2];
						if (num4 == 0)
						{
							num5 = 138;
							num6 = 3;
						}
						else
						{
							num5 = 6;
							num6 = 3;
							if (num != num4)
							{
								short[] array2 = (array = blTree.freqs);
								int num7 = num4;
								num8 = num7;
								array2[num7] = (short)(array[num8] + 1);
								num3 = 0;
							}
						}
						num = num4;
						num2++;
						while (num2 < numCodes && num == length[num2])
						{
							num2++;
							if (++num3 >= num5)
							{
								break;
							}
						}
						if (num3 < num6)
						{
							short[] array3 = (array = blTree.freqs);
							int num9 = num;
							num8 = num9;
							array3[num9] = (short)(array[num8] + (short)num3);
						}
						else if (num != 0)
						{
							(array = blTree.freqs)[16] = (short)(array[16] + 1);
						}
						else if (num3 <= 10)
						{
							(array = blTree.freqs)[17] = (short)(array[17] + 1);
						}
						else
						{
							(array = blTree.freqs)[18] = (short)(array[18] + 1);
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException10(exception, num5, num6, num3, num, num2, num4, array, num8, this, blTree);
					throw;
				}
			}

			public void WriteTree(Tree blTree)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				try
				{
					num = -1;
					num2 = 0;
					while (num2 < numCodes)
					{
						num3 = 1;
						num4 = length[num2];
						if (num4 == 0)
						{
							num5 = 138;
							num6 = 3;
						}
						else
						{
							num5 = 6;
							num6 = 3;
							if (num != num4)
							{
								blTree.WriteSymbol(num4);
								num3 = 0;
							}
						}
						num = num4;
						num2++;
						while (num2 < numCodes && num == length[num2])
						{
							num2++;
							if (++num3 >= num5)
							{
								break;
							}
						}
						if (num3 < num6)
						{
							while (num3-- > 0)
							{
								blTree.WriteSymbol(num);
							}
						}
						else if (num != 0)
						{
							blTree.WriteSymbol(16);
							dh.pending.WriteBits(num3 - 3, 2);
						}
						else if (num3 <= 10)
						{
							blTree.WriteSymbol(17);
							dh.pending.WriteBits(num3 - 3, 3);
						}
						else
						{
							blTree.WriteSymbol(18);
							dh.pending.WriteBits(num3 - 11, 7);
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num5, num6, num3, num, num2, num4, this, blTree);
					throw;
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
			try
			{
				return (short)((bit4Reverse[toReverse & 0xF] << 12) | (bit4Reverse[(toReverse >> 4) & 0xF] << 8) | (bit4Reverse[(toReverse >> 8) & 0xF] << 4) | bit4Reverse[toReverse >> 12]);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, toReverse);
				throw;
			}
		}

		static DeflaterHuffman()
		{
			int i = default(int);
			try
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
				i = 0;
				while (i < 144)
				{
					staticLCodes[i] = BitReverse(48 + i << 8);
					staticLLength[i++] = 8;
				}
				while (i < 256)
				{
					staticLCodes[i] = BitReverse(256 + i << 7);
					staticLLength[i++] = 9;
				}
				while (i < 280)
				{
					staticLCodes[i] = BitReverse(-256 + i << 9);
					staticLLength[i++] = 7;
				}
				while (i < 286)
				{
					staticLCodes[i] = BitReverse(-88 + i << 8);
					staticLLength[i++] = 8;
				}
				staticDCodes = new short[30];
				staticDLength = new byte[30];
				for (i = 0; i < 30; i++)
				{
					staticDCodes[i] = BitReverse(i << 11);
					staticDLength[i] = 5;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, i);
				throw;
			}
		}

		public DeflaterHuffman(DeflaterPending pending)
		{
			try
			{
				this.pending = pending;
				literalTree = new Tree(this, 286, 257, 15);
				distTree = new Tree(this, 30, 1, 15);
				blTree = new Tree(this, 19, 4, 7);
				d_buf = new short[16384];
				l_buf = new byte[16384];
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, pending);
				throw;
			}
		}

		public void Init()
		{
			try
			{
				last_lit = 0;
				extra_bits = 0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		private int Lcode(int len)
		{
			int num = default(int);
			try
			{
				if (len == 255)
				{
					return 285;
				}
				num = 257;
				while (len >= 8)
				{
					num += 4;
					len >>= 1;
				}
				return num + len;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, len);
				throw;
			}
		}

		private int Dcode(int distance)
		{
			int num = default(int);
			try
			{
				num = 0;
				while (distance >= 4)
				{
					num += 2;
					distance >>= 1;
				}
				return num + distance;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, distance);
				throw;
			}
		}

		public void SendAllTrees(int blTreeCodes)
		{
			int i = default(int);
			try
			{
				blTree.BuildCodes();
				literalTree.BuildCodes();
				distTree.BuildCodes();
				pending.WriteBits(literalTree.numCodes - 257, 5);
				pending.WriteBits(distTree.numCodes - 1, 5);
				pending.WriteBits(blTreeCodes - 4, 4);
				for (i = 0; i < blTreeCodes; i++)
				{
					pending.WriteBits(blTree.length[BL_ORDER[i]], 3);
				}
				literalTree.WriteTree(blTree);
				distTree.WriteTree(blTree);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, i, this, blTreeCodes);
				throw;
			}
		}

		public void CompressBlock()
		{
			int i = default(int);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				for (i = 0; i < last_lit; i++)
				{
					num = l_buf[i] & 0xFF;
					num2 = d_buf[i];
					if (num2-- != 0)
					{
						num3 = Lcode(num);
						literalTree.WriteSymbol(num3);
						num4 = (num3 - 261) / 4;
						if (num4 > 0 && num4 <= 5)
						{
							pending.WriteBits(num & ((1 << num4) - 1), num4);
						}
						num5 = Dcode(num2);
						distTree.WriteSymbol(num5);
						num4 = num5 / 2 - 1;
						if (num4 > 0)
						{
							pending.WriteBits(num2 & ((1 << num4) - 1), num4);
						}
					}
					else
					{
						literalTree.WriteSymbol(num);
					}
				}
				literalTree.WriteSymbol(256);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, i, num, num2, num3, num4, num5, this);
				throw;
			}
		}

		public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			try
			{
				pending.WriteBits(lastBlock ? 1 : 0, 3);
				pending.AlignToByte();
				pending.WriteShort(storedLength);
				pending.WriteShort(~storedLength);
				pending.WriteBlock(stored, storedOffset, storedLength);
				Init();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, stored, storedOffset, storedLength, lastBlock);
				throw;
			}
		}

		public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			short[] freqs = default(short[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int i = default(int);
			int j = default(int);
			try
			{
				(freqs = literalTree.freqs)[256] = (short)(freqs[256] + 1);
				literalTree.BuildTree();
				distTree.BuildTree();
				literalTree.CalcBLFreq(blTree);
				distTree.CalcBLFreq(blTree);
				blTree.BuildTree();
				num = 4;
				for (num2 = 18; num2 > num; num2--)
				{
					if (blTree.length[BL_ORDER[num2]] > 0)
					{
						num = num2 + 1;
					}
				}
				num3 = 14 + num * 3 + blTree.GetEncodedLength() + literalTree.GetEncodedLength() + distTree.GetEncodedLength() + extra_bits;
				num4 = extra_bits;
				for (i = 0; i < 286; i++)
				{
					num4 += literalTree.freqs[i] * staticLLength[i];
				}
				for (j = 0; j < 30; j++)
				{
					num4 += distTree.freqs[j] * staticDLength[j];
				}
				if (num3 >= num4)
				{
					num3 = num4;
				}
				if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
				{
					FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
				}
				else if (num3 == num4)
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
					SendAllTrees(num);
					CompressBlock();
					Init();
				}
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[12]
				{
					num, num2, num3, num4, i, j, freqs, this, stored, storedOffset,
					storedLength, lastBlock
				});
				throw;
			}
		}

		public bool IsFull()
		{
			try
			{
				return last_lit >= 16384;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public bool TallyLit(int lit)
		{
			int num = default(int);
			short[] freqs = default(short[]);
			nint num2 = default(nint);
			try
			{
				d_buf[last_lit] = 0;
				byte[] array = l_buf;
				num = last_lit++;
				array[num] = (byte)lit;
				short[] array2 = (freqs = literalTree.freqs);
				num2 = lit;
				array2[lit] = (short)(freqs[num2] + 1);
				return IsFull();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, freqs, num2, this, lit);
				throw;
			}
		}

		public bool TallyDist(int dist, int len)
		{
			int num = default(int);
			int num2 = default(int);
			short[] freqs = default(short[]);
			nint num4 = default(nint);
			int num5 = default(int);
			try
			{
				d_buf[last_lit] = (short)dist;
				byte[] array = l_buf;
				num = last_lit++;
				array[num] = (byte)(len - 3);
				num2 = Lcode(len - 3);
				short[] array2 = (freqs = literalTree.freqs);
				int num3 = num2;
				num4 = num3;
				array2[num3] = (short)(freqs[num4] + 1);
				if (num2 >= 265 && num2 < 285)
				{
					extra_bits += (num2 - 261) / 4;
				}
				num5 = Dcode(dist - 1);
				short[] array3 = (freqs = distTree.freqs);
				int num6 = num5;
				num4 = num6;
				array3[num6] = (short)(freqs[num4] + 1);
				if (num5 >= 4)
				{
					extra_bits += num5 / 2 - 1;
				}
				return IsFull();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num2, num5, num, freqs, num4, this, dist, len);
				throw;
			}
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
			int num = default(int);
			try
			{
				this.pending = pending;
				huffman = new DeflaterHuffman(pending);
				window = new byte[65536];
				head = new short[32768];
				prev = new short[32768];
				num = 1;
				strstart = 1;
				blockStart = 1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, pending);
				throw;
			}
		}

		private void UpdateHash()
		{
			try
			{
				ins_h = (window[strstart] << 5) ^ window[strstart + 1];
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		private int InsertString()
		{
			int num = default(int);
			short num2 = default(short);
			try
			{
				num = ((ins_h << 5) ^ window[strstart + 2]) & 0x7FFF;
				num2 = (prev[strstart & 0x7FFF] = head[num]);
				head[num] = (short)strstart;
				ins_h = num;
				return num2 & 0xFFFF;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num2, num, this);
				throw;
			}
		}

		private void SlideWindow()
		{
			int i = default(int);
			int num = default(int);
			int j = default(int);
			int num2 = default(int);
			try
			{
				Array.Copy(window, 32768, window, 0, 32768);
				matchStart -= 32768;
				strstart -= 32768;
				blockStart -= 32768;
				for (i = 0; i < 32768; i++)
				{
					num = head[i] & 0xFFFF;
					head[i] = (short)((num >= 32768) ? (num - 32768) : 0);
				}
				for (j = 0; j < 32768; j++)
				{
					num2 = prev[j] & 0xFFFF;
					prev[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, i, num, j, num2, this);
				throw;
			}
		}

		public void FillWindow()
		{
			int num = default(int);
			try
			{
				if (strstart >= 65274)
				{
					SlideWindow();
				}
				while (lookahead < 262 && inputOff < inputEnd)
				{
					num = 65536 - lookahead - strstart;
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		private bool FindLongestMatch(int curMatch)
		{
			int num = default(int);
			int num2 = default(int);
			short[] array = default(short[]);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			byte b = default(byte);
			byte b2 = default(byte);
			int num8 = default(int);
			try
			{
				num = 128;
				num2 = 128;
				array = prev;
				num3 = strstart;
				num4 = strstart + matchLen;
				num5 = Math.Max(matchLen, 2);
				num6 = Math.Max(strstart - 32506, 0);
				num7 = strstart + 258 - 1;
				b = window[num4 - 1];
				b2 = window[num4];
				if (num5 >= 8)
				{
					num >>= 2;
				}
				if (num2 > lookahead)
				{
					num2 = lookahead;
				}
				do
				{
					if (window[curMatch + num5] != b2 || window[curMatch + num5 - 1] != b || window[curMatch] != window[num3] || window[curMatch + 1] != window[num3 + 1])
					{
						continue;
					}
					num8 = curMatch + 2;
					num3 += 2;
					while (window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && num3 < num7)
					{
					}
					if (num3 > num4)
					{
						matchStart = curMatch;
						num4 = num3;
						num5 = num3 - strstart;
						if (num5 >= num2)
						{
							break;
						}
						b = window[num4 - 1];
						b2 = window[num4];
					}
					num3 = strstart;
				}
				while ((curMatch = array[curMatch & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
				matchLen = Math.Min(num5, lookahead);
				return matchLen >= 3;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[13]
				{
					num, num2, array, num3, num8, num4, num5, num6, num7, b,
					b2, this, curMatch
				});
				throw;
			}
		}

		private bool DeflateSlow(bool flush, bool finish)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			bool flag = default(bool);
			try
			{
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
							num = matchStart;
							num2 = matchLen;
							if (lookahead >= 3)
							{
								num3 = InsertString();
								if (num3 != 0 && strstart - num3 <= 32506 && FindLongestMatch(num3) && matchLen <= 5 && matchLen == 3 && strstart - matchStart > 4096)
								{
									matchLen = 2;
								}
							}
							if (num2 >= 3 && matchLen <= num2)
							{
								huffman.TallyDist(strstart - 1 - num, num2);
								num2 -= 2;
								do
								{
									strstart++;
									lookahead--;
									if (lookahead >= 3)
									{
										InsertString();
									}
								}
								while (--num2 > 0);
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
				num4 = strstart - blockStart;
				if (prevAvailable)
				{
					num4--;
				}
				flag = finish && lookahead == 0 && !prevAvailable;
				huffman.FlushBlock(window, blockStart, num4, flag);
				blockStart += num4;
				return !flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, num, num2, num3, num4, flag, this, flush, finish);
				throw;
			}
		}

		public bool Deflate(bool flush, bool finish)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			try
			{
				do
				{
					FillWindow();
					flag = flush && inputOff == inputEnd;
					flag2 = DeflateSlow(flag, finish);
				}
				while (pending.IsFlushed && flag2);
				return flag2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, flag2, flag, this, flush, finish);
				throw;
			}
		}

		public void SetInput(byte[] buffer)
		{
			try
			{
				inputBuf = buffer;
				inputOff = 0;
				inputEnd = buffer.Length;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, buffer);
				throw;
			}
		}

		public bool NeedsInput()
		{
			try
			{
				return inputEnd == inputOff;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	internal sealed class DeflaterPending
	{
		protected byte[] buf = new byte[65536];

		private int start = 0;

		private int end = 0;

		private uint bits = 0u;

		private int bitCount = 0;

		public int BitCount
		{
			get
			{
				try
				{
					return bitCount;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public bool IsFlushed
		{
			get
			{
				try
				{
					return end == 0;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
		}

		public void WriteShort(int s)
		{
			int num = default(int);
			try
			{
				byte[] array = buf;
				num = end++;
				array[num] = (byte)s;
				byte[] array2 = buf;
				num = end++;
				array2[num] = (byte)(s >> 8);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, this, s);
				throw;
			}
		}

		public void WriteBlock(byte[] block, int offset, int len)
		{
			try
			{
				Array.Copy(block, offset, buf, end, len);
				end += len;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, block, offset, len);
				throw;
			}
		}

		public void AlignToByte()
		{
			int num = default(int);
			try
			{
				if (bitCount > 0)
				{
					byte[] array = buf;
					num = end++;
					array[num] = (byte)bits;
					if (bitCount > 8)
					{
						byte[] array2 = buf;
						num = end++;
						array2[num] = (byte)(bits >> 8);
					}
				}
				bits = 0u;
				bitCount = 0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		public void WriteBits(int b, int count)
		{
			int num = default(int);
			try
			{
				bits |= (uint)(b << bitCount);
				bitCount += count;
				if (bitCount >= 16)
				{
					byte[] array = buf;
					num = end++;
					array[num] = (byte)bits;
					byte[] array2 = buf;
					num = end++;
					array2[num] = (byte)(bits >> 8);
					bits >>= 16;
					bitCount -= 16;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, this, b, count);
				throw;
			}
		}

		public int Flush(byte[] output, int offset, int length)
		{
			int num = default(int);
			try
			{
				if (bitCount >= 8)
				{
					byte[] array = buf;
					num = end++;
					array[num] = (byte)bits;
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, this, output, offset, length);
				throw;
			}
		}
	}

	internal sealed class ZipStream : MemoryStream
	{
		public void WriteShort(int value)
		{
			try
			{
				WriteByte((byte)((uint)value & 0xFFu));
				WriteByte((byte)((uint)(value >> 8) & 0xFFu));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, value);
				throw;
			}
		}

		public void WriteInt(int value)
		{
			try
			{
				WriteShort(value);
				WriteShort(value >> 16);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, value);
				throw;
			}
		}

		public int ReadShort()
		{
			try
			{
				return ReadByte() | (ReadByte() << 8);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public int ReadInt()
		{
			try
			{
				return ReadShort() | (ReadShort() << 16);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
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
		byte[] publicKey = default(byte[]);
		byte[] publicKey2 = default(byte[]);
		int i = default(int);
		try
		{
			publicKey = executingAssembly.GetName().GetPublicKey();
			publicKey2 = callingAssembly.GetName().GetPublicKey();
			if (publicKey2 == null != (publicKey == null))
			{
				return false;
			}
			if (publicKey2 != null)
			{
				for (i = 0; i < publicKey2.Length; i++)
				{
					if (publicKey2[i] != publicKey[i])
					{
						return false;
					}
				}
			}
			return true;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, publicKey, publicKey2, i, executingAssembly, callingAssembly);
			throw;
		}
	}

	public static byte[] Unzip(byte[] buffer)
	{
		Assembly callingAssembly = default(Assembly);
		Assembly executingAssembly = default(Assembly);
		ZipStream zipStream = default(ZipStream);
		byte[] array = default(byte[]);
		int num = default(int);
		short num2 = default(short);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		Inflater inflater = default(Inflater);
		int num8 = default(int);
		int num9 = default(int);
		int i = default(int);
		int num10 = default(int);
		int num11 = default(int);
		byte[] array5 = default(byte[]);
		Inflater inflater2 = default(Inflater);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		DESCryptoIndirector dESCryptoIndirector = default(DESCryptoIndirector);
		ICryptoTransform dESCryptoTransform = default(ICryptoTransform);
		byte[] array8 = default(byte[]);
		byte[] array9 = default(byte[]);
		byte[] array10 = default(byte[]);
		AESCryptoIndirector aESCryptoIndirector = default(AESCryptoIndirector);
		ICryptoTransform aESCryptoTransform = default(ICryptoTransform);
		byte[] array11 = default(byte[]);
		try
		{
			callingAssembly = Assembly.GetCallingAssembly();
			executingAssembly = Assembly.GetExecutingAssembly();
			if ((object)callingAssembly != executingAssembly && !PublicKeysMatch(executingAssembly, callingAssembly))
			{
				return null;
			}
			zipStream = new ZipStream(buffer);
			array = new byte[0];
			num = zipStream.ReadInt();
			if (num == 67324752)
			{
				num2 = (short)zipStream.ReadShort();
				num3 = zipStream.ReadShort();
				num4 = zipStream.ReadShort();
				if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
				{
					throw new FormatException("Wrong Header Signature");
				}
				zipStream.ReadInt();
				zipStream.ReadInt();
				zipStream.ReadInt();
				num5 = zipStream.ReadInt();
				num6 = zipStream.ReadShort();
				num7 = zipStream.ReadShort();
				if (num6 > 0)
				{
					array2 = new byte[num6];
					zipStream.Read(array2, 0, num6);
				}
				if (num7 > 0)
				{
					array3 = new byte[num7];
					zipStream.Read(array3, 0, num7);
				}
				array4 = new byte[zipStream.Length - zipStream.Position];
				zipStream.Read(array4, 0, array4.Length);
				inflater = new Inflater(array4);
				array = new byte[num5];
				inflater.Inflate(array, 0, array.Length);
				array4 = null;
			}
			else
			{
				num8 = num >> 24;
				num -= num8 << 24;
				if (num != 8223355)
				{
					throw new FormatException("Unknown Header");
				}
				if (num8 == 1)
				{
					num9 = zipStream.ReadInt();
					array = new byte[num9];
					for (i = 0; i < num9; i += num11)
					{
						num10 = zipStream.ReadInt();
						num11 = zipStream.ReadInt();
						array5 = new byte[num10];
						zipStream.Read(array5, 0, array5.Length);
						inflater2 = new Inflater(array5);
						inflater2.Inflate(array, i, num11);
					}
				}
				if (num8 == 2)
				{
					array6 = new byte[8] { 246, 149, 138, 65, 4, 232, 249, 228 };
					array7 = new byte[8] { 217, 218, 254, 34, 200, 241, 209, 180 };
					dESCryptoIndirector = new DESCryptoIndirector();
					try
					{
						dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(array6, array7, decrypt: true);
						try
						{
							array8 = dESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
							array = Unzip(array8);
						}
						finally
						{
							dESCryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)dESCryptoIndirector)?.Dispose();
					}
				}
				if (num8 == 3)
				{
					array9 = new byte[16]
					{
						1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
						1, 1, 1, 1, 1, 1
					};
					array10 = new byte[16]
					{
						2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
						2, 2, 2, 2, 2, 2
					};
					aESCryptoIndirector = new AESCryptoIndirector();
					try
					{
						aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(array9, array10, decrypt: true);
						try
						{
							array11 = aESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
							array = Unzip(array11);
						}
						finally
						{
							aESCryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)aESCryptoIndirector)?.Dispose();
					}
				}
			}
			zipStream.Close();
			zipStream = null;
			return array;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[33]
			{
				callingAssembly, executingAssembly, zipStream, array, num, num2, num3, num4, num5, num6,
				num7, array2, array3, array4, inflater, num8, num9, i, num10, num11,
				inflater2, array5, array6, array7, dESCryptoIndirector, dESCryptoTransform, array8, array9, array10, aESCryptoIndirector,
				aESCryptoTransform, array11, buffer
			});
			throw;
		}
	}

	public static byte[] Zip(byte[] buffer)
	{
		try
		{
			return Zip(buffer, 1, null, null);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, buffer);
			throw;
		}
	}

	public static byte[] ZipAndEncrypt(byte[] buffer, byte[] key, byte[] iv)
	{
		try
		{
			return Zip(buffer, 2, key, iv);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, buffer, key, iv);
			throw;
		}
	}

	public static byte[] ZipAndAES(byte[] buffer, byte[] key, byte[] iv)
	{
		try
		{
			return Zip(buffer, 3, key, iv);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, buffer, key, iv);
			throw;
		}
	}

	private static byte[] Zip(byte[] buffer, int version, byte[] key, byte[] iv)
	{
		ZipStream zipStream = default(ZipStream);
		Deflater deflater2 = default(Deflater);
		DateTime now = default(DateTime);
		long num3 = default(long);
		uint[] array8 = default(uint[]);
		uint num4 = default(uint);
		uint num5 = default(uint);
		int num6 = default(int);
		int num7 = default(int);
		long position3 = default(long);
		byte[] bytes = default(byte[]);
		byte[] array9 = default(byte[]);
		int num8 = default(int);
		byte[] array10 = default(byte[]);
		int num9 = default(int);
		long totalOut = default(long);
		int i = default(int);
		byte[] array5 = default(byte[]);
		long position = default(long);
		Deflater deflater = default(Deflater);
		byte[] array6 = default(byte[]);
		int num = default(int);
		byte[] array7 = default(byte[]);
		int num2 = default(int);
		long position2 = default(long);
		byte[] array3 = default(byte[]);
		DESCryptoIndirector dESCryptoIndirector = default(DESCryptoIndirector);
		ICryptoTransform dESCryptoTransform = default(ICryptoTransform);
		byte[] array4 = default(byte[]);
		byte[] array = default(byte[]);
		AESCryptoIndirector aESCryptoIndirector = default(AESCryptoIndirector);
		ICryptoTransform aESCryptoTransform = default(ICryptoTransform);
		byte[] array2 = default(byte[]);
		byte[] array11 = default(byte[]);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				zipStream = new ZipStream();
				switch (version)
				{
				case 0:
					deflater2 = new Deflater();
					now = DateTime.Now;
					num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
					array8 = new uint[256]
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
					num4 = uint.MaxValue;
					num5 = uint.MaxValue;
					num6 = 0;
					num7 = buffer.Length;
					while (--num7 >= 0)
					{
						num5 = array8[(num5 ^ buffer[num6++]) & 0xFF] ^ (num5 >> 8);
					}
					num5 ^= num4;
					zipStream.WriteInt(67324752);
					zipStream.WriteShort(20);
					zipStream.WriteShort(0);
					zipStream.WriteShort(8);
					zipStream.WriteInt((int)num3);
					zipStream.WriteInt((int)num5);
					position3 = zipStream.Position;
					zipStream.WriteInt(0);
					zipStream.WriteInt(buffer.Length);
					bytes = Encoding.UTF8.GetBytes("{data}");
					zipStream.WriteShort(bytes.Length);
					zipStream.WriteShort(0);
					zipStream.Write(bytes, 0, bytes.Length);
					deflater2.SetInput(buffer);
					while (!deflater2.IsNeedingInput)
					{
						array9 = new byte[512];
						num8 = deflater2.Deflate(array9);
						if (num8 <= 0)
						{
							break;
						}
						zipStream.Write(array9, 0, num8);
					}
					deflater2.Finish();
					while (!deflater2.IsFinished)
					{
						array10 = new byte[512];
						num9 = deflater2.Deflate(array10);
						if (num9 <= 0)
						{
							break;
						}
						zipStream.Write(array10, 0, num9);
					}
					totalOut = deflater2.TotalOut;
					zipStream.WriteInt(33639248);
					zipStream.WriteShort(20);
					zipStream.WriteShort(20);
					zipStream.WriteShort(0);
					zipStream.WriteShort(8);
					zipStream.WriteInt((int)num3);
					zipStream.WriteInt((int)num5);
					zipStream.WriteInt((int)totalOut);
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
					zipStream.WriteInt((int)(30 + bytes.Length + totalOut));
					zipStream.WriteShort(0);
					zipStream.Seek(position3, SeekOrigin.Begin);
					zipStream.WriteInt((int)totalOut);
					break;
				case 1:
					zipStream.WriteInt(25000571);
					zipStream.WriteInt(buffer.Length);
					for (i = 0; i < buffer.Length; i += array5.Length)
					{
						array5 = new byte[Math.Min(2097151, buffer.Length - i)];
						Buffer.BlockCopy(buffer, i, array5, 0, array5.Length);
						position = zipStream.Position;
						zipStream.WriteInt(0);
						zipStream.WriteInt(array5.Length);
						deflater = new Deflater();
						deflater.SetInput(array5);
						while (!deflater.IsNeedingInput)
						{
							array6 = new byte[512];
							num = deflater.Deflate(array6);
							if (num <= 0)
							{
								break;
							}
							zipStream.Write(array6, 0, num);
						}
						deflater.Finish();
						while (!deflater.IsFinished)
						{
							array7 = new byte[512];
							num2 = deflater.Deflate(array7);
							if (num2 <= 0)
							{
								break;
							}
							zipStream.Write(array7, 0, num2);
						}
						position2 = zipStream.Position;
						zipStream.Position = position;
						zipStream.WriteInt((int)deflater.TotalOut);
						zipStream.Position = position2;
					}
					break;
				case 2:
					zipStream.WriteInt(41777787);
					array3 = Zip(buffer, 1, null, null);
					dESCryptoIndirector = new DESCryptoIndirector();
					try
					{
						dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(key, iv, decrypt: false);
						try
						{
							array4 = dESCryptoTransform.TransformFinalBlock(array3, 0, array3.Length);
							zipStream.Write(array4, 0, array4.Length);
						}
						finally
						{
							dESCryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)dESCryptoIndirector)?.Dispose();
					}
					break;
				case 3:
					zipStream.WriteInt(58555003);
					array = Zip(buffer, 1, null, null);
					aESCryptoIndirector = new AESCryptoIndirector();
					try
					{
						aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(key, iv, decrypt: false);
						try
						{
							array2 = aESCryptoTransform.TransformFinalBlock(array, 0, array.Length);
							zipStream.Write(array2, 0, array2.Length);
						}
						finally
						{
							aESCryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)aESCryptoIndirector)?.Dispose();
					}
					break;
				}
				zipStream.Flush();
				zipStream.Close();
				array11 = zipStream.ToArray();
				return array11;
			}
			catch (Exception ex)
			{
				ex2 = ex;
				ExceptionMessage = "ERR 2003: " + ex2.Message;
				throw;
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[39]
			{
				zipStream, deflater2, now, num3, array8, num4, num5, num6, num7, position3,
				bytes, array9, num8, array10, num9, totalOut, i, array5, position, deflater,
				array6, num, array7, num2, position2, array3, dESCryptoIndirector, dESCryptoTransform, array4, array,
				aESCryptoIndirector, aESCryptoTransform, array2, ex2, array11, buffer, version, key, iv
			});
			throw;
		}
	}
}
