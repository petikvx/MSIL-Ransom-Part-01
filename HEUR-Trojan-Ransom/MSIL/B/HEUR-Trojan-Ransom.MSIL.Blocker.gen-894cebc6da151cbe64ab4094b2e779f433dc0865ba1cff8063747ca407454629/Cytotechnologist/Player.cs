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
			int num7 = default(int);
			int result = default(int);
			int num5 = default(int);
			bool flag = default(bool);
			int num6 = default(int);
			int[] planningCards = default(int[]);
			while (true)
			{
				int num = 1824802091;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D19B438u) % 15u)
					{
					case 13u:
						num7 = 0;
						num = (int)((num2 * 13110743) ^ 0x6F29D9EC);
						continue;
					case 12u:
						num = 1725179766;
						continue;
					case 11u:
						num = ((int)num2 * -26089562) ^ 0x1AD085A3;
						continue;
					case 10u:
						result = num5;
						num = (int)((num2 * 1556941139) ^ 0x5DA5BADE);
						continue;
					case 8u:
						flag = num6 > 0;
						num = (int)(num2 * 1965260366) ^ -1370752645;
						continue;
					case 7u:
						num5++;
						num = (int)(num2 * 1079526971) ^ -324559301;
						continue;
					case 6u:
						num7++;
						num = (int)(num2 * 404774220) ^ -2127033141;
						continue;
					case 5u:
						num = ((int)num2 * -1381896174) ^ -843881113;
						continue;
					case 4u:
					{
						int num8;
						if (num7 < planningCards.Length)
						{
							num = 1562485400;
							num8 = 1562485400;
						}
						else
						{
							num = 1179238646;
							num8 = 1179238646;
						}
						continue;
					}
					case 3u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1002767568) ^ -372410670;
						continue;
					case 2u:
						num5 = 0;
						num = (int)(num2 * 311669915) ^ -1426714989;
						continue;
					case 1u:
						num6 = planningCards[num7];
						num = 1117489169;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 911189902;
							num4 = 911189902;
						}
						else
						{
							num3 = 80899447;
							num4 = 80899447;
						}
						num = num3 ^ ((int)num2 * -106136330);
						continue;
					}
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
		string text = null;
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 127902586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70EE9F0Au) % 11u)
				{
				case 10u:
					flag = BaseStream == 1;
					num = 1922713368;
					continue;
				case 9u:
					num = ((int)num2 * -32667603) ^ -1537685383;
					continue;
				case 8u:
					text = "41676772656761746545786365707469";
					num = ((int)num2 * -814756508) ^ -410426368;
					continue;
				case 7u:
					text = "6E794235314452";
					num = ((int)num2 * -14175964) ^ -529813333;
					continue;
				case 5u:
					num = (int)((num2 * 28448271) ^ 0x55AB9AB2);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 2083450136;
						num6 = 2083450136;
					}
					else
					{
						num5 = 760941129;
						num6 = 760941129;
					}
					num = num5 ^ (int)(num2 * 122195913);
					continue;
				}
				case 3u:
					result = text;
					num = 1319242834;
					continue;
				case 2u:
					num = ((int)num2 * -749456857) ^ 0x9E59078;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -1441776697;
						num4 = -1441776697;
					}
					else
					{
						num3 = -730031833;
						num4 = -730031833;
					}
					num = num3 ^ ((int)num2 * -53838062);
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0049;
		IL_0049:
		int result = num;
		int num2 = -57999482;
		goto IL_0027;
		IL_0013:
		num2 = -1313469051;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xA5E7BF13u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = ((int)num3 * -845136463) ^ 0x14BAF78A;
				continue;
			case 2u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0013;
		IL_0048:
		num = 0;
		goto IL_0049;
	}

	private Player()
	{
		while (true)
		{
			int num = 2134846942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64FB3BF8u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1993898856) ^ 0x77EC5606;
			}
		}
	}

	public string PlanningCardsToString()
	{
		bool flag = default(bool);
		int num3 = default(int);
		string text = default(string);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -2140072769;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6EAD6E1u) % 15u)
				{
				case 14u:
					num = (int)(num2 * 218396750) ^ -1154598220;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1661721706;
						num8 = -1661721706;
					}
					else
					{
						num7 = -730831209;
						num8 = -730831209;
					}
					num = num7 ^ (int)(num2 * 1438070383);
					continue;
				}
				case 12u:
					flag = num3 < PlanningCards.Length;
					num = -6234072;
					continue;
				case 11u:
					num3++;
					num = -1125720633;
					continue;
				case 10u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -830007942;
					continue;
				case 9u:
					result = text;
					num = (int)(num2 * 81532071) ^ -1687947261;
					continue;
				case 8u:
					num = ((int)num2 * -249508293) ^ 0x1634CD9F;
					continue;
				case 6u:
					num4 = PlanningCards[num3];
					num = (int)((num2 * 293199087) ^ 0x2FFCFDC4);
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (num4 == 0)
					{
						num5 = 1561355799;
						num6 = 1561355799;
					}
					else
					{
						num5 = 1775071158;
						num6 = 1775071158;
					}
					num = num5 ^ (int)(num2 * 2023228131);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1272470541) ^ 0x1F8FB639);
					continue;
				case 3u:
					num = -222431231;
					continue;
				case 1u:
					text = " ";
					num3 = 0;
					num = ((int)num2 * -428670899) ^ -990062895;
					continue;
				case 0u:
					num = ((int)num2 * -1615345049) ^ -824577367;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 1166863572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F9C2D36u) % 3u)
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
				num = (int)((num2 * 1168047894) ^ 0x1AEAA9FC);
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num5 = default(int);
		bool flag = default(bool);
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = -1412207557;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF86A837u) % 12u)
				{
				case 11u:
					num5++;
					num = (int)((num2 * 1171356578) ^ 0x4AED5F70);
					continue;
				case 9u:
					flag = num5 < count;
					num = -233137511;
					continue;
				case 8u:
					array[num5] = json[num5].AsInt;
					num = -381513404;
					continue;
				case 7u:
					array = new int[count];
					num = ((int)num2 * -340565528) ^ 0x322925E0;
					continue;
				case 6u:
					num = (int)((num2 * 1693449594) ^ 0x7F7FF0AA);
					continue;
				case 5u:
					num = (int)((num2 * 411740596) ^ 0x7D75FE49);
					continue;
				case 4u:
					count = json.Count;
					num = ((int)num2 * -15256646) ^ -52436660;
					continue;
				case 3u:
					num5 = 0;
					num = ((int)num2 * -1139083671) ^ 0x56D12796;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -684216685;
						num4 = -684216685;
					}
					else
					{
						num3 = -1756707798;
						num4 = -1756707798;
					}
					num = num3 ^ ((int)num2 * -1481915582);
					continue;
				}
				case 1u:
					result = array;
					num = (int)(num2 * 841490161) ^ -1652525229;
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
			int num = 74884735;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9842C6Eu) % 4u)
				{
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 1452186526) ^ -874788024;
					continue;
				case 0u:
					num = (int)(num2 * 1636682196) ^ -1986214664;
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
