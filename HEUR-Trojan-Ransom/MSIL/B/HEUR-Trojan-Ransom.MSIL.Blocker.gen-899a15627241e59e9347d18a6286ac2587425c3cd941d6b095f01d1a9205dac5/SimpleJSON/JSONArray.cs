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
				int num = 1968469087;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x45FB77E4u) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1399700351;
							num5 = 1399700351;
						}
						else
						{
							num4 = 987203103;
							num5 = 987203103;
						}
						num = num4 ^ (int)(num2 * 1916582999);
						continue;
					}
					case 7u:
						result = m_List[aIndex];
						num = 1236856322;
						continue;
					case 6u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1899846439) ^ 0x6202243D;
						continue;
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1301854902) ^ 0x5761896C);
							continue;
						}
						num3 = 1;
						goto IL_0068;
					case 2u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0068;
					case 1u:
						num = ((int)num2 * -1581579188) ^ 0x10023009;
						continue;
					case 0u:
						num = (int)((num2 * 1813007203) ^ 0x130F549B);
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0068:
						flag = (byte)num3 != 0;
						num = 1140941578;
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
				int num = -1481729524;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x96B08F5Bu) % 8u)
					{
					case 7u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1899213897) ^ -1632100110;
							continue;
						}
						goto IL_0028;
					case 6u:
						num = ((int)num2 * -1231555639) ^ 0x2FA577D9;
						continue;
					case 5u:
						m_List.Add(value);
						num = (int)(num2 * 445944349) ^ -824868679;
						continue;
					case 3u:
						num = (int)(num2 * 1962870797) ^ -2035939080;
						continue;
					case 1u:
						m_List[aIndex] = value;
						num = -1790928083;
						continue;
					case 0u:
						if (aIndex < m_List.Count)
						{
							num = -616194198;
							num3 = -616194198;
							continue;
						}
						goto IL_0028;
					default:
						return;
					case 2u:
						break;
					case 4u:
						return;
						IL_0028:
						num = -1722175890;
						num3 = -1722175890;
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
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = 113481794;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D471A09u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -545103187) ^ 0x4150B270;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 535718985;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77B58824u) % 3u)
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
					m_List.Add(value);
					num = ((int)num2 * -1266595378) ^ -1928880947;
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
				int num = -1434655008;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6EE0BD8u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_List.Count;
					num = (int)(num2 * 1861122660) ^ -1796231897;
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
				int num = -1360933025;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2841235u) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -676577553) ^ 0x75B3FF6E;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 982904607) ^ -437639494;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 2072926819;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E02D85Du) % 3u)
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
				num = (int)(num2 * 1455993348) ^ -891527321;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0057;
		}
		goto IL_00d4;
		IL_0057:
		int num = -1248089381;
		goto IL_008b;
		IL_008b:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9F663A38u) % 9u)
			{
			case 8u:
				result = jSONNode;
				num = (int)(num2 * 1143269509) ^ -2108866416;
				continue;
			case 7u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num = -830423531;
				continue;
			case 5u:
				num = (int)(num2 * 505635718) ^ -2091350608;
				continue;
			case 4u:
				break;
			case 3u:
				result = null;
				num = (int)((num2 * 2099468483) ^ 0x5B8AEC04);
				continue;
			case 2u:
				num = (int)(num2 * 1700358906) ^ -574190558;
				continue;
			case 0u:
				num = (int)((num2 * 217702989) ^ 0x6A454ED8);
				continue;
			case 6u:
				goto IL_00c1;
			default:
				return result;
			}
			break;
			IL_00c1:
			if (aIndex < m_List.Count)
			{
				num = -697730674;
				num3 = -697730674;
				continue;
			}
			goto IL_00d4;
		}
		goto IL_0057;
		IL_00d4:
		num = -280784534;
		num3 = -280784534;
		goto IL_008b;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1659376810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74066678u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 79574860) ^ 0x59286019);
					continue;
				case 2u:
					m_List.Remove(aNode);
					result = aNode;
					num = (int)((num2 * 1775722178) ^ 0x6B0FB6FB);
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
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
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
					num = 29415949;
					num2 = 29415949;
				}
				else
				{
					num = 164190132;
					num2 = 164190132;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x32030465u) % 8u)
					{
					case 7u:
						num = 164190132;
						continue;
					case 6u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = 820661534;
						continue;
					case 5u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 721523765) ^ 0x3414D4AA);
						continue;
					case 4u:
						flag = JSONArray.smethod_30(string_) > 2;
						num = (int)((num3 * 2146373777) ^ 0x33362923);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1458512442;
							num5 = -1458512442;
						}
						else
						{
							num4 = -15256427;
							num5 = -15256427;
						}
						num = num4 ^ (int)(num3 * 551416435);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num = 252466569;
						continue;
					default:
						goto end_IL_00ab;
					case 3u:
						break;
					case 0u:
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
		finally
		{
			((IDisposable)enumerator).Dispose();
			while (true)
			{
				IL_0137:
				int num6 = 1583524522;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x32030465u) % 3u)
					{
					case 1u:
						goto IL_010b;
					default:
						goto end_IL_0119;
					case 0u:
						break;
					case 2u:
						goto end_IL_0119;
					}
					goto IL_0137;
					IL_010b:
					num6 = ((int)num3 * -1261484584) ^ -1477293627;
					continue;
					end_IL_0119:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = default(string);
		while (true)
		{
			int num7 = 763081634;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x32030465u) % 3u)
				{
				case 2u:
					goto IL_014d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_014d:
				result = string_;
				num7 = (int)((num3 * 1388264099) ^ 0x61AC921E);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				IL_0135:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -448566856;
					num2 = -448566856;
				}
				else
				{
					num = -769450308;
					num2 = -769450308;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xA24DC469u) % 10u)
					{
					case 9u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -1038293833) ^ 0x3CC84C2C;
						continue;
					case 8u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = (int)(num3 * 173640835) ^ -1870127091;
						continue;
					case 7u:
						current = enumerator.Current;
						num = -1547843255;
						continue;
					case 6u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = ((int)num3 * -26018508) ^ -1987088795;
						continue;
					case 5u:
						num = -448566856;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1282871395;
							num5 = -1282871395;
						}
						else
						{
							num4 = -1502441602;
							num5 = -1502441602;
						}
						num = num4 ^ (int)(num3 * 985807647);
						continue;
					}
					case 2u:
						num = ((int)num3 * -27400019) ^ 0x435E32F2;
						continue;
					case 0u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = -756962665;
						continue;
					default:
						goto end_IL_00eb;
					case 1u:
						break;
					case 3u:
						goto end_IL_00eb;
					}
					goto IL_0135;
					continue;
					end_IL_00eb:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num6 = -2005957690;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xA24DC469u) % 3u)
				{
				case 1u:
					goto IL_0167;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0167:
				result = string_;
				num6 = (int)((num3 * 1008674523) ^ 0x6FCB2405);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		while (true)
		{
			int num = -290484001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7770666u) % 8u)
				{
				case 7u:
					m_List[num3].Serialize(aWriter);
					num = -1474418230;
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -351138471) ^ 0x285DBA33;
					continue;
				case 4u:
					num = (int)((num2 * 43968517) ^ 0x7B095694);
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = -1292560685;
						num4 = -1292560685;
					}
					else
					{
						num = -1460490687;
						num4 = -1460490687;
					}
					continue;
				}
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -717868736) ^ 0x1C42966E;
					continue;
				case 0u:
					num3 = 0;
					num = (int)(num2 * 1441205692) ^ -1985561939;
					continue;
				default:
					return;
				case 2u:
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
