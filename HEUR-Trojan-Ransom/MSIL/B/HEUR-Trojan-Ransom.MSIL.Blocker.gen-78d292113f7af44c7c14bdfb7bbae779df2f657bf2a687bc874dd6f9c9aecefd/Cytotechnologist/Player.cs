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
			int num3 = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			bool flag = default(bool);
			int num5 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -519288107;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF20C62CCu) % 13u)
					{
					case 12u:
					{
						int num8;
						if (num3 < planningCards.Length)
						{
							num = -248748947;
							num8 = -248748947;
						}
						else
						{
							num = -1071347912;
							num8 = -1071347912;
						}
						continue;
					}
					case 11u:
						num3 = 0;
						num = (int)((num2 * 1429949992) ^ 0x4172657B);
						continue;
					case 9u:
						num4++;
						num = ((int)num2 * -1929254185) ^ -941284919;
						continue;
					case 8u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = 838087835;
							num7 = 838087835;
						}
						else
						{
							num6 = 1915811288;
							num7 = 1915811288;
						}
						num = num6 ^ ((int)num2 * -1801864928);
						continue;
					}
					case 6u:
						flag = num5 > 0;
						num = ((int)num2 * -1941448076) ^ 0x32A1E2A4;
						continue;
					case 5u:
						result = num4;
						num = ((int)num2 * -441514038) ^ -1616623344;
						continue;
					case 4u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1244795448) ^ -419742496;
						continue;
					case 3u:
						num = ((int)num2 * -2037853645) ^ 0x6DD66201;
						continue;
					case 2u:
						num5 = planningCards[num3];
						num = -1456369389;
						continue;
					case 1u:
						num4 = 0;
						num = ((int)num2 * -1596367403) ^ -1965772021;
						continue;
					case 0u:
						num3++;
						num = -246125868;
						continue;
					case 10u:
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
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 2037284782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x597A82EAu) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 862357629;
						num6 = 862357629;
					}
					else
					{
						num5 = 101463074;
						num6 = 101463074;
					}
					num = num5 ^ ((int)num2 * -1160828822);
					continue;
				}
				case 10u:
					result = text;
					num = 560395982;
					continue;
				case 8u:
					num = (int)((num2 * 2059944963) ^ 0x43600C5D);
					continue;
				case 7u:
					text = "4944696374696F6E61";
					num = (int)(num2 * 2117165079) ^ -638324625;
					continue;
				case 6u:
					flag = BaseStream == 1;
					num = 903252313;
					continue;
				case 5u:
					num = (int)(num2 * 695972038) ^ -730478411;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (BaseStream == 0)
					{
						num3 = -1121825743;
						num4 = -1121825743;
					}
					else
					{
						num3 = -1052988860;
						num4 = -1052988860;
					}
					num = num3 ^ ((int)num2 * -1453789062);
					continue;
				}
				case 3u:
					num = ((int)num2 * -2006257046) ^ 0x5FCC86DA;
					continue;
				case 1u:
					text = "6A4151504874";
					num = (int)((num2 * 2111580471) ^ 0x6F639A73);
					continue;
				case 0u:
					num = ((int)num2 * -752368059) ^ -624883609;
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
			int num = -1475880246;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF8080C6Fu) % 5u)
				{
				case 4u:
					if (PlanningCards.Length == 0)
					{
						num = (int)((num2 * 2030167762) ^ 0x72DEEE91);
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 2u:
					num = (int)((num2 * 1920704773) ^ 0xEADB2B7);
					continue;
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
					num = -885384129;
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
			int num = 1736326777;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x650533C4u) % 4u)
				{
				case 1u:
					num = (int)((num2 * 359077437) ^ 0x16813AF9);
					continue;
				case 0u:
					num = ((int)num2 * -734530753) ^ 0x505D2DB7;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public string PlanningCardsToString()
	{
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num = 695647828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FED7BFEu) % 14u)
				{
				case 11u:
					num = (int)(num2 * 27834406) ^ -1259481455;
					continue;
				case 10u:
					num6 = PlanningCards[num3];
					num = 91565015;
					continue;
				case 9u:
					flag = num6 == 0;
					num = ((int)num2 * -990821739) ^ 0x7AAF1235;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 2053263563;
						num8 = 2053263563;
					}
					else
					{
						num7 = 1480783324;
						num8 = 1480783324;
					}
					num = num7 ^ ((int)num2 * -1802993192);
					continue;
				}
				case 7u:
					result = text;
					num = (int)((num2 * 1542560740) ^ 0x35ED99A);
					continue;
				case 6u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num6.ToString(),
						" "
					});
					num = 521084719;
					continue;
				case 5u:
					flag2 = num3 < PlanningCards.Length;
					num = 2081456712;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1431522003;
						num5 = -1431522003;
					}
					else
					{
						num4 = -1572685086;
						num5 = -1572685086;
					}
					num = num4 ^ ((int)num2 * -2014648290);
					continue;
				}
				case 3u:
					num = ((int)num2 * -693365586) ^ -1574028934;
					continue;
				case 2u:
					text = " ";
					num3 = 0;
					num = (int)((num2 * 1288616850) ^ 0x4F40D34D);
					continue;
				case 1u:
					num = ((int)num2 * -1333109535) ^ 0x4A724A89;
					continue;
				case 0u:
					num3++;
					num = 237585435;
					continue;
				case 13u:
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
			int num = -913407657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x833525BEu) % 3u)
				{
				case 1u:
					goto IL_004a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_004a:
				num = (int)(num2 * 111973690) ^ -1802432229;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] array = default(int[]);
		int num5 = default(int);
		int[] result = default(int[]);
		bool flag = default(bool);
		int count = default(int);
		while (true)
		{
			int num = 231764940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D7941BDu) % 8u)
				{
				case 6u:
					array[num5] = json[num5].AsInt;
					num5++;
					num = 313626855;
					continue;
				case 5u:
					result = array;
					num = (int)((num2 * 1678425638) ^ 0x584DD2CC);
					continue;
				case 3u:
					num = ((int)num2 * -1741667889) ^ 0x70C8F5E2;
					continue;
				case 2u:
					flag = num5 < count;
					num = 141974629;
					continue;
				case 1u:
					count = json.Count;
					array = new int[count];
					num5 = 0;
					num = ((int)num2 * -522557859) ^ 0x681D5C5B;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1127303824;
						num4 = 1127303824;
					}
					else
					{
						num3 = 84947131;
						num4 = 84947131;
					}
					num = num3 ^ ((int)num2 * -2101115482);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 2098603897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38B5F4DEu) % 3u)
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
				result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
				num = ((int)num2 * -898198146) ^ -21522345;
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
