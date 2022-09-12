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
			int num4 = default(int);
			int num3 = default(int);
			int result = default(int);
			int num5 = default(int);
			int[] planningCards = default(int[]);
			while (true)
			{
				int num = 415230942;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FAB44u) % 11u)
					{
					case 10u:
					{
						int num7;
						int num8;
						if (num4 <= 0)
						{
							num7 = -698389374;
							num8 = -698389374;
						}
						else
						{
							num7 = -301645101;
							num8 = -301645101;
						}
						num = num7 ^ ((int)num2 * -1698779545);
						continue;
					}
					case 9u:
						num = (int)(num2 * 1820474861) ^ -1026020789;
						continue;
					case 8u:
						num3++;
						num = 520930488;
						continue;
					case 7u:
						result = num5;
						num = (int)((num2 * 208743501) ^ 0x777971AB);
						continue;
					case 5u:
						num5 = 0;
						num = (int)((num2 * 1805795140) ^ 0x7FECFB90);
						continue;
					case 4u:
					{
						int num6;
						if (num3 >= planningCards.Length)
						{
							num = 971402829;
							num6 = 971402829;
						}
						else
						{
							num = 725791916;
							num6 = 725791916;
						}
						continue;
					}
					case 3u:
						planningCards = PlanningCards;
						num3 = 0;
						num = (int)((num2 * 290648759) ^ 0x3FD4D05C);
						continue;
					case 1u:
						num5++;
						num = ((int)num2 * -1752575356) ^ -905674428;
						continue;
					case 0u:
						num4 = planningCards[num3];
						num = 534942874;
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
		string text = null;
		string result = default(string);
		while (true)
		{
			int num = -1723777765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE57AB75Bu) % 11u)
				{
				case 10u:
				{
					int num5;
					if (BaseStream != 1)
					{
						num = -1597500073;
						num5 = -1597500073;
					}
					else
					{
						num = -892406115;
						num5 = -892406115;
					}
					continue;
				}
				case 7u:
					num = (int)(num2 * 290935089) ^ -1455906004;
					continue;
				case 6u:
					text = "446573657269616C697A6174696F6E4576656E7448616E646C";
					num = (int)(num2 * 1749570716) ^ -517164705;
					continue;
				case 5u:
					num = ((int)num2 * -1979121146) ^ -817538447;
					continue;
				case 4u:
					num = (int)((num2 * 1887638417) ^ 0x36CFCBB0);
					continue;
				case 3u:
					result = text;
					num = -1654430364;
					continue;
				case 2u:
					text = "794664687358375471";
					num = ((int)num2 * -1787511806) ^ 0x65D64EF0;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (BaseStream == 0)
					{
						num3 = 1576136562;
						num4 = 1576136562;
					}
					else
					{
						num3 = 1039382148;
						num4 = 1039382148;
					}
					num = num3 ^ ((int)num2 * -1873884978);
					continue;
				}
				case 0u:
					num = (int)(num2 * 694751925) ^ -2030700325;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = 990354298;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x40DCD2AEu) % 5u)
				{
				case 4u:
					num3 = 0;
					goto IL_0004;
				case 3u:
					num = (int)((num2 * 598931771) ^ 0x3B33568C);
					continue;
				case 2u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -288976127) ^ -154955933;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = 600376837;
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
		string text = " ";
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		string result = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = -128372181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACEA3D56u) % 12u)
				{
				case 11u:
					num = (int)((num2 * 939480308) ^ 0x1AB58A06);
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -969236547;
						num8 = -969236547;
					}
					else
					{
						num7 = -848534825;
						num8 = -848534825;
					}
					num = num7 ^ (int)(num2 * 902296185);
					continue;
				}
				case 9u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 871875311;
						num6 = 871875311;
					}
					else
					{
						num5 = 146451872;
						num6 = 146451872;
					}
					num = num5 ^ (int)(num2 * 957851921);
					continue;
				}
				case 8u:
					num3++;
					num = -1357814490;
					continue;
				case 7u:
					result = text;
					num = (int)((num2 * 217764969) ^ 0x2440AB53);
					continue;
				case 5u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -190142502;
					continue;
				case 4u:
					flag2 = num3 < PlanningCards.Length;
					num = -1593949381;
					continue;
				case 3u:
					num = ((int)num2 * -1403485762) ^ 0x718DF324;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 1928787469) ^ 0x4CD64A10);
					continue;
				case 0u:
					num4 = PlanningCards[num3];
					flag = num4 == 0;
					num = -350572668;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = -891041221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB932F0BCu) % 3u)
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
				num = (int)((num2 * 437208055) ^ 0x6D987DB1);
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		bool flag = default(bool);
		int count = default(int);
		while (true)
		{
			int num = 799372273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x257BB1D2u) % 10u)
				{
				case 9u:
					array[num3] = json[num3].AsInt;
					num = 1094805524;
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -447127474) ^ 0x26370ACE;
					continue;
				case 6u:
					result = array;
					num = ((int)num2 * -1975934684) ^ -1542308881;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1338199794;
						num5 = -1338199794;
					}
					else
					{
						num4 = -713791541;
						num5 = -713791541;
					}
					num = num4 ^ ((int)num2 * -1571716720);
					continue;
				}
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1147994432) ^ -1307516838;
					continue;
				case 2u:
					flag = num3 < count;
					num = 1953831650;
					continue;
				case 1u:
					count = json.Count;
					num = ((int)num2 * -437695511) ^ 0x5A64FF1B;
					continue;
				case 0u:
					array = new int[count];
					num = (int)((num2 * 402052046) ^ 0x404777);
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

	public override string ToString()
	{
		return Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
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
