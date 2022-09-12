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
			int num = -157704085;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC38699E6u) % 4u)
				{
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
					num = ((int)num2 * -40040380) ^ 0x2D7D4252;
					continue;
				case 0u:
					num = ((int)num2 * -1523117716) ^ -854319240;
					continue;
				case 3u:
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
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = -1265135319;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9860AE73u) % 8u)
				{
				case 7u:
					num3++;
					num = (int)((num2 * 67147745) ^ 0x1AAA581F);
					continue;
				case 4u:
					array[num3] = json[num3].AsFloat;
					num = -1529728948;
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -233054565;
						num4 = -233054565;
					}
					else
					{
						num = -1673591265;
						num4 = -1673591265;
					}
					continue;
				}
				case 2u:
					array = new float[json.Count];
					num3 = 0;
					num = (int)((num2 * 205045413) ^ 0x55282D28);
					continue;
				case 1u:
					num = ((int)num2 * -52678435) ^ -1761857387;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -181936294) ^ -2106409170;
					continue;
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
		bool flag = default(bool);
		int num3 = default(int);
		List<Card> list = default(List<Card>);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag2 = default(bool);
		int count = default(int);
		int num4 = default(int);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 1949487613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17C20094u) % 21u)
				{
				case 20u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 547568520;
						num10 = 547568520;
					}
					else
					{
						num9 = 1173986889;
						num10 = 1173986889;
					}
					num = num9 ^ ((int)num2 * -2100645179);
					continue;
				}
				case 19u:
				{
					bool flag3 = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num5
					});
					num = 951187775;
					continue;
				}
				case 18u:
					num = (int)(num2 * 1815157178) ^ -121503707;
					continue;
				case 16u:
					num = (int)((num2 * 986297803) ^ 0x356BFA73);
					continue;
				case 15u:
					num3++;
					num = (int)((num2 * 1260406847) ^ 0x652CDA26);
					continue;
				case 14u:
					jSONNode = json[num5];
					num = 742938025;
					continue;
				case 13u:
					flag2 = num3 < maxImpact * 2;
					num = 1704212594;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 183160364;
						num8 = 183160364;
					}
					else
					{
						num7 = 2034505433;
						num8 = 2034505433;
					}
					num = num7 ^ ((int)num2 * -359178383);
					continue;
				}
				case 11u:
					num = (int)((num2 * 1544291958) ^ 0x7E42D2CC);
					continue;
				case 10u:
				{
					int num6;
					if (num5 < count)
					{
						num = 1080570358;
						num6 = 1080570358;
					}
					else
					{
						num = 1279658724;
						num6 = 1279658724;
					}
					continue;
				}
				case 9u:
					num = ((int)num2 * -695719741) ^ -1825919025;
					continue;
				case 8u:
					count = json.Count;
					list = new List<Card>();
					num = ((int)num2 * -62413024) ^ 0x71AC2A2A;
					continue;
				case 7u:
					num5 = 0;
					num = ((int)num2 * -1141956129) ^ 0x2F07F9CB;
					continue;
				case 6u:
					flag = num4 < jSONNode[num3].AsInt;
					num = 1091640178;
					continue;
				case 5u:
					num5++;
					num = ((int)num2 * -231470662) ^ -1166172827;
					continue;
				case 4u:
					num4 = 0;
					num = 134088276;
					continue;
				case 3u:
					result = list.ToArray();
					num = ((int)num2 * -513647782) ^ -1769323069;
					continue;
				case 2u:
					num4++;
					num = ((int)num2 * -1051864571) ^ -542300495;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -688628028) ^ -1088133189;
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
			int num = -1019991163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C72100Fu) % 4u)
				{
				case 2u:
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
					num = (int)((num2 * 1231411842) ^ 0x88E0C32);
					continue;
				case 1u:
					num = ((int)num2 * -77419597) ^ -2124472973;
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
		int num4 = default(int);
		int num3 = default(int);
		Card card = default(Card);
		string text = default(string);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1823427873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66562510u) % 16u)
				{
				case 15u:
					num = ((int)num2 * -1752825578) ^ 0x2ABE83C4;
					continue;
				case 14u:
					cards = Cards;
					num4 = 0;
					num = ((int)num2 * -1139071326) ^ 0x6BF33B6B;
					continue;
				case 13u:
					num3 = card.Type;
					num = (int)(num2 * 1394854525) ^ -1071016677;
					continue;
				case 12u:
					card = cards[num4];
					num = 1094584149;
					continue;
				case 10u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)((num2 * 1660386324) ^ 0x38408E75);
					continue;
				case 9u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1600220359) ^ 0x51576102;
					continue;
				case 8u:
					num4++;
					num = ((int)num2 * -1923573732) ^ 0x15B4F77;
					continue;
				case 7u:
				{
					int num7;
					if (num4 < cards.Length)
					{
						num = 390645404;
						num7 = 390645404;
					}
					else
					{
						num = 149673833;
						num7 = 149673833;
					}
					continue;
				}
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 361106620;
						num6 = 361106620;
					}
					else
					{
						num5 = 991614996;
						num6 = 991614996;
					}
					num = num5 ^ ((int)num2 * -117955495);
					continue;
				}
				case 5u:
					flag = num3 != card.Type;
					num = ((int)num2 * -1457039489) ^ -1835394035;
					continue;
				case 3u:
					num = (int)((num2 * 1627668462) ^ 0x4BEAE83E);
					continue;
				case 2u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1906253392;
					continue;
				}
				case 1u:
					text = "[\n\t";
					num3 = 0;
					num = ((int)num2 * -1953897809) ^ 0x50C4BB90;
					continue;
				case 0u:
					num = (int)(num2 * 7178794) ^ -785517464;
					continue;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1424685307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21B4AE24u) % 9u)
				{
				case 7u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -150567099) ^ 0x2F18E74;
					continue;
				case 6u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 2030248447;
					continue;
				case 5u:
					flag = num3 < RiskChances.Length;
					num = 676642954;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1147987123;
						num5 = -1147987123;
					}
					else
					{
						num4 = -1532489070;
						num5 = -1532489070;
					}
					num = num4 ^ (int)(num2 * 2135055855);
					continue;
				}
				case 2u:
					num3 = 1;
					num = (int)((num2 * 607686197) ^ 0x63C61E72);
					continue;
				case 1u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = (int)((num2 * 1249038716) ^ 0x155E5AC9);
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -136230066) ^ -949087499;
					continue;
				case 8u:
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
