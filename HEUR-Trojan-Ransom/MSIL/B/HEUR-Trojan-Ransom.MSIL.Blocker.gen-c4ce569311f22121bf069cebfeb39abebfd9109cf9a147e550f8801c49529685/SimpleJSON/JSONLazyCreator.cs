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
				int num = -823967885;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC4050C8u) % 3u)
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
					num = ((int)num2 * -588810829) ^ -1123062106;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 22925566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55682678u) % 6u)
					{
					case 4u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1345296840) ^ -941878301;
						continue;
					case 3u:
						jSONArray.Add(value);
						num = ((int)num2 * -298567366) ^ 0x278B95A6;
						continue;
					case 1u:
						num = ((int)num2 * -492501043) ^ -860398690;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)(num2 * 502575778) ^ -1867917321;
						continue;
					default:
						return;
					case 2u:
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
				int num = 277849157;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C19EB0Eu) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1959985031) ^ 0x107F6B73;
						continue;
					case 2u:
						num = (int)(num2 * 1117348427) ^ -1065449847;
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
				int num = 242893879;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64039D33u) % 5u)
					{
					case 4u:
						jSONClass.Add(aKey, value);
						Set(jSONClass);
						num = ((int)num2 * -2104139695) ^ -408364103;
						continue;
					case 3u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -1729343713) ^ -457488698;
						continue;
					case 2u:
						num = (int)((num2 * 2016921427) ^ 0x56EDD0DC);
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			Set(aVal);
			int result = default(int);
			while (true)
			{
				int num = -1736686750;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x980A029Du) % 5u)
					{
					case 4u:
						result = 0;
						num = (int)((num2 * 654801298) ^ 0x523791B5);
						continue;
					case 3u:
						num = (int)((num2 * 16976056) ^ 0x28CC5AE2);
						continue;
					case 2u:
						num = ((int)num2 * -394327559) ^ 0x19F9F401;
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
				int num = 905867235;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x467F7FE8u) % 3u)
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
					num = (int)(num2 * 1503720845) ^ -2081222312;
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
				int num = 1528750165;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5DD35702u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -2108461830) ^ 0x56141B58;
						continue;
					case 0u:
						result = 0f;
						num = ((int)num2 * -1638426245) ^ -1979381457;
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
				int num = -554448862;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB71EDF97u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 111741105) ^ 0x289D54CA);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)(num2 * 768795524) ^ -136631368;
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
				int num = 832274643;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3A448C7Au) % 4u)
					{
					case 1u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1079653170) ^ -2011261140;
						continue;
					case 0u:
						Set(aVal);
						result = 0.0;
						num = (int)(num2 * 1214454371) ^ -1922545516;
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
			while (true)
			{
				int num = 1681222748;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68273B41u) % 3u)
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
					num = ((int)num2 * -1430767674) ^ 0x895BFB9;
				}
			}
		}
	}

	public override bool AsBool
	{
		get
		{
			JSONData aVal = new JSONData(aData: false);
			Set(aVal);
			bool result = default(bool);
			while (true)
			{
				int num = -1060178382;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF51DDEEBu) % 5u)
					{
					case 3u:
						num = ((int)num2 * -666311208) ^ -1363481503;
						continue;
					case 2u:
						result = false;
						num = ((int)num2 * -1116928193) ^ 0x4DE8217D;
						continue;
					case 1u:
						num = (int)((num2 * 1716432666) ^ 0x3D3F6A7A);
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
				int num = 339036395;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F1D276Cu) % 5u)
					{
					case 4u:
						num = ((int)num2 * -694592178) ^ -607989465;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 713266819) ^ 0x1E88C7);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -383818291) ^ -1836508845;
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
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1875052763;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA9D6822u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -247894982) ^ 0x4E1F93AE;
						continue;
					case 4u:
						num = ((int)num2 * -1752923330) ^ -769623201;
						continue;
					case 3u:
						Set(jSONArray);
						num = ((int)num2 * -44355698) ^ 0x349D0FEA;
						continue;
					case 1u:
						result = jSONArray;
						num = ((int)num2 * -1651477935) ^ 0x20964040;
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
			JSONClass jSONClass = new JSONClass();
			Set(jSONClass);
			JSONClass result = jSONClass;
			while (true)
			{
				int num = -552778587;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEADB43E7u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					num = (int)((num2 * 1882687585) ^ 0x7B99708C);
				}
			}
		}
	}

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = -608002944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE19A2ECAu) % 5u)
				{
				case 4u:
					m_Node = aNode;
					m_Key = null;
					num = ((int)num2 * -1579598057) ^ 0x1B3992EB;
					continue;
				case 3u:
					num = ((int)num2 * -879601681) ^ 0x83D1C8B;
					continue;
				case 1u:
					num = (int)((num2 * 2063046148) ^ 0xF3DF401);
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
		m_Node = aNode;
		m_Key = aKey;
	}

	private void Set(JSONNode aVal)
	{
		bool flag = m_Key == null;
		while (true)
		{
			int num = 2072110789;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DE2C43Bu) % 10u)
				{
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -964273011;
						num4 = -964273011;
					}
					else
					{
						num3 = -1287881733;
						num4 = -1287881733;
					}
					num = num3 ^ ((int)num2 * -2064876249);
					continue;
				}
				case 6u:
					num = ((int)num2 * -790250125) ^ -555095483;
					continue;
				case 5u:
					num = ((int)num2 * -1935076932) ^ 0x368A9F24;
					continue;
				case 4u:
					num = ((int)num2 * -1097309601) ^ -882025782;
					continue;
				case 3u:
					m_Node = null;
					num = 89535788;
					continue;
				case 2u:
					m_Node.Add(m_Key, aVal);
					num = 328863328;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = (int)((num2 * 1851474162) ^ 0x8AF1655);
					continue;
				case 0u:
					num = ((int)num2 * -9476172) ^ 0x62EDA1D0;
					continue;
				default:
					return;
				case 7u:
					break;
				case 9u:
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
			int num = 516611800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x245A1BBFu) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000f:
				Set(jSONArray);
				num = ((int)num2 * -729471677) ^ 0x2A12321B;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 683465276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x781DC577u) % 6u)
				{
				case 5u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 72281603) ^ 0x58F48486);
					continue;
				case 3u:
					num = (int)(num2 * 1334062227) ^ -1327958019;
					continue;
				case 1u:
					Set(jSONClass);
					num = ((int)num2 * -820071622) ^ 0xADD1197;
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1913838182) ^ 0x59D87132;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
			int num = 285425969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46B69D42u) % 8u)
				{
				case 7u:
					result = true;
					num = ((int)num2 * -1790404138) ^ 0x4993CEF5;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1523170675;
						num4 = 1523170675;
					}
					else
					{
						num3 = 1244011992;
						num4 = 1244011992;
					}
					num = num3 ^ ((int)num2 * -1463683267);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1406272556) ^ 0x6E05D7E7;
					continue;
				case 4u:
					result = (object)a == b;
					num = 2064428136;
					continue;
				case 3u:
					flag = b == null;
					num = (int)(num2 * 856094972) ^ -703378560;
					continue;
				case 2u:
					num = (int)(num2 * 214599792) ^ -2082953981;
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
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -1201836488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC936667Du) % 6u)
				{
				case 4u:
					result = true;
					num = (int)(num2 * 1007871987) ^ -874703631;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -840547779;
						num4 = -840547779;
					}
					else
					{
						num3 = -1152138502;
						num4 = -1152138502;
					}
					num = num3 ^ (int)(num2 * 1204020363);
					continue;
				}
				case 2u:
					num = (int)(num2 * 544344516) ^ -1051622796;
					continue;
				case 1u:
					result = (object)this == obj;
					num = -1788788732;
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
		int hashCode = default(int);
		while (true)
		{
			int num = 451812515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F62CE92u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1841172951) ^ 0x1752A747;
					continue;
				case 1u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -1199640973) ^ -557307629;
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
			int num = 1874605777;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FE568AEu) % 3u)
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
				num = (int)((num2 * 2139620942) ^ 0x2384CBC4);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = -613137241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC067B343u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = (int)(num2 * 663728596) ^ -347978921;
			}
		}
	}
}
