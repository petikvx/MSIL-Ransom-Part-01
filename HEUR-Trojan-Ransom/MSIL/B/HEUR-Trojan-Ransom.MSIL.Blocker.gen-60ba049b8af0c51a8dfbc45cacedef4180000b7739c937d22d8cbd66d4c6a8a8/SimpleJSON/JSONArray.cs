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
				goto IL_0017;
			}
			goto IL_0091;
			IL_0017:
			int num = -950976008;
			goto IL_0055;
			IL_0055:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0008ACFu) % 6u)
				{
				case 4u:
					break;
				case 3u:
					result = new JSONLazyCreator(this);
					num = (int)((num2 * 1612049369) ^ 0x156CCC2);
					continue;
				case 1u:
					result = m_List[aIndex];
					num = -38655629;
					continue;
				case 0u:
					num = ((int)num2 * -610732835) ^ -46491037;
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
					num = -1885436312;
					num3 = -1885436312;
					continue;
				}
				goto IL_0091;
			}
			goto IL_0017;
			IL_0091:
			num = -1524799750;
			num3 = -1524799750;
			goto IL_0055;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -316029932;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x8256647Du) % 8u)
					{
					case 5u:
						m_List.Add(value);
						num = (int)(num2 * 1519786274) ^ -1800407961;
						continue;
					case 4u:
						m_List[aIndex] = value;
						num = -502189101;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1683869195;
							num5 = -1683869195;
						}
						else
						{
							num4 = -505296764;
							num5 = -505296764;
						}
						num = num4 ^ ((int)num2 * -733418033);
						continue;
					}
					case 2u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_006a;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -786149225) ^ 0x405B578;
							continue;
						}
						num3 = 1;
						goto IL_006a;
					case 0u:
						num = (int)(num2 * 218779690) ^ -1080863437;
						continue;
					default:
						return;
					case 7u:
						break;
					case 6u:
						return;
						IL_006a:
						flag = (byte)num3 != 0;
						num = -2000464994;
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
				int num = 17713985;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7DC008F8u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1903028941) ^ -108924106;
						continue;
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1188719707) ^ -1533912031;
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
				int num = 1748950517;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7189AF56u) % 3u)
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
					num = (int)(num2 * 1096517874) ^ -1421168659;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1085661782;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD35EC072u) % 3u)
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
					num = (int)(num2 * 1773991523) ^ -37434117;
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
			int num = 1750191047;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x4EC9BD85u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -991913573;
						num5 = -991913573;
					}
					else
					{
						num4 = -229698676;
						num5 = -229698676;
					}
					num = num4 ^ ((int)num2 * -39906616);
					continue;
				}
				case 6u:
					result = null;
					num = (int)((num2 * 1323112756) ^ 0x773A0428);
					continue;
				case 4u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_004c;
				case 3u:
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = ((int)num2 * -2107085972) ^ -1932724780;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 420266915) ^ -1997001529;
						continue;
					}
					num3 = 1;
					goto IL_004c;
				case 1u:
					jSONNode = m_List[aIndex];
					num = 584922438;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_004c:
					flag = (byte)num3 != 0;
					num = 652955490;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		while (true)
		{
			int num = -1407549604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB11C91D9u) % 3u)
				{
				case 1u:
					goto IL_0011;
				case 0u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0011:
				num = ((int)num2 * -835481035) ^ 0x3D11D136;
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
		bool flag = default(bool);
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 838539961;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59CE389Bu) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = (int)((num2 * 1358268184) ^ 0x2DAEB326);
					continue;
				case 1u:
					num = ((int)num2 * -1509255189) ^ -1426346236;
					continue;
				case 3u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_014e:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1705189806;
								num4 = 1705189806;
							}
							else
							{
								num3 = 1055514612;
								num4 = 1055514612;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x59CE389Bu) % 9u)
								{
								case 8u:
									num3 = ((int)num2 * -836253154) ^ 0x9FC0547;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1675795176;
										num6 = -1675795176;
									}
									else
									{
										num5 = -487975787;
										num6 = -487975787;
									}
									num3 = num5 ^ ((int)num2 * -62817426);
									continue;
								}
								case 5u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -2127029998) ^ 0x7BEF59CC;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = 2042503052;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 2057953803;
									continue;
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1960105529) ^ -1592217226;
									continue;
								case 0u:
									num3 = 1705189806;
									continue;
								default:
									goto end_IL_0108;
								case 1u:
									break;
								case 7u:
									goto end_IL_0108;
								}
								goto IL_014e;
								continue;
								end_IL_0108:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = 1581235340;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x59CE389Bu) % 4u)
							{
							case 3u:
								result = string_;
								num7 = ((int)num2 * -1755938202) ^ -580770456;
								continue;
							case 1u:
								num7 = ((int)num2 * -542153464) ^ -279839879;
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

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
		{
			JSONNode current = default(JSONNode);
			while (true)
			{
				IL_010a:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1952526617;
					num2 = 1952526617;
				}
				else
				{
					num = 151513611;
					num2 = 151513611;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x13DB429u) % 8u)
					{
					case 7u:
						num = 151513611;
						continue;
					case 6u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = 92644042;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (JSONArray.smethod_30(string_) <= 3)
						{
							num4 = -2128417828;
							num5 = -2128417828;
						}
						else
						{
							num4 = -1422638810;
							num5 = -1422638810;
						}
						num = num4 ^ (int)(num3 * 139776967);
						continue;
					}
					case 4u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 257691006) ^ -2000141137;
						continue;
					case 3u:
						num = (int)((num3 * 1150985824) ^ 0x33390A28);
						continue;
					case 2u:
						current = enumerator.Current;
						num = 377899572;
						continue;
					default:
						goto end_IL_00c9;
					case 1u:
						break;
					case 0u:
						goto end_IL_00c9;
					}
					goto IL_010a;
					continue;
					end_IL_00c9:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num6 = 697250244;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x13DB429u) % 4u)
				{
				case 1u:
					result = string_;
					num6 = ((int)num3 * -1201901564) ^ 0x64072979;
					continue;
				case 0u:
					num6 = (int)(num3 * 524433505) ^ -1394005713;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 114397620;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49A9386Cu) % 9u)
				{
				case 6u:
					num = ((int)num2 * -1753260297) ^ 0x339D0B78;
					continue;
				case 5u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -1796895049) ^ -304666097;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -594019213) ^ 0x4641F4D6;
					continue;
				case 3u:
					m_List[num3].Serialize(aWriter);
					num3++;
					num = 101000022;
					continue;
				case 2u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)(num2 * 1098002859) ^ -1368385385;
					continue;
				case 1u:
					num = ((int)num2 * -212192212) ^ -751438564;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < m_List.Count)
					{
						num = 328790279;
						num4 = 328790279;
					}
					else
					{
						num = 1700086800;
						num4 = 1700086800;
					}
					continue;
				}
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

	public JSONArray()
	{
		while (true)
		{
			int num = 513700671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60F52213u) % 3u)
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
				num = ((int)num2 * -1700726904) ^ -547081585;
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
