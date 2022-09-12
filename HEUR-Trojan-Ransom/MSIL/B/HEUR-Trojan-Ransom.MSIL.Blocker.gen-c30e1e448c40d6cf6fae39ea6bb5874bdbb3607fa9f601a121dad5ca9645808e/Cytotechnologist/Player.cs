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
			int num6 = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			int num3 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -1482657682;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE998FEEu) % 13u)
					{
					case 12u:
					{
						int num7;
						int num8;
						if (num6 > 0)
						{
							num7 = 758546278;
							num8 = 758546278;
						}
						else
						{
							num7 = 473430516;
							num8 = 473430516;
						}
						num = num7 ^ (int)(num2 * 1377180425);
						continue;
					}
					case 11u:
						num = ((int)num2 * -1079528236) ^ 0x622E99F6;
						continue;
					case 10u:
						num6 = planningCards[num4];
						num = -1862990176;
						continue;
					case 9u:
						planningCards = PlanningCards;
						num4 = 0;
						num = (int)(num2 * 1723948929) ^ -1572418008;
						continue;
					case 8u:
						num3 = 0;
						num = ((int)num2 * -99065599) ^ -341560189;
						continue;
					case 6u:
						num = -942748955;
						continue;
					case 5u:
						num4++;
						num = (int)(num2 * 884283120) ^ -359117803;
						continue;
					case 4u:
					{
						int num5;
						if (num4 < planningCards.Length)
						{
							num = -369674362;
							num5 = -369674362;
						}
						else
						{
							num = -1217186610;
							num5 = -1217186610;
						}
						continue;
					}
					case 3u:
						result = num3;
						num = ((int)num2 * -2032711926) ^ 0xAB5A84F;
						continue;
					case 1u:
						num3++;
						num = ((int)num2 * -350123275) ^ -509620096;
						continue;
					case 0u:
						num = ((int)num2 * -446438328) ^ -315881533;
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
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1941892844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D57F777u) % 12u)
				{
				case 11u:
					text = null;
					num = (int)(num2 * 1108666389) ^ -2140094528;
					continue;
				case 10u:
					num = ((int)num2 * -128427959) ^ -37458912;
					continue;
				case 9u:
				{
					int num5;
					if (BaseStream != 1)
					{
						num = 2096428048;
						num5 = 2096428048;
					}
					else
					{
						num = 1924646011;
						num5 = 1924646011;
					}
					continue;
				}
				case 8u:
					flag = BaseStream == 0;
					num = (int)(num2 * 717412472) ^ -617322012;
					continue;
				case 7u:
					result = text;
					num = 1213339949;
					continue;
				case 5u:
					num = (int)((num2 * 279533702) ^ 0x1C44246);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1653766807;
						num4 = -1653766807;
					}
					else
					{
						num3 = -759322314;
						num4 = -759322314;
					}
					num = num3 ^ ((int)num2 * -500305523);
					continue;
				}
				case 2u:
					text = "4D6574686F644275696C64";
					num = ((int)num2 * -677096135) ^ 0x7048ACF;
					continue;
				case 1u:
					num = ((int)num2 * -1644481276) ^ 0x751CD754;
					continue;
				case 0u:
					text = "4D70643043716B4E76";
					num = (int)(num2 * 557642141) ^ -129930566;
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
		int num2 = 1514553044;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x2C9C763Du) % 4u)
			{
			case 3u:
				break;
			case 0u:
				num2 = ((int)num3 * -1636873110) ^ -1319640289;
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
		num2 = 2121989917;
		goto IL_0027;
	}

	private Player()
	{
		while (true)
		{
			int num = -708586874;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE80C7884u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 35414569) ^ -153739909;
					continue;
				case 1u:
					num = ((int)num2 * -1624149842) ^ 0x7656ADE2;
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
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		int num4 = default(int);
		while (true)
		{
			int num = -419002609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5D3A1C3u) % 11u)
				{
				case 10u:
				{
					int num7;
					if (num3 >= PlanningCards.Length)
					{
						num = -397419256;
						num7 = -397419256;
					}
					else
					{
						num = -180990658;
						num7 = -180990658;
					}
					continue;
				}
				case 9u:
					result = text;
					num = (int)(num2 * 1624213389) ^ -754998989;
					continue;
				case 8u:
					num = (int)(num2 * 426183883) ^ -1771795828;
					continue;
				case 7u:
				{
					num4 = PlanningCards[num3];
					int num5;
					int num6;
					if (num4 != 0)
					{
						num5 = 220702730;
						num6 = 220702730;
					}
					else
					{
						num5 = 1825837173;
						num6 = 1825837173;
					}
					num = num5 ^ ((int)num2 * -301898487);
					continue;
				}
				case 5u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -261934952;
					continue;
				case 4u:
					num3++;
					num = -956638324;
					continue;
				case 3u:
					num = ((int)num2 * -1454218636) ^ 0x394758E8;
					continue;
				case 1u:
					text = " ";
					num3 = 0;
					num = ((int)num2 * -1652901120) ^ -1795900498;
					continue;
				case 0u:
					num = -966681607;
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
		Player result = default(Player);
		while (true)
		{
			int num = -399598422;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C7E7663u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1490385277) ^ 0x38281C06;
					continue;
				case 1u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = (int)(num2 * 298288903) ^ -959291794;
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
		bool flag = default(bool);
		int num3 = default(int);
		int count = default(int);
		int[] result = default(int[]);
		int[] array = default(int[]);
		while (true)
		{
			int num = -1017562727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9EFF26E7u) % 9u)
				{
				case 8u:
					flag = num3 < count;
					num = -2041170388;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1967884674;
						num5 = 1967884674;
					}
					else
					{
						num4 = 585589991;
						num5 = 585589991;
					}
					num = num4 ^ (int)(num2 * 1529703855);
					continue;
				}
				case 6u:
					result = array;
					num = (int)(num2 * 865550120) ^ -627299566;
					continue;
				case 4u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -2058612771;
					continue;
				case 3u:
					num = (int)(num2 * 388682302) ^ -1760396789;
					continue;
				case 2u:
					count = json.Count;
					array = new int[count];
					num3 = 0;
					num = (int)((num2 * 625902721) ^ 0xF86E82C);
					continue;
				case 1u:
					num = ((int)num2 * -643476412) ^ 0x34B8F0CA;
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
			int num = -1405634771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD2F75E3u) % 4u)
				{
				case 2u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1402034717) ^ -2031871928;
					continue;
				case 1u:
					num = ((int)num2 * -1930750636) ^ -912842352;
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
