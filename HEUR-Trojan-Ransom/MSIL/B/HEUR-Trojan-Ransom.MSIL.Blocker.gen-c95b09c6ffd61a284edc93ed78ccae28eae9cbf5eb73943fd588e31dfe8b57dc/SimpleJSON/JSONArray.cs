using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON;

public class JSONArray : JSONNode, IEnumerable
{
	private List<JSONNode> m_List = new List<JSONNode>();

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = -789708088;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xC75FA55Cu) % 9u)
					{
					case 8u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -821082874) ^ 0x46396B90;
							continue;
						}
						num5 = 1;
						goto IL_001d;
					case 7u:
						result = m_List[aIndex];
						num = -405900028;
						continue;
					case 6u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -2124807847) ^ -1759129664;
						continue;
					case 5u:
						num = ((int)num2 * -1113478045) ^ 0x7CCCDA65;
						continue;
					case 4u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_001d;
					case 3u:
						num = (int)(num2 * 1063773786) ^ -1560553793;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 100246057;
							num4 = 100246057;
						}
						else
						{
							num3 = 1853734057;
							num4 = 1853734057;
						}
						num = num3 ^ ((int)num2 * -1686688903);
						continue;
					}
					case 2u:
						break;
					default:
						{
							return result;
						}
						IL_001d:
						flag = (byte)num5 != 0;
						num = -1593933040;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1519426473;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x43BF581u) % 9u)
					{
					case 8u:
						m_List.Add(value);
						num = ((int)num2 * -170497784) ^ -251145081;
						continue;
					case 7u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1966838670) ^ 0x3A82C438;
							continue;
						}
						num5 = 1;
						goto IL_0038;
					case 6u:
						num = ((int)num2 * -1891654417) ^ -953992490;
						continue;
					case 4u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0038;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1159771935;
							num4 = -1159771935;
						}
						else
						{
							num3 = -990540566;
							num4 = -990540566;
						}
						num = num3 ^ (int)(num2 * 1951561222);
						continue;
					}
					case 2u:
						num = (int)(num2 * 645460748) ^ -1684006628;
						continue;
					case 0u:
						m_List[aIndex] = value;
						num = 885522233;
						continue;
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
						IL_0038:
						flag = (byte)num5 != 0;
						num = 1560338320;
						continue;
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
				int num = 251560043;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x127C46Du) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -98440065) ^ -598872066;
						continue;
					case 1u:
						num = ((int)num2 * -2027108352) ^ 0x344FA089;
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
				int num = -1862448646;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE8D1D7E5u) % 4u)
					{
					case 3u:
						m_List.Add(value);
						num = (int)(num2 * 227850995) ^ -1829749830;
						continue;
					case 2u:
						num = (int)(num2 * 2023745920) ^ -750834040;
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

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -252545003;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE8A8624u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -715725599) ^ 0x754596F5;
						continue;
					case 1u:
						count = m_List.Count;
						num = ((int)num2 * -2063598717) ^ -419745247;
						continue;
					case 0u:
						break;
					default:
						return count;
					}
					break;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0050;
		}
		int num = 1;
		goto IL_00a0;
		IL_008f:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00a0;
		IL_0050:
		int num2 = 194009415;
		goto IL_0066;
		IL_0066:
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x12E6AC02u) % 6u)
			{
			case 5u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 542791662;
					num5 = 542791662;
				}
				else
				{
					num4 = 1648514534;
					num5 = 1648514534;
				}
				num2 = num4 ^ ((int)num3 * -1297826680);
				continue;
			}
			case 4u:
			{
				JSONNode jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				result = jSONNode;
				num2 = 1976331119;
				continue;
			}
			case 2u:
				break;
			case 0u:
				result = null;
				num2 = (int)(num3 * 2088276363) ^ -1297239757;
				continue;
			case 1u:
				goto IL_008f;
			default:
				return result;
			}
			break;
		}
		goto IL_0050;
		IL_00a0:
		flag = (byte)num != 0;
		num2 = 674906813;
		goto IL_0066;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1109006540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93ED5E03u) % 4u)
				{
				case 3u:
					result = aNode;
					num = ((int)num2 * -773533933) ^ -1652426982;
					continue;
				case 0u:
					num = ((int)num2 * -1015346865) ^ 0x591EF692;
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

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumerator_003Ed__14(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_00ea:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -626986160;
					num2 = -626986160;
				}
				else
				{
					num = -1763675753;
					num2 = -1763675753;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xA58C1D4Du) % 8u)
					{
					case 7u:
						num = -626986160;
						continue;
					case 6u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -1220019799;
						continue;
					case 5u:
						current = enumerator.Current;
						num = -1985278787;
						continue;
					case 4u:
						num = ((int)num3 * -305606051) ^ 0x102B2488;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -660315939) ^ -2104316188;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) <= 2)
						{
							num4 = -2095946997;
							num5 = -2095946997;
						}
						else
						{
							num4 = -445499754;
							num5 = -445499754;
						}
						num = num4 ^ (int)(num3 * 114282621);
						continue;
					}
					default:
						goto end_IL_00a9;
					case 1u:
						break;
					case 2u:
						goto end_IL_00a9;
					}
					goto IL_00ea;
					continue;
					end_IL_00a9:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = default(string);
		while (true)
		{
			int num6 = -96830066;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xA58C1D4Du) % 3u)
				{
				case 1u:
					goto IL_0116;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0116:
				result = string_;
				num6 = (int)(num3 * 235319328) ^ -1517956051;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			bool flag = default(bool);
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_0138:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1699955033;
					num2 = 1699955033;
				}
				else
				{
					num = 300871572;
					num2 = 300871572;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x42E7E4D6u) % 10u)
					{
					case 9u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -251341438;
							num5 = -251341438;
						}
						else
						{
							num4 = -116150715;
							num5 = -116150715;
						}
						num = num4 ^ ((int)num3 * -1011954989);
						continue;
					}
					case 8u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = 714287287;
						continue;
					case 7u:
						current = enumerator.Current;
						num = 530700192;
						continue;
					case 5u:
						num = (int)(num3 * 14367288) ^ -802004888;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 489158665) ^ -1628423879;
						continue;
					case 2u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = (int)((num3 * 1401228543) ^ 0x70DFF129);
						continue;
					case 1u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = ((int)num3 * -305732890) ^ -426747861;
						continue;
					case 0u:
						num = 1699955033;
						continue;
					default:
						goto end_IL_00ee;
					case 6u:
						break;
					case 4u:
						goto end_IL_00ee;
					}
					goto IL_0138;
					continue;
					end_IL_00ee:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num6 = 998044587;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x42E7E4D6u) % 4u)
				{
				case 3u:
					num6 = (int)(num3 * 2062308057) ^ -1756048639;
					continue;
				case 1u:
					result = string_;
					num6 = (int)((num3 * 1574595111) ^ 0x1FB38E86);
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -1248273425;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDCB9766u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1748421709) ^ -753452166;
					continue;
				case 8u:
					flag = num3 < m_List.Count;
					num = -1516766373;
					continue;
				case 7u:
					num = (int)((num2 * 1232221231) ^ 0x44A7B301);
					continue;
				case 5u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 20093285) ^ -1871493147;
					continue;
				case 4u:
					m_List[num3].Serialize(aWriter);
					num = -824426009;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1188749152;
						num5 = 1188749152;
					}
					else
					{
						num4 = 610621928;
						num5 = 610621928;
					}
					num = num4 ^ ((int)num2 * -890138972);
					continue;
				}
				case 2u:
					num3 = 0;
					num = ((int)num2 * -1433717338) ^ 0x16F1C585;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1228532469) ^ -1353648633;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public JSONArray()
	{
		while (true)
		{
			int num = -396903755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1318C0Eu) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0013:
				num = ((int)num2 * -1499466296) ^ -1529204231;
			}
		}
	}

	static int smethod_30(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_31(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_32(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_33(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_34(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_35(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}
}
