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
				int num = -1292835611;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x91654725u) % 3u)
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
					num = (int)(num2 * 332925139) ^ -916861928;
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
				int num = -1689955125;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF919DA4u) % 4u)
					{
					case 3u:
						result = null;
						num = ((int)num2 * -1054855014) ^ -1794345137;
						continue;
					case 1u:
						num = (int)(num2 * 1809798461) ^ -2145399705;
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
				int num = 739055850;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6490E1EEu) % 3u)
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
					result = 0;
					num = ((int)num2 * -921228268) ^ 0x12FAD215;
				}
			}
		}
	}

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 577644978;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7621C6C3u) % 3u)
					{
					case 2u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -614979663) ^ 0x5B0A96;
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
				int num = 1931818804;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D5E965u) % 4u)
					{
					case 2u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)(num2 * 686078801) ^ -547273389;
						continue;
					case 1u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 990911537) ^ -236560622;
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

	public virtual int AsInt
	{
		get
		{
			int result = 0;
			bool flag = int.TryParse(Value, out result);
			int result2 = default(int);
			while (true)
			{
				int num = 138724501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B1A8BFu) % 6u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1399766067;
							num4 = 1399766067;
						}
						else
						{
							num3 = 1129027026;
							num4 = 1129027026;
						}
						num = num3 ^ ((int)num2 * -1546119456);
						continue;
					}
					case 3u:
						num = ((int)num2 * -61082927) ^ -525974249;
						continue;
					case 1u:
						result2 = 0;
						num = 883238534;
						continue;
					case 0u:
						result2 = result;
						num = (int)((num2 * 1726908783) ^ 0x44AC848A);
						continue;
					case 2u:
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
				int num = -2143834617;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xABD37E68u) % 4u)
					{
					case 3u:
						Value = value.ToString();
						num = ((int)num2 * -1490524909) ^ 0x27597305;
						continue;
					case 0u:
						num = (int)((num2 * 1540477717) ^ 0x88A196D);
						continue;
					default:
						return;
					case 2u:
						break;
					case 1u:
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
				int num = 1579917883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77403DECu) % 6u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
						{
							num3 = -1646714086;
							num4 = -1646714086;
						}
						else
						{
							num3 = -1783755655;
							num4 = -1783755655;
						}
						num = num3 ^ ((int)num2 * -291867816);
						continue;
					}
					case 2u:
						num = ((int)num2 * -629998224) ^ 0xADFA74C;
						continue;
					case 1u:
						result2 = 0f;
						num = 50752322;
						continue;
					case 0u:
						result2 = result;
						num = (int)((num2 * 365720381) ^ 0x2DC4FC4A);
						continue;
					case 5u:
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
				int num = -694870002;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB690DAD7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -716970568) ^ 0x4B128CBB;
						continue;
					case 1u:
						Value = value.ToString();
						num = ((int)num2 * -342593559) ^ -1809547691;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			bool flag = default(bool);
			double result = default(double);
			while (true)
			{
				int num = 110404618;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5ABF5E5Du) % 7u)
					{
					case 5u:
						result2 = 0.0;
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -1292662956) ^ -1769588448;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1512925584;
							num4 = 1512925584;
						}
						else
						{
							num3 = 1175344478;
							num4 = 1175344478;
						}
						num = num3 ^ ((int)num2 * -1868018626);
						continue;
					}
					case 3u:
						result = 0.0;
						num = 957720682;
						continue;
					case 2u:
						result = result2;
						num = (int)((num2 * 357752936) ^ 0x4CF961F4);
						continue;
					case 1u:
						num = (int)((num2 * 942442501) ^ 0x62E24B2F);
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
			Value = value.ToString();
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			if (bool.TryParse(Value, out result))
			{
				goto IL_0033;
			}
			goto IL_005d;
			IL_005d:
			bool result2 = !JSONNode.smethod_1(Value);
			int num = 1010043005;
			goto IL_0038;
			IL_0038:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3F3D33u) % 5u)
				{
				case 3u:
					result2 = result;
					num = (int)((num2 * 772929872) ^ 0x1617EF07);
					continue;
				case 1u:
					num = (int)((num2 * 578991945) ^ 0x31FF6149);
					continue;
				case 0u:
					break;
				case 4u:
					goto IL_005d;
				default:
					return result2;
				}
				break;
			}
			goto IL_0033;
			IL_0033:
			num = 1869595265;
			goto IL_0038;
		}
		set
		{
			Value = (value ? "true" : "false");
		}
	}

	public virtual JSONArray AsArray => this as JSONArray;

	public virtual JSONClass AsObject => this as JSONClass;

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		Add("", aItem);
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
			int num = -1786575674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E9FB3D9u) % 3u)
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
				num = (int)((num2 * 1421460716) ^ 0x25A21C6E);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -1171770827;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7500C77u) % 3u)
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
				num = ((int)num2 * -1051319800) ^ 0x3C511CFC;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1458256286;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC99B2744u) % 3u)
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
				result = "JSONNode";
				num = (int)((num2 * 2140947256) ^ 0x6C44D4E1);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 2114519923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70DC5A9Eu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1175494682) ^ 0x3E1F6506;
					continue;
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -1171555405) ^ 0x1D37F12B;
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -581217731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBC923C7u) % 4u)
				{
				case 2u:
					result = new JSONData(s);
					num = (int)((num2 * 502602434) ^ 0x361DA936);
					continue;
				case 1u:
					num = (int)((num2 * 1747579060) ^ 0x13F6FE1B);
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

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 521826197;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x20683B66u) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = ((int)num2 * -418439187) ^ -1804694235;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					obj = d.Value;
					goto IL_001c;
				case 0u:
					num = ((int)num2 * -1494044202) ^ 0x2F91B170;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = 1155722609;
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
			goto IL_0059;
		}
		int num = 0;
		goto IL_0094;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
		IL_0059:
		int num2 = -320769941;
		goto IL_005e;
		IL_005e:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xAED1ED6Fu) % 7u)
			{
			case 6u:
				result = true;
				num2 = (int)(num3 * 1584138353) ^ -1396267174;
				continue;
			case 5u:
				num2 = (int)((num3 * 487301136) ^ 0x182FD641);
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 633274028;
					num5 = 633274028;
				}
				else
				{
					num4 = 1180165881;
					num5 = 1180165881;
				}
				num2 = num4 ^ (int)(num3 * 1677821392);
				continue;
			}
			case 2u:
				result = (object)a == b;
				num2 = -1032400863;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_0059;
		IL_0094:
		flag = (byte)num != 0;
		num2 = -1658958797;
		goto IL_005e;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		return (object)this == obj;
	}

	public override int GetHashCode()
	{
		return this.method_0();
	}

	internal static string Escape(string aText)
	{
		string text = "";
		char c = default(char);
		string string_ = default(string);
		int num3 = default(int);
		char c3 = default(char);
		char c2 = default(char);
		string result = default(string);
		while (true)
		{
			int num = -579114470;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB901CAF9u) % 28u)
				{
				case 27u:
					c = JSONNode.smethod_2(string_, num3);
					num = -762700149;
					continue;
				case 26u:
					num = (int)(num2 * 1815570950) ^ -1100403918;
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, "\\r");
					num = -2098962610;
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -2098962610;
					continue;
				case 23u:
					num3 = 0;
					num = ((int)num2 * -615619267) ^ -2118731089;
					continue;
				case 22u:
					goto IL_0071;
				case 21u:
				{
					int num6;
					if (c3 != '\\')
					{
						num = -2039761719;
						num6 = -2039761719;
					}
					else
					{
						num = -1634749463;
						num6 = -1634749463;
					}
					continue;
				}
				case 20u:
					num = (int)(num2 * 1225139240) ^ -1845180562;
					continue;
				case 19u:
					switch (c3)
					{
					case '\r':
						break;
					case '\b':
						goto IL_0071;
					default:
						goto IL_00dd;
					case '\t':
						goto IL_00f0;
					case '\n':
						goto IL_0106;
					case '\v':
						goto IL_011c;
					case '\f':
						goto IL_0134;
					}
					goto case 25u;
				case 11u:
					goto IL_00f0;
				case 6u:
					goto IL_0106;
				case 1u:
					goto IL_011c;
				case 3u:
					goto IL_0134;
				case 18u:
					num = (int)((num2 * 1687195172) ^ 0x3C0B2F9B);
					continue;
				case 17u:
					num = (int)(num2 * 1180031257) ^ -1382218001;
					continue;
				case 16u:
					c3 = c2;
					num = ((int)num2 * -1637625832) ^ 0x48471086;
					continue;
				case 15u:
					num = -558545029;
					continue;
				case 14u:
				{
					int num5;
					if (c3 == '"')
					{
						num = -1916627379;
						num5 = -1916627379;
					}
					else
					{
						num = -1897383064;
						num5 = -1897383064;
					}
					continue;
				}
				case 13u:
					num = (int)((num2 * 2076616661) ^ 0xA4A14C1);
					continue;
				case 10u:
					c2 = c;
					num = ((int)num2 * -1480620913) ^ -1650706409;
					continue;
				case 9u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -2052143332;
						num4 = -2052143332;
					}
					else
					{
						num = -125090170;
						num4 = -125090170;
					}
					continue;
				}
				case 8u:
					num = (int)((num2 * 1088127722) ^ 0x5B7F36F4);
					continue;
				case 7u:
					string_ = aText;
					num = (int)(num2 * 1858892762) ^ -1234223320;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -287441418) ^ -135024045;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1676557619;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1924966202) ^ 0x4A51EBC0;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0071:
					text = JSONNode.smethod_3(text, "\\b");
					num = -2098962610;
					continue;
					IL_0134:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1648531664;
					continue;
					IL_011c:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -776001645;
					continue;
					IL_0106:
					text = JSONNode.smethod_3(text, "\\n");
					num = -2098962610;
					continue;
					IL_00f0:
					text = JSONNode.smethod_3(text, "\\t");
					num = -2098962610;
					continue;
					IL_00dd:
					num = ((int)num2 * -502544157) ^ 0x2E60D932;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		JSONNode jSONNode = null;
		int num = 0;
		bool flag17 = default(bool);
		string text = default(string);
		bool flag15 = default(bool);
		string text2 = default(string);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag12 = default(bool);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		char c = default(char);
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		bool flag10 = default(bool);
		char c2 = default(char);
		bool flag2 = default(bool);
		bool flag16 = default(bool);
		string s = default(string);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		bool flag14 = default(bool);
		char c3 = default(char);
		bool flag = default(bool);
		bool flag5 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num2 = 257575166;
			while (true)
			{
				uint num3;
				int num42;
				int num55;
				int num59;
				switch ((num3 = (uint)num2 ^ 0x60D61B27u) % 148u)
				{
				case 147u:
					num++;
					num2 = 2075043795;
					continue;
				case 15u:
				case 24u:
				case 64u:
				case 67u:
				case 146u:
					num++;
					num2 = 378026062;
					continue;
				case 145u:
					num2 = (int)((num3 * 1192348518) ^ 0x59C84B7B);
					continue;
				case 144u:
					stack.Push(new JSONClass());
					flag17 = jSONNode != null;
					num2 = 1945922564;
					continue;
				case 143u:
					num2 = ((int)num3 * -552936830) ^ -1506608786;
					continue;
				case 142u:
					jSONNode.Add(text);
					num2 = (int)(num3 * 1697020012) ^ -7019165;
					continue;
				case 141u:
					num2 = ((int)num3 * -296333849) ^ 0x6036111C;
					continue;
				case 140u:
					num2 = (int)((num3 * 1220272152) ^ 0x2F36BC70);
					continue;
				case 139u:
					flag15 = JSONNode.smethod_6(text2, "");
					num2 = 731035734;
					continue;
				case 138u:
					jSONNode.Add(stack.Peek());
					num2 = ((int)num3 * -258832767) ^ -659559564;
					continue;
				case 137u:
				{
					int num21;
					int num22;
					if (!flag3)
					{
						num21 = 587227366;
						num22 = 587227366;
					}
					else
					{
						num21 = 1438123901;
						num22 = 1438123901;
					}
					num2 = num21 ^ (int)(num3 * 780360619);
					continue;
				}
				case 136u:
				{
					int num57;
					if (flag4)
					{
						num2 = 2138129970;
						num57 = 2138129970;
					}
					else
					{
						num2 = 75480345;
						num57 = 75480345;
					}
					continue;
				}
				case 135u:
				{
					int num47;
					int num48;
					if (flag17)
					{
						num47 = -797404017;
						num48 = -797404017;
					}
					else
					{
						num47 = -383393209;
						num48 = -383393209;
					}
					num2 = num47 ^ ((int)num3 * -840879835);
					continue;
				}
				case 134u:
					flag4 = false;
					num2 = (int)(num3 * 767240867) ^ -863476187;
					continue;
				case 133u:
					num2 = (int)((num3 * 217910279) ^ 0x644689D4);
					continue;
				case 132u:
				{
					int num31;
					int num32;
					if (flag12)
					{
						num31 = 411409971;
						num32 = 411409971;
					}
					else
					{
						num31 = 1150296910;
						num32 = 1150296910;
					}
					num2 = num31 ^ (int)(num3 * 1072514291);
					continue;
				}
				case 131u:
					jSONNode.Add(text2, text);
					num2 = ((int)num3 * -2117812456) ^ 0x79D7CE21;
					continue;
				case 130u:
					text = JSONNode.smethod_3(text, "\b");
					num2 = 90459275;
					continue;
				case 129u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)(num3 * 2045087810) ^ -1825709891;
					continue;
				case 128u:
				{
					int num13;
					int num14;
					if (!flag7)
					{
						num13 = -588211860;
						num14 = -588211860;
					}
					else
					{
						num13 = -174240315;
						num14 = -174240315;
					}
					num2 = num13 ^ ((int)num3 * -975041341);
					continue;
				}
				case 127u:
					text = JSONNode.smethod_3(text, "\n");
					num2 = 793420534;
					continue;
				case 126u:
					flag3 = stack.Count == 0;
					num2 = 696550126;
					continue;
				case 125u:
					num2 = ((int)num3 * -1218691086) ^ -1912835269;
					continue;
				case 124u:
					num2 = (int)(num3 * 174991140) ^ -690332005;
					continue;
				case 123u:
					num2 = ((int)num3 * -193314720) ^ 0x3F17E418;
					continue;
				case 122u:
					goto IL_029d;
				case 121u:
					text2 = JSONNode.smethod_5(text2);
					flag8 = jSONNode is JSONArray;
					num2 = (int)((num3 * 1050321818) ^ 0x1F2BD2BF);
					continue;
				case 120u:
					switch (c)
					{
					case '\\':
						break;
					case ']':
						goto IL_029d;
					default:
						goto IL_02fa;
					case '[':
						goto IL_0304;
					}
					goto case 147u;
				case 78u:
					goto IL_0304;
				case 119u:
					flag9 = jSONNode is JSONArray;
					num2 = (int)(num3 * 1652081724) ^ -1658641143;
					continue;
				case 118u:
					text = "";
					num2 = (int)(num3 * 1530739619) ^ -1895754121;
					continue;
				case 117u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num);
					c = c5;
					int num51;
					if ((uint)c > 44u)
					{
						num2 = 747218089;
						num51 = 747218089;
					}
					else
					{
						num2 = 1117968152;
						num51 = 1117968152;
					}
					continue;
				}
				case 116u:
				{
					int num45;
					if (c == ',')
					{
						num2 = 986633869;
						num45 = 986633869;
					}
					else
					{
						num2 = 1385417052;
						num45 = 1385417052;
					}
					continue;
				}
				case 115u:
					flag11 = JSONNode.smethod_6(text2, "");
					num2 = 1296311822;
					continue;
				case 114u:
					stack.Pop();
					flag10 = JSONNode.smethod_6(text, "");
					num2 = 1772528358;
					continue;
				case 113u:
					goto IL_03e2;
				case 112u:
					num2 = (int)((num3 * 993077896) ^ 0x62EA964);
					continue;
				case 111u:
					num2 = (int)(num3 * 2107674074) ^ -686512595;
					continue;
				case 110u:
					num2 = (int)((num3 * 1948408557) ^ 0x76C680C4);
					continue;
				case 109u:
					num2 = (int)(num3 * 1078933947) ^ -1589770208;
					continue;
				case 108u:
					switch (c2)
					{
					case 'r':
						goto IL_0472;
					case 's':
						goto IL_0488;
					case 't':
						goto IL_04a0;
					case 'u':
						goto IL_04b6;
					}
					num2 = 1942525289;
					continue;
				case 72u:
					goto IL_0472;
				case 36u:
					goto IL_0488;
				case 100u:
					goto IL_04a0;
				case 17u:
					goto IL_04b6;
				case 107u:
					jSONNode.Add(text2, stack.Peek());
					num2 = (int)(num3 * 1116362354) ^ -489460344;
					continue;
				case 106u:
				{
					int num29;
					if (c2 == 'n')
					{
						num2 = 633133372;
						num29 = 633133372;
					}
					else
					{
						num2 = 1044761604;
						num29 = 1044761604;
					}
					continue;
				}
				case 105u:
				{
					int num25;
					int num26;
					if (flag11)
					{
						num25 = -578346145;
						num26 = -578346145;
					}
					else
					{
						num25 = -1472681691;
						num26 = -1472681691;
					}
					num2 = num25 ^ (int)(num3 * 1902762715);
					continue;
				}
				case 104u:
					flag2 = flag4;
					num2 = 1004645962;
					continue;
				case 103u:
					num2 = ((int)num3 * -1075416463) ^ 0x46AFC948;
					continue;
				case 102u:
				{
					int num17;
					int num18;
					if (flag9)
					{
						num17 = -1876026087;
						num18 = -1876026087;
					}
					else
					{
						num17 = -1160461712;
						num18 = -1160461712;
					}
					num2 = num17 ^ (int)(num3 * 441496790);
					continue;
				}
				case 101u:
					num2 = (int)(num3 * 311764957) ^ -274882995;
					continue;
				case 99u:
					num2 = (int)(num3 * 1187947025) ^ -1258799676;
					continue;
				case 97u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = ((int)num3 * -1728520454) ^ 0x75856165;
					continue;
				case 96u:
				{
					int num10;
					if (c != '{')
					{
						num2 = 2006550352;
						num10 = 2006550352;
					}
					else
					{
						num2 = 2122987447;
						num10 = 2122987447;
					}
					continue;
				}
				case 95u:
				{
					int num6;
					int num7;
					if ((uint)c > 32u)
					{
						num6 = -51430428;
						num7 = -51430428;
					}
					else
					{
						num6 = -1039833895;
						num7 = -1039833895;
					}
					num2 = num6 ^ (int)(num3 * 1008242562);
					continue;
				}
				case 94u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = ((int)num3 * -66751850) ^ 0x521B5280;
					continue;
				case 93u:
					num2 = ((int)num3 * -1874098807) ^ -2015646534;
					continue;
				case 92u:
					num2 = 300693000;
					continue;
				case 90u:
					text2 = JSONNode.smethod_5(text2);
					num2 = (int)((num3 * 1371541411) ^ 0x2BD9626A);
					continue;
				case 89u:
					jSONNode = stack.Peek();
					num2 = (int)((num3 * 557473178) ^ 0x191C236E);
					continue;
				case 88u:
					num2 = ((int)num3 * -28845548) ^ 0x2EE3B6C4;
					continue;
				case 87u:
					flag7 = jSONNode is JSONArray;
					num2 = ((int)num3 * -305540145) ^ -1241457086;
					continue;
				case 86u:
					num += 4;
					num2 = (int)(num3 * 1490896741) ^ -749002553;
					continue;
				case 85u:
					num2 = (int)((num3 * 1408138402) ^ 0x2676BD8);
					continue;
				case 84u:
					num2 = (int)(num3 * 1120878855) ^ -1301300057;
					continue;
				case 83u:
				{
					int num60;
					int num61;
					if (flag16)
					{
						num60 = -502000101;
						num61 = -502000101;
					}
					else
					{
						num60 = -1508745611;
						num61 = -1508745611;
					}
					num2 = num60 ^ (int)(num3 * 340487746);
					continue;
				}
				case 82u:
				{
					int num58;
					if (c2 != 'f')
					{
						num2 = 662662340;
						num58 = 662662340;
					}
					else
					{
						num2 = 700496782;
						num58 = 700496782;
					}
					continue;
				}
				case 81u:
					text = "";
					text2 = "";
					num2 = ((int)num3 * -1786685483) ^ 0x3D16218;
					continue;
				case 80u:
				{
					int num56;
					if (c != '}')
					{
						num2 = 704516734;
						num56 = 704516734;
					}
					else
					{
						num2 = 945126661;
						num56 = 945126661;
					}
					continue;
				}
				case 79u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num2 = (int)(num3 * 1637199604) ^ -1639997467;
					continue;
				case 77u:
					num2 = 895615002;
					continue;
				case 76u:
				{
					int num53;
					int num54;
					if (c == ':')
					{
						num53 = 589852783;
						num54 = 589852783;
					}
					else
					{
						num53 = 2031853842;
						num54 = 2031853842;
					}
					num2 = num53 ^ (int)(num3 * 1052009807);
					continue;
				}
				case 75u:
					num2 = (int)(num3 * 694157927) ^ -921027419;
					continue;
				case 74u:
				{
					int num52;
					if ((uint)c <= 93u)
					{
						num2 = 1722190167;
						num52 = 1722190167;
					}
					else
					{
						num2 = 135066723;
						num52 = 135066723;
					}
					continue;
				}
				case 73u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = ((int)num3 * -1427131247) ^ -177034671;
					continue;
				case 71u:
				{
					int num49;
					int num50;
					if (flag13)
					{
						num49 = 1710024332;
						num50 = 1710024332;
					}
					else
					{
						num49 = 202208658;
						num50 = 202208658;
					}
					num2 = num49 ^ ((int)num3 * -1039591968);
					continue;
				}
				case 70u:
				{
					int num46;
					if (c == ' ')
					{
						num2 = 1454076186;
						num46 = 1454076186;
					}
					else
					{
						num2 = 563765784;
						num46 = 563765784;
					}
					continue;
				}
				case 69u:
					num2 = 1268123976;
					continue;
				case 68u:
					flag6 = flag4;
					num2 = ((int)num3 * -1283155421) ^ 0x23ACAD45;
					continue;
				case 66u:
					jSONNode = stack.Peek();
					num2 = ((int)num3 * -131826373) ^ 0x4FFA811D;
					continue;
				case 65u:
					num2 = (int)(num3 * 1881095258) ^ -2111889767;
					continue;
				case 63u:
					flag16 = JSONNode.smethod_6(text2, "");
					num2 = 16918836;
					continue;
				case 62u:
					num2 = ((int)num3 * -298507744) ^ 0x799DCF01;
					continue;
				case 61u:
				{
					int num43;
					int num44;
					if (flag15)
					{
						num43 = -1937146911;
						num44 = -1937146911;
					}
					else
					{
						num43 = -1326526633;
						num44 = -1326526633;
					}
					num2 = num43 ^ (int)(num3 * 973016913);
					continue;
				}
				case 60u:
					goto IL_093c;
				case 59u:
					num2 = (int)((num3 * 1937850753) ^ 0x15FD9F98);
					continue;
				case 58u:
				{
					int num40;
					int num41;
					if (stack.Count > 0)
					{
						num40 = -2001513729;
						num41 = -2001513729;
					}
					else
					{
						num40 = -568480575;
						num41 = -568480575;
					}
					num2 = num40 ^ (int)(num3 * 1852198355);
					continue;
				}
				case 57u:
					flag12 = jSONNode != null;
					num2 = ((int)num3 * -1987080053) ^ -62122284;
					continue;
				case 56u:
					num2 = ((int)num3 * -1092048128) ^ 0x16895536;
					continue;
				case 55u:
				{
					int num38;
					int num39;
					if (!flag4)
					{
						num38 = 237487608;
						num39 = 237487608;
					}
					else
					{
						num38 = 678131780;
						num39 = 678131780;
					}
					num2 = num38 ^ ((int)num3 * -584457624);
					continue;
				}
				case 54u:
					num2 = ((int)num3 * -1475161151) ^ 0x56B49045;
					continue;
				case 52u:
				{
					int num36;
					int num37;
					if (flag14)
					{
						num36 = 1854464907;
						num37 = 1854464907;
					}
					else
					{
						num36 = 1367660716;
						num37 = 1367660716;
					}
					num2 = num36 ^ (int)(num3 * 919082944);
					continue;
				}
				case 51u:
					flag14 = jSONNode is JSONArray;
					num2 = ((int)num3 * -1589054837) ^ -895484034;
					continue;
				case 50u:
					text2 = text;
					text = "";
					num2 = 1793770618;
					continue;
				case 49u:
				{
					int num35;
					if (c != '"')
					{
						num2 = 1969836534;
						num35 = 1969836534;
					}
					else
					{
						num2 = 294071033;
						num35 = 294071033;
					}
					continue;
				}
				case 48u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\t':
						goto IL_03e2;
					case '\v':
					case '\f':
						goto IL_093c;
					default:
						goto IL_0aa5;
					}
					goto case 15u;
				case 47u:
					text2 = "";
					text = "";
					num2 = 199427997;
					continue;
				case 46u:
				{
					int num33;
					int num34;
					if ((uint)c2 > 102u)
					{
						num33 = 433654985;
						num34 = 433654985;
					}
					else
					{
						num33 = 1611520242;
						num34 = 1611520242;
					}
					num2 = num33 ^ ((int)num3 * -1012825002);
					continue;
				}
				case 45u:
					text2 = "";
					num2 = 722171501;
					continue;
				case 44u:
					num2 = 1601486649;
					continue;
				case 43u:
					flag13 = JSONNode.smethod_6(text2, "");
					num2 = 650173660;
					continue;
				case 42u:
				{
					int num30;
					if (!flag4)
					{
						num2 = 1593697656;
						num30 = 1593697656;
					}
					else
					{
						num2 = 378075478;
						num30 = 378075478;
					}
					continue;
				}
				case 41u:
					text = "";
					num2 = (int)(num3 * 329621503) ^ -1132124805;
					continue;
				case 40u:
				{
					c3 = JSONNode.smethod_2(aJSON, num);
					char c4 = c3;
					c2 = c4;
					num2 = (int)(num3 * 820976446) ^ -975908351;
					continue;
				}
				case 39u:
					jSONNode.Add(text2, stack.Peek());
					num2 = ((int)num3 * -397917757) ^ -1261101641;
					continue;
				case 38u:
					num2 = (int)(num3 * 1860250650) ^ -1567550569;
					continue;
				case 37u:
				{
					int num27;
					int num28;
					if (c2 == 'b')
					{
						num27 = -2006451427;
						num28 = -2006451427;
					}
					else
					{
						num27 = -923263123;
						num28 = -923263123;
					}
					num2 = num27 ^ ((int)num3 * -1286820012);
					continue;
				}
				case 35u:
					num2 = ((int)num3 * -208806490) ^ -2053909319;
					continue;
				case 34u:
				{
					int num23;
					int num24;
					if (!flag)
					{
						num23 = 2034805896;
						num24 = 2034805896;
					}
					else
					{
						num23 = 740311892;
						num24 = 740311892;
					}
					num2 = num23 ^ ((int)num3 * -849272692);
					continue;
				}
				case 33u:
				{
					int num19;
					int num20;
					if (flag10)
					{
						num19 = -1803017492;
						num20 = -1803017492;
					}
					else
					{
						num19 = -492249710;
						num20 = -492249710;
					}
					num2 = num19 ^ ((int)num3 * -1358328294);
					continue;
				}
				case 32u:
					num2 = (int)((num3 * 1764107070) ^ 0x3FBD77A6);
					continue;
				case 31u:
					text2 = "";
					num2 = 1106307378;
					continue;
				case 30u:
					num2 = (int)((num3 * 1545777852) ^ 0x117F8F63);
					continue;
				case 29u:
					num2 = ((int)num3 * -1434734570) ^ 0x2D6630A1;
					continue;
				case 27u:
					text2 = "";
					text = "";
					num2 = 2050291118;
					continue;
				case 26u:
					stack.Push(new JSONArray());
					num2 = 1938440394;
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, "\f");
					num2 = 2039429443;
					continue;
				case 23u:
					num2 = ((int)num3 * -1788601814) ^ 0x765C7CB4;
					continue;
				case 22u:
				{
					int num15;
					int num16;
					if (flag8)
					{
						num15 = -1945660207;
						num16 = -1945660207;
					}
					else
					{
						num15 = -1348622986;
						num16 = -1348622986;
					}
					num2 = num15 ^ ((int)num3 * -1670546261);
					continue;
				}
				case 21u:
					num2 = 291679344;
					continue;
				case 20u:
					flag5 = num < JSONNode.smethod_4(aJSON);
					num2 = 205696439;
					continue;
				case 19u:
					result = jSONNode;
					num2 = 1748303077;
					continue;
				case 18u:
				{
					int num11;
					int num12;
					if (flag6)
					{
						num11 = 137871579;
						num12 = 137871579;
					}
					else
					{
						num11 = 290796473;
						num12 = 290796473;
					}
					num2 = num11 ^ ((int)num3 * -468774464);
					continue;
				}
				case 16u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)(num3 * 162203939) ^ -1835577572;
					continue;
				case 14u:
					jSONNode.Add(text2, text);
					num2 = ((int)num3 * -349130562) ^ -15347873;
					continue;
				case 13u:
					num2 = ((int)num3 * -1307762199) ^ -441289442;
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag5)
					{
						num8 = -1273284778;
						num9 = -1273284778;
					}
					else
					{
						num8 = -1552776352;
						num9 = -1552776352;
					}
					num2 = num8 ^ ((int)num3 * -1836221706);
					continue;
				}
				case 11u:
					text2 = JSONNode.smethod_5(text2);
					num2 = ((int)num3 * -1389803852) ^ 0x4F4501C;
					continue;
				case 10u:
					flag4 = !flag4;
					num2 = 1210671108;
					continue;
				case 9u:
				{
					int num4;
					int num5;
					if (flag2)
					{
						num4 = 1574786287;
						num5 = 1574786287;
					}
					else
					{
						num4 = 2111262742;
						num5 = 2111262742;
					}
					num2 = num4 ^ ((int)num3 * -109952487);
					continue;
				}
				case 8u:
					jSONNode.Add(stack.Peek());
					num2 = ((int)num3 * -168985876) ^ 0x374295E7;
					continue;
				case 7u:
					flag = JSONNode.smethod_6(text, "");
					num2 = 1415973005;
					continue;
				case 6u:
					s = JSONNode.smethod_8(aJSON, num + 1, 4);
					num2 = (int)((num3 * 659960283) ^ 0x4A59ABD2);
					continue;
				case 5u:
					num2 = (int)((num3 * 472332160) ^ 0x23F31EE3);
					continue;
				case 4u:
					num2 = (int)((num3 * 888739596) ^ 0x7D9268A4);
					continue;
				case 3u:
					num2 = (int)((num3 * 1303689222) ^ 0x2C34F48E);
					continue;
				case 2u:
					jSONNode = stack.Peek();
					num2 = (int)(num3 * 1115176939) ^ -1675426390;
					continue;
				case 1u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = ((int)num3 * -1391917874) ^ -990422302;
					continue;
				case 0u:
					jSONNode.Add(text);
					num2 = ((int)num3 * -295812918) ^ 0x6ED96086;
					continue;
				case 28u:
					break;
				case 53u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 91u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_04b6:
					num2 = 1610907321;
					continue;
					IL_0aa5:
					num2 = ((int)num3 * -1255039113) ^ 0x4D9F65CE;
					continue;
					IL_04a0:
					text = JSONNode.smethod_3(text, "\t");
					num2 = 90459275;
					continue;
					IL_0488:
					text = JSONNode.smethod_3(text, c3.ToString());
					num2 = 90459275;
					continue;
					IL_0472:
					text = JSONNode.smethod_3(text, "\r");
					num2 = 790381417;
					continue;
					IL_03e2:
					if (flag4)
					{
						num2 = 856862813;
						num42 = 856862813;
					}
					else
					{
						num2 = 1222746108;
						num42 = 1222746108;
					}
					continue;
					IL_093c:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = 2107953227;
					continue;
					IL_0304:
					if (flag4)
					{
						num2 = 1396861578;
						num55 = 1396861578;
					}
					else
					{
						num2 = 810819429;
						num55 = 810819429;
					}
					continue;
					IL_02fa:
					num2 = 1876399862;
					continue;
					IL_029d:
					if (flag4)
					{
						num2 = 34186154;
						num59 = 34186154;
					}
					else
					{
						num2 = 391019989;
						num59 = 391019989;
					}
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
			int num = 5547526;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF86DB9u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
					Serialize(aWriter);
					return;
				}
				break;
				IL_0003:
				aWriter = JSONNode.smethod_9(aData);
				num = (int)(num2 * 1049298168) ^ -360377082;
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
			int num = -1125254426;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x872288D4u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					FileStream fileStream = JSONNode.smethod_14(aFileName);
					try
					{
						SaveToStream(fileStream);
						return;
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00a2:
								int num3 = -1327408975;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x872288D4u) % 4u)
									{
									case 2u:
										num3 = (int)(num2 * 1359053682) ^ -950248844;
										continue;
									case 1u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num3 = (int)(num2 * 1608419369) ^ -2027290749;
										continue;
									default:
										goto end_IL_0081;
									case 3u:
										break;
									case 0u:
										goto end_IL_0081;
									}
									goto IL_00a2;
									continue;
									end_IL_0081:
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
				num = ((int)num2 * -2072943648) ^ 0x22D364B6;
			}
		}
	}

	public string SaveToBase64()
	{
		MemoryStream memoryStream = JSONNode.smethod_16();
		try
		{
			SaveToStream(memoryStream);
			string result = default(string);
			while (true)
			{
				int num = -1386451483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA9C5482u) % 6u)
					{
					case 5u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 932058002) ^ -1156699946;
						continue;
					case 4u:
						num = (int)((num2 * 582827033) ^ 0x67FD6343);
						continue;
					case 3u:
						num = (int)((num2 * 1878642746) ^ 0x61477B65);
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 362196561) ^ 0x6EA825FF);
						continue;
					case 0u:
						break;
					default:
						return result;
					case 2u:
						return result;
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
					IL_00cb:
					int num3 = -1879910435;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xEA9C5482u) % 3u)
						{
						case 2u:
							goto IL_009b;
						default:
							goto end_IL_00ae;
						case 0u:
							break;
						case 1u:
							goto end_IL_00ae;
						}
						goto IL_00cb;
						IL_009b:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -773014385) ^ -718858027;
						continue;
						end_IL_00ae:
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
		JSONArray jSONArray = default(JSONArray);
		string aKey = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONClass jSONClass = default(JSONClass);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -435455069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD12F80Eu) % 42u)
				{
				case 41u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 429440982) ^ 0x6470BDAD);
					continue;
				case 40u:
					jSONArray.Add(Deserialize(aReader));
					num = -774453168;
					continue;
				case 39u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1319301219) ^ 0x3A3D8BC7;
					continue;
				case 38u:
					num3 = 0;
					num = (int)(num2 * 1778440487) ^ -22437374;
					continue;
				case 37u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 1121488780) ^ -1435184553;
					continue;
				case 35u:
					num = -693974085;
					continue;
				case 34u:
					result = jSONArray;
					num = (int)((num2 * 848804894) ^ 0x347C553);
					continue;
				case 33u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = -1095681655;
						num10 = -1095681655;
					}
					else
					{
						num9 = -465018940;
						num10 = -465018940;
					}
					num = num9 ^ (int)(num2 * 1636729853);
					continue;
				}
				case 32u:
					num6++;
					num = ((int)num2 * -322913183) ^ 0x771E27BA;
					continue;
				case 31u:
					num = (int)((num2 * 463963318) ^ 0x47926047);
					continue;
				case 29u:
					num3++;
					num = (int)(num2 * 838373560) ^ -1993807948;
					continue;
				case 28u:
					goto IL_011d;
				case 27u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = ((int)num2 * -1547683175) ^ -2015610094;
					continue;
				case 26u:
					num = (int)(num2 * 202857081) ^ -1920264131;
					continue;
				case 25u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -112726642) ^ 0x6C96553B;
					continue;
				case 24u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1493964836) ^ -798375978;
					continue;
				}
				case 23u:
					jSONClass = new JSONClass();
					num = (int)(num2 * 198440307) ^ -1580281221;
					continue;
				case 22u:
					num = ((int)num2 * -136992053) ^ 0x66619E03;
					continue;
				case 21u:
					jSONArray = new JSONArray();
					num = (int)(num2 * 1999250747) ^ -1918144017;
					continue;
				case 20u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1461488713) ^ 0x615F76DD;
					continue;
				case 19u:
					goto IL_01f1;
				case 18u:
					flag2 = num6 < num5;
					num = -728956822;
					continue;
				case 17u:
					result = jSONClass;
					num = ((int)num2 * -1264500157) ^ 0x116C5FBB;
					continue;
				case 16u:
					num = -1162200527;
					continue;
				case 15u:
					goto IL_022d;
				case 14u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -680413622) ^ -186003008;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1437887040;
						num8 = -1437887040;
					}
					else
					{
						num7 = -1890800470;
						num8 = -1890800470;
					}
					num = num7 ^ (int)(num2 * 2074124187);
					continue;
				}
				case 11u:
					goto IL_028d;
				case 10u:
					num = (int)((num2 * 1405789022) ^ 0xD93F697);
					continue;
				case 9u:
					num4 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -58441220) ^ 0x20EB6D31;
					continue;
				case 8u:
					num = ((int)num2 * -183316685) ^ 0xAA923C;
					continue;
				case 7u:
					num = -1801293840;
					continue;
				case 6u:
					num6 = 0;
					num = (int)((num2 * 916009422) ^ 0x1C169CC0);
					continue;
				case 5u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Class:
						goto IL_011d;
					case JSONBinaryTag.BoolValue:
						goto IL_01f1;
					case JSONBinaryTag.Value:
						goto IL_022d;
					case JSONBinaryTag.IntValue:
						goto IL_028d;
					default:
						goto IL_0319;
					case JSONBinaryTag.Array:
						goto IL_0329;
					case JSONBinaryTag.FloatValue:
						goto IL_0337;
					}
					goto case 35u;
				case 3u:
					goto IL_0329;
				case 2u:
					goto IL_0337;
				case 4u:
					flag = num3 < num4;
					num = -273951703;
					continue;
				case 1u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -1571367004) ^ -1538760849;
					continue;
				case 0u:
					num = (int)(num2 * 1527790528) ^ -747732125;
					continue;
				case 36u:
					break;
				case 30u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0337:
					num = -261075268;
					continue;
					IL_0329:
					num5 = JSONNode.smethod_21(aReader);
					num = -891472605;
					continue;
					IL_0319:
					num = (int)(num2 * 591274725) ^ -662690546;
					continue;
					IL_028d:
					num = -918202655;
					continue;
					IL_022d:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -214474432;
					continue;
					IL_01f1:
					num = -1144105654;
					continue;
					IL_011d:
					num = -1944603627;
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
					int num = 1410126097;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x187A557Au) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = (int)((num2 * 146478720) ^ 0x50F18DD3);
							continue;
						case 1u:
							num = ((int)num2 * -1527280400) ^ -1449238676;
							continue;
						default:
							goto end_IL_0037;
						case 0u:
							break;
						case 2u:
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
					int num = -2060970226;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x9704CC45u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -636966421) ^ -440091608;
							continue;
						case 0u:
							num = (int)((num2 * 703859454) ^ 0x30E585A0);
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 2093434811;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10569014u) % 5u)
				{
				case 3u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -272839939) ^ 0xFF41F14;
					continue;
				case 1u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -71121839) ^ -1350162750;
					continue;
				case 0u:
					num = ((int)num2 * -1971097320) ^ -2119237463;
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
			int num = -126067223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA6F4728u) % 3u)
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
				num = (int)(num2 * 39864120) ^ -1990522296;
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
