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
				int num = -1642889025;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9D2D1D3u) % 7u)
					{
					case 6u:
						result = new JSONLazyCreator(this, aKey);
						num = -904302500;
						continue;
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -685006976) ^ -115712141;
						continue;
					case 3u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1842005918) ^ -1375968214;
						continue;
					case 1u:
						num = (int)(num2 * 1860824626) ^ -1468577034;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2077084851;
							num4 = -2077084851;
						}
						else
						{
							num3 = -1284191775;
							num4 = -1284191775;
						}
						num = num3 ^ (int)(num2 * 681290003);
						continue;
					}
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = 1370092740;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x183DA98Eu) % 7u)
					{
					case 6u:
						num = (int)((num2 * 537468249) ^ 0x32739D71);
						continue;
					case 4u:
						num = ((int)num2 * -344336586) ^ -1098505357;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 439567989;
							num4 = 439567989;
						}
						else
						{
							num3 = 959337120;
							num4 = 959337120;
						}
						num = num3 ^ (int)(num2 * 749271184);
						continue;
					}
					case 1u:
						m_Dict.Add(aKey, value);
						num = 421690216;
						continue;
					case 0u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 2023532499) ^ 0x250ED70A);
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1223982581;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1BEC8B3Fu) % 7u)
					{
					case 6u:
						result = null;
						num = ((int)num2 * -370406930) ^ 0x283C5D58;
						continue;
					case 4u:
						if (aIndex < m_Dict.Count)
						{
							num = 2097423961;
							num3 = 2097423961;
							continue;
						}
						goto IL_002a;
					case 2u:
						result = null;
						num = 1348183825;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1825528015) ^ 0x1D41E7D2;
							continue;
						}
						goto IL_002a;
					case 0u:
						num = (int)(num2 * 1124497231) ^ -1656238986;
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_002a:
						num = 2129650510;
						num3 = 2129650510;
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
				int num = 108547842;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x113220D4u) % 5u)
					{
					case 4u:
						if (aIndex < m_Dict.Count)
						{
							num = 204973445;
							num3 = 204973445;
							continue;
						}
						goto IL_0016;
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1860606729) ^ -43655106;
							continue;
						}
						goto IL_0016;
					case 1u:
						num = (int)(num2 * 344061997) ^ -473855740;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
						IL_0016:
						num = 386361073;
						num3 = 386361073;
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
				int num = 45014616;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x18BB1B6Cu) % 3u)
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
					num = ((int)num2 * -732260008) ^ 0x68FACE9A;
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
		bool flag = !JSONClass.smethod_30(aKey);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1242787450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51D715C9u) % 11u)
				{
				case 10u:
					num = (int)(num2 * 1528336672) ^ -1405111708;
					continue;
				case 9u:
					num = ((int)num2 * -956744386) ^ 0x3B027605;
					continue;
				case 6u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -778644440) ^ -1371029604;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 2130264046;
						num6 = 2130264046;
					}
					else
					{
						num5 = 1165238340;
						num6 = 1165238340;
					}
					num = num5 ^ (int)(num2 * 1176341003);
					continue;
				}
				case 4u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1830351979;
					continue;
				case 3u:
					num = 1830351979;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = -18056240;
						num4 = -18056240;
					}
					else
					{
						num3 = -1879296005;
						num4 = -1879296005;
					}
					num = num3 ^ (int)(num2 * 1164701986);
					continue;
				}
				case 1u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1149642935) ^ 0x4AD39FEA;
					continue;
				case 0u:
					m_Dict.Add(aKey, aItem);
					num = 1892194931;
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
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 713358816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BE45C04u) % 8u)
				{
				case 7u:
					m_Dict.Remove(aKey);
					num = ((int)num2 * -711280090) ^ 0x70CC3418;
					continue;
				case 6u:
					result = jSONNode;
					num = (int)((num2 * 1650844326) ^ 0x4107C2F9);
					continue;
				case 5u:
					jSONNode = m_Dict[aKey];
					num = 1001983635;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 311079801;
						num4 = 311079801;
					}
					else
					{
						num3 = 484766199;
						num4 = 484766199;
					}
					num = num3 ^ (int)(num2 * 167213168);
					continue;
				}
				case 3u:
					result = null;
					num = ((int)num2 * -1614658161) ^ -461240927;
					continue;
				case 0u:
					num = (int)(num2 * 31658871) ^ -475360747;
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1921343359;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x98F49A88u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1716380866;
						num5 = -1716380866;
					}
					else
					{
						num4 = -1698714984;
						num5 = -1698714984;
					}
					num = num4 ^ ((int)num2 * -1914277200);
					continue;
				}
				case 6u:
					num = (int)((num2 * 1012812528) ^ 0x4A11A8EE);
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 95820056) ^ -1664624393;
						continue;
					}
					num3 = 1;
					goto IL_004d;
				case 4u:
					result = null;
					num = -58246421;
					continue;
				case 3u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_004d;
				case 2u:
					num = (int)(num2 * 817718118) ^ -286355380;
					continue;
				case 1u:
					result = null;
					num = (int)((num2 * 1560747105) ^ 0x7B5653DD);
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_004d:
					flag = (byte)num3 != 0;
					num = -1656856764;
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
		//IL_0032: Incompatible stack heights: 0 vs 1
		//IL_0039: Incompatible stack heights: 0 vs 1
		try
		{
			return null;
		}
		catch
		{
			while (true)
			{
				_ = -1730261462;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -585757153;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						_ = ((int)num * -1377358987) ^ -1758852461;
						continue;
					case 0:
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
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
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
			int num = -1691503176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA7B246A5u) % 4u)
				{
				case 1u:
					text = "{";
					num = (int)(num2 * 776088317) ^ -714104180;
					continue;
				case 0u:
					num = (int)(num2 * 668281227) ^ -1144948525;
					continue;
				case 3u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0182:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -362973687;
								num4 = -362973687;
							}
							else
							{
								num3 = -368384639;
								num4 = -368384639;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA7B246A5u) % 9u)
								{
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 2044330143) ^ 0x3BA7CB34);
									continue;
								case 6u:
									num3 = ((int)num2 * -606370099) ^ -1321030292;
									continue;
								case 5u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = (int)(num2 * 1896440294) ^ -256720556;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1389890788;
										num6 = -1389890788;
									}
									else
									{
										num5 = -1658418477;
										num6 = -1658418477;
									}
									num3 = num5 ^ ((int)num2 * -305921787);
									continue;
								}
								case 2u:
									num3 = -368384639;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -5515258;
									continue;
								case 0u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -1535045586;
									continue;
								default:
									goto end_IL_013c;
								case 4u:
									break;
								case 8u:
									goto end_IL_013c;
								}
								goto IL_0182;
								continue;
								end_IL_013c:
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
							IL_01cd:
							int num7 = -1687172182;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xA7B246A5u) % 3u)
								{
								case 2u:
									goto IL_01a1;
								default:
									goto end_IL_01af;
								case 0u:
									break;
								case 1u:
									goto end_IL_01af;
								}
								goto IL_01cd;
								IL_01a1:
								num7 = (int)(num2 * 1583998854) ^ -883188184;
								continue;
								end_IL_01af:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = -1522823552;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xA7B246A5u) % 4u)
							{
							case 3u:
								num8 = (int)((num2 * 391636452) ^ 0x76455ACD);
								continue;
							case 1u:
								result = text;
								num8 = ((int)num2 * -17093345) ^ -1508598655;
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
				break;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = default(string);
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -2128570155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D58FFF7u) % 4u)
				{
				case 2u:
					text = "{ ";
					num = (int)((num2 * 1900204396) ^ 0x151CEFCE);
					continue;
				case 1u:
					num = (int)(num2 * 1765026408) ^ -1352730332;
					continue;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_018d:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1388251457;
								num4 = -1388251457;
							}
							else
							{
								num3 = -20809180;
								num4 = -20809180;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9D58FFF7u) % 8u)
								{
								case 7u:
									num3 = -20809180;
									continue;
								case 5u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -1131983539) ^ -473260310;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 300617966;
										num6 = 300617966;
									}
									else
									{
										num5 = 2097923573;
										num6 = 2097923573;
									}
									num3 = num5 ^ (int)(num2 * 766857314);
									continue;
								}
								case 3u:
									current = enumerator.Current;
									num3 = -645584014;
									continue;
								case 2u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = -554698967;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1678290258) ^ -985042397;
									continue;
								default:
									goto end_IL_014c;
								case 6u:
									break;
								case 0u:
									goto end_IL_014c;
								}
								goto IL_018d;
								continue;
								end_IL_014c:
								break;
							}
							break;
						}
					}
					return JSONClass.smethod_35(text, "\n", aPrefix, "}");
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
			int num = -160584035;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE309403u) % 5u)
				{
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 1604152408) ^ -1981289125;
					continue;
				case 1u:
					num = ((int)num2 * -1877132240) ^ 0x673D2FBE;
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 694257101) ^ -740802241;
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
						if (!enumerator.MoveNext())
						{
							num3 = -118294422;
							num4 = -118294422;
						}
						else
						{
							num3 = -1008522903;
							num4 = -1008522903;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xEE309403u) % 7u)
							{
							case 6u:
								current = enumerator.Current;
								num3 = -1873321893;
								continue;
							case 5u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1034961555) ^ 0xAD7F2B9);
								continue;
							case 4u:
								num3 = -1008522903;
								continue;
							case 3u:
								num3 = (int)(num2 * 1659257482) ^ -1007610034;
								continue;
							case 0u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -87849144) ^ 0x1845EE7D;
								continue;
							default:
								return;
							case 1u:
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
