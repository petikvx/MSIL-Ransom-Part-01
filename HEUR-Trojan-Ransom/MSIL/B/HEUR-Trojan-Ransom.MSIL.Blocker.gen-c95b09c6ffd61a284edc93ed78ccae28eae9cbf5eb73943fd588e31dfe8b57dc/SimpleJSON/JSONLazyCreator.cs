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
				int num = -2108169276;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9189C4F8u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)(num2 * 519043529) ^ -296382698;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = 1510089779;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E1F1B18u) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						Set(jSONArray);
						return;
					}
					break;
					IL_000f:
					num = (int)(num2 * 306568686) ^ -276985715;
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
				int num = -340142659;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE0CF4F3u) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -827305858) ^ 0x28C8D5FE;
						continue;
					case 1u:
						num = ((int)num2 * -1259382687) ^ -1426161667;
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
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			while (true)
			{
				int num = 11341120;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58797D4Fu) % 3u)
					{
					case 1u:
						goto IL_0010;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0010:
					Set(jSONClass);
					num = ((int)num2 * -1491528869) ^ 0x3DA9D39B;
				}
			}
		}
	}

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			int result = default(int);
			while (true)
			{
				int num = 1254084906;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22FE27Eu) % 5u)
					{
					case 4u:
						result = 0;
						num = (int)(num2 * 1393881011) ^ -1573378635;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -2017164824) ^ 0x1DEBBD70;
						continue;
					case 0u:
						num = (int)(num2 * 345019865) ^ -246056231;
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
			Set(aVal);
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
				int num = -1580975356;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4616CB2u) % 5u)
					{
					case 2u:
						Set(aVal);
						num = (int)(num2 * 956122960) ^ -1084322919;
						continue;
					case 1u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 2065007672) ^ 0x75965FD7);
						continue;
					case 0u:
						result = 0f;
						num = (int)((num2 * 117703057) ^ 0x71FACB74);
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
				int num = -830245360;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0512C80u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						Set(aVal);
						return;
					}
					break;
					IL_0003:
					aVal = new JSONData(value);
					num = ((int)num2 * -2000722009) ^ -1138966888;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			double result = default(double);
			while (true)
			{
				int num = -1923128694;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC40842E4u) % 5u)
					{
					case 3u:
						result = 0.0;
						num = (int)(num2 * 557688704) ^ -419896943;
						continue;
					case 2u:
						num = (int)((num2 * 152848415) ^ 0x54D04598);
						continue;
					case 1u:
						num = (int)(num2 * 478123868) ^ -716963099;
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
		}
	}

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = 642144451;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29D8EDA2u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 2137577614) ^ 0xFD70A5C);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						result = false;
						num = (int)((num2 * 1577405917) ^ 0x1BEFA9B4);
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
		set
		{
			JSONData aVal = new JSONData(value);
			Set(aVal);
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
				int num = 1547913046;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4465B4AAu) % 5u)
					{
					case 4u:
						result = jSONArray;
						num = (int)((num2 * 1528704307) ^ 0x181176D);
						continue;
					case 2u:
						Set(jSONArray);
						num = (int)((num2 * 1025459690) ^ 0xE7B4505);
						continue;
					case 0u:
						num = ((int)num2 * -2089756654) ^ 0x68323A56;
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
				int num = 139101447;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F87C646u) % 6u)
					{
					case 5u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 2041594104) ^ 0x25E2D840);
						continue;
					case 4u:
						num = (int)(num2 * 928822077) ^ -1213577837;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -1340506647) ^ -727181632;
						continue;
					case 0u:
						Set(jSONClass);
						num = ((int)num2 * -1998847526) ^ -1888212534;
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
			int num = -918154176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF82057CFu) % 6u)
				{
				case 3u:
					m_Key = aKey;
					num = ((int)num2 * -628079293) ^ -956164951;
					continue;
				case 2u:
					num = (int)((num2 * 100877521) ^ 0x350249D3);
					continue;
				case 1u:
					num = (int)((num2 * 1549048038) ^ 0xABF4AED);
					continue;
				case 0u:
					m_Node = aNode;
					num = (int)((num2 * 1622084789) ^ 0x3F22A9DE);
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
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
			int num = 225050501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F7DAF30u) % 11u)
				{
				case 10u:
					m_Node = null;
					num = 1569542850;
					continue;
				case 9u:
					num = ((int)num2 * -1056103136) ^ -1376071803;
					continue;
				case 8u:
					m_Node.Add(aVal);
					num = (int)((num2 * 429111747) ^ 0x5EA1D082);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = 1664156277;
						num4 = 1664156277;
					}
					else
					{
						num3 = 174057162;
						num4 = 174057162;
					}
					num = num3 ^ (int)(num2 * 1160180205);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1899381114) ^ 0xAB4BD0E;
					continue;
				case 3u:
					num = (int)((num2 * 1952728382) ^ 0x32F02538);
					continue;
				case 2u:
					num = ((int)num2 * -482903625) ^ -1484327089;
					continue;
				case 1u:
					m_Node.Add(m_Key, aVal);
					num = 1715335600;
					continue;
				case 0u:
					num = (int)((num2 * 1645615631) ^ 0x96B23AA);
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
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
			int num = -1691984036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB13328Fu) % 4u)
				{
				case 3u:
					jSONArray.Add(aItem);
					num = (int)((num2 * 1447067625) ^ 0x18961922);
					continue;
				case 2u:
					Set(jSONArray);
					num = (int)(num2 * 1752633683) ^ -2047149984;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = -2138485479;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83BB5A43u) % 5u)
				{
				case 2u:
					Set(jSONClass);
					num = (int)(num2 * 2080044724) ^ -274900392;
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -767526511) ^ -1898313644;
					continue;
				case 0u:
					num = (int)(num2 * 972573344) ^ -1731068806;
					continue;
				default:
					return;
				case 4u:
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
			int num = -506753076;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA74D160Cu) % 7u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 280693681;
						num4 = 280693681;
					}
					else
					{
						num3 = 2143347163;
						num4 = 2143347163;
					}
					num = num3 ^ (int)(num2 * 1036653501);
					continue;
				}
				case 3u:
					num = ((int)num2 * -2088527304) ^ -1846819931;
					continue;
				case 2u:
					result = true;
					num = ((int)num2 * -14994493) ^ -1154946680;
					continue;
				case 1u:
					flag = b == null;
					num = ((int)num2 * -1853822625) ^ -532582322;
					continue;
				case 0u:
					result = (object)a == b;
					num = -760603715;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1285908342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EAA936Fu) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -1626117633) ^ 0x327EF29C;
					continue;
				case 0u:
					num = ((int)num2 * -750069693) ^ 0x3DC1B9;
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
		bool result = default(bool);
		while (true)
		{
			int num = 1704843713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25C18A3Au) % 6u)
				{
				case 4u:
					result = true;
					num = ((int)num2 * -1773582506) ^ 0x4C4F0A7D;
					continue;
				case 3u:
					num = ((int)num2 * -1628046718) ^ 0x20BD2C0F;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (obj == null)
					{
						num3 = -1616909899;
						num4 = -1616909899;
					}
					else
					{
						num3 = -1488003871;
						num4 = -1488003871;
					}
					num = num3 ^ ((int)num2 * -248508515);
					continue;
				}
				case 0u:
					result = (object)this == obj;
					num = 12476387;
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = 940180918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23DFD6D9u) % 3u)
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
				num = (int)((num2 * 652824270) ^ 0x858629B);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1671934104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x928D0ABBu) % 4u)
				{
				case 3u:
					result = "";
					num = (int)((num2 * 765563668) ^ 0x267614A5);
					continue;
				case 2u:
					num = (int)((num2 * 684282172) ^ 0x2E2CA89E);
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
		return "";
	}
}
