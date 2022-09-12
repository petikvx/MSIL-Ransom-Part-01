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
			int num = 1395841228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73A6E5C9u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 279835641) ^ -1414261589;
					continue;
				case 1u:
					num = ((int)num2 * -559949301) ^ -626011744;
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
		int asInt = json["max-impact"].AsInt;
		Rules result = default(Rules);
		while (true)
		{
			int num = -1749359873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3C85BACu) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0016:
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
				num = ((int)num2 * -1667116867) ^ 0xA215C8F;
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1122014609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA582A20u) % 8u)
				{
				case 6u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 1400882536;
						num4 = 1400882536;
					}
					else
					{
						num = 1826465682;
						num4 = 1826465682;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -907814966) ^ 0x671D3B47;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1557691339) ^ 0x3936E639;
					continue;
				case 2u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 662419998;
					continue;
				case 1u:
					array = new float[json.Count];
					num = (int)(num2 * 1190417120) ^ -706104149;
					continue;
				case 0u:
					result = array;
					num = (int)(num2 * 602918682) ^ -1098064740;
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
		int num4 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num5 = default(int);
		List<Card> list = default(List<Card>);
		int num3 = default(int);
		bool flag2 = default(bool);
		int count = default(int);
		bool flag = default(bool);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = 960382170;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6DD110u) % 21u)
				{
				case 20u:
				{
					int num10;
					if (num4 >= jSONNode[num5].AsInt)
					{
						num = 324445503;
						num10 = 324445503;
					}
					else
					{
						num = 473535989;
						num10 = 473535989;
					}
					continue;
				}
				case 19u:
				{
					bool flag3 = num5 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num5)) : (maxImpact * 2 - num5)),
						Type = num3
					});
					num = 1045530709;
					continue;
				}
				case 17u:
					num3 = 0;
					num = (int)(num2 * 1763077735) ^ -1484563311;
					continue;
				case 16u:
					num = (int)((num2 * 1890871356) ^ 0x77945C8D);
					continue;
				case 15u:
					flag2 = num3 < count;
					num = 2136237116;
					continue;
				case 14u:
					count = json.Count;
					list = new List<Card>();
					num = ((int)num2 * -157743486) ^ -1033836226;
					continue;
				case 13u:
					num5 = 0;
					num = ((int)num2 * -1254586947) ^ 0x335CC236;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 1248285019;
						num9 = 1248285019;
					}
					else
					{
						num8 = 1723588942;
						num9 = 1723588942;
					}
					num = num8 ^ (int)(num2 * 1228052766);
					continue;
				}
				case 11u:
					num5++;
					num = (int)((num2 * 2069818238) ^ 0x4F010F74);
					continue;
				case 10u:
					num = ((int)num2 * -894130980) ^ -1205074254;
					continue;
				case 9u:
					num4++;
					num = ((int)num2 * -251446668) ^ 0x65090749;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -609534974;
						num7 = -609534974;
					}
					else
					{
						num6 = -349804381;
						num7 = -349804381;
					}
					num = num6 ^ ((int)num2 * -1297181121);
					continue;
				}
				case 6u:
					num3++;
					num = ((int)num2 * -1557513207) ^ -1479065744;
					continue;
				case 5u:
					flag = num5 < maxImpact * 2;
					num = 1976543619;
					continue;
				case 4u:
					num = 88029535;
					continue;
				case 3u:
					num4 = 0;
					num = ((int)num2 * -720757832) ^ -1250210120;
					continue;
				case 2u:
					result = list.ToArray();
					num = (int)((num2 * 1484855596) ^ 0x35C27B9C);
					continue;
				case 1u:
					jSONNode = json[num3];
					num = ((int)num2 * -1200719011) ^ -1377577809;
					continue;
				case 0u:
					num = 1430417685;
					continue;
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
			int num = 1528550206;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x404E75A5u) % 3u)
				{
				case 1u:
					goto IL_00b5;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_00b5:
				num = (int)((num2 * 2056956913) ^ 0x5411AFA7);
			}
		}
	}

	private string CardsToString()
	{
		int num3 = default(int);
		Card[] cards = default(Card[]);
		int num4 = default(int);
		Card card = default(Card);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1266946347;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA79B8BCu) % 20u)
				{
				case 19u:
				{
					int num7;
					if (num3 >= cards.Length)
					{
						num = -482648534;
						num7 = -482648534;
					}
					else
					{
						num = -1293179609;
						num7 = -1293179609;
					}
					continue;
				}
				case 18u:
					num4 = card.Type;
					num = (int)((num2 * 1788850830) ^ 0x6E67EDFB);
					continue;
				case 17u:
					num3++;
					num = ((int)num2 * -1563361016) ^ 0x38CAF90F;
					continue;
				case 16u:
					num = ((int)num2 * -1595221720) ^ -2105521819;
					continue;
				case 15u:
					card = cards[num3];
					num = -551366460;
					continue;
				case 14u:
					num = ((int)num2 * -112182616) ^ 0x4814920A;
					continue;
				case 13u:
					num4 = 0;
					num = ((int)num2 * -966172284) ^ -759836405;
					continue;
				case 12u:
					num = ((int)num2 * -1392707258) ^ -675461419;
					continue;
				case 10u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1763878934) ^ 0x7A99D092;
					continue;
				case 9u:
					text = "[\n\t";
					num = (int)(num2 * 1638308062) ^ -1938073285;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 959253038;
						num6 = 959253038;
					}
					else
					{
						num5 = 1148301589;
						num6 = 1148301589;
					}
					num = num5 ^ ((int)num2 * -301192855);
					continue;
				}
				case 7u:
					cards = Cards;
					num = (int)(num2 * 863284257) ^ -328272943;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -1901645957) ^ 0x70A76FED;
					continue;
				case 5u:
					flag = num4 != card.Type;
					num = (int)((num2 * 410509669) ^ 0x5F6FA8F9);
					continue;
				case 3u:
					num = (int)((num2 * 590533908) ^ 0x5F181FD1);
					continue;
				case 2u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1130370017) ^ -1305876146;
					continue;
				case 1u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -225396344;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1124281300) ^ 0x554BA1D8;
					continue;
				case 11u:
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
		int num5 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 601276261;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21F0DEA8u) % 8u)
				{
				case 7u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num5++;
					num = 1981469182;
					continue;
				case 6u:
					flag = num5 < RiskChances.Length;
					num = 1411231976;
					continue;
				case 5u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num5 = 1;
					num = (int)(num2 * 1773724092) ^ -966381966;
					continue;
				case 4u:
					num = (int)((num2 * 1012501791) ^ 0x11CF1947);
					continue;
				case 1u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 217542745) ^ -763930947;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1318508289;
						num4 = 1318508289;
					}
					else
					{
						num3 = 1087260463;
						num4 = 1087260463;
					}
					num = num3 ^ (int)(num2 * 276311712);
					continue;
				}
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
