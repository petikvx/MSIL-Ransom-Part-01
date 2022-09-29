using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace lbBmsCGqmaavDk;

public class oBaGoFGSOWPojT : IEnumerable
{
	private string sjpSzEescyvE;

	private string CwWyiBHNvjlBUJnh;

	private object qYGRYBPBpazbkHp;

	private yVFUbarMbQjHDjr KhDAXnEcyHS;

	private oBaGoFGSOWPojT PJkefnGKGkmTkqA;

	private List<oBaGoFGSOWPojT> jnAmlNPgeTIe = new List<oBaGoFGSOWPojT>();

	private KwlmLGAPcIR SditJFSXWI;

	public string UPNpZCCgWUpsQj
	{
		get
		{
			return ONRubSqDxGCZrr();
		}
		set
		{
			ekETxtxcAFPeX(value);
		}
	}

	public long RLIOckwrMmMI
	{
		get
		{
			return XXEfKmYuCbjSze();
		}
		set
		{
			nxUHnDsRRJqvipS(value);
		}
	}

	public double FoBInwpViOY
	{
		get
		{
			return BRUDRxgEKfFM();
		}
		set
		{
			XkRUvuedFdG(value);
		}
	}

	public KwlmLGAPcIR iWKMLYONTKn
	{
		get
		{
			lock (this)
			{
				if (SditJFSXWI == null)
				{
					SditJFSXWI = new KwlmLGAPcIR(this, jnAmlNPgeTIe);
				}
			}
			return SditJFSXWI;
		}
	}

	public yVFUbarMbQjHDjr HEKMMZauVcsx => KhDAXnEcyHS;

	private void VTuidVJqfPN(string BpTFBRlFOLujv)
	{
		sjpSzEescyvE = BpTFBRlFOLujv;
		CwWyiBHNvjlBUJnh = sjpSzEescyvE.ToLower();
	}

	private void rCaRzthqHspC()
	{
		for (int i = 0; i < jnAmlNPgeTIe.Count; i++)
		{
			jnAmlNPgeTIe[i].rCaRzthqHspC();
		}
		jnAmlNPgeTIe.Clear();
	}

	private oBaGoFGSOWPojT yHoLICTlRSwV()
	{
		oBaGoFGSOWPojT oBaGoFGSOWPojT2 = new oBaGoFGSOWPojT();
		oBaGoFGSOWPojT2.PJkefnGKGkmTkqA = this;
		jnAmlNPgeTIe.Add(oBaGoFGSOWPojT2);
		return oBaGoFGSOWPojT2;
	}

	private int QsGVssfYyH(string sLUpASDPNuig)
	{
		int num = -1;
		int result = -1;
		string text = sLUpASDPNuig.ToLower();
		foreach (oBaGoFGSOWPojT item in jnAmlNPgeTIe)
		{
			num++;
			if (text.Equals(item.CwWyiBHNvjlBUJnh))
			{
				return num;
			}
		}
		return result;
	}

	public oBaGoFGSOWPojT huVuAFYbbEuEY(string PGYZCyUYlfDsKOGaH)
	{
		int num = QsGVssfYyH(PGYZCyUYlfDsKOGaH);
		if (num == -1)
		{
			return null;
		}
		return jnAmlNPgeTIe[num];
	}

	private oBaGoFGSOWPojT VbOHODZmMF()
	{
		if (KhDAXnEcyHS != yVFUbarMbQjHDjr.tyiVWxeUQmfVC)
		{
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.tyiVWxeUQmfVC;
		}
		return yHoLICTlRSwV();
	}

	private oBaGoFGSOWPojT XqeRZMoyGIil()
	{
		if (KhDAXnEcyHS != yVFUbarMbQjHDjr.KMnmLPOfRt)
		{
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.KMnmLPOfRt;
		}
		return yHoLICTlRSwV();
	}

	public oBaGoFGSOWPojT GgaebLhDgBbKg()
	{
		return XqeRZMoyGIil();
	}

