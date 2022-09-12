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
			if (aIndex >= 0)
			{
				goto IL_000a;
			}
			int num = 1;
			goto IL_00aa;
			IL_00aa:
			bool flag = (byte)num != 0;
			int num2 = -1292270480;
			goto IL_006c;
			IL_000a:
			num2 = -2041089138;
			goto IL_006c;
			IL_006c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB092AE4Du) % 7u)
				{
				case 6u:
					break;
				case 5u:
					num2 = ((int)num3 * -1144745186) ^ 0x6B878352;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -177061674;
						num5 = -177061674;
					}
					else
					{
						num4 = -1358099242;
						num5 = -1358099242;
					}
					num2 = num4 ^ ((int)num3 * -429304735);
					continue;
				}
				case 3u:
					result = m_List[aIndex];
					num2 = -1165487080;
					continue;
				case 0u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -1957072234) ^ 0x4387F742;
					continue;
				case 1u:
					goto IL_0099;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_0099:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00aa;
		}
		set
		{
			while (true)
			{
				int num = -2048422692;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xEDE1D10Bu) % 9u)
					{
					case 7u:
						m_List[aIndex] = value;
						num = -969596767;
						continue;
					case 6u:
						num = ((int)num2 * -1912248570) ^ 0x612CDCCF;
						continue;
					case 5u:
						m_List.Add(value);
						num = (int)((num2 * 613179370) ^ 0x20D52348);
						continue;
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 1813310028) ^ 0x69E0DD63);
							continue;
						}
						goto IL_005d;
					case 2u:
						num = (int)((num2 * 942537256) ^ 0x5FA69396);
						continue;
					case 1u:
						if (aIndex < m_List.Count)
						{
							num = -672220936;
							num3 = -672220936;
							continue;
						}
						goto IL_005d;
					case 0u:
						num = ((int)num2 * -523821478) ^ 0xD5BED91;
						continue;
					default:
						return;
					case 8u:
						break;
					case 3u:
						return;
						IL_005d:
						num = -1332202754;
						num3 = -1332202754;
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
				int num = 660262086;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x375DD191u) % 4u)
					{
					case 3u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1529256461) ^ -1840258680;
						continue;
					case 0u:
						num = ((int)num2 * -1261967734) ^ 0x4F3513BC;
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

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 2005300876;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x723DE285u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -2124684055) ^ -1667489292;
						continue;
					case 1u:
						count = m_List.Count;
						num = ((int)num2 * -258302229) ^ -1662190252;
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
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 319434022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x67135F5Bu) % 3u)
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
					num = (int)((num2 * 1600705422) ^ 0x60C75D55);
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -392992169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF4D6FB6u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2129025960) ^ -693597874;
					continue;
				case 1u:
					m_List.Add(aItem);
					num = (int)(num2 * 1415372969) ^ -939544227;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
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
			goto IL_000a;
		}
		int num = 1;
		goto IL_00dd;
		IL_00dd:
		bool flag = (byte)num != 0;
		int num2 = 2043558824;
		goto IL_0096;
		IL_000a:
		num2 = 1741788946;
		goto IL_0096;
		IL_0096:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x66A9DDD9u) % 9u)
			{
			case 7u:
				break;
			case 6u:
				num2 = ((int)num3 * -839974654) ^ -1088061315;
				continue;
			case 4u:
				result = null;
				num2 = (int)(num3 * 1266481824) ^ -1536432838;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -695515047;
					num5 = -695515047;
				}
				else
				{
					num4 = -305861967;
					num5 = -305861967;
				}
				num2 = num4 ^ (int)(num3 * 1666129457);
				continue;
			}
			case 2u:
				result = jSONNode;
				num2 = (int)(num3 * 1230035872) ^ -1919410121;
				continue;
			case 1u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = 404584491;
				continue;
			case 0u:
				num2 = (int)((num3 * 1538685447) ^ 0x6F7C87F4);
				continue;
			case 8u:
				goto IL_00cc;
			default:
				return result;
			}
			break;
		}
		goto IL_000a;
		IL_00cc:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00dd;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1529682824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC32C7F6u) % 5u)
				{
				case 3u:
					result = aNode;
					num = ((int)num2 * -60325614) ^ 0x7E47539A;
					continue;
				case 2u:
					num = (int)((num2 * 954873137) ^ 0x7E97E48A);
					continue;
				case 1u:
					m_List.Remove(aNode);
					num = ((int)num2 * -98398135) ^ 0x1C99F5A8;
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
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = -314607398;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAFD4CD01u) % 4u)
				{
				case 3u:
					string_ = "[ ";
					num = ((int)num2 * -1491204882) ^ -246425961;
					continue;
				case 0u:
					num = ((int)num2 * -375662814) ^ -138274248;
					continue;
				case 2u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_011f:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -482328268;
								num4 = -482328268;
							}
							else
							{
								num3 = -359455483;
								num4 = -359455483;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xAFD4CD01u) % 7u)
								{
								case 6u:
									num3 = -482328268;
									continue;
								case 5u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = -109810376;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 887688783;
										num6 = 887688783;
									}
									else
									{
										num5 = 1424142774;
										num6 = 1424142774;
									}
									num3 = num5 ^ ((int)num2 * -1877343371);
									continue;
								}
								case 3u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1132535886;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -2138995664) ^ 0x5AF051A2;
									continue;
								default:
									goto end_IL_00e2;
								case 1u:
									break;
								case 2u:
									goto end_IL_00e2;
								}
								goto IL_011f;
								continue;
								end_IL_00e2:
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
							IL_016a:
							int num7 = -2077539503;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xAFD4CD01u) % 3u)
								{
								case 1u:
									goto IL_013e;
								default:
									goto end_IL_014c;
								case 0u:
									break;
								case 2u:
									goto end_IL_014c;
								}
								goto IL_016a;
								IL_013e:
								num7 = (int)((num2 * 1465042957) ^ 0x727FD696);
								continue;
								end_IL_014c:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num8 = -1562412021;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xAFD4CD01u) % 3u)
							{
							case 1u:
								goto IL_0183;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0183:
							num8 = (int)((num2 * 500870886) ^ 0x71CEEC7A);
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
			int num = 1391244667;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D42BFCDu) % 3u)
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
							IL_0140:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 2011176763;
								num4 = 2011176763;
							}
							else
							{
								num3 = 1537508888;
								num4 = 1537508888;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x1D42BFCDu) % 8u)
								{
								case 6u:
									current = enumerator.Current;
									num3 = 2142923297;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -577390306;
										num6 = -577390306;
									}
									else
									{
										num5 = -464242923;
										num6 = -464242923;
									}
									num3 = num5 ^ ((int)num2 * -1895402332);
									continue;
								}
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 504424916;
									continue;
								case 2u:
									num3 = 2011176763;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 1356026630) ^ -1436098076;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1555810714) ^ -1776460706;
									continue;
								default:
									goto end_IL_00ff;
								case 7u:
									break;
								case 5u:
									goto end_IL_00ff;
								}
								goto IL_0140;
								continue;
								end_IL_00ff:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num7 = 1815139461;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x1D42BFCDu) % 3u)
							{
							case 1u:
								goto IL_0175;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0175:
							num7 = (int)((num2 * 1299939348) ^ 0x1120CECA);
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)(num2 * 641432251) ^ -1950213529;
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
			int num = 1131697262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32AB83AEu) % 11u)
				{
				case 10u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 640089364) ^ -818269190;
					continue;
				case 9u:
					num = 1851097932;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -662083633) ^ 0x69B263D;
					continue;
				case 6u:
					num = ((int)num2 * -2104145291) ^ -1827030706;
					continue;
				case 5u:
					flag = num3 < m_List.Count;
					num = 78555878;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1693588622;
						num5 = 1693588622;
					}
					else
					{
						num4 = 356902411;
						num5 = 356902411;
					}
					num = num4 ^ (int)(num2 * 1744862627);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1945946912) ^ 0x427BA249;
					continue;
				case 2u:
					m_List[num3].Serialize(aWriter);
					num = (int)((num2 * 70244342) ^ 0x43EB8089);
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -724684007) ^ -114164768;
					continue;
				default:
					return;
				case 8u:
					break;
				case 1u:
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
			int num = -1054845405;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8DD310DDu) % 3u)
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
				num = ((int)num2 * -1972804115) ^ -1411138423;
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
