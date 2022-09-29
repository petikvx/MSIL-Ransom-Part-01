using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace MlfWmjHrDtM;

public class BkiLYFLOLaOffh : IEnumerable
{
	private string rrGQhtjqPpF;

	private string nAhBsyyFMsq;

	private object DihVgTIKTCDTdP;

	private LCqMGntLLbJI WxQhKNJRqudd;

	private BkiLYFLOLaOffh DEmyGIiurPEz;

	private List<BkiLYFLOLaOffh> ukkISmsyEsB = new List<BkiLYFLOLaOffh>();

	private ihNzOfvLuUX dEfofvXgEtkN;

	public string NeEjgBfTnxsVX
	{
		get
		{
			return chCjLqqweDVZo();
		}
		set
		{
			MDUVhUbWiMDgI(value);
		}
	}

	public long uESHMKQjRuIPaX
	{
		get
		{
			return iqSJWrbMhCbs();
		}
		set
		{
			lHQeDPoKfFeByp(value);
		}
	}

	public double oNUfXJqtaejBd
	{
		get
		{
			return vgkfjpSQbmj();
		}
		set
		{
			wCWRBMSpzfyUCz(value);
		}
	}

	public ihNzOfvLuUX iUMfWjuYWOHk
	{
		get
		{
			lock (this)
			{
				if (dEfofvXgEtkN == null)
				{
					dEfofvXgEtkN = new ihNzOfvLuUX(this, ukkISmsyEsB);
				}
			}
			return dEfofvXgEtkN;
		}
	}

	public LCqMGntLLbJI LqvBboeGGGqZPbmE => WxQhKNJRqudd;

	private void rxtrEDhOpUn(string RGWhOZFosUOfRr)
	{
		rrGQhtjqPpF = RGWhOZFosUOfRr;
		nAhBsyyFMsq = rrGQhtjqPpF.ToLower();
	}

	private void OkjhyCIQZi()
	{
		for (int i = 0; i < ukkISmsyEsB.Count; i++)
		{
			ukkISmsyEsB[i].OkjhyCIQZi();
		}
		ukkISmsyEsB.Clear();
	}

	private BkiLYFLOLaOffh cLZCcAxhQWn()
	{
		BkiLYFLOLaOffh bkiLYFLOLaOffh = new BkiLYFLOLaOffh();
		bkiLYFLOLaOffh.DEmyGIiurPEz = this;
		ukkISmsyEsB.Add(bkiLYFLOLaOffh);
		return bkiLYFLOLaOffh;
	}

	private int AwFPVCkjSXYw(string alYCAOSnsiDr)
	{
		int num = -1;
		int result = -1;
		string text = alYCAOSnsiDr.ToLower();
		foreach (BkiLYFLOLaOffh item in ukkISmsyEsB)
		{
			num++;
			if (text.Equals(item.nAhBsyyFMsq))
			{
				return num;
			}
		}
		return result;
	}

	public BkiLYFLOLaOffh JRbwjrdXNkTsB(string ZjHnALItUxvnhR)
	{
		int num = AwFPVCkjSXYw(ZjHnALItUxvnhR);
		if (num == -1)
		{
			return null;
		}
		return ukkISmsyEsB[num];
	}

	private BkiLYFLOLaOffh dmrNgoEIxMTwx()
	{
		if (WxQhKNJRqudd != LCqMGntLLbJI.ALdvYHnwCcXq)
		{
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.ALdvYHnwCcXq;
		}
		return cLZCcAxhQWn();
	}

	private BkiLYFLOLaOffh hBYBspncustIeX()
	{
		if (WxQhKNJRqudd != LCqMGntLLbJI.KSxTlGlAcsyb)
		{
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.KSxTlGlAcsyb;
		}
		return cLZCcAxhQWn();
	}

	public BkiLYFLOLaOffh tPEvaSSFyxfj()
	{
		return hBYBspncustIeX();
	}

