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
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_003b;
			}
			goto IL_0065;
			IL_0065:
			JSONNode result = new JSONLazyCreator(this, aKey);
			int num = -836395431;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAB3566Du) % 5u)
				{
				case 2u:
					num = ((int)num2 * -2014862718) ^ 0xF355C4A;
					continue;
				case 1u:
					result = m_Dict[aKey];
					num = (int)((num2 * 441491631) ^ 0x1BC13820);
					continue;
				case 0u:
					break;
				case 3u:
					goto IL_0065;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = -918552333;
			goto IL_0040;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -174730161;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFEC087Bu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1904258449) ^ 0x54A19AB9;
						continue;
					case 6u:
						m_Dict.Add(aKey, value);
						num = -197070010;
						continue;
					case 5u:
						num = ((int)num2 * -1467642055) ^ -1436818251;
						continue;
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1650571102) ^ 0x24424A2B;
						continue;
					case 1u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -826638162) ^ -1809649278;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1078635642;
							num4 = 1078635642;
						}
						else
						{
							num3 = 1480217277;
							num4 = 1480217277;
						}
						num = num3 ^ ((int)num2 * -1937578642);
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 3u:
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
			if (aIndex >= 0)
			{
				goto IL_0019;
			}
			int num = 1;
			goto IL_009a;
			IL_009a:
			bool flag = (byte)num != 0;
			int num2 = 1863629593;
			goto IL_005c;
			IL_0019:
			num2 = 1454794340;
			goto IL_005c;
			IL_005c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x705E7A85u) % 7u)
				{
				case 5u:
					num2 = ((int)num3 * -1223654435) ^ -2088679689;
					continue;
				case 4u:
					break;
				case 3u:
					result = null;
					num2 = (int)((num3 * 711563476) ^ 0x662E10ED);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -713371610;
						num5 = -713371610;
					}
					else
					{
						num4 = -2108016618;
						num5 = -2108016618;
					}
					num2 = num4 ^ ((int)num3 * -1602149210);
					continue;
				}
				case 0u:
					result = null;
					num2 = 1890928019;
					continue;
				case 6u:
					goto IL_0089;
				default:
					return result;
				}
				break;
			}
			goto IL_0019;
			IL_0089:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_009a;
		}
		set
		{
			while (true)
			{
				int num = -1657269134;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xD89E01BDu) % 5u)
					{
					case 4u:
						if (aIndex < m_Dict.Count)
						{
							num = -1837094386;
							num3 = -1837094386;
							continue;
						}
						goto IL_0022;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1562868198) ^ -1556145760;
							continue;
						}
						goto IL_0022;
					case 2u:
						num = ((int)num2 * -708033293) ^ 0x66A1FCD;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
						IL_0022:
						num = -1430602164;
						num3 = -1430602164;
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
				int num = -1738992522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE28866EDu) % 4u)
					{
					case 3u:
						count = m_Dict.Count;
						num = ((int)num2 * -856927317) ^ -530551119;
						continue;
					case 1u:
						num = ((int)num2 * -1522869165) ^ 0x6BD0DC00;
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		if (!JSONClass.smethod_30(aKey))
		{
			goto IL_0043;
		}
		goto IL_00fa;
		IL_00fa:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = 2125686480;
		goto IL_00bc;
		IL_00bc:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4FD9D5ABu) % 11u)
			{
			case 10u:
				m_Dict.Add(aKey, aItem);
				num = 1689876384;
				continue;
			case 9u:
				m_Dict[aKey] = aItem;
				num = ((int)num2 * -891384099) ^ -1828553559;
				continue;
			case 8u:
				break;
			case 5u:
				num = ((int)num2 * -1732076612) ^ -980303648;
				continue;
			case 4u:
				flag = m_Dict.ContainsKey(aKey);
				num = ((int)num2 * -328557150) ^ 0x37BD22D1;
				continue;
			case 3u:
				num = 1039394638;
				continue;
			case 2u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -337020666;
					num4 = -337020666;
				}
				else
				{
					num3 = -269739329;
					num4 = -269739329;
				}
				num = num3 ^ ((int)num2 * -1803255672);
				continue;
			}
			case 1u:
				num = ((int)num2 * -1071159967) ^ 0x1BD3CF80;
				continue;
			case 0u:
				num = (int)((num2 * 43824734) ^ 0x6848BE64);
				continue;
			default:
				return;
			case 6u:
				goto IL_00fa;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0043;
		IL_0043:
		num = 1732332864;
		goto IL_00bc;
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1375383781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6955DAu) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 957842758;
						num4 = 957842758;
					}
					else
					{
						num3 = 639366082;
						num4 = 639366082;
					}
					num = num3 ^ ((int)num2 * -2143709124);
					continue;
				}
				case 6u:
					m_Dict.Remove(aKey);
					num = ((int)num2 * -842601080) ^ 0x19A97180;
					continue;
				case 5u:
					num = (int)((num2 * 1581000675) ^ 0x264339DC);
					continue;
				case 4u:
					jSONNode = m_Dict[aKey];
					num = 5439100;
					continue;
				case 2u:
					result = jSONNode;
					num = ((int)num2 * -1506114767) ^ 0x35CF194D;
					continue;
				case 0u:
					result = null;
					num = ((int)num2 * -1937479714) ^ 0x1D16277B;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -163874369;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xBA04F439u) % 8u)
				{
				case 7u:
					result = null;
					num = ((int)num2 * -1737393412) ^ -926347756;
					continue;
				case 6u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -234173852) ^ -1784932702;
						continue;
					}
					num5 = 1;
					goto IL_002b;
				case 4u:
					num = ((int)num2 * -1524067304) ^ 0x7E3068F0;
					continue;
				case 3u:
					num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_002b;
				case 2u:
					result = null;
					num = -359419339;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1383512509;
						num4 = -1383512509;
					}
					else
					{
						num3 = -44761362;
						num4 = -44761362;
					}
					num = num3 ^ ((int)num2 * -262876001);
					continue;
				}
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_002b:
					flag = (byte)num5 != 0;
					num = -332889263;
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
			return null;
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
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0149:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1394168430;
					num2 = 1394168430;
				}
				else
				{
					num = 235458905;
					num2 = 235458905;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x3DC602AFu) % 10u)
					{
					case 9u:
						num = (int)(num3 * 746079235) ^ -1704916516;
						continue;
					case 8u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = 754961817;
						continue;
					case 7u:
						num = 1394168430;
						continue;
					case 6u:
						flag = JSONClass.smethod_31(text) > 2;
						num = ((int)num3 * -1629768770) ^ 0x510C62B5;
						continue;
					case 3u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)((num3 * 773625056) ^ 0x12CEEC83);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -153743375;
							num5 = -153743375;
						}
						else
						{
							num4 = -445194322;
							num5 = -445194322;
						}
						num = num4 ^ (int)(num3 * 319651613);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = 1031339086;
						continue;
					case 0u:
						num = ((int)num3 * -656404522) ^ -244576098;
						continue;
					default:
						goto end_IL_00ff;
					case 5u:
						break;
					case 4u:
						goto end_IL_00ff;
					}
					goto IL_0149;
					continue;
					end_IL_00ff:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num6 = 1293500098;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x3DC602AFu) % 4u)
				{
				case 1u:
					result = text;
					num6 = ((int)num3 * -1927622547) ^ -1098111426;
					continue;
				case 0u:
					num6 = ((int)num3 * -1131823532) ^ -1741752875;
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

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0150:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -549818723;
					num2 = -549818723;
				}
				else
				{
					num = -1023495446;
					num2 = -1023495446;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE01142E3u) % 9u)
					{
					case 8u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = (int)((num3 * 482645660) ^ 0x467B70CD);
						continue;
					case 7u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						num = -1848076782;
						continue;
					case 5u:
						num = -1023495446;
						continue;
					case 4u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -865619501) ^ 0x60EA9CD2;
						continue;
					case 3u:
						current = enumerator.Current;
						num = -2077759110;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 3)
						{
							num4 = 571928932;
							num5 = 571928932;
						}
						else
						{
							num4 = 657805969;
							num5 = 657805969;
						}
						num = num4 ^ ((int)num3 * -166679444);
						continue;
					}
					case 1u:
						num = ((int)num3 * -1151509203) ^ 0x5C10CB13;
						continue;
					default:
						goto end_IL_010a;
					case 6u:
						break;
					case 0u:
						goto end_IL_010a;
					}
					goto IL_0150;
					continue;
					end_IL_010a:
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
				IL_019b:
				int num6 = -59283778;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xE01142E3u) % 3u)
					{
					case 1u:
						goto IL_016f;
					default:
						goto end_IL_017d;
					case 0u:
						break;
					case 2u:
						goto end_IL_017d;
					}
					goto IL_019b;
					IL_016f:
					num6 = (int)(num3 * 235008969) ^ -2096478498;
					continue;
					end_IL_017d:
					break;
				}
				break;
			}
		}
		return JSONClass.smethod_35(text, "\n", aPrefix, "}");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = 100202199;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3877325u) % 5u)
				{
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 258066766) ^ 0x72BBC4DE);
					continue;
				case 2u:
					num = (int)((num2 * 1301097136) ^ 0x2BA5D6A1);
					continue;
				case 1u:
					num = (int)(num2 * 1360718143) ^ -1462461932;
					continue;
				case 4u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					try
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 914849515;
								num4 = 914849515;
							}
							else
							{
								num3 = 1946875347;
								num4 = 1946875347;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3877325u) % 9u)
								{
								case 8u:
									num3 = (int)((num2 * 570937661) ^ 0x5FB2D6C4);
									continue;
								case 6u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -488347816) ^ 0x3201CC9A;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 2084023701;
									continue;
								case 4u:
									JSONClass.smethod_38(aWriter, current);
									num3 = ((int)num2 * -2088283262) ^ 0x137F5214;
									continue;
								case 3u:
									num3 = 914849515;
									continue;
								case 2u:
									num3 = ((int)num2 * -1247872441) ^ 0x48200446;
									continue;
								case 1u:
									num3 = (int)(num2 * 1391015240) ^ -1878994408;
									continue;
								default:
									return;
								case 0u:
									break;
								case 7u:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_019b:
							int num5 = 752510161;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x3877325u) % 3u)
								{
								case 2u:
									goto IL_0171;
								default:
									goto end_IL_017e;
								case 0u:
									break;
								case 1u:
									goto end_IL_017e;
								}
								goto IL_019b;
								IL_0171:
								num5 = (int)((num2 * 1199636618) ^ 0x13EE840);
								continue;
								end_IL_017e:
								break;
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

	public JSONClass()
	{
		while (true)
		{
			int num = -1362135352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5A28CD0u) % 3u)
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
				num = (int)(num2 * 1694918923) ^ -1064419472;
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
