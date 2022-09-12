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
				int num = 1468475501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41A0DD00u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 1499835386) ^ 0x62723DA4);
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = 2141722114;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C27AEEFu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -850433839) ^ -789652560;
						continue;
					case 1u:
						jSONArray.Add(value);
						Set(jSONArray);
						num = ((int)num2 * -1720963360) ^ -132763444;
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
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -888645567;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE357254Fu) % 3u)
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
					num = ((int)num2 * -1296526890) ^ -269198006;
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = -1359460138;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98DADEE3u) % 6u)
					{
					case 4u:
						Set(jSONClass);
						num = (int)((num2 * 1776770650) ^ 0x5F0C5B13);
						continue;
					case 3u:
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 1603438190) ^ 0x2C237C94);
						continue;
					case 2u:
						num = ((int)num2 * -466947083) ^ -874488207;
						continue;
					case 1u:
						num = ((int)num2 * -1178713857) ^ -1837511770;
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
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = 459401598;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x731241E5u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 649074324) ^ 0x4509A145);
						continue;
					case 2u:
						aVal = new JSONData(0);
						num = (int)(num2 * 647163100) ^ -1686210078;
						continue;
					case 1u:
						result = 0;
						num = (int)(num2 * 1760778250) ^ -1088310680;
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
				int num = 1277076115;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D12DC89u) % 4u)
					{
					case 2u:
						aVal = new JSONData(value);
						num = (int)((num2 * 465963481) ^ 0x534D6122);
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -547167573) ^ -1442775691;
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

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = 380454192;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x545F961Fu) % 5u)
					{
					case 3u:
						num = (int)(num2 * 1231060264) ^ -985769263;
						continue;
					case 2u:
						result = 0f;
						num = (int)((num2 * 20367045) ^ 0x63ECE6C6);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = ((int)num2 * -1205052039) ^ -1277422958;
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
				int num = -16937327;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5D78E49u) % 5u)
					{
					case 4u:
						result = 0.0;
						num = (int)((num2 * 708876305) ^ 0xADAD5CB);
						continue;
					case 3u:
						Set(aVal);
						num = (int)(num2 * 1677402437) ^ -296591485;
						continue;
					case 1u:
						num = ((int)num2 * -1550977839) ^ -1918995673;
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
				int num = -823129771;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x91B54163u) % 4u)
					{
					case 2u:
						aVal = new JSONData(value);
						num = ((int)num2 * -361451251) ^ 0x568E3F10;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1622679851) ^ -1591694078;
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

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1811723721;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB29AFA6Cu) % 5u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -221018509) ^ -444956417;
						continue;
					}
					case 1u:
						num = (int)(num2 * 534941673) ^ -808006445;
						continue;
					case 0u:
						result = false;
						num = ((int)num2 * -911181293) ^ -670292384;
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
				int num = -305962243;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB352720u) % 3u)
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
					num = ((int)num2 * -1380769135) ^ -1461839639;
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
				int num = 781804252;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73742DD0u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -222430927) ^ 0x4AE5100F;
						continue;
					case 4u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = (int)(num2 * 1729031912) ^ -404820399;
						continue;
					case 3u:
						num = ((int)num2 * -1763269267) ^ 0x2367F652;
						continue;
					case 2u:
						result = jSONArray;
						num = (int)((num2 * 979306793) ^ 0x23703D1);
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
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -640556333;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E37B0CEu) % 4u)
					{
					case 3u:
						result = jSONClass;
						num = (int)((num2 * 1468842113) ^ 0x779F505B);
						continue;
					case 1u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)(num2 * 299332355) ^ -1175331902;
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
		while (true)
		{
			int num = 285944966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1481C789u) % 6u)
				{
				case 5u:
					m_Node = aNode;
					num = (int)((num2 * 126047954) ^ 0x10A6A641);
					continue;
				case 4u:
					num = (int)(num2 * 947999317) ^ -2052546224;
					continue;
				case 3u:
					num = ((int)num2 * -940856363) ^ -1540594950;
					continue;
				case 2u:
					m_Key = aKey;
					num = (int)(num2 * 898546808) ^ -444451436;
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

	private void Set(JSONNode aVal)
	{
		if (m_Key == null)
		{
			goto IL_0088;
		}
		goto IL_00c3;
		IL_00c3:
		int num = 489701725;
		goto IL_008d;
		IL_008d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x16C33802u) % 9u)
			{
			case 7u:
				m_Node.Add(aVal);
				num = ((int)num2 * -793060816) ^ 0x31A2F10D;
				continue;
			case 6u:
				num = (int)(num2 * 2082116797) ^ -1431496600;
				continue;
			case 5u:
				m_Node.Add(m_Key, aVal);
				num = (int)((num2 * 1729046009) ^ 0x5B1F77A1);
				continue;
			case 4u:
				num = ((int)num2 * -1993733977) ^ -91556576;
				continue;
			case 3u:
				num = (int)((num2 * 963675309) ^ 0x43AA44B2);
				continue;
			case 1u:
				num = ((int)num2 * -1239599617) ^ 0x214E9CA5;
				continue;
			case 0u:
				break;
			case 8u:
				goto IL_00c3;
			default:
				m_Node = null;
				return;
			}
			break;
		}
		goto IL_0088;
		IL_0088:
		num = 1200981294;
		goto IL_008d;
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = -80725134;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB2B39EFu) % 6u)
				{
				case 5u:
					Set(jSONArray);
					num = ((int)num2 * -911388501) ^ 0x1B15B362;
					continue;
				case 4u:
					num = (int)(num2 * 759463241) ^ -649722934;
					continue;
				case 2u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -716053576) ^ -1296067451;
					continue;
				case 1u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -393664191) ^ -1515778328;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 1885370728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36D2E3F3u) % 6u)
				{
				case 5u:
					jSONClass = new JSONClass();
					num = (int)(num2 * 1425106744) ^ -940029758;
					continue;
				case 4u:
					Set(jSONClass);
					num = (int)((num2 * 826317514) ^ 0x42098D77);
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -680588998) ^ 0x2CF50B83;
					continue;
				case 0u:
					num = (int)(num2 * 626967109) ^ -777658285;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1947869931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC100BE12u) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -617894992;
						num4 = -617894992;
					}
					else
					{
						num3 = -1968009463;
						num4 = -1968009463;
					}
					num = num3 ^ (int)(num2 * 866827244);
					continue;
				}
				case 4u:
					flag = b == null;
					num = ((int)num2 * -502390853) ^ -164243979;
					continue;
				case 2u:
					result = true;
					num = (int)(num2 * 990888939) ^ -1040314450;
					continue;
				case 1u:
					result = (object)a == b;
					num = -545419408;
					continue;
				case 0u:
					num = ((int)num2 * -767207347) ^ 0x31A5DF35;
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
			int num = -1582358957;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDDD6BFD4u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = ((int)num2 * -565356553) ^ -1237487389;
					continue;
				case 2u:
					num = ((int)num2 * -36532053) ^ -1177063429;
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
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -26225407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE4698A7u) % 6u)
				{
				case 5u:
					result = (object)this == obj;
					num = -1486699502;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1778728682;
						num4 = -1778728682;
					}
					else
					{
						num3 = -1197246530;
						num4 = -1197246530;
					}
					num = num3 ^ ((int)num2 * -1137000707);
					continue;
				}
				case 2u:
					flag = obj == null;
					num = (int)((num2 * 1399230937) ^ 0x6A375DBD);
					continue;
				case 1u:
					result = true;
					num = (int)(num2 * 65575015) ^ -1147845583;
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
			int num = -178266191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0EF3AC7u) % 3u)
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
				num = ((int)num2 * -1409172675) ^ 0x37142134;
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = 189891852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CD712B6u) % 3u)
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
				num = (int)((num2 * 12356159) ^ 0x5344A27);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1404758630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90A08FEDu) % 3u)
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
				num = (int)((num2 * 2059842068) ^ 0x5A587155);
			}
		}
	}
}
