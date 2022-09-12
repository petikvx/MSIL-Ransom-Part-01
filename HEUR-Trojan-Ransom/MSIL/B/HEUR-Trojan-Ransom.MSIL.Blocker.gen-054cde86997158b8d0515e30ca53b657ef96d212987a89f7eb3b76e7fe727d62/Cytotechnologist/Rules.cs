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
			int num = 1122923974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41AC7B62u) % 3u)
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
				num = (int)((num2 * 2046050476) ^ 0x51821657);
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		while (true)
		{
			int num = -1808584621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE13729B4u) % 4u)
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
					num = ((int)num2 * -180334686) ^ 0x21CCB3FE;
					continue;
				}
				case 0u:
					num = ((int)num2 * -49507097) ^ -1900913023;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = -1457971186;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88D04438u) % 9u)
				{
				case 8u:
					num3 = 0;
					num = (int)(num2 * 2105533555) ^ -670637674;
					continue;
				case 7u:
					num = (int)((num2 * 1957477884) ^ 0xD7F2D8A);
					continue;
				case 6u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = -1376382399;
						num4 = -1376382399;
					}
					else
					{
						num = -310354235;
						num4 = -310354235;
					}
					continue;
				}
				case 4u:
					array = new float[json.Count];
					num = (int)((num2 * 1960148963) ^ 0x6D507AE7);
					continue;
				case 3u:
					array[num3] = json[num3].AsFloat;
					num = -153328956;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 618819542) ^ -2053594626;
					continue;
				case 1u:
					result = array;
					num = (int)((num2 * 1109878086) ^ 0x466764EE);
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
		int count = json.Count;
		List<Card> list = new List<Card>();
		Card[] result = default(Card[]);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = -1660365533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD46147E2u) % 22u)
				{
				case 21u:
					num = ((int)num2 * -916497291) ^ -1159287379;
					continue;
				case 20u:
					result = list.ToArray();
					num = ((int)num2 * -1875417574) ^ -156364258;
					continue;
				case 19u:
					jSONNode = json[num3];
					num5 = 0;
					num = ((int)num2 * -911858510) ^ -1142174916;
					continue;
				case 18u:
					num = (int)(num2 * 1455014760) ^ -238268628;
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -1117587011;
						num10 = -1117587011;
					}
					else
					{
						num9 = -489958122;
						num10 = -489958122;
					}
					num = num9 ^ ((int)num2 * -305602623);
					continue;
				}
				case 16u:
				{
					int num6;
					if (num5 < maxImpact * 2)
					{
						num = -654970865;
						num6 = -654970865;
					}
					else
					{
						num = -149846658;
						num6 = -149846658;
					}
					continue;
				}
				case 13u:
					num5++;
					num = ((int)num2 * -416509100) ^ -2086494466;
					continue;
				case 12u:
					num = (int)((num2 * 521664811) ^ 0x48EA8325);
					continue;
				case 11u:
					num = -1926207783;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1358396074;
						num8 = 1358396074;
					}
					else
					{
						num7 = 1476338508;
						num8 = 1476338508;
					}
					num = num7 ^ ((int)num2 * -1645877562);
					continue;
				}
				case 9u:
				{
					bool flag3 = num5 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num3
					});
					num = -1447303237;
					continue;
				}
				case 8u:
					num = -1516757919;
					continue;
				case 7u:
					num = -736866307;
					continue;
				case 6u:
					flag2 = num4 < jSONNode[num5].AsInt;
					num = -1393531986;
					continue;
				case 5u:
					num3 = 0;
					num = (int)((num2 * 1649115308) ^ 0x63244ED9);
					continue;
				case 4u:
					num = ((int)num2 * -601515408) ^ 0x2E803578;
					continue;
				case 3u:
					flag = num3 < count;
					num = -1742967177;
					continue;
				case 2u:
					num4++;
					num = (int)((num2 * 1012010316) ^ 0x55A2A5BC);
					continue;
				case 1u:
					num4 = 0;
					num = (int)((num2 * 1951405982) ^ 0x79690FCE);
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -126651433) ^ 0x282B4E57;
					continue;
				case 15u:
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
			int num = 1487809942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9755DA0u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1710824731) ^ -114946670;
					continue;
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
					num = ((int)num2 * -246798192) ^ -1581869685;
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
		string text = "[\n\t";
		int num = 0;
		Card[] cards = Cards;
		int num4 = default(int);
		string result = default(string);
		bool flag = default(bool);
		Card card = default(Card);
		while (true)
		{
			int num2 = -1173911687;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xE5A17495u) % 15u)
				{
				case 14u:
					num2 = ((int)num3 * -1266042365) ^ -1718104884;
					continue;
				case 13u:
				{
					int num7;
					if (num4 < cards.Length)
					{
						num2 = -1845384649;
						num7 = -1845384649;
					}
					else
					{
						num2 = -947133078;
						num7 = -947133078;
					}
					continue;
				}
				case 12u:
					num2 = (int)((num3 * 1251062133) ^ 0x81E77E);
					continue;
				case 11u:
					result = Rules.smethod_1(text, "\n]");
					num2 = (int)((num3 * 922196169) ^ 0x586345B7);
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1490262271;
						num6 = -1490262271;
					}
					else
					{
						num5 = -1489894153;
						num6 = -1489894153;
					}
					num2 = num5 ^ ((int)num3 * -340917816);
					continue;
				}
				case 8u:
					num2 = ((int)num3 * -1186029488) ^ 0x6E937FDA;
					continue;
				case 7u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num2 = -890357963;
					continue;
				}
				case 6u:
					text = Rules.smethod_1(text, "\n\t");
					num = card.Type;
					num2 = (int)((num3 * 361372809) ^ 0x4C1A1A86);
					continue;
				case 5u:
					num4 = 0;
					num2 = ((int)num3 * -1810334249) ^ -299563278;
					continue;
				case 3u:
					card = cards[num4];
					num2 = -453680571;
					continue;
				case 2u:
					num4++;
					num2 = ((int)num3 * -1829741536) ^ 0x3F333CD5;
					continue;
				case 1u:
					num2 = (int)(num3 * 1552898923) ^ -1814847494;
					continue;
				case 0u:
					flag = num != card.Type;
					num2 = ((int)num3 * -173647108) ^ 0x4F845F56;
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
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 1272572812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2FBD7F84u) % 9u)
				{
				case 8u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1581267626) ^ 0x75356925;
					continue;
				case 7u:
					num3++;
					num = (int)((num2 * 863952948) ^ 0x4A3F44A8);
					continue;
				case 5u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = (int)(num2 * 984426063) ^ -1296613007;
					continue;
				case 4u:
					num3 = 1;
					num = ((int)num2 * -1277746115) ^ -169316391;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = 1639029169;
						num4 = 1639029169;
					}
					else
					{
						num = 1523226166;
						num4 = 1523226166;
					}
					continue;
				}
				case 2u:
					num = (int)((num2 * 99604280) ^ 0x45B202F6);
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 110614950;
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
