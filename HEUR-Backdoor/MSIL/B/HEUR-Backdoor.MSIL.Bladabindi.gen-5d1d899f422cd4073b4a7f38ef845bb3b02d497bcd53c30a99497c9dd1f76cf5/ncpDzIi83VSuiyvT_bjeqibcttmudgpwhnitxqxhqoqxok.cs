using System;
using XjXnoB31;

internal sealed class ncpDzIi83VSuiyvT_bjeqibcttmudgpwhnitxqxhqoqxok
{
	private enum cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx
	{
		a,
		b,
		c,
		d,
		e,
		f,
		g,
		h,
		i,
		j
	}

	private const int a = 1440;

	internal static readonly int[] b = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	private cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx c;

	internal int d;

	internal int e;

	internal int f;

	internal int[] g;

	internal int[] h = new int[1];

	internal int[] i = new int[1];

	internal nJYrtAupA_bjeqibcttmudgpwhnitxqxhqoqxom j = new nJYrtAupA_bjeqibcttmudgpwhnitxqxhqoqxom();

	internal int k;

	internal GClass1 l;

	internal int m;

	internal int n;

	internal int[] o;

	internal byte[] p;

	internal int q;

	internal int r;

	internal int s;

	internal object t;

	internal uint u;

	internal Nf6rhQRSeplxSb_bjeqibcttmudgpwhnitxqxhqoqxoo v = new Nf6rhQRSeplxSb_bjeqibcttmudgpwhnitxqxhqoqxoo();

	internal ncpDzIi83VSuiyvT_bjeqibcttmudgpwhnitxqxhqoqxok(GClass1 a, object b, int c)
	{
		l = a;
		o = new int[4320];
		p = new byte[c];
		q = c;
		t = b;
		this.c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.a;
		PsYjkc_a();
	}

	internal uint PsYjkc_a()
	{
		uint result = u;
		c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.a;
		m = 0;
		n = 0;
		s = 0;
		r = 0;
		if (t != null)
		{
			l.c = (u = iPb2Xq.xzUz5iI85y4(0u, null, 0, 0));
		}
		return result;
	}

