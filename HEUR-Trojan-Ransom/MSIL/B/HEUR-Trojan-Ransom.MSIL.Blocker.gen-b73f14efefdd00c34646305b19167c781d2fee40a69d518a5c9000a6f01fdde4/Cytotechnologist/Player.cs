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
			int result = default(int);
			int num7 = default(int);
			int[] planningCards = default(int[]);
			int num6 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 355285493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E0473FDu) % 13u)
					{
					case 11u:
						result = num7;
						num = (int)((num2 * 1687317698) ^ 0x1DE81CBC);
						continue;
					case 10u:
						planningCards = PlanningCards;
						num6 = 0;
						num = (int)(num2 * 1990741565) ^ -1168777344;
						continue;
					case 9u:
						num = ((int)num2 * -30969868) ^ -1389406118;
						continue;
					case 8u:
						num6++;
						num = (int)((num2 * 1851546002) ^ 0x1594315F);
						continue;
					case 7u:
					{
						int num8;
						if (num6 >= planningCards.Length)
						{
							num = 1960475465;
							num8 = 1960475465;
						}
						else
						{
							num = 138077621;
							num8 = 138077621;
						}
						continue;
					}
					case 5u:
						num7++;
						num = ((int)num2 * -678352522) ^ 0x6D222F69;
						continue;
					case 4u:
						num3 = planningCards[num6];
						num = 1704746081;
						continue;
					case 3u:
						num = 1773271717;
						continue;
					case 2u:
						num = ((int)num2 * -1938378321) ^ 0x726ECC8E;
						continue;
					case 1u:
						num7 = 0;
						num = (int)((num2 * 330242437) ^ 0x5785394E);
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (num3 <= 0)
						{
							num4 = -1974669547;
							num5 = -1974669547;
						}
						else
						{
							num4 = -1914934946;
							num5 = -1914934946;
						}
						num = num4 ^ (int)(num2 * 2012573462);
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1582369381;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAC1B011u) % 11u)
				{
				case 10u:
					text = "7330326878443838";
					num = (int)(num2 * 1241297479) ^ -1933616963;
					continue;
				case 9u:
					num = ((int)num2 * -1424893375) ^ 0x74298F5F;
					continue;
				case 8u:
					num = ((int)num2 * -1859099956) ^ -1646370256;
					continue;
				case 7u:
					text = "43616E63656C6C6174696F6E43616C6C6261636B436F7265576F726B417267756D656E";
					num = (int)(num2 * 1582062190) ^ -759151342;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (BaseStream != 0)
					{
						num4 = 606341800;
						num5 = 606341800;
					}
					else
					{
						num4 = 1905098733;
						num5 = 1905098733;
					}
					num = num4 ^ ((int)num2 * -1766537097);
					continue;
				}
				case 5u:
					text = null;
					num = ((int)num2 * -271414406) ^ -896489376;
					continue;
				case 4u:
					num = (int)((num2 * 1691227305) ^ 0x3C8994E4);
					continue;
				case 3u:
					result = text;
					num = -1421912667;
					continue;
				case 1u:
				{
					int num3;
					if (BaseStream != 1)
					{
						num = -265827108;
						num3 = -265827108;
					}
					else
					{
						num = -2133643918;
						num3 = -2133643918;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = 1915502901;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x79D0B266u) % 5u)
				{
				case 4u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -57909351) ^ -1038129237;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 3u:
					num3 = 0;
					goto IL_0023;
				case 2u:
					num = ((int)num2 * -353395537) ^ -285796918;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					result = num3;
					num = 1004525185;
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
		bool flag = default(bool);
		int num8 = default(int);
		int num3 = default(int);
		string result = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -936121433;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD384EED7u) % 15u)
				{
				case 14u:
					num = -1190515197;
					continue;
				case 12u:
					text = " ";
					num = ((int)num2 * -1743590646) ^ 0x7D6FDF89;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 1374766097;
						num7 = 1374766097;
					}
					else
					{
						num6 = 982253520;
						num7 = 982253520;
					}
					num = num6 ^ (int)(num2 * 745834881);
					continue;
				}
				case 10u:
					num8++;
					num = -1783718110;
					continue;
				case 9u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num8],
						"x",
						num3.ToString(),
						" "
					});
					num = -1961109636;
					continue;
				case 8u:
					num8 = 0;
					num = (int)((num2 * 2067629212) ^ 0xC8CC51F);
					continue;
				case 7u:
					num3 = PlanningCards[num8];
					num = ((int)num2 * -1361709303) ^ -459211235;
					continue;
				case 6u:
					result = text;
					num = ((int)num2 * -483854278) ^ -665850894;
					continue;
				case 5u:
					flag2 = num8 < PlanningCards.Length;
					num = -503242674;
					continue;
				case 4u:
					num = (int)((num2 * 1307103014) ^ 0x254AE322);
					continue;
				case 2u:
					num = ((int)num2 * -169381735) ^ 0x3E7DB392;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = 452695522;
						num5 = 452695522;
					}
					else
					{
						num4 = 525866709;
						num5 = 525866709;
					}
					num = num4 ^ (int)(num2 * 1094470360);
					continue;
				}
				case 0u:
					flag = num3 == 0;
					num = ((int)num2 * -1438109748) ^ 0x5F7BBF26;
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
		Player result = default(Player);
		while (true)
		{
			int num = -312167142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9759A4D4u) % 4u)
				{
				case 2u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -309736138) ^ 0x7C1E9011;
					continue;
				case 1u:
					num = ((int)num2 * -798504435) ^ 0x157B78F6;
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

	private static int[] ParsePlanningCards(JSONNode json)
	{
		bool flag = default(bool);
		int num3 = default(int);
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = -436963321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBCBF07Au) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 2034925382;
						num5 = 2034925382;
					}
					else
					{
						num4 = 1010161759;
						num5 = 1010161759;
					}
					num = num4 ^ ((int)num2 * -691109676);
					continue;
				}
				case 6u:
					flag = num3 < count;
					num = -1369191155;
					continue;
				case 5u:
					count = json.Count;
					array = new int[count];
					num = ((int)num2 * -157244223) ^ 0x2386D593;
					continue;
				case 4u:
					num3 = 0;
					num = (int)(num2 * 264809506) ^ -1695607516;
					continue;
				case 1u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -880853236;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -777325544) ^ -1541877151;
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
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = -786832154;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x934F9188u) % 3u)
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
				num = ((int)num2 * -866521780) ^ -44490677;
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
