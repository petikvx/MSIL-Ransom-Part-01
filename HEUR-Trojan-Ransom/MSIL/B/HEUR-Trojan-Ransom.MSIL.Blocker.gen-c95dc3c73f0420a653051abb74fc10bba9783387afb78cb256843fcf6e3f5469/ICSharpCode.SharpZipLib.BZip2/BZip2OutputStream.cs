using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.BZip2;

public class BZip2OutputStream : Stream
{
	private struct NPoBmdqVOHgyifPYhJjuUxtQEuWPA
	{
		public int HwALclJnmKEhvJkyEQoZKjdhqbRWA;

		public int dOvLMdEnpwinlAusVqzbBezROZEo;

		public int UtCINLvDbBxPoKhwgLqnyqcCzgDj;
	}

	private int QnPyFeLfyqIhIIOnOmPzzQYYexpf;

	private Stream ZZbXkWNbEgTXEBDIabDhSGsvFVVF;

	private byte[] pkXETbftTbFbDtzujsuZzsRbxUcS;

	private uint BbQeuLWwaesMwomBJEVtbqMPyYlcA;

	private bool hqbwIvdQbrNrqztnvgfUOMSZzaem;

	private int sZgxSfYAUAnyelhwLZStXVttsNlD;

	private int sYcomjKCwLDiLDMZJtTdAWTPdeCmA;

	private int XgunpNknGoBMgdBeWGHZUzxXYQmVA;

	private int StBStlTgPfoodkyEMUeLrijuCOMgA;

	private const int EIqEFlgAuCgrsiNYDWpGfhkzTCGO = -2097153;

	private uint WetFTVPQLqRZONhItWMMtKYazRyO;

	private int MTtlOaSLQrBDxDzkNPPhamSQOXLrA;

	private const int QKaLrZoLyWvKIbWUjfmxqpeSibyd = 10;

	private bool OjnrIXIVHzBOOTJQCEKUPSBGbcxE;

	private bool RYuQfZkjLGCKYsQvQSwZBDKlbaSW;

	private int[] DbvmXoRMYnEwBLsFpcUQRIdsLxJH;

	private const int vfGPfrBrxbWSCPMKTJkahRxrYjCj = 15;

	private readonly int[] EjdREjfkudToTpTBLMGqmBaudnK;

	private bool[] WJTCScASGJaAMYRLiANAKHblvVep;

	private bool wLAMyKxDbSSzQUvMyMwOQVxXsyqm;

	private int kiondpinEzQabZwUucVyiXrfkoSi;

	private const int byeClxWLtrtzXjCHGnrPYVVwqsFF = 0;

	private IChecksum LhlEXUmBlhGoplOFyZirAzSUloCs;

	private int[] JRoLBMhXAhDcMaeeqrLeJYBAlNme;

	private int JUvhUoRPnQANEIdKBYGfANjVGtBfA;

	private int tQtXjtSNoifumqdiLgPUhAuAJjDNA;

	private int OghhmIBNMvBTbOGpZXyuoxHIEBdJ;

	private int sfpCkskMhymSQOTKbVdlrYHaVrRF;

	private const int xMVabdCFFBMZcOHskSRSEAFgSxMO = 1000;

	private int[] fiGDJvVPWXBPrTtNjCdheEOwlwwKA;

	private int vWsfQyutgDTxHdnlsNQuuqOYXSDq;

	private char[] IXcIBuUUdlRGZcrgjUHPaJMukgPK;

	private char[] HLlqQetIguswClpYBFmvMxanYBAB;

	private char[] EFdwufFphqDVTLqqjbNnyhvOAgBz;

	private const int mpoMTMtjdRMUrvIBeDDtElznEZQt = 2097152;

	private const int USxAPpMsADFxNVdeQGGKXHPufgDQ = 20;

	private short[] mqgHnWZkJvMCmFMkSldZVxcxEbxO;

	private char[] HYGdcsrlybOhhRFOTlBLFZwDTROJ;

	private int SnUYgXgZtYeVBzNWLvYFcJlgIDeU;

	private int JIEguBlduWEZHlMUMFhetsdqTlix;

	private int pfLXuMbyTcGiXZFhKjlMHAryNcwj;

	private int[] XDikxKdtGEtmJQDoaUKQCLOBxzhC;

	public int BytesWritten => StBStlTgPfoodkyEMUeLrijuCOMgA;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => ZZbXkWNbEgTXEBDIabDhSGsvFVVF.CanWrite;

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

	public override long Length => ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Length;

