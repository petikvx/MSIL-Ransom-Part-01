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
				int num = -1808823744;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB5B852FEu) % 6u)
					{
					case 5u:
						result = new JSONLazyCreator(this, aKey);
						num = -519444175;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 780152439;
							num4 = 780152439;
						}
						else
						{
							num3 = 1627418347;
							num4 = 1627418347;
						}
						num = num3 ^ (int)(num2 * 354158027);
						continue;
					}
					case 3u:
						result = m_Dict[aKey];
						num = (int)((num2 * 866930613) ^ 0x2FE4E6E4);
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = (int)((num2 * 1140504828) ^ 0x46C5C16A);
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
			bool flag = default(bool);
			while (true)
			{
				int num = -266637959;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB140AE0Du) % 8u)
					{
					case 7u:
						num = (int)(num2 * 937635057) ^ -20454085;
						continue;
					case 6u:
						m_Dict[aKey] = value;
						num = (int)(num2 * 1203461412) ^ -111836400;
						continue;
					case 5u:
						num = (int)((num2 * 905733312) ^ 0x4102798C);
						continue;
					case 4u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -1348753365) ^ 0x1ED0C4C3;
						continue;
					case 3u:
						m_Dict.Add(aKey, value);
						num = -367703830;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1823090593;
							num4 = -1823090593;
						}
						else
						{
							num3 = -2076697054;
							num4 = -2076697054;
						}
						num = num3 ^ (int)(num2 * 15297462);
						continue;
					}
					default:
						return;
					case 0u:
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
			if (aIndex < 0)
			{
				goto IL_000a;
			}
			goto IL_0026;
			IL_0026:
			int num = 1973236775;
			goto IL_0045;
			IL_0045:
			JSONNode result = default(JSONNode);
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77AFCFAAu) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1751562661) ^ -1264365971;
					continue;
				case 4u:
					break;
				case 2u:
					result = null;
					num = (int)(num2 * 2121551885) ^ -1866134580;
					continue;
				case 1u:
					result = null;
					num = 1366870565;
					continue;
				case 3u:
					goto IL_006e;
				default:
					return result;
				}
				break;
				IL_006e:
				if (aIndex < m_Dict.Count)
				{
					num = 1703606313;
					num3 = 1703606313;
					continue;
				}
				goto IL_000a;
			}
			goto IL_0026;
			IL_000a:
			num = 1769057432;
			num3 = 1769057432;
			goto IL_0045;
		}
		set
		{
			if (aIndex >= 0)
			{
				goto IL_0014;
			}
			goto IL_005c;
			IL_0014:
			int num = -1602617733;
			goto IL_0028;
			IL_0028:
			int num3;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7DB9792u) % 4u)
				{
				case 3u:
					break;
				case 2u:
					num = ((int)num2 * -261021945) ^ -1133535696;
					continue;
				default:
					return;
				case 1u:
					goto IL_0049;
				case 0u:
					return;
				}
				break;
				IL_0049:
				if (aIndex < m_Dict.Count)
				{
					num = -434527346;
					num3 = -434527346;
					continue;
				}
				goto IL_005c;
			}
			goto IL_0014;
			IL_005c:
			num = -283512512;
			num3 = -283512512;
			goto IL_0028;
		}
	}

	public override int Count
	{
		get
		{
			int count = default(int);
			while (true)
			{
				int num = 852164685;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7652BE6u) % 4u)
					{
					case 3u:
						count = m_Dict.Count;
						num = ((int)num2 * -1984904320) ^ 0x2BA671E3;
						continue;
					case 1u:
						num = ((int)num2 * -1079439091) ^ 0x639C2875;
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
			goto IL_006a;
		}
		goto IL_0113;
		IL_0113:
		m_Dict.Add(Guid.NewGuid().ToString(), aItem);
		int num = -1611582345;
		goto IL_00d1;
		IL_00d1:
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xCA02AE8Fu) % 12u)
			{
			case 11u:
				num = (int)(num2 * 793607819) ^ -2035494652;
				continue;
			case 10u:
				num = ((int)num2 * -1321680201) ^ -176959267;
				continue;
			case 9u:
				num = ((int)num2 * -1332821398) ^ 0x689348B2;
				continue;
			case 8u:
			{
				int num3;
				int num4;
				if (flag)
				{
					num3 = 874683674;
					num4 = 874683674;
				}
				else
				{
					num3 = 638583728;
					num4 = 638583728;
				}
				num = num3 ^ ((int)num2 * -1918329819);
				continue;
			}
			case 7u:
				break;
			case 6u:
				flag = m_Dict.ContainsKey(aKey);
				num = ((int)num2 * -1645362573) ^ 0x40E86799;
				continue;
			case 5u:
				m_Dict[aKey] = aItem;
				num = (int)(num2 * 436035333) ^ -1515065605;
				continue;
			case 3u:
				m_Dict.Add(aKey, aItem);
				num = -919131959;
				continue;
			case 2u:
				num = -666582999;
				continue;
			case 1u:
				num = ((int)num2 * -1416693056) ^ -1350845887;
				continue;
			default:
				return;
			case 0u:
				goto IL_0113;
			case 4u:
				return;
			}
			break;
		}
		goto IL_006a;
		IL_006a:
		num = -65951654;
		goto IL_00d1;
	}

	public override JSONNode Remove(string aKey)
	{
		bool flag = !m_Dict.ContainsKey(aKey);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		while (true)
		{
			int num = 1585379122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x399975DDu) % 6u)
				{
				case 5u:
					result = null;
					num = (int)((num2 * 1861971902) ^ 0x6C906DC5);
					continue;
				case 2u:
					jSONNode = m_Dict[aKey];
					num = 1336563061;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -501379949;
						num4 = -501379949;
					}
					else
					{
						num3 = -2015111694;
						num4 = -2015111694;
					}
					num = num3 ^ (int)(num2 * 1022907611);
					continue;
				}
				case 0u:
					m_Dict.Remove(aKey);
					result = jSONNode;
					num = ((int)num2 * -341164841) ^ 0x564A7217;
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
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 2047121062;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xED3E519u) % 8u)
				{
				case 7u:
					if (aIndex >= 0)
					{
						num = ((int)num2 * -518925333) ^ 0x4EAB3A64;
						continue;
					}
					num3 = 1;
					goto IL_001a;
				case 4u:
					result = null;
					num = 1469536963;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1723977345;
						num5 = 1723977345;
					}
					else
					{
						num4 = 1177229844;
						num5 = 1177229844;
					}
					num = num4 ^ ((int)num2 * -124254781);
					continue;
				}
				case 2u:
					num = (int)(num2 * 910608721) ^ -2059998618;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -1902754446) ^ -761022354;
					continue;
				case 0u:
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
					num = 1084182570;
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
				_ = -1516326697;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ -1040956713;
					uint num = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						result = null;
						_ = ((int)num * -1599965388) ^ -823450936;
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
			KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
			while (true)
			{
				IL_011b:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 2074910618;
					num2 = 2074910618;
				}
				else
				{
					num = 1997308998;
					num2 = 1997308998;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x35DF9E68u) % 8u)
					{
					case 7u:
						text = JSONClass.smethod_34(new string[5]
						{
							text,
							"\"",
							JSONNode.Escape(current.Key),
							"\":",
							JSONClass.smethod_33((object)current.Value)
						});
						num = 1976087033;
						continue;
					case 6u:
						current = enumerator.Current;
						num = 1947888152;
						continue;
					case 5u:
						text = JSONClass.smethod_32(text, ", ");
						num = (int)(num3 * 1270021126) ^ -1497918583;
						continue;
					case 4u:
						num = 1997308998;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (JSONClass.smethod_31(text) <= 2)
						{
							num4 = -552470223;
							num5 = -552470223;
						}
						else
						{
							num4 = -914947549;
							num5 = -914947549;
						}
						num = num4 ^ ((int)num3 * -1167397246);
						continue;
					}
					case 0u:
						num = ((int)num3 * -1766814619) ^ -327839405;
						continue;
					default:
						goto end_IL_00da;
					case 1u:
						break;
					case 2u:
						goto end_IL_00da;
					}
					goto IL_011b;
					continue;
					end_IL_00da:
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
				IL_0166:
				int num6 = 868184941;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num6 ^ 0x35DF9E68u) % 3u)
					{
					case 2u:
						goto IL_013a;
					default:
						goto end_IL_0148;
					case 0u:
						break;
					case 1u:
						goto end_IL_0148;
					}
					goto IL_0166;
					IL_013a:
					num6 = (int)((num3 * 1239662909) ^ 0x25284850);
					continue;
					end_IL_0148:
					break;
				}
				break;
			}
		}
		text = JSONClass.smethod_32(text, "}");
		string result = text;
		while (true)
		{
			int num7 = 1236356536;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0x35DF9E68u) % 3u)
				{
				case 2u:
					goto IL_017f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_017f:
				num7 = ((int)num3 * -1926166085) ^ -1960487264;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1660055606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7934E5Au) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_0171:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1173019742;
								num4 = -1173019742;
							}
							else
							{
								num3 = -935118157;
								num4 = -935118157;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF7934E5Au) % 8u)
								{
								case 7u:
									num3 = ((int)num2 * -1532282851) ^ -1091436244;
									continue;
								case 6u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = -2048195843;
									continue;
								case 4u:
								{
									int num5;
									int num6;
									if (JSONClass.smethod_31(text) > 3)
									{
										num5 = 999501405;
										num6 = 999501405;
									}
									else
									{
										num5 = 1100356656;
										num6 = 1100356656;
									}
									num3 = num5 ^ ((int)num2 * -523320941);
									continue;
								}
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -1567712269) ^ 0xB001C0D;
									continue;
								case 2u:
									num3 = -935118157;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1241092978;
									continue;
								default:
									goto end_IL_0130;
								case 5u:
									break;
								case 0u:
									goto end_IL_0130;
								}
								goto IL_0171;
								continue;
								end_IL_0130:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num7 = -886892721;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xF7934E5Au) % 4u)
							{
							case 3u:
								num7 = ((int)num2 * -1460302898) ^ 0x37C54B46;
								continue;
							case 1u:
								result = text;
								num7 = (int)((num2 * 1459162605) ^ 0x2DBE61C0);
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
				IL_0003:
				text = "{ ";
				num = ((int)num2 * -688169462) ^ 0x2382E34;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		string current = default(string);
		while (true)
		{
			int num = -179630069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B2445FFu) % 7u)
				{
				case 4u:
					num = ((int)num2 * -1128782245) ^ -489397436;
					continue;
				case 3u:
					num = (int)((num2 * 899093772) ^ 0x4214C5D6);
					continue;
				case 2u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 241683149) ^ 0xF7F6B43);
					continue;
				case 1u:
					JSONClass.smethod_36(aWriter, (byte)2);
					num = (int)(num2 * 655226023) ^ -634797650;
					continue;
				case 0u:
					num = (int)((num2 * 1620382644) ^ 0x7A1BCBCA);
					continue;
				case 5u:
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
							num3 = -670480898;
							num4 = -670480898;
						}
						else
						{
							num3 = -1983251591;
							num4 = -1983251591;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x8B2445FFu) % 9u)
							{
							case 8u:
								current = enumerator.Current;
								num3 = -264924446;
								continue;
							case 7u:
								num3 = (int)(num2 * 723933498) ^ -135097588;
								continue;
							case 6u:
								JSONClass.smethod_38(aWriter, current);
								num3 = (int)((num2 * 1366214588) ^ 0x5F962E7A);
								continue;
							case 5u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)((num2 * 1601819086) ^ 0x72BE70D0);
								continue;
							case 4u:
								num3 = ((int)num2 * -2049140476) ^ 0x75E8DD47;
								continue;
							case 1u:
								num3 = ((int)num2 * -1379473670) ^ -703138524;
								continue;
							case 0u:
								num3 = -1983251591;
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
				break;
			}
		}
	}

	public JSONClass()
	{
		while (true)
		{
			int num = 828793969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x278EF6B1u) % 3u)
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
				num = (int)((num2 * 1362250268) ^ 0x4BBC5F25);
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
