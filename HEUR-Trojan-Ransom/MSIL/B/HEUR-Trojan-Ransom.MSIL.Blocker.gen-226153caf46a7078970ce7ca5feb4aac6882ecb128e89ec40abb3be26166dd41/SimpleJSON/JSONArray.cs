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
				int num = -999578531;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xA77A901Bu) % 7u)
					{
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1577338905) ^ -564050222;
							continue;
						}
						num5 = 1;
						goto IL_001a;
					case 4u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_001a;
					case 3u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1710318945) ^ 0x2B8EC225);
						continue;
					case 2u:
						result = m_List[aIndex];
						num = -596994079;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 107370160;
							num4 = 107370160;
						}
						else
						{
							num3 = 234386791;
							num4 = 234386791;
						}
						num = num3 ^ (int)(num2 * 1371263941);
						continue;
					}
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_001a:
						flag = (byte)num5 != 0;
						num = -1836596285;
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
			goto IL_00c2;
			IL_00c2:
			bool flag = (byte)num != 0;
			int num2 = 1516304993;
			goto IL_0080;
			IL_000a:
			num2 = 1597691782;
			goto IL_0080;
			IL_0080:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3892A5C1u) % 8u)
				{
				case 6u:
					break;
				case 4u:
					num2 = ((int)num3 * -508358926) ^ 0x187E6A74;
					continue;
				case 3u:
					m_List[aIndex] = value;
					num2 = 1551338709;
					continue;
				case 2u:
					num2 = ((int)num3 * -993899019) ^ 0x1069EB76;
					continue;
				case 1u:
					m_List.Add(value);
					num2 = (int)((num3 * 1079863665) ^ 0x6534AB5A);
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -169682168;
						num5 = -169682168;
					}
					else
					{
						num4 = -1982742310;
						num5 = -1982742310;
					}
					num2 = num4 ^ ((int)num3 * -1308536937);
					continue;
				}
				default:
					return;
				case 7u:
					goto IL_00b1;
				case 5u:
					return;
				}
				break;
			}
			goto IL_000a;
			IL_00b1:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00c2;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -1189387371;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0333FFAu) % 3u)
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
					num = ((int)num2 * -1559851452) ^ 0x7ED4911;
				}
			}
		}
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = -1092967781;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5330B85u) % 3u)
					{
					case 1u:
						goto IL_000e;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000e:
					num = (int)((num2 * 1880230767) ^ 0x37227178);
				}
			}
		}
	}

	public override int Count
	{
		get
		{
			int count = m_List.Count;
			while (true)
			{
				int num = 695760345;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15884352u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = (int)((num2 * 1499214938) ^ 0x457837D3);
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			while (true)
			{
				int num = -831425444;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB6FC78Du) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -1269721078) ^ 0x2AFBCA7E;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -1770908233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C737253u) % 3u)
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
				num = ((int)num2 * -142638751) ^ -1883225757;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0036;
		}
		int num = 1;
		goto IL_00da;
		IL_00da:
		bool flag = (byte)num != 0;
		int num2 = 1137472545;
		goto IL_0093;
		IL_0036:
		num2 = 279278154;
		goto IL_0093;
		IL_0093:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x55A75274u) % 9u)
			{
			case 8u:
				num2 = (int)((num3 * 842219994) ^ 0x58CA745F);
				continue;
			case 7u:
				m_List.RemoveAt(aIndex);
				result = jSONNode;
				num2 = ((int)num3 * -410169690) ^ -897040781;
				continue;
			case 6u:
				break;
			case 5u:
				result = null;
				num2 = ((int)num3 * -1765487982) ^ 0x2679E9C8;
				continue;
			case 2u:
				num2 = (int)((num3 * 1857203005) ^ 0x4B998865);
				continue;
			case 1u:
				jSONNode = m_List[aIndex];
				num2 = 628655968;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -184560856;
					num5 = -184560856;
				}
				else
				{
					num4 = -479048626;
					num5 = -479048626;
				}
				num2 = num4 ^ ((int)num3 * -2061548844);
				continue;
			}
			case 3u:
				goto IL_00c9;
			default:
				return result;
			}
			break;
		}
		goto IL_0036;
		IL_00c9:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00da;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1902220531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4CC175Au) % 4u)
				{
				case 3u:
					m_List.Remove(aNode);
					num = ((int)num2 * -318015603) ^ 0x78253A1B;
					continue;
				case 2u:
					result = aNode;
					num = (int)(num2 * 1892049293) ^ -1742576875;
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
			bool flag = default(bool);
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_0101:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -851109557;
					num2 = -851109557;
				}
				else
				{
					num = -893972418;
					num2 = -893972418;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xF84F2399u) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 2051144182;
							num5 = 2051144182;
						}
						else
						{
							num4 = 880249671;
							num5 = 880249671;
						}
						num = num4 ^ ((int)num3 * -744552790);
						continue;
					}
					case 6u:
						current = enumerator.Current;
						num = -2043080829;
						continue;
					case 5u:
						flag = JSONArray.smethod_30(string_) > 2;
						num = (int)(num3 * 86739708) ^ -1460536224;
						continue;
					case 3u:
						num = -893972418;
						continue;
					case 2u:
						num = ((int)num3 * -16783946) ^ -416047349;
						continue;
					case 1u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -1790084117;
						continue;
					case 0u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 113295260) ^ 0x67CF5441);
						continue;
					default:
						goto end_IL_00bb;
					case 4u:
						break;
					case 7u:
						goto end_IL_00bb;
					}
					goto IL_0101;
					continue;
					end_IL_00bb:
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
				IL_014c:
				int num6 = -957509756;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xF84F2399u) % 3u)
					{
					case 2u:
						goto IL_0120;
					default:
						goto end_IL_012e;
					case 0u:
						break;
					case 1u:
						goto end_IL_012e;
					}
					goto IL_014c;
					IL_0120:
					num6 = ((int)num3 * -227621484) ^ 0x7CC37251;
					continue;
					end_IL_012e:
					break;
				}
				break;
			}
		}
		return JSONArray.smethod_31(string_, " ]");
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_011f:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1178093018;
					num2 = -1178093018;
				}
				else
				{
					num = -1757545069;
					num2 = -1757545069;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xEC76F87Au) % 9u)
					{
					case 8u:
						num = (int)((num3 * 1389598061) ^ 0x1EA613CC);
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) <= 3)
						{
							num4 = -356612200;
							num5 = -356612200;
						}
						else
						{
							num4 = -1105488056;
							num5 = -1105488056;
						}
						num = num4 ^ ((int)num3 * -1861621327);
						continue;
					}
					case 4u:
						num = -1757545069;
						continue;
					case 3u:
						num = ((int)num3 * -221831256) ^ -1815328832;
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 507241731) ^ 0xE685C8A);
						continue;
					case 1u:
						current = enumerator.Current;
						num = -2013939383;
						continue;
					case 0u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = -1181563756;
						continue;
					default:
						goto end_IL_00d9;
					case 7u:
						break;
					case 6u:
						goto end_IL_00d9;
					}
					goto IL_011f;
					continue;
					end_IL_00d9:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = string_;
		while (true)
		{
			int num6 = -441216641;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xEC76F87Au) % 3u)
				{
				case 1u:
					goto IL_0154;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0154:
				num6 = ((int)num3 * -1959710870) ^ -1627901681;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 1072890027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DE404CDu) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1823118680) ^ 0x59BF24FF;
					continue;
				case 9u:
					num3 = 0;
					num = (int)((num2 * 1397061459) ^ 0x5BA9B67F);
					continue;
				case 7u:
					num = ((int)num2 * -1651418952) ^ 0x2F3B0BD5;
					continue;
				case 6u:
					num = 1769659317;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = 1378510353;
						num4 = 1378510353;
					}
					else
					{
						num = 1159610721;
						num4 = 1159610721;
					}
					continue;
				}
				case 3u:
					num3++;
					num = (int)((num2 * 147846633) ^ 0x274D29D7);
					continue;
				case 2u:
					m_List[num3].Serialize(aWriter);
					num = (int)((num2 * 846803462) ^ 0x291A5134);
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -874942975) ^ -1199023897;
					continue;
				case 0u:
					num = ((int)num2 * -928859090) ^ 0x185C7A88;
					continue;
				default:
					return;
				case 4u:
					break;
				case 8u:
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
