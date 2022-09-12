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
			bool flag = default(bool);
			int num5 = default(int);
			int num4 = default(int);
			int[] planningCards = default(int[]);
			int result = default(int);
			while (true)
			{
				int num2 = -1590156342;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xC6887ABEu) % 13u)
					{
					case 11u:
						num2 = (int)((num3 * 1554989235) ^ 0x7FCC7703);
						continue;
					case 10u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = 1363744185;
							num8 = 1363744185;
						}
						else
						{
							num7 = 1688580779;
							num8 = 1688580779;
						}
						num2 = num7 ^ ((int)num3 * -778091564);
						continue;
					}
					case 9u:
						num++;
						num2 = (int)(num3 * 350701069) ^ -2014494304;
						continue;
					case 8u:
						num5++;
						num2 = (int)((num3 * 714378745) ^ 0x7AC65B49);
						continue;
					case 7u:
						num4 = planningCards[num5];
						num2 = -1479420443;
						continue;
					case 6u:
						num2 = -1289247359;
						continue;
					case 5u:
					{
						int num6;
						if (num5 >= planningCards.Length)
						{
							num2 = -1623571324;
							num6 = -1623571324;
						}
						else
						{
							num2 = -718008012;
							num6 = -718008012;
						}
						continue;
					}
					case 4u:
						result = num;
						num2 = (int)((num3 * 76095734) ^ 0xFFC44E9);
						continue;
					case 3u:
						num5 = 0;
						num2 = (int)((num3 * 1446803644) ^ 0x682215BE);
						continue;
					case 2u:
						flag = num4 > 0;
						num2 = ((int)num3 * -1394606886) ^ -1193323738;
						continue;
					case 1u:
						planningCards = PlanningCards;
						num2 = (int)(num3 * 559442228) ^ -233474950;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1457545005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAEA13F4Cu) % 13u)
				{
				case 11u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 59690987;
						num5 = 59690987;
					}
					else
					{
						num4 = 26441357;
						num5 = 26441357;
					}
					num = num4 ^ (int)(num2 * 1058828824);
					continue;
				}
				case 10u:
					text = "714737";
					num = ((int)num2 * -1507881575) ^ -460006445;
					continue;
				case 9u:
					text = null;
					flag = BaseStream == 0;
					num = ((int)num2 * -724677626) ^ 0xB4F7AF6;
					continue;
				case 8u:
					num = (int)(num2 * 2080301493) ^ -28704112;
					continue;
				case 7u:
					text = "586D6C546F4669656C64547970654D";
					num = (int)(num2 * 1383596945) ^ -1816096018;
					continue;
				case 6u:
					num = (int)((num2 * 646539111) ^ 0x2E4A56DF);
					continue;
				case 5u:
					num = ((int)num2 * -1996483402) ^ -1006002587;
					continue;
				case 4u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = -2012303127;
						num3 = -2012303127;
					}
					else
					{
						num = -93160031;
						num3 = -93160031;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -774100688) ^ 0x50D55A37;
					continue;
				case 1u:
					result = text;
					num = -1397579716;
					continue;
				case 0u:
					num = ((int)num2 * -146071341) ^ -1378593039;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -2134055968;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCA9E711Du) % 4u)
				{
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -1858760819) ^ 0x1E06BBF8;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 0u:
					num3 = 0;
					goto IL_0023;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					result = num3;
					num = -1036896917;
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
		int num6 = default(int);
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -2120861359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFA25097u) % 12u)
				{
				case 11u:
					num = -1230913502;
					continue;
				case 10u:
					num6++;
					num = -1581135540;
					continue;
				case 9u:
					num3 = PlanningCards[num6];
					num = ((int)num2 * -1159184841) ^ 0x7E9B25D1;
					continue;
				case 8u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num6],
						"x",
						num3.ToString(),
						" "
					});
					num = -226491074;
					continue;
				case 6u:
					text = " ";
					num6 = 0;
					num = (int)((num2 * 1656716359) ^ 0xBBEF4A6);
					continue;
				case 5u:
					num = (int)(num2 * 2001774782) ^ -1650480945;
					continue;
				case 4u:
					num = ((int)num2 * -1362613414) ^ -88694655;
					continue;
				case 3u:
				{
					int num7;
					if (num6 < PlanningCards.Length)
					{
						num = -470601768;
						num7 = -470601768;
					}
					else
					{
						num = -1054995251;
						num7 = -1054995251;
					}
					continue;
				}
				case 2u:
					result = text;
					num = ((int)num2 * -89766934) ^ 0xD80752C;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (num3 != 0)
					{
						num4 = -1229185391;
						num5 = -1229185391;
					}
					else
					{
						num4 = -1063298803;
						num5 = -1063298803;
					}
					num = num4 ^ (int)(num2 * 1173676290);
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 510499275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C48F665u) % 3u)
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
				num = (int)(num2 * 1678528184) ^ -499846658;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int[] array = new int[count];
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -2017982966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F6E1292u) % 7u)
				{
				case 5u:
					num3++;
					num = ((int)num2 * -1690680914) ^ -773028381;
					continue;
				case 4u:
					result = array;
					num = (int)((num2 * 1946345504) ^ 0x65B4F6B2);
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1958432596) ^ -1143397975;
					continue;
				case 2u:
					array[num3] = json[num3].AsInt;
					num = -892843455;
					continue;
				case 1u:
				{
					int num4;
					if (num3 < count)
					{
						num = -1073155584;
						num4 = -1073155584;
					}
					else
					{
						num = -745649542;
						num4 = -745649542;
					}
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1485906012;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x434739CDu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1441196964) ^ 0x2DFA0549;
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)((num2 * 362571239) ^ 0x2ABBFAF4);
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

	static string smethod_0(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
