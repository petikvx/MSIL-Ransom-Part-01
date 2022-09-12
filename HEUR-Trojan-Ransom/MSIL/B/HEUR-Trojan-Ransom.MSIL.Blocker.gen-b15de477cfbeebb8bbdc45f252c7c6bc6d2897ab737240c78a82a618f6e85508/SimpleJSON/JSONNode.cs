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
			JSONNode result = null;
			while (true)
			{
				int num = -1278061153;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB7DE536u) % 3u)
					{
					case 1u:
						goto IL_0004;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0004:
					num = ((int)num2 * -1331433866) ^ -972808725;
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
				int num = 1000128039;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49295E9Au) % 4u)
					{
					case 2u:
						num = ((int)num2 * -61785686) ^ -2133403726;
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -821588659) ^ -1261691467;
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

	public virtual string Value
	{
		get
		{
			string result = "";
			while (true)
			{
				int num = -801399425;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE19CAB66u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = (int)((num2 * 774029641) ^ 0x16795052);
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
			int result = 0;
			while (true)
			{
				int num = -1505126080;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9637416u) % 3u)
					{
					case 2u:
						goto IL_0004;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0004:
					num = (int)((num2 * 999028523) ^ 0x3C972092);
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
				int num = -1878022365;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA90C3075u) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1492121264) ^ 0x3B6E83D0;
						continue;
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1952579045) ^ -1475658588;
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

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -534599428;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF86C8B2Du) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					result = _003Cget_DeepChilds_003Ed__;
					num = ((int)num2 * -230679354) ^ 0x6B7C8150;
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result = default(int);
			int result2 = default(int);
			while (true)
			{
				int num = -121313632;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE761834Du) % 6u)
					{
					case 5u:
						num = (int)(num2 * 1674862375) ^ -1579942501;
						continue;
					case 4u:
						result = 0;
						num = -463214168;
						continue;
					case 3u:
					{
						result2 = 0;
						int num3;
						int num4;
						if (!int.TryParse(Value, out result2))
						{
							num3 = -534017485;
							num4 = -534017485;
						}
						else
						{
							num3 = -1274578775;
							num4 = -1274578775;
						}
						num = num3 ^ ((int)num2 * -701380242);
						continue;
					}
					case 0u:
						result = result2;
						num = ((int)num2 * -745658405) ^ -1856231266;
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
			Value = value.ToString();
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			float result2 = default(float);
			while (true)
			{
				int num = -208177410;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD6A596Du) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
						{
							num3 = 1002877343;
							num4 = 1002877343;
						}
						else
						{
							num3 = 1257734282;
							num4 = 1257734282;
						}
						num = num3 ^ ((int)num2 * -883311259);
						continue;
					}
					case 2u:
						result2 = 0f;
						num = -99813223;
						continue;
					case 1u:
						result2 = result;
						num = ((int)num2 * -626563505) ^ 0x5FEB5410;
						continue;
					case 0u:
						num = ((int)num2 * -1230757052) ^ 0x28855BE1;
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
		}
	}

	public virtual double AsDouble
	{
		get
		{
			bool flag = default(bool);
			double result2 = default(double);
			double result = default(double);
			while (true)
			{
				int num = 1297800188;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x35D210D9u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1322187377;
							num4 = -1322187377;
						}
						else
						{
							num3 = -587378788;
							num4 = -587378788;
						}
						num = num3 ^ ((int)num2 * -712977311);
						continue;
					}
					case 6u:
						num = (int)(num2 * 1700326169) ^ -1827073185;
						continue;
					case 5u:
						result2 = 0.0;
						num = ((int)num2 * -774690158) ^ -337128321;
						continue;
					case 4u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -291600879) ^ 0x53388A7A;
						continue;
					case 2u:
						result = result2;
						num = ((int)num2 * -1667762338) ^ 0x687680E5;
						continue;
					case 1u:
						result = 0.0;
						num = 1588352447;
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
			while (true)
			{
				int num = 1670951493;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x79596E4u) % 3u)
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
					num = (int)(num2 * 1788331106) ^ -1043413286;
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool flag = default(bool);
			bool result = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -576551928;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCCC2D91Cu) % 8u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 2123651785;
							num4 = 2123651785;
						}
						else
						{
							num3 = 1473644325;
							num4 = 1473644325;
						}
						num = num3 ^ ((int)num2 * -1398195240);
						continue;
					}
					case 5u:
						result = result2;
						num = (int)(num2 * 1729638906) ^ -520984055;
						continue;
					case 4u:
						result2 = false;
						num = ((int)num2 * -1605014597) ^ -682446048;
						continue;
					case 3u:
						num = (int)(num2 * 1421321262) ^ -1385552511;
						continue;
					case 1u:
						result = !JSONNode.smethod_1(Value);
						num = -1262098417;
						continue;
					case 0u:
						flag = bool.TryParse(Value, out result2);
						num = (int)((num2 * 1648304401) ^ 0x3831CA62);
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
			while (true)
			{
				int num = 1819203030;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x2508C184) % 3u)
					{
					case 1u:
						value2 = (value ? "true" : "false");
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
					Value = value2;
					num = 570485487;
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
				int num = -1164745451;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x979756E5u) % 3u)
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
					result = this as JSONArray;
					num = (int)(num2 * 434751211) ^ -1246572723;
				}
			}
		}
	}

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = this as JSONClass;
			while (true)
			{
				int num = -1105387285;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC404468Fu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					num = (int)((num2 * 1445192462) ^ 0x64E94830);
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
		while (true)
		{
			int num = 1536607146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C50A890u) % 3u)
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
				num = ((int)num2 * -1377778242) ^ -1754861124;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -827253128;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA08DF469u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1074990167) ^ 0x7B6126EE;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -1993661673) ^ 0x1AFCEBA5;
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

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1214999599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9AB5622u) % 3u)
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
				num = ((int)num2 * -1097545095) ^ 0x310663EB;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = 1234787009;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31B6FAABu) % 3u)
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
				num = ((int)num2 * -933673284) ^ -1075376238;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1472830407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2D743FBu) % 3u)
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
				result = "JSONNode";
				num = (int)((num2 * 1672262013) ^ 0x43A775EE);
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
			int num = -2089157882;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F74D8F9u) % 4u)
				{
				case 3u:
					result = new JSONData(s);
					num = (int)((num2 * 1561457176) ^ 0x607CF4D8);
					continue;
				case 1u:
					num = (int)((num2 * 734959778) ^ 0x1F3E0931);
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

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 1196868969;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x2EF4820u) % 4u)
				{
				case 1u:
					if (!(d == null))
					{
						num = ((int)num2 * -2129543613) ^ 0x2D14D8D3;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 0u:
					obj = d.Value;
					goto IL_001c;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = 499890590;
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
			int num = 1452309872;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6B6E4EF3u) % 7u)
				{
				case 6u:
					if (a is JSONLazyCreator)
					{
						num = 929072960;
						num3 = 929072960;
						continue;
					}
					goto IL_0011;
				case 4u:
					result = true;
					num = ((int)num2 * -1839405834) ^ 0x69EA2DE6;
					continue;
				case 3u:
					num = (int)(num2 * 384301940) ^ -301262828;
					continue;
				case 2u:
					result = (object)a == b;
					num = 584033144;
					continue;
				case 1u:
					if (b == null)
					{
						num = (int)(num2 * 1162151175) ^ -2036292557;
						continue;
					}
					goto IL_0011;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0011:
					num = 805922074;
					num3 = 805922074;
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
			int num = 1658981974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E066AE3u) % 3u)
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
				result = !(a == b);
				num = (int)(num2 * 945317370) ^ -1556954263;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1552661333;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44AFF1A7u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1740899122) ^ 0x5B29E9F4);
					continue;
				case 2u:
					result = (object)this == obj;
					num = (int)((num2 * 1217610251) ^ 0x694CF6EA);
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
			int num = -280029523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90405900u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = (int)(num2 * 2127155523) ^ -977471016;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		int num3 = default(int);
		char c3 = default(char);
		char c = default(char);
		char c2 = default(char);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 441383712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8252D5Fu) % 33u)
				{
				case 32u:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1456176228;
					continue;
				case 31u:
					num3 = 0;
					num = ((int)num2 * -97316583) ^ 0x6AB0B3DA;
					continue;
				case 30u:
					num = 1195654941;
					continue;
				case 29u:
					goto IL_003b;
				case 28u:
					num = (int)((num2 * 555234071) ^ 0x76CEB410);
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 15323504;
					continue;
				case 26u:
					c3 = c;
					num = ((int)num2 * -1399832200) ^ 0x3C3814B3;
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1804748714;
					continue;
				case 24u:
					num = (int)((num2 * 2045179236) ^ 0x5B65602F);
					continue;
				case 23u:
					switch (c2)
					{
					case '\t':
						break;
					case '\v':
						goto IL_003b;
					default:
						goto IL_00dc;
					case '\b':
						goto IL_00ef;
					case '\n':
						goto IL_0105;
					case '\f':
						goto IL_011b;
					case '\r':
						goto IL_0131;
					}
					goto case 32u;
				case 6u:
					goto IL_00ef;
				case 17u:
					goto IL_0105;
				case 1u:
					goto IL_011b;
				case 5u:
					goto IL_0131;
				case 22u:
					num = ((int)num2 * -1067237644) ^ -1732095859;
					continue;
				case 21u:
					num = (int)(num2 * 358899504) ^ -2129245735;
					continue;
				case 20u:
					num = (int)(num2 * 239143534) ^ -1785825205;
					continue;
				case 18u:
				{
					int num6;
					if (c2 != '\\')
					{
						num = 1727158731;
						num6 = 1727158731;
					}
					else
					{
						num = 1542273324;
						num6 = 1542273324;
					}
					continue;
				}
				case 16u:
					string_ = aText;
					num = (int)((num2 * 1390859191) ^ 0x6F7660C);
					continue;
				case 15u:
					num = ((int)num2 * -630788313) ^ 0x47166ED7;
					continue;
				case 14u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 715982572;
						num5 = 715982572;
					}
					else
					{
						num = 377904425;
						num5 = 377904425;
					}
					continue;
				}
				case 13u:
					c2 = c3;
					num = (int)(num2 * 1782360194) ^ -476710935;
					continue;
				case 12u:
				{
					int num4;
					if (c2 != '"')
					{
						num = 92750885;
						num4 = 92750885;
					}
					else
					{
						num = 1837950937;
						num4 = 1837950937;
					}
					continue;
				}
				case 11u:
					num = ((int)num2 * -2108001876) ^ 0x4E4FF13B;
					continue;
				case 10u:
					num = ((int)num2 * -990444569) ^ -583709676;
					continue;
				case 8u:
					result = text;
					num = (int)((num2 * 402824414) ^ 0x30FFA09D);
					continue;
				case 7u:
					text = "";
					num = (int)(num2 * 2005155952) ^ -1430267568;
					continue;
				case 4u:
					num = (int)(num2 * 1274262361) ^ -1323726543;
					continue;
				case 3u:
					c = JSONNode.smethod_2(string_, num3);
					num = 1814974106;
					continue;
				case 2u:
					num3++;
					num = (int)(num2 * 510763074) ^ -1349574294;
					continue;
				case 0u:
					num = ((int)num2 * -1711942795) ^ -741505418;
					continue;
				case 19u:
					break;
				default:
					{
						return result;
					}
					IL_003b:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 585019689;
					continue;
					IL_0131:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1151403100;
					continue;
					IL_011b:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1189494919;
					continue;
					IL_0105:
					text = JSONNode.smethod_3(text, "\\n");
					num = 585019689;
					continue;
					IL_00ef:
					text = JSONNode.smethod_3(text, "\\b");
					num = 585019689;
					continue;
					IL_00dc:
					num = (int)((num2 * 66498516) ^ 0x269B375F);
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		int num5 = default(int);
		string text = default(string);
		char c4 = default(char);
		bool flag9 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag12 = default(bool);
		char c = default(char);
		char c2 = default(char);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		string text2 = default(string);
		bool flag16 = default(bool);
		bool flag13 = default(bool);
		bool flag7 = default(bool);
		char c3 = default(char);
		bool flag8 = default(bool);
		char c5 = default(char);
		bool flag14 = default(bool);
		bool flag6 = default(bool);
		bool flag15 = default(bool);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1921621187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26189E5Bu) % 153u)
				{
				case 152u:
					num = (int)((num2 * 1826947505) ^ 0x5D27352A);
					continue;
				case 151u:
				{
					string s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num5 += 4;
					num = ((int)num2 * -2068135645) ^ 0x6CB1F30C;
					continue;
				}
				case 150u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1228794377) ^ 0x62FE3C08;
					continue;
				case 149u:
				{
					int num47;
					int num48;
					if ((uint)c4 <= 32u)
					{
						num47 = -614369326;
						num48 = -614369326;
					}
					else
					{
						num47 = -232906851;
						num48 = -232906851;
					}
					num = num47 ^ ((int)num2 * -116842957);
					continue;
				}
				case 148u:
					num5 = 0;
					num = ((int)num2 * -1203406510) ^ -1502031095;
					continue;
				case 147u:
					num = (int)(num2 * 482748165) ^ -209430003;
					continue;
				case 146u:
				{
					int num29;
					int num30;
					if (!flag9)
					{
						num29 = -1656658682;
						num30 = -1656658682;
					}
					else
					{
						num29 = -405020808;
						num30 = -405020808;
					}
					num = num29 ^ (int)(num2 * 1994602726);
					continue;
				}
				case 145u:
					num = ((int)num2 * -1438646475) ^ 0x76E6430E;
					continue;
				case 144u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 822841744) ^ -631702413;
					continue;
				case 143u:
					flag2 = flag3;
					num = 158472215;
					continue;
				case 142u:
					flag3 = !flag3;
					num = 1105460001;
					continue;
				case 141u:
					jSONNode.Add(text);
					num = ((int)num2 * -1705439232) ^ -2093207380;
					continue;
				case 140u:
					num = (int)((num2 * 1488227301) ^ 0x683D2CBC);
					continue;
				case 139u:
				{
					int num43;
					int num44;
					if (c4 != ':')
					{
						num43 = -261532871;
						num44 = -261532871;
					}
					else
					{
						num43 = -202011646;
						num44 = -202011646;
					}
					num = num43 ^ (int)(num2 * 2001757023);
					continue;
				}
				case 138u:
				{
					int num35;
					int num36;
					if (flag12)
					{
						num35 = 322314225;
						num36 = 322314225;
					}
					else
					{
						num35 = 1486008836;
						num36 = 1486008836;
					}
					num = num35 ^ (int)(num2 * 1553171314);
					continue;
				}
				case 137u:
				{
					int num26;
					if (!flag3)
					{
						num = 661800572;
						num26 = 661800572;
					}
					else
					{
						num = 963574884;
						num26 = 963574884;
					}
					continue;
				}
				case 136u:
					text = JSONNode.smethod_3(text, "\f");
					num = 2013882500;
					continue;
				case 135u:
				{
					int num19;
					if (c4 == '{')
					{
						num = 1104733014;
						num19 = 1104733014;
					}
					else
					{
						num = 1247274020;
						num19 = 1247274020;
					}
					continue;
				}
				case 134u:
					c = JSONNode.smethod_2(aJSON, num5);
					c2 = c;
					num = ((int)num2 * -575051715) ^ 0x3DB8EB30;
					continue;
				case 133u:
					num = 346477515;
					continue;
				case 132u:
					num = 458085617;
					continue;
				case 131u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 2017777296) ^ 0x15B48312);
					continue;
				case 130u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -971763412) ^ -1083090606;
					continue;
				case 128u:
					num = ((int)num2 * -144536532) ^ -644599745;
					continue;
				case 127u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num57;
					int num58;
					if (!(jSONNode is JSONArray))
					{
						num57 = 207410136;
						num58 = 207410136;
					}
					else
					{
						num57 = 270285388;
						num58 = 270285388;
					}
					num = num57 ^ (int)(num2 * 313160394);
					continue;
				}
				case 126u:
					num = 1808645647;
					continue;
				case 125u:
					flag16 = flag3;
					num = 1611740869;
					continue;
				case 124u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 788088344) ^ 0x4E5FEE6A);
					continue;
				case 123u:
					text2 = JSONNode.smethod_5(text2);
					flag13 = jSONNode is JSONArray;
					num = (int)(num2 * 1107679759) ^ -783452511;
					continue;
				case 122u:
					flag7 = jSONNode != null;
					num = ((int)num2 * -127863393) ^ -643051696;
					continue;
				case 121u:
					num = ((int)num2 * -645079184) ^ 0x504E2CCD;
					continue;
				case 120u:
					num = (int)(num2 * 800849350) ^ -2031764616;
					continue;
				case 119u:
				{
					int num49;
					int num50;
					if (flag3)
					{
						num49 = 1337476810;
						num50 = 1337476810;
					}
					else
					{
						num49 = 1545401011;
						num50 = 1545401011;
					}
					num = num49 ^ ((int)num2 * -267327531);
					continue;
				}
				case 118u:
					num = (int)((num2 * 2043875961) ^ 0x4176C9BC);
					continue;
				case 117u:
				{
					int num39;
					int num40;
					if (flag13)
					{
						num39 = -1861436903;
						num40 = -1861436903;
					}
					else
					{
						num39 = -55719624;
						num40 = -55719624;
					}
					num = num39 ^ ((int)num2 * -1112411793);
					continue;
				}
				case 116u:
					num = ((int)num2 * -1606586520) ^ 0x103588EA;
					continue;
				case 115u:
				{
					int num34;
					if (c3 == 'f')
					{
						num = 2124080750;
						num34 = 2124080750;
					}
					else
					{
						num = 1051003374;
						num34 = 1051003374;
					}
					continue;
				}
				case 114u:
					switch (c4)
					{
					case '\t':
						break;
					default:
						goto IL_0465;
					case '\v':
					case '\f':
						goto IL_0478;
					case '\n':
					case '\r':
						goto IL_0499;
					}
					goto case 143u;
				case 24u:
					goto IL_0478;
				case 1u:
				case 14u:
				case 45u:
				case 83u:
				case 94u:
					goto IL_0499;
				case 113u:
				{
					int num25;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 1814692179;
						num25 = 1814692179;
					}
					else
					{
						num = 1776374582;
						num25 = 1776374582;
					}
					continue;
				}
				case 112u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1531131674) ^ 0x396CF3C0;
					continue;
				case 111u:
				{
					int num22;
					if (c4 != '"')
					{
						num = 1581709704;
						num22 = 1581709704;
					}
					else
					{
						num = 564016338;
						num22 = 564016338;
					}
					continue;
				}
				case 110u:
					num = (int)(num2 * 2136011135) ^ -698624482;
					continue;
				case 109u:
					num = 952535649;
					continue;
				case 108u:
				{
					int num16;
					int num17;
					if (flag8)
					{
						num16 = 240580625;
						num17 = 240580625;
					}
					else
					{
						num16 = 680635036;
						num17 = 680635036;
					}
					num = num16 ^ ((int)num2 * -989293668);
					continue;
				}
				case 107u:
					flag8 = stack.Count == 0;
					num = 2019647030;
					continue;
				case 106u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 1663187818) ^ -1000295258;
					continue;
				case 105u:
					text = JSONNode.smethod_3(text, "\n");
					num = 691201501;
					continue;
				case 104u:
					text2 = "";
					num = 1764801225;
					continue;
				case 103u:
					goto IL_05c0;
				case 102u:
					switch (c3)
					{
					case 'u':
						break;
					default:
						goto IL_05e8;
					case 'r':
						goto IL_05f2;
					case 's':
						goto IL_0608;
					case 't':
						goto IL_0620;
					}
					goto case 126u;
				case 5u:
					goto IL_05f2;
				case 9u:
					goto IL_0608;
				case 28u:
					goto IL_0620;
				case 101u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1591155150) ^ 0xC2A5580);
					continue;
				case 100u:
					text = "";
					text2 = "";
					num = (int)(num2 * 954721990) ^ -219697204;
					continue;
				case 99u:
				{
					int num62;
					int num63;
					if (flag16)
					{
						num62 = -1912259060;
						num63 = -1912259060;
					}
					else
					{
						num62 = -263100268;
						num63 = -263100268;
					}
					num = num62 ^ (int)(num2 * 406904091);
					continue;
				}
				case 98u:
				{
					int num61;
					if (c3 != 'n')
					{
						num = 173151719;
						num61 = 173151719;
					}
					else
					{
						num = 1598244828;
						num61 = 1598244828;
					}
					continue;
				}
				case 97u:
					c5 = JSONNode.smethod_2(aJSON, num5);
					num = (int)((num2 * 315877006) ^ 0x431026D8);
					continue;
				case 96u:
					num = (int)((num2 * 1646567945) ^ 0x7F00837F);
					continue;
				case 95u:
				{
					int num59;
					int num60;
					if (jSONNode is JSONArray)
					{
						num59 = 871672147;
						num60 = 871672147;
					}
					else
					{
						num59 = 382191028;
						num60 = 382191028;
					}
					num = num59 ^ ((int)num2 * -749774245);
					continue;
				}
				case 93u:
					num = (int)(num2 * 1516332584) ^ -1472473058;
					continue;
				case 92u:
				{
					int num56;
					if (c4 != ',')
					{
						num = 639167238;
						num56 = 639167238;
					}
					else
					{
						num = 568945903;
						num56 = 568945903;
					}
					continue;
				}
				case 91u:
					flag14 = jSONNode is JSONArray;
					num = (int)((num2 * 221406045) ^ 0x2EA71CF6);
					continue;
				case 90u:
				{
					int num55;
					if (c4 == '}')
					{
						num = 358209685;
						num55 = 358209685;
					}
					else
					{
						num = 730519726;
						num55 = 730519726;
					}
					continue;
				}
				case 88u:
				{
					int num53;
					int num54;
					if (flag6)
					{
						num53 = -2071460086;
						num54 = -2071460086;
					}
					else
					{
						num53 = -1852820304;
						num54 = -1852820304;
					}
					num = num53 ^ ((int)num2 * -1249568663);
					continue;
				}
				case 87u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -893195196) ^ 0x6E0B3EA3;
					continue;
				case 86u:
				{
					int num51;
					int num52;
					if (flag15)
					{
						num51 = 1317397419;
						num52 = 1317397419;
					}
					else
					{
						num51 = 767152203;
						num52 = 767152203;
					}
					num = num51 ^ ((int)num2 * -151016036);
					continue;
				}
				case 85u:
					num = (int)(num2 * 331088869) ^ -543452609;
					continue;
				case 82u:
					num = (int)(num2 * 1144361484) ^ -1801445062;
					continue;
				case 81u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 2010633135) ^ -1527853916;
					continue;
				case 80u:
					flag15 = jSONNode != null;
					num = ((int)num2 * -1243502396) ^ 0x59649607;
					continue;
				case 79u:
					num = ((int)num2 * -53394762) ^ -1654632725;
					continue;
				case 78u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 726300377) ^ 0x54702BA2);
					continue;
				case 77u:
					num = (int)(num2 * 737908309) ^ -1034785496;
					continue;
				case 76u:
					num = (int)((num2 * 2115191248) ^ 0x1F82F1BC);
					continue;
				case 75u:
					text2 = "";
					text = "";
					num = 1984304373;
					continue;
				case 74u:
					num = ((int)num2 * -1116511051) ^ -1126179170;
					continue;
				case 73u:
					num = 316194038;
					continue;
				case 72u:
				{
					int num45;
					int num46;
					if (flag4)
					{
						num45 = 1654046882;
						num46 = 1654046882;
					}
					else
					{
						num45 = 1949840620;
						num46 = 1949840620;
					}
					num = num45 ^ (int)(num2 * 589195498);
					continue;
				}
				case 71u:
				{
					int num41;
					int num42;
					if (flag14)
					{
						num41 = 347613990;
						num42 = 347613990;
					}
					else
					{
						num41 = 1887864410;
						num42 = 1887864410;
					}
					num = num41 ^ ((int)num2 * -1856608862);
					continue;
				}
				case 70u:
					num = (int)((num2 * 994614899) ^ 0x54D9E6DA);
					continue;
				case 69u:
					num = ((int)num2 * -198483282) ^ -847449568;
					continue;
				case 68u:
					jSONNode.Add(text);
					num = (int)((num2 * 1569881459) ^ 0x37E4F07E);
					continue;
				case 67u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 1124696169) ^ -1555129349;
					continue;
				case 66u:
					num = ((int)num2 * -1567046110) ^ 0x24182450;
					continue;
				case 65u:
					num = (int)((num2 * 229700378) ^ 0x1AE82728);
					continue;
				case 64u:
				{
					int num38;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 321057110;
						num38 = 321057110;
					}
					else
					{
						num = 1730088850;
						num38 = 1730088850;
					}
					continue;
				}
				case 63u:
				{
					int num37;
					if ((uint)c4 > 93u)
					{
						num = 1690569570;
						num37 = 1690569570;
					}
					else
					{
						num = 322397303;
						num37 = 322397303;
					}
					continue;
				}
				case 62u:
					num = 1611640262;
					continue;
				case 61u:
					num = 1297258182;
					continue;
				case 60u:
				{
					int num33;
					if (c4 != ' ')
					{
						num = 1693629168;
						num33 = 1693629168;
					}
					else
					{
						num = 604352510;
						num33 = 604352510;
					}
					continue;
				}
				case 59u:
				{
					c3 = c2;
					int num31;
					int num32;
					if ((uint)c3 > 102u)
					{
						num31 = -606016009;
						num32 = -606016009;
					}
					else
					{
						num31 = -1818712177;
						num32 = -1818712177;
					}
					num = num31 ^ ((int)num2 * -224367739);
					continue;
				}
				case 58u:
				{
					int num27;
					int num28;
					if (c3 != 'b')
					{
						num27 = 2105788023;
						num28 = 2105788023;
					}
					else
					{
						num27 = 908511544;
						num28 = 908511544;
					}
					num = num27 ^ (int)(num2 * 1199391994);
					continue;
				}
				case 57u:
					num = (int)((num2 * 2021379344) ^ 0x666F000A);
					continue;
				case 56u:
					flag11 = JSONNode.smethod_6(text, "");
					num = 551197648;
					continue;
				case 55u:
					num = (int)((num2 * 941514393) ^ 0x31902B60);
					continue;
				case 54u:
					result = jSONNode;
					num = 25077876;
					continue;
				case 53u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -843558230) ^ -1183052616;
					continue;
				case 52u:
					stack.Push(new JSONClass());
					num = 1917886285;
					continue;
				case 51u:
					text = JSONNode.smethod_3(text, "\b");
					num = 303615476;
					continue;
				case 50u:
					goto IL_0b45;
				case 49u:
				{
					int num23;
					int num24;
					if ((uint)c4 <= 44u)
					{
						num23 = 687108665;
						num24 = 687108665;
					}
					else
					{
						num23 = 1697612564;
						num24 = 1697612564;
					}
					num = num23 ^ (int)(num2 * 699221368);
					continue;
				}
				case 48u:
					num = ((int)num2 * -1782480508) ^ -1761681930;
					continue;
				case 47u:
					num = (int)((num2 * 299413427) ^ 0x32BBCE37);
					continue;
				case 46u:
					text = "";
					num = ((int)num2 * -2109180025) ^ -369195957;
					continue;
				case 44u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -613132942) ^ 0x3DF4C6F6;
					continue;
				case 42u:
					flag5 = JSONNode.smethod_6(text2, "");
					num = 192922435;
					continue;
				case 41u:
					num = ((int)num2 * -169190286) ^ -326047315;
					continue;
				case 40u:
					text2 = "";
					text = "";
					num = 1643463446;
					continue;
				case 39u:
					num = ((int)num2 * -1611526866) ^ -822421260;
					continue;
				case 38u:
				{
					int num20;
					int num21;
					if (!flag11)
					{
						num20 = 445772238;
						num21 = 445772238;
					}
					else
					{
						num20 = 1010149756;
						num21 = 1010149756;
					}
					num = num20 ^ (int)(num2 * 818472472);
					continue;
				}
				case 37u:
					num = (int)((num2 * 1881159116) ^ 0x444563CE);
					continue;
				case 36u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 488003130) ^ -1258388742;
					continue;
				case 35u:
					num = ((int)num2 * -1594280392) ^ 0x18575F84;
					continue;
				case 34u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1067869064) ^ 0x16183AD3;
					continue;
				case 33u:
					text2 = "";
					text = "";
					flag10 = stack.Count > 0;
					num = 1133431656;
					continue;
				case 32u:
				{
					int num18;
					if (num5 < JSONNode.smethod_4(aJSON))
					{
						num = 1072756360;
						num18 = 1072756360;
					}
					else
					{
						num = 1539825031;
						num18 = 1539825031;
					}
					continue;
				}
				case 31u:
					num = ((int)num2 * -1932692651) ^ 0x3F874CCA;
					continue;
				case 30u:
				{
					int num14;
					int num15;
					if (flag10)
					{
						num14 = 10947204;
						num15 = 10947204;
					}
					else
					{
						num14 = 1595759804;
						num15 = 1595759804;
					}
					num = num14 ^ ((int)num2 * -310957324);
					continue;
				}
				case 29u:
					flag3 = false;
					num = ((int)num2 * -1232102083) ^ -121289686;
					continue;
				case 27u:
					c4 = c5;
					num = (int)(num2 * 276804801) ^ -1380674729;
					continue;
				case 26u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num = ((int)num2 * -1165798585) ^ 0x5793CA8C;
					continue;
				case 25u:
					flag9 = flag3;
					num = 1968233193;
					continue;
				case 23u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 415062133;
						num13 = 415062133;
					}
					else
					{
						num12 = 356290142;
						num13 = 356290142;
					}
					num = num12 ^ ((int)num2 * -1194329803);
					continue;
				}
				case 22u:
					num = ((int)num2 * -1468954481) ^ 0xA0D708F;
					continue;
				case 21u:
				{
					int num10;
					int num11;
					if (!flag7)
					{
						num10 = -537019840;
						num11 = -537019840;
					}
					else
					{
						num10 = -1815526913;
						num11 = -1815526913;
					}
					num = num10 ^ (int)(num2 * 1829704447);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1010108382) ^ 0x79C374D2;
					continue;
				case 19u:
					num = (int)((num2 * 2097009157) ^ 0x1C080481);
					continue;
				case 18u:
					stack.Push(new JSONArray());
					num = 1879952008;
					continue;
				case 17u:
					num = (int)((num2 * 1293995837) ^ 0x548800FD);
					continue;
				case 16u:
					switch (c4)
					{
					case ']':
						break;
					case '\\':
						goto IL_05c0;
					case '[':
						goto IL_0b45;
					default:
						goto IL_0e5a;
					}
					goto case 137u;
				case 15u:
					num = (int)((num2 * 1538363561) ^ 0x32668094);
					continue;
				case 13u:
					stack.Pop();
					flag6 = JSONNode.smethod_6(text, "");
					num = 1613910082;
					continue;
				case 12u:
					num = (int)((num2 * 1556027123) ^ 0x72617533);
					continue;
				case 11u:
					num = ((int)num2 * -877810981) ^ 0x502D82DE;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (flag5)
					{
						num8 = -1907009113;
						num9 = -1907009113;
					}
					else
					{
						num8 = -834945542;
						num9 = -834945542;
					}
					num = num8 ^ ((int)num2 * -620095174);
					continue;
				}
				case 8u:
					num = (int)(num2 * 728639195) ^ -1514151595;
					continue;
				case 7u:
					flag4 = flag3;
					num = 249283472;
					continue;
				case 6u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 486808190;
						num7 = 486808190;
					}
					else
					{
						num6 = 1882159718;
						num7 = 1882159718;
					}
					num = num6 ^ ((int)num2 * -947296737);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1638594610) ^ 0x36F00D19;
					continue;
				case 3u:
					flag = JSONNode.smethod_6(text2, "");
					num = 1229866554;
					continue;
				case 2u:
					text2 = text;
					text = "";
					num = 1643463446;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 981462987;
						num4 = 981462987;
					}
					else
					{
						num3 = 1098403641;
						num4 = 1098403641;
					}
					num = num3 ^ (int)(num2 * 337859509);
					continue;
				}
				case 129u:
					break;
				case 43u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 84u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0608:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 2029940471;
					continue;
					IL_05f2:
					text = JSONNode.smethod_3(text, "\r");
					num = 855432466;
					continue;
					IL_0620:
					text = JSONNode.smethod_3(text, "\t");
					num = 1799258410;
					continue;
					IL_0e5a:
					num = 880991557;
					continue;
					IL_05c0:
					num5++;
					num = 1731291882;
					continue;
					IL_05e8:
					num = 399514969;
					continue;
					IL_0b45:
					flag12 = flag3;
					num = 1782401610;
					continue;
					IL_0478:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = 490146844;
					continue;
					IL_0465:
					num = (int)(num2 * 857393541) ^ -1106637316;
					continue;
					IL_0499:
					num5++;
					num = 2137015740;
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
		BinaryWriter aWriter = JSONNode.smethod_9(aData);
		while (true)
		{
			int num = 268942850;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x556059C5u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				Serialize(aWriter);
				num = (int)((num2 * 59805294) ^ 0x74478C58);
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
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_006e:
					int num = 1918835469;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x4F9D3304u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 1622615384) ^ 0x610279EC);
							continue;
						case 0u:
							num = (int)(num2 * 438010114) ^ -1344430165;
							continue;
						default:
							goto end_IL_004d;
						case 2u:
							break;
						case 3u:
							goto end_IL_004d;
						}
						goto IL_006e;
						continue;
						end_IL_004d:
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
				int num = -745412095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE62D5F6Cu) % 4u)
					{
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1947853239) ^ -1012075853;
						continue;
					case 0u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1989557130) ^ -1853830470;
						continue;
					case 3u:
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
					int num3 = -2041601806;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE62D5F6Cu) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 208475213) ^ 0x10DA2CCF);
							continue;
						case 1u:
							num3 = (int)(num2 * 421830828) ^ -1860126656;
							continue;
						default:
							goto end_IL_0098;
						case 3u:
							break;
						case 0u:
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
		JSONNode result = default(JSONNode);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num7 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num8 = default(int);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1757299806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4BF1771u) % 43u)
				{
				case 42u:
					num = ((int)num2 * -473110555) ^ -407300727;
					continue;
				case 41u:
					num = (int)((num2 * 1140563013) ^ 0x38438E42);
					continue;
				case 40u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1127879933;
					continue;
				case 39u:
					flag2 = num5 < num6;
					num = -1271460345;
					continue;
				case 38u:
					num = (int)(num2 * 1672937338) ^ -133262312;
					continue;
				case 37u:
					jSONArray.Add(Deserialize(aReader));
					num = -577105261;
					continue;
				case 36u:
					goto IL_007e;
				case 35u:
					num5++;
					num = ((int)num2 * -1155091968) ^ 0x3B5C96D3;
					continue;
				case 34u:
					num = -372881441;
					continue;
				case 33u:
					num = ((int)num2 * -1802366790) ^ -433614475;
					continue;
				case 32u:
					result = jSONArray;
					num = ((int)num2 * -1267585194) ^ 0x209F6EAC;
					continue;
				case 31u:
					num7 = 0;
					num = (int)(num2 * 399824519) ^ -2021560618;
					continue;
				case 30u:
					num = ((int)num2 * -1440736140) ^ -1919383700;
					continue;
				case 29u:
					num = ((int)num2 * -920599797) ^ -1518413920;
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -121803905) ^ 0x5FBF5307;
					continue;
				case 27u:
					num6 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 1104373129) ^ 0x6F0A1A0D);
					continue;
				case 26u:
					num = (int)((num2 * 742748636) ^ 0x517A8CE5);
					continue;
				case 25u:
					goto IL_016b;
				case 24u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.FloatValue:
						break;
					case JSONBinaryTag.DoubleValue:
						goto IL_007e;
					case JSONBinaryTag.Class:
						goto IL_016b;
					default:
						goto IL_0199;
					case JSONBinaryTag.Array:
						goto IL_01ac;
					case JSONBinaryTag.Value:
						goto IL_01b6;
					case JSONBinaryTag.IntValue:
						goto IL_01cd;
					case JSONBinaryTag.BoolValue:
						goto IL_01e4;
					}
					goto case 40u;
				case 3u:
					goto IL_01ac;
				case 12u:
					goto IL_01b6;
				case 20u:
					goto IL_01cd;
				case 7u:
					goto IL_01e4;
				case 23u:
				{
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -909679012) ^ 0x6FCD5603;
					continue;
				}
				case 22u:
					num8 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = ((int)num2 * -72379841) ^ -949857181;
					continue;
				case 21u:
					num5 = 0;
					num = ((int)num2 * -202796108) ^ 0x6F9F400A;
					continue;
				case 18u:
					num7++;
					num = (int)((num2 * 687847150) ^ 0x4760E9DA);
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -420623366;
						num10 = -420623366;
					}
					else
					{
						num9 = -1850805927;
						num10 = -1850805927;
					}
					num = num9 ^ ((int)num2 * -1429008943);
					continue;
				}
				case 16u:
					result = jSONClass;
					num = ((int)num2 * -158373710) ^ -622114003;
					continue;
				case 15u:
					num = ((int)num2 * -838435581) ^ 0x1204BA38;
					continue;
				case 14u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1522543939) ^ -433749847;
					continue;
				}
				case 13u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -302842477) ^ 0x17CE7022;
					continue;
				case 11u:
					flag = num7 < num8;
					num = -322113096;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1594347675;
						num4 = 1594347675;
					}
					else
					{
						num3 = 524247467;
						num4 = 524247467;
					}
					num = num3 ^ (int)(num2 * 938766316);
					continue;
				}
				case 6u:
					num = -1174214398;
					continue;
				case 5u:
					num = ((int)num2 * -409294762) ^ -720082208;
					continue;
				case 4u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)((num2 * 1926306090) ^ 0x130B2032);
					continue;
				case 2u:
					num = ((int)num2 * -1989327361) ^ -1929159385;
					continue;
				case 1u:
					num = ((int)num2 * -761497943) ^ -1974983801;
					continue;
				case 0u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1983481192) ^ -1661147378;
					continue;
				case 19u:
					break;
				case 9u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_01e4:
					num = -43252252;
					continue;
					IL_01cd:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -805695720;
					continue;
					IL_01b6:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1787378383;
					continue;
					IL_01ac:
					num = -106431789;
					continue;
					IL_0199:
					num = ((int)num2 * -1689428676) ^ 0x5FB48C5C;
					continue;
					IL_016b:
					num = -366465297;
					continue;
					IL_007e:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -871218538;
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
					IL_0045:
					int num = 1736400547;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x1D1FA74u) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = ((int)num2 * -1863099970) ^ 0x2550DBA8;
						continue;
						end_IL_0028:
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -305970633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x894D642Cu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					case 0u:
						return result;
					}
					break;
					IL_000a:
					result = LoadFromStream(fileStream);
					num = ((int)num2 * -1137036743) ^ 0x2D020957;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0079:
					int num3 = -100472482;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x894D642Cu) % 3u)
						{
						case 2u:
							goto IL_0049;
						default:
							goto end_IL_005c;
						case 0u:
							break;
						case 1u:
							goto end_IL_005c;
						}
						goto IL_0079;
						IL_0049:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)(num2 * 6162327) ^ -1111384495;
						continue;
						end_IL_005c:
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
			int num = -948586458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1E287A5u) % 8u)
				{
				case 6u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1972399684) ^ 0x140F1095;
					continue;
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 894412217) ^ 0x3C838521);
					continue;
				case 3u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)((num2 * 721849734) ^ 0x7A869942);
					continue;
				case 2u:
					num = (int)((num2 * 1605497583) ^ 0x16550D);
					continue;
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1975843552) ^ 0x79713407;
					continue;
				case 0u:
					num = ((int)num2 * -1869656507) ^ 0x2CDBE4A9;
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

	public JSONNode()
	{
		while (true)
		{
			int num = -952693588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x943A9292u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1738903262) ^ -176490175;
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
