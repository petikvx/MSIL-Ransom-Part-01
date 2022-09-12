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
				int num = 1420331520;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58FE64B1u) % 4u)
					{
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1700595697) ^ 0x5C14719E;
						continue;
					case 0u:
						num = (int)((num2 * 607528637) ^ 0x166A9EF6);
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
				int num = 1655616716;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37D0ADF0u) % 6u)
					{
					case 3u:
						jSONArray.Add(value);
						num = ((int)num2 * -717886642) ^ 0x3F34DC97;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1022661059) ^ 0x413FEAB7;
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)((num2 * 54366078) ^ 0x3A26F70);
						continue;
					case 0u:
						num = ((int)num2 * -1630967964) ^ -2064421321;
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
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 594485283;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F0E5924u) % 3u)
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
					num = (int)(num2 * 896263312) ^ -785412179;
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = 1277706060;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69FAC87u) % 6u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -1495762462) ^ 0x62718529;
						continue;
					case 2u:
						num = (int)((num2 * 120907127) ^ 0x7ADFDF60);
						continue;
					case 1u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 295343056) ^ -831813835;
						continue;
					case 0u:
						num = (int)((num2 * 1010888114) ^ 0x6D4CAB9);
						continue;
					default:
						return;
					case 5u:
						break;
					case 4u:
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
				int num = -1063954797;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3B276DEu) % 5u)
					{
					case 2u:
						result = 0;
						num = (int)(num2 * 1672096757) ^ -162623441;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1657297724) ^ -417349943;
						continue;
					case 0u:
						num = ((int)num2 * -1741772530) ^ 0x35D39C63;
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
			float result = default(float);
			while (true)
			{
				int num = -2130398639;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2124E43u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1644806920) ^ -1670727298;
						continue;
					case 2u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						result = 0f;
						num = ((int)num2 * -438363126) ^ -58318552;
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
				int num = -1761075205;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x919F8CF7u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						Set(aVal);
						return;
					}
					break;
					IL_0003:
					aVal = new JSONData(value);
					num = ((int)num2 * -1980671534) ^ 0x25096EEF;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = -377797099;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFFAF8880u) % 5u)
					{
					case 4u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = ((int)num2 * -1441655520) ^ 0x7F1FC608;
						continue;
					}
					case 3u:
						result = 0.0;
						num = ((int)num2 * -167170485) ^ 0x45FF946C;
						continue;
					case 2u:
						num = ((int)num2 * -1823486371) ^ -715868521;
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
				int num = 1442174183;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x247B56CEu) % 4u)
					{
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)((num2 * 1257812713) ^ 0x21ACED5F);
						continue;
					}
					case 0u:
						num = (int)(num2 * 629668196) ^ -1929908775;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = new JSONData(aData: false);
			bool result = default(bool);
			while (true)
			{
				int num = 2018756103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79711B55u) % 5u)
					{
					case 4u:
						result = false;
						num = ((int)num2 * -1724617813) ^ 0x60C403A0;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -1804004905) ^ 0x17F4B8A8;
						continue;
					case 2u:
						num = (int)(num2 * 1650688051) ^ -875097695;
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
				int num = 2135094993;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3671D16u) % 3u)
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
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = ((int)num2 * -1681892132) ^ -5711817;
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
				int num = -931768529;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9783A379u) % 6u)
					{
					case 4u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -629304990) ^ 0x61A80644;
						continue;
					case 3u:
						Set(jSONArray);
						num = (int)((num2 * 1452560761) ^ 0xC09928A);
						continue;
					case 1u:
						num = ((int)num2 * -144033922) ^ -152287269;
						continue;
					case 0u:
						result = jSONArray;
						num = (int)((num2 * 1839588006) ^ 0x275CCB28);
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
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1488851240;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA524EEDEu) % 6u)
					{
					case 5u:
						result = jSONClass;
						num = (int)((num2 * 84482915) ^ 0x19D57D40);
						continue;
					case 4u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 1718745872) ^ 0x4E3D49EC);
						continue;
					case 3u:
						num = (int)((num2 * 1998970023) ^ 0x78A4D1D2);
						continue;
					case 2u:
						Set(jSONClass);
						num = ((int)num2 * -36543550) ^ -947199467;
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
			int num = -1290507658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x960F0FE2u) % 3u)
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
				num = ((int)num2 * -850182522) ^ 0x191BFE43;
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -2042584488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6222C4Au) % 12u)
				{
				case 10u:
					flag = m_Key == null;
					num = ((int)num2 * -2108807366) ^ 0x3699C822;
					continue;
				case 9u:
					num = -952025915;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1262267197;
						num4 = -1262267197;
					}
					else
					{
						num3 = -1324813085;
						num4 = -1324813085;
					}
					num = num3 ^ ((int)num2 * -45854191);
					continue;
				}
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -833785758) ^ -1292309010;
					continue;
				case 6u:
					m_Node = null;
					num = -865778515;
					continue;
				case 4u:
					num = ((int)num2 * -539116734) ^ 0x153BC444;
					continue;
				case 3u:
					num = (int)(num2 * 36709996) ^ -1702850186;
					continue;
				case 2u:
					num = ((int)num2 * -1930300942) ^ -996977096;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1953934576) ^ 0x180873F5;
					continue;
				case 0u:
					num = ((int)num2 * -1613800371) ^ -1358653322;
					continue;
				default:
					return;
				case 5u:
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
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = -1468652305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6155BB0u) % 4u)
				{
				case 3u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = (int)(num2 * 1381459103) ^ -727334473;
					continue;
				case 2u:
					Set(jSONArray);
					num = ((int)num2 * -2006650402) ^ 0x401ED32D;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -547992288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7CF218Au) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = ((int)num2 * -589421820) ^ 0x503B6121;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1730670554) ^ -1304369512;
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 798127031) ^ -1308548351;
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
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = -1231097898;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE373FB5Au) % 6u)
				{
				case 4u:
					num = (int)((num2 * 974419585) ^ 0x18512B12);
					continue;
				case 3u:
					result = true;
					num = (int)((num2 * 472570942) ^ 0x2791F41C);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 305012305;
						num4 = 305012305;
					}
					else
					{
						num3 = 1684855425;
						num4 = 1684855425;
					}
					num = num3 ^ (int)(num2 * 80097144);
					continue;
				}
				case 1u:
					result = (object)a == b;
					num = -805422274;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -1845614383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE8AE141u) % 3u)
				{
				case 2u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1808179519) ^ -1650182894;
			}
		}
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
		int num = 2020159263;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x6648FCB9u) % 5u)
			{
			case 4u:
				break;
			case 3u:
				num = ((int)num2 * -866275569) ^ 0x62D7EE33;
				continue;
			case 1u:
				result = true;
				num = ((int)num2 * -22533587) ^ 0x7530F559;
				continue;
			case 2u:
				goto IL_0050;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = 1730250493;
		goto IL_002b;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 538446435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F1DE81Cu) % 4u)
				{
				case 3u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -1215839231) ^ -39119765;
					continue;
				case 0u:
					num = (int)((num2 * 504334930) ^ 0x33AB3CC5);
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
			int num = -1181394877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91549645u) % 3u)
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
				num = ((int)num2 * -2041226386) ^ 0xD0BBF8A;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1139277505;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85803665u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1574734669) ^ 0x3A8E61D3);
					continue;
				case 2u:
					result = "";
					num = ((int)num2 * -376479223) ^ -1287120312;
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
