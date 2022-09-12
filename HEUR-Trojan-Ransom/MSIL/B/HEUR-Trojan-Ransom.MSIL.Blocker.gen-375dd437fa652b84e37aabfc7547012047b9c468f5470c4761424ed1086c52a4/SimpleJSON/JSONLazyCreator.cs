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
				int num = 277617335;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4CED9106u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 1257202934) ^ 0x3AE6C1DD);
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -1928279029;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA99680Eu) % 7u)
					{
					case 6u:
						num = (int)(num2 * 1500392329) ^ -291704087;
						continue;
					case 4u:
						num = ((int)num2 * -1367445008) ^ -642057340;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = (int)((num2 * 343804155) ^ 0x3E219234);
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -1757345244) ^ -2029652390;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)((num2 * 76923085) ^ 0x4C5A8131);
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
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -254412929;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x886E112Eu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1698951183) ^ -2082844227;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = (int)(num2 * 766005543) ^ -385818010;
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
			while (true)
			{
				int num = 1236999943;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x65E9A6EEu) % 4u)
					{
					case 1u:
						Set(jSONClass);
						num = (int)((num2 * 710276313) ^ 0x2E3A10DF);
						continue;
					case 0u:
						num = (int)((num2 * 49184978) ^ 0x1B3421C5);
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
			JSONData aVal = new JSONData(0);
			Set(aVal);
			int result = default(int);
			while (true)
			{
				int num = 724365867;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41C39268u) % 4u)
					{
					case 3u:
						result = 0;
						num = ((int)num2 * -745620544) ^ -1889915295;
						continue;
					case 1u:
						num = (int)(num2 * 881359272) ^ -1696119038;
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
				int num = -2079562330;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE571733Fu) % 5u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -331607645) ^ 0x4954BFCD;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = ((int)num2 * -651818301) ^ -146279482;
						continue;
					case 1u:
						num = (int)(num2 * 1692433394) ^ -297080745;
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
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
				int num = -2110991842;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5E10C47u) % 6u)
					{
					case 4u:
						num = (int)(num2 * 2015158857) ^ -1045679;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -2053170961) ^ -1476794112;
						continue;
					case 1u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 1128888363) ^ 0x471C32C9);
						continue;
					case 0u:
						result = 0f;
						num = (int)((num2 * 1770960394) ^ 0x23A5BEFF);
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
		set
		{
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = 2115791353;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15EE9ECCu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 189967638) ^ -1569753558;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -306542277) ^ -433965484;
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			double result = 0.0;
			while (true)
			{
				int num = 559938904;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x140F1273u) % 3u)
					{
					case 1u:
						goto IL_0022;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0022:
					num = (int)(num2 * 599718988) ^ -1755269724;
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
				int num = 1831755921;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57DCECE0u) % 5u)
					{
					case 4u:
						result = false;
						num = (int)((num2 * 926223030) ^ 0x5D3E1E2E);
						continue;
					case 3u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -1486594585) ^ -1606618409;
						continue;
					}
					case 1u:
						num = ((int)num2 * -1181367017) ^ 0x31A205B1;
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
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = -233098534;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0C544D8u) % 3u)
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
					num = (int)(num2 * 220681785) ^ -331992506;
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
				int num = 1790654103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x51162D34u) % 6u)
					{
					case 5u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -262714207) ^ 0x4FA4A716;
						continue;
					case 3u:
						result = jSONArray;
						num = ((int)num2 * -1090955426) ^ 0x61650742;
						continue;
					case 1u:
						Set(jSONArray);
						num = ((int)num2 * -15009285) ^ -39807231;
						continue;
					case 0u:
						num = ((int)num2 * -1103972389) ^ 0xAD587F1;
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
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 1458618980;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A8FC50Fu) % 4u)
					{
					case 3u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 1272336798) ^ 0x2E5FBBCB);
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -1433219983) ^ -1381219476;
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
			int num = -878627224;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA0BBFCFu) % 5u)
				{
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -1549289098) ^ 0x63473469;
					continue;
				case 2u:
					m_Key = null;
					num = (int)((num2 * 201215073) ^ 0x7E34F73E);
					continue;
				case 1u:
					num = ((int)num2 * -102125359) ^ 0x7DF46B25;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -1831121148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF643707u) % 5u)
				{
				case 3u:
					m_Node = aNode;
					num = (int)((num2 * 1273589691) ^ 0x2C929729);
					continue;
				case 1u:
					num = ((int)num2 * -1515139108) ^ -1388169253;
					continue;
				case 0u:
					m_Key = aKey;
					num = (int)(num2 * 354339141) ^ -896489534;
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
			int num = 1516156591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59065E35u) % 10u)
				{
				case 9u:
					num = 657307234;
					continue;
				case 8u:
					num = ((int)num2 * -1494730489) ^ -1747793713;
					continue;
				case 7u:
					num = (int)(num2 * 1983786443) ^ -238437062;
					continue;
				case 5u:
					num = (int)(num2 * 578034447) ^ -968107504;
					continue;
				case 4u:
					m_Node.Add(aVal);
					num = (int)((num2 * 2040461860) ^ 0x7B217F4A);
					continue;
				case 3u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1303749172) ^ 0x8409AB4;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -441596622;
						num4 = -441596622;
					}
					else
					{
						num3 = -847984849;
						num4 = -847984849;
					}
					num = num3 ^ (int)(num2 * 15998727);
					continue;
				}
				case 1u:
					num = (int)((num2 * 1080361609) ^ 0x20A1E27);
					continue;
				case 6u:
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
			int num = 1961986003;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29063B0Du) % 4u)
				{
				case 2u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = (int)(num2 * 1270276158) ^ -470942972;
					continue;
				case 1u:
					num = ((int)num2 * -1074062077) ^ -723318174;
					continue;
				case 3u:
					break;
				default:
					Set(jSONArray);
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
			int num = -1746810281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x901A9D3Au) % 3u)
				{
				case 1u:
					goto IL_0010;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0010:
				Set(jSONClass);
				num = (int)(num2 * 59925151) ^ -1378738510;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = -218484300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACB2CADEu) % 7u)
				{
				case 5u:
					num = (int)((num2 * 606971747) ^ 0x5F4D3506);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -893135845;
						num4 = -893135845;
					}
					else
					{
						num3 = -1200666673;
						num4 = -1200666673;
					}
					num = num3 ^ (int)(num2 * 257874186);
					continue;
				}
				case 3u:
					result = true;
					num = ((int)num2 * -1901154001) ^ 0x387F3152;
					continue;
				case 2u:
					result = (object)a == b;
					num = -2004086398;
					continue;
				case 1u:
					num = ((int)num2 * -1219825628) ^ -23563105;
					continue;
				case 6u:
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
			int num = 1176055939;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B3A4DCAu) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = (int)(num2 * 1094708448) ^ -1940756018;
					continue;
				case 0u:
					num = ((int)num2 * -707251269) ^ -971983239;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1428577044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35C70ED5u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1991855297) ^ -1946455147;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1071999942;
						num4 = -1071999942;
					}
					else
					{
						num3 = -947248377;
						num4 = -947248377;
					}
					num = num3 ^ ((int)num2 * -439692323);
					continue;
				}
				case 3u:
					result = true;
					num = ((int)num2 * -1256510134) ^ -1744913867;
					continue;
				case 1u:
					flag = obj == null;
					num = ((int)num2 * -1641531508) ^ -1283719518;
					continue;
				case 0u:
					result = (object)this == obj;
					num = 1829742645;
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
			int num = 1707766600;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C1AD3A2u) % 3u)
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
				num = (int)((num2 * 2063859622) ^ 0x789AE09B);
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
			int num = -1902100714;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E0AE9B5u) % 3u)
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
				num = ((int)num2 * -694373093) ^ 0x8EE88FE;
			}
		}
	}
}
