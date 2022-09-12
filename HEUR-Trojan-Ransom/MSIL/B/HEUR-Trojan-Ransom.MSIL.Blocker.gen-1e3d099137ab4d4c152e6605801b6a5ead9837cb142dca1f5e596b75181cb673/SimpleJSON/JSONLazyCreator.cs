namespace SimpleJSON;

internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node = null;

	private string m_Key = null;

	public override JSONNode this[int aIndex]
	{
		get
		{
			return new JSONLazyCreator(this);
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1444080086;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x43C2B06Cu) % 4u)
					{
					case 3u:
						jSONArray.Add(value);
						Set(jSONArray);
						num = (int)(num2 * 558923335) ^ -1835102304;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1701347629) ^ 0x3770BFB5;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			return new JSONLazyCreator(this, aKey);
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = -284355039;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99C5D3EDu) % 5u)
					{
					case 4u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 125757936) ^ -1701977375;
						continue;
					case 2u:
						Set(jSONClass);
						num = (int)(num2 * 1433428459) ^ -178250100;
						continue;
					case 1u:
						num = ((int)num2 * -1966757248) ^ 0x2064823;
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

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = -1599952950;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC128C21Eu) % 5u)
					{
					case 4u:
						result = 0;
						num = (int)(num2 * 1809143986) ^ -1745376162;
						continue;
					case 3u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = ((int)num2 * -1266035937) ^ -1102857793;
						continue;
					}
					case 2u:
						num = ((int)num2 * -771477444) ^ -807249783;
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
				int num = 559307356;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x76E66345u) % 4u)
					{
					case 1u:
						Set(aVal);
						result = 0f;
						num = ((int)num2 * -1917777872) ^ 0x4E401371;
						continue;
					case 0u:
						num = ((int)num2 * -1858923360) ^ 0x7F2D1862;
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
			while (true)
			{
				int num = 2068691262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x51880DF8u) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = ((int)num2 * -566350301) ^ -750355381;
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
				int num = 44907301;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4659118Cu) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 549023889) ^ -831947785;
						continue;
					case 2u:
						result = 0.0;
						num = (int)(num2 * 1154246769) ^ -1684589857;
						continue;
					case 1u:
						num = ((int)num2 * -1777742344) ^ -1567739114;
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
				int num = -382929903;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCF00DAFCu) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = ((int)num2 * -138654888) ^ -1158593217;
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
				int num = 743791627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11EB044Du) % 6u)
					{
					case 5u:
						num = (int)((num2 * 71315990) ^ 0x14BB5F64);
						continue;
					case 4u:
						aVal = new JSONData(aData: false);
						num = (int)((num2 * 1443855731) ^ 0x7F1C8D23);
						continue;
					case 2u:
						result = false;
						num = ((int)num2 * -854127564) ^ 0x71366D0E;
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 1871297610) ^ -2117590653;
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
				int num = -1678319879;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA35594Cu) % 3u)
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
					num = (int)((num2 * 1886563859) ^ 0x3735955D);
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
				int num = -1246590693;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCB9C98DAu) % 6u)
					{
					case 4u:
						Set(jSONArray);
						num = (int)(num2 * 1900747900) ^ -191693253;
						continue;
					case 3u:
						result = jSONArray;
						num = ((int)num2 * -128161285) ^ 0x55A2C35;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1602376603) ^ -1622528229;
						continue;
					case 0u:
						num = (int)(num2 * 304347637) ^ -2002111197;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 2110972985;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x359C2F4Bu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					JSONClass jSONClass = new JSONClass();
					Set(jSONClass);
					result = jSONClass;
					num = ((int)num2 * -123244493) ^ 0x4D049632;
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
			int num = -1092223677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6D6BD47u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 1154500482) ^ -1459944526;
					continue;
				case 3u:
					m_Key = aKey;
					num = (int)(num2 * 57045013) ^ -941094655;
					continue;
				case 2u:
					num = (int)((num2 * 1500332235) ^ 0x5BE79E77);
					continue;
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -246475142) ^ 0x7CD42156;
					continue;
				default:
					return;
				case 0u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -188158743;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE53BF66u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 1233223886) ^ 0x3A5FF13E);
					continue;
				case 7u:
					flag = m_Key == null;
					num = ((int)num2 * -1297102903) ^ -1972118240;
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1768667476) ^ -1069587696;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 891842941;
						num4 = 891842941;
					}
					else
					{
						num3 = 221842379;
						num4 = 221842379;
					}
					num = num3 ^ ((int)num2 * -830321864);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1508387838) ^ -456367841;
					continue;
				case 2u:
					num = -1087498726;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = (int)((num2 * 1262319312) ^ 0x52E9E9BF);
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
			int num = 289783349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49C556FCu) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1837828577) ^ 0x7F943FD9;
					continue;
				case 3u:
					num = (int)(num2 * 499906616) ^ -1758268946;
					continue;
				case 2u:
					Set(jSONArray);
					num = (int)((num2 * 1630937587) ^ 0x73F2F589);
					continue;
				case 1u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -1137943571) ^ 0x329F6638;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		jSONClass.Add(aKey, aItem);
		Set(jSONClass);
		while (true)
		{
			int num = -354752883;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEFF14BDu) % 3u)
				{
				case 1u:
					goto IL_0017;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0017:
				num = (int)((num2 * 1721845070) ^ 0x3D5D0F36);
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1858072657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FFC3120u) % 6u)
				{
				case 5u:
					result = (object)a == b;
					num = 694259302;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -976583618;
						num4 = -976583618;
					}
					else
					{
						num3 = -1845474309;
						num4 = -1845474309;
					}
					num = num3 ^ ((int)num2 * -374820411);
					continue;
				}
				case 1u:
					flag = b == null;
					num = ((int)num2 * -1697662309) ^ -358987835;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 66223530) ^ 0x6555DE16);
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1967744973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F192038u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -276231539) ^ 0x3263576D;
					continue;
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -1473110129) ^ 0xA5C84CD;
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

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = 448454940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x697BB8C7u) % 6u)
				{
				case 4u:
					result = true;
					num = ((int)num2 * -737091576) ^ -531085026;
					continue;
				case 2u:
					result = (object)this == obj;
					num = 1989778879;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -837566866;
						num4 = -837566866;
					}
					else
					{
						num3 = -1638147916;
						num4 = -1638147916;
					}
					num = num3 ^ (int)(num2 * 1623485821);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1539163362) ^ 0x4FDD473E;
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
		return base.GetHashCode();
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 666577533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x206E5E78u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1801923322) ^ 0x769FB583;
					continue;
				case 1u:
					result = "";
					num = (int)((num2 * 1301957481) ^ 0x312C46EB);
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
		string result = "";
		while (true)
		{
			int num = -1325295083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x889C332Du) % 3u)
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
				num = ((int)num2 * -943752532) ^ 0x78920350;
			}
		}
	}
}
