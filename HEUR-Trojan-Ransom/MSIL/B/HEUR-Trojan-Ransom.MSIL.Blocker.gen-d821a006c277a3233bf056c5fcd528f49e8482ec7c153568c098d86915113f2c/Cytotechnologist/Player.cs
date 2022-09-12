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
			int result = default(int);
			int[] planningCards = default(int[]);
			int num5 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = 501135675;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x77352439u) % 15u)
					{
					case 14u:
						num++;
						num2 = ((int)num3 * -2121267376) ^ -1447276626;
						continue;
					case 13u:
						num2 = (int)((num3 * 769660167) ^ 0x6C62CA68);
						continue;
					case 11u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = 1867290768;
							num8 = 1867290768;
						}
						else
						{
							num7 = 1790238461;
							num8 = 1790238461;
						}
						num2 = num7 ^ (int)(num3 * 1107695322);
						continue;
					}
					case 10u:
						num2 = ((int)num3 * -693553972) ^ -2140544583;
						continue;
					case 9u:
						num2 = 1331157547;
						continue;
					case 8u:
						result = num;
						num2 = (int)(num3 * 1879372899) ^ -1828810912;
						continue;
					case 7u:
						planningCards = PlanningCards;
						num5 = 0;
						num2 = ((int)num3 * -2139025555) ^ 0x7274E1A7;
						continue;
					case 6u:
						num5++;
						num2 = ((int)num3 * -2067633845) ^ -1358817842;
						continue;
					case 5u:
						num2 = (int)((num3 * 303139483) ^ 0x6780C9F9);
						continue;
					case 4u:
					{
						int num6;
						if (num5 < planningCards.Length)
						{
							num2 = 1912039595;
							num6 = 1912039595;
						}
						else
						{
							num2 = 829089813;
							num6 = 829089813;
						}
						continue;
					}
					case 3u:
						num2 = ((int)num3 * -899267824) ^ 0x2D7259BC;
						continue;
					case 2u:
						num4 = planningCards[num5];
						num2 = 75769442;
						continue;
					case 1u:
						flag = num4 > 0;
						num2 = ((int)num3 * -637782733) ^ 0x5872139E;
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
		bool flag2 = default(bool);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1242286786;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37A2BC96u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -448631255) ^ 0x4AF09F77;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1131342226;
						num6 = 1131342226;
					}
					else
					{
						num5 = 793710528;
						num6 = 793710528;
					}
					num = num5 ^ (int)(num2 * 1431217040);
					continue;
				}
				case 9u:
					flag2 = BaseStream == 1;
					num = 1016592592;
					continue;
				case 8u:
					num = (int)((num2 * 1640914916) ^ 0x36997CDD);
					continue;
				case 6u:
					text = "58353039436572746966696361";
					num = (int)(num2 * 623823095) ^ -934898458;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1332408827;
						num4 = 1332408827;
					}
					else
					{
						num3 = 279100989;
						num4 = 279100989;
					}
					num = num3 ^ ((int)num2 * -91316842);
					continue;
				}
				case 4u:
					text = null;
					flag = BaseStream == 0;
					num = ((int)num2 * -967805027) ^ -465028593;
					continue;
				case 3u:
					text = "7254385133624663";
					num = ((int)num2 * -818077106) ^ 0x2B2C011A;
					continue;
				case 2u:
					result = text;
					num = 409888887;
					continue;
				case 1u:
					num = ((int)num2 * -561931488) ^ 0x1B70E9A2;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = 1294236259;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x56CD3489u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -566694742) ^ -1283191147;
					continue;
				case 2u:
					if (PlanningCards.Length == 0)
					{
						num = (int)(num2 * 1803050269) ^ -1303786874;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0032;
				case 1u:
					num3 = 0;
					goto IL_0032;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0032:
					result = num3;
					num = 1641864693;
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
		string text = default(string);
		int num5 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -454876229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9514D06u) % 13u)
				{
				case 12u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num5],
						"x",
						num6.ToString(),
						" "
					});
					num = -1295304966;
					continue;
				case 11u:
					num5++;
					num = -1975759898;
					continue;
				case 10u:
					num = (int)(num2 * 737003060) ^ -637124853;
					continue;
				case 9u:
					flag = num5 < PlanningCards.Length;
					num = -989416199;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (num6 != 0)
					{
						num7 = -1552957502;
						num8 = -1552957502;
					}
					else
					{
						num7 = -1232929411;
						num8 = -1232929411;
					}
					num = num7 ^ ((int)num2 * -1973745300);
					continue;
				}
				case 7u:
					num = ((int)num2 * -486843156) ^ -683475657;
					continue;
				case 6u:
					num6 = PlanningCards[num5];
					num = -1965426181;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -1405061852) ^ 0x15835F7F;
					continue;
				case 3u:
					text = " ";
					num5 = 0;
					num = (int)((num2 * 438949917) ^ 0x6CBFA558);
					continue;
				case 1u:
					num = ((int)num2 * -22538588) ^ 0x422522DA;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 723299595;
						num4 = 723299595;
					}
					else
					{
						num3 = 906693920;
						num4 = 906693920;
					}
					num = num3 ^ (int)(num2 * 993723163);
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 1172743141;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x251FE3ADu) % 3u)
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
				num = ((int)num2 * -1136278702) ^ 0x3C89DE49;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] array = default(int[]);
		int num3 = default(int);
		int count = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -1248162300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9159241u) % 9u)
				{
				case 8u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -862249577;
					continue;
				case 7u:
					count = json.Count;
					num = (int)((num2 * 496382261) ^ 0x1C5BF862);
					continue;
				case 6u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -212042956;
						num4 = -212042956;
					}
					else
					{
						num = -1047696667;
						num4 = -1047696667;
					}
					continue;
				}
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1753655677) ^ 0x36D011E;
					continue;
				case 4u:
					result = array;
					num = ((int)num2 * -1179151316) ^ 0x1EB35F9B;
					continue;
				case 2u:
					array = new int[count];
					num = (int)((num2 * 549384766) ^ 0x212E9092);
					continue;
				case 1u:
					num = (int)((num2 * 789469703) ^ 0x33DAB7F9);
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

	public override string ToString()
	{
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = -1471304019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBB28698u) % 3u)
				{
				case 1u:
					goto IL_0024;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0024:
				num = ((int)num2 * -33626521) ^ 0x15B2BBD;
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