	public override long Position
	{
		get
		{
			return ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Position;
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
		EjdREjfkudToTpTBLMGqmBaudnK = new int[14]
		{
			1, 4, 13, 40, 121, 364, 1093, 3280, 9841, 29524,
			88573, 265720, 797161, 2391484
		};
		wLAMyKxDbSSzQUvMyMwOQVxXsyqm = true;
		LhlEXUmBlhGoplOFyZirAzSUloCs = new StrangeCRC();
		WJTCScASGJaAMYRLiANAKHblvVep = new bool[256];
		EFdwufFphqDVTLqqjbNnyhvOAgBz = new char[256];
		HYGdcsrlybOhhRFOTlBLFZwDTROJ = new char[256];
		IXcIBuUUdlRGZcrgjUHPaJMukgPK = new char[18002];
		HLlqQetIguswClpYBFmvMxanYBAB = new char[18002];
		JRoLBMhXAhDcMaeeqrLeJYBAlNme = new int[258];
		MTtlOaSLQrBDxDzkNPPhamSQOXLrA = -1;
		gTcfBmdLPIvSaeGrrkVKZnraHzMF(stream);
		JIEguBlduWEZHlMUMFhetsdqTlix = 50;
		if (blockSize > 9)
		{
			blockSize = 9;
		}
		if (blockSize < 1)
		{
			blockSize = 1;
		}
		sZgxSfYAUAnyelhwLZStXVttsNlD = blockSize;
		pKOdbyAkDFGcGwhlbUpeUOLtjRHNA();
		JmoPVjxnELOhezgyyasePmQDdcem();
		buSvorTwXYqUASLaIqeZxBDzfqmb();
	}

	private void pKOdbyAkDFGcGwhlbUpeUOLtjRHNA()
	{
		int num = 100000 * sZgxSfYAUAnyelhwLZStXVttsNlD;
		pkXETbftTbFbDtzujsuZzsRbxUcS = new byte[num + 1 + 20];
		fiGDJvVPWXBPrTtNjCdheEOwlwwKA = new int[num + 20];
		XDikxKdtGEtmJQDoaUKQCLOBxzhC = new int[num];
		DbvmXoRMYnEwBLsFpcUQRIdsLxJH = new int[65537];
		if (pkXETbftTbFbDtzujsuZzsRbxUcS == null || fiGDJvVPWXBPrTtNjCdheEOwlwwKA == null)
		{
		}
		mqgHnWZkJvMCmFMkSldZVxcxEbxO = new short[2 * num];
	}

	private void RAjISqkvwdttXfSNmuEJfTdechkhb()
	{
		while (XgunpNknGoBMgdBeWGHZUzxXYQmVA > 0)
		{
			int num = sYcomjKCwLDiLDMZJtTdAWTPdeCmA >> 24;
			ZZbXkWNbEgTXEBDIabDhSGsvFVVF.WriteByte((byte)num);
			sYcomjKCwLDiLDMZJtTdAWTPdeCmA <<= 8;
			XgunpNknGoBMgdBeWGHZUzxXYQmVA -= 8;
			StBStlTgPfoodkyEMUeLrijuCOMgA++;
		}
	}

	private void joxHuDUMlrqgbUkIFCsiIdChoJRbb(int int_0)
	{
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(8, (int_0 >> 24) & 0xFF);
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(8, (int_0 >> 16) & 0xFF);
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(8, (int_0 >> 8) & 0xFF);
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(8, int_0 & 0xFF);
	}

	private void SvEXvVqnoZtYyWgHNwWgnCAnJmWd(int numBits, int int_0)
	{
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(numBits, int_0);
	}

	private void JpwECZRXuWHFSiNCojMeAHuKJRop(int int_0)
	{
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(8, int_0);
	}

	private void gTcfBmdLPIvSaeGrrkVKZnraHzMF(Stream stream)
	{
		ZZbXkWNbEgTXEBDIabDhSGsvFVVF = stream;
		XgunpNknGoBMgdBeWGHZUzxXYQmVA = 0;
		sYcomjKCwLDiLDMZJtTdAWTPdeCmA = 0;
		StBStlTgPfoodkyEMUeLrijuCOMgA = 0;
	}

	private void ggfptZZvCYwCUsDNybOaLgiCBRIcA(int int_0, int int_1)
	{
		while (XgunpNknGoBMgdBeWGHZUzxXYQmVA >= 8)
		{
			int num = sYcomjKCwLDiLDMZJtTdAWTPdeCmA >> 24;
			ZZbXkWNbEgTXEBDIabDhSGsvFVVF.WriteByte((byte)num);
			sYcomjKCwLDiLDMZJtTdAWTPdeCmA <<= 8;
			XgunpNknGoBMgdBeWGHZUzxXYQmVA -= 8;
			StBStlTgPfoodkyEMUeLrijuCOMgA++;
		}
		sYcomjKCwLDiLDMZJtTdAWTPdeCmA |= int_1 << 32 - XgunpNknGoBMgdBeWGHZUzxXYQmVA - int_0;
		XgunpNknGoBMgdBeWGHZUzxXYQmVA += int_0;
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
			if (!OjnrIXIVHzBOOTJQCEKUPSBGbcxE)
			{
				OjnrIXIVHzBOOTJQCEKUPSBGbcxE = true;
				if (vWsfQyutgDTxHdnlsNQuuqOYXSDq > 0)
				{
					gpCBoidyLoCTRDabCatBNPrHOdKub();
				}
				MTtlOaSLQrBDxDzkNPPhamSQOXLrA = -1;
				eUlCvHxhzeHzmmgZxTJuaRpPXSUJ();
				xDDeOQntpYOZQssNQSAipuEEJmlH();
				Flush();
			}
		}
		finally
		{
			if (disposing && IsStreamOwner)
			{
				ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Close();
			}
		}
	}

	private void aHDiGgHRROIEkoCigOAYsKNecNhX()
	{
		pfLXuMbyTcGiXZFhKjlMHAryNcwj = JIEguBlduWEZHlMUMFhetsdqTlix * kiondpinEzQabZwUucVyiXrfkoSi;
		SnUYgXgZtYeVBzNWLvYFcJlgIDeU = 0;
		hqbwIvdQbrNrqztnvgfUOMSZzaem = false;
		RYuQfZkjLGCKYsQvQSwZBDKlbaSW = true;
		XxWiTrckMevKWhwqisKzlJPLwZBJ();
		if (SnUYgXgZtYeVBzNWLvYFcJlgIDeU > pfLXuMbyTcGiXZFhKjlMHAryNcwj && RYuQfZkjLGCKYsQvQSwZBDKlbaSW)
		{
			EddbKloPjqgnIyLsCAMmIEVvFTCCb();
			SnUYgXgZtYeVBzNWLvYFcJlgIDeU = 0;
			pfLXuMbyTcGiXZFhKjlMHAryNcwj = 0;
			hqbwIvdQbrNrqztnvgfUOMSZzaem = true;
			RYuQfZkjLGCKYsQvQSwZBDKlbaSW = false;
			XxWiTrckMevKWhwqisKzlJPLwZBJ();
		}
		sfpCkskMhymSQOTKbVdlrYHaVrRF = -1;
		for (int i = 0; i <= kiondpinEzQabZwUucVyiXrfkoSi; i++)
		{
			if (XDikxKdtGEtmJQDoaUKQCLOBxzhC[i] == 0)
			{
				sfpCkskMhymSQOTKbVdlrYHaVrRF = i;
				break;
			}
		}
		if (sfpCkskMhymSQOTKbVdlrYHaVrRF == -1)
		{
			hiPLQJyBqaAdLrzaNBelpArKdVOAA();
		}
	}

