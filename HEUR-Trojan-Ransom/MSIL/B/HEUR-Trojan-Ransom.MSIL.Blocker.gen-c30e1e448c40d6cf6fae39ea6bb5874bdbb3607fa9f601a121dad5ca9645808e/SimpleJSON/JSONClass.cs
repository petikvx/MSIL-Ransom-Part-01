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
				int num = 64641378;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D4D9B5Eu) % 6u)
					{
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = 1930384375;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = -666301649;
							num4 = -666301649;
						}
						else
						{
							num3 = -496701761;
							num4 = -496701761;
						}
						num = num3 ^ (int)(num2 * 1951100737);
						continue;
					}
					case 3u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1124652189) ^ 0x1C816FC7;
						continue;
					case 1u:
						num = ((int)num2 * -1248436153) ^ -1360964897;
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
		set
		{
			while (true)
			{
				int num = 2054166649;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A2552F5u) % 8u)
					{
					case 7u:
						m_Dict.Add(aKey, value);
						num = 1904118263;
						continue;
					case 6u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 785691315) ^ -279821802;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = -592689098;
							num4 = -592689098;
						}
						else
						{
							num3 = -429002129;
							num4 = -429002129;
						}
						num = num3 ^ (int)(num2 * 2070693775);
						continue;
					}
					case 3u:
						num = (int)(num2 * 2070008263) ^ -607795000;
						continue;
					case 2u:
						num = (int)((num2 * 1246999936) ^ 0x5130841D);
						continue;
					case 1u:
						num = (int)(num2 * 742866999) ^ -1929588263;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
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
				int num = 1084531125;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x3C669464u) % 7u)
					{
					case 6u:
						result = null;
						num = 1367660639;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -2081530597;
							num5 = -2081530597;
						}
						else
						{
							num4 = -1576841644;
							num5 = -1576841644;
						}
						num = num4 ^ ((int)num2 * -1323821110);
						continue;
					}
					case 3u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0044;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1532629573) ^ 0x5EBDC469);
							continue;
						}
						num3 = 1;
						goto IL_0044;
					case 1u:
						result = null;
						num = (int)((num2 * 390027935) ^ 0x729CCAC0);
						continue;
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_0044:
						flag = (byte)num3 != 0;
						num = 757851063;
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
				int num = 1849189331;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1C1F35B8u) % 5u)
					{
					case 4u:
						if (aIndex < m_Dict.Count)
						{
							num = 1590070752;
							num3 = 1590070752;
							continue;
						}
						goto IL_0016;
					case 2u:
						num = (int)(num2 * 1752101508) ^ -1663108868;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -543349341) ^ -1122698249;
							continue;
						}
						goto IL_0016;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
						IL_0016:
						num = 1920130399;
						num3 = 1920130399;
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
				int num = -177681220;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE84550Du) % 4u)
					{
					case 3u:
						num = (int)((num2 * 522596791) ^ 0x3D7DD98);
						continue;
					case 1u:
						count = m_Dict.Count;
						num = (int)(num2 * 461537801) ^ -1029733733;
						continue;
					case 2u:
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		if (!JSONClass.smethod_30(aKey))
		{
			goto IL_0068;
		}
		goto IL_00fa;
		IL_00fa:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = 1626501904;
		goto IL_00bc;
		IL_00bc:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x5FF7EB46u) % 11u)
			{
			case 10u:
				num = ((int)num2 * -116911591) ^ 0x65BC471E;
				continue;
			case 9u:
				flag = m_Dict.ContainsKey(aKey);
				num = ((int)num2 * -1075250162) ^ -763777246;
				continue;
			case 8u:
				num = ((int)num2 * -1030441067) ^ 0x6F0BE608;
				continue;
			case 6u:
				m_Dict.Add(aKey, aItem);
				num = 1365957043;
				continue;
			case 5u:
				num = 1761012904;
				continue;
			case 3u:
				break;
			case 2u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -1982393807;
					num4 = -1982393807;
				}
				else
				{
					num3 = -892069591;
					num4 = -892069591;
				}
				num = num3 ^ (int)(num2 * 59215076);
				continue;
			}
			case 1u:
				m_Dict[aKey] = aItem;
				num = ((int)num2 * -1864063101) ^ 0x6B197794;
				continue;
			case 0u:
				num = (int)((num2 * 1008461296) ^ 0x27635208);
				continue;
			default:
				return;
			case 7u:
				goto IL_00fa;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0068;
		IL_0068:
		num = 1440078116;
		goto IL_00bc;
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -1382275520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD964885Eu) % 8u)
				{
				case 7u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = (int)(num2 * 1445805815) ^ -177717059;
					continue;
				case 6u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1712204954) ^ 0x6AF1C65B);
					continue;
				case 3u:
					result = null;
					num = ((int)num2 * -994085557) ^ -1705393318;
					continue;
				case 2u:
					num = ((int)num2 * -2021545056) ^ -1197673981;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1179789031;
						num4 = 1179789031;
					}
					else
					{
						num3 = 1371106660;
						num4 = 1371106660;
					}
					num = num3 ^ ((int)num2 * -2120565175);
					continue;
				}
				case 0u:
					jSONNode = m_Dict[aKey];
					num = -556816311;
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1040046819;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8257423Du) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1313569243;
						num5 = -1313569243;
					}
					else
					{
						num4 = -1482980301;
						num5 = -1482980301;
					}
					num = num4 ^ ((int)num2 * -452311791);
					continue;
				}
				case 7u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_003b;
				case 6u:
					result = null;
					num = (int)((num2 * 957315365) ^ 0x2817981);
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1081753068) ^ 0x5F1330F);
						continue;
					}
					num3 = 1;
					goto IL_003b;
				case 4u:
					num = (int)((num2 * 1615007941) ^ 0x28700FE1);
					continue;
				case 1u:
					num = (int)(num2 * 2078164095) ^ -152113813;
					continue;
				case 0u:
					result = null;
					num = -571616694;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_003b:
					flag = (byte)num3 != 0;
					num = -502036918;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_0038: Incompatible stack heights: 0 vs 1
		//IL_0047: Incompatible stack heights: 0 vs 1
		//IL_004e: Incompatible stack heights: 0 vs 1
		JSONNode result = default(JSONNode);
		try
		{
			result = null;
			return result;
		}
		catch
		{
			while (true)
			{
				_ = -1273080134;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -1139811917;
					uint num = (uint)(int)val;
					switch (val % 4)
					{
					case 3:
						result = null;
						_ = ((int)num * -915866358) ^ -581529349;
						continue;
					case 1:
						_ = (num * 695553858) ^ 0xE757BC7Au;
						continue;
					case 0:
						break;
					default:
						return result;
					case 2:
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
		string text = "{";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0132:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1737835607;
					num2 = 1737835607;
				}
				else
				{
					num = 511078504;
					num2 = 511078504;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x6345756Eu) % 9u)
					{
					case 8u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = 879282192;
						continue;
					case 7u:
						flag = JSONClass.smethod_31(text) > 2;
						num = (int)(num3 * 245530613) ^ -1049036621;
						continue;
					case 5u:
						num = ((int)num3 * -1415021357) ^ 0x29BD97BA;
						continue;
					case 4u:
						current = enumerator.Current;
						num = 1362661073;
						continue;
					case 2u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -388759862) ^ 0x213A87F1;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1821624591;
							num5 = -1821624591;
						}
						else
						{
							num4 = -117702354;
							num5 = -117702354;
						}
						num = num4 ^ ((int)num3 * -923046328);
						continue;
					}
					case 0u:
						num = 511078504;
						continue;
					default:
						goto end_IL_00ec;
					case 6u:
						break;
					case 3u:
						goto end_IL_00ec;
					}
					goto IL_0132;
					continue;
					end_IL_00ec:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num6 = 247713013;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x6345756Eu) % 3u)
				{
				case 1u:
					goto IL_015e;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_015e:
				result = text;
				num6 = (int)(num3 * 1209144420) ^ -708521948;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -2068579281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD038DF00u) % 4u)
				{
				case 3u:
					text = "{ ";
					num = ((int)num2 * -368770896) ^ 0x3387E6D4;
					continue;
				case 0u:
					num = ((int)num2 * -427462070) ^ -36935651;
					continue;
				case 2u:
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
								num3 = -1342005863;
								num4 = -1342005863;
							}
							else
							{
								num3 = -833623672;
								num4 = -833623672;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD038DF00u) % 8u)
								{
								case 7u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = -162120996;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -150401857;
										num6 = -150401857;
									}
									else
									{
										num5 = -11175659;
										num6 = -11175659;
									}
									num3 = num5 ^ (int)(num2 * 1019106796);
									continue;
								}
								case 5u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1180993122) ^ -386417999;
									continue;
								case 3u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)(num2 * 712386957) ^ -1356566511;
									continue;
								case 2u:
									num3 = -1342005863;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -999254005;
									continue;
								default:
									goto end_IL_0143;
								case 4u:
									break;
								case 0u:
									goto end_IL_0143;
								}
								goto IL_0184;
								continue;
								end_IL_0143:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = -144996199;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xD038DF00u) % 4u)
							{
							case 2u:
								num7 = (int)(num2 * 2023983182) ^ -320039761;
								continue;
							case 1u:
								result = text;
								num7 = (int)(num2 * 1193686411) ^ -835235087;
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
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -1480952651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD50AFA0u) % 6u)
				{
				case 5u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -1263826026) ^ -297004502;
					continue;
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 1407041434) ^ 0x23F9A623);
					continue;
				case 2u:
					num = ((int)num2 * -171206916) ^ 0x22630661;
					continue;
				case 1u:
					num = ((int)num2 * -354783946) ^ -48060168;
					continue;
				case 0u:
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
							if (!enumerator.MoveNext())
							{
								num3 = -1562603511;
								num4 = -1562603511;
							}
							else
							{
								num3 = -237042766;
								num4 = -237042766;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBD50AFA0u) % 8u)
								{
								case 6u:
									JSONClass.smethod_38(aWriter, current);
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -1656389357) ^ -1790316591;
									continue;
								case 5u:
									num3 = -237042766;
									continue;
								case 4u:
									num3 = (int)(num2 * 1324160110) ^ -1868132818;
									continue;
								case 3u:
									num3 = (int)((num2 * 1450284371) ^ 0x78884FF9);
									continue;
								case 2u:
									current = enumerator.Current;
									num3 = -1371618308;
									continue;
								case 0u:
									num3 = (int)((num2 * 930107316) ^ 0x7E30D13F);
									continue;
								default:
									return;
								case 7u:
									break;
								case 1u:
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
							int num5 = -1891707290;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xBD50AFA0u) % 3u)
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
								num5 = (int)((num2 * 2062569202) ^ 0x58FB8318);
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
