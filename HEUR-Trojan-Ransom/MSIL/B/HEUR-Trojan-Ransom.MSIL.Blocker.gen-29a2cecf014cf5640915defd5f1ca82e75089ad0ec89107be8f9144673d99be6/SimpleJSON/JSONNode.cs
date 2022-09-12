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
				int num = 281819051;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F996315u) % 3u)
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
					result = null;
					num = (int)(num2 * 1650425144) ^ -1281582322;
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
				int num = 1010813366;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x606A1FBAu) % 3u)
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
					result = "";
					num = (int)((num2 * 737650831) ^ 0x7C4D811B);
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
				int num = -712275240;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCA4B5385u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 2049131465) ^ 0x4F668710);
						continue;
					case 1u:
						result = 0;
						num = ((int)num2 * -1340477317) ^ -1243286767;
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
				int num = -898288760;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD0E087E1u) % 3u)
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
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = (int)((num2 * 903373203) ^ 0x7F5BDF72);
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
				int num = 2047145937;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD5337BFu) % 4u)
					{
					case 2u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1837804040) ^ 0x1BA7436A;
						continue;
					case 1u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)(num2 * 1435976872) ^ -1172228028;
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

	public virtual int AsInt
	{
		get
		{
			int result2 = default(int);
			int result = default(int);
			while (true)
			{
				int num = 1854043363;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF992DBEu) % 6u)
					{
					case 3u:
					{
						result2 = 0;
						int num3;
						int num4;
						if (int.TryParse(Value, out result2))
						{
							num3 = 391093820;
							num4 = 391093820;
						}
						else
						{
							num3 = 632998031;
							num4 = 632998031;
						}
						num = num3 ^ ((int)num2 * -1144069779);
						continue;
					}
					case 2u:
						result = 0;
						num = 1612685506;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1049463359) ^ -890436709;
						continue;
					case 0u:
						num = ((int)num2 * -1496013169) ^ 0x77391684;
						continue;
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
			Value = value.ToString();
		}
	}

	public virtual float AsFloat
	{
		get
		{
			bool flag = default(bool);
			float result = default(float);
			float result2 = default(float);
			while (true)
			{
				int num = 1013817036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x18192515u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 666542790;
							num4 = 666542790;
						}
						else
						{
							num3 = 71534022;
							num4 = 71534022;
						}
						num = num3 ^ (int)(num2 * 652576517);
						continue;
					}
					case 4u:
						result = result2;
						num = ((int)num2 * -1656398914) ^ 0x204FCEAD;
						continue;
					case 1u:
						result2 = 0f;
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -816929658) ^ -386383890;
						continue;
					case 0u:
						result = 0f;
						num = 2048936241;
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
				int num = 27350796;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63369C46u) % 3u)
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
					num = ((int)num2 * -1968850130) ^ -2138349464;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = default(double);
			bool flag = default(bool);
			double result2 = default(double);
			while (true)
			{
				int num = -1231347794;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0523795u) % 8u)
					{
					case 7u:
						result = 0.0;
						num = -1771690711;
						continue;
					case 5u:
						flag = double.TryParse(Value, out result2);
						num = (int)(num2 * 1292298050) ^ -1791643906;
						continue;
					case 3u:
						result2 = 0.0;
						num = ((int)num2 * -2017917860) ^ 0x4A77A134;
						continue;
					case 2u:
						result = result2;
						num = ((int)num2 * -397595530) ^ -1247449887;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 502390387;
							num4 = 502390387;
						}
						else
						{
							num3 = 1414640134;
							num4 = 1414640134;
						}
						num = num3 ^ (int)(num2 * 926854148);
						continue;
					}
					case 0u:
						num = (int)(num2 * 58901534) ^ -196057735;
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
			while (true)
			{
				int num = 99209182;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4817BD43u) % 3u)
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
					num = (int)((num2 * 1123150983) ^ 0x64A03B5F);
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool flag = bool.TryParse(Value, out result);
			bool result2 = default(bool);
			while (true)
			{
				int num = 166214507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72F5A3A8u) % 5u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 257236126;
							num4 = 257236126;
						}
						else
						{
							num3 = 1489553496;
							num4 = 1489553496;
						}
						num = num3 ^ (int)(num2 * 1185016436);
						continue;
					}
					case 1u:
						result2 = result;
						num = ((int)num2 * -698954543) ^ 0x6FD41AA0;
						continue;
					case 0u:
						result2 = !JSONNode.smethod_1(Value);
						num = 804977962;
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
			Value = (value ? "true" : "false");
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 49594542;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5BB12801u) % 4u)
					{
					case 3u:
						result = this as JSONArray;
						num = ((int)num2 * -934735101) ^ 0x31BD5890;
						continue;
					case 0u:
						num = ((int)num2 * -64051519) ^ 0x48AE2B4;
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = this as JSONClass;
			while (true)
			{
				int num = 1595827630;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D95C2E2u) % 3u)
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
					num = (int)(num2 * 624435347) ^ -1173047770;
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
			int num = 368554326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x181CED48u) % 3u)
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
				Add("", aItem);
				num = ((int)num2 * -285369290) ^ 0x772E88A7;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = null;
		while (true)
		{
			int num = 1398381295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F9A397Du) % 3u)
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
				num = (int)((num2 * 743777389) ^ 0x6E04883E);
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1402124800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD63368E7u) % 3u)
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
				num = ((int)num2 * -1745713398) ^ -801268490;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		return aNode;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -2117242226;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDC08364u) % 4u)
				{
				case 2u:
					result = "JSONNode";
					num = (int)(num2 * 1315717976) ^ -773099599;
					continue;
				case 1u:
					num = ((int)num2 * -1080039041) ^ -734013569;
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
			int num = -1524041733;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA122D6E3u) % 3u)
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
				result = "JSONNode";
				num = ((int)num2 * -1422799289) ^ 0x4098906E;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = new JSONData(s);
		while (true)
		{
			int num = 1499819698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67C4DB7Bu) % 3u)
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
				num = (int)(num2 * 1037374292) ^ -2124804940;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -1670295153;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x80713BC4u) % 4u)
				{
				case 3u:
					if (!(d == null))
					{
						num = ((int)num2 * -1343035893) ^ -1458290173;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					obj = d.Value;
					goto IL_001c;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = -1889524527;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b != null)
		{
			goto IL_0009;
		}
		goto IL_0016;
		IL_0016:
		int num = -340843027;
		goto IL_0056;
		IL_0056:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB9D98F98u) % 7u)
			{
			case 6u:
				break;
			case 5u:
				num = ((int)num2 * -1673025773) ^ 0x58D4147A;
				continue;
			case 4u:
				result = (object)a == b;
				num = -1525390066;
				continue;
			case 3u:
				num = ((int)num2 * -495978806) ^ -1501513962;
				continue;
			case 1u:
				result = true;
				num = ((int)num2 * -1972445141) ^ 0x7807BEFB;
				continue;
			case 2u:
				goto IL_0083;
			default:
				return result;
			}
			break;
			IL_0083:
			if (a is JSONLazyCreator)
			{
				num = -85649296;
				num3 = -85649296;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0016;
		IL_0009:
		num = -614252226;
		num3 = -614252226;
		goto IL_0056;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -351748920;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB60C74C7u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = (int)((num2 * 332321123) ^ 0x1338BD4);
					continue;
				case 2u:
					num = (int)(num2 * 2020649151) ^ -546382740;
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
			int num = -1739200209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF119DCD5u) % 3u)
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
				result = (object)this == obj;
				num = ((int)num2 * -1984941594) ^ -1971833943;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -1713048866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3CF15B6u) % 3u)
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
				num = ((int)num2 * -1728232518) ^ -1063545676;
			}
		}
	}

	internal static string Escape(string aText)
	{
		char c2 = default(char);
		char c3 = default(char);
		int num3 = default(int);
		char c = default(char);
		string text = default(string);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 909763152;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D76CCABu) % 34u)
				{
				case 33u:
					c2 = c3;
					num = ((int)num2 * -1467138235) ^ -411726756;
					continue;
				case 32u:
					num3++;
					num = ((int)num2 * -854984938) ^ 0x6CD7E1F6;
					continue;
				case 31u:
					num = (int)(num2 * 1006994048) ^ -1866929963;
					continue;
				case 30u:
					c3 = c;
					num = (int)((num2 * 1137578313) ^ 0x9F8FBC);
					continue;
				case 29u:
					text = "";
					num = ((int)num2 * -1601043166) ^ -115183854;
					continue;
				case 28u:
				{
					int num6;
					if (c2 == '\\')
					{
						num = 1599067295;
						num6 = 1599067295;
					}
					else
					{
						num = 949491941;
						num6 = 949491941;
					}
					continue;
				}
				case 27u:
					text = JSONNode.smethod_3(text, "\\n");
					num = 290987970;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 202778032;
					continue;
				case 25u:
					goto IL_00c4;
				case 24u:
					switch (c2)
					{
					case '\n':
						break;
					case '\t':
						goto IL_00c4;
					default:
						goto IL_00fb;
					case '\b':
						goto IL_010e;
					case '\v':
						goto IL_0124;
					case '\f':
						goto IL_013c;
					case '\r':
						goto IL_0152;
					}
					goto case 27u;
				case 8u:
					goto IL_010e;
				case 0u:
					goto IL_0124;
				case 4u:
					goto IL_013c;
				case 19u:
					goto IL_0152;
				case 23u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 572514928;
						num5 = 572514928;
					}
					else
					{
						num = 1079490202;
						num5 = 1079490202;
					}
					continue;
				}
				case 22u:
					num = (int)(num2 * 1373207881) ^ -1582494407;
					continue;
				case 21u:
					num = ((int)num2 * -1243207478) ^ -1469305045;
					continue;
				case 20u:
					num = (int)(num2 * 710095629) ^ -1466228696;
					continue;
				case 18u:
					num = ((int)num2 * -762647666) ^ 0x312D1C61;
					continue;
				case 17u:
				{
					int num4;
					if (c2 == '"')
					{
						num = 670155541;
						num4 = 670155541;
					}
					else
					{
						num = 1975784265;
						num4 = 1975784265;
					}
					continue;
				}
				case 16u:
					num = ((int)num2 * -1743574656) ^ -555160542;
					continue;
				case 15u:
					num = ((int)num2 * -2082584941) ^ -1415064876;
					continue;
				case 14u:
					num = 1377563309;
					continue;
				case 12u:
					num = ((int)num2 * -1638516906) ^ 0x38F22415;
					continue;
				case 11u:
					result = text;
					num = (int)(num2 * 617457336) ^ -934446385;
					continue;
				case 10u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 327140299;
					continue;
				case 9u:
					string_ = aText;
					num = (int)((num2 * 636616308) ^ 0x529287D9);
					continue;
				case 7u:
					c = JSONNode.smethod_2(string_, num3);
					num = 237752181;
					continue;
				case 6u:
					num = ((int)num2 * -271113315) ^ 0x27F16185;
					continue;
				case 3u:
					num = (int)((num2 * 602599780) ^ 0x1310436E);
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -171112902) ^ -1600517384;
					continue;
				case 1u:
					num = (int)((num2 * 1355305429) ^ 0x4E429912);
					continue;
				case 13u:
					break;
				default:
					{
						return result;
					}
					IL_0152:
					text = JSONNode.smethod_3(text, "\\r");
					num = 2118695160;
					continue;
					IL_013c:
					text = JSONNode.smethod_3(text, "\\f");
					num = 191557205;
					continue;
					IL_0124:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 859658752;
					continue;
					IL_010e:
					text = JSONNode.smethod_3(text, "\\b");
					num = 191557205;
					continue;
					IL_00fb:
					num = (int)((num2 * 1728105698) ^ 0x2B4AAE31);
					continue;
					IL_00c4:
					text = JSONNode.smethod_3(text, "\\t");
					num = 138609339;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		bool flag4 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		string text2 = default(string);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag2 = default(bool);
		string s = default(string);
		bool flag10 = default(bool);
		int num10 = default(int);
		char c2 = default(char);
		bool flag12 = default(bool);
		char c = default(char);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		char c3 = default(char);
		char c4 = default(char);
		bool flag = default(bool);
		bool flag8 = default(bool);
		bool flag13 = default(bool);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag11 = default(bool);
		while (true)
		{
			int num = 132388496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE1C13u) % 152u)
				{
				case 151u:
				{
					int num49;
					if (!flag4)
					{
						num = 88032784;
						num49 = 88032784;
					}
					else
					{
						num = 1959315880;
						num49 = 1959315880;
					}
					continue;
				}
				case 150u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 1235117904) ^ -2081372494;
					continue;
				case 149u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -750983246) ^ -404627048;
					continue;
				case 148u:
					num = 1294647542;
					continue;
				case 147u:
					num = (int)((num2 * 2114103571) ^ 0x611D905C);
					continue;
				case 146u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -187560517) ^ 0x11EF21EE;
					continue;
				case 145u:
				{
					int num32;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 486852725;
						num32 = 486852725;
					}
					else
					{
						num = 2098125349;
						num32 = 2098125349;
					}
					continue;
				}
				case 144u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 2131500733;
						num6 = 2131500733;
					}
					else
					{
						num5 = 489252891;
						num6 = 489252891;
					}
					num = num5 ^ ((int)num2 * -35071822);
					continue;
				}
				case 143u:
				{
					int num48;
					if (stack.Count != 0)
					{
						num = 172749652;
						num48 = 172749652;
					}
					else
					{
						num = 1830335802;
						num48 = 1830335802;
					}
					continue;
				}
				case 142u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 2131276921) ^ -1468785664;
					continue;
				case 141u:
					flag10 = JSONNode.smethod_6(text, "");
					num = 25913856;
					continue;
				case 140u:
					num = (int)(num2 * 1194786819) ^ -943558020;
					continue;
				case 139u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 1878453462) ^ -1802614718;
					continue;
				case 138u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1925737989) ^ 0x6BD7F29E);
					continue;
				case 137u:
					num = (int)((num2 * 1112177876) ^ 0x522D79B1);
					continue;
				case 136u:
				{
					int num31;
					if (c2 != 'f')
					{
						num = 674073899;
						num31 = 674073899;
					}
					else
					{
						num = 1443007039;
						num31 = 1443007039;
					}
					continue;
				}
				case 135u:
					num10++;
					num = 1410680243;
					continue;
				case 134u:
					text2 = "";
					num = (int)(num2 * 1930076499) ^ -1659008413;
					continue;
				case 133u:
				{
					int num19;
					int num20;
					if (flag12)
					{
						num19 = -1201036382;
						num20 = -1201036382;
					}
					else
					{
						num19 = -531899795;
						num20 = -531899795;
					}
					num = num19 ^ ((int)num2 * -825691237);
					continue;
				}
				case 132u:
				{
					int num7;
					if (c == ',')
					{
						num = 1603302847;
						num7 = 1603302847;
					}
					else
					{
						num = 813775015;
						num7 = 813775015;
					}
					continue;
				}
				case 131u:
					text = text2;
					num = 2043397375;
					continue;
				case 130u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 239879371) ^ -536909357;
					continue;
				case 129u:
					text = "";
					num = 602076533;
					continue;
				case 128u:
					flag2 = flag4;
					num = (int)((num2 * 1005039566) ^ 0x4581E2AB);
					continue;
				case 127u:
					num = ((int)num2 * -2133815803) ^ -1331699045;
					continue;
				case 126u:
					text2 = "";
					num = ((int)num2 * -124684976) ^ 0x6B95194;
					continue;
				case 125u:
					flag12 = jSONNode != null;
					num = (int)(num2 * 844938664) ^ -799290482;
					continue;
				case 124u:
					num = 2132429463;
					continue;
				case 123u:
					jSONNode.Add(text2);
					num = (int)((num2 * 404803479) ^ 0x2168AF6B);
					continue;
				case 122u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 436180917) ^ -1741704635;
					continue;
				case 121u:
					num = (int)((num2 * 1536186083) ^ 0x25A6E3A6);
					continue;
				case 120u:
					num = ((int)num2 * -2101811378) ^ -1983838602;
					continue;
				case 119u:
					text = "";
					num = 174463110;
					continue;
				case 118u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 1346814334) ^ 0x3FCF4F31);
					continue;
				case 117u:
				{
					text = JSONNode.smethod_5(text);
					int num45;
					int num46;
					if (!(jSONNode is JSONArray))
					{
						num45 = -345538885;
						num46 = -345538885;
					}
					else
					{
						num45 = -1582072917;
						num46 = -1582072917;
					}
					num = num45 ^ ((int)num2 * -315762830);
					continue;
				}
				case 116u:
				{
					int num42;
					if (flag4)
					{
						num = 2145293916;
						num42 = 2145293916;
					}
					else
					{
						num = 1626261092;
						num42 = 1626261092;
					}
					continue;
				}
				case 115u:
				{
					int num39;
					if (c == '{')
					{
						num = 1289930483;
						num39 = 1289930483;
					}
					else
					{
						num = 1612995619;
						num39 = 1612995619;
					}
					continue;
				}
				case 114u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 817503242) ^ -539319339;
					continue;
				case 113u:
				{
					int num36;
					if (num10 < JSONNode.smethod_4(aJSON))
					{
						num = 577260079;
						num36 = 577260079;
					}
					else
					{
						num = 2772106;
						num36 = 2772106;
					}
					continue;
				}
				case 112u:
					num = (int)(num2 * 282421275) ^ -1567744929;
					continue;
				case 111u:
				{
					int num33;
					if (c != '"')
					{
						num = 1465730907;
						num33 = 1465730907;
					}
					else
					{
						num = 497053841;
						num33 = 497053841;
					}
					continue;
				}
				case 110u:
					num = 672455514;
					continue;
				case 109u:
					num10 += 4;
					num = (int)(num2 * 620816497) ^ -1455212157;
					continue;
				case 108u:
					num = ((int)num2 * -2142211767) ^ -1638769613;
					continue;
				case 107u:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 1374361822;
					continue;
				case 106u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 1374361822;
					continue;
				case 105u:
				{
					int num22;
					int num23;
					if (c == ':')
					{
						num22 = -1732786273;
						num23 = -1732786273;
					}
					else
					{
						num22 = -1527549993;
						num23 = -1527549993;
					}
					num = num22 ^ (int)(num2 * 1835571880);
					continue;
				}
				case 104u:
					stack.Push(new JSONClass());
					num = 871327379;
					continue;
				case 103u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = 1101112975;
						num16 = 1101112975;
					}
					else
					{
						num15 = 279368775;
						num16 = 279368775;
					}
					num = num15 ^ ((int)num2 * -2142727133);
					continue;
				}
				case 102u:
					stack.Push(new JSONArray());
					num = 1473203465;
					continue;
				case 101u:
					num = 197184187;
					continue;
				case 100u:
					flag5 = jSONNode is JSONArray;
					num = ((int)num2 * -615557496) ^ -377200897;
					continue;
				case 46u:
				case 56u:
				case 88u:
				case 91u:
				case 99u:
					goto IL_05ab;
				case 98u:
					num = 1711633644;
					continue;
				case 97u:
					num = (int)((num2 * 289502608) ^ 0xDA35C27);
					continue;
				case 96u:
					flag6 = flag4;
					num = 874122544;
					continue;
				case 95u:
					num = ((int)num2 * -131959846) ^ 0x44A6EC68;
					continue;
				case 94u:
				{
					char c5 = c3;
					c2 = c5;
					int num59;
					int num60;
					if ((uint)c2 > 102u)
					{
						num59 = -705678111;
						num60 = -705678111;
					}
					else
					{
						num59 = -1678319583;
						num60 = -1678319583;
					}
					num = num59 ^ (int)(num2 * 1044728692);
					continue;
				}
				case 93u:
					num = ((int)num2 * -978718698) ^ -1525932899;
					continue;
				case 92u:
					c4 = JSONNode.smethod_2(aJSON, num10);
					num = ((int)num2 * -152174115) ^ 0x1D8E0174;
					continue;
				case 90u:
					goto IL_0659;
				case 89u:
					flag = flag4;
					num = ((int)num2 * -985233652) ^ -1739500617;
					continue;
				case 87u:
				{
					int num58;
					if (c == '}')
					{
						num = 1919408971;
						num58 = 1919408971;
					}
					else
					{
						num = 1597225391;
						num58 = 1597225391;
					}
					continue;
				}
				case 86u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -884604347) ^ 0x5BC91152;
					continue;
				case 85u:
				{
					int num56;
					int num57;
					if (flag8)
					{
						num56 = 1106017243;
						num57 = 1106017243;
					}
					else
					{
						num56 = 1754443203;
						num57 = 1754443203;
					}
					num = num56 ^ (int)(num2 * 1209728914);
					continue;
				}
				case 84u:
					num = (int)(num2 * 226319281) ^ -1818755659;
					continue;
				case 83u:
					goto IL_06fd;
				case 82u:
					num = ((int)num2 * -1652662042) ^ -663557198;
					continue;
				case 80u:
				{
					text = "";
					text2 = "";
					int num55;
					if (stack.Count > 0)
					{
						num = 513586265;
						num55 = 513586265;
					}
					else
					{
						num = 665817568;
						num55 = 665817568;
					}
					continue;
				}
				case 79u:
				{
					int num53;
					int num54;
					if (flag13)
					{
						num53 = -1380311697;
						num54 = -1380311697;
					}
					else
					{
						num53 = -30561900;
						num54 = -30561900;
					}
					num = num53 ^ ((int)num2 * -417038152);
					continue;
				}
				case 77u:
					text2 = "";
					num = (int)((num2 * 567079314) ^ 0x4401DF04);
					continue;
				case 76u:
					text2 = "";
					text = "";
					num = (int)((num2 * 1541550152) ^ 0x27BF86F0);
					continue;
				case 75u:
					num = ((int)num2 * -1811946996) ^ 0x20DABF8C;
					continue;
				case 74u:
					num = ((int)num2 * -1707812877) ^ -2103805045;
					continue;
				case 73u:
				{
					int num51;
					int num52;
					if (!(jSONNode is JSONArray))
					{
						num51 = 76976095;
						num52 = 76976095;
					}
					else
					{
						num51 = 2056712829;
						num52 = 2056712829;
					}
					num = num51 ^ (int)(num2 * 492294277);
					continue;
				}
				case 72u:
					goto IL_081d;
				case 71u:
				{
					int num50;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1294647542;
						num50 = 1294647542;
					}
					else
					{
						num = 186888199;
						num50 = 186888199;
					}
					continue;
				}
				case 69u:
					goto IL_0854;
				case 68u:
					num = (int)(num2 * 1618529289) ^ -289851108;
					continue;
				case 67u:
					s = JSONNode.smethod_8(aJSON, num10 + 1, 4);
					num = ((int)num2 * -1012285996) ^ -226870271;
					continue;
				case 66u:
					num = (int)((num2 * 2085967719) ^ 0x3EF8FBB);
					continue;
				case 65u:
					num = ((int)num2 * -271962236) ^ -409523367;
					continue;
				case 64u:
				{
					int num47;
					if (c != ' ')
					{
						num = 1484513064;
						num47 = 1484513064;
					}
					else
					{
						num = 523611276;
						num47 = 523611276;
					}
					continue;
				}
				case 63u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1278130903) ^ -1020083473;
					continue;
				case 62u:
					num = (int)((num2 * 1191362977) ^ 0x78237CF3);
					continue;
				case 61u:
				{
					int num43;
					int num44;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num43 = 1223950376;
						num44 = 1223950376;
					}
					else
					{
						num43 = 226079132;
						num44 = 226079132;
					}
					num = num43 ^ ((int)num2 * -541501569);
					continue;
				}
				case 60u:
					num = (int)(num2 * 1177420891) ^ -787280535;
					continue;
				case 59u:
				{
					c = c4;
					int num40;
					int num41;
					if ((uint)c <= 44u)
					{
						num40 = -152482456;
						num41 = -152482456;
					}
					else
					{
						num40 = -516410663;
						num41 = -516410663;
					}
					num = num40 ^ (int)(num2 * 1399301348);
					continue;
				}
				case 58u:
					num = (int)((num2 * 321394003) ^ 0x31970BE2);
					continue;
				case 57u:
					num = (int)(num2 * 1980623646) ^ -227451115;
					continue;
				case 55u:
					stack.Pop();
					num = 410528510;
					continue;
				case 54u:
					num = (int)((num2 * 45307891) ^ 0x407203FB);
					continue;
				case 52u:
					num = (int)(num2 * 2106809468) ^ -677117018;
					continue;
				case 51u:
					stack = new Stack<JSONNode>();
					num = (int)(num2 * 264876833) ^ -251813341;
					continue;
				case 50u:
					goto IL_09fb;
				case 49u:
					switch (c)
					{
					case '\t':
						break;
					case '\n':
					case '\r':
						goto IL_05ab;
					case '\v':
					case '\f':
						goto IL_06fd;
					default:
						goto IL_0a23;
					}
					goto case 151u;
				case 48u:
					num = (int)((num2 * 324473843) ^ 0x478A1584);
					continue;
				case 47u:
					num = (int)(num2 * 1886446578) ^ -1948738037;
					continue;
				case 45u:
					text = "";
					num = 1873977981;
					continue;
				case 44u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 1374361822;
					continue;
				case 43u:
					jSONNode = null;
					num10 = 0;
					num = (int)((num2 * 1132044576) ^ 0x1DBD91E7);
					continue;
				case 42u:
				{
					int num37;
					int num38;
					if (c2 != 'b')
					{
						num37 = 1443120828;
						num38 = 1443120828;
					}
					else
					{
						num37 = 203060115;
						num38 = 203060115;
					}
					num = num37 ^ ((int)num2 * -211545019);
					continue;
				}
				case 41u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 974154644) ^ -1998358159;
					continue;
				case 40u:
				{
					int num34;
					int num35;
					if (flag3)
					{
						num34 = -1580996371;
						num35 = -1580996371;
					}
					else
					{
						num34 = -2041104850;
						num35 = -2041104850;
					}
					num = num34 ^ ((int)num2 * -1832992925);
					continue;
				}
				case 39u:
					switch (c)
					{
					case '\\':
						break;
					case '[':
						goto IL_0659;
					case ']':
						goto IL_081d;
					default:
						goto IL_0b2e;
					}
					goto case 135u;
				case 38u:
					num = ((int)num2 * -308817729) ^ -1142129270;
					continue;
				case 37u:
					num = (int)((num2 * 1183394890) ^ 0x3D46AD17);
					continue;
				case 36u:
					text2 = "";
					num = ((int)num2 * -1821279552) ^ -160625732;
					continue;
				case 35u:
				{
					int num29;
					int num30;
					if (jSONNode != null)
					{
						num29 = -1941516063;
						num30 = -1941516063;
					}
					else
					{
						num29 = -716400493;
						num30 = -716400493;
					}
					num = num29 ^ (int)(num2 * 875257333);
					continue;
				}
				case 34u:
				{
					int num28;
					if (c2 != 'n')
					{
						num = 1087578899;
						num28 = 1087578899;
					}
					else
					{
						num = 1699892250;
						num28 = 1699892250;
					}
					continue;
				}
				case 33u:
				{
					int num26;
					int num27;
					if (!flag9)
					{
						num26 = 1350608210;
						num27 = 1350608210;
					}
					else
					{
						num26 = 1962257803;
						num27 = 1962257803;
					}
					num = num26 ^ (int)(num2 * 1516710098);
					continue;
				}
				case 32u:
					num = (int)((num2 * 674471250) ^ 0x4621C992);
					continue;
				case 31u:
				{
					int num24;
					int num25;
					if ((uint)c <= 32u)
					{
						num24 = -1181023433;
						num25 = -1181023433;
					}
					else
					{
						num24 = -194597519;
						num25 = -194597519;
					}
					num = num24 ^ (int)(num2 * 323340555);
					continue;
				}
				case 30u:
				{
					int num21;
					if ((uint)c <= 93u)
					{
						num = 1461590538;
						num21 = 1461590538;
					}
					else
					{
						num = 904631536;
						num21 = 904631536;
					}
					continue;
				}
				case 29u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)((num2 * 710798018) ^ 0x6B11CD7C);
					continue;
				case 28u:
					num = ((int)num2 * -2046846687) ^ 0x1C0EAAE8;
					continue;
				case 27u:
				{
					int num17;
					int num18;
					if (!flag6)
					{
						num17 = -1690696601;
						num18 = -1690696601;
					}
					else
					{
						num17 = -308019782;
						num18 = -308019782;
					}
					num = num17 ^ ((int)num2 * -1606388396);
					continue;
				}
				case 26u:
					flag4 = !flag4;
					num = 1143009381;
					continue;
				case 25u:
					num = ((int)num2 * -2093981636) ^ -1139234663;
					continue;
				case 24u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 912259808) ^ -2047669822;
					continue;
				case 23u:
					goto IL_0d04;
				case 22u:
					result = jSONNode;
					num = 1598230138;
					continue;
				case 21u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 1168256473) ^ -1880871785;
					continue;
				case 20u:
				{
					int num13;
					int num14;
					if (!flag11)
					{
						num13 = -1594433299;
						num14 = -1594433299;
					}
					else
					{
						num13 = -646100118;
						num14 = -646100118;
					}
					num = num13 ^ (int)(num2 * 328357350);
					continue;
				}
				case 19u:
				{
					int num11;
					int num12;
					if (flag10)
					{
						num11 = -96645368;
						num12 = -96645368;
					}
					else
					{
						num11 = -1166485350;
						num12 = -1166485350;
					}
					num = num11 ^ (int)(num2 * 1741965247);
					continue;
				}
				case 18u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1895645238) ^ -1442846659;
					continue;
				case 17u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 1374361822;
					continue;
				case 16u:
					num = ((int)num2 * -404058624) ^ 0x5585F1C;
					continue;
				case 15u:
					num = (int)(num2 * 1823494243) ^ -1829853322;
					continue;
				case 14u:
					c3 = JSONNode.smethod_2(aJSON, num10);
					num = (int)(num2 * 303039705) ^ -1683321877;
					continue;
				case 13u:
					num = 728365931;
					continue;
				case 12u:
					flag9 = flag4;
					num = 1064642402;
					continue;
				case 11u:
					num = (int)((num2 * 17003340) ^ 0x64092B81);
					continue;
				case 10u:
					flag8 = JSONNode.smethod_6(text, "");
					num = 609768510;
					continue;
				case 9u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1783886548) ^ -1112774608;
					continue;
				case 8u:
					num = (int)((num2 * 557547094) ^ 0x660F7F30);
					continue;
				case 7u:
					num = (int)((num2 * 29149900) ^ 0x2D0D9863);
					continue;
				case 6u:
					text = JSONNode.smethod_5(text);
					flag7 = jSONNode is JSONArray;
					num = ((int)num2 * -327736426) ^ -116999128;
					continue;
				case 5u:
					switch (c2)
					{
					case 't':
						break;
					case 'r':
						goto IL_0854;
					case 'u':
						goto IL_09fb;
					case 's':
						goto IL_0d04;
					default:
						goto IL_0ed9;
					}
					goto case 107u;
				case 4u:
				{
					int num8;
					int num9;
					if (!flag5)
					{
						num8 = 48209486;
						num9 = 48209486;
					}
					else
					{
						num8 = 957674145;
						num9 = 957674145;
					}
					num = num8 ^ (int)(num2 * 1661830512);
					continue;
				}
				case 3u:
					flag4 = false;
					num = ((int)num2 * -1047351589) ^ -70320094;
					continue;
				case 2u:
					num = ((int)num2 * -1639789029) ^ 0x1277F063;
					continue;
				case 1u:
					flag3 = JSONNode.smethod_6(text, "");
					num = 1038559747;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 422450493;
						num4 = 422450493;
					}
					else
					{
						num3 = 210967809;
						num4 = 210967809;
					}
					num = num3 ^ (int)(num2 * 1430808450);
					continue;
				}
				case 53u:
					break;
				case 78u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 81u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0ed9:
					num = 294847833;
					continue;
					IL_05ab:
					num10++;
					num = 1593124690;
					continue;
					IL_0d04:
					text2 = JSONNode.smethod_3(text2, c3.ToString());
					num = 1374361822;
					continue;
					IL_0b2e:
					num = 1694708653;
					continue;
					IL_0a23:
					num = (int)(num2 * 1303157102) ^ -90284660;
					continue;
					IL_09fb:
					num = 273609952;
					continue;
					IL_0854:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 1374361822;
					continue;
					IL_081d:
					flag13 = flag4;
					num = 1051974740;
					continue;
					IL_06fd:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = 1323375026;
					continue;
					IL_0659:
					flag11 = flag4;
					num = 277410711;
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
			int num = 379502891;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A23E622u) % 4u)
				{
				case 3u:
					Serialize(aWriter);
					num = (int)(num2 * 13929406) ^ -2030130162;
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -1122581703) ^ -335532996;
					continue;
				default:
					return;
				case 0u:
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
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_006e:
					int num = 743642722;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x7F714993u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -1330388422) ^ -1513814943;
							continue;
						case 0u:
							num = (int)((num2 * 328725345) ^ 0x519DBD38);
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
				int num = -574387485;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8F8BA48u) % 4u)
					{
					case 3u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -82113136) ^ 0x7C38D9A6;
						continue;
					case 2u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 627337133) ^ 0x866AD33);
						continue;
					case 0u:
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
					int num3 = -2026673919;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xF8F8BA48u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -2032614057) ^ 0x2213013F;
							continue;
						case 0u:
							num3 = (int)((num2 * 695706875) ^ 0x2816BCBF);
							continue;
						default:
							goto end_IL_0098;
						case 2u:
							break;
						case 3u:
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		string aKey = default(string);
		JSONClass jSONClass = default(JSONClass);
		JSONArray jSONArray = default(JSONArray);
		int num5 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num6 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		while (true)
		{
			int num = 391013773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B35355Au) % 42u)
				{
				case 41u:
					num = (int)(num2 * 1495280954) ^ -1212804565;
					continue;
				case 40u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 1400079991;
						num9 = 1400079991;
					}
					else
					{
						num8 = 396899406;
						num9 = 396899406;
					}
					num = num8 ^ (int)(num2 * 1852054615);
					continue;
				}
				case 39u:
					num = 779980194;
					continue;
				case 38u:
					goto IL_0052;
				case 37u:
					num = ((int)num2 * -653711250) ^ -786251689;
					continue;
				case 36u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 1409454097) ^ 0x66B1AEA5);
					continue;
				case 35u:
					num = (int)((num2 * 1338361236) ^ 0x579840C);
					continue;
				case 33u:
					aKey = JSONNode.smethod_22(aReader);
					num = 1060759938;
					continue;
				case 32u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1138124778) ^ -1069216;
					continue;
				}
				case 31u:
					result = jSONArray;
					num = ((int)num2 * -717601903) ^ 0x299C0EC7;
					continue;
				case 30u:
					num5 = 0;
					num = ((int)num2 * -351142023) ^ -1812175141;
					continue;
				case 29u:
					num = ((int)num2 * -948656330) ^ -881015301;
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 641430778) ^ 0x22399821);
					continue;
				case 27u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = ((int)num2 * -1308169320) ^ -1784556878;
					continue;
				case 26u:
					result = jSONClass;
					num = ((int)num2 * -1032290832) ^ -1091084851;
					continue;
				case 25u:
				{
					int num7;
					if (num5 >= num6)
					{
						num = 565076221;
						num7 = 565076221;
					}
					else
					{
						num = 1032324317;
						num7 = 1032324317;
					}
					continue;
				}
				case 24u:
					goto IL_0189;
				case 23u:
					num = ((int)num2 * -1878952917) ^ 0x5CD8619C;
					continue;
				case 22u:
					goto IL_01a6;
				case 21u:
					num6 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = ((int)num2 * -173996214) ^ -491094704;
					continue;
				case 20u:
					goto IL_01d1;
				case 19u:
					num = ((int)num2 * -1141529802) ^ 0x77CDAAB5;
					continue;
				case 18u:
					num = (int)(num2 * 1645157824) ^ -2009070847;
					continue;
				case 17u:
					flag = num4 < num3;
					num = 682704786;
					continue;
				case 16u:
					num = ((int)num2 * -302386167) ^ 0x367BC00E;
					continue;
				case 15u:
					num = (int)(num2 * 406610345) ^ -299600108;
					continue;
				case 14u:
					goto IL_0239;
				case 12u:
					num5++;
					num = ((int)num2 * -1641755492) ^ -864868163;
					continue;
				case 11u:
					goto IL_025c;
				case 10u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -52307469) ^ 0x1A9620BE;
					continue;
				case 9u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1234515422) ^ 0x29E22689;
					continue;
				case 8u:
					num = ((int)num2 * -1150603502) ^ 0x1FE148E3;
					continue;
				case 7u:
					num4++;
					num = (int)(num2 * 1662445362) ^ -34886387;
					continue;
				case 6u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -125027697) ^ -162916071;
					continue;
				case 4u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Class:
						goto IL_0052;
					case JSONBinaryTag.IntValue:
						goto IL_0189;
					case JSONBinaryTag.Value:
						goto IL_01a6;
					case JSONBinaryTag.BoolValue:
						goto IL_01d1;
					case JSONBinaryTag.FloatValue:
						goto IL_0239;
					case JSONBinaryTag.Array:
						goto IL_025c;
					default:
						goto IL_030b;
					}
					goto case 39u;
				case 3u:
					num = (int)((num2 * 1464860260) ^ 0x1B240E9D);
					continue;
				case 2u:
					num3 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num4 = 0;
					num = (int)((num2 * 1144051590) ^ 0x428765CF);
					continue;
				case 1u:
					jSONArray.Add(Deserialize(aReader));
					num = 1103726047;
					continue;
				case 0u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)(num2 * 605963382) ^ -1322711587;
					continue;
				case 13u:
					break;
				case 34u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_030b:
					num = (int)(num2 * 1147288233) ^ -1603274014;
					continue;
					IL_025c:
					num = 496841959;
					continue;
					IL_0239:
					num = 1890714792;
					continue;
					IL_01d1:
					num = 1920958910;
					continue;
					IL_01a6:
					num = 889256650;
					continue;
					IL_0189:
					num = 1297249103;
					continue;
					IL_0052:
					num = 1040420994;
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
				int num = 46865810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FBC711Cu) % 3u)
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
					num = (int)(num2 * 865487271) ^ -292961484;
				}
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				while (true)
				{
					IL_0079:
					int num3 = 189133750;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x7FBC711Cu) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = (int)((num2 * 2031389686) ^ 0x2A56C562);
						continue;
						end_IL_005c:
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
				int num = -1615413555;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8CFFE7E3u) % 3u)
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
					result = LoadFromStream(fileStream);
					num = (int)((num2 * 1067183622) ^ 0x5913BEA2);
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
					int num3 = -943037382;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x8CFFE7E3u) % 4u)
						{
						case 3u:
							num3 = (int)(num2 * 462506880) ^ -268489997;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -295821236) ^ -1352887376;
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
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1087026151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF9601C2u) % 6u)
				{
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -895115316) ^ 0xE99D532;
					continue;
				case 4u:
					num = ((int)num2 * -1819412752) ^ -1783889172;
					continue;
				case 2u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 2137122500) ^ -840857901;
					continue;
				case 1u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -2066271207) ^ 0x2352B80;
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
