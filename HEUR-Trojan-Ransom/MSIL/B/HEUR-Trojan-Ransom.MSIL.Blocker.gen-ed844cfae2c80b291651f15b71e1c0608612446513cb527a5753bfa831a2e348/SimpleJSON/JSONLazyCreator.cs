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
				int num = 1646509890;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64898047u) % 3u)
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
					result = new JSONLazyCreator(this);
					num = (int)(num2 * 1869668352) ^ -431957817;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = -2127337107;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C8F7F3Fu) % 4u)
					{
					case 2u:
						jSONArray.Add(value);
						num = (int)(num2 * 326013948) ^ -1825765166;
						continue;
					case 1u:
						num = ((int)num2 * -611018585) ^ -1789327588;
						continue;
					case 3u:
						break;
					default:
						Set(jSONArray);
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
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			Set(jSONClass);
		}
	}

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			Set(aVal);
			int result = default(int);
			while (true)
			{
				int num = -1769197508;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C5D3EA9u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 2105695074) ^ 0x717EAAC2);
						continue;
					case 1u:
						result = 0;
						num = (int)((num2 * 853271160) ^ 0x2789950F);
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
			Set(aVal);
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
				int num = 1145117821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x18AA3816u) % 6u)
					{
					case 5u:
						Set(aVal);
						num = ((int)num2 * -774838944) ^ 0x75CD388E;
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -1258743635) ^ -304874353;
						continue;
					case 2u:
						num = ((int)num2 * -288940384) ^ -1302823193;
						continue;
					case 0u:
						num = (int)((num2 * 803305003) ^ 0x54946CD5);
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
			Set(aVal);
			while (true)
			{
				int num = 1884348622;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74EF3443u) % 3u)
					{
					case 2u:
						goto IL_0010;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0010:
					num = ((int)num2 * -1051341827) ^ -586363125;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			JSONData aVal = default(JSONData);
			double result = default(double);
			while (true)
			{
				int num = -726056981;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFCE69A2u) % 6u)
					{
					case 5u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1868293535) ^ -1573517273;
						continue;
					case 4u:
						result = 0.0;
						num = ((int)num2 * -1333175692) ^ 0x6961603F;
						continue;
					case 3u:
						num = ((int)num2 * -2121743795) ^ 0x47B20F48;
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 261570966) ^ -1024387590;
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
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = -577935055;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE2BE09ACu) % 3u)
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
					num = ((int)num2 * -1142750105) ^ 0x67B13704;
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
				int num = -1004166495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5638907u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -494437872) ^ -2095317648;
						continue;
					case 2u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -318805479) ^ 0x41F297F4;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -2124195555) ^ -1738377080;
						continue;
					case 0u:
						result = false;
						num = ((int)num2 * -1552943642) ^ 0x66F10CBA;
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 764655386;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5C85A8ABu) % 5u)
					{
					case 4u:
						Set(aVal);
						num = (int)((num2 * 673845303) ^ 0x32B6375F);
						continue;
					case 3u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1719842928) ^ 0x532F68E8;
						continue;
					case 1u:
						num = ((int)num2 * -505287462) ^ -325250024;
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1970551496;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x884578E6u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					Set(jSONArray);
					result = jSONArray;
					num = (int)(num2 * 189872274) ^ -313992526;
				}
			}
		}
	}

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = new JSONClass();
			Set(jSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -1138231640;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFDBBD84u) % 5u)
					{
					case 4u:
						num = (int)((num2 * 249403121) ^ 0x7D94FF50);
						continue;
					case 2u:
						result = jSONClass;
						num = (int)((num2 * 980582292) ^ 0x3C4205A7);
						continue;
					case 0u:
						num = ((int)num2 * -1084488072) ^ -681028300;
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
		while (true)
		{
			int num = -2039886322;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E7AD881u) % 4u)
				{
				case 3u:
					m_Node = aNode;
					num = (int)((num2 * 1261787448) ^ 0x43959BAD);
					continue;
				case 0u:
					m_Key = null;
					num = ((int)num2 * -2017081373) ^ 0x45805610;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		m_Node = aNode;
		m_Key = aKey;
	}

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = 235120967;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4979A8C2u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1026546876) ^ -671829166;
					continue;
				case 8u:
					num = (int)(num2 * 1942590847) ^ -1630964237;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = 2129446339;
						num4 = 2129446339;
					}
					else
					{
						num3 = 1462289971;
						num4 = 1462289971;
					}
					num = num3 ^ (int)(num2 * 1296460321);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1488378046) ^ 0x742C17F);
					continue;
				case 5u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1625710860) ^ 0x40C12B9B;
					continue;
				case 3u:
					m_Node = null;
					num = 1531155474;
					continue;
				case 2u:
					num = 1561852561;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1586267610) ^ -593063655;
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

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 173309153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11229C7Bu) % 4u)
				{
				case 2u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -75411976) ^ -20732614;
					continue;
				case 1u:
					num = (int)((num2 * 1267046977) ^ 0x26EE96DE);
					continue;
				case 3u:
					break;
				default:
					Set(jSONArray);
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
			int num = -1866138825;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1F7B69Au) % 6u)
				{
				case 5u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 388115726) ^ 0x122B6114);
					continue;
				case 4u:
					Set(jSONClass);
					num = (int)(num2 * 1884040847) ^ -399365363;
					continue;
				case 3u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1897869204) ^ 0x7BE23099);
					continue;
				case 1u:
					num = (int)(num2 * 2059074749) ^ -1161149137;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		if (b == null)
		{
			goto IL_0028;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)a == b;
		int num = -72066864;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8CC3BB86u) % 5u)
			{
			case 4u:
				result = true;
				num = ((int)num2 * -726674103) ^ 0x3512E4E8;
				continue;
			case 3u:
				num = (int)((num2 * 795532123) ^ 0x71ED4917);
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
		num = -1801806955;
		goto IL_002d;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1776864722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F636FE8u) % 3u)
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
				result = !(a == b);
				num = (int)((num2 * 1464023840) ^ 0x36BDB00C);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 968259287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x494E0C2Eu) % 7u)
				{
				case 5u:
					result = (object)this == obj;
					num = 327285426;
					continue;
				case 3u:
					result = true;
					num = (int)(num2 * 1617673884) ^ -1498358707;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -326476259;
						num4 = -326476259;
					}
					else
					{
						num3 = -1873766700;
						num4 = -1873766700;
					}
					num = num3 ^ ((int)num2 * -1035564809);
					continue;
				}
				case 1u:
					flag = obj == null;
					num = (int)((num2 * 1676908643) ^ 0x5CDF8CFD);
					continue;
				case 0u:
					num = (int)(num2 * 1617660) ^ -1282366426;
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

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = -1981873019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE2094E3u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 812637981) ^ -154882699;
					continue;
				case 2u:
					hashCode = base.GetHashCode();
					num = (int)(num2 * 1269624518) ^ -610180492;
					continue;
				case 0u:
					break;
				default:
					return hashCode;
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
			int num = -626195958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB7981A7u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 550321894) ^ 0x6075A3DC);
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -1202553915) ^ -1697831416;
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
			int num = 1315874473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E73621Au) % 4u)
				{
				case 3u:
					result = "";
					num = ((int)num2 * -1569047684) ^ -874592785;
					continue;
				case 1u:
					num = ((int)num2 * -1516199408) ^ 0x5BAD8DF0;
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
