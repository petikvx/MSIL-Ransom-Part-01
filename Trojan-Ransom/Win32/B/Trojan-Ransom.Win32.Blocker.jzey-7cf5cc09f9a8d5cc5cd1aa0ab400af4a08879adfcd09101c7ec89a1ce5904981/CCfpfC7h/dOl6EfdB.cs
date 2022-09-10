using System;
using System.Drawing;
using IoSuaiAb;
using RuJ22SnU;
using TGaER2JO;
using Y7FbhctW;
using di1mqJMz;
using geYLBm6w;
using ns2;
using sReLFYF2;

namespace CCfpfC7h;

internal class dOl6EfdB : joI8IGp3
{
	protected bool En1r5e41;

	private Font UJYt3WUs;

	public bool oid4RlzB
	{
		get
		{
			return En1r5e41;
		}
		set
		{
			En1r5e41 = value;
		}
	}

	public dOl6EfdB(int oNEIzqOu, string zA3Fgtgu, string N93M6VOB, ref GnNqYKdA oCGiwPwC, bool dYToZH85, bool ItPiLvnB, ref bool cdI7TKjs, Point Y2kXKwYJ, Color color_1, Color color_2, Color e55j7pIt, Color EqqXnblb, Font v5ek450k, Color IC6WGHmr, Color csIErECD, Color JXDarwIP, ref Graphics BS61ivO8, bool bool_0, int int_1)
		: base(oNEIzqOu, zA3Fgtgu, N93M6VOB, ref oCGiwPwC, dYToZH85, ItPiLvnB, Y2kXKwYJ, color_1, color_2, e55j7pIt, EqqXnblb, v5ek450k, IC6WGHmr, csIErECD, JXDarwIP, ref BS61ivO8, bool_0, int_1)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		En1r5e41 = cdI7TKjs;
		UJYt3WUs = new Font("Arial", 16f);
	}

	public dOl6EfdB()
	{
	}

	public override void sAB6sPSc(bool TgkOAk9H)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		RoB2rYnJ(TgkOAk9H, ROP5H3J7, ASayEgzs, F3z3tXYf, kLg6dMzu);
		if (PzZJd3kp)
		{
			method_9(xlm9hdPs: false);
		}
		checked
		{
			if (Nr2sp4aM.Nrwpqirh(ytbOZtOk.ArrayList_0, 51636) > 0)
			{
				Pen pen_ = new Pen(ASayEgzs);
				sSR2WoR5.EvihoKLX(cNracw0T, pen_, mmUz5MyI.X + (int)O4s9Dog1.zxrdwZWP((double)int_0 / 2.0, 40554), mmUz5MyI.Y, mmUz5MyI.X + int_0, mmUz5MyI.Y, 16143);
				ytbOZtOk.HXnTE9JT();
			}
		}
	}

	public new virtual void RoB2rYnJ(bool O3hT73Mm, Color fEVNJpp5, Color TqGkLrMV, Color TkPFuivb, Color inEJwtN3)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		try
		{
			if (Nr2sp4aM.BThVOtCE(cNracw0T, 2000, 40203))
			{
				Pen IbRNwu = new Pen(fEVNJpp5);
				if (!aSJdsz18)
				{
					sSR2WoR5.CwuuMByw(IbRNwu, TqGkLrMV, 58194);
				}
				sSR2WoR5.smethod_2(IbRNwu, 1f, 5815);
				fabvwxPp(ref IbRNwu);
				if (L3jCu1B2)
				{
					dkFxKvkB(ref IbRNwu);
				}
				if (O3hT73Mm)
				{
					method_7(ref IbRNwu, fEVNJpp5, TqGkLrMV, TkPFuivb, inEJwtN3);
				}
				QfWtcoWB(ref TqGkLrMV);
				method_8(TqGkLrMV);
				JNrFyrV0(ref IbRNwu);
			}
		}
		catch (Exception exception_)
		{
			m8meAX3U.L6HgMKrR(exception_, 21003);
			for (int num = 0; num == 0; num = 1)
			{
				FFXb5i9i.LfyQ8gZ7(12759);
			}
		}
		finally
		{
			m8meAX3U.smethod_1(cNracw0T, 61095);
		}
	}

	private void QfWtcoWB(ref Color Owdvo6BE)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		Brush brush_ = (Brush)new SolidBrush(Owdvo6BE);
		if (oid4RlzB)
		{
			U0nDFthS.EeCKkDfY(cNracw0T, "*", UJYt3WUs, brush_, checked(mmUz5MyI.X - int_0), (float)((double)mmUz5MyI.Y - 0.2 * (double)int_0), 6215);
		}
	}
}
