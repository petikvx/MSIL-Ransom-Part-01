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
			bool flag = default(bool);
			while (true)
			{
				int num = -1035571791;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB2E42069u) % 7u)
					{
					case 5u:
						num = ((int)num2 * -691108141) ^ 0x45C68A6F;
						continue;
					case 4u:
						result = m_Dict[aKey];
						num = ((int)num2 * -1081333385) ^ -2063427522;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1972318182;
							num4 = -1972318182;
						}
						else
						{
							num3 = -1646628561;
							num4 = -1646628561;
						}
						num = num3 ^ (int)(num2 * 398124116);
						continue;
					}
					case 1u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1387546395) ^ -1218578175;
						continue;
					case 0u:
						result = new JSONLazyCreator(this, aKey);
						num = -933353431;
						continue;
					case 6u:
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
				int num = -1630404157;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90994125u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 474593362) ^ 0x4A59D7AC);
						continue;
					case 3u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 342211233) ^ 0x248C4119);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -259903472;
							num4 = -259903472;
						}
						else
						{
							num3 = -2081852973;
							num4 = -2081852973;
						}
						num = num3 ^ ((int)num2 * -1143396718);
						continue;
					}
					case 0u:
						m_Dict.Add(aKey, value);
						num = -1340094666;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -41723942;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xAAB1C051u) % 7u)
					{
					case 6u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1492677333) ^ -557503043;
							continue;
						}
						goto IL_0028;
					case 5u:
						if (aIndex < m_Dict.Count)
						{
							num = -1834561038;
							num3 = -1834561038;
							continue;
						}
						goto IL_0028;
					case 4u:
						result = null;
						num = -1363144821;
						continue;
					case 2u:
						num = (int)((num2 * 1601247016) ^ 0x7F6B1CC3);
						continue;
					case 1u:
						result = null;
						num = (int)(num2 * 43169207) ^ -254552328;
						continue;
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_0028:
						num = -139944068;
						num3 = -139944068;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1419112517;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x30D2F959u) % 5u)
					{
					case 4u:
						num = (int)(num2 * 2110693021) ^ -155591346;
						continue;
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 47362189) ^ -637964402;
							continue;
						}
						goto IL_0028;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = 1503781487;
							num3 = 1503781487;
							continue;
						}
						goto IL_0028;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
						IL_0028:
						num = 289382412;
						num3 = 289382412;
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
			int count = m_Dict.Count;
			while (true)
			{
				int num = -633034902;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE8BA488u) % 3u)
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
					num = (int)(num2 * 1310665680) ^ -1214182006;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1616141248;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEAC7ABE2u) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 1304467982) ^ 0x5C901D9F);
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1958506856) ^ -337206771;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = !JSONClass.smethod_30(aKey);
		while (true)
		{
			int num = -991034458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x97716AD7u) % 11u)
				{
				case 9u:
					num = ((int)num2 * -761135376) ^ 0x2CE002CB;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -972641588;
						num6 = -972641588;
					}
					else
					{
						num5 = -2105952190;
						num6 = -2105952190;
					}
					num = num5 ^ (int)(num2 * 1134613773);
					continue;
				}
				case 7u:
					num = -472922687;
					continue;
				case 6u:
					num = ((int)num2 * -443138630) ^ -1471460724;
					continue;
				case 4u:
					m_Dict.Add(aKey, aItem);
					num = -765054821;
					continue;
				case 3u:
					num = (int)(num2 * 253871168) ^ -2082748658;
					continue;
				case 2u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -472922687;
					continue;
				case 1u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 1069859572) ^ -716963405;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (m_Dict.ContainsKey(aKey))
					{
						num3 = -920613240;
						num4 = -920613240;
					}
					else
					{
						num3 = -222208040;
						num4 = -222208040;
					}
					num = num3 ^ ((int)num2 * -1420533548);
					continue;
				}
				default:
					return;
				case 5u:
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
			int num = -236465729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA07D9245u) % 8u)
				{
				case 7u:
					result = jSONNode;
					num = ((int)num2 * -1366984536) ^ -1006945946;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 616859048;
						num4 = 616859048;
					}
					else
					{
						num3 = 1591690973;
						num4 = 1591690973;
					}
					num = num3 ^ ((int)num2 * -2094426118);
					continue;
				}
				case 4u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = -1756385494;
					continue;
				case 2u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1966194733) ^ -1022299255;
					continue;
				case 1u:
					result = null;
					num = (int)((num2 * 1374471025) ^ 0x58AE8B9C);
					continue;
				case 0u:
					num = (int)((num2 * 2089244973) ^ 0x792407D6);
					continue;
				case 5u:
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
			int num = 259456320;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x2BF709EAu) % 8u)
				{
				case 7u:
					if (aIndex < m_Dict.Count)
					{
						num = 56430326;
						num3 = 56430326;
						continue;
					}
					goto IL_0019;
				case 6u:
					num = ((int)num2 * -1790755926) ^ -1069472253;
					continue;
				case 4u:
					result = null;
					num = 765307436;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1326190661) ^ 0x3D03F023;
						continue;
					}
					goto IL_0019;
				case 1u:
					num = (int)((num2 * 1861576408) ^ 0xB3F627);
					continue;
				case 0u:
					result = null;
					num = ((int)num2 * -2111948074) ^ -379125893;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0019:
					num = 1008417626;
					num3 = 1008417626;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0034: Incompatible stack heights: 0 vs 1
		//IL_003b: Incompatible stack heights: 0 vs 1
		JSONNode result = default(JSONNode);
		try
		{
			result = null;
			return result;
		}
		catch
		{
			while (true)
			{
				_ = 76357733;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x732B0F90;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = (num * 63534296) ^ 0xF834B82Eu;
						continue;
					case 2:
						break;
					default:
						return result;
					case 0:
						return result;
					}
					break;
				}
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
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
				IL_010d:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -203174750;
					num2 = -203174750;
				}
				else
				{
					num = -956811637;
					num2 = -956811637;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x9C230C12u) % 7u)
					{
					case 6u:
						num = -203174750;
						continue;
					case 4u:
						current = enumerator.Current;
						num = -1164862135;
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
						num = -1928803551;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) > 2)
						{
							num4 = -130492702;
							num5 = -130492702;
						}
						else
						{
							num4 = -1717283092;
							num5 = -1717283092;
						}
						num = num4 ^ (int)(num3 * 1629544656);
						continue;
					}
					case 0u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)((num3 * 859981917) ^ 0x4E00181C);
						continue;
					default:
						goto end_IL_00d0;
					case 5u:
						break;
					case 3u:
						goto end_IL_00d0;
					}
					goto IL_010d;
					continue;
					end_IL_00d0:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num6 = -1440728666;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x9C230C12u) % 3u)
				{
				case 2u:
					goto IL_0139;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0139:
				result = text;
				num6 = (int)(num3 * 1220088006) ^ -1049655672;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_013b:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1063700555;
					num2 = 1063700555;
				}
				else
				{
					num = 879135209;
					num2 = 879135209;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x721AA5DAu) % 8u)
					{
					case 7u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1723279261) ^ -813066582;
						continue;
					case 5u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = 1754083438;
						continue;
					case 4u:
						num = ((int)num3 * -2097143004) ^ -319404028;
						continue;
					case 2u:
						num = 1063700555;
						continue;
					case 1u:
						current = enumerator.Current;
						num = 1700919914;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 3)
						{
							num4 = -2073252049;
							num5 = -2073252049;
						}
						else
						{
							num4 = -756367635;
							num5 = -756367635;
						}
						num = num4 ^ (int)(num3 * 2092734953);
						continue;
					}
					default:
						goto end_IL_00fa;
					case 6u:
						break;
					case 3u:
						goto end_IL_00fa;
					}
					goto IL_013b;
					continue;
					end_IL_00fa:
					break;
				}
				break;
			}
		}
		return JSONClass.smethod_35(text, "\n", aPrefix, "}");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -2073137084;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFE274C7u) % 4u)
				{
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -2086156727) ^ 0x29C0559A;
					continue;
				case 2u:
					num = ((int)num2 * -1823910999) ^ -1948166472;
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
						if (!enumerator.MoveNext())
						{
							num3 = -1928674087;
							num4 = -1928674087;
						}
						else
						{
							num3 = -1745780493;
							num4 = -1745780493;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xEFE274C7u) % 7u)
							{
							case 6u:
								num3 = ((int)num2 * -1524697747) ^ 0x736FDB05;
								continue;
							case 5u:
								num3 = -1745780493;
								continue;
							case 4u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -661428916) ^ 0x2101A6A3;
								continue;
							case 3u:
								current = enumerator.Current;
								num3 = -1576869940;
								continue;
							case 2u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1501586325) ^ -39689826;
								continue;
							default:
								return;
							case 0u:
								break;
							case 1u:
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
			int num = 1218264540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x340D3920u) % 3u)
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
				num = (int)(num2 * 1724133685) ^ -343751455;
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
