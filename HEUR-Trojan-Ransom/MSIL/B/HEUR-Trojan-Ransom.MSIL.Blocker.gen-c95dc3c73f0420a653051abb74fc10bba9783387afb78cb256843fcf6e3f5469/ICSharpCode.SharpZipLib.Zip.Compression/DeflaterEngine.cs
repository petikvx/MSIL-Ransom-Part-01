using System;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class DeflaterEngine : DeflaterConstants
{
	private Adler32 RoDAjTuYoNhKYzgkLaPoWnqFpolw;

	private int VkVlGVhBvQrLQgfYBOJHxHvRGPMIA;

	private int RZuFWxUjHpGliFcYVKIqChJXjpsBb;

	private int YbXuLJHikCJiFmefaTgUHjOEpZqV;

	private short[] HqUjixNvKMmYrCUCkWHfamFcDZCr;

	private DeflaterHuffman GlodlCZwYknDSmVlHmQEAoUMBggO;

	private byte[] DuQSmohOvWKBESVCOiXLrWuigKHO;

	private int zBuPDKEeTfapzGUbdzTfvCuWocoV;

	private int oLWaUwSoggJoBNkRrWtQuLQEDSgq;

	private int EbIIzqKeBRBLgJfctXKJQQDEsnLdb;

	private int wAYNBJVeFHZrvWlQgYLidPNlfUFC;

	private int IFLAnKajhmssbOjmHhVzAyhgTGiDc;

	private int DNclgUOSysMgIXWfbOiIridRXZiG;

	private int bZrCWxAPjUQlqNyndFFiMFmPDMohA;

	private int mqDLGrLgauhsPhCRQRREjCDaaowuA;

	private int INgiYEABbxLShzkwVuVFFFgHFxdDA;

	private DeflaterPending TjKPLGeiaLhcagazwKehJcslqfAw;

	private short[] PxMPAhrBuTxMLfxitbxEzqlfxBMA;

	private bool TJkGDZqizmsbVugmIHBVIFMlFJLp;

	private DeflateStrategy XTONTslLfkYpBEitLEpmEKzxMOSAA;

	private int zUkIqcJVARKgjyupFAywFaQdOvkj;

	private const int FLLCYIrnGzUDbmWTzmOEeSHlhcEW = 4096;

	private long cAepyoHYFQtoPHRzmCVjFYLqCbUg;

	private byte[] yyMPVNbjbaIYihnijTTdjerIlbbHA;

	public int Adler => (int)RoDAjTuYoNhKYzgkLaPoWnqFpolw.Value;

	public DeflateStrategy Strategy
	{
		get
		{
			return XTONTslLfkYpBEitLEpmEKzxMOSAA;
		}
		set
		{
			XTONTslLfkYpBEitLEpmEKzxMOSAA = value;
		}
	}

	public long TotalIn => cAepyoHYFQtoPHRzmCVjFYLqCbUg;

	public DeflaterEngine(DeflaterPending pending)
	{
		TjKPLGeiaLhcagazwKehJcslqfAw = pending;
		GlodlCZwYknDSmVlHmQEAoUMBggO = new DeflaterHuffman(pending);
		RoDAjTuYoNhKYzgkLaPoWnqFpolw = new Adler32();
		yyMPVNbjbaIYihnijTTdjerIlbbHA = new byte[65536];
		HqUjixNvKMmYrCUCkWHfamFcDZCr = new short[32768];
		PxMPAhrBuTxMLfxitbxEzqlfxBMA = new short[32768];
		zUkIqcJVARKgjyupFAywFaQdOvkj = 1;
		VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = 1;
	}

	public bool Deflate(bool flush, bool finish)
	{
		bool flag;
		do
		{
			FillWindow();
			bool flush2 = false;
			flag = RZuFWxUjHpGliFcYVKIqChJXjpsBb switch
			{
				2 => xhwrBLAZHmeFZQmfbyqsVqIsHsLjA(flush2, finish), 
				1 => YLJesiWKkjqEVXOTGyLfEIldjErDA(flush2, finish), 
				0 => wlNEyEAOpCMegSpPKIfzEfEMXIlL(flush2, finish), 
				_ => throw new InvalidOperationException("unknown compressionFunction"), 
			};
		}
		while (TjKPLGeiaLhcagazwKehJcslqfAw.IsFlushed && flag);
		return flag;
	}

	private bool YLJesiWKkjqEVXOTGyLfEIldjErDA(bool flush, bool finish)
	{
		if (!(wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 262 || flush))
		{
			return false;
		}
		while (true)
		{
			if (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 262 || flush)
			{
				if (wAYNBJVeFHZrvWlQgYLidPNlfUFC == 0)
				{
					break;
				}
				if (zUkIqcJVARKgjyupFAywFaQdOvkj > 65274)
				{
					QAlhdKRyRXyyOFfVOmUlxGHhjMqi();
				}
				int num;
				if (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 3 && (num = CSDgQJbqveOgTHOQRmjTXXZoeCiSA()) != 0 && XTONTslLfkYpBEitLEpmEKzxMOSAA != DeflateStrategy.HuffmanOnly && zUkIqcJVARKgjyupFAywFaQdOvkj - num <= 32506 && qSsgzXGAngDvbDlENIYcTfSnxXyT(num))
				{
					bool flag = GlodlCZwYknDSmVlHmQEAoUMBggO.TallyDist(zUkIqcJVARKgjyupFAywFaQdOvkj - DNclgUOSysMgIXWfbOiIridRXZiG, IFLAnKajhmssbOjmHhVzAyhgTGiDc);
					wAYNBJVeFHZrvWlQgYLidPNlfUFC -= IFLAnKajhmssbOjmHhVzAyhgTGiDc;
					if (IFLAnKajhmssbOjmHhVzAyhgTGiDc <= mqDLGrLgauhsPhCRQRREjCDaaowuA && wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 3)
					{
						while (--IFLAnKajhmssbOjmHhVzAyhgTGiDc > 0)
						{
							zUkIqcJVARKgjyupFAywFaQdOvkj++;
							CSDgQJbqveOgTHOQRmjTXXZoeCiSA();
						}
						zUkIqcJVARKgjyupFAywFaQdOvkj++;
					}
					else
					{
						zUkIqcJVARKgjyupFAywFaQdOvkj += IFLAnKajhmssbOjmHhVzAyhgTGiDc;
						if (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 2)
						{
							uZLztgtMWnsNzucLxpDeNPbiJsMg();
						}
					}
					IFLAnKajhmssbOjmHhVzAyhgTGiDc = 2;
					if (!flag)
					{
						continue;
					}
				}
				else
				{
					GlodlCZwYknDSmVlHmQEAoUMBggO.TallyLit(yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj] & 0xFF);
					zUkIqcJVARKgjyupFAywFaQdOvkj++;
					wAYNBJVeFHZrvWlQgYLidPNlfUFC--;
				}
				if (GlodlCZwYknDSmVlHmQEAoUMBggO.IsFull())
				{
					bool flag2 = finish && wAYNBJVeFHZrvWlQgYLidPNlfUFC == 0;
					GlodlCZwYknDSmVlHmQEAoUMBggO.FlushBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, flag2);
					VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
					return !flag2;
				}
				continue;
			}
			return true;
		}
		GlodlCZwYknDSmVlHmQEAoUMBggO.FlushBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, finish);
		VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
		return false;
	}

	private bool xhwrBLAZHmeFZQmfbyqsVqIsHsLjA(bool flush, bool finish)
	{
		if (!(wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 262 || flush))
		{
			return false;
		}
		while (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 262 || flush)
		{
			if (wAYNBJVeFHZrvWlQgYLidPNlfUFC != 0)
			{
				if (zUkIqcJVARKgjyupFAywFaQdOvkj >= 65274)
				{
					QAlhdKRyRXyyOFfVOmUlxGHhjMqi();
				}
				int dNclgUOSysMgIXWfbOiIridRXZiG = DNclgUOSysMgIXWfbOiIridRXZiG;
				int iFLAnKajhmssbOjmHhVzAyhgTGiDc = IFLAnKajhmssbOjmHhVzAyhgTGiDc;
				if (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 3)
				{
					int num = CSDgQJbqveOgTHOQRmjTXXZoeCiSA();
					if (XTONTslLfkYpBEitLEpmEKzxMOSAA != DeflateStrategy.HuffmanOnly && num != 0 && zUkIqcJVARKgjyupFAywFaQdOvkj - num <= 32506 && qSsgzXGAngDvbDlENIYcTfSnxXyT(num) && IFLAnKajhmssbOjmHhVzAyhgTGiDc <= 5 && (XTONTslLfkYpBEitLEpmEKzxMOSAA == DeflateStrategy.Filtered || (IFLAnKajhmssbOjmHhVzAyhgTGiDc == 3 && zUkIqcJVARKgjyupFAywFaQdOvkj - DNclgUOSysMgIXWfbOiIridRXZiG > 4096)))
					{
						IFLAnKajhmssbOjmHhVzAyhgTGiDc = 2;
					}
				}
				if (iFLAnKajhmssbOjmHhVzAyhgTGiDc >= 3 && IFLAnKajhmssbOjmHhVzAyhgTGiDc <= iFLAnKajhmssbOjmHhVzAyhgTGiDc)
				{
					GlodlCZwYknDSmVlHmQEAoUMBggO.TallyDist(zUkIqcJVARKgjyupFAywFaQdOvkj - 1 - dNclgUOSysMgIXWfbOiIridRXZiG, iFLAnKajhmssbOjmHhVzAyhgTGiDc);
					iFLAnKajhmssbOjmHhVzAyhgTGiDc -= 2;
					do
					{
						zUkIqcJVARKgjyupFAywFaQdOvkj++;
						wAYNBJVeFHZrvWlQgYLidPNlfUFC--;
						if (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 3)
						{
							CSDgQJbqveOgTHOQRmjTXXZoeCiSA();
						}
					}
					while (--iFLAnKajhmssbOjmHhVzAyhgTGiDc > 0);
					zUkIqcJVARKgjyupFAywFaQdOvkj++;
					wAYNBJVeFHZrvWlQgYLidPNlfUFC--;
					TJkGDZqizmsbVugmIHBVIFMlFJLp = false;
					IFLAnKajhmssbOjmHhVzAyhgTGiDc = 2;
				}
				else
				{
					if (TJkGDZqizmsbVugmIHBVIFMlFJLp)
					{
						GlodlCZwYknDSmVlHmQEAoUMBggO.TallyLit(yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj - 1] & 0xFF);
					}
					TJkGDZqizmsbVugmIHBVIFMlFJLp = true;
					zUkIqcJVARKgjyupFAywFaQdOvkj++;
					wAYNBJVeFHZrvWlQgYLidPNlfUFC--;
				}
				if (GlodlCZwYknDSmVlHmQEAoUMBggO.IsFull())
				{
					int num2 = zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA;
					if (TJkGDZqizmsbVugmIHBVIFMlFJLp)
					{
						num2--;
					}
					bool flag = finish && wAYNBJVeFHZrvWlQgYLidPNlfUFC == 0 && !TJkGDZqizmsbVugmIHBVIFMlFJLp;
					GlodlCZwYknDSmVlHmQEAoUMBggO.FlushBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, num2, flag);
					VkVlGVhBvQrLQgfYBOJHxHvRGPMIA += num2;
					return !flag;
				}
				continue;
			}
			if (TJkGDZqizmsbVugmIHBVIFMlFJLp)
			{
				GlodlCZwYknDSmVlHmQEAoUMBggO.TallyLit(yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj - 1] & 0xFF);
			}
			TJkGDZqizmsbVugmIHBVIFMlFJLp = false;
			GlodlCZwYknDSmVlHmQEAoUMBggO.FlushBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, finish);
			VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
			return false;
		}
		return true;
	}

	private bool wlNEyEAOpCMegSpPKIfzEfEMXIlL(bool flush, bool finish)
	{
		if (!flush && wAYNBJVeFHZrvWlQgYLidPNlfUFC == 0)
		{
			return false;
		}
		zUkIqcJVARKgjyupFAywFaQdOvkj += wAYNBJVeFHZrvWlQgYLidPNlfUFC;
		wAYNBJVeFHZrvWlQgYLidPNlfUFC = 0;
		int num = zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA;
		if (num < DeflaterConstants.MAX_BLOCK_SIZE && (VkVlGVhBvQrLQgfYBOJHxHvRGPMIA >= 32768 || num < 32506) && !flush)
		{
			return true;
		}
		bool flag = finish;
		if (num > DeflaterConstants.MAX_BLOCK_SIZE)
		{
			num = DeflaterConstants.MAX_BLOCK_SIZE;
			flag = false;
		}
		GlodlCZwYknDSmVlHmQEAoUMBggO.FlushStoredBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, num, flag);
		VkVlGVhBvQrLQgfYBOJHxHvRGPMIA += num;
		return !flag;
	}

	public void FillWindow()
	{
		if (zUkIqcJVARKgjyupFAywFaQdOvkj >= 65274)
		{
			QAlhdKRyRXyyOFfVOmUlxGHhjMqi();
		}
		while (wAYNBJVeFHZrvWlQgYLidPNlfUFC < 262 && oLWaUwSoggJoBNkRrWtQuLQEDSgq < zBuPDKEeTfapzGUbdzTfvCuWocoV)
		{
			int num = 65536 - wAYNBJVeFHZrvWlQgYLidPNlfUFC - zUkIqcJVARKgjyupFAywFaQdOvkj;
			if (num > zBuPDKEeTfapzGUbdzTfvCuWocoV - oLWaUwSoggJoBNkRrWtQuLQEDSgq)
			{
				num = zBuPDKEeTfapzGUbdzTfvCuWocoV - oLWaUwSoggJoBNkRrWtQuLQEDSgq;
			}
			Array.Copy(DuQSmohOvWKBESVCOiXLrWuigKHO, oLWaUwSoggJoBNkRrWtQuLQEDSgq, yyMPVNbjbaIYihnijTTdjerIlbbHA, zUkIqcJVARKgjyupFAywFaQdOvkj + wAYNBJVeFHZrvWlQgYLidPNlfUFC, num);
			RoDAjTuYoNhKYzgkLaPoWnqFpolw.Update(DuQSmohOvWKBESVCOiXLrWuigKHO, oLWaUwSoggJoBNkRrWtQuLQEDSgq, num);
			oLWaUwSoggJoBNkRrWtQuLQEDSgq += num;
			cAepyoHYFQtoPHRzmCVjFYLqCbUg += num;
			wAYNBJVeFHZrvWlQgYLidPNlfUFC += num;
		}
		if (wAYNBJVeFHZrvWlQgYLidPNlfUFC >= 3)
		{
			uZLztgtMWnsNzucLxpDeNPbiJsMg();
		}
	}

	private bool qSsgzXGAngDvbDlENIYcTfSnxXyT(int curMatch)
	{
		int num = bZrCWxAPjUQlqNyndFFiMFmPDMohA;
		int iNgiYEABbxLShzkwVuVFFFgHFxdDA = INgiYEABbxLShzkwVuVFFFgHFxdDA;
		short[] pxMPAhrBuTxMLfxitbxEzqlfxBMA = PxMPAhrBuTxMLfxitbxEzqlfxBMA;
		int num2 = zUkIqcJVARKgjyupFAywFaQdOvkj;
		int num3 = zUkIqcJVARKgjyupFAywFaQdOvkj + IFLAnKajhmssbOjmHhVzAyhgTGiDc;
		int num4 = Math.Max(IFLAnKajhmssbOjmHhVzAyhgTGiDc, 2);
		int num5 = Math.Max(zUkIqcJVARKgjyupFAywFaQdOvkj - 32506, 0);
		int num6 = zUkIqcJVARKgjyupFAywFaQdOvkj + 258 - 1;
		byte b = yyMPVNbjbaIYihnijTTdjerIlbbHA[num3 - 1];
		byte b2 = yyMPVNbjbaIYihnijTTdjerIlbbHA[num3];
		if (num4 >= YbXuLJHikCJiFmefaTgUHjOEpZqV)
		{
			num >>= 2;
		}
		if (iNgiYEABbxLShzkwVuVFFFgHFxdDA > wAYNBJVeFHZrvWlQgYLidPNlfUFC)
		{
			iNgiYEABbxLShzkwVuVFFFgHFxdDA = wAYNBJVeFHZrvWlQgYLidPNlfUFC;
		}
		do
		{
			if (yyMPVNbjbaIYihnijTTdjerIlbbHA[curMatch + num4] != b2 || yyMPVNbjbaIYihnijTTdjerIlbbHA[curMatch + num4 - 1] != b || yyMPVNbjbaIYihnijTTdjerIlbbHA[curMatch] != yyMPVNbjbaIYihnijTTdjerIlbbHA[num2] || yyMPVNbjbaIYihnijTTdjerIlbbHA[curMatch + 1] != yyMPVNbjbaIYihnijTTdjerIlbbHA[num2 + 1])
			{
				continue;
			}
			int num7 = curMatch + 2;
			num2 += 2;
			while (yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && yyMPVNbjbaIYihnijTTdjerIlbbHA[++num2] == yyMPVNbjbaIYihnijTTdjerIlbbHA[++num7] && num2 < num6)
			{
			}
			if (num2 > num3)
			{
				DNclgUOSysMgIXWfbOiIridRXZiG = curMatch;
				num3 = num2;
				num4 = num2 - zUkIqcJVARKgjyupFAywFaQdOvkj;
				if (num4 >= iNgiYEABbxLShzkwVuVFFFgHFxdDA)
				{
					break;
				}
				b = yyMPVNbjbaIYihnijTTdjerIlbbHA[num3 - 1];
				b2 = yyMPVNbjbaIYihnijTTdjerIlbbHA[num3];
			}
			num2 = zUkIqcJVARKgjyupFAywFaQdOvkj;
		}
		while ((curMatch = pxMPAhrBuTxMLfxitbxEzqlfxBMA[curMatch & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		IFLAnKajhmssbOjmHhVzAyhgTGiDc = Math.Min(num4, wAYNBJVeFHZrvWlQgYLidPNlfUFC);
		return IFLAnKajhmssbOjmHhVzAyhgTGiDc >= 3;
	}

	private int CSDgQJbqveOgTHOQRmjTXXZoeCiSA()
	{
		int num = ((EbIIzqKeBRBLgJfctXKJQQDEsnLdb << 5) ^ yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj + 2]) & 0x7FFF;
		short num2 = (PxMPAhrBuTxMLfxitbxEzqlfxBMA[zUkIqcJVARKgjyupFAywFaQdOvkj & 0x7FFF] = HqUjixNvKMmYrCUCkWHfamFcDZCr[num]);
		HqUjixNvKMmYrCUCkWHfamFcDZCr[num] = (short)zUkIqcJVARKgjyupFAywFaQdOvkj;
		EbIIzqKeBRBLgJfctXKJQQDEsnLdb = num;
		return num2 & 0xFFFF;
	}

	public bool NeedsInput()
	{
		return zBuPDKEeTfapzGUbdzTfvCuWocoV == oLWaUwSoggJoBNkRrWtQuLQEDSgq;
	}

	public void Reset()
	{
		GlodlCZwYknDSmVlHmQEAoUMBggO.Reset();
		RoDAjTuYoNhKYzgkLaPoWnqFpolw.Reset();
		zUkIqcJVARKgjyupFAywFaQdOvkj = 1;
		VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = 1;
		wAYNBJVeFHZrvWlQgYLidPNlfUFC = 0;
		cAepyoHYFQtoPHRzmCVjFYLqCbUg = 0L;
		TJkGDZqizmsbVugmIHBVIFMlFJLp = false;
		IFLAnKajhmssbOjmHhVzAyhgTGiDc = 2;
		for (int i = 0; i < 32768; i++)
		{
			HqUjixNvKMmYrCUCkWHfamFcDZCr[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			PxMPAhrBuTxMLfxitbxEzqlfxBMA[j] = 0;
		}
	}

	public void ResetAdler()
	{
		RoDAjTuYoNhKYzgkLaPoWnqFpolw.Reset();
	}

	public void SetDictionary(byte[] buffer, int offset, int length)
	{
		RoDAjTuYoNhKYzgkLaPoWnqFpolw.Update(buffer, offset, length);
		if (length >= 3)
		{
			if (length > 32506)
			{
				offset += length - 32506;
				length = 32506;
			}
			Array.Copy(buffer, offset, yyMPVNbjbaIYihnijTTdjerIlbbHA, zUkIqcJVARKgjyupFAywFaQdOvkj, length);
			uZLztgtMWnsNzucLxpDeNPbiJsMg();
			length--;
			while (--length > 0)
			{
				CSDgQJbqveOgTHOQRmjTXXZoeCiSA();
				zUkIqcJVARKgjyupFAywFaQdOvkj++;
			}
			zUkIqcJVARKgjyupFAywFaQdOvkj += 2;
			VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
		}
	}

	public void SetInput(byte[] buffer, int offset, int count)
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
		if (oLWaUwSoggJoBNkRrWtQuLQEDSgq < zBuPDKEeTfapzGUbdzTfvCuWocoV)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = offset + count;
		if (offset > num || num > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		DuQSmohOvWKBESVCOiXLrWuigKHO = buffer;
		oLWaUwSoggJoBNkRrWtQuLQEDSgq = offset;
		zBuPDKEeTfapzGUbdzTfvCuWocoV = num;
	}

	public void SetLevel(int level)
	{
		if (level >= 0 && level <= 9)
		{
			YbXuLJHikCJiFmefaTgUHjOEpZqV = DeflaterConstants.GOOD_LENGTH[level];
			mqDLGrLgauhsPhCRQRREjCDaaowuA = DeflaterConstants.MAX_LAZY[level];
			INgiYEABbxLShzkwVuVFFFgHFxdDA = DeflaterConstants.NICE_LENGTH[level];
			bZrCWxAPjUQlqNyndFFiMFmPDMohA = DeflaterConstants.MAX_CHAIN[level];
			if (DeflaterConstants.COMPR_FUNC[level] == RZuFWxUjHpGliFcYVKIqChJXjpsBb)
			{
				return;
			}
			switch (RZuFWxUjHpGliFcYVKIqChJXjpsBb)
			{
			case 0:
				if (zUkIqcJVARKgjyupFAywFaQdOvkj > VkVlGVhBvQrLQgfYBOJHxHvRGPMIA)
				{
					GlodlCZwYknDSmVlHmQEAoUMBggO.FlushStoredBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, lastBlock: false);
					VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
				}
				uZLztgtMWnsNzucLxpDeNPbiJsMg();
				break;
			case 1:
				if (zUkIqcJVARKgjyupFAywFaQdOvkj > VkVlGVhBvQrLQgfYBOJHxHvRGPMIA)
				{
					GlodlCZwYknDSmVlHmQEAoUMBggO.FlushBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, lastBlock: false);
					VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
				}
				break;
			case 2:
				if (TJkGDZqizmsbVugmIHBVIFMlFJLp)
				{
					GlodlCZwYknDSmVlHmQEAoUMBggO.TallyLit(yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj - 1] & 0xFF);
				}
				if (zUkIqcJVARKgjyupFAywFaQdOvkj > VkVlGVhBvQrLQgfYBOJHxHvRGPMIA)
				{
					GlodlCZwYknDSmVlHmQEAoUMBggO.FlushBlock(yyMPVNbjbaIYihnijTTdjerIlbbHA, VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, zUkIqcJVARKgjyupFAywFaQdOvkj - VkVlGVhBvQrLQgfYBOJHxHvRGPMIA, lastBlock: false);
					VkVlGVhBvQrLQgfYBOJHxHvRGPMIA = zUkIqcJVARKgjyupFAywFaQdOvkj;
				}
				TJkGDZqizmsbVugmIHBVIFMlFJLp = false;
				IFLAnKajhmssbOjmHhVzAyhgTGiDc = 2;
				break;
			}
			RZuFWxUjHpGliFcYVKIqChJXjpsBb = DeflaterConstants.COMPR_FUNC[level];
			return;
		}
		throw new ArgumentOutOfRangeException("level");
	}

	private void QAlhdKRyRXyyOFfVOmUlxGHhjMqi()
	{
		Array.Copy(yyMPVNbjbaIYihnijTTdjerIlbbHA, 32768, yyMPVNbjbaIYihnijTTdjerIlbbHA, 0, 32768);
		DNclgUOSysMgIXWfbOiIridRXZiG -= 32768;
		zUkIqcJVARKgjyupFAywFaQdOvkj -= 32768;
		VkVlGVhBvQrLQgfYBOJHxHvRGPMIA -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = HqUjixNvKMmYrCUCkWHfamFcDZCr[i] & 0xFFFF;
			HqUjixNvKMmYrCUCkWHfamFcDZCr[i] = (short)((num >= 32768) ? ((short)(num - 32768)) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = PxMPAhrBuTxMLfxitbxEzqlfxBMA[j] & 0xFFFF;
			PxMPAhrBuTxMLfxitbxEzqlfxBMA[j] = (short)((num2 >= 32768) ? ((short)(num2 - 32768)) : 0);
		}
	}

	private void uZLztgtMWnsNzucLxpDeNPbiJsMg()
	{
		EbIIzqKeBRBLgJfctXKJQQDEsnLdb = (yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj] << 5) ^ yyMPVNbjbaIYihnijTTdjerIlbbHA[zUkIqcJVARKgjyupFAywFaQdOvkj + 1];
	}
}
