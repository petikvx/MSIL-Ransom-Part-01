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
			int[] planningCards = default(int[]);
			int num5 = default(int);
			int result = default(int);
			int num4 = default(int);
			while (true)
			{
				int num2 = 1958851374;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xFDA3CD7u) % 12u)
					{
					case 11u:
						num2 = 2132442890;
						continue;
					case 9u:
						planningCards = PlanningCards;
						num2 = (int)(num3 * 1934814755) ^ -818000708;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (num5 <= 0)
						{
							num7 = 974597597;
							num8 = 974597597;
						}
						else
						{
							num7 = 1792001952;
							num8 = 1792001952;
						}
						num2 = num7 ^ (int)(num3 * 1649222771);
						continue;
					}
					case 6u:
						num++;
						num2 = (int)(num3 * 1479383718) ^ -743427496;
						continue;
					case 5u:
						num2 = ((int)num3 * -10569609) ^ -1503203919;
						continue;
					case 4u:
						result = num;
						num2 = (int)((num3 * 1000751463) ^ 0x515470EF);
						continue;
					case 3u:
					{
						int num6;
						if (num4 >= planningCards.Length)
						{
							num2 = 1832349455;
							num6 = 1832349455;
						}
						else
						{
							num2 = 96401025;
							num6 = 96401025;
						}
						continue;
					}
					case 2u:
						num5 = planningCards[num4];
						num2 = 1983797612;
						continue;
					case 1u:
						num4++;
						num2 = (int)((num3 * 1573393324) ^ 0x16F07540);
						continue;
					case 0u:
						num4 = 0;
						num2 = (int)(num3 * 1626993307) ^ -1897158532;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = null;
		bool flag = BaseStream == 0;
		string result = default(string);
		while (true)
		{
			int num = 168385200;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x683CEC23u) % 11u)
				{
				case 10u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 642846654;
						num5 = 642846654;
					}
					else
					{
						num4 = 2071376469;
						num5 = 2071376469;
					}
					num = num4 ^ (int)(num2 * 1191798157);
					continue;
				}
				case 8u:
					num = ((int)num2 * -162482124) ^ 0x509F5F76;
					continue;
				case 7u:
					text = "456E756D657261626C65546F4974657261626C654164617074";
					num = ((int)num2 * -335865485) ^ 0x774BB7AA;
					continue;
				case 6u:
					text = "384270";
					num = (int)(num2 * 121340929) ^ -755080064;
					continue;
				case 5u:
					num = (int)(num2 * 1392750415) ^ -1316924930;
					continue;
				case 3u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = 1129058610;
						num3 = 1129058610;
					}
					else
					{
						num = 920428512;
						num3 = 920428512;
					}
					continue;
				}
				case 2u:
					num = (int)(num2 * 290515151) ^ -125892328;
					continue;
				case 1u:
					result = text;
					num = 1017878566;
					continue;
				case 0u:
					num = ((int)num2 * -809217012) ^ 0xA90F188;
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
		IL_0049:
		int result = num;
		int num2 = 579319635;
		goto IL_0027;
		IL_0013:
		num2 = 394439088;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1230593Eu) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = (int)((num3 * 171301771) ^ 0x137744C9);
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
		int num = 0;
		int num4 = default(int);
		bool flag2 = default(bool);
		string result = default(string);
		while (true)
		{
			bool flag = num < PlanningCards.Length;
			int num2 = -2073809673;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xACD9D0A1u) % 12u)
				{
				case 11u:
					num2 = (int)(num3 * 1175574949) ^ -1667843893;
					continue;
				case 10u:
					num++;
					num2 = -1791033552;
					continue;
				case 8u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num4.ToString(),
						" "
					});
					num2 = -2080434561;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -2144223486;
						num8 = -2144223486;
					}
					else
					{
						num7 = -1796068582;
						num8 = -1796068582;
					}
					num2 = num7 ^ ((int)num3 * -1707080111);
					continue;
				}
				case 6u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1391025531;
						num6 = 1391025531;
					}
					else
					{
						num5 = 1434374790;
						num6 = 1434374790;
					}
					num2 = num5 ^ ((int)num3 * -1691703819);
					continue;
				}
				case 5u:
					num2 = -277914581;
					continue;
				case 4u:
					num2 = (int)((num3 * 643863915) ^ 0x56191CC7);
					continue;
				case 3u:
					num2 = -1125171512;
					continue;
				case 2u:
					num4 = PlanningCards[num];
					flag2 = num4 == 0;
					num2 = ((int)num3 * -1377970796) ^ 0x1DB329CA;
					continue;
				case 0u:
					result = text;
					num2 = (int)(num3 * 440819681) ^ -1634794686;
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
		Player result = new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
		while (true)
		{
			int num = -870817518;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90C7DEFDu) % 3u)
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
				num = (int)(num2 * 1429502619) ^ -797639792;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1920298327;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19375475u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1580224240) ^ -1033952939;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1420051713) ^ 0x7AC4DDC1;
					continue;
				case 6u:
				{
					int num4;
					if (num3 < count)
					{
						num = 236995273;
						num4 = 236995273;
					}
					else
					{
						num = 1437830206;
						num4 = 1437830206;
					}
					continue;
				}
				case 5u:
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -1755079750) ^ -1200605605;
					continue;
				case 4u:
					result = array;
					num = (int)((num2 * 564264654) ^ 0x4DB9C4C5);
					continue;
				case 3u:
					count = json.Count;
					num = (int)((num2 * 28760347) ^ 0x1FF28954);
					continue;
				case 1u:
					array[num3] = json[num3].AsInt;
					num = 1668831201;
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
		string result = default(string);
		while (true)
		{
			int num = -666976097;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB79BCD9Eu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 814019677) ^ -551245241;
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1781559736) ^ -1348005924;
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
