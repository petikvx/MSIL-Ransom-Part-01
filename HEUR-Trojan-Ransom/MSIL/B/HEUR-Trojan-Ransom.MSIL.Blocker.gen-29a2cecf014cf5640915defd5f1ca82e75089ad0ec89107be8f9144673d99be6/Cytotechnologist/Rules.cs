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
			int num = 675358560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x243430A2u) % 5u)
				{
				case 4u:
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
					num = ((int)num2 * -819262243) ^ 0x796D3D23;
					continue;
				case 2u:
					num = ((int)num2 * -206712854) ^ 0x239AB369;
					continue;
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -975323162) ^ 0x325DBF15;
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
		bool flag = default(bool);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1578714347;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71231AE8u) % 10u)
				{
				case 9u:
					num3++;
					num = (int)(num2 * 787016407) ^ -1345870938;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1648767735;
						num5 = -1648767735;
					}
					else
					{
						num4 = -2083058893;
						num5 = -2083058893;
					}
					num = num4 ^ (int)(num2 * 1769479152);
					continue;
				}
				case 7u:
					array = new float[json.Count];
					num3 = 0;
					num = (int)(num2 * 2098368322) ^ -1251575476;
					continue;
				case 6u:
					num = ((int)num2 * -184927912) ^ 0x3B8D5DAE;
					continue;
				case 5u:
					result = array;
					num = (int)(num2 * 436155568) ^ -510406244;
					continue;
				case 4u:
					num = ((int)num2 * -78490979) ^ 0x3416165D;
					continue;
				case 3u:
					flag = num3 < array.Length;
					num = 1878755924;
					continue;
				case 1u:
					array[num3] = json[num3].AsFloat;
					num = 794054383;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		List<Card> list = new List<Card>();
		bool flag2 = default(bool);
		int num7 = default(int);
		int num3 = default(int);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1458143759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44AFB827u) % 23u)
				{
				case 22u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 573961481;
						num11 = 573961481;
					}
					else
					{
						num10 = 1355137989;
						num11 = 1355137989;
					}
					num = num10 ^ (int)(num2 * 2123146040);
					continue;
				}
				case 21u:
				{
					bool flag4 = num7 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag4 ? (-(maxImpact - num7)) : (maxImpact * 2 - num7)),
						Type = num3
					});
					num = 1857735932;
					continue;
				}
				case 20u:
					num = (int)(num2 * 900653474) ^ -62617308;
					continue;
				case 19u:
					num3 = 0;
					num = ((int)num2 * -1402621534) ^ -1148031419;
					continue;
				case 18u:
					num3++;
					num = (int)((num2 * 1251734804) ^ 0x252C433D);
					continue;
				case 17u:
					num6 = 0;
					num = (int)(num2 * 569243750) ^ -319447298;
					continue;
				case 16u:
				{
					int num8;
					int num9;
					if (flag3)
					{
						num8 = -2128989760;
						num9 = -2128989760;
					}
					else
					{
						num8 = -1289714660;
						num9 = -1289714660;
					}
					num = num8 ^ ((int)num2 * -1291740762);
					continue;
				}
				case 15u:
					num7 = 0;
					num = (int)((num2 * 1097141383) ^ 0x2339092A);
					continue;
				case 14u:
					num = (int)(num2 * 412236700) ^ -1333481216;
					continue;
				case 12u:
					flag = num3 < count;
					num = 530985044;
					continue;
				case 11u:
					result = list.ToArray();
					num = ((int)num2 * -1599773736) ^ 0x3034833D;
					continue;
				case 10u:
					num = 967707670;
					continue;
				case 9u:
					flag3 = num6 < jSONNode[num7].AsInt;
					num = 1735664046;
					continue;
				case 8u:
					num7++;
					num = (int)((num2 * 1896569891) ^ 0x45CCD4F7);
					continue;
				case 7u:
					num = 802622774;
					continue;
				case 6u:
					flag2 = num7 < maxImpact * 2;
					num = 347717235;
					continue;
				case 5u:
					num6++;
					num = ((int)num2 * -134805837) ^ -2143932457;
					continue;
				case 4u:
					num = ((int)num2 * -1151941717) ^ -1542101637;
					continue;
				case 3u:
					num = ((int)num2 * -1554341023) ^ -209596328;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1244696952;
						num5 = 1244696952;
					}
					else
					{
						num4 = 1433416421;
						num5 = 1433416421;
					}
					num = num4 ^ ((int)num2 * -1164875513);
					continue;
				}
				case 1u:
					jSONNode = json[num3];
					num = 795476187;
					continue;
				case 13u:
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
			int num = 176223437;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1364FB1Eu) % 4u)
				{
				case 3u:
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
					num = (int)(num2 * 26959690) ^ -401304252;
					continue;
				case 0u:
					num = (int)(num2 * 781163409) ^ -338015013;
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
		string text = "[\n\t";
		int num3 = default(int);
		Card card = default(Card);
		int num4 = default(int);
		string result = default(string);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = -1285856286;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9142043u) % 16u)
				{
				case 14u:
					num = ((int)num2 * -1166051280) ^ -579588458;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (num3 == card.Type)
					{
						num6 = -854904722;
						num7 = -854904722;
					}
					else
					{
						num6 = -394439575;
						num7 = -394439575;
					}
					num = num6 ^ ((int)num2 * -403305170);
					continue;
				}
				case 12u:
					num = ((int)num2 * -393137373) ^ -1394269969;
					continue;
				case 11u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -389109607;
					continue;
				}
				case 10u:
					num4++;
					num = ((int)num2 * -1629208810) ^ -374250563;
					continue;
				case 9u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1507698721) ^ 0x442B4A04;
					continue;
				case 8u:
					text = Rules.smethod_1(text, "\n\t");
					num3 = card.Type;
					num = ((int)num2 * -82376466) ^ 0xBF13CE8;
					continue;
				case 7u:
					num = (int)((num2 * 1846699181) ^ 0x56E3B8BA);
					continue;
				case 6u:
					num4 = 0;
					num = ((int)num2 * -2139745356) ^ 0x1AB2DFC;
					continue;
				case 5u:
					cards = Cards;
					num = (int)(num2 * 1006332985) ^ -949645848;
					continue;
				case 4u:
					num = (int)((num2 * 2079939778) ^ 0x4BC26326);
					continue;
				case 3u:
					card = cards[num4];
					num = -2008536969;
					continue;
				case 2u:
				{
					int num5;
					if (num4 < cards.Length)
					{
						num = -1930759024;
						num5 = -1930759024;
					}
					else
					{
						num = -668409798;
						num5 = -668409798;
					}
					continue;
				}
				case 1u:
					num3 = 0;
					num = (int)((num2 * 1926616125) ^ 0xD2A9710);
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
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 760928987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25F611F9u) % 8u)
				{
				case 7u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = 611938789;
					continue;
				case 5u:
					num = (int)(num2 * 213513707) ^ -271599678;
					continue;
				case 4u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = 1183459310;
						num4 = 1183459310;
					}
					else
					{
						num = 1146884554;
						num4 = 1146884554;
					}
					continue;
				}
				case 3u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1837205914) ^ -1452824586;
					continue;
				case 2u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = (int)((num2 * 1975935261) ^ 0x6060096);
					continue;
				case 1u:
					num = (int)(num2 * 2071225495) ^ -657017456;
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
