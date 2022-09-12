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
			int[] planningCards = default(int[]);
			int num6 = default(int);
			int num3 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = -859856987;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB76B323u) % 15u)
					{
					case 13u:
						num7 = planningCards[num6];
						num = -1964085331;
						continue;
					case 12u:
						num6++;
						num = (int)((num2 * 226181091) ^ 0x39D406E1);
						continue;
					case 10u:
						num3++;
						num = ((int)num2 * -1922737766) ^ 0x520132AE;
						continue;
					case 9u:
						num6 = 0;
						num = (int)((num2 * 1823422379) ^ 0x6548AFC1);
						continue;
					case 8u:
					{
						int num8;
						if (num6 < planningCards.Length)
						{
							num = -1725623368;
							num8 = -1725623368;
						}
						else
						{
							num = -524663388;
							num8 = -524663388;
						}
						continue;
					}
					case 7u:
						flag = num7 > 0;
						num = (int)(num2 * 1819493471) ^ -421234801;
						continue;
					case 6u:
						planningCards = PlanningCards;
						num = (int)((num2 * 1597254541) ^ 0x780059B);
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -2062479113;
							num5 = -2062479113;
						}
						else
						{
							num4 = -1307416648;
							num5 = -1307416648;
						}
						num = num4 ^ (int)(num2 * 662287891);
						continue;
					}
					case 4u:
						num = -814578384;
						continue;
					case 3u:
						num = (int)((num2 * 2043261368) ^ 0x38F3E5AC);
						continue;
					case 2u:
						num3 = 0;
						num = ((int)num2 * -329122072) ^ -1401833051;
						continue;
					case 1u:
						num = ((int)num2 * -1696948942) ^ -1342010813;
						continue;
					case 0u:
						result = num3;
						num = ((int)num2 * -1329911079) ^ 0x709B08C9;
						continue;
					case 14u:
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
		string result = default(string);
		while (true)
		{
			int num = -2034487321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD74EFB4Fu) % 10u)
				{
				case 9u:
					num = (int)(num2 * 1806522489) ^ -1974272139;
					continue;
				case 8u:
					text = null;
					flag = BaseStream == 0;
					num = (int)((num2 * 96732003) ^ 0x3753D748);
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -333774857;
						num5 = -333774857;
					}
					else
					{
						num4 = -1245094908;
						num5 = -1245094908;
					}
					num = num4 ^ (int)(num2 * 1964099897);
					continue;
				}
				case 5u:
					text = "7843304743794A72";
					num = ((int)num2 * -1094997674) ^ 0x466A0108;
					continue;
				case 3u:
					result = text;
					num = -332264173;
					continue;
				case 2u:
				{
					int num3;
					if (BaseStream != 1)
					{
						num = -7061438;
						num3 = -7061438;
					}
					else
					{
						num = -2090842976;
						num3 = -2090842976;
					}
					continue;
				}
				case 1u:
					text = "417373656D626C794275696C6465724461";
					num = ((int)num2 * -1983032397) ^ 0x3340E58E;
					continue;
				case 0u:
					num = ((int)num2 * -2113438678) ^ -148446312;
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
		int result = default(int);
		while (true)
		{
			int num = -299356940;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB1D99E7Du) % 5u)
				{
				case 2u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -136041410) ^ 0x5380379F;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 0u:
					num = (int)((num2 * 1414134821) ^ 0x92CC4F);
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = -1830883070;
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
			int num = -1770321026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9AA1C13u) % 3u)
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
				num = ((int)num2 * -1191498769) ^ 0x684B98D2;
			}
		}
	}

	public string PlanningCardsToString()
	{
		int num6 = default(int);
		int num3 = default(int);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 828391110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x118223C8u) % 13u)
				{
				case 12u:
					num = (int)(num2 * 1704299073) ^ -1086378796;
					continue;
				case 11u:
				{
					num6 = PlanningCards[num3];
					int num7;
					int num8;
					if (num6 != 0)
					{
						num7 = -2006475211;
						num8 = -2006475211;
					}
					else
					{
						num7 = -1697618577;
						num8 = -1697618577;
					}
					num = num7 ^ (int)(num2 * 1879512863);
					continue;
				}
				case 10u:
					text = " ";
					num = ((int)num2 * -1777505035) ^ -966115974;
					continue;
				case 9u:
					num = 1453071733;
					continue;
				case 8u:
					num = ((int)num2 * -1284637327) ^ -1055528988;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1300789797) ^ 0x7816885E;
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
					num = 2078724476;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -993039944;
						num5 = -993039944;
					}
					else
					{
						num4 = -323590088;
						num5 = -323590088;
					}
					num = num4 ^ (int)(num2 * 100609131);
					continue;
				}
				case 2u:
					num3++;
					num = 364845314;
					continue;
				case 1u:
					flag = num3 < PlanningCards.Length;
					num = 961444114;
					continue;
				case 0u:
					result = text;
					num = ((int)num2 * -904333104) ^ -1158735229;
					continue;
				case 5u:
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
			int num = 375697102;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x738CFFCCu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1430558211) ^ -757442018;
					continue;
				case 2u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -1489298961) ^ -1080823731;
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
		int count = json.Count;
		int[] array = new int[count];
		int[] result = default(int[]);
		int num3 = default(int);
		while (true)
		{
			int num = 1582597152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DC4A9B5u) % 9u)
				{
				case 8u:
					result = array;
					num = ((int)num2 * -1612292422) ^ 0xD4D7822;
					continue;
				case 7u:
					array[num3] = json[num3].AsInt;
					num = 420021507;
					continue;
				case 5u:
					num = (int)((num2 * 711834547) ^ 0x48D2F05C);
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -1798174142) ^ 0x225CBA20;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < count)
					{
						num = 1167238441;
						num4 = 1167238441;
					}
					else
					{
						num = 1717585257;
						num4 = 1717585257;
					}
					continue;
				}
				case 2u:
					num3++;
					num = ((int)num2 * -862516936) ^ 0x25CAF7C1;
					continue;
				case 1u:
					num = ((int)num2 * -952787207) ^ -1692287650;
					continue;
				case 6u:
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
