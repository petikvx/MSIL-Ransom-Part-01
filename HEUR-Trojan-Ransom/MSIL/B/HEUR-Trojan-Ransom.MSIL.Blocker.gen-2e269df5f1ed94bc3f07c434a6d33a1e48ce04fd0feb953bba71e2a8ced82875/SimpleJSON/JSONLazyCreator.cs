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
				int num = 544771847;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79B94660u) % 3u)
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
					num = ((int)num2 * -315261432) ^ 0x75541603;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 414890997;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E687932u) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = ((int)num2 * -237501283) ^ 0x1D77D01B;
						continue;
					case 3u:
						num = (int)((num2 * 807955299) ^ 0x418C9224);
						continue;
					case 1u:
						jSONArray = new JSONArray();
						jSONArray.Add(value);
						num = ((int)num2 * -271564632) ^ -786326002;
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
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 2059023811;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D6F1414u) % 3u)
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
					num = (int)((num2 * 1940192270) ^ 0x2BA1D187);
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1212777069;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D8D6BCu) % 4u)
					{
					case 2u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -988291407) ^ -53853075;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 1281976282) ^ 0x46B7A68C);
						continue;
					case 0u:
						break;
					default:
						Set(jSONClass);
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
				int num = -1968272940;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED143A80u) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1978683024) ^ 0x351794AC);
						continue;
					case 2u:
						Set(aVal);
						num = (int)(num2 * 159008473) ^ -1272193599;
						continue;
					case 1u:
						result = 0;
						num = (int)((num2 * 613531564) ^ 0x433BEC40);
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
			while (true)
			{
				int num = -1037428291;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC3CC422u) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -1826162400) ^ -688680648;
						continue;
					}
					case 2u:
						num = ((int)num2 * -598942403) ^ -312856043;
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

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			float result = default(float);
			while (true)
			{
				int num = 1464171542;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x33BA656Fu) % 5u)
					{
					case 4u:
						num = (int)((num2 * 1426203054) ^ 0x41694633);
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -123384542) ^ -353450628;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -401242146) ^ -1315523013;
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

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = 1981727833;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x626B2F16u) % 5u)
					{
					case 3u:
						result = 0.0;
						num = (int)((num2 * 2096458034) ^ 0x21E110C2);
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = ((int)num2 * -853144130) ^ 0x3C1D23A6;
						continue;
					}
					case 0u:
						num = (int)(num2 * 1607096132) ^ -574689688;
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
				int num = -704594575;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD77DB574u) % 5u)
					{
					case 4u:
						aVal = new JSONData(value);
						num = (int)(num2 * 660121530) ^ -775576121;
						continue;
					case 3u:
						num = (int)((num2 * 836671568) ^ 0x377F7D8B);
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 1715852928) ^ -98134273;
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
			JSONData aVal = new JSONData(aData: false);
			bool result = default(bool);
			while (true)
			{
				int num = 709523988;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FFE2FB3u) % 5u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -1840958010) ^ 0x152A14E3;
						continue;
					case 1u:
						result = false;
						num = ((int)num2 * -498114972) ^ -1236220290;
						continue;
					case 0u:
						num = ((int)num2 * -134455060) ^ 0x5608CFE6;
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
				int num = 275822774;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57578051u) % 5u)
					{
					case 2u:
						aVal = new JSONData(value);
						num = ((int)num2 * -743777444) ^ 0x6C0714DF;
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 518639678) ^ 0x3B166005);
						continue;
					case 0u:
						num = ((int)num2 * -1117906249) ^ 0x3719BA68;
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
				int num = -1077194289;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD87867DFu) % 3u)
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
					num = ((int)num2 * -591693793) ^ 0x48105BB3;
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
				int num = 545813596;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29733C9Eu) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1816132450) ^ -1223996529;
						continue;
					case 1u:
						result = jSONClass;
						num = ((int)num2 * -82451920) ^ 0x45660AD9;
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
			int num = 12093303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x386D63F8u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 513488012) ^ -1511414328;
					continue;
				case 0u:
					m_Node = aNode;
					num = (int)((num2 * 1322217750) ^ 0x77FE81B9);
					continue;
				case 2u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -153732107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBCC71233u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1031584349) ^ 0x6711D99A;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 755608938;
						num4 = 755608938;
					}
					else
					{
						num3 = 1557583712;
						num4 = 1557583712;
					}
					num = num3 ^ (int)(num2 * 1263791033);
					continue;
				}
				case 8u:
					m_Node.Add(aVal);
					num = ((int)num2 * -1709789031) ^ 0x12A9DE6D;
					continue;
				case 7u:
					num = (int)((num2 * 1787997238) ^ 0x64DE8EA1);
					continue;
				case 6u:
					flag = m_Key == null;
					num = ((int)num2 * -551844584) ^ 0x6569D3C5;
					continue;
				case 5u:
					num = -919553541;
					continue;
				case 4u:
					m_Node = null;
					num = -207270096;
					continue;
				case 2u:
					num = (int)((num2 * 1965008046) ^ 0x2A5C40C2);
					continue;
				case 1u:
					num = (int)(num2 * 1736667047) ^ -286846516;
					continue;
				case 0u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -1131874048) ^ -720771148;
					continue;
				default:
					return;
				case 9u:
					break;
				case 3u:
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
			int num = 254009019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4ADC140Eu) % 4u)
				{
				case 1u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = ((int)num2 * -2102104637) ^ -1877049051;
					continue;
				case 0u:
					Set(jSONArray);
					num = ((int)num2 * -935476639) ^ 0x5CB7A380;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = -1814791620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4B0202Au) % 5u)
				{
				case 4u:
					Set(jSONClass);
					num = (int)(num2 * 1604827246) ^ -939574100;
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -568157571) ^ 0x5AB115B1;
					continue;
				case 0u:
					num = (int)(num2 * 1311869391) ^ -1451944642;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = 354719412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39F6D923u) % 6u)
				{
				case 3u:
					result = (object)a == b;
					num = 2090290155;
					continue;
				case 2u:
					num = ((int)num2 * -2024900191) ^ -1131950998;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1095753311;
						num4 = 1095753311;
					}
					else
					{
						num3 = 787171882;
						num4 = 787171882;
					}
					num = num3 ^ ((int)num2 * -1572403714);
					continue;
				}
				case 0u:
					result = true;
					num = ((int)num2 * -185638919) ^ -1173955684;
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
		bool result = !(a == b);
		while (true)
		{
			int num = 432703739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2FCA868Au) % 3u)
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
				num = (int)((num2 * 2011868569) ^ 0x4379A6C5);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -590420400;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC35BB27Cu) % 6u)
				{
				case 4u:
					result = (object)this == obj;
					num = -165655001;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 41270942;
						num4 = 41270942;
					}
					else
					{
						num3 = 1797944625;
						num4 = 1797944625;
					}
					num = num3 ^ (int)(num2 * 2057072114);
					continue;
				}
				case 1u:
					result = true;
					num = (int)(num2 * 2041648524) ^ -1735120548;
					continue;
				case 0u:
					num = ((int)num2 * -1112460221) ^ 0x69960C33;
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
			int num = 1747344609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EF68922u) % 3u)
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
				num = (int)((num2 * 708497433) ^ 0x61244099);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1995101550;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30566077u) % 3u)
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
				result = "";
				num = (int)((num2 * 1548169156) ^ 0x272181A9);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -540640533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB97A1FBu) % 3u)
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
				result = "";
				num = (int)((num2 * 1894460007) ^ 0x3CDF663D);
			}
		}
	}
}
