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
			int num = 1835652016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34DD53Eu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1584395513) ^ -15975295;
					continue;
				case 1u:
					num = (int)((num2 * 1481230555) ^ 0x18FD2445);
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = default(int);
		Rules result = default(Rules);
		while (true)
		{
			int num = 2082455348;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38076Au) % 4u)
				{
				case 2u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -847398220) ^ 0x1F079C1B;
					continue;
				case 1u:
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
					num = ((int)num2 * -376732030) ^ -1585612913;
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
		float[] array = default(float[]);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = -493103991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5AC2D66u) % 9u)
				{
				case 8u:
					array = new float[json.Count];
					num3 = 0;
					num = (int)(num2 * 673947816) ^ -1259191291;
					continue;
				case 7u:
					num = (int)(num2 * 1225540399) ^ -642357104;
					continue;
				case 5u:
					array[num3] = json[num3].AsFloat;
					num = -415843439;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -322877325;
						num4 = -322877325;
					}
					else
					{
						num = -1328452989;
						num4 = -1328452989;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -117156689) ^ -252822396;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -834654001) ^ -1121026180;
					continue;
				case 1u:
					result = array;
					num = ((int)num2 * -564529094) ^ 0x1FA13E11;
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
		int num4 = default(int);
		List<Card> list = default(List<Card>);
		int num5 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -481787199;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCF08AE4u) % 22u)
				{
				case 21u:
					num = -2073603000;
					continue;
				case 20u:
				{
					int num9;
					if (num4 >= count)
					{
						num = -232340783;
						num9 = -232340783;
					}
					else
					{
						num = -1814048251;
						num9 = -1814048251;
					}
					continue;
				}
				case 19u:
					list = new List<Card>();
					num4 = 0;
					num = (int)((num2 * 1343289499) ^ 0x12CA5847);
					continue;
				case 18u:
					num5++;
					num = (int)((num2 * 1012069927) ^ 0x3F78A84A);
					continue;
				case 17u:
					num = ((int)num2 * -403480617) ^ -2008992053;
					continue;
				case 16u:
					num5 = 0;
					num = (int)((num2 * 515670718) ^ 0x44E289A5);
					continue;
				case 15u:
					num = ((int)num2 * -638725541) ^ -245515367;
					continue;
				case 14u:
					num3 = 0;
					num = -1524827366;
					continue;
				case 13u:
					flag2 = num3 < jSONNode[num5].AsInt;
					num = -599004925;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -2138168045;
						num8 = -2138168045;
					}
					else
					{
						num7 = -324183451;
						num8 = -324183451;
					}
					num = num7 ^ (int)(num2 * 603372210);
					continue;
				}
				case 10u:
				{
					int num6;
					if (num5 >= maxImpact * 2)
					{
						num = -151889495;
						num6 = -151889495;
					}
					else
					{
						num = -426666180;
						num6 = -426666180;
					}
					continue;
				}
				case 9u:
					num = -1230971149;
					continue;
				case 8u:
				{
					bool flag = num5 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num4
					});
					num = -796882061;
					continue;
				}
				case 7u:
					jSONNode = json[num4];
					num = (int)((num2 * 13929434) ^ 0x6A27835E);
					continue;
				case 6u:
					num = (int)((num2 * 640996690) ^ 0x67C1B04A);
					continue;
				case 5u:
					result = list.ToArray();
					num = ((int)num2 * -1289490149) ^ 0x5FD7E761;
					continue;
				case 3u:
					num = (int)((num2 * 2043004778) ^ 0x5D516DF6);
					continue;
				case 2u:
					num4++;
					num = ((int)num2 * -1994464921) ^ -1801865296;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -933652613) ^ 0x11B35B7E;
					continue;
				case 0u:
					num = ((int)num2 * -1761793744) ^ -1223589293;
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
			int num = -841830988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD62297B5u) % 3u)
				{
				case 2u:
					goto IL_00b5;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_00b5:
				num = (int)(num2 * 1926885189) ^ -2096248498;
			}
		}
	}

	private string CardsToString()
	{
		string text = default(string);
		Card card = default(Card);
		int num5 = default(int);
		int num3 = default(int);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = -1112451695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC97AD250u) % 17u)
				{
				case 16u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -1604343829;
					continue;
				}
				case 15u:
					text = Rules.smethod_1(text, "\n\t");
					num5 = card.Type;
					num = ((int)num2 * -140931738) ^ 0x6DDCC796;
					continue;
				case 14u:
				{
					int num6;
					int num7;
					if (num5 == card.Type)
					{
						num6 = -1032109698;
						num7 = -1032109698;
					}
					else
					{
						num6 = -976096462;
						num7 = -976096462;
					}
					num = num6 ^ ((int)num2 * -1571725924);
					continue;
				}
				case 13u:
					num5 = 0;
					num = ((int)num2 * -1337151537) ^ 0x15B58865;
					continue;
				case 12u:
					num = (int)(num2 * 2016210173) ^ -1294443740;
					continue;
				case 11u:
					num3++;
					num = (int)(num2 * 1528691653) ^ -1779949791;
					continue;
				case 9u:
					card = cards[num3];
					num = -794649364;
					continue;
				case 8u:
					num = (int)(num2 * 1559354469) ^ -2060517886;
					continue;
				case 7u:
				{
					int num4;
					if (num3 >= cards.Length)
					{
						num = -1855456261;
						num4 = -1855456261;
					}
					else
					{
						num = -511711742;
						num4 = -511711742;
					}
					continue;
				}
				case 6u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1344721091) ^ 0x1674DFA9;
					continue;
				case 5u:
					cards = Cards;
					num3 = 0;
					num = (int)((num2 * 1979728182) ^ 0x66049202);
					continue;
				case 4u:
					num = (int)((num2 * 1987779338) ^ 0x6E8A7285);
					continue;
				case 3u:
					num = ((int)num2 * -1918289058) ^ 0x5B595362;
					continue;
				case 1u:
					text = "[\n\t";
					num = ((int)num2 * -1139862603) ^ -1001938191;
					continue;
				case 0u:
					num = ((int)num2 * -602399449) ^ 0x7A07C83E;
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
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num = 1;
		string result = default(string);
		while (true)
		{
			bool flag = num < RiskChances.Length;
			int num2 = -1118559234;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x9668CA9Du) % 6u)
				{
				case 5u:
					result = Rules.smethod_1(string_, " ]");
					num2 = (int)((num3 * 1142762382) ^ 0x4BCDC454);
					continue;
				case 4u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num++;
					num2 = -680406727;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1176470039;
						num5 = 1176470039;
					}
					else
					{
						num4 = 1164411624;
						num5 = 1164411624;
					}
					num2 = num4 ^ (int)(num3 * 1075038725);
					continue;
				}
				case 0u:
					num2 = -1076482553;
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
