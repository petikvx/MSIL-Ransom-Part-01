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
				int num = 1916225974;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x48A95693u) % 8u)
					{
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 567621795;
							num5 = 567621795;
						}
						else
						{
							num4 = 864368200;
							num5 = 864368200;
						}
						num = num4 ^ (int)(num2 * 2131921598);
						continue;
					}
					case 5u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1471077388) ^ -800223916;
							continue;
						}
						num3 = 1;
						goto IL_003e;
					case 4u:
						num = (int)((num2 * 853470100) ^ 0x145DD395);
						continue;
					case 3u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_003e;
					case 2u:
						result = m_List[aIndex];
						num = 589829925;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 986391709) ^ -151480374;
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_003e:
						flag = (byte)num3 != 0;
						num = 1468967444;
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
				int num = 2126749310;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5808138Fu) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1800335958) ^ 0x3F20EC1C);
						continue;
					case 5u:
						m_List[aIndex] = value;
						num = 1044485314;
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1374974235) ^ 0xEA62929);
							continue;
						}
						goto IL_004b;
					case 1u:
						m_List.Add(value);
						num = (int)(num2 * 207644761) ^ -615115366;
						continue;
					case 0u:
						if (aIndex < m_List.Count)
						{
							num = 1268212893;
							num3 = 1268212893;
							continue;
						}
						goto IL_004b;
					default:
						return;
					case 2u:
						break;
					case 4u:
						return;
						IL_004b:
						num = 1508523543;
						num3 = 1508523543;
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
				int num = -1785017608;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96BF8585u) % 3u)
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
					num = ((int)num2 * -145994048) ^ 0x79F7E1FA;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1988228070;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C106918u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -2098935268) ^ 0x1808A861;
						continue;
					case 2u:
						m_List.Add(value);
						num = ((int)num2 * -723172374) ^ -790777097;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public override int Count => m_List.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 1889204893;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46AB4E02u) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1641696563) ^ -1567152321;
						continue;
					case 0u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 246864727) ^ 0x77C8668F);
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
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 212018638;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7C5CB77Cu) % 10u)
				{
				case 9u:
					m_List.RemoveAt(aIndex);
					num = ((int)num2 * -37543076) ^ 0x215E2148;
					continue;
				case 8u:
					result = jSONNode;
					num = ((int)num2 * -1879438797) ^ -361181735;
					continue;
				case 7u:
					jSONNode = m_List[aIndex];
					num = 1485367195;
					continue;
				case 6u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 1520881314) ^ -1407414717;
						continue;
					}
					goto IL_006e;
				case 4u:
					num = (int)((num2 * 1063855921) ^ 0x4D84061);
					continue;
				case 3u:
					if (aIndex < m_List.Count)
					{
						num = 1634760987;
						num3 = 1634760987;
						continue;
					}
					goto IL_006e;
				case 2u:
					result = null;
					num = (int)((num2 * 1151370676) ^ 0x40234FD6);
					continue;
				case 1u:
					num = (int)((num2 * 417028284) ^ 0x5378A8CF);
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_006e:
					num = 362822438;
					num3 = 362822438;
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
			int num = -1262141239;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF6145C5u) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000f:
				result = aNode;
				num = (int)((num2 * 508378664) ^ 0x4B82F3D1);
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string result = default(string);
		while (true)
		{
			int num = 1509385552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14161B30u) % 3u)
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
							IL_010a:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1780537801;
								num4 = 1780537801;
							}
							else
							{
								num3 = 250598446;
								num4 = 250598446;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x14161B30u) % 7u)
								{
								case 5u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 47881312;
										num6 = 47881312;
									}
									else
									{
										num5 = 889615820;
										num6 = 889615820;
									}
									num3 = num5 ^ (int)(num2 * 1577533111);
									continue;
								}
								case 4u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1439679;
									continue;
								case 3u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = 222133635;
									continue;
								case 2u:
									num3 = 250598446;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1357616986) ^ -186940349;
									continue;
								default:
									goto end_IL_00cd;
								case 0u:
									break;
								case 6u:
									goto end_IL_00cd;
								}
								goto IL_010a;
								continue;
								end_IL_00cd:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = 2029526195;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x14161B30u) % 3u)
							{
							case 1u:
								goto IL_0136;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0136:
							result = string_;
							num7 = (int)((num2 * 2037274244) ^ 0xE212755);
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)((num2 * 337187310) ^ 0xEF33D4C);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		while (true)
		{
			int num = 1808188820;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7151CD15u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 719851923) ^ -1348048085;
					continue;
				case 1u:
					string_ = "[ ";
					num = (int)((num2 * 746760796) ^ 0x4038AD1B);
					continue;
				case 3u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0169:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 2081604107;
								num4 = 2081604107;
							}
							else
							{
								num3 = 1019438769;
								num4 = 1019438769;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7151CD15u) % 9u)
								{
								case 8u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -1527219374;
										num6 = -1527219374;
									}
									else
									{
										num5 = -432121882;
										num6 = -432121882;
									}
									num3 = num5 ^ (int)(num2 * 1020894139);
									continue;
								}
								case 7u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 393856236;
									continue;
								case 6u:
									num3 = (int)((num2 * 208537739) ^ 0x47756422);
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 413007660;
									continue;
								case 2u:
									num3 = 2081604107;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -1594794473) ^ -1202416981;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -434515979) ^ -2124378783;
									continue;
								default:
									goto end_IL_0123;
								case 4u:
									break;
								case 3u:
									goto end_IL_0123;
								}
								goto IL_0169;
								continue;
								end_IL_0123:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num7 = 203064862;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x7151CD15u) % 3u)
							{
							case 1u:
								goto IL_019e;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019e:
							num7 = (int)(num2 * 1877344680) ^ -927627224;
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
			int num = 1932423257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5ADAA054u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -1905927834) ^ -862557016;
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -1390777871) ^ 0x7C3808CA;
					continue;
				case 7u:
					m_List[num3].Serialize(aWriter);
					num = 887594031;
					continue;
				case 6u:
					num = ((int)num2 * -1565108265) ^ 0x722AE888;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 946858927;
						num5 = 946858927;
					}
					else
					{
						num4 = 1014487411;
						num5 = 1014487411;
					}
					num = num4 ^ ((int)num2 * -81465226);
					continue;
				}
				case 3u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num3 = 0;
					num = (int)(num2 * 1421587347) ^ -720010419;
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1763394937) ^ -1390612992;
					continue;
				case 0u:
					flag = num3 < m_List.Count;
					num = 891877718;
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
