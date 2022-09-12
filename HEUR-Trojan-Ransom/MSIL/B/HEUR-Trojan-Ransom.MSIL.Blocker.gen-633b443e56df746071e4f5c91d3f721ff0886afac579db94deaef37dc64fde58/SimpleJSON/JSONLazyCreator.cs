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
				int num = 1744006464;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7ADB9AC3u) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 101288480) ^ -1085104481;
						continue;
					case 0u:
						num = ((int)num2 * -1972314985) ^ -744883566;
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
				int num = -2006090905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F0A35DAu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1117286697) ^ 0x1981A48C;
						continue;
					case 5u:
						jSONArray.Add(value);
						num = (int)(num2 * 644197549) ^ -2015338983;
						continue;
					case 4u:
						Set(jSONArray);
						num = ((int)num2 * -2067005235) ^ -829009008;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1040225520) ^ 0x1D3C368E;
						continue;
					case 1u:
						num = (int)(num2 * 1459073609) ^ -354128053;
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
				int num = -1085896703;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF82210CBu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1024071139) ^ 0x3AE3C2D5;
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = (int)(num2 * 1276723978) ^ -165478148;
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
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 884579581;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36ACEA21u) % 5u)
					{
					case 4u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1381720551) ^ -137534518;
						continue;
					case 2u:
						Set(jSONClass);
						num = ((int)num2 * -305135041) ^ 0x6CC7DFBD;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -959601240) ^ -548167817;
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = 746357444;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A530C9Au) % 5u)
					{
					case 4u:
						Set(aVal);
						result = 0;
						num = ((int)num2 * -2030012244) ^ 0x1E46BEDC;
						continue;
					case 3u:
						aVal = new JSONData(0);
						num = (int)(num2 * 97932114) ^ -962600100;
						continue;
					case 2u:
						num = ((int)num2 * -1625411280) ^ 0x19EB97C9;
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
				int num = 921322789;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x10B5C9C8u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 235844559) ^ -2100177825;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1752707821) ^ 0x2705D2DC;
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
				int num = 1256946959;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19A82F88u) % 4u)
					{
					case 3u:
						result = 0f;
						num = ((int)num2 * -213787080) ^ -728432268;
						continue;
					case 0u:
						num = ((int)num2 * -759630352) ^ 0x58674B71;
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 281624966;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FF740E9u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -2145868760) ^ 0x229D0FD4;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = (int)(num2 * 523735511) ^ -1438365119;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 525255570) ^ -1821309112;
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
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			double result = default(double);
			while (true)
			{
				int num = 224483364;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E758105u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1426196506) ^ -1614637083;
						continue;
					case 1u:
						result = 0.0;
						num = (int)((num2 * 1324052970) ^ 0x7C0AA1A8);
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
				int num = -1935917089;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE813D8Eu) % 3u)
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
					num = (int)((num2 * 1625515582) ^ 0x20480D8F);
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
				int num = -122663056;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB829EE59u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -606134771) ^ 0x16EC5794;
						continue;
					case 1u:
						Set(aVal);
						result = false;
						num = ((int)num2 * -1575929635) ^ -1715307509;
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
			while (true)
			{
				int num = -1751041594;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF5A03885u) % 3u)
					{
					case 2u:
						goto IL_0010;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0010:
					num = ((int)num2 * -1835601217) ^ -1741228440;
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
				int num = 577345581;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x59E03978u) % 6u)
					{
					case 5u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = (int)((num2 * 567330907) ^ 0x313E09F3);
						continue;
					case 4u:
						result = jSONArray;
						num = ((int)num2 * -1323435401) ^ 0x67B18FC3;
						continue;
					case 1u:
						num = (int)(num2 * 1689246581) ^ -702794646;
						continue;
					case 0u:
						num = (int)(num2 * 456718754) ^ -1491668492;
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
				int num = 1064979542;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F268301u) % 6u)
					{
					case 5u:
						Set(jSONClass);
						num = (int)(num2 * 388085230) ^ -904520594;
						continue;
					case 4u:
						num = (int)(num2 * 169331121) ^ -2143641491;
						continue;
					case 3u:
						num = ((int)num2 * -1798986859) ^ -1438954607;
						continue;
					case 1u:
						result = jSONClass;
						num = (int)(num2 * 265349441) ^ -2080428158;
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
			int num = -707613585;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8A0A57Cu) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1282492794) ^ -2019750848;
					continue;
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -1762450229) ^ 0x6028C2FD;
					continue;
				case 3u:
					m_Key = null;
					num = ((int)num2 * -1167543689) ^ -1124746016;
					continue;
				case 2u:
					num = ((int)num2 * -123423678) ^ 0x66B61430;
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
			int num = -494074007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EA20030u) % 10u)
				{
				case 9u:
					num = (int)(num2 * 199668439) ^ -654690753;
					continue;
				case 7u:
					m_Node.Add(aVal);
					num = (int)((num2 * 1171919375) ^ 0x479DC163);
					continue;
				case 6u:
					num = ((int)num2 * -84264971) ^ -1189669260;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1108809846;
						num4 = -1108809846;
					}
					else
					{
						num3 = -1769068873;
						num4 = -1769068873;
					}
					num = num3 ^ (int)(num2 * 1325208391);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1772713541) ^ -1115185558;
					continue;
				case 2u:
					m_Node.Add(m_Key, aVal);
					num = -515554567;
					continue;
				case 1u:
					flag = m_Key == null;
					num = ((int)num2 * -1647294731) ^ 0x3A5D4F0C;
					continue;
				case 0u:
					num = (int)((num2 * 87604472) ^ 0x34E978C0);
					continue;
				case 4u:
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
			int num = -564480315;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90905152u) % 6u)
				{
				case 5u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -308696989) ^ 0xA8761E4;
					continue;
				case 4u:
					Set(jSONArray);
					num = (int)(num2 * 957007513) ^ -765978226;
					continue;
				case 3u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -2089624169) ^ 0x649F6D79;
					continue;
				case 2u:
					num = (int)((num2 * 938143195) ^ 0x49D173A9);
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
			int num = -6998069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB09C659Au) % 3u)
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
				num = (int)(num2 * 1096501354) ^ -898980747;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 893333980;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4DEF2538u) % 7u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (b == null)
					{
						num3 = -2044007027;
						num4 = -2044007027;
					}
					else
					{
						num3 = -623958410;
						num4 = -623958410;
					}
					num = num3 ^ ((int)num2 * -1555368879);
					continue;
				}
				case 3u:
					result = true;
					num = (int)(num2 * 901472383) ^ -856696765;
					continue;
				case 2u:
					result = (object)a == b;
					num = 1451654989;
					continue;
				case 1u:
					num = (int)((num2 * 136204633) ^ 0x6CFA52D6);
					continue;
				case 0u:
					num = (int)(num2 * 1922002330) ^ -1669546816;
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
		bool result = default(bool);
		while (true)
		{
			int num = -1238067592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3C62DD5u) % 3u)
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
				num = (int)((num2 * 1809345458) ^ 0x1E777EB);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -595590153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5985133u) % 6u)
				{
				case 5u:
					result = true;
					num = ((int)num2 * -288421191) ^ 0x42ABA6B5;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 764930513;
						num4 = 764930513;
					}
					else
					{
						num3 = 544799566;
						num4 = 544799566;
					}
					num = num3 ^ (int)(num2 * 782307502);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1809870666) ^ -907150802;
					continue;
				case 0u:
					result = (object)this == obj;
					num = -2076388886;
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
			int num = 1147945355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BAE5D00u) % 4u)
				{
				case 3u:
					hashCode = base.GetHashCode();
					num = (int)(num2 * 1262272920) ^ -845187434;
					continue;
				case 2u:
					num = ((int)num2 * -1148437143) ^ 0x42B7EEEB;
					continue;
				case 0u:
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
			int num = 1930441793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x55896B39u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = (int)((num2 * 253241122) ^ 0x75DBB7FD);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1646967616;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86559116u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1349248541) ^ 0x229F2CF6;
					continue;
				case 2u:
					result = "";
					num = (int)((num2 * 252665377) ^ 0x7475D73F);
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
