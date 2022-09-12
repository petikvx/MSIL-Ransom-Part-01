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
				int num = -792376319;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBAF791ABu) % 3u)
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
					result = new JSONLazyCreator(this);
					num = ((int)num2 * -606066543) ^ -885815933;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1086501688;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE636A6Eu) % 6u)
					{
					case 5u:
						num = (int)((num2 * 1734136708) ^ 0x5B531594);
						continue;
					case 4u:
						Set(jSONArray);
						num = ((int)num2 * -1152945338) ^ 0x254FE94D;
						continue;
					case 3u:
						jSONArray.Add(value);
						num = (int)(num2 * 1350228358) ^ -56661499;
						continue;
					case 2u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 775165408) ^ -1427250051;
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
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 929489523;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2EACDE46u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					num = (int)((num2 * 1944386417) ^ 0x62B50E32);
				}
			}
		}
		set
		{
			JSONClass jSONClass = new JSONClass();
			jSONClass.Add(aKey, value);
			while (true)
			{
				int num = -2070024843;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD382B452u) % 5u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -1033570696) ^ 0x1C39457A;
						continue;
					case 2u:
						num = (int)(num2 * 2047536543) ^ -1268936748;
						continue;
					case 1u:
						num = ((int)num2 * -1427802217) ^ 0x38A42687;
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
			Set(aVal);
			int result = default(int);
			while (true)
			{
				int num = -846409;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD2AAAE0u) % 3u)
					{
					case 1u:
						goto IL_0010;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0010:
					result = 0;
					num = (int)((num2 * 348925606) ^ 0x2A45751F);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 157185658;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5C2521F7u) % 3u)
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
					num = ((int)num2 * -1237984895) ^ -439816781;
				}
			}
		}
	}

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = -421131881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBA79F8B7u) % 6u)
					{
					case 5u:
						result = 0f;
						num = ((int)num2 * -1212099122) ^ -181594097;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -406500789) ^ 0x2324CD0D;
						continue;
					case 2u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 1899746350) ^ 0x1BC9F296);
						continue;
					case 0u:
						num = (int)((num2 * 769239223) ^ 0x5D131DA0);
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
			while (true)
			{
				int num = -1126843312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD22F4DDu) % 3u)
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
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = (int)((num2 * 1922930988) ^ 0x3A0B0CEB);
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
				int num = -1953963991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFD35FA0u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 1521972903) ^ 0x8C27FB8);
						continue;
					case 2u:
						result = 0.0;
						num = ((int)num2 * -1516988209) ^ 0x6B57801A;
						continue;
					case 1u:
						aVal = new JSONData(0.0);
						num = (int)(num2 * 1480852940) ^ -278280696;
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
				int num = -1606089010;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A82417Cu) % 5u)
					{
					case 3u:
						num = ((int)num2 * -1453408040) ^ -39002521;
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1171993638) ^ 0x44DC6342);
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -616396660) ^ 0x3F49091A;
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

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = 150229713;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x218FDD1Fu) % 4u)
					{
					case 2u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						result = false;
						num = (int)(num2 * 370695934) ^ -1899358438;
						continue;
					}
					case 1u:
						num = (int)((num2 * 222898331) ^ 0x98BA534);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = default(JSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -201352433;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF85B5DA2u) % 6u)
					{
					case 4u:
						num = ((int)num2 * -714372914) ^ -1484690988;
						continue;
					case 3u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -1352762138) ^ -1430712211;
						continue;
					case 2u:
						result = jSONArray;
						num = (int)(num2 * 209362210) ^ -1520584853;
						continue;
					case 1u:
						Set(jSONArray);
						num = ((int)num2 * -1772018564) ^ 0x2DA0BA36;
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
			JSONClass jSONClass = new JSONClass();
			Set(jSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -778927330;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCB4CA63Fu) % 4u)
					{
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -1903757065) ^ -1910288258;
						continue;
					case 1u:
						num = ((int)num2 * -297310322) ^ -310957633;
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
		while (true)
		{
			int num = 1803180910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18767CC1u) % 5u)
				{
				case 4u:
					m_Node = aNode;
					m_Key = null;
					num = ((int)num2 * -1519895737) ^ -1616028959;
					continue;
				case 3u:
					num = (int)((num2 * 1132928786) ^ 0x69660601);
					continue;
				case 1u:
					num = (int)(num2 * 1238396488) ^ -1749734065;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = -181815886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA768E79u) % 3u)
				{
				case 1u:
					goto IL_0016;
				case 2u:
					break;
				default:
					m_Node = aNode;
					m_Key = aKey;
					return;
				}
				break;
				IL_0016:
				num = ((int)num2 * -1509378744) ^ 0x1A0F55A2;
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		bool flag = m_Key == null;
		while (true)
		{
			int num = -509594958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9104CC27u) % 10u)
				{
				case 9u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -739821584;
						num4 = -739821584;
					}
					else
					{
						num3 = -1348112197;
						num4 = -1348112197;
					}
					num = num3 ^ (int)(num2 * 807969657);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1687041723) ^ 0x73909822;
					continue;
				case 7u:
					num = (int)(num2 * 690191) ^ -1238734739;
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = -1021672639;
					continue;
				case 5u:
					m_Node = null;
					num = -725801953;
					continue;
				case 3u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1736322315) ^ -514961036;
					continue;
				case 1u:
					num = ((int)num2 * -593576015) ^ 0x4182FDED;
					continue;
				case 0u:
					num = (int)((num2 * 1543994405) ^ 0x5136FD62);
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
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
			int num = -1602392739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6F3A3D3u) % 5u)
				{
				case 3u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -1890419675) ^ 0x7456140B;
					continue;
				case 2u:
					num = ((int)num2 * -1543607243) ^ 0x462C158E;
					continue;
				case 1u:
					Set(jSONArray);
					num = (int)((num2 * 2027262214) ^ 0x6C93CC0E);
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 1807903890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D7B450Fu) % 4u)
				{
				case 2u:
					Set(jSONClass);
					num = ((int)num2 * -2048494238) ^ -1278091172;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 775353475) ^ 0x402DDB3A);
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -235157607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9047D74u) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 345688840;
						num4 = 345688840;
					}
					else
					{
						num3 = 1249156296;
						num4 = 1249156296;
					}
					num = num3 ^ ((int)num2 * -971037356);
					continue;
				}
				case 5u:
					flag = b == null;
					num = ((int)num2 * -1545651127) ^ -1904439616;
					continue;
				case 4u:
					num = (int)((num2 * 272740626) ^ 0x145A46ED);
					continue;
				case 2u:
					result = (object)a == b;
					num = -1215572111;
					continue;
				case 1u:
					result = true;
					num = (int)((num2 * 1280546420) ^ 0x3ECE988A);
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
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0017;
		}
		goto IL_0052;
		IL_0052:
		bool result = (object)this == obj;
		int num = -1550449370;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xFE7B975Du) % 5u)
			{
			case 3u:
				num = (int)(num2 * 1959466105) ^ -966956618;
				continue;
			case 2u:
				break;
			case 1u:
				result = true;
				num = (int)((num2 * 464654872) ^ 0x68233715);
				continue;
			case 0u:
				goto IL_0052;
			default:
				return result;
			}
			break;
		}
		goto IL_0017;
		IL_0017:
		num = -1143899356;
		goto IL_002d;
	}

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = 1255262941;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x420C9997u) % 3u)
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
				num = ((int)num2 * -1024897884) ^ 0x89BA969;
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = -2056664987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x880574B9u) % 3u)
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
				num = (int)(num2 * 752767385) ^ -61551013;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = "";
		while (true)
		{
			int num = 897028096;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5435FD69u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1228677808) ^ -1899555157;
			}
		}
	}
}
