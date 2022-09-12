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
				int num = -891837321;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D528E8Eu) % 7u)
					{
					case 6u:
						result = new JSONLazyCreator(this, aKey);
						num = -2064564068;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = -219613135;
							num4 = -219613135;
						}
						else
						{
							num3 = -1858349420;
							num4 = -1858349420;
						}
						num = num3 ^ (int)(num2 * 1209969684);
						continue;
					}
					case 4u:
						num = (int)((num2 * 502046894) ^ 0x60DC37CE);
						continue;
					case 2u:
						result = m_Dict[aKey];
						num = ((int)num2 * -892367786) ^ 0x135CD0CC;
						continue;
					case 1u:
						num = ((int)num2 * -766294922) ^ 0x54099836;
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = 370048859;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBCF34Fu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -625566710) ^ 0xAFD8378;
						continue;
					case 6u:
						num = ((int)num2 * -776952435) ^ -926774735;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1530675881;
							num4 = 1530675881;
						}
						else
						{
							num3 = 562220368;
							num4 = 562220368;
						}
						num = num3 ^ ((int)num2 * -452063769);
						continue;
					}
					case 3u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1815101136) ^ -1727478848;
						continue;
					case 2u:
						m_Dict.Add(aKey, value);
						num = 925041473;
						continue;
					case 1u:
						num = ((int)num2 * -1193196494) ^ 0x4A7021B5;
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
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1413178052;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x9C657214u) % 7u)
					{
					case 6u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 164881683;
							num5 = 164881683;
						}
						else
						{
							num4 = 465694635;
							num5 = 465694635;
						}
						num = num4 ^ ((int)num2 * -1270482097);
						continue;
					}
					case 4u:
						result = null;
						num = -992936869;
						continue;
					case 2u:
						result = null;
						num = ((int)num2 * -178346100) ^ 0x36AA6617;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -2009086280) ^ -42298195;
							continue;
						}
						num3 = 1;
						goto IL_0058;
					case 0u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0058;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0058:
						flag = (byte)num3 != 0;
						num = -1370361186;
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
				int num = 885870880;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x2FF8A257u) % 6u)
					{
					case 4u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 390394615;
							num5 = 390394615;
						}
						else
						{
							num4 = 225297248;
							num5 = 225297248;
						}
						num = num4 ^ (int)(num2 * 662351792);
						continue;
					}
					case 2u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_003b;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1271116779) ^ -564368154;
							continue;
						}
						num3 = 1;
						goto IL_003b;
					case 0u:
						num = ((int)num2 * -834253889) ^ -699845632;
						continue;
					default:
						return;
					case 5u:
						break;
					case 3u:
						return;
						IL_003b:
						flag = (byte)num3 != 0;
						num = 150111519;
						continue;
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
				int num = -1722594496;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA31880Du) % 3u)
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
					num = (int)((num2 * 472512214) ^ 0x5476AE29);
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
				int num = -996592212;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3998141u) % 3u)
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
					num = ((int)num2 * -1980492971) ^ 0x579279CD;
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
			int num = -843404395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A0758FFu) % 12u)
				{
				case 11u:
					m_Dict.Add(aKey, aItem);
					num = -1115021061;
					continue;
				case 10u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = (int)((num2 * 1102777672) ^ 0x5A648854);
					continue;
				case 9u:
					num = (int)((num2 * 1408198432) ^ 0x58D2BB8A);
					continue;
				case 8u:
					num = ((int)num2 * -1878595862) ^ 0x701CB102;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1811892017;
						num6 = 1811892017;
					}
					else
					{
						num5 = 1205983163;
						num6 = 1205983163;
					}
					num = num5 ^ ((int)num2 * -743086405);
					continue;
				}
				case 6u:
					flag = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -340746771) ^ 0x611BF055;
					continue;
				case 5u:
					num = -285675936;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2144667715;
						num4 = -2144667715;
					}
					else
					{
						num3 = -1058578259;
						num4 = -1058578259;
					}
					num = num3 ^ ((int)num2 * -1280893751);
					continue;
				}
				case 2u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -285675936;
					continue;
				case 1u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 1088238804) ^ 0x2997DBAA);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -393968615;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB332CF54u) % 9u)
				{
				case 8u:
					num = ((int)num2 * -1329635468) ^ -1410679643;
					continue;
				case 5u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -384151795) ^ 0x191084FC;
					continue;
				case 4u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -96258569) ^ -1297194330;
					continue;
				case 3u:
					num = ((int)num2 * -905752202) ^ -148702601;
					continue;
				case 2u:
					jSONNode = m_Dict[aKey];
					num = -1173256692;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -573199625;
						num4 = -573199625;
					}
					else
					{
						num3 = -134210759;
						num4 = -134210759;
					}
					num = num3 ^ ((int)num2 * -654305926);
					continue;
				}
				case 0u:
					result = null;
					num = ((int)num2 * -558727803) ^ 0x7F5C8F70;
					continue;
				case 7u:
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
		if (aIndex >= 0)
		{
			goto IL_0019;
		}
		int num = 1;
		goto IL_009a;
		IL_0089:
		num = ((aIndex >= m_Dict.Count) ? 1 : 0);
		goto IL_009a;
		IL_0019:
		int num2 = 669146942;
		goto IL_005c;
		IL_005c:
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x28FED61Bu) % 7u)
			{
			case 6u:
				num2 = (int)((num3 * 1647644042) ^ 0x39ADE7A);
				continue;
			case 4u:
				break;
			case 3u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 2051893203;
					num5 = 2051893203;
				}
				else
				{
					num4 = 351826605;
					num5 = 351826605;
				}
				num2 = num4 ^ ((int)num3 * -916783985);
				continue;
			}
			case 2u:
				result = null;
				num2 = ((int)num3 * -148002285) ^ -934222447;
				continue;
			case 1u:
				result = null;
				num2 = 1146039446;
				continue;
			case 5u:
				goto IL_0089;
			default:
				return result;
			}
			break;
		}
		goto IL_0019;
		IL_009a:
		flag = (byte)num != 0;
		num2 = 1377392087;
		goto IL_005c;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected I4, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
		//IL_0066: Incompatible stack heights: 0 vs 1
		//IL_006d: Incompatible stack heights: 0 vs 1
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1179431749;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x497EF815u) % 3u)
					{
					case 1u:
						goto IL_0004;
					case 0u:
						break;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_0004:
					result = null;
					num = ((int)num2 * -208555882) ^ 0x285132D0;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 61851631;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x497EF815;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						_ = ((int)num2 * -1832147755) ^ -127106498;
						continue;
					case 0:
						break;
					default:
						return null;
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
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0120:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -268117459;
					num2 = -268117459;
				}
				else
				{
					num = -1807346089;
					num2 = -1807346089;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xF209DFE4u) % 8u)
					{
					case 7u:
						flag = JSONClass.smethod_31(text) > 2;
						num = ((int)num3 * -2051853213) ^ 0x5FCC1A1C;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1344010910;
							num5 = -1344010910;
						}
						else
						{
							num4 = -693292524;
							num5 = -693292524;
						}
						num = num4 ^ ((int)num3 * -877800166);
						continue;
					}
					case 4u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)(num3 * 285883263) ^ -1110189718;
						continue;
					case 3u:
						current = enumerator.Current;
						num = -558202149;
						continue;
					case 2u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = -1353487502;
						continue;
					case 0u:
						num = -1807346089;
						continue;
					default:
						goto end_IL_00df;
					case 6u:
						break;
					case 1u:
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
		text = JSONClass.smethod_32(text, "}");
		string result = text;
		while (true)
		{
			int num6 = -264923192;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xF209DFE4u) % 3u)
				{
				case 1u:
					goto IL_014f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_014f:
				num6 = (int)((num3 * 1351752488) ^ 0x29330791);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0175:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 698121400;
					num2 = 698121400;
				}
				else
				{
					num = 570691318;
					num2 = 570691318;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x9BE4E4Bu) % 10u)
					{
					case 8u:
						flag = JSONClass.smethod_31(text) > 3;
						num = ((int)num3 * -1709605389) ^ -1453205317;
						continue;
					case 7u:
						current = enumerator.Current;
						num = 1564271652;
						continue;
					case 6u:
						num = (int)((num3 * 592305577) ^ 0x4E4F05AB);
						continue;
					case 5u:
						num = (int)(num3 * 353669547) ^ -866109590;
						continue;
					case 4u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1588642040) ^ -465960808;
						continue;
					case 3u:
						num = 570691318;
						continue;
					case 1u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = 1880970757;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -170694679;
							num5 = -170694679;
						}
						else
						{
							num4 = -1109623396;
							num5 = -1109623396;
						}
						num = num4 ^ (int)(num3 * 909623171);
						continue;
					}
					default:
						goto end_IL_012b;
					case 2u:
						break;
					case 9u:
						goto end_IL_012b;
					}
					goto IL_0175;
					continue;
					end_IL_012b:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num6 = 249264870;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x9BE4E4Bu) % 4u)
				{
				case 3u:
					num6 = ((int)num3 * -41392560) ^ 0x2B9049C9;
					continue;
				case 1u:
					result = text;
					num6 = ((int)num3 * -814296540) ^ 0x681402F4;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 1362574919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x338077B8u) % 6u)
				{
				case 5u:
					num = (int)((num2 * 1573956283) ^ 0x24E20229);
					continue;
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -361584684) ^ 0x4C830590;
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1694405883) ^ -474480957;
					continue;
				case 1u:
					num = ((int)num2 * -392459856) ^ -501619269;
					continue;
				case 0u:
					break;
				default:
				{
					using Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = 1282672667;
							num4 = 1282672667;
						}
						else
						{
							num3 = 1915103738;
							num4 = 1915103738;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x338077B8u) % 7u)
							{
							case 5u:
								current = enumerator.Current;
								num3 = 557242180;
								continue;
							case 4u:
								num3 = 1282672667;
								continue;
							case 3u:
								num3 = (int)((num2 * 2045169644) ^ 0x6E69713B);
								continue;
							case 2u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -483072563) ^ 0x4FE98676;
								continue;
							case 0u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1617449109) ^ 0x711C182D;
								continue;
							default:
								return;
							case 1u:
								break;
							case 6u:
								return;
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

	public JSONClass()
	{
		while (true)
		{
			int num = 341535374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D30EA93u) % 3u)
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
				num = (int)(num2 * 906783620) ^ -1612212923;
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
