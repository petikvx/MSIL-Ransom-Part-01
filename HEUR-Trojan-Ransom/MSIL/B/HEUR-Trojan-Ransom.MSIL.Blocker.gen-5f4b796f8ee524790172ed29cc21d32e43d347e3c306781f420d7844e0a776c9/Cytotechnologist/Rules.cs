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
		float[] array = new float[json.Count];
		int num3 = default(int);
		bool flag = default(bool);
		float[] result = default(float[]);
		while (true)
		{
			int num = 1918944346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B4A721u) % 9u)
				{
				case 8u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 1388598513;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1375885737;
						num5 = -1375885737;
					}
					else
					{
						num4 = -1384567892;
						num5 = -1384567892;
					}
					num = num4 ^ (int)(num2 * 846035378);
					continue;
				}
				case 5u:
					num = ((int)num2 * -418113685) ^ -1718127970;
					continue;
				case 4u:
					result = array;
					num = (int)(num2 * 1940915496) ^ -1283229357;
					continue;
				case 3u:
					num = (int)((num2 * 397973340) ^ 0x4798C744);
					continue;
				case 2u:
					flag = num3 < array.Length;
					num = 808196566;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1803535646) ^ 0x3DF875BA;
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
		int num4 = default(int);
		bool flag2 = default(bool);
		int count = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num5 = default(int);
		int num3 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		while (true)
		{
			int num = 1148398854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21390C23u) % 21u)
				{
				case 20u:
					num4++;
					num = (int)(num2 * 1294256463) ^ -1671654335;
					continue;
				case 19u:
					num = 459320731;
					continue;
				case 18u:
					flag2 = num4 < count;
					num = 200610139;
					continue;
				case 17u:
					jSONNode = json[num4];
					num = 2123867786;
					continue;
				case 16u:
				{
					int num7;
					if (num5 >= jSONNode[num3].AsInt)
					{
						num = 480807973;
						num7 = 480807973;
					}
					else
					{
						num = 254886508;
						num7 = 254886508;
					}
					continue;
				}
				case 15u:
					num = (int)(num2 * 197069502) ^ -1837437652;
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = -1301699841;
						num9 = -1301699841;
					}
					else
					{
						num8 = -1267503428;
						num9 = -1267503428;
					}
					num = num8 ^ ((int)num2 * -624093172);
					continue;
				}
				case 12u:
					num = ((int)num2 * -2095508471) ^ -926097765;
					continue;
				case 11u:
					num3 = 0;
					num = ((int)num2 * -1571450672) ^ -909563968;
					continue;
				case 10u:
					result = list.ToArray();
					num = ((int)num2 * -1907294874) ^ 0x3575F30D;
					continue;
				case 9u:
					num5 = 0;
					num = (int)((num2 * 1528130594) ^ 0x3D590C53);
					continue;
				case 8u:
				{
					int num6;
					if (num3 >= maxImpact * 2)
					{
						num = 2067185487;
						num6 = 2067185487;
					}
					else
					{
						num = 262114860;
						num6 = 262114860;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -1683780590) ^ 0x2BBAEB3D;
					continue;
				case 6u:
					num5++;
					num = (int)((num2 * 1710074469) ^ 0x73DF09AF);
					continue;
				case 5u:
					count = json.Count;
					list = new List<Card>();
					num4 = 0;
					num = (int)(num2 * 835655556) ^ -1113862743;
					continue;
				case 4u:
					num = ((int)num2 * -406199110) ^ -1456377816;
					continue;
				case 3u:
					num = 192948290;
					continue;
				case 1u:
					num3++;
					num = (int)(num2 * 971391928) ^ -871242634;
					continue;
				case 0u:
				{
					bool flag = num3 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num4
					});
					num = 485586896;
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
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num5 = default(int);
		string text = default(string);
		bool flag = default(bool);
		int num7 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 499628637;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51AA86C2u) % 18u)
				{
				case 17u:
					card = cards[num5];
					num = 1788466487;
					continue;
				case 16u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)((num2 * 2060579590) ^ 0xA4F14FE);
					continue;
				case 15u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 777149790;
						num4 = 777149790;
					}
					else
					{
						num3 = 1009120068;
						num4 = 1009120068;
					}
					num = num3 ^ ((int)num2 * -1625157978);
					continue;
				}
				case 14u:
					cards = Cards;
					num = (int)(num2 * 369990827) ^ -1067272661;
					continue;
				case 13u:
					num = ((int)num2 * -1575837846) ^ -1920890157;
					continue;
				case 11u:
					num5 = 0;
					num = (int)((num2 * 1257753762) ^ 0x4532F023);
					continue;
				case 10u:
					num5++;
					num = (int)(num2 * 724348396) ^ -1210513927;
					continue;
				case 9u:
					num = ((int)num2 * -2074173448) ^ -1269799855;
					continue;
				case 8u:
					num7 = card.Type;
					num = ((int)num2 * -1652678459) ^ -424553810;
					continue;
				case 6u:
					num = (int)((num2 * 844858293) ^ 0x769E55C8);
					continue;
				case 5u:
					text = "[\n\t";
					num = (int)(num2 * 1779762077) ^ -1732254339;
					continue;
				case 4u:
					result = Rules.smethod_1(text, "\n]");
					num = (int)(num2 * 1038636161) ^ -1263784855;
					continue;
				case 3u:
					flag = num7 != card.Type;
					num = ((int)num2 * -239222683) ^ 0x7DDCFB12;
					continue;
				case 2u:
					num7 = 0;
					num = (int)(num2 * 588653633) ^ -1967100314;
					continue;
				case 1u:
				{
					int num6;
					if (num5 >= cards.Length)
					{
						num = 75717656;
						num6 = 75717656;
					}
					else
					{
						num = 1855619803;
						num6 = 1855619803;
					}
					continue;
				}
				case 0u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 287651442;
					continue;
				}
				case 12u:
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
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1876102331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE389480u) % 9u)
				{
				case 8u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)(num2 * 1037100105) ^ -1375556767;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -2012619802) ^ -330044293;
					continue;
				case 6u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num3 = 1;
					num = ((int)num2 * -1973102237) ^ -1945067334;
					continue;
				case 5u:
					num = ((int)num2 * -743475889) ^ 0x6D08C38;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = -1011815914;
						num4 = -1011815914;
					}
					else
					{
						num = -573540218;
						num4 = -573540218;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -506259123) ^ -871189749;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -331234956;
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
