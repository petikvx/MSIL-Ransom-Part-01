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
				int num = 1538098066;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B2E0A99u) % 6u)
					{
					case 4u:
						num = ((int)num2 * -62998315) ^ -544124236;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = 1992733496;
							num4 = 1992733496;
						}
						else
						{
							num3 = 256251879;
							num4 = 256251879;
						}
						num = num3 ^ ((int)num2 * -418752231);
						continue;
					}
					case 2u:
						result = m_Dict[aKey];
						num = ((int)num2 * -2110623432) ^ 0x231713CC;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = 224886257;
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
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -742997746;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD41D4B0u) % 9u)
					{
					case 7u:
						num = (int)((num2 * 2127928438) ^ 0x69B2D4E0);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1065794534;
							num4 = -1065794534;
						}
						else
						{
							num3 = -1398533638;
							num4 = -1398533638;
						}
						num = num3 ^ (int)(num2 * 2141951060);
						continue;
					}
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1941562775) ^ -369543638;
						continue;
					case 3u:
						num = ((int)num2 * -157168945) ^ 0x10B6BCE;
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 795623732) ^ -1460462636;
						continue;
					case 1u:
						m_Dict.Add(aKey, value);
						num = -73870723;
						continue;
					case 0u:
						num = ((int)num2 * -1036101195) ^ 0x547DA49C;
						continue;
					default:
						return;
					case 8u:
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
				goto IL_0018;
			}
			int num = 1;
			goto IL_0084;
			IL_0073:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0084;
			IL_0018:
			int num2 = -94243898;
			goto IL_004a;
			IL_004a:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAB9CC581u) % 6u)
				{
				case 5u:
					result = null;
					num2 = (int)(num3 * 1907553079) ^ -1449494433;
					continue;
				case 4u:
					break;
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 293687594;
						num5 = 293687594;
					}
					else
					{
						num4 = 462909393;
						num5 = 462909393;
					}
					num2 = num4 ^ (int)(num3 * 817512194);
					continue;
				}
				case 0u:
					result = null;
					num2 = -181439582;
					continue;
				case 3u:
					goto IL_0073;
				default:
					return result;
				}
				break;
			}
			goto IL_0018;
			IL_0084:
			flag = (byte)num != 0;
			num2 = -1595571743;
			goto IL_004a;
		}
		set
		{
			while (true)
			{
				int num = -1421701379;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBDF4714Au) % 5u)
					{
					case 3u:
						num = ((int)num2 * -1543111450) ^ -331803507;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -594714652) ^ -1866146469;
							continue;
						}
						goto IL_0034;
					case 1u:
						if (aIndex < m_Dict.Count)
						{
							num = -1790018409;
							num3 = -1790018409;
							continue;
						}
						goto IL_0034;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
						IL_0034:
						num = -1384705483;
						num3 = -1384705483;
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
				int num = -1564159096;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1D00956u) % 3u)
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
					num = ((int)num2 * -337183482) ^ -1270696556;
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
				int num = 979179572;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x31A57556u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -324037538) ^ 0x90BE731;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 370594192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x566E26D3u) % 13u)
				{
				case 12u:
					num = ((int)num2 * -1443696115) ^ 0x63A6B288;
					continue;
				case 11u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1935490651;
					continue;
				case 10u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -1343913286) ^ 0x4AB7D4B0;
					continue;
				case 8u:
					num = ((int)num2 * -1859368880) ^ 0x2AC91A76;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -372130899;
						num6 = -372130899;
					}
					else
					{
						num5 = -388589082;
						num6 = -388589082;
					}
					num = num5 ^ ((int)num2 * -424915567);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1469247536) ^ 0x5AE74DAB;
					continue;
				case 5u:
					m_Dict.Add(aKey, aItem);
					num = 665553468;
					continue;
				case 4u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 2115897014) ^ -1885427119;
					continue;
				case 3u:
					num = 1935490651;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -1761103555;
						num4 = -1761103555;
					}
					else
					{
						num3 = -1698163960;
						num4 = -1698163960;
					}
					num = num3 ^ ((int)num2 * -1426341412);
					continue;
				}
				case 1u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1822956539) ^ 0x3981AAB8);
					continue;
				default:
					return;
				case 0u:
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
		while (true)
		{
			int num = -1184849261;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8276C0B0u) % 7u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -2145650901) ^ 0x6F96AB32;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = -1322916483;
						num4 = -1322916483;
					}
					else
					{
						num3 = -139534558;
						num4 = -139534558;
					}
					num = num3 ^ (int)(num2 * 2013527272);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1185781654) ^ 0x1D9A23B9;
					continue;
				case 3u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = -1241982245;
					continue;
				}
				case 1u:
					num = (int)((num2 * 1157279155) ^ 0xF59E828);
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -962864868;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xDEA15CA9u) % 7u)
				{
				case 6u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 701735411) ^ 0x15FC0739);
						continue;
					}
					goto IL_0028;
				case 4u:
					num = ((int)num2 * -2096189856) ^ 0x4274924;
					continue;
				case 2u:
					if (aIndex < m_Dict.Count)
					{
						num = -962278011;
						num3 = -962278011;
						continue;
					}
					goto IL_0028;
				case 1u:
					result = null;
					num = ((int)num2 * -2112181239) ^ -743884705;
					continue;
				case 0u:
					result = null;
					num = -133047985;
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0028:
					num = -163702134;
					num3 = -163702134;
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
		string text = "{";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -700882204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF993608Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0167:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1700600;
								num4 = -1700600;
							}
							else
							{
								num3 = -212247985;
								num4 = -212247985;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF993608Eu) % 9u)
								{
								case 8u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -978233682;
									continue;
								case 7u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1072084264;
										num6 = -1072084264;
									}
									else
									{
										num5 = -118437160;
										num6 = -118437160;
									}
									num3 = num5 ^ (int)(num2 * 1902345603);
									continue;
								}
								case 6u:
									num3 = (int)((num2 * 1627497039) ^ 0x466B747F);
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = -322039893;
									continue;
								case 3u:
									num3 = -212247985;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 146165470) ^ 0x1317E15B);
									continue;
								case 1u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -1213062425) ^ -1577435338;
									continue;
								default:
									goto end_IL_0121;
								case 5u:
									break;
								case 0u:
									goto end_IL_0121;
								}
								goto IL_0167;
								continue;
								end_IL_0121:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = -723174467;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xF993608Eu) % 3u)
							{
							case 2u:
								goto IL_0193;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0193:
							result = text;
							num7 = ((int)num2 * -1864428291) ^ -1158518875;
						}
					}
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -1049953684) ^ -1287111578;
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
			int num = -1964665254;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5CEB755u) % 4u)
				{
				case 3u:
					text = "{ ";
					num = ((int)num2 * -1650759201) ^ 0x541C90F2;
					continue;
				case 2u:
					num = (int)(num2 * 638194750) ^ -2091576316;
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
							IL_01b7:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -2115843132;
								num4 = -2115843132;
							}
							else
							{
								num3 = -1953143562;
								num4 = -1953143562;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF5CEB755u) % 10u)
								{
								case 9u:
									current = enumerator.Current;
									num3 = -1483546731;
									continue;
								case 8u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 3)
									{
										num5 = -600321332;
										num6 = -600321332;
									}
									else
									{
										num5 = -405713873;
										num6 = -405713873;
									}
									num3 = num5 ^ (int)(num2 * 2113444206);
									continue;
								}
								case 7u:
									num3 = -2115843132;
									continue;
								case 5u:
									num3 = (int)(num2 * 1149585176) ^ -446109205;
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
									num3 = (int)((num2 * 776057815) ^ 0x727CB3E);
									continue;
								case 3u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -1193344733;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 659231255) ^ -413224646;
									continue;
								case 0u:
									num3 = ((int)num2 * -2120836412) ^ 0x63260367;
									continue;
								default:
									goto end_IL_016d;
								case 6u:
									break;
								case 1u:
									goto end_IL_016d;
								}
								goto IL_01b7;
								continue;
								end_IL_016d:
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
							IL_0202:
							int num7 = -1441825611;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xF5CEB755u) % 3u)
								{
								case 1u:
									goto IL_01d6;
								default:
									goto end_IL_01e4;
								case 2u:
									break;
								case 0u:
									goto end_IL_01e4;
								}
								goto IL_0202;
								IL_01d6:
								num7 = (int)((num2 * 2140491183) ^ 0x680EE7CD);
								continue;
								end_IL_01e4:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = -1216719301;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xF5CEB755u) % 4u)
							{
							case 2u:
								result = text;
								num8 = ((int)num2 * -1499945259) ^ 0x5D7F3446;
								continue;
							case 1u:
								num8 = ((int)num2 * -208646640) ^ -1504354679;
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
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = 55004229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0285EEu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 165925616) ^ 0x4CBBE70);
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -813750891) ^ -673560707;
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
							if (!enumerator.MoveNext())
							{
								num3 = 553760242;
								num4 = 553760242;
							}
							else
							{
								num3 = 883606807;
								num4 = 883606807;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC0285EEu) % 7u)
								{
								case 4u:
									JSONClass.smethod_38(aWriter, current);
									num3 = (int)(num2 * 751976691) ^ -684634189;
									continue;
								case 3u:
									num3 = ((int)num2 * -1814648804) ^ 0x6FBDEE60;
									continue;
								case 2u:
									m_Dict[current].Serialize(aWriter);
									num3 = (int)((num2 * 1370089194) ^ 0x23BF9AC9);
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 1073832806;
									continue;
								case 0u:
									num3 = 883606807;
									continue;
								default:
									return;
								case 6u:
									break;
								case 5u:
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
							IL_0161:
							int num5 = 1448207006;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xC0285EEu) % 3u)
								{
								case 1u:
									goto IL_0137;
								default:
									goto end_IL_0144;
								case 0u:
									break;
								case 2u:
									goto end_IL_0144;
								}
								goto IL_0161;
								IL_0137:
								num5 = (int)(num2 * 920840094) ^ -1796318397;
								continue;
								end_IL_0144:
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
