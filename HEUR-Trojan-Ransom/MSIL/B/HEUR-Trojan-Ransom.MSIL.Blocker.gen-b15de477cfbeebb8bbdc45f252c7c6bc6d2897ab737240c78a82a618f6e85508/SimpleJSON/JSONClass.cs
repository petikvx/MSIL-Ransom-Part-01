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
				int num = -1651419189;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D874A60u) % 6u)
					{
					case 5u:
						result = m_Dict[aKey];
						num = (int)((num2 * 382889272) ^ 0x7023D0D9);
						continue;
					case 4u:
						result = new JSONLazyCreator(this, aKey);
						num = -1937835202;
						continue;
					case 3u:
						num = ((int)num2 * -1097037234) ^ -2114831664;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!m_Dict.ContainsKey(aKey))
						{
							num3 = -497285700;
							num4 = -497285700;
						}
						else
						{
							num3 = -318466521;
							num4 = -318466521;
						}
						num = num3 ^ ((int)num2 * -470609008);
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = 1395405989;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B0BF6D8u) % 7u)
					{
					case 5u:
						num = ((int)num2 * -1378448455) ^ -2089636591;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 38781264;
							num4 = 38781264;
						}
						else
						{
							num3 = 473751713;
							num4 = 473751713;
						}
						num = num3 ^ ((int)num2 * -462160251);
						continue;
					}
					case 3u:
						num = ((int)num2 * -1634445038) ^ -1381956057;
						continue;
					case 1u:
						m_Dict.Add(aKey, value);
						num = 337901542;
						continue;
					case 0u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 889143134) ^ -1232429900;
						continue;
					default:
						return;
					case 6u:
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
			if (aIndex >= 0)
			{
				goto IL_0019;
			}
			int num = 1;
			goto IL_009a;
			IL_009a:
			bool flag = (byte)num != 0;
			int num2 = -630589616;
			goto IL_005c;
			IL_0019:
			num2 = -1776317196;
			goto IL_005c;
			IL_005c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xEE34C3D3u) % 7u)
				{
				case 6u:
					num2 = ((int)num3 * -1436249266) ^ -1938583977;
					continue;
				case 4u:
					break;
				case 3u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 352218876;
						num5 = 352218876;
					}
					else
					{
						num4 = 1536970211;
						num5 = 1536970211;
					}
					num2 = num4 ^ ((int)num3 * -1427015316);
					continue;
				}
				case 2u:
					result = null;
					num2 = -1569044135;
					continue;
				case 0u:
					result = null;
					num2 = (int)((num3 * 1006800231) ^ 0x6EA1065E);
					continue;
				case 1u:
					goto IL_0089;
				default:
					return result;
				}
				break;
			}
			goto IL_0019;
			IL_0089:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_009a;
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
			int num2 = 678859248;
			goto IL_003f;
			IL_003f:
			bool flag = default(bool);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x3161766Eu) % 5u)
				{
				case 4u:
					break;
				case 3u:
					num2 = ((int)num3 * -1612397029) ^ -1415633087;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 731292793;
						num5 = 731292793;
					}
					else
					{
						num4 = 117521758;
						num5 = 117521758;
					}
					num2 = num4 ^ ((int)num3 * -982703787);
					continue;
				}
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
			num2 = 559692129;
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
				int num = -873123300;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBF33F2FDu) % 4u)
					{
					case 1u:
						count = m_Dict.Count;
						num = (int)((num2 * 148635731) ^ 0x723D6EAA);
						continue;
					case 0u:
						num = (int)(num2 * 530339720) ^ -506594578;
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
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1393732340;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCC3A5C48u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = (int)(num2 * 464172771) ^ -1513033409;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = 516034928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41AB328Cu) % 12u)
				{
				case 10u:
					num = ((int)num2 * -1586195929) ^ 0x50E394B2;
					continue;
				case 9u:
					num = (int)(num2 * 475924504) ^ -1677979474;
					continue;
				case 8u:
					num = ((int)num2 * -1408733509) ^ -462128321;
					continue;
				case 7u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 1399445454) ^ -1412383730;
					continue;
				case 6u:
					m_Dict.Add(aKey, aItem);
					num = 1519709017;
					continue;
				case 5u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1344115818;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!JSONClass.smethod_30(aKey))
					{
						num5 = 977732241;
						num6 = 977732241;
					}
					else
					{
						num5 = 1666646405;
						num6 = 1666646405;
					}
					num = num5 ^ ((int)num2 * -367607757);
					continue;
				}
				case 3u:
					num = 1960381880;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = 482744428;
						num4 = 482744428;
					}
					else
					{
						num3 = 393408553;
						num4 = 393408553;
					}
					num = num3 ^ ((int)num2 * -1338269735);
					continue;
				}
				case 1u:
					num = ((int)num2 * -500814803) ^ 0x1E15A0FE;
					continue;
				default:
					return;
				case 11u:
					break;
				case 0u:
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
			goto IL_0061;
		}
		goto IL_00a8;
		IL_00a8:
		JSONNode jSONNode = m_Dict[aKey];
		int num = 1635159381;
		goto IL_0077;
		IL_0077:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x51315118u) % 8u)
			{
			case 7u:
				num = ((int)num2 * -320758278) ^ 0x9F3AE0C;
				continue;
			case 6u:
				num = ((int)num2 * -505283320) ^ 0x561775DA;
				continue;
			case 5u:
				m_Dict.Remove(aKey);
				num = ((int)num2 * -1811094314) ^ 0x415DDEDA;
				continue;
			case 4u:
				result = jSONNode;
				num = ((int)num2 * -530372388) ^ 0x51650127;
				continue;
			case 3u:
				break;
			case 1u:
				result = null;
				num = (int)((num2 * 1498753399) ^ 0x1308ACA1);
				continue;
			case 0u:
				goto IL_00a8;
			default:
				return result;
			}
			break;
		}
		goto IL_0061;
		IL_0061:
		num = 601877505;
		goto IL_0077;
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_0046;
		}
		int num = 1;
		goto IL_009a;
		IL_009a:
		bool flag = (byte)num != 0;
		int num2 = -1278670946;
		goto IL_005c;
		IL_0046:
		num2 = -1681180772;
		goto IL_005c;
		IL_005c:
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x919960AFu) % 7u)
			{
			case 5u:
				num2 = (int)(num3 * 1965221254) ^ -70008830;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1268937246;
					num5 = -1268937246;
				}
				else
				{
					num4 = -844832024;
					num5 = -844832024;
				}
				num2 = num4 ^ ((int)num3 * -305544235);
				continue;
			}
			case 3u:
				result = null;
				num2 = -335558448;
				continue;
			case 2u:
				break;
			case 0u:
				result = null;
				num2 = ((int)num3 * -694800757) ^ 0x75750BEE;
				continue;
			case 6u:
				goto IL_0089;
			default:
				return result;
			}
			break;
		}
		goto IL_0046;
		IL_0089:
		num = ((aIndex >= m_Dict.Count) ? 1 : 0);
		goto IL_009a;
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
				_ = -609024988;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -1373795508;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = (num * 331362921) ^ 0x635758C1;
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
		string result = default(string);
		while (true)
		{
			int num = 97612018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F2B6C49u) % 3u)
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
							IL_016b:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 166207716;
								num4 = 166207716;
							}
							else
							{
								num3 = 891941080;
								num4 = 891941080;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x1F2B6C49u) % 9u)
								{
								case 8u:
									num3 = ((int)num2 * -860821531) ^ 0x6EB5635B;
									continue;
								case 7u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = 1376167124;
										num6 = 1376167124;
									}
									else
									{
										num5 = 1662344505;
										num6 = 1662344505;
									}
									num3 = num5 ^ ((int)num2 * -1024713573);
									continue;
								}
								case 6u:
									current = enumerator.Current;
									num3 = 1757233626;
									continue;
								case 5u:
									num3 = 891941080;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 2046858189) ^ 0x76ED3394);
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
									num3 = 107213855;
									continue;
								case 2u:
									num3 = ((int)num2 * -2032531757) ^ -488568941;
									continue;
								default:
									goto end_IL_0125;
								case 0u:
									break;
								case 1u:
									goto end_IL_0125;
								}
								goto IL_016b;
								continue;
								end_IL_0125:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = 2142243468;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x1F2B6C49u) % 3u)
							{
							case 1u:
								goto IL_0197;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_0197:
							result = text;
							num7 = ((int)num2 * -773981416) ^ -159098053;
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)(num2 * 252360531) ^ -1594017669;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		while (true)
		{
			int num = -1996723869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80ECB05Eu) % 3u)
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
							IL_0174:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1892390281;
								num4 = -1892390281;
							}
							else
							{
								num3 = -1260962788;
								num4 = -1260962788;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x80ECB05Eu) % 8u)
								{
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1239644451) ^ -44283760;
									continue;
								case 6u:
									num3 = (int)((num2 * 1078522739) ^ 0x168B0AA7);
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
									num3 = -1458024410;
									continue;
								case 4u:
									num3 = -1892390281;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) <= 3)
									{
										num5 = -1778291261;
										num6 = -1778291261;
									}
									else
									{
										num5 = -1144927103;
										num6 = -1144927103;
									}
									num3 = num5 ^ ((int)num2 * -626659672);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = -541147848;
									continue;
								default:
									goto end_IL_0133;
								case 0u:
									break;
								case 2u:
									goto end_IL_0133;
								}
								goto IL_0174;
								continue;
								end_IL_0133:
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
							IL_01bf:
							int num7 = -1221527308;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x80ECB05Eu) % 3u)
								{
								case 1u:
									goto IL_0193;
								default:
									goto end_IL_01a1;
								case 2u:
									break;
								case 0u:
									goto end_IL_01a1;
								}
								goto IL_01bf;
								IL_0193:
								num7 = ((int)num2 * -365570384) ^ 0x55078FE6;
								continue;
								end_IL_01a1:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num8 = -1469797936;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x80ECB05Eu) % 3u)
							{
							case 1u:
								goto IL_01de;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_01de:
							num8 = (int)(num2 * 1634031607) ^ -425957524;
						}
					}
				}
				}
				break;
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -969263952) ^ -1860073519;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -1906695039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC776D1DEu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
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
								num3 = -1099544826;
								num4 = -1099544826;
							}
							else
							{
								num3 = -2077735084;
								num4 = -2077735084;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC776D1DEu) % 9u)
								{
								case 8u:
									num3 = (int)((num2 * 22462937) ^ 0x238F9113);
									continue;
								case 7u:
									JSONClass.smethod_38(aWriter, current);
									num3 = ((int)num2 * -1246465967) ^ -1181580863;
									continue;
								case 6u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -1979782296) ^ 0x2915565A;
									continue;
								case 4u:
									num3 = -1099544826;
									continue;
								case 3u:
									num3 = ((int)num2 * -779105585) ^ -902435453;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -171388087;
									continue;
								case 0u:
									num3 = (int)((num2 * 24934602) ^ 0x7E7D6918);
									continue;
								default:
									return;
								case 2u:
									break;
								case 5u:
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
							IL_0176:
							int num5 = -99927033;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0xC776D1DEu) % 3u)
								{
								case 1u:
									goto IL_014c;
								default:
									goto end_IL_0159;
								case 2u:
									break;
								case 0u:
									goto end_IL_0159;
								}
								goto IL_0176;
								IL_014c:
								num5 = ((int)num2 * -644340041) ^ 0x6AFE534D;
								continue;
								end_IL_0159:
								break;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0003:
				JSONClass.smethod_36(aWriter, (byte)2);
				num = ((int)num2 * -1515840895) ^ 0x7F763D8A;
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
