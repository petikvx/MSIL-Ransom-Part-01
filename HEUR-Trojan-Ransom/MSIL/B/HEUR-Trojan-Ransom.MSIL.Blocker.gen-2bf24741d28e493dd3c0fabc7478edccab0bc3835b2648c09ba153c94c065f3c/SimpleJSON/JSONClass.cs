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
			bool flag = m_Dict.ContainsKey(aKey);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1938508442;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A9C85FFu) % 5u)
					{
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = 552571976;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1503173153;
							num4 = -1503173153;
						}
						else
						{
							num3 = -774659209;
							num4 = -774659209;
						}
						num = num3 ^ ((int)num2 * -1532596500);
						continue;
					}
					case 0u:
						result = m_Dict[aKey];
						num = ((int)num2 * -303106636) ^ 0x393D678;
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
				int num = -1459785132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4772C37u) % 8u)
					{
					case 6u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1621494119) ^ -1422176491;
						continue;
					case 4u:
						num = ((int)num2 * -1273942936) ^ 0x2380077F;
						continue;
					case 3u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 1938794138) ^ -1005419896;
						continue;
					case 2u:
						m_Dict.Add(aKey, value);
						num = -220089150;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 953892396;
							num4 = 953892396;
						}
						else
						{
							num3 = 2076793200;
							num4 = 2076793200;
						}
						num = num3 ^ ((int)num2 * -187722139);
						continue;
					}
					case 0u:
						num = (int)((num2 * 178941470) ^ 0x2DAAA272);
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

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -367077971;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xF40E5DC5u) % 7u)
					{
					case 5u:
						if (aIndex < m_Dict.Count)
						{
							num = -1613942815;
							num3 = -1613942815;
							continue;
						}
						goto IL_0019;
					case 4u:
						num = ((int)num2 * -1405673938) ^ -339179174;
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1777142365) ^ -489514598;
							continue;
						}
						goto IL_0019;
					case 2u:
						result = null;
						num = -1204364836;
						continue;
					case 1u:
						result = null;
						num = (int)((num2 * 2022124287) ^ 0x70C53DA0);
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_0019:
						num = -1634862603;
						num3 = -1634862603;
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
				int num = -735621374;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xD11711F9u) % 5u)
					{
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -585701888) ^ -894587841;
							continue;
						}
						goto IL_0019;
					case 1u:
						num = ((int)num2 * -1878665962) ^ -1018891625;
						continue;
					case 0u:
						if (aIndex < m_Dict.Count)
						{
							num = -562691973;
							num3 = -562691973;
							continue;
						}
						goto IL_0019;
					default:
						return;
					case 2u:
						break;
					case 4u:
						return;
						IL_0019:
						num = -795653925;
						num3 = -795653925;
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
				int num = 1415705579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4AEECF8Du) % 4u)
					{
					case 3u:
						num = ((int)num2 * -803107984) ^ -132103232;
						continue;
					case 2u:
						count = m_Dict.Count;
						num = (int)(num2 * 254879222) ^ -1273088098;
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
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -932722954;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE4A40B60u) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1976247366) ^ -861044187;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 714519421) ^ 0x3B88852D);
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
		if (!JSONClass.smethod_30(aKey))
		{
			goto IL_0076;
		}
		goto IL_0126;
		IL_0126:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = -143720438;
		goto IL_00e0;
		IL_00e0:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x91E6F08Au) % 13u)
			{
			case 12u:
				m_Dict.Add(aKey, aItem);
				num = -391918233;
				continue;
			case 11u:
				num = -63350306;
				continue;
			case 10u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -709964731;
					num4 = -709964731;
				}
				else
				{
					num3 = -1985134931;
					num4 = -1985134931;
				}
				num = num3 ^ (int)(num2 * 855884032);
				continue;
			}
			case 9u:
				num = (int)(num2 * 875195862) ^ -1284370507;
				continue;
			case 8u:
				num = ((int)num2 * -683636035) ^ -2078935647;
				continue;
			case 7u:
				break;
			case 5u:
				num = ((int)num2 * -468134445) ^ 0x382EB192;
				continue;
			case 4u:
				num = (int)((num2 * 777507970) ^ 0x50368CA2);
				continue;
			case 2u:
				m_Dict[aKey] = aItem;
				num = (int)((num2 * 922174207) ^ 0x134E42D8);
				continue;
			case 1u:
				flag = m_Dict.ContainsKey(aKey);
				num = (int)((num2 * 787956175) ^ 0x68B963AE);
				continue;
			case 0u:
				num = (int)(num2 * 1351657861) ^ -414725714;
				continue;
			default:
				return;
			case 3u:
				goto IL_0126;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0076;
		IL_0076:
		num = -935175331;
		goto IL_00e0;
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -30435918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84D926E5u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 393260313;
						num4 = 393260313;
					}
					else
					{
						num3 = 1309966886;
						num4 = 1309966886;
					}
					num = num3 ^ ((int)num2 * -1152409776);
					continue;
				}
				case 5u:
					num = ((int)num2 * -531930126) ^ 0x5C35ECE9;
					continue;
				case 4u:
					result = null;
					num = ((int)num2 * -1611031021) ^ 0x177E0A5C;
					continue;
				case 3u:
					jSONNode = m_Dict[aKey];
					num = -2006895859;
					continue;
				case 1u:
					result = jSONNode;
					num = (int)(num2 * 1374467253) ^ -181301498;
					continue;
				case 0u:
					m_Dict.Remove(aKey);
					num = (int)((num2 * 1051339343) ^ 0xBEA12EC);
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
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 247940100;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x277E05EEu) % 8u)
				{
				case 7u:
					result = null;
					num = 745360213;
					continue;
				case 6u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0020;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1702004056;
						num5 = 1702004056;
					}
					else
					{
						num4 = 2063160071;
						num5 = 2063160071;
					}
					num = num4 ^ ((int)num2 * -601402818);
					continue;
				}
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1579547200) ^ 0x28FA7188;
						continue;
					}
					num3 = 1;
					goto IL_0020;
				case 1u:
					num = ((int)num2 * -1657389321) ^ 0x3739D542;
					continue;
				case 0u:
					result = null;
					num = (int)((num2 * 1080775716) ^ 0x13121C4F);
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0020:
					flag = (byte)num3 != 0;
					num = 2084287971;
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
		//IL_0023: Expected I4, but got Unknown
		//IL_0034: Incompatible stack heights: 0 vs 1
		//IL_003b: Incompatible stack heights: 0 vs 1
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
				_ = -705169897;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -751456940;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num * -403485099) ^ 0x1CDB6E98;
						continue;
					case 0:
						break;
					default:
						return result;
					case 2:
						return result;
					}
					break;
				}
			}
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
		string result = default(string);
		while (true)
		{
			int num = 183653657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C3197F8u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1634061428) ^ 0x45DB57F0);
					continue;
				case 1u:
					text = "{";
					num = (int)(num2 * 1722337243) ^ -185105459;
					continue;
				case 3u:
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
							if (!enumerator.MoveNext())
							{
								num3 = 463410165;
								num4 = 463410165;
							}
							else
							{
								num3 = 350324260;
								num4 = 350324260;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6C3197F8u) % 8u)
								{
								case 6u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -875449628) ^ 0x58B06249;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = 135996563;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 2)
									{
										num5 = -351467535;
										num6 = -351467535;
									}
									else
									{
										num5 = -56084906;
										num6 = -56084906;
									}
									num3 = num5 ^ ((int)num2 * -649807168);
									continue;
								}
								case 2u:
									num3 = 350324260;
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
									num3 = 2131679808;
									continue;
								case 0u:
									num3 = (int)(num2 * 344524291) ^ -2070933033;
									continue;
								default:
									goto end_IL_012a;
								case 7u:
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
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = 1009670898;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x6C3197F8u) % 3u)
							{
							case 2u:
								goto IL_0197;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0197:
							result = text;
							num7 = (int)(num2 * 1210955776) ^ -1079049501;
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
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_013e:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 2986630;
					num2 = 2986630;
				}
				else
				{
					num = 63660579;
					num2 = 63660579;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x12DEAC1Fu) % 8u)
					{
					case 7u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -60049744) ^ -1788120809;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 3)
						{
							num4 = -1369153563;
							num5 = -1369153563;
						}
						else
						{
							num4 = -278455926;
							num5 = -278455926;
						}
						num = num4 ^ (int)(num3 * 29106027);
						continue;
					}
					case 5u:
						num = (int)(num3 * 292479847) ^ -1599211734;
						continue;
					case 2u:
						num = 2986630;
						continue;
					case 1u:
						current = enumerator.Current;
						num = 1044735402;
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
						num = 396921900;
						continue;
					default:
						goto end_IL_00fd;
					case 3u:
						break;
					case 4u:
						goto end_IL_00fd;
					}
					goto IL_013e;
					continue;
					end_IL_00fd:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num6 = 709589197;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x12DEAC1Fu) % 4u)
				{
				case 2u:
					result = text;
					num6 = ((int)num3 * -125036869) ^ 0x222673DC;
					continue;
				case 1u:
					num6 = (int)((num3 * 380053116) ^ 0x5E9B2EC0);
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		JSONClass.smethod_37(aWriter, m_Dict.Count);
		using Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
		string current = default(string);
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -1537114036;
				num2 = -1537114036;
			}
			else
			{
				num = -500088564;
				num2 = -500088564;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xEC739DAFu) % 9u)
				{
				case 8u:
					num = (int)(num3 * 515415547) ^ -202608744;
					continue;
				case 7u:
					current = enumerator.Current;
					num = -107356682;
					continue;
				case 6u:
					JSONClass.smethod_38(aWriter, current);
					num = (int)((num3 * 1084805841) ^ 0x5CB601D9);
					continue;
				case 5u:
					num = (int)((num3 * 1908887821) ^ 0x23B6AA1E);
					continue;
				case 4u:
					num = ((int)num3 * -461158181) ^ 0x38D75681;
					continue;
				case 2u:
					num = -500088564;
					continue;
				case 0u:
					m_Dict[current].Serialize(aWriter);
					num = ((int)num3 * -170630389) ^ -1999651163;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
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
