using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace rgA69G;

public class GClass0 : IEnumerable
{
	private string a;

	private string b;

	private object c;

	private zpbMBqUrfL d;

	private GClass0 e;

	private List<GClass0> f = new List<GClass0>();

	private pIuHBryh4 g;

	public string AsString
	{
		get
		{
			return O5ez2jjerXxwUwjr();
		}
		set
		{
			GoBPQoYX(value);
		}
	}

	public long AsInteger
	{
		get
		{
			return kh9P23E0Vof();
		}
		set
		{
			HXSu51W(value);
		}
	}

	public double AsFloat
	{
		get
		{
			return UbCU1QaQx();
		}
		set
		{
			method_1(value);
		}
	}

	public pIuHBryh4 AsArray
	{
		get
		{
			lock (this)
			{
				if (g == null)
				{
					g = new pIuHBryh4(this, f);
				}
			}
			return g;
		}
	}

	public zpbMBqUrfL ValueType => d;

	private void PsYjkc_a(string a)
	{
		this.a = a;
		b = this.a.ToLower();
	}

	private void PsYjkc_b()
	{
		for (int i = 0; i < f.Count; i++)
		{
			f[i].PsYjkc_b();
		}
		f.Clear();
	}

	private GClass0 PsYjkc_c()
	{
		DateTime dateTime = new DateTime(2021, 7, 20, 19, 7, 52);
		if ((dateTime - DateTime.Now).TotalDays < 0.0)
		{
			throw new ArgumentException();
		}
		GClass0 gClass = new GClass0();
		gClass.e = this;
		f.Add(gClass);
		return gClass;
	}

	private int PsYjkc_d(string a)
	{
		DateTime dateTime = new DateTime(2021, 7, 20);
		if (DateTime.Now > dateTime || true)
		{
		}
		int num = -1;
		int result = -1;
		string text = a.ToLower();
		foreach (GClass0 item in f)
		{
			num++;
			if (text.Equals(item.b))
			{
				return num;
			}
		}
		return result;
	}

	public GClass0 HsjXZBu2(string N90JlKEdWAUd)
	{
		int num = PsYjkc_d(N90JlKEdWAUd);
		if (num == -1)
		{
			return null;
		}
		return f[num];
	}

	private GClass0 PsYjkc_e()
	{
		if (d != zpbMBqUrfL.const_2)
		{
			PsYjkc_b();
			d = zpbMBqUrfL.const_2;
		}
		return PsYjkc_c();
	}

	private GClass0 PsYjkc_f()
	{
		if (d != zpbMBqUrfL.const_3)
		{
			PsYjkc_b();
			d = zpbMBqUrfL.const_3;
		}
		return PsYjkc_c();
	}

	public GClass0 ATpHwIeuv()
	{
		return PsYjkc_f();
	}

