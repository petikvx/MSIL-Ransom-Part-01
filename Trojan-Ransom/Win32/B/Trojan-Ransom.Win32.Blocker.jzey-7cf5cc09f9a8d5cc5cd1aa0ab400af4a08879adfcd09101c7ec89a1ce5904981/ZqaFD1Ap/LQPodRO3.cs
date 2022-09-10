using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using IoSuaiAb;
using TGaER2JO;
using Y7FbhctW;
using av2p5dFj;
using di1mqJMz;
using geYLBm6w;
using ns2;
using ns3;
using yer6kF3B;

namespace ZqaFD1Ap;

[Serializable]
internal class LQPodRO3 : List<Class12>
{
	private GnNqYKdA kGDez7sf;

	private Color color_0;

	private Color color_1;

	private Font RIh48eRB;

	private Color liJL3bCb;

	private Color UEUJEq8B;

	private Color color_2;

	private Color hxnRQn6Q;

	private Color BCUWywzX;

	private Color J2s76Gsq;

	private Color zFXt4gIl;

	[NonSerialized]
	private Graphics kquwOLlx;

	private bool x471vc2B;

	private int int_0;

	public LQPodRO3(ref GnNqYKdA FdVcK7IC, Color UgQbD4OM, Color VcOGJXHV, Color color_3, Color MQqWm6RM, Font rEMgbdoe, Color XFSiboZH, Color vZ3brwNh, Color color_4, Color l1e5brJW, Color ase8KVCn, ref Graphics RJqn3FlV, int Rud8NBB4)
	{
		kGDez7sf = FdVcK7IC;
		color_0 = color_3;
		color_1 = VcOGJXHV;
		RIh48eRB = rEMgbdoe;
		liJL3bCb = UgQbD4OM;
		UEUJEq8B = MQqWm6RM;
		BCUWywzX = color_4;
		J2s76Gsq = ase8KVCn;
		zFXt4gIl = cZsR87iS.cEZfA4G8(25999);
		color_2 = XFSiboZH;
		hxnRQn6Q = vZ3brwNh;
		kquwOLlx = RJqn3FlV;
		int_0 = Rud8NBB4;
	}

