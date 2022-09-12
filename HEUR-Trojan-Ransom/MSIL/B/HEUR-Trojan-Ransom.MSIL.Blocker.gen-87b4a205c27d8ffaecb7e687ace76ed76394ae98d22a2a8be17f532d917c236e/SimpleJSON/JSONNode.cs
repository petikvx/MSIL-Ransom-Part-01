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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1081819531;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0D52C28u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1756331318) ^ 0x55322598);
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -1274064650) ^ 0x38AE0971;
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
				int num = -1693994270;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0A49F2Bu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -683975876) ^ -1481563075;
						continue;
					case 1u:
						result = "";
						num = ((int)num2 * -86226714) ^ 0x4F2F0EAE;
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
				int num = -1235231470;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB54B4A2Cu) % 3u)
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
					num = ((int)num2 * -828094746) ^ -2049373065;
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
				int num = -1323473730;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB400FFFBu) % 4u)
					{
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 1086274695) ^ 0x3010C2AE);
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 77067649) ^ 0x4667CA14);
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
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
			int result2 = default(int);
			while (true)
			{
				int num = 1431963638;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD4769B7u) % 6u)
					{
					case 5u:
						result2 = 0;
						num = 1410006535;
						continue;
					case 4u:
						num = (int)((num2 * 528863387) ^ 0x4F8F8F62);
						continue;
					case 2u:
						result2 = result;
						num = ((int)num2 * -99476497) ^ 0x567D2352;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!int.TryParse(Value, out result))
						{
							num3 = 1213520904;
							num4 = 1213520904;
						}
						else
						{
							num3 = 2119846243;
							num4 = 2119846243;
						}
						num = num3 ^ ((int)num2 * -701859404);
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
				int num = 1232561219;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EACC486u) % 3u)
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
					num = (int)((num2 * 2003515156) ^ 0x3D5DA5D7);
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
				int num = -1882688277;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE3EB70CFu) % 5u)
					{
					case 4u:
						result2 = result;
						num = (int)(num2 * 800634568) ^ -1589581937;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1833658518;
							num4 = -1833658518;
						}
						else
						{
							num3 = -1908446191;
							num4 = -1908446191;
						}
						num = num3 ^ ((int)num2 * -1947173353);
						continue;
					}
					case 1u:
						result2 = 0f;
						num = -129821921;
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
			Value = value.ToString();
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
				int num = -1400309411;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8FFB4412u) % 8u)
					{
					case 7u:
						result2 = 0.0;
						num = (int)((num2 * 1044493270) ^ 0x64630E7E);
						continue;
					case 6u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -1609685447) ^ 0x3456F69;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1595177780;
							num4 = -1595177780;
						}
						else
						{
							num3 = -1428949878;
							num4 = -1428949878;
						}
						num = num3 ^ ((int)num2 * -3172228);
						continue;
					}
					case 4u:
						result = 0.0;
						num = -225098967;
						continue;
					case 2u:
						result = result2;
						num = (int)(num2 * 279652920) ^ -1734335565;
						continue;
					case 1u:
						num = ((int)num2 * -2048088842) ^ 0x1ECFDAFF;
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
			bool result2 = default(bool);
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 1832275217;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1EF3FB8Cu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1809096784) ^ 0x6703DB24;
						continue;
					case 6u:
						num = ((int)num2 * -1998757491) ^ 0x1E951F9A;
						continue;
					case 5u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = (int)(num2 * 671976981) ^ -1367683826;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1839722751;
							num4 = 1839722751;
						}
						else
						{
							num3 = 535198596;
							num4 = 535198596;
						}
						num = num3 ^ (int)(num2 * 178590659);
						continue;
					}
					case 2u:
						result = result2;
						num = (int)(num2 * 107527070) ^ -1184232666;
						continue;
					case 1u:
						result = !JSONNode.smethod_1(Value);
						num = 675255371;
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
			while (true)
			{
				int num = 1143722214;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0xAABC3B8) % 3u)
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
					num = 1098733974;
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
				int num = -408466873;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE6979BDFu) % 3u)
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
					result = this as JSONArray;
					num = ((int)num2 * -1865011338) ^ -131538382;
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
				int num = -980372301;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6988707u) % 3u)
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
					num = ((int)num2 * -2093774933) ^ 0x58EAFB5A;
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
		JSONNode result = null;
		while (true)
		{
			int num = 1910670385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FE47BD9u) % 3u)
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
				num = ((int)num2 * -1160031515) ^ -1528188746;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1709053800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40219987u) % 3u)
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
				num = (int)((num2 * 1230455003) ^ 0x31D91355);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		return aNode;
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -1441136590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84BF5B46u) % 3u)
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
				num = ((int)num2 * -1070588416) ^ 0x2512AA17;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1129248830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A50B407u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -984362307) ^ 0x17AFC1DE;
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)(num2 * 1525096879) ^ -1874551394;
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
			int num = -1908384895;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF2606FC9u) % 3u)
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
				num = ((int)num2 * -2100854671) ^ -603119981;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -666211306;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xFDCA1689u) % 5u)
				{
				case 4u:
					obj = d.Value;
					goto IL_0009;
				case 2u:
					num = ((int)num2 * -1077273148) ^ -1633734687;
					continue;
				case 1u:
					if (!(d == null))
					{
						num = (int)(num2 * 154229427) ^ -1517427504;
						continue;
					}
					obj = null;
					goto IL_0009;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = -1880422289;
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
			goto IL_004a;
		}
		int num = 0;
		goto IL_0094;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
		IL_004a:
		int num2 = -1003178842;
		goto IL_005e;
		IL_005e:
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x81B70701u) % 7u)
			{
			case 6u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1324556669;
					num5 = 1324556669;
				}
				else
				{
					num4 = 958146551;
					num5 = 958146551;
				}
				num2 = num4 ^ ((int)num3 * -1001696421);
				continue;
			}
			case 5u:
				result = (object)a == b;
				num2 = -1002685419;
				continue;
			case 4u:
				result = true;
				num2 = (int)(num3 * 954895506) ^ -603292228;
				continue;
			case 2u:
				break;
			case 1u:
				num2 = (int)(num3 * 42551132) ^ -827779630;
				continue;
			case 3u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_004a;
		IL_0094:
		flag = (byte)num != 0;
		num2 = -645731822;
		goto IL_005e;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1243110991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57DEC5Au) % 3u)
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
				result = !(a == b);
				num = ((int)num2 * -1508201676) ^ -1403269580;
			}
		}
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
		char c3 = default(char);
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		char c = default(char);
		while (true)
		{
			int num = 144058910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x172D5ED1u) % 28u)
				{
				case 26u:
					num = (int)((num2 * 107115516) ^ 0x563AB4B7);
					continue;
				case 25u:
					num = ((int)num2 * -1841922021) ^ 0x6E69F3E8;
					continue;
				case 24u:
					switch (c3)
					{
					case '\b':
						goto IL_0065;
					case '\t':
						goto IL_007b;
					case '\n':
						goto IL_0091;
					case '\v':
						goto IL_00a7;
					case '\f':
						goto IL_00bf;
					case '\r':
						goto IL_00d5;
					}
					num = ((int)num2 * -98775307) ^ -2093380132;
					continue;
				case 1u:
					goto IL_0065;
				case 5u:
					goto IL_007b;
				case 2u:
					goto IL_0091;
				case 17u:
					goto IL_00a7;
				case 16u:
					goto IL_00bf;
				case 4u:
					goto IL_00d5;
				case 23u:
				{
					int num6;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = 537117489;
						num6 = 537117489;
					}
					else
					{
						num = 1670537739;
						num6 = 1670537739;
					}
					continue;
				}
				case 22u:
					num3++;
					num = 2146773638;
					continue;
				case 21u:
				{
					int num5;
					if (c3 != '"')
					{
						num = 671070002;
						num5 = 671070002;
					}
					else
					{
						num = 403271579;
						num5 = 403271579;
					}
					continue;
				}
				case 19u:
					string_ = aText;
					num = ((int)num2 * -1534785968) ^ -1829337156;
					continue;
				case 18u:
					result = text;
					num = (int)((num2 * 1498970754) ^ 0x633E25B2);
					continue;
				case 15u:
				{
					int num4;
					if (c3 != '\\')
					{
						num = 2009637222;
						num4 = 2009637222;
					}
					else
					{
						num = 909381567;
						num4 = 909381567;
					}
					continue;
				}
				case 14u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 190603215;
					continue;
				case 13u:
					num3 = 0;
					num = (int)(num2 * 1887715735) ^ -2142119282;
					continue;
				case 12u:
					c = JSONNode.smethod_2(string_, num3);
					num = 1846870787;
					continue;
				case 11u:
					num = ((int)num2 * -14130763) ^ 0x6E847AC0;
					continue;
				case 10u:
				{
					char c2 = c;
					c3 = c2;
					num = ((int)num2 * -145322464) ^ -55751339;
					continue;
				}
				case 9u:
					num = ((int)num2 * -957827679) ^ 0x6D39DD5;
					continue;
				case 8u:
					num = (int)((num2 * 276980328) ^ 0x94A1F0F);
					continue;
				case 7u:
					num = ((int)num2 * -1182234056) ^ 0x5A0E73D4;
					continue;
				case 6u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1524648617;
					continue;
				case 3u:
					num = ((int)num2 * -859904582) ^ -864891304;
					continue;
				case 0u:
					num = ((int)num2 * -544505816) ^ -124769754;
					continue;
				case 20u:
					break;
				default:
					{
						return result;
					}
					IL_00a7:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 1687495220;
					continue;
					IL_0091:
					text = JSONNode.smethod_3(text, "\\n");
					num = 190603215;
					continue;
					IL_007b:
					text = JSONNode.smethod_3(text, "\\t");
					num = 190603215;
					continue;
					IL_0065:
					text = JSONNode.smethod_3(text, "\\b");
					num = 190603215;
					continue;
					IL_00d5:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1284761826;
					continue;
					IL_00bf:
					text = JSONNode.smethod_3(text, "\\f");
					num = 415449587;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		char c2 = default(char);
		char c = default(char);
		char c5 = default(char);
		int num11 = default(int);
		string text = default(string);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag7 = default(bool);
		char c3 = default(char);
		bool flag13 = default(bool);
		string text2 = default(string);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		JSONNode result = default(JSONNode);
		char c4 = default(char);
		bool flag = default(bool);
		while (true)
		{
			int num = 402886843;
			while (true)
			{
				uint num2;
				int num22;
				switch ((num2 = (uint)num ^ 0x849DB40u) % 156u)
				{
				case 155u:
				{
					int num34;
					if (c2 == '}')
					{
						num = 1218698782;
						num34 = 1218698782;
					}
					else
					{
						num = 2109617137;
						num34 = 2109617137;
					}
					continue;
				}
				case 154u:
				{
					int num7;
					if (c != 'n')
					{
						num = 1902328213;
						num7 = 1902328213;
					}
					else
					{
						num = 406800222;
						num7 = 406800222;
					}
					continue;
				}
				case 153u:
					c5 = JSONNode.smethod_2(aJSON, num11);
					num = 303741623;
					continue;
				case 152u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)((num2 * 173776084) ^ 0x572F2D5A);
					continue;
				case 151u:
				{
					int num9;
					int num10;
					if (!(jSONNode != null))
					{
						num9 = -263052068;
						num10 = -263052068;
					}
					else
					{
						num9 = -74468336;
						num10 = -74468336;
					}
					num = num9 ^ (int)(num2 * 555218023);
					continue;
				}
				case 150u:
					stack.Pop();
					num = 2060066066;
					continue;
				case 149u:
				{
					int num30;
					int num31;
					if (flag7)
					{
						num30 = 170196647;
						num31 = 170196647;
					}
					else
					{
						num30 = 1464960983;
						num31 = 1464960983;
					}
					num = num30 ^ ((int)num2 * -1017602006);
					continue;
				}
				case 148u:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1598121968;
					continue;
				case 147u:
				{
					c2 = c5;
					int num55;
					int num56;
					if ((uint)c2 > 44u)
					{
						num55 = 453360754;
						num56 = 453360754;
					}
					else
					{
						num55 = 462430970;
						num56 = 462430970;
					}
					num = num55 ^ ((int)num2 * -794020398);
					continue;
				}
				case 146u:
					flag13 = jSONNode is JSONArray;
					num = ((int)num2 * -1858209111) ^ 0x6A6E9B4E;
					continue;
				case 145u:
					goto IL_0154;
				case 144u:
					text2 = "";
					num = 2002914292;
					continue;
				case 143u:
					num = (int)((num2 * 291955080) ^ 0x2B32200F);
					continue;
				case 142u:
					num = (int)((num2 * 414820529) ^ 0x3D458E56);
					continue;
				case 141u:
				{
					int num35;
					int num36;
					if (flag9)
					{
						num35 = -732370320;
						num36 = -732370320;
					}
					else
					{
						num35 = -2140199757;
						num36 = -2140199757;
					}
					num = num35 ^ (int)(num2 * 1713934760);
					continue;
				}
				case 140u:
				{
					int num27;
					if ((uint)c2 <= 93u)
					{
						num = 364554592;
						num27 = 364554592;
					}
					else
					{
						num = 101972858;
						num27 = 101972858;
					}
					continue;
				}
				case 139u:
					num = (int)((num2 * 543198429) ^ 0x280292A0);
					continue;
				case 138u:
					num = ((int)num2 * -1374262267) ^ 0x6441D7BD;
					continue;
				case 137u:
					text = "";
					num = ((int)num2 * -1454243004) ^ -1556428024;
					continue;
				case 136u:
				{
					int num59;
					int num60;
					if (!flag13)
					{
						num59 = -1361345112;
						num60 = -1361345112;
					}
					else
					{
						num59 = -794787745;
						num60 = -794787745;
					}
					num = num59 ^ (int)(num2 * 1258722099);
					continue;
				}
				case 135u:
					text = "";
					num = ((int)num2 * -1191492577) ^ 0x58805FCD;
					continue;
				case 134u:
				{
					int num51;
					int num52;
					if ((uint)c > 102u)
					{
						num51 = -825936348;
						num52 = -825936348;
					}
					else
					{
						num51 = -1977280422;
						num52 = -1977280422;
					}
					num = num51 ^ (int)(num2 * 1200643339);
					continue;
				}
				case 133u:
					num = ((int)num2 * -148310399) ^ -1235268188;
					continue;
				case 132u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -354195317) ^ -415867052;
					continue;
				case 131u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 269654740) ^ -1314554018;
					continue;
				case 130u:
					num = ((int)num2 * -1824608108) ^ -508087572;
					continue;
				case 7u:
				case 49u:
				case 126u:
				case 128u:
				case 129u:
					num11++;
					num = 1118215926;
					continue;
				case 127u:
					num = ((int)num2 * -1422587901) ^ -192439389;
					continue;
				case 125u:
				{
					int num44;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 2121133915;
						num44 = 2121133915;
					}
					else
					{
						num = 21553223;
						num44 = 21553223;
					}
					continue;
				}
				case 124u:
					text = "";
					num = ((int)num2 * -1196298610) ^ -1507481990;
					continue;
				case 123u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 134750233) ^ -1784005282;
					continue;
				case 122u:
					num = (int)((num2 * 707376080) ^ 0x5C3322F9);
					continue;
				case 121u:
					num = ((int)num2 * -1950845867) ^ -1472232209;
					continue;
				case 120u:
					num = (int)(num2 * 261907712) ^ -1984344259;
					continue;
				case 119u:
					text2 = text;
					num = 897803020;
					continue;
				case 118u:
				{
					int num38;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 495144560;
						num38 = 495144560;
					}
					else
					{
						num = 434913089;
						num38 = 434913089;
					}
					continue;
				}
				case 117u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 1021870188) ^ -432906537;
					continue;
				case 116u:
				{
					int num28;
					int num29;
					if ((uint)c2 <= 32u)
					{
						num28 = -858594010;
						num29 = -858594010;
					}
					else
					{
						num28 = -1803753573;
						num29 = -1803753573;
					}
					num = num28 ^ (int)(num2 * 1625689261);
					continue;
				}
				case 115u:
				{
					int num23;
					int num24;
					if (flag3)
					{
						num23 = 1517169574;
						num24 = 1517169574;
					}
					else
					{
						num23 = 1140594416;
						num24 = 1140594416;
					}
					num = num23 ^ (int)(num2 * 1622828703);
					continue;
				}
				case 114u:
					num = ((int)num2 * -214020139) ^ -1693044318;
					continue;
				case 113u:
					num = (int)(num2 * 1775593120) ^ -797759213;
					continue;
				case 112u:
					goto IL_0479;
				case 111u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -1892426164) ^ 0x6C9CED63;
					continue;
				case 110u:
				{
					int num18;
					if (c2 != '{')
					{
						num = 1284040471;
						num18 = 1284040471;
					}
					else
					{
						num = 1749334850;
						num18 = 1749334850;
					}
					continue;
				}
				case 109u:
					num11 += 4;
					num = ((int)num2 * -386204922) ^ -932978093;
					continue;
				case 108u:
					num = ((int)num2 * -838364971) ^ 0x2FC2F731;
					continue;
				case 107u:
					num = ((int)num2 * -701543143) ^ -2099573679;
					continue;
				case 106u:
					flag7 = false;
					num = ((int)num2 * -1226686186) ^ 0x5FBA60E5;
					continue;
				case 105u:
					flag6 = JSONNode.smethod_6(text2, "");
					num = 277714050;
					continue;
				case 104u:
					num = (int)(num2 * 491712549) ^ -771439924;
					continue;
				case 103u:
					num = (int)((num2 * 1550386949) ^ 0x1D9EF357);
					continue;
				case 102u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -2092785037;
						num6 = -2092785037;
					}
					else
					{
						num5 = -2004711624;
						num6 = -2004711624;
					}
					num = num5 ^ (int)(num2 * 1563624629);
					continue;
				}
				case 101u:
				{
					int num57;
					int num58;
					if (!flag12)
					{
						num57 = 1213866431;
						num58 = 1213866431;
					}
					else
					{
						num57 = 438919985;
						num58 = 438919985;
					}
					num = num57 ^ (int)(num2 * 2136205959);
					continue;
				}
				case 100u:
				{
					int num53;
					int num54;
					if (c2 == ':')
					{
						num53 = 2055472220;
						num54 = 2055472220;
					}
					else
					{
						num53 = 97924358;
						num54 = 97924358;
					}
					num = num53 ^ (int)(num2 * 93991752);
					continue;
				}
				case 99u:
					num = (int)((num2 * 1531360772) ^ 0x741072EF);
					continue;
				case 98u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1879167722) ^ -1450516429;
					continue;
				case 97u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)((num2 * 284643084) ^ 0x1A320986);
					continue;
				case 96u:
					num = ((int)num2 * -649175345) ^ -1559542695;
					continue;
				case 95u:
					num = 486551545;
					continue;
				case 94u:
				{
					int num49;
					int num50;
					if (!flag5)
					{
						num49 = 1268899851;
						num50 = 1268899851;
					}
					else
					{
						num49 = 1276578082;
						num50 = 1276578082;
					}
					num = num49 ^ ((int)num2 * -1758265408);
					continue;
				}
				case 93u:
					jSONNode.Add(text);
					num = ((int)num2 * -195514493) ^ 0x29ADB0F7;
					continue;
				case 92u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -838579161) ^ 0x32C43FD;
					continue;
				case 91u:
					num = ((int)num2 * -538868015) ^ -227084075;
					continue;
				case 90u:
					text = JSONNode.smethod_3(text, "\b");
					num = 872955709;
					continue;
				case 89u:
					num = ((int)num2 * -1549200296) ^ 0x5F0E93F0;
					continue;
				case 88u:
					num = ((int)num2 * -1627111667) ^ 0x7229A8B;
					continue;
				case 87u:
					flag10 = flag7;
					num = 1028971996;
					continue;
				case 86u:
					switch (c2)
					{
					case '[':
						break;
					default:
						goto IL_0744;
					case '\\':
						goto IL_074e;
					case ']':
						goto IL_075c;
					}
					goto case 87u;
				case 6u:
					goto IL_074e;
				case 34u:
					goto IL_075c;
				case 84u:
				{
					int num47;
					int num48;
					if (flag8)
					{
						num47 = 620285772;
						num48 = 620285772;
					}
					else
					{
						num47 = 651484134;
						num48 = 651484134;
					}
					num = num47 ^ ((int)num2 * -1522136161);
					continue;
				}
				case 83u:
					flag4 = num11 < JSONNode.smethod_4(aJSON);
					num = 1688441729;
					continue;
				case 81u:
					num = (int)((num2 * 1405922524) ^ 0x69E7D1F6);
					continue;
				case 80u:
				{
					int num45;
					int num46;
					if (flag11)
					{
						num45 = -1278925327;
						num46 = -1278925327;
					}
					else
					{
						num45 = -1518153031;
						num46 = -1518153031;
					}
					num = num45 ^ (int)(num2 * 577259210);
					continue;
				}
				case 79u:
					text2 = "";
					num = 1971834295;
					continue;
				case 78u:
				{
					int num43;
					if (!flag7)
					{
						num = 2108111861;
						num43 = 2108111861;
					}
					else
					{
						num = 2146005083;
						num43 = 2146005083;
					}
					continue;
				}
				case 77u:
				{
					string s = JSONNode.smethod_8(aJSON, num11 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 232962452) ^ 0x6850D929);
					continue;
				}
				case 75u:
					num = (int)((num2 * 1838462857) ^ 0x5EBB927D);
					continue;
				case 74u:
					num = ((int)num2 * -1368172830) ^ 0x323DA4B8;
					continue;
				case 73u:
					text2 = "";
					num = 1936919905;
					continue;
				case 72u:
					text = "";
					num = ((int)num2 * -1164486746) ^ 0x6952282;
					continue;
				case 71u:
					num = 1325077474;
					continue;
				case 70u:
					text2 = "";
					num = 3708955;
					continue;
				case 69u:
					flag11 = jSONNode is JSONArray;
					num = (int)((num2 * 1248594971) ^ 0x292EC1C7);
					continue;
				case 68u:
					flag7 = !flag7;
					num = 1112721765;
					continue;
				case 67u:
					num = (int)((num2 * 1181107955) ^ 0x4849C821);
					continue;
				case 66u:
					num = ((int)num2 * -1044654683) ^ 0x42E922A0;
					continue;
				case 65u:
				{
					int num42;
					if (c2 == ' ')
					{
						num = 1243641691;
						num42 = 1243641691;
					}
					else
					{
						num = 1495088743;
						num42 = 1495088743;
					}
					continue;
				}
				case 64u:
				{
					int num40;
					int num41;
					if (!flag10)
					{
						num40 = -192169407;
						num41 = -192169407;
					}
					else
					{
						num40 = -1470668872;
						num41 = -1470668872;
					}
					num = num40 ^ ((int)num2 * -1806397223);
					continue;
				}
				case 63u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1675973523) ^ 0x58640EB4;
					continue;
				case 62u:
					text = JSONNode.smethod_3(text, "\n");
					num = 872955709;
					continue;
				case 61u:
					goto IL_0991;
				case 60u:
					num = 495144560;
					continue;
				case 59u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num11 = 0;
					text = "";
					num = ((int)num2 * -1093077414) ^ -1840253788;
					continue;
				case 58u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1660468875) ^ 0x57BD7FDC;
					continue;
				case 57u:
					num = (int)((num2 * 1713421326) ^ 0x566309ED);
					continue;
				case 56u:
				{
					int num39;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 760417646;
						num39 = 760417646;
					}
					else
					{
						num = 890702455;
						num39 = 890702455;
					}
					continue;
				}
				case 55u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 817814350) ^ 0x6B8ECA86);
					continue;
				case 54u:
					jSONNode.Add(text);
					num = (int)((num2 * 1250404330) ^ 0x6EE2A864);
					continue;
				case 53u:
					goto IL_0a66;
				case 52u:
					switch (c)
					{
					case 's':
						break;
					case 't':
						goto IL_0154;
					case 'u':
						goto IL_0991;
					case 'r':
						goto IL_0a66;
					default:
						goto IL_0a96;
					}
					goto case 148u;
				case 51u:
					result = jSONNode;
					num = 1620002827;
					continue;
				case 50u:
				{
					int num37;
					if (c2 == ',')
					{
						num = 612874782;
						num37 = 612874782;
					}
					else
					{
						num = 1144241034;
						num37 = 1144241034;
					}
					continue;
				}
				case 48u:
				{
					int num32;
					int num33;
					if (c == 'b')
					{
						num32 = 1883060190;
						num33 = 1883060190;
					}
					else
					{
						num32 = 2017837468;
						num33 = 2017837468;
					}
					num = num32 ^ (int)(num2 * 2121854386);
					continue;
				}
				case 47u:
				{
					int num25;
					int num26;
					if (!(jSONNode is JSONArray))
					{
						num25 = -1063969696;
						num26 = -1063969696;
					}
					else
					{
						num25 = -1564454663;
						num26 = -1564454663;
					}
					num = num25 ^ ((int)num2 * -1224143224);
					continue;
				}
				case 46u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_0479;
					default:
						goto IL_0b48;
					case '\t':
						goto IL_0b5b;
					}
					goto case 7u;
				case 19u:
					goto IL_0b5b;
				case 45u:
					num = ((int)num2 * -506482573) ^ -1038180268;
					continue;
				case 44u:
					c = c4;
					num = ((int)num2 * -656041085) ^ -1968597646;
					continue;
				case 43u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -533913548) ^ 0x5B63237;
					continue;
				case 42u:
					num = ((int)num2 * -855328779) ^ -271087686;
					continue;
				case 41u:
					text = JSONNode.smethod_3(text, "\f");
					num = 2065170076;
					continue;
				case 40u:
					num = (int)((num2 * 1521838847) ^ 0x3708F119);
					continue;
				case 39u:
					num = ((int)num2 * -1721697079) ^ -536634180;
					continue;
				case 38u:
					num = (int)(num2 * 525777475) ^ -213194748;
					continue;
				case 37u:
					stack.Push(new JSONArray());
					num = 1030275293;
					continue;
				case 36u:
					flag9 = flag7;
					num = 1793950085;
					continue;
				case 35u:
					num = (int)((num2 * 1464004431) ^ 0x335C25D0);
					continue;
				case 32u:
					flag2 = jSONNode is JSONArray;
					num = (int)(num2 * 758118126) ^ -232339406;
					continue;
				case 31u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -753921596) ^ 0x5CDB7B4C;
					continue;
				case 30u:
					flag8 = flag7;
					num = 837968700;
					continue;
				case 29u:
					num = (int)((num2 * 1475026580) ^ 0x2B93A270);
					continue;
				case 28u:
				{
					int num21;
					if (stack.Count != 0)
					{
						num = 147084882;
						num21 = 147084882;
					}
					else
					{
						num = 2086857433;
						num21 = 2086857433;
					}
					continue;
				}
				case 27u:
					text = "";
					num = ((int)num2 * -103231463) ^ 0x6E1C6B32;
					continue;
				case 26u:
					text2 = "";
					num = ((int)num2 * -1969543223) ^ 0x51F9F050;
					continue;
				case 25u:
					stack.Push(new JSONClass());
					num = 1038197623;
					continue;
				case 24u:
					num = 588089483;
					continue;
				case 23u:
					flag = flag7;
					num = ((int)num2 * -1309680041) ^ -984630845;
					continue;
				case 22u:
				{
					int num19;
					int num20;
					if (flag6)
					{
						num19 = 271132213;
						num20 = 271132213;
					}
					else
					{
						num19 = 2084371594;
						num20 = 2084371594;
					}
					num = num19 ^ (int)(num2 * 1217072739);
					continue;
				}
				case 21u:
				{
					int num17;
					if (c != 'f')
					{
						num = 458254714;
						num17 = 458254714;
					}
					else
					{
						num = 1409403517;
						num17 = 1409403517;
					}
					continue;
				}
				case 20u:
					num = (int)((num2 * 1939596765) ^ 0x6A3480CE);
					continue;
				case 18u:
				{
					int num15;
					int num16;
					if (JSONNode.smethod_6(text, ""))
					{
						num15 = 444008716;
						num16 = 444008716;
					}
					else
					{
						num15 = 293028332;
						num16 = 293028332;
					}
					num = num15 ^ (int)(num2 * 339271855);
					continue;
				}
				case 17u:
					c3 = JSONNode.smethod_2(aJSON, num11);
					c4 = c3;
					num = ((int)num2 * -1148957859) ^ 0x55F42AC5;
					continue;
				case 16u:
				{
					int num14;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 2015331538;
						num14 = 2015331538;
					}
					else
					{
						num = 611344700;
						num14 = 611344700;
					}
					continue;
				}
				case 15u:
					flag5 = jSONNode != null;
					num = (int)((num2 * 1870679915) ^ 0x6432DAE3);
					continue;
				case 14u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -1585391335) ^ 0x71D5E4C5;
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if (!flag4)
					{
						num12 = -2080774408;
						num13 = -2080774408;
					}
					else
					{
						num12 = -305703818;
						num13 = -305703818;
					}
					num = num12 ^ ((int)num2 * -1807953805);
					continue;
				}
				case 12u:
					num = ((int)num2 * -81626782) ^ -1645327275;
					continue;
				case 11u:
					num = (int)(num2 * 1631782704) ^ -1524516246;
					continue;
				case 10u:
					num = ((int)num2 * -1078827354) ^ -541890321;
					continue;
				case 9u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1079752494) ^ -498798118;
					continue;
				case 8u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -551005481) ^ 0x5FD1777C;
					continue;
				case 5u:
					flag3 = stack.Count > 0;
					num = ((int)num2 * -1666178451) ^ 0x51A74F36;
					continue;
				case 4u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -386653316) ^ 0x44FB39EA;
					continue;
				case 3u:
				{
					int num8;
					if (c2 != '"')
					{
						num = 1282584143;
						num8 = 1282584143;
					}
					else
					{
						num = 1631654068;
						num8 = 1631654068;
					}
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1246861918;
						num4 = -1246861918;
					}
					else
					{
						num3 = -1334818947;
						num4 = -1334818947;
					}
					num = num3 ^ (int)(num2 * 859402267);
					continue;
				}
				case 1u:
					num = 1837019181;
					continue;
				case 0u:
					num = ((int)num2 * -747686808) ^ -273649766;
					continue;
				case 33u:
					break;
				case 76u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 85u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0479:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num11).ToString());
					num = 1336627315;
					continue;
					IL_0b5b:
					if (!flag7)
					{
						num = 313275728;
						num22 = 313275728;
					}
					else
					{
						num = 727230519;
						num22 = 727230519;
					}
					continue;
					IL_0b48:
					num = ((int)num2 * -1019711602) ^ 0x444B7827;
					continue;
					IL_0a96:
					num = 2096956190;
					continue;
					IL_0a66:
					text = JSONNode.smethod_3(text, "\r");
					num = 1616616476;
					continue;
					IL_0991:
					num = 1355479697;
					continue;
					IL_075c:
					flag12 = flag7;
					num = 1278826877;
					continue;
					IL_074e:
					num11++;
					num = 633664777;
					continue;
					IL_0744:
					num = 563164040;
					continue;
					IL_0154:
					text = JSONNode.smethod_3(text, "\t");
					num = 872955709;
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
			int num = 845198210;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6987792Bu) % 5u)
				{
				case 3u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -757655951) ^ 0x28C823D0;
					continue;
				case 2u:
					Serialize(aWriter);
					num = ((int)num2 * -1239779693) ^ -491371418;
					continue;
				case 1u:
					num = (int)((num2 * 218876099) ^ 0x272A3814);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
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
			while (true)
			{
				int num = 837497776;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x52631A17u) % 3u)
					{
					case 2u:
						goto IL_0020;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0020:
					SaveToStream(fileStream);
					num = ((int)num2 * -627093282) ^ -180017295;
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
					int num3 = 1690063824;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x52631A17u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1405077524) ^ -946083651;
							continue;
						case 2u:
							num3 = (int)((num2 * 990482737) ^ 0x3B8A731C);
							continue;
						default:
							goto end_IL_0081;
						case 0u:
							break;
						case 1u:
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

	public string SaveToBase64()
	{
		MemoryStream memoryStream = JSONNode.smethod_16();
		try
		{
			SaveToStream(memoryStream);
			while (true)
			{
				int num = -198473023;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x80D561C7u) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
					}
					break;
					IL_000f:
					num = ((int)num2 * -1103795505) ^ -1659009359;
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
					int num3 = -1288871722;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x80D561C7u) % 4u)
						{
						case 2u:
							num3 = (int)((num2 * 1346641379) ^ 0x183726DE);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 725872600) ^ 0x6C67EE6D);
							continue;
						default:
							goto end_IL_0084;
						case 0u:
							break;
						case 3u:
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
		JSONBinaryTag jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		int num7 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num3 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -638888523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1D6CA14u) % 35u)
				{
				case 34u:
					num = -617643915;
					continue;
				case 33u:
					num = ((int)num2 * -1341557708) ^ -2140356363;
					continue;
				case 32u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 1677460100;
						num9 = 1677460100;
					}
					else
					{
						num8 = 232254083;
						num9 = 232254083;
					}
					num = num8 ^ (int)(num2 * 981804716);
					continue;
				}
				case 31u:
					goto IL_0052;
				case 30u:
					num = ((int)num2 * -870571737) ^ -103484737;
					continue;
				case 29u:
					goto IL_006f;
				case 28u:
					result = jSONArray;
					num = ((int)num2 * -985934911) ^ 0x40CC3936;
					continue;
				case 27u:
					num7++;
					num = ((int)num2 * -323854848) ^ -499187203;
					continue;
				case 26u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1904825776) ^ -744592227;
					continue;
				}
				case 25u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1063327432) ^ -777752239;
					continue;
				case 24u:
					result = jSONClass;
					num = (int)(num2 * 798518796) ^ -913507219;
					continue;
				case 23u:
					jSONArray = new JSONArray();
					num3 = 0;
					num = (int)((num2 * 808329995) ^ 0x4A480C1F);
					continue;
				case 22u:
					num = (int)((num2 * 1316809864) ^ 0x2041885C);
					continue;
				case 21u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -2140291654) ^ -1847306432;
					continue;
				case 20u:
					goto IL_0160;
				case 18u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -512465835) ^ 0x32F9557B;
					continue;
				case 16u:
					num7 = 0;
					num = (int)(num2 * 270366927) ^ -1852051263;
					continue;
				case 14u:
					flag = num7 < num5;
					num = -932984036;
					continue;
				case 13u:
				{
					int num6;
					if (num3 >= num4)
					{
						num = -1817412097;
						num6 = -1817412097;
					}
					else
					{
						num = -184289538;
						num6 = -184289538;
					}
					continue;
				}
				case 12u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -647600894) ^ 0x6E05A94E;
					continue;
				case 11u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Array:
						break;
					case JSONBinaryTag.Value:
						goto IL_0052;
					case JSONBinaryTag.BoolValue:
						goto IL_006f;
					case JSONBinaryTag.FloatValue:
						goto IL_0160;
					default:
						goto IL_021b;
					case JSONBinaryTag.Class:
						goto IL_022e;
					case JSONBinaryTag.IntValue:
						goto IL_0247;
					case JSONBinaryTag.DoubleValue:
						goto IL_0251;
					}
					goto case 34u;
				case 8u:
					goto IL_022e;
				case 7u:
					goto IL_0247;
				case 9u:
					goto IL_0251;
				case 10u:
					num = (int)(num2 * 2035102102) ^ -1185547259;
					continue;
				case 6u:
					num = ((int)num2 * -1374098012) ^ -966792024;
					continue;
				case 5u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 222608751) ^ 0x503936CF);
					continue;
				case 4u:
					num = -1816064428;
					continue;
				case 3u:
					num = ((int)num2 * -2004700703) ^ -1043909215;
					continue;
				case 2u:
					num4 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1774469127) ^ 0x4D88269B;
					continue;
				case 1u:
					jSONArray.Add(Deserialize(aReader));
					num3++;
					num = -1538739692;
					continue;
				case 0u:
					num = (int)((num2 * 1442151387) ^ 0x1EC70D4A);
					continue;
				case 15u:
					break;
				case 17u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0251:
					num = -727254123;
					continue;
					IL_0247:
					num = -629812745;
					continue;
					IL_022e:
					num5 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = -2104410687;
					continue;
					IL_021b:
					num = (int)((num2 * 618094928) ^ 0x3B6CA7D6);
					continue;
					IL_0160:
					num = -131572930;
					continue;
					IL_006f:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1483880967;
					continue;
					IL_0052:
					num = -1668682731;
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
					int num = -624801767;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xCA36A202u) % 3u)
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
						num = (int)((num2 * 1929720987) ^ 0x6B8CEDCD);
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
				int num = 144754417;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97DF0DFu) % 3u)
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
					num = ((int)num2 * -861401858) ^ 0x49E0F489;
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
					int num3 = 493378530;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x97DF0DFu) % 4u)
						{
						case 3u:
							num3 = (int)((num2 * 964806737) ^ 0x7053F2D2);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -585210764) ^ 0x4834ABF4;
							continue;
						default:
							goto end_IL_006b;
						case 0u:
							break;
						case 2u:
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
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = 48469960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CB80E68u) % 5u)
				{
				case 4u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 105446543) ^ 0x63118AB1);
					continue;
				case 1u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1408805074) ^ 0x7C616274;
					continue;
				}
				case 0u:
					num = (int)(num2 * 807816702) ^ -1662427002;
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
			int num = 1600635076;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C842666u) % 3u)
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
				num = (int)(num2 * 106427998) ^ -720252401;
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
