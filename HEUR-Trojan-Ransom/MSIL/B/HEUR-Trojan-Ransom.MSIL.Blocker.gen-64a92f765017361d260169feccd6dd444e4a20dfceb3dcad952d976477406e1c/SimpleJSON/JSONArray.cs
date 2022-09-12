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
				goto IL_0020;
			}
			int num = 1;
			goto IL_00bd;
			IL_00bd:
			bool flag = (byte)num != 0;
			int num2 = -985424037;
			goto IL_007b;
			IL_0020:
			num2 = -1067640976;
			goto IL_007b;
			IL_007b:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEE7AC542u) % 8u)
				{
				case 7u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -1717310582) ^ -621832308;
					continue;
				case 5u:
					break;
				case 4u:
					result = m_List[aIndex];
					num2 = -1441898711;
					continue;
				case 3u:
					num2 = ((int)num3 * -688290363) ^ 0x438FF8B;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -368004655;
						num5 = -368004655;
					}
					else
					{
						num4 = -1545320846;
						num5 = -1545320846;
					}
					num2 = num4 ^ ((int)num3 * -1697340577);
					continue;
				}
				case 0u:
					num2 = ((int)num3 * -1594156068) ^ -1855742020;
					continue;
				case 2u:
					goto IL_00ac;
				default:
					return result;
				}
				break;
			}
			goto IL_0020;
			IL_00ac:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00bd;
		}
		set
		{
			while (true)
			{
				int num = 750130920;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x45A5A380u) % 6u)
					{
					case 4u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1862477670) ^ -952173497;
							continue;
						}
						goto IL_001c;
					case 3u:
						if (aIndex < m_List.Count)
						{
							num = 2035689906;
							num3 = 2035689906;
							continue;
						}
						goto IL_001c;
					case 2u:
						m_List[aIndex] = value;
						num = 438863930;
						continue;
					case 1u:
						m_List.Add(value);
						num = (int)(num2 * 1755134266) ^ -1491831904;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
						IL_001c:
						num = 1387087217;
						num3 = 1387087217;
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
				int num = -421413750;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8CF88D28u) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1887371788) ^ -500690771;
						continue;
					case 1u:
						num = ((int)num2 * -537171379) ^ -91315458;
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
			m_List.Add(value);
		}
	}

	public override int Count => m_List.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1086140407;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC7F9C31u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = (int)(num2 * 703242287) ^ -1513267307;
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
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 1989195781;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x68B872F2u) % 8u)
				{
				case 7u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -308992729) ^ 0x4A6FA847;
						continue;
					}
					num5 = 1;
					goto IL_001d;
				case 6u:
					result = null;
					num = ((int)num2 * -2004250831) ^ 0x66A00FED;
					continue;
				case 5u:
				{
					JSONNode jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = 330416248;
					continue;
				}
				case 4u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_001d;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1797547633;
						num4 = 1797547633;
					}
					else
					{
						num3 = 2127792314;
						num4 = 2127792314;
					}
					num = num3 ^ (int)(num2 * 1837197674);
					continue;
				}
				case 1u:
					num = (int)((num2 * 2057107344) ^ 0x1FA8A868);
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001d:
					flag = (byte)num5 != 0;
					num = 2094852689;
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
			int num = 1610344167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C1292D0u) % 4u)
				{
				case 3u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -1334091421) ^ -2014447160;
					continue;
				case 1u:
					num = ((int)num2 * -1173448303) ^ 0x733548AF;
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
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_0102:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -179726242;
					num2 = -179726242;
				}
				else
				{
					num = -1861229765;
					num2 = -1861229765;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x8142C3DAu) % 9u)
					{
					case 7u:
						num = -179726242;
						continue;
					case 6u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -1888895600;
						continue;
					case 5u:
						current = enumerator.Current;
						num = -540761899;
						continue;
					case 4u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -799794142) ^ -5653833;
						continue;
					case 3u:
						num = ((int)num3 * -538718069) ^ -1686363442;
						continue;
					case 2u:
						num = ((int)num3 * -1162797340) ^ 0x48F7CF95;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) <= 2)
						{
							num4 = -389802864;
							num5 = -389802864;
						}
						else
						{
							num4 = -1637915212;
							num5 = -1637915212;
						}
						num = num4 ^ (int)(num3 * 1593896921);
						continue;
					}
					default:
						goto end_IL_00bc;
					case 0u:
						break;
					case 8u:
						goto end_IL_00bc;
					}
					goto IL_0102;
					continue;
					end_IL_00bc:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = string_;
		while (true)
		{
			int num6 = -2111034777;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x8142C3DAu) % 3u)
				{
				case 1u:
					goto IL_0131;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0131:
				num6 = (int)((num3 * 1639781909) ^ 0x242D62A7);
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
			int num = -585790741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB71B335Cu) % 3u)
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
							IL_013d:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -939889090;
								num4 = -939889090;
							}
							else
							{
								num3 = -1745166665;
								num4 = -1745166665;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB71B335Cu) % 8u)
								{
								case 6u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -889275800;
										num6 = -889275800;
									}
									else
									{
										num5 = -1968053843;
										num6 = -1968053843;
									}
									num3 = num5 ^ (int)(num2 * 210082912);
									continue;
								}
								case 5u:
									num3 = -1745166665;
									continue;
								case 4u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = -570677548;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = -1786841254;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -78595684) ^ 0x57BEE4F4;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 1860828351) ^ -2032915085;
									continue;
								default:
									goto end_IL_00fc;
								case 7u:
									break;
								case 2u:
									goto end_IL_00fc;
								}
								goto IL_013d;
								continue;
								end_IL_00fc:
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
							IL_0188:
							int num7 = -790098268;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xB71B335Cu) % 3u)
								{
								case 1u:
									goto IL_015c;
								default:
									goto end_IL_016a;
								case 2u:
									break;
								case 0u:
									goto end_IL_016a;
								}
								goto IL_0188;
								IL_015c:
								num7 = ((int)num2 * -929233105) ^ -342093141;
								continue;
								end_IL_016a:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num8 = -45116615;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xB71B335Cu) % 4u)
							{
							case 2u:
								num8 = (int)(num2 * 1413460371) ^ -271358479;
								continue;
							case 1u:
								result = string_;
								num8 = ((int)num2 * -1265974769) ^ 0x2DD0A9C9;
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
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1523734458) ^ -1898432320;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 142206309;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E1A0AC5u) % 9u)
				{
				case 8u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = 729114850;
						num4 = 729114850;
					}
					else
					{
						num = 1320424669;
						num4 = 1320424669;
					}
					continue;
				}
				case 7u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -122965193) ^ 0x91B0340;
					continue;
				case 6u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num3 = 0;
					num = (int)((num2 * 1433901055) ^ 0x4DD25E75);
					continue;
				case 3u:
					num = 511309119;
					continue;
				case 2u:
					num = ((int)num2 * -1809341952) ^ -795212094;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -280843910) ^ -107841310;
					continue;
				case 0u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -1941818425) ^ 0x53386010;
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
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
