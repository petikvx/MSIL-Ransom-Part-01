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
			bool flag = default(bool);
			while (true)
			{
				int num = 1121946460;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x247870B5u) % 8u)
					{
					case 5u:
						result = m_Dict[aKey];
						num = ((int)num2 * -639300186) ^ 0x7E50C551;
						continue;
					case 4u:
						result = new JSONLazyCreator(this, aKey);
						num = 61788598;
						continue;
					case 3u:
						num = (int)((num2 * 1965716290) ^ 0x274590B5);
						continue;
					case 2u:
						num = (int)(num2 * 656938549) ^ -172653599;
						continue;
					case 1u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1225449650) ^ 0x102BF03B;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -450159432;
							num4 = -450159432;
						}
						else
						{
							num3 = -1186674863;
							num4 = -1186674863;
						}
						num = num3 ^ ((int)num2 * -698891808);
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
		set
		{
			while (true)
			{
				int num = 123440315;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CF4994u) % 6u)
					{
					case 5u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 1095907688) ^ -264997074;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = 1528673002;
							num4 = 1528673002;
						}
						else
						{
							num3 = 1740076384;
							num4 = 1740076384;
						}
						num = num3 ^ ((int)num2 * -1243234233);
						continue;
					}
					case 2u:
						num = ((int)num2 * -1701499928) ^ -2130701902;
						continue;
					case 1u:
						m_Dict.Add(aKey, value);
						num = 860488930;
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
			if (aIndex >= 0)
			{
				goto IL_0013;
			}
			int num = 1;
			goto IL_009a;
			IL_009a:
			bool flag = (byte)num != 0;
			int num2 = 2091555228;
			goto IL_005c;
			IL_0013:
			num2 = 1564718149;
			goto IL_005c;
			IL_005c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x32CEC8F5u) % 7u)
				{
				case 6u:
					result = null;
					num2 = 2050944026;
					continue;
				case 5u:
					break;
				case 4u:
					num2 = (int)((num3 * 1414284043) ^ 0x7D05F16A);
					continue;
				case 3u:
					result = null;
					num2 = (int)(num3 * 1336460267) ^ -921384958;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -2005673628;
						num5 = -2005673628;
					}
					else
					{
						num4 = -240347972;
						num5 = -240347972;
					}
					num2 = num4 ^ ((int)num3 * -256843810);
					continue;
				}
				case 1u:
					goto IL_0089;
				default:
					return result;
				}
				break;
			}
			goto IL_0013;
			IL_0089:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_009a;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_003a;
			}
			int num = 1;
			goto IL_0075;
			IL_0075:
			bool flag = (byte)num != 0;
			int num2 = 1432584790;
			goto IL_003f;
			IL_003a:
			num2 = 1995177397;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB63C249u) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -236444383;
						num5 = -236444383;
					}
					else
					{
						num4 = -1225002280;
						num5 = -1225002280;
					}
					num2 = num4 ^ (int)(num3 * 1949400944);
					continue;
				}
				case 3u:
					num2 = ((int)num3 * -848380984) ^ 0x6F2A6D88;
					continue;
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0064;
				case 0u:
					return;
				}
				break;
			}
			goto IL_003a;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 147489624;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BBE757Du) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_Dict.Count;
					num = ((int)num2 * -1015641944) ^ 0x1D2B1F4F;
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
				int num = 1963947905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36BE9257u) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1690756073) ^ 0x41886EE0;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 113461772) ^ -1931993472;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1990975197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD07C9C2Fu) % 14u)
				{
				case 12u:
					m_Dict.Add(aKey, aItem);
					num = -2009172982;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1727108921;
						num6 = 1727108921;
					}
					else
					{
						num5 = 1392068655;
						num6 = 1392068655;
					}
					num = num5 ^ ((int)num2 * -942043585);
					continue;
				}
				case 9u:
					num = -1359428842;
					continue;
				case 8u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -72337145) ^ 0x28AE4E1E;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 908603129;
						num4 = 908603129;
					}
					else
					{
						num3 = 702924138;
						num4 = 702924138;
					}
					num = num3 ^ ((int)num2 * -8215638);
					continue;
				}
				case 6u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = (int)((num2 * 480793738) ^ 0x6FC2BD92);
					continue;
				case 5u:
					num = ((int)num2 * -1774872408) ^ 0x4D46F712;
					continue;
				case 4u:
					num = ((int)num2 * -1864315795) ^ 0x267FA07E;
					continue;
				case 3u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1185339637;
					continue;
				case 2u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 792634507) ^ 0x4ABF0BA7);
					continue;
				case 1u:
					num = (int)(num2 * 1702184122) ^ -464802496;
					continue;
				case 0u:
					num = ((int)num2 * -1851647833) ^ 0x18DC4B69;
					continue;
				default:
					return;
				case 13u:
					break;
				case 11u:
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
			int num = 1132842587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x471218CFu) % 9u)
				{
				case 8u:
					num = (int)(num2 * 1496302539) ^ -1919214486;
					continue;
				case 7u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -1444837619) ^ 0x3F90B492;
					continue;
				case 6u:
					jSONNode = m_Dict[aKey];
					num = 820608733;
					continue;
				case 5u:
					num = ((int)num2 * -255991215) ^ 0x7B47BCD7;
					continue;
				case 4u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1268000683) ^ -1270467020;
					continue;
				case 3u:
					result = null;
					num = ((int)num2 * -271787291) ^ -1785451467;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1332675433;
						num4 = 1332675433;
					}
					else
					{
						num3 = 822159966;
						num4 = 822159966;
					}
					num = num3 ^ (int)(num2 * 522725315);
					continue;
				}
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
			int num = -296333177;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x832DD69Eu) % 7u)
				{
				case 6u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1654293706) ^ 0x197E2FA;
						continue;
					}
					goto IL_0028;
				case 5u:
					result = null;
					num = -971177677;
					continue;
				case 4u:
					if (aIndex < m_Dict.Count)
					{
						num = -1294950078;
						num3 = -1294950078;
						continue;
					}
					goto IL_0028;
				case 3u:
					num = ((int)num2 * -1961838731) ^ -220066909;
					continue;
				case 2u:
					result = null;
					num = ((int)num2 * -1712493138) ^ -760847432;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0028:
					num = -438888157;
					num3 = -438888157;
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
				int num = -243260333;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCD6EF9E1u) % 3u)
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
					num = (int)(num2 * 127067520) ^ -1836878076;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = -315393067;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ -848365087;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num2 * -745225165) ^ -2124320929;
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
			int num = -14810678;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE78C1BCu) % 4u)
				{
				case 2u:
					text = "{";
					num = (int)(num2 * 1727348278) ^ -771155267;
					continue;
				case 1u:
					num = ((int)num2 * -1430065629) ^ 0x16A8BD7;
					continue;
				case 3u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0180:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -2075806041;
								num4 = -2075806041;
							}
							else
							{
								num3 = -1954456107;
								num4 = -1954456107;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFE78C1BCu) % 9u)
								{
								case 7u:
									num3 = (int)(num2 * 1991943665) ^ -535146031;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = -219207383;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -1103777398;
										num6 = -1103777398;
									}
									else
									{
										num5 = -1777513369;
										num6 = -1777513369;
									}
									num3 = num5 ^ ((int)num2 * -958700704);
									continue;
								}
								case 4u:
									num3 = ((int)num2 * -156869498) ^ -120666041;
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
									num3 = -521595161;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 2034909851) ^ -1928490731;
									continue;
								case 0u:
									num3 = -1954456107;
									continue;
								default:
									goto end_IL_013a;
								case 3u:
									break;
								case 8u:
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
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_01cb:
							int num7 = -47912300;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xFE78C1BCu) % 3u)
								{
								case 1u:
									goto IL_019f;
								default:
									goto end_IL_01ad;
								case 2u:
									break;
								case 0u:
									goto end_IL_01ad;
								}
								goto IL_01cb;
								IL_019f:
								num7 = ((int)num2 * -1070951911) ^ 0x43162712;
								continue;
								end_IL_01ad:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num8 = -1722642257;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xFE78C1BCu) % 3u)
							{
							case 2u:
								goto IL_01e4;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01e4:
							num8 = ((int)num2 * -886486756) ^ -1043928659;
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
			int num = -1333552861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x934733DBu) % 3u)
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
							IL_01a2:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -594168303;
								num4 = -594168303;
							}
							else
							{
								num3 = -1649152661;
								num4 = -1649152661;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x934733DBu) % 10u)
								{
								case 9u:
									num3 = -594168303;
									continue;
								case 8u:
									num3 = ((int)num2 * -984577991) ^ 0x183AFA7C;
									continue;
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 1684832592) ^ 0x53B244B8);
									continue;
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
									num3 = -539392697;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = -811760313;
									continue;
								case 3u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -611429801) ^ -1295647385;
									continue;
								case 2u:
									num3 = ((int)num2 * -167311769) ^ -1219463313;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1609289712;
										num6 = -1609289712;
									}
									else
									{
										num5 = -30365048;
										num6 = -30365048;
									}
									num3 = num5 ^ (int)(num2 * 1720443968);
									continue;
								}
								default:
									goto end_IL_0158;
								case 0u:
									break;
								case 6u:
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
						int num7 = -2040926846;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x934733DBu) % 4u)
							{
							case 1u:
								result = text;
								num7 = ((int)num2 * -2052216894) ^ 0xCA31D1D;
								continue;
							case 0u:
								num7 = (int)(num2 * 1371156582) ^ -1651868812;
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
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -1461811847) ^ -814293965;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -204420942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE14DCDC6u) % 5u)
				{
				case 4u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 1259082819) ^ 0x100D537C);
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -2080525916) ^ -1673085636;
					continue;
				case 0u:
					num = (int)((num2 * 1399035877) ^ 0x111438CE);
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
							if (!enumerator.MoveNext())
							{
								num3 = -466395735;
								num4 = -466395735;
							}
							else
							{
								num3 = -1954988400;
								num4 = -1954988400;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE14DCDC6u) % 8u)
								{
								case 6u:
									current = enumerator.Current;
									num3 = -1737163737;
									continue;
								case 5u:
									num3 = -1954988400;
									continue;
								case 4u:
									num3 = ((int)num2 * -2039722415) ^ -603773456;
									continue;
								case 3u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -1570906635) ^ 0x31C180D1;
									continue;
								case 1u:
									JSONClass.smethod_38(aWriter, current);
									num3 = ((int)num2 * -802954165) ^ -729383242;
									continue;
								case 0u:
									num3 = ((int)num2 * -480505831) ^ 0x3A75060A;
									continue;
								default:
									return;
								case 2u:
									break;
								case 7u:
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
							IL_0188:
							int num5 = -1383454837;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xE14DCDC6u) % 3u)
								{
								case 1u:
									goto IL_015e;
								default:
									goto end_IL_016b;
								case 2u:
									break;
								case 0u:
									goto end_IL_016b;
								}
								goto IL_0188;
								IL_015e:
								num5 = ((int)num2 * -1867187108) ^ -1881887389;
								continue;
								end_IL_016b:
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
