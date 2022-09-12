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
				int num = -512648022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE341407Bu) % 6u)
					{
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)((num2 * 1207363987) ^ 0x73B2788E);
						continue;
					case 4u:
						result = m_Dict[aKey];
						num = (int)((num2 * 568215930) ^ 0x40220684);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = -1086254132;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -706419137;
							num4 = -706419137;
						}
						else
						{
							num3 = -1777887909;
							num4 = -1777887909;
						}
						num = num3 ^ ((int)num2 * -386340258);
						continue;
					}
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
				int num = 383932650;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2517DB63u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 37936849) ^ -45535730;
						continue;
					case 6u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1015254936) ^ -628665773;
						continue;
					case 5u:
						num = ((int)num2 * -991116118) ^ 0x7EB5A9FB;
						continue;
					case 4u:
						m_Dict.Add(aKey, value);
						num = 1696731604;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1745324425;
							num4 = 1745324425;
						}
						else
						{
							num3 = 940350019;
							num4 = 940350019;
						}
						num = num3 ^ ((int)num2 * -322443338);
						continue;
					}
					case 0u:
						num = (int)((num2 * 1616832472) ^ 0x6D95A446);
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
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = 808821950;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x7B5EC913u) % 8u)
					{
					case 6u:
						result = null;
						num = ((int)num2 * -1428718775) ^ -1646359196;
						continue;
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1369044949) ^ -1266138042;
							continue;
						}
						num5 = 1;
						goto IL_002b;
					case 4u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_002b;
					case 2u:
						result = null;
						num = 1063001132;
						continue;
					case 1u:
						num = (int)(num2 * 260776163) ^ -1743444305;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 414716317;
							num4 = 414716317;
						}
						else
						{
							num3 = 1215403033;
							num4 = 1215403033;
						}
						num = num3 ^ ((int)num2 * -774079777);
						continue;
					}
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_002b:
						flag = (byte)num5 != 0;
						num = 1467274123;
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
				int num = -756828449;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x815ADF2Au) % 6u)
					{
					case 3u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1779172765) ^ -808409743;
							continue;
						}
						num5 = 1;
						goto IL_001a;
					case 2u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 968579751;
							num4 = 968579751;
						}
						else
						{
							num3 = 1933022924;
							num4 = 1933022924;
						}
						num = num3 ^ ((int)num2 * -371781962);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1299864900) ^ -1424345783;
						continue;
					default:
						return;
					case 4u:
						break;
					case 5u:
						return;
						IL_001a:
						flag = (byte)num5 != 0;
						num = -1231576017;
						continue;
					}
					break;
				}
			}
		}
	}

	public override int Count => m_Dict.Count;

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
		if (!JSONClass.smethod_30(aKey))
		{
			goto IL_000e;
		}
		goto IL_0111;
		IL_0111:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = -951042729;
		goto IL_00cf;
		IL_00cf:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xCDBB2072u) % 12u)
			{
			case 11u:
				break;
			case 10u:
				flag = m_Dict.ContainsKey(aKey);
				num = ((int)num2 * -788860887) ^ 0x4194BAF0;
				continue;
			case 9u:
				num = (int)(num2 * 1074217339) ^ -114532319;
				continue;
			case 8u:
				m_Dict[aKey] = aItem;
				num = ((int)num2 * -480285123) ^ -1176144153;
				continue;
			case 5u:
				num = (int)((num2 * 2000047330) ^ 0x3160159F);
				continue;
			case 4u:
				num = -237094508;
				continue;
			case 3u:
				num = (int)((num2 * 1224527253) ^ 0x776E6C79);
				continue;
			case 2u:
				num = (int)((num2 * 1661236481) ^ 0x32B794D3);
				continue;
			case 1u:
				m_Dict.Add(aKey, aItem);
				num = -933171143;
				continue;
			case 0u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = -1668180598;
					num4 = -1668180598;
				}
				else
				{
					num3 = -1006642189;
					num4 = -1006642189;
				}
				num = num3 ^ (int)(num2 * 2109292523);
				continue;
			}
			default:
				return;
			case 6u:
				goto IL_0111;
			case 7u:
				return;
			}
			break;
		}
		goto IL_000e;
		IL_000e:
		num = -1198176000;
		goto IL_00cf;
	}

	public override JSONNode Remove(string aKey)
	{
		if (!m_Dict.ContainsKey(aKey))
		{
			goto IL_0051;
		}
		goto IL_007f;
		IL_007f:
		JSONNode jSONNode = m_Dict[aKey];
		int num = -1461461246;
		goto IL_0056;
		IL_0056:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xCEAB3805u) % 6u)
			{
			case 5u:
				num = (int)((num2 * 2037739848) ^ 0x56578B5C);
				continue;
			case 4u:
				result = null;
				num = (int)(num2 * 40689562) ^ -1986095140;
				continue;
			case 1u:
				m_Dict.Remove(aKey);
				result = jSONNode;
				num = ((int)num2 * -775648196) ^ -57500328;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_007f;
			default:
				return result;
			}
			break;
		}
		goto IL_0051;
		IL_0051:
		num = -1203602223;
		goto IL_0056;
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex < 0)
		{
			goto IL_000a;
		}
		goto IL_0017;
		IL_0017:
		int num = -482218022;
		goto IL_0045;
		IL_0045:
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8A5E4CBFu) % 6u)
			{
			case 5u:
				break;
			case 4u:
				result = null;
				num = (int)((num2 * 228099856) ^ 0x29B9C76F);
				continue;
			case 3u:
				result = null;
				num = -1420345749;
				continue;
			case 2u:
				num = (int)((num2 * 364802822) ^ 0x47531717);
				continue;
			case 1u:
				goto IL_006e;
			default:
				return result;
			}
			break;
			IL_006e:
			if (aIndex < m_Dict.Count)
			{
				num = -467741202;
				num3 = -467741202;
				continue;
			}
			goto IL_000a;
		}
		goto IL_0017;
		IL_000a:
		num = -412116745;
		num3 = -412116745;
		goto IL_0045;
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
				int num = 1399214475;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x418260BBu) % 3u)
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
					num = (int)((num2 * 1580266158) ^ 0x420BD1F1);
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 1648605264;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x418260BB;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num2 * -993379544) ^ 0x611D5CA7;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		while (true)
		{
			int num = -621328533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAEC7392u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1531389354) ^ 0x8B12199;
					continue;
				case 1u:
					text = "{";
					num = ((int)num2 * -253334413) ^ 0x53C26BF3;
					continue;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0151:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1487149543;
								num4 = -1487149543;
							}
							else
							{
								num3 = -307393442;
								num4 = -307393442;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xAAEC7392u) % 7u)
								{
								case 6u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\":",
										JSONClass.smethod_33((object)current.Value)
									});
									num3 = -278074820;
									continue;
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -605381743) ^ -254505516;
									continue;
								case 2u:
									num3 = -1487149543;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -617236536;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = 997393172;
										num6 = 997393172;
									}
									else
									{
										num5 = 1337299346;
										num6 = 1337299346;
									}
									num3 = num5 ^ (int)(num2 * 1421141357);
									continue;
								}
								default:
									goto end_IL_0114;
								case 5u:
									break;
								case 4u:
									goto end_IL_0114;
								}
								goto IL_0151;
								continue;
								end_IL_0114:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num7 = -1475619033;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xAAEC7392u) % 3u)
							{
							case 2u:
								goto IL_0180;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0180:
							num7 = ((int)num2 * -238841506) ^ -1567971305;
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
		string text = "{ ";
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			bool flag = default(bool);
			while (true)
			{
				IL_0158:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 2022098740;
					num2 = 2022098740;
				}
				else
				{
					num = 1530880136;
					num2 = 1530880136;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x7B12172u) % 9u)
					{
					case 8u:
						current = enumerator.Current;
						num = 2075464633;
						continue;
					case 6u:
						flag = JSONClass.smethod_31(text) > 3;
						num = ((int)num3 * -413558668) ^ -1459266774;
						continue;
					case 5u:
						text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
						num = 2102258880;
						continue;
					case 4u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\" : ",
							current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
						});
						num = (int)((num3 * 314460443) ^ 0x16BCC2B6);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = -1649413315;
							num5 = -1649413315;
						}
						else
						{
							num4 = -1080191390;
							num5 = -1080191390;
						}
						num = num4 ^ ((int)num3 * -415754379);
						continue;
					}
					case 1u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1782910189) ^ -177294217;
						continue;
					case 0u:
						num = 2022098740;
						continue;
					default:
						goto end_IL_0112;
					case 7u:
						break;
					case 3u:
						goto end_IL_0112;
					}
					goto IL_0158;
					continue;
					end_IL_0112:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num6 = 1289179665;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x7B12172u) % 3u)
				{
				case 1u:
					goto IL_018a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_018a:
				result = text;
				num6 = (int)(num3 * 519313494) ^ -1450857676;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -1041663910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6F58045u) % 3u)
				{
				case 2u:
					goto IL_0003;
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
							num3 = -1761141716;
							num4 = -1761141716;
						}
						else
						{
							num3 = -979033877;
							num4 = -979033877;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xA6F58045u) % 8u)
							{
							case 5u:
								num3 = ((int)num2 * -1702562848) ^ 0x51FE9855;
								continue;
							case 4u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -464079015) ^ 0xBC1CFF2;
								continue;
							case 3u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -1122673091) ^ 0x6ECF4907;
								continue;
							case 2u:
								num3 = -1761141716;
								continue;
							case 1u:
								current = enumerator.Current;
								num3 = -513804863;
								continue;
							case 0u:
								num3 = ((int)num2 * -1488407343) ^ -310739358;
								continue;
							default:
								return;
							case 7u:
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
				IL_0003:
				JSONClass.smethod_36(aWriter, (byte)2);
				JSONClass.smethod_37(aWriter, m_Dict.Count);
				num = (int)((num2 * 1354045849) ^ 0x47385D51);
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
