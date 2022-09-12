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
				int num = 1607259396;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2629952Au) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 432084819;
							num4 = 432084819;
						}
						else
						{
							num3 = 875817479;
							num4 = 875817479;
						}
						num = num3 ^ ((int)num2 * -242077280);
						continue;
					}
					case 6u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -200076819) ^ -1859475029;
						continue;
					case 5u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1014944838) ^ -1935383904;
						continue;
					case 3u:
						num = (int)(num2 * 612552730) ^ -1124691528;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = 226137689;
						continue;
					case 0u:
						num = (int)(num2 * 852405078) ^ -668641722;
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
			bool flag = default(bool);
			while (true)
			{
				int num = -1789770358;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB24AC2Eu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -174032594;
							num4 = -174032594;
						}
						else
						{
							num3 = -97315823;
							num4 = -97315823;
						}
						num = num3 ^ ((int)num2 * -413734325);
						continue;
					}
					case 5u:
						m_Dict.Add(aKey, value);
						num = -1737813418;
						continue;
					case 4u:
						num = (int)((num2 * 2008073456) ^ 0x20A8AF1B);
						continue;
					case 1u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -2005264618) ^ 0x7D7E5ADF;
						continue;
					case 0u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -430316264) ^ -1573506349;
						continue;
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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1952810316;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x17756D36u) % 9u)
					{
					case 6u:
						num = (int)(num2 * 195904124) ^ -722976280;
						continue;
					case 5u:
						num = ((int)num2 * -385294382) ^ 0x7C7C9572;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1587877334;
							num5 = -1587877334;
						}
						else
						{
							num4 = -1960552527;
							num5 = -1960552527;
						}
						num = num4 ^ (int)(num2 * 461381799);
						continue;
					}
					case 3u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0059;
					case 2u:
						result = null;
						num = (int)((num2 * 1604083293) ^ 0x817025E);
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1990264576) ^ 0x4D5D2063;
							continue;
						}
						num3 = 1;
						goto IL_0059;
					case 0u:
						result = null;
						num = 1835918133;
						continue;
					case 8u:
						break;
					default:
						{
							return result;
						}
						IL_0059:
						flag = (byte)num3 != 0;
						num = 107456415;
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
				int num = -1825663924;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xA21844AFu) % 6u)
					{
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -653501696;
							num5 = -653501696;
						}
						else
						{
							num4 = -1874071001;
							num5 = -1874071001;
						}
						num = num4 ^ (int)(num2 * 1293126104);
						continue;
					}
					case 3u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_003b;
					case 2u:
						num = (int)(num2 * 344654888) ^ -1975557216;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 2050259346) ^ 0x7C8DEF46);
							continue;
						}
						num3 = 1;
						goto IL_003b;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
						IL_003b:
						flag = (byte)num3 != 0;
						num = -589579461;
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
			int count = m_Dict.Count;
			while (true)
			{
				int num = 381119877;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C3A04DBu) % 3u)
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
					num = ((int)num2 * -1896925769) ^ -997843245;
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
		while (true)
		{
			int num = 2039802826;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11F231B1u) % 12u)
				{
				case 11u:
					num = (int)(num2 * 618044838) ^ -1722121052;
					continue;
				case 10u:
					m_Dict.Add(aKey, aItem);
					num = 163943184;
					continue;
				case 9u:
					num = ((int)num2 * -192232070) ^ 0x6F910BF3;
					continue;
				case 8u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1149539298) ^ 0x23CCF1D8;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!JSONClass.smethod_30(aKey))
					{
						num5 = 1818948646;
						num6 = 1818948646;
					}
					else
					{
						num5 = 131668700;
						num6 = 131668700;
					}
					num = num5 ^ ((int)num2 * -333338808);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1217005251) ^ -1067774816;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 1764459795;
						num4 = 1764459795;
					}
					else
					{
						num3 = 1738757329;
						num4 = 1738757329;
					}
					num = num3 ^ ((int)num2 * -747748540);
					continue;
				}
				case 2u:
					num = (int)((num2 * 1254585799) ^ 0x26DF8997);
					continue;
				case 1u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 11245261;
					continue;
				case 0u:
					num = 11245261;
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

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 161469541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x773AF909u) % 8u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -850688136) ^ 0x6BF7B864;
					continue;
				case 5u:
					num = ((int)num2 * -2093693030) ^ 0x4094A51;
					continue;
				case 4u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1043622671) ^ 0x12EF8BC5;
					continue;
				case 3u:
					jSONNode = m_Dict[aKey];
					num = 788524264;
					continue;
				case 1u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = (int)(num2 * 1049776591) ^ -65565812;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -991089142;
						num4 = -991089142;
					}
					else
					{
						num3 = -344528873;
						num4 = -344528873;
					}
					num = num3 ^ (int)(num2 * 58277712);
					continue;
				}
				case 7u:
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
			int num = 149312213;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x2C421FF6u) % 9u)
				{
				case 7u:
					num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0017;
				case 6u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 287231142) ^ 0x1EA79694);
						continue;
					}
					num5 = 1;
					goto IL_0017;
				case 5u:
					num = ((int)num2 * -943200985) ^ 0x1EA085EB;
					continue;
				case 4u:
					result = null;
					num = ((int)num2 * -1903026369) ^ -579592535;
					continue;
				case 3u:
					result = null;
					num = 1073764070;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 333943934;
						num4 = 333943934;
					}
					else
					{
						num3 = 230944634;
						num4 = 230944634;
					}
					num = num3 ^ (int)(num2 * 612907322);
					continue;
				}
				case 0u:
					num = ((int)num2 * -449373233) ^ -1043298708;
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num5 != 0;
					num = 64547457;
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
		//IL_0057: Expected I4, but got Unknown
		//IL_0066: Incompatible stack heights: 0 vs 1
		//IL_006d: Incompatible stack heights: 0 vs 1
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -2088046921;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xADD7F99Cu) % 3u)
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
					num = (int)(num2 * 304673036) ^ -1603712044;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = -1242166904;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ -1378354788;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						_ = (num2 * 1190484042) ^ 0x510A1A2E;
						continue;
					case 0:
						break;
					default:
						return null;
					}
					break;
				}
			}
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
		while (true)
		{
			int num = -1609332303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB606A6D0u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1887692737) ^ -1361322555;
					continue;
				case 1u:
					text = "{";
					num = ((int)num2 * -1873137743) ^ -1783331085;
					continue;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0151:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1114137593;
								num4 = -1114137593;
							}
							else
							{
								num3 = -792637632;
								num4 = -792637632;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB606A6D0u) % 7u)
								{
								case 5u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -667852001;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -2064071510;
										num6 = -2064071510;
									}
									else
									{
										num5 = -1648520090;
										num6 = -1648520090;
									}
									num3 = num5 ^ ((int)num2 * -557136370);
									continue;
								}
								case 2u:
									num3 = -792637632;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1126988563;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 224615653) ^ -2107974804;
									continue;
								default:
									goto end_IL_0114;
								case 4u:
									break;
								case 6u:
									goto end_IL_0114;
								}
								goto IL_0151;
								continue;
								end_IL_0114:
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
							IL_019c:
							int num7 = -1981615843;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xB606A6D0u) % 3u)
								{
								case 1u:
									goto IL_0170;
								default:
									goto end_IL_017e;
								case 0u:
									break;
								case 2u:
									goto end_IL_017e;
								}
								goto IL_019c;
								IL_0170:
								num7 = (int)(num2 * 125765949) ^ -1698756093;
								continue;
								end_IL_017e:
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -145516904;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA633BA4u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_01a2:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1312708861;
								num4 = -1312708861;
							}
							else
							{
								num3 = -319004196;
								num4 = -319004196;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xDA633BA4u) % 10u)
								{
								case 9u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -49258917;
									continue;
								case 8u:
									current = enumerator.Current;
									num3 = -1367529707;
									continue;
								case 6u:
									num3 = ((int)num2 * -228493429) ^ 0x18A9CCCF;
									continue;
								case 5u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = (int)((num2 * 1724854785) ^ 0x5EB232CB);
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1811250807;
										num6 = -1811250807;
									}
									else
									{
										num5 = -1476118452;
										num6 = -1476118452;
									}
									num3 = num5 ^ ((int)num2 * -1216990266);
									continue;
								}
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 361883870) ^ 0x55591D19);
									continue;
								case 1u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)(num2 * 236421521) ^ -195107979;
									continue;
								case 0u:
									num3 = -319004196;
									continue;
								default:
									goto end_IL_0158;
								case 3u:
									break;
								case 7u:
									goto end_IL_0158;
								}
								goto IL_01a2;
								continue;
								end_IL_0158:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = -46257057;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xDA633BA4u) % 3u)
							{
							case 1u:
								goto IL_01d4;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01d4:
							result = text;
							num7 = (int)((num2 * 202081689) ^ 0x4A1D3A92);
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -1972040908) ^ 0x2F7B4408;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -856502184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE712CAEAu) % 4u)
				{
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 64872092) ^ -701690145;
					continue;
				case 1u:
					num = ((int)num2 * -2077742892) ^ 0x207188A;
					continue;
				case 3u:
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
								num3 = -2096713097;
								num4 = -2096713097;
							}
							else
							{
								num3 = -1138881492;
								num4 = -1138881492;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE712CAEAu) % 6u)
								{
								case 5u:
									num3 = (int)((num2 * 1741220697) ^ 0x2925519F);
									continue;
								case 3u:
									num3 = -2096713097;
									continue;
								case 1u:
									current = enumerator.Current;
									JSONClass.smethod_38(aWriter, current);
									num3 = -2074752749;
									continue;
								case 0u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -567319611) ^ 0x624CA304;
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
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_014e:
							int num5 = -794985949;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xE712CAEAu) % 3u)
								{
								case 2u:
									goto IL_0124;
								default:
									goto end_IL_0131;
								case 0u:
									break;
								case 1u:
									goto end_IL_0131;
								}
								goto IL_014e;
								IL_0124:
								num5 = (int)((num2 * 808626863) ^ 0x7BA74C3A);
								continue;
								end_IL_0131:
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
