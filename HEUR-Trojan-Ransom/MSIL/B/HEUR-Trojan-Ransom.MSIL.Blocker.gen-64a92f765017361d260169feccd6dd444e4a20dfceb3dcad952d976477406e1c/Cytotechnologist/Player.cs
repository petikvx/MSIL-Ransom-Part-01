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
			int num4 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = -422336120;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA02C40F5u) % 14u)
					{
					case 13u:
						num3 = 0;
						num = (int)(num2 * 873306037) ^ -1817598630;
						continue;
					case 12u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1160874808) ^ -424611312;
						continue;
					case 11u:
						num = (int)(num2 * 1003385795) ^ -306692484;
						continue;
					case 10u:
						num = ((int)num2 * -932727) ^ -1879894326;
						continue;
					case 9u:
						num4++;
						num = ((int)num2 * -1855572296) ^ 0x27F77772;
						continue;
					case 8u:
						num3++;
						num = ((int)num2 * -1096259720) ^ 0x185F1924;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = -861274042;
							num8 = -861274042;
						}
						else
						{
							num7 = -732494459;
							num8 = -732494459;
						}
						num = num7 ^ ((int)num2 * -1446631242);
						continue;
					}
					case 5u:
					{
						int num6;
						if (num4 >= planningCards.Length)
						{
							num = -901455271;
							num6 = -901455271;
						}
						else
						{
							num = -157674579;
							num6 = -157674579;
						}
						continue;
					}
					case 3u:
						num4 = 0;
						num = ((int)num2 * -1070768160) ^ 0x6C997885;
						continue;
					case 2u:
					{
						int num5 = planningCards[num4];
						flag = num5 > 0;
						num = -1648166690;
						continue;
					}
					case 1u:
						num = -622975242;
						continue;
					case 0u:
						result = num3;
						num = ((int)num2 * -543536959) ^ -1769786768;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -21831110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87C05B2Bu) % 14u)
				{
				case 12u:
					num = (int)((num2 * 236265051) ^ 0x3CB7FE40);
					continue;
				case 11u:
					num = (int)(num2 * 1071510614) ^ -1872642870;
					continue;
				case 10u:
					num = (int)((num2 * 1802162537) ^ 0x2CE6A810);
					continue;
				case 9u:
					text = "546F6B656E697A6572537472696E67426C6F";
					num = (int)(num2 * 778025129) ^ -621837106;
					continue;
				case 8u:
					text = "65497A";
					num = (int)((num2 * 1993217474) ^ 0x2C9F7C41);
					continue;
				case 7u:
					text = null;
					num = ((int)num2 * -861632928) ^ 0x28F20849;
					continue;
				case 6u:
					flag = BaseStream == 1;
					num = -409770293;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (BaseStream == 0)
					{
						num5 = 1246986217;
						num6 = 1246986217;
					}
					else
					{
						num5 = 1292620599;
						num6 = 1292620599;
					}
					num = num5 ^ (int)(num2 * 265749298);
					continue;
				}
				case 3u:
					num = ((int)num2 * -618688157) ^ -1832374668;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 177487298;
						num4 = 177487298;
					}
					else
					{
						num3 = 224927813;
						num4 = 224927813;
					}
					num = num3 ^ (int)(num2 * 1205828918);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1968346047) ^ 0x501B2420;
					continue;
				case 0u:
					result = text;
					num = -609171922;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0022;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0049;
		IL_0048:
		num = 0;
		goto IL_0049;
		IL_0022:
		int num2 = 576089329;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x57DD7710u) % 4u)
			{
			case 3u:
				num2 = ((int)num3 * -1971446630) ^ -604582354;
				continue;
			case 2u:
				break;
			case 1u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_0049:
		result = num;
		num2 = 130464707;
		goto IL_0027;
	}

	private Player()
	{
		while (true)
		{
			int num = 2133172854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A68805Fu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 491205078) ^ 0x21286143);
					continue;
				case 1u:
					num = ((int)num2 * -352440427) ^ 0x516960F9;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num = 0;
		string result = default(string);
		int num5 = default(int);
		while (true)
		{
			int num2;
			int num3;
			if (num < PlanningCards.Length)
			{
				num2 = 85526191;
				num3 = 85526191;
			}
			else
			{
				num2 = 904195574;
				num3 = 904195574;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x3357706Du) % 9u)
				{
				case 8u:
					result = text;
					num2 = (int)(num4 * 660358815) ^ -275239901;
					continue;
				case 7u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num5.ToString(),
						" "
					});
					num2 = 208000786;
					continue;
				case 6u:
				{
					num5 = PlanningCards[num];
					int num6;
					if (num5 != 0)
					{
						num2 = 856552538;
						num6 = 856552538;
					}
					else
					{
						num2 = 1395234946;
						num6 = 1395234946;
					}
					continue;
				}
				case 4u:
					num++;
					num2 = 1069904261;
					continue;
				case 3u:
					num2 = (int)((num4 * 958536591) ^ 0x66D81E0);
					continue;
				case 2u:
					num2 = (int)(num4 * 1790022713) ^ -910859226;
					continue;
				case 0u:
					num2 = 85526191;
					continue;
				case 1u:
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
			int num = -461583736;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2D335E6u) % 3u)
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
				num = ((int)num2 * -91976695) ^ 0x74194AE8;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] array = default(int[]);
		int num5 = default(int);
		int count = default(int);
		bool flag = default(bool);
		int[] result = default(int[]);
		while (true)
		{
			int num = -895894787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB6085EA8u) % 10u)
				{
				case 9u:
					array[num5] = json[num5].AsInt;
					num = -2124525755;
					continue;
				case 7u:
					count = json.Count;
					array = new int[count];
					num = ((int)num2 * -531561957) ^ 0x1143F5BA;
					continue;
				case 6u:
					num = (int)(num2 * 327748263) ^ -714461980;
					continue;
				case 5u:
					num5++;
					num = ((int)num2 * -976321166) ^ -198402869;
					continue;
				case 3u:
					flag = num5 < count;
					num = -25673858;
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -1416254146) ^ 0x480C7948;
					continue;
				case 1u:
					num5 = 0;
					num = (int)((num2 * 983466786) ^ 0x72D5972B);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -251975103;
						num4 = -251975103;
					}
					else
					{
						num3 = -1167783022;
						num4 = -1167783022;
					}
					num = num3 ^ (int)(num2 * 593864134);
					continue;
				}
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
			int num = -375369669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AEBC9F2u) % 4u)
				{
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -546198412) ^ 0x4CA3EE8E;
					continue;
				case 0u:
					num = (int)(num2 * 1751669472) ^ -1100735447;
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
