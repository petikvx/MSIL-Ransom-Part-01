namespace SimpleJSON;

internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node = null;

	private string m_Key = null;

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1627843992;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDACB081Au) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1242202327) ^ -1351906099;
						continue;
					case 1u:
						num = (int)(num2 * 1653188494) ^ -1579433464;
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
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 118733711;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A86EB2Bu) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = (int)(num2 * 79355213) ^ -1475556671;
						continue;
					case 3u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -992457444) ^ 0x1BC44A21;
						continue;
					case 0u:
						jSONArray.Add(value);
						num = ((int)num2 * -1001170176) ^ -305635113;
						continue;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -547196598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE02FE3E0u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 259428970) ^ 0x78A7403F);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1446404130) ^ -591774861;
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
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1410780598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84051E1Eu) % 5u)
					{
					case 3u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 896743617) ^ -420982995;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -1518087688) ^ -333402820;
						continue;
					case 0u:
						num = (int)((num2 * 215580522) ^ 0x4C6C615);
						continue;
					case 4u:
						break;
					default:
						Set(jSONClass);
						return;
					}
					break;
				}
			}
		}
	}

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = -493316889;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1D48B7Fu) % 6u)
					{
					case 4u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = (int)((num2 * 1955511858) ^ 0x9098D10);
						continue;
					}
					case 3u:
						num = (int)((num2 * 925641341) ^ 0x1AFB4DD9);
						continue;
					case 2u:
						num = ((int)num2 * -338525033) ^ 0x152DA359;
						continue;
					case 1u:
						result = 0;
						num = (int)(num2 * 461364589) ^ -12984306;
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
		set
		{
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = -854277766;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96157424u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = (int)((num2 * 1685384778) ^ 0x391F6D95);
				}
			}
		}
	}

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			float result = default(float);
			while (true)
			{
				int num = 632035870;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x589CDF5Du) % 5u)
					{
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1496526125) ^ 0x1E13370);
						continue;
					case 1u:
						result = 0f;
						num = ((int)num2 * -358347050) ^ -1551153330;
						continue;
					case 0u:
						num = (int)((num2 * 967829457) ^ 0x2A3D6B95);
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
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 1261698546;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x56AA5FF8u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 25062216) ^ -29056687;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = (int)((num2 * 910842723) ^ 0xE3B7819);
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = -558943698;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4892C26u) % 5u)
					{
					case 3u:
						num = ((int)num2 * -1995703128) ^ -1961381995;
						continue;
					case 2u:
						result = 0.0;
						num = (int)(num2 * 600992425) ^ -394774972;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = (int)((num2 * 1867085336) ^ 0x7C890251);
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
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -1213940835;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD8D002F0u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 750431794) ^ 0x5163D436);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)(num2 * 1123993317) ^ -203903786;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 2132617479;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x318CC86Eu) % 5u)
					{
					case 4u:
						Set(aVal);
						num = ((int)num2 * -293237999) ^ 0x35CCD126;
						continue;
					case 3u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -630825267) ^ -179041162;
						continue;
					case 1u:
						result = false;
						num = (int)((num2 * 165953846) ^ 0x2E0B83DF);
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
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -828815920;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB576FDCFu) % 5u)
					{
					case 4u:
						Set(aVal);
						num = (int)(num2 * 1121701679) ^ -27599451;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1293977768) ^ 0x10F3FCA9;
						continue;
					case 0u:
						num = ((int)num2 * -213093460) ^ -1457018567;
						continue;
					default:
						return;
					case 3u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -428662590;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEBCC58F6u) % 5u)
					{
					case 3u:
						Set(jSONArray);
						result = jSONArray;
						num = ((int)num2 * -461520381) ^ -720502639;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -768082641) ^ -895278695;
						continue;
					case 0u:
						num = (int)(num2 * 273885140) ^ -405979369;
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
	}

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = new JSONClass();
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 1369890518;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D472F7Du) % 4u)
					{
					case 3u:
						Set(jSONClass);
						result = jSONClass;
						num = ((int)num2 * -536590793) ^ -925032588;
						continue;
					case 0u:
						num = (int)((num2 * 621995555) ^ 0x4DE7E294);
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

	public JSONLazyCreator(JSONNode aNode)
	{
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 347108172;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39026E4Au) % 5u)
				{
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -389229366) ^ -1163691152;
					continue;
				case 3u:
					num = ((int)num2 * -1604569243) ^ 0x64730E2;
					continue;
				case 1u:
					m_Key = aKey;
					num = ((int)num2 * -154889387) ^ 0x109B221E;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 132752597;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x591A1DF0u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -702917404) ^ 0x22FC3C92;
					continue;
				case 10u:
					num = (int)(num2 * 365802154) ^ -296647401;
					continue;
				case 9u:
					num = ((int)num2 * -832706943) ^ -492788905;
					continue;
				case 7u:
					num = (int)((num2 * 130851055) ^ 0x49783862);
					continue;
				case 5u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1298756524) ^ 0x2B3193AE;
					continue;
				case 4u:
					num = 1870014085;
					continue;
				case 3u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1364733899) ^ -158612387;
					continue;
				case 2u:
					num = (int)((num2 * 1991155878) ^ 0x24C4B0A5);
					continue;
				case 1u:
					flag = m_Key == null;
					num = (int)(num2 * 1981687522) ^ -1750288486;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1744999120;
						num4 = -1744999120;
					}
					else
					{
						num3 = -965832317;
						num4 = -965832317;
					}
					num = num3 ^ ((int)num2 * -864746727);
					continue;
				}
				case 8u:
					break;
				default:
					m_Node = null;
					return;
				}
				break;
			}
		}
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 845521099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22514D8u) % 5u)
				{
				case 4u:
					Set(jSONArray);
					num = (int)((num2 * 588354637) ^ 0x3544F369);
					continue;
				case 2u:
					jSONArray.Add(aItem);
					num = (int)(num2 * 75762731) ^ -1967031602;
					continue;
				case 1u:
					jSONArray = new JSONArray();
					num = (int)(num2 * 1387227646) ^ -21852148;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1323322541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7D5C020u) % 6u)
				{
				case 5u:
					Set(jSONClass);
					num = (int)((num2 * 67517037) ^ 0x4579AD10);
					continue;
				case 4u:
					num = ((int)num2 * -127383172) ^ -1157629725;
					continue;
				case 3u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -2089567458) ^ -702610050;
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -602996511) ^ 0x7EE22792;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -621584847;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC06D7816u) % 6u)
				{
				case 4u:
					result = true;
					num = ((int)num2 * -1083682496) ^ 0x11C027E8;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (b == null)
					{
						num3 = -59809774;
						num4 = -59809774;
					}
					else
					{
						num3 = -1967357683;
						num4 = -1967357683;
					}
					num = num3 ^ ((int)num2 * -125756802);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1675857092) ^ 0x4F707160;
					continue;
				case 1u:
					result = (object)a == b;
					num = -1748322584;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1349676157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF07FFADu) % 8u)
				{
				case 7u:
					result = true;
					num = ((int)num2 * -1086731603) ^ 0x1136D132;
					continue;
				case 6u:
					flag = obj == null;
					num = ((int)num2 * -696414173) ^ 0x400D33AC;
					continue;
				case 4u:
					num = (int)((num2 * 446362333) ^ 0x49D00A9C);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -702187240;
						num4 = -702187240;
					}
					else
					{
						num3 = -1414701818;
						num4 = -1414701818;
					}
					num = num3 ^ ((int)num2 * -890873778);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1207093315) ^ -889392854;
					continue;
				case 1u:
					result = (object)this == obj;
					num = -461810545;
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = -1709085594;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x859A1CB6u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0009:
				num = (int)(num2 * 780154118) ^ -2032979488;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -8318280;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD492D186u) % 3u)
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
				result = "";
				num = (int)((num2 * 1917712937) ^ 0x2EE3E345);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 58794547;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43B7BE2Du) % 3u)
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
				result = "";
				num = ((int)num2 * -1382148537) ^ 0x3BF39CC4;
			}
		}
	}
}
