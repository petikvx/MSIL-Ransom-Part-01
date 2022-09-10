using System;
using CCfpfC7h;
using IoSuaiAb;
using Microsoft.VisualBasic;
using Y7FbhctW;
using di1mqJMz;
using hfpgL6Qd;
using iLd730DL;
using iiraiv39;
using p80hVGtz;
using wMk1FHff;

namespace ns1;

internal class WTSs9ucl
{
	public string string_0;

	private Uj8nVl61 fdETBdol;

	private string FbSFlnNW;

	public WTSs9ucl(ref Uj8nVl61 uj8nVl61_0)
	{
		fdETBdol = uj8nVl61_0;
	}

	public bool UFIfNRPI(string wggoxWVR)
	{
		bool result = true;
		string v1DaJgBe = "co(";
		int num = ivlgLlId.f5lHgZCI(wggoxWVR, 64616);
		int num2 = 1;
		checked
		{
			int num3 = default(int);
			while (true)
			{
				if (num2 <= num)
				{
					string text = ivlgLlId.zIKBYyAm(wggoxWVR, num2, 1, 41221);
					if (DGzajXFC(v1DaJgBe, U0nDFthS.SW3y4MmE(text, 63887)))
					{
						if (ivlgLlId.smethod_3(text, "+", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(text, "*", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(text, "-", bool_0: false, 3221) != 0 && ivlgLlId.smethod_3(text, "/", bool_0: false, 3221) != 0)
						{
							if (ivlgLlId.smethod_3(text, "(", bool_0: false, 3221) != 0)
							{
								if (ivlgLlId.smethod_3(text, ")", bool_0: false, 3221) != 0)
								{
									v1DaJgBe = "co)n";
								}
								else
								{
									v1DaJgBe = "o)";
									num3--;
								}
							}
							else
							{
								v1DaJgBe = "c(n";
								num3++;
							}
						}
						else
						{
							v1DaJgBe = "c(n";
						}
						num2++;
						continue;
					}
					string_0 = FFXb5i9i.Be2UxXd8(new string[5]
					{
						"Unexpected char at ",
						O4s9Dog1.cI1h7tEI(num2, 25972),
						": '",
						text,
						"'!"
					}, 53581);
					result = false;
					break;
				}
				if (num3 > 0)
				{
					string_0 = "Expected ')'";
					result = false;
				}
				else if (num3 < 0)
				{
					string_0 = "Expected '('";
					result = false;
				}
				break;
			}
			return result;
		}
	}

	private bool DGzajXFC(string v1DaJgBe, char F3RGY3sy)
	{
		checked
		{
			int num = ivlgLlId.f5lHgZCI(v1DaJgBe, 64616) - 1;
			for (int i = 0; i <= num; i++)
			{
				if (V3o1cX65(Class15.I9IgXm7u(v1DaJgBe, i, 26430), F3RGY3sy))
				{
					return true;
				}
			}
			bool result = default(bool);
			return result;
		}
	}

	private bool V3o1cX65(char R8OTUQuX, char Z5JMdEYg)
	{
		switch (R8OTUQuX)
		{
		case ')':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), ")", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case '(':
			if (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "(", bool_0: false, 3221) == 0)
			{
				return true;
			}
			break;
		case 'o':
			if ((ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "+", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "*", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "-", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "/", bool_0: false, 3221) == 0))
			{
				return true;
			}
			break;
		case 'n':
			if (Kqk9udae.bvAT73DM(Z5JMdEYg, 25550))
			{
				return true;
			}
			break;
		case 'c':
			if (!(U0nDFthS.suM9Ppzl(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "[+|\"'<>().,:; {}~/\\]^%@", (CompareMethod)0, 60449) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "-", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "*", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "#", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "?", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "!", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "[", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "]", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "*", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "/", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(U0nDFthS.gu9J6OJy(Z5JMdEYg, 48700), "+", bool_0: false, 3221) == 0)))
			{
				return true;
			}
			break;
		}
		bool result = default(bool);
		return result;
	}

	public double E1Jt5eTA(string e1egyEpy)
	{
		int num = 0;
		int num2 = 1;
		bool flag = false;
		checked
		{
			int num3 = default(int);
			while (true)
			{
				string text = ivlgLlId.zIKBYyAm(e1egyEpy, num2, 1, 41221);
				while (ivlgLlId.smethod_3(text, "", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(text, "(", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(text, ")", bool_0: false, 3221) == 0)
						{
							num--;
							if (num == 0)
							{
								string e1egyEpy2 = ivlgLlId.zIKBYyAm(e1egyEpy, num3 + 1, num2 - num3 - 1, 41221);
								e1egyEpy = U0nDFthS.gn4174gi(e1egyEpy, num3 - 1, num2 - num3 + 1, 12859);
								e1egyEpy = Kqk9udae.smethod_0(e1egyEpy, num3 - 1, E1Jt5eTA(e1egyEpy2).ToString(vRvDyS3Z.smethod_0(Class15.kJu0kMKf(45123), 40301)), 27888);
							}
						}
					}
					else
					{
						flag = true;
						if (num == 0)
						{
							num3 = num2;
						}
						num++;
					}
					num2++;
					text = ivlgLlId.zIKBYyAm(e1egyEpy, num2, 1, 41221);
				}
				if (!flag)
				{
					break;
				}
				flag = false;
				num2 = 1;
				num = 0;
			}
			return SC9OdAxX.XwEtgMIh(UyjBsIjO(e1egyEpy));
		}
	}

	private string UyjBsIjO(string zTHSjFkg)
	{
		string text = "";
		string string_ = "";
		string text2 = "";
		int i = 1;
		int num = 0;
		checked
		{
			for (; i < ivlgLlId.f5lHgZCI(zTHSjFkg, 64616); i++)
			{
				text = ivlgLlId.zIKBYyAm(zTHSjFkg, i, 1, 41221);
				if ((ivlgLlId.smethod_3(text, "*", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(text, "/", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(text, "+", bool_0: false, 3221) == 0) | (ivlgLlId.smethod_3(text, "-", bool_0: false, 3221) == 0))
				{
					num++;
					string_ = text;
				}
			}
			switch (num)
			{
			case 0:
			{
				if (Kqk9udae.bvAT73DM(zTHSjFkg, 25550))
				{
					return zTHSjFkg;
				}
				vilSnlZy vilSnlZy3 = null;
				if (FFXb5i9i.smethod_1(vilSnlZy3, 48316))
				{
					vilSnlZy3 = fdETBdol.LEZUQfn3(zTHSjFkg);
				}
				if (FFXb5i9i.smethod_1(vilSnlZy3, 48316))
				{
					throw new Exception(FFXb5i9i.smethod_0("Variable ", zTHSjFkg, " not found", 52605));
				}
				zTHSjFkg = vilSnlZy3.h2YblVSv();
				return zTHSjFkg;
			}
			case 1:
			{
				vilSnlZy vilSnlZy = null;
				vilSnlZy vilSnlZy2 = null;
				string text3 = U0nDFthS.gn4174gi(zTHSjFkg, 0, U0nDFthS.a7rPdJnI(zTHSjFkg, string_, 3436), 12858);
				if (!Kqk9udae.bvAT73DM(text3, 25550))
				{
					if (FFXb5i9i.smethod_1(vilSnlZy, 48316))
					{
						vilSnlZy = fdETBdol.LEZUQfn3(text3);
					}
					if (FFXb5i9i.smethod_1(vilSnlZy, 48316))
					{
						throw new Exception(FFXb5i9i.smethod_0("Variable ", text3, " not found", 52605));
					}
					text3 = vilSnlZy.h2YblVSv();
				}
				string text4 = U0nDFthS.smethod_1(zTHSjFkg, U0nDFthS.a7rPdJnI(zTHSjFkg, string_, 3436) + 1, 11550);
				if (!Kqk9udae.bvAT73DM(text4, 25550))
				{
					if (FFXb5i9i.smethod_1(vilSnlZy2, 48316))
					{
						vilSnlZy2 = fdETBdol.LEZUQfn3(text4);
					}
					if (FFXb5i9i.smethod_1(vilSnlZy2, 48316))
					{
						throw new Exception(FFXb5i9i.smethod_0("Variable ", text4, " not found", 52605));
					}
					text4 = vilSnlZy2.h2YblVSv();
				}
				double num2 = SC9OdAxX.XwEtgMIh(text3);
				double num3 = SC9OdAxX.XwEtgMIh(text4);
				double num4 = num2;
				if (ivlgLlId.smethod_3(string_, "*", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(string_, "/", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(string_, "+", bool_0: false, 3221) != 0)
						{
							if (ivlgLlId.smethod_3(string_, "-", bool_0: false, 3221) == 0)
							{
								num4 -= num3;
							}
						}
						else
						{
							num4 += num3;
						}
					}
					else
					{
						num4 /= num3;
					}
				}
				else
				{
					num4 *= num3;
				}
				return num4.ToString(vRvDyS3Z.smethod_0(Class15.kJu0kMKf(45123), 40301));
			}
			default:
				i = 1;
				text = ivlgLlId.zIKBYyAm(zTHSjFkg, 1, 1, 41221);
				if ((U0nDFthS.a7rPdJnI(zTHSjFkg, "+", 3436) > 0) | (U0nDFthS.a7rPdJnI(zTHSjFkg, "-", 3436) > 0))
				{
					while (ivlgLlId.smethod_3(text, "", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(text, "+", bool_0: false, 3221) == 0 || ivlgLlId.smethod_3(text, "-", bool_0: false, 3221) == 0)
						{
							string_ = U0nDFthS.gn4174gi(zTHSjFkg, 0, i - 1, 12858);
							text2 = U0nDFthS.smethod_1(zTHSjFkg, i, 11550);
							zTHSjFkg = U0nDFthS.gn4174gi(zTHSjFkg, i, ivlgLlId.f5lHgZCI(zTHSjFkg, 64616) - i, 12859);
							zTHSjFkg = Kqk9udae.smethod_0(zTHSjFkg, i, UyjBsIjO(text2), 27888);
							zTHSjFkg = U0nDFthS.gn4174gi(zTHSjFkg, 0, i - 1, 12859);
							zTHSjFkg = Kqk9udae.smethod_0(zTHSjFkg, 0, UyjBsIjO(string_), 27888);
						}
						i++;
						text = ivlgLlId.zIKBYyAm(zTHSjFkg, i, 1, 41221);
					}
				}
				else
				{
					while (ivlgLlId.smethod_3(text, "", bool_0: false, 3221) != 0)
					{
						if (ivlgLlId.smethod_3(text, "*", bool_0: false, 3221) == 0 || ivlgLlId.smethod_3(text, "/", bool_0: false, 3221) == 0)
						{
							string_ = U0nDFthS.gn4174gi(zTHSjFkg, 0, i - 1, 12858);
							zTHSjFkg = U0nDFthS.gn4174gi(zTHSjFkg, 0, i - 1, 12859);
							zTHSjFkg = Kqk9udae.smethod_0(zTHSjFkg, 0, UyjBsIjO(string_), 27888);
						}
						i++;
						text = ivlgLlId.zIKBYyAm(zTHSjFkg, i, 1, 41221);
					}
				}
				return UyjBsIjO(zTHSjFkg);
			}
		}
	}
}
