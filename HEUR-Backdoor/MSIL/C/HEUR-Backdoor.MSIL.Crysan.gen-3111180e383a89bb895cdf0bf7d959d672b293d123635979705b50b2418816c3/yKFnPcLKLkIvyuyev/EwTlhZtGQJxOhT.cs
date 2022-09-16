using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace yKFnPcLKLkIvyuyev;

public class EwTlhZtGQJxOhT : IEnumerable
{
	private string GtUtIFPEoQ;

	private string JZwlOJsrATZWGYdn;

	private object jziIXeNKGekNZl;

	private lNUfSareFBCz ECyokbwZrangcGW;

	private EwTlhZtGQJxOhT djrnEHXMRzw;

	private List<EwTlhZtGQJxOhT> QANJhPrhTXJmRz = new List<EwTlhZtGQJxOhT>();

	private RqNoDYNBrtlGK BUeuofSUkBtMKm;

	public string NTyFKfiOUtVE
	{
		get
		{
			return DDUCNvCkJtar();
		}
		set
		{
			DwBvpudbGNXeL(value);
		}
	}

	public long lPYlSfAkNDFbqukE
	{
		get
		{
			return gUZgEfrxhd();
		}
		set
		{
			vKjIWsOitiMS(value);
		}
	}

	public double aJqinwNlftfXz
	{
		get
		{
			return CUbnOZpHHuOe();
		}
		set
		{
			qXfBFXQEGvf(value);
		}
	}

	public RqNoDYNBrtlGK mCJbczyqeX
	{
		get
		{
			lock (this)
			{
				if (BUeuofSUkBtMKm == null)
				{
					BUeuofSUkBtMKm = new RqNoDYNBrtlGK(this, QANJhPrhTXJmRz);
				}
			}
			return BUeuofSUkBtMKm;
		}
	}

	public lNUfSareFBCz GrbpKPhaYAvdMs => ECyokbwZrangcGW;

	private void mPNJxLcDkEN(string bXxwPqeeQFXuKba)
	{
		GtUtIFPEoQ = bXxwPqeeQFXuKba;
		JZwlOJsrATZWGYdn = GtUtIFPEoQ.ToLower();
	}

	private void vgROUJxNrc()
	{
		for (int i = 0; i < QANJhPrhTXJmRz.Count; i++)
		{
			QANJhPrhTXJmRz[i].vgROUJxNrc();
		}
		QANJhPrhTXJmRz.Clear();
	}

	private EwTlhZtGQJxOhT atcrZOxcBwW()
	{
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = new EwTlhZtGQJxOhT();
		ewTlhZtGQJxOhT.djrnEHXMRzw = this;
		QANJhPrhTXJmRz.Add(ewTlhZtGQJxOhT);
		return ewTlhZtGQJxOhT;
	}

	private int rSLxGcnDoBh(string MRyxLaAkdlIkR)
	{
		int num = -1;
		int result = -1;
		string text = MRyxLaAkdlIkR.ToLower();
		foreach (EwTlhZtGQJxOhT item in QANJhPrhTXJmRz)
		{
			num++;
			if (text.Equals(item.JZwlOJsrATZWGYdn))
			{
				return num;
			}
		}
		return result;
	}

	public EwTlhZtGQJxOhT LRbgDhCHop(string KABZQlvMOyBCpWc)
	{
		int num = rSLxGcnDoBh(KABZQlvMOyBCpWc);
		if (num == -1)
		{
			return null;
		}
		return QANJhPrhTXJmRz[num];
	}

	private EwTlhZtGQJxOhT xZJuOSOxJgW()
	{
		if (ECyokbwZrangcGW != lNUfSareFBCz.ZUhRyaHWTIiEl)
		{
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.ZUhRyaHWTIiEl;
		}
		return atcrZOxcBwW();
	}

	private EwTlhZtGQJxOhT WmtSYMSEcfwl()
	{
		if (ECyokbwZrangcGW != lNUfSareFBCz.hsnmYVJudSIgE)
		{
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.hsnmYVJudSIgE;
		}
		return atcrZOxcBwW();
	}

	public EwTlhZtGQJxOhT GSuuEGyMzXMC()
	{
		return WmtSYMSEcfwl();
	}

