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
			int num5 = default(int);
			bool flag = default(bool);
			int num6 = default(int);
			int num7 = default(int);
			int[] planningCards = default(int[]);
			int result = default(int);
			while (true)
			{
				int num = 69393467;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x472EE7C7u) % 14u)
					{
					case 13u:
						num = (int)((num2 * 725159428) ^ 0x5862F0E6);
						continue;
					case 12u:
						num5 = 0;
						num = ((int)num2 * -734641098) ^ -1022670078;
						continue;
					case 11u:
						flag = num6 > 0;
						num = (int)(num2 * 1614201785) ^ -1062950008;
						continue;
					case 10u:
						num5++;
						num = (int)((num2 * 320720691) ^ 0x2DF72BC1);
						continue;
					case 9u:
					{
						int num8;
						if (num7 < planningCards.Length)
						{
							num = 724140028;
							num8 = 724140028;
						}
						else
						{
							num = 282817533;
							num8 = 282817533;
						}
						continue;
					}
					case 8u:
						num = 2008681786;
						continue;
					case 7u:
						num7++;
						num = ((int)num2 * -828243451) ^ 0x20A652BB;
						continue;
					case 6u:
						num = ((int)num2 * -1646156900) ^ 0x54252C28;
						continue;
					case 5u:
						num6 = planningCards[num7];
						num = 1750965969;
						continue;
					case 2u:
						result = num5;
						num = (int)((num2 * 2029945589) ^ 0x62D50627);
						continue;
					case 1u:
						planningCards = PlanningCards;
						num7 = 0;
						num = (int)((num2 * 1257324587) ^ 0x14360123);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1700095747;
							num4 = -1700095747;
						}
						else
						{
							num3 = -137695025;
							num4 = -137695025;
						}
						num = num3 ^ (int)(num2 * 1338064611);
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = null;
		bool flag = BaseStream == 0;
		string result = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1003408703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x343D79B0u) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1956408676;
						num6 = 1956408676;
					}
					else
					{
						num5 = 1859185283;
						num6 = 1859185283;
					}
					num = num5 ^ ((int)num2 * -1025413706);
					continue;
				}
				case 10u:
					result = text;
					num = 1082879816;
					continue;
				case 9u:
					text = "71736A";
					num = ((int)num2 * -2068065729) ^ -1532153464;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 782004553;
						num4 = 782004553;
					}
					else
					{
						num3 = 5121750;
						num4 = 5121750;
					}
					num = num3 ^ (int)(num2 * 495157159);
					continue;
				}
				case 7u:
					text = "4574775365737369";
					num = ((int)num2 * -1628417403) ^ 0x595AAEA;
					continue;
				case 5u:
					num = (int)(num2 * 67580792) ^ -1112653201;
					continue;
				case 4u:
					num = ((int)num2 * -1992249772) ^ -262314366;
					continue;
				case 3u:
					num = ((int)num2 * -1278311751) ^ 0x52B94FC1;
					continue;
				case 2u:
					flag2 = BaseStream == 1;
					num = 1428036836;
					continue;
				case 1u:
					num = ((int)num2 * -1475497246) ^ 0x756B1488;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0034;
		IL_0034:
		int result = num;
		int num2 = 1974019663;
		goto IL_0018;
		IL_0013:
		num2 = 1985019743;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ 0x3C67EA25) % 3u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_0033;
		default:
			return result;
		}
		goto IL_0013;
		IL_0033:
		num = 0;
		goto IL_0034;
	}

	private Player()
	{
		while (true)
		{
			int num = 561590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4835AE4Fu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -86504422) ^ 0x4668A665;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num = 0;
		bool flag2 = default(bool);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			bool flag = num < PlanningCards.Length;
			int num2 = -849178830;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xDF9FF693u) % 11u)
				{
				case 10u:
					flag2 = num4 == 0;
					num2 = (int)(num3 * 473931657) ^ -302361281;
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -86727383;
						num8 = -86727383;
					}
					else
					{
						num7 = -217285016;
						num8 = -217285016;
					}
					num2 = num7 ^ ((int)num3 * -557401676);
					continue;
				}
				case 8u:
					num2 = -848266467;
					continue;
				case 6u:
					result = text;
					num2 = (int)(num3 * 1863856062) ^ -887091087;
					continue;
				case 5u:
					num++;
					num2 = -1063175183;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1151734032;
						num6 = 1151734032;
					}
					else
					{
						num5 = 352651764;
						num6 = 352651764;
					}
					num2 = num5 ^ ((int)num3 * -155120300);
					continue;
				}
				case 2u:
					num2 = ((int)num3 * -1449866298) ^ 0x361031C7;
					continue;
				case 1u:
					num4 = PlanningCards[num];
					num2 = -863799770;
					continue;
				case 0u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num4.ToString(),
						" "
					});
					num2 = -548927947;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 366702049;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69E4D4B6u) % 4u)
				{
				case 3u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -699470406) ^ 0x4F9DD679;
					continue;
				case 1u:
					num = (int)((num2 * 485121886) ^ 0x29695276);
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
		int count = json.Count;
		int num3 = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1021515788;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D2CC441u) % 8u)
				{
				case 7u:
				{
					int num4;
					if (num3 < count)
					{
						num = 1903309347;
						num4 = 1903309347;
					}
					else
					{
						num = 1826895208;
						num4 = 1826895208;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -1825738447) ^ 0x629840DF;
					continue;
				case 5u:
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -2012990842) ^ -1671287525;
					continue;
				case 4u:
					num = (int)(num2 * 1818663270) ^ -448084834;
					continue;
				case 2u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 979405158;
					continue;
				case 1u:
					result = array;
					num = (int)((num2 * 404149290) ^ 0x146FFA05);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -528880794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE91F52Du) % 4u)
				{
				case 3u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)((num2 * 1380994160) ^ 0x6A0EF83B);
					continue;
				case 2u:
					num = (int)((num2 * 397940219) ^ 0x50772AFE);
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
