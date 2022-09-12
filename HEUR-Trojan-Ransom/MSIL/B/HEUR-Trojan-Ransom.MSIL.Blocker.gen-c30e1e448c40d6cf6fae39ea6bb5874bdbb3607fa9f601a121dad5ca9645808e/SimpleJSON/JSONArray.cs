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
			if (aIndex >= 0)
			{
				goto IL_001e;
			}
			int num = 1;
			goto IL_00bd;
			IL_00ac:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00bd;
			IL_001e:
			int num2 = -2085775835;
			goto IL_007b;
			IL_007b:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA2C7350Cu) % 8u)
				{
				case 6u:
					result = m_List[aIndex];
					num2 = -1807394434;
					continue;
				case 5u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1524028226;
						num5 = -1524028226;
					}
					else
					{
						num4 = -357847525;
						num5 = -357847525;
					}
					num2 = num4 ^ (int)(num3 * 1559771515);
					continue;
				}
				case 3u:
					result = new JSONLazyCreator(this);
					num2 = (int)(num3 * 1352809569) ^ -1233244745;
					continue;
				case 2u:
					num2 = (int)((num3 * 1261175192) ^ 0x6B4CE95B);
					continue;
				case 0u:
					num2 = (int)(num3 * 14753278) ^ -1921226005;
					continue;
				case 1u:
					goto IL_00ac;
				default:
					return result;
				}
				break;
			}
			goto IL_001e;
			IL_00bd:
			flag = (byte)num != 0;
			num2 = -1318535960;
			goto IL_007b;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_000a;
			}
			int num = 1;
			goto IL_00af;
			IL_00af:
			bool flag = (byte)num != 0;
			int num2 = -440776477;
			goto IL_0071;
			IL_000a:
			num2 = -1774515874;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD01E7B21u) % 7u)
				{
				case 4u:
					break;
				case 3u:
					m_List.Add(value);
					num2 = (int)((num3 * 1914032072) ^ 0x7ADDB8AA);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1080201585;
						num5 = 1080201585;
					}
					else
					{
						num4 = 1017606802;
						num5 = 1017606802;
					}
					num2 = num4 ^ (int)(num3 * 1998965388);
					continue;
				}
				case 1u:
					m_List[aIndex] = value;
					num2 = -2104080323;
					continue;
				case 0u:
					num2 = (int)(num3 * 1691877756) ^ -842706935;
					continue;
				default:
					return;
				case 6u:
					goto IL_009e;
				case 5u:
					return;
				}
				break;
			}
			goto IL_000a;
			IL_009e:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00af;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -1116118487;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE653BEF8u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -195593640) ^ -1025117746;
				}
			}
		}
		set
		{
			m_List.Add(value);
		}
	}

	public override int Count
	{
		get
		{
			int count = m_List.Count;
			while (true)
			{
				int num = -324319082;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC89CB3C3u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = (int)(num2 * 3432803) ^ -2036186133;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 383451128;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x59F9E77Au) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 459736004) ^ -1817144581;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 2074697923) ^ -128851118;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 697110262;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x57777CF4u) % 10u)
				{
				case 9u:
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = (int)(num2 * 1899896916) ^ -1329757349;
					continue;
				case 8u:
					num = ((int)num2 * -695389928) ^ -1739208592;
					continue;
				case 7u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0049;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1605788386;
						num5 = 1605788386;
					}
					else
					{
						num4 = 43935499;
						num5 = 43935499;
					}
					num = num4 ^ (int)(num2 * 1649075474);
					continue;
				}
				case 3u:
					jSONNode = m_List[aIndex];
					num = 925935647;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -2146225867) ^ -397521793;
						continue;
					}
					num3 = 1;
					goto IL_0049;
				case 1u:
					num = (int)((num2 * 575712824) ^ 0x558726E8);
					continue;
				case 0u:
					result = null;
					num = ((int)num2 * -1620639185) ^ -1460796982;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0049:
					flag = (byte)num3 != 0;
					num = 1496973389;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 234157841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x581D39CCu) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000f:
				result = aNode;
				num = (int)(num2 * 499493794) ^ -529048968;
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CGetEnumerator_003Ed__14(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -350562336;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x853F71EFu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_010b:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -2142396255;
								num4 = -2142396255;
							}
							else
							{
								num3 = -150510989;
								num4 = -150510989;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x853F71EFu) % 7u)
								{
								case 6u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = -937422017;
									continue;
								case 5u:
									num3 = -2142396255;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 701919952;
										num6 = 701919952;
									}
									else
									{
										num5 = 93129028;
										num6 = 93129028;
									}
									num3 = num5 ^ ((int)num2 * -236996936);
									continue;
								}
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 1502522861) ^ 0x32D5189F);
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1021996125;
									continue;
								default:
									goto end_IL_00ce;
								case 0u:
									break;
								case 3u:
									goto end_IL_00ce;
								}
								goto IL_010b;
								continue;
								end_IL_00ce:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = -1365923863;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x853F71EFu) % 4u)
							{
							case 3u:
								num7 = (int)((num2 * 1732683670) ^ 0x1BCD86B4);
								continue;
							case 2u:
								result = string_;
								num7 = ((int)num2 * -1853268185) ^ 0x562E3992;
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
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -2067931127) ^ -1778996007;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				IL_014f:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 34669344;
					num2 = 34669344;
				}
				else
				{
					num = 2045331105;
					num2 = 2045331105;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x3DB80B7Cu) % 11u)
					{
					case 10u:
						num = 34669344;
						continue;
					case 9u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = 201520961;
						continue;
					case 8u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = (int)(num3 * 579909458) ^ -923483109;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1762483821;
							num5 = -1762483821;
						}
						else
						{
							num4 = -1373466292;
							num5 = -1373466292;
						}
						num = num4 ^ ((int)num3 * -1372931880);
						continue;
					}
					case 5u:
						current = enumerator.Current;
						num = 1438221968;
						continue;
					case 4u:
						num = ((int)num3 * -2103807075) ^ -1387276732;
						continue;
					case 2u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = ((int)num3 * -624384400) ^ -1627128520;
						continue;
					case 1u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 1814239582) ^ -2121680621;
						continue;
					case 0u:
						num = (int)((num3 * 964530278) ^ 0x737677E7);
						continue;
					default:
						goto end_IL_0101;
					case 6u:
						break;
					case 3u:
						goto end_IL_0101;
					}
					goto IL_014f;
					continue;
					end_IL_0101:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num6 = 97354754;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x3DB80B7Cu) % 4u)
				{
				case 2u:
					result = string_;
					num6 = (int)((num3 * 1218242867) ^ 0x5252990B);
					continue;
				case 1u:
					num6 = (int)(num3 * 1549003231) ^ -1019018961;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1748977207;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78577F77u) % 10u)
				{
				case 8u:
					num = 1185973700;
					continue;
				case 7u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -1180846363) ^ 0x834CA51;
					continue;
				case 6u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1501265769) ^ 0x692A7D89);
					continue;
				case 5u:
					flag = num3 < m_List.Count;
					num = 515616501;
					continue;
				case 3u:
					num = (int)((num2 * 1139221573) ^ 0x7338A92B);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 54662475;
						num5 = 54662475;
					}
					else
					{
						num4 = 1094547172;
						num5 = 1094547172;
					}
					num = num4 ^ ((int)num2 * -762600453);
					continue;
				}
				case 1u:
					num3++;
					num = ((int)num2 * -1424098606) ^ 0x4B4296DA;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 1440898721) ^ 0xBE3BC1E);
					continue;
				default:
					return;
				case 4u:
					break;
				case 9u:
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
