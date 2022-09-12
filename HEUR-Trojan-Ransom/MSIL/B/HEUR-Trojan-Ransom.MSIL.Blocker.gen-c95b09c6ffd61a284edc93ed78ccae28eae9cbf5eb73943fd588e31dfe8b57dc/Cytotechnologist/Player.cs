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
			int num4 = default(int);
			int[] planningCards = default(int[]);
			int result = default(int);
			while (true)
			{
				int num2 = -1111563736;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x80CFB316u) % 12u)
					{
					case 10u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = 350184150;
							num8 = 350184150;
						}
						else
						{
							num7 = 718366201;
							num8 = 718366201;
						}
						num2 = num7 ^ (int)(num3 * 685282301);
						continue;
					}
					case 9u:
						num++;
						num2 = (int)(num3 * 1228489174) ^ -953550314;
						continue;
					case 8u:
						num4++;
						num2 = ((int)num3 * -2134692031) ^ -1972673287;
						continue;
					case 7u:
					{
						int num6;
						if (num4 < planningCards.Length)
						{
							num2 = -1704872073;
							num6 = -1704872073;
						}
						else
						{
							num2 = -1096610245;
							num6 = -1096610245;
						}
						continue;
					}
					case 6u:
						num2 = -2054070754;
						continue;
					case 5u:
						result = num;
						num2 = (int)((num3 * 700694577) ^ 0x92D0DCC);
						continue;
					case 4u:
						num4 = 0;
						num2 = (int)((num3 * 1421640717) ^ 0x45CB1E21);
						continue;
					case 3u:
						num2 = ((int)num3 * -1230258727) ^ -1952505214;
						continue;
					case 2u:
						planningCards = PlanningCards;
						num2 = (int)(num3 * 691325912) ^ -135277482;
						continue;
					case 1u:
					{
						int num5 = planningCards[num4];
						flag = num5 > 0;
						num2 = -1364569112;
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
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 2025706504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E94EA75u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -738428745) ^ -1104145797;
					continue;
				case 9u:
					num = (int)(num2 * 1130607140) ^ -2022752723;
					continue;
				case 8u:
					text = "4F7065726174696E6753797374";
					num = (int)((num2 * 655922723) ^ 0x542E594D);
					continue;
				case 6u:
				{
					text = null;
					int num4;
					int num5;
					if (BaseStream == 0)
					{
						num4 = 1909825255;
						num5 = 1909825255;
					}
					else
					{
						num4 = 2065261876;
						num5 = 2065261876;
					}
					num = num4 ^ ((int)num2 * -1676942425);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1358275731) ^ 0x3E1D4B4F);
					continue;
				case 3u:
					text = "7874327938";
					num = (int)(num2 * 2089678327) ^ -1856451474;
					continue;
				case 2u:
					result = text;
					num = 1149262293;
					continue;
				case 1u:
					num = ((int)num2 * -1611739922) ^ -772066406;
					continue;
				case 0u:
				{
					int num3;
					if (BaseStream != 1)
					{
						num = 372244353;
						num3 = 372244353;
					}
					else
					{
						num = 115612110;
						num3 = 115612110;
					}
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0034;
		IL_0034:
		int result = num;
		int num2 = 776856614;
		goto IL_0018;
		IL_0013:
		num2 = 1444475693;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ 0x2E1210B0) % 3u)
		{
		case 2u:
			break;
		case 1u:
			goto IL_0033;
		default:
			return result;
		}
		goto IL_0013;
		IL_0033:
		num = 0;
		goto IL_0034;
	}

	private Player()
	{
	}

	public string PlanningCardsToString()
	{
		int num6 = default(int);
		int num5 = default(int);
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -893365929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1672504u) % 14u)
				{
				case 12u:
					num6 = PlanningCards[num5];
					num = -1087801613;
					continue;
				case 11u:
					result = text;
					num = (int)(num2 * 494725076) ^ -428074851;
					continue;
				case 10u:
					num5 = 0;
					num = (int)((num2 * 134435650) ^ 0x7F14671E);
					continue;
				case 9u:
					num = ((int)num2 * -1070215455) ^ -719062341;
					continue;
				case 8u:
					num = (int)(num2 * 649753028) ^ -1430412095;
					continue;
				case 7u:
					flag = num6 == 0;
					num = ((int)num2 * -125010886) ^ 0x4BFE4336;
					continue;
				case 5u:
					num5++;
					num = -250735384;
					continue;
				case 4u:
				{
					int num7;
					if (num5 >= PlanningCards.Length)
					{
						num = -71412335;
						num7 = -71412335;
					}
					else
					{
						num = -1394821238;
						num7 = -1394821238;
					}
					continue;
				}
				case 3u:
					text = " ";
					num = (int)((num2 * 1418907429) ^ 0x72645255);
					continue;
				case 2u:
					num = (int)(num2 * 1694299664) ^ -1278663544;
					continue;
				case 1u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num5],
						"x",
						num6.ToString(),
						" "
					});
					num = -1626133031;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1901654205;
						num4 = -1901654205;
					}
					else
					{
						num3 = -589479966;
						num4 = -589479966;
					}
					num = num3 ^ (int)(num2 * 380105680);
					continue;
				}
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
			int num = 1967683494;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EE5AC34u) % 3u)
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
				num = ((int)num2 * -1627894748) ^ 0x2A43395;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		bool flag = default(bool);
		while (true)
		{
			int num = -1759946492;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82E6D43Eu) % 9u)
				{
				case 8u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -1050406762;
					continue;
				case 7u:
					array = new int[count];
					num = ((int)num2 * -1444276482) ^ -1964578467;
					continue;
				case 5u:
					result = array;
					num = (int)(num2 * 1539694747) ^ -168627459;
					continue;
				case 4u:
					num = ((int)num2 * -1509509417) ^ -1061498353;
					continue;
				case 3u:
					flag = num3 < count;
					num = -180820015;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2110294141;
						num5 = 2110294141;
					}
					else
					{
						num4 = 849216968;
						num5 = 849216968;
					}
					num = num4 ^ (int)(num2 * 703022850);
					continue;
				}
				case 0u:
					num3 = 0;
					num = (int)((num2 * 324362232) ^ 0x422F781E);
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
