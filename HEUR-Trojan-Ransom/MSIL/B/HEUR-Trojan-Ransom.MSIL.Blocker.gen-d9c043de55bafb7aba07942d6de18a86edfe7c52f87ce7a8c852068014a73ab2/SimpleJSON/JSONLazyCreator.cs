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
				int num = -2053421677;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x914BF1B8u) % 5u)
					{
					case 4u:
						jSONArray.Add(value);
						num = ((int)num2 * -1510065645) ^ 0x622F1F31;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 1350140474) ^ -645916400;
						continue;
					case 0u:
						Set(jSONArray);
						num = ((int)num2 * -1725836116) ^ -98987922;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1134983236;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A108A96u) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1771524742) ^ 0x536C5433;
						continue;
					case 1u:
						num = ((int)num2 * -1299843585) ^ -299065598;
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
				int num = -1811081137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB09C734Cu) % 6u)
					{
					case 4u:
						num = (int)((num2 * 913789008) ^ 0x5B518CF);
						continue;
					case 3u:
						jSONClass = new JSONClass();
						num = (int)(num2 * 79245612) ^ -1725858964;
						continue;
					case 2u:
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 1828455652) ^ 0x3CDF31D8);
						continue;
					case 1u:
						Set(jSONClass);
						num = (int)(num2 * 770475781) ^ -944684735;
						continue;
					default:
						return;
					case 5u:
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
			int result = default(int);
			while (true)
			{
				int num = 1253849215;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1554B4BFu) % 6u)
					{
					case 4u:
						result = 0;
						num = (int)((num2 * 2004299058) ^ 0x73B333AB);
						continue;
					case 2u:
						Set(aVal);
						num = ((int)num2 * -1001351575) ^ -715628180;
						continue;
					case 1u:
						num = ((int)num2 * -212722556) ^ -1629184119;
						continue;
					case 0u:
						num = (int)(num2 * 2000058718) ^ -1241441868;
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
			JSONData aVal = new JSONData(value);
			Set(aVal);
		}
	}

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = -1142809550;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE74C911u) % 5u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = ((int)num2 * -1017382394) ^ 0x11600304;
						continue;
					}
					case 2u:
						num = ((int)num2 * -1142876487) ^ 0x2F789D34;
						continue;
					case 1u:
						result = 0f;
						num = (int)((num2 * 183772424) ^ 0x2CE511F);
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
				int num = -1590668563;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C42F430u) % 4u)
					{
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)(num2 * 1474481993) ^ -1522757579;
						continue;
					}
					case 0u:
						num = (int)((num2 * 1276006020) ^ 0x7583B95B);
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
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = -1403213777;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2FB421Du) % 6u)
					{
					case 5u:
						result = 0.0;
						num = ((int)num2 * -2070019875) ^ 0x12907B75;
						continue;
					case 4u:
						Set(aVal);
						num = (int)(num2 * 187641039) ^ -1609434107;
						continue;
					case 2u:
						num = ((int)num2 * -1446316383) ^ 0x3C495922;
						continue;
					case 1u:
						num = (int)(num2 * 1518053284) ^ -505294499;
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
				int num = -2086025592;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9781BDBu) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = ((int)num2 * -1780987673) ^ -889436887;
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
				int num = -1020946156;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1A23AE5u) % 6u)
					{
					case 4u:
						result = false;
						num = ((int)num2 * -217135752) ^ 0x2B9618E9;
						continue;
					case 2u:
						num = (int)((num2 * 1069152245) ^ 0x580BB438);
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -1098071881) ^ 0x35231658;
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 1096836294) ^ -1704330795;
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
				int num = -222580728;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB8588883u) % 5u)
					{
					case 3u:
						num = ((int)num2 * -405346926) ^ -824941471;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1474128067) ^ 0x6A529E2C;
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 395132655) ^ 0x181F2B1);
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
	}

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			Set(jSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1354942348;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0BDBC59u) % 5u)
					{
					case 2u:
						num = ((int)num2 * -428163178) ^ 0x4C5BECBA;
						continue;
					case 1u:
						num = ((int)num2 * -532263001) ^ 0x2150B50A;
						continue;
					case 0u:
						result = jSONArray;
						num = ((int)num2 * -228307473) ^ -1959893278;
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
				int num = 1676657824;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x67EFD459u) % 5u)
					{
					case 4u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -880529518) ^ 0x54D3C31F;
						continue;
					case 2u:
						Set(jSONClass);
						result = jSONClass;
						num = ((int)num2 * -1951866624) ^ 0x78458FFF;
						continue;
					case 1u:
						num = (int)((num2 * 1550564339) ^ 0x679B0815);
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
		while (true)
		{
			int num = 1609601913;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42026117u) % 10u)
				{
				case 9u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1011338572) ^ -1101565602;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = -1489354469;
						num4 = -1489354469;
					}
					else
					{
						num3 = -1949536284;
						num4 = -1949536284;
					}
					num = num3 ^ ((int)num2 * -1558827716);
					continue;
				}
				case 5u:
					num = ((int)num2 * -167023657) ^ 0x1B8DE60B;
					continue;
				case 4u:
					num = (int)(num2 * 711232549) ^ -421023826;
					continue;
				case 3u:
					m_Node = null;
					num = 986866496;
					continue;
				case 2u:
					num = ((int)num2 * -1360209356) ^ -317977984;
					continue;
				case 1u:
					num = (int)((num2 * 51647615) ^ 0x28EA230);
					continue;
				case 0u:
					m_Node.Add(m_Key, aVal);
					num = 2012292521;
					continue;
				default:
					return;
				case 6u:
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
		JSONArray jSONArray = new JSONArray();
		jSONArray.Add(aItem);
		while (true)
		{
			int num = 316450417;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3452F943u) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 2u:
					break;
				default:
					Set(jSONArray);
					return;
				}
				break;
				IL_000f:
				num = (int)(num2 * 918506025) ^ -618348096;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1755340620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE3CFC6Du) % 4u)
				{
				case 1u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -990137422) ^ -1017840881;
					continue;
				case 0u:
					Set(jSONClass);
					num = (int)(num2 * 958979062) ^ -297554665;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1230848445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5B4DFF7u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -312114203) ^ 0x5CECC7ED;
					continue;
				case 4u:
					result = (object)a == b;
					num = -701912740;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -546391314) ^ 0x6400F23C;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (b == null)
					{
						num3 = -1433558442;
						num4 = -1433558442;
					}
					else
					{
						num3 = -394811021;
						num4 = -394811021;
					}
					num = num3 ^ ((int)num2 * -214097475);
					continue;
				}
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
		bool result = default(bool);
		while (true)
		{
			int num = 479957686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54A9DDB4u) % 3u)
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
				result = !(a == b);
				num = (int)(num2 * 896854313) ^ -2016533086;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -2050335725;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF82E2375u) % 7u)
				{
				case 5u:
					result = (object)this == obj;
					num = -1077796407;
					continue;
				case 4u:
					num = ((int)num2 * -241001766) ^ 0x2C460EC8;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -738231239) ^ -1789822185;
					continue;
				case 2u:
					num = ((int)num2 * -2088082730) ^ -1156275538;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1072523428;
						num4 = 1072523428;
					}
					else
					{
						num3 = 815926083;
						num4 = 815926083;
					}
					num = num3 ^ ((int)num2 * -806491375);
					continue;
				}
				case 6u:
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
		string result = "";
		while (true)
		{
			int num = 1024883271;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C9E22u) % 3u)
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
				num = ((int)num2 * -1632868645) ^ 0x10A8DBD;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1357588172;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC181BCC9u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1959620881) ^ 0xCB34448;
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -978617407) ^ 0x7A1F0D3;
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
