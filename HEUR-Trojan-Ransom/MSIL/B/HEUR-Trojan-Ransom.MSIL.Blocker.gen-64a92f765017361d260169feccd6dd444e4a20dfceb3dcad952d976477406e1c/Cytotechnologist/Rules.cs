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
		int asInt = default(int);
		while (true)
		{
			int num = -2010206696;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9318C79u) % 5u)
				{
				case 4u:
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
					num = ((int)num2 * -1989467658) ^ 0x5130F14E;
					continue;
				case 3u:
					num = (int)(num2 * 1406391622) ^ -1841746388;
					continue;
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = (int)((num2 * 506284310) ^ 0x2103BFC6);
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
		float[] array = new float[json.Count];
		bool flag = default(bool);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1315936192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E8BEA8Du) % 9u)
				{
				case 7u:
					num = ((int)num2 * -515243332) ^ 0x46AAA8AB;
					continue;
				case 6u:
					flag = num3 < array.Length;
					num = 1177178067;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2085974602;
						num5 = -2085974602;
					}
					else
					{
						num4 = -394822720;
						num5 = -394822720;
					}
					num = num4 ^ (int)(num2 * 1692853704);
					continue;
				}
				case 3u:
					num = ((int)num2 * -2037445854) ^ -1455312404;
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -573810624) ^ 0x44FB0EBC;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -868942938) ^ -369373761;
					continue;
				case 0u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 1770659131;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		List<Card> list = new List<Card>();
		int num = 0;
		int num5 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		while (true)
		{
			bool flag = num < count;
			int num2 = 1593805090;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x40076821u) % 20u)
				{
				case 19u:
					num5++;
					num2 = (int)((num3 * 1422326298) ^ 0x311A9955);
					continue;
				case 18u:
					num++;
					num2 = (int)(num3 * 1341271882) ^ -1669967182;
					continue;
				case 17u:
					num4 = 0;
					num2 = (int)(num3 * 1429127045) ^ -1546145076;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1447138376;
						num8 = 1447138376;
					}
					else
					{
						num7 = 644310670;
						num8 = 644310670;
					}
					num2 = num7 ^ (int)(num3 * 1242414958);
					continue;
				}
				case 14u:
					num2 = (int)(num3 * 1200073993) ^ -1089877291;
					continue;
				case 13u:
					num2 = ((int)num3 * -6323109) ^ -426377051;
					continue;
				case 12u:
					num2 = (int)(num3 * 142873078) ^ -1621459021;
					continue;
				case 11u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -2102036889;
						num10 = -2102036889;
					}
					else
					{
						num9 = -1187434499;
						num10 = -1187434499;
					}
					num2 = num9 ^ (int)(num3 * 89009319);
					continue;
				}
				case 10u:
					num4++;
					num2 = (int)((num3 * 807766491) ^ 0x2B9B2E3B);
					continue;
				case 9u:
					num2 = ((int)num3 * -1502598295) ^ 0x52F2918A;
					continue;
				case 8u:
					num2 = 440679058;
					continue;
				case 7u:
					num2 = 2125410424;
					continue;
				case 5u:
					num2 = 287638897;
					continue;
				case 4u:
				{
					bool flag3 = num5 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num
					});
					num2 = 743374943;
					continue;
				}
				case 3u:
					jSONNode = json[num];
					num5 = 0;
					num2 = 746794439;
					continue;
				case 2u:
					flag2 = num5 < maxImpact * 2;
					num2 = 693523569;
					continue;
				case 1u:
					result = list.ToArray();
					num2 = (int)(num3 * 1243030876) ^ -1500042295;
					continue;
				case 0u:
				{
					int num6;
					if (num4 >= jSONNode[num5].AsInt)
					{
						num2 = 1437529896;
						num6 = 1437529896;
					}
					else
					{
						num2 = 969984800;
						num6 = 969984800;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1352928427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3CFB99Au) % 4u)
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
					num = ((int)num2 * -577871462) ^ -217012056;
					continue;
				case 0u:
					num = ((int)num2 * -262211949) ^ -157683965;
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

	private string CardsToString()
	{
		int num3 = default(int);
		Card[] cards = default(Card[]);
		Card card = default(Card);
		int num5 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1977638221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F02F8F8u) % 13u)
				{
				case 12u:
				{
					int num4;
					if (num3 < cards.Length)
					{
						num = 1328440450;
						num4 = 1328440450;
					}
					else
					{
						num = 1552404377;
						num4 = 1552404377;
					}
					continue;
				}
				case 11u:
					cards = Cards;
					num3 = 0;
					num = (int)(num2 * 40222800) ^ -3867094;
					continue;
				case 9u:
				{
					card = cards[num3];
					int num6;
					if (num5 != card.Type)
					{
						num = 1920064800;
						num6 = 1920064800;
					}
					else
					{
						num = 750861465;
						num6 = 750861465;
					}
					continue;
				}
				case 8u:
					num5 = 0;
					num = (int)((num2 * 886938569) ^ 0x1822D47);
					continue;
				case 7u:
					num = (int)((num2 * 14323230) ^ 0x52EA12D3);
					continue;
				case 6u:
					text = "[\n\t";
					num = (int)(num2 * 1114947203) ^ -174666288;
					continue;
				case 5u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 633172442) ^ 0x7A11F7C1);
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -2116495647) ^ 0x52E51D6C;
					continue;
				case 2u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = ((int)num2 * -1598214184) ^ 0x4153AAD9;
					continue;
				case 1u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1903822862;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1603478456) ^ 0x1AC43C2C;
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
			int num = -24734390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9590387u) % 9u)
				{
				case 8u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1551332587) ^ -439273443;
					continue;
				case 7u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -1521972736) ^ -530953615;
					continue;
				case 6u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = -951187897;
					continue;
				case 4u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = -1365199421;
						num4 = -1365199421;
					}
					else
					{
						num = -838362032;
						num4 = -838362032;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -1994693270) ^ 0x2382EACF;
					continue;
				case 1u:
					num = (int)(num2 * 470606527) ^ -976703150;
					continue;
				case 0u:
					num3 = 1;
					num = (int)(num2 * 220932211) ^ -1981677647;
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
