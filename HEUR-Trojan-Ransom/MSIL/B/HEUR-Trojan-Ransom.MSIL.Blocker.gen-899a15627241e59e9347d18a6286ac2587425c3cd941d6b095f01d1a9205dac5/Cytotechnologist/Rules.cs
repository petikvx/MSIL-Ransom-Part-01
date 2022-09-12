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
		int asInt = default(int);
		while (true)
		{
			int num = 2070364879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E810DDEu) % 5u)
				{
				case 3u:
					num = ((int)num2 * -408435541) ^ -1008247691;
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
					num = ((int)num2 * -1324611653) ^ 0xDFB483;
					continue;
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -2068021122) ^ 0x6CAFC6E6;
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
		bool flag = default(bool);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1982424301;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23887FF8u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 218304629;
						num5 = 218304629;
					}
					else
					{
						num4 = 1888635151;
						num5 = 1888635151;
					}
					num = num4 ^ (int)(num2 * 700034089);
					continue;
				}
				case 6u:
					num3++;
					num = (int)((num2 * 2110356903) ^ 0x496B60A3);
					continue;
				case 5u:
					num3 = 0;
					num = (int)((num2 * 2037667671) ^ 0x25085312);
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -1373968485) ^ -840198358;
					continue;
				case 1u:
					flag = num3 < array.Length;
					num = 320853887;
					continue;
				case 0u:
					array[num3] = json[num3].AsFloat;
					num = 1979130598;
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
		int num4 = default(int);
		int num3 = default(int);
		List<Card> list = default(List<Card>);
		bool flag2 = default(bool);
		int num9 = default(int);
		bool flag3 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		bool flag = default(bool);
		while (true)
		{
			int num = 1391124184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x517ED969u) % 25u)
				{
				case 24u:
					num4++;
					num = ((int)num2 * -613472662) ^ -159903846;
					continue;
				case 23u:
					num3 = 0;
					num = ((int)num2 * -1163889742) ^ -366358079;
					continue;
				case 22u:
					num = ((int)num2 * -995737791) ^ 0x3B0A6267;
					continue;
				case 21u:
					num3++;
					num = ((int)num2 * -729265963) ^ 0x2839B9;
					continue;
				case 20u:
					list = new List<Card>();
					num = ((int)num2 * -359648708) ^ -1375659284;
					continue;
				case 19u:
					flag2 = num9 < count;
					num = 1626403317;
					continue;
				case 18u:
					num = 1619713361;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1573197224;
						num8 = -1573197224;
					}
					else
					{
						num7 = -1326292178;
						num8 = -1326292178;
					}
					num = num7 ^ (int)(num2 * 863196774);
					continue;
				}
				case 16u:
					num4 = 0;
					num = ((int)num2 * -857558293) ^ -372286339;
					continue;
				case 15u:
					num = ((int)num2 * -555780389) ^ -690289970;
					continue;
				case 14u:
				{
					bool flag4 = num4 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag4 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num9
					});
					num = 102840611;
					continue;
				}
				case 11u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = 1308459842;
						num11 = 1308459842;
					}
					else
					{
						num10 = 483305423;
						num11 = 483305423;
					}
					num = num10 ^ ((int)num2 * -944045845);
					continue;
				}
				case 10u:
					num = 413514082;
					continue;
				case 9u:
					num = ((int)num2 * -2127208289) ^ -37950963;
					continue;
				case 8u:
					num9 = 0;
					num = ((int)num2 * -1783334299) ^ 0x8759748;
					continue;
				case 7u:
					jSONNode = json[num9];
					num = 1549531041;
					continue;
				case 6u:
					num9++;
					num = ((int)num2 * -55421294) ^ -1257751643;
					continue;
				case 5u:
					num = (int)(num2 * 1589734959) ^ -1247025001;
					continue;
				case 4u:
					result = list.ToArray();
					num = ((int)num2 * -714388442) ^ 0x3DB49A10;
					continue;
				case 3u:
					flag3 = num4 < maxImpact * 2;
					num = 1310139901;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1014658861;
						num6 = -1014658861;
					}
					else
					{
						num5 = -421311277;
						num6 = -421311277;
					}
					num = num5 ^ ((int)num2 * -1163019952);
					continue;
				}
				case 1u:
					num = (int)(num2 * 2134343599) ^ -961484905;
					continue;
				case 0u:
					flag = num3 < jSONNode[num4].AsInt;
					num = 1143060118;
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
			int num = 1664996545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52710013u) % 4u)
				{
				case 2u:
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
					num = ((int)num2 * -1201596065) ^ 0x377CB344;
					continue;
				case 1u:
					num = (int)((num2 * 25154346) ^ 0x162CBB11);
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
		int num6 = default(int);
		Card[] cards = default(Card[]);
		Card card = default(Card);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1832185026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6CC03BDu) % 13u)
				{
				case 12u:
				{
					int num7;
					if (num6 < cards.Length)
					{
						num = -1144664024;
						num7 = -1144664024;
					}
					else
					{
						num = -1965541329;
						num7 = -1965541329;
					}
					continue;
				}
				case 11u:
					card = cards[num6];
					num = -1288499714;
					continue;
				case 10u:
					num3 = 0;
					cards = Cards;
					num6 = 0;
					num = ((int)num2 * -1309024327) ^ -1977379920;
					continue;
				case 9u:
					num = ((int)num2 * -691373391) ^ -1901631025;
					continue;
				case 8u:
					num6++;
					num = (int)(num2 * 1697693751) ^ -993862507;
					continue;
				case 6u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1868697095;
					continue;
				}
				case 5u:
					num3 = card.Type;
					num = (int)(num2 * 651923840) ^ -654748568;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num3 != card.Type)
					{
						num4 = -2099759280;
						num5 = -2099759280;
					}
					else
					{
						num4 = -257202974;
						num5 = -257202974;
					}
					num = num4 ^ (int)(num2 * 322619098);
					continue;
				}
				case 3u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 1779819129) ^ -486207808;
					continue;
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 2101562929) ^ -574059032;
					continue;
				case 0u:
					num = ((int)num2 * -1728911209) ^ 0x2EFC3C4F;
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
		bool flag = default(bool);
		string result = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 54300115;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42365587u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -509412690;
						num5 = -509412690;
					}
					else
					{
						num4 = -143005225;
						num5 = -143005225;
					}
					num = num4 ^ (int)(num2 * 2022161286);
					continue;
				}
				case 7u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 1299273430) ^ 0x48706AB7);
					continue;
				case 6u:
					num = (int)(num2 * 2006564527) ^ -1901804410;
					continue;
				case 4u:
					num = (int)((num2 * 2059153373) ^ 0x422E90A);
					continue;
				case 3u:
					num3 = 1;
					num = ((int)num2 * -198964778) ^ 0x71A9D1DE;
					continue;
				case 2u:
					flag = num3 < RiskChances.Length;
					num = 1414263405;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = 1872073143;
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
