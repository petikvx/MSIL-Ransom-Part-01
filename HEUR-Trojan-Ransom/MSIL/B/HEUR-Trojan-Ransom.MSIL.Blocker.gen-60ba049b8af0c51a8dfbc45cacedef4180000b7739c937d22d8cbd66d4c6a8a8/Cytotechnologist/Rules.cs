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
			int num = -1344618477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94FCB26Bu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1572813138) ^ 0xA1350A6);
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = 886303683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E28EF68u) % 4u)
				{
				case 3u:
					asInt = json["max-impact"].AsInt;
					num = (int)(num2 * 1133215625) ^ -535762813;
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
					num = ((int)num2 * -1745149690) ^ -436271143;
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
		float[] result = default(float[]);
		float[] array = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = 1621406674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C181E73u) % 8u)
				{
				case 5u:
					result = array;
					num = (int)(num2 * 1402221887) ^ -1026710969;
					continue;
				case 4u:
					num = ((int)num2 * -85350605) ^ -1359068361;
					continue;
				case 3u:
					array[num3] = json[num3].AsFloat;
					num = 1671351417;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 1172230195) ^ -434163099;
					continue;
				case 1u:
					array = new float[json.Count];
					num3 = 0;
					num = ((int)num2 * -1621907228) ^ -1699890253;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = 14694336;
						num4 = 14694336;
					}
					else
					{
						num = 2090390430;
						num4 = 2090390430;
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
		bool flag3 = default(bool);
		int num9 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		bool flag4 = default(bool);
		int num3 = default(int);
		List<Card> list = default(List<Card>);
		int count = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -1367007632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB43F6E3Cu) % 27u)
				{
				case 26u:
					flag3 = num9 < jSONNode[num4].AsInt;
					num = -319152843;
					continue;
				case 25u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -1933764343;
						num11 = -1933764343;
					}
					else
					{
						num10 = -1025402014;
						num11 = -1025402014;
					}
					num = num10 ^ (int)(num2 * 1714832638);
					continue;
				}
				case 24u:
					flag4 = num4 < maxImpact * 2;
					num = -2115921770;
					continue;
				case 23u:
					num3++;
					num = ((int)num2 * -245341135) ^ -1025653731;
					continue;
				case 22u:
					num9++;
					num = (int)((num2 * 530099836) ^ 0x70648B78);
					continue;
				case 21u:
					num = (int)(num2 * 1472235799) ^ -113221539;
					continue;
				case 20u:
					list = new List<Card>();
					num = (int)((num2 * 27506057) ^ 0x564EBA2A);
					continue;
				case 19u:
					num = ((int)num2 * -122180637) ^ 0x6DA57A5;
					continue;
				case 18u:
					num = ((int)num2 * -1475177263) ^ 0x611827CB;
					continue;
				case 17u:
					num9 = 0;
					num = ((int)num2 * -1166744772) ^ 0x3293F40;
					continue;
				case 16u:
					count = json.Count;
					num = ((int)num2 * -1767997462) ^ 0x14B36C45;
					continue;
				case 15u:
					num = (int)((num2 * 634066773) ^ 0x403161A9);
					continue;
				case 14u:
					flag = num3 < count;
					num = -1674183410;
					continue;
				case 13u:
					num = (int)(num2 * 492272112) ^ -616395361;
					continue;
				case 11u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num3
					});
					num = -697377015;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -1898700232;
						num8 = -1898700232;
					}
					else
					{
						num7 = -67766444;
						num8 = -67766444;
					}
					num = num7 ^ ((int)num2 * -538644801);
					continue;
				}
				case 9u:
					result = list.ToArray();
					num = (int)(num2 * 1943200359) ^ -1458631906;
					continue;
				case 8u:
					num = -1494912777;
					continue;
				case 7u:
					num = ((int)num2 * -2065561362) ^ 0x3F1DBD2F;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -1430134322) ^ 0x2F31E861;
					continue;
				case 4u:
					flag2 = num4 < maxImpact;
					num = (int)((num2 * 1949528295) ^ 0x5F84C9E6);
					continue;
				case 3u:
					num = -1759667461;
					continue;
				case 2u:
					num4++;
					num = (int)(num2 * 1289700223) ^ -899247857;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -714027494;
						num6 = -714027494;
					}
					else
					{
						num5 = -1682087118;
						num6 = -1682087118;
					}
					num = num5 ^ (int)(num2 * 71168284);
					continue;
				}
				case 0u:
					jSONNode = json[num3];
					num4 = 0;
					num = -998817647;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -696392522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA2CC83Bu) % 4u)
				{
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
					num = ((int)num2 * -174837089) ^ -196462832;
					continue;
				case 0u:
					num = (int)(num2 * 1377875500) ^ -688831787;
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

	private string CardsToString()
	{
		string text = "[\n\t";
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -985580817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83C19053u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -1956209937) ^ -293087932;
					continue;
				case 13u:
					card = cards[num3];
					num = -1220313115;
					continue;
				case 12u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1162021437;
					continue;
				}
				case 11u:
					flag = num4 != card.Type;
					num = ((int)num2 * -983999660) ^ -3908567;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 11144395;
						num7 = 11144395;
					}
					else
					{
						num6 = 182163961;
						num7 = 182163961;
					}
					num = num6 ^ ((int)num2 * -1326815328);
					continue;
				}
				case 9u:
					text = Rules.smethod_1(text, "\n\t");
					num4 = card.Type;
					num = (int)((num2 * 1559207652) ^ 0x623C72E3);
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 2127372089) ^ 0x66A57F28);
					continue;
				case 7u:
					num = ((int)num2 * -728878353) ^ 0x11665DF7;
					continue;
				case 6u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -37006939) ^ 0x136F7B4C;
					continue;
				case 3u:
					num = ((int)num2 * -1873915759) ^ -454008771;
					continue;
				case 2u:
				{
					int num5;
					if (num3 < cards.Length)
					{
						num = -537352738;
						num5 = -537352738;
					}
					else
					{
						num = -1544952032;
						num5 = -1544952032;
					}
					continue;
				}
				case 1u:
					num4 = 0;
					num = ((int)num2 * -1042749221) ^ 0x6083449C;
					continue;
				case 0u:
					cards = Cards;
					num3 = 0;
					num = ((int)num2 * -1992941774) ^ -1687038374;
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
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num = 1;
		string result = default(string);
		while (true)
		{
			int num2 = 1641013376;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x470DB20Cu) % 8u)
				{
				case 7u:
					num++;
					num2 = ((int)num3 * -1022849610) ^ 0x59E5868;
					continue;
				case 6u:
				{
					int num4;
					if (num >= RiskChances.Length)
					{
						num2 = 875323404;
						num4 = 875323404;
					}
					else
					{
						num2 = 1021114967;
						num4 = 1021114967;
					}
					continue;
				}
				case 4u:
					num2 = (int)((num3 * 83511571) ^ 0x56E66FE6);
					continue;
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num2 = 50597219;
					continue;
				case 2u:
					num2 = ((int)num3 * -2115591175) ^ 0x44FCD987;
					continue;
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num2 = ((int)num3 * -1901308407) ^ -460551562;
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
