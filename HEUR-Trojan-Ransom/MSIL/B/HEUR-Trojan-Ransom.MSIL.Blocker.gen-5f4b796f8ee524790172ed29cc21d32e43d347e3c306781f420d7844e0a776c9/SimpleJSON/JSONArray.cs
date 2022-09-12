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
				goto IL_0067;
			}
			int num = 1;
			goto IL_00bd;
			IL_00bd:
			bool flag = (byte)num != 0;
			int num2 = -1713350744;
			goto IL_007b;
			IL_0067:
			num2 = -710843967;
			goto IL_007b;
			IL_007b:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x8B50DA56u) % 8u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -793558261;
						num5 = -793558261;
					}
					else
					{
						num4 = -667170588;
						num5 = -667170588;
					}
					num2 = num4 ^ (int)(num3 * 1854666421);
					continue;
				}
				case 5u:
					num2 = ((int)num3 * -808950378) ^ 0x2C8E8821;
					continue;
				case 4u:
					result = m_List[aIndex];
					num2 = -22276341;
					continue;
				case 3u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -1650409987) ^ -1273987119;
					continue;
				case 2u:
					break;
				case 0u:
					num2 = ((int)num3 * -1286969541) ^ -1245166121;
					continue;
				case 7u:
					goto IL_00ac;
				default:
					return result;
				}
				break;
			}
			goto IL_0067;
			IL_00ac:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00bd;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0055;
			}
			goto IL_00bc;
			IL_0055:
			int num = 1778714215;
			goto IL_0078;
			IL_0078:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7711F3FBu) % 8u)
				{
				case 7u:
					m_List[aIndex] = value;
					num = 2072966245;
					continue;
				case 6u:
					num = ((int)num2 * -958370045) ^ -1177311910;
					continue;
				case 5u:
					m_List.Add(value);
					num = ((int)num2 * -784509304) ^ 0x40386E53;
					continue;
				case 2u:
					break;
				case 1u:
					num = ((int)num2 * -1848241610) ^ -1501587146;
					continue;
				case 0u:
					num = (int)((num2 * 1609743547) ^ 0x2C22F97A);
					continue;
				default:
					return;
				case 4u:
					goto IL_00a9;
				case 3u:
					return;
				}
				break;
				IL_00a9:
				if (aIndex < m_List.Count)
				{
					num = 1863604828;
					num3 = 1863604828;
					continue;
				}
				goto IL_00bc;
			}
			goto IL_0055;
			IL_00bc:
			num = 1795089094;
			num3 = 1795089094;
			goto IL_0078;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			return new JSONLazyCreator(this);
		}
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = -249628411;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89D4328Bu) % 3u)
					{
					case 1u:
						goto IL_000e;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000e:
					num = ((int)num2 * -1745172246) ^ -1029785342;
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
				int num = -1218650337;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D1EA230u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_List.Count;
					num = (int)((num2 * 624591225) ^ 0x6CC8C665);
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
				int num = -1156992933;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9CC496F2u) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 601458381) ^ 0x540A3A79);
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 1910847781) ^ 0x75C98EA8);
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
			int num = 1855671802;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x5A8A5293u) % 11u)
				{
				case 10u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0017;
				case 9u:
					result = null;
					num = (int)(num2 * 2086491144) ^ -702037150;
					continue;
				case 8u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = 1885233893;
					continue;
				case 7u:
					num = ((int)num2 * -1893044576) ^ -129221337;
					continue;
				case 6u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1604182478) ^ 0x31D2BA01);
						continue;
					}
					num5 = 1;
					goto IL_0017;
				case 4u:
					num = (int)((num2 * 1677472965) ^ 0x1AE19CE2);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1335789443;
						num4 = -1335789443;
					}
					else
					{
						num3 = -1717973089;
						num4 = -1717973089;
					}
					num = num3 ^ ((int)num2 * -488406969);
					continue;
				}
				case 2u:
					result = jSONNode;
					num = (int)((num2 * 647856690) ^ 0x435501D5);
					continue;
				case 0u:
					num = ((int)num2 * -1017927733) ^ 0x7562050C;
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num5 != 0;
					num = 251701919;
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
			int num = -1998338635;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB50DA2D8u) % 4u)
				{
				case 1u:
					result = aNode;
					num = (int)(num2 * 1371569411) ^ -1366660893;
					continue;
				case 0u:
					num = (int)(num2 * 1995173517) ^ -1704807969;
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
			bool flag = default(bool);
			while (true)
			{
				IL_0101:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1338868707;
					num2 = -1338868707;
				}
				else
				{
					num = -424922640;
					num2 = -424922640;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x82B3C45Eu) % 9u)
					{
					case 8u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -446126081;
						continue;
					case 7u:
						flag = JSONArray.smethod_30(string_) > 2;
						num = (int)(num3 * 864369870) ^ -145927767;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1459567956;
							num5 = 1459567956;
						}
						else
						{
							num4 = 1231945657;
							num5 = 1231945657;
						}
						num = num4 ^ (int)(num3 * 1667487874);
						continue;
					}
					case 3u:
						num = -1338868707;
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -965101933) ^ -1803378527;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -2140098080;
						continue;
					case 0u:
						num = ((int)num3 * -274438904) ^ -531178512;
						continue;
					default:
						goto end_IL_00bb;
					case 6u:
						break;
					case 4u:
						goto end_IL_00bb;
					}
					goto IL_0101;
					continue;
					end_IL_00bb:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = string_;
		while (true)
		{
			int num6 = -1385897341;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x82B3C45Eu) % 3u)
				{
				case 2u:
					goto IL_0130;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0130:
				num6 = ((int)num3 * -1765047027) ^ 0x68FC7B11;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 420135036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21A7B166u) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = ((int)num2 * -136128582) ^ -426176185;
					continue;
				case 1u:
					num = ((int)num2 * -733415643) ^ -871899108;
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_017f:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1058621769;
								num4 = 1058621769;
							}
							else
							{
								num3 = 267033672;
								num4 = 267033672;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x21A7B166u) % 10u)
								{
								case 9u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1159493743) ^ -1582721249;
									continue;
								case 8u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1205198173;
										num6 = -1205198173;
									}
									else
									{
										num5 = -1093504246;
										num6 = -1093504246;
									}
									num3 = num5 ^ ((int)num2 * -1499951084);
									continue;
								}
								case 7u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = (int)((num2 * 570024064) ^ 0x2E0CEF7E);
									continue;
								case 6u:
									num3 = ((int)num2 * -46415851) ^ 0x20254BDF;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 1492439486;
									continue;
								case 2u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 644845719;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 1124204956) ^ -1171957429;
									continue;
								case 0u:
									num3 = 1058621769;
									continue;
								default:
									goto end_IL_0135;
								case 3u:
									break;
								case 4u:
									goto end_IL_0135;
								}
								goto IL_017f;
								continue;
								end_IL_0135:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 718348023;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x21A7B166u) % 4u)
							{
							case 2u:
								num7 = (int)(num2 * 1368119914) ^ -1633933699;
								continue;
							case 1u:
								result = string_;
								num7 = ((int)num2 * -1911967245) ^ -1774546613;
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
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -421840434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABEBA1B1u) % 11u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -839472136;
						num5 = -839472136;
					}
					else
					{
						num4 = -1170854703;
						num5 = -1170854703;
					}
					num = num4 ^ (int)(num2 * 1948727262);
					continue;
				}
				case 8u:
					num = (int)((num2 * 668231759) ^ 0x16820F97);
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -455354092) ^ 0x11BFC7EB;
					continue;
				case 5u:
					num = ((int)num2 * -1945775686) ^ 0x5B7F91B9;
					continue;
				case 4u:
					flag = num3 < m_List.Count;
					num = -1822551793;
					continue;
				case 3u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 2011162826) ^ 0x43A0EA70);
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -718544890) ^ -148318293;
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -1450455358) ^ 0x5AD19F40;
					continue;
				case 0u:
					m_List[num3].Serialize(aWriter);
					num = -1536682816;
					continue;
				default:
					return;
				case 6u:
					break;
				case 10u:
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
