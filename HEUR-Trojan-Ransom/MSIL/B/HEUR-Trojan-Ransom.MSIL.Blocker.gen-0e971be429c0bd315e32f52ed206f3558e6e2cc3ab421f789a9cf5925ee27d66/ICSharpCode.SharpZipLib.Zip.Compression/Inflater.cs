using System;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class Inflater
{
	private Adler32 IfPFmiMsiqpHWKiRMCSJeyrSLfyi;

	private static readonly int[] jNmDxuUnXpCsBixVFZABfSIgorO = new int[30]
	{
		0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
		4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
		9, 9, 10, 10, 11, 11, 12, 12, 13, 13
	};

	private static readonly int[] tRlyaUaOHuSOHMoCHBULBMLNDLQD = new int[30]
	{
		1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
		33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
		1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
	};

	private static readonly int[] xpeuTfdfOoSAADhBeTrWIJCOCHaDA = new int[29]
	{
		3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
		15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
		67, 83, 99, 115, 131, 163, 195, 227, 258
	};

	private static readonly int[] SRPCxCgNqgPjHTOtTLlBVmUFIlcGA = new int[29]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
		4, 4, 4, 4, 5, 5, 5, 5, 0
	};

	private const int RiIUkwrrTZOXzAnaMLRpFrluQkgW = 2;

	private const int uwqwXPuvQisXLGDxETDDMEgDCVKN = 11;

	private const int UlIhdEuHaJENWNiTJsAxyFjeOlfl = 1;

	private const int DiEYaYfMzumAqyMRVvZcLRWVxDQg = 6;

	private const int OEOHHSASBQoayModAOCPyeNWwKlBA = 0;

	private const int SKlCPBTAjUokdCUSPeJldDugcMBl = 7;

	private const int nzxQGcojTfMXFegCHAvKMiYaULHq = 9;

	private const int GYuEBJMwwuNHVtfUdssrAPLZgLPb = 10;

	private const int HFrCdWPmYAFmpKBZcKhQoujLxhvi = 8;

	private const int LhWdLAuqfXGYewGplFAxBopMMeGAb = 5;

	private const int lzJntjMBDcqZsyJIKrSysBTPcIBHA = 3;

	private const int dNrdjxQCfbbHdKhyCWBIKPmcAIVab = 4;

	private InflaterHuffmanTree dXiKWYsjRQnTcampNCcCFJxaOhEC;

	private RZBhemojFtizJixMGLGAqfPHOzTp XTaNyyaqOAPZKkmDgOybqpUtHdSk;

	private const int ADKsWLrSslEEpIKcxTdWxKWBprtR = 12;

	private StreamManipulator JRCXwOggrgemeivPRExxfAWLiSyL;

	private bool NktFxbFdbuZIIpCkwNOCsGhTGdPCA;

	private InflaterHuffmanTree XKSgCndwuPVkmdRzInkyZzYWbyuIA;

	private int LlcDOZFNqyDRAHCCbndwFtARpdUbb;

	private int NbSlffKmhMbPthikyaJvlORILrDTA;

	private bool zsWGHTldbSYozIiwejiSIWzcbAvA;

	private OutputWindow aWsDWJOwgWltBGIrnCgJSVqHdGeP;

	private int dmVdHmjoACiCMkzBcTeaFgxnJPos;

	private int yWoFzDvJmbQLJFrEJzABppCYSRcF;

	private int cZGPfLJstOiHLjYIskzWyAfilbYk;

	private long lNsWZTpCMfiJLolqbFFEpXLtxjZV;

	private long ZYMhdvZBitGeitcUnzJFQCPgeZdZ;

	private int vPrcBiFMQxGLwdkexugOihpYKtqb;

	public int Adler
	{
		get
		{
			if (!IsNeedingDictionary)
			{
				return (int)IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Value;
			}
			return dmVdHmjoACiCMkzBcTeaFgxnJPos;
		}
	}

	public bool IsFinished => LlcDOZFNqyDRAHCCbndwFtARpdUbb == 12 && aWsDWJOwgWltBGIrnCgJSVqHdGeP.GetAvailable() == 0;

	public bool IsNeedingDictionary
	{
		get
		{
			if (LlcDOZFNqyDRAHCCbndwFtARpdUbb == 1)
			{
				goto IL_000e;
			}
			int num = 0;
			goto IL_0037;
			IL_002e:
			num = ((NbSlffKmhMbPthikyaJvlORILrDTA == 0) ? 1 : 0);
			goto IL_0037;
			IL_0037:
			bool result = (byte)num != 0;
			int num2 = 467966450;
			goto IL_0013;
			IL_0013:
			switch ((uint)(num2 ^ 0x29EB3531) % 3u)
			{
			case 2u:
				break;
			case 1u:
				goto IL_002e;
			default:
				return result;
			}
			goto IL_000e;
			IL_000e:
			num2 = 952556920;
			goto IL_0013;
		}
	}

	public bool IsNeedingInput => JRCXwOggrgemeivPRExxfAWLiSyL.IsNeedingInput;

	public int RemainingInput => JRCXwOggrgemeivPRExxfAWLiSyL.AvailableBytes;

	public long TotalIn => lNsWZTpCMfiJLolqbFFEpXLtxjZV - RemainingInput;

	public long TotalOut => ZYMhdvZBitGeitcUnzJFQCPgeZdZ;

	public Inflater()
		: this(noHeader: false)
	{
	}

	public Inflater(bool noHeader)
	{
		zsWGHTldbSYozIiwejiSIWzcbAvA = noHeader;
		IfPFmiMsiqpHWKiRMCSJeyrSLfyi = new Adler32();
		JRCXwOggrgemeivPRExxfAWLiSyL = new StreamManipulator();
		aWsDWJOwgWltBGIrnCgJSVqHdGeP = new OutputWindow();
		LlcDOZFNqyDRAHCCbndwFtARpdUbb = (noHeader ? 2 : 0);
	}

	private bool kTsqkBqwcoBtisrixuKpwDHQYxLQ()
	{
		switch (LlcDOZFNqyDRAHCCbndwFtARpdUbb)
		{
		default:
			throw new SharpZipBaseException("Inflater.Decode unknown mode");
		case 0:
			return WcUdUGRbtIoernTkgTAHKzEoyBnG();
		case 1:
			return yHrwdpfsHjIMdqRugHyaRjlCoGSU();
		case 2:
			if (!NktFxbFdbuZIIpCkwNOCsGhTGdPCA)
			{
				int num = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(3);
				if (num < 0)
				{
					return false;
				}
				JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					NktFxbFdbuZIIpCkwNOCsGhTGdPCA = true;
				}
				switch (num >> 1)
				{
				default:
					throw new SharpZipBaseException("Unknown block type " + num);
				case 0:
					JRCXwOggrgemeivPRExxfAWLiSyL.SkipToByteBoundary();
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 3;
					break;
				case 1:
					XKSgCndwuPVkmdRzInkyZzYWbyuIA = InflaterHuffmanTree.defLitLenTree;
					dXiKWYsjRQnTcampNCcCFJxaOhEC = InflaterHuffmanTree.defDistTree;
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 7;
					break;
				case 2:
					XTaNyyaqOAPZKkmDgOybqpUtHdSk = new RZBhemojFtizJixMGLGAqfPHOzTp();
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 6;
					break;
				}
				return true;
			}
			if (!zsWGHTldbSYozIiwejiSIWzcbAvA)
			{
				JRCXwOggrgemeivPRExxfAWLiSyL.SkipToByteBoundary();
				NbSlffKmhMbPthikyaJvlORILrDTA = 32;
				LlcDOZFNqyDRAHCCbndwFtARpdUbb = 11;
				return true;
			}
			LlcDOZFNqyDRAHCCbndwFtARpdUbb = 12;
			return false;
		case 3:
			vPrcBiFMQxGLwdkexugOihpYKtqb = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(16);
			if (vPrcBiFMQxGLwdkexugOihpYKtqb < 0)
			{
				return false;
			}
			JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(16);
			LlcDOZFNqyDRAHCCbndwFtARpdUbb = 4;
			goto case 4;
		case 4:
		{
			int num3 = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(16);
			if (num3 < 0)
			{
				return false;
			}
			JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(16);
			if (num3 != (vPrcBiFMQxGLwdkexugOihpYKtqb ^ 0xFFFF))
			{
				throw new SharpZipBaseException("broken uncompressed block");
			}
			LlcDOZFNqyDRAHCCbndwFtARpdUbb = 5;
			goto case 5;
		}
		case 5:
		{
			int num2 = aWsDWJOwgWltBGIrnCgJSVqHdGeP.CopyStored(JRCXwOggrgemeivPRExxfAWLiSyL, vPrcBiFMQxGLwdkexugOihpYKtqb);
			vPrcBiFMQxGLwdkexugOihpYKtqb -= num2;
			if (vPrcBiFMQxGLwdkexugOihpYKtqb == 0)
			{
				LlcDOZFNqyDRAHCCbndwFtARpdUbb = 2;
				return true;
			}
			return !JRCXwOggrgemeivPRExxfAWLiSyL.IsNeedingInput;
		}
		case 6:
			if (XTaNyyaqOAPZKkmDgOybqpUtHdSk.kTsqkBqwcoBtisrixuKpwDHQYxLQ(JRCXwOggrgemeivPRExxfAWLiSyL))
			{
				XKSgCndwuPVkmdRzInkyZzYWbyuIA = XTaNyyaqOAPZKkmDgOybqpUtHdSk.FhPxuEZniFEojjUmScQpOKqHkxDU();
				dXiKWYsjRQnTcampNCcCFJxaOhEC = XTaNyyaqOAPZKkmDgOybqpUtHdSk.NxcRJcIKKAKiosUCHetBXldXWVDG();
				LlcDOZFNqyDRAHCCbndwFtARpdUbb = 7;
				goto case 7;
			}
			return false;
		case 7:
		case 8:
		case 9:
		case 10:
			return MUWzLstjthCOYBEVgjVZYYcgFXxv();
		case 11:
			return tNrWolKTPyOOIdomiKeEphkBLaPW();
		case 12:
			return false;
		}
	}

	private bool tNrWolKTPyOOIdomiKeEphkBLaPW()
	{
		while (NbSlffKmhMbPthikyaJvlORILrDTA > 0)
		{
			int num = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(8);
			if (num >= 0)
			{
				JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(8);
				dmVdHmjoACiCMkzBcTeaFgxnJPos = (dmVdHmjoACiCMkzBcTeaFgxnJPos << 8) | num;
				NbSlffKmhMbPthikyaJvlORILrDTA -= 8;
				continue;
			}
			return false;
		}
		if ((int)IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Value != dmVdHmjoACiCMkzBcTeaFgxnJPos)
		{
			throw new SharpZipBaseException("Adler chksum doesn't match: " + (int)IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Value + " vs. " + dmVdHmjoACiCMkzBcTeaFgxnJPos);
		}
		LlcDOZFNqyDRAHCCbndwFtARpdUbb = 12;
		return false;
	}

	private bool yHrwdpfsHjIMdqRugHyaRjlCoGSU()
	{
		while (NbSlffKmhMbPthikyaJvlORILrDTA > 0)
		{
			int num = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(8);
			if (num >= 0)
			{
				JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(8);
				dmVdHmjoACiCMkzBcTeaFgxnJPos = (dmVdHmjoACiCMkzBcTeaFgxnJPos << 8) | num;
				NbSlffKmhMbPthikyaJvlORILrDTA -= 8;
				continue;
			}
			return false;
		}
		return false;
	}

	private bool WcUdUGRbtIoernTkgTAHKzEoyBnG()
	{
		int num = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(16);
		if (num >= 0)
		{
			JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(16);
			num = ((num << 8) | (num >> 8)) & 0xFFFF;
			if (num % 31 == 0)
			{
				if ((num & 0xF00) != 2048)
				{
					throw new SharpZipBaseException("Compression Method unknown");
				}
				if (((uint)num & 0x20u) != 0)
				{
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 1;
					NbSlffKmhMbPthikyaJvlORILrDTA = 32;
				}
				else
				{
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 2;
				}
				return true;
			}
			throw new SharpZipBaseException("Header checksum illegal");
		}
		return false;
	}

	private bool MUWzLstjthCOYBEVgjVZYYcgFXxv()
	{
		int num = aWsDWJOwgWltBGIrnCgJSVqHdGeP.GetFreeSpace();
		while (num >= 258)
		{
			switch (LlcDOZFNqyDRAHCCbndwFtARpdUbb)
			{
			case 7:
			{
				int symbol;
				while (((symbol = XKSgCndwuPVkmdRzInkyZzYWbyuIA.GetSymbol(JRCXwOggrgemeivPRExxfAWLiSyL)) & -256) == 0)
				{
					aWsDWJOwgWltBGIrnCgJSVqHdGeP.Write(symbol);
					if (--num < 258)
					{
						return true;
					}
				}
				if (symbol >= 257)
				{
					try
					{
						cZGPfLJstOiHLjYIskzWyAfilbYk = xpeuTfdfOoSAADhBeTrWIJCOCHaDA[symbol - 257];
						NbSlffKmhMbPthikyaJvlORILrDTA = SRPCxCgNqgPjHTOtTLlBVmUFIlcGA[symbol - 257];
					}
					catch (Exception)
					{
						throw new SharpZipBaseException("Illegal rep length code");
					}
					goto case 8;
				}
				if (symbol >= 0)
				{
					dXiKWYsjRQnTcampNCcCFJxaOhEC = null;
					XKSgCndwuPVkmdRzInkyZzYWbyuIA = null;
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 2;
					return true;
				}
				return false;
			}
			case 8:
				if (NbSlffKmhMbPthikyaJvlORILrDTA > 0)
				{
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 8;
					int num3 = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(NbSlffKmhMbPthikyaJvlORILrDTA);
					if (num3 < 0)
					{
						return false;
					}
					JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(NbSlffKmhMbPthikyaJvlORILrDTA);
					cZGPfLJstOiHLjYIskzWyAfilbYk += num3;
				}
				LlcDOZFNqyDRAHCCbndwFtARpdUbb = 9;
				goto case 9;
			case 9:
			{
				int symbol = dXiKWYsjRQnTcampNCcCFJxaOhEC.GetSymbol(JRCXwOggrgemeivPRExxfAWLiSyL);
				if (symbol >= 0)
				{
					try
					{
						yWoFzDvJmbQLJFrEJzABppCYSRcF = tRlyaUaOHuSOHMoCHBULBMLNDLQD[symbol];
						NbSlffKmhMbPthikyaJvlORILrDTA = jNmDxuUnXpCsBixVFZABfSIgorO[symbol];
					}
					catch (Exception)
					{
						throw new SharpZipBaseException("Illegal rep dist code");
					}
					goto case 10;
				}
				return false;
			}
			case 10:
				if (NbSlffKmhMbPthikyaJvlORILrDTA > 0)
				{
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 10;
					int num2 = JRCXwOggrgemeivPRExxfAWLiSyL.PeekBits(NbSlffKmhMbPthikyaJvlORILrDTA);
					if (num2 < 0)
					{
						return false;
					}
					JRCXwOggrgemeivPRExxfAWLiSyL.DropBits(NbSlffKmhMbPthikyaJvlORILrDTA);
					yWoFzDvJmbQLJFrEJzABppCYSRcF += num2;
				}
				break;
			default:
				throw new SharpZipBaseException("Inflater unknown mode");
			}
			aWsDWJOwgWltBGIrnCgJSVqHdGeP.Repeat(cZGPfLJstOiHLjYIskzWyAfilbYk, yWoFzDvJmbQLJFrEJzABppCYSRcF);
			num -= cZGPfLJstOiHLjYIskzWyAfilbYk;
			LlcDOZFNqyDRAHCCbndwFtARpdUbb = 7;
		}
		return true;
	}

	public int Inflate(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return Inflate(buffer, 0, buffer.Length);
	}

	public int Inflate(byte[] buffer, int offset, int count)
	{
		if (buffer != null)
		{
			if (count >= 0)
			{
				if (offset < 0)
				{
					throw new ArgumentOutOfRangeException("offset", "offset cannot be negative");
				}
				if (offset + count <= buffer.Length)
				{
					if (count != 0)
					{
						int num = 0;
						do
						{
							if (LlcDOZFNqyDRAHCCbndwFtARpdUbb == 11)
							{
								continue;
							}
							int num2 = aWsDWJOwgWltBGIrnCgJSVqHdGeP.CopyOutput(buffer, offset, count);
							if (num2 > 0)
							{
								IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Update(buffer, offset, num2);
								offset += num2;
								num += num2;
								ZYMhdvZBitGeitcUnzJFQCPgeZdZ += num2;
								count -= num2;
								if (count == 0)
								{
									return num;
								}
							}
						}
						while (kTsqkBqwcoBtisrixuKpwDHQYxLQ() || (aWsDWJOwgWltBGIrnCgJSVqHdGeP.GetAvailable() > 0 && LlcDOZFNqyDRAHCCbndwFtARpdUbb != 11));
						return num;
					}
					if (!IsFinished)
					{
						kTsqkBqwcoBtisrixuKpwDHQYxLQ();
					}
					return 0;
				}
				throw new ArgumentException("count exceeds buffer bounds");
			}
			throw new ArgumentOutOfRangeException("count", "count cannot be negative");
		}
		throw new ArgumentNullException("buffer");
	}

	public void Reset()
	{
		LlcDOZFNqyDRAHCCbndwFtARpdUbb = (zsWGHTldbSYozIiwejiSIWzcbAvA ? 2 : 0);
		lNsWZTpCMfiJLolqbFFEpXLtxjZV = 0L;
		ZYMhdvZBitGeitcUnzJFQCPgeZdZ = 0L;
		JRCXwOggrgemeivPRExxfAWLiSyL.Reset();
		aWsDWJOwgWltBGIrnCgJSVqHdGeP.Reset();
		XTaNyyaqOAPZKkmDgOybqpUtHdSk = null;
		XKSgCndwuPVkmdRzInkyZzYWbyuIA = null;
		dXiKWYsjRQnTcampNCcCFJxaOhEC = null;
		NktFxbFdbuZIIpCkwNOCsGhTGdPCA = false;
		IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Reset();
	}

	public void SetDictionary(byte[] buffer)
	{
		SetDictionary(buffer, 0, buffer.Length);
	}

	public void SetDictionary(byte[] buffer, int index, int count)
	{
		if (buffer != null)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count >= 0)
			{
				if (IsNeedingDictionary)
				{
					IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Update(buffer, index, count);
					if ((int)IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Value != dmVdHmjoACiCMkzBcTeaFgxnJPos)
					{
						throw new SharpZipBaseException("Wrong adler checksum");
					}
					IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Reset();
					aWsDWJOwgWltBGIrnCgJSVqHdGeP.CopyDict(buffer, index, count);
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 2;
					return;
				}
				throw new InvalidOperationException("Dictionary is not needed");
			}
			throw new ArgumentOutOfRangeException("count");
		}
		throw new ArgumentNullException("buffer");
	}

	public void SetInput(byte[] buffer)
	{
		SetInput(buffer, 0, buffer.Length);
	}

	public void SetInput(byte[] buffer, int index, int count)
	{
		JRCXwOggrgemeivPRExxfAWLiSyL.SetInput(buffer, index, count);
		lNsWZTpCMfiJLolqbFFEpXLtxjZV += count;
	}
}
