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
				int num = -2061388841;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xDD66D649u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -2052858238) ^ -1974712607;
						continue;
					case 5u:
						result = m_List[aIndex];
						num = -155128011;
						continue;
					case 2u:
						if (aIndex < m_List.Count)
						{
							num = -738463913;
							num3 = -738463913;
							continue;
						}
						goto IL_0048;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -251940996) ^ -319891234;
							continue;
						}
						goto IL_0048;
					case 0u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -143159107) ^ 0x3DD4A6C2;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0048:
						num = -422366402;
						num3 = -422366402;
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
			IL_00c2:
			bool flag = (byte)num != 0;
			int num2 = -906577311;
			goto IL_0080;
			IL_000a:
			num2 = -992592197;
			goto IL_0080;
			IL_0080:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x84E11D15u) % 8u)
				{
				case 7u:
					break;
				case 5u:
					m_List.Add(value);
					num2 = (int)(num3 * 811939795) ^ -1169348743;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1134000612;
						num5 = 1134000612;
					}
					else
					{
						num4 = 805748632;
						num5 = 805748632;
					}
					num2 = num4 ^ (int)(num3 * 1174603097);
					continue;
				}
				case 3u:
					num2 = (int)(num3 * 1488063129) ^ -620124956;
					continue;
				case 2u:
					num2 = ((int)num3 * -1034632875) ^ 0x50CB9B57;
					continue;
				case 1u:
					m_List[aIndex] = value;
					num2 = -1107837531;
					continue;
				default:
					return;
				case 6u:
					goto IL_00b1;
				case 0u:
					return;
				}
				break;
			}
			goto IL_000a;
			IL_00b1:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00c2;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1230998956;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E45F769u) % 4u)
					{
					case 1u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 1899732123) ^ -739653282;
						continue;
					case 0u:
						num = ((int)num2 * -382531791) ^ -932676969;
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
			while (true)
			{
				int num = -1224482713;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB94A93Cu) % 4u)
					{
					case 3u:
						m_List.Add(value);
						num = (int)(num2 * 968574399) ^ -413316164;
						continue;
					case 1u:
						num = ((int)num2 * -887266524) ^ -1733393778;
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
			int count = m_List.Count;
			while (true)
			{
				int num = 1287886415;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x38A0B8D5u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 2u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = ((int)num2 * -1571976546) ^ -1357993681;
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
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -1985259511;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x971D5D8Eu) % 8u)
				{
				case 7u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 622202290) ^ 0x16406C99);
						continue;
					}
					goto IL_001f;
				case 6u:
					num = ((int)num2 * -1883356782) ^ 0x7189830F;
					continue;
				case 4u:
					result = jSONNode;
					num = (int)(num2 * 808732496) ^ -1466419488;
					continue;
				case 3u:
					result = null;
					num = (int)((num2 * 88619649) ^ 0x4A0F6D48);
					continue;
				case 2u:
					jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					num = -1586597934;
					continue;
				case 1u:
					if (aIndex < m_List.Count)
					{
						num = -1709891140;
						num3 = -1709891140;
						continue;
					}
					goto IL_001f;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001f:
					num = -95403915;
					num3 = -95403915;
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
			int num = -1154041645;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6197B8Eu) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000f:
				result = aNode;
				num = ((int)num2 * -1766638293) ^ -1367850705;
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
		JSONNode current = default(JSONNode);
		string string_ = default(string);
		while (true)
		{
			int num = -806582937;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFAD8FCC2u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0138:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1260902871;
								num4 = -1260902871;
							}
							else
							{
								num3 = -151460108;
								num4 = -151460108;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFAD8FCC2u) % 9u)
								{
								case 6u:
									current = enumerator.Current;
									num3 = -545855570;
									continue;
								case 5u:
									num3 = -1260902871;
									continue;
								case 4u:
									num3 = (int)((num2 * 2097542155) ^ 0x492475E8);
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 2)
									{
										num5 = -946464807;
										num6 = -946464807;
									}
									else
									{
										num5 = -1658508312;
										num6 = -1658508312;
									}
									num3 = num5 ^ ((int)num2 * -449987403);
									continue;
								}
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1249883032) ^ 0x6DC2C15F;
									continue;
								case 1u:
									num3 = ((int)num2 * -2120423449) ^ -282182179;
									continue;
								case 0u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1905043581;
									continue;
								default:
									goto end_IL_00f2;
								case 8u:
									break;
								case 7u:
									goto end_IL_00f2;
								}
								goto IL_0138;
								continue;
								end_IL_00f2:
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
				num = ((int)num2 * -705294100) ^ 0x530ED8C1;
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
			int num = 1140651119;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71DAC58u) % 3u)
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
							IL_015a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 2072730518;
								num4 = 2072730518;
							}
							else
							{
								num3 = 1710755072;
								num4 = 1710755072;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x71DAC58u) % 9u)
								{
								case 8u:
									num3 = 2072730518;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1087808014;
										num6 = -1087808014;
									}
									else
									{
										num5 = -1334282175;
										num6 = -1334282175;
									}
									num3 = num5 ^ ((int)num2 * -1778595484);
									continue;
								}
								case 5u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = (int)((num2 * 415781889) ^ 0x64BFF7F0);
									continue;
								case 4u:
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = (int)(num2 * 1749302533) ^ -1179089214;
									continue;
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 663238572) ^ -1468366070;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 231302511;
									continue;
								case 0u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 686025197;
									continue;
								default:
									goto end_IL_0114;
								case 7u:
									break;
								case 3u:
									goto end_IL_0114;
								}
								goto IL_015a;
								continue;
								end_IL_0114:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 96137774;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x71DAC58u) % 4u)
							{
							case 3u:
								num7 = (int)(num2 * 2084381798) ^ -1125393613;
								continue;
							case 2u:
								result = string_;
								num7 = (int)(num2 * 1803262037) ^ -1024080767;
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
				num = (int)(num2 * 479642771) ^ -455191130;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1602499335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD340166u) % 10u)
				{
				case 9u:
					num5++;
					num = ((int)num2 * -264195073) ^ -1820118313;
					continue;
				case 8u:
					flag = num5 < m_List.Count;
					num = -479053628;
					continue;
				case 7u:
					num5 = 0;
					num = (int)(num2 * 935556347) ^ -710044957;
					continue;
				case 6u:
					num = -2093324725;
					continue;
				case 3u:
					m_List[num5].Serialize(aWriter);
					num = (int)((num2 * 1822701722) ^ 0x59800FBB);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 653454580;
						num4 = 653454580;
					}
					else
					{
						num3 = 986870584;
						num4 = 986870584;
					}
					num = num3 ^ (int)(num2 * 1171911446);
					continue;
				}
				case 1u:
					JSONArray.smethod_34(aWriter, (byte)1);
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = ((int)num2 * -1391513639) ^ -469339524;
					continue;
				case 0u:
					num = (int)(num2 * 988691574) ^ -1290993222;
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

	public JSONArray()
	{
		while (true)
		{
			int num = -1455567928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC54481C3u) % 3u)
				{
				case 2u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0013:
				num = (int)((num2 * 2127547746) ^ 0x31708042);
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
