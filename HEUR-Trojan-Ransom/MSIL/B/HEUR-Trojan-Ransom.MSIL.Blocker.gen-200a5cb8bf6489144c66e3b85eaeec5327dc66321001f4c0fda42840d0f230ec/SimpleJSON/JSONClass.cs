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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1542565509;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC70C4D80u) % 6u)
					{
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -861232754) ^ 0x650D4FDC;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1756489515;
							num4 = 1756489515;
						}
						else
						{
							num3 = 1239934460;
							num4 = 1239934460;
						}
						num = num3 ^ ((int)num2 * -219112089);
						continue;
					}
					case 3u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1467836537) ^ 0x45C84C9C;
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = -675897733;
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
				int num = 1754095801;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x57653B38u) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1620726246) ^ 0x1B377DC5);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = -1066395363;
							num4 = -1066395363;
						}
						else
						{
							num3 = -1122702064;
							num4 = -1122702064;
						}
						num = num3 ^ (int)(num2 * 173022294);
						continue;
					}
					case 3u:
						num = ((int)num2 * -1647518394) ^ -922974283;
						continue;
					case 1u:
						m_Dict.Add(aKey, value);
						num = 1288129633;
						continue;
					case 0u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1055063403) ^ 0x21AD2136;
						continue;
					default:
						return;
					case 2u:
						break;
					case 4u:
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
			bool flag = default(bool);
			while (true)
			{
				int num = 1282577399;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x5A6C6533u) % 8u)
					{
					case 7u:
						result = null;
						num = ((int)num2 * -1917570153) ^ -562776513;
						continue;
					case 6u:
						num = (int)(num2 * 291861096) ^ -130663210;
						continue;
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1641426220) ^ -3632720;
							continue;
						}
						num5 = 1;
						goto IL_003a;
					case 3u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_003a;
					case 2u:
						result = null;
						num = 958554309;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1578307748;
							num4 = -1578307748;
						}
						else
						{
							num3 = -809643327;
							num4 = -809643327;
						}
						num = num3 ^ ((int)num2 * -1125463648);
						continue;
					}
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_003a:
						flag = (byte)num5 != 0;
						num = 861366442;
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
				int num = -1054822119;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x8B5D3EB0u) % 5u)
					{
					case 3u:
						if (aIndex < m_Dict.Count)
						{
							num = -98474786;
							num3 = -98474786;
							continue;
						}
						goto IL_0016;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1805809219) ^ -1716271861;
							continue;
						}
						goto IL_0016;
					case 0u:
						num = (int)(num2 * 1186839806) ^ -1252486436;
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
						return;
						IL_0016:
						num = -223913777;
						num3 = -223913777;
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
				int num = -1893800895;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4A414B8u) % 3u)
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
					count = m_Dict.Count;
					num = (int)((num2 * 148919038) ^ 0x3E84BE8D);
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			while (true)
			{
				int num = -1535852568;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x832A5D71u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -118145983) ^ -147055798;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 416726145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F6AEA23u) % 15u)
				{
				case 12u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = (int)((num2 * 2070510876) ^ 0x504D91F7);
					continue;
				case 11u:
					num = (int)((num2 * 489015227) ^ 0x361CE339);
					continue;
				case 10u:
					num = (int)((num2 * 1208197233) ^ 0x7ED07B87);
					continue;
				case 9u:
					m_Dict.Add(aKey, aItem);
					num = 1741199229;
					continue;
				case 8u:
					num = (int)((num2 * 191477897) ^ 0x63DF18CF);
					continue;
				case 7u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 701309331) ^ -1849023592;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 406558945;
						num6 = 406558945;
					}
					else
					{
						num5 = 2093819623;
						num6 = 2093819623;
					}
					num = num5 ^ ((int)num2 * -1803092196);
					continue;
				}
				case 5u:
					num = (int)((num2 * 68412061) ^ 0x50144070);
					continue;
				case 4u:
					flag = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1532432473) ^ 0xB5ACC4F;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -100910103;
						num4 = -100910103;
					}
					else
					{
						num3 = -1662927669;
						num4 = -1662927669;
					}
					num = num3 ^ (int)(num2 * 375057221);
					continue;
				}
				case 2u:
					num = 1713099084;
					continue;
				case 1u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 337102492;
					continue;
				case 0u:
					num = (int)((num2 * 1274497092) ^ 0x17A37AC4);
					continue;
				default:
					return;
				case 13u:
					break;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1663882133;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5D92DBAu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -566444113) ^ 0x5B9AE2DB;
					continue;
				case 6u:
					jSONNode = m_Dict[aKey];
					num = -1875832421;
					continue;
				case 5u:
					result = null;
					num = ((int)num2 * -880953805) ^ -1057263278;
					continue;
				case 4u:
					result = jSONNode;
					num = (int)(num2 * 1793958465) ^ -73816264;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2108980466;
						num4 = 2108980466;
					}
					else
					{
						num3 = 2118765934;
						num4 = 2118765934;
					}
					num = num3 ^ (int)(num2 * 998879153);
					continue;
				}
				case 2u:
					m_Dict.Remove(aKey);
					num = (int)((num2 * 592870870) ^ 0x73388612);
					continue;
				case 1u:
					num = (int)((num2 * 1929533387) ^ 0x7A685BDE);
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 888881727;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x4EBB3511u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -491579950) ^ 0x6445440C;
					continue;
				case 6u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 367573190) ^ -736969083;
						continue;
					}
					num3 = 1;
					goto IL_0029;
				case 5u:
					result = null;
					num = 108463970;
					continue;
				case 2u:
					result = null;
					num = (int)(num2 * 1733028442) ^ -105267334;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 94319527;
						num5 = 94319527;
					}
					else
					{
						num4 = 1799493904;
						num5 = 1799493904;
					}
					num = num4 ^ ((int)num2 * -1261101164);
					continue;
				}
				case 0u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0029;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0029:
					flag = (byte)num3 != 0;
					num = 2042129680;
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
		//yield-return decompiler failed: Missing enumeratorCtor.Body
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
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0138:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1928439062;
					num2 = 1928439062;
				}
				else
				{
					num = 1427206866;
					num2 = 1427206866;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x7991C814u) % 9u)
					{
					case 8u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -745868449) ^ -956743994;
						continue;
					case 7u:
						flag = JSONClass.smethod_31(text) > 2;
						num = ((int)num3 * -327908936) ^ -1889015877;
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
						num = 169701657;
						continue;
					case 3u:
						num = (int)((num3 * 575971737) ^ 0x3115AA43);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1677873175;
							num5 = 1677873175;
						}
						else
						{
							num4 = 1016809917;
							num5 = 1016809917;
						}
						num = num4 ^ (int)(num3 * 1184469315);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = 1057195070;
						continue;
					case 0u:
						num = 1427206866;
						continue;
					default:
						goto end_IL_00f2;
					case 4u:
						break;
					case 5u:
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
				int num6 = 1949844509;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x7991C814u) % 3u)
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
					num6 = ((int)num3 * -1225656456) ^ 0x64A0D3F1;
					continue;
					end_IL_0165:
					break;
				}
				break;
			}
		}
		return JSONClass.smethod_32(text, "}");
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0152:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -725671182;
					num2 = -725671182;
				}
				else
				{
					num = -1685706557;
					num2 = -1685706557;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xD2D9394Eu) % 9u)
					{
					case 7u:
						num = -1685706557;
						continue;
					case 6u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = -873898317;
						continue;
					case 5u:
						num = ((int)num3 * -82375207) ^ 0x6F752AB9;
						continue;
					case 4u:
						flag = JSONClass.smethod_31(text) > 3;
						num = (int)(num3 * 526390631) ^ -1545319089;
						continue;
					case 3u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1764072631) ^ -134804035;
						continue;
					case 2u:
						current = enumerator.Current;
						num = -1919480208;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1152127419;
							num5 = -1152127419;
						}
						else
						{
							num4 = -721595618;
							num5 = -721595618;
						}
						num = num4 ^ (int)(num3 * 446967512);
						continue;
					}
					default:
						goto end_IL_010c;
					case 0u:
						break;
					case 8u:
						goto end_IL_010c;
					}
					goto IL_0152;
					continue;
					end_IL_010c:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = text;
		while (true)
		{
			int num6 = -773615854;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xD2D9394Eu) % 3u)
				{
				case 2u:
					goto IL_0187;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0187:
				num6 = ((int)num3 * -569135203) ^ -1538311736;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -494050248;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF4BB2ADu) % 4u)
				{
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -648608185) ^ 0x1F5A4F32;
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -640704979) ^ -2120748785;
					continue;
				case 3u:
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
							num3 = -1929600925;
							num4 = -1929600925;
						}
						else
						{
							num3 = -1569970025;
							num4 = -1569970025;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xBF4BB2ADu) % 7u)
							{
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -927391199) ^ -218452842;
								continue;
							case 5u:
								num3 = ((int)num2 * -767886764) ^ -1099700028;
								continue;
							case 4u:
								current = enumerator.Current;
								num3 = -723032862;
								continue;
							case 3u:
								num3 = -1569970025;
								continue;
							case 0u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1257769945) ^ 0x54747A8D;
								continue;
							default:
								return;
							case 1u:
								break;
							case 2u:
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

	public JSONClass()
	{
		while (true)
		{
			int num = 800447142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23A3C65Du) % 3u)
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
				num = ((int)num2 * -631728077) ^ 0x231DE75F;
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
