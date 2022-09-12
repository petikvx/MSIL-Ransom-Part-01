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
			int num = 1550957132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5769FC05u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1508103482) ^ -146841510;
					continue;
				case 1u:
					num = (int)((num2 * 369100711) ^ 0x19553C7C);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = json["max-impact"].AsInt;
		return new Rules
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
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = -1885559767;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x816F98B7u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -551852329) ^ 0x2D60E34;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1803563246) ^ -1871034003;
					continue;
				case 6u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -1075837738;
						num4 = -1075837738;
					}
					else
					{
						num = -1240071298;
						num4 = -1240071298;
					}
					continue;
				}
				case 4u:
					array[num3] = json[num3].AsFloat;
					num = -1039331745;
					continue;
				case 3u:
					num = ((int)num2 * -1759554376) ^ -1883170500;
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -1356212806) ^ -739694387;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -892137140) ^ 0x3B2AAC9E;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int num6 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		bool flag2 = default(bool);
		int count = default(int);
		List<Card> list = default(List<Card>);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		int num3 = default(int);
		while (true)
		{
			int num = -559665588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB22A0A29u) % 25u)
				{
				case 24u:
					num6++;
					num = (int)(num2 * 160242192) ^ -1312691807;
					continue;
				case 23u:
					num = ((int)num2 * -1970496108) ^ -1589861487;
					continue;
				case 21u:
					flag = num4 < maxImpact;
					num = -1428315013;
					continue;
				case 20u:
				{
					int num7;
					if (num4 >= maxImpact * 2)
					{
						num = -1345214186;
						num7 = -1345214186;
					}
					else
					{
						num = -2100058859;
						num7 = -2100058859;
					}
					continue;
				}
				case 19u:
					num = ((int)num2 * -389257514) ^ -2047094151;
					continue;
				case 18u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -2068497572;
						num9 = -2068497572;
					}
					else
					{
						num8 = -1463816106;
						num9 = -1463816106;
					}
					num = num8 ^ ((int)num2 * -474749227);
					continue;
				}
				case 17u:
					num = -1831247644;
					continue;
				case 16u:
					num = (int)((num2 * 822750659) ^ 0x452B6A5E);
					continue;
				case 15u:
					num6 = 0;
					num = (int)(num2 * 858127424) ^ -713179843;
					continue;
				case 14u:
					num = (int)((num2 * 1557785311) ^ 0x1BE347FC);
					continue;
				case 13u:
					flag2 = num6 < count;
					num = -391711330;
					continue;
				case 12u:
					num = (int)((num2 * 622560131) ^ 0x796EAD33);
					continue;
				case 11u:
					list = new List<Card>();
					num = (int)((num2 * 1621368728) ^ 0x7D917BB6);
					continue;
				case 10u:
					num4 = 0;
					num = ((int)num2 * -72592611) ^ 0x23B5988E;
					continue;
				case 9u:
					jSONNode = json[num6];
					num = (int)(num2 * 714044497) ^ -1598171419;
					continue;
				case 8u:
					num4++;
					num = (int)((num2 * 1837289738) ^ 0x5B744E21);
					continue;
				case 7u:
					count = json.Count;
					num = ((int)num2 * -1983061266) ^ -1358915272;
					continue;
				case 5u:
					result = list.ToArray();
					num = (int)(num2 * 2002659728) ^ -1828787783;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -869863064) ^ 0x5FA13FC;
					continue;
				case 3u:
					num = -1979680973;
					continue;
				case 2u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num6
					});
					num = -1280228453;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -837118928) ^ 0x367516C;
					continue;
				case 0u:
				{
					int num5;
					if (num3 < jSONNode[num4].AsInt)
					{
						num = -294480774;
						num5 = -294480774;
					}
					else
					{
						num = -961301926;
						num5 = -961301926;
					}
					continue;
				}
				case 22u:
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
			int num = -1162017443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA7B0FADu) % 3u)
				{
				case 1u:
					goto IL_00b5;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_00b5:
				num = ((int)num2 * -2129575801) ^ -1042370277;
			}
		}
	}

	private string CardsToString()
	{
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num4 = default(int);
		string text = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1308488625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A10B201u) % 20u)
				{
				case 19u:
					card = cards[num4];
					num = -2124516708;
					continue;
				case 17u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1584629653) ^ -656608331;
					continue;
				case 16u:
					num = ((int)num2 * -1419339456) ^ -844639629;
					continue;
				case 15u:
					num3 = card.Type;
					num = (int)((num2 * 1683495072) ^ 0x358F8BFB);
					continue;
				case 14u:
					num = (int)((num2 * 587040285) ^ 0x482B237C);
					continue;
				case 13u:
					num = (int)(num2 * 227865057) ^ -1000170418;
					continue;
				case 11u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -183755652;
					continue;
				}
				case 10u:
				{
					int num7;
					if (num4 >= cards.Length)
					{
						num = -88644831;
						num7 = -88644831;
					}
					else
					{
						num = -1131487586;
						num7 = -1131487586;
					}
					continue;
				}
				case 9u:
					num = (int)((num2 * 1279882721) ^ 0x5813E007);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1051069966;
						num6 = 1051069966;
					}
					else
					{
						num5 = 1444788704;
						num6 = 1444788704;
					}
					num = num5 ^ (int)(num2 * 1254032272);
					continue;
				}
				case 7u:
					cards = Cards;
					num4 = 0;
					num = ((int)num2 * -1745191837) ^ -1468577071;
					continue;
				case 6u:
					flag = num3 != card.Type;
					num = ((int)num2 * -1933070318) ^ -1684686107;
					continue;
				case 5u:
					num = (int)((num2 * 409932528) ^ 0xF105B4F);
					continue;
				case 4u:
					num = (int)(num2 * 1757323304) ^ -617672142;
					continue;
				case 3u:
					num4++;
					num = (int)((num2 * 823899057) ^ 0x3046A354);
					continue;
				case 2u:
					text = "[\n\t";
					num = (int)((num2 * 1053358728) ^ 0x554BB328);
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -814530808) ^ -842495595;
					continue;
				case 0u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 969958115) ^ -1083970323;
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

	private string RiskChancesToString()
	{
		int num5 = default(int);
		string string_ = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -844025119;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD204A7Fu) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1547513065) ^ 0x744D8B61;
					continue;
				case 9u:
					num5 = 1;
					num = ((int)num2 * -713807482) ^ -925495353;
					continue;
				case 8u:
					num = ((int)num2 * -36788293) ^ -219904350;
					continue;
				case 7u:
					num5++;
					num = ((int)num2 * -970560098) ^ 0x172054C9;
					continue;
				case 6u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -253438990) ^ -1584849364;
					continue;
				case 4u:
					flag = num5 < RiskChances.Length;
					num = -692874413;
					continue;
				case 2u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -728493634) ^ 0x71C1991;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num = -839702494;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 145684274;
						num4 = 145684274;
					}
					else
					{
						num3 = 1601933641;
						num4 = 1601933641;
					}
					num = num3 ^ (int)(num2 * 286518786);
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
