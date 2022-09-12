using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON;

public class JSONClass : JSONNode, IEnumerable
{
	private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 197407092;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A5CCB36u) % 6u)
					{
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = 814610131;
						continue;
					case 3u:
						num = (int)(num2 * 883243849) ^ -1812702015;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = 950698905;
							num4 = 950698905;
						}
						else
						{
							num3 = 1409217597;
							num4 = 1409217597;
						}
						num = num3 ^ (int)(num2 * 39027822);
						continue;
					}
					case 1u:
						result = m_Dict[aKey];
						num = (int)((num2 * 505618072) ^ 0x722D7BC4);
						continue;
					case 4u:
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
			bool flag = default(bool);
			while (true)
			{
				int num = 1030801;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20D7EEFAu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1623715464;
							num4 = -1623715464;
						}
						else
						{
							num3 = -653029577;
							num4 = -653029577;
						}
						num = num3 ^ (int)(num2 * 851264185);
						continue;
					}
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 1574067175) ^ -1946847541;
						continue;
					case 3u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1553316077) ^ -1292199421;
						continue;
					case 1u:
						num = ((int)num2 * -1638522847) ^ 0x5BE5679C;
						continue;
					case 0u:
						m_Dict.Add(aKey, value);
						num = 1153736038;
						continue;
					default:
						return;
					case 2u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -2000388564;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x87AD7237u) % 6u)
					{
					case 5u:
						result = null;
						num = ((int)num2 * -78488093) ^ 0x305B7D29;
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -290594632) ^ -1089762255;
							continue;
						}
						goto IL_002d;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = -1215824793;
							num3 = -1215824793;
							continue;
						}
						goto IL_002d;
					case 0u:
						result = null;
						num = -842695830;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_002d:
						num = -1402382826;
						num3 = -1402382826;
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
				int num = 398787404;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x3521E196u) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1530962640) ^ 0x22A8C77D;
						continue;
					case 3u:
						if (aIndex < m_Dict.Count)
						{
							num = 172747405;
							num3 = 172747405;
							continue;
						}
						goto IL_0031;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1564559744) ^ 0x755E20AC;
							continue;
						}
						goto IL_0031;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
						IL_0031:
						num = 920275667;
						num3 = 920275667;
						continue;
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
				int num = -510986124;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA38B81F2u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 442725217) ^ -1090833272;
						continue;
					case 2u:
						count = m_Dict.Count;
						num = (int)((num2 * 24269222) ^ 0x4B82B961);
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
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -371719101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED83CE49u) % 3u)
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
					num = ((int)num2 * -1810426794) ^ 0x2542CB7;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		if (!JSONClass.smethod_30(aKey))
		{
			goto IL_008f;
		}
		goto IL_0110;
		IL_0110:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = -1308642960;
		goto IL_00ce;
		IL_00ce:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD3A593CEu) % 12u)
			{
			case 11u:
				m_Dict[aKey] = aItem;
				num = (int)(num2 * 690458762) ^ -468297332;
				continue;
			case 10u:
				num = ((int)num2 * -770374773) ^ -1720185155;
				continue;
			case 8u:
				num = (int)((num2 * 1318851555) ^ 0x170021E8);
				continue;
			case 7u:
				m_Dict.Add(aKey, aItem);
				num = -1584956478;
				continue;
			case 6u:
				flag = m_Dict.ContainsKey(aKey);
				num = (int)((num2 * 1543782565) ^ 0x52A4BC63);
				continue;
			case 5u:
				num = (int)((num2 * 1838551763) ^ 0x721415DC);
				continue;
			case 4u:
				break;
			case 3u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = -107132514;
					num4 = -107132514;
				}
				else
				{
					num3 = -1577986082;
					num4 = -1577986082;
				}
				num = num3 ^ ((int)num2 * -1222737443);
				continue;
			}
			case 2u:
				num = -1749674393;
				continue;
			case 0u:
				num = ((int)num2 * -118726592) ^ -105524148;
				continue;
			default:
				return;
			case 9u:
				goto IL_0110;
			case 1u:
				return;
			}
			break;
		}
		goto IL_008f;
		IL_008f:
		num = -1513419284;
		goto IL_00ce;
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 455713745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x508835D4u) % 7u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1622636629;
						num4 = -1622636629;
					}
					else
					{
						num3 = -689610462;
						num4 = -689610462;
					}
					num = num3 ^ ((int)num2 * -848035750);
					continue;
				}
				case 3u:
					result = null;
					num = (int)((num2 * 2023479815) ^ 0xBC55298);
					continue;
				case 2u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = 1203302773;
					continue;
				}
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1392897964) ^ -805009514;
					continue;
				case 0u:
					num = (int)((num2 * 659813437) ^ 0x62BBEAB0);
					continue;
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 921649100;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x78BDC26Du) % 7u)
				{
				case 5u:
					result = null;
					num = (int)((num2 * 744301845) ^ 0x78DFE6CA);
					continue;
				case 4u:
					num = (int)(num2 * 1607120263) ^ -1865925445;
					continue;
				case 3u:
					if (aIndex < m_Dict.Count)
					{
						num = 412396587;
						num3 = 412396587;
						continue;
					}
					goto IL_0045;
				case 2u:
					result = null;
					num = 1200366105;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 1631023009) ^ -150518995;
						continue;
					}
					goto IL_0045;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0045:
					num = 111844676;
					num3 = 111844676;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1728911308;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CAF2448u) % 3u)
					{
					case 1u:
						goto IL_0004;
					case 0u:
						break;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_0004:
					result = null;
					num = (int)((num2 * 1132086066) ^ 0x5C302341);
				}
			}
		}
		catch
		{
			return null;
		}
	}

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CGetEnumerator_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string text = "{";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0138:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 224621129;
					num2 = 224621129;
				}
				else
				{
					num = 363867330;
					num2 = 363867330;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x4B558D85u) % 9u)
					{
					case 8u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1384671940) ^ -174924478;
						continue;
					case 7u:
						current = enumerator.Current;
						num = 1860725928;
						continue;
					case 6u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = 1102697574;
						continue;
					case 5u:
						num = 224621129;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1671356600;
							num5 = 1671356600;
						}
						else
						{
							num4 = 728954300;
							num5 = 728954300;
						}
						num = num4 ^ (int)(num3 * 717822125);
						continue;
					}
					case 2u:
						flag = JSONClass.smethod_31(text) > 2;
						num = (int)((num3 * 1081878817) ^ 0x17EC0C37);
						continue;
					case 1u:
						num = ((int)num3 * -863263736) ^ -1718827063;
						continue;
					default:
						goto end_IL_00f2;
					case 4u:
						break;
					case 0u:
						goto end_IL_00f2;
					}
					goto IL_0138;
					continue;
					end_IL_00f2:
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
				IL_0183:
				int num6 = 744198036;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x4B558D85u) % 3u)
					{
					case 1u:
						goto IL_0157;
					default:
						goto end_IL_0165;
					case 0u:
						break;
					case 2u:
						goto end_IL_0165;
					}
					goto IL_0183;
					IL_0157:
					num6 = ((int)num3 * -732591548) ^ -1990287884;
					continue;
					end_IL_0165:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num7 = 1120799612;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x4B558D85u) % 4u)
				{
				case 3u:
					num7 = ((int)num3 * -53032683) ^ 0x2F27E35E;
					continue;
				case 1u:
					result = text;
					num7 = ((int)num3 * -894226779) ^ -48529089;
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

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 944824105;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x542FC3DBu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0184:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 526560821;
								num4 = 526560821;
							}
							else
							{
								num3 = 81567881;
								num4 = 81567881;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x542FC3DBu) % 9u)
								{
								case 8u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = 552674416;
									continue;
								case 7u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -2096671868) ^ -1964547212;
									continue;
								case 5u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1118657459) ^ -1978527002;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -837099616;
										num6 = -837099616;
									}
									else
									{
										num5 = -429565355;
										num6 = -429565355;
									}
									num3 = num5 ^ (int)(num2 * 1408759777);
									continue;
								}
								case 3u:
									num3 = 526560821;
									continue;
								case 2u:
									num3 = (int)((num2 * 1370531044) ^ 0x22E516C9);
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 1945376873;
									continue;
								default:
									goto end_IL_013e;
								case 6u:
									break;
								case 0u:
									goto end_IL_013e;
								}
								goto IL_0184;
								continue;
								end_IL_013e:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = 933980993;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x542FC3DBu) % 4u)
							{
							case 2u:
								result = text;
								num7 = ((int)num2 * -658532349) ^ -2014965768;
								continue;
							case 1u:
								num7 = ((int)num2 * -1355841939) ^ 0x36A42FD;
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
				IL_0008:
				num = (int)((num2 * 301902674) ^ 0x5E08121D);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -480534992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6422E65u) % 4u)
				{
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 794678486) ^ -1604170801;
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 1494141646) ^ -763211772;
					continue;
				case 2u:
					break;
				default:
				{
					using Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -1765657910;
							num4 = -1765657910;
						}
						else
						{
							num3 = -244789864;
							num4 = -244789864;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xA6422E65u) % 7u)
							{
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 1476830088) ^ 0x10E5FCDC);
								continue;
							case 5u:
								num3 = -244789864;
								continue;
							case 2u:
								current = enumerator.Current;
								num3 = -104942112;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1612757813) ^ 0x4534733C);
								continue;
							case 0u:
								num3 = (int)(num2 * 228548768) ^ -113812251;
								continue;
							default:
								return;
							case 4u:
								break;
							case 3u:
								return;
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

	static bool smethod_30(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static int smethod_31(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_32(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_33(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_34(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_35(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_36(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_37(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	static void smethod_38(BinaryWriter binaryWriter_0, string string_0)
	{
		binaryWriter_0.Write(string_0);
	}
}
