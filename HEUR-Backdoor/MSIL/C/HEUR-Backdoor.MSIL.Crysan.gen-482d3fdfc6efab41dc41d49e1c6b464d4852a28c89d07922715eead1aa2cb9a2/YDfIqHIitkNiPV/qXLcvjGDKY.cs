using System;
using System.IO;

namespace YDfIqHIitkNiPV;

internal class qXLcvjGDKY
{
	public static void oxXPsChDsXZlg(Stream iFIiFoiDLdQbir)
	{
		iFIiFoiDLdQbir.WriteByte(192);
	}

	public static void EXqLXcQKRfIp(Stream TnqnWPjoDykqRBke, string LcjknHHIsE)
	{
		byte[] array = UOsdaDuvXGt.qHQdBeXzvCjzzZP(LcjknHHIsE);
		byte[] array2 = null;
		int num = array.Length;
		byte b = 0;
		if (num <= 31)
		{
			b = (byte)(160 + (byte)num);
			TnqnWPjoDykqRBke.WriteByte(b);
		}
		else if (num <= 255)
		{
			b = 217;
			TnqnWPjoDykqRBke.WriteByte(217);
			b = (byte)num;
			TnqnWPjoDykqRBke.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 218;
			TnqnWPjoDykqRBke.WriteByte(218);
			array2 = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes((short)num));
			TnqnWPjoDykqRBke.Write(array2, 0, array2.Length);
		}
		else
		{
			b = 219;
			TnqnWPjoDykqRBke.WriteByte(219);
			array2 = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes(num));
			TnqnWPjoDykqRBke.Write(array2, 0, array2.Length);
		}
		TnqnWPjoDykqRBke.Write(array, 0, array.Length);
	}

	public static void viTNlocAQtZq(Stream FjymUKEbfiyGkn, byte[] kTztNtmemAxST)
	{
		byte[] array = null;
		int num = kTztNtmemAxST.Length;
		byte b = 0;
		if (num <= 255)
		{
			b = 196;
			FjymUKEbfiyGkn.WriteByte(196);
			b = (byte)num;
			FjymUKEbfiyGkn.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 197;
			FjymUKEbfiyGkn.WriteByte(197);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes((short)num));
			FjymUKEbfiyGkn.Write(array, 0, array.Length);
		}
		else
		{
			b = 198;
			FjymUKEbfiyGkn.WriteByte(198);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes(num));
			FjymUKEbfiyGkn.Write(array, 0, array.Length);
		}
		FjymUKEbfiyGkn.Write(kTztNtmemAxST, 0, kTztNtmemAxST.Length);
	}

	public static void EzgdKlCAZNTrGKSS(Stream vgZUWUGfjJFHWQ, double EWpJAdzWSMaqD)
	{
		vgZUWUGfjJFHWQ.WriteByte(203);
		vgZUWUGfjJFHWQ.Write(UOsdaDuvXGt.iMfNqqZMYYa(EWpJAdzWSMaqD), 0, 8);
	}

	public static void FrhXdujfLfDXYY(Stream NfKnDXtkcuG, float mXrOKJbOxNUCNd)
	{
		NfKnDXtkcuG.WriteByte(202);
		NfKnDXtkcuG.Write(UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes(mXrOKJbOxNUCNd)), 0, 4);
	}

	public static void mljrRzpAwAoiwid(Stream wCRbyExehxInF, bool GIAZUAJGiXsfSRQs)
	{
		if (GIAZUAJGiXsfSRQs)
		{
			wCRbyExehxInF.WriteByte(195);
		}
		else
		{
			wCRbyExehxInF.WriteByte(194);
		}
	}

	public static void XQnFdotlVthHH(Stream mLeUVuFfRdgqP, ulong sZOMmHmOYID)
	{
		mLeUVuFfRdgqP.WriteByte(207);
		byte[] bytes = BitConverter.GetBytes(sZOMmHmOYID);
		mLeUVuFfRdgqP.Write(UOsdaDuvXGt.ejlbQgoHCEAYu(bytes), 0, 8);
	}

	public static void sRRMBxluTLRNpG(Stream wMaXkMusrzk, long ZHhEQmtsclkdVO)
	{
		if (ZHhEQmtsclkdVO >= 0L)
		{
			if (ZHhEQmtsclkdVO <= 127L)
			{
				wMaXkMusrzk.WriteByte((byte)ZHhEQmtsclkdVO);
			}
			else if (ZHhEQmtsclkdVO <= 255L)
			{
				wMaXkMusrzk.WriteByte(204);
				wMaXkMusrzk.WriteByte((byte)ZHhEQmtsclkdVO);
			}
			else if (ZHhEQmtsclkdVO <= 65535L)
			{
				wMaXkMusrzk.WriteByte(205);
				wMaXkMusrzk.Write(UOsdaDuvXGt.nAWUsQpiPGh((short)ZHhEQmtsclkdVO), 0, 2);
			}
			else if (ZHhEQmtsclkdVO <= 4294967295L)
			{
				wMaXkMusrzk.WriteByte(206);
				wMaXkMusrzk.Write(UOsdaDuvXGt.hNyMaJxXoI((int)ZHhEQmtsclkdVO), 0, 4);
			}
			else
			{
				wMaXkMusrzk.WriteByte(211);
				wMaXkMusrzk.Write(UOsdaDuvXGt.xCzBXgslsxgs(ZHhEQmtsclkdVO), 0, 8);
			}
		}
		else if (ZHhEQmtsclkdVO <= -2147483648L)
		{
			wMaXkMusrzk.WriteByte(211);
			wMaXkMusrzk.Write(UOsdaDuvXGt.xCzBXgslsxgs(ZHhEQmtsclkdVO), 0, 8);
		}
		else if (ZHhEQmtsclkdVO <= -32768L)
		{
			wMaXkMusrzk.WriteByte(210);
			wMaXkMusrzk.Write(UOsdaDuvXGt.hNyMaJxXoI((int)ZHhEQmtsclkdVO), 0, 4);
		}
		else if (ZHhEQmtsclkdVO <= -128L)
		{
			wMaXkMusrzk.WriteByte(209);
			wMaXkMusrzk.Write(UOsdaDuvXGt.nAWUsQpiPGh((short)ZHhEQmtsclkdVO), 0, 2);
		}
		else if (ZHhEQmtsclkdVO <= -32L)
		{
			wMaXkMusrzk.WriteByte(208);
			wMaXkMusrzk.WriteByte((byte)ZHhEQmtsclkdVO);
		}
		else
		{
			wMaXkMusrzk.WriteByte((byte)ZHhEQmtsclkdVO);
		}
	}
}
