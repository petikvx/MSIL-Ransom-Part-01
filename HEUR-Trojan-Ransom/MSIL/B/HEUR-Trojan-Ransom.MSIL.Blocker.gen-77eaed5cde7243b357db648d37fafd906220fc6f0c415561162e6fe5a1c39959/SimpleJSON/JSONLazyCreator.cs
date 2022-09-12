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
			jSONArray.Add(value);
			while (true)
			{
				int num = -845340675;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD8A1430Eu) % 3u)
					{
					case 2u:
						goto IL_000f;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000f:
					Set(jSONArray);
					num = ((int)num2 * -1272460813) ^ 0x7781DEBB;
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
				int num = 1149158501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x611D31ABu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2108720683) ^ 0x7A1070B1;
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = (int)(num2 * 1792840193) ^ -1343423598;
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
				int num = 1259886081;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FCF69B0u) % 4u)
					{
					case 1u:
						jSONClass = new JSONClass();
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 516632182) ^ 0x2B45B94E);
						continue;
					case 0u:
						Set(jSONClass);
						num = (int)((num2 * 2044651852) ^ 0x9AFB522);
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
			int result = default(int);
			while (true)
			{
				int num = -1525730809;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x825C61CAu) % 6u)
					{
					case 5u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = (int)((num2 * 821675465) ^ 0x5932A343);
						continue;
					}
					case 3u:
						result = 0;
						num = ((int)num2 * -2098338883) ^ -355879221;
						continue;
					case 2u:
						num = (int)((num2 * 1227245741) ^ 0x371B8D35);
						continue;
					case 0u:
						num = ((int)num2 * -416226657) ^ 0x6A76576B;
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
				int num = -960001915;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x894D83E8u) % 3u)
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
					num = ((int)num2 * -892009872) ^ -673928304;
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
				int num = 1776479312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71DA0F35u) % 5u)
					{
					case 3u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 135317686) ^ 0x3BC0B174);
						continue;
					case 1u:
						num = (int)(num2 * 685909011) ^ -874365369;
						continue;
					case 0u:
						Set(aVal);
						result = 0f;
						num = (int)((num2 * 1164838907) ^ 0x7D6D9454);
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
				int num = 1233611201;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D4B223Fu) % 3u)
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
					num = (int)((num2 * 622249445) ^ 0x7DCB1F71);
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
				int num = -1091840331;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB62FFD9Cu) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 2041224614) ^ -1713388239;
						continue;
					case 2u:
						num = ((int)num2 * -381758455) ^ -1504334068;
						continue;
					case 1u:
						result = 0.0;
						num = (int)(num2 * 1970124912) ^ -51219290;
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 848275159;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BD53BFAu) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -85242036) ^ -1598993491;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = (int)((num2 * 978267355) ^ 0x5B0AA2DB);
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

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = 570385534;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D33260Eu) % 5u)
					{
					case 3u:
						num = (int)(num2 * 987588281) ^ -1875746703;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = (int)((num2 * 1837172143) ^ 0x64E7E162);
						continue;
					}
					case 0u:
						result = false;
						num = ((int)num2 * -1722371104) ^ -504280750;
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
				int num = -2114807234;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x831F0AF4u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2035487777) ^ -401078380;
						continue;
					case 2u:
						Set(aVal);
						num = ((int)num2 * -1919611272) ^ 0x3873FD07;
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1825419174;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F6280C3u) % 6u)
					{
					case 3u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = ((int)num2 * -535156028) ^ -880885066;
						continue;
					case 2u:
						result = jSONArray;
						num = ((int)num2 * -1063544473) ^ 0x402A07C3;
						continue;
					case 1u:
						num = ((int)num2 * -1846777168) ^ -1278539469;
						continue;
					case 0u:
						num = (int)(num2 * 1096087467) ^ -1080116945;
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
	}

	public override JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 320769591;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0C16A5u) % 6u)
					{
					case 5u:
						result = jSONClass;
						num = ((int)num2 * -481700349) ^ -1223876842;
						continue;
					case 2u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -265290266) ^ 0x74D1F7D2;
						continue;
					case 1u:
						Set(jSONClass);
						num = ((int)num2 * -6056276) ^ -1768492909;
						continue;
					case 0u:
						num = (int)((num2 * 1691437237) ^ 0x79508F92);
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
			int num = -906569239;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0ECA922u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -813549796) ^ -611231805;
					continue;
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -1277386900) ^ -2134806380;
					continue;
				case 3u:
					num = (int)(num2 * 687177476) ^ -1055007326;
					continue;
				case 0u:
					m_Key = null;
					num = ((int)num2 * -1395355676) ^ -518734681;
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
			int num = -1223426618;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB81F5838u) % 12u)
				{
				case 11u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -569433802) ^ 0x69A97D65;
					continue;
				case 10u:
					num = ((int)num2 * -1814133057) ^ -2137645218;
					continue;
				case 9u:
					num = (int)((num2 * 1491567158) ^ 0x17795678);
					continue;
				case 7u:
					num = ((int)num2 * -1508829571) ^ 0x69910260;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1992164279;
						num4 = 1992164279;
					}
					else
					{
						num3 = 957453271;
						num4 = 957453271;
					}
					num = num3 ^ (int)(num2 * 1235598123);
					continue;
				}
				case 5u:
					num = -1090838673;
					continue;
				case 4u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1511325847) ^ 0x61B1A9C5;
					continue;
				case 3u:
					num = (int)(num2 * 548395629) ^ -973087965;
					continue;
				case 2u:
					flag = m_Key == null;
					num = (int)((num2 * 1669022135) ^ 0x19E972A4);
					continue;
				case 1u:
					num = ((int)num2 * -614322991) ^ -1729992959;
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
		while (true)
		{
			int num = 1532075512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C8BF4CDu) % 3u)
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
				JSONArray jSONArray = new JSONArray();
				jSONArray.Add(aItem);
				Set(jSONArray);
				num = (int)((num2 * 288998731) ^ 0xD19BB65);
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = -1871600977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF61CE0E0u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1406802968) ^ 0x6F74025F);
					continue;
				case 3u:
					Set(jSONClass);
					num = ((int)num2 * -2018679306) ^ -1403942134;
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1486966730) ^ 0x73574662;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = -1508199263;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCBCB12F3u) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -980065700;
						num4 = -980065700;
					}
					else
					{
						num3 = -598698986;
						num4 = -598698986;
					}
					num = num3 ^ ((int)num2 * -1963142089);
					continue;
				}
				case 5u:
					result = (object)a == b;
					num = -29323033;
					continue;
				case 3u:
					num = (int)((num2 * 1344371307) ^ 0x719688EB);
					continue;
				case 1u:
					num = (int)((num2 * 1096482301) ^ 0x32E7E4DA);
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -1758725028) ^ 0x6907825E;
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
		bool result = !(a == b);
		while (true)
		{
			int num = 145297174;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4EEF465u) % 3u)
				{
				case 2u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 849005174) ^ 0x3849BD5C);
			}
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0037;
		}
		goto IL_0065;
		IL_0065:
		bool result = (object)this == obj;
		int num = 1636089256;
		goto IL_003c;
		IL_003c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4E5E5444u) % 6u)
			{
			case 4u:
				num = (int)(num2 * 1670730229) ^ -1861067021;
				continue;
			case 3u:
				result = true;
				num = (int)(num2 * 1089316074) ^ -1593825582;
				continue;
			case 2u:
				num = ((int)num2 * -89857124) ^ -425755777;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0065;
			default:
				return result;
			}
			break;
		}
		goto IL_0037;
		IL_0037:
		num = 1194681133;
		goto IL_003c;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 1414703923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BD82DECu) % 4u)
				{
				case 3u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -614411055) ^ 0x6E37A472;
					continue;
				case 1u:
					num = ((int)num2 * -1671713906) ^ 0x212509F4;
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
		return "";
	}

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = -1596995968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E7F974Cu) % 3u)
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
				num = (int)(num2 * 978818850) ^ -222226950;
			}
		}
	}
}
