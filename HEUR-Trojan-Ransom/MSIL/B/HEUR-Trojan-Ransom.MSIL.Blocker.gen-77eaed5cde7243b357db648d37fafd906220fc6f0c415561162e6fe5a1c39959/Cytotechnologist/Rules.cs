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
			int num = 1270796885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x115182C3u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 257136281) ^ 0x42DC1B11);
					continue;
				case 2u:
					num = (int)((num2 * 808963770) ^ 0x52F67E44);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
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
			int num = 1824787458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45AC281Cu) % 3u)
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
				num = ((int)num2 * -191186175) ^ -949258682;
			}
		}
	}

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		float[] result = default(float[]);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1137529586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CD2807Fu) % 9u)
				{
				case 8u:
					result = array;
					num = (int)((num2 * 872700598) ^ 0x7C259C3C);
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -957634929) ^ 0x20BB71FE;
					continue;
				case 4u:
					num = ((int)num2 * -1452198373) ^ 0x6AB7EFAE;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1997925316) ^ -654216444;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 440721856;
						num5 = 440721856;
					}
					else
					{
						num4 = 1973180814;
						num5 = 1973180814;
					}
					num = num4 ^ ((int)num2 * -1197372885);
					continue;
				}
				case 1u:
					array[num3] = json[num3].AsFloat;
					num = 1670966229;
					continue;
				case 0u:
					flag = num3 < array.Length;
					num = 89545836;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int count = json.Count;
		JSONNode jSONNode = default(JSONNode);
		int num6 = default(int);
		int num3 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		int num7 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -585453480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA0D6458u) % 22u)
				{
				case 21u:
					jSONNode = json[num6];
					num3 = 0;
					num = -1094801307;
					continue;
				case 20u:
					result = list.ToArray();
					num = (int)((num2 * 1767876352) ^ 0x74C12CA7);
					continue;
				case 19u:
					num6++;
					num = (int)(num2 * 1510455114) ^ -1438747446;
					continue;
				case 18u:
					list = new List<Card>();
					num = ((int)num2 * -462602913) ^ -717994897;
					continue;
				case 17u:
					flag3 = num3 < maxImpact * 2;
					num = -130802738;
					continue;
				case 16u:
					num = ((int)num2 * -494676208) ^ -1021624960;
					continue;
				case 15u:
					num = ((int)num2 * -561051389) ^ 0x42941B13;
					continue;
				case 13u:
					num6 = 0;
					num = ((int)num2 * -1162142387) ^ -1992643729;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -917934733;
						num10 = -917934733;
					}
					else
					{
						num9 = -452575452;
						num10 = -452575452;
					}
					num = num9 ^ (int)(num2 * 1719434869);
					continue;
				}
				case 11u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num3)) : (maxImpact * 2 - num3)),
						Type = num6
					});
					num7++;
					num = -1568856535;
					continue;
				case 10u:
					num = (int)(num2 * 1016811749) ^ -1283689725;
					continue;
				case 9u:
					num = ((int)num2 * -2124894740) ^ 0x64AC5697;
					continue;
				case 8u:
					flag = num6 < count;
					num = -866414291;
					continue;
				case 7u:
				{
					int num8;
					if (num7 >= jSONNode[num3].AsInt)
					{
						num = -905345492;
						num8 = -905345492;
					}
					else
					{
						num = -1985430586;
						num8 = -1985430586;
					}
					continue;
				}
				case 6u:
					flag2 = num3 < maxImpact;
					num = (int)((num2 * 1936239175) ^ 0x38909E7B);
					continue;
				case 5u:
					num = (int)(num2 * 1623153808) ^ -1439096167;
					continue;
				case 3u:
					num7 = 0;
					num = -937886933;
					continue;
				case 2u:
					num = -932158140;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1944261833;
						num5 = 1944261833;
					}
					else
					{
						num4 = 250182382;
						num5 = 250182382;
					}
					num = num4 ^ (int)(num2 * 911598552);
					continue;
				}
				case 0u:
					num3++;
					num = ((int)num2 * -1651858910) ^ 0x626AACC3;
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
			int num = 1493315961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x411CDCAAu) % 3u)
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
				num = (int)(num2 * 1843989652) ^ -1973443270;
			}
		}
	}

	private string CardsToString()
	{
		int num3 = default(int);
		int num4 = default(int);
		Card card = default(Card);
		string text = default(string);
		Card[] cards = default(Card[]);
		string result = default(string);
		while (true)
		{
			int num = 1581991501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x508CD547u) % 16u)
				{
				case 15u:
					num3++;
					num = (int)((num2 * 789491019) ^ 0x5505E7EA);
					continue;
				case 14u:
					num = (int)(num2 * 1215747252) ^ -1295959780;
					continue;
				case 13u:
					num4 = card.Type;
					num = ((int)num2 * -1923337920) ^ -1926677191;
					continue;
				case 12u:
					num = (int)((num2 * 1053016580) ^ 0x38D6B671);
					continue;
				case 10u:
					text = "[\n\t";
					num4 = 0;
					num = (int)((num2 * 784977118) ^ 0x2F9F6F49);
					continue;
				case 9u:
					card = cards[num3];
					num = 2063160731;
					continue;
				case 8u:
				{
					int num7;
					if (num3 < cards.Length)
					{
						num = 594616238;
						num7 = 594616238;
					}
					else
					{
						num = 286273602;
						num7 = 286273602;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -1625197523) ^ -1172821000;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (num4 == card.Type)
					{
						num5 = -1245142186;
						num6 = -1245142186;
					}
					else
					{
						num5 = -178569307;
						num6 = -178569307;
					}
					num = num5 ^ ((int)num2 * -765809277);
					continue;
				}
				case 5u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -1986999966) ^ -1109288502;
					continue;
				case 3u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = 2147329974;
					continue;
				}
				case 2u:
					cards = Cards;
					num3 = 0;
					num = (int)(num2 * 1096289760) ^ -1595625857;
					continue;
				case 1u:
					num = (int)(num2 * 40772163) ^ -1956361077;
					continue;
				case 0u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -228989142) ^ -1495788438;
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
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 145702947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23DC92FCu) % 9u)
				{
				case 7u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 555398411;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1750444918;
						num5 = -1750444918;
					}
					else
					{
						num4 = -117299297;
						num5 = -117299297;
					}
					num = num4 ^ (int)(num2 * 218485501);
					continue;
				}
				case 4u:
					flag = num3 < RiskChances.Length;
					num = 1977919202;
					continue;
				case 3u:
					num3 = 1;
					num = (int)((num2 * 1209246142) ^ 0x28327AD8);
					continue;
				case 2u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 1403027937) ^ 0x63603100);
					continue;
				case 1u:
					num = (int)((num2 * 1842188096) ^ 0x189E1959);
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 1196911521) ^ -642341490;
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
