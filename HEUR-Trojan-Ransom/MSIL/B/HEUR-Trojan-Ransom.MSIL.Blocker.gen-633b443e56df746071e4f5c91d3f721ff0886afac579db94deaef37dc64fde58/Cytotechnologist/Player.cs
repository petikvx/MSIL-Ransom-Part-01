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
			int[] planningCards = default(int[]);
			int result = default(int);
			while (true)
			{
				int num2 = -1256585947;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xF266106Cu) % 9u)
					{
					case 8u:
					{
						int num7;
						if (num4 >= planningCards.Length)
						{
							num2 = -839167133;
							num7 = -839167133;
						}
						else
						{
							num2 = -1598435974;
							num7 = -1598435974;
						}
						continue;
					}
					case 7u:
						planningCards = PlanningCards;
						num4 = 0;
						num2 = (int)((num3 * 1291917284) ^ 0x61D68D1B);
						continue;
					case 5u:
						result = num;
						num2 = ((int)num3 * -713692208) ^ -1013087689;
						continue;
					case 4u:
						num++;
						num2 = (int)(num3 * 421571022) ^ -1527722765;
						continue;
					case 2u:
					{
						int num5 = planningCards[num4];
						int num6;
						if (num5 > 0)
						{
							num2 = -856854769;
							num6 = -856854769;
						}
						else
						{
							num2 = -1505226663;
							num6 = -1505226663;
						}
						continue;
					}
					case 1u:
						num4++;
						num2 = ((int)num3 * -910533273) ^ -1293919135;
						continue;
					case 0u:
						num2 = -1719131714;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 666496952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x541396ABu) % 10u)
				{
				case 9u:
					flag = BaseStream == 1;
					num = 1798872764;
					continue;
				case 8u:
					num = (int)(num2 * 879888469) ^ -945018432;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1634961645;
						num6 = 1634961645;
					}
					else
					{
						num5 = 695962441;
						num6 = 695962441;
					}
					num = num5 ^ (int)(num2 * 210651616);
					continue;
				}
				case 5u:
					text = null;
					num = (int)((num2 * 310910682) ^ 0x7BFADA43);
					continue;
				case 4u:
					result = text;
					num = 293324459;
					continue;
				case 3u:
					text = "456D7074794173796E634C6F63616C56616C75654D";
					num = (int)(num2 * 73572197) ^ -387064832;
					continue;
				case 2u:
					text = "31634D";
					num = (int)((num2 * 1952907623) ^ 0x2E58B263);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -2044747326;
						num4 = -2044747326;
					}
					else
					{
						num3 = -1619061470;
						num4 = -1619061470;
					}
					num = num3 ^ ((int)num2 * -128817078);
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
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0034;
		IL_0034:
		int result = num;
		int num2 = -513657172;
		goto IL_0018;
		IL_0013:
		num2 = -1766489389;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ -1936118317) % 3u)
		{
		case 0u:
			break;
		case 2u:
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
		while (true)
		{
			int num = -654204950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E13C107u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 2043390962) ^ 0x47903377);
					continue;
				case 1u:
					num = (int)(num2 * 1183790820) ^ -1910588975;
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
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		int num8 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 717222439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x776AFF86u) % 16u)
				{
				case 15u:
					result = text;
					num = ((int)num2 * -114412662) ^ 0x3DBC3A63;
					continue;
				case 14u:
					num = (int)(num2 * 1023513023) ^ -1694874568;
					continue;
				case 13u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num8.ToString(),
						" "
					});
					num = 1947378355;
					continue;
				case 12u:
					flag2 = num3 < PlanningCards.Length;
					num = 1666821650;
					continue;
				case 10u:
					num3++;
					num = 761463354;
					continue;
				case 9u:
					num = 635147409;
					continue;
				case 8u:
					flag = num8 == 0;
					num = (int)((num2 * 809791491) ^ 0x5A301A6C);
					continue;
				case 7u:
					num8 = PlanningCards[num3];
					num = (int)(num2 * 422807633) ^ -974938231;
					continue;
				case 6u:
					num = ((int)num2 * -405371332) ^ -251112188;
					continue;
				case 5u:
					num = (int)((num2 * 1841344819) ^ 0x619500E3);
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag2)
					{
						num6 = -1175220705;
						num7 = -1175220705;
					}
					else
					{
						num6 = -416306007;
						num7 = -416306007;
					}
					num = num6 ^ (int)(num2 * 192612880);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1679087106) ^ -66496181;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -218099509;
						num5 = -218099509;
					}
					else
					{
						num4 = -1084816512;
						num5 = -1084816512;
					}
					num = num4 ^ ((int)num2 * -1918493632);
					continue;
				}
				case 1u:
					text = " ";
					num3 = 0;
					num = ((int)num2 * -414318653) ^ 0x5399C95B;
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
		Player result = new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
		while (true)
		{
			int num = 1848135004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4123589Bu) % 3u)
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
				num = (int)((num2 * 1441799704) ^ 0x2757ECCA);
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = default(int);
		int[] array = default(int[]);
		bool flag = default(bool);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1386331213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75E460E2u) % 8u)
				{
				case 7u:
					count = json.Count;
					array = new int[count];
					num = (int)(num2 * 1382132736) ^ -1629818614;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 266985267;
						num5 = 266985267;
					}
					else
					{
						num4 = 1054179254;
						num5 = 1054179254;
					}
					num = num4 ^ ((int)num2 * -2141833872);
					continue;
				}
				case 4u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 1244403465;
					continue;
				case 3u:
					flag = num3 < count;
					num = 845217828;
					continue;
				case 1u:
					result = array;
					num = ((int)num2 * -355198129) ^ 0x3B3A74C0;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 1483456748) ^ 0x470F66E9);
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
		string result = default(string);
		while (true)
		{
			int num = 1565471895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E2DDFBAu) % 4u)
				{
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 1922688598) ^ -671226060;
					continue;
				case 0u:
					num = (int)(num2 * 1758415670) ^ -1866451283;
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
