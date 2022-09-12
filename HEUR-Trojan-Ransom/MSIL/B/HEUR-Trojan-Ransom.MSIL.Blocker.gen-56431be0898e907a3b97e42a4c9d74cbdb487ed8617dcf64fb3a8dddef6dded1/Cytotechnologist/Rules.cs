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
		Rules result = default(Rules);
		while (true)
		{
			int num = 1213064213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29966540u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -84228965) ^ 0x7598213D;
					continue;
				case 1u:
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
					num = (int)(num2 * 1908935764) ^ -1886056710;
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
		bool flag = default(bool);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = -509524560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9C3BF13u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1984761029;
						num5 = -1984761029;
					}
					else
					{
						num4 = -220116204;
						num5 = -220116204;
					}
					num = num4 ^ ((int)num2 * -426782137);
					continue;
				}
				case 7u:
					array[num3] = json[num3].AsFloat;
					num = -1962339958;
					continue;
				case 5u:
					result = array;
					num = (int)(num2 * 128760488) ^ -1595212966;
					continue;
				case 3u:
					flag = num3 < array.Length;
					num = -1834226076;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -943418182) ^ -710831615;
					continue;
				case 1u:
					num = ((int)num2 * -1495109403) ^ -1326576035;
					continue;
				case 0u:
					num3++;
					num = (int)((num2 * 1744663702) ^ 0x692965C9);
					continue;
				case 4u:
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
		int num5 = default(int);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		int num4 = default(int);
		int count = default(int);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		while (true)
		{
			int num = -1815556526;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB67A4833u) % 20u)
				{
				case 19u:
					num5 = 0;
					num = -1064059702;
					continue;
				case 17u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 828329775;
						num9 = 828329775;
					}
					else
					{
						num8 = 1170129292;
						num9 = 1170129292;
					}
					num = num8 ^ (int)(num2 * 584006148);
					continue;
				}
				case 16u:
				{
					int num6;
					if (num5 >= jSONNode[num3].AsInt)
					{
						num = -784178039;
						num6 = -784178039;
					}
					else
					{
						num = -986137543;
						num6 = -986137543;
					}
					continue;
				}
				case 15u:
					jSONNode = json[num4];
					num = -1945493101;
					continue;
				case 14u:
					num = ((int)num2 * -420374922) ^ 0x2EC4C30F;
					continue;
				case 13u:
					flag2 = num4 < count;
					num = -1280551194;
					continue;
				case 12u:
					num3++;
					num = ((int)num2 * -1533003131) ^ -1855765064;
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -377576487) ^ 0x4A2AAD60;
					continue;
				case 10u:
					flag = num3 < maxImpact;
					num = -681713413;
					continue;
				case 9u:
					num = (int)((num2 * 372062906) ^ 0x3BF41435);
					continue;
				case 8u:
					result = list.ToArray();
					num = ((int)num2 * -850606081) ^ -1355023991;
					continue;
				case 7u:
				{
					int num7;
					if (num3 < maxImpact * 2)
					{
						num = -872077044;
						num7 = -872077044;
					}
					else
					{
						num = -1090363768;
						num7 = -1090363768;
					}
					continue;
				}
				case 6u:
					num4 = 0;
					num = ((int)num2 * -20851219) ^ 0x7DB34468;
					continue;
				case 5u:
					num4++;
					num = (int)(num2 * 651219073) ^ -1210174005;
					continue;
				case 4u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -1342418588;
					continue;
				case 3u:
					num = (int)(num2 * 1339284178) ^ -253443232;
					continue;
				case 1u:
					count = json.Count;
					list = new List<Card>();
					num = ((int)num2 * -485827928) ^ -61117131;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1195195362) ^ 0x545239F8;
					continue;
				case 18u:
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
			int num = -1938563366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x875048E7u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1986569882) ^ 0x2041991C);
					continue;
				case 1u:
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
					num = ((int)num2 * -360654931) ^ -351967436;
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
		Card[] cards = default(Card[]);
		int num3 = default(int);
		int num4 = default(int);
		Card card = default(Card);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 2123369926;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21940F4Cu) % 17u)
				{
				case 15u:
					cards = Cards;
					num3 = 0;
					num = ((int)num2 * -587647255) ^ 0x2C1B0687;
					continue;
				case 14u:
					num = (int)((num2 * 681767276) ^ 0x11FFE66F);
					continue;
				case 12u:
					num = (int)((num2 * 607090154) ^ 0x16CDA537);
					continue;
				case 11u:
					num3++;
					num = ((int)num2 * -1517500372) ^ -2145359825;
					continue;
				case 10u:
					num4 = card.Type;
					num = (int)(num2 * 1568153285) ^ -1441108421;
					continue;
				case 9u:
					num4 = 0;
					num = ((int)num2 * -1735533697) ^ -1321343355;
					continue;
				case 8u:
				{
					int num7;
					if (num3 < cards.Length)
					{
						num = 1746743699;
						num7 = 1746743699;
					}
					else
					{
						num = 1049364878;
						num7 = 1049364878;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -742007786) ^ -1994679611;
					continue;
				case 6u:
					flag = num4 != card.Type;
					num = ((int)num2 * -663521894) ^ -1649317420;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 893951351;
						num6 = 893951351;
					}
					else
					{
						num5 = 1833075762;
						num6 = 1833075762;
					}
					num = num5 ^ (int)(num2 * 1627764544);
					continue;
				}
				case 4u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1804890476;
					continue;
				}
				case 3u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)((num2 * 357570192) ^ 0x4840971D);
					continue;
				case 2u:
					card = cards[num3];
					num = 1955883081;
					continue;
				case 1u:
					text = "[\n\t";
					num = (int)(num2 * 111589813) ^ -581389379;
					continue;
				case 0u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -780054916) ^ 0x6D73B760;
					continue;
				case 13u:
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
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1728813756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x315D53E1u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1486247444;
						num5 = -1486247444;
					}
					else
					{
						num4 = -1208084072;
						num5 = -1208084072;
					}
					num = num4 ^ (int)(num2 * 693853601);
					continue;
				}
				case 7u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = 513118430;
					continue;
				case 4u:
					flag = num3 < RiskChances.Length;
					num = 482190987;
					continue;
				case 3u:
					num = ((int)num2 * -247335160) ^ -1609126866;
					continue;
				case 2u:
					num = ((int)num2 * -1921048627) ^ -1443606036;
					continue;
				case 1u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -1214204319) ^ -62961534;
					continue;
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -881350900) ^ -2019130357;
					continue;
				case 5u:
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
