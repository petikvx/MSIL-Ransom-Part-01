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
			int num8 = default(int);
			int num6 = default(int);
			int[] planningCards = default(int[]);
			int num3 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -490855458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83539D7Bu) % 13u)
					{
					case 12u:
						result = num8;
						num = ((int)num2 * -1951838247) ^ -366198411;
						continue;
					case 11u:
					{
						int num7;
						if (num6 >= planningCards.Length)
						{
							num = -1484512152;
							num7 = -1484512152;
						}
						else
						{
							num = -2047969182;
							num7 = -2047969182;
						}
						continue;
					}
					case 10u:
						num6++;
						num = (int)(num2 * 2030839963) ^ -1203780153;
						continue;
					case 9u:
						num8++;
						num = ((int)num2 * -1603707342) ^ 0x5F93869B;
						continue;
					case 8u:
						num6 = 0;
						num = (int)(num2 * 625228833) ^ -1670233731;
						continue;
					case 7u:
						num3 = planningCards[num6];
						num = -2114259887;
						continue;
					case 5u:
						num8 = 0;
						planningCards = PlanningCards;
						num = ((int)num2 * -531522944) ^ 0x69654FCD;
						continue;
					case 3u:
						num = (int)(num2 * 636870864) ^ -2003048734;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1778180565;
							num5 = 1778180565;
						}
						else
						{
							num4 = 899341700;
							num5 = 899341700;
						}
						num = num4 ^ ((int)num2 * -1257481760);
						continue;
					}
					case 1u:
						flag = num3 > 0;
						num = (int)((num2 * 1763311520) ^ 0x21BC3DFF);
						continue;
					case 0u:
						num = -483767585;
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
			int num = 1853422682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCA4BF7u) % 12u)
				{
				case 11u:
					flag = BaseStream == 1;
					num = 863263993;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 910678227;
						num6 = 910678227;
					}
					else
					{
						num5 = 191590168;
						num6 = 191590168;
					}
					num = num5 ^ (int)(num2 * 1605840900);
					continue;
				}
				case 9u:
					text = null;
					num = (int)((num2 * 1911904427) ^ 0x433C4FF0);
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (BaseStream != 0)
					{
						num3 = -810442512;
						num4 = -810442512;
					}
					else
					{
						num3 = -604393094;
						num4 = -604393094;
					}
					num = num3 ^ (int)(num2 * 393697869);
					continue;
				}
				case 7u:
					result = text;
					num = 1204348601;
					continue;
				case 5u:
					text = "32636E464D4A";
					num = (int)(num2 * 170409947) ^ -1391717869;
					continue;
				case 4u:
					num = ((int)num2 * -1745564166) ^ 0xF872926;
					continue;
				case 3u:
					text = "537461";
					num = (int)((num2 * 1290580372) ^ 0x607899B1);
					continue;
				case 2u:
					num = (int)(num2 * 194802172) ^ -1539290888;
					continue;
				case 1u:
					num = ((int)num2 * -142225094) ^ -198788094;
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
		int num2 = 1415382687;
		goto IL_0027;
		IL_0027:
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x256A99A2u) % 4u)
			{
			case 3u:
				num2 = ((int)num3 * -1672009803) ^ 0x670C4491;
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
		num2 = 96131769;
		goto IL_0027;
	}

	private Player()
	{
		while (true)
		{
			int num = 421628830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x480BA5C7u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 569419747) ^ 0x1F502469);
					continue;
				case 1u:
					num = ((int)num2 * -697115983) ^ 0xD748A74;
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
		string text = " ";
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -828609651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8FF3563u) % 14u)
				{
				case 12u:
					flag2 = num3 < PlanningCards.Length;
					num = -1577439118;
					continue;
				case 11u:
					num = (int)((num2 * 1108725295) ^ 0x37CA78D3);
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1697518540;
						num8 = 1697518540;
					}
					else
					{
						num7 = 16452089;
						num8 = 16452089;
					}
					num = num7 ^ ((int)num2 * -2075592146);
					continue;
				}
				case 8u:
					num3 = 0;
					num = (int)(num2 * 745840986) ^ -1888007479;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1243650655;
						num6 = 1243650655;
					}
					else
					{
						num5 = 2015354267;
						num6 = 2015354267;
					}
					num = num5 ^ ((int)num2 * -1369047922);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1022744989) ^ 0x4F65F6BC;
					continue;
				case 5u:
					num = ((int)num2 * -1192511378) ^ -1062929692;
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
					num = -54755059;
					continue;
				case 3u:
					num4 = PlanningCards[num3];
					flag = num4 == 0;
					num = (int)(num2 * 175363714) ^ -12169171;
					continue;
				case 2u:
					num = -925908896;
					continue;
				case 1u:
					num3++;
					num = -972273819;
					continue;
				case 0u:
					result = text;
					num = (int)(num2 * 1066134865) ^ -203927700;
					continue;
				case 13u:
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
			int num = -388160024;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8C04B19u) % 3u)
				{
				case 2u:
					goto IL_004a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_004a:
				num = (int)(num2 * 1687578939) ^ -1710064291;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		bool flag = default(bool);
		int num3 = default(int);
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = -2010153756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80858CEBu) % 11u)
				{
				case 10u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 61755854;
						num5 = 61755854;
					}
					else
					{
						num4 = 171730628;
						num5 = 171730628;
					}
					num = num4 ^ (int)(num2 * 1088716382);
					continue;
				}
				case 9u:
					flag = num3 < count;
					num = -261528451;
					continue;
				case 7u:
					array = new int[count];
					num = (int)((num2 * 1167888357) ^ 0x174B4E71);
					continue;
				case 6u:
					count = json.Count;
					num = ((int)num2 * -1831743510) ^ 0x1E41AFD1;
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 1252358857) ^ -549253609;
					continue;
				case 4u:
					num3 = 0;
					num = (int)(num2 * 825281172) ^ -1318909005;
					continue;
				case 3u:
					array[num3] = json[num3].AsInt;
					num = -1917824689;
					continue;
				case 1u:
					num = ((int)num2 * -1625576592) ^ 0x688F45D3;
					continue;
				case 0u:
					result = array;
					num = ((int)num2 * -327630717) ^ -76936881;
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
			int num = -1005525290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD105DF84u) % 4u)
				{
				case 2u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)(num2 * 1204783051) ^ -1113692513;
					continue;
				case 1u:
					num = (int)((num2 * 978909300) ^ 0x3C974A73);
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
