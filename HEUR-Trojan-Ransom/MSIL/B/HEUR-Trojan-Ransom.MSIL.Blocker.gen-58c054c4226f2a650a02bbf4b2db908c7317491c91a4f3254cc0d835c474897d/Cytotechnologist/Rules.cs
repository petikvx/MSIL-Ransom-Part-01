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
			int num = 895374470;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10BB66BFu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -423918325) ^ -935101260;
					continue;
				case 1u:
					num = (int)((num2 * 353236512) ^ 0x172CE834);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
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
		float[] array = new float[json.Count];
		int num3 = default(int);
		float[] result = default(float[]);
		while (true)
		{
			int num = 813999975;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F51FFB0u) % 8u)
				{
				case 7u:
					num3 = 0;
					num = (int)(num2 * 224950421) ^ -321324111;
					continue;
				case 6u:
					num = ((int)num2 * -2089816772) ^ -528202207;
					continue;
				case 5u:
					array[num3] = json[num3].AsFloat;
					num3++;
					num = 114262492;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 118360176;
						num4 = 118360176;
					}
					else
					{
						num = 1592915877;
						num4 = 1592915877;
					}
					continue;
				}
				case 2u:
					num = (int)(num2 * 1719197266) ^ -961689288;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -151661947) ^ -421983754;
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

	private static Card[] ParseDeck(JSONNode json, int maxImpact)
	{
		int num4 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		List<Card> list = default(List<Card>);
		bool flag3 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag2 = default(bool);
		Card[] result = default(Card[]);
		int count = default(int);
		while (true)
		{
			int num = -2110119713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3F872CFu) % 25u)
				{
				case 24u:
				{
					int num10;
					if (num4 < maxImpact * 2)
					{
						num = -270798601;
						num10 = -270798601;
					}
					else
					{
						num = -1763289600;
						num10 = -1763289600;
					}
					continue;
				}
				case 22u:
					num5++;
					num = ((int)num2 * -1150286530) ^ -390239459;
					continue;
				case 21u:
					num = ((int)num2 * -1743798056) ^ -1152219918;
					continue;
				case 20u:
					num = ((int)num2 * -458123577) ^ -401158237;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 539382234;
						num9 = 539382234;
					}
					else
					{
						num8 = 1877419285;
						num9 = 1877419285;
					}
					num = num8 ^ (int)(num2 * 779142380);
					continue;
				}
				case 18u:
					num3 = 0;
					num = -352424047;
					continue;
				case 17u:
					num = -1044796296;
					continue;
				case 16u:
					num5 = 0;
					num = ((int)num2 * -119159242) ^ 0x6E350DD5;
					continue;
				case 15u:
					list.Add(new Card
					{
						Impact = (flag3 ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num5
					});
					num = -990073833;
					continue;
				case 14u:
					jSONNode = json[num5];
					num = -1217909920;
					continue;
				case 13u:
					num3++;
					num = (int)((num2 * 1015522623) ^ 0x45C42347);
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = 904910801;
						num7 = 904910801;
					}
					else
					{
						num6 = 1139051872;
						num7 = 1139051872;
					}
					num = num6 ^ (int)(num2 * 1528900265);
					continue;
				}
				case 11u:
					num = ((int)num2 * -2076251040) ^ 0x7A057C2B;
					continue;
				case 10u:
					result = list.ToArray();
					num = ((int)num2 * -342834719) ^ 0x36A1D710;
					continue;
				case 9u:
					num = ((int)num2 * -1522027771) ^ 0x53316531;
					continue;
				case 8u:
					num = ((int)num2 * -1697959373) ^ 0x3BC6A8A1;
					continue;
				case 7u:
					num4 = 0;
					num = (int)((num2 * 1504627144) ^ 0x6A490116);
					continue;
				case 6u:
					num = (int)(num2 * 763561792) ^ -36149717;
					continue;
				case 5u:
					num4++;
					num = (int)(num2 * 1118502564) ^ -553691136;
					continue;
				case 4u:
					flag3 = num4 < maxImpact;
					num = ((int)num2 * -546396231) ^ 0x6E18F794;
					continue;
				case 3u:
					flag2 = num5 < count;
					num = -1535537093;
					continue;
				case 1u:
					count = json.Count;
					list = new List<Card>();
					num = (int)(num2 * 2109039710) ^ -1305506328;
					continue;
				case 0u:
					flag = num3 < jSONNode[num4].AsInt;
					num = -308125099;
					continue;
				case 23u:
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
			int num = 69378036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6625C69Cu) % 3u)
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
				num = (int)((num2 * 1197523998) ^ 0x263A211D);
			}
		}
	}

	private string CardsToString()
	{
		int num3 = default(int);
		Card[] cards = default(Card[]);
		Card card = default(Card);
		int num5 = default(int);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = -883974523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3632B6Eu) % 17u)
				{
				case 16u:
				{
					int num4;
					if (num3 < cards.Length)
					{
						num = -1686430188;
						num4 = -1686430188;
					}
					else
					{
						num = -2031560374;
						num4 = -2031560374;
					}
					continue;
				}
				case 15u:
					num3++;
					num = (int)(num2 * 874764247) ^ -1407564409;
					continue;
				case 14u:
				{
					card = cards[num3];
					int num6;
					if (num5 == card.Type)
					{
						num = -116913816;
						num6 = -116913816;
					}
					else
					{
						num = -258153097;
						num6 = -258153097;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -1178852602) ^ -5876441;
					continue;
				case 12u:
					num5 = card.Type;
					num = (int)(num2 * 1474230107) ^ -676797232;
					continue;
				case 11u:
					num = (int)(num2 * 1227108952) ^ -661275647;
					continue;
				case 10u:
					num = (int)((num2 * 1748961352) ^ 0x7FF6600);
					continue;
				case 9u:
					num = ((int)num2 * -480965013) ^ 0x4D6BA430;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -993065881) ^ -287548768;
					continue;
				case 7u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -326533319) ^ -877401937;
					continue;
				case 6u:
					text = "[\n\t";
					num5 = 0;
					num = ((int)num2 * -14669563) ^ -174306801;
					continue;
				case 4u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -94653515;
					continue;
				}
				case 3u:
					cards = Cards;
					num = (int)(num2 * 262501893) ^ -666655717;
					continue;
				case 2u:
					num = ((int)num2 * -1089549330) ^ 0xC357488;
					continue;
				case 1u:
					text = Rules.smethod_1(text, "\n\t");
					num = (int)(num2 * 1564877483) ^ -1143424262;
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

	private string RiskChancesToString()
	{
		string result = default(string);
		string string_ = default(string);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -741042556;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD386100u) % 9u)
				{
				case 8u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 1563283186) ^ 0x55626234);
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1332920339;
						num5 = 1332920339;
					}
					else
					{
						num4 = 1753832717;
						num5 = 1753832717;
					}
					num = num4 ^ (int)(num2 * 1609630918);
					continue;
				}
				case 6u:
					num3 = 1;
					num = ((int)num2 * -591643191) ^ 0x44451127;
					continue;
				case 5u:
					flag = num3 < RiskChances.Length;
					num = -407847368;
					continue;
				case 4u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = -1090512139;
					continue;
				case 3u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = ((int)num2 * -1025210508) ^ -29500011;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 2093912155) ^ 0x6C18AF1D);
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
