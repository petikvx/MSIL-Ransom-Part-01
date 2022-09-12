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
				int num = 1096631990;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68A4A5E4u) % 3u)
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
					result = new JSONLazyCreator(this);
					num = (int)(num2 * 1365994359) ^ -213974851;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = -492598972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE1748B45u) % 4u)
					{
					case 1u:
						num = ((int)num2 * -910472160) ^ 0x22F1E24D;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)((num2 * 547166145) ^ 0xAB19663);
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 1048348649;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x16A09ECu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					num = ((int)num2 * -1284858052) ^ 0x326F6544;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1066262489;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x67583C12u) % 3u)
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
					jSONClass.Add(aKey, value);
					num = (int)((num2 * 351378972) ^ 0x7BBC4478);
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
				int num = 802032950;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5FB62EDCu) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1386679573) ^ 0x46819D30);
						continue;
					case 3u:
						result = 0;
						num = ((int)num2 * -1596830481) ^ 0x6D96FA31;
						continue;
					case 1u:
						num = ((int)num2 * -1496594788) ^ -1391844807;
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
				int num = -343170741;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC15D1CF8u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 371718466) ^ -1573792178;
						continue;
					case 0u:
						num = ((int)num2 * -129589363) ^ -904679667;
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
			JSONData aVal = default(JSONData);
			float result = default(float);
			while (true)
			{
				int num = -1600328218;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAF79B0AEu) % 6u)
					{
					case 4u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -1396606860) ^ -1315586334;
						continue;
					case 2u:
						result = 0f;
						num = ((int)num2 * -310946967) ^ -1097605663;
						continue;
					case 1u:
						num = (int)((num2 * 1258009808) ^ 0x71F6FAD5);
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -304066605) ^ -2032380834;
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

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = 2132364417;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x275D4990u) % 3u)
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
					JSONData aVal = new JSONData(0.0);
					Set(aVal);
					result = 0.0;
					num = (int)((num2 * 1327900198) ^ 0x490B5949);
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
			bool result = default(bool);
			while (true)
			{
				int num = -248542702;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x932C6410u) % 5u)
					{
					case 4u:
						result = false;
						num = ((int)num2 * -1187854819) ^ 0x54447D19;
						continue;
					case 2u:
						num = (int)((num2 * 1685543666) ^ 0x1ACCD2CC);
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -764532078) ^ -99730710;
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -123957661;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9A79CD5u) % 4u)
					{
					case 2u:
						Set(jSONArray);
						result = jSONArray;
						num = ((int)num2 * -1465899038) ^ 0x1F24231C;
						continue;
					case 1u:
						num = (int)(num2 * 1286401424) ^ -190156623;
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
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1755657992;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F54CC92u) % 6u)
					{
					case 5u:
						result = jSONClass;
						num = (int)((num2 * 522939202) ^ 0x40B8F6D1);
						continue;
					case 4u:
						num = (int)(num2 * 2083589163) ^ -1681922483;
						continue;
					case 2u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)(num2 * 1006548757) ^ -1382773188;
						continue;
					case 1u:
						num = ((int)num2 * -1173670013) ^ -334377092;
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
		while (true)
		{
			int num = 1933689378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4ECBA510u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 869721122) ^ -940287243;
					continue;
				case 3u:
					num = (int)((num2 * 282477845) ^ 0xCDDA73);
					continue;
				case 1u:
					m_Key = null;
					num = (int)(num2 * 1011321096) ^ -1289031213;
					continue;
				case 0u:
					m_Node = aNode;
					num = ((int)num2 * -10116551) ^ 0x7C550C61;
					continue;
				default:
					return;
				case 2u:
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
			int num = -1980728065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FAB0B17u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 701763869) ^ -967564542;
					continue;
				case 3u:
					num = (int)(num2 * 534408495) ^ -1680815045;
					continue;
				case 2u:
					m_Node = aNode;
					m_Key = aKey;
					num = (int)(num2 * 980355832) ^ -393104853;
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
			goto IL_002e;
		}
		goto IL_00c3;
		IL_00c3:
		int num = 1117667469;
		goto IL_008d;
		IL_008d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x156ECCA5u) % 9u)
			{
			case 7u:
				num = (int)(num2 * 1333193547) ^ -439248687;
				continue;
			case 6u:
				num = (int)((num2 * 389531878) ^ 0x70D842DD);
				continue;
			case 5u:
				break;
			case 4u:
				num = ((int)num2 * -294031973) ^ -873804832;
				continue;
			case 3u:
				num = (int)(num2 * 307185199) ^ -2106932126;
				continue;
			case 1u:
				m_Node.Add(aVal);
				num = ((int)num2 * -858053913) ^ -209971112;
				continue;
			case 0u:
				m_Node.Add(m_Key, aVal);
				num = (int)(num2 * 400607775) ^ -218615840;
				continue;
			case 8u:
				goto IL_00c3;
			default:
				m_Node = null;
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		num = 1722360256;
		goto IL_008d;
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = -1713163332;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF59C2B52u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 1772797587) ^ -1415952192;
					continue;
				case 2u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -1356864321) ^ 0x6F51078E;
					continue;
				case 1u:
					num = ((int)num2 * -534820973) ^ 0x5C796364;
					continue;
				case 0u:
					Set(jSONArray);
					num = ((int)num2 * -793846266) ^ 0x560CC417;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		jSONClass.Add(aKey, aItem);
		while (true)
		{
			int num = 87247773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45D3405Du) % 3u)
				{
				case 2u:
					goto IL_0010;
				case 0u:
					break;
				default:
					Set(jSONClass);
					return;
				}
				break;
				IL_0010:
				num = ((int)num2 * -1694676747) ^ 0x72019D16;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1849460969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x310DCBEu) % 8u)
				{
				case 7u:
					flag = b == null;
					num = ((int)num2 * -1833949241) ^ 0x224AA116;
					continue;
				case 5u:
					num = (int)((num2 * 836735051) ^ 0x42821E67);
					continue;
				case 4u:
					num = (int)(num2 * 284067177) ^ -1082042620;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -521663778) ^ 0x47F2AB1;
					continue;
				case 2u:
					result = (object)a == b;
					num = 420828778;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2016398719;
						num4 = -2016398719;
					}
					else
					{
						num3 = -1223186488;
						num4 = -1223186488;
					}
					num = num3 ^ (int)(num2 * 1349676485);
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
			int num = -777228357;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF04911A0u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = (int)((num2 * 438302435) ^ 0x45EE164);
					continue;
				case 1u:
					num = (int)(num2 * 705458595) ^ -1519398027;
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
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = 535487754;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x122E3728u) % 7u)
				{
				case 6u:
					result = true;
					num = (int)((num2 * 1125644756) ^ 0x7D8631E3);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1771890011;
						num4 = 1771890011;
					}
					else
					{
						num3 = 1491957582;
						num4 = 1491957582;
					}
					num = num3 ^ ((int)num2 * -1808459245);
					continue;
				}
				case 3u:
					num = ((int)num2 * -971481518) ^ -115823086;
					continue;
				case 1u:
					num = ((int)num2 * -1560557936) ^ -1813989764;
					continue;
				case 0u:
					result = (object)this == obj;
					num = 483417454;
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

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 241759074;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30066DEFu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1329208512) ^ 0x60F0E943);
					continue;
				case 1u:
					hashCode = base.GetHashCode();
					num = (int)((num2 * 1842086425) ^ 0x100A426D);
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
		string result = "";
		while (true)
		{
			int num = 1663875077;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77CFB937u) % 3u)
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
				num = (int)((num2 * 751895912) ^ 0x7E73212A);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1234366132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23EBD405u) % 4u)
				{
				case 1u:
					result = "";
					num = ((int)num2 * -29315017) ^ -1358096630;
					continue;
				case 0u:
					num = ((int)num2 * -396589507) ^ 0x256F84BB;
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
