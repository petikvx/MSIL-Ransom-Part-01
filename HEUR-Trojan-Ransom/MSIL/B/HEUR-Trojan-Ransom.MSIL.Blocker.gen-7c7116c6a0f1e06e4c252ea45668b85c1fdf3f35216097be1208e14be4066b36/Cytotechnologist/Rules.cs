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
			int num = 747168038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CCBFDB4u) % 4u)
				{
				case 2u:
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
					num = (int)((num2 * 1725400061) ^ 0x44F24887);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1615128875) ^ 0x5C29D63A;
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
			int num2 = -1158857993;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF9E6F5A8u) % 8u)
				{
				case 7u:
					num2 = ((int)num3 * -258455800) ^ 0x4A3FA67A;
					continue;
				case 6u:
					num++;
					num2 = (int)((num3 * 2034035623) ^ 0x13C07EC0);
					continue;
				case 4u:
					num2 = (int)(num3 * 1681908604) ^ -1397193451;
					continue;
				case 3u:
					result = array;
					num2 = (int)((num3 * 1374777924) ^ 0x3D3A8140);
					continue;
				case 2u:
				{
					int num4;
					if (num >= array.Length)
					{
						num2 = -793923173;
						num4 = -793923173;
					}
					else
					{
						num2 = -122501303;
						num4 = -122501303;
					}
					continue;
				}
				case 1u:
					array[num] = json[num].AsFloat;
					num2 = -1160057018;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		bool flag3 = default(bool);
		int num4 = default(int);
		int count = default(int);
		int num7 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -46503046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2536AE3u) % 27u)
				{
				case 26u:
					num = (int)(num2 * 1553762939) ^ -1859146340;
					continue;
				case 25u:
					num = ((int)num2 * -1928194855) ^ -626871584;
					continue;
				case 24u:
					num = (int)((num2 * 508619526) ^ 0x361707D0);
					continue;
				case 23u:
					num = ((int)num2 * -615508062) ^ -1071592743;
					continue;
				case 22u:
					flag3 = num4 < count;
					num = -2000111186;
					continue;
				case 21u:
					num7++;
					num = (int)(num2 * 40713885) ^ -596670056;
					continue;
				case 20u:
					num7 = 0;
					num = -1013926753;
					continue;
				case 19u:
					result = list.ToArray();
					num = (int)((num2 * 149715255) ^ 0x9E5EDC3);
					continue;
				case 18u:
					num = ((int)num2 * -2041962736) ^ 0x3EF42518;
					continue;
				case 17u:
					count = json.Count;
					num = (int)(num2 * 1789733543) ^ -1696606578;
					continue;
				case 16u:
					num3++;
					num = (int)(num2 * 350776967) ^ -820630742;
					continue;
				case 15u:
					num4++;
					num = (int)(num2 * 1950676328) ^ -863626547;
					continue;
				case 14u:
					list = new List<Card>();
					num = (int)(num2 * 1404174416) ^ -657433591;
					continue;
				case 13u:
					num = (int)((num2 * 2143959706) ^ 0x55B21434);
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -742739260;
						num10 = -742739260;
					}
					else
					{
						num9 = -840326283;
						num10 = -840326283;
					}
					num = num9 ^ ((int)num2 * -1914619298);
					continue;
				}
				case 11u:
					num = ((int)num2 * -5743337) ^ -78263256;
					continue;
				case 10u:
					flag = num3 < maxImpact;
					num = ((int)num2 * -690791702) ^ -1131986892;
					continue;
				case 9u:
					jSONNode = json[num4];
					num = -1006641203;
					continue;
				case 8u:
					num3 = 0;
					num = (int)(num2 * 26552103) ^ -669561823;
					continue;
				case 7u:
					num4 = 0;
					num = (int)((num2 * 2016742447) ^ 0x5C463FA3);
					continue;
				case 5u:
				{
					int num8;
					if (num7 < jSONNode[num3].AsInt)
					{
						num = -2078226233;
						num8 = -2078226233;
					}
					else
					{
						num = -1882911991;
						num8 = -1882911991;
					}
					continue;
				}
				case 4u:
					num = -1232170434;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = -253638863;
						num6 = -253638863;
					}
					else
					{
						num5 = -1787586093;
						num6 = -1787586093;
					}
					num = num5 ^ (int)(num2 * 1328554549);
					continue;
				}
				case 1u:
					flag2 = num3 < maxImpact * 2;
					num = -285609753;
					continue;
				case 0u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -1704248391;
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

	public override string ToString()
	{
		return Rules.smethod_0("sprints: {0},\nmax-impact:{1},\ndeck: \n{2},\n\ninitial-resources: {3},\n\nnormal-planning-count: {4},\nnormal-planning-cost: {5},\nover-planning-cost: {6},\nsprints-won-without-planning: {7},\n\nrisk-chances: {8},\n\neconomics-affects-all: {9},\nstay-on-sprint-min-diff: {10},\nonly-one-winner: {11}", new object[12]
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
	}

	private string CardsToString()
	{
		string text = default(string);
		string result = default(string);
		int num3 = default(int);
		Card[] cards = default(Card[]);
		int num4 = default(int);
		Card card = default(Card);
		while (true)
		{
			int num = 1303355305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69DD7372u) % 17u)
				{
				case 16u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 768293659) ^ -603082045;
					continue;
				case 15u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 509545631) ^ 0x182875B);
					continue;
				case 14u:
					num3 = 0;
					num = (int)(num2 * 1410316194) ^ -2036328770;
					continue;
				case 13u:
					num = ((int)num2 * -264881495) ^ -1352093506;
					continue;
				case 12u:
					cards = Cards;
					num = ((int)num2 * -358038872) ^ 0x7DB592BA;
					continue;
				case 11u:
					num = ((int)num2 * -1942591216) ^ 0x691B9DEC;
					continue;
				case 10u:
					text = "[\n\t";
					num4 = 0;
					num = (int)((num2 * 1524276376) ^ 0x5AB3BEEB);
					continue;
				case 8u:
				{
					int num7;
					if (num3 < cards.Length)
					{
						num = 890127762;
						num7 = 890127762;
					}
					else
					{
						num = 806940959;
						num7 = 806940959;
					}
					continue;
				}
				case 7u:
					num4 = card.Type;
					num = ((int)num2 * -186635736) ^ 0x86EEED9;
					continue;
				case 6u:
					num = ((int)num2 * -1163806117) ^ -313939766;
					continue;
				case 5u:
					num = ((int)num2 * -519641641) ^ -695588028;
					continue;
				case 3u:
					card = cards[num3];
					num = 1075275316;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (num4 == card.Type)
					{
						num5 = -1993923691;
						num6 = -1993923691;
					}
					else
					{
						num5 = -591384451;
						num6 = -591384451;
					}
					num = num5 ^ (int)(num2 * 860930637);
					continue;
				}
				case 1u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 782588718;
					continue;
				}
				case 0u:
					num3++;
					num = (int)((num2 * 402645256) ^ 0x43A4F79E);
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

	private string RiskChancesToString()
	{
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1622360371;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C04BC97u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1514276679) ^ 0x4A0FD2CA);
					continue;
				case 8u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -892918773) ^ -2085055808;
					continue;
				case 7u:
					num3++;
					num = (int)(num2 * 2024174169) ^ -1595627312;
					continue;
				case 6u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = 1584424362;
						num4 = 1584424362;
					}
					else
					{
						num = 1330667934;
						num4 = 1330667934;
					}
					continue;
				}
				case 5u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 956370592;
					continue;
				case 3u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1686347341) ^ -784844343;
					continue;
				case 1u:
					num3 = 1;
					num = ((int)num2 * -1473665610) ^ -1718823917;
					continue;
				case 0u:
					num = (int)(num2 * 1754469631) ^ -1609853691;
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
