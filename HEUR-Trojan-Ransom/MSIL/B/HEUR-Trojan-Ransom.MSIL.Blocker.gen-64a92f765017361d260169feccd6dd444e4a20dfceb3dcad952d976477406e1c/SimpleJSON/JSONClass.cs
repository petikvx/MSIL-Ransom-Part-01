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
			if (m_Dict.ContainsKey(aKey))
			{
				goto IL_000e;
			}
			goto IL_0076;
			IL_0076:
			JSONNode result = new JSONLazyCreator(this, aKey);
			int num = -748363304;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9F02BB8u) % 6u)
				{
				case 5u:
					break;
				case 2u:
					num = ((int)num2 * -1715566054) ^ -1627094278;
					continue;
				case 1u:
					result = m_Dict[aKey];
					num = (int)((num2 * 602296668) ^ 0x1D195C0);
					continue;
				case 0u:
					num = ((int)num2 * -304224062) ^ -1085600350;
					continue;
				case 3u:
					goto IL_0076;
				default:
					return result;
				}
				break;
			}
			goto IL_000e;
			IL_000e:
			num = -2010577857;
			goto IL_004d;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -1275495312;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA76E0DBFu) % 9u)
					{
					case 8u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)((num2 * 588142321) ^ 0x6918B5ED);
						continue;
					case 7u:
						num = ((int)num2 * -1750664218) ^ -42562678;
						continue;
					case 6u:
						m_Dict.Add(aKey, value);
						num = -1292738712;
						continue;
					case 5u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1287150025) ^ 0x2EA54727;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -735647977;
							num4 = -735647977;
						}
						else
						{
							num3 = -1692403297;
							num4 = -1692403297;
						}
						num = num3 ^ ((int)num2 * -995683357);
						continue;
					}
					case 3u:
						num = (int)(num2 * 1499982988) ^ -1732488689;
						continue;
					case 0u:
						num = ((int)num2 * -1604982262) ^ 0x66D7F204;
						continue;
					default:
						return;
					case 2u:
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
				goto IL_004e;
			}
			int num = 1;
			goto IL_00ad;
			IL_009c:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_00ad;
			IL_004e:
			int num2 = -1255665966;
			goto IL_006b;
			IL_006b:
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xBEF0F104u) % 8u)
				{
				case 7u:
					num2 = (int)((num3 * 362495001) ^ 0x1309AC47);
					continue;
				case 5u:
					result = null;
					num2 = (int)((num3 * 1249764030) ^ 0x7152177D);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1415833017;
						num5 = 1415833017;
					}
					else
					{
						num4 = 1985426204;
						num5 = 1985426204;
					}
					num2 = num4 ^ ((int)num3 * -1972510936);
					continue;
				}
				case 2u:
					break;
				case 1u:
					num2 = (int)(num3 * 588120352) ^ -1796963248;
					continue;
				case 0u:
					result = null;
					num2 = -47936931;
					continue;
				case 6u:
					goto IL_009c;
				default:
					return result;
				}
				break;
			}
			goto IL_004e;
			IL_00ad:
			flag = (byte)num != 0;
			num2 = -566493921;
			goto IL_006b;
		}
		set
		{
			while (true)
			{
				int num = -649254314;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x89D96914u) % 5u)
					{
					case 2u:
						num = (int)((num2 * 226084713) ^ 0x2B25950B);
						continue;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -796513023) ^ -154057590;
							continue;
						}
						goto IL_0034;
					case 0u:
						if (aIndex < m_Dict.Count)
						{
							num = -62363654;
							num3 = -62363654;
							continue;
						}
						goto IL_0034;
					default:
						return;
					case 3u:
						break;
					case 4u:
						return;
						IL_0034:
						num = -407908515;
						num3 = -407908515;
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
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 1439881796;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x493A55BBu) % 3u)
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
					num = ((int)num2 * -202432763) ^ 0x6BE5B113;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -1446888067;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA00AA81Cu) % 12u)
				{
				case 11u:
				{
					int num5;
					int num6;
					if (m_Dict.ContainsKey(aKey))
					{
						num5 = 1142739153;
						num6 = 1142739153;
					}
					else
					{
						num5 = 574134323;
						num6 = 574134323;
					}
					num = num5 ^ ((int)num2 * -1046368769);
					continue;
				}
				case 8u:
					num = ((int)num2 * -2139784650) ^ -1334255722;
					continue;
				case 7u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1086793686;
					continue;
				case 6u:
					num = -846079580;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (JSONClass.smethod_30(aKey))
					{
						num3 = -1103553475;
						num4 = -1103553475;
					}
					else
					{
						num3 = -609647479;
						num4 = -609647479;
					}
					num = num3 ^ (int)(num2 * 1389630454);
					continue;
				}
				case 4u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1463199429) ^ 0x289EBC0D;
					continue;
				case 3u:
					num = ((int)num2 * -1893195283) ^ -1298932011;
					continue;
				case 2u:
					m_Dict.Add(aKey, aItem);
					num = -1947339909;
					continue;
				case 1u:
					num = (int)(num2 * 1909714860) ^ -421877804;
					continue;
				case 0u:
					num = (int)(num2 * 2105146414) ^ -219195590;
					continue;
				default:
					return;
				case 9u:
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
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 2108436599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BB44EB9u) % 9u)
				{
				case 8u:
					m_Dict.Remove(aKey);
					num = (int)((num2 * 1185665182) ^ 0x2C3F1971);
					continue;
				case 7u:
					jSONNode = m_Dict[aKey];
					num = 1365586624;
					continue;
				case 6u:
					num = (int)((num2 * 1095144616) ^ 0x3CDFF631);
					continue;
				case 4u:
					result = jSONNode;
					num = (int)((num2 * 1085358182) ^ 0x33D90EDF);
					continue;
				case 3u:
					flag = !m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 1756057767) ^ -791320163;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1717347918;
						num4 = -1717347918;
					}
					else
					{
						num3 = -791709966;
						num4 = -791709966;
					}
					num = num3 ^ ((int)num2 * -1121856648);
					continue;
				}
				case 1u:
					result = null;
					num = (int)(num2 * 1315414009) ^ -783819166;
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

	public override JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -925160311;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xF57F3EACu) % 7u)
				{
				case 6u:
					result = null;
					num = (int)((num2 * 1818987199) ^ 0xD198AA6);
					continue;
				case 4u:
					if (aIndex < m_Dict.Count)
					{
						num = -1852919021;
						num3 = -1852919021;
						continue;
					}
					goto IL_002a;
				case 2u:
					num = (int)(num2 * 1302884184) ^ -1170883792;
					continue;
				case 1u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1046180535) ^ 0x65ED87C5);
						continue;
					}
					goto IL_002a;
				case 0u:
					result = null;
					num = -921925744;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_002a:
					num = -187908250;
					num3 = -187908250;
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
		//IL_0032: Incompatible stack heights: 0 vs 1
		//IL_0039: Incompatible stack heights: 0 vs 1
		try
		{
			return null;
		}
		catch
		{
			while (true)
			{
				_ = -1115129414;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -1350420392;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = ((int)num * -120702220) ^ -993545162;
						continue;
					case 2:
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
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CGetEnumerator_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		string text = "{";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		while (true)
		{
			int num = -192524793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9D55883u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0155:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -436384738;
								num4 = -436384738;
							}
							else
							{
								num3 = -481828798;
								num4 = -481828798;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC9D55883u) % 8u)
								{
								case 7u:
									num3 = -481828798;
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
									num3 = -1193359464;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 743689027) ^ -707177407;
									continue;
								case 3u:
									num3 = (int)((num2 * 945734222) ^ 0x57DD4279);
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1011828813;
										num6 = 1011828813;
									}
									else
									{
										num5 = 657021639;
										num6 = 657021639;
									}
									num3 = num5 ^ (int)(num2 * 1612873456);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									flag = JSONClass.smethod_31(text) > 2;
									num3 = -1434539823;
									continue;
								default:
									goto end_IL_0114;
								case 0u:
									break;
								case 5u:
									goto end_IL_0114;
								}
								goto IL_0155;
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
						int num7 = -2046429524;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xC9D55883u) % 3u)
							{
							case 1u:
								goto IL_0184;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_0184:
							num7 = ((int)num2 * -1095260701) ^ 0x2B8BC5A6;
						}
					}
				}
				}
				break;
				IL_0008:
				num = ((int)num2 * -658400540) ^ 0x4DE7BA4D;
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
			int num = 1537208776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7DFC6Au) % 4u)
				{
				case 2u:
					text = "{ ";
					num = ((int)num2 * -611307127) ^ 0x4A0990D1;
					continue;
				case 1u:
					num = (int)(num2 * 1282920322) ^ -766097949;
					continue;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_01a5:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1990910659;
								num4 = 1990910659;
							}
							else
							{
								num3 = 605486381;
								num4 = 605486381;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD7DFC6Au) % 9u)
								{
								case 8u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 219377042;
										num6 = 219377042;
									}
									else
									{
										num5 = 1411908267;
										num6 = 1411908267;
									}
									num3 = num5 ^ ((int)num2 * -533911376);
									continue;
								}
								case 7u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = 737811089;
									continue;
								case 6u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -2080941141) ^ -10357533;
									continue;
								case 5u:
									num3 = 605486381;
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
									num3 = ((int)num2 * -1089850972) ^ -1880436375;
									continue;
								case 2u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 48802078) ^ 0x790B89CB);
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = 590511088;
									continue;
								default:
									goto end_IL_015f;
								case 4u:
									break;
								case 0u:
									goto end_IL_015f;
								}
								goto IL_01a5;
								continue;
								end_IL_015f:
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
			int num = -1807203846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE779494u) % 4u)
				{
				case 2u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 92656850) ^ -561921255;
					continue;
				case 1u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)(num2 * 883340135) ^ -2113877804;
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
							num3 = -384087623;
							num4 = -384087623;
						}
						else
						{
							num3 = -576423104;
							num4 = -576423104;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xEE779494u) % 7u)
							{
							case 6u:
								num3 = -576423104;
								continue;
							case 5u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)(num2 * 2016732163) ^ -1654217906;
								continue;
							case 3u:
								current = enumerator.Current;
								num3 = -1844009933;
								continue;
							case 1u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -339591548) ^ -596053877;
								continue;
							case 0u:
								num3 = (int)(num2 * 243265742) ^ -1380549725;
								continue;
							default:
								return;
							case 2u:
								break;
							case 4u:
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
