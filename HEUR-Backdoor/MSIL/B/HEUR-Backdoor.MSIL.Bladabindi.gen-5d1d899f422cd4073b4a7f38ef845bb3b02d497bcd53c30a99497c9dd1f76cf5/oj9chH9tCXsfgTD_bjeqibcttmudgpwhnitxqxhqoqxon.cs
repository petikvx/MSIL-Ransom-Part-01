using XjXnoB31;

internal sealed class oj9chH9tCXsfgTD_bjeqibcttmudgpwhnitxqxhqoqxon
{
	private enum fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu
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
		j,
		k,
		l,
		m,
		n
	}

	private const int a = 32;

	private const int b = 8;

	private fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu c;

	internal GClass1 d;

	internal int e;

	internal uint f;

	internal uint g;

	internal int h;

	private bool i = true;

	internal int j;

	internal ncpDzIi83VSuiyvT_bjeqibcttmudgpwhnitxqxhqoqxok k;

	private static readonly byte[] l = new byte[4] { 0, 0, 255, 255 };

	internal bool m
	{
		get
		{
			return i;
		}
		set
		{
			i = value;
		}
	}

	public oj9chH9tCXsfgTD_bjeqibcttmudgpwhnitxqxhqoqxon()
	{
	}

	public oj9chH9tCXsfgTD_bjeqibcttmudgpwhnitxqxhqoqxon(bool a)
	{
		i = a;
	}

	internal int PsYjkc_a()
	{
		GClass1 gClass = d;
		d.cVk5Mz = 0L;
		gClass.long_0 = 0L;
		d.pUqtyJHW = null;
		c = ((!m) ? fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.h : fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.a);
		k.PsYjkc_a();
		return 0;
	}

	internal int PsYjkc_b()
	{
		if (k != null)
		{
			k.PsYjkc_c();
		}
		k = null;
		return 0;
	}

	internal int PsYjkc_c(GClass1 a, int b)
	{
		d = a;
		d.pUqtyJHW = null;
		k = null;
		if (b >= 8 && b <= 15)
		{
			j = b;
			k = new ncpDzIi83VSuiyvT_bjeqibcttmudgpwhnitxqxhqoqxok(a, m ? this : null, 1 << b);
			PsYjkc_a();
			return 0;
		}
		PsYjkc_b();
		throw new Vq0hzqOV0Ivo0(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᭑\u1b72᭷ᬳ᭤᭺\u1b7d᭷᭼᭤ᬳ᭠᭺᭩᭶\u1b3d", 62141), 59662));
	}

	internal int PsYjkc_d(ADGP36Df a)
	{
		if (d.rpH1xWxlQbQKT == null)
		{
			throw new Vq0hzqOV0Ivo0(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᜱ\u1716ᜈ\u170dᜌ\u173a\u170d\u171e\u171e\u171dᜊ\u1758ᜑᜋ\u1758\u1716\u170d\u1714\u1714\u1756\u1758", 61633), 59312));
		}
		int num = 0;
		int num2 = -5;
		while (true)
		{
			switch (c)
			{
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.l:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g += (uint)(d.rpH1xWxlQbQKT[d.int_0++] & 0xFF);
					if (f != g)
					{
						c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
						d.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ԽԺԷԻԦԦԱԷԠմ\u0530ԵԠԵմԷԼԱԷԿ", 60025), 61192);
						h = 5;
						break;
					}
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.m;
					return 1;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.k:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g += (uint)((d.rpH1xWxlQbQKT[d.int_0++] << 8) & 0xFF00);
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.l;
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.j:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g += (uint)((d.rpH1xWxlQbQKT[d.int_0++] << 16) & 0xFF0000);
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.k;
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.i:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g = (uint)((ulong)(d.rpH1xWxlQbQKT[d.int_0++] << 24) & 0xFF000000uL);
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.j;
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.h:
				num2 = k.PsYjkc_b(num2);
				switch (num2)
				{
				case -3:
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
					h = 0;
					goto end_IL_066b;
				case 0:
					num2 = num;
					break;
				}
				if (num2 == 1)
				{
					num2 = num;
					f = k.PsYjkc_a();
					if (m)
					{
						c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.i;
						break;
					}
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.m;
					return 1;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.e:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g += (uint)((d.rpH1xWxlQbQKT[d.int_0++] << 8) & 0xFF00);
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.f;
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.d:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g += (uint)((d.rpH1xWxlQbQKT[d.int_0++] << 16) & 0xFF0000);
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.e;
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.c:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					g = (uint)((ulong)(d.rpH1xWxlQbQKT[d.int_0++] << 24) & 0xFF000000uL);
					c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.d;
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.b:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					int num3 = d.rpH1xWxlQbQKT[d.int_0++] & 0xFF;
					if (((e << 8) + num3) % 31 != 0)
					{
						c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
						d.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0c11ఖఛగఊఊఝఛఌౘఐఝఙజఝఊౘఛఐఝఛఓ", 62693), 63621);
						h = 5;
					}
					else
					{
						c = (((num3 & 0x20) == 0) ? fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.h : fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.c);
					}
					break;
				}
				return num2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.a:
				if (d.IERyRPH5INmHzNia != 0)
				{
					num2 = num;
					d.IERyRPH5INmHzNia--;
					d.long_0++;
					if (((e = d.rpH1xWxlQbQKT[d.int_0++]) & 0xF) != 8)
					{
						c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
						d.pUqtyJHW = string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0957\u094c\u0949\u094c\u094d\u0955\u094c\u0902\u0941\u094d\u094f\u0952ॐ\u0947\u0951\u0951\u094b\u094d\u094c\u0902\u094f\u0947\u0956\u094a\u094d\u0946\u0902ऊऒग़ख़ऒघॺऐय़ऋ", 61405), 58999), e);
						h = 5;
					}
					else if ((e >> 4) + 8 > j)
					{
						c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
						d.pUqtyJHW = string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᱿ᱸᱠᱷᱺ᱿ᱲ\u1c36ᱡ᱿ᱸᱲᱹᱡ\u1c36ᱥ᱿ᱬᱳ\u1c36᰾ᱭ\u1c26ᱫ᰿", 58605), 63625), (e >> 4) + 8);
						h = 5;
					}
					else
					{
						c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.b;
					}
					break;
				}
				return num2;
			default:
				throw new Vq0hzqOV0Ivo0(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᨿ\u1a18᨞ᨉᨍᨁᩌᨉ᨞᨞ᨃ᨞ᩂ", 59923), 61632));
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.f:
				if (d.IERyRPH5INmHzNia == 0)
				{
					return num2;
				}
				num2 = num;
				d.IERyRPH5INmHzNia--;
				d.long_0++;
				g += (uint)(d.rpH1xWxlQbQKT[d.int_0++] & 0xFF);
				d.c = g;
				c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.g;
				return 2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.g:
				c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
				d.pUqtyJHW = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ܕܞܞܟݛܟܒܘ\u070fܒܔܕܚ܉܂", 59908), 60908);
				h = 0;
				return -2;
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n:
				throw new Vq0hzqOV0Ivo0(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("៷។\u17d1ផ\u17c6\u17c1។\u17c1\u17d0ផឝ\u17ceច\u17c8វ", 61393), 63594), d.pUqtyJHW));
			case fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.m:
				{
					return 1;
				}
				end_IL_066b:
				break;
			}
		}
	}

	internal int PsYjkc_e(byte[] a)
	{
		int num = 0;
		int num2 = a.Length;
		if (c != fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.g)
		{
			throw new Vq0hzqOV0Ivo0(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u1dc3\u1de4\u1de2\u1df5\u1df1\u1dfdᶰ\u1df5\u1de2\u1de2\u1dff\u1de2ᶾ", 60497), 61773));
		}
		if (iPb2Xq.xzUz5iI85y4(1u, a, 0, a.Length) != d.c)
		{
			return -3;
		}
		d.c = iPb2Xq.xzUz5iI85y4(0u, null, 0, 0);
		if (num2 >= 1 << j)
		{
			num2 = (1 << j) - 1;
			num = a.Length - num2;
		}
		k.PsYjkc_d(a, num, num2);
		c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.h;
		return 0;
	}

	internal int PsYjkc_f()
	{
		if (c != fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n)
		{
			c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.n;
			h = 0;
		}
		int num;
		if ((num = d.IERyRPH5INmHzNia) == 0)
		{
			return -5;
		}
		int num2 = d.int_0;
		int num3 = h;
		while (num != 0 && num3 < 4)
		{
			num3 = ((d.rpH1xWxlQbQKT[num2] != l[num3]) ? ((d.rpH1xWxlQbQKT[num2] == 0) ? (4 - num3) : 0) : (num3 + 1));
			num2++;
			num--;
		}
		d.long_0 += num2 - d.int_0;
		d.int_0 = num2;
		d.IERyRPH5INmHzNia = num;
		h = num3;
		if (num3 != 4)
		{
			return -3;
		}
		long long_ = d.long_0;
		long cVk5Mz = d.cVk5Mz;
		PsYjkc_a();
		d.long_0 = long_;
		d.cVk5Mz = cVk5Mz;
		c = fzcD2oZRv_akvuirforehvfhfjgwtdoplomupsu.h;
		return 0;
	}

	internal int PsYjkc_g(GClass1 a)
	{
		return k.PsYjkc_e();
	}
}
