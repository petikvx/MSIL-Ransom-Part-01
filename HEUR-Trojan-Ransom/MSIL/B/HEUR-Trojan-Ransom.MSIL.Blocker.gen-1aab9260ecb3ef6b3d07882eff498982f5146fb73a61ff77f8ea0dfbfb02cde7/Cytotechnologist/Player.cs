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
			int num4 = default(int);
			int num6 = default(int);
			int[] planningCards = default(int[]);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num2 = -1035224973;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xA9ACC07Bu) % 15u)
					{
					case 14u:
						num++;
						num2 = ((int)num3 * -455057530) ^ -1286625456;
						continue;
					case 13u:
						num4++;
						num2 = ((int)num3 * -1250371074) ^ -1233878338;
						continue;
					case 12u:
						num2 = -900449670;
						continue;
					case 11u:
						num4 = 0;
						num2 = ((int)num3 * -208687069) ^ -1595907656;
						continue;
					case 10u:
						num2 = (int)((num3 * 177618390) ^ 0x2ED0EFA4);
						continue;
					case 9u:
						num2 = (int)((num3 * 485796400) ^ 0x396FF006);
						continue;
					case 8u:
						num6 = planningCards[num4];
						num2 = -1221341545;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (flag)
						{
							num7 = -1638962482;
							num8 = -1638962482;
						}
						else
						{
							num7 = -661033362;
							num8 = -661033362;
						}
						num2 = num7 ^ ((int)num3 * -109073978);
						continue;
					}
					case 4u:
						num2 = ((int)num3 * -1738498939) ^ 0x5E45F9B;
						continue;
					case 3u:
						result = num;
						num2 = ((int)num3 * -535883486) ^ -1770108428;
						continue;
					case 2u:
						flag = num6 > 0;
						num2 = (int)(num3 * 1219957145) ^ -1465359065;
						continue;
					case 1u:
						planningCards = PlanningCards;
						num2 = ((int)num3 * -23840109) ^ 0x498FB184;
						continue;
					case 0u:
					{
						int num5;
						if (num4 >= planningCards.Length)
						{
							num2 = -2002615188;
							num5 = -2002615188;
						}
						else
						{
							num2 = -866297492;
							num5 = -866297492;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -2026515660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8BC49AEDu) % 12u)
				{
				case 10u:
					num = ((int)num2 * -1929069425) ^ 0x2FFDC508;
					continue;
				case 9u:
					text = null;
					flag = BaseStream == 0;
					num = ((int)num2 * -1725780714) ^ 0x1DEC49EB;
					continue;
				case 8u:
					flag2 = BaseStream == 1;
					num = -1987426369;
					continue;
				case 7u:
					result = text;
					num = -1834217560;
					continue;
				case 6u:
					num = (int)((num2 * 845050373) ^ 0x29E47072);
					continue;
				case 4u:
					num = ((int)num2 * -1567919021) ^ -1472225242;
					continue;
				case 3u:
					text = "45617374417369616E4C756E69736F6C617243616C656E64";
					num = (int)((num2 * 733190687) ^ 0x1982F8);
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -819774956;
						num6 = -819774956;
					}
					else
					{
						num5 = -1052296707;
						num6 = -1052296707;
					}
					num = num5 ^ ((int)num2 * -1918623561);
					continue;
				}
				case 1u:
					text = "376F4C6958";
					num = ((int)num2 * -2031400749) ^ 0x41538CD1;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1649579839;
						num4 = -1649579839;
					}
					else
					{
						num3 = -266597093;
						num4 = -266597093;
					}
					num = num3 ^ (int)(num2 * 378545795);
					continue;
				}
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
		int result = default(int);
		while (true)
		{
			int num = -1224511641;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC7EBBB0Cu) % 5u)
				{
				case 4u:
					num3 = 0;
					goto IL_0004;
				case 3u:
					if (PlanningCards.Length == 0)
					{
						num = (int)((num2 * 1906667467) ^ 0x1C4753BF);
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 2u:
					num = ((int)num2 * -1652542929) ^ -1232641368;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = -282717225;
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
			int num = -2090318056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95DE81D6u) % 3u)
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
				num = (int)(num2 * 1890025662) ^ -1225990727;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -258545745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95ECB4AAu) % 15u)
				{
				case 14u:
					result = text;
					num = (int)((num2 * 139262214) ^ 0x28ED756A);
					continue;
				case 13u:
					num = (int)((num2 * 1304077537) ^ 0x2AE07DE9);
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -118362040;
						num7 = -118362040;
					}
					else
					{
						num6 = -2019001422;
						num7 = -2019001422;
					}
					num = num6 ^ (int)(num2 * 1563206317);
					continue;
				}
				case 11u:
					text = " ";
					num = ((int)num2 * -1468296856) ^ 0x2C966323;
					continue;
				case 10u:
					num3 = 0;
					num = ((int)num2 * -1262383624) ^ -775334892;
					continue;
				case 9u:
					num5 = PlanningCards[num3];
					num = ((int)num2 * -2142666916) ^ -597235158;
					continue;
				case 8u:
					num = ((int)num2 * -1218141110) ^ -1892551446;
					continue;
				case 6u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num5.ToString(),
						" "
					});
					num = -232111156;
					continue;
				case 5u:
					num3++;
					num = -247123242;
					continue;
				case 4u:
					flag = num5 == 0;
					num = ((int)num2 * -255787311) ^ -886206465;
					continue;
				case 3u:
					num = -1709268155;
					continue;
				case 2u:
				{
					int num4;
					if (num3 < PlanningCards.Length)
					{
						num = -481541447;
						num4 = -481541447;
					}
					else
					{
						num = -2020472786;
						num4 = -2020472786;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1222352614) ^ 0x76A298E0;
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
		Player result = new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
		while (true)
		{
			int num = -1799714793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3497A76u) % 3u)
				{
				case 1u:
					goto IL_004a;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_004a:
				num = (int)(num2 * 2114679815) ^ -1656152496;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = default(int);
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		bool flag = default(bool);
		while (true)
		{
			int num = 1591154413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7198ABu) % 8u)
				{
				case 6u:
					count = json.Count;
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -1836764986) ^ 0x45979FA4;
					continue;
				case 5u:
					array[num3] = json[num3].AsInt;
					num = 473333306;
					continue;
				case 4u:
					result = array;
					num = (int)((num2 * 698910006) ^ 0xE167DC);
					continue;
				case 3u:
					flag = num3 < count;
					num = 358920345;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2123119412;
						num5 = -2123119412;
					}
					else
					{
						num4 = -482256267;
						num5 = -482256267;
					}
					num = num4 ^ ((int)num2 * -419951935);
					continue;
				}
				case 1u:
					num3++;
					num = ((int)num2 * -259548031) ^ -1753727343;
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
		string result = default(string);
		while (true)
		{
			int num = 340448894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBDCE1Cu) % 4u)
				{
				case 2u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -424326284) ^ -1559266495;
					continue;
				case 1u:
					num = ((int)num2 * -743394462) ^ 0x1E1BB2AA;
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
