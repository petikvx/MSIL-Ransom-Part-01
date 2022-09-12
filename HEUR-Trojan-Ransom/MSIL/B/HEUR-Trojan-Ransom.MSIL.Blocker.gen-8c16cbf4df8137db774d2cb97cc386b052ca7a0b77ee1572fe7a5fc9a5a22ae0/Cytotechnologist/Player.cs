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
			bool flag = default(bool);
			int num5 = default(int);
			int num4 = default(int);
			int result = default(int);
			while (true)
			{
				int num2 = -1178482405;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xD22A6711u) % 11u)
					{
					case 10u:
						flag = num5 > 0;
						num2 = (int)((num3 * 1513666503) ^ 0x2B8BEDF8);
						continue;
					case 9u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = 258635938;
							num8 = 258635938;
						}
						else
						{
							num7 = 77143066;
							num8 = 77143066;
						}
						num2 = num7 ^ ((int)num3 * -13826095);
						continue;
					}
					case 7u:
						num4++;
						num2 = -1438406844;
						continue;
					case 6u:
					{
						int num6;
						if (num4 >= planningCards.Length)
						{
							num2 = -2008765867;
							num6 = -2008765867;
						}
						else
						{
							num2 = -1186052216;
							num6 = -1186052216;
						}
						continue;
					}
					case 4u:
						num++;
						num2 = (int)((num3 * 2061002314) ^ 0xCA4EA04);
						continue;
					case 3u:
						num4 = 0;
						num2 = (int)(num3 * 573688625) ^ -2058642770;
						continue;
					case 2u:
						num2 = ((int)num3 * -1625058322) ^ 0x68055B6C;
						continue;
					case 1u:
						num5 = planningCards[num4];
						num2 = -127987942;
						continue;
					case 0u:
						result = num;
						num2 = (int)((num3 * 99094563) ^ 0x7939518D);
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
		if (BaseStream == 0)
		{
			goto IL_003d;
		}
		goto IL_00f5;
		IL_00f5:
		int num;
		int num2;
		if (BaseStream == 1)
		{
			num = -1026806241;
			num2 = -1026806241;
		}
		else
		{
			num = -1817611511;
			num2 = -1817611511;
		}
		goto IL_00a7;
		IL_00a7:
		string result = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xD9622720u) % 11u)
			{
			case 10u:
				num = ((int)num3 * -1271534955) ^ -42642185;
				continue;
			case 9u:
				num = ((int)num3 * -776218189) ^ -1701269157;
				continue;
			case 8u:
				break;
			case 6u:
				text = "766D4779";
				num = ((int)num3 * -1132826652) ^ 0x1CE65BED;
				continue;
			case 4u:
				result = text;
				num = -1538782038;
				continue;
			case 3u:
				text = "476574456E756D657261746F7264";
				num = (int)((num3 * 1982195714) ^ 0x6978BCA3);
				continue;
			case 2u:
				num = ((int)num3 * -68044625) ^ 0x5C837C17;
				continue;
			case 1u:
				num = (int)(num3 * 1678017176) ^ -1118274026;
				continue;
			case 0u:
				num = ((int)num3 * -616861002) ^ -1119295385;
				continue;
			case 7u:
				goto IL_00f5;
			default:
				return result;
			}
			break;
		}
		goto IL_003d;
		IL_003d:
		num = -922416451;
		goto IL_00a7;
	}

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = 1559575120;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6C15DFD8u) % 5u)
				{
				case 3u:
					num3 = 0;
					goto IL_0004;
				case 2u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -1670985592) ^ -396464830;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 1u:
					num = ((int)num2 * -1112898208) ^ 0x22E45DD0;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = 1108229875;
					continue;
				}
				break;
			}
		}
	}

	private Player()
	{
	}

	public string PlanningCardsToString()
	{
		string text = default(string);
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1436069099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D573ACFu) % 12u)
				{
				case 11u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num6],
						"x",
						num3.ToString(),
						" "
					});
					num = 848064162;
					continue;
				case 10u:
					num = (int)((num2 * 582247368) ^ 0x557325AC);
					continue;
				case 8u:
					text = " ";
					num6 = 0;
					num = ((int)num2 * -1764526205) ^ -1408519343;
					continue;
				case 7u:
					flag = num6 < PlanningCards.Length;
					num = 1566417365;
					continue;
				case 5u:
					num3 = PlanningCards[num6];
					num = 1886707239;
					continue;
				case 4u:
					result = text;
					num = (int)(num2 * 518216330) ^ -1404476375;
					continue;
				case 3u:
					num = (int)(num2 * 26197830) ^ -579092624;
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 124668360;
						num8 = 124668360;
					}
					else
					{
						num7 = 172256381;
						num8 = 172256381;
					}
					num = num7 ^ ((int)num2 * -965631943);
					continue;
				}
				case 1u:
					num6++;
					num = 634912444;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (num3 != 0)
					{
						num4 = -163210316;
						num5 = -163210316;
					}
					else
					{
						num4 = -1723657396;
						num5 = -1723657396;
					}
					num = num4 ^ (int)(num2 * 30996912);
					continue;
				}
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
		Player result = default(Player);
		while (true)
		{
			int num = -746492919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x997F64C8u) % 3u)
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
				result = new Player
				{
					Name = json["name"].Value,
					PlanningCards = ParsePlanningCards(json["planning-cards"]),
					UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
				};
				num = ((int)num2 * -464863577) ^ 0x870DD95;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		int[] result = default(int[]);
		int[] array = default(int[]);
		int count = default(int);
		while (true)
		{
			int num = 102116374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4903C9A0u) % 9u)
				{
				case 6u:
					num3++;
					num = (int)((num2 * 1953761708) ^ 0x5F0A46E5);
					continue;
				case 5u:
					num = (int)(num2 * 462881042) ^ -356834732;
					continue;
				case 4u:
					result = array;
					num = (int)((num2 * 111255341) ^ 0xA9E9ABD);
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= count)
					{
						num = 95737696;
						num4 = 95737696;
					}
					else
					{
						num = 278396599;
						num4 = 278396599;
					}
					continue;
				}
				case 2u:
					num = (int)((num2 * 874049439) ^ 0x256DE9F2);
					continue;
				case 1u:
					count = json.Count;
					array = new int[count];
					num3 = 0;
					num = ((int)num2 * -289753083) ^ 0x256CF843;
					continue;
				case 0u:
					array[num3] = json[num3].AsInt;
					num = 1065406619;
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
		return Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
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
