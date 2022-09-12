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
			while (true)
			{
				int num3 = 1838196141;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num3 ^ 0x11A73C5Eu) % 10u)
					{
					case 8u:
						num2++;
						num3 = ((int)num4 * -1750884073) ^ 0x7BD2B45F;
						continue;
					case 7u:
						result = num;
						num3 = (int)((num4 * 1691017316) ^ 0x5A61DC5C);
						continue;
					case 5u:
						num3 = (int)((num4 * 942351730) ^ 0x7E8CB88D);
						continue;
					case 4u:
						num++;
						num3 = ((int)num4 * -1594358742) ^ 0x3CCB8B9E;
						continue;
					case 3u:
					{
						int num7;
						if (num2 < planningCards.Length)
						{
							num3 = 1517915055;
							num7 = 1517915055;
						}
						else
						{
							num3 = 1104101771;
							num7 = 1104101771;
						}
						continue;
					}
					case 2u:
						num3 = (int)((num4 * 1804311851) ^ 0x4BF254A1);
						continue;
					case 1u:
					{
						int num5 = planningCards[num2];
						int num6;
						if (num5 > 0)
						{
							num3 = 848230076;
							num6 = 848230076;
						}
						else
						{
							num3 = 171793034;
							num6 = 171793034;
						}
						continue;
					}
					case 0u:
						num3 = 894259170;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1832189011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90A62245u) % 14u)
				{
				case 13u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1967199708;
						num5 = -1967199708;
					}
					else
					{
						num4 = -60343441;
						num5 = -60343441;
					}
					num = num4 ^ (int)(num2 * 461344864);
					continue;
				}
				case 11u:
					num = ((int)num2 * -184170224) ^ 0x3AF876EC;
					continue;
				case 10u:
					text = null;
					num = ((int)num2 * -592989327) ^ 0x4AB6B0F7;
					continue;
				case 9u:
					text = "5461736B577261707065724173796E6352657375";
					num = (int)(num2 * 1958124680) ^ -1510253520;
					continue;
				case 8u:
					result = text;
					num = -1942042734;
					continue;
				case 7u:
					num = ((int)num2 * -648263713) ^ -787671284;
					continue;
				case 6u:
					text = "51793631";
					num = ((int)num2 * -710095702) ^ -93530315;
					continue;
				case 4u:
					flag = BaseStream == 0;
					num = (int)((num2 * 1342806722) ^ 0x7AF882CC);
					continue;
				case 3u:
					num = (int)((num2 * 1186236912) ^ 0x340258D0);
					continue;
				case 2u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = -1784449225;
						num3 = -1784449225;
					}
					else
					{
						num = -7701227;
						num3 = -7701227;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -753464548) ^ -274963431;
					continue;
				case 0u:
					num = ((int)num2 * -337577970) ^ 0xF784EA9;
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
		goto IL_0034;
		IL_0034:
		int result = num;
		int num2 = -1384818572;
		goto IL_0018;
		IL_0013:
		num2 = -262985182;
		goto IL_0018;
		IL_0018:
		switch ((uint)(num2 ^ -801000355) % 3u)
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
		while (true)
		{
			int num = -403801905;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89B65BC7u) % 3u)
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
				num = (int)((num2 * 314322280) ^ 0x17C01D8A);
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num3 = default(int);
		int num5 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1898693059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88568D52u) % 10u)
				{
				case 9u:
					num3++;
					num = -1855287982;
					continue;
				case 8u:
				{
					num5 = PlanningCards[num3];
					int num6;
					if (num5 != 0)
					{
						num = -667582550;
						num6 = -667582550;
					}
					else
					{
						num = -199144978;
						num6 = -199144978;
					}
					continue;
				}
				case 6u:
					num = (int)((num2 * 112702020) ^ 0x86EC8D7);
					continue;
				case 4u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num5.ToString(),
						" "
					});
					num = -1140893721;
					continue;
				case 3u:
					result = text;
					num = ((int)num2 * -1133279718) ^ 0x6241C608;
					continue;
				case 2u:
					num = (int)((num2 * 148767983) ^ 0x3614CC63);
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 742242947) ^ -1311114593;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < PlanningCards.Length)
					{
						num = -421115844;
						num4 = -421115844;
					}
					else
					{
						num = -1475020453;
						num4 = -1475020453;
					}
					continue;
				}
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
		Player result = new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
		while (true)
		{
			int num = 1979727432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35C3BC39u) % 3u)
				{
				case 1u:
					goto IL_004a;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_004a:
				num = ((int)num2 * -695966417) ^ 0x445000C8;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		bool flag = default(bool);
		int[] result = default(int[]);
		int[] array = default(int[]);
		int count = default(int);
		while (true)
		{
			int num = 1785997604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x486CF05Du) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1512972500) ^ 0x476FACE5;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1229180879) ^ 0x33B9234;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -260726030) ^ 0x3E313A94;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1840953905;
						num5 = -1840953905;
					}
					else
					{
						num4 = -125929294;
						num5 = -125929294;
					}
					num = num4 ^ ((int)num2 * -1290571762);
					continue;
				}
				case 3u:
					result = array;
					num = ((int)num2 * -625265815) ^ 0x6211BEAA;
					continue;
				case 2u:
					array[num3] = json[num3].AsInt;
					num = 2087798024;
					continue;
				case 1u:
					count = json.Count;
					array = new int[count];
					num = (int)((num2 * 1264826538) ^ 0x6DBB39BC);
					continue;
				case 0u:
					flag = num3 < count;
					num = 1483575077;
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
			int num = -1688345649;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9DFB022u) % 3u)
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
				num = (int)(num2 * 323468830) ^ -631247142;
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
