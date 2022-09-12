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
			int[] planningCards = default(int[]);
			int result = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = -1392764674;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xA7A166D0u) % 12u)
					{
					case 11u:
						num++;
						num2 = (int)(num3 * 909664197) ^ -82529533;
						continue;
					case 10u:
						planningCards = PlanningCards;
						num2 = ((int)num3 * -219294579) ^ -505820715;
						continue;
					case 8u:
						result = num;
						num2 = (int)(num3 * 1682332026) ^ -578701794;
						continue;
					case 7u:
						num4 = 0;
						num2 = (int)(num3 * 719402114) ^ -1414256073;
						continue;
					case 6u:
						num2 = ((int)num3 * -528755389) ^ 0x2B7B5470;
						continue;
					case 5u:
						num2 = ((int)num3 * -323139644) ^ 0x22FC3FA7;
						continue;
					case 4u:
						num4++;
						num2 = -1392070205;
						continue;
					case 3u:
					{
						int num7;
						if (num4 >= planningCards.Length)
						{
							num2 = -1049519444;
							num7 = -1049519444;
						}
						else
						{
							num2 = -29848047;
							num7 = -29848047;
						}
						continue;
					}
					case 2u:
						num2 = (int)(num3 * 1062863733) ^ -1053389881;
						continue;
					case 1u:
					{
						int num5 = planningCards[num4];
						int num6;
						if (num5 > 0)
						{
							num2 = -141311025;
							num6 = -141311025;
						}
						else
						{
							num2 = -804052264;
							num6 = -804052264;
						}
						continue;
					}
					case 0u:
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
			int num = 1718280443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47ACFB99u) % 9u)
				{
				case 7u:
				{
					int num5;
					if (BaseStream != 1)
					{
						num = 920363794;
						num5 = 920363794;
					}
					else
					{
						num = 265203676;
						num5 = 265203676;
					}
					continue;
				}
				case 6u:
					result = text;
					num = 418033593;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -1210858901;
						num4 = -1210858901;
					}
					else
					{
						num3 = -995394524;
						num4 = -995394524;
					}
					num = num3 ^ ((int)num2 * -1548960179);
					continue;
				}
				case 4u:
					text = "43616C6C436F6E7465";
					num = (int)((num2 * 1088922142) ^ 0x7C435AC7);
					continue;
				case 2u:
					text = "633273346A";
					num = ((int)num2 * -881322387) ^ 0x31737D4A;
					continue;
				case 1u:
					num = ((int)num2 * -1524878739) ^ -840726568;
					continue;
				case 0u:
					num = (int)((num2 * 47309315) ^ 0x31D2C936);
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -1863240457;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFEF0D94Eu) % 4u)
				{
				case 3u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)((num2 * 1212506617) ^ 0x5B4CAEC0);
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
					num = -835785328;
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
			int num = 420930903;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2136ABF1u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1016563238) ^ -1561406540;
					continue;
				case 1u:
					num = ((int)num2 * -2104473328) ^ 0x64703C26;
					continue;
				default:
					return;
				case 0u:
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
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -818150509;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC37E40D6u) % 13u)
				{
				case 12u:
					result = text;
					num = (int)(num2 * 1883638286) ^ -1084164187;
					continue;
				case 11u:
					text = " ";
					num = ((int)num2 * -1157387682) ^ 0x2AFB0BC1;
					continue;
				case 10u:
				{
					int num7;
					if (num3 >= PlanningCards.Length)
					{
						num = -1598300036;
						num7 = -1598300036;
					}
					else
					{
						num = -1741444490;
						num7 = -1741444490;
					}
					continue;
				}
				case 9u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -817280971;
					continue;
				case 8u:
					num3++;
					num = -1575216192;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1540622088;
						num6 = -1540622088;
					}
					else
					{
						num5 = -648562090;
						num6 = -648562090;
					}
					num = num5 ^ (int)(num2 * 2088429804);
					continue;
				}
				case 6u:
					num3 = 0;
					num = (int)(num2 * 1993002839) ^ -1344305488;
					continue;
				case 5u:
					flag = num4 == 0;
					num = (int)((num2 * 714719564) ^ 0x4885DF7D);
					continue;
				case 3u:
					num = ((int)num2 * -58542071) ^ 0x41C5963F;
					continue;
				case 2u:
					num = (int)(num2 * 749799978) ^ -1990361782;
					continue;
				case 1u:
					num4 = PlanningCards[num3];
					num = -1202527983;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 1563870246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6DE41027u) % 4u)
				{
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = (int)((num2 * 966674368) ^ 0x3E1ECDAB);
					continue;
				case 0u:
					num = ((int)num2 * -1149511610) ^ -753827296;
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
		int count = default(int);
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -1013739606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF72E8BA8u) % 9u)
				{
				case 7u:
					count = json.Count;
					array = new int[count];
					num3 = 0;
					num = (int)((num2 * 390719430) ^ 0x15ECC7CF);
					continue;
				case 6u:
					array[num3] = json[num3].AsInt;
					num = -821373609;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -1995740865;
						num4 = -1995740865;
					}
					else
					{
						num = -1399147131;
						num4 = -1399147131;
					}
					continue;
				}
				case 3u:
					num3++;
					num = ((int)num2 * -952723025) ^ -1422056496;
					continue;
				case 2u:
					num = ((int)num2 * -491777925) ^ -131646104;
					continue;
				case 1u:
					num = (int)(num2 * 489839265) ^ -851990488;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -692191108) ^ 0x291EC81D;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -2013091831;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE92951ACu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1333333477) ^ 0x2C6E8BD1);
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1073276155) ^ -969926346;
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
