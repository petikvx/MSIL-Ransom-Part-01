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
			int num = 576959618;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x348BF724u) % 3u)
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
				num = ((int)num2 * -495214519) ^ -521310742;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = -1320922804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFF9B761u) % 5u)
				{
				case 3u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -569449249) ^ 0x6354CE99;
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
					num = ((int)num2 * -1028095258) ^ -1569815377;
					continue;
				case 1u:
					num = ((int)num2 * -523780846) ^ 0x43A86D32;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		int num5 = default(int);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 795478511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39DA39A8u) % 9u)
				{
				case 8u:
					array[num5] = json[num5].AsFloat;
					num = 408703786;
					continue;
				case 7u:
					flag = num5 < array.Length;
					num = 1980613590;
					continue;
				case 6u:
					result = array;
					num = (int)(num2 * 825956061) ^ -1623873194;
					continue;
				case 5u:
					num5 = 0;
					num = ((int)num2 * -809884404) ^ 0x1EC1A034;
					continue;
				case 4u:
					num5++;
					num = ((int)num2 * -1567290434) ^ -436222065;
					continue;
				case 3u:
					num = ((int)num2 * -2061439614) ^ -831443357;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -25460166;
						num4 = -25460166;
					}
					else
					{
						num3 = -494384265;
						num4 = -494384265;
					}
					num = num3 ^ ((int)num2 * -424759012);
					continue;
				}
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
		int num6 = default(int);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		int num7 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag2 = default(bool);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -754218226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF63AE2DCu) % 21u)
				{
				case 20u:
					num = ((int)num2 * -1163239385) ^ -1415613234;
					continue;
				case 19u:
				{
					bool flag3 = num6 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num6)) : (maxImpact * 2 - num6)),
						Type = num3
					});
					num = -1065533712;
					continue;
				}
				case 18u:
				{
					int num10;
					if (num7 < jSONNode[num6].AsInt)
					{
						num = -856492180;
						num10 = -856492180;
					}
					else
					{
						num = -1365693060;
						num10 = -1365693060;
					}
					continue;
				}
				case 17u:
					num7 = 0;
					num = (int)((num2 * 236624656) ^ 0x4801F7B3);
					continue;
				case 16u:
					num6++;
					num = (int)((num2 * 1470409522) ^ 0x33246F10);
					continue;
				case 14u:
					num7++;
					num = ((int)num2 * -1503003714) ^ 0x174A003B;
					continue;
				case 13u:
					num = -174944370;
					continue;
				case 12u:
					flag2 = num6 < maxImpact * 2;
					num = -1882380423;
					continue;
				case 11u:
					num = -513329662;
					continue;
				case 10u:
					num6 = 0;
					num = ((int)num2 * -168054798) ^ -1939978260;
					continue;
				case 9u:
					num = (int)(num2 * 1433841637) ^ -1246949357;
					continue;
				case 8u:
					num = ((int)num2 * -1743161103) ^ 0x22D7447D;
					continue;
				case 7u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -1311061864;
						num9 = -1311061864;
					}
					else
					{
						num8 = -763103251;
						num9 = -763103251;
					}
					num = num8 ^ ((int)num2 * -1057121844);
					continue;
				}
				case 6u:
					flag = num3 < count;
					num = -627083166;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -921751976;
						num5 = -921751976;
					}
					else
					{
						num4 = -1404688394;
						num5 = -1404688394;
					}
					num = num4 ^ ((int)num2 * -2016559631);
					continue;
				}
				case 3u:
					result = list.ToArray();
					num = ((int)num2 * -1424898725) ^ -404636619;
					continue;
				case 2u:
					list = new List<Card>();
					num3 = 0;
					num = ((int)num2 * -1129833820) ^ 0x90B4E7;
					continue;
				case 1u:
					jSONNode = json[num3];
					num = -1896315411;
					continue;
				case 0u:
					num3++;
					num = (int)((num2 * 357571835) ^ 0x2825C94D);
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
			int num = -808994592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEF4FCFDu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -94678427) ^ 0x34AD17BC;
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
					num = (int)((num2 * 22430194) ^ 0x6DF6F601);
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
		string text = "[\n\t";
		Card[] cards = default(Card[]);
		Card card = default(Card);
		bool flag = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1463932195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87E7EA11u) % 16u)
				{
				case 15u:
					cards = Cards;
					num = (int)((num2 * 1471839731) ^ 0x325ED60A);
					continue;
				case 14u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1314716314;
					continue;
				}
				case 13u:
					flag = num5 != card.Type;
					num = (int)(num2 * 1902683430) ^ -1917863973;
					continue;
				case 12u:
					num5 = 0;
					num = ((int)num2 * -560893371) ^ 0xA5F65E2;
					continue;
				case 11u:
					num6++;
					num = ((int)num2 * -1560760936) ^ 0x5FB92A21;
					continue;
				case 10u:
					num = (int)((num2 * 1288418463) ^ 0x313FC8E4);
					continue;
				case 9u:
					card = cards[num6];
					num = -1448033572;
					continue;
				case 8u:
				{
					int num7;
					if (num6 >= cards.Length)
					{
						num = -2077169856;
						num7 = -2077169856;
					}
					else
					{
						num = -457033256;
						num7 = -457033256;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -551201134) ^ -1852884844;
					continue;
				case 6u:
					num6 = 0;
					num = ((int)num2 * -1072275485) ^ 0x62A58FE1;
					continue;
				case 5u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = ((int)num2 * -1000178172) ^ 0x298EE44B;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 754127372;
						num4 = 754127372;
					}
					else
					{
						num3 = 1449466871;
						num4 = 1449466871;
					}
					num = num3 ^ ((int)num2 * -1983414390);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1116567789) ^ 0x1A58EC33);
					continue;
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -110412933) ^ 0x2DB94930;
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
		int num = 1;
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num2 = -50009148;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xFDDA63D8u) % 7u)
				{
				case 5u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num++;
					num2 = -1914593769;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1507408501;
						num5 = -1507408501;
					}
					else
					{
						num4 = -1265598037;
						num5 = -1265598037;
					}
					num2 = num4 ^ ((int)num3 * -482512393);
					continue;
				}
				case 3u:
					result = Rules.smethod_1(string_, " ]");
					num2 = ((int)num3 * -1896358048) ^ 0x6ADD1CC1;
					continue;
				case 1u:
					num2 = ((int)num3 * -795515020) ^ 0x68056EA7;
					continue;
				case 0u:
					flag = num < RiskChances.Length;
					num2 = -1109323145;
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
