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
				int num = -1315998482;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCDF91185u) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 700977628) ^ -824730079;
						continue;
					case 0u:
						num = (int)((num2 * 1969763457) ^ 0x24FA9ED4);
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
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -6241054;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA490940u) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = (int)(num2 * 1997886613) ^ -1925360589;
						continue;
					case 3u:
						jSONArray.Add(value);
						num = ((int)num2 * -1826968379) ^ 0x729C1AA3;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -957256106) ^ -1638077868;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1923040797;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A423AC7u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1628715762) ^ 0x508E3CF8);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = (int)(num2 * 578824700) ^ -1026330844;
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
			Set(jSONClass);
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
				int num = -1919386551;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8099A73Bu) % 6u)
					{
					case 5u:
						num = (int)(num2 * 467246841) ^ -1815290525;
						continue;
					case 4u:
						num = (int)(num2 * 598144108) ^ -2119726539;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1783814940) ^ 0x615D54E7);
						continue;
					case 0u:
						result = 0;
						num = ((int)num2 * -1992743057) ^ 0x26723D8A;
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
			JSONData aVal = new JSONData(0f);
			Set(aVal);
			float result = default(float);
			while (true)
			{
				int num = -1259642292;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5695139u) % 3u)
					{
					case 1u:
						goto IL_0014;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0014:
					result = 0f;
					num = (int)(num2 * 275996716) ^ -376342797;
				}
			}
		}
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -426047235;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB1909B7u) % 5u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = ((int)num2 * -131719560) ^ 0x6AD5B143;
						continue;
					case 1u:
						num = (int)(num2 * 2055409046) ^ -1038007837;
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 618301070) ^ -870786216;
						continue;
					default:
						return;
					case 4u:
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
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = -1338093739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97C7A262u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1079698937) ^ 0x66223183;
						continue;
					case 3u:
						result = 0.0;
						num = ((int)num2 * -1953829937) ^ -2126131972;
						continue;
					case 2u:
						num = (int)((num2 * 1399784028) ^ 0x13086F9F);
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 644285706) ^ -544287996;
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
				int num = -1256805643;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFF56B94Bu) % 5u)
					{
					case 3u:
						num = ((int)num2 * -534775337) ^ 0x7D7F13B2;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = (int)((num2 * 1771721162) ^ 0xA5BB777);
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -693570234) ^ -1818696995;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 542308130;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50780429u) % 5u)
					{
					case 3u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -1095379062) ^ -1366586967;
						continue;
					case 2u:
						result = false;
						num = ((int)num2 * -1401548454) ^ 0x457AF547;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1722125513) ^ -1374915838;
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
				int num = 544536616;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48371333u) % 4u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = (int)((num2 * 1276281320) ^ 0x4D54BC75);
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1065152341) ^ 0x3319B24C);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -984581063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA59E5814u) % 5u)
					{
					case 4u:
						num = (int)(num2 * 231657890) ^ -524326745;
						continue;
					case 3u:
						Set(jSONArray);
						num = (int)(num2 * 1522270671) ^ -305457839;
						continue;
					case 1u:
						result = jSONArray;
						num = ((int)num2 * -329976049) ^ 0x3CBF87B;
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
				int num = -1038987594;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB224F9Fu) % 6u)
					{
					case 4u:
						result = jSONClass;
						num = (int)(num2 * 584529553) ^ -1492234215;
						continue;
					case 3u:
						num = ((int)num2 * -297027486) ^ 0x71FDEA41;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = ((int)num2 * -47911467) ^ 0x93EC42D;
						continue;
					case 0u:
						num = (int)((num2 * 1870966970) ^ 0x1DF345E7);
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

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = 1316356633;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36D8FBCAu) % 6u)
				{
				case 5u:
					num = (int)(num2 * 963819162) ^ -804944090;
					continue;
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -871175448) ^ -464773804;
					continue;
				case 1u:
					num = ((int)num2 * -1499921461) ^ -201795856;
					continue;
				case 0u:
					m_Key = null;
					num = ((int)num2 * -702733327) ^ -1460529660;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -1333476027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF8F0E5Du) % 3u)
				{
				case 1u:
					goto IL_0016;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0016:
				m_Node = aNode;
				m_Key = aKey;
				num = (int)((num2 * 1122535380) ^ 0x24E1545D);
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1916767448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA26AC5C8u) % 11u)
				{
				case 10u:
					num = (int)((num2 * 44054888) ^ 0x566A0330);
					continue;
				case 8u:
					m_Node = null;
					num = -1816415835;
					continue;
				case 7u:
					num = (int)((num2 * 1105908159) ^ 0x57BABA2E);
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = -1986333921;
					continue;
				case 5u:
					flag = m_Key == null;
					num = (int)((num2 * 1560015579) ^ 0x22307137);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1378198692;
						num4 = 1378198692;
					}
					else
					{
						num3 = 2069395509;
						num4 = 2069395509;
					}
					num = num3 ^ ((int)num2 * -281690838);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1194804605) ^ -807111731;
					continue;
				case 1u:
					num = (int)((num2 * 1641014604) ^ 0x5B386430);
					continue;
				case 0u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1370114644) ^ -1006454500;
					continue;
				default:
					return;
				case 4u:
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
		while (true)
		{
			int num = 367349461;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EF1BF69u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					Set(jSONArray);
					return;
				}
				break;
				IL_0008:
				jSONArray.Add(aItem);
				num = ((int)num2 * -2093365150) ^ 0x7599965C;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		jSONClass.Add(aKey, aItem);
		while (true)
		{
			int num = -1630232196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB2D101Bu) % 4u)
				{
				case 3u:
					Set(jSONClass);
					num = ((int)num2 * -2132901454) ^ 0x2E4D2B03;
					continue;
				case 2u:
					num = (int)(num2 * 457999287) ^ -671940084;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -925846884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94C86285u) % 8u)
				{
				case 7u:
					result = true;
					num = (int)(num2 * 751764409) ^ -1296678040;
					continue;
				case 6u:
					num = ((int)num2 * -1395968673) ^ 0x25F19754;
					continue;
				case 5u:
					result = (object)a == b;
					num = -287699165;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -457802616;
						num4 = -457802616;
					}
					else
					{
						num3 = -204166414;
						num4 = -204166414;
					}
					num = num3 ^ ((int)num2 * -1876359984);
					continue;
				}
				case 2u:
					num = (int)((num2 * 2011638325) ^ 0x7737B434);
					continue;
				case 1u:
					flag = b == null;
					num = ((int)num2 * -340358701) ^ -97675766;
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
		bool result = default(bool);
		while (true)
		{
			int num = -399771740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFC7E159u) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -921748042) ^ 0x5A2609E7;
					continue;
				case 0u:
					num = (int)(num2 * 401543052) ^ -1259338970;
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

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0017;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)this == obj;
		int num = -1088399997;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xAD08184Bu) % 5u)
			{
			case 4u:
				num = ((int)num2 * -1637604256) ^ 0x37A7BE23;
				continue;
			case 3u:
				break;
			case 1u:
				result = true;
				num = ((int)num2 * -1531627042) ^ 0xB489DB6;
				continue;
			case 2u:
				goto IL_0052;
			default:
				return result;
			}
			break;
		}
		goto IL_0017;
		IL_0017:
		num = -1122157180;
		goto IL_002d;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = -830473315;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2425970u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0003:
				hashCode = base.GetHashCode();
				num = (int)(num2 * 2008430359) ^ -1083210575;
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = -121076519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC34D5922u) % 3u)
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
				num = (int)((num2 * 751477418) ^ 0x4D563B8B);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = -450508199;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD60436AEu) % 3u)
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
				num = (int)(num2 * 259246783) ^ -1738363525;
			}
		}
	}
}
