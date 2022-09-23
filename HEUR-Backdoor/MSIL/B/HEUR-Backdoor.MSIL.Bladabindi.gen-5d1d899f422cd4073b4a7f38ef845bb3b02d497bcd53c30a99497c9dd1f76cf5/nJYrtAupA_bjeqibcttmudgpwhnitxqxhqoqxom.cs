using System;
using XjXnoB31;

internal sealed class nJYrtAupA_bjeqibcttmudgpwhnitxqxhqoqxom
{
	private const int a = 0;

	private const int b = 1;

	private const int c = 2;

	private const int d = 3;

	private const int e = 4;

	private const int f = 5;

	private const int g = 6;

	private const int h = 7;

	private const int i = 8;

	private const int j = 9;

	internal int k;

	internal int l;

	internal int[] m;

	internal int n;

	internal int o;

	internal int p;

	internal int q;

	internal int r;

	internal byte s;

	internal byte t;

	internal int[] u;

	internal int v;

	internal int[] w;

	internal int x;

	internal nJYrtAupA_bjeqibcttmudgpwhnitxqxhqoqxom()
	{
	}

	internal void PsYjkc_a(int a, int b, int[] c, int d, int[] e, int f)
	{
		k = 0;
		s = (byte)a;
		t = (byte)b;
		u = c;
		v = d;
		w = e;
		x = f;
		m = null;
	}

