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
				int num = 1034042024;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x21B359B9u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1629536634) ^ 0x5C143A46;
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 117086462;
							num5 = 117086462;
						}
						else
						{
							num4 = 241501485;
							num5 = 241501485;
						}
						num = num4 ^ (int)(num2 * 906042022);
						continue;
					}
					case 3u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1514767756) ^ -637866800;
						continue;
					case 2u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0060;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -183095837) ^ -1184885024;
							continue;
						}
						num3 = 1;
						goto IL_0060;
					case 0u:
						result = m_List[aIndex];
						num = 1571254190;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0060:
						flag = (byte)num3 != 0;
						num = 1718259991;
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
				int num = -411848472;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xF93A966Au) % 9u)
					{
					case 8u:
						num = ((int)num2 * -1473536969) ^ -1705834918;
						continue;
					case 7u:
						num = (int)(num2 * 156028729) ^ -262760823;
						continue;
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1571777806) ^ -1146907463;
							continue;
						}
						num3 = 1;
						goto IL_003e;
					case 3u:
						m_List.Add(value);
						num = (int)(num2 * 515647550) ^ -580738100;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 559660793;
							num5 = 559660793;
						}
						else
						{
							num4 = 1978677384;
							num5 = 1978677384;
						}
						num = num4 ^ (int)(num2 * 2002468515);
						continue;
					}
					case 1u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_003e;
					case 0u:
						m_List[aIndex] = value;
						num = -698439877;
						continue;
					default:
						return;
					case 5u:
						break;
					case 6u:
						return;
						IL_003e:
						flag = (byte)num3 != 0;
						num = -1400812845;
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
				int num = -1976559586;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB99F3AE6u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = new JSONLazyCreator(this);
					num = (int)(num2 * 1741184545) ^ -854097448;
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
				int num = -485869351;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9188A514u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -447630217) ^ -1952132322;
						continue;
					case 1u:
						count = m_List.Count;
						num = (int)(num2 * 1252883128) ^ -137320714;
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 490182812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C577FD3u) % 3u)
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
				num = (int)(num2 * 1310921899) ^ -408414091;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 886109723;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x3DF2BDB4u) % 8u)
				{
				case 7u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1008616320) ^ -475424832;
						continue;
					}
					goto IL_001c;
				case 6u:
					result = jSONNode;
					num = (int)((num2 * 1440758730) ^ 0x3659817B);
					continue;
				case 5u:
					jSONNode = m_List[aIndex];
					num = 1670772876;
					continue;
				case 4u:
					if (aIndex < m_List.Count)
					{
						num = 587277857;
						num3 = 587277857;
						continue;
					}
					goto IL_001c;
				case 1u:
					result = null;
					num = (int)((num2 * 1447558395) ^ 0x48D1A03C);
					continue;
				case 0u:
					m_List.RemoveAt(aIndex);
					num = (int)((num2 * 1034392497) ^ 0x5A80BDC2);
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					num = 436731589;
					num3 = 436731589;
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
			int num = -286554165;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5E91152u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1429203516) ^ -1317307550;
					continue;
				case 1u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -1487193595) ^ -479816363;
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
					num = -1464520201;
					num2 = -1464520201;
				}
				else
				{
					num = -1506043925;
					num2 = -1506043925;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xAA9C59B6u) % 8u)
					{
					case 6u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 1545454602) ^ 0x58632BD8);
						continue;
					case 4u:
						num = ((int)num3 * -1201411223) ^ 0x6F52689D;
						continue;
					case 3u:
						num = -1464520201;
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -1236461286;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -1874661514;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) <= 2)
						{
							num4 = -1003365212;
							num5 = -1003365212;
						}
						else
						{
							num4 = -227147856;
							num5 = -227147856;
						}
						num = num4 ^ (int)(num3 * 2037183785);
						continue;
					}
					default:
						goto end_IL_00a9;
					case 7u:
						break;
					case 5u:
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
				int num6 = -176505899;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xAA9C59B6u) % 3u)
					{
					case 2u:
						goto IL_0109;
					default:
						goto end_IL_0117;
					case 0u:
						break;
					case 1u:
						goto end_IL_0117;
					}
					goto IL_0135;
					IL_0109:
					num6 = (int)((num3 * 2037964834) ^ 0x46329D18);
					continue;
					end_IL_0117:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = default(string);
		while (true)
		{
			int num7 = -662116378;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xAA9C59B6u) % 3u)
				{
				case 2u:
					goto IL_014b;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_014b:
				result = string_;
				num7 = ((int)num3 * -101643725) ^ 0x1BE3CE76;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_010a:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1228341948;
					num2 = -1228341948;
				}
				else
				{
					num = -513696891;
					num2 = -513696891;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xFB500693u) % 8u)
					{
					case 6u:
						current = enumerator.Current;
						num = -297742738;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) > 3)
						{
							num4 = 1308002365;
							num5 = 1308002365;
						}
						else
						{
							num4 = 1188461598;
							num5 = 1188461598;
						}
						num = num4 ^ ((int)num3 * -933817556);
						continue;
					}
					case 3u:
						num = (int)(num3 * 935147212) ^ -291547917;
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 243435114) ^ 0x333F7496);
						continue;
					case 1u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = -624111352;
						continue;
					case 0u:
						num = -513696891;
						continue;
					default:
						goto end_IL_00c9;
					case 4u:
						break;
					case 7u:
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
		finally
		{
			((IDisposable)enumerator).Dispose();
			while (true)
			{
				IL_0155:
				int num6 = -1600141830;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xFB500693u) % 3u)
					{
					case 1u:
						goto IL_0129;
					default:
						goto end_IL_0137;
					case 0u:
						break;
					case 2u:
						goto end_IL_0137;
					}
					goto IL_0155;
					IL_0129:
					num6 = (int)((num3 * 1460124382) ^ 0x4E7AB177);
					continue;
					end_IL_0137:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = string_;
		while (true)
		{
			int num7 = -39392848;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xFB500693u) % 3u)
				{
				case 1u:
					goto IL_0174;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0174:
				num7 = ((int)num3 * -2146869028) ^ -2116888813;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = 1551889862;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2336EC35u) % 11u)
				{
				case 8u:
					flag = num3 < m_List.Count;
					num = 65920699;
					continue;
				case 7u:
					num = ((int)num2 * -2051541407) ^ 0x69F68689;
					continue;
				case 6u:
					num3++;
					num = (int)((num2 * 1582351854) ^ 0x38687463);
					continue;
				case 5u:
					num = (int)(num2 * 905229471) ^ -1077748287;
					continue;
				case 4u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1864593305) ^ 0x1D74C192;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1786418243;
						num5 = -1786418243;
					}
					else
					{
						num4 = -1807020038;
						num5 = -1807020038;
					}
					num = num4 ^ (int)(num2 * 1827277467);
					continue;
				}
				case 2u:
					num3 = 0;
					num = (int)(num2 * 627487275) ^ -856179068;
					continue;
				case 1u:
					m_List[num3].Serialize(aWriter);
					num = 724003078;
					continue;
				case 0u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -468440452) ^ -118605342;
					continue;
				default:
					return;
				case 9u:
					break;
				case 10u:
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
