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
				int num = -93441211;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE22878AEu) % 3u)
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
					num = (int)((num2 * 1642947297) ^ 0x166C82E);
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			Set(jSONArray);
			while (true)
			{
				int num = 8714557;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79F889A7u) % 3u)
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
					num = ((int)num2 * -848677120) ^ -1190117512;
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
				int num = -1567716157;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC8249AF2u) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = ((int)num2 * -590944430) ^ 0x217607BE;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1972705928;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9F22E1Du) % 4u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -1322533901) ^ 0x7AA3A7EA;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 1744244067) ^ 0x79E1005);
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = -603793838;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9ED95F80u) % 4u)
					{
					case 2u:
						aVal = new JSONData(0);
						num = (int)((num2 * 1479285131) ^ 0x1CDAD63);
						continue;
					case 1u:
						Set(aVal);
						result = 0;
						num = ((int)num2 * -1274672367) ^ -335175330;
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
				int num = -365722910;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC8EC0AFDu) % 4u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = (int)(num2 * 126044819) ^ -1496622312;
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -1470178259) ^ 0x7E8571F0;
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

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = -43087631;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBEAC2533u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1876677785) ^ -1576053250;
						continue;
					case 3u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = (int)(num2 * 782577611) ^ -345437827;
						continue;
					}
					case 1u:
						result = 0f;
						num = ((int)num2 * -334005667) ^ -1419066271;
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
				int num = -823830562;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB3CB1877u) % 3u)
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
					num = ((int)num2 * -599515141) ^ 0x16263447;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			double result = 0.0;
			while (true)
			{
				int num = -828274307;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2EC9B37u) % 3u)
					{
					case 2u:
						goto IL_0022;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0022:
					num = ((int)num2 * -1866816895) ^ 0x5AFE664F;
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
			while (true)
			{
				int num = -987616501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3190313u) % 5u)
					{
					case 4u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = (int)((num2 * 401660405) ^ 0x602F8411);
						continue;
					}
					case 2u:
						result = false;
						num = (int)(num2 * 82060677) ^ -1523490698;
						continue;
					case 0u:
						num = (int)((num2 * 928330930) ^ 0x4535E894);
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
				int num = 830777093;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50F6787Eu) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -1084592747) ^ -2097697593;
						continue;
					}
					case 2u:
						num = ((int)num2 * -2086029962) ^ 0x6F236007;
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
			Set(jSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 47780547;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73534A38u) % 3u)
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
					result = jSONArray;
					num = (int)(num2 * 1967034687) ^ -175887923;
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
				int num = -2140381517;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEDB3908Cu) % 6u)
					{
					case 3u:
						result = jSONClass;
						num = (int)(num2 * 1178848170) ^ -657404568;
						continue;
					case 2u:
						num = (int)((num2 * 1034002256) ^ 0x11A84F27);
						continue;
					case 1u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 1706046212) ^ 0x1C2B5F1C);
						continue;
					case 0u:
						num = ((int)num2 * -691908581) ^ 0x17036D1E;
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
		m_Node = aNode;
		m_Key = aKey;
	}

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1372220362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA131DB2u) % 10u)
				{
				case 8u:
					m_Node = null;
					num = 628922688;
					continue;
				case 7u:
					num = ((int)num2 * -569824795) ^ -1327052529;
					continue;
				case 6u:
					flag = m_Key == null;
					num = ((int)num2 * -2047299567) ^ -599789266;
					continue;
				case 5u:
					m_Node.Add(aVal);
					num = ((int)num2 * -966652149) ^ -929315241;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 2053243299;
						num4 = 2053243299;
					}
					else
					{
						num3 = 1380873918;
						num4 = 1380873918;
					}
					num = num3 ^ (int)(num2 * 1117443913);
					continue;
				}
				case 3u:
					num = 397875265;
					continue;
				case 1u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 973953185) ^ 0x33B87EE4);
					continue;
				case 0u:
					num = ((int)num2 * -1172390635) ^ -1778631655;
					continue;
				default:
					return;
				case 9u:
					break;
				case 2u:
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
			int num = 1638663427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71BCF6F0u) % 6u)
				{
				case 5u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -1228050737) ^ 0x6D1E3302;
					continue;
				case 3u:
					num = ((int)num2 * -1649350239) ^ -598328813;
					continue;
				case 1u:
					num = ((int)num2 * -1326578988) ^ 0x71D64E;
					continue;
				case 0u:
					Set(jSONArray);
					num = ((int)num2 * -124883845) ^ -239932621;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 1479763887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5455B0FEu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					Set(jSONClass);
					return;
				}
				break;
				IL_0003:
				jSONClass = new JSONClass();
				jSONClass.Add(aKey, aItem);
				num = ((int)num2 * -903573069) ^ 0x5CB096D2;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1760462166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x890BC0BCu) % 7u)
				{
				case 5u:
					result = true;
					num = ((int)num2 * -533399086) ^ -1775574045;
					continue;
				case 4u:
					num = ((int)num2 * -1120241411) ^ 0x4CD3EC5E;
					continue;
				case 3u:
					result = (object)a == b;
					num = -1006380083;
					continue;
				case 1u:
					flag = b == null;
					num = (int)(num2 * 2091754808) ^ -1458002372;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 310443803;
						num4 = 310443803;
					}
					else
					{
						num3 = 1647598580;
						num4 = 1647598580;
					}
					num = num3 ^ (int)(num2 * 314809204);
					continue;
				}
				case 2u:
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
			int num = -51171958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC039AEFEu) % 3u)
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
				num = ((int)num2 * -2071716617) ^ -1345377896;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -260835644;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x875C9E90u) % 8u)
				{
				case 6u:
					result = true;
					num = ((int)num2 * -1600082363) ^ 0x4488EB87;
					continue;
				case 5u:
					num = ((int)num2 * -704297107) ^ 0x36A8F7FB;
					continue;
				case 4u:
					flag = obj == null;
					num = (int)((num2 * 460787674) ^ 0x5EDFBFB8);
					continue;
				case 3u:
					result = (object)this == obj;
					num = -1594901499;
					continue;
				case 1u:
					num = (int)((num2 * 481193288) ^ 0x7400BE42);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -195928461;
						num4 = -195928461;
					}
					else
					{
						num3 = -1581483938;
						num4 = -1581483938;
					}
					num = num3 ^ (int)(num2 * 954925312);
					continue;
				}
				case 7u:
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
			int num = 1227845789;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x759B201Cu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 2108781945) ^ -1292084618;
					continue;
				case 1u:
					hashCode = base.GetHashCode();
					num = (int)((num2 * 714740427) ^ 0x79EAEB39);
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
			int num = -1687734403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB5A4F1Cu) % 3u)
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
				num = (int)(num2 * 907583911) ^ -696851704;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = 670329298;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x380E9FF3u) % 3u)
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
				num = (int)(num2 * 2095979412) ^ -839957045;
			}
		}
	}
}
