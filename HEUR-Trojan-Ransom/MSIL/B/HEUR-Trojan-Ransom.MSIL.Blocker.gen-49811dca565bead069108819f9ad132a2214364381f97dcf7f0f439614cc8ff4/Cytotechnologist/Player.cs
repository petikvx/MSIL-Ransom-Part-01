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
			int num8 = default(int);
			int num5 = default(int);
			int result = default(int);
			int[] planningCards = default(int[]);
			int num3 = default(int);
			while (true)
			{
				int num = -872415775;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0EDFB2Du) % 11u)
					{
					case 10u:
						num8++;
						num = (int)(num2 * 817803043) ^ -95588042;
						continue;
					case 9u:
					{
						int num6;
						int num7;
						if (num5 > 0)
						{
							num6 = -1342438559;
							num7 = -1342438559;
						}
						else
						{
							num6 = -1438745426;
							num7 = -1438745426;
						}
						num = num6 ^ (int)(num2 * 1473926474);
						continue;
					}
					case 8u:
						num8 = 0;
						num = (int)(num2 * 236601877) ^ -889659336;
						continue;
					case 7u:
						result = num8;
						num = (int)((num2 * 684954827) ^ 0x117F2588);
						continue;
					case 6u:
						planningCards = PlanningCards;
						num3 = 0;
						num = (int)(num2 * 537312235) ^ -674890214;
						continue;
					case 4u:
						num3++;
						num = -1830598523;
						continue;
					case 3u:
						num = ((int)num2 * -416132957) ^ 0x6CCDEEAB;
						continue;
					case 2u:
						num5 = planningCards[num3];
						num = -1087500814;
						continue;
					case 1u:
					{
						int num4;
						if (num3 >= planningCards.Length)
						{
							num = -1204701487;
							num4 = -1204701487;
						}
						else
						{
							num = -521531203;
							num4 = -521531203;
						}
						continue;
					}
					case 0u:
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
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1927334986;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC950E5C6u) % 12u)
				{
				case 11u:
					text = "5461736B457863657074696F6E486F6C64";
					num = ((int)num2 * -152037503) ^ -1765933088;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1436563401;
						num5 = 1436563401;
					}
					else
					{
						num4 = 610063870;
						num5 = 610063870;
					}
					num = num4 ^ ((int)num2 * -1743844596);
					continue;
				}
				case 9u:
					num = (int)(num2 * 934093932) ^ -915571439;
					continue;
				case 8u:
					flag = BaseStream == 0;
					num = (int)((num2 * 1280428300) ^ 0xF105CE8);
					continue;
				case 7u:
					num = ((int)num2 * -1125768153) ^ 0x2574D718;
					continue;
				case 5u:
					num = ((int)num2 * -677640158) ^ 0x7AD60F61;
					continue;
				case 4u:
				{
					int num3;
					if (BaseStream != 1)
					{
						num = -877818541;
						num3 = -877818541;
					}
					else
					{
						num = -523360189;
						num3 = -523360189;
					}
					continue;
				}
				case 3u:
					text = "37436633656949";
					num = ((int)num2 * -1096282220) ^ -1135175921;
					continue;
				case 1u:
					result = text;
					num = -2107387666;
					continue;
				case 0u:
					num = (int)(num2 * 377489617) ^ -168508140;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -241166827;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x9E25BDBCu) % 4u)
				{
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)(num2 * 1727444087) ^ -905386985;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 0u:
					num3 = 0;
					goto IL_0023;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					result = num3;
					num = -1619019785;
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
			int num = 1622116953;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DC57BEDu) % 3u)
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
				num = ((int)num2 * -1604515224) ^ -1422398074;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num = 0;
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num2 = 246025321;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x6736BA92u) % 13u)
				{
				case 12u:
					num2 = 562506608;
					continue;
				case 11u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num4.ToString(),
						" "
					});
					num2 = 386933668;
					continue;
				case 10u:
					result = text;
					num2 = (int)(num3 * 698725839) ^ -1811989117;
					continue;
				case 9u:
					num++;
					num2 = 1612346732;
					continue;
				case 7u:
				{
					int num7;
					if (num >= PlanningCards.Length)
					{
						num2 = 1203809119;
						num7 = 1203809119;
					}
					else
					{
						num2 = 1857294203;
						num7 = 1857294203;
					}
					continue;
				}
				case 6u:
					num2 = ((int)num3 * -1038908277) ^ 0x3A7AD9A4;
					continue;
				case 5u:
					num2 = (int)(num3 * 1550217713) ^ -715818969;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (num4 != 0)
					{
						num5 = 962510048;
						num6 = 962510048;
					}
					else
					{
						num5 = 744005512;
						num6 = 744005512;
					}
					num2 = num5 ^ ((int)num3 * -50434773);
					continue;
				}
				case 2u:
					num2 = ((int)num3 * -101759043) ^ -41618934;
					continue;
				case 1u:
					num2 = ((int)num3 * -1288688607) ^ -1820887197;
					continue;
				case 0u:
					num4 = PlanningCards[num];
					num2 = (int)((num3 * 1325449171) ^ 0x627CEA99);
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
		bool flag = default(bool);
		int num3 = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = -677978402;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9954AEECu) % 10u)
				{
				case 9u:
					flag = num3 < count;
					num = -1450592435;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -147020356) ^ 0x5BF94FF1;
					continue;
				case 7u:
					array[num3] = json[num3].AsInt;
					num = -1128670123;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1350463697;
						num5 = 1350463697;
					}
					else
					{
						num4 = 1198257061;
						num5 = 1198257061;
					}
					num = num4 ^ ((int)num2 * -1992708992);
					continue;
				}
				case 4u:
					array = new int[count];
					num = ((int)num2 * -2053772637) ^ -1892959166;
					continue;
				case 3u:
					num3++;
					num = (int)((num2 * 42763844) ^ 0x22CCACF5);
					continue;
				case 1u:
					result = array;
					num = ((int)num2 * -1504073685) ^ 0x3788B92F;
					continue;
				case 0u:
					num = ((int)num2 * -413832372) ^ -334734284;
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

	public override string ToString()
	{
		string result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
		while (true)
		{
			int num = -303268744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE4FAEB4u) % 3u)
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
				num = ((int)num2 * -115283310) ^ 0x5CEB34F7;
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
