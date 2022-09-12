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
				int num = 1149938924;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29DAFB81u) % 7u)
					{
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -2142864774) ^ -1545729278;
						continue;
					case 4u:
						num = (int)(num2 * 943219497) ^ -760982967;
						continue;
					case 3u:
						result = m_Dict[aKey];
						num = (int)((num2 * 70556669) ^ 0x5E3C8BE5);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = 1788288812;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -631248542;
							num4 = -631248542;
						}
						else
						{
							num3 = -1053459538;
							num4 = -1053459538;
						}
						num = num3 ^ ((int)num2 * -1349919090);
						continue;
					}
					case 6u:
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = -1574369686;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA958CEB9u) % 7u)
					{
					case 5u:
						m_Dict.Add(aKey, value);
						num = -1325925498;
						continue;
					case 4u:
						num = ((int)num2 * -2100996474) ^ 0x2CADD755;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1564476820;
							num4 = 1564476820;
						}
						else
						{
							num3 = 747604162;
							num4 = 747604162;
						}
						num = num3 ^ (int)(num2 * 347821752);
						continue;
					}
					case 1u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 2039493137) ^ 0x26DBD09B);
						continue;
					case 0u:
						num = (int)((num2 * 28579044) ^ 0x667CF4EE);
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
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			if (aIndex < 0)
			{
				goto IL_0007;
			}
			goto IL_002e;
			IL_002e:
			int num = -1387917085;
			goto IL_0033;
			IL_0033:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA9A0B11u) % 5u)
				{
				case 4u:
					result = null;
					num = (int)((num2 * 906445379) ^ 0x2ED9EDB);
					continue;
				case 3u:
					result = null;
					num = -320228976;
					continue;
				case 2u:
					break;
				case 1u:
					goto IL_0058;
				default:
					return result;
				}
				break;
				IL_0058:
				if (aIndex < m_Dict.Count)
				{
					num = -355113104;
					num3 = -355113104;
					continue;
				}
				goto IL_0007;
			}
			goto IL_002e;
			IL_0007:
			num = -837818040;
			num3 = -837818040;
			goto IL_0033;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_003a;
			}
			int num = 1;
			goto IL_0075;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
			IL_003a:
			int num2 = -544816963;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xDAB6C5CAu) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1098426619;
						num5 = 1098426619;
					}
					else
					{
						num4 = 750251126;
						num5 = 750251126;
					}
					num2 = num4 ^ (int)(num3 * 1714191638);
					continue;
				}
				case 1u:
					num2 = (int)((num3 * 777405970) ^ 0x686C5301);
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0064;
				case 3u:
					return;
				}
				break;
			}
			goto IL_003a;
			IL_0075:
			flag = (byte)num != 0;
			num2 = -1280470905;
			goto IL_003f;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -1527788543;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDDD7C198u) % 4u)
					{
					case 1u:
						count = m_Dict.Count;
						num = (int)((num2 * 320820267) ^ 0x4BE71B2F);
						continue;
					case 0u:
						num = (int)(num2 * 369253) ^ -2098418553;
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
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			while (true)
			{
				int num = -540470852;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92B50788u) % 3u)
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
					num = ((int)num2 * -1507600469) ^ 0x2AAF34FD;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1000392748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x898454A8u) % 14u)
				{
				case 13u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1496420458) ^ 0x3995687D);
					continue;
				case 12u:
					num = (int)(num2 * 188136032) ^ -35093111;
					continue;
				case 11u:
					num = -1741771038;
					continue;
				case 10u:
					num = (int)(num2 * 1431323822) ^ -172567124;
					continue;
				case 9u:
					num = ((int)num2 * -1395972373) ^ 0x2E9F47BE;
					continue;
				case 7u:
					m_Dict.Add(aKey, aItem);
					num = -1820330379;
					continue;
				case 6u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 1798424622) ^ -590681564;
					continue;
				case 5u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1659568295;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1336730681;
						num6 = -1336730681;
					}
					else
					{
						num5 = -54211825;
						num6 = -54211825;
					}
					num = num5 ^ (int)(num2 * 183035033);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1000142364;
						num4 = -1000142364;
					}
					else
					{
						num3 = -1666320865;
						num4 = -1666320865;
					}
					num = num3 ^ ((int)num2 * -804455366);
					continue;
				}
				case 1u:
					num = (int)((num2 * 2113681260) ^ 0x7052434C);
					continue;
				case 0u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -253166001) ^ 0x662B8202;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		if (!m_Dict.ContainsKey(aKey))
		{
			goto IL_0024;
		}
		goto IL_0085;
		IL_0085:
		JSONNode jSONNode = m_Dict[aKey];
		m_Dict.Remove(aKey);
		int num = 1104468108;
		goto IL_0058;
		IL_0058:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x38686DDCu) % 7u)
			{
			case 6u:
				result = jSONNode;
				num = ((int)num2 * -2007190505) ^ 0x391A79C5;
				continue;
			case 5u:
				break;
			case 3u:
				num = (int)((num2 * 1398326578) ^ 0x37ED5767);
				continue;
			case 2u:
				result = null;
				num = (int)((num2 * 1465704787) ^ 0x24896B17);
				continue;
			case 1u:
				num = (int)(num2 * 1960820867) ^ -709831034;
				continue;
			case 4u:
				goto IL_0085;
			default:
				return result;
			}
			break;
		}
		goto IL_0024;
		IL_0024:
		num = 106644466;
		goto IL_0058;
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 98900984;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x14E210F2u) % 7u)
				{
				case 6u:
					result = null;
					num = 945114698;
					continue;
				case 5u:
					if (aIndex < m_Dict.Count)
					{
						num = 1541643443;
						num3 = 1541643443;
						continue;
					}
					goto IL_0022;
				case 4u:
					num = (int)(num2 * 413068430) ^ -1239656446;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 892775141) ^ 0x6A8AEC88);
						continue;
					}
					goto IL_0022;
				case 0u:
					result = null;
					num = ((int)num2 * -1965623587) ^ 0x3D5669D9;
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0022:
					num = 1915010613;
					num3 = 1915010613;
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
		string text = default(string);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		while (true)
		{
			int num = -968014798;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFFC49A54u) % 4u)
				{
				case 2u:
					text = "{";
					num = ((int)num2 * -242569516) ^ -606654943;
					continue;
				case 1u:
					num = ((int)num2 * -1697732713) ^ 0x17DD887;
					continue;
				case 3u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0193:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1871029172;
								num4 = -1871029172;
							}
							else
							{
								num3 = -2053289761;
								num4 = -2053289761;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFFC49A54u) % 10u)
								{
								case 9u:
									num3 = (int)(num2 * 463844215) ^ -1643841152;
									continue;
								case 7u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -1596351497;
									continue;
								case 6u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -738351817) ^ 0x29B0616D;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = -1716793069;
									continue;
								case 3u:
									num3 = ((int)num2 * -117325357) ^ 0x29AF68C3;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1657269430;
										num6 = 1657269430;
									}
									else
									{
										num5 = 390175267;
										num6 = 390175267;
									}
									num3 = num5 ^ (int)(num2 * 1214205421);
									continue;
								}
								case 1u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -383544279) ^ -1386406291;
									continue;
								case 0u:
									num3 = -2053289761;
									continue;
								default:
									goto end_IL_0149;
								case 4u:
									break;
								case 8u:
									goto end_IL_0149;
								}
								goto IL_0193;
								continue;
								end_IL_0149:
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
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0152:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1181263833;
					num2 = -1181263833;
				}
				else
				{
					num = -1901322890;
					num2 = -1901322890;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x8ECB1C00u) % 9u)
					{
					case 8u:
						flag = JSONClass.smethod_31(text) > 3;
						num = ((int)num3 * -91463138) ^ 0x34ABE614;
						continue;
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
						num = -1373653809;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1690847565;
							num5 = 1690847565;
						}
						else
						{
							num4 = 1093985335;
							num5 = 1093985335;
						}
						num = num4 ^ (int)(num3 * 587461233);
						continue;
					}
					case 3u:
						num = -1181263833;
						continue;
					case 2u:
						current = enumerator.Current;
						num = -132380716;
						continue;
					case 1u:
						num = ((int)num3 * -832948520) ^ -586346112;
						continue;
					case 0u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -2060221054) ^ 0xC7EB239;
						continue;
					default:
						goto end_IL_010c;
					case 5u:
						break;
					case 6u:
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
		string result = default(string);
		while (true)
		{
			int num6 = -2127660694;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x8ECB1C00u) % 4u)
				{
				case 2u:
					result = text;
					num6 = ((int)num3 * -1176031712) ^ -381427119;
					continue;
				case 1u:
					num6 = ((int)num3 * -331194598) ^ 0x51FC2D62;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -1617619534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7238D37u) % 4u)
				{
				case 1u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1339163231) ^ -8776566;
					continue;
				case 0u:
					num = ((int)num2 * -349026407) ^ -507594448;
					continue;
				case 2u:
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
								num3 = -1157152387;
								num4 = -1157152387;
							}
							else
							{
								num3 = -2013092058;
								num4 = -2013092058;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC7238D37u) % 8u)
								{
								case 6u:
									num3 = (int)((num2 * 2113629734) ^ 0x236D851E);
									continue;
								case 5u:
									JSONClass.smethod_38(aWriter, current);
									m_Dict[current].Serialize(aWriter);
									num3 = (int)((num2 * 1191599767) ^ 0x7920B3C);
									continue;
								case 4u:
									num3 = -1157152387;
									continue;
								case 3u:
									num3 = ((int)num2 * -1406847667) ^ -2092151753;
									continue;
								case 2u:
									current = enumerator.Current;
									num3 = -783562079;
									continue;
								case 0u:
									num3 = (int)((num2 * 1573117943) ^ 0x5E5CC974);
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
							IL_0174:
							int num5 = -1493031211;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xC7238D37u) % 3u)
								{
								case 1u:
									goto IL_014a;
								default:
									goto end_IL_0157;
								case 0u:
									break;
								case 2u:
									goto end_IL_0157;
								}
								goto IL_0174;
								IL_014a:
								num5 = (int)((num2 * 710976737) ^ 0x1888B088);
								continue;
								end_IL_0157:
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
