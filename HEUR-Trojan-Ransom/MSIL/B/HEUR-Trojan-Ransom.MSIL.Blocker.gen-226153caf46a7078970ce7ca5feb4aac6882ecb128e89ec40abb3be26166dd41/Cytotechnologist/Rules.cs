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
			int num = 1018470169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4166DFD3u) % 3u)
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
				num = ((int)num2 * -1205409633) ^ 0x1F16F705;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = json["max-impact"].AsInt;
		Rules result = default(Rules);
		while (true)
		{
			int num = -1226447881;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB8CBFC9u) % 4u)
				{
				case 2u:
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
					num = ((int)num2 * -1978924586) ^ 0x3297FFEC;
					continue;
				case 1u:
					num = (int)(num2 * 1051937968) ^ -710714166;
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
		bool flag = default(bool);
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = -161820104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1D00B93u) % 11u)
				{
				case 10u:
					flag = num3 < array.Length;
					num = -1690151279;
					continue;
				case 9u:
					result = array;
					num = ((int)num2 * -1044617264) ^ 0x66D9C99;
					continue;
				case 8u:
					num3++;
					num = (int)(num2 * 1177392462) ^ -10451857;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1332970625;
						num5 = 1332970625;
					}
					else
					{
						num4 = 1872363587;
						num5 = 1872363587;
					}
					num = num4 ^ ((int)num2 * -197315498);
					continue;
				}
				case 6u:
					num = (int)((num2 * 2099763879) ^ 0x37FB90D5);
					continue;
				case 4u:
					array = new float[json.Count];
					num = ((int)num2 * -677495098) ^ -1212684054;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1189306208) ^ -1642960401;
					continue;
				case 1u:
					array[num3] = json[num3].AsFloat;
					num = -868248110;
					continue;
				case 0u:
					num = (int)((num2 * 954042181) ^ 0x662284AD);
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
		int count = json.Count;
		bool flag2 = default(bool);
		int num4 = default(int);
		bool flag3 = default(bool);
		int num3 = default(int);
		int num5 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 597735065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3394788Eu) % 22u)
				{
				case 21u:
					num = (int)(num2 * 517996165) ^ -1564957335;
					continue;
				case 20u:
					flag2 = num4 < maxImpact;
					num = 438627925;
					continue;
				case 19u:
					num = ((int)num2 * -107584483) ^ -220488115;
					continue;
				case 18u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -1682871591;
						num9 = -1682871591;
					}
					else
					{
						num8 = -2143776101;
						num9 = -2143776101;
					}
					num = num8 ^ (int)(num2 * 1927809092);
					continue;
				}
				case 16u:
					num4++;
					num = ((int)num2 * -1659729169) ^ 0x34C9C9CC;
					continue;
				case 15u:
					num = ((int)num2 * -997735840) ^ -79639970;
					continue;
				case 14u:
					num3++;
					num = (int)(num2 * 2126075649) ^ -294868118;
					continue;
				case 12u:
					num5 = 0;
					num = (int)((num2 * 2134939597) ^ 0x5DA44A63);
					continue;
				case 11u:
					result = list.ToArray();
					num = (int)((num2 * 281468114) ^ 0x5A47600D);
					continue;
				case 10u:
				{
					int num10;
					if (num4 >= maxImpact * 2)
					{
						num = 1270971062;
						num10 = 1270971062;
					}
					else
					{
						num = 885678031;
						num10 = 885678031;
					}
					continue;
				}
				case 9u:
					num = (int)(num2 * 616282067) ^ -433134173;
					continue;
				case 8u:
					num5++;
					num = ((int)num2 * -1411068357) ^ -1416108624;
					continue;
				case 7u:
					num3 = 0;
					num = 1279800201;
					continue;
				case 6u:
					flag3 = num5 < count;
					num = 938020420;
					continue;
				case 5u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num5
					});
					num = 1205203797;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1089090954;
						num7 = -1089090954;
					}
					else
					{
						num6 = -136166664;
						num7 = -136166664;
					}
					num = num6 ^ (int)(num2 * 2016730013);
					continue;
				}
				case 3u:
					jSONNode = json[num5];
					num = 222013850;
					continue;
				case 2u:
					num4 = 0;
					num = (int)(num2 * 1672226824) ^ -801267659;
					continue;
				case 1u:
					list = new List<Card>();
					num = (int)(num2 * 509020879) ^ -1498066041;
					continue;
				case 0u:
					flag = num3 < jSONNode[num4].AsInt;
					num = 148222326;
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

	public override string ToString()
	{
		string result = Rules.smethod_0("sprints: {0},\nmax-impact:{1},\ndeck: \n{2},\n\ninitial-resources: {3},\n\nnormal-planning-count: {4},\nnormal-planning-cost: {5},\nover-planning-cost: {6},\nsprints-won-without-planning: {7},\n\nrisk-chances: {8},\n\neconomics-affects-all: {9},\nstay-on-sprint-min-diff: {10},\nonly-one-winner: {11}", new object[12]
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
		while (true)
		{
			int num = -126708555;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE730F92u) % 3u)
				{
				case 1u:
					goto IL_00b5;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_00b5:
				num = ((int)num2 * -1064461109) ^ -1544744933;
			}
		}
	}

	private string CardsToString()
	{
		Card[] cards = default(Card[]);
		string text = default(string);
		Card card = default(Card);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 561728888;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34C2189Bu) % 18u)
				{
				case 17u:
					cards = Cards;
					num = ((int)num2 * -695882657) ^ -516720378;
					continue;
				case 16u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 374029398;
					continue;
				}
				case 15u:
					num4 = 0;
					num = (int)(num2 * 1205838048) ^ -1578075124;
					continue;
				case 14u:
					num3 = 0;
					num = (int)((num2 * 1381369449) ^ 0x8EE6E10);
					continue;
				case 13u:
					num = ((int)num2 * -339602269) ^ 0x60929DE2;
					continue;
				case 12u:
					num4 = card.Type;
					num = (int)((num2 * 1871752652) ^ 0x58C5481D);
					continue;
				case 11u:
					text = "[\n\t";
					num = ((int)num2 * -535154033) ^ -483023303;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 220483503;
						num7 = 220483503;
					}
					else
					{
						num6 = 895704800;
						num7 = 895704800;
					}
					num = num6 ^ (int)(num2 * 1523024196);
					continue;
				}
				case 8u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 1425245845) ^ -95612754;
					continue;
				case 7u:
					num = ((int)num2 * -441018758) ^ -373367409;
					continue;
				case 6u:
				{
					int num5;
					if (num3 < cards.Length)
					{
						num = 1933808305;
						num5 = 1933808305;
					}
					else
					{
						num = 229294545;
						num5 = 229294545;
					}
					continue;
				}
				case 5u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 144156671) ^ -1559337310;
					continue;
				case 4u:
					num = (int)((num2 * 166464178) ^ 0x4A5892B7);
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -1098388884) ^ 0x1C0814CD;
					continue;
				case 2u:
					card = cards[num3];
					flag = num4 != card.Type;
					num = 877939894;
					continue;
				case 1u:
					num = ((int)num2 * -1591148984) ^ 0x77E57780;
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

	private string RiskChancesToString()
	{
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		string result = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1113396515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE76177D5u) % 7u)
				{
				case 6u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 2004620319) ^ 0x657D7272);
					continue;
				case 5u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = -401316086;
						num4 = -401316086;
					}
					else
					{
						num = -1880172035;
						num4 = -1880172035;
					}
					continue;
				}
				case 4u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -468878450;
					continue;
				case 3u:
					num3 = 1;
					num = ((int)num2 * -1412340713) ^ -1707984468;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -474712851) ^ 0x7DCAE2B;
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
