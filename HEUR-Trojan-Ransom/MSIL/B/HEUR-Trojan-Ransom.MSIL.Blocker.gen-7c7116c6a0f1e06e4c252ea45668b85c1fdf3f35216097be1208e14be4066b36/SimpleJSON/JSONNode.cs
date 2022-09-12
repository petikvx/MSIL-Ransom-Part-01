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
			JSONNode result = null;
			while (true)
			{
				int num = 903943087;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCC5274u) % 3u)
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
					num = (int)(num2 * 1765452914) ^ -1305520194;
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
			return "";
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
				int num = 1084511042;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x612A3A10u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1167399610) ^ 0x11086FDF);
						continue;
					case 2u:
						result = 0;
						num = ((int)num2 * -898258767) ^ 0x336DD199;
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

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 297265158;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x14854305u) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 533992732) ^ -325822205;
						continue;
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -2011548653) ^ -409166878;
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
				int num = 1792846553;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B5BFF56u) % 3u)
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
					num = ((int)num2 * -872467780) ^ 0x4A68A961;
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
				int num = 1765255309;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FB19202u) % 6u)
					{
					case 5u:
						result2 = 0;
						num = 1080643078;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (int.TryParse(Value, out result))
						{
							num3 = 1009237591;
							num4 = 1009237591;
						}
						else
						{
							num3 = 1596729831;
							num4 = 1596729831;
						}
						num = num3 ^ (int)(num2 * 743256612);
						continue;
					}
					case 2u:
						num = ((int)num2 * -605299377) ^ 0x5F0E900;
						continue;
					case 1u:
						result2 = result;
						num = ((int)num2 * -477650514) ^ -500523358;
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
				int num = 1915728537;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A604947u) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = ((int)num2 * -306171863) ^ -636556660;
						continue;
					case 1u:
						num = ((int)num2 * -1022134447) ^ -393972603;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
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
				int num = 2014957277;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BBD1171u) % 5u)
					{
					case 3u:
						result2 = 0f;
						num = 444324971;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
						{
							num3 = 483948435;
							num4 = 483948435;
						}
						else
						{
							num3 = 1554506777;
							num4 = 1554506777;
						}
						num = num3 ^ (int)(num2 * 319877203);
						continue;
					}
					case 0u:
						result2 = result;
						num = ((int)num2 * -117730316) ^ -1105279077;
						continue;
					case 4u:
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
			double result = 0.0;
			double result2 = default(double);
			while (true)
			{
				int num = -2110414563;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD97CAFE2u) % 6u)
					{
					case 5u:
						num = (int)((num2 * 384006193) ^ 0x4775ACAF);
						continue;
					case 3u:
						result2 = 0.0;
						num = -1104586952;
						continue;
					case 2u:
						result2 = result;
						num = (int)(num2 * 2136624623) ^ -2005073879;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (double.TryParse(Value, out result))
						{
							num3 = -1509575749;
							num4 = -1509575749;
						}
						else
						{
							num3 = -643879456;
							num4 = -643879456;
						}
						num = num3 ^ (int)(num2 * 462534035);
						continue;
					}
					case 4u:
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

	public virtual bool AsBool
	{
		get
		{
			bool result = default(bool);
			bool result2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = -707422242;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBC52572Cu) % 6u)
					{
					case 3u:
						result = !JSONNode.smethod_1(Value);
						num = -270202029;
						continue;
					case 2u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = (int)(num2 * 494990923) ^ -814303979;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1241509416;
							num4 = -1241509416;
						}
						else
						{
							num3 = -206699897;
							num4 = -206699897;
						}
						num = num3 ^ (int)(num2 * 270639996);
						continue;
					}
					case 0u:
						result = result2;
						num = (int)((num2 * 1791630515) ^ 0x43620F83);
						continue;
					case 4u:
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
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = this as JSONArray;
			while (true)
			{
				int num = -2122104821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90ADA4FFu) % 3u)
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
					num = (int)((num2 * 7758712) ^ 0x71D01CF6);
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
				int num = -225554407;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA04B9E0u) % 4u)
					{
					case 1u:
						result = this as JSONClass;
						num = ((int)num2 * -1329701474) ^ -640968662;
						continue;
					case 0u:
						num = (int)(num2 * 1600698557) ^ -950597233;
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

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 2104548137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5916037Au) % 3u)
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
				Add("", aItem);
				num = ((int)num2 * -508109836) ^ 0x46921619;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1951555562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73ACCBA7u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1264966578) ^ -876137528;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -1218461369) ^ 0x686C4806;
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

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1675640068;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5BEFCB6u) % 3u)
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
				result = null;
				num = ((int)num2 * -1931919701) ^ 0x6A0296EE;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 889767595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x246375D2u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 860121975) ^ -346784343;
					continue;
				case 1u:
					result = aNode;
					num = ((int)num2 * -301163596) ^ 0x7D3FCA89;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1055164893;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3C60A42u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 117706874) ^ 0x68E7354A);
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)((num2 * 2114247552) ^ 0xF4A5880);
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

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 280466943;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63129010u) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = ((int)num2 * -384616081) ^ -180062832;
					continue;
				case 1u:
					num = ((int)num2 * -1614140003) ^ -95848113;
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

	public static implicit operator JSONNode(string s)
	{
		return new JSONData(s);
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -286173712;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xB83392BAu) % 5u)
				{
				case 3u:
					if (!(d == null))
					{
						num = ((int)num2 * -234601333) ^ 0x2F62FC34;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					num = ((int)num2 * -1639810309) ^ 0x30760148;
					continue;
				case 1u:
					obj = d.Value;
					goto IL_001c;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = -1613498078;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b == null)
		{
			goto IL_0012;
		}
		int num = 0;
		goto IL_007e;
		IL_0075:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_007e;
		IL_0012:
		int num2 = -503466540;
		goto IL_004c;
		IL_004c:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xFA18DC33u) % 6u)
			{
			case 5u:
				result = (object)a == b;
				num2 = -1857991349;
				continue;
			case 4u:
				break;
			case 3u:
				result = true;
				num2 = ((int)num3 * -1538015465) ^ 0x70EE66FC;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 2099402428;
					num5 = 2099402428;
				}
				else
				{
					num4 = 2049610322;
					num5 = 2049610322;
				}
				num2 = num4 ^ (int)(num3 * 1767599656);
				continue;
			}
			case 1u:
				goto IL_0075;
			default:
				return result;
			}
			break;
		}
		goto IL_0012;
		IL_007e:
		flag = (byte)num != 0;
		num2 = -524275341;
		goto IL_004c;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -12484841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA21BBE21u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)(num2 * 1684623499) ^ -1956597695;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1374606751;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0F0FE56u) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = (int)(num2 * 1762839258) ^ -390340463;
					continue;
				case 1u:
					num = ((int)num2 * -690839829) ^ -1752919129;
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
		int result = default(int);
		while (true)
		{
			int num = -1197271678;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF7E2DD7u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1369775810) ^ 0x220B2D89;
					continue;
				case 1u:
					result = this.method_0();
					num = (int)(num2 * 97651936) ^ -2029386280;
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

	internal static string Escape(string aText)
	{
		string text = default(string);
		char c = default(char);
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		char c3 = default(char);
		char c2 = default(char);
		while (true)
		{
			int num = 452632449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6DE90D83u) % 30u)
				{
				case 29u:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1680917146;
					continue;
				case 28u:
					num = (int)((num2 * 1189234947) ^ 0x8D9A22A);
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 854295070;
					continue;
				case 26u:
					num = ((int)num2 * -1728187132) ^ 0x664904A;
					continue;
				case 25u:
				{
					int num6;
					if (c == '"')
					{
						num = 870771508;
						num6 = 870771508;
					}
					else
					{
						num = 223383965;
						num6 = 223383965;
					}
					continue;
				}
				case 23u:
					num = 976556654;
					continue;
				case 22u:
					goto IL_0084;
				case 21u:
					num = ((int)num2 * -231532870) ^ 0x312D8E9D;
					continue;
				case 20u:
				{
					int num5;
					if (c == '\\')
					{
						num = 1691985288;
						num5 = 1691985288;
					}
					else
					{
						num = 826048227;
						num5 = 826048227;
					}
					continue;
				}
				case 19u:
					num = ((int)num2 * -894935790) ^ 0x17641AFC;
					continue;
				case 18u:
					result = text;
					num = ((int)num2 * -1975219609) ^ -1394316918;
					continue;
				case 17u:
					string_ = aText;
					num3 = 0;
					num = (int)(num2 * 883803104) ^ -182972210;
					continue;
				case 16u:
					text = "";
					num = (int)((num2 * 702127739) ^ 0x2E8CC300);
					continue;
				case 15u:
					c = c3;
					num = (int)((num2 * 780472650) ^ 0x10E8879D);
					continue;
				case 14u:
					c2 = JSONNode.smethod_2(string_, num3);
					c3 = c2;
					num = 1557132992;
					continue;
				case 12u:
					num = (int)((num2 * 827333979) ^ 0x131FFFB0);
					continue;
				case 11u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 2092924957;
					continue;
				case 10u:
				{
					int num4;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = 1688743545;
						num4 = 1688743545;
					}
					else
					{
						num = 515886085;
						num4 = 515886085;
					}
					continue;
				}
				case 9u:
					goto IL_01a2;
				case 8u:
					goto IL_01b8;
				case 7u:
					num = (int)(num2 * 929802325) ^ -1618512453;
					continue;
				case 6u:
					num = (int)((num2 * 1980938682) ^ 0x51F23A29);
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -437664865) ^ 0x36B7BB1C;
					continue;
				case 4u:
					goto IL_0208;
				case 3u:
					num = ((int)num2 * -1818906850) ^ -1648203646;
					continue;
				case 2u:
					num = ((int)num2 * -1739878924) ^ -1325273781;
					continue;
				case 1u:
					goto IL_023d;
				case 0u:
					switch (c)
					{
					case '\r':
						break;
					case '\f':
						goto IL_0084;
					case '\b':
						goto IL_01a2;
					case '\t':
						goto IL_01b8;
					case '\v':
						goto IL_0208;
					case '\n':
						goto IL_023d;
					default:
						goto IL_0271;
					}
					goto case 29u;
				case 24u:
					break;
				default:
					{
						return result;
					}
					IL_0271:
					num = (int)(num2 * 586697996) ^ -2094895326;
					continue;
					IL_023d:
					text = JSONNode.smethod_3(text, "\\n");
					num = 989875767;
					continue;
					IL_0208:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1680917146;
					continue;
					IL_01b8:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1680917146;
					continue;
					IL_01a2:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1680917146;
					continue;
					IL_0084:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1888667667;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		int num3 = default(int);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag6 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag11 = default(bool);
		char c2 = default(char);
		string text2 = default(string);
		bool flag14 = default(bool);
		string text = default(string);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		char c = default(char);
		bool flag16 = default(bool);
		bool flag15 = default(bool);
		bool flag10 = default(bool);
		bool flag12 = default(bool);
		char c5 = default(char);
		bool flag9 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag13 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		string s = default(string);
		char c3 = default(char);
		bool flag4 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 178435073;
			while (true)
			{
				uint num2;
				int num40;
				int num46;
				switch ((num2 = (uint)num ^ 0x77A9E13Au) % 155u)
				{
				case 12u:
				case 66u:
				case 94u:
				case 104u:
				case 154u:
					num3++;
					num = 2045250009;
					continue;
				case 153u:
					stack.Pop();
					num = 456930464;
					continue;
				case 152u:
					num = 636409798;
					continue;
				case 151u:
				{
					int num57;
					int num58;
					if (!flag6)
					{
						num57 = -1004803388;
						num58 = -1004803388;
					}
					else
					{
						num57 = -1393643867;
						num58 = -1393643867;
					}
					num = num57 ^ ((int)num2 * -1669459004);
					continue;
				}
				case 150u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1512359440) ^ 0x52B905A6;
					continue;
				case 149u:
					flag11 = jSONNode is JSONArray;
					num = ((int)num2 * -1740679748) ^ -1050593414;
					continue;
				case 148u:
				{
					int num22;
					if (c2 == ' ')
					{
						num = 1945440179;
						num22 = 1945440179;
					}
					else
					{
						num = 1572007366;
						num22 = 1572007366;
					}
					continue;
				}
				case 147u:
					text2 = "";
					num = 521590640;
					continue;
				case 146u:
					num = 966092896;
					continue;
				case 145u:
				{
					int num51;
					int num52;
					if (!flag14)
					{
						num51 = 1564093027;
						num52 = 1564093027;
					}
					else
					{
						num51 = 852791628;
						num52 = 852791628;
					}
					num = num51 ^ ((int)num2 * -158857183);
					continue;
				}
				case 144u:
					text = "";
					num = (int)(num2 * 2063190371) ^ -1453440513;
					continue;
				case 143u:
					num = ((int)num2 * -563604701) ^ 0x2357AECC;
					continue;
				case 142u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1124770182) ^ -1257191273;
					continue;
				case 141u:
					stack.Push(new JSONArray());
					num = 1545582033;
					continue;
				case 140u:
					num = ((int)num2 * -976587432) ^ 0x1FF69F39;
					continue;
				case 139u:
				{
					int num34;
					if ((uint)c2 <= 93u)
					{
						num = 724452277;
						num34 = 724452277;
					}
					else
					{
						num = 1170732466;
						num34 = 1170732466;
					}
					continue;
				}
				case 138u:
				{
					int num24;
					int num25;
					if (!(jSONNode is JSONArray))
					{
						num24 = 176394204;
						num25 = 176394204;
					}
					else
					{
						num24 = 1944332427;
						num25 = 1944332427;
					}
					num = num24 ^ (int)(num2 * 711512570);
					continue;
				}
				case 137u:
					num = ((int)num2 * -437638326) ^ -1020363747;
					continue;
				case 136u:
					num = (int)(num2 * 547114033) ^ -1100888573;
					continue;
				case 135u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 694927240) ^ -1036298482;
					continue;
				case 134u:
					flag3 = flag2;
					num = 725021184;
					continue;
				case 133u:
					num = (int)(num2 * 637660259) ^ -1990802076;
					continue;
				case 132u:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 1264574578;
					continue;
				case 131u:
					num = ((int)num2 * -1544183551) ^ -565278670;
					continue;
				case 130u:
					num = (int)(num2 * 947674860) ^ -66138429;
					continue;
				case 129u:
				{
					int num55;
					int num56;
					if (flag16)
					{
						num55 = 831651458;
						num56 = 831651458;
					}
					else
					{
						num55 = 524882283;
						num56 = 524882283;
					}
					num = num55 ^ (int)(num2 * 312580250);
					continue;
				}
				case 128u:
				{
					int num49;
					int num50;
					if (!flag15)
					{
						num49 = -1968007012;
						num50 = -1968007012;
					}
					else
					{
						num49 = -1603249986;
						num50 = -1603249986;
					}
					num = num49 ^ (int)(num2 * 983151003);
					continue;
				}
				case 127u:
				{
					int num44;
					int num45;
					if (flag10)
					{
						num44 = -1065474920;
						num45 = -1065474920;
					}
					else
					{
						num44 = -304025726;
						num45 = -304025726;
					}
					num = num44 ^ ((int)num2 * -10675462);
					continue;
				}
				case 126u:
					text2 = "";
					text = "";
					num = 241948970;
					continue;
				case 125u:
					flag16 = flag2;
					num = 1984845148;
					continue;
				case 124u:
					switch (c2)
					{
					case ']':
						break;
					default:
						goto IL_0327;
					case '[':
						goto IL_0331;
					case '\\':
						goto IL_0351;
					}
					goto case 134u;
				case 107u:
					goto IL_0331;
				case 19u:
					goto IL_0351;
				case 123u:
					text = JSONNode.smethod_3(text, "\n");
					num = 1859132017;
					continue;
				case 122u:
					flag14 = stack.Count > 0;
					num = ((int)num2 * -1806858703) ^ 0x59A47A2B;
					continue;
				case 121u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 1780837520) ^ -1958284007;
					continue;
				case 120u:
				{
					int num31;
					int num32;
					if (flag12)
					{
						num31 = 878648552;
						num32 = 878648552;
					}
					else
					{
						num31 = 301655775;
						num32 = 301655775;
					}
					num = num31 ^ (int)(num2 * 1029114528);
					continue;
				}
				case 119u:
					num = (int)(num2 * 1921318098) ^ -1611055523;
					continue;
				case 118u:
					switch (c5)
					{
					case 's':
						break;
					default:
						goto IL_0409;
					case 'r':
						goto IL_0413;
					case 't':
						goto IL_0429;
					case 'u':
						goto IL_043f;
					}
					goto case 132u;
				case 57u:
					goto IL_0413;
				case 22u:
					goto IL_0429;
				case 101u:
					goto IL_043f;
				case 117u:
					flag2 = !flag2;
					num = 315096186;
					continue;
				case 116u:
					num = ((int)num2 * -1428689900) ^ 0x46015D08;
					continue;
				case 114u:
				{
					int num19;
					int num20;
					if (!flag9)
					{
						num19 = -99908668;
						num20 = -99908668;
					}
					else
					{
						num19 = -881529730;
						num20 = -881529730;
					}
					num = num19 ^ (int)(num2 * 2108664572);
					continue;
				}
				case 113u:
					num = ((int)num2 * -346933757) ^ -1084996292;
					continue;
				case 112u:
				{
					int num15;
					int num16;
					if (c2 == ':')
					{
						num15 = -614135091;
						num16 = -614135091;
					}
					else
					{
						num15 = -1700639689;
						num16 = -1700639689;
					}
					num = num15 ^ (int)(num2 * 1210728783);
					continue;
				}
				case 111u:
					num = ((int)num2 * -2105236468) ^ 0x1EFA5E05;
					continue;
				case 110u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 124091023) ^ 0x167FA4AC);
					continue;
				case 109u:
					num = (int)(num2 * 1699237660) ^ -363796347;
					continue;
				case 108u:
					flag6 = jSONNode != null;
					num = ((int)num2 * -2093742392) ^ 0x763CBB9B;
					continue;
				case 106u:
					flag5 = stack.Count == 0;
					num = 1763589227;
					continue;
				case 105u:
					text2 = "";
					num = 76776436;
					continue;
				case 103u:
					text = "";
					num = (int)((num2 * 725521956) ^ 0x363CE798);
					continue;
				case 102u:
				{
					int num7;
					if (c2 != '}')
					{
						num = 1640450253;
						num7 = 1640450253;
					}
					else
					{
						num = 1700940678;
						num7 = 1700940678;
					}
					continue;
				}
				case 100u:
				{
					int num61;
					int num62;
					if ((uint)c5 > 102u)
					{
						num61 = -1368992543;
						num62 = -1368992543;
					}
					else
					{
						num61 = -1886649043;
						num62 = -1886649043;
					}
					num = num61 ^ ((int)num2 * -1288717056);
					continue;
				}
				case 99u:
				{
					int num59;
					int num60;
					if (!(jSONNode != null))
					{
						num59 = 1122909260;
						num60 = 1122909260;
					}
					else
					{
						num59 = 862321408;
						num60 = 862321408;
					}
					num = num59 ^ ((int)num2 * -1223770307);
					continue;
				}
				case 98u:
					goto IL_0606;
				case 97u:
					num = ((int)num2 * -1116766664) ^ -1576358354;
					continue;
				case 96u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -856788166) ^ -130735667;
					continue;
				case 95u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num3 = 0;
					text = "";
					num = (int)((num2 * 1296268508) ^ 0x3DF03D5E);
					continue;
				case 93u:
				{
					int num53;
					int num54;
					if ((uint)c2 <= 44u)
					{
						num53 = -99344095;
						num54 = -99344095;
					}
					else
					{
						num53 = -743804048;
						num54 = -743804048;
					}
					num = num53 ^ ((int)num2 * -2024379294);
					continue;
				}
				case 92u:
					num = (int)((num2 * 1349290855) ^ 0x5A36B2EF);
					continue;
				case 90u:
				{
					int num47;
					int num48;
					if (c5 == 'b')
					{
						num47 = 486162727;
						num48 = 486162727;
					}
					else
					{
						num47 = 597327291;
						num48 = 597327291;
					}
					num = num47 ^ ((int)num2 * -1600466029);
					continue;
				}
				case 89u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_0606;
					default:
						goto IL_06fe;
					case '\t':
						goto IL_0711;
					}
					goto case 12u;
				case 26u:
					goto IL_0711;
				case 88u:
					flag8 = JSONNode.smethod_6(text2, "");
					num = 1070549729;
					continue;
				case 87u:
					num = 1310551099;
					continue;
				case 86u:
					num = (int)(num2 * 154432543) ^ -1002207879;
					continue;
				case 85u:
				{
					int num42;
					int num43;
					if (flag13)
					{
						num42 = 1497291778;
						num43 = 1497291778;
					}
					else
					{
						num42 = 858894649;
						num43 = 858894649;
					}
					num = num42 ^ (int)(num2 * 1298724556);
					continue;
				}
				case 84u:
				{
					int num41;
					if (c5 == 'f')
					{
						num = 56735148;
						num41 = 56735148;
					}
					else
					{
						num = 1714264892;
						num41 = 1714264892;
					}
					continue;
				}
				case 83u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1134628914) ^ -1961473989;
					continue;
				case 82u:
					num = (int)((num2 * 930485896) ^ 0x38876E70);
					continue;
				case 81u:
				{
					int num38;
					int num39;
					if (flag)
					{
						num38 = -1827426683;
						num39 = -1827426683;
					}
					else
					{
						num38 = -1869138642;
						num39 = -1869138642;
					}
					num = num38 ^ (int)(num2 * 923899370);
					continue;
				}
				case 80u:
					text = JSONNode.smethod_3(text, "\b");
					num = 1859132017;
					continue;
				case 79u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1319153765) ^ 0x2B7F4826;
					continue;
				case 78u:
				{
					int num36;
					int num37;
					if (flag3)
					{
						num36 = -147173835;
						num37 = -147173835;
					}
					else
					{
						num36 = -1199912494;
						num37 = -1199912494;
					}
					num = num36 ^ ((int)num2 * -823785890);
					continue;
				}
				case 77u:
					flag12 = jSONNode is JSONArray;
					num = ((int)num2 * -1602484147) ^ -2076859457;
					continue;
				case 76u:
				{
					int num35;
					if (c2 == '{')
					{
						num = 1535008163;
						num35 = 1535008163;
					}
					else
					{
						num = 1089711981;
						num35 = 1089711981;
					}
					continue;
				}
				case 74u:
					num = ((int)num2 * -1501661344) ^ -2131724492;
					continue;
				case 73u:
					num = ((int)num2 * -580771542) ^ 0x59F2A202;
					continue;
				case 72u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1945601319) ^ -846753007;
					continue;
				case 71u:
					flag7 = flag2;
					num = (int)(num2 * 1096230291) ^ -42593937;
					continue;
				case 70u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = 1856117232;
					continue;
				case 69u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -776595222) ^ -1720000994;
					continue;
				case 68u:
				{
					int num33;
					if (!flag2)
					{
						num = 1120069171;
						num33 = 1120069171;
					}
					else
					{
						num = 161777165;
						num33 = 161777165;
					}
					continue;
				}
				case 67u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 713574360) ^ -716488416;
					continue;
				case 65u:
					num = ((int)num2 * -480561358) ^ -1994628642;
					continue;
				case 64u:
					num = (int)((num2 * 1457076764) ^ 0x1A5E9458);
					continue;
				case 63u:
					num = (int)(num2 * 412448524) ^ -2107194532;
					continue;
				case 62u:
					flag9 = jSONNode is JSONArray;
					num = (int)((num2 * 527399074) ^ 0x2DDE6022);
					continue;
				case 61u:
					flag13 = JSONNode.smethod_6(text2, "");
					num = 310185815;
					continue;
				case 60u:
				{
					int num29;
					int num30;
					if (flag5)
					{
						num29 = -1198966008;
						num30 = -1198966008;
					}
					else
					{
						num29 = -1836683523;
						num30 = -1836683523;
					}
					num = num29 ^ (int)(num2 * 741057886);
					continue;
				}
				case 59u:
					jSONNode.Add(text);
					num = (int)((num2 * 419733445) ^ 0x5333E3AC);
					continue;
				case 58u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 316162373) ^ -646929359;
					continue;
				case 56u:
				{
					int num27;
					int num28;
					if (!flag11)
					{
						num27 = 1451985993;
						num28 = 1451985993;
					}
					else
					{
						num27 = 1050242087;
						num28 = 1050242087;
					}
					num = num27 ^ ((int)num2 * -1788185081);
					continue;
				}
				case 55u:
				{
					int num26;
					if (c5 == 'n')
					{
						num = 52882144;
						num26 = 52882144;
					}
					else
					{
						num = 945171505;
						num26 = 945171505;
					}
					continue;
				}
				case 54u:
					stack.Push(new JSONClass());
					num = 1793780029;
					continue;
				case 53u:
					jSONNode.Add(text);
					num = (int)((num2 * 1318988196) ^ 0x625A1BE7);
					continue;
				case 52u:
					num = 1464446131;
					continue;
				case 51u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 1044681616) ^ -2001974606;
					continue;
				case 50u:
					c2 = c3;
					num = (int)((num2 * 801617774) ^ 0xAF388B9);
					continue;
				case 49u:
				{
					int num23;
					if (flag2)
					{
						num = 147902215;
						num23 = 147902215;
					}
					else
					{
						num = 1244352596;
						num23 = 1244352596;
					}
					continue;
				}
				case 48u:
					text2 = "";
					num = (int)(num2 * 743676982) ^ -576080904;
					continue;
				case 47u:
					num = (int)(num2 * 947384326) ^ -880780531;
					continue;
				case 46u:
					num = (int)(num2 * 753118579) ^ -896118759;
					continue;
				case 45u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 427947781) ^ -871192210;
					continue;
				case 44u:
					num = ((int)num2 * -161114037) ^ -252888471;
					continue;
				case 43u:
					num = (int)(num2 * 968511676) ^ -843293440;
					continue;
				case 41u:
					flag10 = JSONNode.smethod_6(text2, "");
					num = 1915843679;
					continue;
				case 40u:
					text = JSONNode.smethod_3(text, "\f");
					num = 1764453276;
					continue;
				case 39u:
				{
					int num21;
					if (c2 != '"')
					{
						num = 1728236321;
						num21 = 1728236321;
					}
					else
					{
						num = 885029246;
						num21 = 885029246;
					}
					continue;
				}
				case 38u:
					num = 2082556892;
					continue;
				case 37u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -343638273) ^ 0x12BA61FF;
					continue;
				case 36u:
				{
					c = JSONNode.smethod_2(aJSON, num3);
					char c4 = c;
					c5 = c4;
					num = (int)(num2 * 1025983192) ^ -14695490;
					continue;
				}
				case 35u:
					num = ((int)num2 * -2141899553) ^ 0x3A19C465;
					continue;
				case 34u:
					num = (int)((num2 * 2109385172) ^ 0x13434E74);
					continue;
				case 33u:
					flag2 = false;
					num = ((int)num2 * -1450939148) ^ 0x7320C2AD;
					continue;
				case 32u:
					text = "";
					num = ((int)num2 * -772190307) ^ -610090515;
					continue;
				case 31u:
					num = (int)((num2 * 46043617) ^ 0x137DEF44);
					continue;
				case 30u:
				{
					int num17;
					int num18;
					if (flag4)
					{
						num17 = 1220826676;
						num18 = 1220826676;
					}
					else
					{
						num17 = 2084392717;
						num18 = 2084392717;
					}
					num = num17 ^ ((int)num2 * -906502687);
					continue;
				}
				case 29u:
				{
					int num13;
					int num14;
					if (!flag8)
					{
						num13 = -1144302764;
						num14 = -1144302764;
					}
					else
					{
						num13 = -1579034651;
						num14 = -1579034651;
					}
					num = num13 ^ ((int)num2 * -8510986);
					continue;
				}
				case 28u:
					num = (int)(num2 * 308398631) ^ -1339342923;
					continue;
				case 27u:
				{
					int num11;
					int num12;
					if (!flag7)
					{
						num11 = -408945996;
						num12 = -408945996;
					}
					else
					{
						num11 = -1163395947;
						num12 = -1163395947;
					}
					num = num11 ^ ((int)num2 * -152613529);
					continue;
				}
				case 25u:
					num3 += 4;
					num = ((int)num2 * -615276889) ^ 0x7A02369C;
					continue;
				case 24u:
					num = ((int)num2 * -836905690) ^ 0x124C8E70;
					continue;
				case 23u:
				{
					int num9;
					int num10;
					if ((uint)c2 <= 32u)
					{
						num9 = 1995275548;
						num10 = 1995275548;
					}
					else
					{
						num9 = 218675132;
						num10 = 218675132;
					}
					num = num9 ^ ((int)num2 * -1680389480);
					continue;
				}
				case 21u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1620516183) ^ -444466072;
					continue;
				case 20u:
					num = (int)(num2 * 975053483) ^ -1165041828;
					continue;
				case 18u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = 752098070;
					continue;
				case 17u:
					num = ((int)num2 * -1876793136) ^ 0x226C13B0;
					continue;
				case 16u:
					num = (int)(num2 * 1238733727) ^ -1341532258;
					continue;
				case 15u:
					num = ((int)num2 * -1617919049) ^ 0x659ABAA8;
					continue;
				case 14u:
					c3 = JSONNode.smethod_2(aJSON, num3);
					num = ((int)num2 * -1896772514) ^ 0x65456F59;
					continue;
				case 13u:
					num = (int)(num2 * 1434677228) ^ -894691623;
					continue;
				case 11u:
					text2 = text;
					num = 1852714335;
					continue;
				case 10u:
				{
					int num8;
					if (c2 == ',')
					{
						num = 1218386744;
						num8 = 1218386744;
					}
					else
					{
						num = 604585337;
						num8 = 604585337;
					}
					continue;
				}
				case 9u:
				{
					int num5;
					int num6;
					if (JSONNode.smethod_6(text, ""))
					{
						num5 = -27376498;
						num6 = -27376498;
					}
					else
					{
						num5 = -1405370876;
						num6 = -1405370876;
					}
					num = num5 ^ (int)(num2 * 1947572079);
					continue;
				}
				case 8u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1296289638) ^ -819917260;
					continue;
				case 7u:
					num = (int)(num2 * 197579527) ^ -398000944;
					continue;
				case 6u:
					result = jSONNode;
					num = 305263741;
					continue;
				case 5u:
					num = ((int)num2 * -1457827808) ^ 0x2253B050;
					continue;
				case 4u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 2118897345) ^ -1310350100;
					continue;
				case 3u:
					flag = JSONNode.smethod_6(text, "");
					num = 367589071;
					continue;
				case 2u:
					num = 1873595842;
					continue;
				case 1u:
					num = ((int)num2 * -395560491) ^ -1801113941;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(aJSON))
					{
						num = 45029249;
						num4 = 45029249;
					}
					else
					{
						num = 1441725748;
						num4 = 1441725748;
					}
					continue;
				}
				case 75u:
					break;
				case 42u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 115u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0429:
					text = JSONNode.smethod_3(text, "\t");
					num = 1859132017;
					continue;
					IL_0413:
					text = JSONNode.smethod_3(text, "\r");
					num = 1587070564;
					continue;
					IL_043f:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = 2020787476;
					continue;
					IL_0409:
					num = 893823117;
					continue;
					IL_0331:
					if (flag2)
					{
						num = 1953210311;
						num40 = 1953210311;
					}
					else
					{
						num = 676019519;
						num40 = 676019519;
					}
					continue;
					IL_0351:
					num3++;
					flag15 = flag2;
					num = 895461780;
					continue;
					IL_0327:
					num = 55035625;
					continue;
					IL_0711:
					if (!flag2)
					{
						num = 684011699;
						num46 = 684011699;
					}
					else
					{
						num = 594942388;
						num46 = 594942388;
					}
					continue;
					IL_06fe:
					num = ((int)num2 * -37854750) ^ 0x7A8A8468;
					continue;
					IL_0606:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = 1835793098;
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
		while (true)
		{
			int num = -1203996201;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7FE5CBEu) % 4u)
				{
				case 1u:
				{
					BinaryWriter aWriter = JSONNode.smethod_9(aData);
					Serialize(aWriter);
					num = ((int)num2 * -38524695) ^ 0x5C546CD7;
					continue;
				}
				case 0u:
					num = ((int)num2 * -819735003) ^ -689042940;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
				int num = -1064487665;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5CBC2EDu) % 3u)
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
					num = (int)(num2 * 1882892511) ^ -2115541551;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00a1:
					int num3 = -569192105;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE5CBC2EDu) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1478806467) ^ 0x19A85AA2;
							continue;
						case 1u:
							num3 = ((int)num2 * -1053632090) ^ -847760521;
							continue;
						default:
							goto end_IL_0080;
						case 3u:
							break;
						case 0u:
							goto end_IL_0080;
						}
						goto IL_00a1;
						continue;
						end_IL_0080:
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
			SaveToStream(memoryStream);
			while (true)
			{
				int num = 1683962949;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52EF2879u) % 3u)
					{
					case 1u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
					}
					break;
					IL_000f:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -564632337) ^ -98423487;
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_00a5:
					int num3 = 830712124;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x52EF2879u) % 4u)
						{
						case 2u:
							num3 = (int)(num2 * 866119924) ^ -1020397455;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)(num2 * 67289303) ^ -536409448;
							continue;
						default:
							goto end_IL_0084;
						case 3u:
							break;
						case 0u:
							goto end_IL_0084;
						}
						goto IL_00a5;
						continue;
						end_IL_0084:
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
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num6 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num4 = default(int);
		JSONArray jSONArray = default(JSONArray);
		bool flag = default(bool);
		int num5 = default(int);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		while (true)
		{
			int num = -1004007606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5CBE117u) % 40u)
				{
				case 39u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 1246674085) ^ 0x21A68F97);
					continue;
				case 38u:
					num = (int)(num2 * 1274769728) ^ -445835688;
					continue;
				case 37u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)((num2 * 660194362) ^ 0x4C4A1032);
					continue;
				case 35u:
					num = (int)((num2 * 2041509864) ^ 0x25561520);
					continue;
				case 34u:
					flag2 = num3 < num6;
					num = -450858098;
					continue;
				case 33u:
					result = jSONClass;
					num = (int)((num2 * 1465444079) ^ 0x74284BFB);
					continue;
				case 32u:
					num = -1348032386;
					continue;
				case 31u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Array:
						break;
					default:
						goto IL_00c1;
					case JSONBinaryTag.Class:
						goto IL_00d4;
					case JSONBinaryTag.Value:
						goto IL_00de;
					case JSONBinaryTag.IntValue:
						goto IL_00f5;
					case JSONBinaryTag.DoubleValue:
						goto IL_00ff;
					case JSONBinaryTag.BoolValue:
						goto IL_0116;
					case JSONBinaryTag.FloatValue:
						goto IL_012d;
					}
					goto case 32u;
				case 22u:
					goto IL_00d4;
				case 1u:
					goto IL_00de;
				case 29u:
					goto IL_00f5;
				case 9u:
					goto IL_00ff;
				case 13u:
					goto IL_0116;
				case 26u:
					goto IL_012d;
				case 28u:
					num = -810652295;
					continue;
				case 27u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1351566304) ^ -477019777;
					continue;
				case 25u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 542053744;
						num10 = 542053744;
					}
					else
					{
						num9 = 1909061805;
						num10 = 1909061805;
					}
					num = num9 ^ (int)(num2 * 1858494435);
					continue;
				}
				case 24u:
					num4++;
					num = (int)((num2 * 1238647394) ^ 0x4B38BC0A);
					continue;
				case 23u:
					num = ((int)num2 * -944176136) ^ -565046640;
					continue;
				case 21u:
					num = (int)(num2 * 1404415703) ^ -850252469;
					continue;
				case 20u:
					jSONArray.Add(Deserialize(aReader));
					num = -274522837;
					continue;
				case 19u:
					jSONArray = new JSONArray();
					num4 = 0;
					num = (int)(num2 * 1760214865) ^ -482200760;
					continue;
				case 18u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1666234248;
						num8 = 1666234248;
					}
					else
					{
						num7 = 736227191;
						num8 = 736227191;
					}
					num = num7 ^ (int)(num2 * 799421662);
					continue;
				}
				case 17u:
					num5 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 1443780132) ^ 0x57331418);
					continue;
				case 16u:
					num = -646729191;
					continue;
				case 14u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1429881473) ^ -1521257213;
					continue;
				case 12u:
					num = ((int)num2 * -1676498912) ^ -1459032657;
					continue;
				case 11u:
					result = jSONArray;
					num = ((int)num2 * -464696566) ^ -913025210;
					continue;
				case 10u:
					num = ((int)num2 * -1426831396) ^ 0x5F60C42F;
					continue;
				case 8u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -247039537) ^ -502456884;
					continue;
				case 7u:
					num3++;
					num = (int)((num2 * 1496611833) ^ 0x3E18B572);
					continue;
				case 6u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 418306972) ^ 0x512C62A2);
					continue;
				case 5u:
					flag = num4 < num5;
					num = -992838875;
					continue;
				case 4u:
					num = ((int)num2 * -1818813148) ^ 0x406A256A;
					continue;
				case 3u:
					num = ((int)num2 * -1890632571) ^ 0x7E73CDA7;
					continue;
				case 2u:
					num = (int)((num2 * 472478540) ^ 0x7FA87180);
					continue;
				case 0u:
					num3 = 0;
					num = (int)(num2 * 1313903669) ^ -840981227;
					continue;
				case 36u:
					break;
				case 30u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_012d:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1604122463;
					continue;
					IL_0116:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1783048744;
					continue;
					IL_00ff:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -149779003;
					continue;
					IL_00f5:
					num = -1172230216;
					continue;
					IL_00de:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1784401024;
					continue;
					IL_00d4:
					num = -253825089;
					continue;
					IL_00c1:
					num = ((int)num2 * -241175644) ^ 0x7D3EB591;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1348238926;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B2C6242u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
					IL_000a:
					result = Deserialize(binaryReader);
					num = ((int)num2 * -1958286344) ^ 0x305A5A3F;
				}
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				while (true)
				{
					IL_008c:
					int num3 = -1387454773;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x9B2C6242u) % 4u)
						{
						case 2u:
							num3 = ((int)num2 * -841125803) ^ 0x6372A55F;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)(num2 * 706216252) ^ -1847510824;
							continue;
						default:
							goto end_IL_006b;
						case 0u:
							break;
						case 3u:
							goto end_IL_006b;
						}
						goto IL_008c;
						continue;
						end_IL_006b:
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
					int num = -937937499;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x82D24AF8u) % 4u)
						{
						case 3u:
							num = ((int)num2 * -1625558383) ^ -693239529;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -557001521) ^ -1383879900;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
							break;
						case 0u:
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
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 68350619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1125CBFFu) % 5u)
				{
				case 3u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1126004136) ^ 0x7B1CA13;
					continue;
				}
				case 1u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1309319647) ^ -47244730;
					continue;
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -54392108) ^ -615859892;
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

	public JSONNode()
	{
		while (true)
		{
			int num = -425012813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6F7CE07u) % 3u)
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
				num = ((int)num2 * -1264999684) ^ 0x10AF60FE;
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