	internal int PsYjkc_b(int a)
	{
		int num = l.int_0;
		int num2 = l.IERyRPH5INmHzNia;
		int num3 = n;
		int i = m;
		int num4 = s;
		int num5 = ((num4 < r) ? (r - num4 - 1) : (q - num4));
		while (true)
		{
			switch (c)
			{
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.g:
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				a = j.PsYjkc_b(this, a);
				if (a == 1)
				{
					a = 0;
					num = l.int_0;
					num2 = l.IERyRPH5INmHzNia;
					num3 = n;
					i = m;
					num4 = s;
					num5 = ((num4 < r) ? (r - num4 - 1) : (q - num4));
					if (k == 0)
					{
						c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.a;
						break;
					}
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.h;
					goto case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.h;
				}
				return PsYjkc_f(a);
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.f:
			{
				int num6;
				while (true)
				{
					num6 = e;
					if (f >= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F))
					{
						break;
					}
					for (num6 = h[0]; i < num6; i += 8)
					{
						if (num2 != 0)
						{
							a = 0;
							num2--;
							num3 |= (l.rpH1xWxlQbQKT[num++] & 0xFF) << i;
							continue;
						}
						n = num3;
						m = i;
						l.IERyRPH5INmHzNia = num2;
						l.long_0 += num - l.int_0;
						l.int_0 = num;
						s = num4;
						return PsYjkc_f(a);
					}
					num6 = o[(this.i[0] + (num3 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num6])) * 3 + 1];
					int num7 = o[(this.i[0] + (num3 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num6])) * 3 + 2];
					if (num7 < 16)
					{
						num3 >>= num6;
						i -= num6;
						g[f++] = num7;
						continue;
					}
					int num8 = ((num7 == 18) ? 7 : (num7 - 14));
					int num9 = ((num7 == 18) ? 11 : 3);
					for (; i < num6 + num8; i += 8)
					{
						if (num2 != 0)
						{
							a = 0;
							num2--;
							num3 |= (l.rpH1xWxlQbQKT[num++] & 0xFF) << i;
							continue;
						}
						n = num3;
						m = i;
						l.IERyRPH5INmHzNia = num2;
						l.long_0 += num - l.int_0;
						l.int_0 = num;
						s = num4;
						return PsYjkc_f(a);
					}
					num3 >>= num6;
					i -= num6;
					num9 += num3 & lFkAfJ4NJFgZ_bjeqibcttmudgpwhnitxqxhqoqxol.a[num8];
					num3 >>= num8;
					i -= num8;
					num8 = f;
					num6 = e;
					if (num8 + num9 <= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F) && (num7 != 16 || num8 >= 1))
					{
						num7 = ((num7 == 16) ? g[num8 - 1] : 0);
						do
						{
							g[num8++] = num7;
						}
						while (--num9 != 0);
						f = num8;
						continue;
					}
					g = null;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j;
					l.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ፍፊፒፅፈፍፀጄፆፍፐጄፈፁፊፃፐፌጄፖፁፔፁፅፐ", 58483), 63255);
					a = -3;
					n = num3;
					m = i;
					l.IERyRPH5INmHzNia = num2;
					l.long_0 += num - l.int_0;
					l.int_0 = num;
					s = num4;
					return PsYjkc_f(-3);
				}
				this.i[0] = -1;
				int[] array5 = new int[1] { 9 };
				int[] array6 = new int[1] { 6 };
				int[] array7 = new int[1];
				int[] array8 = new int[1];
				num6 = e;
				num6 = v.PsYjkc_c(257 + (num6 & 0x1F), 1 + ((num6 >> 5) & 0x1F), g, array5, array6, array7, array8, o, l);
				if (num6 == 0)
				{
					j.PsYjkc_a(array5[0], array6[0], o, array7[0], o, array8[0]);
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.g;
					goto case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.g;
				}
				if (num6 == -3)
				{
					g = null;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j;
				}
				a = num6;
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(a);
			}
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.e:
			{
				while (f < 4 + (e >> 10))
				{
					for (; i < 3; i += 8)
					{
						if (num2 != 0)
						{
							a = 0;
							num2--;
							num3 |= (l.rpH1xWxlQbQKT[num++] & 0xFF) << i;
							continue;
						}
						n = num3;
						m = i;
						l.IERyRPH5INmHzNia = num2;
						l.long_0 += num - l.int_0;
						l.int_0 = num;
						s = num4;
						return PsYjkc_f(a);
					}
					g[b[f++]] = num3 & 7;
					num3 >>= 3;
					i -= 3;
				}
				while (f < 19)
				{
					g[b[f++]] = 0;
				}
				h[0] = 7;
				int num6 = v.PsYjkc_b(g, h, this.i, o, l);
				if (num6 == 0)
				{
					f = 0;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.f;
					goto case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.f;
				}
				a = num6;
				if (a == -3)
				{
					g = null;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j;
				}
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(a);
			}
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.d:
			{
				for (; i < 14; i += 8)
				{
					if (num2 != 0)
					{
						a = 0;
						num2--;
						num3 |= (l.rpH1xWxlQbQKT[num++] & 0xFF) << i;
						continue;
					}
					n = num3;
					m = i;
					l.IERyRPH5INmHzNia = num2;
					l.long_0 += num - l.int_0;
					l.int_0 = num;
					s = num4;
					return PsYjkc_f(a);
				}
				int num6 = (e = num3 & 0x3FFF);
				if ((num6 & 0x1F) <= 29 && ((num6 >> 5) & 0x1F) <= 29)
				{
					num6 = 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F);
					if (g != null && g.Length >= num6)
					{
						Array.Clear(g, 0, num6);
					}
					else
					{
						g = new int[num6];
					}
					num3 >>= 14;
					i -= 14;
					f = 0;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.e;
					goto case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.e;
				}
				c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j;
				l.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᘼᘧᘧᙨᘥᘩᘦᘱᙨᘤᘭᘦᘯᘼᘠᙨᘧᘺᙨᘬᘡᘻᘼᘩᘦᘫᘭᙨᘻᘱᘥᘪᘧᘤᘻ", 62726), 58237);
				a = -3;
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(-3);
			}
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.c:
				if (num2 != 0)
				{
					if (num5 == 0)
					{
						if (num4 == q && r != 0)
						{
							num4 = 0;
							num5 = ((0 < r) ? (r - num4 - 1) : (q - num4));
						}
						if (num5 == 0)
						{
							s = num4;
							a = PsYjkc_f(a);
							num4 = s;
							num5 = ((num4 < r) ? (r - num4 - 1) : (q - num4));
							if (num4 == q && r != 0)
							{
								num4 = 0;
								num5 = ((0 < r) ? (r - num4 - 1) : (q - num4));
							}
							if (num5 == 0)
							{
								n = num3;
								m = i;
								l.IERyRPH5INmHzNia = num2;
								l.long_0 += num - l.int_0;
								l.int_0 = num;
								s = num4;
								return PsYjkc_f(a);
							}
						}
					}
					a = 0;
					int num6 = d;
					if (num6 > num2)
					{
						num6 = num2;
					}
					if (num6 > num5)
					{
						num6 = num5;
					}
					Array.Copy(l.rpH1xWxlQbQKT, num, p, num4, num6);
					num += num6;
					num2 -= num6;
					num4 += num6;
					num5 -= num6;
					if ((d -= num6) == 0)
					{
						c = ((k != 0) ? cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.h : cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.a);
					}
					break;
				}
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(a);
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.b:
				for (; i < 32; i += 8)
				{
					if (num2 != 0)
					{
						a = 0;
						num2--;
						num3 |= (l.rpH1xWxlQbQKT[num++] & 0xFF) << i;
						continue;
					}
					n = num3;
					m = i;
					l.IERyRPH5INmHzNia = num2;
					l.long_0 += num - l.int_0;
					l.int_0 = num;
					s = num4;
					return PsYjkc_f(a);
				}
				if (((~num3 >> 16) & 0xFFFF) == (num3 & 0xFFFF))
				{
					d = num3 & 0xFFFF;
					i = 0;
					num3 = 0;
					c = ((d != 0) ? cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.c : ((k != 0) ? cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.h : cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.a));
					break;
				}
				c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j;
				l.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u1acd\u1aca\u1ad2\u1ac5\u1ac8\u1acd\u1ac0᪄\u1ad7\u1ad0\u1acb\u1ad6\u1ac1\u1ac0᪄\u1ac6\u1ac8\u1acb\u1ac7\u1acf᪄\u1ac8\u1ac1\u1aca\u1ac3\u1ad0\u1acc\u1ad7", 63255), 60849);
				a = -3;
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(-3);
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.a:
			{
				for (; i < 3; i += 8)
				{
					if (num2 != 0)
					{
						a = 0;
						num2--;
						num3 |= (l.rpH1xWxlQbQKT[num++] & 0xFF) << i;
						continue;
					}
					n = num3;
					m = i;
					l.IERyRPH5INmHzNia = num2;
					l.long_0 += num - l.int_0;
					l.int_0 = num;
					s = num4;
					return PsYjkc_f(a);
				}
				int num6 = num3 & 7;
				k = num6 & 1;
				switch ((uint)num6 >> 1)
				{
				case 0u:
					num3 >>= 3;
					i -= 3;
					num6 = i & 7;
					num3 >>= num6;
					i -= num6;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.b;
					break;
				case 1u:
				{
					int[] array = new int[1];
					int[] array2 = new int[1];
					int[][] array3 = new int[1][];
					int[][] array4 = new int[1][];
					Nf6rhQRSeplxSb_bjeqibcttmudgpwhnitxqxhqoqxoo.PsYjkc_d(array, array2, array3, array4, l);
					j.PsYjkc_a(array[0], array2[0], array3[0], 0, array4[0], 0);
					num3 >>= 3;
					i -= 3;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.g;
					break;
				}
				case 2u:
					num3 >>= 3;
					i -= 3;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.d;
					break;
				case 3u:
					num3 >>= 3;
					i -= 3;
					c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j;
					l.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ጞጙጁ\u1316ጛጞጓፗጕጛጘጔጜፗጃጎጇጒ", 58650), 63205);
					a = -3;
					n = num3;
					m = i;
					l.IERyRPH5INmHzNia = num2;
					l.long_0 += num - l.int_0;
					l.int_0 = num;
					s = num4;
					return PsYjkc_f(-3);
				}
				break;
			}
			default:
				a = -2;
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(-2);
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.h:
				s = num4;
				a = PsYjkc_f(a);
				num4 = s;
				num5 = ((num4 < r) ? (r - num4 - 1) : (q - num4));
				if (r != s)
				{
					n = num3;
					m = i;
					l.IERyRPH5INmHzNia = num2;
					l.long_0 += num - l.int_0;
					l.int_0 = num;
					s = num4;
					return PsYjkc_f(a);
				}
				c = cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.i;
				goto case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.i;
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.i:
				a = 1;
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(1);
			case cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.j:
				a = -3;
				n = num3;
				m = i;
				l.IERyRPH5INmHzNia = num2;
				l.long_0 += num - l.int_0;
				l.int_0 = num;
				s = num4;
				return PsYjkc_f(-3);
			}
		}
	}

	internal void PsYjkc_c()
	{
		PsYjkc_a();
		p = null;
		o = null;
	}

	internal void PsYjkc_d(byte[] a, int b, int c)
	{
		Array.Copy(a, b, p, 0, c);
		r = (s = c);
	}

	internal int PsYjkc_e()
	{
		if (c != cqVrduZAqs_wngmhsrtlaleghdowwcthfbsbrtfx.b)
		{
			return 0;
		}
		return 1;
	}

	internal int PsYjkc_f(int a)
	{
		int num = 0;
		while (true)
		{
			if (num >= 2)
			{
				return a;
			}
			int num2 = ((num != 0) ? (s - r) : (((r <= s) ? s : q) - r));
			if (num2 == 0)
			{
				break;
			}
			if (num2 > l.jb8wh8)
			{
				num2 = l.jb8wh8;
			}
			if (num2 != 0 && a == -5)
			{
				a = 0;
			}
			l.jb8wh8 -= num2;
			l.cVk5Mz += num2;
			if (t != null)
			{
				l.c = (u = iPb2Xq.xzUz5iI85y4(u, p, r, num2));
			}
			Array.Copy(p, r, l.byte_0, l.Pc3XlGJDtqV6e, num2);
			l.Pc3XlGJDtqV6e += num2;
			r += num2;
			if (r == q && num == 0)
			{
				r = 0;
				if (s == q)
				{
					s = 0;
				}
			}
			else
			{
				num++;
			}
			num++;
		}
		if (a == -5)
		{
			a = 0;
		}
		return a;
	}
}