	private void eUlCvHxhzeHzmmgZxTJuaRpPXSUJ()
	{
		if (kiondpinEzQabZwUucVyiXrfkoSi >= 0)
		{
			BbQeuLWwaesMwomBJEVtbqMPyYlcA = (uint)LhlEXUmBlhGoplOFyZirAzSUloCs.Value;
			WetFTVPQLqRZONhItWMMtKYazRyO = (WetFTVPQLqRZONhItWMMtKYazRyO << 1) | (WetFTVPQLqRZONhItWMMtKYazRyO >> 31);
			WetFTVPQLqRZONhItWMMtKYazRyO ^= BbQeuLWwaesMwomBJEVtbqMPyYlcA;
			aHDiGgHRROIEkoCigOAYsKNecNhX();
			JpwECZRXuWHFSiNCojMeAHuKJRop(49);
			JpwECZRXuWHFSiNCojMeAHuKJRop(65);
			JpwECZRXuWHFSiNCojMeAHuKJRop(89);
			JpwECZRXuWHFSiNCojMeAHuKJRop(38);
			JpwECZRXuWHFSiNCojMeAHuKJRop(83);
			JpwECZRXuWHFSiNCojMeAHuKJRop(89);
			joxHuDUMlrqgbUkIFCsiIdChoJRbb((int)BbQeuLWwaesMwomBJEVtbqMPyYlcA);
			if (!hqbwIvdQbrNrqztnvgfUOMSZzaem)
			{
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 0);
			}
			else
			{
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 1);
				JUvhUoRPnQANEIdKBYGfANjVGtBfA++;
			}
			KTPcKUDZNATxJhjbrWPgmiUtJBsDb();
		}
	}

	private void xDDeOQntpYOZQssNQSAipuEEJmlH()
	{
		JpwECZRXuWHFSiNCojMeAHuKJRop(23);
		JpwECZRXuWHFSiNCojMeAHuKJRop(114);
		JpwECZRXuWHFSiNCojMeAHuKJRop(69);
		JpwECZRXuWHFSiNCojMeAHuKJRop(56);
		JpwECZRXuWHFSiNCojMeAHuKJRop(80);
		JpwECZRXuWHFSiNCojMeAHuKJRop(144);
		joxHuDUMlrqgbUkIFCsiIdChoJRbb((int)WetFTVPQLqRZONhItWMMtKYazRyO);
		RAjISqkvwdttXfSNmuEJfTdechkhb();
	}

	~BZip2OutputStream()
	{
		Dispose(disposing: false);
	}

	public override void Flush()
	{
		ZZbXkWNbEgTXEBDIabDhSGsvFVVF.Flush();
	}

	private bool tNfpuDGeeWjEPHCXNFjtBXSBfrqRb(int int_0, int int_1)
	{
		byte b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
		byte b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
		if (b == b2)
		{
			int_0++;
			int_1++;
			b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
			b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
			if (b == b2)
			{
				int_0++;
				int_1++;
				b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
				b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
				if (b != b2)
				{
					return b > b2;
				}
				int_0++;
				int_1++;
				b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
				b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
				if (b != b2)
				{
					return b > b2;
				}
				int_0++;
				int_1++;
				b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
				b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
				if (b != b2)
				{
					return b > b2;
				}
				int_0++;
				int_1++;
				b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
				b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
				if (b == b2)
				{
					int_0++;
					int_1++;
					int num = kiondpinEzQabZwUucVyiXrfkoSi + 1;
					while (true)
					{
						b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
						b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
						if (b == b2)
						{
							int num2 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_0];
							int num3 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_1];
							if (num2 == num3)
							{
								int_0++;
								int_1++;
								b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
								b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
								if (b != b2)
								{
									break;
								}
								num2 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_0];
								num3 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_1];
								if (num2 == num3)
								{
									int_0++;
									int_1++;
									b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
									b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
									if (b == b2)
									{
										num2 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_0];
										num3 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_1];
										if (num2 == num3)
										{
											int_0++;
											int_1++;
											b = pkXETbftTbFbDtzujsuZzsRbxUcS[int_0 + 1];
											b2 = pkXETbftTbFbDtzujsuZzsRbxUcS[int_1 + 1];
											if (b == b2)
											{
												num2 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_0];
												num3 = fiGDJvVPWXBPrTtNjCdheEOwlwwKA[int_1];
												if (num2 == num3)
												{
													int_0++;
													int_1++;
													if (int_0 > kiondpinEzQabZwUucVyiXrfkoSi)
													{
														int_0 -= kiondpinEzQabZwUucVyiXrfkoSi;
														int_0--;
													}
													if (int_1 > kiondpinEzQabZwUucVyiXrfkoSi)
													{
														int_1 -= kiondpinEzQabZwUucVyiXrfkoSi;
														int_1--;
													}
													num -= 4;
													SnUYgXgZtYeVBzNWLvYFcJlgIDeU++;
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

	private void MkfqjRJfGQHzumObOBgEANxLaaBzA()
	{
		char[] array = new char[256];
		phAbDIKSTndJbPQkmBAhAZOdrZNoc();
		int num = tQtXjtSNoifumqdiLgPUhAuAJjDNA + 1;
		for (int i = 0; i <= num; i++)
		{
			JRoLBMhXAhDcMaeeqrLeJYBAlNme[i] = 0;
		}
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < tQtXjtSNoifumqdiLgPUhAuAJjDNA; i++)
		{
			array[i] = (char)i;
		}
		for (int i = 0; i <= kiondpinEzQabZwUucVyiXrfkoSi; i++)
		{
			char c = HYGdcsrlybOhhRFOTlBLFZwDTROJ[pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[i]]];
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
						if (num5 != 0)
						{
							if (num5 == 1)
							{
								mqgHnWZkJvMCmFMkSldZVxcxEbxO[num2] = 1;
								num2++;
								JRoLBMhXAhDcMaeeqrLeJYBAlNme[1]++;
							}
						}
						else
						{
							mqgHnWZkJvMCmFMkSldZVxcxEbxO[num2] = 0;
							num2++;
							JRoLBMhXAhDcMaeeqrLeJYBAlNme[0]++;
						}
						if (num3 < 2)
						{
							break;
						}
						num3 = (num3 - 2) / 2;
					}
					num3 = 0;
				}
				mqgHnWZkJvMCmFMkSldZVxcxEbxO[num2] = (short)(num4 + 1);
				num2++;
				JRoLBMhXAhDcMaeeqrLeJYBAlNme[num4 + 1]++;
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
				int num5 = num3 % 2;
				if (num5 != 0)
				{
					if (num5 == 1)
					{
						mqgHnWZkJvMCmFMkSldZVxcxEbxO[num2] = 1;
						num2++;
						JRoLBMhXAhDcMaeeqrLeJYBAlNme[1]++;
					}
				}
				else
				{
					mqgHnWZkJvMCmFMkSldZVxcxEbxO[num2] = 0;
					num2++;
					JRoLBMhXAhDcMaeeqrLeJYBAlNme[0]++;
				}
				if (num3 < 2)
				{
					break;
				}
				num3 = (num3 - 2) / 2;
			}
		}
		mqgHnWZkJvMCmFMkSldZVxcxEbxO[num2] = (short)num;
		num2++;
		JRoLBMhXAhDcMaeeqrLeJYBAlNme[num]++;
		OghhmIBNMvBTbOGpZXyuoxHIEBdJ = num2;
	}

	private static void AvphUjViPMKOyuvnNfVClzcDAHFl(int[] code, char[] length, int minLen, int maxLen, int alphaSize)
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

	private static void ZZRdFXVTQtELngTlSTIzBdPXEBdBb(char[] char_0, int[] freq, int alphaSize, int maxLen)
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
				hiPLQJyBqaAdLrzaNBelpArKdVOAA();
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
				hiPLQJyBqaAdLrzaNBelpArKdVOAA();
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

	private void buSvorTwXYqUASLaIqeZxBDzfqmb()
	{
		LhlEXUmBlhGoplOFyZirAzSUloCs.Reset();
		kiondpinEzQabZwUucVyiXrfkoSi = -1;
		for (int i = 0; i < 256; i++)
		{
			WJTCScASGJaAMYRLiANAKHblvVep[i] = false;
		}
		QnPyFeLfyqIhIIOnOmPzzQYYexpf = 100000 * sZgxSfYAUAnyelhwLZStXVttsNlD - 20;
	}

	private void JmoPVjxnELOhezgyyasePmQDdcem()
	{
		StBStlTgPfoodkyEMUeLrijuCOMgA = 0;
		JUvhUoRPnQANEIdKBYGfANjVGtBfA = 0;
		JpwECZRXuWHFSiNCojMeAHuKJRop(66);
		JpwECZRXuWHFSiNCojMeAHuKJRop(90);
		JpwECZRXuWHFSiNCojMeAHuKJRop(104);
		JpwECZRXuWHFSiNCojMeAHuKJRop(48 + sZgxSfYAUAnyelhwLZStXVttsNlD);
		WetFTVPQLqRZONhItWMMtKYazRyO = 0u;
	}

	private void XxWiTrckMevKWhwqisKzlJPLwZBJ()
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		bool[] array3 = new bool[256];
		for (int i = 0; i < 20; i++)
		{
			pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + i + 2] = pkXETbftTbFbDtzujsuZzsRbxUcS[i % (kiondpinEzQabZwUucVyiXrfkoSi + 1) + 1];
		}
		for (int i = 0; i <= kiondpinEzQabZwUucVyiXrfkoSi + 20; i++)
		{
			fiGDJvVPWXBPrTtNjCdheEOwlwwKA[i] = 0;
		}
		pkXETbftTbFbDtzujsuZzsRbxUcS[0] = pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1];
		if (kiondpinEzQabZwUucVyiXrfkoSi < 4000)
		{
			for (int i = 0; i <= kiondpinEzQabZwUucVyiXrfkoSi; i++)
			{
				XDikxKdtGEtmJQDoaUKQCLOBxzhC[i] = i;
			}
			RYuQfZkjLGCKYsQvQSwZBDKlbaSW = false;
			pfLXuMbyTcGiXZFhKjlMHAryNcwj = 0;
			SnUYgXgZtYeVBzNWLvYFcJlgIDeU = 0;
			yLICqBMXRoLXjEgzgaLRFgKSfaCf(0, kiondpinEzQabZwUucVyiXrfkoSi, 0);
			return;
		}
		int num = 0;
		for (int i = 0; i <= 255; i++)
		{
			array3[i] = false;
		}
		for (int i = 0; i <= 65536; i++)
		{
			DbvmXoRMYnEwBLsFpcUQRIdsLxJH[i] = 0;
		}
		int num2 = pkXETbftTbFbDtzujsuZzsRbxUcS[0];
		for (int i = 0; i <= kiondpinEzQabZwUucVyiXrfkoSi; i++)
		{
			int num3 = pkXETbftTbFbDtzujsuZzsRbxUcS[i + 1];
			DbvmXoRMYnEwBLsFpcUQRIdsLxJH[(num2 << 8) + num3]++;
			num2 = num3;
		}
		for (int i = 1; i <= 65536; i++)
		{
			DbvmXoRMYnEwBLsFpcUQRIdsLxJH[i] += DbvmXoRMYnEwBLsFpcUQRIdsLxJH[i - 1];
		}
		num2 = pkXETbftTbFbDtzujsuZzsRbxUcS[1];
		int num4;
		for (int i = 0; i < kiondpinEzQabZwUucVyiXrfkoSi; i++)
		{
			int num3 = pkXETbftTbFbDtzujsuZzsRbxUcS[i + 2];
			num4 = (num2 << 8) + num3;
			num2 = num3;
			DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num4]--;
			XDikxKdtGEtmJQDoaUKQCLOBxzhC[DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num4]] = i;
		}
		num4 = (pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] << 8) + pkXETbftTbFbDtzujsuZzsRbxUcS[1];
		DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num4]--;
		XDikxKdtGEtmJQDoaUKQCLOBxzhC[DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num4]] = kiondpinEzQabZwUucVyiXrfkoSi;
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
				while (DbvmXoRMYnEwBLsFpcUQRIdsLxJH[array[num4 - num5] + 1 << 8] - DbvmXoRMYnEwBLsFpcUQRIdsLxJH[array[num4 - num5] << 8] > DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num6 + 1 << 8] - DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num6 << 8])
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
				if ((DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num8] & 0x200000) == 2097152)
				{
					continue;
				}
				int num9 = DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num8] & -2097153;
				int num10 = (DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num8 + 1] & -2097153) - 1;
				if (num10 > num9)
				{
					xNiuOVQEVXMDHGGEhDgSYWGbdaUG(num9, num10, 2);
					num += num10 - num9 + 1;
					if (SnUYgXgZtYeVBzNWLvYFcJlgIDeU > pfLXuMbyTcGiXZFhKjlMHAryNcwj && RYuQfZkjLGCKYsQvQSwZBDKlbaSW)
					{
						return;
					}
				}
				DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num8] |= 2097152;
			}
			array3[num7] = true;
			if (i < 255)
			{
				int num11 = DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num7 << 8] & -2097153;
				int num12 = (DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num7 + 1 << 8] & -2097153) - num11;
				int j;
				for (j = 0; num12 >> j > 65534; j++)
				{
				}
				for (num4 = 0; num4 < num12; num4++)
				{
					int num13 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num11 + num4];
					int num14 = num4 >> j;
					fiGDJvVPWXBPrTtNjCdheEOwlwwKA[num13] = num14;
					if (num13 < 20)
					{
						fiGDJvVPWXBPrTtNjCdheEOwlwwKA[num13 + kiondpinEzQabZwUucVyiXrfkoSi + 1] = num14;
					}
				}
				if (num12 - 1 >> j > 65535)
				{
					hiPLQJyBqaAdLrzaNBelpArKdVOAA();
				}
			}
			for (num4 = 0; num4 <= 255; num4++)
			{
				array2[num4] = DbvmXoRMYnEwBLsFpcUQRIdsLxJH[(num4 << 8) + num7] & -2097153;
			}
			for (num4 = DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num7 << 8] & -2097153; num4 < (DbvmXoRMYnEwBLsFpcUQRIdsLxJH[num7 + 1 << 8] & -2097153); num4++)
			{
				num2 = pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4]];
				if (!array3[num2])
				{
					XDikxKdtGEtmJQDoaUKQCLOBxzhC[array2[num2]] = ((XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4] == 0) ? kiondpinEzQabZwUucVyiXrfkoSi : (XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4] - 1));
					array2[num2]++;
				}
			}
			for (num4 = 0; num4 <= 255; num4++)
			{
				DbvmXoRMYnEwBLsFpcUQRIdsLxJH[(num4 << 8) + num7] |= 2097152;
			}
		}
	}

	private void phAbDIKSTndJbPQkmBAhAZOdrZNoc()
	{
		tQtXjtSNoifumqdiLgPUhAuAJjDNA = 0;
		for (int i = 0; i < 256; i++)
		{
			if (WJTCScASGJaAMYRLiANAKHblvVep[i])
			{
				EFdwufFphqDVTLqqjbNnyhvOAgBz[tQtXjtSNoifumqdiLgPUhAuAJjDNA] = (char)i;
				HYGdcsrlybOhhRFOTlBLFZwDTROJ[i] = (char)tQtXjtSNoifumqdiLgPUhAuAJjDNA;
				tQtXjtSNoifumqdiLgPUhAuAJjDNA++;
			}
		}
	}

	private static byte OhiihqDNpgiebjUivUjSjJYZekit(byte byte_0, byte byte_1, byte byte_2)
	{
		if (byte_0 > byte_1)
		{
			byte num = byte_0;
			byte_0 = byte_1;
			byte_1 = num;
		}
		if (byte_1 > byte_2)
		{
			byte num2 = byte_1;
			byte_1 = byte_2;
			byte_2 = num2;
		}
		if (byte_0 > byte_1)
		{
			byte_1 = byte_0;
		}
		return byte_1;
	}

	private void KTPcKUDZNATxJhjbrWPgmiUtJBsDb()
	{
		SvEXvVqnoZtYyWgHNwWgnCAnJmWd(24, sfpCkskMhymSQOTKbVdlrYHaVrRF);
		MkfqjRJfGQHzumObOBgEANxLaaBzA();
		TvookakhkzQWjHAIShNUTBtVVwrm();
	}

	private static void hiPLQJyBqaAdLrzaNBelpArKdVOAA()
	{
		throw new BZip2Exception("BZip2 output stream panic");
	}

	private void xNiuOVQEVXMDHGGEhDgSYWGbdaUG(int loSt, int hiSt, int dSt)
	{
		NPoBmdqVOHgyifPYhJjuUxtQEuWPA[] array = new NPoBmdqVOHgyifPYhJjuUxtQEuWPA[1000];
		int num = 0;
		array[0].HwALclJnmKEhvJkyEQoZKjdhqbRWA = loSt;
		array[0].dOvLMdEnpwinlAusVqzbBezROZEo = hiSt;
		array[0].UtCINLvDbBxPoKhwgLqnyqcCzgDj = dSt;
		num = 1;
		while (num > 0)
		{
			if (num >= 1000)
			{
				hiPLQJyBqaAdLrzaNBelpArKdVOAA();
			}
			num--;
			int hwALclJnmKEhvJkyEQoZKjdhqbRWA = array[num].HwALclJnmKEhvJkyEQoZKjdhqbRWA;
			int dOvLMdEnpwinlAusVqzbBezROZEo = array[num].dOvLMdEnpwinlAusVqzbBezROZEo;
			int utCINLvDbBxPoKhwgLqnyqcCzgDj = array[num].UtCINLvDbBxPoKhwgLqnyqcCzgDj;
			if (dOvLMdEnpwinlAusVqzbBezROZEo - hwALclJnmKEhvJkyEQoZKjdhqbRWA >= 20 && utCINLvDbBxPoKhwgLqnyqcCzgDj <= 10)
			{
				int num2 = OhiihqDNpgiebjUivUjSjJYZekit(pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[hwALclJnmKEhvJkyEQoZKjdhqbRWA] + utCINLvDbBxPoKhwgLqnyqcCzgDj + 1], pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[dOvLMdEnpwinlAusVqzbBezROZEo] + utCINLvDbBxPoKhwgLqnyqcCzgDj + 1], pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[hwALclJnmKEhvJkyEQoZKjdhqbRWA + dOvLMdEnpwinlAusVqzbBezROZEo >> 1] + utCINLvDbBxPoKhwgLqnyqcCzgDj + 1]);
				int num3;
				int num4 = (num3 = hwALclJnmKEhvJkyEQoZKjdhqbRWA);
				int num5;
				int num6 = (num5 = dOvLMdEnpwinlAusVqzbBezROZEo);
				int num7;
				while (true)
				{
					if (num4 <= num6)
					{
						num7 = pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4] + utCINLvDbBxPoKhwgLqnyqcCzgDj + 1] - num2;
						if (num7 == 0)
						{
							int num8 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4];
							XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num3];
							XDikxKdtGEtmJQDoaUKQCLOBxzhC[num3] = num8;
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
						num7 = pkXETbftTbFbDtzujsuZzsRbxUcS[XDikxKdtGEtmJQDoaUKQCLOBxzhC[num6] + utCINLvDbBxPoKhwgLqnyqcCzgDj + 1] - num2;
						if (num7 == 0)
						{
							int num9 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num6];
							XDikxKdtGEtmJQDoaUKQCLOBxzhC[num6] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5];
							XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = num9;
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
					int num10 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4];
					XDikxKdtGEtmJQDoaUKQCLOBxzhC[num4] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num6];
					XDikxKdtGEtmJQDoaUKQCLOBxzhC[num6] = num10;
					num4++;
					num6--;
				}
				if (num5 < num3)
				{
					array[num].HwALclJnmKEhvJkyEQoZKjdhqbRWA = hwALclJnmKEhvJkyEQoZKjdhqbRWA;
					array[num].dOvLMdEnpwinlAusVqzbBezROZEo = dOvLMdEnpwinlAusVqzbBezROZEo;
					array[num].UtCINLvDbBxPoKhwgLqnyqcCzgDj = utCINLvDbBxPoKhwgLqnyqcCzgDj + 1;
					num++;
					continue;
				}
				num7 = ((num3 - hwALclJnmKEhvJkyEQoZKjdhqbRWA < num4 - num3) ? (num3 - hwALclJnmKEhvJkyEQoZKjdhqbRWA) : (num4 - num3));
				HCRGLMHeWcYUfpWXRrBZZxgwrIKq(hwALclJnmKEhvJkyEQoZKjdhqbRWA, num4 - num7, num7);
				int num11 = ((dOvLMdEnpwinlAusVqzbBezROZEo - num5 < num5 - num6) ? (dOvLMdEnpwinlAusVqzbBezROZEo - num5) : (num5 - num6));
				HCRGLMHeWcYUfpWXRrBZZxgwrIKq(num4, dOvLMdEnpwinlAusVqzbBezROZEo - num11 + 1, num11);
				num7 = hwALclJnmKEhvJkyEQoZKjdhqbRWA + num4 - num3 - 1;
				num11 = dOvLMdEnpwinlAusVqzbBezROZEo - (num5 - num6) + 1;
				array[num].HwALclJnmKEhvJkyEQoZKjdhqbRWA = hwALclJnmKEhvJkyEQoZKjdhqbRWA;
				array[num].dOvLMdEnpwinlAusVqzbBezROZEo = num7;
				array[num].UtCINLvDbBxPoKhwgLqnyqcCzgDj = utCINLvDbBxPoKhwgLqnyqcCzgDj;
				num++;
				array[num].HwALclJnmKEhvJkyEQoZKjdhqbRWA = num7 + 1;
				array[num].dOvLMdEnpwinlAusVqzbBezROZEo = num11 - 1;
				array[num].UtCINLvDbBxPoKhwgLqnyqcCzgDj = utCINLvDbBxPoKhwgLqnyqcCzgDj + 1;
				num++;
				array[num].HwALclJnmKEhvJkyEQoZKjdhqbRWA = num11;
				array[num].dOvLMdEnpwinlAusVqzbBezROZEo = dOvLMdEnpwinlAusVqzbBezROZEo;
				array[num].UtCINLvDbBxPoKhwgLqnyqcCzgDj = utCINLvDbBxPoKhwgLqnyqcCzgDj;
				num++;
			}
			else
			{
				yLICqBMXRoLXjEgzgaLRFgKSfaCf(hwALclJnmKEhvJkyEQoZKjdhqbRWA, dOvLMdEnpwinlAusVqzbBezROZEo, utCINLvDbBxPoKhwgLqnyqcCzgDj);
				if (SnUYgXgZtYeVBzNWLvYFcJlgIDeU > pfLXuMbyTcGiXZFhKjlMHAryNcwj && RYuQfZkjLGCKYsQvQSwZBDKlbaSW)
				{
					break;
				}
			}
		}
	}

	private void EddbKloPjqgnIyLsCAMmIEVvFTCCb()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 256; i++)
		{
			WJTCScASGJaAMYRLiANAKHblvVep[i] = false;
		}
		for (int i = 0; i <= kiondpinEzQabZwUucVyiXrfkoSi; i++)
		{
			if (num == 0)
			{
				num = pRwYMkIAnTEhcZFjkhDZpfhHBJxCA.nfpaSxpzdvbZBhJWdJgHgYQptFur[num2];
				num2++;
				if (num2 == 512)
				{
					num2 = 0;
				}
			}
			num--;
			pkXETbftTbFbDtzujsuZzsRbxUcS[i + 1] = (byte)((uint)pkXETbftTbFbDtzujsuZzsRbxUcS[i + 1] ^ ((num == 1) ? 1u : 0u));
			pkXETbftTbFbDtzujsuZzsRbxUcS[i + 1] = (byte)(pkXETbftTbFbDtzujsuZzsRbxUcS[i + 1] & 0xFFu);
			WJTCScASGJaAMYRLiANAKHblvVep[pkXETbftTbFbDtzujsuZzsRbxUcS[i + 1]] = true;
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

	private void TvookakhkzQWjHAIShNUTBtVVwrm()
	{
		char[][] array = new char[6][];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new char[258];
		}
		int num = 0;
		int num2 = tQtXjtSNoifumqdiLgPUhAuAJjDNA + 2;
		for (int j = 0; j < 6; j++)
		{
			for (int k = 0; k < num2; k++)
			{
				array[j][k] = '\u000f';
			}
		}
		if (OghhmIBNMvBTbOGpZXyuoxHIEBdJ <= 0)
		{
			hiPLQJyBqaAdLrzaNBelpArKdVOAA();
		}
		int num3 = ((OghhmIBNMvBTbOGpZXyuoxHIEBdJ < 200) ? 2 : ((OghhmIBNMvBTbOGpZXyuoxHIEBdJ < 600) ? 3 : ((OghhmIBNMvBTbOGpZXyuoxHIEBdJ < 1200) ? 4 : ((OghhmIBNMvBTbOGpZXyuoxHIEBdJ >= 2400) ? 6 : 5))));
		int num4 = num3;
		int num5 = OghhmIBNMvBTbOGpZXyuoxHIEBdJ;
		int num6 = 0;
		while (num4 > 0)
		{
			int num7 = num5 / num4;
			int l = 0;
			int num8;
			for (num8 = num6 - 1; l < num7; l += JRoLBMhXAhDcMaeeqrLeJYBAlNme[num8])
			{
				if (num8 >= num2 - 1)
				{
					break;
				}
				num8++;
			}
			if (num8 > num6 && num4 != num3 && num4 != 1 && (num3 - num4) % 2 == 1)
			{
				l -= JRoLBMhXAhDcMaeeqrLeJYBAlNme[num8];
				num8--;
			}
			for (int m = 0; m < num2; m++)
			{
				if (m >= num6 && m <= num8)
				{
					array[num4 - 1][m] = '\0';
				}
				else
				{
					array[num4 - 1][m] = '\u000f';
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
			while (num6 < OghhmIBNMvBTbOGpZXyuoxHIEBdJ)
			{
				int num8 = num6 + 50 - 1;
				if (num8 >= OghhmIBNMvBTbOGpZXyuoxHIEBdJ)
				{
					num8 = OghhmIBNMvBTbOGpZXyuoxHIEBdJ - 1;
				}
				for (int num14 = 0; num14 < num3; num14++)
				{
					array4[num14] = 0;
				}
				if (num3 != 6)
				{
					for (int num15 = num6; num15 <= num8; num15++)
					{
						short num16 = mqgHnWZkJvMCmFMkSldZVxcxEbxO[num15];
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
						short num25 = mqgHnWZkJvMCmFMkSldZVxcxEbxO[num24];
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
				IXcIBuUUdlRGZcrgjUHPaJMukgPK[num] = (char)num27;
				num++;
				for (int num29 = num6; num29 <= num8; num29++)
				{
					array2[num27][mqgHnWZkJvMCmFMkSldZVxcxEbxO[num29]]++;
				}
				num6 = num8 + 1;
			}
			for (int num30 = 0; num30 < num3; num30++)
			{
				ZZRdFXVTQtELngTlSTIzBdPXEBdBb(array[num30], array2[num30], num2, 20);
			}
		}
		array2 = null;
		array3 = null;
		array4 = null;
		if (num3 >= 8)
		{
			hiPLQJyBqaAdLrzaNBelpArKdVOAA();
		}
		if (num >= 32768 || num > 18002)
		{
			hiPLQJyBqaAdLrzaNBelpArKdVOAA();
		}
		char[] array5 = new char[6];
		for (int num31 = 0; num31 < num3; num31++)
		{
			array5[num31] = (char)num31;
		}
		for (int num32 = 0; num32 < num; num32++)
		{
			char c = IXcIBuUUdlRGZcrgjUHPaJMukgPK[num32];
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
			HLlqQetIguswClpYBFmvMxanYBAB[num32] = (char)num33;
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
				hiPLQJyBqaAdLrzaNBelpArKdVOAA();
			}
			if (num36 < 1)
			{
				hiPLQJyBqaAdLrzaNBelpArKdVOAA();
			}
			AvphUjViPMKOyuvnNfVClzcDAHFl(array6[num35], array[num35], num36, num37, num2);
		}
		bool[] array7 = new bool[16];
		for (int num39 = 0; num39 < 16; num39++)
		{
			array7[num39] = false;
			for (int num40 = 0; num40 < 16; num40++)
			{
				if (WJTCScASGJaAMYRLiANAKHblvVep[num39 * 16 + num40])
				{
					array7[num39] = true;
				}
			}
		}
		for (int num41 = 0; num41 < 16; num41++)
		{
			if (!array7[num41])
			{
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 0);
			}
			else
			{
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 1);
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
				if (!WJTCScASGJaAMYRLiANAKHblvVep[num42 * 16 + num43])
				{
					ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 0);
				}
				else
				{
					ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 1);
				}
			}
		}
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(3, num3);
		ggfptZZvCYwCUsDNybOaLgiCBRIcA(15, num);
		for (int num44 = 0; num44 < num; num44++)
		{
			for (int num45 = 0; num45 < HLlqQetIguswClpYBFmvMxanYBAB[num44]; num45++)
			{
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 1);
			}
			ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 0);
		}
		for (int num46 = 0; num46 < num3; num46++)
		{
			int num47 = array[num46][0];
			ggfptZZvCYwCUsDNybOaLgiCBRIcA(5, num47);
			for (int num48 = 0; num48 < num2; num48++)
			{
				for (; num47 < array[num46][num48]; num47++)
				{
					ggfptZZvCYwCUsDNybOaLgiCBRIcA(2, 2);
				}
				while (num47 > array[num46][num48])
				{
					ggfptZZvCYwCUsDNybOaLgiCBRIcA(2, 3);
					num47--;
				}
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(1, 0);
			}
		}
		int num49 = 0;
		num6 = 0;
		while (num6 < OghhmIBNMvBTbOGpZXyuoxHIEBdJ)
		{
			int num8 = num6 + 50 - 1;
			if (num8 >= OghhmIBNMvBTbOGpZXyuoxHIEBdJ)
			{
				num8 = OghhmIBNMvBTbOGpZXyuoxHIEBdJ - 1;
			}
			for (int num50 = num6; num50 <= num8; num50++)
			{
				ggfptZZvCYwCUsDNybOaLgiCBRIcA(array[(uint)IXcIBuUUdlRGZcrgjUHPaJMukgPK[num49]][mqgHnWZkJvMCmFMkSldZVxcxEbxO[num50]], array6[(uint)IXcIBuUUdlRGZcrgjUHPaJMukgPK[num49]][mqgHnWZkJvMCmFMkSldZVxcxEbxO[num50]]);
			}
			num6 = num8 + 1;
			num49++;
		}
		if (num49 != num)
		{
			hiPLQJyBqaAdLrzaNBelpArKdVOAA();
		}
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("BZip2OutputStream SetLength not supported");
	}

	private void yLICqBMXRoLXjEgzgaLRFgKSfaCf(int int_0, int int_1, int int_2)
	{
		int num = int_1 - int_0 + 1;
		if (num < 2)
		{
			return;
		}
		int i;
		for (i = 0; EjdREjfkudToTpTBLMGqmBaudnK[i] < num; i++)
		{
		}
		for (i--; i >= 0; i--)
		{
			int num2 = EjdREjfkudToTpTBLMGqmBaudnK[i];
			int num3 = int_0 + num2;
			while (num3 <= int_1)
			{
				int num4 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num3];
				int num5 = num3;
				while (tNfpuDGeeWjEPHCXNFjtBXSBfrqRb(XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5 - num2] + int_2, num4 + int_2))
				{
					XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5 - num2];
					num5 -= num2;
					if (num5 <= int_0 + num2 - 1)
					{
						break;
					}
				}
				XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = num4;
				num3++;
				if (num3 > int_1)
				{
					break;
				}
				num4 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num3];
				num5 = num3;
				while (tNfpuDGeeWjEPHCXNFjtBXSBfrqRb(XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5 - num2] + int_2, num4 + int_2))
				{
					XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5 - num2];
					num5 -= num2;
					if (num5 <= int_0 + num2 - 1)
					{
						break;
					}
				}
				XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = num4;
				num3++;
				if (num3 > int_1)
				{
					break;
				}
				num4 = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num3];
				num5 = num3;
				while (tNfpuDGeeWjEPHCXNFjtBXSBfrqRb(XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5 - num2] + int_2, num4 + int_2))
				{
					XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5 - num2];
					num5 -= num2;
					if (num5 <= int_0 + num2 - 1)
					{
						break;
					}
				}
				XDikxKdtGEtmJQDoaUKQCLOBxzhC[num5] = num4;
				num3++;
				if (SnUYgXgZtYeVBzNWLvYFcJlgIDeU > pfLXuMbyTcGiXZFhKjlMHAryNcwj && RYuQfZkjLGCKYsQvQSwZBDKlbaSW)
				{
					return;
				}
			}
		}
	}

	private void HCRGLMHeWcYUfpWXRrBZZxgwrIKq(int int_0, int int_1, int int_2)
	{
		int num = 0;
		while (int_2 > 0)
		{
			num = XDikxKdtGEtmJQDoaUKQCLOBxzhC[int_0];
			XDikxKdtGEtmJQDoaUKQCLOBxzhC[int_0] = XDikxKdtGEtmJQDoaUKQCLOBxzhC[int_1];
			XDikxKdtGEtmJQDoaUKQCLOBxzhC[int_1] = num;
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
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Offset/count out of range");
		}
		for (int i = 0; i < count; i++)
		{
			WriteByte(buffer[offset + i]);
		}
	}

	public override void WriteByte(byte value)
	{
		int num = (256 + value) % 256;
		if (MTtlOaSLQrBDxDzkNPPhamSQOXLrA == -1)
		{
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = num;
			vWsfQyutgDTxHdnlsNQuuqOYXSDq++;
			return;
		}
		if (MTtlOaSLQrBDxDzkNPPhamSQOXLrA != num)
		{
			gpCBoidyLoCTRDabCatBNPrHOdKub();
			vWsfQyutgDTxHdnlsNQuuqOYXSDq = 1;
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = num;
			return;
		}
		vWsfQyutgDTxHdnlsNQuuqOYXSDq++;
		if (vWsfQyutgDTxHdnlsNQuuqOYXSDq > 254)
		{
			gpCBoidyLoCTRDabCatBNPrHOdKub();
			MTtlOaSLQrBDxDzkNPPhamSQOXLrA = -1;
			vWsfQyutgDTxHdnlsNQuuqOYXSDq = 0;
		}
	}

	private void gpCBoidyLoCTRDabCatBNPrHOdKub()
	{
		if (kiondpinEzQabZwUucVyiXrfkoSi < QnPyFeLfyqIhIIOnOmPzzQYYexpf)
		{
			WJTCScASGJaAMYRLiANAKHblvVep[MTtlOaSLQrBDxDzkNPPhamSQOXLrA] = true;
			for (int i = 0; i < vWsfQyutgDTxHdnlsNQuuqOYXSDq; i++)
			{
				LhlEXUmBlhGoplOFyZirAzSUloCs.Update(MTtlOaSLQrBDxDzkNPPhamSQOXLrA);
			}
			switch (vWsfQyutgDTxHdnlsNQuuqOYXSDq)
			{
			default:
				WJTCScASGJaAMYRLiANAKHblvVep[vWsfQyutgDTxHdnlsNQuuqOYXSDq - 4] = true;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)(vWsfQyutgDTxHdnlsNQuuqOYXSDq - 4);
				break;
			case 1:
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				break;
			case 2:
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				break;
			case 3:
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				kiondpinEzQabZwUucVyiXrfkoSi++;
				pkXETbftTbFbDtzujsuZzsRbxUcS[kiondpinEzQabZwUucVyiXrfkoSi + 1] = (byte)MTtlOaSLQrBDxDzkNPPhamSQOXLrA;
				break;
			}
		}
		else
		{
			eUlCvHxhzeHzmmgZxTJuaRpPXSUJ();
			buSvorTwXYqUASLaIqeZxBDzfqmb();
			gpCBoidyLoCTRDabCatBNPrHOdKub();
		}
	}
}
