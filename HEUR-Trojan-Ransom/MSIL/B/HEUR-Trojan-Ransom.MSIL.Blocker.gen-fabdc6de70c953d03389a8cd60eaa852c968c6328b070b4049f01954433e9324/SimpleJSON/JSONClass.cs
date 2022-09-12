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
				int num = 235922485;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x604C1853u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1127753684) ^ 0x781E0B4C);
						continue;
					case 6u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -885359872) ^ -1295163333;
						continue;
					case 4u:
						num = (int)((num2 * 622014893) ^ 0x604E0A4);
						continue;
					case 2u:
						result = new JSONLazyCreator(this, aKey);
						num = 517565172;
						continue;
					case 1u:
						result = m_Dict[aKey];
						num = ((int)num2 * -283683143) ^ 0x4E6B7696;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1674567738;
							num4 = 1674567738;
						}
						else
						{
							num3 = 1853691817;
							num4 = 1853691817;
						}
						num = num3 ^ (int)(num2 * 663256970);
						continue;
					}
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
			bool flag = default(bool);
			while (true)
			{
				int num = 1979789759;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B638C1Bu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -896733393) ^ -1406770247;
						continue;
					case 6u:
						m_Dict.Add(aKey, value);
						num = 1790325518;
						continue;
					case 5u:
						num = (int)(num2 * 664966468) ^ -1038074516;
						continue;
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -438478699) ^ 0x664C577;
						continue;
					case 1u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 1098094983) ^ 0x4C15801B);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -306209518;
							num4 = -306209518;
						}
						else
						{
							num3 = -1068081427;
							num4 = -1068081427;
						}
						num = num3 ^ ((int)num2 * -872979662);
						continue;
					}
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
			bool flag = default(bool);
			while (true)
			{
				int num = -648183660;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xA4CF60FBu) % 8u)
					{
					case 7u:
						if (aIndex >= 0)
						{
							num = (int)((num2 * 489913869) ^ 0x8A31FEB);
							continue;
						}
						num3 = 1;
						goto IL_001a;
					case 6u:
						result = null;
						num = ((int)num2 * -637195661) ^ -676793192;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 494559465;
							num5 = 494559465;
						}
						else
						{
							num4 = 1083980007;
							num5 = 1083980007;
						}
						num = num4 ^ ((int)num2 * -941227860);
						continue;
					}
					case 3u:
						num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_001a;
					case 1u:
						num = ((int)num2 * -1727404618) ^ 0x6064304F;
						continue;
					case 0u:
						result = null;
						num = -422109527;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_001a:
						flag = (byte)num3 != 0;
						num = -880640202;
						continue;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -87688505;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xF375F5E9u) % 5u)
					{
					case 3u:
						if (aIndex < m_Dict.Count)
						{
							num = -1490147228;
							num3 = -1490147228;
							continue;
						}
						goto IL_0022;
					case 1u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -316431438) ^ -171716281;
							continue;
						}
						goto IL_0022;
					case 0u:
						num = ((int)num2 * -1839978878) ^ -674145614;
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
						return;
						IL_0022:
						num = -1755092926;
						num3 = -1755092926;
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
				int num = -1156116858;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1CC3AFCu) % 3u)
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
					num = ((int)num2 * -1887937622) ^ 0x76B27237;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 308779721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E390373u) % 12u)
				{
				case 11u:
					num = ((int)num2 * -463069841) ^ -266059368;
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (JSONClass.smethod_30(aKey))
					{
						num5 = 1780505079;
						num6 = 1780505079;
					}
					else
					{
						num5 = 1301423348;
						num6 = 1301423348;
					}
					num = num5 ^ ((int)num2 * -397384963);
					continue;
				}
				case 8u:
					num = (int)(num2 * 251631634) ^ -487208616;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2140357890;
						num4 = 2140357890;
					}
					else
					{
						num3 = 884126723;
						num4 = 884126723;
					}
					num = num3 ^ ((int)num2 * -1582213485);
					continue;
				}
				case 6u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 2113357019;
					continue;
				case 5u:
					num = (int)(num2 * 276828664) ^ -13412812;
					continue;
				case 3u:
					flag = m_Dict.ContainsKey(aKey);
					num = ((int)num2 * -2115421103) ^ 0x5E54EDC3;
					continue;
				case 2u:
					num = 2113357019;
					continue;
				case 1u:
					m_Dict.Add(aKey, aItem);
					num = 2103181485;
					continue;
				case 0u:
					m_Dict[aKey] = aItem;
					num = (int)((num2 * 750668840) ^ 0x686FE0B);
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
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
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1264058536;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x513861AAu) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 491601223;
						num4 = 491601223;
					}
					else
					{
						num3 = 796563164;
						num4 = 796563164;
					}
					num = num3 ^ (int)(num2 * 1155741323);
					continue;
				}
				case 5u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -988084924) ^ 0x462EAA03;
					continue;
				case 4u:
					jSONNode = m_Dict[aKey];
					num = 516992005;
					continue;
				case 2u:
					num = ((int)num2 * -1764055834) ^ -1790725133;
					continue;
				case 0u:
					result = null;
					num = (int)((num2 * 24688748) ^ 0x1F8EAD6C);
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

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_004f;
		}
		goto IL_0094;
		IL_004f:
		int num = -1770794701;
		goto IL_0054;
		IL_0054:
		JSONNode result = default(JSONNode);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD2165382u) % 7u)
			{
			case 6u:
				num = (int)(num2 * 1550983765) ^ -954503201;
				continue;
			case 5u:
				num = (int)(num2 * 615556170) ^ -484854254;
				continue;
			case 4u:
				result = null;
				num = -1699263202;
				continue;
			case 3u:
				result = null;
				num = ((int)num2 * -2093768857) ^ 0x4763B188;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0081;
			default:
				return result;
			}
			break;
			IL_0081:
			if (aIndex < m_Dict.Count)
			{
				num = -1855838236;
				num3 = -1855838236;
				continue;
			}
			goto IL_0094;
		}
		goto IL_004f;
		IL_0094:
		num = -943341889;
		num3 = -943341889;
		goto IL_0054;
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
		using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
		{
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_010d:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -193988547;
					num2 = -193988547;
				}
				else
				{
					num = -1747106256;
					num2 = -1747106256;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xCBD47A5Cu) % 7u)
					{
					case 6u:
						num = ((int)num3 * -1253739380) ^ -1425689164;
						continue;
					case 5u:
						num = -193988547;
						continue;
					case 4u:
					{
						current = enumerator.Current;
						int num4;
						if (JSONClass.smethod_31(text) <= 2)
						{
							num = -1477281121;
							num4 = -1477281121;
						}
						else
						{
							num = -1209142646;
							num4 = -1209142646;
						}
						continue;
					}
					case 2u:
						text = JSONClass.smethod_32(text, ", ");
						num = ((int)num3 * -71154955) ^ -1687070127;
						continue;
					case 1u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = -944191785;
						continue;
					default:
						goto end_IL_00d0;
					case 0u:
						break;
					case 3u:
						goto end_IL_00d0;
					}
					goto IL_010d;
					continue;
					end_IL_00d0:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = default(string);
		while (true)
		{
			int num5 = -1777020043;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num5 ^ 0xCBD47A5Cu) % 4u)
				{
				case 2u:
					num5 = (int)((num3 * 108299040) ^ 0x237AC804);
					continue;
				case 1u:
					result = text;
					num5 = (int)((num3 * 248869935) ^ 0x1C6C19D5);
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

	public override string ToString(string aPrefix)
	{
		string text = "{ ";
		bool flag = default(bool);
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		while (true)
		{
			int num = -590853101;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD14419BAu) % 3u)
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
							IL_019e:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1979662015;
								num4 = -1979662015;
							}
							else
							{
								num3 = -922870208;
								num4 = -922870208;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD14419BAu) % 10u)
								{
								case 9u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = (int)(num2 * 846953558) ^ -1717521900;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1628624512;
										num6 = 1628624512;
									}
									else
									{
										num5 = 1942050779;
										num6 = 1942050779;
									}
									num3 = num5 ^ ((int)num2 * -332444050);
									continue;
								}
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
									num3 = -2138420779;
									continue;
								case 4u:
									num3 = -1979662015;
									continue;
								case 3u:
									num3 = ((int)num2 * -1418478448) ^ 0x5B04CE0B;
									continue;
								case 2u:
									num3 = ((int)num2 * -678784836) ^ 0x52F261F9;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1545032794;
									continue;
								case 0u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1211605877) ^ -2058634443;
									continue;
								default:
									goto end_IL_0154;
								case 7u:
									break;
								case 8u:
									goto end_IL_0154;
								}
								goto IL_019e;
								continue;
								end_IL_0154:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					string result = text;
					while (true)
					{
						int num7 = -407698337;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xD14419BAu) % 3u)
							{
							case 1u:
								goto IL_01d3;
							case 0u:
								break;
							default:
								return result;
							}
							break;
							IL_01d3:
							num7 = ((int)num2 * -530693506) ^ -1594407200;
						}
					}
				}
				}
				break;
				IL_0008:
				num = (int)(num2 * 165666398) ^ -1752539295;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = 1445934238;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3785EBAEu) % 6u)
				{
				case 4u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 1921641214) ^ -817380963;
					continue;
				case 3u:
					num = (int)((num2 * 1546673490) ^ 0x409770A);
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = ((int)num2 * -1740835401) ^ -1115985025;
					continue;
				case 1u:
					num = ((int)num2 * -668620567) ^ 0x4E1E371B;
					continue;
				case 5u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.KeyCollection.Enumerator enumerator = m_Dict.Keys.GetEnumerator();
					try
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1342170746;
								num4 = 1342170746;
							}
							else
							{
								num3 = 1168871831;
								num4 = 1168871831;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3785EBAEu) % 6u)
								{
								case 5u:
									num3 = ((int)num2 * -733864279) ^ -459993926;
									continue;
								case 2u:
									current = enumerator.Current;
									JSONClass.smethod_38(aWriter, current);
									num3 = 775044387;
									continue;
								case 1u:
									m_Dict[current].Serialize(aWriter);
									num3 = ((int)num2 * -1476295285) ^ -664327939;
									continue;
								case 0u:
									num3 = 1342170746;
									continue;
								default:
									return;
								case 4u:
									break;
								case 3u:
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
							IL_0175:
							int num5 = 1810548466;
							while (true)
							{
								switch ((num2 = (uint)num5 ^ 0x3785EBAEu) % 3u)
								{
								case 1u:
									goto IL_014b;
								default:
									goto end_IL_0158;
								case 0u:
									break;
								case 2u:
									goto end_IL_0158;
								}
								goto IL_0175;
								IL_014b:
								num5 = ((int)num2 * -340063774) ^ 0x139ED966;
								continue;
								end_IL_0158:
								break;
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
			int num = -1069139959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB1BE9CAu) % 3u)
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
				num = ((int)num2 * -472316566) ^ -1198456320;
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
