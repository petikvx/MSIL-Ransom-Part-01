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
				int num = 380421820;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BC926Du) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -434497672) ^ 0xF75AB34;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -1457160592;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82437D41u) % 5u)
					{
					case 2u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -815158542) ^ 0xB76252E;
						continue;
					case 1u:
						jSONArray.Add(value);
						Set(jSONArray);
						num = (int)(num2 * 1307968093) ^ -1705241877;
						continue;
					case 0u:
						num = (int)((num2 * 1146837166) ^ 0x2DD46E15);
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 415766886;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D50F5CBu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 659826163) ^ 0x7432023E);
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = (int)(num2 * 332612202) ^ -1451747718;
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
			JSONClass jSONClass = new JSONClass();
			while (true)
			{
				int num = 1860047228;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1CBB54AEu) % 6u)
					{
					case 4u:
						num = ((int)num2 * -1603752171) ^ 0x2AF21A44;
						continue;
					case 2u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 262141390) ^ -1508120610;
						continue;
					case 1u:
						num = ((int)num2 * -1004132920) ^ -2081340207;
						continue;
					case 0u:
						Set(jSONClass);
						num = ((int)num2 * -209058041) ^ -753724851;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
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
				int num = 970163795;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25DFB3EFu) % 5u)
					{
					case 3u:
						Set(aVal);
						num = (int)((num2 * 1730122148) ^ 0x314E88E9);
						continue;
					case 2u:
						result = 0;
						num = (int)(num2 * 873129648) ^ -417694410;
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = ((int)num2 * -1701797062) ^ 0x4F831EB8;
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
				int num = -1841067253;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x80079A94u) % 4u)
					{
					case 3u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -1648932578) ^ 0x1B4E3D4F;
						continue;
					}
					case 1u:
						num = ((int)num2 * -780647836) ^ -1282402238;
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

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			Set(aVal);
			float result = default(float);
			while (true)
			{
				int num = 816283909;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x32EA8913u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1894533470) ^ -1137309280;
						continue;
					case 2u:
						result = 0f;
						num = (int)(num2 * 991899213) ^ -320367466;
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
				int num = -1417591489;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE4F5A4Au) % 4u)
					{
					case 1u:
						aVal = new JSONData(value);
						num = (int)((num2 * 1017555854) ^ 0x7049D218);
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 1353910933) ^ 0x7B9D0171);
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
	}

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = 901093221;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42809671u) % 6u)
					{
					case 4u:
						Set(aVal);
						num = ((int)num2 * -766995241) ^ 0x371233F1;
						continue;
					case 3u:
						result = 0.0;
						num = ((int)num2 * -1194850380) ^ -1438035172;
						continue;
					case 1u:
						num = (int)((num2 * 243562313) ^ 0x51264EC0);
						continue;
					case 0u:
						num = ((int)num2 * -1583752690) ^ 0x4FB56568;
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
			while (true)
			{
				int num = 80287166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64EE76AFu) % 3u)
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
					num = ((int)num2 * -1141624098) ^ -12992537;
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
				int num = 39146393;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36B113CBu) % 5u)
					{
					case 3u:
						num = (int)(num2 * 1861993656) ^ -1101422949;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1316695275) ^ 0x1932BA8E;
						continue;
					case 0u:
						result = false;
						num = ((int)num2 * -688842685) ^ 0x148944A4;
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
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1228950820;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x537ADAE2u) % 4u)
					{
					case 2u:
						Set(jSONArray);
						num = (int)((num2 * 1907139335) ^ 0x661DB2D1);
						continue;
					case 1u:
						result = jSONArray;
						num = (int)(num2 * 1148215181) ^ -1225098477;
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
			JSONClass jSONClass = default(JSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 2011776293;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C632B6Eu) % 5u)
					{
					case 4u:
						jSONClass = new JSONClass();
						Set(jSONClass);
						num = (int)((num2 * 529331038) ^ 0x5DF9D09F);
						continue;
					case 3u:
						num = (int)(num2 * 92997934) ^ -997552833;
						continue;
					case 2u:
						result = jSONClass;
						num = ((int)num2 * -625122762) ^ 0x8378BEA;
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
			int num = 503438652;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50E2FDF7u) % 6u)
				{
				case 4u:
					m_Key = null;
					num = ((int)num2 * -1797198875) ^ -1186897427;
					continue;
				case 3u:
					num = (int)(num2 * 1086119346) ^ -337161952;
					continue;
				case 2u:
					m_Node = aNode;
					num = (int)((num2 * 1405690238) ^ 0x6C2D02BD);
					continue;
				case 1u:
					num = ((int)num2 * -933662779) ^ -128219840;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
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
		bool flag = m_Key == null;
		while (true)
		{
			int num = -458236403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBF359DCu) % 10u)
				{
				case 8u:
					m_Node.Add(m_Key, aVal);
					num = -422401393;
					continue;
				case 7u:
					num = (int)((num2 * 24023839) ^ 0x56337A89);
					continue;
				case 6u:
					num = (int)((num2 * 222870253) ^ 0x457682C9);
					continue;
				case 5u:
					m_Node = null;
					num = -157631256;
					continue;
				case 4u:
					m_Node.Add(aVal);
					num = ((int)num2 * -2014671158) ^ -38721782;
					continue;
				case 3u:
					num = ((int)num2 * -446582958) ^ -1750302790;
					continue;
				case 2u:
					num = ((int)num2 * -480843401) ^ -13391345;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1771404763;
						num4 = 1771404763;
					}
					else
					{
						num3 = 1885472106;
						num4 = 1885472106;
					}
					num = num3 ^ ((int)num2 * -248859967);
					continue;
				}
				default:
					return;
				case 9u:
					break;
				case 0u:
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
			int num = -1506886338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD65CA261u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 752532112) ^ -1129146020;
					continue;
				case 1u:
					Set(jSONArray);
					num = ((int)num2 * -1931427305) ^ -1310604568;
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
			int num = 1685618436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D503A88u) % 7u)
				{
				case 6u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -644040243) ^ -236642661;
					continue;
				case 5u:
					Set(jSONClass);
					num = ((int)num2 * -1323883502) ^ 0x1B733FFF;
					continue;
				case 3u:
					num = ((int)num2 * -1422091110) ^ -1602956445;
					continue;
				case 2u:
					num = ((int)num2 * -831606452) ^ 0x5523078F;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -394531638) ^ -1038862974;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1040959131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD826A59u) % 6u)
				{
				case 3u:
					num = ((int)num2 * -943482396) ^ -1482654528;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (b != null)
					{
						num3 = 848582275;
						num4 = 848582275;
					}
					else
					{
						num3 = 813784640;
						num4 = 813784640;
					}
					num = num3 ^ ((int)num2 * -1194826816);
					continue;
				}
				case 1u:
					result = true;
					num = (int)((num2 * 1185616403) ^ 0x3040D437);
					continue;
				case 0u:
					result = (object)a == b;
					num = 1038432282;
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
		bool result = default(bool);
		while (true)
		{
			int num = 1592094203;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F1198C8u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = ((int)num2 * -909414395) ^ -921635359;
					continue;
				case 2u:
					num = ((int)num2 * -129860828) ^ -108503559;
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

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1110331016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE886A71Bu) % 8u)
				{
				case 6u:
					result = (object)this == obj;
					num = -1374093609;
					continue;
				case 5u:
					num = (int)(num2 * 2076289035) ^ -371207741;
					continue;
				case 4u:
					num = ((int)num2 * -93208993) ^ 0x760448A0;
					continue;
				case 3u:
					flag = obj == null;
					num = ((int)num2 * -493009340) ^ 0x2397B25;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -310622329;
						num4 = -310622329;
					}
					else
					{
						num3 = -1131139520;
						num4 = -1131139520;
					}
					num = num3 ^ (int)(num2 * 494440361);
					continue;
				}
				case 1u:
					result = true;
					num = (int)(num2 * 454966994) ^ -1983396996;
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
		int hashCode = base.GetHashCode();
		while (true)
		{
			int num = 145208504;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22EBDB75u) % 3u)
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
				num = ((int)num2 * -1204165756) ^ -653910085;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1169722876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D253E26u) % 4u)
				{
				case 2u:
					result = "";
					num = (int)(num2 * 96697350) ^ -657920621;
					continue;
				case 1u:
					num = (int)((num2 * 1481775244) ^ 0x5C1EE5BE);
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
		string result = default(string);
		while (true)
		{
			int num = -1400605873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA4619D6u) % 3u)
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
				num = (int)((num2 * 1771275929) ^ 0x5FE3BF36);
			}
		}
	}
}
