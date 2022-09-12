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
				int num = -530788706;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF6257C73u) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1151349333) ^ 0x3D3DCC5D);
						continue;
					case 5u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1858168378) ^ 0x103DE70E;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1771905276;
							num4 = -1771905276;
						}
						else
						{
							num3 = -1675601765;
							num4 = -1675601765;
						}
						num = num3 ^ ((int)num2 * -89489969);
						continue;
					}
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = -714930404;
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1687572808) ^ 0x2B78B012;
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
			while (true)
			{
				int num = 1465608133;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2B24F7EFu) % 6u)
					{
					case 5u:
						num = (int)((num2 * 1057114431) ^ 0x57C19C0);
						continue;
					case 4u:
						m_Dict.Add(aKey, value);
						num = 64691591;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = 1823580185;
							num4 = 1823580185;
						}
						else
						{
							num3 = 1635452450;
							num4 = 1635452450;
						}
						num = num3 ^ ((int)num2 * -2102825834);
						continue;
					}
					case 1u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 20514844) ^ 0x3B1AE1CA);
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
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
				int num = 712723116;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x59C04A3Au) % 9u)
					{
					case 8u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -229524621) ^ -1062275418;
							continue;
						}
						num3 = 1;
						goto IL_001a;
					case 7u:
						num = (int)((num2 * 1541661363) ^ 0x7381BD3D);
						continue;
					case 6u:
						result = null;
						num = 1097075360;
						continue;
					case 5u:
						result = null;
						num = ((int)num2 * -1401220905) ^ 0x6231B325;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 949078785;
							num5 = 949078785;
						}
						else
						{
							num4 = 1573721626;
							num5 = 1573721626;
						}
						num = num4 ^ ((int)num2 * -1457193554);
						continue;
					}
					case 1u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					case 0u:
						num = (int)(num2 * 133184142) ^ -1974502889;
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_001a:
						flag = (byte)num3 != 0;
						num = 1194747280;
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
				goto IL_0007;
			}
			int num = 1;
			goto IL_0075;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
			IL_0007:
			int num2 = -1979987972;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEE760BF8u) % 5u)
				{
				case 4u:
					break;
				case 3u:
					num2 = ((int)num3 * -937416263) ^ -1647445880;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1338890164;
						num5 = -1338890164;
					}
					else
					{
						num4 = -1960174132;
						num5 = -1960174132;
					}
					num2 = num4 ^ ((int)num3 * -567806674);
					continue;
				}
				default:
					return;
				case 2u:
					goto IL_0064;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0007;
			IL_0075:
			flag = (byte)num != 0;
			num2 = -664721531;
			goto IL_003f;
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
				int num = -1140854146;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF6AA6D8Du) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 2092255038) ^ -638284139;
						continue;
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 167786783) ^ -1268033374;
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
			int num = 113061989;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C1182E5u) % 11u)
				{
				case 10u:
					num = 1324970490;
					continue;
				case 9u:
					m_Dict.Add(aKey, aItem);
					num = 534372989;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!m_Dict.ContainsKey(aKey))
					{
						num5 = -1484535999;
						num6 = -1484535999;
					}
					else
					{
						num5 = -434387490;
						num6 = -434387490;
					}
					num = num5 ^ ((int)num2 * -1149608847);
					continue;
				}
				case 7u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1740091391;
					continue;
				case 6u:
					num = (int)(num2 * 839284751) ^ -90887562;
					continue;
				case 5u:
					num = ((int)num2 * -1892250961) ^ -627201732;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1756545865;
						num4 = 1756545865;
					}
					else
					{
						num3 = 1155979199;
						num4 = 1155979199;
					}
					num = num3 ^ (int)(num2 * 1278914048);
					continue;
				}
				case 1u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 755266333) ^ -1577230386;
					continue;
				case 0u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -971236687) ^ -848265839;
					continue;
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

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 608067875;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F443354u) % 9u)
				{
				case 8u:
					m_Dict.Remove(aKey);
					num = ((int)num2 * -183578353) ^ 0x578DDAA2;
					continue;
				case 6u:
					result = null;
					num = (int)((num2 * 928848606) ^ 0x70B62689);
					continue;
				case 5u:
					num = (int)(num2 * 1699650436) ^ -583480373;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -317160525;
						num4 = -317160525;
					}
					else
					{
						num3 = -687981363;
						num4 = -687981363;
					}
					num = num3 ^ ((int)num2 * -1040103843);
					continue;
				}
				case 2u:
					result = jSONNode;
					num = (int)(num2 * 1143923547) ^ -1799569964;
					continue;
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 485418733) ^ -1394617841;
					continue;
				case 0u:
					jSONNode = m_Dict[aKey];
					num = 1720257050;
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -570055824;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x83F4E861u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 152702467;
						num5 = 152702467;
					}
					else
					{
						num4 = 710141087;
						num5 = 710141087;
					}
					num = num4 ^ (int)(num2 * 1604865538);
					continue;
				}
				case 6u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_003b;
				case 4u:
					result = null;
					num = -1142463981;
					continue;
				case 3u:
					num = ((int)num2 * -759381917) ^ -239183998;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1068458804) ^ 0x6EB502B);
						continue;
					}
					num3 = 1;
					goto IL_003b;
				case 0u:
					result = null;
					num = ((int)num2 * -891696169) ^ 0x1D9E012A;
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_003b:
					flag = (byte)num3 != 0;
					num = -1846482634;
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
				_ = 693028588;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x3B884655;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num * -204985257) ^ -1595822114;
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
			int num = -458913659;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD58E4C07u) % 4u)
				{
				case 2u:
					text = "{";
					num = (int)((num2 * 307516873) ^ 0x26D49250);
					continue;
				case 1u:
					num = ((int)num2 * -1224558363) ^ 0x1A0AEC91;
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
							IL_017d:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -768313471;
								num4 = -768313471;
							}
							else
							{
								num3 = -1205426563;
								num4 = -1205426563;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD58E4C07u) % 9u)
								{
								case 8u:
									num3 = -1205426563;
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
									num3 = -857106273;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 2)
									{
										num5 = -956137229;
										num6 = -956137229;
									}
									else
									{
										num5 = -1395397420;
										num6 = -1395397420;
									}
									num3 = num5 ^ (int)(num2 * 2064634189);
									continue;
								}
								case 3u:
									current = enumerator.Current;
									num3 = -1119084471;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 2369655) ^ -1789106056;
									continue;
								case 1u:
									num3 = ((int)num2 * -768845527) ^ 0x4BE1C19A;
									continue;
								case 0u:
									num3 = (int)(num2 * 1783246236) ^ -1806195791;
									continue;
								default:
									goto end_IL_0137;
								case 7u:
									break;
								case 5u:
									goto end_IL_0137;
								}
								goto IL_017d;
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
							IL_01c8:
							int num7 = -149467998;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xD58E4C07u) % 3u)
								{
								case 1u:
									goto IL_019c;
								default:
									goto end_IL_01aa;
								case 2u:
									break;
								case 0u:
									goto end_IL_01aa;
								}
								goto IL_01c8;
								IL_019c:
								num7 = (int)(num2 * 763193112) ^ -1329739547;
								continue;
								end_IL_01aa:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = -1799441072;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xD58E4C07u) % 4u)
							{
							case 3u:
								result = text;
								num8 = (int)((num2 * 663436413) ^ 0x1E0BFC8);
								continue;
							case 0u:
								num8 = ((int)num2 * -1437642937) ^ 0x3F5EF7FA;
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
		string text = "{ ";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string result = default(string);
		while (true)
		{
			int num = 1364650281;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x504B03E8u) % 3u)
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
							IL_0185:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 222676007;
								num4 = 222676007;
							}
							else
							{
								num3 = 2012796837;
								num4 = 2012796837;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x504B03E8u) % 9u)
								{
								case 7u:
									num3 = (int)(num2 * 534621276) ^ -1692656694;
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
									num3 = 142517598;
									continue;
								case 4u:
									num3 = 2012796837;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = 1584330031;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1461863381) ^ 0x3EC0EA10;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 3)
									{
										num5 = -131512628;
										num6 = -131512628;
									}
									else
									{
										num5 = -1873634276;
										num6 = -1873634276;
									}
									num3 = num5 ^ ((int)num2 * -1433422784);
									continue;
								}
								case 0u:
									num3 = ((int)num2 * -1027749281) ^ 0x2C75A1B5;
									continue;
								default:
									goto end_IL_013f;
								case 8u:
									break;
								case 6u:
									goto end_IL_013f;
								}
								goto IL_0185;
								continue;
								end_IL_013f:
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
							IL_01d0:
							int num7 = 782077087;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x504B03E8u) % 3u)
								{
								case 2u:
									goto IL_01a4;
								default:
									goto end_IL_01b2;
								case 0u:
									break;
								case 1u:
									goto end_IL_01b2;
								}
								goto IL_01d0;
								IL_01a4:
								num7 = ((int)num2 * -1381239250) ^ 0x239BB575;
								continue;
								end_IL_01b2:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = 1705424361;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x504B03E8u) % 4u)
							{
							case 3u:
								num8 = (int)((num2 * 736007790) ^ 0x529082E2);
								continue;
							case 1u:
								result = text;
								num8 = ((int)num2 * -506460606) ^ 0x582F26D9;
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
				IL_0008:
				num = ((int)num2 * -478142708) ^ 0x32767452;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = 1354474547;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23E66C92u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -38617585) ^ -1819799741;
					continue;
				case 2u:
					num = ((int)num2 * -2076829765) ^ 0x55BAB231;
					continue;
				case 0u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1622092109) ^ 0x7A017AB3;
					continue;
				case 3u:
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
							num3 = 1580667244;
							num4 = 1580667244;
						}
						else
						{
							num3 = 304436882;
							num4 = 304436882;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x23E66C92u) % 7u)
							{
							case 6u:
								current = enumerator.Current;
								num3 = 1413913790;
								continue;
							case 5u:
								num3 = 304436882;
								continue;
							case 4u:
								num3 = ((int)num2 * -175778456) ^ -1691480270;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1194588499) ^ 0x661787B4);
								continue;
							case 0u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -1613205606) ^ -112554880;
								continue;
							default:
								return;
							case 3u:
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
			int num = -1881629369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC41C9CBu) % 3u)
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
				num = ((int)num2 * -1858693465) ^ -861069174;
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
