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
			int num = 1659216070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62725294u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 2009466802) ^ 0xDD3D438);
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
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = -144345885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF478F59Fu) % 7u)
				{
				case 6u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = -1539348726;
						num4 = -1539348726;
					}
					else
					{
						num = -1762419100;
						num4 = -1762419100;
					}
					continue;
				}
				case 5u:
					result = array;
					num = (int)(num2 * 1974777732) ^ -1215598902;
					continue;
				case 3u:
					array[num3] = json[num3].AsFloat;
					num = -624789908;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 433302580) ^ -1228365974;
					continue;
				case 1u:
					array = new float[json.Count];
					num3 = 0;
					num = ((int)num2 * -429824683) ^ -658086886;
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
		int num3 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		bool flag = default(bool);
		int num4 = default(int);
		int count = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -478307273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA9AA633u) % 24u)
				{
				case 23u:
					num3++;
					num = (int)((num2 * 1947817681) ^ 0x2801419F);
					continue;
				case 22u:
					result = list.ToArray();
					num = (int)(num2 * 1846053091) ^ -1690751263;
					continue;
				case 21u:
					num = (int)((num2 * 1395042014) ^ 0x315F200E);
					continue;
				case 20u:
					flag = num4 < count;
					num = -1103072416;
					continue;
				case 18u:
				{
					int num10;
					if (num7 >= maxImpact * 2)
					{
						num = -544425342;
						num10 = -544425342;
					}
					else
					{
						num = -398051357;
						num10 = -398051357;
					}
					continue;
				}
				case 17u:
					num4++;
					num = ((int)num2 * -1708272668) ^ -483483869;
					continue;
				case 16u:
					num = ((int)num2 * -811107306) ^ -787331496;
					continue;
				case 15u:
					num = ((int)num2 * -323027897) ^ 0x7525F950;
					continue;
				case 14u:
					num = ((int)num2 * -1923644008) ^ -563935532;
					continue;
				case 13u:
					num7++;
					num = (int)((num2 * 1937652340) ^ 0x2F6C595);
					continue;
				case 12u:
					count = json.Count;
					num = ((int)num2 * -1578332615) ^ 0x7C84C56;
					continue;
				case 11u:
					flag2 = num3 < jSONNode[num7].AsInt;
					num = -2116422570;
					continue;
				case 10u:
					num = -839226773;
					continue;
				case 9u:
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num7)) : (maxImpact * 2 - num7)),
						Type = num4
					});
					num = -422128171;
					continue;
				case 8u:
					flag3 = num7 < maxImpact;
					num = ((int)num2 * -753781748) ^ -1837047366;
					continue;
				case 7u:
					num = ((int)num2 * -1733172614) ^ -1287962463;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 2030390693;
						num9 = 2030390693;
					}
					else
					{
						num8 = 1941648266;
						num9 = 1941648266;
					}
					num = num8 ^ ((int)num2 * -1513094572);
					continue;
				}
				case 4u:
					jSONNode = json[num4];
					num7 = 0;
					num = -1562147164;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1596440549;
						num6 = 1596440549;
					}
					else
					{
						num5 = 440427863;
						num6 = 440427863;
					}
					num = num5 ^ (int)(num2 * 287312840);
					continue;
				}
				case 2u:
					num4 = 0;
					num = (int)((num2 * 2078029771) ^ 0x4B24752);
					continue;
				case 1u:
					list = new List<Card>();
					num = ((int)num2 * -1824243156) ^ -1689464427;
					continue;
				case 0u:
					num3 = 0;
					num = -1487064602;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1134529719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE10D1DCu) % 4u)
				{
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
					num = ((int)num2 * -1503678096) ^ 0xCEBC880;
					continue;
				case 0u:
					num = (int)((num2 * 1385787539) ^ 0x5AE37D17);
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
		string text = "[\n\t";
		int num = 0;
		Card[] cards = Cards;
		int num2 = 0;
		Card card = default(Card);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num3;
			int num4;
			if (num2 >= cards.Length)
			{
				num3 = -1690018723;
				num4 = -1690018723;
			}
			else
			{
				num3 = -1165171397;
				num4 = -1165171397;
			}
			while (true)
			{
				uint num5;
				switch ((num5 = (uint)num3 ^ 0xE7C04B1Eu) % 12u)
				{
				case 11u:
					num3 = ((int)num5 * -1743172519) ^ 0x631F278D;
					continue;
				case 10u:
					num2++;
					num3 = (int)(num5 * 19679953) ^ -1603888543;
					continue;
				case 9u:
					num3 = (int)(num5 * 1571551280) ^ -225688699;
					continue;
				case 8u:
					text = Rules.smethod_1(text, "\n\t");
					num = card.Type;
					num3 = (int)((num5 * 108037365) ^ 0x27B0391A);
					continue;
				case 7u:
					result = Rules.smethod_1(text, "\n]");
					num3 = ((int)num5 * -1341334580) ^ -624465045;
					continue;
				case 6u:
					num3 = -1165171397;
					continue;
				case 5u:
					card = cards[num2];
					flag = num != card.Type;
					num3 = -1395905012;
					continue;
				case 4u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num3 = -1078920846;
					continue;
				}
				case 2u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1381726532;
						num7 = 1381726532;
					}
					else
					{
						num6 = 215590523;
						num7 = 215590523;
					}
					num3 = num6 ^ (int)(num5 * 81908523);
					continue;
				}
				case 0u:
					num3 = (int)((num5 * 572705581) ^ 0x22C82850);
					continue;
				case 1u:
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
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 479663929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x627DA980u) % 7u)
				{
				case 6u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num5 = 1;
					num = (int)(num2 * 423183572) ^ -2002618961;
					continue;
				case 5u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 363099920) ^ -1221010053;
					continue;
				case 4u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num5].ToString(Rules.smethod_4()));
					num5++;
					num = 1977770139;
					continue;
				case 3u:
					flag = num5 < RiskChances.Length;
					num = 2143352287;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1861025123;
						num4 = -1861025123;
					}
					else
					{
						num3 = -126500656;
						num4 = -126500656;
					}
					num = num3 ^ ((int)num2 * -132027961);
					continue;
				}
				case 0u:
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
