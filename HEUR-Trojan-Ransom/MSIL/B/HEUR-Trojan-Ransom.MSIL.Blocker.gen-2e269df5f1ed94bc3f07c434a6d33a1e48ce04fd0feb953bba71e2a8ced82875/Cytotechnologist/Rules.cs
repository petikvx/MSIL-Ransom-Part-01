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
			int num = 2052346740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2ED4E293u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1844661591) ^ 0x69DE3999;
					continue;
				case 1u:
					num = (int)(num2 * 1405147901) ^ -305454120;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		while (true)
		{
			int num = 104368311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x229C7B5Au) % 4u)
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
					num = (int)(num2 * 574531590) ^ -2089978652;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1596691249) ^ 0x79BFDB29;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		bool flag = default(bool);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = -116752970;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF95B6608u) % 9u)
				{
				case 8u:
					flag = num3 < array.Length;
					num = -639113324;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1143207875) ^ -1913290701;
					continue;
				case 6u:
					num = (int)(num2 * 412865225) ^ -1507298626;
					continue;
				case 5u:
					array[num3] = json[num3].AsFloat;
					num = -638044985;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 132609522;
						num5 = 132609522;
					}
					else
					{
						num4 = 8390294;
						num5 = 8390294;
					}
					num = num4 ^ (int)(num2 * 1980315420);
					continue;
				}
				case 3u:
					result = array;
					num = ((int)num2 * -254409174) ^ -380470500;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 990428295) ^ -1160201004;
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
		int count = json.Count;
		bool flag3 = default(bool);
		bool flag = default(bool);
		List<Card> list = default(List<Card>);
		int num5 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		bool flag4 = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -1857851151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC89CDD7Au) % 26u)
				{
				case 25u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -1789092145;
						num11 = -1789092145;
					}
					else
					{
						num10 = -1550575562;
						num11 = -1550575562;
					}
					num = num10 ^ ((int)num2 * -29373968);
					continue;
				}
				case 24u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 948542049;
						num9 = 948542049;
					}
					else
					{
						num8 = 597705241;
						num9 = 597705241;
					}
					num = num8 ^ ((int)num2 * -1972311896);
					continue;
				}
				case 23u:
					list = new List<Card>();
					num = (int)((num2 * 1782572569) ^ 0x123C1DD1);
					continue;
				case 22u:
					num5++;
					num = ((int)num2 * -269504261) ^ 0x59DBD3CA;
					continue;
				case 21u:
					num = ((int)num2 * -574201322) ^ -289435009;
					continue;
				case 20u:
					num = ((int)num2 * -1161885663) ^ 0x7EA545C2;
					continue;
				case 19u:
					num = -2037295968;
					continue;
				case 18u:
					num = ((int)num2 * -146539756) ^ 0x283E1E2D;
					continue;
				case 17u:
					num3++;
					num = (int)((num2 * 1660547007) ^ 0x5A358125);
					continue;
				case 16u:
					num = (int)(num2 * 1802974933) ^ -2108547651;
					continue;
				case 15u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 1161213593;
						num7 = 1161213593;
					}
					else
					{
						num6 = 1384549501;
						num7 = 1384549501;
					}
					num = num6 ^ (int)(num2 * 342458355);
					continue;
				}
				case 14u:
					num4 = 0;
					num = ((int)num2 * -70284252) ^ -298722899;
					continue;
				case 13u:
					num = ((int)num2 * -875352435) ^ 0x66D07EEF;
					continue;
				case 12u:
					jSONNode = json[num4];
					num3 = 0;
					num = ((int)num2 * -1520184843) ^ 0x3CF2FAE8;
					continue;
				case 11u:
					list.Add(new Card
					{
						Impact = (flag4 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -1333432744;
					continue;
				case 9u:
					flag4 = num3 < maxImpact;
					num = -821598937;
					continue;
				case 8u:
					num5 = 0;
					num = (int)(num2 * 1058117626) ^ -48160423;
					continue;
				case 6u:
					result = list.ToArray();
					num = (int)(num2 * 2014866444) ^ -252098156;
					continue;
				case 5u:
					num4++;
					num = (int)(num2 * 111455931) ^ -1291510372;
					continue;
				case 4u:
					flag3 = num5 < jSONNode[num3].AsInt;
					num = -1349259339;
					continue;
				case 3u:
					num = ((int)num2 * -444084384) ^ 0x776BC5B1;
					continue;
				case 2u:
					num = -1058504158;
					continue;
				case 1u:
					flag2 = num4 < count;
					num = -1843818721;
					continue;
				case 0u:
					flag = num3 < maxImpact * 2;
					num = -1224328886;
					continue;
				case 10u:
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
			int num = 809775849;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14128A34u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1642051738) ^ -1490385686;
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
					num = ((int)num2 * -697752460) ^ 0x6D3398D7;
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
		int num7 = default(int);
		string text = default(string);
		Card card = default(Card);
		int num5 = default(int);
		bool flag = default(bool);
		string result = default(string);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = -159527228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED5BFB8Cu) % 17u)
				{
				case 16u:
					num7 = 0;
					num = ((int)num2 * -1477431270) ^ -1808588739;
					continue;
				case 15u:
					text = Rules.smethod_1(text, "\n\t");
					num7 = card.Type;
					num = (int)(num2 * 952276809) ^ -1011847217;
					continue;
				case 14u:
					num5 = 0;
					num = ((int)num2 * -642599876) ^ 0x752611C5;
					continue;
				case 13u:
					flag = num7 != card.Type;
					num = (int)(num2 * 205748803) ^ -1070517837;
					continue;
				case 12u:
					num = (int)(num2 * 1767683565) ^ -571699690;
					continue;
				case 11u:
					num = ((int)num2 * -1521360524) ^ 0x29B7B6C;
					continue;
				case 9u:
					num5++;
					num = (int)(num2 * 1293194949) ^ -1842464230;
					continue;
				case 8u:
					num = ((int)num2 * -989261792) ^ -897431674;
					continue;
				case 7u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -2121586725;
					continue;
				}
				case 6u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 964943926) ^ 0x3B8D6E0F);
					continue;
				case 5u:
					cards = Cards;
					num = ((int)num2 * -1433482930) ^ 0x6081806C;
					continue;
				case 4u:
				{
					int num6;
					if (num5 < cards.Length)
					{
						num = -12132421;
						num6 = -12132421;
					}
					else
					{
						num = -1751962677;
						num6 = -1751962677;
					}
					continue;
				}
				case 3u:
					text = "[\n\t";
					num = ((int)num2 * -1042472658) ^ -1823377378;
					continue;
				case 2u:
					card = cards[num5];
					num = -1520789737;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2018283176;
						num4 = -2018283176;
					}
					else
					{
						num3 = -1951393547;
						num4 = -1951393547;
					}
					num = num3 ^ ((int)num2 * -6117840);
					continue;
				}
				case 10u:
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
		bool flag = default(bool);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 2124203842;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A3643BEu) % 11u)
				{
				case 10u:
					num3 = 1;
					num = (int)(num2 * 1570055736) ^ -1623569920;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -564819080;
						num5 = -564819080;
					}
					else
					{
						num4 = -599331109;
						num5 = -599331109;
					}
					num = num4 ^ (int)(num2 * 2128280137);
					continue;
				}
				case 7u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 2122287841;
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -807106930) ^ -1897829753;
					continue;
				case 4u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -1011046347) ^ 0x58625ACC;
					continue;
				case 3u:
					flag = num3 < RiskChances.Length;
					num = 568424768;
					continue;
				case 2u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1177825532) ^ -588078841;
					continue;
				case 1u:
					num = ((int)num2 * -1623019828) ^ -205417827;
					continue;
				case 0u:
					num = (int)(num2 * 2143111373) ^ -1073242937;
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
