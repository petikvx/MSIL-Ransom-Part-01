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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -773236528;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xC9A48AD4u) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1996421006;
							num5 = 1996421006;
						}
						else
						{
							num4 = 2104080413;
							num5 = 2104080413;
						}
						num = num4 ^ ((int)num2 * -573985787);
						continue;
					}
					case 6u:
						result = m_List[aIndex];
						num = -1694046745;
						continue;
					case 5u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_004f;
					case 4u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -2118775303) ^ -867080059;
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -924651479) ^ -20833389;
							continue;
						}
						num3 = 1;
						goto IL_004f;
					case 1u:
						num = (int)((num2 * 912098400) ^ 0x2C731DF8);
						continue;
					case 0u:
						num = ((int)num2 * -1568949190) ^ -160591586;
						continue;
					case 2u:
						break;
					default:
						{
							return result;
						}
						IL_004f:
						flag = (byte)num3 != 0;
						num = -1128959712;
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
				goto IL_0028;
			}
			int num = 1;
			goto IL_00d6;
			IL_00c5:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00d6;
			IL_0028:
			int num2 = -1990923070;
			goto IL_008f;
			IL_008f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xD7434E5Fu) % 9u)
				{
				case 8u:
					num2 = ((int)num3 * -301030842) ^ -1821222374;
					continue;
				case 6u:
					num2 = ((int)num3 * -2130094583) ^ -1661398241;
					continue;
				case 5u:
					break;
				case 4u:
					num2 = (int)(num3 * 953414430) ^ -521075992;
					continue;
				case 3u:
					m_List[aIndex] = value;
					num2 = -374000240;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1476920237;
						num5 = 1476920237;
					}
					else
					{
						num4 = 1945528463;
						num5 = 1945528463;
					}
					num2 = num4 ^ (int)(num3 * 502410785);
					continue;
				}
				case 0u:
					m_List.Add(value);
					num2 = ((int)num3 * -206343324) ^ 0x2C30462F;
					continue;
				default:
					return;
				case 7u:
					goto IL_00c5;
				case 1u:
					return;
				}
				break;
			}
			goto IL_0028;
			IL_00d6:
			flag = (byte)num != 0;
			num2 = -30419856;
			goto IL_008f;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -214904426;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCB12DAD3u) % 4u)
					{
					case 1u:
						result = new JSONLazyCreator(this);
						num = ((int)num2 * -687428693) ^ -2075682752;
						continue;
					case 0u:
						num = (int)((num2 * 513822255) ^ 0x587951A1);
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
				int num = -584054702;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE8C43019u) % 4u)
					{
					case 3u:
						m_List.Add(value);
						num = ((int)num2 * -303915218) ^ 0x79466CC2;
						continue;
					case 1u:
						num = (int)(num2 * 312384365) ^ -328495182;
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
				int num = 1461650252;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x26CA9881u) % 4u)
					{
					case 1u:
						count = m_List.Count;
						num = (int)(num2 * 1836025117) ^ -540520104;
						continue;
					case 0u:
						num = (int)(num2 * 133577190) ^ -1864901206;
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
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1208378796;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB040120u) % 3u)
					{
					case 2u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = (int)(num2 * 975679460) ^ -1419842179;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -723310291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF2F793Fu) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				m_List.Add(aItem);
				num = (int)(num2 * 551512906) ^ -1308032772;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -1417087469;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xBCDB05CDu) % 7u)
				{
				case 6u:
					num5 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_0017;
				case 5u:
					result = null;
					num = (int)(num2 * 292165044) ^ -1519249042;
					continue;
				case 4u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1556190958) ^ 0x58C5CEF4);
						continue;
					}
					num5 = 1;
					goto IL_0017;
				case 1u:
				{
					JSONNode jSONNode = m_List[aIndex];
					m_List.RemoveAt(aIndex);
					result = jSONNode;
					num = -749997726;
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1310983410;
						num4 = 1310983410;
					}
					else
					{
						num3 = 23647691;
						num4 = 23647691;
					}
					num = num3 ^ (int)(num2 * 289965946);
					continue;
				}
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num5 != 0;
					num = -875512219;
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
			int num = -1796334197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD56621B1u) % 3u)
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
				num = ((int)num2 * -2133635483) ^ -850725839;
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
			int num = 1308533407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x519F4D5Bu) % 3u)
				{
				case 2u:
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
							IL_0120:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1188860254;
								num4 = 1188860254;
							}
							else
							{
								num3 = 1431232597;
								num4 = 1431232597;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x519F4D5Bu) % 8u)
								{
								case 7u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -1641528451) ^ 0x2173AC4C;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = 1197377064;
									continue;
								case 4u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 393411609;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONArray.smethod_30(string_) > 2)
									{
										num5 = -553586847;
										num6 = -553586847;
									}
									else
									{
										num5 = -2059712422;
										num6 = -2059712422;
									}
									num3 = num5 ^ ((int)num2 * -1276234145);
									continue;
								}
								case 2u:
									num3 = ((int)num2 * -634877391) ^ -722153904;
									continue;
								case 0u:
									num3 = 1431232597;
									continue;
								default:
									goto end_IL_00df;
								case 1u:
									break;
								case 5u:
									goto end_IL_00df;
								}
								goto IL_0120;
								continue;
								end_IL_00df:
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
							IL_016b:
							int num7 = 1324566320;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x519F4D5Bu) % 3u)
								{
								case 1u:
									goto IL_013f;
								default:
									goto end_IL_014d;
								case 0u:
									break;
								case 2u:
									goto end_IL_014d;
								}
								goto IL_016b;
								IL_013f:
								num7 = ((int)num2 * -1118034845) ^ 0x22A7323E;
								continue;
								end_IL_014d:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = 375676682;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x519F4D5Bu) % 4u)
							{
							case 2u:
								num8 = (int)((num2 * 2082479071) ^ 0x4B965B66);
								continue;
							case 1u:
								result = string_;
								num8 = ((int)num2 * -773183874) ^ -1377259849;
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
				num = (int)(num2 * 373173111) ^ -415186424;
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
			int num = -1115943746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3A23DABu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1936333329) ^ 0x1AB0810C;
					continue;
				case 1u:
					string_ = "[ ";
					num = ((int)num2 * -1123353878) ^ -1609503074;
					continue;
				case 0u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0126:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -337767318;
								num4 = -337767318;
							}
							else
							{
								num3 = -1267068348;
								num4 = -1267068348;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE3A23DABu) % 6u)
								{
								case 5u:
									num3 = -1267068348;
									continue;
								case 4u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = -792177391;
									continue;
								case 2u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -848493612) ^ 0x11E087BD;
									continue;
								case 1u:
								{
									current = enumerator.Current;
									int num5;
									if (JSONArray.smethod_30(string_) <= 3)
									{
										num3 = -977818555;
										num5 = -977818555;
									}
									else
									{
										num3 = -602483219;
										num5 = -602483219;
									}
									continue;
								}
								default:
									goto end_IL_00ed;
								case 0u:
									break;
								case 3u:
									goto end_IL_00ed;
								}
								goto IL_0126;
								continue;
								end_IL_00ed:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
					while (true)
					{
						int num6 = -164855949;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xE3A23DABu) % 3u)
							{
							case 1u:
								goto IL_0158;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0158:
							result = string_;
							num6 = (int)(num2 * 1348640346) ^ -1185830705;
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
		while (true)
		{
			int num = 1704806739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B6889FBu) % 9u)
				{
				case 8u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 752670439) ^ -1800925698;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1675515680) ^ 0x15485901;
					continue;
				case 5u:
					m_List[num3].Serialize(aWriter);
					num = 1885701438;
					continue;
				case 4u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = ((int)num2 * -1484120431) ^ -1442852931;
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = 968301899;
						num4 = 968301899;
					}
					else
					{
						num = 1066872707;
						num4 = 1066872707;
					}
					continue;
				}
				case 2u:
					num3 = 0;
					num = ((int)num2 * -2142653542) ^ -375439529;
					continue;
				case 1u:
					num = ((int)num2 * -470396567) ^ -242368017;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
