using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using RuJ22SnU;
using Y7FbhctW;
using ZqaFD1Ap;
using di1mqJMz;
using iLd730DL;
using iiraiv39;
using ns0;
using p80hVGtz;
using sReLFYF2;

namespace wMk1FHff;

[StandardModule]
internal sealed class SC9OdAxX
{
	public static string pBiUUD7t = Nr2sp4aM.Be12s2SH(O4s9Dog1.BG85lvs2(42744), "cursors", 1009);

	public static string ikhE7NoX = Nr2sp4aM.Be12s2SH(Nr2sp4aM.Be12s2SH(O4s9Dog1.BG85lvs2(42744), "xml", 1009), "TC6_XML_V10.xsd", 1009);

	public static string rWBaUb9n = "+|\"'<>().,:; /\\]^%@-*#?![]~{}";

	[CompilerGenerated]
	[AccessedThroughProperty("ResourceTab")]
	private static oecgZsK4 CaWMJoSE;

	public static object C2qwMLqY = m8meAX3U.bErpAbl3(new object(), 6598);

	public static readonly Font jzYmtNRS = new Font("Arial", 8f);

	public static oecgZsK4 sC25mRbG
	{
		[CompilerGenerated]
		get
		{
			return CaWMJoSE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CaWMJoSE = value;
		}
	} = new oecgZsK4();


	public static void HYRxkTVe()
	{
	}

	public static T smethod_0<T>(bool NRpC3Ivm, T gparam_0, T ScAD9r36)
	{
		if (NRpC3Ivm)
		{
			return gparam_0;
		}
		return ScAD9r36;
	}

	public static bool pRSrLOxY(string tvrB44Ip)
	{
		return Class15.Xcu2ie9g(tvrB44Ip, Class15.ftpBFsac(rWBaUb9n, 19054), 61985) < 0;
	}

	public static Point bWjTgnUm(Rectangle NiyLfbBA)
	{
		return checked(new Point((int)O4s9Dog1.zxrdwZWP((double)NiyLfbBA.Location.X + (double)NiyLfbBA.Size.Width / 2.0, 40554), (int)O4s9Dog1.zxrdwZWP((double)NiyLfbBA.Location.Y + (double)NiyLfbBA.Size.Height / 2.0, 40554)));
	}

	public static Point bwrELiT3(Point FCaDZs20, Size z38OcE22)
	{
		return bWjTgnUm(new Rectangle(FCaDZs20, z38OcE22));
	}

	public static double XwEtgMIh(string TRpxC4ET)
	{
		return Class15.SovO4tjC(TRpxC4ET, vRvDyS3Z.smethod_0(Class15.kJu0kMKf(45123), 40301), 5098);
	}

