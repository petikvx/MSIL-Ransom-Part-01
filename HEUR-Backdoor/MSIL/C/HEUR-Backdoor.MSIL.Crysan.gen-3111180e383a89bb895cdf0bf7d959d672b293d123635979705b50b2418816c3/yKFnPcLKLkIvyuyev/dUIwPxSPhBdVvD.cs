using System;
using System.IO;

namespace yKFnPcLKLkIvyuyev;

internal class dUIwPxSPhBdVvD
{
	public static void odDBglmIgiW(Stream CeUlCVrivD)
	{
		CeUlCVrivD.WriteByte(192);
	}

	public static void YFgoTIZkwVKZDT(Stream SGmxnYztmJhcyop, string eedCqzMDygxh)
	{
		byte[] array = ArcLSVHldVsl.vStUhhEpPekZ(eedCqzMDygxh);
		byte[] array2 = null;
		int num = array.Length;
		byte b = 0;
		if (num <= 31)
		{
			b = (byte)(160 + (byte)num);
			SGmxnYztmJhcyop.WriteByte(b);
		}
		else if (num <= 255)
		{
			b = 217;
			SGmxnYztmJhcyop.WriteByte(217);
			b = (byte)num;
			SGmxnYztmJhcyop.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 218;
			SGmxnYztmJhcyop.WriteByte(218);
			array2 = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes((short)num));
			SGmxnYztmJhcyop.Write(array2, 0, array2.Length);
		}
		else
		{
			b = 219;
			SGmxnYztmJhcyop.WriteByte(219);
			array2 = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes(num));
			SGmxnYztmJhcyop.Write(array2, 0, array2.Length);
		}
		SGmxnYztmJhcyop.Write(array, 0, array.Length);
	}

	public static void KMiyUincHZKml(Stream CjDEXScUGiBPBo, byte[] mjmPglbUBIwG)
	{
		byte[] array = null;
		int num = mjmPglbUBIwG.Length;
		byte b = 0;
		if (num <= 255)
		{
			b = 196;
			CjDEXScUGiBPBo.WriteByte(196);
			b = (byte)num;
			CjDEXScUGiBPBo.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 197;
			CjDEXScUGiBPBo.WriteByte(197);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes((short)num));
			CjDEXScUGiBPBo.Write(array, 0, array.Length);
		}
		else
		{
			b = 198;
			CjDEXScUGiBPBo.WriteByte(198);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes(num));
			CjDEXScUGiBPBo.Write(array, 0, array.Length);
		}
		CjDEXScUGiBPBo.Write(mjmPglbUBIwG, 0, mjmPglbUBIwG.Length);
	}

	public static void yRjHBjGrtaAk(Stream qQcKOoRtZuO, double TBRSSakGUhEKW)
	{
		qQcKOoRtZuO.WriteByte(203);
		qQcKOoRtZuO.Write(ArcLSVHldVsl.JRHlHOBnVdsT(TBRSSakGUhEKW), 0, 8);
	}

	public static void JaZvqRPFTOd(Stream mlMvPpUGnzt, float YGdZMwZFfwJe)
	{
		mlMvPpUGnzt.WriteByte(202);
		mlMvPpUGnzt.Write(ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes(YGdZMwZFfwJe)), 0, 4);
	}

	public static void HpZZOCafuaGKn(Stream ezuWumlhDa, bool FAKiaxafOTD)
	{
		if (FAKiaxafOTD)
		{
			ezuWumlhDa.WriteByte(195);
		}
		else
		{
			ezuWumlhDa.WriteByte(194);
		}
	}

	public static void ILmtfFtHtWd(Stream ietUPMstsTAE, ulong LmaLDiDJPI)
	{
		ietUPMstsTAE.WriteByte(207);
		byte[] bytes = BitConverter.GetBytes(LmaLDiDJPI);
		ietUPMstsTAE.Write(ArcLSVHldVsl.TvlDPJoCjMDCsQh(bytes), 0, 8);
	}

	public static void RqjIOFkEtcQhaum(Stream XNsRxTMTFQYB, long MQPnkGVITVcEr)
	{
		if (MQPnkGVITVcEr >= 0L)
		{
			if (MQPnkGVITVcEr <= 127L)
			{
				XNsRxTMTFQYB.WriteByte((byte)MQPnkGVITVcEr);
			}
			else if (MQPnkGVITVcEr <= 255L)
			{
				XNsRxTMTFQYB.WriteByte(204);
				XNsRxTMTFQYB.WriteByte((byte)MQPnkGVITVcEr);
			}
			else if (MQPnkGVITVcEr <= 65535L)
			{
				XNsRxTMTFQYB.WriteByte(205);
				XNsRxTMTFQYB.Write(ArcLSVHldVsl.dkESVunFtWvpAVM((short)MQPnkGVITVcEr), 0, 2);
			}
			else if (MQPnkGVITVcEr <= 4294967295L)
			{
				XNsRxTMTFQYB.WriteByte(206);
				XNsRxTMTFQYB.Write(ArcLSVHldVsl.qpyMBRZnwNIwfBh((int)MQPnkGVITVcEr), 0, 4);
			}
			else
			{
				XNsRxTMTFQYB.WriteByte(211);
				XNsRxTMTFQYB.Write(ArcLSVHldVsl.VLgAiYqFOKmag(MQPnkGVITVcEr), 0, 8);
			}
		}
		else if (MQPnkGVITVcEr <= -2147483648L)
		{
			XNsRxTMTFQYB.WriteByte(211);
			XNsRxTMTFQYB.Write(ArcLSVHldVsl.VLgAiYqFOKmag(MQPnkGVITVcEr), 0, 8);
		}
		else if (MQPnkGVITVcEr <= -32768L)
		{
			XNsRxTMTFQYB.WriteByte(210);
			XNsRxTMTFQYB.Write(ArcLSVHldVsl.qpyMBRZnwNIwfBh((int)MQPnkGVITVcEr), 0, 4);
		}
		else if (MQPnkGVITVcEr <= -128L)
		{
			XNsRxTMTFQYB.WriteByte(209);
			XNsRxTMTFQYB.Write(ArcLSVHldVsl.dkESVunFtWvpAVM((short)MQPnkGVITVcEr), 0, 2);
		}
		else if (MQPnkGVITVcEr <= -32L)
		{
			XNsRxTMTFQYB.WriteByte(208);
			XNsRxTMTFQYB.WriteByte((byte)MQPnkGVITVcEr);
		}
		else
		{
			XNsRxTMTFQYB.WriteByte((byte)MQPnkGVITVcEr);
		}
	}
}
