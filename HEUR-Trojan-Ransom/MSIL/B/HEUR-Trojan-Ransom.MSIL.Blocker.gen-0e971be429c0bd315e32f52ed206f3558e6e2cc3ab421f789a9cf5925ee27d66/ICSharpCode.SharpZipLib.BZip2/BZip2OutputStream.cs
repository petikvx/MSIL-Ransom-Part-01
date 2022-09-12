using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.BZip2;

public class BZip2OutputStream : Stream
{
	private struct mgKUUcUmNOyeMfaegDHZcNWBVU
	{
		public int MJKWhUrNwzNBdVNFDjpgJckseGKX;

		public int yctsBImRvXVwxzGHEoZUtliKoFTj;

		public int BnEYqwTVzmRLybjFdhAWIHzXOkWL;
	}

	private int FhTUGTxLwXYkCxOGLhpGXVLVbPyu;

	private Stream CupzxnnSjFHrQutmtRwIqUtsocQw;

	private byte[] gtXxhAZCXMTVJSCDsGpmRNOcTfhw;

	private uint KRSJCgyfuVfyecPkMOMWmQVAIlebA;

	private bool mBzRCENAtMtxcALUkcnzuOROWKpq;

	private int fuwyPOgeStYLqYkQScYQnHYocDyAA;

	private int zgyYYWmKacCJPhHaOQHCwZGKHJTJ;

	private int CoeDrwONOFolugwTFEwqBRmYnbbk;

	private int HfXPSYhRVMCjpLxjLvOmRcDljZBD;

	private const int FTcFkCMNubBDyeHpQiedmNxgltBYA = -2097153;

	private uint VNhljmnXTXpmYkgdmVKjHjFdFwlP;

	private int LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;

	private const int DfcuhuKgLdzJGQqrcRqPMLgDIZfM = 10;

	private bool XyffHmCkXOXpOKiqDsXnedNBvSwtA;

	private bool EMsRawGFNlIwWTlWBKJktLXccLNW;

	private int[] OtlpAXreYGOsVepcifbxjzwlDoQn;

	private const int oRWKnEvYxMLgAopfSGQVFTmkafLGb = 15;

	private readonly int[] LslZVbLrgPaPigPaUiWlSpSvRZgR;

	private bool[] BuHJgZyyImgmYpHohmGriNggjsfP;

	private bool tTMSyxFlQfXCQfFhbrPnqimGRjzK;

	private int pqoHwWUCEGWPpyGzfvhLUfikiJXO;

	private const int oJqreEqHrQWNXSLeNAmgJyCzYHIu = 0;

	private IChecksum AYnfmpQafGZCtChcfRpAksXHVLBu;

	private int[] SgefvaHJZGGdQiXLbKgFznRJhGlzA;

	private int SdtBeDtYjxebYzTfCHUCezmAKOIJ;

	private int wWdHPAghuZOHyFFiYAwhypiHAJWd;

	private int XptaChznMCxhfnTGGnfDUeENszkq;

	private int vXrneFWezTwWWxshcqGMPNMrzeKM;

	private const int oDJhPSyYJoglmrHNriIxAsCpNANmA = 1000;

	private int[] cREzpInxYydwtyrckuZKusPtVVdg;

	private int sgqkxVYEgiRtLSCSdCLLSyFPlvEr;

	private char[] JSeGmkCiGCJzBgFYeeFcmGTbsRIIA;

	private char[] OmPcOtIJWJoQwOSIMOCXSscqbbOOA;

	private char[] LlbQaIxdfNtnXkZZqWcKQSoBNwQF;

	private const int bdorVtVkjueYvUsgxYbIwuwwmhDj = 2097152;

	private const int HfxQsEslSwrzHqCJNkJrpxGxTHKt = 20;

	private short[] vfgPXfrCNGhowsMDBYiijRhoPAon;

	private char[] KKGoLDHsuAdslfqfQAeuTppGpsJTA;

	private int HtSUmgEGzvhsRWBdCVBuCrarkKnk;

	private int AZSFYcLGybrUHEEfNGaVJzsvFAxw;

	private int uYRvzfFIsTjmVyhKZykltnopBadHA;

	private int[] AsmSSbXNzzTJLdtedJPrkYUGJCgx;

	public int BytesWritten => HfXPSYhRVMCjpLxjLvOmRcDljZBD;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => CupzxnnSjFHrQutmtRwIqUtsocQw.CanWrite;

	public bool IsStreamOwner
	{
		get
		{
			return tTMSyxFlQfXCQfFhbrPnqimGRjzK;
		}
		set
		{
			tTMSyxFlQfXCQfFhbrPnqimGRjzK = value;
		}
	}

	public override long Length => CupzxnnSjFHrQutmtRwIqUtsocQw.Length;

	public override long Position
	{
		get
		{
			return CupzxnnSjFHrQutmtRwIqUtsocQw.Position;
		}
		set
		{
			throw new NotSupportedException("BZip2OutputStream position cannot be set");
		}
	}

	public BZip2OutputStream(Stream stream)
		: this(stream, 9)
	{
	}

	public BZip2OutputStream(Stream stream, int blockSize)
	{
		LslZVbLrgPaPigPaUiWlSpSvRZgR = new int[14]
		{
			1, 4, 13, 40, 121, 364, 1093, 3280, 9841, 29524,
			88573, 265720, 797161, 2391484
		};
		tTMSyxFlQfXCQfFhbrPnqimGRjzK = true;
		AYnfmpQafGZCtChcfRpAksXHVLBu = new StrangeCRC();
		BuHJgZyyImgmYpHohmGriNggjsfP = new bool[256];
		LlbQaIxdfNtnXkZZqWcKQSoBNwQF = new char[256];
		KKGoLDHsuAdslfqfQAeuTppGpsJTA = new char[256];
		JSeGmkCiGCJzBgFYeeFcmGTbsRIIA = new char[18002];
		OmPcOtIJWJoQwOSIMOCXSscqbbOOA = new char[18002];
		SgefvaHJZGGdQiXLbKgFznRJhGlzA = new int[258];
		LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = -1;
		jmeLBDDiHbrLuHZOkKrnzCodawVbA(stream);
		AZSFYcLGybrUHEEfNGaVJzsvFAxw = 50;
		if (blockSize > 9)
		{
			blockSize = 9;
		}
		if (blockSize < 1)
		{
			blockSize = 1;
		}
		fuwyPOgeStYLqYkQScYQnHYocDyAA = blockSize;
		eCgRPaQLjiEGkEMxgyZXmSUikCnb();
		EgsSbMJlpoeuwULFbWfLfdPUwSrN();
		eqUGBVElyrrEWwxgNprZKJKqRYvBA();
	}

