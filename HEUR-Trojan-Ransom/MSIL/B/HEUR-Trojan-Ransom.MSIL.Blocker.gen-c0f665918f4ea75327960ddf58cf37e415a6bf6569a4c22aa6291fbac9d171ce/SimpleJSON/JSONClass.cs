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
				int num = -906402596;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4DD0EBFu) % 8u)
					{
					case 5u:
						num = (int)((num2 * 1473614851) ^ 0xDE2071F);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1685607450;
							num4 = -1685607450;
						}
						else
						{
							num3 = -193259627;
							num4 = -193259627;
						}
						num = num3 ^ ((int)num2 * -1448594206);
						continue;
					}
					case 3u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1276770762) ^ -1445446015;
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = -1351453985;
						continue;
					case 1u:
						result = m_Dict[aKey];
						num = (int)(num2 * 650320114) ^ -767980200;
						continue;
					case 0u:
						num = (int)(num2 * 307962754) ^ -1839469280;
						continue;
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
				int num = -1660354596;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCC298ABu) % 7u)
					{
					case 6u:
						num = (int)((num2 * 427449245) ^ 0x45EF1C2F);
						continue;
					case 5u:
						num = ((int)num2 * -1046068311) ^ -765587482;
						continue;
					case 4u:
						m_Dict.Add(aKey, value);
						num = -1745015372;
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 209920883) ^ -508952616;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1442702595;
							num4 = -1442702595;
						}
						else
						{
							num3 = -958727685;
							num4 = -958727685;
						}
						num = num3 ^ ((int)num2 * -1502939307);
						continue;
					}
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
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = -1963591469;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xB8D02FCFu) % 8u)
					{
					case 7u:
						result = null;
						num = -480824307;
						continue;
					case 6u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0020;
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 859587264) ^ -1670281167;
							continue;
						}
						num5 = 1;
						goto IL_0020;
					case 2u:
						num = ((int)num2 * -736795337) ^ 0x25B769C4;
						continue;
					case 1u:
						result = null;
						num = (int)(num2 * 1227006063) ^ -2019008243;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1511759240;
							num4 = 1511759240;
						}
						else
						{
							num3 = 947771102;
							num4 = 947771102;
						}
						num = num3 ^ ((int)num2 * -1588205657);
						continue;
					}
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0020:
						flag = (byte)num5 != 0;
						num = -1723233177;
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
				goto IL_0016;
			}
			int num = 1;
			goto IL_0075;
			IL_0075:
			bool flag = (byte)num != 0;
			int num2 = 2048945721;
			goto IL_003f;
			IL_0016:
			num2 = 1154286877;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x61F3E175u) % 5u)
				{
				case 4u:
					num2 = (int)(num3 * 1035418537) ^ -386169493;
					continue;
				case 3u:
					break;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 164229996;
						num5 = 164229996;
					}
					else
					{
						num4 = 219216442;
						num5 = 219216442;
					}
					num2 = num4 ^ (int)(num3 * 1939169543);
					continue;
				}
				default:
					return;
				case 1u:
					goto IL_0064;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0016;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
		}
	}

	public override int Count => m_Dict.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 2011542102;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FB439Eu) % 3u)
					{
					case 2u:
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
					num = ((int)num2 * -603603413) ^ 0xDEFFD5F;
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
			int num = 2040456375;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20B810A3u) % 15u)
				{
				case 14u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1548241266;
					continue;
				case 13u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 3080192) ^ 0x712201B0);
					continue;
				case 12u:
					num = (int)((num2 * 1056840086) ^ 0x1F350FA9);
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 437721566;
						num6 = 437721566;
					}
					else
					{
						num5 = 1741565083;
						num6 = 1741565083;
					}
					num = num5 ^ ((int)num2 * -1743022357);
					continue;
				}
				case 10u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1650033928;
						num4 = -1650033928;
					}
					else
					{
						num3 = -2036549712;
						num4 = -2036549712;
					}
					num = num3 ^ ((int)num2 * -1141620906);
					continue;
				}
				case 9u:
					num = 1711701817;
					continue;
				case 8u:
					num = (int)((num2 * 1874102937) ^ 0x45D1FAF3);
					continue;
				case 7u:
					m_Dict.Add(aKey, aItem);
					num = 1805025936;
					continue;
				case 6u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 2050915481) ^ 0x3CC8B7F6);
					continue;
				case 3u:
					num = ((int)num2 * -1284156506) ^ 0x10118599;
					continue;
				case 2u:
					num = (int)((num2 * 853251469) ^ 0x3F7B954E);
					continue;
				case 1u:
					flag = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -1477257678) ^ -2011275742;
					continue;
				case 0u:
					num = ((int)num2 * -91942661) ^ -1044675667;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 631656876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FB0C46Du) % 8u)
				{
				case 7u:
					result = null;
					num = ((int)num2 * -730777208) ^ -2020400522;
					continue;
				case 5u:
					result = jSONNode;
					num = ((int)num2 * -1544678792) ^ 0x5CA395B7;
					continue;
				case 4u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = 652925856;
					continue;
				case 2u:
					num = (int)((num2 * 1739937959) ^ 0x44C42A40);
					continue;
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1341738083) ^ 0x4ECEE3B0;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1858672025;
						num4 = 1858672025;
					}
					else
					{
						num3 = 73955530;
						num4 = 73955530;
					}
					num = num3 ^ ((int)num2 * -1595166407);
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1428833983;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC0E4C129u) % 6u)
				{
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1521042322) ^ -1718868937;
						continue;
					}
					goto IL_001c;
				case 2u:
					if (aIndex < m_Dict.Count)
					{
						num = -376572970;
						num3 = -376572970;
						continue;
					}
					goto IL_001c;
				case 1u:
					result = null;
					num = -2130947158;
					continue;
				case 0u:
					result = null;
					num = (int)(num2 * 722161358) ^ -1698251990;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					num = -1697169175;
					num3 = -1697169175;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1428887137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA891778u) % 4u)
				{
				case 3u:
					text = "{";
					num = (int)(num2 * 2065246312) ^ -2002325382;
					continue;
				case 2u:
					num = ((int)num2 * -717710256) ^ -1341744027;
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
							IL_0165:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1679349159;
								num4 = -1679349159;
							}
							else
							{
								num3 = -305541609;
								num4 = -305541609;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xDA891778u) % 8u)
								{
								case 6u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -1761175315;
									continue;
								case 5u:
									num3 = ((int)num2 * -1544534454) ^ -587356106;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -1919249023;
										num6 = -1919249023;
									}
									else
									{
										num5 = -368600145;
										num6 = -368600145;
									}
									num3 = num5 ^ (int)(num2 * 2133527955);
									continue;
								}
								case 2u:
									num3 = -1679349159;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1626291501;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1867718046) ^ 0x78EE9B0E;
									continue;
								default:
									goto end_IL_0124;
								case 4u:
									break;
								case 7u:
									goto end_IL_0124;
								}
								goto IL_0165;
								continue;
								end_IL_0124:
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
							IL_01b0:
							int num7 = -716786349;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xDA891778u) % 3u)
								{
								case 1u:
									goto IL_0184;
								default:
									goto end_IL_0192;
								case 0u:
									break;
								case 2u:
									goto end_IL_0192;
								}
								goto IL_01b0;
								IL_0184:
								num7 = ((int)num2 * -877712342) ^ -1557042327;
								continue;
								end_IL_0192:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = -918133359;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xDA891778u) % 4u)
							{
							case 1u:
								result = text;
								num8 = (int)(num2 * 160697032) ^ -1060122496;
								continue;
							case 0u:
								num8 = ((int)num2 * -1707578071) ^ -454043637;
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
			int num = 1653540812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3145D841u) % 4u)
				{
				case 1u:
					text = "{ ";
					num = ((int)num2 * -1811182688) ^ -538373563;
					continue;
				case 0u:
					num = ((int)num2 * -1991359222) ^ 0x273D0F6;
					continue;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_01a5:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 439559540;
								num4 = 439559540;
							}
							else
							{
								num3 = 1263473901;
								num4 = 1263473901;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3145D841u) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = 1540165386;
									continue;
								case 7u:
									num3 = 439559540;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1702108209;
										num6 = 1702108209;
									}
									else
									{
										num5 = 1098620497;
										num6 = 1098620497;
									}
									num3 = num5 ^ (int)(num2 * 2042600526);
									continue;
								}
								case 4u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)(num2 * 1373412092) ^ -1681858631;
									continue;
								case 3u:
									num3 = (int)((num2 * 1578832711) ^ 0x41DB03E5);
									continue;
								case 2u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = 1813688429;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 159212808) ^ 0x741D9BF9);
									continue;
								default:
									goto end_IL_015f;
								case 5u:
									break;
								case 1u:
									goto end_IL_015f;
								}
								goto IL_01a5;
								continue;
								end_IL_015f:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = 1275407460;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x3145D841u) % 4u)
							{
							case 3u:
								num7 = (int)((num2 * 436311075) ^ 0x2D83ADFA);
								continue;
							case 1u:
								result = text;
								num7 = ((int)num2 * -1945442619) ^ -1429111097;
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
			int num = -2132622181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED1F7071u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 1840808307) ^ 0xC62B189);
					continue;
				case 4u:
					num = ((int)num2 * -1498987764) ^ 0x4574274D;
					continue;
				case 2u:
					num = (int)(num2 * 1335938335) ^ -8533083;
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 752822311) ^ -475650120;
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1373847743) ^ 0x2104A4FE;
					continue;
				case 6u:
					break;
				default:
				{
					using Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = -527820368;
							num4 = -527820368;
						}
						else
						{
							num3 = -843681209;
							num4 = -843681209;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xED1F7071u) % 10u)
							{
							case 9u:
								num3 = (int)((num2 * 1359678651) ^ 0x330FDE3E);
								continue;
							case 8u:
								num3 = ((int)num2 * -1764591925) ^ 0x1262B6AF;
								continue;
							case 7u:
								num3 = ((int)num2 * -1361983644) ^ 0x5B7E94E;
								continue;
							case 6u:
								num3 = (int)((num2 * 1516875038) ^ 0x64C1BCB4);
								continue;
							case 5u:
								current = enumerator.Current;
								num3 = -1421407363;
								continue;
							case 4u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -549628989) ^ 0x52C78E79;
								continue;
							case 3u:
								num3 = -527820368;
								continue;
							case 0u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)(num2 * 1881767799) ^ -425101312;
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
			int num = 1502508273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3497F6C6u) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0013:
				num = ((int)num2 * -208539314) ^ 0x5B2D620F;
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
