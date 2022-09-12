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
				int num = 547899562;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE8B40A1u) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1140192552) ^ -948167027;
						continue;
					case 0u:
						num = (int)(num2 * 1961386708) ^ -940127372;
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
				int num = 584283458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7236CF93u) % 6u)
					{
					case 5u:
						jSONArray = new JSONArray();
						num = (int)((num2 * 1811971239) ^ 0x5C8382EF);
						continue;
					case 3u:
						num = (int)(num2 * 1266180675) ^ -1546156632;
						continue;
					case 2u:
						Set(jSONArray);
						num = ((int)num2 * -1469434858) ^ -750205261;
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -1152528208) ^ -255920020;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1997328665;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x161B0137u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1058172804) ^ -1919088882;
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1658596273) ^ 0x5FAB596A;
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
			while (true)
			{
				int num = 738599079;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F2B8037u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -19323032) ^ 0xF8AB8FD;
						continue;
					case 4u:
						Set(jSONClass);
						num = ((int)num2 * -706100976) ^ 0x4347E44;
						continue;
					case 2u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -453796109) ^ -100688522;
						continue;
					case 1u:
						num = ((int)num2 * -960898245) ^ 0x74C70AB9;
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			Set(aVal);
			int result = default(int);
			while (true)
			{
				int num = -1707998987;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD1503F8u) % 4u)
					{
					case 2u:
						result = 0;
						num = (int)(num2 * 1308006246) ^ -828580793;
						continue;
					case 1u:
						num = (int)(num2 * 640596766) ^ -1347510688;
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
				int num = -599607412;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF58792Bu) % 4u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -906163954) ^ 0x4B318AB0;
						continue;
					case 1u:
						num = (int)(num2 * 1150459519) ^ -55011730;
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

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			Set(aVal);
			float result = default(float);
			while (true)
			{
				int num = -763677017;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE432B87Cu) % 4u)
					{
					case 3u:
						result = 0f;
						num = ((int)num2 * -1635634187) ^ -655954495;
						continue;
					case 2u:
						num = ((int)num2 * -853330182) ^ -539041515;
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
				int num = 798345875;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49768A2Fu) % 3u)
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
					num = (int)(num2 * 369203942) ^ -226639050;
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
				int num = -1953484281;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD9754EB7u) % 3u)
					{
					case 2u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					Set(aVal);
					result = 0.0;
					num = ((int)num2 * -2140515865) ^ -601434444;
				}
			}
		}
		set
		{
			JSONData aVal = new JSONData(value);
			Set(aVal);
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
				int num = -768718760;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C7926F7u) % 6u)
					{
					case 5u:
						num = (int)(num2 * 1073071757) ^ -2016437010;
						continue;
					case 4u:
						result = false;
						num = ((int)num2 * -1859440206) ^ -1467989986;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -1002297747) ^ 0x79995214;
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -429875444) ^ -189277396;
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
				int num = -1438374214;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA16A875Fu) % 4u)
					{
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1140210229) ^ 0x7D094286);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)((num2 * 830483524) ^ 0xD704149);
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
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 407496626;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2720EE60u) % 5u)
					{
					case 3u:
						num = ((int)num2 * -814894057) ^ -126909399;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1657058872) ^ -157358545;
						continue;
					case 1u:
						Set(jSONArray);
						result = jSONArray;
						num = ((int)num2 * -264459444) ^ 0x68B3168F;
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
				int num = 1392315346;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3249316Au) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000f:
					result = jSONClass;
					num = ((int)num2 * -502661782) ^ -2002345084;
				}
			}
		}
	}

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = 502634731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x293E9606u) % 5u)
				{
				case 4u:
					m_Node = aNode;
					m_Key = null;
					num = ((int)num2 * -432813755) ^ -631673057;
					continue;
				case 3u:
					num = (int)((num2 * 370156144) ^ 0xF3B1A3B);
					continue;
				case 1u:
					num = ((int)num2 * -330725357) ^ -657351045;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -108719819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9284B64Fu) % 5u)
				{
				case 2u:
					num = ((int)num2 * -1143004233) ^ 0x1A3B9344;
					continue;
				case 1u:
					num = (int)(num2 * 1791400038) ^ -146815406;
					continue;
				case 0u:
					m_Node = aNode;
					m_Key = aKey;
					num = (int)(num2 * 972906287) ^ -900660113;
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
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
			goto IL_0078;
		}
		goto IL_00eb;
		IL_00eb:
		int num = 666116379;
		goto IL_00ad;
		IL_00ad:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x62798F1Du) % 11u)
			{
			case 10u:
				num = ((int)num2 * -1277373863) ^ 0x39D321A9;
				continue;
			case 8u:
				m_Node = null;
				num = 817710270;
				continue;
			case 7u:
				num = ((int)num2 * -170846805) ^ -546711422;
				continue;
			case 6u:
				m_Node.Add(aVal);
				num = (int)((num2 * 42454256) ^ 0x54912804);
				continue;
			case 5u:
				num = ((int)num2 * -1330270556) ^ -21717845;
				continue;
			case 4u:
				num = ((int)num2 * -1836190903) ^ 0x60B913ED;
				continue;
			case 3u:
				break;
			case 1u:
				m_Node.Add(m_Key, aVal);
				num = ((int)num2 * -1303558697) ^ -1821986340;
				continue;
			case 0u:
				num = (int)((num2 * 1473559040) ^ 0x5BFCB4A0);
				continue;
			default:
				return;
			case 2u:
				goto IL_00eb;
			case 9u:
				return;
			}
			break;
		}
		goto IL_0078;
		IL_0078:
		num = 1179305847;
		goto IL_00ad;
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = new JSONArray();
		jSONArray.Add(aItem);
		Set(jSONArray);
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1001396217;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2EEBAACu) % 5u)
				{
				case 3u:
					Set(jSONClass);
					num = (int)((num2 * 1479024198) ^ 0x47DF7265);
					continue;
				case 2u:
					num = ((int)num2 * -274890438) ^ 0x51925877;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1133624175) ^ 0x2BC106AE;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 179079281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2061974Au) % 6u)
				{
				case 5u:
					result = (object)a == b;
					num = 2095433077;
					continue;
				case 3u:
					num = ((int)num2 * -1478853426) ^ -1431379388;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (b != null)
					{
						num3 = 956443731;
						num4 = 956443731;
					}
					else
					{
						num3 = 404241624;
						num4 = 404241624;
					}
					num = num3 ^ (int)(num2 * 1448394382);
					continue;
				}
				case 0u:
					result = true;
					num = ((int)num2 * -1705160907) ^ -266136642;
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
		bool result = !(a == b);
		while (true)
		{
			int num = -685060436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8066F5Eu) % 3u)
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
				num = (int)(num2 * 272007363) ^ -434979374;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 240354871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E5E32B6u) % 7u)
				{
				case 6u:
					num = (int)(num2 * 230688667) ^ -663092628;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (obj == null)
					{
						num3 = -1684076357;
						num4 = -1684076357;
					}
					else
					{
						num3 = -1551545913;
						num4 = -1551545913;
					}
					num = num3 ^ (int)(num2 * 2116774512);
					continue;
				}
				case 3u:
					result = true;
					num = (int)(num2 * 1577416756) ^ -155060463;
					continue;
				case 2u:
					result = (object)this == obj;
					num = 1980699195;
					continue;
				case 1u:
					num = ((int)num2 * -176117223) ^ -1891538248;
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
			int num = -2125701322;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1C43E1Du) % 3u)
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
				num = ((int)num2 * -1119973205) ^ -816214406;
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
			int num = 1897974136;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69D5C5D6u) % 4u)
				{
				case 2u:
					result = "";
					num = ((int)num2 * -1424488496) ^ 0x231196EB;
					continue;
				case 1u:
					num = ((int)num2 * -2050367081) ^ 0x11436BD2;
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
