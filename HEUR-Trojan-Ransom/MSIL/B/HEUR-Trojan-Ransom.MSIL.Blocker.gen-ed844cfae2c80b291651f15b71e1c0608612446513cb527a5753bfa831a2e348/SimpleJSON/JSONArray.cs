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
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0017;
			IL_0017:
			int num = 1412794508;
			goto IL_0055;
			IL_0055:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4258F73u) % 6u)
				{
				case 5u:
					break;
				case 4u:
					num = ((int)num2 * -1500932479) ^ -178739645;
					continue;
				case 3u:
					result = new JSONLazyCreator(this);
					num = (int)((num2 * 762501798) ^ 0xC583243);
					continue;
				case 2u:
					result = m_List[aIndex];
					num = 1872278645;
					continue;
				case 1u:
					goto IL_007e;
				default:
					return result;
				}
				break;
				IL_007e:
				if (aIndex < m_List.Count)
				{
					num = 643636007;
					num3 = 643636007;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0017;
			IL_000a:
			num = 964111074;
			num3 = 964111074;
			goto IL_0055;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1343148098;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x580CAFF3u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -373922806) ^ -230335355;
						continue;
					case 7u:
						num = (int)((num2 * 837216319) ^ 0x5A06FA30);
						continue;
					case 6u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_003b;
					case 5u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1806177372) ^ 0x245C5EA9;
							continue;
						}
						num5 = 1;
						goto IL_003b;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1453303305;
							num4 = 1453303305;
						}
						else
						{
							num3 = 230897202;
							num4 = 230897202;
						}
						num = num3 ^ ((int)num2 * -1597568650);
						continue;
					}
					case 1u:
						m_List[aIndex] = value;
						num = 933365413;
						continue;
					case 0u:
						m_List.Add(value);
						num = (int)(num2 * 480010814) ^ -698353726;
						continue;
					default:
						return;
					case 4u:
						break;
					case 3u:
						return;
						IL_003b:
						flag = (byte)num5 != 0;
						num = 729186143;
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
				int num = -1083284499;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAC428117u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = new JSONLazyCreator(this);
					num = ((int)num2 * -211654617) ^ -2016659080;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1478243977;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE6024BBu) % 3u)
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
					num = ((int)num2 * -1829054240) ^ -1591629958;
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
				int num = 1130753407;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x35804916u) % 4u)
					{
					case 1u:
						count = m_List.Count;
						num = ((int)num2 * -1995633518) ^ 0x67DAED8C;
						continue;
					case 0u:
						num = (int)(num2 * 996101762) ^ -2081830376;
						continue;
					case 3u:
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
				int num = -2031889964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3FA0438u) % 3u)
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
					num = ((int)num2 * -2033882584) ^ -434858538;
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
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2041965449;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE674DC7Au) % 11u)
				{
				case 10u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -460268322;
						num5 = -460268322;
					}
					else
					{
						num4 = -1734671858;
						num5 = -1734671858;
					}
					num = num4 ^ (int)(num2 * 1487770537);
					continue;
				}
				case 9u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_003e;
				case 8u:
					jSONNode = m_List[aIndex];
					num = -1432353718;
					continue;
				case 7u:
					num = (int)(num2 * 1275493189) ^ -1649309918;
					continue;
				case 6u:
					result = null;
					num = (int)(num2 * 65126474) ^ -101542505;
					continue;
				case 5u:
					result = jSONNode;
					num = (int)(num2 * 1678725646) ^ -678988165;
					continue;
				case 3u:
					m_List.RemoveAt(aIndex);
					num = ((int)num2 * -467024960) ^ -182186126;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 1358218260) ^ -2136525864;
						continue;
					}
					num3 = 1;
					goto IL_003e;
				case 0u:
					num = ((int)num2 * -671116481) ^ 0x449C3524;
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_003e:
					flag = (byte)num3 != 0;
					num = -258843488;
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
			int num = -463455386;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89D6F216u) % 5u)
				{
				case 4u:
					m_List.Remove(aNode);
					num = (int)((num2 * 1713932845) ^ 0x2F940B6A);
					continue;
				case 2u:
					result = aNode;
					num = ((int)num2 * -1809632701) ^ 0x2429BD6;
					continue;
				case 1u:
					num = ((int)num2 * -1741003340) ^ -1037253156;
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
		while (true)
		{
			int num = -739346137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9278E808u) % 3u)
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
							IL_0120:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1233034466;
								num4 = -1233034466;
							}
							else
							{
								num3 = -278462197;
								num4 = -278462197;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x9278E808u) % 8u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1080465407;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = -415675972;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = -1044616673;
										num6 = -1044616673;
									}
									else
									{
										num5 = -1289054424;
										num6 = -1289054424;
									}
									num3 = num5 ^ (int)(num2 * 480987154);
									continue;
								}
								case 2u:
									num3 = -1233034466;
									continue;
								case 1u:
									num3 = ((int)num2 * -2050897080) ^ 0x541CD4D;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -2084160469) ^ 0x4523356F;
									continue;
								default:
									goto end_IL_00df;
								case 5u:
									break;
								case 3u:
									goto end_IL_00df;
								}
								goto IL_0120;
								continue;
								end_IL_00df:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num7 = -1982428134;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x9278E808u) % 3u)
							{
							case 1u:
								goto IL_014f;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_014f:
							num7 = (int)((num2 * 7798418) ^ 0x20B42DB5);
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1883195106) ^ 0x2F9EA13C;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = -2113335883;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE319C7DEu) % 4u)
				{
				case 3u:
					string_ = "[ ";
					num = (int)(num2 * 1004705180) ^ -1000073013;
					continue;
				case 1u:
					num = (int)((num2 * 535433239) ^ 0x7464E2CF);
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_019c:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -238820014;
								num4 = -238820014;
							}
							else
							{
								num3 = -1154066316;
								num4 = -1154066316;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE319C7DEu) % 11u)
								{
								case 10u:
									num3 = -1154066316;
									continue;
								case 9u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = ((int)num2 * -265900309) ^ -1512293386;
									continue;
								case 7u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -192932649;
									continue;
								case 5u:
									num3 = ((int)num2 * -1501871954) ^ 0x46E37337;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1972339236) ^ 0x61C69C28;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = -1200586648;
									continue;
								case 2u:
									num3 = (int)((num2 * 740931602) ^ 0x19D67401);
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1993878265;
										num6 = -1993878265;
									}
									else
									{
										num5 = -1226579685;
										num6 = -1226579685;
									}
									num3 = num5 ^ ((int)num2 * -1792925649);
									continue;
								}
								case 0u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 1254818348) ^ -1325293387;
									continue;
								default:
									goto end_IL_014e;
								case 8u:
									break;
								case 6u:
									goto end_IL_014e;
								}
								goto IL_019c;
								continue;
								end_IL_014e:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = -516918493;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xE319C7DEu) % 4u)
							{
							case 2u:
								num7 = (int)((num2 * 795677224) ^ 0x7CE0277D);
								continue;
							case 1u:
								result = string_;
								num7 = ((int)num2 * -887610445) ^ 0x3B012E27;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		while (true)
		{
			int num = -1942484942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C92690Du) % 10u)
				{
				case 8u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = -596124787;
						num4 = -596124787;
					}
					else
					{
						num = -286240448;
						num4 = -286240448;
					}
					continue;
				}
				case 7u:
					num3++;
					num = ((int)num2 * -1387479165) ^ 0x616B58CE;
					continue;
				case 6u:
					num = ((int)num2 * -1280337648) ^ -1205094914;
					continue;
				case 5u:
					m_List[num3].Serialize(aWriter);
					num = -2112725695;
					continue;
				case 3u:
					num = ((int)num2 * -815569629) ^ 0x4CE6C04C;
					continue;
				case 2u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1112318619) ^ 0x3389CA1F);
					continue;
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)(num2 * 266332579) ^ -497106269;
					continue;
				case 0u:
					num3 = 0;
					num = (int)(num2 * 756573520) ^ -1031015433;
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
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
			int num = 273965214;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70D82B23u) % 3u)
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
				num = ((int)num2 * -1490679049) ^ 0xE385054;
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
