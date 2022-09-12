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
			int num7 = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num2 = 397833746;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x1CF3B4F5u) % 14u)
					{
					case 13u:
						num7 = planningCards[num4];
						num2 = 371557595;
						continue;
					case 11u:
						num2 = (int)((num3 * 796498379) ^ 0x35DEF95A);
						continue;
					case 10u:
						flag = num7 > 0;
						num2 = (int)(num3 * 1435262453) ^ -1610024206;
						continue;
					case 9u:
						num++;
						num2 = (int)(num3 * 2140026457) ^ -829089204;
						continue;
					case 8u:
						num2 = (int)((num3 * 565994100) ^ 0x43A9350F);
						continue;
					case 6u:
					{
						int num8;
						if (num4 < planningCards.Length)
						{
							num2 = 1262276154;
							num8 = 1262276154;
						}
						else
						{
							num2 = 1631208433;
							num8 = 1631208433;
						}
						continue;
					}
					case 5u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -992617520;
							num6 = -992617520;
						}
						else
						{
							num5 = -1388376783;
							num6 = -1388376783;
						}
						num2 = num5 ^ (int)(num3 * 1419304272);
						continue;
					}
					case 4u:
						num2 = ((int)num3 * -726416186) ^ 0x3770A953;
						continue;
					case 3u:
						num4 = 0;
						num2 = (int)(num3 * 1416225783) ^ -1211536852;
						continue;
					case 2u:
						num4++;
						num2 = 603607191;
						continue;
					case 1u:
						planningCards = PlanningCards;
						num2 = (int)((num3 * 350725952) ^ 0x365AFE84);
						continue;
					case 0u:
						result = num;
						num2 = ((int)num3 * -1073204927) ^ 0x41B636;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 463085591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F9B82EFu) % 11u)
				{
				case 10u:
					result = text;
					num = 1922547150;
					continue;
				case 9u:
					flag = BaseStream == 1;
					num = 1393114654;
					continue;
				case 8u:
					num = (int)((num2 * 7870659) ^ 0x479FA2AA);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (BaseStream != 0)
					{
						num5 = -196889290;
						num6 = -196889290;
					}
					else
					{
						num5 = -1428568032;
						num6 = -1428568032;
					}
					num = num5 ^ (int)(num2 * 1678440766);
					continue;
				}
				case 4u:
					text = null;
					num = (int)((num2 * 1398076458) ^ 0x8DF7C78);
					continue;
				case 3u:
					text = "52344E5461";
					num = (int)(num2 * 1685616933) ^ -1897029569;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 420611382;
						num4 = 420611382;
					}
					else
					{
						num3 = 1995130413;
						num4 = 1995130413;
					}
					num = num3 ^ ((int)num2 * -991478958);
					continue;
				}
				case 1u:
					num = (int)((num2 * 82672159) ^ 0x4C679566);
					continue;
				case 0u:
					text = "4E756C6C54797065496E";
					num = ((int)num2 * -2117190567) ^ 0x514B663D;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -1630681228;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9A22F51Eu) % 5u)
				{
				case 4u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -589065322) ^ -1419431535;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 3u:
					num3 = 0;
					goto IL_0023;
				case 0u:
					num = (int)((num2 * 919768893) ^ 0x7E35B7DF);
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					result = num3;
					num = -295751991;
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
			int num = 1253487257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CE981D7u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1239250929) ^ -1821424032;
					continue;
				case 1u:
					num = (int)(num2 * 934542317) ^ -1383763558;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public string PlanningCardsToString()
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1639603562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE12F92B0u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -658940224) ^ 0x392250D1;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 155693224;
						num8 = 155693224;
					}
					else
					{
						num7 = 1848523501;
						num8 = 1848523501;
					}
					num = num7 ^ ((int)num2 * -486754410);
					continue;
				}
				case 12u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1714803024;
						num6 = 1714803024;
					}
					else
					{
						num5 = 1361474677;
						num6 = 1361474677;
					}
					num = num5 ^ ((int)num2 * -1966267351);
					continue;
				}
				case 11u:
					num3++;
					num = -1904947822;
					continue;
				case 10u:
					num3 = 0;
					num = ((int)num2 * -932782657) ^ 0x6D6937DC;
					continue;
				case 9u:
					num4 = PlanningCards[num3];
					flag2 = num4 == 0;
					num = (int)((num2 * 997441251) ^ 0x414E1CF2);
					continue;
				case 8u:
					num = (int)((num2 * 762924355) ^ 0x2A804C0D);
					continue;
				case 5u:
					num = ((int)num2 * -506419172) ^ -689605318;
					continue;
				case 4u:
					text = " ";
					num = (int)((num2 * 460389206) ^ 0x6E04E946);
					continue;
				case 3u:
					num = -2077174640;
					continue;
				case 2u:
					result = text;
					num = ((int)num2 * -277766472) ^ 0x38EC6D34;
					continue;
				case 1u:
					flag = num3 < PlanningCards.Length;
					num = -2091083424;
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
					num = -1927957008;
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
			int num = 1567520021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68E04409u) % 3u)
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
				num = (int)((num2 * 1343827495) ^ 0x62704301);
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		int[] array = default(int[]);
		int count = default(int);
		int[] result = default(int[]);
		bool flag = default(bool);
		while (true)
		{
			int num = 453093981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x555599D1u) % 12u)
				{
				case 11u:
					num3 = 0;
					num = ((int)num2 * -1578728882) ^ -919680755;
					continue;
				case 10u:
					array = new int[count];
					num = ((int)num2 * -1415675806) ^ 0xB841826;
					continue;
				case 9u:
					result = array;
					num = (int)(num2 * 1849062024) ^ -669219817;
					continue;
				case 8u:
					count = json.Count;
					num = (int)((num2 * 2002699064) ^ 0x79A02143);
					continue;
				case 6u:
					num = ((int)num2 * -1481714064) ^ 0x5845E325;
					continue;
				case 5u:
					flag = num3 < count;
					num = 1559855576;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -887771747) ^ 0x576389B7;
					continue;
				case 2u:
					num = ((int)num2 * -1095810163) ^ -230624446;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -233312178;
						num5 = -233312178;
					}
					else
					{
						num4 = -793657085;
						num5 = -793657085;
					}
					num = num4 ^ (int)(num2 * 1318729430);
					continue;
				}
				case 0u:
					array[num3] = json[num3].AsInt;
					num = 1111948918;
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
		string result = default(string);
		while (true)
		{
			int num = 660291162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C4B5F7Fu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -252431239) ^ -667479252;
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 599735333) ^ -1512990103;
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

	static string smethod_0(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
