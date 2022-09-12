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
			int num = 1380515629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6370EDE2u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -461770973) ^ 0x33F68FC7;
					continue;
				case 0u:
					num = ((int)num2 * -1405120446) ^ 0x115058F7;
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
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = 930768776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A9C353u) % 4u)
				{
				case 3u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -1821031977) ^ -605216148;
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
					num = (int)((num2 * 174270885) ^ 0xB3B4E34);
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
		float[] array = new float[json.Count];
		int num = 0;
		float[] result = default(float[]);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -977040233;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xFE0FB330u) % 8u)
				{
				case 7u:
					num2 = (int)((num3 * 260474136) ^ 0x3D4C9889);
					continue;
				case 6u:
					array[num] = json[num].AsFloat;
					num++;
					num2 = -269671903;
					continue;
				case 4u:
					num2 = ((int)num3 * -977298070) ^ -621210909;
					continue;
				case 2u:
					result = array;
					num2 = ((int)num3 * -1816118780) ^ -904869924;
					continue;
				case 1u:
					flag = num < array.Length;
					num2 = -1755496968;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -594287386;
						num5 = -594287386;
					}
					else
					{
						num4 = -1810692678;
						num5 = -1810692678;
					}
					num2 = num4 ^ ((int)num3 * -126814344);
					continue;
				}
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
		int count = json.Count;
		bool flag2 = default(bool);
		int num3 = default(int);
		int num7 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		List<Card> list = default(List<Card>);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 244010654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0531BDu) % 25u)
				{
				case 24u:
					num = ((int)num2 * -774642937) ^ -2062269381;
					continue;
				case 23u:
					flag2 = num3 < maxImpact * 2;
					num = 1736604667;
					continue;
				case 22u:
					num = (int)(num2 * 276087369) ^ -1652964795;
					continue;
				case 21u:
					num7++;
					num = ((int)num2 * -82930689) ^ 0xE6375DA;
					continue;
				case 20u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -989311203;
						num6 = -989311203;
					}
					else
					{
						num5 = -386607934;
						num6 = -386607934;
					}
					num = num5 ^ ((int)num2 * -675557191);
					continue;
				}
				case 19u:
					num3 = 0;
					num = (int)(num2 * 1438716666) ^ -1546768865;
					continue;
				case 18u:
					jSONNode = json[num4];
					num = 238469102;
					continue;
				case 17u:
					num4 = 0;
					num = ((int)num2 * -1859461966) ^ -2133612489;
					continue;
				case 16u:
					num7 = 0;
					num = ((int)num2 * -887514138) ^ -823812043;
					continue;
				case 13u:
				{
					int num9;
					if (num4 >= count)
					{
						num = 395149425;
						num9 = 395149425;
					}
					else
					{
						num = 1068221278;
						num9 = 1068221278;
					}
					continue;
				}
				case 12u:
					num = (int)((num2 * 961784305) ^ 0x664ABFAF);
					continue;
				case 11u:
					num4++;
					num = ((int)num2 * -1061915105) ^ -1969961172;
					continue;
				case 10u:
					num = (int)((num2 * 2035460801) ^ 0x2E45A747);
					continue;
				case 9u:
					num = (int)((num2 * 667013164) ^ 0x723FA2EA);
					continue;
				case 8u:
					num = ((int)num2 * -111804451) ^ 0x5A5D57AF;
					continue;
				case 7u:
					list = new List<Card>();
					num = ((int)num2 * -122378013) ^ -773635744;
					continue;
				case 6u:
					num = 1620674781;
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 1307258602) ^ 0x12072DC5);
					continue;
				case 4u:
					num = 1420659108;
					continue;
				case 3u:
					result = list.ToArray();
					num = (int)((num2 * 1854691262) ^ 0x2971260);
					continue;
				case 2u:
				{
					int num8;
					if (num7 >= jSONNode[num3].AsInt)
					{
						num = 1818633354;
						num8 = 1818633354;
					}
					else
					{
						num = 932733910;
						num8 = 932733910;
					}
					continue;
				}
				case 1u:
				{
					bool flag = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = 232231520;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1096755526) ^ 0x17E409C6;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1298889656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEFDF1D1u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1886624668) ^ 0x589D1D3;
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
					num = ((int)num2 * -371224385) ^ 0x73BB2879;
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
		int num5 = default(int);
		string text = default(string);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -2042605104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB64F9571u) % 16u)
				{
				case 15u:
					num5 = 0;
					num = ((int)num2 * -1881973754) ^ 0x42BE71A1;
					continue;
				case 13u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1804325006;
					continue;
				}
				case 12u:
					card = cards[num3];
					num = -708430441;
					continue;
				case 10u:
					cards = Cards;
					num = (int)((num2 * 197832676) ^ 0x34E2CAA9);
					continue;
				case 9u:
					flag = num5 != card.Type;
					num = (int)(num2 * 1766615639) ^ -1004013754;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -93100988;
						num7 = -93100988;
					}
					else
					{
						num6 = -201905554;
						num7 = -201905554;
					}
					num = num6 ^ ((int)num2 * -334762209);
					continue;
				}
				case 7u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = ((int)num2 * -198457395) ^ -1182952761;
					continue;
				case 6u:
					num = (int)((num2 * 2104694836) ^ 0x50F66030);
					continue;
				case 5u:
				{
					int num4;
					if (num3 < cards.Length)
					{
						num = -451567283;
						num4 = -451567283;
					}
					else
					{
						num = -1295526459;
						num4 = -1295526459;
					}
					continue;
				}
				case 4u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 1420071098) ^ -942461214;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -249233610) ^ 0x619CD5D6;
					continue;
				case 2u:
					num = ((int)num2 * -1652388441) ^ -891645574;
					continue;
				case 1u:
					text = "[\n\t";
					num = ((int)num2 * -545038324) ^ -1088836558;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -287235264) ^ 0xA510133;
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
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num = 1;
		string result = default(string);
		while (true)
		{
			int num2 = -1213350316;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC5621D53u) % 7u)
				{
				case 6u:
				{
					int num4;
					if (num < RiskChances.Length)
					{
						num2 = -1856616619;
						num4 = -1856616619;
					}
					else
					{
						num2 = -1861520694;
						num4 = -1861520694;
					}
					continue;
				}
				case 5u:
					num2 = ((int)num3 * -1249435441) ^ -400575186;
					continue;
				case 4u:
					num2 = (int)(num3 * 200117189) ^ -1110697089;
					continue;
				case 2u:
					result = Rules.smethod_1(string_, " ]");
					num2 = ((int)num3 * -1535466419) ^ -498725756;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num++;
					num2 = -335259108;
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
