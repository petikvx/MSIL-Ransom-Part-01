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
				int num = -1930473135;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEEAB28Fu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 877218378;
							num4 = 877218378;
						}
						else
						{
							num3 = 724338947;
							num4 = 724338947;
						}
						num = num3 ^ (int)(num2 * 592834795);
						continue;
					}
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = -1528826947;
						continue;
					case 4u:
						num = (int)(num2 * 1574944407) ^ -2092547050;
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -314730133) ^ 0x1DBB893D;
						continue;
					case 0u:
						result = m_Dict[aKey];
						num = ((int)num2 * -856292146) ^ -1953657456;
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
		set
		{
			while (true)
			{
				int num = -1107301852;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF94152E3u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = 600564532;
							num4 = 600564532;
						}
						else
						{
							num3 = 1915680076;
							num4 = 1915680076;
						}
						num = num3 ^ (int)(num2 * 1637765492);
						continue;
					}
					case 3u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1422748147) ^ 0x2EF9C86A;
						continue;
					case 2u:
						num = ((int)num2 * -1615147122) ^ -1305099399;
						continue;
					case 1u:
						m_Dict.Add(aKey, value);
						num = -1758739275;
						continue;
					default:
						return;
					case 0u:
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
				int num = 921543207;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x7065E12Fu) % 9u)
					{
					case 7u:
						num = ((int)num2 * -1503773988) ^ 0x702CC812;
						continue;
					case 5u:
						result = null;
						num = 1249123588;
						continue;
					case 4u:
						num = (int)(num2 * 2085920194) ^ -511695916;
						continue;
					case 3u:
						result = null;
						num = ((int)num2 * -83801792) ^ 0x38084163;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1587972481) ^ -86926793;
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
							num3 = -1091391416;
							num4 = -1091391416;
						}
						else
						{
							num3 = -815597327;
							num4 = -815597327;
						}
						num = num3 ^ ((int)num2 * -310873516);
						continue;
					}
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_0052:
						flag = (byte)num5 != 0;
						num = 778988696;
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
				int num = 864373111;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4E350246u) % 6u)
					{
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 925560614) ^ 0x1B086A40);
							continue;
						}
						num3 = 1;
						goto IL_001a;
					case 3u:
						num = (int)(num2 * 1217029847) ^ -1177124633;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1808546879;
							num5 = 1808546879;
						}
						else
						{
							num4 = 707009304;
							num5 = 707009304;
						}
						num = num4 ^ (int)(num2 * 765690346);
						continue;
					}
					case 0u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					default:
						return;
					case 2u:
						break;
					case 4u:
						return;
						IL_001a:
						flag = (byte)num3 != 0;
						num = 127879309;
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
				int num = 72769328;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x35887A44u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = (int)(num2 * 663094154) ^ -1515809884;
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
			int num = 140614548;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x354E2757u) % 13u)
				{
				case 12u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1440258846) ^ -249709779;
					continue;
				case 11u:
					num = (int)(num2 * 1486839713) ^ -1612035057;
					continue;
				case 10u:
					num = ((int)num2 * -1864020099) ^ 0x445DE385;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (JSONClass.smethod_30(aKey))
					{
						num5 = 829622495;
						num6 = 829622495;
					}
					else
					{
						num5 = 1379616858;
						num6 = 1379616858;
					}
					num = num5 ^ ((int)num2 * -482381624);
					continue;
				}
				case 8u:
					num = ((int)num2 * -386492445) ^ 0x4B4EBD6A;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = -2137396777;
						num4 = -2137396777;
					}
					else
					{
						num3 = -464893918;
						num4 = -464893918;
					}
					num = num3 ^ (int)(num2 * 1552051708);
					continue;
				}
				case 5u:
					m_Dict.Add(aKey, aItem);
					num = 1597762940;
					continue;
				case 4u:
					num = ((int)num2 * -139799372) ^ 0x6704CB19;
					continue;
				case 3u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1943935212;
					continue;
				case 2u:
					num = (int)((num2 * 215882029) ^ 0x1718D1B8);
					continue;
				case 1u:
					num = 543339875;
					continue;
				default:
					return;
				case 7u:
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
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2046841054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE4A11572u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -1938336499) ^ -2110586343;
					continue;
				case 4u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = -212101189;
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1900737069;
						num4 = -1900737069;
					}
					else
					{
						num3 = -621766244;
						num4 = -621766244;
					}
					num = num3 ^ ((int)num2 * -1378201595);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1363068566) ^ -1165196888;
					continue;
				case 1u:
					result = null;
					num = (int)((num2 * 541238700) ^ 0x3899E35C);
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1490332869;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x2D7CE606u) % 7u)
				{
				case 6u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -839408565) ^ -392151861;
						continue;
					}
					goto IL_0028;
				case 5u:
					num = ((int)num2 * -2043014053) ^ 0x5FC8371F;
					continue;
				case 4u:
					if (aIndex < m_Dict.Count)
					{
						num = 298664677;
						num3 = 298664677;
						continue;
					}
					goto IL_0028;
				case 3u:
					result = null;
					num = ((int)num2 * -300734340) ^ -208785624;
					continue;
				case 2u:
					result = null;
					num = 2024387045;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0028:
					num = 1121163070;
					num3 = 1121163070;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		while (true)
		{
			int num = 390737373;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12086A7u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_016f:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1295514206;
								num4 = 1295514206;
							}
							else
							{
								num3 = 378385630;
								num4 = 378385630;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x12086A7u) % 9u)
								{
								case 8u:
									num3 = ((int)num2 * -1120806432) ^ 0x47B12AA7;
									continue;
								case 5u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -2051928815) ^ -138298041;
									continue;
								case 4u:
									num3 = ((int)num2 * -1551165917) ^ 0x726609BC;
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
									num3 = 1270893562;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = 1624312300;
										num6 = 1624312300;
									}
									else
									{
										num5 = 920760492;
										num6 = 920760492;
									}
									num3 = num5 ^ ((int)num2 * -56417127);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = 2055917613;
									continue;
								case 0u:
									num3 = 1295514206;
									continue;
								default:
									goto end_IL_0129;
								case 6u:
									break;
								case 7u:
									goto end_IL_0129;
								}
								goto IL_016f;
								continue;
								end_IL_0129:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num7 = 372043078;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x12086A7u) % 3u)
							{
							case 1u:
								goto IL_019e;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019e:
							num7 = ((int)num2 * -1905049342) ^ -301838812;
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{";
				num = ((int)num2 * -976436935) ^ -1275893922;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = 941638279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E5CBFF5u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_01bb:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1885036315;
								num4 = 1885036315;
							}
							else
							{
								num3 = 1696978199;
								num4 = 1696978199;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6E5CBFF5u) % 11u)
								{
								case 9u:
									num3 = 1885036315;
									continue;
								case 8u:
									num3 = (int)((num2 * 1084507198) ^ 0x424CFEC1);
									continue;
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1227817550) ^ 0x29C29A0F;
									continue;
								case 6u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 1970932574;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -265744955;
										num6 = -265744955;
									}
									else
									{
										num5 = -750684479;
										num6 = -750684479;
									}
									num3 = num5 ^ (int)(num2 * 110745961);
									continue;
								}
								case 3u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)(num2 * 1485088863) ^ -436056495;
									continue;
								case 2u:
									num3 = ((int)num2 * -249236874) ^ -2042007239;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 667797434;
									continue;
								case 0u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -439608103) ^ 0x29A40F5D;
									continue;
								default:
									goto end_IL_016d;
								case 10u:
									break;
								case 5u:
									goto end_IL_016d;
								}
								goto IL_01bb;
								continue;
								end_IL_016d:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = 1609916506;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x6E5CBFF5u) % 3u)
							{
							case 1u:
								goto IL_01f0;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01f0:
							num7 = ((int)num2 * -1577508485) ^ 0x5D6DD1F9;
						}
					}
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -742005556) ^ 0x78D78A2;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -47263705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDFA7A48u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1051868957) ^ -242532483;
					continue;
				case 3u:
					num = (int)((num2 * 88451935) ^ 0x26B45D0C);
					continue;
				case 1u:
					num = (int)((num2 * 678541710) ^ 0x56315EAA);
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1979351207) ^ 0x46CDA3CF;
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
							num3 = -1425271582;
							num4 = -1425271582;
						}
						else
						{
							num3 = -638570917;
							num4 = -638570917;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xEDFA7A48u) % 8u)
							{
							case 7u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)(num2 * 685186783) ^ -1509066319;
								continue;
							case 6u:
								num3 = -638570917;
								continue;
							case 5u:
								num3 = ((int)num2 * -148367761) ^ 0x43976E57;
								continue;
							case 3u:
								current = enumerator.Current;
								num3 = -556082599;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)(num2 * 401660586) ^ -1473694819;
								continue;
							case 0u:
								num3 = (int)((num2 * 1679385436) ^ 0x67BA2BF5);
								continue;
							default:
								return;
							case 4u:
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
