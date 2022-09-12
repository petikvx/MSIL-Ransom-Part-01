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
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = -709650902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8BB7CA0u) % 4u)
				{
				case 2u:
					asInt = json["max-impact"].AsInt;
					num = (int)(num2 * 1629445025) ^ -1063274201;
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
					num = ((int)num2 * -1093366003) ^ -1759021258;
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
		float[] result = default(float[]);
		float[] array = default(float[]);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -81980732;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE63DD411u) % 10u)
				{
				case 9u:
					result = array;
					num = ((int)num2 * -233734264) ^ -1004023010;
					continue;
				case 7u:
					array = new float[json.Count];
					num = (int)((num2 * 501186825) ^ 0x23FC2551);
					continue;
				case 6u:
					num = ((int)num2 * -1884761884) ^ -439242201;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -260356288) ^ -1642934289;
					continue;
				case 4u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = -949756129;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1155757349;
						num5 = 1155757349;
					}
					else
					{
						num4 = 471975098;
						num5 = 471975098;
					}
					num = num4 ^ (int)(num2 * 935541672);
					continue;
				}
				case 2u:
					flag = num3 < array.Length;
					num = -2079189432;
					continue;
				case 1u:
					num = (int)((num2 * 1509701880) ^ 0x3959D13);
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
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num7 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		int count = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		while (true)
		{
			int num = 1533437072;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5428AAu) % 25u)
				{
				case 24u:
					num = ((int)num2 * -1694127182) ^ 0x7B3A509F;
					continue;
				case 23u:
					num = (int)((num2 * 1270226434) ^ 0x762D1BF9);
					continue;
				case 22u:
					flag3 = num3 < jSONNode[num7].AsInt;
					num = 428124904;
					continue;
				case 21u:
					num = 1808040245;
					continue;
				case 20u:
					jSONNode = json[num4];
					num7 = 0;
					num = (int)((num2 * 439721623) ^ 0x789FADB6);
					continue;
				case 19u:
					num = ((int)num2 * -617847287) ^ 0x3BCFB6BA;
					continue;
				case 18u:
					flag = num4 < count;
					num = 1507144133;
					continue;
				case 17u:
					num = ((int)num2 * -1183804043) ^ -1558457605;
					continue;
				case 14u:
					num7++;
					num = ((int)num2 * -815512365) ^ -972200408;
					continue;
				case 13u:
					num = ((int)num2 * -1235092630) ^ 0x390B6956;
					continue;
				case 12u:
					result = list.ToArray();
					num = ((int)num2 * -868247818) ^ -703529984;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 729938814;
						num10 = 729938814;
					}
					else
					{
						num9 = 1880612529;
						num10 = 1880612529;
					}
					num = num9 ^ (int)(num2 * 1691262708);
					continue;
				}
				case 10u:
					num = ((int)num2 * -271360777) ^ 0x16769502;
					continue;
				case 9u:
				{
					int num8;
					if (num7 >= maxImpact * 2)
					{
						num = 1485344568;
						num8 = 1485344568;
					}
					else
					{
						num = 15348502;
						num8 = 15348502;
					}
					continue;
				}
				case 8u:
					count = json.Count;
					list = new List<Card>();
					num4 = 0;
					num = ((int)num2 * -2055064410) ^ -682524808;
					continue;
				case 7u:
				{
					bool flag2 = num7 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num7)) : (maxImpact * 2 - num7)),
						Type = num4
					});
					num = 194445045;
					continue;
				}
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 820848698;
						num6 = 820848698;
					}
					else
					{
						num5 = 1632070;
						num6 = 1632070;
					}
					num = num5 ^ (int)(num2 * 739594745);
					continue;
				}
				case 5u:
					num = 17590766;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 1186140685) ^ -175447823;
					continue;
				case 3u:
					num = 567740442;
					continue;
				case 2u:
					num = (int)(num2 * 965225742) ^ -1622999093;
					continue;
				case 1u:
					num4++;
					num = (int)(num2 * 1755430060) ^ -1647695540;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -469233567) ^ -1222874796;
					continue;
				case 16u:
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
		int num4 = default(int);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = -784868538;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA72AFEC9u) % 18u)
				{
				case 17u:
					num4++;
					num = (int)((num2 * 1632066944) ^ 0x5830EC89);
					continue;
				case 16u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 1996878571) ^ 0x6AB8808B);
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (num3 == card.Type)
					{
						num6 = -614048543;
						num7 = -614048543;
					}
					else
					{
						num6 = -484995155;
						num7 = -484995155;
					}
					num = num6 ^ ((int)num2 * -1829372226);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1208530883) ^ -1410107345;
					continue;
				case 11u:
					cards = Cards;
					num = (int)((num2 * 116269052) ^ 0x28586487);
					continue;
				case 10u:
					num = (int)(num2 * 1912587993) ^ -118226480;
					continue;
				case 9u:
					text = "[\n\t";
					num = ((int)num2 * -1391545625) ^ 0x612698A0;
					continue;
				case 8u:
					num3 = 0;
					num = (int)(num2 * 972733964) ^ -71343232;
					continue;
				case 7u:
					card = cards[num4];
					num = -1837783532;
					continue;
				case 6u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -32335562;
					continue;
				}
				case 5u:
					num = ((int)num2 * -704907206) ^ 0x2B401E92;
					continue;
				case 4u:
					num4 = 0;
					num = ((int)num2 * -1305401531) ^ 0x7D3D7453;
					continue;
				case 3u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1604333662) ^ -1688205096;
					continue;
				case 2u:
				{
					int num5;
					if (num4 >= cards.Length)
					{
						num = -1432704049;
						num5 = -1432704049;
					}
					else
					{
						num = -1292707460;
						num5 = -1292707460;
					}
					continue;
				}
				case 1u:
					num3 = card.Type;
					num = ((int)num2 * -1705866345) ^ -596223516;
					continue;
				case 0u:
					num = ((int)num2 * -716977289) ^ -1586113986;
					continue;
				case 14u:
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
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 138808810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A0F9394u) % 9u)
				{
				case 8u:
					num3++;
					num = (int)((num2 * 418643474) ^ 0x50B4EE0C);
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = 115276386;
						num4 = 115276386;
					}
					else
					{
						num = 1536380418;
						num4 = 1536380418;
					}
					continue;
				}
				case 4u:
					num3 = 1;
					num = (int)((num2 * 865013003) ^ 0x1ECD7B27);
					continue;
				case 3u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -749604383) ^ -1828225031;
					continue;
				case 2u:
					num = (int)(num2 * 357179520) ^ -1433247126;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 1938058081;
					continue;
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1540785682) ^ -1003534391;
					continue;
				case 7u:
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
