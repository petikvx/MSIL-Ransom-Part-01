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
				int num = 1431635581;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3554E54Cu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1450583815) ^ -133952274;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 388111148) ^ 0x14C21FDA);
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
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = 664119527;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B5BC1Du) % 3u)
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
					num = ((int)num2 * -1472388806) ^ -965121751;
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
				int num = -88330091;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C29DA6Du) % 3u)
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
					num = ((int)num2 * -218415787) ^ 0x6FB5C39E;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1436177689;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x56BB8172u) % 6u)
					{
					case 5u:
						Set(jSONClass);
						num = (int)((num2 * 79813523) ^ 0x4FFEA719);
						continue;
					case 2u:
						num = ((int)num2 * -592898574) ^ -539260109;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -128903351) ^ -872559589;
						continue;
					case 0u:
						num = ((int)num2 * -1621112929) ^ -1109948339;
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
	}

	public override int AsInt
	{
		get
		{
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = -2116674413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBB9F016u) % 4u)
					{
					case 3u:
						Set(aVal);
						result = 0;
						num = (int)(num2 * 1635051183) ^ -1793028065;
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = (int)((num2 * 1237999204) ^ 0x7D7FAB9);
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
				int num = 254391132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4305637Eu) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -384068624) ^ 0x50B1AB97;
						continue;
					case 1u:
						num = ((int)num2 * -1770104052) ^ -1091940074;
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

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			while (true)
			{
				int num = 2092718394;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D410937u) % 6u)
					{
					case 5u:
						result = 0f;
						num = (int)(num2 * 1945994958) ^ -938205615;
						continue;
					case 4u:
						num = ((int)num2 * -411508312) ^ 0xC66522C;
						continue;
					case 3u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = (int)(num2 * 2045862242) ^ -1737719235;
						continue;
					}
					case 0u:
						num = (int)((num2 * 948435364) ^ 0x60112F5E);
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
			while (true)
			{
				int num = 849809688;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x188FBDD6u) % 3u)
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
					num = (int)((num2 * 1839781941) ^ 0xC71ACFB);
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
				int num = -842045196;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2617D93u) % 6u)
					{
					case 5u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1153540782) ^ 0x250EE16;
						continue;
					case 4u:
						num = (int)((num2 * 492268554) ^ 0x5E11AE95);
						continue;
					case 3u:
						result = 0.0;
						num = ((int)num2 * -2059487180) ^ 0x3B243AF5;
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 1035525170) ^ 0x3D6E47C2);
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
				int num = -1737096197;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD518C175u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = (int)(num2 * 1497158498) ^ -1364031722;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = ((int)num2 * -962390708) ^ 0x58E2500A;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = new JSONData(aData: false);
			bool result = default(bool);
			while (true)
			{
				int num = 746004816;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2A06E3u) % 3u)
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
					Set(aVal);
					result = false;
					num = (int)(num2 * 1161414721) ^ -904117783;
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
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1117288633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8647B0EDu) % 5u)
					{
					case 3u:
						Set(jSONArray);
						num = ((int)num2 * -580497023) ^ 0x2B1DC3A2;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = (int)((num2 * 584664802) ^ 0x43E684F8);
						continue;
					case 0u:
						result = jSONArray;
						num = ((int)num2 * -636560540) ^ -290608046;
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
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 904630503;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5154BD15u) % 4u)
					{
					case 2u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 2144473686) ^ 0x2E1E7EB0);
						continue;
					case 1u:
						result = jSONClass;
						num = (int)((num2 * 1936837859) ^ 0x16549BB6);
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
			int num = 697926669;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27215088u) % 12u)
				{
				case 10u:
					num = (int)(num2 * 952254320) ^ -1600762680;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = 1094434965;
						num4 = 1094434965;
					}
					else
					{
						num3 = 871032364;
						num4 = 871032364;
					}
					num = num3 ^ ((int)num2 * -1296537288);
					continue;
				}
				case 8u:
					num = ((int)num2 * -2143407489) ^ 0x65E29AB7;
					continue;
				case 7u:
					num = (int)(num2 * 68182349) ^ -1209454776;
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 1013019106) ^ 0x4BF16928);
					continue;
				case 4u:
					num = (int)((num2 * 1906988819) ^ 0x16FECC9E);
					continue;
				case 3u:
					m_Node.Add(aVal);
					num = ((int)num2 * -879436564) ^ 0x3B26A77A;
					continue;
				case 2u:
					num = ((int)num2 * -1492569254) ^ -614455829;
					continue;
				case 1u:
					num = ((int)num2 * -616114300) ^ 0x49A5587F;
					continue;
				case 0u:
					num = 678832374;
					continue;
				case 5u:
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
			int num = 151266707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B31590u) % 4u)
				{
				case 3u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -2135514065) ^ -1016837207;
					continue;
				case 0u:
					Set(jSONArray);
					num = ((int)num2 * -451634830) ^ -773747503;
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
			int num = 782975209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DA4F4F0u) % 3u)
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
				Set(jSONClass);
				num = (int)((num2 * 1233654003) ^ 0x5AEAEB8A);
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
		int num = 1062860578;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x547C44E7u) % 5u)
			{
			case 3u:
				break;
			case 1u:
				result = true;
				num = (int)((num2 * 906415949) ^ 0x2667AB84);
				continue;
			case 0u:
				num = ((int)num2 * -1837776365) ^ 0x54FA3F39;
				continue;
			case 4u:
				goto IL_0050;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = 1644951629;
		goto IL_002b;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -558171827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD63BDB9u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -1030904286) ^ 0x5FA13478;
					continue;
				case 3u:
					result = (object)this == obj;
					num = -1861617268;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (obj != null)
					{
						num3 = -1975784644;
						num4 = -1975784644;
					}
					else
					{
						num3 = -315337336;
						num4 = -315337336;
					}
					num = num3 ^ ((int)num2 * -888736472);
					continue;
				}
				case 1u:
					result = true;
					num = ((int)num2 * -1919799568) ^ 0x52BE4313;
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
			int num = -1429683622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD11DDB2Fu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return hashCode;
				}
				break;
				IL_0003:
				hashCode = base.GetHashCode();
				num = (int)((num2 * 585270224) ^ 0x2A5086AF);
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
			int num = 1626391235;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8709CAu) % 4u)
				{
				case 1u:
					result = "";
					num = (int)(num2 * 935628911) ^ -1188501471;
					continue;
				case 0u:
					num = (int)(num2 * 549818795) ^ -347430755;
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
