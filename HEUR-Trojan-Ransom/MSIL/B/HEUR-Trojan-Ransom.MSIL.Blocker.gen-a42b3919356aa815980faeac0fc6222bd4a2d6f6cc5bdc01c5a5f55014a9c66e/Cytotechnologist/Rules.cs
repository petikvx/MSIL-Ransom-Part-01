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
			int num = 124071598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BD2B9E0u) % 3u)
				{
				case 2u:
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
				num = (int)((num2 * 1939392058) ^ 0x3DDBA23D);
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = default(float[]);
		int num3 = default(int);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 348975730;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7246FFB8u) % 9u)
				{
				case 8u:
					array = new float[json.Count];
					num3 = 0;
					num = (int)((num2 * 1971727035) ^ 0xB3CFDF2);
					continue;
				case 7u:
					num = (int)(num2 * 457116493) ^ -879469208;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2017540264;
						num5 = 2017540264;
					}
					else
					{
						num4 = 1478960564;
						num5 = 1478960564;
					}
					num = num4 ^ (int)(num2 * 1990254006);
					continue;
				}
				case 4u:
					flag = num3 < array.Length;
					num = 1048604147;
					continue;
				case 3u:
					result = array;
					num = ((int)num2 * -651691138) ^ -2086009366;
					continue;
				case 2u:
					array[num3] = json[num3].AsFloat;
					num = 1440712866;
					continue;
				case 1u:
					num3++;
					num = (int)(num2 * 569562510) ^ -322853392;
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
		int num4 = default(int);
		int num3 = default(int);
		int num7 = default(int);
		bool flag3 = default(bool);
		int count = default(int);
		List<Card> list = default(List<Card>);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		bool flag = default(bool);
		while (true)
		{
			int num = 991050244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1450F190u) % 27u)
				{
				case 26u:
					num4++;
					num = (int)(num2 * 613929572) ^ -35945571;
					continue;
				case 25u:
					num3 = 0;
					num = (int)(num2 * 303357599) ^ -1945411420;
					continue;
				case 24u:
					num = ((int)num2 * -1361670613) ^ 0x22AA4142;
					continue;
				case 23u:
					num = 1866175412;
					continue;
				case 22u:
					num7 = 0;
					num = (int)((num2 * 1694899362) ^ 0x6E0E10BD);
					continue;
				case 21u:
					flag3 = num4 < count;
					num = 1836444173;
					continue;
				case 20u:
					count = json.Count;
					list = new List<Card>();
					num = ((int)num2 * -1326807452) ^ 0x39381CD;
					continue;
				case 18u:
					num7++;
					num = (int)((num2 * 586121496) ^ 0x6F05F72D);
					continue;
				case 17u:
					num4 = 0;
					num = (int)((num2 * 1107041916) ^ 0x27422B7F);
					continue;
				case 16u:
					jSONNode = json[num4];
					num = ((int)num2 * -955812809) ^ 0x3A51F417;
					continue;
				case 15u:
				{
					int num10;
					if (num7 < jSONNode[num3].AsInt)
					{
						num = 184641713;
						num10 = 184641713;
					}
					else
					{
						num = 315807027;
						num10 = 315807027;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -1283555854) ^ 0x3454BC9F;
					continue;
				case 12u:
					result = list.ToArray();
					num = ((int)num2 * -262630107) ^ 0x48323B36;
					continue;
				case 11u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -457078078;
						num9 = -457078078;
					}
					else
					{
						num8 = -178107346;
						num9 = -178107346;
					}
					num = num8 ^ ((int)num2 * -723445241);
					continue;
				}
				case 10u:
					num = 1091666273;
					continue;
				case 9u:
					num3++;
					num = ((int)num2 * -1174450317) ^ 0x3B66C6C7;
					continue;
				case 8u:
					num = ((int)num2 * -1387015365) ^ -775524117;
					continue;
				case 7u:
					num = ((int)num2 * -1217837339) ^ 0x55E621AB;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 1358624243;
						num6 = 1358624243;
					}
					else
					{
						num5 = 522405522;
						num6 = 522405522;
					}
					num = num5 ^ (int)(num2 * 216388015);
					continue;
				}
				case 5u:
				{
					bool flag2 = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = 813328192;
					continue;
				}
				case 4u:
					num = ((int)num2 * -1051316099) ^ 0xC705094;
					continue;
				case 3u:
					num = (int)((num2 * 1757115433) ^ 0x35ACFF8D);
					continue;
				case 2u:
					num = ((int)num2 * -443223040) ^ 0x3929D3F5;
					continue;
				case 1u:
					num = 966098292;
					continue;
				case 0u:
					flag = num3 < maxImpact * 2;
					num = 1230162064;
					continue;
				case 19u:
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
			int num = 1992379502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38238BAFu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1899306748) ^ 0x4EC5B0BB;
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
					num = ((int)num2 * -1366122891) ^ 0x55E3FD61;
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
		Card[] cards = default(Card[]);
		bool flag = default(bool);
		int num3 = default(int);
		Card card = default(Card);
		int num4 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -958249337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6A5D1DBu) % 20u)
				{
				case 19u:
					num = ((int)num2 * -1531025064) ^ 0x72D39F18;
					continue;
				case 18u:
					cards = Cards;
					num = (int)((num2 * 1616449206) ^ 0xCF24A6E);
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 923349607;
						num7 = 923349607;
					}
					else
					{
						num6 = 1607089306;
						num7 = 1607089306;
					}
					num = num6 ^ (int)(num2 * 1240499863);
					continue;
				}
				case 16u:
					flag = num3 != card.Type;
					num = ((int)num2 * -93080927) ^ 0x8066E5A;
					continue;
				case 14u:
					num = (int)((num2 * 623870850) ^ 0x28276118);
					continue;
				case 13u:
					card = cards[num4];
					num = -1214549001;
					continue;
				case 12u:
					text = "[\n\t";
					num = ((int)num2 * -1300679247) ^ 0x36DF147B;
					continue;
				case 11u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -346432293;
					continue;
				}
				case 10u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1032744937) ^ -1780355238;
					continue;
				case 9u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 863955118) ^ 0x4354CE9E);
					continue;
				case 8u:
					num = (int)((num2 * 121132481) ^ 0x4A22E0FB);
					continue;
				case 6u:
					num = ((int)num2 * -277351707) ^ -1568485445;
					continue;
				case 5u:
					num = ((int)num2 * -1797408862) ^ 0x3699D653;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -919544097) ^ -1842058567;
					continue;
				case 3u:
					num3 = card.Type;
					num = (int)(num2 * 265747519) ^ -1784705296;
					continue;
				case 2u:
				{
					int num5;
					if (num4 < cards.Length)
					{
						num = -1507374326;
						num5 = -1507374326;
					}
					else
					{
						num = -653100638;
						num5 = -653100638;
					}
					continue;
				}
				case 1u:
					num4 = 0;
					num = ((int)num2 * -1656159713) ^ -1403961087;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -944836123) ^ -443604503;
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

	private string RiskChancesToString()
	{
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		string result = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1599197682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE56450D5u) % 8u)
				{
				case 7u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1381874612) ^ -1665645089;
					continue;
				case 6u:
					num = (int)((num2 * 499375745) ^ 0x5A791217);
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 1354174772) ^ -388798432;
					continue;
				case 3u:
					num3 = 1;
					num = (int)((num2 * 1749339824) ^ 0x7095AD14);
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = -1214004070;
						num4 = -1214004070;
					}
					else
					{
						num = -1969767435;
						num4 = -1969767435;
					}
					continue;
				}
				case 0u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -89367720;
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
