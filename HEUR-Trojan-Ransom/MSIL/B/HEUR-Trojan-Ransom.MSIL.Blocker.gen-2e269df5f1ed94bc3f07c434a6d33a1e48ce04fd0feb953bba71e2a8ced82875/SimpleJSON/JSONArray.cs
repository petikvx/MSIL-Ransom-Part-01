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
				int num = 345474473;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5A2A371Bu) % 8u)
					{
					case 7u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0017;
					case 6u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1564369550;
							num5 = -1564369550;
						}
						else
						{
							num4 = -1677439620;
							num5 = -1677439620;
						}
						num = num4 ^ (int)(num2 * 778410866);
						continue;
					}
					case 5u:
						result = new JSONLazyCreator(this);
						num = (int)((num2 * 1048835638) ^ 0x734CCEB9);
						continue;
					case 3u:
						result = m_List[aIndex];
						num = 714500906;
						continue;
					case 2u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1452369894) ^ 0x864C388);
							continue;
						}
						num3 = 1;
						goto IL_0017;
					case 1u:
						num = (int)(num2 * 251414683) ^ -497459940;
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num3 != 0;
						num = 950932285;
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
				int num = 1462695491;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x3EB0525Au) % 8u)
					{
					case 7u:
						m_List[aIndex] = value;
						num = 2050775130;
						continue;
					case 6u:
						num = (int)(num2 * 944409883) ^ -433272768;
						continue;
					case 5u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_003a;
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1161526172;
							num5 = 1161526172;
						}
						else
						{
							num4 = 85877161;
							num5 = 85877161;
						}
						num = num4 ^ ((int)num2 * -591640221);
						continue;
					}
					case 2u:
						m_List.Add(value);
						num = (int)(num2 * 1653103107) ^ -442606630;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1150106168) ^ -682913705;
							continue;
						}
						num3 = 1;
						goto IL_003a;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
						IL_003a:
						flag = (byte)num3 != 0;
						num = 635609934;
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
			return new JSONLazyCreator(this);
		}
		set
		{
			while (true)
			{
				int num = -1104351393;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9EC2C300u) % 3u)
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
					num = (int)((num2 * 1839743889) ^ 0xF1875F3);
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
				int num = -1045676724;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0001BB5u) % 3u)
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
					num = ((int)num2 * -1167942845) ^ -261632880;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 810539089;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x135F7D90u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -1921548907) ^ -1659328942;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
		while (true)
		{
			int num = 1113667063;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11416939u) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = (int)(num2 * 157955911) ^ -1772820484;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0066;
		}
		goto IL_00d4;
		IL_0066:
		int num = -1564461720;
		goto IL_008b;
		IL_008b:
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xC3B7E017u) % 9u)
			{
			case 8u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num = -785742755;
				continue;
			case 7u:
				num = (int)(num2 * 1452781485) ^ -1373337555;
				continue;
			case 6u:
				num = (int)(num2 * 1163857103) ^ -1197936485;
				continue;
			case 5u:
				result = null;
				num = (int)(num2 * 2022847118) ^ -1025763029;
				continue;
			case 3u:
				break;
			case 2u:
				result = jSONNode;
				num = (int)((num2 * 326768421) ^ 0x672A8FF4);
				continue;
			case 0u:
				num = ((int)num2 * -841711324) ^ 0x7DAF9C95;
				continue;
			case 1u:
				goto IL_00c1;
			default:
				return result;
			}
			break;
			IL_00c1:
			if (aIndex < m_List.Count)
			{
				num = -282091925;
				num3 = -282091925;
				continue;
			}
			goto IL_00d4;
		}
		goto IL_0066;
		IL_00d4:
		num = -488019344;
		num3 = -488019344;
		goto IL_008b;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1022056119;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF80CE7ECu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1040137539) ^ -26400973;
					continue;
				case 1u:
					m_List.Remove(aNode);
					num = (int)(num2 * 1391032062) ^ -1050028756;
					continue;
				case 0u:
					result = aNode;
					num = (int)((num2 * 1391704286) ^ 0x399916AE);
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
		bool flag = default(bool);
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = -625264299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC53E0030u) % 3u)
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
							IL_014e:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1296357696;
								num4 = -1296357696;
							}
							else
							{
								num3 = -972637335;
								num4 = -972637335;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC53E0030u) % 10u)
								{
								case 9u:
									num3 = (int)((num2 * 1090505128) ^ 0x5DD40EC1);
									continue;
								case 7u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -119464603) ^ -935093275;
									continue;
								case 6u:
									num3 = (int)((num2 * 400455161) ^ 0x77D74FC6);
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = -1047226033;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1129607419;
										num6 = -1129607419;
									}
									else
									{
										num5 = -432172971;
										num6 = -432172971;
									}
									num3 = num5 ^ (int)(num2 * 1045878084);
									continue;
								}
								case 3u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -282460549) ^ 0x519943E2;
									continue;
								case 2u:
									num3 = -972637335;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -341123396;
									continue;
								default:
									goto end_IL_0104;
								case 8u:
									break;
								case 0u:
									goto end_IL_0104;
								}
								goto IL_014e;
								continue;
								end_IL_0104:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_31(string_, " ]");
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -774072466) ^ 0x2250D81F;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = -2077452069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DB29194u) % 4u)
				{
				case 3u:
					string_ = "[ ";
					num = ((int)num2 * -909674674) ^ 0x5D8F79EC;
					continue;
				case 2u:
					num = (int)((num2 * 1784559021) ^ 0x39D7C7B3);
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_013d:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1611828538;
								num4 = -1611828538;
							}
							else
							{
								num3 = -726297717;
								num4 = -726297717;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x8DB29194u) % 7u)
								{
								case 6u:
									num3 = (int)(num2 * 1590288234) ^ -1786335604;
									continue;
								case 5u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -1600619814;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 1729481141) ^ 0x31C74927);
									continue;
								case 2u:
								{
									current = enumerator.Current;
									int num5;
									if (JSONArray.smethod_30(string_) > 3)
									{
										num3 = -1310596134;
										num5 = -1310596134;
									}
									else
									{
										num3 = -538819071;
										num5 = -538819071;
									}
									continue;
								}
								case 0u:
									num3 = -726297717;
									continue;
								default:
									goto end_IL_0100;
								case 3u:
									break;
								case 1u:
									goto end_IL_0100;
								}
								goto IL_013d;
								continue;
								end_IL_0100:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_33(string_, "\n", aPrefix, "]");
				}
				}
				break;
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
			int num = -282970279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85EC15EFu) % 13u)
				{
				case 12u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -312643461) ^ -1235865695;
					continue;
				case 11u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -1230303559) ^ -1824872479;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1044841558;
						num5 = 1044841558;
					}
					else
					{
						num4 = 338955896;
						num5 = 338955896;
					}
					num = num4 ^ ((int)num2 * -1458197601);
					continue;
				}
				case 9u:
					num = (int)((num2 * 1785817654) ^ 0x66359810);
					continue;
				case 8u:
					num = -860406021;
					continue;
				case 7u:
					flag = num3 < m_List.Count;
					num = -808498053;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -1819450443) ^ -1099849417;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 2106345096) ^ -464503015;
					continue;
				case 3u:
					num = (int)((num2 * 1152716335) ^ 0x6DD16A28);
					continue;
				case 2u:
					num = (int)(num2 * 1016398628) ^ -1791111117;
					continue;
				case 1u:
					num = (int)((num2 * 48109948) ^ 0x396FA0D);
					continue;
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
