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
			int num = -734577129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC76DA612u) % 4u)
				{
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -1581232617) ^ 0x50F66DF9;
					continue;
				case 0u:
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
					num = ((int)num2 * -965818811) ^ 0x2456D5DD;
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
		float[] array = default(float[]);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1544769609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BB6C56u) % 7u)
				{
				case 5u:
					array = new float[json.Count];
					num3 = 0;
					num = ((int)num2 * -671838525) ^ 0x1553F5A8;
					continue;
				case 4u:
					num = ((int)num2 * -775618140) ^ 0x62B9F624;
					continue;
				case 3u:
					result = array;
					num = ((int)num2 * -1644816993) ^ 0x4AAA87E3;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 793187945;
						num4 = 793187945;
					}
					else
					{
						num = 1330549571;
						num4 = 1330549571;
					}
					continue;
				}
				case 0u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 1817774133;
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
		List<Card> list = new List<Card>();
		JSONNode jSONNode = default(JSONNode);
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 2113718903;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x797A0077u) % 27u)
				{
				case 26u:
					jSONNode = json[num5];
					num = (int)((num2 * 946579991) ^ 0x3206C30D);
					continue;
				case 25u:
					num5++;
					num = (int)(num2 * 122424901) ^ -1411431736;
					continue;
				case 24u:
				{
					int num9;
					if (num3 >= jSONNode[num4].AsInt)
					{
						num = 1410111440;
						num9 = 1410111440;
					}
					else
					{
						num = 1161122043;
						num9 = 1161122043;
					}
					continue;
				}
				case 23u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num5
					});
					num = 527341695;
					continue;
				case 22u:
					flag = num4 < maxImpact * 2;
					num = 1575451679;
					continue;
				case 21u:
					result = list.ToArray();
					num = (int)(num2 * 1566108698) ^ -1748576004;
					continue;
				case 20u:
					num4 = 0;
					num = ((int)num2 * -834330813) ^ 0x5CC68AC9;
					continue;
				case 19u:
					num3++;
					num = ((int)num2 * -1009081309) ^ -120437275;
					continue;
				case 18u:
				{
					int num8;
					if (num5 >= count)
					{
						num = 375074265;
						num8 = 375074265;
					}
					else
					{
						num = 191697452;
						num8 = 191697452;
					}
					continue;
				}
				case 17u:
					flag2 = num4 < maxImpact;
					num = ((int)num2 * -1863281091) ^ 0x29539BE;
					continue;
				case 16u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1268115292;
						num7 = 1268115292;
					}
					else
					{
						num6 = 60782769;
						num7 = 60782769;
					}
					num = num6 ^ (int)(num2 * 1892639643);
					continue;
				}
				case 14u:
					num = ((int)num2 * -965917093) ^ 0x4B953C0E;
					continue;
				case 13u:
					num5 = 0;
					num = ((int)num2 * -1462570865) ^ -1557750637;
					continue;
				case 12u:
					num = ((int)num2 * -1105695487) ^ 0x5D373B6E;
					continue;
				case 11u:
					num = 1188113710;
					continue;
				case 10u:
					num = (int)(num2 * 1354016057) ^ -1882809620;
					continue;
				case 9u:
					num = 833865689;
					continue;
				case 8u:
					num = ((int)num2 * -873168127) ^ 0x36227DB8;
					continue;
				case 7u:
					num = ((int)num2 * -657056130) ^ 0x30C7D685;
					continue;
				case 6u:
					num = 106213006;
					continue;
				case 5u:
					num = (int)((num2 * 1603260745) ^ 0x23FE275D);
					continue;
				case 4u:
					num = ((int)num2 * -1808645527) ^ 0x150060D2;
					continue;
				case 2u:
					num4++;
					num = ((int)num2 * -844079579) ^ 0x25045B60;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 1457921388) ^ 0x46B6BE8A);
					continue;
				case 0u:
					num = ((int)num2 * -1923412532) ^ 0x6D442D6E;
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
			int num = -975471747;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2546ED4u) % 3u)
				{
				case 2u:
					goto IL_00b5;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_00b5:
				num = ((int)num2 * -1696019005) ^ 0x6EF8C71B;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		Card[] cards = default(Card[]);
		int num6 = default(int);
		Card card = default(Card);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1979553021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B6B3670u) % 15u)
				{
				case 14u:
					cards = Cards;
					num6 = 0;
					num = ((int)num2 * -213215685) ^ 0x6D79BFE0;
					continue;
				case 13u:
				{
					int num7;
					if (num6 < cards.Length)
					{
						num = 1098733357;
						num7 = 1098733357;
					}
					else
					{
						num = 243307582;
						num7 = 243307582;
					}
					continue;
				}
				case 12u:
					num6++;
					num = (int)((num2 * 1284574797) ^ 0x2274E4C1);
					continue;
				case 11u:
					num = (int)((num2 * 1448423229) ^ 0x19C8E223);
					continue;
				case 9u:
					num = ((int)num2 * -1391920287) ^ 0x25B35F55;
					continue;
				case 8u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1399065264;
					continue;
				}
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1926557827) ^ -2013419559;
					continue;
				case 6u:
					num = (int)(num2 * 719464909) ^ -1244936838;
					continue;
				case 4u:
					text = Rules.smethod_1(text, "\n\t");
					num3 = card.Type;
					num = (int)(num2 * 1414276906) ^ -1311885386;
					continue;
				case 3u:
					card = cards[num6];
					num = 832257790;
					continue;
				case 2u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 1255606250) ^ -1786821650;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num3 != card.Type)
					{
						num4 = -1793643481;
						num5 = -1793643481;
					}
					else
					{
						num4 = -963168112;
						num5 = -963168112;
					}
					num = num4 ^ (int)(num2 * 2046705172);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1190820393) ^ 0x3A1EB41);
					continue;
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
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = -942279299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9EF1535u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1453076047) ^ -4380169;
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 1692764872) ^ 0xCB4709B);
					continue;
				case 7u:
					flag = num3 < RiskChances.Length;
					num = -1943514498;
					continue;
				case 6u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1227205887) ^ -1756237702;
					continue;
				case 4u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -1975847837;
					continue;
				case 3u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -781938876) ^ 0x2FB277DC;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1004054323;
						num5 = 1004054323;
					}
					else
					{
						num4 = 1902889436;
						num5 = 1902889436;
					}
					num = num4 ^ (int)(num2 * 162724274);
					continue;
				}
				case 1u:
					num3 = 1;
					num = ((int)num2 * -1215948448) ^ 0x4F18A649;
					continue;
				case 0u:
					num = ((int)num2 * -1801096983) ^ 0x755709C;
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
