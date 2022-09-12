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
			int num = 817278206;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EC49484u) % 3u)
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
				num = (int)((num2 * 689345871) ^ 0x5A139DFC);
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = -144801124;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA210857u) % 4u)
				{
				case 3u:
					asInt = json["max-impact"].AsInt;
					num = (int)((num2 * 257670117) ^ 0x366F7536);
					continue;
				case 2u:
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
					num = ((int)num2 * -854309990) ^ 0xA9A82FA;
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
		int num3 = default(int);
		float[] array = default(float[]);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = -244644933;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3C9F515u) % 11u)
				{
				case 10u:
					num3 = 0;
					num = ((int)num2 * -593747180) ^ -1998798599;
					continue;
				case 9u:
					num = (int)(num2 * 11496410) ^ -733154058;
					continue;
				case 8u:
					array = new float[json.Count];
					num = (int)((num2 * 2032161696) ^ 0x2B86A8D7);
					continue;
				case 7u:
					num = (int)((num2 * 1172419054) ^ 0x7F740A68);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1328746555;
						num5 = -1328746555;
					}
					else
					{
						num4 = -1623607695;
						num5 = -1623607695;
					}
					num = num4 ^ (int)(num2 * 2141737848);
					continue;
				}
				case 5u:
					num3++;
					num = ((int)num2 * -226492861) ^ 0x3991A180;
					continue;
				case 4u:
					flag = num3 < array.Length;
					num = -436402097;
					continue;
				case 3u:
					array[num3] = json[num3].AsFloat;
					num = -737458459;
					continue;
				case 1u:
					result = array;
					num = (int)(num2 * 1693169901) ^ -706287614;
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
		int num = 0;
		bool flag2 = default(bool);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		bool flag3 = default(bool);
		int num4 = default(int);
		Card[] result = default(Card[]);
		while (true)
		{
			int num2 = 589627923;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1ADB5927u) % 20u)
				{
				case 19u:
					flag2 = num5 < maxImpact;
					num2 = 27050081;
					continue;
				case 18u:
					num++;
					num2 = (int)(num3 * 1836275344) ^ -596811743;
					continue;
				case 16u:
					jSONNode = json[num];
					num5 = 0;
					num2 = 152838025;
					continue;
				case 15u:
					num5++;
					num2 = (int)((num3 * 777871759) ^ 0x6F51E504);
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -1922501567;
						num8 = -1922501567;
					}
					else
					{
						num7 = -1842008218;
						num8 = -1842008218;
					}
					num2 = num7 ^ (int)(num3 * 157434083);
					continue;
				}
				case 13u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 2029089453;
						num10 = 2029089453;
					}
					else
					{
						num9 = 1557633797;
						num10 = 1557633797;
					}
					num2 = num9 ^ ((int)num3 * -807709223);
					continue;
				}
				case 11u:
					flag3 = num4 < jSONNode[num5].AsInt;
					num2 = 548909390;
					continue;
				case 10u:
				{
					int num6;
					if (num < count)
					{
						num2 = 1681195463;
						num6 = 1681195463;
					}
					else
					{
						num2 = 1332369250;
						num6 = 1332369250;
					}
					continue;
				}
				case 9u:
					num2 = ((int)num3 * -931760514) ^ 0x550EF121;
					continue;
				case 8u:
					num4++;
					num2 = ((int)num3 * -222482652) ^ 0x5C7050;
					continue;
				case 7u:
					num2 = (int)((num3 * 42579250) ^ 0x164A675B);
					continue;
				case 6u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num
					});
					num2 = 857261982;
					continue;
				case 5u:
					result = list.ToArray();
					num2 = (int)(num3 * 371088448) ^ -1436632089;
					continue;
				case 4u:
					num2 = ((int)num3 * -1909750478) ^ -1056954583;
					continue;
				case 3u:
					num2 = (int)((num3 * 86317971) ^ 0x668D5EA9);
					continue;
				case 2u:
					flag = num5 < maxImpact * 2;
					num2 = 1107951109;
					continue;
				case 1u:
					num4 = 0;
					num2 = (int)(num3 * 2055278020) ^ -1501958224;
					continue;
				case 0u:
					num2 = 623570090;
					continue;
				case 17u:
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
			int num = -38623974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8B6855Bu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -480924074) ^ -848781727;
					continue;
				case 1u:
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
					num = ((int)num2 * -753247003) ^ -1754143539;
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
		int num4 = default(int);
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		int num3 = default(int);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = 1527006255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x626FC904u) % 18u)
				{
				case 17u:
					num = (int)(num2 * 1476604908) ^ -1905773547;
					continue;
				case 16u:
					num4 = 0;
					num = (int)((num2 * 1928880761) ^ 0x75291B6D);
					continue;
				case 14u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1223115048) ^ 0xA61A1CA;
					continue;
				case 13u:
					num = ((int)num2 * -815404783) ^ 0x7381A582;
					continue;
				case 12u:
					flag = num3 != card.Type;
					num = ((int)num2 * -1928141553) ^ 0x7CAB4826;
					continue;
				case 11u:
					num4++;
					num = (int)((num2 * 345013473) ^ 0x4805E6E2);
					continue;
				case 9u:
					text = "[\n\t";
					num = ((int)num2 * -702092818) ^ 0x159E0990;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1963223632;
						num7 = 1963223632;
					}
					else
					{
						num6 = 739822791;
						num7 = 739822791;
					}
					num = num6 ^ (int)(num2 * 2115121997);
					continue;
				}
				case 7u:
				{
					int num5;
					if (num4 < cards.Length)
					{
						num = 1288884598;
						num5 = 1288884598;
					}
					else
					{
						num = 1778805374;
						num5 = 1778805374;
					}
					continue;
				}
				case 6u:
					cards = Cards;
					num = ((int)num2 * -1338674646) ^ 0x45E02F8C;
					continue;
				case 5u:
					num = (int)(num2 * 985639518) ^ -2012679124;
					continue;
				case 4u:
					card = cards[num4];
					num = 1351524531;
					continue;
				case 3u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 466963423;
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)((num2 * 14497351) ^ 0x12E37B9A);
					continue;
				case 1u:
					num3 = card.Type;
					num = ((int)num2 * -1151771135) ^ -1940559050;
					continue;
				case 0u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -2059711029) ^ -986866633;
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

	private string RiskChancesToString()
	{
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num = 1;
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -23055525;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x9AF5D0C7u) % 8u)
				{
				case 6u:
					result = Rules.smethod_1(string_, " ]");
					num2 = (int)(num3 * 1559266622) ^ -926873620;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2143788810;
						num5 = -2143788810;
					}
					else
					{
						num4 = -737089895;
						num5 = -737089895;
					}
					num2 = num4 ^ ((int)num3 * -1401194376);
					continue;
				}
				case 4u:
					num2 = ((int)num3 * -1181507424) ^ 0x2D3AC31D;
					continue;
				case 2u:
					flag = num < RiskChances.Length;
					num2 = -179686342;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num2 = -1194998433;
					continue;
				case 0u:
					num++;
					num2 = ((int)num3 * -1532691976) ^ -414400035;
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
