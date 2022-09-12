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
			int result = default(int);
			int num5 = default(int);
			int[] planningCards = default(int[]);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = 412482671;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48EE3496u) % 15u)
					{
					case 14u:
						num = ((int)num2 * -1493043496) ^ -1614484457;
						continue;
					case 13u:
						num3 = 0;
						num = (int)(num2 * 1290815070) ^ -856625335;
						continue;
					case 12u:
						result = num5;
						num = ((int)num2 * -838391728) ^ -1355434490;
						continue;
					case 11u:
						num3++;
						num = ((int)num2 * -199815971) ^ -144909784;
						continue;
					case 10u:
					{
						int num8;
						if (num3 >= planningCards.Length)
						{
							num = 1494364851;
							num8 = 1494364851;
						}
						else
						{
							num = 295100432;
							num8 = 295100432;
						}
						continue;
					}
					case 8u:
						planningCards = PlanningCards;
						num = (int)(num2 * 182036249) ^ -229107611;
						continue;
					case 7u:
						num5 = 0;
						num = ((int)num2 * -236052330) ^ -2116985165;
						continue;
					case 6u:
					{
						int num6;
						int num7;
						if (!flag)
						{
							num6 = -2067548763;
							num7 = -2067548763;
						}
						else
						{
							num6 = -1166825074;
							num7 = -1166825074;
						}
						num = num6 ^ ((int)num2 * -1819276264);
						continue;
					}
					case 5u:
						num5++;
						num = (int)((num2 * 1316638583) ^ 0x7895BC8D);
						continue;
					case 3u:
						num = (int)(num2 * 688532211) ^ -315258285;
						continue;
					case 2u:
						num = 987838428;
						continue;
					case 1u:
						flag = num4 > 0;
						num = (int)(num2 * 636986045) ^ -1868859348;
						continue;
					case 0u:
						num4 = planningCards[num3];
						num = 1697745688;
						continue;
					case 9u:
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
			int num = -1094238784;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABF44A05u) % 13u)
				{
				case 12u:
					text = null;
					num = (int)(num2 * 322508683) ^ -798005916;
					continue;
				case 11u:
					num = (int)((num2 * 348346620) ^ 0x612A2097);
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (BaseStream == 0)
					{
						num4 = 115696498;
						num5 = 115696498;
					}
					else
					{
						num4 = 620973808;
						num5 = 620973808;
					}
					num = num4 ^ ((int)num2 * -1237218688);
					continue;
				}
				case 9u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = -2103003628;
						num3 = -2103003628;
					}
					else
					{
						num = -1057756423;
						num3 = -1057756423;
					}
					continue;
				}
				case 8u:
					num = (int)((num2 * 996943210) ^ 0x3C96BCB2);
					continue;
				case 7u:
					text = "417267756D656E744F75744F6652616E676545786365707469";
					num = ((int)num2 * -700529114) ^ 0x40237B14;
					continue;
				case 6u:
					num = (int)((num2 * 1736902203) ^ 0x3578A976);
					continue;
				case 5u:
					text = "75596D336E4D497162";
					num = ((int)num2 * -314205600) ^ 0x4512B2D9;
					continue;
				case 3u:
					num = ((int)num2 * -2141732519) ^ 0x5B74E5C5;
					continue;
				case 1u:
					num = (int)((num2 * 1475439358) ^ 0x6E1ACFD5);
					continue;
				case 0u:
					result = text;
					num = -221400696;
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
			int num = -1328240286;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xCA7A24B7u) % 4u)
				{
				case 3u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)((num2 * 907820970) ^ 0x1FA1463E);
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
					num = -160873909;
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
		string text = default(string);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 959556080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E43DC9Cu) % 14u)
				{
				case 13u:
					num = ((int)num2 * -1338105808) ^ -739502412;
					continue;
				case 12u:
					num3++;
					num = 427589726;
					continue;
				case 11u:
					num = ((int)num2 * -39031958) ^ 0x190C8D74;
					continue;
				case 10u:
					text = " ";
					num = ((int)num2 * -1481601320) ^ -1873650723;
					continue;
				case 9u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 738137919;
					continue;
				case 7u:
					num3 = 0;
					num = (int)((num2 * 2136942535) ^ 0x68A6A06E);
					continue;
				case 6u:
					result = text;
					num = (int)(num2 * 1890835900) ^ -453381105;
					continue;
				case 5u:
					num = ((int)num2 * -871980263) ^ -1239980077;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (num4 != 0)
					{
						num6 = -1049262940;
						num7 = -1049262940;
					}
					else
					{
						num6 = -533788344;
						num7 = -533788344;
					}
					num = num6 ^ ((int)num2 * -1113532875);
					continue;
				}
				case 2u:
				{
					int num5;
					if (num3 >= PlanningCards.Length)
					{
						num = 665554360;
						num5 = 665554360;
					}
					else
					{
						num = 969884276;
						num5 = 969884276;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1644089018) ^ 0x1753374;
					continue;
				case 0u:
					num4 = PlanningCards[num3];
					num = 1274109537;
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
		Player result = default(Player);
		while (true)
		{
			int num = 1901250796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61801339u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2081754343) ^ -613633889;
					continue;
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -733557309) ^ 0x9C2D860;
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

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		int[] array = default(int[]);
		int count = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = 998535335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC267718u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 1342049012) ^ -1962062224;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -2046405951) ^ 0x4F802293;
					continue;
				case 6u:
					array = new int[count];
					num = ((int)num2 * -1738145101) ^ -918880190;
					continue;
				case 5u:
					count = json.Count;
					num = ((int)num2 * -340916198) ^ 0xA9C8022;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -79382694) ^ -471877908;
					continue;
				case 3u:
					array[num3] = json[num3].AsInt;
					num = 755231300;
					continue;
				case 1u:
					result = array;
					num = (int)((num2 * 1204530740) ^ 0x1899848B);
					continue;
				case 0u:
				{
					int num4;
					if (num3 < count)
					{
						num = 1711179945;
						num4 = 1711179945;
					}
					else
					{
						num = 1484029935;
						num4 = 1484029935;
					}
					continue;
				}
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
