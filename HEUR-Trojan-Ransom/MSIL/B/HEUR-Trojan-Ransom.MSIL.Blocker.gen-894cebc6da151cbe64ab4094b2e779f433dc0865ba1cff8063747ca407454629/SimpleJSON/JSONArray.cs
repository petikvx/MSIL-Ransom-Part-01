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
			while (true)
			{
				int num = 238165258;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2B668FD5u) % 8u)
					{
					case 7u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -856656594) ^ -1769583229;
							continue;
						}
						goto IL_0028;
					case 4u:
						if (aIndex < m_List.Count)
						{
							num = 389086220;
							num3 = 389086220;
							continue;
						}
						goto IL_0028;
					case 3u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -526486324) ^ -1410057037;
						continue;
					case 2u:
						num = (int)(num2 * 526813483) ^ -2011484250;
						continue;
					case 1u:
						result = m_List[aIndex];
						num = 171120277;
						continue;
					case 0u:
						num = ((int)num2 * -473281059) ^ 0x556FC9F0;
						continue;
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_0028:
						num = 2008249094;
						num3 = 2008249094;
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
				goto IL_002e;
			}
			int num = 1;
			goto IL_00c2;
			IL_00c2:
			bool flag = (byte)num != 0;
			int num2 = 2029218876;
			goto IL_0080;
			IL_002e:
			num2 = 2116771423;
			goto IL_0080;
			IL_0080:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x7DF42F1Bu) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 228407337;
						num5 = 228407337;
					}
					else
					{
						num4 = 375954116;
						num5 = 375954116;
					}
					num2 = num4 ^ (int)(num3 * 368456206);
					continue;
				}
				case 6u:
					break;
				case 5u:
					m_List[aIndex] = value;
					num2 = 333050193;
					continue;
				case 3u:
					num2 = ((int)num3 * -1142892832) ^ -1528891919;
					continue;
				case 1u:
					num2 = (int)((num3 * 1643962659) ^ 0x289AF6B);
					continue;
				case 0u:
					m_List.Add(value);
					num2 = ((int)num3 * -1218359138) ^ 0x670C748A;
					continue;
				default:
					return;
				case 4u:
					goto IL_00b1;
				case 2u:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_00b1:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00c2;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -1860917265;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF5FD1244u) % 3u)
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
					num = ((int)num2 * -493782228) ^ -717351306;
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
				int num = 363240587;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x528A26C9u) % 3u)
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
					num = (int)(num2 * 2132635829) ^ -1181848387;
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
				int num = 1045478338;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73A4EF49u) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 791435632) ^ 0x35A79D64);
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 144095730) ^ -1924197659;
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
			int num = 933901456;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50D691CDu) % 3u)
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
				num = ((int)num2 * -75156880) ^ -369682954;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1482381046;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x1D24A5D3u) % 11u)
				{
				case 10u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1655545886) ^ 0x66D0F80;
						continue;
					}
					goto IL_001f;
				case 9u:
					m_List.RemoveAt(aIndex);
					num = ((int)num2 * -2114214772) ^ -932381789;
					continue;
				case 8u:
					result = null;
					num = ((int)num2 * -397020029) ^ -1949529997;
					continue;
				case 7u:
					num = ((int)num2 * -709106727) ^ -241552459;
					continue;
				case 6u:
					num = ((int)num2 * -153409376) ^ 0x3092456F;
					continue;
				case 5u:
					jSONNode = m_List[aIndex];
					num = 1126190987;
					continue;
				case 3u:
					num = ((int)num2 * -1734041681) ^ -788356282;
					continue;
				case 2u:
					if (aIndex < m_List.Count)
					{
						num = 462736333;
						num3 = 462736333;
						continue;
					}
					goto IL_001f;
				case 1u:
					result = jSONNode;
					num = (int)(num2 * 1632988655) ^ -1369405410;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001f:
					num = 447639503;
					num3 = 447639503;
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
			int num = -130696883;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC23D0715u) % 3u)
				{
				case 2u:
					goto IL_000f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000f:
				result = aNode;
				num = ((int)num2 * -1163699114) ^ 0x32683DB1;
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
		bool flag = default(bool);
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = -1240455447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3605B65u) % 3u)
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
							if (!enumerator.MoveNext())
							{
								num3 = -2026742625;
								num4 = -2026742625;
							}
							else
							{
								num3 = -573189306;
								num4 = -573189306;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA3605B65u) % 9u)
								{
								case 8u:
									num3 = -573189306;
									continue;
								case 7u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -1279351785) ^ -1847628243;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1037282905) ^ 0x7D7F7413;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1120681809;
									continue;
								case 2u:
									num3 = (int)(num2 * 1756926951) ^ -477333117;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -2125577691;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1521937322;
										num6 = -1521937322;
									}
									else
									{
										num5 = -1165667242;
										num6 = -1165667242;
									}
									num3 = num5 ^ ((int)num2 * -1849876188);
									continue;
								}
								default:
									goto end_IL_00f4;
								case 3u:
									break;
								case 6u:
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
							int num7 = -103592186;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xA3605B65u) % 3u)
								{
								case 1u:
									goto IL_0159;
								default:
									goto end_IL_0167;
								case 2u:
									break;
								case 0u:
									goto end_IL_0167;
								}
								goto IL_0185;
								IL_0159:
								num7 = ((int)num2 * -53116102) ^ 0xDE2523C;
								continue;
								end_IL_0167:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_31(string_, " ]");
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)((num2 * 539012992) ^ 0x6DB07B30);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -10672895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADDC681Du) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_015b:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -790967705;
								num4 = -790967705;
							}
							else
							{
								num3 = -1205330168;
								num4 = -1205330168;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xADDC681Du) % 9u)
								{
								case 8u:
									num3 = -790967705;
									continue;
								case 6u:
									num3 = (int)((num2 * 950912339) ^ 0x5BA31F84);
									continue;
								case 5u:
									num3 = (int)(num2 * 1627614998) ^ -879473654;
									continue;
								case 4u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -878471885;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -369322754;
										num6 = -369322754;
									}
									else
									{
										num5 = -1270047216;
										num6 = -1270047216;
									}
									num3 = num5 ^ (int)(num2 * 677459215);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = -2141527179;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1959734946) ^ -252895745;
									continue;
								default:
									goto end_IL_0115;
								case 7u:
									break;
								case 3u:
									goto end_IL_0115;
								}
								goto IL_015b;
								continue;
								end_IL_0115:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = -524649408;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xADDC681Du) % 4u)
							{
							case 2u:
								num7 = (int)((num2 * 1604360123) ^ 0x4E5DFFF3);
								continue;
							case 1u:
								result = string_;
								num7 = (int)((num2 * 1750190182) ^ 0x376E6B69);
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
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -221419325) ^ 0x47074488;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		JSONArray.smethod_35(aWriter, m_List.Count);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -580507091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x911E7BC1u) % 10u)
				{
				case 9u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -2138660054) ^ -1167738974;
					continue;
				case 8u:
					num = (int)((num2 * 819643046) ^ 0xD852597);
					continue;
				case 7u:
					num = ((int)num2 * -1156987906) ^ 0xF15362;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -686240988;
						num5 = -686240988;
					}
					else
					{
						num4 = -1550805454;
						num5 = -1550805454;
					}
					num = num4 ^ ((int)num2 * -1437363855);
					continue;
				}
				case 3u:
					num3++;
					num = (int)((num2 * 1362263672) ^ 0x20AEE600);
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -1232066951) ^ 0x5C2E3D76;
					continue;
				case 1u:
					flag = num3 < m_List.Count;
					num = -151980728;
					continue;
				case 0u:
					num = -214048352;
					continue;
				default:
					return;
				case 6u:
					break;
				case 4u:
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
			int num = -1742714258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82A6EBB2u) % 3u)
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
				num = ((int)num2 * -414240492) ^ -1867254776;
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
