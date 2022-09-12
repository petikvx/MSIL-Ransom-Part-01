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
				int num = -1037775661;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xFE3C06F2u) % 7u)
					{
					case 4u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -32911049) ^ 0x41E73BCD;
							continue;
						}
						goto IL_0028;
					case 3u:
						num = (int)((num2 * 1300717584) ^ 0x136E7E87);
						continue;
					case 2u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -7751764) ^ 0x46281662;
						continue;
					case 1u:
						if (aIndex < m_List.Count)
						{
							num = -1621951479;
							num3 = -1621951479;
							continue;
						}
						goto IL_0028;
					case 0u:
						result = m_List[aIndex];
						num = -207775609;
						continue;
					case 5u:
						break;
					default:
						{
							return result;
						}
						IL_0028:
						num = -1464123706;
						num3 = -1464123706;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0055;
			IL_0055:
			int num = -116042398;
			goto IL_005a;
			IL_005a:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA23C767Cu) % 6u)
				{
				case 5u:
					num = (int)((num2 * 1935303055) ^ 0x6C18357F);
					continue;
				case 3u:
					m_List.Add(value);
					num = ((int)num2 * -786919321) ^ 0x19AADFFD;
					continue;
				case 1u:
					m_List[aIndex] = value;
					num = -1128699899;
					continue;
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0083;
				case 4u:
					return;
				}
				break;
				IL_0083:
				if (aIndex < m_List.Count)
				{
					num = -1798150763;
					num3 = -1798150763;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0055;
			IL_000a:
			num = -1425576865;
			num3 = -1425576865;
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
				int num = -2004310119;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAF00D3E0u) % 3u)
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
					num = ((int)num2 * -1421803373) ^ -250313429;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 2084731462;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x47B2F633u) % 4u)
					{
					case 1u:
						m_List.Add(value);
						num = (int)(num2 * 2009089558) ^ -718214467;
						continue;
					case 0u:
						num = (int)((num2 * 1844940062) ^ 0x323DA3E1);
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
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 407466552;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x229AC872u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_List.Count;
					num = (int)(num2 * 523820177) ^ -1015979196;
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
				int num = -308217867;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCDB4AA66u) % 3u)
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
					num = ((int)num2 * -985831355) ^ -899129702;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 1424279002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x670ACB43u) % 4u)
				{
				case 1u:
					m_List.Add(aItem);
					num = (int)(num2 * 49641275) ^ -2014459152;
					continue;
				case 0u:
					num = ((int)num2 * -1771527265) ^ -664335036;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
		goto IL_00f3;
		IL_00e2:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00f3;
		IL_000a:
		int num2 = 1089884054;
		goto IL_00a8;
		IL_00a8:
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x1636AD6Bu) % 10u)
			{
			case 8u:
				break;
			case 6u:
				num2 = ((int)num3 * -33498038) ^ 0x1496EFD4;
				continue;
			case 5u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = 590426715;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1212191632;
					num5 = -1212191632;
				}
				else
				{
					num4 = -606333606;
					num5 = -606333606;
				}
				num2 = num4 ^ (int)(num3 * 1606177279);
				continue;
			}
			case 3u:
				result = jSONNode;
				num2 = ((int)num3 * -1572049850) ^ -843851871;
				continue;
			case 2u:
				num2 = ((int)num3 * -668053808) ^ -1533008014;
				continue;
			case 1u:
				result = null;
				num2 = (int)(num3 * 1675706064) ^ -1478947375;
				continue;
			case 0u:
				num2 = ((int)num3 * -1325636378) ^ 0x2B789A98;
				continue;
			case 7u:
				goto IL_00e2;
			default:
				return result;
			}
			break;
		}
		goto IL_000a;
		IL_00f3:
		flag = (byte)num != 0;
		num2 = 1282978995;
		goto IL_00a8;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1932338966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5643EC53u) % 4u)
				{
				case 1u:
					m_List.Remove(aNode);
					result = aNode;
					num = ((int)num2 * -548469063) ^ 0x884C63A;
					continue;
				case 0u:
					num = (int)((num2 * 1932929938) ^ 0xC98FC28);
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
			bool flag = default(bool);
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_0115:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 193924711;
					num2 = 193924711;
				}
				else
				{
					num = 858341020;
					num2 = 858341020;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xA53B3D6u) % 10u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1302651771;
							num5 = 1302651771;
						}
						else
						{
							num4 = 1148498692;
							num5 = 1148498692;
						}
						num = num4 ^ ((int)num3 * -723546315);
						continue;
					}
					case 6u:
						num = (int)((num3 * 1922070548) ^ 0x50D5C543);
						continue;
					case 5u:
						flag = JSONArray.smethod_30(string_) > 2;
						num = ((int)num3 * -1049197668) ^ 0x7D78C85E;
						continue;
					case 4u:
						current = enumerator.Current;
						num = 1871285180;
						continue;
					case 3u:
						string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
						num = 962078329;
						continue;
					case 2u:
						num = 858341020;
						continue;
					case 1u:
						num = ((int)num3 * -1551815515) ^ -457269608;
						continue;
					case 0u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = ((int)num3 * -898951735) ^ -1187824807;
						continue;
					default:
						goto end_IL_00cb;
					case 9u:
						break;
					case 7u:
						goto end_IL_00cb;
					}
					goto IL_0115;
					continue;
					end_IL_00cb:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_31(string_, " ]");
		string result = default(string);
		while (true)
		{
			int num6 = 113720127;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xA53B3D6u) % 4u)
				{
				case 3u:
					num6 = (int)(num3 * 1302498349) ^ -25595435;
					continue;
				case 1u:
					result = string_;
					num6 = ((int)num3 * -889589555) ^ 0x3AA080A4;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1962347260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68417DF7u) % 4u)
				{
				case 3u:
					string_ = "[ ";
					num = ((int)num2 * -386650418) ^ 0x39DADD6B;
					continue;
				case 2u:
					num = (int)((num2 * 216838786) ^ 0x77CC70F6);
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_016b:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 604007002;
								num4 = 604007002;
							}
							else
							{
								num3 = 1106070930;
								num4 = 1106070930;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x68417DF7u) % 9u)
								{
								case 7u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = ((int)num2 * -1951571617) ^ -802757159;
									continue;
								case 6u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 1281710151;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = 1289696909;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 2008590526;
										num6 = 2008590526;
									}
									else
									{
										num5 = 1580526273;
										num6 = 1580526273;
									}
									num3 = num5 ^ ((int)num2 * -1321504788);
									continue;
								}
								case 2u:
									num3 = 604007002;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -603925092) ^ 0x6D1C36DD;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 587425419) ^ -1906114526;
									continue;
								default:
									goto end_IL_0125;
								case 5u:
									break;
								case 8u:
									goto end_IL_0125;
								}
								goto IL_016b;
								continue;
								end_IL_0125:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 2892972;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x68417DF7u) % 4u)
							{
							case 3u:
								result = string_;
								num7 = ((int)num2 * -1066353717) ^ 0x13ACFB7;
								continue;
							case 1u:
								num7 = (int)(num2 * 1418474128) ^ -2033608919;
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
			int num = 234999157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E29D011u) % 9u)
				{
				case 6u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1013397821) ^ 0x31D74363;
					continue;
				case 5u:
					flag = num3 < m_List.Count;
					num = 1935992732;
					continue;
				case 4u:
					num = (int)(num2 * 1324207136) ^ -1785620500;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1549988176;
						num5 = 1549988176;
					}
					else
					{
						num4 = 463264302;
						num5 = 463264302;
					}
					num = num4 ^ ((int)num2 * -691883858);
					continue;
				}
				case 2u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num3 = 0;
					num = (int)((num2 * 1069180878) ^ 0x77983612);
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -2079818015) ^ 0x282A28F2;
					continue;
				case 0u:
					m_List[num3].Serialize(aWriter);
					num = 996861863;
					continue;
				default:
					return;
				case 8u:
					break;
				case 7u:
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
