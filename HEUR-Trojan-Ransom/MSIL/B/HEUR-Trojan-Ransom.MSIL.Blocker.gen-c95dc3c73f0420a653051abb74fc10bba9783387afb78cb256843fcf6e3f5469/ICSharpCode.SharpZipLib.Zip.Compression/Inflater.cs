using System;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class Inflater
{
	private Adler32 RoDAjTuYoNhKYzgkLaPoWnqFpolw;

	private static readonly int[] yWVatOhWhctkuRaOEMYjXpFTGVyoA = new int[30]
	{
		0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
		4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
		9, 9, 10, 10, 11, 11, 12, 12, 13, 13
	};

	private static readonly int[] qnnGEhHSWRagTmvBITAagvDMMgXFA = new int[30]
	{
		1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
		33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
		1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
	};

	private static readonly int[] iBcrqERIGLgRAqsxtsabeJMRmtWc = new int[29]
	{
		3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
		15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
		67, 83, 99, 115, 131, 163, 195, 227, 258
	};

	private static readonly int[] DCLDbRtemJNRvzCLSauSSDBQWzJc = new int[29]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
		4, 4, 4, 4, 5, 5, 5, 5, 0
	};

	private const int SOUKnVXZIktvrfNaTWkOvwExBKhd = 2;

	private const int xOeRAoULQTJMFhaORVSkmjzKPgBO = 11;

	private const int RfYvDpEnaiiqAmVBCbbCExcdIlaY = 1;

	private const int GuSmqfNsrPuIiXSwAPiBrLICGKNFA = 6;

	private const int JpMlEpiVJzYeVBAcPTemMSGJnAwf = 0;

	private const int BybymirRdvKSzlzlEahQFUrriXUO = 7;

	private const int ekvhyLGWPIFwNNYzOeXdmFFrJcGT = 9;

	private const int VuyCgmBeuZulHHGQgRvXqcIALHIUA = 10;

	private const int CRtLkddSQjspdxpodoFtYiwGbMqDA = 8;

	private const int KyAGnrEGfgLmiFTQsWJQUQoVPDXr = 5;

	private const int aGHHIMupDRzLmNchTgNPQLYQQpYt = 3;

	private const int oXtIFYqghCHvjbOTVlQhdpzhhrEMb = 4;

	private InflaterHuffmanTree oLkvcbWXfxQJuTSVADRhrRGzHnTU;

	private MRDrLLWIBILNBVEdFnBrGlUQdOYp YmorjLQKGlXfAPEmfeVSHKBgFgNfb;

	private const int RQMcjaBmyIotnlHXmigrJVPGWEuH = 12;

	private StreamManipulator ICAkxrYhvVCxwTxgSFtMPIFMNodG;

	private bool EthRiYlahHkuQWvRpOJrAAeUdGWfA;

	private InflaterHuffmanTree GVEiCIUyTeOkDaKOXdDlHXZVTfyA;

	private int IUaiPypAyJprEbBfufyZPnRGIEHt;

	private int MqSdJEiylbvfjNALfoSYgdEXnQAY;

	private bool wJkCaejThAZocgvZlqmJIwDacQLpc;

	private OutputWindow rLqmoacIipiRLtiUwnbwiPvUChdR;

	private int uWXIjTVNWbJqGPRwxDzTbAasdkxT;

	private int nIapdyLToSAuZohzMamwCNJPVpvNA;

	private int nmUnnqhvnpPEBWQdneltaOgvpGTqA;

	private long cAepyoHYFQtoPHRzmCVjFYLqCbUg;

	private long SrCqLMdMcUzSeOKdoSXawZGpwzeH;

	private int iFfgIeevGWgwBEOFhwfLTSyXwbqgb;

	public int Adler
	{
		get
		{
			if (!IsNeedingDictionary)
			{
				return (int)RoDAjTuYoNhKYzgkLaPoWnqFpolw.Value;
			}
			return uWXIjTVNWbJqGPRwxDzTbAasdkxT;
		}
	}

	public bool IsFinished
	{
		get
		{
			if (IUaiPypAyJprEbBfufyZPnRGIEHt == 12)
			{
				return rLqmoacIipiRLtiUwnbwiPvUChdR.GetAvailable() == 0;
			}
			return false;
		}
	}

	public bool IsNeedingDictionary
	{
		get
		{
			if (IUaiPypAyJprEbBfufyZPnRGIEHt == 1)
			{
				return MqSdJEiylbvfjNALfoSYgdEXnQAY == 0;
			}
			return false;
		}
	}

	public bool IsNeedingInput => ICAkxrYhvVCxwTxgSFtMPIFMNodG.IsNeedingInput;

	public int RemainingInput => ICAkxrYhvVCxwTxgSFtMPIFMNodG.AvailableBytes;

	public long TotalIn => cAepyoHYFQtoPHRzmCVjFYLqCbUg - RemainingInput;

	public long TotalOut => SrCqLMdMcUzSeOKdoSXawZGpwzeH;

	public Inflater()
		: this(noHeader: false)
	{
	}

	public Inflater(bool noHeader)
	{
		wJkCaejThAZocgvZlqmJIwDacQLpc = noHeader;
		RoDAjTuYoNhKYzgkLaPoWnqFpolw = new Adler32();
		ICAkxrYhvVCxwTxgSFtMPIFMNodG = new StreamManipulator();
		rLqmoacIipiRLtiUwnbwiPvUChdR = new OutputWindow();
		IUaiPypAyJprEbBfufyZPnRGIEHt = (noHeader ? 2 : 0);
	}

	private bool zbaWQsUFePKHcHJPiERAQKKLzQEQ()
	{
		switch (IUaiPypAyJprEbBfufyZPnRGIEHt)
		{
		default:
			throw new SharpZipBaseException("Inflater.Decode unknown mode");
		case 0:
			return VPYsNrbQdvqWdOFobBCwGgwlKVmuA();
		case 1:
			return nNpJAYHROAggvRdTjxgTlcyBBtTr();
		case 2:
			if (!EthRiYlahHkuQWvRpOJrAAeUdGWfA)
			{
				int num = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(3);
				if (num >= 0)
				{
					ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(3);
					if (((uint)num & (true ? 1u : 0u)) != 0)
					{
						EthRiYlahHkuQWvRpOJrAAeUdGWfA = true;
					}
					switch (num >> 1)
					{
					default:
						throw new SharpZipBaseException("Unknown block type " + num);
					case 0:
						ICAkxrYhvVCxwTxgSFtMPIFMNodG.SkipToByteBoundary();
						IUaiPypAyJprEbBfufyZPnRGIEHt = 3;
						break;
					case 1:
						GVEiCIUyTeOkDaKOXdDlHXZVTfyA = InflaterHuffmanTree.defLitLenTree;
						oLkvcbWXfxQJuTSVADRhrRGzHnTU = InflaterHuffmanTree.defDistTree;
						IUaiPypAyJprEbBfufyZPnRGIEHt = 7;
						break;
					case 2:
						YmorjLQKGlXfAPEmfeVSHKBgFgNfb = new MRDrLLWIBILNBVEdFnBrGlUQdOYp();
						IUaiPypAyJprEbBfufyZPnRGIEHt = 6;
						break;
					}
					return true;
				}
				return false;
			}
			if (!wJkCaejThAZocgvZlqmJIwDacQLpc)
			{
				ICAkxrYhvVCxwTxgSFtMPIFMNodG.SkipToByteBoundary();
				MqSdJEiylbvfjNALfoSYgdEXnQAY = 32;
				IUaiPypAyJprEbBfufyZPnRGIEHt = 11;
				return true;
			}
			IUaiPypAyJprEbBfufyZPnRGIEHt = 12;
			return false;
		case 3:
			iFfgIeevGWgwBEOFhwfLTSyXwbqgb = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(16);
			if (iFfgIeevGWgwBEOFhwfLTSyXwbqgb >= 0)
			{
				ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(16);
				IUaiPypAyJprEbBfufyZPnRGIEHt = 4;
				goto case 4;
			}
			return false;
		case 4:
		{
			int num3 = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(16);
			if (num3 < 0)
			{
				return false;
			}
			ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(16);
			if (num3 != (iFfgIeevGWgwBEOFhwfLTSyXwbqgb ^ 0xFFFF))
			{
				throw new SharpZipBaseException("broken uncompressed block");
			}
			IUaiPypAyJprEbBfufyZPnRGIEHt = 5;
			goto case 5;
		}
		case 5:
		{
			int num2 = rLqmoacIipiRLtiUwnbwiPvUChdR.CopyStored(ICAkxrYhvVCxwTxgSFtMPIFMNodG, iFfgIeevGWgwBEOFhwfLTSyXwbqgb);
			iFfgIeevGWgwBEOFhwfLTSyXwbqgb -= num2;
			if (iFfgIeevGWgwBEOFhwfLTSyXwbqgb == 0)
			{
				IUaiPypAyJprEbBfufyZPnRGIEHt = 2;
				return true;
			}
			return !ICAkxrYhvVCxwTxgSFtMPIFMNodG.IsNeedingInput;
		}
		case 6:
			if (YmorjLQKGlXfAPEmfeVSHKBgFgNfb.zbaWQsUFePKHcHJPiERAQKKLzQEQ(ICAkxrYhvVCxwTxgSFtMPIFMNodG))
			{
				GVEiCIUyTeOkDaKOXdDlHXZVTfyA = YmorjLQKGlXfAPEmfeVSHKBgFgNfb.QtNMfvzDosYspEBuPLyIgjgMWGSf();
				oLkvcbWXfxQJuTSVADRhrRGzHnTU = YmorjLQKGlXfAPEmfeVSHKBgFgNfb.ORqzdXygKbMmgZJdIoxijpyEphYL();
				IUaiPypAyJprEbBfufyZPnRGIEHt = 7;
				goto case 7;
			}
			return false;
		case 7:
		case 8:
		case 9:
		case 10:
			return BAGzWVTGrWcuUulyfKTsajlzedmj();
		case 11:
			return uadMzUmXuJymOIBMhvndRpPKHPYC();
		case 12:
			return false;
		}
	}

	private bool uadMzUmXuJymOIBMhvndRpPKHPYC()
	{
		while (MqSdJEiylbvfjNALfoSYgdEXnQAY > 0)
		{
			int num = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(8);
			if (num >= 0)
			{
				ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(8);
				uWXIjTVNWbJqGPRwxDzTbAasdkxT = (uWXIjTVNWbJqGPRwxDzTbAasdkxT << 8) | num;
				MqSdJEiylbvfjNALfoSYgdEXnQAY -= 8;
				continue;
			}
			return false;
		}
		if ((int)RoDAjTuYoNhKYzgkLaPoWnqFpolw.Value != uWXIjTVNWbJqGPRwxDzTbAasdkxT)
		{
			throw new SharpZipBaseException("Adler chksum doesn't match: " + (int)RoDAjTuYoNhKYzgkLaPoWnqFpolw.Value + " vs. " + uWXIjTVNWbJqGPRwxDzTbAasdkxT);
		}
		IUaiPypAyJprEbBfufyZPnRGIEHt = 12;
		return false;
	}

	private bool nNpJAYHROAggvRdTjxgTlcyBBtTr()
	{
		while (true)
		{
			if (MqSdJEiylbvfjNALfoSYgdEXnQAY > 0)
			{
				int num = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(8);
				if (num < 0)
				{
					break;
				}
				ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(8);
				uWXIjTVNWbJqGPRwxDzTbAasdkxT = (uWXIjTVNWbJqGPRwxDzTbAasdkxT << 8) | num;
				MqSdJEiylbvfjNALfoSYgdEXnQAY -= 8;
				continue;
			}
			return false;
		}
		return false;
	}

	private bool VPYsNrbQdvqWdOFobBCwGgwlKVmuA()
	{
		int num = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(16);
		if (num < 0)
		{
			return false;
		}
		ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(16);
		num = ((num << 8) | (num >> 8)) & 0xFFFF;
		if (num % 31 == 0)
		{
			if ((num & 0xF00) != 2048)
			{
				throw new SharpZipBaseException("Compression Method unknown");
			}
			if (((uint)num & 0x20u) != 0)
			{
				IUaiPypAyJprEbBfufyZPnRGIEHt = 1;
				MqSdJEiylbvfjNALfoSYgdEXnQAY = 32;
			}
			else
			{
				IUaiPypAyJprEbBfufyZPnRGIEHt = 2;
			}
			return true;
		}
		throw new SharpZipBaseException("Header checksum illegal");
	}

	private bool BAGzWVTGrWcuUulyfKTsajlzedmj()
	{
		int num = rLqmoacIipiRLtiUwnbwiPvUChdR.GetFreeSpace();
		while (num >= 258)
		{
			switch (IUaiPypAyJprEbBfufyZPnRGIEHt)
			{
			case 7:
			{
				int symbol;
				while (((symbol = GVEiCIUyTeOkDaKOXdDlHXZVTfyA.GetSymbol(ICAkxrYhvVCxwTxgSFtMPIFMNodG)) & -256) == 0)
				{
					rLqmoacIipiRLtiUwnbwiPvUChdR.Write(symbol);
					if (--num < 258)
					{
						return true;
					}
				}
				if (symbol >= 257)
				{
					try
					{
						nmUnnqhvnpPEBWQdneltaOgvpGTqA = iBcrqERIGLgRAqsxtsabeJMRmtWc[symbol - 257];
						MqSdJEiylbvfjNALfoSYgdEXnQAY = DCLDbRtemJNRvzCLSauSSDBQWzJc[symbol - 257];
					}
					catch (Exception)
					{
						throw new SharpZipBaseException("Illegal rep length code");
					}
					goto case 8;
				}
				if (symbol >= 0)
				{
					oLkvcbWXfxQJuTSVADRhrRGzHnTU = null;
					GVEiCIUyTeOkDaKOXdDlHXZVTfyA = null;
					IUaiPypAyJprEbBfufyZPnRGIEHt = 2;
					return true;
				}
				return false;
			}
			case 8:
				if (MqSdJEiylbvfjNALfoSYgdEXnQAY > 0)
				{
					IUaiPypAyJprEbBfufyZPnRGIEHt = 8;
					int num3 = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(MqSdJEiylbvfjNALfoSYgdEXnQAY);
					if (num3 < 0)
					{
						return false;
					}
					ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(MqSdJEiylbvfjNALfoSYgdEXnQAY);
					nmUnnqhvnpPEBWQdneltaOgvpGTqA += num3;
				}
				IUaiPypAyJprEbBfufyZPnRGIEHt = 9;
				goto case 9;
			case 9:
			{
				int symbol = oLkvcbWXfxQJuTSVADRhrRGzHnTU.GetSymbol(ICAkxrYhvVCxwTxgSFtMPIFMNodG);
				if (symbol >= 0)
				{
					try
					{
						nIapdyLToSAuZohzMamwCNJPVpvNA = qnnGEhHSWRagTmvBITAagvDMMgXFA[symbol];
						MqSdJEiylbvfjNALfoSYgdEXnQAY = yWVatOhWhctkuRaOEMYjXpFTGVyoA[symbol];
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
				if (MqSdJEiylbvfjNALfoSYgdEXnQAY > 0)
				{
					IUaiPypAyJprEbBfufyZPnRGIEHt = 10;
					int num2 = ICAkxrYhvVCxwTxgSFtMPIFMNodG.PeekBits(MqSdJEiylbvfjNALfoSYgdEXnQAY);
					if (num2 < 0)
					{
						return false;
					}
					ICAkxrYhvVCxwTxgSFtMPIFMNodG.DropBits(MqSdJEiylbvfjNALfoSYgdEXnQAY);
					nIapdyLToSAuZohzMamwCNJPVpvNA += num2;
				}
				break;
			default:
				throw new SharpZipBaseException("Inflater unknown mode");
			}
			rLqmoacIipiRLtiUwnbwiPvUChdR.Repeat(nmUnnqhvnpPEBWQdneltaOgvpGTqA, nIapdyLToSAuZohzMamwCNJPVpvNA);
			num -= nmUnnqhvnpPEBWQdneltaOgvpGTqA;
			IUaiPypAyJprEbBfufyZPnRGIEHt = 7;
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
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "count cannot be negative");
		}
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
					if (IUaiPypAyJprEbBfufyZPnRGIEHt == 11)
					{
						continue;
					}
					int num2 = rLqmoacIipiRLtiUwnbwiPvUChdR.CopyOutput(buffer, offset, count);
					if (num2 > 0)
					{
						RoDAjTuYoNhKYzgkLaPoWnqFpolw.Update(buffer, offset, num2);
						offset += num2;
						num += num2;
						SrCqLMdMcUzSeOKdoSXawZGpwzeH += num2;
						count -= num2;
						if (count == 0)
						{
							return num;
						}
					}
				}
				while (zbaWQsUFePKHcHJPiERAQKKLzQEQ() || (rLqmoacIipiRLtiUwnbwiPvUChdR.GetAvailable() > 0 && IUaiPypAyJprEbBfufyZPnRGIEHt != 11));
				return num;
			}
			if (!IsFinished)
			{
				zbaWQsUFePKHcHJPiERAQKKLzQEQ();
			}
			return 0;
		}
		throw new ArgumentException("count exceeds buffer bounds");
	}

	public void Reset()
	{
		IUaiPypAyJprEbBfufyZPnRGIEHt = (wJkCaejThAZocgvZlqmJIwDacQLpc ? 2 : 0);
		cAepyoHYFQtoPHRzmCVjFYLqCbUg = 0L;
		SrCqLMdMcUzSeOKdoSXawZGpwzeH = 0L;
		ICAkxrYhvVCxwTxgSFtMPIFMNodG.Reset();
		rLqmoacIipiRLtiUwnbwiPvUChdR.Reset();
		YmorjLQKGlXfAPEmfeVSHKBgFgNfb = null;
		GVEiCIUyTeOkDaKOXdDlHXZVTfyA = null;
		oLkvcbWXfxQJuTSVADRhrRGzHnTU = null;
		EthRiYlahHkuQWvRpOJrAAeUdGWfA = false;
		RoDAjTuYoNhKYzgkLaPoWnqFpolw.Reset();
	}

	public void SetDictionary(byte[] buffer)
	{
		SetDictionary(buffer, 0, buffer.Length);
	}

	public void SetDictionary(byte[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (!IsNeedingDictionary)
		{
			throw new InvalidOperationException("Dictionary is not needed");
		}
		RoDAjTuYoNhKYzgkLaPoWnqFpolw.Update(buffer, index, count);
		if ((int)RoDAjTuYoNhKYzgkLaPoWnqFpolw.Value != uWXIjTVNWbJqGPRwxDzTbAasdkxT)
		{
			throw new SharpZipBaseException("Wrong adler checksum");
		}
		RoDAjTuYoNhKYzgkLaPoWnqFpolw.Reset();
		rLqmoacIipiRLtiUwnbwiPvUChdR.CopyDict(buffer, index, count);
		IUaiPypAyJprEbBfufyZPnRGIEHt = 2;
	}

	public void SetInput(byte[] buffer)
	{
		SetInput(buffer, 0, buffer.Length);
	}

	public void SetInput(byte[] buffer, int index, int count)
	{
		ICAkxrYhvVCxwTxgSFtMPIFMNodG.SetInput(buffer, index, count);
		cAepyoHYFQtoPHRzmCVjFYLqCbUg += count;
	}
}
