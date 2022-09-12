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
				goto IL_0017;
			}
			goto IL_007e;
			IL_0017:
			int num = -1970486091;
			goto IL_0046;
			IL_0046:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0319A0Du) % 5u)
				{
				case 4u:
					break;
				case 3u:
					result = new JSONLazyCreator(this);
					num = ((int)num2 * -199832189) ^ 0x40A1A818;
					continue;
				case 2u:
					result = m_List[aIndex];
					num = -1189292591;
					continue;
				case 1u:
					goto IL_006b;
				default:
					return result;
				}
				break;
				IL_006b:
				if (aIndex < m_List.Count)
				{
					num = -1520653580;
					num3 = -1520653580;
					continue;
				}
				goto IL_007e;
			}
			goto IL_0017;
			IL_007e:
			num = -2106831922;
			num3 = -2106831922;
			goto IL_0046;
		}
		set
		{
			while (true)
			{
				int num = -2007371919;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xE22043DAu) % 8u)
					{
					case 7u:
						m_List[aIndex] = value;
						num = -1108568234;
						continue;
					case 4u:
						num = (int)((num2 * 986703884) ^ 0x12B702BF);
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1348821099) ^ -1320596260;
							continue;
						}
						goto IL_003f;
					case 2u:
						m_List.Add(value);
						num = ((int)num2 * -1875142589) ^ 0x1180CC2C;
						continue;
					case 1u:
						if (aIndex < m_List.Count)
						{
							num = -64417859;
							num3 = -64417859;
							continue;
						}
						goto IL_003f;
					case 0u:
						num = (int)(num2 * 578680841) ^ -885099673;
						continue;
					default:
						return;
					case 6u:
						break;
					case 5u:
						return;
						IL_003f:
						num = -1568054800;
						num3 = -1568054800;
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
				int num = 2025386514;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71548ECBu) % 3u)
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
					num = ((int)num2 * -1378423365) ^ 0x55317AFF;
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
				int num = -941963932;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FAB7517u) % 4u)
					{
					case 3u:
						count = m_List.Count;
						num = ((int)num2 * -1744884674) ^ 0x78FB8FD3;
						continue;
					case 2u:
						num = ((int)num2 * -96827271) ^ 0x15C39408;
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_006e;
		}
		int num = 1;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = -854378821;
		goto IL_0084;
		IL_006e:
		num2 = -1543238695;
		goto IL_0084;
		IL_0084:
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xCD8D61D0u) % 8u)
			{
			case 7u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = -58813139;
				continue;
			case 5u:
				result = jSONNode;
				num2 = (int)((num3 * 1285821551) ^ 0x372C0F05);
				continue;
			case 4u:
				num2 = (int)((num3 * 443414801) ^ 0x92C8072);
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -481235149;
					num5 = -481235149;
				}
				else
				{
					num4 = -1414850924;
					num5 = -1414850924;
				}
				num2 = num4 ^ ((int)num3 * -1019271692);
				continue;
			}
			case 2u:
				break;
			case 0u:
				result = null;
				num2 = ((int)num3 * -1274898141) ^ -1419777668;
				continue;
			case 1u:
				goto IL_00b5;
			default:
				return result;
			}
			break;
		}
		goto IL_006e;
		IL_00b5:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00c6;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -487414159;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90C32F48u) % 4u)
				{
				case 3u:
					result = aNode;
					num = ((int)num2 * -1473065104) ^ 0x1BD01C9E;
					continue;
				case 1u:
					m_List.Remove(aNode);
					num = (int)((num2 * 1739651517) ^ 0x401F84BA);
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
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1069465125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECD9D71Eu) % 4u)
				{
				case 1u:
					string_ = "[ ";
					num = (int)(num2 * 1769802361) ^ -767321365;
					continue;
				case 0u:
					num = (int)(num2 * 1454671805) ^ -1946471859;
					continue;
				case 2u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0134:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1954809639;
								num4 = -1954809639;
							}
							else
							{
								num3 = -472534806;
								num4 = -472534806;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xECD9D71Eu) % 8u)
								{
								case 6u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 918519735) ^ -738922319;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1510257609;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = -1847195115;
									continue;
								case 3u:
									num3 = ((int)num2 * -21847690) ^ 0x35010BFE;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = 1194824091;
										num6 = 1194824091;
									}
									else
									{
										num5 = 1921638552;
										num6 = 1921638552;
									}
									num3 = num5 ^ ((int)num2 * -110232552);
									continue;
								}
								case 0u:
									num3 = -472534806;
									continue;
								default:
									goto end_IL_00f3;
								case 1u:
									break;
								case 7u:
									goto end_IL_00f3;
								}
								goto IL_0134;
								continue;
								end_IL_00f3:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = -813851881;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xECD9D71Eu) % 3u)
							{
							case 2u:
								goto IL_0160;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0160:
							result = string_;
							num7 = (int)((num2 * 2129433428) ^ 0x39FED2EB);
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
				if (!enumerator.MoveNext())
				{
					num = -348813111;
					num2 = -348813111;
				}
				else
				{
					num = -2087333172;
					num2 = -2087333172;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xAC3B7CD9u) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 2045170553;
							num5 = 2045170553;
						}
						else
						{
							num4 = 68107890;
							num5 = 68107890;
						}
						num = num4 ^ (int)(num3 * 1922697276);
						continue;
					}
					case 6u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = (int)((num3 * 307817246) ^ 0x5B7B75E8);
						continue;
					case 5u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = -635076425;
						continue;
					case 4u:
						num = -2087333172;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 68057197) ^ -1166277614;
						continue;
					case 2u:
						current = enumerator.Current;
						num = -323323731;
						continue;
					case 1u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = ((int)num3 * -1543013475) ^ 0x7E08FFF1;
						continue;
					default:
						goto end_IL_00db;
					case 7u:
						break;
					case 0u:
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
			int num6 = -570545933;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xAC3B7CD9u) % 3u)
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
				num6 = (int)(num3 * 36547608) ^ -571510987;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -635813435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD8EFA9D1u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 1367654443) ^ 0x6F50B873);
					continue;
				case 8u:
					m_List[num3].Serialize(aWriter);
					num = -1902024031;
					continue;
				case 7u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num3 = 0;
					num = (int)(num2 * 405573496) ^ -675276704;
					continue;
				case 6u:
					num = ((int)num2 * -1297960685) ^ -445306499;
					continue;
				case 5u:
					flag = num3 < m_List.Count;
					num = -982493104;
					continue;
				case 4u:
					num = ((int)num2 * -156864183) ^ -1723915640;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 687401414;
						num5 = 687401414;
					}
					else
					{
						num4 = 9414353;
						num5 = 9414353;
					}
					num = num4 ^ ((int)num2 * -1219287901);
					continue;
				}
				case 0u:
					num3++;
					num = ((int)num2 * -1811577109) ^ -380149948;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
