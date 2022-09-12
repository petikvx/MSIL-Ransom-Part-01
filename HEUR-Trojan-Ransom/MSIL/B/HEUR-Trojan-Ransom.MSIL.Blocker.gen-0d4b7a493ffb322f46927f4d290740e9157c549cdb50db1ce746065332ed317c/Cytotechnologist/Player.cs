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
			int num6 = default(int);
			int num3 = default(int);
			int result = default(int);
			int[] planningCards = default(int[]);
			int num8 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = 852808619;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13D69AE9u) % 14u)
					{
					case 13u:
						num6++;
						num = ((int)num2 * -1119013666) ^ -205579158;
						continue;
					case 11u:
						num = 1461497916;
						continue;
					case 10u:
						num3 = 0;
						num = ((int)num2 * -1938839142) ^ 0x519F569F;
						continue;
					case 9u:
						result = num3;
						num = (int)(num2 * 93354816) ^ -232544271;
						continue;
					case 8u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1798353466) ^ -1750211324;
						continue;
					case 7u:
						num6 = 0;
						num = (int)((num2 * 492639813) ^ 0x679346D8);
						continue;
					case 6u:
						num8 = planningCards[num6];
						num = 1982881875;
						continue;
					case 4u:
						flag = num8 > 0;
						num = ((int)num2 * -1161163632) ^ 0x358E162A;
						continue;
					case 3u:
					{
						int num7;
						if (num6 < planningCards.Length)
						{
							num = 672556467;
							num7 = 672556467;
						}
						else
						{
							num = 776478964;
							num7 = 776478964;
						}
						continue;
					}
					case 2u:
						num = (int)((num2 * 948515382) ^ 0x795DF5E4);
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 185468111;
							num5 = 185468111;
						}
						else
						{
							num4 = 2046993324;
							num5 = 2046993324;
						}
						num = num4 ^ (int)(num2 * 2125120103);
						continue;
					}
					case 0u:
						num3++;
						num = (int)((num2 * 2002708486) ^ 0x2C94967A);
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = null;
		if (BaseStream == 0)
		{
			goto IL_0050;
		}
		goto IL_00de;
		IL_00de:
		int num;
		int num2;
		if (BaseStream != 1)
		{
			num = -1161572980;
			num2 = -1161572980;
		}
		else
		{
			num = -824860712;
			num2 = -824860712;
		}
		goto IL_0094;
		IL_0094:
		string result = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xAE649428u) % 10u)
			{
			case 9u:
				num = ((int)num3 * -1158025798) ^ -894491211;
				continue;
			case 7u:
				num = ((int)num3 * -1063996799) ^ 0x39379423;
				continue;
			case 6u:
				text = "5A79385A343637";
				num = (int)((num3 * 831021632) ^ 0x79361087);
				continue;
			case 5u:
				break;
			case 4u:
				num = (int)((num3 * 877229825) ^ 0x455C3C6A);
				continue;
			case 3u:
				text = "49536F61704D65737361";
				num = ((int)num3 * -1305359507) ^ -1065993185;
				continue;
			case 2u:
				num = (int)(num3 * 368602691) ^ -784885058;
				continue;
			case 0u:
				result = text;
				num = -987306075;
				continue;
			case 8u:
				goto IL_00de;
			default:
				return result;
			}
			break;
		}
		goto IL_0050;
		IL_0050:
		num = -290081443;
		goto IL_0094;
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
		int num2 = 217705800;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x14A29E4Eu) % 4u)
			{
			case 3u:
				num2 = ((int)num3 * -1189865275) ^ -1809714192;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_0049:
		result = num;
		num2 = 514572313;
		goto IL_0027;
	}

	private Player()
	{
	}

	public string PlanningCardsToString()
	{
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1734802362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF74076E8u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -2050889843) ^ -1747589029;
					continue;
				case 12u:
					num4 = PlanningCards[num3];
					num = ((int)num2 * -1919924352) ^ -890735386;
					continue;
				case 11u:
					num3++;
					num = -137965419;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 1970233722;
						num7 = 1970233722;
					}
					else
					{
						num6 = 220251446;
						num7 = 220251446;
					}
					num = num6 ^ (int)(num2 * 1816924833);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1810228173) ^ 0x62389170;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -831669272) ^ 0x424F79E5;
					continue;
				case 7u:
					flag = num4 == 0;
					num = ((int)num2 * -2088160475) ^ -2130728453;
					continue;
				case 6u:
					num = -2066347553;
					continue;
				case 5u:
				{
					int num5;
					if (num3 < PlanningCards.Length)
					{
						num = -1340206695;
						num5 = -1340206695;
					}
					else
					{
						num = -1407814631;
						num5 = -1407814631;
					}
					continue;
				}
				case 4u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -1705099334;
					continue;
				case 3u:
					num = ((int)num2 * -900651484) ^ -98680486;
					continue;
				case 1u:
					text = " ";
					num = (int)(num2 * 1934656769) ^ -1593781504;
					continue;
				case 0u:
					result = text;
					num = (int)(num2 * 1937807098) ^ -1384455554;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = -1732105778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80191C01u) % 3u)
				{
				case 2u:
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
				num = ((int)num2 * -1111742961) ^ -1243077477;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int[] array = new int[count];
		int[] result = default(int[]);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 877881527;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32C6602Eu) % 9u)
				{
				case 8u:
					result = array;
					num = ((int)num2 * -390621017) ^ -728157912;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1267182507;
						num5 = 1267182507;
					}
					else
					{
						num4 = 74288065;
						num5 = 74288065;
					}
					num = num4 ^ (int)(num2 * 1340666956);
					continue;
				}
				case 6u:
					num3++;
					num = ((int)num2 * -1475315194) ^ 0x4DA86A6A;
					continue;
				case 5u:
					flag = num3 < count;
					num = 1071527444;
					continue;
				case 4u:
					array[num3] = json[num3].AsInt;
					num = 1032148065;
					continue;
				case 2u:
					num = (int)(num2 * 1978207747) ^ -1014118713;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 226471959) ^ 0x24EB400F);
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
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = 1719063962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58DBEB9Du) % 3u)
				{
				case 1u:
					goto IL_0024;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0024:
				num = (int)(num2 * 1207419684) ^ -534610595;
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
