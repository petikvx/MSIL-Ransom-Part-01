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
				int num = 40829909;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8ECBA4u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 731089310) ^ -1182133731;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 519711040;
							num4 = 519711040;
						}
						else
						{
							num3 = 1533124066;
							num4 = 1533124066;
						}
						num = num3 ^ (int)(num2 * 743563012);
						continue;
					}
					case 4u:
						num = (int)((num2 * 1644974029) ^ 0x2EFA42F3);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = 369054787;
						continue;
					case 1u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -550835637) ^ -391120942;
						continue;
					case 0u:
						result = m_Dict[aKey];
						num = (int)(num2 * 1413945437) ^ -974346792;
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
				int num = 816977932;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E19072Eu) % 7u)
					{
					case 6u:
						m_Dict.Add(aKey, value);
						num = 145595554;
						continue;
					case 4u:
						num = (int)(num2 * 1281770379) ^ -543540914;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 2045146103;
							num4 = 2045146103;
						}
						else
						{
							num3 = 826783387;
							num4 = 826783387;
						}
						num = num3 ^ (int)(num2 * 647006511);
						continue;
					}
					case 1u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1341314764) ^ 0x40979657;
						continue;
					case 0u:
						num = (int)(num2 * 1513563820) ^ -1949377239;
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
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
				goto IL_0057;
			}
			int num = 1;
			goto IL_009a;
			IL_009a:
			bool flag = (byte)num != 0;
			int num2 = -1301581234;
			goto IL_005c;
			IL_0057:
			num2 = -1028073921;
			goto IL_005c;
			IL_005c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB5C71FC9u) % 7u)
				{
				case 6u:
					result = null;
					num2 = (int)(num3 * 728369973) ^ -1395270129;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -631806905;
						num5 = -631806905;
					}
					else
					{
						num4 = -1019212832;
						num5 = -1019212832;
					}
					num2 = num4 ^ (int)(num3 * 1257254021);
					continue;
				}
				case 4u:
					result = null;
					num2 = -475050623;
					continue;
				case 1u:
					num2 = (int)(num3 * 227170119) ^ -721033946;
					continue;
				case 0u:
					break;
				case 2u:
					goto IL_0089;
				default:
					return result;
				}
				break;
			}
			goto IL_0057;
			IL_0089:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_009a;
		}
		set
		{
			while (true)
			{
				int num = 996009144;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x769E2F4Eu) % 5u)
					{
					case 4u:
						num = (int)((num2 * 806399480) ^ 0x2BF6C41C);
						continue;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = 1368760836;
							num3 = 1368760836;
							continue;
						}
						goto IL_0031;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1010233849) ^ 0x4DCE1F96;
							continue;
						}
						goto IL_0031;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
						IL_0031:
						num = 1025179315;
						num3 = 1025179315;
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
				int num = -1219200604;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9E90409u) % 3u)
					{
					case 2u:
						goto IL_000e;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = (int)(num2 * 1204281832) ^ -783729526;
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
				int num = -806995306;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA43A2AEAu) % 3u)
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
					num = (int)(num2 * 2076164750) ^ -2069928582;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1654410933;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67B8A8AFu) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -2117865657;
						num6 = -2117865657;
					}
					else
					{
						num5 = -34511479;
						num6 = -34511479;
					}
					num = num5 ^ ((int)num2 * -462658182);
					continue;
				}
				case 10u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 506757246;
					continue;
				case 8u:
					num = (int)((num2 * 1047523424) ^ 0x306F5A7E);
					continue;
				case 7u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 2079091119) ^ 0x1987F791);
					continue;
				case 6u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)((num2 * 249535672) ^ 0x5B4B7AF8);
					continue;
				case 5u:
					num = 1714140255;
					continue;
				case 4u:
					num = ((int)num2 * -1229274978) ^ 0x55924DE6;
					continue;
				case 3u:
					num = (int)((num2 * 1034615471) ^ 0x1B314482);
					continue;
				case 1u:
					m_Dict.Add(aKey, aItem);
					num = 1932468774;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (m_Dict.ContainsKey(aKey))
					{
						num3 = 1182172796;
						num4 = 1182172796;
					}
					else
					{
						num3 = 1488325042;
						num4 = 1488325042;
					}
					num = num3 ^ ((int)num2 * -1309076992);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 9u:
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
		while (true)
		{
			int num = 1207528176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x507C849Au) % 6u)
				{
				case 3u:
					result = null;
					num = (int)(num2 * 2073601853) ^ -21479958;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (m_Dict.ContainsKey(aKey))
					{
						num3 = -1229097775;
						num4 = -1229097775;
					}
					else
					{
						num3 = -525362789;
						num4 = -525362789;
					}
					num = num3 ^ (int)(num2 * 554594113);
					continue;
				}
				case 1u:
					jSONNode = m_Dict[aKey];
					num = 1144685066;
					continue;
				case 0u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -1681978987) ^ 0x5980C7C5;
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
		if (aIndex >= 0)
		{
			goto IL_0057;
		}
		int num = 1;
		goto IL_009a;
		IL_0089:
		num = ((aIndex >= m_Dict.Count) ? 1 : 0);
		goto IL_009a;
		IL_0057:
		int num2 = -1072376956;
		goto IL_005c;
		IL_005c:
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x9220E6C7u) % 7u)
			{
			case 6u:
				result = null;
				num2 = (int)((num3 * 1092254340) ^ 0x5942A5A9);
				continue;
			case 5u:
				result = null;
				num2 = -1194528067;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 802285119;
					num5 = 802285119;
				}
				else
				{
					num4 = 928321535;
					num5 = 928321535;
				}
				num2 = num4 ^ ((int)num3 * -660393601);
				continue;
			}
			case 1u:
				num2 = (int)((num3 * 1102345908) ^ 0x7F65ABC5);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0089;
			default:
				return result;
			}
			break;
		}
		goto IL_0057;
		IL_009a:
		flag = (byte)num != 0;
		num2 = -1251168387;
		goto IL_005c;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0032: Incompatible stack heights: 0 vs 1
		//IL_0039: Incompatible stack heights: 0 vs 1
		try
		{
			return null;
		}
		catch
		{
			while (true)
			{
				_ = -555219991;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -729821059;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = ((int)num * -1903229456) ^ -1250794403;
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
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumerator_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string text = "{";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1880018160;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DA5E502u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0152:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1491704523;
								num4 = 1491704523;
							}
							else
							{
								num3 = 1229795268;
								num4 = 1229795268;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5DA5E502u) % 8u)
								{
								case 7u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = 543542903;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1965088993;
										num6 = 1965088993;
									}
									else
									{
										num5 = 2120791852;
										num6 = 2120791852;
									}
									num3 = num5 ^ (int)(num2 * 968692339);
									continue;
								}
								case 3u:
									num3 = 1491704523;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1611778430) ^ -1944982463;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 1561751242;
									continue;
								case 0u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)((num2 * 1007069670) ^ 0x195571A6);
									continue;
								default:
									goto end_IL_0111;
								case 5u:
									break;
								case 6u:
									goto end_IL_0111;
								}
								goto IL_0152;
								continue;
								end_IL_0111:
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
							IL_019d:
							int num7 = 2137019775;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x5DA5E502u) % 3u)
								{
								case 1u:
									goto IL_0171;
								default:
									goto end_IL_017f;
								case 2u:
									break;
								case 0u:
									goto end_IL_017f;
								}
								goto IL_019d;
								IL_0171:
								num7 = ((int)num2 * -225568974) ^ -1454404407;
								continue;
								end_IL_017f:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = 931003960;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x5DA5E502u) % 4u)
							{
							case 2u:
								result = text;
								num8 = (int)(num2 * 326674703) ^ -627926271;
								continue;
							case 1u:
								num8 = ((int)num2 * -2024851217) ^ 0x6A119D4E;
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
				num = ((int)num2 * -1971288613) ^ 0x7A274E5B;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -1380887958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED41E580u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0185:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -322130217;
								num4 = -322130217;
							}
							else
							{
								num3 = -1903126478;
								num4 = -1903126478;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xED41E580u) % 9u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = -672432689;
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
									num3 = -943299936;
									continue;
								case 5u:
									num3 = -322130217;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 3)
									{
										num5 = 1886985503;
										num6 = 1886985503;
									}
									else
									{
										num5 = 1692555976;
										num6 = 1692555976;
									}
									num3 = num5 ^ (int)(num2 * 1326038568);
									continue;
								}
								case 2u:
									num3 = (int)(num2 * 1635419689) ^ -364936368;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -2102504602) ^ -508844481;
									continue;
								case 0u:
									num3 = (int)((num2 * 520609799) ^ 0x58E50CFF);
									continue;
								default:
									goto end_IL_013f;
								case 4u:
									break;
								case 8u:
									goto end_IL_013f;
								}
								goto IL_0185;
								continue;
								end_IL_013f:
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
							IL_01d0:
							int num7 = -1310107102;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xED41E580u) % 3u)
								{
								case 1u:
									goto IL_01a4;
								default:
									goto end_IL_01b2;
								case 2u:
									break;
								case 0u:
									goto end_IL_01b2;
								}
								goto IL_01d0;
								IL_01a4:
								num7 = ((int)num2 * -968254880) ^ -1184541191;
								continue;
								end_IL_01b2:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num8 = -463039985;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xED41E580u) % 3u)
							{
							case 1u:
								goto IL_01ef;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_01ef:
							num8 = (int)(num2 * 1433274043) ^ -209042736;
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)((num2 * 121846177) ^ 0x498F19EA);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -641656966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x982A68BBu) % 6u)
				{
				case 5u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 1639012283) ^ 0x6F127D2);
					continue;
				case 3u:
					num = (int)(num2 * 1734852210) ^ -445547429;
					continue;
				case 2u:
					num = (int)((num2 * 2020139853) ^ 0x2778BEDA);
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 782135655) ^ 0x1ADE2BCC);
					continue;
				case 4u:
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
							num3 = -86868048;
							num4 = -86868048;
						}
						else
						{
							num3 = -1394138479;
							num4 = -1394138479;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x982A68BBu) % 9u)
							{
							case 8u:
								num3 = ((int)num2 * -574970908) ^ 0x1D666F07;
								continue;
							case 5u:
								num3 = -86868048;
								continue;
							case 4u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -1238557868) ^ 0x47B917F6;
								continue;
							case 3u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -780025162) ^ -778850607;
								continue;
							case 2u:
								current = enumerator.Current;
								num3 = -2138523576;
								continue;
							case 1u:
								num3 = ((int)num2 * -357154776) ^ -2033846013;
								continue;
							case 0u:
								num3 = ((int)num2 * -883214490) ^ -1355569274;
								continue;
							default:
								return;
							case 6u:
								break;
							case 7u:
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
