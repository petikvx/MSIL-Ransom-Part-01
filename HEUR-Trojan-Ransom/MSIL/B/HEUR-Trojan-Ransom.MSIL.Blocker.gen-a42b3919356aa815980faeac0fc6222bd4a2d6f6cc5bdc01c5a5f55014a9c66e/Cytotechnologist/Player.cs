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
			int num4 = default(int);
			int num7 = default(int);
			int[] planningCards = default(int[]);
			int num3 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -1119871105;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFAA843Au) % 12u)
					{
					case 10u:
						result = num4;
						num = ((int)num2 * -779660176) ^ -193830122;
						continue;
					case 9u:
					{
						int num8;
						if (num7 >= planningCards.Length)
						{
							num = -683047500;
							num8 = -683047500;
						}
						else
						{
							num = -1439067496;
							num8 = -1439067496;
						}
						continue;
					}
					case 7u:
						num7++;
						num = ((int)num2 * -141079023) ^ 0x780B4018;
						continue;
					case 6u:
						num3 = planningCards[num7];
						num = -516477977;
						continue;
					case 5u:
						num4 = 0;
						planningCards = PlanningCards;
						num7 = 0;
						num = (int)((num2 * 285150406) ^ 0x64C3C100);
						continue;
					case 4u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 1301835008;
							num6 = 1301835008;
						}
						else
						{
							num5 = 900272449;
							num6 = 900272449;
						}
						num = num5 ^ (int)(num2 * 462137517);
						continue;
					}
					case 3u:
						num4++;
						num = ((int)num2 * -2002292595) ^ 0x93B809F;
						continue;
					case 2u:
						num = -2140439475;
						continue;
					case 1u:
						flag = num3 > 0;
						num = ((int)num2 * -297429175) ^ -627608713;
						continue;
					case 0u:
						num = (int)((num2 * 1376338876) ^ 0x5BF91C8F);
						continue;
					case 11u:
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
			int num = 39254821;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E9940DFu) % 13u)
				{
				case 12u:
					num = (int)(num2 * 1678744874) ^ -2050101824;
					continue;
				case 11u:
					text = "57696E5254547970654E616D65436F6E76657274";
					num = ((int)num2 * -850090587) ^ -1524068826;
					continue;
				case 9u:
					result = text;
					num = 2106132518;
					continue;
				case 8u:
					num = ((int)num2 * -1474290804) ^ 0x10344D47;
					continue;
				case 7u:
					num = ((int)num2 * -65815622) ^ -146245595;
					continue;
				case 5u:
					text = "6A5633";
					num = (int)(num2 * 1183152688) ^ -476257092;
					continue;
				case 4u:
					text = null;
					flag = BaseStream == 0;
					num = ((int)num2 * -523017136) ^ -376335687;
					continue;
				case 3u:
				{
					int num5;
					if (BaseStream != 1)
					{
						num = 1536713118;
						num5 = 1536713118;
					}
					else
					{
						num = 409571920;
						num5 = 409571920;
					}
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1291830602;
						num4 = 1291830602;
					}
					else
					{
						num3 = 139233874;
						num4 = 139233874;
					}
					num = num3 ^ (int)(num2 * 1731007682);
					continue;
				}
				case 1u:
					num = ((int)num2 * -926531255) ^ -585161228;
					continue;
				case 0u:
					num = ((int)num2 * -1964974190) ^ -875020086;
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
		int result = default(int);
		while (true)
		{
			int num = 373896570;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x3439CBF7u) % 5u)
				{
				case 2u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -270198552) ^ 0x1493367E;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 0u:
					num = ((int)num2 * -1503150611) ^ -1172929591;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = 1556827560;
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
			int num = -21398604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8579E6DDu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1310614824) ^ 0x2D5EAF3E);
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num = 0;
		bool flag = default(bool);
		int num5 = default(int);
		string result = default(string);
		while (true)
		{
			int num2;
			int num3;
			if (num < PlanningCards.Length)
			{
				num2 = 255511200;
				num3 = 255511200;
			}
			else
			{
				num2 = 1568848696;
				num3 = 1568848696;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x3B2B3B6Fu) % 11u)
				{
				case 10u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -596758666;
						num7 = -596758666;
					}
					else
					{
						num6 = -747893833;
						num7 = -747893833;
					}
					num2 = num6 ^ (int)(num4 * 327629327);
					continue;
				}
				case 9u:
					num++;
					num2 = 757189701;
					continue;
				case 8u:
					num2 = 255511200;
					continue;
				case 7u:
					num5 = PlanningCards[num];
					flag = num5 == 0;
					num2 = (int)((num4 * 159283767) ^ 0x41DBD077);
					continue;
				case 6u:
					num2 = ((int)num4 * -252615886) ^ 0x361077FD;
					continue;
				case 5u:
					result = text;
					num2 = (int)((num4 * 1177256108) ^ 0x842D6FD);
					continue;
				case 3u:
					num2 = (int)(num4 * 947742795) ^ -399588305;
					continue;
				case 1u:
					num2 = 30248916;
					continue;
				case 0u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num5.ToString(),
						" "
					});
					num2 = 825929741;
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

	public static Player Deserialize(JSONNode json)
	{
		Player result = default(Player);
		while (true)
		{
			int num = 731000236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10EBC7F9u) % 3u)
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
				num = (int)(num2 * 463981708) ^ -1966063575;
			}
		}
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] array = default(int[]);
		int count = default(int);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -1134968701;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8056220Du) % 10u)
				{
				case 9u:
					array = new int[count];
					num = ((int)num2 * -1747039585) ^ 0xC2A4224;
					continue;
				case 8u:
					count = json.Count;
					num = (int)((num2 * 930363920) ^ 0x75F57D3E);
					continue;
				case 7u:
					array[num3] = json[num3].AsInt;
					num = -2015978972;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -73239474) ^ 0x375C705E;
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 461760239) ^ 0x71DB396E);
					continue;
				case 3u:
					num = (int)(num2 * 845742153) ^ -351186454;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -1426156048;
						num4 = -1426156048;
					}
					else
					{
						num = -477366268;
						num4 = -477366268;
					}
					continue;
				}
				case 1u:
					result = array;
					num = ((int)num2 * -843881896) ^ -739679779;
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
