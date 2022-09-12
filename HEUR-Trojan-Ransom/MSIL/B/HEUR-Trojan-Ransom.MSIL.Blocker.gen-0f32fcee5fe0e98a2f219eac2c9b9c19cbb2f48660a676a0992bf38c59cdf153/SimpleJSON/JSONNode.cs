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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 959036104;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B1C7E99u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1533785386) ^ -2076474117;
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -409791082) ^ 0x189B2BF0;
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
		set
		{
		}
	}

	public virtual JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -2010066596;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE031347u) % 4u)
					{
					case 3u:
						result = null;
						num = (int)(num2 * 1218616692) ^ -1622986055;
						continue;
					case 2u:
						num = ((int)num2 * -2114603032) ^ -915092918;
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

	public virtual string Value
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 1559562170;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79D9437u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -446923234) ^ -296635737;
						continue;
					case 1u:
						result = "";
						num = ((int)num2 * -1745070888) ^ -1368280003;
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
		}
	}

	public virtual int Count => 0;

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
		}
	}

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 104450868;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7052ECC6u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					result = _003Cget_DeepChilds_003Ed__;
					num = (int)((num2 * 974405047) ^ 0x557581D9);
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result2 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = -756890516;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF74C5AD2u) % 8u)
					{
					case 6u:
						result2 = 0;
						num = ((int)num2 * -1849378846) ^ -1607283586;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1270000389;
							num4 = 1270000389;
						}
						else
						{
							num3 = 845866371;
							num4 = 845866371;
						}
						num = num3 ^ ((int)num2 * -1802915441);
						continue;
					}
					case 4u:
						result = 0;
						num = -1187282301;
						continue;
					case 2u:
						result = result2;
						num = ((int)num2 * -682146361) ^ -2143755889;
						continue;
					case 1u:
						num = (int)(num2 * 1592774385) ^ -825085264;
						continue;
					case 0u:
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 2018735092) ^ 0x3C13471F);
						continue;
					case 7u:
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
			while (true)
			{
				int num = 229659522;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F452802u) % 3u)
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
					num = ((int)num2 * -1252438220) ^ 0x22CC52DA;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result2 = default(float);
			bool flag = default(bool);
			float result = default(float);
			while (true)
			{
				int num = 141765195;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72E8BBDDu) % 8u)
					{
					case 6u:
						result2 = 0f;
						num = ((int)num2 * -1680092953) ^ 0x21F2524D;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1203021679;
							num4 = -1203021679;
						}
						else
						{
							num3 = -1252278396;
							num4 = -1252278396;
						}
						num = num3 ^ ((int)num2 * -356241792);
						continue;
					}
					case 4u:
						result = 0f;
						num = 478665078;
						continue;
					case 3u:
						num = (int)(num2 * 1687544661) ^ -1565465774;
						continue;
					case 2u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -1786796056) ^ -1566325608;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1546601053) ^ -1785521218;
						continue;
					case 7u:
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
			while (true)
			{
				int num = 1669266942;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x53713786u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					Value = value.ToString();
					num = ((int)num2 * -2006875852) ^ 0x85140A2;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			bool flag = double.TryParse(Value, out result);
			double result2 = default(double);
			while (true)
			{
				int num = 858252869;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25CB3461u) % 7u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1120654723;
							num4 = 1120654723;
						}
						else
						{
							num3 = 965763885;
							num4 = 965763885;
						}
						num = num3 ^ ((int)num2 * -203873195);
						continue;
					}
					case 4u:
						num = ((int)num2 * -166718726) ^ -453789847;
						continue;
					case 2u:
						result2 = 0.0;
						num = 1036387251;
						continue;
					case 1u:
						result2 = result;
						num = (int)(num2 * 1999378998) ^ -1983420207;
						continue;
					case 0u:
						num = (int)(num2 * 2085848811) ^ -1926704547;
						continue;
					case 3u:
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
			Value = value.ToString();
			while (true)
			{
				int num = 495338355;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20FFCE6u) % 3u)
					{
					case 1u:
						goto IL_000f;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_000f:
					num = ((int)num2 * -1712163319) ^ -1230168852;
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
				int num = 1894418290;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3AAF8177u) % 6u)
					{
					case 4u:
						result = result2;
						num = ((int)num2 * -889483725) ^ 0x7F4E6AC8;
						continue;
					case 2u:
						result = !JSONNode.smethod_1(Value);
						num = 1464851914;
						continue;
					case 1u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = (int)(num2 * 1756085037) ^ -1640040130;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1040313329;
							num4 = 1040313329;
						}
						else
						{
							num3 = 956520701;
							num4 = 956520701;
						}
						num = num3 ^ (int)(num2 * 1818596374);
						continue;
					}
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
			while (true)
			{
				int num = -2047962486;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD0C1AFD7u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1589753412) ^ 0x4BD6C5B3;
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = -1045076271;
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public virtual JSONArray AsArray => this as JSONArray;

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 2142074084;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x331106D2u) % 4u)
					{
					case 2u:
						result = this as JSONClass;
						num = ((int)num2 * -1897080756) ^ 0x239E3967;
						continue;
					case 1u:
						num = ((int)num2 * -154536688) ^ 0x12E0C1E5;
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
		Add("", aItem);
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1692013852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADC62827u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = null;
				num = ((int)num2 * -1249222086) ^ -17165480;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		return null;
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = 113632359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11C2F33Eu) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 0u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0004:
				num = ((int)num2 * -850923846) ^ 0x549145AC;
			}
		}
	}

	public override string ToString()
	{
		return "JSONNode";
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -905788114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x871D862Bu) % 4u)
				{
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -1907507379) ^ -587838246;
					continue;
				case 0u:
					num = (int)(num2 * 46421143) ^ -1764495972;
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = new JSONData(s);
		while (true)
		{
			int num = 386597164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2917A199u) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1347258889) ^ 0x2F1917C4;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 1196733603;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x37FE9330u) % 5u)
				{
				case 3u:
					if (!(d == null))
					{
						num = (int)((num2 * 755830095) ^ 0x5F6C43D8);
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					obj = d.Value;
					goto IL_001c;
				case 1u:
					num = ((int)num2 * -1068118236) ^ 0x12759736;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = 1286769862;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1450905406;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA29CA7DCu) % 8u)
				{
				case 7u:
					if (a is JSONLazyCreator)
					{
						num = -1797282447;
						num3 = -1797282447;
						continue;
					}
					goto IL_0011;
				case 6u:
					if (b == null)
					{
						num = ((int)num2 * -1680960738) ^ 0x41B0A8BF;
						continue;
					}
					goto IL_0011;
				case 5u:
					result = true;
					num = (int)(num2 * 1458253368) ^ -901462716;
					continue;
				case 3u:
					num = ((int)num2 * -713353758) ^ -1578454560;
					continue;
				case 1u:
					result = (object)a == b;
					num = -742016849;
					continue;
				case 0u:
					num = ((int)num2 * -1507785627) ^ 0x262FE526;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_0011:
					num = -1079587843;
					num3 = -1079587843;
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
			int num = -1993537502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA75A56F1u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = ((int)num2 * -1672223468) ^ 0x274C0CCF;
					continue;
				case 2u:
					num = (int)(num2 * 821668838) ^ -606247140;
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
		bool result = default(bool);
		while (true)
		{
			int num = -1663832877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4B99F60u) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = (int)((num2 * 1587013933) ^ 0xBDF7E06);
					continue;
				case 1u:
					num = (int)(num2 * 1786633500) ^ -19351786;
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

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -1599800301;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF987B79Eu) % 3u)
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
				num = ((int)num2 * -1350053115) ^ -832084964;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		int num4 = default(int);
		string string_ = default(string);
		string result = default(string);
		char c2 = default(char);
		char c = default(char);
		while (true)
		{
			int num = 38445241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38F9E053u) % 30u)
				{
				case 29u:
					num = (int)((num2 * 108408995) ^ 0x5540F7C);
					continue;
				case 28u:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1881611216;
					continue;
				case 27u:
					num = (int)((num2 * 1309363996) ^ 0x150F9583);
					continue;
				case 26u:
					num = ((int)num2 * -1023707548) ^ -2037268934;
					continue;
				case 25u:
					goto IL_0055;
				case 24u:
					goto IL_006b;
				case 23u:
					num = ((int)num2 * -1123466068) ^ -2047057842;
					continue;
				case 22u:
					num = ((int)num2 * -136239344) ^ 0x7E3C3412;
					continue;
				case 21u:
					num = ((int)num2 * -403786289) ^ 0xF38A1C2;
					continue;
				case 20u:
				{
					int num6;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = 346282932;
						num6 = 346282932;
					}
					else
					{
						num = 535268480;
						num6 = 535268480;
					}
					continue;
				}
				case 19u:
					result = text;
					num = ((int)num2 * -1846332782) ^ -483577795;
					continue;
				case 17u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 455852282;
					continue;
				case 16u:
					goto IL_010b;
				case 15u:
					num = ((int)num2 * -1904091496) ^ -684435655;
					continue;
				case 13u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 1275708769;
					continue;
				case 12u:
				{
					int num5;
					if (c != '"')
					{
						num = 462565382;
						num5 = 462565382;
					}
					else
					{
						num = 282944268;
						num5 = 282944268;
					}
					continue;
				}
				case 11u:
					num = (int)((num2 * 60129840) ^ 0x6B1C0042);
					continue;
				case 10u:
					text = "";
					string_ = aText;
					num4 = 0;
					num = ((int)num2 * -2098905579) ^ 0x90239F8;
					continue;
				case 9u:
					switch (c)
					{
					case '\t':
						break;
					case '\n':
						goto IL_0055;
					case '\r':
						goto IL_006b;
					case '\f':
						goto IL_010b;
					default:
						goto IL_01b9;
					case '\b':
						goto IL_01cc;
					case '\v':
						goto IL_01e2;
					}
					goto case 28u;
				case 4u:
					goto IL_01cc;
				case 0u:
					goto IL_01e2;
				case 8u:
					num = (int)((num2 * 1778064371) ^ 0x10CC2CC4);
					continue;
				case 7u:
				{
					char c3 = c2;
					c = c3;
					num = (int)((num2 * 838047928) ^ 0x7DA59A9A);
					continue;
				}
				case 6u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 38072818;
					continue;
				case 5u:
					num4++;
					num = 810206069;
					continue;
				case 3u:
					num = ((int)num2 * -1414672834) ^ 0x703A9368;
					continue;
				case 2u:
				{
					int num3;
					if (c != '\\')
					{
						num = 1194329842;
						num3 = 1194329842;
					}
					else
					{
						num = 276861705;
						num3 = 276861705;
					}
					continue;
				}
				case 1u:
					num = (int)((num2 * 1596045481) ^ 0x6A99C089);
					continue;
				case 18u:
					break;
				default:
					{
						return result;
					}
					IL_006b:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1144587629;
					continue;
					IL_0055:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1652381248;
					continue;
					IL_01e2:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1524436894;
					continue;
					IL_01cc:
					text = JSONNode.smethod_3(text, "\\b");
					num = 38072818;
					continue;
					IL_01b9:
					num = ((int)num2 * -2061277088) ^ 0x66F2CE08;
					continue;
					IL_010b:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1339668113;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		JSONNode result = default(JSONNode);
		JSONNode jSONNode = default(JSONNode);
		bool flag12 = default(bool);
		int num3 = default(int);
		bool flag13 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		string text = default(string);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		char c4 = default(char);
		char c = default(char);
		char c2 = default(char);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		string text2 = default(string);
		bool flag11 = default(bool);
		char c3 = default(char);
		bool flag9 = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		string s = default(string);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -466242530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE94443BDu) % 152u)
				{
				case 150u:
					result = jSONNode;
					num = -354676787;
					continue;
				case 149u:
				{
					int num52;
					int num53;
					if (flag12)
					{
						num52 = -393352828;
						num53 = -393352828;
					}
					else
					{
						num52 = -798949792;
						num53 = -798949792;
					}
					num = num52 ^ ((int)num2 * -258008740);
					continue;
				}
				case 148u:
					num3++;
					flag13 = flag2;
					num = -26762002;
					continue;
				case 147u:
					num = ((int)num2 * -442214379) ^ 0x642CCD11;
					continue;
				case 146u:
					num = (int)(num2 * 1175106801) ^ -1304516658;
					continue;
				case 145u:
					num = ((int)num2 * -1005252516) ^ -2001158935;
					continue;
				case 144u:
					num = ((int)num2 * -1961666444) ^ 0x46C35F5A;
					continue;
				case 143u:
					goto IL_009a;
				case 142u:
					flag4 = jSONNode != null;
					num = (int)((num2 * 945037273) ^ 0xB09F944);
					continue;
				case 32u:
				case 54u:
				case 55u:
				case 109u:
				case 141u:
					num3++;
					num = -813898921;
					continue;
				case 140u:
					text = JSONNode.smethod_3(text, "\n");
					num = -1496835674;
					continue;
				case 139u:
					jSONNode = null;
					num = (int)((num2 * 1500488193) ^ 0x3D19CFCD);
					continue;
				case 138u:
				{
					stack.Push(new JSONArray());
					int num56;
					if (jSONNode != null)
					{
						num = -1659218946;
						num56 = -1659218946;
					}
					else
					{
						num = -827466839;
						num56 = -827466839;
					}
					continue;
				}
				case 137u:
				{
					int num39;
					if (!flag2)
					{
						num = -1883906403;
						num39 = -1883906403;
					}
					else
					{
						num = -960990658;
						num39 = -960990658;
					}
					continue;
				}
				case 136u:
				{
					c4 = JSONNode.smethod_2(aJSON, num3);
					char c5 = c4;
					c = c5;
					num = ((int)num2 * -1601705304) ^ -954080062;
					continue;
				}
				case 135u:
				{
					int num34;
					int num35;
					if ((uint)c2 > 44u)
					{
						num34 = 1896677741;
						num35 = 1896677741;
					}
					else
					{
						num34 = 374957907;
						num35 = 374957907;
					}
					num = num34 ^ ((int)num2 * -353159126);
					continue;
				}
				case 134u:
					num = ((int)num2 * -751492193) ^ -2042107315;
					continue;
				case 133u:
					text = "";
					num = (int)(num2 * 231928800) ^ -779943461;
					continue;
				case 132u:
					num = (int)(num2 * 61614919) ^ -2055667425;
					continue;
				case 131u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 1443921714;
						num10 = 1443921714;
					}
					else
					{
						num9 = 949867795;
						num10 = 949867795;
					}
					num = num9 ^ ((int)num2 * -1834444929);
					continue;
				}
				case 130u:
					flag6 = num3 < JSONNode.smethod_4(aJSON);
					num = -833966552;
					continue;
				case 129u:
				{
					int num6;
					if (flag2)
					{
						num = -2128037242;
						num6 = -2128037242;
					}
					else
					{
						num = -254025634;
						num6 = -254025634;
					}
					continue;
				}
				case 128u:
					text2 = "";
					flag2 = false;
					num = ((int)num2 * -1988547801) ^ -912532945;
					continue;
				case 127u:
					num = ((int)num2 * -2086753468) ^ 0x27F81D47;
					continue;
				case 125u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1798131503) ^ 0x12B56A4F;
					continue;
				case 124u:
					num = (int)(num2 * 1054120437) ^ -302302820;
					continue;
				case 123u:
				{
					int num50;
					int num51;
					if (!flag13)
					{
						num50 = 1080867992;
						num51 = 1080867992;
					}
					else
					{
						num50 = 592256190;
						num51 = 592256190;
					}
					num = num50 ^ ((int)num2 * -1052703648);
					continue;
				}
				case 122u:
					switch (c2)
					{
					case '\\':
						break;
					case '[':
						goto IL_009a;
					default:
						goto IL_02e5;
					case ']':
						goto IL_02ef;
					}
					goto case 148u;
				case 108u:
					goto IL_02ef;
				case 121u:
					num = ((int)num2 * -1681036801) ^ 0x623D79A4;
					continue;
				case 120u:
					num = (int)((num2 * 761517883) ^ 0x6B2E216D);
					continue;
				case 119u:
				{
					int num44;
					if (c2 != '"')
					{
						num = -1965099673;
						num44 = -1965099673;
					}
					else
					{
						num = -1378496644;
						num44 = -1378496644;
					}
					continue;
				}
				case 118u:
					flag12 = JSONNode.smethod_6(text, "");
					num = (int)((num2 * 1283117272) ^ 0x1C679BF0);
					continue;
				case 117u:
				{
					int num40;
					int num41;
					if (flag6)
					{
						num40 = 131515197;
						num41 = 131515197;
					}
					else
					{
						num40 = 613469165;
						num41 = 613469165;
					}
					num = num40 ^ ((int)num2 * -1401693622);
					continue;
				}
				case 116u:
					jSONNode.Add(text);
					num = ((int)num2 * -1657357860) ^ 0x4CDF240B;
					continue;
				case 115u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -616157325) ^ 0x1C1F2F3A;
					continue;
				case 114u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num31;
					int num32;
					if (jSONNode is JSONArray)
					{
						num31 = 923846215;
						num32 = 923846215;
					}
					else
					{
						num31 = 1410207034;
						num32 = 1410207034;
					}
					num = num31 ^ ((int)num2 * -1869112637);
					continue;
				}
				case 113u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -47906683) ^ -708318348;
					continue;
				case 112u:
					num = -827466839;
					continue;
				case 111u:
					flag11 = jSONNode is JSONArray;
					num = ((int)num2 * -1563978379) ^ 0x400B2110;
					continue;
				case 110u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -607900956) ^ -1400147492;
					continue;
				case 107u:
					c2 = c3;
					num = (int)(num2 * 1955425674) ^ -1374162916;
					continue;
				case 106u:
					num = (int)((num2 * 1382753155) ^ 0xD3C6B5D);
					continue;
				case 105u:
					flag9 = JSONNode.smethod_6(text2, "");
					num = -985678051;
					continue;
				case 104u:
					text2 = "";
					text = "";
					num = -339513421;
					continue;
				case 103u:
					num = (int)((num2 * 86868415) ^ 0x5108811A);
					continue;
				case 102u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 694678096) ^ -104317147;
					continue;
				case 101u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_0537;
					case '\t':
						goto IL_054a;
					case '\v':
					case '\f':
						goto IL_0558;
					}
					goto case 32u;
				case 60u:
					goto IL_054a;
				case 23u:
					goto IL_0558;
				case 100u:
				{
					int num19;
					if (c == 'n')
					{
						num = -1085266487;
						num19 = -1085266487;
					}
					else
					{
						num = -1621637180;
						num19 = -1621637180;
					}
					continue;
				}
				case 99u:
					stack.Push(new JSONClass());
					num = -786305829;
					continue;
				case 98u:
				{
					int num14;
					int num15;
					if (!flag)
					{
						num14 = -1686423895;
						num15 = -1686423895;
					}
					else
					{
						num14 = -447170480;
						num15 = -447170480;
					}
					num = num14 ^ (int)(num2 * 663046136);
					continue;
				}
				case 97u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = -1496871270;
						num12 = -1496871270;
					}
					else
					{
						num11 = -387699148;
						num12 = -387699148;
					}
					num = num11 ^ (int)(num2 * 66174273);
					continue;
				}
				case 96u:
					text2 = text;
					num = -600074481;
					continue;
				case 95u:
				{
					int num58;
					int num59;
					if (flag4)
					{
						num58 = 1654581968;
						num59 = 1654581968;
					}
					else
					{
						num58 = 764044716;
						num59 = 764044716;
					}
					num = num58 ^ ((int)num2 * -816896331);
					continue;
				}
				case 94u:
					num = ((int)num2 * -100806901) ^ -1298514149;
					continue;
				case 93u:
					num = ((int)num2 * -1411183875) ^ 0x14745795;
					continue;
				case 92u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 51004188) ^ -468682360;
					continue;
				case 91u:
					num = (int)((num2 * 508189362) ^ 0x569F338E);
					continue;
				case 90u:
					text = "";
					num = (int)((num2 * 890039176) ^ 0x5CD181AA);
					continue;
				case 89u:
					flag2 = !flag2;
					num = -1543669857;
					continue;
				case 88u:
					num = ((int)num2 * -1837980775) ^ -1447957983;
					continue;
				case 87u:
					num = (int)(num2 * 2018549235) ^ -958045266;
					continue;
				case 86u:
					switch (c)
					{
					case 'r':
						goto IL_0704;
					case 's':
						goto IL_071a;
					case 't':
						goto IL_0732;
					case 'u':
						goto IL_0748;
					}
					num = -772865435;
					continue;
				case 28u:
					goto IL_0704;
				case 81u:
					goto IL_071a;
				case 13u:
					goto IL_0732;
				case 17u:
					goto IL_0748;
				case 85u:
					jSONNode.Add(text);
					num = (int)(num2 * 770175697) ^ -1288352789;
					continue;
				case 84u:
				{
					int num57;
					if (!flag2)
					{
						num = -421279537;
						num57 = -421279537;
					}
					else
					{
						num = -156013221;
						num57 = -156013221;
					}
					continue;
				}
				case 83u:
					num = (int)(num2 * 441779530) ^ -136642085;
					continue;
				case 82u:
					flag10 = JSONNode.smethod_6(text, "");
					num = -2076895491;
					continue;
				case 79u:
					num = ((int)num2 * -168335136) ^ -1239752301;
					continue;
				case 78u:
				{
					int num54;
					int num55;
					if (!flag11)
					{
						num54 = -287319879;
						num55 = -287319879;
					}
					else
					{
						num54 = -264089159;
						num55 = -264089159;
					}
					num = num54 ^ (int)(num2 * 379350896);
					continue;
				}
				case 77u:
				{
					int num49;
					if (c != 'f')
					{
						num = -701403644;
						num49 = -701403644;
					}
					else
					{
						num = -1770560709;
						num49 = -1770560709;
					}
					continue;
				}
				case 76u:
					stack.Pop();
					num = -946974453;
					continue;
				case 75u:
					num = (int)((num2 * 2052023640) ^ 0xF803B04);
					continue;
				case 74u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1502908346) ^ -838946103;
					continue;
				case 73u:
				{
					int num47;
					int num48;
					if (c2 != ':')
					{
						num47 = 1918246662;
						num48 = 1918246662;
					}
					else
					{
						num47 = 197155113;
						num48 = 197155113;
					}
					num = num47 ^ (int)(num2 * 45330445);
					continue;
				}
				case 72u:
					num = ((int)num2 * -1623529670) ^ -1877454228;
					continue;
				case 71u:
					num3 += 4;
					num = ((int)num2 * -689686410) ^ -127737199;
					continue;
				case 70u:
					num = (int)(num2 * 1219259161) ^ -1755014255;
					continue;
				case 69u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -765567417) ^ 0x758EFA9;
					continue;
				case 68u:
				{
					int num46;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -1257382119;
						num46 = -1257382119;
					}
					else
					{
						num = -1938621917;
						num46 = -1938621917;
					}
					continue;
				}
				case 67u:
					num = ((int)num2 * -1140341042) ^ -848519793;
					continue;
				case 66u:
					num = ((int)num2 * -2117543193) ^ 0x116F156D;
					continue;
				case 65u:
				{
					int num45;
					if (c2 == '}')
					{
						num = -1527749471;
						num45 = -1527749471;
					}
					else
					{
						num = -722879508;
						num45 = -722879508;
					}
					continue;
				}
				case 64u:
				{
					int num42;
					int num43;
					if (flag9)
					{
						num42 = 920615174;
						num43 = 920615174;
					}
					else
					{
						num42 = 285018836;
						num43 = 285018836;
					}
					num = num42 ^ (int)(num2 * 993917880);
					continue;
				}
				case 63u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 923499910) ^ -629080488;
					continue;
				case 62u:
					num = -867453000;
					continue;
				case 61u:
				{
					int num37;
					int num38;
					if (jSONNode is JSONArray)
					{
						num37 = 45328719;
						num38 = 45328719;
					}
					else
					{
						num37 = 985839797;
						num38 = 985839797;
					}
					num = num37 ^ ((int)num2 * -2111067125);
					continue;
				}
				case 59u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -1184212288) ^ -304312138;
					continue;
				case 58u:
				{
					int num36;
					if (c2 != ' ')
					{
						num = -1522041419;
						num36 = -1522041419;
					}
					else
					{
						num = -2059267783;
						num36 = -2059267783;
					}
					continue;
				}
				case 57u:
					num = -1334434377;
					continue;
				case 56u:
				{
					int num33;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -672293060;
						num33 = -672293060;
					}
					else
					{
						num = -57119707;
						num33 = -57119707;
					}
					continue;
				}
				case 53u:
					num = ((int)num2 * -1913769616) ^ 0x3523C44A;
					continue;
				case 52u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -2037919296;
					continue;
				case 51u:
					num = (int)((num2 * 1789408428) ^ 0x5640EAD9);
					continue;
				case 50u:
				{
					int num29;
					int num30;
					if (flag2)
					{
						num29 = 755350756;
						num30 = 755350756;
					}
					else
					{
						num29 = 267175617;
						num30 = 267175617;
					}
					num = num29 ^ ((int)num2 * -1339870407);
					continue;
				}
				case 49u:
				{
					text2 = "";
					text = "";
					int num28;
					if (stack.Count > 0)
					{
						num = -1797415455;
						num28 = -1797415455;
					}
					else
					{
						num = -1727013787;
						num28 = -1727013787;
					}
					continue;
				}
				case 48u:
				{
					int num26;
					int num27;
					if (flag10)
					{
						num26 = -1795509344;
						num27 = -1795509344;
					}
					else
					{
						num26 = -277052283;
						num27 = -277052283;
					}
					num = num26 ^ ((int)num2 * -2063751850);
					continue;
				}
				case 47u:
					num = (int)((num2 * 1350721740) ^ 0x209FF62E);
					continue;
				case 46u:
					text = JSONNode.smethod_3(text, "\f");
					num = -1975891673;
					continue;
				case 44u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -597658765) ^ 0x648DEB31;
					continue;
				case 43u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1707829422) ^ -1540048971;
					continue;
				case 42u:
					num = ((int)num2 * -498759305) ^ 0x639B90DD;
					continue;
				case 41u:
					num = ((int)num2 * -222884864) ^ 0x5252C3B3;
					continue;
				case 40u:
					num = -13080827;
					continue;
				case 39u:
					num = ((int)num2 * -190362358) ^ -2070840427;
					continue;
				case 38u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 267105627) ^ 0x377E5ACF);
					continue;
				case 37u:
					num = ((int)num2 * -1267526554) ^ 0x6A464E7D;
					continue;
				case 36u:
				{
					int num24;
					int num25;
					if (c == 'b')
					{
						num24 = -1672171363;
						num25 = -1672171363;
					}
					else
					{
						num24 = -608244451;
						num25 = -608244451;
					}
					num = num24 ^ (int)(num2 * 1104444877);
					continue;
				}
				case 35u:
					num = (int)(num2 * 1679553297) ^ -1734698180;
					continue;
				case 34u:
					text2 = "";
					num = -2080124336;
					continue;
				case 33u:
					num = ((int)num2 * -2070354961) ^ -887938459;
					continue;
				case 31u:
				{
					int num23;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -203734601;
						num23 = -203734601;
					}
					else
					{
						num = -479044491;
						num23 = -479044491;
					}
					continue;
				}
				case 30u:
				{
					int num22;
					if ((uint)c2 <= 93u)
					{
						num = -766947252;
						num22 = -766947252;
					}
					else
					{
						num = -1375008053;
						num22 = -1375008053;
					}
					continue;
				}
				case 29u:
					num = ((int)num2 * -385136855) ^ 0x29D86FD9;
					continue;
				case 27u:
					num3 = 0;
					text = "";
					num = ((int)num2 * -957013035) ^ -1074715294;
					continue;
				case 26u:
					num = ((int)num2 * -1839924976) ^ -1514980461;
					continue;
				case 25u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1653620087) ^ 0x745D1567;
					continue;
				case 24u:
				{
					int num20;
					int num21;
					if (!flag8)
					{
						num20 = 894252791;
						num21 = 894252791;
					}
					else
					{
						num20 = 1698452379;
						num21 = 1698452379;
					}
					num = num20 ^ (int)(num2 * 511054750);
					continue;
				}
				case 22u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1907102736) ^ -107900001;
					continue;
				case 21u:
					text2 = JSONNode.smethod_5(text2);
					flag5 = jSONNode is JSONArray;
					num = (int)(num2 * 866573400) ^ -713242628;
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, "\b");
					num = -712693702;
					continue;
				case 19u:
					num = (int)((num2 * 783394551) ^ 0x6FED396);
					continue;
				case 18u:
					c3 = JSONNode.smethod_2(aJSON, num3);
					num = -129050290;
					continue;
				case 16u:
					num = (int)(num2 * 168986209) ^ -716834829;
					continue;
				case 15u:
				{
					int num17;
					int num18;
					if (!flag7)
					{
						num17 = 1934732516;
						num18 = 1934732516;
					}
					else
					{
						num17 = 1558419349;
						num18 = 1558419349;
					}
					num = num17 ^ (int)(num2 * 711531228);
					continue;
				}
				case 14u:
				{
					int num16;
					if (c2 == '{')
					{
						num = -50226812;
						num16 = -50226812;
					}
					else
					{
						num = -22601288;
						num16 = -22601288;
					}
					continue;
				}
				case 12u:
					num = -423985652;
					continue;
				case 11u:
					num = (int)((num2 * 537901639) ^ 0x1729049D);
					continue;
				case 10u:
					num = (int)(num2 * 571880212) ^ -489991492;
					continue;
				case 9u:
				{
					int num13;
					if (c2 != ',')
					{
						num = -958698352;
						num13 = -958698352;
					}
					else
					{
						num = -699840791;
						num13 = -699840791;
					}
					continue;
				}
				case 8u:
				{
					int num7;
					int num8;
					if ((uint)c2 > 32u)
					{
						num7 = -271170918;
						num8 = -271170918;
					}
					else
					{
						num7 = -408269056;
						num8 = -408269056;
					}
					num = num7 ^ (int)(num2 * 2131335163);
					continue;
				}
				case 7u:
				{
					int num4;
					int num5;
					if ((uint)c > 102u)
					{
						num4 = 1290732420;
						num5 = 1290732420;
					}
					else
					{
						num4 = 277938756;
						num5 = 277938756;
					}
					num = num4 ^ ((int)num2 * -404778285);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1525399031) ^ 0x58627646;
					continue;
				case 5u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1746472262) ^ -736497613;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 2119157343) ^ -1059630924;
					continue;
				case 3u:
					flag = stack.Count == 0;
					num = -1331800441;
					continue;
				case 2u:
					num = ((int)num2 * -44210077) ^ 0x6821193A;
					continue;
				case 1u:
					num = (int)((num2 * 582517638) ^ 0x7E8D194A);
					continue;
				case 0u:
					num = (int)(num2 * 556050087) ^ -1637061030;
					continue;
				case 126u:
					break;
				case 45u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 80u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_009a:
					flag8 = flag2;
					num = -1402390035;
					continue;
					IL_0558:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = -266134998;
					continue;
					IL_054a:
					flag7 = flag2;
					num = -1578053430;
					continue;
					IL_0537:
					num = (int)(num2 * 1013444686) ^ -594243856;
					continue;
					IL_02ef:
					flag3 = flag2;
					num = -1121020858;
					continue;
					IL_02e5:
					num = -1045500726;
					continue;
					IL_0748:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = -1412472142;
					continue;
					IL_0732:
					text = JSONNode.smethod_3(text, "\t");
					num = -687987969;
					continue;
					IL_071a:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = -276979301;
					continue;
					IL_0704:
					text = JSONNode.smethod_3(text, "\r");
					num = -674241910;
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
			int num = -533804518;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF3802D4u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					Serialize(aWriter);
					return;
				}
				break;
				IL_0003:
				aWriter = JSONNode.smethod_9(aData);
				num = (int)((num2 * 1055771101) ^ 0x78A95F71);
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
		while (true)
		{
			int num = -1125304471;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6B7D41Bu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					FileStream fileStream = JSONNode.smethod_14(aFileName);
					try
					{
						SaveToStream(fileStream);
						while (true)
						{
							int num3 = -2020858093;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xE6B7D41Bu) % 3u)
								{
								case 2u:
									goto IL_005a;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_005a:
								num3 = (int)(num2 * 574295754) ^ -1690360890;
							}
						}
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00d5:
								int num4 = -2107149974;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xE6B7D41Bu) % 4u)
									{
									case 1u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num4 = ((int)num2 * -1853692460) ^ -766815213;
										continue;
									case 0u:
										num4 = ((int)num2 * -2024338053) ^ 0x16C7A851;
										continue;
									default:
										goto end_IL_00b4;
									case 3u:
										break;
									case 2u:
										goto end_IL_00b4;
									}
									goto IL_00d5;
									continue;
									end_IL_00b4:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0003:
				JSONNode.smethod_13(JSONNode.smethod_12((FileSystemInfo)JSONNode.smethod_11(JSONNode.smethod_10(aFileName))));
				num = (int)((num2 * 1609963518) ^ 0x1F9868D0);
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
				int num = 1425484097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x50FE18FCu) % 4u)
					{
					case 1u:
						SaveToStream(memoryStream);
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 2110301901) ^ 0x514B1D8D);
						continue;
					case 0u:
						num = ((int)num2 * -853333052) ^ -715672509;
						continue;
					case 2u:
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
					IL_00b9:
					int num3 = 616908557;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x50FE18FCu) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -1205680269) ^ 0x313FFC2F;
							continue;
						case 0u:
							num3 = ((int)num2 * -423997033) ^ -1957806482;
							continue;
						default:
							goto end_IL_0098;
						case 3u:
							break;
						case 2u:
							goto end_IL_0098;
						}
						goto IL_00b9;
						continue;
						end_IL_0098:
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
		JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
		int num6 = default(int);
		int num7 = default(int);
		JSONNode result = default(JSONNode);
		string aKey = default(string);
		bool flag = default(bool);
		JSONArray jSONArray = default(JSONArray);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONClass jSONClass = default(JSONClass);
		JSONNode aItem = default(JSONNode);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1285178310;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x561B6CDDu) % 38u)
				{
				case 36u:
					num6++;
					num = ((int)num2 * -1959053973) ^ -1184703283;
					continue;
				case 35u:
					num = ((int)num2 * -1861202420) ^ -1723522936;
					continue;
				case 34u:
					num7 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -27579229) ^ -570099197;
					continue;
				case 33u:
					num = ((int)num2 * -1774330511) ^ -560441575;
					continue;
				case 32u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 1279241819) ^ 0x325AFDC7);
					continue;
				case 31u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)(num2 * 1374002371) ^ -1512354844;
					continue;
				case 29u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -352240413;
						num9 = -352240413;
					}
					else
					{
						num8 = -1797249168;
						num9 = -1797249168;
					}
					num = num8 ^ (int)(num2 * 693588019);
					continue;
				}
				case 28u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -2045908781) ^ -1560694883;
					continue;
				case 27u:
					num = ((int)num2 * -1819032392) ^ -562016740;
					continue;
				case 26u:
					num = (int)(num2 * 993635953) ^ -880352003;
					continue;
				case 24u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 1783016084) ^ 0x661FB02C);
					continue;
				case 23u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -769973183) ^ 0x38199A5F;
					continue;
				case 22u:
					jSONArray.Add(Deserialize(aReader));
					num = 1034701223;
					continue;
				case 21u:
					result = jSONArray;
					num = ((int)num2 * -496681168) ^ 0x1244E4D8;
					continue;
				case 20u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 689853896) ^ -1198090838;
					continue;
				case 19u:
					num = 1232687221;
					continue;
				case 18u:
					goto IL_0196;
				case 17u:
					goto IL_01a0;
				case 16u:
					aItem = Deserialize(aReader);
					num = (int)((num2 * 2037270249) ^ 0x4F2A166F);
					continue;
				case 15u:
					goto IL_01d7;
				case 14u:
					num = 1819620072;
					continue;
				case 13u:
					num6 = 0;
					num = (int)((num2 * 612736383) ^ 0x7A1129F4);
					continue;
				case 12u:
					flag = num6 < num7;
					num = 104456480;
					continue;
				case 11u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Array:
						goto IL_0196;
					case JSONBinaryTag.Class:
						goto IL_01a0;
					case JSONBinaryTag.IntValue:
						goto IL_01d7;
					default:
						goto IL_0243;
					case JSONBinaryTag.Value:
						goto IL_0256;
					case JSONBinaryTag.BoolValue:
						goto IL_0260;
					case JSONBinaryTag.FloatValue:
						goto IL_026a;
					}
					goto case 19u;
				case 8u:
					goto IL_0256;
				case 3u:
					goto IL_0260;
				case 2u:
					goto IL_026a;
				case 10u:
					num = ((int)num2 * -1368204895) ^ -1626181131;
					continue;
				case 9u:
					num3++;
					num = ((int)num2 * -721603533) ^ 0x4CAFEE85;
					continue;
				case 7u:
				{
					int num5;
					if (num3 >= num4)
					{
						num = 785548682;
						num5 = 785548682;
					}
					else
					{
						num = 1849447343;
						num5 = 1849447343;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -423813088) ^ 0x7B6B2A7C;
					continue;
				case 5u:
					num = (int)((num2 * 61002102) ^ 0x6C4DDCFE);
					continue;
				case 4u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1394922886) ^ 0x4D232BF8;
					continue;
				case 1u:
					result = jSONClass;
					num = ((int)num2 * -1730466969) ^ -1850054659;
					continue;
				case 0u:
					num = ((int)num2 * -164185827) ^ -868401244;
					continue;
				case 37u:
					break;
				case 30u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_026a:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = 885116590;
					continue;
					IL_0260:
					num = 1287292791;
					continue;
					IL_0256:
					num = 395324375;
					continue;
					IL_0243:
					num = (int)(num2 * 857872049) ^ -309245640;
					continue;
					IL_01d7:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 615049474;
					continue;
					IL_01a0:
					num4 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num3 = 0;
					num = 965323790;
					continue;
					IL_0196:
					num = 84405419;
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
					int num = 2061510895;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x33DF6Au) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = (int)(num2 * 49936162) ^ -647654584;
							continue;
						case 0u:
							num = (int)(num2 * 1611380944) ^ -1250421471;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
							break;
						case 3u:
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
					IL_0058:
					int num = -1126009703;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xAB254737u) % 4u)
						{
						case 3u:
							num = (int)(num2 * 654565177) ^ -21895915;
							continue;
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)(num2 * 658842729) ^ -227950422;
							continue;
						default:
							goto end_IL_0037;
						case 0u:
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num = 1391574972;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33B95318u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1896526786) ^ -138172354;
					continue;
				case 4u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -450942670) ^ -1796241746;
					continue;
				case 2u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)((num2 * 1097639578) ^ 0x20953433);
					continue;
				case 1u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1853748490) ^ 0x6BB18199;
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