	private void LgTZGEMOOsKm(Stream OnqexAOrrFBI)
	{
		int count = QANJhPrhTXJmRz.Count;
		if (count <= 15)
		{
			byte value = (byte)(128 + (byte)count);
			OnqexAOrrFBI.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 222;
			OnqexAOrrFBI.WriteByte(222);
			byte[] array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes((short)count));
			OnqexAOrrFBI.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 223;
			OnqexAOrrFBI.WriteByte(223);
			byte[] array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes(count));
			OnqexAOrrFBI.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			dUIwPxSPhBdVvD.YFgoTIZkwVKZDT(OnqexAOrrFBI, QANJhPrhTXJmRz[i].GtUtIFPEoQ);
			QANJhPrhTXJmRz[i].aKhaMMNrQEVzu(OnqexAOrrFBI);
		}
	}

	private void kAHbpoPpRaMa(Stream GDWmDTVDKwmEB)
	{
		int count = QANJhPrhTXJmRz.Count;
		if (count <= 15)
		{
			byte value = (byte)(144 + (byte)count);
			GDWmDTVDKwmEB.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 220;
			GDWmDTVDKwmEB.WriteByte(220);
			byte[] array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes((short)count));
			GDWmDTVDKwmEB.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 221;
			GDWmDTVDKwmEB.WriteByte(221);
			byte[] array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(BitConverter.GetBytes(count));
			GDWmDTVDKwmEB.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			QANJhPrhTXJmRz[i].aKhaMMNrQEVzu(GDWmDTVDKwmEB);
		}
	}

	public void vKjIWsOitiMS(long ozbKnMkJRWKsvBDN)
	{
		jziIXeNKGekNZl = ozbKnMkJRWKsvBDN;
		ECyokbwZrangcGW = lNUfSareFBCz.jUeDqezXVgjvrGHg;
	}

	public void JgIWmUellfWH(ulong BdcrsywyfopAn)
	{
		jziIXeNKGekNZl = BdcrsywyfopAn;
		ECyokbwZrangcGW = lNUfSareFBCz.nMQOuzHwbQXP;
	}

	public ulong AolsykESdHQ()
	{
		return ECyokbwZrangcGW switch
		{
			lNUfSareFBCz.MDDmqTFHIKA => ulong.Parse(jziIXeNKGekNZl.ToString()!.Trim()), 
			lNUfSareFBCz.jUeDqezXVgjvrGHg => Convert.ToUInt64((long)jziIXeNKGekNZl), 
			lNUfSareFBCz.nMQOuzHwbQXP => (ulong)jziIXeNKGekNZl, 
			lNUfSareFBCz.fDkGrDbfogiQK => Convert.ToUInt64((double)jziIXeNKGekNZl), 
			lNUfSareFBCz.UeYxDsmWasRGwF => Convert.ToUInt64((float)jziIXeNKGekNZl), 
			lNUfSareFBCz.BwkdunbFWqJJSM => Convert.ToUInt64((DateTime)jziIXeNKGekNZl), 
			_ => 0uL, 
		};
	}

	public long gUZgEfrxhd()
	{
		return ECyokbwZrangcGW switch
		{
			lNUfSareFBCz.MDDmqTFHIKA => long.Parse(jziIXeNKGekNZl.ToString()!.Trim()), 
			lNUfSareFBCz.jUeDqezXVgjvrGHg => (long)jziIXeNKGekNZl, 
			lNUfSareFBCz.nMQOuzHwbQXP => Convert.ToInt64((long)jziIXeNKGekNZl), 
			lNUfSareFBCz.fDkGrDbfogiQK => Convert.ToInt64((double)jziIXeNKGekNZl), 
			lNUfSareFBCz.UeYxDsmWasRGwF => Convert.ToInt64((float)jziIXeNKGekNZl), 
			lNUfSareFBCz.BwkdunbFWqJJSM => Convert.ToInt64((DateTime)jziIXeNKGekNZl), 
			_ => 0L, 
		};
	}

	public double CUbnOZpHHuOe()
	{
		return ECyokbwZrangcGW switch
		{
			lNUfSareFBCz.MDDmqTFHIKA => double.Parse((string)jziIXeNKGekNZl), 
			lNUfSareFBCz.jUeDqezXVgjvrGHg => Convert.ToDouble((long)jziIXeNKGekNZl), 
			lNUfSareFBCz.fDkGrDbfogiQK => (double)jziIXeNKGekNZl, 
			lNUfSareFBCz.UeYxDsmWasRGwF => (float)jziIXeNKGekNZl, 
			lNUfSareFBCz.BwkdunbFWqJJSM => Convert.ToInt64((DateTime)jziIXeNKGekNZl), 
			_ => 0.0, 
		};
	}

	public void ILQgntcMgNJoqn(byte[] waLJKExWSVqX)
	{
		jziIXeNKGekNZl = waLJKExWSVqX;
		ECyokbwZrangcGW = lNUfSareFBCz.EnxXOuvYTy;
	}

	public byte[] zTmwNdOTsSFoX()
	{
		return ECyokbwZrangcGW switch
		{
			lNUfSareFBCz.MDDmqTFHIKA => ArcLSVHldVsl.vStUhhEpPekZ(jziIXeNKGekNZl.ToString()), 
			lNUfSareFBCz.jUeDqezXVgjvrGHg => BitConverter.GetBytes((long)jziIXeNKGekNZl), 
			lNUfSareFBCz.fDkGrDbfogiQK => BitConverter.GetBytes((double)jziIXeNKGekNZl), 
			lNUfSareFBCz.UeYxDsmWasRGwF => BitConverter.GetBytes((float)jziIXeNKGekNZl), 
			lNUfSareFBCz.BwkdunbFWqJJSM => BitConverter.GetBytes(((DateTime)jziIXeNKGekNZl).ToBinary()), 
			lNUfSareFBCz.EnxXOuvYTy => (byte[])jziIXeNKGekNZl, 
			_ => new byte[0], 
		};
	}

	public void WosvelobfJ(string kHpuTlXaHDtByC, string CrhNSmEfiqYd)
	{
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = WmtSYMSEcfwl();
		ewTlhZtGQJxOhT.GtUtIFPEoQ = kHpuTlXaHDtByC;
		ewTlhZtGQJxOhT.DwBvpudbGNXeL(CrhNSmEfiqYd);
	}

	public void DwJSCYVhvMCrZhr(string yvxbvQHAPwzJal, int hDdhwgpnCwFa)
	{
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = WmtSYMSEcfwl();
		ewTlhZtGQJxOhT.GtUtIFPEoQ = yvxbvQHAPwzJal;
		ewTlhZtGQJxOhT.vKjIWsOitiMS(hDdhwgpnCwFa);
	}

	public bool rpzTrBupAHaPm(string krYfUNgRbISG)
	{
		if (File.Exists(krYfUNgRbISG))
		{
			byte[] array = null;
			FileStream fileStream = new FileStream(krYfUNgRbISG, FileMode.Open, FileAccess.Read, FileShare.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			fileStream.Dispose();
			ILQgntcMgNJoqn(array);
			return true;
		}
		return false;
	}

	public bool cepepEvtxhqey(string KFtSljhEvu)
	{
		if (jziIXeNKGekNZl != null)
		{
			FileStream fileStream = new FileStream(KFtSljhEvu, FileMode.Append);
			fileStream.Write((byte[])jziIXeNKGekNZl, 0, ((byte[])jziIXeNKGekNZl).Length);
			fileStream.Close();
			fileStream.Dispose();
			return true;
		}
		return false;
	}

	public EwTlhZtGQJxOhT RjmBfFMUGNiO(string qbUNORpPjHWAPR)
	{
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = this;
		string[] array = qbUNORpPjHWAPR.Trim().Split('.', '/', '\\');
		string text = null;
		if (array.Length == 0)
		{
			return null;
		}
		if (array.Length > 1)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				text = array[i];
				EwTlhZtGQJxOhT ewTlhZtGQJxOhT2 = ewTlhZtGQJxOhT.LRbgDhCHop(text);
				if (ewTlhZtGQJxOhT2 == null)
				{
					ewTlhZtGQJxOhT = ewTlhZtGQJxOhT.xZJuOSOxJgW();
					ewTlhZtGQJxOhT.mPNJxLcDkEN(text);
				}
				else
				{
					ewTlhZtGQJxOhT = ewTlhZtGQJxOhT2;
				}
			}
		}
		text = array[^1];
		int num = ewTlhZtGQJxOhT.rSLxGcnDoBh(text);
		if (num > -1)
		{
			return ewTlhZtGQJxOhT.QANJhPrhTXJmRz[num];
		}
		ewTlhZtGQJxOhT = ewTlhZtGQJxOhT.xZJuOSOxJgW();
		ewTlhZtGQJxOhT.mPNJxLcDkEN(text);
		return ewTlhZtGQJxOhT;
	}

	public void wfaQnJABMLBUQA()
	{
		vgROUJxNrc();
		jziIXeNKGekNZl = null;
		ECyokbwZrangcGW = lNUfSareFBCz.tRyOJfnujzoseF;
	}

	public void DwBvpudbGNXeL(string sDGqPBADUuq)
	{
		jziIXeNKGekNZl = sDGqPBADUuq;
		ECyokbwZrangcGW = lNUfSareFBCz.MDDmqTFHIKA;
	}

	public string DDUCNvCkJtar()
	{
		if (jziIXeNKGekNZl == null)
		{
			return "";
		}
		return jziIXeNKGekNZl.ToString();
	}

	public void ivDpQXNPnujx(bool hCOOopjqovhLqKqj)
	{
		ECyokbwZrangcGW = lNUfSareFBCz.OJNrWntZLr;
		jziIXeNKGekNZl = hCOOopjqovhLqKqj;
	}

	public void TiUtRXgDqcL(float UctbolJMTswCR)
	{
		ECyokbwZrangcGW = lNUfSareFBCz.UeYxDsmWasRGwF;
		jziIXeNKGekNZl = UctbolJMTswCR;
	}

	public void qXfBFXQEGvf(double KIvYxXQpdljkYs)
	{
		ECyokbwZrangcGW = lNUfSareFBCz.fDkGrDbfogiQK;
		jziIXeNKGekNZl = KIvYxXQpdljkYs;
	}

	public void uTiCyKWwObK(byte[] XhfGbXJbanktp)
	{
		using MemoryStream memoryStream = new MemoryStream();
		XhfGbXJbanktp = NGisxejvQwVr.qIWGxapWynhKI(XhfGbXJbanktp);
		memoryStream.Write(XhfGbXJbanktp, 0, XhfGbXJbanktp.Length);
		memoryStream.Position = 0L;
		ZhkSnPAmBBTN(memoryStream);
	}

	public void VFNtaCPROdjA(string lDANKWBkUQYJuiuSQ)
	{
		FileStream fileStream = new FileStream(lDANKWBkUQYJuiuSQ, FileMode.Open);
		ZhkSnPAmBBTN(fileStream);
		fileStream.Dispose();
	}

	public void ZhkSnPAmBBTN(Stream zJuakzDkVDAetEQ)
	{
		byte b = (byte)zJuakzDkVDAetEQ.ReadByte();
		byte[] array = null;
		int num = 0;
		int num2 = 0;
		if (b <= 127)
		{
			vKjIWsOitiMS(b);
			return;
		}
		if (b >= 128 && b <= 143)
		{
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.ZUhRyaHWTIiEl;
			num = b - 128;
			for (num2 = 0; num2 < num; num2++)
			{
				EwTlhZtGQJxOhT ewTlhZtGQJxOhT = atcrZOxcBwW();
				ewTlhZtGQJxOhT.mPNJxLcDkEN(OqorelcqEXXMs.DqGyjaPViSShn(zJuakzDkVDAetEQ));
				ewTlhZtGQJxOhT.ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			return;
		}
		if (b >= 144 && b <= 159)
		{
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.hsnmYVJudSIgE;
			num = b - 144;
			for (num2 = 0; num2 < num; num2++)
			{
				atcrZOxcBwW().ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			return;
		}
		if (b >= 160 && b <= 191)
		{
			num = b - 160;
			DwBvpudbGNXeL(OqorelcqEXXMs.BekNPmXkceiLSQ(zJuakzDkVDAetEQ, num));
			return;
		}
		if (b >= 224 && b <= byte.MaxValue)
		{
			vKjIWsOitiMS((sbyte)b);
			return;
		}
		switch (b)
		{
		case 192:
			wfaQnJABMLBUQA();
			return;
		case 193:
			throw new Exception("(never used) type $c1");
		case 194:
			ivDpQXNPnujx(hCOOopjqovhLqKqj: false);
			return;
		case 195:
			ivDpQXNPnujx(hCOOopjqovhLqKqj: true);
			return;
		case 196:
			num = zJuakzDkVDAetEQ.ReadByte();
			array = new byte[num];
			zJuakzDkVDAetEQ.Read(array, 0, num);
			ILQgntcMgNJoqn(array);
			return;
		case 197:
			array = new byte[2];
			zJuakzDkVDAetEQ.Read(array, 0, 2);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToUInt16(array, 0);
			array = new byte[num];
			zJuakzDkVDAetEQ.Read(array, 0, num);
			ILQgntcMgNJoqn(array);
			return;
		case 198:
			array = new byte[4];
			zJuakzDkVDAetEQ.Read(array, 0, 4);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToInt32(array, 0);
			array = new byte[num];
			zJuakzDkVDAetEQ.Read(array, 0, num);
			ILQgntcMgNJoqn(array);
			return;
		case 202:
			array = new byte[4];
			zJuakzDkVDAetEQ.Read(array, 0, 4);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			TiUtRXgDqcL(BitConverter.ToSingle(array, 0));
			return;
		case 203:
			array = new byte[8];
			zJuakzDkVDAetEQ.Read(array, 0, 8);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			qXfBFXQEGvf(BitConverter.ToDouble(array, 0));
			return;
		case 204:
			b = (byte)zJuakzDkVDAetEQ.ReadByte();
			vKjIWsOitiMS(b);
			return;
		case 205:
			array = new byte[2];
			zJuakzDkVDAetEQ.Read(array, 0, 2);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			vKjIWsOitiMS(BitConverter.ToUInt16(array, 0));
			return;
		case 206:
			array = new byte[4];
			zJuakzDkVDAetEQ.Read(array, 0, 4);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			vKjIWsOitiMS(BitConverter.ToUInt32(array, 0));
			return;
		case 207:
			array = new byte[8];
			zJuakzDkVDAetEQ.Read(array, 0, 8);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			JgIWmUellfWH(BitConverter.ToUInt64(array, 0));
			return;
		case 220:
			array = new byte[2];
			zJuakzDkVDAetEQ.Read(array, 0, 2);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToInt16(array, 0);
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.hsnmYVJudSIgE;
			for (num2 = 0; num2 < num; num2++)
			{
				atcrZOxcBwW().ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			return;
		case 221:
			array = new byte[4];
			zJuakzDkVDAetEQ.Read(array, 0, 4);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToInt16(array, 0);
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.hsnmYVJudSIgE;
			for (num2 = 0; num2 < num; num2++)
			{
				atcrZOxcBwW().ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			return;
		case 217:
			DwBvpudbGNXeL(OqorelcqEXXMs.GBcBiSiAjhsWaeC(b, zJuakzDkVDAetEQ));
			return;
		case 222:
			array = new byte[2];
			zJuakzDkVDAetEQ.Read(array, 0, 2);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToInt16(array, 0);
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.ZUhRyaHWTIiEl;
			for (num2 = 0; num2 < num; num2++)
			{
				EwTlhZtGQJxOhT ewTlhZtGQJxOhT2 = atcrZOxcBwW();
				ewTlhZtGQJxOhT2.mPNJxLcDkEN(OqorelcqEXXMs.DqGyjaPViSShn(zJuakzDkVDAetEQ));
				ewTlhZtGQJxOhT2.ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			return;
		case 199:
		case 200:
		case 201:
			throw new Exception("(ext8,ext16,ex32) type $c7,$c8,$c9");
		}
		switch (b)
		{
		case 222:
			array = new byte[2];
			zJuakzDkVDAetEQ.Read(array, 0, 2);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToInt16(array, 0);
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.ZUhRyaHWTIiEl;
			for (num2 = 0; num2 < num; num2++)
			{
				EwTlhZtGQJxOhT ewTlhZtGQJxOhT4 = atcrZOxcBwW();
				ewTlhZtGQJxOhT4.mPNJxLcDkEN(OqorelcqEXXMs.DqGyjaPViSShn(zJuakzDkVDAetEQ));
				ewTlhZtGQJxOhT4.ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			break;
		case 223:
			array = new byte[4];
			zJuakzDkVDAetEQ.Read(array, 0, 4);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			num = BitConverter.ToInt32(array, 0);
			vgROUJxNrc();
			ECyokbwZrangcGW = lNUfSareFBCz.ZUhRyaHWTIiEl;
			for (num2 = 0; num2 < num; num2++)
			{
				EwTlhZtGQJxOhT ewTlhZtGQJxOhT3 = atcrZOxcBwW();
				ewTlhZtGQJxOhT3.mPNJxLcDkEN(OqorelcqEXXMs.DqGyjaPViSShn(zJuakzDkVDAetEQ));
				ewTlhZtGQJxOhT3.ZhkSnPAmBBTN(zJuakzDkVDAetEQ);
			}
			break;
		case 218:
			DwBvpudbGNXeL(OqorelcqEXXMs.GBcBiSiAjhsWaeC(b, zJuakzDkVDAetEQ));
			break;
		case 219:
			DwBvpudbGNXeL(OqorelcqEXXMs.GBcBiSiAjhsWaeC(b, zJuakzDkVDAetEQ));
			break;
		case 208:
			vKjIWsOitiMS((sbyte)zJuakzDkVDAetEQ.ReadByte());
			break;
		case 209:
			array = new byte[2];
			zJuakzDkVDAetEQ.Read(array, 0, 2);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			vKjIWsOitiMS(BitConverter.ToInt16(array, 0));
			break;
		case 210:
			array = new byte[4];
			zJuakzDkVDAetEQ.Read(array, 0, 4);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			vKjIWsOitiMS(BitConverter.ToInt32(array, 0));
			break;
		case 211:
			array = new byte[8];
			zJuakzDkVDAetEQ.Read(array, 0, 8);
			array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
			vKjIWsOitiMS(BitConverter.ToInt64(array, 0));
			break;
		}
	}

	public byte[] zdVHdMvzwJZJVpl()
	{
		using MemoryStream memoryStream = new MemoryStream();
		aKhaMMNrQEVzu(memoryStream);
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Position = 0L;
		memoryStream.Read(array, 0, (int)memoryStream.Length);
		return NGisxejvQwVr.erJxJWuxfPFAW(array);
	}

	public void aKhaMMNrQEVzu(Stream wAMJruSamFKlfSQrtp)
	{
		switch (ECyokbwZrangcGW)
		{
		default:
			dUIwPxSPhBdVvD.odDBglmIgiW(wAMJruSamFKlfSQrtp);
			break;
		case lNUfSareFBCz.ifTdIRWbxUg:
		case lNUfSareFBCz.tRyOJfnujzoseF:
			dUIwPxSPhBdVvD.odDBglmIgiW(wAMJruSamFKlfSQrtp);
			break;
		case lNUfSareFBCz.ZUhRyaHWTIiEl:
			LgTZGEMOOsKm(wAMJruSamFKlfSQrtp);
			break;
		case lNUfSareFBCz.hsnmYVJudSIgE:
			kAHbpoPpRaMa(wAMJruSamFKlfSQrtp);
			break;
		case lNUfSareFBCz.MDDmqTFHIKA:
			dUIwPxSPhBdVvD.YFgoTIZkwVKZDT(wAMJruSamFKlfSQrtp, (string)jziIXeNKGekNZl);
			break;
		case lNUfSareFBCz.jUeDqezXVgjvrGHg:
			dUIwPxSPhBdVvD.RqjIOFkEtcQhaum(wAMJruSamFKlfSQrtp, (long)jziIXeNKGekNZl);
			break;
		case lNUfSareFBCz.nMQOuzHwbQXP:
			dUIwPxSPhBdVvD.ILmtfFtHtWd(wAMJruSamFKlfSQrtp, (ulong)jziIXeNKGekNZl);
			break;
		case lNUfSareFBCz.OJNrWntZLr:
			dUIwPxSPhBdVvD.HpZZOCafuaGKn(wAMJruSamFKlfSQrtp, (bool)jziIXeNKGekNZl);
			break;
		case lNUfSareFBCz.fDkGrDbfogiQK:
			dUIwPxSPhBdVvD.yRjHBjGrtaAk(wAMJruSamFKlfSQrtp, (double)jziIXeNKGekNZl);
			break;
		case lNUfSareFBCz.UeYxDsmWasRGwF:
			dUIwPxSPhBdVvD.yRjHBjGrtaAk(wAMJruSamFKlfSQrtp, (float)jziIXeNKGekNZl);
			break;
		case lNUfSareFBCz.BwkdunbFWqJJSM:
			dUIwPxSPhBdVvD.RqjIOFkEtcQhaum(wAMJruSamFKlfSQrtp, gUZgEfrxhd());
			break;
		case lNUfSareFBCz.EnxXOuvYTy:
			dUIwPxSPhBdVvD.KMiyUincHZKml(wAMJruSamFKlfSQrtp, (byte[])jziIXeNKGekNZl);
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new GPaSREEQwv(QANJhPrhTXJmRz);
	}
}
