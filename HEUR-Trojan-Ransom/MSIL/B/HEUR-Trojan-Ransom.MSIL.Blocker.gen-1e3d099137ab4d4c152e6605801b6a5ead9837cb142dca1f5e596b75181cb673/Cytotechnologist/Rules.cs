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
			int num = 691222499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x799A493u) % 3u)
				{
				case 1u:
					goto IL_0113;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0113:
				num = ((int)num2 * -1529947304) ^ 0x48239ABD;
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = default(float[]);
		bool flag = default(bool);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 2089164000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x167F51C5u) % 9u)
				{
				case 7u:
					array = new float[json.Count];
					num = ((int)num2 * -1267843157) ^ -966131753;
					continue;
				case 6u:
					num = (int)(num2 * 1945797958) ^ -1907822905;
					continue;
				case 4u:
					flag = num3 < array.Length;
					num = 1434719203;
					continue;
				case 3u:
					result = array;
					num = ((int)num2 * -1961259805) ^ -1414304575;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 539708889;
						num5 = 539708889;
					}
					else
					{
						num4 = 501271193;
						num5 = 501271193;
					}
					num = num4 ^ ((int)num2 * -2126110853);
					continue;
				}
				case 1u:
					num3 = 0;
					num = (int)(num2 * 356200623) ^ -1345103337;
					continue;
				case 0u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 183341841;
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
		int num7 = default(int);
		bool flag2 = default(bool);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		List<Card> list = default(List<Card>);
		int num8 = default(int);
		int count = default(int);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -304446636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA262947Eu) % 21u)
				{
				case 20u:
					num7++;
					num = ((int)num2 * -138358048) ^ -693369431;
					continue;
				case 19u:
					flag2 = num3 < maxImpact;
					num = -1790836780;
					continue;
				case 18u:
					jSONNode = json[num7];
					num3 = 0;
					num = (int)(num2 * 393606848) ^ -23877212;
					continue;
				case 17u:
					num = (int)((num2 * 2106031407) ^ 0x64822A9B);
					continue;
				case 16u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num7
					});
					num = -745747242;
					continue;
				case 15u:
					num = (int)(num2 * 1628667819) ^ -1853875240;
					continue;
				case 13u:
					num = (int)((num2 * 464207919) ^ 0x74BBC1FA);
					continue;
				case 12u:
					num7 = 0;
					num = (int)(num2 * 773259917) ^ -93961862;
					continue;
				case 11u:
					num8 = 0;
					num = -890745466;
					continue;
				case 10u:
					num8++;
					num = (int)(num2 * 1587879634) ^ -220715946;
					continue;
				case 9u:
				{
					int num9;
					if (num7 < count)
					{
						num = -997349672;
						num9 = -997349672;
					}
					else
					{
						num = -655011363;
						num9 = -655011363;
					}
					continue;
				}
				case 8u:
					num = -319242985;
					continue;
				case 7u:
					count = json.Count;
					list = new List<Card>();
					num = (int)((num2 * 1995266661) ^ 0x7E7A3B73);
					continue;
				case 5u:
					flag = num8 < jSONNode[num3].AsInt;
					num = -304055017;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1723731557;
						num6 = 1723731557;
					}
					else
					{
						num5 = 1670642938;
						num6 = 1670642938;
					}
					num = num5 ^ (int)(num2 * 583359833);
					continue;
				}
				case 3u:
					result = list.ToArray();
					num = (int)((num2 * 19122697) ^ 0x437D7809);
					continue;
				case 2u:
					num = ((int)num2 * -1640530337) ^ 0x59E050AC;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -2116626011) ^ 0x7E4CEC90;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= maxImpact * 2)
					{
						num = -1053715168;
						num4 = -1053715168;
					}
					else
					{
						num = -1971407974;
						num4 = -1971407974;
					}
					continue;
				}
				case 14u:
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
			int num = -1776164384;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA27CFFC4u) % 3u)
				{
				case 1u:
					goto IL_0006;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0006:
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
				num = ((int)num2 * -533029281) ^ -312457204;
			}
		}
	}

	private string CardsToString()
	{
		int num5 = default(int);
		Card card = default(Card);
		int num3 = default(int);
		string text = default(string);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = 629404500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12A8900Au) % 17u)
				{
				case 16u:
				{
					int num6;
					int num7;
					if (num5 == card.Type)
					{
						num6 = 1168572599;
						num7 = 1168572599;
					}
					else
					{
						num6 = 988653807;
						num7 = 988653807;
					}
					num = num6 ^ (int)(num2 * 1765302752);
					continue;
				}
				case 14u:
					num3++;
					num = (int)(num2 * 522620109) ^ -1662540141;
					continue;
				case 13u:
					num = (int)(num2 * 437756700) ^ -812990740;
					continue;
				case 12u:
					num = (int)(num2 * 118939614) ^ -279574197;
					continue;
				case 10u:
					num = (int)((num2 * 977960928) ^ 0x2F336A25);
					continue;
				case 9u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = (int)((num2 * 1248729793) ^ 0xC10BF6F);
					continue;
				case 8u:
					cards = Cards;
					num3 = 0;
					num = ((int)num2 * -1304673774) ^ -2014063620;
					continue;
				case 7u:
					num = ((int)num2 * -991833756) ^ 0x44100A55;
					continue;
				case 6u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1482114003) ^ 0x681F6D22;
					continue;
				case 5u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 346719850;
					continue;
				}
				case 4u:
					card = cards[num3];
					num = 981291147;
					continue;
				case 3u:
					num5 = 0;
					num = (int)(num2 * 1567127901) ^ -1420953660;
					continue;
				case 2u:
					text = "[\n\t";
					num = (int)(num2 * 1293582846) ^ -918545522;
					continue;
				case 1u:
					num = ((int)num2 * -599704836) ^ -1724187057;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < cards.Length)
					{
						num = 504278264;
						num4 = 504278264;
					}
					else
					{
						num = 515613541;
						num4 = 515613541;
					}
					continue;
				}
				case 15u:
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
		int num = 1;
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num2 = -262628418;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x92E65233u) % 9u)
				{
				case 8u:
					flag = num < RiskChances.Length;
					num2 = -625098115;
					continue;
				case 6u:
					num2 = (int)((num3 * 1327393154) ^ 0x3D22C7F2);
					continue;
				case 5u:
					num2 = ((int)num3 * -1838956991) ^ -204378019;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1128486274;
						num5 = -1128486274;
					}
					else
					{
						num4 = -369760392;
						num5 = -369760392;
					}
					num2 = num4 ^ ((int)num3 * -2095185558);
					continue;
				}
				case 3u:
					num++;
					num2 = (int)((num3 * 901959775) ^ 0x27471CB9);
					continue;
				case 1u:
					result = Rules.smethod_1(string_, " ]");
					num2 = (int)(num3 * 425594119) ^ -1803966225;
					continue;
				case 0u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num2 = -1125616132;
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
