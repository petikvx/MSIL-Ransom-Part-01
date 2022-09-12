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
				int num = -26502212;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5CEF9A5u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1508480524) ^ -1364381381;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1630509388) ^ -799575458;
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
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 256436054;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x823D044u) % 6u)
					{
					case 4u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -532944063) ^ -1946901500;
						continue;
					case 3u:
						Set(jSONArray);
						num = ((int)num2 * -631670367) ^ 0x7E6475EC;
						continue;
					case 2u:
						jSONArray.Add(value);
						num = (int)((num2 * 1898478161) ^ 0x7885C0D5);
						continue;
					case 1u:
						num = (int)(num2 * 652211316) ^ -898557471;
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
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = -416623845;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98926FCDu) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					num = ((int)num2 * -1539964971) ^ -634481112;
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			while (true)
			{
				int num = -831960444;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAAF210B9u) % 4u)
					{
					case 1u:
						num = (int)(num2 * 928049839) ^ -274343182;
						continue;
					case 0u:
						Set(jSONClass);
						num = (int)(num2 * 726146473) ^ -1192762093;
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			int result = default(int);
			while (true)
			{
				int num = 569986312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x411C2EE2u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -961471451) ^ -852189436;
						continue;
					case 2u:
						Set(aVal);
						result = 0;
						num = (int)((num2 * 343523150) ^ 0x4BA30D);
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
				int num = 35880903;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A22A6EAu) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1763299715) ^ -1872159858;
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -182093518) ^ 0x43F53522;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1232433043) ^ -1898667203;
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
				int num = 1583470720;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B1AF0F5u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = (int)((num2 * 23211011) ^ 0x41CE507B);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)((num2 * 401301387) ^ 0x3705D60);
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = -1409061859;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8EA8C786u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -544296625) ^ 0x640F7C69;
						continue;
					case 2u:
						result = 0.0;
						num = ((int)num2 * -361926583) ^ 0x7ACBEBF1;
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
				int num = -1945102036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE4D4423u) % 3u)
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
					num = ((int)num2 * -1252505462) ^ -692319030;
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
				int num = 294635277;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E45FA3Eu) % 6u)
					{
					case 5u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -475685525) ^ 0x55B46828;
						continue;
					case 3u:
						Set(aVal);
						num = (int)((num2 * 384823474) ^ 0xEC16B61);
						continue;
					case 2u:
						num = ((int)num2 * -1466925658) ^ 0x11075806;
						continue;
					case 1u:
						result = false;
						num = (int)(num2 * 1093792045) ^ -1763392291;
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1909111667;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FBA46ABu) % 3u)
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
					num = ((int)num2 * -1497590354) ^ 0x3A4BB5F4;
				}
			}
		}
	}

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = new JSONClass();
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -1949339245;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F2A9960u) % 5u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -194360242) ^ 0x66DC81E8;
						continue;
					case 2u:
						num = (int)(num2 * 819338342) ^ -269999280;
						continue;
					case 1u:
						result = jSONClass;
						num = ((int)num2 * -1945128396) ^ 0x15E5DE1C;
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

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = -1770390246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC7EA9C6u) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 2u:
					break;
				default:
					m_Key = null;
					return;
				}
				break;
				IL_0016:
				m_Node = aNode;
				num = ((int)num2 * -1461309427) ^ -987061493;
			}
		}
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 961560890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53B66AFCu) % 4u)
				{
				case 3u:
					m_Node = aNode;
					m_Key = aKey;
					num = ((int)num2 * -870550168) ^ -1062551827;
					continue;
				case 2u:
					num = (int)(num2 * 1329841849) ^ -407721651;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 104063379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x772939C6u) % 12u)
				{
				case 10u:
					num = ((int)num2 * -934735345) ^ 0x1CB92785;
					continue;
				case 9u:
					num = (int)(num2 * 1765491364) ^ -1182963142;
					continue;
				case 8u:
					m_Node.Add(aVal);
					num = ((int)num2 * -100360771) ^ -2027983160;
					continue;
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = 825199200;
					continue;
				case 6u:
					num = ((int)num2 * -1891872663) ^ 0x48D2C588;
					continue;
				case 5u:
					flag = m_Key == null;
					num = ((int)num2 * -1301587751) ^ -171632086;
					continue;
				case 4u:
					m_Node = null;
					num = 2087280341;
					continue;
				case 3u:
					num = ((int)num2 * -583555345) ^ -418697161;
					continue;
				case 2u:
					num = (int)(num2 * 1381574516) ^ -2117980535;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1140986498;
						num4 = -1140986498;
					}
					else
					{
						num3 = -62068429;
						num4 = -62068429;
					}
					num = num3 ^ (int)(num2 * 1876872431);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 11u:
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
			int num = -382438368;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCED77649u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				JSONArray jSONArray = new JSONArray();
				jSONArray.Add(aItem);
				Set(jSONArray);
				num = ((int)num2 * -1013223728) ^ -902292131;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = -1382379882;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD67E737Bu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -2062544495) ^ 0x1C5E39C1;
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1686915330) ^ -2073473439;
					continue;
				case 0u:
					Set(jSONClass);
					num = (int)(num2 * 1511265167) ^ -2072793637;
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
		if (b == null)
		{
			goto IL_0006;
		}
		goto IL_0050;
		IL_0050:
		bool result = (object)a == b;
		int num = 719629759;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x34A7D515u) % 5u)
			{
			case 4u:
				break;
			case 2u:
				num = ((int)num2 * -1817130340) ^ 0x2A79E8B5;
				continue;
			case 1u:
				result = true;
				num = (int)(num2 * 1523240562) ^ -909704835;
				continue;
			case 0u:
				goto IL_0050;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = 1805621117;
		goto IL_002b;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 897764828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C01DDB3u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = (int)(num2 * 1996172699) ^ -1646571325;
					continue;
				case 1u:
					num = ((int)num2 * -25298976) ^ 0x79D4C4B9;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 178345044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D3C4C9Au) % 7u)
				{
				case 6u:
					num = (int)((num2 * 920229694) ^ 0x1C86800F);
					continue;
				case 5u:
					flag = obj == null;
					num = (int)(num2 * 514185115) ^ -1006316559;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -115162169;
						num4 = -115162169;
					}
					else
					{
						num3 = -1989771367;
						num4 = -1989771367;
					}
					num = num3 ^ ((int)num2 * -21582735);
					continue;
				}
				case 2u:
					result = (object)this == obj;
					num = 2129983161;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 353378868) ^ 0x31BBC337);
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
		int hashCode = default(int);
		while (true)
		{
			int num = -1070853700;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBAF9922u) % 4u)
				{
				case 2u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -1400377407) ^ -29487747;
					continue;
				case 1u:
					num = (int)(num2 * 1513261873) ^ -1940757581;
					continue;
				case 3u:
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
			int num = 1451858614;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B8158BCu) % 4u)
				{
				case 2u:
					result = "";
					num = (int)((num2 * 1602402506) ^ 0x1EF5CC79);
					continue;
				case 1u:
					num = (int)((num2 * 199769898) ^ 0x55DA79C9);
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
			int num = -1311953266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB8F00B5u) % 3u)
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
				result = "";
				num = ((int)num2 * -1424119660) ^ -1607592589;
			}
		}
	}
}
