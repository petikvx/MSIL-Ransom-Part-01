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
			int num4 = default(int);
			int[] planningCards = default(int[]);
			int result = default(int);
			int num5 = default(int);
			while (true)
			{
				int num2 = 1432582525;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x7D6FB0A6u) % 14u)
					{
					case 13u:
						num2 = 1354390886;
						continue;
					case 12u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = 1478071158;
							num8 = 1478071158;
						}
						else
						{
							num7 = 1659028703;
							num8 = 1659028703;
						}
						num2 = num7 ^ (int)(num3 * 415861015);
						continue;
					}
					case 10u:
					{
						int num6;
						if (num4 >= planningCards.Length)
						{
							num2 = 2020574859;
							num6 = 2020574859;
						}
						else
						{
							num2 = 1342801921;
							num6 = 1342801921;
						}
						continue;
					}
					case 9u:
						num2 = ((int)num3 * -589399407) ^ 0x48F1FFE1;
						continue;
					case 8u:
						num4++;
						num2 = (int)(num3 * 1407678011) ^ -1673443498;
						continue;
					case 7u:
						result = num;
						num2 = ((int)num3 * -1455309634) ^ 0x75DA9C35;
						continue;
					case 5u:
						flag = num5 > 0;
						num2 = (int)(num3 * 359329564) ^ -326069604;
						continue;
					case 4u:
						num++;
						num2 = (int)(num3 * 723999367) ^ -393365917;
						continue;
					case 3u:
						num5 = planningCards[num4];
						num2 = 1722568014;
						continue;
					case 2u:
						num2 = ((int)num3 * -10966360) ^ -713233275;
						continue;
					case 1u:
						num2 = ((int)num3 * -194650831) ^ -1542378583;
						continue;
					case 0u:
						planningCards = PlanningCards;
						num4 = 0;
						num2 = ((int)num3 * -1150315157) ^ -82753395;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1824844635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BD1A5B8u) % 15u)
				{
				case 14u:
					num = (int)((num2 * 1788722438) ^ 0x1025A887);
					continue;
				case 13u:
					num = (int)((num2 * 546892115) ^ 0x49EDE5F5);
					continue;
				case 12u:
					result = text;
					num = 39524887;
					continue;
				case 10u:
					num = (int)(num2 * 1597037048) ^ -88152719;
					continue;
				case 9u:
					num = (int)(num2 * 322263817) ^ -1567736730;
					continue;
				case 7u:
					text = "31456E3263693565";
					num = ((int)num2 * -1115939607) ^ 0x3F2EFC34;
					continue;
				case 6u:
					num = (int)(num2 * 1038900447) ^ -1144893461;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (BaseStream != 0)
					{
						num5 = -1960545980;
						num6 = -1960545980;
					}
					else
					{
						num5 = -1817417164;
						num6 = -1817417164;
					}
					num = num5 ^ (int)(num2 * 1598681252);
					continue;
				}
				case 4u:
					flag = BaseStream == 1;
					num = 10336319;
					continue;
				case 3u:
					text = null;
					num = ((int)num2 * -314722824) ^ -656175047;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2077283240;
						num4 = -2077283240;
					}
					else
					{
						num3 = -100407764;
						num4 = -100407764;
					}
					num = num3 ^ ((int)num2 * -1236336185);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1591434336) ^ 0x13108044);
					continue;
				case 0u:
					text = "434F4D536572766572456E74";
					num = (int)(num2 * 306904274) ^ -1968194527;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0022;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0049;
		IL_0048:
		num = 0;
		goto IL_0049;
		IL_0022:
		int num2 = 1056648629;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x4DCBDEE4u) % 4u)
			{
			case 2u:
				num2 = ((int)num3 * -1795643648) ^ -1026329653;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_0049:
		result = num;
		num2 = 1978707166;
		goto IL_0027;
	}

	private Player()
	{
		while (true)
		{
			int num = 368485755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A4937B2u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1267501335) ^ 0x7CB497C0;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		bool flag = default(bool);
		string result = default(string);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -1723955632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED689D32u) % 12u)
				{
				case 11u:
					num = (int)((num2 * 1791036961) ^ 0x69A56AE6);
					continue;
				case 10u:
					num = (int)(num2 * 1684948519) ^ -507778625;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1739556747;
						num7 = -1739556747;
					}
					else
					{
						num6 = -955525319;
						num7 = -955525319;
					}
					num = num6 ^ ((int)num2 * -1643364568);
					continue;
				}
				case 8u:
					result = text;
					num = (int)((num2 * 1745037936) ^ 0x29F4F728);
					continue;
				case 7u:
					num3++;
					num = -1399871238;
					continue;
				case 6u:
					num3 = 0;
					num = (int)((num2 * 1420796085) ^ 0x5D7334B0);
					continue;
				case 4u:
					num5 = PlanningCards[num3];
					num = -1550868149;
					continue;
				case 3u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num5.ToString(),
						" "
					});
					num = -515856376;
					continue;
				case 1u:
					flag = num5 == 0;
					num = ((int)num2 * -37675242) ^ 0x4FCFB62D;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= PlanningCards.Length)
					{
						num = -280850402;
						num4 = -280850402;
					}
					else
					{
						num = -541008246;
						num4 = -541008246;
					}
					continue;
				}
				case 5u:
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
			int num = -1028391168;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCF8D20Eu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
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
				num = ((int)num2 * -1678855753) ^ 0x63F673DB;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] result = default(int[]);
		int[] array = default(int[]);
		int count = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -592291595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE1CBDDAu) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1410610068) ^ -1843163021;
					continue;
				case 10u:
					result = array;
					num = ((int)num2 * -1205899330) ^ -1781262945;
					continue;
				case 9u:
					num = (int)(num2 * 1952051753) ^ -754043589;
					continue;
				case 7u:
					count = json.Count;
					num = (int)((num2 * 567764985) ^ 0x6FED846E);
					continue;
				case 6u:
					num3++;
					num = (int)(num2 * 1933944683) ^ -276615875;
					continue;
				case 5u:
					flag = num3 < count;
					num = -175529232;
					continue;
				case 3u:
					array = new int[count];
					num = (int)(num2 * 1673996202) ^ -1254784560;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 634949557;
						num5 = 634949557;
					}
					else
					{
						num4 = 692184398;
						num5 = 692184398;
					}
					num = num4 ^ ((int)num2 * -255901499);
					continue;
				}
				case 1u:
					array[num3] = json[num3].AsInt;
					num = -1200326604;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 292943498) ^ 0x32BB92E5);
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
		string result = default(string);
		while (true)
		{
			int num = -1269877222;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0214FABu) % 4u)
				{
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -384606727) ^ 0x42DF1976;
					continue;
				case 0u:
					num = ((int)num2 * -764122797) ^ 0x58C8C4D;
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
