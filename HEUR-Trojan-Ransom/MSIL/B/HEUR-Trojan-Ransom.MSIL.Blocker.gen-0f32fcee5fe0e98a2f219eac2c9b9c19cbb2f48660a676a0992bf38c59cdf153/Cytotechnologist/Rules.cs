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
			int num = 1685828018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x768327B2u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -516276543) ^ 0x6E587262;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		int asInt = json["max-impact"].AsInt;
		Rules result = new Rules
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
		while (true)
		{
			int num = 63540271;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x714F7D12u) % 3u)
				{
				case 1u:
					goto IL_0113;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0113:
				num = (int)((num2 * 1226323380) ^ 0x52ECF6EC);
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		float[] result = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = -1358551109;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CE64DFAu) % 8u)
				{
				case 7u:
					num = ((int)num2 * -1422514535) ^ 0x7895EAA1;
					continue;
				case 6u:
					result = array;
					num = ((int)num2 * -1181077308) ^ 0x3C889449;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -343814324;
						num4 = -343814324;
					}
					else
					{
						num = -661603878;
						num4 = -661603878;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -1267363626) ^ -1005990651;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 1550818742) ^ 0x3C6EA6A3);
					continue;
				case 0u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = -1967684874;
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
		JSONNode jSONNode = default(JSONNode);
		int num4 = default(int);
		int num3 = default(int);
		List<Card> list = default(List<Card>);
		bool flag2 = default(bool);
		int num5 = default(int);
		Card[] result = default(Card[]);
		while (true)
		{
			int num = -647704427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8A4CAEBu) % 22u)
				{
				case 21u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1739598248;
						num8 = 1739598248;
					}
					else
					{
						num7 = 1744493582;
						num8 = 1744493582;
					}
					num = num7 ^ ((int)num2 * -1181473253);
					continue;
				}
				case 20u:
					jSONNode = json[num4];
					num3 = 0;
					num = ((int)num2 * -1090590419) ^ -1785953362;
					continue;
				case 19u:
					num = ((int)num2 * -747351277) ^ 0x4185961B;
					continue;
				case 18u:
					num = (int)(num2 * 2066119609) ^ -705320967;
					continue;
				case 17u:
					num = ((int)num2 * -522890936) ^ -1938261545;
					continue;
				case 16u:
					num = (int)(num2 * 790313037) ^ -222271413;
					continue;
				case 14u:
				{
					bool flag3 = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = -790023126;
					continue;
				}
				case 13u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -959560969;
						num10 = -959560969;
					}
					else
					{
						num9 = -1894103753;
						num10 = -1894103753;
					}
					num = num9 ^ (int)(num2 * 1441520055);
					continue;
				}
				case 12u:
					flag2 = num5 < jSONNode[num3].AsInt;
					num = -295847208;
					continue;
				case 11u:
					num = -1628211903;
					continue;
				case 10u:
				{
					int num6;
					if (num4 >= count)
					{
						num = -1772401229;
						num6 = -1772401229;
					}
					else
					{
						num = -1823098094;
						num6 = -1823098094;
					}
					continue;
				}
				case 9u:
					num5++;
					num = (int)(num2 * 1440020568) ^ -26520573;
					continue;
				case 8u:
					num5 = 0;
					num = -245534805;
					continue;
				case 7u:
					num4 = 0;
					num = (int)(num2 * 2104339801) ^ -1940000646;
					continue;
				case 6u:
					num4++;
					num = (int)((num2 * 409445365) ^ 0x79BF91D1);
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 718887684) ^ -131705717;
					continue;
				case 4u:
					list = new List<Card>();
					num = (int)((num2 * 92007160) ^ 0x5231E680);
					continue;
				case 2u:
					result = list.ToArray();
					num = (int)((num2 * 915988007) ^ 0x33D54386);
					continue;
				case 1u:
					num = -1370169625;
					continue;
				case 0u:
					flag = num3 < maxImpact * 2;
					num = -1332930632;
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
		string result = default(string);
		while (true)
		{
			int num = 1851054798;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22EAA438u) % 3u)
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
				num = (int)((num2 * 1410808036) ^ 0x67D10139);
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		int num3 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = -1157447455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2DBF31Au) % 17u)
				{
				case 16u:
					num3 = 0;
					num = ((int)num2 * -1337057630) ^ -1806535460;
					continue;
				case 15u:
					flag = num5 != card.Type;
					num = ((int)num2 * -1431165353) ^ -310406038;
					continue;
				case 14u:
					card = cards[num3];
					num = -1404413487;
					continue;
				case 12u:
					num5 = 0;
					num = ((int)num2 * -1539046904) ^ 0x2B8C4FE5;
					continue;
				case 11u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -1748374103) ^ -414955248;
					continue;
				case 10u:
					num = (int)(num2 * 1506684491) ^ -835546877;
					continue;
				case 9u:
					num5 = card.Type;
					num = ((int)num2 * -1327860416) ^ 0x93D8FC8;
					continue;
				case 7u:
					num = (int)((num2 * 452323935) ^ 0x709B09A3);
					continue;
				case 6u:
					num = ((int)num2 * -2127689766) ^ -1173315402;
					continue;
				case 5u:
					cards = Cards;
					num = (int)(num2 * 1047812343) ^ -1174899265;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 1131836503) ^ -2081270708;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -743029384;
						num7 = -743029384;
					}
					else
					{
						num6 = -1817700011;
						num7 = -1817700011;
					}
					num = num6 ^ (int)(num2 * 1758607224);
					continue;
				}
				case 2u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -257964737;
					continue;
				}
				case 1u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)((num2 * 1934708034) ^ 0x2F6570E8);
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= cards.Length)
					{
						num = -1988977374;
						num4 = -1988977374;
					}
					else
					{
						num = -1128379904;
						num4 = -1128379904;
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
		int num5 = default(int);
		bool flag = default(bool);
		string result = default(string);
		string string_ = default(string);
		while (true)
		{
			int num = -21660275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x907CCB7Eu) % 9u)
				{
				case 8u:
					num5 = 1;
					num = (int)(num2 * 1804173749) ^ -993359831;
					continue;
				case 7u:
					flag = num5 < RiskChances.Length;
					num = -2137744375;
					continue;
				case 6u:
					num = ((int)num2 * -551927454) ^ -426113666;
					continue;
				case 5u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 333716398) ^ 0x55067AE9);
					continue;
				case 4u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -253405049) ^ -2117293597;
					continue;
				case 3u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num5++;
					num = -584762816;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1170469381;
						num4 = -1170469381;
					}
					else
					{
						num3 = -1443114046;
						num4 = -1443114046;
					}
					num = num3 ^ (int)(num2 * 240781205);
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
