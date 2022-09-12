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
				int num = -1242602312;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xDA3630D3u) % 8u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -796696634;
							num5 = -796696634;
						}
						else
						{
							num4 = -1634003334;
							num5 = -1634003334;
						}
						num = num4 ^ ((int)num2 * -1949581272);
						continue;
					}
					case 6u:
						num = (int)(num2 * 695295215) ^ -762924811;
						continue;
					case 5u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1807805385) ^ 0x2514EE18);
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1426859025) ^ 0x44C1DD94;
							continue;
						}
						num3 = 1;
						goto IL_0063;
					case 2u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0063;
					case 1u:
						result = m_List[aIndex];
						num = -647408553;
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_0063:
						flag = (byte)num3 != 0;
						num = -322229372;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -725150945;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xA7E0265Fu) % 9u)
					{
					case 8u:
						m_List.Add(value);
						num = (int)(num2 * 163933768) ^ -854097597;
						continue;
					case 7u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1728053826) ^ 0x4E5B9427);
							continue;
						}
						goto IL_003a;
					case 5u:
						num = ((int)num2 * -1534088211) ^ 0x7BFC1C13;
						continue;
					case 4u:
						num = ((int)num2 * -337097803) ^ -312176493;
						continue;
					case 2u:
						num = (int)(num2 * 1817512884) ^ -815336421;
						continue;
					case 1u:
						if (aIndex < m_List.Count)
						{
							num = -719322097;
							num3 = -719322097;
							continue;
						}
						goto IL_003a;
					case 0u:
						m_List[aIndex] = value;
						num = -696250453;
						continue;
					default:
						return;
					case 3u:
						break;
					case 6u:
						return;
						IL_003a:
						num = -2098536146;
						num3 = -2098536146;
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
				int num = 1060644280;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48C2D0B1u) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -1884067391) ^ -734683333;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -957986595;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF201B3ADu) % 3u)
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
					m_List.Add(value);
					num = (int)(num2 * 417687399) ^ -1838961667;
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
				int num = 1616331427;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x339BCA5Au) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1605445061) ^ -1730366027;
						continue;
					case 1u:
						count = m_List.Count;
						num = (int)((num2 * 1882601386) ^ 0x2763D4EB);
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
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			while (true)
			{
				int num = -589872505;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF7059D89u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -653139899) ^ -185360490;
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
		if (aIndex >= 0)
		{
			goto IL_003b;
		}
		int num = 1;
		goto IL_00c6;
		IL_00b5:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00c6;
		IL_003b:
		int num2 = 304890847;
		goto IL_0084;
		IL_0084:
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x455B55BEu) % 8u)
			{
			case 7u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = 647300136;
				continue;
			case 6u:
				result = jSONNode;
				num2 = ((int)num3 * -2018797959) ^ -263400205;
				continue;
			case 5u:
				break;
			case 3u:
				num2 = ((int)num3 * -2113172376) ^ -1638647990;
				continue;
			case 2u:
				result = null;
				num2 = (int)((num3 * 1244888702) ^ 0x308A5CCE);
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1430972303;
					num5 = -1430972303;
				}
				else
				{
					num4 = -1061177860;
					num5 = -1061177860;
				}
				num2 = num4 ^ (int)(num3 * 126762700);
				continue;
			}
			case 1u:
				goto IL_00b5;
			default:
				return result;
			}
			break;
		}
		goto IL_003b;
		IL_00c6:
		flag = (byte)num != 0;
		num2 = 131394766;
		goto IL_0084;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1925333447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E715EFEu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1285907064) ^ 0x489339CE);
					continue;
				case 1u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -932278093) ^ -1402523829;
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
		//yield-return decompiler failed: Missing enumeratorCtor.Body
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
			int num = 1647954501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29DD5E5Au) % 4u)
				{
				case 3u:
					string_ = "[ ";
					num = (int)(num2 * 1000181156) ^ -923558514;
					continue;
				case 0u:
					num = (int)(num2 * 1840779759) ^ -1753035661;
					continue;
				case 2u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0136:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1634336551;
								num4 = 1634336551;
							}
							else
							{
								num3 = 460411659;
								num4 = 460411659;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x29DD5E5Au) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 316373861;
										num6 = 316373861;
									}
									else
									{
										num5 = 69243459;
										num6 = 69243459;
									}
									num3 = num5 ^ ((int)num2 * -131422145);
									continue;
								}
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 730889113;
									continue;
								case 4u:
									num3 = 460411659;
									continue;
								case 2u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -1896637954) ^ -318628487;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 1252624848;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 1486725191) ^ 0x3B5AB1CC);
									continue;
								default:
									goto end_IL_00f5;
								case 3u:
									break;
								case 5u:
									goto end_IL_00f5;
								}
								goto IL_0136;
								continue;
								end_IL_00f5:
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
							IL_0181:
							int num7 = 1230160046;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x29DD5E5Au) % 3u)
								{
								case 2u:
									goto IL_0155;
								default:
									goto end_IL_0163;
								case 0u:
									break;
								case 1u:
									goto end_IL_0163;
								}
								goto IL_0181;
								IL_0155:
								num7 = (int)(num2 * 736961943) ^ -376761508;
								continue;
								end_IL_0163:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = 641419610;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x29DD5E5Au) % 3u)
							{
							case 1u:
								goto IL_0197;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0197:
							result = string_;
							num8 = ((int)num2 * -1252584259) ^ -1130440669;
						}
					}
				}
				}
				break;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_00f6:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -377326719;
					num2 = -377326719;
				}
				else
				{
					num = -1512961164;
					num2 = -1512961164;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x8BF88AAAu) % 7u)
					{
					case 6u:
						num = -377326719;
						continue;
					case 4u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 966858995) ^ 0x6166159C);
						continue;
					case 3u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = -1770540547;
						continue;
					case 2u:
					{
						current = enumerator.Current;
						int num4;
						if (JSONArray.smethod_30(string_) <= 3)
						{
							num = -701779191;
							num4 = -701779191;
						}
						else
						{
							num = -1422086403;
							num4 = -1422086403;
						}
						continue;
					}
					case 1u:
						num = (int)((num3 * 1784932568) ^ 0x30B4B121);
						continue;
					default:
						goto end_IL_00b9;
					case 5u:
						break;
					case 0u:
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
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = string_;
		while (true)
		{
			int num5 = -2140341874;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num5 ^ 0x8BF88AAAu) % 3u)
				{
				case 1u:
					goto IL_012b;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_012b:
				num5 = ((int)num3 * -1425325351) ^ -2041319745;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		while (true)
		{
			int num = -1274479335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC28BB33Du) % 9u)
				{
				case 6u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -38945305) ^ -1313778789;
					continue;
				case 5u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 1468330692) ^ -524661003;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 1176629025) ^ -1386212589;
					continue;
				case 3u:
					num = (int)(num2 * 663827783) ^ -832764230;
					continue;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 990230614) ^ 0x534EE215);
					continue;
				case 1u:
					m_List[num3].Serialize(aWriter);
					num = -103767350;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = -47163637;
						num4 = -47163637;
					}
					else
					{
						num = -1794212812;
						num4 = -1794212812;
					}
					continue;
				}
				default:
					return;
				case 8u:
					break;
				case 7u:
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
			int num = 2139006114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5673E905u) % 3u)
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
				num = (int)((num2 * 590341782) ^ 0x212B24CF);
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
