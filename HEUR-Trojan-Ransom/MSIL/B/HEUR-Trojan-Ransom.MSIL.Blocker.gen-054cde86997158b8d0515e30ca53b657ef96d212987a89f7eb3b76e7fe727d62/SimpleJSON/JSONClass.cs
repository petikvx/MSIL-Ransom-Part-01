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
				int num = -1841985363;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFBA80EFu) % 6u)
					{
					case 4u:
						num = ((int)num2 * -1155653160) ^ 0x69E9D38B;
						continue;
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = -268889987;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = 1415032168;
							num4 = 1415032168;
						}
						else
						{
							num3 = 1831809076;
							num4 = 1831809076;
						}
						num = num3 ^ ((int)num2 * -1581973449);
						continue;
					}
					case 1u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1950703945) ^ 0x60FADD74;
						continue;
					case 5u:
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
				int num = 510308200;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A4A044Du) % 6u)
					{
					case 4u:
						m_Dict.Add(aKey, value);
						num = 2098066393;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = 1226776399;
							num4 = 1226776399;
						}
						else
						{
							num3 = 110630514;
							num4 = 110630514;
						}
						num = num3 ^ ((int)num2 * -1542523554);
						continue;
					}
					case 2u:
						num = (int)((num2 * 1786471275) ^ 0x7E1A0F34);
						continue;
					case 1u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1377043108) ^ 0x1AA90054;
						continue;
					default:
						return;
					case 0u:
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
			bool flag = default(bool);
			while (true)
			{
				int num = 1554099448;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x57AED5Eu) % 7u)
					{
					case 6u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0017;
					case 4u:
						result = null;
						num = (int)((num2 * 1876765829) ^ 0x3085CEED);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -244515802;
							num5 = -244515802;
						}
						else
						{
							num4 = -792809411;
							num5 = -792809411;
						}
						num = num4 ^ (int)(num2 * 992628699);
						continue;
					}
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1387385634) ^ 0x2C7913D2);
							continue;
						}
						num3 = 1;
						goto IL_0017;
					case 0u:
						result = null;
						num = 39592595;
						continue;
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num3 != 0;
						num = 1159855716;
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
				int num = -1321170144;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x84796735u) % 6u)
					{
					case 4u:
						num = ((int)num2 * -1970244622) ^ 0x1D91F2C0;
						continue;
					case 3u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0026;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 2023745251;
							num5 = 2023745251;
						}
						else
						{
							num4 = 669767676;
							num5 = 669767676;
						}
						num = num4 ^ ((int)num2 * -1674336350);
						continue;
					}
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -383273619) ^ 0xF15D9B;
							continue;
						}
						num3 = 1;
						goto IL_0026;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
						IL_0026:
						flag = (byte)num3 != 0;
						num = -1619472451;
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
				int num = -1216588664;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3FC6FC9u) % 4u)
					{
					case 1u:
						count = m_Dict.Count;
						num = ((int)num2 * -1507253625) ^ 0x2A575FDA;
						continue;
					case 0u:
						num = (int)(num2 * 687390627) ^ -1858930234;
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
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1059172204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5B8C5D3u) % 15u)
				{
				case 14u:
					num = ((int)num2 * -1484964083) ^ -2091415912;
					continue;
				case 13u:
					num = ((int)num2 * -1700361890) ^ -1423243080;
					continue;
				case 12u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)((num2 * 237870192) ^ 0x7A1CC451);
					continue;
				case 11u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -2129002565) ^ 0x5338C56D;
					continue;
				case 10u:
					num = ((int)num2 * -1546000552) ^ 0x85ABBA;
					continue;
				case 8u:
					m_Dict.Add(aKey, aItem);
					num = -1024883504;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -964507562;
						num6 = -964507562;
					}
					else
					{
						num5 = -1558230879;
						num6 = -1558230879;
					}
					num = num5 ^ (int)(num2 * 631893163);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1945373201) ^ 0x77A0CFD2);
					continue;
				case 5u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -937692839) ^ 0x47A8089D;
					continue;
				case 4u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -794786126;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -811060013;
						num4 = -811060013;
					}
					else
					{
						num3 = -630782250;
						num4 = -630782250;
					}
					num = num3 ^ (int)(num2 * 1956555916);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1109154570) ^ -956441537;
					continue;
				case 1u:
					num = -1149580171;
					continue;
				default:
					return;
				case 9u:
					break;
				case 0u:
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
			int num = -2144923938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF46F401u) % 10u)
				{
				case 9u:
					m_Dict.Remove(aKey);
					num = ((int)num2 * -1658594631) ^ 0x7C023149;
					continue;
				case 7u:
					result = jSONNode;
					num = ((int)num2 * -1088853858) ^ -567313199;
					continue;
				case 6u:
					result = null;
					num = ((int)num2 * -1857020203) ^ 0x4FBF2172;
					continue;
				case 5u:
					num = (int)((num2 * 1781684311) ^ 0x169E2CB0);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1025173939;
						num4 = 1025173939;
					}
					else
					{
						num3 = 448073495;
						num4 = 448073495;
					}
					num = num3 ^ (int)(num2 * 298238941);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1355750475) ^ 0xF6E2C31;
					continue;
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1246292532) ^ -1024661943;
					continue;
				case 0u:
					jSONNode = m_Dict[aKey];
					num = -609984410;
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
		if (aIndex >= 0)
		{
			goto IL_0014;
		}
		goto IL_006b;
		IL_0014:
		int num = 348958321;
		goto IL_0033;
		IL_0033:
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4F2080D7u) % 5u)
			{
			case 2u:
				break;
			case 1u:
				result = null;
				num = 1505722572;
				continue;
			case 0u:
				result = null;
				num = ((int)num2 * -695684248) ^ -2095279948;
				continue;
			case 4u:
				goto IL_0058;
			default:
				return result;
			}
			break;
			IL_0058:
			if (aIndex < m_Dict.Count)
			{
				num = 1025149626;
				num3 = 1025149626;
				continue;
			}
			goto IL_006b;
		}
		goto IL_0014;
		IL_006b:
		num = 881392700;
		num3 = 881392700;
		goto IL_0033;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1449381169;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92EFBA25u) % 3u)
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
					num = ((int)num2 * -107353231) ^ 0x7BCB7717;
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
		//yield-return decompiler failed: Missing enumeratorCtor.Body
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
			int num = -233589894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFBBB9FCu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0154:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -2117096638;
								num4 = -2117096638;
							}
							else
							{
								num3 = -1857324051;
								num4 = -1857324051;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCFBBB9FCu) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 2)
									{
										num5 = -263655786;
										num6 = -263655786;
									}
									else
									{
										num5 = -1016051864;
										num6 = -1016051864;
									}
									num3 = num5 ^ ((int)num2 * -166414889);
									continue;
								}
								case 5u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 968514319) ^ 0x6CD6858C);
									continue;
								case 4u:
									num3 = -1857324051;
									continue;
								case 3u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -238557714;
									continue;
								case 2u:
									num3 = (int)(num2 * 418906704) ^ -1542930740;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -361841261;
									continue;
								default:
									goto end_IL_0113;
								case 0u:
									break;
								case 6u:
									goto end_IL_0113;
								}
								goto IL_0154;
								continue;
								end_IL_0113:
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
							IL_019f:
							int num7 = -617928647;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xCFBBB9FCu) % 3u)
								{
								case 2u:
									goto IL_0173;
								default:
									goto end_IL_0181;
								case 0u:
									break;
								case 1u:
									goto end_IL_0181;
								}
								goto IL_019f;
								IL_0173:
								num7 = (int)(num2 * 1048567690) ^ -66594670;
								continue;
								end_IL_0181:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = -1160604946;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xCFBBB9FCu) % 3u)
							{
							case 1u:
								goto IL_01b5;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01b5:
							result = text;
							num8 = (int)((num2 * 1809683670) ^ 0x6B583620);
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{";
				num = ((int)num2 * -86146668) ^ -1488293286;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 369320521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C76DCCCu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 291735572) ^ -981307564;
					continue;
				case 1u:
					text = "{ ";
					num = ((int)num2 * -386748342) ^ 0xA490998;
					continue;
				case 3u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0185:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 574096994;
								num4 = 574096994;
							}
							else
							{
								num3 = 1329986077;
								num4 = 1329986077;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5C76DCCCu) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 3)
									{
										num5 = -120271129;
										num6 = -120271129;
									}
									else
									{
										num5 = -463001696;
										num6 = -463001696;
									}
									num3 = num5 ^ (int)(num2 * 1017298983);
									continue;
								}
								case 5u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = 1004999655;
									continue;
								case 3u:
									num3 = (int)(num2 * 1830500509) ^ -1805530673;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1375143489) ^ -1108674293;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 441862371;
									continue;
								case 0u:
									num3 = 1329986077;
									continue;
								default:
									goto end_IL_0144;
								case 4u:
									break;
								case 6u:
									goto end_IL_0144;
								}
								goto IL_0185;
								continue;
								end_IL_0144:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = 1182536257;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x5C76DCCCu) % 4u)
							{
							case 1u:
								result = text;
								num7 = ((int)num2 * -1768778835) ^ 0x614DA709;
								continue;
							case 0u:
								num7 = ((int)num2 * -1337426078) ^ -622911713;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -415285245;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99C6D6F1u) % 5u)
				{
				case 4u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 801035995) ^ 0x1A5301F1);
					continue;
				case 2u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 1332393803) ^ 0x25F7F0B7);
					continue;
				case 1u:
					num = ((int)num2 * -1392520766) ^ -824235231;
					continue;
				case 0u:
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
							num3 = -948449317;
							num4 = -948449317;
						}
						else
						{
							num3 = -535859279;
							num4 = -535859279;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x99C6D6F1u) % 8u)
							{
							case 7u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -2065053321) ^ 0x17B796DE;
								continue;
							case 6u:
								num3 = (int)((num2 * 280485328) ^ 0x1042ABCC);
								continue;
							case 4u:
								num3 = -948449317;
								continue;
							case 3u:
								num3 = ((int)num2 * -118908761) ^ -1313433789;
								continue;
							case 2u:
								current = enumerator.Current;
								num3 = -443281248;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -2116217724) ^ 0x47ECE43E;
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
