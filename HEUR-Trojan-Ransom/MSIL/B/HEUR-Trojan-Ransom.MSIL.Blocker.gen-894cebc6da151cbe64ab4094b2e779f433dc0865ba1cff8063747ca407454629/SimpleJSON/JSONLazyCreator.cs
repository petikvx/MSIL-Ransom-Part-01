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
				int num = 175285996;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40836B6u) % 3u)
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
					num = ((int)num2 * -1937833208) ^ -1613907673;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 1290152203;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE49A8E0u) % 4u)
					{
					case 3u:
						jSONArray = new JSONArray();
						num = (int)(num2 * 41126173) ^ -895101725;
						continue;
					case 0u:
						jSONArray.Add(value);
						num = ((int)num2 * -1239387681) ^ -1146357319;
						continue;
					case 2u:
						break;
					default:
						Set(jSONArray);
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
				int num = 420303994;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A72DC84u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1719160027) ^ 0x54C5B3B4);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -202330112) ^ 0x1F4200AF;
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
				int num = 57090383;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x333B3F36u) % 5u)
					{
					case 3u:
						Set(jSONClass);
						num = ((int)num2 * -1078452794) ^ 0x260EE1B;
						continue;
					case 1u:
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 732666122) ^ -1032708109;
						continue;
					case 0u:
						num = (int)((num2 * 884998611) ^ 0x1395FF7A);
						continue;
					default:
						return;
					case 2u:
						break;
					case 4u:
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
				int num = -1754876586;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8228C8CBu) % 6u)
					{
					case 5u:
						result = 0;
						num = ((int)num2 * -1772791374) ^ -1819086050;
						continue;
					case 4u:
						Set(aVal);
						num = ((int)num2 * -2091642881) ^ -1973909545;
						continue;
					case 3u:
						aVal = new JSONData(0);
						num = ((int)num2 * -1057098719) ^ -1405355474;
						continue;
					case 2u:
						num = (int)((num2 * 533787647) ^ 0x19776668);
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
				int num = -1233239624;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81A72805u) % 4u)
					{
					case 1u:
						aVal = new JSONData(value);
						num = ((int)num2 * -207829250) ^ -983725349;
						continue;
					case 0u:
						Set(aVal);
						num = (int)(num2 * 1610434613) ^ -619811357;
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
	}

	public override float AsFloat
	{
		get
		{
			JSONData aVal = new JSONData(0f);
			float result = default(float);
			while (true)
			{
				int num = 1000343784;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5DBD363Eu) % 3u)
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
					Set(aVal);
					result = 0f;
					num = ((int)num2 * -182449298) ^ -1162309731;
				}
			}
		}
		set
		{
			JSONData aVal = new JSONData(value);
			while (true)
			{
				int num = -1731841756;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB45B4BB3u) % 4u)
					{
					case 3u:
						Set(aVal);
						num = ((int)num2 * -1045931925) ^ -810109910;
						continue;
					case 0u:
						num = ((int)num2 * -50234044) ^ 0x707BF8EE;
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = new JSONData(0.0);
			double result = default(double);
			while (true)
			{
				int num = 1042597856;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x327FBE69u) % 4u)
					{
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1148780873) ^ -496259724;
						continue;
					case 0u:
						result = 0.0;
						num = (int)(num2 * 473914625) ^ -766711829;
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
			while (true)
			{
				int num = -490654285;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFB95252u) % 4u)
					{
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1365854714) ^ 0xCF98340;
						continue;
					case 0u:
						num = (int)((num2 * 1334189052) ^ 0x47F1484);
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
	}

	public override bool AsBool
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1813598554;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB3EE1827u) % 4u)
					{
					case 1u:
					{
						JSONData aVal = new JSONData(aData: false);
						Set(aVal);
						num = ((int)num2 * -2029530205) ^ 0x79307BC4;
						continue;
					}
					case 0u:
						result = false;
						num = (int)(num2 * 288550899) ^ -908028200;
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
			while (true)
			{
				int num = -1694770658;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D08AF88u) % 3u)
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
					num = (int)((num2 * 493781516) ^ 0x36B549CB);
				}
			}
		}
	}

	public override JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -2101013966;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9EF1BADFu) % 3u)
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
					JSONArray jSONArray = new JSONArray();
					Set(jSONArray);
					result = jSONArray;
					num = (int)(num2 * 618901068) ^ -747645265;
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
				int num = 1428969371;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C5C9FB2u) % 5u)
					{
					case 3u:
						result = jSONClass;
						num = ((int)num2 * -1745922569) ^ -15342327;
						continue;
					case 1u:
						num = (int)((num2 * 719205896) ^ 0x59E1F8E);
						continue;
					case 0u:
						num = ((int)num2 * -700082529) ^ -157436330;
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

	public JSONLazyCreator(JSONNode aNode)
	{
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 1350977180;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64923A0Fu) % 3u)
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
				num = (int)((num2 * 1666297349) ^ 0xF2C469E);
			}
		}
	}

	private void Set(JSONNode aVal)
	{
		bool flag = m_Key == null;
		while (true)
		{
			int num = -1002746362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8836CE71u) % 11u)
				{
				case 10u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -974334265;
						num4 = -974334265;
					}
					else
					{
						num3 = -674091922;
						num4 = -674091922;
					}
					num = num3 ^ ((int)num2 * -1261512530);
					continue;
				}
				case 9u:
					m_Node = null;
					num = -1234974762;
					continue;
				case 8u:
					num = (int)(num2 * 1456665558) ^ -649420466;
					continue;
				case 6u:
					num = ((int)num2 * -504163121) ^ 0x359AB974;
					continue;
				case 5u:
					num = -508015253;
					continue;
				case 3u:
					num = ((int)num2 * -814356963) ^ -248664022;
					continue;
				case 2u:
					num = (int)(num2 * 465187297) ^ -779526784;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = ((int)num2 * -638459612) ^ 0x45A93858;
					continue;
				case 0u:
					m_Node.Add(m_Key, aVal);
					num = ((int)num2 * -163744766) ^ 0x4F884D2F;
					continue;
				default:
					return;
				case 7u:
					break;
				case 4u:
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
			int num = 649824875;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C1649E9u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1430696685) ^ -296458780;
					continue;
				case 3u:
					Set(jSONArray);
					num = ((int)num2 * -1351507939) ^ 0x7CBC9ADD;
					continue;
				case 2u:
					jSONArray.Add(aItem);
					num = (int)((num2 * 1755844164) ^ 0x12A6F7DE);
					continue;
				case 1u:
					num = ((int)num2 * -875095575) ^ -37812619;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = new JSONClass();
		while (true)
		{
			int num = 517740219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C2C5C7u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					Set(jSONClass);
					return;
				}
				break;
				IL_0008:
				jSONClass.Add(aKey, aItem);
				num = (int)((num2 * 1816260004) ^ 0x3A5787BB);
			}
		}
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = 765223656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49D81636u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1713783865) ^ -824199999;
					continue;
				case 3u:
					result = (object)a == b;
					num = 425435346;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1450903319;
						num4 = 1450903319;
					}
					else
					{
						num3 = 136044141;
						num4 = 136044141;
					}
					num = num3 ^ (int)(num2 * 1338909597);
					continue;
				}
				case 1u:
					result = true;
					num = (int)((num2 * 178765947) ^ 0x1BF0D4C0);
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
			int num = -915210812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADC0ADEEu) % 4u)
				{
				case 2u:
					result = !(a == b);
					num = (int)(num2 * 72326955) ^ -200912339;
					continue;
				case 1u:
					num = ((int)num2 * -1721261175) ^ -1521848789;
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
		if (obj == null)
		{
			goto IL_0017;
		}
		goto IL_0065;
		IL_0065:
		bool result = (object)this == obj;
		int num = -1145056058;
		goto IL_003c;
		IL_003c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xC2C8FCD5u) % 6u)
			{
			case 5u:
				num = ((int)num2 * -654747167) ^ -1458439640;
				continue;
			case 3u:
				break;
			case 1u:
				result = true;
				num = (int)(num2 * 656407027) ^ -1922746912;
				continue;
			case 0u:
				num = (int)((num2 * 1013048853) ^ 0x2F22AB55);
				continue;
			case 2u:
				goto IL_0065;
			default:
				return result;
			}
			break;
		}
		goto IL_0017;
		IL_0017:
		num = -154467900;
		goto IL_003c;
	}

	public override int GetHashCode()
	{
		int hashCode = default(int);
		while (true)
		{
			int num = -303660439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5289D3Fu) % 4u)
				{
				case 2u:
					hashCode = base.GetHashCode();
					num = ((int)num2 * -1671916360) ^ 0x2C6345A2;
					continue;
				case 1u:
					num = (int)(num2 * 893888007) ^ -438249388;
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
			int num = 550999696;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78E986B8u) % 3u)
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
				num = ((int)num2 * -967770391) ^ -141275795;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 867811956;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A0B76ECu) % 3u)
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
				num = (int)((num2 * 944806829) ^ 0x3500148D);
			}
		}
	}
}
