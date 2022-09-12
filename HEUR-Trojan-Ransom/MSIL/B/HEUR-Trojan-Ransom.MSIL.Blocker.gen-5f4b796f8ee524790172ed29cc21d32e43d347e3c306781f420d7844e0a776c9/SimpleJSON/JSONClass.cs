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
				int num = -926823137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF357975Cu) % 6u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1081518283;
							num4 = -1081518283;
						}
						else
						{
							num3 = -506955280;
							num4 = -506955280;
						}
						num = num3 ^ ((int)num2 * -844824157);
						continue;
					}
					case 2u:
						num = ((int)num2 * -800468749) ^ 0x42C1810F;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = -695163436;
						continue;
					case 0u:
						result = m_Dict[aKey];
						num = (int)((num2 * 1524671356) ^ 0x4CB5C717);
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
			bool flag = default(bool);
			while (true)
			{
				int num = -1824609295;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA7C163Du) % 7u)
					{
					case 6u:
						m_Dict.Add(aKey, value);
						num = -1130602678;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1150809354;
							num4 = -1150809354;
						}
						else
						{
							num3 = -1020679949;
							num4 = -1020679949;
						}
						num = num3 ^ ((int)num2 * -1042374489);
						continue;
					}
					case 3u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 261086441) ^ -1729115661;
						continue;
					case 1u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 1665463329) ^ 0x3D180B2);
						continue;
					case 0u:
						num = ((int)num2 * -149402547) ^ 0x579185E9;
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
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
			goto IL_009a;
			IL_0089:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_009a;
			IL_000a:
			int num2 = -1233380737;
			goto IL_005c;
			IL_005c:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xFD9FAD88u) % 7u)
				{
				case 5u:
					break;
				case 4u:
					num2 = (int)(num3 * 884761674) ^ -895810185;
					continue;
				case 2u:
					result = null;
					num2 = ((int)num3 * -674657181) ^ -1051312236;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1126491098;
						num5 = -1126491098;
					}
					else
					{
						num4 = -190054000;
						num5 = -190054000;
					}
					num2 = num4 ^ ((int)num3 * -392082336);
					continue;
				}
				case 0u:
					result = null;
					num2 = -1102255637;
					continue;
				case 3u:
					goto IL_0089;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_009a:
			flag = (byte)num != 0;
			num2 = -1920598743;
			goto IL_005c;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0023;
			}
			goto IL_005c;
			IL_0023:
			int num = 734505950;
			goto IL_0028;
			IL_0028:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42F00A73u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1016670543) ^ -421618914;
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0049;
				case 2u:
					return;
				}
				break;
				IL_0049:
				if (aIndex < m_Dict.Count)
				{
					num = 1089288141;
					num3 = 1089288141;
					continue;
				}
				goto IL_005c;
			}
			goto IL_0023;
			IL_005c:
			num = 128020144;
			num3 = 128020144;
			goto IL_0028;
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
				int num = 869571884;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22802A39u) % 4u)
					{
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -200317545) ^ 0x558CD93A;
						continue;
					case 0u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -123447905) ^ -2015020206;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = !JSONClass.smethod_30(aKey);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1661614664;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1BBBF3Fu) % 14u)
				{
				case 13u:
					num = -342025333;
					continue;
				case 12u:
					num = ((int)num2 * -1797178995) ^ 0x7434F4C;
					continue;
				case 10u:
					num = ((int)num2 * -1985644137) ^ -2059559741;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1014678874;
						num6 = -1014678874;
					}
					else
					{
						num5 = -728217815;
						num6 = -728217815;
					}
					num = num5 ^ (int)(num2 * 45883725);
					continue;
				}
				case 8u:
					m_Dict.Add(aKey, aItem);
					num = -990812346;
					continue;
				case 7u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1487066255) ^ -1261405345;
					continue;
				case 5u:
					num = (int)(num2 * 1505963258) ^ -379268053;
					continue;
				case 4u:
					num = (int)((num2 * 440581237) ^ 0x7726B3AE);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -1524580817;
						num4 = -1524580817;
					}
					else
					{
						num3 = -389129916;
						num4 = -389129916;
					}
					num = num3 ^ ((int)num2 * -218581788);
					continue;
				}
				case 2u:
					num = (int)((num2 * 567079955) ^ 0x21ED09B8);
					continue;
				case 1u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -124917863;
					continue;
				case 0u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1151743918) ^ -55987502;
					continue;
				default:
					return;
				case 6u:
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
			int num = 909468523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D1BC989u) % 9u)
				{
				case 8u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -1669807422) ^ -1133428228;
					continue;
				case 7u:
					jSONNode = m_Dict[aKey];
					num = 573639222;
					continue;
				case 6u:
					num = ((int)num2 * -1775947086) ^ 0x51C2C276;
					continue;
				case 4u:
					result = null;
					num = ((int)num2 * -1759590018) ^ 0x125B04D5;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1837326781;
						num4 = -1837326781;
					}
					else
					{
						num3 = -88344487;
						num4 = -88344487;
					}
					num = num3 ^ ((int)num2 * -1141267577);
					continue;
				}
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -927191491) ^ -944607816;
					continue;
				case 0u:
					num = ((int)num2 * -370285560) ^ 0x2061FA20;
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
		if (aIndex >= 0)
		{
			goto IL_002e;
		}
		goto IL_006b;
		IL_002e:
		int num = -2093805050;
		goto IL_0033;
		IL_0033:
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xAC706D0Bu) % 5u)
			{
			case 3u:
				result = null;
				num = -869579227;
				continue;
			case 2u:
				result = null;
				num = (int)(num2 * 1533408808) ^ -778235611;
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0058;
			default:
				return result;
			}
			break;
			IL_0058:
			if (aIndex < m_Dict.Count)
			{
				num = -1463383667;
				num3 = -1463383667;
				continue;
			}
			goto IL_006b;
		}
		goto IL_002e;
		IL_006b:
		num = -2075778965;
		num3 = -2075778965;
		goto IL_0033;
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
				int num = 738489088;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5078C1A0u) % 3u)
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
					num = (int)((num2 * 687295443) ^ 0x4E0B1CE);
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 1149094020;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x5078C1A0;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = (num2 * 803823217) ^ 0xC393842Fu;
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
		string result = default(string);
		while (true)
		{
			int num = -1995150734;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97A50AF2u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
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
								num3 = -703056115;
								num4 = -703056115;
							}
							else
							{
								num3 = -1353145007;
								num4 = -1353145007;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x97A50AF2u) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = -2018158927;
									continue;
								case 7u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -266412727;
									continue;
								case 5u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)(num2 * 482923476) ^ -1226587894;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 750662124;
										num6 = 750662124;
									}
									else
									{
										num5 = 167660869;
										num6 = 167660869;
									}
									num3 = num5 ^ (int)(num2 * 288072956);
									continue;
								}
								case 3u:
									num3 = -1353145007;
									continue;
								case 2u:
									num3 = (int)(num2 * 221513210) ^ -796287850;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 276243364) ^ 0x46B172CD);
									continue;
								default:
									goto end_IL_0125;
								case 1u:
									break;
								case 6u:
									goto end_IL_0125;
								}
								goto IL_016b;
								continue;
								end_IL_0125:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = -809424548;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x97A50AF2u) % 3u)
							{
							case 1u:
								goto IL_0197;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0197:
							result = text;
							num7 = (int)((num2 * 1407981084) ^ 0x62203A90);
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{";
				num = (int)((num2 * 577853141) ^ 0x59B52B3D);
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
			bool flag = default(bool);
			while (true)
			{
				IL_013d:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -735529960;
					num2 = -735529960;
				}
				else
				{
					num = -1286249295;
					num2 = -1286249295;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x9A98FD86u) % 8u)
					{
					case 6u:
						current = enumerator.Current;
						num = -222439174;
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
						num = -938451908;
						continue;
					case 4u:
						flag = JSONClass.smethod_31(text) > 3;
						num = (int)(num3 * 688999605) ^ -2091440727;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -124543904;
							num5 = -124543904;
						}
						else
						{
							num4 = -437725564;
							num5 = -437725564;
						}
						num = num4 ^ ((int)num3 * -1465051539);
						continue;
					}
					case 1u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -54397158) ^ -971018983;
						continue;
					case 0u:
						num = -735529960;
						continue;
					default:
						goto end_IL_00fc;
					case 2u:
						break;
					case 7u:
						goto end_IL_00fc;
					}
					goto IL_013d;
					continue;
					end_IL_00fc:
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
				IL_0188:
				int num6 = -826127632;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x9A98FD86u) % 3u)
					{
					case 1u:
						goto IL_015c;
					default:
						goto end_IL_016a;
					case 2u:
						break;
					case 0u:
						goto end_IL_016a;
					}
					goto IL_0188;
					IL_015c:
					num6 = (int)((num3 * 198215180) ^ 0x7FE74A3A);
					continue;
					end_IL_016a:
					break;
				}
				break;
			}
		}
		return JSONClass.smethod_35(text, "\n", aPrefix, "}");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 1777076314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46FF73F1u) % 4u)
				{
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1244527973) ^ 0x15D78B89;
					continue;
				case 1u:
					num = ((int)num2 * -770583324) ^ -153822661;
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
								num3 = 381225897;
								num4 = 381225897;
							}
							else
							{
								num3 = 1318255036;
								num4 = 1318255036;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x46FF73F1u) % 8u)
								{
								case 6u:
									JSONClass.smethod_38(aWriter, current);
									num3 = ((int)num2 * -1309038357) ^ 0x1B089951;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 1142722471;
									continue;
								case 4u:
									num3 = 1318255036;
									continue;
								case 3u:
									m_Dict[current].Serialize(aWriter);
									num3 = (int)((num2 * 777797530) ^ 0x67C6249E);
									continue;
								case 2u:
									num3 = (int)((num2 * 1299614401) ^ 0x530A7B90);
									continue;
								case 1u:
									num3 = ((int)num2 * -281789633) ^ 0x1E46B5B1;
									continue;
								default:
									return;
								case 7u:
									break;
								case 0u:
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
							IL_0175:
							int num5 = 892894007;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x46FF73F1u) % 3u)
								{
								case 1u:
									goto IL_014b;
								default:
									goto end_IL_0158;
								case 0u:
									break;
								case 2u:
									goto end_IL_0158;
								}
								goto IL_0175;
								IL_014b:
								num5 = (int)(num2 * 931577173) ^ -1946400702;
								continue;
								end_IL_0158:
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