	private void WCqoJcWvMPgvAw(Stream zUVahQXgSTsMOo)
	{
		int count = ukkISmsyEsB.Count;
		if (count <= 15)
		{
			byte value = (byte)(128 + (byte)count);
			zUVahQXgSTsMOo.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 222;
			zUVahQXgSTsMOo.WriteByte(222);
			byte[] array = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes((short)count));
			zUVahQXgSTsMOo.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 223;
			zUVahQXgSTsMOo.WriteByte(223);
			byte[] array = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes(count));
			zUVahQXgSTsMOo.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			RtqzGygiRYp.XiPnSumecxcVevou(zUVahQXgSTsMOo, ukkISmsyEsB[i].rrGQhtjqPpF);
			ukkISmsyEsB[i].qoZjNYWoMgliTO(zUVahQXgSTsMOo);
		}
	}

	private void kqOBMCvSBnWzWy(Stream KLniZvEMDRbnLlR)
	{
		int count = ukkISmsyEsB.Count;
		if (count <= 15)
		{
			byte value = (byte)(144 + (byte)count);
			KLniZvEMDRbnLlR.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 220;
			KLniZvEMDRbnLlR.WriteByte(220);
			byte[] array = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes((short)count));
			KLniZvEMDRbnLlR.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 221;
			KLniZvEMDRbnLlR.WriteByte(221);
			byte[] array = HtHLMJnLldFHH.eVeGzxKKqtkG(BitConverter.GetBytes(count));
			KLniZvEMDRbnLlR.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			ukkISmsyEsB[i].qoZjNYWoMgliTO(KLniZvEMDRbnLlR);
		}
	}

	public void lHQeDPoKfFeByp(long TVzTRIJOOI)
	{
		DihVgTIKTCDTdP = TVzTRIJOOI;
		WxQhKNJRqudd = LCqMGntLLbJI.vfMMFQULNvv;
	}

	public void yHHGeLqijBdC(ulong sgvEcuzgnRNPw)
	{
		DihVgTIKTCDTdP = sgvEcuzgnRNPw;
		WxQhKNJRqudd = LCqMGntLLbJI.QTXxwuoXvVGk;
	}

	public ulong PjcfuQTvOYsbo()
	{
		return WxQhKNJRqudd switch
		{
			LCqMGntLLbJI.rHphuWACKbmKfEY => ulong.Parse(DihVgTIKTCDTdP.ToString()!.Trim()), 
			LCqMGntLLbJI.vfMMFQULNvv => Convert.ToUInt64((long)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.QTXxwuoXvVGk => (ulong)DihVgTIKTCDTdP, 
			LCqMGntLLbJI.MQyiEVqHOS => Convert.ToUInt64((double)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.DbJBbWuYusw => Convert.ToUInt64((float)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.EBYcWLPNeA => Convert.ToUInt64((DateTime)DihVgTIKTCDTdP), 
			_ => 0uL, 
		};
	}

	public long iqSJWrbMhCbs()
	{
		return WxQhKNJRqudd switch
		{
			LCqMGntLLbJI.rHphuWACKbmKfEY => long.Parse(DihVgTIKTCDTdP.ToString()!.Trim()), 
			LCqMGntLLbJI.vfMMFQULNvv => (long)DihVgTIKTCDTdP, 
			LCqMGntLLbJI.QTXxwuoXvVGk => Convert.ToInt64((long)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.MQyiEVqHOS => Convert.ToInt64((double)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.DbJBbWuYusw => Convert.ToInt64((float)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.EBYcWLPNeA => Convert.ToInt64((DateTime)DihVgTIKTCDTdP), 
			_ => 0L, 
		};
	}

	public double vgkfjpSQbmj()
	{
		return WxQhKNJRqudd switch
		{
			LCqMGntLLbJI.rHphuWACKbmKfEY => double.Parse((string)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.vfMMFQULNvv => Convert.ToDouble((long)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.MQyiEVqHOS => (double)DihVgTIKTCDTdP, 
			LCqMGntLLbJI.DbJBbWuYusw => (float)DihVgTIKTCDTdP, 
			LCqMGntLLbJI.EBYcWLPNeA => Convert.ToInt64((DateTime)DihVgTIKTCDTdP), 
			_ => 0.0, 
		};
	}

	public void difXphALEIqepd(byte[] DoRmFDQimsAHqb)
	{
		DihVgTIKTCDTdP = DoRmFDQimsAHqb;
		WxQhKNJRqudd = LCqMGntLLbJI.cXpWmmiHKv;
	}

	public byte[] YyNRwQqHAHiY()
	{
		return WxQhKNJRqudd switch
		{
			LCqMGntLLbJI.rHphuWACKbmKfEY => HtHLMJnLldFHH.WYXyyrTeIGtktOJ(DihVgTIKTCDTdP.ToString()), 
			LCqMGntLLbJI.vfMMFQULNvv => BitConverter.GetBytes((long)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.MQyiEVqHOS => BitConverter.GetBytes((double)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.DbJBbWuYusw => BitConverter.GetBytes((float)DihVgTIKTCDTdP), 
			LCqMGntLLbJI.EBYcWLPNeA => BitConverter.GetBytes(((DateTime)DihVgTIKTCDTdP).ToBinary()), 
			LCqMGntLLbJI.cXpWmmiHKv => (byte[])DihVgTIKTCDTdP, 
			_ => new byte[0], 
		};
	}

	public void VUfTUiWRhOduG(string IcdmYIxlOfBkdh, string AAvvsEWIAGhku)
	{
		BkiLYFLOLaOffh bkiLYFLOLaOffh = hBYBspncustIeX();
		bkiLYFLOLaOffh.rrGQhtjqPpF = IcdmYIxlOfBkdh;
		bkiLYFLOLaOffh.MDUVhUbWiMDgI(AAvvsEWIAGhku);
	}

	public void fPGGhHMpFifpPgd(string KWUYAeDjVwKV, int xUeOFZFXVPkID)
	{
		BkiLYFLOLaOffh bkiLYFLOLaOffh = hBYBspncustIeX();
		bkiLYFLOLaOffh.rrGQhtjqPpF = KWUYAeDjVwKV;
		bkiLYFLOLaOffh.lHQeDPoKfFeByp(xUeOFZFXVPkID);
	}

	public bool skiYcQBkVjE(string CfsmWVfytjpFJ)
	{
		if (File.Exists(CfsmWVfytjpFJ))
		{
			byte[] array = null;
			FileStream fileStream = new FileStream(CfsmWVfytjpFJ, FileMode.Open, FileAccess.Read, FileShare.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			fileStream.Dispose();
			difXphALEIqepd(array);
			return true;
		}
		return false;
	}

	public bool AcjjhvhSNV(string KdssHumjWlNZG)
	{
		if (DihVgTIKTCDTdP != null)
		{
			FileStream fileStream = new FileStream(KdssHumjWlNZG, FileMode.Append);
			fileStream.Write((byte[])DihVgTIKTCDTdP, 0, ((byte[])DihVgTIKTCDTdP).Length);
			fileStream.Close();
			fileStream.Dispose();
			return true;
		}
		return false;
	}

	public BkiLYFLOLaOffh bHZXfobBkouZxiwT(string rrJhVBWKhlawl)
	{
		BkiLYFLOLaOffh bkiLYFLOLaOffh = this;
		string[] array = rrJhVBWKhlawl.Trim().Split('.', '/', '\\');
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
				BkiLYFLOLaOffh bkiLYFLOLaOffh2 = bkiLYFLOLaOffh.JRbwjrdXNkTsB(text);
				if (bkiLYFLOLaOffh2 == null)
				{
					bkiLYFLOLaOffh = bkiLYFLOLaOffh.dmrNgoEIxMTwx();
					bkiLYFLOLaOffh.rxtrEDhOpUn(text);
				}
				else
				{
					bkiLYFLOLaOffh = bkiLYFLOLaOffh2;
				}
			}
		}
		text = array[^1];
		int num = bkiLYFLOLaOffh.AwFPVCkjSXYw(text);
		if (num > -1)
		{
			return bkiLYFLOLaOffh.ukkISmsyEsB[num];
		}
		bkiLYFLOLaOffh = bkiLYFLOLaOffh.dmrNgoEIxMTwx();
		bkiLYFLOLaOffh.rxtrEDhOpUn(text);
		return bkiLYFLOLaOffh;
	}

	public void HJRXkWrsltORh()
	{
		OkjhyCIQZi();
		DihVgTIKTCDTdP = null;
		WxQhKNJRqudd = LCqMGntLLbJI.cMgwJbqpNs;
	}

	public void MDUVhUbWiMDgI(string IDifGzezrEs)
	{
		DihVgTIKTCDTdP = IDifGzezrEs;
		WxQhKNJRqudd = LCqMGntLLbJI.rHphuWACKbmKfEY;
	}

	public string chCjLqqweDVZo()
	{
		if (DihVgTIKTCDTdP == null)
		{
			return "";
		}
		return DihVgTIKTCDTdP.ToString();
	}

	public void atfAyzZQWLz(bool QnLtHNuAFdUKff)
	{
		WxQhKNJRqudd = LCqMGntLLbJI.xRoLOKAnNxtd;
		DihVgTIKTCDTdP = QnLtHNuAFdUKff;
	}

	public void jPOdyPnJkDh(float uITizmENaBnX)
	{
		WxQhKNJRqudd = LCqMGntLLbJI.DbJBbWuYusw;
		DihVgTIKTCDTdP = uITizmENaBnX;
	}

	public void wCWRBMSpzfyUCz(double TfGUvffFvJO)
	{
		WxQhKNJRqudd = LCqMGntLLbJI.MQyiEVqHOS;
		DihVgTIKTCDTdP = TfGUvffFvJO;
	}

	public void UBlyuHNEtFb(byte[] LZmRFhjHOZPsdWaiY)
	{
		using MemoryStream memoryStream = new MemoryStream();
		LZmRFhjHOZPsdWaiY = JHJqnZOmgeGMD.porHVDREaXWlJc(LZmRFhjHOZPsdWaiY);
		memoryStream.Write(LZmRFhjHOZPsdWaiY, 0, LZmRFhjHOZPsdWaiY.Length);
		memoryStream.Position = 0L;
		wSopMTTUzuetb(memoryStream);
	}

	public void tiCIZyygYZxt(string WzlwDHSRvuOvHfOY)
	{
		FileStream fileStream = new FileStream(WzlwDHSRvuOvHfOY, FileMode.Open);
		wSopMTTUzuetb(fileStream);
		fileStream.Dispose();
	}

	public void wSopMTTUzuetb(Stream dRyWRDJervIc)
	{
		byte b = (byte)dRyWRDJervIc.ReadByte();
		byte[] array = null;
		int num = 0;
		int num2 = 0;
		if (b <= 127)
		{
			lHQeDPoKfFeByp(b);
			return;
		}
		if (b >= 128 && b <= 143)
		{
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.ALdvYHnwCcXq;
			num = b - 128;
			for (num2 = 0; num2 < num; num2++)
			{
				BkiLYFLOLaOffh bkiLYFLOLaOffh = cLZCcAxhQWn();
				bkiLYFLOLaOffh.rxtrEDhOpUn(waOjfjhUmdSfN.PkpHmfkwViUif(dRyWRDJervIc));
				bkiLYFLOLaOffh.wSopMTTUzuetb(dRyWRDJervIc);
			}
			return;
		}
		if (b >= 144 && b <= 159)
		{
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.KSxTlGlAcsyb;
			num = b - 144;
			for (num2 = 0; num2 < num; num2++)
			{
				cLZCcAxhQWn().wSopMTTUzuetb(dRyWRDJervIc);
			}
			return;
		}
		if (b >= 160 && b <= 191)
		{
			num = b - 160;
			MDUVhUbWiMDgI(waOjfjhUmdSfN.joAfDBMieauNbx(dRyWRDJervIc, num));
			return;
		}
		if (b >= 224 && b <= byte.MaxValue)
		{
			lHQeDPoKfFeByp((sbyte)b);
			return;
		}
		switch (b)
		{
		case 192:
			HJRXkWrsltORh();
			return;
		case 193:
			throw new Exception("(never used) type $c1");
		case 194:
			atfAyzZQWLz(QnLtHNuAFdUKff: false);
			return;
		case 195:
			atfAyzZQWLz(QnLtHNuAFdUKff: true);
			return;
		case 196:
			num = dRyWRDJervIc.ReadByte();
			array = new byte[num];
			dRyWRDJervIc.Read(array, 0, num);
			difXphALEIqepd(array);
			return;
		case 197:
			array = new byte[2];
			dRyWRDJervIc.Read(array, 0, 2);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToUInt16(array, 0);
			array = new byte[num];
			dRyWRDJervIc.Read(array, 0, num);
			difXphALEIqepd(array);
			return;
		case 198:
			array = new byte[4];
			dRyWRDJervIc.Read(array, 0, 4);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToInt32(array, 0);
			array = new byte[num];
			dRyWRDJervIc.Read(array, 0, num);
			difXphALEIqepd(array);
			return;
		case 202:
			array = new byte[4];
			dRyWRDJervIc.Read(array, 0, 4);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			jPOdyPnJkDh(BitConverter.ToSingle(array, 0));
			return;
		case 203:
			array = new byte[8];
			dRyWRDJervIc.Read(array, 0, 8);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			wCWRBMSpzfyUCz(BitConverter.ToDouble(array, 0));
			return;
		case 204:
			b = (byte)dRyWRDJervIc.ReadByte();
			lHQeDPoKfFeByp(b);
			return;
		case 205:
			array = new byte[2];
			dRyWRDJervIc.Read(array, 0, 2);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			lHQeDPoKfFeByp(BitConverter.ToUInt16(array, 0));
			return;
		case 206:
			array = new byte[4];
			dRyWRDJervIc.Read(array, 0, 4);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			lHQeDPoKfFeByp(BitConverter.ToUInt32(array, 0));
			return;
		case 207:
			array = new byte[8];
			dRyWRDJervIc.Read(array, 0, 8);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			yHHGeLqijBdC(BitConverter.ToUInt64(array, 0));
			return;
		case 220:
			array = new byte[2];
			dRyWRDJervIc.Read(array, 0, 2);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToInt16(array, 0);
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.KSxTlGlAcsyb;
			for (num2 = 0; num2 < num; num2++)
			{
				cLZCcAxhQWn().wSopMTTUzuetb(dRyWRDJervIc);
			}
			return;
		case 221:
			array = new byte[4];
			dRyWRDJervIc.Read(array, 0, 4);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToInt16(array, 0);
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.KSxTlGlAcsyb;
			for (num2 = 0; num2 < num; num2++)
			{
				cLZCcAxhQWn().wSopMTTUzuetb(dRyWRDJervIc);
			}
			return;
		case 217:
			MDUVhUbWiMDgI(waOjfjhUmdSfN.IEQkeHssluYG(b, dRyWRDJervIc));
			return;
		case 222:
			array = new byte[2];
			dRyWRDJervIc.Read(array, 0, 2);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToInt16(array, 0);
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.ALdvYHnwCcXq;
			for (num2 = 0; num2 < num; num2++)
			{
				BkiLYFLOLaOffh bkiLYFLOLaOffh2 = cLZCcAxhQWn();
				bkiLYFLOLaOffh2.rxtrEDhOpUn(waOjfjhUmdSfN.PkpHmfkwViUif(dRyWRDJervIc));
				bkiLYFLOLaOffh2.wSopMTTUzuetb(dRyWRDJervIc);
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
			dRyWRDJervIc.Read(array, 0, 2);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToInt16(array, 0);
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.ALdvYHnwCcXq;
			for (num2 = 0; num2 < num; num2++)
			{
				BkiLYFLOLaOffh bkiLYFLOLaOffh4 = cLZCcAxhQWn();
				bkiLYFLOLaOffh4.rxtrEDhOpUn(waOjfjhUmdSfN.PkpHmfkwViUif(dRyWRDJervIc));
				bkiLYFLOLaOffh4.wSopMTTUzuetb(dRyWRDJervIc);
			}
			break;
		case 223:
			array = new byte[4];
			dRyWRDJervIc.Read(array, 0, 4);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			num = BitConverter.ToInt32(array, 0);
			OkjhyCIQZi();
			WxQhKNJRqudd = LCqMGntLLbJI.ALdvYHnwCcXq;
			for (num2 = 0; num2 < num; num2++)
			{
				BkiLYFLOLaOffh bkiLYFLOLaOffh3 = cLZCcAxhQWn();
				bkiLYFLOLaOffh3.rxtrEDhOpUn(waOjfjhUmdSfN.PkpHmfkwViUif(dRyWRDJervIc));
				bkiLYFLOLaOffh3.wSopMTTUzuetb(dRyWRDJervIc);
			}
			break;
		case 218:
			MDUVhUbWiMDgI(waOjfjhUmdSfN.IEQkeHssluYG(b, dRyWRDJervIc));
			break;
		case 219:
			MDUVhUbWiMDgI(waOjfjhUmdSfN.IEQkeHssluYG(b, dRyWRDJervIc));
			break;
		case 208:
			lHQeDPoKfFeByp((sbyte)dRyWRDJervIc.ReadByte());
			break;
		case 209:
			array = new byte[2];
			dRyWRDJervIc.Read(array, 0, 2);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			lHQeDPoKfFeByp(BitConverter.ToInt16(array, 0));
			break;
		case 210:
			array = new byte[4];
			dRyWRDJervIc.Read(array, 0, 4);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			lHQeDPoKfFeByp(BitConverter.ToInt32(array, 0));
			break;
		case 211:
			array = new byte[8];
			dRyWRDJervIc.Read(array, 0, 8);
			array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
			lHQeDPoKfFeByp(BitConverter.ToInt64(array, 0));
			break;
		}
	}

	public byte[] nBhKSGjtanPwf()
	{
		using MemoryStream memoryStream = new MemoryStream();
		qoZjNYWoMgliTO(memoryStream);
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Position = 0L;
		memoryStream.Read(array, 0, (int)memoryStream.Length);
		return JHJqnZOmgeGMD.EjySUgKXdylXp(array);
	}

	public void qoZjNYWoMgliTO(Stream xKDfkuZmHAs)
	{
		switch (WxQhKNJRqudd)
		{
		default:
			RtqzGygiRYp.xzFNXuePUvStwG(xKDfkuZmHAs);
			break;
		case LCqMGntLLbJI.oEUoZTALXlH:
		case LCqMGntLLbJI.cMgwJbqpNs:
			RtqzGygiRYp.xzFNXuePUvStwG(xKDfkuZmHAs);
			break;
		case LCqMGntLLbJI.ALdvYHnwCcXq:
			WCqoJcWvMPgvAw(xKDfkuZmHAs);
			break;
		case LCqMGntLLbJI.KSxTlGlAcsyb:
			kqOBMCvSBnWzWy(xKDfkuZmHAs);
			break;
		case LCqMGntLLbJI.rHphuWACKbmKfEY:
			RtqzGygiRYp.XiPnSumecxcVevou(xKDfkuZmHAs, (string)DihVgTIKTCDTdP);
			break;
		case LCqMGntLLbJI.vfMMFQULNvv:
			RtqzGygiRYp.bmIcjoqZjnrg(xKDfkuZmHAs, (long)DihVgTIKTCDTdP);
			break;
		case LCqMGntLLbJI.QTXxwuoXvVGk:
			RtqzGygiRYp.uwTFYCNeKBUvJd(xKDfkuZmHAs, (ulong)DihVgTIKTCDTdP);
			break;
		case LCqMGntLLbJI.xRoLOKAnNxtd:
			RtqzGygiRYp.JeAbrKdGAXcuB(xKDfkuZmHAs, (bool)DihVgTIKTCDTdP);
			break;
		case LCqMGntLLbJI.MQyiEVqHOS:
			RtqzGygiRYp.cQuPdKvIRcx(xKDfkuZmHAs, (double)DihVgTIKTCDTdP);
			break;
		case LCqMGntLLbJI.DbJBbWuYusw:
			RtqzGygiRYp.cQuPdKvIRcx(xKDfkuZmHAs, (float)DihVgTIKTCDTdP);
			break;
		case LCqMGntLLbJI.EBYcWLPNeA:
			RtqzGygiRYp.bmIcjoqZjnrg(xKDfkuZmHAs, iqSJWrbMhCbs());
			break;
		case LCqMGntLLbJI.cXpWmmiHKv:
			RtqzGygiRYp.CnVkTXRwhKEZv(xKDfkuZmHAs, (byte[])DihVgTIKTCDTdP);
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new zwYyzCRfIl(ukkISmsyEsB);
	}
}
