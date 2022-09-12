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
				int num = -2022018906;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B2609ADu) % 6u)
					{
					case 5u:
						num = (int)(num2 * 140567027) ^ -959645577;
						continue;
					case 4u:
						result = m_Dict[aKey];
						num = ((int)num2 * -789681290) ^ -1641534554;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = -578557137;
							num4 = -578557137;
						}
						else
						{
							num3 = -532364839;
							num4 = -532364839;
						}
						num = num3 ^ ((int)num2 * -1875219308);
						continue;
					}
					case 0u:
						result = new JSONLazyCreator(this, aKey);
						num = -422355110;
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
				int num = -1898094637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD68B50FFu) % 8u)
					{
					case 7u:
						m_Dict.Add(aKey, value);
						num = -1674175511;
						continue;
					case 6u:
						num = (int)((num2 * 1260189627) ^ 0x4E4E18A0);
						continue;
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1226671398) ^ 0x280BB72F;
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 348129493) ^ 0x48EE0BAC);
						continue;
					case 1u:
						num = ((int)num2 * -722905134) ^ 0x11367B80;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 401165072;
							num4 = 401165072;
						}
						else
						{
							num3 = 160292941;
							num4 = 160292941;
						}
						num = num3 ^ (int)(num2 * 1644103689);
						continue;
					}
					default:
						return;
					case 3u:
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
				int num = 668906551;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x6A3AB36Eu) % 9u)
					{
					case 8u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 326398982) ^ 0x7DD659F2);
							continue;
						}
						num3 = 1;
						goto IL_001a;
					case 7u:
						result = null;
						num = (int)(num2 * 553281230) ^ -1385252338;
						continue;
					case 6u:
						result = null;
						num = 279543399;
						continue;
					case 4u:
						num = ((int)num2 * -1645186751) ^ -15191551;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1184826363;
							num5 = 1184826363;
						}
						else
						{
							num4 = 1988101163;
							num5 = 1988101163;
						}
						num = num4 ^ ((int)num2 * -900831963);
						continue;
					}
					case 1u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					case 0u:
						num = (int)((num2 * 1044988012) ^ 0x4B9ECA3F);
						continue;
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_001a:
						flag = (byte)num3 != 0;
						num = 821543276;
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
				int num = 1594994017;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5B5A9C4u) % 6u)
					{
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 2014403373;
							num5 = 2014403373;
						}
						else
						{
							num4 = 1266824566;
							num5 = 1266824566;
						}
						num = num4 ^ (int)(num2 * 1813905137);
						continue;
					}
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1444331450) ^ -509530800;
							continue;
						}
						num3 = 1;
						goto IL_003e;
					case 1u:
						num = (int)(num2 * 850708578) ^ -1370728298;
						continue;
					case 0u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_003e;
					default:
						return;
					case 5u:
						break;
					case 2u:
						return;
						IL_003e:
						flag = (byte)num3 != 0;
						num = 1868201642;
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
				int num = 1288993665;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7657FEA2u) % 4u)
					{
					case 3u:
						count = m_Dict.Count;
						num = ((int)num2 * -1936678513) ^ 0x18D6C7E2;
						continue;
					case 1u:
						num = ((int)num2 * -1378498080) ^ 0x7806F468;
						continue;
					case 0u:
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
				int num = 525136888;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EF1CAFAu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)(num2 * 322411801) ^ -1084327407;
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
			int num = -1245892568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1C30E3Fu) % 15u)
				{
				case 14u:
					num = (int)(num2 * 521679408) ^ -1145027394;
					continue;
				case 13u:
					num = ((int)num2 * -259152636) ^ 0x7901A48C;
					continue;
				case 11u:
					m_Dict.Add(aKey, aItem);
					num = -786494659;
					continue;
				case 10u:
					num = -381304301;
					continue;
				case 9u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 1341462008) ^ -2077547458;
					continue;
				case 8u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1238944797) ^ -1802438036;
					continue;
				case 7u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1925488057) ^ 0x923C17C;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1118786111;
						num6 = -1118786111;
					}
					else
					{
						num5 = -985324620;
						num6 = -985324620;
					}
					num = num5 ^ ((int)num2 * -14220595);
					continue;
				}
				case 4u:
					num = ((int)num2 * -543650082) ^ -1349245597;
					continue;
				case 3u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -926249317;
					continue;
				case 2u:
					num = (int)((num2 * 616320698) ^ 0x4F31FD85);
					continue;
				case 1u:
					num = ((int)num2 * -757114314) ^ 0x65E89B54;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 977444090;
						num4 = 977444090;
					}
					else
					{
						num3 = 214028811;
						num4 = 214028811;
					}
					num = num3 ^ (int)(num2 * 648451488);
					continue;
				}
				default:
					return;
				case 12u:
					break;
				case 6u:
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
		while (true)
		{
			int num = 7582634;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A28CE48u) % 7u)
				{
				case 5u:
					result = null;
					num = ((int)num2 * -391633465) ^ 0x15BF310C;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 571647871;
						num4 = 571647871;
					}
					else
					{
						num3 = 864976734;
						num4 = 864976734;
					}
					num = num3 ^ (int)(num2 * 1509570461);
					continue;
				}
				case 3u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = 214979976;
					continue;
				}
				case 2u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1285998265) ^ 0x4F35EFD7);
					continue;
				case 1u:
					num = ((int)num2 * -1775527286) ^ -1924191244;
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1916899916;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x98A5B59u) % 8u)
				{
				case 7u:
					num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0017;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 1290615431) ^ -1989544171;
						continue;
					}
					num5 = 1;
					goto IL_0017;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1505506899;
						num4 = -1505506899;
					}
					else
					{
						num3 = -228537473;
						num4 = -228537473;
					}
					num = num3 ^ (int)(num2 * 1454618002);
					continue;
				}
				case 2u:
					result = null;
					num = (int)(num2 * 2128590196) ^ -1221017968;
					continue;
				case 1u:
					num = (int)(num2 * 2004564724) ^ -1208653543;
					continue;
				case 0u:
					result = null;
					num = 192315501;
					continue;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num5 != 0;
					num = 508590490;
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
		//IL_0068: Incompatible stack heights: 0 vs 1
		//IL_006f: Incompatible stack heights: 0 vs 1
		JSONNode result = default(JSONNode);
		try
		{
			while (true)
			{
				int num = 1815844159;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72C3A23Bu) % 3u)
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
					num = (int)(num2 * 815903768) ^ -243895488;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 1682129030;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x72C3A23B;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = (num2 * 398791453) ^ 0x8A06C013u;
						continue;
					case 2:
						break;
					default:
						return result;
					case 0:
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		while (true)
		{
			int num = 1934638895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13673A2u) % 4u)
				{
				case 1u:
					text = "{";
					num = (int)((num2 * 1436494699) ^ 0xE7AC81D);
					continue;
				case 0u:
					num = (int)(num2 * 959465846) ^ -303361299;
					continue;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0180:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 2014996712;
								num4 = 2014996712;
							}
							else
							{
								num3 = 1969817254;
								num4 = 1969817254;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x13673A2u) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = 908514101;
									continue;
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1656783910) ^ -1970378497;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -1706042641;
										num6 = -1706042641;
									}
									else
									{
										num5 = -1409241787;
										num6 = -1409241787;
									}
									num3 = num5 ^ ((int)num2 * -1309516574);
									continue;
								}
								case 5u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = 1327814061;
									continue;
								case 4u:
									num3 = (int)((num2 * 912012321) ^ 0x6C6BAA0B);
									continue;
								case 1u:
									num3 = ((int)num2 * -353124923) ^ 0x23ACA65F;
									continue;
								case 0u:
									num3 = 2014996712;
									continue;
								default:
									goto end_IL_013a;
								case 3u:
									break;
								case 2u:
									goto end_IL_013a;
								}
								goto IL_0180;
								continue;
								end_IL_013a:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num7 = 641853782;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x13673A2u) % 3u)
							{
							case 1u:
								goto IL_01af;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01af:
							num7 = (int)((num2 * 192608244) ^ 0x53D9ECB6);
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
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -457032182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5C5D76Du) % 3u)
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
							IL_018f:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1471841899;
								num4 = -1471841899;
							}
							else
							{
								num3 = -1216256684;
								num4 = -1216256684;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB5C5D76Du) % 9u)
								{
								case 8u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -1244586430;
									continue;
								case 7u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 3)
									{
										num5 = -945095993;
										num6 = -945095993;
									}
									else
									{
										num5 = -876080062;
										num6 = -876080062;
									}
									num3 = num5 ^ (int)(num2 * 55877545);
									continue;
								}
								case 6u:
									current = enumerator.Current;
									num3 = -1526293602;
									continue;
								case 4u:
									num3 = -1471841899;
									continue;
								case 2u:
									num3 = ((int)num2 * -1355241331) ^ -28100056;
									continue;
								case 1u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -174465207) ^ -720037351;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -199108169) ^ -835908690;
									continue;
								default:
									goto end_IL_0149;
								case 3u:
									break;
								case 5u:
									goto end_IL_0149;
								}
								goto IL_018f;
								continue;
								end_IL_0149:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = -1265596766;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xB5C5D76Du) % 4u)
							{
							case 3u:
								result = text;
								num7 = (int)(num2 * 1964274381) ^ -266067416;
								continue;
							case 2u:
								num7 = ((int)num2 * -1073063179) ^ 0x149179F2;
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
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -1332254735) ^ 0x70614FA;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -1580436755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EE6899Fu) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1489839106) ^ 0x74FFBE5C);
					continue;
				case 3u:
					num = (int)(num2 * 407998006) ^ -1392281601;
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 1395534522) ^ -2093478643;
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
							num3 = -756065614;
							num4 = -756065614;
						}
						else
						{
							num3 = -833013179;
							num4 = -833013179;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x8EE6899Fu) % 8u)
							{
							case 6u:
								num3 = (int)((num2 * 660000003) ^ 0x2C988A31);
								continue;
							case 4u:
								JSONClass.smethod_38(aWriter, current);
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 1698560270) ^ 0x7F3C31D6);
								continue;
							case 3u:
								num3 = ((int)num2 * -1373393044) ^ -1412968684;
								continue;
							case 2u:
								current = enumerator.Current;
								num3 = -859103951;
								continue;
							case 1u:
								num3 = (int)(num2 * 670312813) ^ -245326743;
								continue;
							case 0u:
								num3 = -833013179;
								continue;
							default:
								return;
							case 7u:
								break;
							case 5u:
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
