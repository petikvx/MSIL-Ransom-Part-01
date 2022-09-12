namespace SimpleJSON;

internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node = null;

	private string m_Key = null;

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = 796824396;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x32CF80FCu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)(num2 * 1606492933) ^ -899620019;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = -114176706;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF7FFE403u) % 6u)
					{
					case 5u:
						Set(jSONArray);
						num = (int)((num2 * 1668247377) ^ 0x7203B164);
						continue;
					case 3u:
						num = (int)(num2 * 1854950306) ^ -871683166;
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -1731380684) ^ 0x7F5F1C3A;
						continue;
					case 0u:
						num = ((int)num2 * -147173519) ^ 0x6DB36BBD;
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
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
				int num = 1121811173;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x578FB222u) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = ((int)num2 * -1417572384) ^ -949264321;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1795373088;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA08258E5u) % 5u)
					{
					case 4u:
						num = (int)((num2 * 777827311) ^ 0x11711BF6);
						continue;
					case 2u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 1525276831) ^ 0x55FE92D2);
						continue;
					case 1u:
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 522111555) ^ 0x440B8538);
						continue;
					case 0u:
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
			JSONData aVal = new JSONData(0);
			Set(aVal);
			return 0;
		}
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -379812420;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB1B96DDu) % 5u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = (int)((num2 * 719003637) ^ 0x6E638744);
						continue;
					case 2u:
						num = (int)(num2 * 276215057) ^ -1547113388;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1033208673) ^ 0x2E01E57C;
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public override float AsFloat
	{
		get
		{
			JSONData aVal = default(JSONData);
			float result = default(float);
			while (true)
			{
				int num = 490037444;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x643E78A1u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 1135407418) ^ 0x2F81B92C);
						continue;
					case 2u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 1897087128) ^ 0x48D35BAD);
						continue;
					case 1u:
						result = 0f;
						num = (int)(num2 * 1522182055) ^ -1399472459;
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
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = -1416513521;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9143448u) % 3u)
					{
					case 2u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = ((int)num2 * -534774583) ^ 0x5252BAC0;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = -368893924;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x982DDE34u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					Set(aVal);
					result = 0.0;
					num = (int)((num2 * 1111852323) ^ 0x26428C8B);
				}
			}
		}
		set
		{
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = 666635092;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40426022u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1806983539) ^ -921396350;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1877165204) ^ 0x18CA8551);
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 1471715375;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25B8539u) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1992429925) ^ 0x78B6EBCE);
						continue;
					case 5u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -798248092) ^ 0x4DAA7152;
						continue;
					case 3u:
						result = false;
						num = ((int)num2 * -1826899726) ^ 0x1CA8587C;
						continue;
					case 2u:
						Set(aVal);
						num = (int)(num2 * 225497490) ^ -2028607511;
						continue;
					case 1u:
						num = (int)(num2 * 1539335196) ^ -708132547;
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
			while (true)
			{
				int num = -562405493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC01082D6u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1600634734) ^ -1770486363;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)(num2 * 1024897878) ^ -233659482;
						continue;
					}
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
	}

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -765520967;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5C49EBAu) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = (int)((num2 * 1681644628) ^ 0x1ABB488A);
						continue;
					case 2u:
						num = (int)((num2 * 815847110) ^ 0x55BC4817);
						continue;
					case 1u:
						result = jSONArray;
						num = (int)((num2 * 184820437) ^ 0x1CA74FBA);
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 239945755;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x798C05A1u) % 7u)
					{
					case 5u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -830813201) ^ -187143268;
						continue;
					case 4u:
						num = (int)(num2 * 230835927) ^ -1769570554;
						continue;
					case 3u:
						result = jSONClass;
						num = (int)(num2 * 2140958758) ^ -1876843969;
						continue;
					case 2u:
						num = ((int)num2 * -1792225862) ^ -165749500;
						continue;
					case 1u:
						Set(jSONClass);
						num = (int)((num2 * 703324558) ^ 0x4D02034D);
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

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = 1261820599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x798FEB95u) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 0u:
					break;
				default:
					m_Key = null;
					return;
				}
				break;
				IL_0016:
				m_Node = aNode;
				num = ((int)num2 * -1728935740) ^ 0x5F8B1660;
			}
		}
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -1305786812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF44AB281u) % 4u)
				{
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -564195890) ^ -1619649745;
					continue;
				case 0u:
					m_Key = aKey;
					num = ((int)num2 * -337383510) ^ -878815709;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = -330371776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6BFEE53u) % 11u)
				{
				case 10u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 2142228127) ^ 0x18F309B3);
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = -1481821971;
						num4 = -1481821971;
					}
					else
					{
						num3 = -2030842897;
						num4 = -2030842897;
					}
					num = num3 ^ (int)(num2 * 278483431);
					continue;
				}
				case 7u:
					num = ((int)num2 * -114784047) ^ -1622765156;
					continue;
				case 6u:
					num = (int)(num2 * 1157787374) ^ -1512389070;
					continue;
				case 5u:
					num = (int)(num2 * 1628699165) ^ -2042383877;
					continue;
				case 4u:
					num = (int)(num2 * 1459598581) ^ -1337048154;
					continue;
				case 3u:
					num = ((int)num2 * -333818996) ^ -1751796061;
					continue;
				case 2u:
					m_Node.Add(aVal);
					num = (int)(num2 * 602369222) ^ -1287135862;
					continue;
				case 1u:
					num = -1251733244;
					continue;
				case 0u:
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
		JSONArray jSONArray = new JSONArray();
		while (true)
		{
			int num = -176482561;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFABE8323u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1041253083) ^ 0x32B0A8F7);
					continue;
				case 3u:
					Set(jSONArray);
					num = ((int)num2 * -1365360479) ^ -375812844;
					continue;
				case 1u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -265576635) ^ -713215826;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			int num = -1081421041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA348B69u) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = ((int)num2 * -2143962382) ^ -259975570;
					continue;
				case 3u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -933241234) ^ 0x4B83C0AE;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1823355257) ^ -140129993;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		if (b == null)
		{
			goto IL_0028;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)a == b;
		int num = 177103029;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x61404479u) % 5u)
			{
			case 4u:
				result = true;
				num = ((int)num2 * -1511421785) ^ 0x18F7A13C;
				continue;
			case 3u:
				num = ((int)num2 * -1528088012) ^ 0x4AF84C67;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0052;
			default:
				return result;
			}
			break;
		}
		goto IL_0028;
		IL_0028:
		num = 462534820;
		goto IL_002d;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -1966811569;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF1676C5u) % 3u)
				{
				case 2u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 1531914439) ^ 0x11F9F122);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 2044199641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37817507u) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (obj == null)
					{
						num3 = -1211900203;
						num4 = -1211900203;
					}
					else
					{
						num3 = -209150502;
						num4 = -209150502;
					}
					num = num3 ^ (int)(num2 * 967340609);
					continue;
				}
				case 3u:
					result = (object)this == obj;
					num = 825755713;
					continue;
				case 1u:
					num = (int)((num2 * 1572528236) ^ 0x3572D7FD);
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -1043161643) ^ 0x4AF8E1C6;
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = 1461864183;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2206817Fu) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0009:
				num = (int)(num2 * 425534916) ^ -675047532;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -578398998;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x960E380Du) % 4u)
				{
				case 3u:
					result = "";
					num = ((int)num2 * -695639582) ^ 0x6DC13635;
					continue;
				case 2u:
					num = ((int)num2 * -1596358578) ^ -1653118144;
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1853079257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1106D57Cu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 888761913) ^ -1092754362;
					continue;
				case 1u:
					result = "";
					num = (int)((num2 * 1484837752) ^ 0x49D34E1A);
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
}
