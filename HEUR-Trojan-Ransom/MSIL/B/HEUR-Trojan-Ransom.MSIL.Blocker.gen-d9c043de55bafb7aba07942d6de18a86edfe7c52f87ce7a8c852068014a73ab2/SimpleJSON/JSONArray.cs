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
				int num = 69767177;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2B480669u) % 9u)
					{
					case 8u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -331201689) ^ 0x33451E5D;
						continue;
					case 6u:
						num = ((int)num2 * -695374619) ^ -668469991;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -724939394;
							num5 = -724939394;
						}
						else
						{
							num4 = -863878504;
							num5 = -863878504;
						}
						num = num4 ^ ((int)num2 * -1941497645);
						continue;
					}
					case 4u:
						num = (int)(num2 * 373797149) ^ -1609870945;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -500188871) ^ -2095131070;
							continue;
						}
						num3 = 1;
						goto IL_0075;
					case 1u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0075;
					case 0u:
						result = m_List[aIndex];
						num = 1436934966;
						continue;
					case 7u:
						break;
					default:
						{
							return result;
						}
						IL_0075:
						flag = (byte)num3 != 0;
						num = 1108454741;
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
				int num = 267528970;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2443AA8Bu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -970536986) ^ 0x59E59089;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1394301521;
							num5 = -1394301521;
						}
						else
						{
							num4 = -35562170;
							num5 = -35562170;
						}
						num = num4 ^ ((int)num2 * -1115132667);
						continue;
					}
					case 5u:
						m_List.Add(value);
						num = ((int)num2 * -1699074992) ^ 0x4F518E00;
						continue;
					case 4u:
						num = ((int)num2 * -2025401073) ^ -320417801;
						continue;
					case 3u:
						m_List[aIndex] = value;
						num = 584693039;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -508112040) ^ -338564187;
							continue;
						}
						num3 = 1;
						goto IL_008e;
					case 0u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_008e;
					default:
						return;
					case 2u:
						break;
					case 7u:
						return;
						IL_008e:
						flag = (byte)num3 != 0;
						num = 923045599;
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
				int num = 1574683777;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x657FBBA4u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -687990968) ^ -1192981322;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 242510972) ^ 0x496C75EF);
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
				int num = 1097053739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20D4E259u) % 3u)
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
					m_List.Add(value);
					num = ((int)num2 * -473816120) ^ 0x3F1E6163;
				}
			}
		}
	}

	public override int Count
	{
		get
		{
			int count = m_List.Count;
			while (true)
			{
				int num = 1390941759;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F19AFFAu) % 3u)
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
					num = (int)(num2 * 2115802756) ^ -1298738334;
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
				int num = 932152861;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1FD85780u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = (int)(num2 * 49788674) ^ -1266631553;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 614724497;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E6238EAu) % 3u)
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
				m_List.Add(aItem);
				num = (int)((num2 * 1487853495) ^ 0x799008E9);
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 711746590;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x71EB2080u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 206098135) ^ -380093496;
					continue;
				case 9u:
					result = jSONNode;
					num = (int)((num2 * 2075296824) ^ 0x620703C1);
					continue;
				case 8u:
					m_List.RemoveAt(aIndex);
					num = (int)(num2 * 277767897) ^ -763634053;
					continue;
				case 7u:
					num = (int)(num2 * 1902477682) ^ -1581142047;
					continue;
				case 6u:
					result = null;
					num = (int)((num2 * 1365001199) ^ 0x37744F5);
					continue;
				case 5u:
					num = ((int)num2 * -130919913) ^ 0x74F05590;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1983494662;
						num5 = 1983494662;
					}
					else
					{
						num4 = 1937577620;
						num5 = 1937577620;
					}
					num = num4 ^ ((int)num2 * -1565674364);
					continue;
				}
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -606595324) ^ -351946703;
						continue;
					}
					num3 = 1;
					goto IL_00b4;
				case 1u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_00b4;
				case 0u:
					jSONNode = m_List[aIndex];
					num = 874107748;
					continue;
				case 10u:
					break;
				default:
					{
						return result;
					}
					IL_00b4:
					flag = (byte)num3 != 0;
					num = 1619872264;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -258831641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6179719u) % 5u)
				{
				case 4u:
					m_List.Remove(aNode);
					num = ((int)num2 * -694209516) ^ -689757179;
					continue;
				case 3u:
					num = (int)((num2 * 1144929993) ^ 0x80F7382);
					continue;
				case 2u:
					result = aNode;
					num = ((int)num2 * -154897470) ^ -836881157;
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
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 1201796610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x513421E3u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_013a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 868678802;
								num4 = 868678802;
							}
							else
							{
								num3 = 2055628335;
								num4 = 2055628335;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x513421E3u) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = 791747085;
									continue;
								case 7u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -924499709) ^ -708766808;
									continue;
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 234542288;
									continue;
								case 5u:
									num3 = (int)((num2 * 1658760628) ^ 0x67B73ED0);
									continue;
								case 3u:
									num3 = 868678802;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -2066755302;
										num6 = -2066755302;
									}
									else
									{
										num5 = -1673788147;
										num6 = -1673788147;
									}
									num3 = num5 ^ ((int)num2 * -1898179496);
									continue;
								}
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -647133483) ^ 0x6DB2481C;
									continue;
								default:
									goto end_IL_00f4;
								case 0u:
									break;
								case 4u:
									goto end_IL_00f4;
								}
								goto IL_013a;
								continue;
								end_IL_00f4:
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
							IL_0185:
							int num7 = 177070982;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x513421E3u) % 3u)
								{
								case 1u:
									goto IL_0159;
								default:
									goto end_IL_0167;
								case 0u:
									break;
								case 2u:
									goto end_IL_0167;
								}
								goto IL_0185;
								IL_0159:
								num7 = (int)(num2 * 877501171) ^ -1661176114;
								continue;
								end_IL_0167:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num8 = 272969398;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x513421E3u) % 3u)
							{
							case 2u:
								goto IL_019e;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019e:
							num8 = (int)((num2 * 1990920722) ^ 0x3D200F1E);
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)((num2 * 1964655762) ^ 0x4ADE9F9D);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 2137547841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AF8C408u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 2091962504) ^ 0x3BA32C84);
					continue;
				case 1u:
					string_ = "[ ";
					num = ((int)num2 * -1897535325) ^ 0x7EE91170;
					continue;
				case 2u:
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
							if (!enumerator.MoveNext())
							{
								num3 = 1110451860;
								num4 = 1110451860;
							}
							else
							{
								num3 = 1744596011;
								num4 = 1744596011;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3AF8C408u) % 10u)
								{
								case 9u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 608619552;
									continue;
								case 8u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)((num2 * 731873626) ^ 0x3E4F5D8);
									continue;
								case 6u:
									num3 = ((int)num2 * -1575103193) ^ 0x6A38AFD;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 298529553;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1426814401) ^ -1053989523;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -314005491;
										num6 = -314005491;
									}
									else
									{
										num5 = -1665467928;
										num6 = -1665467928;
									}
									num3 = num5 ^ ((int)num2 * -1424080745);
									continue;
								}
								case 1u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = ((int)num2 * -992262856) ^ -1463663919;
									continue;
								case 0u:
									num3 = 1744596011;
									continue;
								default:
									goto end_IL_0135;
								case 7u:
									break;
								case 2u:
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
					string result = string_;
					while (true)
					{
						int num7 = 1413353783;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x3AF8C408u) % 3u)
							{
							case 2u:
								goto IL_01b4;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01b4:
							num7 = (int)(num2 * 1216459159) ^ -758859332;
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
		JSONArray.smethod_34(aWriter, (byte)1);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -832383804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCC9E715u) % 11u)
				{
				case 9u:
					flag = num3 < m_List.Count;
					num = -809001650;
					continue;
				case 8u:
					num3 = 0;
					num = (int)((num2 * 1152449721) ^ 0x74F7ABF7);
					continue;
				case 7u:
					num = ((int)num2 * -1198375125) ^ -292239260;
					continue;
				case 6u:
					num = (int)(num2 * 380637881) ^ -1430039454;
					continue;
				case 4u:
					m_List[num3].Serialize(aWriter);
					num = (int)((num2 * 384891206) ^ 0x24C690BA);
					continue;
				case 3u:
					num = -1199775584;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1102655350;
						num5 = 1102655350;
					}
					else
					{
						num4 = 384210384;
						num5 = 384210384;
					}
					num = num4 ^ ((int)num2 * -286913523);
					continue;
				}
				case 1u:
					num3++;
					num = (int)(num2 * 673171198) ^ -177630808;
					continue;
				case 0u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -947664161) ^ 0x50D1AA5C;
					continue;
				default:
					return;
				case 5u:
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
