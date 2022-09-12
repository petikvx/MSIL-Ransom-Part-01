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
				int num = -1421100446;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF668238u) % 3u)
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
					num = ((int)num2 * -1436049653) ^ 0x2BBAFEEF;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1451476716;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x26EE08E9u) % 4u)
					{
					case 2u:
						jSONArray.Add(value);
						Set(jSONArray);
						num = ((int)num2 * -1283816599) ^ -643241109;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1281308606) ^ 0x1A14E6C9;
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
			return new JSONLazyCreator(this, aKey);
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = -544984760;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA557A0B2u) % 3u)
					{
					case 2u:
						goto IL_0008;
					case 0u:
						break;
					default:
						Set(jSONClass);
						return;
					}
					break;
					IL_0008:
					jSONClass.Add(aKey, value);
					num = ((int)num2 * -1967109951) ^ -1800150885;
				}
			}
		}
	}

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = -1208257850;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5E2FD7Du) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						result = 0;
						num = ((int)num2 * -1645127223) ^ -367613722;
						continue;
					}
					case 0u:
						num = ((int)num2 * -166148210) ^ 0xD894DD8;
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
			Set(aVal);
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
				int num = 289157918;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x376606E4u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1760294945) ^ 0x579C4F1F;
						continue;
					case 4u:
						num = (int)((num2 * 651800752) ^ 0x3FBA0D06);
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 502019372) ^ 0x268B92DF);
						continue;
					case 1u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -202733618) ^ 0x3F5611BA;
						continue;
					case 0u:
						result = 0f;
						num = (int)((num2 * 446023601) ^ 0x54D6F35D);
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
			while (true)
			{
				int num = 1215635279;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B286437u) % 3u)
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
					num = ((int)num2 * -2049915422) ^ -1575234015;
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
				int num = 1117151450;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x75FB2A47u) % 4u)
					{
					case 1u:
						result = 0.0;
						num = (int)((num2 * 1970615356) ^ 0x3E088FBF);
						continue;
					case 0u:
						num = ((int)num2 * -777014144) ^ 0x18FD769C;
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
				int num = 1030440306;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x683C0215u) % 3u)
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
					num = (int)((num2 * 1657148893) ^ 0x378E4E44);
				}
			}
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
				int num = -57722838;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB792ECE1u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 373095193) ^ 0x29C4BADA);
						continue;
					case 0u:
						result = false;
						num = (int)((num2 * 1012399095) ^ 0x2EA82004);
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
				int num = -1465491072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x91B3D553u) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = (int)(num2 * 251813651) ^ -734433511;
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
				int num = 1312434847;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20DA5153u) % 6u)
					{
					case 5u:
						result = jSONArray;
						num = ((int)num2 * -1423884324) ^ -2035508993;
						continue;
					case 4u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 115318405) ^ -1120989076;
						continue;
					case 3u:
						Set(jSONArray);
						num = ((int)num2 * -734330710) ^ 0x739A64B2;
						continue;
					case 1u:
						num = ((int)num2 * -2070531157) ^ 0xCFE64E1;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -1238393191;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBAA49F5Cu) % 6u)
					{
					case 5u:
						num = (int)(num2 * 1969430122) ^ -525228855;
						continue;
					case 2u:
						num = ((int)num2 * -858823973) ^ -1678645586;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = ((int)num2 * -1118952315) ^ -445881201;
						continue;
					case 0u:
						result = jSONClass;
						num = (int)((num2 * 1202666730) ^ 0x62962D15);
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
			int num = -1185805439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1A2E3E0u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1027402358) ^ -309637779;
					continue;
				case 4u:
					m_Key = null;
					num = ((int)num2 * -2005259877) ^ -50135134;
					continue;
				case 1u:
					num = (int)((num2 * 814073218) ^ 0x2B5609A8);
					continue;
				case 0u:
					m_Node = aNode;
					num = (int)((num2 * 542142817) ^ 0x1123608E);
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -723732688;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7118636u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 422682225) ^ 0xAC97F45);
					continue;
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -1359291085) ^ -1026108567;
					continue;
				case 3u:
					break;
				default:
					m_Key = aKey;
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
			int num = -18295302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE258668u) % 11u)
				{
				case 10u:
					num = (int)((num2 * 967081434) ^ 0x220D3DF2);
					continue;
				case 9u:
					m_Node.Add(aVal);
					num = ((int)num2 * -663626010) ^ -509234741;
					continue;
				case 8u:
					num = (int)(num2 * 768530897) ^ -1125814828;
					continue;
				case 7u:
					num = (int)(num2 * 1022175656) ^ -1326505571;
					continue;
				case 6u:
					num = ((int)num2 * -1599939923) ^ -110419624;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -930835611;
						num4 = -930835611;
					}
					else
					{
						num3 = -1178520257;
						num4 = -1178520257;
					}
					num = num3 ^ (int)(num2 * 973063792);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1804073946) ^ -741495170;
					continue;
				case 2u:
					flag = m_Key == null;
					num = (int)(num2 * 1032830248) ^ -1186453438;
					continue;
				case 1u:
					m_Node.Add(m_Key, aVal);
					num = -1352215727;
					continue;
				case 0u:
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
			int num = 1723478690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA103324u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 1737133126) ^ -1378794215;
					continue;
				case 3u:
					num = (int)((num2 * 1578616110) ^ 0x71D21D5D);
					continue;
				case 2u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -900832358) ^ 0x754E3CDC;
					continue;
				case 1u:
					Set(jSONArray);
					num = ((int)num2 * -1244236908) ^ -1873737969;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 89038729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5AD8918Au) % 5u)
				{
				case 3u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1015020332) ^ -2128037447;
					continue;
				case 2u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1714142651) ^ -1477410202;
					continue;
				case 1u:
					Set(jSONClass);
					num = ((int)num2 * -1060010143) ^ -676191606;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		if (b == null)
		{
			goto IL_0006;
		}
		goto IL_003d;
		IL_003d:
		bool result = (object)a == b;
		int num = 873043416;
		goto IL_001c;
		IL_001c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x3AFADCDCu) % 4u)
			{
			case 3u:
				break;
			case 1u:
				result = true;
				num = ((int)num2 * -1381162099) ^ -2100720263;
				continue;
			case 2u:
				goto IL_003d;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = 393021113;
		goto IL_001c;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1308681307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x219EAE64u) % 3u)
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
				result = !(a == b);
				num = ((int)num2 * -2016170513) ^ -495496795;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = 1105252658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C550EA9u) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1828195656;
						num4 = -1828195656;
					}
					else
					{
						num3 = -1136070968;
						num4 = -1136070968;
					}
					num = num3 ^ ((int)num2 * -260572134);
					continue;
				}
				case 3u:
					result = true;
					num = ((int)num2 * -13053465) ^ -988374016;
					continue;
				case 1u:
					result = (object)this == obj;
					num = 1028450549;
					continue;
				case 0u:
					num = ((int)num2 * -275904131) ^ -1728548955;
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
			int num = -346052723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83DC5574u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -122347294) ^ -2104223742;
					continue;
				case 1u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -589711593) ^ 0x6AC9B1C;
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
			int num = 1987014678;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BC722CFu) % 4u)
				{
				case 1u:
					result = "";
					num = ((int)num2 * -1667318998) ^ 0x6BE08DE9;
					continue;
				case 0u:
					num = ((int)num2 * -109441384) ^ -686444867;
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1407093254;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F3B56B7u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1138333483) ^ -343252611;
					continue;
				case 1u:
					result = "";
					num = (int)((num2 * 179294336) ^ 0x7608EEF5);
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
