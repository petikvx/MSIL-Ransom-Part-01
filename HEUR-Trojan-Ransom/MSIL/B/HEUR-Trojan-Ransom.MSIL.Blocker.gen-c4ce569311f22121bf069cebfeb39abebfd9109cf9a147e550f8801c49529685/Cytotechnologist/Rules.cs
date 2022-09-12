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
			int num = -842449334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAE6F213u) % 4u)
				{
				case 1u:
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
					num = (int)(num2 * 2002122253) ^ -8460094;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1881932175) ^ -1479950163;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		bool flag = default(bool);
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = 2032894762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CA8920Bu) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1840531918;
						num5 = -1840531918;
					}
					else
					{
						num4 = -1281002195;
						num5 = -1281002195;
					}
					num = num4 ^ (int)(num2 * 1671361484);
					continue;
				}
				case 6u:
					flag = num3 < array.Length;
					num = 1437232876;
					continue;
				case 5u:
					array[num3] = json[num3].AsFloat;
					num = 1217494096;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -1605947718) ^ 0x7328528B;
					continue;
				case 2u:
					result = array;
					num = (int)((num2 * 640322411) ^ 0xE9F1D55);
					continue;
				case 1u:
					array = new float[json.Count];
					num3 = 0;
					num = (int)((num2 * 1047261229) ^ 0x4BE32858);
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		List<Card> list = new List<Card>();
		bool flag3 = default(bool);
		int num9 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		bool flag4 = default(bool);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -1015599486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF481749u) % 26u)
				{
				case 25u:
					flag3 = num9 < jSONNode[num3].AsInt;
					num = -889019525;
					continue;
				case 24u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -410470316;
						num8 = -410470316;
					}
					else
					{
						num7 = -962063512;
						num8 = -962063512;
					}
					num = num7 ^ ((int)num2 * -1410736383);
					continue;
				}
				case 23u:
					num = -1098135063;
					continue;
				case 22u:
					num9 = 0;
					num = (int)((num2 * 1271779730) ^ 0x6B67F64B);
					continue;
				case 20u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1766973037;
						num6 = 1766973037;
					}
					else
					{
						num5 = 520880710;
						num6 = 520880710;
					}
					num = num5 ^ ((int)num2 * -1047247357);
					continue;
				}
				case 18u:
					jSONNode = json[num4];
					num = ((int)num2 * -1769481734) ^ -2041853497;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = -624860320;
						num11 = -624860320;
					}
					else
					{
						num10 = -1401515673;
						num11 = -1401515673;
					}
					num = num10 ^ ((int)num2 * -473838953);
					continue;
				}
				case 16u:
					num4++;
					num = (int)((num2 * 679866722) ^ 0x1ED77290);
					continue;
				case 15u:
					flag = num3 < maxImpact;
					num = (int)((num2 * 70144551) ^ 0x4C445AB0);
					continue;
				case 14u:
					result = list.ToArray();
					num = ((int)num2 * -826490963) ^ -987206532;
					continue;
				case 13u:
					num = (int)(num2 * 1912366530) ^ -897665739;
					continue;
				case 12u:
					num = ((int)num2 * -1693606304) ^ 0x39648E20;
					continue;
				case 11u:
					flag4 = num3 < maxImpact * 2;
					num = -2094681614;
					continue;
				case 10u:
					num3++;
					num = ((int)num2 * -1564901017) ^ 0x4E557D76;
					continue;
				case 9u:
					flag2 = num4 < count;
					num = -933223663;
					continue;
				case 8u:
					num9++;
					num = (int)((num2 * 706273597) ^ 0x271C3694);
					continue;
				case 7u:
					num4 = 0;
					num = ((int)num2 * -1649848601) ^ 0x531C21FA;
					continue;
				case 6u:
					num = ((int)num2 * -570013677) ^ 0x21CF55D;
					continue;
				case 5u:
					num = ((int)num2 * -494240458) ^ -1447343643;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -94093674) ^ 0x2BA7F830;
					continue;
				case 3u:
					num = -320992422;
					continue;
				case 2u:
					num = ((int)num2 * -1883138869) ^ -496420392;
					continue;
				case 1u:
					num = -1882083155;
					continue;
				case 0u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -2047364410;
					continue;
				case 21u:
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
			int num = 126542711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10177B50u) % 3u)
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
				num = ((int)num2 * -201971011) ^ -733200258;
			}
		}
	}

	private string CardsToString()
	{
		int num3 = default(int);
		Card[] cards = default(Card[]);
		string text = default(string);
		Card card = default(Card);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -2478800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF23BF51Fu) % 19u)
				{
				case 18u:
				{
					int num7;
					if (num3 >= cards.Length)
					{
						num = -317453960;
						num7 = -317453960;
					}
					else
					{
						num = -1750709587;
						num7 = -1750709587;
					}
					continue;
				}
				case 17u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -51991614;
					continue;
				}
				case 16u:
					num4 = 0;
					num = (int)((num2 * 1748921296) ^ 0x75698BE);
					continue;
				case 15u:
					text = "[\n\t";
					num = ((int)num2 * -823533362) ^ -976929394;
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (num4 == card.Type)
					{
						num5 = -1948533232;
						num6 = -1948533232;
					}
					else
					{
						num5 = -970075371;
						num6 = -970075371;
					}
					num = num5 ^ ((int)num2 * -451416860);
					continue;
				}
				case 13u:
					cards = Cards;
					num = (int)((num2 * 1333923273) ^ 0x10B01516);
					continue;
				case 12u:
					num = ((int)num2 * -2109378654) ^ -1548376120;
					continue;
				case 11u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1029833422) ^ -1670741879;
					continue;
				case 10u:
					num = (int)((num2 * 1951982935) ^ 0x5548846A);
					continue;
				case 9u:
					num3++;
					num = (int)(num2 * 799081209) ^ -1003106431;
					continue;
				case 8u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 209260187) ^ -960134746;
					continue;
				case 7u:
					card = cards[num3];
					num = -583962574;
					continue;
				case 6u:
					num = (int)(num2 * 1612423139) ^ -860092504;
					continue;
				case 5u:
					num = ((int)num2 * -60941852) ^ -971401681;
					continue;
				case 4u:
					num = ((int)num2 * -199927925) ^ -154348861;
					continue;
				case 3u:
					num4 = card.Type;
					num = ((int)num2 * -1551482651) ^ 0x258E3D75;
					continue;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 131867572) ^ 0x4503E805);
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
		bool flag = default(bool);
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 3426105;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53E1B12Au) % 8u)
				{
				case 7u:
					flag = num3 < RiskChances.Length;
					num = 1059291151;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -30405;
						num5 = -30405;
					}
					else
					{
						num4 = -14509095;
						num5 = -14509095;
					}
					num = num4 ^ ((int)num2 * -552626721);
					continue;
				}
				case 3u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = (int)((num2 * 837759678) ^ 0x424BAB1F);
					continue;
				case 2u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 97598315;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1343182421) ^ 0x758C4E90);
					continue;
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 58512220) ^ -1605424090;
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
