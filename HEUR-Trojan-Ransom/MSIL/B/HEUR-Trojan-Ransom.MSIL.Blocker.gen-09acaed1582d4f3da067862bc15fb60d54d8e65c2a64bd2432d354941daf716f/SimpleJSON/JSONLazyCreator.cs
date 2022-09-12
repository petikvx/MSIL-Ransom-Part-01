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
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = 488541565;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12A33B21u) % 5u)
					{
					case 3u:
						num = (int)((num2 * 1004789340) ^ 0x1D3EAE66);
						continue;
					case 2u:
						num = ((int)num2 * -443537565) ^ -709364756;
						continue;
					case 1u:
						Set(jSONArray);
						num = ((int)num2 * -1268283155) ^ -142731006;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 1202569376;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D6893BEu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					num = (int)((num2 * 88317201) ^ 0x16E3D70F);
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = -1904478861;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2C9FA41u) % 5u)
					{
					case 4u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 647608416) ^ -1397131678;
						continue;
					case 2u:
						Set(jSONClass);
						num = (int)((num2 * 2000606022) ^ 0xED9DA5D);
						continue;
					case 0u:
						num = ((int)num2 * -1904293065) ^ 0x50EB6C27;
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

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 44177749;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3945EDD7u) % 5u)
					{
					case 4u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = (int)(num2 * 1731374386) ^ -466360679;
						continue;
					}
					case 2u:
						result = 0;
						num = ((int)num2 * -1934688023) ^ 0x2B0401;
						continue;
					case 1u:
						num = (int)((num2 * 1507566679) ^ 0x52027FFA);
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
			while (true)
			{
				int num = -706604408;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE31FD87u) % 3u)
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
					num = (int)((num2 * 665960570) ^ 0x1337A2FB);
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
				int num = 1519536973;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CD10EFCu) % 6u)
					{
					case 5u:
						result = 0f;
						num = (int)((num2 * 420703739) ^ 0x5B4F90DB);
						continue;
					case 4u:
						num = ((int)num2 * -309954341) ^ 0x1B6067CD;
						continue;
					case 2u:
						num = (int)((num2 * 1589548029) ^ 0x58B2715C);
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 1589297480) ^ 0x3BC44C72);
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
				int num = -2127231417;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF49B9320u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 2105677573) ^ -1558670358;
						continue;
					case 1u:
						num = ((int)num2 * -494076488) ^ 0x30CAC5EE;
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = default(JSONData);
			double result = default(double);
			while (true)
			{
				int num = 2107950354;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AC4F5A1u) % 7u)
					{
					case 6u:
						aVal = new JSONData(0.0);
						num = (int)(num2 * 2144907535) ^ -91885244;
						continue;
					case 5u:
						Set(aVal);
						num = (int)((num2 * 37413955) ^ 0x2B9BCFEB);
						continue;
					case 4u:
						num = (int)((num2 * 442557690) ^ 0x7974FA3B);
						continue;
					case 3u:
						num = ((int)num2 * -1055761797) ^ -52312578;
						continue;
					case 0u:
						result = 0.0;
						num = (int)((num2 * 246942107) ^ 0x4DCF8FD1);
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
				int num = -526519755;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA62FFF4u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -1371409538) ^ -1900380437;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -2130102974) ^ -1984924888;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 1407437483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A74A4E0u) % 5u)
					{
					case 2u:
						aVal = new JSONData(aData: false);
						num = (int)(num2 * 829188412) ^ -1503855839;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1667041879) ^ 0x628B1867;
						continue;
					case 0u:
						result = false;
						num = (int)(num2 * 1379441483) ^ -997704186;
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 535722878;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x765C8022u) % 6u)
					{
					case 5u:
						Set(jSONArray);
						num = (int)(num2 * 661882200) ^ -849813301;
						continue;
					case 3u:
						result = jSONArray;
						num = ((int)num2 * -1230021229) ^ -308357783;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = (int)((num2 * 1840547920) ^ 0x5CDC6B9D);
						continue;
					case 0u:
						num = (int)((num2 * 751168121) ^ 0x1D415AAD);
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
			Set(jSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 54751945;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E303DC1u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1254566345) ^ -1310565515;
						continue;
					case 1u:
						num = (int)(num2 * 1590722571) ^ -664942988;
						continue;
					case 0u:
						result = jSONClass;
						num = (int)(num2 * 2040753520) ^ -1072454275;
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
		while (true)
		{
			int num = -1382947125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD65A7099u) % 5u)
				{
				case 4u:
					m_Node = aNode;
					m_Key = null;
					num = (int)(num2 * 163919579) ^ -1838043080;
					continue;
				case 3u:
					num = (int)(num2 * 699810856) ^ -1798785203;
					continue;
				case 1u:
					num = ((int)num2 * -742552620) ^ -1983458586;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -569684687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5BC4AB4u) % 3u)
				{
				case 1u:
					goto IL_0016;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0016:
				m_Node = aNode;
				m_Key = aKey;
				num = (int)((num2 * 1583189190) ^ 0x5DA0E425);
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = 1241472503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1269AFB2u) % 8u)
				{
				case 6u:
					m_Node.Add(aVal);
					num = (int)(num2 * 579974716) ^ -2040016290;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = -1713903829;
						num4 = -1713903829;
					}
					else
					{
						num3 = -164298452;
						num4 = -164298452;
					}
					num = num3 ^ ((int)num2 * -1651768704);
					continue;
				}
				case 4u:
					num = (int)((num2 * 451845204) ^ 0x8BD29F9);
					continue;
				case 3u:
					m_Node = null;
					num = 1412813269;
					continue;
				case 2u:
					num = ((int)num2 * -1620750122) ^ 0x3F46DDB5;
					continue;
				case 1u:
					m_Node.Add(m_Key, aVal);
					num = 607890136;
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public override void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 168164451;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C290542u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 458739091) ^ 0x265303C1);
					continue;
				case 1u:
				{
					JSONArray jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					Set(jSONArray);
					num = ((int)num2 * -15317646) ^ 0x3936CDF7;
					continue;
				}
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
			int num = -941396713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1673FF7u) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = (int)((num2 * 76458804) ^ 0x56F8445F);
					continue;
				case 3u:
					num = (int)(num2 * 1877544652) ^ -254683225;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -625983122) ^ -526238972;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1569509933;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2647185Au) % 8u)
				{
				case 7u:
					flag = b == null;
					num = (int)((num2 * 1052990640) ^ 0x29696FEE);
					continue;
				case 5u:
					result = (object)a == b;
					num = 1589604089;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -802130817;
						num4 = -802130817;
					}
					else
					{
						num3 = -10910822;
						num4 = -10910822;
					}
					num = num3 ^ ((int)num2 * -1104850902);
					continue;
				}
				case 3u:
					num = ((int)num2 * -58785424) ^ 0x698CC680;
					continue;
				case 1u:
					num = ((int)num2 * -401665458) ^ 0x7699C40E;
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -741615131) ^ -1225988501;
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
			int num = 1250823184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1854A95u) % 3u)
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
				num = (int)(num2 * 1727763013) ^ -672886963;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -2068276353;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5651141u) % 7u)
				{
				case 6u:
					num = (int)(num2 * 1710115212) ^ -302476889;
					continue;
				case 5u:
					result = (object)this == obj;
					num = -995931902;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -648037855;
						num4 = -648037855;
					}
					else
					{
						num3 = -5227285;
						num4 = -5227285;
					}
					num = num3 ^ ((int)num2 * -743708694);
					continue;
				}
				case 3u:
					result = true;
					num = (int)(num2 * 1451982985) ^ -81767681;
					continue;
				case 2u:
					num = (int)((num2 * 868303110) ^ 0x71CDEB55);
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
			int num = -1115396223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDEC0394u) % 3u)
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
				num = (int)(num2 * 639383375) ^ -1854700571;
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
			int num = -237343107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED3692DBu) % 3u)
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
				num = ((int)num2 * -1291134240) ^ -542281732;
			}
		}
	}
}
