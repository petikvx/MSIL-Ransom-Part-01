using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace YDfIqHIitkNiPV;

public class UsnwLsVggjVevszVi : IEnumerable
{
	private string rxFmoBTtuKei;

	private string nAjUxxSYezqq;

	private object suadjeSvKJql;

	private NpUvJyxjRP MFEUpLRUDyeui;

	private UsnwLsVggjVevszVi pgvqVhzjDJw;

	private List<UsnwLsVggjVevszVi> FERqDAusvgFrz = new List<UsnwLsVggjVevszVi>();

	private VwSOlVLZFEgYMJr fdebOEBgYNIOuJ;

	public string dQdRsEbxlbxwL
	{
		get
		{
			return pRKUJlPyMtqXw();
		}
		set
		{
			ywqmmgHQwlnV(value);
		}
	}

	public long IFemAMNhQvg
	{
		get
		{
			return BWywENcVjM();
		}
		set
		{
			kbhSzVQmmGYe(value);
		}
	}

	public double GxmPrZKMfGymj
	{
		get
		{
			return rSpHdnVjPFXnW();
		}
		set
		{
			UdXRZpBWerry(value);
		}
	}

	public VwSOlVLZFEgYMJr WcBnCMiwWihi
	{
		get
		{
			lock (this)
			{
				if (fdebOEBgYNIOuJ == null)
				{
					fdebOEBgYNIOuJ = new VwSOlVLZFEgYMJr(this, FERqDAusvgFrz);
				}
			}
			return fdebOEBgYNIOuJ;
		}
	}

	public NpUvJyxjRP QLDbnoFlnKBO => MFEUpLRUDyeui;

	private void VfqRftFImRulXxX(string odEUwlazixut)
	{
		rxFmoBTtuKei = odEUwlazixut;
		nAjUxxSYezqq = rxFmoBTtuKei.ToLower();
	}

	private void RZyscVuEWsQ()
	{
		for (int i = 0; i < FERqDAusvgFrz.Count; i++)
		{
			FERqDAusvgFrz[i].RZyscVuEWsQ();
		}
		FERqDAusvgFrz.Clear();
	}

	private UsnwLsVggjVevszVi QdmipSsVkAvC()
	{
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = new UsnwLsVggjVevszVi();
		usnwLsVggjVevszVi.pgvqVhzjDJw = this;
		FERqDAusvgFrz.Add(usnwLsVggjVevszVi);
		return usnwLsVggjVevszVi;
	}

	private int LTZuOaaljbyyUUlr(string aiTSRzrxWPIEM)
	{
		int num = -1;
		int result = -1;
		string text = aiTSRzrxWPIEM.ToLower();
		foreach (UsnwLsVggjVevszVi item in FERqDAusvgFrz)
		{
			num++;
			if (text.Equals(item.nAjUxxSYezqq))
			{
				return num;
			}
		}
		return result;
	}

	public UsnwLsVggjVevszVi DehIyAbGFLFnR(string RtRjhRHuuzDBS)
	{
		int num = LTZuOaaljbyyUUlr(RtRjhRHuuzDBS);
		if (num == -1)
		{
			return null;
		}
		return FERqDAusvgFrz[num];
	}

	private UsnwLsVggjVevszVi sKcihWWFeO()
	{
		if (MFEUpLRUDyeui != NpUvJyxjRP.iasansPIxfUzrZ)
		{
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.iasansPIxfUzrZ;
		}
		return QdmipSsVkAvC();
	}

	private UsnwLsVggjVevszVi UlaeDBxngojgStlT()
	{
		if (MFEUpLRUDyeui != NpUvJyxjRP.hNUVpgBCZUADh)
		{
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.hNUVpgBCZUADh;
		}
		return QdmipSsVkAvC();
	}

	public UsnwLsVggjVevszVi IEfFzAPwwqvHF()
	{
		return UlaeDBxngojgStlT();
	}