	private void eCgRPaQLjiEGkEMxgyZXmSUikCnb()
	{
		int num = 100000 * fuwyPOgeStYLqYkQScYQnHYocDyAA;
		gtXxhAZCXMTVJSCDsGpmRNOcTfhw = new byte[num + 1 + 20];
		cREzpInxYydwtyrckuZKusPtVVdg = new int[num + 20];
		AsmSSbXNzzTJLdtedJPrkYUGJCgx = new int[num];
		OtlpAXreYGOsVepcifbxjzwlDoQn = new int[65537];
		if (gtXxhAZCXMTVJSCDsGpmRNOcTfhw == null || cREzpInxYydwtyrckuZKusPtVVdg == null || AsmSSbXNzzTJLdtedJPrkYUGJCgx == null)
		{
		}
		vfgPXfrCNGhowsMDBYiijRhoPAon = new short[2 * num];
	}

	private void QLvycDPiPUPbJruqnBjsfqtbCFhD()
	{
		while (CoeDrwONOFolugwTFEwqBRmYnbbk > 0)
		{
			int num = zgyYYWmKacCJPhHaOQHCwZGKHJTJ >> 24;
			CupzxnnSjFHrQutmtRwIqUtsocQw.WriteByte((byte)num);
			zgyYYWmKacCJPhHaOQHCwZGKHJTJ <<= 8;
			CoeDrwONOFolugwTFEwqBRmYnbbk -= 8;
			HfXPSYhRVMCjpLxjLvOmRcDljZBD++;
		}
	}

	private void oDlAtsadrWYwjhenOhpHZAZeDwKdA(int int_0)
	{
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(8, (int_0 >> 24) & 0xFF);
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(8, (int_0 >> 16) & 0xFF);
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(8, (int_0 >> 8) & 0xFF);
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(8, int_0 & 0xFF);
	}

	private void HjGvtqSkduiTcdNTSjbFFcTsfmJgA(int numBits, int int_0)
	{
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(numBits, int_0);
	}

	private void QewcHerdyjcrCPPhlxHVsNzTAwvp(int int_0)
	{
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(8, int_0);
	}

	private void jmeLBDDiHbrLuHZOkKrnzCodawVbA(Stream stream)
	{
		CupzxnnSjFHrQutmtRwIqUtsocQw = stream;
		CoeDrwONOFolugwTFEwqBRmYnbbk = 0;
		zgyYYWmKacCJPhHaOQHCwZGKHJTJ = 0;
		HfXPSYhRVMCjpLxjLvOmRcDljZBD = 0;
	}

	private void hxtFHgzRWpjOMPjoxATDJnnDYqXnA(int int_0, int int_1)
	{
		while (CoeDrwONOFolugwTFEwqBRmYnbbk >= 8)
		{
			int num = zgyYYWmKacCJPhHaOQHCwZGKHJTJ >> 24;
			CupzxnnSjFHrQutmtRwIqUtsocQw.WriteByte((byte)num);
			zgyYYWmKacCJPhHaOQHCwZGKHJTJ <<= 8;
			CoeDrwONOFolugwTFEwqBRmYnbbk -= 8;
			HfXPSYhRVMCjpLxjLvOmRcDljZBD++;
		}
		zgyYYWmKacCJPhHaOQHCwZGKHJTJ |= int_1 << 32 - CoeDrwONOFolugwTFEwqBRmYnbbk - int_0;
		CoeDrwONOFolugwTFEwqBRmYnbbk += int_0;
	}

