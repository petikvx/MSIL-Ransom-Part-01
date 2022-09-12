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
				int num = 2078546757;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77BD9627u) % 3u)
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
					num = (int)(num2 * 1210310085) ^ -1861029763;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -1340226421;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF71E59Eu) % 4u)
					{
					case 2u:
						Set(jSONArray);
						num = (int)(num2 * 1518826563) ^ -1211566377;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						jSONArray.Add(value);
						num = (int)(num2 * 839189951) ^ -432620941;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -397552035;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9E32696Du) % 3u)
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
					num = (int)((num2 * 2074009725) ^ 0x32CE4875);
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1171897550;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC82868E1u) % 5u)
					{
					case 3u:
						Set(jSONClass);
						num = (int)(num2 * 1200837782) ^ -511343841;
						continue;
					case 2u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 111508693) ^ 0x1B7BFD81);
						continue;
					case 1u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1431895004) ^ -880267961;
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			int result = default(int);
			while (true)
			{
				int num = -1615012684;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA39BEBDDu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1015270127) ^ 0x30B4E586);
						continue;
					case 1u:
						Set(aVal);
						result = 0;
						num = (int)(num2 * 126059584) ^ -840419626;
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
				int num = 1481495599;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7E241AD6u) % 3u)
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
					num = ((int)num2 * -854031172) ^ -642163226;
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
				int num = -1200154162;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB887D1EAu) % 5u)
					{
					case 2u:
						result = 0f;
						num = ((int)num2 * -763834000) ^ -1145016631;
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 791384608) ^ 0xD3F3D87);
						continue;
					case 0u:
						num = (int)(num2 * 1959634357) ^ -151099607;
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 1330356602;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E48AC9Du) % 4u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = ((int)num2 * -70557932) ^ 0x17EF3C0;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -523469868) ^ -256405553;
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = default(JSONData);
			double result = default(double);
			while (true)
			{
				int num = -995151270;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3585DF6u) % 5u)
					{
					case 3u:
						aVal = new JSONData(0.0);
						num = (int)((num2 * 251030210) ^ 0x79C33D35);
						continue;
					case 2u:
						Set(aVal);
						num = (int)(num2 * 1279894770) ^ -1684673877;
						continue;
					case 1u:
						result = 0.0;
						num = (int)((num2 * 1698159717) ^ 0x2E7D0C1B);
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
				int num = -1495597717;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC81D112Au) % 3u)
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
					num = (int)(num2 * 2050099713) ^ -977438353;
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
				int num = 1643992175;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BD1D4E6u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 41361374) ^ -1720041376;
						continue;
					case 1u:
						result = false;
						num = (int)((num2 * 1811894334) ^ 0x6FF248B7);
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
				int num = 1932568535;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E675548u) % 5u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1434602785) ^ -1727413967;
						continue;
					case 2u:
						Set(aVal);
						num = (int)(num2 * 629857565) ^ -1063529423;
						continue;
					case 1u:
						num = (int)((num2 * 769227796) ^ 0x3FEAB3AE);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1302644309;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52E21710u) % 6u)
					{
					case 4u:
						num = (int)((num2 * 2032695375) ^ 0x56E9D2CB);
						continue;
					case 3u:
						num = ((int)num2 * -1284971607) ^ 0x9889D19;
						continue;
					case 2u:
						result = jSONArray;
						num = (int)((num2 * 1130900856) ^ 0x53DED2EE);
						continue;
					case 1u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = ((int)num2 * -1648741664) ^ -488641103;
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
				int num = 2039177401;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42FCDD94u) % 6u)
					{
					case 5u:
						Set(jSONClass);
						num = ((int)num2 * -217699750) ^ 0x73FD4768;
						continue;
					case 2u:
						result = jSONClass;
						num = (int)(num2 * 1100674767) ^ -999167068;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -57370493) ^ 0x69E9B568;
						continue;
					case 0u:
						num = ((int)num2 * -275136994) ^ -1233097930;
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
		while (true)
		{
			int num = -376912114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90B898C3u) % 12u)
				{
				case 11u:
					m_Node.Add(aVal);
					num = (int)(num2 * 259896244) ^ -888665491;
					continue;
				case 10u:
					num = ((int)num2 * -1543486353) ^ -189692022;
					continue;
				case 8u:
					num = ((int)num2 * -167516438) ^ 0x2C65F098;
					continue;
				case 7u:
					num = (int)(num2 * 1787591194) ^ -1407634147;
					continue;
				case 6u:
					num = ((int)num2 * -424618291) ^ -749543618;
					continue;
				case 5u:
					num = -1174758571;
					continue;
				case 3u:
					m_Node = null;
					num = -1625185237;
					continue;
				case 2u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1052709969) ^ 0x66B48AF3;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = -648507900;
						num4 = -648507900;
					}
					else
					{
						num3 = -595035695;
						num4 = -595035695;
					}
					num = num3 ^ (int)(num2 * 1833862091);
					continue;
				}
				case 0u:
					num = ((int)num2 * -848192713) ^ 0x410B3C94;
					continue;
				default:
					return;
				case 9u:
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
		JSONArray jSONArray = new JSONArray();
		while (true)
		{
			int num = 377809614;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94D7146u) % 6u)
				{
				case 4u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -1213015983) ^ -1308475074;
					continue;
				case 2u:
					num = (int)((num2 * 433690299) ^ 0x40AFCC3E);
					continue;
				case 1u:
					num = ((int)num2 * -1004938814) ^ -291243579;
					continue;
				case 0u:
					Set(jSONArray);
					num = ((int)num2 * -1650732687) ^ 0xECCB6AF;
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
		while (true)
		{
			int num = -1851741342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x989F69F0u) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = (int)(num2 * 805356146) ^ -1241470223;
					continue;
				case 2u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -956017858) ^ -1809613012;
					continue;
				case 1u:
					num = (int)((num2 * 2055694468) ^ 0xE3D8CB6);
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = 1157266374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A0E751Fu) % 7u)
				{
				case 5u:
					result = true;
					num = ((int)num2 * -1503338601) ^ 0x4D3FBF3F;
					continue;
				case 3u:
					result = (object)a == b;
					num = 675439077;
					continue;
				case 2u:
					num = (int)((num2 * 222383166) ^ 0x50389A22);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2082060592;
						num4 = -2082060592;
					}
					else
					{
						num3 = -921227777;
						num4 = -921227777;
					}
					num = num3 ^ ((int)num2 * -1848079217);
					continue;
				}
				case 0u:
					num = ((int)num2 * -14213033) ^ -252773404;
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
			int num = 1377950225;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E0A3DE0u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1326029766) ^ -1195811614;
					continue;
				case 1u:
					result = !(a == b);
					num = (int)(num2 * 1288576056) ^ -309539909;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -530956142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB248ABE0u) % 7u)
				{
				case 6u:
					result = (object)this == obj;
					num = -1400899561;
					continue;
				case 4u:
					result = true;
					num = (int)((num2 * 281800538) ^ 0x650AB8A7);
					continue;
				case 3u:
					flag = obj == null;
					num = ((int)num2 * -264262020) ^ -1434194302;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1220890917;
						num4 = -1220890917;
					}
					else
					{
						num3 = -694062884;
						num4 = -694062884;
					}
					num = num3 ^ (int)(num2 * 1925490227);
					continue;
				}
				case 1u:
					num = ((int)num2 * -517892066) ^ 0x754A9F41;
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

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 1822174284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D1AFF8Bu) % 3u)
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
				num = ((int)num2 * -431996590) ^ 0x7B802538;
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = -562483793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED78C1D9u) % 3u)
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
				num = ((int)num2 * -969338055) ^ -407576415;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1447452491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FA3E472u) % 4u)
				{
				case 1u:
					result = "";
					num = (int)(num2 * 689693207) ^ -1982072459;
					continue;
				case 0u:
					num = ((int)num2 * -702796103) ^ -1134273124;
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
