using System.Collections.Generic;
using ZqaFD1Ap;
using av2p5dFj;
using di1mqJMz;
using geYLBm6w;
using iiraiv39;
using ns2;
using qGIjTe0w;

namespace BZJnSPwx;

internal class y3Lio2Dd : Zgdu3ojh
{
	public y3Lio2Dd(ref Class2 evxXhOA3)
		: base(ref evxXhOA3)
	{
	}

	public string Bb7EmbQI()
	{
		string text = ivlgLlId.jnXal2jf(uwtJIsFs(), jPuAefZQ, 28657);
		text = FFXb5i9i.Be2UxXd8(new string[17]
		{
			text, "void EvolucioGrafcet(void)", jPuAefZQ, "{", jPuAefZQ, hevTs6I2, "unsigned char nG;", jPuAefZQ, jPuAefZQ, hevTs6I2,
			"for (nG = 0; nG < nGRAFCET; nG++)", jPuAefZQ, hevTs6I2, hevTs6I2, "G[nG].Receptivitat.all = 0x0000;", jPuAefZQ, jPuAefZQ
		}, 53581);
		Class12 current2 = default(Class12);
		Class12 current3 = default(Class12);
		foreach (KeyValuePair<int, sm18FGKs> item in RuM7nYib.E8cNtPVW)
		{
			text = FFXb5i9i.Be2UxXd8(new string[16]
			{
				text,
				hevTs6I2,
				"if (!G[",
				item.Value.mGeNVBao,
				"].Forcat)",
				jPuAefZQ,
				hevTs6I2,
				"{",
				jPuAefZQ,
				hevTs6I2,
				hevTs6I2,
				"AvaluaReceptivitats(",
				item.Value.mGeNVBao,
				");",
				jPuAefZQ,
				jPuAefZQ
			}, 53581);
			LQPodRO3 pnFjzbsw = new LQPodRO3();
			GnNqYKdA gnNqYKdA_ = item.Value;
			i5abCRMT(ref gnNqYKdA_, ref pnFjzbsw);
			av2p5dFj.EJ0keUOA<Class12, bool> ej0keUOA_ = new av2p5dFj.EJ0keUOA<Class12, bool>();
			using (List<Class12>.Enumerator enumerator2 = pnFjzbsw.GetEnumerator())
			{
				int num = 0;
				while (true)
				{
					if (num != 0)
					{
						ej0keUOA_.Add(current2, value: false);
					}
					if (enumerator2.MoveNext())
					{
						current2 = enumerator2.Current;
						num = 1;
						continue;
					}
					break;
				}
			}
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "/*", jPuAefZQ }, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, " * Desactivació d'etapes", jPuAefZQ }, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, hevTs6I2, " */", jPuAefZQ, jPuAefZQ }, 53581);
			string string_ = text;
			int key = item.Key;
			gnNqYKdA_ = item.Value;
			text = ivlgLlId.jnXal2jf(string_, VUmwcTlu(key, ref gnNqYKdA_, ref ej0keUOA_, evKREXwk: true), 28657);
			ej0keUOA_.Clear();
			using (List<Class12>.Enumerator enumerator3 = pnFjzbsw.GetEnumerator())
			{
				int num2 = 0;
				while (true)
				{
					if (num2 != 0)
					{
						ej0keUOA_.Add(current3, value: false);
					}
					if (enumerator3.MoveNext())
					{
						current3 = enumerator3.Current;
						num2 = 1;
						continue;
					}
					break;
				}
			}
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "/*", jPuAefZQ }, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, " * Activació d'etapes", jPuAefZQ }, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, hevTs6I2, " */", jPuAefZQ, jPuAefZQ }, 53581);
			string string_2 = text;
			int key2 = item.Key;
			gnNqYKdA_ = item.Value;
			text = ivlgLlId.jnXal2jf(string_2, VUmwcTlu(key2, ref gnNqYKdA_, ref ej0keUOA_, evKREXwk: false), 28657);
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
		}
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "for (nG = 0; nG < nGRAFCET; nG++) {", jPuAefZQ, 9407);
		text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "G[nG].FlagIniciEtapa.all =    G[nG].EtapaActiva.all & ~G[nG].EtapaActivaAux.all;", jPuAefZQ }, 53581);
		text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "G[nG].FlagFiEtapa.all =       ~G[nG].EtapaActiva.all & G[nG].EtapaActivaAux.all;", jPuAefZQ }, 53581);
		text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
		return FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
	}

	private string VUmwcTlu(int S5wPMGIf, ref GnNqYKdA MULOCpPH, ref av2p5dFj.EJ0keUOA<Class12, bool> ej0keUOA_0, bool evKREXwk)
	{
		string text = "";
		StKhY3Gf nqEzkDpk = default(StKhY3Gf);
		for (int num = 0; num == 0; num = 1)
		{
			nqEzkDpk = new StKhY3Gf();
		}
		method_0(ref MULOCpPH, ref nqEzkDpk);
		GAJDqHR0 current = default(GAJDqHR0);
		foreach (GAJDqHR0 item in nqEzkDpk)
		{
			GAJDqHR0 sRSrp15w = item;
			text = FFXb5i9i.Be2UxXd8(new string[8]
			{
				text,
				hevTs6I2,
				hevTs6I2,
				"// Etapa ",
				sRSrp15w.bi9Ci9zp.mGeNVBao,
				":",
				sRSrp15w.NHfrgFk8,
				jPuAefZQ
			}, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[9]
			{
				text,
				hevTs6I2,
				hevTs6I2,
				"if (G[",
				MULOCpPH.L0TyRGNz().mGeNVBao,
				"].EtapaActivaAux.bits.bit",
				RuM7nYib.CfoWAt93[S5wPMGIf].ej0keUOA_0[sRSrp15w].ToString(),
				") {",
				jPuAefZQ
			}, 53581);
			foreach (Class12 item2 in a34chLhV(ref sRSrp15w))
			{
				Class12 qeMZwLA = item2;
				bool flag;
				if (method_1(ref qeMZwLA).Count > 1)
				{
					flag = true;
					text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, "// Sincronisme: transició ", qeMZwLA.String_0, jPuAefZQ }, 53581);
				}
				else
				{
					flag = false;
				}
				if (!ej0keUOA_0[qeMZwLA])
				{
					text = FFXb5i9i.Be2UxXd8(new string[10]
					{
						text,
						hevTs6I2,
						hevTs6I2,
						hevTs6I2,
						"if (G[",
						MULOCpPH.L0TyRGNz().mGeNVBao,
						"].Receptivitat.bits.bit",
						RuM7nYib.CfoWAt93[S5wPMGIf].I6ksM8Iw[qeMZwLA].ToString(),
						") {",
						jPuAefZQ
					}, 53581);
					string text2;
					if (flag)
					{
						text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, hevTs6I2, "if (1", jPuAefZQ }, 53581);
						using (List<GAJDqHR0>.Enumerator enumerator3 = y84m9ZZC(ref qeMZwLA).GetEnumerator())
						{
							int num2 = 0;
							while (true)
							{
								if (num2 != 0 && current != sRSrp15w)
								{
									text = FFXb5i9i.Be2UxXd8(new string[12]
									{
										text,
										hevTs6I2,
										hevTs6I2,
										hevTs6I2,
										hevTs6I2,
										hevTs6I2,
										hevTs6I2,
										"&& G[",
										MULOCpPH.L0TyRGNz().mGeNVBao,
										"].EtapaActivaAux.bits.bit",
										RuM7nYib.CfoWAt93[S5wPMGIf].ej0keUOA_0[current].ToString(),
										jPuAefZQ
									}, 53581);
								}
								if (enumerator3.MoveNext())
								{
									current = enumerator3.Current;
									num2 = 1;
									continue;
								}
								break;
							}
						}
						text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, hevTs6I2, ") {", jPuAefZQ }, 53581);
						text2 = hevTs6I2;
					}
					else
					{
						text2 = "";
					}
					text = ((!evKREXwk) ? ivlgLlId.jnXal2jf(text, isCK8hzF(S5wPMGIf, ref MULOCpPH, ref qeMZwLA, FFXb5i9i.Be2UxXd8(new string[5] { hevTs6I2, hevTs6I2, hevTs6I2, hevTs6I2, text2 }, 53581)), 28657) : ivlgLlId.jnXal2jf(text, f6BxmnQB(S5wPMGIf, ref MULOCpPH, ref qeMZwLA, FFXb5i9i.Be2UxXd8(new string[5] { hevTs6I2, hevTs6I2, hevTs6I2, hevTs6I2, text2 }, 53581)), 28657));
					if (flag)
					{
						text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, hevTs6I2, "}", jPuAefZQ }, 53581);
					}
					text = FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, hevTs6I2, hevTs6I2, "}", jPuAefZQ }, 53581);
					ej0keUOA_0[qeMZwLA] = true;
				}
				else
				{
					text = FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, hevTs6I2, hevTs6I2, "// Codi ja generat abans.", jPuAefZQ }, 53581);
				}
			}
			text = FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
		}
		return text;
	}

	private LQPodRO3 a34chLhV(ref GAJDqHR0 sRSrp15w)
	{
		GnNqYKdA bi9Ci9zp = sRSrp15w.bi9Ci9zp;
		LQPodRO3 lQPodRO = bi9Ci9zp.oYAQhwHM(ref sRSrp15w);
		if (lQPodRO.Count == 0 && ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(bi9Ci9zp, 58039), 54497), "MacroStepBody", bool_0: false, 3221) == 0)
		{
			Z9B67Lte z9B67Lte_ = ((xjacLSP2)bi9Ci9zp).Z9B67Lte_0;
			GAJDqHR0 sRSrp15w2 = z9B67Lte_;
			LQPodRO3 lQPodRO2 = a34chLhV(ref sRSrp15w2);
			z9B67Lte_ = (Z9B67Lte)sRSrp15w2;
			lQPodRO = lQPodRO2;
		}
		return lQPodRO;
	}

	private void method_0(ref GnNqYKdA gnNqYKdA_0, ref StKhY3Gf nqEzkDpk)
	{
		foreach (GAJDqHR0 item in gnNqYKdA_0.PAwen1cW)
		{
			if (item.OqG5Jn98())
			{
				nqEzkDpk.Add(item);
			}
			else if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(item, 58039), 54497), "GraphicalMacroStep", bool_0: false, 3221) == 0)
			{
				GnNqYKdA gnNqYKdA_ = ((Z9B67Lte)item).xn1zY2zE();
				method_0(ref gnNqYKdA_, ref nqEzkDpk);
			}
		}
	}

	private StKhY3Gf method_1(ref Class12 qeMZwLA2)
	{
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		foreach (GAJDqHR0 item in qeMZwLA2.A1I888Ta())
		{
			if (item.OqG5Jn98())
			{
				stKhY3Gf.Add(item);
			}
			else if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(item, 58039), 54497), "GraphicalMacroStep", bool_0: false, 3221) == 0)
			{
				stKhY3Gf.Add(((Z9B67Lte)item).xn1zY2zE().JFU7hdaY());
			}
		}
		return stKhY3Gf;
	}

	private StKhY3Gf y84m9ZZC(ref Class12 g34Ynvbq)
	{
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		GAJDqHR0 current2 = default(GAJDqHR0);
		foreach (GAJDqHR0 item in g34Ynvbq.gNIXMyxN())
		{
			if (item.OqG5Jn98())
			{
				stKhY3Gf.Add(item);
			}
			else
			{
				if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(item, 58039), 54497), "GraphicalMacroStep", bool_0: false, 3221) != 0)
				{
					continue;
				}
				using List<GAJDqHR0>.Enumerator enumerator2 = ((Z9B67Lte)item).xn1zY2zE().PAwen1cW.GetEnumerator();
				int num = 0;
				while (true)
				{
					if (num != 0 && current2.OqG5Jn98() && ((joI8IGp3)current2).tKwsxiGR)
					{
						stKhY3Gf.Add(current2);
					}
					if (enumerator2.MoveNext())
					{
						current2 = enumerator2.Current;
						num = 1;
						continue;
					}
					break;
				}
			}
		}
		return stKhY3Gf;
	}

	private string f6BxmnQB(int KoRH3BiB, ref GnNqYKdA QB0bz3aa, ref Class12 d8R1rcPU, string string_0)
	{
		string text = "";
		using List<GAJDqHR0>.Enumerator enumerator = method_1(ref d8R1rcPU).GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0)
			{
				text = FFXb5i9i.Be2UxXd8(new string[8]
				{
					text,
					string_0,
					"G[",
					QB0bz3aa.L0TyRGNz().mGeNVBao,
					"].EtapaActiva.bits.bit",
					RuM7nYib.CfoWAt93[KoRH3BiB].ej0keUOA_0[current].ToString(),
					" = 0;",
					jPuAefZQ
				}, 53581);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return text;
	}

	private string isCK8hzF(int Ls7Lu0Rc, ref GnNqYKdA WrjewPax, ref Class12 zWFHSSrO, string VPT6qp1V)
	{
		string text = "";
		using List<GAJDqHR0>.Enumerator enumerator = y84m9ZZC(ref zWFHSSrO).GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0)
			{
				text = FFXb5i9i.Be2UxXd8(new string[8]
				{
					text,
					VPT6qp1V,
					"G[",
					WrjewPax.L0TyRGNz().mGeNVBao,
					"].EtapaActiva.bits.bit",
					RuM7nYib.CfoWAt93[Ls7Lu0Rc].ej0keUOA_0[current].ToString(),
					" = 1;",
					jPuAefZQ
				}, 53581);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return text;
	}
}
