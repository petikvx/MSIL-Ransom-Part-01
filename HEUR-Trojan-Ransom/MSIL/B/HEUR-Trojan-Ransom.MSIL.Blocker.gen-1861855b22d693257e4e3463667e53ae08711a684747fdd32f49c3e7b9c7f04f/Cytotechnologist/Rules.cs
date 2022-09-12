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
			int num = -776641915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x986BEE1Fu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1393129834) ^ -1751800784;
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
					num = (int)(num2 * 1942402783) ^ -1931977038;
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
		int num5 = default(int);
		float[] array = default(float[]);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1893626931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45718BFFu) % 10u)
				{
				case 9u:
					num5++;
					num = ((int)num2 * -717135298) ^ 0x7968976F;
					continue;
				case 8u:
					array[num5] = json[num5].AsFloat;
					num = 6158570;
					continue;
				case 6u:
					flag = num5 < array.Length;
					num = 644315301;
					continue;
				case 5u:
					num5 = 0;
					num = (int)((num2 * 735631332) ^ 0x431BC9DD);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1744133437;
						num4 = 1744133437;
					}
					else
					{
						num3 = 536026107;
						num4 = 536026107;
					}
					num = num3 ^ ((int)num2 * -1705790779);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1791615323) ^ 0x11C248E5;
					continue;
				case 2u:
					array = new float[json.Count];
					num = (int)((num2 * 1150047500) ^ 0x3850011E);
					continue;
				case 0u:
					result = array;
					num = (int)(num2 * 1684344006) ^ -935631044;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		List<Card> list = default(List<Card>);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num3 = default(int);
		Card[] result = default(Card[]);
		bool flag = default(bool);
		int num5 = default(int);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1944177501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DC7FFE6u) % 24u)
				{
				case 23u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num6)) : (maxImpact * 2 - num6)),
						Type = num3
					});
					num = 817989567;
					continue;
				case 22u:
					num = (int)((num2 * 1379461524) ^ 0x30927A25);
					continue;
				case 21u:
					result = list.ToArray();
					num = (int)(num2 * 82569807) ^ -911668711;
					continue;
				case 20u:
					flag = num6 < maxImpact * 2;
					num = 1578612436;
					continue;
				case 19u:
					num = 2055062383;
					continue;
				case 18u:
					num6++;
					num = ((int)num2 * -386896048) ^ 0x50BA40B2;
					continue;
				case 17u:
					num5 = 0;
					num = ((int)num2 * -2030393759) ^ -175521152;
					continue;
				case 16u:
					flag2 = num6 < maxImpact;
					num = ((int)num2 * -1191514042) ^ -1267745815;
					continue;
				case 15u:
					num5++;
					num = (int)((num2 * 1688289085) ^ 0x5D1631AA);
					continue;
				case 14u:
					num6 = 0;
					num = (int)(num2 * 1599629686) ^ -1443233118;
					continue;
				case 13u:
					num = (int)((num2 * 53948606) ^ 0x788B98CA);
					continue;
				case 12u:
					num = (int)(num2 * 319124514) ^ -1153948453;
					continue;
				case 11u:
					count = json.Count;
					list = new List<Card>();
					num3 = 0;
					num = ((int)num2 * -1580769340) ^ 0x7885409C;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 1757783909;
						num9 = 1757783909;
					}
					else
					{
						num8 = 226428151;
						num9 = 226428151;
					}
					num = num8 ^ (int)(num2 * 1665413336);
					continue;
				}
				case 9u:
					num = (int)((num2 * 258326804) ^ 0x1A6C2DED);
					continue;
				case 8u:
					num = ((int)num2 * -819535246) ^ -1477228974;
					continue;
				case 7u:
				{
					int num7;
					if (num5 >= jSONNode[num6].AsInt)
					{
						num = 904337019;
						num7 = 904337019;
					}
					else
					{
						num = 1544443460;
						num7 = 1544443460;
					}
					continue;
				}
				case 6u:
					jSONNode = json[num3];
					num = 2052300592;
					continue;
				case 4u:
					num3++;
					num = (int)((num2 * 635743787) ^ 0x2B49FD1);
					continue;
				case 3u:
				{
					int num4;
					if (num3 < count)
					{
						num = 1391442128;
						num4 = 1391442128;
					}
					else
					{
						num = 2131658763;
						num4 = 2131658763;
					}
					continue;
				}
				case 2u:
					num = 144450182;
					continue;
				case 1u:
					num = (int)((num2 * 1441874588) ^ 0x1762251E);
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
			int num = 278376526;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1299B8E9u) % 3u)
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
				num = ((int)num2 * -610481064) ^ 0x2B2CE526;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		int num = 0;
		bool flag = default(bool);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num2 = 330627635;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xE84EC3Cu) % 13u)
				{
				case 12u:
					flag = num != card.Type;
					num2 = ((int)num3 * -1092629186) ^ -839374683;
					continue;
				case 11u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num2 = 1715504405;
					continue;
				}
				case 10u:
					num2 = (int)(num3 * 433550342) ^ -753320002;
					continue;
				case 9u:
					cards = Cards;
					num4 = 0;
					num2 = (int)((num3 * 596916523) ^ 0x1F509DEF);
					continue;
				case 8u:
					text = Rules.smethod_1(text, "\n\t");
					num2 = ((int)num3 * -913400055) ^ 0x224EBFDC;
					continue;
				case 7u:
					card = cards[num4];
					num2 = 1731873769;
					continue;
				case 6u:
					num = card.Type;
					num2 = (int)((num3 * 765487398) ^ 0x49B9DA3E);
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1547478538;
						num7 = 1547478538;
					}
					else
					{
						num6 = 1200204756;
						num7 = 1200204756;
					}
					num2 = num6 ^ (int)(num3 * 113437178);
					continue;
				}
				case 4u:
					result = Rules.smethod_1(text, "\n]");
					num2 = (int)(num3 * 230418989) ^ -1756933883;
					continue;
				case 2u:
				{
					int num5;
					if (num4 < cards.Length)
					{
						num2 = 605236010;
						num5 = 605236010;
					}
					else
					{
						num2 = 581184058;
						num5 = 581184058;
					}
					continue;
				}
				case 1u:
					num4++;
					num2 = ((int)num3 * -1775858150) ^ 0x4EA4FA40;
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

	private string RiskChancesToString()
	{
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num5 = default(int);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1849593822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x65A12F59u) % 10u)
				{
				case 9u:
					num5++;
					num = (int)((num2 * 1567360948) ^ 0x46785F95);
					continue;
				case 7u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 716629865) ^ 0x64D75E6E);
					continue;
				case 6u:
					flag = num5 < RiskChances.Length;
					num = 930532234;
					continue;
				case 5u:
					num5 = 1;
					num = (int)((num2 * 413666404) ^ 0x732ABF5B);
					continue;
				case 4u:
					num = ((int)num2 * -1037683607) ^ -348026972;
					continue;
				case 2u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num = 851707262;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -775998636;
						num4 = -775998636;
					}
					else
					{
						num3 = -839817003;
						num4 = -839817003;
					}
					num = num3 ^ (int)(num2 * 394816781);
					continue;
				}
				case 0u:
					num = ((int)num2 * -120477910) ^ -1605637419;
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
