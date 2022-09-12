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
			int num = -1964725166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4068FEDu) % 3u)
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
				num = (int)((num2 * 102190235) ^ 0x37E658A);
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		int asInt = default(int);
		while (true)
		{
			int num = -2008293393;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE062E641u) % 5u)
				{
				case 3u:
					num = (int)((num2 * 1272303565) ^ 0x4A36C6F9);
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
					num = (int)(num2 * 1970245558) ^ -1476300666;
					continue;
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = (int)((num2 * 394203925) ^ 0x3FDB6987);
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
		int num3 = default(int);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1921723078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16B2387Cu) % 10u)
				{
				case 8u:
					num3++;
					num = (int)((num2 * 96998583) ^ 0x1E27953);
					continue;
				case 7u:
					array[num3] = json[num3].AsFloat;
					num = 459621378;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -364592049) ^ -1347025838;
					continue;
				case 5u:
					num = (int)((num2 * 1505395374) ^ 0x6991C96A);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 306552853;
						num5 = 306552853;
					}
					else
					{
						num4 = 818611527;
						num5 = 818611527;
					}
					num = num4 ^ (int)(num2 * 382662304);
					continue;
				}
				case 3u:
					result = array;
					num = ((int)num2 * -24601448) ^ -1535150073;
					continue;
				case 2u:
					num = (int)((num2 * 857011728) ^ 0xEC9CBC1);
					continue;
				case 1u:
					flag = num3 < array.Length;
					num = 1820100376;
					continue;
				case 9u:
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
		bool flag = default(bool);
		int num5 = default(int);
		bool flag2 = default(bool);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -76899520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE46C4A6u) % 21u)
				{
				case 20u:
					num4++;
					num = ((int)num2 * -915814887) ^ 0x66DD2113;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -192796649;
						num9 = -192796649;
					}
					else
					{
						num8 = -1174487685;
						num9 = -1174487685;
					}
					num = num8 ^ ((int)num2 * -568842529);
					continue;
				}
				case 18u:
					num5 = 0;
					num = -1055419917;
					continue;
				case 17u:
					flag2 = num4 < maxImpact;
					num = -761713040;
					continue;
				case 15u:
					num = (int)(num2 * 1339449775) ^ -106021503;
					continue;
				case 14u:
					result = list.ToArray();
					num = ((int)num2 * -1372966765) ^ 0xF7B5117;
					continue;
				case 13u:
					list = new List<Card>();
					num3 = 0;
					num = (int)((num2 * 800322432) ^ 0x7A07F13D);
					continue;
				case 12u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num3
					});
					num = -975225429;
					continue;
				case 11u:
					num = (int)(num2 * 145167969) ^ -1284590357;
					continue;
				case 10u:
					num = -1611393445;
					continue;
				case 9u:
					num = ((int)num2 * -458883699) ^ 0x646ED71A;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1888433940) ^ 0x51B75600;
					continue;
				case 6u:
					num = (int)(num2 * 1173905656) ^ -1592567438;
					continue;
				case 5u:
				{
					int num7;
					if (num5 < jSONNode[num4].AsInt)
					{
						num = -1241548817;
						num7 = -1241548817;
					}
					else
					{
						num = -697414361;
						num7 = -697414361;
					}
					continue;
				}
				case 4u:
				{
					int num6;
					if (num3 >= count)
					{
						num = -44263091;
						num6 = -44263091;
					}
					else
					{
						num = -2060849842;
						num6 = -2060849842;
					}
					continue;
				}
				case 3u:
					num5++;
					num = ((int)num2 * -1248825848) ^ 0x69DF77D3;
					continue;
				case 2u:
					num = (int)((num2 * 1744208052) ^ 0x13DF143E);
					continue;
				case 1u:
					flag = num4 < maxImpact * 2;
					num = -907942842;
					continue;
				case 0u:
					jSONNode = json[num3];
					num4 = 0;
					num = ((int)num2 * -443959906) ^ -434797637;
					continue;
				case 16u:
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
			int num = 232840229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x674871B8u) % 3u)
				{
				case 1u:
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
				num = (int)((num2 * 651699077) ^ 0x581BDF0F);
			}
		}
	}

	private string CardsToString()
	{
		int num3 = default(int);
		string text = default(string);
		int num4 = default(int);
		Card card = default(Card);
		string result = default(string);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = 1187455246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BDD7532u) % 16u)
				{
				case 15u:
					num3++;
					num = ((int)num2 * -1198700661) ^ -486615727;
					continue;
				case 14u:
					text = Rules.smethod_1(text, "\n\t");
					num4 = card.Type;
					num = (int)(num2 * 1170862221) ^ -1051287025;
					continue;
				case 12u:
					text = "[\n\t";
					num = (int)((num2 * 1585867115) ^ 0x6C6D016F);
					continue;
				case 11u:
					num = (int)((num2 * 1724488467) ^ 0x375C2C72);
					continue;
				case 10u:
					num = ((int)num2 * -995456998) ^ -610174672;
					continue;
				case 9u:
					num4 = 0;
					num = (int)(num2 * 1556798221) ^ -1478312124;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (num4 != card.Type)
					{
						num6 = 1208270924;
						num7 = 1208270924;
					}
					else
					{
						num6 = 899224307;
						num7 = 899224307;
					}
					num = num6 ^ ((int)num2 * -1613218596);
					continue;
				}
				case 7u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1508727266) ^ -1906973739;
					continue;
				case 6u:
				{
					int num5;
					if (num3 < cards.Length)
					{
						num = 750037778;
						num5 = 750037778;
					}
					else
					{
						num = 2031965877;
						num5 = 2031965877;
					}
					continue;
				}
				case 5u:
					num = (int)(num2 * 827162837) ^ -353623338;
					continue;
				case 4u:
					num = ((int)num2 * -1467670865) ^ -517967914;
					continue;
				case 3u:
					cards = Cards;
					num3 = 0;
					num = ((int)num2 * -1927120669) ^ -1807018543;
					continue;
				case 1u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1532808189;
					continue;
				}
				case 0u:
					card = cards[num3];
					num = 1665250822;
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

	private string RiskChancesToString()
	{
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 450548112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EA4D3AEu) % 8u)
				{
				case 7u:
					num3 = 1;
					num = ((int)num2 * -857747228) ^ -1967801685;
					continue;
				case 6u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -136925142) ^ -129428179;
					continue;
				case 5u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 149407562) ^ -304508968;
					continue;
				case 4u:
					num = (int)((num2 * 1495133184) ^ 0x62C3DCBE);
					continue;
				case 2u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = 316150135;
					continue;
				case 1u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = 742271564;
						num4 = 742271564;
					}
					else
					{
						num = 735820395;
						num4 = 735820395;
					}
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
