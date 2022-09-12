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
			while (true)
			{
				int num = -77116141;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBDC0B910u) % 6u)
					{
					case 5u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1140040400) ^ -1178139976;
						continue;
					case 3u:
						result = m_List[aIndex];
						num = -902426040;
						continue;
					case 2u:
						if (aIndex < m_List.Count)
						{
							num = -1016350403;
							num3 = -1016350403;
							continue;
						}
						goto IL_004f;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1004599231) ^ -143264087;
							continue;
						}
						goto IL_004f;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_004f:
						num = -1903857851;
						num3 = -1903857851;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0055;
			IL_0055:
			int num = 90456990;
			goto IL_005a;
			IL_005a:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1879E955u) % 6u)
				{
				case 4u:
					m_List.Add(value);
					num = ((int)num2 * -219803579) ^ 0xD292A;
					continue;
				case 2u:
					m_List[aIndex] = value;
					num = 731180322;
					continue;
				case 1u:
					num = (int)(num2 * 1194933142) ^ -203787672;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_0083;
				case 3u:
					return;
				}
				break;
				IL_0083:
				if (aIndex < m_List.Count)
				{
					num = 838698819;
					num3 = 838698819;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0055;
			IL_000a:
			num = 726492453;
			num3 = 726492453;
			goto IL_005a;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1683159945;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B342EC4u) % 4u)
					{
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1610811812) ^ -195915684;
						continue;
					case 0u:
						num = ((int)num2 * -623778778) ^ -1829324689;
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
			while (true)
			{
				int num = -1593203571;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x88FD642Du) % 3u)
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
					m_List.Add(value);
					num = ((int)num2 * -450457987) ^ 0x2D716E0E;
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
				int num = 2094863374;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E582DE7u) % 3u)
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
					num = (int)(num2 * 726659186) ^ -388575213;
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
				int num = 1773845613;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BE6E054u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)(num2 * 314674404) ^ -2125881831;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
		while (true)
		{
			int num = 1089969222;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E6DA6Eu) % 3u)
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
				num = ((int)num2 * -320695825) ^ -1519503112;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_003d;
		}
		int num = 1;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = -704299718;
		goto IL_0084;
		IL_003d:
		num2 = -339237577;
		goto IL_0084;
		IL_0084:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xA2FA7CD5u) % 8u)
			{
			case 7u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 673768511;
					num5 = 673768511;
				}
				else
				{
					num4 = 1392559662;
					num5 = 1392559662;
				}
				num2 = num4 ^ ((int)num3 * -1115719842);
				continue;
			}
			case 6u:
				num2 = ((int)num3 * -1078985338) ^ 0x2E2E86A2;
				continue;
			case 5u:
				break;
			case 4u:
				result = jSONNode;
				num2 = (int)(num3 * 1655471909) ^ -771521049;
				continue;
			case 1u:
				result = null;
				num2 = ((int)num3 * -1476148869) ^ -431860795;
				continue;
			case 0u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = -122802879;
				continue;
			case 2u:
				goto IL_00b5;
			default:
				return result;
			}
			break;
		}
		goto IL_003d;
		IL_00b5:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00c6;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 654636130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24C624CBu) % 3u)
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
				num = ((int)num2 * -429779745) ^ 0x1A1874F2;
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
			int num = -215732182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB374E655u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0109:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -175062066;
								num4 = -175062066;
							}
							else
							{
								num3 = -293957038;
								num4 = -293957038;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB374E655u) % 7u)
								{
								case 6u:
									num3 = -293957038;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -786375474;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = -1497722908;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = -14909916;
										num6 = -14909916;
									}
									else
									{
										num5 = -244097172;
										num6 = -244097172;
									}
									num3 = num5 ^ ((int)num2 * -1528179198);
									continue;
								}
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1067379621) ^ -1934736159;
									continue;
								default:
									goto end_IL_00cc;
								case 2u:
									break;
								case 3u:
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
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = -1077265980;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xB374E655u) % 4u)
							{
							case 2u:
								num7 = (int)((num2 * 1133557326) ^ 0x77A9F7AA);
								continue;
							case 1u:
								result = string_;
								num7 = (int)((num2 * 1490145006) ^ 0x7CB4E8F9);
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
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -75248383) ^ -1763433258;
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
				IL_0121:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -208209835;
					num2 = -208209835;
				}
				else
				{
					num = -1662058795;
					num2 = -1662058795;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x88DABC4Au) % 9u)
					{
					case 8u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -1677511959) ^ 0x68121062;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1533796071;
							num5 = 1533796071;
						}
						else
						{
							num4 = 1042276375;
							num5 = 1042276375;
						}
						num = num4 ^ ((int)num3 * -228293878);
						continue;
					}
					case 4u:
						current = enumerator.Current;
						num = -1858953586;
						continue;
					case 3u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = -1773422193;
						continue;
					case 2u:
						num = (int)(num3 * 101048712) ^ -1825117911;
						continue;
					case 1u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = ((int)num3 * -1019134727) ^ 0x317974DF;
						continue;
					case 0u:
						num = -208209835;
						continue;
					default:
						goto end_IL_00db;
					case 5u:
						break;
					case 6u:
						goto end_IL_00db;
					}
					goto IL_0121;
					continue;
					end_IL_00db:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = string_;
		while (true)
		{
			int num6 = -840802085;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x88DABC4Au) % 3u)
				{
				case 1u:
					goto IL_0156;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0156:
				num6 = ((int)num3 * -1931070325) ^ 0x4F4D2A06;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		while (true)
		{
			int num = -1165055603;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A0138A7u) % 10u)
				{
				case 9u:
					num = -1560886566;
					continue;
				case 8u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 2121971547) ^ 0x6B958345);
					continue;
				case 7u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -936711334) ^ 0x52D2E357;
					continue;
				case 6u:
					num = ((int)num2 * -13096484) ^ 0x5C26E8B2;
					continue;
				case 4u:
					num3 = 0;
					num = (int)(num2 * 1761220408) ^ -1514274498;
					continue;
				case 3u:
					num = ((int)num2 * -1174851750) ^ -1427217021;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 812873196) ^ 0x767F8756);
					continue;
				case 1u:
				{
					int num4;
					if (num3 < m_List.Count)
					{
						num = -849958534;
						num4 = -849958534;
					}
					else
					{
						num = -736425642;
						num4 = -736425642;
					}
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 5u:
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
			int num = -1309135037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDB34E88u) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0013:
				num = (int)(num2 * 1111671736) ^ -692008433;
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
