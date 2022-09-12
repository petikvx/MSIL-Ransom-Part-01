using System.Collections.Generic;
using System.Globalization;
using SimpleJSON;

namespace Cytotechnologist;

public class Rules
{
	public int SprintCount { get; private set; }

	public int MaxImpact { get; private set; }

	public Card[] Cards { get; private set; }

	public int InitialResources { get; private set; }

	public int NormalPlanningCount { get; private set; }

	public int NormalPlanningCost { get; private set; }

	public int OverPlanningCost { get; private set; }

	public int SprintsWonWithoutPlanning { get; private set; }

	public float[] RiskChances { get; private set; }

	public bool EconomicsAffectsAll { get; private set; }

	public int StayOnSprintMinDiff { get; private set; }

	public bool OnlyOneWinner { get; private set; }

	private Rules()
	{
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = json["max-impact"].AsInt;
		Rules result = new Rules
		{
			SprintCount = json["sprints"].AsInt,
			MaxImpact = asInt,
			Cards = ParseDeck(json["deck"], asInt),
			InitialResources = json["initial-resources"].AsInt,
			NormalPlanningCount = json["normal-planning-count"].AsInt,
			NormalPlanningCost = json["normal-planning-cost"].AsInt,
			OverPlanningCost = json["over-planning-cost"].AsInt,
			SprintsWonWithoutPlanning = json["sprints-won-without-planning"].AsInt,
			RiskChances = ParseRiskChances(json["risk-chances"]),
			EconomicsAffectsAll = json["economics-affects-all"].AsBool,
			StayOnSprintMinDiff = json["stay-on-sprint-min-diff"].AsInt,
			OnlyOneWinner = json["only-one-winner"].AsBool
		};
		while (true)
		{
			int num = -839379342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC35FBCCu) % 3u)
				{
				case 1u:
					goto IL_0113;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0113:
				num = (int)((num2 * 1313744573) ^ 0x72F497A8);
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		bool flag = default(bool);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1674452273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C9E7C13u) % 10u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1544173439;
						num5 = 1544173439;
					}
					else
					{
						num4 = 2145449556;
						num5 = 2145449556;
					}
					num = num4 ^ (int)(num2 * 1302775095);
					continue;
				}
				case 8u:
					num3 = 0;
					num = ((int)num2 * -1475394260) ^ -1214093001;
					continue;
				case 7u:
					num = (int)(num2 * 186301693) ^ -1777480081;
					continue;
				case 6u:
					array[num3] = json[num3].AsFloat;
					num = 233526933;
					continue;
				case 5u:
					result = array;
					num = (int)((num2 * 1347136139) ^ 0xD403239);
					continue;
				case 4u:
					num = ((int)num2 * -2005232881) ^ -1606725238;
					continue;
				case 3u:
					flag = num3 < array.Length;
					num = 1556968134;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 1764346874) ^ -1784918638;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 19932116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDED1ADu) % 25u)
				{
				case 24u:
					flag3 = num3 < count;
					num = 2104864002;
					continue;
				case 22u:
					num3 = 0;
					num = (int)(num2 * 917995433) ^ -489512315;
					continue;
				case 21u:
					num = (int)(num2 * 405940384) ^ -902923551;
					continue;
				case 20u:
					flag = num5 < jSONNode[num4].AsInt;
					num = 976567979;
					continue;
				case 19u:
					result = list.ToArray();
					num = (int)((num2 * 821223776) ^ 0x14F83331);
					continue;
				case 18u:
				{
					bool flag4 = num4 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag4 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num3
					});
					num = 1840674987;
					continue;
				}
				case 17u:
				{
					int num10;
					int num11;
					if (!flag2)
					{
						num10 = 1979201661;
						num11 = 1979201661;
					}
					else
					{
						num10 = 1816907170;
						num11 = 1816907170;
					}
					num = num10 ^ (int)(num2 * 1798293355);
					continue;
				}
				case 16u:
					num = (int)((num2 * 1220069399) ^ 0x37562527);
					continue;
				case 15u:
					num4++;
					num = ((int)num2 * -1304606000) ^ -579462876;
					continue;
				case 14u:
					num = (int)((num2 * 1175405201) ^ 0xD721C58);
					continue;
				case 13u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -597938456;
						num9 = -597938456;
					}
					else
					{
						num8 = -1249698708;
						num9 = -1249698708;
					}
					num = num8 ^ ((int)num2 * -459062408);
					continue;
				}
				case 11u:
					num = ((int)num2 * -1939299163) ^ -1492463459;
					continue;
				case 10u:
					flag2 = num4 < maxImpact * 2;
					num = 1591546915;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1103883324;
						num7 = -1103883324;
					}
					else
					{
						num6 = -306960936;
						num7 = -306960936;
					}
					num = num6 ^ (int)(num2 * 1244542805);
					continue;
				}
				case 8u:
					num5 = 0;
					num = (int)((num2 * 2014640670) ^ 0x7F307C60);
					continue;
				case 7u:
					num5++;
					num = (int)((num2 * 1366060864) ^ 0x737420D2);
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -2102258452) ^ -1106001792;
					continue;
				case 5u:
					num4 = 0;
					num = ((int)num2 * -1205640239) ^ 0x2BE0F079;
					continue;
				case 4u:
					jSONNode = json[num3];
					num = 415427637;
					continue;
				case 3u:
					num = 286731524;
					continue;
				case 2u:
					num = (int)(num2 * 1497561995) ^ -901636108;
					continue;
				case 1u:
					list = new List<Card>();
					num = (int)(num2 * 1301676950) ^ -932260530;
					continue;
				case 0u:
					num = (int)((num2 * 747061427) ^ 0x6007ADCB);
					continue;
				case 12u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 2000367531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EC31770u) % 4u)
				{
				case 3u:
					result = Rules.smethod_0("sprints: {0},\nmax-impact:{1},\ndeck: \n{2},\n\ninitial-resources: {3},\n\nnormal-planning-count: {4},\nnormal-planning-cost: {5},\nover-planning-cost: {6},\nsprints-won-without-planning: {7},\n\nrisk-chances: {8},\n\neconomics-affects-all: {9},\nstay-on-sprint-min-diff: {10},\nonly-one-winner: {11}", new object[12]
					{
						SprintCount,
						MaxImpact,
						CardsToString(),
						InitialResources,
						NormalPlanningCount,
						NormalPlanningCost,
						OverPlanningCost,
						SprintsWonWithoutPlanning,
						RiskChancesToString(),
						EconomicsAffectsAll,
						StayOnSprintMinDiff,
						OnlyOneWinner
					});
					num = (int)(num2 * 59705778) ^ -1465774537;
					continue;
				case 1u:
					num = ((int)num2 * -166828664) ^ -716762214;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private string CardsToString()
	{
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		int num4 = default(int);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = -961378365;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5615643u) % 18u)
				{
				case 16u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -1941108434;
						num7 = -1941108434;
					}
					else
					{
						num6 = -1725880195;
						num7 = -1725880195;
					}
					num = num6 ^ ((int)num2 * -1754032374);
					continue;
				}
				case 15u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 1589711274) ^ 0x413574FF);
					continue;
				case 14u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)((num2 * 1345097112) ^ 0x7E07A100);
					continue;
				case 13u:
					num3 = 0;
					num = (int)(num2 * 915529414) ^ -1263970271;
					continue;
				case 12u:
					text = "[\n\t";
					num4 = 0;
					num = ((int)num2 * -338078008) ^ 0x43DC4167;
					continue;
				case 11u:
					flag = num4 != card.Type;
					num = (int)(num2 * 879957834) ^ -430447397;
					continue;
				case 10u:
					num = ((int)num2 * -479336214) ^ -2111319290;
					continue;
				case 8u:
					card = cards[num3];
					num = -1812667192;
					continue;
				case 7u:
				{
					int num5;
					if (num3 < cards.Length)
					{
						num = -596277541;
						num5 = -596277541;
					}
					else
					{
						num = -1668859350;
						num5 = -1668859350;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -1687156975) ^ 0x50FD29F0;
					continue;
				case 5u:
					num4 = card.Type;
					num = (int)((num2 * 2143570988) ^ 0x476F14B6);
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 89506697) ^ -538582652;
					continue;
				case 3u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -831660365;
					continue;
				}
				case 2u:
					num = ((int)num2 * -1226587701) ^ 0x6729E84E;
					continue;
				case 1u:
					cards = Cards;
					num = (int)((num2 * 1715553014) ^ 0x31B30BAC);
					continue;
				case 0u:
					num = (int)(num2 * 1242869757) ^ -1709246799;
					continue;
				case 17u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private string RiskChancesToString()
	{
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1235322514;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29FBED62u) % 9u)
				{
				case 8u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -717075103) ^ 0x51A2650A;
					continue;
				case 7u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = 60771917;
						num4 = 60771917;
					}
					else
					{
						num = 456071326;
						num4 = 456071326;
					}
					continue;
				}
				case 6u:
					num3++;
					num = ((int)num2 * -142739153) ^ -1015323202;
					continue;
				case 4u:
					num = ((int)num2 * -1325925839) ^ -391358969;
					continue;
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 586406733;
					continue;
				case 2u:
					num = ((int)num2 * -1204004392) ^ -631699838;
					continue;
				case 1u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1470711117) ^ 0x1F8612C4;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	static string smethod_0(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	static string smethod_1(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_2(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_3(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static CultureInfo smethod_4()
	{
		return CultureInfo.InvariantCulture;
	}
}
