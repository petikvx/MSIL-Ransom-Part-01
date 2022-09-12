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
			int num = -1363125415;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA147196Cu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1620692638) ^ 0x3FD34CB3);
					continue;
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
					num = (int)(num2 * 1240453246) ^ -1954166900;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = new float[json.Count];
		float[] result = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = 1475933517;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23A59DCEu) % 8u)
				{
				case 7u:
					result = array;
					num = ((int)num2 * -1374305907) ^ 0x53730AD;
					continue;
				case 6u:
					num = (int)(num2 * 2084658311) ^ -1210917456;
					continue;
				case 5u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 1969249282;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 583496513;
						num4 = 583496513;
					}
					else
					{
						num = 1564901459;
						num4 = 1564901459;
					}
					continue;
				}
				case 3u:
					num3 = 0;
					num = (int)((num2 * 1866164836) ^ 0x5369D3DC);
					continue;
				case 0u:
					num = (int)((num2 * 445425530) ^ 0x4D61874F);
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
		int num7 = default(int);
		int num4 = default(int);
		List<Card> list = default(List<Card>);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		Card[] result = default(Card[]);
		bool flag3 = default(bool);
		int count = default(int);
		while (true)
		{
			int num = 273675689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A819ED6u) % 25u)
				{
				case 24u:
					num7 = 0;
					num = ((int)num2 * -538208) ^ 0x5F58D404;
					continue;
				case 23u:
					num7++;
					num = ((int)num2 * -1993226299) ^ -1031864778;
					continue;
				case 22u:
					num = (int)(num2 * 1407186896) ^ -30453382;
					continue;
				case 21u:
					num = (int)(num2 * 1580452265) ^ -1034835615;
					continue;
				case 20u:
					num4++;
					num = ((int)num2 * -726719008) ^ -1812571393;
					continue;
				case 19u:
					list.Add(new Card
					{
						Impact = (flag2 ? (-(maxImpact - num7)) : (maxImpact * 2 - num7)),
						Type = num4
					});
					num = 185784303;
					continue;
				case 17u:
					num = (int)((num2 * 724287536) ^ 0x385CE2BC);
					continue;
				case 15u:
					num3 = 0;
					num = 1032605391;
					continue;
				case 14u:
					flag = num3 < jSONNode[num7].AsInt;
					num = 702165454;
					continue;
				case 13u:
					num4 = 0;
					num = ((int)num2 * -1033610371) ^ 0x7C0D753E;
					continue;
				case 12u:
					num = ((int)num2 * -1100217000) ^ -2046360009;
					continue;
				case 11u:
					result = list.ToArray();
					num = ((int)num2 * -936824949) ^ -1544174357;
					continue;
				case 10u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 16627525;
						num10 = 16627525;
					}
					else
					{
						num9 = 12967080;
						num10 = 12967080;
					}
					num = num9 ^ (int)(num2 * 921721303);
					continue;
				}
				case 9u:
					list = new List<Card>();
					num = (int)((num2 * 404027999) ^ 0x34B52335);
					continue;
				case 8u:
					flag3 = num4 < count;
					num = 90686653;
					continue;
				case 7u:
					count = json.Count;
					num = ((int)num2 * -613444487) ^ -832964581;
					continue;
				case 6u:
					flag2 = num7 < maxImpact;
					num = 859667671;
					continue;
				case 5u:
				{
					int num8;
					if (num7 >= maxImpact * 2)
					{
						num = 1328183222;
						num8 = 1328183222;
					}
					else
					{
						num = 359455003;
						num8 = 359455003;
					}
					continue;
				}
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 2075387696;
						num6 = 2075387696;
					}
					else
					{
						num5 = 1170163;
						num6 = 1170163;
					}
					num = num5 ^ (int)(num2 * 1925035073);
					continue;
				}
				case 3u:
					num = (int)((num2 * 279244633) ^ 0x96BF271);
					continue;
				case 2u:
					num = ((int)num2 * -491765695) ^ -1479966921;
					continue;
				case 1u:
					jSONNode = json[num4];
					num = 1871683404;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -1871850955) ^ -1050896541;
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
		int num7 = default(int);
		Card card = default(Card);
		string text = default(string);
		int num5 = default(int);
		Card[] cards = default(Card[]);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1777531790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1AFF83FDu) % 16u)
				{
				case 15u:
					num7 = card.Type;
					num = (int)((num2 * 2124321555) ^ 0x49010EF5);
					continue;
				case 14u:
					num = (int)((num2 * 2139367763) ^ 0x5F09A3ED);
					continue;
				case 12u:
					num7 = 0;
					num = (int)((num2 * 121385526) ^ 0x3177CD11);
					continue;
				case 11u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -2008125138) ^ 0x279850B8;
					continue;
				case 10u:
				{
					int num6;
					if (num5 >= cards.Length)
					{
						num = 245103295;
						num6 = 245103295;
					}
					else
					{
						num = 528247130;
						num6 = 528247130;
					}
					continue;
				}
				case 9u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num5++;
					num = 1544965751;
					continue;
				}
				case 7u:
					card = cards[num5];
					num = 1608063339;
					continue;
				case 6u:
					flag = num7 != card.Type;
					num = (int)((num2 * 874658184) ^ 0x6AEC965D);
					continue;
				case 5u:
					num = (int)((num2 * 1891699666) ^ 0xAF40D2E);
					continue;
				case 4u:
					num = ((int)num2 * -382149338) ^ -1957677964;
					continue;
				case 3u:
					text = "[\n\t";
					num = (int)(num2 * 1718109196) ^ -940818347;
					continue;
				case 2u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -253479793) ^ -530130338;
					continue;
				case 1u:
					cards = Cards;
					num5 = 0;
					num = ((int)num2 * -627800496) ^ 0x61E4CA13;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -381960604;
						num4 = -381960604;
					}
					else
					{
						num3 = -327220618;
						num4 = -327220618;
					}
					num = num3 ^ ((int)num2 * -2015760947);
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
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num = 1;
		string result = default(string);
		while (true)
		{
			int num2;
			int num3;
			if (num < RiskChances.Length)
			{
				num2 = -896199886;
				num3 = -896199886;
			}
			else
			{
				num2 = -2008371202;
				num3 = -2008371202;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xB629BB9Bu) % 6u)
				{
				case 3u:
					result = Rules.smethod_1(string_, " ]");
					num2 = ((int)num4 * -308379603) ^ 0x72326632;
					continue;
				case 2u:
					num2 = -896199886;
					continue;
				case 1u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num].ToString(Rules.smethod_4()));
					num2 = -1583835447;
					continue;
				case 0u:
					num++;
					num2 = ((int)num4 * -192603469) ^ -1403551084;
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
