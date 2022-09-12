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
				int num = -1793446913;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x9BC709BCu) % 8u)
					{
					case 7u:
						result = m_List[aIndex];
						num = -378860915;
						continue;
					case 6u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_002b;
					case 4u:
						num = ((int)num2 * -65237675) ^ -373753751;
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 710373107) ^ 0x79057043);
							continue;
						}
						num5 = 1;
						goto IL_002b;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -220098654;
							num4 = -220098654;
						}
						else
						{
							num3 = -186508667;
							num4 = -186508667;
						}
						num = num3 ^ ((int)num2 * -520373709);
						continue;
					}
					case 0u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 408858478) ^ 0x1410A8E8);
						continue;
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_002b:
						flag = (byte)num5 != 0;
						num = -1974974506;
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
				int num = 470967098;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x7937ADCu) % 10u)
					{
					case 9u:
						num = (int)((num2 * 563961300) ^ 0x7DBBEE88);
						continue;
					case 8u:
						m_List[aIndex] = value;
						num = 1773300651;
						continue;
					case 6u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1883751372) ^ 0xC8A1F82);
							continue;
						}
						num3 = 1;
						goto IL_0043;
					case 5u:
						num = (int)((num2 * 1591102444) ^ 0x12447308);
						continue;
					case 4u:
						m_List.Add(value);
						num = ((int)num2 * -1103968980) ^ 0x2EE74701;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1393773620;
							num5 = -1393773620;
						}
						else
						{
							num4 = -672529286;
							num5 = -672529286;
						}
						num = num4 ^ ((int)num2 * -1771176960);
						continue;
					}
					case 1u:
						num = ((int)num2 * -1678928277) ^ -679901094;
						continue;
					case 0u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0043;
					default:
						return;
					case 7u:
						break;
					case 2u:
						return;
						IL_0043:
						flag = (byte)num3 != 0;
						num = 477046043;
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
				int num = 2144853877;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2392AA5Cu) % 3u)
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
					num = ((int)num2 * -1272178398) ^ 0x1E77DDF6;
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
			int count = default(int);
			while (true)
			{
				int num = -581595889;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC22EFA76u) % 3u)
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
					num = ((int)num2 * -1484142654) ^ 0xC698938;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -1098360740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83DB4129u) % 3u)
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
				m_List.Add(aItem);
				num = (int)(num2 * 878103055) ^ -213855843;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1160842826;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE2C74A09u) % 9u)
				{
				case 8u:
					m_List.RemoveAt(aIndex);
					num = (int)((num2 * 1797676115) ^ 0x23DFCE47);
					continue;
				case 6u:
					jSONNode = m_List[aIndex];
					num = -2115863886;
					continue;
				case 5u:
					result = jSONNode;
					num = (int)((num2 * 1124269616) ^ 0x3F32DE3F);
					continue;
				case 4u:
					num = ((int)num2 * -316095524) ^ 0x15298B47;
					continue;
				case 3u:
					result = null;
					num = (int)(num2 * 1154189050) ^ -974679883;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1743656265) ^ 0x318C38AB;
						continue;
					}
					goto IL_007f;
				case 0u:
					if (aIndex < m_List.Count)
					{
						num = -841461661;
						num3 = -841461661;
						continue;
					}
					goto IL_007f;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_007f:
					num = -1337241352;
					num3 = -1337241352;
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
			int num = 1598305449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x561F5450u) % 4u)
				{
				case 1u:
					result = aNode;
					num = ((int)num2 * -1321603055) ^ 0xA77D50D;
					continue;
				case 0u:
					num = ((int)num2 * -670802424) ^ 0x2A189836;
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
		string string_ = "[ ";
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
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
					num = -802909956;
					num2 = -802909956;
				}
				else
				{
					num = -1904772189;
					num2 = -1904772189;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xB09670DAu) % 9u)
					{
					case 8u:
						current = enumerator.Current;
						num = -79693540;
						continue;
					case 7u:
						num = -802909956;
						continue;
					case 6u:
						flag = JSONArray.smethod_30(string_) > 2;
						num = (int)(num3 * 910696098) ^ -507951260;
						continue;
					case 5u:
						num = ((int)num3 * -552474677) ^ 0x68CB1F82;
						continue;
					case 4u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -1740259080;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 600024597;
							num5 = 600024597;
						}
						else
						{
							num4 = 723580178;
							num5 = 723580178;
						}
						num = num4 ^ ((int)num3 * -1120909633);
						continue;
					}
					case 1u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 1627717718) ^ -1570883809;
						continue;
					default:
						goto end_IL_00be;
					case 0u:
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
		finally
		{
			((IDisposable)enumerator).Dispose();
			while (true)
			{
				IL_014f:
				int num6 = -699498785;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xB09670DAu) % 3u)
					{
					case 1u:
						goto IL_0123;
					default:
						goto end_IL_0131;
					case 0u:
						break;
					case 2u:
						goto end_IL_0131;
					}
					goto IL_014f;
					IL_0123:
					num6 = (int)((num3 * 1429789503) ^ 0x2C7B5AC1);
					continue;
					end_IL_0131:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = string_;
		while (true)
		{
			int num7 = -413434195;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xB09670DAu) % 3u)
				{
				case 2u:
					goto IL_0168;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0168:
				num7 = ((int)num3 * -1618006392) ^ -895055934;
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
			int num = -1712236062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x862343D0u) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = ((int)num2 * -1789012765) ^ 0x5C3E348F;
					continue;
				case 1u:
					num = (int)((num2 * 929493699) ^ 0x382C9D4);
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_016b:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -718412022;
								num4 = -718412022;
							}
							else
							{
								num3 = -1714504839;
								num4 = -1714504839;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x862343D0u) % 9u)
								{
								case 6u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -352955968;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -950656273) ^ 0x6856FB01;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 302834783) ^ -1187461304;
									continue;
								case 3u:
									num3 = -718412022;
									continue;
								case 2u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = -54058144;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 469602007;
										num6 = 469602007;
									}
									else
									{
										num5 = 1707415912;
										num6 = 1707415912;
									}
									num3 = num5 ^ (int)(num2 * 752566767);
									continue;
								}
								case 0u:
									num3 = ((int)num2 * -2116179646) ^ 0x7950E369;
									continue;
								default:
									goto end_IL_0125;
								case 8u:
									break;
								case 7u:
									goto end_IL_0125;
								}
								goto IL_016b;
								continue;
								end_IL_0125:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num7 = -1162539298;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x862343D0u) % 3u)
							{
							case 1u:
								goto IL_01a0;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01a0:
							num7 = ((int)num2 * -63658304) ^ -1576921565;
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
		int num3 = default(int);
		while (true)
		{
			int num = 1000325929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3EF33216u) % 11u)
				{
				case 10u:
					num3 = 0;
					num = (int)(num2 * 1938201965) ^ -819252123;
					continue;
				case 9u:
					num = (int)(num2 * 82235711) ^ -238908232;
					continue;
				case 7u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = 1238176314;
						num4 = 1238176314;
					}
					else
					{
						num = 155471970;
						num4 = 155471970;
					}
					continue;
				}
				case 5u:
					num3++;
					num = (int)(num2 * 790163263) ^ -263214720;
					continue;
				case 4u:
					num = ((int)num2 * -1932817681) ^ 0x3937AC6A;
					continue;
				case 3u:
					num = ((int)num2 * -767476248) ^ 0x4B742E5D;
					continue;
				case 2u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 582920361) ^ -471002601;
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1499746906) ^ 0x464DB5A0;
					continue;
				case 0u:
					m_List[num3].Serialize(aWriter);
					num = 947499111;
					continue;
				default:
					return;
				case 8u:
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
			int num = -76695059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF1FF4E2u) % 3u)
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
				num = ((int)num2 * -1245050644) ^ 0x6014C8EB;
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
