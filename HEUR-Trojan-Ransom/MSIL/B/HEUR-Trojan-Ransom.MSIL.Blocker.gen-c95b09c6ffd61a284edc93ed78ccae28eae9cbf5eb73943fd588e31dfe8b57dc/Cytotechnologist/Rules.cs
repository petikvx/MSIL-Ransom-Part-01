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
		Rules result = default(Rules);
		while (true)
		{
			int num = -127063595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB32A94B6u) % 4u)
				{
				case 3u:
				{
					int asInt = json["max-impact"].AsInt;
					result = new Rules
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
					num = (int)((num2 * 162607964) ^ 0x72105B43);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1050554294) ^ 0x440C6B02;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		int num5 = default(int);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1074359559;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FDBEA8Au) % 8u)
				{
				case 5u:
					num5 = 0;
					num = ((int)num2 * -1938861302) ^ -1171079565;
					continue;
				case 4u:
					num = (int)((num2 * 1471998764) ^ 0x20C1E07D);
					continue;
				case 3u:
					flag = num5 < array.Length;
					num = 995508610;
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -2145439694) ^ 0x338FC70A;
					continue;
				case 1u:
					array[num5] = json[num5].AsFloat;
					num5++;
					num = 410893553;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1065557541;
						num4 = -1065557541;
					}
					else
					{
						num3 = -1793655400;
						num4 = -1793655400;
					}
					num = num3 ^ (int)(num2 * 2098254925);
					continue;
				}
				case 6u:
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
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -480059690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA03AC456u) % 23u)
				{
				case 22u:
					flag2 = num4 < maxImpact;
					num = -755144172;
					continue;
				case 21u:
				{
					int num9;
					if (num4 < maxImpact * 2)
					{
						num = -1271432883;
						num9 = -1271432883;
					}
					else
					{
						num = -1670892421;
						num9 = -1670892421;
					}
					continue;
				}
				case 19u:
					num = (int)((num2 * 251830871) ^ 0x3E2C94FA);
					continue;
				case 18u:
					num3++;
					num = (int)(num2 * 530777646) ^ -425550028;
					continue;
				case 17u:
					num = (int)((num2 * 12548272) ^ 0x77495220);
					continue;
				case 16u:
					num = ((int)num2 * -1122991821) ^ 0xCE7AE84;
					continue;
				case 15u:
					jSONNode = json[num3];
					num = (int)(num2 * 1944477817) ^ -128861709;
					continue;
				case 14u:
					result = list.ToArray();
					num = (int)((num2 * 1339769055) ^ 0x75CC9C6F);
					continue;
				case 13u:
					num = ((int)num2 * -2142494560) ^ -344337390;
					continue;
				case 12u:
					num = ((int)num2 * -64317380) ^ 0x30357AD1;
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -2056735151) ^ 0x37B1A034;
					continue;
				case 10u:
					num4 = 0;
					num = (int)((num2 * 2099368715) ^ 0x6F94DE67);
					continue;
				case 9u:
					num = -1128973774;
					continue;
				case 8u:
					num = -1660683976;
					continue;
				case 7u:
					num5 = 0;
					num = ((int)num2 * -1478324043) ^ -289568416;
					continue;
				case 6u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num3
					});
					num = -31869216;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1763900476;
						num8 = 1763900476;
					}
					else
					{
						num7 = 1172803195;
						num8 = 1172803195;
					}
					num = num7 ^ ((int)num2 * -19676379);
					continue;
				}
				case 4u:
				{
					int num6;
					if (num5 < jSONNode[num4].AsInt)
					{
						num = -2051369472;
						num6 = -2051369472;
					}
					else
					{
						num = -194725198;
						num6 = -194725198;
					}
					continue;
				}
				case 2u:
					num4++;
					num = ((int)num2 * -1822509755) ^ 0x1EFF057F;
					continue;
				case 1u:
					list = new List<Card>();
					num3 = 0;
					num = ((int)num2 * -1583367144) ^ 0x37B5D522;
					continue;
				case 0u:
					flag = num3 < count;
					num = -610449467;
					continue;
				case 20u:
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
			int num = 1749460614;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F1CCDA1u) % 4u)
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
					num = (int)((num2 * 1053797061) ^ 0x32716BC);
					continue;
				case 2u:
					num = (int)((num2 * 2032228732) ^ 0x4B10BCF4);
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
		int num3 = default(int);
		string text = default(string);
		int num7 = default(int);
		Card[] cards = default(Card[]);
		Card card = default(Card);
		string result = default(string);
		while (true)
		{
			int num = 1935375044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x742E9B8Eu) % 16u)
				{
				case 15u:
					num = (int)((num2 * 2008965006) ^ 0x5D465F1C);
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -797636972;
						num6 = -797636972;
					}
					else
					{
						num5 = -275420462;
						num6 = -275420462;
					}
					num = num5 ^ (int)(num2 * 921786244);
					continue;
				}
				case 13u:
					num3++;
					num = ((int)num2 * -1756267339) ^ -2066305556;
					continue;
				case 12u:
					num = ((int)num2 * -53543981) ^ 0x653D3629;
					continue;
				case 11u:
					num = ((int)num2 * -196065793) ^ -175070490;
					continue;
				case 10u:
					text = "[\n\t";
					num7 = 0;
					cards = Cards;
					num = ((int)num2 * -343062815) ^ -685498335;
					continue;
				case 8u:
					flag = num7 != card.Type;
					num = ((int)num2 * -1860785125) ^ 0x32C6D968;
					continue;
				case 7u:
					card = cards[num3];
					num = 2006704230;
					continue;
				case 6u:
					num7 = card.Type;
					num = (int)(num2 * 718643932) ^ -559542780;
					continue;
				case 5u:
					num3 = 0;
					num = (int)(num2 * 245345479) ^ -1963009343;
					continue;
				case 4u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 1641662106) ^ -336683536;
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= cards.Length)
					{
						num = 1424433519;
						num4 = 1424433519;
					}
					else
					{
						num = 946475049;
						num4 = 946475049;
					}
					continue;
				}
				case 2u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 159777317;
					continue;
				}
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 933500747) ^ -1748791366;
					continue;
				case 9u:
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
		bool flag = default(bool);
		int num5 = default(int);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 583689503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D39D443u) % 8u)
				{
				case 6u:
					num = ((int)num2 * -119397270) ^ -1782516254;
					continue;
				case 5u:
					flag = num5 < RiskChances.Length;
					num = 1925324306;
					continue;
				case 4u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num5 = 1;
					num = ((int)num2 * -632416216) ^ 0x49921125;
					continue;
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num5++;
					num = 2021346718;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1991949386;
						num4 = -1991949386;
					}
					else
					{
						num3 = -949583683;
						num4 = -949583683;
					}
					num = num3 ^ (int)(num2 * 1027317558);
					continue;
				}
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -663957313) ^ 0x8A8C304;
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
