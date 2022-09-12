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
			int num4 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num2 = 85784701;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x4D3E9ABCu) % 12u)
					{
					case 11u:
					{
						int num8;
						if (num4 < planningCards.Length)
						{
							num2 = 838832921;
							num8 = 838832921;
						}
						else
						{
							num2 = 305612018;
							num8 = 305612018;
						}
						continue;
					}
					case 10u:
						num++;
						num2 = ((int)num3 * -12800699) ^ -404505825;
						continue;
					case 9u:
						num2 = 229218018;
						continue;
					case 7u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = -1422985046;
							num7 = -1422985046;
						}
						else
						{
							num6 = -653303615;
							num7 = -653303615;
						}
						num2 = num6 ^ ((int)num3 * -1029424664);
						continue;
					}
					case 6u:
						num4++;
						num2 = (int)((num3 * 1042195747) ^ 0x7F4B059);
						continue;
					case 5u:
					{
						int num5 = planningCards[num4];
						flag = num5 > 0;
						num2 = 771349031;
						continue;
					}
					case 3u:
						num2 = ((int)num3 * -939281153) ^ 0x3D28FA5;
						continue;
					case 2u:
						result = num;
						num2 = (int)((num3 * 984584516) ^ 0x11ED851F);
						continue;
					case 1u:
						num4 = 0;
						num2 = ((int)num3 * -1735435690) ^ 0x42BA231A;
						continue;
					case 0u:
						num2 = ((int)num3 * -1575184765) ^ -634756909;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -916501206;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95C75303u) % 11u)
				{
				case 9u:
					result = text;
					num = -868241982;
					continue;
				case 8u:
					num = ((int)num2 * -108775649) ^ 0x65AC0799;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1504048682;
						num6 = -1504048682;
					}
					else
					{
						num5 = -496197621;
						num6 = -496197621;
					}
					num = num5 ^ (int)(num2 * 519002532);
					continue;
				}
				case 6u:
					num = (int)(num2 * 984553299) ^ -1739664017;
					continue;
				case 5u:
					flag = BaseStream == 1;
					num = -281861105;
					continue;
				case 4u:
					text = "487455456D";
					num = (int)((num2 * 460554092) ^ 0x3375DCD6);
					continue;
				case 3u:
					text = "4C4942464C41";
					num = (int)((num2 * 181172561) ^ 0x4286D1B1);
					continue;
				case 2u:
					num = ((int)num2 * -139128573) ^ 0x66253153;
					continue;
				case 1u:
				{
					text = null;
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -59234709;
						num4 = -59234709;
					}
					else
					{
						num3 = -1782681977;
						num4 = -1782681977;
					}
					num = num3 ^ (int)(num2 * 800380495);
					continue;
				}
				case 10u:
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
		int num2 = 778970470;
		goto IL_0018;
		IL_0013:
		num2 = 1244244910;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ 0x7D998C42) % 3u)
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
	}

	public string PlanningCardsToString()
	{
		int num3 = default(int);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = 1732703088;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x693392E4u) % 13u)
				{
				case 12u:
					num = (int)((num2 * 11479518) ^ 0x50D317C1);
					continue;
				case 10u:
					num3 = 0;
					num = ((int)num2 * -986753717) ^ 0x5DE9BC50;
					continue;
				case 9u:
					num3++;
					num = 83589156;
					continue;
				case 8u:
					text = " ";
					num = ((int)num2 * -228615570) ^ -2132799584;
					continue;
				case 7u:
					num = (int)((num2 * 550015912) ^ 0x1187E8DF);
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1632343632;
						num7 = -1632343632;
					}
					else
					{
						num6 = -470193607;
						num7 = -470193607;
					}
					num = num6 ^ (int)(num2 * 99212104);
					continue;
				}
				case 5u:
					result = text;
					num = (int)((num2 * 1809998342) ^ 0x8568746);
					continue;
				case 4u:
				{
					int num5;
					if (num3 < PlanningCards.Length)
					{
						num = 210525715;
						num5 = 210525715;
					}
					else
					{
						num = 1597965334;
						num5 = 1597965334;
					}
					continue;
				}
				case 2u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 1656541589;
					continue;
				case 1u:
					num4 = PlanningCards[num3];
					flag = num4 == 0;
					num = 766610775;
					continue;
				case 0u:
					num = ((int)num2 * -1976309348) ^ -1659852962;
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

	public static Player Deserialize(JSONNode json)
	{
		return new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] array = default(int[]);
		int num3 = default(int);
		int count = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -1817191729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9569AC4Eu) % 8u)
				{
				case 7u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -941027534;
					continue;
				case 6u:
					num = (int)(num2 * 1770315514) ^ -128850487;
					continue;
				case 5u:
					num3 = 0;
					num = (int)(num2 * 847636366) ^ -1486087372;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -71685314;
						num4 = -71685314;
					}
					else
					{
						num = -1494339407;
						num4 = -1494339407;
					}
					continue;
				}
				case 1u:
					count = json.Count;
					array = new int[count];
					num = ((int)num2 * -514134320) ^ -1103878789;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -1016368988) ^ -1261166472;
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
