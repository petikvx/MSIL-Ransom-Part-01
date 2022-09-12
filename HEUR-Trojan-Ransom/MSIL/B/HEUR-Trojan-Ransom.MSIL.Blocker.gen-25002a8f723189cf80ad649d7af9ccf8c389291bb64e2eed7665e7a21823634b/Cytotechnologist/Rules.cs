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
			int num = -1749923933;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E892D92u) % 4u)
				{
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -2071083199) ^ -2128614749;
					continue;
				case 0u:
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
					num = (int)((num2 * 597155355) ^ 0x3A4ED4);
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		int num3 = default(int);
		float[] result = default(float[]);
		bool flag = default(bool);
		while (true)
		{
			int num = -1575156478;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFEE93D2u) % 7u)
				{
				case 6u:
					num3 = 0;
					num = (int)((num2 * 959630210) ^ 0x52DF3332);
					continue;
				case 5u:
					result = array;
					num = (int)((num2 * 1184647873) ^ 0x62D7035D);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1528618867;
						num5 = 1528618867;
					}
					else
					{
						num4 = 1484474665;
						num5 = 1484474665;
					}
					num = num4 ^ ((int)num2 * -1563862713);
					continue;
				}
				case 1u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = -801720686;
					continue;
				case 0u:
					flag = num3 < array.Length;
					num = -1710840109;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		bool flag = default(bool);
		int num4 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		int num8 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int count = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -707382339;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9AF47EBu) % 25u)
				{
				case 24u:
					num = (int)((num2 * 2141525178) ^ 0x6871A07);
					continue;
				case 23u:
					flag = num4 < maxImpact * 2;
					num = -703863205;
					continue;
				case 22u:
					num4 = 0;
					num = (int)(num2 * 712845680) ^ -494049935;
					continue;
				case 21u:
					num = -122036687;
					continue;
				case 20u:
					num = (int)((num2 * 1264352482) ^ 0x103EBB46);
					continue;
				case 19u:
					result = list.ToArray();
					num = (int)((num2 * 99797160) ^ 0x237FF427);
					continue;
				case 18u:
					num3 = 0;
					num = (int)((num2 * 1570488895) ^ 0x70800042);
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -2038755603;
						num7 = -2038755603;
					}
					else
					{
						num6 = -313389561;
						num7 = -313389561;
					}
					num = num6 ^ (int)(num2 * 581038425);
					continue;
				}
				case 15u:
					num4++;
					num = ((int)num2 * -1554882375) ^ 0x6B157E00;
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -602520797) ^ 0x5A655C42;
					continue;
				case 13u:
					num8++;
					num = ((int)num2 * -1535470400) ^ 0x1242984C;
					continue;
				case 12u:
					jSONNode = json[num8];
					num = (int)((num2 * 447254262) ^ 0x16D85E4C);
					continue;
				case 11u:
					count = json.Count;
					list = new List<Card>();
					num8 = 0;
					num = ((int)num2 * -285821913) ^ -660737715;
					continue;
				case 10u:
					num = ((int)num2 * -117926690) ^ 0x47759CF0;
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 748826872;
						num10 = 748826872;
					}
					else
					{
						num9 = 1414477427;
						num10 = 1414477427;
					}
					num = num9 ^ ((int)num2 * -271336558);
					continue;
				}
				case 8u:
					flag3 = num8 < count;
					num = -1635176894;
					continue;
				case 7u:
					num = -1172846974;
					continue;
				case 6u:
					flag2 = num4 < maxImpact;
					num = -643483414;
					continue;
				case 5u:
					num = (int)(num2 * 243374951) ^ -963379736;
					continue;
				case 4u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num8
					});
					num = -1915507143;
					continue;
				case 3u:
				{
					int num5;
					if (num3 >= jSONNode[num4].AsInt)
					{
						num = -1339203912;
						num5 = -1339203912;
					}
					else
					{
						num = -1249567448;
						num5 = -1249567448;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -336047458) ^ -88582207;
					continue;
				case 1u:
					num = ((int)num2 * -219477453) ^ -827844301;
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
			int num = 495644185;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E5364BDu) % 3u)
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
				num = ((int)num2 * -963140577) ^ 0x2AE37E15;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		string result = default(string);
		int num5 = default(int);
		Card card = default(Card);
		bool flag = default(bool);
		int num3 = default(int);
		Card[] cards = default(Card[]);
		while (true)
		{
			int num = -629866534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE09D3BF5u) % 17u)
				{
				case 16u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -478425181) ^ -929911284;
					continue;
				case 15u:
					num = ((int)num2 * -580443637) ^ 0xC2ECADE;
					continue;
				case 14u:
					num5 = card.Type;
					num = ((int)num2 * -143209993) ^ -1130437983;
					continue;
				case 13u:
					num = ((int)num2 * -1165106059) ^ 0x566658E8;
					continue;
				case 12u:
					flag = num5 != card.Type;
					num = (int)(num2 * 903310933) ^ -1540574006;
					continue;
				case 11u:
					num3++;
					num = ((int)num2 * -260433470) ^ -1122194492;
					continue;
				case 10u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1814152173;
					continue;
				}
				case 9u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1793812087;
						num7 = -1793812087;
					}
					else
					{
						num6 = -1514802402;
						num7 = -1514802402;
					}
					num = num6 ^ ((int)num2 * -339342521);
					continue;
				}
				case 7u:
					num5 = 0;
					num = (int)(num2 * 833585093) ^ -1572580712;
					continue;
				case 6u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1479516204) ^ 0x1B6754E2;
					continue;
				case 5u:
					card = cards[num3];
					num = -1098108249;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -765296898) ^ -332528926;
					continue;
				case 2u:
					cards = Cards;
					num = ((int)num2 * -501904384) ^ -972716700;
					continue;
				case 1u:
					num = ((int)num2 * -2018900948) ^ -633127164;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= cards.Length)
					{
						num = -199479971;
						num4 = -199479971;
					}
					else
					{
						num = -1350982473;
						num4 = -1350982473;
					}
					continue;
				}
				case 8u:
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
		bool flag = default(bool);
		int num3 = default(int);
		string result = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = -1227094299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD84C3CB6u) % 10u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1120444071;
						num5 = -1120444071;
					}
					else
					{
						num4 = -1659526382;
						num5 = -1659526382;
					}
					num = num4 ^ (int)(num2 * 345621510);
					continue;
				}
				case 7u:
					num3 = 1;
					num = ((int)num2 * -1404023997) ^ -613140695;
					continue;
				case 6u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -1163024287) ^ -878351432;
					continue;
				case 5u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -2123292113) ^ -299417624;
					continue;
				case 4u:
					num = ((int)num2 * -118545221) ^ 0x795AC5BF;
					continue;
				case 2u:
					flag = num3 < RiskChances.Length;
					num = -640040578;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num3++;
					num = -1458766048;
					continue;
				case 0u:
					num = (int)((num2 * 2098807172) ^ 0x301629F8);
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
