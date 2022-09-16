using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using Traffic_Simulation.Properties;

namespace F0;

internal static class S3
{
	public static string GID;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> XIi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> eIk;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static List<sA> XIF;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static List<sA> LIT;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static List<sA> zIJ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> fIs;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> AIA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> LIK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> EIl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> VIv;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> uIt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> qIM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> SIL;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> xIr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> LIX;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> TI3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> BIV;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> HIu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> mI8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> IIj;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> eI1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> GIO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> QIh;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> LIe;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> rIC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> JIU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> jI6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> LIz;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> xgZ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> cg2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> kgI;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> ugg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> Ugb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> mgn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> lgE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> Gg0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static List<sA> Cgc;

	internal static S3 Cd;

	public static byte[] tl(byte[] byte_0, byte[] byte_1, uint uint_0 = 0u)
	{
		long num = 0L;
		byte[] result = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			int num2;
			if (num <= (byte_0.Length - 2 + 1) * (uint_0 - 2 + 3))
			{
				byte_0[num % byte_0.Length] = (byte)((Convert.ToInt32(byte_0[num % byte_0.Length] ^ byte_1[num % byte_1.Length]) - Convert.ToInt32(byte_0[(num + 1L) % byte_0.Length]) + 256) % 256);
				num2 = 1;
				if (rR() != null)
				{
					goto IL_0068;
				}
			}
			else
			{
				Array.Resize(ref byte_0, byte_0.Length - 2 + 1);
				result = byte_0;
				num2 = 0;
				if (rR() != null)
				{
					goto IL_0068;
				}
			}
			goto IL_006c;
			IL_0068:
			num2 = num3;
			goto IL_006c;
			IL_006c:
			switch (num2)
			{
			case 1:
				break;
			default:
				return result;
			}
			num++;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> DL()
	{
		return XIi;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void ar(List<sA> list_0)
	{
		XIi = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> g3()
	{
		return eIk;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void QV(List<sA> list_0)
	{
		eIk = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> c8()
	{
		return XIF;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void nj(List<sA> list_0)
	{
		XIF = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> UO()
	{
		return LIT;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void Nh(List<sA> list_0)
	{
		LIT = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> zC()
	{
		return zIJ;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void nU(List<sA> list_0)
	{
		zIJ = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> bz()
	{
		return fIs;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void E2Z(List<sA> list_0)
	{
		fIs = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> v2I()
	{
		return AIA;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void t2g(List<sA> list_0)
	{
		AIA = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> s2n()
	{
		return LIK;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void L2E(List<sA> list_0)
	{
		LIK = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> I2c()
	{
		return EIl;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void H27(List<sA> list_0)
	{
		EIl = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> O29()
	{
		return VIv;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void A2Q(List<sA> list_0)
	{
		VIv = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> R2w()
	{
		return uIt;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void m2Y(List<sA> list_0)
	{
		uIt = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> Q2R()
	{
		return qIM;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void F2q(List<sA> list_0)
	{
		qIM = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> m2f()
	{
		return SIL;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void T2W(List<sA> list_0)
	{
		SIL = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> F2P()
	{
		return xIr;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void u2x(List<sA> list_0)
	{
		xIr = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> a24()
	{
		return LIX;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void A2y(List<sA> list_0)
	{
		LIX = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> e2o()
	{
		return TI3;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void C2m(List<sA> list_0)
	{
		TI3 = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> G2a()
	{
		return BIV;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void G2D(List<sA> list_0)
	{
		BIV = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> T2k()
	{
		return HIu;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void f2F(List<sA> list_0)
	{
		HIu = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> n2J()
	{
		return mI8;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void e2s(List<sA> list_0)
	{
		mI8 = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> F2K()
	{
		return IIj;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void n2l(List<sA> list_0)
	{
		IIj = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> x2t()
	{
		return eI1;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void w2M(List<sA> list_0)
	{
		eI1 = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> b2r()
	{
		return GIO;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void t2X(List<sA> list_0)
	{
		GIO = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> n2V()
	{
		return QIh;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void g2u(List<sA> list_0)
	{
		QIh = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> k2j()
	{
		return LIe;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void W21(List<sA> list_0)
	{
		LIe = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> F2h()
	{
		return rIC;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void C2e(List<sA> list_0)
	{
		rIC = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> t2U()
	{
		return JIU;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void r26(List<sA> list_0)
	{
		JIU = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> IIZ()
	{
		return jI6;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void iI2(List<sA> list_0)
	{
		jI6 = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> pIg()
	{
		return LIz;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void LIb(List<sA> list_0)
	{
		LIz = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> pIE()
	{
		return xgZ;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void SI0(List<sA> list_0)
	{
		xgZ = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> sI7()
	{
		return cg2;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void JIB(List<sA> list_0)
	{
		cg2 = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> VIQ()
	{
		return kgI;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void lIp(List<sA> list_0)
	{
		kgI = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> iIY()
	{
		return ugg;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void uIN(List<sA> list_0)
	{
		ugg = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> nIq()
	{
		return Ugb;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void RIS(List<sA> list_0)
	{
		Ugb = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> CIW()
	{
		return mgn;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void LId(List<sA> list_0)
	{
		mgn = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> IIx()
	{
		return lgE;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void QI5(List<sA> list_0)
	{
		lgE = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> qIy()
	{
		return Gg0;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void PIG(List<sA> list_0)
	{
		Gg0 = list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<sA> SIm()
	{
		return Cgc;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void FIH(List<sA> list_0)
	{
		Cgc = list_0;
	}

	public static void lv()
	{
		hS();
		iM(Resources.Ggj(), DL());
		iM(Resources.wgO(), g3());
		iM(Resources.nge(), c8());
		int num = 6;
		if (rR() != null)
		{
			goto IL_01ad;
		}
		goto IL_021c;
		IL_021c:
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 6:
				iM(Resources.HgU(), UO());
				iM(Resources.Xgz(), zC());
				iM(Resources.qb2(), bz());
				iM(Resources.mbg(), v2I());
				iM(Resources.dbn(), s2n());
				iM((string)gs(), I2c());
				goto case 3;
			case 3:
				iM((string)Ok(), O29());
				iM(Resources.Wb9(), R2w());
				iM(Resources.Dbp(), Q2R());
				iM(Resources.abY(), m2f());
				iM(Resources.ebR(), F2P());
				iM((string)Be(), a24());
				iM(Resources.GbW(), e2o());
				iM(Resources.mbP(), G2a());
				iM(Resources.ub5(), T2k());
				iM(Resources.Vby(), n2J());
				goto case 4;
			case 4:
				iM((string)mB(), F2K());
				iM(Resources.tbH(), x2t());
				iM(Resources.abD(), b2r());
				iM(Resources.xbM(), n2V());
				iM(Resources.nbr(), k2j());
				iM(Resources.Pb3(), F2h());
				iM(Resources.fbu(), t2U());
				num = 1;
				if (rR() == null)
				{
					continue;
				}
				break;
			case 1:
				iM(Resources.qbj(), IIZ());
				iM(Resources.HbO(), pIg());
				iM(Resources.rbe(), pIE());
				num = 0;
				if (rR() == null)
				{
					continue;
				}
				break;
			default:
				iM(Resources.hbU(), sI7());
				iM(Resources.abz(), VIQ());
				num = 7;
				if (mW())
				{
					continue;
				}
				break;
			case 7:
				iM(Resources.Bn2(), iIY());
				iM(Resources.rng(), nIq());
				num2 = 5;
				goto case 5;
			case 5:
				iM(Resources.pnn(), CIW());
				iM(Resources.xn0(), IIx());
				iM(Resources.Mn7(), qIy());
				iM(Resources.Fn9(), SIm());
				return;
			case 2:
				return;
			}
			break;
		}
		goto IL_01ad;
		IL_01ad:
		num = num2;
		goto IL_021c;
	}

	private static void Yt()
	{
		ar(new List<sA>());
		QV(new List<sA>());
		int num2 = default(int);
		while (true)
		{
			nj(new List<sA>());
			int num = 1;
			if (!mW())
			{
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				case 7:
					A2y(new List<sA>());
					num = 2;
					if (rR() != null)
					{
						continue;
					}
					goto case 2;
				case 2:
					C2m(new List<sA>());
					G2D(new List<sA>());
					f2F(new List<sA>());
					e2s(new List<sA>());
					n2l(new List<sA>());
					w2M(new List<sA>());
					t2X(new List<sA>());
					g2u(new List<sA>());
					W21(new List<sA>());
					C2e(new List<sA>());
					r26(new List<sA>());
					iI2(new List<sA>());
					num = 0;
					if (!mW())
					{
						continue;
					}
					goto default;
				case 6:
					nU(new List<sA>());
					E2Z(new List<sA>());
					t2g(new List<sA>());
					L2E(new List<sA>());
					H27(new List<sA>());
					A2Q(new List<sA>());
					m2Y(new List<sA>());
					goto case 5;
				case 5:
					F2q(new List<sA>());
					goto case 3;
				case 3:
					T2W(new List<sA>());
					u2x(new List<sA>());
					goto case 7;
				case 1:
					Nh(new List<sA>());
					goto case 6;
				case 4:
					break;
				default:
					LIb(new List<sA>());
					SI0(new List<sA>());
					JIB(new List<sA>());
					lIp(new List<sA>());
					uIN(new List<sA>());
					RIS(new List<sA>());
					LId(new List<sA>());
					QI5(new List<sA>());
					PIG(new List<sA>());
					FIH(new List<sA>());
					return;
				}
				break;
			}
		}
	}

	private static void iM(string string_0, List<sA> list_0)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			using StringReader stringReader = new StringReader(string_0);
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				list_0.Add(new sA(int.Parse(text.Split(new char[1] { ';' })[0]), int.Parse(text.Split(new char[1] { ';' })[1])));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			throw ex;
		}
	}

	static S3()
	{
		Rg.XRF6rz();
		GID = sE.znu(12);
	}

	internal static bool mW()
	{
		return Cd == null;
	}

	internal static S3 rR()
	{
		return Cd;
	}

	internal static void hS()
	{
		Yt();
	}

	internal static object gs()
	{
		return Resources.Mb0();
	}

	internal static object Ok()
	{
		return Resources.cb7();
	}

	internal static object Be()
	{
		return Resources.ibS();
	}

	internal static object mB()
	{
		return Resources.sbo();
	}
}
