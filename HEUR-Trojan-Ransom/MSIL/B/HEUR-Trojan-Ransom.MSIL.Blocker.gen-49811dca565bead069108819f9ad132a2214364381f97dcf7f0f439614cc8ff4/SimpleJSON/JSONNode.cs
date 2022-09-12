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
				int num = -2038268516;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99AB4294u) % 3u)
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
					num = (int)(num2 * 379467971) ^ -937005258;
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
				int num = 636284001;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x548D3C1Bu) % 4u)
					{
					case 2u:
						result = null;
						num = (int)(num2 * 2013230317) ^ -359438292;
						continue;
					case 1u:
						num = (int)(num2 * 1414843963) ^ -284434840;
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
			string result = default(string);
			while (true)
			{
				int num = 260300699;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A1C3A4Au) % 3u)
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
					num = (int)((num2 * 1066979897) ^ 0x1A880A2);
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
				int num = -1816006621;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFFF8BA5Du) % 4u)
					{
					case 2u:
						result = 0;
						num = ((int)num2 * -90749456) ^ 0x6D684008;
						continue;
					case 1u:
						num = ((int)num2 * -1342605896) ^ -800078870;
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
				int num = 278589826;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6134E267u) % 4u)
					{
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 239934247) ^ -70760803;
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1145919018) ^ 0x73277D3;
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
			int result = default(int);
			bool flag = default(bool);
			int result2 = default(int);
			while (true)
			{
				int num = 396491718;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3DCFAC3u) % 6u)
					{
					case 5u:
						result = 0;
						num = 721156565;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1319472088;
							num4 = 1319472088;
						}
						else
						{
							num3 = 278460115;
							num4 = 278460115;
						}
						num = num3 ^ (int)(num2 * 206393142);
						continue;
					}
					case 2u:
						result = result2;
						num = ((int)num2 * -137278238) ^ 0x6CBF3321;
						continue;
					case 1u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = (int)(num2 * 529755658) ^ -862699218;
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
			Value = value.ToString();
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
				int num = 1265815869;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4BE8E299u) % 9u)
					{
					case 8u:
						num = (int)((num2 * 1315625430) ^ 0x736FAEC2);
						continue;
					case 7u:
						result = 0f;
						num = 362533112;
						continue;
					case 6u:
						result2 = 0f;
						num = (int)(num2 * 1077610403) ^ -709711792;
						continue;
					case 4u:
						result = result2;
						num = (int)(num2 * 1058268670) ^ -538593264;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -212010922;
							num4 = -212010922;
						}
						else
						{
							num3 = -1868181202;
							num4 = -1868181202;
						}
						num = num3 ^ (int)(num2 * 479700153);
						continue;
					}
					case 1u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -230607771) ^ -1577276796;
						continue;
					case 0u:
						num = ((int)num2 * -382911482) ^ 0x85E4E26;
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
			while (true)
			{
				int num = 2003869827;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x58AA13CCu) % 3u)
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
					num = ((int)num2 * -2072134633) ^ 0x7EE8EDC7;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = default(double);
			double result2 = default(double);
			while (true)
			{
				int num = -1883727965;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB86627Eu) % 7u)
					{
					case 4u:
						result = 0.0;
						num = -603172016;
						continue;
					case 3u:
					{
						result2 = 0.0;
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = 1987925087;
							num4 = 1987925087;
						}
						else
						{
							num3 = 93174603;
							num4 = 93174603;
						}
						num = num3 ^ ((int)num2 * -1621287007);
						continue;
					}
					case 2u:
						num = ((int)num2 * -1127190713) ^ -2094942418;
						continue;
					case 1u:
						result = result2;
						num = (int)((num2 * 803251297) ^ 0x633A3089);
						continue;
					case 0u:
						num = ((int)num2 * -1361727170) ^ 0x14EEE73;
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

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool flag = bool.TryParse(Value, out result);
			bool result2 = default(bool);
			while (true)
			{
				int num = -1500438980;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF34222CCu) % 6u)
					{
					case 4u:
						result2 = !JSONNode.smethod_1(Value);
						num = -1778945407;
						continue;
					case 3u:
						result2 = result;
						num = (int)(num2 * 2001408069) ^ -300627922;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -830970461;
							num4 = -830970461;
						}
						else
						{
							num3 = -2123336390;
							num4 = -2123336390;
						}
						num = num3 ^ (int)(num2 * 1483214168);
						continue;
					}
					case 1u:
						num = (int)((num2 * 910786904) ^ 0x7D13299);
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
				int num = -1147807507;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC8BB9696u) % 4u)
					{
					case 3u:
						Value = (value ? "true" : "false");
						num = -1517632760;
						continue;
					case 2u:
						num = (int)((num2 * 13121829) ^ 0x42E76D09);
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
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = this as JSONArray;
			while (true)
			{
				int num = -556816487;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9E19B29Bu) % 3u)
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
					num = ((int)num2 * -1804171220) ^ 0xB9A5120;
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
				int num = -246845751;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA708EE72u) % 3u)
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
					result = this as JSONClass;
					num = ((int)num2 * -1586228955) ^ 0x1FA39496;
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
			int num = -1104547305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAD740AAu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1843068982) ^ 0x7980CF5A);
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -281577342) ^ 0x40FA5E3;
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
		return null;
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 692786234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24C69B5Bu) % 3u)
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
				result = aNode;
				num = ((int)num2 * -37661042) ^ 0x766695A0;
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -1628215837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7EB675Du) % 3u)
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
				num = ((int)num2 * -1230151809) ^ -451138720;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -1128933627;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6C1969Eu) % 3u)
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
				num = ((int)num2 * -638160849) ^ 0x33CDC2E1;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -940681438;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC343153u) % 3u)
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
				result = new JSONData(s);
				num = (int)((num2 * 420974701) ^ 0x5669855);
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -1527507049;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xBB2A73E4u) % 4u)
				{
				case 3u:
					if (!(d == null))
					{
						num = (int)((num2 * 113761311) ^ 0x390F7090);
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
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
					num = -1452298050;
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
		int num = -424959707;
		goto IL_0056;
		IL_0056:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBF11A86Du) % 7u)
			{
			case 6u:
				break;
			case 5u:
				result = (object)a == b;
				num = -2026350718;
				continue;
			case 4u:
				num = ((int)num2 * -1334597208) ^ 0x4F2A18DC;
				continue;
			case 3u:
				result = true;
				num = (int)((num2 * 1467100006) ^ 0x5E851436);
				continue;
			case 1u:
				num = (int)((num2 * 197533047) ^ 0x7B055FB3);
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
				num = -966880622;
				num3 = -966880622;
				continue;
			}
			goto IL_0009;
		}
		goto IL_0016;
		IL_0009:
		num = -2045269740;
		num3 = -2045269740;
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
		int result = this.method_0();
		while (true)
		{
			int num = 1398145981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C75CF04u) % 3u)
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
				num = (int)((num2 * 1251426647) ^ 0x5B4B0EDA);
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = "";
		string string_ = default(string);
		int num4 = default(int);
		char c2 = default(char);
		char c = default(char);
		string result = default(string);
		while (true)
		{
			int num = 565250654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1ADD2E48u) % 31u)
				{
				case 30u:
					num = (int)(num2 * 1075519527) ^ -1867856148;
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1259658302;
					continue;
				case 27u:
					num = (int)(num2 * 391980431) ^ -152226128;
					continue;
				case 26u:
					num = 461796984;
					continue;
				case 25u:
					num = (int)((num2 * 1681296414) ^ 0x683C3663);
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1937435864;
					continue;
				case 23u:
					num = ((int)num2 * -1706177374) ^ 0x25682677;
					continue;
				case 22u:
					string_ = aText;
					num4 = 0;
					num = (int)(num2 * 451358149) ^ -634389945;
					continue;
				case 21u:
					num = ((int)num2 * -23048415) ^ -764596041;
					continue;
				case 20u:
					num4++;
					num = (int)(num2 * 1465930256) ^ -1555821006;
					continue;
				case 19u:
				{
					char c3 = c2;
					c = c3;
					num = (int)((num2 * 687675253) ^ 0x42F8152A);
					continue;
				}
				case 18u:
					goto IL_00e8;
				case 17u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 264746023;
					continue;
				case 16u:
				{
					int num6;
					if (c == '\\')
					{
						num = 468355125;
						num6 = 468355125;
					}
					else
					{
						num = 1700278277;
						num6 = 1700278277;
					}
					continue;
				}
				case 15u:
					switch (c)
					{
					case '\f':
						break;
					case '\t':
						goto IL_00e8;
					default:
						goto IL_0157;
					case '\b':
						goto IL_016a;
					case '\n':
						goto IL_0180;
					case '\v':
						goto IL_0196;
					case '\r':
						goto IL_01ae;
					}
					goto case 24u;
				case 8u:
					goto IL_016a;
				case 3u:
					goto IL_0180;
				case 5u:
					goto IL_0196;
				case 4u:
					goto IL_01ae;
				case 14u:
					result = text;
					num = ((int)num2 * -760761554) ^ 0x7B815B9;
					continue;
				case 13u:
					num = (int)((num2 * 983223639) ^ 0x49EC2C3);
					continue;
				case 12u:
					num = ((int)num2 * -278228993) ^ 0x616DC1A4;
					continue;
				case 11u:
					num = ((int)num2 * -489516385) ^ -2063237260;
					continue;
				case 10u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 1040366899;
					continue;
				case 9u:
				{
					int num5;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = 703041203;
						num5 = 703041203;
					}
					else
					{
						num = 963353037;
						num5 = 963353037;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -32394915) ^ -1351448081;
					continue;
				case 6u:
				{
					int num3;
					if (c == '"')
					{
						num = 376125152;
						num3 = 376125152;
					}
					else
					{
						num = 1412910525;
						num3 = 1412910525;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -1541895092) ^ -971719453;
					continue;
				case 1u:
					num = (int)(num2 * 1998436369) ^ -372482575;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_01ae:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1137986272;
					continue;
					IL_0196:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1284234784;
					continue;
					IL_0180:
					text = JSONNode.smethod_3(text, "\\n");
					num = 264746023;
					continue;
					IL_016a:
					text = JSONNode.smethod_3(text, "\\b");
					num = 694318325;
					continue;
					IL_0157:
					num = (int)(num2 * 1607372742) ^ -1934400502;
					continue;
					IL_00e8:
					text = JSONNode.smethod_3(text, "\\t");
					num = 264746023;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		char c = default(char);
		JSONNode jSONNode = default(JSONNode);
		bool flag2 = default(bool);
		int num24 = default(int);
		string text2 = default(string);
		bool flag10 = default(bool);
		char c2 = default(char);
		string text = default(string);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		char c4 = default(char);
		bool flag12 = default(bool);
		bool flag8 = default(bool);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		char c3 = default(char);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		bool flag = default(bool);
		bool flag11 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1223048387;
			while (true)
			{
				uint num2;
				int num39;
				switch ((num2 = (uint)num ^ 0xC6A487E8u) % 152u)
				{
				case 151u:
					num = ((int)num2 * -1186553861) ^ -1061720576;
					continue;
				case 150u:
				{
					int num14;
					if (c == '{')
					{
						num = -206267719;
						num14 = -206267719;
					}
					else
					{
						num = -1111123147;
						num14 = -1111123147;
					}
					continue;
				}
				case 149u:
					num = -796310683;
					continue;
				case 148u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -950674351) ^ -881701340;
					continue;
				case 147u:
					num = (int)(num2 * 1279860119) ^ -564958945;
					continue;
				case 146u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 523405436;
						num6 = 523405436;
					}
					else
					{
						num5 = 1442174841;
						num6 = 1442174841;
					}
					num = num5 ^ ((int)num2 * -111939043);
					continue;
				}
				case 83u:
				case 84u:
				case 92u:
				case 114u:
				case 145u:
					num24++;
					num = -700525098;
					continue;
				case 144u:
				{
					int num29;
					int num30;
					if (jSONNode is JSONArray)
					{
						num29 = 1742406066;
						num30 = 1742406066;
					}
					else
					{
						num29 = 602751129;
						num30 = 602751129;
					}
					num = num29 ^ ((int)num2 * -638997772);
					continue;
				}
				case 143u:
					text2 = "";
					num = -1581566346;
					continue;
				case 142u:
				{
					int num50;
					int num51;
					if (flag10)
					{
						num50 = 563946159;
						num51 = 563946159;
					}
					else
					{
						num50 = 1280157288;
						num51 = 1280157288;
					}
					num = num50 ^ (int)(num2 * 436014790);
					continue;
				}
				case 141u:
				{
					int num40;
					int num41;
					if ((uint)c2 > 102u)
					{
						num40 = -1156130968;
						num41 = -1156130968;
					}
					else
					{
						num40 = -682103920;
						num41 = -682103920;
					}
					num = num40 ^ ((int)num2 * -89617826);
					continue;
				}
				case 140u:
					text2 = "";
					text = "";
					num = -1500566598;
					continue;
				case 139u:
					goto IL_015f;
				case 138u:
					num = (int)((num2 * 886265410) ^ 0x282A9CF6);
					continue;
				case 137u:
				{
					int num32;
					int num33;
					if (!(jSONNode != null))
					{
						num32 = 14537532;
						num33 = 14537532;
					}
					else
					{
						num32 = 286130075;
						num33 = 286130075;
					}
					num = num32 ^ ((int)num2 * -1211192320);
					continue;
				}
				case 136u:
					num = ((int)num2 * -1345490311) ^ 0x100B840E;
					continue;
				case 135u:
					text = "";
					num = (int)((num2 * 1750524205) ^ 0x719F059F);
					continue;
				case 134u:
					num = -1734754500;
					continue;
				case 133u:
					num = ((int)num2 * -508007225) ^ -1154611716;
					continue;
				case 132u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = -862643382;
						num11 = -862643382;
					}
					else
					{
						num10 = -1984755056;
						num11 = -1984755056;
					}
					num = num10 ^ (int)(num2 * 477685257);
					continue;
				}
				case 131u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1873375029) ^ -422914289;
					continue;
				case 130u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1725430846;
					continue;
				case 129u:
					stack.Push(new JSONClass());
					num = -1088443759;
					continue;
				case 128u:
					num = ((int)num2 * -760353081) ^ -1741265711;
					continue;
				case 127u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = (int)((num2 * 402828380) ^ 0x304DBC99);
					continue;
				case 126u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -750563272) ^ -588157184;
					continue;
				case 125u:
					switch (c2)
					{
					case 'u':
						break;
					default:
						goto IL_02f5;
					case 'r':
						goto IL_02ff;
					case 's':
						goto IL_0315;
					case 't':
						goto IL_032d;
					}
					goto case 149u;
				case 6u:
					goto IL_02ff;
				case 47u:
					goto IL_0315;
				case 76u:
					goto IL_032d;
				case 124u:
					num = ((int)num2 * -345694093) ^ -604401755;
					continue;
				case 123u:
				{
					int num52;
					if (c != '}')
					{
						num = -1939497623;
						num52 = -1939497623;
					}
					else
					{
						num = -278782799;
						num52 = -278782799;
					}
					continue;
				}
				case 122u:
					num = (int)(num2 * 445833507) ^ -903339147;
					continue;
				case 121u:
				{
					int num45;
					if (flag7)
					{
						num = -1249055481;
						num45 = -1249055481;
					}
					else
					{
						num = -728645637;
						num45 = -728645637;
					}
					continue;
				}
				case 120u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = ((int)num2 * -1396854874) ^ 0x13C1A097;
					continue;
				case 119u:
					num = -640777137;
					continue;
				case 118u:
				{
					char c5 = c4;
					c2 = c5;
					num = ((int)num2 * -1635508710) ^ -1290582071;
					continue;
				}
				case 117u:
				{
					int num37;
					int num38;
					if (!flag12)
					{
						num37 = 2075742234;
						num38 = 2075742234;
					}
					else
					{
						num37 = 1930754051;
						num38 = 1930754051;
					}
					num = num37 ^ ((int)num2 * -1231773115);
					continue;
				}
				case 116u:
				{
					int num34;
					if (c == '"')
					{
						num = -674773287;
						num34 = -674773287;
					}
					else
					{
						num = -1380235520;
						num34 = -1380235520;
					}
					continue;
				}
				case 115u:
				{
					int num26;
					int num27;
					if (flag8)
					{
						num26 = -814203718;
						num27 = -814203718;
					}
					else
					{
						num26 = -1275491928;
						num27 = -1275491928;
					}
					num = num26 ^ (int)(num2 * 1699398659);
					continue;
				}
				case 113u:
					flag7 = false;
					num = (int)(num2 * 2052087496) ^ -1829104371;
					continue;
				case 112u:
					goto IL_0484;
				case 111u:
					num = ((int)num2 * -2023796658) ^ 0x22BDA573;
					continue;
				case 110u:
				{
					int num19;
					int num20;
					if (c2 == 'b')
					{
						num19 = 2008222118;
						num20 = 2008222118;
					}
					else
					{
						num19 = 641149977;
						num20 = 641149977;
					}
					num = num19 ^ (int)(num2 * 604132902);
					continue;
				}
				case 109u:
					num = ((int)num2 * -508847510) ^ -1052589927;
					continue;
				case 108u:
					num = ((int)num2 * -97907978) ^ -22353067;
					continue;
				case 107u:
					jSONNode.Add(text);
					num = (int)(num2 * 882183857) ^ -984146308;
					continue;
				case 106u:
					num = -1016778772;
					continue;
				case 105u:
				{
					int num15;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -2090678283;
						num15 = -2090678283;
					}
					else
					{
						num = -1227730497;
						num15 = -1227730497;
					}
					continue;
				}
				case 104u:
					text = "";
					num = (int)((num2 * 1312346567) ^ 0x1F12BBDC);
					continue;
				case 103u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 1695600319;
						num8 = 1695600319;
					}
					else
					{
						num7 = 616634264;
						num8 = 616634264;
					}
					num = num7 ^ (int)(num2 * 1756288568);
					continue;
				}
				case 101u:
					num = ((int)num2 * -451692122) ^ 0x4811BB98;
					continue;
				case 100u:
					num = (int)((num2 * 1700608836) ^ 0x4A84315F);
					continue;
				case 99u:
					num = (int)((num2 * 1351572269) ^ 0x1AEC8DD5);
					continue;
				case 98u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 2012593594) ^ -1296703749;
					continue;
				case 97u:
					num = (int)((num2 * 988563186) ^ 0x7DD67553);
					continue;
				case 96u:
					num = (int)((num2 * 1187680998) ^ 0xB15A7C2);
					continue;
				case 95u:
				{
					int num59;
					if (c2 == 'f')
					{
						num = -73610213;
						num59 = -73610213;
					}
					else
					{
						num = -1487721812;
						num59 = -1487721812;
					}
					continue;
				}
				case 94u:
					c4 = JSONNode.smethod_2(aJSON, num24);
					num = ((int)num2 * -1091956226) ^ 0x5362AB5A;
					continue;
				case 93u:
				{
					int num58;
					if ((uint)c <= 93u)
					{
						num = -2136443558;
						num58 = -2136443558;
					}
					else
					{
						num = -336559394;
						num58 = -336559394;
					}
					continue;
				}
				case 91u:
					num = (int)(num2 * 1242644848) ^ -730113736;
					continue;
				case 90u:
					jSONNode.Add(text);
					num = ((int)num2 * -2130584258) ^ 0x1EBB8EB7;
					continue;
				case 89u:
					flag7 = !flag7;
					num = -1956717559;
					continue;
				case 88u:
					num = (int)((num2 * 1686263242) ^ 0x4B5177FD);
					continue;
				case 87u:
				{
					int num56;
					int num57;
					if (!flag9)
					{
						num56 = -571218609;
						num57 = -571218609;
					}
					else
					{
						num56 = -118343698;
						num57 = -118343698;
					}
					num = num56 ^ (int)(num2 * 1823801298);
					continue;
				}
				case 86u:
					num = ((int)num2 * -898437959) ^ 0x50B8968B;
					continue;
				case 85u:
					num = -603341972;
					continue;
				case 82u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = ((int)num2 * -185510662) ^ 0x6DE392C5;
					continue;
				case 81u:
				{
					int num55;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1585647058;
						num55 = -1585647058;
					}
					else
					{
						num = -401883114;
						num55 = -401883114;
					}
					continue;
				}
				case 80u:
					num = (int)(num2 * 403763049) ^ -97601127;
					continue;
				case 79u:
					num = ((int)num2 * -2119945956) ^ 0x655F47C5;
					continue;
				case 78u:
					c3 = JSONNode.smethod_2(aJSON, num24);
					num = -1065657325;
					continue;
				case 77u:
					num = ((int)num2 * -863313229) ^ -1708220408;
					continue;
				case 75u:
				{
					int num53;
					int num54;
					if (!flag5)
					{
						num53 = -1165505766;
						num54 = -1165505766;
					}
					else
					{
						num53 = -1794728971;
						num54 = -1794728971;
					}
					num = num53 ^ ((int)num2 * -465496043);
					continue;
				}
				case 74u:
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -1291293040) ^ 0x1D2D539B;
					continue;
				case 73u:
					switch (c)
					{
					case '[':
						break;
					case '\\':
						goto IL_0484;
					default:
						goto IL_0804;
					case ']':
						goto IL_080e;
					}
					goto case 121u;
				case 25u:
					goto IL_080e;
				case 72u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -2027110427) ^ 0x34E9EBDB;
					continue;
				case 71u:
					flag6 = stack.Count == 0;
					num = -1608715051;
					continue;
				case 70u:
				{
					int num48;
					int num49;
					if (!flag7)
					{
						num48 = 1511947928;
						num49 = 1511947928;
					}
					else
					{
						num48 = 1016057460;
						num49 = 1016057460;
					}
					num = num48 ^ (int)(num2 * 1317246934);
					continue;
				}
				case 69u:
				{
					int num46;
					int num47;
					if ((uint)c > 32u)
					{
						num46 = -722379770;
						num47 = -722379770;
					}
					else
					{
						num46 = -593552366;
						num47 = -593552366;
					}
					num = num46 ^ ((int)num2 * -1538422222);
					continue;
				}
				case 68u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = (int)(num2 * 1449655756) ^ -1680349833;
					continue;
				case 67u:
					text = JSONNode.smethod_3(text, "\f");
					num = -382793401;
					continue;
				case 66u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -2024667578) ^ 0x66DF1F8D;
					continue;
				case 65u:
					num = ((int)num2 * -2003539175) ^ 0x5C332928;
					continue;
				case 64u:
					text2 = text;
					num = -1226385344;
					continue;
				case 63u:
				{
					int num43;
					int num44;
					if (jSONNode is JSONArray)
					{
						num43 = -1496446594;
						num44 = -1496446594;
					}
					else
					{
						num43 = -501251768;
						num44 = -501251768;
					}
					num = num43 ^ (int)(num2 * 1199397435);
					continue;
				}
				case 62u:
					text = "";
					flag = stack.Count > 0;
					num = ((int)num2 * -1523964687) ^ 0x38F9187E;
					continue;
				case 61u:
				{
					string s = JSONNode.smethod_8(aJSON, num24 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num24 += 4;
					num = (int)((num2 * 703904736) ^ 0x79B48BAC);
					continue;
				}
				case 60u:
					flag4 = flag7;
					num = (int)(num2 * 154175394) ^ -2142109148;
					continue;
				case 59u:
					stack.Push(new JSONArray());
					num = -1745766029;
					continue;
				case 57u:
					num = (int)(num2 * 1313189789) ^ -1955122570;
					continue;
				case 56u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 536982819) ^ 0x3DDBC480);
					continue;
				case 55u:
					text2 = JSONNode.smethod_5(text2);
					flag11 = jSONNode is JSONArray;
					num = (int)((num2 * 811678115) ^ 0x4C38D217);
					continue;
				case 54u:
					num = ((int)num2 * -643731166) ^ 0x68BA076E;
					continue;
				case 53u:
					jSONNode = null;
					num24 = 0;
					num = (int)((num2 * 1437476136) ^ 0x28BD3DAF);
					continue;
				case 52u:
					flag2 = JSONNode.smethod_6(text2, "");
					num = -872070470;
					continue;
				case 51u:
					num = ((int)num2 * -743720094) ^ 0x7F74F079;
					continue;
				case 50u:
				{
					int num42;
					if (flag7)
					{
						num = -1605350496;
						num42 = -1605350496;
					}
					else
					{
						num = -1623074189;
						num42 = -1623074189;
					}
					continue;
				}
				case 49u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = (int)((num2 * 684326563) ^ 0x52C99C6C);
					continue;
				case 48u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_015f;
					default:
						goto IL_0aec;
					case '\t':
						goto IL_0aff;
					}
					goto case 83u;
				case 31u:
					goto IL_0aff;
				case 46u:
					num = (int)((num2 * 323825440) ^ 0x2B80D4D6);
					continue;
				case 45u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -198300007) ^ -890906902;
					continue;
				case 44u:
					num = ((int)num2 * -1448016795) ^ -1220779119;
					continue;
				case 43u:
					flag12 = JSONNode.smethod_6(text, "");
					num = -334757187;
					continue;
				case 42u:
				{
					int num35;
					int num36;
					if (!flag11)
					{
						num35 = -1518850914;
						num36 = -1518850914;
					}
					else
					{
						num35 = -1484146786;
						num36 = -1484146786;
					}
					num = num35 ^ (int)(num2 * 1096654249);
					continue;
				}
				case 41u:
					num = (int)((num2 * 699930356) ^ 0x613BE277);
					continue;
				case 40u:
					num = ((int)num2 * -25029850) ^ 0x2039704E;
					continue;
				case 39u:
					num = (int)((num2 * 1383256124) ^ 0x5651F65);
					continue;
				case 38u:
					num = -581506573;
					continue;
				case 37u:
					num = (int)(num2 * 2146501485) ^ -357456496;
					continue;
				case 36u:
					text2 = "";
					num = (int)((num2 * 186694119) ^ 0x3EB974F5);
					continue;
				case 35u:
					c = c3;
					num = ((int)num2 * -1779956215) ^ 0xC2CE2A9;
					continue;
				case 34u:
					flag10 = jSONNode != null;
					num = (int)(num2 * 528307652) ^ -1232438250;
					continue;
				case 33u:
					flag9 = flag7;
					num = -1793017713;
					continue;
				case 32u:
				{
					int num31;
					if (!flag7)
					{
						num = -1953055928;
						num31 = -1953055928;
					}
					else
					{
						num = -113152748;
						num31 = -113152748;
					}
					continue;
				}
				case 30u:
					text = JSONNode.smethod_3(text, "\n");
					num = -1725430846;
					continue;
				case 29u:
				{
					int num28;
					if (c == ' ')
					{
						num = -2091717553;
						num28 = -2091717553;
					}
					else
					{
						num = -44450950;
						num28 = -44450950;
					}
					continue;
				}
				case 28u:
					text2 = "";
					text = "";
					num = -273483615;
					continue;
				case 27u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -259486244) ^ 0x7D89DAD3;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = (int)((num2 * 1910419164) ^ 0x1FA3113C);
					continue;
				case 24u:
					num = ((int)num2 * -84539829) ^ 0x59300B11;
					continue;
				case 23u:
					num = (int)(num2 * 225876585) ^ -1723820167;
					continue;
				case 21u:
				{
					int num25;
					if (num24 < JSONNode.smethod_4(aJSON))
					{
						num = -1533150402;
						num25 = -1533150402;
					}
					else
					{
						num = -751978348;
						num25 = -751978348;
					}
					continue;
				}
				case 20u:
					num = (int)((num2 * 261412026) ^ 0x31B6601B);
					continue;
				case 19u:
					num = (int)((num2 * 1282069256) ^ 0x65416F3F);
					continue;
				case 18u:
				{
					int num22;
					int num23;
					if (c == ':')
					{
						num22 = 840778060;
						num23 = 840778060;
					}
					else
					{
						num22 = 1214009694;
						num23 = 1214009694;
					}
					num = num22 ^ ((int)num2 * -1469000730);
					continue;
				}
				case 17u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -537118805) ^ -1898208990;
					continue;
				case 15u:
				{
					stack.Pop();
					int num21;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -1441114373;
						num21 = -1441114373;
					}
					else
					{
						num = -640777137;
						num21 = -640777137;
					}
					continue;
				}
				case 14u:
				{
					int num18;
					if (c2 != 'n')
					{
						num = -70449236;
						num18 = -70449236;
					}
					else
					{
						num = -966502466;
						num18 = -966502466;
					}
					continue;
				}
				case 13u:
				{
					int num16;
					int num17;
					if (!flag6)
					{
						num16 = 423770399;
						num17 = 423770399;
					}
					else
					{
						num16 = 728642126;
						num17 = 728642126;
					}
					num = num16 ^ ((int)num2 * -1691538704);
					continue;
				}
				case 12u:
					result = jSONNode;
					num = -327333813;
					continue;
				case 11u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -338403090) ^ -227097825;
					continue;
				case 10u:
				{
					int num12;
					int num13;
					if ((uint)c > 44u)
					{
						num12 = -1162375093;
						num13 = -1162375093;
					}
					else
					{
						num12 = -1042292133;
						num13 = -1042292133;
					}
					num = num12 ^ ((int)num2 * -516670609);
					continue;
				}
				case 9u:
					num = (int)(num2 * 1837636305) ^ -926349712;
					continue;
				case 8u:
					num = ((int)num2 * -1801247188) ^ -687238218;
					continue;
				case 7u:
					num = (int)((num2 * 1057092696) ^ 0x628EDBEA);
					continue;
				case 5u:
					flag5 = JSONNode.smethod_6(text2, "");
					num = -1820181805;
					continue;
				case 4u:
					num = (int)(num2 * 1523397009) ^ -1568256602;
					continue;
				case 3u:
					text2 = "";
					text = "";
					num = -399392039;
					continue;
				case 2u:
					num = ((int)num2 * -466118193) ^ -1200873201;
					continue;
				case 1u:
				{
					int num9;
					if (c != ',')
					{
						num = -2035745583;
						num9 = -2035745583;
					}
					else
					{
						num = -233727374;
						num9 = -233727374;
					}
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -100504912;
						num4 = -100504912;
					}
					else
					{
						num3 = -702634589;
						num4 = -702634589;
					}
					num = num3 ^ (int)(num2 * 12052436);
					continue;
				}
				case 16u:
					break;
				case 22u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 102u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0484:
					num24++;
					num = -88937914;
					continue;
					IL_0aff:
					if (flag7)
					{
						num = -391036894;
						num39 = -391036894;
					}
					else
					{
						num = -871502684;
						num39 = -871502684;
					}
					continue;
					IL_0aec:
					num = (int)((num2 * 455764087) ^ 0x3720EF14);
					continue;
					IL_015f:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num24).ToString());
					num = -2052898504;
					continue;
					IL_080e:
					flag3 = flag7;
					num = -1046810457;
					continue;
					IL_0804:
					num = -57179564;
					continue;
					IL_032d:
					text = JSONNode.smethod_3(text, "\t");
					num = -1788071906;
					continue;
					IL_0315:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = -1725430846;
					continue;
					IL_02ff:
					text = JSONNode.smethod_3(text, "\r");
					num = -586620494;
					continue;
					IL_02f5:
					num = -584845987;
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
			int num = 175929353;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C97F41u) % 3u)
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
				num = ((int)num2 * -350159447) ^ 0x562A4387;
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
			int num = 353788908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x600D7E6Fu) % 3u)
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
						while (true)
						{
							int num3 = 833885659;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x600D7E6Fu) % 3u)
								{
								case 1u:
									goto IL_005a;
								default:
									return;
								case 2u:
									break;
								case 0u:
									return;
								}
								break;
								IL_005a:
								num3 = ((int)num2 * -619016027) ^ -1283468368;
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
								int num4 = 1652327042;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0x600D7E6Fu) % 4u)
									{
									case 1u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num4 = ((int)num2 * -25588803) ^ 0x4917A1F6;
										continue;
									case 0u:
										num4 = ((int)num2 * -1394645483) ^ -690606335;
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
				num = ((int)num2 * -987652179) ^ -1053075130;
			}
		}
	}

	public string SaveToBase64()
	{
		MemoryStream memoryStream = JSONNode.smethod_16();
		try
		{
			string result = default(string);
			while (true)
			{
				int num = 1729465947;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x18FBEECCu) % 6u)
					{
					case 5u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -2100805391) ^ -680795466;
						continue;
					case 3u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -73862923) ^ 0x368AFF8E;
						continue;
					case 2u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 901141499) ^ -908582332;
						continue;
					case 1u:
						num = (int)(num2 * 564692481) ^ -152695641;
						continue;
					case 0u:
						break;
					default:
						return result;
					case 4u:
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
					IL_00cf:
					int num3 = 1237845562;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x18FBEECCu) % 3u)
						{
						case 1u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 0u:
							break;
						case 2u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = (int)(num2 * 926518624) ^ -843228855;
						continue;
						end_IL_00b2:
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
		int num3 = default(int);
		int num9 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num4 = default(int);
		int num5 = default(int);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = -1793327979;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80CEC24Fu) % 39u)
				{
				case 38u:
					num = -822291971;
					continue;
				case 37u:
					num = ((int)num2 * -661122827) ^ -1845381577;
					continue;
				case 36u:
					flag = num3 < num9;
					num = -720234678;
					continue;
				case 35u:
					goto IL_003b;
				case 34u:
					jSONArray = new JSONArray();
					num4 = 0;
					num = ((int)num2 * -536487870) ^ -1081092253;
					continue;
				case 33u:
					goto IL_0062;
				case 32u:
					num5 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 1475064316) ^ -1592698485;
					continue;
				case 31u:
					num9 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 1460082417) ^ 0x29C87C14);
					continue;
				case 30u:
					num = (int)(num2 * 903749292) ^ -297867937;
					continue;
				case 28u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1927181897;
						num8 = -1927181897;
					}
					else
					{
						num7 = -1046061706;
						num8 = -1046061706;
					}
					num = num7 ^ (int)(num2 * 244938424);
					continue;
				}
				case 27u:
					num = ((int)num2 * -440207966) ^ 0x4343BAF;
					continue;
				case 25u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)(num2 * 1814381709) ^ -1932346870;
					continue;
				case 24u:
					num = ((int)num2 * -169845734) ^ 0x2001F58B;
					continue;
				case 23u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1847150657) ^ -739208068;
					continue;
				case 22u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = (int)(num2 * 1460823323) ^ -1342764060;
					continue;
				case 21u:
					num3 = 0;
					num = ((int)num2 * -1253796096) ^ -1815232597;
					continue;
				case 20u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = (int)((num2 * 1029913872) ^ 0xC623EC7);
					continue;
				case 19u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = ((int)num2 * -126912250) ^ 0xB9A5FF1;
					continue;
				case 18u:
					goto IL_01b3;
				case 17u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.Array:
						goto IL_003b;
					case JSONBinaryTag.Value:
						goto IL_0062;
					case JSONBinaryTag.FloatValue:
						goto IL_01b3;
					default:
						goto IL_01ee;
					case JSONBinaryTag.IntValue:
						goto IL_0201;
					case JSONBinaryTag.DoubleValue:
						goto IL_0218;
					case JSONBinaryTag.BoolValue:
						goto IL_0222;
					}
					goto case 38u;
				case 8u:
					goto IL_0201;
				case 14u:
					goto IL_0218;
				case 10u:
					goto IL_0222;
				case 16u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 665246341) ^ 0x7DE9F98F);
					continue;
				case 15u:
					num = -1986355841;
					continue;
				case 13u:
					jSONArray.Add(Deserialize(aReader));
					num4++;
					num = -234460357;
					continue;
				case 12u:
					num = (int)((num2 * 1801842348) ^ 0x77B1826B);
					continue;
				case 11u:
				{
					int num6;
					if (num4 < num5)
					{
						num = -1536699602;
						num6 = -1536699602;
					}
					else
					{
						num = -800617192;
						num6 = -800617192;
					}
					continue;
				}
				case 9u:
					num = (int)(num2 * 1936565400) ^ -1936714361;
					continue;
				case 6u:
					num = (int)(num2 * 1768005731) ^ -569015529;
					continue;
				case 5u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1538428626) ^ -321759735;
					continue;
				case 4u:
					num = (int)(num2 * 759892490) ^ -578490851;
					continue;
				case 3u:
					num = (int)((num2 * 1545383447) ^ 0x78043903);
					continue;
				case 2u:
					result = jSONArray;
					num = ((int)num2 * -968372851) ^ 0x4BA93B6F;
					continue;
				case 1u:
					result = jSONClass;
					num = ((int)num2 * -981434176) ^ 0x3386DFA;
					continue;
				case 0u:
					num3++;
					num = ((int)num2 * -2052230129) ^ 0x71127CEF;
					continue;
				case 7u:
					break;
				case 26u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_003b:
					num = -1658376087;
					continue;
					IL_0222:
					num = -1980763366;
					continue;
					IL_0218:
					num = -1859156390;
					continue;
					IL_0201:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -222607545;
					continue;
					IL_01ee:
					num = ((int)num2 * -193986442) ^ -755314610;
					continue;
					IL_01b3:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1589254204;
					continue;
					IL_0062:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1198853873;
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
					int num = 1120758611;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x64297005u) % 3u)
						{
						case 1u:
							goto IL_0015;
						default:
							goto end_IL_0028;
						case 2u:
							break;
						case 0u:
							goto end_IL_0028;
						}
						goto IL_0045;
						IL_0015:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = ((int)num2 * -1185328102) ^ 0x5A168C3C;
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
				int num = 2087015867;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D19BF64u) % 3u)
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
					num = ((int)num2 * -216021059) ^ 0x62ED873A;
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
					int num3 = 35177914;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x6D19BF64u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1658093577) ^ -64570317;
							continue;
						case 1u:
							num3 = (int)(num2 * 1605907022) ^ -1722223742;
							continue;
						default:
							goto end_IL_006b;
						case 3u:
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
			int num = -1894314327;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF2E09B9u) % 7u)
				{
				case 6u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 528810565) ^ 0x4D5C4CC4);
					continue;
				case 5u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -2090749432) ^ 0x1871423;
					continue;
				case 4u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1158717038) ^ 0x60F1F484;
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1522945337) ^ -677905198;
					continue;
				case 1u:
					num = ((int)num2 * -2123976606) ^ 0x18382638;
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
