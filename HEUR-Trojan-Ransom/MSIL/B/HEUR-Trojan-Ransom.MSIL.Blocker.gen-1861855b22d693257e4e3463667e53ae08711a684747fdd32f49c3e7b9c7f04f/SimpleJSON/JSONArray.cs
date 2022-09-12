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
				goto IL_0044;
			}
			int num = 1;
			goto IL_00aa;
			IL_0099:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00aa;
			IL_0044:
			int num2 = 844500930;
			goto IL_006c;
			IL_006c:
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x41F7B9A5u) % 7u)
				{
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1638788613;
						num5 = -1638788613;
					}
					else
					{
						num4 = -2027373510;
						num5 = -2027373510;
					}
					num2 = num4 ^ ((int)num3 * -634268947);
					continue;
				}
				case 4u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -1241893329) ^ 0xE263105;
					continue;
				case 3u:
					break;
				case 2u:
					result = m_List[aIndex];
					num2 = 122957511;
					continue;
				case 0u:
					num2 = ((int)num3 * -1263406974) ^ 0x6466DD2F;
					continue;
				case 1u:
					goto IL_0099;
				default:
					return result;
				}
				break;
			}
			goto IL_0044;
			IL_00aa:
			flag = (byte)num != 0;
			num2 = 712777594;
			goto IL_006c;
		}
		set
		{
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0032;
			IL_0032:
			int num = 2130931450;
			goto IL_005a;
			IL_005a:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59D16437u) % 6u)
				{
				case 5u:
					m_List.Add(value);
					num = (int)((num2 * 1653673090) ^ 0x45F3682D);
					continue;
				case 3u:
					break;
				case 2u:
					m_List[aIndex] = value;
					num = 1107562293;
					continue;
				case 0u:
					num = (int)(num2 * 453055068) ^ -185567355;
					continue;
				default:
					return;
				case 1u:
					goto IL_0083;
				case 4u:
					return;
				}
				break;
				IL_0083:
				if (aIndex < m_List.Count)
				{
					num = 1738396493;
					num3 = 1738396493;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0032;
			IL_000a:
			num = 299781280;
			num3 = 299781280;
			goto IL_005a;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -369801981;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8DE13D97u) % 3u)
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
					num = ((int)num2 * -173965075) ^ -1333117165;
				}
			}
		}
		set
		{
			m_List.Add(value);
		}
	}

	public override int Count => m_List.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			while (true)
			{
				int num = 902049386;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48053722u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)(num2 * 255391693) ^ -833189764;
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
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 563315751;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x1A3C97F8u) % 9u)
				{
				case 8u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -275341851) ^ -1075955330;
						continue;
					}
					num5 = 1;
					goto IL_001d;
				case 6u:
					jSONNode = m_List[aIndex];
					num = 117681616;
					continue;
				case 4u:
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = (int)((num2 * 740706146) ^ 0x268B9866);
					continue;
				case 3u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_001d;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1275365658;
						num4 = -1275365658;
					}
					else
					{
						num3 = -684995826;
						num4 = -684995826;
					}
					num = num3 ^ (int)(num2 * 377346134);
					continue;
				}
				case 1u:
					num = ((int)num2 * -488041450) ^ 0x35F08262;
					continue;
				case 0u:
					result = null;
					num = ((int)num2 * -1523749233) ^ -1490390802;
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_001d:
					flag = (byte)num5 != 0;
					num = 1126557329;
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
			int num = -320121080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDE68CE3u) % 4u)
				{
				case 3u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -270205622) ^ -1643506984;
					continue;
				case 1u:
					num = (int)(num2 * 717729762) ^ -713899165;
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
			int num = -157965395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF35172B3u) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = ((int)num2 * -764918110) ^ -423100578;
					continue;
				case 1u:
					num = (int)(num2 * 414670566) ^ -1373464639;
					continue;
				case 3u:
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
								num3 = -2059897769;
								num4 = -2059897769;
							}
							else
							{
								num3 = -729372612;
								num4 = -729372612;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF35172B3u) % 8u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = -1396057669;
									continue;
								case 5u:
									num3 = (int)((num2 * 500767148) ^ 0x64B48211);
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -44459434;
									continue;
								case 2u:
									num3 = -729372612;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1380689282) ^ -147044226;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = 2018597616;
										num6 = 2018597616;
									}
									else
									{
										num5 = 1607968754;
										num6 = 1607968754;
									}
									num3 = num5 ^ ((int)num2 * -712800198);
									continue;
								}
								default:
									goto end_IL_00f3;
								case 6u:
									break;
								case 4u:
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
						int num7 = -1823911857;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xF35172B3u) % 3u)
							{
							case 1u:
								goto IL_0160;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0160:
							result = string_;
							num7 = ((int)num2 * -1641244728) ^ 0x6D95E3C2;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		while (true)
		{
			int num = -1009608284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB81CC3DDu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1682447877) ^ -58836596;
					continue;
				case 1u:
					string_ = "[ ";
					num = ((int)num2 * -1433950772) ^ 0x184B9A8F;
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0156:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -897887092;
								num4 = -897887092;
							}
							else
							{
								num3 = -907811950;
								num4 = -907811950;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB81CC3DDu) % 8u)
								{
								case 6u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1162610779) ^ -1379949812;
									continue;
								case 5u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = (int)((num2 * 477164153) ^ 0x4B6B4A48);
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -576141799;
									continue;
								case 2u:
									num3 = -897887092;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -915670032;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1648792267;
										num6 = 1648792267;
									}
									else
									{
										num5 = 228387230;
										num6 = 228387230;
									}
									num3 = num5 ^ (int)(num2 * 1417178150);
									continue;
								}
								default:
									goto end_IL_0115;
								case 4u:
									break;
								case 7u:
									goto end_IL_0115;
								}
								goto IL_0156;
								continue;
								end_IL_0115:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num7 = -259105368;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xB81CC3DDu) % 3u)
							{
							case 1u:
								goto IL_018b;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_018b:
							num7 = (int)(num2 * 1016888162) ^ -812353562;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1551660871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF55FF36u) % 11u)
				{
				case 10u:
					num = (int)((num2 * 525474659) ^ 0x735FF4E9);
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -1161229348) ^ 0x7739B4F7;
					continue;
				case 7u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 405567700) ^ 0x14F794AC);
					continue;
				case 6u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 608548577) ^ -1834903030;
					continue;
				case 5u:
					flag = num3 < m_List.Count;
					num = -40239112;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 834871708;
						num5 = 834871708;
					}
					else
					{
						num4 = 783294835;
						num5 = 783294835;
					}
					num = num4 ^ ((int)num2 * -13540037);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1968988597) ^ 0x452023AF;
					continue;
				case 2u:
					num3 = 0;
					num = (int)(num2 * 1977395904) ^ -869484017;
					continue;
				case 1u:
					m_List[num3].Serialize(aWriter);
					num = -814998988;
					continue;
				default:
					return;
				case 0u:
					break;
				case 9u:
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
			int num = -475133663;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x895F4DD2u) % 3u)
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
				num = ((int)num2 * -1535561866) ^ 0x2717E5F0;
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
