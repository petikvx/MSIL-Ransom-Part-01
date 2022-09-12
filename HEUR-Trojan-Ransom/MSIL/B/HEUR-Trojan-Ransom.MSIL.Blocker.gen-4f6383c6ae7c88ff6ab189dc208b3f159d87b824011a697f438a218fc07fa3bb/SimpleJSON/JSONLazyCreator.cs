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
				int num = -1381909325;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x95B94367u) % 3u)
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
					result = new JSONLazyCreator(this);
					num = (int)(num2 * 23983135) ^ -289136259;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1607583124;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6930F41Cu) % 6u)
					{
					case 3u:
						num = (int)(num2 * 1097105983) ^ -619403783;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 458548675) ^ -2113541879;
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -1630541319) ^ 0x2473CF9A;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)(num2 * 701685883) ^ -597982275;
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
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1651053222;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FB86908u) % 3u)
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
					num = ((int)num2 * -2048685015) ^ 0x44779DE;
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			Set(jSONClass);
			while (true)
			{
				int num = 135529504;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F81538Au) % 3u)
					{
					case 1u:
						goto IL_0017;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0017:
					num = ((int)num2 * -268047759) ^ 0x72323776;
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
				int num = -1040961571;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD540294u) % 6u)
					{
					case 5u:
						aVal = new JSONData(0);
						num = (int)((num2 * 837378258) ^ 0x14CF7D7B);
						continue;
					case 2u:
						result = 0;
						num = (int)(num2 * 881685153) ^ -464510758;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1174678346) ^ 0x443E5616;
						continue;
					case 0u:
						num = (int)((num2 * 555465225) ^ 0xFA5CF8B);
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
				int num = -1547813025;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC90948Au) % 4u)
					{
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)(num2 * 133682732) ^ -389224654;
						continue;
					}
					case 0u:
						num = (int)((num2 * 1696610) ^ 0x7DD5FE54);
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
	}

	public override float AsFloat
	{
		get
		{
			JSONData aVal = default(JSONData);
			float result = default(float);
			while (true)
			{
				int num = -898701608;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA200AB4u) % 6u)
					{
					case 5u:
						Set(aVal);
						num = (int)(num2 * 599716226) ^ -1117274409;
						continue;
					case 4u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -1963197063) ^ -1931732575;
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -1139512958) ^ 0x374D4AF2;
						continue;
					case 2u:
						num = (int)(num2 * 1870165294) ^ -13021173;
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
				int num = 1486698156;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11089D71u) % 3u)
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
					num = (int)(num2 * 2086643113) ^ -763230057;
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
				int num = -850987345;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B21D3CAu) % 6u)
					{
					case 4u:
						result = 0.0;
						num = ((int)num2 * -191491640) ^ 0x5196931F;
						continue;
					case 3u:
						aVal = new JSONData(0.0);
						num = (int)((num2 * 125345757) ^ 0x6D1B8DDD);
						continue;
					case 2u:
						Set(aVal);
						num = ((int)num2 * -234134542) ^ 0x2E71BF2;
						continue;
					case 1u:
						num = (int)((num2 * 1057070667) ^ 0x4E49B17D);
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 1321018401;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x285E1628u) % 5u)
					{
					case 4u:
						num = (int)((num2 * 2045898670) ^ 0x49123291);
						continue;
					case 3u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1076903779) ^ -418201672;
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 2091412230) ^ 0x68C3D075);
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

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = 879179389;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x353CF63Bu) % 5u)
					{
					case 4u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -1114654118) ^ 0x7AE57366;
						continue;
					}
					case 3u:
						num = ((int)num2 * -327447920) ^ -249184360;
						continue;
					case 2u:
						result = false;
						num = ((int)num2 * -2010333903) ^ 0x7D73512A;
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
				int num = 1897343044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C4CAB10u) % 5u)
					{
					case 4u:
						aVal = new JSONData(value);
						num = (int)(num2 * 413507395) ^ -1208721923;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -965513541) ^ 0xC564EE3;
						continue;
					case 1u:
						num = ((int)num2 * -1041491842) ^ -1602040533;
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
			JSONArray result = default(JSONArray);
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -136883653;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87CE986Au) % 6u)
					{
					case 5u:
						result = jSONArray;
						num = ((int)num2 * -1190917637) ^ 0x458EE201;
						continue;
					case 3u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -844667120) ^ -611329608;
						continue;
					case 2u:
						Set(jSONArray);
						num = (int)((num2 * 698075023) ^ 0x4DADDE61);
						continue;
					case 1u:
						num = (int)(num2 * 1512672735) ^ -2037857110;
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
				int num = 710853334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3131D3D3u) % 6u)
					{
					case 5u:
						Set(jSONClass);
						num = ((int)num2 * -1838174859) ^ 0x5A8F3318;
						continue;
					case 4u:
						result = jSONClass;
						num = ((int)num2 * -455675298) ^ 0x7AA4A656;
						continue;
					case 2u:
						num = (int)((num2 * 1459789572) ^ 0x759E8E9);
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -357984538) ^ -2143516056;
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

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = -403171086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x891FB46Cu) % 5u)
				{
				case 3u:
					num = (int)(num2 * 377120641) ^ -1010214242;
					continue;
				case 1u:
					num = (int)(num2 * 1152121747) ^ -1042155991;
					continue;
				case 0u:
					m_Node = aNode;
					num = (int)(num2 * 2114469148) ^ -175165067;
					continue;
				case 4u:
					break;
				default:
					m_Key = null;
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
			int num = -1506866504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB445FDD4u) % 9u)
				{
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1995895510) ^ -1554311826;
					continue;
				case 6u:
					num = (int)(num2 * 2144147200) ^ -753955815;
					continue;
				case 5u:
					num = (int)((num2 * 458315969) ^ 0x18DABEE5);
					continue;
				case 4u:
					num = -282468236;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = 692855881;
						num4 = 692855881;
					}
					else
					{
						num3 = 1359571612;
						num4 = 1359571612;
					}
					num = num3 ^ (int)(num2 * 1636002262);
					continue;
				}
				case 1u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1983830333) ^ -1100729125;
					continue;
				case 0u:
					num = ((int)num2 * -434537644) ^ 0xB3E7BC4;
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
		jSONArray.Add(aItem);
		while (true)
		{
			int num = 1855513261;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7558D1DDu) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				Set(jSONArray);
				num = (int)((num2 * 2110225402) ^ 0x5EA27609);
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1415529982;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97B70D18u) % 4u)
				{
				case 2u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 420467242) ^ 0x7384FFF1);
					continue;
				case 1u:
					num = ((int)num2 * -1846961100) ^ -1712482268;
					continue;
				case 3u:
					break;
				default:
					Set(jSONClass);
					return;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -762955075;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1186678u) % 6u)
				{
				case 5u:
					result = (object)a == b;
					num = -2142519962;
					continue;
				case 3u:
					flag = b == null;
					num = ((int)num2 * -610570036) ^ -725546443;
					continue;
				case 2u:
					result = true;
					num = ((int)num2 * -1267616321) ^ -205687592;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1087164412;
						num4 = -1087164412;
					}
					else
					{
						num3 = -934208925;
						num4 = -934208925;
					}
					num = num3 ^ ((int)num2 * -1435485783);
					continue;
				}
				case 4u:
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
			int num = -405057957;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7E20152u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1730948954) ^ -1083052483;
			}
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0017;
		}
		goto IL_0065;
		IL_0065:
		bool result = (object)this == obj;
		int num = -361763481;
		goto IL_003c;
		IL_003c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x84250FFEu) % 6u)
			{
			case 5u:
				num = (int)(num2 * 1608503810) ^ -44842848;
				continue;
			case 3u:
				break;
			case 2u:
				result = true;
				num = ((int)num2 * -243525393) ^ 0x2FA05943;
				continue;
			case 1u:
				num = (int)((num2 * 1675888588) ^ 0x5F476BBE);
				continue;
			case 0u:
				goto IL_0065;
			default:
				return result;
			}
			break;
		}
		goto IL_0017;
		IL_0017:
		num = -967697678;
		goto IL_003c;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 690095737;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44AC597Au) % 4u)
				{
				case 3u:
					hashCode = base.GetHashCode();
					num = (int)(num2 * 1591064034) ^ -1562155212;
					continue;
				case 0u:
					num = ((int)num2 * -1569602269) ^ 0x2229C0D3;
					continue;
				case 2u:
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
			int num = -228002709;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A9D8572u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -751937676) ^ -659145448;
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -265989532) ^ 0x10EF3791;
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
			int num = -1742376971;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC38AE3B7u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1702412914) ^ -650777;
			}
		}
	}
}
