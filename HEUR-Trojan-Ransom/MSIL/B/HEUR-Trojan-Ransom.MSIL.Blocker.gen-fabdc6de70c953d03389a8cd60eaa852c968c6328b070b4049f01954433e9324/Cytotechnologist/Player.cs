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
			bool flag = default(bool);
			int num5 = default(int);
			int result = default(int);
			while (true)
			{
				int num3 = -99047712;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)num3 ^ 0xB511B4E3u) % 11u)
					{
					case 9u:
						num3 = -927179589;
						continue;
					case 7u:
						num2++;
						num3 = ((int)num4 * -1828459461) ^ 0x1C405500;
						continue;
					case 6u:
						flag = num5 > 0;
						num3 = ((int)num4 * -218679074) ^ -767061861;
						continue;
					case 5u:
						num3 = ((int)num4 * -883279599) ^ 0x6CA7247B;
						continue;
					case 4u:
					{
						int num8;
						if (num2 >= planningCards.Length)
						{
							num3 = -178717896;
							num8 = -178717896;
						}
						else
						{
							num3 = -113933942;
							num8 = -113933942;
						}
						continue;
					}
					case 3u:
						result = num;
						num3 = ((int)num4 * -1154153254) ^ -924063472;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (!flag)
						{
							num6 = 1984998226;
							num7 = 1984998226;
						}
						else
						{
							num6 = 1325199752;
							num7 = 1325199752;
						}
						num3 = num6 ^ (int)(num4 * 59118041);
						continue;
					}
					case 1u:
						num++;
						num3 = ((int)num4 * -2000763789) ^ 0x63374A4B;
						continue;
					case 0u:
						num5 = planningCards[num2];
						num3 = -34101140;
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
		string text = null;
		bool flag = BaseStream == 0;
		bool flag2 = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1538206997;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF48E106u) % 13u)
				{
				case 12u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1966053032;
						num6 = 1966053032;
					}
					else
					{
						num5 = 1974912076;
						num6 = 1974912076;
					}
					num = num5 ^ ((int)num2 * -417333374);
					continue;
				}
				case 11u:
					text = "4672616D6553656375726974794465736372697074";
					num = ((int)num2 * -346653311) ^ -1636944119;
					continue;
				case 10u:
					num = ((int)num2 * -1631825317) ^ 0x4D5E36BE;
					continue;
				case 9u:
					text = "52626A";
					num = ((int)num2 * -1160942721) ^ 0x1C5A6610;
					continue;
				case 7u:
					num = ((int)num2 * -1578571290) ^ 0x62C3BFF0;
					continue;
				case 5u:
					result = text;
					num = -1817527611;
					continue;
				case 4u:
					num = ((int)num2 * -173519844) ^ -256865348;
					continue;
				case 3u:
					num = ((int)num2 * -675811161) ^ -110996515;
					continue;
				case 2u:
					flag2 = BaseStream == 1;
					num = -669389952;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1451007166;
						num4 = -1451007166;
					}
					else
					{
						num3 = -1129097120;
						num4 = -1129097120;
					}
					num = num3 ^ ((int)num2 * -1919036883);
					continue;
				}
				case 0u:
					num = ((int)num2 * -569308929) ^ 0x44D0B17A;
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
		int num2 = -1905342592;
		goto IL_0027;
		IL_0013:
		num2 = -682123481;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x90B4B549u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = ((int)num3 * -1796986080) ^ 0x10342F5;
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
		int num4 = default(int);
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1510118802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC880D48Cu) % 11u)
				{
				case 10u:
				{
					num4 = PlanningCards[num3];
					int num7;
					if (num4 != 0)
					{
						num = -2053638709;
						num7 = -2053638709;
					}
					else
					{
						num = -447096483;
						num7 = -447096483;
					}
					continue;
				}
				case 9u:
					num = (int)((num2 * 1903173656) ^ 0x5E5F6C7C);
					continue;
				case 6u:
					num = (int)((num2 * 805226579) ^ 0x6BEC460E);
					continue;
				case 5u:
					result = text;
					num = (int)(num2 * 199227953) ^ -1787863584;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -60657247;
						num6 = -60657247;
					}
					else
					{
						num5 = -718201303;
						num6 = -718201303;
					}
					num = num5 ^ (int)(num2 * 1208279069);
					continue;
				}
				case 3u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -278625075;
					continue;
				case 2u:
					text = " ";
					num3 = 0;
					num = ((int)num2 * -1215046257) ^ 0x6C0860A9;
					continue;
				case 1u:
					flag = num3 < PlanningCards.Length;
					num = -1191029675;
					continue;
				case 0u:
					num3++;
					num = -1599349004;
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
		Player result = default(Player);
		while (true)
		{
			int num = 50258170;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95C32A0u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1060188708) ^ 0x3DD32369;
					continue;
				case 2u:
					result = new Player
					{
						Name = json["name"].Value,
						PlanningCards = ParsePlanningCards(json["planning-cards"]),
						UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
					};
					num = ((int)num2 * -235747323) ^ 0xFA8BE3D;
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
		int[] result = default(int[]);
		int[] array = default(int[]);
		int num3 = default(int);
		while (true)
		{
			int num = -913027623;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECF7B763u) % 10u)
				{
				case 9u:
					result = array;
					num = (int)(num2 * 1891021983) ^ -746626871;
					continue;
				case 8u:
					num3 = 0;
					num = (int)((num2 * 1014977176) ^ 0xA34D486);
					continue;
				case 7u:
					num = ((int)num2 * -258294635) ^ 0x26CA2004;
					continue;
				case 6u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -1141661998;
						num4 = -1141661998;
					}
					else
					{
						num = -1948976861;
						num4 = -1948976861;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -388529361) ^ -352125264;
					continue;
				case 2u:
					array = new int[count];
					num = ((int)num2 * -704804770) ^ -1353030207;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1352115597) ^ 0x7268EC38;
					continue;
				case 0u:
					array[num3] = json[num3].AsInt;
					num = -79801436;
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
			int num = -1043604091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4B1BE28u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1368565071) ^ 0x60AC1681;
					continue;
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -2137528077) ^ 0x186F2DB8;
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
