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
				int num = 1913698026;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50FE5726u) % 6u)
					{
					case 5u:
						num = (int)(num2 * 1094879680) ^ -653226666;
						continue;
					case 4u:
						result = new JSONLazyCreator(this, aKey);
						num = 1839017878;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 636758774;
							num4 = 636758774;
						}
						else
						{
							num3 = 621704327;
							num4 = 621704327;
						}
						num = num3 ^ ((int)num2 * -1267823184);
						continue;
					}
					case 1u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1219704867) ^ 0x1AC66DE6;
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
			bool flag = default(bool);
			while (true)
			{
				int num = -1266750458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFED21F3u) % 7u)
					{
					case 6u:
						m_Dict.Add(aKey, value);
						num = -685812111;
						continue;
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -908207702) ^ -1085657999;
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -689614655) ^ 0x42EFF1F6;
						continue;
					case 1u:
						num = ((int)num2 * -1222860944) ^ -2033054207;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 897097525;
							num4 = 897097525;
						}
						else
						{
							num3 = 1746029879;
							num4 = 1746029879;
						}
						num = num3 ^ (int)(num2 * 1030058225);
						continue;
					}
					default:
						return;
					case 3u:
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
				int num = -1031262258;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xAD29EF97u) % 8u)
					{
					case 6u:
						result = null;
						num = -546910276;
						continue;
					case 5u:
						num = ((int)num2 * -1660993075) ^ -1809944795;
						continue;
					case 4u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_002f;
					case 2u:
						result = null;
						num = ((int)num2 * -1284408570) ^ -449652922;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -846187673) ^ 0x7FB01F3C;
							continue;
						}
						num5 = 1;
						goto IL_002f;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1290695077;
							num4 = 1290695077;
						}
						else
						{
							num3 = 1175542977;
							num4 = 1175542977;
						}
						num = num3 ^ (int)(num2 * 600212105);
						continue;
					}
					case 7u:
						break;
					default:
						{
							return result;
						}
						IL_002f:
						flag = (byte)num5 != 0;
						num = -592003945;
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
				int num = 1717946459;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x6F3B6DB6u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 2023436777) ^ 0x7C42BDDF);
						continue;
					case 2u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0026;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1577257090) ^ 0x60F4BE6C;
							continue;
						}
						num5 = 1;
						goto IL_0026;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -3010598;
							num4 = -3010598;
						}
						else
						{
							num3 = -1412635317;
							num4 = -1412635317;
						}
						num = num3 ^ (int)(num2 * 1947386596);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 4u:
						return;
						IL_0026:
						flag = (byte)num5 != 0;
						num = 1760005502;
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
				int num = -700971043;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA78779E8u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2079903249) ^ 0x29440297;
						continue;
					case 1u:
						count = m_Dict.Count;
						num = (int)((num2 * 1601752861) ^ 0x45A28B02);
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		if (!JSONClass.smethod_30(aKey))
		{
			goto IL_00ae;
		}
		goto IL_0100;
		IL_0100:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = 1687730464;
		goto IL_00c2;
		IL_00c2:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x186C0990u) % 11u)
			{
			case 10u:
				num = 757247959;
				continue;
			case 9u:
				m_Dict.Add(aKey, aItem);
				num = 1058908368;
				continue;
			case 8u:
				m_Dict[aKey] = aItem;
				num = ((int)num2 * -1543734926) ^ -268612857;
				continue;
			case 7u:
				num = (int)(num2 * 1866928982) ^ -1041458694;
				continue;
			case 6u:
				num = (int)((num2 * 1852347452) ^ 0xF9B827D);
				continue;
			case 5u:
			{
				int num3;
				int num4;
				if (!flag)
				{
					num3 = 1478645901;
					num4 = 1478645901;
				}
				else
				{
					num3 = 590428574;
					num4 = 590428574;
				}
				num = num3 ^ (int)(num2 * 347768285);
				continue;
			}
			case 4u:
				flag = m_Dict.ContainsKey(aKey);
				num = ((int)num2 * -1101297830) ^ 0x29E2F3B3;
				continue;
			case 2u:
				break;
			case 1u:
				num = (int)(num2 * 1224914179) ^ -684583197;
				continue;
			default:
				return;
			case 3u:
				goto IL_0100;
			case 0u:
				return;
			}
			break;
		}
		goto IL_00ae;
		IL_00ae:
		num = 193688865;
		goto IL_00c2;
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1222968678;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8841B733u) % 7u)
				{
				case 5u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = -779919065;
					continue;
				}
				case 3u:
					result = null;
					num = (int)((num2 * 1754107564) ^ 0x5F6E8CAE);
					continue;
				case 2u:
					num = ((int)num2 * -2131421294) ^ 0x787FA850;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 266827003;
						num4 = 266827003;
					}
					else
					{
						num3 = 1302326246;
						num4 = 1302326246;
					}
					num = num3 ^ (int)(num2 * 1965084804);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1276440680) ^ 0x216DB670);
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
			int num = -149447672;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x87804C24u) % 8u)
				{
				case 6u:
					num = (int)(num2 * 1214925398) ^ -1030685286;
					continue;
				case 5u:
					result = null;
					num = -791938382;
					continue;
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1664016257) ^ 0x7D209ED0;
						continue;
					}
					goto IL_0040;
				case 3u:
					result = null;
					num = (int)(num2 * 1124306993) ^ -1811443170;
					continue;
				case 1u:
					num = (int)(num2 * 930160203) ^ -251573219;
					continue;
				case 0u:
					if (aIndex < m_Dict.Count)
					{
						num = -1094527295;
						num3 = -1094527295;
						continue;
					}
					goto IL_0040;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_0040:
					num = -1239969465;
					num3 = -1239969465;
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
				_ = 1372817423;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x744D7770;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num * -298615736) ^ -1650175327;
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
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -772354782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A9D2F15u) % 3u)
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
							IL_0182:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -979270485;
								num4 = -979270485;
							}
							else
							{
								num3 = -1495627104;
								num4 = -1495627104;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8A9D2F15u) % 10u)
								{
								case 9u:
									num3 = (int)(num2 * 1467767518) ^ -1470780909;
									continue;
								case 8u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)((num2 * 849737450) ^ 0x6783F4F6);
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
									num3 = -193901077;
									continue;
								case 6u:
									num3 = -1495627104;
									continue;
								case 4u:
									num3 = ((int)num2 * -638684583) ^ 0xEE4B97E;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1336070749;
										num6 = -1336070749;
									}
									else
									{
										num5 = -1281167460;
										num6 = -1281167460;
									}
									num3 = num5 ^ ((int)num2 * -517599747);
									continue;
								}
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 1505702826) ^ 0x2BBAF968);
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1065225660;
									continue;
								default:
									goto end_IL_0138;
								case 5u:
									break;
								case 0u:
									goto end_IL_0138;
								}
								goto IL_0182;
								continue;
								end_IL_0138:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = -1363989869;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x8A9D2F15u) % 4u)
							{
							case 2u:
								result = text;
								num7 = (int)((num2 * 1949172548) ^ 0x39857214);
								continue;
							case 1u:
								num7 = ((int)num2 * -464923023) ^ -988871740;
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
				text = "{";
				num = (int)(num2 * 534990527) ^ -1141922169;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0172:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 351927964;
					num2 = 351927964;
				}
				else
				{
					num = 540539623;
					num2 = 540539623;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x58E44A80u) % 10u)
					{
					case 9u:
						flag = JSONClass.smethod_31(text) > 3;
						num = (int)(num3 * 1633937560) ^ -256596611;
						continue;
					case 8u:
						current = enumerator.Current;
						num = 1785570069;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -305981935;
							num5 = -305981935;
						}
						else
						{
							num4 = -1034577312;
							num5 = -1034577312;
						}
						num = num4 ^ ((int)num3 * -133469748);
						continue;
					}
					case 6u:
						num = 351927964;
						continue;
					case 3u:
						num = ((int)num3 * -2105405955) ^ -1908375765;
						continue;
					case 2u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						num = 1044395678;
						continue;
					case 1u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1900600649) ^ -1082175113;
						continue;
					case 0u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = (int)((num3 * 1809393057) ^ 0x7FD92DB5);
						continue;
					default:
						goto end_IL_0128;
					case 4u:
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
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num6 = 1157015971;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x58E44A80u) % 4u)
				{
				case 3u:
					result = text;
					num6 = ((int)num3 * -94730327) ^ -1815482555;
					continue;
				case 2u:
					num6 = ((int)num3 * -1868714724) ^ -106739523;
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
		string current = default(string);
		while (true)
		{
			int num = -1898510318;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA309A1C7u) % 4u)
				{
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 1581773334) ^ 0x78A46914);
					continue;
				case 1u:
					num = (int)(num2 * 255929077) ^ -1473532948;
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
								num3 = -266482595;
								num4 = -266482595;
							}
							else
							{
								num3 = -658466137;
								num4 = -658466137;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA309A1C7u) % 5u)
								{
								case 4u:
									current = enumerator.Current;
									JSONClass.smethod_38(aWriter, current);
									num3 = -1030478386;
									continue;
								case 2u:
									num3 = -658466137;
									continue;
								case 0u:
									m_Dict[current].Serialize(aWriter);
									num3 = (int)((num2 * 1105151442) ^ 0x751ED267);
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
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_0135:
							int num5 = -511381118;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xA309A1C7u) % 3u)
								{
								case 2u:
									goto IL_010b;
								default:
									goto end_IL_0118;
								case 0u:
									break;
								case 1u:
									goto end_IL_0118;
								}
								goto IL_0135;
								IL_010b:
								num5 = ((int)num2 * -1040771188) ^ 0x5C2781F0;
								continue;
								end_IL_0118:
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
			int num = 1203925204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72B6CE34u) % 3u)
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
				num = (int)((num2 * 1785891493) ^ 0x3A255C1C);
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
