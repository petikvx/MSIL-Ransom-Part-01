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
			int[] planningCards = default(int[]);
			int num5 = default(int);
			int num4 = default(int);
			int num3 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -724992627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC599DDA3u) % 15u)
					{
					case 14u:
						num = ((int)num2 * -423970908) ^ -722194305;
						continue;
					case 13u:
						planningCards = PlanningCards;
						num = ((int)num2 * -847975520) ^ 0x9DFA07D;
						continue;
					case 11u:
						num = (int)((num2 * 1125055317) ^ 0x70437741);
						continue;
					case 10u:
						num = ((int)num2 * -772226044) ^ 0x67BA1BE1;
						continue;
					case 9u:
						num5 = planningCards[num4];
						num = -1870389633;
						continue;
					case 8u:
						num4++;
						num = -1832282003;
						continue;
					case 7u:
					{
						int num8;
						if (num4 < planningCards.Length)
						{
							num = -650656272;
							num8 = -650656272;
						}
						else
						{
							num = -1206811062;
							num8 = -1206811062;
						}
						continue;
					}
					case 6u:
					{
						int num6;
						int num7;
						if (num5 > 0)
						{
							num6 = -1098846204;
							num7 = -1098846204;
						}
						else
						{
							num6 = -1172727657;
							num7 = -1172727657;
						}
						num = num6 ^ (int)(num2 * 925629452);
						continue;
					}
					case 5u:
						num3++;
						num = ((int)num2 * -699880128) ^ -1055020505;
						continue;
					case 4u:
						num = (int)(num2 * 570447026) ^ -1464667281;
						continue;
					case 3u:
						num3 = 0;
						num = (int)((num2 * 844910904) ^ 0x43C2F035);
						continue;
					case 1u:
						num4 = 0;
						num = (int)((num2 * 1061821467) ^ 0x3C09E2AA);
						continue;
					case 0u:
						result = num3;
						num = ((int)num2 * -226842973) ^ -1807388132;
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
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -297988982;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CFCA3A6u) % 14u)
				{
				case 13u:
					result = text;
					num = -394645623;
					continue;
				case 12u:
					flag = BaseStream == 0;
					num = ((int)num2 * -13823783) ^ -1386876987;
					continue;
				case 11u:
					num = ((int)num2 * -708213292) ^ -1585684307;
					continue;
				case 10u:
					text = null;
					num = ((int)num2 * -885715090) ^ 0x3CD82014;
					continue;
				case 8u:
					num = (int)((num2 * 171808348) ^ 0x4A40E5CE);
					continue;
				case 7u:
					text = "496E74726F7370656374697665536F72745574696C697469";
					num = (int)(num2 * 1515137465) ^ -370091080;
					continue;
				case 6u:
					text = "666838796332";
					num = ((int)num2 * -126423793) ^ -408641399;
					continue;
				case 5u:
					num = ((int)num2 * -1886412284) ^ -1365232427;
					continue;
				case 3u:
					flag2 = BaseStream == 1;
					num = -441487076;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -818879059;
						num6 = -818879059;
					}
					else
					{
						num5 = -1555838338;
						num6 = -1555838338;
					}
					num = num5 ^ (int)(num2 * 875285402);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -272044874;
						num4 = -272044874;
					}
					else
					{
						num3 = -1173236699;
						num4 = -1173236699;
					}
					num = num3 ^ ((int)num2 * -513986462);
					continue;
				}
				case 0u:
					num = (int)(num2 * 56357147) ^ -174971469;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0034;
		IL_0033:
		num = 0;
		goto IL_0034;
		IL_0013:
		int num2 = 169273294;
		goto IL_0018;
		IL_0018:
		int result = default(int);
		switch ((uint)(num2 ^ 0x55D9DC49) % 3u)
		{
		case 0u:
			break;
		case 1u:
			goto IL_0033;
		default:
			return result;
		}
		goto IL_0013;
		IL_0034:
		result = num;
		num2 = 257981714;
		goto IL_0018;
	}

	private Player()
	{
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		bool flag2 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1117296716;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3AEFDD0u) % 12u)
				{
				case 11u:
					flag2 = num5 < PlanningCards.Length;
					num = -49733062;
					continue;
				case 10u:
					num = -1692085867;
					continue;
				case 9u:
					num6 = PlanningCards[num5];
					flag = num6 == 0;
					num = (int)((num2 * 1452979737) ^ 0x262786A5);
					continue;
				case 8u:
					num5 = 0;
					num = (int)(num2 * 1631726523) ^ -1844319965;
					continue;
				case 7u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num5],
						"x",
						num6.ToString(),
						" "
					});
					num = -1579214214;
					continue;
				case 6u:
					num5++;
					num = -1175750097;
					continue;
				case 5u:
					num = ((int)num2 * -1699553191) ^ 0x21C28BBF;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1588497098;
						num8 = 1588497098;
					}
					else
					{
						num7 = 1485074973;
						num8 = 1485074973;
					}
					num = num7 ^ (int)(num2 * 1470341172);
					continue;
				}
				case 1u:
					result = text;
					num = (int)(num2 * 547037706) ^ -54314383;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 937004925;
						num4 = 937004925;
					}
					else
					{
						num3 = 348822995;
						num4 = 348822995;
					}
					num = num3 ^ (int)(num2 * 1531864732);
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
			int num = -1380776073;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB763CC5Bu) % 3u)
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
				num = (int)((num2 * 79328425) ^ 0x7A6AEE7A);
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		bool flag = default(bool);
		int num5 = default(int);
		int count = default(int);
		int[] result = default(int[]);
		int[] array = default(int[]);
		while (true)
		{
			int num = 2091486439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34C0BB7u) % 9u)
				{
				case 8u:
					flag = num5 < count;
					num = 1645897245;
					continue;
				case 7u:
					result = array;
					num = (int)(num2 * 1882907639) ^ -1121363975;
					continue;
				case 6u:
					num = ((int)num2 * -520997513) ^ 0x6F234ECE;
					continue;
				case 5u:
					num5++;
					num = (int)(num2 * 2000153911) ^ -1533421404;
					continue;
				case 2u:
					array[num5] = json[num5].AsInt;
					num = 1911774450;
					continue;
				case 1u:
					count = json.Count;
					array = new int[count];
					num5 = 0;
					num = (int)(num2 * 1233082158) ^ -2086909288;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1625955856;
						num4 = -1625955856;
					}
					else
					{
						num3 = -313522760;
						num4 = -313522760;
					}
					num = num3 ^ ((int)num2 * -1775020144);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1921789342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FAF5665u) % 4u)
				{
				case 3u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 12738961) ^ -2004797693;
					continue;
				case 1u:
					num = ((int)num2 * -153749272) ^ -927419997;
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
