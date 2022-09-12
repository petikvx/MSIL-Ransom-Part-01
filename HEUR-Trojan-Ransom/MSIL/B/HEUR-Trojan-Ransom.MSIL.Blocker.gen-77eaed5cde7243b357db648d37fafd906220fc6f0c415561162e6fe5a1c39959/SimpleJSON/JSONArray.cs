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
			if (aIndex >= 0)
			{
				goto IL_0019;
			}
			int num = 1;
			goto IL_00bd;
			IL_00bd:
			bool flag = (byte)num != 0;
			int num2 = 786524070;
			goto IL_007b;
			IL_0019:
			num2 = 1339423234;
			goto IL_007b;
			IL_007b:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3B88C4DDu) % 8u)
				{
				case 6u:
					num2 = ((int)num3 * -1815586647) ^ -838868671;
					continue;
				case 5u:
					break;
				case 4u:
					result = m_List[aIndex];
					num2 = 1769524003;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1932222968;
						num5 = 1932222968;
					}
					else
					{
						num4 = 1958511237;
						num5 = 1958511237;
					}
					num2 = num4 ^ (int)(num3 * 562097875);
					continue;
				}
				case 1u:
					result = new JSONLazyCreator(this);
					num2 = ((int)num3 * -1659411385) ^ -2032636206;
					continue;
				case 0u:
					num2 = ((int)num3 * -446674923) ^ 0x4CC6352F;
					continue;
				case 7u:
					goto IL_00ac;
				default:
					return result;
				}
				break;
			}
			goto IL_0019;
			IL_00ac:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00bd;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0049;
			}
			int num = 1;
			goto IL_00af;
			IL_009e:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00af;
			IL_0049:
			int num2 = 2072208517;
			goto IL_0071;
			IL_0071:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x540361B0u) % 7u)
				{
				case 6u:
					m_List.Add(value);
					num2 = (int)((num3 * 1445247254) ^ 0x1CB18338);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1408466135;
						num5 = -1408466135;
					}
					else
					{
						num4 = -458101759;
						num5 = -458101759;
					}
					num2 = num4 ^ ((int)num3 * -503732259);
					continue;
				}
				case 2u:
					break;
				case 1u:
					num2 = ((int)num3 * -162353038) ^ -116100824;
					continue;
				case 0u:
					m_List[aIndex] = value;
					num2 = 2122761622;
					continue;
				default:
					return;
				case 5u:
					goto IL_009e;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0049;
			IL_00af:
			flag = (byte)num != 0;
			num2 = 1736469455;
			goto IL_0071;
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1114967338;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E68FEF4u) % 4u)
					{
					case 2u:
						result = new JSONLazyCreator(this);
						num = (int)(num2 * 591757111) ^ -838427461;
						continue;
					case 1u:
						num = (int)(num2 * 904400277) ^ -1048780574;
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
		set
		{
			m_List.Add(value);
			while (true)
			{
				int num = 996682041;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77CA6112u) % 3u)
					{
					case 2u:
						goto IL_000e;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000e:
					num = (int)(num2 * 619054482) ^ -796120234;
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
				int num = 708164799;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1ED83286u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -151389797) ^ -1026908212;
						continue;
					case 1u:
						count = m_List.Count;
						num = ((int)num2 * -1071446079) ^ -96562955;
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
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1366168333;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD9F7B7Bu) % 3u)
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
					num = (int)((num2 * 86862486) ^ 0x3D12ACE);
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 1779228107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C50E0D2u) % 4u)
				{
				case 1u:
					m_List.Add(aItem);
					num = (int)((num2 * 1961971907) ^ 0x527291D9);
					continue;
				case 0u:
					num = ((int)num2 * -53846857) ^ -1883139816;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -1054224115;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE9B58233u) % 11u)
				{
				case 10u:
					result = null;
					num = (int)((num2 * 917171404) ^ 0x2CD0D584);
					continue;
				case 9u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1716452035;
						num5 = -1716452035;
					}
					else
					{
						num4 = -1155496903;
						num5 = -1155496903;
					}
					num = num4 ^ ((int)num2 * -1050139922);
					continue;
				}
				case 7u:
					result = jSONNode;
					num = (int)(num2 * 564907866) ^ -1904058880;
					continue;
				case 6u:
					m_List.RemoveAt(aIndex);
					num = (int)((num2 * 185487540) ^ 0x4605D0F6);
					continue;
				case 4u:
					num = ((int)num2 * -665874213) ^ 0x4B344A6E;
					continue;
				case 3u:
					num = ((int)num2 * -302017216) ^ -797487525;
					continue;
				case 2u:
					jSONNode = m_List[aIndex];
					num = -1000737013;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -2053850985) ^ 0x122A0A55;
						continue;
					}
					num3 = 1;
					goto IL_00b3;
				case 0u:
					num3 = ((aIndex >= m_List.Count) ? 1 : 0);
					goto IL_00b3;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_00b3:
					flag = (byte)num3 != 0;
					num = -418880495;
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
			int num = 622760218;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x315F9017u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 571371692) ^ -616843164;
					continue;
				case 1u:
					result = aNode;
					num = ((int)num2 * -1749808694) ^ -75986221;
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
		string result = default(string);
		while (true)
		{
			int num = -1969944838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAEAD4067u) % 4u)
				{
				case 1u:
					string_ = "[ ";
					num = ((int)num2 * -1832009491) ^ 0x5655C6F2;
					continue;
				case 0u:
					num = (int)((num2 * 1258281328) ^ 0x4A312D1D);
					continue;
				case 3u:
					break;
				default:
				{
					using (List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator())
					{
						while (true)
						{
							IL_0136:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1306758061;
								num4 = -1306758061;
							}
							else
							{
								num3 = -1107760963;
								num4 = -1107760963;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xAEAD4067u) % 8u)
								{
								case 7u:
									num3 = -1306758061;
									continue;
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = -1998933874;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = ((int)num2 * -462511551) ^ -1153295588;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = -816059433;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -246533073;
										num6 = -246533073;
									}
									else
									{
										num5 = -676036588;
										num6 = -676036588;
									}
									num3 = num5 ^ (int)(num2 * 519467135);
									continue;
								}
								case 0u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -556730201) ^ 0x5CD2A1BC;
									continue;
								default:
									goto end_IL_00f5;
								case 1u:
									break;
								case 2u:
									goto end_IL_00f5;
								}
								goto IL_0136;
								continue;
								end_IL_00f5:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num7 = -1726826943;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xAEAD4067u) % 4u)
							{
							case 2u:
								result = string_;
								num7 = (int)((num2 * 208682958) ^ 0x4E2D4D7E);
								continue;
							case 1u:
								num7 = (int)((num2 * 1860872897) ^ 0x74EDC4A);
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

	public override string ToString(string aPrefix)
	{
		string string_ = "[ ";
		List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
		try
		{
			JSONNode current = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				IL_0121:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1129608398;
					num2 = -1129608398;
				}
				else
				{
					num = -531933920;
					num2 = -531933920;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xDB07D91Fu) % 9u)
					{
					case 8u:
						current = enumerator.Current;
						num = -30635161;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 1784229197;
							num5 = 1784229197;
						}
						else
						{
							num4 = 863773859;
							num5 = 863773859;
						}
						num = num4 ^ (int)(num3 * 2141140048);
						continue;
					}
					case 4u:
						string_ = JSONArray.smethod_31(string_, ", ");
						num = (int)(num3 * 1874860342) ^ -473450795;
						continue;
					case 3u:
						flag = JSONArray.smethod_30(string_) > 3;
						num = (int)((num3 * 135699148) ^ 0x651ACB7E);
						continue;
					case 2u:
						string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
						num = ((int)num3 * -437385075) ^ -1190925368;
						continue;
					case 1u:
						string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
						num = -1281891031;
						continue;
					case 0u:
						num = -531933920;
						continue;
					default:
						goto end_IL_00db;
					case 5u:
						break;
					case 6u:
						goto end_IL_00db;
					}
					goto IL_0121;
					continue;
					end_IL_00db:
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
				IL_016c:
				int num6 = -276169879;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0xDB07D91Fu) % 3u)
					{
					case 1u:
						goto IL_0140;
					default:
						goto end_IL_014e;
					case 2u:
						break;
					case 0u:
						goto end_IL_014e;
					}
					goto IL_016c;
					IL_0140:
					num6 = (int)((num3 * 1966553323) ^ 0x45E27982);
					continue;
					end_IL_014e:
					break;
				}
				break;
			}
		}
		string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "]");
		string result = default(string);
		while (true)
		{
			int num7 = -142496404;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xDB07D91Fu) % 3u)
				{
				case 1u:
					goto IL_0188;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0188:
				result = string_;
				num7 = (int)(num3 * 858273088) ^ -499141210;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		int num3 = default(int);
		while (true)
		{
			int num = -1012220887;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A1DA567u) % 12u)
				{
				case 11u:
					num = -1199959461;
					continue;
				case 9u:
					num = ((int)num2 * -1211846620) ^ -770411849;
					continue;
				case 7u:
					num = ((int)num2 * -19097811) ^ -553530674;
					continue;
				case 6u:
					num3++;
					num = (int)((num2 * 663299922) ^ 0x14579FAF);
					continue;
				case 5u:
					num = ((int)num2 * -1853984638) ^ -548914258;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= m_List.Count)
					{
						num = -369595391;
						num4 = -369595391;
					}
					else
					{
						num = -687702060;
						num4 = -687702060;
					}
					continue;
				}
				case 3u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)(num2 * 1912689517) ^ -176863715;
					continue;
				case 2u:
					JSONArray.smethod_34(aWriter, (byte)1);
					num = (int)((num2 * 1035105594) ^ 0x48CBE03E);
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -773135331) ^ 0x17ACE2C3;
					continue;
				case 0u:
					m_List[num3].Serialize(aWriter);
					num = (int)(num2 * 1886256203) ^ -2016227576;
					continue;
				default:
					return;
				case 8u:
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
