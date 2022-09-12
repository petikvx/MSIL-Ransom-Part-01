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
		while (true)
		{
			int num = 1709003038;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64F21D8Cu) % 4u)
				{
				case 2u:
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
					num = (int)(num2 * 582284632) ^ -1746001935;
					continue;
				}
				case 1u:
					num = (int)(num2 * 512131656) ^ -2133429045;
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
		int num = 0;
		float[] result = default(float[]);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 12196454;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x5CBFFF4u) % 8u)
				{
				case 7u:
					num++;
					num2 = ((int)num3 * -1521078230) ^ 0x10CA7F1A;
					continue;
				case 5u:
					result = array;
					num2 = (int)((num3 * 1985036942) ^ 0x3A5A4033);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 529810307;
						num5 = 529810307;
					}
					else
					{
						num4 = 972057973;
						num5 = 972057973;
					}
					num2 = num4 ^ ((int)num3 * -906283937);
					continue;
				}
				case 3u:
					array[num] = json[num].AsFloat;
					num2 = 253167971;
					continue;
				case 2u:
					num2 = (int)((num3 * 1489886081) ^ 0x434E2F4E);
					continue;
				case 0u:
					flag = num < array.Length;
					num2 = 671455816;
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
		bool flag4 = default(bool);
		int num7 = default(int);
		int count = default(int);
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num6 = default(int);
		List<Card> list = default(List<Card>);
		bool flag3 = default(bool);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -148560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0E3702Cu) % 24u)
				{
				case 23u:
					flag4 = num7 < count;
					num = -1431313568;
					continue;
				case 22u:
					num = ((int)num2 * -1429053741) ^ -677890320;
					continue;
				case 20u:
					num3++;
					num = ((int)num2 * -233608169) ^ 0x7183A19E;
					continue;
				case 19u:
					num7 = 0;
					num = ((int)num2 * -1877351456) ^ -344973375;
					continue;
				case 18u:
					jSONNode = json[num7];
					num = -1365483725;
					continue;
				case 17u:
					num = ((int)num2 * -484579915) ^ 0x2EB296F5;
					continue;
				case 16u:
					num7++;
					num = ((int)num2 * -217753717) ^ 0xC8F17BB;
					continue;
				case 14u:
				{
					bool flag2 = num6 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num6)) : (maxImpact * 2 - num6)),
						Type = num7
					});
					num = -1218892827;
					continue;
				}
				case 13u:
					flag3 = num6 < maxImpact * 2;
					num = -1064712210;
					continue;
				case 12u:
					count = json.Count;
					list = new List<Card>();
					num = (int)((num2 * 104840653) ^ 0x3D2BB0C3);
					continue;
				case 11u:
					num = -909874612;
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -1339436619;
						num11 = -1339436619;
					}
					else
					{
						num10 = -1294854746;
						num11 = -1294854746;
					}
					num = num10 ^ (int)(num2 * 955810565);
					continue;
				}
				case 9u:
					num = (int)(num2 * 759058747) ^ -1046325894;
					continue;
				case 8u:
					num = ((int)num2 * -68977374) ^ -2038885618;
					continue;
				case 7u:
					num6 = 0;
					num = ((int)num2 * -967490191) ^ -641510798;
					continue;
				case 6u:
					flag = num3 < jSONNode[num6].AsInt;
					num = -2021883539;
					continue;
				case 5u:
					num = ((int)num2 * -68163084) ^ -92279777;
					continue;
				case 4u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = 2058256839;
						num9 = 2058256839;
					}
					else
					{
						num8 = 217455182;
						num9 = 217455182;
					}
					num = num8 ^ ((int)num2 * -1955109566);
					continue;
				}
				case 3u:
					result = list.ToArray();
					num = (int)(num2 * 1459185265) ^ -50625982;
					continue;
				case 2u:
					num6++;
					num = ((int)num2 * -1381169481) ^ 0x5D1A3C0F;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -568764830;
						num5 = -568764830;
					}
					else
					{
						num4 = -1961788940;
						num5 = -1961788940;
					}
					num = num4 ^ (int)(num2 * 263551142);
					continue;
				}
				case 0u:
					num3 = 0;
					num = (int)((num2 * 1974111769) ^ 0x4370354A);
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

	public override string ToString()
	{
		return Rules.smethod_0("sprints: {0},\nmax-impact:{1},\ndeck: \n{2},\n\ninitial-resources: {3},\n\nnormal-planning-count: {4},\nnormal-planning-cost: {5},\nover-planning-cost: {6},\nsprints-won-without-planning: {7},\n\nrisk-chances: {8},\n\neconomics-affects-all: {9},\nstay-on-sprint-min-diff: {10},\nonly-one-winner: {11}", new object[12]
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
	}

	private string CardsToString()
	{
		bool flag = default(bool);
		int num4 = default(int);
		Card[] cards = default(Card[]);
		string text = default(string);
		Card card = default(Card);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 2028863195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57D1B9F4u) % 19u)
				{
				case 18u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -833382213;
						num6 = -833382213;
					}
					else
					{
						num5 = -2068108182;
						num6 = -2068108182;
					}
					num = num5 ^ ((int)num2 * -866574090);
					continue;
				}
				case 17u:
					num = ((int)num2 * -676152309) ^ 0x3FE6849A;
					continue;
				case 16u:
				{
					int num7;
					if (num4 < cards.Length)
					{
						num = 1976523009;
						num7 = 1976523009;
					}
					else
					{
						num = 1564204540;
						num7 = 1564204540;
					}
					continue;
				}
				case 15u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 813522925;
					continue;
				}
				case 14u:
					num = ((int)num2 * -120764828) ^ -327748985;
					continue;
				case 12u:
					text = Rules.smethod_1(text, "\n\t");
					num3 = card.Type;
					num = ((int)num2 * -1025291936) ^ -1945374624;
					continue;
				case 11u:
					num = (int)((num2 * 245486774) ^ 0x23E7BA77);
					continue;
				case 10u:
					num = ((int)num2 * -1312318409) ^ -211871793;
					continue;
				case 9u:
					num4++;
					num = (int)(num2 * 1776344083) ^ -17881477;
					continue;
				case 8u:
					card = cards[num4];
					num = 1247269475;
					continue;
				case 7u:
					cards = Cards;
					num = (int)((num2 * 134877862) ^ 0x1F079FA7);
					continue;
				case 6u:
					num3 = 0;
					num = (int)(num2 * 1824776011) ^ -27786814;
					continue;
				case 5u:
					num = (int)(num2 * 438115803) ^ -1994245102;
					continue;
				case 4u:
					text = "[\n\t";
					num = ((int)num2 * -1795104916) ^ -709683088;
					continue;
				case 2u:
					num4 = 0;
					num = ((int)num2 * -920524155) ^ -2039308585;
					continue;
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 1144003449) ^ -346773352;
					continue;
				case 0u:
					flag = num3 != card.Type;
					num = ((int)num2 * -1193292982) ^ 0x1DAA5F9C;
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

	private string RiskChancesToString()
	{
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = -1939702954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA3425E1u) % 9u)
				{
				case 8u:
					num3++;
					num = ((int)num2 * -913828877) ^ -1887629795;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1070301924;
						num5 = -1070301924;
					}
					else
					{
						num4 = -1243444993;
						num5 = -1243444993;
					}
					num = num4 ^ (int)(num2 * 2098287936);
					continue;
				}
				case 4u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 248394615) ^ -1275134990;
					continue;
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -1398356239;
					continue;
				case 2u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -2120503131) ^ 0x6419F3F5;
					continue;
				case 1u:
					num = ((int)num2 * -1003931975) ^ 0x4E5573C2;
					continue;
				case 0u:
					flag = num3 < RiskChances.Length;
					num = -1923602966;
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
