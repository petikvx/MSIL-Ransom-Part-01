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
				int num = -1360215554;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF01D1E42u) % 3u)
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
					num = (int)((num2 * 798612622) ^ 0x57FECD8A);
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
				int num = 779128460;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55727884u) % 3u)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0008:
					num = ((int)num2 * -689409592) ^ 0x5EC040B9;
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
				int num = -1101220802;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x91B59FD7u) % 3u)
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
					num = (int)(num2 * 1591789825) ^ -333043560;
				}
			}
		}
	}

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			while (true)
			{
				int num = 1477693214;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x16ACF016u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)(num2 * 1007479592) ^ -1071680961;
				}
			}
		}
	}

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			return _003Cget_DeepChilds_003Ed__;
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
				int num = -1319322283;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE57EF936u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -126359440) ^ 0x7C2A033C;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 149437081;
							num4 = 149437081;
						}
						else
						{
							num3 = 1043145046;
							num4 = 1043145046;
						}
						num = num3 ^ ((int)num2 * -772450335);
						continue;
					}
					case 1u:
						result2 = result;
						num = ((int)num2 * -368849325) ^ 0x307A31B4;
						continue;
					case 0u:
						result2 = 0;
						num = -1949624084;
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
			while (true)
			{
				int num = -1784254780;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE7D658DFu) % 3u)
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
					num = (int)(num2 * 974031543) ^ -1235749754;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			bool flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
			float result2 = default(float);
			while (true)
			{
				int num = 480450747;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x121A13AEu) % 5u)
					{
					case 3u:
						result2 = 0f;
						num = 325413652;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 15748862;
							num4 = 15748862;
						}
						else
						{
							num3 = 1478212244;
							num4 = 1478212244;
						}
						num = num3 ^ ((int)num2 * -834974288);
						continue;
					}
					case 0u:
						result2 = result;
						num = ((int)num2 * -844921184) ^ 0x4231C154;
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
				int num = -1879224430;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA808E624u) % 3u)
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
					num = ((int)num2 * -942236664) ^ -1177309960;
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
			while (true)
			{
				int num = -668933239;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB665CADu) % 5u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (double.TryParse(Value, out result))
						{
							num3 = 1061358739;
							num4 = 1061358739;
						}
						else
						{
							num3 = 1973696848;
							num4 = 1973696848;
						}
						num = num3 ^ (int)(num2 * 947564376);
						continue;
					}
					case 2u:
						result2 = result;
						num = (int)((num2 * 1337925117) ^ 0x51DF688F);
						continue;
					case 1u:
						result2 = 0.0;
						num = -842765719;
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

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool result2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = -520124428;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC574EB40u) % 8u)
					{
					case 7u:
						result2 = result;
						num = ((int)num2 * -64226323) ^ -26803579;
						continue;
					case 6u:
						num = (int)((num2 * 28336361) ^ 0x7C1B2E75);
						continue;
					case 5u:
						result2 = !JSONNode.smethod_1(Value);
						num = -1629563055;
						continue;
					case 4u:
						flag = bool.TryParse(Value, out result);
						num = ((int)num2 * -480585315) ^ -665432940;
						continue;
					case 1u:
						num = (int)((num2 * 203339643) ^ 0x76F3EF88);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -900772387;
							num4 = -900772387;
						}
						else
						{
							num3 = -118900193;
							num4 = -118900193;
						}
						num = num3 ^ (int)(num2 * 467469899);
						continue;
					}
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
				int num = 404155561;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x76F5027Fu) % 4u)
					{
					case 2u:
						Value = (value ? "true" : "false");
						num = 188584606;
						continue;
					case 1u:
						num = ((int)num2 * -1648060229) ^ -148448597;
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

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1651150218;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBA10DF8u) % 3u)
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
					num = ((int)num2 * -180281666) ^ 0x6600322A;
				}
			}
		}
	}

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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1675402352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11EABC0Du) % 4u)
				{
				case 1u:
					result = null;
					num = (int)((num2 * 1124329586) ^ 0x413FD343);
					continue;
				case 0u:
					num = ((int)num2 * -1346779907) ^ -1034983694;
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2024150742;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB223E460u) % 3u)
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
				num = (int)((num2 * 693570787) ^ 0x4831CD92);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1785505202;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B284F83u) % 4u)
				{
				case 1u:
					result = aNode;
					num = ((int)num2 * -378076966) ^ 0x54D4CB89;
					continue;
				case 0u:
					num = ((int)num2 * -56466198) ^ 0x1F0018D9;
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

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 866072741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2C044C53u) % 3u)
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
				num = (int)((num2 * 89223043) ^ 0x5D3045CE);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -785184930;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2564024u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1943703533) ^ -896063134;
					continue;
				case 2u:
					result = "JSONNode";
					num = (int)((num2 * 1995027568) ^ 0x46347D3);
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2120142944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x821B9D66u) % 3u)
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
				num = (int)(num2 * 958115625) ^ -869683155;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -811435007;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xF9C2D702u) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = (int)(num2 * 1294983410) ^ -1326219590;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
					num = (int)((num2 * 807349381) ^ 0x246696A3);
					continue;
				case 0u:
					obj = d.Value;
					goto IL_001c;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = -642487669;
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
			goto IL_0042;
		}
		goto IL_008e;
		IL_0042:
		int num = -138325509;
		goto IL_0056;
		IL_0056:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9BA1310Fu) % 7u)
			{
			case 6u:
				result = true;
				num = (int)((num2 * 672462341) ^ 0x76EE53EF);
				continue;
			case 5u:
				num = (int)((num2 * 1361341054) ^ 0x1FCFF9C);
				continue;
			case 3u:
				result = (object)a == b;
				num = -1246450553;
				continue;
			case 2u:
				break;
			case 1u:
				num = ((int)num2 * -1595243720) ^ -1994552116;
				continue;
			case 4u:
				goto IL_0083;
			default:
				return result;
			}
			break;
			IL_0083:
			if (a is JSONLazyCreator)
			{
				num = -1725842157;
				num3 = -1725842157;
				continue;
			}
			goto IL_008e;
		}
		goto IL_0042;
		IL_008e:
		num = -1880239443;
		num3 = -1880239443;
		goto IL_0056;
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
		int result = default(int);
		while (true)
		{
			int num = -1358639720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8FEE2ADu) % 4u)
				{
				case 1u:
					result = this.method_0();
					num = (int)(num2 * 1661948135) ^ -1906193994;
					continue;
				case 0u:
					num = (int)(num2 * 1965222615) ^ -401586617;
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

	internal static string Escape(string aText)
	{
		string text = default(string);
		char c3 = default(char);
		string string_ = default(string);
		char c2 = default(char);
		int num3 = default(int);
		char c = default(char);
		string result = default(string);
		while (true)
		{
			int num = -2016002740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB54EFA09u) % 30u)
				{
				case 29u:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1892807417;
					continue;
				case 28u:
				{
					int num6;
					if (c3 != '\\')
					{
						num = -723741671;
						num6 = -723741671;
					}
					else
					{
						num = -359072966;
						num6 = -359072966;
					}
					continue;
				}
				case 27u:
					num = ((int)num2 * -1658672866) ^ -1947776531;
					continue;
				case 26u:
					string_ = aText;
					num = ((int)num2 * -2077823451) ^ -381055398;
					continue;
				case 25u:
					switch (c3)
					{
					case '\t':
						break;
					default:
						goto IL_0087;
					case '\b':
						goto IL_009a;
					case '\n':
						goto IL_00b0;
					case '\v':
						goto IL_00c6;
					case '\f':
						goto IL_00de;
					case '\r':
						goto IL_00f4;
					}
					goto case 29u;
				case 17u:
					goto IL_009a;
				case 6u:
					goto IL_00b0;
				case 13u:
					goto IL_00c6;
				case 22u:
					goto IL_00de;
				case 9u:
					goto IL_00f4;
				case 24u:
					num = ((int)num2 * -88526732) ^ 0x377EDA0C;
					continue;
				case 23u:
					c3 = c2;
					num = ((int)num2 * -1369790995) ^ -387023109;
					continue;
				case 21u:
					num = (int)((num2 * 1113612871) ^ 0x4EC9AAE2);
					continue;
				case 20u:
				{
					int num5;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -1579831909;
						num5 = -1579831909;
					}
					else
					{
						num = -518672042;
						num5 = -518672042;
					}
					continue;
				}
				case 18u:
					c = JSONNode.smethod_2(string_, num3);
					num = -240186927;
					continue;
				case 16u:
				{
					int num4;
					if (c3 != '"')
					{
						num = -696377022;
						num4 = -696377022;
					}
					else
					{
						num = -1090607352;
						num4 = -1090607352;
					}
					continue;
				}
				case 15u:
					result = text;
					num = (int)((num2 * 2019366831) ^ 0x198596DD);
					continue;
				case 14u:
					num3++;
					num = -1517856891;
					continue;
				case 12u:
					num = (int)(num2 * 498712510) ^ -1156858197;
					continue;
				case 11u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -174969189;
					continue;
				case 10u:
					num = ((int)num2 * -938989732) ^ -572463105;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -2086539930) ^ 0x2DAF9937;
					continue;
				case 5u:
					text = "";
					num = (int)((num2 * 1579261871) ^ 0x4671BE5A);
					continue;
				case 4u:
					num = (int)(num2 * 1120426102) ^ -1448695301;
					continue;
				case 3u:
					num = ((int)num2 * -680259716) ^ 0x61565CB;
					continue;
				case 2u:
					c2 = c;
					num = ((int)num2 * -510640489) ^ -135991046;
					continue;
				case 1u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1257566985;
					continue;
				case 0u:
					num = (int)((num2 * 785747403) ^ 0x3FF55E71);
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_00f4:
					text = JSONNode.smethod_3(text, "\\r");
					num = -176666838;
					continue;
					IL_00de:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1257566985;
					continue;
					IL_00c6:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -1257566985;
					continue;
					IL_00b0:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1193128552;
					continue;
					IL_009a:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1257566985;
					continue;
					IL_0087:
					num = ((int)num2 * -808963343) ^ 0x678E08C8;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		JSONNode jSONNode = default(JSONNode);
		string text2 = default(string);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		char c2 = default(char);
		string text = default(string);
		int num10 = default(int);
		bool flag5 = default(bool);
		bool flag = default(bool);
		bool flag10 = default(bool);
		bool flag12 = default(bool);
		bool flag13 = default(bool);
		char c = default(char);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag15 = default(bool);
		char c3 = default(char);
		char c4 = default(char);
		bool flag14 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		bool flag9 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1058405960;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xCDD3409Fu) % 150u)
				{
				case 149u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -2133909244) ^ 0xAFBC14B;
					continue;
				case 148u:
				{
					int num13;
					if (c2 == ',')
					{
						num = -50878519;
						num13 = -50878519;
					}
					else
					{
						num = -525223799;
						num13 = -525223799;
					}
					continue;
				}
				case 147u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = -1505813393;
					continue;
				case 146u:
					num10++;
					flag5 = flag;
					num = -178246085;
					continue;
				case 145u:
				{
					int num59;
					if (!flag)
					{
						num = -1036266296;
						num59 = -1036266296;
					}
					else
					{
						num = -1380743118;
						num59 = -1380743118;
					}
					continue;
				}
				case 144u:
					num = ((int)num2 * -365685095) ^ -931934926;
					continue;
				case 143u:
					num = (int)((num2 * 888949186) ^ 0x494BCED2);
					continue;
				case 142u:
					num = ((int)num2 * -1014938630) ^ -1336832814;
					continue;
				case 141u:
					num = (int)(num2 * 1037462547) ^ -447556107;
					continue;
				case 140u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 456848934) ^ 0x18AEE741);
					continue;
				case 139u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -538476107) ^ 0x5CBAAFC3;
					continue;
				case 138u:
				{
					int num36;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -1038103995;
						num36 = -1038103995;
					}
					else
					{
						num = -1775041816;
						num36 = -1775041816;
					}
					continue;
				}
				case 137u:
					text2 = "";
					num = -2082838609;
					continue;
				case 136u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 1329927837) ^ 0x515CAFFC);
					continue;
				case 135u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1733214962;
					continue;
				case 134u:
					num = ((int)num2 * -567645170) ^ 0x46F787FE;
					continue;
				case 133u:
					num = -198151610;
					continue;
				case 132u:
					jSONNode.Add(text);
					num = (int)((num2 * 1955868408) ^ 0x53E0CB17);
					continue;
				case 131u:
					text = "";
					num = ((int)num2 * -779761457) ^ -547704801;
					continue;
				case 130u:
					text2 = "";
					text = "";
					num = -816837916;
					continue;
				case 129u:
					switch (c2)
					{
					case '\\':
						break;
					default:
						goto IL_021b;
					case '[':
						goto IL_0225;
					case ']':
						goto IL_0245;
					}
					goto case 146u;
				case 127u:
					goto IL_0225;
				case 78u:
					goto IL_0245;
				case 128u:
					num = (int)(num2 * 831734400) ^ -1113694523;
					continue;
				case 126u:
					flag10 = flag;
					num = -1436806037;
					continue;
				case 125u:
				{
					int num56;
					int num57;
					if (jSONNode is JSONArray)
					{
						num56 = -809719370;
						num57 = -809719370;
					}
					else
					{
						num56 = -390941885;
						num57 = -390941885;
					}
					num = num56 ^ (int)(num2 * 1330242840);
					continue;
				}
				case 124u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)((num2 * 622990849) ^ 0x70754F74);
					continue;
				case 123u:
					num = -1543246648;
					continue;
				case 122u:
					flag12 = flag;
					num = ((int)num2 * -64807907) ^ -915856498;
					continue;
				case 121u:
					num = -1666777449;
					continue;
				case 120u:
				{
					int num50;
					if (stack.Count != 0)
					{
						num = -1022287251;
						num50 = -1022287251;
					}
					else
					{
						num = -1219145278;
						num50 = -1219145278;
					}
					continue;
				}
				case 119u:
					num = ((int)num2 * -1673510485) ^ 0x340C8F84;
					continue;
				case 118u:
				{
					int num45;
					int num46;
					if (c2 == ':')
					{
						num45 = 1963426263;
						num46 = 1963426263;
					}
					else
					{
						num45 = 866268145;
						num46 = 866268145;
					}
					num = num45 ^ ((int)num2 * -239839030);
					continue;
				}
				case 117u:
					num = ((int)num2 * -2030549816) ^ 0x6B584FC2;
					continue;
				case 116u:
					num = ((int)num2 * -459641455) ^ 0x7BD4A5FF;
					continue;
				case 115u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 1671157949) ^ -1460990315;
					continue;
				case 114u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -1961971451) ^ 0x28FA3EC5;
					continue;
				case 113u:
					text = JSONNode.smethod_3(text, "\n");
					num = -687720220;
					continue;
				case 112u:
					flag13 = JSONNode.smethod_6(text2, "");
					num = -870867833;
					continue;
				case 111u:
					c = JSONNode.smethod_2(aJSON, num10);
					num = ((int)num2 * -1638726398) ^ -607494480;
					continue;
				case 110u:
					num = ((int)num2 * -1169742858) ^ -1907082378;
					continue;
				case 55u:
				case 56u:
				case 96u:
				case 101u:
				case 109u:
					goto IL_0435;
				case 108u:
				{
					string s = JSONNode.smethod_8(aJSON, num10 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 1725872165) ^ 0x36776DB4);
					continue;
				}
				case 107u:
					num = ((int)num2 * -2135060123) ^ -159487219;
					continue;
				case 106u:
					num = ((int)num2 * -442153761) ^ -1337255480;
					continue;
				case 105u:
				{
					int num33;
					if ((uint)c2 <= 93u)
					{
						num = -134799219;
						num33 = -134799219;
					}
					else
					{
						num = -1730287360;
						num33 = -1730287360;
					}
					continue;
				}
				case 104u:
					num = ((int)num2 * -94079400) ^ 0x7EFB7805;
					continue;
				case 103u:
					num = ((int)num2 * -1213375017) ^ -2110683291;
					continue;
				case 102u:
					flag3 = flag;
					num = -1958189803;
					continue;
				case 100u:
					text2 = "";
					num = -1759336922;
					continue;
				case 99u:
					num = (int)(num2 * 1236918298) ^ -1907433383;
					continue;
				case 98u:
					flag = !flag;
					num = -121566098;
					continue;
				case 97u:
					num = ((int)num2 * -1523078890) ^ 0x7FABDE37;
					continue;
				case 95u:
				{
					int num25;
					int num26;
					if (flag6)
					{
						num25 = -305799768;
						num26 = -305799768;
					}
					else
					{
						num25 = -2140814295;
						num26 = -2140814295;
					}
					num = num25 ^ (int)(num2 * 1270681439);
					continue;
				}
				case 94u:
				{
					int num21;
					int num22;
					if (!flag10)
					{
						num21 = -209529846;
						num22 = -209529846;
					}
					else
					{
						num21 = -1940951824;
						num22 = -1940951824;
					}
					num = num21 ^ ((int)num2 * -1222973807);
					continue;
				}
				case 93u:
				{
					int num18;
					if (c2 == ' ')
					{
						num = -476669012;
						num18 = -476669012;
					}
					else
					{
						num = -1638833402;
						num18 = -1638833402;
					}
					continue;
				}
				case 92u:
					switch (c2)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_0435;
					default:
						goto IL_05d5;
					case '\t':
						goto IL_05e8;
					}
					goto case 147u;
				case 85u:
					goto IL_05e8;
				case 91u:
					num = (int)(num2 * 1178827549) ^ -1277583169;
					continue;
				case 90u:
					num = -1797343636;
					continue;
				case 89u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = 1488433347;
						num9 = 1488433347;
					}
					else
					{
						num8 = 1927913563;
						num9 = 1927913563;
					}
					num = num8 ^ ((int)num2 * -642836142);
					continue;
				}
				case 88u:
				{
					int num61;
					int num62;
					if ((uint)c2 <= 32u)
					{
						num61 = -361059719;
						num62 = -361059719;
					}
					else
					{
						num61 = -1081689904;
						num62 = -1081689904;
					}
					num = num61 ^ (int)(num2 * 1118488268);
					continue;
				}
				case 87u:
				{
					int num60;
					if (c2 != '"')
					{
						num = -1010546584;
						num60 = -1010546584;
					}
					else
					{
						num = -259482491;
						num60 = -259482491;
					}
					continue;
				}
				case 86u:
				{
					int num58;
					if (c2 != '}')
					{
						num = -554477237;
						num58 = -554477237;
					}
					else
					{
						num = -1290991679;
						num58 = -1290991679;
					}
					continue;
				}
				case 84u:
					num = -287655005;
					continue;
				case 83u:
					flag15 = JSONNode.smethod_6(text, "");
					num = -827082359;
					continue;
				case 82u:
				{
					int num55;
					if (c3 == 'f')
					{
						num = -171002673;
						num55 = -171002673;
					}
					else
					{
						num = -1581300731;
						num55 = -1581300731;
					}
					continue;
				}
				case 81u:
				{
					int num53;
					int num54;
					if (jSONNode != null)
					{
						num53 = 1484332386;
						num54 = 1484332386;
					}
					else
					{
						num53 = 1168570338;
						num54 = 1168570338;
					}
					num = num53 ^ ((int)num2 * -238751195);
					continue;
				}
				case 80u:
					num = -2015603525;
					continue;
				case 79u:
				{
					char c5 = c4;
					c3 = c5;
					int num51;
					int num52;
					if ((uint)c3 <= 102u)
					{
						num51 = 176829725;
						num52 = 176829725;
					}
					else
					{
						num51 = 512911259;
						num52 = 512911259;
					}
					num = num51 ^ ((int)num2 * -840278561);
					continue;
				}
				case 76u:
					flag14 = jSONNode is JSONArray;
					num = (int)((num2 * 34221384) ^ 0x2032F234);
					continue;
				case 75u:
					text = JSONNode.smethod_3(text, "\t");
					num = -687720220;
					continue;
				case 74u:
					num = ((int)num2 * -1273290021) ^ 0x34223412;
					continue;
				case 73u:
				{
					int num49;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -603300798;
						num49 = -603300798;
					}
					else
					{
						num = -14889642;
						num49 = -14889642;
					}
					continue;
				}
				case 72u:
					jSONNode.Add(text);
					num = (int)(num2 * 918675290) ^ -80647644;
					continue;
				case 71u:
					num = (int)((num2 * 424666645) ^ 0x22401EE7);
					continue;
				case 70u:
				{
					int num47;
					int num48;
					if (!flag15)
					{
						num47 = 746680637;
						num48 = 746680637;
					}
					else
					{
						num47 = 339785786;
						num48 = 339785786;
					}
					num = num47 ^ ((int)num2 * -889622103);
					continue;
				}
				case 69u:
					num = ((int)num2 * -293005479) ^ -550095369;
					continue;
				case 68u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 687188609) ^ -616112631;
					continue;
				case 67u:
				{
					int num43;
					int num44;
					if (!flag14)
					{
						num43 = -970263249;
						num44 = -970263249;
					}
					else
					{
						num43 = -756998020;
						num44 = -756998020;
					}
					num = num43 ^ ((int)num2 * -1851829223);
					continue;
				}
				case 66u:
				{
					int num41;
					int num42;
					if (!flag13)
					{
						num41 = -386080933;
						num42 = -386080933;
					}
					else
					{
						num41 = -984864896;
						num42 = -984864896;
					}
					num = num41 ^ ((int)num2 * -115139386);
					continue;
				}
				case 65u:
				{
					int num39;
					int num40;
					if (flag8)
					{
						num39 = 110989725;
						num40 = 110989725;
					}
					else
					{
						num39 = 1803468127;
						num40 = 1803468127;
					}
					num = num39 ^ (int)(num2 * 159962472);
					continue;
				}
				case 64u:
					num = (int)((num2 * 262056975) ^ 0x475D1853);
					continue;
				case 63u:
				{
					int num37;
					int num38;
					if (!flag12)
					{
						num37 = -1787406254;
						num38 = -1787406254;
					}
					else
					{
						num37 = -522792659;
						num38 = -522792659;
					}
					num = num37 ^ ((int)num2 * -2134724550);
					continue;
				}
				case 61u:
				{
					int num34;
					int num35;
					if (c3 != 'b')
					{
						num34 = -1193223760;
						num35 = -1193223760;
					}
					else
					{
						num34 = -1304890935;
						num35 = -1304890935;
					}
					num = num34 ^ (int)(num2 * 1374391621);
					continue;
				}
				case 60u:
					goto IL_0939;
				case 59u:
					num = (int)((num2 * 608685644) ^ 0x74E04B85);
					continue;
				case 57u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = -242538431;
					continue;
				case 54u:
					text = "";
					jSONNode = stack.Peek();
					num = (int)(num2 * 1659931737) ^ -555500666;
					continue;
				case 53u:
				{
					int num32;
					if (c3 != 'n')
					{
						num = -954016871;
						num32 = -954016871;
					}
					else
					{
						num = -1890623576;
						num32 = -1890623576;
					}
					continue;
				}
				case 52u:
					num = ((int)num2 * -1416031557) ^ -1350745115;
					continue;
				case 51u:
				{
					int num30;
					int num31;
					if (!(jSONNode is JSONArray))
					{
						num30 = -81166693;
						num31 = -81166693;
					}
					else
					{
						num30 = -1468452023;
						num31 = -1468452023;
					}
					num = num30 ^ (int)(num2 * 1428837216);
					continue;
				}
				case 50u:
					c4 = JSONNode.smethod_2(aJSON, num10);
					num = ((int)num2 * -91650169) ^ 0x3A7CE976;
					continue;
				case 49u:
				{
					int num28;
					int num29;
					if (flag2)
					{
						num28 = -1490209618;
						num29 = -1490209618;
					}
					else
					{
						num28 = -2075960458;
						num29 = -2075960458;
					}
					num = num28 ^ ((int)num2 * -315076983);
					continue;
				}
				case 48u:
					num = (int)(num2 * 1636256910) ^ -1332244848;
					continue;
				case 47u:
					num = (int)(num2 * 1089552666) ^ -1219974443;
					continue;
				case 46u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -2047964040) ^ -107661038;
					continue;
				case 45u:
					goto IL_0a96;
				case 44u:
					num = ((int)num2 * -2041960064) ^ -297765365;
					continue;
				case 43u:
					num = (int)((num2 * 1186818481) ^ 0x1943FE33);
					continue;
				case 42u:
					text = "";
					text2 = "";
					flag = false;
					num = (int)(num2 * 1509033888) ^ -1997262043;
					continue;
				case 41u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -180298673) ^ 0x1FCF251B;
					continue;
				case 40u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1870630633) ^ -504771637;
					continue;
				case 39u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num10 = 0;
					num = ((int)num2 * -1208100426) ^ -914082393;
					continue;
				case 38u:
					stack.Pop();
					flag11 = JSONNode.smethod_6(text, "");
					num = -1099932163;
					continue;
				case 37u:
				{
					int num27;
					if (c2 != '{')
					{
						num = -1011566953;
						num27 = -1011566953;
					}
					else
					{
						num = -1152482818;
						num27 = -1152482818;
					}
					continue;
				}
				case 36u:
					switch (c3)
					{
					case 't':
						break;
					case 's':
						goto IL_0939;
					case 'u':
						goto IL_0a96;
					default:
						goto IL_0b9b;
					case 'r':
						goto IL_0ba5;
					}
					goto case 75u;
				case 12u:
					goto IL_0ba5;
				case 35u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -928430750) ^ -1982133605;
					continue;
				case 34u:
					text = JSONNode.smethod_3(text, "\f");
					num = -1776169144;
					continue;
				case 33u:
					num = (int)(num2 * 1994262032) ^ -1982527500;
					continue;
				case 32u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -283798675) ^ 0x54FC64A;
					continue;
				case 31u:
					num = (int)((num2 * 865446258) ^ 0x745811D0);
					continue;
				case 30u:
				{
					int num23;
					int num24;
					if (flag11)
					{
						num23 = 163757348;
						num24 = 163757348;
					}
					else
					{
						num23 = 1899050335;
						num24 = 1899050335;
					}
					num = num23 ^ (int)(num2 * 2055759140);
					continue;
				}
				case 29u:
				{
					int num19;
					int num20;
					if (!flag9)
					{
						num19 = -811580596;
						num20 = -811580596;
					}
					else
					{
						num19 = -309109915;
						num20 = -309109915;
					}
					num = num19 ^ (int)(num2 * 778025500);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1182887784) ^ -2014738056;
					continue;
				case 27u:
				{
					int num16;
					int num17;
					if (stack.Count > 0)
					{
						num16 = -1374768486;
						num17 = -1374768486;
					}
					else
					{
						num16 = -696352822;
						num17 = -696352822;
					}
					num = num16 ^ (int)(num2 * 1869621705);
					continue;
				}
				case 26u:
					flag9 = jSONNode != null;
					num = ((int)num2 * -692613983) ^ 0x365A4F9C;
					continue;
				case 25u:
					num10 += 4;
					num = ((int)num2 * -1281227753) ^ 0x720D365B;
					continue;
				case 24u:
				{
					int num14;
					int num15;
					if (!flag7)
					{
						num14 = -2141518158;
						num15 = -2141518158;
					}
					else
					{
						num14 = -793583937;
						num15 = -793583937;
					}
					num = num14 ^ ((int)num2 * -403985199);
					continue;
				}
				case 23u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1238711796) ^ -1210664313;
					continue;
				case 22u:
					num = (int)(num2 * 576323470) ^ -698692427;
					continue;
				case 20u:
					num = (int)(num2 * 414399830) ^ -101407421;
					continue;
				case 19u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -1235043350) ^ -1057381669;
					continue;
				case 18u:
					num = ((int)num2 * -1821448573) ^ -450441194;
					continue;
				case 17u:
					stack.Push(new JSONClass());
					num = -960974215;
					continue;
				case 16u:
					text2 = JSONNode.smethod_5(text2);
					flag6 = jSONNode is JSONArray;
					num = (int)((num2 * 653539451) ^ 0x16920BDC);
					continue;
				case 15u:
					num = (int)(num2 * 1560973786) ^ -424943060;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = 497227195;
						num12 = 497227195;
					}
					else
					{
						num11 = 1158103346;
						num12 = 1158103346;
					}
					num = num11 ^ (int)(num2 * 1128171541);
					continue;
				}
				case 13u:
					flag4 = num10 < JSONNode.smethod_4(aJSON);
					num = -2052404042;
					continue;
				case 11u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1166671657) ^ 0x31C2F7ED);
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -155613064;
						num7 = -155613064;
					}
					else
					{
						num6 = -24964044;
						num7 = -24964044;
					}
					num = num6 ^ ((int)num2 * -1193251663);
					continue;
				}
				case 9u:
					stack.Push(new JSONArray());
					num = -1211279797;
					continue;
				case 8u:
					num = (int)((num2 * 1299621176) ^ 0x3F2F0DBA);
					continue;
				case 7u:
					result = jSONNode;
					num = -1688202903;
					continue;
				case 6u:
					text2 = "";
					text = "";
					num = -1221989360;
					continue;
				case 5u:
					num = ((int)num2 * -2071158624) ^ 0x565EDFD2;
					continue;
				case 4u:
					num = ((int)num2 * -1459241041) ^ -134533760;
					continue;
				case 3u:
				{
					c2 = c;
					int num3;
					int num4;
					if ((uint)c2 <= 44u)
					{
						num3 = -1023912315;
						num4 = -1023912315;
					}
					else
					{
						num3 = -1256853642;
						num4 = -1256853642;
					}
					num = num3 ^ (int)(num2 * 400973974);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1329346056) ^ -404634462;
					continue;
				case 1u:
					text2 = text;
					text = "";
					num = -1264189691;
					continue;
				case 0u:
					num = (int)((num2 * 1943234841) ^ 0x186376E2);
					continue;
				case 58u:
					break;
				case 21u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 77u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0225:
					if (!flag)
					{
						num = -1464181668;
						num5 = -1464181668;
					}
					else
					{
						num = -817787014;
						num5 = -817787014;
					}
					continue;
					IL_0245:
					flag2 = flag;
					num = -1733878170;
					continue;
					IL_021b:
					num = -2013279678;
					continue;
					IL_05e8:
					flag8 = flag;
					num = -90177544;
					continue;
					IL_05d5:
					num = ((int)num2 * -1302083864) ^ 0x1BD0F2D0;
					continue;
					IL_0ba5:
					text = JSONNode.smethod_3(text, "\r");
					num = -1692539932;
					continue;
					IL_0b9b:
					num = -948617070;
					continue;
					IL_0a96:
					num = -1839955035;
					continue;
					IL_0939:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = -676178621;
					continue;
					IL_0435:
					num10++;
					num = -1959081901;
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
		Serialize(aWriter);
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
			while (true)
			{
				int num = 1999269142;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12D5FD5Bu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -778753021) ^ -287684779;
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = (int)(num2 * 1772151633) ^ -1652185064;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00a2:
					int num3 = 1764540564;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x12D5FD5Bu) % 3u)
						{
						case 1u:
							goto IL_0072;
						default:
							goto end_IL_0085;
						case 0u:
							break;
						case 2u:
							goto end_IL_0085;
						}
						goto IL_00a2;
						IL_0072:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = ((int)num2 * -1374121665) ^ 0x6151D040;
						continue;
						end_IL_0085:
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
			string result = default(string);
			while (true)
			{
				int num = 1397835423;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3C0AD50Cu) % 5u)
					{
					case 4u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1739749079) ^ -596289048;
						continue;
					case 2u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 1351629429) ^ -2092434496;
						continue;
					case 1u:
						num = (int)((num2 * 1362209199) ^ 0x7C0542E0);
						continue;
					case 0u:
						break;
					default:
						return result;
					case 3u:
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
					int num3 = 1690692566;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x3C0AD50Cu) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -813077950) ^ -429832799;
							continue;
						case 1u:
							num3 = ((int)num2 * -1678317181) ^ 0x8F131B4;
							continue;
						default:
							goto end_IL_00aa;
						case 0u:
							break;
						case 3u:
							goto end_IL_00aa;
						}
						goto IL_00cb;
						continue;
						end_IL_00aa:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		bool flag = default(bool);
		int num6 = default(int);
		int num7 = default(int);
		JSONNode aItem = default(JSONNode);
		JSONNode result = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1268589262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96FE44FFu) % 38u)
				{
				case 37u:
					num = -1641010381;
					continue;
				case 36u:
					num = (int)(num2 * 1234303509) ^ -1026014139;
					continue;
				case 35u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)(num2 * 2141684938) ^ -1600915187;
					continue;
				case 34u:
					goto IL_003d;
				case 33u:
					flag = num6 < num7;
					num = -1400858937;
					continue;
				case 32u:
					num6 = 0;
					num = (int)(num2 * 1990991519) ^ -1411734894;
					continue;
				case 31u:
					num = ((int)num2 * -1802507112) ^ 0x5DB9F716;
					continue;
				case 30u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1795260223) ^ 0x10B5EC1E;
					continue;
				case 29u:
					num = (int)((num2 * 1478212565) ^ 0x2EB0CD95);
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1271881570) ^ 0x497BA186;
					continue;
				case 27u:
					num = (int)(num2 * 1179600849) ^ -1399571239;
					continue;
				case 26u:
					result = jSONArray;
					num = (int)((num2 * 183432224) ^ 0x65FA592E);
					continue;
				case 25u:
					result = jSONClass;
					num = ((int)num2 * -1236748555) ^ -1302648923;
					continue;
				case 23u:
					goto IL_011d;
				case 21u:
					goto IL_0134;
				case 20u:
					goto IL_013e;
				case 19u:
					goto IL_0148;
				case 18u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1181964917;
						num9 = 1181964917;
					}
					else
					{
						num8 = 421841333;
						num9 = 421841333;
					}
					num = num8 ^ (int)(num2 * 710666402);
					continue;
				}
				case 17u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1209920776) ^ -1316661268;
					continue;
				case 16u:
					num6++;
					num = ((int)num2 * -379278544) ^ -1079747150;
					continue;
				case 15u:
					num = (int)((num2 * 1027960007) ^ 0x56750A1C);
					continue;
				case 14u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.FloatValue:
						break;
					case JSONBinaryTag.BoolValue:
						goto IL_003d;
					case JSONBinaryTag.Value:
						goto IL_011d;
					case JSONBinaryTag.IntValue:
						goto IL_0134;
					case JSONBinaryTag.DoubleValue:
						goto IL_013e;
					case JSONBinaryTag.Array:
						goto IL_0148;
					default:
						goto IL_01f7;
					case JSONBinaryTag.Class:
						goto IL_020a;
					}
					goto case 37u;
				case 13u:
					goto IL_020a;
				case 12u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)((num2 * 1706531828) ^ 0xA786455);
					continue;
				case 11u:
					num = (int)((num2 * 2120804182) ^ 0x42A0DE89);
					continue;
				case 10u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -1498813692) ^ 0x2C5D3F26;
					continue;
				case 8u:
					jSONArray.Add(Deserialize(aReader));
					num = -197881070;
					continue;
				case 7u:
					num = ((int)num2 * -219952190) ^ 0x5BA8868B;
					continue;
				case 6u:
				{
					int num5;
					if (num3 >= num4)
					{
						num = -454119104;
						num5 = -454119104;
					}
					else
					{
						num = -1183031054;
						num5 = -1183031054;
					}
					continue;
				}
				case 5u:
					aKey = JSONNode.smethod_22(aReader);
					num = -235667943;
					continue;
				case 4u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 43360544) ^ 0x73EE28EF);
					continue;
				case 3u:
					num = ((int)num2 * -2044036414) ^ 0x564E8AFC;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -1394338373) ^ -955066588;
					continue;
				case 1u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 797024044) ^ 0x31A47D64);
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 338086079) ^ -1533151343;
					continue;
				case 22u:
					break;
				case 24u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_003d:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1829511570;
					continue;
					IL_020a:
					num4 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = -1897549543;
					continue;
					IL_01f7:
					num = ((int)num2 * -37637701) ^ -485606413;
					continue;
					IL_0148:
					num7 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = -710354017;
					continue;
					IL_013e:
					num = -1973862285;
					continue;
					IL_0134:
					num = -68531798;
					continue;
					IL_011d:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1173553270;
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
					int num = -1255574229;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x99297C47u) % 3u)
						{
						case 2u:
							goto IL_0015;
						default:
							goto end_IL_0028;
						case 0u:
							break;
						case 1u:
							goto end_IL_0028;
						}
						goto IL_0045;
						IL_0015:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = (int)(num2 * 1812380877) ^ -1278397675;
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
				int num = 734532713;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B5792AEu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_000a:
					result = LoadFromStream(fileStream);
					num = (int)((num2 * 971135844) ^ 0xC6D828);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008c:
					int num3 = 378336159;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x6B5792AEu) % 4u)
						{
						case 3u:
							num3 = (int)((num2 * 847859137) ^ 0x5C169C8D);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 740888061) ^ -495626776;
							continue;
						default:
							goto end_IL_006b;
						case 2u:
							break;
						case 0u:
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1555941622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13EA0CF7u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -203037798) ^ -599471423;
					continue;
				case 3u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 896507260) ^ 0x472F0837);
					continue;
				}
				case 2u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 2020879039) ^ 0x67BE6C18);
					continue;
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 631058924) ^ -1243856510;
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

	public JSONNode()
	{
		while (true)
		{
			int num = 33728498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D56BDB2u) % 3u)
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
				num = (int)((num2 * 603386416) ^ 0x2AA35339);
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
