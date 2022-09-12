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
				int num = 137324010;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x380EAA5Du) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1728971260;
							num4 = 1728971260;
						}
						else
						{
							num3 = 1646933433;
							num4 = 1646933433;
						}
						num = num3 ^ (int)(num2 * 973227219);
						continue;
					}
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -980807943) ^ 0x155B44C5;
						continue;
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = 1799412548;
						continue;
					case 2u:
						num = (int)((num2 * 532686968) ^ 0x3AE8697E);
						continue;
					case 0u:
						result = m_Dict[aKey];
						num = ((int)num2 * -274962632) ^ 0x5308F026;
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = 1940608451;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DD46689u) % 7u)
					{
					case 6u:
						m_Dict.Add(aKey, value);
						num = 144652461;
						continue;
					case 5u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 1864129672) ^ -591591247;
						continue;
					case 4u:
						num = ((int)num2 * -288298996) ^ 0x5C4F3052;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -117265623;
							num4 = -117265623;
						}
						else
						{
							num3 = -1633200357;
							num4 = -1633200357;
						}
						num = num3 ^ (int)(num2 * 2032875193);
						continue;
					}
					case 2u:
						num = ((int)num2 * -1971889734) ^ -665978670;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 707705985;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1079106Cu) % 7u)
					{
					case 5u:
						result = null;
						num = ((int)num2 * -1170674546) ^ 0x559C26E2;
						continue;
					case 3u:
						result = null;
						num = 799929011;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -976328612) ^ 0x65000FAD;
							continue;
						}
						goto IL_0042;
					case 1u:
						if (aIndex < m_Dict.Count)
						{
							num = 1378754170;
							num3 = 1378754170;
							continue;
						}
						goto IL_0042;
					case 0u:
						num = ((int)num2 * -526099581) ^ 0x5DAC79BB;
						continue;
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_0042:
						num = 1064141009;
						num3 = 1064141009;
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
				int num = 1316441778;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x69BA343Fu) % 5u)
					{
					case 4u:
						num = (int)((num2 * 379429942) ^ 0x6C7FD260);
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -490061574) ^ 0x4BFA7B8C;
							continue;
						}
						goto IL_0034;
					case 1u:
						if (aIndex < m_Dict.Count)
						{
							num = 1376430424;
							num3 = 1376430424;
							continue;
						}
						goto IL_0034;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
						IL_0034:
						num = 1918502571;
						num3 = 1918502571;
						continue;
					}
					break;
				}
			}
		}
	}

	public override int Count => m_Dict.Count;

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
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2141994719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D9C423Cu) % 15u)
				{
				case 14u:
					num = ((int)num2 * -1283821519) ^ 0x1A67F71A;
					continue;
				case 13u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 992072875) ^ -1480120506;
					continue;
				case 12u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 481270869) ^ -1599522007;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1939515751;
						num6 = 1939515751;
					}
					else
					{
						num5 = 1071786281;
						num6 = 1071786281;
					}
					num = num5 ^ ((int)num2 * -461171811);
					continue;
				}
				case 10u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1052267621;
						num4 = -1052267621;
					}
					else
					{
						num3 = -342644926;
						num4 = -342644926;
					}
					num = num3 ^ (int)(num2 * 2123332570);
					continue;
				}
				case 9u:
					num = 744947251;
					continue;
				case 6u:
					num = (int)(num2 * 526134039) ^ -301325553;
					continue;
				case 5u:
					m_Dict.Add(aKey, aItem);
					num = 566490528;
					continue;
				case 4u:
					num = (int)(num2 * 38918896) ^ -1752699718;
					continue;
				case 3u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1185777740;
					continue;
				case 2u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 1952221493) ^ 0x19238EF4);
					continue;
				case 1u:
					num = ((int)num2 * -355766435) ^ 0x2CBE483;
					continue;
				case 0u:
					num = ((int)num2 * -779010699) ^ 0x2C459D7B;
					continue;
				default:
					return;
				case 7u:
					break;
				case 8u:
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
		while (true)
		{
			int num = 472610533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D086653u) % 7u)
				{
				case 6u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = 620889204;
					continue;
				case 5u:
					result = jSONNode;
					num = ((int)num2 * -311862261) ^ 0x8B23122;
					continue;
				case 3u:
					result = null;
					num = (int)((num2 * 205880917) ^ 0x308CEAE5);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 2108174627;
						num4 = 2108174627;
					}
					else
					{
						num3 = 2046462018;
						num4 = 2046462018;
					}
					num = num3 ^ ((int)num2 * -1244765936);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1548686721) ^ 0x5F4C8091;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -622724492;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD3DD826Eu) % 7u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -1098356789) ^ 0xDC1DACE;
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -856360409) ^ 0x13ADA62;
						continue;
					}
					goto IL_0039;
				case 3u:
					result = null;
					num = -350210647;
					continue;
				case 2u:
					num = ((int)num2 * -1562368504) ^ -1213573806;
					continue;
				case 1u:
					if (aIndex < m_Dict.Count)
					{
						num = -1936040995;
						num3 = -1936040995;
						continue;
					}
					goto IL_0039;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0039:
					num = -311379966;
					num3 = -311379966;
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
				_ = 182456232;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x50786CFB;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num * -1703528453) ^ 0xEB2DC69;
						continue;
					case 2:
						break;
					default:
						return result;
					case 0:
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
		string text = "{";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0135:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -2051765572;
					num2 = -2051765572;
				}
				else
				{
					num = -1673014733;
					num2 = -1673014733;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xF5256B44u) % 9u)
					{
					case 8u:
						num = (int)(num3 * 227906103) ^ -564959941;
						continue;
					case 6u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = -1808498606;
						continue;
					case 5u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)(num3 * 645192608) ^ -721823828;
						continue;
					case 4u:
						flag = JSONClass.smethod_31(text) > 2;
						num = (int)((num3 * 1066082884) ^ 0x7E6E9B77);
						continue;
					case 3u:
						current = enumerator.Current;
						num = -547276007;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1048367287;
							num5 = 1048367287;
						}
						else
						{
							num4 = 34293168;
							num5 = 34293168;
						}
						num = num4 ^ (int)(num3 * 218206884);
						continue;
					}
					case 0u:
						num = -1673014733;
						continue;
					default:
						goto end_IL_00ef;
					case 1u:
						break;
					case 7u:
						goto end_IL_00ef;
					}
					goto IL_0135;
					continue;
					end_IL_00ef:
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
				IL_0180:
				int num6 = -1320695635;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xF5256B44u) % 3u)
					{
					case 1u:
						goto IL_0154;
					default:
						goto end_IL_0162;
					case 2u:
						break;
					case 0u:
						goto end_IL_0162;
					}
					goto IL_0180;
					IL_0154:
					num6 = (int)(num3 * 843783104) ^ -1708250850;
					continue;
					end_IL_0162:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num7 = -886209054;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xF5256B44u) % 4u)
				{
				case 2u:
					result = text;
					num7 = (int)(num3 * 732540287) ^ -1610723721;
					continue;
				case 1u:
					num7 = (int)((num3 * 634342810) ^ 0x1431EC6);
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
		string text = "{ ";
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0172:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 871698922;
					num2 = 871698922;
				}
				else
				{
					num = 3963844;
					num2 = 3963844;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x686B1247u) % 10u)
					{
					case 9u:
						num = 3963844;
						continue;
					case 8u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						num = 1779163611;
						continue;
					case 7u:
						current = enumerator.Current;
						num = 708416352;
						continue;
					case 6u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -696443102) ^ 0xF9EB581;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1680526107;
							num5 = -1680526107;
						}
						else
						{
							num4 = -1438188283;
							num5 = -1438188283;
						}
						num = num4 ^ (int)(num3 * 418461664);
						continue;
					}
					case 3u:
						num = (int)((num3 * 1111474574) ^ 0x50E653B9);
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
						num = ((int)num3 * -840161923) ^ -422181066;
						continue;
					case 1u:
						flag = JSONClass.smethod_31(text) > 3;
						num = (int)((num3 * 1258575365) ^ 0x564C76BC);
						continue;
					default:
						goto end_IL_0128;
					case 0u:
						break;
					case 5u:
						goto end_IL_0128;
					}
					goto IL_0172;
					continue;
					end_IL_0128:
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
				IL_01bd:
				int num6 = 1151783863;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x686B1247u) % 3u)
					{
					case 1u:
						goto IL_0191;
					default:
						goto end_IL_019f;
					case 0u:
						break;
					case 2u:
						goto end_IL_019f;
					}
					goto IL_01bd;
					IL_0191:
					num6 = ((int)num3 * -1135487058) ^ -931286004;
					continue;
					end_IL_019f:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = text;
		while (true)
		{
			int num7 = 1315317618;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x686B1247u) % 3u)
				{
				case 1u:
					goto IL_01dc;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_01dc:
				num7 = ((int)num3 * -1852178446) ^ -552535513;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -190726074;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC82750Cu) % 5u)
				{
				case 4u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1895742745) ^ -979526112;
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 940990533) ^ -254762217;
					continue;
				case 0u:
					num = (int)((num2 * 711699824) ^ 0x31D33BBF);
					continue;
				case 2u:
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
							num3 = -316551383;
							num4 = -316551383;
						}
						else
						{
							num3 = -617284208;
							num4 = -617284208;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xCC82750Cu) % 7u)
							{
							case 6u:
								current = enumerator.Current;
								num3 = -964917616;
								continue;
							case 4u:
								num3 = -316551383;
								continue;
							case 3u:
								num3 = (int)((num2 * 229251355) ^ 0xEFE67FE);
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -323168950) ^ -392854444;
								continue;
							case 0u:
								num3 = ((int)num2 * -252817141) ^ -345198671;
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
				break;
			}
		}
	}

	public JSONClass()
	{
		while (true)
		{
			int num = 794667344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30E48647u) % 3u)
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
				num = (int)((num2 * 1227183404) ^ 0x61E0367D);
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
