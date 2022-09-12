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
				int num = -373146047;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0DE28DFu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1198300359) ^ 0x8035613;
						continue;
					case 6u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 1322516807) ^ -668466172;
						continue;
					case 5u:
						result = m_Dict[aKey];
						num = ((int)num2 * -23693387) ^ 0x2C78C664;
						continue;
					case 4u:
						result = new JSONLazyCreator(this, aKey);
						num = -1101060864;
						continue;
					case 2u:
						num = ((int)num2 * -222645750) ^ -145755152;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 352273396;
							num4 = 352273396;
						}
						else
						{
							num3 = 1294630245;
							num4 = 1294630245;
						}
						num = num3 ^ ((int)num2 * -76206586);
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
			while (true)
			{
				int num = -1372163404;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC389324Bu) % 7u)
					{
					case 6u:
						num = (int)(num2 * 2119848980) ^ -1469880476;
						continue;
					case 5u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1229155136) ^ 0x641F93ED;
						continue;
					case 2u:
						num = (int)(num2 * 345410547) ^ -1935015903;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = -1986240035;
							num4 = -1986240035;
						}
						else
						{
							num3 = -870113861;
							num4 = -870113861;
						}
						num = num3 ^ ((int)num2 * -543668206);
						continue;
					}
					case 0u:
						m_Dict.Add(aKey, value);
						num = -1542800380;
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
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1538679569;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xFF3E9C14u) % 7u)
					{
					case 6u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -158124964) ^ 0x55209BC0;
							continue;
						}
						goto IL_0028;
					case 5u:
						if (aIndex < m_Dict.Count)
						{
							num = -1967855222;
							num3 = -1967855222;
							continue;
						}
						goto IL_0028;
					case 4u:
						result = null;
						num = -292145872;
						continue;
					case 3u:
						num = ((int)num2 * -251847088) ^ 0x2B61CF90;
						continue;
					case 2u:
						result = null;
						num = ((int)num2 * -1037105210) ^ -591689658;
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_0028:
						num = -110594532;
						num3 = -110594532;
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
				goto IL_003a;
			}
			int num = 1;
			goto IL_0075;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
			IL_003a:
			int num2 = -1791246165;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF1598767u) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 432828334;
						num5 = 432828334;
					}
					else
					{
						num4 = 335632967;
						num5 = 335632967;
					}
					num2 = num4 ^ (int)(num3 * 333999612);
					continue;
				}
				case 2u:
					num2 = (int)((num3 * 2133398218) ^ 0x5C28BC9E);
					continue;
				case 0u:
					break;
				default:
					return;
				case 3u:
					goto IL_0064;
				case 1u:
					return;
				}
				break;
			}
			goto IL_003a;
			IL_0075:
			flag = (byte)num != 0;
			num2 = -807594677;
			goto IL_003f;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -35998820;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD5B5CB6u) % 3u)
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
					num = (int)(num2 * 1600914517) ^ -1667947996;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			while (true)
			{
				int num = -839598528;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB88DABDu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -2011797648) ^ 0x7E64F430;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 709768787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39473B8u) % 13u)
				{
				case 12u:
					num = 1466636703;
					continue;
				case 11u:
					num = (int)((num2 * 520764612) ^ 0x3B0EEE24);
					continue;
				case 10u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 357629067;
					continue;
				case 9u:
					num = (int)(num2 * 86463641) ^ -194427801;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1584988686;
						num6 = 1584988686;
					}
					else
					{
						num5 = 815542108;
						num6 = 815542108;
					}
					num = num5 ^ (int)(num2 * 1021914896);
					continue;
				}
				case 7u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 497909736) ^ 0x5F422B44);
					continue;
				case 5u:
					m_Dict.Add(aKey, aItem);
					num = 2105734084;
					continue;
				case 4u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 1891331909) ^ -1584697961;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (m_Dict.ContainsKey(aKey))
					{
						num3 = 1172508434;
						num4 = 1172508434;
					}
					else
					{
						num3 = 941166590;
						num4 = 941166590;
					}
					num = num3 ^ (int)(num2 * 1592244058);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1791465903) ^ 0x560A79AD;
					continue;
				case 0u:
					num = (int)((num2 * 641471639) ^ 0x178E6D80);
					continue;
				default:
					return;
				case 6u:
					break;
				case 1u:
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
		int num = 276565474;
		goto IL_0075;
		IL_0075:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x11B04EF6u) % 8u)
			{
			case 7u:
				break;
			case 4u:
				m_Dict.Remove(aKey);
				num = (int)((num2 * 1815487648) ^ 0x1794104F);
				continue;
			case 3u:
				num = (int)((num2 * 1976641741) ^ 0x2FFC060F);
				continue;
			case 2u:
				result = null;
				num = ((int)num2 * -1880728969) ^ 0x4B5C991B;
				continue;
			case 1u:
				result = jSONNode;
				num = (int)((num2 * 887106879) ^ 0x2BDB87E9);
				continue;
			case 0u:
				num = ((int)num2 * -1784917558) ^ -286244840;
				continue;
			case 5u:
				goto IL_00a6;
			default:
				return result;
			}
			break;
		}
		goto IL_0014;
		IL_0014:
		num = 877282164;
		goto IL_0075;
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0066;
		}
		int num = 1;
		goto IL_00ad;
		IL_009c:
		num = ((aIndex >= m_Dict.Count) ? 1 : 0);
		goto IL_00ad;
		IL_0066:
		int num2 = 1492256220;
		goto IL_006b;
		IL_006b:
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x61CCB91Au) % 8u)
			{
			case 5u:
				num2 = (int)(num3 * 402166786) ^ -1210060705;
				continue;
			case 4u:
				num2 = ((int)num3 * -801757778) ^ 0x480244BD;
				continue;
			case 3u:
				result = null;
				num2 = 1262866183;
				continue;
			case 2u:
				result = null;
				num2 = ((int)num3 * -602704517) ^ 0xE996478;
				continue;
			case 1u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -837008383;
					num5 = -837008383;
				}
				else
				{
					num4 = -1827859184;
					num5 = -1827859184;
				}
				num2 = num4 ^ (int)(num3 * 892964153);
				continue;
			}
			case 0u:
				break;
			case 6u:
				goto IL_009c;
			default:
				return result;
			}
			break;
		}
		goto IL_0066;
		IL_00ad:
		flag = (byte)num != 0;
		num2 = 489413211;
		goto IL_006b;
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
				_ = -63043053;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -1230132746;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = (num * 228461552) ^ 0xB8E9B07Du;
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
		while (true)
		{
			int num = 1945936675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53F24770u) % 4u)
				{
				case 3u:
					text = "{";
					num = (int)((num2 * 587393780) ^ 0x65BF6244);
					continue;
				case 0u:
					num = (int)(num2 * 641421180) ^ -775624283;
					continue;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_017a:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1707323299;
								num4 = 1707323299;
							}
							else
							{
								num3 = 1562056016;
								num4 = 1562056016;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x53F24770u) % 9u)
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
									num3 = 214663088;
									continue;
								case 7u:
									current = enumerator.Current;
									num3 = 2008993769;
									continue;
								case 5u:
									num3 = ((int)num2 * -498563977) ^ -296269772;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 2)
									{
										num5 = -83271875;
										num6 = -83271875;
									}
									else
									{
										num5 = -1787427289;
										num6 = -1787427289;
									}
									num3 = num5 ^ (int)(num2 * 597553363);
									continue;
								}
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1568747736) ^ -1008568148;
									continue;
								case 1u:
									num3 = (int)((num2 * 1313201096) ^ 0x6D3182BD);
									continue;
								case 0u:
									num3 = 1562056016;
									continue;
								default:
									goto end_IL_0134;
								case 2u:
									break;
								case 6u:
									goto end_IL_0134;
								}
								goto IL_017a;
								continue;
								end_IL_0134:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num7 = 2073504815;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x53F24770u) % 3u)
							{
							case 1u:
								goto IL_01a9;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01a9:
							num7 = (int)((num2 * 940801330) ^ 0x28BB50EB);
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
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 1725726230;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x583C7D6Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_019b:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 236198423;
								num4 = 236198423;
							}
							else
							{
								num3 = 936509494;
								num4 = 936509494;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x583C7D6Eu) % 10u)
								{
								case 9u:
									num3 = (int)((num2 * 252674839) ^ 0x3F3EF2EF);
									continue;
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
									num3 = 588909593;
									continue;
								case 7u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 622008250;
										num6 = 622008250;
									}
									else
									{
										num5 = 60555799;
										num6 = 60555799;
									}
									num3 = num5 ^ ((int)num2 * -2083496186);
									continue;
								}
								case 6u:
									num3 = 936509494;
									continue;
								case 3u:
									num3 = ((int)num2 * -1309598121) ^ 0x28D63761;
									continue;
								case 2u:
									current = enumerator.Current;
									num3 = 1133817247;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 562442605) ^ -124793873;
									continue;
								case 0u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -1289442015) ^ 0x3E940539;
									continue;
								default:
									goto end_IL_0151;
								case 4u:
									break;
								case 5u:
									goto end_IL_0151;
								}
								goto IL_019b;
								continue;
								end_IL_0151:
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
							IL_01e6:
							int num7 = 346665836;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x583C7D6Eu) % 3u)
								{
								case 1u:
									goto IL_01ba;
								default:
									goto end_IL_01c8;
								case 0u:
									break;
								case 2u:
									goto end_IL_01c8;
								}
								goto IL_01e6;
								IL_01ba:
								num7 = (int)(num2 * 742274740) ^ -695675766;
								continue;
								end_IL_01c8:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = 979899695;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x583C7D6Eu) % 4u)
							{
							case 2u:
								num8 = ((int)num2 * -2037029680) ^ 0x253B8666;
								continue;
							case 1u:
								result = text;
								num8 = ((int)num2 * -878021089) ^ -1611639945;
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
				IL_0008:
				num = ((int)num2 * -499557537) ^ -715860792;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -180708176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92E83E96u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2076945319) ^ 0x627361D8;
					continue;
				case 2u:
					JSONClass.smethod_36(aWriter, (byte)2);
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1391198192) ^ 0x4A67BE31;
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
						if (enumerator.MoveNext())
						{
							num3 = -926574249;
							num4 = -926574249;
						}
						else
						{
							num3 = -655197953;
							num4 = -655197953;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x92E83E96u) % 9u)
							{
							case 8u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 47776590) ^ 0x6BD38E04);
								continue;
							case 6u:
								current = enumerator.Current;
								num3 = -1417479645;
								continue;
							case 5u:
								num3 = -926574249;
								continue;
							case 4u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1151809258) ^ -959628030;
								continue;
							case 3u:
								num3 = (int)((num2 * 1601731822) ^ 0x4D03D348);
								continue;
							case 1u:
								num3 = (int)((num2 * 1976545737) ^ 0x621DFB77);
								continue;
							case 0u:
								num3 = ((int)num2 * -119676619) ^ 0x6A64AE7C;
								continue;
							default:
								return;
							case 7u:
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
