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
				int num = 1400670316;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E895FA6u) % 8u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1698147009;
							num4 = -1698147009;
						}
						else
						{
							num3 = -2014201557;
							num4 = -2014201557;
						}
						num = num3 ^ (int)(num2 * 1207082710);
						continue;
					}
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = 1712646381;
						continue;
					case 4u:
						num = ((int)num2 * -1122340882) ^ 0x63291D61;
						continue;
					case 3u:
						num = ((int)num2 * -1792670705) ^ -116649332;
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1616153080) ^ -2143591992;
						continue;
					case 1u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1937251406) ^ -343062376;
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
			while (true)
			{
				int num = -1134265072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8B604236u) % 7u)
					{
					case 5u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 145505275) ^ 0x6FA902BC);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = 934144615;
							num4 = 934144615;
						}
						else
						{
							num3 = 527778975;
							num4 = 527778975;
						}
						num = num3 ^ (int)(num2 * 286253409);
						continue;
					}
					case 2u:
						num = (int)(num2 * 854731939) ^ -960849382;
						continue;
					case 1u:
						num = ((int)num2 * -735781633) ^ 0x56729016;
						continue;
					case 0u:
						m_Dict.Add(aKey, value);
						num = -133148079;
						continue;
					default:
						return;
					case 6u:
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
				int num = -1303695523;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x88079018u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 2058367859) ^ 0x2905275C);
						continue;
					case 6u:
						result = null;
						num = -1529996423;
						continue;
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 364388985) ^ 0x595C725D);
							continue;
						}
						num3 = 1;
						goto IL_0032;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 816275106;
							num5 = 816275106;
						}
						else
						{
							num4 = 1396104694;
							num5 = 1396104694;
						}
						num = num4 ^ ((int)num2 * -1537258759);
						continue;
					}
					case 2u:
						result = null;
						num = (int)((num2 * 321790292) ^ 0x7858BC57);
						continue;
					case 0u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0032;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0032:
						flag = (byte)num3 != 0;
						num = -1892164004;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -153851440;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xAC988B19u) % 5u)
					{
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 434169318) ^ 0x71A58941);
							continue;
						}
						goto IL_0019;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = -52960590;
							num3 = -52960590;
							continue;
						}
						goto IL_0019;
					case 1u:
						num = (int)((num2 * 727775271) ^ 0x329DE0EE);
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
						IL_0019:
						num = -1141464227;
						num3 = -1141464227;
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
				int num = 72194671;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x353A8A41u) % 3u)
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
					num = (int)(num2 * 1634777256) ^ -400573298;
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
		while (true)
		{
			int num = -761260173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x917815A0u) % 12u)
				{
				case 11u:
					m_Dict.Add(aKey, aItem);
					num = -1267991619;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1060099336;
						num6 = 1060099336;
					}
					else
					{
						num5 = 476332932;
						num6 = 476332932;
					}
					num = num5 ^ ((int)num2 * -1596548980);
					continue;
				}
				case 8u:
					num = -1352500710;
					continue;
				case 7u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)((num2 * 760518496) ^ 0xE37E381);
					continue;
				case 5u:
					num = ((int)num2 * -1225757490) ^ -264644074;
					continue;
				case 4u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1869612769;
					continue;
				case 3u:
					num = ((int)num2 * -1321155577) ^ -1297363165;
					continue;
				case 2u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 1941895605) ^ -1218658602;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 2087309514;
						num4 = 2087309514;
					}
					else
					{
						num3 = 164733547;
						num4 = 164733547;
					}
					num = num3 ^ ((int)num2 * -133205615);
					continue;
				}
				case 0u:
					num = (int)((num2 * 2109396334) ^ 0x7AD8EEF5);
					continue;
				default:
					return;
				case 6u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 991481019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62EBC539u) % 8u)
				{
				case 7u:
					jSONNode = m_Dict[aKey];
					num = 376154255;
					continue;
				case 6u:
					m_Dict.Remove(aKey);
					num = (int)((num2 * 909356209) ^ 0x30B8EF5B);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1172509484;
						num4 = -1172509484;
					}
					else
					{
						num3 = -889512160;
						num4 = -889512160;
					}
					num = num3 ^ (int)(num2 * 1207925398);
					continue;
				}
				case 4u:
					result = jSONNode;
					num = ((int)num2 * -1303905798) ^ 0x4B676458;
					continue;
				case 3u:
					result = null;
					num = (int)(num2 * 1967012247) ^ -181008875;
					continue;
				case 2u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -573150503) ^ 0x27B073AE;
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
			int num = -1195134994;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA4C489D6u) % 7u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -108294651) ^ -1558391201;
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -991751006) ^ -1874714004;
						continue;
					}
					goto IL_002d;
				case 3u:
					num = ((int)num2 * -909241953) ^ -668939588;
					continue;
				case 1u:
					result = null;
					num = -669295219;
					continue;
				case 0u:
					if (aIndex < m_Dict.Count)
					{
						num = -1543154115;
						num3 = -1543154115;
						continue;
					}
					goto IL_002d;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_002d:
					num = -618437832;
					num3 = -618437832;
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
				int num = 2050926049;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7039607Cu) % 3u)
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
					num = ((int)num2 * -955849832) ^ -236385368;
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
		string text = default(string);
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = 975910196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3069F9E2u) % 4u)
				{
				case 2u:
					text = "{";
					num = ((int)num2 * -710295488) ^ -1739216169;
					continue;
				case 1u:
					num = ((int)num2 * -370655782) ^ -1211275321;
					continue;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_016a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1840772465;
								num4 = 1840772465;
							}
							else
							{
								num3 = 2119593994;
								num4 = 2119593994;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3069F9E2u) % 8u)
								{
								case 7u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -942638877) ^ -614850018;
									continue;
								case 6u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 585520053) ^ -1536398040;
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
									num3 = 1872419567;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = 595137021;
									continue;
								case 2u:
									num3 = 1840772465;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1554107758;
										num6 = -1554107758;
									}
									else
									{
										num5 = -1359168016;
										num6 = -1359168016;
									}
									num3 = num5 ^ (int)(num2 * 1996352444);
									continue;
								}
								default:
									goto end_IL_0129;
								case 5u:
									break;
								case 0u:
									goto end_IL_0129;
								}
								goto IL_016a;
								continue;
								end_IL_0129:
								break;
							}
							break;
						}
					}
					return JSONClass.smethod_32(text, "}");
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
			int num = 442162427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AB9DC0Au) % 3u)
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
							IL_0171:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 169901429;
								num4 = 169901429;
							}
							else
							{
								num3 = 1923917659;
								num4 = 1923917659;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6AB9DC0Au) % 8u)
								{
								case 6u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 738587351;
									continue;
								case 5u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -1030003176) ^ 0x1CA63809;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 265569572) ^ 0x35750904);
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 3)
									{
										num5 = 199617956;
										num6 = 199617956;
									}
									else
									{
										num5 = 1012443342;
										num6 = 1012443342;
									}
									num3 = num5 ^ ((int)num2 * -1525350984);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = 1545408376;
									continue;
								case 0u:
									num3 = 1923917659;
									continue;
								default:
									goto end_IL_0130;
								case 3u:
									break;
								case 7u:
									goto end_IL_0130;
								}
								goto IL_0171;
								continue;
								end_IL_0130:
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
							IL_01bc:
							int num7 = 1901468942;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x6AB9DC0Au) % 3u)
								{
								case 1u:
									goto IL_0190;
								default:
									goto end_IL_019e;
								case 2u:
									break;
								case 0u:
									goto end_IL_019e;
								}
								goto IL_01bc;
								IL_0190:
								num7 = ((int)num2 * -189359220) ^ 0x37FAB88B;
								continue;
								end_IL_019e:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = 513241780;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x6AB9DC0Au) % 4u)
							{
							case 2u:
								result = text;
								num8 = (int)((num2 * 1878023164) ^ 0x73757957);
								continue;
							case 1u:
								num8 = ((int)num2 * -622381008) ^ -1050407238;
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
				num = ((int)num2 * -195649897) ^ -252240060;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -938004029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE575CC9u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1433704639) ^ -1786649837;
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 46908947) ^ -1991258444;
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
							num3 = -1047961160;
							num4 = -1047961160;
						}
						else
						{
							num3 = -1087354870;
							num4 = -1087354870;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xBE575CC9u) % 8u)
							{
							case 7u:
								num3 = (int)((num2 * 1644758838) ^ 0x48C1BDB7);
								continue;
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -232590586) ^ -1392294305;
								continue;
							case 5u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1760012339) ^ 0x7674EECE;
								continue;
							case 2u:
								num3 = ((int)num2 * -663061550) ^ -277881942;
								continue;
							case 1u:
								current = enumerator.Current;
								num3 = -727279980;
								continue;
							case 0u:
								num3 = -1047961160;
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
				break;
			}
		}
	}

	public JSONClass()
	{
		while (true)
		{
			int num = 1830048886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15812DF4u) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0013:
				num = (int)((num2 * 2128051251) ^ 0x5545E7F9);
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
