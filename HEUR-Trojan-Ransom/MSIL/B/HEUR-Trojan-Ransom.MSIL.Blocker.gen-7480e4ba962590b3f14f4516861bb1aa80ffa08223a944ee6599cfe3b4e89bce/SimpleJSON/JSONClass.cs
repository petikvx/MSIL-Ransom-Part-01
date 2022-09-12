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
				int num = 1174131717;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6DFF128Cu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1974754766;
							num4 = 1974754766;
						}
						else
						{
							num3 = 1812330679;
							num4 = 1812330679;
						}
						num = num3 ^ ((int)num2 * -629020381);
						continue;
					}
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1200890551) ^ -2116992618;
						continue;
					case 2u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1672419383) ^ 0x75E38939;
						continue;
					case 1u:
						num = (int)((num2 * 1856232735) ^ 0x2AC3E231);
						continue;
					case 0u:
						result = new JSONLazyCreator(this, aKey);
						num = 274245136;
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = -1113250013;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5807856u) % 6u)
					{
					case 5u:
						m_Dict.Add(aKey, value);
						num = -290401701;
						continue;
					case 4u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -336387483) ^ -1199954938;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1988681405;
							num4 = -1988681405;
						}
						else
						{
							num3 = -2103133864;
							num4 = -2103133864;
						}
						num = num3 ^ ((int)num2 * -122155899);
						continue;
					}
					case 2u:
						num = ((int)num2 * -524150609) ^ -1322353409;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
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
				goto IL_002a;
			}
			int num = 1;
			goto IL_00ad;
			IL_009c:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_00ad;
			IL_002a:
			int num2 = -1877752995;
			goto IL_006b;
			IL_006b:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAF711216u) % 8u)
				{
				case 6u:
					result = null;
					num2 = ((int)num3 * -1924286597) ^ 0x257A7D2E;
					continue;
				case 5u:
					num2 = (int)((num3 * 320713947) ^ 0x46A91F56);
					continue;
				case 4u:
					break;
				case 2u:
					num2 = (int)((num3 * 874627424) ^ 0x1A4C2791);
					continue;
				case 1u:
					result = null;
					num2 = -851255469;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1724666559;
						num5 = 1724666559;
					}
					else
					{
						num4 = 1483910824;
						num5 = 1483910824;
					}
					num2 = num4 ^ ((int)num3 * -1842932489);
					continue;
				}
				case 3u:
					goto IL_009c;
				default:
					return result;
				}
				break;
			}
			goto IL_002a;
			IL_00ad:
			flag = (byte)num != 0;
			num2 = -1465171930;
			goto IL_006b;
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
			int num2 = 900859038;
			goto IL_003f;
			IL_003a:
			num2 = 80231403;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1CBB2F35u) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 975279779;
						num5 = 975279779;
					}
					else
					{
						num4 = 1199532442;
						num5 = 1199532442;
					}
					num2 = num4 ^ (int)(num3 * 742285774);
					continue;
				}
				case 3u:
					num2 = ((int)num3 * -688693459) ^ -2118826468;
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0064;
				case 2u:
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

	public override int Count => m_Dict.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -308153794;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x86CB303Bu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -1950099596) ^ 0x4AD9C08E;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -423347465;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92BBCB3Bu) % 14u)
				{
				case 13u:
					num = (int)((num2 * 262558801) ^ 0x78ADA0E7);
					continue;
				case 12u:
					flag = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -192898979) ^ 0x32443764;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -1805493561;
						num6 = -1805493561;
					}
					else
					{
						num5 = -967145756;
						num6 = -967145756;
					}
					num = num5 ^ (int)(num2 * 47822852);
					continue;
				}
				case 10u:
					m_Dict.Add(aKey, aItem);
					num = -1256500780;
					continue;
				case 9u:
					num = (int)((num2 * 890623246) ^ 0x1699B43F);
					continue;
				case 8u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -207204514;
					continue;
				case 7u:
					num = (int)(num2 * 1165053473) ^ -1329045989;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (m_Dict.ContainsKey(aKey))
					{
						num3 = 1746903103;
						num4 = 1746903103;
					}
					else
					{
						num3 = 457586131;
						num4 = 457586131;
					}
					num = num3 ^ ((int)num2 * -82585848);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1217017061) ^ 0x13E290AE);
					continue;
				case 2u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1308445186) ^ 0x5F605184;
					continue;
				case 1u:
					num = ((int)num2 * -1025614033) ^ -1685629506;
					continue;
				case 0u:
					num = -1670280930;
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 166123039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x200FFE81u) % 10u)
				{
				case 9u:
					jSONNode = m_Dict[aKey];
					num = 562521809;
					continue;
				case 6u:
					num = (int)(num2 * 1478029971) ^ -1582432330;
					continue;
				case 5u:
					result = null;
					num = ((int)num2 * -353296814) ^ 0x17A73603;
					continue;
				case 4u:
					m_Dict.Remove(aKey);
					num = (int)(num2 * 1327946781) ^ -1042697402;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1601991683;
						num4 = -1601991683;
					}
					else
					{
						num3 = -1593725333;
						num4 = -1593725333;
					}
					num = num3 ^ (int)(num2 * 249574645);
					continue;
				}
				case 2u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1210171973) ^ -1797339466;
					continue;
				case 1u:
					result = jSONNode;
					num = (int)(num2 * 692253993) ^ -591752500;
					continue;
				case 0u:
					num = ((int)num2 * -1885150560) ^ -1165071182;
					continue;
				case 8u:
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
			int num = -1494747402;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xC0E7D6E4u) % 7u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -96322346) ^ -1866453511;
					continue;
				case 4u:
					num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0028;
				case 3u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -973801997) ^ -1124735562;
						continue;
					}
					num5 = 1;
					goto IL_0028;
				case 2u:
					result = null;
					num = -290279489;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1338427379;
						num4 = 1338427379;
					}
					else
					{
						num3 = 1014191348;
						num4 = 1014191348;
					}
					num = num3 ^ (int)(num2 * 1306184205);
					continue;
				}
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0028:
					flag = (byte)num5 != 0;
					num = -1825174446;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_0038: Incompatible stack heights: 0 vs 1
		//IL_0047: Incompatible stack heights: 0 vs 1
		//IL_004e: Incompatible stack heights: 0 vs 1
		JSONNode result = default(JSONNode);
		try
		{
			result = null;
			return result;
		}
		catch
		{
			while (true)
			{
				_ = -751306139;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -1010457908;
					uint num = (uint)(int)val;
					switch (val % 4)
					{
					case 2:
						result = null;
						_ = (num * 2119859936) ^ 0xF919E97;
						continue;
					case 1:
						_ = ((int)num * -2054130374) ^ -1529745416;
						continue;
					case 0:
						break;
					default:
						return result;
					case 3:
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
		string text = "{";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_011e:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1253872364;
					num2 = 1253872364;
				}
				else
				{
					num = 208119942;
					num2 = 208119942;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x3742FB17u) % 8u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 2)
						{
							num4 = -850601247;
							num5 = -850601247;
						}
						else
						{
							num4 = -897039000;
							num5 = -897039000;
						}
						num = num4 ^ (int)(num3 * 448950790);
						continue;
					}
					case 6u:
						num = ((int)num3 * -1179031204) ^ -367049419;
						continue;
					case 5u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)(num3 * 1209172627) ^ -406445180;
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
						num = 1292179065;
						continue;
					case 3u:
						current = enumerator.Current;
						num = 1540970520;
						continue;
					case 0u:
						num = 1253872364;
						continue;
					default:
						goto end_IL_00dd;
					case 2u:
						break;
					case 1u:
						goto end_IL_00dd;
					}
					goto IL_011e;
					continue;
					end_IL_00dd:
					break;
				}
				break;
			}
		}
		return JSONClass.smethod_32(text, "}");
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_014f:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1707413750;
					num2 = -1707413750;
				}
				else
				{
					num = -2134671479;
					num2 = -2134671479;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xEB59DEFFu) % 9u)
					{
					case 8u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = -1542436889;
						continue;
					case 7u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -647175414) ^ -817309639;
						continue;
					case 6u:
						flag = JSONClass.smethod_31(text) > 3;
						num = (int)(num3 * 485942599) ^ -1203521063;
						continue;
					case 5u:
						current = enumerator.Current;
						num = -797267461;
						continue;
					case 4u:
						num = -1707413750;
						continue;
					case 1u:
						num = ((int)num3 * -1101209156) ^ -648926754;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -742989252;
							num5 = -742989252;
						}
						else
						{
							num4 = -1135253297;
							num5 = -1135253297;
						}
						num = num4 ^ ((int)num3 * -1799571237);
						continue;
					}
					default:
						goto end_IL_0109;
					case 2u:
						break;
					case 3u:
						goto end_IL_0109;
					}
					goto IL_014f;
					continue;
					end_IL_0109:
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
				IL_019a:
				int num6 = -1327591784;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xEB59DEFFu) % 3u)
					{
					case 1u:
						goto IL_016e;
					default:
						goto end_IL_017c;
					case 2u:
						break;
					case 0u:
						goto end_IL_017c;
					}
					goto IL_019a;
					IL_016e:
					num6 = ((int)num3 * -2124155656) ^ 0x578DDEEB;
					continue;
					end_IL_017c:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num7 = -1042326510;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xEB59DEFFu) % 4u)
				{
				case 1u:
					result = text;
					num7 = ((int)num3 * -125883493) ^ 0x3F80FD2C;
					continue;
				case 0u:
					num7 = ((int)num3 * -1868920472) ^ -562065151;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -2017131889;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84F8644Bu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -640550615) ^ 0x8F3224C;
					continue;
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1871273764) ^ 0x26FC536E;
					continue;
				case 2u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 1487299867) ^ 0x346AA6B5);
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
						if (!enumerator.MoveNext())
						{
							num3 = -2050718134;
							num4 = -2050718134;
						}
						else
						{
							num3 = -2058321761;
							num4 = -2058321761;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x84F8644Bu) % 9u)
							{
							case 8u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -703220268) ^ 0x42042BB1;
								continue;
							case 7u:
								num3 = -2058321761;
								continue;
							case 6u:
								current = enumerator.Current;
								num3 = -2073824835;
								continue;
							case 5u:
								num3 = (int)(num2 * 547774902) ^ -1872033774;
								continue;
							case 4u:
								num3 = ((int)num2 * -803473609) ^ -93805056;
								continue;
							case 2u:
								num3 = (int)(num2 * 1425269812) ^ -906611217;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 952133292) ^ 0x4DA40DC1);
								continue;
							default:
								return;
							case 0u:
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
