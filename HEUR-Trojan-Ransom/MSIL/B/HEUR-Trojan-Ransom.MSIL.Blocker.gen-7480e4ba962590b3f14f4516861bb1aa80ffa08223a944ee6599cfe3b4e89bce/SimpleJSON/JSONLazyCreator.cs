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
				int num = -1272283637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFDDF2BDu) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1242550501) ^ -1313978934;
						continue;
					case 1u:
						num = ((int)num2 * -1994145697) ^ 0x4285CAC2;
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
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = -1956446607;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8869CB3Au) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2013183476) ^ -1873943598;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)((num2 * 969293988) ^ 0x8FDA927);
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 81756720;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BE2542Eu) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1349108349) ^ -1371878883;
						continue;
					case 1u:
						num = ((int)num2 * -1776943749) ^ 0x2496C851;
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
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			Set(jSONClass);
		}
	}

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = -400261657;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB134520u) % 6u)
					{
					case 4u:
						num = (int)((num2 * 932698098) ^ 0x7AA9656A);
						continue;
					case 3u:
						num = (int)(num2 * 1955734857) ^ -126962309;
						continue;
					case 2u:
						result = 0;
						num = (int)((num2 * 455125684) ^ 0x14A568B2);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = (int)((num2 * 1696524012) ^ 0x2831ED7);
						continue;
					}
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
				int num = 1136210578;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D5D1ECAu) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 494800058) ^ 0x74CB2232);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)(num2 * 1738375076) ^ -1644127891;
						continue;
					case 0u:
						num = ((int)num2 * -1238137971) ^ -1446652053;
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

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			float result = default(float);
			while (true)
			{
				int num = -983661604;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE7252039u) % 4u)
					{
					case 1u:
						Set(aVal);
						result = 0f;
						num = (int)(num2 * 1368252999) ^ -554260862;
						continue;
					case 0u:
						num = (int)((num2 * 1443832359) ^ 0x615C91A7);
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
				int num = 890858297;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72E83FF3u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -587987299) ^ 0xBCAB6D4;
						continue;
					case 1u:
						num = (int)(num2 * 282559011) ^ -2844240;
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
			JSONData aVal = default(JSONData);
			double result = default(double);
			while (true)
			{
				int num = 1627503995;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1346BB86u) % 4u)
					{
					case 2u:
						Set(aVal);
						result = 0.0;
						num = (int)((num2 * 1087481565) ^ 0x65F46E87);
						continue;
					case 1u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -973740626) ^ -558281442;
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
				int num = -1023894686;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA91A0E3Fu) % 4u)
					{
					case 2u:
						Set(aVal);
						num = (int)(num2 * 650433480) ^ -1661520740;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -2046289429) ^ 0x54F68C06;
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
			bool result = default(bool);
			while (true)
			{
				int num = -1338886492;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB64074FDu) % 4u)
					{
					case 2u:
						result = false;
						num = ((int)num2 * -130066435) ^ 0x38A0A458;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -1367182876) ^ -2042023493;
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
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 284944275;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73466D15u) % 3u)
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
					num = (int)((num2 * 104755910) ^ 0x2BF1AC66);
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
				int num = -2024547841;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF804836Eu) % 4u)
					{
					case 3u:
						result = jSONArray;
						num = ((int)num2 * -1472221317) ^ 0x44982B17;
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)(num2 * 354027434) ^ -132371501;
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
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 1905914227;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1F1AC7C9u) % 5u)
					{
					case 3u:
						num = ((int)num2 * -357267391) ^ -1776442347;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -862378481) ^ -1151614049;
						continue;
					case 1u:
						Set(jSONClass);
						num = ((int)num2 * -1211681371) ^ -1399888582;
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
			int num = 1056345651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15873390u) % 6u)
				{
				case 4u:
					m_Key = null;
					num = (int)(num2 * 1996992792) ^ -499697583;
					continue;
				case 2u:
					m_Node = aNode;
					num = (int)((num2 * 1895757514) ^ 0x45F0E2AA);
					continue;
				case 1u:
					num = ((int)num2 * -718568060) ^ -1099039552;
					continue;
				case 0u:
					num = ((int)num2 * -56506861) ^ 0xBC56B3E;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
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
			int num = -1665793258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB92C76C4u) % 6u)
				{
				case 5u:
					m_Key = aKey;
					num = (int)(num2 * 1385288479) ^ -42520254;
					continue;
				case 4u:
					num = (int)((num2 * 946955446) ^ 0x782B5A82);
					continue;
				case 2u:
					num = ((int)num2 * -69193576) ^ -1455395572;
					continue;
				case 0u:
					m_Node = aNode;
					num = (int)((num2 * 1925582856) ^ 0x1F1B399B);
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

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = -1527118443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA67193FFu) % 11u)
				{
				case 9u:
					num = (int)(num2 * 511740597) ^ -425444320;
					continue;
				case 8u:
					num = ((int)num2 * -1228243020) ^ -1880067659;
					continue;
				case 7u:
					num = ((int)num2 * -1804971212) ^ 0x13E24148;
					continue;
				case 5u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -565621484) ^ 0x4D9C12C2;
					continue;
				case 4u:
					m_Node.Add(aVal);
					num = ((int)num2 * -2111959129) ^ 0x3C5F0F8B;
					continue;
				case 3u:
					num = ((int)num2 * -55592503) ^ 0x5C76594A;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = 1314794969;
						num4 = 1314794969;
					}
					else
					{
						num3 = 1393274599;
						num4 = 1393274599;
					}
					num = num3 ^ (int)(num2 * 1787969160);
					continue;
				}
				case 1u:
					m_Node = null;
					num = -1632450656;
					continue;
				case 0u:
					num = -1913537087;
					continue;
				default:
					return;
				case 10u:
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
			int num = 1213155816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F559F51u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				jSONArray.Add(aItem);
				Set(jSONArray);
				num = (int)(num2 * 251642063) ^ -1332696099;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 105858003;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE7D315u) % 4u)
				{
				case 3u:
					jSONClass.Add(aKey, aItem);
					Set(jSONClass);
					num = ((int)num2 * -2130255693) ^ 0x2D58FBD1;
					continue;
				case 2u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1551411458) ^ 0x7EE13ABE);
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
		if (b == null)
		{
			goto IL_0037;
		}
		goto IL_0065;
		IL_0065:
		bool result = (object)a == b;
		int num = -712923068;
		goto IL_003c;
		IL_003c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x89C1FC23u) % 6u)
			{
			case 5u:
				num = ((int)num2 * -671584105) ^ 0x4EF4F318;
				continue;
			case 4u:
				result = true;
				num = ((int)num2 * -134600648) ^ -1423665802;
				continue;
			case 1u:
				num = ((int)num2 * -759595534) ^ -2101372491;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0065;
			default:
				return result;
			}
			break;
		}
		goto IL_0037;
		IL_0037:
		num = -1205653851;
		goto IL_003c;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0006;
		}
		goto IL_0050;
		IL_0050:
		bool result = (object)this == obj;
		int num = -2108794093;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x82BB242Du) % 5u)
			{
			case 3u:
				break;
			case 2u:
				result = true;
				num = ((int)num2 * -1141226361) ^ -770026769;
				continue;
			case 1u:
				num = (int)((num2 * 1420160490) ^ 0x796143FB);
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
		num = -1352573113;
		goto IL_002b;
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
			int num = 2016010408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3606DD95u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -481095294) ^ -511337141;
					continue;
				case 1u:
					result = "";
					num = (int)(num2 * 1835380533) ^ -1174546673;
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

	public override string ToString(string aPrefix)
	{
		return "";
	}
}
