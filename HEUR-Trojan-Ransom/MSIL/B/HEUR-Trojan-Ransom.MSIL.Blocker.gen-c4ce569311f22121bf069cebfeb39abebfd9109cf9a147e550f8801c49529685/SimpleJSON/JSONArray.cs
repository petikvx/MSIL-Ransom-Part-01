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
				int num = 614480834;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x43C8953Bu) % 8u)
					{
					case 7u:
						result = m_List[aIndex];
						num = 125106657;
						continue;
					case 5u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_002b;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -679912307;
							num5 = -679912307;
						}
						else
						{
							num4 = -241901438;
							num5 = -241901438;
						}
						num = num4 ^ (int)(num2 * 632047811);
						continue;
					}
					case 2u:
						num = ((int)num2 * -172054852) ^ 0x5BF91C7F;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1889522663) ^ -23913793;
							continue;
						}
						num3 = 1;
						goto IL_002b;
					case 0u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -83971119) ^ 0x5D1D2BD7;
						continue;
					case 6u:
						break;
					default:
						{
							return result;
						}
						IL_002b:
						flag = (byte)num3 != 0;
						num = 735371128;
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
				goto IL_000a;
			}
			int num = 1;
			goto IL_00c2;
			IL_00b1:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00c2;
			IL_000a:
			int num2 = -1462251725;
			goto IL_0080;
			IL_0080:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x911C0046u) % 8u)
				{
				case 7u:
					break;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -930026196;
						num5 = -930026196;
					}
					else
					{
						num4 = -211476922;
						num5 = -211476922;
					}
					num2 = num4 ^ ((int)num3 * -438896076);
					continue;
				}
				case 4u:
					num2 = (int)((num3 * 276520739) ^ 0x3BCF3FB1);
					continue;
				case 2u:
					m_List[aIndex] = value;
					num2 = -601401987;
					continue;
				case 1u:
					num2 = (int)(num3 * 808126741) ^ -1917646993;
					continue;
				case 0u:
					m_List.Add(value);
					num2 = (int)(num3 * 207730256) ^ -1213145921;
					continue;
				default:
					return;
				case 5u:
					goto IL_00b1;
				case 3u:
					return;
				}
				break;
			}
			goto IL_000a;
			IL_00c2:
			flag = (byte)num != 0;
			num2 = -1335122880;
			goto IL_0080;
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
			m_List.Add(value);
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
				int num = -1499137429;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCB801FEAu) % 4u)
					{
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 304673561) ^ 0x19F001BB);
						continue;
					case 0u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1715927955) ^ 0x7EB1CC80;
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
			int num = 2004442725;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x212B2CF4u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				m_List.Add(aItem);
				num = ((int)num2 * -1104133251) ^ -1098400703;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -2105590844;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA873B9CDu) % 11u)
				{
				case 10u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0017;
				case 9u:
					num = ((int)num2 * -1073000) ^ -1227066921;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1708378888;
						num5 = 1708378888;
					}
					else
					{
						num4 = 139810648;
						num5 = 139810648;
					}
					num = num4 ^ ((int)num2 * -1072706369);
					continue;
				}
				case 7u:
					num = ((int)num2 * -2016550046) ^ -2053244083;
					continue;
				case 6u:
					result = null;
					num = (int)(num2 * 579060239) ^ -1377927763;
					continue;
				case 3u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = -861754492;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1662238822) ^ 0x6141CC9B;
						continue;
					}
					num3 = 1;
					goto IL_0017;
				case 1u:
					result = jSONNode;
					num = ((int)num2 * -990407532) ^ 0x4A576184;
					continue;
				case 0u:
					num = (int)((num2 * 1002585266) ^ 0x579EFB38);
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num3 != 0;
					num = -1595602309;
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
			int num = 1933479213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47346911u) % 3u)
				{
				case 2u:
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
				num = ((int)num2 * -988305238) ^ 0x28BB4293;
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
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -2071707101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBE95592u) % 3u)
				{
				case 1u:
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
							IL_0122:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1767724765;
								num4 = -1767724765;
							}
							else
							{
								num3 = -569026714;
								num4 = -569026714;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFBE95592u) % 8u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 849076520) ^ -1377051076;
									continue;
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1775690407;
									continue;
								case 5u:
									num3 = -1767724765;
									continue;
								case 2u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -949548672) ^ 0x2239D12;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -747370048;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 215013476;
										num6 = 215013476;
									}
									else
									{
										num5 = 1911982477;
										num6 = 1911982477;
									}
									num3 = num5 ^ (int)(num2 * 150696437);
									continue;
								}
								default:
									goto end_IL_00e1;
								case 3u:
									break;
								case 4u:
									goto end_IL_00e1;
								}
								goto IL_0122;
								continue;
								end_IL_00e1:
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
							IL_016d:
							int num7 = -1823611746;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xFBE95592u) % 3u)
								{
								case 1u:
									goto IL_0141;
								default:
									goto end_IL_014f;
								case 2u:
									break;
								case 0u:
									goto end_IL_014f;
								}
								goto IL_016d;
								IL_0141:
								num7 = (int)(num2 * 842892111) ^ -1016668708;
								continue;
								end_IL_014f:
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
				num = (int)((num2 * 2053547639) ^ 0x5F3E8059);
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
			int num = 1880936417;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11037482u) % 4u)
				{
				case 3u:
					string_ = "[ ";
					num = (int)(num2 * 1993409221) ^ -1304047385;
					continue;
				case 2u:
					num = ((int)num2 * -820584846) ^ -918529129;
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0154:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1305937046;
								num4 = 1305937046;
							}
							else
							{
								num3 = 2098973128;
								num4 = 2098973128;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x11037482u) % 8u)
								{
								case 7u:
									num3 = 1305937046;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = -1122768671;
										num6 = -1122768671;
									}
									else
									{
										num5 = -493029531;
										num6 = -493029531;
									}
									num3 = num5 ^ (int)(num2 * 1876642075);
									continue;
								}
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1833087800) ^ -1658411301;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = 2065299860;
									continue;
								case 1u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = 2053138730;
									continue;
								case 0u:
									num3 = ((int)num2 * -1405280574) ^ -1023766143;
									continue;
								default:
									goto end_IL_0113;
								case 3u:
									break;
								case 2u:
									goto end_IL_0113;
								}
								goto IL_0154;
								continue;
								end_IL_0113:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 1967513560;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x11037482u) % 4u)
							{
							case 2u:
								result = string_;
								num7 = ((int)num2 * -280516827) ^ 0xC6E357D;
								continue;
							case 1u:
								num7 = ((int)num2 * -1350662921) ^ -1076915583;
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
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		while (true)
		{
			int num = 47206210;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2FC25925u) % 8u)
				{
				case 7u:
					num = (int)(num2 * 1410307350) ^ -2110490282;
					continue;
				case 6u:
					num3++;
					num = (int)((num2 * 1308276565) ^ 0x1442A80B);
					continue;
				case 4u:
					m_List[num3].Serialize(aWriter);
					num = 43666899;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -1463872846) ^ -697954367;
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 324855616) ^ -1963831833;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < m_List.Count)
					{
						num = 2063723529;
						num4 = 2063723529;
					}
					else
					{
						num = 1764032990;
						num4 = 1764032990;
					}
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 3u:
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
			int num = -572652158;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CF0E602u) % 3u)
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
				num = (int)((num2 * 1613393338) ^ 0x10A0EA51);
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
