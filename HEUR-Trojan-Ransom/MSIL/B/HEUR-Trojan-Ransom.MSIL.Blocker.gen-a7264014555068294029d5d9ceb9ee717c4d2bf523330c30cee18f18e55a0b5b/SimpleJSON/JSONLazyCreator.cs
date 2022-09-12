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
				int num = -166365752;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCF79AAFBu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -136030618) ^ -2135680986;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 417055087;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7E44DB3u) % 5u)
					{
					case 4u:
						jSONArray = new JSONArray();
						jSONArray.Add(value);
						num = (int)(num2 * 1538021582) ^ -1643039293;
						continue;
					case 2u:
						Set(jSONArray);
						num = (int)((num2 * 321386926) ^ 0x5799CAF8);
						continue;
					case 1u:
						num = (int)(num2 * 1779164733) ^ -216559314;
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
			return new JSONLazyCreator(this, aKey);
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			Set(jSONClass);
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
				int num = -1912901858;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB6079BCu) % 5u)
					{
					case 4u:
						num = (int)(num2 * 1152083904) ^ -1518126336;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 280180256) ^ -1184017380;
						continue;
					case 0u:
						result = 0;
						num = (int)(num2 * 122998586) ^ -1473129470;
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
			Set(aVal);
		}
	}

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = -213238685;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC781806Du) % 3u)
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
					JSONData aVal = new JSONData(0f);
					Set(aVal);
					result = 0f;
					num = ((int)num2 * -711721660) ^ -1685704964;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1826296419;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC2AF5CDu) % 3u)
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
					num = ((int)num2 * -1550098769) ^ 0x33B18DCB;
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
				int num = 1995141676;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EA1051u) % 5u)
					{
					case 3u:
						num = (int)(num2 * 301002067) ^ -4276007;
						continue;
					case 2u:
						Set(aVal);
						result = 0.0;
						num = ((int)num2 * -2116734090) ^ 0x7B171EB5;
						continue;
					case 1u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1555161834) ^ -1054704302;
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
				int num = -608314090;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8894B2B7u) % 4u)
					{
					case 3u:
						result = false;
						num = (int)(num2 * 573174839) ^ -109493886;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = (int)((num2 * 631101551) ^ 0x5146CE6F);
						continue;
					}
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
			while (true)
			{
				int num = 1415071418;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B85596Bu) % 3u)
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
					num = (int)(num2 * 1868282750) ^ -1306857270;
				}
			}
		}
	}

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1463596851;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D3F0A63u) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = (int)(num2 * 920755402) ^ -32954773;
						continue;
					case 1u:
						num = ((int)num2 * -61424082) ^ 0x688ED9A4;
						continue;
					case 0u:
						result = jSONArray;
						num = (int)((num2 * 1810394067) ^ 0x11CEC28C);
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
				int num = 2107464260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FD1FC7Bu) % 5u)
					{
					case 4u:
						num = (int)(num2 * 1319266961) ^ -870033575;
						continue;
					case 2u:
						result = jSONClass;
						num = (int)(num2 * 37836974) ^ -1594847265;
						continue;
					case 1u:
						Set(jSONClass);
						num = (int)((num2 * 925472358) ^ 0x9C9F672);
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
		while (true)
		{
			int num = 1189810556;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25BDBA57u) % 6u)
				{
				case 5u:
					m_Key = aKey;
					num = (int)((num2 * 1807619910) ^ 0x48AEE401);
					continue;
				case 3u:
					num = ((int)num2 * -1449803839) ^ -1761500871;
					continue;
				case 2u:
					m_Node = aNode;
					num = (int)((num2 * 1483630410) ^ 0x46BDDFC2);
					continue;
				case 1u:
					num = ((int)num2 * -744918227) ^ 0x2863C8E2;
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

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1981716778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE642D2A1u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1409571316) ^ 0x7958FCCC;
					continue;
				case 9u:
					num = ((int)num2 * -1319465263) ^ -169547281;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1813738144;
						num4 = 1813738144;
					}
					else
					{
						num3 = 583678450;
						num4 = 583678450;
					}
					num = num3 ^ ((int)num2 * -252574319);
					continue;
				}
				case 7u:
					num = ((int)num2 * -750242448) ^ -746237621;
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -589290177) ^ 0xB9FE77F;
					continue;
				case 5u:
					m_Node.Add(aVal);
					num = ((int)num2 * -751679364) ^ 0x3D06ADD8;
					continue;
				case 3u:
					flag = m_Key == null;
					num = (int)((num2 * 735331176) ^ 0x427E90BD);
					continue;
				case 2u:
					m_Node = null;
					num = -1334722269;
					continue;
				case 1u:
					num = -1611157789;
					continue;
				case 0u:
					num = (int)(num2 * 181861751) ^ -1023230789;
					continue;
				default:
					return;
				case 4u:
					break;
				case 10u:
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
			int num = -1354471332;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB627EFAu) % 4u)
				{
				case 2u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -1912942669) ^ 0x2456F785;
					continue;
				case 1u:
					num = (int)(num2 * 541068104) ^ -1141449415;
					continue;
				case 0u:
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
			int num = -475840951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA68B6F3Eu) % 4u)
				{
				case 3u:
					Set(jSONClass);
					num = ((int)num2 * -272693385) ^ -1141374638;
					continue;
				case 1u:
					num = ((int)num2 * -233725309) ^ 0x3938CE17;
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
		if (b == null)
		{
			goto IL_0028;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)a == b;
		int num = 99230209;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x7A3C0D16u) % 5u)
			{
			case 3u:
				result = true;
				num = (int)((num2 * 1363271804) ^ 0x6E2D3A6D);
				continue;
			case 1u:
				num = (int)(num2 * 1628472119) ^ -520463080;
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0052;
			default:
				return result;
			}
			break;
		}
		goto IL_0028;
		IL_0028:
		num = 99580777;
		goto IL_002d;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -693691125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE063DC9u) % 4u)
				{
				case 2u:
					result = !(a == b);
					num = ((int)num2 * -2131456573) ^ 0x635BDF86;
					continue;
				case 1u:
					num = (int)(num2 * 1809340299) ^ -217843662;
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
		while (true)
		{
			int num = -743281598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9369B60u) % 6u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (obj != null)
					{
						num3 = 1073797945;
						num4 = 1073797945;
					}
					else
					{
						num3 = 1790462318;
						num4 = 1790462318;
					}
					num = num3 ^ (int)(num2 * 2059192379);
					continue;
				}
				case 3u:
					result = (object)this == obj;
					num = -1640810292;
					continue;
				case 1u:
					num = (int)(num2 * 45755105) ^ -796738951;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 1888994412) ^ 0x45209E15);
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
			int num = 1342725571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA53CEB6u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0003:
				hashCode = base.GetHashCode();
				num = (int)((num2 * 731025059) ^ 0x7D440375);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1696825474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD99710A5u) % 4u)
				{
				case 3u:
					result = "";
					num = (int)((num2 * 1250671325) ^ 0x6C0C0DB4);
					continue;
				case 2u:
					num = (int)(num2 * 126183573) ^ -1869460126;
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1122768622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A5C6046u) % 3u)
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
				num = ((int)num2 * -1081353378) ^ 0x1585434C;
			}
		}
	}
}
