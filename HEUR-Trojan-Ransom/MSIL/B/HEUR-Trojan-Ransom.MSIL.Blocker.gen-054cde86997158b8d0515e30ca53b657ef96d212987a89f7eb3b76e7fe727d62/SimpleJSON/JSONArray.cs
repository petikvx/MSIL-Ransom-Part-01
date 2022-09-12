using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SimpleJSON;

public class JSONArray : JSONNode, IEnumerable
{
	private List<JSONNode> m_List = new List<JSONNode>();

	public override JSONNode this[int aIndex]
	{
		get
		{
			if (aIndex >= 0)
			{
				goto IL_000a;
			}
			int num = 1;
			goto IL_00aa;
			IL_00aa:
			bool flag = (byte)num != 0;
			int num2 = -1222341052;
			goto IL_006c;
			IL_000a:
			num2 = -1155831611;
			goto IL_006c;
			IL_006c:
			JSONNode result = default(JSONNode);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAEC531BDu) % 7u)
				{
				case 6u:
					break;
				case 5u:
					result = new JSONLazyCreator(this);
					num2 = (int)(num3 * 2049955699) ^ -593138605;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1523295714;
						num5 = -1523295714;
					}
					else
					{
						num4 = -451850140;
						num5 = -451850140;
					}
					num2 = num4 ^ ((int)num3 * -1209209299);
					continue;
				}
				case 1u:
					result = m_List[aIndex];
					num2 = -438664868;
					continue;
				case 0u:
					num2 = ((int)num3 * -1320973662) ^ -1788805468;
					continue;
				case 3u:
					goto IL_0099;
				default:
					return result;
				}
				break;
			}
			goto IL_000a;
			IL_0099:
			num = ((aIndex >= m_List.Count) ? 1 : 0);
			goto IL_00aa;
		}
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = -1508762978;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x93212EABu) % 8u)
					{
					case 7u:
						m_List[aIndex] = value;
						num = -1260049456;
						continue;
					case 6u:
						num = (int)(num2 * 1751584205) ^ -1823784930;
						continue;
					case 5u:
						if (aIndex >= 0)
						{
							num = (int)(num2 * 1056111278) ^ -873679331;
							continue;
						}
						num3 = 1;
						goto IL_003d;
					case 4u:
						m_List.Add(value);
						num = ((int)num2 * -1078169645) ^ -1633151151;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (flag)
						{
							num4 = 1365492624;
							num5 = 1365492624;
						}
						else
						{
							num4 = 886676915;
							num5 = 886676915;
						}
						num = num4 ^ (int)(num2 * 190220951);
						continue;
					}
					case 0u:
						num3 = ((aIndex >= m_List.Count) ? 1 : 0);
						goto IL_003d;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
						IL_003d:
						flag = (byte)num3 != 0;
						num = -2121604350;
						continue;
					}
					break;
				}
			}
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = -1297178399;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1BBE2D8u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = ((int)num2 * -1324950048) ^ -684992348;
				}
			}
		}
		set
		{
			m_List.Add(value);
		}
	}

	public override int Count => m_List.Count;

	public override IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__13 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__13(-2);
			while (true)
			{
				int num = 117754010;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x197BC5B9u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)((num2 * 849544545) ^ 0x557A8A5E);
				}
			}
		}
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		m_List.Add(aItem);
		while (true)
		{
			int num = 720716025;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4354B08u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1777217448) ^ 0x1994923B;
			}
		}
	}

	public override JSONNode Remove(int aIndex)
	{
		if (aIndex >= 0)
		{
			goto IL_004e;
		}
		int num = 1;
		goto IL_00c6;
		IL_00c6:
		bool flag = (byte)num != 0;
		int num2 = -1843541105;
		goto IL_0084;
		IL_004e:
		num2 = -2048040316;
		goto IL_0084;
		IL_0084:
		JSONNode jSONNode = default(JSONNode);
		JSONNode result = default(JSONNode);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xA53D3AC0u) % 8u)
			{
			case 7u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1507633236;
					num5 = -1507633236;
				}
				else
				{
					num4 = -1610827198;
					num5 = -1610827198;
				}
				num2 = num4 ^ (int)(num3 * 37433734);
				continue;
			}
			case 6u:
				jSONNode = m_List[aIndex];
				m_List.RemoveAt(aIndex);
				num2 = -477587374;
				continue;
			case 5u:
				break;
			case 2u:
				result = jSONNode;
				num2 = ((int)num3 * -27916906) ^ -667027785;
				continue;
			case 1u:
				num2 = ((int)num3 * -231853546) ^ -1974066307;
				continue;
			case 0u:
				result = null;
				num2 = (int)(num3 * 1895168101) ^ -1279891279;
				continue;
			case 4u:
				goto IL_00b5;
			default:
				return result;
			}
			break;
		}
		goto IL_004e;
		IL_00b5:
		num = ((aIndex >= m_List.Count) ? 1 : 0);
		goto IL_00c6;
	}

	public override JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1356590816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96B9AB35u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				m_List.Remove(aNode);
				result = aNode;
				num = ((int)num2 * -900910393) ^ -883301106;
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetEnumerator_003Ed__14(0)
		{
			_003C_003E4__this = this
		};
	}

	public override string ToString()
	{
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 603006366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x46CF987Cu) % 4u)
				{
				case 2u:
					string_ = "[ ";
					num = (int)(num2 * 1853459789) ^ -915573337;
					continue;
				case 1u:
					num = ((int)num2 * -2077790090) ^ 0x48C4044D;
					continue;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_014e:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1809054459;
								num4 = 1809054459;
							}
							else
							{
								num3 = 2021465265;
								num4 = 2021465265;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x46CF987Cu) % 9u)
								{
								case 8u:
									num3 = 1809054459;
									continue;
								case 6u:
									string_ = JSONArray.smethod_31(string_, JSONArray.smethod_32((object)current));
									num3 = 1410507076;
									continue;
								case 5u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 1546677042) ^ 0x1E06CCD3);
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = 541840136;
									continue;
								case 2u:
									num3 = ((int)num2 * -1233997541) ^ 0x5D8B1D27;
									continue;
								case 1u:
									flag = JSONArray.smethod_30(string_) > 2;
									num3 = ((int)num2 * -61592873) ^ 0xC58BCCF;
									continue;
								case 0u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 124454557;
										num6 = 124454557;
									}
									else
									{
										num5 = 1966698362;
										num6 = 1966698362;
									}
									num3 = num5 ^ (int)(num2 * 588219319);
									continue;
								}
								default:
									goto end_IL_0108;
								case 4u:
									break;
								case 7u:
									goto end_IL_0108;
								}
								goto IL_014e;
								continue;
								end_IL_0108:
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
							IL_0199:
							int num7 = 1754192945;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x46CF987Cu) % 3u)
								{
								case 1u:
									goto IL_016d;
								default:
									goto end_IL_017b;
								case 2u:
									break;
								case 0u:
									goto end_IL_017b;
								}
								goto IL_0199;
								IL_016d:
								num7 = (int)(num2 * 1337134740) ^ -214837663;
								continue;
								end_IL_017b:
								break;
							}
							break;
						}
					}
					string_ = JSONArray.smethod_31(string_, " ]");
					while (true)
					{
						int num8 = 1245105577;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x46CF987Cu) % 4u)
							{
							case 3u:
								num8 = ((int)num2 * -1148070674) ^ 0x8AE6B7A;
								continue;
							case 1u:
								result = string_;
								num8 = (int)((num2 * 1632159359) ^ 0x32CC0EE8);
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
		string string_ = default(string);
		JSONNode current = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 1568992032;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B8B437Cu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					List<JSONNode>.Enumerator enumerator = m_List.GetEnumerator();
					try
					{
						while (true)
						{
							IL_015a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 696506245;
								num4 = 696506245;
							}
							else
							{
								num3 = 2016820059;
								num4 = 2016820059;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x3B8B437Cu) % 9u)
								{
								case 8u:
									string_ = JSONArray.smethod_31(string_, current.ToString(JSONArray.smethod_31(aPrefix, "   ")));
									num3 = ((int)num2 * -739909741) ^ 0x36289E72;
									continue;
								case 7u:
									num3 = 696506245;
									continue;
								case 6u:
									current = enumerator.Current;
									flag = JSONArray.smethod_30(string_) > 3;
									num3 = 360141383;
									continue;
								case 5u:
									num3 = (int)(num2 * 1420491096) ^ -196843098;
									continue;
								case 3u:
									string_ = JSONArray.smethod_31(string_, ", ");
									num3 = (int)((num2 * 50514729) ^ 0x7D21A2D2);
									continue;
								case 2u:
								{
									int num5;
									int num6;
									if (!flag)
									{
										num5 = 614362407;
										num6 = 614362407;
									}
									else
									{
										num5 = 1933952993;
										num6 = 1933952993;
									}
									num3 = num5 ^ ((int)num2 * -675781866);
									continue;
								}
								case 0u:
									string_ = JSONArray.smethod_33(string_, "\n", aPrefix, "   ");
									num3 = 966963776;
									continue;
								default:
									goto end_IL_0114;
								case 4u:
									break;
								case 1u:
									goto end_IL_0114;
								}
								goto IL_015a;
								continue;
								end_IL_0114:
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
							IL_01a5:
							int num7 = 1262632981;
							while (true)
							{
								switch ((num2 = (uint)num7 ^ 0x3B8B437Cu) % 3u)
								{
								case 1u:
									goto IL_0179;
								default:
									goto end_IL_0187;
								case 2u:
									break;
								case 0u:
									goto end_IL_0187;
								}
								goto IL_01a5;
								IL_0179:
								num7 = (int)(num2 * 1096190504) ^ -52387356;
								continue;
								end_IL_0187:
								break;
							}
							break;
						}
					}
					return JSONArray.smethod_33(string_, "\n", aPrefix, "]");
				}
				}
				break;
				IL_0003:
				string_ = "[ ";
				num = ((int)num2 * -762026780) ^ -525723336;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONArray.smethod_34(aWriter, (byte)1);
		int num3 = default(int);
		while (true)
		{
			int num = 1810094709;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EA298C9u) % 10u)
				{
				case 9u:
					m_List[num3].Serialize(aWriter);
					num = ((int)num2 * -592025266) ^ 0x3A9B9BC5;
					continue;
				case 8u:
					JSONArray.smethod_35(aWriter, m_List.Count);
					num = (int)((num2 * 1364651246) ^ 0x773BE426);
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1014190823) ^ 0xEE2E251;
					continue;
				case 6u:
					num = 132806776;
					continue;
				case 4u:
					num = ((int)num2 * -1476367440) ^ -273029377;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < m_List.Count)
					{
						num = 831869633;
						num4 = 831869633;
					}
					else
					{
						num = 380425620;
						num4 = 380425620;
					}
					continue;
				}
				case 2u:
					num3++;
					num = (int)(num2 * 2032597192) ^ -574173576;
					continue;
				case 1u:
					num = ((int)num2 * -862670818) ^ 0xF309A5A;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	static int smethod_30(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_31(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static string smethod_32(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_33(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	static void smethod_34(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_35(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}
}
