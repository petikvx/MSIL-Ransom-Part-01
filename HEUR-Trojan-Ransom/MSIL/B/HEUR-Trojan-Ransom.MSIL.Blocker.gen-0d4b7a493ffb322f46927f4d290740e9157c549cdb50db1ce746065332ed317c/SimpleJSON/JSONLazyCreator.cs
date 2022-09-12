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
				int num = 1230218656;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C4215u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1809495406) ^ 0x6DB0AFB1);
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -719048938) ^ 0x36C47DE8;
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
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 205609832;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E7B3D64u) % 6u)
					{
					case 5u:
						jSONArray.Add(value);
						num = ((int)num2 * -1871981825) ^ 0x2C68950A;
						continue;
					case 4u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -963437211) ^ -31546877;
						continue;
					case 3u:
						num = (int)((num2 * 1422530600) ^ 0x1C321CC9);
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)((num2 * 423345047) ^ 0x42B40985);
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
				int num = 1832953310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E619BDDu) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = (int)((num2 * 1879747416) ^ 0x3EA2FF14);
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1978012762;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x272A3399u) % 6u)
					{
					case 5u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1309683595) ^ -1485731118;
						continue;
					case 4u:
						num = (int)((num2 * 1623763186) ^ 0x4141CC9F);
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -580098538) ^ -679996846;
						continue;
					case 0u:
						Set(jSONClass);
						num = ((int)num2 * -1060259829) ^ 0x7AB41BA9;
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = -521581870;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC02CACA2u) % 5u)
					{
					case 3u:
						num = ((int)num2 * -411554393) ^ 0x61898A48;
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = ((int)num2 * -1830034760) ^ 0x5FB401E6;
						continue;
					case 0u:
						Set(aVal);
						result = 0;
						num = (int)((num2 * 41993679) ^ 0x4E8760C3);
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
				int num = 23529047;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1CB0F3u) % 5u)
					{
					case 4u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -795570711) ^ -1104565944;
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -886185094) ^ -1681502253;
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -1661501814) ^ -1417078622;
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
				int num = 968978074;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C03DABu) % 4u)
					{
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -397546471) ^ -896456866;
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 1545864122) ^ 0x44687721);
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

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = 2134226340;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8CA323Fu) % 5u)
					{
					case 4u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = ((int)num2 * -1345108153) ^ -768881818;
						continue;
					}
					case 3u:
						num = (int)(num2 * 494901559) ^ -1794402066;
						continue;
					case 2u:
						result = 0.0;
						num = (int)(num2 * 1530442864) ^ -733854611;
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
				int num = 313521576;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D5D980Fu) % 3u)
					{
					case 1u:
						goto IL_0010;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0010:
					num = (int)((num2 * 688838717) ^ 0x65B40116);
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
				int num = -2019691122;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90EC559Fu) % 4u)
					{
					case 3u:
						result = false;
						num = ((int)num2 * -1687088893) ^ 0x7B0147E4;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -1126346367) ^ -1326230259;
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
			while (true)
			{
				int num = -1678079880;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF231D9BFu) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)((num2 * 1966813788) ^ 0xCB98A32);
						continue;
					}
					case 1u:
						num = (int)((num2 * 350831720) ^ 0x7B54A45D);
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
				int num = -1075336600;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD92FD98u) % 5u)
					{
					case 3u:
						num = (int)((num2 * 188293696) ^ 0x46C24F1C);
						continue;
					case 1u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = ((int)num2 * -707284367) ^ -965666126;
						continue;
					case 0u:
						result = jSONArray;
						num = ((int)num2 * -1414203361) ^ 0x5F379EFD;
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
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1619174794;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x157D837Cu) % 5u)
					{
					case 4u:
						num = ((int)num2 * -967224980) ^ 0x50EF2591;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -981291081) ^ -1951270705;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 1036846524) ^ 0x6BC5CA9B);
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
		while (true)
		{
			int num = -909639993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9150EECFu) % 6u)
				{
				case 4u:
					m_Key = null;
					num = ((int)num2 * -1575964812) ^ 0x667E819F;
					continue;
				case 3u:
					m_Node = aNode;
					num = ((int)num2 * -1768737982) ^ 0xB41BFB5;
					continue;
				case 2u:
					num = ((int)num2 * -115773858) ^ 0x4CE41622;
					continue;
				case 1u:
					num = (int)(num2 * 1190529708) ^ -525422250;
					continue;
				default:
					return;
				case 5u:
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
			int num = -961897272;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCB6BEA4u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 567965845) ^ -1049139687;
					continue;
				case 3u:
					num = ((int)num2 * -239321169) ^ 0x6967FE96;
					continue;
				case 2u:
					m_Key = aKey;
					num = ((int)num2 * -1438656073) ^ 0x535FE5DD;
					continue;
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -1600211468) ^ 0x537362F6;
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

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1299711991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x606C08DBu) % 11u)
				{
				case 10u:
					flag = m_Key == null;
					num = (int)(num2 * 720737759) ^ -484310334;
					continue;
				case 9u:
					num = (int)((num2 * 425064670) ^ 0x11949499);
					continue;
				case 8u:
					num = (int)((num2 * 2107609115) ^ 0x2C36B205);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2050661982;
						num4 = -2050661982;
					}
					else
					{
						num3 = -2126391568;
						num4 = -2126391568;
					}
					num = num3 ^ ((int)num2 * -231837524);
					continue;
				}
				case 5u:
					num = 1704519750;
					continue;
				case 4u:
					num = ((int)num2 * -1604248952) ^ -1624804944;
					continue;
				case 3u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -988846971) ^ -1970147270;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = ((int)num2 * -56445646) ^ -1340287357;
					continue;
				case 0u:
					num = ((int)num2 * -166954721) ^ -1260410525;
					continue;
				case 2u:
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
		JSONArray jSONArray = new JSONArray();
		jSONArray.Add(aItem);
		while (true)
		{
			int num = 45017758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5999BAE6u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -716156431) ^ 0xC64FD94;
					continue;
				case 2u:
					Set(jSONArray);
					num = (int)((num2 * 929914340) ^ 0xE22A19C);
					continue;
				case 1u:
					num = (int)(num2 * 1083175608) ^ -1264474027;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 503217501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x477F84B9u) % 5u)
				{
				case 3u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -300531950) ^ -1318788473;
					continue;
				case 2u:
					Set(jSONClass);
					num = ((int)num2 * -2114118167) ^ 0xDDA73B6;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 2028082249) ^ 0x7146E439);
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
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = -987492071;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8F768AAu) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -824988862;
						num4 = -824988862;
					}
					else
					{
						num3 = -2012323000;
						num4 = -2012323000;
					}
					num = num3 ^ ((int)num2 * -1058434254);
					continue;
				}
				case 4u:
					result = (object)a == b;
					num = -1853562837;
					continue;
				case 1u:
					num = ((int)num2 * -527256742) ^ 0x7D123655;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 813059569) ^ 0x510D3ADB);
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1741413874;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9F30116u) % 3u)
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
				result = !(a == b);
				num = (int)(num2 * 576066852) ^ -261177462;
			}
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0006;
		}
		goto IL_003d;
		IL_003d:
		bool result = (object)this == obj;
		int num = -1978882144;
		goto IL_001c;
		IL_001c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x91A47392u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				result = true;
				num = (int)(num2 * 2010655931) ^ -423698433;
				continue;
			case 0u:
				goto IL_003d;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = -551835329;
		goto IL_001c;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = -1325591900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE894277u) % 4u)
				{
				case 3u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -1762136192) ^ -1086746406;
					continue;
				case 1u:
					num = ((int)num2 * -1146243408) ^ 0x29A8C309;
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
		string result = default(string);
		while (true)
		{
			int num = -809742326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB85C377Du) % 3u)
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
				num = (int)(num2 * 646017437) ^ -1550496650;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1128701465;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59E30787u) % 3u)
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
				num = ((int)num2 * -2054960797) ^ 0x61966A13;
			}
		}
	}
}
