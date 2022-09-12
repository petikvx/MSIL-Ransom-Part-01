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
			while (true)
			{
				int num = 1971601081;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x6CC9D404u) % 6u)
					{
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 764326575) ^ -1504529143;
							continue;
						}
						goto IL_0028;
					case 2u:
						result = m_List[aIndex];
						num = 837091645;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 2014657412) ^ -512442927;
						continue;
					case 0u:
						if (aIndex < m_List.Count)
						{
							num = 1477289398;
							num3 = 1477289398;
							continue;
						}
						goto IL_0028;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0028:
						num = 343775647;
						num3 = 343775647;
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
			goto IL_0049;
			IL_0049:
			int num = 1030446681;
			goto IL_0078;
			IL_0078:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30FEE894u) % 8u)
				{
				case 7u:
					m_List[aIndex] = value;
					num = 1852302844;
					continue;
				case 6u:
					num = (int)(num2 * 1155097821) ^ -1716396234;
					continue;
				case 4u:
					num = (int)(num2 * 1332120568) ^ -1689267226;
					continue;
				case 3u:
					break;
				case 1u:
					m_List.Add(value);
					num = (int)(num2 * 1973330496) ^ -1491075374;
					continue;
				case 0u:
					num = ((int)num2 * -2097711453) ^ -352128642;
					continue;
				default:
					return;
				case 5u:
					goto IL_00a9;
				case 2u:
					return;
				}
				break;
				IL_00a9:
				if (aIndex < m_List.Count)
				{
					num = 566102299;
					num3 = 566102299;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0049;
			IL_000a:
			num = 1875265493;
			num3 = 1875265493;
			goto IL_0078;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			return new JSONLazyCreator(this);
		}
		set
		{
			while (true)
			{
				int num = -355624249;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92C75744u) % 3u)
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
					num = (int)(num2 * 24871860) ^ -861760568;
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
				int num = -1332942568;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA157B31Bu) % 4u)
					{
					case 3u:
						count = m_List.Count;
						num = (int)(num2 * 818456855) ^ -1007651388;
						continue;
					case 2u:
						num = (int)(num2 * 674408025) ^ -246582312;
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
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
		if (aIndex < 0)
		{
			goto IL_000a;
		}
		goto IL_0077;
		IL_0077:
		int num = 822759246;
		goto IL_007c;
		IL_007c:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1343FD9Du) % 8u)
			{
			case 7u:
				m_List.RemoveAt(aIndex);
				num = ((int)num2 * -2037009324) ^ 0x2772E38;
				continue;
			case 6u:
				result = null;
				num = (int)((num2 * 84583606) ^ 0x31513D3);
				continue;
			case 4u:
				jSONNode = m_List[aIndex];
				num = 318364498;
				continue;
			case 2u:
				num = ((int)num2 * -1920606676) ^ 0x6B2EE338;
				continue;
			case 1u:
				result = jSONNode;
				num = (int)(num2 * 1632479607) ^ -1513909393;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_00ad;
			default:
				return result;
			}
			break;
			IL_00ad:
			if (aIndex < m_List.Count)
			{
				num = 1705036641;
				num3 = 1705036641;
				continue;
			}
			goto IL_000a;
		}
		goto IL_0077;
		IL_000a:
		num = 1351871739;
		num3 = 1351871739;
		goto IL_007c;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 513560380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BA3E3C5u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				m_List.Remove(aNode);
				result = aNode;
				num = ((int)num2 * -631982629) ^ 0x178B6C1A;
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
			int num = 1293272484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x773395E0u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0122:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 214530197;
								num4 = 214530197;
							}
							else
							{
								num3 = 1837444058;
								num4 = 1837444058;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x773395E0u) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -475107831;
										num6 = -475107831;
									}
									else
									{
										num5 = -1891474301;
										num6 = -1891474301;
									}
									num3 = num5 ^ ((int)num2 * -1706075600);
									continue;
								}
								case 6u:
									num3 = 214530197;
									continue;
								case 5u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = 1543542303;
									continue;
								case 4u:
									num3 = ((int)num2 * -845773353) ^ 0x6B601574;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 271748176) ^ -957263831;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 49489932;
									continue;
								default:
									goto end_IL_00e1;
								case 0u:
									break;
								case 2u:
									goto end_IL_00e1;
								}
								goto IL_0122;
								continue;
								end_IL_00e1:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = 1172315959;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x773395E0u) % 3u)
							{
							case 2u:
								goto IL_014e;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_014e:
							result = string_;
							num7 = ((int)num2 * -1734245564) ^ -167433548;
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)(num2 * 2101960652) ^ -1534878564;
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
			bool flag = default(bool);
			while (true)
			{
				IL_0124:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -646548549;
					num2 = -646548549;
				}
				else
				{
					num = -156387388;
					num2 = -156387388;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x9FE682F5u) % 9u)
					{
					case 8u:
						num = -646548549;
						continue;
					case 7u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -104282238) ^ -320950016;
						continue;
					case 6u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = (int)((num3 * 944303587) ^ 0x7E39B32C);
						continue;
					case 5u:
						current = enumerator.Current;
						num = -844255113;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -905995473;
							num5 = -905995473;
						}
						else
						{
							num4 = -889090042;
							num5 = -889090042;
						}
						num = num4 ^ ((int)num3 * -1305192233);
						continue;
					}
					case 3u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = -753300080;
						continue;
					case 1u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = ((int)num3 * -719797225) ^ 0x4B021419;
						continue;
					default:
						goto end_IL_00de;
					case 2u:
						break;
					case 0u:
						goto end_IL_00de;
					}
					goto IL_0124;
					continue;
					end_IL_00de:
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
				IL_016f:
				int num6 = -665130697;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x9FE682F5u) % 3u)
					{
					case 2u:
						goto IL_0143;
					default:
						goto end_IL_0151;
					case 0u:
						break;
					case 1u:
						goto end_IL_0151;
					}
					goto IL_016f;
					IL_0143:
					num6 = ((int)num3 * -653034239) ^ 0x6472A2BE;
					continue;
					end_IL_0151:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num7 = -1242053528;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x9FE682F5u) % 4u)
				{
				case 2u:
					num7 = ((int)num3 * -842147443) ^ 0x2AF3B4AC;
					continue;
				case 1u:
					result = string_;
					num7 = ((int)num3 * -7951416) ^ 0xD5B6BCB;
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
		bool flag = default(bool);
		int num5 = default(int);
		while (true)
		{
			int num = 1929799389;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F46F898u) % 10u)
				{
				case 9u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 1525631971) ^ 0x3C6BE982);
					continue;
				case 8u:
					flag = num5 < m_List.Count;
					num = 76882108;
					continue;
				case 6u:
					num5 = 0;
					num = (int)(num2 * 1151176581) ^ -285384630;
					continue;
				case 4u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1172299586) ^ 0x5B5E3690);
					continue;
				case 3u:
					num = 2018278838;
					continue;
				case 2u:
					m_List[num5].Serialize(aWriter);
					num5++;
					num = ((int)num2 * -124749271) ^ 0x74DD92EC;
					continue;
				case 1u:
					num = ((int)num2 * -724603667) ^ -111483711;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1270056115;
						num4 = 1270056115;
					}
					else
					{
						num3 = 336595963;
						num4 = 336595963;
					}
					num = num3 ^ ((int)num2 * -423531165);
					continue;
				}
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
