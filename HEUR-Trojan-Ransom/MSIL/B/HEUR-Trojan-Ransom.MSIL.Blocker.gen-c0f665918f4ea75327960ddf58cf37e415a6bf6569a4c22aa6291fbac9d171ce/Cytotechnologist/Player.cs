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
			int result = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int[] planningCards = default(int[]);
			int num5 = default(int);
			while (true)
			{
				int num = 1835267684;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A014337u) % 11u)
					{
					case 10u:
						result = num3;
						num = (int)((num2 * 615358757) ^ 0x61995049);
						continue;
					case 8u:
					{
						int num8;
						if (num4 >= planningCards.Length)
						{
							num = 2059964360;
							num8 = 2059964360;
						}
						else
						{
							num = 2100160746;
							num8 = 2100160746;
						}
						continue;
					}
					case 7u:
						num4++;
						num = 1758267543;
						continue;
					case 6u:
						num5 = planningCards[num4];
						num = 78743187;
						continue;
					case 5u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1663471917) ^ 0x741F6A28;
						continue;
					case 3u:
					{
						int num6;
						int num7;
						if (num5 > 0)
						{
							num6 = -448693320;
							num7 = -448693320;
						}
						else
						{
							num6 = -509373598;
							num7 = -509373598;
						}
						num = num6 ^ (int)(num2 * 833856085);
						continue;
					}
					case 2u:
						num3 = 0;
						num = ((int)num2 * -1254723663) ^ 0xEC25F68;
						continue;
					case 1u:
						num4 = 0;
						num = (int)((num2 * 856695887) ^ 0x2D5C0E92);
						continue;
					case 0u:
						num3++;
						num = ((int)num2 * -1174307593) ^ -522003653;
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 146415467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4AEF9098u) % 14u)
				{
				case 13u:
					text = "65756D7333";
					num = (int)(num2 * 1821531312) ^ -374590078;
					continue;
				case 11u:
					num = (int)(num2 * 620262250) ^ -1399231493;
					continue;
				case 10u:
					num = ((int)num2 * -628459376) ^ 0x37D5A46D;
					continue;
				case 9u:
					text = "52756E74696D65417373656D62";
					num = ((int)num2 * -1473087704) ^ 0x62200EAB;
					continue;
				case 8u:
					num = (int)((num2 * 876308506) ^ 0x134A3A06);
					continue;
				case 7u:
					flag2 = BaseStream == 1;
					num = 1298928087;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1803280067;
						num6 = 1803280067;
					}
					else
					{
						num5 = 461485155;
						num6 = 461485155;
					}
					num = num5 ^ ((int)num2 * -2016935497);
					continue;
				}
				case 5u:
					result = text;
					num = 1423722234;
					continue;
				case 4u:
					num = (int)((num2 * 487217938) ^ 0x30764DE1);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 1308924667;
						num4 = 1308924667;
					}
					else
					{
						num3 = 1702488880;
						num4 = 1702488880;
					}
					num = num3 ^ ((int)num2 * -1911884597);
					continue;
				}
				case 2u:
					flag = BaseStream == 0;
					num = ((int)num2 * -1519707656) ^ 0x37B59E2;
					continue;
				case 1u:
					text = null;
					num = ((int)num2 * -720987129) ^ -1672816051;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = 1518637791;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x3632887Eu) % 4u)
				{
				case 2u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -602121013) ^ -2077992557;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = 925479950;
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
			int num = 555617920;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6604778Fu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2057522696) ^ 0x70E4EC6E;
					continue;
				case 1u:
					num = ((int)num2 * -132729387) ^ 0x65B766DC;
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
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		while (true)
		{
			int num = 1885570620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x728B1BDDu) % 15u)
				{
				case 14u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 852073122;
						num8 = 852073122;
					}
					else
					{
						num7 = 2138211469;
						num8 = 2138211469;
					}
					num = num7 ^ (int)(num2 * 838592764);
					continue;
				}
				case 13u:
					result = text;
					num = (int)((num2 * 811882718) ^ 0x680C48B6);
					continue;
				case 12u:
					num = (int)((num2 * 632284184) ^ 0x7F40D75B);
					continue;
				case 11u:
					num = (int)((num2 * 2100634914) ^ 0x1FE81BC0);
					continue;
				case 10u:
					num = (int)(num2 * 1115853802) ^ -2133460352;
					continue;
				case 8u:
					num = (int)(num2 * 577196178) ^ -1301153979;
					continue;
				case 7u:
					num3++;
					num = 1821119602;
					continue;
				case 6u:
					flag2 = num4 == 0;
					num = ((int)num2 * -1899495523) ^ 0x3E2A74F5;
					continue;
				case 4u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 1854628722;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1159844249;
						num6 = -1159844249;
					}
					else
					{
						num5 = -1241860026;
						num6 = -1241860026;
					}
					num = num5 ^ ((int)num2 * -1983477219);
					continue;
				}
				case 2u:
					flag = num3 < PlanningCards.Length;
					num = 740175091;
					continue;
				case 1u:
					text = " ";
					num3 = 0;
					num = ((int)num2 * -2071039345) ^ -625407609;
					continue;
				case 0u:
					num4 = PlanningCards[num3];
					num = 1812565297;
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
		int num3 = default(int);
		int[] result = default(int[]);
		int[] array = default(int[]);
		int count = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -554060736;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A661B5Au) % 11u)
				{
				case 10u:
					num3++;
					num = ((int)num2 * -1237602142) ^ -1553136540;
					continue;
				case 9u:
					num = ((int)num2 * -1643854726) ^ 0x28FCD31D;
					continue;
				case 7u:
					result = array;
					num = (int)((num2 * 816920896) ^ 0x1D3961D);
					continue;
				case 6u:
					array = new int[count];
					num = (int)((num2 * 1737701471) ^ 0x1A4ECBFA);
					continue;
				case 4u:
					count = json.Count;
					num = (int)((num2 * 370651817) ^ 0x3B296A4B);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -542916431;
						num5 = -542916431;
					}
					else
					{
						num4 = -159725890;
						num5 = -159725890;
					}
					num = num4 ^ ((int)num2 * -856645918);
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)(num2 * 1547969573) ^ -2126457219;
					continue;
				case 1u:
					array[num3] = json[num3].AsInt;
					num = -1845190742;
					continue;
				case 0u:
					flag = num3 < count;
					num = -640798963;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1824784689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78146FAAu) % 4u)
				{
				case 3u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 26228273) ^ -569926499;
					continue;
				case 0u:
					num = ((int)num2 * -1438203475) ^ -1932180317;
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
