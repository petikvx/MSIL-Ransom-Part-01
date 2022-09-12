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
			int num5 = default(int);
			int result = default(int);
			int num4 = default(int);
			int[] planningCards = default(int[]);
			while (true)
			{
				int num = 941674654;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48493EC1u) % 13u)
					{
					case 12u:
						num3 = 0;
						num = ((int)num2 * -762225268) ^ -2039896894;
						continue;
					case 10u:
					{
						int num7;
						int num8;
						if (num5 <= 0)
						{
							num7 = -1632657796;
							num8 = -1632657796;
						}
						else
						{
							num7 = -1186020913;
							num8 = -1186020913;
						}
						num = num7 ^ ((int)num2 * -712704317);
						continue;
					}
					case 9u:
						result = num3;
						num = (int)((num2 * 420344910) ^ 0x1C9FEEC6);
						continue;
					case 8u:
						num = 1901115722;
						continue;
					case 7u:
					{
						int num6;
						if (num4 < planningCards.Length)
						{
							num = 85701698;
							num6 = 85701698;
						}
						else
						{
							num = 1006091124;
							num6 = 1006091124;
						}
						continue;
					}
					case 6u:
						num5 = planningCards[num4];
						num = 1901864073;
						continue;
					case 5u:
						planningCards = PlanningCards;
						num4 = 0;
						num = ((int)num2 * -1516540763) ^ -1684892504;
						continue;
					case 4u:
						num4++;
						num = ((int)num2 * -865774106) ^ 0x7877A0DE;
						continue;
					case 3u:
						num = (int)((num2 * 1399827022) ^ 0x3D2FA0AD);
						continue;
					case 2u:
						num = (int)((num2 * 876963778) ^ 0x1C3904E2);
						continue;
					case 0u:
						num3++;
						num = (int)((num2 * 981682629) ^ 0x7C3B4B0A);
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
		bool flag = default(bool);
		string text = default(string);
		bool flag2 = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -108681720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA05C11AFu) % 14u)
				{
				case 13u:
					num = ((int)num2 * -1754093890) ^ 0x58CCC169;
					continue;
				case 12u:
					num = ((int)num2 * -678110166) ^ 0x49968EA4;
					continue;
				case 11u:
					flag = BaseStream == 0;
					num = ((int)num2 * -1102868314) ^ 0x37FA2F56;
					continue;
				case 10u:
					text = "775876";
					num = (int)(num2 * 746711558) ^ -998498570;
					continue;
				case 9u:
					num = ((int)num2 * -184593782) ^ -626783351;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 111041611;
						num6 = 111041611;
					}
					else
					{
						num5 = 2045259301;
						num6 = 2045259301;
					}
					num = num5 ^ ((int)num2 * -432179128);
					continue;
				}
				case 7u:
					num = ((int)num2 * -607893877) ^ -856667760;
					continue;
				case 6u:
					flag2 = BaseStream == 1;
					num = -673357711;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 935730269;
						num4 = 935730269;
					}
					else
					{
						num3 = 1037759931;
						num4 = 1037759931;
					}
					num = num3 ^ (int)(num2 * 1496984532);
					continue;
				}
				case 3u:
					text = "456E636F646572457863657074696F6E46616C6C6261";
					num = ((int)num2 * -337473953) ^ -1053743817;
					continue;
				case 2u:
					result = text;
					num = -954103664;
					continue;
				case 1u:
					text = null;
					num = ((int)num2 * -22898954) ^ 0x5AF8958;
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
		int result = default(int);
		while (true)
		{
			int num = 2016679016;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x35A9B5B0u) % 5u)
				{
				case 3u:
					num = (int)((num2 * 1752227289) ^ 0x7A939A35);
					continue;
				case 2u:
					num3 = 0;
					goto IL_0013;
				case 1u:
					if (PlanningCards.Length == 0)
					{
						num = ((int)num2 * -683533208) ^ -1482215615;
						continue;
					}
					num3 = PlanningCards[cardTypeIndex];
					goto IL_0013;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0013:
					result = num3;
					num = 1107716246;
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
			int num = 1700499846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57B0E6E4u) % 3u)
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
				num = ((int)num2 * -163786897) ^ -1629344467;
			}
		}
	}

	public string PlanningCardsToString()
	{
		string text = " ";
		string result = default(string);
		int num5 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -1243817973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80C4DBF3u) % 14u)
				{
				case 13u:
					num = (int)((num2 * 741943439) ^ 0x15D6A03A);
					continue;
				case 12u:
					result = text;
					num = ((int)num2 * -1854432875) ^ -1357687354;
					continue;
				case 11u:
					num5++;
					num = -236304081;
					continue;
				case 9u:
					num = -1883736840;
					continue;
				case 8u:
					flag = num5 < PlanningCards.Length;
					num = -2018907089;
					continue;
				case 7u:
					num = (int)((num2 * 40256902) ^ 0x2D5D5642);
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (num6 != 0)
					{
						num7 = 1300182992;
						num8 = 1300182992;
					}
					else
					{
						num7 = 931789934;
						num8 = 931789934;
					}
					num = num7 ^ ((int)num2 * -482885175);
					continue;
				}
				case 5u:
					text = Player.smethod_0(new string[5]
					{
						text,
						Card.CardTypeNames[num5],
						"x",
						num6.ToString(),
						" "
					});
					num = -1808943992;
					continue;
				case 4u:
					num5 = 0;
					num = ((int)num2 * -848458341) ^ 0x59BBB607;
					continue;
				case 3u:
					num = ((int)num2 * -1105959713) ^ -1875500255;
					continue;
				case 1u:
					num6 = PlanningCards[num5];
					num = ((int)num2 * -62665985) ^ -1195899046;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 107437831;
						num4 = 107437831;
					}
					else
					{
						num3 = 788714050;
						num4 = 788714050;
					}
					num = num3 ^ (int)(num2 * 1433145211);
					continue;
				}
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
		int[] array = new int[count];
		bool flag = default(bool);
		int num3 = default(int);
		int[] result = default(int[]);
		while (true)
		{
			int num = -616610232;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC60C03D4u) % 8u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1864391256;
						num5 = -1864391256;
					}
					else
					{
						num4 = -539872966;
						num5 = -539872966;
					}
					num = num4 ^ (int)(num2 * 532739890);
					continue;
				}
				case 5u:
					flag = num3 < count;
					num = -471124054;
					continue;
				case 4u:
					num3 = 0;
					num = (int)((num2 * 618720129) ^ 0x356BA2B1);
					continue;
				case 2u:
					result = array;
					num = ((int)num2 * -253242983) ^ 0x160E2421;
					continue;
				case 1u:
					num = (int)((num2 * 1472077389) ^ 0x24477984);
					continue;
				case 0u:
					array[num3] = json[num3].AsInt;
					num3++;
					num = -943399071;
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
			int num = -1655443543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADC9BCFCu) % 4u)
				{
				case 1u:
					result = Player.smethod_1("name: {0},\nplanning-cards: [{1}]\nuse-one-more-planning-sprint: {2}", (object)Name, (object)PlanningCardsToString(), (object)UseOneMorePlanningSprint);
					num = (int)((num2 * 1373458177) ^ 0x2AAD80C5);
					continue;
				case 0u:
					num = ((int)num2 * -1713820557) ^ -973368598;
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

	static string smethod_0(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
