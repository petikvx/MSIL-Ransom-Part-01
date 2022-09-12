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
			int num5 = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num2 = 925831775;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x835BE18u) % 12u)
					{
					case 11u:
						num2 = (int)((num3 * 1575441300) ^ 0x59D02712);
						continue;
					case 10u:
						num5 = planningCards[num4];
						num2 = 2134117739;
						continue;
					case 9u:
					{
						int num8;
						if (num4 >= planningCards.Length)
						{
							num2 = 1893784466;
							num8 = 1893784466;
						}
						else
						{
							num2 = 409322030;
							num8 = 409322030;
						}
						continue;
					}
					case 8u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = 2047025639;
							num7 = 2047025639;
						}
						else
						{
							num6 = 1921611560;
							num7 = 1921611560;
						}
						num2 = num6 ^ ((int)num3 * -15488571);
						continue;
					}
					case 7u:
						num++;
						num2 = ((int)num3 * -1311338747) ^ 0x464746D3;
						continue;
					case 6u:
						planningCards = PlanningCards;
						num2 = ((int)num3 * -1619908934) ^ 0x30AF542D;
						continue;
					case 5u:
						num4 = 0;
						num2 = (int)(num3 * 1222973635) ^ -1208796418;
						continue;
					case 3u:
						flag = num5 > 0;
						num2 = ((int)num3 * -1904320008) ^ 0x76201EB0;
						continue;
					case 2u:
						result = num;
						num2 = ((int)num3 * -1334038819) ^ -1322571129;
						continue;
					case 0u:
						num4++;
						num2 = 831936773;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 187218801;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27E209F8u) % 12u)
				{
				case 11u:
					flag = BaseStream == 0;
					num = (int)((num2 * 1808333090) ^ 0x78BECF43);
					continue;
				case 10u:
					result = text;
					num = 706768899;
					continue;
				case 9u:
					text = null;
					num = (int)((num2 * 1310548563) ^ 0x2C5E447C);
					continue;
				case 8u:
					num = ((int)num2 * -1091984003) ^ 0x55E436AA;
					continue;
				case 7u:
				{
					int num5;
					if (BaseStream == 1)
					{
						num = 394183966;
						num5 = 394183966;
					}
					else
					{
						num = 1537677458;
						num5 = 1537677458;
					}
					continue;
				}
				case 6u:
					text = "6B7837564A67656B";
					num = ((int)num2 * -1168510088) ^ -406619344;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1908437805;
						num4 = 1908437805;
					}
					else
					{
						num3 = 1487332602;
						num4 = 1487332602;
					}
					num = num3 ^ ((int)num2 * -929782583);
					continue;
				}
				case 4u:
					text = "466F756E64446174655061747465";
					num = ((int)num2 * -895673092) ^ 0x77115F1D;
					continue;
				case 2u:
					num = (int)((num2 * 85419655) ^ 0x428E6364);
					continue;
				case 1u:
					num = (int)((num2 * 79845186) ^ 0x7F9DE758);
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
		int result = default(int);
		while (true)
		{
			int num = -1032773848;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x82738A9Du) % 4u)
				{
				case 3u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -1677185605) ^ -709325647;
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
					num = -218616199;
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
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 2007913290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6008F896u) % 15u)
				{
				case 14u:
					result = text;
					num = (int)(num2 * 1915888212) ^ -961082661;
					continue;
				case 13u:
					num = 645563338;
					continue;
				case 11u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 625823196;
					continue;
				case 10u:
					text = " ";
					num = (int)((num2 * 1913280463) ^ 0x3B107DEF);
					continue;
				case 9u:
					num4 = PlanningCards[num3];
					num = (int)((num2 * 255254160) ^ 0x5645E0AB);
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 20185347;
						num7 = 20185347;
					}
					else
					{
						num6 = 710869281;
						num7 = 710869281;
					}
					num = num6 ^ (int)(num2 * 1514560175);
					continue;
				}
				case 7u:
					num = ((int)num2 * -2002317733) ^ 0x7E058D17;
					continue;
				case 5u:
				{
					int num5;
					if (num3 < PlanningCards.Length)
					{
						num = 791607671;
						num5 = 791607671;
					}
					else
					{
						num = 1334836179;
						num5 = 1334836179;
					}
					continue;
				}
				case 4u:
					flag = num4 == 0;
					num = (int)(num2 * 1143429605) ^ -1401759681;
					continue;
				case 3u:
					num = (int)((num2 * 88112847) ^ 0x6970BCAF);
					continue;
				case 2u:
					num = ((int)num2 * -1030582782) ^ 0x30BA7443;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 1761682708) ^ -584866524;
					continue;
				case 0u:
					num3++;
					num = 7015013;
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
			int num = 929736577;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A1D70A0u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 765874938) ^ 0x505037A2);
					continue;
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = (int)((num2 * 453830047) ^ 0x453A09C);
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

	private static int[] ParsePlanningCards(JSONNode json)
	{
		bool flag = default(bool);
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		int count = default(int);
		while (true)
		{
			int num = 1946158794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79A23BF8u) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1488561958;
						num5 = -1488561958;
					}
					else
					{
						num4 = -733441992;
						num5 = -733441992;
					}
					num = num4 ^ ((int)num2 * -1051745339);
					continue;
				}
				case 5u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 329862742;
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -368115715) ^ 0x75BF7815;
					continue;
				case 1u:
					count = json.Count;
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -690787505) ^ 0x53738638;
					continue;
				case 0u:
					flag = num3 < count;
					num = 318551960;
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
			int num = -383998194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC65B17F0u) % 3u)
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
				result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
				num = (int)((num2 * 963033132) ^ 0x3341F949);
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
