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
				int num = 1170863941;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36638677u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1045767393) ^ 0x25B0FF13;
						continue;
					case 2u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1728722485) ^ 0x43D1D986);
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
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = -1498428647;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1966948u) % 4u)
					{
					case 2u:
						Set(jSONArray);
						num = ((int)num2 * -1203069076) ^ 0x66BCDAB4;
						continue;
					case 1u:
						num = (int)(num2 * 879504142) ^ -406059576;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1608057803;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x118594CEu) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1400876762) ^ -407221034;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = (int)(num2 * 2091238655) ^ -1711581945;
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
			while (true)
			{
				int num = 1885327516;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x482D4EF3u) % 5u)
					{
					case 4u:
						num = (int)(num2 * 632976151) ^ -295362511;
						continue;
					case 1u:
						num = (int)((num2 * 2133054674) ^ 0x51B919F0);
						continue;
					case 0u:
						Set(jSONClass);
						num = (int)((num2 * 1943596550) ^ 0x6919B648);
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = 1636295885;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA564C4Du) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1917992401) ^ 0x1A2C4EE2);
						continue;
					case 2u:
						aVal = new JSONData(0);
						num = ((int)num2 * -73465315) ^ 0x6DECF5F0;
						continue;
					case 1u:
						Set(aVal);
						result = 0;
						num = ((int)num2 * -1060397072) ^ -1402105042;
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
				int num = 1619832263;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64B30768u) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -340095144) ^ -969581270;
						continue;
					}
					case 2u:
						num = ((int)num2 * -594114586) ^ -970617079;
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

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = -728632953;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC32B546Eu) % 5u)
					{
					case 4u:
						result = 0f;
						num = ((int)num2 * -642944125) ^ 0x2BEEEC82;
						continue;
					case 2u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = ((int)num2 * -135237034) ^ -1183002526;
						continue;
					}
					case 1u:
						num = ((int)num2 * -207688076) ^ 0x42CD7063;
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
				int num = 1941606378;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A43EE81u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 1854336747) ^ 0x3DDB8438);
						continue;
					case 0u:
						num = (int)((num2 * 729683052) ^ 0x315F00B8);
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = -416865904;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA3F1927u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 2139416251) ^ 0x79F211C8);
						continue;
					case 4u:
						result = 0.0;
						num = ((int)num2 * -103045630) ^ -1024916481;
						continue;
					case 2u:
						num = ((int)num2 * -1409019272) ^ 0x6B2754A6;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1265152538) ^ -107100890;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = new JSONData(aData: false);
			Set(aVal);
			bool result = default(bool);
			while (true)
			{
				int num = -481079765;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC3AB8F7u) % 3u)
					{
					case 1u:
						goto IL_0010;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0010:
					result = false;
					num = ((int)num2 * -1186404894) ^ -681515259;
				}
			}
		}
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -430611522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE43CD867u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -1263917169) ^ -271062610;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)(num2 * 1848313107) ^ -1418331650;
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
			JSONArray result = default(JSONArray);
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1873775655;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x748B40BAu) % 6u)
					{
					case 5u:
						result = jSONArray;
						num = (int)(num2 * 1765635465) ^ -1270227887;
						continue;
					case 2u:
						num = (int)((num2 * 1500887205) ^ 0x5696AC6F);
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 854700686) ^ -1852472916;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)(num2 * 521201247) ^ -365132100;
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
				int num = -936831613;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3B30A5Bu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1379321976) ^ 0x243745BE;
						continue;
					case 4u:
						num = (int)(num2 * 559833945) ^ -127231819;
						continue;
					case 3u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -1728179328) ^ -1267963939;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -1900299649) ^ -1369493439;
						continue;
					case 1u:
						Set(jSONClass);
						num = ((int)num2 * -1750128947) ^ -581052653;
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
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 25495881;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6DC4774u) % 6u)
				{
				case 5u:
					m_Key = aKey;
					num = (int)((num2 * 392287118) ^ 0x17FDB90B);
					continue;
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -1817634928) ^ 0x7626F8F3;
					continue;
				case 1u:
					num = ((int)num2 * -577519072) ^ 0x6669AE2;
					continue;
				case 0u:
					num = (int)(num2 * 1885309904) ^ -732977268;
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

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1496819636;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC47FB67Au) % 11u)
				{
				case 10u:
					num = ((int)num2 * -876951712) ^ 0x15D862CF;
					continue;
				case 9u:
					num = (int)(num2 * 623612447) ^ -916646818;
					continue;
				case 8u:
					num = ((int)num2 * -1307451322) ^ -1930036163;
					continue;
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = -1871939761;
					continue;
				case 6u:
					num = (int)(num2 * 1594054109) ^ -1563173042;
					continue;
				case 3u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1296069496) ^ -1238212154;
					continue;
				case 2u:
					m_Node = null;
					num = -1712408148;
					continue;
				case 1u:
					flag = m_Key == null;
					num = (int)(num2 * 323204697) ^ -1102612298;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1378364025;
						num4 = -1378364025;
					}
					else
					{
						num3 = -888675877;
						num4 = -888675877;
					}
					num = num3 ^ (int)(num2 * 1239286449);
					continue;
				}
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

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = new JSONArray();
		jSONArray.Add(aItem);
		while (true)
		{
			int num = -2073453173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2F91DE7u) % 5u)
				{
				case 3u:
					Set(jSONArray);
					num = ((int)num2 * -1096062247) ^ -366934555;
					continue;
				case 2u:
					num = (int)(num2 * 1157873130) ^ -1373260531;
					continue;
				case 1u:
					num = (int)((num2 * 1547778245) ^ 0x22BEB740);
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -765590822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87F9C371u) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = (int)(num2 * 853941532) ^ -1214966135;
					continue;
				case 3u:
					num = ((int)num2 * -642437273) ^ -494177720;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1383313268) ^ -108161293;
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
		if (b == null)
		{
			goto IL_0019;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)a == b;
		int num = -1460088373;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x81367E4Eu) % 5u)
			{
			case 4u:
				result = true;
				num = (int)((num2 * 435265709) ^ 0x20D5A288);
				continue;
			case 3u:
				break;
			case 0u:
				num = (int)(num2 * 1944648062) ^ -482850991;
				continue;
			case 1u:
				goto IL_0052;
			default:
				return result;
			}
			break;
		}
		goto IL_0019;
		IL_0019:
		num = -1750417147;
		goto IL_002d;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1113722491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7BCB728u) % 7u)
				{
				case 5u:
					flag = obj == null;
					num = ((int)num2 * -957034868) ^ -782581946;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1071348859;
						num4 = 1071348859;
					}
					else
					{
						num3 = 1197322678;
						num4 = 1197322678;
					}
					num = num3 ^ ((int)num2 * -870724349);
					continue;
				}
				case 2u:
					result = true;
					num = (int)(num2 * 624771420) ^ -1300183942;
					continue;
				case 1u:
					num = (int)(num2 * 697734836) ^ -2135181550;
					continue;
				case 0u:
					result = (object)this == obj;
					num = -337693118;
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

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = -63120330;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEA2AF80u) % 4u)
				{
				case 2u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -1844516032) ^ -442148659;
					continue;
				case 1u:
					num = (int)(num2 * 1137278394) ^ -1017036106;
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
		return "";
	}

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = 550216262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51FD9344u) % 3u)
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
				num = ((int)num2 * -1465512693) ^ -1503718573;
			}
		}
	}
}
