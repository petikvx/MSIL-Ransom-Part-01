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
				int num = -451647112;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xC1FEE3BEu) % 7u)
					{
					case 6u:
						num = (int)((num2 * 17139712) ^ 0x4B9FEDDC);
						continue;
					case 5u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1397752175) ^ -1808006842;
						continue;
					case 4u:
						if (aIndex < m_List.Count)
						{
							num = -89850363;
							num3 = -89850363;
							continue;
						}
						goto IL_004a;
					case 3u:
						result = m_List[aIndex];
						num = -630809124;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -358079119) ^ -1916360317;
							continue;
						}
						goto IL_004a;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_004a:
						num = -1035246764;
						num3 = -1035246764;
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
				int num = 1290611201;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x54410CE8u) % 8u)
					{
					case 6u:
						num = (int)((num2 * 362469574) ^ 0x51BBA031);
						continue;
					case 4u:
						num = (int)((num2 * 401680615) ^ 0x3BAD49);
						continue;
					case 3u:
						if (aIndex < m_List.Count)
						{
							num = 916396794;
							num3 = 916396794;
							continue;
						}
						goto IL_0043;
					case 2u:
						m_List[aIndex] = value;
						num = 20263180;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1855189709) ^ -1968206434;
							continue;
						}
						goto IL_0043;
					case 0u:
						m_List.Add(value);
						num = (int)((num2 * 1721814531) ^ 0x55B382E6);
						continue;
					default:
						return;
					case 7u:
						break;
					case 5u:
						return;
						IL_0043:
						num = 1655635328;
						num3 = 1655635328;
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
				int num = -1607864791;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD58F42A0u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1422193799) ^ -1025396855;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -138316273) ^ 0x3B089655;
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
				int num = -1461323883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0099D22u) % 3u)
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
					m_List.Add(value);
					num = (int)((num2 * 544136223) ^ 0x6686AD5D);
				}
			}
		}
	}

	public override int Count => m_List.Count;

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
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -788796199;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE76CCC8Au) % 10u)
				{
				case 9u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1482454042;
						num5 = 1482454042;
					}
					else
					{
						num4 = 958820057;
						num5 = 958820057;
					}
					num = num4 ^ (int)(num2 * 1781050322);
					continue;
				}
				case 8u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = -180511035;
					continue;
				case 6u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_005e;
				case 5u:
					num = ((int)num2 * -2069765309) ^ -1479469159;
					continue;
				case 4u:
					num = ((int)num2 * -1215323643) ^ -81172537;
					continue;
				case 3u:
					result = null;
					num = ((int)num2 * -173217928) ^ 0x5197D17D;
					continue;
				case 2u:
					result = jSONNode;
					num = (int)((num2 * 1745733781) ^ 0x1DFF47E6);
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -448126781) ^ 0xF16AA71;
						continue;
					}
					num3 = 1;
					goto IL_005e;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_005e:
					flag = (byte)num3 != 0;
					num = -1307066919;
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
			int num = -998885157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAD5DFF1u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1308877384) ^ 0x66E6C113);
					continue;
				case 3u:
					m_List.Remove(aNode);
					num = ((int)num2 * -607329478) ^ 0x7AD2B696;
					continue;
				case 0u:
					result = aNode;
					num = (int)((num2 * 1426415315) ^ 0x656F871D);
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
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1436831157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51A58C36u) % 3u)
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
								num3 = 245289521;
								num4 = 245289521;
							}
							else
							{
								num3 = 1182415995;
								num4 = 1182415995;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x51A58C36u) % 7u)
								{
								case 6u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1566275050) ^ -241738139;
									continue;
								case 4u:
								{
									current = enumerator.Current;
									int num5;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num3 = 598305223;
										num5 = 598305223;
									}
									else
									{
										num3 = 951384101;
										num5 = 951384101;
									}
									continue;
								}
								case 3u:
									num3 = 1182415995;
									continue;
								case 2u:
									num3 = ((int)num2 * -1968457157) ^ -1562016234;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1199711701;
									continue;
								default:
									goto end_IL_00cc;
								case 5u:
									break;
								case 1u:
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
						int num6 = 271990574;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x51A58C36u) % 3u)
							{
							case 1u:
								goto IL_0135;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0135:
							result = string_;
							num6 = ((int)num2 * -1203352449) ^ -1737535090;
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1079025269) ^ -1871543090;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1923592981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9535A1A9u) % 3u)
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
							IL_012c:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -197557830;
								num4 = -197557830;
							}
							else
							{
								num3 = -1301477228;
								num4 = -1301477228;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9535A1A9u) % 7u)
								{
								case 6u:
									num3 = -197557830;
									continue;
								case 4u:
									num3 = (int)(num2 * 891926613) ^ -1815148626;
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -1403786365;
									continue;
								case 2u:
								{
									current = enumerator.Current;
									int num5;
									if (JSONArray.smethod_30(string_) > 3)
									{
										num3 = -681541784;
										num5 = -681541784;
									}
									else
									{
										num3 = -1225473086;
										num5 = -1225473086;
									}
									continue;
								}
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1232314357) ^ -1573899895;
									continue;
								default:
									goto end_IL_00ef;
								case 5u:
									break;
								case 0u:
									goto end_IL_00ef;
								}
								goto IL_012c;
								continue;
								end_IL_00ef:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num6 = -1974248806;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x9535A1A9u) % 4u)
							{
							case 3u:
								result = string_;
								num6 = (int)(num2 * 578280497) ^ -646391862;
								continue;
							case 0u:
								num6 = (int)(num2 * 147253801) ^ -370472864;
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
				num = ((int)num2 * -1286420322) ^ -2144994907;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		while (true)
		{
			int num = 2017928070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FD6F51Du) % 10u)
				{
				case 9u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1930915045) ^ 0x1ACBD72);
					continue;
				case 7u:
				{
					int num4;
					if (num3 < m_List.Count)
					{
						num = 1255750682;
						num4 = 1255750682;
					}
					else
					{
						num = 886077035;
						num4 = 886077035;
					}
					continue;
				}
				case 6u:
					num = (int)(num2 * 783284621) ^ -1230150325;
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -109701004) ^ -423654154;
					continue;
				case 3u:
					num = 466640760;
					continue;
				case 2u:
					num = ((int)num2 * -325227633) ^ 0x69C73364;
					continue;
				case 1u:
					m_List[num3].Serialize(aWriter);
					num = (int)(num2 * 597887556) ^ -921704125;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -660200824) ^ 0x5F06DC4A;
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
