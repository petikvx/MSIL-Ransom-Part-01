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
				int num = -393774949;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF5DE28Fu) % 3u)
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
					num = (int)(num2 * 235379393) ^ -252943105;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 134842305;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6BDCB254u) % 5u)
					{
					case 4u:
						jSONArray = new JSONArray();
						jSONArray.Add(value);
						num = ((int)num2 * -1127088407) ^ -1046963013;
						continue;
					case 2u:
						num = (int)((num2 * 1502835118) ^ 0x20138373);
						continue;
					case 0u:
						Set(jSONArray);
						num = ((int)num2 * -1058231996) ^ 0x7C6FA830;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 807485298;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45F4ADE0u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 826538376) ^ -731828875;
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1255446129) ^ 0x14CDDE9D;
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
				int num = -1807439991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB26E869Eu) % 5u)
					{
					case 3u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1570065417) ^ 0x79A0BC9C;
						continue;
					case 2u:
						Set(jSONClass);
						num = (int)((num2 * 769528684) ^ 0x2459FAF1);
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 271357305) ^ 0x73ACF32A);
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -1096390562;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0255EEDu) % 6u)
					{
					case 5u:
						result = 0;
						num = (int)(num2 * 1637664063) ^ -687168354;
						continue;
					case 4u:
						num = (int)(num2 * 416997511) ^ -1322696631;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 440479268) ^ 0x68626DC4);
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = (int)(num2 * 1186168442) ^ -1536792337;
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
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = -1339755541;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4FE5F02u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = ((int)num2 * -1110427708) ^ 0x7BD39282;
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
				int num = -1455776257;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD108786Eu) % 5u)
					{
					case 4u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -2030469175) ^ 0x4A3A8F93;
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -893973327) ^ -966132388;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1633288530) ^ 0x2352526F;
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
				int num = 1148262698;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D472C5Fu) % 4u)
					{
					case 1u:
						Set(aVal);
						num = (int)((num2 * 2113006254) ^ 0x17B84DBD);
						continue;
					case 0u:
						num = (int)((num2 * 1090330808) ^ 0x2F9FE0E4);
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
	}

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = 1834160903;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D6B1C7Cu) % 5u)
					{
					case 4u:
						result = 0.0;
						num = (int)(num2 * 338139215) ^ -420513098;
						continue;
					case 2u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = (int)(num2 * 1057342848) ^ -2066685601;
						continue;
					}
					case 1u:
						num = ((int)num2 * -433927987) ^ 0x57271133;
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -1810846322;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA8D471Bu) % 5u)
					{
					case 4u:
						Set(aVal);
						num = ((int)num2 * -587399230) ^ -1795651942;
						continue;
					case 3u:
						num = ((int)num2 * -520955330) ^ -1821694140;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -318571063) ^ -405955283;
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
	}

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 1020954059;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45101D57u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -886566663) ^ 0x46657B94;
						continue;
					case 2u:
						result = false;
						num = ((int)num2 * -1077844001) ^ 0x612E14F1;
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -1113513789) ^ 0x3B8B5A90;
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
		set
		{
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = 509597695;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30CADCC1u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -1035625027) ^ -224415242;
						continue;
					case 1u:
						num = ((int)num2 * -14705320) ^ -552185930;
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
	}

	public override JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -1006936431;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC8624DFFu) % 6u)
					{
					case 4u:
						result = jSONArray;
						num = (int)((num2 * 2013523869) ^ 0x20FEC345);
						continue;
					case 2u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = (int)((num2 * 1404328310) ^ 0x70414FC8);
						continue;
					case 1u:
						num = ((int)num2 * -1210362856) ^ -1900939025;
						continue;
					case 0u:
						num = (int)(num2 * 1002010118) ^ -1828408812;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 1230200532;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B1EF99Fu) % 4u)
					{
					case 3u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 1809323958) ^ 0x2548D341);
						continue;
					case 0u:
						result = jSONClass;
						num = (int)((num2 * 1914758645) ^ 0x46D20FC2);
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
		m_Node = aNode;
		m_Key = aKey;
	}

	private void Set(JSONNode aVal)
	{
		bool flag = m_Key == null;
		while (true)
		{
			int num = 2034115503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D365C68u) % 7u)
				{
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = 442652309;
					continue;
				case 5u:
					num = (int)(num2 * 1081778347) ^ -530387847;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1471639258;
						num4 = -1471639258;
					}
					else
					{
						num3 = -391667601;
						num4 = -391667601;
					}
					num = num3 ^ (int)(num2 * 2108701381);
					continue;
				}
				case 1u:
					m_Node.Add(aVal);
					num = (int)(num2 * 459963805) ^ -457474360;
					continue;
				case 0u:
					num = ((int)num2 * -1975027661) ^ -1984717990;
					continue;
				case 3u:
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
			int num = -975244139;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF620369u) % 5u)
				{
				case 4u:
					jSONArray.Add(aItem);
					num = (int)(num2 * 1239067306) ^ -678365287;
					continue;
				case 2u:
					Set(jSONArray);
					num = ((int)num2 * -217411812) ^ -998194519;
					continue;
				case 0u:
					num = ((int)num2 * -1792811877) ^ 0x4374955A;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = -942046310;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC855FF81u) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = (int)((num2 * 1729200362) ^ 0x524A63EC);
					continue;
				case 2u:
					num = (int)(num2 * 352889188) ^ -1303906795;
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1983911988) ^ -2018261579;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1883134448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A242B00u) % 7u)
				{
				case 6u:
					flag = b == null;
					num = (int)((num2 * 765239559) ^ 0x37CBE37D);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 887518662;
						num4 = 887518662;
					}
					else
					{
						num3 = 1824188453;
						num4 = 1824188453;
					}
					num = num3 ^ (int)(num2 * 1759333121);
					continue;
				}
				case 4u:
					result = (object)a == b;
					num = 1016325540;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -894892210) ^ -240830073;
					continue;
				case 0u:
					num = ((int)num2 * -209884427) ^ -1438992509;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -369497025;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD52B95Au) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = (int)((num2 * 522943153) ^ 0x65EF9C83);
					continue;
				case 0u:
					num = (int)(num2 * 1898147180) ^ -1771932884;
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

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0019;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)this == obj;
		int num = -1336389473;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xC8ACCE53u) % 5u)
			{
			case 4u:
				result = true;
				num = ((int)num2 * -1216630903) ^ -916772102;
				continue;
			case 2u:
				break;
			case 0u:
				num = ((int)num2 * -2075413280) ^ -1227014113;
				continue;
			case 3u:
				goto IL_0052;
			default:
				return result;
			}
			break;
		}
		goto IL_0019;
		IL_0019:
		num = -1330726946;
		goto IL_002d;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 212859855;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEFFBA9u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0003:
				hashCode = base.GetHashCode();
				num = ((int)num2 * -1568035504) ^ 0x2F3C0F0B;
			}
		}
	}

	public override string ToString()
	{
		return "";
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1752232385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F95F84Cu) % 4u)
				{
				case 1u:
					result = "";
					num = ((int)num2 * -459192466) ^ 0x71140212;
					continue;
				case 0u:
					num = ((int)num2 * -884392728) ^ 0x3C9B5DB3;
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
