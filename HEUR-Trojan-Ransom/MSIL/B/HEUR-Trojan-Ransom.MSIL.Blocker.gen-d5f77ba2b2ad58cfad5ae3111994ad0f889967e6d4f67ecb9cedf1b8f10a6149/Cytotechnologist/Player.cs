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
			int num4 = default(int);
			int[] planningCards = default(int[]);
			int num3 = default(int);
			int result = default(int);
			int num7 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -768795894;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC105B274u) % 15u)
					{
					case 14u:
						num4 = planningCards[num3];
						num = -1704460036;
						continue;
					case 13u:
						num3++;
						num = ((int)num2 * -2077161992) ^ 0x650DEC0C;
						continue;
					case 11u:
						result = num7;
						num = (int)((num2 * 2107837219) ^ 0x1243A975);
						continue;
					case 10u:
						num = ((int)num2 * -1311965305) ^ -1055089975;
						continue;
					case 9u:
						num7 = 0;
						num = (int)((num2 * 1125540146) ^ 0x33AC4AC4);
						continue;
					case 8u:
					{
						int num8;
						if (num3 >= planningCards.Length)
						{
							num = -1409086517;
							num8 = -1409086517;
						}
						else
						{
							num = -2084503139;
							num8 = -2084503139;
						}
						continue;
					}
					case 7u:
						num7++;
						num = ((int)num2 * -1499346362) ^ 0x3E4A392F;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = -1316300519;
							num6 = -1316300519;
						}
						else
						{
							num5 = -1904139438;
							num6 = -1904139438;
						}
						num = num5 ^ (int)(num2 * 1223410602);
						continue;
					}
					case 4u:
						num = ((int)num2 * -233707892) ^ 0x2AD7355F;
						continue;
					case 3u:
						flag = num4 > 0;
						num = ((int)num2 * -1488563041) ^ 0x2318C53E;
						continue;
					case 2u:
						num = -1644411904;
						continue;
					case 1u:
						planningCards = PlanningCards;
						num3 = 0;
						num = (int)((num2 * 1110063520) ^ 0x573D1F8);
						continue;
					case 0u:
						num = ((int)num2 * -930526773) ^ 0x747BC9E8;
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
		string text = null;
		bool flag = BaseStream == 0;
		string result = default(string);
		while (true)
		{
			int num = -733855215;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4B8F7BEu) % 10u)
				{
				case 8u:
					text = "59414F";
					num = (int)(num2 * 1623750312) ^ -442069917;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -726548510;
						num5 = -726548510;
					}
					else
					{
						num4 = -1040324602;
						num5 = -1040324602;
					}
					num = num4 ^ ((int)num2 * -123276604);
					continue;
				}
				case 6u:
					num = ((int)num2 * -965354968) ^ -319994253;
					continue;
				case 4u:
					num = ((int)num2 * -96512544) ^ 0x63F747E5;
					continue;
				case 3u:
					result = text;
					num = -1531854032;
					continue;
				case 2u:
					num = ((int)num2 * -1851377645) ^ -2043026857;
					continue;
				case 1u:
					text = "436F6D706C6574654F6E436F756E74646F776E50726F6D69";
					num = (int)(num2 * 1879672580) ^ -1273016474;
					continue;
				case 0u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = -1560423688;
						num3 = -1560423688;
					}
					else
					{
						num = -1097321069;
						num3 = -1097321069;
					}
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
		int num2 = -1333492799;
		goto IL_0018;
		IL_0013:
		num2 = -1541663937;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ -867731334) % 3u)
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
		string text = " ";
		int num = 0;
		int num4 = default(int);
		bool flag2 = default(bool);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -1936281857;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF031AFBEu) % 11u)
				{
				case 9u:
					num4 = PlanningCards[num];
					flag2 = num4 == 0;
					num2 = -1617789502;
					continue;
				case 8u:
					num++;
					num2 = -205300850;
					continue;
				case 6u:
					result = text;
					num2 = (int)(num3 * 1564567785) ^ -248774851;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -105039633;
						num8 = -105039633;
					}
					else
					{
						num7 = -1341587494;
						num8 = -1341587494;
					}
					num2 = num7 ^ ((int)num3 * -1363791329);
					continue;
				}
				case 4u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1447766799;
						num6 = -1447766799;
					}
					else
					{
						num5 = -736330522;
						num6 = -736330522;
					}
					num2 = num5 ^ (int)(num3 * 1129487075);
					continue;
				}
				case 3u:
					flag = num < PlanningCards.Length;
					num2 = -1409520192;
					continue;
				case 2u:
					num2 = ((int)num3 * -1886624676) ^ -187790126;
					continue;
				case 1u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num4.ToString(),
						" "
					});
					num2 = -1998295517;
					continue;
				case 0u:
					num2 = ((int)num3 * -1269594183) ^ 0x6DBD0A00;
					continue;
				case 10u:
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
			int num = 1973996148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AC44615u) % 3u)
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
				num = (int)((num2 * 2033634176) ^ 0x5C67ED5F);
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = default(int);
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = 940384379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FADCECDu) % 8u)
				{
				case 6u:
					count = json.Count;
					array = new int[count];
					num3 = 0;
					num = (int)(num2 * 938921121) ^ -1061449831;
					continue;
				case 5u:
					num = ((int)num2 * -1457482237) ^ 0x7485665;
					continue;
				case 4u:
					result = array;
					num = ((int)num2 * -989718390) ^ 0x88ECB08;
					continue;
				case 3u:
					array[num3] = json[num3].AsInt;
					num = 1021123116;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= count)
					{
						num = 129964793;
						num4 = 129964793;
					}
					else
					{
						num = 826456518;
						num4 = 826456518;
					}
					continue;
				}
				case 1u:
					num3++;
					num = ((int)num2 * -1775429350) ^ -1205587915;
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
			int num = -687511129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5FAA850u) % 4u)
				{
				case 3u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1119644734) ^ 0x4C1E933F;
					continue;
				case 1u:
					num = ((int)num2 * -696382068) ^ 0x496C24A6;
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
