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
				int num = -2112418453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCF555658u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -754006284) ^ -1297997100;
						continue;
					case 6u:
						num = ((int)num2 * -88146730) ^ -606514244;
						continue;
					case 5u:
						result = m_Dict[aKey];
						num = (int)(num2 * 494348030) ^ -1825003592;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1057555797;
							num4 = 1057555797;
						}
						else
						{
							num3 = 89481289;
							num4 = 89481289;
						}
						num = num3 ^ ((int)num2 * -1090986779);
						continue;
					}
					case 3u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 151346205) ^ -929338045;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = -2071815521;
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
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_001f;
			}
			goto IL_008b;
			IL_008b:
			m_Dict.Add(aKey, value);
			int num = 1152305711;
			goto IL_005e;
			IL_005e:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x345FE2DAu) % 7u)
				{
				case 5u:
					num = ((int)num2 * -2067571193) ^ 0x502922DF;
					continue;
				case 4u:
					break;
				case 3u:
					num = ((int)num2 * -2141820674) ^ 0x1099EDFE;
					continue;
				case 2u:
					m_Dict[aKey] = value;
					num = ((int)num2 * -67314236) ^ 0x1C875A47;
					continue;
				case 1u:
					num = (int)(num2 * 2093233816) ^ -1627864459;
					continue;
				default:
					return;
				case 6u:
					goto IL_008b;
				case 0u:
					return;
				}
				break;
			}
			goto IL_001f;
			IL_001f:
			num = 1677190065;
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
				int num = 1439118021;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x5B4ACB82u) % 8u)
					{
					case 7u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -352019264) ^ -1323677824;
							continue;
						}
						num5 = 1;
						goto IL_001a;
					case 6u:
						num = (int)(num2 * 415056473) ^ -910313504;
						continue;
					case 5u:
						result = null;
						num = (int)((num2 * 285256694) ^ 0x5E7569F2);
						continue;
					case 3u:
						result = null;
						num = 1768525518;
						continue;
					case 2u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -28687874;
							num4 = -28687874;
						}
						else
						{
							num3 = -373924032;
							num4 = -373924032;
						}
						num = num3 ^ (int)(num2 * 1349475833);
						continue;
					}
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_001a:
						flag = (byte)num5 != 0;
						num = 1415683891;
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
				int num = -1114602963;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x91BEE281u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -632113170) ^ -279342995;
						continue;
					case 4u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -291661262) ^ 0x32FDA82C;
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
							num3 = -2061327194;
							num4 = -2061327194;
						}
						else
						{
							num3 = -1257524597;
							num4 = -1257524597;
						}
						num = num3 ^ (int)(num2 * 781621002);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
						IL_0029:
						flag = (byte)num5 != 0;
						num = -1091334745;
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
				int num = -369018608;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAF964E74u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = ((int)num2 * -227722090) ^ 0x176316CC;
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
				int num = -2008827338;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB340A3FDu) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -2092413415) ^ 0x677F99F;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1565646215;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD27C202Fu) % 13u)
				{
				case 12u:
					num = ((int)num2 * -727552304) ^ 0x47BE3318;
					continue;
				case 11u:
					num = ((int)num2 * -646077666) ^ -207768405;
					continue;
				case 10u:
					num = (int)(num2 * 1844118999) ^ -1607737010;
					continue;
				case 9u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 341526835) ^ -1016182096;
					continue;
				case 8u:
					m_Dict.Add(aKey, aItem);
					num = -1961674117;
					continue;
				case 7u:
					num = (int)((num2 * 1323456301) ^ 0x62AF6DCB);
					continue;
				case 5u:
					num = -1763261735;
					continue;
				case 4u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 1072395525) ^ 0x5C4275A6);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1948058528;
						num6 = 1948058528;
					}
					else
					{
						num5 = 1881705974;
						num6 = 1881705974;
					}
					num = num5 ^ (int)(num2 * 1917252301);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (JSONClass.smethod_30(aKey))
					{
						num3 = -1351510358;
						num4 = -1351510358;
					}
					else
					{
						num3 = -596789793;
						num4 = -596789793;
					}
					num = num3 ^ (int)(num2 * 432645108);
					continue;
				}
				case 0u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1190938514;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
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
			goto IL_0014;
		}
		goto IL_00a6;
		IL_00a6:
		JSONNode jSONNode = m_Dict[aKey];
		int num = 1494185100;
		goto IL_0075;
		IL_0075:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x679005Cu) % 8u)
			{
			case 7u:
				break;
			case 5u:
				num = (int)(num2 * 760988414) ^ -1300978135;
				continue;
			case 4u:
				result = jSONNode;
				num = (int)(num2 * 109346823) ^ -1922752070;
				continue;
			case 2u:
				num = ((int)num2 * -906943292) ^ 0x6AA8D527;
				continue;
			case 1u:
				result = null;
				num = (int)((num2 * 1647895816) ^ 0x7CA72689);
				continue;
			case 0u:
				m_Dict.Remove(aKey);
				num = ((int)num2 * -1340477503) ^ -989251104;
				continue;
			case 6u:
				goto IL_00a6;
			default:
				return result;
			}
			break;
		}
		goto IL_0014;
		IL_0014:
		num = 289836133;
		goto IL_0075;
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 1644699521;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x481B5460u) % 7u)
				{
				case 6u:
					num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0017;
				case 4u:
					result = null;
					num = 125099449;
					continue;
				case 3u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -291550974) ^ 0x929BEB1;
						continue;
					}
					num5 = 1;
					goto IL_0017;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1758160727;
						num4 = -1758160727;
					}
					else
					{
						num3 = -512461458;
						num4 = -512461458;
					}
					num = num3 ^ ((int)num2 * -832189479);
					continue;
				}
				case 0u:
					result = null;
					num = ((int)num2 * -1981339664) ^ 0x494FBFA9;
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num5 != 0;
					num = 339439449;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num = -447200184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90B5B1FDu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1107518193) ^ -1841811484;
					continue;
				case 1u:
					text = "{";
					num = (int)((num2 * 2037595355) ^ 0x1F01F739);
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
							IL_017c:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -678007204;
								num4 = -678007204;
							}
							else
							{
								num3 = -2083185937;
								num4 = -2083185937;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x90B5B1FDu) % 9u)
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
									num3 = -340210494;
									continue;
								case 6u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -1136035659) ^ -932406016;
									continue;
								case 5u:
									num3 = (int)(num2 * 973730323) ^ -173202512;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1013280876) ^ -1935542355;
									continue;
								case 2u:
									num3 = -678007204;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -735639992;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 907627382;
										num6 = 907627382;
									}
									else
									{
										num5 = 1629926388;
										num6 = 1629926388;
									}
									num3 = num5 ^ (int)(num2 * 976579815);
									continue;
								}
								default:
									goto end_IL_0136;
								case 3u:
									break;
								case 7u:
									goto end_IL_0136;
								}
								goto IL_017c;
								continue;
								end_IL_0136:
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
							IL_01c7:
							int num7 = -2019633851;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x90B5B1FDu) % 3u)
								{
								case 2u:
									goto IL_019b;
								default:
									goto end_IL_01a9;
								case 0u:
									break;
								case 1u:
									goto end_IL_01a9;
								}
								goto IL_01c7;
								IL_019b:
								num7 = (int)(num2 * 547540287) ^ -293367761;
								continue;
								end_IL_01a9:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num8 = -1433448143;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x90B5B1FDu) % 3u)
							{
							case 1u:
								goto IL_01e0;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_01e0:
							num8 = ((int)num2 * -1904823765) ^ -854127044;
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
		string text = "{ ";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0156:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1496677291;
					num2 = -1496677291;
				}
				else
				{
					num = -1174608409;
					num2 = -1174608409;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xA00C1B87u) % 9u)
					{
					case 8u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1954006015) ^ -66280987;
						continue;
					case 7u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						num = -818912343;
						continue;
					case 6u:
						current = enumerator.Current;
						num = -1397228989;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) > 3)
						{
							num4 = -77574416;
							num5 = -77574416;
						}
						else
						{
							num4 = -1828861806;
							num5 = -1828861806;
						}
						num = num4 ^ (int)(num3 * 724556788);
						continue;
					}
					case 4u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = ((int)num3 * -384591694) ^ -1741217547;
						continue;
					case 3u:
						num = -1496677291;
						continue;
					case 2u:
						num = (int)((num3 * 1346458383) ^ 0x50E24371);
						continue;
					default:
						goto end_IL_0110;
					case 1u:
						break;
					case 0u:
						goto end_IL_0110;
					}
					goto IL_0156;
					continue;
					end_IL_0110:
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
				IL_01a1:
				int num6 = -1874579066;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xA00C1B87u) % 3u)
					{
					case 1u:
						goto IL_0175;
					default:
						goto end_IL_0183;
					case 0u:
						break;
					case 2u:
						goto end_IL_0183;
					}
					goto IL_01a1;
					IL_0175:
					num6 = (int)(num3 * 167038577) ^ -275504179;
					continue;
					end_IL_0183:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = text;
		while (true)
		{
			int num7 = -993885047;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xA00C1B87u) % 3u)
				{
				case 2u:
					goto IL_01c0;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_01c0:
				num7 = (int)(num3 * 1022934590) ^ -267486289;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 1548937947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x81C8D30u) % 4u)
				{
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -1375550283) ^ 0x270DC18D;
					continue;
				case 2u:
					num = (int)(num2 * 647763700) ^ -1410539911;
					continue;
				case 0u:
					break;
				default:
				{
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					using Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = 53126875;
							num4 = 53126875;
						}
						else
						{
							num3 = 565093860;
							num4 = 565093860;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x81C8D30u) % 8u)
							{
							case 7u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 1731282712) ^ 0x73DA745);
								continue;
							case 6u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -574272645) ^ -521810773;
								continue;
							case 4u:
								current = enumerator.Current;
								num3 = 1655126834;
								continue;
							case 2u:
								num3 = ((int)num2 * -1314920868) ^ 0x7585B596;
								continue;
							case 1u:
								num3 = ((int)num2 * -1881140235) ^ 0x53EE21BA;
								continue;
							case 0u:
								num3 = 565093860;
								continue;
							default:
								return;
							case 5u:
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
