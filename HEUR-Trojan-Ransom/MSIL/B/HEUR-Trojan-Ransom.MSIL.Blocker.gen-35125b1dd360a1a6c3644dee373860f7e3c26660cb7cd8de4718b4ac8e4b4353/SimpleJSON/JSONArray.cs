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
				goto IL_002b;
			}
			goto IL_0091;
			IL_002b:
			int num = -484994868;
			goto IL_0055;
			IL_0055:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AC1F9F5u) % 6u)
				{
				case 4u:
					result = m_List[aIndex];
					num = -1684187978;
					continue;
				case 2u:
					break;
				case 1u:
					num = ((int)num2 * -1392202100) ^ 0x7706888A;
					continue;
				case 0u:
					result = new JSONLazyCreator(this);
					num = ((int)num2 * -339599912) ^ -618627504;
					continue;
				case 5u:
					goto IL_007e;
				default:
					return result;
				}
				break;
				IL_007e:
				if (aIndex < m_List.Count)
				{
					num = -1319164371;
					num3 = -1319164371;
					continue;
				}
				goto IL_0091;
			}
			goto IL_002b;
			IL_0091:
			num = -496506827;
			num3 = -496506827;
			goto IL_0055;
		}
		set
		{
			while (true)
			{
				int num = 69575278;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x5F882Au) % 7u)
					{
					case 5u:
						num = ((int)num2 * -1829906227) ^ 0x256B44A1;
						continue;
					case 4u:
						m_List[aIndex] = value;
						num = 54875390;
						continue;
					case 3u:
						m_List.Add(value);
						num = (int)(num2 * 205261140) ^ -1670884095;
						continue;
					case 2u:
						if (aIndex < m_List.Count)
						{
							num = 773864020;
							num3 = 773864020;
							continue;
						}
						goto IL_0057;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 611131194) ^ 0x2457BDC9);
							continue;
						}
						goto IL_0057;
					default:
						return;
					case 0u:
						break;
					case 6u:
						return;
						IL_0057:
						num = 179008358;
						num3 = 179008358;
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
				int num = 816364634;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x18749BA3u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -356645087) ^ 0x5D517540;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1570939258) ^ 0x6FAE91DE;
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
		set
		{
			while (true)
			{
				int num = -2076250265;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCBCC7A66u) % 4u)
					{
					case 1u:
						m_List.Add(value);
						num = ((int)num2 * -1118849695) ^ 0x7FA34F17;
						continue;
					case 0u:
						num = ((int)num2 * -886241162) ^ 0x6014F2F1;
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
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 57944881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x75574588u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_List.Count;
					num = (int)(num2 * 1558065099) ^ -848354484;
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
				int num = -152556095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8ADFC231u) % 3u)
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
					num = (int)((num2 * 169911501) ^ 0x2F15D9D2);
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
		while (true)
		{
			int num = 736286988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67328681u) % 3u)
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
				num = (int)(num2 * 961246541) ^ -760456245;
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
			int num = -291920736;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x99421157u) % 9u)
				{
				case 8u:
					result = jSONNode;
					num = ((int)num2 * -785044436) ^ -1345528611;
					continue;
				case 7u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_002b;
				case 5u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = -1906814814;
					continue;
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -346711482) ^ -868762437;
						continue;
					}
					num5 = 1;
					goto IL_002b;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 525185916;
						num4 = 525185916;
					}
					else
					{
						num3 = 1876261470;
						num4 = 1876261470;
					}
					num = num3 ^ ((int)num2 * -79145584);
					continue;
				}
				case 1u:
					result = null;
					num = ((int)num2 * -29195125) ^ 0xA809306;
					continue;
				case 0u:
					num = ((int)num2 * -484901730) ^ 0x272AF1BD;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_002b:
					flag = (byte)num5 != 0;
					num = -1492459864;
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
			int num = -1508837712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5BEF4CFu) % 3u)
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
				num = (int)((num2 * 2146431653) ^ 0x37E4E771);
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		while (true)
		{
			int num = -1223760399;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF866E001u) % 3u)
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
							IL_0139:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1871704324;
								num4 = -1871704324;
							}
							else
							{
								num3 = -1404645781;
								num4 = -1404645781;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF866E001u) % 9u)
								{
								case 8u:
									num3 = (int)((num2 * 1464416018) ^ 0x2C4F76D0);
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1482961991;
										num6 = -1482961991;
									}
									else
									{
										num5 = -896065802;
										num6 = -896065802;
									}
									num3 = num5 ^ (int)(num2 * 1088589941);
									continue;
								}
								case 5u:
									current = enumerator.Current;
									num3 = -1459105090;
									continue;
								case 3u:
									num3 = -1871704324;
									continue;
								case 2u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -1319723241) ^ -641961684;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1864345137) ^ -1725496946;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1004696996;
									continue;
								default:
									goto end_IL_00f3;
								case 7u:
									break;
								case 4u:
									goto end_IL_00f3;
								}
								goto IL_0139;
								continue;
								end_IL_00f3:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_31(string_, " ]");
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -684254834) ^ -1048582830;
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
			int num = 120604562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9EFE60u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1875053821) ^ -1386711898;
					continue;
				case 2u:
					string_ = "[ ";
					num = (int)(num2 * 310437577) ^ -1803476423;
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0171:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 799435000;
								num4 = 799435000;
							}
							else
							{
								num3 = 961546278;
								num4 = 961546278;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF9EFE60u) % 9u)
								{
								case 8u:
									num3 = (int)((num2 * 611795433) ^ 0x4D2F1997);
									continue;
								case 7u:
									num3 = 799435000;
									continue;
								case 6u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = 1178545841;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1196200845) ^ -2047156026;
									continue;
								case 2u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 1939158219;
									continue;
								case 1u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)(num2 * 472382888) ^ -164799728;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1345647291;
										num6 = -1345647291;
									}
									else
									{
										num5 = -697745753;
										num6 = -697745753;
									}
									num3 = num5 ^ ((int)num2 * -755789472);
									continue;
								}
								default:
									goto end_IL_012b;
								case 4u:
									break;
								case 3u:
									goto end_IL_012b;
								}
								goto IL_0171;
								continue;
								end_IL_012b:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 1589732165;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xF9EFE60u) % 4u)
							{
							case 3u:
								num7 = (int)((num2 * 169735269) ^ 0xFB4A9ED);
								continue;
							case 1u:
								result = string_;
								num7 = ((int)num2 * -930026633) ^ -135048944;
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
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1770432071;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35B416BBu) % 11u)
				{
				case 10u:
					num3 = 0;
					num = ((int)num2 * -1170369995) ^ 0x6B1260F6;
					continue;
				case 9u:
					num = (int)((num2 * 1696909314) ^ 0x679C6813);
					continue;
				case 7u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)(num2 * 1771869424) ^ -679506377;
					continue;
				case 6u:
					num = 525782935;
					continue;
				case 4u:
					num3++;
					num = (int)(num2 * 1153171200) ^ -1533134437;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 98861141;
						num5 = 98861141;
					}
					else
					{
						num4 = 880564698;
						num5 = 880564698;
					}
					num = num4 ^ (int)(num2 * 1034082259);
					continue;
				}
				case 2u:
					m_List[num3].Serialize(aWriter);
					num = (int)(num2 * 564452120) ^ -592691880;
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1344415356) ^ 0x51774D6E);
					continue;
				case 0u:
					flag = num3 < m_List.Count;
					num = 813638239;
					continue;
				default:
					return;
				case 8u:
					break;
				case 5u:
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
			int num = -1897829418;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBA41E5Fu) % 3u)
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
				num = (int)(num2 * 86381700) ^ -179149342;
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
