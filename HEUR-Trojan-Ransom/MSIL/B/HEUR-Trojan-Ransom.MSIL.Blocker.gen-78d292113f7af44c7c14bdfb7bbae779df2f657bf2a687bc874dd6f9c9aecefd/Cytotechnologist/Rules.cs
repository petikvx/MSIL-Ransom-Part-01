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
			int num = -1149952991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB6FA3713u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1274315473) ^ 0xF1B3B8C);
					continue;
				case 1u:
					num = ((int)num2 * -54473234) ^ 0x6FB00895;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = -1692248946;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD82B2F75u) % 4u)
				{
				case 3u:
					asInt = json["max-impact"].AsInt;
					num = (int)((num2 * 1453754204) ^ 0x108E1ED0);
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
					num = (int)(num2 * 64665922) ^ -1066533351;
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
		float[] array = default(float[]);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = -806422429;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9F0F5C8u) % 8u)
				{
				case 7u:
					array[num3] = json[num3].AsFloat;
					num = -825322692;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 792364416) ^ -355322966;
					continue;
				case 3u:
					array = new float[json.Count];
					num = (int)((num2 * 1095107177) ^ 0x534AE5A2);
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -141863120;
						num4 = -141863120;
					}
					else
					{
						num = -470464641;
						num4 = -470464641;
					}
					continue;
				}
				case 1u:
					num3 = 0;
					num = (int)((num2 * 946902108) ^ 0x573D2796);
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -1718517935) ^ 0x76FD3FE5;
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
		int count = json.Count;
		int num7 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		bool flag3 = default(bool);
		List<Card> list = default(List<Card>);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 373597819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x387F8523u) % 22u)
				{
				case 21u:
					num = ((int)num2 * -344825144) ^ -1189948480;
					continue;
				case 19u:
					num = ((int)num2 * -348698427) ^ -2057233175;
					continue;
				case 18u:
					num7 = 0;
					num = 1024011952;
					continue;
				case 17u:
					num = ((int)num2 * -1036784040) ^ -98885933;
					continue;
				case 16u:
				{
					int num8;
					if (num7 < jSONNode[num3].AsInt)
					{
						num = 1989106236;
						num8 = 1989106236;
					}
					else
					{
						num = 1121511899;
						num8 = 1121511899;
					}
					continue;
				}
				case 15u:
					flag = num3 < maxImpact * 2;
					num = 1077594951;
					continue;
				case 14u:
					jSONNode = json[num4];
					num = (int)(num2 * 932062399) ^ -815788325;
					continue;
				case 13u:
					num7++;
					num = (int)((num2 * 1260707027) ^ 0x3675C6B4);
					continue;
				case 12u:
					num = ((int)num2 * -1236191445) ^ 0xB777C89;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 2121318371;
						num10 = 2121318371;
					}
					else
					{
						num9 = 649708634;
						num10 = 649708634;
					}
					num = num9 ^ (int)(num2 * 1933084156);
					continue;
				}
				case 10u:
					num3 = 0;
					num = ((int)num2 * -194350336) ^ 0x45515CE6;
					continue;
				case 9u:
					num = (int)((num2 * 1272949199) ^ 0x148C0970);
					continue;
				case 8u:
					list = new List<Card>();
					num4 = 0;
					num = ((int)num2 * -1671584373) ^ -198491814;
					continue;
				case 7u:
					flag3 = num4 < count;
					num = 1954818506;
					continue;
				case 5u:
				{
					bool flag2 = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = 88229430;
					continue;
				}
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -763245055;
						num6 = -763245055;
					}
					else
					{
						num5 = -1603444628;
						num6 = -1603444628;
					}
					num = num5 ^ (int)(num2 * 1540132278);
					continue;
				}
				case 3u:
					num4++;
					num = ((int)num2 * -2006237749) ^ 0x5755E46F;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -655731786) ^ 0x4B058744;
					continue;
				case 1u:
					result = list.ToArray();
					num = (int)((num2 * 902845691) ^ 0x1B108B83);
					continue;
				case 0u:
					num = 1773434309;
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
		string result = default(string);
		while (true)
		{
			int num = 1783436375;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C8AB769u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1723152530) ^ -1722125682;
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
					num = (int)(num2 * 571756697) ^ -234544164;
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
		string result = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num5 = default(int);
		while (true)
		{
			int num = -1180314369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D97F37Du) % 14u)
				{
				case 13u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1527332714) ^ -1379193745;
					continue;
				case 12u:
					num3++;
					num = (int)((num2 * 878307860) ^ 0x6B8E891D);
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 20377123;
						num7 = 20377123;
					}
					else
					{
						num6 = 1885252356;
						num7 = 1885252356;
					}
					num = num6 ^ (int)(num2 * 1453595775);
					continue;
				}
				case 9u:
					card = cards[num3];
					flag = num5 != card.Type;
					num = -228838630;
					continue;
				case 8u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = (int)((num2 * 1941230675) ^ 0x2E32451A);
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 966377616) ^ -565854843;
					continue;
				case 6u:
					num = (int)(num2 * 1014816759) ^ -942290634;
					continue;
				case 4u:
					num5 = 0;
					num = (int)(num2 * 897456216) ^ -2024702029;
					continue;
				case 3u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -293431993;
					continue;
				}
				case 2u:
					num = (int)(num2 * 1382119193) ^ -1023092180;
					continue;
				case 1u:
					cards = Cards;
					num = ((int)num2 * -2127110815) ^ 0x4CCFC83D;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < cards.Length)
					{
						num = -1061368370;
						num4 = -1061368370;
					}
					else
					{
						num = -993089012;
						num4 = -993089012;
					}
					continue;
				}
				case 10u:
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
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 1407843165;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F2A3BEDu) % 7u)
				{
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2017626659;
						num5 = -2017626659;
					}
					else
					{
						num4 = -150906076;
						num5 = -150906076;
					}
					num = num4 ^ ((int)num2 * -610046960);
					continue;
				}
				case 4u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1837050302) ^ 0x48B4F0BB;
					continue;
				case 3u:
					flag = num3 < RiskChances.Length;
					num = 1065190767;
					continue;
				case 2u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -1927888490) ^ -1744412028;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = 370275748;
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
