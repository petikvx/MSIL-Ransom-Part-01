using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.BZip2;

public class BZip2InputStream : Stream
{
	private const int ALeavJlUgHaCMAqPIdFYflKFVpYVb = 1;

	private const int OtUjSYmeAQOSpgIzhTIpieqXKiqt = 2;

	private const int wEGfHhElJWOtPlAAllSUZWDRySXrA = 3;

	private const int HIGVUGBnrpBLwepgFezPNKWcloIIA = 4;

	private const int XSVfOCMjBydtUZZYwbinlhtVtEG = 5;

	private const int cxRPhIkYHjkxTrTKMjzVQdQOtaie = 6;

	private const int rMakjlmrmMWRHoqjiFvrBXxbUcMh = 7;

	private int kiondpinEzQabZwUucVyiXrfkoSi;

	private int sfpCkskMhymSQOTKbVdlrYHaVrRF;

	private int sZgxSfYAUAnyelhwLZStXVttsNlD;

	private bool hqbwIvdQbrNrqztnvgfUOMSZzaem;

	private int sYcomjKCwLDiLDMZJtTdAWTPdeCmA;

	private int XgunpNknGoBMgdBeWGHZUzxXYQmVA;

	private IChecksum LhlEXUmBlhGoplOFyZirAzSUloCs = new StrangeCRC();

	private bool[] WJTCScASGJaAMYRLiANAKHblvVep = new bool[256];

	private int tQtXjtSNoifumqdiLgPUhAuAJjDNA;

	private byte[] EFdwufFphqDVTLqqjbNnyhvOAgBz = new byte[256];

	private byte[] HYGdcsrlybOhhRFOTlBLFZwDTROJ = new byte[256];

	private byte[] IXcIBuUUdlRGZcrgjUHPaJMukgPK = new byte[18002];

	private byte[] HLlqQetIguswClpYBFmvMxanYBAB = new byte[18002];

	private int[] HwALclJnmKEhvJkyEQoZKjdhqbRWA;

	private byte[] YzBRIVUxaJVmjEDtROkGJXZIcLMW;

	private int[] kGMVGApdAqNVFtpwaJNgrKSCfmQJ = new int[256];

	private int[][] eMPdNwNBKojabEPjTnmnJDdJVzxo = new int[6][];

	private int[][] HgjWDRHfHxGPZQnWGDWGCCwMTerQA = new int[6][];

	private int[][] iZUqIeWxiasaIVquELDhwYMipVRl = new int[6][];

	private int[] BumZnVZHNudIwfCtZAGFsYCJqIYPA = new int[6];

	private Stream ZZbXkWNbEgTXEBDIabDhSGsvFVVF;

	private bool PibbjKDknrCXcaQQtaBucZhKMBYFb;

	private int MTtlOaSLQrBDxDzkNPPhamSQOXLrA = -1;

	private int tkcYjskPNFudsogyhBIonVKpjivs = 1;

	private int wjEjYNNVkfsmiVGTnLSEWFazcfFQ;

	private int xDXbROgJkSpndePEbrbaTURGGccMc;

	private int UvrCGuIsCgIUUPgEIkWIEhZdjFJCA;

	private uint AkzigfZHBuEFhOUxiZkWcoIsddrV;

	private int MLVOROAbOXETfTvfiJujIrPTKFKn;

	private int yjWKyupdIeEAAiowswLMUrHuqfnKA;

	private int dOvLMdEnpwinlAusVqzbBezROZEo;

	private int hyxHdfesKkjkGdLctPALLjInnIhE;

	private int sjVZcXBSxbaLJcPRIwbqeOypSBPT;

	private int VtRqnPNtGIPQOwIlxJucIlgEQiqK;

	private int UtCINLvDbBxPoKhwgLqnyqcCzgDj;

	private int uqzdWddaKDfBaLRIDlKyKrscTzgn;

	private byte XOFiuGduWMSCCYHcOtpXwynzgrnH;

	private bool wLAMyKxDbSSzQUvMyMwOQVxXsyqm = true;

	public bool IsStreamOwner
	{
		get
		{
			return wLAMyKxDbSSzQUvMyMwOQVxXsyqm;
		}
		set
		{
			wLAMyKxDbSSzQUvMyMwOQVxXsyqm = value;
		}
	}

	public override bool CanRead => ZZbXkWNbEgTXEBDIabDhSGsvFVVF.CanRead;

	public override bool CanSeek => ZZbXkWNbEgTXEBDIabDhSGsvFVVF.CanSeek;

	public override bool CanWrite => false;

	public override long Length => ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Length;

