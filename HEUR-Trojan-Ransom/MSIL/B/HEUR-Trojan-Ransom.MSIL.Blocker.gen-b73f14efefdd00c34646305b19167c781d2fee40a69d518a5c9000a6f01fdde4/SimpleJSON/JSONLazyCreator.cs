namespace SimpleJSON;

internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node = null;

	private string m_Key = null;

	public override JSONNode this[int aIndex]
	{
		get
		{
			return new JSONLazyCreator(this);
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = -67011860;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3CECB33u) % 5u)
					{
					case 4u:
						jSONArray.Add(value);
						num = ((int)num2 * -252193070) ^ 0x68D45F71;
						continue;
					case 2u:
						num = (int)((num2 * 1802902056) ^ 0x5E153DD0);
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)(num2 * 48423173) ^ -680114429;
						continue;
					default:
						return;
					case 3u:
						break;
					case 1u:
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
				int num = -1629268559;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB2ACDB6Eu) % 4u)
					{
					case 3u:
						jSONClass.Add(aKey, value);
						Set(jSONClass);
						num = ((int)num2 * -326159848) ^ -1841439204;
						continue;
					case 2u:
						num = ((int)num2 * -812877924) ^ -1225386917;
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
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = 1566401014;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B20FACCu) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 2046553947) ^ -554429173;
						continue;
					case 2u:
						result = 0;
						num = ((int)num2 * -808666223) ^ 0x75684D1E;
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = ((int)num2 * -869143258) ^ -2074378902;
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
				int num = -2072390063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE764528Fu) % 5u)
					{
					case 3u:
						num = (int)((num2 * 1903885025) ^ 0x4CD724D2);
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = ((int)num2 * -543171786) ^ -1354021760;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -734013671) ^ -1454650990;
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
	}

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			float result = default(float);
			while (true)
			{
				int num = -2016308751;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEDF37609u) % 5u)
					{
					case 4u:
						Set(aVal);
						num = (int)(num2 * 2063241947) ^ -789231630;
						continue;
					case 1u:
						result = 0f;
						num = ((int)num2 * -1425295613) ^ -303022938;
						continue;
					case 0u:
						num = (int)((num2 * 250057279) ^ 0x7C1F10A7);
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
				int num = -53142866;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC74138BAu) % 5u)
					{
					case 4u:
						Set(aVal);
						num = (int)((num2 * 40353342) ^ 0xF0696F6);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -34112962) ^ 0x2FB224BA;
						continue;
					case 0u:
						num = (int)((num2 * 1491727810) ^ 0x51D39007);
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = 381024406;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4678467Fu) % 4u)
					{
					case 1u:
						Set(aVal);
						result = 0.0;
						num = ((int)num2 * -841466766) ^ -751697035;
						continue;
					case 0u:
						num = (int)(num2 * 181616917) ^ -1387311892;
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
				int num = 1145956566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x44B2C80Fu) % 5u)
					{
					case 4u:
						aVal = new JSONData(value);
						num = (int)(num2 * 1844155573) ^ -1367445655;
						continue;
					case 3u:
						num = ((int)num2 * -2033769254) ^ 0x5B90F483;
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 638572982) ^ -645504383;
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
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = -1229973960;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1EC87BBu) % 7u)
					{
					case 6u:
						aVal = new JSONData(aData: false);
						num = (int)((num2 * 677565545) ^ 0x2300634B);
						continue;
					case 5u:
						Set(aVal);
						num = ((int)num2 * -1165203019) ^ 0x536E87CB;
						continue;
					case 4u:
						num = ((int)num2 * -2077250810) ^ 0x5FCDD8BF;
						continue;
					case 3u:
						result = false;
						num = (int)(num2 * 1491025201) ^ -302918513;
						continue;
					case 1u:
						num = (int)((num2 * 1247957745) ^ 0x28762F9F);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			Set(jSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1524587951;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C88D9D1u) % 3u)
					{
					case 1u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000f:
					result = jSONArray;
					num = (int)(num2 * 969988039) ^ -390748244;
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
				int num = -1357244149;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB15FCFB6u) % 6u)
					{
					case 5u:
						result = jSONClass;
						num = ((int)num2 * -976718446) ^ 0x262D4990;
						continue;
					case 4u:
						num = (int)(num2 * 1809339204) ^ -1076783582;
						continue;
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -924688204) ^ -2070089137;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 924754818) ^ 0x1CB02C05);
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
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 517838325;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A249E19u) % 6u)
				{
				case 5u:
					m_Key = aKey;
					num = ((int)num2 * -1540675584) ^ -732455617;
					continue;
				case 4u:
					num = (int)(num2 * 561648704) ^ -201251462;
					continue;
				case 3u:
					m_Node = aNode;
					num = (int)((num2 * 420419449) ^ 0x4FD7B8FF);
					continue;
				case 1u:
					num = ((int)num2 * -887516360) ^ -1942394218;
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

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 661459058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E03A6Bu) % 11u)
				{
				case 10u:
					num = 156269132;
					continue;
				case 9u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1958784960) ^ -771211078;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 577491752;
						num4 = 577491752;
					}
					else
					{
						num3 = 1148336361;
						num4 = 1148336361;
					}
					num = num3 ^ (int)(num2 * 726145095);
					continue;
				}
				case 7u:
					m_Node.Add(aVal);
					num = (int)((num2 * 1727089782) ^ 0x59662A57);
					continue;
				case 6u:
					num = (int)(num2 * 580947594) ^ -654685047;
					continue;
				case 4u:
					num = ((int)num2 * -1917161104) ^ 0x1FFCBAFD;
					continue;
				case 3u:
					num = ((int)num2 * -1666223181) ^ 0x1755650B;
					continue;
				case 2u:
					num = (int)((num2 * 1257430928) ^ 0x36F7C851);
					continue;
				case 1u:
					flag = m_Key == null;
					num = (int)(num2 * 445184864) ^ -933198745;
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
		JSONArray jSONArray = new JSONArray();
		while (true)
		{
			int num = 1777049813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A27675Au) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1442923997) ^ 0x740A4EC;
					continue;
				case 3u:
					Set(jSONArray);
					num = (int)((num2 * 1537401746) ^ 0x15C24F7F);
					continue;
				case 1u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -1386265449) ^ 0x4D083F3E;
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
		while (true)
		{
			int num = 1890386497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21722C8u) % 3u)
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
				JSONClass jSONClass = new JSONClass();
				jSONClass.Add(aKey, aItem);
				Set(jSONClass);
				num = (int)((num2 * 1719593518) ^ 0x46AB2ED6);
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		if (b == null)
		{
			goto IL_0037;
		}
		goto IL_0065;
		IL_0065:
		bool result = (object)a == b;
		int num = -193325097;
		goto IL_003c;
		IL_003c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x90382FB5u) % 6u)
			{
			case 4u:
				num = (int)(num2 * 80799680) ^ -884730210;
				continue;
			case 2u:
				num = ((int)num2 * -395132966) ^ 0x77C466A;
				continue;
			case 1u:
				result = true;
				num = (int)((num2 * 2048065951) ^ 0x70C83D94);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0065;
			default:
				return result;
			}
			break;
		}
		goto IL_0037;
		IL_0037:
		num = -2073389456;
		goto IL_003c;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -1191638443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0862700u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 192296213) ^ 0x6C964FB0);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1670080929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34FE719Bu) % 8u)
				{
				case 6u:
					result = true;
					num = (int)(num2 * 1767981360) ^ -446540038;
					continue;
				case 4u:
					num = ((int)num2 * -307954753) ^ -1082917896;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1945894971;
						num4 = -1945894971;
					}
					else
					{
						num3 = -1742272021;
						num4 = -1742272021;
					}
					num = num3 ^ (int)(num2 * 226473962);
					continue;
				}
				case 2u:
					flag = obj == null;
					num = (int)(num2 * 933812864) ^ -235213072;
					continue;
				case 1u:
					num = ((int)num2 * -1672495748) ^ 0x75108C48;
					continue;
				case 0u:
					result = (object)this == obj;
					num = 2004999343;
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = 76654291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70628D22u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1612195532) ^ 0x6CC6FD18;
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
			int num = 207092628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x156AB39Au) % 4u)
				{
				case 2u:
					result = "";
					num = ((int)num2 * -1459100425) ^ 0x52E63A5;
					continue;
				case 1u:
					num = (int)(num2 * 1562035429) ^ -361397828;
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