	public override void Close()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			base.Dispose(disposing);
			if (!XyffHmCkXOXpOKiqDsXnedNBvSwtA)
			{
				XyffHmCkXOXpOKiqDsXnedNBvSwtA = true;
				if (sgqkxVYEgiRtLSCSdCLLSyFPlvEr > 0)
				{
					lCPUFlWTVajHmPOnOqklpyHXWHSA();
				}
				LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = -1;
				jEvKacTVbHqNqPskyiOHWYkOaXXK();
				yqFoOjTghnxeWLTsZnJRDXJDBycs();
				Flush();
			}
		}
		finally
		{
			if (disposing && IsStreamOwner)
			{
				CupzxnnSjFHrQutmtRwIqUtsocQw.Close();
			}
		}
	}

	private void zWTaFZhcPdCqsXvTpNHjEFWvnyyV()
	{
		uYRvzfFIsTjmVyhKZykltnopBadHA = AZSFYcLGybrUHEEfNGaVJzsvFAxw * pqoHwWUCEGWPpyGzfvhLUfikiJXO;
		HtSUmgEGzvhsRWBdCVBuCrarkKnk = 0;
		mBzRCENAtMtxcALUkcnzuOROWKpq = false;
		EMsRawGFNlIwWTlWBKJktLXccLNW = true;
		AJUpCKQiGZpVUYrLxHrELdIKsBWN();
		if (HtSUmgEGzvhsRWBdCVBuCrarkKnk > uYRvzfFIsTjmVyhKZykltnopBadHA && EMsRawGFNlIwWTlWBKJktLXccLNW)
		{
			HNfGeEKlfVmBYPJPLPJLwAIkzaFU();
			HtSUmgEGzvhsRWBdCVBuCrarkKnk = 0;
			uYRvzfFIsTjmVyhKZykltnopBadHA = 0;
			mBzRCENAtMtxcALUkcnzuOROWKpq = true;
			EMsRawGFNlIwWTlWBKJktLXccLNW = false;
			AJUpCKQiGZpVUYrLxHrELdIKsBWN();
		}
		vXrneFWezTwWWxshcqGMPNMrzeKM = -1;
		for (int i = 0; i <= pqoHwWUCEGWPpyGzfvhLUfikiJXO; i++)
		{
			if (AsmSSbXNzzTJLdtedJPrkYUGJCgx[i] == 0)
			{
				vXrneFWezTwWWxshcqGMPNMrzeKM = i;
				break;
			}
		}
		if (vXrneFWezTwWWxshcqGMPNMrzeKM == -1)
		{
			qYDFxoGBkDrPVABXCxlWFGuLccDaA();
		}
	}

	private void jEvKacTVbHqNqPskyiOHWYkOaXXK()
	{
		if (pqoHwWUCEGWPpyGzfvhLUfikiJXO >= 0)
		{
			KRSJCgyfuVfyecPkMOMWmQVAIlebA = (uint)AYnfmpQafGZCtChcfRpAksXHVLBu.Value;
			VNhljmnXTXpmYkgdmVKjHjFdFwlP = (VNhljmnXTXpmYkgdmVKjHjFdFwlP << 1) | (VNhljmnXTXpmYkgdmVKjHjFdFwlP >> 31);
			VNhljmnXTXpmYkgdmVKjHjFdFwlP ^= KRSJCgyfuVfyecPkMOMWmQVAIlebA;
			zWTaFZhcPdCqsXvTpNHjEFWvnyyV();
			QewcHerdyjcrCPPhlxHVsNzTAwvp(49);
			QewcHerdyjcrCPPhlxHVsNzTAwvp(65);
			QewcHerdyjcrCPPhlxHVsNzTAwvp(89);
			QewcHerdyjcrCPPhlxHVsNzTAwvp(38);
			QewcHerdyjcrCPPhlxHVsNzTAwvp(83);
			QewcHerdyjcrCPPhlxHVsNzTAwvp(89);
			oDlAtsadrWYwjhenOhpHZAZeDwKdA((int)KRSJCgyfuVfyecPkMOMWmQVAIlebA);
			if (!mBzRCENAtMtxcALUkcnzuOROWKpq)
			{
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 0);
			}
			else
			{
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 1);
				SdtBeDtYjxebYzTfCHUCezmAKOIJ++;
			}
			FyXwhefDdjPGFMKsoUoVGZnmuXte();
		}
	}

	private void yqFoOjTghnxeWLTsZnJRDXJDBycs()
	{
		QewcHerdyjcrCPPhlxHVsNzTAwvp(23);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(114);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(69);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(56);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(80);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(144);
		oDlAtsadrWYwjhenOhpHZAZeDwKdA((int)VNhljmnXTXpmYkgdmVKjHjFdFwlP);
		QLvycDPiPUPbJruqnBjsfqtbCFhD();
	}

	~BZip2OutputStream()
	{
		Dispose(disposing: false);
	}

	public override void Flush()
	{
		CupzxnnSjFHrQutmtRwIqUtsocQw.Flush();
	}

	private bool gBrKmyqjibmYXhcsUmJSpbZmEApH(int int_0, int int_1)
	{
		byte b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
		byte b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
		if (b == b2)
		{
			int_0++;
			int_1++;
			b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
			b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
			if (b == b2)
			{
				int_0++;
				int_1++;
				b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
				b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
				if (b == b2)
				{
					int_0++;
					int_1++;
					b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
					b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
					if (b != b2)
					{
						return b > b2;
					}
					int_0++;
					int_1++;
					b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
					b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
					if (b == b2)
					{
						int_0++;
						int_1++;
						b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
						b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
						if (b == b2)
						{
							int_0++;
							int_1++;
							int num = pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1;
							int num2;
							int num3;
							while (true)
							{
								b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
								b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
								if (b == b2)
								{
									num2 = cREzpInxYydwtyrckuZKusPtVVdg[int_0];
									num3 = cREzpInxYydwtyrckuZKusPtVVdg[int_1];
									if (num2 != num3)
									{
										break;
									}
									int_0++;
									int_1++;
									b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
									b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
									if (b == b2)
									{
										num2 = cREzpInxYydwtyrckuZKusPtVVdg[int_0];
										num3 = cREzpInxYydwtyrckuZKusPtVVdg[int_1];
										if (num2 == num3)
										{
											int_0++;
											int_1++;
											b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
											b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
											if (b == b2)
											{
												num2 = cREzpInxYydwtyrckuZKusPtVVdg[int_0];
												num3 = cREzpInxYydwtyrckuZKusPtVVdg[int_1];
												if (num2 == num3)
												{
													int_0++;
													int_1++;
													b = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_0 + 1];
													b2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[int_1 + 1];
													if (b == b2)
													{
														num2 = cREzpInxYydwtyrckuZKusPtVVdg[int_0];
														num3 = cREzpInxYydwtyrckuZKusPtVVdg[int_1];
														if (num2 == num3)
														{
															int_0++;
															int_1++;
															if (int_0 > pqoHwWUCEGWPpyGzfvhLUfikiJXO)
															{
																int_0 -= pqoHwWUCEGWPpyGzfvhLUfikiJXO;
																int_0--;
															}
															if (int_1 > pqoHwWUCEGWPpyGzfvhLUfikiJXO)
															{
																int_1 -= pqoHwWUCEGWPpyGzfvhLUfikiJXO;
																int_1--;
															}
															num -= 4;
															HtSUmgEGzvhsRWBdCVBuCrarkKnk++;
															if (num < 0)
															{
																return false;
															}
															continue;
														}
														return num2 > num3;
													}
													return b > b2;
												}
												return num2 > num3;
											}
											return b > b2;
										}
										return num2 > num3;
									}
									return b > b2;
								}
								return b > b2;
							}
							return num2 > num3;
						}
						return b > b2;
					}
					return b > b2;
				}
				return b > b2;
			}
			return b > b2;
		}
		return b > b2;
	}

	private void DXrTQyfUKhZGwNmCRxlhppqQFISj()
	{
		char[] array = new char[256];
		oOHhxgkRAltnEdJftRCVfNAykMQB();
		int num = wWdHPAghuZOHyFFiYAwhypiHAJWd + 1;
		for (int i = 0; i <= num; i++)
		{
			SgefvaHJZGGdQiXLbKgFznRJhGlzA[i] = 0;
		}
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < wWdHPAghuZOHyFFiYAwhypiHAJWd; i++)
		{
			array[i] = (char)i;
		}
		for (int i = 0; i <= pqoHwWUCEGWPpyGzfvhLUfikiJXO; i++)
		{
			char c = KKGoLDHsuAdslfqfQAeuTppGpsJTA[gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[i]]];
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
			if (num4 != 0)
			{
				if (num3 > 0)
				{
					num3--;
					while (true)
					{
						int num5 = num3 % 2;
						int num6 = num5;
						if (num6 != 0)
						{
							if (num6 == 1)
							{
								vfgPXfrCNGhowsMDBYiijRhoPAon[num2] = 1;
								num2++;
								SgefvaHJZGGdQiXLbKgFznRJhGlzA[1]++;
							}
						}
						else
						{
							vfgPXfrCNGhowsMDBYiijRhoPAon[num2] = 0;
							num2++;
							SgefvaHJZGGdQiXLbKgFznRJhGlzA[0]++;
						}
						if (num3 < 2)
						{
							break;
						}
						num3 = (num3 - 2) / 2;
					}
					num3 = 0;
				}
				vfgPXfrCNGhowsMDBYiijRhoPAon[num2] = (short)(num4 + 1);
				num2++;
				SgefvaHJZGGdQiXLbKgFznRJhGlzA[num4 + 1]++;
			}
			else
			{
				num3++;
			}
		}
		if (num3 > 0)
		{
			num3--;
			while (true)
			{
				int num7 = num3 % 2;
				int num8 = num7;
				if (num8 != 0)
				{
					if (num8 == 1)
					{
						vfgPXfrCNGhowsMDBYiijRhoPAon[num2] = 1;
						num2++;
						SgefvaHJZGGdQiXLbKgFznRJhGlzA[1]++;
					}
				}
				else
				{
					vfgPXfrCNGhowsMDBYiijRhoPAon[num2] = 0;
					num2++;
					SgefvaHJZGGdQiXLbKgFznRJhGlzA[0]++;
				}
				if (num3 < 2)
				{
					break;
				}
				num3 = (num3 - 2) / 2;
			}
		}
		vfgPXfrCNGhowsMDBYiijRhoPAon[num2] = (short)num;
		num2++;
		SgefvaHJZGGdQiXLbKgFznRJhGlzA[num]++;
		XptaChznMCxhfnTGGnfDUeENszkq = num2;
	}

	private static void VfnJXMdvLloacHpCSzglZcdUvdET(int[] code, char[] length, int minLen, int maxLen, int alphaSize)
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

	private static void KeLlhyvEQWvqvkSbRPcCDkYKkKiG(char[] char_0, int[] freq, int alphaSize, int maxLen)
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
				num2++;
				array[num2] = j;
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
				qYDFxoGBkDrPVABXCxlWFGuLccDaA();
			}
			while (num2 > 1)
			{
				int num5 = array[1];
				array[1] = array[num2];
				num2--;
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
				array[1] = array[num2];
				num2--;
				num6 = 1;
				num7 = array[1];
				while (true)
				{
					int num10 = num6 << 1;
					if (num10 > num2)
					{
						break;
					}
					if (num10 < num2 && array2[array[num10 + 1]] < array2[array[num10]])
					{
						num10++;
					}
					if (array2[num7] < array2[array[num10]])
					{
						break;
					}
					array[num6] = array[num10];
					num6 = num10;
				}
				array[num6] = num7;
				num++;
				array3[num5] = (array3[num9] = num);
				array2[num] = (int)((array2[num5] & 0xFFFFFF00L) + (array2[num9] & 0xFFFFFF00L)) | (1 + (((array2[num5] & 0xFF) > (array2[num9] & 0xFF)) ? (array2[num5] & 0xFF) : (array2[num9] & 0xFF)));
				array3[num] = -1;
				num2++;
				array[num2] = num;
				num6 = num2;
				num7 = array[num6];
				while (array2[num7] < array2[array[num6 >> 1]])
				{
					array[num6] = array[num6 >> 1];
					num6 >>= 1;
				}
				array[num6] = num7;
			}
			if (num >= 516)
			{
				qYDFxoGBkDrPVABXCxlWFGuLccDaA();
			}
			bool flag = false;
			for (int k = 1; k <= alphaSize; k++)
			{
				int num11 = 0;
				int num12 = k;
				while (array3[num12] >= 0)
				{
					num12 = array3[num12];
					num11++;
				}
				char_0[k - 1] = (char)num11;
				if (num11 > maxLen)
				{
					flag = true;
				}
			}
			if (flag)
			{
				for (int l = 1; l < alphaSize; l++)
				{
					int num13 = array2[l] >> 8;
					num13 = 1 + num13 / 2;
					array2[l] = num13 << 8;
				}
				continue;
			}
			break;
		}
	}

	private void eqUGBVElyrrEWwxgNprZKJKqRYvBA()
	{
		AYnfmpQafGZCtChcfRpAksXHVLBu.Reset();
		pqoHwWUCEGWPpyGzfvhLUfikiJXO = -1;
		for (int i = 0; i < 256; i++)
		{
			BuHJgZyyImgmYpHohmGriNggjsfP[i] = false;
		}
		FhTUGTxLwXYkCxOGLhpGXVLVbPyu = 100000 * fuwyPOgeStYLqYkQScYQnHYocDyAA - 20;
	}

	private void EgsSbMJlpoeuwULFbWfLfdPUwSrN()
	{
		HfXPSYhRVMCjpLxjLvOmRcDljZBD = 0;
		SdtBeDtYjxebYzTfCHUCezmAKOIJ = 0;
		QewcHerdyjcrCPPhlxHVsNzTAwvp(66);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(90);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(104);
		QewcHerdyjcrCPPhlxHVsNzTAwvp(48 + fuwyPOgeStYLqYkQScYQnHYocDyAA);
		VNhljmnXTXpmYkgdmVKjHjFdFwlP = 0u;
	}

	private void AJUpCKQiGZpVUYrLxHrELdIKsBWN()
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		bool[] array3 = new bool[256];
		for (int i = 0; i < 20; i++)
		{
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + i + 2] = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i % (pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1) + 1];
		}
		for (int i = 0; i <= pqoHwWUCEGWPpyGzfvhLUfikiJXO + 20; i++)
		{
			cREzpInxYydwtyrckuZKusPtVVdg[i] = 0;
		}
		gtXxhAZCXMTVJSCDsGpmRNOcTfhw[0] = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1];
		if (pqoHwWUCEGWPpyGzfvhLUfikiJXO >= 4000)
		{
			int num = 0;
			for (int i = 0; i <= 255; i++)
			{
				array3[i] = false;
			}
			for (int i = 0; i <= 65536; i++)
			{
				OtlpAXreYGOsVepcifbxjzwlDoQn[i] = 0;
			}
			int num2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[0];
			for (int i = 0; i <= pqoHwWUCEGWPpyGzfvhLUfikiJXO; i++)
			{
				int num3 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 1];
				OtlpAXreYGOsVepcifbxjzwlDoQn[(num2 << 8) + num3]++;
				num2 = num3;
			}
			for (int i = 1; i <= 65536; i++)
			{
				OtlpAXreYGOsVepcifbxjzwlDoQn[i] += OtlpAXreYGOsVepcifbxjzwlDoQn[i - 1];
			}
			num2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[1];
			int num4;
			for (int i = 0; i < pqoHwWUCEGWPpyGzfvhLUfikiJXO; i++)
			{
				int num3 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 2];
				num4 = (num2 << 8) + num3;
				num2 = num3;
				OtlpAXreYGOsVepcifbxjzwlDoQn[num4]--;
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[OtlpAXreYGOsVepcifbxjzwlDoQn[num4]] = i;
			}
			num4 = (gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] << 8) + gtXxhAZCXMTVJSCDsGpmRNOcTfhw[1];
			OtlpAXreYGOsVepcifbxjzwlDoQn[num4]--;
			AsmSSbXNzzTJLdtedJPrkYUGJCgx[OtlpAXreYGOsVepcifbxjzwlDoQn[num4]] = pqoHwWUCEGWPpyGzfvhLUfikiJXO;
			for (int i = 0; i <= 255; i++)
			{
				array[i] = i;
			}
			int num5 = 1;
			do
			{
				num5 = 3 * num5 + 1;
			}
			while (num5 <= 256);
			do
			{
				num5 /= 3;
				for (int i = num5; i <= 255; i++)
				{
					int num6 = array[i];
					num4 = i;
					while (OtlpAXreYGOsVepcifbxjzwlDoQn[array[num4 - num5] + 1 << 8] - OtlpAXreYGOsVepcifbxjzwlDoQn[array[num4 - num5] << 8] > OtlpAXreYGOsVepcifbxjzwlDoQn[num6 + 1 << 8] - OtlpAXreYGOsVepcifbxjzwlDoQn[num6 << 8])
					{
						array[num4] = array[num4 - num5];
						num4 -= num5;
						if (num4 <= num5 - 1)
						{
							break;
						}
					}
					array[num4] = num6;
				}
			}
			while (num5 != 1);
			for (int i = 0; i <= 255; i++)
			{
				int num7 = array[i];
				for (num4 = 0; num4 <= 255; num4++)
				{
					int num8 = (num7 << 8) + num4;
					if ((OtlpAXreYGOsVepcifbxjzwlDoQn[num8] & 0x200000) == 2097152)
					{
						continue;
					}
					int num9 = OtlpAXreYGOsVepcifbxjzwlDoQn[num8] & -2097153;
					int num10 = (OtlpAXreYGOsVepcifbxjzwlDoQn[num8 + 1] & -2097153) - 1;
					if (num10 > num9)
					{
						aikTOounAybmNhfroJEncsLyJIVaA(num9, num10, 2);
						num += num10 - num9 + 1;
						if (HtSUmgEGzvhsRWBdCVBuCrarkKnk > uYRvzfFIsTjmVyhKZykltnopBadHA && EMsRawGFNlIwWTlWBKJktLXccLNW)
						{
							return;
						}
					}
					OtlpAXreYGOsVepcifbxjzwlDoQn[num8] |= 2097152;
				}
				array3[num7] = true;
				if (i < 255)
				{
					int num11 = OtlpAXreYGOsVepcifbxjzwlDoQn[num7 << 8] & -2097153;
					int num12 = (OtlpAXreYGOsVepcifbxjzwlDoQn[num7 + 1 << 8] & -2097153) - num11;
					int j;
					for (j = 0; num12 >> j > 65534; j++)
					{
					}
					for (num4 = 0; num4 < num12; num4++)
					{
						int num13 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num11 + num4];
						int num14 = num4 >> j;
						cREzpInxYydwtyrckuZKusPtVVdg[num13] = num14;
						if (num13 < 20)
						{
							cREzpInxYydwtyrckuZKusPtVVdg[num13 + pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = num14;
						}
					}
					if (num12 - 1 >> j > 65535)
					{
						qYDFxoGBkDrPVABXCxlWFGuLccDaA();
					}
				}
				for (num4 = 0; num4 <= 255; num4++)
				{
					array2[num4] = OtlpAXreYGOsVepcifbxjzwlDoQn[(num4 << 8) + num7] & -2097153;
				}
				for (num4 = OtlpAXreYGOsVepcifbxjzwlDoQn[num7 << 8] & -2097153; num4 < (OtlpAXreYGOsVepcifbxjzwlDoQn[num7 + 1 << 8] & -2097153); num4++)
				{
					num2 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4]];
					if (!array3[num2])
					{
						AsmSSbXNzzTJLdtedJPrkYUGJCgx[array2[num2]] = ((AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4] == 0) ? pqoHwWUCEGWPpyGzfvhLUfikiJXO : (AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4] - 1));
						array2[num2]++;
					}
				}
				for (num4 = 0; num4 <= 255; num4++)
				{
					OtlpAXreYGOsVepcifbxjzwlDoQn[(num4 << 8) + num7] |= 2097152;
				}
			}
		}
		else
		{
			for (int i = 0; i <= pqoHwWUCEGWPpyGzfvhLUfikiJXO; i++)
			{
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[i] = i;
			}
			EMsRawGFNlIwWTlWBKJktLXccLNW = false;
			uYRvzfFIsTjmVyhKZykltnopBadHA = 0;
			HtSUmgEGzvhsRWBdCVBuCrarkKnk = 0;
			xzYXucgDNJYjhjzVbujsvKbRsIZn(0, pqoHwWUCEGWPpyGzfvhLUfikiJXO, 0);
		}
	}

	private void oOHhxgkRAltnEdJftRCVfNAykMQB()
	{
		wWdHPAghuZOHyFFiYAwhypiHAJWd = 0;
		for (int i = 0; i < 256; i++)
		{
			if (BuHJgZyyImgmYpHohmGriNggjsfP[i])
			{
				LlbQaIxdfNtnXkZZqWcKQSoBNwQF[wWdHPAghuZOHyFFiYAwhypiHAJWd] = (char)i;
				KKGoLDHsuAdslfqfQAeuTppGpsJTA[i] = (char)wWdHPAghuZOHyFFiYAwhypiHAJWd;
				wWdHPAghuZOHyFFiYAwhypiHAJWd++;
			}
		}
	}

	private static byte LxyBFVtctDcShWUBckodReTWPPbV(byte byte_0, byte byte_1, byte byte_2)
	{
		if (byte_0 > byte_1)
		{
			byte b = byte_0;
			byte_0 = byte_1;
			byte_1 = b;
		}
		if (byte_1 > byte_2)
		{
			byte b = byte_1;
			byte_1 = byte_2;
			byte_2 = b;
		}
		if (byte_0 > byte_1)
		{
			byte_1 = byte_0;
		}
		return byte_1;
	}

	private void FyXwhefDdjPGFMKsoUoVGZnmuXte()
	{
		HjGvtqSkduiTcdNTSjbFFcTsfmJgA(24, vXrneFWezTwWWxshcqGMPNMrzeKM);
		DXrTQyfUKhZGwNmCRxlhppqQFISj();
		MLofYNAzoKaUjuRlFCKtfOaCZVcg();
	}

	private static void qYDFxoGBkDrPVABXCxlWFGuLccDaA()
	{
		throw new BZip2Exception("BZip2 output stream panic");
	}

	private void aikTOounAybmNhfroJEncsLyJIVaA(int loSt, int hiSt, int dSt)
	{
		mgKUUcUmNOyeMfaegDHZcNWBVU[] array = new mgKUUcUmNOyeMfaegDHZcNWBVU[1000];
		int num = 0;
		array[0].MJKWhUrNwzNBdVNFDjpgJckseGKX = loSt;
		array[0].yctsBImRvXVwxzGHEoZUtliKoFTj = hiSt;
		array[0].BnEYqwTVzmRLybjFdhAWIHzXOkWL = dSt;
		num = 1;
		while (num > 0)
		{
			if (num >= 1000)
			{
				qYDFxoGBkDrPVABXCxlWFGuLccDaA();
			}
			num--;
			int mJKWhUrNwzNBdVNFDjpgJckseGKX = array[num].MJKWhUrNwzNBdVNFDjpgJckseGKX;
			int yctsBImRvXVwxzGHEoZUtliKoFTj = array[num].yctsBImRvXVwxzGHEoZUtliKoFTj;
			int bnEYqwTVzmRLybjFdhAWIHzXOkWL = array[num].BnEYqwTVzmRLybjFdhAWIHzXOkWL;
			if (yctsBImRvXVwxzGHEoZUtliKoFTj - mJKWhUrNwzNBdVNFDjpgJckseGKX < 20 || bnEYqwTVzmRLybjFdhAWIHzXOkWL > 10)
			{
				xzYXucgDNJYjhjzVbujsvKbRsIZn(mJKWhUrNwzNBdVNFDjpgJckseGKX, yctsBImRvXVwxzGHEoZUtliKoFTj, bnEYqwTVzmRLybjFdhAWIHzXOkWL);
				if (HtSUmgEGzvhsRWBdCVBuCrarkKnk <= uYRvzfFIsTjmVyhKZykltnopBadHA || !EMsRawGFNlIwWTlWBKJktLXccLNW)
				{
					continue;
				}
				break;
			}
			int num2 = LxyBFVtctDcShWUBckodReTWPPbV(gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[mJKWhUrNwzNBdVNFDjpgJckseGKX] + bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1], gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[yctsBImRvXVwxzGHEoZUtliKoFTj] + bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1], gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[mJKWhUrNwzNBdVNFDjpgJckseGKX + yctsBImRvXVwxzGHEoZUtliKoFTj >> 1] + bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1]);
			int num3;
			int num4 = (num3 = mJKWhUrNwzNBdVNFDjpgJckseGKX);
			int num5;
			int num6 = (num5 = yctsBImRvXVwxzGHEoZUtliKoFTj);
			while (true)
			{
				if (num4 <= num6)
				{
					int num7 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4] + bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1] - num2;
					if (num7 == 0)
					{
						int num8 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4];
						AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num3];
						AsmSSbXNzzTJLdtedJPrkYUGJCgx[num3] = num8;
						num3++;
						num4++;
						continue;
					}
					if (num7 <= 0)
					{
						num4++;
						continue;
					}
				}
				while (num4 <= num6)
				{
					int num7 = gtXxhAZCXMTVJSCDsGpmRNOcTfhw[AsmSSbXNzzTJLdtedJPrkYUGJCgx[num6] + bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1] - num2;
					if (num7 == 0)
					{
						int num9 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num6];
						AsmSSbXNzzTJLdtedJPrkYUGJCgx[num6] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5];
						AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = num9;
						num5--;
						num6--;
					}
					else
					{
						if (num7 < 0)
						{
							break;
						}
						num6--;
					}
				}
				if (num4 > num6)
				{
					break;
				}
				int num10 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4];
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[num4] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num6];
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[num6] = num10;
				num4++;
				num6--;
			}
			if (num5 >= num3)
			{
				int num7 = ((num3 - mJKWhUrNwzNBdVNFDjpgJckseGKX < num4 - num3) ? (num3 - mJKWhUrNwzNBdVNFDjpgJckseGKX) : (num4 - num3));
				GLDadxjfSHCgzdGkMbCqUhdlfbBsA(mJKWhUrNwzNBdVNFDjpgJckseGKX, num4 - num7, num7);
				int num11 = ((yctsBImRvXVwxzGHEoZUtliKoFTj - num5 < num5 - num6) ? (yctsBImRvXVwxzGHEoZUtliKoFTj - num5) : (num5 - num6));
				GLDadxjfSHCgzdGkMbCqUhdlfbBsA(num4, yctsBImRvXVwxzGHEoZUtliKoFTj - num11 + 1, num11);
				num7 = mJKWhUrNwzNBdVNFDjpgJckseGKX + num4 - num3 - 1;
				num11 = yctsBImRvXVwxzGHEoZUtliKoFTj - (num5 - num6) + 1;
				array[num].MJKWhUrNwzNBdVNFDjpgJckseGKX = mJKWhUrNwzNBdVNFDjpgJckseGKX;
				array[num].yctsBImRvXVwxzGHEoZUtliKoFTj = num7;
				array[num].BnEYqwTVzmRLybjFdhAWIHzXOkWL = bnEYqwTVzmRLybjFdhAWIHzXOkWL;
				num++;
				array[num].MJKWhUrNwzNBdVNFDjpgJckseGKX = num7 + 1;
				array[num].yctsBImRvXVwxzGHEoZUtliKoFTj = num11 - 1;
				array[num].BnEYqwTVzmRLybjFdhAWIHzXOkWL = bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1;
				num++;
				array[num].MJKWhUrNwzNBdVNFDjpgJckseGKX = num11;
				array[num].yctsBImRvXVwxzGHEoZUtliKoFTj = yctsBImRvXVwxzGHEoZUtliKoFTj;
				array[num].BnEYqwTVzmRLybjFdhAWIHzXOkWL = bnEYqwTVzmRLybjFdhAWIHzXOkWL;
				num++;
			}
			else
			{
				array[num].MJKWhUrNwzNBdVNFDjpgJckseGKX = mJKWhUrNwzNBdVNFDjpgJckseGKX;
				array[num].yctsBImRvXVwxzGHEoZUtliKoFTj = yctsBImRvXVwxzGHEoZUtliKoFTj;
				array[num].BnEYqwTVzmRLybjFdhAWIHzXOkWL = bnEYqwTVzmRLybjFdhAWIHzXOkWL + 1;
				num++;
			}
		}
	}

	private void HNfGeEKlfVmBYPJPLPJLwAIkzaFU()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 256; i++)
		{
			BuHJgZyyImgmYpHohmGriNggjsfP[i] = false;
		}
		for (int i = 0; i <= pqoHwWUCEGWPpyGzfvhLUfikiJXO; i++)
		{
			if (num == 0)
			{
				num = imyYcTsRjudagyxGvRWoRnuWOcyS.uqdhwAXSfWJnPSrvkAnqGqJkhgdcA[num2];
				num2++;
				if (num2 == 512)
				{
					num2 = 0;
				}
			}
			num--;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 1] = (byte)((uint)gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 1] ^ ((num == 1) ? 1u : 0u));
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 1] = (byte)(gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 1] & 0xFFu);
			BuHJgZyyImgmYpHohmGriNggjsfP[gtXxhAZCXMTVJSCDsGpmRNOcTfhw[i + 1]] = true;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("BZip2OutputStream Read not supported");
	}

	public override int ReadByte()
	{
		throw new NotSupportedException("BZip2OutputStream ReadByte not supported");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("BZip2OutputStream Seek not supported");
	}

	private void MLofYNAzoKaUjuRlFCKtfOaCZVcg()
	{
		char[][] array = new char[6][];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new char[258];
		}
		int num = 0;
		int num2 = wWdHPAghuZOHyFFiYAwhypiHAJWd + 2;
		for (int j = 0; j < 6; j++)
		{
			for (int k = 0; k < num2; k++)
			{
				array[j][k] = '\u000f';
			}
		}
		if (XptaChznMCxhfnTGGnfDUeENszkq <= 0)
		{
			qYDFxoGBkDrPVABXCxlWFGuLccDaA();
		}
		int num3 = ((XptaChznMCxhfnTGGnfDUeENszkq < 200) ? 2 : ((XptaChznMCxhfnTGGnfDUeENszkq < 600) ? 3 : ((XptaChznMCxhfnTGGnfDUeENszkq < 1200) ? 4 : ((XptaChznMCxhfnTGGnfDUeENszkq < 2400) ? 5 : 6))));
		int num4 = num3;
		int num5 = XptaChznMCxhfnTGGnfDUeENszkq;
		int num6 = 0;
		while (num4 > 0)
		{
			int num7 = num5 / num4;
			int l = 0;
			int num8;
			for (num8 = num6 - 1; l < num7; l += SgefvaHJZGGdQiXLbKgFznRJhGlzA[num8])
			{
				if (num8 >= num2 - 1)
				{
					break;
				}
				num8++;
			}
			if (num8 > num6 && num4 != num3 && num4 != 1 && (num3 - num4) % 2 == 1)
			{
				l -= SgefvaHJZGGdQiXLbKgFznRJhGlzA[num8];
				num8--;
			}
			for (int m = 0; m < num2; m++)
			{
				if (m < num6 || m > num8)
				{
					array[num4 - 1][m] = '\u000f';
				}
				else
				{
					array[num4 - 1][m] = '\0';
				}
			}
			num4--;
			num6 = num8 + 1;
			num5 -= l;
		}
		int[][] array2 = new int[6][];
		for (int n = 0; n < 6; n++)
		{
			array2[n] = new int[258];
		}
		int[] array3 = new int[6];
		short[] array4 = new short[6];
		for (int num9 = 0; num9 < 4; num9++)
		{
			for (int num10 = 0; num10 < num3; num10++)
			{
				array3[num10] = 0;
			}
			for (int num11 = 0; num11 < num3; num11++)
			{
				for (int num12 = 0; num12 < num2; num12++)
				{
					array2[num11][num12] = 0;
				}
			}
			num = 0;
			int num13 = 0;
			num6 = 0;
			while (num6 < XptaChznMCxhfnTGGnfDUeENszkq)
			{
				int num8 = num6 + 50 - 1;
				if (num8 >= XptaChznMCxhfnTGGnfDUeENszkq)
				{
					num8 = XptaChznMCxhfnTGGnfDUeENszkq - 1;
				}
				for (int num14 = 0; num14 < num3; num14++)
				{
					array4[num14] = 0;
				}
				if (num3 != 6)
				{
					for (int num15 = num6; num15 <= num8; num15++)
					{
						short num16 = vfgPXfrCNGhowsMDBYiijRhoPAon[num15];
						for (int num17 = 0; num17 < num3; num17++)
						{
							array4[num17] += (short)array[num17][num16];
						}
					}
				}
				else
				{
					short num18 = 0;
					short num19 = 0;
					short num20 = 0;
					short num21 = 0;
					short num22 = 0;
					short num23 = 0;
					for (int num24 = num6; num24 <= num8; num24++)
					{
						short num25 = vfgPXfrCNGhowsMDBYiijRhoPAon[num24];
						num23 = (short)(num23 + (short)array[0][num25]);
						num22 = (short)(num22 + (short)array[1][num25]);
						num21 = (short)(num21 + (short)array[2][num25]);
						num20 = (short)(num20 + (short)array[3][num25]);
						num19 = (short)(num19 + (short)array[4][num25]);
						num18 = (short)(num18 + (short)array[5][num25]);
					}
					array4[0] = num23;
					array4[1] = num22;
					array4[2] = num21;
					array4[3] = num20;
					array4[4] = num19;
					array4[5] = num18;
				}
				int num26 = 999999999;
				int num27 = -1;
				for (int num28 = 0; num28 < num3; num28++)
				{
					if (array4[num28] < num26)
					{
						num26 = array4[num28];
						num27 = num28;
					}
				}
				num13 += num26;
				array3[num27]++;
				JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num] = (char)num27;
				num++;
				for (int num29 = num6; num29 <= num8; num29++)
				{
					array2[num27][vfgPXfrCNGhowsMDBYiijRhoPAon[num29]]++;
				}
				num6 = num8 + 1;
			}
			for (int num30 = 0; num30 < num3; num30++)
			{
				KeLlhyvEQWvqvkSbRPcCDkYKkKiG(array[num30], array2[num30], num2, 20);
			}
		}
		array2 = null;
		array3 = null;
		array4 = null;
		if (num3 >= 8)
		{
			qYDFxoGBkDrPVABXCxlWFGuLccDaA();
		}
		if (num >= 32768 || num > 18002)
		{
			qYDFxoGBkDrPVABXCxlWFGuLccDaA();
		}
		char[] array5 = new char[6];
		for (int num31 = 0; num31 < num3; num31++)
		{
			array5[num31] = (char)num31;
		}
		for (int num32 = 0; num32 < num; num32++)
		{
			char c = JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num32];
			int num33 = 0;
			char c2 = array5[0];
			while (c != c2)
			{
				num33++;
				char c3 = c2;
				c2 = array5[num33];
				array5[num33] = c3;
			}
			array5[0] = c2;
			OmPcOtIJWJoQwOSIMOCXSscqbbOOA[num32] = (char)num33;
		}
		int[][] array6 = new int[6][];
		for (int num34 = 0; num34 < 6; num34++)
		{
			array6[num34] = new int[258];
		}
		for (int num35 = 0; num35 < num3; num35++)
		{
			int num36 = 32;
			int num37 = 0;
			for (int num38 = 0; num38 < num2; num38++)
			{
				if (array[num35][num38] > num37)
				{
					num37 = array[num35][num38];
				}
				if (array[num35][num38] < num36)
				{
					num36 = array[num35][num38];
				}
			}
			if (num37 > 20)
			{
				qYDFxoGBkDrPVABXCxlWFGuLccDaA();
			}
			if (num36 < 1)
			{
				qYDFxoGBkDrPVABXCxlWFGuLccDaA();
			}
			VfnJXMdvLloacHpCSzglZcdUvdET(array6[num35], array[num35], num36, num37, num2);
		}
		bool[] array7 = new bool[16];
		for (int num39 = 0; num39 < 16; num39++)
		{
			array7[num39] = false;
			for (int num40 = 0; num40 < 16; num40++)
			{
				if (BuHJgZyyImgmYpHohmGriNggjsfP[num39 * 16 + num40])
				{
					array7[num39] = true;
				}
			}
		}
		for (int num41 = 0; num41 < 16; num41++)
		{
			if (array7[num41])
			{
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 1);
			}
			else
			{
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 0);
			}
		}
		for (int num42 = 0; num42 < 16; num42++)
		{
			if (!array7[num42])
			{
				continue;
			}
			for (int num43 = 0; num43 < 16; num43++)
			{
				if (!BuHJgZyyImgmYpHohmGriNggjsfP[num42 * 16 + num43])
				{
					hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 0);
				}
				else
				{
					hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 1);
				}
			}
		}
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(3, num3);
		hxtFHgzRWpjOMPjoxATDJnnDYqXnA(15, num);
		for (int num44 = 0; num44 < num; num44++)
		{
			for (int num45 = 0; num45 < OmPcOtIJWJoQwOSIMOCXSscqbbOOA[num44]; num45++)
			{
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 1);
			}
			hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 0);
		}
		for (int num46 = 0; num46 < num3; num46++)
		{
			int num47 = array[num46][0];
			hxtFHgzRWpjOMPjoxATDJnnDYqXnA(5, num47);
			for (int num48 = 0; num48 < num2; num48++)
			{
				for (; num47 < array[num46][num48]; num47++)
				{
					hxtFHgzRWpjOMPjoxATDJnnDYqXnA(2, 2);
				}
				while (num47 > array[num46][num48])
				{
					hxtFHgzRWpjOMPjoxATDJnnDYqXnA(2, 3);
					num47--;
				}
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(1, 0);
			}
		}
		int num49 = 0;
		num6 = 0;
		while (num6 < XptaChznMCxhfnTGGnfDUeENszkq)
		{
			int num8 = num6 + 50 - 1;
			if (num8 >= XptaChznMCxhfnTGGnfDUeENszkq)
			{
				num8 = XptaChznMCxhfnTGGnfDUeENszkq - 1;
			}
			for (int num50 = num6; num50 <= num8; num50++)
			{
				hxtFHgzRWpjOMPjoxATDJnnDYqXnA(array[(uint)JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num49]][vfgPXfrCNGhowsMDBYiijRhoPAon[num50]], array6[(uint)JSeGmkCiGCJzBgFYeeFcmGTbsRIIA[num49]][vfgPXfrCNGhowsMDBYiijRhoPAon[num50]]);
			}
			num6 = num8 + 1;
			num49++;
		}
		if (num49 != num)
		{
			qYDFxoGBkDrPVABXCxlWFGuLccDaA();
		}
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("BZip2OutputStream SetLength not supported");
	}

	private void xzYXucgDNJYjhjzVbujsvKbRsIZn(int int_0, int int_1, int int_2)
	{
		int num = int_1 - int_0 + 1;
		if (num < 2)
		{
			return;
		}
		int i;
		for (i = 0; LslZVbLrgPaPigPaUiWlSpSvRZgR[i] < num; i++)
		{
		}
		for (i--; i >= 0; i--)
		{
			int num2 = LslZVbLrgPaPigPaUiWlSpSvRZgR[i];
			int num3 = int_0 + num2;
			while (num3 <= int_1)
			{
				int num4 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num3];
				int num5 = num3;
				while (gBrKmyqjibmYXhcsUmJSpbZmEApH(AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5 - num2] + int_2, num4 + int_2))
				{
					AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5 - num2];
					num5 -= num2;
					if (num5 <= int_0 + num2 - 1)
					{
						break;
					}
				}
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = num4;
				num3++;
				if (num3 > int_1)
				{
					break;
				}
				num4 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num3];
				num5 = num3;
				while (gBrKmyqjibmYXhcsUmJSpbZmEApH(AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5 - num2] + int_2, num4 + int_2))
				{
					AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5 - num2];
					num5 -= num2;
					if (num5 <= int_0 + num2 - 1)
					{
						break;
					}
				}
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = num4;
				num3++;
				if (num3 > int_1)
				{
					break;
				}
				num4 = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num3];
				num5 = num3;
				while (gBrKmyqjibmYXhcsUmJSpbZmEApH(AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5 - num2] + int_2, num4 + int_2))
				{
					AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5 - num2];
					num5 -= num2;
					if (num5 <= int_0 + num2 - 1)
					{
						break;
					}
				}
				AsmSSbXNzzTJLdtedJPrkYUGJCgx[num5] = num4;
				num3++;
				if (HtSUmgEGzvhsRWBdCVBuCrarkKnk > uYRvzfFIsTjmVyhKZykltnopBadHA && EMsRawGFNlIwWTlWBKJktLXccLNW)
				{
					return;
				}
			}
		}
	}

	private void GLDadxjfSHCgzdGkMbCqUhdlfbBsA(int int_0, int int_1, int int_2)
	{
		int num = 0;
		while (int_2 > 0)
		{
			num = AsmSSbXNzzTJLdtedJPrkYUGJCgx[int_0];
			AsmSSbXNzzTJLdtedJPrkYUGJCgx[int_0] = AsmSSbXNzzTJLdtedJPrkYUGJCgx[int_1];
			AsmSSbXNzzTJLdtedJPrkYUGJCgx[int_1] = num;
			int_0++;
			int_1++;
			int_2--;
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count >= 0)
		{
			if (buffer.Length - offset >= count)
			{
				for (int i = 0; i < count; i++)
				{
					WriteByte(buffer[offset + i]);
				}
				return;
			}
			throw new ArgumentException("Offset/count out of range");
		}
		throw new ArgumentOutOfRangeException("count");
	}

	public override void WriteByte(byte value)
	{
		int num = (256 + value) % 256;
		if (LhdkhDyOSIpzpAwDGWvIQnTTcrOJ != -1)
		{
			if (LhdkhDyOSIpzpAwDGWvIQnTTcrOJ == num)
			{
				sgqkxVYEgiRtLSCSdCLLSyFPlvEr++;
				if (sgqkxVYEgiRtLSCSdCLLSyFPlvEr > 254)
				{
					lCPUFlWTVajHmPOnOqklpyHXWHSA();
					LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = -1;
					sgqkxVYEgiRtLSCSdCLLSyFPlvEr = 0;
				}
			}
			else
			{
				lCPUFlWTVajHmPOnOqklpyHXWHSA();
				sgqkxVYEgiRtLSCSdCLLSyFPlvEr = 1;
				LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = num;
			}
		}
		else
		{
			LhdkhDyOSIpzpAwDGWvIQnTTcrOJ = num;
			sgqkxVYEgiRtLSCSdCLLSyFPlvEr++;
		}
	}

	private void lCPUFlWTVajHmPOnOqklpyHXWHSA()
	{
		if (pqoHwWUCEGWPpyGzfvhLUfikiJXO >= FhTUGTxLwXYkCxOGLhpGXVLVbPyu)
		{
			jEvKacTVbHqNqPskyiOHWYkOaXXK();
			eqUGBVElyrrEWwxgNprZKJKqRYvBA();
			lCPUFlWTVajHmPOnOqklpyHXWHSA();
			return;
		}
		BuHJgZyyImgmYpHohmGriNggjsfP[LhdkhDyOSIpzpAwDGWvIQnTTcrOJ] = true;
		for (int i = 0; i < sgqkxVYEgiRtLSCSdCLLSyFPlvEr; i++)
		{
			AYnfmpQafGZCtChcfRpAksXHVLBu.Update(LhdkhDyOSIpzpAwDGWvIQnTTcrOJ);
		}
		switch (sgqkxVYEgiRtLSCSdCLLSyFPlvEr)
		{
		default:
			BuHJgZyyImgmYpHohmGriNggjsfP[sgqkxVYEgiRtLSCSdCLLSyFPlvEr - 4] = true;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)(sgqkxVYEgiRtLSCSdCLLSyFPlvEr - 4);
			break;
		case 1:
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			break;
		case 2:
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			break;
		case 3:
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			pqoHwWUCEGWPpyGzfvhLUfikiJXO++;
			gtXxhAZCXMTVJSCDsGpmRNOcTfhw[pqoHwWUCEGWPpyGzfvhLUfikiJXO + 1] = (byte)LhdkhDyOSIpzpAwDGWvIQnTTcrOJ;
			break;
		}
	}
}
