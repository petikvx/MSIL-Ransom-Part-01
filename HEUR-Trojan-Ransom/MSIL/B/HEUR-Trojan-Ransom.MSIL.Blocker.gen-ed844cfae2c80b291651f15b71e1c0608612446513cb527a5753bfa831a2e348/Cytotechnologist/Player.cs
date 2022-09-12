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
			int result = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			while (true)
			{
				int num2 = -1555182169;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x80E180ABu) % 13u)
					{
					case 12u:
						result = num;
						num2 = ((int)num3 * -36809780) ^ 0x23B8587F;
						continue;
					case 11u:
						num++;
						num2 = (int)(num3 * 1061705558) ^ -2080543434;
						continue;
					case 9u:
						planningCards = PlanningCards;
						num2 = ((int)num3 * -580294980) ^ 0x393BDC2F;
						continue;
					case 8u:
						num2 = ((int)num3 * -881085509) ^ -670422600;
						continue;
					case 7u:
					{
						int num7;
						if (num4 < planningCards.Length)
						{
							num2 = -511793143;
							num7 = -511793143;
						}
						else
						{
							num2 = -1597683924;
							num7 = -1597683924;
						}
						continue;
					}
					case 6u:
						num2 = -783157709;
						continue;
					case 4u:
					{
						int num5 = planningCards[num4];
						int num6;
						if (num5 > 0)
						{
							num2 = -1490244647;
							num6 = -1490244647;
						}
						else
						{
							num2 = -583189638;
							num6 = -583189638;
						}
						continue;
					}
					case 3u:
						num4++;
						num2 = ((int)num3 * -1332259077) ^ 0x413C010E;
						continue;
					case 2u:
						num2 = ((int)num3 * -1266940136) ^ -1293466146;
						continue;
					case 1u:
						num4 = 0;
						num2 = (int)(num3 * 1903121572) ^ -2144564574;
						continue;
					case 0u:
						num2 = (int)((num3 * 1030279063) ^ 0x52EB85F3);
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 1055800324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E829535u) % 12u)
				{
				case 9u:
					text = null;
					num = ((int)num2 * -257710081) ^ -1978143256;
					continue;
				case 8u:
					num = (int)(num2 * 1834774029) ^ -279745097;
					continue;
				case 7u:
					num = ((int)num2 * -1010846529) ^ 0x7B9D06BA;
					continue;
				case 6u:
					result = text;
					num = 137508482;
					continue;
				case 5u:
					flag = BaseStream == 1;
					num = 1394755510;
					continue;
				case 4u:
					text = "4461746554696D654B69";
					num = (int)((num2 * 446812161) ^ 0x5119C8E5);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -723307104;
						num6 = -723307104;
					}
					else
					{
						num5 = -650240286;
						num6 = -650240286;
					}
					num = num5 ^ (int)(num2 * 1091340161);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -651896182;
						num4 = -651896182;
					}
					else
					{
						num3 = -1823804741;
						num4 = -1823804741;
					}
					num = num3 ^ (int)(num2 * 2056592501);
					continue;
				}
				case 1u:
					text = "75624573575678556F";
					num = (int)((num2 * 211405027) ^ 0x4655F60);
					continue;
				case 0u:
					num = ((int)num2 * -941262017) ^ -456878920;
					continue;
				case 11u:
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
		int num2 = 1781669416;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1023C549u) % 4u)
			{
			case 3u:
				num2 = (int)((num3 * 1675866150) ^ 0x7B5C36D3);
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
		num2 = 23449862;
		goto IL_0027;
	}

	private Player()
	{
		while (true)
		{
			int num = 1085866619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67880DC6u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 928675835) ^ 0x7895A15B);
					continue;
				case 1u:
					num = (int)(num2 * 1113107903) ^ -1357270826;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public string PlanningCardsToString()
	{
		bool flag2 = default(bool);
		int num4 = default(int);
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -295365683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CB30395u) % 16u)
				{
				case 15u:
					flag2 = num4 == 0;
					num = ((int)num2 * -1929168963) ^ 0x55679BB;
					continue;
				case 14u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -1797960404;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -2020130620;
						num8 = -2020130620;
					}
					else
					{
						num7 = -77401329;
						num8 = -77401329;
					}
					num = num7 ^ (int)(num2 * 1996266068);
					continue;
				}
				case 12u:
					result = text;
					num = ((int)num2 * -410691156) ^ -1166643865;
					continue;
				case 11u:
					num = -1096667994;
					continue;
				case 10u:
					num3 = 0;
					num = (int)((num2 * 1503728555) ^ 0x48A597CA);
					continue;
				case 9u:
					num3++;
					num = -1989184955;
					continue;
				case 8u:
					text = " ";
					num = (int)((num2 * 1365153564) ^ 0x2907131F);
					continue;
				case 5u:
					num = ((int)num2 * -1248664468) ^ 0x4723DAF0;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1265233050;
						num6 = -1265233050;
					}
					else
					{
						num5 = -61015423;
						num6 = -61015423;
					}
					num = num5 ^ ((int)num2 * -620025534);
					continue;
				}
				case 3u:
					num4 = PlanningCards[num3];
					num = (int)(num2 * 794813614) ^ -1639489936;
					continue;
				case 2u:
					num = ((int)num2 * -1705483241) ^ -33663427;
					continue;
				case 1u:
					num = ((int)num2 * -1183152286) ^ -1725881;
					continue;
				case 0u:
					flag = num3 < PlanningCards.Length;
					num = -68772047;
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
			int num = 1656944698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DEA215Cu) % 4u)
				{
				case 2u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -1846519458) ^ -1992308659;
					continue;
				case 1u:
					num = (int)(num2 * 744968369) ^ -763631283;
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
		int count = default(int);
		int num3 = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = 422731543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D16AB34u) % 10u)
				{
				case 9u:
					count = json.Count;
					num = (int)((num2 * 722268374) ^ 0xCBBC6F1);
					continue;
				case 8u:
					num = ((int)num2 * -1360998679) ^ -632070008;
					continue;
				case 6u:
				{
					int num4;
					if (num3 < count)
					{
						num = 962877892;
						num4 = 962877892;
					}
					else
					{
						num = 1235611094;
						num4 = 1235611094;
					}
					continue;
				}
				case 5u:
					array = new int[count];
					num = (int)((num2 * 51090419) ^ 0x7B1B98AB);
					continue;
				case 4u:
					result = array;
					num = (int)((num2 * 1920071570) ^ 0x2A72085);
					continue;
				case 2u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 1571658252;
					continue;
				case 1u:
					num = (int)((num2 * 2060927457) ^ 0xD78EE16);
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -1645354687) ^ 0x4A64C7EA;
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
			int num = -947536392;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC470929Fu) % 4u)
				{
				case 3u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1451963716) ^ 0x99FE817;
					continue;
				case 0u:
					num = (int)((num2 * 1477150714) ^ 0x209EB842);
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
