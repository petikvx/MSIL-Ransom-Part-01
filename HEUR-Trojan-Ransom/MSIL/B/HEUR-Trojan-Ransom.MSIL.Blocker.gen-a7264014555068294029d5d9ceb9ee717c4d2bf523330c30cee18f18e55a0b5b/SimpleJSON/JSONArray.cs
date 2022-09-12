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
				int num = -1823847406;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x908DE124u) % 8u)
					{
					case 7u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0017;
					case 6u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1367009079) ^ -1725799843;
							continue;
						}
						num5 = 1;
						goto IL_0017;
					case 4u:
						result = m_List[aIndex];
						num = -1719278066;
						continue;
					case 3u:
						num = (int)((num2 * 1452839664) ^ 0x7669F4DE);
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1904530999) ^ -1187872138;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 759285432;
							num4 = 759285432;
						}
						else
						{
							num3 = 183337701;
							num4 = 183337701;
						}
						num = num3 ^ (int)(num2 * 2113129677);
						continue;
					}
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num5 != 0;
						num = -707722068;
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
				int num = 1694215525;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x75418900u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1811121057) ^ 0x2563820E;
						continue;
					case 7u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -131445617) ^ -813744196;
							continue;
						}
						num3 = 1;
						goto IL_002c;
					case 5u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1665504603;
							num5 = -1665504603;
						}
						else
						{
							num4 = -1426620493;
							num5 = -1426620493;
						}
						num = num4 ^ (int)(num2 * 871525191);
						continue;
					}
					case 4u:
						m_List[aIndex] = value;
						num = 1254156633;
						continue;
					case 2u:
						m_List.Add(value);
						num = ((int)num2 * -327290540) ^ -355338656;
						continue;
					case 1u:
						num = ((int)num2 * -592003084) ^ -744958183;
						continue;
					case 0u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_002c;
					default:
						return;
					case 6u:
						break;
					case 3u:
						return;
						IL_002c:
						flag = (byte)num3 != 0;
						num = 1770054;
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
				int num = -30750015;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE71A7E4u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -633720609) ^ -1395361817;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1150111077) ^ 0x2BCC2226);
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
				int num = -1159825963;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF3246C30u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 536661348) ^ -2055382608;
						continue;
					case 1u:
						m_List.Add(value);
						num = ((int)num2 * -1345659637) ^ -1587838711;
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

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -396332884;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A86CDD5u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 2123221624) ^ -36673983;
						continue;
					case 1u:
						count = m_List.Count;
						num = (int)((num2 * 1093430531) ^ 0x7B0C6AE0);
						continue;
					case 3u:
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
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 2076650416;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x533CA468u) % 3u)
					{
					case 2u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -924851111) ^ 0x12A7B74C;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 1055774548;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BA91D0Eu) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				m_List.Add(aItem);
				num = ((int)num2 * -1422358821) ^ 0x6B442E8E;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 538686658;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x655EF236u) % 8u)
				{
				case 5u:
					num = ((int)num2 * -1815491232) ^ 0x3BC30910;
					continue;
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -480105008) ^ -1821594385;
						continue;
					}
					num3 = 1;
					goto IL_002c;
				case 3u:
					result = null;
					num = ((int)num2 * -930909276) ^ -867676836;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 877007802;
						num5 = 877007802;
					}
					else
					{
						num4 = 233101321;
						num5 = 233101321;
					}
					num = num4 ^ ((int)num2 * -1608205002);
					continue;
				}
				case 1u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_002c;
				case 0u:
				{
					JSONNode jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = 1429406451;
					continue;
				}
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_002c:
					flag = (byte)num3 != 0;
					num = 1329919332;
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
			int num = 1623713371;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F7DFB94u) % 4u)
				{
				case 3u:
					m_List.Remove(aNode);
					num = ((int)num2 * -1874220) ^ 0x38490471;
					continue;
				case 1u:
					result = aNode;
					num = (int)((num2 * 648661001) ^ 0x713746BB);
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
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CGetEnumerator_003Ed__14(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				IL_00ec:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1797275307;
					num2 = 1797275307;
				}
				else
				{
					num = 1950568725;
					num2 = 1950568725;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x22E31FC4u) % 8u)
					{
					case 6u:
						num = ((int)num3 * -60677246) ^ -565557012;
						continue;
					case 5u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = 660606458;
						continue;
					case 3u:
						num = 1950568725;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 142968610;
							num5 = 142968610;
						}
						else
						{
							num4 = 229839247;
							num5 = 229839247;
						}
						num = num4 ^ (int)(num3 * 414073967);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						flag = JSONArray.smethod_30(string_) > 2;
						num = 2006227310;
						continue;
					case 0u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -90366878) ^ -386941287;
						continue;
					default:
						goto end_IL_00ab;
					case 4u:
						break;
					case 7u:
						goto end_IL_00ab;
					}
					goto IL_00ec;
					continue;
					end_IL_00ab:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = string_;
		while (true)
		{
			int num6 = 1592056405;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x22E31FC4u) % 3u)
				{
				case 2u:
					goto IL_011b;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_011b:
				num6 = (int)((num3 * 71180261) ^ 0x26846595);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_010a:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 363125193;
					num2 = 363125193;
				}
				else
				{
					num = 1350196365;
					num2 = 1350196365;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x4BAD0618u) % 8u)
					{
					case 7u:
						num = ((int)num3 * -483460007) ^ 0x34B04E5B;
						continue;
					case 6u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = 369831351;
						continue;
					case 5u:
						current = enumerator.Current;
						num = 1090190016;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 297976621) ^ 0x4BE6A6D1);
						continue;
					case 2u:
						num = 1350196365;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) > 3)
						{
							num4 = 459523251;
							num5 = 459523251;
						}
						else
						{
							num4 = 970334846;
							num5 = 970334846;
						}
						num = num4 ^ (int)(num3 * 847958139);
						continue;
					}
					default:
						goto end_IL_00c9;
					case 4u:
						break;
					case 1u:
						goto end_IL_00c9;
					}
					goto IL_010a;
					continue;
					end_IL_00c9:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num6 = 85362966;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x4BAD0618u) % 4u)
				{
				case 2u:
					result = string_;
					num6 = (int)((num3 * 1192357829) ^ 0x4411D893);
					continue;
				case 1u:
					num6 = (int)(num3 * 850187676) ^ -162188861;
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
		int num3 = default(int);
		while (true)
		{
			int num = 1366665806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36B8B866u) % 11u)
				{
				case 10u:
					num3++;
					num = (int)(num2 * 1518489635) ^ -1232386471;
					continue;
				case 9u:
					m_List[num3].Serialize(aWriter);
					num = 236996437;
					continue;
				case 8u:
					num = (int)((num2 * 54792033) ^ 0x627749BE);
					continue;
				case 7u:
					num = (int)(num2 * 1966784266) ^ -1351610371;
					continue;
				case 4u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1597641319) ^ 0x1065D946);
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = 11988787;
						num4 = 11988787;
					}
					else
					{
						num = 263406852;
						num4 = 263406852;
					}
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)((num2 * 1024804611) ^ 0x62C28A8C);
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -786918843) ^ 0x41997AA0;
					continue;
				case 0u:
					num = (int)(num2 * 665014484) ^ -52325798;
					continue;
				default:
					return;
				case 6u:
					break;
				case 5u:
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