	public override long Position
	{
		get
		{
			return ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Position;
		}
		set
		{
			throw new NotSupportedException("BZip2InputStream position cannot be set");
		}
	}

	public BZip2InputStream(Stream stream)
	{
		for (int i = 0; i < 6; i++)
		{
			eMPdNwNBKojabEPjTnmnJDdJVzxo[i] = new int[258];
			HgjWDRHfHxGPZQnWGDWGCCwMTerQA[i] = new int[258];
			iZUqIeWxiasaIVquELDhwYMipVRl[i] = new int[258];
		}
		gTcfBmdLPIvSaeGrrkVKZnraHzMF(stream);
		JmoPVjxnELOhezgyyasePmQDdcem();
		buSvorTwXYqUASLaIqeZxBDzfqmb();
		BrXHbNIfkbNWpgxaVzqKyaMMcSQb();
	}

	public override void Flush()
	{
		if (ZZbXkWNbEgTXEBDIabDhSGsvFVVF != null)
		{
			ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Flush();
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("BZip2InputStream Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("BZip2InputStream SetLength not supported");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("BZip2InputStream Write not supported");
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException("BZip2InputStream WriteByte not supported");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		for (int i = 0; i < count; i++)
		{
			int num = ReadByte();
			if (num != -1)
			{
				buffer[offset + i] = (byte)num;
				continue;
			}
			return i;
		}
		return count;
	}

	public override void Close()
	{
		if (IsStreamOwner && ZZbXkWNbEgTXEBDIabDhSGsvFVVF != null)
		{
			ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Close();
		}
	}

	public override int ReadByte()
	{
		if (PibbjKDknrCXcaQQtaBucZhKMBYFb)
		{
			return -1;
		}
		int mTtlOaSLQrBDxDzkNPPhamSQOXLrA = MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
		switch (tkcYjskPNFudsogyhBIonVKpjivs)
		{
		case 3:
			CVfKkhWHahQQAuEeUtKqlNedzsuO();
			break;
		case 4:
			URHehHcSzWIJfpjgGXMsJKTOOPkFA();
			break;
		case 6:
			VdmuhKcyeCaUXiaaDbaYoYMnzWXk();
			break;
		case 7:
			LWuVVTTEAzidtEItGPmPvilRwYYqA();
			break;
		}
		return mTtlOaSLQrBDxDzkNPPhamSQOXLrA;
	}

	private void phAbDIKSTndJbPQkmBAhAZOdrZNoc()
	{
		tQtXjtSNoifumqdiLgPUhAuAJjDNA = 0;
		for (int i = 0; i < 256; i++)
		{
			if (WJTCScASGJaAMYRLiANAKHblvVep[i])
			{
				EFdwufFphqDVTLqqjbNnyhvOAgBz[tQtXjtSNoifumqdiLgPUhAuAJjDNA] = (byte)i;
				HYGdcsrlybOhhRFOTlBLFZwDTROJ[i] = (byte)tQtXjtSNoifumqdiLgPUhAuAJjDNA;
				tQtXjtSNoifumqdiLgPUhAuAJjDNA++;
			}
		}
	}

	private void JmoPVjxnELOhezgyyasePmQDdcem()
	{
		char num = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c2 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c3 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		if (num == 'B' && c == 'Z' && c2 == 'h' && c3 >= '1' && c3 <= '9')
		{
			WKKHUrZuUCsbArGLUpdwykwhsKXi(c3 - 48);
			AkzigfZHBuEFhOUxiZkWcoIsddrV = 0u;
		}
		else
		{
			PibbjKDknrCXcaQQtaBucZhKMBYFb = true;
		}
	}

	private void buSvorTwXYqUASLaIqeZxBDzfqmb()
	{
		char c = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c2 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c3 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c4 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c5 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		char c6 = TUvFKZqjVVAOoVpRiDDWOVsDHiIk();
		if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
		{
			wCALRmZrVpcnBUIbPeKYFkUPzGFMA();
		}
		else if (c == '1' && c2 == 'A' && c3 == 'Y' && c4 == '&' && c5 == 'S' && c6 == 'Y')
		{
			wjEjYNNVkfsmiVGTnLSEWFazcfFQ = YYNYlyOeqmbnjaEXfzNyMClMdxMeA();
			hqbwIvdQbrNrqztnvgfUOMSZzaem = nJjcafkkXWkztLxvBOhRsyOtIIMW(1) == 1;
			DAHfySLRwNFKHDrvyJBOgtPbOGGgc();
			LhlEXUmBlhGoplOFyZirAzSUloCs.Reset();
			tkcYjskPNFudsogyhBIonVKpjivs = 1;
		}
		else
		{
			MlnkEgjlSZHgrXMvRmWwQUHFDmmN();
			PibbjKDknrCXcaQQtaBucZhKMBYFb = true;
		}
	}

	private void eUlCvHxhzeHzmmgZxTJuaRpPXSUJ()
	{
		UvrCGuIsCgIUUPgEIkWIEhZdjFJCA = (int)LhlEXUmBlhGoplOFyZirAzSUloCs.Value;
		if (wjEjYNNVkfsmiVGTnLSEWFazcfFQ != UvrCGuIsCgIUUPgEIkWIEhZdjFJCA)
		{
			oJxYDVHPeZXCcSNRJhHOaACpXOQT();
		}
		AkzigfZHBuEFhOUxiZkWcoIsddrV = ((AkzigfZHBuEFhOUxiZkWcoIsddrV << 1) & 0xFFFFFFFFu) | (AkzigfZHBuEFhOUxiZkWcoIsddrV >> 31);
		AkzigfZHBuEFhOUxiZkWcoIsddrV ^= (uint)UvrCGuIsCgIUUPgEIkWIEhZdjFJCA;
	}

	private void wCALRmZrVpcnBUIbPeKYFkUPzGFMA()
	{
		xDXbROgJkSpndePEbrbaTURGGccMc = YYNYlyOeqmbnjaEXfzNyMClMdxMeA();
		if (xDXbROgJkSpndePEbrbaTURGGccMc != (int)AkzigfZHBuEFhOUxiZkWcoIsddrV)
		{
			oJxYDVHPeZXCcSNRJhHOaACpXOQT();
		}
		PibbjKDknrCXcaQQtaBucZhKMBYFb = true;
	}

	private void gTcfBmdLPIvSaeGrrkVKZnraHzMF(Stream stream)
	{
		ZZbXkWNbEgTXEBDIabDhSGsvFVVF = stream;
		XgunpNknGoBMgdBeWGHZUzxXYQmVA = 0;
		sYcomjKCwLDiLDMZJtTdAWTPdeCmA = 0;
	}

	private void fRjIxpaLGCwsLTdUStEvpMOvLlCo()
	{
		int num = 0;
		try
		{
			num = ZZbXkWNbEgTXEBDIabDhSGsvFVVF.ReadByte();
		}
		catch (Exception)
		{
			TahiWgjRcmASCzYHiqQdnFsUJMuf();
		}
		if (num == -1)
		{
			TahiWgjRcmASCzYHiqQdnFsUJMuf();
		}
		sYcomjKCwLDiLDMZJtTdAWTPdeCmA = (sYcomjKCwLDiLDMZJtTdAWTPdeCmA << 8) | (num & 0xFF);
		XgunpNknGoBMgdBeWGHZUzxXYQmVA += 8;
	}

	private int nJjcafkkXWkztLxvBOhRsyOtIIMW(int int_4)
	{
		while (XgunpNknGoBMgdBeWGHZUzxXYQmVA < int_4)
		{
			fRjIxpaLGCwsLTdUStEvpMOvLlCo();
		}
		int result = (sYcomjKCwLDiLDMZJtTdAWTPdeCmA >> XgunpNknGoBMgdBeWGHZUzxXYQmVA - int_4) & ((1 << int_4) - 1);
		XgunpNknGoBMgdBeWGHZUzxXYQmVA -= int_4;
		return result;
	}

	private char TUvFKZqjVVAOoVpRiDDWOVsDHiIk()
	{
		return (char)nJjcafkkXWkztLxvBOhRsyOtIIMW(8);
	}

	private int ExZgffgDMJkTKfSEfxmRjgyDgdvQA(int numBits)
	{
		return nJjcafkkXWkztLxvBOhRsyOtIIMW(numBits);
	}

	private int YYNYlyOeqmbnjaEXfzNyMClMdxMeA()
	{
		return (((((nJjcafkkXWkztLxvBOhRsyOtIIMW(8) << 8) | nJjcafkkXWkztLxvBOhRsyOtIIMW(8)) << 8) | nJjcafkkXWkztLxvBOhRsyOtIIMW(8)) << 8) | nJjcafkkXWkztLxvBOhRsyOtIIMW(8);
	}

	private void ankJRBlwcZWTfomKmTdRruwilSgL()
	{
		char[][] array = new char[6][];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new char[258];
		}
		bool[] array2 = new bool[16];
		for (int j = 0; j < 16; j++)
		{
			array2[j] = nJjcafkkXWkztLxvBOhRsyOtIIMW(1) == 1;
		}
		for (int k = 0; k < 16; k++)
		{
			if (array2[k])
			{
				for (int l = 0; l < 16; l++)
				{
					WJTCScASGJaAMYRLiANAKHblvVep[k * 16 + l] = nJjcafkkXWkztLxvBOhRsyOtIIMW(1) == 1;
				}
			}
			else
			{
				for (int m = 0; m < 16; m++)
				{
					WJTCScASGJaAMYRLiANAKHblvVep[k * 16 + m] = false;
				}
			}
		}
		phAbDIKSTndJbPQkmBAhAZOdrZNoc();
		int num = tQtXjtSNoifumqdiLgPUhAuAJjDNA + 2;
		int num2 = nJjcafkkXWkztLxvBOhRsyOtIIMW(3);
		int num3 = nJjcafkkXWkztLxvBOhRsyOtIIMW(15);
		for (int n = 0; n < num3; n++)
		{
			int num4 = 0;
			while (nJjcafkkXWkztLxvBOhRsyOtIIMW(1) == 1)
			{
				num4++;
			}
			HLlqQetIguswClpYBFmvMxanYBAB[n] = (byte)num4;
		}
		byte[] array3 = new byte[6];
		for (int num5 = 0; num5 < num2; num5++)
		{
			array3[num5] = (byte)num5;
		}
		for (int num6 = 0; num6 < num3; num6++)
		{
			int num7 = HLlqQetIguswClpYBFmvMxanYBAB[num6];
			byte b = array3[num7];
			while (num7 > 0)
			{
				array3[num7] = array3[num7 - 1];
				num7--;
			}
			array3[0] = b;
			IXcIBuUUdlRGZcrgjUHPaJMukgPK[num6] = b;
		}
		for (int num8 = 0; num8 < num2; num8++)
		{
			int num9 = nJjcafkkXWkztLxvBOhRsyOtIIMW(5);
			for (int num10 = 0; num10 < num; num10++)
			{
				while (nJjcafkkXWkztLxvBOhRsyOtIIMW(1) == 1)
				{
					num9 = ((nJjcafkkXWkztLxvBOhRsyOtIIMW(1) == 0) ? (num9 + 1) : (num9 - 1));
				}
				array[num8][num10] = (char)num9;
			}
		}
		for (int num11 = 0; num11 < num2; num11++)
		{
			int num12 = 32;
			int num13 = 0;
			for (int num14 = 0; num14 < num; num14++)
			{
				num13 = Math.Max(num13, array[num11][num14]);
				num12 = Math.Min(num12, array[num11][num14]);
			}
			HxCVbtQHUbHIgzktivzIDucgmdHF(eMPdNwNBKojabEPjTnmnJDdJVzxo[num11], HgjWDRHfHxGPZQnWGDWGCCwMTerQA[num11], iZUqIeWxiasaIVquELDhwYMipVRl[num11], array[num11], num12, num13, num);
			BumZnVZHNudIwfCtZAGFsYCJqIYPA[num11] = num12;
		}
	}

	private void DAHfySLRwNFKHDrvyJBOgtPbOGGgc()
	{
		byte[] array = new byte[256];
		int num = 100000 * sZgxSfYAUAnyelhwLZStXVttsNlD;
		sfpCkskMhymSQOTKbVdlrYHaVrRF = ExZgffgDMJkTKfSEfxmRjgyDgdvQA(24);
		ankJRBlwcZWTfomKmTdRruwilSgL();
		int num2 = tQtXjtSNoifumqdiLgPUhAuAJjDNA + 1;
		int num3 = -1;
		int num4 = 0;
		for (int i = 0; i <= 255; i++)
		{
			kGMVGApdAqNVFtpwaJNgrKSCfmQJ[i] = 0;
		}
		for (int j = 0; j <= 255; j++)
		{
			array[j] = (byte)j;
		}
		kiondpinEzQabZwUucVyiXrfkoSi = -1;
		if (num4 == 0)
		{
			num3++;
			num4 = 50;
		}
		num4--;
		int num5 = IXcIBuUUdlRGZcrgjUHPaJMukgPK[num3];
		int num6 = BumZnVZHNudIwfCtZAGFsYCJqIYPA[num5];
		int num7 = nJjcafkkXWkztLxvBOhRsyOtIIMW(num6);
		while (true)
		{
			if (num7 > eMPdNwNBKojabEPjTnmnJDdJVzxo[num5][num6])
			{
				if (num6 > 20)
				{
					break;
				}
				num6++;
				while (XgunpNknGoBMgdBeWGHZUzxXYQmVA < 1)
				{
					fRjIxpaLGCwsLTdUStEvpMOvLlCo();
				}
				int num8 = (sYcomjKCwLDiLDMZJtTdAWTPdeCmA >> XgunpNknGoBMgdBeWGHZUzxXYQmVA - 1) & 1;
				XgunpNknGoBMgdBeWGHZUzxXYQmVA--;
				num7 = (num7 << 1) | num8;
				continue;
			}
			if (num7 - HgjWDRHfHxGPZQnWGDWGCCwMTerQA[num5][num6] >= 0 && num7 - HgjWDRHfHxGPZQnWGDWGCCwMTerQA[num5][num6] < 258)
			{
				int num9 = iZUqIeWxiasaIVquELDhwYMipVRl[num5][num7 - HgjWDRHfHxGPZQnWGDWGCCwMTerQA[num5][num6]];
				while (num9 != num2)
				{
					if (num9 != 0 && num9 != 1)
					{
						kiondpinEzQabZwUucVyiXrfkoSi++;
						if (kiondpinEzQabZwUucVyiXrfkoSi >= num)
						{
							fvQCgCafHJhAYbDGfqZYAVMDedoYB();
						}
						byte b = array[num9 - 1];
						kGMVGApdAqNVFtpwaJNgrKSCfmQJ[EFdwufFphqDVTLqqjbNnyhvOAgBz[b]]++;
						YzBRIVUxaJVmjEDtROkGJXZIcLMW[kiondpinEzQabZwUucVyiXrfkoSi] = EFdwufFphqDVTLqqjbNnyhvOAgBz[b];
						for (int num10 = num9 - 1; num10 > 0; num10--)
						{
							array[num10] = array[num10 - 1];
						}
						array[0] = b;
						if (num4 == 0)
						{
							num3++;
							num4 = 50;
						}
						num4--;
						num5 = IXcIBuUUdlRGZcrgjUHPaJMukgPK[num3];
						num6 = BumZnVZHNudIwfCtZAGFsYCJqIYPA[num5];
						num7 = nJjcafkkXWkztLxvBOhRsyOtIIMW(num6);
						while (num7 > eMPdNwNBKojabEPjTnmnJDdJVzxo[num5][num6])
						{
							num6++;
							while (XgunpNknGoBMgdBeWGHZUzxXYQmVA < 1)
							{
								fRjIxpaLGCwsLTdUStEvpMOvLlCo();
							}
							int num8 = (sYcomjKCwLDiLDMZJtTdAWTPdeCmA >> XgunpNknGoBMgdBeWGHZUzxXYQmVA - 1) & 1;
							XgunpNknGoBMgdBeWGHZUzxXYQmVA--;
							num7 = (num7 << 1) | num8;
						}
						num9 = iZUqIeWxiasaIVquELDhwYMipVRl[num5][num7 - HgjWDRHfHxGPZQnWGDWGCCwMTerQA[num5][num6]];
						continue;
					}
					int num11 = -1;
					int num12 = 1;
					do
					{
						if (num9 != 0)
						{
							if (num9 == 1)
							{
								num11 += 2 * num12;
							}
						}
						else
						{
							num11 += num12;
						}
						num12 <<= 1;
						if (num4 == 0)
						{
							num3++;
							num4 = 50;
						}
						num4--;
						num5 = IXcIBuUUdlRGZcrgjUHPaJMukgPK[num3];
						num6 = BumZnVZHNudIwfCtZAGFsYCJqIYPA[num5];
						num7 = nJjcafkkXWkztLxvBOhRsyOtIIMW(num6);
						while (num7 > eMPdNwNBKojabEPjTnmnJDdJVzxo[num5][num6])
						{
							num6++;
							while (XgunpNknGoBMgdBeWGHZUzxXYQmVA < 1)
							{
								fRjIxpaLGCwsLTdUStEvpMOvLlCo();
							}
							int num8 = (sYcomjKCwLDiLDMZJtTdAWTPdeCmA >> XgunpNknGoBMgdBeWGHZUzxXYQmVA - 1) & 1;
							XgunpNknGoBMgdBeWGHZUzxXYQmVA--;
							num7 = (num7 << 1) | num8;
						}
						num9 = iZUqIeWxiasaIVquELDhwYMipVRl[num5][num7 - HgjWDRHfHxGPZQnWGDWGCCwMTerQA[num5][num6]];
					}
					while (num9 == 0 || num9 == 1);
					num11++;
					byte b2 = EFdwufFphqDVTLqqjbNnyhvOAgBz[array[0]];
					kGMVGApdAqNVFtpwaJNgrKSCfmQJ[b2] += num11;
					while (num11 > 0)
					{
						kiondpinEzQabZwUucVyiXrfkoSi++;
						YzBRIVUxaJVmjEDtROkGJXZIcLMW[kiondpinEzQabZwUucVyiXrfkoSi] = b2;
						num11--;
					}
					if (kiondpinEzQabZwUucVyiXrfkoSi >= num)
					{
						fvQCgCafHJhAYbDGfqZYAVMDedoYB();
					}
				}
				return;
			}
			throw new BZip2Exception("Bzip data error");
		}
		throw new BZip2Exception("Bzip data error");
	}

	private void BrXHbNIfkbNWpgxaVzqKyaMMcSQb()
	{
		int[] array = new int[257];
		array[0] = 0;
		Array.Copy(kGMVGApdAqNVFtpwaJNgrKSCfmQJ, 0, array, 1, 256);
		for (int i = 1; i <= 256; i++)
		{
			array[i] += array[i - 1];
		}
		for (int j = 0; j <= kiondpinEzQabZwUucVyiXrfkoSi; j++)
		{
			byte b = YzBRIVUxaJVmjEDtROkGJXZIcLMW[j];
			HwALclJnmKEhvJkyEQoZKjdhqbRWA[array[b]] = j;
			array[b]++;
		}
		hyxHdfesKkjkGdLctPALLjInnIhE = HwALclJnmKEhvJkyEQoZKjdhqbRWA[sfpCkskMhymSQOTKbVdlrYHaVrRF];
		MLVOROAbOXETfTvfiJujIrPTKFKn = 0;
		UtCINLvDbBxPoKhwgLqnyqcCzgDj = 0;
		dOvLMdEnpwinlAusVqzbBezROZEo = 256;
		if (!hqbwIvdQbrNrqztnvgfUOMSZzaem)
		{
			uvVZfJfhlmrDeJRhvZhAerFUxqFg();
			return;
		}
		sjVZcXBSxbaLJcPRIwbqeOypSBPT = 0;
		VtRqnPNtGIPQOwIlxJucIlgEQiqK = 0;
		jAszLOzaLLcxyPsbbIVJNBQMKyWN();
	}

	private void jAszLOzaLLcxyPsbbIVJNBQMKyWN()
	{
		if (UtCINLvDbBxPoKhwgLqnyqcCzgDj <= kiondpinEzQabZwUucVyiXrfkoSi)
		{
			yjWKyupdIeEAAiowswLMUrHuqfnKA = dOvLMdEnpwinlAusVqzbBezROZEo;
			dOvLMdEnpwinlAusVqzbBezROZEo = YzBRIVUxaJVmjEDtROkGJXZIcLMW[hyxHdfesKkjkGdLctPALLjInnIhE];
			hyxHdfesKkjkGdLctPALLjInnIhE = HwALclJnmKEhvJkyEQoZKjdhqbRWA[hyxHdfesKkjkGdLctPALLjInnIhE];
			if (sjVZcXBSxbaLJcPRIwbqeOypSBPT == 0)
			{
				sjVZcXBSxbaLJcPRIwbqeOypSBPT = pRwYMkIAnTEhcZFjkhDZpfhHBJxCA.nfpaSxpzdvbZBhJWdJgHgYQptFur[VtRqnPNtGIPQOwIlxJucIlgEQiqK];
				VtRqnPNtGIPQOwIlxJucIlgEQiqK++;
				if (VtRqnPNtGIPQOwIlxJucIlgEQiqK == 512)
				{
					VtRqnPNtGIPQOwIlxJucIlgEQiqK = 0;
				}
			}
			sjVZcXBSxbaLJcPRIwbqeOypSBPT--;
			dOvLMdEnpwinlAusVqzbBezROZEo ^= ((sjVZcXBSxbaLJcPRIwbqeOypSBPT == 1) ? 1 : 0);
			UtCINLvDbBxPoKhwgLqnyqcCzgDj++;
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = dOvLMdEnpwinlAusVqzbBezROZEo;
			tkcYjskPNFudsogyhBIonVKpjivs = 3;
			LhlEXUmBlhGoplOFyZirAzSUloCs.Update(dOvLMdEnpwinlAusVqzbBezROZEo);
		}
		else
		{
			eUlCvHxhzeHzmmgZxTJuaRpPXSUJ();
			buSvorTwXYqUASLaIqeZxBDzfqmb();
			BrXHbNIfkbNWpgxaVzqKyaMMcSQb();
		}
	}

	private void uvVZfJfhlmrDeJRhvZhAerFUxqFg()
	{
		if (UtCINLvDbBxPoKhwgLqnyqcCzgDj <= kiondpinEzQabZwUucVyiXrfkoSi)
		{
			yjWKyupdIeEAAiowswLMUrHuqfnKA = dOvLMdEnpwinlAusVqzbBezROZEo;
			dOvLMdEnpwinlAusVqzbBezROZEo = YzBRIVUxaJVmjEDtROkGJXZIcLMW[hyxHdfesKkjkGdLctPALLjInnIhE];
			hyxHdfesKkjkGdLctPALLjInnIhE = HwALclJnmKEhvJkyEQoZKjdhqbRWA[hyxHdfesKkjkGdLctPALLjInnIhE];
			UtCINLvDbBxPoKhwgLqnyqcCzgDj++;
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = dOvLMdEnpwinlAusVqzbBezROZEo;
			tkcYjskPNFudsogyhBIonVKpjivs = 6;
			LhlEXUmBlhGoplOFyZirAzSUloCs.Update(dOvLMdEnpwinlAusVqzbBezROZEo);
		}
		else
		{
			eUlCvHxhzeHzmmgZxTJuaRpPXSUJ();
			buSvorTwXYqUASLaIqeZxBDzfqmb();
			BrXHbNIfkbNWpgxaVzqKyaMMcSQb();
		}
	}

	private void CVfKkhWHahQQAuEeUtKqlNedzsuO()
	{
		if (dOvLMdEnpwinlAusVqzbBezROZEo != yjWKyupdIeEAAiowswLMUrHuqfnKA)
		{
			tkcYjskPNFudsogyhBIonVKpjivs = 2;
			MLVOROAbOXETfTvfiJujIrPTKFKn = 1;
			jAszLOzaLLcxyPsbbIVJNBQMKyWN();
			return;
		}
		MLVOROAbOXETfTvfiJujIrPTKFKn++;
		if (MLVOROAbOXETfTvfiJujIrPTKFKn < 4)
		{
			tkcYjskPNFudsogyhBIonVKpjivs = 2;
			jAszLOzaLLcxyPsbbIVJNBQMKyWN();
			return;
		}
		XOFiuGduWMSCCYHcOtpXwynzgrnH = YzBRIVUxaJVmjEDtROkGJXZIcLMW[hyxHdfesKkjkGdLctPALLjInnIhE];
		hyxHdfesKkjkGdLctPALLjInnIhE = HwALclJnmKEhvJkyEQoZKjdhqbRWA[hyxHdfesKkjkGdLctPALLjInnIhE];
		if (sjVZcXBSxbaLJcPRIwbqeOypSBPT == 0)
		{
			sjVZcXBSxbaLJcPRIwbqeOypSBPT = pRwYMkIAnTEhcZFjkhDZpfhHBJxCA.nfpaSxpzdvbZBhJWdJgHgYQptFur[VtRqnPNtGIPQOwIlxJucIlgEQiqK];
			VtRqnPNtGIPQOwIlxJucIlgEQiqK++;
			if (VtRqnPNtGIPQOwIlxJucIlgEQiqK == 512)
			{
				VtRqnPNtGIPQOwIlxJucIlgEQiqK = 0;
			}
		}
		sjVZcXBSxbaLJcPRIwbqeOypSBPT--;
		XOFiuGduWMSCCYHcOtpXwynzgrnH ^= ((sjVZcXBSxbaLJcPRIwbqeOypSBPT == 1) ? ((byte)1) : ((byte)0));
		uqzdWddaKDfBaLRIDlKyKrscTzgn = 0;
		tkcYjskPNFudsogyhBIonVKpjivs = 4;
		URHehHcSzWIJfpjgGXMsJKTOOPkFA();
	}

	private void URHehHcSzWIJfpjgGXMsJKTOOPkFA()
	{
		if (uqzdWddaKDfBaLRIDlKyKrscTzgn < XOFiuGduWMSCCYHcOtpXwynzgrnH)
		{
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = dOvLMdEnpwinlAusVqzbBezROZEo;
			LhlEXUmBlhGoplOFyZirAzSUloCs.Update(dOvLMdEnpwinlAusVqzbBezROZEo);
			uqzdWddaKDfBaLRIDlKyKrscTzgn++;
		}
		else
		{
			tkcYjskPNFudsogyhBIonVKpjivs = 2;
			UtCINLvDbBxPoKhwgLqnyqcCzgDj++;
			MLVOROAbOXETfTvfiJujIrPTKFKn = 0;
			jAszLOzaLLcxyPsbbIVJNBQMKyWN();
		}
	}

	private void VdmuhKcyeCaUXiaaDbaYoYMnzWXk()
	{
		if (dOvLMdEnpwinlAusVqzbBezROZEo != yjWKyupdIeEAAiowswLMUrHuqfnKA)
		{
			tkcYjskPNFudsogyhBIonVKpjivs = 5;
			MLVOROAbOXETfTvfiJujIrPTKFKn = 1;
			uvVZfJfhlmrDeJRhvZhAerFUxqFg();
			return;
		}
		MLVOROAbOXETfTvfiJujIrPTKFKn++;
		if (MLVOROAbOXETfTvfiJujIrPTKFKn < 4)
		{
			tkcYjskPNFudsogyhBIonVKpjivs = 5;
			uvVZfJfhlmrDeJRhvZhAerFUxqFg();
			return;
		}
		XOFiuGduWMSCCYHcOtpXwynzgrnH = YzBRIVUxaJVmjEDtROkGJXZIcLMW[hyxHdfesKkjkGdLctPALLjInnIhE];
		hyxHdfesKkjkGdLctPALLjInnIhE = HwALclJnmKEhvJkyEQoZKjdhqbRWA[hyxHdfesKkjkGdLctPALLjInnIhE];
		tkcYjskPNFudsogyhBIonVKpjivs = 7;
		uqzdWddaKDfBaLRIDlKyKrscTzgn = 0;
		LWuVVTTEAzidtEItGPmPvilRwYYqA();
	}

	private void LWuVVTTEAzidtEItGPmPvilRwYYqA()
	{
		if (uqzdWddaKDfBaLRIDlKyKrscTzgn < XOFiuGduWMSCCYHcOtpXwynzgrnH)
		{
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = dOvLMdEnpwinlAusVqzbBezROZEo;
			LhlEXUmBlhGoplOFyZirAzSUloCs.Update(dOvLMdEnpwinlAusVqzbBezROZEo);
			uqzdWddaKDfBaLRIDlKyKrscTzgn++;
		}
		else
		{
			tkcYjskPNFudsogyhBIonVKpjivs = 5;
			UtCINLvDbBxPoKhwgLqnyqcCzgDj++;
			MLVOROAbOXETfTvfiJujIrPTKFKn = 0;
			uvVZfJfhlmrDeJRhvZhAerFUxqFg();
		}
	}

	private void WKKHUrZuUCsbArGLUpdwykwhsKXi(int newSize100k)
	{
		if (0 <= newSize100k && newSize100k <= 9 && 0 <= sZgxSfYAUAnyelhwLZStXVttsNlD && sZgxSfYAUAnyelhwLZStXVttsNlD <= 9)
		{
			sZgxSfYAUAnyelhwLZStXVttsNlD = newSize100k;
			if (newSize100k != 0)
			{
				int num = 100000 * newSize100k;
				YzBRIVUxaJVmjEDtROkGJXZIcLMW = new byte[num];
				HwALclJnmKEhvJkyEQoZKjdhqbRWA = new int[num];
			}
			return;
		}
		throw new BZip2Exception("Invalid block size");
	}

	private static void TahiWgjRcmASCzYHiqQdnFsUJMuf()
	{
		throw new EndOfStreamException("BZip2 input stream end of compressed stream");
	}

	private static void fvQCgCafHJhAYbDGfqZYAVMDedoYB()
	{
		throw new BZip2Exception("BZip2 input stream block overrun");
	}

	private static void MlnkEgjlSZHgrXMvRmWwQUHFDmmN()
	{
		throw new BZip2Exception("BZip2 input stream bad block header");
	}

	private static void oJxYDVHPeZXCcSNRJhHOaACpXOQT()
	{
		throw new BZip2Exception("BZip2 input stream crc error");
	}

	private static void HxCVbtQHUbHIgzktivzIDucgmdHF(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
	{
		int num = 0;
		for (int i = minLen; i <= maxLen; i++)
		{
			for (int j = 0; j < alphaSize; j++)
			{
				if (length[j] == i)
				{
					perm[num] = j;
					num++;
				}
			}
		}
		for (int k = 0; k < 23; k++)
		{
			baseArray[k] = 0;
		}
		for (int l = 0; l < alphaSize; l++)
		{
			baseArray[length[l] + 1]++;
		}
		for (int m = 1; m < 23; m++)
		{
			baseArray[m] += baseArray[m - 1];
		}
		for (int n = 0; n < 23; n++)
		{
			limit[n] = 0;
		}
		int num2 = 0;
		for (int num3 = minLen; num3 <= maxLen; num3++)
		{
			num2 += baseArray[num3 + 1] - baseArray[num3];
			limit[num3] = num2 - 1;
			num2 <<= 1;
		}
		for (int num4 = minLen + 1; num4 <= maxLen; num4++)
		{
			baseArray[num4] = (limit[num4 - 1] + 1 << 1) - baseArray[num4];
		}
	}
}
