using SimpleJSON;

namespace Cytotechnologist;

public class Player
{
	public string Name { get; private set; }

	private int[] PlanningCards { get; set; }

	public bool UseOneMorePlanningSprint { get; private set; }

	public int PlanningCardsCount
	{
		get
		{
			int num8 = default(int);
			int num3 = default(int);
			int[] planningCards = default(int[]);
			bool flag = default(bool);
			int num4 = default(int);
			int result = default(int);
			while (true)
			{
				int num = 1103501665;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1F425DC2u) % 14u)
					{
					case 12u:
						num8++;
						num = ((int)num2 * -838080985) ^ -1118083624;
						continue;
					case 11u:
					{
						int num7;
						if (num3 < planningCards.Length)
						{
							num = 1385328231;
							num7 = 1385328231;
						}
						else
						{
							num = 721143522;
							num7 = 721143522;
						}
						continue;
					}
					case 10u:
						num3 = 0;
						num = ((int)num2 * -821431289) ^ -1525398369;
						continue;
					case 9u:
						num8 = 0;
						num = ((int)num2 * -659665133) ^ 0x747C8390;
						continue;
					case 8u:
						num = 1447922540;
						continue;
					case 7u:
						planningCards = PlanningCards;
						num = (int)(num2 * 264334977) ^ -891893335;
						continue;
					case 6u:
						num3++;
						num = ((int)num2 * -338087922) ^ -298123397;
						continue;
					case 5u:
						flag = num4 > 0;
						num = ((int)num2 * -822524747) ^ -1567484547;
						continue;
					case 4u:
						result = num8;
						num = ((int)num2 * -565080744) ^ -626771833;
						continue;
					case 3u:
						num = (int)((num2 * 687905723) ^ 0x6CD54EFC);
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -878691016;
							num6 = -878691016;
						}
						else
						{
							num5 = -1098747282;
							num6 = -1098747282;
						}
						num = num5 ^ ((int)num2 * -873478177);
						continue;
					}
					case 1u:
						num4 = planningCards[num3];
						num = 450794653;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1701735024;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7C8A9Fu) % 14u)
				{
				case 13u:
					flag = BaseStream == 0;
					num = ((int)num2 * -360483382) ^ 0x61C936D8;
					continue;
				case 12u:
					num = (int)(num2 * 329150376) ^ -319245511;
					continue;
				case 11u:
				{
					int num5;
					if (BaseStream == 1)
					{
						num = 1428129351;
						num5 = 1428129351;
					}
					else
					{
						num = 1288789371;
						num5 = 1288789371;
					}
					continue;
				}
				case 10u:
					num = (int)((num2 * 370188114) ^ 0x74CA534D);
					continue;
				case 9u:
					text = null;
					num = ((int)num2 * -1527721557) ^ -304297295;
					continue;
				case 8u:
					num = (int)(num2 * 1672334892) ^ -894045973;
					continue;
				case 7u:
					num = ((int)num2 * -541907677) ^ 0x439CBDB7;
					continue;
				case 6u:
					text = "55564B51384D6B";
					num = ((int)num2 * -726180699) ^ 0x5CDBB5F2;
					continue;
				case 5u:
					text = "5365744F6E496E766F6B654D72";
					num = (int)(num2 * 361267729) ^ -1235189976;
					continue;
				case 3u:
					num = (int)(num2 * 115414391) ^ -1184875922;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -986506104;
						num4 = -986506104;
					}
					else
					{
						num3 = -694036980;
						num4 = -694036980;
					}
					num = num3 ^ ((int)num2 * -1755004126);
					continue;
				}
				case 0u:
					result = text;
					num = 1463653959;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -1224821083;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xBAA1F8E9u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -878522581) ^ 0x7A1F2322;
					continue;
				case 2u:
					num3 = 0;
					goto IL_0013;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)(num2 * 1847502118) ^ -1671363052;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0013;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0013:
					result = num3;
					num = -1912613295;
					continue;
				}
				break;
			}
		}
	}

	private Player()
	{
		while (true)
		{
			int num = 992160134;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC475D54u) % 3u)
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
				num = ((int)num2 * -613296048) ^ 0x24B0442F;
			}
		}
	}

	public string PlanningCardsToString()
	{
		int num3 = default(int);
		int num4 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -2032255487;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7F13F02u) % 14u)
				{
				case 13u:
					num3++;
					num = -118184831;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (num4 != 0)
					{
						num6 = 1850240902;
						num7 = 1850240902;
					}
					else
					{
						num6 = 18714297;
						num7 = 18714297;
					}
					num = num6 ^ ((int)num2 * -1698467970);
					continue;
				}
				case 10u:
					num3 = 0;
					num = ((int)num2 * -293031633) ^ 0x9A6FDE9;
					continue;
				case 8u:
					num4 = PlanningCards[num3];
					num = (int)((num2 * 653064416) ^ 0x67F2AECD);
					continue;
				case 7u:
					text = " ";
					num = ((int)num2 * -1439175256) ^ -1478904192;
					continue;
				case 6u:
					result = text;
					num = (int)((num2 * 1179722480) ^ 0x3A6F87BF);
					continue;
				case 5u:
					num = ((int)num2 * -1516198262) ^ 0x4BAB8883;
					continue;
				case 4u:
					num = (int)(num2 * 1105635628) ^ -1522491725;
					continue;
				case 3u:
				{
					int num5;
					if (num3 >= PlanningCards.Length)
					{
						num = -297911468;
						num5 = -297911468;
					}
					else
					{
						num = -2080882444;
						num5 = -2080882444;
					}
					continue;
				}
				case 2u:
					num = -1858378864;
					continue;
				case 1u:
					num = ((int)num2 * -1783809287) ^ 0x23851BD2;
					continue;
				case 0u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -1277409514;
					continue;
				case 12u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = -19856863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F16D390u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 125218506) ^ -1913200792;
					continue;
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -309612121) ^ -171496472;
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

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] result = default(int[]);
		int[] array = default(int[]);
		int num3 = default(int);
		int count = default(int);
		while (true)
		{
			int num = -1920542718;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94ED8BC8u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1916375082) ^ -291836660;
					continue;
				case 8u:
					result = array;
					num = (int)(num2 * 2108227759) ^ -308652345;
					continue;
				case 7u:
					array[num3] = json[num3].AsInt;
					num = -649603097;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -858481266) ^ 0x6C76EFAB;
					continue;
				case 3u:
					num = (int)((num2 * 286501252) ^ 0x93FA0FC);
					continue;
				case 2u:
					count = json.Count;
					array = new int[count];
					num = ((int)num2 * -1607630530) ^ -628632337;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -2039796442) ^ 0x7B524462;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < count)
					{
						num = -208360925;
						num4 = -208360925;
					}
					else
					{
						num = -1734074146;
						num4 = -1734074146;
					}
					continue;
				}
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
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = 1441295432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30325480u) % 3u)
				{
				case 2u:
					goto IL_0024;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0024:
				num = ((int)num2 * -495358369) ^ -1120287607;
			}
		}
	}

	static string smethod_0(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
