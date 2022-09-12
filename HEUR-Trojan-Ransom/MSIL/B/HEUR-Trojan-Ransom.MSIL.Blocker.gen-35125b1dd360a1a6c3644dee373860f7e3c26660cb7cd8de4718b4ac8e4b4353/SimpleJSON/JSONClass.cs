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
				int num = -87674954;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB2080D01u) % 8u)
					{
					case 7u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)((num2 * 583056925) ^ 0x1EA71841);
						continue;
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = -986622736;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -259554585;
							num4 = -259554585;
						}
						else
						{
							num3 = -1503086038;
							num4 = -1503086038;
						}
						num = num3 ^ ((int)num2 * -231312471);
						continue;
					}
					case 2u:
						num = (int)((num2 * 212404059) ^ 0x6C21DAC9);
						continue;
					case 1u:
						num = (int)(num2 * 309572223) ^ -572231800;
						continue;
					case 0u:
						result = m_Dict[aKey];
						num = (int)(num2 * 655707782) ^ -1912835493;
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
		set
		{
			while (true)
			{
				int num = -1973804458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD039AC11u) % 6u)
					{
					case 4u:
						m_Dict.Add(aKey, value);
						num = -534454075;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = 1684642455;
							num4 = 1684642455;
						}
						else
						{
							num3 = 1235832836;
							num4 = 1235832836;
						}
						num = num3 ^ (int)(num2 * 2137587304);
						continue;
					}
					case 2u:
						num = (int)(num2 * 1416214337) ^ -967634637;
						continue;
					case 1u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 1366905861) ^ 0x6A4B0EE6);
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
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_002f;
			IL_002f:
			int num = -1467501518;
			goto IL_0054;
			IL_0054:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3FC553Cu) % 7u)
				{
				case 6u:
					result = null;
					num = -1367125304;
					continue;
				case 5u:
					num = ((int)num2 * -2043817292) ^ 0x11F7F590;
					continue;
				case 3u:
					break;
				case 1u:
					result = null;
					num = ((int)num2 * -1136968715) ^ -83882708;
					continue;
				case 0u:
					num = ((int)num2 * -1035049586) ^ 0x7F88BA20;
					continue;
				case 2u:
					goto IL_0081;
				default:
					return result;
				}
				break;
				IL_0081:
				if (aIndex < m_Dict.Count)
				{
					num = -541287450;
					num3 = -541287450;
					continue;
				}
				goto IL_000a;
			}
			goto IL_002f;
			IL_000a:
			num = -1866001706;
			num3 = -1866001706;
			goto IL_0054;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1127137924;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x3E3A8E60u) % 6u)
					{
					case 3u:
						num = ((int)num2 * -1235934755) ^ -333827327;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1776655946) ^ -1068463453;
							continue;
						}
						num5 = 1;
						goto IL_0029;
					case 1u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0029;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1003064183;
							num4 = -1003064183;
						}
						else
						{
							num3 = -817913628;
							num4 = -817913628;
						}
						num = num3 ^ (int)(num2 * 867008552);
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 4u:
						return;
						IL_0029:
						flag = (byte)num5 != 0;
						num = 1734233098;
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
				int num = -534376582;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD554D67u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 324148542) ^ 0x1D984853);
						continue;
					case 1u:
						count = m_Dict.Count;
						num = ((int)num2 * -584490641) ^ -1535878822;
						continue;
					case 3u:
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
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 1264666918;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x454406C4u) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -2073496267) ^ -1114160465;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 1431180629) ^ 0x377618D5);
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
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = !JSONClass.smethod_30(aKey);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2141674759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59AD30E0u) % 12u)
				{
				case 11u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1905513398) ^ 0x1659D76;
					continue;
				case 10u:
					m_Dict.Add(aKey, aItem);
					num = 473436591;
					continue;
				case 9u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1341928948;
					continue;
				case 8u:
					num = ((int)num2 * -633598896) ^ -560083968;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 910656557;
						num6 = 910656557;
					}
					else
					{
						num5 = 1534264525;
						num6 = 1534264525;
					}
					num = num5 ^ ((int)num2 * -831463928);
					continue;
				}
				case 6u:
					num = (int)(num2 * 669814872) ^ -109293648;
					continue;
				case 5u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -741489758) ^ 0x3EE2D177;
					continue;
				case 4u:
					num = (int)((num2 * 1435883957) ^ 0xD0A7DA7);
					continue;
				case 3u:
					num = 994063898;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 1543209901;
						num4 = 1543209901;
					}
					else
					{
						num3 = 1791976668;
						num4 = 1791976668;
					}
					num = num3 ^ (int)(num2 * 1084670843);
					continue;
				}
				default:
					return;
				case 2u:
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
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -441993711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0E5E4F3u) % 8u)
				{
				case 6u:
					num = (int)(num2 * 1346481641) ^ -2003452758;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1043018950;
						num4 = -1043018950;
					}
					else
					{
						num3 = -1357715520;
						num4 = -1357715520;
					}
					num = num3 ^ (int)(num2 * 375736494);
					continue;
				}
				case 3u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = -1799860045;
					continue;
				case 2u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1484211304) ^ -2134973473;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -658079945) ^ -2105895637;
					continue;
				case 0u:
					result = jSONNode;
					num = (int)(num2 * 952222140) ^ -1698527691;
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

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1780445087;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x77DF763Bu) % 8u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 621103394;
						num5 = 621103394;
					}
					else
					{
						num4 = 1020023272;
						num5 = 1020023272;
					}
					num = num4 ^ (int)(num2 * 190159332);
					continue;
				}
				case 4u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 675774732) ^ -655651831;
						continue;
					}
					num3 = 1;
					goto IL_003e;
				case 3u:
					result = null;
					num = (int)((num2 * 1901555328) ^ 0xD135EA3);
					continue;
				case 2u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_003e;
				case 1u:
					result = null;
					num = 2096702046;
					continue;
				case 0u:
					num = ((int)num2 * -2044452701) ^ -737167850;
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_003e:
					flag = (byte)num3 != 0;
					num = 144858061;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1303496182;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A97AF9Eu) % 3u)
					{
					case 2u:
						goto IL_0004;
					case 0u:
						break;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
					IL_0004:
					result = null;
					num = ((int)num2 * -1164456801) ^ 0x35C5D46;
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
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CGetEnumerator_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string text = "{";
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -1465646413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8E5EAD9u) % 3u)
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
							IL_016d:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1460995233;
								num4 = -1460995233;
							}
							else
							{
								num3 = -2039053785;
								num4 = -2039053785;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC8E5EAD9u) % 9u)
								{
								case 8u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)((num2 * 1048150174) ^ 0x1A84E935);
									continue;
								case 6u:
									num3 = -2039053785;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1084971499;
										num6 = -1084971499;
									}
									else
									{
										num5 = -743335309;
										num6 = -743335309;
									}
									num3 = num5 ^ ((int)num2 * -931456094);
									continue;
								}
								case 4u:
									current = enumerator.Current;
									num3 = -786008653;
									continue;
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1060796800) ^ 0x6C4CA573;
									continue;
								case 2u:
									num3 = (int)((num2 * 160860258) ^ 0x178CBEF5);
									continue;
								case 1u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -722200111;
									continue;
								default:
									goto end_IL_0127;
								case 0u:
									break;
								case 7u:
									goto end_IL_0127;
								}
								goto IL_016d;
								continue;
								end_IL_0127:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num7 = -1355495543;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xC8E5EAD9u) % 3u)
							{
							case 2u:
								goto IL_019c;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019c:
							num7 = (int)((num2 * 1899244498) ^ 0x49851FE3);
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)((num2 * 1180311870) ^ 0x16AC2EF);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num = 647243891;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DE98BF0u) % 3u)
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
							IL_018e:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 396355283;
								num4 = 396355283;
							}
							else
							{
								num3 = 2114198522;
								num4 = 2114198522;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2DE98BF0u) % 9u)
								{
								case 8u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 1139621506;
									continue;
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -2008496207) ^ -1151520511;
									continue;
								case 5u:
									current = enumerator.Current;
									flag = JSONClass.smethod_31(text) > 3;
									num3 = 23809358;
									continue;
								case 4u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -1764621722) ^ -1895741755;
									continue;
								case 3u:
									num3 = 396355283;
									continue;
								case 2u:
									num3 = ((int)num2 * -456313978) ^ 0x20D02C07;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 2113276677;
										num6 = 2113276677;
									}
									else
									{
										num5 = 563420532;
										num6 = 563420532;
									}
									num3 = num5 ^ ((int)num2 * -449952942);
									continue;
								}
								default:
									goto end_IL_0148;
								case 0u:
									break;
								case 6u:
									goto end_IL_0148;
								}
								goto IL_018e;
								continue;
								end_IL_0148:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = 2114191540;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x2DE98BF0u) % 3u)
							{
							case 2u:
								goto IL_01c3;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01c3:
							num7 = (int)(num2 * 297727377) ^ -1129906602;
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -1916630619) ^ -1488569136;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -719976895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC155EA6Cu) % 5u)
				{
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -1803347079) ^ 0x10239FA5;
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1029647494) ^ -1590754902;
					continue;
				case 1u:
					num = (int)((num2 * 1332774969) ^ 0x2E9A4A31);
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
							num3 = -1021804183;
							num4 = -1021804183;
						}
						else
						{
							num3 = -1584915124;
							num4 = -1584915124;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xC155EA6Cu) % 8u)
							{
							case 7u:
								num3 = ((int)num2 * -1251200862) ^ -430298138;
								continue;
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -1387477743) ^ -980183879;
								continue;
							case 5u:
								current = enumerator.Current;
								num3 = -8705837;
								continue;
							case 4u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1476858718) ^ 0x561D4EA);
								continue;
							case 3u:
								num3 = ((int)num2 * -1129663743) ^ -1435474498;
								continue;
							case 2u:
								num3 = -1021804183;
								continue;
							default:
								return;
							case 1u:
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
