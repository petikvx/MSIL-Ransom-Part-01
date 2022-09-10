using System.Drawing;
using System.Runtime.CompilerServices;
using IoSuaiAb;
using TGaER2JO;
using Y7FbhctW;
using ZqaFD1Ap;
using iiraiv39;
using ns2;

namespace geYLBm6w;

internal class HkkwJxeX : kN09K4MB
{
	[AccessedThroughProperty("m_Grafcet")]
	[CompilerGenerated]
	private sm18FGKs MJ7UPlWK;

	protected MxjPN5Gd mxjPN5Gd_0;

	protected StKhY3Gf yqmtEEku;

	protected virtual sm18FGKs l5OXeht8
	{
		[CompilerGenerated]
		get
		{
			return MJ7UPlWK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MJ7UPlWK = value;
		}
	}

	public sm18FGKs j7PaZN1n
	{
		get
		{
			return l5OXeht8;
		}
		set
		{
			l5OXeht8 = value;
		}
	}

	public MxjPN5Gd Dazr1T1M
	{
		get
		{
			return mxjPN5Gd_0;
		}
		set
		{
			mxjPN5Gd_0 = value;
		}
	}

	public StKhY3Gf mGnVdnr3
	{
		get
		{
			return yqmtEEku;
		}
		set
		{
			yqmtEEku = value;
		}
	}

	public HkkwJxeX(ref sm18FGKs dtndNcpQ, MxjPN5Gd oMJ60wqO, ref StKhY3Gf EZyqlGbJ, int GuqUmbTZ, Point mNk5jhDe, Color color_1, Color color_2, Color hDwiLuud, Color SJKcbkvm, Font mkh4Jb56, ref Graphics WiPPTnYh)
		: base(GuqUmbTZ, mNk5jhDe, color_1, color_2, hDwiLuud, SJKcbkvm, mkh4Jb56, WiPPTnYh)
	{
		l5OXeht8 = dtndNcpQ;
		mxjPN5Gd_0 = oMJ60wqO;
		yqmtEEku = EZyqlGbJ;
	}

	public HkkwJxeX()
	{
	}

	public HkkwJxeX qONFLksE()
	{
		sm18FGKs dtndNcpQ = l5OXeht8;
		HkkwJxeX result = default(HkkwJxeX);
		for (int num = 0; num == 0; num = 1)
		{
			MxjPN5Gd oMJ60wqO = mxjPN5Gd_0;
			ref StKhY3Gf eZyqlGbJ = ref yqmtEEku;
			int guqUmbTZ = checked((int)O4s9Dog1.zxrdwZWP((double)JoL4SDi3 / 4.0, 40554));
			Point mNk5jhDe = gnSv1hng;
			Color color_ = s4gcnwXA;
			Color u7V7w5IU = U7V7w5IU;
			Color hDwiLuud = r7fjB6gZ;
			Color sJKcbkvm = color_0;
			Font mkh4Jb = w23W0aTv;
			Graphics WiPPTnYh = null;
			HkkwJxeX hkkwJxeX = new HkkwJxeX(ref dtndNcpQ, oMJ60wqO, ref eZyqlGbJ, guqUmbTZ, mNk5jhDe, color_, u7V7w5IU, hDwiLuud, sJKcbkvm, mkh4Jb, ref WiPPTnYh);
			l5OXeht8 = dtndNcpQ;
			result = hkkwJxeX;
		}
		return result;
	}

	protected override int yxMhuPYn()
	{
		return checked((int)O4s9Dog1.zxrdwZWP((float)ecacupAK * 0.75f, 40554));
	}

	protected override void vmethod_0(Color xwyzKMby, Color R9YrIvWS, Color E4IT882r)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		Pen pen_ = new Pen(r7fjB6gZ);
		int x = gnSv1hng.X;
		checked
		{
			int num = gnSv1hng.Y - (int)O4s9Dog1.zxrdwZWP((double)cPoguDmD / 2.0, 40554);
			SolidBrush brush_ = new SolidBrush(E4IT882r);
			sSR2WoR5.smethod_2(pen_, 1f, 5815);
			if (bool_0)
			{
				sSR2WoR5.CwuuMByw(pen_, xwyzKMby, 58194);
			}
			else
			{
				sSR2WoR5.CwuuMByw(pen_, R9YrIvWS, 58194);
			}
			sSR2WoR5.EvihoKLX(drlfOdj2, pen_, x, num, JoL4SDi3, cPoguDmD, 16142);
			sSR2WoR5.EvihoKLX(drlfOdj2, pen_, x + 4, num + 4, JoL4SDi3 - 8, cPoguDmD - 8, 16142);
			string string_ = l5OXeht8.mGeNVBao;
			switch (mxjPN5Gd_0)
			{
			case MxjPN5Gd.const_0:
			{
				string_ = ivlgLlId.jnXal2jf(string_, "{", 28657);
				bool flag = true;
				foreach (joI8IGp3 item in yqmtEEku)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						string_ = ivlgLlId.jnXal2jf(string_, ",", 28657);
					}
					string_ = ivlgLlId.jnXal2jf(string_, item.NHfrgFk8, 28657);
				}
				string_ = ivlgLlId.jnXal2jf(string_, "}", 28657);
				break;
			}
			case MxjPN5Gd.ySvxzGuq:
				string_ = ivlgLlId.jnXal2jf(string_, "{*}", 28657);
				break;
			case MxjPN5Gd.rx6mMmGy:
				string_ = ivlgLlId.jnXal2jf(string_, "{}", 28657);
				break;
			case MxjPN5Gd.EvlXvzwI:
				string_ = ivlgLlId.jnXal2jf(string_, "{INIT}", 28657);
				break;
			}
			U0nDFthS.EeCKkDfY(drlfOdj2, string_, w23W0aTv, (Brush)(object)brush_, (float)((double)x + (double)JoL4SDi3 / 10.0), (float)((double)num + (double)cPoguDmD / 3.0), 6215);
		}
	}
}
