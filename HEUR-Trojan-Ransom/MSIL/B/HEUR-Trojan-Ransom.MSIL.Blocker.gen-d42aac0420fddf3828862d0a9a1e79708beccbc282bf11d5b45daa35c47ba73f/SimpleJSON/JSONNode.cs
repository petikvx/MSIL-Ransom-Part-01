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
				int num = 1161941421;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x59525E27u) % 4u)
					{
					case 2u:
						result = null;
						num = (int)((num2 * 1968884502) ^ 0x6625E37E);
						continue;
					case 1u:
						num = (int)(num2 * 502649567) ^ -2088883977;
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

	public virtual JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 510952707;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B3EE3B4u) % 4u)
					{
					case 3u:
						result = null;
						num = ((int)num2 * -107479345) ^ 0x6278FFF9;
						continue;
					case 0u:
						num = ((int)num2 * -1597869065) ^ -1444583231;
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

	public virtual int Count => 0;

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -466488351;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x955D041Fu) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -809372990) ^ -761525630;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)(num2 * 1309545025) ^ -1499186723;
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
			bool flag = default(bool);
			int result2 = default(int);
			while (true)
			{
				int num = 855060872;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x34F79C54u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2024798655;
							num4 = -2024798655;
						}
						else
						{
							num3 = -1310809590;
							num4 = -1310809590;
						}
						num = num3 ^ (int)(num2 * 1664373013);
						continue;
					}
					case 5u:
						result2 = 0;
						num = 982673874;
						continue;
					case 4u:
						result2 = result;
						num = ((int)num2 * -1489439656) ^ 0x37542684;
						continue;
					case 1u:
						flag = int.TryParse(Value, out result);
						num = (int)((num2 * 1830621729) ^ 0x2986DCD3);
						continue;
					case 0u:
						num = ((int)num2 * -849815607) ^ -682489086;
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
			while (true)
			{
				int num = 1843487828;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6FF2AC39u) % 4u)
					{
					case 1u:
						Value = value.ToString();
						num = (int)(num2 * 1244796456) ^ -1457828179;
						continue;
					case 0u:
						num = (int)((num2 * 1197555983) ^ 0x104E81EB);
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
				int num = 396866992;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41882865u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -412350017) ^ 0x26DB1BA2;
						continue;
					case 5u:
						result2 = 0f;
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)(num2 * 1079151042) ^ -752721693;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -943791680;
							num4 = -943791680;
						}
						else
						{
							num3 = -1921772269;
							num4 = -1921772269;
						}
						num = num3 ^ ((int)num2 * -132166155);
						continue;
					}
					case 3u:
						num = (int)((num2 * 1991287286) ^ 0x1A94D621);
						continue;
					case 2u:
						result = 0f;
						num = 2007682766;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1659594953) ^ 0x4DAD67F5;
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
			while (true)
			{
				int num = -2025591404;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84A2B650u) % 3u)
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
					num = (int)((num2 * 707937852) ^ 0x585FEB2B);
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			double result = default(double);
			while (true)
			{
				int num = -44069458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD446870Cu) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = -147328790;
							num4 = -147328790;
						}
						else
						{
							num3 = -338111362;
							num4 = -338111362;
						}
						num = num3 ^ ((int)num2 * -786893222);
						continue;
					}
					case 6u:
						num = (int)((num2 * 349402222) ^ 0x74335631);
						continue;
					case 4u:
						result = result2;
						num = ((int)num2 * -2127541908) ^ 0x698D4FC2;
						continue;
					case 3u:
						num = ((int)num2 * -1220936472) ^ -563971987;
						continue;
					case 2u:
						result2 = 0.0;
						num = ((int)num2 * -756275590) ^ 0x1B15479F;
						continue;
					case 0u:
						result = 0.0;
						num = -2074874345;
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
			bool flag = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -59758331;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD61D9E2u) % 7u)
					{
					case 5u:
						flag = bool.TryParse(Value, out result);
						num = (int)(num2 * 784510512) ^ -1222515265;
						continue;
					case 4u:
						result2 = result;
						num = (int)(num2 * 1115328017) ^ -827319625;
						continue;
					case 3u:
						num = ((int)num2 * -264752066) ^ 0x13BB324D;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1925874843;
							num4 = 1925874843;
						}
						else
						{
							num3 = 1477353339;
							num4 = 1477353339;
						}
						num = num3 ^ ((int)num2 * -209834365);
						continue;
					}
					case 1u:
						result2 = !JSONNode.smethod_1(Value);
						num = -556529364;
						continue;
					case 6u:
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
				int num = -1984107030;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E760E9Fu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 596672750) ^ 0x1F2DD56F);
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = -1994130972;
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
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -875008974;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9EFE3E7u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1858723669) ^ 0x3865FC41;
						continue;
					case 1u:
						result = this as JSONArray;
						num = ((int)num2 * -413591093) ^ 0x6BEE88B2;
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = this as JSONClass;
			while (true)
			{
				int num = 1989574925;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x776FAFBDu) % 3u)
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
					num = (int)((num2 * 1844942861) ^ 0x7ADE0B4A);
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
			int num = 963324867;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x22106E2Cu) % 3u)
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
				num = ((int)num2 * -1188033909) ^ -517109672;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1323627730;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71E25626u) % 3u)
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
				num = (int)((num2 * 1322328459) ^ 0x31787D86);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -1951496940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE80F848Eu) % 3u)
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
				num = ((int)num2 * -621539504) ^ -1713738609;
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
			int num = 1434746375;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x333765C5u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 23731016) ^ -523779700;
					continue;
				case 2u:
					result = "JSONNode";
					num = ((int)num2 * -1997777013) ^ 0x333A80C;
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
			int num = 828309689;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x3267A31Bu) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = ((int)num2 * -585664576) ^ 0x6760ECC5;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 3u:
					num = (int)(num2 * 1314804619) ^ -1715430777;
					continue;
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
					num = 1579134163;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1600095890;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6D2FE5DEu) % 8u)
				{
				case 7u:
					num = (int)((num2 * 1591125828) ^ 0x618A593);
					continue;
				case 6u:
					result = true;
					num = (int)(num2 * 447706702) ^ -875464587;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 306810018;
						num5 = 306810018;
					}
					else
					{
						num4 = 926436111;
						num5 = 926436111;
					}
					num = num4 ^ ((int)num2 * -2116013997);
					continue;
				}
				case 4u:
					if (b == null)
					{
						num = ((int)num2 * -146386262) ^ -2000387420;
						continue;
					}
					num3 = 0;
					goto IL_005d;
				case 3u:
					result = (object)a == b;
					num = 860170031;
					continue;
				case 2u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_005d;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_005d:
					flag = (byte)num3 != 0;
					num = 726119987;
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
			int num = -1670383604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC329CCCDu) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -1128249724) ^ 0x23B293C9;
					continue;
				case 0u:
					num = ((int)num2 * -1080863748) ^ 0x2B3740B3;
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

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -396395245;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF8E5CB9u) % 3u)
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
				result = (object)this == obj;
				num = (int)(num2 * 905233313) ^ -500136753;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = 371906828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67CB579Eu) % 3u)
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
				num = ((int)num2 * -2093751053) ^ 0x3D61F6D3;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string string_ = default(string);
		string text = default(string);
		int num4 = default(int);
		char c = default(char);
		char c3 = default(char);
		char c2 = default(char);
		string result = default(string);
		while (true)
		{
			int num = 1958752759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C423B28u) % 33u)
				{
				case 32u:
					string_ = aText;
					num = ((int)num2 * -2045724039) ^ -1500622764;
					continue;
				case 31u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1529800730;
					continue;
				case 29u:
					text = "";
					num = ((int)num2 * -755057474) ^ -779098321;
					continue;
				case 28u:
					num4++;
					num = ((int)num2 * -1919199783) ^ 0x4C0A0505;
					continue;
				case 27u:
					switch (c)
					{
					case '\b':
						goto IL_0095;
					case '\t':
						goto IL_00ab;
					case '\n':
						goto IL_00c1;
					case '\v':
						goto IL_00d7;
					case '\f':
						goto IL_00ef;
					case '\r':
						goto IL_0105;
					}
					num = (int)(num2 * 676613879) ^ -15067212;
					continue;
				case 1u:
					goto IL_0095;
				case 17u:
					goto IL_00ab;
				case 18u:
					goto IL_00c1;
				case 4u:
					goto IL_00d7;
				case 15u:
					goto IL_00ef;
				case 6u:
					goto IL_0105;
				case 26u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1859610175;
					continue;
				case 25u:
					num = ((int)num2 * -1786898879) ^ 0x28C901EF;
					continue;
				case 24u:
					c = c3;
					num = ((int)num2 * -1179504023) ^ 0x3794EF88;
					continue;
				case 23u:
					num = (int)(num2 * 28440612) ^ -2082377137;
					continue;
				case 22u:
					num = (int)(num2 * 188122150) ^ -774459467;
					continue;
				case 21u:
				{
					int num6;
					if (c == '\\')
					{
						num = 1272112814;
						num6 = 1272112814;
					}
					else
					{
						num = 1946268228;
						num6 = 1946268228;
					}
					continue;
				}
				case 20u:
					num = ((int)num2 * -1298704489) ^ -985511757;
					continue;
				case 16u:
					num = (int)((num2 * 134598933) ^ 0x1C6CFD5B);
					continue;
				case 14u:
					num = (int)((num2 * 1991213254) ^ 0x42E85E7F);
					continue;
				case 13u:
					num = 369132679;
					continue;
				case 12u:
					num4 = 0;
					num = ((int)num2 * -1240047580) ^ -87606359;
					continue;
				case 11u:
				{
					int num5;
					if (num4 < JSONNode.smethod_4(string_))
					{
						num = 1550280070;
						num5 = 1550280070;
					}
					else
					{
						num = 1729869326;
						num5 = 1729869326;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -1025605010) ^ -1607767177;
					continue;
				case 9u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 1017838994;
					continue;
				case 8u:
					num = (int)((num2 * 1689664222) ^ 0x2B131F63);
					continue;
				case 7u:
					result = text;
					num = (int)(num2 * 1299793616) ^ -1570355160;
					continue;
				case 5u:
					c3 = c2;
					num = ((int)num2 * -941227827) ^ 0x36A84167;
					continue;
				case 3u:
					num = (int)(num2 * 1755949165) ^ -492088424;
					continue;
				case 2u:
				{
					int num3;
					if (c != '"')
					{
						num = 1276883697;
						num3 = 1276883697;
					}
					else
					{
						num = 1680104203;
						num3 = 1680104203;
					}
					continue;
				}
				case 0u:
					num = (int)(num2 * 1505570928) ^ -1893487665;
					continue;
				case 30u:
					break;
				default:
					{
						return result;
					}
					IL_00ab:
					text = JSONNode.smethod_3(text, "\\t");
					num = 797160001;
					continue;
					IL_0095:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1859610175;
					continue;
					IL_0105:
					text = JSONNode.smethod_3(text, "\\r");
					num = 955045908;
					continue;
					IL_00ef:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1859610175;
					continue;
					IL_00d7:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1859610175;
					continue;
					IL_00c1:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1987259220;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		string text = default(string);
		JSONNode jSONNode = default(JSONNode);
		string text2 = default(string);
		int num3 = default(int);
		bool flag9 = default(bool);
		bool flag16 = default(bool);
		char c2 = default(char);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag15 = default(bool);
		bool flag13 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		char c = default(char);
		JSONNode result = default(JSONNode);
		char c4 = default(char);
		char c5 = default(char);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		bool flag14 = default(bool);
		bool flag11 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 1752843082;
			while (true)
			{
				uint num2;
				int num22;
				switch ((num2 = (uint)num ^ 0x657B56A5u) % 156u)
				{
				case 155u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -939128402) ^ -765536483;
					continue;
				case 154u:
					text = "";
					num = 2081602717;
					continue;
				case 153u:
				{
					int num51;
					int num52;
					if (jSONNode is JSONArray)
					{
						num51 = -1035750971;
						num52 = -1035750971;
					}
					else
					{
						num51 = -314639336;
						num52 = -314639336;
					}
					num = num51 ^ (int)(num2 * 1401060440);
					continue;
				}
				case 152u:
					num = ((int)num2 * -2130048166) ^ -267063737;
					continue;
				case 151u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = 1607381951;
					continue;
				case 150u:
					flag9 = jSONNode is JSONArray;
					num = ((int)num2 * -1301464488) ^ 0x15FBB0C5;
					continue;
				case 149u:
					num = (int)(num2 * 2072822589) ^ -1475233269;
					continue;
				case 148u:
					flag16 = JSONNode.smethod_6(text, "");
					num = 1991917155;
					continue;
				case 147u:
				{
					int num46;
					int num47;
					if ((uint)c2 <= 32u)
					{
						num46 = 321551905;
						num47 = 321551905;
					}
					else
					{
						num46 = 223962331;
						num47 = 223962331;
					}
					num = num46 ^ (int)(num2 * 1611807133);
					continue;
				}
				case 146u:
					num = 1062770659;
					continue;
				case 145u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -328063403) ^ -1748842672;
					continue;
				case 144u:
					text2 = "";
					text = "";
					flag = false;
					num = ((int)num2 * -963713240) ^ -1489155106;
					continue;
				case 143u:
					goto IL_0159;
				case 142u:
					num3++;
					num = 1265571134;
					continue;
				case 141u:
					num = (int)((num2 * 832079862) ^ 0x3EE655EE);
					continue;
				case 140u:
					text2 = "";
					num = (int)(num2 * 714428056) ^ -1439383740;
					continue;
				case 139u:
					num = (int)((num2 * 898210669) ^ 0x71D61213);
					continue;
				case 138u:
					text = text2;
					num = 127065911;
					continue;
				case 137u:
					flag10 = flag;
					num = ((int)num2 * -809841526) ^ -1270474231;
					continue;
				case 136u:
				{
					int num17;
					if (c2 != ',')
					{
						num = 1672043910;
						num17 = 1672043910;
					}
					else
					{
						num = 2075455812;
						num17 = 2075455812;
					}
					continue;
				}
				case 135u:
					flag8 = JSONNode.smethod_6(text2, "");
					num = 879385248;
					continue;
				case 134u:
					num = ((int)num2 * -2054484920) ^ -1442432854;
					continue;
				case 133u:
					flag7 = jSONNode != null;
					num = ((int)num2 * -1024064956) ^ -801923747;
					continue;
				case 132u:
					num = ((int)num2 * -1880187747) ^ -1108179161;
					continue;
				case 131u:
				{
					int num57;
					int num58;
					if (flag15)
					{
						num57 = -1586924501;
						num58 = -1586924501;
					}
					else
					{
						num57 = -197249720;
						num58 = -197249720;
					}
					num = num57 ^ ((int)num2 * -1623816551);
					continue;
				}
				case 130u:
				{
					string s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 381766776) ^ -1305860088;
					continue;
				}
				case 129u:
					num = 1318356631;
					continue;
				case 128u:
					flag13 = jSONNode is JSONArray;
					num = (int)((num2 * 747724619) ^ 0x90DD921);
					continue;
				case 127u:
				{
					int num48;
					int num49;
					if (c2 == ':')
					{
						num48 = 1346275679;
						num49 = 1346275679;
					}
					else
					{
						num48 = 2066207253;
						num49 = 2066207253;
					}
					num = num48 ^ (int)(num2 * 1041906485);
					continue;
				}
				case 126u:
				{
					int num43;
					if (num3 < JSONNode.smethod_4(aJSON))
					{
						num = 245588809;
						num43 = 245588809;
					}
					else
					{
						num = 580368228;
						num43 = 580368228;
					}
					continue;
				}
				case 124u:
					num = ((int)num2 * -1685656001) ^ -1032575997;
					continue;
				case 123u:
					flag15 = flag;
					num = ((int)num2 * -493653497) ^ -648660817;
					continue;
				case 122u:
					text2 = "";
					num = ((int)num2 * -2126795175) ^ 0x3A96BC7D;
					continue;
				case 30u:
				case 61u:
				case 62u:
				case 100u:
				case 121u:
					goto IL_037d;
				case 120u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 2015687923) ^ -856935757;
					continue;
				case 119u:
					num = (int)((num2 * 2090386858) ^ 0x4CE6FA2C);
					continue;
				case 118u:
					num = (int)(num2 * 1119602233) ^ -1085162507;
					continue;
				case 117u:
					flag5 = JSONNode.smethod_6(text2, "");
					num = (int)((num2 * 1294516527) ^ 0x33CCDDEA);
					continue;
				case 116u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -934994304) ^ 0x7504D24E;
					continue;
				case 115u:
				{
					int num33;
					int num34;
					if (!flag3)
					{
						num33 = -2073083836;
						num34 = -2073083836;
					}
					else
					{
						num33 = -1971081518;
						num34 = -1971081518;
					}
					num = num33 ^ (int)(num2 * 829343046);
					continue;
				}
				case 114u:
					flag = !flag;
					num = 983852233;
					continue;
				case 113u:
				{
					int num30;
					if (c2 != '"')
					{
						num = 1215918950;
						num30 = 1215918950;
					}
					else
					{
						num = 2036347007;
						num30 = 2036347007;
					}
					continue;
				}
				case 112u:
				{
					int num25;
					int num26;
					if (c == 'b')
					{
						num25 = 1490433098;
						num26 = 1490433098;
					}
					else
					{
						num25 = 315260443;
						num26 = 315260443;
					}
					num = num25 ^ (int)(num2 * 417610881);
					continue;
				}
				case 111u:
					num = ((int)num2 * -1834786984) ^ -580988551;
					continue;
				case 110u:
					goto IL_04ab;
				case 109u:
					result = jSONNode;
					num = 1799299483;
					continue;
				case 108u:
					goto IL_04d8;
				case 107u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1125810210) ^ -867904991;
					continue;
				case 106u:
				{
					int num16;
					if (c != 'f')
					{
						num = 2073692500;
						num16 = 2073692500;
					}
					else
					{
						num = 186922274;
						num16 = 186922274;
					}
					continue;
				}
				case 105u:
					num = ((int)num2 * -1873397629) ^ 0x2D9E7A63;
					continue;
				case 104u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = -876986826;
						num12 = -876986826;
					}
					else
					{
						num11 = -1367628404;
						num12 = -1367628404;
					}
					num = num11 ^ (int)(num2 * 581665913);
					continue;
				}
				case 103u:
					switch (c2)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_037d;
					case '\t':
						goto IL_04ab;
					default:
						goto IL_0596;
					}
					goto case 151u;
				case 102u:
					num = ((int)num2 * -1472135168) ^ -807405795;
					continue;
				case 101u:
					c4 = JSONNode.smethod_2(aJSON, num3);
					c5 = c4;
					num = (int)(num2 * 1395023621) ^ -1344684161;
					continue;
				case 99u:
					num = 2093987340;
					continue;
				case 98u:
					num = (int)(num2 * 363490483) ^ -2070622839;
					continue;
				case 97u:
					switch (c2)
					{
					case '\\':
						break;
					default:
						goto IL_060f;
					case '[':
						goto IL_0619;
					case ']':
						goto IL_0627;
					}
					goto case 142u;
				case 14u:
					goto IL_0619;
				case 20u:
					goto IL_0627;
				case 96u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 800994215) ^ 0x6235DBF5);
					continue;
				case 95u:
					stack.Push(new JSONArray());
					num = 1926935080;
					continue;
				case 94u:
				{
					int num59;
					int num60;
					if (flag16)
					{
						num59 = -2049574539;
						num60 = -2049574539;
					}
					else
					{
						num59 = -1847324779;
						num60 = -1847324779;
					}
					num = num59 ^ (int)(num2 * 1191390860);
					continue;
				}
				case 93u:
					flag12 = stack.Count > 0;
					num = ((int)num2 * -65130267) ^ 0x74AC846;
					continue;
				case 92u:
					num = ((int)num2 * -648033019) ^ 0x6287D4EC;
					continue;
				case 91u:
					num = (int)(num2 * 243233118) ^ -1225307955;
					continue;
				case 90u:
				{
					int num55;
					int num56;
					if (!flag10)
					{
						num55 = 1510816350;
						num56 = 1510816350;
					}
					else
					{
						num55 = 2050908564;
						num56 = 2050908564;
					}
					num = num55 ^ ((int)num2 * -353005093);
					continue;
				}
				case 89u:
				{
					int num53;
					int num54;
					if (!flag2)
					{
						num53 = 1686716532;
						num54 = 1686716532;
					}
					else
					{
						num53 = 124545058;
						num54 = 124545058;
					}
					num = num53 ^ ((int)num2 * -880443747);
					continue;
				}
				case 88u:
				{
					int num50;
					if (c2 != ' ')
					{
						num = 1075797251;
						num50 = 1075797251;
					}
					else
					{
						num = 503514707;
						num50 = 503514707;
					}
					continue;
				}
				case 87u:
					c = c5;
					num = (int)((num2 * 753694104) ^ 0x58D8DE5D);
					continue;
				case 86u:
					text = "";
					num = 673650586;
					continue;
				case 85u:
					text = "";
					num = 2143658613;
					continue;
				case 84u:
					text2 = "";
					num = (int)((num2 * 268827749) ^ 0x7F2BA4AA);
					continue;
				case 82u:
					num = (int)(num2 * 293732386) ^ -173153319;
					continue;
				case 81u:
					stack.Push(new JSONClass());
					num = 676572424;
					continue;
				case 80u:
				{
					int num44;
					int num45;
					if (!flag7)
					{
						num44 = -34752709;
						num45 = -34752709;
					}
					else
					{
						num44 = -1695324065;
						num45 = -1695324065;
					}
					num = num44 ^ (int)(num2 * 908632081);
					continue;
				}
				case 79u:
					num = 1549415927;
					continue;
				case 78u:
					num = ((int)num2 * -378060777) ^ -825254692;
					continue;
				case 77u:
					num = ((int)num2 * -857076082) ^ -1207141004;
					continue;
				case 76u:
					num = (int)((num2 * 198465640) ^ 0x5098C568);
					continue;
				case 75u:
					num = (int)(num2 * 492275631) ^ -1664566487;
					continue;
				case 74u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 1036125981) ^ 0x66AA2B86);
					continue;
				case 73u:
					flag14 = jSONNode != null;
					num = ((int)num2 * -755463178) ^ -757624432;
					continue;
				case 72u:
					num = ((int)num2 * -1911153829) ^ -366843782;
					continue;
				case 71u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 753620341) ^ 0x344B4587);
					continue;
				case 70u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 1639466593) ^ -1270800320;
					continue;
				case 69u:
				{
					int num42;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 1578342858;
						num42 = 1578342858;
					}
					else
					{
						num = 244200076;
						num42 = 244200076;
					}
					continue;
				}
				case 68u:
					num = ((int)num2 * -246355379) ^ 0x679F8D2;
					continue;
				case 67u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -343946470) ^ 0x46D771C8;
					continue;
				case 66u:
					num = ((int)num2 * -1531938274) ^ 0x61B87116;
					continue;
				case 65u:
				{
					int num41;
					if (flag)
					{
						num = 1200394859;
						num41 = 1200394859;
					}
					else
					{
						num = 70741406;
						num41 = 70741406;
					}
					continue;
				}
				case 64u:
					goto IL_0972;
				case 63u:
				{
					int num39;
					int num40;
					if (!flag14)
					{
						num39 = -897412852;
						num40 = -897412852;
					}
					else
					{
						num39 = -1275151863;
						num40 = -1275151863;
					}
					num = num39 ^ ((int)num2 * -1203407452);
					continue;
				}
				case 60u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -448536456) ^ 0x10774B57;
					continue;
				case 59u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 1604952280;
					continue;
				case 58u:
					num = (int)((num2 * 1617362770) ^ 0x773F8D94);
					continue;
				case 57u:
				{
					int num37;
					int num38;
					if (!flag11)
					{
						num37 = 1905020460;
						num38 = 1905020460;
					}
					else
					{
						num37 = 266281439;
						num38 = 266281439;
					}
					num = num37 ^ (int)(num2 * 353310141);
					continue;
				}
				case 56u:
				{
					int num35;
					int num36;
					if (flag13)
					{
						num35 = -581355884;
						num36 = -581355884;
					}
					else
					{
						num35 = -1553123740;
						num36 = -1553123740;
					}
					num = num35 ^ (int)(num2 * 917485551);
					continue;
				}
				case 55u:
					num = ((int)num2 * -396072919) ^ 0x12013681;
					continue;
				case 54u:
				{
					int num31;
					int num32;
					if (!flag12)
					{
						num31 = -1400302029;
						num32 = -1400302029;
					}
					else
					{
						num31 = -1699274764;
						num32 = -1699274764;
					}
					num = num31 ^ ((int)num2 * -34480761);
					continue;
				}
				case 53u:
					flag6 = flag;
					num = 1192893144;
					continue;
				case 52u:
				{
					int num28;
					int num29;
					if ((uint)c2 <= 44u)
					{
						num28 = 16058854;
						num29 = 16058854;
					}
					else
					{
						num28 = 478055754;
						num29 = 478055754;
					}
					num = num28 ^ ((int)num2 * -195182706);
					continue;
				}
				case 51u:
					switch (c)
					{
					case 'u':
						break;
					case 't':
						goto IL_0159;
					case 's':
						goto IL_04d8;
					case 'r':
						goto IL_0972;
					default:
						goto IL_0ae5;
					}
					goto case 146u;
				case 50u:
					num = (int)(num2 * 1464412296) ^ -1876303563;
					continue;
				case 49u:
					num3 += 4;
					num = (int)(num2 * 1517760458) ^ -1560042058;
					continue;
				case 48u:
					num = 1034571767;
					continue;
				case 47u:
					num = (int)((num2 * 1073294280) ^ 0x6F22EE7F);
					continue;
				case 46u:
					num = (int)(num2 * 585148492) ^ -2095850758;
					continue;
				case 45u:
					num = (int)((num2 * 2023165457) ^ 0x12E4EA06);
					continue;
				case 44u:
				{
					int num27;
					if (c2 != '}')
					{
						num = 269847373;
						num27 = 269847373;
					}
					else
					{
						num = 1644853845;
						num27 = 1644853845;
					}
					continue;
				}
				case 43u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 856330992;
					continue;
				case 42u:
					flag11 = jSONNode is JSONArray;
					num = (int)((num2 * 988894999) ^ 0x233CD68E);
					continue;
				case 41u:
					num = (int)(num2 * 1090669000) ^ -780705129;
					continue;
				case 40u:
				{
					int num23;
					int num24;
					if ((uint)c > 102u)
					{
						num23 = -1720532423;
						num24 = -1720532423;
					}
					else
					{
						num23 = -2122161567;
						num24 = -2122161567;
					}
					num = num23 ^ ((int)num2 * -980785857);
					continue;
				}
				case 39u:
					text2 = "";
					num = ((int)num2 * -787941435) ^ 0x623B2500;
					continue;
				case 37u:
				{
					int num20;
					int num21;
					if (!flag8)
					{
						num20 = -1757762776;
						num21 = -1757762776;
					}
					else
					{
						num20 = -357548794;
						num21 = -357548794;
					}
					num = num20 ^ (int)(num2 * 934369427);
					continue;
				}
				case 36u:
				{
					int num18;
					int num19;
					if (!flag9)
					{
						num18 = 340474436;
						num19 = 340474436;
					}
					else
					{
						num18 = 758597946;
						num19 = 758597946;
					}
					num = num18 ^ (int)(num2 * 2019447658);
					continue;
				}
				case 35u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -840606175) ^ 0x59BEFA0B;
					continue;
				case 34u:
				{
					int num15;
					if (c2 != '{')
					{
						num = 2086670987;
						num15 = 2086670987;
					}
					else
					{
						num = 1195703827;
						num15 = 1195703827;
					}
					continue;
				}
				case 33u:
					num = ((int)num2 * -1089714651) ^ 0x5561DEF0;
					continue;
				case 32u:
					flag4 = stack.Count == 0;
					num = 1031881597;
					continue;
				case 31u:
					num = 945891840;
					continue;
				case 29u:
				{
					int num13;
					int num14;
					if (!flag6)
					{
						num13 = -1355744834;
						num14 = -1355744834;
					}
					else
					{
						num13 = -1561264481;
						num14 = -1561264481;
					}
					num = num13 ^ (int)(num2 * 1124641929);
					continue;
				}
				case 28u:
					num = (int)((num2 * 1826441242) ^ 0x46142700);
					continue;
				case 27u:
				{
					int num10;
					if ((uint)c2 <= 93u)
					{
						num = 841389306;
						num10 = 841389306;
					}
					else
					{
						num = 1692704731;
						num10 = 1692704731;
					}
					continue;
				}
				case 26u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1599453007) ^ 0x71C135BD);
					continue;
				case 25u:
					jSONNode.Add(text2);
					num = (int)((num2 * 123606124) ^ 0x8C9072F);
					continue;
				case 24u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1462966561) ^ -806829501;
					continue;
				case 23u:
					jSONNode = null;
					num3 = 0;
					num = ((int)num2 * -650118584) ^ 0x55C5C611;
					continue;
				case 22u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 856330992;
					continue;
				case 21u:
				{
					int num9;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 1996982962;
						num9 = 1996982962;
					}
					else
					{
						num = 814133805;
						num9 = 814133805;
					}
					continue;
				}
				case 19u:
					stack.Pop();
					num = 1603131588;
					continue;
				case 18u:
					num = ((int)num2 * -1667542769) ^ 0x2D60BDE1;
					continue;
				case 17u:
				{
					int num8;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 872634835;
						num8 = 872634835;
					}
					else
					{
						num = 835272694;
						num8 = 835272694;
					}
					continue;
				}
				case 15u:
					num = (int)(num2 * 614439204) ^ -771720303;
					continue;
				case 13u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 1815080787) ^ 0x612D7DB6);
					continue;
				case 12u:
				{
					char c3 = JSONNode.smethod_2(aJSON, num3);
					c2 = c3;
					num = 1861328713;
					continue;
				}
				case 11u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1387080848) ^ 0x55A7AFAE);
					continue;
				case 10u:
					num = (int)((num2 * 502339809) ^ 0x21D5105F);
					continue;
				case 9u:
					text = "";
					text2 = "";
					num = 825088038;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag4)
					{
						num6 = -1646811112;
						num7 = -1646811112;
					}
					else
					{
						num6 = -1158964778;
						num7 = -1158964778;
					}
					num = num6 ^ (int)(num2 * 988753637);
					continue;
				}
				case 7u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1013177673) ^ -1552265164;
					continue;
				case 6u:
				{
					int num5;
					if (flag)
					{
						num = 226396244;
						num5 = 226396244;
					}
					else
					{
						num = 694927052;
						num5 = 694927052;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -1131414293) ^ -2021338018;
					continue;
				case 4u:
				{
					int num4;
					if (c != 'n')
					{
						num = 1668619027;
						num4 = 1668619027;
					}
					else
					{
						num = 1955805251;
						num4 = 1955805251;
					}
					continue;
				}
				case 3u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1253005833) ^ 0x52C284;
					continue;
				case 2u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1310301496) ^ 0x19BB4D2D;
					continue;
				case 1u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 1541741986) ^ -1070798838;
					continue;
				case 0u:
					num = ((int)num2 * -1431048771) ^ -421766398;
					continue;
				case 16u:
					break;
				case 83u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 125u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0627:
					flag2 = flag;
					num = 2089842940;
					continue;
					IL_0619:
					flag3 = flag;
					num = 621786410;
					continue;
					IL_060f:
					num = 725884805;
					continue;
					IL_0596:
					num = (int)((num2 * 1246654801) ^ 0x3E31A9D8);
					continue;
					IL_04d8:
					text2 = JSONNode.smethod_3(text2, c4.ToString());
					num = 1382540925;
					continue;
					IL_04ab:
					if (flag)
					{
						num = 2033301998;
						num22 = 2033301998;
					}
					else
					{
						num = 1774649792;
						num22 = 1774649792;
					}
					continue;
					IL_0ae5:
					num = 444623303;
					continue;
					IL_0159:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 999530439;
					continue;
					IL_037d:
					num3++;
					num = 1442329703;
					continue;
					IL_0972:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 856330992;
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
			int num = -470401347;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x919F5309u) % 3u)
				{
				case 1u:
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
				num = (int)((num2 * 147313130) ^ 0x28364BD1);
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
					int num = 1201759763;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x6145049Eu) % 4u)
						{
						case 3u:
							num = (int)((num2 * 1940689708) ^ 0x3704B2B4);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 268403937) ^ 0x6F6BE634);
							continue;
						default:
							goto end_IL_004d;
						case 0u:
							break;
						case 2u:
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
				int num = -1182543379;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD53B451Bu) % 5u)
					{
					case 4u:
						num = ((int)num2 * -1164502622) ^ 0x64EDB619;
						continue;
					case 2u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 937704120) ^ 0x7C1077AF);
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1866642388) ^ -849030862;
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
					int num3 = -1289490166;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xD53B451Bu) % 3u)
						{
						case 2u:
							goto IL_0089;
						default:
							goto end_IL_009c;
						case 0u:
							break;
						case 1u:
							goto end_IL_009c;
						}
						goto IL_00b9;
						IL_0089:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -420355773) ^ -352025356;
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
		bool flag = default(bool);
		int num3 = default(int);
		int num10 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num9 = default(int);
		JSONClass jSONClass = default(JSONClass);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		string aKey = default(string);
		while (true)
		{
			int num = -220343367;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB1202B6u) % 44u)
				{
				case 42u:
					flag = num3 < num10;
					num = -1188171476;
					continue;
				case 41u:
					num4++;
					num = (int)(num2 * 720264406) ^ -1201562468;
					continue;
				case 40u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 93826083;
						num8 = 93826083;
					}
					else
					{
						num7 = 168987334;
						num8 = 168987334;
					}
					num = num7 ^ (int)(num2 * 1827031288);
					continue;
				}
				case 39u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 1352883208) ^ 0x3678DD27);
					continue;
				case 38u:
					num3++;
					num = (int)(num2 * 1077584586) ^ -320236164;
					continue;
				case 37u:
					num = ((int)num2 * -1053113042) ^ 0x1EE90AA1;
					continue;
				case 36u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -2131412617) ^ 0x617E08B;
					continue;
				case 35u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -1684260798) ^ -2068283156;
					continue;
				case 34u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)(num2 * 1619817154) ^ -279008130;
					continue;
				case 32u:
					flag2 = num4 < num9;
					num = -1359101142;
					continue;
				case 31u:
					result = jSONClass;
					num = ((int)num2 * -736194827) ^ -379641516;
					continue;
				case 30u:
					num10 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 605700439) ^ -172251796;
					continue;
				case 29u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Array:
						goto IL_017c;
					case JSONBinaryTag.Class:
						goto IL_0186;
					case JSONBinaryTag.Value:
						goto IL_0190;
					case JSONBinaryTag.IntValue:
						goto IL_019a;
					case JSONBinaryTag.DoubleValue:
						goto IL_01a4;
					case JSONBinaryTag.BoolValue:
						goto IL_01ae;
					case JSONBinaryTag.FloatValue:
						goto IL_01c5;
					}
					num = (int)(num2 * 321179110) ^ -2011127982;
					continue;
				case 18u:
					goto IL_017c;
				case 7u:
					goto IL_0186;
				case 26u:
					goto IL_0190;
				case 2u:
					goto IL_019a;
				case 11u:
					goto IL_01a4;
				case 13u:
					goto IL_01ae;
				case 1u:
					goto IL_01c5;
				case 28u:
					result = jSONArray;
					num = (int)((num2 * 1862828751) ^ 0x5FE95CC7);
					continue;
				case 27u:
					num = (int)(num2 * 1272612776) ^ -1570491724;
					continue;
				case 25u:
					num = (int)(num2 * 1037573119) ^ -1292286245;
					continue;
				case 24u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 1362285657) ^ 0x43FC7195);
					continue;
				case 23u:
					num9 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 1614494964) ^ -997815906;
					continue;
				case 22u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 791259044;
						num6 = 791259044;
					}
					else
					{
						num5 = 29020705;
						num6 = 29020705;
					}
					num = num5 ^ ((int)num2 * -1729949316);
					continue;
				}
				case 21u:
					num = (int)(num2 * 96191049) ^ -1176171338;
					continue;
				case 20u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1998006138) ^ -372317476;
					continue;
				case 19u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 229922507) ^ 0x577FF2C8);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1284131505) ^ 0x79FDCFA8;
					continue;
				case 16u:
					num = ((int)num2 * -573163785) ^ 0x653FC2C3;
					continue;
				case 15u:
					num4 = 0;
					num = (int)((num2 * 208185374) ^ 0x773DE978);
					continue;
				case 14u:
					num = (int)((num2 * 1073331418) ^ 0x717399E1);
					continue;
				case 10u:
					num = -453592917;
					continue;
				case 9u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 255421082) ^ 0x4E522247);
					continue;
				case 8u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -913448459) ^ -209075733;
					continue;
				case 6u:
					num3 = 0;
					num = (int)((num2 * 1049063843) ^ 0x3F3D847D);
					continue;
				case 5u:
					jSONArray.Add(Deserialize(aReader));
					num = -1909651798;
					continue;
				case 4u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 501210700) ^ -1004013713;
					continue;
				case 3u:
					num = ((int)num2 * -2076613843) ^ 0x749CC256;
					continue;
				case 0u:
					num = ((int)num2 * -900441098) ^ 0x20B175DF;
					continue;
				case 12u:
					break;
				case 43u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_01c5:
					num = -1184317947;
					continue;
					IL_01ae:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1059343105;
					continue;
					IL_01a4:
					num = -1076557152;
					continue;
					IL_019a:
					num = -786819830;
					continue;
					IL_0190:
					num = -1344149286;
					continue;
					IL_0186:
					num = -283773884;
					continue;
					IL_017c:
					num = -1194182803;
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
				int num = 271777284;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x392B4262u) % 3u)
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
					num = (int)(num2 * 1294899180) ^ -1740213142;
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
					int num3 = 273359170;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x392B4262u) % 3u)
						{
						case 1u:
							goto IL_0049;
						default:
							goto end_IL_005c;
						case 2u:
							break;
						case 0u:
							goto end_IL_005c;
						}
						goto IL_0079;
						IL_0049:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = ((int)num2 * -675831603) ^ 0x3C342C00;
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
				int num = -2013002051;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEEE0C00u) % 3u)
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
					num = ((int)num2 * -1829622717) ^ 0x3870904A;
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
					int num3 = -1531949127;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xCEEE0C00u) % 3u)
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
						num3 = (int)((num2 * 709341923) ^ 0x2F3420A7);
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = JSONNode.smethod_29(byte_);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1719610029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CEA20D1u) % 5u)
				{
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1218707043) ^ 0x359BF234);
					continue;
				case 2u:
					num = (int)(num2 * 188606284) ^ -1464491820;
					continue;
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 1426939554) ^ -2038078842;
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