	private void rlSxQNNWfq(Stream rjTUHDLwSPxl)
	{
		int count = FERqDAusvgFrz.Count;
		if (count <= 15)
		{
			byte value = (byte)(128 + (byte)count);
			rjTUHDLwSPxl.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 222;
			rjTUHDLwSPxl.WriteByte(222);
			byte[] array = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes((short)count));
			rjTUHDLwSPxl.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 223;
			rjTUHDLwSPxl.WriteByte(223);
			byte[] array = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes(count));
			rjTUHDLwSPxl.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			qXLcvjGDKY.EXqLXcQKRfIp(rjTUHDLwSPxl, FERqDAusvgFrz[i].rxFmoBTtuKei);
			FERqDAusvgFrz[i].mLEvcfljZitslffJx(rjTUHDLwSPxl);
		}
	}

	private void eXWDIzSkVew(Stream mEkjkzbCFFPN)
	{
		int count = FERqDAusvgFrz.Count;
		if (count <= 15)
		{
			byte value = (byte)(144 + (byte)count);
			mEkjkzbCFFPN.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 220;
			mEkjkzbCFFPN.WriteByte(220);
			byte[] array = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes((short)count));
			mEkjkzbCFFPN.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 221;
			mEkjkzbCFFPN.WriteByte(221);
			byte[] array = UOsdaDuvXGt.ejlbQgoHCEAYu(BitConverter.GetBytes(count));
			mEkjkzbCFFPN.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			FERqDAusvgFrz[i].mLEvcfljZitslffJx(mEkjkzbCFFPN);
		}
	}

	public void kbhSzVQmmGYe(long hfwNDsPcTjgT)
	{
		suadjeSvKJql = hfwNDsPcTjgT;
		MFEUpLRUDyeui = NpUvJyxjRP.fBpFHiXuGcQsYRY;
	}

	public void aasmxTeRbxbMA(ulong DoOMpZRvwpSqm)
	{
		suadjeSvKJql = DoOMpZRvwpSqm;
		MFEUpLRUDyeui = NpUvJyxjRP.bNBSLAGLVkAGNknpG;
	}

	public ulong bOBUxNnWadE()
	{
		return MFEUpLRUDyeui switch
		{
			NpUvJyxjRP.MKaUinktwSTe => ulong.Parse(suadjeSvKJql.ToString()!.Trim()), 
			NpUvJyxjRP.fBpFHiXuGcQsYRY => Convert.ToUInt64((long)suadjeSvKJql), 
			NpUvJyxjRP.bNBSLAGLVkAGNknpG => (ulong)suadjeSvKJql, 
			NpUvJyxjRP.mWGgacSrwnup => Convert.ToUInt64((double)suadjeSvKJql), 
			NpUvJyxjRP.EKGosWKtRHRCJ => Convert.ToUInt64((float)suadjeSvKJql), 
			NpUvJyxjRP.ESLmFlSlRXhhn => Convert.ToUInt64((DateTime)suadjeSvKJql), 
			_ => 0uL, 
		};
	}

	public long BWywENcVjM()
	{
		return MFEUpLRUDyeui switch
		{
			NpUvJyxjRP.MKaUinktwSTe => long.Parse(suadjeSvKJql.ToString()!.Trim()), 
			NpUvJyxjRP.fBpFHiXuGcQsYRY => (long)suadjeSvKJql, 
			NpUvJyxjRP.bNBSLAGLVkAGNknpG => Convert.ToInt64((long)suadjeSvKJql), 
			NpUvJyxjRP.mWGgacSrwnup => Convert.ToInt64((double)suadjeSvKJql), 
			NpUvJyxjRP.EKGosWKtRHRCJ => Convert.ToInt64((float)suadjeSvKJql), 
			NpUvJyxjRP.ESLmFlSlRXhhn => Convert.ToInt64((DateTime)suadjeSvKJql), 
			_ => 0L, 
		};
	}

	public double rSpHdnVjPFXnW()
	{
		return MFEUpLRUDyeui switch
		{
			NpUvJyxjRP.MKaUinktwSTe => double.Parse((string)suadjeSvKJql), 
			NpUvJyxjRP.fBpFHiXuGcQsYRY => Convert.ToDouble((long)suadjeSvKJql), 
			NpUvJyxjRP.mWGgacSrwnup => (double)suadjeSvKJql, 
			NpUvJyxjRP.EKGosWKtRHRCJ => (float)suadjeSvKJql, 
			NpUvJyxjRP.ESLmFlSlRXhhn => Convert.ToInt64((DateTime)suadjeSvKJql), 
			_ => 0.0, 
		};
	}

	public void gCRcUeUyutKnv(byte[] pvVWRvmJUTiyqI)
	{
		suadjeSvKJql = pvVWRvmJUTiyqI;
		MFEUpLRUDyeui = NpUvJyxjRP.CAMzASLSBM;
	}

	public byte[] amgfTLPMTM()
	{
		return MFEUpLRUDyeui switch
		{
			NpUvJyxjRP.MKaUinktwSTe => UOsdaDuvXGt.qHQdBeXzvCjzzZP(suadjeSvKJql.ToString()), 
			NpUvJyxjRP.fBpFHiXuGcQsYRY => BitConverter.GetBytes((long)suadjeSvKJql), 
			NpUvJyxjRP.mWGgacSrwnup => BitConverter.GetBytes((double)suadjeSvKJql), 
			NpUvJyxjRP.EKGosWKtRHRCJ => BitConverter.GetBytes((float)suadjeSvKJql), 
			NpUvJyxjRP.ESLmFlSlRXhhn => BitConverter.GetBytes(((DateTime)suadjeSvKJql).ToBinary()), 
			NpUvJyxjRP.CAMzASLSBM => (byte[])suadjeSvKJql, 
			_ => new byte[0], 
		};
	}

	public void KKWWavZwTfm(string SbuvOShdLyUYpSzn, string nruvIWMjmKOhI)
	{
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = UlaeDBxngojgStlT();
		usnwLsVggjVevszVi.rxFmoBTtuKei = SbuvOShdLyUYpSzn;
		usnwLsVggjVevszVi.ywqmmgHQwlnV(nruvIWMjmKOhI);
	}

	public void VnWEWIjYOOaOhe(string JbslKZCoAD, int UMNFIdsEOoJrD)
	{
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = UlaeDBxngojgStlT();
		usnwLsVggjVevszVi.rxFmoBTtuKei = JbslKZCoAD;
		usnwLsVggjVevszVi.kbhSzVQmmGYe(UMNFIdsEOoJrD);
	}

	public bool QYhAgiNTyweU(string RrgoXQHjWFZ)
	{
		if (File.Exists(RrgoXQHjWFZ))
		{
			byte[] array = null;
			FileStream fileStream = new FileStream(RrgoXQHjWFZ, FileMode.Open, FileAccess.Read, FileShare.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			fileStream.Dispose();
			gCRcUeUyutKnv(array);
			return true;
		}
		return false;
	}

	public bool dNATbAgxdE(string rjSWZEoortz)
	{
		if (suadjeSvKJql != null)
		{
			FileStream fileStream = new FileStream(rjSWZEoortz, FileMode.Append);
			fileStream.Write((byte[])suadjeSvKJql, 0, ((byte[])suadjeSvKJql).Length);
			fileStream.Close();
			fileStream.Dispose();
			return true;
		}
		return false;
	}

	public UsnwLsVggjVevszVi twuQjjnvvWt(string udpbBSQdyBfOOmfm)
	{
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = this;
		string[] array = udpbBSQdyBfOOmfm.Trim().Split('.', '/', '\\');
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
				UsnwLsVggjVevszVi usnwLsVggjVevszVi2 = usnwLsVggjVevszVi.DehIyAbGFLFnR(text);
				if (usnwLsVggjVevszVi2 == null)
				{
					usnwLsVggjVevszVi = usnwLsVggjVevszVi.sKcihWWFeO();
					usnwLsVggjVevszVi.VfqRftFImRulXxX(text);
				}
				else
				{
					usnwLsVggjVevszVi = usnwLsVggjVevszVi2;
				}
			}
		}
		text = array[^1];
		int num = usnwLsVggjVevszVi.LTZuOaaljbyyUUlr(text);
		if (num > -1)
		{
			return usnwLsVggjVevszVi.FERqDAusvgFrz[num];
		}
		usnwLsVggjVevszVi = usnwLsVggjVevszVi.sKcihWWFeO();
		usnwLsVggjVevszVi.VfqRftFImRulXxX(text);
		return usnwLsVggjVevszVi;
	}

	public void JuRelpvgIsV()
	{
		RZyscVuEWsQ();
		suadjeSvKJql = null;
		MFEUpLRUDyeui = NpUvJyxjRP.XjWKvbbXdYsK;
	}

	public void ywqmmgHQwlnV(string aUgqYkHefcst)
	{
		suadjeSvKJql = aUgqYkHefcst;
		MFEUpLRUDyeui = NpUvJyxjRP.MKaUinktwSTe;
	}

	public string pRKUJlPyMtqXw()
	{
		if (suadjeSvKJql == null)
		{
			return "";
		}
		return suadjeSvKJql.ToString();
	}

	public void QmzEwncDaqnZ(bool MZjaHAyluKxn)
	{
		MFEUpLRUDyeui = NpUvJyxjRP.AyOJASOYMsKiw;
		suadjeSvKJql = MZjaHAyluKxn;
	}

	public void PwlsxRuaoT(float yIkeCbSIqVeTb)
	{
		MFEUpLRUDyeui = NpUvJyxjRP.EKGosWKtRHRCJ;
		suadjeSvKJql = yIkeCbSIqVeTb;
	}

	public void UdXRZpBWerry(double OUiMZQgxeGvjsP)
	{
		MFEUpLRUDyeui = NpUvJyxjRP.mWGgacSrwnup;
		suadjeSvKJql = OUiMZQgxeGvjsP;
	}

	public void hyZPpWPFHEd(byte[] jFdopDkYjswUXQ)
	{
		using MemoryStream memoryStream = new MemoryStream();
		jFdopDkYjswUXQ = xbfXshnVCPifH.emiUIBjFUmzH(jFdopDkYjswUXQ);
		memoryStream.Write(jFdopDkYjswUXQ, 0, jFdopDkYjswUXQ.Length);
		memoryStream.Position = 0L;
		zZxDoSyGgjEz(memoryStream);
	}

	public void ulgDEJuYWUzN(string GAHYLZfYhfLX)
	{
		FileStream fileStream = new FileStream(GAHYLZfYhfLX, FileMode.Open);
		zZxDoSyGgjEz(fileStream);
		fileStream.Dispose();
	}

	public void zZxDoSyGgjEz(Stream rAgppEQirWH)
	{
		byte b = (byte)rAgppEQirWH.ReadByte();
		byte[] array = null;
		int num = 0;
		int num2 = 0;
		if (b <= 127)
		{
			kbhSzVQmmGYe(b);
			return;
		}
		if (b >= 128 && b <= 143)
		{
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.iasansPIxfUzrZ;
			num = b - 128;
			for (num2 = 0; num2 < num; num2++)
			{
				UsnwLsVggjVevszVi usnwLsVggjVevszVi = QdmipSsVkAvC();
				usnwLsVggjVevszVi.VfqRftFImRulXxX(VyYBHhfMnUamB.daQXUttxCgjeD(rAgppEQirWH));
				usnwLsVggjVevszVi.zZxDoSyGgjEz(rAgppEQirWH);
			}
			return;
		}
		if (b >= 144 && b <= 159)
		{
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.hNUVpgBCZUADh;
			num = b - 144;
			for (num2 = 0; num2 < num; num2++)
			{
				QdmipSsVkAvC().zZxDoSyGgjEz(rAgppEQirWH);
			}
			return;
		}
		if (b >= 160 && b <= 191)
		{
			num = b - 160;
			ywqmmgHQwlnV(VyYBHhfMnUamB.yDsYXOHrNYTg(rAgppEQirWH, num));
			return;
		}
		if (b >= 224 && b <= byte.MaxValue)
		{
			kbhSzVQmmGYe((sbyte)b);
			return;
		}
		switch (b)
		{
		case 192:
			JuRelpvgIsV();
			return;
		case 193:
			throw new Exception("(never used) type $c1");
		case 194:
			QmzEwncDaqnZ(MZjaHAyluKxn: false);
			return;
		case 195:
			QmzEwncDaqnZ(MZjaHAyluKxn: true);
			return;
		case 196:
			num = rAgppEQirWH.ReadByte();
			array = new byte[num];
			rAgppEQirWH.Read(array, 0, num);
			gCRcUeUyutKnv(array);
			return;
		case 197:
			array = new byte[2];
			rAgppEQirWH.Read(array, 0, 2);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToUInt16(array, 0);
			array = new byte[num];
			rAgppEQirWH.Read(array, 0, num);
			gCRcUeUyutKnv(array);
			return;
		case 198:
			array = new byte[4];
			rAgppEQirWH.Read(array, 0, 4);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToInt32(array, 0);
			array = new byte[num];
			rAgppEQirWH.Read(array, 0, num);
			gCRcUeUyutKnv(array);
			return;
		case 202:
			array = new byte[4];
			rAgppEQirWH.Read(array, 0, 4);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			PwlsxRuaoT(BitConverter.ToSingle(array, 0));
			return;
		case 203:
			array = new byte[8];
			rAgppEQirWH.Read(array, 0, 8);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			UdXRZpBWerry(BitConverter.ToDouble(array, 0));
			return;
		case 204:
			b = (byte)rAgppEQirWH.ReadByte();
			kbhSzVQmmGYe(b);
			return;
		case 205:
			array = new byte[2];
			rAgppEQirWH.Read(array, 0, 2);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			kbhSzVQmmGYe(BitConverter.ToUInt16(array, 0));
			return;
		case 206:
			array = new byte[4];
			rAgppEQirWH.Read(array, 0, 4);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			kbhSzVQmmGYe(BitConverter.ToUInt32(array, 0));
			return;
		case 207:
			array = new byte[8];
			rAgppEQirWH.Read(array, 0, 8);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			aasmxTeRbxbMA(BitConverter.ToUInt64(array, 0));
			return;
		case 220:
			array = new byte[2];
			rAgppEQirWH.Read(array, 0, 2);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToInt16(array, 0);
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.hNUVpgBCZUADh;
			for (num2 = 0; num2 < num; num2++)
			{
				QdmipSsVkAvC().zZxDoSyGgjEz(rAgppEQirWH);
			}
			return;
		case 221:
			array = new byte[4];
			rAgppEQirWH.Read(array, 0, 4);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToInt16(array, 0);
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.hNUVpgBCZUADh;
			for (num2 = 0; num2 < num; num2++)
			{
				QdmipSsVkAvC().zZxDoSyGgjEz(rAgppEQirWH);
			}
			return;
		case 217:
			ywqmmgHQwlnV(VyYBHhfMnUamB.BdQmcwiaSZ(b, rAgppEQirWH));
			return;
		case 222:
			array = new byte[2];
			rAgppEQirWH.Read(array, 0, 2);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToInt16(array, 0);
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.iasansPIxfUzrZ;
			for (num2 = 0; num2 < num; num2++)
			{
				UsnwLsVggjVevszVi usnwLsVggjVevszVi2 = QdmipSsVkAvC();
				usnwLsVggjVevszVi2.VfqRftFImRulXxX(VyYBHhfMnUamB.daQXUttxCgjeD(rAgppEQirWH));
				usnwLsVggjVevszVi2.zZxDoSyGgjEz(rAgppEQirWH);
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
			rAgppEQirWH.Read(array, 0, 2);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToInt16(array, 0);
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.iasansPIxfUzrZ;
			for (num2 = 0; num2 < num; num2++)
			{
				UsnwLsVggjVevszVi usnwLsVggjVevszVi4 = QdmipSsVkAvC();
				usnwLsVggjVevszVi4.VfqRftFImRulXxX(VyYBHhfMnUamB.daQXUttxCgjeD(rAgppEQirWH));
				usnwLsVggjVevszVi4.zZxDoSyGgjEz(rAgppEQirWH);
			}
			break;
		case 223:
			array = new byte[4];
			rAgppEQirWH.Read(array, 0, 4);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			num = BitConverter.ToInt32(array, 0);
			RZyscVuEWsQ();
			MFEUpLRUDyeui = NpUvJyxjRP.iasansPIxfUzrZ;
			for (num2 = 0; num2 < num; num2++)
			{
				UsnwLsVggjVevszVi usnwLsVggjVevszVi3 = QdmipSsVkAvC();
				usnwLsVggjVevszVi3.VfqRftFImRulXxX(VyYBHhfMnUamB.daQXUttxCgjeD(rAgppEQirWH));
				usnwLsVggjVevszVi3.zZxDoSyGgjEz(rAgppEQirWH);
			}
			break;
		case 218:
			ywqmmgHQwlnV(VyYBHhfMnUamB.BdQmcwiaSZ(b, rAgppEQirWH));
			break;
		case 219:
			ywqmmgHQwlnV(VyYBHhfMnUamB.BdQmcwiaSZ(b, rAgppEQirWH));
			break;
		case 208:
			kbhSzVQmmGYe((sbyte)rAgppEQirWH.ReadByte());
			break;
		case 209:
			array = new byte[2];
			rAgppEQirWH.Read(array, 0, 2);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			kbhSzVQmmGYe(BitConverter.ToInt16(array, 0));
			break;
		case 210:
			array = new byte[4];
			rAgppEQirWH.Read(array, 0, 4);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			kbhSzVQmmGYe(BitConverter.ToInt32(array, 0));
			break;
		case 211:
			array = new byte[8];
			rAgppEQirWH.Read(array, 0, 8);
			array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
			kbhSzVQmmGYe(BitConverter.ToInt64(array, 0));
			break;
		}
	}

	public byte[] mTRfDZbSUzkmH()
	{
		using MemoryStream memoryStream = new MemoryStream();
		mLEvcfljZitslffJx(memoryStream);
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Position = 0L;
		memoryStream.Read(array, 0, (int)memoryStream.Length);
		return xbfXshnVCPifH.IENiPWJnbCwq(array);
	}

	public void mLEvcfljZitslffJx(Stream NDvKpCMvumiByFAb)
	{
		switch (MFEUpLRUDyeui)
		{
		default:
			qXLcvjGDKY.oxXPsChDsXZlg(NDvKpCMvumiByFAb);
			break;
		case NpUvJyxjRP.jkNLdEPxMYiA:
		case NpUvJyxjRP.XjWKvbbXdYsK:
			qXLcvjGDKY.oxXPsChDsXZlg(NDvKpCMvumiByFAb);
			break;
		case NpUvJyxjRP.iasansPIxfUzrZ:
			rlSxQNNWfq(NDvKpCMvumiByFAb);
			break;
		case NpUvJyxjRP.hNUVpgBCZUADh:
			eXWDIzSkVew(NDvKpCMvumiByFAb);
			break;
		case NpUvJyxjRP.MKaUinktwSTe:
			qXLcvjGDKY.EXqLXcQKRfIp(NDvKpCMvumiByFAb, (string)suadjeSvKJql);
			break;
		case NpUvJyxjRP.fBpFHiXuGcQsYRY:
			qXLcvjGDKY.sRRMBxluTLRNpG(NDvKpCMvumiByFAb, (long)suadjeSvKJql);
			break;
		case NpUvJyxjRP.bNBSLAGLVkAGNknpG:
			qXLcvjGDKY.XQnFdotlVthHH(NDvKpCMvumiByFAb, (ulong)suadjeSvKJql);
			break;
		case NpUvJyxjRP.AyOJASOYMsKiw:
			qXLcvjGDKY.mljrRzpAwAoiwid(NDvKpCMvumiByFAb, (bool)suadjeSvKJql);
			break;
		case NpUvJyxjRP.mWGgacSrwnup:
			qXLcvjGDKY.EzgdKlCAZNTrGKSS(NDvKpCMvumiByFAb, (double)suadjeSvKJql);
			break;
		case NpUvJyxjRP.EKGosWKtRHRCJ:
			qXLcvjGDKY.EzgdKlCAZNTrGKSS(NDvKpCMvumiByFAb, (float)suadjeSvKJql);
			break;
		case NpUvJyxjRP.ESLmFlSlRXhhn:
			qXLcvjGDKY.sRRMBxluTLRNpG(NDvKpCMvumiByFAb, BWywENcVjM());
			break;
		case NpUvJyxjRP.CAMzASLSBM:
			qXLcvjGDKY.viTNlocAQtZq(NDvKpCMvumiByFAb, (byte[])suadjeSvKJql);
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new ymmCBoPembInFg(FERqDAusvgFrz);
	}
}
