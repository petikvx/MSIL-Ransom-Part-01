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
				int num = -261795701;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C649FACu) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1272468531) ^ -1457870937;
						continue;
					case 0u:
						num = (int)((num2 * 1816767690) ^ 0x2E03D8B5);
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
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			Set(jSONArray);
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1421134441;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x62EB2C52u) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1487582300) ^ -1017764681;
						continue;
					case 1u:
						num = (int)((num2 * 2077206843) ^ 0x14516FC7);
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
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = 345920109;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x442688C7u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1743838244) ^ 0x56A62F2);
						continue;
					case 2u:
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 191933405) ^ 0xF7569A6);
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
				int num = 1082936676;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B0B1B17u) % 5u)
					{
					case 4u:
						Set(aVal);
						num = ((int)num2 * -1507327084) ^ 0x64B9812C;
						continue;
					case 2u:
						num = ((int)num2 * -1445723564) ^ -727120506;
						continue;
					case 1u:
						result = 0;
						num = (int)(num2 * 1414086900) ^ -788727038;
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
			while (true)
			{
				int num = 566800438;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2880C0ECu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -810768712) ^ 0x11D9C935;
						continue;
					case 2u:
						Set(aVal);
						num = (int)(num2 * 120901357) ^ -512362319;
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
			JSONData aVal = default(JSONData);
			float result = default(float);
			while (true)
			{
				int num = 387183088;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A2AC6ADu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -95266946) ^ -1974175236;
						continue;
					case 5u:
						aVal = new JSONData(0f);
						num = ((int)num2 * -783084506) ^ 0x79E909D8;
						continue;
					case 4u:
						result = 0f;
						num = (int)(num2 * 174235503) ^ -812686404;
						continue;
					case 2u:
						num = ((int)num2 * -1864138401) ^ -1405118001;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1896309730) ^ -184615989;
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
				int num = -877030276;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9CA14E1u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = (int)(num2 * 1149194850) ^ -2006384362;
						continue;
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -875012060) ^ 0x60F5161B;
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
			double result = default(double);
			while (true)
			{
				int num = -1559201723;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6B8D2B3u) % 4u)
					{
					case 2u:
						result = 0.0;
						num = (int)(num2 * 1695565852) ^ -1496046530;
						continue;
					case 1u:
						num = (int)(num2 * 677632836) ^ -102714773;
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
				int num = 912454838;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BD0FE42u) % 3u)
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
					num = ((int)num2 * -499189734) ^ -1275683629;
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
				int num = 1611831401;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6336361Cu) % 7u)
					{
					case 6u:
						aVal = new JSONData(aData: false);
						num = (int)((num2 * 1538311202) ^ 0x70202F03);
						continue;
					case 5u:
						num = (int)((num2 * 623013972) ^ 0x352D4CB2);
						continue;
					case 4u:
						num = ((int)num2 * -1288820785) ^ -1577805538;
						continue;
					case 2u:
						Set(aVal);
						num = ((int)num2 * -361647807) ^ -1528643413;
						continue;
					case 0u:
						result = false;
						num = (int)(num2 * 1199357756) ^ -1457121009;
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
				int num = -934696158;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB87D3240u) % 4u)
					{
					case 2u:
						jSONArray = new JSONArray();
						Set(jSONArray);
						num = ((int)num2 * -928051976) ^ 0xFF3E299;
						continue;
					case 1u:
						result = jSONArray;
						num = (int)(num2 * 1672740762) ^ -1152880410;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1825175486;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D16D9AAu) % 6u)
					{
					case 5u:
						result = jSONClass;
						num = (int)((num2 * 623533969) ^ 0x43AB5190);
						continue;
					case 4u:
						jSONClass = new JSONClass();
						num = ((int)num2 * -920636137) ^ -919071036;
						continue;
					case 3u:
						num = ((int)num2 * -1102229866) ^ -1472653723;
						continue;
					case 0u:
						Set(jSONClass);
						num = ((int)num2 * -1087336513) ^ 0x2507C7A9;
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

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = 1208043675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x385E4F8Du) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1449450844) ^ 0x432FBE4C;
					continue;
				case 1u:
					m_Node = aNode;
					num = (int)(num2 * 558424334) ^ -1470080941;
					continue;
				case 3u:
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
		while (true)
		{
			int num = 1110198715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77469FD4u) % 6u)
				{
				case 5u:
					m_Key = aKey;
					num = ((int)num2 * -63023012) ^ 0x6A59F0F7;
					continue;
				case 4u:
					m_Node = aNode;
					num = ((int)num2 * -1526406481) ^ -890100095;
					continue;
				case 2u:
					num = (int)(num2 * 242800773) ^ -91420200;
					continue;
				case 1u:
					num = (int)(num2 * 1660191978) ^ -180994344;
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

	private void Set(JSONNode aVal)
	{
		bool flag = m_Key == null;
		while (true)
		{
			int num = 46878076;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DC7945Fu) % 12u)
				{
				case 11u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1659505611;
						num4 = -1659505611;
					}
					else
					{
						num3 = -799850217;
						num4 = -799850217;
					}
					num = num3 ^ (int)(num2 * 106053514);
					continue;
				}
				case 10u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1053529595) ^ -1122764942;
					continue;
				case 9u:
					num = ((int)num2 * -1160963974) ^ 0x99EAD61;
					continue;
				case 8u:
					m_Node = null;
					num = 434988728;
					continue;
				case 6u:
					num = (int)(num2 * 259855740) ^ -1924712973;
					continue;
				case 4u:
					num = (int)((num2 * 159882863) ^ 0x5CBF90CF);
					continue;
				case 3u:
					num = ((int)num2 * -750455177) ^ -994817072;
					continue;
				case 2u:
					num = (int)((num2 * 11845912) ^ 0x616EEADD);
					continue;
				case 1u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 2020897025) ^ 0x18431C6B);
					continue;
				case 0u:
					num = 1943157438;
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
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
			int num = -1126239824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1D66285u) % 5u)
				{
				case 4u:
					Set(jSONArray);
					num = ((int)num2 * -1598954453) ^ 0x577B0DAB;
					continue;
				case 3u:
					jSONArray.Add(aItem);
					num = ((int)num2 * -1393535126) ^ 0x1BFD777D;
					continue;
				case 1u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -1989013680) ^ -1978123637;
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
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = 731386856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4819D900u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				jSONClass.Add(aKey, aItem);
				Set(jSONClass);
				num = ((int)num2 * -240176263) ^ 0xE1FCA9D;
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 201188387;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x747D05C9u) % 7u)
				{
				case 6u:
					result = (object)a == b;
					num = 1460157555;
					continue;
				case 5u:
					flag = b == null;
					num = ((int)num2 * -349433202) ^ 0x4FD66C99;
					continue;
				case 3u:
					num = (int)((num2 * 150270445) ^ 0x31CA5A81);
					continue;
				case 1u:
					result = true;
					num = ((int)num2 * -1548855567) ^ -1263701190;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 802811293;
						num4 = 802811293;
					}
					else
					{
						num3 = 1169280316;
						num4 = 1169280316;
					}
					num = num3 ^ ((int)num2 * -1544253171);
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -142962285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDDD460Eu) % 3u)
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
				num = (int)(num2 * 1472299366) ^ -1421724299;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -520418855;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF10B4EF4u) % 6u)
				{
				case 4u:
					result = true;
					num = ((int)num2 * -1958444387) ^ 0x317E21A2;
					continue;
				case 3u:
					result = (object)this == obj;
					num = -1892983173;
					continue;
				case 2u:
					num = ((int)num2 * -1580836778) ^ 0x15390CB;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (obj != null)
					{
						num3 = 1352142778;
						num4 = 1352142778;
					}
					else
					{
						num3 = 2092571609;
						num4 = 2092571609;
					}
					num = num3 ^ (int)(num2 * 686162599);
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

	public override int GetHashCode()
	{
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = -1004435851;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x815CBD19u) % 3u)
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
				num = ((int)num2 * -94066059) ^ 0x2F9401EB;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -927865591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C8DE320u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2002995063) ^ 0x295EBFCA;
					continue;
				case 1u:
					result = "";
					num = (int)(num2 * 962153066) ^ -2094365064;
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

	public override string ToString(string aPrefix)
	{
		return "";
	}
}
