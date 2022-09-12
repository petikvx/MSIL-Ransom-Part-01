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
				int num = 1163486691;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5C8FD15Au) % 3u)
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
					num = ((int)num2 * -437304685) ^ 0x69305351;
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
				int num = 2058193434;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73E80CAu) % 3u)
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
					num = (int)(num2 * 929212898) ^ -210202565;
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
				int num = 891348481;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4535983Bu) % 4u)
					{
					case 2u:
						result = 0;
						num = ((int)num2 * -511516997) ^ -1075096112;
						continue;
					case 1u:
						num = ((int)num2 * -647259423) ^ -890709567;
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
			while (true)
			{
				int num = 1689370223;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15496F49u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)(num2 * 1089847648) ^ -1167193461;
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
			int result2 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -2067608013;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFEE7DDA8u) % 8u)
					{
					case 7u:
						result = result2;
						num = ((int)num2 * -358810443) ^ -1450929937;
						continue;
					case 6u:
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 1708722305) ^ 0x21B3A7B3);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1804707331;
							num4 = 1804707331;
						}
						else
						{
							num3 = 1785828228;
							num4 = 1785828228;
						}
						num = num3 ^ ((int)num2 * -1615215425);
						continue;
					}
					case 4u:
						num = (int)(num2 * 530451797) ^ -5487795;
						continue;
					case 3u:
						result2 = 0;
						num = (int)(num2 * 895396216) ^ -2070178538;
						continue;
					case 0u:
						result = 0;
						num = -1113016367;
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
				int num = 1647119868;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40F6DDE8u) % 3u)
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
					num = (int)(num2 * 1462064375) ^ -1228801753;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result2 = default(float);
			float result = default(float);
			while (true)
			{
				int num = -904507295;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD4B8D3Cu) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1174602735) ^ 0x1C1C0429);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = 1691854529;
							num4 = 1691854529;
						}
						else
						{
							num3 = 1626976011;
							num4 = 1626976011;
						}
						num = num3 ^ (int)(num2 * 605463178);
						continue;
					}
					case 5u:
						result2 = 0f;
						num = ((int)num2 * -2014954069) ^ -1951762995;
						continue;
					case 3u:
						result = 0f;
						num = -1365121165;
						continue;
					case 1u:
						result = result2;
						num = (int)((num2 * 1106350229) ^ 0x7710F1C1);
						continue;
					case 0u:
						num = ((int)num2 * -111398907) ^ -1314750928;
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
				int num = 297062168;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x26A59B72u) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = ((int)num2 * -443306192) ^ 0x167E41FB;
						continue;
					case 1u:
						num = ((int)num2 * -1079759351) ^ -96897453;
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

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			double result2 = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = -1917349855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF97CB2A2u) % 8u)
					{
					case 7u:
						result2 = 0.0;
						num = -2041173234;
						continue;
					case 6u:
						num = ((int)num2 * -543617326) ^ 0x372DB4D6;
						continue;
					case 4u:
						num = ((int)num2 * -86371220) ^ 0x5C639BAA;
						continue;
					case 3u:
						flag = double.TryParse(Value, out result);
						num = (int)((num2 * 293794511) ^ 0x43BE5FBD);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2022181247;
							num4 = -2022181247;
						}
						else
						{
							num3 = -178945921;
							num4 = -178945921;
						}
						num = num3 ^ ((int)num2 * -944503167);
						continue;
					}
					case 1u:
						result2 = result;
						num = (int)(num2 * 1271758771) ^ -1234027769;
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
				int num = -985031503;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD000696Du) % 3u)
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
					num = ((int)num2 * -832230371) ^ -1931489339;
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool result2 = default(bool);
			while (true)
			{
				int num = -214257561;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2D0853Cu) % 6u)
					{
					case 5u:
						result2 = !JSONNode.smethod_1(Value);
						num = -574082426;
						continue;
					case 4u:
						result2 = result;
						num = ((int)num2 * -143581761) ^ 0x5B441E7E;
						continue;
					case 2u:
						num = ((int)num2 * -506872792) ^ -99877988;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (bool.TryParse(Value, out result))
						{
							num3 = -1628223646;
							num4 = -1628223646;
						}
						else
						{
							num3 = -768936529;
							num4 = -768936529;
						}
						num = num3 ^ ((int)num2 * -347743632);
						continue;
					}
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
			while (true)
			{
				int num = 1070558044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x239A5076u) % 4u)
					{
					case 2u:
						Value = (value ? "true" : "false");
						num = 2120040259;
						continue;
					case 1u:
						num = ((int)num2 * -240598484) ^ 0x1660A80D;
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
				int num = -294998342;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0A50843u) % 3u)
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
					result = this as JSONArray;
					num = ((int)num2 * -2045815076) ^ 0x575F6A95;
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
				int num = 639872097;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37A8A3A4u) % 3u)
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
					num = ((int)num2 * -1416162102) ^ -1045453307;
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
			int num = 1891944116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x559B3F46u) % 3u)
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
				num = (int)(num2 * 407386577) ^ -3047878;
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
			int num = -1069571557;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9246B388u) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 2u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0004:
				num = (int)(num2 * 1618676292) ^ -405250756;
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -628631697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCB39868u) % 3u)
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
				num = (int)((num2 * 6968) ^ 0xB828E44);
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
			int num = 1799551883;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x733C691Du) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1908542463) ^ -262576803;
					continue;
				case 2u:
					result = new JSONData(s);
					num = (int)(num2 * 39632184) ^ -313296362;
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
			int num = -415356711;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x95B0E3FCu) % 5u)
				{
				case 3u:
					num = (int)(num2 * 1661706432) ^ -99575168;
					continue;
				case 1u:
					if (!(d == null))
					{
						num = ((int)num2 * -484377966) ^ 0x4C230070;
						continue;
					}
					obj = null;
					goto IL_002b;
				case 0u:
					obj = d.Value;
					goto IL_002b;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_002b:
					result = (string)obj;
					num = -1680171165;
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
			goto IL_001a;
		}
		int num = 0;
		goto IL_0094;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
		IL_001a:
		int num2 = 57048862;
		goto IL_005e;
		IL_005e:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x6519749Fu) % 7u)
			{
			case 5u:
				result = true;
				num2 = (int)(num3 * 1539412036) ^ -1447464051;
				continue;
			case 3u:
				break;
			case 2u:
				num2 = (int)(num3 * 1829953059) ^ -1927219188;
				continue;
			case 1u:
				result = (object)a == b;
				num2 = 1707854336;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 1768776342;
					num5 = 1768776342;
				}
				else
				{
					num4 = 78638051;
					num5 = 78638051;
				}
				num2 = num4 ^ ((int)num3 * -2019914963);
				continue;
			}
			case 4u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_001a;
		IL_0094:
		flag = (byte)num != 0;
		num2 = 185473585;
		goto IL_005e;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1977062584;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5431F6BBu) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = ((int)num2 * -1085822078) ^ -1521827879;
					continue;
				case 0u:
					num = ((int)num2 * -2109078465) ^ 0x681A421E;
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

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -1182410897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF89B2C8Au) % 3u)
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
				num = ((int)num2 * -1975137520) ^ 0x3231CD74;
			}
		}
	}

	internal static string Escape(string aText)
	{
		int num3 = default(int);
		string text = default(string);
		char c3 = default(char);
		string result = default(string);
		char c2 = default(char);
		string string_ = default(string);
		char c = default(char);
		while (true)
		{
			int num = 495094979;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22ACE1E1u) % 32u)
				{
				case 31u:
					num = ((int)num2 * -457796441) ^ 0x7E69E88C;
					continue;
				case 30u:
					num3 = 0;
					num = ((int)num2 * -734019648) ^ 0x7A50193;
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, "\\b");
					num = 698964328;
					continue;
				case 28u:
					goto IL_0044;
				case 27u:
					num = (int)(num2 * 854113786) ^ -1127532884;
					continue;
				case 26u:
					num = (int)((num2 * 1878236495) ^ 0x7F529B54);
					continue;
				case 25u:
					num = ((int)num2 * -520964388) ^ -1201032642;
					continue;
				case 24u:
				{
					int num6;
					if (c3 == '"')
					{
						num = 1781148453;
						num6 = 1781148453;
					}
					else
					{
						num = 137632190;
						num6 = 137632190;
					}
					continue;
				}
				case 23u:
					result = text;
					num = (int)((num2 * 1650331709) ^ 0x795B5A94);
					continue;
				case 22u:
					num = (int)((num2 * 64399673) ^ 0x61E09A94);
					continue;
				case 21u:
					c3 = c2;
					switch (c3)
					{
					case '\b':
						break;
					case '\r':
						goto IL_0044;
					default:
						goto IL_0103;
					case '\t':
						goto IL_0116;
					case '\n':
						goto IL_012c;
					case '\v':
						goto IL_0142;
					case '\f':
						goto IL_015a;
					}
					goto case 29u;
				case 15u:
					goto IL_0116;
				case 13u:
					goto IL_012c;
				case 3u:
					goto IL_0142;
				case 0u:
					goto IL_015a;
				case 20u:
				{
					int num5;
					if (c3 != '\\')
					{
						num = 978806104;
						num5 = 978806104;
					}
					else
					{
						num = 20353552;
						num5 = 20353552;
					}
					continue;
				}
				case 19u:
					num3++;
					num = 1202082067;
					continue;
				case 18u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 571873398;
						num4 = 571873398;
					}
					else
					{
						num = 183161991;
						num4 = 183161991;
					}
					continue;
				}
				case 17u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 2032397169;
					continue;
				case 16u:
					num = (int)(num2 * 1878275034) ^ -1078674926;
					continue;
				case 14u:
					num = (int)(num2 * 1517164198) ^ -536012231;
					continue;
				case 11u:
					num = (int)(num2 * 1013600300) ^ -1456152106;
					continue;
				case 10u:
					c2 = c;
					num = ((int)num2 * -926236199) ^ 0x5D4E8F4E;
					continue;
				case 9u:
					num = ((int)num2 * -574361928) ^ 0x549A14CA;
					continue;
				case 7u:
					num = (int)((num2 * 1569010244) ^ 0x3C2B6B6E);
					continue;
				case 6u:
					c = JSONNode.smethod_2(string_, num3);
					num = 36793291;
					continue;
				case 5u:
					num = ((int)num2 * -1336040342) ^ 0x3756660B;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1052766026;
					continue;
				case 2u:
					text = "";
					num = ((int)num2 * -1782524657) ^ -325182754;
					continue;
				case 1u:
					string_ = aText;
					num = (int)(num2 * 882732162) ^ -1696191139;
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_0044:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1504951479;
					continue;
					IL_015a:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1991030235;
					continue;
					IL_0142:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 1201476786;
					continue;
					IL_012c:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1884088806;
					continue;
					IL_0116:
					text = JSONNode.smethod_3(text, "\\t");
					num = 415939098;
					continue;
					IL_0103:
					num = ((int)num2 * -1342863510) ^ 0x79C555B6;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		string text = default(string);
		string text2 = default(string);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		int num5 = default(int);
		char c = default(char);
		bool flag11 = default(bool);
		bool flag3 = default(bool);
		char c2 = default(char);
		bool flag9 = default(bool);
		bool flag16 = default(bool);
		bool flag4 = default(bool);
		char c4 = default(char);
		char c5 = default(char);
		bool flag13 = default(bool);
		bool flag10 = default(bool);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag8 = default(bool);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 14688199;
			while (true)
			{
				uint num2;
				int num50;
				switch ((num2 = (uint)num ^ 0x132236D2u) % 149u)
				{
				case 148u:
					num = ((int)num2 * -1292544699) ^ -2028783424;
					continue;
				case 147u:
					text = text2;
					text2 = "";
					num = 587065516;
					continue;
				case 146u:
				{
					int num34;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 574188156;
						num34 = 574188156;
					}
					else
					{
						num = 1978022792;
						num34 = 1978022792;
					}
					continue;
				}
				case 145u:
					flag6 = flag2;
					num = 1294755377;
					continue;
				case 144u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 457243248) ^ 0x768067FE);
					continue;
				case 13u:
				case 25u:
				case 59u:
				case 125u:
				case 142u:
					goto IL_0080;
				case 141u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1940250853) ^ 0x289055A1;
					continue;
				case 140u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 1548900275) ^ 0x7F849C5C);
					continue;
				case 139u:
					num = 348214592;
					continue;
				case 138u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -856665302) ^ 0x724ECD41;
					continue;
				case 137u:
					switch (c)
					{
					case 'r':
						goto IL_0128;
					case 's':
						goto IL_013e;
					case 't':
						goto IL_0156;
					case 'u':
						goto IL_016c;
					}
					num = 346596979;
					continue;
				case 64u:
					goto IL_0128;
				case 124u:
					goto IL_013e;
				case 122u:
					goto IL_0156;
				case 58u:
					goto IL_016c;
				case 136u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 1201495516) ^ -1694325744;
					continue;
				case 134u:
					flag11 = flag2;
					num = 1299840529;
					continue;
				case 133u:
					num = (int)((num2 * 1262726296) ^ 0x5D6F8DC5);
					continue;
				case 132u:
					flag3 = flag2;
					num = (int)((num2 * 465865707) ^ 0xBF04D94);
					continue;
				case 131u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 1539505008;
					continue;
				case 130u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num = (int)((num2 * 1035202011) ^ 0x1D2E4B14);
					continue;
				case 129u:
					text = "";
					text2 = "";
					num = 587065516;
					continue;
				case 128u:
				{
					int num30;
					int num31;
					if ((uint)c2 > 44u)
					{
						num30 = 1081101149;
						num31 = 1081101149;
					}
					else
					{
						num30 = 223418129;
						num31 = 223418129;
					}
					num = num30 ^ (int)(num2 * 147697438);
					continue;
				}
				case 127u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 255408570) ^ -455297550;
					continue;
				case 126u:
					num = (int)(num2 * 1065678573) ^ -2145781452;
					continue;
				case 123u:
					text2 = "";
					jSONNode = stack.Peek();
					num = (int)((num2 * 932614153) ^ 0x55609F30);
					continue;
				case 121u:
					stack.Pop();
					num = 1871958273;
					continue;
				case 120u:
					flag9 = jSONNode is JSONArray;
					num = (int)((num2 * 199855749) ^ 0x5B32716F);
					continue;
				case 119u:
				{
					int num6;
					int num7;
					if (jSONNode is JSONArray)
					{
						num6 = 1043793059;
						num7 = 1043793059;
					}
					else
					{
						num6 = 312246544;
						num7 = 312246544;
					}
					num = num6 ^ ((int)num2 * -708161687);
					continue;
				}
				case 118u:
				{
					int num60;
					if ((uint)c2 > 93u)
					{
						num = 1900153248;
						num60 = 1900153248;
					}
					else
					{
						num = 1505188421;
						num60 = 1505188421;
					}
					continue;
				}
				case 117u:
					flag16 = JSONNode.smethod_6(text, "");
					num = 108836911;
					continue;
				case 116u:
				{
					int num56;
					int num57;
					if (!flag4)
					{
						num56 = -1557093415;
						num57 = -1557093415;
					}
					else
					{
						num56 = -972452352;
						num57 = -972452352;
					}
					num = num56 ^ ((int)num2 * -1395320135);
					continue;
				}
				case 115u:
				{
					int num51;
					int num52;
					if (!(jSONNode is JSONArray))
					{
						num51 = 1577079194;
						num52 = 1577079194;
					}
					else
					{
						num51 = 1416495822;
						num52 = 1416495822;
					}
					num = num51 ^ ((int)num2 * -1061588261);
					continue;
				}
				case 114u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1545380030) ^ -1784341232;
					continue;
				case 113u:
					c4 = c5;
					num = (int)(num2 * 1472344011) ^ -1667490800;
					continue;
				case 112u:
				{
					int num46;
					int num47;
					if (!flag9)
					{
						num46 = 2008640213;
						num47 = 2008640213;
					}
					else
					{
						num46 = 2065469105;
						num47 = 2065469105;
					}
					num = num46 ^ ((int)num2 * -237535037);
					continue;
				}
				case 111u:
					num = (int)(num2 * 934006471) ^ -1831631645;
					continue;
				case 110u:
				{
					int num40;
					int num41;
					if (!flag13)
					{
						num40 = 541051486;
						num41 = 541051486;
					}
					else
					{
						num40 = 721108881;
						num41 = 721108881;
					}
					num = num40 ^ (int)(num2 * 1550038977);
					continue;
				}
				case 109u:
				{
					int num36;
					int num37;
					if ((uint)c2 > 32u)
					{
						num36 = -2038160491;
						num37 = -2038160491;
					}
					else
					{
						num36 = -1360302785;
						num37 = -1360302785;
					}
					num = num36 ^ (int)(num2 * 1204678143);
					continue;
				}
				case 108u:
				{
					int num33;
					if (c == 'f')
					{
						num = 1438591538;
						num33 = 1438591538;
					}
					else
					{
						num = 903482077;
						num33 = 903482077;
					}
					continue;
				}
				case 107u:
				{
					int num26;
					int num27;
					if (flag10)
					{
						num26 = 271327536;
						num27 = 271327536;
					}
					else
					{
						num26 = 1180705127;
						num27 = 1180705127;
					}
					num = num26 ^ (int)(num2 * 1080755549);
					continue;
				}
				case 105u:
					flag5 = jSONNode != null;
					num = (int)((num2 * 1203847489) ^ 0x104E0AF1);
					continue;
				case 104u:
					flag12 = flag2;
					num = 1139593446;
					continue;
				case 103u:
					num = (int)(num2 * 894406934) ^ -320289169;
					continue;
				case 102u:
					num = (int)((num2 * 218637984) ^ 0x14D88E2C);
					continue;
				case 101u:
					goto IL_0506;
				case 100u:
					num = ((int)num2 * -1125040021) ^ 0x30D7D446;
					continue;
				case 99u:
					flag10 = JSONNode.smethod_6(text2, "");
					num = ((int)num2 * -732519057) ^ 0x2930E57;
					continue;
				case 98u:
				{
					int num18;
					int num19;
					if ((uint)c <= 102u)
					{
						num18 = -717522408;
						num19 = -717522408;
					}
					else
					{
						num18 = -1078580198;
						num19 = -1078580198;
					}
					num = num18 ^ (int)(num2 * 843148200);
					continue;
				}
				case 97u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 380439639;
					continue;
				case 96u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1814277542) ^ 0x2498AE4C);
					continue;
				case 95u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = 500423462;
						num13 = 500423462;
					}
					else
					{
						num12 = 1514988431;
						num13 = 1514988431;
					}
					num = num12 ^ (int)(num2 * 1611628137);
					continue;
				}
				case 94u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 1024854584) ^ 0x7EDFFA05);
					continue;
				case 93u:
					flag4 = jSONNode is JSONArray;
					num = ((int)num2 * -1421397278) ^ -1890243879;
					continue;
				case 92u:
					num = (int)((num2 * 324223991) ^ 0x9F7AC74);
					continue;
				case 91u:
					text = "";
					text2 = "";
					num = 575140242;
					continue;
				case 90u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 1837199145) ^ -803416525;
					continue;
				case 89u:
				{
					int num61;
					int num62;
					if (!flag16)
					{
						num61 = -1522603582;
						num62 = -1522603582;
					}
					else
					{
						num61 = -1668081883;
						num62 = -1668081883;
					}
					num = num61 ^ (int)(num2 * 1587929747);
					continue;
				}
				case 88u:
					flag8 = flag2;
					num = (int)((num2 * 1823607115) ^ 0x52CB93B);
					continue;
				case 87u:
				{
					int num58;
					int num59;
					if (c == 'b')
					{
						num58 = 368499255;
						num59 = 368499255;
					}
					else
					{
						num58 = 505913432;
						num59 = 505913432;
					}
					num = num58 ^ (int)(num2 * 1213344047);
					continue;
				}
				case 86u:
					num = (int)(num2 * 1207686558) ^ -925589729;
					continue;
				case 85u:
					num = ((int)num2 * -154726320) ^ 0x6C3AEBA9;
					continue;
				case 84u:
					text = "";
					text2 = "";
					num = 738696116;
					continue;
				case 83u:
					flag14 = stack.Count > 0;
					num = ((int)num2 * -1727501623) ^ 0x37C33F96;
					continue;
				case 82u:
					flag15 = flag2;
					num = 451384595;
					continue;
				case 81u:
				{
					int num54;
					int num55;
					if (flag12)
					{
						num54 = 1178990215;
						num55 = 1178990215;
					}
					else
					{
						num54 = 875682005;
						num55 = 875682005;
					}
					num = num54 ^ (int)(num2 * 1327292134);
					continue;
				}
				case 80u:
					c5 = JSONNode.smethod_2(aJSON, num5);
					num = (int)(num2 * 614095734) ^ -1020914663;
					continue;
				case 79u:
					text = "";
					num = 1440910030;
					continue;
				case 78u:
				{
					int num53;
					if (c2 != '{')
					{
						num = 325207982;
						num53 = 325207982;
					}
					else
					{
						num = 1725296986;
						num53 = 1725296986;
					}
					continue;
				}
				case 77u:
					goto IL_07c2;
				case 76u:
					num = (int)((num2 * 2124555912) ^ 0xC206B2A);
					continue;
				case 75u:
				{
					int num48;
					int num49;
					if (flag15)
					{
						num48 = 1767275218;
						num49 = 1767275218;
					}
					else
					{
						num48 = 471166595;
						num49 = 471166595;
					}
					num = num48 ^ ((int)num2 * -190308981);
					continue;
				}
				case 74u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 1591297807) ^ -904005031;
					continue;
				case 73u:
					switch (c2)
					{
					case '\t':
						break;
					case '\n':
					case '\r':
						goto IL_0080;
					case '\v':
					case '\f':
						goto IL_0506;
					default:
						goto IL_0858;
					}
					goto case 145u;
				case 72u:
					num = (int)(num2 * 898824389) ^ -1927039663;
					continue;
				case 71u:
				{
					int num44;
					int num45;
					if (flag14)
					{
						num44 = -1720712458;
						num45 = -1720712458;
					}
					else
					{
						num44 = -268569364;
						num45 = -268569364;
					}
					num = num44 ^ ((int)num2 * -1614844247);
					continue;
				}
				case 70u:
					num = (int)(num2 * 1857953880) ^ -7816688;
					continue;
				case 69u:
					num = ((int)num2 * -921130944) ^ 0x6BC227C8;
					continue;
				case 68u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1212694158) ^ 0x6F109D48);
					continue;
				case 67u:
					flag7 = JSONNode.smethod_6(text, "");
					num = 890780326;
					continue;
				case 66u:
					switch (c2)
					{
					case '[':
						break;
					case ']':
						goto IL_07c2;
					default:
						goto IL_0915;
					case '\\':
						goto IL_091f;
					}
					goto case 134u;
				case 6u:
					goto IL_091f;
				case 65u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1493408756) ^ -1924981567;
					continue;
				case 63u:
					num5 = 0;
					num = (int)((num2 * 319646875) ^ 0x642F4C8A);
					continue;
				case 62u:
					num = 1251641298;
					continue;
				case 61u:
					num = 1779374204;
					continue;
				case 60u:
					num = (int)(num2 * 1228417002) ^ -2010431748;
					continue;
				case 57u:
					num = ((int)num2 * -639583748) ^ -1458558933;
					continue;
				case 56u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -477633941) ^ -26065479;
					continue;
				case 55u:
					num = ((int)num2 * -1216973566) ^ -1314305904;
					continue;
				case 54u:
					flag = JSONNode.smethod_6(text2, "");
					num = 1664801993;
					continue;
				case 52u:
					flag13 = stack.Count == 0;
					num = 1133682949;
					continue;
				case 51u:
				{
					int num43;
					if (num5 < JSONNode.smethod_4(aJSON))
					{
						num = 1548730409;
						num43 = 1548730409;
					}
					else
					{
						num = 1609384463;
						num43 = 1609384463;
					}
					continue;
				}
				case 50u:
					num = 459921007;
					continue;
				case 49u:
				{
					int num42;
					if (c2 != '}')
					{
						num = 917556855;
						num42 = 917556855;
					}
					else
					{
						num = 581627178;
						num42 = 581627178;
					}
					continue;
				}
				case 48u:
					num = ((int)num2 * -1915306505) ^ 0x5A811F82;
					continue;
				case 47u:
					num = ((int)num2 * -1324119595) ^ 0x7083FD58;
					continue;
				case 46u:
					num = ((int)num2 * -1354199674) ^ -1664036709;
					continue;
				case 45u:
					num = ((int)num2 * -559444556) ^ 0x7B4B8EBC;
					continue;
				case 44u:
				{
					int num39;
					if (c2 == '"')
					{
						num = 1954538488;
						num39 = 1954538488;
					}
					else
					{
						num = 100322049;
						num39 = 100322049;
					}
					continue;
				}
				case 43u:
				{
					int num38;
					if (!flag2)
					{
						num = 1124089112;
						num38 = 1124089112;
					}
					else
					{
						num = 1091653121;
						num38 = 1091653121;
					}
					continue;
				}
				case 42u:
					text2 = "";
					text = "";
					num = ((int)num2 * -1379038743) ^ 0x45D1BDA4;
					continue;
				case 41u:
				{
					int num35;
					if (c2 != ' ')
					{
						num = 1860962784;
						num35 = 1860962784;
					}
					else
					{
						num = 1092878298;
						num35 = 1092878298;
					}
					continue;
				}
				case 40u:
				{
					int num32;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 763447177;
						num32 = 763447177;
					}
					else
					{
						num = 628143101;
						num32 = 628143101;
					}
					continue;
				}
				case 39u:
					num = (int)((num2 * 1814915936) ^ 0x44536E45);
					continue;
				case 38u:
				{
					int num28;
					int num29;
					if (!(jSONNode != null))
					{
						num28 = -433504174;
						num29 = -433504174;
					}
					else
					{
						num28 = -1666923504;
						num29 = -1666923504;
					}
					num = num28 ^ (int)(num2 * 1797167552);
					continue;
				}
				case 37u:
					c = c4;
					num = ((int)num2 * -2035437408) ^ -1203730398;
					continue;
				case 36u:
				{
					int num25;
					if (c2 == ',')
					{
						num = 1838904955;
						num25 = 1838904955;
					}
					else
					{
						num = 2096386815;
						num25 = 2096386815;
					}
					continue;
				}
				case 35u:
					jSONNode.Add(text2);
					num = ((int)num2 * -188587845) ^ -822075381;
					continue;
				case 34u:
				{
					char c3 = JSONNode.smethod_2(aJSON, num5);
					c2 = c3;
					num = 295080501;
					continue;
				}
				case 33u:
				{
					int num24;
					if (c == 'n')
					{
						num = 1262578759;
						num24 = 1262578759;
					}
					else
					{
						num = 474741070;
						num24 = 474741070;
					}
					continue;
				}
				case 32u:
					num = 1658126463;
					continue;
				case 31u:
				{
					string s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num5 += 4;
					num = ((int)num2 * -695735785) ^ -2142123429;
					continue;
				}
				case 30u:
					stack.Push(new JSONClass());
					num = 734115808;
					continue;
				case 29u:
				{
					int num22;
					int num23;
					if (flag11)
					{
						num22 = 2086613128;
						num23 = 2086613128;
					}
					else
					{
						num22 = 1728342716;
						num23 = 1728342716;
					}
					num = num22 ^ ((int)num2 * -587531668);
					continue;
				}
				case 28u:
				{
					int num20;
					int num21;
					if (c2 == ':')
					{
						num20 = -1853778281;
						num21 = -1853778281;
					}
					else
					{
						num20 = -116486870;
						num21 = -116486870;
					}
					num = num20 ^ (int)(num2 * 1898604254);
					continue;
				}
				case 27u:
					num = ((int)num2 * -1938004487) ^ -1951608837;
					continue;
				case 26u:
					num = ((int)num2 * -272407514) ^ 0x3FB0B4B5;
					continue;
				case 24u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1704357969) ^ -1819383274;
					continue;
				case 23u:
					num = (int)(num2 * 768626914) ^ -252842944;
					continue;
				case 22u:
					flag2 = false;
					num = ((int)num2 * -1380840645) ^ 0x57F63C59;
					continue;
				case 21u:
					num = ((int)num2 * -1829778430) ^ 0x42523E72;
					continue;
				case 20u:
				{
					int num16;
					int num17;
					if (flag8)
					{
						num16 = 368425180;
						num17 = 368425180;
					}
					else
					{
						num16 = 2009636482;
						num17 = 2009636482;
					}
					num = num16 ^ ((int)num2 * -167548731);
					continue;
				}
				case 19u:
				{
					int num14;
					int num15;
					if (!flag7)
					{
						num14 = -2016014112;
						num15 = -2016014112;
					}
					else
					{
						num14 = -322316279;
						num15 = -322316279;
					}
					num = num14 ^ ((int)num2 * -1663236467);
					continue;
				}
				case 18u:
				{
					int num10;
					int num11;
					if (!flag5)
					{
						num10 = 722719612;
						num11 = 722719612;
					}
					else
					{
						num10 = 852288348;
						num11 = 852288348;
					}
					num = num10 ^ ((int)num2 * -2016693048);
					continue;
				}
				case 17u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 2131553515) ^ 0x18F72FB5);
					continue;
				case 16u:
				{
					int num8;
					int num9;
					if (!flag3)
					{
						num8 = -388743946;
						num9 = -388743946;
					}
					else
					{
						num8 = -456189579;
						num9 = -456189579;
					}
					num = num8 ^ ((int)num2 * -317759153);
					continue;
				}
				case 15u:
					num = (int)((num2 * 2052659658) ^ 0x489F601D);
					continue;
				case 14u:
					result = jSONNode;
					num = 1122138384;
					continue;
				case 12u:
					num = ((int)num2 * -862890123) ^ 0x352F6ABB;
					continue;
				case 11u:
					stack.Push(new JSONArray());
					num = 1558154833;
					continue;
				case 10u:
					flag2 = !flag2;
					num = 587065516;
					continue;
				case 9u:
					num = ((int)num2 * -845088944) ^ 0x6B661AC0;
					continue;
				case 8u:
					num = ((int)num2 * -1236221933) ^ 0x78123BE9;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1096945892;
						num4 = 1096945892;
					}
					else
					{
						num3 = 899564830;
						num4 = 899564830;
					}
					num = num3 ^ (int)(num2 * 428242682);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1007959147) ^ -1981033377;
					continue;
				case 4u:
					num = (int)(num2 * 1564971669) ^ -1269076854;
					continue;
				case 3u:
					num = ((int)num2 * -1618881547) ^ -856030638;
					continue;
				case 2u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 699957254;
					continue;
				case 1u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1158726450) ^ 0xE61230D);
					continue;
				case 0u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1420408373) ^ -935869496;
					continue;
				case 135u:
					break;
				case 53u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 106u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0080:
					num5++;
					num = 1169471823;
					continue;
					IL_0506:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = 802637067;
					continue;
					IL_091f:
					num5++;
					num = 1856169441;
					continue;
					IL_0915:
					num = 2136146432;
					continue;
					IL_0858:
					num = ((int)num2 * -860563287) ^ -1861114778;
					continue;
					IL_07c2:
					if (flag2)
					{
						num = 1621401519;
						num50 = 1621401519;
					}
					else
					{
						num = 1624243349;
						num50 = 1624243349;
					}
					continue;
					IL_0156:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 380439639;
					continue;
					IL_013e:
					text2 = JSONNode.smethod_3(text2, c5.ToString());
					num = 380439639;
					continue;
					IL_016c:
					num = 533232390;
					continue;
					IL_0128:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 380439639;
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
				int num = -1717646498;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE5C32B58u) % 4u)
					{
					case 2u:
						SaveToStream(fileStream);
						num = ((int)num2 * -31431274) ^ 0x17D44F69;
						continue;
					case 1u:
						num = (int)(num2 * 929717494) ^ -1695827890;
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
					IL_00b5:
					int num3 = -2098780707;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE5C32B58u) % 4u)
						{
						case 2u:
							num3 = (int)((num2 * 1530006737) ^ 0x6B92215E);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -544805560) ^ 0x55BBDE96;
							continue;
						default:
							goto end_IL_0094;
						case 3u:
							break;
						case 0u:
							goto end_IL_0094;
						}
						goto IL_00b5;
						continue;
						end_IL_0094:
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
				int num = 1060765310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CE51D38u) % 5u)
					{
					case 4u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 1482737407) ^ 0x265E93C4);
						continue;
					case 2u:
						num = (int)((num2 * 1472856724) ^ 0x365201C);
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1210927552) ^ -703227563;
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
					int num3 = 235328788;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x2CE51D38u) % 3u)
						{
						case 1u:
							goto IL_0089;
						default:
							goto end_IL_009c;
						case 2u:
							break;
						case 0u:
							goto end_IL_009c;
						}
						goto IL_00b9;
						IL_0089:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = (int)(num2 * 822064171) ^ -1228802161;
						continue;
						end_IL_009c:
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
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num5 = default(int);
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		int num3 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -966491157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE525D36u) % 32u)
				{
				case 31u:
				{
					JSONBinaryTag jSONBinaryTag3 = jSONBinaryTag;
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -1103388304) ^ -458349568;
					continue;
				}
				case 30u:
					num5 = 0;
					num = (int)((num2 * 409067397) ^ 0x6A6B8521);
					continue;
				case 29u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -275851632) ^ -1477907399;
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 1708987733) ^ -1699020319;
					continue;
				case 26u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 78486900) ^ 0x3E78D07C);
					continue;
				case 25u:
					num = -546994390;
					continue;
				case 24u:
					num = (int)((num2 * 1455782953) ^ 0x2B45B9B5);
					continue;
				case 23u:
					num = (int)(num2 * 2101588313) ^ -1348456302;
					continue;
				case 22u:
					result = jSONArray;
					num = (int)((num2 * 637686217) ^ 0x31852EA8);
					continue;
				case 21u:
					result = jSONClass;
					num = ((int)num2 * -728240745) ^ 0x2169FB4E;
					continue;
				case 20u:
					goto IL_00e9;
				case 19u:
					jSONClass = new JSONClass();
					num3 = 0;
					num = (int)(num2 * 365153349) ^ -1244266135;
					continue;
				case 18u:
					goto IL_011e;
				case 17u:
					aKey = JSONNode.smethod_22(aReader);
					num = -306490088;
					continue;
				case 16u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -795908278) ^ 0x71C9678D;
					continue;
				case 15u:
					num = ((int)num2 * -727585365) ^ -800121096;
					continue;
				case 14u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1506962857) ^ -934651698;
					continue;
				case 13u:
					num = ((int)num2 * -510883321) ^ 0x3376E56;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1712619039;
						num10 = 1712619039;
					}
					else
					{
						num9 = 1286859291;
						num10 = 1286859291;
					}
					num = num9 ^ (int)(num2 * 1748668842);
					continue;
				}
				case 10u:
					goto IL_01c4;
				case 9u:
					goto IL_01db;
				case 8u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1736356000;
						num8 = 1736356000;
					}
					else
					{
						num7 = 1358239763;
						num8 = 1358239763;
					}
					num = num7 ^ ((int)num2 * -1772220352);
					continue;
				}
				case 7u:
					goto IL_021b;
				case 6u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.IntValue:
						break;
					case JSONBinaryTag.Array:
						goto IL_00e9;
					case JSONBinaryTag.Value:
						goto IL_011e;
					case JSONBinaryTag.BoolValue:
						goto IL_01c4;
					case JSONBinaryTag.FloatValue:
						goto IL_01db;
					case JSONBinaryTag.DoubleValue:
						goto IL_021b;
					default:
						goto IL_0256;
					case JSONBinaryTag.Class:
						goto IL_0266;
					}
					goto case 25u;
				case 3u:
					goto IL_0266;
				case 5u:
					jSONArray.Add(Deserialize(aReader));
					num5++;
					num = -283750953;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -2042923999) ^ 0x4FF9B8B4;
					continue;
				case 1u:
					flag2 = num5 < num6;
					num = -1200963042;
					continue;
				case 0u:
					flag = num3 < num4;
					num = -2034015270;
					continue;
				case 4u:
					break;
				case 11u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0266:
					num4 = JSONNode.smethod_21(aReader);
					num = -769868763;
					continue;
					IL_0256:
					num = ((int)num2 * -98474525) ^ -1845490837;
					continue;
					IL_021b:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -1920306079;
					continue;
					IL_01db:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -929885861;
					continue;
					IL_01c4:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -668944723;
					continue;
					IL_011e:
					num = -1845953434;
					continue;
					IL_00e9:
					num6 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = -479216952;
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
				int num = -636687538;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE098B230u) % 3u)
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
					result = Deserialize(binaryReader);
					num = (int)((num2 * 1175092341) ^ 0x5A34F366);
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
					int num3 = -922037594;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE098B230u) % 3u)
						{
						case 1u:
							goto IL_0049;
						default:
							goto end_IL_005c;
						case 0u:
							break;
						case 2u:
							goto end_IL_005c;
						}
						goto IL_0079;
						IL_0049:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = ((int)num2 * -1023362101) ^ -358146331;
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
			return LoadFromStream(fileStream);
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0045:
					int num = -460418612;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xB5071E33u) % 3u)
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
						num = ((int)num2 * -555843596) ^ 0x358F968F;
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
			int num = -872621065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED52284Du) % 7u)
				{
				case 6u:
					num = (int)((num2 * 1099745807) ^ 0x63BA145D);
					continue;
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)(num2 * 1563306685) ^ -498581125;
					continue;
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)((num2 * 231340341) ^ 0x6727EB75);
					continue;
				case 3u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 991157545) ^ 0x3EAF2600);
					continue;
				case 2u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1542084732) ^ -815059061;
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
