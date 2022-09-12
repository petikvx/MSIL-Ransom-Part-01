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
				goto IL_000a;
			}
			int num = 1;
			goto IL_00aa;
			IL_0099:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00aa;
			IL_000a:
			int num2 = 1105517492;
			goto IL_006c;
			IL_006c:
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3C26EB77u) % 7u)
				{
				case 6u:
					break;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1983011452;
						num5 = -1983011452;
					}
					else
					{
						num4 = -489349143;
						num5 = -489349143;
					}
					num2 = num4 ^ (int)(num3 * 1205187830);
					continue;
				}
				case 2u:
					num2 = ((int)num3 * -127514773) ^ -1563820165;
					continue;
				case 1u:
					result = m_List[aIndex];
					num2 = 1990190134;
					continue;
				case 0u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -565259913) ^ -137333279;
					continue;
				case 4u:
					goto IL_0099;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_00aa:
			flag = (byte)num != 0;
			num2 = 718233025;
			goto IL_006c;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_006c;
			}
			int num = 1;
			goto IL_00af;
			IL_009e:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00af;
			IL_006c:
			int num2 = -869951959;
			goto IL_0071;
			IL_0071:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD278B5A8u) % 7u)
				{
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 878090037;
						num5 = 878090037;
					}
					else
					{
						num4 = 147511505;
						num5 = 147511505;
					}
					num2 = num4 ^ ((int)num3 * -484270074);
					continue;
				}
				case 4u:
					m_List.Add(value);
					num2 = ((int)num3 * -1125939653) ^ -327173453;
					continue;
				case 3u:
					m_List[aIndex] = value;
					num2 = -743065925;
					continue;
				case 1u:
					num2 = ((int)num3 * -1799643080) ^ 0x37D88EFC;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_009e;
				case 6u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_00af:
			flag = (byte)num != 0;
			num2 = -1991520948;
			goto IL_0071;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 829881086;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x54BB6BF2u) % 3u)
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
					num = ((int)num2 * -28157335) ^ 0x74B97A10;
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
				int num = -697042088;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA77DD75u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 677595050) ^ -1407833710;
						continue;
					case 1u:
						count = m_List.Count;
						num = (int)((num2 * 1373197988) ^ 0x43C802EB);
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
			while (true)
			{
				int num = -1305848285;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB799CF8Du) % 3u)
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
					num = ((int)num2 * -1030088582) ^ 0x44DDBC9A;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
	}

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1224095526;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x62244F87u) % 9u)
				{
				case 8u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -46779465;
						num5 = -46779465;
					}
					else
					{
						num4 = -1349951657;
						num5 = -1349951657;
					}
					num = num4 ^ (int)(num2 * 269131213);
					continue;
				}
				case 7u:
					result = jSONNode;
					num = (int)(num2 * 804809377) ^ -1592195984;
					continue;
				case 6u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_004c;
				case 5u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = 538131151;
					continue;
				case 4u:
					result = null;
					num = (int)(num2 * 1085377505) ^ -1392740047;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -214567079) ^ -1860242862;
						continue;
					}
					num3 = 1;
					goto IL_004c;
				case 1u:
					num = (int)((num2 * 331466505) ^ 0x5E75825A);
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_004c:
					flag = (byte)num3 != 0;
					num = 1038547059;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		while (true)
		{
			int num = 996500412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x34A9A441u) % 3u)
				{
				case 2u:
					goto IL_0011;
				case 0u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0011:
				num = (int)((num2 * 169402734) ^ 0x75A1AA49);
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
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 556426596;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x914E0E6u) % 3u)
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
							IL_013a:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1070716415;
								num4 = 1070716415;
							}
							else
							{
								num3 = 760263884;
								num4 = 760263884;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x914E0E6u) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = 2146534365;
									continue;
								case 7u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -246738807) ^ -928714697;
									continue;
								case 6u:
									num3 = ((int)num2 * -931295684) ^ 0x1734155E;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 934321710;
									continue;
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -410336698) ^ 0x3591D454;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 2097312182;
										num6 = 2097312182;
									}
									else
									{
										num5 = 714112375;
										num6 = 714112375;
									}
									num3 = num5 ^ (int)(num2 * 83609030);
									continue;
								}
								case 0u:
									num3 = 760263884;
									continue;
								default:
									goto end_IL_00f4;
								case 4u:
									break;
								case 5u:
									goto end_IL_00f4;
								}
								goto IL_013a;
								continue;
								end_IL_00f4:
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
							IL_0185:
							int num7 = 1623279173;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x914E0E6u) % 3u)
								{
								case 2u:
									goto IL_0159;
								default:
									goto end_IL_0167;
								case 0u:
									break;
								case 1u:
									goto end_IL_0167;
								}
								goto IL_0185;
								IL_0159:
								num7 = ((int)num2 * -1901502587) ^ -1511780511;
								continue;
								end_IL_0167:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num8 = 317956079;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x914E0E6u) % 3u)
							{
							case 1u:
								goto IL_019e;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_019e:
							num8 = ((int)num2 * -787912332) ^ 0x6A9F66D;
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)(num2 * 1892521136) ^ -1838532366;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			bool flag = default(bool);
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_0138:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 600255708;
					num2 = 600255708;
				}
				else
				{
					num = 1918628420;
					num2 = 1918628420;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xB25B1ABu) % 10u)
					{
					case 9u:
						num = ((int)num3 * -1326264015) ^ 0x3EBCFC46;
						continue;
					case 8u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -1467871441) ^ 0x593C31D1;
						continue;
					case 6u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = (int)((num3 * 328607948) ^ 0x4892C9AE);
						continue;
					case 5u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = (int)(num3 * 339388241) ^ -1449564353;
						continue;
					case 4u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = 1507112492;
						continue;
					case 3u:
						current = enumerator.Current;
						num = 443226279;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 772126828;
							num5 = 772126828;
						}
						else
						{
							num4 = 1878723174;
							num5 = 1878723174;
						}
						num = num4 ^ ((int)num3 * -1876118815);
						continue;
					}
					case 0u:
						num = 1918628420;
						continue;
					default:
						goto end_IL_00ee;
					case 2u:
						break;
					case 7u:
						goto end_IL_00ee;
					}
					goto IL_0138;
					continue;
					end_IL_00ee:
					break;
				}
				break;
			}
		}
		return JSONArray.smethod_33(string_, "\n", aPrefix, "]");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		while (true)
		{
			int num = -1306511027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8C0BFD8u) % 9u)
				{
				case 8u:
					num = -262705438;
					continue;
				case 7u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = -576119433;
						num4 = -576119433;
					}
					else
					{
						num = -774516571;
						num4 = -774516571;
					}
					continue;
				}
				case 5u:
					num3++;
					num = (int)((num2 * 1045469582) ^ 0x31F298B3);
					continue;
				case 4u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -1984853560) ^ -1672467153;
					continue;
				case 3u:
					num = ((int)num2 * -651207101) ^ -1005603449;
					continue;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 1590474510) ^ 0x8C7186B);
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 970967215) ^ -1667703773;
					continue;
				default:
					return;
				case 6u:
					break;
				case 0u:
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
