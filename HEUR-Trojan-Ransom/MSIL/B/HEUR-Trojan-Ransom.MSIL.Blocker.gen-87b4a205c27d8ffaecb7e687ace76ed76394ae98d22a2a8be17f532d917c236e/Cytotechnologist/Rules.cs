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
			int num = 1851336816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AEDAF1Du) % 4u)
				{
				case 1u:
					num = ((int)num2 * -1985524987) ^ -1907050548;
					continue;
				case 0u:
					num = (int)((num2 * 503129653) ^ 0x3504EDEB);
					continue;
				default:
					return;
				case 3u:
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
		float[] array = default(float[]);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = -149457374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9787A4CFu) % 7u)
				{
				case 5u:
					array = new float[json.Count];
					num3 = 0;
					num = (int)(num2 * 1562010617) ^ -89362023;
					continue;
				case 4u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = -1888679905;
					continue;
				case 3u:
					result = array;
					num = ((int)num2 * -510885233) ^ -180857874;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -75392381;
						num4 = -75392381;
					}
					else
					{
						num = -2065490128;
						num4 = -2065490128;
					}
					continue;
				}
				case 1u:
					num = (int)(num2 * 759664428) ^ -276532901;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		int num4 = default(int);
		bool flag2 = default(bool);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num7 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -745129531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6747F7Au) % 24u)
				{
				case 23u:
				{
					int num10;
					if (num4 < count)
					{
						num = -1073614455;
						num10 = -1073614455;
					}
					else
					{
						num = -145095736;
						num10 = -145095736;
					}
					continue;
				}
				case 22u:
					num = -2022858140;
					continue;
				case 21u:
					num = -34748194;
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -2127193816;
						num6 = -2127193816;
					}
					else
					{
						num5 = -675875037;
						num6 = -675875037;
					}
					num = num5 ^ ((int)num2 * -1009197228);
					continue;
				}
				case 18u:
					result = list.ToArray();
					num = ((int)num2 * -42592258) ^ -961661273;
					continue;
				case 17u:
					flag2 = num7 < jSONNode[num3].AsInt;
					num = -1901700999;
					continue;
				case 16u:
					num = (int)(num2 * 1078052311) ^ -1241813075;
					continue;
				case 15u:
					list = new List<Card>();
					num4 = 0;
					num = ((int)num2 * -1762256708) ^ -364746023;
					continue;
				case 14u:
					num = (int)(num2 * 131824464) ^ -2058892341;
					continue;
				case 13u:
					num7++;
					num = ((int)num2 * -1029818617) ^ -302343320;
					continue;
				case 12u:
					flag = num3 < maxImpact;
					num = (int)((num2 * 2089732070) ^ 0x38185CA8);
					continue;
				case 11u:
					num = -1782832322;
					continue;
				case 10u:
					num3 = 0;
					num = ((int)num2 * -920675819) ^ -1993985797;
					continue;
				case 9u:
					num3++;
					num = (int)((num2 * 1559114415) ^ 0xEDC94C5);
					continue;
				case 8u:
					flag3 = num3 < maxImpact * 2;
					num = -195739577;
					continue;
				case 7u:
					num4++;
					num = (int)(num2 * 684572956) ^ -599703975;
					continue;
				case 6u:
					num7 = 0;
					num = ((int)num2 * -1650835212) ^ -1224416797;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = 1513472131;
						num9 = 1513472131;
					}
					else
					{
						num8 = 2061231421;
						num9 = 2061231421;
					}
					num = num8 ^ (int)(num2 * 332319037);
					continue;
				}
				case 4u:
					jSONNode = json[num4];
					num = ((int)num2 * -50183239) ^ -128818036;
					continue;
				case 3u:
					num = (int)((num2 * 743293077) ^ 0x125034CD);
					continue;
				case 2u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -1014232337;
					continue;
				case 1u:
					num = ((int)num2 * -709645380) ^ -1427747246;
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
			int num = 715195297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24349B2Du) % 3u)
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
				num = (int)((num2 * 1048553485) ^ 0x76A513CD);
			}
		}
	}

	private string CardsToString()
	{
		int num6 = default(int);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 479118687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62A0F21Cu) % 16u)
				{
				case 15u:
					num6 = 0;
					num = (int)((num2 * 720312876) ^ 0x4C2E97DD);
					continue;
				case 13u:
					card = cards[num6];
					num = 151549483;
					continue;
				case 12u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 1643576228) ^ 0x4E577932);
					continue;
				case 11u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 1493546350;
					continue;
				}
				case 10u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -47352513) ^ 0x7E4FDF1E;
					continue;
				case 9u:
					num6++;
					num = (int)(num2 * 1824854088) ^ -1711294916;
					continue;
				case 8u:
				{
					int num7;
					if (num6 >= cards.Length)
					{
						num = 779883472;
						num7 = 779883472;
					}
					else
					{
						num = 1667815121;
						num7 = 1667815121;
					}
					continue;
				}
				case 7u:
				{
					int num4;
					int num5;
					if (num3 == card.Type)
					{
						num4 = -37672200;
						num5 = -37672200;
					}
					else
					{
						num4 = -1620274414;
						num5 = -1620274414;
					}
					num = num4 ^ ((int)num2 * -430249767);
					continue;
				}
				case 6u:
					num3 = 0;
					cards = Cards;
					num = (int)((num2 * 1803192976) ^ 0x3E8EAB03);
					continue;
				case 5u:
					num = (int)((num2 * 1324083753) ^ 0x7A8747E9);
					continue;
				case 4u:
					num3 = card.Type;
					num = ((int)num2 * -417648470) ^ 0x53F78F0F;
					continue;
				case 3u:
					text = "[\n\t";
					num = (int)((num2 * 1010551266) ^ 0x77DF94EC);
					continue;
				case 2u:
					num = ((int)num2 * -1247581739) ^ -1742119089;
					continue;
				case 1u:
					num = (int)(num2 * 663121215) ^ -1177353943;
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
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1223894879;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC94E64A5u) % 9u)
				{
				case 8u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -633602248;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -99600819;
						num5 = -99600819;
					}
					else
					{
						num4 = -1897145184;
						num5 = -1897145184;
					}
					num = num4 ^ ((int)num2 * -1790451585);
					continue;
				}
				case 5u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -698796185) ^ 0x66650A19;
					continue;
				case 4u:
					num3++;
					num = (int)((num2 * 1821731673) ^ 0x64D717DA);
					continue;
				case 3u:
					num3 = 1;
					num = (int)((num2 * 2067942190) ^ 0x2A72BEFC);
					continue;
				case 2u:
					num = (int)(num2 * 1656936559) ^ -1056471872;
					continue;
				case 0u:
					flag = num3 < RiskChances.Length;
					num = -1972581814;
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
