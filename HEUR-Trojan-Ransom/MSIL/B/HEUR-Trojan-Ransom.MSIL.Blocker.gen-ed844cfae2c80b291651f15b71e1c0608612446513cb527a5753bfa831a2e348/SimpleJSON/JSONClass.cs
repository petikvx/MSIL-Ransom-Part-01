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
				goto IL_000e;
			}
			goto IL_0050;
			IL_0050:
			JSONNode result = new JSONLazyCreator(this, aKey);
			int num = -1800022101;
			goto IL_002f;
			IL_002f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAB0C543u) % 4u)
				{
				case 2u:
					break;
				case 1u:
					result = m_Dict[aKey];
					num = ((int)num2 * -292266047) ^ 0x36B0B786;
					continue;
				case 3u:
					goto IL_0050;
				default:
					return result;
				}
				break;
			}
			goto IL_000e;
			IL_000e:
			num = -1203790290;
			goto IL_002f;
		}
		set
		{
			while (true)
			{
				int num = -513425994;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFBC8D031u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -699741246) ^ 0x5368BE91;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = -2030097993;
							num4 = -2030097993;
						}
						else
						{
							num3 = -818691539;
							num4 = -818691539;
						}
						num = num3 ^ ((int)num2 * -1011969400);
						continue;
					}
					case 2u:
						m_Dict.Add(aKey, value);
						num = -541349607;
						continue;
					case 1u:
						num = (int)((num2 * 1049629465) ^ 0xFA982D9);
						continue;
					case 0u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 1264473007) ^ 0x4C5952F5);
						continue;
					default:
						return;
					case 4u:
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
			if (aIndex >= 0)
			{
				goto IL_000a;
			}
			int num = 1;
			goto IL_00ad;
			IL_009c:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_00ad;
			IL_000a:
			int num2 = -1267876793;
			goto IL_006b;
			IL_006b:
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xCFAA7DEEu) % 8u)
				{
				case 7u:
					break;
				case 6u:
					num2 = (int)((num3 * 749038890) ^ 0x63E1D8D2);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1207555540;
						num5 = 1207555540;
					}
					else
					{
						num4 = 2103812322;
						num5 = 2103812322;
					}
					num2 = num4 ^ ((int)num3 * -938731056);
					continue;
				}
				case 4u:
					result = null;
					num2 = (int)(num3 * 1365064264) ^ -2091769667;
					continue;
				case 3u:
					num2 = ((int)num3 * -1922436621) ^ -128787497;
					continue;
				case 2u:
					result = null;
					num2 = -818094992;
					continue;
				case 1u:
					goto IL_009c;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_00ad:
			flag = (byte)num != 0;
			num2 = -192164357;
			goto IL_006b;
		}
		set
		{
			if (aIndex < 0)
			{
				goto IL_0007;
			}
			goto IL_0023;
			IL_0023:
			int num = 264097534;
			goto IL_0028;
			IL_0028:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68828AA8u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -1558683844) ^ 0x2433066B;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0049;
				case 3u:
					return;
				}
				break;
				IL_0049:
				if (aIndex < m_Dict.Count)
				{
					num = 380063575;
					num3 = 380063575;
					continue;
				}
				goto IL_0007;
			}
			goto IL_0023;
			IL_0007:
			num = 668989225;
			num3 = 668989225;
			goto IL_0028;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 784120629;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87861F6u) % 4u)
					{
					case 3u:
						count = m_Dict.Count;
						num = ((int)num2 * -114793815) ^ -1098044728;
						continue;
					case 1u:
						num = ((int)num2 * -1492882005) ^ -79910805;
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
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -348824991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE0A5EC5u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = (int)((num2 * 1440453130) ^ 0x71FE730F);
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1069260719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC98BD4E2u) % 11u)
				{
				case 10u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1274291785;
						num6 = -1274291785;
					}
					else
					{
						num5 = -1864220481;
						num6 = -1864220481;
					}
					num = num5 ^ ((int)num2 * -1620401842);
					continue;
				}
				case 9u:
				{
					int num3;
					int num4;
					if (JSONClass.smethod_30(aKey))
					{
						num3 = 1497264183;
						num4 = 1497264183;
					}
					else
					{
						num3 = 1348923587;
						num4 = 1348923587;
					}
					num = num3 ^ ((int)num2 * -1113701562);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1730430414) ^ -2021200449;
					continue;
				case 6u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -2099271345) ^ -947589456;
					continue;
				case 5u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1145058675;
					continue;
				case 4u:
					num = ((int)num2 * -650802300) ^ 0x642F09C3;
					continue;
				case 3u:
					num = -101224861;
					continue;
				case 1u:
					m_Dict.Add(aKey, aItem);
					num = -1955891497;
					continue;
				case 0u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 677319120) ^ -1229945928;
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

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 697241018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40F5BEBDu) % 7u)
				{
				case 6u:
					result = null;
					num = (int)((num2 * 396980344) ^ 0x5B240135);
					continue;
				case 5u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = 2136058549;
					continue;
				case 3u:
					result = jSONNode;
					num = (int)((num2 * 1910152488) ^ 0x3E978F7D);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = -1449009505;
						num4 = -1449009505;
					}
					else
					{
						num3 = -1043441392;
						num4 = -1043441392;
					}
					num = num3 ^ ((int)num2 * -329754254);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1487130147) ^ 0x4F735B95;
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

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_002e;
		}
		int num = 1;
		goto IL_009a;
		IL_0089:
		num = ((aIndex >= m_Dict.Count) ? 1 : 0);
		goto IL_009a;
		IL_002e:
		int num2 = -1655587719;
		goto IL_005c;
		IL_005c:
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xDC7BB71Eu) % 7u)
			{
			case 6u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1818868883;
					num5 = -1818868883;
				}
				else
				{
					num4 = -1516988635;
					num5 = -1516988635;
				}
				num2 = num4 ^ (int)(num3 * 1406150009);
				continue;
			}
			case 5u:
				break;
			case 4u:
				result = null;
				num2 = ((int)num3 * -735409488) ^ 0x302D76C2;
				continue;
			case 3u:
				num2 = (int)(num3 * 297332787) ^ -1464648627;
				continue;
			case 0u:
				result = null;
				num2 = -479828085;
				continue;
			case 2u:
				goto IL_0089;
			default:
				return result;
			}
			break;
		}
		goto IL_002e;
		IL_009a:
		flag = (byte)num != 0;
		num2 = -136239085;
		goto IL_005c;
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
		while (true)
		{
			int num = -1883073503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2655B84u) % 4u)
				{
				case 1u:
					text = "{";
					num = (int)(num2 * 1158679875) ^ -1228016505;
					continue;
				case 0u:
					num = ((int)num2 * -1181934480) ^ 0x4EBC0E83;
					continue;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0154:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1129790945;
								num4 = -1129790945;
							}
							else
							{
								num3 = -1431544756;
								num4 = -1431544756;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD2655B84u) % 7u)
								{
								case 6u:
									current = enumerator.Current;
									num3 = -1266459353;
									continue;
								case 5u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1267319963) ^ -764398633;
									continue;
								case 4u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -2039853249;
									continue;
								case 2u:
									num3 = -1129790945;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -1726899463;
										num6 = -1726899463;
									}
									else
									{
										num5 = -743106530;
										num6 = -743106530;
									}
									num3 = num5 ^ (int)(num2 * 1511960981);
									continue;
								}
								default:
									goto end_IL_0117;
								case 3u:
									break;
								case 1u:
									goto end_IL_0117;
								}
								goto IL_0154;
								continue;
								end_IL_0117:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num7 = -309533438;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xD2655B84u) % 3u)
							{
							case 2u:
								goto IL_0183;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0183:
							num7 = (int)((num2 * 813891865) ^ 0x63D9F1D5);
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
			int num = 1686324252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1577F6D3u) % 3u)
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
							IL_01a6:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1372491002;
								num4 = 1372491002;
							}
							else
							{
								num3 = 139676380;
								num4 = 139676380;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x1577F6D3u) % 10u)
								{
								case 9u:
									num3 = ((int)num2 * -191889794) ^ -1206800987;
									continue;
								case 7u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 3)
									{
										num5 = -293442075;
										num6 = -293442075;
									}
									else
									{
										num5 = -634799981;
										num6 = -634799981;
									}
									num3 = num5 ^ (int)(num2 * 919089706);
									continue;
								}
								case 6u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 209286963;
									continue;
								case 5u:
									num3 = 139676380;
									continue;
								case 4u:
									num3 = ((int)num2 * -1074696535) ^ -233263548;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = 1704105777;
									continue;
								case 2u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = (int)(num2 * 681049166) ^ -2140857622;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1749875610) ^ -832297943;
									continue;
								default:
									goto end_IL_015c;
								case 8u:
									break;
								case 1u:
									goto end_IL_015c;
								}
								goto IL_01a6;
								continue;
								end_IL_015c:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = 573130521;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x1577F6D3u) % 4u)
							{
							case 2u:
								result = text;
								num7 = ((int)num2 * -1933788050) ^ 0x4BD9546A;
								continue;
							case 1u:
								num7 = ((int)num2 * -1081396030) ^ 0x71659939;
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
				break;
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -576282346) ^ 0x60AD35F1;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 1551782473;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4951B479u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -74471402) ^ -1077609624;
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 1136953875) ^ -1690048647;
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -817844592) ^ -1602941122;
					continue;
				case 0u:
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
								num3 = 1600638851;
								num4 = 1600638851;
							}
							else
							{
								num3 = 268373170;
								num4 = 268373170;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4951B479u) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = 8445846;
									continue;
								case 7u:
									JSONClass.smethod_38(aWriter, current);
									num3 = (int)((num2 * 787481683) ^ 0x73D019FF);
									continue;
								case 6u:
									num3 = (int)(num2 * 6904707) ^ -2122297170;
									continue;
								case 5u:
									num3 = ((int)num2 * -1931431682) ^ 0xCE36DD7;
									continue;
								case 3u:
									m_Dict[current].Serialize(aWriter);
									num3 = (int)(num2 * 1522744278) ^ -2094118207;
									continue;
								case 2u:
									num3 = 1600638851;
									continue;
								case 1u:
									num3 = (int)(num2 * 993938506) ^ -2098005621;
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
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_019c:
							int num5 = 2034174556;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x4951B479u) % 3u)
								{
								case 1u:
									goto IL_0172;
								default:
									goto end_IL_017f;
								case 2u:
									break;
								case 0u:
									goto end_IL_017f;
								}
								goto IL_019c;
								IL_0172:
								num5 = (int)(num2 * 295452032) ^ -1243521388;
								continue;
								end_IL_017f:
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

	public JSONClass()
	{
		while (true)
		{
			int num = -344786693;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97F92F85u) % 3u)
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
				num = (int)((num2 * 336143164) ^ 0xE5FAEB1);
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