	private void PsYjkc_g(Stream a)
	{
		int count = f.Count;
		if (count <= 15)
		{
			byte value = (byte)(128 + (byte)count);
			a.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 222;
			a.WriteByte(222);
			byte[] array = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes((short)count));
			a.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 223;
			a.WriteByte(223);
			byte[] array = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes(count));
			a.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_b(a, f[i].a);
			f[i].UbAQs1(a);
		}
	}

	private void PsYjkc_h(Stream a)
	{
		int count = f.Count;
		if (count <= 15)
		{
			byte value = (byte)(144 + (byte)count);
			a.WriteByte(value);
		}
		else if (count <= 65535)
		{
			byte value = 220;
			a.WriteByte(220);
			byte[] array = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes((short)count));
			a.Write(array, 0, array.Length);
		}
		else
		{
			byte value = 221;
			a.WriteByte(221);
			byte[] array = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes(count));
			a.Write(array, 0, array.Length);
		}
		for (int i = 0; i < count; i++)
		{
			f[i].UbAQs1(a);
		}
	}

	public void HXSu51W(long av8WMXaUH1)
	{
		c = av8WMXaUH1;
		d = zpbMBqUrfL.NDsoF6qX9K;
	}

	public void CeOIb9YEv(ulong uK4TlufHeNl)
	{
		c = uK4TlufHeNl;
		d = zpbMBqUrfL.njiWHMduoJPTxYS;
	}

	public ulong uXBPVPZb3KpVo()
	{
		return d switch
		{
			zpbMBqUrfL.g8GBrxXfP7XdhRTP => ulong.Parse(c.ToString()!.Trim()), 
			zpbMBqUrfL.NDsoF6qX9K => Convert.ToUInt64((long)c), 
			zpbMBqUrfL.njiWHMduoJPTxYS => (ulong)c, 
			zpbMBqUrfL.DmUr5eTj8XAT => Convert.ToUInt64((double)c), 
			zpbMBqUrfL.R6QmgObbzKm => Convert.ToUInt64((float)c), 
			zpbMBqUrfL.const_10 => Convert.ToUInt64((DateTime)c), 
			_ => 0uL, 
		};
	}

	public long kh9P23E0Vof()
	{
		return d switch
		{
			zpbMBqUrfL.g8GBrxXfP7XdhRTP => long.Parse(c.ToString()!.Trim()), 
			zpbMBqUrfL.NDsoF6qX9K => (long)c, 
			zpbMBqUrfL.njiWHMduoJPTxYS => Convert.ToInt64((long)c), 
			zpbMBqUrfL.DmUr5eTj8XAT => Convert.ToInt64((double)c), 
			zpbMBqUrfL.R6QmgObbzKm => Convert.ToInt64((float)c), 
			zpbMBqUrfL.const_10 => Convert.ToInt64((DateTime)c), 
			_ => 0L, 
		};
	}

	public double UbCU1QaQx()
	{
		return d switch
		{
			zpbMBqUrfL.g8GBrxXfP7XdhRTP => double.Parse((string)c), 
			zpbMBqUrfL.NDsoF6qX9K => Convert.ToDouble((long)c), 
			zpbMBqUrfL.DmUr5eTj8XAT => (double)c, 
			zpbMBqUrfL.R6QmgObbzKm => (float)c, 
			zpbMBqUrfL.const_10 => Convert.ToInt64((DateTime)c), 
			_ => 0.0, 
		};
	}

	public void jAGzAAXuiyXo(byte[] xZE0DpOgtnMHkq6)
	{
		c = xZE0DpOgtnMHkq6;
		d = zpbMBqUrfL.JJIcUBanjs27Zg;
	}

	public byte[] YEesP8E()
	{
		return d switch
		{
			zpbMBqUrfL.g8GBrxXfP7XdhRTP => V7qSaHaL8shx.i0SpamIY(c.ToString()), 
			zpbMBqUrfL.NDsoF6qX9K => BitConverter.GetBytes((long)c), 
			zpbMBqUrfL.DmUr5eTj8XAT => BitConverter.GetBytes((double)c), 
			zpbMBqUrfL.R6QmgObbzKm => BitConverter.GetBytes((float)c), 
			zpbMBqUrfL.const_10 => BitConverter.GetBytes(((DateTime)c).ToBinary()), 
			zpbMBqUrfL.JJIcUBanjs27Zg => (byte[])c, 
			_ => new byte[0], 
		};
	}

	public void USnAUj9SncV(string CAXNCrc6wxYpiR, string mhMK0dWI9Lg3ZH)
	{
		GClass0 gClass = PsYjkc_f();
		gClass.a = CAXNCrc6wxYpiR;
		gClass.GoBPQoYX(mhMK0dWI9Lg3ZH);
	}

	public void method_0(string hiFz3wI, int int_0)
	{
		GClass0 gClass = PsYjkc_f();
		gClass.a = hiFz3wI;
		gClass.HXSu51W(int_0);
	}

	public bool djYSShuLv(string Ye0Bk90Jy8tYg9O)
	{
		if (File.Exists(Ye0Bk90Jy8tYg9O))
		{
			byte[] array = null;
			FileStream fileStream = new FileStream(Ye0Bk90Jy8tYg9O, FileMode.Open, FileAccess.Read, FileShare.Read);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Close();
			fileStream.Dispose();
			jAGzAAXuiyXo(array);
			return true;
		}
		return false;
	}

	public bool XuUOfExX03Km(string BLuiO7kP0AuP)
	{
		if (c != null)
		{
			FileStream fileStream = new FileStream(BLuiO7kP0AuP, FileMode.Append);
			fileStream.Write((byte[])c, 0, ((byte[])c).Length);
			fileStream.Close();
			fileStream.Dispose();
			return true;
		}
		return false;
	}

	public GClass0 IVAx7Cpxaqkvx(string lLq6sUCigh)
	{
		GClass0 gClass = this;
		string[] array = lLq6sUCigh.Trim().Split('.', '/', '\\');
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
				GClass0 gClass2 = gClass.HsjXZBu2(text);
				if (gClass2 == null)
				{
					gClass = gClass.PsYjkc_e();
					gClass.PsYjkc_a(text);
				}
				else
				{
					gClass = gClass2;
				}
			}
		}
		text = array[^1];
		int num = gClass.PsYjkc_d(text);
		if (num > -1)
		{
			return gClass.f[num];
		}
		gClass = gClass.PsYjkc_e();
		gClass.PsYjkc_a(text);
		return gClass;
	}

	public void MUjgEIN82AI()
	{
		PsYjkc_b();
		c = null;
		d = zpbMBqUrfL.const_1;
	}

	public void GoBPQoYX(string ZnLykogi)
	{
		c = ZnLykogi;
		d = zpbMBqUrfL.g8GBrxXfP7XdhRTP;
	}

	public string O5ez2jjerXxwUwjr()
	{
		if (c == null)
		{
			return "";
		}
		return c.ToString();
	}

	public void gp2gM9K(bool KzKE6Hbs1f)
	{
		d = zpbMBqUrfL.Ev36LdTfbCx;
		c = KzKE6Hbs1f;
	}

	public void yy0kwJy7jmUG2(float dIpritArenyN)
	{
		d = zpbMBqUrfL.R6QmgObbzKm;
		c = dIpritArenyN;
	}

	public void method_1(double Y0mmlOu6NVP7)
	{
		d = zpbMBqUrfL.DmUr5eTj8XAT;
		c = Y0mmlOu6NVP7;
	}

	public void method_2(byte[] z6CkDU3)
	{
		using MemoryStream memoryStream = new MemoryStream();
		z6CkDU3 = SxI4mOMWyWSAY.iKQRVJjO0lmN8Z(z6CkDU3);
		memoryStream.Write(z6CkDU3, 0, z6CkDU3.Length);
		memoryStream.Position = 0L;
		O0lVjrukAg2rN2(memoryStream);
	}

	public void nPrtsM8s(string E3W4Ec4bDXJ1)
	{
		FileStream fileStream = new FileStream(E3W4Ec4bDXJ1, FileMode.Open);
		O0lVjrukAg2rN2(fileStream);
		fileStream.Dispose();
	}

	public void O0lVjrukAg2rN2(Stream mVGHWUiPNlA)
	{
		byte b = (byte)mVGHWUiPNlA.ReadByte();
		byte[] array = null;
		int num = 0;
		int num2 = 0;
		if (b <= 127)
		{
			HXSu51W(b);
			return;
		}
		if (b >= 128 && b <= 143)
		{
			PsYjkc_b();
			d = zpbMBqUrfL.const_2;
			num = b - 128;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass0 gClass = PsYjkc_c();
				gClass.PsYjkc_a(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_b(mVGHWUiPNlA));
				gClass.O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			return;
		}
		if (b >= 144 && b <= 159)
		{
			PsYjkc_b();
			d = zpbMBqUrfL.const_3;
			num = b - 144;
			for (num2 = 0; num2 < num; num2++)
			{
				PsYjkc_c().O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			return;
		}
		if (b >= 160 && b <= 191)
		{
			num = b - 160;
			GoBPQoYX(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_a(mVGHWUiPNlA, num));
			return;
		}
		if (b >= 224 && b <= byte.MaxValue)
		{
			HXSu51W((sbyte)b);
			return;
		}
		switch (b)
		{
		case 192:
			MUjgEIN82AI();
			return;
		case 193:
			throw new Exception(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0e3e\u0e78\u0e73\u0e60\u0e73\u0e64\u0e36\u0e63\u0e65\u0e73\u0e72฿\u0e36\u0e62\u0e6f\u0e66\u0e73\u0e36า\u0e75ว", 60915), 58344));
		case 194:
			gp2gM9K(KzKE6Hbs1f: false);
			return;
		case 195:
			gp2gM9K(KzKE6Hbs1f: true);
			return;
		case 196:
			num = mVGHWUiPNlA.ReadByte();
			array = new byte[num];
			mVGHWUiPNlA.Read(array, 0, num);
			jAGzAAXuiyXo(array);
			return;
		case 197:
			array = new byte[2];
			mVGHWUiPNlA.Read(array, 0, 2);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToUInt16(array, 0);
			array = new byte[num];
			mVGHWUiPNlA.Read(array, 0, num);
			jAGzAAXuiyXo(array);
			return;
		case 198:
			array = new byte[4];
			mVGHWUiPNlA.Read(array, 0, 4);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToInt32(array, 0);
			array = new byte[num];
			mVGHWUiPNlA.Read(array, 0, num);
			jAGzAAXuiyXo(array);
			return;
		case 202:
			array = new byte[4];
			mVGHWUiPNlA.Read(array, 0, 4);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			yy0kwJy7jmUG2(BitConverter.ToSingle(array, 0));
			return;
		case 203:
			array = new byte[8];
			mVGHWUiPNlA.Read(array, 0, 8);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			method_1(BitConverter.ToDouble(array, 0));
			return;
		case 204:
			b = (byte)mVGHWUiPNlA.ReadByte();
			HXSu51W(b);
			return;
		case 205:
			array = new byte[2];
			mVGHWUiPNlA.Read(array, 0, 2);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			HXSu51W(BitConverter.ToUInt16(array, 0));
			return;
		case 206:
			array = new byte[4];
			mVGHWUiPNlA.Read(array, 0, 4);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			HXSu51W(BitConverter.ToUInt32(array, 0));
			return;
		case 207:
			array = new byte[8];
			mVGHWUiPNlA.Read(array, 0, 8);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			CeOIb9YEv(BitConverter.ToUInt64(array, 0));
			return;
		case 220:
			array = new byte[2];
			mVGHWUiPNlA.Read(array, 0, 2);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToInt16(array, 0);
			PsYjkc_b();
			d = zpbMBqUrfL.const_3;
			for (num2 = 0; num2 < num; num2++)
			{
				PsYjkc_c().O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			return;
		case 221:
			array = new byte[4];
			mVGHWUiPNlA.Read(array, 0, 4);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToInt16(array, 0);
			PsYjkc_b();
			d = zpbMBqUrfL.const_3;
			for (num2 = 0; num2 < num; num2++)
			{
				PsYjkc_c().O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			return;
		case 217:
			GoBPQoYX(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_c(b, mVGHWUiPNlA));
			return;
		case 222:
			array = new byte[2];
			mVGHWUiPNlA.Read(array, 0, 2);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToInt16(array, 0);
			PsYjkc_b();
			d = zpbMBqUrfL.const_2;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass0 gClass2 = PsYjkc_c();
				gClass2.PsYjkc_a(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_b(mVGHWUiPNlA));
				gClass2.O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			return;
		case 199:
		case 200:
		case 201:
			throw new Exception(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("Ⴡ\u108c႑\u109dბჅ\u108c႑\u109dიჟჅ\u108c႑ლმჀ\u10c9\u109d႐႙\u108c\u10c9Ⴭ\u108aპჅჍ\u108aბჅჍ\u108aა", 63380), 59190));
		}
		switch (b)
		{
		case 222:
			array = new byte[2];
			mVGHWUiPNlA.Read(array, 0, 2);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToInt16(array, 0);
			PsYjkc_b();
			d = zpbMBqUrfL.const_2;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass0 gClass4 = PsYjkc_c();
				gClass4.PsYjkc_a(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_b(mVGHWUiPNlA));
				gClass4.O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			break;
		case 223:
			array = new byte[4];
			mVGHWUiPNlA.Read(array, 0, 4);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			num = BitConverter.ToInt32(array, 0);
			PsYjkc_b();
			d = zpbMBqUrfL.const_2;
			for (num2 = 0; num2 < num; num2++)
			{
				GClass0 gClass3 = PsYjkc_c();
				gClass3.PsYjkc_a(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_b(mVGHWUiPNlA));
				gClass3.O0lVjrukAg2rN2(mVGHWUiPNlA);
			}
			break;
		case 218:
			GoBPQoYX(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_c(b, mVGHWUiPNlA));
			break;
		case 219:
			GoBPQoYX(hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw.PsYjkc_c(b, mVGHWUiPNlA));
			break;
		case 208:
			HXSu51W((sbyte)mVGHWUiPNlA.ReadByte());
			break;
		case 209:
			array = new byte[2];
			mVGHWUiPNlA.Read(array, 0, 2);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			HXSu51W(BitConverter.ToInt16(array, 0));
			break;
		case 210:
			array = new byte[4];
			mVGHWUiPNlA.Read(array, 0, 4);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			HXSu51W(BitConverter.ToInt32(array, 0));
			break;
		case 211:
			array = new byte[8];
			mVGHWUiPNlA.Read(array, 0, 8);
			array = V7qSaHaL8shx.aduO6vFYO(array);
			HXSu51W(BitConverter.ToInt64(array, 0));
			break;
		}
	}

	public byte[] UlA6tHUTIQK()
	{
		using MemoryStream memoryStream = new MemoryStream();
		UbAQs1(memoryStream);
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Position = 0L;
		memoryStream.Read(array, 0, (int)memoryStream.Length);
		return SxI4mOMWyWSAY.owEJxuSoVd4hJ(array);
	}

	public void UbAQs1(Stream eHaka53dum)
	{
		switch (d)
		{
		default:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_a(eHaka53dum);
			break;
		case zpbMBqUrfL.gultd2i0IfSO:
		case zpbMBqUrfL.const_1:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_a(eHaka53dum);
			break;
		case zpbMBqUrfL.const_2:
			PsYjkc_g(eHaka53dum);
			break;
		case zpbMBqUrfL.const_3:
			PsYjkc_h(eHaka53dum);
			break;
		case zpbMBqUrfL.g8GBrxXfP7XdhRTP:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_b(eHaka53dum, (string)c);
			break;
		case zpbMBqUrfL.NDsoF6qX9K:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_h(eHaka53dum, (long)c);
			break;
		case zpbMBqUrfL.njiWHMduoJPTxYS:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_g(eHaka53dum, (ulong)c);
			break;
		case zpbMBqUrfL.Ev36LdTfbCx:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_f(eHaka53dum, (bool)c);
			break;
		case zpbMBqUrfL.DmUr5eTj8XAT:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_d(eHaka53dum, (double)c);
			break;
		case zpbMBqUrfL.R6QmgObbzKm:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_d(eHaka53dum, (float)c);
			break;
		case zpbMBqUrfL.const_10:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_h(eHaka53dum, kh9P23E0Vof());
			break;
		case zpbMBqUrfL.JJIcUBanjs27Zg:
			yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx.PsYjkc_c(eHaka53dum, (byte[])c);
			break;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Qvo7GYCkNi1w(f);
	}
}
