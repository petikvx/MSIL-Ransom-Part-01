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
			int[] planningCards = PlanningCards;
			int num2 = 0;
			int result = default(int);
			int num5 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num3 = -1435409461;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num3 ^ 0xDEFF6D7Du) % 13u)
					{
					case 12u:
						num2++;
						num3 = (int)((num4 * 877951236) ^ 0x2504AE36);
						continue;
					case 11u:
						num3 = ((int)num4 * -1211043816) ^ -1775329219;
						continue;
					case 10u:
						num++;
						num3 = (int)((num4 * 1721567934) ^ 0x7A6CD2B0);
						continue;
					case 9u:
						num3 = -273123999;
						continue;
					case 8u:
					{
						int num8;
						if (num2 < planningCards.Length)
						{
							num3 = -528509395;
							num8 = -528509395;
						}
						else
						{
							num3 = -385554288;
							num8 = -385554288;
						}
						continue;
					}
					case 6u:
						result = num;
						num3 = ((int)num4 * -1833717874) ^ 0x4F69DE26;
						continue;
					case 5u:
						num3 = ((int)num4 * -1962418883) ^ 0x7C33AD18;
						continue;
					case 3u:
						num5 = planningCards[num2];
						num3 = -570048278;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (flag)
						{
							num6 = -330703612;
							num7 = -330703612;
						}
						else
						{
							num6 = -1824824371;
							num7 = -1824824371;
						}
						num3 = num6 ^ ((int)num4 * -978691855);
						continue;
					}
					case 1u:
						num3 = ((int)num4 * -538067794) ^ 0x1D763B1F;
						continue;
					case 0u:
						flag = num5 > 0;
						num3 = ((int)num4 * -1619637948) ^ 0x1C2FEE58;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -229063867;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x824CD523u) % 11u)
				{
				case 10u:
					result = text;
					num = -856046396;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 655360296;
						num6 = 655360296;
					}
					else
					{
						num5 = 1890230651;
						num6 = 1890230651;
					}
					num = num5 ^ ((int)num2 * -1388004383);
					continue;
				}
				case 8u:
					num = ((int)num2 * -2101929789) ^ 0x4A4FAED5;
					continue;
				case 7u:
					text = "38685975";
					num = ((int)num2 * -282345656) ^ -285040096;
					continue;
				case 6u:
					text = null;
					num = ((int)num2 * -1360971565) ^ 0x1FE85C49;
					continue;
				case 3u:
					flag = BaseStream == 1;
					num = -1403654120;
					continue;
				case 2u:
					num = ((int)num2 * -2000916817) ^ -1502890825;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -1780983595;
						num4 = -1780983595;
					}
					else
					{
						num3 = -367913238;
						num4 = -367913238;
					}
					num = num3 ^ ((int)num2 * -1062054889);
					continue;
				}
				case 0u:
					text = "5665727369";
					num = (int)(num2 * 1247191175) ^ -541441965;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0049;
		IL_0048:
		num = 0;
		goto IL_0049;
		IL_0013:
		int num2 = 1651046093;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x772793ACu) % 4u)
			{
			case 3u:
				break;
			case 2u:
				num2 = (int)((num3 * 1346751069) ^ 0x2D192532);
				continue;
			case 1u:
				goto IL_0048;
			default:
				return result;
			}
			break;
		}
		goto IL_0013;
		IL_0049:
		result = num;
		num2 = 845773242;
		goto IL_0027;
	}

	private Player()
	{
		while (true)
		{
			int num = -1621033415;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC23DE4Eu) % 3u)
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
				num = (int)(num2 * 2056201051) ^ -158004525;
			}
		}
	}

	public string PlanningCardsToString()
	{
		int num4 = default(int);
		int num3 = default(int);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1999754499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1B97501u) % 13u)
				{
				case 12u:
					num = (int)((num2 * 561709743) ^ 0x7CC73793);
					continue;
				case 11u:
				{
					num4 = PlanningCards[num3];
					int num6;
					int num7;
					if (num4 == 0)
					{
						num6 = -1112197156;
						num7 = -1112197156;
					}
					else
					{
						num6 = -352546845;
						num7 = -352546845;
					}
					num = num6 ^ ((int)num2 * -336090481);
					continue;
				}
				case 9u:
				{
					int num5;
					if (num3 >= PlanningCards.Length)
					{
						num = -80142890;
						num5 = -80142890;
					}
					else
					{
						num = -1063090882;
						num5 = -1063090882;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -634005382) ^ -329840054;
					continue;
				case 7u:
					num = -763197863;
					continue;
				case 6u:
					text = " ";
					num = ((int)num2 * -714136972) ^ 0x68F725E2;
					continue;
				case 4u:
					result = text;
					num = (int)((num2 * 850675157) ^ 0x295F90FB);
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -998496073) ^ 0x5769BDE1;
					continue;
				case 2u:
					num3++;
					num = -576617164;
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
					num = -1068375297;
					continue;
				case 0u:
					num = ((int)num2 * -1709011744) ^ 0x21A78751;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = -1327733618;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB137EB7Fu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 695535765) ^ 0x572DC71A);
					continue;
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -664515239) ^ -315876496;
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
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		int num3 = default(int);
		while (true)
		{
			int num = 389816886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x241918C6u) % 9u)
				{
				case 8u:
					count = json.Count;
					array = new int[count];
					num = (int)((num2 * 48079630) ^ 0x3EA0180B);
					continue;
				case 7u:
					result = array;
					num = (int)(num2 * 80957806) ^ -1210542485;
					continue;
				case 6u:
					num = ((int)num2 * -1342952454) ^ -59015358;
					continue;
				case 5u:
					num3 = 0;
					num = (int)(num2 * 1822866344) ^ -367577200;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= count)
					{
						num = 413885593;
						num4 = 413885593;
					}
					else
					{
						num = 2039912649;
						num4 = 2039912649;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -1723977143) ^ -602748338;
					continue;
				case 1u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = 1880168960;
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
			int num = 1845904117;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BD242E0u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
				num = (int)((num2 * 359960605) ^ 0x1C6442C0);
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
