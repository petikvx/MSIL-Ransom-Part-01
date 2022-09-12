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
				int num = -1095834880;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x9801E65Fu) % 9u)
					{
					case 8u:
						result = m_List[aIndex];
						num = -334399243;
						continue;
					case 7u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_002e;
					case 4u:
						num = ((int)num2 * -1465742209) ^ 0x23120439;
						continue;
					case 3u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -875667902) ^ 0x2A9230A;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1370964480;
							num5 = -1370964480;
						}
						else
						{
							num4 = -407504110;
							num5 = -407504110;
						}
						num = num4 ^ (int)(num2 * 1997138449);
						continue;
					}
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1790239557) ^ 0x4C93054A);
							continue;
						}
						num3 = 1;
						goto IL_002e;
					case 0u:
						num = (int)((num2 * 1797460522) ^ 0x34FF4B9);
						continue;
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_002e:
						flag = (byte)num3 != 0;
						num = -731376299;
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
				int num = 1116110640;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x565A550Du) % 10u)
					{
					case 9u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0017;
					case 8u:
						num = (int)((num2 * 812906911) ^ 0x67EC89B6);
						continue;
					case 7u:
						m_List.Add(value);
						num = (int)(num2 * 1012773635) ^ -1640624786;
						continue;
					case 6u:
						num = ((int)num2 * -843123562) ^ -18254603;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 924435007;
							num5 = 924435007;
						}
						else
						{
							num4 = 1545678364;
							num5 = 1545678364;
						}
						num = num4 ^ (int)(num2 * 1060432787);
						continue;
					}
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1217530555) ^ -135168643;
							continue;
						}
						num3 = 1;
						goto IL_0017;
					case 2u:
						m_List[aIndex] = value;
						num = 1967006850;
						continue;
					case 1u:
						num = (int)((num2 * 1754032253) ^ 0x774A1009);
						continue;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
						IL_0017:
						flag = (byte)num3 != 0;
						num = 3441491;
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
			return new JSONLazyCreator(this);
		}
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = -1223358806;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8AD631CAu) % 3u)
					{
					case 2u:
						goto IL_000e;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000e:
					num = (int)((num2 * 1781650489) ^ 0x12676CD3);
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
				int num = -2012672977;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCFD9468Du) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_List.Count;
					num = (int)((num2 * 643311561) ^ 0x63F22C9D);
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
				int num = 871618754;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C3F538Cu) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1159430246) ^ 0x4B5933A3;
						continue;
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -648163904) ^ 0x24D346C3;
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
		while (true)
		{
			int num = 1035472060;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2372FE2u) % 3u)
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
				m_List.Add(aItem);
				num = ((int)num2 * -460703129) ^ -2066225074;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -695349984;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8D2E7F9Cu) % 7u)
				{
				case 6u:
					if (aIndex < m_List.Count)
					{
						num = -570115377;
						num3 = -570115377;
						continue;
					}
					goto IL_0025;
				case 4u:
					result = null;
					num = (int)((num2 * 1161358742) ^ 0x44E43E95);
					continue;
				case 3u:
					num = ((int)num2 * -400235579) ^ -248597960;
					continue;
				case 2u:
				{
					JSONNode jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = -883003051;
					continue;
				}
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 2075252320) ^ -817709550;
						continue;
					}
					goto IL_0025;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0025:
					num = -108540836;
					num3 = -108540836;
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
			int num = 164508673;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F1D3FF9u) % 5u)
				{
				case 4u:
					result = aNode;
					num = (int)(num2 * 526192831) ^ -1592943958;
					continue;
				case 3u:
					m_List.Remove(aNode);
					num = ((int)num2 * -242450824) ^ 0x2CD14401;
					continue;
				case 1u:
					num = ((int)num2 * -1015590290) ^ -36027080;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string result = default(string);
		while (true)
		{
			int num = -658642875;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93D77620u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0121:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -732920487;
								num4 = -732920487;
							}
							else
							{
								num3 = -920121310;
								num4 = -920121310;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x93D77620u) % 8u)
								{
								case 7u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = (int)((num2 * 414106910) ^ 0x6CCDC07A);
									continue;
								case 6u:
									num3 = -732920487;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -217554100;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -833175147) ^ -1578741934;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -195004385;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1831998645;
										num6 = -1831998645;
									}
									else
									{
										num5 = -1766916571;
										num6 = -1766916571;
									}
									num3 = num5 ^ ((int)num2 * -436389655);
									continue;
								}
								default:
									goto end_IL_00e0;
								case 4u:
									break;
								case 2u:
									goto end_IL_00e0;
								}
								goto IL_0121;
								continue;
								end_IL_00e0:
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
							IL_016c:
							int num7 = -496698715;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x93D77620u) % 3u)
								{
								case 1u:
									goto IL_0140;
								default:
									goto end_IL_014e;
								case 2u:
									break;
								case 0u:
									goto end_IL_014e;
								}
								goto IL_016c;
								IL_0140:
								num7 = (int)(num2 * 714825600) ^ -763374664;
								continue;
								end_IL_014e:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = -578782736;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x93D77620u) % 3u)
							{
							case 1u:
								goto IL_0182;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0182:
							result = string_;
							num8 = ((int)num2 * -1326375410) ^ -1879159676;
						}
					}
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -1220022076) ^ 0x5EF96438;
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
			int num = -66095202;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB09CB3Fu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1120802936) ^ 0x6325F043);
					continue;
				case 1u:
					string_ = "[ ";
					num = (int)((num2 * 1287984186) ^ 0x55C48C9B);
					continue;
				case 3u:
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
							if (!enumerator.MoveNext())
							{
								num3 = -1942966843;
								num4 = -1942966843;
							}
							else
							{
								num3 = -1605249762;
								num4 = -1605249762;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xEB09CB3Fu) % 9u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = -1691916366;
									continue;
								case 6u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -751671091;
									continue;
								case 5u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = (int)(num2 * 1186462138) ^ -220818427;
									continue;
								case 3u:
									num3 = (int)((num2 * 504234533) ^ 0x31E4D84C);
									continue;
								case 2u:
									num3 = -1605249762;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1236033988;
										num6 = -1236033988;
									}
									else
									{
										num5 = -1861738932;
										num6 = -1861738932;
									}
									num3 = num5 ^ ((int)num2 * -2124625075);
									continue;
								}
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1944073177) ^ -1500832055;
									continue;
								default:
									goto end_IL_0125;
								case 4u:
									break;
								case 8u:
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
						int num7 = -2019622141;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xEB09CB3Fu) % 3u)
							{
							case 2u:
								goto IL_01a0;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01a0:
							num7 = ((int)num2 * -1252858753) ^ 0x573F53F2;
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
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 659927621;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3599E59Au) % 12u)
				{
				case 11u:
					num = (int)((num2 * 206902581) ^ 0x65F2E0E2);
					continue;
				case 10u:
					num5 = 0;
					num = (int)(num2 * 2022795128) ^ -1566284519;
					continue;
				case 9u:
					num5++;
					num = (int)((num2 * 1463462203) ^ 0x4BEA314E);
					continue;
				case 7u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 666940614) ^ 0x7FC56759);
					continue;
				case 5u:
					num = 209226474;
					continue;
				case 4u:
					m_List[num5].Serialize(aWriter);
					num = ((int)num2 * -151393095) ^ -246844684;
					continue;
				case 3u:
					flag = num5 < m_List.Count;
					num = 2068446442;
					continue;
				case 2u:
					num = (int)((num2 * 576386249) ^ 0x5E90938D);
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1070648116) ^ 0x293E7F10);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1998428604;
						num4 = 1998428604;
					}
					else
					{
						num3 = 1597922651;
						num4 = 1597922651;
					}
					num = num3 ^ ((int)num2 * -1799767987);
					continue;
				}
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