	public LQPodRO3(ref GnNqYKdA f3X9aUv4, ref BinaryReader f71YiEx7, ref StKhY3Gf q1VTr2LF, Color GjdGeA8z, Color R9SGYsdX, Color dm7VEmCc, Color X6ILGHDd, Font ihtQGPPF, Color Yr78LQ8Y, Color OXF4VP1j, Color G0J7SmT9, Color wFoGYmho, Color wsXcfur6, ref Graphics XKXI1yhs)
	{
		kGDez7sf = f3X9aUv4;
		color_0 = dm7VEmCc;
		color_1 = R9SGYsdX;
		RIh48eRB = ihtQGPPF;
		liJL3bCb = GjdGeA8z;
		UEUJEq8B = X6ILGHDd;
		BCUWywzX = G0J7SmT9;
		J2s76Gsq = wsXcfur6;
		zFXt4gIl = wFoGYmho;
		color_2 = Yr78LQ8Y;
		hxnRQn6Q = OXF4VP1j;
		kquwOLlx = XKXI1yhs;
		int num = Class16.MnIpuB8b(f71YiEx7, 50393);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
		}
	}

	public LQPodRO3()
	{
	}

	public LQPodRO3 gaaF6IMC(ref GnNqYKdA yXC5ssZs, ref StKhY3Gf GhytSO3c)
	{
		Color ugQbD4OM = liJL3bCb;
		Color vcOGJXHV = color_1;
		Color color_ = color_0;
		Color uEUJEq8B = UEUJEq8B;
		Font rIh48eRB = RIh48eRB;
		Color xFSiboZH = color_2;
		Color vZ3brwNh = hxnRQn6Q;
		Color bCUWywzX = BCUWywzX;
		Color l1e5brJW = zFXt4gIl;
		Color j2s76Gsq = J2s76Gsq;
		Graphics RJqn3FlV = null;
		LQPodRO3 lQPodRO = new LQPodRO3(ref yXC5ssZs, ugQbD4OM, vcOGJXHV, color_, uEUJEq8B, rIh48eRB, xFSiboZH, vZ3brwNh, bCUWywzX, l1e5brJW, j2s76Gsq, ref RJqn3FlV, int_0);
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0)
			{
				lQPodRO.Add(current.qbzN4WGh(ref yXC5ssZs, ref GhytSO3c));
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return lQPodRO;
	}

	public void zCa8pa8X()
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.method_0();
			}
		}
		sSR2WoR5.IbTYXQVQ(this, 2531);
	}

	public void oWpObBhO()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			Class16.ufTFzFyL(enumerator.Current.ZE7Png1V(), 62823);
		}
	}

	public void FkDhSlDu(ref Graphics Lu1KZNzr)
	{
		kquwOLlx = Lu1KZNzr;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.t4tNCU16(ref kquwOLlx);
		}
	}

	public void method_0(bool PEHw2ag5)
	{
		x471vc2B = PEHw2ag5;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.M0kTvusF(ref x471vc2B);
		}
	}

	public void ZKOxbMkd()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.rlqaA3dA();
		}
	}

	public void YFmU8nXA(int mXIdvNg0, string string_0, string dWKfZ1gk, ref StKhY3Gf ESuShifr, ref StKhY3Gf G6a5r3zc, ref VZxzVnkV uNqVj6yR, bool dMGcDIBk, bool HozCinJP)
	{
		Class12 @class = new Class12(ref kGDez7sf, mXIdvNg0, string_0, dWKfZ1gk, ref ESuShifr, ref G6a5r3zc, ref uNqVj6yR, -1, liJL3bCb, color_1, color_0, UEUJEq8B, RIh48eRB, color_2, hxnRQn6Q, BCUWywzX, J2s76Gsq, zFXt4gIl, kquwOLlx, HozCinJP, int_0);
		Add(@class);
		@class.NA1Wmo3C(dMGcDIBk);
	}

	public Class12 Z0wyWm9a(int myLcBk0x)
	{
		return base[myLcBk0x];
	}

	public void jDFvC3OY(Rectangle uPn3tXT6, bool bool_0)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			Class12 current = enumerator.Current;
			if (current.Ls9OoDtc().IntersectsWith(uPn3tXT6))
			{
				current.NA1Wmo3C(bool_0);
			}
		}
	}

	public int CvP5WpIm(int o1iFHecW)
	{
		int result = -1;
		checked
		{
			int num = base.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (base[i].R6ZncuQL == o1iFHecW)
				{
					result = i;
					break;
				}
			}
			return result;
		}
	}

	public Class12 cx36Z5Gp(int FE80oGXj)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class12 current = enumerator.Current;
				if (current.R6ZncuQL == FE80oGXj)
				{
					return current;
				}
			}
		}
		return null;
	}

	public int IOS6dI25(ref Class12 class12_0)
	{
		int num = IndexOf(class12_0);
		if (FFXb5i9i.smethod_1(num, 48316))
		{
			num = -1;
		}
		return num;
	}

	public int oZ71WNRw()
	{
		checked
		{
			int num = base.Count + 1;
			for (int i = 1; i <= num; i++)
			{
				if (CvP5WpIm(i) == -1)
				{
					return i;
				}
			}
			int result = default(int);
			return result;
		}
	}

	public int PpqhgHYH()
	{
		return base.Count;
	}

	public bool method_1(int vYZYreLr, int giCpzVnU)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		for (int num = 0; num == 0; num = 1)
		{
			do
			{
				if (!enumerator.MoveNext())
				{
					return result;
				}
			}
			while (!enumerator.Current.bbX98W2U(vYZYreLr, giCpzVnU));
			result = true;
		}
		return result;
	}

	public bool XlhOiLPp(int int_1, int fDwYOT5A)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (enumerator.MoveNext())
		{
			Class12 current = enumerator.Current;
			if (current.bbX98W2U(int_1, fDwYOT5A))
			{
				result = true;
				current.pzMjs9TW(MIbBQ6gj: true);
				return result;
			}
		}
		return result;
	}

	public void DY1X5y88(Rectangle B2V0PUaK)
	{
		checked
		{
			using Enumerator enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class12 current = enumerator.Current;
				int num = (int)O4s9Dog1.zxrdwZWP((double)current.CFW7BH6j() / 5.0, 40554);
				int x = B2V0PUaK.X;
				int num2 = B2V0PUaK.X + B2V0PUaK.Width;
				int num3 = num;
				int i;
				int j;
				for (i = x; ((num3 >> 31) ^ i) <= ((num3 >> 31) ^ num2); i += num3)
				{
					int y = B2V0PUaK.Y;
					int num4 = B2V0PUaK.Y + B2V0PUaK.Height;
					int num5 = num;
					for (j = y; ((num5 >> 31) ^ j) <= ((num5 >> 31) ^ num4); j += num5)
					{
						if (current.bbX98W2U(i, j))
						{
							current.pzMjs9TW(MIbBQ6gj: true);
						}
					}
				}
				i = B2V0PUaK.X + B2V0PUaK.Width;
				int y2 = B2V0PUaK.Y;
				int num6 = B2V0PUaK.Y + B2V0PUaK.Height;
				int num7 = num;
				for (j = y2; ((num7 >> 31) ^ j) <= ((num7 >> 31) ^ num6); j += num7)
				{
					if (current.bbX98W2U(i, j))
					{
						current.pzMjs9TW(MIbBQ6gj: true);
					}
				}
				j = B2V0PUaK.Y + B2V0PUaK.Height;
				int x2 = B2V0PUaK.X;
				int num8 = B2V0PUaK.X + B2V0PUaK.Width;
				int num9 = num;
				for (i = x2; ((num9 >> 31) ^ i) <= ((num9 >> 31) ^ num8); i += num9)
				{
					if (current.bbX98W2U(i, j))
					{
						current.pzMjs9TW(MIbBQ6gj: true);
					}
				}
				i = B2V0PUaK.X + B2V0PUaK.Width;
				j = B2V0PUaK.Y + B2V0PUaK.Height;
				if (current.bbX98W2U(i, j))
				{
					current.pzMjs9TW(MIbBQ6gj: true);
				}
			}
		}
	}

	public bool method_2(int Ol9Vpo64, int fGajJRku)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			Class12 current = enumerator.Current;
			if (current.bbX98W2U(Ol9Vpo64, fGajJRku) & current.method_2())
			{
				return true;
			}
		}
		bool result = default(bool);
		return result;
	}

	public void Pf3dAtsl()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.pzMjs9TW(MIbBQ6gj: false);
		}
	}

	public void sLPdYBKy()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.pzMjs9TW(MIbBQ6gj: true);
		}
	}

	public void Nh8KocJc()
	{
		int num = 0;
		checked
		{
			int num2 = base.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (base[i - num].method_2())
				{
					base[i - num].method_0();
					RemoveAt(i - num);
					num++;
				}
			}
		}
	}

	public void VQK8KQ0h(int gqEA1X9l)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			Class12 current = enumerator.Current;
			if (current.method_2())
			{
				int num = current.ocybDOFE();
				num = checked(num + gqEA1X9l);
				current.method_1(num);
			}
		}
	}

	public bool SOtDzS6D(StKhY3Gf WCwsJA6D)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (enumerator.MoveNext())
		{
			Class12 current = enumerator.Current;
			foreach (GAJDqHR0 item in WCwsJA6D)
			{
				GAJDqHR0 VNNmyRSz = item;
				if (current.A1I888Ta().hsKxRBCg(ref VNNmyRSz) == -1)
				{
					if (current.gNIXMyxN().hsKxRBCg(ref VNNmyRSz) != -1)
					{
						result = true;
						return result;
					}
					continue;
				}
				result = true;
				return result;
			}
		}
		return result;
	}

	public LQPodRO3 wRiJJkAB()
	{
		LQPodRO3 lQPodRO = new LQPodRO3();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0 && current.method_2())
			{
				lQPodRO.Add(current);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return lQPodRO;
	}

	public Rectangle LyXxX9wQ()
	{
		Rectangle rectangle = default(Rectangle);
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class12 class12_ = enumerator.Current;
				rectangle = ((IOS6dI25(ref class12_) == 0) ? U0nDFthS.gwkkMhir(rectangle, class12_.Ls9OoDtc(), 8631) : class12_.Ls9OoDtc());
			}
		}
		return rectangle;
	}

	public LQPodRO3 method_3(joI8IGp3 K6b7kxxF)
	{
		LQPodRO3 lQPodRO = new LQPodRO3();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0)
			{
				StKhY3Gf stKhY3Gf = current.gNIXMyxN();
				GAJDqHR0 VNNmyRSz = K6b7kxxF;
				int num2 = stKhY3Gf.hsKxRBCg(ref VNNmyRSz);
				K6b7kxxF = (joI8IGp3)VNNmyRSz;
				if (num2 != -1)
				{
					lQPodRO.Add(current);
				}
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return lQPodRO;
	}

	public LQPodRO3 k14aFpBy(joI8IGp3 dRS1VyGN)
	{
		LQPodRO3 lQPodRO = new LQPodRO3();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0)
			{
				StKhY3Gf stKhY3Gf = current.A1I888Ta();
				GAJDqHR0 VNNmyRSz = dRS1VyGN;
				int num2 = stKhY3Gf.hsKxRBCg(ref VNNmyRSz);
				dRS1VyGN = (joI8IGp3)VNNmyRSz;
				if (num2 != -1)
				{
					lQPodRO.Add(current);
				}
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return lQPodRO;
	}

	public void method_4(bool efZC8thd)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0 && current.method_2())
			{
				current.Pcqr1E3i(efZC8thd);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public void method_5(bool bimSdC8b)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0 && ((current.A1I888Ta().dzbmRAOB().moKiVAwu() > 0) | (current.gNIXMyxN().dzbmRAOB().moKiVAwu() > 0)))
			{
				current.Pcqr1E3i(bimSdC8b);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public void pn1EdBWO(bool bool_0)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0 && current.method_2())
			{
				current.NA1Wmo3C(bool_0);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public void zE0DlLIL(int vCKq91dB)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0 && current.method_2())
			{
				current.GAdOW22b(vCKq91dB);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public bool method_6(Rectangle koNroLic, ref bool RCiyBuPE, ref bool Eg9ARwF5)
	{
		checked
		{
			using Enumerator enumerator = GetEnumerator();
			bool flag = default(bool);
			while (true)
			{
				if (enumerator.MoveNext())
				{
					Class12 current = enumerator.Current;
					if (current.method_2())
					{
						Rectangle rectangle = current.Ls9OoDtc();
						if ((rectangle.X <= koNroLic.X) | (rectangle.X + rectangle.Width >= koNroLic.X + koNroLic.Width))
						{
							flag = true;
							RCiyBuPE = true;
						}
						if ((rectangle.Y <= koNroLic.Y) | (rectangle.Y + rectangle.Height >= koNroLic.Y + koNroLic.Height))
						{
							flag = true;
							Eg9ARwF5 = true;
						}
						if (flag)
						{
							break;
						}
					}
					continue;
				}
				return flag;
			}
			return flag;
		}
	}

	public bool pkiBMFiW(int EBiXXhmJ)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			int num = 0;
			bool result = default(bool);
			while (true)
			{
				IL_0029:
				if (num == 0)
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.R6ZncuQL != EBiXXhmJ)
						{
							continue;
						}
						result = true;
						num = 1;
						goto IL_0029;
					}
					break;
				}
				return result;
			}
		}
		return false;
	}

	public int jyyxJF0C()
	{
		int num = 0;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current.method_2())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public Class12 Yy5bupxO()
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class12 current = enumerator.Current;
				if (current.method_2())
				{
					return current;
				}
			}
		}
		return null;
	}

	public void JH23sGpc()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.AAJgY8Qk(bool_0: false);
		}
	}

	public LQPodRO3 jmTZcSGn(ref GAJDqHR0 UphiX7mJ)
	{
		LQPodRO3 lQPodRO = new LQPodRO3();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		Class12 current = default(Class12);
		while (true)
		{
			if (num != 0 && current.uelWGmkp(ref UphiX7mJ))
			{
				lQPodRO.Add(current);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return lQPodRO;
	}
}
