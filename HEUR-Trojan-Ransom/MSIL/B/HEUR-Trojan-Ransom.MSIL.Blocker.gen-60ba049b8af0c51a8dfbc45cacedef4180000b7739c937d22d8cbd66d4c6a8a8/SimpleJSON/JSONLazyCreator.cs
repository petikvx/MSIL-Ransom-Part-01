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
				int num = 2025887147;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3645B1DDu) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1102199839) ^ -2017941230;
						continue;
					case 1u:
						num = ((int)num2 * -221866508) ^ 0xF70C43A;
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
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = -1678969710;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF9D7E5B2u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -774503720) ^ -1738371176;
						continue;
					case 3u:
						Set(jSONArray);
						num = (int)((num2 * 1351946415) ^ 0x5F03130);
						continue;
					case 2u:
						jSONArray.Add(value);
						num = ((int)num2 * -2021404109) ^ 0x6124291;
						continue;
					case 1u:
						num = (int)(num2 * 2142134350) ^ -1289376897;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			return new JSONLazyCreator(this, aKey);
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -2134733039;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCDDD5F7Du) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						Set(jSONClass);
						return;
					}
					break;
					IL_0003:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, value);
					num = ((int)num2 * -1957207168) ^ -558150042;
				}
			}
		}
	}

	public override int AsInt
	{
		get
		{
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = 171261163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x677857A2u) % 6u)
					{
					case 5u:
						Set(aVal);
						num = (int)(num2 * 165182659) ^ -1468348921;
						continue;
					case 3u:
						aVal = new JSONData(0);
						num = ((int)num2 * -1556308458) ^ -898170349;
						continue;
					case 2u:
						num = (int)((num2 * 1258475845) ^ 0x4837CC8F);
						continue;
					case 1u:
						result = 0;
						num = (int)(num2 * 1217782175) ^ -344358619;
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
				int num = -1953466625;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8647FEFu) % 3u)
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
					num = ((int)num2 * -135796676) ^ -1026324161;
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
				int num = -1283744639;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCE5D398u) % 4u)
					{
					case 1u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 2041967696) ^ 0x2CC83594);
						continue;
					case 0u:
						Set(aVal);
						result = 0f;
						num = ((int)num2 * -1598421443) ^ 0x640D9252;
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
				int num = -438424794;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD06EE185u) % 5u)
					{
					case 4u:
						aVal = new JSONData(value);
						num = (int)((num2 * 1192638009) ^ 0x12D2DF6F);
						continue;
					case 3u:
						num = ((int)num2 * -1189178664) ^ 0x511ADE31;
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -1586514069) ^ -725295792;
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

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -1088389929;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9185AC9Fu) % 5u)
					{
					case 3u:
						result = 0.0;
						num = ((int)num2 * -1665948129) ^ 0x48F419DF;
						continue;
					case 1u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -2024677557) ^ 0x7E50C8E9;
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -1424234227) ^ 0x5F905A3C;
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
			while (true)
			{
				int num = 1789046118;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F3563B0u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = ((int)num2 * -1259414816) ^ -995258533;
				}
			}
		}
	}

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 47666512;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x17CF9180u) % 6u)
					{
					case 5u:
						result = false;
						num = ((int)num2 * -1823649881) ^ -1219901349;
						continue;
					case 3u:
						num = ((int)num2 * -1261123578) ^ 0x1E0F74E1;
						continue;
					case 2u:
						aVal = new JSONData(aData: false);
						num = (int)(num2 * 340594065) ^ -2042082801;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 647862130) ^ -1962983311;
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
				int num = -1943975054;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84CC59A7u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1120963144) ^ -1485119852;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1136428350) ^ -1611339265;
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
				int num = -2065423991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A64258Cu) % 5u)
					{
					case 3u:
						result = jSONArray;
						num = (int)(num2 * 283084349) ^ -587523792;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1211536076) ^ -508604841;
						continue;
					case 1u:
						Set(jSONArray);
						num = ((int)num2 * -1119196281) ^ -616039171;
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
				int num = 2089828347;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5EB0A1Du) % 4u)
					{
					case 2u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = ((int)num2 * -486256414) ^ -993202440;
						continue;
					case 1u:
						result = jSONClass;
						num = (int)(num2 * 863988736) ^ -37842219;
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

	public JSONLazyCreator(JSONNode aNode)
	{
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 881397802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x356CDC60u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1513122004) ^ -128828319;
					continue;
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -956404083) ^ -1219483467;
					continue;
				case 3u:
					break;
				default:
					m_Key = aKey;
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
			int num = 2018638777;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x431CC252u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -866514939) ^ 0xA5659FD;
					continue;
				case 8u:
					num = 1066314960;
					continue;
				case 6u:
					num = (int)((num2 * 1400232882) ^ 0x2921C0B5);
					continue;
				case 4u:
					num = ((int)num2 * -2041519757) ^ 0x41625629;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = -879856163;
						num4 = -879856163;
					}
					else
					{
						num3 = -1858403937;
						num4 = -1858403937;
					}
					num = num3 ^ ((int)num2 * -887667765);
					continue;
				}
				case 2u:
					m_Node.Add(aVal);
					num = (int)(num2 * 724697305) ^ -938458841;
					continue;
				case 1u:
					num = (int)(num2 * 1035263061) ^ -182242810;
					continue;
				case 0u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -26395440) ^ -1558492810;
					continue;
				case 5u:
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
		jSONArray.Add(aItem);
		Set(jSONArray);
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1042501983;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4B7E114u) % 5u)
				{
				case 4u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -917529466) ^ 0x4172D490;
					continue;
				case 1u:
					Set(jSONClass);
					num = (int)(num2 * 1479262100) ^ -217773106;
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 590679999) ^ -390122969;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 751326839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F5FF72Au) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -180838839;
						num4 = -180838839;
					}
					else
					{
						num3 = -803733524;
						num4 = -803733524;
					}
					num = num3 ^ (int)(num2 * 2076819771);
					continue;
				}
				case 6u:
					result = true;
					num = (int)(num2 * 1128477275) ^ -2095921511;
					continue;
				case 5u:
					flag = b == null;
					num = ((int)num2 * -1524573420) ^ -737751623;
					continue;
				case 3u:
					result = (object)a == b;
					num = 1746393272;
					continue;
				case 2u:
					num = (int)(num2 * 1518202396) ^ -774928970;
					continue;
				case 1u:
					num = (int)(num2 * 205468008) ^ -512453658;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -2060754573;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE616F588u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 511797618) ^ 0x23FB9B3D);
			}
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0019;
		}
		goto IL_003f;
		IL_003f:
		bool result = (object)this == obj;
		int num = 795489362;
		goto IL_001e;
		IL_001e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x7F9D9064u) % 4u)
			{
			case 3u:
				result = true;
				num = (int)(num2 * 633529718) ^ -1688016328;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_003f;
			default:
				return result;
			}
			break;
		}
		goto IL_0019;
		IL_0019:
		num = 1960169131;
		goto IL_001e;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 182409541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26D8454Cu) % 4u)
				{
				case 1u:
					result = "";
					num = ((int)num2 * -1690461192) ^ 0x7C7FCEE8;
					continue;
				case 0u:
					num = (int)((num2 * 308986388) ^ 0x1C0E24A);
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -916116452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA038177u) % 4u)
				{
				case 3u:
					result = "";
					num = (int)(num2 * 905990142) ^ -1394324367;
					continue;
				case 0u:
					num = (int)((num2 * 1537507411) ^ 0x2CCB3A86);
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
