using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SimpleJSON;

public class JSONNode
{
	public virtual JSONNode this[int aIndex]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual JSONNode this[string aKey]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Value
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 2006813471;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x877FDD6u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1007730770) ^ 0x6FC1E35D);
						continue;
					case 1u:
						result = "";
						num = (int)((num2 * 1305220786) ^ 0x5F4D2B66);
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
		}
	}

	public virtual int Count
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = -491766984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9FAD9AEAu) % 4u)
					{
					case 2u:
						result = 0;
						num = (int)((num2 * 699218641) ^ 0x33EA7989);
						continue;
					case 1u:
						num = ((int)num2 * -1278916484) ^ -32449794;
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
	}

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -405989628;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9805EAFu) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1731165217) ^ -1447773734;
						continue;
					case 0u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -582341782) ^ -1121530010;
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

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1630758384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA38F9CAu) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_DeepChilds_003Ed__;
					num = ((int)num2 * -1301783900) ^ 0x1CB92C5B;
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result = 0;
			int result2 = default(int);
			while (true)
			{
				int num = 177909069;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6682F081u) % 5u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (!int.TryParse(Value, out result))
						{
							num3 = 30589687;
							num4 = 30589687;
						}
						else
						{
							num3 = 65995397;
							num4 = 65995397;
						}
						num = num3 ^ ((int)num2 * -1821761580);
						continue;
					}
					case 3u:
						result2 = 0;
						num = 219354480;
						continue;
					case 1u:
						result2 = result;
						num = (int)((num2 * 1551998557) ^ 0x4F04EFD4);
						continue;
					case 0u:
						break;
					default:
						return result2;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1414271151;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81674B2Au) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					Value = value.ToString();
					num = (int)(num2 * 826000789) ^ -195045006;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = default(float);
			float result2 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = -385784566;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD4D1910u) % 9u)
					{
					case 7u:
						num = (int)(num2 * 2120219652) ^ -1365203134;
						continue;
					case 6u:
						result = 0f;
						num = -1499427684;
						continue;
					case 5u:
						result = result2;
						num = (int)((num2 * 1916789805) ^ 0x415287A);
						continue;
					case 4u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -635026854) ^ -784669215;
						continue;
					case 3u:
						result2 = 0f;
						num = ((int)num2 * -292973183) ^ -2057898431;
						continue;
					case 2u:
						num = ((int)num2 * -1804640728) ^ -1359360442;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1724244931;
							num4 = 1724244931;
						}
						else
						{
							num3 = 97017132;
							num4 = 97017132;
						}
						num = num3 ^ ((int)num2 * -1564399596);
						continue;
					}
					case 8u:
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
			Value = value.ToString();
			while (true)
			{
				int num = -52768661;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED85B3ABu) % 3u)
					{
					case 1u:
						goto IL_000f;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000f:
					num = (int)((num2 * 1801861473) ^ 0x35E494CF);
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			double result2 = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = -100876344;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0DD7F34u) % 8u)
					{
					case 7u:
						result2 = result;
						num = (int)((num2 * 872514861) ^ 0x5850F99D);
						continue;
					case 6u:
						num = ((int)num2 * -801513870) ^ 0x4886453;
						continue;
					case 5u:
						result2 = 0.0;
						num = -222499910;
						continue;
					case 4u:
						flag = double.TryParse(Value, out result);
						num = (int)((num2 * 984045189) ^ 0x2044EDF1);
						continue;
					case 2u:
						num = (int)(num2 * 729808744) ^ -1050154817;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -995091545;
							num4 = -995091545;
						}
						else
						{
							num3 = -1647345283;
							num4 = -1647345283;
						}
						num = num3 ^ ((int)num2 * -1070225180);
						continue;
					}
					case 0u:
						break;
					default:
						return result2;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 206045757;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x27896335u) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					Value = value.ToString();
					num = (int)(num2 * 839599934) ^ -1209089114;
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = default(bool);
			bool result2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = -1043834066;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB75BAC6Cu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -2094763939) ^ -678838618;
						continue;
					case 5u:
						result = result2;
						num = (int)(num2 * 1560879005) ^ -294761102;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1617404040;
							num4 = 1617404040;
						}
						else
						{
							num3 = 2093823325;
							num4 = 2093823325;
						}
						num = num3 ^ ((int)num2 * -1814718245);
						continue;
					}
					case 3u:
						num = ((int)num2 * -483532472) ^ 0x2B001DCD;
						continue;
					case 2u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -345411157) ^ 0xEAA54A6;
						continue;
					case 0u:
						result = !JSONNode.smethod_1(Value);
						num = -1232026297;
						continue;
					case 6u:
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
			Value = (value ? "true" : "false");
			while (true)
			{
				int num = -835102117;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5486A5Fu) % 3u)
					{
					case 1u:
						goto IL_0017;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0017:
					num = ((int)num2 * -2050453900) ^ -1996152886;
				}
			}
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -83974507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D2D75C7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -649436856) ^ -551303030;
						continue;
					case 2u:
						result = this as JSONArray;
						num = ((int)num2 * -457559803) ^ -560525990;
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -1301996398;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9A74CD8u) % 4u)
					{
					case 2u:
						result = this as JSONClass;
						num = (int)((num2 * 2129335414) ^ 0x3C01AF1);
						continue;
					case 1u:
						num = ((int)num2 * -475166510) ^ -921133263;
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

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 1259933173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1442D5E9u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0003:
				Add("", aItem);
				num = ((int)num2 * -1572059762) ^ -650764939;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -2031897663;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C2EE50Eu) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0004:
				num = (int)((num2 * 662588718) ^ 0x4501F95F);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 147624188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B7315B2u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = aNode;
				num = (int)((num2 * 363719594) ^ 0x50CAF2CF);
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 1156340647;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51468160u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = ((int)num2 * -2004764595) ^ 0x179A594D;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		return "JSONNode";
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1067265037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA880B1B9u) % 3u)
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
				result = new JSONData(s);
				num = (int)((num2 * 860120087) ^ 0x1F357BE2);
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		if (!(d == null))
		{
			goto IL_001b;
		}
		object obj = null;
		goto IL_0047;
		IL_0047:
		string result = (string)obj;
		int num = -1907843281;
		goto IL_0020;
		IL_001b:
		num = -1546612146;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xEED92081u) % 4u)
			{
			case 2u:
				num = ((int)num2 * -1993250888) ^ 0x3E78BF08;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_001b;
		IL_0041:
		obj = d.Value;
		goto IL_0047;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1537582142;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x5E57C811u) % 7u)
				{
				case 6u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_000f;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1041126439;
						num5 = -1041126439;
					}
					else
					{
						num4 = -1662147018;
						num5 = -1662147018;
					}
					num = num4 ^ (int)(num2 * 739127667);
					continue;
				}
				case 4u:
					result = true;
					num = ((int)num2 * -228249931) ^ 0x277150CB;
					continue;
				case 2u:
					if (b == null)
					{
						num = ((int)num2 * -1917079255) ^ 0x6398721D;
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 1u:
					result = (object)a == b;
					num = 379455437;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_000f:
					flag = (byte)num3 != 0;
					num = 195830018;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1730761537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CB03178u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1308843686) ^ 0x5A92B38B;
					continue;
				case 1u:
					result = !(a == b);
					num = (int)(num2 * 327263020) ^ -23754026;
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

	public override bool Equals(object obj)
	{
		bool result = (object)this == obj;
		while (true)
		{
			int num = -1363578146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6A06714u) % 3u)
				{
				case 2u:
					goto IL_0007;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0007:
				num = ((int)num2 * -1165777666) ^ -1826458542;
			}
		}
	}

	public override int GetHashCode()
	{
		return this.method_0();
	}

	internal static string Escape(string aText)
	{
		string text = "";
		int num3 = default(int);
		string string_ = default(string);
		char c = default(char);
		char c2 = default(char);
		string result = default(string);
		while (true)
		{
			int num = -887621062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D70BFE3u) % 26u)
				{
				case 25u:
					num = ((int)num2 * -55881501) ^ -1914100626;
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1119145083;
					continue;
				case 23u:
					num = (int)(num2 * 1312357773) ^ -1726884122;
					continue;
				case 22u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -214865428;
						num5 = -214865428;
					}
					else
					{
						num = -44976619;
						num5 = -44976619;
					}
					continue;
				}
				case 21u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -2069042149) ^ -178872167;
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1705377323;
					continue;
				case 19u:
				{
					int num6;
					if (c == '"')
					{
						num = -1502264471;
						num6 = -1502264471;
					}
					else
					{
						num = -231424662;
						num6 = -231424662;
					}
					continue;
				}
				case 18u:
				{
					c2 = JSONNode.smethod_2(string_, num3);
					char c3 = c2;
					c = c3;
					switch (c)
					{
					case '\b':
						goto IL_00f5;
					case '\t':
						goto IL_010b;
					case '\n':
						goto IL_0121;
					case '\v':
						goto IL_0137;
					case '\f':
						goto IL_014f;
					case '\r':
						goto IL_0165;
					}
					num = -739737056;
					continue;
				}
				case 6u:
					goto IL_00f5;
				case 3u:
					goto IL_010b;
				case 10u:
					goto IL_0121;
				case 4u:
					goto IL_0137;
				case 16u:
					goto IL_014f;
				case 1u:
					goto IL_0165;
				case 17u:
					num = (int)((num2 * 1234039718) ^ 0x12B4DFE1);
					continue;
				case 15u:
					num = ((int)num2 * -1959187723) ^ -214885852;
					continue;
				case 14u:
					num = ((int)num2 * -477514372) ^ -1847058755;
					continue;
				case 13u:
					result = text;
					num = (int)(num2 * 219291415) ^ -1995999712;
					continue;
				case 11u:
					num = ((int)num2 * -901333317) ^ 0x235B349A;
					continue;
				case 9u:
				{
					int num4;
					if (c != '\\')
					{
						num = -1891922980;
						num4 = -1891922980;
					}
					else
					{
						num = -2133925447;
						num4 = -2133925447;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -232357387) ^ 0x6D6A8F37;
					continue;
				case 5u:
					num = (int)(num2 * 1394226238) ^ -382793158;
					continue;
				case 2u:
					num3++;
					num = -354215079;
					continue;
				case 0u:
					num = ((int)num2 * -2147360871) ^ 0x553FBED7;
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_0165:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1705377323;
					continue;
					IL_014f:
					text = JSONNode.smethod_3(text, "\\f");
					num = -86566742;
					continue;
					IL_0137:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -212699026;
					continue;
					IL_0121:
					text = JSONNode.smethod_3(text, "\\n");
					num = -667836495;
					continue;
					IL_010b:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1705377323;
					continue;
					IL_00f5:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1748260772;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag12 = default(bool);
		string text = default(string);
		char c4 = default(char);
		string text2 = default(string);
		bool flag3 = default(bool);
		char c3 = default(char);
		char c2 = default(char);
		char c = default(char);
		bool flag14 = default(bool);
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		int num7 = default(int);
		bool flag7 = default(bool);
		string s = default(string);
		bool flag15 = default(bool);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		bool flag16 = default(bool);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1420705815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5D98E18u) % 153u)
				{
				case 152u:
				{
					int num57;
					int num58;
					if (!flag12)
					{
						num57 = -1654837759;
						num58 = -1654837759;
					}
					else
					{
						num57 = -508564699;
						num58 = -508564699;
					}
					num = num57 ^ (int)(num2 * 998945158);
					continue;
				}
				case 151u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 651187688) ^ 0x5F6927A7);
					continue;
				case 150u:
					num = ((int)num2 * -1929014452) ^ 0x59BAF66A;
					continue;
				case 149u:
				{
					int num51;
					if (c4 == 'n')
					{
						num = -1353921221;
						num51 = -1353921221;
					}
					else
					{
						num = -986836994;
						num51 = -986836994;
					}
					continue;
				}
				case 148u:
				{
					text2 = "";
					int num53;
					int num54;
					if (stack.Count <= 0)
					{
						num53 = 96569980;
						num54 = 96569980;
					}
					else
					{
						num53 = 447465816;
						num54 = 447465816;
					}
					num = num53 ^ ((int)num2 * -1373672966);
					continue;
				}
				case 147u:
					num = ((int)num2 * -203747179) ^ -1619586297;
					continue;
				case 146u:
				{
					int num10;
					int num11;
					if (!flag3)
					{
						num10 = -1585866513;
						num11 = -1585866513;
					}
					else
					{
						num10 = -1648290287;
						num11 = -1648290287;
					}
					num = num10 ^ (int)(num2 * 1045079696);
					continue;
				}
				case 145u:
					num = (int)((num2 * 1663104689) ^ 0x5DE770C4);
					continue;
				case 144u:
					c3 = c2;
					num = ((int)num2 * -1281000629) ^ 0x3231BAC1;
					continue;
				case 143u:
					num = -870998225;
					continue;
				case 142u:
				{
					int num50;
					if ((uint)c > 93u)
					{
						num = -688398681;
						num50 = -688398681;
					}
					else
					{
						num = -1030529683;
						num50 = -1030529683;
					}
					continue;
				}
				case 141u:
				{
					int num42;
					int num43;
					if (!flag14)
					{
						num42 = -2043723505;
						num43 = -2043723505;
					}
					else
					{
						num42 = -1163235837;
						num43 = -1163235837;
					}
					num = num42 ^ ((int)num2 * -862094104);
					continue;
				}
				case 140u:
					result = jSONNode;
					num = -540772327;
					continue;
				case 139u:
					num = (int)((num2 * 1932155650) ^ 0x7EE04DFF);
					continue;
				case 138u:
					switch (c)
					{
					case '[':
						goto IL_01b6;
					case '\\':
						goto IL_01c4;
					case ']':
						goto IL_01d6;
					}
					num = -1419520661;
					continue;
				case 59u:
					goto IL_01b6;
				case 78u:
					goto IL_01c4;
				case 97u:
					goto IL_01d6;
				case 20u:
				case 21u:
				case 33u:
				case 70u:
				case 137u:
					num7++;
					num = -717898352;
					continue;
				case 136u:
					num = ((int)num2 * -1564153207) ^ 0x61776DE2;
					continue;
				case 135u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = -809212587;
					continue;
				case 134u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -648724783) ^ -1046659323;
					continue;
				case 133u:
					num = ((int)num2 * -1343137062) ^ 0x3543127B;
					continue;
				case 132u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 1969202999) ^ -1530293890;
					continue;
				case 131u:
					num = (int)(num2 * 560758313) ^ -1729395136;
					continue;
				case 130u:
					num = ((int)num2 * -1922910003) ^ -1420552934;
					continue;
				case 129u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)(num2 * 350922317) ^ -902881302;
					continue;
				case 128u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 32404218) ^ 0x22A33063);
					continue;
				case 127u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = ((int)num2 * -1687373059) ^ 0x55210961;
					continue;
				case 126u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num7);
					c = c5;
					int num62;
					int num63;
					if ((uint)c > 44u)
					{
						num62 = 137998403;
						num63 = 137998403;
					}
					else
					{
						num62 = 1626603925;
						num63 = 1626603925;
					}
					num = num62 ^ ((int)num2 * -826502672);
					continue;
				}
				case 125u:
					num7 += 4;
					num = ((int)num2 * -1625875945) ^ -361380538;
					continue;
				case 124u:
					num = (int)(num2 * 1303062528) ^ -1144710986;
					continue;
				case 122u:
				{
					int num56;
					if (c == '}')
					{
						num = -550774162;
						num56 = -550774162;
					}
					else
					{
						num = -183028410;
						num56 = -183028410;
					}
					continue;
				}
				case 121u:
					text = "";
					num = -778064986;
					continue;
				case 120u:
				{
					int num49;
					if (c == ' ')
					{
						num = -2119950555;
						num49 = -2119950555;
					}
					else
					{
						num = -1102483047;
						num49 = -1102483047;
					}
					continue;
				}
				case 119u:
				{
					int num46;
					if (stack.Count != 0)
					{
						num = -1924895388;
						num46 = -1924895388;
					}
					else
					{
						num = -120797085;
						num46 = -120797085;
					}
					continue;
				}
				case 118u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -52534871;
					continue;
				case 117u:
					num = ((int)num2 * -213352802) ^ 0x4911C47F;
					continue;
				case 116u:
				{
					int num39;
					if (c != '{')
					{
						num = -613758752;
						num39 = -613758752;
					}
					else
					{
						num = -1798741846;
						num39 = -1798741846;
					}
					continue;
				}
				case 115u:
				{
					int num35;
					int num36;
					if (!flag15)
					{
						num35 = 793818260;
						num36 = 793818260;
					}
					else
					{
						num35 = 1488829690;
						num36 = 1488829690;
					}
					num = num35 ^ (int)(num2 * 1923183371);
					continue;
				}
				case 114u:
				{
					int num30;
					int num31;
					if (!flag9)
					{
						num30 = -2019096143;
						num31 = -2019096143;
					}
					else
					{
						num30 = -2004998857;
						num31 = -2004998857;
					}
					num = num30 ^ ((int)num2 * -976872332);
					continue;
				}
				case 113u:
				{
					int num26;
					int num27;
					if (!flag2)
					{
						num26 = -1120928934;
						num27 = -1120928934;
					}
					else
					{
						num26 = -552765918;
						num27 = -552765918;
					}
					num = num26 ^ ((int)num2 * -1469179606);
					continue;
				}
				case 112u:
				{
					int num22;
					int num23;
					if (flag7)
					{
						num22 = 103332922;
						num23 = 103332922;
					}
					else
					{
						num22 = 197059722;
						num23 = 197059722;
					}
					num = num22 ^ (int)(num2 * 131620717);
					continue;
				}
				case 111u:
					num = (int)(num2 * 1769316404) ^ -247638524;
					continue;
				case 110u:
				{
					int num17;
					int num18;
					if (!(jSONNode is JSONArray))
					{
						num17 = -1125987332;
						num18 = -1125987332;
					}
					else
					{
						num17 = -970915578;
						num18 = -970915578;
					}
					num = num17 ^ ((int)num2 * -1661674789);
					continue;
				}
				case 109u:
				{
					int num14;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -697476016;
						num14 = -697476016;
					}
					else
					{
						num = -1812175173;
						num14 = -1812175173;
					}
					continue;
				}
				case 108u:
				{
					int num5;
					int num6;
					if ((uint)c <= 32u)
					{
						num5 = -926326455;
						num6 = -926326455;
					}
					else
					{
						num5 = -2108474949;
						num6 = -2108474949;
					}
					num = num5 ^ (int)(num2 * 870063372);
					continue;
				}
				case 107u:
					num = -329932578;
					continue;
				case 106u:
				{
					int num60;
					int num61;
					if (!flag16)
					{
						num60 = 1533852787;
						num61 = 1533852787;
					}
					else
					{
						num60 = 1426951557;
						num61 = 1426951557;
					}
					num = num60 ^ (int)(num2 * 939235644);
					continue;
				}
				case 105u:
					c2 = JSONNode.smethod_2(aJSON, num7);
					num = ((int)num2 * -1521468731) ^ -1334263462;
					continue;
				case 104u:
					text = "";
					text2 = "";
					num = -1459430733;
					continue;
				case 103u:
					num = (int)((num2 * 203127093) ^ 0x229137F0);
					continue;
				case 102u:
					num = ((int)num2 * -114599098) ^ -529554965;
					continue;
				case 101u:
					text2 = JSONNode.smethod_3(text2, c2.ToString());
					num = -1373435948;
					continue;
				case 100u:
					text = "";
					text2 = "";
					jSONNode = stack.Peek();
					num = -616742999;
					continue;
				case 99u:
					num = (int)((num2 * 1722374228) ^ 0x71419DAE);
					continue;
				case 98u:
				{
					int num59;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -1694108956;
						num59 = -1694108956;
					}
					else
					{
						num = -1473675439;
						num59 = -1473675439;
					}
					continue;
				}
				case 96u:
				{
					int num55;
					if (c != ',')
					{
						num = -1393186557;
						num55 = -1393186557;
					}
					else
					{
						num = -1884110004;
						num55 = -1884110004;
					}
					continue;
				}
				case 95u:
					flag16 = num7 < JSONNode.smethod_4(aJSON);
					num = -288632998;
					continue;
				case 94u:
					num = ((int)num2 * -1998315724) ^ 0x464AA7D6;
					continue;
				case 93u:
					jSONNode = null;
					num = (int)((num2 * 1786088852) ^ 0x3C03637F);
					continue;
				case 92u:
					num = (int)((num2 * 868691248) ^ 0x5AA721D9);
					continue;
				case 91u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_070b;
					case '\t':
						goto IL_071e;
					case '\v':
					case '\f':
						goto IL_072c;
					}
					goto case 20u;
				case 7u:
					goto IL_071e;
				case 49u:
					goto IL_072c;
				case 90u:
					stack.Push(new JSONArray());
					num = -872761028;
					continue;
				case 89u:
					num7 = 0;
					num = (int)((num2 * 852740970) ^ 0x2FBCE795);
					continue;
				case 88u:
					num = ((int)num2 * -1054161340) ^ 0x1A207779;
					continue;
				case 87u:
					flag11 = !flag11;
					num = -616742999;
					continue;
				case 86u:
					stack.Pop();
					num = -30013606;
					continue;
				case 85u:
				{
					int num52;
					if (c != '"')
					{
						num = -992935859;
						num52 = -992935859;
					}
					else
					{
						num = -673076410;
						num52 = -673076410;
					}
					continue;
				}
				case 84u:
					num = ((int)num2 * -1153429195) ^ -731540092;
					continue;
				case 83u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1376218890) ^ -391561552;
					continue;
				case 81u:
					flag8 = JSONNode.smethod_6(text, "");
					num = -1170678686;
					continue;
				case 80u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 2092023925) ^ 0xB0197D);
					continue;
				case 79u:
				{
					int num47;
					int num48;
					if (flag11)
					{
						num47 = -1691767200;
						num48 = -1691767200;
					}
					else
					{
						num47 = -830508035;
						num48 = -830508035;
					}
					num = num47 ^ (int)(num2 * 1560691545);
					continue;
				}
				case 77u:
				{
					int num44;
					int num45;
					if (!flag13)
					{
						num44 = 251414919;
						num45 = 251414919;
					}
					else
					{
						num44 = 1849413880;
						num45 = 1849413880;
					}
					num = num44 ^ ((int)num2 * -80934658);
					continue;
				}
				case 76u:
				{
					int num40;
					int num41;
					if (flag5)
					{
						num40 = 914143791;
						num41 = 914143791;
					}
					else
					{
						num40 = 964700004;
						num41 = 964700004;
					}
					num = num40 ^ (int)(num2 * 104218279);
					continue;
				}
				case 75u:
					num = (int)(num2 * 308538319) ^ -1989790484;
					continue;
				case 74u:
					num = ((int)num2 * -918061328) ^ -457443321;
					continue;
				case 73u:
					text = text2;
					num = -2126120083;
					continue;
				case 72u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)((num2 * 162164914) ^ 0x48758E67);
					continue;
				case 71u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 929143210) ^ -1549984192;
					continue;
				case 69u:
					goto IL_092f;
				case 68u:
					num = -1718263631;
					continue;
				case 67u:
					text2 = "";
					text = "";
					num = (int)(num2 * 563233831) ^ -1050998735;
					continue;
				case 66u:
					num = (int)(num2 * 2019309710) ^ -1433432461;
					continue;
				case 65u:
				{
					int num37;
					int num38;
					if (c4 == 'b')
					{
						num37 = -1244858554;
						num38 = -1244858554;
					}
					else
					{
						num37 = -1669044406;
						num38 = -1669044406;
					}
					num = num37 ^ ((int)num2 * -1531682165);
					continue;
				}
				case 64u:
					flag11 = false;
					num = ((int)num2 * -2026212257) ^ 0x72D8C9D8;
					continue;
				case 63u:
					num = ((int)num2 * -409222220) ^ 0x5C13D507;
					continue;
				case 62u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 2130989251) ^ 0x58D88CA5);
					continue;
				case 61u:
					num = (int)((num2 * 641458794) ^ 0x35DD1917);
					continue;
				case 60u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -851992980;
					continue;
				case 58u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = ((int)num2 * -566803002) ^ -1400197916;
					continue;
				case 57u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -52534871;
					continue;
				case 56u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)((num2 * 1335005794) ^ 0x42C27D31);
					continue;
				case 54u:
					flag9 = jSONNode != null;
					num = ((int)num2 * -1448329847) ^ -1890371812;
					continue;
				case 53u:
					num = ((int)num2 * -998431335) ^ -679552726;
					continue;
				case 52u:
				{
					int num34;
					if (!flag11)
					{
						num = -215941563;
						num34 = -215941563;
					}
					else
					{
						num = -984060023;
						num34 = -984060023;
					}
					continue;
				}
				case 51u:
					num = ((int)num2 * -1552747861) ^ 0x1BAA82ED;
					continue;
				case 50u:
					num = ((int)num2 * -1004957738) ^ 0x3138E708;
					continue;
				case 48u:
					flag15 = jSONNode is JSONArray;
					num = ((int)num2 * -2075742622) ^ -1879372109;
					continue;
				case 47u:
					goto IL_0b1d;
				case 46u:
					text = "";
					num = -1831318630;
					continue;
				case 45u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = ((int)num2 * -542861599) ^ 0xBCFAD81;
					continue;
				case 44u:
					num = ((int)num2 * -1825137720) ^ 0x3DB9EDB9;
					continue;
				case 43u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 755453154) ^ -137997967;
					continue;
				case 42u:
					text2 = "";
					jSONNode = stack.Peek();
					num = (int)((num2 * 86397282) ^ 0xAB6D3C1);
					continue;
				case 41u:
					jSONNode.Add(text2);
					num = ((int)num2 * -484388210) ^ 0x1391A92;
					continue;
				case 40u:
					flag14 = flag11;
					num = -1640786157;
					continue;
				case 39u:
					flag13 = JSONNode.smethod_6(text, "");
					num = -2107524572;
					continue;
				case 38u:
					flag12 = flag11;
					num = -1854890283;
					continue;
				case 37u:
				{
					int num32;
					int num33;
					if (flag10)
					{
						num32 = -231084413;
						num33 = -231084413;
					}
					else
					{
						num32 = -1685644231;
						num33 = -1685644231;
					}
					num = num32 ^ ((int)num2 * -711758845);
					continue;
				}
				case 35u:
				{
					c4 = c3;
					int num28;
					int num29;
					if ((uint)c4 <= 102u)
					{
						num28 = -1240467993;
						num29 = -1240467993;
					}
					else
					{
						num28 = -1264627016;
						num29 = -1264627016;
					}
					num = num28 ^ ((int)num2 * -1164139897);
					continue;
				}
				case 34u:
					num = ((int)num2 * -2102127513) ^ -2108154065;
					continue;
				case 32u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 134547711) ^ 0x6F4DDEC4);
					continue;
				case 31u:
					switch (c4)
					{
					case 's':
						break;
					case 'u':
						goto IL_092f;
					case 't':
						goto IL_0b1d;
					default:
						goto IL_0cb4;
					case 'r':
						goto IL_0cbe;
					}
					goto case 101u;
				case 0u:
					goto IL_0cbe;
				case 30u:
				{
					int num24;
					int num25;
					if (flag8)
					{
						num24 = -1993759589;
						num25 = -1993759589;
					}
					else
					{
						num24 = -930221783;
						num25 = -930221783;
					}
					num = num24 ^ (int)(num2 * 66578324);
					continue;
				}
				case 29u:
				{
					int num20;
					int num21;
					if (flag6)
					{
						num20 = 588675052;
						num21 = 588675052;
					}
					else
					{
						num20 = 2023496667;
						num21 = 2023496667;
					}
					num = num20 ^ ((int)num2 * -1180477011);
					continue;
				}
				case 28u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1645376948) ^ 0x2C0A3DDD;
					continue;
				case 27u:
					num = (int)((num2 * 1782093538) ^ 0x6DFFCECA);
					continue;
				case 26u:
					flag5 = JSONNode.smethod_6(text2, "");
					num = (int)((num2 * 602267493) ^ 0x13ECE43);
					continue;
				case 25u:
					num = (int)(num2 * 577251241) ^ -536922637;
					continue;
				case 24u:
					num = ((int)num2 * -1521432768) ^ -1022761234;
					continue;
				case 23u:
					num = ((int)num2 * -1041543311) ^ -126414867;
					continue;
				case 22u:
					num = (int)((num2 * 1454168473) ^ 0x32688521);
					continue;
				case 19u:
				{
					int num19;
					if (c4 != 'f')
					{
						num = -519725608;
						num19 = -519725608;
					}
					else
					{
						num = -139438985;
						num19 = -139438985;
					}
					continue;
				}
				case 18u:
					num = ((int)num2 * -1037760178) ^ 0x3FA3E13F;
					continue;
				case 17u:
				{
					int num15;
					int num16;
					if (c != ':')
					{
						num15 = -1179099956;
						num16 = -1179099956;
					}
					else
					{
						num15 = -1047951991;
						num16 = -1047951991;
					}
					num = num15 ^ (int)(num2 * 171831593);
					continue;
				}
				case 16u:
					num = -401009997;
					continue;
				case 15u:
					text2 = "";
					num = ((int)num2 * -1150194249) ^ -1304233974;
					continue;
				case 14u:
				{
					int num12;
					int num13;
					if (!(jSONNode is JSONArray))
					{
						num12 = 1922926889;
						num13 = 1922926889;
					}
					else
					{
						num12 = 1008435457;
						num13 = 1008435457;
					}
					num = num12 ^ ((int)num2 * -1026520932);
					continue;
				}
				case 13u:
					num = ((int)num2 * -133774059) ^ 0x371E6963;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag4)
					{
						num8 = -1263980427;
						num9 = -1263980427;
					}
					else
					{
						num8 = -1007887340;
						num9 = -1007887340;
					}
					num = num8 ^ ((int)num2 * -525735899);
					continue;
				}
				case 11u:
					flag3 = jSONNode != null;
					num = (int)(num2 * 1541318267) ^ -570340198;
					continue;
				case 10u:
					num = ((int)num2 * -165803391) ^ 0x62D48EF4;
					continue;
				case 9u:
					num = (int)((num2 * 884810258) ^ 0x673B5C5E);
					continue;
				case 8u:
					num = (int)((num2 * 1288396910) ^ 0xBCF276);
					continue;
				case 6u:
					num = -692574653;
					continue;
				case 5u:
					num = -1269660172;
					continue;
				case 4u:
					stack.Push(new JSONClass());
					num = -1992344222;
					continue;
				case 3u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 853051908) ^ 0x2AA151D3);
					continue;
				case 2u:
					flag2 = jSONNode is JSONArray;
					num = (int)((num2 * 105468695) ^ 0x50E750DB);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2047579948;
						num4 = -2047579948;
					}
					else
					{
						num3 = -56842504;
						num4 = -56842504;
					}
					num = num3 ^ (int)(num2 * 1063406320);
					continue;
				}
				case 36u:
					break;
				case 55u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 123u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0cbe:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -52534871;
					continue;
					IL_0cb4:
					num = -438798771;
					continue;
					IL_01b6:
					flag4 = flag11;
					num = -1668754076;
					continue;
					IL_01d6:
					flag10 = flag11;
					num = -1523361644;
					continue;
					IL_01c4:
					num7++;
					flag6 = flag11;
					num = -249245791;
					continue;
					IL_0b1d:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -617847197;
					continue;
					IL_092f:
					s = JSONNode.smethod_8(aJSON, num7 + 1, 4);
					num = -2111932538;
					continue;
					IL_072c:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num7).ToString());
					num = -1786183833;
					continue;
					IL_071e:
					flag = flag11;
					num = -208695809;
					continue;
					IL_070b:
					num = (int)((num2 * 1620298248) ^ 0x44C02EA7);
					continue;
				}
				break;
			}
		}
	}

	public virtual void Serialize(BinaryWriter aWriter)
	{
	}

	public void SaveToStream(Stream aData)
	{
		BinaryWriter aWriter = default(BinaryWriter);
		while (true)
		{
			int num = -1218160085;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB85C051u) % 4u)
				{
				case 3u:
					Serialize(aWriter);
					num = ((int)num2 * -1361649643) ^ 0x48A108BB;
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -1484535838) ^ -745783262;
					continue;
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

	public void SaveToCompressedStream(Stream aData)
	{
		throw JSONNode.smethod_7("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public void SaveToCompressedFile(string aFileName)
	{
		throw JSONNode.smethod_7("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public string SaveToCompressedBase64()
	{
		throw JSONNode.smethod_7("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public void SaveToFile(string aFileName)
	{
		JSONNode.smethod_13(JSONNode.smethod_12((FileSystemInfo)JSONNode.smethod_11(JSONNode.smethod_10(aFileName))));
		FileStream fileStream = JSONNode.smethod_14(aFileName);
		try
		{
			SaveToStream(fileStream);
			while (true)
			{
				int num = 953951927;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E7C18D3u) % 3u)
					{
					case 1u:
						goto IL_0026;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0026:
					num = (int)((num2 * 1219920477) ^ 0x3E8814BF);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008e:
					int num3 = 756675165;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x3E7C18D3u) % 3u)
						{
						case 1u:
							goto IL_005e;
						default:
							goto end_IL_0071;
						case 2u:
							break;
						case 0u:
							goto end_IL_0071;
						}
						goto IL_008e;
						IL_005e:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)(num2 * 881261354) ^ -781086171;
						continue;
						end_IL_0071:
						break;
					}
					break;
				}
			}
		}
	}

	public string SaveToBase64()
	{
		MemoryStream memoryStream = JSONNode.smethod_16();
		try
		{
			while (true)
			{
				int num = 1751172975;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48480FE4u) % 5u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 2042518902) ^ 0x794A77F0);
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -598165444) ^ 0x182D348;
						continue;
					case 0u:
						num = ((int)num2 * -419528118) ^ 0x126B2CA9;
						continue;
					case 4u:
						break;
					default:
						return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
					}
					break;
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_00cc:
					int num3 = 1343742573;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x48480FE4u) % 4u)
						{
						case 3u:
							num3 = (int)(num2 * 824110817) ^ -963082463;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -1624946030) ^ 0x7F3E2D45;
							continue;
						default:
							goto end_IL_00ab;
						case 0u:
							break;
						case 2u:
							goto end_IL_00ab;
						}
						goto IL_00cc;
						continue;
						end_IL_00ab:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		JSONBinaryTag jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
		bool flag2 = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		JSONNode result = default(JSONNode);
		int num5 = default(int);
		JSONArray jSONArray = default(JSONArray);
		bool flag = default(bool);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		int num3 = default(int);
		while (true)
		{
			int num = 1285748738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64BD55FCu) % 43u)
				{
				case 42u:
					flag2 = num4 < num6;
					num = 633727973;
					continue;
				case 41u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)(num2 * 1504478227) ^ -1002953951;
					continue;
				case 40u:
					num = 207458831;
					continue;
				case 38u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 178007463) ^ 0x6CE9A546);
					continue;
				case 37u:
					num = (int)((num2 * 1926632294) ^ 0x4CBFB570);
					continue;
				case 36u:
					num5 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 1881423929) ^ -1933990945;
					continue;
				case 35u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 962283871;
						num10 = 962283871;
					}
					else
					{
						num9 = 2113908936;
						num10 = 2113908936;
					}
					num = num9 ^ ((int)num2 * -2015450033);
					continue;
				}
				case 34u:
					result = jSONArray;
					num = ((int)num2 * -1306467492) ^ -1030566147;
					continue;
				case 32u:
					num = 1077279350;
					continue;
				case 31u:
					num = ((int)num2 * -1941962814) ^ -1747516198;
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 12449651;
						num8 = 12449651;
					}
					else
					{
						num7 = 775467360;
						num8 = 775467360;
					}
					num = num7 ^ (int)(num2 * 1630774891);
					continue;
				}
				case 29u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -1737906023) ^ 0x682C41D2;
					continue;
				case 28u:
					goto IL_0130;
				case 27u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -566594509) ^ -1567219065;
					continue;
				case 26u:
					num4++;
					num = ((int)num2 * -1928026089) ^ -414835157;
					continue;
				case 24u:
					goto IL_0171;
				case 23u:
					jSONArray = new JSONArray();
					num = (int)(num2 * 195330857) ^ -153566086;
					continue;
				case 22u:
					goto IL_019d;
				case 21u:
					goto IL_01b4;
				case 20u:
					flag = num3 < num5;
					num = 1896145836;
					continue;
				case 19u:
					num = (int)(num2 * 720291209) ^ -1699621225;
					continue;
				case 18u:
					num = ((int)num2 * -308981988) ^ -1722524352;
					continue;
				case 17u:
					goto IL_01f5;
				case 16u:
					result = jSONClass;
					num = ((int)num2 * -2015649352) ^ 0x32963A5F;
					continue;
				case 15u:
					num = (int)((num2 * 1236723489) ^ 0x5AC8B4E5);
					continue;
				case 14u:
					num = 787762604;
					continue;
				case 13u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = (int)((num2 * 335123493) ^ 0xB91F317);
					continue;
				case 12u:
					goto IL_0255;
				case 11u:
					num = ((int)num2 * -2022833071) ^ 0x7DCFB496;
					continue;
				case 10u:
					num = (int)(num2 * 872744060) ^ -1449444869;
					continue;
				case 9u:
					num = ((int)num2 * -1113005817) ^ 0x662BA501;
					continue;
				case 8u:
					jSONArray.Add(Deserialize(aReader));
					num = 1841910819;
					continue;
				case 7u:
					jSONClass = new JSONClass();
					num = (int)(num2 * 1837535884) ^ -48306199;
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -1376313254) ^ -369265403;
					continue;
				case 5u:
					aItem = Deserialize(aReader);
					num = (int)((num2 * 683580571) ^ 0x4518FA50);
					continue;
				case 4u:
					num4 = 0;
					num = ((int)num2 * -1212368075) ^ -619856833;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1167516193) ^ 0x68F58AB1;
					continue;
				case 2u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Array:
						goto IL_0130;
					case JSONBinaryTag.Class:
						goto IL_0171;
					case JSONBinaryTag.Value:
						goto IL_019d;
					case JSONBinaryTag.FloatValue:
						goto IL_01b4;
					case JSONBinaryTag.IntValue:
						goto IL_01f5;
					case JSONBinaryTag.BoolValue:
						goto IL_0255;
					default:
						goto IL_0354;
					}
					goto case 40u;
				case 1u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)(num2 * 1343850496) ^ -39977971;
					continue;
				case 0u:
					num = (int)(num2 * 993968332) ^ -1411397252;
					continue;
				case 39u:
					break;
				case 33u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0354:
					num = ((int)num2 * -145718813) ^ 0x73AAE4AF;
					continue;
					IL_0255:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = 1671010478;
					continue;
					IL_01f5:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 390635448;
					continue;
					IL_01b4:
					num = 903104914;
					continue;
					IL_019d:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 390635448;
					continue;
					IL_0171:
					num6 = JSONNode.smethod_21(aReader);
					num = 639365980;
					continue;
					IL_0130:
					num = 1885135483;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode LoadFromCompressedFile(string aFileName)
	{
		throw JSONNode.smethod_7("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static JSONNode LoadFromCompressedStream(Stream aData)
	{
		throw JSONNode.smethod_7("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static JSONNode LoadFromCompressedBase64(string aBase64)
	{
		throw JSONNode.smethod_7("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
	}

	public static JSONNode LoadFromStream(Stream aData)
	{
		BinaryReader binaryReader = JSONNode.smethod_26(aData);
		try
		{
			return Deserialize(binaryReader);
		}
		finally
		{
			if (binaryReader != null)
			{
				while (true)
				{
					IL_0058:
					int num = -458827084;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xF60CDA23u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -49579506) ^ -1724900859;
							continue;
						case 0u:
							num = ((int)num2 * -730098367) ^ 0x79D0BBF6;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
							break;
						case 1u:
							goto end_IL_0037;
						}
						goto IL_0058;
						continue;
						end_IL_0037:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode LoadFromFile(string aFileName)
	{
		FileStream fileStream = JSONNode.smethod_27(aFileName);
		try
		{
			return LoadFromStream(fileStream);
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0045:
					int num = 708887171;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x64863DABu) % 3u)
						{
						case 1u:
							goto IL_0015;
						default:
							goto end_IL_0028;
						case 0u:
							break;
						case 2u:
							goto end_IL_0028;
						}
						goto IL_0045;
						IL_0015:
						JSONNode.smethod_15((IDisposable)fileStream);
						num = ((int)num2 * -661096893) ^ -1778158565;
						continue;
						end_IL_0028:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode LoadFromBase64(string aBase64)
	{
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 794845927;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x114EF106u) % 7u)
				{
				case 6u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1265727825) ^ -1568884436;
					continue;
				case 4u:
					num = (int)(num2 * 251067909) ^ -714103481;
					continue;
				case 2u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 202385290) ^ -956559272;
					continue;
				case 1u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -865388204) ^ -1249920397;
					continue;
				case 0u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -592808238) ^ -1462725724;
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

	public JSONNode()
	{
		while (true)
		{
			int num = 940633294;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B16B6C6u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 187512861) ^ -5082455;
			}
		}
	}

	static CultureInfo smethod_0()
	{
		return CultureInfo.InvariantCulture;
	}

	static bool smethod_1(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	int method_0()
	{
		return base.GetHashCode();
	}

	static char smethod_2(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_3(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static int smethod_4(string string_0)
	{
		return string_0.Length;
	}

	static string smethod_5(string string_0)
	{
		return string_0.Trim();
	}

	static bool smethod_6(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static Exception smethod_7(string string_0)
	{
		return new Exception(string_0);
	}

	static string smethod_8(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	static BinaryWriter smethod_9(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	static FileInfo smethod_10(string string_0)
	{
		return new FileInfo(string_0);
	}

	static DirectoryInfo smethod_11(FileInfo fileInfo_0)
	{
		return fileInfo_0.Directory;
	}

	static string smethod_12(FileSystemInfo fileSystemInfo_0)
	{
		return fileSystemInfo_0.FullName;
	}

	static DirectoryInfo smethod_13(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	static FileStream smethod_14(string string_0)
	{
		return File.OpenWrite(string_0);
	}

	static void smethod_15(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static MemoryStream smethod_16()
	{
		return new MemoryStream();
	}

	static void smethod_17(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	static byte[] smethod_18(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	static string smethod_19(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	static byte smethod_20(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadByte();
	}

	static int smethod_21(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt32();
	}

	static string smethod_22(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadString();
	}

	static double smethod_23(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadDouble();
	}

	static bool smethod_24(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadBoolean();
	}

	static float smethod_25(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadSingle();
	}

	static BinaryReader smethod_26(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	static FileStream smethod_27(string string_0)
	{
		return File.OpenRead(string_0);
	}

	static byte[] smethod_28(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	static MemoryStream smethod_29(byte[] byte_0)
	{
		return new MemoryStream(byte_0);
	}
}
