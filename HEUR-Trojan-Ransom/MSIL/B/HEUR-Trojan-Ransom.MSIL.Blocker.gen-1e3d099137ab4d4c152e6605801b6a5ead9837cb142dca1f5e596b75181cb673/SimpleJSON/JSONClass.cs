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
			bool flag = default(bool);
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 2140168249;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x359E4DBFu) % 8u)
					{
					case 6u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)((num2 * 1920770286) ^ 0x2188E637);
						continue;
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = 779115629;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1341562606;
							num4 = 1341562606;
						}
						else
						{
							num3 = 767855435;
							num4 = 767855435;
						}
						num = num3 ^ ((int)num2 * -713404527);
						continue;
					}
					case 2u:
						num = (int)(num2 * 1881182408) ^ -1158928884;
						continue;
					case 1u:
						num = ((int)num2 * -137689181) ^ -898325345;
						continue;
					case 0u:
						result = m_Dict[aKey];
						num = (int)((num2 * 925272092) ^ 0x5FDF9A7E);
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
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -1032037358;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFD7AAE8u) % 9u)
					{
					case 8u:
						num = (int)((num2 * 480101555) ^ 0x3D4AD99);
						continue;
					case 7u:
						num = ((int)num2 * -777214086) ^ -1474856685;
						continue;
					case 6u:
						m_Dict.Add(aKey, value);
						num = -606793477;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1149901642;
							num4 = -1149901642;
						}
						else
						{
							num3 = -1590124883;
							num4 = -1590124883;
						}
						num = num3 ^ ((int)num2 * -1455817749);
						continue;
					}
					case 3u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)((num2 * 137643786) ^ 0x712E67E7);
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 1539564876) ^ -469986638;
						continue;
					case 1u:
						num = ((int)num2 * -2079001548) ^ 0x59310DE1;
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
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = -2130496454;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xC2148AA8u) % 7u)
					{
					case 6u:
						result = null;
						num = -959553181;
						continue;
					case 5u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0020;
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1930098467) ^ -1606045559;
							continue;
						}
						num5 = 1;
						goto IL_0020;
					case 2u:
						result = null;
						num = (int)(num2 * 85624504) ^ -1221773197;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1978099386;
							num4 = -1978099386;
						}
						else
						{
							num3 = -1522949915;
							num4 = -1522949915;
						}
						num = num3 ^ (int)(num2 * 1561213320);
						continue;
					}
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0020:
						flag = (byte)num5 != 0;
						num = -829840224;
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
				goto IL_002b;
			}
			int num = 1;
			goto IL_0075;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
			IL_002b:
			int num2 = 177209414;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x178AED7Du) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1507358651;
						num5 = -1507358651;
					}
					else
					{
						num4 = -1780782382;
						num5 = -1780782382;
					}
					num2 = num4 ^ ((int)num3 * -379340271);
					continue;
				}
				case 3u:
					break;
				case 0u:
					num2 = ((int)num3 * -1756528757) ^ 0x5C46767E;
					continue;
				default:
					return;
				case 1u:
					goto IL_0064;
				case 2u:
					return;
				}
				break;
			}
			goto IL_002b;
			IL_0075:
			flag = (byte)num != 0;
			num2 = 1265703255;
			goto IL_003f;
		}
	}

	public override int Count => m_Dict.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1712004491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6E530A2u) % 13u)
				{
				case 12u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -394072411) ^ 0xC130408;
					continue;
				case 11u:
					num = -1079918169;
					continue;
				case 9u:
					num = ((int)num2 * -1020625494) ^ 0x3FCD0345;
					continue;
				case 8u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 1685397181) ^ -1469805998;
					continue;
				case 7u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -948777329;
					continue;
				case 6u:
					num = ((int)num2 * -913274050) ^ 0x102D4393;
					continue;
				case 5u:
					num = (int)(num2 * 193245821) ^ -1376093432;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1740561211;
						num6 = -1740561211;
					}
					else
					{
						num5 = -997457263;
						num6 = -997457263;
					}
					num = num5 ^ (int)(num2 * 295289348);
					continue;
				}
				case 2u:
					m_Dict.Add(aKey, aItem);
					num = -1813035135;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1803361626;
						num4 = -1803361626;
					}
					else
					{
						num3 = -239161513;
						num4 = -239161513;
					}
					num = num3 ^ (int)(num2 * 1668699965);
					continue;
				}
				case 0u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 1049316557) ^ 0x5F8D4304);
					continue;
				default:
					return;
				case 3u:
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
		while (true)
		{
			int num = -1731989885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF02B86F2u) % 8u)
				{
				case 7u:
					result = null;
					num = ((int)num2 * -9307611) ^ -1962389492;
					continue;
				case 6u:
					jSONNode = m_Dict[aKey];
					num = -613121994;
					continue;
				case 4u:
					m_Dict.Remove(aKey);
					num = ((int)num2 * -2005450663) ^ -773536026;
					continue;
				case 3u:
					num = ((int)num2 * -479491656) ^ 0xF290EA7;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 57505655;
						num4 = 57505655;
					}
					else
					{
						num3 = 801826046;
						num4 = 801826046;
					}
					num = num3 ^ (int)(num2 * 331648994);
					continue;
				}
				case 0u:
					result = jSONNode;
					num = ((int)num2 * -79920000) ^ 0x1AEBC0D9;
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
		bool flag = default(bool);
		while (true)
		{
			int num = -1353493267;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE5B74581u) % 8u)
				{
				case 6u:
					result = null;
					num = -200813119;
					continue;
				case 5u:
					result = null;
					num = ((int)num2 * -785868733) ^ 0x50BBB5BF;
					continue;
				case 4u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 225964999) ^ -1741067529;
						continue;
					}
					num3 = 1;
					goto IL_0034;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 149122707;
						num5 = 149122707;
					}
					else
					{
						num4 = 957302976;
						num5 = 957302976;
					}
					num = num4 ^ (int)(num2 * 1490852916);
					continue;
				}
				case 2u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0034;
				case 1u:
					num = ((int)num2 * -1773774448) ^ 0x721C0DD1;
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_0034:
					flag = (byte)num3 != 0;
					num = -1324697902;
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
				int num = 1785654938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x673F1C6Du) % 3u)
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
					num = (int)((num2 * 122521292) ^ 0x9CC31B5);
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 1452438665;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x673F1C6D;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						result = null;
						_ = ((int)num2 * -754486600) ^ -1944962783;
						continue;
					case 0:
						break;
					default:
						return result;
					case 1:
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
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_0138:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -602789357;
					num2 = -602789357;
				}
				else
				{
					num = -788086774;
					num2 = -788086774;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xE50F60A0u) % 9u)
					{
					case 8u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 311481536;
							num5 = 311481536;
						}
						else
						{
							num4 = 1722440147;
							num5 = 1722440147;
						}
						num = num4 ^ (int)(num3 * 1667721142);
						continue;
					}
					case 6u:
						current = enumerator.Current;
						num = -545015489;
						continue;
					case 5u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = -1450403657;
						continue;
					case 4u:
						flag = JSONClass.smethod_31(text) > 2;
						num = (int)((num3 * 366442011) ^ 0x92EA98B);
						continue;
					case 3u:
						num = -602789357;
						continue;
					case 1u:
						num = (int)((num3 * 412282671) ^ 0x2DEC8DF3);
						continue;
					case 0u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)((num3 * 661312847) ^ 0x4FD3591D);
						continue;
					default:
						goto end_IL_00f2;
					case 2u:
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
		text = JSONClass.smethod_32(text, "}");
		string result = text;
		while (true)
		{
			int num6 = -1515067283;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0xE50F60A0u) % 3u)
				{
				case 1u:
					goto IL_0167;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0167:
				num6 = ((int)num3 * -1092593784) ^ 0x2006A8C5;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = default(string);
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -1133392486;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x982B697Bu) % 4u)
				{
				case 1u:
					text = "{ ";
					num = ((int)num2 * -585961543) ^ 0x75CF5AB2;
					continue;
				case 0u:
					num = ((int)num2 * -1431781047) ^ 0x72EC928C;
					continue;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_019f:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -368648366;
								num4 = -368648366;
							}
							else
							{
								num3 = -2146176975;
								num4 = -2146176975;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x982B697Bu) % 9u)
								{
								case 8u:
									num3 = -368648366;
									continue;
								case 6u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)((num2 * 10998113) ^ 0x4437FA77);
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
									num3 = -165881980;
									continue;
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -19956292) ^ -1462350687;
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -166292681;
										num6 = -166292681;
									}
									else
									{
										num5 = -585647966;
										num6 = -585647966;
									}
									num3 = num5 ^ (int)(num2 * 2112444370);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = -1828064703;
									continue;
								case 0u:
									num3 = ((int)num2 * -1344431608) ^ 0x2364DDBE;
									continue;
								default:
									goto end_IL_0159;
								case 7u:
									break;
								case 4u:
									goto end_IL_0159;
								}
								goto IL_019f;
								continue;
								end_IL_0159:
								break;
							}
							break;
						}
					}
					return JSONClass.smethod_35(text, "\n", aPrefix, "}");
				}
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
			int num = 420396732;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x411D78E1u) % 5u)
				{
				case 4u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1349648000) ^ -1152745494;
					continue;
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -619336727) ^ 0x5C46D105;
					continue;
				case 2u:
					num = ((int)num2 * -262623510) ^ -799006788;
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
							num3 = 2039025217;
							num4 = 2039025217;
						}
						else
						{
							num3 = 2002922483;
							num4 = 2002922483;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x411D78E1u) % 9u)
							{
							case 8u:
								num3 = 2002922483;
								continue;
							case 7u:
								num3 = ((int)num2 * -1019599617) ^ 0x1DADFD08;
								continue;
							case 6u:
								current = enumerator.Current;
								num3 = 1259220209;
								continue;
							case 3u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -1555434206) ^ 0x7BAD6721;
								continue;
							case 2u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -417229631) ^ 0x1377C69F;
								continue;
							case 1u:
								num3 = (int)((num2 * 274946098) ^ 0x6C79D2F1);
								continue;
							case 0u:
								num3 = ((int)num2 * -1167408238) ^ -39400634;
								continue;
							default:
								return;
							case 4u:
								break;
							case 5u:
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
