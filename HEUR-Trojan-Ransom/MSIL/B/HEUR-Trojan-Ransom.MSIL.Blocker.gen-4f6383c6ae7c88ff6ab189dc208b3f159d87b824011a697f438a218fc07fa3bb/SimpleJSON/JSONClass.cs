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
				int num = 1934479245;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EF60FF0u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = -557624731;
							num4 = -557624731;
						}
						else
						{
							num3 = -443062547;
							num4 = -443062547;
						}
						num = num3 ^ (int)(num2 * 1162615796);
						continue;
					}
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = 1337609808;
						continue;
					case 2u:
						num = (int)(num2 * 1317421888) ^ -2048739632;
						continue;
					case 1u:
						result = m_Dict[aKey];
						num = (int)(num2 * 864076537) ^ -615839693;
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
			bool flag = default(bool);
			while (true)
			{
				int num = 1048273685;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF865CDFu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -2067360198) ^ 0x1E5B411D;
						continue;
					case 6u:
						num = ((int)num2 * -812596822) ^ 0xABA2C54;
						continue;
					case 5u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 107187032) ^ 0x8AFB7F9);
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 1266664243) ^ -497583936;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1727202448;
							num4 = 1727202448;
						}
						else
						{
							num3 = 2131126149;
							num4 = 2131126149;
						}
						num = num3 ^ ((int)num2 * -10177721);
						continue;
					}
					case 0u:
						m_Dict.Add(aKey, value);
						num = 2071236939;
						continue;
					default:
						return;
					case 3u:
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
				int num = 892919214;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x5A551C24u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1753823811) ^ 0x7A1672D2;
						continue;
					case 7u:
						result = null;
						num = ((int)num2 * -1555407602) ^ 0x3D667238;
						continue;
					case 5u:
						num = ((int)num2 * -1268752737) ^ -822581789;
						continue;
					case 3u:
						result = null;
						num = 1268463683;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 860247260) ^ 0x6DF83ECB);
							continue;
						}
						num5 = 1;
						goto IL_0052;
					case 1u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0052;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -905699834;
							num4 = -905699834;
						}
						else
						{
							num3 = -220063387;
							num4 = -220063387;
						}
						num = num3 ^ (int)(num2 * 1135268444);
						continue;
					}
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0052:
						flag = (byte)num5 != 0;
						num = 1841898519;
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
				int num = -2059164692;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBD2B6C40u) % 5u)
					{
					case 4u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1596961662) ^ 0x528C90FA;
							continue;
						}
						goto IL_0019;
					case 1u:
						if (aIndex < m_Dict.Count)
						{
							num = -1338057012;
							num3 = -1338057012;
							continue;
						}
						goto IL_0019;
					case 0u:
						num = (int)(num2 * 1039934521) ^ -377121902;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
						IL_0019:
						num = -268892146;
						num3 = -268892146;
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
				int num = 1343401152;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x658E1DC6u) % 4u)
					{
					case 2u:
						count = m_Dict.Count;
						num = ((int)num2 * -1377640242) ^ -1442399345;
						continue;
					case 1u:
						num = ((int)num2 * -1767395712) ^ 0x2B52A012;
						continue;
					case 3u:
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
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1962999615;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1CEF18C8u) % 13u)
				{
				case 12u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 1857334355) ^ 0x43ACBAB);
					continue;
				case 11u:
					num = ((int)num2 * -756831641) ^ -1169961208;
					continue;
				case 9u:
					num = 1798261659;
					continue;
				case 8u:
					num = (int)(num2 * 837537231) ^ -687018180;
					continue;
				case 7u:
					m_Dict.Add(aKey, aItem);
					num = 1128071868;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 888260401;
						num6 = 888260401;
					}
					else
					{
						num5 = 457588413;
						num6 = 457588413;
					}
					num = num5 ^ (int)(num2 * 2080194702);
					continue;
				}
				case 5u:
					num = ((int)num2 * -514310502) ^ 0x593CEFE0;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 1823575606;
						num4 = 1823575606;
					}
					else
					{
						num3 = 801929678;
						num4 = 801929678;
					}
					num = num3 ^ (int)(num2 * 1534692405);
					continue;
				}
				case 2u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -1199768050) ^ -1038398608;
					continue;
				case 1u:
					flag = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -950637588) ^ -136875002;
					continue;
				case 0u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1133709373;
					continue;
				default:
					return;
				case 10u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 2039924640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x691941A1u) % 8u)
				{
				case 6u:
					num = (int)((num2 * 651568555) ^ 0x6E730B24);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1496218023;
						num4 = -1496218023;
					}
					else
					{
						num3 = -2034702441;
						num4 = -2034702441;
					}
					num = num3 ^ ((int)num2 * -2044098318);
					continue;
				}
				case 4u:
					result = null;
					num = ((int)num2 * -526238349) ^ 0x185AEC62;
					continue;
				case 3u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = (int)((num2 * 2120876696) ^ 0x1D19EB8F);
					continue;
				case 2u:
					jSONNode = m_Dict[aKey];
					num = 2006017434;
					continue;
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -924429741) ^ -557134185;
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
		while (true)
		{
			int num = 170065169;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x3E75847Du) % 8u)
				{
				case 6u:
					result = null;
					num = 1707906229;
					continue;
				case 5u:
					if (aIndex < m_Dict.Count)
					{
						num = 2038790427;
						num3 = 2038790427;
						continue;
					}
					goto IL_0022;
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1257799090) ^ 0x63FCD1D0;
						continue;
					}
					goto IL_0022;
				case 3u:
					result = null;
					num = (int)((num2 * 738255361) ^ 0x443E7A37);
					continue;
				case 1u:
					num = ((int)num2 * -829022859) ^ -1678774825;
					continue;
				case 0u:
					num = (int)(num2 * 165108480) ^ -547140286;
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0022:
					num = 131062422;
					num3 = 131062422;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_006a: Incompatible stack heights: 0 vs 1
		//IL_007b: Incompatible stack heights: 0 vs 1
		//IL_0082: Incompatible stack heights: 0 vs 1
		JSONNode result = default(JSONNode);
		try
		{
			while (true)
			{
				int num = -1657931984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA5471B52u) % 3u)
					{
					case 1u:
						goto IL_0004;
					case 2u:
						break;
					default:
						return result;
					case 0u:
						return result;
					}
					break;
					IL_0004:
					result = null;
					num = (int)(num2 * 30535179) ^ -226600471;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = -103417779;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ -1522066606;
					uint num2 = (uint)(int)val;
					switch (val % 4)
					{
					case 3:
						_ = (num2 * 713051953) ^ 0x7BAAB4F1;
						continue;
					case 0:
						result = null;
						_ = ((int)num2 * -882703744) ^ 0x6B25343;
						continue;
					case 2:
						break;
					default:
						return result;
					case 1:
						return result;
					}
					break;
				}
			}
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
		string text = default(string);
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -1893703070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4DE8703u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1829068704) ^ 0x60827D3B);
					continue;
				case 1u:
					text = "{";
					num = (int)(num2 * 465259176) ^ -702060563;
					continue;
				case 3u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_019c:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -854076013;
								num4 = -854076013;
							}
							else
							{
								num3 = -373148730;
								num4 = -373148730;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC4DE8703u) % 10u)
								{
								case 9u:
									num3 = ((int)num2 * -619732243) ^ -804682049;
									continue;
								case 8u:
									num3 = ((int)num2 * -476139596) ^ 0x77256880;
									continue;
								case 7u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)(num2 * 323101920) ^ -2026642060;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = -1525320032;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -162141220) ^ -1651825607;
									continue;
								case 2u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -1187021047;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1087809848;
										num6 = -1087809848;
									}
									else
									{
										num5 = -1264017616;
										num6 = -1264017616;
									}
									num3 = num5 ^ (int)(num2 * 1315133823);
									continue;
								}
								case 0u:
									num3 = -854076013;
									continue;
								default:
									goto end_IL_0152;
								case 3u:
									break;
								case 5u:
									goto end_IL_0152;
								}
								goto IL_019c;
								continue;
								end_IL_0152:
								break;
							}
							break;
						}
					}
					return JSONClass.smethod_32(text, "}");
				}
				}
				break;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_013e:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -244366997;
					num2 = -244366997;
				}
				else
				{
					num = -350101884;
					num2 = -350101884;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x93E8B54Du) % 8u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 3)
						{
							num4 = 247072037;
							num5 = 247072037;
						}
						else
						{
							num4 = 1825319796;
							num5 = 1825319796;
						}
						num = num4 ^ (int)(num3 * 99112652);
						continue;
					}
					case 5u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1730211059) ^ 0x13ADBE78;
						continue;
					case 4u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = -1291928905;
						continue;
					case 2u:
						num = (int)((num3 * 448863161) ^ 0x5FE35444);
						continue;
					case 1u:
						current = enumerator.Current;
						num = -583147062;
						continue;
					case 0u:
						num = -350101884;
						continue;
					default:
						goto end_IL_00fd;
					case 3u:
						break;
					case 6u:
						goto end_IL_00fd;
					}
					goto IL_013e;
					continue;
					end_IL_00fd:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num6 = -760202740;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x93E8B54Du) % 4u)
				{
				case 1u:
					result = text;
					num6 = ((int)num3 * -410669843) ^ -1158951516;
					continue;
				case 0u:
					num6 = ((int)num3 * -2087006591) ^ -1719121722;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -668437070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B98B3D7u) % 6u)
				{
				case 4u:
					num = (int)((num2 * 741720910) ^ 0x9DF726E);
					continue;
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 993397468) ^ 0x62204A9F);
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -573448830) ^ -876836015;
					continue;
				case 1u:
					num = ((int)num2 * -1232692256) ^ 0x2FE31B69;
					continue;
				case 5u:
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
								num3 = -1701154618;
								num4 = -1701154618;
							}
							else
							{
								num3 = -1250325295;
								num4 = -1250325295;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8B98B3D7u) % 8u)
								{
								case 7u:
									num3 = (int)(num2 * 1809948435) ^ -147463143;
									continue;
								case 5u:
									num3 = -1701154618;
									continue;
								case 4u:
									num3 = ((int)num2 * -2137471783) ^ -767025943;
									continue;
								case 2u:
									JSONClass.smethod_38(aWriter, current);
									num3 = (int)(num2 * 185527296) ^ -1185155649;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1858951397;
									continue;
								case 0u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -732213108) ^ -1467302296;
									continue;
								default:
									return;
								case 3u:
									break;
								case 6u:
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
							int num5 = -2055518241;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x8B98B3D7u) % 3u)
								{
								case 1u:
									goto IL_0171;
								default:
									goto end_IL_017e;
								case 2u:
									break;
								case 0u:
									goto end_IL_017e;
								}
								goto IL_019b;
								IL_0171:
								num5 = ((int)num2 * -2019917696) ^ -239772491;
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
			int num = -2106304317;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE11DBF2u) % 3u)
				{
				case 2u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0013:
				num = (int)((num2 * 296347940) ^ 0x61F33F1B);
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
