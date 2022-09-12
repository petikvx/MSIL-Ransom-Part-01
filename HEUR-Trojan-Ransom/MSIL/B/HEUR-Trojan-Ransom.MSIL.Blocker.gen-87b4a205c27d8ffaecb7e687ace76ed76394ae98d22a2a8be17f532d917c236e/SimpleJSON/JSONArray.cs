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
				int num = 1883514896;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x4578A21Eu) % 8u)
					{
					case 7u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0017;
					case 6u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1118045982) ^ -762414643;
							continue;
						}
						num5 = 1;
						goto IL_0017;
					case 5u:
						result = m_List[aIndex];
						num = 771660669;
						continue;
					case 4u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 776013806) ^ -88565956;
						continue;
					case 2u:
						num = ((int)num2 * -1784752587) ^ 0x629E06F;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1532966768;
							num4 = -1532966768;
						}
						else
						{
							num3 = -425011415;
							num4 = -425011415;
						}
						num = num3 ^ (int)(num2 * 26738370);
						continue;
					}
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num5 != 0;
						num = 999312959;
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
				int num = 1038931881;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x30D3B86Du) % 7u)
					{
					case 5u:
						m_List.Add(value);
						num = ((int)num2 * -1449398161) ^ 0x635E94A0;
						continue;
					case 4u:
						m_List[aIndex] = value;
						num = 406891374;
						continue;
					case 3u:
						num = ((int)num2 * -1371783618) ^ -2096822010;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1437622306) ^ 0x311222C4);
							continue;
						}
						goto IL_0066;
					case 1u:
						if (aIndex < m_List.Count)
						{
							num = 1598999380;
							num3 = 1598999380;
							continue;
						}
						goto IL_0066;
					default:
						return;
					case 6u:
						break;
					case 0u:
						return;
						IL_0066:
						num = 1886932578;
						num3 = 1886932578;
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
				int num = 1677542916;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1BD9B08Bu) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 347898062) ^ 0x61A68987);
						continue;
					case 2u:
						num = ((int)num2 * -1276041562) ^ 0x30965B16;
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
				int num = -1458522692;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE34FCE69u) % 3u)
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
					num = ((int)num2 * -1508870666) ^ 0x68FF495;
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
				int num = -680732181;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB32D32D8u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = (int)(num2 * 621490320) ^ -1565104942;
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
			int num = -397197981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5B584D9u) % 3u)
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
				num = ((int)num2 * -1005118387) ^ 0x37478B13;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex < 0)
		{
			goto IL_000a;
		}
		goto IL_0017;
		IL_0017:
		int num = 1475708883;
		goto IL_007c;
		IL_007c:
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x341D62D8u) % 8u)
			{
			case 7u:
				break;
			case 6u:
				m_List.RemoveAt(aIndex);
				num = ((int)num2 * -1502576054) ^ 0x214E6636;
				continue;
			case 5u:
				jSONNode = m_List[aIndex];
				num = 891818078;
				continue;
			case 4u:
				result = null;
				num = ((int)num2 * -2102537659) ^ -1985160123;
				continue;
			case 2u:
				result = jSONNode;
				num = (int)(num2 * 1488331911) ^ -1092646650;
				continue;
			case 1u:
				num = ((int)num2 * -344266671) ^ -648625119;
				continue;
			case 3u:
				goto IL_00ad;
			default:
				return result;
			}
			break;
			IL_00ad:
			if (aIndex < m_List.Count)
			{
				num = 185107821;
				num3 = 185107821;
				continue;
			}
			goto IL_000a;
		}
		goto IL_0017;
		IL_000a:
		num = 614144284;
		num3 = 614144284;
		goto IL_007c;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		while (true)
		{
			int num = 899649665;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E28595Au) % 3u)
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
				num = (int)(num2 * 921911365) ^ -614798120;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -903602455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD9141AC8u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -630401251) ^ 0x4F2FA391;
					continue;
				case 1u:
					string_ = "[ ";
					num = (int)((num2 * 1223205927) ^ 0x4A5653C8);
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
							IL_014b:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -257068366;
								num4 = -257068366;
							}
							else
							{
								num3 = -624220761;
								num4 = -624220761;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD9141AC8u) % 9u)
								{
								case 8u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = (int)((num2 * 483073477) ^ 0x172A9EB2);
									continue;
								case 7u:
									num3 = -257068366;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -358066651;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1586177656) ^ 0x5B816476;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 955662742;
										num6 = 955662742;
									}
									else
									{
										num5 = 1152615868;
										num6 = 1152615868;
									}
									num3 = num5 ^ (int)(num2 * 635510280);
									continue;
								}
								case 2u:
									current = enumerator.Current;
									num3 = -1500583358;
									continue;
								case 0u:
									num3 = (int)(num2 * 370625571) ^ -895581478;
									continue;
								default:
									goto end_IL_0105;
								case 6u:
									break;
								case 1u:
									goto end_IL_0105;
								}
								goto IL_014b;
								continue;
								end_IL_0105:
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
							IL_0196:
							int num7 = -1297867934;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xD9141AC8u) % 3u)
								{
								case 1u:
									goto IL_016a;
								default:
									goto end_IL_0178;
								case 0u:
									break;
								case 2u:
									goto end_IL_0178;
								}
								goto IL_0196;
								IL_016a:
								num7 = ((int)num2 * -1788893744) ^ 0x65BFF53B;
								continue;
								end_IL_0178:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = -2005777559;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xD9141AC8u) % 4u)
							{
							case 2u:
								num8 = ((int)num2 * -665501927) ^ 0x3E6DC1AD;
								continue;
							case 1u:
								result = string_;
								num8 = (int)(num2 * 1405091692) ^ -41364194;
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

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		while (true)
		{
			int num = 1760404331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CCECC22u) % 4u)
				{
				case 1u:
					string_ = "[ ";
					num = (int)(num2 * 1449249731) ^ -1102483787;
					continue;
				case 0u:
					num = ((int)num2 * -655400510) ^ -1492098580;
					continue;
				case 3u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0151:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1666084230;
								num4 = 1666084230;
							}
							else
							{
								num3 = 413410866;
								num4 = 413410866;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5CCECC22u) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = 45973561;
										num6 = 45973561;
									}
									else
									{
										num5 = 772717374;
										num6 = 772717374;
									}
									num3 = num5 ^ ((int)num2 * -2067767226);
									continue;
								}
								case 6u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 687302162) ^ -607296641;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = 1703387829;
									continue;
								case 3u:
									num3 = (int)(num2 * 1443644498) ^ -1017391343;
									continue;
								case 2u:
									num3 = 1666084230;
									continue;
								case 1u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = 1754871337;
									continue;
								default:
									goto end_IL_0110;
								case 5u:
									break;
								case 0u:
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
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num7 = 433971845;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x5CCECC22u) % 3u)
							{
							case 1u:
								goto IL_0186;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0186:
							num7 = (int)((num2 * 1865284336) ^ 0xFC42DCE);
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
		while (true)
		{
			int num = 906068587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D494050u) % 11u)
				{
				case 9u:
				{
					int num4;
					if (num3 < m_List.Count)
					{
						num = 69503615;
						num4 = 69503615;
					}
					else
					{
						num = 283841753;
						num4 = 283841753;
					}
					continue;
				}
				case 8u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -907071249) ^ 0x58A45330;
					continue;
				case 7u:
					num3 = 0;
					num = (int)((num2 * 1750553521) ^ 0x2FFCBDE4);
					continue;
				case 6u:
					num = (int)(num2 * 1433523413) ^ -607414200;
					continue;
				case 5u:
					num = 580916344;
					continue;
				case 3u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -1850584202) ^ -379824972;
					continue;
				case 2u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 418068350) ^ 0x17442650);
					continue;
				case 1u:
					num3++;
					num = (int)(num2 * 1498666678) ^ -552779138;
					continue;
				case 0u:
					num = ((int)num2 * -907808468) ^ -2111868402;
					continue;
				default:
					return;
				case 10u:
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
