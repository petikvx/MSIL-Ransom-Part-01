using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CCfpfC7h;
using Microsoft.VisualBasic;
using Y7FbhctW;
using av2p5dFj;
using di1mqJMz;
using iiraiv39;
using l2iEFwW1;
using ns0;
using oWLXhSmh;
using p80hVGtz;
using wMk1FHff;

namespace qGIjTe0w;

[Serializable]
internal class XfdOvtct
{
	public const int Lp9eiwqS = 5;

	public object rXJ2dGmV;

	public string fuBYrNnK;

	public string wGz29HTD;

	[NonSerialized]
	private DataGridView cLjAErA8;

	[AccessedThroughProperty("m_Project")]
	[CompilerGenerated]
	private GEBbAG79 oxxouQmv;

	private string zrn2UfjX;

	private av2p5dFj.EJ0keUOA<int, vilSnlZy> ej0keUOA_0;

	[NonSerialized]
	private List<Class4> list_0;

	private B6EVEXad.Urz7QsVX TsAUgZfF;

	[NonSerialized]
	private m7bmPddy j4tHjRJX;

	private virtual GEBbAG79 GEBbAG79_0
	{
		[CompilerGenerated]
		get
		{
			return oxxouQmv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			GEBbAG79.qCGCr7sz value2 = EOpYmeSA;
			GEBbAG79.axCc2sxk value3 = bVnDwvdL;
			GEBbAG79 gEBbAG = oxxouQmv;
			if (gEBbAG != null)
			{
				gEBbAG.Event_0 -= value2;
				gEBbAG.cnapuNw4 -= value3;
			}
			oxxouQmv = value;
			gEBbAG = oxxouQmv;
			if (gEBbAG != null)
			{
				gEBbAG.Event_0 += value2;
				gEBbAG.cnapuNw4 += value3;
			}
		}
	}

	public XfdOvtct(ref DataGridView sg5CFw6o, ref GEBbAG79 JgkwoZRy, string Obf0MZS2, ref m7bmPddy LFXDDmEG = null)
	{
		cLjAErA8 = sg5CFw6o;
		GEBbAG79_0 = JgkwoZRy;
		zrn2UfjX = Obf0MZS2;
		list_0 = new List<Class4>();
		if (LFXDDmEG == null)
		{
			PTOeUr7o();
		}
		else
		{
			method_0(ref LFXDDmEG);
		}
	}

	public void PTOeUr7o()
	{
		TsAUgZfF = B6EVEXad.Urz7QsVX.SPrF7ERV;
		j4tHjRJX = null;
		CEGuaDDm();
		method_1();
	}

	public void method_0(ref m7bmPddy m7bmPddy_0)
	{
		TsAUgZfF = B6EVEXad.Urz7QsVX.nuAh3Lvc;
		j4tHjRJX = m7bmPddy_0;
		CEGuaDDm();
		method_1();
	}

	public B6EVEXad.Urz7QsVX o2R0ysLm()
	{
		return TsAUgZfF;
	}

	private void CEGuaDDm()
	{
		switch (TsAUgZfF)
		{
		case B6EVEXad.Urz7QsVX.nuAh3Lvc:
			if (!JVngNRMK())
			{
				P4ylgCWg.CVRHEjrU(P4ylgCWg.smethod_2(cLjAErA8, 48428), "CurrentValue", "Current Value", 43399);
				P4ylgCWg.smethod_4(P4ylgCWg.smethod_3(P4ylgCWg.smethod_2(cLjAErA8, 48428), 5, 63477), bool_0: true, 25327);
			}
			break;
		case B6EVEXad.Urz7QsVX.SPrF7ERV:
			if (JVngNRMK())
			{
				P4ylgCWg.nfVtfiey(P4ylgCWg.smethod_2(cLjAErA8, 48428), 5, 10080);
			}
			break;
		}
	}

	public void method_1()
	{
		ghmONLMX();
		using (List<vilSnlZy>.Enumerator enumerator = YohKXxkq("Project").GetEnumerator())
		{
			int num = 0;
			vilSnlZy D5FJOUVp = default(vilSnlZy);
			while (true)
			{
				if (num != 0)
				{
					method_3(ref D5FJOUVp, "Project");
				}
				if (enumerator.MoveNext())
				{
					D5FJOUVp = enumerator.Current;
					num = 1;
					continue;
				}
				break;
			}
		}
		if (ivlgLlId.smethod_3(zrn2UfjX, "Project", bool_0: false, 3221) == 0)
		{
			return;
		}
		using List<vilSnlZy>.Enumerator enumerator2 = YohKXxkq(zrn2UfjX).GetEnumerator();
		int num2 = 0;
		vilSnlZy D5FJOUVp2 = default(vilSnlZy);
		while (true)
		{
			if (num2 != 0)
			{
				method_3(ref D5FJOUVp2, zrn2UfjX);
			}
			if (enumerator2.MoveNext())
			{
				D5FJOUVp2 = enumerator2.Current;
				num2 = 1;
				continue;
			}
			break;
		}
	}

