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
			int[] planningCards = default(int[]);
			int num5 = default(int);
			int result = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = 819406338;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5DC2A7B1u) % 13u)
					{
					case 12u:
						num = ((int)num2 * -1342358873) ^ -1919501624;
						continue;
					case 11u:
						num3 = 0;
						num = ((int)num2 * -1816586186) ^ -1450008732;
						continue;
					case 10u:
					{
						int num8;
						if (num3 >= planningCards.Length)
						{
							num = 299951407;
							num8 = 299951407;
						}
						else
						{
							num = 2093105449;
							num8 = 2093105449;
						}
						continue;
					}
					case 8u:
					{
						int num6;
						int num7;
						if (num5 > 0)
						{
							num6 = 635555454;
							num7 = 635555454;
						}
						else
						{
							num6 = 650853878;
							num7 = 650853878;
						}
						num = num6 ^ ((int)num2 * -185829992);
						continue;
					}
					case 7u:
						result = num4;
						num = (int)((num2 * 1346302385) ^ 0x128451C4);
						continue;
					case 6u:
						num5 = planningCards[num3];
						num = 595234080;
						continue;
					case 5u:
						num = ((int)num2 * -1306449534) ^ 0x9F1C4B1;
						continue;
					case 4u:
						num4 = 0;
						num = ((int)num2 * -1313324929) ^ 0x234B23DA;
						continue;
					case 2u:
						num4++;
						num = (int)((num2 * 1688346533) ^ 0x7108C39D);
						continue;
					case 1u:
						planningCards = PlanningCards;
						num = (int)((num2 * 1306539207) ^ 0x55A1B30E);
						continue;
					case 0u:
						num3++;
						num = 114520088;
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
			int num = -1437945476;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB63D4DC1u) % 9u)
				{
				case 7u:
					text = "436F6E736F6C6543616E63656C4576656E7448616E646C";
					num = ((int)num2 * -33649929) ^ -1744487857;
					continue;
				case 6u:
				{
					text = null;
					int num4;
					int num5;
					if (BaseStream == 0)
					{
						num4 = -1557086967;
						num5 = -1557086967;
					}
					else
					{
						num4 = -2084359250;
						num5 = -2084359250;
					}
					num = num4 ^ ((int)num2 * -1460711256);
					continue;
				}
				case 5u:
					result = text;
					num = -1521842117;
					continue;
				case 4u:
				{
					int num3;
					if (BaseStream != 1)
					{
						num = -900808339;
						num3 = -900808339;
					}
					else
					{
						num = -1680905465;
						num3 = -1680905465;
					}
					continue;
				}
				case 3u:
					num = (int)(num2 * 704831817) ^ -297018144;
					continue;
				case 2u:
					num = (int)(num2 * 905640079) ^ -1575690470;
					continue;
				case 1u:
					text = "3163356B67";
					num = (int)(num2 * 802220688) ^ -1060632051;
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
		int num2 = -1175562679;
		goto IL_0018;
		IL_0013:
		num2 = -1167133319;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ -844036709) % 3u)
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
		string text = " ";
		int num = 0;
		int num4 = default(int);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = -52274432;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x88C1FB64u) % 11u)
				{
				case 9u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num4.ToString(),
						" "
					});
					num2 = -1746404905;
					continue;
				case 8u:
					result = text;
					num2 = (int)(num3 * 855772656) ^ -949621569;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 315178695;
						num7 = 315178695;
					}
					else
					{
						num6 = 463973056;
						num7 = 463973056;
					}
					num2 = num6 ^ ((int)num3 * -1286883823);
					continue;
				}
				case 6u:
					flag = num < PlanningCards.Length;
					num2 = -871256832;
					continue;
				case 5u:
					num2 = ((int)num3 * -1497606855) ^ 0x1DDD84F1;
					continue;
				case 3u:
					num2 = ((int)num3 * -106825362) ^ -568052265;
					continue;
				case 2u:
				{
					num4 = PlanningCards[num];
					int num5;
					if (num4 != 0)
					{
						num2 = -2089933701;
						num5 = -2089933701;
					}
					else
					{
						num2 = -1626164892;
						num5 = -1626164892;
					}
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -2082729901) ^ 0x5575E185;
					continue;
				case 0u:
					num++;
					num2 = -1225350679;
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
			int num = 1530772360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C7BB66u) % 3u)
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
				num = (int)(num2 * 1521509774) ^ -556272600;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int[] array = new int[count];
		int num = 0;
		int[] result = default(int[]);
		while (true)
		{
			int num2 = 185016610;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x6E00D044u) % 7u)
				{
				case 6u:
				{
					int num4;
					if (num < count)
					{
						num2 = 1825948668;
						num4 = 1825948668;
					}
					else
					{
						num2 = 28777501;
						num4 = 28777501;
					}
					continue;
				}
				case 5u:
					num2 = ((int)num3 * -2145512349) ^ -1997940496;
					continue;
				case 3u:
					result = array;
					num2 = ((int)num3 * -685071383) ^ -358026760;
					continue;
				case 2u:
					array[num] = json[num].AsInt;
					num++;
					num2 = 1913358978;
					continue;
				case 1u:
					num2 = (int)(num3 * 1964772772) ^ -444158628;
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
		string result = default(string);
		while (true)
		{
			int num = 213331530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x145B377Du) % 4u)
				{
				case 3u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 1341664369) ^ -72239845;
					continue;
				case 1u:
					num = (int)((num2 * 1262454649) ^ 0x36240B2E);
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
