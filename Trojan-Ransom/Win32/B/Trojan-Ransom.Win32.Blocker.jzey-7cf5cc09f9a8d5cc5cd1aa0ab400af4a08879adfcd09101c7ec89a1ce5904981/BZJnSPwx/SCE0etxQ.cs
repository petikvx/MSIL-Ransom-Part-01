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

internal class SCE0etxQ : Zgdu3ojh
{
	public SCE0etxQ(ref Class2 b5VEODfI)
		: base(ref b5VEODfI)
	{
	}

	public string mgSgP9Bs()
	{
		string text = ivlgLlId.jnXal2jf(uwtJIsFs(), jPuAefZQ, 28657);
		text = FFXb5i9i.Be2UxXd8(new string[10] { text, "void AccionsContinues(void)", jPuAefZQ, "{", jPuAefZQ, hevTs6I2, "unsigned char nG;", jPuAefZQ, hevTs6I2, jPuAefZQ }, 53581);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "/*", jPuAefZQ, 9407);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, " * All grafcets are unforced, but the enclosed ones", jPuAefZQ, 9407);
		text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, " */", jPuAefZQ, jPuAefZQ }, 53581);
		text = FFXb5i9i.Be2UxXd8(new string[9] { text, hevTs6I2, "for (nG = 0; nG < nGRAFCET; nG++)", jPuAefZQ, hevTs6I2, hevTs6I2, "G[nG].Forcat = 0;", jPuAefZQ, jPuAefZQ }, 53581);
		using (Dictionary<int, sm18FGKs>.Enumerator enumerator = RuM7nYib.E8cNtPVW.GetEnumerator())
		{
			int num = 0;
			KeyValuePair<int, sm18FGKs> current = default(KeyValuePair<int, sm18FGKs>);
			while (true)
			{
				if (num != 0 && current.Value.jl3opsZZ())
				{
					text = FFXb5i9i.Be2UxXd8(new string[6]
					{
						text,
						hevTs6I2,
						"G[",
						current.Value.mGeNVBao,
						"].Forcat = 1;",
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
		}
		text = ivlgLlId.jnXal2jf(text, jPuAefZQ, 28657);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "/*", jPuAefZQ, 9407);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, " * For all steps, execute associated forcing orders", jPuAefZQ, 9407);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, " *  and grafcet forcing", jPuAefZQ, 9407);
		text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, " */", jPuAefZQ, jPuAefZQ }, 53581);
		using (Dictionary<int, sm18FGKs>.Enumerator enumerator5 = RuM7nYib.E8cNtPVW.GetEnumerator())
		{
			int num2 = 0;
			KeyValuePair<int, sm18FGKs> current2 = default(KeyValuePair<int, sm18FGKs>);
			GAJDqHR0 current3 = default(GAJDqHR0);
			Class9 current4 = default(Class9);
			while (true)
			{
				if (num2 != 0)
				{
					text = FFXb5i9i.Be2UxXd8(new string[6]
					{
						text,
						hevTs6I2,
						"// Grafcet ",
						current2.Value.mGeNVBao,
						jPuAefZQ,
						jPuAefZQ
					}, 53581);
					using List<GAJDqHR0>.Enumerator enumerator4 = current2.Value.PAwen1cW.GetEnumerator();
					int num3 = 0;
					while (true)
					{
						if (num3 != 0)
						{
							if (current3.OqG5Jn98() && ((joI8IGp3)current3).dQ2rQ2ve().Count > 0)
							{
								text = FFXb5i9i.Be2UxXd8(new string[8]
								{
									text,
									hevTs6I2,
									"if (G[",
									current2.Value.mGeNVBao,
									"].EtapaActiva.bits.bit",
									RuM7nYib.CfoWAt93[current2.Key].ej0keUOA_0[current3].ToString(),
									") {",
									jPuAefZQ
								}, 53581);
								foreach (HkkwJxeX item in ((joI8IGp3)current3).dQ2rQ2ve())
								{
									HkkwJxeX emKu0wa = item;
									text = FFXb5i9i.Be2UxXd8(new string[7]
									{
										text,
										hevTs6I2,
										hevTs6I2,
										"G[",
										emKu0wa.j7PaZN1n.mGeNVBao,
										"].Forcat = 1;",
										jPuAefZQ
									}, 53581);
									text = ivlgLlId.jnXal2jf(text, VdGHWlZr(ivlgLlId.jnXal2jf(hevTs6I2, hevTs6I2, 28657), ref emKu0wa), 28657);
								}
								text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
							}
							if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(current3, 58039), 54497), "GraphicalEnclosingStep", bool_0: false, 3221) == 0)
							{
								text = FFXb5i9i.Be2UxXd8(new string[8]
								{
									text,
									hevTs6I2,
									"if (G[",
									current2.Value.mGeNVBao,
									"].EtapaActiva.bits.bit",
									RuM7nYib.CfoWAt93[current2.Key].ej0keUOA_0[current3].ToString(),
									") {",
									jPuAefZQ
								}, 53581);
								using (List<Class9>.Enumerator enumerator3 = ((mQUbpu5F)current3).QkKCBsaR.GetEnumerator())
								{
									int num4 = 0;
									while (true)
									{
										if (num4 != 0)
										{
											text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, "G[", current4.mGeNVBao, "].Forcat = 0;", jPuAefZQ }, 53581);
										}
										if (enumerator3.MoveNext())
										{
											current4 = enumerator3.Current;
											num4 = 1;
											continue;
										}
										break;
									}
								}
								text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
							}
						}
						if (enumerator4.MoveNext())
						{
							current3 = enumerator4.Current;
							num3 = 1;
							continue;
						}
						break;
					}
				}
				if (enumerator5.MoveNext())
				{
					current2 = enumerator5.Current;
					num2 = 1;
					continue;
				}
				break;
			}
		}
		text = ivlgLlId.jnXal2jf(text, jPuAefZQ, 28657);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "/*", jPuAefZQ, 9407);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, " * For all steps, execute associated continous actions", jPuAefZQ, 9407);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, " */", jPuAefZQ, 9407);
		text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "SortidaDig.all = 0x0000;", jPuAefZQ, 9407);
		GAJDqHR0 current6 = default(GAJDqHR0);
		tlWY2AYk tlWY2AYk_ = default(tlWY2AYk);
		foreach (KeyValuePair<int, sm18FGKs> item2 in RuM7nYib.E8cNtPVW)
		{
			using List<GAJDqHR0>.Enumerator enumerator8 = item2.Value.PAwen1cW.GetEnumerator();
			int num5 = 0;
			while (true)
			{
				if (num5 != 0 && current6.OqG5Jn98() && ((joI8IGp3)current6).d0fds6sf(yXGcq0sI.const_0).Count > 0)
				{
					text = FFXb5i9i.Be2UxXd8(new string[8]
					{
						text,
						hevTs6I2,
						"if (G[",
						item2.Value.mGeNVBao,
						"].EtapaActiva.bits.bit",
						RuM7nYib.CfoWAt93[item2.Key].ej0keUOA_0[current6].ToString(),
						") {",
						jPuAefZQ
					}, 53581);
					using (List<tlWY2AYk>.Enumerator enumerator7 = ((joI8IGp3)current6).d0fds6sf(yXGcq0sI.const_0).GetEnumerator())
					{
						int num6 = 0;
						while (true)
						{
							if (num6 != 0)
							{
								text = ivlgLlId.jnXal2jf(text, u4CvepRy(item2.Key, ref tlWY2AYk_), 28657);
							}
							if (enumerator7.MoveNext())
							{
								tlWY2AYk_ = enumerator7.Current;
								num6 = 1;
								continue;
							}
							break;
						}
					}
					text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, "}", jPuAefZQ, jPuAefZQ }, 53581);
				}
				if (enumerator8.MoveNext())
				{
					current6 = enumerator8.Current;
					num5 = 1;
					continue;
				}
				break;
			}
		}
		text = ivlgLlId.jnXal2jf(text, jPuAefZQ, 28657);
		return FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
	}

	private string u4CvepRy(int TkCJymP0, ref tlWY2AYk tlWY2AYk_0)
	{
		string text = "";
		string text2 = "";
		bool flag;
		if (flag = ivlgLlId.smethod_3(tlWY2AYk_0.iQmyfBoG.zLvhmgIq, "true", bool_0: false, 3221) != 0)
		{
			string string_ = text;
			string arNlePjH = ivlgLlId.jnXal2jf(hevTs6I2, hevTs6I2, 28657);
			tlWY2AYk tlWY2AYk;
			VZxzVnkV KWjlMlS = (tlWY2AYk = tlWY2AYk_0).iQmyfBoG;
			string string_2 = xDdloI5s(arNlePjH, TkCJymP0, ref KWjlMlS);
			tlWY2AYk.iQmyfBoG = KWjlMlS;
			text = ivlgLlId.jnXal2jf(string_, string_2, 28657);
			text2 = hevTs6I2;
		}
		text = FFXb5i9i.Be2UxXd8(new string[9]
		{
			text,
			text2,
			hevTs6I2,
			hevTs6I2,
			"SortidaDig.bits.bit",
			RuM7nYib.ej0keUOA_1[(cXJ3GNUP)tlWY2AYk_0.DxitHPne].ToString(),
			" = 1; // ",
			tlWY2AYk_0.DxitHPne.PYBbtbg6,
			jPuAefZQ
		}, 53581);
		if (flag)
		{
			text = FFXb5i9i.Be2UxXd8(new string[5] { text, hevTs6I2, hevTs6I2, "}", jPuAefZQ }, 53581);
		}
		return text;
	}

	private string VdGHWlZr(string IKBMW7UL, ref HkkwJxeX emKu0wa0)
	{
		string text = "";
		switch (emKu0wa0.Dazr1T1M)
		{
		case MxjPN5Gd.const_0:
		{
			text = FFXb5i9i.MhuSoiDL(text, "G[", emKu0wa0.j7PaZN1n.mGeNVBao, "].EtapaActiva.all = (", 9407);
			bool flag2 = true;
			foreach (joI8IGp3 item in emKu0wa0.mGnVdnr3)
			{
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					text = ivlgLlId.jnXal2jf(text, " | ", 28657);
				}
				text = FFXb5i9i.smethod_0(text, "BIT", RuM7nYib.CfoWAt93[RuM7nYib.ej0keUOA_0[emKu0wa0.j7PaZN1n]].ej0keUOA_0[item].ToString(), 52605);
			}
			text = FFXb5i9i.smethod_0(text, ");", jPuAefZQ, 52605);
			break;
		}
		case MxjPN5Gd.rx6mMmGy:
			text = FFXb5i9i.Be2UxXd8(new string[5]
			{
				text,
				"G[",
				emKu0wa0.j7PaZN1n.mGeNVBao,
				"].EtapaActiva.all = 0;",
				jPuAefZQ
			}, 53581);
			break;
		case MxjPN5Gd.EvlXvzwI:
		{
			text = FFXb5i9i.MhuSoiDL(text, "G[", emKu0wa0.j7PaZN1n.mGeNVBao, "].EtapaActiva.all = (", 9407);
			bool flag = true;
			foreach (joI8IGp3 item2 in emKu0wa0.j7PaZN1n.jrb5S1G6())
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					text = ivlgLlId.jnXal2jf(text, " | ", 28657);
				}
				text = FFXb5i9i.smethod_0(text, "BIT", RuM7nYib.CfoWAt93[RuM7nYib.ej0keUOA_0[emKu0wa0.j7PaZN1n]].ej0keUOA_0[item2].ToString(), 52605);
			}
			text = FFXb5i9i.smethod_0(text, ");", jPuAefZQ, 52605);
			break;
		}
		}
		return text;
	}
}
