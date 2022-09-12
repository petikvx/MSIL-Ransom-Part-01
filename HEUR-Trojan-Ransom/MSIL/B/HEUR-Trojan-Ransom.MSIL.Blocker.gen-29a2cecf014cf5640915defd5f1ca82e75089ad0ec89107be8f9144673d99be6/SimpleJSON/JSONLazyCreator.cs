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
				int num = 267190955;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C6A57BFu) % 3u)
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
					result = new JSONLazyCreator(this);
					num = ((int)num2 * -953371491) ^ -1974323782;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(value);
			while (true)
			{
				int num = 1711634913;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x70EC142Bu) % 3u)
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
					num = (int)((num2 * 1122624852) ^ 0x7D8F152E);
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
				int num = -1672073266;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92E034CFu) % 4u)
					{
					case 2u:
						num = (int)(num2 * 2040854188) ^ -164728816;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -1993191018) ^ -261644165;
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
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = -737072011;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xABA5C735u) % 5u)
					{
					case 3u:
						num = (int)((num2 * 1597437831) ^ 0x16CCFE6E);
						continue;
					case 2u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1584828275) ^ 0x43BB0ACB;
						continue;
					case 1u:
						jSONClass = new JSONClass();
						num = (int)((num2 * 1321253677) ^ 0x4DDB6C3C);
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
			JSONData aVal = default(JSONData);
			int result = default(int);
			while (true)
			{
				int num = 2053442342;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x171538F8u) % 4u)
					{
					case 3u:
						Set(aVal);
						result = 0;
						num = ((int)num2 * -833088450) ^ -2062681601;
						continue;
					case 2u:
						aVal = new JSONData(0);
						num = ((int)num2 * -1347854084) ^ -1660504677;
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
				int num = -431321549;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAF0F9539u) % 3u)
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
					num = (int)((num2 * 285187548) ^ 0x557207AA);
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
				int num = 811180840;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C170B62u) % 4u)
					{
					case 2u:
						Set(aVal);
						num = ((int)num2 * -531604289) ^ -1960545759;
						continue;
					case 1u:
						result = 0f;
						num = (int)((num2 * 123520200) ^ 0x70AB0C36);
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
			while (true)
			{
				int num = -1874034252;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0D9315Au) % 3u)
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
					num = (int)((num2 * 522066527) ^ 0x2F84BD0E);
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
				int num = 143271408;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69644A92u) % 4u)
					{
					case 2u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1584970102) ^ 0x1261A3F7;
						continue;
					case 1u:
						Set(aVal);
						result = 0.0;
						num = (int)(num2 * 45083610) ^ -1395278965;
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

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 396742756;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C32CE84u) % 5u)
					{
					case 4u:
						num = (int)(num2 * 2012157400) ^ -1442676494;
						continue;
					case 3u:
						Set(aVal);
						result = false;
						num = ((int)num2 * -1487930935) ^ 0x59BE0744;
						continue;
					case 1u:
						aVal = new JSONData(aData: false);
						num = (int)(num2 * 536192985) ^ -104403828;
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
				int num = -241008262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9910C17Du) % 4u)
					{
					case 3u:
						aVal = new JSONData(value);
						num = (int)((num2 * 1215192842) ^ 0x454E763B);
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 449215962) ^ 0x79E86F1C);
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			Set(jSONArray);
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1940594110;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE47B4537u) % 4u)
					{
					case 1u:
						result = jSONArray;
						num = (int)(num2 * 1536120514) ^ -1303648975;
						continue;
					case 0u:
						num = (int)((num2 * 666657189) ^ 0xE70838);
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
				int num = 407693633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D6D4C64u) % 5u)
					{
					case 4u:
						result = jSONClass;
						num = ((int)num2 * -1814792972) ^ 0x12D5017;
						continue;
					case 2u:
						Set(jSONClass);
						num = ((int)num2 * -1719681337) ^ -615543298;
						continue;
					case 0u:
						num = (int)((num2 * 153697939) ^ 0x6A478517);
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
			int num = 1374110205;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C80213Bu) % 4u)
				{
				case 3u:
					m_Node = aNode;
					num = ((int)num2 * -1033975785) ^ -791923441;
					continue;
				case 2u:
					num = (int)(num2 * 1288476456) ^ -2015388588;
					continue;
				case 0u:
					break;
				default:
					m_Key = aKey;
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
			int num = -2044087193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB08DF2BDu) % 13u)
				{
				case 12u:
					m_Node.Add(aVal);
					num = (int)(num2 * 1823286064) ^ -1106534226;
					continue;
				case 11u:
					num = (int)(num2 * 624320443) ^ -1731808859;
					continue;
				case 10u:
					num = (int)((num2 * 719241883) ^ 0x31B1A23A);
					continue;
				case 9u:
					num = ((int)num2 * -503818165) ^ -1884782086;
					continue;
				case 8u:
					num = -254283380;
					continue;
				case 7u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 444308318) ^ 0x17484EAA);
					continue;
				case 6u:
					num = ((int)num2 * -833015346) ^ 0x4D8C3555;
					continue;
				case 5u:
					m_Node = null;
					num = -601937747;
					continue;
				case 3u:
					flag = m_Key == null;
					num = ((int)num2 * -192445269) ^ -158003454;
					continue;
				case 1u:
					num = ((int)num2 * -1056943930) ^ -1951671383;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1959272192;
						num4 = 1959272192;
					}
					else
					{
						num3 = 1823825181;
						num4 = 1823825181;
					}
					num = num3 ^ (int)(num2 * 1266296498);
					continue;
				}
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
			int num = 1518684409;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E2A8103u) % 6u)
				{
				case 5u:
					jSONArray.Add(aItem);
					num = (int)((num2 * 923183554) ^ 0x46DCA0F5);
					continue;
				case 4u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 404512767) ^ 0x5458EB94);
					continue;
				case 1u:
					num = ((int)num2 * -203994679) ^ -646969764;
					continue;
				case 0u:
					Set(jSONArray);
					num = (int)(num2 * 1866484989) ^ -2073142286;
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
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1020955321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE410D368u) % 6u)
				{
				case 5u:
					jSONClass = new JSONClass();
					num = (int)(num2 * 1053532654) ^ -273180350;
					continue;
				case 3u:
					Set(jSONClass);
					num = (int)((num2 * 865691565) ^ 0x491B8AF5);
					continue;
				case 2u:
					num = (int)((num2 * 1247206954) ^ 0x2758546B);
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 1311395678) ^ 0x27CD4E83);
					continue;
				default:
					return;
				case 4u:
					break;
				case 1u:
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
			int num = -483407385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACD18D1Eu) % 6u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (b == null)
					{
						num3 = -1144288846;
						num4 = -1144288846;
					}
					else
					{
						num3 = -1331781941;
						num4 = -1331781941;
					}
					num = num3 ^ (int)(num2 * 921439035);
					continue;
				}
				case 3u:
					result = true;
					num = (int)(num2 * 1985849716) ^ -1238247660;
					continue;
				case 2u:
					num = (int)((num2 * 992995497) ^ 0x1029FD25);
					continue;
				case 0u:
					result = (object)a == b;
					num = -1190597229;
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
			int num = 1519739742;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F8867Eu) % 3u)
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
				num = ((int)num2 * -597254956) ^ 0x128B5703;
			}
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			goto IL_0006;
		}
		goto IL_0050;
		IL_0050:
		bool result = (object)this == obj;
		int num = -203476248;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDD46B632u) % 5u)
			{
			case 2u:
				break;
			case 1u:
				result = true;
				num = (int)(num2 * 640314260) ^ -547010068;
				continue;
			case 0u:
				num = ((int)num2 * -681600250) ^ 0x7CCCE4B4;
				continue;
			case 3u:
				goto IL_0050;
			default:
				return result;
			}
			break;
		}
		goto IL_0006;
		IL_0006:
		num = -559068585;
		goto IL_002b;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = 530438477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A411A58u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -174354053) ^ 0x71DDA0C7;
					continue;
				case 1u:
					hashCode = base.GetHashCode();
					num = (int)((num2 * 1233338225) ^ 0x9F70E1A);
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
		string result = default(string);
		while (true)
		{
			int num = 678467305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x479EB524u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2073330454) ^ -1106007034;
					continue;
				case 1u:
					result = "";
					num = ((int)num2 * -1767194611) ^ 0x10D4F876;
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