	internal int PsYjkc_b(ncpDzIi83VSuiyvT_bjeqibcttmudgpwhnitxqxhqoqxok a, int b)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		GClass1 gClass = a.l;
		num3 = gClass.int_0;
		int num4 = gClass.IERyRPH5INmHzNia;
		num = a.n;
		num2 = a.m;
		int num5 = a.s;
		int num6 = ((num5 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
		while (true)
		{
			switch (k)
			{
			case 6:
				if (num6 == 0)
				{
					if (num5 == a.q && a.r != 0)
					{
						num5 = 0;
						num6 = ((0 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
					}
					if (num6 == 0)
					{
						a.s = num5;
						b = a.PsYjkc_f(b);
						num5 = a.s;
						num6 = ((num5 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
						if (num5 == a.q && a.r != 0)
						{
							num5 = 0;
							num6 = ((0 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
						}
						if (num6 == 0)
						{
							a.n = num;
							a.m = num2;
							gClass.IERyRPH5INmHzNia = num4;
							gClass.long_0 += num3 - gClass.int_0;
							gClass.int_0 = num3;
							a.s = num5;
							return a.PsYjkc_f(b);
						}
					}
				}
				b = 0;
				a.p[num5++] = (byte)p;
				num6--;
				k = 0;
				break;
			case 5:
			{
				int i;
				for (i = num5 - r; i < 0; i += a.q)
				{
				}
				while (l != 0)
				{
					if (num6 == 0)
					{
						if (num5 == a.q && a.r != 0)
						{
							num5 = 0;
							num6 = ((0 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
						}
						if (num6 == 0)
						{
							a.s = num5;
							b = a.PsYjkc_f(b);
							num5 = a.s;
							num6 = ((num5 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
							if (num5 == a.q && a.r != 0)
							{
								num5 = 0;
								num6 = ((0 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
							}
							if (num6 == 0)
							{
								a.n = num;
								a.m = num2;
								gClass.IERyRPH5INmHzNia = num4;
								gClass.long_0 += num3 - gClass.int_0;
								gClass.int_0 = num3;
								a.s = num5;
								return a.PsYjkc_f(b);
							}
						}
					}
					a.p[num5++] = a.p[i++];
					num6--;
					if (i == a.q)
					{
						i = 0;
					}
					l--;
				}
				k = 0;
				break;
			}
			case 4:
			{
				int num7;
				for (num7 = q; num2 < num7; num2 += 8)
				{
					if (num4 != 0)
					{
						b = 0;
						num4--;
						num |= (gClass.rpH1xWxlQbQKT[num3++] & 0xFF) << num2;
						continue;
					}
					a.n = num;
					a.m = num2;
					gClass.IERyRPH5INmHzNia = num4;
					gClass.long_0 += num3 - gClass.int_0;
					gClass.int_0 = num3;
					a.s = num5;
					return a.PsYjkc_f(b);
				}
				r += num & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num7];
				num >>= num7;
				num2 -= num7;
				k = 5;
				goto case 5;
			}
			case 3:
			{
				int num7;
				for (num7 = o; num2 < num7; num2 += 8)
				{
					if (num4 != 0)
					{
						b = 0;
						num4--;
						num |= (gClass.rpH1xWxlQbQKT[num3++] & 0xFF) << num2;
						continue;
					}
					a.n = num;
					a.m = num2;
					gClass.IERyRPH5INmHzNia = num4;
					gClass.long_0 += num3 - gClass.int_0;
					gClass.int_0 = num3;
					a.s = num5;
					return a.PsYjkc_f(b);
				}
				int num8 = (n + (num & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num7])) * 3;
				num >>= m[num8 + 1];
				num2 -= m[num8 + 1];
				int num9 = m[num8];
				if (((uint)num9 & 0x10u) != 0)
				{
					q = num9 & 0xF;
					r = m[num8 + 2];
					k = 4;
					break;
				}
				if ((num9 & 0x40) == 0)
				{
					o = num9;
					n = num8 / 3 + m[num8 + 2];
					break;
				}
				k = 9;
				gClass.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u02e9ˮ\u02f6ˡˬ\u02e9ˤʠˤ\u02e9\u02f3\u02f4ˡˮˣ\u02e5ʠˣ\u02efˤ\u02e5", 59471), 60119);
				b = -3;
				a.n = num;
				a.m = num2;
				gClass.IERyRPH5INmHzNia = num4;
				gClass.long_0 += num3 - gClass.int_0;
				gClass.int_0 = num3;
				a.s = num5;
				return a.PsYjkc_f(-3);
			}
			case 2:
			{
				int num7;
				for (num7 = q; num2 < num7; num2 += 8)
				{
					if (num4 != 0)
					{
						b = 0;
						num4--;
						num |= (gClass.rpH1xWxlQbQKT[num3++] & 0xFF) << num2;
						continue;
					}
					a.n = num;
					a.m = num2;
					gClass.IERyRPH5INmHzNia = num4;
					gClass.long_0 += num3 - gClass.int_0;
					gClass.int_0 = num3;
					a.s = num5;
					return a.PsYjkc_f(b);
				}
				l += num & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num7];
				num >>= num7;
				num2 -= num7;
				o = t;
				m = w;
				n = x;
				k = 3;
				goto case 3;
			}
			case 1:
			{
				int num7;
				for (num7 = o; num2 < num7; num2 += 8)
				{
					if (num4 != 0)
					{
						b = 0;
						num4--;
						num |= (gClass.rpH1xWxlQbQKT[num3++] & 0xFF) << num2;
						continue;
					}
					a.n = num;
					a.m = num2;
					gClass.IERyRPH5INmHzNia = num4;
					gClass.long_0 += num3 - gClass.int_0;
					gClass.int_0 = num3;
					a.s = num5;
					return a.PsYjkc_f(b);
				}
				int num8 = (n + (num & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num7])) * 3;
				num >>= m[num8 + 1];
				num2 -= m[num8 + 1];
				int num9 = m[num8];
				if (num9 == 0)
				{
					p = m[num8 + 2];
					k = 6;
					break;
				}
				if (((uint)num9 & 0x10u) != 0)
				{
					q = num9 & 0xF;
					l = m[num8 + 2];
					k = 2;
					break;
				}
				if ((num9 & 0x40) == 0)
				{
					o = num9;
					n = num8 / 3 + m[num8 + 2];
					break;
				}
				if (((uint)num9 & 0x20u) != 0)
				{
					k = 7;
					break;
				}
				k = 9;
				gClass.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("STL[VS^\u001aVSN_H[V\u0015V_T]NR\u001aYU^_", 63734), 63685);
				b = -3;
				a.n = num;
				a.m = num2;
				gClass.IERyRPH5INmHzNia = num4;
				gClass.long_0 += num3 - gClass.int_0;
				gClass.int_0 = num3;
				a.s = num5;
				return a.PsYjkc_f(-3);
			}
			case 0:
				if (num6 >= 258 && num4 >= 10)
				{
					a.n = num;
					a.m = num2;
					gClass.IERyRPH5INmHzNia = num4;
					gClass.long_0 += num3 - gClass.int_0;
					gClass.int_0 = num3;
					a.s = num5;
					b = PsYjkc_c(s, t, u, v, w, x, a, gClass);
					num3 = gClass.int_0;
					num4 = gClass.IERyRPH5INmHzNia;
					num = a.n;
					num2 = a.m;
					num5 = a.s;
					num6 = ((num5 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
					if (b != 0)
					{
						k = ((b == 1) ? 7 : 9);
						break;
					}
				}
				o = s;
				m = u;
				n = v;
				k = 1;
				goto case 1;
			default:
				b = -2;
				a.n = num;
				a.m = num2;
				gClass.IERyRPH5INmHzNia = num4;
				gClass.long_0 += num3 - gClass.int_0;
				gClass.int_0 = num3;
				a.s = num5;
				return a.PsYjkc_f(-2);
			case 7:
				if (num2 > 7)
				{
					num2 -= 8;
					num4++;
					num3--;
				}
				a.s = num5;
				b = a.PsYjkc_f(b);
				num5 = a.s;
				num6 = ((num5 < a.r) ? (a.r - num5 - 1) : (a.q - num5));
				if (a.r != a.s)
				{
					a.n = num;
					a.m = num2;
					gClass.IERyRPH5INmHzNia = num4;
					gClass.long_0 += num3 - gClass.int_0;
					gClass.int_0 = num3;
					a.s = num5;
					return a.PsYjkc_f(b);
				}
				k = 8;
				goto case 8;
			case 8:
				b = 1;
				a.n = num;
				a.m = num2;
				gClass.IERyRPH5INmHzNia = num4;
				gClass.long_0 += num3 - gClass.int_0;
				gClass.int_0 = num3;
				a.s = num5;
				return a.PsYjkc_f(1);
			case 9:
				b = -3;
				a.n = num;
				a.m = num2;
				gClass.IERyRPH5INmHzNia = num4;
				gClass.long_0 += num3 - gClass.int_0;
				gClass.int_0 = num3;
				a.s = num5;
				return a.PsYjkc_f(-3);
			}
		}
	}

	internal int PsYjkc_c(int a, int b, int[] c, int d, int[] e, int f, ncpDzIi83VSuiyvT_bjeqibcttmudgpwhnitxqxhqoqxok g, GClass1 h)
	{
		int int_ = h.int_0;
		int num = h.IERyRPH5INmHzNia;
		int num2 = g.n;
		int num3 = g.m;
		int num4 = g.s;
		int num5 = ((num4 < g.r) ? (g.r - num4 - 1) : (g.q - num4));
		int num6 = lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[a];
		int num7 = lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[b];
		int num12;
		while (true)
		{
			if (num3 < 20)
			{
				num--;
				num2 |= (h.rpH1xWxlQbQKT[int_++] & 0xFF) << num3;
				num3 += 8;
				continue;
			}
			int num8 = num2 & num6;
			int[] array = c;
			int num9 = d;
			int num10 = (num9 + num8) * 3;
			int num11;
			if ((num11 = array[num10]) == 0)
			{
				num2 >>= array[num10 + 1];
				num3 -= array[num10 + 1];
				g.p[num4++] = (byte)array[num10 + 2];
				num5--;
			}
			else
			{
				while (true)
				{
					num2 >>= array[num10 + 1];
					num3 -= array[num10 + 1];
					if ((num11 & 0x10) == 0)
					{
						if ((num11 & 0x40) == 0)
						{
							num8 += array[num10 + 2];
							num8 += num2 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num11];
							num10 = (num9 + num8) * 3;
							if ((num11 = array[num10]) == 0)
							{
								num2 >>= array[num10 + 1];
								num3 -= array[num10 + 1];
								g.p[num4++] = (byte)array[num10 + 2];
								num5--;
								break;
							}
							continue;
						}
						if (((uint)num11 & 0x20u) != 0)
						{
							num12 = h.IERyRPH5INmHzNia - num;
							num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
							num += num12;
							int_ -= num12;
							num3 -= num12 << 3;
							g.n = num2;
							g.m = num3;
							h.IERyRPH5INmHzNia = num;
							h.long_0 += int_ - h.int_0;
							h.int_0 = int_;
							g.s = num4;
							return 1;
						}
						h.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ࠍࠊࠒࠅࠈࠍࠀࡄࠈࠍࠐࠁ\u0816ࠅࠈࡋࠈࠁࠊࠃࠐࠌࡄࠇࠋࠀࠁ", 60351), 58323);
						num12 = h.IERyRPH5INmHzNia - num;
						num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
						num += num12;
						int_ -= num12;
						num3 -= num12 << 3;
						g.n = num2;
						g.m = num3;
						h.IERyRPH5INmHzNia = num;
						h.long_0 += int_ - h.int_0;
						h.int_0 = int_;
						g.s = num4;
						return -3;
					}
					num11 &= 0xF;
					num12 = array[num10 + 2] + (num2 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num11]);
					num2 >>= num11;
					for (num3 -= num11; num3 < 15; num3 += 8)
					{
						num--;
						num2 |= (h.rpH1xWxlQbQKT[int_++] & 0xFF) << num3;
					}
					num8 = num2 & num7;
					array = e;
					num9 = f;
					num10 = (num9 + num8) * 3;
					num11 = array[num10];
					while (true)
					{
						num2 >>= array[num10 + 1];
						num3 -= array[num10 + 1];
						if (((uint)num11 & 0x10u) != 0)
						{
							break;
						}
						if ((num11 & 0x40) == 0)
						{
							num8 += array[num10 + 2];
							num8 += num2 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num11];
							num10 = (num9 + num8) * 3;
							num11 = array[num10];
							continue;
						}
						h.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u1c29\u1c2e\u1c36ᰡ\u1c2c\u1c29\u1c24ᱠ\u1c24\u1c29\u1c33\u1c34ᰡ\u1c2eᰣ\u1c25ᱠᰣ\u1c2f\u1c24\u1c25", 60051), 63169);
						num12 = h.IERyRPH5INmHzNia - num;
						num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
						num += num12;
						int_ -= num12;
						num3 -= num12 << 3;
						g.n = num2;
						g.m = num3;
						h.IERyRPH5INmHzNia = num;
						h.long_0 += int_ - h.int_0;
						h.int_0 = int_;
						g.s = num4;
						return -3;
					}
					for (num11 &= 0xF; num3 < num11; num3 += 8)
					{
						num--;
						num2 |= (h.rpH1xWxlQbQKT[int_++] & 0xFF) << num3;
					}
					int num13 = array[num10 + 2] + (num2 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num11]);
					num2 >>= num11;
					num3 -= num11;
					num5 -= num12;
					int num14;
					if (num4 >= num13)
					{
						num14 = num4 - num13;
						if (num4 - num14 > 0 && 2 > num4 - num14)
						{
							g.p[num4++] = g.p[num14++];
							g.p[num4++] = g.p[num14++];
							num12 -= 2;
						}
						else
						{
							Array.Copy(g.p, num14, g.p, num4, 2);
							num4 += 2;
							num14 += 2;
							num12 -= 2;
						}
					}
					else
					{
						num14 = num4 - num13;
						do
						{
							num14 += g.q;
						}
						while (num14 < 0);
						num11 = g.q - num14;
						if (num12 > num11)
						{
							num12 -= num11;
							if (num4 - num14 > 0 && num11 > num4 - num14)
							{
								do
								{
									g.p[num4++] = g.p[num14++];
								}
								while (--num11 != 0);
							}
							else
							{
								Array.Copy(g.p, num14, g.p, num4, num11);
								num4 += num11;
								num14 += num11;
								num11 = 0;
							}
							num14 = 0;
						}
					}
					if (num4 - num14 > 0 && num12 > num4 - num14)
					{
						do
						{
							g.p[num4++] = g.p[num14++];
						}
						while (--num12 != 0);
						break;
					}
					Array.Copy(g.p, num14, g.p, num4, num12);
					num4 += num12;
					num14 += num12;
					num12 = 0;
					break;
				}
			}
			if (num5 < 258 || num < 10)
			{
				break;
			}
		}
		num12 = h.IERyRPH5INmHzNia - num;
		num12 = ((num3 >> 3 < num12) ? (num3 >> 3) : num12);
		num += num12;
		int_ -= num12;
		num3 -= num12 << 3;
		g.n = num2;
		g.m = num3;
		h.IERyRPH5INmHzNia = num;
		h.long_0 += int_ - h.int_0;
		h.int_0 = int_;
		g.s = num4;
		return 0;
	}
}
