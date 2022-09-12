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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1322778765;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x1D92F961u) % 8u)
					{
					case 6u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0017;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1962636650;
							num5 = 1962636650;
						}
						else
						{
							num4 = 282030411;
							num5 = 282030411;
						}
						num = num4 ^ ((int)num2 * -2020223035);
						continue;
					}
					case 4u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1204258131) ^ 0xE4DACBB;
							continue;
						}
						num3 = 1;
						goto IL_0017;
					case 3u:
						result = m_List[aIndex];
						num = 439536577;
						continue;
					case 2u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -1303221293) ^ -1396669714;
						continue;
					case 1u:
						num = ((int)num2 * -715642143) ^ 0x1F02BF08;
						continue;
					case 7u:
						break;
					default:
						{
							return result;
						}
						IL_0017:
						flag = (byte)num3 != 0;
						num = 1903101140;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1587480629;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2C8DFB4Cu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -251768456) ^ 0x7D904DF7;
						continue;
					case 7u:
						m_List[aIndex] = value;
						num = 450965727;
						continue;
					case 6u:
						m_List.Add(value);
						num = (int)(num2 * 778871734) ^ -1343601841;
						continue;
					case 4u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_0058;
					case 3u:
						num = (int)(num2 * 1410965307) ^ -1158123470;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1492564346;
							num5 = -1492564346;
						}
						else
						{
							num4 = -2119572703;
							num5 = -2119572703;
						}
						num = num4 ^ ((int)num2 * -500997224);
						continue;
					}
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -459261161) ^ -810424301;
							continue;
						}
						num3 = 1;
						goto IL_0058;
					default:
						return;
					case 0u:
						break;
					case 5u:
						return;
						IL_0058:
						flag = (byte)num3 != 0;
						num = 1131836439;
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
				int num = 832673204;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DAB5E79u) % 3u)
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
					num = (int)(num2 * 446714479) ^ -21992248;
				}
			}
		}
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = 1889479813;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B5B2906u) % 3u)
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
					num = ((int)num2 * -330176838) ^ 0x431102A3;
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
				int num = 1476030358;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50AD87A8u) % 3u)
					{
					case 1u:
						goto IL_000e;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_000e:
					num = (int)(num2 * 308931244) ^ -1327677469;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
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
		if (aIndex >= 0)
		{
			goto IL_003b;
		}
		int num = 1;
		goto IL_00da;
		IL_00c9:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00da;
		IL_003b:
		int num2 = -1746833206;
		goto IL_0093;
		IL_0093:
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xD56E7F08u) % 9u)
			{
			case 8u:
				num2 = ((int)num3 * -1704674977) ^ -1296441958;
				continue;
			case 5u:
				result = jSONNode;
				num2 = ((int)num3 * -1640964014) ^ 0x158D47C8;
				continue;
			case 4u:
				result = null;
				num2 = (int)(num3 * 166385889) ^ -833359365;
				continue;
			case 3u:
				break;
			case 2u:
				num2 = (int)(num3 * 1907665490) ^ -1744300844;
				continue;
			case 1u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = -83269755;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 638706677;
					num5 = 638706677;
				}
				else
				{
					num4 = 1516058291;
					num5 = 1516058291;
				}
				num2 = num4 ^ (int)(num3 * 1860517671);
				continue;
			}
			case 7u:
				goto IL_00c9;
			default:
				return result;
			}
			break;
		}
		goto IL_003b;
		IL_00da:
		flag = (byte)num != 0;
		num2 = -409835884;
		goto IL_0093;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		m_List.Remove(aNode);
		while (true)
		{
			int num = -364240835;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA35C88DEu) % 3u)
				{
				case 1u:
					goto IL_0011;
				case 2u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0011:
				num = ((int)num2 * -1203101599) ^ 0x5B5CD8D;
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
			int num = 1049840307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E56ECA8u) % 3u)
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
							IL_0137:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 532708657;
								num4 = 532708657;
							}
							else
							{
								num3 = 370937279;
								num4 = 370937279;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4E56ECA8u) % 9u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 657000756;
									continue;
								case 6u:
									num3 = (int)((num2 * 1010702180) ^ 0x599B7A78);
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1533091306) ^ 0x35955275;
									continue;
								case 3u:
									num3 = 532708657;
									continue;
								case 2u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -73902816) ^ 0x4ADDD564;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 1443623276;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -944289433;
										num6 = -944289433;
									}
									else
									{
										num5 = -305276181;
										num6 = -305276181;
									}
									num3 = num5 ^ ((int)num2 * -1818845004);
									continue;
								}
								default:
									goto end_IL_00f1;
								case 5u:
									break;
								case 8u:
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
						int num7 = 780634410;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x4E56ECA8u) % 3u)
							{
							case 2u:
								goto IL_0166;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0166:
							num7 = (int)((num2 * 1186889854) ^ 0x7C3941DD);
						}
					}
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = (int)((num2 * 1403392407) ^ 0xECDBD88);
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
			int num = 1317519099;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41FB3036u) % 4u)
				{
				case 1u:
					string_ = "[ ";
					num = ((int)num2 * -1711175745) ^ 0x38F7D709;
					continue;
				case 0u:
					num = (int)(num2 * 951135379) ^ -99478184;
					continue;
				case 3u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0169:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 462225175;
								num4 = 462225175;
							}
							else
							{
								num3 = 665879268;
								num4 = 665879268;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x41FB3036u) % 9u)
								{
								case 8u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)(num2 * 1162611019) ^ -2075559105;
									continue;
								case 7u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num5 = 1348716202;
										num6 = 1348716202;
									}
									else
									{
										num5 = 1948144307;
										num6 = 1948144307;
									}
									num3 = num5 ^ (int)(num2 * 629179339);
									continue;
								}
								case 5u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -1478519470) ^ 0x4D23A970;
									continue;
								case 4u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 1424986833;
									continue;
								case 3u:
									num3 = 665879268;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 2027525960;
									continue;
								case 0u:
									num3 = ((int)num2 * -60230837) ^ -196272661;
									continue;
								default:
									goto end_IL_0123;
								case 6u:
									break;
								case 2u:
									goto end_IL_0123;
								}
								goto IL_0169;
								continue;
								end_IL_0123:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num7 = 1300925700;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x41FB3036u) % 3u)
							{
							case 1u:
								goto IL_019b;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_019b:
							result = string_;
							num7 = (int)(num2 * 689325683) ^ -1687432957;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1546246954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF98E686u) % 9u)
				{
				case 8u:
					num3++;
					num = ((int)num2 * -279010929) ^ 0xF201857;
					continue;
				case 7u:
					num = ((int)num2 * -1311831537) ^ 0x1B15EE86;
					continue;
				case 6u:
					m_List[num3].Serialize(aWriter);
					num = -589071892;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1319944191;
						num5 = -1319944191;
					}
					else
					{
						num4 = -1670301381;
						num5 = -1670301381;
					}
					num = num4 ^ ((int)num2 * -36924672);
					continue;
				}
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1517929216) ^ -1585764255;
					continue;
				case 2u:
					flag = num3 < m_List.Count;
					num = -1018508507;
					continue;
				case 1u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1841379913) ^ 0x56C74374);
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
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
			int num = 1604161989;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D8C817Fu) % 3u)
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
				num = ((int)num2 * -2105420524) ^ -146678598;
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
