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
				int num = 1459245424;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D1B0E56u) % 3u)
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
					result = new JSONLazyCreator(this);
					num = (int)(num2 * 213633208) ^ -1515719784;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = -1156298887;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x932C317Fu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -464345868) ^ 0x5792166E;
						continue;
					case 2u:
						Set(jSONArray);
						num = (int)(num2 * 1884970499) ^ -1493172858;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 55827156;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x24B2B8B8u) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = (int)((num2 * 1025580212) ^ 0x2E55A499);
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1830808082;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7DC7A896u) % 6u)
					{
					case 5u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1093027286) ^ -1777187865;
						continue;
					case 4u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -103287965) ^ 0x6675D939;
						continue;
					case 3u:
						num = (int)(num2 * 19323659) ^ -1367373391;
						continue;
					case 2u:
						Set(jSONClass);
						num = ((int)num2 * -321245818) ^ -216138323;
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
			int result = default(int);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -949618279;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBF34956u) % 6u)
					{
					case 5u:
						result = 0;
						num = (int)((num2 * 1191485020) ^ 0x3CAEFD5A);
						continue;
					case 3u:
						aVal = new JSONData(0);
						num = ((int)num2 * -1293898985) ^ 0x40584F7D;
						continue;
					case 1u:
						num = (int)((num2 * 732413530) ^ 0x24C12FC3);
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -124036547) ^ 0x29C3CC45;
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
				int num = 807079901;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CEB3202u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 134685497) ^ 0x6FA3E94);
						continue;
					case 2u:
						num = ((int)num2 * -1866919209) ^ 0x3F3573DF;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -614096745) ^ -1383303877;
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
			float result = default(float);
			while (true)
			{
				int num = 95358453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79494332u) % 6u)
					{
					case 5u:
						result = 0f;
						num = ((int)num2 * -1650642215) ^ -1000918255;
						continue;
					case 4u:
						num = (int)((num2 * 1112341332) ^ 0x50DCF1FB);
						continue;
					case 2u:
						num = (int)((num2 * 156635873) ^ 0x45A6B445);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = ((int)num2 * -400516642) ^ 0x77948FC0;
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
				int num = 1994529297;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x738BA5CCu) % 4u)
					{
					case 2u:
						Set(aVal);
						num = (int)(num2 * 1732154789) ^ -1602501695;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1591617751) ^ 0xDEBEDFF;
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			return 0.0;
		}
		set
		{
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = 1517737785;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x653C144Bu) % 3u)
					{
					case 2u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0009:
					Set(aVal);
					num = (int)(num2 * 693496195) ^ -1372400802;
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
				int num = 229909922;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E2C1050u) % 6u)
					{
					case 4u:
						aVal = new JSONData(aData: false);
						num = (int)(num2 * 332238300) ^ -400409869;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -256776323) ^ -2106978969;
						continue;
					case 1u:
						num = ((int)num2 * -579973719) ^ 0x155ED9D0;
						continue;
					case 0u:
						result = false;
						num = (int)((num2 * 731547352) ^ 0x399D92AB);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -1282975749;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA8BF221u) % 6u)
					{
					case 5u:
						result = jSONArray;
						num = ((int)num2 * -696664797) ^ 0x36B7EC6B;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 1686517600) ^ -1377578716;
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)((num2 * 314551524) ^ 0x7310B73B);
						continue;
					case 0u:
						num = ((int)num2 * -1014148497) ^ -771403002;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -928660354;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB8287B33u) % 7u)
					{
					case 6u:
						Set(jSONClass);
						num = ((int)num2 * -360288197) ^ 0x2DD9DE51;
						continue;
					case 5u:
						num = ((int)num2 * -755898536) ^ 0x6F2A4C00;
						continue;
					case 3u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 46843220) ^ 0x5DE44B42);
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -658502624) ^ -1978399384;
						continue;
					case 1u:
						num = (int)((num2 * 1780227304) ^ 0x5751FD77);
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
		m_Node = aNode;
		m_Key = aKey;
	}

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 479591832;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4EFD474Cu) % 13u)
				{
				case 12u:
					num = ((int)num2 * -774802970) ^ -2123467078;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1298492410;
						num4 = 1298492410;
					}
					else
					{
						num3 = 17613582;
						num4 = 17613582;
					}
					num = num3 ^ (int)(num2 * 765748393);
					continue;
				}
				case 9u:
					num = 1962853285;
					continue;
				case 8u:
					m_Node = null;
					num = 352209806;
					continue;
				case 7u:
					num = ((int)num2 * -846877008) ^ -1426869448;
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = (int)(num2 * 1361586267) ^ -79034185;
					continue;
				case 5u:
					flag = m_Key == null;
					num = ((int)num2 * -461968395) ^ -309699084;
					continue;
				case 4u:
					num = ((int)num2 * -2113868444) ^ 0x1FD066A9;
					continue;
				case 2u:
					num = ((int)num2 * -1062143057) ^ -99276055;
					continue;
				case 1u:
					num = ((int)num2 * -571677417) ^ -50938345;
					continue;
				case 0u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1292554715) ^ 0x6E2B49B1;
					continue;
				default:
					return;
				case 3u:
					break;
				case 11u:
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
			int num = 958308683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F5B6DB4u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1306163358) ^ 0x269D6842);
					continue;
				case 0u:
					Set(jSONArray);
					num = (int)(num2 * 1097778761) ^ -1684368391;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		jSONClass.Add(aKey, aItem);
		while (true)
		{
			int num = -1588195546;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3113B57u) % 4u)
				{
				case 3u:
					Set(jSONClass);
					num = ((int)num2 * -143961237) ^ 0x339F8E38;
					continue;
				case 1u:
					num = ((int)num2 * -1789578734) ^ -429040446;
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
			goto IL_0006;
		}
		goto IL_0050;
		IL_0050:
		bool result = (object)a == b;
		int num = -1882123445;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDE17F554u) % 5u)
			{
			case 4u:
				break;
			case 3u:
				result = true;
				num = (int)(num2 * 872607068) ^ -466807914;
				continue;
			case 2u:
				num = ((int)num2 * -1094036533) ^ 0x2EB8E861;
				continue;
			case 1u:
				goto IL_0050;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = -1491549555;
		goto IL_002b;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = 809394081;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F0F3B61u) % 3u)
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
				num = (int)((num2 * 1846231206) ^ 0x7105AC0);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -1969708718;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9A6B4DCu) % 5u)
				{
				case 3u:
					result = true;
					num = (int)(num2 * 1709918149) ^ -67657729;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1001696832;
						num4 = -1001696832;
					}
					else
					{
						num3 = -1804442276;
						num4 = -1804442276;
					}
					num = num3 ^ (int)(num2 * 110182195);
					continue;
				}
				case 1u:
					result = (object)this == obj;
					num = -1671640111;
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = 699098621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EFD9ED5u) % 3u)
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
				num = (int)(num2 * 37541899) ^ -1291918175;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1931013324;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE988BB3u) % 4u)
				{
				case 3u:
					result = "";
					num = (int)(num2 * 678845784) ^ -1754439929;
					continue;
				case 0u:
					num = (int)((num2 * 807390658) ^ 0x5136140E);
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

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = -1951401613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC84B187u) % 3u)
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
				num = ((int)num2 * -1587471344) ^ -45313887;
			}
		}
	}
}
