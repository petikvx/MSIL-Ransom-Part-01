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
				int num = 486622132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73484DEDu) % 3u)
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
					result = new JSONLazyCreator(this);
					num = ((int)num2 * -524299573) ^ -808786209;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 631943107;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13496230u) % 6u)
					{
					case 4u:
						Set(jSONArray);
						num = ((int)num2 * -1287369513) ^ -1324859167;
						continue;
					case 3u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1243103977) ^ -1527878718;
						continue;
					case 2u:
						num = (int)(num2 * 909709257) ^ -1326677852;
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -259886796) ^ -222447952;
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
			return new JSONLazyCreator(this, aKey);
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 517938487;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x43CA1AAEu) % 4u)
					{
					case 3u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1620677136) ^ 0x5AA52690;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 719321174) ^ 0x65CFE3C3);
						continue;
					case 0u:
						break;
					default:
						Set(jSONClass);
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
				int num = -521653263;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82F58AB4u) % 6u)
					{
					case 4u:
						num = (int)(num2 * 1645515624) ^ -203275488;
						continue;
					case 3u:
						aVal = new JSONData(0);
						num = (int)(num2 * 716298203) ^ -1767919488;
						continue;
					case 2u:
						result = 0;
						num = (int)((num2 * 739305698) ^ 0x2B740CC7);
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -577847485) ^ 0x4E219D23;
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
			float result = default(float);
			while (true)
			{
				int num = -582415409;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99F8976Fu) % 5u)
					{
					case 4u:
						num = ((int)num2 * -82239601) ^ -745850331;
						continue;
					case 2u:
						result = 0f;
						num = ((int)num2 * -1751837910) ^ -111440661;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = (int)(num2 * 1439925417) ^ -1306655473;
						continue;
					}
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
				int num = 1185113535;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57035A54u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = ((int)num2 * -1575201682) ^ -1735438378;
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
				int num = -2065542827;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD5AEA192u) % 5u)
					{
					case 2u:
						result = 0.0;
						num = ((int)num2 * -1012173049) ^ -1553575568;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = ((int)num2 * -960865461) ^ -193891355;
						continue;
					}
					case 0u:
						num = ((int)num2 * -342951618) ^ -2044162650;
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
			while (true)
			{
				int num = 1621575698;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CE5F8FFu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1198959199) ^ -1431937566;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)(num2 * 609953861) ^ -1609318975;
						continue;
					}
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

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -1152817117;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF86679D6u) % 6u)
					{
					case 5u:
						result = false;
						num = (int)(num2 * 1281462145) ^ -1086766217;
						continue;
					case 4u:
						num = ((int)num2 * -2015485083) ^ -1507806137;
						continue;
					case 3u:
						Set(aVal);
						num = (int)((num2 * 1540744887) ^ 0x30BB5C7F);
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = (int)(num2 * 1341909130) ^ -201351071;
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
			while (true)
			{
				int num = -1601908097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D061814u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = (int)(num2 * 61937028) ^ -1226446129;
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
				int num = -1276141497;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA76BC764u) % 6u)
					{
					case 5u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1346190466) ^ -472208036;
						continue;
					case 4u:
						num = (int)(num2 * 917443235) ^ -2047660659;
						continue;
					case 2u:
						Set(jSONArray);
						num = ((int)num2 * -1145237454) ^ -516528670;
						continue;
					case 0u:
						result = jSONArray;
						num = ((int)num2 * -196654835) ^ -643282876;
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
				int num = 2059311101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x323B0758u) % 6u)
					{
					case 4u:
						num = ((int)num2 * -27181555) ^ -1517430066;
						continue;
					case 3u:
						num = ((int)num2 * -2132040077) ^ -1490579994;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -203686177) ^ -2145464509;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = ((int)num2 * -751363070) ^ 0x706DDFBC;
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
			int num = -78177892;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6F02585u) % 4u)
				{
				case 2u:
					m_Node = aNode;
					m_Key = null;
					num = ((int)num2 * -1504713049) ^ 0x5AE88408;
					continue;
				case 1u:
					num = (int)(num2 * 1330188268) ^ -712239877;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 298317314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40EDA04Au) % 5u)
				{
				case 3u:
					m_Node = aNode;
					m_Key = aKey;
					num = ((int)num2 * -1727094411) ^ -1034669202;
					continue;
				case 1u:
					num = ((int)num2 * -425442022) ^ -1038590934;
					continue;
				case 0u:
					num = (int)((num2 * 688401954) ^ 0x172708ED);
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

	private void Set(JSONNode aVal)
	{
		bool flag = m_Key == null;
		while (true)
		{
			int num = -383711447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5B86EB2u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1543252498) ^ 0x42C63FE1);
					continue;
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = -1651336589;
					continue;
				case 6u:
					num = ((int)num2 * -589072635) ^ 0x7A49472A;
					continue;
				case 4u:
					num = ((int)num2 * -1567858793) ^ 0x4400F71E;
					continue;
				case 3u:
					num = ((int)num2 * -1729316574) ^ -610716043;
					continue;
				case 2u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1980981521) ^ 0x4A61B6F4;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -589729083;
						num4 = -589729083;
					}
					else
					{
						num3 = -1268801362;
						num4 = -1268801362;
					}
					num = num3 ^ ((int)num2 * -741688878);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1734788204) ^ -1331125477;
					continue;
				case 8u:
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
			int num = 261363473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D1CFFECu) % 4u)
				{
				case 3u:
					Set(jSONArray);
					num = ((int)num2 * -88113789) ^ -1626601475;
					continue;
				case 1u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = (int)((num2 * 1512456160) ^ 0x460F883B);
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = 1043216267;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12B961A8u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				jSONClass.Add(aKey, aItem);
				Set(jSONClass);
				num = ((int)num2 * -134724313) ^ -1994296933;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -628021214;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD03F2DD3u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -873308670) ^ -1876215621;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -133833054) ^ -1605462896;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (b == null)
					{
						num3 = -76594171;
						num4 = -76594171;
					}
					else
					{
						num3 = -1079529406;
						num4 = -1079529406;
					}
					num = num3 ^ ((int)num2 * -387683397);
					continue;
				}
				case 0u:
					result = (object)a == b;
					num = -613641335;
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
		bool result = default(bool);
		while (true)
		{
			int num = 1375406020;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FA4F7D9u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1670633061) ^ -655732942;
					continue;
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -75681900) ^ 0x327640CE;
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
		bool result = default(bool);
		while (true)
		{
			int num = 1614278663;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A1943A1u) % 6u)
				{
				case 5u:
					result = true;
					num = (int)((num2 * 663387735) ^ 0x7D274A72);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (obj != null)
					{
						num3 = 1664365512;
						num4 = 1664365512;
					}
					else
					{
						num3 = 76610252;
						num4 = 76610252;
					}
					num = num3 ^ ((int)num2 * -1688875603);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1285813118) ^ -253274891;
					continue;
				case 1u:
					result = (object)this == obj;
					num = 1720839488;
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
			int num = 1360434453;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E5ECCB3u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0003:
				hashCode = base.GetHashCode();
				num = ((int)num2 * -2016832924) ^ 0x9505329;
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = -988729393;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7B76A32u) % 3u)
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
				num = (int)((num2 * 2113993272) ^ 0x347104D0);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 748819677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E3A4A8Cu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 111894226) ^ -1269203862;
					continue;
				case 1u:
					result = "";
					num = (int)((num2 * 650156107) ^ 0x49CF5CA8);
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
