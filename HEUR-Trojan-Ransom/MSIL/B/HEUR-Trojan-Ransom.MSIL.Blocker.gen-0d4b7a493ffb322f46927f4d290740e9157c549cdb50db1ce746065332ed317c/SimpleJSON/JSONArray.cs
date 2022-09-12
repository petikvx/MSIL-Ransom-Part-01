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
			bool flag = default(bool);
			while (true)
			{
				int num = 1985228935;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x22F43DD8u) % 9u)
					{
					case 8u:
						num = (int)(num2 * 82845336) ^ -2059128788;
						continue;
					case 7u:
						result = m_List[aIndex];
						num = 1036262996;
						continue;
					case 6u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1501738620) ^ 0x6EB5B88C;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 2026447600;
							num5 = 2026447600;
						}
						else
						{
							num4 = 1882540107;
							num5 = 1882540107;
						}
						num = num4 ^ ((int)num2 * -1986042508);
						continue;
					}
					case 2u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0077;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1752709089) ^ -1602891007;
							continue;
						}
						num3 = 1;
						goto IL_0077;
					case 0u:
						num = ((int)num2 * -473123113) ^ -1082349904;
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0077:
						flag = (byte)num3 != 0;
						num = 2058899041;
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
				int num = 965717195;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1DF3270Au) % 10u)
					{
					case 9u:
						num = (int)(num2 * 702399817) ^ -236401285;
						continue;
					case 8u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1848072079;
							num5 = -1848072079;
						}
						else
						{
							num4 = -1147642252;
							num5 = -1147642252;
						}
						num = num4 ^ ((int)num2 * -1708011401);
						continue;
					}
					case 7u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 588167217) ^ -1567539431;
							continue;
						}
						num3 = 1;
						goto IL_0050;
					case 6u:
						num = ((int)num2 * -1282835034) ^ 0x100A5836;
						continue;
					case 4u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0050;
					case 3u:
						num = (int)((num2 * 157794049) ^ 0x16480388);
						continue;
					case 2u:
						m_List.Add(value);
						num = ((int)num2 * -1759008063) ^ -1508514325;
						continue;
					case 1u:
						m_List[aIndex] = value;
						num = 1971894266;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
						IL_0050:
						flag = (byte)num3 != 0;
						num = 476668322;
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
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = 707915465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4DC80529u) % 3u)
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
					num = (int)(num2 * 736861776) ^ -189872894;
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
				int num = 691488753;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D58F6EAu) % 3u)
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
					num = ((int)num2 * -1544431897) ^ 0x20FF0C4B;
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
				int num = 962392780;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7AD8BCCBu) % 3u)
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
					num = ((int)num2 * -406221275) ^ -1633285015;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -2031962333;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA5BECD2u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -800074609) ^ 0x29392E7B;
					continue;
				case 1u:
					m_List.Add(aItem);
					num = (int)(num2 * 1351377916) ^ -276428607;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 1591499778;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x66FE8731u) % 10u)
				{
				case 8u:
					result = null;
					num = ((int)num2 * -30298749) ^ 0x1498CC92;
					continue;
				case 6u:
					m_List.RemoveAt(aIndex);
					num = (int)(num2 * 1970911689) ^ -383171899;
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 576169039) ^ -1393591021;
						continue;
					}
					num5 = 1;
					goto IL_004c;
				case 4u:
					result = jSONNode;
					num = (int)(num2 * 1706369399) ^ -858443279;
					continue;
				case 3u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_004c;
				case 2u:
					num = (int)((num2 * 1089885783) ^ 0x307DB962);
					continue;
				case 1u:
					jSONNode = m_List[aIndex];
					num = 1101464997;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1369751801;
						num4 = 1369751801;
					}
					else
					{
						num3 = 1246368928;
						num4 = 1246368928;
					}
					num = num3 ^ ((int)num2 * -1001822395);
					continue;
				}
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_004c:
					flag = (byte)num5 != 0;
					num = 1337929481;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 873568299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5490205Eu) % 3u)
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
				num = ((int)num2 * -54978384) ^ -1735304037;
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
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = -1021079900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD293D0ADu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0137:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1826988045;
								num4 = -1826988045;
							}
							else
							{
								num3 = -1020290467;
								num4 = -1020290467;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD293D0ADu) % 9u)
								{
								case 8u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1594390881) ^ -1630688472;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = -1671859740;
									continue;
								case 5u:
									num3 = (int)((num2 * 1508371246) ^ 0x787ED0F0);
									continue;
								case 4u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -599236160) ^ 0x664AF7FC;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1105487623;
										num6 = -1105487623;
									}
									else
									{
										num5 = -1025083200;
										num6 = -1025083200;
									}
									num3 = num5 ^ (int)(num2 * 1934885714);
									continue;
								}
								case 1u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -341089290;
									continue;
								case 0u:
									num3 = -1020290467;
									continue;
								default:
									goto end_IL_00f1;
								case 3u:
									break;
								case 7u:
									goto end_IL_00f1;
								}
								goto IL_0137;
								continue;
								end_IL_00f1:
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
							IL_0182:
							int num7 = -1340763285;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xD293D0ADu) % 3u)
								{
								case 2u:
									goto IL_0156;
								default:
									goto end_IL_0164;
								case 0u:
									break;
								case 1u:
									goto end_IL_0164;
								}
								goto IL_0182;
								IL_0156:
								num7 = ((int)num2 * -1183508688) ^ 0x5BD1522;
								continue;
								end_IL_0164:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num8 = -1254622499;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xD293D0ADu) % 3u)
							{
							case 1u:
								goto IL_019b;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019b:
							num8 = ((int)num2 * -927476721) ^ 0x1EA75481;
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1381894549) ^ -891227065;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = -907946377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3830AA3u) % 3u)
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
							IL_0185:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -65047833;
								num4 = -65047833;
							}
							else
							{
								num3 = -1767478215;
								num4 = -1767478215;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD3830AA3u) % 11u)
								{
								case 10u:
									current = enumerator.Current;
									num3 = -1550418788;
									continue;
								case 9u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -941619828) ^ 0x105B5245;
									continue;
								case 8u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 820344994;
										num6 = 820344994;
									}
									else
									{
										num5 = 1317679489;
										num6 = 1317679489;
									}
									num3 = num5 ^ (int)(num2 * 1784005500);
									continue;
								}
								case 6u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = ((int)num2 * -1752957505) ^ -1758675111;
									continue;
								case 4u:
									num3 = ((int)num2 * -520552195) ^ 0x262E500;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 1736757079) ^ -591505197;
									continue;
								case 2u:
									num3 = -65047833;
									continue;
								case 1u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -492596713;
									continue;
								case 0u:
									num3 = (int)((num2 * 59807294) ^ 0x312A275);
									continue;
								default:
									goto end_IL_0137;
								case 7u:
									break;
								case 5u:
									goto end_IL_0137;
								}
								goto IL_0185;
								continue;
								end_IL_0137:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					string result = string_;
					while (true)
					{
						int num7 = -1795409441;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xD3830AA3u) % 3u)
							{
							case 1u:
								goto IL_01ba;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01ba:
							num7 = (int)((num2 * 1818581827) ^ 0x71070FFC);
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)((num2 * 1175037078) ^ 0xAD5EACC);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -299339753;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFD559FAu) % 12u)
				{
				case 11u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -2070069651) ^ 0x1783AC40;
					continue;
				case 10u:
					num = -2093801902;
					continue;
				case 9u:
					num = (int)(num2 * 1098815347) ^ -1393883450;
					continue;
				case 8u:
					m_List[num5].Serialize(aWriter);
					num = ((int)num2 * -783218338) ^ -1022327202;
					continue;
				case 7u:
					num5++;
					num = ((int)num2 * -141584836) ^ 0x56101785;
					continue;
				case 4u:
					num5 = 0;
					num = ((int)num2 * -251815254) ^ 0x7E9DE6E9;
					continue;
				case 3u:
					flag = num5 < m_List.Count;
					num = -524552448;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1388374712;
						num4 = -1388374712;
					}
					else
					{
						num3 = -1725939652;
						num4 = -1725939652;
					}
					num = num3 ^ ((int)num2 * -883901354);
					continue;
				}
				case 1u:
					num = ((int)num2 * -2070217385) ^ 0x6595643D;
					continue;
				case 0u:
					num = (int)(num2 * 1612750057) ^ -1966585215;
					continue;
				default:
					return;
				case 5u:
					break;
				case 6u:
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
