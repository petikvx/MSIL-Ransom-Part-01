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
			int num7 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num3 = 179617258;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num3 ^ 0x31381CC5u) % 11u)
					{
					case 10u:
						num7 = planningCards[num2];
						num3 = 482315340;
						continue;
					case 8u:
						num++;
						num3 = (int)((num4 * 315973596) ^ 0x5BFACFD2);
						continue;
					case 7u:
						flag = num7 > 0;
						num3 = (int)((num4 * 2022687780) ^ 0xDD6AA2F);
						continue;
					case 6u:
						num3 = ((int)num4 * -1898653716) ^ -1449981381;
						continue;
					case 4u:
						num2++;
						num3 = (int)(num4 * 1149665358) ^ -140789493;
						continue;
					case 3u:
					{
						int num8;
						if (num2 < planningCards.Length)
						{
							num3 = 31169982;
							num8 = 31169982;
						}
						else
						{
							num3 = 1086944654;
							num8 = 1086944654;
						}
						continue;
					}
					case 2u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 1230595060;
							num6 = 1230595060;
						}
						else
						{
							num5 = 852950014;
							num6 = 852950014;
						}
						num3 = num5 ^ ((int)num4 * -229781301);
						continue;
					}
					case 1u:
						num3 = 839663931;
						continue;
					case 0u:
						result = num;
						num3 = ((int)num4 * -1192913532) ^ 0x6613B37C;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1195371545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B823AFBu) % 12u)
				{
				case 11u:
					text = "466978656453697A654C69";
					num = (int)(num2 * 952450754) ^ -790891812;
					continue;
				case 9u:
					result = text;
					num = 658980891;
					continue;
				case 8u:
					num = ((int)num2 * -607997754) ^ 0x142A9B4C;
					continue;
				case 7u:
					num = ((int)num2 * -1684366354) ^ -1596820163;
					continue;
				case 6u:
					flag = BaseStream == 1;
					num = 1189487438;
					continue;
				case 5u:
					num = ((int)num2 * -1431336428) ^ -1793940058;
					continue;
				case 4u:
					num = ((int)num2 * -1664007665) ^ -261361808;
					continue;
				case 2u:
				{
					text = null;
					int num5;
					int num6;
					if (BaseStream != 0)
					{
						num5 = -348420331;
						num6 = -348420331;
					}
					else
					{
						num5 = -1095558813;
						num6 = -1095558813;
					}
					num = num5 ^ (int)(num2 * 573782080);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 452120138;
						num4 = 452120138;
					}
					else
					{
						num3 = 250137708;
						num4 = 250137708;
					}
					num = num3 ^ ((int)num2 * -1365351272);
					continue;
				}
				case 0u:
					text = "544772";
					num = (int)((num2 * 258404282) ^ 0x2CD3107A);
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

	public int PlannedForCard(int cardTypeIndex)
	{
		if (PlanningCards.Length == 0)
		{
			goto IL_0013;
		}
		int num = PlanningCards[cardTypeIndex];
		goto IL_0034;
		IL_0033:
		num = 0;
		goto IL_0034;
		IL_0013:
		int num2 = 159270018;
		goto IL_0018;
		IL_0018:
		int result = default(int);
		switch ((uint)(num2 ^ 0x794A730A) % 3u)
		{
		case 0u:
			break;
		case 1u:
			goto IL_0033;
		default:
			return result;
		}
		goto IL_0013;
		IL_0034:
		result = num;
		num2 = 994215180;
		goto IL_0018;
	}

	private Player()
	{
		while (true)
		{
			int num = -1138272352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF11672C6u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 561837355) ^ -745247091;
					continue;
				case 1u:
					num = (int)(num2 * 1997045968) ^ -918828422;
					continue;
				default:
					return;
				case 3u:
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
		string text = default(string);
		int num6 = default(int);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -797563373;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCDF55FBu) % 13u)
				{
				case 12u:
					num = (int)(num2 * 49610796) ^ -1494106584;
					continue;
				case 11u:
					text = " ";
					num6 = 0;
					num = (int)(num2 * 1067728310) ^ -1011003258;
					continue;
				case 10u:
					num = ((int)num2 * -2093212100) ^ 0x417263C0;
					continue;
				case 8u:
					num3 = PlanningCards[num6];
					num = -805896112;
					continue;
				case 7u:
					num = (int)((num2 * 1634306927) ^ 0x3E0EBBB);
					continue;
				case 6u:
					result = text;
					num = (int)((num2 * 802042801) ^ 0x61212982);
					continue;
				case 5u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num6],
						"x",
						num3.ToString(),
						" "
					});
					num = -825419681;
					continue;
				case 4u:
					num6++;
					num = -87025000;
					continue;
				case 3u:
				{
					int num7;
					if (num6 >= PlanningCards.Length)
					{
						num = -1429027647;
						num7 = -1429027647;
					}
					else
					{
						num = -555790619;
						num7 = -555790619;
					}
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (num3 != 0)
					{
						num4 = 877882883;
						num5 = 877882883;
					}
					else
					{
						num4 = 674335596;
						num5 = 674335596;
					}
					num = num4 ^ ((int)num2 * -1797041865);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1087117580) ^ 0xE95DBA6;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 929711749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D04FD12u) % 4u)
				{
				case 3u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = (int)((num2 * 1450258180) ^ 0x277EE893);
					continue;
				case 1u:
					num = (int)((num2 * 1459608198) ^ 0xDC12E0A);
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
		int count = json.Count;
		int[] array = new int[count];
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -1311969268;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95307AD6u) % 7u)
				{
				case 6u:
				{
					int num4;
					if (num3 < count)
					{
						num = -999125511;
						num4 = -999125511;
					}
					else
					{
						num = -1098176642;
						num4 = -1098176642;
					}
					continue;
				}
				case 5u:
					result = array;
					num = (int)(num2 * 1629141246) ^ -1060409587;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -2062935302) ^ -1897464956;
					continue;
				case 2u:
					array[num3] = json[num3].AsInt;
					num = -1688147575;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 684018976) ^ -1213364734;
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
			int num = -1244457716;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCF0D955u) % 3u)
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
				result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
				num = (int)(num2 * 769692254) ^ -691011988;
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
