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
			int num = -640484992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82CC9191u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1271054396) ^ 0x297FE9E);
					continue;
				case 1u:
					num = (int)(num2 * 1864132870) ^ -1324479307;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			int num = -737159687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9122E1Au) % 4u)
				{
				case 3u:
					asInt = json["max-impact"].AsInt;
					num = ((int)num2 * -199067358) ^ 0x3907F1C;
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
					num = (int)(num2 * 150172546) ^ -1503736081;
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

	private static float[] ParseRiskChances(JSONNode json)
	{
		float[] array = default(float[]);
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 124850472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B1CDAEFu) % 9u)
				{
				case 8u:
					array = new float[json.Count];
					num = ((int)num2 * -440639435) ^ -929675458;
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 1699085636) ^ -2019587862;
					continue;
				case 6u:
					array[num3] = json[num3].AsFloat;
					num = 2143662612;
					continue;
				case 5u:
					num = ((int)num2 * -1264852511) ^ 0x50466EF3;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 1461384110;
						num4 = 1461384110;
					}
					else
					{
						num = 433222001;
						num4 = 433222001;
					}
					continue;
				}
				case 3u:
					num3++;
					num = ((int)num2 * -1215572449) ^ -1929246073;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -1166002278) ^ -2011948069;
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
		int num5 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		bool flag = default(bool);
		while (true)
		{
			int num = -1894935312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2C2B217u) % 24u)
				{
				case 23u:
					num5++;
					num = (int)(num2 * 1080367027) ^ -982188257;
					continue;
				case 22u:
				{
					int num9;
					if (num4 >= maxImpact * 2)
					{
						num = -1244138804;
						num9 = -1244138804;
					}
					else
					{
						num = -1550420537;
						num9 = -1550420537;
					}
					continue;
				}
				case 21u:
					flag2 = num5 < jSONNode[num4].AsInt;
					num = -1199304335;
					continue;
				case 19u:
					num3++;
					num = (int)(num2 * 2116528676) ^ -571619723;
					continue;
				case 18u:
					result = list.ToArray();
					num = (int)(num2 * 39996745) ^ -1859377859;
					continue;
				case 17u:
					num5 = 0;
					num = ((int)num2 * -1746861753) ^ 0xF94175;
					continue;
				case 16u:
					num = -64440434;
					continue;
				case 15u:
					list = new List<Card>();
					num = (int)((num2 * 1343385722) ^ 0x2847CE00);
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1723003209;
						num8 = -1723003209;
					}
					else
					{
						num7 = -975360448;
						num8 = -975360448;
					}
					num = num7 ^ ((int)num2 * -1644164598);
					continue;
				}
				case 13u:
					num = ((int)num2 * -1574492036) ^ 0x64C0A9BE;
					continue;
				case 12u:
					num = (int)((num2 * 1047176242) ^ 0x4AC1D8FB);
					continue;
				case 11u:
					num = -531799059;
					continue;
				case 10u:
					flag = num4 < maxImpact;
					num = (int)((num2 * 773500200) ^ 0x5C777DF4);
					continue;
				case 9u:
					num = (int)((num2 * 86114649) ^ 0x363E92B8);
					continue;
				case 8u:
					num = ((int)num2 * -741795769) ^ -2066112695;
					continue;
				case 7u:
					jSONNode = json[num3];
					num = -1522028718;
					continue;
				case 6u:
				{
					int num6;
					if (num3 < count)
					{
						num = -1540958920;
						num6 = -1540958920;
					}
					else
					{
						num = -1626257499;
						num6 = -1626257499;
					}
					continue;
				}
				case 5u:
					num4 = 0;
					num = ((int)num2 * -1937479167) ^ -2036168069;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -368018376) ^ 0x34AD0899;
					continue;
				case 3u:
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num3
					});
					num = -272389435;
					continue;
				case 2u:
					num = ((int)num2 * -1657386382) ^ -367301812;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1149832019) ^ -446451158;
					continue;
				case 20u:
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
			int num = -1352830613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFFC753C3u) % 3u)
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
				num = ((int)num2 * -1068841279) ^ 0x57F66DAC;
			}
		}
	}

	private string CardsToString()
	{
		string text = "[\n\t";
		int num = 0;
		Card card = default(Card);
		string result = default(string);
		Card[] cards = default(Card[]);
		int num4 = default(int);
		while (true)
		{
			int num2 = 578714953;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x7A8472B4u) % 14u)
				{
				case 13u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num2 = 1663534593;
					continue;
				}
				case 12u:
					text = Rules.smethod_1(text, "\n\t");
					num = card.Type;
					num2 = (int)((num3 * 1761940019) ^ 0x517D931F);
					continue;
				case 11u:
					num2 = ((int)num3 * -488119902) ^ -1188500634;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (num != card.Type)
					{
						num6 = 1374330594;
						num7 = 1374330594;
					}
					else
					{
						num6 = 441502525;
						num7 = 441502525;
					}
					num2 = num6 ^ ((int)num3 * -205914714);
					continue;
				}
				case 9u:
					result = Rules.smethod_1(text, "\n]");
					num2 = ((int)num3 * -1412289779) ^ -1143177064;
					continue;
				case 8u:
					card = cards[num4];
					num2 = 787779166;
					continue;
				case 7u:
					num2 = ((int)num3 * -2007954554) ^ 0x3788AA02;
					continue;
				case 5u:
					cards = Cards;
					num2 = (int)(num3 * 1623375821) ^ -1838940560;
					continue;
				case 4u:
					num4++;
					num2 = (int)((num3 * 1921819180) ^ 0xA2D3944);
					continue;
				case 3u:
					num2 = (int)(num3 * 1516993740) ^ -1820541784;
					continue;
				case 2u:
				{
					int num5;
					if (num4 >= cards.Length)
					{
						num2 = 1788843087;
						num5 = 1788843087;
					}
					else
					{
						num2 = 479015064;
						num5 = 479015064;
					}
					continue;
				}
				case 1u:
					num4 = 0;
					num2 = (int)((num3 * 539937264) ^ 0x109A1365);
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

	private string RiskChancesToString()
	{
		string string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -810015400;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADE9B4EDu) % 8u)
				{
				case 6u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -1870772411;
					continue;
				case 5u:
					num3 = 1;
					num = (int)(num2 * 411471135) ^ -1375857497;
					continue;
				case 4u:
					num = ((int)num2 * -1004952545) ^ 0x342CECBA;
					continue;
				case 2u:
					result = Rules.smethod_1(string_, " ]");
					num = ((int)num2 * -397599284) ^ 0xDA407D1;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= RiskChances.Length)
					{
						num = -918759721;
						num4 = -918759721;
					}
					else
					{
						num = -1203107701;
						num4 = -1203107701;
					}
					continue;
				}
				case 0u:
					num3++;
					num = ((int)num2 * -1028133306) ^ 0x250B8EBC;
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
