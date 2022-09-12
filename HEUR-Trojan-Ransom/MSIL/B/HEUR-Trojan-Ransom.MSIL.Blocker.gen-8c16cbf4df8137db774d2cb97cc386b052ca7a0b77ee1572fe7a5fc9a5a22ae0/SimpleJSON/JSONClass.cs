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
				int num = -1725398112;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD45A10BAu) % 6u)
					{
					case 5u:
						result = m_Dict[aKey];
						num = ((int)num2 * -263112265) ^ 0x23017D80;
						continue;
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -2137403831) ^ -172219764;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1516981229;
							num4 = 1516981229;
						}
						else
						{
							num3 = 406599671;
							num4 = 406599671;
						}
						num = num3 ^ (int)(num2 * 1937589319);
						continue;
					}
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = -1341236433;
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
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_002c;
			}
			goto IL_0065;
			IL_0065:
			m_Dict.Add(aKey, value);
			int num = 1669741474;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25080425u) % 5u)
				{
				case 4u:
					m_Dict[aKey] = value;
					num = ((int)num2 * -438095432) ^ -872552943;
					continue;
				case 2u:
					break;
				case 0u:
					num = (int)((num2 * 1469519369) ^ 0x5E482A36);
					continue;
				default:
					return;
				case 3u:
					goto IL_0065;
				case 1u:
					return;
				}
				break;
			}
			goto IL_002c;
			IL_002c:
			num = 1657317568;
			goto IL_0040;
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
				int num = -994576342;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xD49FBE9Au) % 9u)
					{
					case 8u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0017;
					case 7u:
						num = (int)((num2 * 857229081) ^ 0x92B17DC);
						continue;
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 447538649) ^ -210255056;
							continue;
						}
						num5 = 1;
						goto IL_0017;
					case 3u:
						result = null;
						num = (int)(num2 * 1704087834) ^ -1017617781;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1025356151;
							num4 = 1025356151;
						}
						else
						{
							num3 = 1700534599;
							num4 = 1700534599;
						}
						num = num3 ^ (int)(num2 * 443163168);
						continue;
					}
					case 1u:
						num = (int)(num2 * 438770257) ^ -1478680892;
						continue;
					case 0u:
						result = null;
						num = -1355497767;
						continue;
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num5 != 0;
						num = -172179916;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			if (aIndex < 0)
			{
				goto IL_0007;
			}
			goto IL_0023;
			IL_0023:
			int num = -1060651194;
			goto IL_0028;
			IL_0028:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB6A37FBBu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 904388112) ^ -995943493;
					continue;
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0049;
				case 0u:
					return;
				}
				break;
				IL_0049:
				if (aIndex < m_Dict.Count)
				{
					num = -110086709;
					num3 = -110086709;
					continue;
				}
				goto IL_0007;
			}
			goto IL_0023;
			IL_0007:
			num = -477559172;
			num3 = -477559172;
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
				int num = -226833771;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9388962u) % 4u)
					{
					case 3u:
						count = m_Dict.Count;
						num = ((int)num2 * -1800757973) ^ 0x112FE072;
						continue;
					case 1u:
						num = ((int)num2 * -508522739) ^ 0x4466B625;
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
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
			int num = -634148113;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85B164B5u) % 13u)
				{
				case 12u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 714907340;
						num6 = 714907340;
					}
					else
					{
						num5 = 2055173684;
						num6 = 2055173684;
					}
					num = num5 ^ (int)(num2 * 1770529942);
					continue;
				}
				case 11u:
				{
					int num3;
					int num4;
					if (!JSONClass.smethod_30(aKey))
					{
						num3 = 92140490;
						num4 = 92140490;
					}
					else
					{
						num3 = 1822931755;
						num4 = 1822931755;
					}
					num = num3 ^ (int)(num2 * 417913579);
					continue;
				}
				case 9u:
					num = -1967021918;
					continue;
				case 8u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -490083244;
					continue;
				case 6u:
					num = ((int)num2 * -484762608) ^ -624900707;
					continue;
				case 5u:
					num = (int)((num2 * 370405612) ^ 0x782B1266);
					continue;
				case 4u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1847587625) ^ 0x2D373845);
					continue;
				case 3u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -2089820244) ^ 0x7D942FB2;
					continue;
				case 2u:
					num = ((int)num2 * -1508582175) ^ 0x3F7F0E6C;
					continue;
				case 1u:
					num = ((int)num2 * -327238215) ^ 0x8CC0774;
					continue;
				case 0u:
					m_Dict.Add(aKey, aItem);
					num = -117174081;
					continue;
				default:
					return;
				case 10u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -2017889929;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDFBF6F4u) % 8u)
				{
				case 6u:
					result = jSONNode;
					num = (int)((num2 * 1266662812) ^ 0x66FF5C38);
					continue;
				case 5u:
					num = ((int)num2 * -1074024703) ^ 0x1538CD15;
					continue;
				case 3u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1532730753) ^ -651815181;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1408295969;
						num4 = 1408295969;
					}
					else
					{
						num3 = 1561920168;
						num4 = 1561920168;
					}
					num = num3 ^ (int)(num2 * 1522748226);
					continue;
				}
				case 1u:
					result = null;
					num = ((int)num2 * -1925281207) ^ 0x68EC1458;
					continue;
				case 0u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = -665599774;
					continue;
				case 7u:
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1543651042;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFEF5AEB3u) % 8u)
				{
				case 6u:
					result = null;
					num = -1986147783;
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -836563881) ^ -349174648;
						continue;
					}
					num3 = 1;
					goto IL_0023;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1361967603;
						num5 = -1361967603;
					}
					else
					{
						num4 = -1094285766;
						num5 = -1094285766;
					}
					num = num4 ^ (int)(num2 * 867290632);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1243043084) ^ -309833403;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -1691081893) ^ -894086869;
					continue;
				case 0u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0023;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_0023:
					flag = (byte)num3 != 0;
					num = -1805704529;
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
		string text = default(string);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = 481830432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FBFCBE1u) % 4u)
				{
				case 1u:
					text = "{";
					num = ((int)num2 * -151374006) ^ 0x57B7A3CB;
					continue;
				case 0u:
					num = (int)(num2 * 382110942) ^ -511265802;
					continue;
				case 2u:
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
							if (enumerator.MoveNext())
							{
								num3 = 1666133622;
								num4 = 1666133622;
							}
							else
							{
								num3 = 1153530860;
								num4 = 1153530860;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4FBFCBE1u) % 8u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = 2060672649;
									continue;
								case 6u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -172966551) ^ -374576693;
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
									num3 = 1055434704;
									continue;
								case 3u:
									num3 = 1666133622;
									continue;
								case 1u:
									num3 = (int)(num2 * 590781971) ^ -1560877656;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = 400192175;
										num6 = 400192175;
									}
									else
									{
										num5 = 1909128277;
										num6 = 1909128277;
									}
									num3 = num5 ^ (int)(num2 * 615276234);
									continue;
								}
								default:
									goto end_IL_012a;
								case 2u:
									break;
								case 5u:
									goto end_IL_012a;
								}
								goto IL_016b;
								continue;
								end_IL_012a:
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
		while (true)
		{
			int num = 1372427650;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE22FBDBu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1142088916) ^ -2065225780;
					continue;
				case 1u:
					text = "{ ";
					num = (int)((num2 * 1812271105) ^ 0x6AA634B0);
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
							IL_0174:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1263560580;
								num4 = 1263560580;
							}
							else
							{
								num3 = 799528903;
								num4 = 799528903;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE22FBDBu) % 7u)
								{
								case 6u:
								{
									current = enumerator.Current;
									int num5;
									if (JSONClass.smethod_31(text) > 3)
									{
										num3 = 1110785215;
										num5 = 1110785215;
									}
									else
									{
										num3 = 1119525294;
										num5 = 1119525294;
									}
									continue;
								}
								case 5u:
									num3 = 799528903;
									continue;
								case 4u:
									num3 = (int)(num2 * 333321295) ^ -1939861370;
									continue;
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1009613826) ^ 0x24129896;
									continue;
								case 0u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = 275128912;
									continue;
								default:
									goto end_IL_0137;
								case 2u:
									break;
								case 1u:
									goto end_IL_0137;
								}
								goto IL_0174;
								continue;
								end_IL_0137:
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
							IL_01bf:
							int num6 = 1647164038;
							while (true)
							{
								switch ((num2 = (uint)num6 ^ 0xE22FBDBu) % 3u)
								{
								case 2u:
									goto IL_0193;
								default:
									goto end_IL_01a1;
								case 0u:
									break;
								case 1u:
									goto end_IL_01a1;
								}
								goto IL_01bf;
								IL_0193:
								num6 = (int)(num2 * 1654579727) ^ -1509292058;
								continue;
								end_IL_01a1:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = 1567132559;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xE22FBDBu) % 3u)
							{
							case 2u:
								goto IL_01de;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01de:
							num7 = ((int)num2 * -2016824446) ^ -302584421;
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
			int num = -168065580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8007D73u) % 6u)
				{
				case 5u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -1221724838) ^ 0x4E47930;
					continue;
				case 2u:
					num = (int)(num2 * 1680466042) ^ -881247555;
					continue;
				case 1u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 1607268427) ^ 0x7ABA8B64);
					continue;
				case 0u:
					num = ((int)num2 * -1665330555) ^ 0x1D111C30;
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
							num3 = -1294146619;
							num4 = -1294146619;
						}
						else
						{
							num3 = -143762406;
							num4 = -143762406;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xE8007D73u) % 6u)
							{
							case 5u:
								num3 = -1294146619;
								continue;
							case 2u:
								current = enumerator.Current;
								num3 = -923496010;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)(num2 * 1655637452) ^ -1683309441;
								continue;
							case 0u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -412070912) ^ -133869473;
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
			int num = 1957124260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1FCD25D0u) % 3u)
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
				num = ((int)num2 * -1924930339) ^ 0x50915A74;
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
