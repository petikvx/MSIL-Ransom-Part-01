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
				int num = -1805902881;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xA8EE956Eu) % 8u)
					{
					case 6u:
						num = (int)((num2 * 571050343) ^ 0x367A6AAB);
						continue;
					case 5u:
						result = m_List[aIndex];
						num = -274910231;
						continue;
					case 4u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 20219912) ^ -283152672;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1684521794;
							num5 = -1684521794;
						}
						else
						{
							num4 = -789139121;
							num5 = -789139121;
						}
						num = num4 ^ ((int)num2 * -1740209532);
						continue;
					}
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 192308513) ^ 0x8EBF477);
							continue;
						}
						num3 = 1;
						goto IL_0077;
					case 0u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0077;
					case 2u:
						break;
					default:
						{
							return result;
						}
						IL_0077:
						flag = (byte)num3 != 0;
						num = -1496935443;
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
				int num = 728624872;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x20943103u) % 10u)
					{
					case 8u:
						m_List[aIndex] = value;
						num = 669034894;
						continue;
					case 7u:
						num = (int)(num2 * 151017402) ^ -62232793;
						continue;
					case 5u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0040;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1389690193;
							num5 = 1389690193;
						}
						else
						{
							num4 = 295407569;
							num5 = 295407569;
						}
						num = num4 ^ (int)(num2 * 2074131685);
						continue;
					}
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1996020430) ^ 0xD63C678;
							continue;
						}
						num3 = 1;
						goto IL_0040;
					case 2u:
						m_List.Add(value);
						num = ((int)num2 * -442770210) ^ -2034004588;
						continue;
					case 1u:
						num = (int)(num2 * 1157333136) ^ -270837408;
						continue;
					case 0u:
						num = ((int)num2 * -1600668523) ^ 0x68C89262;
						continue;
					default:
						return;
					case 6u:
						break;
					case 9u:
						return;
						IL_0040:
						flag = (byte)num3 != 0;
						num = 1430125911;
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
				int num = 2017771288;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1687D36Du) % 4u)
					{
					case 2u:
						num = (int)(num2 * 866852364) ^ -340595363;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1711545441) ^ -1126231346;
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
				int num = -629357435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEED4850u) % 3u)
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
					num = (int)((num2 * 212214600) ^ 0x7169BBD0);
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
			int num = -616789690;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC69E7D6Du) % 3u)
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
				num = (int)(num2 * 1051875580) ^ -1673276462;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 870746777;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x65684C86u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1755664804) ^ 0x3A5F8A65;
					continue;
				case 8u:
					jSONNode = m_List[aIndex];
					num = 956518104;
					continue;
				case 7u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0040;
				case 5u:
					m_List.RemoveAt(aIndex);
					num = (int)(num2 * 1399467465) ^ -1183934290;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1550431073;
						num5 = -1550431073;
					}
					else
					{
						num4 = -1192824253;
						num5 = -1192824253;
					}
					num = num4 ^ (int)(num2 * 1733622830);
					continue;
				}
				case 3u:
					result = null;
					num = (int)((num2 * 1236349725) ^ 0x6DC81833);
					continue;
				case 2u:
					num = ((int)num2 * -2134763839) ^ 0x3134141B;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -569668841) ^ -496668487;
						continue;
					}
					num3 = 1;
					goto IL_0040;
				case 0u:
					result = jSONNode;
					num = (int)(num2 * 490773475) ^ -1472385330;
					continue;
				case 9u:
					break;
				default:
					{
						return result;
					}
					IL_0040:
					flag = (byte)num3 != 0;
					num = 322556789;
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
			int num = 1768369434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x445E6315u) % 4u)
				{
				case 3u:
					m_List.Remove(aNode);
					num = ((int)num2 * -1469298736) ^ 0x73E3DEE0;
					continue;
				case 1u:
					result = aNode;
					num = ((int)num2 * -1228275945) ^ 0x5CA0107C;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string result = default(string);
		while (true)
		{
			int num = 1226958232;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2654471Au) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_014d:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 502204392;
								num4 = 502204392;
							}
							else
							{
								num3 = 1150916435;
								num4 = 1150916435;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x2654471Au) % 10u)
								{
								case 8u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = (int)(num2 * 1006096149) ^ -1415608983;
									continue;
								case 7u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1291121457) ^ 0x64E9CEED;
									continue;
								case 6u:
									num3 = 502204392;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 216577280;
										num6 = 216577280;
									}
									else
									{
										num5 = 1284428121;
										num6 = 1284428121;
									}
									num3 = num5 ^ (int)(num2 * 1823471733);
									continue;
								}
								case 4u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 429736150;
									continue;
								case 3u:
									num3 = (int)(num2 * 531733473) ^ -1109430353;
									continue;
								case 2u:
									current = enumerator.Current;
									num3 = 1873166715;
									continue;
								case 0u:
									num3 = ((int)num2 * -727653200) ^ -1930971525;
									continue;
								default:
									goto end_IL_0103;
								case 1u:
									break;
								case 9u:
									goto end_IL_0103;
								}
								goto IL_014d;
								continue;
								end_IL_0103:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = 464065243;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x2654471Au) % 3u)
							{
							case 1u:
								goto IL_0179;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0179:
							result = string_;
							num7 = ((int)num2 * -1325765857) ^ -575591790;
						}
					}
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -1716706426) ^ -1675777681;
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
					num = 1721260269;
					num2 = 1721260269;
				}
				else
				{
					num = 917683433;
					num2 = 917683433;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x5461DDD6u) % 10u)
					{
					case 7u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = (int)((num3 * 184951827) ^ 0x3BEAE48A);
						continue;
					case 6u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = (int)((num3 * 1194229830) ^ 0x1537FE76);
						continue;
					case 5u:
						num = 1721260269;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1287294842;
							num5 = 1287294842;
						}
						else
						{
							num4 = 899834676;
							num5 = 899834676;
						}
						num = num4 ^ (int)(num3 * 75926819);
						continue;
					}
					case 3u:
						num = ((int)num3 * -1787416074) ^ -2120565338;
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 87552358) ^ 0x51DA19AA);
						continue;
					case 1u:
						current = enumerator.Current;
						num = 908936348;
						continue;
					case 0u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = 1949631319;
						continue;
					default:
						goto end_IL_00eb;
					case 8u:
						break;
					case 9u:
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
			int num6 = 436657696;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x5461DDD6u) % 4u)
				{
				case 3u:
					num6 = ((int)num3 * -764927934) ^ -256148259;
					continue;
				case 2u:
					result = string_;
					num6 = (int)((num3 * 966343311) ^ 0xD7EDAB7);
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
		bool flag = default(bool);
		while (true)
		{
			int num = -2056876174;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC73B7E5u) % 13u)
				{
				case 12u:
					num3++;
					num = ((int)num2 * -1147495232) ^ -1140109690;
					continue;
				case 11u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1685953300) ^ 0x23630AF5);
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1115463026;
						num5 = -1115463026;
					}
					else
					{
						num4 = -1743688546;
						num5 = -1743688546;
					}
					num = num4 ^ ((int)num2 * -1759229114);
					continue;
				}
				case 9u:
					num = (int)(num2 * 605433015) ^ -267854216;
					continue;
				case 8u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1519679902) ^ 0x17254573;
					continue;
				case 7u:
					num = ((int)num2 * -992330895) ^ 0x58BD600C;
					continue;
				case 6u:
					num = ((int)num2 * -51683584) ^ 0x65DFEB29;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1183546093) ^ -544657509;
					continue;
				case 4u:
					flag = num3 < m_List.Count;
					num = -815010947;
					continue;
				case 2u:
					num = -326967179;
					continue;
				case 1u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -50913898) ^ -1341725659;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			int num = -504129796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF722DEAu) % 3u)
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
				num = (int)((num2 * 820185970) ^ 0x3D33F758);
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
