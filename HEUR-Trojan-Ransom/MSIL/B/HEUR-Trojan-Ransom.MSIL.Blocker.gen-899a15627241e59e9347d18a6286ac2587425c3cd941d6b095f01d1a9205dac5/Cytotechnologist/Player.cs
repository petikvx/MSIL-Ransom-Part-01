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
			bool flag = default(bool);
			int num5 = default(int);
			int result = default(int);
			while (true)
			{
				int num = 147218282;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x583CFE26u) % 14u)
					{
					case 13u:
					{
						int num8;
						if (num4 < planningCards.Length)
						{
							num = 1519509323;
							num8 = 1519509323;
						}
						else
						{
							num = 26742544;
							num8 = 26742544;
						}
						continue;
					}
					case 12u:
						num3 = 0;
						planningCards = PlanningCards;
						num = (int)((num2 * 902407254) ^ 0x734BDE2E);
						continue;
					case 11u:
						num = 1287190848;
						continue;
					case 10u:
						flag = num5 > 0;
						num = ((int)num2 * -1666852773) ^ 0x75C77F13;
						continue;
					case 8u:
						num4++;
						num = ((int)num2 * -152328457) ^ 0x2E6B907D;
						continue;
					case 7u:
						num = (int)(num2 * 279915671) ^ -1373083998;
						continue;
					case 6u:
						num4 = 0;
						num = ((int)num2 * -1308479325) ^ -463875787;
						continue;
					case 5u:
					{
						int num6;
						int num7;
						if (!flag)
						{
							num6 = 87696874;
							num7 = 87696874;
						}
						else
						{
							num6 = 1586811719;
							num7 = 1586811719;
						}
						num = num6 ^ ((int)num2 * -755326817);
						continue;
					}
					case 4u:
						num3++;
						num = ((int)num2 * -276086469) ^ 0x1C3156FF;
						continue;
					case 3u:
						num = ((int)num2 * -2072834865) ^ -1095306864;
						continue;
					case 1u:
						num5 = planningCards[num4];
						num = 1951849146;
						continue;
					case 0u:
						result = num3;
						num = (int)((num2 * 1129717416) ^ 0x776041DD);
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = null;
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -800400198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9631B003u) % 10u)
				{
				case 9u:
				{
					int num5;
					if (BaseStream == 1)
					{
						num = -1505231649;
						num5 = -1505231649;
					}
					else
					{
						num = -670837676;
						num5 = -670837676;
					}
					continue;
				}
				case 7u:
					num = (int)((num2 * 1435897934) ^ 0xCB95853);
					continue;
				case 6u:
					num = ((int)num2 * -848190583) ^ -320422167;
					continue;
				case 5u:
					result = text;
					num = -1509215355;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 694981786;
						num4 = 694981786;
					}
					else
					{
						num3 = 1888292004;
						num4 = 1888292004;
					}
					num = num3 ^ ((int)num2 * -221735469);
					continue;
				}
				case 2u:
					text = "5866754742327A75";
					num = ((int)num2 * -2138577790) ^ 0x588923EC;
					continue;
				case 1u:
					flag = BaseStream == 0;
					num = (int)(num2 * 187128292) ^ -202583385;
					continue;
				case 0u:
					text = "45766964656E6365547970654465736372697074";
					num = ((int)num2 * -343060729) ^ -2055027146;
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
			goto IL_0022;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0049;
		IL_0048:
		num = 0;
		goto IL_0049;
		IL_0022:
		int num2 = -1115877936;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xD71A6266u) % 4u)
			{
			case 3u:
				num2 = ((int)num3 * -248322677) ^ -2074608458;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_0049:
		result = num;
		num2 = -173508595;
		goto IL_0027;
	}

	private Player()
	{
	}

	public string PlanningCardsToString()
	{
		bool flag = default(bool);
		string result = default(string);
		string text = default(string);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1399805122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CA94F19u) % 12u)
				{
				case 11u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = 467219191;
						num7 = 467219191;
					}
					else
					{
						num6 = 1339980816;
						num7 = 1339980816;
					}
					num = num6 ^ (int)(num2 * 1258535889);
					continue;
				}
				case 10u:
					result = text;
					num = (int)(num2 * 1382762484) ^ -986219763;
					continue;
				case 9u:
				{
					int num5;
					if (num3 < PlanningCards.Length)
					{
						num = 1299542554;
						num5 = 1299542554;
					}
					else
					{
						num = 713239215;
						num5 = 713239215;
					}
					continue;
				}
				case 8u:
					num4 = PlanningCards[num3];
					flag = num4 == 0;
					num = ((int)num2 * -1254478779) ^ 0x6CE5E53A;
					continue;
				case 7u:
					text = " ";
					num3 = 0;
					num = (int)(num2 * 2013583605) ^ -1087525841;
					continue;
				case 5u:
					num3++;
					num = 413719736;
					continue;
				case 3u:
					num = 1638064685;
					continue;
				case 2u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 1723511448;
					continue;
				case 1u:
					num = ((int)num2 * -1918341425) ^ 0x6C8F628F;
					continue;
				case 0u:
					num = (int)(num2 * 2010677714) ^ -33068843;
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
		int[] result = default(int[]);
		int[] array = default(int[]);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1806832076;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC413AD54u) % 10u)
				{
				case 9u:
					result = array;
					num = ((int)num2 * -1204944875) ^ -651490722;
					continue;
				case 8u:
					array[num3] = json[num3].AsInt;
					num = -658792131;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 2105883400;
						num5 = 2105883400;
					}
					else
					{
						num4 = 1214829501;
						num5 = 1214829501;
					}
					num = num4 ^ (int)(num2 * 1101266244);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1654702296) ^ -666292506;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 2136481027) ^ 0x2D7D7949);
					continue;
				case 2u:
					array = new int[count];
					num = (int)((num2 * 1558993729) ^ 0x73CD39F3);
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 207696477) ^ 0x4D42CA39);
					continue;
				case 0u:
					flag = num3 < count;
					num = -1360711313;
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
			int num = 1836294818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40CB808Bu) % 3u)
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
				num = ((int)num2 * -640920373) ^ -1992505680;
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
