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
				int num = 82734653;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3DCB7B07u) % 6u)
					{
					case 4u:
						result = m_Dict[aKey];
						num = ((int)num2 * -571241378) ^ 0x79416FCD;
						continue;
					case 3u:
						result = new JSONLazyCreator(this, aKey);
						num = 128679389;
						continue;
					case 2u:
						flag = m_Dict.ContainsKey(aKey);
						num = ((int)num2 * -939589586) ^ 0x4CA82E5C;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1912652382;
							num4 = 1912652382;
						}
						else
						{
							num3 = 1860687445;
							num4 = 1860687445;
						}
						num = num3 ^ (int)(num2 * 1337064807);
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
			bool flag = m_Dict.ContainsKey(aKey);
			while (true)
			{
				int num = 753514184;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72C3EF66u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1189096666) ^ 0x5D958835;
						continue;
					case 4u:
						m_Dict.Add(aKey, value);
						num = 1527501929;
						continue;
					case 2u:
						num = ((int)num2 * -2121310111) ^ 0x64017573;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1155087245;
							num4 = -1155087245;
						}
						else
						{
							num3 = -605940117;
							num4 = -605940117;
						}
						num = num3 ^ ((int)num2 * -11942041);
						continue;
					}
					case 0u:
						m_Dict[aKey] = value;
						num = (int)((num2 * 1714632907) ^ 0x16F09CA7);
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
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
				int num = 1866642162;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x2C73C7A9u) % 9u)
					{
					case 8u:
						result = null;
						num = 797132617;
						continue;
					case 7u:
						num = (int)(num2 * 920581407) ^ -1485599873;
						continue;
					case 6u:
						if (aIndex >= 0)
						{
							num = ((int)num2 * -2247579) ^ 0x70A992A;
							continue;
						}
						num5 = 1;
						goto IL_0035;
					case 5u:
						result = null;
						num = (int)(num2 * 1661019191) ^ -1993836832;
						continue;
					case 2u:
						num5 = ((aIndex >= m_Dict.Count) ? 1 : 0);
						goto IL_0035;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -94990742;
							num4 = -94990742;
						}
						else
						{
							num3 = -503631798;
							num4 = -503631798;
						}
						num = num3 ^ (int)(num2 * 1588609723);
						continue;
					}
					case 0u:
						num = ((int)num2 * -1756274638) ^ 0x6925190D;
						continue;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0035:
						flag = (byte)num5 != 0;
						num = 322205304;
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
			int num2 = -1208920479;
			goto IL_003f;
			IL_003a:
			num2 = -10425613;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xE88860E0u) % 5u)
				{
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -387254078;
						num5 = -387254078;
					}
					else
					{
						num4 = -1884688721;
						num5 = -1884688721;
					}
					num2 = num4 ^ (int)(num3 * 1639038951);
					continue;
				}
				case 3u:
					num2 = (int)(num3 * 2088945965) ^ -2034908243;
					continue;
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
				int num = 1293692932;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x462E461Du) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1100398766) ^ 0x29065741);
						continue;
					case 1u:
						count = m_Dict.Count;
						num = ((int)num2 * -1528553696) ^ -1094511805;
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
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
			int num = 223745992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x257A81Du) % 11u)
				{
				case 10u:
					m_Dict[aKey] = aItem;
					num = ((int)num2 * -1018623416) ^ -2028223486;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (m_Dict.ContainsKey(aKey))
					{
						num5 = 1569200456;
						num6 = 1569200456;
					}
					else
					{
						num5 = 171841480;
						num6 = 171841480;
					}
					num = num5 ^ (int)(num2 * 278224776);
					continue;
				}
				case 8u:
					num = 2016393951;
					continue;
				case 7u:
					num = ((int)num2 * -1166073007) ^ -640739307;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2080776419;
						num4 = -2080776419;
					}
					else
					{
						num3 = -2007154167;
						num4 = -2007154167;
					}
					num = num3 ^ (int)(num2 * 1087527519);
					continue;
				}
				case 5u:
					num = (int)(num2 * 896591484) ^ -2119576814;
					continue;
				case 3u:
					m_Dict.Add(Guid.NewGuid().ToString(), aItem);
					num = 2016393951;
					continue;
				case 1u:
					flag = !JSONClass.smethod_30(aKey);
					num = ((int)num2 * -1147911128) ^ 0x2DAFD5ED;
					continue;
				case 0u:
					m_Dict.Add(aKey, aItem);
					num = 1988233910;
					continue;
				default:
					return;
				case 4u:
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
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 649497010;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5940A391u) % 8u)
				{
				case 7u:
					jSONNode = m_Dict[aKey];
					num = 1105050028;
					continue;
				case 6u:
					result = jSONNode;
					num = ((int)num2 * -2015138859) ^ 0x49965B66;
					continue;
				case 5u:
					m_Dict.Remove(aKey);
					num = ((int)num2 * -477369453) ^ -785518824;
					continue;
				case 4u:
					num = (int)(num2 * 757701494) ^ -253906344;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!m_Dict.ContainsKey(aKey))
					{
						num3 = -891871186;
						num4 = -891871186;
					}
					else
					{
						num3 = -694732719;
						num4 = -694732719;
					}
					num = num3 ^ ((int)num2 * -387350091);
					continue;
				}
				case 0u:
					result = null;
					num = (int)(num2 * 1875464636) ^ -247493771;
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

	public override JSONNode Remove(int aIndex)
	{
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1399299110;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xB9C2AF81u) % 8u)
				{
				case 7u:
					num3 = ((aIndex >= m_Dict.Count) ? 1 : 0);
					goto IL_0017;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1723547760;
						num5 = 1723547760;
					}
					else
					{
						num4 = 733966156;
						num5 = 733966156;
					}
					num = num4 ^ ((int)num2 * -1718286972);
					continue;
				}
				case 5u:
					result = null;
					num = ((int)num2 * -297673158) ^ 0x39D8AA3F;
					continue;
				case 3u:
					if (aIndex >= 0)
					{
						num = (int)(num2 * 924881030) ^ -25944740;
						continue;
					}
					num3 = 1;
					goto IL_0017;
				case 2u:
					num = ((int)num2 * -1692334558) ^ -794879447;
					continue;
				case 1u:
					result = null;
					num = -1330822741;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0017:
					flag = (byte)num3 != 0;
					num = -521483441;
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
		//IL_0027: Expected I4, but got Unknown
		//IL_0038: Incompatible stack heights: 0 vs 1
		//IL_0047: Incompatible stack heights: 0 vs 1
		//IL_004e: Incompatible stack heights: 0 vs 1
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
				_ = 1481061975;
				while (true)
				{
					_003F val = /*Error near IL_000e: Stack underflow*/^ 0x3BC5B20A;
					uint num = (uint)(int)val;
					switch (val % 4)
					{
					case 2:
						result = null;
						_ = ((int)num * -1509250060) ^ -983537791;
						continue;
					case 1:
						_ = (num * 1330961732) ^ 0x4E38BA18;
						continue;
					case 0:
						break;
					default:
						return result;
					case 3:
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
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1372553719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x560B5C40u) % 4u)
				{
				case 3u:
					text = "{";
					num = ((int)num2 * -1917907650) ^ 0x49E3314F;
					continue;
				case 1u:
					num = ((int)num2 * -1471308701) ^ 0x247E7C41;
					continue;
				case 0u:
					break;
				default:
				{
					using (Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator())
					{
						while (true)
						{
							IL_016d:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 351623718;
								num4 = 351623718;
							}
							else
							{
								num3 = 1255945101;
								num4 = 1255945101;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x560B5C40u) % 8u)
								{
								case 7u:
									num3 = (int)(num2 * 755275507) ^ -1303536439;
									continue;
								case 6u:
									current = enumerator.Current;
									flag = JSONClass.smethod_31(text) > 2;
									num3 = 528219120;
									continue;
								case 3u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = ((int)num2 * -789951685) ^ 0x5FC05298;
									continue;
								case 2u:
									num3 = 351623718;
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
									num3 = 1854314783;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 269693385;
										num6 = 269693385;
									}
									else
									{
										num5 = 1632155427;
										num6 = 1632155427;
									}
									num3 = num5 ^ (int)(num2 * 1548763908);
									continue;
								}
								default:
									goto end_IL_012c;
								case 4u:
									break;
								case 5u:
									goto end_IL_012c;
								}
								goto IL_016d;
								continue;
								end_IL_012c:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_32(text, "}");
					while (true)
					{
						int num7 = 22007031;
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x560B5C40u) % 4u)
							{
							case 3u:
								result = text;
								num7 = (int)((num2 * 1541069557) ^ 0x466A6F8F);
								continue;
							case 0u:
								num7 = ((int)num2 * -212975612) ^ 0x34255AE1;
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
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		KeyValuePair<string, JSONNode> current = default(KeyValuePair<string, JSONNode>);
		bool flag = default(bool);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1794477509;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25F493ABu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					Dictionary<string, JSONNode>.Enumerator enumerator = m_Dict.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0170:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 752997035;
								num4 = 752997035;
							}
							else
							{
								num3 = 546562469;
								num4 = 546562469;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x25F493ABu) % 8u)
								{
								case 7u:
									text = JSONClass.smethod_35(text, "\n", aPrefix, "   ");
									text = JSONClass.smethod_34(new string[5]
									{
										text,
										"\"",
										JSONNode.Escape(current.Key),
										"\" : ",
										current.Value.ToString(JSONClass.smethod_32(aPrefix, "   "))
									});
									num3 = 1623702288;
									continue;
								case 6u:
									current = enumerator.Current;
									num3 = 2139797657;
									continue;
								case 5u:
									num3 = 546562469;
									continue;
								case 4u:
									text = JSONClass.smethod_32(text, ", ");
									num3 = (int)(num2 * 1864429424) ^ -2010504148;
									continue;
								case 2u:
									flag = JSONClass.smethod_31(text) > 3;
									num3 = ((int)num2 * -1168994565) ^ -363925956;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if (flag)
									{
										num5 = 1737387436;
										num6 = 1737387436;
									}
									else
									{
										num5 = 390536831;
										num6 = 390536831;
									}
									num3 = num5 ^ ((int)num2 * -1484806685);
									continue;
								}
								default:
									goto end_IL_012f;
								case 3u:
									break;
								case 0u:
									goto end_IL_012f;
								}
								goto IL_0170;
								continue;
								end_IL_012f:
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
							IL_01bb:
							int num7 = 1762506121;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x25F493ABu) % 3u)
								{
								case 1u:
									goto IL_018f;
								default:
									goto end_IL_019d;
								case 0u:
									break;
								case 2u:
									goto end_IL_019d;
								}
								goto IL_01bb;
								IL_018f:
								num7 = (int)((num2 * 1504461157) ^ 0x2FC594AB);
								continue;
								end_IL_019d:
								break;
							}
							break;
						}
					}
					text = JSONClass.smethod_35(text, "\n", aPrefix, "}");
					while (true)
					{
						int num8 = 1478930796;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x25F493ABu) % 4u)
							{
							case 3u:
								result = text;
								num8 = (int)((num2 * 1248872477) ^ 0x337BFF9E);
								continue;
							case 2u:
								num8 = (int)(num2 * 665999795) ^ -1649982700;
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
				num = (int)(num2 * 388059432) ^ -1632544693;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONClass.smethod_36(aWriter, (byte)2);
		string current = default(string);
		while (true)
		{
			int num = -529968050;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xACA58B47u) % 5u)
				{
				case 3u:
					JSONClass.smethod_37(aWriter, m_Dict.Count);
					num = (int)((num2 * 773868037) ^ 0x55C06C9E);
					continue;
				case 2u:
					num = ((int)num2 * -2023022980) ^ -1996008720;
					continue;
				case 1u:
					num = (int)(num2 * 1921315471) ^ -1875573112;
					continue;
				case 4u:
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
							num3 = -1394289322;
							num4 = -1394289322;
						}
						else
						{
							num3 = -1264092742;
							num4 = -1264092742;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xACA58B47u) % 9u)
							{
							case 8u:
								current = enumerator.Current;
								num3 = -1542199574;
								continue;
							case 7u:
								JSONClass.smethod_38(aWriter, current);
								num3 = ((int)num2 * -1430335464) ^ -111144253;
								continue;
							case 5u:
								num3 = -1264092742;
								continue;
							case 4u:
								num3 = ((int)num2 * -1038123897) ^ -433205663;
								continue;
							case 3u:
								num3 = (int)(num2 * 1879230817) ^ -565410562;
								continue;
							case 1u:
								num3 = (int)(num2 * 628760347) ^ -1357487715;
								continue;
							case 0u:
								m_Dict[current].Serialize(aWriter);
								num3 = (int)(num2 * 1243556437) ^ -673761050;
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
