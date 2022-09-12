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
			int num = -504150117;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8BB84578u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1200746844) ^ -1095466388;
					continue;
				case 0u:
					num = ((int)num2 * -329189074) ^ -1474768295;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
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
			int num = -447073876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA495D01u) % 3u)
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
				num = ((int)num2 * -1703386972) ^ 0x331BDBBA;
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] result = default(float[]);
		float[] array = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = 1341846738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x542FDF99u) % 8u)
				{
				case 5u:
					result = array;
					num = ((int)num2 * -668900400) ^ -1866539706;
					continue;
				case 4u:
					num = ((int)num2 * -1371073282) ^ 0x5FC0C2F9;
					continue;
				case 3u:
					array = new float[json.Count];
					num3 = 0;
					num = ((int)num2 * -19117427) ^ -564788614;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1505343628) ^ -542643015;
					continue;
				case 1u:
					array[num3] = json[num3].AsFloat;
					num = 1158653083;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = 97330416;
						num4 = 97330416;
					}
					else
					{
						num = 763825148;
						num4 = 763825148;
					}
					continue;
				}
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
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 108343565;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x355CCD3Cu) % 23u)
				{
				case 22u:
					result = list.ToArray();
					num = (int)(num2 * 1131671982) ^ -449530555;
					continue;
				case 21u:
					list = new List<Card>();
					num = (int)((num2 * 1002023087) ^ 0x425F461E);
					continue;
				case 20u:
					num3 = 0;
					num = ((int)num2 * -1919780612) ^ 0x76D162D2;
					continue;
				case 19u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 424291416;
						num8 = 424291416;
					}
					else
					{
						num7 = 479900439;
						num8 = 479900439;
					}
					num = num7 ^ (int)(num2 * 1284285084);
					continue;
				}
				case 18u:
					num4 = 0;
					num = (int)(num2 * 1252049130) ^ -642936322;
					continue;
				case 17u:
					jSONNode = json[num4];
					num = 577924119;
					continue;
				case 16u:
					num4++;
					num = (int)(num2 * 345736809) ^ -594758467;
					continue;
				case 15u:
					num = (int)((num2 * 1879840533) ^ 0x525E6C8E);
					continue;
				case 14u:
					num = ((int)num2 * -731592576) ^ -1030784198;
					continue;
				case 13u:
					num5 = 0;
					num = (int)(num2 * 1654855164) ^ -2137925126;
					continue;
				case 12u:
					flag = num3 < maxImpact;
					num = ((int)num2 * -1488696367) ^ -837229834;
					continue;
				case 10u:
					flag2 = num4 < count;
					num = 492224631;
					continue;
				case 9u:
					flag3 = num3 < maxImpact * 2;
					num = 1699787356;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -1084209563;
						num10 = -1084209563;
					}
					else
					{
						num9 = -457076995;
						num10 = -457076995;
					}
					num = num9 ^ (int)(num2 * 1998391988);
					continue;
				}
				case 7u:
					num = ((int)num2 * -138539450) ^ 0x660253C;
					continue;
				case 6u:
				{
					int num6;
					if (num5 < jSONNode[num3].AsInt)
					{
						num = 1083411764;
						num6 = 1083411764;
					}
					else
					{
						num = 524937186;
						num6 = 524937186;
					}
					continue;
				}
				case 5u:
					num5++;
					num = (int)(num2 * 1103363421) ^ -412378360;
					continue;
				case 3u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = 80695508;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 85069825) ^ -1802192126;
					continue;
				case 1u:
					num = 120663087;
					continue;
				case 0u:
					num = 2092169845;
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
		string text = "[\n\t";
		Card card = default(Card);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = -432217250;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x859C8992u) % 14u)
				{
				case 13u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -117570561;
					continue;
				}
				case 12u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -146311517;
						num7 = -146311517;
					}
					else
					{
						num6 = -372391965;
						num7 = -372391965;
					}
					num = num6 ^ (int)(num2 * 1876465521);
					continue;
				}
				case 11u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1881900218) ^ 0x283E7147;
					continue;
				case 10u:
					flag = num4 != card.Type;
					num = (int)(num2 * 572873609) ^ -56371154;
					continue;
				case 9u:
					num3++;
					num = (int)((num2 * 1216492019) ^ 0x5E43AA5F);
					continue;
				case 8u:
				{
					int num5;
					if (num3 < cards.Length)
					{
						num = -1747460933;
						num5 = -1747460933;
					}
					else
					{
						num = -401349175;
						num5 = -401349175;
					}
					continue;
				}
				case 7u:
					num4 = card.Type;
					num = (int)((num2 * 2086455720) ^ 0x7113C4AD);
					continue;
				case 6u:
					cards = Cards;
					num = ((int)num2 * -68462302) ^ 0x608161F4;
					continue;
				case 4u:
					num4 = 0;
					num = ((int)num2 * -346149038) ^ 0x698E5F28;
					continue;
				case 3u:
					card = cards[num3];
					num = -1986910616;
					continue;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 1851382665) ^ 0x46CC485A);
					continue;
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 663231744) ^ 0x608E4490);
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

	private string RiskChancesToString()
	{
		string result = default(string);
		string string_ = default(string);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1953503435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD09FE06Cu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -2051948018) ^ -2029571259;
					continue;
				case 6u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1237213468) ^ 0x7EBE7251;
					continue;
				case 5u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num5 = 1;
					num = ((int)num2 * -1185525519) ^ 0x5F8DB047;
					continue;
				case 4u:
					flag = num5 < RiskChances.Length;
					num = -1989716596;
					continue;
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num5++;
					num = -1680023072;
					continue;
				case 2u:
					num = ((int)num2 * -250548138) ^ -1123932660;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2113040436;
						num4 = -2113040436;
					}
					else
					{
						num3 = -1953608986;
						num4 = -1953608986;
					}
					num = num3 ^ ((int)num2 * -1940065893);
					continue;
				}
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
