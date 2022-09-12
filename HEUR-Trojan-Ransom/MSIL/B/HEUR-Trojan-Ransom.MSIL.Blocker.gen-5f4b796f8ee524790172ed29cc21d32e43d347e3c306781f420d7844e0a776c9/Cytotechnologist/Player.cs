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
			int num = 0;
			int num6 = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			int result = default(int);
			while (true)
			{
				int num2 = 1091715506;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xC439784u) % 14u)
					{
					case 13u:
						num2 = 1531862463;
						continue;
					case 12u:
						num2 = ((int)num3 * -1355659677) ^ 0x4C757CE5;
						continue;
					case 11u:
						num2 = ((int)num3 * -1576461878) ^ 0x6E92DBCC;
						continue;
					case 10u:
					{
						int num7;
						int num8;
						if (num6 > 0)
						{
							num7 = -1623330615;
							num8 = -1623330615;
						}
						else
						{
							num7 = -1113398471;
							num8 = -1113398471;
						}
						num2 = num7 ^ (int)(num3 * 533333561);
						continue;
					}
					case 8u:
						planningCards = PlanningCards;
						num2 = ((int)num3 * -853819543) ^ -2111879594;
						continue;
					case 7u:
						num4++;
						num2 = (int)(num3 * 915301890) ^ -674318562;
						continue;
					case 6u:
						num4 = 0;
						num2 = ((int)num3 * -897805619) ^ -860000659;
						continue;
					case 5u:
						result = num;
						num2 = ((int)num3 * -1302731505) ^ 0x2FED21F3;
						continue;
					case 4u:
						num6 = planningCards[num4];
						num2 = 126158837;
						continue;
					case 3u:
						num2 = ((int)num3 * -1534693578) ^ 0x6B9F4BD6;
						continue;
					case 1u:
						num++;
						num2 = (int)(num3 * 777523068) ^ -1586076945;
						continue;
					case 0u:
					{
						int num5;
						if (num4 >= planningCards.Length)
						{
							num2 = 1097481419;
							num5 = 1097481419;
						}
						else
						{
							num2 = 160031134;
							num5 = 160031134;
						}
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = null;
		bool flag2 = default(bool);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1535161947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F28CB76u) % 11u)
				{
				case 10u:
					text = "75755068";
					num = ((int)num2 * -1281209094) ^ 0x4162D566;
					continue;
				case 9u:
					num = (int)(num2 * 203309831) ^ -178814747;
					continue;
				case 8u:
					flag2 = BaseStream == 0;
					num = (int)(num2 * 1471267588) ^ -1975840822;
					continue;
				case 7u:
					result = text;
					num = 619379314;
					continue;
				case 6u:
					num = ((int)num2 * -1756747979) ^ -834522952;
					continue;
				case 5u:
					flag = BaseStream == 1;
					num = 909644565;
					continue;
				case 4u:
					text = "49456E756D5641524941";
					num = (int)(num2 * 927490831) ^ -1549929187;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1703160062;
						num6 = -1703160062;
					}
					else
					{
						num5 = -1228302659;
						num6 = -1228302659;
					}
					num = num5 ^ ((int)num2 * -140428872);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1675778240;
						num4 = -1675778240;
					}
					else
					{
						num3 = -1859103706;
						num4 = -1859103706;
					}
					num = num3 ^ ((int)num2 * -210035780);
					continue;
				}
				case 3u:
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
			int num = -1518959936;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC43DD54Eu) % 5u)
				{
				case 4u:
					num3 = 0;
					goto IL_0004;
				case 3u:
					num = (int)((num2 * 1593679054) ^ 0x603A0657);
					continue;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)((num2 * 1187724103) ^ 0x43CCA0CC);
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = -2101646421;
					continue;
				}
				break;
			}
		}
	}

	private Player()
	{
	}

	public string PlanningCardsToString()
	{
		bool flag2 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1076343861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F61E77u) % 16u)
				{
				case 15u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1793987122;
						num8 = -1793987122;
					}
					else
					{
						num7 = -700973917;
						num8 = -700973917;
					}
					num = num7 ^ ((int)num2 * -2027819418);
					continue;
				}
				case 14u:
					num6 = PlanningCards[num5];
					num = 126146637;
					continue;
				case 13u:
					num5 = 0;
					num = (int)(num2 * 1258454056) ^ -201911533;
					continue;
				case 12u:
					num = (int)(num2 * 1275286423) ^ -519914940;
					continue;
				case 11u:
					num = ((int)num2 * -1667438355) ^ -517396866;
					continue;
				case 10u:
					flag = num6 == 0;
					num = ((int)num2 * -1839833882) ^ -758415014;
					continue;
				case 9u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num5],
						"x",
						num6.ToString(),
						" "
					});
					num = 1666264707;
					continue;
				case 7u:
					flag2 = num5 < PlanningCards.Length;
					num = 164338680;
					continue;
				case 5u:
					num5++;
					num = 973827440;
					continue;
				case 4u:
					num = ((int)num2 * -1084933351) ^ 0x21D9F916;
					continue;
				case 3u:
					result = text;
					num = (int)((num2 * 1063704377) ^ 0x53D70C17);
					continue;
				case 2u:
					text = " ";
					num = ((int)num2 * -1401918388) ^ 0x4DACB1D2;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1965360589;
						num4 = -1965360589;
					}
					else
					{
						num3 = -83298662;
						num4 = -83298662;
					}
					num = num3 ^ (int)(num2 * 605687412);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1290152686) ^ -202529502;
					continue;
				case 8u:
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
			int num = -1194508729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE66F9E9Du) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = new Player
				{
					Name = json["name"].Value,
					PlanningCards = ParsePlanningCards(json["planning-cards"]),
					UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
				};
				num = ((int)num2 * -701168565) ^ 0x2D070656;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int num3 = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = -2015075311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE24FF214u) % 10u)
				{
				case 9u:
					num3 = 0;
					num = ((int)num2 * -1380063133) ^ -737346512;
					continue;
				case 7u:
					array = new int[count];
					num = ((int)num2 * -1308617610) ^ 0x20CB8019;
					continue;
				case 6u:
					array[num3] = json[num3].AsInt;
					num = -1034349748;
					continue;
				case 5u:
					num = ((int)num2 * -1252796643) ^ 0x33745311;
					continue;
				case 4u:
					num = ((int)num2 * -320776496) ^ -560566280;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1985790707) ^ 0x3594C750;
					continue;
				case 1u:
					result = array;
					num = (int)((num2 * 497073931) ^ 0x5CAB55CD);
					continue;
				case 0u:
				{
					int num4;
					if (num3 < count)
					{
						num = -1426328026;
						num4 = -1426328026;
					}
					else
					{
						num = -169265333;
						num4 = -169265333;
					}
					continue;
				}
				case 3u:
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
			int num = -872738104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1E80101u) % 3u)
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
				num = ((int)num2 * -174752097) ^ -406712372;
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
