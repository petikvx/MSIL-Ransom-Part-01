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
				int num = 317484055;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E62227Fu) % 7u)
					{
					case 6u:
						num = (int)(num2 * 274948519) ^ -494738144;
						continue;
					case 5u:
						result = m_Dict[aKey];
						num = ((int)num2 * -501871377) ^ -1644270836;
						continue;
					case 4u:
						result = new JSONLazyCreator(this, aKey);
						num = 297113952;
						continue;
					case 3u:
						num = (int)((num2 * 1057387849) ^ 0x1BEA7E22);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = 1277237935;
							num4 = 1277237935;
						}
						else
						{
							num3 = 2077760240;
							num4 = 2077760240;
						}
						num = num3 ^ (int)(num2 * 1602559132);
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
		set
		{
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_003b;
			}
			goto IL_008b;
			IL_008b:
			m_Dict.Add(aKey, value);
			int num = -200461969;
			goto IL_005e;
			IL_005e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7E3F81Fu) % 7u)
				{
				case 6u:
					m_Dict[aKey] = value;
					num = (int)((num2 * 937180226) ^ 0x6DE54D71);
					continue;
				case 4u:
					num = ((int)num2 * -1897438977) ^ -640637142;
					continue;
				case 3u:
					break;
				case 1u:
					num = ((int)num2 * -1727447927) ^ 0x3C3098A6;
					continue;
				case 0u:
					num = (int)((num2 * 548650207) ^ 0x4B1EAF73);
					continue;
				default:
					return;
				case 2u:
					goto IL_008b;
				case 5u:
					return;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = -1075176745;
			goto IL_005e;
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
				int num = 1818089835;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x35808909u) % 9u)
					{
					case 6u:
						result = null;
						num = (int)((num2 * 276795441) ^ 0x2B2D705F);
						continue;
					case 5u:
						num = (int)((num2 * 1526040698) ^ 0x5C6CBCC);
						continue;
					case 4u:
						result = null;
						num = 264903361;
						continue;
					case 3u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0040;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 2053605544) ^ -1504666870;
							continue;
						}
						num5 = 1;
						goto IL_0040;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 384600715;
							num4 = 384600715;
						}
						else
						{
							num3 = 464156951;
							num4 = 464156951;
						}
						num = num3 ^ (int)(num2 * 251348515);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1174714315) ^ -1137068116;
						continue;
					case 7u:
						break;
					default:
						{
							return result;
						}
						IL_0040:
						flag = (byte)num5 != 0;
						num = 1863469569;
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
				int num = 1786672753;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x26E4F269u) % 5u)
					{
					case 3u:
						num = ((int)num2 * -158461035) ^ 0x6EE58A29;
						continue;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = 1219465199;
							num3 = 1219465199;
							continue;
						}
						goto IL_0025;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 2070701086) ^ -1233584210;
							continue;
						}
						goto IL_0025;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
						IL_0025:
						num = 1499254599;
						num3 = 1499254599;
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
				int num = 1865838926;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x34DDDF06u) % 3u)
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
					num = ((int)num2 * -1671923999) ^ 0x5C34CDF8;
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
				int num = -1003121762;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C3C1164u) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1707566380) ^ -2078314447;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1983312745) ^ -195196308;
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
		while (true)
		{
			int num = 1248684286;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7F96DBDCu) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 2048146589;
						num6 = 2048146589;
					}
					else
					{
						num5 = 1671313515;
						num6 = 1671313515;
					}
					num = num5 ^ ((int)num2 * -321898426);
					continue;
				}
				case 10u:
				{
					int num3;
					int num4;
					if (!JSONClass.smethod_30(aKey))
					{
						num3 = 345342462;
						num4 = 345342462;
					}
					else
					{
						num3 = 1869193900;
						num4 = 1869193900;
					}
					num = num3 ^ (int)(num2 * 2071378320);
					continue;
				}
				case 9u:
					num = (int)(num2 * 1997110357) ^ -1608247875;
					continue;
				case 7u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1399835354) ^ 0x6E96A157;
					continue;
				case 5u:
					num = (int)((num2 * 1887416546) ^ 0x7F48C5D8);
					continue;
				case 4u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 582743474;
					continue;
				case 3u:
					flag = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -523972682) ^ -162709659;
					continue;
				case 2u:
					num = (int)((num2 * 1285979544) ^ 0x33BA9573);
					continue;
				case 1u:
					m_Dict.Add(aKey, aItem);
					num = 1424168176;
					continue;
				case 0u:
					num = 740943321;
					continue;
				default:
					return;
				case 8u:
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
		if (!m_Dict.ContainsKey(aKey))
		{
			goto IL_0044;
		}
		goto IL_0072;
		IL_0072:
		JSONNode jSONNode = m_Dict[aKey];
		m_Dict.Remove(aKey);
		int num = 1768744686;
		goto IL_0049;
		IL_0049:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x231FE7D7u) % 6u)
			{
			case 5u:
				num = ((int)num2 * -1340515124) ^ -1908724207;
				continue;
			case 3u:
				result = null;
				num = (int)(num2 * 1240148042) ^ -288039396;
				continue;
			case 1u:
				result = jSONNode;
				num = ((int)num2 * -2084490767) ^ 0xE51A304;
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0072;
			default:
				return result;
			}
			break;
		}
		goto IL_0044;
		IL_0044:
		num = 2093972628;
		goto IL_0049;
	}

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -611149636;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x823A609Cu) % 9u)
				{
				case 8u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0017;
				case 7u:
					num = (int)((num2 * 869970393) ^ 0x2491FE89);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1690383656;
						num5 = -1690383656;
					}
					else
					{
						num4 = -695507942;
						num5 = -695507942;
					}
					num = num4 ^ (int)(num2 * 2132628347);
					continue;
				}
				case 4u:
					result = null;
					num = -2064374964;
					continue;
				case 3u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 2110145313) ^ -594170322;
						continue;
					}
					num3 = 1;
					goto IL_0017;
				case 1u:
					num = ((int)num2 * -1051997571) ^ 0x2CB8EA02;
					continue;
				case 0u:
					result = null;
					num = (int)(num2 * 1263448376) ^ -1102975309;
					continue;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num3 != 0;
					num = -245282971;
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
		//IL_0066: Incompatible stack heights: 0 vs 1
		//IL_006d: Incompatible stack heights: 0 vs 1
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 528100654;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B71C597u) % 3u)
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
					num = ((int)num2 * -937562227) ^ 0x561BD89B;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 301106228;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x5B71C597;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = (num2 * 2058435979) ^ 0xCB781EA8u;
						continue;
					case 2:
						break;
					default:
						return null;
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
		string text = "{";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0123:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 274416814;
					num2 = 274416814;
				}
				else
				{
					num = 1977094466;
					num2 = 1977094466;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x6FF1DCB2u) % 8u)
					{
					case 7u:
						num = 274416814;
						continue;
					case 6u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1159625295) ^ 0x4ED60CA5;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -2039595748;
							num5 = -2039595748;
						}
						else
						{
							num4 = -1143327253;
							num5 = -1143327253;
						}
						num = num4 ^ (int)(num3 * 2137163384);
						continue;
					}
					case 4u:
						current = enumerator.Current;
						flag = JSONClass.smethod_31(text) > 2;
						num = 653546775;
						continue;
					case 2u:
						num = (int)((num3 * 932099229) ^ 0x2D2B03AB);
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
						num = 754057096;
						continue;
					default:
						goto end_IL_00e2;
					case 3u:
						break;
					case 0u:
						goto end_IL_00e2;
					}
					goto IL_0123;
					continue;
					end_IL_00e2:
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
				IL_016e:
				int num6 = 897975521;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x6FF1DCB2u) % 3u)
					{
					case 1u:
						goto IL_0142;
					default:
						goto end_IL_0150;
					case 2u:
						break;
					case 0u:
						goto end_IL_0150;
					}
					goto IL_016e;
					IL_0142:
					num6 = (int)((num3 * 1835154441) ^ 0x180ACFCA);
					continue;
					end_IL_0150:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num7 = 542591151;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x6FF1DCB2u) % 4u)
				{
				case 1u:
					result = text;
					num7 = (int)(num3 * 315945856) ^ -1069891086;
					continue;
				case 0u:
					num7 = ((int)num3 * -272907618) ^ -576632984;
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

	public override string ToString(string aPrefix)
	{
		bool flag = default(bool);
		string text = default(string);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -1835132839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8266CB30u) % 3u)
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
							IL_01a8:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -859782673;
								num4 = -859782673;
							}
							else
							{
								num3 = -1688209965;
								num4 = -1688209965;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8266CB30u) % 10u)
								{
								case 9u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -718598223) ^ -46156677;
									continue;
								case 8u:
									num3 = ((int)num2 * -2046261064) ^ -543368539;
									continue;
								case 7u:
									current = enumerator.Current;
									num3 = -1050749590;
									continue;
								case 6u:
									num3 = -859782673;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1804114655;
										num6 = 1804114655;
									}
									else
									{
										num5 = 2097635748;
										num6 = 2097635748;
									}
									num3 = num5 ^ ((int)num2 * -1527006223);
									continue;
								}
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1020565110) ^ -39444112;
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
									num3 = ((int)num2 * -200021976) ^ -1790399945;
									continue;
								case 0u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -1216102148;
									continue;
								default:
									goto end_IL_015e;
								case 5u:
									break;
								case 1u:
									goto end_IL_015e;
								}
								goto IL_01a8;
								continue;
								end_IL_015e:
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
							IL_01f3:
							int num7 = -1604003018;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x8266CB30u) % 3u)
								{
								case 1u:
									goto IL_01c7;
								default:
									goto end_IL_01d5;
								case 0u:
									break;
								case 2u:
									goto end_IL_01d5;
								}
								goto IL_01f3;
								IL_01c7:
								num7 = ((int)num2 * -2048324031) ^ -1908441001;
								continue;
								end_IL_01d5:
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
				num = ((int)num2 * -84649305) ^ 0x321A80E3;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 1990566340;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EC4E942u) % 5u)
				{
				case 2u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -1310696560) ^ 0x34D33514;
					continue;
				case 1u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 1999179626) ^ 0xAB05210);
					continue;
				case 0u:
					num = ((int)num2 * -956488509) ^ -991358995;
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
							num3 = 947728571;
							num4 = 947728571;
						}
						else
						{
							num3 = 700047961;
							num4 = 700047961;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x6EC4E942u) % 9u)
							{
							case 8u:
								num3 = ((int)num2 * -1635874969) ^ -1593633739;
								continue;
							case 7u:
								num3 = (int)((num2 * 877031113) ^ 0x717E2045);
								continue;
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 800059730) ^ 0x2FC62F8C);
								continue;
							case 5u:
								current = enumerator.Current;
								num3 = 1581254533;
								continue;
							case 4u:
								num3 = (int)(num2 * 1476522618) ^ -462825538;
								continue;
							case 3u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1394422667) ^ -993783008;
								continue;
							case 2u:
								num3 = 947728571;
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

	public JSONClass()
	{
		while (true)
		{
			int num = -1392159260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2550AB8u) % 3u)
				{
				case 2u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0013:
				num = ((int)num2 * -422884495) ^ 0x62774ACA;
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
