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
				int num = 769041553;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x32141120u) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = ((int)num2 * -1474225163) ^ -1252156573;
						continue;
					case 3u:
						jSONArray.Add(value);
						num = ((int)num2 * -1868349304) ^ -1731870766;
						continue;
					case 0u:
						num = (int)((num2 * 28187767) ^ 0x862E35F);
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this, aKey);
			while (true)
			{
				int num = 1690481159;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x450761A0u) % 3u)
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
					num = (int)(num2 * 1525958804) ^ -53004477;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -1296497769;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFEAE8830u) % 6u)
					{
					case 4u:
						Set(jSONClass);
						num = (int)(num2 * 196720240) ^ -1801725903;
						continue;
					case 3u:
						jSONClass = new JSONClass();
						jSONClass.Add(aKey, value);
						num = (int)((num2 * 1893838417) ^ 0xC24EA77);
						continue;
					case 1u:
						num = ((int)num2 * -2077535052) ^ 0x19706E68;
						continue;
					case 0u:
						num = ((int)num2 * -1120334078) ^ 0x5C2CC3BA;
						continue;
					default:
						return;
					case 5u:
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 96463453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D14B7DCu) % 6u)
					{
					case 5u:
						num = (int)(num2 * 161321746) ^ -945592791;
						continue;
					case 3u:
						result = 0;
						num = ((int)num2 * -1478593360) ^ -929380830;
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = (int)(num2 * 391999200) ^ -193914054;
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -1315173552) ^ -1053887939;
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
			while (true)
			{
				int num = -65090609;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE376B99u) % 3u)
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
					num = (int)(num2 * 421929770) ^ -1890774552;
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
				int num = 1770972109;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x78A586A4u) % 5u)
					{
					case 4u:
						result = 0f;
						num = (int)((num2 * 542115423) ^ 0x386B882);
						continue;
					case 3u:
						num = (int)(num2 * 266854271) ^ -757508103;
						continue;
					case 1u:
						Set(aVal);
						num = (int)((num2 * 1640116544) ^ 0x3F06ADE3);
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
				int num = 1412756723;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68950740u) % 3u)
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
					num = ((int)num2 * -1037497947) ^ 0x1CDBC77F;
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
				int num = 674243732;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D12841Au) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1078458058) ^ 0x59260DC9;
						continue;
					case 2u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -809422457) ^ -626566817;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1915142976) ^ -933654164;
						continue;
					case 0u:
						result = 0.0;
						num = ((int)num2 * -811703860) ^ -1343279069;
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
			while (true)
			{
				int num = -1958752442;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D996401u) % 3u)
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
					num = ((int)num2 * -747269189) ^ -1839959348;
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
				int num = -457641981;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98282954u) % 7u)
					{
					case 5u:
						num = ((int)num2 * -586722226) ^ 0x48E4427F;
						continue;
					case 3u:
						num = ((int)num2 * -997974333) ^ -191906479;
						continue;
					case 2u:
						aVal = new JSONData(aData: false);
						num = (int)((num2 * 1105756736) ^ 0x5FD555F6);
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 168750817) ^ -1177281814;
						continue;
					case 0u:
						result = false;
						num = (int)(num2 * 1655469323) ^ -1491165935;
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
			while (true)
			{
				int num = -778332872;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB3DE5938u) % 3u)
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
					num = ((int)num2 * -277207863) ^ -853704090;
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
				int num = -1118523519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED2211D7u) % 5u)
					{
					case 4u:
						Set(jSONArray);
						num = (int)((num2 * 1628976081) ^ 0x6BC3DCD1);
						continue;
					case 2u:
						result = jSONArray;
						num = (int)(num2 * 1730639459) ^ -635901383;
						continue;
					case 0u:
						num = ((int)num2 * -1177866114) ^ -241080913;
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
			JSONClass jSONClass = new JSONClass();
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -2107492173;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD11B698u) % 6u)
					{
					case 5u:
						Set(jSONClass);
						num = (int)(num2 * 59953792) ^ -1077888513;
						continue;
					case 3u:
						num = ((int)num2 * -1847357203) ^ -1633695615;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -768030162) ^ 0xD3107BF;
						continue;
					case 1u:
						num = ((int)num2 * -1818055654) ^ -811397094;
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
			int num = 1216663390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7132221Fu) % 4u)
				{
				case 1u:
					num = ((int)num2 * -1679006150) ^ 0x21653285;
					continue;
				case 0u:
					m_Node = aNode;
					m_Key = aKey;
					num = ((int)num2 * -178653804) ^ 0x72EC3BB0;
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

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = -641849943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8FA93CBu) % 8u)
				{
				case 7u:
					m_Node.Add(aVal);
					num = ((int)num2 * -114322353) ^ -2042922037;
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = -253648776;
					continue;
				case 5u:
					num = (int)((num2 * 2099888604) ^ 0x2056BBC0);
					continue;
				case 3u:
					num = (int)((num2 * 1270039310) ^ 0x5A455A4D);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (m_Key == null)
					{
						num3 = -661167884;
						num4 = -661167884;
					}
					else
					{
						num3 = -1038974129;
						num4 = -1038974129;
					}
					num = num3 ^ (int)(num2 * 1246551381);
					continue;
				}
				case 1u:
					num = (int)(num2 * 249749191) ^ -113733928;
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
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 290726194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33BEA961u) % 4u)
				{
				case 3u:
					jSONArray = new JSONArray();
					jSONArray.Add(aItem);
					num = (int)((num2 * 1756123543) ^ 0xF06CA9D);
					continue;
				case 1u:
					Set(jSONArray);
					num = (int)(num2 * 1665351457) ^ -1760382618;
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
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 172705498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2408B8ACu) % 4u)
				{
				case 2u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -596165923) ^ 0x8EA434B;
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					Set(jSONClass);
					num = ((int)num2 * -913699307) ^ -813364019;
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
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 833662300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7934EF39u) % 6u)
				{
				case 5u:
					flag = b == null;
					num = (int)(num2 * 1481156973) ^ -2038799328;
					continue;
				case 4u:
					result = true;
					num = ((int)num2 * -1341115054) ^ -1040206776;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2008827371;
						num4 = -2008827371;
					}
					else
					{
						num3 = -1511134659;
						num4 = -1511134659;
					}
					num = num3 ^ (int)(num2 * 50814269);
					continue;
				}
				case 0u:
					result = (object)a == b;
					num = 499855984;
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

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 808891666;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72700037u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 242153178) ^ -1876740871;
					continue;
				case 1u:
					result = !(a == b);
					num = (int)(num2 * 1239365246) ^ -195079386;
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

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 469189129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B0CFB70u) % 7u)
				{
				case 5u:
					result = (object)this == obj;
					num = 541366785;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -1832174726) ^ -1857814866;
					continue;
				case 2u:
					flag = obj == null;
					num = (int)((num2 * 1492988890) ^ 0x5AA47E58);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1849595666;
						num4 = 1849595666;
					}
					else
					{
						num3 = 324238461;
						num4 = 324238461;
					}
					num = num3 ^ (int)(num2 * 1728358683);
					continue;
				}
				case 0u:
					num = (int)(num2 * 1592497369) ^ -1244923207;
					continue;
				case 6u:
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
			int num = -1724044121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9349720Du) % 4u)
				{
				case 2u:
					hashCode = base.GetHashCode();
					num = (int)(num2 * 602165740) ^ -1849214244;
					continue;
				case 1u:
					num = ((int)num2 * -1649573829) ^ 0x760A0526;
					continue;
				case 3u:
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
		string result = "";
		while (true)
		{
			int num = -1436288445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAB437C3u) % 3u)
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
				num = (int)(num2 * 588256814) ^ -885776307;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1362309337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FA883BFu) % 4u)
				{
				case 2u:
					result = "";
					num = (int)((num2 * 235551307) ^ 0x1D159BC);
					continue;
				case 1u:
					num = (int)((num2 * 351506743) ^ 0x61B08CD8);
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
