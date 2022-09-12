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
			int num7 = default(int);
			int[] planningCards = default(int[]);
			int result = default(int);
			int num4 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num2 = -92854780;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xA55C4D92u) % 14u)
					{
					case 12u:
						num2 = -973921247;
						continue;
					case 11u:
					{
						int num8;
						if (num7 >= planningCards.Length)
						{
							num2 = -1276538637;
							num8 = -1276538637;
						}
						else
						{
							num2 = -541160697;
							num8 = -541160697;
						}
						continue;
					}
					case 10u:
						num2 = (int)(num3 * 606267119) ^ -2020571948;
						continue;
					case 9u:
						num7++;
						num2 = ((int)num3 * -441588053) ^ 0x25985D02;
						continue;
					case 7u:
						result = num;
						num2 = ((int)num3 * -163390585) ^ 0x4B75B573;
						continue;
					case 6u:
						planningCards = PlanningCards;
						num2 = (int)((num3 * 586085804) ^ 0x7D1ED38B);
						continue;
					case 5u:
						num7 = 0;
						num2 = (int)(num3 * 1061146855) ^ -673010036;
						continue;
					case 4u:
						num2 = ((int)num3 * -381780629) ^ -956409410;
						continue;
					case 3u:
						num4 = planningCards[num7];
						num2 = -1835342692;
						continue;
					case 2u:
						num++;
						num2 = ((int)num3 * -831490841) ^ 0x1638946E;
						continue;
					case 1u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -712474512;
							num6 = -712474512;
						}
						else
						{
							num5 = -717519296;
							num6 = -717519296;
						}
						num2 = num5 ^ ((int)num3 * -1855126812);
						continue;
					}
					case 0u:
						flag = num4 > 0;
						num2 = (int)(num3 * 2097802360) ^ -1618870483;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 488847472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E5D63F5u) % 14u)
				{
				case 13u:
					num = (int)((num2 * 2137677073) ^ 0x2515732E);
					continue;
				case 12u:
					result = text;
					num = 552577947;
					continue;
				case 11u:
					text = "5365595244";
					num = (int)(num2 * 1557885565) ^ -227906576;
					continue;
				case 10u:
					num = (int)(num2 * 1545132343) ^ -1346584525;
					continue;
				case 9u:
					text = null;
					flag = BaseStream == 0;
					num = ((int)num2 * -196762430) ^ 0x4208C535;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 643411612;
						num6 = 643411612;
					}
					else
					{
						num5 = 1653328255;
						num6 = 1653328255;
					}
					num = num5 ^ ((int)num2 * -2024859635);
					continue;
				}
				case 6u:
					num = ((int)num2 * -763485236) ^ 0x5B120736;
					continue;
				case 4u:
					flag2 = BaseStream == 1;
					num = 1378274594;
					continue;
				case 3u:
					num = ((int)num2 * -1986975648) ^ -971246394;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -680386571;
						num4 = -680386571;
					}
					else
					{
						num3 = -561630094;
						num4 = -561630094;
					}
					num = num3 ^ ((int)num2 * -791736534);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1870120135) ^ -2074828080;
					continue;
				case 0u:
					text = "53757070726573734D65726765436865636B41747472696275";
					num = ((int)num2 * -1380631975) ^ 0x1C142382;
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
		goto IL_0049;
		IL_0049:
		int result = num;
		int num2 = -1518056721;
		goto IL_0027;
		IL_0013:
		num2 = -2115840460;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xF451616Au) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = ((int)num3 * -792999151) ^ -181547737;
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
			int num = 1243654548;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10A43486u) % 3u)
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
				num = (int)(num2 * 548883730) ^ -2021444461;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num = 0;
		int num5 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num2;
			int num3;
			if (num < PlanningCards.Length)
			{
				num2 = 1888539692;
				num3 = 1888539692;
			}
			else
			{
				num2 = 197227352;
				num3 = 197227352;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x482000F2u) % 10u)
				{
				case 9u:
					num2 = (int)(num4 * 874092586) ^ -860573763;
					continue;
				case 8u:
					num2 = ((int)num4 * -399266665) ^ -1740735744;
					continue;
				case 7u:
					num2 = 1888539692;
					continue;
				case 6u:
					num5 = PlanningCards[num];
					flag = num5 == 0;
					num2 = 1743230111;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -729181691;
						num7 = -729181691;
					}
					else
					{
						num6 = -1775277824;
						num7 = -1775277824;
					}
					num2 = num6 ^ (int)(num4 * 332571338);
					continue;
				}
				case 2u:
					result = text;
					num2 = ((int)num4 * -1932918352) ^ -495017905;
					continue;
				case 1u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num5.ToString(),
						" "
					});
					num2 = 1422200720;
					continue;
				case 0u:
					num++;
					num2 = 1939185916;
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
		return new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int count = json.Count;
		int[] array = default(int[]);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -623445161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBAAF89Du) % 7u)
				{
				case 6u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -1385824568;
					continue;
				case 4u:
				{
					int num4;
					if (num3 < count)
					{
						num = -1275313908;
						num4 = -1275313908;
					}
					else
					{
						num = -288628403;
						num4 = -288628403;
					}
					continue;
				}
				case 3u:
					num = (int)(num2 * 1513624191) ^ -400783087;
					continue;
				case 2u:
					result = array;
					num = (int)(num2 * 292432645) ^ -1625756509;
					continue;
				case 1u:
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -2039636298) ^ 0xF40BCA6;
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
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = -2057867212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9FDB9A8u) % 3u)
				{
				case 1u:
					goto IL_0024;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0024:
				num = ((int)num2 * -1687239211) ^ 0x3CD02818;
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
