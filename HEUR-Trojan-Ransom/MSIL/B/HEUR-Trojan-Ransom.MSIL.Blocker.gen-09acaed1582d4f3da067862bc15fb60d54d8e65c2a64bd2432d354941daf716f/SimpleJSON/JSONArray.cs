using System;
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
				int num = 978355475;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x718F4149u) % 9u)
					{
					case 8u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -127615606) ^ -864071242;
							continue;
						}
						num5 = 1;
						goto IL_001d;
					case 6u:
						result = m_List[aIndex];
						num = 1147550037;
						continue;
					case 5u:
						num = ((int)num2 * -569868163) ^ 0x2D2B3683;
						continue;
					case 4u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_001d;
					case 3u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 525718032) ^ -4744942;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1303055891;
							num4 = -1303055891;
						}
						else
						{
							num3 = -1386086625;
							num4 = -1386086625;
						}
						num = num3 ^ (int)(num2 * 262948261);
						continue;
					}
					case 1u:
						num = ((int)num2 * -1428834271) ^ 0x4CA2CD64;
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_001d:
						flag = (byte)num5 != 0;
						num = 1955649072;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0025;
			}
			int num = 1;
			goto IL_00af;
			IL_00af:
			bool flag = (byte)num != 0;
			int num2 = 1408044022;
			goto IL_0071;
			IL_0025:
			num2 = 1379091879;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3F6BDA09u) % 7u)
				{
				case 6u:
					m_List.Add(value);
					num2 = ((int)num3 * -1555986293) ^ -1566788208;
					continue;
				case 5u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 835594407;
						num5 = 835594407;
					}
					else
					{
						num4 = 2120829868;
						num5 = 2120829868;
					}
					num2 = num4 ^ ((int)num3 * -732670735);
					continue;
				}
				case 2u:
					num2 = ((int)num3 * -340864043) ^ -627370624;
					continue;
				case 0u:
					m_List[aIndex] = value;
					num2 = 1509468003;
					continue;
				default:
					return;
				case 3u:
					goto IL_009e;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0025;
			IL_009e:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00af;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -559501405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC236A9CFu) % 3u)
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
					num = (int)(num2 * 1219069631) ^ -969312829;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -592242053;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8F87510u) % 4u)
					{
					case 3u:
						m_List.Add(value);
						num = (int)((num2 * 1694122946) ^ 0x7526154B);
						continue;
					case 1u:
						num = ((int)num2 * -676525378) ^ 0x3A8CF4D4;
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

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -516124422;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA3D21CEu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_List.Count;
					num = (int)((num2 * 1128124944) ^ 0x64CF2706);
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
		if (aIndex < 0)
		{
			goto IL_000a;
		}
		goto IL_0068;
		IL_0068:
		int num = -1959256031;
		goto IL_006d;
		IL_006d:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8E036E6Au) % 7u)
			{
			case 5u:
				result = jSONNode;
				num = ((int)num2 * -514818055) ^ -714461174;
				continue;
			case 4u:
				m_List.RemoveAt(aIndex);
				num = ((int)num2 * -2043267777) ^ 0x42BB5215;
				continue;
			case 3u:
				jSONNode = m_List[aIndex];
				num = -1462024594;
				continue;
			case 2u:
				result = null;
				num = ((int)num2 * -321506209) ^ -1630598905;
				continue;
			case 0u:
				break;
			case 6u:
				goto IL_009a;
			default:
				return result;
			}
			break;
			IL_009a:
			if (aIndex < m_List.Count)
			{
				num = -263910702;
				num3 = -263910702;
				continue;
			}
			goto IL_000a;
		}
		goto IL_0068;
		IL_000a:
		num = -148088272;
		num3 = -148088272;
		goto IL_006d;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -389990624;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE03BA26Au) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1752522492) ^ 0x93AD86B);
					continue;
				case 2u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -900448767) ^ -1461246829;
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
			bool flag = default(bool);
			while (true)
			{
				IL_0104:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 498377245;
					num2 = 498377245;
				}
				else
				{
					num = 1822617118;
					num2 = 1822617118;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x5E6088FBu) % 9u)
					{
					case 8u:
						num = (int)(num3 * 1774245568) ^ -1726749980;
						continue;
					case 7u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = 1771832281;
						continue;
					case 5u:
						current = enumerator.Current;
						num = 1299024671;
						continue;
					case 4u:
						flag = JSONArray.smethod_30(string_) > 2;
						num = ((int)num3 * -5745884) ^ -1411670230;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 850318119;
							num5 = 850318119;
						}
						else
						{
							num4 = 183442638;
							num5 = 183442638;
						}
						num = num4 ^ ((int)num3 * -2103117759);
						continue;
					}
					case 1u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 463790752) ^ -1541788253;
						continue;
					case 0u:
						num = 498377245;
						continue;
					default:
						goto end_IL_00be;
					case 6u:
						break;
					case 2u:
						goto end_IL_00be;
					}
					goto IL_0104;
					continue;
					end_IL_00be:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = string_;
		while (true)
		{
			int num6 = 1075966819;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x5E6088FBu) % 3u)
				{
				case 1u:
					goto IL_0133;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0133:
				num6 = ((int)num3 * -1131622201) ^ -1313293390;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_00f6:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -529033880;
					num2 = -529033880;
				}
				else
				{
					num = -786467750;
					num2 = -786467750;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xEE67A37Eu) % 7u)
					{
					case 6u:
						num = -529033880;
						continue;
					case 5u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = -466686522;
						continue;
					case 4u:
						current = enumerator.Current;
						num = -327033722;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -695661163) ^ -1003141110;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) > 3)
						{
							num4 = 1676764915;
							num5 = 1676764915;
						}
						else
						{
							num4 = 1318027835;
							num5 = 1318027835;
						}
						num = num4 ^ ((int)num3 * -1773956126);
						continue;
					}
					default:
						goto end_IL_00b9;
					case 1u:
						break;
					case 2u:
						goto end_IL_00b9;
					}
					goto IL_00f6;
					continue;
					end_IL_00b9:
					break;
				}
				break;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
			while (true)
			{
				IL_0141:
				int num6 = -1867894710;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xEE67A37Eu) % 3u)
					{
					case 2u:
						goto IL_0115;
					default:
						goto end_IL_0123;
					case 0u:
						break;
					case 1u:
						goto end_IL_0123;
					}
					goto IL_0141;
					IL_0115:
					num6 = (int)((num3 * 721734028) ^ 0x39AA4BB3);
					continue;
					end_IL_0123:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num7 = -1404165861;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xEE67A37Eu) % 4u)
				{
				case 1u:
					result = string_;
					num7 = ((int)num3 * -2113248992) ^ -665631694;
					continue;
				case 0u:
					num7 = ((int)num3 * -883540442) ^ -1616425771;
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
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1078508658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26A4DA83u) % 10u)
				{
				case 9u:
					m_List[num5].Serialize(aWriter);
					num = 491903649;
					continue;
				case 8u:
					num5++;
					num = ((int)num2 * -886142417) ^ 0x79778053;
					continue;
				case 7u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 1282675742) ^ -1839510240;
					continue;
				case 4u:
					num = (int)((num2 * 138921748) ^ 0x7CD63C66);
					continue;
				case 3u:
					num5 = 0;
					num = (int)(num2 * 1435091887) ^ -1993228154;
					continue;
				case 2u:
					flag = num5 < m_List.Count;
					num = 1098913613;
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)(num2 * 1427121851) ^ -1167795882;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1988487134;
						num4 = 1988487134;
					}
					else
					{
						num3 = 955414201;
						num4 = 955414201;
					}
					num = num3 ^ (int)(num2 * 371783292);
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 6u:
					return;
				}
				break;
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
