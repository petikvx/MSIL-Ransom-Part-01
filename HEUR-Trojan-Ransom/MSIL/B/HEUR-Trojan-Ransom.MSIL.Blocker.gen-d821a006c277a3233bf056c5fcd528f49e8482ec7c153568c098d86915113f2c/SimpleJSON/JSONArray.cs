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
				goto IL_001e;
			}
			int num = 1;
			goto IL_00aa;
			IL_00aa:
			bool flag = (byte)num != 0;
			int num2 = 606457572;
			goto IL_006c;
			IL_001e:
			num2 = 1982750640;
			goto IL_006c;
			IL_006c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x1D900127u) % 7u)
				{
				case 5u:
					result = m_List[aIndex];
					num2 = 918075786;
					continue;
				case 4u:
					break;
				case 3u:
					num2 = (int)((num3 * 1571147570) ^ 0x11E1C719);
					continue;
				case 2u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -289160455) ^ -19936802;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 268611501;
						num5 = 268611501;
					}
					else
					{
						num4 = 1721503205;
						num5 = 1721503205;
					}
					num2 = num4 ^ (int)(num3 * 1414495189);
					continue;
				}
				case 6u:
					goto IL_0099;
				default:
					return result;
				}
				break;
			}
			goto IL_001e;
			IL_0099:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00aa;
		}
		set
		{
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0017;
			IL_0017:
			int num = -167227150;
			goto IL_0078;
			IL_0078:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3510569u) % 8u)
				{
				case 7u:
					break;
				case 6u:
					m_List[aIndex] = value;
					num = -1199001924;
					continue;
				case 5u:
					num = ((int)num2 * -91378816) ^ 0x1311A9FB;
					continue;
				case 4u:
					num = ((int)num2 * -1308101939) ^ -1528919889;
					continue;
				case 1u:
					num = ((int)num2 * -341724688) ^ -1211712579;
					continue;
				case 0u:
					m_List.Add(value);
					num = ((int)num2 * -383450848) ^ -582715496;
					continue;
				default:
					return;
				case 3u:
					goto IL_00a9;
				case 2u:
					return;
				}
				break;
				IL_00a9:
				if (aIndex < m_List.Count)
				{
					num = -1067702849;
					num3 = -1067702849;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0017;
			IL_000a:
			num = -1736700855;
			num3 = -1736700855;
			goto IL_0078;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = 194476435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39F2CFB3u) % 3u)
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
					num = (int)((num2 * 795551359) ^ 0x29BAD4C0);
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
				int num = 905360507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A18C8B0u) % 4u)
					{
					case 3u:
						count = m_List.Count;
						num = ((int)num2 * -535496181) ^ -1973175295;
						continue;
					case 0u:
						num = ((int)num2 * -691173291) ^ 0x4D8008D5;
						continue;
					case 2u:
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
				int num = 2073597015;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x26BED0C6u) % 4u)
					{
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 930591534) ^ 0x60F1218A);
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1878153532) ^ -804618564;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 1467458928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x433D4666u) % 3u)
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
				m_List.Add(aItem);
				num = (int)(num2 * 1883935201) ^ -2050041129;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 1934494611;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x14C51F62u) % 8u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -4994813) ^ -1534132620;
					continue;
				case 5u:
				{
					JSONNode jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = 909893032;
					continue;
				}
				case 4u:
					num = (int)((num2 * 272807258) ^ 0x6861EF60);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 929903853;
						num5 = 929903853;
					}
					else
					{
						num4 = 530149302;
						num5 = 530149302;
					}
					num = num4 ^ ((int)num2 * -964747738);
					continue;
				}
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 1188311803) ^ -753578271;
						continue;
					}
					num3 = 1;
					goto IL_0083;
				case 0u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0083;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_0083:
					flag = (byte)num3 != 0;
					num = 1571314793;
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
			int num = -598486551;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEA6CE4Bu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -458311693) ^ -1136759621;
					continue;
				case 2u:
					result = aNode;
					num = ((int)num2 * -1705304769) ^ -790390470;
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
		bool flag = default(bool);
		string string_ = default(string);
		while (true)
		{
			int num = 1848511948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66309378u) % 3u)
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
							IL_0137:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 257806130;
								num4 = 257806130;
							}
							else
							{
								num3 = 414884396;
								num4 = 414884396;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x66309378u) % 9u)
								{
								case 8u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 342865621;
									continue;
								case 7u:
									num3 = 257806130;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 1667719069;
									continue;
								case 3u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -795438433) ^ -1230217812;
									continue;
								case 2u:
									num3 = (int)((num2 * 1373650109) ^ 0x3A405358);
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 758909651) ^ 0x799A2811);
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1797602697;
										num6 = -1797602697;
									}
									else
									{
										num5 = -57822406;
										num6 = -57822406;
									}
									num3 = num5 ^ ((int)num2 * -1810222273);
									continue;
								}
								default:
									goto end_IL_00f1;
								case 6u:
									break;
								case 4u:
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
					string_ = JSONArray.smethod_31(string_, " ]");
					string result = string_;
					while (true)
					{
						int num7 = 1876884989;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x66309378u) % 3u)
							{
							case 1u:
								goto IL_0166;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0166:
							num7 = (int)((num2 * 478360855) ^ 0x37E57C7E);
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -1490780181) ^ 0x2AFC6E7F;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = -752631002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0A5E561u) % 3u)
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
							if (!enumerator.MoveNext())
							{
								num3 = -907771467;
								num4 = -907771467;
							}
							else
							{
								num3 = -687104832;
								num4 = -687104832;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC0A5E561u) % 8u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -466207854) ^ 0x23B78814;
									continue;
								case 5u:
									num3 = (int)(num2 * 774124283) ^ -1776032938;
									continue;
								case 3u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -344347321;
									continue;
								case 2u:
									num3 = -687104832;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1988504652;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -1394136230;
										num6 = -1394136230;
									}
									else
									{
										num5 = -1405499650;
										num6 = -1405499650;
									}
									num3 = num5 ^ ((int)num2 * -779512725);
									continue;
								}
								default:
									goto end_IL_00ff;
								case 6u:
									break;
								case 4u:
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
					return JSONArray.smethod_33(string_, "\n", aPrefix, "]");
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -574124953) ^ -854610109;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 2107916521;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x348775FBu) % 12u)
				{
				case 10u:
					num = ((int)num2 * -171277553) ^ -296007537;
					continue;
				case 9u:
					num = ((int)num2 * -1403924638) ^ 0x75B34B8D;
					continue;
				case 8u:
					num = (int)(num2 * 2006050035) ^ -694558495;
					continue;
				case 7u:
					num = 952103118;
					continue;
				case 6u:
					num5++;
					num = ((int)num2 * -1397263338) ^ -592133413;
					continue;
				case 5u:
					m_List[num5].Serialize(aWriter);
					num = ((int)num2 * -335848928) ^ -1056961485;
					continue;
				case 4u:
					flag = num5 < m_List.Count;
					num = 2009115259;
					continue;
				case 2u:
					JSONArray.smethod_34(aWriter, (byte)1);
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -796100038) ^ -667662526;
					continue;
				case 1u:
					num5 = 0;
					num = (int)((num2 * 1553373380) ^ 0x60C108DA);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -868957852;
						num4 = -868957852;
					}
					else
					{
						num3 = -1210097524;
						num4 = -1210097524;
					}
					num = num3 ^ (int)(num2 * 1791769002);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 11u:
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