	public static void smethod_1(string gxbc3Nnx, Graphics upHeDqMS, Color TTJ82unv, BF4Ltdel peLWqnQF, float ajcIAwd6 = 0f, float tS2dnpfB = 0f)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		slKjxehL(gxbc3Nnx, upHeDqMS, (Brush)new SolidBrush(TTJ82unv), peLWqnQF, ajcIAwd6, tS2dnpfB);
	}

	public static void slKjxehL(string aGNP2q77, Graphics y14je3hn, Brush FDEasa7Z, BF4Ltdel Yau4Cw8W, float float_0 = 0f, float LVEmkWno = 0f)
	{
		if (y14je3hn == null || !Nr2sp4aM.BThVOtCE(y14je3hn, 2000, 40203))
		{
			return;
		}
		checked
		{
			try
			{
				Point point = new Point((int)O4s9Dog1.zxrdwZWP((double)Yau4Cw8W.NeYKwVur.X + (double)Yau4Cw8W.lwmr7AQU.Width / 2.0, 40554), (int)O4s9Dog1.zxrdwZWP((double)Yau4Cw8W.NeYKwVur.Y + (double)Yau4Cw8W.lwmr7AQU.Height / 2.0, 40554));
				SizeF size = Class15.HaAQudSW(y14je3hn, aGNP2q77, jzYmtNRS, 17127);
				Point point_ = new Point((int)O4s9Dog1.zxrdwZWP((float)point.X - size.Width / 2f, 40554) + (int)O4s9Dog1.zxrdwZWP(float_0 * size.Width, 40554), (int)O4s9Dog1.zxrdwZWP((float)point.Y - size.Height / 2f, 40554) + (int)O4s9Dog1.zxrdwZWP(LVEmkWno * size.Height, 40554));
				RectangleF rectangleF_ = new RectangleF(Class15.smethod_0(point_, 55206), size);
				rectangleF_.Intersect(new RectangleF(Yau4Cw8W.NeYKwVur.X, Yau4Cw8W.NeYKwVur.Y, Yau4Cw8W.lwmr7AQU.Width, Yau4Cw8W.lwmr7AQU.Height));
				try
				{
					Class15.smethod_1(y14je3hn, aGNP2q77, jzYmtNRS, FDEasa7Z, rectangleF_, 43153);
				}
				catch (Exception exception_)
				{
					m8meAX3U.L6HgMKrR(exception_, 21003);
					for (int num = 0; num == 0; num = 1)
					{
						FFXb5i9i.LfyQ8gZ7(12759);
					}
				}
			}
			finally
			{
				m8meAX3U.smethod_1(y14je3hn, 61095);
			}
		}
	}

	public static bool smethod_2(Rectangle yNQRW2u2, Rectangle S7hMvnDh, ref bool zBowwLE2, ref bool M50fSfmV)
	{
		int num;
		if ((S7hMvnDh.X <= yNQRW2u2.X) | checked(S7hMvnDh.X + S7hMvnDh.Width >= yNQRW2u2.X + yNQRW2u2.Width))
		{
			zBowwLE2 = true;
			num = 0;
			goto IL_0043;
		}
		goto IL_0047;
		IL_0043:
		bool result = default(bool);
		if (num == 0)
		{
			result = true;
			goto IL_0047;
		}
		result = true;
		goto IL_0084;
		IL_0047:
		if ((S7hMvnDh.Y <= yNQRW2u2.Y) | checked(S7hMvnDh.Y + S7hMvnDh.Height >= yNQRW2u2.Y + yNQRW2u2.Height))
		{
			M50fSfmV = true;
			num = 1;
			goto IL_0043;
		}
		goto IL_0084;
		IL_0084:
		return result;
	}

	public static string smethod_3(string rCtdEATG, char KlkYIMtN)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		bool flag = false;
		int i = 0;
		for (int num = ivlgLlId.f5lHgZCI(rCtdEATG, 64616); i < num; i = checked(i + 1))
		{
			char c = Class15.I9IgXm7u(rCtdEATG, i, 26430);
			if (flag)
			{
				if (c != KlkYIMtN)
				{
					flag = false;
					Class15.TSl8DiL7(stringBuilder_, KlkYIMtN, 24433);
					Class15.TSl8DiL7(stringBuilder_, c, 24433);
				}
			}
			else if (c == KlkYIMtN)
			{
				flag = true;
			}
			else
			{
				Class15.TSl8DiL7(stringBuilder_, c, 24433);
			}
		}
		if (flag)
		{
			Class15.TSl8DiL7(stringBuilder_, KlkYIMtN, 24433);
		}
		return Class15.QySGJYLH(stringBuilder_, 32916);
	}

	public static void smethod_4<bjvwUocl>(ref bjvwUocl LmEW1HKn, ref bjvwUocl uF4Uhrnc) where bjvwUocl : class
	{
		bjvwUocl val = LmEW1HKn;
		LmEW1HKn = uF4Uhrnc;
		uF4Uhrnc = val;
	}

	public static void smethod_5<T>(ref T[] sQriVXE2, int BWu2IzvG, int qSFIJCIm) where T : class
	{
		smethod_4(ref sQriVXE2[BWu2IzvG], ref sQriVXE2[qSFIJCIm]);
	}

	public static void ZSrrZ4ge(ref object EsVYUaDw, ref object object_0)
	{
		object object_ = m8meAX3U.bErpAbl3(EsVYUaDw, 6598);
		EsVYUaDw = m8meAX3U.bErpAbl3(object_0, 6598);
		object_0 = m8meAX3U.bErpAbl3(object_, 6598);
	}

	public static void smethod_6(ref object[] Gf3Q74Gl, int Cq3hHKsZ, int FkrLI1D1)
	{
		ZSrrZ4ge(ref Gf3Q74Gl[Cq3hHKsZ], ref Gf3Q74Gl[FkrLI1D1]);
	}
}
