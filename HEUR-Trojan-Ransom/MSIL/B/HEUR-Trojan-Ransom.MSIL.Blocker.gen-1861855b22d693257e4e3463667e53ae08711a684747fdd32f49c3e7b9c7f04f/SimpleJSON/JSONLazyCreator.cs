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
				int num = 470450990;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D44334Cu) % 3u)
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
					num = ((int)num2 * -51316894) ^ -886349276;
				}
			}
		}
		set
		{
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = 785060367;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3788FCD6u) % 4u)
					{
					case 3u:
						jSONArray.Add(value);
						Set(jSONArray);
						num = (int)((num2 * 1973927280) ^ 0x31518CF8);
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = (int)((num2 * 405114193) ^ 0x3648B34C);
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1433543852;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x539057A9u) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = (int)((num2 * 422365293) ^ 0x30C99BF);
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 1711020840;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x56473BD1u) % 6u)
					{
					case 5u:
						Set(jSONClass);
						num = (int)((num2 * 530472621) ^ 0x20E6D43C);
						continue;
					case 3u:
						jSONClass = new JSONClass();
						jSONClass.Add(aKey, value);
						num = (int)(num2 * 145242609) ^ -967276943;
						continue;
					case 2u:
						num = ((int)num2 * -597776822) ^ 0x1F414C61;
						continue;
					case 1u:
						num = ((int)num2 * -1293171570) ^ -1054290360;
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

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 1023237660;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B4E1CAFu) % 6u)
					{
					case 5u:
						result = 0;
						num = (int)(num2 * 1010660454) ^ -429209299;
						continue;
					case 3u:
						num = (int)(num2 * 250719181) ^ -446127111;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = (int)(num2 * 415554204) ^ -1955219020;
						continue;
					}
					case 0u:
						num = ((int)num2 * -1485980626) ^ 0x58207AA9;
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
				int num = 874513905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3111D1DFu) % 5u)
					{
					case 4u:
						Set(aVal);
						num = (int)(num2 * 23825499) ^ -334794177;
						continue;
					case 2u:
						aVal = new JSONData(value);
						num = (int)(num2 * 89719094) ^ -891893846;
						continue;
					case 1u:
						num = ((int)num2 * -654421937) ^ -1116559154;
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

	public override float AsFloat
	{
		get
		{
			JSONData aVal = default(JSONData);
			float result = default(float);
			while (true)
			{
				int num = 1640723330;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81DE5A8u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 1353258000) ^ 0x7D429AF4);
						continue;
					case 4u:
						aVal = new JSONData(0f);
						num = (int)((num2 * 39493951) ^ 0x4A467BFD);
						continue;
					case 3u:
						result = 0f;
						num = ((int)num2 * -1056899229) ^ -1996535546;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1630190524) ^ -325122333;
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
			JSONData aVal = new JSONData(0.0);
			Set(aVal);
			double result = default(double);
			while (true)
			{
				int num = 341051132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2724D8A8u) % 3u)
					{
					case 1u:
						goto IL_0018;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0018:
					result = 0.0;
					num = ((int)num2 * -1619347648) ^ -846639467;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -567827877;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC60B6819u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 110729384) ^ 0x531A29F4);
						continue;
					case 2u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -1967294267) ^ 0x502395C4;
						continue;
					}
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
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = 1759833760;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58FE3CBDu) % 7u)
					{
					case 5u:
						num = ((int)num2 * -1429396777) ^ 0x222ACE8C;
						continue;
					case 4u:
						num = (int)(num2 * 1154605189) ^ -1379790372;
						continue;
					case 3u:
						aVal = new JSONData(aData: false);
						num = (int)((num2 * 1232410541) ^ 0x4ED0870A);
						continue;
					case 1u:
						result = false;
						num = ((int)num2 * -1988544192) ^ 0x18A20805;
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 397945473) ^ 0x5F1F2752);
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
		set
		{
			while (true)
			{
				int num = 486880993;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52C8BDD3u) % 3u)
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
					num = ((int)num2 * -1095628615) ^ -33770437;
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
				int num = 1640083973;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6367F319u) % 5u)
					{
					case 4u:
						result = jSONArray;
						num = ((int)num2 * -1918774943) ^ 0x604D4FE1;
						continue;
					case 1u:
						Set(jSONArray);
						num = (int)(num2 * 694234596) ^ -720185822;
						continue;
					case 0u:
						num = ((int)num2 * -1399932056) ^ 0x63B5E87B;
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
			Set(jSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 86905962;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2C32C5E5u) % 4u)
					{
					case 3u:
						result = jSONClass;
						num = ((int)num2 * -1163285330) ^ -673997485;
						continue;
					case 0u:
						num = (int)((num2 * 442736262) ^ 0x5264136C);
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
			int num = 1333360930;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D8A8EDFu) % 4u)
				{
				case 2u:
					m_Key = null;
					num = ((int)num2 * -560398747) ^ 0x59E47229;
					continue;
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -1126977204) ^ 0x162A5195;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 1243209540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EA9E9FDu) % 4u)
				{
				case 1u:
					m_Node = aNode;
					num = (int)((num2 * 1778802774) ^ 0x13E11193);
					continue;
				case 0u:
					m_Key = aKey;
					num = (int)((num2 * 17453716) ^ 0x553D7D4F);
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

	private void Set(JSONNode aVal)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -420069622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD2E253Eu) % 10u)
				{
				case 8u:
					num = (int)(num2 * 1537597967) ^ -2128612185;
					continue;
				case 7u:
					num = (int)(num2 * 873600851) ^ -176145057;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 622659250;
						num4 = 622659250;
					}
					else
					{
						num3 = 455331476;
						num4 = 455331476;
					}
					num = num3 ^ ((int)num2 * -1925958778);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1502595520) ^ -179032419;
					continue;
				case 4u:
					flag = m_Key == null;
					num = ((int)num2 * -2028152277) ^ -142479510;
					continue;
				case 2u:
					m_Node.Add(m_Key, aVal);
					num = -2081293649;
					continue;
				case 1u:
					num = (int)(num2 * 934532821) ^ -1232149946;
					continue;
				case 0u:
					m_Node.Add(aVal);
					num = (int)((num2 * 670195788) ^ 0x3F00A0D1);
					continue;
				case 3u:
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
		JSONArray jSONArray = new JSONArray();
		jSONArray.Add(aItem);
		Set(jSONArray);
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -649104383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFC4C224u) % 4u)
				{
				case 3u:
					Set(jSONClass);
					num = (int)(num2 * 152308778) ^ -763099176;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -46973517) ^ 0x1F4D0494;
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
		bool flag = b == null;
		bool result = default(bool);
		while (true)
		{
			int num = -1055454905;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86B23401u) % 7u)
				{
				case 5u:
					result = (object)a == b;
					num = -1790921587;
					continue;
				case 3u:
					num = (int)((num2 * 308865692) ^ 0x106FE09D);
					continue;
				case 2u:
					result = true;
					num = ((int)num2 * -43041294) ^ -488900331;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1230934486;
						num4 = -1230934486;
					}
					else
					{
						num3 = -623552520;
						num4 = -623552520;
					}
					num = num3 ^ ((int)num2 * -56794533);
					continue;
				}
				case 0u:
					num = (int)(num2 * 47619943) ^ -1425075151;
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
			int num = 1727383042;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D83BC9u) % 3u)
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
				num = ((int)num2 * -280883523) ^ -806371702;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1671788768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2BBEBE1Cu) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1756102577) ^ -678725832;
					continue;
				case 4u:
					result = (object)this == obj;
					num = 155408687;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -933150937;
						num4 = -933150937;
					}
					else
					{
						num3 = -858107122;
						num4 = -858107122;
					}
					num = num3 ^ ((int)num2 * -712914429);
					continue;
				}
				case 1u:
					flag = obj == null;
					num = (int)(num2 * 92034858) ^ -2125181199;
					continue;
				case 0u:
					result = true;
					num = ((int)num2 * -1119015636) ^ -564091239;
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
			int num = 2083538675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11E7DB38u) % 4u)
				{
				case 3u:
					hashCode = base.GetHashCode();
					num = (int)((num2 * 1198106101) ^ 0x12495ABD);
					continue;
				case 2u:
					num = ((int)num2 * -774760346) ^ -722179647;
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
		string result = default(string);
		while (true)
		{
			int num = 1610881638;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5844B722u) % 3u)
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
				result = "";
				num = ((int)num2 * -1046376936) ^ 0x1B4E2102;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		return "";
	}
}
