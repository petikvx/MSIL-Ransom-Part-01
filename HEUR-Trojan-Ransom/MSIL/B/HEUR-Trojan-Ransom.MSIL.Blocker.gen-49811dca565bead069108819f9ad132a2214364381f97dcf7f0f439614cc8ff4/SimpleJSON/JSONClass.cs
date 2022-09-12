using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON;

public class JSONClass : JSONNode, IEnumerable
{
	private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

	public override JSONNode this[string aKey]
	{
		get
		{
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_003b;
			}
			goto IL_0065;
			IL_0065:
			JSONNode result = new JSONLazyCreator(this, aKey);
			int num = -824940354;
			goto IL_0040;
			IL_0040:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD0CB0FCu) % 5u)
				{
				case 4u:
					result = m_Dict[aKey];
					num = (int)((num2 * 1072206855) ^ 0x4BFAB5AE);
					continue;
				case 1u:
					num = ((int)num2 * -322959914) ^ -1244081638;
					continue;
				case 0u:
					break;
				case 2u:
					goto IL_0065;
				default:
					return result;
				}
				break;
			}
			goto IL_003b;
			IL_003b:
			num = -43700652;
			goto IL_0040;
		}
		set
		{
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_000e;
			}
			goto IL_0089;
			IL_0089:
			m_Dict.Add(aKey, value);
			int num = 196251112;
			goto IL_005c;
			IL_005c:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D14585Fu) % 7u)
				{
				case 6u:
					break;
				case 5u:
					m_Dict[aKey] = value;
					num = ((int)num2 * -863184277) ^ -950586906;
					continue;
				case 4u:
					num = ((int)num2 * -1241362287) ^ 0x1B72AD0D;
					continue;
				case 1u:
					num = (int)(num2 * 683947957) ^ -1601209105;
					continue;
				case 0u:
					num = ((int)num2 * -103171512) ^ -2049754234;
					continue;
				default:
					return;
				case 3u:
					goto IL_0089;
				case 2u:
					return;
				}
				break;
			}
			goto IL_000e;
			IL_000e:
			num = 1177207187;
			goto IL_005c;
		}
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			if (aIndex >= 0)
			{
				goto IL_0040;
			}
			goto IL_0081;
			IL_0040:
			int num = -1270120870;
			goto IL_0045;
			IL_0045:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE2A1CDCu) % 6u)
				{
				case 5u:
					result = null;
					num = -1874653900;
					continue;
				case 3u:
					result = null;
					num = (int)((num2 * 2093880813) ^ 0x4D40F3DC);
					continue;
				case 2u:
					num = (int)(num2 * 349923753) ^ -234849439;
					continue;
				case 0u:
					break;
				case 4u:
					goto IL_006e;
				default:
					return result;
				}
				break;
				IL_006e:
				if (aIndex < m_Dict.Count)
				{
					num = -2019162483;
					num3 = -2019162483;
					continue;
				}
				goto IL_0081;
			}
			goto IL_0040;
			IL_0081:
			num = -649550187;
			num3 = -649550187;
			goto IL_0045;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_003a;
			}
			int num = 1;
			goto IL_0075;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
			IL_003a:
			int num2 = 1688087876;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1723267Au) % 5u)
				{
				case 4u:
					num2 = (int)((num3 * 805954936) ^ 0xE492F9D);
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -44628979;
						num5 = -44628979;
					}
					else
					{
						num4 = -678167645;
						num5 = -678167645;
					}
					num2 = num4 ^ ((int)num3 * -1902422476);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0064;
				case 3u:
					return;
				}
				break;
			}
			goto IL_003a;
			IL_0075:
			flag = (byte)num != 0;
			num2 = 98811000;
			goto IL_003f;
		}
	}

	public override int Count
	{
		get
		{
			int count = m_Dict.Count;
			while (true)
			{
				int num = -397949892;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x93B2F3A8u) % 3u)
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
					num = ((int)num2 * -1248302169) ^ 0x6A69C72;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1371692286;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97A2F9F5u) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1353502940) ^ -498029753;
						continue;
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1161460188) ^ -283850228;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 12316583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25915EB5u) % 11u)
				{
				case 10u:
				{
					int num5;
					int num6;
					if (!m_Dict.ContainsKey(aKey))
					{
						num5 = -1210184352;
						num6 = -1210184352;
					}
					else
					{
						num5 = -1000430283;
						num6 = -1000430283;
					}
					num = num5 ^ ((int)num2 * -764510296);
					continue;
				}
				case 9u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1902795220;
					continue;
				case 8u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 175964226) ^ 0x797C7BB0);
					continue;
				case 6u:
					m_Dict.Add(aKey, aItem);
					num = 372521075;
					continue;
				case 5u:
					num = ((int)num2 * -801588989) ^ -1982649143;
					continue;
				case 4u:
					num = (int)((num2 * 1233216631) ^ 0x709C5F28);
					continue;
				case 3u:
					num = ((int)num2 * -163156667) ^ 0x7A061DDD;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!JSONClass.smethod_30(aKey))
					{
						num3 = 1574891348;
						num4 = 1574891348;
					}
					else
					{
						num3 = 567229229;
						num4 = 567229229;
					}
					num = num3 ^ (int)(num2 * 656987243);
					continue;
				}
				case 0u:
					num = 2119522296;
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		if (!m_Dict.ContainsKey(aKey))
		{
			goto IL_0022;
		}
		goto IL_007f;
		IL_007f:
		JSONNode jSONNode = m_Dict[aKey];
		int num = -377627993;
		goto IL_0056;
		IL_0056:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xEE70A267u) % 6u)
			{
			case 5u:
				num = ((int)num2 * -1067890226) ^ -750647755;
				continue;
			case 4u:
				break;
			case 2u:
				m_Dict.Remove(aKey);
				result = jSONNode;
				num = ((int)num2 * -743693766) ^ 0x1EE9208E;
				continue;
			case 1u:
				result = null;
				num = (int)((num2 * 1093519735) ^ 0x22F77620);
				continue;
			case 3u:
				goto IL_007f;
			default:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_0022:
		num = -443866934;
		goto IL_0056;
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -376068513;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE9DA382Du) % 7u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -537245851) ^ 0x38CBFB3D;
					continue;
				case 4u:
					result = null;
					num = -1420979055;
					continue;
				case 2u:
					if (aIndex < m_Dict.Count)
					{
						num = -1967272460;
						num3 = -1967272460;
						continue;
					}
					goto IL_003f;
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 894982502) ^ 0x6EE7DA41);
						continue;
					}
					goto IL_003f;
				case 0u:
					num = ((int)num2 * -1004040928) ^ -1990173359;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_003f:
					num = -1310363941;
					num3 = -1310363941;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		try
		{
			return null;
		}
		catch
		{
			return null;
		}
	}

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumerator_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -503846391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4F43618u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -100378758) ^ 0x722D9E3A;
					continue;
				case 1u:
					text = "{";
					num = (int)((num2 * 689815381) ^ 0x1BDBAE16);
					continue;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0168:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1260220465;
								num4 = -1260220465;
							}
							else
							{
								num3 = -163878749;
								num4 = -163878749;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB4F43618u) % 8u)
								{
								case 6u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 561759142) ^ 0x2E3FB85E);
									continue;
								case 5u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -227383889;
										num6 = -227383889;
									}
									else
									{
										num5 = -573311381;
										num6 = -573311381;
									}
									num3 = num5 ^ ((int)num2 * -1402958787);
									continue;
								}
								case 4u:
									num3 = (int)(num2 * 1510089388) ^ -1564722391;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = -1299746051;
									continue;
								case 2u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -1579985932;
									continue;
								case 0u:
									num3 = -163878749;
									continue;
								default:
									goto end_IL_0127;
								case 1u:
									break;
								case 7u:
									goto end_IL_0127;
								}
								goto IL_0168;
								continue;
								end_IL_0127:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = -688218814;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xB4F43618u) % 4u)
							{
							case 3u:
								num7 = (int)((num2 * 1027217920) ^ 0x22808089);
								continue;
							case 2u:
								result = text;
								num7 = ((int)num2 * -1293792390) ^ 0x35FA0AC3;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num = -1212877781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBCE7B3Cu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_018b:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -814498062;
								num4 = -814498062;
							}
							else
							{
								num3 = -1240122973;
								num4 = -1240122973;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFBCE7B3Cu) % 9u)
								{
								case 8u:
									current = enumerator.Current;
									num3 = -76077359;
									continue;
								case 7u:
									num3 = -1240122973;
									continue;
								case 6u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -649046418) ^ 0x18FA0CFE;
									continue;
								case 5u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)((num2 * 66500722) ^ 0x4C2B892F);
									continue;
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1011830506) ^ -1249237647;
									continue;
								case 1u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -2113720716;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -104044580;
										num6 = -104044580;
									}
									else
									{
										num5 = -825040353;
										num6 = -825040353;
									}
									num3 = num5 ^ ((int)num2 * -1370841062);
									continue;
								}
								default:
									goto end_IL_0145;
								case 4u:
									break;
								case 2u:
									goto end_IL_0145;
								}
								goto IL_018b;
								continue;
								end_IL_0145:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = -751795041;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xFBCE7B3Cu) % 3u)
							{
							case 1u:
								goto IL_01c0;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_01c0:
							num7 = ((int)num2 * -498913083) ^ -619083660;
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{ ";
				num = (int)(num2 * 1312382425) ^ -1152832994;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		JSONClass.smethod_37(aWriter, m_Dict.Count);
		string current = default(string);
		while (true)
		{
			int num = 85581645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x698678C3u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 1377397037) ^ 0x2D70D658);
					continue;
				case 1u:
					num = (int)(num2 * 173495169) ^ -1667501679;
					continue;
				case 0u:
					break;
				default:
				{
					using Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = 1572444158;
							num4 = 1572444158;
						}
						else
						{
							num3 = 2114267688;
							num4 = 2114267688;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x698678C3u) % 8u)
							{
							case 6u:
								num3 = ((int)num2 * -1782669565) ^ 0x177C5073;
								continue;
							case 4u:
								num3 = 2114267688;
								continue;
							case 3u:
								current = enumerator.Current;
								num3 = 938533221;
								continue;
							case 2u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1338941085) ^ 0x49D9955D;
								continue;
							case 1u:
								num3 = (int)(num2 * 1084234533) ^ -203703351;
								continue;
							case 0u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)(num2 * 556509779) ^ -315302686;
								continue;
							default:
								return;
							case 7u:
								break;
							case 5u:
								return;
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

	static bool smethod_30(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static int smethod_31(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_32(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_33(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_34(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_35(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_36(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_37(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	static void smethod_38(BinaryWriter binaryWriter_0, string string_0)
	{
		binaryWriter_0.Write(string_0);
	}
}
