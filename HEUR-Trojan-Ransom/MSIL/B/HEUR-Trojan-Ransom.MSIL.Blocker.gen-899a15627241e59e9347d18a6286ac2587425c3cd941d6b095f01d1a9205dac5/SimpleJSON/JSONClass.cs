using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON;

public class JSONClass : JSONNode, IEnumerable
{
	private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -878370916;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82FC3A3Au) % 7u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = -722255074;
							num4 = -722255074;
						}
						else
						{
							num3 = -403553598;
							num4 = -403553598;
						}
						num = num3 ^ ((int)num2 * -418081383);
						continue;
					}
					case 4u:
						num = ((int)num2 * -911878141) ^ -782498902;
						continue;
					case 2u:
						result = m_Dict[aKey];
						num = (int)(num2 * 920926423) ^ -1072410461;
						continue;
					case 1u:
						result = new JSONLazyCreator(this, aKey);
						num = -755742939;
						continue;
					case 0u:
						num = (int)((num2 * 1524750402) ^ 0x6D7BD501);
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
				int num = 1138341658;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x636743BBu) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1559963024) ^ 0x18895F53);
						continue;
					case 5u:
						m_Dict.Add(aKey, value);
						num = 21939055;
						continue;
					case 3u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 351403906) ^ 0x5C9D4A77);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = 1359908241;
							num4 = 1359908241;
						}
						else
						{
							num3 = 1746623214;
							num4 = 1746623214;
						}
						num = num3 ^ ((int)num2 * -1388214415);
						continue;
					}
					case 0u:
						num = ((int)num2 * -916831574) ^ 0x72DB88BF;
						continue;
					default:
						return;
					case 4u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			if (aIndex >= 0)
			{
				goto IL_0039;
			}
			int num = 1;
			goto IL_00ad;
			IL_009c:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_00ad;
			IL_0039:
			int num2 = -107615985;
			goto IL_006b;
			IL_006b:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xB47E40DBu) % 8u)
				{
				case 7u:
					result = null;
					num2 = (int)(num3 * 17575950) ^ -161003300;
					continue;
				case 6u:
					num2 = ((int)num3 * -1923420150) ^ 0x5604C9EC;
					continue;
				case 5u:
					num2 = ((int)num3 * -462395775) ^ 0x5188E705;
					continue;
				case 2u:
					break;
				case 1u:
					result = null;
					num2 = -1787118179;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -957529260;
						num5 = -957529260;
					}
					else
					{
						num4 = -1934608206;
						num5 = -1934608206;
					}
					num2 = num4 ^ (int)(num3 * 1453109120);
					continue;
				}
				case 4u:
					goto IL_009c;
				default:
					return result;
				}
				break;
			}
			goto IL_0039;
			IL_00ad:
			flag = (byte)num != 0;
			num2 = -154953997;
			goto IL_006b;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0007;
			}
			int num = 1;
			goto IL_0075;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
			IL_0007:
			int num2 = -857413123;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC8467951u) % 5u)
				{
				case 4u:
					break;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1167257926;
						num5 = -1167257926;
					}
					else
					{
						num4 = -939109729;
						num5 = -939109729;
					}
					num2 = num4 ^ ((int)num3 * -1382411069);
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -88802986) ^ 0x72E57A10;
					continue;
				default:
					return;
				case 2u:
					goto IL_0064;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0007;
			IL_0075:
			flag = (byte)num != 0;
			num2 = -1651969924;
			goto IL_003f;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -1997055487;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC05ABC7u) % 3u)
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
					count = m_Dict.Count;
					num = ((int)num2 * -2107354061) ^ -1679478932;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1293448722;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x906BBBA4u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -943991813) ^ 0x2F59DBCD;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1832990849;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83C9A6D0u) % 15u)
				{
				case 14u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -919379932;
						num6 = -919379932;
					}
					else
					{
						num5 = -1082382352;
						num6 = -1082382352;
					}
					num = num5 ^ (int)(num2 * 1071271042);
					continue;
				}
				case 13u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 736044860) ^ -1727043859;
					continue;
				case 12u:
					m_Dict.Add(aKey, aItem);
					num = -1750398890;
					continue;
				case 9u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1100132429;
					continue;
				case 8u:
					num = -1413153641;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1748984238;
						num4 = -1748984238;
					}
					else
					{
						num3 = -2083957383;
						num4 = -2083957383;
					}
					num = num3 ^ ((int)num2 * -843920383);
					continue;
				}
				case 6u:
					num = (int)(num2 * 1794886508) ^ -1072449353;
					continue;
				case 5u:
					num = (int)(num2 * 1404275692) ^ -1272940696;
					continue;
				case 4u:
					num = (int)(num2 * 1234171051) ^ -910126117;
					continue;
				case 3u:
					flag2 = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -892941728) ^ -429636796;
					continue;
				case 2u:
					num = ((int)num2 * -995193420) ^ 0x7796CA2A;
					continue;
				case 1u:
					num = ((int)num2 * -2139596728) ^ -317557385;
					continue;
				case 0u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 934595799) ^ 0xB163D53);
					continue;
				default:
					return;
				case 11u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -1152877897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF94DFB3Bu) % 9u)
				{
				case 8u:
					result = null;
					num = (int)(num2 * 1569655193) ^ -518508256;
					continue;
				case 7u:
					m_Dict.Remove(aKey);
					num = (int)(num2 * 76495831) ^ -117707110;
					continue;
				case 6u:
					result = jSONNode;
					num = ((int)num2 * -1486723856) ^ -985962890;
					continue;
				case 5u:
					num = ((int)num2 * -645513257) ^ 0x7028F7E9;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1158221064;
						num4 = 1158221064;
					}
					else
					{
						num3 = 1815186980;
						num4 = 1815186980;
					}
					num = num3 ^ ((int)num2 * -872430547);
					continue;
				}
				case 1u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1515825874) ^ -984364666;
					continue;
				case 0u:
					jSONNode = m_Dict[aKey];
					num = -1567104136;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 563810252;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x74EA4AD5u) % 8u)
				{
				case 5u:
					num = ((int)num2 * -765784045) ^ 0x5364A965;
					continue;
				case 4u:
					result = null;
					num = (int)(num2 * 90774071) ^ -169478996;
					continue;
				case 3u:
					num = ((int)num2 * -1044649838) ^ 0x565F288C;
					continue;
				case 2u:
					if (aIndex < m_Dict.Count)
					{
						num = 56695413;
						num3 = 56695413;
						continue;
					}
					goto IL_0054;
				case 1u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -2110312267) ^ 0x58735582;
						continue;
					}
					goto IL_0054;
				case 0u:
					result = null;
					num = 1643783062;
					continue;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0054:
					num = 1530677297;
					num3 = 1530677297;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
		//IL_0068: Incompatible stack heights: 0 vs 1
		//IL_006f: Incompatible stack heights: 0 vs 1
		JSONNode result = default(JSONNode);
		try
		{
			while (true)
			{
				int num = 1868963090;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x499AF31Fu) % 3u)
					{
					case 1u:
						goto IL_0004;
					case 2u:
						break;
					default:
						return result;
					case 0u:
						return result;
					}
					break;
					IL_0004:
					result = null;
					num = ((int)num2 * -490605544) ^ -99458023;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 1563615638;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x499AF31F;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = (num2 * 452264435) ^ 0xDA1429E5u;
						continue;
					case 0:
						break;
					default:
						return result;
					case 2:
						return result;
					}
					break;
				}
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumerator_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string text = "{";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_013c:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1462141727;
					num2 = -1462141727;
				}
				else
				{
					num = -1120256786;
					num2 = -1120256786;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xC6629F34u) % 9u)
					{
					case 8u:
						num = (int)((num3 * 2062915552) ^ 0x112A28BE);
						continue;
					case 7u:
						current = enumerator.Current;
						num = -2024935477;
						continue;
					case 5u:
						num = -1120256786;
						continue;
					case 4u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)(num3 * 1399931708) ^ -1649496720;
						continue;
					case 3u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = -779711088;
						continue;
					case 1u:
						num = ((int)num3 * -1145786101) ^ 0x6ACAAC3C;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 2)
						{
							num4 = 2143565286;
							num5 = 2143565286;
						}
						else
						{
							num4 = 1615796850;
							num5 = 1615796850;
						}
						num = num4 ^ ((int)num3 * -468436097);
						continue;
					}
					default:
						goto end_IL_00f6;
					case 6u:
						break;
					case 2u:
						goto end_IL_00f6;
					}
					goto IL_013c;
					continue;
					end_IL_00f6:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num6 = -399237287;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xC6629F34u) % 4u)
				{
				case 3u:
					num6 = ((int)num3 * -1616553326) ^ 0x274F60D6;
					continue;
				case 1u:
					result = text;
					num6 = (int)((num3 * 936057526) ^ 0x6126EE51);
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 813395079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4983109Fu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_018f:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 866774254;
								num4 = 866774254;
							}
							else
							{
								num3 = 1064137087;
								num4 = 1064137087;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x4983109Fu) % 9u)
								{
								case 7u:
									current = enumerator.Current;
									num3 = 1021865037;
									continue;
								case 6u:
									num3 = ((int)num2 * -763471018) ^ 0x9A412AD;
									continue;
								case 5u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 545547542;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1725024258) ^ 0x74905E70;
									continue;
								case 3u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -445632796) ^ -1774297886;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 3)
									{
										num5 = 89149890;
										num6 = 89149890;
									}
									else
									{
										num5 = 28386941;
										num6 = 28386941;
									}
									num3 = num5 ^ (int)(num2 * 658490199);
									continue;
								}
								case 0u:
									num3 = 866774254;
									continue;
								default:
									goto end_IL_0149;
								case 8u:
									break;
								case 2u:
									goto end_IL_0149;
								}
								goto IL_018f;
								continue;
								end_IL_0149:
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
							IL_01da:
							int num7 = 788947285;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x4983109Fu) % 3u)
								{
								case 1u:
									goto IL_01ae;
								default:
									goto end_IL_01bc;
								case 0u:
									break;
								case 2u:
									goto end_IL_01bc;
								}
								goto IL_01da;
								IL_01ae:
								num7 = ((int)num2 * -827359706) ^ 0x1991D4B7;
								continue;
								end_IL_01bc:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = 407140738;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x4983109Fu) % 4u)
							{
							case 1u:
								result = text;
								num8 = ((int)num2 * -738704998) ^ -1271415967;
								continue;
							case 0u:
								num8 = (int)(num2 * 2051024855) ^ -1520984840;
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
				text = "{ ";
				num = ((int)num2 * -2004013118) ^ 0x3C016E9E;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -539225848;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE02FC2Bu) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
				{
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					try
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -2050306204;
								num4 = -2050306204;
							}
							else
							{
								num3 = -2142855966;
								num4 = -2142855966;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xAE02FC2Bu) % 9u)
								{
								case 8u:
									num3 = -2050306204;
									continue;
								case 7u:
									current = enumerator.Current;
									num3 = -808801390;
									continue;
								case 6u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -640665166) ^ 0x71858AA6;
									continue;
								case 5u:
									JSONClass.smethod_38(aWriter, current);
									num3 = (int)(num2 * 1278741509) ^ -527890374;
									continue;
								case 3u:
									num3 = (int)(num2 * 717671292) ^ -979597578;
									continue;
								case 2u:
									num3 = (int)(num2 * 1544053031) ^ -909691249;
									continue;
								case 1u:
									num3 = (int)((num2 * 1287778884) ^ 0x125973F1);
									continue;
								default:
									return;
								case 4u:
									break;
								case 0u:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_0175:
							int num5 = -1553627744;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xAE02FC2Bu) % 3u)
								{
								case 1u:
									goto IL_014b;
								default:
									goto end_IL_0158;
								case 2u:
									break;
								case 0u:
									goto end_IL_0158;
								}
								goto IL_0175;
								IL_014b:
								num5 = ((int)num2 * -1493605536) ^ -2035157053;
								continue;
								end_IL_0158:
								break;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0009:
				num = ((int)num2 * -326847681) ^ -1005118302;
			}
		}
	}

	public JSONClass()
	{
		while (true)
		{
			int num = -1183558716;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x918CC806u) % 3u)
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
				num = (int)(num2 * 811492280) ^ -1012370226;
			}
		}
	}

	static bool smethod_30(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static int smethod_31(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_32(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_33(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_34(string[] string_0)
	{
		return string.Concat(string_0);
	}

	static string smethod_35(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_36(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_37(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	static void smethod_38(BinaryWriter binaryWriter_0, string string_0)
	{
		binaryWriter_0.Write(string_0);
	}
}
