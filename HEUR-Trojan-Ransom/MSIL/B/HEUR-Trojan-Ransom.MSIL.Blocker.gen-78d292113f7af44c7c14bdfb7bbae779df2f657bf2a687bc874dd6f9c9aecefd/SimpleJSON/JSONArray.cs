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
				int num = 1394218522;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x231E96E8u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 793965630) ^ -1845357561;
						continue;
					case 6u:
						result = m_List[aIndex];
						num = 1544468149;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1626957564;
							num5 = 1626957564;
						}
						else
						{
							num4 = 1848712394;
							num5 = 1848712394;
						}
						num = num4 ^ ((int)num2 * -350364223);
						continue;
					}
					case 2u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1977618282) ^ -129263147;
							continue;
						}
						num3 = 1;
						goto IL_0061;
					case 1u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0061;
					case 0u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1665278254) ^ -1050889841;
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0061:
						flag = (byte)num3 != 0;
						num = 233391628;
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
				int num = -1443794722;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xEA65DD7Du) % 8u)
					{
					case 7u:
						m_List[aIndex] = value;
						num = -1955623799;
						continue;
					case 6u:
						m_List.Add(value);
						num = (int)((num2 * 1814868451) ^ 0x5A1B9D1D);
						continue;
					case 5u:
						if (aIndex < m_List.Count)
						{
							num = -291119958;
							num3 = -291119958;
							continue;
						}
						goto IL_0048;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1384360893) ^ 0x2DBD59C9;
							continue;
						}
						goto IL_0048;
					case 2u:
						num = ((int)num2 * -691255391) ^ -1164994482;
						continue;
					case 1u:
						num = ((int)num2 * -385622327) ^ 0x4F310698;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
						IL_0048:
						num = -1623907741;
						num3 = -1623907741;
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
				int num = -1576834066;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4C55CABu) % 4u)
					{
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1289159136) ^ 0x1358C8FB);
						continue;
					case 0u:
						num = ((int)num2 * -1726454381) ^ -199628520;
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
		set
		{
			m_List.Add(value);
		}
	}

	public override int Count => m_List.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 369226340;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C9E4D0Au) % 3u)
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
					num = ((int)num2 * -1451686274) ^ 0x7781B453;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 717750480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11E74D15u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1104161669) ^ 0x8EF3ABC);
					continue;
				case 1u:
					m_List.Add(aItem);
					num = (int)((num2 * 432498539) ^ 0x7E6CEE00);
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

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_001a;
		}
		goto IL_00ea;
		IL_001a:
		int num = -1110528203;
		goto IL_009d;
		IL_009d:
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDC6E3871u) % 10u)
			{
			case 9u:
				break;
			case 7u:
				num = ((int)num2 * -1218380773) ^ 0x8A16DFA;
				continue;
			case 5u:
				jSONNode = m_List[aIndex];
				num = -525433457;
				continue;
			case 4u:
				num = ((int)num2 * -1037609414) ^ -1878878895;
				continue;
			case 3u:
				num = ((int)num2 * -778012054) ^ -940860781;
				continue;
			case 2u:
				result = jSONNode;
				num = ((int)num2 * -1872962288) ^ -2099886014;
				continue;
			case 1u:
				result = null;
				num = ((int)num2 * -1492794618) ^ -838675323;
				continue;
			case 0u:
				m_List.RemoveAt(aIndex);
				num = (int)(num2 * 520345936) ^ -267940626;
				continue;
			case 6u:
				goto IL_00d7;
			default:
				return result;
			}
			break;
			IL_00d7:
			if (aIndex < m_List.Count)
			{
				num = -1068824136;
				num3 = -1068824136;
				continue;
			}
			goto IL_00ea;
		}
		goto IL_001a;
		IL_00ea:
		num = -1442369710;
		num3 = -1442369710;
		goto IL_009d;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 863676386;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24BA1A0u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 2077391362) ^ 0x6E07EF13);
					continue;
				case 2u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -123221397) ^ 0x358CD8B9;
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
		JSONNode current = default(JSONNode);
		string result = default(string);
		while (true)
		{
			int num = 348660349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53340671u) % 3u)
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
							IL_011f:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 317411011;
								num4 = 317411011;
							}
							else
							{
								num3 = 663060007;
								num4 = 663060007;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x53340671u) % 8u)
								{
								case 6u:
									current = enumerator.Current;
									num3 = 1970799284;
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = 784875756;
										num6 = 784875756;
									}
									else
									{
										num5 = 636677939;
										num6 = 636677939;
									}
									num3 = num5 ^ (int)(num2 * 1718772246);
									continue;
								}
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 967686174) ^ 0xE3D0C2A);
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1362540224;
									continue;
								case 1u:
									num3 = ((int)num2 * -2134828329) ^ -2105429471;
									continue;
								case 0u:
									num3 = 663060007;
									continue;
								default:
									goto end_IL_00de;
								case 7u:
									break;
								case 2u:
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
					while (true)
					{
						int num7 = 37528703;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x53340671u) % 3u)
							{
							case 1u:
								goto IL_014b;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_014b:
							result = string_;
							num7 = ((int)num2 * -2142233780) ^ -1170079170;
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)(num2 * 225021192) ^ -1440599050;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 776464697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B1B04E5u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0145:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 736267666;
								num4 = 736267666;
							}
							else
							{
								num3 = 1431394521;
								num4 = 1431394521;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7B1B04E5u) % 8u)
								{
								case 6u:
									num3 = 1431394521;
									continue;
								case 4u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = 252112470;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1205298941;
										num6 = 1205298941;
									}
									else
									{
										num5 = 1125598950;
										num6 = 1125598950;
									}
									num3 = num5 ^ ((int)num2 * -736621165);
									continue;
								}
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -793126605) ^ 0xB4F600A;
									continue;
								case 1u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = 2035641301;
									continue;
								case 0u:
									num3 = ((int)num2 * -191240583) ^ -567698984;
									continue;
								default:
									goto end_IL_0104;
								case 5u:
									break;
								case 7u:
									goto end_IL_0104;
								}
								goto IL_0145;
								continue;
								end_IL_0104:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 746416580;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x7B1B04E5u) % 4u)
							{
							case 3u:
								num7 = (int)(num2 * 1860399484) ^ -1426533731;
								continue;
							case 1u:
								result = string_;
								num7 = ((int)num2 * -973174765) ^ -7593991;
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
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1540931275) ^ 0x3B5BE69;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1361047524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EC04DA9u) % 8u)
				{
				case 6u:
					m_List[num5].Serialize(aWriter);
					num5++;
					num = ((int)num2 * -2023935716) ^ -1949489013;
					continue;
				case 5u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)(num2 * 1228155828) ^ -1917777831;
					continue;
				case 4u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num5 = 0;
					num = ((int)num2 * -1115132154) ^ 0x1C22CD5B;
					continue;
				case 3u:
					num = 1451599567;
					continue;
				case 2u:
					flag = num5 < m_List.Count;
					num = 1503403776;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 903298102;
						num4 = 903298102;
					}
					else
					{
						num3 = 929489333;
						num4 = 929489333;
					}
					num = num3 ^ (int)(num2 * 725577452);
					continue;
				}
				default:
					return;
				case 7u:
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
