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
			int num = -378136249;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2BD506Du) % 3u)
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
				num = ((int)num2 * -401900780) ^ 0x7E693D9A;
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		float[] result = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = 145301258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x746B15C3u) % 7u)
				{
				case 6u:
					result = array;
					num = ((int)num2 * -2095744152) ^ -355403578;
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -120382557) ^ -1822256137;
					continue;
				case 4u:
					num3 = 0;
					num = (int)(num2 * 867812691) ^ -863227200;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 365946219;
						num4 = 365946219;
					}
					else
					{
						num = 749682607;
						num4 = 749682607;
					}
					continue;
				}
				case 0u:
					array[num3] = json[num3].AsFloat;
					num = 260851191;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		List<Card> list = default(List<Card>);
		bool flag3 = default(bool);
		int num3 = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		int num6 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -1011972896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC52647F3u) % 25u)
				{
				case 24u:
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num7
					});
					num = -1053887176;
					continue;
				case 23u:
					num = ((int)num2 * -108840323) ^ 0x227C38CB;
					continue;
				case 22u:
					flag2 = num7 < count;
					num = -2043412803;
					continue;
				case 21u:
					num7++;
					num = (int)((num2 * 319747386) ^ 0x20312371);
					continue;
				case 20u:
					flag4 = num6 < jSONNode[num3].AsInt;
					num = -639268451;
					continue;
				case 19u:
					flag = num3 < maxImpact * 2;
					num = -786862244;
					continue;
				case 18u:
					num3 = 0;
					num = (int)(num2 * 1939029421) ^ -12924003;
					continue;
				case 17u:
					num6 = 0;
					num = -163452537;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 1682396738;
						num11 = 1682396738;
					}
					else
					{
						num10 = 174968438;
						num11 = 174968438;
					}
					num = num10 ^ ((int)num2 * -310304758);
					continue;
				}
				case 15u:
					result = list.ToArray();
					num = (int)((num2 * 1730828099) ^ 0x2559D931);
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -609304077;
						num9 = -609304077;
					}
					else
					{
						num8 = -2081515769;
						num9 = -2081515769;
					}
					num = num8 ^ ((int)num2 * -1749697842);
					continue;
				}
				case 13u:
					flag3 = num3 < maxImpact;
					num = -59865065;
					continue;
				case 11u:
					num = (int)((num2 * 625010555) ^ 0x5FDBA496);
					continue;
				case 10u:
					num = (int)((num2 * 469685275) ^ 0x315F6192);
					continue;
				case 9u:
					num = (int)((num2 * 330065571) ^ 0xA343A73);
					continue;
				case 8u:
					num6++;
					num = ((int)num2 * -352192232) ^ 0x16DE7F17;
					continue;
				case 6u:
					list = new List<Card>();
					num7 = 0;
					num = ((int)num2 * -722664443) ^ 0x5A0BF11D;
					continue;
				case 5u:
					num = ((int)num2 * -905031166) ^ 0x259F39F5;
					continue;
				case 4u:
					jSONNode = json[num7];
					num = (int)(num2 * 1292981906) ^ -1334575834;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 721194193;
						num5 = 721194193;
					}
					else
					{
						num4 = 1034703137;
						num5 = 1034703137;
					}
					num = num4 ^ ((int)num2 * -2102883853);
					continue;
				}
				case 2u:
					num3++;
					num = (int)(num2 * 2107774852) ^ -298312085;
					continue;
				case 1u:
					num = -200174715;
					continue;
				case 0u:
					num = ((int)num2 * -282419574) ^ 0x78743F48;
					continue;
				case 12u:
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
			int num = -800006270;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDD92BCFu) % 3u)
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
				num = ((int)num2 * -484080294) ^ -1339610324;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		bool flag = default(bool);
		int num3 = default(int);
		Card card = default(Card);
		int num4 = default(int);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = -401906886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF10D4318u) % 15u)
				{
				case 14u:
					num = (int)(num2 * 160343843) ^ -1571971464;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -757575075;
						num7 = -757575075;
					}
					else
					{
						num6 = -1035226563;
						num7 = -1035226563;
					}
					num = num6 ^ (int)(num2 * 1753359595);
					continue;
				}
				case 12u:
					num = ((int)num2 * -718156051) ^ 0x328A8D85;
					continue;
				case 11u:
					text = Rules.smethod_1(text, "\n\t");
					num3 = card.Type;
					num = ((int)num2 * -373630488) ^ -1523560571;
					continue;
				case 10u:
					num4++;
					num = (int)(num2 * 556533859) ^ -22039774;
					continue;
				case 9u:
					card = cards[num4];
					num = -241248592;
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 1313932661) ^ -1989644998;
					continue;
				case 6u:
				{
					int num5;
					if (num4 < cards.Length)
					{
						num = -914731030;
						num5 = -914731030;
					}
					else
					{
						num = -2119671147;
						num5 = -2119671147;
					}
					continue;
				}
				case 5u:
					cards = Cards;
					num4 = 0;
					num = ((int)num2 * -1465854563) ^ -1215447895;
					continue;
				case 4u:
					num = ((int)num2 * -1464964499) ^ 0x74F5D499;
					continue;
				case 2u:
					flag = num3 != card.Type;
					num = (int)(num2 * 1441664922) ^ -1083287605;
					continue;
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 1925144039) ^ -1816401365;
					continue;
				case 0u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -151655559;
					continue;
				}
				case 3u:
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
		string result = default(string);
		while (true)
		{
			int num = -22000223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8A88E18u) % 6u)
				{
				case 5u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = -119493642;
						num4 = -119493642;
					}
					else
					{
						num = -1166492908;
						num4 = -1166492908;
					}
					continue;
				}
				case 4u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 1853733952) ^ 0x6DE9F327);
					continue;
				case 3u:
					num3 = 1;
					num = ((int)num2 * -670754554) ^ 0x4507D4F7;
					continue;
				case 0u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = -1622576223;
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
