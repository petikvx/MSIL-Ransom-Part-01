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
				int num = -261957757;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBB767D06u) % 7u)
					{
					case 6u:
						result = new JSONLazyCreator(this, aKey);
						num = -1585186955;
						continue;
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -252549098) ^ 0x64766D20;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1010113232;
							num4 = 1010113232;
						}
						else
						{
							num3 = 1059471289;
							num4 = 1059471289;
						}
						num = num3 ^ (int)(num2 * 1398342117);
						continue;
					}
					case 2u:
						result = m_Dict[aKey];
						num = ((int)num2 * -333119596) ^ -1312455638;
						continue;
					case 1u:
						num = (int)(num2 * 1427984211) ^ -1365476759;
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
		set
		{
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = 1329740641;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39CDAE5Bu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -25547899) ^ 0x6D1D9CFD;
						continue;
					case 4u:
						num = (int)((num2 * 512509542) ^ 0x16383DB);
						continue;
					case 2u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 261843886) ^ -606036865;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -677196321;
							num4 = -677196321;
						}
						else
						{
							num3 = -1139738503;
							num4 = -1139738503;
						}
						num = num3 ^ ((int)num2 * -258407742);
						continue;
					}
					case 0u:
						m_Dict.Add(aKey, value);
						num = 1724721378;
						continue;
					default:
						return;
					case 5u:
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
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_002f;
			IL_002f:
			int num = 1865471035;
			goto IL_0045;
			IL_0045:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4358D15Cu) % 6u)
				{
				case 5u:
					num = (int)((num2 * 401035622) ^ 0x5F7BBC77);
					continue;
				case 4u:
					result = null;
					num = 1116629801;
					continue;
				case 2u:
					break;
				case 0u:
					result = null;
					num = (int)(num2 * 946714133) ^ -1955753479;
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
					num = 160421886;
					num3 = 160421886;
					continue;
				}
				goto IL_000a;
			}
			goto IL_002f;
			IL_000a:
			num = 1424309388;
			num3 = 1424309388;
			goto IL_0045;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 2119954149;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x492C2FBAu) % 6u)
					{
					case 5u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0017;
					case 3u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -1683767132) ^ -2039290119;
							continue;
						}
						num5 = 1;
						goto IL_0017;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 39236304;
							num4 = 39236304;
						}
						else
						{
							num3 = 1745623215;
							num4 = 1745623215;
						}
						num = num3 ^ (int)(num2 * 989841347);
						continue;
					}
					case 0u:
						num = ((int)num2 * -2079744715) ^ 0x7E114A65;
						continue;
					default:
						return;
					case 4u:
						break;
					case 1u:
						return;
						IL_0017:
						flag = (byte)num5 != 0;
						num = 271806652;
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
				int num = -1317423342;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9BE9AE70u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 412517348) ^ -320648439;
						continue;
					case 2u:
						count = m_Dict.Count;
						num = (int)(num2 * 12943713) ^ -1009208791;
						continue;
					case 0u:
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__14 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__14(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		bool flag = !JSONClass.smethod_30(aKey);
		while (true)
		{
			int num = -469297889;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B2090E1u) % 10u)
				{
				case 9u:
					num = ((int)num2 * -567323388) ^ -48898564;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 299518951;
						num6 = 299518951;
					}
					else
					{
						num5 = 1084813140;
						num6 = 1084813140;
					}
					num = num5 ^ ((int)num2 * -767561584);
					continue;
				}
				case 7u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = -1637747833;
					continue;
				case 5u:
					num = -1637747833;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (m_Dict.ContainsKey(aKey))
					{
						num3 = 2038082806;
						num4 = 2038082806;
					}
					else
					{
						num3 = 973975557;
						num4 = 973975557;
					}
					num = num3 ^ (int)(num2 * 1682705909);
					continue;
				}
				case 2u:
					m_Dict[aKey] = aItem;
					num = (int)(num2 * 165532327) ^ -128869054;
					continue;
				case 1u:
					m_Dict.Add(aKey, aItem);
					num = -858542824;
					continue;
				case 0u:
					num = (int)(num2 * 1500866120) ^ -968927476;
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

	public override JSONNode Remove(string aKey)
	{
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -567458211;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2F2ABA9u) % 7u)
				{
				case 5u:
					result = null;
					num = ((int)num2 * -158532947) ^ -1273005243;
					continue;
				case 4u:
					num = ((int)num2 * -1742326510) ^ -857978662;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1742404394;
						num4 = 1742404394;
					}
					else
					{
						num3 = 1996184122;
						num4 = 1996184122;
					}
					num = num3 ^ ((int)num2 * -827389221);
					continue;
				}
				case 2u:
					num = (int)(num2 * 2099070565) ^ -438921880;
					continue;
				case 1u:
				{
					JSONNode jSONNode = m_Dict[aKey];
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = -1984880667;
					continue;
				}
				case 6u:
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
			int num = -764821466;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD587A0CCu) % 8u)
				{
				case 7u:
					num = ((int)num2 * -97475575) ^ 0x643C7D18;
					continue;
				case 6u:
					result = null;
					num = -126632212;
					continue;
				case 5u:
					result = null;
					num = ((int)num2 * -543381006) ^ -1574709095;
					continue;
				case 2u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -1376279717) ^ -1261865725;
						continue;
					}
					goto IL_0051;
				case 1u:
					if (aIndex < m_Dict.Count)
					{
						num = -384729942;
						num3 = -384729942;
						continue;
					}
					goto IL_0051;
				case 0u:
					num = (int)(num2 * 97697144) ^ -863324625;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0051:
					num = -93141039;
					num3 = -93141039;
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
		string text = "{";
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string result = default(string);
		while (true)
		{
			int num = -1131011290;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA68672Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0187:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1042347843;
								num4 = -1042347843;
							}
							else
							{
								num3 = -1291080524;
								num4 = -1291080524;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xFA68672Eu) % 10u)
								{
								case 9u:
									num3 = -1042347843;
									continue;
								case 8u:
									num3 = ((int)num2 * -104401557) ^ -2001062195;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 46610330;
										num6 = 46610330;
									}
									else
									{
										num5 = 509680673;
										num6 = 509680673;
									}
									num3 = num5 ^ (int)(num2 * 1117408402);
									continue;
								}
								case 5u:
									current = enumerator.Current;
									num3 = -1357829508;
									continue;
								case 3u:
									flag = JSONClass.smethod_31(text) > 2;
									num3 = ((int)num2 * -905373702) ^ -562104336;
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
									num3 = -1922324196;
									continue;
								case 1u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1360698929) ^ 0x5FD443B;
									continue;
								case 0u:
									num3 = ((int)num2 * -1446448541) ^ -1288910215;
									continue;
								default:
									goto end_IL_013d;
								case 7u:
									break;
								case 4u:
									goto end_IL_013d;
								}
								goto IL_0187;
								continue;
								end_IL_013d:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = -2015761433;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xFA68672Eu) % 4u)
							{
							case 3u:
								num7 = (int)((num2 * 1981625179) ^ 0x798142C9);
								continue;
							case 1u:
								result = text;
								num7 = ((int)num2 * -402218778) ^ -1438771933;
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
				IL_0008:
				num = (int)(num2 * 1436006619) ^ -888128873;
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
				IL_0124:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1202836673;
					num2 = 1202836673;
				}
				else
				{
					num = 753687689;
					num2 = 753687689;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x636B4983u) % 7u)
					{
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
						num = 1410551634;
						continue;
					case 3u:
						num = ((int)num3 * -1035498088) ^ 0x63C7917D;
						continue;
					case 2u:
					{
						current = enumerator.Current;
						int num4;
						if (JSONClass.smethod_31(text) <= 3)
						{
							num = 1479449041;
							num4 = 1479449041;
						}
						else
						{
							num = 626657296;
							num4 = 626657296;
						}
						continue;
					}
					case 1u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)((num3 * 1116725691) ^ 0x4F9480B0);
						continue;
					case 0u:
						num = 753687689;
						continue;
					default:
						goto end_IL_00e7;
					case 6u:
						break;
					case 4u:
						goto end_IL_00e7;
					}
					goto IL_0124;
					continue;
					end_IL_00e7:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
		string result = default(string);
		while (true)
		{
			int num5 = 1325420582;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num5 ^ 0x636B4983u) % 4u)
				{
				case 1u:
					result = text;
					num5 = (int)(num3 * 526654919) ^ -70508844;
					continue;
				case 0u:
					num5 = ((int)num3 * -1700017970) ^ -907591864;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 2036578608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F301064u) % 6u)
				{
				case 4u:
					num = (int)((num2 * 1689370140) ^ 0x24DE393D);
					continue;
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1291122440) ^ -1697589730;
					continue;
				case 2u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)((num2 * 891969081) ^ 0x839D547);
					continue;
				case 1u:
					num = ((int)num2 * -1133045875) ^ -473425828;
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
							num3 = 1264735486;
							num4 = 1264735486;
						}
						else
						{
							num3 = 818706481;
							num4 = 818706481;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x2F301064u) % 6u)
							{
							case 4u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)(num2 * 1450033082) ^ -2021215590;
								continue;
							case 3u:
								num3 = 818706481;
								continue;
							case 1u:
								current = enumerator.Current;
								JSONClass.smethod_38(aWriter, current);
								num3 = 1256987828;
								continue;
							case 0u:
								num3 = ((int)num2 * -142468645) ^ -1816136497;
								continue;
							default:
								return;
							case 5u:
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
