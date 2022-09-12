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
				int num = -1857036681;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEEE69C79u) % 3u)
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
					num = (int)(num2 * 73398588) ^ -1417260769;
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
			string result = "";
			while (true)
			{
				int num = -614526954;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0ADDF4Bu) % 3u)
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
					num = (int)(num2 * 1029229558) ^ -22935620;
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
				int num = 429766113;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73A548u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1431679125) ^ -336185558;
						continue;
					case 1u:
						result = 0;
						num = (int)((num2 * 1191818313) ^ 0x76968D9B);
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
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 1870120238;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42A8FE49u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -962529853) ^ 0x126E627C;
				}
			}
		}
	}

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			while (true)
			{
				int num = 1795585319;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBFC8DC9u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_DeepChilds_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -605422716) ^ 0x603A75F3;
				}
			}
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
				int num = 138731137;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x112E8BEFu) % 9u)
					{
					case 8u:
						num = ((int)num2 * -705574720) ^ -1323798331;
						continue;
					case 7u:
						result = 0;
						num = 543928522;
						continue;
					case 6u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -1450446351) ^ 0x1D11DC5;
						continue;
					case 4u:
						num = ((int)num2 * -204791051) ^ 0x4CA821AC;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1162409704;
							num4 = -1162409704;
						}
						else
						{
							num3 = -876932306;
							num4 = -876932306;
						}
						num = num3 ^ ((int)num2 * -572585319);
						continue;
					}
					case 2u:
						result2 = 0;
						num = (int)((num2 * 965336052) ^ 0x457B35FA);
						continue;
					case 1u:
						result = result2;
						num = (int)(num2 * 1027320469) ^ -1260679451;
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
			while (true)
			{
				int num = -1810545715;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD979C3Fu) % 3u)
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
					num = (int)((num2 * 1307039283) ^ 0x2618DCC1);
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
			while (true)
			{
				int num = 1774150798;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3333BD43u) % 6u)
					{
					case 5u:
						result = result2;
						num = ((int)num2 * -1225880728) ^ 0xAD9007D;
						continue;
					case 3u:
						num = ((int)num2 * -167432429) ^ -1272580024;
						continue;
					case 1u:
					{
						result2 = 0f;
						int num3;
						int num4;
						if (!float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = 991380678;
							num4 = 991380678;
						}
						else
						{
							num3 = 1498672419;
							num4 = 1498672419;
						}
						num = num3 ^ (int)(num2 * 1343925925);
						continue;
					}
					case 0u:
						result = 0f;
						num = 681355916;
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
				int num = 1540519551;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4CE47B33u) % 3u)
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
					num = ((int)num2 * -1828703464) ^ -1757721124;
				}
			}
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
				int num = -1751341881;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x922C7051u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -804684013;
							num4 = -804684013;
						}
						else
						{
							num3 = -1290690139;
							num4 = -1290690139;
						}
						num = num3 ^ (int)(num2 * 550647965);
						continue;
					}
					case 4u:
						result2 = 0.0;
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -73300930) ^ -1082300042;
						continue;
					case 3u:
						num = (int)(num2 * 252912787) ^ -519903679;
						continue;
					case 2u:
						result = 0.0;
						num = -320262469;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1787691612) ^ -1501347541;
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
			bool result = default(bool);
			while (true)
			{
				int num = -1695267074;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F38D09Du) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = 1866190885;
							num4 = 1866190885;
						}
						else
						{
							num3 = 1729110972;
							num4 = 1729110972;
						}
						num = num3 ^ (int)(num2 * 684087678);
						continue;
					}
					case 3u:
						result = !JSONNode.smethod_1(Value);
						num = -1548917563;
						continue;
					case 2u:
						num = ((int)num2 * -1155427374) ^ -791631297;
						continue;
					case 1u:
						result2 = false;
						num = (int)(num2 * 1233689710) ^ -1491636804;
						continue;
					case 0u:
						result = result2;
						num = (int)(num2 * 1081783435) ^ -1966518794;
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
			while (true)
			{
				int num = -946974533;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF24A3F29u) % 4u)
					{
					case 2u:
						Value = (value ? "true" : "false");
						num = -2103008272;
						continue;
					case 1u:
						num = (int)((num2 * 2051768973) ^ 0x6E6D76CB);
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
			JSONArray result = this as JSONArray;
			while (true)
			{
				int num = 149444953;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2A4B65Fu) % 3u)
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
					num = ((int)num2 * -1592668897) ^ -1363160518;
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
				int num = -539878750;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E1A97A1u) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = ((int)num2 * -832759812) ^ -1820962435;
						continue;
					case 0u:
						num = (int)((num2 * 963663066) ^ 0x177A19B0);
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
		Add("", aItem);
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1851425418;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C134A97u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 226763421) ^ 0x147FA7A);
					continue;
				case 1u:
					result = null;
					num = (int)((num2 * 1536051406) ^ 0x708CA35E);
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
			int num = 144956531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3C824A8Eu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -326524030) ^ 0x6C48A44C;
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -235282292) ^ -1120534895;
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

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -905220156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB879A0Au) % 3u)
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
				num = ((int)num2 * -1315437915) ^ 0x4FC31488;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 14187349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3504CF23u) % 3u)
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
				num = (int)((num2 * 878051720) ^ 0x464EEE30);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		return "JSONNode";
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = new JSONData(s);
		while (true)
		{
			int num = -481524329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8FF209Au) % 3u)
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
				num = ((int)num2 * -1132602255) ^ 0x2ABED0CB;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		if (!(d == null))
		{
			goto IL_000c;
		}
		object obj = null;
		goto IL_0032;
		IL_002c:
		obj = d.Value;
		goto IL_0032;
		IL_000c:
		int num = -772020409;
		goto IL_0011;
		IL_0011:
		string result = default(string);
		switch ((uint)(num ^ -1296576402) % 3u)
		{
		case 0u:
			break;
		case 1u:
			goto IL_002c;
		default:
			return result;
		}
		goto IL_000c;
		IL_0032:
		result = (string)obj;
		num = -855058256;
		goto IL_0011;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -808946100;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xE7F282C4u) % 9u)
				{
				case 7u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_000f;
				case 5u:
					num = ((int)num2 * -1217155889) ^ -106432020;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1851098296;
						num5 = 1851098296;
					}
					else
					{
						num4 = 684359392;
						num5 = 684359392;
					}
					num = num4 ^ ((int)num2 * -909100198);
					continue;
				}
				case 3u:
					result = (object)a == b;
					num = -1138185652;
					continue;
				case 2u:
					result = true;
					num = ((int)num2 * -1715392215) ^ -1943956348;
					continue;
				case 1u:
					if (b == null)
					{
						num = (int)((num2 * 1701902960) ^ 0x6066D251);
						continue;
					}
					num3 = 0;
					goto IL_000f;
				case 0u:
					num = ((int)num2 * -582838982) ^ 0x48F55428;
					continue;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_000f:
					flag = (byte)num3 != 0;
					num = -1919018383;
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
			int num = 1520188576;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54224E37u) % 3u)
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
				result = !(a == b);
				num = (int)((num2 * 2002765159) ^ 0x2003EC9);
			}
		}
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
			int num = -427533057;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9E71732u) % 4u)
				{
				case 1u:
					result = this.method_0();
					num = (int)((num2 * 1577585136) ^ 0x7F5AEB26);
					continue;
				case 0u:
					num = ((int)num2 * -413456097) ^ -449053028;
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
		char c2 = default(char);
		char c = default(char);
		char c3 = default(char);
		string string_ = default(string);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -133185578;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF572D165u) % 35u)
				{
				case 34u:
					num = ((int)num2 * -581420455) ^ -117313326;
					continue;
				case 33u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -943832357;
					continue;
				case 32u:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -322347756;
					continue;
				case 30u:
					num = ((int)num2 * -1366444234) ^ -1367993093;
					continue;
				case 29u:
					goto IL_005a;
				case 28u:
					c = c3;
					switch (c)
					{
					case '\v':
						break;
					case '\b':
						goto IL_005a;
					default:
						goto IL_0095;
					case '\t':
						goto IL_00a8;
					case '\n':
						goto IL_00be;
					case '\f':
						goto IL_00d4;
					case '\r':
						goto IL_00ea;
					}
					goto case 32u;
				case 14u:
					goto IL_00a8;
				case 9u:
					goto IL_00be;
				case 19u:
					goto IL_00d4;
				case 2u:
					goto IL_00ea;
				case 27u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = -780922080;
					continue;
				case 26u:
					num = (int)((num2 * 1627756754) ^ 0x7B871686);
					continue;
				case 25u:
					num = ((int)num2 * -1031670427) ^ 0x26C6BAA4;
					continue;
				case 24u:
					num4++;
					num = ((int)num2 * -214114105) ^ 0x7727776D;
					continue;
				case 23u:
					c3 = c2;
					num = ((int)num2 * -1541911369) ^ -877265743;
					continue;
				case 22u:
					result = text;
					num = ((int)num2 * -369725445) ^ 0x31295217;
					continue;
				case 21u:
					num = (int)((num2 * 1390767745) ^ 0x4A612606);
					continue;
				case 20u:
					num = (int)(num2 * 1176884321) ^ -318777204;
					continue;
				case 18u:
					num = (int)(num2 * 530870677) ^ -490723450;
					continue;
				case 17u:
					num = (int)((num2 * 322463186) ^ 0x6CE69FB4);
					continue;
				case 16u:
					num = (int)((num2 * 10598398) ^ 0x20285746);
					continue;
				case 15u:
					num = ((int)num2 * -1430517185) ^ 0x457F3FA7;
					continue;
				case 13u:
					num = ((int)num2 * -123881363) ^ -836879344;
					continue;
				case 12u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1774072877;
					continue;
				case 11u:
					num = (int)((num2 * 1054369107) ^ 0x4A0D1AF2);
					continue;
				case 10u:
				{
					int num6;
					if (num4 < JSONNode.smethod_4(string_))
					{
						num = -1182322540;
						num6 = -1182322540;
					}
					else
					{
						num = -862501021;
						num6 = -862501021;
					}
					continue;
				}
				case 8u:
					num = -134912546;
					continue;
				case 7u:
					text = "";
					num = (int)(num2 * 117387691) ^ -268273368;
					continue;
				case 6u:
				{
					int num5;
					if (c != '"')
					{
						num = -2042751464;
						num5 = -2042751464;
					}
					else
					{
						num = -2094635973;
						num5 = -2094635973;
					}
					continue;
				}
				case 5u:
					num = (int)((num2 * 1981704480) ^ 0x7D2EA361);
					continue;
				case 4u:
					num4 = 0;
					num = (int)((num2 * 107780320) ^ 0xEB95150);
					continue;
				case 3u:
					string_ = aText;
					num = (int)(num2 * 1290376987) ^ -1532751091;
					continue;
				case 1u:
				{
					int num3;
					if (c != '\\')
					{
						num = -1334835332;
						num3 = -1334835332;
					}
					else
					{
						num = -164819469;
						num3 = -164819469;
					}
					continue;
				}
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0095:
					num = ((int)num2 * -1908139855) ^ -59514716;
					continue;
					IL_005a:
					text = JSONNode.smethod_3(text, "\\b");
					num = -253025780;
					continue;
					IL_00ea:
					text = JSONNode.smethod_3(text, "\\r");
					num = -472901571;
					continue;
					IL_00d4:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1864317336;
					continue;
					IL_00be:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1206839845;
					continue;
					IL_00a8:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1108731903;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		bool flag10 = default(bool);
		string text2 = default(string);
		string text = default(string);
		bool flag5 = default(bool);
		char c2 = default(char);
		int num10 = default(int);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		char c = default(char);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		char c3 = default(char);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag6 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1731292063;
			while (true)
			{
				uint num2;
				int num24;
				int num25;
				int num32;
				switch ((num2 = (uint)num ^ 0xAAFE7C55u) % 146u)
				{
				case 145u:
				{
					int num48;
					int num49;
					if (flag10)
					{
						num48 = -2013660576;
						num49 = -2013660576;
					}
					else
					{
						num48 = -525615532;
						num49 = -525615532;
					}
					num = num48 ^ ((int)num2 * -752159806);
					continue;
				}
				case 144u:
					text2 = "";
					text = "";
					num = -1535381151;
					continue;
				case 143u:
					flag5 = JSONNode.smethod_6(text, "");
					num = -944684550;
					continue;
				case 142u:
					num = (int)(num2 * 86678230) ^ -129912323;
					continue;
				case 141u:
					num = (int)(num2 * 826649246) ^ -416032040;
					continue;
				case 140u:
					num = (int)(num2 * 154305043) ^ -185796077;
					continue;
				case 139u:
					text2 = "";
					num = (int)(num2 * 16618858) ^ -1556054519;
					continue;
				case 138u:
				{
					int num31;
					if (c2 != 'f')
					{
						num = -822260558;
						num31 = -822260558;
					}
					else
					{
						num = -595947571;
						num31 = -595947571;
					}
					continue;
				}
				case 57u:
				case 58u:
				case 69u:
				case 82u:
				case 137u:
					num10++;
					num = -1048428906;
					continue;
				case 136u:
					num = (int)(num2 * 948007059) ^ -944732541;
					continue;
				case 135u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 504793128) ^ -598182977;
					continue;
				case 134u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 410753920) ^ -835062483;
					continue;
				case 133u:
				{
					int num54;
					int num55;
					if (JSONNode.smethod_6(text, ""))
					{
						num54 = 1268373014;
						num55 = 1268373014;
					}
					else
					{
						num54 = 1683486713;
						num55 = 1683486713;
					}
					num = num54 ^ (int)(num2 * 653183643);
					continue;
				}
				case 132u:
				{
					int num39;
					int num40;
					if ((uint)c <= 32u)
					{
						num39 = 361646110;
						num40 = 361646110;
					}
					else
					{
						num39 = 1525914496;
						num40 = 1525914496;
					}
					num = num39 ^ ((int)num2 * -1073346205);
					continue;
				}
				case 131u:
					switch (c)
					{
					case '[':
						goto IL_01a6;
					case '\\':
						goto IL_01c6;
					case ']':
						goto IL_01ea;
					}
					num = -1205816989;
					continue;
				case 60u:
					goto IL_01a6;
				case 45u:
					goto IL_01c6;
				case 91u:
					goto IL_01ea;
				case 130u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 12069783) ^ -787859000;
					continue;
				case 129u:
					num = ((int)num2 * -1105946513) ^ -311831843;
					continue;
				case 128u:
					num = -355768335;
					continue;
				case 127u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1816878457;
						num6 = 1816878457;
					}
					else
					{
						num5 = 67769020;
						num6 = 67769020;
					}
					num = num5 ^ ((int)num2 * -119553537);
					continue;
				}
				case 126u:
				{
					int num56;
					if (!flag3)
					{
						num = -161576136;
						num56 = -161576136;
					}
					else
					{
						num = -126137110;
						num56 = -126137110;
					}
					continue;
				}
				case 125u:
					num = ((int)num2 * -1913524971) ^ 0x341598B1;
					continue;
				case 124u:
					num = (int)(num2 * 1587352736) ^ -829616566;
					continue;
				case 123u:
				{
					int num45;
					int num46;
					if (!(jSONNode != null))
					{
						num45 = -1027965856;
						num46 = -1027965856;
					}
					else
					{
						num45 = -1616377738;
						num46 = -1616377738;
					}
					num = num45 ^ (int)(num2 * 2045231142);
					continue;
				}
				case 122u:
					num = (int)((num2 * 1423893511) ^ 0x77D53670);
					continue;
				case 121u:
					num = ((int)num2 * -795039630) ^ -1304400471;
					continue;
				case 120u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)((num2 * 229070593) ^ 0x2A6E4DEC);
					continue;
				case 119u:
					text = JSONNode.smethod_3(text, "\r");
					num = -390451050;
					continue;
				case 118u:
					stack.Push(new JSONClass());
					num = -1833664330;
					continue;
				case 117u:
				{
					char c5 = c3;
					c2 = c5;
					int num36;
					int num37;
					if ((uint)c2 <= 102u)
					{
						num36 = 517649678;
						num37 = 517649678;
					}
					else
					{
						num36 = 605625030;
						num37 = 605625030;
					}
					num = num36 ^ ((int)num2 * -1012149608);
					continue;
				}
				case 116u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 702313294) ^ 0x79BB84D2);
					continue;
				case 115u:
					num = (int)(num2 * 786650532) ^ -1174586427;
					continue;
				case 114u:
					flag3 = false;
					num = ((int)num2 * -1868985173) ^ 0x4EB180F0;
					continue;
				case 113u:
					flag3 = !flag3;
					num = -988116489;
					continue;
				case 112u:
					goto IL_03e5;
				case 111u:
				{
					stack.Push(new JSONArray());
					int num28;
					if (!(jSONNode != null))
					{
						num = -777329349;
						num28 = -777329349;
					}
					else
					{
						num = -1368919469;
						num28 = -1368919469;
					}
					continue;
				}
				case 110u:
					c3 = JSONNode.smethod_2(aJSON, num10);
					num = ((int)num2 * -2009986983) ^ -1363596040;
					continue;
				case 109u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -789942692) ^ 0x7B13BE34;
					continue;
				case 108u:
				{
					int num22;
					int num23;
					if (jSONNode is JSONArray)
					{
						num22 = -1005652576;
						num23 = -1005652576;
					}
					else
					{
						num22 = -1487206416;
						num23 = -1487206416;
					}
					num = num22 ^ ((int)num2 * -1756289566);
					continue;
				}
				case 107u:
				{
					int num17;
					int num18;
					if (flag7)
					{
						num17 = 1841141010;
						num18 = 1841141010;
					}
					else
					{
						num17 = 708802404;
						num18 = 708802404;
					}
					num = num17 ^ ((int)num2 * -1895929625);
					continue;
				}
				case 106u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -551907419) ^ 0x54A1C510;
					continue;
				case 105u:
				{
					int num12;
					int num13;
					if (!flag3)
					{
						num12 = 257411854;
						num13 = 257411854;
					}
					else
					{
						num12 = 2082107239;
						num13 = 2082107239;
					}
					num = num12 ^ ((int)num2 * -780584038);
					continue;
				}
				case 104u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = -235700613;
					continue;
				case 103u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -552940805) ^ -1887915048;
					continue;
				case 102u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1098015572;
					continue;
				case 100u:
					num = (int)((num2 * 1931646371) ^ 0x74204849);
					continue;
				case 99u:
					num = ((int)num2 * -1970212986) ^ 0x7598A8AE;
					continue;
				case 98u:
					num = ((int)num2 * -720063770) ^ -1920053055;
					continue;
				case 97u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -694548669) ^ -659173783;
					continue;
				case 96u:
					num = (int)(num2 * 1512875955) ^ -1704177477;
					continue;
				case 95u:
					goto IL_05d9;
				case 94u:
				{
					int num57;
					int num58;
					if (!(jSONNode is JSONArray))
					{
						num57 = -420168085;
						num58 = -420168085;
					}
					else
					{
						num57 = -1958577753;
						num58 = -1958577753;
					}
					num = num57 ^ (int)(num2 * 317100074);
					continue;
				}
				case 93u:
					num = -1445577858;
					continue;
				case 92u:
					num = (int)((num2 * 420724279) ^ 0x7033C189);
					continue;
				case 90u:
					num = -916434235;
					continue;
				case 89u:
					text2 = "";
					num = -193317375;
					continue;
				case 88u:
					jSONNode.Add(text);
					num = ((int)num2 * -174428021) ^ -192975982;
					continue;
				case 87u:
					flag9 = jSONNode is JSONArray;
					num = ((int)num2 * -1400510222) ^ 0xC8237CE;
					continue;
				case 86u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -2043167472;
					continue;
				case 85u:
				{
					int num52;
					int num53;
					if (c2 != 'b')
					{
						num52 = -952142400;
						num53 = -952142400;
					}
					else
					{
						num52 = -558670695;
						num53 = -558670695;
					}
					num = num52 ^ ((int)num2 * -1557518406);
					continue;
				}
				case 84u:
					text = JSONNode.smethod_3(text, "\f");
					num = -1942928907;
					continue;
				case 83u:
				{
					int num50;
					int num51;
					if (c != ':')
					{
						num50 = 1021856563;
						num51 = 1021856563;
					}
					else
					{
						num50 = 1615085649;
						num51 = 1615085649;
					}
					num = num50 ^ (int)(num2 * 1925410472);
					continue;
				}
				case 81u:
					num = -702892590;
					continue;
				case 80u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1037252534) ^ 0x5B2B41E6);
					continue;
				case 79u:
					num = (int)((num2 * 241185822) ^ 0x691DFA77);
					continue;
				case 78u:
				{
					int num47;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -1565700870;
						num47 = -1565700870;
					}
					else
					{
						num = -570559429;
						num47 = -570559429;
					}
					continue;
				}
				case 77u:
					num = (int)((num2 * 1703562488) ^ 0x28153738);
					continue;
				case 75u:
				{
					int num44;
					if (c2 != 'n')
					{
						num = -1997117867;
						num44 = -1997117867;
					}
					else
					{
						num = -415552697;
						num44 = -415552697;
					}
					continue;
				}
				case 74u:
					num = (int)((num2 * 42357975) ^ 0x2E6A30C9);
					continue;
				case 73u:
				{
					string s = JSONNode.smethod_8(aJSON, num10 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num10 += 4;
					num = (int)(num2 * 1410392353) ^ -83053546;
					continue;
				}
				case 72u:
				{
					int num43;
					if (c != '}')
					{
						num = -2055603825;
						num43 = -2055603825;
					}
					else
					{
						num = -1493355096;
						num43 = -1493355096;
					}
					continue;
				}
				case 71u:
					num = (int)(num2 * 640867499) ^ -1280885317;
					continue;
				case 70u:
				{
					int num41;
					int num42;
					if (flag8)
					{
						num41 = -1686458841;
						num42 = -1686458841;
					}
					else
					{
						num41 = -788412191;
						num42 = -788412191;
					}
					num = num41 ^ (int)(num2 * 501669255);
					continue;
				}
				case 68u:
				{
					int num38;
					if (stack.Count == 0)
					{
						num = -180450741;
						num38 = -180450741;
					}
					else
					{
						num = -1489337882;
						num38 = -1489337882;
					}
					continue;
				}
				case 67u:
					num = -777329349;
					continue;
				case 66u:
					num = ((int)num2 * -89729884) ^ -1634270833;
					continue;
				case 65u:
					text2 = text;
					num = -776389168;
					continue;
				case 63u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -164311323) ^ 0x45D2BA30;
					continue;
				case 62u:
					num = ((int)num2 * -938523844) ^ -194687336;
					continue;
				case 61u:
				{
					int num35;
					if ((uint)c > 93u)
					{
						num = -1021703401;
						num35 = -1021703401;
					}
					else
					{
						num = -961767136;
						num35 = -961767136;
					}
					continue;
				}
				case 59u:
					goto IL_090c;
				case 56u:
				{
					char c4 = JSONNode.smethod_2(aJSON, num10);
					c = c4;
					int num33;
					int num34;
					if ((uint)c <= 44u)
					{
						num33 = -1382434095;
						num34 = -1382434095;
					}
					else
					{
						num33 = -268501794;
						num34 = -268501794;
					}
					num = num33 ^ ((int)num2 * -779397412);
					continue;
				}
				case 55u:
					stack.Pop();
					num = -699579696;
					continue;
				case 54u:
					num = ((int)num2 * -1340903837) ^ 0xB50BA08;
					continue;
				case 53u:
					result = jSONNode;
					num = -1112585952;
					continue;
				case 52u:
					goto IL_097f;
				case 51u:
					num = (int)((num2 * 1163003343) ^ 0x214C634C);
					continue;
				case 50u:
					num = ((int)num2 * -1967184627) ^ -1281055637;
					continue;
				case 49u:
					flag10 = num10 < JSONNode.smethod_4(aJSON);
					num = -326343556;
					continue;
				case 48u:
					num = ((int)num2 * -1227914669) ^ 0x2A3A92CC;
					continue;
				case 47u:
					flag7 = flag3;
					num = -1736607238;
					continue;
				case 46u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)((num2 * 1261055363) ^ 0x11962965);
					continue;
				case 44u:
				{
					int num29;
					int num30;
					if (flag6)
					{
						num29 = -947133935;
						num30 = -947133935;
					}
					else
					{
						num29 = -1492021409;
						num30 = -1492021409;
					}
					num = num29 ^ (int)(num2 * 1225519562);
					continue;
				}
				case 43u:
					jSONNode = null;
					num10 = 0;
					text = "";
					num = ((int)num2 * -187621495) ^ 0xDDA3EEB;
					continue;
				case 42u:
					num = (int)((num2 * 1087068187) ^ 0xB028FF4);
					continue;
				case 41u:
					num = -1130458793;
					continue;
				case 40u:
					num = (int)(num2 * 742867163) ^ -521773381;
					continue;
				case 39u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -3016066) ^ 0x47C92978;
					continue;
				case 38u:
					text = "";
					num = ((int)num2 * -1365261498) ^ 0xB326E44;
					continue;
				case 37u:
				{
					int num26;
					int num27;
					if (flag9)
					{
						num26 = 153292023;
						num27 = 153292023;
					}
					else
					{
						num26 = 1632253285;
						num27 = 1632253285;
					}
					num = num26 ^ (int)(num2 * 810291376);
					continue;
				}
				case 36u:
					num = ((int)num2 * -325312823) ^ 0x30726522;
					continue;
				case 35u:
					goto IL_0b0d;
				case 33u:
					num = ((int)num2 * -1735091309) ^ 0x587A5DB3;
					continue;
				case 32u:
					text = "";
					flag = stack.Count > 0;
					num = (int)(num2 * 123742541) ^ -1819821959;
					continue;
				case 31u:
					num = ((int)num2 * -1105502175) ^ 0x5F8F6970;
					continue;
				case 30u:
					num = ((int)num2 * -1667496357) ^ -1282061957;
					continue;
				case 29u:
				{
					int num20;
					int num21;
					if (!flag5)
					{
						num20 = 410859915;
						num21 = 410859915;
					}
					else
					{
						num20 = 948808684;
						num21 = 948808684;
					}
					num = num20 ^ ((int)num2 * -231714394);
					continue;
				}
				case 28u:
					num = (int)(num2 * 517098309) ^ -2108574997;
					continue;
				case 27u:
					flag2 = JSONNode.smethod_6(text2, "");
					num = -859814156;
					continue;
				case 26u:
				{
					int num19;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -490350967;
						num19 = -490350967;
					}
					else
					{
						num = -1810390154;
						num19 = -1810390154;
					}
					continue;
				}
				case 25u:
					text2 = "";
					num = -1781258839;
					continue;
				case 24u:
				{
					int num16;
					if (c == ' ')
					{
						num = -1473581712;
						num16 = -1473581712;
					}
					else
					{
						num = -28100659;
						num16 = -28100659;
					}
					continue;
				}
				case 23u:
					num = (int)(num2 * 951322278) ^ -1047939119;
					continue;
				case 22u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -227291309) ^ -173175710;
					continue;
				case 21u:
					num = (int)((num2 * 579416470) ^ 0x19698389);
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, "\n");
					num = -400729910;
					continue;
				case 19u:
					num = (int)((num2 * 380830581) ^ 0x541AF8E7);
					continue;
				case 18u:
					text2 = JSONNode.smethod_5(text2);
					flag6 = jSONNode is JSONArray;
					num = (int)(num2 * 784915345) ^ -938720051;
					continue;
				case 17u:
					num = (int)((num2 * 446868970) ^ 0x76B6B35D);
					continue;
				case 16u:
				{
					int num14;
					int num15;
					if (!flag4)
					{
						num14 = -644251586;
						num15 = -644251586;
					}
					else
					{
						num14 = -1089431195;
						num15 = -1089431195;
					}
					num = num14 ^ (int)(num2 * 631042158);
					continue;
				}
				case 15u:
				{
					int num11;
					if (c == '"')
					{
						num = -1698947090;
						num11 = -1698947090;
					}
					else
					{
						num = -1125625644;
						num11 = -1125625644;
					}
					continue;
				}
				case 14u:
					jSONNode.Add(text);
					num = (int)((num2 * 1248017746) ^ 0xCCC0441);
					continue;
				case 13u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_097f;
					case '\t':
						goto IL_0b0d;
					default:
						goto IL_0d65;
					}
					goto case 57u;
				case 12u:
					num = (int)(num2 * 152232321) ^ -944065234;
					continue;
				case 11u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -804782798) ^ 0x1F489FA6;
					continue;
				case 10u:
					switch (c2)
					{
					case 'r':
						break;
					case 's':
						goto IL_03e5;
					case 't':
						goto IL_05d9;
					case 'u':
						goto IL_090c;
					default:
						goto IL_0dcf;
					}
					goto case 119u;
				case 9u:
					num = ((int)num2 * -653375431) ^ 0x7BC9D1BA;
					continue;
				case 8u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1320178283) ^ -1794772025;
					continue;
				case 7u:
					text = "";
					num = (int)((num2 * 1204582845) ^ 0x3255191A);
					continue;
				case 6u:
					num = ((int)num2 * -368187845) ^ 0x2F7561DD;
					continue;
				case 5u:
				{
					int num9;
					if (flag3)
					{
						num = -1028518357;
						num9 = -1028518357;
					}
					else
					{
						num = -753547032;
						num9 = -753547032;
					}
					continue;
				}
				case 4u:
				{
					int num8;
					if (c == '{')
					{
						num = -2105099624;
						num8 = -2105099624;
					}
					else
					{
						num = -730783095;
						num8 = -730783095;
					}
					continue;
				}
				case 3u:
					num = ((int)num2 * -1358221783) ^ 0x5D52B9E4;
					continue;
				case 2u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 174297571) ^ 0x345F0B70);
					continue;
				case 1u:
				{
					int num7;
					if (c != ',')
					{
						num = -663967263;
						num7 = -663967263;
					}
					else
					{
						num = -95114276;
						num7 = -95114276;
					}
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1801762302;
						num4 = 1801762302;
					}
					else
					{
						num3 = 1739674023;
						num4 = 1739674023;
					}
					num = num3 ^ ((int)num2 * -2063343813);
					continue;
				}
				case 101u:
					break;
				case 34u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 76u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_05d9:
					text = JSONNode.smethod_3(text, "\t");
					num = -1060283670;
					continue;
					IL_0dcf:
					num = -1982740711;
					continue;
					IL_0d65:
					num = ((int)num2 * -2034620123) ^ 0x3D0DDAE2;
					continue;
					IL_01ea:
					flag8 = flag3;
					num = -906200227;
					continue;
					IL_0b0d:
					if (!flag3)
					{
						num = -398988764;
						num24 = -398988764;
					}
					else
					{
						num = -2002058692;
						num24 = -2002058692;
					}
					continue;
					IL_01c6:
					num10++;
					if (flag3)
					{
						num = -1075110044;
						num25 = -1075110044;
					}
					else
					{
						num = -916434235;
						num25 = -916434235;
					}
					continue;
					IL_03e5:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -126300469;
					continue;
					IL_01a6:
					if (flag3)
					{
						num = -1142194719;
						num32 = -1142194719;
					}
					else
					{
						num = -234232130;
						num32 = -234232130;
					}
					continue;
					IL_097f:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = -2043167472;
					continue;
					IL_090c:
					num = -1372668186;
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
			int num = 339378026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72D83460u) % 3u)
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
				BinaryWriter aWriter = JSONNode.smethod_9(aData);
				Serialize(aWriter);
				num = ((int)num2 * -1633727864) ^ -1623755089;
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
				int num = 1512081245;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x27A216B9u) % 3u)
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
					num = ((int)num2 * -1748808796) ^ 0x799944DB;
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
					int num3 = 27948004;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x27A216B9u) % 4u)
						{
						case 3u:
							num3 = ((int)num2 * -174691039) ^ -2094919040;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -610528355) ^ 0x1609BC47;
							continue;
						default:
							goto end_IL_0080;
						case 0u:
							break;
						case 2u:
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
			string result = default(string);
			while (true)
			{
				int num = 580714152;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AB3342Bu) % 6u)
					{
					case 5u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -852789725) ^ -419044090;
						continue;
					case 4u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 856681276) ^ -978432779;
						continue;
					case 2u:
						num = (int)(num2 * 1747547104) ^ -28345714;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -739060205) ^ -797089744;
						continue;
					case 3u:
						break;
					default:
						return result;
					case 0u:
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
					int num3 = 1823125961;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x2AB3342Bu) % 3u)
						{
						case 1u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 2u:
							break;
						case 0u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -693094888) ^ -1044028057;
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
		bool flag = default(bool);
		int num7 = default(int);
		int num4 = default(int);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num5 = default(int);
		JSONNode aItem = default(JSONNode);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		string aKey = default(string);
		JSONClass jSONClass = default(JSONClass);
		JSONArray jSONArray = default(JSONArray);
		int num3 = default(int);
		while (true)
		{
			int num = 71365071;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0DA056u) % 38u)
				{
				case 37u:
					num = ((int)num2 * -551896292) ^ 0x203207AB;
					continue;
				case 35u:
					flag = num7 < num4;
					num = 1313194109;
					continue;
				case 34u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -1626432140) ^ -1141875750;
					continue;
				case 33u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)((num2 * 226973200) ^ 0x1EFCAFDD);
					continue;
				case 32u:
					num5 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1552814678) ^ -507402327;
					continue;
				case 31u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1129845055;
						num9 = -1129845055;
					}
					else
					{
						num8 = -2093855611;
						num9 = -2093855611;
					}
					num = num8 ^ (int)(num2 * 1639235131);
					continue;
				}
				case 30u:
					aItem = Deserialize(aReader);
					num = (int)((num2 * 657280038) ^ 0x29F1BD50);
					continue;
				case 29u:
					num = 17521954;
					continue;
				case 28u:
					num = (int)(num2 * 832372519) ^ -1979431793;
					continue;
				case 27u:
					num = (int)((num2 * 1829813653) ^ 0x7967BBAE);
					continue;
				case 26u:
					goto IL_00f3;
				case 25u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.IntValue:
						goto IL_00f3;
					default:
						goto IL_0130;
					case JSONBinaryTag.Array:
						goto IL_0143;
					case JSONBinaryTag.Value:
						goto IL_014d;
					case JSONBinaryTag.DoubleValue:
						goto IL_0157;
					case JSONBinaryTag.BoolValue:
						goto IL_016e;
					case JSONBinaryTag.FloatValue:
						goto IL_0185;
					}
					goto case 29u;
				case 12u:
					goto IL_0143;
				case 7u:
					goto IL_014d;
				case 16u:
					goto IL_0157;
				case 4u:
					goto IL_016e;
				case 1u:
					goto IL_0185;
				case 24u:
					num7 = 0;
					num = ((int)num2 * -432604320) ^ 0x9FC6BDF;
					continue;
				case 23u:
					num = ((int)num2 * -1472772327) ^ 0x112DE4A4;
					continue;
				case 22u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1383636489) ^ -2070965828;
					continue;
				case 21u:
					result = jSONClass;
					num = ((int)num2 * -1678110781) ^ -937216890;
					continue;
				case 20u:
					result = jSONArray;
					num = (int)(num2 * 95245122) ^ -779079391;
					continue;
				case 19u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1974566066) ^ 0x42362B86);
					continue;
				case 18u:
					num = (int)((num2 * 1807108099) ^ 0x17A194C6);
					continue;
				case 17u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 1507794270) ^ 0x7EFB0686);
					continue;
				case 15u:
					num7++;
					num = (int)((num2 * 1127452588) ^ 0x20D0C5A3);
					continue;
				case 14u:
					num3 = 0;
					num = ((int)num2 * -1330160003) ^ 0x7F0F0F86;
					continue;
				case 11u:
				{
					int num6;
					if (num3 >= num5)
					{
						num = 1711610913;
						num6 = 1711610913;
					}
					else
					{
						num = 754121039;
						num6 = 754121039;
					}
					continue;
				}
				case 10u:
					num4 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 1506039523) ^ -2041828943;
					continue;
				case 9u:
					num = 288531984;
					continue;
				case 8u:
					jSONArray.Add(Deserialize(aReader));
					num = 1737736891;
					continue;
				case 5u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -497423890) ^ 0x515B3221;
					continue;
				case 3u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -608880195) ^ -218575824;
					continue;
				case 2u:
					num = (int)((num2 * 1330978013) ^ 0x2CDE7C0B);
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num3++;
					num = (int)(num2 * 1342587958) ^ -1949021247;
					continue;
				case 36u:
					break;
				case 6u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0185:
					num = 892696165;
					continue;
					IL_016e:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = 1620119479;
					continue;
					IL_0157:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 1620119479;
					continue;
					IL_014d:
					num = 971415278;
					continue;
					IL_0143:
					num = 1488740512;
					continue;
					IL_0130:
					num = (int)(num2 * 1888598007) ^ -374267361;
					continue;
					IL_00f3:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 1620119479;
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
				int num = -1434378537;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB66703C9u) % 3u)
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
					num = (int)((num2 * 436197132) ^ 0x180AF50);
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
					int num3 = -969304564;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xB66703C9u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)((num2 * 1458862095) ^ 0x4E8599BE);
							continue;
						case 0u:
							num3 = ((int)num2 * -288206159) ^ 0x15B3F653;
							continue;
						default:
							goto end_IL_006b;
						case 3u:
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
					int num = -620938948;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xFCC5BE06u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)(num2 * 1269456859) ^ -1445358727;
							continue;
						case 1u:
							num = (int)(num2 * 1632256066) ^ -1812069680;
							continue;
						default:
							goto end_IL_0037;
						case 3u:
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
			int num = -1444714391;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD01A8E6u) % 5u)
				{
				case 2u:
					num = ((int)num2 * -1976777943) ^ 0x7FD9EC1D;
					continue;
				case 1u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 470675707) ^ -110888828;
					continue;
				}
				case 0u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1025906803) ^ 0x3473155B;
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
