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
		Rules result = default(Rules);
		while (true)
		{
			int num = -217333697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD3D39E4u) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0016:
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
				num = (int)((num2 * 960256032) ^ 0x723D18D2);
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		int num = 0;
		float[] result = default(float[]);
		while (true)
		{
			int num2;
			int num3;
			if (num >= array.Length)
			{
				num2 = -1100850642;
				num3 = -1100850642;
			}
			else
			{
				num2 = -599338252;
				num3 = -599338252;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xED47666Au) % 6u)
				{
				case 5u:
					num2 = -599338252;
					continue;
				case 4u:
					array[num] = json[num].AsFloat;
					num2 = -1719024229;
					continue;
				case 3u:
					num++;
					num2 = ((int)num4 * -493245769) ^ -2060824114;
					continue;
				case 2u:
					result = array;
					num2 = (int)(num4 * 707227388) ^ -596804442;
					continue;
				case 1u:
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
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		bool flag2 = default(bool);
		int num8 = default(int);
		List<Card> list = default(List<Card>);
		int count = default(int);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -202858345;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84E0B1A2u) % 23u)
				{
				case 22u:
					flag = num3 < maxImpact * 2;
					num = -2046700672;
					continue;
				case 21u:
					jSONNode = json[num4];
					num = ((int)num2 * -550305718) ^ 0x7F89425C;
					continue;
				case 20u:
					num4 = 0;
					num = ((int)num2 * -1945233026) ^ 0x67877FED;
					continue;
				case 19u:
					flag2 = num3 < maxImpact;
					num = ((int)num2 * -826527589) ^ -1878820849;
					continue;
				case 17u:
					num8 = 0;
					num = ((int)num2 * -351215464) ^ 0x29E64B77;
					continue;
				case 16u:
					list = new List<Card>();
					num = (int)((num2 * 1211816715) ^ 0x4269F616);
					continue;
				case 15u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1052484698;
						num7 = -1052484698;
					}
					else
					{
						num6 = -973989183;
						num7 = -973989183;
					}
					num = num6 ^ (int)(num2 * 1115474360);
					continue;
				}
				case 14u:
					num = -56367782;
					continue;
				case 13u:
					num = ((int)num2 * -1437785717) ^ -1593296198;
					continue;
				case 12u:
					num = -231362932;
					continue;
				case 11u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num8++;
					num = -219506487;
					continue;
				case 10u:
				{
					int num9;
					if (num8 < jSONNode[num3].AsInt)
					{
						num = -364362735;
						num9 = -364362735;
					}
					else
					{
						num = -1843364716;
						num9 = -1843364716;
					}
					continue;
				}
				case 9u:
					num = -267516578;
					continue;
				case 8u:
					count = json.Count;
					num = ((int)num2 * -424511939) ^ 0x7E637217;
					continue;
				case 7u:
					num = (int)(num2 * 121611318) ^ -199119257;
					continue;
				case 5u:
				{
					int num5;
					if (num4 >= count)
					{
						num = -1621768698;
						num5 = -1621768698;
					}
					else
					{
						num = -2112970058;
						num5 = -2112970058;
					}
					continue;
				}
				case 4u:
					result = list.ToArray();
					num = ((int)num2 * -1943045600) ^ 0x36F850F5;
					continue;
				case 3u:
					num4++;
					num = ((int)num2 * -289662455) ^ 0x47094576;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 1533171583) ^ -486461097;
					continue;
				case 1u:
					num = ((int)num2 * -1509728203) ^ -791296626;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1772746734) ^ 0x4AE00EBF;
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
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num6 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 475800780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C0B3164u) % 15u)
				{
				case 14u:
					card = cards[num6];
					flag = num3 != card.Type;
					num = 1935266074;
					continue;
				case 13u:
					num = ((int)num2 * -905272431) ^ -1040615676;
					continue;
				case 12u:
					num = (int)(num2 * 1484706329) ^ -555560546;
					continue;
				case 11u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num6++;
					num = 274120915;
					continue;
				}
				case 10u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -749120668) ^ 0x36207570;
					continue;
				case 9u:
					text = "[\n\t";
					num = ((int)num2 * -179003560) ^ -1113622449;
					continue;
				case 7u:
				{
					int num7;
					if (num6 >= cards.Length)
					{
						num = 2106579345;
						num7 = 2106579345;
					}
					else
					{
						num = 470970788;
						num7 = 470970788;
					}
					continue;
				}
				case 6u:
					num3 = card.Type;
					num = (int)((num2 * 1081420059) ^ 0x2CBA5AD1);
					continue;
				case 5u:
					cards = Cards;
					num = ((int)num2 * -170362677) ^ 0x55DB17E4;
					continue;
				case 3u:
					num6 = 0;
					num = ((int)num2 * -25779339) ^ 0x2480BD65;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -2057786583;
						num5 = -2057786583;
					}
					else
					{
						num4 = -56185668;
						num5 = -56185668;
					}
					num = num4 ^ ((int)num2 * -1804636326);
					continue;
				}
				case 1u:
					num3 = 0;
					num = (int)((num2 * 1821149541) ^ 0x82A52C9);
					continue;
				case 0u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 172562406) ^ 0x56D68EF3);
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

	private string RiskChancesToString()
	{
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		string result = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1508808418;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FF8705Bu) % 9u)
				{
				case 8u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1637151109) ^ -1364054839;
					continue;
				case 7u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 426647834;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1074533702;
						num5 = 1074533702;
					}
					else
					{
						num4 = 446792209;
						num5 = 446792209;
					}
					num = num4 ^ ((int)num2 * -1895284211);
					continue;
				}
				case 3u:
					flag = num3 < RiskChances.Length;
					num = 1028540436;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 1608236443) ^ -1036884162;
					continue;
				case 1u:
					num3 = 1;
					num = (int)(num2 * 1592918410) ^ -762818337;
					continue;
				case 0u:
					num = (int)((num2 * 94248626) ^ 0x4EDAEA1C);
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
