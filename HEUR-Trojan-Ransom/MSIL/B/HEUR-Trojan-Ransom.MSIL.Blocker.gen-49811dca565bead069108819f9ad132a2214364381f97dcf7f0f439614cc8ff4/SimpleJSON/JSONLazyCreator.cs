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
				int num = 188017603;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x127A8411u) % 3u)
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
					num = ((int)num2 * -800074975) ^ 0x501BFBA4;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = 1060066069;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2310921Fu) % 4u)
					{
					case 2u:
						jSONArray.Add(value);
						num = ((int)num2 * -440001539) ^ -2049765264;
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)(num2 * 569753034) ^ -1210131539;
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
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -309805986;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96E58385u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1720415375) ^ -552628773;
						continue;
					case 4u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 1782966671) ^ -500793668;
						continue;
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -1163344620) ^ 0x65FD0C29;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -892817940) ^ -1732691685;
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

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 52179721;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FCDD537u) % 4u)
					{
					case 3u:
						result = 0;
						num = (int)((num2 * 696875193) ^ 0x6DAD2E3D);
						continue;
					case 2u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = ((int)num2 * -203697869) ^ 0x32F4F2DA;
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
		set
		{
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 1824609183;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x61998C38u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 605076193) ^ 0x40455424);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -485161291) ^ -1810233256;
						continue;
					case 0u:
						num = ((int)num2 * -1885695940) ^ 0x625FAD8F;
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
	}

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			float result = default(float);
			while (true)
			{
				int num = 572685259;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13BF6CA1u) % 6u)
					{
					case 4u:
						result = 0f;
						num = (int)(num2 * 176098873) ^ -322068595;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1328095213) ^ 0x5BA8C758);
						continue;
					case 1u:
						num = (int)(num2 * 452372175) ^ -24779400;
						continue;
					case 0u:
						num = ((int)num2 * -1786498684) ^ 0xF97828A;
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
				int num = -1405276895;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x880CFFB1u) % 3u)
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
					num = ((int)num2 * -1569585584) ^ -1760856394;
				}
			}
		}
	}

	public override double AsDouble
	{
		get
		{
			JSONData aVal = default(JSONData);
			double result = default(double);
			while (true)
			{
				int num = -923189164;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE41FCA9u) % 6u)
					{
					case 4u:
						Set(aVal);
						num = ((int)num2 * -762648359) ^ 0x75A41D9A;
						continue;
					case 3u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1143058163) ^ -790287710;
						continue;
					case 2u:
						num = (int)(num2 * 1963009409) ^ -1346105446;
						continue;
					case 1u:
						result = 0.0;
						num = (int)((num2 * 478903369) ^ 0x4C2B2016);
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
				int num = 1340535471;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x255C893Fu) % 3u)
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
					num = ((int)num2 * -330264667) ^ 0x58BFB55;
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
				int num = -1415197807;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE576F5F6u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 43249612) ^ 0x4BF45434);
						continue;
					case 4u:
						result = false;
						num = (int)(num2 * 551870270) ^ -1654412835;
						continue;
					case 2u:
						num = (int)((num2 * 256571835) ^ 0x1307D4CE);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -802871716) ^ -1798544386;
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -598715036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE4CB3805u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -1930833817) ^ 0xBB8ACFA;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1196743927) ^ -2040323737;
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 822706681;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B74C483u) % 5u)
					{
					case 2u:
						Set(jSONArray);
						result = jSONArray;
						num = ((int)num2 * -1716628450) ^ 0x3AA737D3;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1477721875) ^ 0x75A51AAE;
						continue;
					case 0u:
						num = (int)(num2 * 361602170) ^ -154440770;
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
				int num = 865952342;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4920531Du) % 7u)
					{
					case 5u:
						num = ((int)num2 * -1209637787) ^ 0x7D23D47B;
						continue;
					case 3u:
						Set(jSONClass);
						num = (int)((num2 * 1646276416) ^ 0x3F81C5F2);
						continue;
					case 2u:
						num = ((int)num2 * -615617670) ^ -639784720;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)(num2 * 863801620) ^ -4829948;
						continue;
					case 0u:
						result = jSONClass;
						num = (int)((num2 * 798767370) ^ 0x96982F4);
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
			int num = 669298838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EF417FEu) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 0u:
					break;
				default:
					m_Key = aKey;
					return;
				}
				break;
				IL_0016:
				m_Node = aNode;
				num = ((int)num2 * -855661657) ^ 0x328891C7;
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = -1536576703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9DC8D93u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -892356705) ^ -2030151047;
					continue;
				case 8u:
					num = ((int)num2 * -1524790535) ^ 0x48123FB3;
					continue;
				case 7u:
					m_Node = null;
					num = -1444296621;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = 583329582;
						num4 = 583329582;
					}
					else
					{
						num3 = 21551853;
						num4 = 21551853;
					}
					num = num3 ^ ((int)num2 * -849937815);
					continue;
				}
				case 5u:
					num = ((int)num2 * -832681710) ^ 0x3F397FC0;
					continue;
				case 2u:
					num = (int)((num2 * 1627120019) ^ 0x40E92DF6);
					continue;
				case 1u:
					m_Node.Add(m_Key, aVal);
					num = -1677404190;
					continue;
				case 0u:
					m_Node.Add(aVal);
					num = ((int)num2 * -261147477) ^ 0x4A597597;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
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
			int num = 1797025865;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A1FF9B5u) % 5u)
				{
				case 3u:
					Set(jSONArray);
					num = ((int)num2 * -1369103627) ^ 0x3A35BAB6;
					continue;
				case 2u:
					num = ((int)num2 * -2054162100) ^ -775633699;
					continue;
				case 1u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -2104320954) ^ 0x1DCBEC96;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1867977291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1CC2F78u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 841200737) ^ 0x4A2CCFA9);
					continue;
				case 4u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1655606694) ^ 0xC98F542);
					continue;
				case 2u:
					num = ((int)num2 * -1235308429) ^ 0x3BAAA547;
					continue;
				case 1u:
					Set(jSONClass);
					num = ((int)num2 * -185180529) ^ -1203881453;
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1363796915) ^ -2112669883;
					continue;
				default:
					return;
				case 6u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = 271529553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A154489u) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1672341441;
						num4 = 1672341441;
					}
					else
					{
						num3 = 1393858744;
						num4 = 1393858744;
					}
					num = num3 ^ (int)(num2 * 1881597149);
					continue;
				}
				case 3u:
					result = (object)a == b;
					num = 123394514;
					continue;
				case 1u:
					num = (int)(num2 * 982822902) ^ -573888789;
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -936237563) ^ 0x701FAF69;
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
			int num = 172273198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39D253DBu) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = (int)(num2 * 408768652) ^ -1269635205;
					continue;
				case 0u:
					num = (int)((num2 * 1254862790) ^ 0x27C8F5E5);
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
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = 1016311861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33F42B1Cu) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1053390030;
						num4 = -1053390030;
					}
					else
					{
						num3 = -435768104;
						num4 = -435768104;
					}
					num = num3 ^ ((int)num2 * -21321536);
					continue;
				}
				case 4u:
					result = (object)this == obj;
					num = 1584991736;
					continue;
				case 2u:
					result = true;
					num = (int)(num2 * 933795145) ^ -1241754279;
					continue;
				case 0u:
					num = (int)((num2 * 571466198) ^ 0x75DC85E5);
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

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 827151220;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EBDE857u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0003:
				hashCode = base.GetHashCode();
				num = (int)((num2 * 1641046489) ^ 0x56367428);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1246598901;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0A6CE9Bu) % 3u)
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
				result = "";
				num = (int)(num2 * 115128738) ^ -1343480683;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -721326422;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA13B9A9Fu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 515792306) ^ 0x458F5F8B);
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -469924760) ^ 0x4B6FF488;
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
