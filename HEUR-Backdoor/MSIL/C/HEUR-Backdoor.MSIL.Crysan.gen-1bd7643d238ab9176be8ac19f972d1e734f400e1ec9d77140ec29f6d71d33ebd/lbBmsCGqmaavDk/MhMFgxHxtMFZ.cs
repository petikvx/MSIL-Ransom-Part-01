using System;
using System.IO;

namespace lbBmsCGqmaavDk;

internal class MhMFgxHxtMFZ
{
	public static void ZgtAvztkcDpfk(Stream rxLTRpSvgx)
	{
		rxLTRpSvgx.WriteByte(192);
	}

	public static void OkuEvXyruJsk(Stream wDMVGvkcmVjej, string TVemMSLOsMHnU)
	{
		byte[] array = mvCuPdYBvDWOQ.WJqmZBBWKYNCsRIM(TVemMSLOsMHnU);
		byte[] array2 = null;
		int num = array.Length;
		byte b = 0;
		if (num <= 31)
		{
			b = (byte)(160 + (byte)num);
			wDMVGvkcmVjej.WriteByte(b);
		}
		else if (num <= 255)
		{
			b = 217;
			wDMVGvkcmVjej.WriteByte(217);
			b = (byte)num;
			wDMVGvkcmVjej.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 218;
			wDMVGvkcmVjej.WriteByte(218);
			array2 = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes((short)num));
			wDMVGvkcmVjej.Write(array2, 0, array2.Length);
		}
		else
		{
			b = 219;
			wDMVGvkcmVjej.WriteByte(219);
			array2 = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes(num));
			wDMVGvkcmVjej.Write(array2, 0, array2.Length);
		}
		wDMVGvkcmVjej.Write(array, 0, array.Length);
	}

	public static void QPToAWBUdA(Stream IJjSediOvYUQs, byte[] osVIpUnoIDZyI)
	{
		byte[] array = null;
		int num = osVIpUnoIDZyI.Length;
		byte b = 0;
		if (num <= 255)
		{
			b = 196;
			IJjSediOvYUQs.WriteByte(196);
			b = (byte)num;
			IJjSediOvYUQs.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 197;
			IJjSediOvYUQs.WriteByte(197);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes((short)num));
			IJjSediOvYUQs.Write(array, 0, array.Length);
		}
		else
		{
			b = 198;
			IJjSediOvYUQs.WriteByte(198);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes(num));
			IJjSediOvYUQs.Write(array, 0, array.Length);
		}
		IJjSediOvYUQs.Write(osVIpUnoIDZyI, 0, osVIpUnoIDZyI.Length);
	}

	public static void AFWbpakubLdkcs(Stream XkCpDMZJBhmqN, double lArzvQRrSumctgd)
	{
		XkCpDMZJBhmqN.WriteByte(203);
		XkCpDMZJBhmqN.Write(mvCuPdYBvDWOQ.ygZzTNMBROB(lArzvQRrSumctgd), 0, 8);
	}

	public static void KAWeTPTNJBCHKdi(Stream ehOuIBKyqphyMBwtbI, float HLZYjVOLODOAuLo)
	{
		ehOuIBKyqphyMBwtbI.WriteByte(202);
		ehOuIBKyqphyMBwtbI.Write(mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes(HLZYjVOLODOAuLo)), 0, 4);
	}

	public static void pWHGMOqdRJmvuVz(Stream HNqwUBbMVilhg, bool tcwnbdspXuY)
	{
		if (tcwnbdspXuY)
		{
			HNqwUBbMVilhg.WriteByte(195);
		}
		else
		{
			HNqwUBbMVilhg.WriteByte(194);
		}
	}

	public static void MdOVnsZOsoIID(Stream xojfElxREYNUqT, ulong wbjEzqJuow)
	{
		xojfElxREYNUqT.WriteByte(207);
		byte[] bytes = BitConverter.GetBytes(wbjEzqJuow);
		xojfElxREYNUqT.Write(mvCuPdYBvDWOQ.pzfCndFTSze(bytes), 0, 8);
	}

	public static void yuojjlymkN(Stream pYoQKRzxYlr, long OAUKemKarspHT)
	{
		if (OAUKemKarspHT >= 0L)
		{
			if (OAUKemKarspHT <= 127L)
			{
				pYoQKRzxYlr.WriteByte((byte)OAUKemKarspHT);
			}
			else if (OAUKemKarspHT <= 255L)
			{
				pYoQKRzxYlr.WriteByte(204);
				pYoQKRzxYlr.WriteByte((byte)OAUKemKarspHT);
			}
			else if (OAUKemKarspHT <= 65535L)
			{
				pYoQKRzxYlr.WriteByte(205);
				pYoQKRzxYlr.Write(mvCuPdYBvDWOQ.iKNoEvwUXZyU((short)OAUKemKarspHT), 0, 2);
			}
			else if (OAUKemKarspHT <= 4294967295L)
			{
				pYoQKRzxYlr.WriteByte(206);
				pYoQKRzxYlr.Write(mvCuPdYBvDWOQ.xdMxdsWitnKng((int)OAUKemKarspHT), 0, 4);
			}
			else
			{
				pYoQKRzxYlr.WriteByte(211);
				pYoQKRzxYlr.Write(mvCuPdYBvDWOQ.BIrLgqjtjgXB(OAUKemKarspHT), 0, 8);
			}
		}
		else if (OAUKemKarspHT <= -2147483648L)
		{
			pYoQKRzxYlr.WriteByte(211);
			pYoQKRzxYlr.Write(mvCuPdYBvDWOQ.BIrLgqjtjgXB(OAUKemKarspHT), 0, 8);
		}
		else if (OAUKemKarspHT <= -32768L)
		{
			pYoQKRzxYlr.WriteByte(210);
			pYoQKRzxYlr.Write(mvCuPdYBvDWOQ.xdMxdsWitnKng((int)OAUKemKarspHT), 0, 4);
		}
		else if (OAUKemKarspHT <= -128L)
		{
			pYoQKRzxYlr.WriteByte(209);
			pYoQKRzxYlr.Write(mvCuPdYBvDWOQ.iKNoEvwUXZyU((short)OAUKemKarspHT), 0, 2);
		}
		else if (OAUKemKarspHT <= -32L)
		{
			pYoQKRzxYlr.WriteByte(208);
			pYoQKRzxYlr.WriteByte((byte)OAUKemKarspHT);
		}
		else
		{
			pYoQKRzxYlr.WriteByte((byte)OAUKemKarspHT);
		}
	}
}
