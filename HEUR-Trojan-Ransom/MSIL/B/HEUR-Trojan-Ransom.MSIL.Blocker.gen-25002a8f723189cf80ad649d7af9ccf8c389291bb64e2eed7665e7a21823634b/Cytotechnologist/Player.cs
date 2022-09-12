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
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num2 = 857722038;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x55549F08u) % 12u)
					{
					case 11u:
						num4++;
						num2 = ((int)num3 * -1465365831) ^ -1433783314;
						continue;
					case 9u:
					{
						int num8;
						if (num4 < planningCards.Length)
						{
							num2 = 210692577;
							num8 = 210692577;
						}
						else
						{
							num2 = 2012992634;
							num8 = 2012992634;
						}
						continue;
					}
					case 7u:
						planningCards = PlanningCards;
						num4 = 0;
						num2 = ((int)num3 * -1740288106) ^ 0x64E08186;
						continue;
					case 6u:
						num2 = ((int)num3 * -1408261690) ^ 0x5AB08ADF;
						continue;
					case 5u:
						num2 = 696428283;
						continue;
					case 4u:
						num++;
						num2 = (int)(num3 * 939900984) ^ -1881132655;
						continue;
					case 3u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = -2129572954;
							num7 = -2129572954;
						}
						else
						{
							num6 = -753772029;
							num7 = -753772029;
						}
						num2 = num6 ^ (int)(num3 * 202914366);
						continue;
					}
					case 2u:
						result = num;
						num2 = (int)(num3 * 979310841) ^ -1666894340;
						continue;
					case 1u:
					{
						int num5 = planningCards[num4];
						flag = num5 > 0;
						num2 = 1675550223;
						continue;
					}
					case 0u:
						num2 = (int)((num3 * 1815107135) ^ 0x785DA881);
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
			int num = 1115146101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17CB600Bu) % 12u)
				{
				case 10u:
					result = text;
					num = 1666110187;
					continue;
				case 9u:
					text = "504D";
					num = (int)((num2 * 2014588604) ^ 0x6BC37B9);
					continue;
				case 8u:
				{
					int num5;
					if (BaseStream == 1)
					{
						num = 263890331;
						num5 = 263890331;
					}
					else
					{
						num = 1662219969;
						num5 = 1662219969;
					}
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1893468478;
						num4 = 1893468478;
					}
					else
					{
						num3 = 366767387;
						num4 = 366767387;
					}
					num = num3 ^ ((int)num2 * -1294017469);
					continue;
				}
				case 6u:
					num = (int)((num2 * 39844483) ^ 0x4181806B);
					continue;
				case 5u:
					num = ((int)num2 * -2023040303) ^ 0x72D42AB4;
					continue;
				case 4u:
					text = "507576";
					num = (int)((num2 * 35364843) ^ 0x35FF235E);
					continue;
				case 2u:
					text = null;
					num = (int)(num2 * 1699689352) ^ -1227352438;
					continue;
				case 1u:
					flag = BaseStream == 0;
					num = (int)((num2 * 1368922073) ^ 0x71DD7F9);
					continue;
				case 0u:
					num = ((int)num2 * -2090901968) ^ -2099601756;
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
		int num2 = 919053164;
		goto IL_0027;
		IL_0013:
		num2 = 1551361691;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1E8DAA09u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = ((int)num3 * -576285672) ^ -580288383;
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
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		bool flag2 = default(bool);
		int num3 = default(int);
		string result = default(string);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 196166457;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33D6CC6Cu) % 14u)
				{
				case 12u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1806736631;
						num8 = 1806736631;
					}
					else
					{
						num7 = 1573599571;
						num8 = 1573599571;
					}
					num = num7 ^ (int)(num2 * 922810873);
					continue;
				}
				case 11u:
					num = ((int)num2 * -1796778781) ^ 0x566921EF;
					continue;
				case 10u:
					num = 283036208;
					continue;
				case 9u:
					num3 = 0;
					num = (int)((num2 * 623629720) ^ 0x6B0CAEE6);
					continue;
				case 8u:
					num3++;
					num = 1309819610;
					continue;
				case 7u:
					result = text;
					num = (int)(num2 * 1736016797) ^ -1132823345;
					continue;
				case 6u:
					num4 = PlanningCards[num3];
					num = (int)((num2 * 380895741) ^ 0x7DE06C73);
					continue;
				case 5u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 1794044004;
					continue;
				case 4u:
					num = (int)(num2 * 1465784954) ^ -1046797426;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -52991422;
						num6 = -52991422;
					}
					else
					{
						num5 = -1152218271;
						num6 = -1152218271;
					}
					num = num5 ^ ((int)num2 * -1663781941);
					continue;
				}
				case 1u:
					flag2 = num4 == 0;
					num = (int)((num2 * 723523000) ^ 0x6A5A6C72);
					continue;
				case 0u:
					flag = num3 < PlanningCards.Length;
					num = 396392723;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = -1860207291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDC37E87u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 161101979) ^ -1810241565;
					continue;
				case 2u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -289922123) ^ -573928850;
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
		int[] array = default(int[]);
		int num3 = default(int);
		int count = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = 144197958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38D6F22Au) % 8u)
				{
				case 6u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 733471335;
					continue;
				case 5u:
				{
					int num4;
					if (num3 < count)
					{
						num = 430062844;
						num4 = 430062844;
					}
					else
					{
						num = 1165208248;
						num4 = 1165208248;
					}
					continue;
				}
				case 4u:
					count = json.Count;
					num = ((int)num2 * -108391156) ^ -352557637;
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -1828905010) ^ -2069327647;
					continue;
				case 1u:
					array = new int[count];
					num = (int)(num2 * 1071959167) ^ -1886855011;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1299875020) ^ 0x1D1F00C7;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 14265779;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24329421u) % 4u)
				{
				case 2u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1174498852) ^ -552753616;
					continue;
				case 1u:
					num = ((int)num2 * -1584780311) ^ -2096923209;
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
