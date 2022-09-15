using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Apache.Bzip2;

public class CBZip2OutputStream : Stream
{
	internal class StackElem
	{
		internal int ll;

		internal int hh;

		internal int dd;
	}

	protected const int SETMASK = 2097152;

	protected const int CLEARMASK = -2097153;

	protected const int GREATER_ICOST = 15;

	protected const int LESSER_ICOST = 0;

	protected const int SMALL_THRESH = 20;

	protected const int DEPTH_THRESH = 10;

	private bool finished;

	private int count;

	private int origPtr;

	private readonly int blockSize100k;

	private int allowableBlockSize;

	private bool blockRandomised;

	private int bsBuff;

	private int bsLive;

	private readonly CRC mCrc = new CRC();

	private bool[] inUse = new bool[256];

	private int nInUse;

	private char[] seqToUnseq = new char[256];

	private char[] unseqToSeq = new char[256];

	private char[] selector = new char[18002];

	private char[] selectorMtf = new char[18002];

	private byte[] blockBytes;

	private ushort[] quadrantShorts;

	private int[] zptr;

	private int[] szptr;

	private int[] ftab;

	private int nMTF;

	private int[] mtfFreq = new int[258];

	private int workFactor;

	private int workDone;

	private int workLimit;

	private bool firstAttempt;

	private int currentByte = -1;

	private int runLength;

	private bool closed;

	private int blockCRC;

	private int combinedCRC;

	private Stream bsStream;

	private static readonly int[] incs = new int[14]
	{
		1, 4, 13, 40, 121, 364, 1093, 3280, 9841, 29524,
		88573, 265720, 797161, 2391484
	};

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

	public override long Length => 0L;

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	private static void Panic()
	{
		throw new InvalidOperationException();
	}

	private void MakeMaps()
	{
		nInUse = 0;
		for (int i = 0; i < 256; i++)
		{
			if (inUse[i])
			{
				seqToUnseq[nInUse] = (char)i;
				unseqToSeq[i] = (char)nInUse;
				nInUse++;
			}
		}
	}

	protected static void HbMakeCodeLengths(byte[] len, int[] freq, int alphaSize, int maxLen)
	{
		int[] array = new int[260];
		int[] array2 = new int[516];
		int[] array3 = new int[516];
		for (int i = 0; i < alphaSize; i++)
		{
			array2[i + 1] = ((freq[i] == 0) ? 1 : freq[i]) << 8;
		}
		while (true)
		{
			int num = alphaSize;
			int num2 = 0;
			array[0] = 0;
			array2[0] = 0;
			array3[0] = -2;
			for (int j = 1; j <= alphaSize; j++)
			{
				array3[j] = -1;
				array[++num2] = j;
				int num3 = num2;
				int num4 = array[num3];
				while (array2[num4] < array2[array[num3 >> 1]])
				{
					array[num3] = array[num3 >> 1];
					num3 >>= 1;
				}
				array[num3] = num4;
			}
			if (num2 >= 260)
			{
				Panic();
			}
			while (num2 > 1)
			{
				int num5 = array[1];
				array[1] = array[num2--];
				int num6 = 1;
				int num7 = array[1];
				while (true)
				{
					int num8 = num6 << 1;
					if (num8 > num2)
					{
						break;
					}
					if (num8 < num2 && array2[array[num8 + 1]] < array2[array[num8]])
					{
						num8++;
					}
					if (array2[num7] < array2[array[num8]])
					{
						break;
					}
					array[num6] = array[num8];
					num6 = num8;
				}
				array[num6] = num7;
				int num9 = array[1];
				array[1] = array[num2--];
				int num10 = 1;
				int num11 = array[1];
				while (true)
				{
					int num12 = num10 << 1;
					if (num12 > num2)
					{
						break;
					}
					if (num12 < num2 && array2[array[num12 + 1]] < array2[array[num12]])
					{
						num12++;
					}
					if (array2[num11] < array2[array[num12]])
					{
						break;
					}
					array[num10] = array[num12];
					num10 = num12;
				}
				array[num10] = num11;
				num++;
				array3[num5] = (array3[num9] = num);
				array2[num] = (int)((array2[num5] & 0xFFFFFF00L) + (array2[num9] & 0xFFFFFF00L)) | (1 + (((array2[num5] & 0xFF) > (array2[num9] & 0xFF)) ? (array2[num5] & 0xFF) : (array2[num9] & 0xFF)));
				array3[num] = -1;
				array[++num2] = num;
				int num13 = num2;
				int num14 = array[num13];
				while (array2[num14] < array2[array[num13 >> 1]])
				{
					array[num13] = array[num13 >> 1];
					num13 >>= 1;
				}
				array[num13] = num14;
			}
			if (num >= 516)
			{
				Panic();
			}
			bool flag = false;
			for (int k = 1; k <= alphaSize; k++)
			{
				int num15 = 0;
				int num16 = k;
				while (array3[num16] >= 0)
				{
					num16 = array3[num16];
					num15++;
				}
				len[k - 1] = (byte)num15;
				if (num15 > maxLen)
				{
					flag = true;
				}
			}
			if (flag)
			{
				for (int l = 1; l < alphaSize; l++)
				{
					int num17 = array2[l] >> 8;
					num17 = 1 + num17 / 2;
					array2[l] = num17 << 8;
				}
				continue;
			}
			break;
		}
	}

