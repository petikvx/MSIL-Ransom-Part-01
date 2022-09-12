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
				int num = -126050944;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA813B39u) % 6u)
					{
					case 5u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1044638754) ^ 0x4D2E3E03;
						continue;
					case 4u:
						result = new JSONLazyCreator(this, aKey);
						num = -435270102;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -139174003;
							num4 = -139174003;
						}
						else
						{
							num3 = -601599487;
							num4 = -601599487;
						}
						num = num3 ^ ((int)num2 * -1633182643);
						continue;
					}
					case 0u:
						result = m_Dict[aKey];
						num = (int)(num2 * 1230114727) ^ -372749106;
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
			bool flag = default(bool);
			while (true)
			{
				int num = 417535788;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B10AB0Bu) % 7u)
					{
					case 5u:
						m_Dict.Add(aKey, value);
						num = 1343773134;
						continue;
					case 4u:
						num = ((int)num2 * -760436867) ^ -1926880148;
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 638534700) ^ -1086804253;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 926025753;
							num4 = 926025753;
						}
						else
						{
							num3 = 593578845;
							num4 = 593578845;
						}
						num = num3 ^ (int)(num2 * 917079544);
						continue;
					}
					case 0u:
						m_Dict[aKey] = value;
						num = ((int)num2 * -1763881648) ^ 0x44599BBD;
						continue;
					default:
						return;
					case 3u:
						break;
					case 6u:
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
				goto IL_0048;
			}
			int num = 1;
			goto IL_009a;
			IL_009a:
			bool flag = (byte)num != 0;
			int num2 = -1679819038;
			goto IL_005c;
			IL_0048:
			num2 = -572653180;
			goto IL_005c;
			IL_005c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x84C9AE00u) % 7u)
				{
				case 6u:
					result = null;
					num2 = (int)(num3 * 1079175181) ^ -584739668;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 776964636;
						num5 = 776964636;
					}
					else
					{
						num4 = 1373089765;
						num5 = 1373089765;
					}
					num2 = num4 ^ (int)(num3 * 173316171);
					continue;
				}
				case 4u:
					result = null;
					num2 = -172780419;
					continue;
				case 3u:
					break;
				case 2u:
					num2 = ((int)num3 * -680794867) ^ 0x40C6CB4B;
					continue;
				case 1u:
					goto IL_0089;
				default:
					return result;
				}
				break;
			}
			goto IL_0048;
			IL_0089:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_009a;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0014;
			}
			goto IL_005c;
			IL_0014:
			int num = -232527193;
			goto IL_0028;
			IL_0028:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCA264550u) % 4u)
				{
				case 2u:
					break;
				case 0u:
					num = (int)(num2 * 416170685) ^ -883214963;
					continue;
				default:
					return;
				case 3u:
					goto IL_0049;
				case 1u:
					return;
				}
				break;
				IL_0049:
				if (aIndex < m_Dict.Count)
				{
					num = -2111038583;
					num3 = -2111038583;
					continue;
				}
				goto IL_005c;
			}
			goto IL_0014;
			IL_005c:
			num = -2143245052;
			num3 = -2143245052;
			goto IL_0028;
		}
	}

	public override int Count
	{
		get
		{
			int count = m_Dict.Count;
			while (true)
			{
				int num = 2021796719;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x34817304u) % 3u)
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
					num = ((int)num2 * -90832052) ^ -725537513;
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
				int num = 837210188;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x235D89BBu) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1083347879) ^ -1989040566;
						continue;
					case 0u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 1673896046) ^ 0xC7F778A);
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

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -997757312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9351CB1Fu) % 14u)
				{
				case 13u:
					num = ((int)num2 * -2035274062) ^ 0x54AC6603;
					continue;
				case 12u:
					flag = m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 235938833) ^ -384835454;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (!JSONClass.smethod_30(aKey))
					{
						num5 = -1061282311;
						num6 = -1061282311;
					}
					else
					{
						num5 = -762726797;
						num6 = -762726797;
					}
					num = num5 ^ (int)(num2 * 776893525);
					continue;
				}
				case 9u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1513653103;
					continue;
				case 8u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 1770601570) ^ -711063956;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1942846527;
						num4 = 1942846527;
					}
					else
					{
						num3 = 208141267;
						num4 = 208141267;
					}
					num = num3 ^ ((int)num2 * -2064439350);
					continue;
				}
				case 5u:
					num = -1955615540;
					continue;
				case 4u:
					num = ((int)num2 * -1976592520) ^ -1973084826;
					continue;
				case 3u:
					num = (int)((num2 * 7968503) ^ 0x70F2C1A);
					continue;
				case 2u:
					m_Dict.Add(aKey, aItem);
					num = -899841087;
					continue;
				case 1u:
					num = (int)(num2 * 1040871147) ^ -1612413920;
					continue;
				case 0u:
					num = ((int)num2 * -1943157351) ^ 0x616FC8A8;
					continue;
				default:
					return;
				case 6u:
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
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = -962445103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8B4E34Fu) % 8u)
				{
				case 7u:
					result = null;
					num = (int)(num2 * 1519893303) ^ -1364676645;
					continue;
				case 6u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -342310388) ^ -1172533013;
					continue;
				case 5u:
					num = (int)((num2 * 1493936164) ^ 0x19C33370);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -57022490;
						num4 = -57022490;
					}
					else
					{
						num3 = -23697872;
						num4 = -23697872;
					}
					num = num3 ^ ((int)num2 * -1521081766);
					continue;
				}
				case 2u:
					result = jSONNode;
					num = ((int)num2 * -553888585) ^ 0x22074BEA;
					continue;
				case 1u:
					jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					num = -1121760947;
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -69703683;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC858A230u) % 7u)
				{
				case 5u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1227250509) ^ 0x9D26CEC;
						continue;
					}
					num3 = 1;
					goto IL_001a;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1690258404;
						num5 = 1690258404;
					}
					else
					{
						num4 = 1329620285;
						num5 = 1329620285;
					}
					num = num4 ^ ((int)num2 * -779137805);
					continue;
				}
				case 3u:
					result = null;
					num = -685750893;
					continue;
				case 2u:
					result = null;
					num = ((int)num2 * -487494572) ^ -1367813121;
					continue;
				case 1u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_001a;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_001a:
					flag = (byte)num3 != 0;
					num = -125369306;
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
				_ = -35244580;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -405383632;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num * -2142620859) ^ 0x61797A75;
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
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1564045906;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7D70361u) % 4u)
				{
				case 3u:
					text = "{";
					num = (int)((num2 * 1492088379) ^ 0x6A48BD91);
					continue;
				case 1u:
					num = (int)((num2 * 2000685256) ^ 0x5594E20B);
					continue;
				case 0u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_016b:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1518947617;
								num4 = -1518947617;
							}
							else
							{
								num3 = -797019736;
								num4 = -797019736;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xC7D70361u) % 8u)
								{
								case 7u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -466608352) ^ -1218500901;
									continue;
								case 5u:
									num3 = ((int)num2 * -389676470) ^ 0xC46200B;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 2)
									{
										num5 = -1775869746;
										num6 = -1775869746;
									}
									else
									{
										num5 = -1682938957;
										num6 = -1682938957;
									}
									num3 = num5 ^ ((int)num2 * -56883402);
									continue;
								}
								case 3u:
									num3 = -797019736;
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
									num3 = -534830676;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1163882387;
									continue;
								default:
									goto end_IL_012a;
								case 0u:
									break;
								case 6u:
									goto end_IL_012a;
								}
								goto IL_016b;
								continue;
								end_IL_012a:
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
							IL_01b6:
							int num7 = -2077561866;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xC7D70361u) % 3u)
								{
								case 1u:
									goto IL_018a;
								default:
									goto end_IL_0198;
								case 0u:
									break;
								case 2u:
									goto end_IL_0198;
								}
								goto IL_01b6;
								IL_018a:
								num7 = ((int)num2 * -1824107635) ^ -1541440859;
								continue;
								end_IL_0198:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = -1562243525;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xC7D70361u) % 4u)
							{
							case 3u:
								num8 = (int)(num2 * 1290912701) ^ -1858408293;
								continue;
							case 2u:
								result = text;
								num8 = ((int)num2 * -1288766772) ^ 0x32F02CE2;
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
				break;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		while (true)
		{
			int num = -1334364066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD14746DCu) % 4u)
				{
				case 2u:
					text = "{ ";
					num = (int)((num2 * 1129029419) ^ 0x72B310B3);
					continue;
				case 1u:
					num = ((int)num2 * -1479366966) ^ 0x65D21E02;
					continue;
				case 3u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_01a2:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -2071375606;
								num4 = -2071375606;
							}
							else
							{
								num3 = -1887041829;
								num4 = -1887041829;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD14746DCu) % 9u)
								{
								case 8u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 854287518;
										num6 = 854287518;
									}
									else
									{
										num5 = 546221737;
										num6 = 546221737;
									}
									num3 = num5 ^ (int)(num2 * 826411438);
									continue;
								}
								case 7u:
									current = enumerator.Current;
									num3 = -1214237139;
									continue;
								case 5u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)((num2 * 254969452) ^ 0x627C4520);
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -546113540) ^ -502937679;
									continue;
								case 3u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = -2014932230;
									continue;
								case 2u:
									num3 = (int)((num2 * 670424962) ^ 0x6379BBB8);
									continue;
								case 0u:
									num3 = -1887041829;
									continue;
								default:
									goto end_IL_015c;
								case 1u:
									break;
								case 6u:
									goto end_IL_015c;
								}
								goto IL_01a2;
								continue;
								end_IL_015c:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = -2039179525;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xD14746DCu) % 3u)
							{
							case 1u:
								goto IL_01d7;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_01d7:
							num7 = (int)((num2 * 1455964216) ^ 0x5646A836);
						}
					}
				}
				}
				break;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = 879253314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D5B5922u) % 5u)
				{
				case 4u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -119668159) ^ -622098581;
					continue;
				case 1u:
					num = (int)((num2 * 336864466) ^ 0x14FE8BF);
					continue;
				case 0u:
					num = ((int)num2 * -1877141856) ^ -1640385383;
					continue;
				case 3u:
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
							num3 = 550246022;
							num4 = 550246022;
						}
						else
						{
							num3 = 1252749111;
							num4 = 1252749111;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x2D5B5922u) % 8u)
							{
							case 7u:
								num3 = (int)((num2 * 1223417995) ^ 0x28DBD454);
								continue;
							case 6u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1663017760) ^ 0x2E0B8A9B);
								continue;
							case 5u:
								current = enumerator.Current;
								num3 = 138620540;
								continue;
							case 3u:
								num3 = (int)((num2 * 315623046) ^ 0x549C72B8);
								continue;
							case 2u:
								num3 = 1252749111;
								continue;
							case 1u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 1198275736) ^ 0x4AF56FDD);
								continue;
							default:
								return;
							case 0u:
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
