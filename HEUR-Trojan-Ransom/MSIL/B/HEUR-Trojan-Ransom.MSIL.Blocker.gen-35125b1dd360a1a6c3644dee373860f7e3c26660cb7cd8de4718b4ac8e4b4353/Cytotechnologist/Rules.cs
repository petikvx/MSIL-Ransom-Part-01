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
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = 861651007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5181AB9Eu) % 5u)
				{
				case 4u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -629298474) ^ 0x1641787A;
					continue;
				case 3u:
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
					num = ((int)num2 * -795636477) ^ 0x2FDD7E52;
					continue;
				case 2u:
					num = (int)((num2 * 743180194) ^ 0x1BD05A5C);
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
		bool flag = default(bool);
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = -688207979;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3917972u) % 10u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 560254600;
						num5 = 560254600;
					}
					else
					{
						num4 = 992090719;
						num5 = 992090719;
					}
					num = num4 ^ ((int)num2 * -1017325780);
					continue;
				}
				case 8u:
					flag = num3 < array.Length;
					num = -1482394219;
					continue;
				case 6u:
					num = ((int)num2 * -996322163) ^ 0x62D99C12;
					continue;
				case 5u:
					result = array;
					num = (int)((num2 * 643764807) ^ 0x3B3710AC);
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1627434540) ^ -1478195030;
					continue;
				case 2u:
					array[num3] = json[num3].AsFloat;
					num = -407607126;
					continue;
				case 1u:
					array = new float[json.Count];
					num = ((int)num2 * -1410466840) ^ -2142203724;
					continue;
				case 0u:
					num3 = 0;
					num = (int)(num2 * 299148460) ^ -1230309662;
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
		int count = json.Count;
		List<Card> list = new List<Card>();
		Card[] result = default(Card[]);
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -417881573;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF518D2FFu) % 20u)
				{
				case 19u:
					result = list.ToArray();
					num = ((int)num2 * -1760249039) ^ 0x34BE219D;
					continue;
				case 18u:
				{
					bool flag2 = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -756732869;
					continue;
				}
				case 17u:
					num = (int)((num2 * 502890878) ^ 0x39171370);
					continue;
				case 16u:
				{
					int num7;
					if (num6 < jSONNode[num3].AsInt)
					{
						num = -1321156727;
						num7 = -1321156727;
					}
					else
					{
						num = -1632342882;
						num7 = -1632342882;
					}
					continue;
				}
				case 15u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1631446809;
						num9 = 1631446809;
					}
					else
					{
						num8 = 1539706793;
						num9 = 1539706793;
					}
					num = num8 ^ ((int)num2 * -455795592);
					continue;
				}
				case 14u:
					num6++;
					num = (int)((num2 * 1374560842) ^ 0x6DCCF35B);
					continue;
				case 13u:
					num = ((int)num2 * -545721598) ^ -1213762499;
					continue;
				case 12u:
					num = (int)(num2 * 1103928228) ^ -1605564495;
					continue;
				case 11u:
					jSONNode = json[num4];
					num = -297538953;
					continue;
				case 10u:
					num = (int)(num2 * 30861090) ^ -776175928;
					continue;
				case 8u:
					num4 = 0;
					num = ((int)num2 * -1787801244) ^ -2065599182;
					continue;
				case 7u:
					num = ((int)num2 * -501436060) ^ 0x3BF00351;
					continue;
				case 6u:
					num6 = 0;
					num = -2119974694;
					continue;
				case 5u:
				{
					int num5;
					if (num4 < count)
					{
						num = -1670299668;
						num5 = -1670299668;
					}
					else
					{
						num = -1992223908;
						num5 = -1992223908;
					}
					continue;
				}
				case 3u:
					num4++;
					num = (int)(num2 * 1919633586) ^ -2044660784;
					continue;
				case 2u:
					flag = num3 < maxImpact * 2;
					num = -1980161492;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1511678914) ^ 0xC604D1F);
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1223962170) ^ -1107124444;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 645379832;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E170FC1u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1942741486) ^ 0x558B904D;
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
					num = (int)((num2 * 804100038) ^ 0x1AF28F8D);
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
		int num = 0;
		bool flag = default(bool);
		Card card = default(Card);
		int num6 = default(int);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num2 = 561820675;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA42BDDDu) % 17u)
				{
				case 16u:
					flag = num != card.Type;
					num2 = (int)((num3 * 599476116) ^ 0x7B74BD7);
					continue;
				case 15u:
				{
					int num7;
					if (num6 < cards.Length)
					{
						num2 = 2096864113;
						num7 = 2096864113;
					}
					else
					{
						num2 = 249150956;
						num7 = 249150956;
					}
					continue;
				}
				case 13u:
					cards = Cards;
					num6 = 0;
					num2 = (int)((num3 * 7898363) ^ 0x7F37FEBE);
					continue;
				case 12u:
					num2 = (int)((num3 * 1969960129) ^ 0x5B7D459);
					continue;
				case 11u:
					num2 = (int)(num3 * 1032607369) ^ -830698715;
					continue;
				case 10u:
					num6++;
					num2 = ((int)num3 * -1675026719) ^ 0x349927A9;
					continue;
				case 9u:
					text = Rules.smethod_1(text, "\n\t");
					num2 = (int)((num3 * 2128391634) ^ 0x1029583E);
					continue;
				case 8u:
					num2 = ((int)num3 * -378888858) ^ 0x5D2D1547;
					continue;
				case 7u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num2 = 732924626;
					continue;
				}
				case 6u:
					num = card.Type;
					num2 = ((int)num3 * -428945718) ^ 0x33C3DD2D;
					continue;
				case 5u:
					num2 = (int)(num3 * 863743446) ^ -325797242;
					continue;
				case 4u:
					result = Rules.smethod_1(text, "\n]");
					num2 = (int)((num3 * 234807180) ^ 0x79E4247E);
					continue;
				case 3u:
					card = cards[num6];
					num2 = 395843917;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 415477679;
						num5 = 415477679;
					}
					else
					{
						num4 = 1775362656;
						num5 = 1775362656;
					}
					num2 = num4 ^ (int)(num3 * 987146898);
					continue;
				}
				case 0u:
					num2 = (int)((num3 * 636931639) ^ 0x3E58E7AD);
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
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1656078352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9336586Au) % 9u)
				{
				case 8u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = (int)((num2 * 128102320) ^ 0x1C020728);
					continue;
				case 7u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -603911941) ^ 0x6864FDC;
					continue;
				case 6u:
					num3++;
					num = (int)(num2 * 570087594) ^ -2117641644;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = -655311475;
						num4 = -655311475;
					}
					else
					{
						num = -1914381516;
						num4 = -1914381516;
					}
					continue;
				}
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -2058115158;
					continue;
				case 2u:
					num = ((int)num2 * -1642378634) ^ -1667087560;
					continue;
				case 1u:
					num = (int)(num2 * 1299623240) ^ -989321148;
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
