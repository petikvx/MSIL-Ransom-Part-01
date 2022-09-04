using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SmartAssembly.Zip;

public static class SimpleZip
{
	internal class Deflater
	{
		private int state = 16;

		private long totalOut;

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

		public void SetInput(byte[] byte_0)
		{
			engine.SetInput(byte_0);
		}

		public int Deflate(byte[] byte_0)
		{
			int num = 0;
			int num2 = byte_0.Length;
			int num3 = num2;
			while (true)
			{
				int num4 = pending.Flush(byte_0, num, num2);
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
						for (int num5 = 8 + (-pending.BitCount & 7); num5 > 0; num5 -= 10)
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
	}

	internal class DeflaterHuffman
	{
		public class Tree
		{
			public short[] freqs;

			public byte[] length;

			public int minNumCodes;

			public int numCodes;

			private short[] codes;

			private int[] bl_counts;

			private int maxLength;

			private DeflaterHuffman dh;

			public Tree(DeflaterHuffman deflaterHuffman_0, int int_0, int int_1, int int_2)
			{
				dh = deflaterHuffman_0;
				minNumCodes = int_1;
				maxLength = int_2;
				freqs = new short[int_0];
				bl_counts = new int[int_2];
			}

			public void WriteSymbol(int int_0)
			{
				dh.pending.WriteBits(codes[int_0] & 0xFFFF, length[int_0]);
			}

			public void SetStaticCodes(short[] short_0, byte[] byte_0)
			{
				codes = short_0;
				length = byte_0;
			}

			public void BuildCodes()
			{
				int[] array = new int[maxLength];
				int num = 0;
				codes = new short[freqs.Length];
				for (int i = 0; i < maxLength; i++)
				{
					array[i] = num;
					num += bl_counts[i] << 15 - i;
				}
				for (int j = 0; j < numCodes; j++)
				{
					int num2 = length[j];
					if (num2 > 0)
					{
						codes[j] = BitReverse(array[num2 - 1]);
						array[num2 - 1] += 1 << 16 - num2;
					}
				}
			}

			private void BuildLength(int[] int_0)
			{
				length = new byte[freqs.Length];
				int num = int_0.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < maxLength; i++)
				{
					bl_counts[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int num4 = num - 1; num4 >= 0; num4--)
				{
					if (int_0[2 * num4 + 1] != -1)
					{
						int num5 = array[num4] + 1;
						if (num5 > maxLength)
						{
							num5 = maxLength;
							num3++;
						}
						array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
					}
					else
					{
						int num6 = array[num4];
						bl_counts[num6 - 1]++;
						length[int_0[2 * num4]] = (byte)array[num4];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num7 = maxLength - 1;
				while (true)
				{
					if (bl_counts[--num7] != 0)
					{
						do
						{
							bl_counts[num7]--;
							bl_counts[++num7]++;
							num3 -= 1 << maxLength - 1 - num7;
						}
						while (num3 > 0 && num7 < maxLength - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				bl_counts[maxLength - 1] += num3;
				bl_counts[maxLength - 2] -= num3;
				int num8 = 2 * num2;
				for (int num9 = maxLength; num9 != 0; num9--)
				{
					int num10 = bl_counts[num9 - 1];
					while (num10 > 0)
					{
						int num11 = 2 * int_0[num8++];
						if (int_0[num11 + 1] == -1)
						{
							length[int_0[num11]] = (byte)num9;
							num10--;
						}
					}
				}
			}

			public void BuildTree()
			{
				int num = freqs.Length;
				int[] array = new int[num];
				int num2 = 0;
				int num3 = 0;
				for (int i = 0; i < num; i++)
				{
					int num4 = freqs[i];
					if (num4 != 0)
					{
						int num5 = num2++;
						int num6;
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
					int num7 = ((num3 < 2) ? (++num3) : 0);
					array[num2++] = num7;
				}
				numCodes = Math.Max(num3 + 1, minNumCodes);
				int num8 = num2;
				int[] array2 = new int[4 * num2 - 2];
				int[] array3 = new int[2 * num2 - 1];
				int num9 = num8;
				for (int j = 0; j < num2; j++)
				{
					int num10 = (array2[2 * j] = array[j]);
					array2[2 * j + 1] = -1;
					array3[j] = freqs[num10] << 8;
					array[j] = j;
				}
				do
				{
					int num11 = array[0];
					int num12 = array[--num2];
					int num13 = 0;
					int num14;
					for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
					{
						if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
						{
							num14++;
						}
						array[num13] = array[num14];
						num13 = num14;
					}
					int num15 = array3[num12];
					while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
					{
						array[num14] = array[num13];
					}
					array[num14] = num12;
					int num16 = array[0];
					num12 = num9++;
					array2[2 * num12] = num11;
					array2[2 * num12 + 1] = num16;
					int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
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

			public int GetEncodedLength()
			{
				int num = 0;
				for (int i = 0; i < freqs.Length; i++)
				{
					num += freqs[i] * length[i];
				}
				return num;
			}

			public void CalcBLFreq(Tree tree_0)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < numCodes)
				{
					int num3 = 1;
					int num4 = length[num2];
					int num5;
					int num6;
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
							tree_0.freqs[num4]++;
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
						tree_0.freqs[num] += (short)num3;
					}
					else if (num != 0)
					{
						tree_0.freqs[16]++;
					}
					else if (num3 <= 10)
					{
						tree_0.freqs[17]++;
					}
					else
					{
						tree_0.freqs[18]++;
					}
				}
			}

			public void WriteTree(Tree tree_0)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < numCodes)
				{
					int num3 = 1;
					int num4 = length[num2];
					int num5;
					int num6;
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
							tree_0.WriteSymbol(num4);
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
							tree_0.WriteSymbol(num);
						}
					}
					else if (num != 0)
					{
						tree_0.WriteSymbol(16);
						dh.pending.WriteBits(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						tree_0.WriteSymbol(17);
						dh.pending.WriteBits(num3 - 3, 3);
					}
					else
					{
						tree_0.WriteSymbol(18);
						dh.pending.WriteBits(num3 - 11, 7);
					}
				}
			}
		}

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

		public DeflaterHuffman(DeflaterPending deflaterPending_0)
		{
			pending = deflaterPending_0;
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

		private int Lcode(int int_0)
		{
			if (int_0 == 255)
			{
				return 285;
			}
			int num = 257;
			while (int_0 >= 8)
			{
				num += 4;
				int_0 >>= 1;
			}
			return num + int_0;
		}

		private int Dcode(int int_0)
		{
			int num = 0;
			while (int_0 >= 4)
			{
				num += 2;
				int_0 >>= 1;
			}
			return num + int_0;
		}

		public void SendAllTrees(int int_0)
		{
			blTree.BuildCodes();
			literalTree.BuildCodes();
			distTree.BuildCodes();
			pending.WriteBits(literalTree.numCodes - 257, 5);
			pending.WriteBits(distTree.numCodes - 1, 5);
			pending.WriteBits(int_0 - 4, 4);
			for (int i = 0; i < int_0; i++)
			{
				pending.WriteBits(blTree.length[BL_ORDER[i]], 3);
			}
			literalTree.WriteTree(blTree);
			distTree.WriteTree(blTree);
		}

		public void CompressBlock()
		{
			for (int i = 0; i < last_lit; i++)
			{
				int num = l_buf[i] & 0xFF;
				int num2 = d_buf[i];
				if (num2-- != 0)
				{
					int num3 = Lcode(num);
					literalTree.WriteSymbol(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						pending.WriteBits(num & ((1 << num4) - 1), num4);
					}
					int num5 = Dcode(num2);
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

		public void FlushStoredBlock(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			pending.WriteBits(bool_0 ? 1 : 0, 3);
			pending.AlignToByte();
			pending.WriteShort(int_1);
			pending.WriteShort(~int_1);
			pending.WriteBlock(byte_0, int_0, int_1);
			Init();
		}

		public void FlushBlock(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			literalTree.freqs[256]++;
			literalTree.BuildTree();
			distTree.BuildTree();
			literalTree.CalcBLFreq(blTree);
			distTree.CalcBLFreq(blTree);
			blTree.BuildTree();
			int num = 4;
			for (int num2 = 18; num2 > num; num2--)
			{
				if (blTree.length[BL_ORDER[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			int num3 = 14 + num * 3 + blTree.GetEncodedLength() + literalTree.GetEncodedLength() + distTree.GetEncodedLength() + extra_bits;
			int num4 = extra_bits;
			for (int i = 0; i < 286; i++)
			{
				num4 += literalTree.freqs[i] * staticLLength[i];
			}
			for (int j = 0; j < 30; j++)
			{
				num4 += distTree.freqs[j] * staticDLength[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
			{
				FlushStoredBlock(byte_0, int_0, int_1, bool_0);
			}
			else if (num3 == num4)
			{
				pending.WriteBits(2 + (bool_0 ? 1 : 0), 3);
				literalTree.SetStaticCodes(staticLCodes, staticLLength);
				distTree.SetStaticCodes(staticDCodes, staticDLength);
				CompressBlock();
				Init();
			}
			else
			{
				pending.WriteBits(4 + (bool_0 ? 1 : 0), 3);
				SendAllTrees(num);
				CompressBlock();
				Init();
			}
		}

		public bool IsFull()
		{
			return last_lit >= 16384;
		}

		public bool TallyLit(int int_0)
		{
			d_buf[last_lit] = 0;
			l_buf[last_lit++] = (byte)int_0;
			literalTree.freqs[int_0]++;
			return IsFull();
		}

		public bool TallyDist(int int_0, int int_1)
		{
			d_buf[last_lit] = (short)int_0;
			l_buf[last_lit++] = (byte)(int_1 - 3);
			int num = Lcode(int_1 - 3);
			literalTree.freqs[num]++;
			if (num >= 265 && num < 285)
			{
				extra_bits += (num - 261) / 4;
			}
			int num2 = Dcode(int_0 - 1);
			distTree.freqs[num2]++;
			if (num2 >= 4)
			{
				extra_bits += num2 / 2 - 1;
			}
			return IsFull();
		}
	}

	internal class DeflaterEngine
	{
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

		public DeflaterEngine(DeflaterPending deflaterPending_0)
		{
			pending = deflaterPending_0;
			huffman = new DeflaterHuffman(deflaterPending_0);
			window = new byte[65536];
			head = new short[32768];
			prev = new short[32768];
			int num = 1;
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

		private void SlideWindow()
		{
			Array.Copy(window, 32768, window, 0, 32768);
			matchStart -= 32768;
			strstart -= 32768;
			blockStart -= 32768;
			for (int i = 0; i < 32768; i++)
			{
				int num = head[i] & 0xFFFF;
				head[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (int j = 0; j < 32768; j++)
			{
				int num2 = prev[j] & 0xFFFF;
				prev[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
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

		private bool FindLongestMatch(int int_0)
		{
			int num = 128;
			int num2 = 128;
			short[] array = prev;
			int num3 = strstart;
			int num4 = strstart + matchLen;
			int num5 = Math.Max(matchLen, 2);
			int num6 = Math.Max(strstart - 32506, 0);
			int num7 = strstart + 258 - 1;
			byte b = window[num4 - 1];
			byte b2 = window[num4];
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
				if (window[int_0 + num5] != b2 || window[int_0 + num5 - 1] != b || window[int_0] != window[num3] || window[int_0 + 1] != window[num3 + 1])
				{
					continue;
				}
				int num8 = int_0 + 2;
				num3 += 2;
				while (window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && window[++num3] == window[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					matchStart = int_0;
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
			while ((int_0 = array[int_0 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			matchLen = Math.Min(num5, lookahead);
			return matchLen >= 3;
		}

		private bool DeflateSlow(bool bool_0, bool bool_1)
		{
			if (lookahead < 262 && !bool_0)
			{
				return false;
			}
			do
			{
				if (lookahead >= 262 || bool_0)
				{
					if (lookahead != 0)
					{
						if (strstart >= 65274)
						{
							SlideWindow();
						}
						int num = matchStart;
						int num2 = matchLen;
						if (lookahead >= 3)
						{
							int num3 = InsertString();
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
					huffman.FlushBlock(window, blockStart, strstart - blockStart, bool_1);
					blockStart = strstart;
					return false;
				}
				return true;
			}
			while (!huffman.IsFull());
			int num4 = strstart - blockStart;
			if (prevAvailable)
			{
				num4--;
			}
			bool flag = bool_1 && lookahead == 0 && !prevAvailable;
			huffman.FlushBlock(window, blockStart, num4, flag);
			blockStart += num4;
			return !flag;
		}

		public bool Deflate(bool bool_0, bool bool_1)
		{
			bool flag;
			do
			{
				FillWindow();
				bool bool_2 = bool_0 && inputOff == inputEnd;
				flag = DeflateSlow(bool_2, bool_1);
			}
			while (pending.IsFlushed && flag);
			return flag;
		}

		public void SetInput(byte[] byte_0)
		{
			inputBuf = byte_0;
			inputOff = 0;
			inputEnd = byte_0.Length;
		}

		public bool NeedsInput()
		{
			return inputEnd == inputOff;
		}
	}

	internal class DeflaterPending
	{
		protected byte[] buf = new byte[65536];

		private int start;

		private int end;

		private uint bits;

		private int bitCount;

		public int BitCount => bitCount;

		public bool IsFlushed => end == 0;

		public void WriteShort(int int_0)
		{
			buf[end++] = (byte)int_0;
			buf[end++] = (byte)(int_0 >> 8);
		}

		public void WriteBlock(byte[] byte_0, int int_0, int int_1)
		{
			Array.Copy(byte_0, int_0, buf, end, int_1);
			end += int_1;
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

		public void WriteBits(int int_0, int int_1)
		{
			bits |= (uint)(int_0 << bitCount);
			bitCount += int_1;
			if (bitCount >= 16)
			{
				buf[end++] = (byte)bits;
				buf[end++] = (byte)(bits >> 8);
				bits >>= 16;
				bitCount -= 16;
			}
		}

		public int Flush(byte[] byte_0, int int_0, int int_1)
		{
			if (bitCount >= 8)
			{
				buf[end++] = (byte)bits;
				bits >>= 8;
				bitCount -= 8;
			}
			if (int_1 > end - start)
			{
				int_1 = end - start;
				Array.Copy(buf, start, byte_0, int_0, int_1);
				start = 0;
				end = 0;
			}
			else
			{
				Array.Copy(buf, start, byte_0, int_0, int_1);
				start += int_1;
			}
			return int_1;
		}
	}

	internal class ZipStream : MemoryStream
	{
		public void WriteShort(int int_0)
		{
			WriteByte((byte)((uint)int_0 & 0xFFu));
			WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
		}

		public void WriteInt(int int_0)
		{
			WriteShort(int_0);
			WriteShort(int_0 >> 16);
		}
	}

	public static string ExceptionMessage;

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

	public static byte[] Zip(byte[] byte_0)
	{
		return Zip(byte_0, 1, null, null);
	}

	private static byte[] Zip(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			ZipStream zipStream = new ZipStream();
			switch (int_0)
			{
			case 0:
			{
				Deflater deflater2 = new Deflater();
				DateTime now = DateTime.Now;
				long num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
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
				uint num4 = uint.MaxValue;
				uint num5 = uint.MaxValue;
				int num6 = 0;
				int num7 = byte_0.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_0[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				zipStream.WriteInt(67324752);
				zipStream.WriteShort(20);
				zipStream.WriteShort(0);
				zipStream.WriteShort(8);
				zipStream.WriteInt((int)num3);
				zipStream.WriteInt((int)num5);
				long position3 = zipStream.Position;
				zipStream.WriteInt(0);
				zipStream.WriteInt(byte_0.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				zipStream.WriteShort(bytes.Length);
				zipStream.WriteShort(0);
				zipStream.Write(bytes, 0, bytes.Length);
				deflater2.SetInput(byte_0);
				while (!deflater2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = deflater2.Deflate(array9);
					if (num8 <= 0)
					{
						break;
					}
					zipStream.Write(array9, 0, num8);
				}
				deflater2.Finish();
				while (!deflater2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = deflater2.Deflate(array10);
					if (num9 <= 0)
					{
						break;
					}
					zipStream.Write(array10, 0, num9);
				}
				long totalOut = deflater2.TotalOut;
				zipStream.WriteInt(33639248);
				zipStream.WriteShort(20);
				zipStream.WriteShort(20);
				zipStream.WriteShort(0);
				zipStream.WriteShort(8);
				zipStream.WriteInt((int)num3);
				zipStream.WriteInt((int)num5);
				zipStream.WriteInt((int)totalOut);
				zipStream.WriteInt(byte_0.Length);
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
			}
			case 1:
			{
				zipStream.WriteInt(25000571);
				zipStream.WriteInt(byte_0.Length);
				byte[] array5;
				for (int i = 0; i < byte_0.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_0.Length - i)];
					Buffer.BlockCopy(byte_0, i, array5, 0, array5.Length);
					long position = zipStream.Position;
					zipStream.WriteInt(0);
					zipStream.WriteInt(array5.Length);
					Deflater deflater = new Deflater();
					deflater.SetInput(array5);
					while (!deflater.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = deflater.Deflate(array6);
						if (num <= 0)
						{
							break;
						}
						zipStream.Write(array6, 0, num);
					}
					deflater.Finish();
					while (!deflater.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = deflater.Deflate(array7);
						if (num2 <= 0)
						{
							break;
						}
						zipStream.Write(array7, 0, num2);
					}
					long position2 = zipStream.Position;
					zipStream.Position = position;
					zipStream.WriteInt((int)deflater.TotalOut);
					zipStream.Position = position2;
				}
				break;
			}
			case 2:
			{
				zipStream.WriteInt(41777787);
				byte[] array3 = Zip(byte_0, 1, null, null);
				using (ICryptoTransform cryptoTransform2 = GetDesTransform(byte_1, byte_2, bool_0: false))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					zipStream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				zipStream.WriteInt(58555003);
				byte[] array = Zip(byte_0, 1, null, null);
				using (ICryptoTransform cryptoTransform = GetAesTransform(byte_1, byte_2, bool_0: false))
				{
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
