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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1530886934;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x27964254u) % 8u)
					{
					case 7u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0017;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1580316401;
							num5 = -1580316401;
						}
						else
						{
							num4 = -1630469147;
							num5 = -1630469147;
						}
						num = num4 ^ ((int)num2 * -875225390);
						continue;
					}
					case 3u:
						result = m_List[aIndex];
						num = 1176333164;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1200524788) ^ 0x7DA8121B);
							continue;
						}
						num3 = 1;
						goto IL_0017;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -2071353365) ^ -1755202741;
						continue;
					case 0u:
						num = (int)((num2 * 2047196603) ^ 0x5D41FB48);
						continue;
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num3 != 0;
						num = 452871153;
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
				goto IL_000a;
			}
			int num = 1;
			goto IL_009c;
			IL_009c:
			bool flag = (byte)num != 0;
			int num2 = 1438392423;
			goto IL_0062;
			IL_000a:
			num2 = 1251592265;
			goto IL_0062;
			IL_0062:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x71E14194u) % 6u)
				{
				case 5u:
					break;
				case 2u:
					m_List.Add(value);
					num2 = ((int)num3 * -854540810) ^ 0x26757F70;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1137810364;
						num5 = -1137810364;
					}
					else
					{
						num4 = -563239806;
						num5 = -563239806;
					}
					num2 = num4 ^ (int)(num3 * 366771584);
					continue;
				}
				case 0u:
					m_List[aIndex] = value;
					num2 = 779310480;
					continue;
				default:
					return;
				case 3u:
					goto IL_008b;
				case 4u:
					return;
				}
				break;
			}
			goto IL_000a;
			IL_008b:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_009c;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 557647243;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EAB0FF4u) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 2061871721) ^ 0x72EA311A);
						continue;
					case 1u:
						num = ((int)num2 * -1498396372) ^ 0x266EF562;
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
				int num = 662033962;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6FFC787Cu) % 3u)
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
					m_List.Add(value);
					num = (int)(num2 * 824034732) ^ -164965517;
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
				int num = -2663302;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFC91893u) % 3u)
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
					count = m_List.Count;
					num = (int)(num2 * 632827906) ^ -227117686;
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
				int num = 313235730;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4812E085u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -429060332) ^ 0x64FC23C8;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 1779618695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AE63DB3u) % 3u)
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
				num = ((int)num2 * -322203214) ^ -1112516828;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -88254507;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEC89AE10u) % 7u)
				{
				case 6u:
					result = jSONNode;
					num = ((int)num2 * -1814745353) ^ -117429204;
					continue;
				case 5u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = -38961858;
					continue;
				case 4u:
					result = null;
					num = (int)((num2 * 1460406075) ^ 0x1C5B1DEC);
					continue;
				case 3u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -137141230) ^ -1460236577;
						continue;
					}
					goto IL_006a;
				case 0u:
					if (aIndex < m_List.Count)
					{
						num = -1155655812;
						num3 = -1155655812;
						continue;
					}
					goto IL_006a;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_006a:
					num = -1322735146;
					num3 = -1322735146;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1988636116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41F10C00u) % 5u)
				{
				case 4u:
					result = aNode;
					num = (int)((num2 * 501074260) ^ 0x13842D);
					continue;
				case 2u:
					num = (int)(num2 * 1481046861) ^ -734071953;
					continue;
				case 1u:
					m_List.Remove(aNode);
					num = (int)(num2 * 97344513) ^ -1058778719;
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

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumerator_003Ed__14(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string string_ = "[ ";
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_00ea:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1757082204;
					num2 = -1757082204;
				}
				else
				{
					num = -1698921736;
					num2 = -1698921736;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xDB44FC79u) % 8u)
					{
					case 6u:
						num = (int)(num3 * 1958803152) ^ -1859238415;
						continue;
					case 5u:
						current = enumerator.Current;
						num = -748891249;
						continue;
					case 4u:
						num = -1757082204;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -869695658) ^ 0x2DA610F9;
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -415351066;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) > 2)
						{
							num4 = 827101138;
							num5 = 827101138;
						}
						else
						{
							num4 = 841694299;
							num5 = 841694299;
						}
						num = num4 ^ ((int)num3 * -1971008018);
						continue;
					}
					default:
						goto end_IL_00a9;
					case 7u:
						break;
					case 1u:
						goto end_IL_00a9;
					}
					goto IL_00ea;
					continue;
					end_IL_00a9:
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
				IL_0135:
				int num6 = -651001855;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xDB44FC79u) % 3u)
					{
					case 1u:
						goto IL_0109;
					default:
						goto end_IL_0117;
					case 2u:
						break;
					case 0u:
						goto end_IL_0117;
					}
					goto IL_0135;
					IL_0109:
					num6 = ((int)num3 * -117947601) ^ -271105968;
					continue;
					end_IL_0117:
					break;
				}
				break;
			}
		}
		return JSONArray.smethod_31(string_, " ]");
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -693841617;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8056F2CAu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1579405274) ^ -1991923670;
					continue;
				case 1u:
					string_ = "[ ";
					num = (int)((num2 * 1384133810) ^ 0x1F4504E2);
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
							IL_017f:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -805679720;
								num4 = -805679720;
							}
							else
							{
								num3 = -159289351;
								num4 = -159289351;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8056F2CAu) % 10u)
								{
								case 9u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 1546435102) ^ 0x7831FF09);
									continue;
								case 7u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -966438459) ^ -1617050713;
									continue;
								case 6u:
									num3 = -159289351;
									continue;
								case 5u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = ((int)num2 * -1893831364) ^ 0x1583EDD4;
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -2010327563;
									continue;
								case 2u:
									num3 = ((int)num2 * -1761693432) ^ -1931847516;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1681129837;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 2028471747;
										num6 = 2028471747;
									}
									else
									{
										num5 = 1054272165;
										num6 = 1054272165;
									}
									num3 = num5 ^ (int)(num2 * 93276348);
									continue;
								}
								default:
									goto end_IL_0135;
								case 8u:
									break;
								case 4u:
									goto end_IL_0135;
								}
								goto IL_017f;
								continue;
								end_IL_0135:
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
							IL_01ca:
							int num7 = -732810275;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x8056F2CAu) % 3u)
								{
								case 1u:
									goto IL_019e;
								default:
									goto end_IL_01ac;
								case 2u:
									break;
								case 0u:
									goto end_IL_01ac;
								}
								goto IL_01ca;
								IL_019e:
								num7 = (int)(num2 * 1164318180) ^ -978976583;
								continue;
								end_IL_01ac:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num8 = -1856739860;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x8056F2CAu) % 3u)
							{
							case 1u:
								goto IL_01e6;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01e6:
							result = string_;
							num8 = (int)(num2 * 284815216) ^ -1183122651;
						}
					}
				}
				}
				break;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 851301872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1DFB543Du) % 10u)
				{
				case 9u:
					m_List[num5].Serialize(aWriter);
					num = (int)((num2 * 75868239) ^ 0x1B604FF2);
					continue;
				case 8u:
					num = (int)(num2 * 868534153) ^ -857759464;
					continue;
				case 6u:
					flag = num5 < m_List.Count;
					num = 1190813735;
					continue;
				case 5u:
					num5++;
					num = (int)(num2 * 6970832) ^ -872890807;
					continue;
				case 3u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num5 = 0;
					num = ((int)num2 * -351100945) ^ 0x4ADB02DA;
					continue;
				case 2u:
					num = 1988535620;
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 1704021018) ^ 0x23E1D5C2);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 163666289;
						num4 = 163666289;
					}
					else
					{
						num3 = 1443564089;
						num4 = 1443564089;
					}
					num = num3 ^ (int)(num2 * 162086939);
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 4u:
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