	public void method_2(ref Form form_0)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		GEBbAG79 aqBwh6MH = GEBbAG79_0;
		int num = 0;
		mjvh6qaQ mjvh6qaQ2 = default(mjvh6qaQ);
		while (true)
		{
			if (num == 0)
			{
				mjvh6qaQ mjvh6qaQ = new mjvh6qaQ(ref aqBwh6MH, zrn2UfjX);
				GEBbAG79_0 = aqBwh6MH;
				mjvh6qaQ2 = mjvh6qaQ;
				goto IL_0096;
			}
			goto IL_0024;
			IL_0024:
			if (!mjvh6qaQ2.Boolean_0)
			{
				break;
			}
			goto IL_0096;
			IL_0096:
			if ((int)P4ylgCWg.PHc303fO((Form)(object)mjvh6qaQ2, (IWin32Window)(object)form_0, 40774) == 1)
			{
				if (!FFXb5i9i.smethod_1(YohKXxkq("All").LEZUQfn3(mjvh6qaQ2.fqzuQgZM), 48316))
				{
					vRvDyS3Z.WaN2uVeZ(FFXb5i9i.smethod_0("Variable ", mjvh6qaQ2.fqzuQgZM, " already exists!", 52605), (MsgBoxStyle)16, null, 34299);
					num = 1;
					continue;
				}
				YohKXxkq(mjvh6qaQ2.rlyfSpAd).iMX8EXQC(mjvh6qaQ2.rlyfSpAd, mjvh6qaQ2.fqzuQgZM, mjvh6qaQ2.yIz2KIaD, "", mjvh6qaQ2.TMbPPFC4, mjvh6qaQ2.yscMQiEa, mjvh6qaQ2.tpkjKE5s_0, mjvh6qaQ2.l7geXAOJ);
			}
			goto IL_0024;
		}
	}

	public void XZ00V54s()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		if (P4ylgCWg.Hf0jDrfN((BaseCollection)(object)P4ylgCWg.sHdXwxpO(cLjAErA8, 23547), 57076) == 0)
		{
			return;
		}
		vilSnlZy IvOOYyaK = ej0keUOA_0[P4ylgCWg.vQ0Q1Oay(P4ylgCWg.P83d5WAN(P4ylgCWg.sHdXwxpO(cLjAErA8, 23547), 0, 64234), 32180)];
		if (FFXb5i9i.smethod_1(IvOOYyaK, 48316))
		{
			return;
		}
		GEBbAG79 jFoblK5h = GEBbAG79_0;
		mjvh6qaQ mjvh6qaQ = new mjvh6qaQ(ref jFoblK5h, ref IvOOYyaK);
		GEBbAG79_0 = jFoblK5h;
		mjvh6qaQ mjvh6qaQ2 = mjvh6qaQ;
		if ((int)P4ylgCWg.G2fW6tnP((Form)(object)mjvh6qaQ2, 8306) != 1)
		{
			return;
		}
		if ((ivlgLlId.smethod_3(IvOOYyaK.PYBbtbg6, mjvh6qaQ2.fqzuQgZM, bool_0: false, 3221) != 0) & !FFXb5i9i.smethod_1(YohKXxkq(mjvh6qaQ2.rlyfSpAd).LEZUQfn3(mjvh6qaQ2.fqzuQgZM), 48316))
		{
			vRvDyS3Z.WaN2uVeZ(FFXb5i9i.smethod_0("Variable ", mjvh6qaQ2.fqzuQgZM, " already exists!", 52605), (MsgBoxStyle)16, null, 34299);
			return;
		}
		string ehtynTEo = IvOOYyaK.ehtynTEo;
		YohKXxkq(mjvh6qaQ2.rlyfSpAd).CnKvSJK9(ref IvOOYyaK, mjvh6qaQ2.rlyfSpAd, mjvh6qaQ2.fqzuQgZM, mjvh6qaQ2.yIz2KIaD, mjvh6qaQ2.yscMQiEa, mjvh6qaQ2.TMbPPFC4, O4s9Dog1.cI1h7tEI((int)mjvh6qaQ2.tpkjKE5s_0, 25972), mjvh6qaQ2.l7geXAOJ);
		if (ivlgLlId.smethod_3(ehtynTEo, IvOOYyaK.ehtynTEo, bool_0: false, 3221) != 0)
		{
			YohKXxkq(IvOOYyaK.ehtynTEo).gXCjBRdJ(ref IvOOYyaK);
			YohKXxkq(ehtynTEo).xt5emxTP(ref IvOOYyaK);
		}
	}

	public void E8SsuIO9()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		if (P4ylgCWg.Hf0jDrfN((BaseCollection)(object)P4ylgCWg.P7MZiVUn(cLjAErA8, 50671), 57076) != 0 && (int)vRvDyS3Z.WaN2uVeZ("Please confirm variable deletion", (MsgBoxStyle)1, null, 34299) != 2)
		{
			vilSnlZy vilSnlZy_ = YohKXxkq(zrn2UfjX).LEZUQfn3(FFXb5i9i.F6ODWxg3(P4ylgCWg.smethod_5(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.spdSZ2Jw(P4ylgCWg.P7MZiVUn(cLjAErA8, 50671), 0, 41861), 59542), 0, 60337), 29342), 22851));
			if (!FFXb5i9i.smethod_1(vilSnlZy_, 48316))
			{
				YohKXxkq(zrn2UfjX).xt5emxTP(ref vilSnlZy_);
			}
		}
	}

	public void FIVQUquV()
	{
		if (P4ylgCWg.Hf0jDrfN((BaseCollection)(object)P4ylgCWg.sHdXwxpO(cLjAErA8, 23547), 57076) == 0)
		{
			return;
		}
		vilSnlZy vxtGfhw = ej0keUOA_0[P4ylgCWg.vQ0Q1Oay(P4ylgCWg.P83d5WAN(P4ylgCWg.sHdXwxpO(cLjAErA8, 23547), 0, 64234), 32180)];
		if (FFXb5i9i.smethod_1(vxtGfhw, 48316))
		{
			return;
		}
		string text;
		if (ivlgLlId.smethod_3(vxtGfhw.String_2, "BOOL", bool_0: false, 3221) == 0)
		{
			vxtGfhw.Ht1EgdTf(FFXb5i9i.nWO7RQjw(vxtGfhw.WCmKoO66(), 22106));
			text = vxtGfhw.h2YblVSv();
		}
		else
		{
			text = D6GpGQoV.smethod_0("Enter new value", "Set variable value", vxtGfhw.h2YblVSv(), -1, -1, 44160);
			if (ivlgLlId.smethod_3(text, "", bool_0: false, 3221) == 0)
			{
				return;
			}
		}
		j4tHjRJX.wQlHDqVw(ref vxtGfhw, text);
	}

	private void ghmONLMX()
	{
		D6GpGQoV.LenX9Auz(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), 4067);
		ej0keUOA_0 = new av2p5dFj.EJ0keUOA<int, vilSnlZy>();
		list_0.Clear();
	}

	private void method_3(ref vilSnlZy D5FJOUVp, string wFdSbZHx)
	{
		int lVraDaVi = D6GpGQoV.VCnCAiyD(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), 62330);
		int num = 0;
		P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), 0, 60337), D5FJOUVp.ehtynTEo, 57383);
		num = 1;
		P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), 1, 60337), D5FJOUVp.PYBbtbg6, 57383);
		u5KDIfFT(ref lVraDaVi, ref D5FJOUVp);
		num = 2;
		P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), 2, 60337), D5FJOUVp.String_2, 57383);
		num = 3;
		P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), 3, 60337), D5FJOUVp.mKYD5QOE.ToString(), 57383);
		num = 4;
		if (D5FJOUVp.ROfx4MMm)
		{
			P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), num, 60337), KcEKvRC1.smethod_0(D5FJOUVp.EqZ3j4Ys()), 57383);
		}
		else
		{
			P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), num, 60337), D5FJOUVp.EqZ3j4Ys(), 57383);
		}
		num = checked(num + 1);
		if (TsAUgZfF == B6EVEXad.Urz7QsVX.nuAh3Lvc)
		{
			P4ylgCWg.PSxjHVmY(P4ylgCWg.smethod_1(P4ylgCWg.PJdX2FWt(P4ylgCWg.e7DGAcD8(P4ylgCWg.u2dqNayc(cLjAErA8, 50450), lVraDaVi, 10836), 59542), num, 60337), D5FJOUVp.h2YblVSv(), 57383);
			mXh7yUL1(lVraDaVi, ref D5FJOUVp);
		}
	}

	private void u5KDIfFT(ref int lVraDaVi, ref vilSnlZy uVcPKK6l)
	{
		ej0keUOA_0.Add(lVraDaVi, uVcPKK6l);
	}

	private void mXh7yUL1(int Cx98CAho, ref vilSnlZy pMoSsLLm)
	{
		Class4 item = new Class4(ref cLjAErA8, Cx98CAho, 5, ref pMoSsLLm);
		for (int num = 0; num == 0; num = 1)
		{
			list_0.Add(item);
		}
	}

	private bool JVngNRMK()
	{
		return D6GpGQoV.iIPH1Gig(cLjAErA8, 36192) > 5;
	}

	private Uj8nVl61 YohKXxkq(string string_0)
	{
		return GEBbAG79_0.Tv8giphj(string_0);
	}

	private void EOpYmeSA()
	{
		if (D6GpGQoV.iIPH1Gig(cLjAErA8, 36192) > 0)
		{
			method_1();
		}
	}

	private void bVnDwvdL()
	{
		if (ivlgLlId.smethod_3(zrn2UfjX, "Project", bool_0: false, 3221) != 0)
		{
			method_1();
		}
	}
}
