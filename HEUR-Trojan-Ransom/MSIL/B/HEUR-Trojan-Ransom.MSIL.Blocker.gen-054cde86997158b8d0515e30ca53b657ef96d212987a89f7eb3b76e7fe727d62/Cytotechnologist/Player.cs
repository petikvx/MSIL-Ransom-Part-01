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
			int[] planningCards = default(int[]);
			int result = default(int);
			int num5 = default(int);
			int num3 = default(int);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = 847921864;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E736B9Au) % 13u)
					{
					case 12u:
						planningCards = PlanningCards;
						num = (int)(num2 * 198953833) ^ -493134500;
						continue;
					case 11u:
						result = num5;
						num = ((int)num2 * -1129522802) ^ 0x33884726;
						continue;
					case 9u:
						num3 = 0;
						num = ((int)num2 * -31707339) ^ 0x6E4FC485;
						continue;
					case 8u:
						num5++;
						num = (int)((num2 * 1496414196) ^ 0x47B6987F);
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (!flag)
						{
							num7 = -123446750;
							num8 = -123446750;
						}
						else
						{
							num7 = -883544266;
							num8 = -883544266;
						}
						num = num7 ^ ((int)num2 * -1015913167);
						continue;
					}
					case 6u:
						flag = num4 > 0;
						num = ((int)num2 * -1838227277) ^ -1033471145;
						continue;
					case 5u:
						num3++;
						num = 1595286018;
						continue;
					case 4u:
					{
						int num6;
						if (num3 < planningCards.Length)
						{
							num = 1377754346;
							num6 = 1377754346;
						}
						else
						{
							num = 1716957056;
							num6 = 1716957056;
						}
						continue;
					}
					case 3u:
						num5 = 0;
						num = (int)((num2 * 2058907517) ^ 0x63D4E715);
						continue;
					case 1u:
						num4 = planningCards[num3];
						num = 1430852118;
						continue;
					case 0u:
						num = ((int)num2 * -1920667028) ^ 0x44793474;
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
		string text = null;
		if (BaseStream == 0)
		{
			goto IL_00a0;
		}
		goto IL_0108;
		IL_0108:
		bool flag = BaseStream == 1;
		int num = -1848717659;
		goto IL_00c5;
		IL_00c5:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA3C7411Cu) % 12u)
			{
			case 11u:
				result = text;
				num = -1378297560;
				continue;
			case 10u:
				text = "53746F7265417373656D626C79456E756D6572617469";
				num = ((int)num2 * -645093881) ^ -1270399369;
				continue;
			case 9u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = 166926954;
					num4 = 166926954;
				}
				else
				{
					num3 = 1640431006;
					num4 = 1640431006;
				}
				num = num3 ^ ((int)num2 * -1979102207);
				continue;
			}
			case 8u:
				text = "336F55636B736D4867";
				num = ((int)num2 * -683893032) ^ 0x42D35B73;
				continue;
			case 7u:
				num = (int)((num2 * 1109545879) ^ 0x6E5CE5ED);
				continue;
			case 6u:
				num = (int)(num2 * 2120961376) ^ -2074330810;
				continue;
			case 4u:
				num = (int)(num2 * 1803396721) ^ -2055655777;
				continue;
			case 2u:
				break;
			case 1u:
				num = (int)((num2 * 1437244529) ^ 0x7BEB081D);
				continue;
			case 0u:
				num = ((int)num2 * -1848206679) ^ -6730425;
				continue;
			case 5u:
				goto IL_0108;
			default:
				return result;
			}
			break;
		}
		goto IL_00a0;
		IL_00a0:
		num = -1511437914;
		goto IL_00c5;
	}

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = -555114242;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB81EE473u) % 4u)
				{
				case 2u:
					num3 = 0;
					goto IL_0004;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = (int)(num2 * 252858689) ^ -1571736988;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0004;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0004:
					result = num3;
					num = -1405680321;
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
			int num = 913849452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B8C4C7u) % 3u)
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
				num = (int)(num2 * 620334698) ^ -1505252543;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		int num = 0;
		string result = default(string);
		bool flag2 = default(bool);
		int num4 = default(int);
		while (true)
		{
			bool flag = num < PlanningCards.Length;
			int num2 = -277541946;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x999FB5B2u) % 12u)
				{
				case 11u:
					num++;
					num2 = -508192528;
					continue;
				case 10u:
					result = text;
					num2 = (int)(num3 * 388869291) ^ -118458228;
					continue;
				case 8u:
					num2 = -1553200201;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -949699628;
						num8 = -949699628;
					}
					else
					{
						num7 = -1752306838;
						num8 = -1752306838;
					}
					num2 = num7 ^ (int)(num3 * 1293711837);
					continue;
				}
				case 5u:
					num2 = (int)(num3 * 625593784) ^ -1872165923;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1449488228;
						num6 = 1449488228;
					}
					else
					{
						num5 = 648055823;
						num6 = 648055823;
					}
					num2 = num5 ^ ((int)num3 * -1279426234);
					continue;
				}
				case 3u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num],
						"x",
						num4.ToString(),
						" "
					});
					num2 = -1614097947;
					continue;
				case 2u:
					flag2 = num4 == 0;
					num2 = ((int)num3 * -1137808026) ^ 0x247ACBD;
					continue;
				case 1u:
					num4 = PlanningCards[num];
					num2 = -1714908720;
					continue;
				case 0u:
					num2 = ((int)num3 * -1033438180) ^ -161441653;
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
		return new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int[] result = default(int[]);
		int[] array = default(int[]);
		int count = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -957319874;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA47F41EBu) % 11u)
				{
				case 9u:
					num = ((int)num2 * -823951206) ^ -623079628;
					continue;
				case 7u:
					result = array;
					num = (int)(num2 * 1684359794) ^ -2048866680;
					continue;
				case 6u:
					array = new int[count];
					num = ((int)num2 * -1213438029) ^ 0x7E67B664;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= count)
					{
						num = -455302038;
						num4 = -455302038;
					}
					else
					{
						num = -17509065;
						num4 = -17509065;
					}
					continue;
				}
				case 4u:
					num3++;
					num = (int)(num2 * 774859272) ^ -818744657;
					continue;
				case 3u:
					num = ((int)num2 * -815381730) ^ 0x553561DB;
					continue;
				case 2u:
					num3 = 0;
					num = (int)(num2 * 519618297) ^ -178225573;
					continue;
				case 1u:
					count = json.Count;
					num = (int)((num2 * 206535693) ^ 0x763EFF29);
					continue;
				case 0u:
					array[num3] = json[num3].AsInt;
					num = -567380021;
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
			int num = 275427886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4163427Bu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
				num = (int)(num2 * 786346086) ^ -635276801;
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
