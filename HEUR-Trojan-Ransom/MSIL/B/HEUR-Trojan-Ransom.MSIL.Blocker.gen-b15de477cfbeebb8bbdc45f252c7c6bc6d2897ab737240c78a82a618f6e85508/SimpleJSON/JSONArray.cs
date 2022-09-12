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
			if (aIndex >= 0)
			{
				goto IL_001e;
			}
			int num = 1;
			goto IL_00bd;
			IL_00ac:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00bd;
			IL_001e:
			int num2 = 893668329;
			goto IL_007b;
			IL_007b:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x47937397u) % 8u)
				{
				case 7u:
					result = m_List[aIndex];
					num2 = 1243227990;
					continue;
				case 5u:
					break;
				case 4u:
					num2 = (int)(num3 * 499221644) ^ -263434497;
					continue;
				case 3u:
					result = new JSONLazyCreator(this);
					num2 = (int)((num3 * 8047042) ^ 0x57C2F8FD);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1001445914;
						num5 = 1001445914;
					}
					else
					{
						num4 = 2089481726;
						num5 = 2089481726;
					}
					num2 = num4 ^ (int)(num3 * 161313793);
					continue;
				}
				case 1u:
					num2 = (int)((num3 * 296428080) ^ 0x6AA15E5F);
					continue;
				case 6u:
					goto IL_00ac;
				default:
					return result;
				}
				break;
			}
			goto IL_001e;
			IL_00bd:
			flag = (byte)num != 0;
			num2 = 2048411885;
			goto IL_007b;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0055;
			}
			goto IL_00bc;
			IL_0055:
			int num = 1963280720;
			goto IL_0078;
			IL_0078:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BA4745Au) % 8u)
				{
				case 6u:
					m_List[aIndex] = value;
					num = 1238273667;
					continue;
				case 5u:
					num = ((int)num2 * -764975483) ^ 0x712BF3AC;
					continue;
				case 4u:
					m_List.Add(value);
					num = (int)(num2 * 992592650) ^ -1737068342;
					continue;
				case 3u:
					break;
				case 1u:
					num = (int)((num2 * 280426384) ^ 0x7115F65D);
					continue;
				case 0u:
					num = (int)((num2 * 9031495) ^ 0x747966F);
					continue;
				default:
					return;
				case 2u:
					goto IL_00a9;
				case 7u:
					return;
				}
				break;
				IL_00a9:
				if (aIndex < m_List.Count)
				{
					num = 865865700;
					num3 = 865865700;
					continue;
				}
				goto IL_00bc;
			}
			goto IL_0055;
			IL_00bc:
			num = 556308918;
			num3 = 556308918;
			goto IL_0078;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			return new JSONLazyCreator(this);
		}
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = -1693449385;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA58AAED0u) % 3u)
					{
					case 2u:
						goto IL_000e;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000e:
					num = ((int)num2 * -464108557) ^ -868598641;
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
				int num = -698835443;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA97EA65Au) % 4u)
					{
					case 3u:
						count = m_List.Count;
						num = ((int)num2 * -24217652) ^ 0x4E4743F8;
						continue;
					case 2u:
						num = (int)((num2 * 1544761184) ^ 0x728D7A17);
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 368108739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A30F8F6u) % 4u)
				{
				case 1u:
					m_List.Add(aItem);
					num = ((int)num2 * -2039075649) ^ 0x5DB14D65;
					continue;
				case 0u:
					num = ((int)num2 * -1914749624) ^ -1372727947;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -765172429;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF9ACB359u) % 9u)
				{
				case 8u:
					result = null;
					num = (int)((num2 * 1585118346) ^ 0x288BE864);
					continue;
				case 6u:
					result = jSONNode;
					num = ((int)num2 * -1464720810) ^ 0x325AF46B;
					continue;
				case 5u:
					if (aIndex < m_List.Count)
					{
						num = -991806715;
						num3 = -991806715;
						continue;
					}
					goto IL_004a;
				case 4u:
					m_List.RemoveAt(aIndex);
					num = (int)((num2 * 1460465151) ^ 0x712E6338);
					continue;
				case 3u:
					num = (int)((num2 * 930538888) ^ 0x79128C28);
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 1261901936) ^ -1635130300;
						continue;
					}
					goto IL_004a;
				case 1u:
					jSONNode = m_List[aIndex];
					num = -150310989;
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_004a:
					num = -414979817;
					num3 = -414979817;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1974525015;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BF49D0Du) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1141569189) ^ -773935597;
					continue;
				case 2u:
					result = aNode;
					num = (int)((num2 * 596164237) ^ 0x3009DBD0);
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
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1274347715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6A3C7Eu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0109:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1200968384;
								num4 = 1200968384;
							}
							else
							{
								num3 = 273252042;
								num4 = 273252042;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC6A3C7Eu) % 7u)
								{
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1576154870;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = 1028506773;
										num6 = 1028506773;
									}
									else
									{
										num5 = 1990209051;
										num6 = 1990209051;
									}
									num3 = num5 ^ (int)(num2 * 666531090);
									continue;
								}
								case 3u:
									current = enumerator.Current;
									num3 = 1543424298;
									continue;
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1993298365) ^ -770124444;
									continue;
								case 0u:
									num3 = 273252042;
									continue;
								default:
									goto end_IL_00cc;
								case 1u:
									break;
								case 4u:
									goto end_IL_00cc;
								}
								goto IL_0109;
								continue;
								end_IL_00cc:
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
							IL_0154:
							int num7 = 1616300844;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xC6A3C7Eu) % 3u)
								{
								case 2u:
									goto IL_0128;
								default:
									goto end_IL_0136;
								case 0u:
									break;
								case 1u:
									goto end_IL_0136;
								}
								goto IL_0154;
								IL_0128:
								num7 = (int)(num2 * 771452921) ^ -133737123;
								continue;
								end_IL_0136:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = 827246528;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xC6A3C7Eu) % 3u)
							{
							case 1u:
								goto IL_016a;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_016a:
							result = string_;
							num8 = ((int)num2 * -609316846) ^ -1353459492;
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -509636017) ^ -1966850821;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1634703011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5C92110u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 734381161) ^ 0x7E2E1B6D);
					continue;
				case 1u:
					string_ = "[ ";
					num = (int)(num2 * 1299689657) ^ -703011605;
					continue;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0151:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -195178767;
								num4 = -195178767;
							}
							else
							{
								num3 = -1073648476;
								num4 = -1073648476;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB5C92110u) % 8u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)((num2 * 1088762043) ^ 0x23DDFEB5);
									continue;
								case 6u:
									num3 = -195178767;
									continue;
								case 5u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -260379385;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -771910727) ^ -1545938482;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -1523708227;
										num6 = -1523708227;
									}
									else
									{
										num5 = -1051726949;
										num6 = -1051726949;
									}
									num3 = num5 ^ (int)(num2 * 132215552);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = -1309328022;
									continue;
								default:
									goto end_IL_0110;
								case 0u:
									break;
								case 4u:
									goto end_IL_0110;
								}
								goto IL_0151;
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
							IL_019c:
							int num7 = -14207690;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xB5C92110u) % 3u)
								{
								case 1u:
									goto IL_0170;
								default:
									goto end_IL_017e;
								case 0u:
									break;
								case 2u:
									goto end_IL_017e;
								}
								goto IL_019c;
								IL_0170:
								num7 = ((int)num2 * -1250539287) ^ -734871988;
								continue;
								end_IL_017e:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num8 = -461886153;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xB5C92110u) % 4u)
							{
							case 3u:
								result = string_;
								num8 = ((int)num2 * -788964934) ^ -91831896;
								continue;
							case 2u:
								num8 = (int)((num2 * 2092998222) ^ 0x20AD165);
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
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1419671481;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF8D88E70u) % 11u)
				{
				case 9u:
					m_List[num3].Serialize(aWriter);
					num = -894814374;
					continue;
				case 8u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 2019342714) ^ 0x5B68365A);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2070696445;
						num5 = -2070696445;
					}
					else
					{
						num4 = -1496849572;
						num5 = -1496849572;
					}
					num = num4 ^ ((int)num2 * -2124620437);
					continue;
				}
				case 5u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -258318298) ^ -1628122282;
					continue;
				case 4u:
					flag = num3 < m_List.Count;
					num = -1659119083;
					continue;
				case 3u:
					num = ((int)num2 * -1140254444) ^ -1202429150;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 38600673) ^ 0x6B308F0F);
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -414985522) ^ 0x76FE7B61;
					continue;
				case 0u:
					num = ((int)num2 * -1073665657) ^ 0x6D864D7C;
					continue;
				default:
					return;
				case 10u:
					break;
				case 7u:
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
			int num = -854724861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA231B868u) % 3u)
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
				num = (int)(num2 * 1296564598) ^ -1177128835;
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
