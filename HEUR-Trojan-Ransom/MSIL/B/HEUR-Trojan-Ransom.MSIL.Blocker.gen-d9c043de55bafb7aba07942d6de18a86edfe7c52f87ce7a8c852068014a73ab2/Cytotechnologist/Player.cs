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
			int num3 = default(int);
			bool flag = default(bool);
			int num4 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -618103639;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE32B4BD4u) % 13u)
					{
					case 12u:
					{
						int num8 = planningCards[num3];
						flag = num8 > 0;
						num = -25642791;
						continue;
					}
					case 11u:
						num = -1621369666;
						continue;
					case 10u:
						num4++;
						num = (int)((num2 * 1678878991) ^ 0x7F0C60A3);
						continue;
					case 9u:
						num4 = 0;
						num = (int)((num2 * 1178424267) ^ 0x4F57C083);
						continue;
					case 8u:
					{
						int num6;
						int num7;
						if (!flag)
						{
							num6 = -1887264735;
							num7 = -1887264735;
						}
						else
						{
							num6 = -1446184776;
							num7 = -1446184776;
						}
						num = num6 ^ ((int)num2 * -1291284975);
						continue;
					}
					case 7u:
					{
						int num5;
						if (num3 >= planningCards.Length)
						{
							num = -863443739;
							num5 = -863443739;
						}
						else
						{
							num = -98680965;
							num5 = -98680965;
						}
						continue;
					}
					case 5u:
						num = (int)(num2 * 548489820) ^ -81076060;
						continue;
					case 4u:
						planningCards = PlanningCards;
						num3 = 0;
						num = (int)(num2 * 863659544) ^ -2125575271;
						continue;
					case 2u:
						result = num4;
						num = ((int)num2 * -1555512396) ^ 0x3A4F0036;
						continue;
					case 1u:
						num3++;
						num = (int)(num2 * 2123468862) ^ -1335426691;
						continue;
					case 0u:
						num = ((int)num2 * -615858570) ^ -2001944529;
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
		string text = null;
		bool flag2 = default(bool);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1414935240;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB52CA7Fu) % 12u)
				{
				case 11u:
					num = (int)(num2 * 329006835) ^ -2087608390;
					continue;
				case 10u:
					num = (int)((num2 * 1439735400) ^ 0x4CD788CD);
					continue;
				case 7u:
					flag2 = BaseStream == 1;
					num = -1739769502;
					continue;
				case 6u:
					text = "4276434766";
					num = ((int)num2 * -1555327025) ^ 0x4D37FB92;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -774706797;
						num6 = -774706797;
					}
					else
					{
						num5 = -279474463;
						num6 = -279474463;
					}
					num = num5 ^ (int)(num2 * 183393408);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1355284940;
						num4 = -1355284940;
					}
					else
					{
						num3 = -1911621291;
						num4 = -1911621291;
					}
					num = num3 ^ (int)(num2 * 101285122);
					continue;
				}
				case 3u:
					flag = BaseStream == 0;
					num = (int)((num2 * 599495811) ^ 0x23577A76);
					continue;
				case 2u:
					text = "4173796D6D65747269635369676E6174757265466F726D617474";
					num = ((int)num2 * -846141897) ^ -839291571;
					continue;
				case 1u:
					num = (int)(num2 * 971114395) ^ -802384584;
					continue;
				case 0u:
					result = text;
					num = -1397295922;
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
		int num2 = 706606659;
		goto IL_0018;
		IL_0018:
		int result = default(int);
		switch ((uint)(num2 ^ 0x45CD8E9D) % 3u)
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
		num2 = 2095031722;
		goto IL_0018;
	}

	private Player()
	{
		while (true)
		{
			int num = 133613413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A0E595Cu) % 3u)
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
				num = ((int)num2 * -1985885956) ^ 0x554088C6;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num4 = default(int);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 669995495;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DD94A16u) % 13u)
				{
				case 12u:
					num = 773891034;
					continue;
				case 11u:
					num4 = PlanningCards[num3];
					flag2 = num4 == 0;
					num = (int)((num2 * 282356326) ^ 0x580B20E0);
					continue;
				case 10u:
					num3++;
					num = 1111788851;
					continue;
				case 9u:
					flag = num3 < PlanningCards.Length;
					num = 129824273;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -1329051600) ^ -468875261;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -178710280;
						num8 = -178710280;
					}
					else
					{
						num7 = -149405391;
						num8 = -149405391;
					}
					num = num7 ^ ((int)num2 * -63123914);
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -958861561;
						num6 = -958861561;
					}
					else
					{
						num5 = -1714741652;
						num6 = -1714741652;
					}
					num = num5 ^ (int)(num2 * 1706816518);
					continue;
				}
				case 4u:
					num = (int)((num2 * 114218148) ^ 0x4B28227C);
					continue;
				case 3u:
					num = ((int)num2 * -698535272) ^ 0x14D48A8C;
					continue;
				case 1u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 1459036175;
					continue;
				case 0u:
					result = text;
					num = (int)(num2 * 1518059170) ^ -1508620044;
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
		Player result = new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
		while (true)
		{
			int num = -1736882727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0393BCDu) % 3u)
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
				num = ((int)num2 * -980146276) ^ -620709786;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int[] result = default(int[]);
		int[] array = default(int[]);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1055566000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CEE2CE4u) % 10u)
				{
				case 9u:
					result = array;
					num = ((int)num2 * -2035047331) ^ 0x7C728901;
					continue;
				case 8u:
					num = (int)(num2 * 110273738) ^ -1596008443;
					continue;
				case 7u:
					num3++;
					num = (int)((num2 * 1999583858) ^ 0xDCE6AA7);
					continue;
				case 6u:
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -1409259430) ^ 0x1CAD4B0C;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1757840574;
						num5 = 1757840574;
					}
					else
					{
						num4 = 1089820324;
						num5 = 1089820324;
					}
					num = num4 ^ ((int)num2 * -489811095);
					continue;
				}
				case 3u:
					flag = num3 < count;
					num = -34669715;
					continue;
				case 1u:
					array[num3] = json[num3].AsInt;
					num = -807288803;
					continue;
				case 0u:
					num = ((int)num2 * -1089314231) ^ 0x1B690EAC;
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

	public override string ToString()
	{
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = -229930073;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0B53FF9u) % 3u)
				{
				case 2u:
					goto IL_0024;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0024:
				num = (int)(num2 * 1388708806) ^ -561015946;
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
