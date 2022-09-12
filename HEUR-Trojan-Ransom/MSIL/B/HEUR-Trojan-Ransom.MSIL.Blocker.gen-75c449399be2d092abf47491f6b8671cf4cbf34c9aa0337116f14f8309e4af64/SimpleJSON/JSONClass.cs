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
				int num = -1915122348;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x802186D5u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 200350602) ^ 0x2F6A1AF6);
						continue;
					case 6u:
						result = new JSONLazyCreator(this, aKey);
						num = -1463937146;
						continue;
					case 4u:
						result = m_Dict[aKey];
						num = (int)(num2 * 450493142) ^ -1186946990;
						continue;
					case 3u:
						num = ((int)num2 * -1837250235) ^ 0x5E72CDDF;
						continue;
					case 1u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -59704257) ^ 0x6A7B2C52;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 85193937;
							num4 = 85193937;
						}
						else
						{
							num3 = 202781995;
							num4 = 202781995;
						}
						num = num3 ^ ((int)num2 * -1057697182);
						continue;
					}
					case 2u:
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
				goto IL_004a;
			}
			goto IL_0078;
			IL_0078:
			m_Dict.Add(aKey, value);
			int num = -1378234315;
			goto IL_004f;
			IL_004f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA779E6Cu) % 6u)
				{
				case 4u:
					num = ((int)num2 * -397203857) ^ 0x47CBAAA5;
					continue;
				case 2u:
					m_Dict[aKey] = value;
					num = ((int)num2 * -1465977795) ^ -1859363362;
					continue;
				case 1u:
					num = (int)(num2 * 1544540149) ^ -790865984;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_0078;
				case 3u:
					return;
				}
				break;
			}
			goto IL_004a;
			IL_004a:
			num = -775953090;
			goto IL_004f;
		}
	}

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1574819047;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4C4077FEu) % 6u)
					{
					case 5u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -2066291677) ^ 0x1E214F03;
							continue;
						}
						goto IL_0028;
					case 2u:
						if (aIndex < m_Dict.Count)
						{
							num = 935081237;
							num3 = 935081237;
							continue;
						}
						goto IL_0028;
					case 1u:
						result = null;
						num = 14288260;
						continue;
					case 0u:
						result = null;
						num = (int)(num2 * 332646087) ^ -470944408;
						continue;
					case 3u:
						break;
					default:
						{
							return result;
						}
						IL_0028:
						num = 346889290;
						num3 = 346889290;
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
				goto IL_003a;
			}
			int num = 1;
			goto IL_0075;
			IL_0075:
			bool flag = (byte)num != 0;
			int num2 = -1541401901;
			goto IL_003f;
			IL_003a:
			num2 = -221374989;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xF2F290C8u) % 5u)
				{
				case 4u:
					num2 = (int)((num3 * 1393846541) ^ 0x43EAA998);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1942120396;
						num5 = 1942120396;
					}
					else
					{
						num4 = 86648340;
						num5 = 86648340;
					}
					num2 = num4 ^ (int)(num3 * 2051689654);
					continue;
				}
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0064;
				case 1u:
					return;
				}
				break;
			}
			goto IL_003a;
			IL_0064:
			num = ((aIndex >= m_Dict.Count) ? 1 : 0);
			goto IL_0075;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = -980900554;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9447762Fu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return count;
					}
					break;
					IL_0003:
					count = m_Dict.Count;
					num = (int)((num2 * 2132461538) ^ 0x7A747A25);
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
				int num = -720757572;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9ED5E271u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -1200507146) ^ 0x7FCE4F04;
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = 1754708974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF4B81Fu) % 14u)
				{
				case 12u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -577963847) ^ -836826285;
					continue;
				case 11u:
					num = (int)((num2 * 1814122000) ^ 0x1EC5C148);
					continue;
				case 10u:
					num = (int)(num2 * 1550042672) ^ -1118238410;
					continue;
				case 9u:
					flag = !JSONClass.smethod_30(aKey);
					num = (int)(num2 * 911808302) ^ -1889411981;
					continue;
				case 8u:
					m_Dict.Add(aKey, aItem);
					num = 853887448;
					continue;
				case 7u:
					num = (int)(num2 * 488795162) ^ -333814777;
					continue;
				case 6u:
					num = (int)(num2 * 1983624600) ^ -1023770727;
					continue;
				case 5u:
					num = (int)((num2 * 1753530605) ^ 0x5BC34307);
					continue;
				case 4u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1771195796;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (m_Dict.ContainsKey(aKey))
					{
						num5 = 2109257801;
						num6 = 2109257801;
					}
					else
					{
						num5 = 214536417;
						num6 = 214536417;
					}
					num = num5 ^ (int)(num2 * 817265742);
					continue;
				}
				case 1u:
					num = 962446927;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 717292353;
						num4 = 717292353;
					}
					else
					{
						num3 = 74941948;
						num4 = 74941948;
					}
					num = num3 ^ ((int)num2 * -1307150336);
					continue;
				}
				default:
					return;
				case 13u:
					break;
				case 2u:
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
			int num = -939019174;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD601EB14u) % 7u)
				{
				case 6u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = (int)((num2 * 332483768) ^ 0x75EB211E);
					continue;
				case 5u:
					result = null;
					num = (int)(num2 * 580785041) ^ -1025203948;
					continue;
				case 4u:
					jSONNode = m_Dict[aKey];
					num = -1483470791;
					continue;
				case 3u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -1217336075) ^ -865753152;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1414912050;
						num4 = -1414912050;
					}
					else
					{
						num3 = -822292586;
						num4 = -822292586;
					}
					num = num3 ^ ((int)num2 * -114370284);
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

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1368921491;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x98AB7870u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1861252905;
						num5 = -1861252905;
					}
					else
					{
						num4 = -42891254;
						num5 = -42891254;
					}
					num = num4 ^ ((int)num2 * -171958779);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1704969685) ^ 0x574D4C32;
					continue;
				case 5u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 453322265) ^ 0x13BDF487);
						continue;
					}
					num3 = 1;
					goto IL_004d;
				case 4u:
					result = null;
					num = -233675104;
					continue;
				case 2u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_004d;
				case 1u:
					result = null;
					num = (int)((num2 * 699006672) ^ 0x77422B96);
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_004d:
					flag = (byte)num3 != 0;
					num = -1666688185;
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
				_ = 1887288932;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x62D1C34C;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						_ = (num * 883311587) ^ 0xFFD15266u;
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
		Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
		try
		{
			bool flag = default(bool);
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_014f:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 375881500;
					num2 = 375881500;
				}
				else
				{
					num = 872217754;
					num2 = 872217754;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x1D13656Du) % 10u)
					{
					case 8u:
						num = (int)(num3 * 816218019) ^ -480625416;
						continue;
					case 7u:
						num = 375881500;
						continue;
					case 6u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -1943613817) ^ 0x41731911;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 2030253493;
							num5 = 2030253493;
						}
						else
						{
							num4 = 1577094289;
							num5 = 1577094289;
						}
						num = num4 ^ (int)(num3 * 908245163);
						continue;
					}
					case 3u:
						flag = JSONClass.smethod_31(text) > 2;
						num = (int)((num3 * 1022058129) ^ 0x2EB705CC);
						continue;
					case 2u:
						num = ((int)num3 * -724992482) ^ -2058470576;
						continue;
					case 1u:
						current = enumerator.Current;
						num = 1679270843;
						continue;
					case 0u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = 2074879637;
						continue;
					default:
						goto end_IL_0105;
					case 9u:
						break;
					case 5u:
						goto end_IL_0105;
					}
					goto IL_014f;
					continue;
					end_IL_0105:
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
				IL_019a:
				int num6 = 925439550;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x1D13656Du) % 3u)
					{
					case 1u:
						goto IL_016e;
					default:
						goto end_IL_017c;
					case 0u:
						break;
					case 2u:
						goto end_IL_017c;
					}
					goto IL_019a;
					IL_016e:
					num6 = ((int)num3 * -68916827) ^ 0x212E0E75;
					continue;
					end_IL_017c:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num7 = 766922930;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x1D13656Du) % 4u)
				{
				case 3u:
					result = text;
					num7 = (int)((num3 * 1247456093) ^ 0x35F8FECB);
					continue;
				case 1u:
					num7 = ((int)num3 * -464600497) ^ 0x74560EB8;
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

	public override string ToString(string aPrefix)
	{
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1981875962;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB43380B9u) % 4u)
				{
				case 3u:
					text = "{ ";
					num = ((int)num2 * -1960971237) ^ -333065231;
					continue;
				case 1u:
					num = ((int)num2 * -1107979922) ^ 0x6AE67231;
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
							IL_01a5:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -984582047;
								num4 = -984582047;
							}
							else
							{
								num3 = -1002839370;
								num4 = -1002839370;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB43380B9u) % 9u)
								{
								case 8u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)((num2 * 1462701742) ^ 0x2AB0B7CD);
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 1607410435;
										num6 = 1607410435;
									}
									else
									{
										num5 = 1929807967;
										num6 = 1929807967;
									}
									num3 = num5 ^ ((int)num2 * -1706621956);
									continue;
								}
								case 4u:
									current = enumerator.Current;
									num3 = -334749893;
									continue;
								case 3u:
									num3 = -1002839370;
									continue;
								case 2u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -1608333536;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)((num2 * 239541343) ^ 0x1829DED9);
									continue;
								case 0u:
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = (int)((num2 * 1773759308) ^ 0x323CD71B);
									continue;
								default:
									goto end_IL_015f;
								case 5u:
									break;
								case 7u:
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
					finally
					{
						((IDisposable)enumerator).Dispose();
						while (true)
						{
							IL_01f0:
							int num7 = -668084471;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0xB43380B9u) % 3u)
								{
								case 2u:
									goto IL_01c4;
								default:
									goto end_IL_01d2;
								case 0u:
									break;
								case 1u:
									goto end_IL_01d2;
								}
								goto IL_01f0;
								IL_01c4:
								num7 = ((int)num2 * -1059830939) ^ -1392572834;
								continue;
								end_IL_01d2:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = -1793787738;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0xB43380B9u) % 3u)
							{
							case 1u:
								goto IL_020c;
							case 2u:
								break;
							default:
								return result;
							}
							break;
							IL_020c:
							result = text;
							num8 = ((int)num2 * -2084382331) ^ 0x7078AB5E;
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
			int num = 1119928434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4EA57288u) % 4u)
				{
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -393514664) ^ -891538487;
					continue;
				case 1u:
					num = (int)((num2 * 5531499) ^ 0xA49E9A0);
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
							num3 = 938384667;
							num4 = 938384667;
						}
						else
						{
							num3 = 1521510103;
							num4 = 1521510103;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x4EA57288u) % 8u)
							{
							case 6u:
								num3 = 938384667;
								continue;
							case 5u:
								num3 = ((int)num2 * -1459235728) ^ -2056893696;
								continue;
							case 4u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 573877123) ^ 0x422CCBA5);
								continue;
							case 3u:
								current = enumerator.Current;
								num3 = 754489186;
								continue;
							case 2u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1697748565) ^ -165903742;
								continue;
							case 1u:
								num3 = ((int)num2 * -1608346079) ^ 0x700C78C;
								continue;
							default:
								return;
							case 0u:
								break;
							case 7u:
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
			int num = 265342411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x417A280Fu) % 3u)
				{
				case 1u:
					goto IL_0013;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0013:
				num = (int)((num2 * 1296818188) ^ 0x21C37434);
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
