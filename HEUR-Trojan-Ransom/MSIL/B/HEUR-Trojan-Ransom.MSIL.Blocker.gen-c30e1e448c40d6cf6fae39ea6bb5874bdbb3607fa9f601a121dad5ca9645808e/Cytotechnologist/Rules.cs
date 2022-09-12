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
			int num = 440823968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F13365Fu) % 4u)
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
					num = ((int)num2 * -178330786) ^ 0x2DCBC578;
					continue;
				}
				case 1u:
					num = ((int)num2 * -890172440) ^ 0x71998B0D;
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
		float[] result = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = -779172905;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0DC84E1u) % 8u)
				{
				case 6u:
					array = new float[json.Count];
					num = (int)((num2 * 769308655) ^ 0x1E852BFB);
					continue;
				case 5u:
					result = array;
					num = (int)(num2 * 1728252201) ^ -1315088157;
					continue;
				case 4u:
					num3++;
					num = (int)((num2 * 1741612883) ^ 0x6C236FEE);
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -1694283620;
						num4 = -1694283620;
					}
					else
					{
						num = -611206576;
						num4 = -611206576;
					}
					continue;
				}
				case 1u:
					array[num3] = json[num3].AsFloat;
					num = -59886443;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1253499100) ^ -592623182;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		bool flag = default(bool);
		int num9 = default(int);
		int count = default(int);
		List<Card> list = default(List<Card>);
		int num8 = default(int);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag3 = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 1124724477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57D84586u) % 24u)
				{
				case 23u:
					flag = num9 < count;
					num = 1494949418;
					continue;
				case 21u:
					num9++;
					num = (int)(num2 * 326904973) ^ -983296312;
					continue;
				case 20u:
					num = 1188925855;
					continue;
				case 19u:
					count = json.Count;
					list = new List<Card>();
					num9 = 0;
					num = (int)(num2 * 761053189) ^ -2114290973;
					continue;
				case 18u:
					num8++;
					num = (int)(num2 * 407960595) ^ -678992158;
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -1446685440;
						num7 = -1446685440;
					}
					else
					{
						num6 = -545924222;
						num7 = -545924222;
					}
					num = num6 ^ (int)(num2 * 1455832201);
					continue;
				}
				case 15u:
					num = (int)(num2 * 492118486) ^ -1764178610;
					continue;
				case 14u:
					num = ((int)num2 * -1249800078) ^ -472823052;
					continue;
				case 13u:
					num = (int)(num2 * 1420607677) ^ -1718794054;
					continue;
				case 12u:
					jSONNode = json[num9];
					num = ((int)num2 * -246486626) ^ -1714617659;
					continue;
				case 11u:
					num8 = 0;
					num = ((int)num2 * -1636554388) ^ -1113428256;
					continue;
				case 10u:
				{
					int num10;
					if (num8 >= maxImpact * 2)
					{
						num = 1194264571;
						num10 = 1194264571;
					}
					else
					{
						num = 1394976410;
						num10 = 1394976410;
					}
					continue;
				}
				case 9u:
					flag2 = num3 < jSONNode[num8].AsInt;
					num = 11368199;
					continue;
				case 8u:
					num = 2002317538;
					continue;
				case 7u:
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num8)) : (maxImpact * 2 - num8)),
						Type = num9
					});
					num = 3580165;
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -1662532376) ^ 0x601635F;
					continue;
				case 5u:
					flag3 = num8 < maxImpact;
					num = 503412505;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1912708906;
						num5 = 1912708906;
					}
					else
					{
						num4 = 1907661602;
						num5 = 1907661602;
					}
					num = num4 ^ (int)(num2 * 2081598501);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1276466588) ^ -1279124684;
					continue;
				case 2u:
					num = (int)(num2 * 204193076) ^ -618143791;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1911190206) ^ -474811619;
					continue;
				case 0u:
					result = list.ToArray();
					num = (int)((num2 * 783643746) ^ 0x3AE8F4BE);
					continue;
				case 22u:
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
			int num = 630011062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7605F8AAu) % 3u)
				{
				case 1u:
					goto IL_0006;
				case 2u:
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
				num = ((int)num2 * -377320084) ^ -671832956;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		int num4 = default(int);
		Card[] cards = default(Card[]);
		Card card = default(Card);
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1543505002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3530827Fu) % 17u)
				{
				case 16u:
				{
					int num7;
					if (num4 >= cards.Length)
					{
						num = 1162659115;
						num7 = 1162659115;
					}
					else
					{
						num = 852169652;
						num7 = 852169652;
					}
					continue;
				}
				case 14u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 1430774690) ^ -2059308284;
					continue;
				case 13u:
					cards = Cards;
					num4 = 0;
					num = (int)(num2 * 1722840669) ^ -710501229;
					continue;
				case 12u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1160332786;
					continue;
				}
				case 11u:
					card = cards[num4];
					flag = num3 != card.Type;
					num = 1826852243;
					continue;
				case 10u:
					num = (int)(num2 * 291589751) ^ -175069319;
					continue;
				case 8u:
					num = ((int)num2 * -350916476) ^ -346860064;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 574016584;
						num6 = 574016584;
					}
					else
					{
						num5 = 1631476088;
						num6 = 1631476088;
					}
					num = num5 ^ (int)(num2 * 747030466);
					continue;
				}
				case 6u:
					num3 = card.Type;
					num = ((int)num2 * -1961515034) ^ -132047269;
					continue;
				case 5u:
					num = ((int)num2 * -984923624) ^ -1802798880;
					continue;
				case 4u:
					num = (int)(num2 * 1642505432) ^ -2052286893;
					continue;
				case 3u:
					num4++;
					num = ((int)num2 * -111762011) ^ 0x668B1983;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -13182888) ^ 0x2C18A82F;
					continue;
				case 1u:
					num = ((int)num2 * -1701138481) ^ 0x3B97E2CB;
					continue;
				case 0u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -758132723) ^ 0x5C693BE3;
					continue;
				case 9u:
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
		string result = default(string);
		while (true)
		{
			int num2;
			int num3;
			if (num >= RiskChances.Length)
			{
				num2 = 418101340;
				num3 = 418101340;
			}
			else
			{
				num2 = 98481376;
				num3 = 98481376;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x8B483FFu) % 6u)
				{
				case 4u:
					num++;
					num2 = (int)((num4 * 1322709925) ^ 0x5027D22A);
					continue;
				case 3u:
					result = Rules.smethod_1(string_, " ]");
					num2 = (int)((num4 * 1496433886) ^ 0x6DA123E1);
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num2 = 753292431;
					continue;
				case 0u:
					num2 = 98481376;
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
