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
				int num = 1027831996;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5C96915Bu) % 7u)
					{
					case 6u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 988313132) ^ -1853082879;
							continue;
						}
						goto IL_001c;
					case 4u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1340564690) ^ 0x52BF2129;
						continue;
					case 3u:
						if (aIndex < m_List.Count)
						{
							num = 453276193;
							num3 = 453276193;
							continue;
						}
						goto IL_001c;
					case 2u:
						num = (int)((num2 * 1183937955) ^ 0x3BEC582E);
						continue;
					case 0u:
						result = m_List[aIndex];
						num = 1201877748;
						continue;
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_001c:
						num = 413145217;
						num3 = 413145217;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_006c;
			}
			int num = 1;
			goto IL_00af;
			IL_00af:
			bool flag = (byte)num != 0;
			int num2 = -612625168;
			goto IL_0071;
			IL_006c:
			num2 = -755477836;
			goto IL_0071;
			IL_0071:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEE07D03Bu) % 7u)
				{
				case 6u:
					m_List.Add(value);
					num2 = ((int)num3 * -703465177) ^ 0x41722D1D;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1670783671;
						num5 = 1670783671;
					}
					else
					{
						num4 = 893076778;
						num5 = 893076778;
					}
					num2 = num4 ^ ((int)num3 * -1489108002);
					continue;
				}
				case 4u:
					m_List[aIndex] = value;
					num2 = -699667887;
					continue;
				case 3u:
					num2 = (int)((num3 * 1317827053) ^ 0x663315CE);
					continue;
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_009e;
				case 0u:
					return;
				}
				break;
			}
			goto IL_006c;
			IL_009e:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00af;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -867484109;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FEC5D40u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -154390164) ^ -1910814655;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1819078241;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA066E1D2u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 992038274) ^ 0x22F2688C);
						continue;
					case 1u:
						m_List.Add(value);
						num = (int)((num2 * 1609177715) ^ 0x208CBAA);
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
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
				int num = 1433095824;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1FAFAE9Du) % 4u)
					{
					case 2u:
						num = ((int)num2 * -760743066) ^ -580778350;
						continue;
					case 1u:
						count = m_List.Count;
						num = (int)(num2 * 1267016460) ^ -1735784661;
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
			while (true)
			{
				int num = 1058423829;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12BAFFFu) % 3u)
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
					num = (int)((num2 * 70723001) ^ 0x1E5B4D51);
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 996730539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E9583FAu) % 4u)
				{
				case 1u:
					m_List.Add(aItem);
					num = ((int)num2 * -968406237) ^ 0xD34C48D;
					continue;
				case 0u:
					num = ((int)num2 * -690353331) ^ 0x799409FC;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -292947863;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8F7CA79Bu) % 8u)
				{
				case 7u:
					result = null;
					num = ((int)num2 * -1783781020) ^ -481316505;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -130697504;
						num5 = -130697504;
					}
					else
					{
						num4 = -87719437;
						num5 = -87719437;
					}
					num = num4 ^ (int)(num2 * 1394729242);
					continue;
				}
				case 4u:
				{
					JSONNode jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = -1554750682;
					continue;
				}
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1644122033) ^ -1780458300;
						continue;
					}
					num3 = 1;
					goto IL_0074;
				case 1u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0074;
				case 0u:
					num = (int)((num2 * 408220504) ^ 0x269F8326);
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0074:
					flag = (byte)num3 != 0;
					num = -2105825739;
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
			int num = 1669327290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A064BA4u) % 3u)
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
				m_List.Remove(aNode);
				result = aNode;
				num = ((int)num2 * -323325874) ^ -1972397913;
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
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = -382838064;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFA1B89Du) % 3u)
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
							IL_014d:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -458043136;
								num4 = -458043136;
							}
							else
							{
								num3 = -1227753702;
								num4 = -1227753702;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xEFA1B89Du) % 10u)
								{
								case 9u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1960504049;
									continue;
								case 8u:
									num3 = (int)((num2 * 137201263) ^ 0x7E03FBF3);
									continue;
								case 7u:
									current = enumerator.Current;
									num3 = -1373172515;
									continue;
								case 6u:
									num3 = (int)(num2 * 1966501714) ^ -2134227061;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -863936658;
										num6 = -863936658;
									}
									else
									{
										num5 = -1568470970;
										num6 = -1568470970;
									}
									num3 = num5 ^ ((int)num2 * -790485014);
									continue;
								}
								case 3u:
									num3 = -458043136;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1484289567) ^ -2102660565;
									continue;
								case 0u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -921597250) ^ -272026477;
									continue;
								default:
									goto end_IL_0103;
								case 2u:
									break;
								case 5u:
									goto end_IL_0103;
								}
								goto IL_014d;
								continue;
								end_IL_0103:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = -2014249325;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xEFA1B89Du) % 4u)
							{
							case 2u:
								result = string_;
								num7 = ((int)num2 * -1266090661) ^ -1735618190;
								continue;
							case 1u:
								num7 = ((int)num2 * -1572427041) ^ -1142489458;
								continue;
							case 3u:
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
				IL_0008:
				num = (int)((num2 * 1454785101) ^ 0x4871FB54);
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
			while (true)
			{
				IL_0125:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -2124503286;
					num2 = -2124503286;
				}
				else
				{
					num = -813814978;
					num2 = -813814978;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xBC757341u) % 9u)
					{
					case 8u:
						num = -2124503286;
						continue;
					case 7u:
						current = enumerator.Current;
						num = -1210364870;
						continue;
					case 4u:
						num = (int)(num3 * 1882957837) ^ -17745199;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)((num3 * 1495496871) ^ 0x1CD6EFA8);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) <= 3)
						{
							num4 = 932504067;
							num5 = 932504067;
						}
						else
						{
							num4 = 459839398;
							num5 = 459839398;
						}
						num = num4 ^ (int)(num3 * 1107378839);
						continue;
					}
					case 1u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = -3505537;
						continue;
					case 0u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = ((int)num3 * -1489814420) ^ -1656462776;
						continue;
					default:
						goto end_IL_00df;
					case 6u:
						break;
					case 5u:
						goto end_IL_00df;
					}
					goto IL_0125;
					continue;
					end_IL_00df:
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
				IL_0170:
				int num6 = -295593802;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xBC757341u) % 3u)
					{
					case 2u:
						goto IL_0144;
					default:
						goto end_IL_0152;
					case 0u:
						break;
					case 1u:
						goto end_IL_0152;
					}
					goto IL_0170;
					IL_0144:
					num6 = ((int)num3 * -330019293) ^ 0x176CEBA1;
					continue;
					end_IL_0152:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num7 = -1824194480;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xBC757341u) % 4u)
				{
				case 3u:
					num7 = (int)((num3 * 1104958981) ^ 0x7B2D9564);
					continue;
				case 1u:
					result = string_;
					num7 = (int)((num3 * 1838540576) ^ 0x3079812E);
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
		int num3 = default(int);
		while (true)
		{
			int num = -258545865;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC15BB07u) % 11u)
				{
				case 10u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1897566048;
						num5 = 1897566048;
					}
					else
					{
						num4 = 1192438599;
						num5 = 1192438599;
					}
					num = num4 ^ ((int)num2 * -117145450);
					continue;
				}
				case 8u:
					num = (int)(num2 * 1121042755) ^ -1699120443;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1731712004) ^ -1897249619;
					continue;
				case 6u:
					num3 = 0;
					num = (int)((num2 * 1273626219) ^ 0x71C9CAF9);
					continue;
				case 5u:
					num = (int)(num2 * 2028291381) ^ -2134928504;
					continue;
				case 3u:
					m_List[num3].Serialize(aWriter);
					num = -980317230;
					continue;
				case 2u:
					JSONArray.smethod_34(aWriter, (byte)1);
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 807459847) ^ 0x67041A39);
					continue;
				case 1u:
					num = ((int)num2 * -208682732) ^ 0x6D3A9198;
					continue;
				case 0u:
					flag = num3 < m_List.Count;
					num = -1160692543;
					continue;
				default:
					return;
				case 4u:
					break;
				case 9u:
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
