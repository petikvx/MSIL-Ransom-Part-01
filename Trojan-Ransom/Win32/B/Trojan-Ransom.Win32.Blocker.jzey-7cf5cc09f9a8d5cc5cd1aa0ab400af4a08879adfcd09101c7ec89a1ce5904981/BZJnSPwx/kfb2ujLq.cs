using System;
using System.Collections.Generic;
using CCfpfC7h;
using ZqaFD1Ap;
using av2p5dFj;
using di1mqJMz;
using geYLBm6w;
using iiraiv39;
using ns2;
using qGIjTe0w;

namespace BZJnSPwx;

internal class kfb2ujLq : Zgdu3ojh
{
	public kfb2ujLq(ref Class2 qS7t3j7q)
		: base(ref qS7t3j7q)
	{
	}

	public string sXz1J9Cy()
	{
		string text = ivlgLlId.jnXal2jf(uwtJIsFs(), jPuAefZQ, 28657);
		List<GAJDqHR0>.Enumerator enumerator2 = default(List<GAJDqHR0>.Enumerator);
		GAJDqHR0 Jc8Pvmgn = default(GAJDqHR0);
		tlWY2AYk current2 = default(tlWY2AYk);
		List<GAJDqHR0>.Enumerator enumerator4 = default(List<GAJDqHR0>.Enumerator);
		GAJDqHR0 Jc8Pvmgn2 = default(GAJDqHR0);
		tlWY2AYk current3 = default(tlWY2AYk);
		for (int num = 0; num == 0; num = 1)
		{
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, "void AccionsPuntuals(void)", jPuAefZQ, "{", jPuAefZQ }, 53581);
			foreach (KeyValuePair<int, sm18FGKs> item in RuM7nYib.E8cNtPVW)
			{
				text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "/*", jPuAefZQ, 9407);
				text = FFXb5i9i.Be2UxXd8(new string[5]
				{
					text,
					hevTs6I2,
					" * Grafcet ",
					item.Value.mGeNVBao,
					jPuAefZQ
				}, 53581);
				text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, " */", jPuAefZQ, jPuAefZQ }, 53581);
				text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "// Accions associades a la desactivació de l'etapa", jPuAefZQ, 9407);
				text = FFXb5i9i.Be2UxXd8(new string[6]
				{
					text,
					hevTs6I2,
					"if (G[",
					item.Key.ToString(),
					"].FlagFiEtapa.all != 0) {",
					jPuAefZQ
				}, 53581);
				try
				{
					sm18FGKs rl2Yj7Ep = item.Value;
					enumerator2 = lb1NK331(ref rl2Yj7Ep, yYtwns2j.Sw5lw6yu).GetEnumerator();
					int num2 = 0;
					while (true)
					{
						if (num2 != 0)
						{
							text = FFXb5i9i.Be2UxXd8(new string[9]
							{
								text,
								hevTs6I2,
								hevTs6I2,
								"if (G[",
								item.Key.ToString(),
								"].FlagFiEtapa.bits.bit",
								RuM7nYib.CfoWAt93[item.Key].ej0keUOA_0[Jc8Pvmgn].ToString(),
								") {",
								jPuAefZQ
							}, 53581);
							using (List<tlWY2AYk>.Enumerator enumerator3 = DbjZxT24(ref Jc8Pvmgn, yYtwns2j.Sw5lw6yu).GetEnumerator())
							{
								int num3 = 0;
								while (true)
								{
									if (num3 != 0)
									{
										text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, current2.BzrTEiuM, ";", jPuAefZQ }, 53581);
									}
									if (enumerator3.MoveNext())
									{
										current2 = enumerator3.Current;
										num3 = 1;
										continue;
									}
									break;
								}
							}
							text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "}", jPuAefZQ }, 53581);
						}
						if (enumerator2.MoveNext())
						{
							Jc8Pvmgn = enumerator2.Current;
							num2 = 1;
							continue;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
				}
				text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
				text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "// Accions associades a l'activació de l'etapa", jPuAefZQ, 9407);
				text = FFXb5i9i.Be2UxXd8(new string[6]
				{
					text,
					hevTs6I2,
					"if (G[",
					item.Key.ToString(),
					"].FlagIniciEtapa.all != 0) {",
					jPuAefZQ
				}, 53581);
				try
				{
					sm18FGKs rl2Yj7Ep = item.Value;
					enumerator4 = lb1NK331(ref rl2Yj7Ep, yYtwns2j.v7905RZc).GetEnumerator();
					int num4 = 0;
					while (true)
					{
						if (num4 != 0)
						{
							text = FFXb5i9i.Be2UxXd8(new string[9]
							{
								text,
								hevTs6I2,
								hevTs6I2,
								"if (G[",
								item.Key.ToString(),
								"].FlagIniciEtapa.bits.bit",
								RuM7nYib.CfoWAt93[item.Key].ej0keUOA_0[Jc8Pvmgn2].ToString(),
								") {",
								jPuAefZQ
							}, 53581);
							using (List<tlWY2AYk>.Enumerator enumerator5 = DbjZxT24(ref Jc8Pvmgn2, yYtwns2j.v7905RZc).GetEnumerator())
							{
								int num5 = 0;
								while (true)
								{
									if (num5 != 0)
									{
										text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, current3.BzrTEiuM, ";", jPuAefZQ }, 53581);
									}
									if (enumerator5.MoveNext())
									{
										current3 = enumerator5.Current;
										num5 = 1;
										continue;
									}
									break;
								}
							}
							text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "}", jPuAefZQ }, 53581);
						}
						if (enumerator4.MoveNext())
						{
							Jc8Pvmgn2 = enumerator4.Current;
							num4 = 1;
							continue;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator4).Dispose();
				}
				text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
			}
			text = FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
		}
		return text;
	}

	private StKhY3Gf lb1NK331(ref sm18FGKs rl2Yj7Ep, yYtwns2j yYtwns2j_0)
	{
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		using List<GAJDqHR0>.Enumerator enumerator = rl2Yj7Ep.PAwen1cW.GetEnumerator();
		int num = 0;
		GAJDqHR0 Jc8Pvmgn = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && DbjZxT24(ref Jc8Pvmgn, yYtwns2j_0).Count > 0)
			{
				stKhY3Gf.Add(Jc8Pvmgn);
			}
			if (enumerator.MoveNext())
			{
				Jc8Pvmgn = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return stKhY3Gf;
	}

	private List<tlWY2AYk> DbjZxT24(ref GAJDqHR0 Jc8Pvmgn, yYtwns2j O52Hh86l)
	{
		List<tlWY2AYk> list = new List<tlWY2AYk>();
		list.AddRange(Jc8Pvmgn.gYQRshmY(O52Hh86l));
		if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(Jc8Pvmgn, 58039), 54497), "GraphicalEnclosingStep", bool_0: false, 3221) == 0)
		{
			switch (O52Hh86l)
			{
			case yYtwns2j.Sw5lw6yu:
			{
				foreach (Class9 item2 in ((mQUbpu5F)Jc8Pvmgn).QkKCBsaR)
				{
					string qxDhzuHz = FFXb5i9i.Be2UxXd8(new string[5] { "G[", item2.mGeNVBao, "].FlagFiEtapa.all = G[", item2.mGeNVBao, "].EtapaActivaAux.all" }, 53581);
					vilSnlZy EbH0gwzm = null;
					tlWY2AYk item = new tlWY2AYk(yXGcq0sI.JlGbI90G, ref EbH0gwzm, null, qxDhzuHz, yYtwns2j.v7905RZc);
					list.Add(item);
					qxDhzuHz = FFXb5i9i.smethod_0("G[", item2.mGeNVBao, "].EtapaActiva.all = 0x0000", 52605);
					EbH0gwzm = null;
					item = new tlWY2AYk(yXGcq0sI.JlGbI90G, ref EbH0gwzm, null, qxDhzuHz, yYtwns2j.v7905RZc);
					list.Add(item);
					qxDhzuHz = FFXb5i9i.smethod_0("G[", item2.mGeNVBao, "].Forcat = 1", 52605);
					EbH0gwzm = null;
					item = new tlWY2AYk(yXGcq0sI.JlGbI90G, ref EbH0gwzm, null, qxDhzuHz, yYtwns2j.v7905RZc);
					list.Add(item);
				}
				return list;
			}
			case yYtwns2j.v7905RZc:
			{
				foreach (Class9 item3 in ((mQUbpu5F)Jc8Pvmgn).QkKCBsaR)
				{
					string qxDhzuHz = FFXb5i9i.MhuSoiDL("G[", item3.mGeNVBao, "].EtapaActiva.all = ENC_INI_", item3.mGeNVBao, 9407);
					vilSnlZy EbH0gwzm = null;
					tlWY2AYk item = new tlWY2AYk(yXGcq0sI.JlGbI90G, ref EbH0gwzm, null, qxDhzuHz, yYtwns2j.v7905RZc);
					list.Add(item);
					qxDhzuHz = FFXb5i9i.Be2UxXd8(new string[5] { "G[", item3.mGeNVBao, "].FlagIniciEtapa.all = G[", item3.mGeNVBao, "].EtapaActiva.all" }, 53581);
					EbH0gwzm = null;
					item = new tlWY2AYk(yXGcq0sI.JlGbI90G, ref EbH0gwzm, null, qxDhzuHz, yYtwns2j.v7905RZc);
					list.Add(item);
					qxDhzuHz = FFXb5i9i.smethod_0("G[", item3.mGeNVBao, "].Forcat = 0", 52605);
					EbH0gwzm = null;
					item = new tlWY2AYk(yXGcq0sI.JlGbI90G, ref EbH0gwzm, null, qxDhzuHz, yYtwns2j.v7905RZc);
					list.Add(item);
				}
				return list;
			}
			}
		}
		return list;
	}
}
