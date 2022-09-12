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
				int num = 1877059947;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2009EC14u) % 8u)
					{
					case 7u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 435384950) ^ -224637496;
							continue;
						}
						goto IL_001c;
					case 6u:
						if (aIndex < m_List.Count)
						{
							num = 773870345;
							num3 = 773870345;
							continue;
						}
						goto IL_001c;
					case 5u:
						result = m_List[aIndex];
						num = 1680426422;
						continue;
					case 2u:
						num = ((int)num2 * -837266028) ^ 0x55A48927;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1187967185) ^ -1698035157;
						continue;
					case 0u:
						num = ((int)num2 * -212885403) ^ -1566797569;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_001c:
						num = 1759441333;
						num3 = 1759441333;
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
				goto IL_0055;
			}
			goto IL_0096;
			IL_0055:
			int num = 411150182;
			goto IL_005a;
			IL_005a:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E93613u) % 6u)
				{
				case 4u:
					m_List[aIndex] = value;
					num = 193339863;
					continue;
				case 3u:
					m_List.Add(value);
					num = (int)((num2 * 1130305496) ^ 0x232FDB0C);
					continue;
				case 2u:
					num = ((int)num2 * -1725401371) ^ -1688332496;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_0083;
				case 1u:
					return;
				}
				break;
				IL_0083:
				if (aIndex < m_List.Count)
				{
					num = 936969187;
					num3 = 936969187;
					continue;
				}
				goto IL_0096;
			}
			goto IL_0055;
			IL_0096:
			num = 1328138436;
			num3 = 1328138436;
			goto IL_005a;
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
				int num = -440354519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8529EF2u) % 4u)
					{
					case 3u:
						m_List.Add(value);
						num = (int)((num2 * 2124358708) ^ 0x593ED773);
						continue;
					case 1u:
						num = (int)((num2 * 328399509) ^ 0x3311522D);
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
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
				int num = -744151958;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3E4A088u) % 4u)
					{
					case 2u:
						count = m_List.Count;
						num = (int)(num2 * 1597329033) ^ -1330077825;
						continue;
					case 1u:
						num = (int)((num2 * 1892310472) ^ 0x3117F460);
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
		while (true)
		{
			int num = 1357334111;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA01FBB0u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1533663717) ^ 0xF6CBB20;
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
			int num = 2075669712;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x790AE724u) % 9u)
				{
				case 8u:
					result = null;
					num = (int)(num2 * 1547420545) ^ -1468935868;
					continue;
				case 6u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_002b;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 224845994) ^ 0x4C90F252);
						continue;
					}
					num5 = 1;
					goto IL_002b;
				case 4u:
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = ((int)num2 * -424586211) ^ -1727568687;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -890707466;
						num4 = -890707466;
					}
					else
					{
						num3 = -1400757422;
						num4 = -1400757422;
					}
					num = num3 ^ ((int)num2 * -1596430119);
					continue;
				}
				case 1u:
					jSONNode = m_List[aIndex];
					num = 138876442;
					continue;
				case 0u:
					num = ((int)num2 * -990097448) ^ 0x5F04B585;
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_002b:
					flag = (byte)num5 != 0;
					num = 1043366583;
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
			int num = -835160529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3B30800u) % 4u)
				{
				case 3u:
					result = aNode;
					num = (int)(num2 * 2107962872) ^ -1869909723;
					continue;
				case 1u:
					num = ((int)num2 * -129366820) ^ 0x58E42CC6;
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
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
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
			int num = 1907097580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F8E4333u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0109:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1624072173;
								num4 = 1624072173;
							}
							else
							{
								num3 = 1564166172;
								num4 = 1564166172;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3F8E4333u) % 7u)
								{
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1303232447;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 668120671;
									continue;
								case 4u:
									num3 = 1564166172;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) > 2)
									{
										num5 = 1356387110;
										num6 = 1356387110;
									}
									else
									{
										num5 = 1142343913;
										num6 = 1142343913;
									}
									num3 = num5 ^ ((int)num2 * -491839996);
									continue;
								}
								case 0u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -253147821) ^ 0x2E473026;
									continue;
								default:
									goto end_IL_00cc;
								case 2u:
									break;
								case 3u:
									goto end_IL_00cc;
								}
								goto IL_0109;
								continue;
								end_IL_00cc:
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
							IL_0154:
							int num7 = 439065916;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x3F8E4333u) % 3u)
								{
								case 1u:
									goto IL_0128;
								default:
									goto end_IL_0136;
								case 2u:
									break;
								case 0u:
									goto end_IL_0136;
								}
								goto IL_0154;
								IL_0128:
								num7 = (int)((num2 * 1608950083) ^ 0x410A09A6);
								continue;
								end_IL_0136:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = 272133568;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x3F8E4333u) % 4u)
							{
							case 3u:
								result = string_;
								num8 = ((int)num2 * -655865303) ^ -773691572;
								continue;
							case 0u:
								num8 = (int)((num2 * 376645020) ^ 0x50B4FC22);
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
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)((num2 * 2009027519) ^ 0xADA9BD1);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		JSONNode current = default(JSONNode);
		string result = default(string);
		while (true)
		{
			int num = 1420024093;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77B1F574u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_012b:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1314074560;
								num4 = 1314074560;
							}
							else
							{
								num3 = 694745002;
								num4 = 694745002;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x77B1F574u) % 7u)
								{
								case 6u:
									num3 = 694745002;
									continue;
								case 5u:
									num3 = ((int)num2 * -1495019183) ^ -1334297718;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 2107813403) ^ 0x708FB25);
									continue;
								case 2u:
								{
									current = enumerator.Current;
									int num5;
									if (JSONArray.smethod_30(string_) > 3)
									{
										num3 = 730836742;
										num5 = 730836742;
									}
									else
									{
										num3 = 87686435;
										num5 = 87686435;
									}
									continue;
								}
								case 1u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = 1708897236;
									continue;
								default:
									goto end_IL_00ee;
								case 3u:
									break;
								case 0u:
									goto end_IL_00ee;
								}
								goto IL_012b;
								continue;
								end_IL_00ee:
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
							IL_0176:
							int num6 = 1780975757;
							while (true)
							{
								switch ((num2 = (uint)num6 ^ 0x77B1F574u) % 3u)
								{
								case 1u:
									goto IL_014a;
								default:
									goto end_IL_0158;
								case 2u:
									break;
								case 0u:
									goto end_IL_0158;
								}
								goto IL_0176;
								IL_014a:
								num6 = (int)((num2 * 1459356607) ^ 0x349D03D7);
								continue;
								end_IL_0158:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 1188250098;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x77B1F574u) % 3u)
							{
							case 2u:
								goto IL_0192;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0192:
							result = string_;
							num7 = (int)((num2 * 1421094653) ^ 0x46723191);
						}
					}
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -944218612) ^ -1572526669;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num = -1244285499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCB58A8Du) % 12u)
				{
				case 11u:
					num = ((int)num2 * -1487016274) ^ 0x2F1E0921;
					continue;
				case 9u:
					flag = num3 < m_List.Count;
					num = -1624617717;
					continue;
				case 8u:
					num = -167477044;
					continue;
				case 7u:
					num = (int)((num2 * 231405412) ^ 0x1C10021E);
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1463594047;
						num5 = 1463594047;
					}
					else
					{
						num4 = 2131277361;
						num5 = 2131277361;
					}
					num = num4 ^ (int)(num2 * 1220191187);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1526068210) ^ -346326076;
					continue;
				case 4u:
					JSONArray.smethod_34(aWriter, (byte)1);
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 872402936) ^ -1886384798;
					continue;
				case 3u:
					num3 = 0;
					num = (int)((num2 * 1069941322) ^ 0x4ECC6BC2);
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -6814892) ^ 0x445AE10C;
					continue;
				case 1u:
					m_List[num3].Serialize(aWriter);
					num = (int)(num2 * 353213047) ^ -1840725269;
					continue;
				default:
					return;
				case 0u:
					break;
				case 10u:
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
