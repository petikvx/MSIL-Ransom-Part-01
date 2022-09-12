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
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = 181027003;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x45650B11u) % 9u)
					{
					case 7u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1987020954) ^ -101388241;
						continue;
					case 6u:
						result = m_List[aIndex];
						num = 721858406;
						continue;
					case 5u:
						num = (int)((num2 * 1525159245) ^ 0x6F69B59);
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1251315394;
							num5 = -1251315394;
						}
						else
						{
							num4 = -2124850681;
							num5 = -2124850681;
						}
						num = num4 ^ (int)(num2 * 380713554);
						continue;
					}
					case 3u:
						num = ((int)num2 * -1753282633) ^ 0x4F94F0CA;
						continue;
					case 2u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0086;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1490742004) ^ 0x7A963431);
							continue;
						}
						num3 = 1;
						goto IL_0086;
					case 8u:
						break;
					default:
						{
							return result;
						}
						IL_0086:
						flag = (byte)num3 != 0;
						num = 1246627749;
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
				int num = 551419237;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x53A5E13Au) % 9u)
					{
					case 7u:
						num = ((int)num2 * -427511173) ^ -254492137;
						continue;
					case 6u:
						num = ((int)num2 * -1075776266) ^ 0x86B4D63;
						continue;
					case 4u:
						m_List.Add(value);
						num = (int)((num2 * 341478763) ^ 0x496CD0FC);
						continue;
					case 3u:
						if (aIndex < m_List.Count)
						{
							num = 1463424102;
							num3 = 1463424102;
							continue;
						}
						goto IL_0055;
					case 2u:
						m_List[aIndex] = value;
						num = 1032315982;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 697294542) ^ 0xC74CE4D);
							continue;
						}
						goto IL_0055;
					case 0u:
						num = (int)((num2 * 209736261) ^ 0x7C8EA915);
						continue;
					default:
						return;
					case 8u:
						break;
					case 5u:
						return;
						IL_0055:
						num = 422202521;
						num3 = 422202521;
						continue;
					}
					break;
				}
			}
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 864511280;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B38BF5Fu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = new JSONLazyCreator(this);
					num = (int)((num2 * 2056322062) ^ 0x1590BAD3);
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
				int num = -127808036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8C64F39u) % 3u)
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
					count = m_List.Count;
					num = (int)((num2 * 1133492337) ^ 0x104B6ED0);
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -116508599;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD33424CFu) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -1140198866) ^ 0x6AA9D680;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -1193284601;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94F9BA85u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				m_List.Add(aItem);
				num = (int)((num2 * 1047224404) ^ 0x491D6717);
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex < 0)
		{
			goto IL_000a;
		}
		goto IL_0068;
		IL_0068:
		int num = 1968342836;
		goto IL_006d;
		IL_006d:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x32D0DA89u) % 7u)
			{
			case 6u:
				result = jSONNode;
				num = (int)(num2 * 1218811674) ^ -1255610818;
				continue;
			case 5u:
				result = null;
				num = (int)(num2 * 424945165) ^ -1281497470;
				continue;
			case 4u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num = 1546755276;
				continue;
			case 2u:
				num = (int)(num2 * 1576682986) ^ -1584761386;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_009a;
			default:
				return result;
			}
			break;
			IL_009a:
			if (aIndex < m_List.Count)
			{
				num = 821624821;
				num3 = 821624821;
				continue;
			}
			goto IL_000a;
		}
		goto IL_0068;
		IL_000a:
		num = 2136865083;
		num3 = 2136865083;
		goto IL_006d;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1917649110;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x248CC2C3u) % 4u)
				{
				case 1u:
					result = aNode;
					num = ((int)num2 * -683069011) ^ -1894226750;
					continue;
				case 0u:
					num = (int)((num2 * 121032219) ^ 0x796866CD);
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
		while (true)
		{
			int num = 2118610647;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B24CBC7u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_011f:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 2039624137;
								num4 = 2039624137;
							}
							else
							{
								num3 = 1326946674;
								num4 = 1326946674;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6B24CBC7u) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) > 2)
									{
										num5 = -1305833032;
										num6 = -1305833032;
									}
									else
									{
										num5 = -989702739;
										num6 = -989702739;
									}
									num3 = num5 ^ (int)(num2 * 1186741402);
									continue;
								}
								case 5u:
									current = enumerator.Current;
									num3 = 1415708829;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 615699852;
									continue;
								case 2u:
									num3 = ((int)num2 * -1834717025) ^ -214098266;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -157162247) ^ -1177427302;
									continue;
								case 0u:
									num3 = 1326946674;
									continue;
								default:
									goto end_IL_00de;
								case 3u:
									break;
								case 6u:
									goto end_IL_00de;
								}
								goto IL_011f;
								continue;
								end_IL_00de:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num7 = 1958366670;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x6B24CBC7u) % 3u)
							{
							case 2u:
								goto IL_014e;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_014e:
							num7 = (int)((num2 * 1695752735) ^ 0x2D3DA3A5);
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)((num2 * 1381946607) ^ 0x184FFFBB);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = 2132629155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13642A7Bu) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0156:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 708725573;
								num4 = 708725573;
							}
							else
							{
								num3 = 1524181197;
								num4 = 1524181197;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x13642A7Bu) % 9u)
								{
								case 8u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = ((int)num2 * -1712548623) ^ -332979715;
									continue;
								case 7u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -914658382) ^ -1633572433;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -619927732) ^ -1027058894;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 231729484;
										num6 = 231729484;
									}
									else
									{
										num5 = 2028962000;
										num6 = 2028962000;
									}
									num3 = num5 ^ (int)(num2 * 807543377);
									continue;
								}
								case 3u:
									current = enumerator.Current;
									num3 = 883172051;
									continue;
								case 1u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 1591612552;
									continue;
								case 0u:
									num3 = 708725573;
									continue;
								default:
									goto end_IL_0110;
								case 6u:
									break;
								case 2u:
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
							int num7 = 220162275;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x13642A7Bu) % 3u)
								{
								case 2u:
									goto IL_0175;
								default:
									goto end_IL_0183;
								case 0u:
									break;
								case 1u:
									goto end_IL_0183;
								}
								goto IL_01a1;
								IL_0175:
								num7 = (int)(num2 * 225524559) ^ -1507587447;
								continue;
								end_IL_0183:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_33(string_, "\n", aPrefix, "]");
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -1056595983) ^ -1957879125;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		JSONArray.smethod_35(aWriter, m_List.Count);
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 1705451593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BCA419Du) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -160336975;
						num5 = -160336975;
					}
					else
					{
						num4 = -1375407320;
						num5 = -1375407320;
					}
					num = num4 ^ ((int)num2 * -2113060623);
					continue;
				}
				case 5u:
					flag = num3 < m_List.Count;
					num = 928343642;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -1195991827) ^ -628570695;
					continue;
				case 3u:
					m_List[num3].Serialize(aWriter);
					num = 1287850220;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 673276056) ^ 0x51A313C8);
					continue;
				case 0u:
					num = (int)((num2 * 664701186) ^ 0x67290210);
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
