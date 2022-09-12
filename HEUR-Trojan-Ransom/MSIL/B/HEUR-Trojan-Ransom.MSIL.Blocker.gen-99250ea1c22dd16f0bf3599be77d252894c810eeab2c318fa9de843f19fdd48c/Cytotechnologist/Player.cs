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
			int num3 = default(int);
			int result = default(int);
			int num4 = default(int);
			int num6 = default(int);
			int[] planningCards = default(int[]);
			while (true)
			{
				int num = 852960303;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1F4F2056u) % 12u)
					{
					case 10u:
						num = ((int)num2 * -497652597) ^ 0x528F47E7;
						continue;
					case 9u:
						num3 = 0;
						num = (int)((num2 * 1997114985) ^ 0x54DEC19C);
						continue;
					case 8u:
						result = num4;
						num = (int)(num2 * 951033895) ^ -1467187911;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (num6 <= 0)
						{
							num7 = 1470792792;
							num8 = 1470792792;
						}
						else
						{
							num7 = 147169490;
							num8 = 147169490;
						}
						num = num7 ^ (int)(num2 * 229814618);
						continue;
					}
					case 6u:
						num4++;
						num = ((int)num2 * -1929438635) ^ -187774972;
						continue;
					case 5u:
						num6 = planningCards[num3];
						num = 361585760;
						continue;
					case 4u:
						planningCards = PlanningCards;
						num = (int)((num2 * 1274178659) ^ 0x6CD57937);
						continue;
					case 3u:
					{
						int num5;
						if (num3 < planningCards.Length)
						{
							num = 1182329899;
							num5 = 1182329899;
						}
						else
						{
							num = 1735853758;
							num5 = 1735853758;
						}
						continue;
					}
					case 1u:
						num4 = 0;
						num = ((int)num2 * -1422826677) ^ -1842175875;
						continue;
					case 0u:
						num3++;
						num = 567106445;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1393705223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE9C8FBu) % 8u)
				{
				case 7u:
					text = "326E46";
					num = ((int)num2 * -469497045) ^ 0x6D3A21D6;
					continue;
				case 5u:
					text = "4942696E6443";
					num = (int)((num2 * 429278205) ^ 0x23332B82);
					continue;
				case 4u:
					text = null;
					flag = BaseStream == 0;
					num = ((int)num2 * -1313640037) ^ -184990940;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1826565104;
						num5 = -1826565104;
					}
					else
					{
						num4 = -1343029049;
						num5 = -1343029049;
					}
					num = num4 ^ ((int)num2 * -1657954317);
					continue;
				}
				case 2u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = 831771356;
						num3 = 831771356;
					}
					else
					{
						num = 1610887259;
						num3 = 1610887259;
					}
					continue;
				}
				case 0u:
					result = text;
					num = 431415970;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -374202240;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE289C594u) % 5u)
				{
				case 4u:
					if (PlanningCards.Length == 0)
					{
						num = (int)((num2 * 852628216) ^ 0x1B8C670C);
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 3u:
					num3 = 0;
					goto IL_0023;
				case 1u:
					num = (int)(num2 * 1934248962) ^ -1447117541;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					result = num3;
					num = -660702412;
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
			int num = -43635436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAE08A43u) % 3u)
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
				num = ((int)num2 * -1162299003) ^ -1958748365;
			}
		}
	}

	public string PlanningCardsToString()
	{
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = -760875056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1511AD7u) % 16u)
				{
				case 15u:
					num4 = PlanningCards[num3];
					num = ((int)num2 * -749147738) ^ -2003069741;
					continue;
				case 14u:
					flag = num4 == 0;
					num = ((int)num2 * -562345089) ^ -539594426;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -2058929854;
						num8 = -2058929854;
					}
					else
					{
						num7 = -1973894540;
						num8 = -1973894540;
					}
					num = num7 ^ ((int)num2 * -1174988947);
					continue;
				}
				case 12u:
					num = -1224592616;
					continue;
				case 11u:
					flag2 = num3 < PlanningCards.Length;
					num = -1401479110;
					continue;
				case 10u:
					result = text;
					num = (int)((num2 * 251874768) ^ 0x42AF54E5);
					continue;
				case 8u:
					num = ((int)num2 * -164232413) ^ 0x2AD5039;
					continue;
				case 7u:
					text = " ";
					num = (int)((num2 * 1219690341) ^ 0x3F111980);
					continue;
				case 6u:
					num3++;
					num = -751065364;
					continue;
				case 5u:
					num = (int)((num2 * 281013687) ^ 0x1571B20F);
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -792919611) ^ 0x4E92C806;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -277012159;
						num6 = -277012159;
					}
					else
					{
						num5 = -1610993031;
						num6 = -1610993031;
					}
					num = num5 ^ ((int)num2 * -615940622);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1125730916) ^ 0x1DBDED3E);
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
					num = -2010248015;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = -1567209182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6DA32F3u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1119281848) ^ 0x42925EEC);
					continue;
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = (int)(num2 * 1313702219) ^ -1621806634;
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
		int[] array = default(int[]);
		int count = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1952159690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x637C2768u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1984399707) ^ 0x388077E1;
					continue;
				case 7u:
					array = new int[count];
					num3 = 0;
					num = (int)((num2 * 2042405934) ^ 0x74DA0BB9);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1049249947;
						num5 = 1049249947;
					}
					else
					{
						num4 = 1577910475;
						num5 = 1577910475;
					}
					num = num4 ^ (int)(num2 * 196985804);
					continue;
				}
				case 4u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 1808552061;
					continue;
				case 2u:
					result = array;
					num = (int)((num2 * 154559920) ^ 0x107F6D02);
					continue;
				case 1u:
					count = json.Count;
					num = (int)((num2 * 906340578) ^ 0x41764002);
					continue;
				case 0u:
					flag = num3 < count;
					num = 132418425;
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
			int num = 1144976371;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE3CFCAu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1502971205) ^ 0x702DB451;
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -609074072) ^ -194771807;
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

	static string smethod_0(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
