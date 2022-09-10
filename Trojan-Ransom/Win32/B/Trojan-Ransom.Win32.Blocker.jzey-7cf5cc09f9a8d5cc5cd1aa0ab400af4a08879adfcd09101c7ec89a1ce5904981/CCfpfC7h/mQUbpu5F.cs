using System.Collections.Generic;
using System.Drawing;
using TGaER2JO;
using Y7FbhctW;
using ZqaFD1Ap;
using geYLBm6w;
using ns2;

namespace CCfpfC7h;

internal class mQUbpu5F : joI8IGp3
{
	private List<Class9> vcc2XGWs;

	public List<Class9> QkKCBsaR => vcc2XGWs;

	public mQUbpu5F(int G9TW2bFD, string negayAXr, string RffBnSqJ, ref GnNqYKdA gnNqYKdA_0, bool w4RdUbJY, bool MoVgRz5I, Point oBxacnCN, Color J9UT4loy, Color TFEtJKwF, Color vgPZXaSt, Color color_1, Font s4uLhPTq, Color ZmmcVBZD, Color color_2, Color hqPGpMiJ, ref Graphics gv0EgLoF, bool moZANFxs, int piwovrAP)
		: base(G9TW2bFD, negayAXr, RffBnSqJ, ref gnNqYKdA_0, w4RdUbJY, MoVgRz5I, oBxacnCN, J9UT4loy, TFEtJKwF, vgPZXaSt, color_1, s4uLhPTq, ZmmcVBZD, color_2, hqPGpMiJ, ref gv0EgLoF, moZANFxs, piwovrAP)
	{
		vcc2XGWs = new List<Class9>();
	}

	public mQUbpu5F()
	{
	}

	public override object eVuQ0d1c(ref GnNqYKdA UbqlhyF9)
	{
		int int_ = m0ULPID4;
		string g1OpDB = qZUre3Ui;
		string qiZ6bUHm = QiZ6bUHm;
		bool l3jCu1B = L3jCu1B2;
		bool mWwfXgZq = MWwfXgZq;
		Point pSQifZCX = mmUz5MyI;
		Color fQngbW = kLg6dMzu;
		Color rOP5H3J = ROP5H3J7;
		Color aSayEgzs = ASayEgzs;
		Color f3z3tXYf = F3z3tXYf;
		Font zZS2CO2e = c5ih69YM;
		Color cX0wWjWX = color_0;
		Color cePHDLLx = mbHeZp84;
		Color n44xT1D = jrTK0eN8;
		Graphics sx1FZdZF = null;
		return new joI8IGp3(int_, g1OpDB, qiZ6bUHm, ref UbqlhyF9, l3jCu1B, mWwfXgZq, pSQifZCX, fQngbW, rOP5H3J, aSayEgzs, f3z3tXYf, zZS2CO2e, cX0wWjWX, cePHDLLx, n44xT1D, ref sx1FZdZF, v7eeHXmS: false, int_0);
	}

	public void nMv9J7R4(ref sm18FGKs UcVxSrcY)
	{
		vcc2XGWs.Add((Class9)UcVxSrcY);
	}

	public override void RoB2rYnJ(bool OmGYauTf, Color phtat0Ol, Color lu72o9Hj, Color XIoEaonJ, Color c0XSrSNE)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		base.RoB2rYnJ(OmGYauTf, phtat0Ol, lu72o9Hj, XIoEaonJ, c0XSrSNE);
		Pen p6wpU22U = new Pen(phtat0Ol);
		if (!aSJdsz18)
		{
			sSR2WoR5.CwuuMByw(p6wpU22U, lu72o9Hj, 58194);
		}
		sSR2WoR5.smethod_2(p6wpU22U, 1f, 5815);
		method_12(ref p6wpU22U, L3jCu1B2);
	}

	protected void method_12(ref Pen p6wpU22U, bool jpLQKBRM)
	{
		sSR2WoR5.smethod_2(p6wpU22U, 1f, 5815);
		checked
		{
			int num = ((!jpLQKBRM) ? ((int)O4s9Dog1.zxrdwZWP((double)int_0 / 2.0, 40554)) : ((int)O4s9Dog1.zxrdwZWP((double)int_0 / 2.0, 40554) - 4));
			sSR2WoR5.EvihoKLX(cNracw0T, p6wpU22U, mmUz5MyI.X - num, mmUz5MyI.Y - (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), mmUz5MyI.X - (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), mmUz5MyI.Y - num, 16143);
			sSR2WoR5.EvihoKLX(cNracw0T, p6wpU22U, mmUz5MyI.X + (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), mmUz5MyI.Y - num, mmUz5MyI.X + num, mmUz5MyI.Y - (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), 16143);
			sSR2WoR5.EvihoKLX(cNracw0T, p6wpU22U, mmUz5MyI.X + num, mmUz5MyI.Y + (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), mmUz5MyI.X + (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), mmUz5MyI.Y + num, 16143);
			sSR2WoR5.EvihoKLX(cNracw0T, p6wpU22U, mmUz5MyI.X - (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), mmUz5MyI.Y + num, mmUz5MyI.X - num, mmUz5MyI.Y + (int)O4s9Dog1.zxrdwZWP((double)int_0 / 5.0, 40554), 16143);
		}
	}
}
