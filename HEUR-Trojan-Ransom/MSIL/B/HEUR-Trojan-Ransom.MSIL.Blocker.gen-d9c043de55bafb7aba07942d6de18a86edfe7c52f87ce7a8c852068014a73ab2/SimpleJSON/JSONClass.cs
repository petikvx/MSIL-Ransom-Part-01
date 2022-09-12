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
				goto IL_004a;
			}
			goto IL_0078;
			IL_0078:
			JSONNode result = new JSONLazyCreator(this, aKey);
			int num = -308033909;
			goto IL_004f;
			IL_004f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE934E6D1u) % 6u)
				{
				case 4u:
					num = (int)((num2 * 1361597088) ^ 0x449322F4);
					continue;
				case 3u:
					result = m_Dict[aKey];
					num = (int)((num2 * 996298046) ^ 0x7ECF9773);
					continue;
				case 2u:
					num = (int)((num2 * 376534789) ^ 0x77B37270);
					continue;
				case 0u:
					break;
				case 1u:
					goto IL_0078;
				default:
					return result;
				}
				break;
			}
			goto IL_004a;
			IL_004a:
			num = -1370978652;
			goto IL_004f;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -1552813072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF07914CFu) % 7u)
					{
					case 5u:
						m_Dict.Add(aKey, value);
						num = -1083743524;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 893920341;
							num4 = 893920341;
						}
						else
						{
							num3 = 584283611;
							num4 = 584283611;
						}
						num = num3 ^ (int)(num2 * 2112670261);
						continue;
					}
					case 2u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 1509433003) ^ -1436899867;
						continue;
					case 1u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)(num2 * 491744734) ^ -1773596514;
						continue;
					case 0u:
						num = (int)(num2 * 1136562553) ^ -1036351143;
						continue;
					default:
						return;
					case 4u:
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
			JSONNode result = default(JSONNode);
			bool flag = default(bool);
			while (true)
			{
				int num = 349208099;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x71707304u) % 8u)
					{
					case 7u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1081038295) ^ 0x2AB380C0;
							continue;
						}
						num5 = 1;
						goto IL_001a;
					case 5u:
						num = ((int)num2 * -412655250) ^ 0x2BD2754;
						continue;
					case 4u:
						result = null;
						num = ((int)num2 * -274914076) ^ 0x73FC4231;
						continue;
					case 3u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					case 2u:
						result = null;
						num = 608014578;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 496615076;
							num4 = 496615076;
						}
						else
						{
							num3 = 145322090;
							num4 = 145322090;
						}
						num = num3 ^ (int)(num2 * 1923820274);
						continue;
					}
					case 0u:
						break;
					default:
						{
							return result;
						}
						IL_001a:
						flag = (byte)num5 != 0;
						num = 1638637893;
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
			int num2 = 1030780579;
			goto IL_003f;
			IL_003a:
			num2 = 331507994;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x6E982A7Bu) % 5u)
				{
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 883950251;
						num5 = 883950251;
					}
					else
					{
						num4 = 1343612526;
						num5 = 1343612526;
					}
					num2 = num4 ^ ((int)num3 * -714804777);
					continue;
				}
				case 2u:
					num2 = (int)((num3 * 416609515) ^ 0x3F52ACEE);
					continue;
				case 0u:
					break;
				default:
					return;
				case 4u:
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
		bool flag = !JSONClass.smethod_30(aKey);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 164630534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6A2FE1u) % 14u)
				{
				case 13u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 433125896;
						num6 = 433125896;
					}
					else
					{
						num5 = 1049333205;
						num6 = 1049333205;
					}
					num = num5 ^ (int)(num2 * 140578849);
					continue;
				}
				case 12u:
					num = (int)((num2 * 1076659865) ^ 0x55C9DEA9);
					continue;
				case 11u:
					num = (int)((num2 * 76800869) ^ 0xD4F8DE4);
					continue;
				case 9u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 1119746284;
					continue;
				case 8u:
					num = (int)(num2 * 306758576) ^ -1933911135;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -95281217;
						num4 = -95281217;
					}
					else
					{
						num3 = -342381543;
						num4 = -342381543;
					}
					num = num3 ^ (int)(num2 * 1064299611);
					continue;
				}
				case 6u:
					num = (int)(num2 * 54511635) ^ -2116831274;
					continue;
				case 5u:
					num = ((int)num2 * -75695285) ^ -937502892;
					continue;
				case 4u:
					flag2 = m_Dict.ContainsKey(aKey);
					num = (int)(num2 * 229750705) ^ -961838004;
					continue;
				case 3u:
					m_Dict.Add(aKey, aItem);
					num = 544823759;
					continue;
				case 2u:
					num = 463954175;
					continue;
				case 0u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 2024563104) ^ -863687978;
					continue;
				default:
					return;
				case 10u:
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1764698300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0CF8C76u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -699354521) ^ 0x4500F672;
					continue;
				case 3u:
					flag = !m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -540606543) ^ 0x61983B51;
					continue;
				case 2u:
					result = null;
					num = ((int)num2 * -1076000938) ^ 0x6B0FA4E5;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -970412065;
						num4 = -970412065;
					}
					else
					{
						num3 = -283453199;
						num4 = -283453199;
					}
					num = num3 ^ ((int)num2 * -81208258);
					continue;
				}
				case 0u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = -1995848175;
					continue;
				}
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1649169773;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x8DC48C88u) % 8u)
				{
				case 6u:
					result = null;
					num = ((int)num2 * -1782202863) ^ -1718978329;
					continue;
				case 5u:
					result = null;
					num = -2010940900;
					continue;
				case 4u:
					num = (int)(num2 * 379736417) ^ -914616602;
					continue;
				case 3u:
					if (aIndex >= 0)
					{
						num = (int)((num2 * 1469573367) ^ 0x72DE9EA5);
						continue;
					}
					goto IL_0051;
				case 1u:
					num = ((int)num2 * -1483573604) ^ -1265147666;
					continue;
				case 0u:
					if (aIndex < m_Dict.Count)
					{
						num = -391395403;
						num3 = -391395403;
						continue;
					}
					goto IL_0051;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_0051:
					num = -604997530;
					num3 = -604997530;
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
			return null;
		}
		catch
		{
			return null;
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
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1160489743;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32004A9Eu) % 3u)
				{
				case 1u:
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
							IL_0171:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 529088180;
								num4 = 529088180;
							}
							else
							{
								num3 = 1462474477;
								num4 = 1462474477;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x32004A9Eu) % 9u)
								{
								case 8u:
									num3 = 529088180;
									continue;
								case 7u:
									current = enumerator.Current;
									num3 = 1863712733;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = -1014191638;
										num6 = -1014191638;
									}
									else
									{
										num5 = -1393951532;
										num6 = -1393951532;
									}
									num3 = num5 ^ ((int)num2 * -258511762);
									continue;
								}
								case 5u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -1701272541) ^ -1396999260;
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
									num3 = 559241005;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -183585652) ^ 0x6B937F40;
									continue;
								case 0u:
									num3 = (int)((num2 * 1189927865) ^ 0x2CC2C93F);
									continue;
								default:
									goto end_IL_012b;
								case 4u:
									break;
								case 2u:
									goto end_IL_012b;
								}
								goto IL_0171;
								continue;
								end_IL_012b:
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
							IL_01bc:
							int num7 = 1334970202;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x32004A9Eu) % 3u)
								{
								case 1u:
									goto IL_0190;
								default:
									goto end_IL_019e;
								case 2u:
									break;
								case 0u:
									goto end_IL_019e;
								}
								goto IL_01bc;
								IL_0190:
								num7 = ((int)num2 * -1887986628) ^ 0x65E74DBA;
								continue;
								end_IL_019e:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num8 = 616310323;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x32004A9Eu) % 4u)
							{
							case 3u:
								num8 = (int)(num2 * 2053650616) ^ -439309022;
								continue;
							case 1u:
								result = text;
								num8 = ((int)num2 * -1304091663) ^ -223626200;
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
				IL_0003:
				text = "{";
				num = (int)(num2 * 239224571) ^ -30666110;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		while (true)
		{
			int num = -755336762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD220B235u) % 3u)
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
							IL_01b8:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -841526497;
								num4 = -841526497;
							}
							else
							{
								num3 = -245527971;
								num4 = -245527971;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD220B235u) % 11u)
								{
								case 9u:
									num3 = (int)(num2 * 851598268) ^ -1593316643;
									continue;
								case 8u:
									num3 = ((int)num2 * -1308197133) ^ 0x5FAACB00;
									continue;
								case 7u:
									num3 = -841526497;
									continue;
								case 6u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									num3 = -673172046;
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
									num3 = ((int)num2 * -1656300747) ^ 0x2C9A280F;
									continue;
								case 4u:
									current = enumerator.Current;
									num3 = -1326611096;
									continue;
								case 3u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -643661764) ^ -288420007;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = -1126737264;
										num6 = -1126737264;
									}
									else
									{
										num5 = -2003041700;
										num6 = -2003041700;
									}
									num3 = num5 ^ (int)(num2 * 1920983759);
									continue;
								}
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1034209615) ^ -1894761783;
									continue;
								default:
									goto end_IL_016a;
								case 2u:
									break;
								case 10u:
									goto end_IL_016a;
								}
								goto IL_01b8;
								continue;
								end_IL_016a:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = -1198438116;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xD220B235u) % 3u)
							{
							case 2u:
								goto IL_01ed;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01ed:
							num7 = (int)(num2 * 213404845) ^ -2117852383;
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)(num2 * 1198745706) ^ -326103963;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -1763252996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3DAD5C4u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 2000442165) ^ -428284235;
					continue;
				case 3u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = ((int)num2 * -1679781409) ^ -794585613;
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -360493602) ^ 0x7F0725FD;
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
							num3 = -244761350;
							num4 = -244761350;
						}
						else
						{
							num3 = -396985087;
							num4 = -396985087;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xA3DAD5C4u) % 8u)
							{
							case 7u:
								num3 = -396985087;
								continue;
							case 5u:
								current = enumerator.Current;
								num3 = -869332139;
								continue;
							case 3u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)(num2 * 1202151753) ^ -1356957185;
								continue;
							case 2u:
								num3 = ((int)num2 * -60803433) ^ -196680562;
								continue;
							case 1u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -574416323) ^ -422990182;
								continue;
							case 0u:
								num3 = ((int)num2 * -392505630) ^ 0x135784A6;
								continue;
							default:
								return;
							case 4u:
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
			int num = 1487750712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74967A47u) % 3u)
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
				num = (int)((num2 * 988124045) ^ 0x2107E91);
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
