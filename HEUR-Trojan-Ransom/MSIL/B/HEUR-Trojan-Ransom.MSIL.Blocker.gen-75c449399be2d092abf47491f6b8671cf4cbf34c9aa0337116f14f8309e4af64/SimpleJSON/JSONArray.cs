using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON;

public class JSONArray : JSONNode, IEnumerable
{
	private List<JSONNode> m_List = new List<JSONNode>();

	public override JSONNode this[int aIndex]
	{
		get
		{
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_003a;
			IL_003a:
			int num = 1125895367;
			goto IL_0064;
			IL_0064:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x766F6EAFu) % 7u)
				{
				case 6u:
					num = (int)(num2 * 699328690) ^ -568393846;
					continue;
				case 5u:
					result = m_List[aIndex];
					num = 246550593;
					continue;
				case 4u:
					break;
				case 2u:
					num = ((int)num2 * -680430349) ^ 0x7848F8CC;
					continue;
				case 0u:
					result = new JSONLazyCreator(this);
					num = (int)((num2 * 1010275650) ^ 0x9709C9);
					continue;
				case 1u:
					goto IL_0091;
				default:
					return result;
				}
				break;
				IL_0091:
				if (aIndex < m_List.Count)
				{
					num = 1434287181;
					num3 = 1434287181;
					continue;
				}
				goto IL_000a;
			}
			goto IL_003a;
			IL_000a:
			num = 2066375231;
			num3 = 2066375231;
			goto IL_0064;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0064;
			}
			goto IL_00a9;
			IL_0064:
			int num = -535926717;
			goto IL_0069;
			IL_0069:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBC40B08u) % 7u)
				{
				case 4u:
					m_List[aIndex] = value;
					num = -1344034383;
					continue;
				case 3u:
					num = (int)((num2 * 2092919512) ^ 0x2E26CB1F);
					continue;
				case 2u:
					m_List.Add(value);
					num = (int)(num2 * 1366695531) ^ -748914034;
					continue;
				case 1u:
					num = ((int)num2 * -755434363) ^ -68816206;
					continue;
				case 0u:
					break;
				default:
					return;
				case 6u:
					goto IL_0096;
				case 5u:
					return;
				}
				break;
				IL_0096:
				if (aIndex < m_List.Count)
				{
					num = -1815327529;
					num3 = -1815327529;
					continue;
				}
				goto IL_00a9;
			}
			goto IL_0064;
			IL_00a9:
			num = -272013116;
			num3 = -272013116;
			goto IL_0069;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -1540837990;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB6DC8BEEu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 1616723199) ^ 0x649CA1FC);
				}
			}
		}
		set
		{
			m_List.Add(value);
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 1472973663;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58DF51Du) % 4u)
					{
					case 2u:
						count = m_List.Count;
						num = (int)((num2 * 1992878701) ^ 0x5FF8CF5E);
						continue;
					case 1u:
						num = ((int)num2 * -1696763322) ^ 0x5D102A24;
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
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1242230484;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED9BD4F6u) % 3u)
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
					num = ((int)num2 * -1859249004) ^ -844434107;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -1523889189;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8808E86u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				m_List.Add(aItem);
				num = ((int)num2 * -1708995887) ^ -304578031;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0037;
		}
		goto IL_00ad;
		IL_0037:
		int num = 266551010;
		goto IL_006d;
		IL_006d:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x2631FEB8u) % 7u)
			{
			case 5u:
				num = (int)((num2 * 27816535) ^ 0x2DE10381);
				continue;
			case 4u:
				result = jSONNode;
				num = ((int)num2 * -779598370) ^ 0x78FD65B4;
				continue;
			case 2u:
				break;
			case 1u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num = 1586066173;
				continue;
			case 0u:
				result = null;
				num = ((int)num2 * -2109446759) ^ -1341372912;
				continue;
			case 3u:
				goto IL_009a;
			default:
				return result;
			}
			break;
			IL_009a:
			if (aIndex < m_List.Count)
			{
				num = 1218661914;
				num3 = 1218661914;
				continue;
			}
			goto IL_00ad;
		}
		goto IL_0037;
		IL_00ad:
		num = 215781309;
		num3 = 215781309;
		goto IL_006d;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1870570477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4F157964u) % 4u)
				{
				case 1u:
					result = aNode;
					num = (int)(num2 * 35733375) ^ -1829093809;
					continue;
				case 0u:
					num = (int)((num2 * 76151901) ^ 0x4B4B0D77);
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

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CGetEnumerator_003Ed__14(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string string_ = "[ ";
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 896592481;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51F0C7D1u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0136:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1972062702;
								num4 = 1972062702;
							}
							else
							{
								num3 = 2093243732;
								num4 = 2093243732;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x51F0C7D1u) % 9u)
								{
								case 8u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -2056169645) ^ -718702448;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = 2026268300;
									continue;
								case 4u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -809915635) ^ 0x3AD344C4;
									continue;
								case 3u:
									num3 = ((int)num2 * -257414263) ^ 0x3A4F0F58;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1234523408;
										num6 = 1234523408;
									}
									else
									{
										num5 = 1020843545;
										num6 = 1020843545;
									}
									num3 = num5 ^ (int)(num2 * 1966276359);
									continue;
								}
								case 1u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1250764700;
									continue;
								case 0u:
									num3 = 2093243732;
									continue;
								default:
									goto end_IL_00f0;
								case 5u:
									break;
								case 7u:
									goto end_IL_00f0;
								}
								goto IL_0136;
								continue;
								end_IL_00f0:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = 1469946895;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x51F0C7D1u) % 4u)
							{
							case 3u:
								num7 = ((int)num2 * -482946390) ^ -1739403702;
								continue;
							case 2u:
								result = string_;
								num7 = ((int)num2 * -95214358) ^ -1069046174;
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
				break;
				IL_0008:
				num = (int)(num2 * 294594299) ^ -681467468;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -1417955863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC34F8133u) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = ((int)num2 * -361027888) ^ -288149038;
					continue;
				case 1u:
					num = (int)((num2 * 484098264) ^ 0x7ABB4FCF);
					continue;
				case 3u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_016e:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1400760074;
								num4 = -1400760074;
							}
							else
							{
								num3 = -1610689050;
								num4 = -1610689050;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC34F8133u) % 9u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1263016837) ^ -957504122;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = -458761352;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -798039279;
										num6 = -798039279;
									}
									else
									{
										num5 = -2105828202;
										num6 = -2105828202;
									}
									num3 = num5 ^ ((int)num2 * -1132141752);
									continue;
								}
								case 4u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -1968395798) ^ -1621758737;
									continue;
								case 3u:
									num3 = -1400760074;
									continue;
								case 1u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = (int)((num2 * 1486214374) ^ 0x7BC4536C);
									continue;
								case 0u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -348863416;
									continue;
								default:
									goto end_IL_0128;
								case 2u:
									break;
								case 8u:
									goto end_IL_0128;
								}
								goto IL_016e;
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
							IL_01b9:
							int num7 = -1325319084;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xC34F8133u) % 3u)
								{
								case 1u:
									goto IL_018d;
								default:
									goto end_IL_019b;
								case 0u:
									break;
								case 2u:
									goto end_IL_019b;
								}
								goto IL_01b9;
								IL_018d:
								num7 = ((int)num2 * -2129820375) ^ 0x57D2C25A;
								continue;
								end_IL_019b:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_33(string_, "\n", aPrefix, "]");
				}
				}
				break;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -2078300728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1D86DD1u) % 12u)
				{
				case 11u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1465618760;
						num5 = -1465618760;
					}
					else
					{
						num4 = -1065865787;
						num5 = -1065865787;
					}
					num = num4 ^ ((int)num2 * -1454526086);
					continue;
				}
				case 10u:
					num = ((int)num2 * -1060268543) ^ 0x220316FB;
					continue;
				case 9u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -1436409531) ^ -2072696240;
					continue;
				case 8u:
					num = ((int)num2 * -1833336648) ^ -385148844;
					continue;
				case 7u:
					m_List[num3].Serialize(aWriter);
					num = -1750694990;
					continue;
				case 5u:
					num3 = 0;
					num = (int)((num2 * 191331436) ^ 0x5D7EE51F);
					continue;
				case 4u:
					num3++;
					num = (int)((num2 * 392934827) ^ 0x326F4657);
					continue;
				case 3u:
					num = (int)((num2 * 847558103) ^ 0x415A4A22);
					continue;
				case 2u:
					flag = num3 < m_List.Count;
					num = -377220134;
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -306562332) ^ 0x47F19070;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public JSONArray()
	{
		while (true)
		{
			int num = 51120106;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A88102Eu) % 3u)
				{
				case 2u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0013:
				num = ((int)num2 * -1962164685) ^ -1464802268;
			}
		}
	}

	static int smethod_30(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_31(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_32(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_33(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_34(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_35(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}
}
