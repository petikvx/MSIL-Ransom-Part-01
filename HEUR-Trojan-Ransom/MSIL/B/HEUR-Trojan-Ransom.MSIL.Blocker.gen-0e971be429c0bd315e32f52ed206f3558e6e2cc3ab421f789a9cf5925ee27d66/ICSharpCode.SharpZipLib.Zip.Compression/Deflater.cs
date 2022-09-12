using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class Deflater
{
	public const int BEST_COMPRESSION = 9;

	public const int BEST_SPEED = 1;

	private const int QtJbfGFjzIVcCUlfOusaSCpleIoAA = 16;

	private const int vfCVZOLTPGiwGSqAsKVyqfLTbgqt = 127;

	public const int DEFAULT_COMPRESSION = -1;

	public const int DEFLATED = 8;

	private DeflaterEngine akyMtNpHhKQfybPrhfArqYrQBIwX;

	private const int mDcSJrbCraoieSJMliAnLhAYWCpA = 30;

	private const int lAdAMmmDHaOSRktLFMUSflFetAhw = 28;

	private const int koZNGiPyISlxSXqwxQwThAHKTEtP = 20;

	private const int RHyXVjFPiWIYozmBnoQMMZqzafZF = 0;

	private const int oHxzSGQSbCsrCnuWqAqMSRqvnZzr = 8;

	private const int wyfYjqACxGNeOIsJAicARryEMgIq = 4;

	private const int UPAlbHlXRxIbXnjvArZRwagXdVzg = 1;

	private int qcfvqLzBLvFMcmwgjBAaFccGNCoDb;

	public const int NO_COMPRESSION = 0;

	private bool ioRngngmfjBHLJOBcsvsFHrdtHAAB;

	private DeflaterPending CuYexhYXycYPsNcAnazYdxbwUVJI;

	private const int namjbtzNIuXhMtuoLyPsGKZNSrsi = 1;

	private int vocWeQqGJQMVixlmsDfIGSzACRVfA;

	private long ZYMhdvZBitGeitcUnzJFQCPgeZdZ;

	public int Adler => akyMtNpHhKQfybPrhfArqYrQBIwX.Adler;

	public bool IsFinished
	{
		get
		{
			if (vocWeQqGJQMVixlmsDfIGSzACRVfA == 30)
			{
				goto IL_000f;
			}
			int num = 0;
			goto IL_003a;
			IL_002f:
			num = (CuYexhYXycYPsNcAnazYdxbwUVJI.IsFlushed ? 1 : 0);
			goto IL_003a;
			IL_003a:
			bool result = (byte)num != 0;
			int num2 = 810787414;
			goto IL_0014;
			IL_0014:
			switch ((uint)(num2 ^ 0x39F5D6A0) % 3u)
			{
			case 2u:
				break;
			case 1u:
				goto IL_002f;
			default:
				return result;
			}
			goto IL_000f;
			IL_000f:
			num2 = 1245482651;
			goto IL_0014;
		}
	}

	public bool IsNeedingInput => akyMtNpHhKQfybPrhfArqYrQBIwX.NeedsInput();

	public long TotalIn => akyMtNpHhKQfybPrhfArqYrQBIwX.TotalIn;

	public long TotalOut => ZYMhdvZBitGeitcUnzJFQCPgeZdZ;

	public Deflater()
		: this(-1, noZlibHeaderOrFooter: false)
	{
	}

	public Deflater(int level)
		: this(level, noZlibHeaderOrFooter: false)
	{
	}

	public Deflater(int level, bool noZlibHeaderOrFooter)
	{
		if (level == -1)
		{
			level = 6;
		}
		else if (level < 0 || level > 9)
		{
			throw new ArgumentOutOfRangeException("level");
		}
		CuYexhYXycYPsNcAnazYdxbwUVJI = new DeflaterPending();
		akyMtNpHhKQfybPrhfArqYrQBIwX = new DeflaterEngine(CuYexhYXycYPsNcAnazYdxbwUVJI);
		ioRngngmfjBHLJOBcsvsFHrdtHAAB = noZlibHeaderOrFooter;
		SetStrategy(DeflateStrategy.Default);
		SetLevel(level);
		Reset();
	}

	public int Deflate(byte[] output)
	{
		return Deflate(output, 0, output.Length);
	}

	public int Deflate(byte[] output, int offset, int length)
	{
		int num = length;
		if (vocWeQqGJQMVixlmsDfIGSzACRVfA != 127)
		{
			if (vocWeQqGJQMVixlmsDfIGSzACRVfA < 16)
			{
				int num2 = 30720;
				int num3 = qcfvqLzBLvFMcmwgjBAaFccGNCoDb - 1 >> 1;
				if (num3 < 0 || num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if (((uint)vocWeQqGJQMVixlmsDfIGSzACRVfA & (true ? 1u : 0u)) != 0)
				{
					num2 |= 0x20;
				}
				num2 += 31 - num2 % 31;
				CuYexhYXycYPsNcAnazYdxbwUVJI.WriteShortMSB(num2);
				if (((uint)vocWeQqGJQMVixlmsDfIGSzACRVfA & (true ? 1u : 0u)) != 0)
				{
					int adler = akyMtNpHhKQfybPrhfArqYrQBIwX.Adler;
					akyMtNpHhKQfybPrhfArqYrQBIwX.ResetAdler();
					CuYexhYXycYPsNcAnazYdxbwUVJI.WriteShortMSB(adler >> 16);
					CuYexhYXycYPsNcAnazYdxbwUVJI.WriteShortMSB(adler & 0xFFFF);
				}
				vocWeQqGJQMVixlmsDfIGSzACRVfA = 0x10 | (vocWeQqGJQMVixlmsDfIGSzACRVfA & 0xC);
			}
			while (true)
			{
				int num4 = CuYexhYXycYPsNcAnazYdxbwUVJI.Flush(output, offset, length);
				offset += num4;
				ZYMhdvZBitGeitcUnzJFQCPgeZdZ += num4;
				length -= num4;
				if (length == 0 || vocWeQqGJQMVixlmsDfIGSzACRVfA == 30)
				{
					break;
				}
				if (akyMtNpHhKQfybPrhfArqYrQBIwX.Deflate((vocWeQqGJQMVixlmsDfIGSzACRVfA & 4) != 0, (vocWeQqGJQMVixlmsDfIGSzACRVfA & 8) != 0))
				{
					continue;
				}
				if (vocWeQqGJQMVixlmsDfIGSzACRVfA != 16)
				{
					if (vocWeQqGJQMVixlmsDfIGSzACRVfA == 20)
					{
						if (qcfvqLzBLvFMcmwgjBAaFccGNCoDb != 0)
						{
							for (int num5 = 8 + (-CuYexhYXycYPsNcAnazYdxbwUVJI.BitCount & 7); num5 > 0; num5 -= 10)
							{
								CuYexhYXycYPsNcAnazYdxbwUVJI.WriteBits(2, 10);
							}
						}
						vocWeQqGJQMVixlmsDfIGSzACRVfA = 16;
					}
					else if (vocWeQqGJQMVixlmsDfIGSzACRVfA == 28)
					{
						CuYexhYXycYPsNcAnazYdxbwUVJI.AlignToByte();
						if (!ioRngngmfjBHLJOBcsvsFHrdtHAAB)
						{
							int adler2 = akyMtNpHhKQfybPrhfArqYrQBIwX.Adler;
							CuYexhYXycYPsNcAnazYdxbwUVJI.WriteShortMSB(adler2 >> 16);
							CuYexhYXycYPsNcAnazYdxbwUVJI.WriteShortMSB(adler2 & 0xFFFF);
						}
						vocWeQqGJQMVixlmsDfIGSzACRVfA = 30;
					}
					continue;
				}
				return num - length;
			}
			return num - length;
		}
		throw new InvalidOperationException("Deflater closed");
	}

	public void Finish()
	{
		vocWeQqGJQMVixlmsDfIGSzACRVfA |= 12;
	}

	public void Flush()
	{
		vocWeQqGJQMVixlmsDfIGSzACRVfA |= 4;
	}

	public int GetLevel()
	{
		return qcfvqLzBLvFMcmwgjBAaFccGNCoDb;
	}

	public void Reset()
	{
		vocWeQqGJQMVixlmsDfIGSzACRVfA = (ioRngngmfjBHLJOBcsvsFHrdtHAAB ? 16 : 0);
		ZYMhdvZBitGeitcUnzJFQCPgeZdZ = 0L;
		CuYexhYXycYPsNcAnazYdxbwUVJI.Reset();
		akyMtNpHhKQfybPrhfArqYrQBIwX.Reset();
	}

	public void SetDictionary(byte[] dictionary)
	{
		SetDictionary(dictionary, 0, dictionary.Length);
	}

	public void SetDictionary(byte[] dictionary, int index, int count)
	{
		if (vocWeQqGJQMVixlmsDfIGSzACRVfA != 0)
		{
			throw new InvalidOperationException();
		}
		vocWeQqGJQMVixlmsDfIGSzACRVfA = 1;
		akyMtNpHhKQfybPrhfArqYrQBIwX.SetDictionary(dictionary, index, count);
	}

	public void SetInput(byte[] input)
	{
		SetInput(input, 0, input.Length);
	}

	public void SetInput(byte[] input, int offset, int count)
	{
		if (((uint)vocWeQqGJQMVixlmsDfIGSzACRVfA & 8u) != 0)
		{
			throw new InvalidOperationException("Finish() already called");
		}
		akyMtNpHhKQfybPrhfArqYrQBIwX.SetInput(input, offset, count);
	}

	public void SetLevel(int level)
	{
		if (level != -1)
		{
			if (level < 0 || level > 9)
			{
				throw new ArgumentOutOfRangeException("level");
			}
		}
		else
		{
			level = 6;
		}
		if (qcfvqLzBLvFMcmwgjBAaFccGNCoDb != level)
		{
			qcfvqLzBLvFMcmwgjBAaFccGNCoDb = level;
			akyMtNpHhKQfybPrhfArqYrQBIwX.SetLevel(level);
		}
	}

	public void SetStrategy(DeflateStrategy strategy)
	{
		akyMtNpHhKQfybPrhfArqYrQBIwX.Strategy = strategy;
	}
}
