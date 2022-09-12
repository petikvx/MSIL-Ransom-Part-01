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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 324272684;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5D8427B6u) % 8u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1462949973;
							num5 = 1462949973;
						}
						else
						{
							num4 = 1620684208;
							num5 = 1620684208;
						}
						num = num4 ^ ((int)num2 * -1574211466);
						continue;
					}
					case 5u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_003b;
					case 4u:
						result = m_List[aIndex];
						num = 486269014;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 551005220) ^ -1128796341;
							continue;
						}
						num3 = 1;
						goto IL_003b;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1636589083) ^ 0x1463C25B);
						continue;
					case 0u:
						num = ((int)num2 * -57807633) ^ -728183256;
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_003b:
						flag = (byte)num3 != 0;
						num = 1690244073;
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
				int num = 354368932;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4A091F2u) % 9u)
					{
					case 8u:
						m_List[aIndex] = value;
						num = 2146622355;
						continue;
					case 7u:
						m_List.Add(value);
						num = ((int)num2 * -1641216083) ^ -1436393655;
						continue;
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1765229569) ^ 0x3A234BE5);
							continue;
						}
						num3 = 1;
						goto IL_004c;
					case 3u:
						num = ((int)num2 * -703890264) ^ -1928493849;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -280240948;
							num5 = -280240948;
						}
						else
						{
							num4 = -425283860;
							num5 = -425283860;
						}
						num = num4 ^ ((int)num2 * -1905012991);
						continue;
					}
					case 1u:
						num = ((int)num2 * -181737268) ^ -2063910685;
						continue;
					case 0u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_004c;
					default:
						return;
					case 6u:
						break;
					case 5u:
						return;
						IL_004c:
						flag = (byte)num3 != 0;
						num = 504822618;
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
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = 475731081;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FE18E1u) % 3u)
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
					num = ((int)num2 * -1732185285) ^ 0x6958329;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1213381033;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D7CA37Fu) % 4u)
					{
					case 2u:
						m_List.Add(value);
						num = (int)(num2 * 1935402750) ^ -1768784654;
						continue;
					case 1u:
						num = (int)(num2 * 2005158585) ^ -1199649263;
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

	public override int Count
	{
		get
		{
			int count = m_List.Count;
			while (true)
			{
				int num = 1704873438;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D54EAD8u) % 3u)
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
					num = ((int)num2 * -1492172176) ^ -1403543053;
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
				int num = -1560547338;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD7871DB3u) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 349065564) ^ 0x1A7DE741);
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1574365986) ^ -144387050;
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
			int num = 944181592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27A74C7Du) % 4u)
				{
				case 2u:
					num = (int)(num2 * 515215317) ^ -712401317;
					continue;
				case 1u:
					m_List.Add(aItem);
					num = (int)(num2 * 1211255346) ^ -393369767;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -1041175391;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA4A980B9u) % 10u)
				{
				case 9u:
					result = jSONNode;
					num = ((int)num2 * -1809646415) ^ 0x766D37F4;
					continue;
				case 8u:
					num = ((int)num2 * -380494971) ^ -147252686;
					continue;
				case 7u:
					if (aIndex < m_List.Count)
					{
						num = -1295730624;
						num3 = -1295730624;
						continue;
					}
					goto IL_003f;
				case 6u:
					m_List.RemoveAt(aIndex);
					num = (int)(num2 * 544199210) ^ -413957470;
					continue;
				case 3u:
					num = ((int)num2 * -994599511) ^ 0x56ED687B;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1055972079) ^ 0x1F657800);
						continue;
					}
					goto IL_003f;
				case 1u:
					jSONNode = m_List[aIndex];
					num = -1490690721;
					continue;
				case 0u:
					result = null;
					num = (int)((num2 * 973996860) ^ 0x49A340DA);
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_003f:
					num = -649488475;
					num3 = -649488475;
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
			int num = -1860473022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F9A7DFBu) % 4u)
				{
				case 1u:
					m_List.Remove(aNode);
					result = aNode;
					num = (int)(num2 * 1220479430) ^ -1240467915;
					continue;
				case 0u:
					num = ((int)num2 * -958725671) ^ -404944187;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1522800681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE08128BCu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_013a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -323327375;
								num4 = -323327375;
							}
							else
							{
								num3 = -1545258696;
								num4 = -1545258696;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE08128BCu) % 9u)
								{
								case 8u:
									num3 = (int)(num2 * 1670953343) ^ -37781178;
									continue;
								case 7u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = (int)(num2 * 1662665188) ^ -182286517;
									continue;
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1628976792;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 73488811;
										num6 = 73488811;
									}
									else
									{
										num5 = 2059312202;
										num6 = 2059312202;
									}
									num3 = num5 ^ ((int)num2 * -1679798399);
									continue;
								}
								case 3u:
									current = enumerator.Current;
									num3 = -1394764467;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1645884719) ^ 0x3561259D;
									continue;
								case 0u:
									num3 = -323327375;
									continue;
								default:
									goto end_IL_00f4;
								case 2u:
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
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = -1558210133;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xE08128BCu) % 4u)
							{
							case 3u:
								result = string_;
								num7 = (int)(num2 * 749323911) ^ -672161191;
								continue;
							case 0u:
								num7 = (int)(num2 * 304513318) ^ -1777812543;
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
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1110658596) ^ -1955820593;
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
			int num = 496101662;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49694E82u) % 3u)
				{
				case 1u:
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
							IL_0171:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1107867624;
								num4 = 1107867624;
							}
							else
							{
								num3 = 2009590473;
								num4 = 2009590473;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x49694E82u) % 10u)
								{
								case 9u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 1170935808) ^ 0x5DBCA25);
									continue;
								case 8u:
									current = enumerator.Current;
									num3 = 977036090;
									continue;
								case 7u:
									num3 = ((int)num2 * -556949120) ^ -722549043;
									continue;
								case 6u:
									num3 = 1107867624;
									continue;
								case 4u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = (int)((num2 * 491406639) ^ 0x67026EA4);
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 1674130702;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1097990241;
										num6 = 1097990241;
									}
									else
									{
										num5 = 91943863;
										num6 = 91943863;
									}
									num3 = num5 ^ ((int)num2 * -824465729);
									continue;
								}
								case 0u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -1542990310) ^ -1213067509;
									continue;
								default:
									goto end_IL_0127;
								case 1u:
									break;
								case 5u:
									goto end_IL_0127;
								}
								goto IL_0171;
								continue;
								end_IL_0127:
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
							IL_01bc:
							int num7 = 252455843;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x49694E82u) % 3u)
								{
								case 2u:
									goto IL_0190;
								default:
									goto end_IL_019e;
								case 0u:
									break;
								case 1u:
									goto end_IL_019e;
								}
								goto IL_01bc;
								IL_0190:
								num7 = (int)(num2 * 1568712975) ^ -1355017015;
								continue;
								end_IL_019e:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num8 = 997801712;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x49694E82u) % 3u)
							{
							case 2u:
								goto IL_01db;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01db:
							num8 = ((int)num2 * -1384026402) ^ -1153881449;
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -205628776) ^ 0x7826FDB6;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		JSONArray.smethod_35(aWriter, m_List.Count);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1508501919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64E5B10Au) % 9u)
				{
				case 7u:
					num5 = 0;
					num = ((int)num2 * -2079565050) ^ -1319857414;
					continue;
				case 6u:
					num5++;
					num = (int)((num2 * 810106322) ^ 0x1BEF049E);
					continue;
				case 5u:
					flag = num5 < m_List.Count;
					num = 1708407501;
					continue;
				case 4u:
					num = ((int)num2 * -227497556) ^ -1186439370;
					continue;
				case 3u:
					num = (int)(num2 * 145588) ^ -299962950;
					continue;
				case 2u:
					m_List[num5].Serialize(aWriter);
					num = 855545358;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 397552874;
						num4 = 397552874;
					}
					else
					{
						num3 = 913035654;
						num4 = 913035654;
					}
					num = num3 ^ (int)(num2 * 1400137405);
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 0u:
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
