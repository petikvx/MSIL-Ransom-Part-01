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
				int num = 2120317453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A791358u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1191659497) ^ -1198308091;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -852499468) ^ -1724592750;
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
			while (true)
			{
				int num = -327898873;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD433282Fu) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1057735865) ^ 0x504FE897);
						continue;
					case 3u:
						Set(jSONArray);
						num = (int)(num2 * 1976029634) ^ -1104404531;
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -1286576591) ^ 0x3D0B9DCA;
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
				int num = 416403964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F9B95Bu) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = ((int)num2 * -204498205) ^ 0x488B4B5F;
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			while (true)
			{
				int num = 457477501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20EFAF86u) % 4u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -1727497093) ^ -1658122519;
						continue;
					case 2u:
						num = (int)(num2 * 149538237) ^ -913570731;
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
			return 0;
		}
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -301638933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE97EB36u) % 3u)
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
					num = (int)(num2 * 402717279) ^ -2007849482;
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
				int num = 1196513739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2937D6C8u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 180639661) ^ 0x5E0F048B);
						continue;
					case 2u:
						result = 0f;
						num = (int)((num2 * 838958171) ^ 0x7EE2EE7E);
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1152203459) ^ -399333250;
						continue;
					case 0u:
						num = ((int)num2 * -716772740) ^ 0xECF38D;
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
				int num = -1141335804;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97A8A646u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1873833514) ^ 0xB8EFB37);
						continue;
					case 1u:
						num = (int)(num2 * 493878352) ^ -333024827;
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			double result = default(double);
			while (true)
			{
				int num = -408101096;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA35AFA66u) % 4u)
					{
					case 2u:
						result = 0.0;
						num = (int)((num2 * 2092797991) ^ 0x34904F35);
						continue;
					case 1u:
						num = (int)((num2 * 708206192) ^ 0x573A90C9);
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
				int num = 770250224;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x255B1483u) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)((num2 * 1643941928) ^ 0x26F6B5AB);
						continue;
					}
					case 0u:
						num = (int)(num2 * 1329769499) ^ -1980844902;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = new JSONData(aData: false);
			bool result = default(bool);
			while (true)
			{
				int num = 1737758916;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x233A3BE3u) % 5u)
					{
					case 3u:
						result = false;
						num = ((int)num2 * -394792532) ^ -1262380230;
						continue;
					case 2u:
						num = (int)(num2 * 1153355320) ^ -325761597;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -305565315) ^ 0x37F4DD07;
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
				int num = 2120929267;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BDD4769u) % 3u)
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
					num = ((int)num2 * -1729890626) ^ -1293618287;
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
			return jSONArray;
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
				int num = 766390989;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1471F8FCu) % 5u)
					{
					case 3u:
						result = jSONClass;
						num = ((int)num2 * -48385487) ^ 0x6828004E;
						continue;
					case 1u:
						Set(jSONClass);
						num = (int)(num2 * 1611430782) ^ -1697641659;
						continue;
					case 0u:
						num = (int)((num2 * 1640421757) ^ 0x623204BB);
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
			int num = 35177432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33C89519u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1788049284) ^ -412301395;
					continue;
				case 1u:
					num = (int)((num2 * 208864061) ^ 0x34FB4913);
					continue;
				case 2u:
					break;
				default:
					m_Node = aNode;
					m_Key = null;
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
			int num = -287381796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD78B005Fu) % 11u)
				{
				case 10u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1151005012) ^ -1962410149;
					continue;
				case 8u:
					num = -893658013;
					continue;
				case 7u:
					num = (int)((num2 * 1638285989) ^ 0x74590019);
					continue;
				case 6u:
					num = ((int)num2 * -480414242) ^ 0x884B4A8;
					continue;
				case 5u:
					num = ((int)num2 * -1472971837) ^ 0x38F737DF;
					continue;
				case 3u:
					num = (int)(num2 * 1011549934) ^ -26128170;
					continue;
				case 2u:
					num = (int)((num2 * 2773959) ^ 0x8F8026B);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1390192987;
						num4 = 1390192987;
					}
					else
					{
						num3 = 505878906;
						num4 = 505878906;
					}
					num = num3 ^ (int)(num2 * 1443732591);
					continue;
				}
				case 0u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1970055949) ^ 0x3A2B2649;
					continue;
				case 9u:
					break;
				default:
					m_Node = null;
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
			int num = -1889485011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3D8D8EBu) % 6u)
				{
				case 3u:
					num = (int)(num2 * 915335183) ^ -985247405;
					continue;
				case 2u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -1570808324) ^ 0x36B0B898;
					continue;
				case 1u:
					Set(jSONArray);
					num = (int)(num2 * 458046743) ^ -258218218;
					continue;
				case 0u:
					num = ((int)num2 * -2043701690) ^ 0x2B3CA8E6;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = 2000957683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x345170A0u) % 3u)
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
				jSONClass.Add(aKey, aItem);
				Set(jSONClass);
				num = (int)((num2 * 1261564864) ^ 0x4146F77D);
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
		int num = -999007237;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA649B12Cu) % 5u)
			{
			case 4u:
				break;
			case 2u:
				result = true;
				num = ((int)num2 * -1215147111) ^ -129919135;
				continue;
			case 1u:
				num = ((int)num2 * -678556946) ^ -429460777;
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
		num = -1763601981;
		goto IL_002b;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -266234473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1BD2762u) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = (int)((num2 * 443336218) ^ 0x447AED50);
					continue;
				case 0u:
					num = ((int)num2 * -430060336) ^ -435285276;
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

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0006;
		}
		goto IL_0050;
		IL_0050:
		bool result = (object)this == obj;
		int num = -191713438;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x818891BBu) % 5u)
			{
			case 3u:
				break;
			case 2u:
				num = ((int)num2 * -782934875) ^ 0x3313A71E;
				continue;
			case 1u:
				result = true;
				num = ((int)num2 * -1095650630) ^ -586159489;
				continue;
			case 4u:
				goto IL_0050;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = -1971413939;
		goto IL_002b;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 622523132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x178C8A0Au) % 4u)
				{
				case 2u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -205810842) ^ 0x15C9036F;
					continue;
				case 1u:
					num = (int)((num2 * 815442964) ^ 0x489F8302);
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
			int num = 1354737839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E684B50u) % 4u)
				{
				case 3u:
					result = "";
					num = ((int)num2 * -1620320837) ^ 0x46FC6BB;
					continue;
				case 2u:
					num = (int)(num2 * 1892945657) ^ -1996949421;
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
			int num = 121277741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52D0F94Cu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1657200627) ^ 0x269DA6A9);
					continue;
				case 1u:
					result = "";
					num = (int)(num2 * 1020698815) ^ -1102070455;
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
