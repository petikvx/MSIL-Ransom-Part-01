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
			int num = 1442790528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73A860F5u) % 3u)
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
				num = (int)((num2 * 1851539361) ^ 0x7A865906);
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		while (true)
		{
			int num = 912572530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x673D057Bu) % 4u)
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
					num = (int)(num2 * 66735008) ^ -1808395141;
					continue;
				}
				case 0u:
					num = (int)((num2 * 686541407) ^ 0x1124938C);
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
		int num5 = default(int);
		bool flag = default(bool);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = -1273338474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCA70405u) % 10u)
				{
				case 9u:
					num5++;
					num = (int)(num2 * 1446490161) ^ -1578414851;
					continue;
				case 8u:
					num5 = 0;
					num = (int)((num2 * 1364175070) ^ 0x6604495E);
					continue;
				case 5u:
					flag = num5 < array.Length;
					num = -1927650057;
					continue;
				case 4u:
					array[num5] = json[num5].AsFloat;
					num = -867831186;
					continue;
				case 3u:
					array = new float[json.Count];
					num = (int)((num2 * 1548272796) ^ 0x427BC945);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 136553745;
						num4 = 136553745;
					}
					else
					{
						num3 = 1241309582;
						num4 = 1241309582;
					}
					num = num3 ^ (int)(num2 * 1347324485);
					continue;
				}
				case 1u:
					result = array;
					num = ((int)num2 * -126956513) ^ 0x324DAC74;
					continue;
				case 0u:
					num = ((int)num2 * -1277848658) ^ -323271916;
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
		bool flag2 = default(bool);
		int num5 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -359020360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE2F57E4u) % 22u)
				{
				case 21u:
					num = ((int)num2 * -666562545) ^ 0x65CED98B;
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1199515802;
						num10 = -1199515802;
					}
					else
					{
						num9 = -258671353;
						num10 = -258671353;
					}
					num = num9 ^ (int)(num2 * 138238889);
					continue;
				}
				case 19u:
					num5++;
					num = (int)(num2 * 1137871062) ^ -1079455985;
					continue;
				case 18u:
					result = list.ToArray();
					num = ((int)num2 * -864311522) ^ -380018715;
					continue;
				case 17u:
					num4++;
					num = ((int)num2 * -1903806122) ^ -1920355959;
					continue;
				case 16u:
					jSONNode = json[num3];
					num5 = 0;
					num = ((int)num2 * -1678723213) ^ 0x7777B6F7;
					continue;
				case 15u:
				{
					bool flag3 = num5 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num3
					});
					num = -841013997;
					continue;
				}
				case 14u:
					list = new List<Card>();
					num = ((int)num2 * -793546921) ^ -1617573942;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -1733202421) ^ 0x16A98C98;
					continue;
				case 11u:
				{
					int num8;
					if (num4 < jSONNode[num5].AsInt)
					{
						num = -1114389442;
						num8 = -1114389442;
					}
					else
					{
						num = -1692930151;
						num8 = -1692930151;
					}
					continue;
				}
				case 10u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1340437852;
						num7 = 1340437852;
					}
					else
					{
						num6 = 901049856;
						num7 = 901049856;
					}
					num = num6 ^ ((int)num2 * -912924547);
					continue;
				}
				case 9u:
					flag2 = num5 < maxImpact * 2;
					num = -437045218;
					continue;
				case 8u:
					num = -590672563;
					continue;
				case 6u:
					num = -1128832375;
					continue;
				case 5u:
					flag = num3 < count;
					num = -1740386864;
					continue;
				case 4u:
					num = ((int)num2 * -1036475249) ^ -900033971;
					continue;
				case 3u:
					num4 = 0;
					num = (int)(num2 * 412518023) ^ -164439190;
					continue;
				case 2u:
					num3 = 0;
					num = (int)(num2 * 1674224170) ^ -382908342;
					continue;
				case 1u:
					num = ((int)num2 * -747231680) ^ 0x1E643733;
					continue;
				case 0u:
					num = -1332980474;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 826181710;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27D08088u) % 3u)
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
				num = (int)(num2 * 44037632) ^ -1095981278;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		int num = 0;
		Card[] cards = default(Card[]);
		string result = default(string);
		int num4 = default(int);
		Card card = default(Card);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -603210290;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF6581720u) % 16u)
				{
				case 15u:
					num2 = ((int)num3 * -1622430212) ^ -866261011;
					continue;
				case 14u:
					cards = Cards;
					num2 = ((int)num3 * -441861291) ^ 0x72C392B0;
					continue;
				case 13u:
					num2 = ((int)num3 * -298331264) ^ 0x6E6AAF20;
					continue;
				case 12u:
					result = Rules.smethod_1(text, "\n]");
					num2 = ((int)num3 * -88077528) ^ 0x24890263;
					continue;
				case 11u:
					num2 = ((int)num3 * -664172821) ^ -242192963;
					continue;
				case 10u:
					num2 = (int)((num3 * 257123805) ^ 0x70D490B3);
					continue;
				case 9u:
					num4++;
					num2 = ((int)num3 * -972742392) ^ -149843480;
					continue;
				case 8u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num2 = -548612033;
					continue;
				}
				case 7u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 865243371;
						num7 = 865243371;
					}
					else
					{
						num6 = 1929450041;
						num7 = 1929450041;
					}
					num2 = num6 ^ (int)(num3 * 305181495);
					continue;
				}
				case 6u:
					num4 = 0;
					num2 = ((int)num3 * -1571383558) ^ 0xC31C71;
					continue;
				case 4u:
					flag = num != card.Type;
					num2 = ((int)num3 * -413081029) ^ -325165045;
					continue;
				case 2u:
					card = cards[num4];
					num2 = -1221525093;
					continue;
				case 1u:
					text = Rules.smethod_1(text, "\n\t");
					num = card.Type;
					num2 = ((int)num3 * -1469836912) ^ -1586579048;
					continue;
				case 0u:
				{
					int num5;
					if (num4 >= cards.Length)
					{
						num2 = -160553828;
						num5 = -160553828;
					}
					else
					{
						num2 = -73936622;
						num5 = -73936622;
					}
					continue;
				}
				case 5u:
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
			int num = -538495664;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3DBAA49u) % 8u)
				{
				case 7u:
					num5 = 1;
					num = ((int)num2 * -1863090240) ^ 0x3DDF1105;
					continue;
				case 6u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num5++;
					num = -1433199803;
					continue;
				case 4u:
					flag = num5 < RiskChances.Length;
					num = -282713453;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 562565691;
						num4 = 562565691;
					}
					else
					{
						num3 = 517231565;
						num4 = 517231565;
					}
					num = num3 ^ ((int)num2 * -476357022);
					continue;
				}
				case 1u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -2035483383) ^ -768592001;
					continue;
				case 0u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1788710768) ^ 0x4BA32672;
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
