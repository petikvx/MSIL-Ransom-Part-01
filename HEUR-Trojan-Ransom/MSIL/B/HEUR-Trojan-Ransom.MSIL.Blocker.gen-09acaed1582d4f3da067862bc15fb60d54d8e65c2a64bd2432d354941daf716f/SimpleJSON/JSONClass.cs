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
				int num = -1843799984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE062DF0Eu) % 5u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1858496364;
							num4 = 1858496364;
						}
						else
						{
							num3 = 1042970787;
							num4 = 1042970787;
						}
						num = num3 ^ ((int)num2 * -1515948084);
						continue;
					}
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = -78855848;
						continue;
					case 1u:
						result = m_Dict[aKey];
						num = ((int)num2 * -328922741) ^ -1704546769;
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
			while (true)
			{
				int num = 240421260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x65CFEB1Cu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1346578163) ^ -1343438749;
						continue;
					case 5u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -47761549) ^ 0x40A52A72;
						continue;
					case 4u:
						m_Dict.Add(aKey, value);
						num = 234153569;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (m_Dict.ContainsKey(aKey))
						{
							num3 = -1606906077;
							num4 = -1606906077;
						}
						else
						{
							num3 = -2074806700;
							num4 = -2074806700;
						}
						num = num3 ^ ((int)num2 * -2086154584);
						continue;
					}
					case 0u:
						num = ((int)num2 * -296718502) ^ -1099432746;
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
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
				int num = -1932602348;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xCEBEF169u) % 6u)
					{
					case 5u:
						result = null;
						num = -1089954978;
						continue;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = -841499316;
							num3 = -841499316;
							continue;
						}
						goto IL_0022;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -733916144) ^ 0x1B5F7103;
							continue;
						}
						goto IL_0022;
					case 0u:
						result = null;
						num = ((int)num2 * -170410598) ^ -1488742106;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0022:
						num = -1918697659;
						num3 = -1918697659;
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
				int num = 1868759412;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x66661D4Eu) % 6u)
					{
					case 4u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 41209082) ^ 0x35BE2739);
							continue;
						}
						num3 = 1;
						goto IL_001a;
					case 3u:
						num = (int)((num2 * 1551992213) ^ 0x69C9B60D);
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = -1262019860;
							num5 = -1262019860;
						}
						else
						{
							num4 = -778436581;
							num5 = -778436581;
						}
						num = num4 ^ (int)(num2 * 853272943);
						continue;
					}
					case 1u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
						IL_001a:
						flag = (byte)num3 != 0;
						num = 1858327442;
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
				int num = 1900123324;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x246FD639u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 685164443) ^ 0x7751A683);
						continue;
					case 1u:
						count = m_Dict.Count;
						num = (int)(num2 * 64215443) ^ -437688524;
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
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			while (true)
			{
				int num = 866129076;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5560216Cu) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -937935364) ^ -1958246766;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1684859398;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x529D949Fu) % 13u)
				{
				case 12u:
					num = (int)(num2 * 2099884860) ^ -697059358;
					continue;
				case 10u:
					flag = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -636819940) ^ 0x6F2E2D69;
					continue;
				case 9u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 766357645;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (m_Dict.ContainsKey(aKey))
					{
						num5 = 1805484194;
						num6 = 1805484194;
					}
					else
					{
						num5 = 814609425;
						num6 = 814609425;
					}
					num = num5 ^ (int)(num2 * 1766640140);
					continue;
				}
				case 7u:
					num = ((int)num2 * -546288959) ^ -926702069;
					continue;
				case 6u:
					num = (int)((num2 * 1820441172) ^ 0x307A3D43);
					continue;
				case 5u:
					m_Dict.Add(aKey, aItem);
					num = 723457934;
					continue;
				case 4u:
					num = 237990692;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2008009856;
						num4 = -2008009856;
					}
					else
					{
						num3 = -124907151;
						num4 = -124907151;
					}
					num = num3 ^ ((int)num2 * -1683057484);
					continue;
				}
				case 2u:
					num = (int)(num2 * 948471661) ^ -2078145611;
					continue;
				case 0u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 1616618976) ^ -77422838;
					continue;
				default:
					return;
				case 11u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1298448758;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D2732DBu) % 7u)
				{
				case 6u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = 672602099;
					continue;
				}
				case 5u:
					num = ((int)num2 * -451381126) ^ -208306248;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1144823718;
						num4 = 1144823718;
					}
					else
					{
						num3 = 610186296;
						num4 = 610186296;
					}
					num = num3 ^ (int)(num2 * 1293034074);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1972376177) ^ -1281377250;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -843043399) ^ -50636097;
					continue;
				case 4u:
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
			goto IL_0013;
		}
		int num = 1;
		goto IL_009a;
		IL_0089:
		num = ((aIndex >= m_Dict.Count) ? 1 : 0);
		goto IL_009a;
		IL_0013:
		int num2 = 1331033335;
		goto IL_005c;
		IL_005c:
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x5633DE02u) % 7u)
			{
			case 6u:
				result = null;
				num2 = 1919056087;
				continue;
			case 3u:
				break;
			case 2u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 830735868;
					num5 = 830735868;
				}
				else
				{
					num4 = 449180450;
					num5 = 449180450;
				}
				num2 = num4 ^ ((int)num3 * -824390171);
				continue;
			}
			case 1u:
				num2 = ((int)num3 * -305231274) ^ -117731107;
				continue;
			case 0u:
				result = null;
				num2 = (int)(num3 * 111972545) ^ -2145763378;
				continue;
			case 5u:
				goto IL_0089;
			default:
				return result;
			}
			break;
		}
		goto IL_0013;
		IL_009a:
		flag = (byte)num != 0;
		num2 = 750608485;
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
				int num = 1327981528;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x717499FEu) % 3u)
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
					num = ((int)num2 * -620610430) ^ -1218024500;
				}
			}
		}
		catch
		{
			while (true)
			{
				_ = 1916084441;
				while (true)
				{
					_003F val = /*Error near IL_0042: Stack underflow*/^ 0x717499FE;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = (num2 * 784140656) ^ 0x48C5313C;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		while (true)
		{
			int num = 30928016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBD8B7Du) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_016c:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 585020775;
								num4 = 585020775;
							}
							else
							{
								num3 = 371291895;
								num4 = 371291895;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xEBD8B7Du) % 9u)
								{
								case 8u:
									num3 = (int)((num2 * 1866820730) ^ 0x33A2070C);
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = 1225469251;
										num6 = 1225469251;
									}
									else
									{
										num5 = 1298417682;
										num6 = 1298417682;
									}
									num3 = num5 ^ (int)(num2 * 849427871);
									continue;
								}
								case 5u:
									num3 = ((int)num2 * -744148792) ^ 0x22D2DA3E;
									continue;
								case 4u:
									num3 = 585020775;
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = 784132895;
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
									num3 = 1748586906;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1274117329) ^ 0x4F7963C2;
									continue;
								default:
									goto end_IL_0126;
								case 1u:
									break;
								case 7u:
									goto end_IL_0126;
								}
								goto IL_016c;
								continue;
								end_IL_0126:
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
							IL_01b7:
							int num7 = 107099090;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xEBD8B7Du) % 3u)
								{
								case 2u:
									goto IL_018b;
								default:
									goto end_IL_0199;
								case 0u:
									break;
								case 1u:
									goto end_IL_0199;
								}
								goto IL_01b7;
								IL_018b:
								num7 = (int)((num2 * 1494262770) ^ 0x1FA010C5);
								continue;
								end_IL_0199:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					string result = text;
					while (true)
					{
						int num8 = 2116179865;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xEBD8B7Du) % 3u)
							{
							case 2u:
								goto IL_01d0;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01d0:
							num8 = (int)(num2 * 1765446030) ^ -391036213;
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{";
				num = (int)((num2 * 104998167) ^ 0x4A1C1F3A);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string result = default(string);
		while (true)
		{
			int num = -1594020981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAB6FAD0u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_018a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -370332333;
								num4 = -370332333;
							}
							else
							{
								num3 = -1910313198;
								num4 = -1910313198;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xEAB6FAD0u) % 9u)
								{
								case 8u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1128155035;
										num6 = 1128155035;
									}
									else
									{
										num5 = 2088985351;
										num6 = 2088985351;
									}
									num3 = num5 ^ (int)(num2 * 1169327981);
									continue;
								}
								case 6u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)(num2 * 1972800771) ^ -1739583534;
									continue;
								case 5u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = ((int)num2 * -1192275993) ^ -655752208;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -2063185824) ^ 0xE678C93;
									continue;
								case 3u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -1583481309;
									continue;
								case 2u:
									current = enumerator.Current;
									num3 = -1458030914;
									continue;
								case 0u:
									num3 = -370332333;
									continue;
								default:
									goto end_IL_0144;
								case 7u:
									break;
								case 1u:
									goto end_IL_0144;
								}
								goto IL_018a;
								continue;
								end_IL_0144:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = -589510099;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xEAB6FAD0u) % 4u)
							{
							case 3u:
								num7 = ((int)num2 * -1334399650) ^ -1715340422;
								continue;
							case 1u:
								result = text;
								num7 = (int)((num2 * 1864238860) ^ 0x2DE41EBB);
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
				IL_0008:
				num = ((int)num2 * -437657487) ^ -2029866422;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -493091581;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB91B4AB2u) % 6u)
				{
				case 5u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 394898863) ^ 0x13436BE2);
					continue;
				case 4u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1733719618) ^ -373592754;
					continue;
				case 3u:
					num = ((int)num2 * -757863363) ^ 0x49507B71;
					continue;
				case 0u:
					num = (int)((num2 * 1868519888) ^ 0xEEDC905);
					continue;
				case 2u:
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
							num3 = -62822488;
							num4 = -62822488;
						}
						else
						{
							num3 = -1537990401;
							num4 = -1537990401;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xB91B4AB2u) % 8u)
							{
							case 6u:
								num3 = -62822488;
								continue;
							case 4u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1636029849) ^ 0xE1C87B6);
								continue;
							case 3u:
								num3 = ((int)num2 * -496997146) ^ -1002914529;
								continue;
							case 2u:
								current = enumerator.Current;
								num3 = -1497256378;
								continue;
							case 1u:
								num3 = (int)(num2 * 1709136873) ^ -492803600;
								continue;
							case 0u:
								m_Dict[current].Serialize(aWriter);
								num3 = ((int)num2 * -2143255570) ^ -780225437;
								continue;
							default:
								return;
							case 7u:
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
