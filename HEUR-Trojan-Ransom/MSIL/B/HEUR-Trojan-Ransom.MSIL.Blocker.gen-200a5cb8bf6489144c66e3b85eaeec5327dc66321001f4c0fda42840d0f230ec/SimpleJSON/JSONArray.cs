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
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0050;
			IL_0050:
			int num = -1003598624;
			goto IL_0055;
			IL_0055:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE948F210u) % 6u)
				{
				case 3u:
					result = new JSONLazyCreator(this);
					num = (int)((num2 * 130045355) ^ 0x102F2F20);
					continue;
				case 2u:
					num = ((int)num2 * -689914169) ^ 0x25217141;
					continue;
				case 1u:
					result = m_List[aIndex];
					num = -1804836886;
					continue;
				case 0u:
					break;
				case 4u:
					goto IL_007e;
				default:
					return result;
				}
				break;
				IL_007e:
				if (aIndex < m_List.Count)
				{
					num = -94510099;
					num3 = -94510099;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0050;
			IL_000a:
			num = -1022831947;
			num3 = -1022831947;
			goto IL_0055;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1787083304;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x43EB0331u) % 7u)
					{
					case 6u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -505759381) ^ -1501206509;
							continue;
						}
						num5 = 1;
						goto IL_001a;
					case 5u:
						num5 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_001a;
					case 3u:
						m_List[aIndex] = value;
						num = 723650934;
						continue;
					case 2u:
						m_List.Add(value);
						num = ((int)num2 * -97948746) ^ 0xF3A5666;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1380368198;
							num4 = -1380368198;
						}
						else
						{
							num3 = -386427605;
							num4 = -386427605;
						}
						num = num3 ^ (int)(num2 * 1385541815);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 1u:
						return;
						IL_001a:
						flag = (byte)num5 != 0;
						num = 1553699380;
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
				int num = 1894015619;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x212D7ECCu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -69769969) ^ 0x5523A7FD;
				}
			}
		}
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = 161023442;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x507A0397u) % 3u)
					{
					case 1u:
						goto IL_000e;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000e:
					num = (int)(num2 * 178848254) ^ -1862314485;
				}
			}
		}
	}

	public override int Count => m_List.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 349063745;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x61838C3u) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1050118110) ^ -446853220;
						continue;
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 1549259940) ^ 0x3F428738);
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
		m_List.Add(aItem);
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_003d;
		}
		int num = 1;
		goto IL_00da;
		IL_00c9:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00da;
		IL_003d:
		int num2 = 1545874418;
		goto IL_0093;
		IL_0093:
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x32709335u) % 9u)
			{
			case 8u:
				num2 = ((int)num3 * -948675659) ^ 0x4EEB1678;
				continue;
			case 7u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 984299009;
					num5 = 984299009;
				}
				else
				{
					num4 = 1330216522;
					num5 = 1330216522;
				}
				num2 = num4 ^ (int)(num3 * 1955272973);
				continue;
			}
			case 6u:
				break;
			case 5u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = 2044128026;
				continue;
			case 3u:
				result = null;
				num2 = (int)((num3 * 694208559) ^ 0x2765E65F);
				continue;
			case 2u:
				num2 = ((int)num3 * -1511929902) ^ -369513622;
				continue;
			case 0u:
				result = jSONNode;
				num2 = ((int)num3 * -826456336) ^ -2101852120;
				continue;
			case 4u:
				goto IL_00c9;
			default:
				return result;
			}
			break;
		}
		goto IL_003d;
		IL_00da:
		flag = (byte)num != 0;
		num2 = 469688992;
		goto IL_0093;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 450218218;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CA44AD9u) % 4u)
				{
				case 3u:
					m_List.Remove(aNode);
					num = (int)(num2 * 1077210916) ^ -1530698447;
					continue;
				case 0u:
					result = aNode;
					num = (int)((num2 * 937205324) ^ 0x45B99258);
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
				if (!enumerator.MoveNext())
				{
					num = -830058508;
					num2 = -830058508;
				}
				else
				{
					num = -873157482;
					num2 = -873157482;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE630B23Au) % 8u)
					{
					case 7u:
						num = ((int)num3 * -1226960319) ^ -1676751179;
						continue;
					case 5u:
						num = -873157482;
						continue;
					case 4u:
						current = enumerator.Current;
						flag = JSONArray.smethod_30(string_) > 2;
						num = -1827388959;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -913694760;
							num5 = -913694760;
						}
						else
						{
							num4 = -1189065581;
							num5 = -1189065581;
						}
						num = num4 ^ ((int)num3 * -112310207);
						continue;
					}
					case 2u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 1736172788) ^ -1581810965;
						continue;
					case 1u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = -1160650875;
						continue;
					default:
						goto end_IL_00ab;
					case 0u:
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
				int num6 = -1270651283;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xE630B23Au) % 3u)
					{
					case 1u:
						goto IL_010b;
					default:
						goto end_IL_0119;
					case 0u:
						break;
					case 2u:
						goto end_IL_0119;
					}
					goto IL_0137;
					IL_010b:
					num6 = ((int)num3 * -702574607) ^ 0xEFE1D8;
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
			int num7 = -796261627;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xE630B23Au) % 4u)
				{
				case 3u:
					result = string_;
					num7 = ((int)num3 * -620555815) ^ 0x563B661B;
					continue;
				case 2u:
					num7 = (int)(num3 * 1190498443) ^ -1470950179;
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

	public override string ToString(string aPrefix)
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1497700928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7735CB06u) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = ((int)num2 * -1898067428) ^ -376076473;
					continue;
				case 1u:
					num = (int)((num2 * 1176487114) ^ 0x2AB1954F);
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
								num3 = 2091909816;
								num4 = 2091909816;
							}
							else
							{
								num3 = 1571411615;
								num4 = 1571411615;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x7735CB06u) % 8u)
								{
								case 6u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = 1750832294;
									continue;
								case 5u:
									num3 = (int)(num2 * 472688503) ^ -1549249542;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1218741101) ^ 0x5C004D09;
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = 1271716331;
									continue;
								case 2u:
									num3 = 2091909816;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 47315373;
										num6 = 47315373;
									}
									else
									{
										num5 = 311265738;
										num6 = 311265738;
									}
									num3 = num5 ^ ((int)num2 * -1515937239);
									continue;
								}
								default:
									goto end_IL_0115;
								case 7u:
									break;
								case 1u:
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
					while (true)
					{
						int num7 = 10294957;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x7735CB06u) % 4u)
							{
							case 3u:
								result = string_;
								num7 = (int)((num2 * 1447954607) ^ 0xA4180C2);
								continue;
							case 1u:
								num7 = ((int)num2 * -950582620) ^ -1803531960;
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
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -1164149651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x869D0E6Fu) % 12u)
				{
				case 11u:
					num = (int)((num2 * 281699689) ^ 0x34B8F02D);
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -879540290;
						num5 = -879540290;
					}
					else
					{
						num4 = -1371545620;
						num5 = -1371545620;
					}
					num = num4 ^ ((int)num2 * -455114719);
					continue;
				}
				case 8u:
					num = (int)(num2 * 1970085006) ^ -99445818;
					continue;
				case 7u:
					m_List[num3].Serialize(aWriter);
					num = -509277732;
					continue;
				case 6u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)(num2 * 1285162406) ^ -944824516;
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -171876277) ^ -952483004;
					continue;
				case 3u:
					num = (int)(num2 * 832355323) ^ -99545454;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -927750787) ^ -36161039;
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 2004921233) ^ 0x6AC6EB1C);
					continue;
				case 0u:
					flag = num3 < m_List.Count;
					num = -852564635;
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
