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
				int num = 2002917629;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB8B57E4u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1847241930) ^ 0x5913E954);
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -875999912) ^ 0x2EF6FC42;
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
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1813287669;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BD279AAu) % 6u)
					{
					case 5u:
						jSONArray = new JSONArray();
						jSONArray.Add(value);
						num = ((int)num2 * -526423010) ^ 0x50908D8C;
						continue;
					case 4u:
						num = ((int)num2 * -1810278449) ^ -1639163841;
						continue;
					case 2u:
						Set(jSONArray);
						num = (int)(num2 * 928139010) ^ -1421221884;
						continue;
					case 0u:
						num = ((int)num2 * -248982639) ^ -1403228370;
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
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = -176709869;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDCFE4746u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					num = (int)(num2 * 175541734) ^ -628787412;
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = -890895459;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8B172897u) % 4u)
					{
					case 2u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1857778109) ^ -315273440;
						continue;
					case 1u:
						Set(jSONClass);
						num = ((int)num2 * -191512917) ^ 0x5D1BE128;
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
			int result = default(int);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -825750243;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDDD7893Fu) % 5u)
					{
					case 4u:
						result = 0;
						num = ((int)num2 * -2043192108) ^ -1968390408;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 630513146) ^ 0x1C471AF);
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = (int)((num2 * 1653014639) ^ 0x6B897A7E);
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
				int num = 1118364330;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EB9B310u) % 5u)
					{
					case 4u:
						Set(aVal);
						num = ((int)num2 * -832722725) ^ 0x55CE80DC;
						continue;
					case 3u:
						aVal = new JSONData(value);
						num = (int)((num2 * 779750794) ^ 0x7633EC41);
						continue;
					case 1u:
						num = (int)((num2 * 513522572) ^ 0x34E0D131);
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

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = 1033124855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7ABC86B4u) % 6u)
					{
					case 4u:
						result = 0f;
						num = (int)(num2 * 2025416955) ^ -1922804640;
						continue;
					case 2u:
						num = (int)((num2 * 1520172712) ^ 0x58B34C96);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = (int)(num2 * 1449928783) ^ -657129679;
						continue;
					}
					case 0u:
						num = (int)((num2 * 1043617303) ^ 0x776D0895);
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
			Set(aVal);
			while (true)
			{
				int num = -1073035188;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x86072E7Fu) % 3u)
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
					num = ((int)num2 * -137220504) ^ 0x5D98069B;
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
				int num = -728869736;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA698CE53u) % 5u)
					{
					case 4u:
						result = 0.0;
						num = ((int)num2 * -1115830047) ^ 0x504BAF99;
						continue;
					case 3u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = (int)((num2 * 53555827) ^ 0x6714E0EA);
						continue;
					}
					case 1u:
						num = (int)((num2 * 1221046209) ^ 0xC3AA369);
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 708904782;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3670DB15u) % 6u)
					{
					case 5u:
						Set(aVal);
						num = (int)(num2 * 1631937374) ^ -416162237;
						continue;
					case 2u:
						result = false;
						num = ((int)num2 * -390446598) ^ 0x6A88049;
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -1445710372) ^ 0x2263DE04;
						continue;
					case 0u:
						num = ((int)num2 * -670236806) ^ 0x5C5DC8DB;
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
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = 2038948613;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71226180u) % 3u)
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
					num = ((int)num2 * -1535536840) ^ -271458818;
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
				int num = -2088263311;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE2355B6u) % 5u)
					{
					case 4u:
						result = jSONArray;
						num = ((int)num2 * -868993451) ^ 0x56A807F9;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 370051667) ^ -1142994530;
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)(num2 * 390503171) ^ -1989671664;
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
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 745044800;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x327A09FAu) % 7u)
					{
					case 5u:
						num = (int)((num2 * 559675534) ^ 0x6B1611B);
						continue;
					case 4u:
						result = jSONClass;
						num = (int)(num2 * 1398561774) ^ -1229790897;
						continue;
					case 2u:
						num = ((int)num2 * -928031862) ^ 0x34DD67E4;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 317622787) ^ 0x455508D0);
						continue;
					case 0u:
						Set(jSONClass);
						num = ((int)num2 * -490136801) ^ -918250761;
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
			int num = 1960899729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F3B47A5u) % 5u)
				{
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -670311064) ^ -935567551;
					continue;
				case 2u:
					num = ((int)num2 * -490622231) ^ 0x3BC921E4;
					continue;
				case 1u:
					num = ((int)num2 * -257460028) ^ 0x513F3CD0;
					continue;
				case 0u:
					break;
				default:
					m_Key = null;
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
		if (m_Key == null)
		{
			goto IL_0058;
		}
		goto IL_0086;
		IL_0086:
		int num = 897562800;
		goto IL_005d;
		IL_005d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB8DE86Cu) % 6u)
			{
			case 4u:
				m_Node.Add(m_Key, aVal);
				num = ((int)num2 * -1901557826) ^ -943571859;
				continue;
			case 2u:
				num = ((int)num2 * -626085178) ^ 0x1E71662F;
				continue;
			case 1u:
				m_Node.Add(aVal);
				num = ((int)num2 * -261309540) ^ 0x40C10701;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0086;
			default:
				m_Node = null;
				return;
			}
			break;
		}
		goto IL_0058;
		IL_0058:
		num = 657955982;
		goto IL_005d;
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = -1953324928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBB24C39u) % 4u)
				{
				case 3u:
					Set(jSONArray);
					num = ((int)num2 * -1963252882) ^ 0x2540A177;
					continue;
				case 1u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = (int)(num2 * 332127719) ^ -1530899375;
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
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1187712658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC978827u) % 6u)
				{
				case 5u:
					Set(jSONClass);
					num = (int)(num2 * 827960481) ^ -1348403747;
					continue;
				case 3u:
					num = ((int)num2 * -722060592) ^ -914057789;
					continue;
				case 2u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1271757379) ^ -1342642796;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					num = (int)(num2 * 2027282318) ^ -220640431;
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
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -692162670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x917E6F01u) % 8u)
				{
				case 7u:
					result = true;
					num = (int)(num2 * 1322964971) ^ -1296497891;
					continue;
				case 6u:
					num = (int)((num2 * 675217612) ^ 0x43A4474D);
					continue;
				case 5u:
					result = (object)a == b;
					num = -97258569;
					continue;
				case 3u:
					flag = b == null;
					num = ((int)num2 * -800952675) ^ -169790068;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1833005136;
						num4 = 1833005136;
					}
					else
					{
						num3 = 1924431322;
						num4 = 1924431322;
					}
					num = num3 ^ ((int)num2 * -1808911477);
					continue;
				}
				case 1u:
					num = (int)(num2 * 159166366) ^ -929536629;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1022926120;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA97158Du) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1727215053) ^ -1625499509;
					continue;
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -1069686290) ^ 0xDD36EB1;
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
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1075413025;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EB9EB6Fu) % 7u)
				{
				case 6u:
					result = (object)this == obj;
					num = 1576029997;
					continue;
				case 3u:
					flag = obj == null;
					num = ((int)num2 * -619002095) ^ -834404121;
					continue;
				case 2u:
					result = true;
					num = (int)((num2 * 383656885) ^ 0x7C8C55AA);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2026925418;
						num4 = 2026925418;
					}
					else
					{
						num3 = 1217331845;
						num4 = 1217331845;
					}
					num = num3 ^ ((int)num2 * -1206852932);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1810876057) ^ 0x5B437E19);
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
		int hashCode = default(int);
		while (true)
		{
			int num = -1587401827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4C24A03u) % 4u)
				{
				case 2u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -810592465) ^ 0x4B299B8;
					continue;
				case 1u:
					num = (int)(num2 * 1082008691) ^ -306416425;
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
			int num = 1524441674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE135477u) % 3u)
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
				num = ((int)num2 * -649576453) ^ -1579707933;
			}
		}
	}
}