	private void yKArIGqjInNAFl(Stream WpUrAQzBuJq)
	{
		int count = jnAmlNPgeTIe.Count;
		if (count <= 15)
		{
			byte value = (byte)(128 + (byte)count);
			WpUrAQzBuJq.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 222;
			WpUrAQzBuJq.WriteByte(222);
			byte[] array = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes((short)count));
			WpUrAQzBuJq.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 223;
			WpUrAQzBuJq.WriteByte(223);
			byte[] array = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes(count));
			WpUrAQzBuJq.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			MhMFgxHxtMFZ.OkuEvXyruJsk(WpUrAQzBuJq, jnAmlNPgeTIe[i].sjpSzEescyvE);
			jnAmlNPgeTIe[i].MDqNufHPyNCt(WpUrAQzBuJq);
		}
	}

	private void JHzRRazOqytfJlm(Stream eFgSULWMCWZd)
	{
		int count = jnAmlNPgeTIe.Count;
		if (count <= 15)
		{
			byte value = (byte)(144 + (byte)count);
			eFgSULWMCWZd.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 220;
			eFgSULWMCWZd.WriteByte(220);
			byte[] array = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes((short)count));
			eFgSULWMCWZd.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 221;
			eFgSULWMCWZd.WriteByte(221);
			byte[] array = mvCuPdYBvDWOQ.pzfCndFTSze(BitConverter.GetBytes(count));
			eFgSULWMCWZd.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			jnAmlNPgeTIe[i].MDqNufHPyNCt(eFgSULWMCWZd);
		}
	}

	public void nxUHnDsRRJqvipS(long uWIraVMMeEvJDR)
	{
		qYGRYBPBpazbkHp = uWIraVMMeEvJDR;
		KhDAXnEcyHS = yVFUbarMbQjHDjr.JVAapesJbdempw;
	}

	public void DjwZYVnoORF(ulong pPXeGJsBUqwJHG)
	{
		qYGRYBPBpazbkHp = pPXeGJsBUqwJHG;
		KhDAXnEcyHS = yVFUbarMbQjHDjr.MtiKdcJKpSGsvYku;
	}

	public ulong MvKrVqrCpbnrPR()
	{
		return KhDAXnEcyHS switch
		{
			yVFUbarMbQjHDjr.BLzFgRUmILsbcxY => ulong.Parse(qYGRYBPBpazbkHp.ToString()!.Trim()), 
			yVFUbarMbQjHDjr.JVAapesJbdempw => Convert.ToUInt64((long)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.MtiKdcJKpSGsvYku => (ulong)qYGRYBPBpazbkHp, 
			yVFUbarMbQjHDjr.lIlmauYDEd => Convert.ToUInt64((double)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.VGRiscGOWM => Convert.ToUInt64((float)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.asVhpvsZmbcgic => Convert.ToUInt64((DateTime)qYGRYBPBpazbkHp), 
			_ => 0uL, 
		};
	}

	public long XXEfKmYuCbjSze()
	{
		return KhDAXnEcyHS switch
		{
			yVFUbarMbQjHDjr.BLzFgRUmILsbcxY => long.Parse(qYGRYBPBpazbkHp.ToString()!.Trim()), 
			yVFUbarMbQjHDjr.JVAapesJbdempw => (long)qYGRYBPBpazbkHp, 
			yVFUbarMbQjHDjr.MtiKdcJKpSGsvYku => Convert.ToInt64((long)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.lIlmauYDEd => Convert.ToInt64((double)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.VGRiscGOWM => Convert.ToInt64((float)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.asVhpvsZmbcgic => Convert.ToInt64((DateTime)qYGRYBPBpazbkHp), 
			_ => 0L, 
		};
	}

	public double BRUDRxgEKfFM()
	{
		return KhDAXnEcyHS switch
		{
			yVFUbarMbQjHDjr.BLzFgRUmILsbcxY => double.Parse((string)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.JVAapesJbdempw => Convert.ToDouble((long)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.lIlmauYDEd => (double)qYGRYBPBpazbkHp, 
			yVFUbarMbQjHDjr.VGRiscGOWM => (float)qYGRYBPBpazbkHp, 
			yVFUbarMbQjHDjr.asVhpvsZmbcgic => Convert.ToInt64((DateTime)qYGRYBPBpazbkHp), 
			_ => 0.0, 
		};
	}

	public void cWTSAQwOZb(byte[] wpEHVXQDEKUb)
	{
		qYGRYBPBpazbkHp = wpEHVXQDEKUb;
		KhDAXnEcyHS = yVFUbarMbQjHDjr.wfooKbiSuTb;
	}

	public byte[] HTXWtqsPAAmFp()
	{
		return KhDAXnEcyHS switch
		{
			yVFUbarMbQjHDjr.BLzFgRUmILsbcxY => mvCuPdYBvDWOQ.WJqmZBBWKYNCsRIM(qYGRYBPBpazbkHp.ToString()), 
			yVFUbarMbQjHDjr.JVAapesJbdempw => BitConverter.GetBytes((long)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.lIlmauYDEd => BitConverter.GetBytes((double)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.VGRiscGOWM => BitConverter.GetBytes((float)qYGRYBPBpazbkHp), 
			yVFUbarMbQjHDjr.asVhpvsZmbcgic => BitConverter.GetBytes(((DateTime)qYGRYBPBpazbkHp).ToBinary()), 
			yVFUbarMbQjHDjr.wfooKbiSuTb => (byte[])qYGRYBPBpazbkHp, 
			_ => new byte[0], 
		};
	}

	public void UYJjuFGxLZB(string VFEuzeICphSDg, string ChcOOFbEmbVEcT)
	{
		oBaGoFGSOWPojT obj = XqeRZMoyGIil();
		obj.sjpSzEescyvE = VFEuzeICphSDg;
		obj.ekETxtxcAFPeX(ChcOOFbEmbVEcT);
	}

	public void ruanWvHiiREal(string IYZAsjHjrFAd, int wcUtdbXjIHYy)
	{
		oBaGoFGSOWPojT obj = XqeRZMoyGIil();
		obj.sjpSzEescyvE = IYZAsjHjrFAd;
		obj.nxUHnDsRRJqvipS(wcUtdbXjIHYy);
	}

	public bool iYfzBKGkpfw(string vrbaDWmwTRAJjY)
	{
		if (File.Exists(vrbaDWmwTRAJjY))
		{
			byte[] array = null;
			FileStream fileStream = new FileStream(vrbaDWmwTRAJjY, FileMode.Open, FileAccess.Read, FileShare.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			fileStream.Dispose();
			cWTSAQwOZb(array);
			return true;
		}
		return false;
	}

	public bool LfjMDVTyyDRJdV(string oJeKQhGipxTYfpJE)
	{
		if (qYGRYBPBpazbkHp != null)
		{
			FileStream fileStream = new FileStream(oJeKQhGipxTYfpJE, FileMode.Append);
			fileStream.Write((byte[])qYGRYBPBpazbkHp, 0, ((byte[])qYGRYBPBpazbkHp).Length);
			fileStream.Close();
			fileStream.Dispose();
			return true;
		}
		return false;
	}

	public oBaGoFGSOWPojT MCNaMOuHJPmBBcg(string IfgWRbUcKZ)
	{
		oBaGoFGSOWPojT oBaGoFGSOWPojT2 = this;
		string[] array = IfgWRbUcKZ.Trim().Split('.', '/', '\\');
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
				oBaGoFGSOWPojT oBaGoFGSOWPojT3 = oBaGoFGSOWPojT2.huVuAFYbbEuEY(text);
				if (oBaGoFGSOWPojT3 == null)
				{
					oBaGoFGSOWPojT2 = oBaGoFGSOWPojT2.VbOHODZmMF();
					oBaGoFGSOWPojT2.VTuidVJqfPN(text);
				}
				else
				{
					oBaGoFGSOWPojT2 = oBaGoFGSOWPojT3;
				}
			}
		}
		text = array[^1];
		int num = oBaGoFGSOWPojT2.QsGVssfYyH(text);
		if (num > -1)
		{
			return oBaGoFGSOWPojT2.jnAmlNPgeTIe[num];
		}
		oBaGoFGSOWPojT2 = oBaGoFGSOWPojT2.VbOHODZmMF();
		oBaGoFGSOWPojT2.VTuidVJqfPN(text);
		return oBaGoFGSOWPojT2;
	}

	public void LgYiuMJzwbK()
	{
		rCaRzthqHspC();
		qYGRYBPBpazbkHp = null;
		KhDAXnEcyHS = yVFUbarMbQjHDjr.nrvVJMVmjlyTlZ;
	}

	public void ekETxtxcAFPeX(string JvLkkreatfZLX)
	{
		qYGRYBPBpazbkHp = JvLkkreatfZLX;
		KhDAXnEcyHS = yVFUbarMbQjHDjr.BLzFgRUmILsbcxY;
	}

	public string ONRubSqDxGCZrr()
	{
		if (qYGRYBPBpazbkHp == null)
		{
			return "";
		}
		return qYGRYBPBpazbkHp.ToString();
	}

	public void qKyODyFYQVEt(bool DAnvRgbzPiJ)
	{
		KhDAXnEcyHS = yVFUbarMbQjHDjr.RNPllMmEclWeSO;
		qYGRYBPBpazbkHp = DAnvRgbzPiJ;
	}

	public void fRiOYbmlTphn(float ELBWbcWvXa)
	{
		KhDAXnEcyHS = yVFUbarMbQjHDjr.VGRiscGOWM;
		qYGRYBPBpazbkHp = ELBWbcWvXa;
	}

	public void XkRUvuedFdG(double VeDcgHVxmI)
	{
		KhDAXnEcyHS = yVFUbarMbQjHDjr.lIlmauYDEd;
		qYGRYBPBpazbkHp = VeDcgHVxmI;
	}

	public void hnaiBFRrRO(byte[] KdjlDiwVPaON)
	{
		using MemoryStream memoryStream = new MemoryStream();
		KdjlDiwVPaON = DYzeemrNuqGi.KLKwzFgHTWV(KdjlDiwVPaON);
		memoryStream.Write(KdjlDiwVPaON, 0, KdjlDiwVPaON.Length);
		memoryStream.Position = 0L;
		VAdBwCSxbDpNe(memoryStream);
	}

	public void ljCNfBGHSrKD(string XbTmiocMwokOQycJ)
	{
		FileStream fileStream = new FileStream(XbTmiocMwokOQycJ, FileMode.Open);
		VAdBwCSxbDpNe(fileStream);
		fileStream.Dispose();
	}

	public void VAdBwCSxbDpNe(Stream cHiZGOymgFIKo)
	{
		byte b = (byte)cHiZGOymgFIKo.ReadByte();
		byte[] array = null;
		int num = 0;
		int num2 = 0;
		if (b <= 127)
		{
			nxUHnDsRRJqvipS(b);
			return;
		}
		if (b >= 128 && b <= 143)
		{
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.tyiVWxeUQmfVC;
			num = b - 128;
			for (num2 = 0; num2 < num; num2++)
			{
				oBaGoFGSOWPojT obj = yHoLICTlRSwV();
				obj.VTuidVJqfPN(bTiTWyAenDMH.rEGQVSRugryb(cHiZGOymgFIKo));
				obj.VAdBwCSxbDpNe(cHiZGOymgFIKo);
			}
			return;
		}
		if (b >= 144 && b <= 159)
		{
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.KMnmLPOfRt;
			num = b - 144;
			for (num2 = 0; num2 < num; num2++)
			{
				yHoLICTlRSwV().VAdBwCSxbDpNe(cHiZGOymgFIKo);
			}
			return;
		}
		if (b >= 160 && b <= 191)
		{
			num = b - 160;
			ekETxtxcAFPeX(bTiTWyAenDMH.LoKvyIJCiPf(cHiZGOymgFIKo, num));
			return;
		}
		if (b >= 224 && b <= byte.MaxValue)
		{
			nxUHnDsRRJqvipS((sbyte)b);
			return;
		}
		switch (b)
		{
		case 192:
			LgYiuMJzwbK();
			return;
		case 193:
			throw new Exception("(never used) type $c1");
		case 194:
			qKyODyFYQVEt(DAnvRgbzPiJ: false);
			return;
		case 195:
			qKyODyFYQVEt(DAnvRgbzPiJ: true);
			return;
		case 196:
			num = cHiZGOymgFIKo.ReadByte();
			array = new byte[num];
			cHiZGOymgFIKo.Read(array, 0, num);
			cWTSAQwOZb(array);
			return;
		case 197:
			array = new byte[2];
			cHiZGOymgFIKo.Read(array, 0, 2);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToUInt16(array, 0);
			array = new byte[num];
			cHiZGOymgFIKo.Read(array, 0, num);
			cWTSAQwOZb(array);
			return;
		case 198:
			array = new byte[4];
			cHiZGOymgFIKo.Read(array, 0, 4);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToInt32(array, 0);
			array = new byte[num];
			cHiZGOymgFIKo.Read(array, 0, num);
			cWTSAQwOZb(array);
			return;
		case 202:
			array = new byte[4];
			cHiZGOymgFIKo.Read(array, 0, 4);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			fRiOYbmlTphn(BitConverter.ToSingle(array, 0));
			return;
		case 203:
			array = new byte[8];
			cHiZGOymgFIKo.Read(array, 0, 8);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			XkRUvuedFdG(BitConverter.ToDouble(array, 0));
			return;
		case 204:
			b = (byte)cHiZGOymgFIKo.ReadByte();
			nxUHnDsRRJqvipS(b);
			return;
		case 205:
			array = new byte[2];
			cHiZGOymgFIKo.Read(array, 0, 2);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			nxUHnDsRRJqvipS(BitConverter.ToUInt16(array, 0));
			return;
		case 206:
			array = new byte[4];
			cHiZGOymgFIKo.Read(array, 0, 4);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			nxUHnDsRRJqvipS(BitConverter.ToUInt32(array, 0));
			return;
		case 207:
			array = new byte[8];
			cHiZGOymgFIKo.Read(array, 0, 8);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			DjwZYVnoORF(BitConverter.ToUInt64(array, 0));
			return;
		case 220:
			array = new byte[2];
			cHiZGOymgFIKo.Read(array, 0, 2);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToInt16(array, 0);
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.KMnmLPOfRt;
			for (num2 = 0; num2 < num; num2++)
			{
				yHoLICTlRSwV().VAdBwCSxbDpNe(cHiZGOymgFIKo);
			}
			return;
		case 221:
			array = new byte[4];
			cHiZGOymgFIKo.Read(array, 0, 4);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToInt16(array, 0);
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.KMnmLPOfRt;
			for (num2 = 0; num2 < num; num2++)
			{
				yHoLICTlRSwV().VAdBwCSxbDpNe(cHiZGOymgFIKo);
			}
			return;
		case 217:
			ekETxtxcAFPeX(bTiTWyAenDMH.ucjpLLiFSigfJY(b, cHiZGOymgFIKo));
			return;
		case 222:
			array = new byte[2];
			cHiZGOymgFIKo.Read(array, 0, 2);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToInt16(array, 0);
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.tyiVWxeUQmfVC;
			for (num2 = 0; num2 < num; num2++)
			{
				oBaGoFGSOWPojT obj2 = yHoLICTlRSwV();
				obj2.VTuidVJqfPN(bTiTWyAenDMH.rEGQVSRugryb(cHiZGOymgFIKo));
				obj2.VAdBwCSxbDpNe(cHiZGOymgFIKo);
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
			cHiZGOymgFIKo.Read(array, 0, 2);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToInt16(array, 0);
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.tyiVWxeUQmfVC;
			for (num2 = 0; num2 < num; num2++)
			{
				oBaGoFGSOWPojT obj4 = yHoLICTlRSwV();
				obj4.VTuidVJqfPN(bTiTWyAenDMH.rEGQVSRugryb(cHiZGOymgFIKo));
				obj4.VAdBwCSxbDpNe(cHiZGOymgFIKo);
			}
			break;
		case 223:
			array = new byte[4];
			cHiZGOymgFIKo.Read(array, 0, 4);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			num = BitConverter.ToInt32(array, 0);
			rCaRzthqHspC();
			KhDAXnEcyHS = yVFUbarMbQjHDjr.tyiVWxeUQmfVC;
			for (num2 = 0; num2 < num; num2++)
			{
				oBaGoFGSOWPojT obj3 = yHoLICTlRSwV();
				obj3.VTuidVJqfPN(bTiTWyAenDMH.rEGQVSRugryb(cHiZGOymgFIKo));
				obj3.VAdBwCSxbDpNe(cHiZGOymgFIKo);
			}
			break;
		case 218:
			ekETxtxcAFPeX(bTiTWyAenDMH.ucjpLLiFSigfJY(b, cHiZGOymgFIKo));
			break;
		case 219:
			ekETxtxcAFPeX(bTiTWyAenDMH.ucjpLLiFSigfJY(b, cHiZGOymgFIKo));
			break;
		case 208:
			nxUHnDsRRJqvipS((sbyte)cHiZGOymgFIKo.ReadByte());
			break;
		case 209:
			array = new byte[2];
			cHiZGOymgFIKo.Read(array, 0, 2);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			nxUHnDsRRJqvipS(BitConverter.ToInt16(array, 0));
			break;
		case 210:
			array = new byte[4];
			cHiZGOymgFIKo.Read(array, 0, 4);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			nxUHnDsRRJqvipS(BitConverter.ToInt32(array, 0));
			break;
		case 211:
			array = new byte[8];
			cHiZGOymgFIKo.Read(array, 0, 8);
			array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
			nxUHnDsRRJqvipS(BitConverter.ToInt64(array, 0));
			break;
		}
	}

	public byte[] MrbeXnLKFMlfC()
	{
		using MemoryStream memoryStream = new MemoryStream();
		MDqNufHPyNCt(memoryStream);
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Position = 0L;
		memoryStream.Read(array, 0, (int)memoryStream.Length);
		return DYzeemrNuqGi.pUmeTuMGuRTB(array);
	}

	public void MDqNufHPyNCt(Stream obtuQJcSMZY)
	{
		switch (KhDAXnEcyHS)
		{
		default:
			MhMFgxHxtMFZ.ZgtAvztkcDpfk(obtuQJcSMZY);
			break;
		case yVFUbarMbQjHDjr.zDrVJgGzGjubAJ:
		case yVFUbarMbQjHDjr.nrvVJMVmjlyTlZ:
			MhMFgxHxtMFZ.ZgtAvztkcDpfk(obtuQJcSMZY);
			break;
		case yVFUbarMbQjHDjr.tyiVWxeUQmfVC:
			yKArIGqjInNAFl(obtuQJcSMZY);
			break;
		case yVFUbarMbQjHDjr.KMnmLPOfRt:
			JHzRRazOqytfJlm(obtuQJcSMZY);
			break;
		case yVFUbarMbQjHDjr.BLzFgRUmILsbcxY:
			MhMFgxHxtMFZ.OkuEvXyruJsk(obtuQJcSMZY, (string)qYGRYBPBpazbkHp);
			break;
		case yVFUbarMbQjHDjr.JVAapesJbdempw:
			MhMFgxHxtMFZ.yuojjlymkN(obtuQJcSMZY, (long)qYGRYBPBpazbkHp);
			break;
		case yVFUbarMbQjHDjr.MtiKdcJKpSGsvYku:
			MhMFgxHxtMFZ.MdOVnsZOsoIID(obtuQJcSMZY, (ulong)qYGRYBPBpazbkHp);
			break;
		case yVFUbarMbQjHDjr.RNPllMmEclWeSO:
			MhMFgxHxtMFZ.pWHGMOqdRJmvuVz(obtuQJcSMZY, (bool)qYGRYBPBpazbkHp);
			break;
		case yVFUbarMbQjHDjr.lIlmauYDEd:
			MhMFgxHxtMFZ.AFWbpakubLdkcs(obtuQJcSMZY, (double)qYGRYBPBpazbkHp);
			break;
		case yVFUbarMbQjHDjr.VGRiscGOWM:
			MhMFgxHxtMFZ.AFWbpakubLdkcs(obtuQJcSMZY, (float)qYGRYBPBpazbkHp);
			break;
		case yVFUbarMbQjHDjr.asVhpvsZmbcgic:
			MhMFgxHxtMFZ.yuojjlymkN(obtuQJcSMZY, XXEfKmYuCbjSze());
			break;
		case yVFUbarMbQjHDjr.wfooKbiSuTb:
			MhMFgxHxtMFZ.QPToAWBUdA(obtuQJcSMZY, (byte[])qYGRYBPBpazbkHp);
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new PeGGijSyohBfbV(jnAmlNPgeTIe);
	}
}
