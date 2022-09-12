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
				goto IL_0019;
			}
			int num = 1;
			goto IL_00aa;
			IL_00aa:
			bool flag = (byte)num != 0;
			int num2 = -1543048402;
			goto IL_006c;
			IL_0019:
			num2 = -1103639750;
			goto IL_006c;
			IL_006c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xA9FB7976u) % 7u)
				{
				case 6u:
					num2 = (int)((num3 * 1646925019) ^ 0x7B0BDF63);
					continue;
				case 5u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 466436178;
						num5 = 466436178;
					}
					else
					{
						num4 = 1952859972;
						num5 = 1952859972;
					}
					num2 = num4 ^ (int)(num3 * 92591095);
					continue;
				}
				case 3u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -1847917594) ^ 0x27DB9D27;
					continue;
				case 2u:
					result = m_List[aIndex];
					num2 = -826256132;
					continue;
				case 1u:
					goto IL_0099;
				default:
					return result;
				}
				break;
			}
			goto IL_0019;
			IL_0099:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00aa;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_008d;
			}
			int num = 1;
			goto IL_00d9;
			IL_00d9:
			bool flag = (byte)num != 0;
			int num2 = -208126676;
			goto IL_0092;
			IL_008d:
			num2 = -1613787878;
			goto IL_0092;
			IL_0092:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xCCFF5884u) % 9u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 155186299;
						num5 = 155186299;
					}
					else
					{
						num4 = 422654739;
						num5 = 422654739;
					}
					num2 = num4 ^ (int)(num3 * 1961858678);
					continue;
				}
				case 5u:
					m_List.Add(value);
					num2 = (int)(num3 * 1627081566) ^ -98280348;
					continue;
				case 4u:
					num2 = (int)((num3 * 521461543) ^ 0x7BE0DBC7);
					continue;
				case 3u:
					num2 = ((int)num3 * -1689152579) ^ 0x37D68173;
					continue;
				case 2u:
					num2 = ((int)num3 * -1939078290) ^ -3640598;
					continue;
				case 1u:
					m_List[aIndex] = value;
					num2 = -2089093802;
					continue;
				case 0u:
					break;
				default:
					return;
				case 7u:
					goto IL_00c8;
				case 8u:
					return;
				}
				break;
			}
			goto IL_008d;
			IL_00c8:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00d9;
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
				int num = -251444864;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD14E255u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1593943893) ^ 0x792A1242);
						continue;
					case 1u:
						m_List.Add(value);
						num = ((int)num2 * -2130851121) ^ 0x2E41EDF9;
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
				int num = 466998566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x59601A7Bu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -177664873) ^ -1416553728;
						continue;
					case 1u:
						count = m_List.Count;
						num = (int)((num2 * 2141461594) ^ 0x77C7E62);
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
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -256740344;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9466299u) % 3u)
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
					num = ((int)num2 * -949078820) ^ 0x5AE89A5;
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
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1617636866;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x425839CCu) % 10u)
				{
				case 9u:
					num = (int)(num2 * 582376016) ^ -718855927;
					continue;
				case 7u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0029;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1853164375;
						num5 = -1853164375;
					}
					else
					{
						num4 = -1836162846;
						num5 = -1836162846;
					}
					num = num4 ^ ((int)num2 * -630906449);
					continue;
				}
				case 5u:
					result = null;
					num = (int)((num2 * 193121652) ^ 0x255DBAE5);
					continue;
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1548884163) ^ -684459155;
						continue;
					}
					num3 = 1;
					goto IL_0029;
				case 3u:
					result = jSONNode;
					num = ((int)num2 * -1876193944) ^ -268682772;
					continue;
				case 2u:
					num = (int)((num2 * 772172169) ^ 0x1C8BF051);
					continue;
				case 0u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = 389033973;
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_0029:
					flag = (byte)num3 != 0;
					num = 1274494344;
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
			int num = 202238345;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x305CDE0Du) % 3u)
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
				num = (int)(num2 * 171673267) ^ -1277308979;
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
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
		{
			JSONNode current = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				IL_00ec:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 157514820;
					num2 = 157514820;
				}
				else
				{
					num = 142966376;
					num2 = 142966376;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x8C2FD2Eu) % 8u)
					{
					case 7u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 1107342032) ^ -1265205218;
						continue;
					case 4u:
						num = (int)(num3 * 1073768057) ^ -1351300705;
						continue;
					case 3u:
						num = 157514820;
						continue;
					case 2u:
						current = enumerator.Current;
						flag = JSONArray.smethod_30(string_) > 2;
						num = 1197289687;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -2017940755;
							num5 = -2017940755;
						}
						else
						{
							num4 = -7493174;
							num5 = -7493174;
						}
						num = num4 ^ ((int)num3 * -1715287932);
						continue;
					}
					case 0u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = 394484226;
						continue;
					default:
						goto end_IL_00ab;
					case 5u:
						break;
					case 6u:
						goto end_IL_00ab;
					}
					goto IL_00ec;
					continue;
					end_IL_00ab:
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
				IL_0137:
				int num6 = 330367937;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x8C2FD2Eu) % 3u)
					{
					case 2u:
						goto IL_010b;
					default:
						goto end_IL_0119;
					case 0u:
						break;
					case 1u:
						goto end_IL_0119;
					}
					goto IL_0137;
					IL_010b:
					num6 = (int)((num3 * 88546696) ^ 0x762ECFDC);
					continue;
					end_IL_0119:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = default(string);
		while (true)
		{
			int num7 = 94265593;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x8C2FD2Eu) % 4u)
				{
				case 3u:
					result = string_;
					num7 = ((int)num3 * -2131842286) ^ 0x19911C;
					continue;
				case 0u:
					num7 = ((int)num3 * -651089326) ^ 0x5319F02B;
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

	public override string ToString(string aPrefix)
	{
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = -382816095;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0E29FEFu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -449511853) ^ -1394359925;
					continue;
				case 2u:
					string_ = "[ ";
					num = (int)((num2 * 1441710232) ^ 0x71890CDC);
					continue;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0151:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1353244359;
								num4 = -1353244359;
							}
							else
							{
								num3 = -1575809101;
								num4 = -1575809101;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA0E29FEFu) % 8u)
								{
								case 7u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -936958918;
										num6 = -936958918;
									}
									else
									{
										num5 = -2031662464;
										num6 = -2031662464;
									}
									num3 = num5 ^ (int)(num2 * 1508389530);
									continue;
								}
								case 4u:
									current = enumerator.Current;
									num3 = -1392367067;
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -856894702;
									continue;
								case 2u:
									num3 = ((int)num2 * -1028907997) ^ 0xF630466;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 34354150) ^ -1737010982;
									continue;
								case 0u:
									num3 = -1575809101;
									continue;
								default:
									goto end_IL_0110;
								case 5u:
									break;
								case 6u:
									goto end_IL_0110;
								}
								goto IL_0151;
								continue;
								end_IL_0110:
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
							IL_019c:
							int num7 = -2076444226;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xA0E29FEFu) % 3u)
								{
								case 1u:
									goto IL_0170;
								default:
									goto end_IL_017e;
								case 2u:
									break;
								case 0u:
									goto end_IL_017e;
								}
								goto IL_019c;
								IL_0170:
								num7 = ((int)num2 * -1376656117) ^ -1579812997;
								continue;
								end_IL_017e:
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
		int num3 = default(int);
		while (true)
		{
			int num = 226312000;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FEC5A6Du) % 10u)
				{
				case 9u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = 561846037;
						num4 = 561846037;
					}
					else
					{
						num = 696731672;
						num4 = 696731672;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -618257738) ^ -1717726365;
					continue;
				case 5u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1897573578) ^ -261902326;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -177872838) ^ 0x3D8F21CA;
					continue;
				case 3u:
					m_List[num3].Serialize(aWriter);
					num = 1373873807;
					continue;
				case 2u:
					num = ((int)num2 * -208967415) ^ 0x561669EA;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1399386891) ^ 0x77953194;
					continue;
				case 0u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 157859579) ^ 0x18E15E4C);
					continue;
				default:
					return;
				case 8u:
					break;
				case 6u:
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
			int num = -1939355848;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBEF6AAAu) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0013:
				num = (int)(num2 * 73562952) ^ -21176158;
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
