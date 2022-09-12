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
			int num = 597798356;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x777FCBF5u) % 5u)
				{
				case 2u:
					result = m_Dict[aKey];
					num = (int)((num2 * 1821415605) ^ 0x1B60E5A1);
					continue;
				case 1u:
					num = (int)((num2 * 1784130833) ^ 0x42354ECE);
					continue;
				case 0u:
					break;
				case 4u:
					goto IL_0065;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = 1842855507;
			goto IL_0040;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 422919345;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6910B656u) % 8u)
					{
					case 7u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -63199762) ^ -1990402174;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1948097974;
							num4 = 1948097974;
						}
						else
						{
							num3 = 17802700;
							num4 = 17802700;
						}
						num = num3 ^ (int)(num2 * 889566312);
						continue;
					}
					case 5u:
						num = ((int)num2 * -651426729) ^ -1622851191;
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -448315585) ^ -912608359;
						continue;
					case 1u:
						num = ((int)num2 * -570636196) ^ 0x26EBEFF6;
						continue;
					case 0u:
						m_Dict.Add(aKey, value);
						num = 944271587;
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
				int num = 924306500;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x14EC0C54u) % 9u)
					{
					case 8u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0017;
					case 7u:
						result = null;
						num = ((int)num2 * -443852533) ^ -1420460570;
						continue;
					case 6u:
						result = null;
						num = 1696815389;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 976075223;
							num5 = 976075223;
						}
						else
						{
							num4 = 1324247530;
							num5 = 1324247530;
						}
						num = num4 ^ ((int)num2 * -927020524);
						continue;
					}
					case 4u:
						num = ((int)num2 * -526607992) ^ 0x4CCF88CF;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1666482760) ^ -1846850084;
							continue;
						}
						num3 = 1;
						goto IL_0017;
					case 0u:
						num = (int)((num2 * 667647411) ^ 0x23AC2A5B);
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num3 != 0;
						num = 1033539435;
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
				int num = -1739450795;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x985CE736u) % 6u)
					{
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -130047716;
							num5 = -130047716;
						}
						else
						{
							num4 = -1950502387;
							num5 = -1950502387;
						}
						num = num4 ^ ((int)num2 * -940167005);
						continue;
					}
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1333267940) ^ 0x4F6900C6);
							continue;
						}
						num3 = 1;
						goto IL_003e;
					case 2u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_003e;
					case 1u:
						num = ((int)num2 * -251742745) ^ -987208671;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
						IL_003e:
						flag = (byte)num3 != 0;
						num = -1478269811;
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
				int num = -1178801974;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF681136u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_Dict.Count;
					num = ((int)num2 * -869015369) ^ 0x11E3AAFB;
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
			int num = 619297494;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42406905u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -573726393) ^ 0x3D9EA834;
					continue;
				case 10u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 633548758;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -663350963;
						num6 = -663350963;
					}
					else
					{
						num5 = -891831210;
						num6 = -891831210;
					}
					num = num5 ^ (int)(num2 * 1049863539);
					continue;
				}
				case 8u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 119925533) ^ -37706988;
					continue;
				case 7u:
					m_Dict.Add(aKey, aItem);
					num = 246973159;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1297688437;
						num4 = -1297688437;
					}
					else
					{
						num3 = -2060993656;
						num4 = -2060993656;
					}
					num = num3 ^ (int)(num2 * 881779464);
					continue;
				}
				case 5u:
					num = ((int)num2 * -146397944) ^ -1023758801;
					continue;
				case 3u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = (int)((num2 * 1789209059) ^ 0x1C396DB6);
					continue;
				case 2u:
					num = 527761329;
					continue;
				case 1u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1964969466) ^ 0xA57A2AE);
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

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 72879952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71844551u) % 8u)
				{
				case 6u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -1105547464) ^ 0x669069E3;
					continue;
				case 5u:
					result = null;
					num = ((int)num2 * -2138493927) ^ -1001037749;
					continue;
				case 3u:
					jSONNode = m_Dict[aKey];
					num = 906592943;
					continue;
				case 2u:
					num = ((int)num2 * -1968536968) ^ 0xC085F9E;
					continue;
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1760808688) ^ -1943444799;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -250375492;
						num4 = -250375492;
					}
					else
					{
						num3 = -1565505014;
						num4 = -1565505014;
					}
					num = num3 ^ ((int)num2 * -757322900);
					continue;
				}
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 451045284;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7941B909u) % 8u)
				{
				case 6u:
					num = (int)((num2 * 2139530707) ^ 0x11419D77);
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 43683738) ^ -412781070;
						continue;
					}
					goto IL_0037;
				case 3u:
					result = null;
					num = 406855671;
					continue;
				case 2u:
					result = null;
					num = (int)(num2 * 1333323870) ^ -780599795;
					continue;
				case 1u:
					if (aIndex < m_Dict.Count)
					{
						num = 781767434;
						num3 = 781767434;
						continue;
					}
					goto IL_0037;
				case 0u:
					num = (int)((num2 * 101316522) ^ 0x5350741D);
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_0037:
					num = 1958007563;
					num3 = 1958007563;
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
			int num = 540982449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6897FCC6u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_016b:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1578599912;
								num4 = 1578599912;
							}
							else
							{
								num3 = 1256112834;
								num4 = 1256112834;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6897FCC6u) % 9u)
								{
								case 8u:
									num3 = 1256112834;
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
									num3 = 319386646;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1767435361;
										num6 = -1767435361;
									}
									else
									{
										num5 = -1623135620;
										num6 = -1623135620;
									}
									num3 = num5 ^ ((int)num2 * -107182806);
									continue;
								}
								case 5u:
									current = enumerator.Current;
									num3 = 843872808;
									continue;
								case 3u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)(num2 * 1565658320) ^ -927254630;
									continue;
								case 1u:
									num3 = ((int)num2 * -1107412350) ^ -1739019519;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1370884604) ^ -1625820256;
									continue;
								default:
									goto end_IL_0125;
								case 2u:
									break;
								case 4u:
									goto end_IL_0125;
								}
								goto IL_016b;
								continue;
								end_IL_0125:
								break;
							}
							break;
						}
					}
					return JSONClass.smethod_32(text, "}");
				}
				}
				break;
				IL_0003:
				text = "{";
				num = (int)(num2 * 1541030294) ^ -2084049505;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = default(string);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		while (true)
		{
			int num = 2134204073;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A01B8ECu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_01b6:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1179865261;
								num4 = 1179865261;
							}
							else
							{
								num3 = 1082242124;
								num4 = 1082242124;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5A01B8ECu) % 11u)
								{
								case 10u:
									num3 = ((int)num2 * -1049973067) ^ 0x7A7CDF77;
									continue;
								case 9u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = (int)(num2 * 1209653981) ^ -800581883;
									continue;
								case 8u:
									num3 = ((int)num2 * -759594864) ^ -97944183;
									continue;
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 224336973) ^ 0x44F8CCEB);
									continue;
								case 6u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -1388656027) ^ -641855516;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = 1041345374;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1913184114;
										num6 = 1913184114;
									}
									else
									{
										num5 = 1987603693;
										num6 = 1987603693;
									}
									num3 = num5 ^ (int)(num2 * 264785563);
									continue;
								}
								case 2u:
									num3 = 1082242124;
									continue;
								case 1u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 811891305;
									continue;
								default:
									goto end_IL_0168;
								case 5u:
									break;
								case 0u:
									goto end_IL_0168;
								}
								goto IL_01b6;
								continue;
								end_IL_0168:
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
							IL_0201:
							int num7 = 2096017277;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x5A01B8ECu) % 3u)
								{
								case 1u:
									goto IL_01d5;
								default:
									goto end_IL_01e3;
								case 0u:
									break;
								case 2u:
									goto end_IL_01e3;
								}
								goto IL_0201;
								IL_01d5:
								num7 = ((int)num2 * -766975404) ^ 0x65E145F5;
								continue;
								end_IL_01e3:
								break;
							}
							break;
						}
					}
					return JSONClass.smethod_35(text, "\n", aPrefix, "}");
				}
				}
				break;
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -1010170047) ^ 0x70CE65FD;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = 1241305441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x578B845Cu) % 3u)
				{
				case 1u:
					goto IL_0009;
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
							num3 = 2138653123;
							num4 = 2138653123;
						}
						else
						{
							num3 = 659656040;
							num4 = 659656040;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x578B845Cu) % 8u)
							{
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -807082772) ^ 0x28FFF605;
								continue;
							case 4u:
								current = enumerator.Current;
								num3 = 1790711198;
								continue;
							case 3u:
								num3 = 659656040;
								continue;
							case 2u:
								num3 = (int)(num2 * 724280868) ^ -649982756;
								continue;
							case 1u:
								num3 = (int)((num2 * 843908854) ^ 0x11508CFF);
								continue;
							case 0u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -777136610) ^ 0x48CB2122;
								continue;
							default:
								return;
							case 5u:
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
				IL_0009:
				JSONClass.smethod_37(aWriter, m_Dict.Count);
				num = (int)(num2 * 243229660) ^ -1193188444;
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
