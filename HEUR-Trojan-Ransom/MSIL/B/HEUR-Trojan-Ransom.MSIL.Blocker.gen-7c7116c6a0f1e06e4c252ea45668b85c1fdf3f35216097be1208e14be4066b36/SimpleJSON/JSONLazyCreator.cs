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
			JSONArray jSONArray = default(JSONArray);
			while (true)
			{
				int num = -748818483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1C92158u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -824591004) ^ 0x54AB1848;
						continue;
					case 3u:
						jSONArray.Add(value);
						num = ((int)num2 * -1861293777) ^ -1382434841;
						continue;
					case 2u:
						Set(jSONArray);
						num = ((int)num2 * -1378491338) ^ 0x7389FD29;
						continue;
					case 1u:
						jSONArray = new JSONArray();
						num = ((int)num2 * -879941879) ^ 0x4007C7DA;
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

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -2006399526;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFF887D3u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1080282069) ^ -64413550;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = ((int)num2 * -2015075712) ^ 0x352EF420;
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
				int num = -1272559238;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCB25A91u) % 5u)
					{
					case 2u:
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -242672136) ^ -1211407104;
						continue;
					case 1u:
						num = (int)(num2 * 602216373) ^ -1736355463;
						continue;
					case 0u:
						Set(jSONClass);
						num = ((int)num2 * -115836557) ^ -1529179741;
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
				int num = 690023443;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x59162246u) % 4u)
					{
					case 3u:
						Set(aVal);
						result = 0;
						num = (int)((num2 * 707652133) ^ 0x3E095007);
						continue;
					case 1u:
						aVal = new JSONData(0);
						num = (int)((num2 * 1612438721) ^ 0x3A69AA64);
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
			while (true)
			{
				int num = -227027477;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x962DCB0Au) % 3u)
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
					num = ((int)num2 * -127302671) ^ -893481609;
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
				int num = -504673137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFC291AEDu) % 4u)
					{
					case 2u:
					{
						JSONData aVal = new JSONData(0f);
						Set(aVal);
						result = 0f;
						num = ((int)num2 * -58760052) ^ 0x48547F78;
						continue;
					}
					case 1u:
						num = (int)(num2 * 177955275) ^ -745020787;
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
				int num = 974737247;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11BF00A2u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -530856863) ^ -457843637;
						continue;
					case 1u:
						Set(aVal);
						num = ((int)num2 * -1383935636) ^ -524204943;
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

	public override double AsDouble
	{
		get
		{
			double result = default(double);
			while (true)
			{
				int num = 772594696;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x276B775Eu) % 4u)
					{
					case 3u:
						result = 0.0;
						num = ((int)num2 * -468213544) ^ 0x3BCE1747;
						continue;
					case 2u:
					{
						JSONData aVal = new JSONData(0.0);
						Set(aVal);
						num = (int)(num2 * 1168002242) ^ -1124366791;
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
			JSONData aVal = new JSONData(value);
			Set(aVal);
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
				int num = -750465063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x850B9D4Cu) % 4u)
					{
					case 3u:
						result = false;
						num = ((int)num2 * -297382952) ^ 0x1F83EB10;
						continue;
					case 1u:
						Set(aVal);
						num = (int)(num2 * 1666165863) ^ -1607804736;
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
				int num = -938093943;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF24524D2u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1932392786) ^ 0x40DC862A;
						continue;
					case 3u:
						result = jSONArray;
						num = ((int)num2 * -1409689738) ^ -713748267;
						continue;
					case 2u:
						num = (int)(num2 * 440538687) ^ -1929579699;
						continue;
					case 1u:
						Set(jSONArray);
						num = ((int)num2 * -1945022388) ^ 0x485A14BA;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = new JSONClass();
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 260420665;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3EC881F4u) % 4u)
					{
					case 2u:
						result = jSONClass;
						num = (int)(num2 * 1417389571) ^ -777617606;
						continue;
					case 1u:
						Set(jSONClass);
						num = ((int)num2 * -222380623) ^ -767451357;
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
			int num = -1173239156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEE084B5u) % 4u)
				{
				case 1u:
					m_Node = aNode;
					num = ((int)num2 * -1972412292) ^ 0x74125491;
					continue;
				case 0u:
					m_Key = aKey;
					num = (int)(num2 * 825172497) ^ -722437817;
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
			int num = 1893829395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x128278DCu) % 11u)
				{
				case 9u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1662847117;
						num4 = 1662847117;
					}
					else
					{
						num3 = 958537511;
						num4 = 958537511;
					}
					num = num3 ^ ((int)num2 * -362692119);
					continue;
				}
				case 8u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 1858100698) ^ 0x56D8DD67);
					continue;
				case 7u:
					flag = m_Key == null;
					num = (int)((num2 * 1835973138) ^ 0x6A3FE230);
					continue;
				case 6u:
					num = 872521695;
					continue;
				case 5u:
					m_Node = null;
					num = 1865747004;
					continue;
				case 4u:
					num = ((int)num2 * -1036599696) ^ -727359155;
					continue;
				case 3u:
					m_Node.Add(aVal);
					num = ((int)num2 * -378461635) ^ -138423269;
					continue;
				case 2u:
					num = (int)(num2 * 290450493) ^ -1477056716;
					continue;
				case 1u:
					num = ((int)num2 * -1677135679) ^ -1426085007;
					continue;
				default:
					return;
				case 10u:
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
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 515248334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22D30767u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					Set(jSONArray);
					return;
				}
				break;
				IL_0003:
				jSONArray = new JSONArray();
				jSONArray.Add(aItem);
				num = ((int)num2 * -1691374306) ^ 0xC4911A3;
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 791650635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2147E85Au) % 5u)
				{
				case 4u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -362520428) ^ 0x3217310E;
					continue;
				case 3u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1340073011) ^ 0x31E76B1;
					continue;
				case 1u:
					Set(jSONClass);
					num = ((int)num2 * -759647174) ^ 0x34AFD98B;
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 640355869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D354A6Au) % 8u)
				{
				case 7u:
					flag = b == null;
					num = ((int)num2 * -1476926348) ^ -1053266619;
					continue;
				case 6u:
					result = (object)a == b;
					num = 271759963;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1656655458;
						num4 = 1656655458;
					}
					else
					{
						num3 = 533491974;
						num4 = 533491974;
					}
					num = num3 ^ (int)(num2 * 1056932674);
					continue;
				}
				case 2u:
					result = true;
					num = (int)(num2 * 1740005074) ^ -1403379890;
					continue;
				case 1u:
					num = ((int)num2 * -641323281) ^ -755393904;
					continue;
				case 0u:
					num = ((int)num2 * -1998148039) ^ 0x12623DFF;
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
			int num = 1179809781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76A3D824u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -976299880) ^ 0x68C3ABF4;
					continue;
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -496974389) ^ 0x7235D8E1;
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
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -103169148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9CD9997u) % 7u)
				{
				case 6u:
					result = (object)this == obj;
					num = -1823408006;
					continue;
				case 5u:
					num = (int)((num2 * 973872252) ^ 0x6F2D3E36);
					continue;
				case 4u:
					result = true;
					num = ((int)num2 * -689044048) ^ 0x3AC4F0CA;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -719973212;
						num4 = -719973212;
					}
					else
					{
						num3 = -1236860303;
						num4 = -1236860303;
					}
					num = num3 ^ (int)(num2 * 997690378);
					continue;
				}
				case 2u:
					flag = obj == null;
					num = ((int)num2 * -787022867) ^ -285141890;
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
			int num = 65191304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x786FD4A8u) % 3u)
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
				num = ((int)num2 * -688984342) ^ -479183743;
			}
		}
	}

	public override string ToString()
	{
		string result = "";
		while (true)
		{
			int num = 247996928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x638FB170u) % 3u)
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
				num = (int)(num2 * 1472304360) ^ -1296711285;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		return "";
	}
}
