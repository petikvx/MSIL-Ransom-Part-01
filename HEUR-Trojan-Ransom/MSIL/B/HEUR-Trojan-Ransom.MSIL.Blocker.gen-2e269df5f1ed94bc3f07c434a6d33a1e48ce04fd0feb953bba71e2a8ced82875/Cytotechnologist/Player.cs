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
			int num3 = default(int);
			int[] planningCards = default(int[]);
			int result = default(int);
			int num8 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = 1497653465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x197FFEF6u) % 14u)
					{
					case 13u:
						num3++;
						num = ((int)num2 * -1172842085) ^ -680426643;
						continue;
					case 12u:
					{
						int num7;
						if (num3 >= planningCards.Length)
						{
							num = 556673637;
							num7 = 556673637;
						}
						else
						{
							num = 332955491;
							num7 = 332955491;
						}
						continue;
					}
					case 11u:
						num3 = 0;
						num = (int)((num2 * 1391874825) ^ 0x3F168715);
						continue;
					case 9u:
						result = num8;
						num = (int)(num2 * 313328274) ^ -2131465683;
						continue;
					case 8u:
						planningCards = PlanningCards;
						num = ((int)num2 * -1477294961) ^ 0x41F4F727;
						continue;
					case 7u:
						num8 = 0;
						num = (int)(num2 * 536614723) ^ -131865763;
						continue;
					case 6u:
						num8++;
						num = ((int)num2 * -859984421) ^ -1301421552;
						continue;
					case 5u:
						num = ((int)num2 * -1649244599) ^ -945136245;
						continue;
					case 4u:
						num = 739151447;
						continue;
					case 3u:
						num = ((int)num2 * -764574526) ^ -270573974;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (num4 <= 0)
						{
							num5 = -505342448;
							num6 = -505342448;
						}
						else
						{
							num5 = -1007614206;
							num6 = -1007614206;
						}
						num = num5 ^ (int)(num2 * 353033477);
						continue;
					}
					case 1u:
						num4 = planningCards[num3];
						num = 1477698593;
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
	}

	public static string MembershipCondition(int BaseStream)
	{
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -1760067292;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5665330u) % 10u)
				{
				case 8u:
					text = "42696E64";
					num = (int)(num2 * 1258023992) ^ -258251900;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1808654227;
						num6 = -1808654227;
					}
					else
					{
						num5 = -577107554;
						num6 = -577107554;
					}
					num = num5 ^ ((int)num2 * -928125463);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1761862364) ^ 0x56E70AAE);
					continue;
				case 5u:
					text = "616F6658703061";
					num = ((int)num2 * -1655534861) ^ -212544679;
					continue;
				case 4u:
				{
					text = null;
					int num3;
					int num4;
					if (BaseStream == 0)
					{
						num3 = -803692738;
						num4 = -803692738;
					}
					else
					{
						num3 = -1417133195;
						num4 = -1417133195;
					}
					num = num3 ^ ((int)num2 * -1820098933);
					continue;
				}
				case 2u:
					result = text;
					num = -2140494930;
					continue;
				case 1u:
					flag = BaseStream == 1;
					num = -770358517;
					continue;
				case 0u:
					num = ((int)num2 * -1150252130) ^ -356159037;
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

	public int PlannedForCard(int cardTypeIndex)
	{
		int result = default(int);
		while (true)
		{
			int num = 737529870;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6E3B008Bu) % 4u)
				{
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -39033069) ^ -368484628;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0023;
				case 0u:
					num3 = 0;
					goto IL_0023;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					result = num3;
					num = 1976274065;
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
			int num = -1128234941;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4E59D7Au) % 4u)
				{
				case 1u:
					num = ((int)num2 * -1750969358) ^ 0x4E3B1C5C;
					continue;
				case 0u:
					num = ((int)num2 * -380553046) ^ 0x684D081D;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public string PlanningCardsToString()
	{
		int num4 = default(int);
		int num3 = default(int);
		string text = default(string);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -563855289;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBF2051Au) % 13u)
				{
				case 12u:
				{
					num4 = PlanningCards[num3];
					int num7;
					int num8;
					if (num4 == 0)
					{
						num7 = 107238479;
						num8 = 107238479;
					}
					else
					{
						num7 = 1270577386;
						num8 = 1270577386;
					}
					num = num7 ^ ((int)num2 * -1945490721);
					continue;
				}
				case 11u:
					num = ((int)num2 * -1830887337) ^ 0x64A908D;
					continue;
				case 10u:
					num = -1249060006;
					continue;
				case 8u:
					text = " ";
					num3 = 0;
					num = (int)((num2 * 521831548) ^ 0x5EB4DD05);
					continue;
				case 7u:
					num = ((int)num2 * -808008010) ^ -787176114;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -2036369593;
						num6 = -2036369593;
					}
					else
					{
						num5 = -1593564987;
						num6 = -1593564987;
					}
					num = num5 ^ ((int)num2 * -490732368);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1428769630) ^ 0x1776388C;
					continue;
				case 3u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num3],
						"x",
						num4.ToString(),
						" "
					});
					num = -865432890;
					continue;
				case 2u:
					result = text;
					num = (int)(num2 * 635783283) ^ -480697604;
					continue;
				case 1u:
					flag = num3 < PlanningCards.Length;
					num = -2060206821;
					continue;
				case 0u:
					num3++;
					num = -995354120;
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
		return new Player
		{
			Name = json["name"].Value,
			PlanningCards = ParsePlanningCards(json["planning-cards"]),
			UseOneMorePlanningSprint = json["use-one-more-planning-sprint"].AsBool
		};
	}

	private static int[] ParsePlanningCards(JSONNode json)
	{
		int num3 = default(int);
		int count = default(int);
		int[] array = default(int[]);
		int[] result = default(int[]);
		while (true)
		{
			int num = 1698206212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CBE8A4Du) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1661945451) ^ -1553341172;
					continue;
				case 9u:
				{
					int num4;
					if (num3 < count)
					{
						num = 549008981;
						num4 = 549008981;
					}
					else
					{
						num = 1819665075;
						num4 = 1819665075;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -1430612312) ^ -557772391;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -425953402) ^ -66201550;
					continue;
				case 6u:
					array = new int[count];
					num = (int)(num2 * 1026375421) ^ -1100877585;
					continue;
				case 5u:
					count = json.Count;
					num = (int)(num2 * 823111039) ^ -742708151;
					continue;
				case 3u:
					array[num3] = json[num3].AsInt;
					num = 2107171867;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 356870614) ^ -757262435;
					continue;
				case 1u:
					result = array;
					num = (int)((num2 * 640104535) ^ 0x540542);
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
			int num = -262064480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8F2C5E1u) % 4u)
				{
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = ((int)num2 * -1744477345) ^ -283510450;
					continue;
				case 0u:
					num = (int)(num2 * 18453724) ^ -1196762818;
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

	static string smethod_0(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