	public CBZip2OutputStream(Stream outStream)
		: this(outStream, 9)
	{
	}

	public CBZip2OutputStream(Stream outStream, int blockSize)
	{
		blockBytes = null;
		quadrantShorts = null;
		zptr = null;
		ftab = null;
		outStream.WriteByte(66);
		outStream.WriteByte(90);
		BsSetStream(outStream);
		workFactor = 50;
		if (blockSize > 9)
		{
			blockSize = 9;
		}
		if (blockSize < 1)
		{
			blockSize = 1;
		}
		blockSize100k = blockSize;
		AllocateCompressStructures();
		Initialize();
		InitBlock();
	}

	public override void WriteByte(byte b)
	{
		if (currentByte == b)
		{
			runLength++;
			if (runLength > 254)
			{
				WriteRun();
				currentByte = -1;
				runLength = 0;
			}
		}
		else if (currentByte == -1)
		{
			currentByte = b;
			runLength++;
		}
		else
		{
			WriteRun();
			runLength = 1;
			currentByte = b;
		}
	}

	private void WriteRun()
	{
		if (count > allowableBlockSize)
		{
			EndBlock();
			InitBlock();
		}
		inUse[currentByte] = true;
		for (int i = 0; i < runLength; i++)
		{
			mCrc.UpdateCRC(currentByte);
		}
		switch (runLength)
		{
		default:
			inUse[runLength - 4] = true;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)(runLength - 4);
			break;
		case 1:
			blockBytes[++count] = (byte)currentByte;
			break;
		case 2:
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			break;
		case 3:
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			break;
		}
	}

	public override void Close()
	{
		if (!closed)
		{
			Finish();
			closed = true;
			Platform.Dispose(bsStream);
			base.Close();
		}
	}

	public void Finish()
	{
		if (!finished)
		{
			if (runLength > 0)
			{
				WriteRun();
			}
			currentByte = -1;
			if (count > 0)
			{
				EndBlock();
			}
			EndCompression();
			finished = true;
			Flush();
		}
	}

	public override void Flush()
	{
		bsStream.Flush();
	}

	private void Initialize()
	{
		BsPutUChar(104);
		BsPutUChar(48 + blockSize100k);
		combinedCRC = 0;
	}

	private void InitBlock()
	{
		mCrc.InitialiseCRC();
		count = 0;
		for (int i = 0; i < 256; i++)
		{
			inUse[i] = false;
		}
		allowableBlockSize = 100000 * blockSize100k - 20;
	}

	private void EndBlock()
	{
		blockCRC = mCrc.GetFinalCRC();
		combinedCRC = Integers.RotateLeft(combinedCRC, 1) ^ blockCRC;
		DoReversibleTransformation();
		BsPutUChar(49);
		BsPutUChar(65);
		BsPutUChar(89);
		BsPutUChar(38);
		BsPutUChar(83);
		BsPutUChar(89);
		BsPutint(blockCRC);
		BsW(1, blockRandomised ? 1 : 0);
		MoveToFrontCodeAndSend();
	}

	private void EndCompression()
	{
		BsPutUChar(23);
		BsPutUChar(114);
		BsPutUChar(69);
		BsPutUChar(56);
		BsPutUChar(80);
		BsPutUChar(144);
		BsPutint(combinedCRC);
		BsFinishedWithStream();
	}

	private void HbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
	{
		int num = 0;
		for (int i = minLen; i <= maxLen; i++)
		{
			for (int j = 0; j < alphaSize; j++)
			{
				if (length[j] == i)
				{
					code[j] = num;
					num++;
				}
			}
			num <<= 1;
		}
	}

	private void BsSetStream(Stream f)
	{
		bsStream = f;
		bsLive = 0;
		bsBuff = 0;
	}

	private void BsFinishedWithStream()
	{
		while (bsLive > 0)
		{
			bsStream.WriteByte((byte)(bsBuff >> 24));
			bsBuff <<= 8;
			bsLive -= 8;
		}
	}

	private void BsW(int n, int v)
	{
		while (bsLive >= 8)
		{
			bsStream.WriteByte((byte)(bsBuff >> 24));
			bsBuff <<= 8;
			bsLive -= 8;
		}
		bsBuff |= v << 32 - bsLive - n;
		bsLive += n;
	}

	private void BsPutUChar(int c)
	{
		BsW(8, c);
	}

	private void BsPutint(int u)
	{
		BsW(16, (u >> 16) & 0xFFFF);
		BsW(16, u & 0xFFFF);
	}

	private void BsPutIntVS(int numBits, int c)
	{
		BsW(numBits, c);
	}

	private void SendMTFValues()
	{
		byte[][] array = CBZip2InputStream.InitByteArray(6, 258);
		int num = 0;
		int num2 = nInUse + 2;
		for (int i = 0; i < 6; i++)
		{
			byte[] array2 = array[i];
			for (int j = 0; j < num2; j++)
			{
				array2[j] = 15;
			}
		}
		if (nMTF <= 0)
		{
			Panic();
		}
		int num3 = ((nMTF < 200) ? 2 : ((nMTF < 600) ? 3 : ((nMTF < 1200) ? 4 : ((nMTF >= 2400) ? 6 : 5))));
		int num4 = num3;
		int num5 = nMTF;
		int num6 = 0;
		while (num4 > 0)
		{
			int num7 = num5 / num4;
			int num8 = num6 - 1;
			int k;
			for (k = 0; k < num7; k += mtfFreq[++num8])
			{
				if (num8 >= num2 - 1)
				{
					break;
				}
			}
			if (num8 > num6 && num4 != num3 && num4 != 1 && (num3 - num4) % 2 == 1)
			{
				k -= mtfFreq[num8--];
			}
			byte[] array3 = array[num4 - 1];
			for (int j = 0; j < num2; j++)
			{
				if (j >= num6 && j <= num8)
				{
					array3[j] = 0;
				}
				else
				{
					array3[j] = 15;
				}
			}
			num4--;
			num6 = num8 + 1;
			num5 -= k;
		}
		int[][] array4 = CBZip2InputStream.InitIntArray(6, 258);
		int[] array5 = new int[6];
		short[] array6 = new short[6];
		byte[] array7 = array[0];
		byte[] array8 = array[1];
		byte[] array9 = array[2];
		byte[] array10 = array[3];
		byte[] array11 = array[4];
		byte[] array12 = array[5];
		for (int l = 0; l < 4; l++)
		{
			for (int i = 0; i < num3; i++)
			{
				array5[i] = 0;
				int[] array13 = array4[i];
				for (int j = 0; j < num2; j++)
				{
					array13[j] = 0;
				}
			}
			num = 0;
			num6 = 0;
			while (num6 < nMTF)
			{
				int num8 = System.Math.Min(num6 + 50 - 1, nMTF - 1);
				if (num3 == 6)
				{
					short num9 = 0;
					short num10 = 0;
					short num11 = 0;
					short num12 = 0;
					short num13 = 0;
					short num14 = 0;
					for (int m = num6; m <= num8; m++)
					{
						int num15 = szptr[m];
						num9 = (short)(num9 + array7[num15]);
						num10 = (short)(num10 + array8[num15]);
						num11 = (short)(num11 + array9[num15]);
						num12 = (short)(num12 + array10[num15]);
						num13 = (short)(num13 + array11[num15]);
						num14 = (short)(num14 + array12[num15]);
					}
					array6[0] = num9;
					array6[1] = num10;
					array6[2] = num11;
					array6[3] = num12;
					array6[4] = num13;
					array6[5] = num14;
				}
				else
				{
					for (int i = 0; i < num3; i++)
					{
						array6[i] = 0;
					}
					for (int m = num6; m <= num8; m++)
					{
						int num16 = szptr[m];
						for (int i = 0; i < num3; i++)
						{
							ref short reference = ref array6[i];
							reference = (short)(reference + array[i][num16]);
						}
					}
				}
				int num17 = 999999999;
				int num18 = -1;
				for (int i = 0; i < num3; i++)
				{
					if (array6[i] < num17)
					{
						num17 = array6[i];
						num18 = i;
					}
				}
				array5[num18]++;
				selector[num] = (char)num18;
				num++;
				int[] array14 = array4[num18];
				for (int m = num6; m <= num8; m++)
				{
					array14[szptr[m]]++;
				}
				num6 = num8 + 1;
			}
			for (int i = 0; i < num3; i++)
			{
				HbMakeCodeLengths(array[i], array4[i], num2, 20);
			}
		}
		array4 = null;
		array5 = null;
		array6 = null;
		if (num3 >= 8)
		{
			Panic();
		}
		if (num >= 32768 || num > 18002)
		{
			Panic();
		}
		char[] array15 = new char[6];
		for (int m = 0; m < num3; m++)
		{
			array15[m] = (char)m;
		}
		for (int m = 0; m < num; m++)
		{
			char c = selector[m];
			int num19 = 0;
			char c2 = array15[0];
			while (c != c2)
			{
				num19++;
				char c3 = c2;
				c2 = array15[num19];
				array15[num19] = c3;
			}
			array15[0] = c2;
			selectorMtf[m] = (char)num19;
		}
		int[][] array16 = CBZip2InputStream.InitIntArray(6, 258);
		for (int i = 0; i < num3; i++)
		{
			int num20 = 32;
			int num21 = 0;
			byte[] array17 = array[i];
			for (int m = 0; m < num2; m++)
			{
				int num22 = array17[m];
				if (num22 > num21)
				{
					num21 = num22;
				}
				if (num22 < num20)
				{
					num20 = num22;
				}
			}
			if (num21 > 20)
			{
				Panic();
			}
			if (num20 < 1)
			{
				Panic();
			}
			HbAssignCodes(array16[i], array[i], num20, num21, num2);
		}
		bool[] array18 = new bool[16];
		for (int m = 0; m < 16; m++)
		{
			array18[m] = false;
			int num23 = m * 16;
			for (int num19 = 0; num19 < 16; num19++)
			{
				if (inUse[num23 + num19])
				{
					array18[m] = true;
					break;
				}
			}
		}
		for (int m = 0; m < 16; m++)
		{
			BsW(1, array18[m] ? 1 : 0);
		}
		for (int m = 0; m < 16; m++)
		{
			if (array18[m])
			{
				int num24 = m * 16;
				for (int num19 = 0; num19 < 16; num19++)
				{
					BsW(1, inUse[num24 + num19] ? 1 : 0);
				}
			}
		}
		BsW(3, num3);
		BsW(15, num);
		for (int m = 0; m < num; m++)
		{
			int num25;
			for (num25 = selectorMtf[m]; num25 >= 24; num25 -= 24)
			{
				BsW(24, 16777215);
			}
			BsW(num25 + 1, (1 << num25 + 1) - 2);
		}
		for (int i = 0; i < num3; i++)
		{
			byte[] array19 = array[i];
			int n = array19[0];
			BsW(5, n);
			for (int m = 0; m < num2; m++)
			{
				int num26;
				for (num26 = array19[m]; n < num26; n++)
				{
					BsW(2, 2);
				}
				while (n > num26)
				{
					BsW(2, 3);
					n--;
				}
				BsW(1, 0);
			}
		}
		int num27 = 0;
		num6 = 0;
		while (num6 < nMTF)
		{
			int num8 = System.Math.Min(num6 + 50 - 1, nMTF - 1);
			int num28 = selector[num27];
			byte[] array20 = array[num28];
			int[] array21 = array16[num28];
			for (int m = num6; m <= num8; m++)
			{
				int num29 = szptr[m];
				BsW(array20[num29], array21[num29]);
			}
			num6 = num8 + 1;
			num27++;
		}
		if (num27 != num)
		{
			Panic();
		}
	}

	private void MoveToFrontCodeAndSend()
	{
		BsPutIntVS(24, origPtr);
		GenerateMTFValues();
		SendMTFValues();
	}

	private void SimpleSort(int lo, int hi, int d)
	{
		int num = hi - lo + 1;
		if (num < 2)
		{
			return;
		}
		int i;
		for (i = 0; incs[i] < num; i++)
		{
		}
		for (i--; i >= 0; i--)
		{
			int num2 = incs[i];
			int num3 = lo + num2;
			while (num3 <= hi)
			{
				int num4 = zptr[num3];
				int num5 = num3;
				while (FullGtU(zptr[num5 - num2] + d, num4 + d))
				{
					zptr[num5] = zptr[num5 - num2];
					num5 -= num2;
					if (num5 <= lo + num2 - 1)
					{
						break;
					}
				}
				zptr[num5] = num4;
				if (++num3 > hi)
				{
					break;
				}
				num4 = zptr[num3];
				num5 = num3;
				while (FullGtU(zptr[num5 - num2] + d, num4 + d))
				{
					zptr[num5] = zptr[num5 - num2];
					num5 -= num2;
					if (num5 <= lo + num2 - 1)
					{
						break;
					}
				}
				zptr[num5] = num4;
				if (++num3 > hi)
				{
					break;
				}
				num4 = zptr[num3];
				num5 = num3;
				while (FullGtU(zptr[num5 - num2] + d, num4 + d))
				{
					zptr[num5] = zptr[num5 - num2];
					num5 -= num2;
					if (num5 <= lo + num2 - 1)
					{
						break;
					}
				}
				zptr[num5] = num4;
				num3++;
				if (workDone > workLimit && firstAttempt)
				{
					return;
				}
			}
		}
	}

	private void Vswap(int p1, int p2, int n)
	{
		while (--n >= 0)
		{
			int num = zptr[p1];
			int num2 = zptr[p2];
			zptr[p1++] = num2;
			zptr[p2++] = num;
		}
	}

	private int Med3(int a, int b, int c)
	{
		if (a <= b)
		{
			if (c >= a)
			{
				if (c <= b)
				{
					return c;
				}
				return b;
			}
			return a;
		}
		if (c >= b)
		{
			if (c <= a)
			{
				return c;
			}
			return a;
		}
		return b;
	}

	private static void PushStackElem(IList stack, int stackCount, int ll, int hh, int dd)
	{
		StackElem stackElem;
		if (stackCount < stack.Count)
		{
			stackElem = (StackElem)stack[stackCount];
		}
		else
		{
			stackElem = new StackElem();
			stack.Add(stackElem);
		}
		stackElem.ll = ll;
		stackElem.hh = hh;
		stackElem.dd = dd;
	}

	private void QSort3(int loSt, int hiSt, int dSt)
	{
		IList list = Platform.CreateArrayList();
		int num = 0;
		int num2 = loSt;
		int num3 = hiSt;
		int num4 = dSt;
		while (true)
		{
			if (num3 - num2 < 20 || num4 > 10)
			{
				SimpleSort(num2, num3, num4);
				if (num >= 1 && (workDone <= workLimit || !firstAttempt))
				{
					StackElem obj = (StackElem)list[--num];
					num2 = obj.ll;
					num3 = obj.hh;
					num4 = obj.dd;
					continue;
				}
				break;
			}
			int num5 = num4 + 1;
			int num6 = Med3(blockBytes[zptr[num2] + num5], blockBytes[zptr[num3] + num5], blockBytes[zptr[num2 + num3 >> 1] + num5]);
			int num7;
			int num8 = (num7 = num2);
			int num9;
			int num10 = (num9 = num3);
			int num12;
			while (true)
			{
				if (num8 <= num10)
				{
					int num11 = zptr[num8];
					num12 = blockBytes[num11 + num5] - num6;
					if (num12 <= 0)
					{
						if (num12 == 0)
						{
							zptr[num8] = zptr[num7];
							zptr[num7++] = num11;
						}
						num8++;
						continue;
					}
				}
				while (num8 <= num10)
				{
					int num13 = zptr[num10];
					num12 = blockBytes[num13 + num5] - num6;
					if (num12 < 0)
					{
						break;
					}
					if (num12 == 0)
					{
						zptr[num10] = zptr[num9];
						zptr[num9--] = num13;
					}
					num10--;
				}
				if (num8 > num10)
				{
					break;
				}
				int num14 = zptr[num8];
				zptr[num8++] = zptr[num10];
				zptr[num10--] = num14;
			}
			if (num9 < num7)
			{
				num4 = num5;
				continue;
			}
			num12 = System.Math.Min(num7 - num2, num8 - num7);
			Vswap(num2, num8 - num12, num12);
			int num15 = System.Math.Min(num3 - num9, num9 - num10);
			Vswap(num8, num3 - num15 + 1, num15);
			num12 = num2 + (num8 - num7);
			num15 = num3 - (num9 - num10);
			PushStackElem(list, num++, num2, num12 - 1, num4);
			PushStackElem(list, num++, num12, num15, num5);
			num2 = num15 + 1;
		}
	}

	private void MainSort()
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		bool[] array3 = new bool[256];
		for (int i = 0; i < 20; i++)
		{
			blockBytes[count + i + 1] = blockBytes[i % count + 1];
		}
		for (int i = 0; i <= count + 20; i++)
		{
			quadrantShorts[i] = 0;
		}
		blockBytes[0] = blockBytes[count];
		if (count <= 4000)
		{
			for (int i = 0; i < count; i++)
			{
				zptr[i] = i;
			}
			firstAttempt = false;
			workLimit = 0;
			workDone = 0;
			SimpleSort(0, count - 1, 0);
			return;
		}
		for (int i = 0; i <= 255; i++)
		{
			array3[i] = false;
		}
		for (int i = 0; i <= 65536; i++)
		{
			ftab[i] = 0;
		}
		int num = blockBytes[0];
		for (int i = 1; i <= count; i++)
		{
			int num2 = blockBytes[i];
			ftab[(num << 8) + num2]++;
			num = num2;
		}
		for (int i = 0; i < 65536; i++)
		{
			ftab[i + 1] += ftab[i];
		}
		num = blockBytes[1];
		int num3;
		for (int i = 0; i < count - 1; i++)
		{
			int num2 = blockBytes[i + 2];
			num3 = (num << 8) + num2;
			num = num2;
			ftab[num3]--;
			zptr[ftab[num3]] = i;
		}
		num3 = (blockBytes[count] << 8) + blockBytes[1];
		ftab[num3]--;
		zptr[ftab[num3]] = count - 1;
		for (int i = 0; i <= 255; i++)
		{
			array[i] = i;
		}
		int num4 = 1;
		do
		{
			num4 = 3 * num4 + 1;
		}
		while (num4 <= 256);
		do
		{
			num4 /= 3;
			for (int i = num4; i <= 255; i++)
			{
				int num5 = array[i];
				num3 = i;
				while (ftab[array[num3 - num4] + 1 << 8] - ftab[array[num3 - num4] << 8] > ftab[num5 + 1 << 8] - ftab[num5 << 8])
				{
					array[num3] = array[num3 - num4];
					num3 -= num4;
					if (num3 < num4)
					{
						break;
					}
				}
				array[num3] = num5;
			}
		}
		while (num4 != 1);
		for (int i = 0; i <= 255; i++)
		{
			int num6 = array[i];
			for (num3 = 0; num3 <= 255; num3++)
			{
				int num7 = (num6 << 8) + num3;
				if ((ftab[num7] & 0x200000) == 2097152)
				{
					continue;
				}
				int num8 = ftab[num7] & -2097153;
				int num9 = (ftab[num7 + 1] & -2097153) - 1;
				if (num9 > num8)
				{
					QSort3(num8, num9, 2);
					if (workDone > workLimit && firstAttempt)
					{
						return;
					}
				}
				ftab[num7] |= 2097152;
			}
			array3[num6] = true;
			if (i < 255)
			{
				int num10 = ftab[num6 << 8] & -2097153;
				int num11 = (ftab[num6 + 1 << 8] & -2097153) - num10;
				int j;
				for (j = 0; num11 >> j > 65534; j++)
				{
				}
				for (num3 = 0; num3 < num11; num3++)
				{
					int num12 = zptr[num10 + num3] + 1;
					ushort num13 = (ushort)(num3 >> j);
					quadrantShorts[num12] = num13;
					if (num12 <= 20)
					{
						quadrantShorts[num12 + count] = num13;
					}
				}
				if (num11 - 1 >> j > 65535)
				{
					Panic();
				}
			}
			for (num3 = 0; num3 <= 255; num3++)
			{
				array2[num3] = ftab[(num3 << 8) + num6] & -2097153;
			}
			for (num3 = ftab[num6 << 8] & -2097153; num3 < (ftab[num6 + 1 << 8] & -2097153); num3++)
			{
				int num14 = zptr[num3];
				num = blockBytes[num14];
				if (!array3[num])
				{
					zptr[array2[num]] = ((num14 == 0) ? count : num14) - 1;
					array2[num]++;
				}
			}
			for (num3 = 0; num3 <= 255; num3++)
			{
				ftab[(num3 << 8) + num6] |= 2097152;
			}
		}
	}

	private void RandomiseBlock()
	{
		for (int i = 0; i < 256; i++)
		{
			inUse[i] = false;
		}
		int num = 0;
		int num2 = 0;
		for (int j = 0; j < count; j++)
		{
			if (num == 0)
			{
				num = BZip2Constants.rNums[num2];
				if (++num2 == 512)
				{
					num2 = 0;
				}
			}
			num--;
			blockBytes[j + 1] ^= ((num == 1) ? ((byte)1) : ((byte)0));
			inUse[blockBytes[j + 1]] = true;
		}
	}

	private void DoReversibleTransformation()
	{
		workLimit = workFactor * (count - 1);
		workDone = 0;
		blockRandomised = false;
		firstAttempt = true;
		MainSort();
		if (workDone > workLimit && firstAttempt)
		{
			RandomiseBlock();
			workDone = 0;
			workLimit = 0;
			blockRandomised = true;
			firstAttempt = false;
			MainSort();
		}
		origPtr = -1;
		for (int i = 0; i < count; i++)
		{
			if (zptr[i] == 0)
			{
				origPtr = i;
				break;
			}
		}
		if (origPtr == -1)
		{
			Panic();
		}
	}

	private bool FullGtU(int i1, int i2)
	{
		int num = blockBytes[++i1];
		int num2 = blockBytes[++i2];
		if (num != num2)
		{
			return num > num2;
		}
		num = blockBytes[++i1];
		num2 = blockBytes[++i2];
		if (num != num2)
		{
			return num > num2;
		}
		num = blockBytes[++i1];
		num2 = blockBytes[++i2];
		if (num != num2)
		{
			return num > num2;
		}
		num = blockBytes[++i1];
		num2 = blockBytes[++i2];
		if (num != num2)
		{
			return num > num2;
		}
		num = blockBytes[++i1];
		num2 = blockBytes[++i2];
		if (num != num2)
		{
			return num > num2;
		}
		num = blockBytes[++i1];
		num2 = blockBytes[++i2];
		if (num != num2)
		{
			return num > num2;
		}
		int num3 = count;
		do
		{
			num = blockBytes[++i1];
			num2 = blockBytes[++i2];
			if (num == num2)
			{
				int num4 = quadrantShorts[i1];
				int num5 = quadrantShorts[i2];
				if (num4 == num5)
				{
					num = blockBytes[++i1];
					num2 = blockBytes[++i2];
					if (num == num2)
					{
						num4 = quadrantShorts[i1];
						num5 = quadrantShorts[i2];
						if (num4 == num5)
						{
							num = blockBytes[++i1];
							num2 = blockBytes[++i2];
							if (num == num2)
							{
								num4 = quadrantShorts[i1];
								num5 = quadrantShorts[i2];
								if (num4 == num5)
								{
									num = blockBytes[++i1];
									num2 = blockBytes[++i2];
									if (num == num2)
									{
										num4 = quadrantShorts[i1];
										num5 = quadrantShorts[i2];
										if (num4 == num5)
										{
											if (i1 >= count)
											{
												i1 -= count;
											}
											if (i2 >= count)
											{
												i2 -= count;
											}
											num3 -= 4;
											workDone++;
											continue;
										}
										return num4 > num5;
									}
									return num > num2;
								}
								return num4 > num5;
							}
							return num > num2;
						}
						return num4 > num5;
					}
					return num > num2;
				}
				return num4 > num5;
			}
			return num > num2;
		}
		while (num3 >= 0);
		return false;
	}

	private void AllocateCompressStructures()
	{
		int num = 100000 * blockSize100k;
		blockBytes = new byte[num + 1 + 20];
		quadrantShorts = new ushort[num + 1 + 20];
		zptr = new int[num];
		ftab = new int[65537];
		szptr = zptr;
	}

	private void GenerateMTFValues()
	{
		char[] array = new char[256];
		MakeMaps();
		int num = nInUse + 1;
		for (int i = 0; i <= num; i++)
		{
			mtfFreq[i] = 0;
		}
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < nInUse; i++)
		{
			array[i] = (char)i;
		}
		for (int i = 0; i < count; i++)
		{
			char c = unseqToSeq[blockBytes[zptr[i]]];
			int num4 = 0;
			char c2 = array[0];
			while (c != c2)
			{
				num4++;
				char c3 = c2;
				c2 = array[num4];
				array[num4] = c3;
			}
			array[0] = c2;
			if (num4 == 0)
			{
				num3++;
				continue;
			}
			if (num3 > 0)
			{
				num3--;
				while (true)
				{
					int num5 = num3 % 2;
					if (num5 == 0)
					{
						szptr[num2++] = 0;
						mtfFreq[0]++;
					}
					else if (num5 == 1)
					{
						szptr[num2++] = 1;
						mtfFreq[1]++;
					}
					if (num3 < 2)
					{
						break;
					}
					num3 = (num3 - 2) / 2;
				}
				num3 = 0;
			}
			szptr[num2++] = num4 + 1;
			mtfFreq[num4 + 1]++;
		}
		if (num3 > 0)
		{
			num3--;
			while (true)
			{
				int num5 = num3 % 2;
				if (num5 == 0)
				{
					szptr[num2++] = 0;
					mtfFreq[0]++;
				}
				else if (num5 == 1)
				{
					szptr[num2++] = 1;
					mtfFreq[1]++;
				}
				if (num3 < 2)
				{
					break;
				}
				num3 = (num3 - 2) / 2;
			}
		}
		szptr[num2++] = num;
		mtfFreq[num]++;
		nMTF = num2;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		for (int i = 0; i < count; i++)
		{
			WriteByte(buffer[i + offset]);
		}
	}
}
