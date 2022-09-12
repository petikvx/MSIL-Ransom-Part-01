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
				int num = 1546489507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64B7501Au) % 3u)
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
					num = ((int)num2 * -728457850) ^ -319104984;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = -645986583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F596A7Eu) % 4u)
					{
					case 3u:
						jSONArray.Add(value);
						num = (int)((num2 * 1251569540) ^ 0x31B25186);
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)(num2 * 972041619) ^ -17717281;
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
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 602103211;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA6A24CEu) % 3u)
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
					num = ((int)num2 * -702497985) ^ 0x42FA4391;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1963693618;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30AF3CB7u) % 4u)
					{
					case 2u:
						jSONClass.Add(aKey, value);
						Set(jSONClass);
						num = ((int)num2 * -1081974350) ^ 0x7B7BE367;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 1207036884) ^ 0x52DB3AF9);
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
				int num = -548375177;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5398678u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1673881960) ^ 0x5CA3318C;
						continue;
					case 3u:
						result = 0;
						num = (int)((num2 * 515599731) ^ 0x1F08122A);
						continue;
					case 2u:
						num = ((int)num2 * -1933184269) ^ 0x17D1B03;
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
				int num = -940109260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x811FC35Du) % 3u)
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
					num = ((int)num2 * -1780537865) ^ 0x6A443D43;
				}
			}
		}
	}

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = -1318317461;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF6FEE7Au) % 3u)
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
					JSONData aVal = new JSONData(0f);
					Set(aVal);
					result = 0f;
					num = ((int)num2 * -1084539418) ^ -1130785323;
				}
			}
		}
		set
		{
			JSONData aVal = new JSONData(value);
			Set(aVal);
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
				int num = -171079759;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD141F75Cu) % 6u)
					{
					case 5u:
						result = 0.0;
						num = (int)(num2 * 1319421201) ^ -1012083113;
						continue;
					case 4u:
						num = ((int)num2 * -822352491) ^ 0x269AF8B8;
						continue;
					case 3u:
						Set(aVal);
						num = (int)(num2 * 1276525297) ^ -1802519546;
						continue;
					case 1u:
						num = ((int)num2 * -1438271520) ^ -1694233833;
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
				int num = 1067414573;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74B98052u) % 3u)
					{
					case 1u:
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
					num = ((int)num2 * -2063102523) ^ -1076875539;
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
				int num = 729318001;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30C990A8u) % 7u)
					{
					case 5u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -1577734896) ^ -1852161474;
						continue;
					case 4u:
						Set(aVal);
						num = ((int)num2 * -1295106792) ^ -174750455;
						continue;
					case 2u:
						result = false;
						num = (int)(num2 * 474188426) ^ -722518461;
						continue;
					case 1u:
						num = ((int)num2 * -1065492814) ^ -1018041983;
						continue;
					case 0u:
						num = (int)(num2 * 2077819238) ^ -2070678122;
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
				int num = 1962914273;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x478E8D52u) % 6u)
					{
					case 4u:
						Set(jSONArray);
						num = ((int)num2 * -280511293) ^ 0x1349CD3C;
						continue;
					case 3u:
						num = ((int)num2 * -980496227) ^ -272486987;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = (int)((num2 * 1178264411) ^ 0x1ABB2473);
						continue;
					case 0u:
						result = jSONArray;
						num = (int)(num2 * 1444775383) ^ -26612197;
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
	}

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -628503100;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE56D8A04u) % 5u)
					{
					case 4u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 487718122) ^ 0x58EE74A2);
						continue;
					case 3u:
						num = (int)(num2 * 1796504723) ^ -1795566738;
						continue;
					case 0u:
						result = jSONClass;
						num = ((int)num2 * -606230257) ^ -811926285;
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
			int num = 401197338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25CF7FA3u) % 4u)
				{
				case 3u:
					m_Node = aNode;
					num = (int)(num2 * 959896163) ^ -1955628058;
					continue;
				case 1u:
					num = ((int)num2 * -530154287) ^ 0x67701245;
					continue;
				case 2u:
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
		while (true)
		{
			int num = -1572420746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97A90BFFu) % 4u)
				{
				case 3u:
					m_Node = aNode;
					num = (int)(num2 * 1533302389) ^ -2024088404;
					continue;
				case 1u:
					num = (int)(num2 * 1759728072) ^ -1948559972;
					continue;
				case 2u:
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
			int num = -8911029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F4AC230u) % 8u)
				{
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = -353205567;
					continue;
				case 6u:
					num = ((int)num2 * -1309309830) ^ 0x53A76A61;
					continue;
				case 5u:
					num = (int)((num2 * 1282393288) ^ 0x357897B2);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = -217663581;
						num4 = -217663581;
					}
					else
					{
						num3 = -741480716;
						num4 = -741480716;
					}
					num = num3 ^ (int)(num2 * 55738441);
					continue;
				}
				case 1u:
					num = ((int)num2 * -918473800) ^ 0x31E7F3A2;
					continue;
				case 0u:
					m_Node.Add(aVal);
					num = ((int)num2 * -293189328) ^ -1197033898;
					continue;
				case 4u:
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
		while (true)
		{
			int num = -1633775514;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA3806B3u) % 3u)
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
				JSONArray jSONArray = new JSONArray();
				jSONArray.Add(aItem);
				Set(jSONArray);
				num = ((int)num2 * -241712809) ^ 0xD3B2CAB;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 275899148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18278C09u) % 6u)
				{
				case 5u:
					Set(jSONClass);
					num = ((int)num2 * -813385893) ^ -801983588;
					continue;
				case 4u:
					num = (int)((num2 * 813976703) ^ 0x2DADA086);
					continue;
				case 3u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1899598453) ^ 0x7D3E4F87);
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -615322924) ^ 0x740477A5;
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
		bool result = default(bool);
		while (true)
		{
			int num = 1297917271;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BDAD851u) % 5u)
				{
				case 3u:
					result = true;
					num = (int)(num2 * 282856044) ^ -1713895310;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (b != null)
					{
						num3 = 568869196;
						num4 = 568869196;
					}
					else
					{
						num3 = 216375283;
						num4 = 216375283;
					}
					num = num3 ^ (int)(num2 * 31204477);
					continue;
				}
				case 1u:
					result = (object)a == b;
					num = 1492664418;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = 1004544720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58C68D6Bu) % 6u)
				{
				case 5u:
					result = true;
					num = ((int)num2 * -1721513406) ^ -504438707;
					continue;
				case 2u:
					result = (object)this == obj;
					num = 1745889329;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -769467079;
						num4 = -769467079;
					}
					else
					{
						num3 = -696625374;
						num4 = -696625374;
					}
					num = num3 ^ ((int)num2 * -1596059581);
					continue;
				}
				case 0u:
					num = ((int)num2 * -805711258) ^ 0x14AEAEF1;
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = -2039271590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3C8B9DAu) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0009:
				num = (int)(num2 * 1186597706) ^ -26920751;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -510462545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4201CF6u) % 3u)
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
				num = (int)((num2 * 2025247371) ^ 0x52730485);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		return "";
	}
}
