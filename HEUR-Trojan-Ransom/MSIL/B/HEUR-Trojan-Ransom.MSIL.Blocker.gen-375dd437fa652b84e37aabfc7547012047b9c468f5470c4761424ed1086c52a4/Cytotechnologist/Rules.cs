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
		while (true)
		{
			int num = 1501803430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12E81575u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1247758597) ^ -1934292764;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = json["max-impact"].AsInt;
		Rules result = default(Rules);
		while (true)
		{
			int num = -378752103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC20BEF8Eu) % 4u)
				{
				case 3u:
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
					num = (int)(num2 * 854502139) ^ -57129822;
					continue;
				case 1u:
					num = ((int)num2 * -519716145) ^ 0x653F21BF;
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
		int num = 0;
		float[] result = default(float[]);
		while (true)
		{
			bool flag = num < array.Length;
			int num2 = 1607470581;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x316D175Fu) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -815201946;
						num5 = -815201946;
					}
					else
					{
						num4 = -1603455457;
						num5 = -1603455457;
					}
					num2 = num4 ^ (int)(num3 * 1141327878);
					continue;
				}
				case 3u:
					array[num] = json[num].AsFloat;
					num++;
					num2 = 1660189907;
					continue;
				case 2u:
					num2 = 1711107738;
					continue;
				case 1u:
					result = array;
					num2 = ((int)num3 * -1424252212) ^ 0x739F3EEF;
					continue;
				case 0u:
					num2 = (int)((num3 * 2123546450) ^ 0x72DFA2D7);
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		List<Card> list = default(List<Card>);
		bool flag3 = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 1080257667;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C278A29u) % 21u)
				{
				case 20u:
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num3
					});
					num = 1577310912;
					continue;
				case 19u:
					flag2 = num3 < count;
					num = 121055001;
					continue;
				case 18u:
					jSONNode = json[num3];
					num = 1413853606;
					continue;
				case 17u:
					count = json.Count;
					num = ((int)num2 * -511117556) ^ -1793953125;
					continue;
				case 16u:
					num4++;
					num = (int)((num2 * 1097501062) ^ 0x4DB5D8D5);
					continue;
				case 15u:
					flag3 = num5 < maxImpact;
					num = 2108881879;
					continue;
				case 14u:
					num = (int)(num2 * 361478313) ^ -1623369451;
					continue;
				case 13u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 1913028057;
						num10 = 1913028057;
					}
					else
					{
						num9 = 1749198232;
						num10 = 1749198232;
					}
					num = num9 ^ (int)(num2 * 141706122);
					continue;
				}
				case 12u:
					result = list.ToArray();
					num = ((int)num2 * -449587002) ^ 0x69A8CDF9;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1186704690;
						num8 = 1186704690;
					}
					else
					{
						num7 = 514891323;
						num8 = 514891323;
					}
					num = num7 ^ (int)(num2 * 1334641188);
					continue;
				}
				case 10u:
					num4 = 0;
					num = 1603741687;
					continue;
				case 8u:
					num5 = 0;
					num = ((int)num2 * -1024359490) ^ -1205567851;
					continue;
				case 7u:
					num5++;
					num = (int)(num2 * 949568930) ^ -824336139;
					continue;
				case 6u:
					flag = num5 < maxImpact * 2;
					num = 1571500501;
					continue;
				case 5u:
					list = new List<Card>();
					num3 = 0;
					num = ((int)num2 * -1266116066) ^ -1527265055;
					continue;
				case 4u:
				{
					int num6;
					if (num4 < jSONNode[num5].AsInt)
					{
						num = 1586529072;
						num6 = 1586529072;
					}
					else
					{
						num = 796633742;
						num6 = 796633742;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -1634013100) ^ -1667716266;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 1521348795) ^ 0x12A57D75);
					continue;
				case 1u:
					num = (int)(num2 * 258522382) ^ -1540282829;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 273628659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D932CBEu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -303877083) ^ -460407281;
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
					num = ((int)num2 * -486591693) ^ -1424030337;
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
		string result = default(string);
		string text = default(string);
		int num5 = default(int);
		Card[] cards = default(Card[]);
		Card card = default(Card);
		int num3 = default(int);
		while (true)
		{
			int num = -1602942717;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0D4DC37u) % 18u)
				{
				case 17u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 214671537) ^ 0x23B40D9E);
					continue;
				case 16u:
					num = ((int)num2 * -979701664) ^ 0x44888599;
					continue;
				case 15u:
					num5 = 0;
					num = ((int)num2 * -2101804282) ^ -442944889;
					continue;
				case 14u:
					num = (int)(num2 * 1144978764) ^ -1227994390;
					continue;
				case 13u:
					num = (int)((num2 * 1587575207) ^ 0x170213B3);
					continue;
				case 12u:
					cards = Cards;
					num = ((int)num2 * -680389680) ^ -417666213;
					continue;
				case 10u:
					text = "[\n\t";
					num = (int)(num2 * 828409464) ^ -1471990672;
					continue;
				case 9u:
					card = cards[num3];
					num = -1150010257;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (num5 != card.Type)
					{
						num6 = 935334176;
						num7 = 935334176;
					}
					else
					{
						num6 = 1469596318;
						num7 = 1469596318;
					}
					num = num6 ^ ((int)num2 * -1087122188);
					continue;
				}
				case 6u:
					num = ((int)num2 * -65859137) ^ -210144328;
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 61030013) ^ -532030956;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -1715065554) ^ 0x78568EEF;
					continue;
				case 3u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = (int)((num2 * 509451268) ^ 0x5A790241);
					continue;
				case 2u:
					num = ((int)num2 * -1063910607) ^ -643794153;
					continue;
				case 1u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1870836634;
					continue;
				}
				case 0u:
				{
					int num4;
					if (num3 >= cards.Length)
					{
						num = -973093624;
						num4 = -973093624;
					}
					else
					{
						num = -1669514510;
						num4 = -1669514510;
					}
					continue;
				}
				case 11u:
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
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1458074492;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF0BDCE7u) % 6u)
				{
				case 4u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1966227371) ^ -1738413827;
					continue;
				case 3u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -1983204680) ^ -1715923062;
					continue;
				case 2u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = -454718814;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = -25298801;
						num4 = -25298801;
					}
					else
					{
						num = -980892737;
						num4 = -980892737;
					}
					continue;
				}
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
