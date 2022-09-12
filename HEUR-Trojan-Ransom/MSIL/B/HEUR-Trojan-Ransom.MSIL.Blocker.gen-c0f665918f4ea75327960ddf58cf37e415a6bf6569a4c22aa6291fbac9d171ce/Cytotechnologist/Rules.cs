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
			int num = 1307094561;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C426827u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -861663433) ^ 0x5E6434DA;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		int asInt = default(int);
		while (true)
		{
			int num = 710467081;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F0DC899u) % 5u)
				{
				case 3u:
					num = ((int)num2 * -491076177) ^ 0x76F2FF8C;
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
					num = (int)(num2 * 2078105333) ^ -1319628192;
					continue;
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -1527352062) ^ 0x5B795B40;
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
		int num3 = default(int);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 606402925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x577ADA93u) % 9u)
				{
				case 8u:
					num3++;
					num = (int)((num2 * 1994199612) ^ 0x417FF1C7);
					continue;
				case 7u:
					flag = num3 < array.Length;
					num = 247108266;
					continue;
				case 6u:
					num3 = 0;
					num = (int)(num2 * 286793059) ^ -866231731;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1669268094;
						num5 = -1669268094;
					}
					else
					{
						num4 = -1351577958;
						num5 = -1351577958;
					}
					num = num4 ^ ((int)num2 * -68748833);
					continue;
				}
				case 4u:
					num = ((int)num2 * -346973440) ^ 0x7CFD20DA;
					continue;
				case 3u:
					array[num3] = json[num3].AsFloat;
					num = 444466695;
					continue;
				case 1u:
					result = array;
					num = (int)((num2 * 2100012063) ^ 0x66ACB892);
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
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num6 = default(int);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 281057962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x186B8410u) % 20u)
				{
				case 19u:
					num = 1190392829;
					continue;
				case 17u:
					flag = num3 < maxImpact;
					num = ((int)num2 * -828290341) ^ 0x15F78B2C;
					continue;
				case 16u:
					num3++;
					num = ((int)num2 * -994276591) ^ -1035400896;
					continue;
				case 15u:
					num = (int)(num2 * 1973180102) ^ -1615837214;
					continue;
				case 14u:
					num4 = 0;
					num = ((int)num2 * -1171538280) ^ 0x4D08F216;
					continue;
				case 13u:
					num = (int)((num2 * 1676874501) ^ 0x161D6308);
					continue;
				case 12u:
					result = list.ToArray();
					num = ((int)num2 * -279027737) ^ -1136678962;
					continue;
				case 11u:
				{
					int num8;
					if (num6 < count)
					{
						num = 1599303360;
						num8 = 1599303360;
					}
					else
					{
						num = 665185888;
						num8 = 665185888;
					}
					continue;
				}
				case 10u:
					count = json.Count;
					list = new List<Card>();
					num6 = 0;
					num = (int)((num2 * 42645981) ^ 0x7C235937);
					continue;
				case 9u:
					num = ((int)num2 * -1369418326) ^ -2077535815;
					continue;
				case 8u:
				{
					int num7;
					if (num3 < maxImpact * 2)
					{
						num = 1834345854;
						num7 = 1834345854;
					}
					else
					{
						num = 1461241753;
						num7 = 1461241753;
					}
					continue;
				}
				case 7u:
					jSONNode = json[num6];
					num = (int)(num2 * 590182102) ^ -208507249;
					continue;
				case 6u:
					num = 229645290;
					continue;
				case 5u:
					num6++;
					num = ((int)num2 * -1864030186) ^ 0x3CB48B05;
					continue;
				case 4u:
					num = 921218299;
					continue;
				case 3u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num6
					});
					num4++;
					num = 858290790;
					continue;
				case 2u:
				{
					int num5;
					if (num4 < jSONNode[num3].AsInt)
					{
						num = 909489339;
						num5 = 909489339;
					}
					else
					{
						num = 459471051;
						num5 = 459471051;
					}
					continue;
				}
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1593020262) ^ 0x4D5C2642;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 702107545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D2AC79u) % 3u)
				{
				case 2u:
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
				num = (int)((num2 * 137725036) ^ 0x499CD98F);
			}
		}
	}

	private string CardsToString()
	{
		int num3 = default(int);
		Card card = default(Card);
		int num6 = default(int);
		string text = default(string);
		Card[] cards = default(Card[]);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 491178303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C0B75DCu) % 18u)
				{
				case 17u:
					num3 = card.Type;
					num = ((int)num2 * -1758547872) ^ -643841771;
					continue;
				case 16u:
					num6 = 0;
					num = (int)((num2 * 2124684263) ^ 0x66784F62);
					continue;
				case 15u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -565254335) ^ 0x746E9F92;
					continue;
				case 13u:
					card = cards[num6];
					flag = num3 != card.Type;
					num = 502761637;
					continue;
				case 12u:
					cards = Cards;
					num = (int)(num2 * 1515479749) ^ -609319110;
					continue;
				case 11u:
					num6++;
					num = ((int)num2 * -1826115354) ^ 0x3DC955C7;
					continue;
				case 10u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1757983856;
					continue;
				}
				case 9u:
					num = ((int)num2 * -2119372629) ^ 0x221C617;
					continue;
				case 8u:
					num = ((int)num2 * -8927122) ^ -533617039;
					continue;
				case 7u:
				{
					int num7;
					if (num6 < cards.Length)
					{
						num = 2054430431;
						num7 = 2054430431;
					}
					else
					{
						num = 493700355;
						num7 = 493700355;
					}
					continue;
				}
				case 6u:
					num = (int)(num2 * 673336021) ^ -773811863;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 683059403;
						num5 = 683059403;
					}
					else
					{
						num4 = 1270575434;
						num5 = 1270575434;
					}
					num = num4 ^ (int)(num2 * 1216474679);
					continue;
				}
				case 4u:
					num = ((int)num2 * -911016539) ^ -1972416716;
					continue;
				case 3u:
					text = "[\n\t";
					num = ((int)num2 * -410064385) ^ -669977453;
					continue;
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 795963151) ^ -815717169;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -107294599) ^ 0xA6A4EEA;
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
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1451113910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4302D424u) % 9u)
				{
				case 7u:
					num = (int)((num2 * 1173699925) ^ 0x36073BDE);
					continue;
				case 5u:
					num3 = 1;
					num = (int)(num2 * 441316874) ^ -553209698;
					continue;
				case 4u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = 2042260820;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1331324606;
						num5 = 1331324606;
					}
					else
					{
						num4 = 715541134;
						num5 = 715541134;
					}
					num = num4 ^ (int)(num2 * 450971037);
					continue;
				}
				case 2u:
					flag = num3 < RiskChances.Length;
					num = 508412801;
					continue;
				case 1u:
					num = (int)(num2 * 608380242) ^ -207112920;
					continue;
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 962666947) ^ -889616302;
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
