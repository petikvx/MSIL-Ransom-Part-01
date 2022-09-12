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
			int[] planningCards = PlanningCards;
			bool flag = default(bool);
			int num6 = default(int);
			int num4 = default(int);
			int result = default(int);
			while (true)
			{
				int num2 = 1105796701;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x7DA8F0D6u) % 13u)
					{
					case 12u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = -1419026061;
							num8 = -1419026061;
						}
						else
						{
							num7 = -1110930464;
							num8 = -1110930464;
						}
						num2 = num7 ^ (int)(num3 * 1370019965);
						continue;
					}
					case 10u:
						flag = num6 > 0;
						num2 = (int)((num3 * 341139249) ^ 0x13C98BD8);
						continue;
					case 9u:
						num2 = (int)(num3 * 433952808) ^ -614671224;
						continue;
					case 8u:
						num4++;
						num2 = (int)(num3 * 529062260) ^ -195549752;
						continue;
					case 7u:
						num6 = planningCards[num4];
						num2 = 1579721663;
						continue;
					case 6u:
						num++;
						num2 = (int)((num3 * 1110833674) ^ 0xB029DCA);
						continue;
					case 5u:
					{
						int num5;
						if (num4 >= planningCards.Length)
						{
							num2 = 351201100;
							num5 = 351201100;
						}
						else
						{
							num2 = 1578881688;
							num5 = 1578881688;
						}
						continue;
					}
					case 3u:
						num2 = ((int)num3 * -623581869) ^ -1963109171;
						continue;
					case 2u:
						num2 = 1335670482;
						continue;
					case 1u:
						num4 = 0;
						num2 = (int)(num3 * 723896276) ^ -1155220960;
						continue;
					case 0u:
						result = num;
						num2 = ((int)num3 * -1680046602) ^ 0x62EF6C91;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string result = default(string);
		string text = default(string);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 2144177098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7AAB3FAFu) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1755914313) ^ 0x43C64101;
					continue;
				case 10u:
					result = text;
					num = 579808219;
					continue;
				case 9u:
					num = (int)((num2 * 307149351) ^ 0x4ADBB2E);
					continue;
				case 7u:
					text = "774834796E66";
					num = ((int)num2 * -1547982894) ^ -2075075524;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1752570325;
						num6 = -1752570325;
					}
					else
					{
						num5 = -262153818;
						num6 = -262153818;
					}
					num = num5 ^ ((int)num2 * -41502634);
					continue;
				}
				case 4u:
					num = (int)((num2 * 857879234) ^ 0x3D333AF5);
					continue;
				case 3u:
					flag = BaseStream == 1;
					num = 454705627;
					continue;
				case 2u:
					text = "417373656D626C7944656C61795369676E41747472696275";
					num = ((int)num2 * -2068655577) ^ -1375951731;
					continue;
				case 1u:
					text = null;
					flag2 = BaseStream == 0;
					num = (int)((num2 * 1951001533) ^ 0x376820DB);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -369559116;
						num4 = -369559116;
					}
					else
					{
						num3 = -1525501515;
						num4 = -1525501515;
					}
					num = num3 ^ ((int)num2 * -1615520582);
					continue;
				}
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
			int num = 1446335786;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x376AFCBCu) % 5u)
				{
				case 4u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)(num2 * 973936733) ^ -1393179345;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 0u:
					num = ((int)num2 * -253446650) ^ -1894060871;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = 2039201194;
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
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = 1869695601;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66AC1440u) % 12u)
				{
				case 11u:
					num3++;
					num = 2124399089;
					continue;
				case 9u:
					flag = num3 < PlanningCards.Length;
					num = 905721507;
					continue;
				case 8u:
					num = ((int)num2 * -2144700592) ^ -2127681066;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -985771362;
						num8 = -985771362;
					}
					else
					{
						num7 = -490759481;
						num8 = -490759481;
					}
					num = num7 ^ ((int)num2 * -509405016);
					continue;
				}
				case 6u:
					result = text;
					num = (int)((num2 * 1949185331) ^ 0x12907262);
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
					num = 2035208291;
					continue;
				case 3u:
					num4 = PlanningCards[num3];
					num = 391128146;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (num4 != 0)
					{
						num5 = 1021291047;
						num6 = 1021291047;
					}
					else
					{
						num5 = 1425925014;
						num6 = 1425925014;
					}
					num = num5 ^ ((int)num2 * -2023183197);
					continue;
				}
				case 1u:
					text = " ";
					num3 = 0;
					num = (int)(num2 * 114251138) ^ -1395599341;
					continue;
				case 0u:
					num = ((int)num2 * -1469990620) ^ 0x2E5396E3;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
		while (true)
		{
			int num = 1109737590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37C32B5Du) % 3u)
				{
				case 2u:
					goto IL_004a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_004a:
				num = ((int)num2 * -559336308) ^ 0x1287DB70;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		int count = default(int);
		int[] result = default(int[]);
		int[] array = default(int[]);
		while (true)
		{
			int num = -1394822393;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x828607D7u) % 10u)
				{
				case 9u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -1172547710;
						num4 = -1172547710;
					}
					else
					{
						num = -116317528;
						num4 = -116317528;
					}
					continue;
				}
				case 8u:
					num3 = 0;
					num = ((int)num2 * -710882016) ^ -1242541503;
					continue;
				case 7u:
					num = ((int)num2 * -933381376) ^ 0x7A4C5FD;
					continue;
				case 5u:
					result = array;
					num = ((int)num2 * -1807570161) ^ -1321134465;
					continue;
				case 4u:
					count = json.Count;
					num = (int)(num2 * 345481108) ^ -326532098;
					continue;
				case 3u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -2092013620;
					continue;
				case 2u:
					num = (int)((num2 * 1032838502) ^ 0x398DEC08);
					continue;
				case 1u:
					array = new int[count];
					num = ((int)num2 * -1164365910) ^ -454531363;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 868538472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7500F741u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 2013026849) ^ -413211646;
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -394607132) ^ -236521214;
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
