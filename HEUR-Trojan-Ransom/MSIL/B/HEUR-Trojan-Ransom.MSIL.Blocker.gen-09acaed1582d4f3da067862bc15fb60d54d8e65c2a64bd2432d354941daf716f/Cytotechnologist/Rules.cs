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
			int num = 111582815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AF62393u) % 3u)
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
				num = ((int)num2 * -150291672) ^ 0x28FAD9BE;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		while (true)
		{
			int num = -1102681170;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x883B4EACu) % 3u)
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
				num = ((int)num2 * -1240701469) ^ 0x3D71E6BD;
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		int num = 0;
		float[] result = default(float[]);
		while (true)
		{
			int num2;
			int num3;
			if (num >= array.Length)
			{
				num2 = -1447870000;
				num3 = -1447870000;
			}
			else
			{
				num2 = -153326044;
				num3 = -153326044;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xA58434CDu) % 6u)
				{
				case 5u:
					array[num] = json[num].AsFloat;
					num++;
					num2 = -1031706161;
					continue;
				case 3u:
					result = array;
					num2 = (int)((num4 * 1141423143) ^ 0x381B611D);
					continue;
				case 1u:
					num2 = ((int)num4 * -12485508) ^ 0x5BBB8FBD;
					continue;
				case 0u:
					num2 = -153326044;
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
		bool flag = default(bool);
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num5 = default(int);
		JSONNode jSONNode = default(JSONNode);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -13776006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x806D8E3Fu) % 24u)
				{
				case 23u:
					num = (int)((num2 * 1545396423) ^ 0x66EC2C3E);
					continue;
				case 22u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 236728598;
						num10 = 236728598;
					}
					else
					{
						num9 = 727871917;
						num10 = 727871917;
					}
					num = num9 ^ (int)(num2 * 542415561);
					continue;
				}
				case 21u:
					num = -330634604;
					continue;
				case 20u:
					num6++;
					num = ((int)num2 * -681140442) ^ -1084184647;
					continue;
				case 19u:
					flag3 = num6 < maxImpact;
					num = ((int)num2 * -1944403591) ^ 0x11E223B8;
					continue;
				case 17u:
					flag2 = num5 < jSONNode[num6].AsInt;
					num = -372599515;
					continue;
				case 16u:
					num = (int)(num2 * 813671164) ^ -1996937148;
					continue;
				case 15u:
					num5 = 0;
					num = -1161954338;
					continue;
				case 14u:
					num6 = 0;
					num = ((int)num2 * -1268904639) ^ 0x2782A7BC;
					continue;
				case 13u:
					num = (int)((num2 * 1545108982) ^ 0x18880E1F);
					continue;
				case 12u:
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num6)) : (maxImpact * 2 - num6)),
						Type = num3
					});
					num = -1915371091;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -104873404;
						num8 = -104873404;
					}
					else
					{
						num7 = -1273073040;
						num8 = -1273073040;
					}
					num = num7 ^ (int)(num2 * 1698329831);
					continue;
				}
				case 9u:
					num = -1116971857;
					continue;
				case 8u:
					jSONNode = json[num3];
					num = ((int)num2 * -1502923011) ^ -297883511;
					continue;
				case 7u:
					num5++;
					num = ((int)num2 * -1415848496) ^ -50545170;
					continue;
				case 6u:
					flag = num6 < maxImpact * 2;
					num = -1685747511;
					continue;
				case 5u:
					list = new List<Card>();
					num3 = 0;
					num = ((int)num2 * -239284304) ^ -67515744;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 518205084) ^ -1222532537;
					continue;
				case 3u:
					result = list.ToArray();
					num = (int)((num2 * 267989393) ^ 0x490EDAA4);
					continue;
				case 2u:
					num = (int)((num2 * 840617432) ^ 0x53871430);
					continue;
				case 1u:
					num = (int)((num2 * 1138719859) ^ 0x78087478);
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -1210621524;
						num4 = -1210621524;
					}
					else
					{
						num = -87136530;
						num4 = -87136530;
					}
					continue;
				}
				case 18u:
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
			int num = 1720279958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D37D4Cu) % 3u)
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
				num = (int)((num2 * 326803721) ^ 0x64025622);
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		int num3 = default(int);
		Card card = default(Card);
		int num4 = default(int);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = -332445195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB525BAF9u) % 16u)
				{
				case 15u:
				{
					int num6;
					int num7;
					if (num3 == card.Type)
					{
						num6 = -1774743929;
						num7 = -1774743929;
					}
					else
					{
						num6 = -2085196344;
						num7 = -2085196344;
					}
					num = num6 ^ ((int)num2 * -1455880699);
					continue;
				}
				case 14u:
				{
					int num5;
					if (num4 >= cards.Length)
					{
						num = -2120094689;
						num5 = -2120094689;
					}
					else
					{
						num = -1698816502;
						num5 = -1698816502;
					}
					continue;
				}
				case 12u:
					num3 = 0;
					num = ((int)num2 * -433041317) ^ -1535316934;
					continue;
				case 11u:
					num = ((int)num2 * -763614928) ^ 0x11388F6;
					continue;
				case 10u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)((num2 * 590346598) ^ 0x70DD90E4);
					continue;
				case 9u:
					num4++;
					num = (int)(num2 * 1260833664) ^ -1699450489;
					continue;
				case 8u:
					num = ((int)num2 * -1539657280) ^ -302967744;
					continue;
				case 7u:
					cards = Cards;
					num4 = 0;
					num = ((int)num2 * -2000226295) ^ 0x72675BF6;
					continue;
				case 6u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 771968020) ^ 0x2E563CC3);
					continue;
				case 5u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1739132639;
					continue;
				}
				case 3u:
					card = cards[num4];
					num = -1599618510;
					continue;
				case 2u:
					num = ((int)num2 * -1795063648) ^ 0x7435F154;
					continue;
				case 1u:
					num3 = card.Type;
					num = (int)(num2 * 538261675) ^ -1437764713;
					continue;
				case 0u:
					num = (int)(num2 * 2113474695) ^ -1376278313;
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

	private string RiskChancesToString()
	{
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1904874014;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F29C4B5u) % 8u)
				{
				case 6u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 475181928;
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -1545587181) ^ 0x7D2FF2AB;
					continue;
				case 4u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 2110627013) ^ -424916095;
					continue;
				case 3u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -1202550584) ^ 0x5C2DFC54;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = 378353353;
						num4 = 378353353;
					}
					else
					{
						num = 1657505147;
						num4 = 1657505147;
					}
					continue;
				}
				case 0u:
					num = ((int)num2 * -1736290697) ^ -260984193;
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
