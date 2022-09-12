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
				int num = 101826532;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58B29135u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1843736100) ^ 0x2CCC0BB6);
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 2069142901) ^ 0x7EBE73CA);
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
				int num = 1625590451;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B479687u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1408873736) ^ -1673450001;
						continue;
					case 2u:
						Set(jSONArray);
						num = ((int)num2 * -1070653403) ^ -372291880;
						continue;
					case 1u:
						jSONArray.Add(value);
						num = ((int)num2 * -1827233520) ^ -70761937;
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
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 1217991281;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x468616B1u) % 3u)
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
					num = ((int)num2 * -73200837) ^ -1059307917;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -490015154;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFA7B453u) % 4u)
					{
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -682567658) ^ 0x473B0CF9;
						continue;
					case 0u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1488027146) ^ -251673707;
						continue;
					case 3u:
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
			JSONData aVal = new JSONData(0);
			int result = default(int);
			while (true)
			{
				int num = -1519731369;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA5938F4u) % 5u)
					{
					case 4u:
						result = 0;
						num = ((int)num2 * -802118409) ^ -130693539;
						continue;
					case 3u:
						num = (int)(num2 * 921263025) ^ -2032981090;
						continue;
					case 2u:
						Set(aVal);
						num = ((int)num2 * -234628836) ^ 0x739AF355;
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
				int num = 224447500;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40EEBEE5u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 1437883177) ^ -1218064868;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)((num2 * 2053339173) ^ 0x6005CF83);
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
			JSONData aVal = default(JSONData);
			float result = default(float);
			while (true)
			{
				int num = 1917314478;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x66FAA802u) % 5u)
					{
					case 3u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -1102044712) ^ -1958935660;
						continue;
					case 2u:
						num = ((int)num2 * -1074479162) ^ 0x7652A2FD;
						continue;
					case 1u:
						Set(aVal);
						result = 0f;
						num = (int)(num2 * 1529704625) ^ -1050299376;
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
				int num = 1500632612;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15E03672u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -1404229289) ^ -1590554051;
						continue;
					case 1u:
						num = ((int)num2 * -73786964) ^ 0x67EAE6A;
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
			double result = default(double);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -1381335836;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x907DB70Bu) % 7u)
					{
					case 5u:
						num = ((int)num2 * -397658928) ^ 0xA07A473;
						continue;
					case 4u:
						num = ((int)num2 * -720945949) ^ 0x37E97699;
						continue;
					case 3u:
						result = 0.0;
						num = ((int)num2 * -706360157) ^ -443779502;
						continue;
					case 2u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -2016214700) ^ -203647308;
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 1160481344) ^ 0x36C01DFB);
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
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 1768214169;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B98458Eu) % 4u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = (int)(num2 * 468630520) ^ -1624544825;
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 1704174815) ^ 0x377997B3);
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

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1391793219;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD96D4D09u) % 3u)
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
					JSONData aVal = new JSONData(aData: false);
					Set(aVal);
					result = false;
					num = ((int)num2 * -2085306608) ^ 0x54D4D14D;
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
			Set(jSONArray);
			JSONArray result = jSONArray;
			while (true)
			{
				int num = -2054196269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB10D32Bu) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					num = (int)((num2 * 359280117) ^ 0x6B55CBF);
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
				int num = -1739554048;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE885B01u) % 5u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -399970107) ^ 0x40677AF1;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -267784338) ^ -751123379;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 800873858) ^ 0xDFC2ED5);
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
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -683572253;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99F1DEDEu) % 5u)
				{
				case 4u:
					m_Node = aNode;
					num = (int)(num2 * 766831715) ^ -1969463813;
					continue;
				case 3u:
					num = ((int)num2 * -22970688) ^ 0xD2B2FAB;
					continue;
				case 1u:
					num = ((int)num2 * -1939593438) ^ 0x255708D9;
					continue;
				case 0u:
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
		bool flag = m_Key == null;
		while (true)
		{
			int num = 556948140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F0342BAu) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1355288905) ^ 0xC0C1492;
					continue;
				case 8u:
					num = ((int)num2 * -875816306) ^ -1294008219;
					continue;
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = 646986800;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1512289645;
						num4 = 1512289645;
					}
					else
					{
						num3 = 1014570315;
						num4 = 1014570315;
					}
					num = num3 ^ ((int)num2 * -820566633);
					continue;
				}
				case 5u:
					num = ((int)num2 * -840778088) ^ 0x541A2824;
					continue;
				case 2u:
					num = ((int)num2 * -1137995464) ^ -30716196;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = ((int)num2 * -949803390) ^ -102053458;
					continue;
				case 0u:
					m_Node = null;
					num = 1109544849;
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

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 1947129048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26DD9F4Fu) % 5u)
				{
				case 4u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -2083249046) ^ -2140975670;
					continue;
				case 3u:
					num = (int)((num2 * 662757827) ^ 0x3BDB4F72);
					continue;
				case 1u:
					Set(jSONArray);
					num = ((int)num2 * -812664382) ^ 0x2C86A504;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -168787169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92F604F5u) % 5u)
				{
				case 3u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1026077500) ^ -176279575;
					continue;
				case 2u:
					Set(jSONClass);
					num = (int)((num2 * 1546687816) ^ 0x5EF05597);
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -827618665) ^ 0x2AFF693E;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1566381534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF2E654Au) % 7u)
				{
				case 6u:
					num = (int)(num2 * 471093955) ^ -233920269;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1780198781;
						num4 = 1780198781;
					}
					else
					{
						num3 = 1445894765;
						num4 = 1445894765;
					}
					num = num3 ^ ((int)num2 * -1785774110);
					continue;
				}
				case 2u:
					result = (object)a == b;
					num = -10290150;
					continue;
				case 1u:
					flag = b == null;
					num = ((int)num2 * -1621198355) ^ -889169723;
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -364001661) ^ -419774798;
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
			int num = 91571419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68BD01E2u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2000576202) ^ -1808029010;
					continue;
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -2054192712) ^ 0x699C5241;
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
			int num = 723897723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x673B1FF8u) % 5u)
				{
				case 4u:
					result = true;
					num = (int)(num2 * 924956504) ^ -2057590407;
					continue;
				case 3u:
					result = (object)this == obj;
					num = 8243417;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 797600465;
						num4 = 797600465;
					}
					else
					{
						num3 = 813812985;
						num4 = 813812985;
					}
					num = num3 ^ (int)(num2 * 534186087);
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = -538668458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD853E598u) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0009:
				num = (int)((num2 * 1173462660) ^ 0x6CE6A1F6);
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = 235417670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A24C7FAu) % 3u)
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
				num = ((int)num2 * -1820357589) ^ -1490759013;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 2082174608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B561185u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1032185628) ^ -1758882131;
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -169294570) ^ 0x6548E1D4;
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
