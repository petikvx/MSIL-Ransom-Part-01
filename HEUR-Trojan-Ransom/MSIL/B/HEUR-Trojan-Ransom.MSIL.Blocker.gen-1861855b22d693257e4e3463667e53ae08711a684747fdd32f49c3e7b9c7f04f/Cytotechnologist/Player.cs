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
			int num7 = default(int);
			int[] planningCards = default(int[]);
			int num4 = default(int);
			int result = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num2 = -1646754931;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0xF1CA8108u) % 15u)
					{
					case 13u:
						num7 = 0;
						num2 = (int)(num3 * 1581424264) ^ -637474260;
						continue;
					case 12u:
						num++;
						num2 = ((int)num3 * -592432564) ^ -1447128733;
						continue;
					case 11u:
					{
						int num8;
						if (num7 < planningCards.Length)
						{
							num2 = -764956118;
							num8 = -764956118;
						}
						else
						{
							num2 = -1758802628;
							num8 = -1758802628;
						}
						continue;
					}
					case 10u:
						num2 = ((int)num3 * -481308661) ^ -1165638836;
						continue;
					case 9u:
						num2 = (int)((num3 * 1120788415) ^ 0x10B895BC);
						continue;
					case 8u:
						num4 = planningCards[num7];
						num2 = -1456014693;
						continue;
					case 7u:
						num7++;
						num2 = (int)(num3 * 356031453) ^ -563190381;
						continue;
					case 6u:
						planningCards = PlanningCards;
						num2 = (int)(num3 * 1548664371) ^ -1115464158;
						continue;
					case 4u:
						result = num;
						num2 = ((int)num3 * -2004160550) ^ 0x51F328DB;
						continue;
					case 3u:
						num2 = (int)(num3 * 757705617) ^ -566415545;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -395583642;
							num6 = -395583642;
						}
						else
						{
							num5 = -529543504;
							num6 = -529543504;
						}
						num2 = num5 ^ ((int)num3 * -308772419);
						continue;
					}
					case 1u:
						flag = num4 > 0;
						num2 = (int)(num3 * 1096784459) ^ -209669276;
						continue;
					case 0u:
						num2 = -917066768;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -284827690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1B285D7u) % 13u)
				{
				case 12u:
					text = "5374617469634172726179496E69745479706553697A653430";
					num = (int)((num2 * 676617680) ^ 0x5B16AEF2);
					continue;
				case 11u:
					num = ((int)num2 * -1326844295) ^ 0x6EF44C8A;
					continue;
				case 9u:
					num = ((int)num2 * -1731119537) ^ 0x22D75A22;
					continue;
				case 8u:
					num = (int)((num2 * 1029281911) ^ 0x17D3C382);
					continue;
				case 7u:
					num = (int)((num2 * 939817267) ^ 0x176BB536);
					continue;
				case 6u:
					text = "4466494A4430416F";
					num = (int)((num2 * 265596016) ^ 0x51AD9F7D);
					continue;
				case 5u:
					text = null;
					num = (int)(num2 * 1134254849) ^ -1010073388;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (BaseStream != 0)
					{
						num4 = 114688074;
						num5 = 114688074;
					}
					else
					{
						num4 = 1880636707;
						num5 = 1880636707;
					}
					num = num4 ^ (int)(num2 * 1412153467);
					continue;
				}
				case 3u:
					result = text;
					num = -76398581;
					continue;
				case 2u:
				{
					int num3;
					if (BaseStream == 1)
					{
						num = -619498761;
						num3 = -619498761;
					}
					else
					{
						num = -802414472;
						num3 = -802414472;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -400624988) ^ -1971050484;
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
		goto IL_0049;
		IL_0049:
		int result = num;
		int num2 = -363703479;
		goto IL_0027;
		IL_0013:
		num2 = -1215124494;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xC54AD150u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num2 = ((int)num3 * -38243908) ^ 0x74ED4930;
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
		bool flag2 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 300688117;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F5FD1E9u) % 16u)
				{
				case 15u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -923878401;
						num8 = -923878401;
					}
					else
					{
						num7 = -929240877;
						num8 = -929240877;
					}
					num = num7 ^ ((int)num2 * -1654855506);
					continue;
				}
				case 14u:
					num4 = PlanningCards[num3];
					num = (int)(num2 * 1363490357) ^ -1964178606;
					continue;
				case 13u:
					flag = num4 == 0;
					num = (int)((num2 * 1833326187) ^ 0x2EFF2D35);
					continue;
				case 12u:
					text = " ";
					num = ((int)num2 * -1727297882) ^ -2054349052;
					continue;
				case 11u:
					flag2 = num3 < PlanningCards.Length;
					num = 293759302;
					continue;
				case 10u:
					num = ((int)num2 * -1002692640) ^ -545532625;
					continue;
				case 9u:
					num3++;
					num = 570912610;
					continue;
				case 8u:
					num = 1441373495;
					continue;
				case 7u:
					num = ((int)num2 * -1563374156) ^ -1084866802;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1418067496) ^ -1872747914;
					continue;
				case 4u:
					result = text;
					num = (int)((num2 * 219492559) ^ 0x79C837F);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 280042818;
						num6 = 280042818;
					}
					else
					{
						num5 = 1421201475;
						num6 = 1421201475;
					}
					num = num5 ^ (int)(num2 * 1668812718);
					continue;
				}
				case 1u:
					num = (int)(num2 * 669690274) ^ -392733550;
					continue;
				case 0u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = 1476638256;
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
		int[] array = default(int[]);
		bool flag = default(bool);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1827621478;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45E6152Au) % 11u)
				{
				case 9u:
					array = new int[count];
					num = (int)((num2 * 1265586805) ^ 0x74FB7AF6);
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1855315460;
						num5 = 1855315460;
					}
					else
					{
						num4 = 1988255594;
						num5 = 1988255594;
					}
					num = num4 ^ (int)(num2 * 1664086520);
					continue;
				}
				case 6u:
					num = (int)((num2 * 2005637618) ^ 0x17985E6);
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -954150712) ^ -414451424;
					continue;
				case 4u:
					array[num3] = json[num3].AsInt;
					num = 1450407115;
					continue;
				case 3u:
					num = (int)(num2 * 1818974263) ^ -725373028;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -530295781) ^ 0x68E9D375;
					continue;
				case 1u:
					flag = num3 < count;
					num = 548828104;
					continue;
				case 0u:
					result = array;
					num = (int)(num2 * 1288205393) ^ -1302807914;
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
