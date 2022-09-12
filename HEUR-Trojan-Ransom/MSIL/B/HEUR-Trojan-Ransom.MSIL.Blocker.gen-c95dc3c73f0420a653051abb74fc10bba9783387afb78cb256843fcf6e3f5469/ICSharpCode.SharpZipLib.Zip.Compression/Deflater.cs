using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class Deflater
{
	public const int BEST_COMPRESSION = 9;

	public const int BEST_SPEED = 1;

	private const int HKVkJfzEbrGMMJjWLkhNCgoaodvVB = 16;

	private const int qlMlctxhVnAaMzodjHWREBYUZYfG = 127;

	public const int DEFAULT_COMPRESSION = -1;

	public const int DEFLATED = 8;

	private DeflaterEngine fsyRVsDhpzPsgGFCqJtIYvwHxXvG;

	private const int lvPbcoGJYWRAqmrgNorxBvcVYjZpA = 30;

	private const int elfgcRGULXkgVJfeYKBbTrIlCxsEA = 28;

	private const int fCJsTDtSOhHZAinVqvPkHwQHltwh = 20;

	private const int EBmWjMblBtcieAOLwbpteNSmHJCM = 0;

	private const int tTliZxyzSrJCAClFhtpnghBuwOaD = 8;

	private const int bKdTmXebxnMAGnXkVflxrMbLFsHh = 4;

	private const int JBAtZmHdNOhcDiIYZIymgOlhGSeRB = 1;

	private int nibMIiVaVSuxgXiXmPYJICfNbazL;

	public const int NO_COMPRESSION = 0;

	private bool hBRKxYCCnOlkHtaofGuNlguqSwJq;

	private DeflaterPending TjKPLGeiaLhcagazwKehJcslqfAw;

	private const int kTeyHWFcAVwzYAiHIlvDiDAOHlvr = 1;

	private int ebaUcpSHPvhyiEtDxoSjaRsZqJGj;

	private long SrCqLMdMcUzSeOKdoSXawZGpwzeH;

	public int Adler => fsyRVsDhpzPsgGFCqJtIYvwHxXvG.Adler;

	public bool IsFinished
	{
		get
		{
			if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj == 30)
			{
				return TjKPLGeiaLhcagazwKehJcslqfAw.IsFlushed;
			}
			return false;
		}
	}

	public bool IsNeedingInput => fsyRVsDhpzPsgGFCqJtIYvwHxXvG.NeedsInput();

	public long TotalIn => fsyRVsDhpzPsgGFCqJtIYvwHxXvG.TotalIn;

	public long TotalOut => SrCqLMdMcUzSeOKdoSXawZGpwzeH;

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
		switch (level)
		{
		default:
			throw new ArgumentOutOfRangeException("level");
		case -1:
			level = 6;
			break;
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
			break;
		}
		TjKPLGeiaLhcagazwKehJcslqfAw = new DeflaterPending();
		fsyRVsDhpzPsgGFCqJtIYvwHxXvG = new DeflaterEngine(TjKPLGeiaLhcagazwKehJcslqfAw);
		hBRKxYCCnOlkHtaofGuNlguqSwJq = noZlibHeaderOrFooter;
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
		if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj == 127)
		{
			throw new InvalidOperationException("Deflater closed");
		}
		if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj < 16)
		{
			int num2 = 30720;
			int num3 = nibMIiVaVSuxgXiXmPYJICfNbazL - 1 >> 1;
			if (num3 < 0 || num3 > 3)
			{
				num3 = 3;
			}
			num2 |= num3 << 6;
			if (((uint)ebaUcpSHPvhyiEtDxoSjaRsZqJGj & (true ? 1u : 0u)) != 0)
			{
				num2 |= 0x20;
			}
			num2 += 31 - num2 % 31;
			TjKPLGeiaLhcagazwKehJcslqfAw.WriteShortMSB(num2);
			if (((uint)ebaUcpSHPvhyiEtDxoSjaRsZqJGj & (true ? 1u : 0u)) != 0)
			{
				int adler = fsyRVsDhpzPsgGFCqJtIYvwHxXvG.Adler;
				fsyRVsDhpzPsgGFCqJtIYvwHxXvG.ResetAdler();
				TjKPLGeiaLhcagazwKehJcslqfAw.WriteShortMSB(adler >> 16);
				TjKPLGeiaLhcagazwKehJcslqfAw.WriteShortMSB(adler & 0xFFFF);
			}
			ebaUcpSHPvhyiEtDxoSjaRsZqJGj = 0x10 | (ebaUcpSHPvhyiEtDxoSjaRsZqJGj & 0xC);
		}
		while (true)
		{
			int num4 = TjKPLGeiaLhcagazwKehJcslqfAw.Flush(output, offset, length);
			offset += num4;
			SrCqLMdMcUzSeOKdoSXawZGpwzeH += num4;
			length -= num4;
			if (length != 0 && ebaUcpSHPvhyiEtDxoSjaRsZqJGj != 30)
			{
				if (fsyRVsDhpzPsgGFCqJtIYvwHxXvG.Deflate((ebaUcpSHPvhyiEtDxoSjaRsZqJGj & 4) != 0, (ebaUcpSHPvhyiEtDxoSjaRsZqJGj & 8) != 0))
				{
					continue;
				}
				if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj == 16)
				{
					break;
				}
				if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj != 20)
				{
					if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj == 28)
					{
						TjKPLGeiaLhcagazwKehJcslqfAw.AlignToByte();
						if (!hBRKxYCCnOlkHtaofGuNlguqSwJq)
						{
							int adler2 = fsyRVsDhpzPsgGFCqJtIYvwHxXvG.Adler;
							TjKPLGeiaLhcagazwKehJcslqfAw.WriteShortMSB(adler2 >> 16);
							TjKPLGeiaLhcagazwKehJcslqfAw.WriteShortMSB(adler2 & 0xFFFF);
						}
						ebaUcpSHPvhyiEtDxoSjaRsZqJGj = 30;
					}
					continue;
				}
				if (nibMIiVaVSuxgXiXmPYJICfNbazL != 0)
				{
					for (int num5 = 8 + (-TjKPLGeiaLhcagazwKehJcslqfAw.BitCount & 7); num5 > 0; num5 -= 10)
					{
						TjKPLGeiaLhcagazwKehJcslqfAw.WriteBits(2, 10);
					}
				}
				ebaUcpSHPvhyiEtDxoSjaRsZqJGj = 16;
				continue;
			}
			return num - length;
		}
		return num - length;
	}

	public void Finish()
	{
		ebaUcpSHPvhyiEtDxoSjaRsZqJGj |= 12;
	}

	public void Flush()
	{
		ebaUcpSHPvhyiEtDxoSjaRsZqJGj |= 4;
	}

	public int GetLevel()
	{
		return nibMIiVaVSuxgXiXmPYJICfNbazL;
	}

	public void Reset()
	{
		ebaUcpSHPvhyiEtDxoSjaRsZqJGj = (hBRKxYCCnOlkHtaofGuNlguqSwJq ? 16 : 0);
		SrCqLMdMcUzSeOKdoSXawZGpwzeH = 0L;
		TjKPLGeiaLhcagazwKehJcslqfAw.Reset();
		fsyRVsDhpzPsgGFCqJtIYvwHxXvG.Reset();
	}

	public void SetDictionary(byte[] dictionary)
	{
		SetDictionary(dictionary, 0, dictionary.Length);
	}

	public void SetDictionary(byte[] dictionary, int index, int count)
	{
		if (ebaUcpSHPvhyiEtDxoSjaRsZqJGj != 0)
		{
			throw new InvalidOperationException();
		}
		ebaUcpSHPvhyiEtDxoSjaRsZqJGj = 1;
		fsyRVsDhpzPsgGFCqJtIYvwHxXvG.SetDictionary(dictionary, index, count);
	}

	public void SetInput(byte[] input)
	{
		SetInput(input, 0, input.Length);
	}

	public void SetInput(byte[] input, int offset, int count)
	{
		if (((uint)ebaUcpSHPvhyiEtDxoSjaRsZqJGj & 8u) != 0)
		{
			throw new InvalidOperationException("Finish() already called");
		}
		fsyRVsDhpzPsgGFCqJtIYvwHxXvG.SetInput(input, offset, count);
	}

	public void SetLevel(int level)
	{
		if (level == -1)
		{
			level = 6;
		}
		else if (level < 0 || level > 9)
		{
			throw new ArgumentOutOfRangeException("level");
		}
		if (nibMIiVaVSuxgXiXmPYJICfNbazL != level)
		{
			nibMIiVaVSuxgXiXmPYJICfNbazL = level;
			fsyRVsDhpzPsgGFCqJtIYvwHxXvG.SetLevel(level);
		}
	}

	public void SetStrategy(DeflateStrategy strategy)
	{
		fsyRVsDhpzPsgGFCqJtIYvwHxXvG.Strategy = strategy;
	}
}
