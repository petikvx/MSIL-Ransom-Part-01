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
			int num = 1566217981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AA40CF6u) % 3u)
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
				num = (int)(num2 * 52938806) ^ -2139684877;
			}
		}
	}

	public static Rules Deserialize(JSONNode json)
	{
		Rules result = default(Rules);
		int asInt = default(int);
		while (true)
		{
			int num = -473871098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD898A0B9u) % 5u)
				{
				case 4u:
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
					num = ((int)num2 * -791228924) ^ -535494089;
					continue;
				case 3u:
					num = ((int)num2 * -854052235) ^ 0x7F3EB560;
					continue;
				case 1u:
					asInt = json["max-impact"].AsInt;
					num = (int)(num2 * 1181028325) ^ -1903962379;
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
		int num3 = default(int);
		float[] array = default(float[]);
		float[] result = default(float[]);
		while (true)
		{
			int num = 893791272;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EA52BD0u) % 9u)
				{
				case 8u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 610257803;
						num4 = 610257803;
					}
					else
					{
						num = 101946412;
						num4 = 101946412;
					}
					continue;
				}
				case 7u:
					num3 = 0;
					num = (int)((num2 * 180026466) ^ 0x5572E7E6);
					continue;
				case 6u:
					result = array;
					num = (int)(num2 * 1880305354) ^ -1863808876;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -419683331) ^ -1312064708;
					continue;
				case 2u:
					array[num3] = json[num3].AsFloat;
					num = 1338269164;
					continue;
				case 1u:
					array = new float[json.Count];
					num = (int)((num2 * 1235809560) ^ 0x23B7B72B);
					continue;
				case 0u:
					num = (int)(num2 * 201003318) ^ -1454691275;
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
		int num3 = default(int);
		JSONNode jSONNode = default(JSONNode);
		int num6 = default(int);
		int num4 = default(int);
		Card[] result = default(Card[]);
		List<Card> list = default(List<Card>);
		int count = default(int);
		while (true)
		{
			int num = 1449458292;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4264FF77u) % 23u)
				{
				case 21u:
					num = (int)((num2 * 1244633828) ^ 0x66F5ABFB);
					continue;
				case 20u:
					num = ((int)num2 * -642222625) ^ -822941444;
					continue;
				case 19u:
					num3++;
					num = ((int)num2 * -1420513291) ^ 0x780D34DF;
					continue;
				case 18u:
					jSONNode = json[num6];
					num = 2100330079;
					continue;
				case 17u:
					num4++;
					num = ((int)num2 * -905857040) ^ -1159031568;
					continue;
				case 16u:
					num6++;
					num = ((int)num2 * -604375712) ^ 0x72B84F4;
					continue;
				case 15u:
					num3 = 0;
					num = (int)((num2 * 710312074) ^ 0x11E9951F);
					continue;
				case 14u:
					num6 = 0;
					num = (int)((num2 * 587087214) ^ 0x7FDA4ABA);
					continue;
				case 13u:
				{
					int num8;
					if (num4 >= maxImpact * 2)
					{
						num = 1034945124;
						num8 = 1034945124;
					}
					else
					{
						num = 963558538;
						num8 = 963558538;
					}
					continue;
				}
				case 12u:
					num = 9187117;
					continue;
				case 11u:
					num = (int)(num2 * 1584416747) ^ -145735304;
					continue;
				case 10u:
					result = list.ToArray();
					num = ((int)num2 * -460895255) ^ 0x71320A65;
					continue;
				case 9u:
					num4 = 0;
					num = ((int)num2 * -460349332) ^ 0x440ABBEF;
					continue;
				case 8u:
				{
					int num7;
					if (num6 < count)
					{
						num = 1679158281;
						num7 = 1679158281;
					}
					else
					{
						num = 2129475528;
						num7 = 2129475528;
					}
					continue;
				}
				case 7u:
				{
					bool flag = num4 < maxImpact;
					list.Add(new Card
					{
						Impact = (flag ? (-(maxImpact - num4)) : (maxImpact * 2 - num4)),
						Type = num6
					});
					num = 968839213;
					continue;
				}
				case 6u:
					count = json.Count;
					num = ((int)num2 * -710538685) ^ -1631125436;
					continue;
				case 4u:
					num = ((int)num2 * -2091189476) ^ 0x35ACDA49;
					continue;
				case 3u:
					list = new List<Card>();
					num = (int)((num2 * 1578303324) ^ 0x6C56E625);
					continue;
				case 2u:
				{
					int num5;
					if (num3 < jSONNode[num4].AsInt)
					{
						num = 969921506;
						num5 = 969921506;
					}
					else
					{
						num = 1523474629;
						num5 = 1523474629;
					}
					continue;
				}
				case 1u:
					num = 925552714;
					continue;
				case 0u:
					num = (int)(num2 * 23773173) ^ -1212679487;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 584755517;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71F099E0u) % 3u)
				{
				case 1u:
					goto IL_0006;
				case 2u:
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
				num = (int)((num2 * 627720070) ^ 0x1746F828);
			}
		}
	}

	private string CardsToString()
	{
		string text = default(string);
		int num4 = default(int);
		Card card = default(Card);
		Card[] cards = default(Card[]);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1088942408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE91FB3Fu) % 15u)
				{
				case 14u:
					text = "[\n\t";
					num4 = 0;
					num = (int)(num2 * 460085720) ^ -870784913;
					continue;
				case 13u:
				{
					int num6;
					int num7;
					if (num4 != card.Type)
					{
						num6 = 1545307596;
						num7 = 1545307596;
					}
					else
					{
						num6 = 507763038;
						num7 = 507763038;
					}
					num = num6 ^ (int)(num2 * 421463508);
					continue;
				}
				case 12u:
				{
					string string_ = text;
					Card card2 = card;
					text = Rules.smethod_3(string_, (card2 != null) ? Rules.smethod_2((object)card2) : null, " ");
					num = -977117288;
					continue;
				}
				case 11u:
					cards = Cards;
					num3 = 0;
					num = (int)((num2 * 255140147) ^ 0xA3EDE1F);
					continue;
				case 10u:
				{
					int num5;
					if (num3 >= cards.Length)
					{
						num = -1737095872;
						num5 = -1737095872;
					}
					else
					{
						num = -1110192172;
						num5 = -1110192172;
					}
					continue;
				}
				case 8u:
					text = Rules.smethod_1(text, "\n\t");
					num = ((int)num2 * -447067690) ^ -693143410;
					continue;
				case 7u:
					result = Rules.smethod_1(text, "\n]");
					num = ((int)num2 * -403381198) ^ 0x5FE86ADF;
					continue;
				case 6u:
					num3++;
					num = (int)((num2 * 1278675169) ^ 0x7ECC19C8);
					continue;
				case 4u:
					num = (int)((num2 * 1261233171) ^ 0x3C6F453F);
					continue;
				case 3u:
					num4 = card.Type;
					num = ((int)num2 * -1401509053) ^ -425257723;
					continue;
				case 2u:
					card = cards[num3];
					num = -220227147;
					continue;
				case 1u:
					num = ((int)num2 * -1903193056) ^ 0x1CF36035;
					continue;
				case 0u:
					num = ((int)num2 * -1096454705) ^ -1381633977;
					continue;
				case 9u:
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
			int num = 109832195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5887D3DAu) % 9u)
				{
				case 8u:
					result = Rules.smethod_1(string_, " ]");
					num = (int)((num2 * 2076077125) ^ 0x96353CF);
					continue;
				case 7u:
				{
					int num4;
					if (num3 < RiskChances.Length)
					{
						num = 1690745349;
						num4 = 1690745349;
					}
					else
					{
						num = 1703095914;
						num4 = 1703095914;
					}
					continue;
				}
				case 6u:
					string_ = Rules.smethod_3(string_, ", ", RiskChances[num3].ToString(Rules.smethod_4()));
					num = 1181721494;
					continue;
				case 5u:
					num3 = 1;
					num = ((int)num2 * -368633433) ^ 0x66C75114;
					continue;
				case 2u:
					num = ((int)num2 * -133443809) ^ 0x25F3547B;
					continue;
				case 1u:
					string_ = Rules.smethod_1("[ ", RiskChances[0].ToString(Rules.smethod_4()));
					num = (int)((num2 * 1225531996) ^ 0x1B3C2F6E);
					continue;
				case 0u:
					num3++;
					num = (int)((num2 * 197203938) ^ 0x49ECD0E9);
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
