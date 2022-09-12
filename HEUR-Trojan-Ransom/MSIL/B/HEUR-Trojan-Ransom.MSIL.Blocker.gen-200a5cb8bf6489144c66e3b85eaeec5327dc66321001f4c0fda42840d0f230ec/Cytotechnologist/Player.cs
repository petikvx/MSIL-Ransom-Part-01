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
			int num4 = default(int);
			int result = default(int);
			int num5 = default(int);
			while (true)
			{
				int num = 1637863100;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4751263Eu) % 13u)
					{
					case 12u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1555047625) ^ -1273818846;
						continue;
					case 11u:
						num3++;
						num = 1456596016;
						continue;
					case 10u:
						num3 = 0;
						num = (int)(num2 * 225013633) ^ -1651690760;
						continue;
					case 9u:
						num = (int)(num2 * 1849013537) ^ -1214859648;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (num4 <= 0)
						{
							num7 = -1566548924;
							num8 = -1566548924;
						}
						else
						{
							num7 = -775022498;
							num8 = -775022498;
						}
						num = num7 ^ (int)(num2 * 813907161);
						continue;
					}
					case 5u:
						result = num5;
						num = ((int)num2 * -299698151) ^ -1954896093;
						continue;
					case 4u:
						num = ((int)num2 * -587935059) ^ -1002849989;
						continue;
					case 3u:
					{
						int num6;
						if (num3 >= planningCards.Length)
						{
							num = 897949433;
							num6 = 897949433;
						}
						else
						{
							num = 1133953675;
							num6 = 1133953675;
						}
						continue;
					}
					case 2u:
						num5++;
						num = (int)((num2 * 601646530) ^ 0x319D8E32);
						continue;
					case 1u:
						num5 = 0;
						num = ((int)num2 * -1793422444) ^ 0x7B618F0D;
						continue;
					case 0u:
						num4 = planningCards[num3];
						num = 1437978972;
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -915304196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7BD65C2u) % 14u)
				{
				case 13u:
					result = text;
					num = -130184619;
					continue;
				case 11u:
					flag2 = BaseStream == 1;
					num = -1641425481;
					continue;
				case 10u:
					num = (int)((num2 * 181581427) ^ 0x5B2867DB);
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1262494309;
						num6 = 1262494309;
					}
					else
					{
						num5 = 1607112121;
						num6 = 1607112121;
					}
					num = num5 ^ ((int)num2 * -835421210);
					continue;
				}
				case 8u:
					text = null;
					flag = BaseStream == 0;
					num = (int)((num2 * 2037056926) ^ 0x246F3138);
					continue;
				case 7u:
					num = (int)(num2 * 518676603) ^ -2034419558;
					continue;
				case 6u:
					text = "546872656164506F6F6C5461736B5363686564756C";
					num = ((int)num2 * -2058941136) ^ -881285940;
					continue;
				case 4u:
					text = "50305A4852597452";
					num = (int)(num2 * 197196916) ^ -871551984;
					continue;
				case 3u:
					num = (int)(num2 * 788384292) ^ -582489070;
					continue;
				case 2u:
					num = ((int)num2 * -652504639) ^ 0x3AA2C479;
					continue;
				case 1u:
					num = ((int)num2 * -755457786) ^ 0x351149C;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -793119779;
						num4 = -793119779;
					}
					else
					{
						num3 = -12046887;
						num4 = -12046887;
					}
					num = num3 ^ ((int)num2 * -513999063);
					continue;
				}
				case 12u:
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
			goto IL_0022;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0049;
		IL_0049:
		int result = num;
		int num2 = -31705768;
		goto IL_0027;
		IL_0022:
		num2 = -789613790;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xBD9193E7u) % 4u)
			{
			case 3u:
				num2 = (int)((num3 * 1984049709) ^ 0x5BFA0ED2);
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_0048:
		num = 0;
		goto IL_0049;
	}

	private Player()
	{
		while (true)
		{
			int num = 882631554;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF24893u) % 3u)
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
				num = (int)(num2 * 592823968) ^ -1547935262;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1528797001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD12B9D3Fu) % 15u)
				{
				case 14u:
					num = (int)((num2 * 1856108816) ^ 0x16B34702);
					continue;
				case 13u:
					result = text;
					num = ((int)num2 * -888858657) ^ -2045123166;
					continue;
				case 12u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num5.ToString(),
						" "
					});
					num = -709670908;
					continue;
				case 11u:
					text = " ";
					num = ((int)num2 * -1362775840) ^ 0x143FC257;
					continue;
				case 9u:
					num5 = PlanningCards[num3];
					num = ((int)num2 * -1936051551) ^ 0x4D6657BE;
					continue;
				case 8u:
					num3++;
					num = -1721560718;
					continue;
				case 6u:
					num = (int)(num2 * 768552718) ^ -105175900;
					continue;
				case 5u:
					flag = num5 == 0;
					num = ((int)num2 * -274749201) ^ -1555707848;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -744655728;
						num7 = -744655728;
					}
					else
					{
						num6 = -57276919;
						num7 = -57276919;
					}
					num = num6 ^ (int)(num2 * 182903781);
					continue;
				}
				case 3u:
					num = (int)((num2 * 31066040) ^ 0x1FBD0600);
					continue;
				case 2u:
					num = -1762937006;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= PlanningCards.Length)
					{
						num = -1103313617;
						num4 = -1103313617;
					}
					else
					{
						num = -867832252;
						num4 = -867832252;
					}
					continue;
				}
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1570346000) ^ -1795650104;
					continue;
				case 7u:
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
			int num = 1489212512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7CC5B04Eu) % 4u)
				{
				case 2u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = (int)((num2 * 1512858052) ^ 0x55B2D90B);
					continue;
				case 1u:
					num = (int)(num2 * 994181171) ^ -1873537299;
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
		bool flag = default(bool);
		int num3 = default(int);
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1798115568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A1969BBu) % 10u)
				{
				case 9u:
					flag = num3 < count;
					num = 577821880;
					continue;
				case 8u:
					array[num3] = json[num3].AsInt;
					num = 2071251583;
					continue;
				case 6u:
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -874139206) ^ -182155954;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1918058797;
						num5 = -1918058797;
					}
					else
					{
						num4 = -1767751626;
						num5 = -1767751626;
					}
					num = num4 ^ (int)(num2 * 1703098825);
					continue;
				}
				case 3u:
					result = array;
					num = ((int)num2 * -118678080) ^ -126435567;
					continue;
				case 2u:
					num = ((int)num2 * -1395595148) ^ -2112628739;
					continue;
				case 1u:
					count = json.Count;
					num = (int)((num2 * 663702631) ^ 0x49A650E);
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -1589438765) ^ -1040068686;
					continue;
				case 7u:
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
			int num = -1674755662;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA628B8D0u) % 4u)
				{
				case 2u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 401785040) ^ -413531395;
					continue;
				case 1u:
					num = ((int)num2 * -12911117) ^ -1570222573;
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
