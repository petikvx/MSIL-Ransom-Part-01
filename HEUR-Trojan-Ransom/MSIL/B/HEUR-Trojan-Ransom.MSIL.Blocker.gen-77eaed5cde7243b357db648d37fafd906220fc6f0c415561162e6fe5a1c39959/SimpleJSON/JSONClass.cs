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
				int num = 1086386157;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B1B09B7u) % 6u)
					{
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 1832621202) ^ -127159205;
						continue;
					case 2u:
						result = m_Dict[aKey];
						num = (int)((num2 * 1102201896) ^ 0x19B311E);
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = 765350734;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -295705636;
							num4 = -295705636;
						}
						else
						{
							num3 = -1221140283;
							num4 = -1221140283;
						}
						num = num3 ^ (int)(num2 * 1932076554);
						continue;
					}
					case 5u:
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
				int num = -1524108801;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE4C4303u) % 9u)
					{
					case 8u:
						m_Dict.Add(aKey, value);
						num = -1321492328;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1648290389;
							num4 = -1648290389;
						}
						else
						{
							num3 = -1234752756;
							num4 = -1234752756;
						}
						num = num3 ^ ((int)num2 * -2079873579);
						continue;
					}
					case 6u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -296762962) ^ 0x44397CDC;
						continue;
					case 4u:
						num = (int)(num2 * 176696820) ^ -1132560568;
						continue;
					case 3u:
						num = ((int)num2 * -341238174) ^ 0x3FD55371;
						continue;
					case 2u:
						num = (int)(num2 * 146109333) ^ -207126217;
						continue;
					case 0u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1601130308) ^ 0x7F25B513;
						continue;
					default:
						return;
					case 5u:
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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1437182342;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xECA77887u) % 8u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -395283168;
							num5 = -395283168;
						}
						else
						{
							num4 = -1759553347;
							num5 = -1759553347;
						}
						num = num4 ^ (int)(num2 * 432286445);
						continue;
					}
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 698299735) ^ 0xE1736BC);
							continue;
						}
						num3 = 1;
						goto IL_003e;
					case 4u:
						result = null;
						num = -1050294020;
						continue;
					case 3u:
						num = ((int)num2 * -1224121667) ^ -586836698;
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -638054457) ^ 0x637A056E;
						continue;
					case 0u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_003e;
					case 2u:
						break;
					default:
						{
							return result;
						}
						IL_003e:
						flag = (byte)num3 != 0;
						num = -1091544704;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0023;
			}
			goto IL_005c;
			IL_0023:
			int num = 778162651;
			goto IL_0028;
			IL_0028:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA03862u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1090667257) ^ 0x4B553287);
					continue;
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0049;
				case 3u:
					return;
				}
				break;
				IL_0049:
				if (aIndex < m_Dict.Count)
				{
					num = 790813433;
					num3 = 790813433;
					continue;
				}
				goto IL_005c;
			}
			goto IL_0023;
			IL_005c:
			num = 2077177228;
			num3 = 2077177228;
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
				int num = -495740818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBEC00DAu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_Dict.Count;
					num = ((int)num2 * -662497191) ^ -1374535254;
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
			int num = -1441651642;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD21B63EEu) % 14u)
				{
				case 13u:
					num = (int)((num2 * 1350011511) ^ 0x3E48C887);
					continue;
				case 12u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1591091692;
					continue;
				case 11u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1115569908) ^ 0x389BF6C1;
					continue;
				case 9u:
					num = (int)(num2 * 1280766145) ^ -765897882;
					continue;
				case 8u:
					m_Dict.Add(aKey, aItem);
					num = -178228385;
					continue;
				case 7u:
					num = (int)(num2 * 1494811566) ^ -132553359;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (m_Dict.ContainsKey(aKey))
					{
						num5 = 1773732309;
						num6 = 1773732309;
					}
					else
					{
						num5 = 487016572;
						num6 = 487016572;
					}
					num = num5 ^ (int)(num2 * 1276414009);
					continue;
				}
				case 5u:
					num = ((int)num2 * -243854374) ^ 0x1175BD96;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 226713501;
						num4 = 226713501;
					}
					else
					{
						num3 = 160138750;
						num4 = 160138750;
					}
					num = num3 ^ (int)(num2 * 576866432);
					continue;
				}
				case 3u:
					num = -937780181;
					continue;
				case 2u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 1398899976) ^ -1074335970;
					continue;
				case 1u:
					num = ((int)num2 * -238180916) ^ 0x7981CA67;
					continue;
				default:
					return;
				case 0u:
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
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -555473218;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0A35B39u) % 7u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -673576495) ^ -1648415184;
					continue;
				case 5u:
					num = ((int)num2 * -1055126748) ^ -1324116111;
					continue;
				case 3u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = -33059804;
					continue;
				}
				case 2u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 6401852) ^ 0x501B237D);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -137783236;
						num4 = -137783236;
					}
					else
					{
						num3 = -302565842;
						num4 = -302565842;
					}
					num = num3 ^ (int)(num2 * 1619730334);
					continue;
				}
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
			int num = 661375708;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x741F5607u) % 7u)
				{
				case 6u:
					result = null;
					num = (int)((num2 * 1949142303) ^ 0x21C8DD02);
					continue;
				case 5u:
					num = ((int)num2 * -1942097046) ^ 0x1CFD0B24;
					continue;
				case 4u:
					result = null;
					num = 1375449476;
					continue;
				case 3u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1927576243) ^ -1396378881;
						continue;
					}
					goto IL_0051;
				case 0u:
					if (aIndex < m_Dict.Count)
					{
						num = 1578102857;
						num3 = 1578102857;
						continue;
					}
					goto IL_0051;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0051:
					num = 1201049932;
					num3 = 1201049932;
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
		//IL_0036: Incompatible stack heights: 0 vs 1
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
				_ = 1238435721;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x5339CAF8;
					uint num = (uint)(int)val;
					switch (val % 4)
					{
					case 1:
						_ = (num * 1689033992) ^ 0xF31CB9D4u;
						continue;
					case 0:
						result = null;
						_ = (num * 64413583) ^ 0x8941C3FEu;
						continue;
					case 3:
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
		string text = "{";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 313671055;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x661BD9D1u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0158:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1295470310;
								num4 = 1295470310;
							}
							else
							{
								num3 = 968116170;
								num4 = 968116170;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x661BD9D1u) % 8u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = 915569360;
									continue;
								case 6u:
									num3 = 1295470310;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -367084894;
										num6 = -367084894;
									}
									else
									{
										num5 = -1755762556;
										num6 = -1755762556;
									}
									num3 = num5 ^ (int)(num2 * 774161307);
									continue;
								}
								case 4u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = 1818171433;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -367462419) ^ 0x24A7FF3F;
									continue;
								case 1u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -889668404) ^ -1635004176;
									continue;
								default:
									goto end_IL_0117;
								case 0u:
									break;
								case 3u:
									goto end_IL_0117;
								}
								goto IL_0158;
								continue;
								end_IL_0117:
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
							IL_01a3:
							int num7 = 215910346;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x661BD9D1u) % 3u)
								{
								case 1u:
									goto IL_0177;
								default:
									goto end_IL_0185;
								case 2u:
									break;
								case 0u:
									goto end_IL_0185;
								}
								goto IL_01a3;
								IL_0177:
								num7 = ((int)num2 * -1467701923) ^ 0x3D38E7A6;
								continue;
								end_IL_0185:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = 620083982;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x661BD9D1u) % 3u)
							{
							case 1u:
								goto IL_01b9;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_01b9:
							result = text;
							num8 = (int)((num2 * 138605387) ^ 0x21F05821);
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)((num2 * 396815389) ^ 0x330147ED);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num = 482739043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x569BF317u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0173:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 2066070945;
								num4 = 2066070945;
							}
							else
							{
								num3 = 1624281184;
								num4 = 1624281184;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x569BF317u) % 8u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = 859580623;
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
									num3 = 2009285852;
									continue;
								case 4u:
									num3 = 1624281184;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 970392893) ^ 0x4E717888);
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -786925123;
										num6 = -786925123;
									}
									else
									{
										num5 = -919287942;
										num6 = -919287942;
									}
									num3 = num5 ^ ((int)num2 * -35411705);
									continue;
								}
								case 0u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -1902352576) ^ -1599311042;
									continue;
								default:
									goto end_IL_0132;
								case 3u:
									break;
								case 6u:
									goto end_IL_0132;
								}
								goto IL_0173;
								continue;
								end_IL_0132:
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
							IL_01be:
							int num7 = 1918907269;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x569BF317u) % 3u)
								{
								case 1u:
									goto IL_0192;
								default:
									goto end_IL_01a0;
								case 2u:
									break;
								case 0u:
									goto end_IL_01a0;
								}
								goto IL_01be;
								IL_0192:
								num7 = (int)((num2 * 1134636022) ^ 0x68060816);
								continue;
								end_IL_01a0:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num8 = 552122982;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x569BF317u) % 3u)
							{
							case 2u:
								goto IL_01dd;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01dd:
							num8 = (int)(num2 * 1293662742) ^ -1317725321;
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{ ";
				num = (int)(num2 * 101873637) ^ -1941782643;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 525775225;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB16C264u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1686220485) ^ 0x4A145111);
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 2078870460) ^ 0x5D98BC36);
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
							num3 = 1139201791;
							num4 = 1139201791;
						}
						else
						{
							num3 = 1095446802;
							num4 = 1095446802;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xB16C264u) % 9u)
							{
							case 8u:
								num3 = (int)(num2 * 950730810) ^ -502760061;
								continue;
							case 6u:
								current = enumerator.Current;
								num3 = 1753528800;
								continue;
							case 4u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)(num2 * 207901583) ^ -751276985;
								continue;
							case 3u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1589391316) ^ -2026319242;
								continue;
							case 2u:
								num3 = (int)((num2 * 350537579) ^ 0x5FEFBE87);
								continue;
							case 1u:
								num3 = (int)(num2 * 1125362953) ^ -873651281;
								continue;
							case 0u:
								num3 = 1095446802;
								continue;
							default:
								return;
							case 5u:
								break;
							case 7u:
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
