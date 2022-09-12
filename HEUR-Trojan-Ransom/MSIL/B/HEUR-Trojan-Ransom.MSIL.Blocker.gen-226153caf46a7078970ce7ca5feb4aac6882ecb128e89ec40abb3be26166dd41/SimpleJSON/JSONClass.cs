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
			bool flag = m_Dict.ContainsKey(aKey);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1424422179;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB33404CCu) % 6u)
					{
					case 5u:
						num = (int)(num2 * 586676569) ^ -1390200557;
						continue;
					case 4u:
						result = m_Dict[aKey];
						num = ((int)num2 * -803896417) ^ 0x23B01E4D;
						continue;
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = -467726916;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -966733528;
							num4 = -966733528;
						}
						else
						{
							num3 = -714336205;
							num4 = -714336205;
						}
						num = num3 ^ ((int)num2 * -2135580738);
						continue;
					}
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
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_000e;
			}
			goto IL_0076;
			IL_0076:
			m_Dict.Add(aKey, value);
			int num = 629256155;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79CBD1FBu) % 6u)
				{
				case 5u:
					break;
				case 3u:
					num = ((int)num2 * -1141181059) ^ -1659377956;
					continue;
				case 2u:
					m_Dict[aKey] = value;
					num = ((int)num2 * -1698868632) ^ -2107093536;
					continue;
				case 0u:
					num = (int)((num2 * 169806688) ^ 0x4ECE2343);
					continue;
				default:
					return;
				case 1u:
					goto IL_0076;
				case 4u:
					return;
				}
				break;
			}
			goto IL_000e;
			IL_000e:
			num = 1452256905;
			goto IL_004d;
		}
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = 688376739;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4F21FAF7u) % 8u)
					{
					case 6u:
						num = (int)((num2 * 1061346835) ^ 0x777AB8F2);
						continue;
					case 5u:
						result = null;
						num = 586116872;
						continue;
					case 4u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -594936967) ^ 0x37FE8D53;
							continue;
						}
						num3 = 1;
						goto IL_0032;
					case 3u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1300830890;
							num5 = -1300830890;
						}
						else
						{
							num4 = -1472485622;
							num5 = -1472485622;
						}
						num = num4 ^ (int)(num2 * 24397764);
						continue;
					}
					case 1u:
						result = null;
						num = (int)((num2 * 716877339) ^ 0x1B405B82);
						continue;
					case 0u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0032;
					case 2u:
						break;
					default:
						{
							return result;
						}
						IL_0032:
						flag = (byte)num3 != 0;
						num = 1009275284;
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
				int num = -1791700272;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x8BBD6C85u) % 6u)
					{
					case 5u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0017;
					case 3u:
						num = ((int)num2 * -376249847) ^ -328718260;
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 300318890) ^ 0x3F8C61A);
							continue;
						}
						num5 = 1;
						goto IL_0017;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2142286078;
							num4 = -2142286078;
						}
						else
						{
							num3 = -1982237741;
							num4 = -1982237741;
						}
						num = num3 ^ ((int)num2 * -670004133);
						continue;
					}
					default:
						return;
					case 4u:
						break;
					case 2u:
						return;
						IL_0017:
						flag = (byte)num5 != 0;
						num = -134441463;
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
				int num = 1715042997;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x470A419u) % 3u)
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
					count = m_Dict.Count;
					num = ((int)num2 * -1199002135) ^ 0x2526CB25;
				}
			}
		}
	}

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 931425611;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C0C8FA2u) % 11u)
				{
				case 9u:
					num = 1786371597;
					continue;
				case 8u:
					num = ((int)num2 * -2023479316) ^ -1111446894;
					continue;
				case 7u:
					num = ((int)num2 * -1428545027) ^ -468103945;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (!m_Dict.ContainsKey(aKey))
					{
						num5 = 1427671884;
						num6 = 1427671884;
					}
					else
					{
						num5 = 2132117384;
						num6 = 2132117384;
					}
					num = num5 ^ ((int)num2 * -681046983);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (JSONClass.smethod_30(aKey))
					{
						num3 = -140232087;
						num4 = -140232087;
					}
					else
					{
						num3 = -192708096;
						num4 = -192708096;
					}
					num = num3 ^ (int)(num2 * 2006291274);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1137596235) ^ -320576736;
					continue;
				case 2u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1248834720;
					continue;
				case 1u:
					m_Dict.Add(aKey, aItem);
					num = 1108456104;
					continue;
				case 0u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 540168106) ^ -817656765;
					continue;
				default:
					return;
				case 10u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		if (!m_Dict.ContainsKey(aKey))
		{
			goto IL_0014;
		}
		goto IL_00a6;
		IL_00a6:
		JSONNode jSONNode = m_Dict[aKey];
		int num = -866282161;
		goto IL_0075;
		IL_0075:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF8A4675Du) % 8u)
			{
			case 7u:
				break;
			case 5u:
				num = (int)(num2 * 53435031) ^ -1385438619;
				continue;
			case 4u:
				result = jSONNode;
				num = (int)((num2 * 479704120) ^ 0x6EC1FD50);
				continue;
			case 2u:
				m_Dict.Remove(aKey);
				num = ((int)num2 * -1737156257) ^ -643900929;
				continue;
			case 1u:
				result = null;
				num = ((int)num2 * -1484494304) ^ 0x6050FE55;
				continue;
			case 0u:
				num = (int)(num2 * 1744077448) ^ -760586450;
				continue;
			case 6u:
				goto IL_00a6;
			default:
				return result;
			}
			break;
		}
		goto IL_0014;
		IL_0014:
		num = -1993816788;
		goto IL_0075;
	}

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1797419599;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF7311D5Du) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -567354893;
						num5 = -567354893;
					}
					else
					{
						num4 = -1862977759;
						num5 = -1862977759;
					}
					num = num4 ^ (int)(num2 * 1278542091);
					continue;
				}
				case 6u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_003b;
				case 4u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -2004785791) ^ -1860569041;
						continue;
					}
					num3 = 1;
					goto IL_003b;
				case 3u:
					result = null;
					num = -1660290875;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -1396608933) ^ -902711621;
					continue;
				case 0u:
					num = (int)((num2 * 956752855) ^ 0x503360);
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_003b:
					flag = (byte)num3 != 0;
					num = -642773406;
					continue;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 880262844;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25FD1906u) % 3u)
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
					num = (int)((num2 * 811614412) ^ 0x78E21B23);
				}
			}
		}
		catch
		{
			return null;
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
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0138:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1972918585;
					num2 = -1972918585;
				}
				else
				{
					num = -1681022964;
					num2 = -1681022964;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE7A3F743u) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1367845691;
							num5 = -1367845691;
						}
						else
						{
							num4 = -958460298;
							num5 = -958460298;
						}
						num = num4 ^ ((int)num3 * -1708467057);
						continue;
					}
					case 7u:
						current = enumerator.Current;
						num = -1543648784;
						continue;
					case 6u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = -389449769;
						continue;
					case 5u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1172788710) ^ -423179078;
						continue;
					case 3u:
						flag = JSONClass.smethod_31(text) > 2;
						num = ((int)num3 * -416037235) ^ -711717837;
						continue;
					case 1u:
						num = (int)((num3 * 1446020134) ^ 0x66BADF71);
						continue;
					case 0u:
						num = -1681022964;
						continue;
					default:
						goto end_IL_00f2;
					case 4u:
						break;
					case 2u:
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
		return JSONClass.smethod_32(text, "}");
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_016c:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1241508391;
					num2 = -1241508391;
				}
				else
				{
					num = -1675140804;
					num2 = -1675140804;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x871E04A2u) % 10u)
					{
					case 9u:
						current = enumerator.Current;
						num = -189814934;
						continue;
					case 7u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = (int)(num3 * 1563605237) ^ -911031539;
						continue;
					case 6u:
						num = -1241508391;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -113525097;
							num5 = -113525097;
						}
						else
						{
							num4 = -1074199936;
							num5 = -1074199936;
						}
						num = num4 ^ ((int)num3 * -1595866689);
						continue;
					}
					case 4u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1865101391) ^ 0x627B6035;
						continue;
					case 2u:
						num = ((int)num3 * -890045038) ^ -989233661;
						continue;
					case 1u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						num = -1433274343;
						continue;
					case 0u:
						flag = JSONClass.smethod_31(text) > 3;
						num = (int)(num3 * 461026524) ^ -746105007;
						continue;
					default:
						goto end_IL_0122;
					case 3u:
						break;
					case 8u:
						goto end_IL_0122;
					}
					goto IL_016c;
					continue;
					end_IL_0122:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num6 = -535939233;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x871E04A2u) % 4u)
				{
				case 2u:
					num6 = (int)(num3 * 1918793920) ^ -1427429727;
					continue;
				case 1u:
					result = text;
					num6 = (int)(num3 * 516803751) ^ -1240221989;
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
			int num = -814488187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x918807FEu) % 4u)
				{
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -230000139) ^ 0x7F3B938F;
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -518611454) ^ -1808741681;
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
							num3 = -1780344805;
							num4 = -1780344805;
						}
						else
						{
							num3 = -1052691075;
							num4 = -1052691075;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x918807FEu) % 7u)
							{
							case 6u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -2117960056) ^ -985770383;
								continue;
							case 5u:
								num3 = ((int)num2 * -1133198160) ^ 0x5744B991;
								continue;
							case 3u:
								num3 = -1052691075;
								continue;
							case 1u:
								current = enumerator.Current;
								JSONClass.smethod_38(aWriter, current);
								num3 = -315050287;
								continue;
							case 0u:
								num3 = (int)((num2 * 519595900) ^ 0x79D24AD3);
								continue;
							default:
								return;
							case 4u:
								break;
							case 2u:
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
			int num = -993552500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA95BD7Au) % 3u)
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
				num = ((int)num2 * -1447344781) ^ 0x70317525;
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
