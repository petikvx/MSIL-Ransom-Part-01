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
				int num = -1655333483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD9E82D7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1446981937) ^ 0x761D81BF;
						continue;
					case 2u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1304237397) ^ -760136954;
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
				int num = 1698962898;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37586D67u) % 4u)
					{
					case 3u:
						Set(jSONArray);
						num = (int)(num2 * 583453042) ^ -510974423;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						jSONArray.Add(value);
						num = (int)(num2 * 2049269968) ^ -824263348;
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
				int num = 1672305502;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15BE7028u) % 3u)
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
					num = (int)(num2 * 529190774) ^ -203632990;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1571553292;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D464174u) % 5u)
					{
					case 4u:
						Set(jSONClass);
						num = ((int)num2 * -719639016) ^ -188329725;
						continue;
					case 3u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -122779085) ^ 0x63C32487;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 1684899869) ^ 0x3418B6FC);
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

	public override int AsInt
	{
		get
		{
			JSONData aVal = new JSONData(0);
			int result = default(int);
			while (true)
			{
				int num = 1677326622;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C2D8ECBu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -377851250) ^ 0x7A5F24BB;
						continue;
					case 1u:
						Set(aVal);
						result = 0;
						num = ((int)num2 * -1074293149) ^ 0x1ACF03E2;
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
				int num = 1789689834;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E5372F1u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1111539915) ^ 0x2F8B851C;
						continue;
					case 3u:
						aVal = new JSONData(value);
						num = (int)((num2 * 1980036038) ^ 0x714F3D09);
						continue;
					case 2u:
						Set(aVal);
						num = (int)((num2 * 16147189) ^ 0x6F1A7F78);
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
			float result = default(float);
			while (true)
			{
				int num = 1461325623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EB33A2u) % 4u)
					{
					case 2u:
						result = 0f;
						num = ((int)num2 * -463587464) ^ -255603779;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						num = ((int)num2 * -1828951304) ^ -2122642892;
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
				int num = 1622939187;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37FAFABAu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1908256968) ^ -1121915830;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -154131098) ^ -1350409617;
						continue;
					}
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = -568394504;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA09C7DC6u) % 5u)
					{
					case 2u:
						Set(aVal);
						num = (int)((num2 * 1853371345) ^ 0x7B60FEE7);
						continue;
					case 1u:
						result = 0.0;
						num = ((int)num2 * -355712659) ^ 0x45BEA5A9;
						continue;
					case 0u:
						num = ((int)num2 * -2077510243) ^ -1264243654;
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
				int num = -1729199146;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFAF7BAE2u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					JSONData aVal = new JSONData(value);
					Set(aVal);
					num = ((int)num2 * -1758637371) ^ -1886056398;
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
				int num = -247946002;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9688D6C4u) % 7u)
					{
					case 6u:
						num = (int)((num2 * 216187267) ^ 0x29CF26BE);
						continue;
					case 5u:
						Set(aVal);
						num = ((int)num2 * -1690723538) ^ 0x3F79BF89;
						continue;
					case 4u:
						num = ((int)num2 * -1008677377) ^ 0x79DF99F3;
						continue;
					case 2u:
						result = false;
						num = (int)((num2 * 430033638) ^ 0x75CBE188);
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -298494155) ^ -240749848;
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
				int num = 297718576;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46774C09u) % 5u)
					{
					case 4u:
						aVal = new JSONData(value);
						num = ((int)num2 * -1668663351) ^ -1326469253;
						continue;
					case 2u:
						Set(aVal);
						num = (int)(num2 * 1501615808) ^ -1477418986;
						continue;
					case 1u:
						num = (int)((num2 * 1461671358) ^ 0x572D31EA);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			Set(jSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -2006848434;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBF27731u) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000f:
					result = jSONArray;
					num = (int)((num2 * 1969455600) ^ 0x401CC6D8);
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
				int num = -1571883662;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0AA3075u) % 6u)
					{
					case 4u:
						num = (int)(num2 * 1590019623) ^ -2031035615;
						continue;
					case 2u:
						result = jSONClass;
						num = (int)(num2 * 1617818178) ^ -773989403;
						continue;
					case 1u:
						Set(jSONClass);
						num = (int)(num2 * 1951557947) ^ -1938935540;
						continue;
					case 0u:
						num = (int)(num2 * 2133943861) ^ -1091490982;
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
			int num = 1537844177;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23D676A4u) % 4u)
				{
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -927345721) ^ -476021325;
					continue;
				case 0u:
					m_Key = null;
					num = (int)((num2 * 801517543) ^ 0x526B72F2);
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 1809293948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30F2C8A5u) % 3u)
				{
				case 1u:
					goto IL_0016;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0016:
				m_Node = aNode;
				m_Key = aKey;
				num = (int)(num2 * 422471276) ^ -1875900928;
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		if (m_Key == null)
		{
			goto IL_0057;
		}
		goto IL_00b0;
		IL_00b0:
		m_Node.Add(m_Key, aVal);
		int num = 1434877148;
		goto IL_007a;
		IL_007a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x283F5B91u) % 9u)
			{
			case 8u:
				num = (int)((num2 * 477889595) ^ 0xCB3B5C9);
				continue;
			case 6u:
				num = (int)(num2 * 798068610) ^ -648159903;
				continue;
			case 4u:
				m_Node = null;
				num = 450939428;
				continue;
			case 3u:
				m_Node.Add(aVal);
				num = (int)((num2 * 467413815) ^ 0x6D0785C);
				continue;
			case 2u:
				break;
			case 1u:
				num = (int)((num2 * 1441700173) ^ 0x1EE02E3C);
				continue;
			case 0u:
				num = (int)(num2 * 171594511) ^ -1023402964;
				continue;
			default:
				return;
			case 7u:
				goto IL_00b0;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0057;
		IL_0057:
		num = 957708920;
		goto IL_007a;
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = new JSONArray();
		while (true)
		{
			int num = 1596696465;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11D7B6F3u) % 4u)
				{
				case 2u:
					jSONArray.Add(aItem);
					num = (int)((num2 * 1281256550) ^ 0x457ECB96);
					continue;
				case 1u:
					Set(jSONArray);
					num = (int)((num2 * 702572295) ^ 0x7447FCDC);
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
			int num = 1921383083;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BC320D1u) % 4u)
				{
				case 2u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 1224338402) ^ 0x2DFE2C20);
					continue;
				case 1u:
					Set(jSONClass);
					num = (int)((num2 * 214413708) ^ 0x57683F89);
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 114522504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97A79C6u) % 7u)
				{
				case 6u:
					result = true;
					num = ((int)num2 * -2124094738) ^ 0x585ED525;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (b != null)
					{
						num3 = -1923619392;
						num4 = -1923619392;
					}
					else
					{
						num3 = -1494688623;
						num4 = -1494688623;
					}
					num = num3 ^ ((int)num2 * -1635113895);
					continue;
				}
				case 3u:
					num = ((int)num2 * -368134001) ^ 0x1941C956;
					continue;
				case 2u:
					num = ((int)num2 * -10626968) ^ -151994155;
					continue;
				case 1u:
					result = (object)a == b;
					num = 733147804;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 172881488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E29C204u) % 3u)
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
				num = ((int)num2 * -261239797) ^ -1046695797;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool flag = obj == null;
		bool result = default(bool);
		while (true)
		{
			int num = -888602859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A322903u) % 6u)
				{
				case 4u:
					result = true;
					num = ((int)num2 * -1099908530) ^ 0x7A1952B6;
					continue;
				case 3u:
					num = (int)(num2 * 2118701911) ^ -1720710463;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1481623787;
						num4 = 1481623787;
					}
					else
					{
						num3 = 1911998218;
						num4 = 1911998218;
					}
					num = num3 ^ ((int)num2 * -1091512971);
					continue;
				}
				case 1u:
					result = (object)this == obj;
					num = -742479146;
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
			int num = -429605566;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DFE7E19u) % 3u)
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
				num = (int)(num2 * 867079213) ^ -331331732;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -454470687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA2C4600u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 634858516) ^ 0x7AA3D28A);
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -1641518313) ^ -1515702580;
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
			int num = -810162390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED19F97Fu) % 4u)
				{
				case 1u:
					result = "";
					num = (int)((num2 * 597662134) ^ 0x32B84B61);
					continue;
				case 0u:
					num = ((int)num2 * -1912348720) ^ 0x6F65092D;
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
