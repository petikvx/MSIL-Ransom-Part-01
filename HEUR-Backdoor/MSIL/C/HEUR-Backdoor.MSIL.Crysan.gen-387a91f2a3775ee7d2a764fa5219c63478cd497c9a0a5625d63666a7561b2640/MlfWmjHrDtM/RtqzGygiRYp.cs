using System;
using System.IO;

namespace MlfWmjHrDtM;

internal class RtqzGygiRYp
{
	public static void xzFNXuePUvStwG(Stream VHeKBiFOiNQmKuJg)
	{
		VHeKBiFOiNQmKuJg.WriteByte(192);
	}

	public static void XiPnSumecxcVevou(Stream idLtejnIdVsx, string fRPEiyCvhSasnv)
	{
		byte[] array = HtHLMJnLldFHH.WYXyyrTeIGtktOJ(fRPEiyCvhSasnv);
		byte[] array2 = null;
		int num = array.Length;
		byte b = 0;
		if (num <= 31)
		{
			b = (byte)(160 + (byte)num);
			idLtejnIdVsx.WriteByte(b);
		}
		else if (num <= 255)
		{
			b = 217;
			idLtejnIdVsx.WriteByte(217);
			b = (byte)num;
			idLtejnIdVsx.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 218;
			idLtejnIdVsx.WriteByte(218);
			array2 = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes((short)num));
			idLtejnIdVsx.Write(array2, 0, array2.Length);
		}
		else
		{
			b = 219;
			idLtejnIdVsx.WriteByte(219);
			array2 = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes(num));
			idLtejnIdVsx.Write(array2, 0, array2.Length);
		}
		idLtejnIdVsx.Write(array, 0, array.Length);
	}

	public static void CnVkTXRwhKEZv(Stream XvnjvYNJqKf, byte[] pTCwGCSYctXjvaK)
	{
		byte[] array = null;
		int num = pTCwGCSYctXjvaK.Length;
		byte b = 0;
		if (num <= 255)
		{
			b = 196;
			XvnjvYNJqKf.WriteByte(196);
			b = (byte)num;
			XvnjvYNJqKf.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 197;
			XvnjvYNJqKf.WriteByte(197);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes((short)num));
			XvnjvYNJqKf.Write(array, 0, array.Length);
		}
		else
		{
			b = 198;
			XvnjvYNJqKf.WriteByte(198);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes(num));
			XvnjvYNJqKf.Write(array, 0, array.Length);
		}
		XvnjvYNJqKf.Write(pTCwGCSYctXjvaK, 0, pTCwGCSYctXjvaK.Length);
	}

	public static void cQuPdKvIRcx(Stream zhfHBHFCEKp, double ZHIvlyGoddIWXCO)
	{
		zhfHBHFCEKp.WriteByte(203);
		zhfHBHFCEKp.Write(HtHLMJnLldFHH.jidQYoFyPEE(ZHIvlyGoddIWXCO), 0, 8);
	}

	public static void cYZEAqfrOjxo(Stream hDEQVHcBhlasW, float lVooEpBINNtX)
	{
		hDEQVHcBhlasW.WriteByte(202);
		hDEQVHcBhlasW.Write(HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes(lVooEpBINNtX)), 0, 4);
	}

	public static void JeAbrKdGAXcuB(Stream EcrrGRZJlkU, bool zMMnrzkioh)
	{
		if (zMMnrzkioh)
		{
			EcrrGRZJlkU.WriteByte(195);
		}
		else
		{
			EcrrGRZJlkU.WriteByte(194);
		}
	}

	public static void uwTFYCNeKBUvJd(Stream okCcTZFCEYAyAY, ulong TgANoGyOYewuy)
	{
		okCcTZFCEYAyAY.WriteByte(207);
		byte[] bytes = BitConverter.GetBytes(TgANoGyOYewuy);
		okCcTZFCEYAyAY.Write(HtHLMJnLldFHH.eVeGzxKKqtkG(bytes), 0, 8);
	}

	public static void bmIcjoqZjnrg(Stream RQNbUYIlfnJ, long oJIFAGPOVOcAA)
	{
		if (oJIFAGPOVOcAA >= 0L)
		{
			if (oJIFAGPOVOcAA <= 127L)
			{
				RQNbUYIlfnJ.WriteByte((byte)oJIFAGPOVOcAA);
			}
			else if (oJIFAGPOVOcAA <= 255L)
			{
				RQNbUYIlfnJ.WriteByte(204);
				RQNbUYIlfnJ.WriteByte((byte)oJIFAGPOVOcAA);
			}
			else if (oJIFAGPOVOcAA <= 65535L)
			{
				RQNbUYIlfnJ.WriteByte(205);
				RQNbUYIlfnJ.Write(HtHLMJnLldFHH.NJzmbIKqqi((short)oJIFAGPOVOcAA), 0, 2);
			}
			else if (oJIFAGPOVOcAA <= 4294967295L)
			{
				RQNbUYIlfnJ.WriteByte(206);
				RQNbUYIlfnJ.Write(HtHLMJnLldFHH.ORcbqcLdDqNCa((int)oJIFAGPOVOcAA), 0, 4);
			}
			else
			{
				RQNbUYIlfnJ.WriteByte(211);
				RQNbUYIlfnJ.Write(HtHLMJnLldFHH.XQOOuzMeQGItXPu(oJIFAGPOVOcAA), 0, 8);
			}
		}
		else if (oJIFAGPOVOcAA <= -2147483648L)
		{
			RQNbUYIlfnJ.WriteByte(211);
			RQNbUYIlfnJ.Write(HtHLMJnLldFHH.XQOOuzMeQGItXPu(oJIFAGPOVOcAA), 0, 8);
		}
		else if (oJIFAGPOVOcAA <= -32768L)
		{
			RQNbUYIlfnJ.WriteByte(210);
			RQNbUYIlfnJ.Write(HtHLMJnLldFHH.ORcbqcLdDqNCa((int)oJIFAGPOVOcAA), 0, 4);
		}
		else if (oJIFAGPOVOcAA <= -128L)
		{
			RQNbUYIlfnJ.WriteByte(209);
			RQNbUYIlfnJ.Write(HtHLMJnLldFHH.NJzmbIKqqi((short)oJIFAGPOVOcAA), 0, 2);
		}
		else if (oJIFAGPOVOcAA <= -32L)
		{
			RQNbUYIlfnJ.WriteByte(208);
			RQNbUYIlfnJ.WriteByte((byte)oJIFAGPOVOcAA);
		}
		else
		{
			RQNbUYIlfnJ.WriteByte((byte)oJIFAGPOVOcAA);
		}
	}
}
