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

internal class dj4Oy23s : Zgdu3ojh
{
	public dj4Oy23s(ref Class2 class2_0)
		: base(ref class2_0)
	{
	}

	public string method_0()
	{
		return FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(ivlgLlId.jnXal2jf(uwtJIsFs(), jPuAefZQ, 28657), NRCPADsl(), jPuAefZQ, 52605), xjWmU1Tm(), jPuAefZQ, 52605), F6P36vFl(), jPuAefZQ, 52605), Tg36HnaV(), jPuAefZQ, 52605), o6b5iIOq(), jPuAefZQ, 52605), WDF4yfB1(), jPuAefZQ, 52605);
	}

	private string NRCPADsl()
	{
		return FFXb5i9i.smethod_0(FFXb5i9i.MhuSoiDL("void IniciMicro(void)", jPuAefZQ, "{", jPuAefZQ, 9407), "}", jPuAefZQ, 52605);
	}

	private string xjWmU1Tm()
	{
		string text = FFXb5i9i.MhuSoiDL("void IniciGrafcet(void)", jPuAefZQ, "{", jPuAefZQ, 9407);
		GAJDqHR0 current2 = default(GAJDqHR0);
		foreach (KeyValuePair<int, sm18FGKs> item in RuM7nYib.E8cNtPVW)
		{
			text = ((!item.Value.jl3opsZZ()) ? FFXb5i9i.Be2UxXd8(new string[6]
			{
				text,
				hevTs6I2,
				"G[",
				item.Value.mGeNVBao,
				"].Forcat = 0;",
				jPuAefZQ
			}, 53581) : FFXb5i9i.Be2UxXd8(new string[6]
			{
				text,
				hevTs6I2,
				"G[",
				item.Value.mGeNVBao,
				"].Forcat = 1;",
				jPuAefZQ
			}, 53581));
			string text2 = "0";
			using (List<GAJDqHR0>.Enumerator enumerator2 = item.Value.PAwen1cW.GetEnumerator())
			{
				int num = 0;
				while (true)
				{
					if (num != 0 && current2.OqG5Jn98() && ((joI8IGp3)current2).tKwsxiGR)
					{
						text2 = FFXb5i9i.smethod_0(text2, " | BIT", RuM7nYib.CfoWAt93[item.Key].ej0keUOA_0[current2].ToString(), 52605);
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
			text = FFXb5i9i.Be2UxXd8(new string[8]
			{
				text,
				hevTs6I2,
				"G[",
				item.Value.mGeNVBao,
				"].EtapaActiva.all = ",
				text2,
				";",
				jPuAefZQ
			}, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[9]
			{
				text,
				hevTs6I2,
				"G[",
				item.Value.mGeNVBao,
				"].FlagIniciEtapa.all = G[",
				item.Value.mGeNVBao,
				"].EtapaActiva.all;",
				jPuAefZQ,
				jPuAefZQ
			}, 53581);
		}
		foreach (KeyValuePair<int, Gx6yJerN> item2 in RuM7nYib.wJaok9e7)
		{
			_ = item2;
		}
		checked
		{
			foreach (KeyValuePair<int, Gx6yJerN> item3 in RuM7nYib.VwNsPtDH)
			{
				text = FFXb5i9i.Be2UxXd8(new string[8]
				{
					text,
					hevTs6I2,
					"TLimitPB[",
					item3.Key.ToString(),
					"].all = ",
					(item3.Value.nv9d2LsG * 1000).ToString(),
					";",
					jPuAefZQ
				}, 53581);
				text = FFXb5i9i.Be2UxXd8(new string[8]
				{
					text,
					hevTs6I2,
					"TLimitPB[",
					(item3.Key + 1).ToString(),
					"].all = ",
					(item3.Value.Bjc6RzC9 * 1000).ToString(),
					";",
					jPuAefZQ
				}, 53581);
			}
			text = ivlgLlId.jnXal2jf(text, jPuAefZQ, 28657);
			text = FFXb5i9i.Be2UxXd8(new string[14]
			{
				text, hevTs6I2, "BitTimerP.all = 0x0000;", jPuAefZQ, hevTs6I2, "BitTimerPB.all = 0x0000;", jPuAefZQ, hevTs6I2, "FlancP.all = 0x0000;", jPuAefZQ,
				hevTs6I2, "FlancB.all = 0x0000;", jPuAefZQ, jPuAefZQ
			}, 53581);
			foreach (KeyValuePair<string, vilSnlZy> item4 in RuM7nYib.qFlLSVvw)
			{
				string text3 = ((ivlgLlId.smethod_3(item4.Value.String_2, "BOOL", bool_0: false, 3221) != 0) ? item4.Value.EqZ3j4Ys() : RuM7nYib.oUJpcypU(item4.Value.EqZ3j4Ys()).ToString());
				text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, item4.Key, " = ", text3, ";", jPuAefZQ }, 53581);
			}
			text = ivlgLlId.jnXal2jf(text, jPuAefZQ, 28657);
			text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "LecturaEntradesFisiques();", jPuAefZQ, 9407);
			return FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
		}
	}

	private string F6P36vFl()
	{
		string text = FFXb5i9i.MhuSoiDL("void GestioTempo()", jPuAefZQ, "{", jPuAefZQ, 9407);
		foreach (KeyValuePair<int, Gx6yJerN> item in RuM7nYib.hokncJ8y)
		{
			text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "/*", jPuAefZQ, 9407);
			text = FFXb5i9i.smethod_0(text, FFXb5i9i.smethod_0(hevTs6I2, " * Condition: ", item.Value.zLvhmgIq, 52605), jPuAefZQ, 52605);
			text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, " */", jPuAefZQ, 9407);
			string text2 = RuM7nYib.ej0keUOA_3[item.Value].ToString();
			string text3 = checked(RuM7nYib.ej0keUOA_3[item.Value] + 1).ToString();
			string text4 = item.Key.ToString();
			text = FFXb5i9i.Be2UxXd8(new string[87]
			{
				text, hevTs6I2, "if (BitTimerPB.bits.bit", text2, ") {", jPuAefZQ, hevTs6I2, hevTs6I2, "if (TimerPB[", text2,
				"].all >= TLimitPB[", text2, "].all) {", jPuAefZQ, hevTs6I2, hevTs6I2, hevTs6I2, "BitTimerPB.bits.bit", text2, " = 0;",
				jPuAefZQ, hevTs6I2, hevTs6I2, "}", jPuAefZQ, hevTs6I2, "} else if (FlancP.bits.bit", text4, ") {", jPuAefZQ,
				hevTs6I2, hevTs6I2, "BitTimerPB.bits.bit", text2, " = 1;", jPuAefZQ, hevTs6I2, hevTs6I2, "TimerPB[", text2,
				"].all = 0x0000;", jPuAefZQ, hevTs6I2, "} else if (BitTimerPB.bits.bit", text3, ") {", jPuAefZQ, hevTs6I2, hevTs6I2, "if (TimerPB[",
				text3, "].all >= TLimitPB[", text3, "].all) {", jPuAefZQ, hevTs6I2, hevTs6I2, hevTs6I2, "BitTimerPB.bits.bit", text3,
				" = 0;", jPuAefZQ, hevTs6I2, hevTs6I2, "}", jPuAefZQ, hevTs6I2, "} else if (FlancB.bits.bit", text4, ") {",
				jPuAefZQ, hevTs6I2, hevTs6I2, "BitTimerPB.bits.bit", text3, " = 1;", jPuAefZQ, hevTs6I2, hevTs6I2, "TimerPB[",
				text3, "].all = 0x0000;", jPuAefZQ, hevTs6I2, "}", jPuAefZQ, jPuAefZQ
			}, 53581);
		}
		return FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
	}

	private string Tg36HnaV()
	{
		string string_ = ivlgLlId.jnXal2jf("void temps_adeq(void)", jPuAefZQ, 28657);
		string_ = FFXb5i9i.smethod_0(string_, "{", jPuAefZQ, 52605);
		string_ = FFXb5i9i.Be2UxXd8(new string[5] { string_, hevTs6I2, "unsigned char nT;", jPuAefZQ, jPuAefZQ }, 53581);
		if (RuM7nYib.int_0 > 0)
		{
			string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "for (nT = 0; nT < nTempP; nT++)", jPuAefZQ, 9407);
			string_ = FFXb5i9i.Be2UxXd8(new string[8]
			{
				string_,
				hevTs6I2,
				hevTs6I2,
				"TimerP[nT].all = TimerP[nT].all + ",
				ERkYWUyo.ToString(),
				";",
				jPuAefZQ,
				jPuAefZQ
			}, 53581);
		}
		if (RuM7nYib.adi8tF4L > 0)
		{
			string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "for (nT = 0; nT < nTempPB; nT++)", jPuAefZQ, 9407);
			string_ = FFXb5i9i.Be2UxXd8(new string[8]
			{
				string_,
				hevTs6I2,
				hevTs6I2,
				"TimerPB[nT].all = TimerPB[nT].all + ",
				ERkYWUyo.ToString(),
				";",
				jPuAefZQ,
				jPuAefZQ
			}, 53581);
		}
		return FFXb5i9i.smethod_0(string_, "}", jPuAefZQ, 52605);
	}

	private string o6b5iIOq()
	{
		return FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(FFXb5i9i.smethod_0(ivlgLlId.jnXal2jf(FFXb5i9i.smethod_0(FFXb5i9i.MhuSoiDL("void AssignaAux(void)", jPuAefZQ, "{", jPuAefZQ, 9407), "    unsigned char nG;", jPuAefZQ, 52605), jPuAefZQ, 28657), "    for (nG = 0; nG < nGRAFCET; nG++)", jPuAefZQ, 52605), "        G[nG].EtapaActivaAux.all = G[nG].EtapaActiva.all;", jPuAefZQ, 52605), "}", jPuAefZQ, 52605);
	}

	public string WDF4yfB1()
	{
		string string_ = FFXb5i9i.MhuSoiDL("unsigned char GrafcetEstable(void)", jPuAefZQ, "{", jPuAefZQ, 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "unsigned char nG;", jPuAefZQ, 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "unsigned char estable;", jPuAefZQ, 9407);
		string_ = FFXb5i9i.smethod_0(string_, hevTs6I2, jPuAefZQ, 52605);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "nG = 0;", jPuAefZQ, 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "estable = 1;", jPuAefZQ, 9407);
		string_ = FFXb5i9i.smethod_0(string_, hevTs6I2, jPuAefZQ, 52605);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "while ((nG < nGRAFCET) && estable)", jPuAefZQ, 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "{", jPuAefZQ, 9407);
		string_ = FFXb5i9i.Be2UxXd8(new string[5] { string_, hevTs6I2, hevTs6I2, "estable = (G[nG].EtapaActiva.all == G[nG].EtapaActivaAux.all);", jPuAefZQ }, 53581);
		string_ = FFXb5i9i.Be2UxXd8(new string[5] { string_, hevTs6I2, hevTs6I2, "nG++;", jPuAefZQ }, 53581);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "}", jPuAefZQ, 9407);
		string_ = FFXb5i9i.MhuSoiDL(string_, hevTs6I2, "return(estable);", jPuAefZQ, 9407);
		return FFXb5i9i.smethod_0(string_, "}", jPuAefZQ, 52605);
	}
}
