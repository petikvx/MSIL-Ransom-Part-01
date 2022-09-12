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
				int num = 720983468;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1F6A408Fu) % 3u)
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
					num = ((int)num2 * -789568823) ^ -594854593;
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
				int num = 122990606;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1E1187E3u) % 4u)
					{
					case 1u:
						result = "";
						num = (int)(num2 * 1834493006) ^ -1279143367;
						continue;
					case 0u:
						num = ((int)num2 * -2105755036) ^ -1378244244;
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

	public virtual int Count
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 229366061;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C8581ECu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -502044457) ^ -678502106;
						continue;
					case 1u:
						result = 0;
						num = (int)(num2 * 365460806) ^ -1231266872;
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
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -259770378;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA914A683u) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 68919483) ^ 0x5C0DDAD2);
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -842106238) ^ -101023814;
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
			int result = default(int);
			int result2 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -1304663450;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA6C66140u) % 8u)
					{
					case 7u:
						result = result2;
						num = (int)(num2 * 1510636074) ^ -492595097;
						continue;
					case 6u:
						result2 = 0;
						num = ((int)num2 * -636745132) ^ 0x192E873A;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1034291079;
							num4 = -1034291079;
						}
						else
						{
							num3 = -228468595;
							num4 = -228468595;
						}
						num = num3 ^ ((int)num2 * -1390485694);
						continue;
					}
					case 3u:
						result = 0;
						num = -468307776;
						continue;
					case 2u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -1717384755) ^ -1388447257;
						continue;
					case 1u:
						num = (int)((num2 * 2061546580) ^ 0x59B4A014);
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
				int num = -60784923;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC88DB5BAu) % 4u)
					{
					case 3u:
						Value = value.ToString();
						num = (int)((num2 * 2050213580) ^ 0x5E52561B);
						continue;
					case 1u:
						num = ((int)num2 * -274826667) ^ 0x73E01F49;
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

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			bool flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
			float result2 = default(float);
			while (true)
			{
				int num = 296140002;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x715A2736u) % 7u)
					{
					case 6u:
						num = (int)(num2 * 843391019) ^ -950049541;
						continue;
					case 5u:
						result2 = result;
						num = ((int)num2 * -1395150211) ^ -317365234;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 2067376660;
							num4 = 2067376660;
						}
						else
						{
							num3 = 817260258;
							num4 = 817260258;
						}
						num = num3 ^ (int)(num2 * 2036847838);
						continue;
					}
					case 3u:
						result2 = 0f;
						num = 1397270914;
						continue;
					case 1u:
						num = (int)((num2 * 1705080597) ^ 0x5F4BE873);
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
				int num = 1343369179;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BEB11AAu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1821836939) ^ 0x1BAB4AC7;
						continue;
					case 1u:
						Value = value.ToString();
						num = ((int)num2 * -563303828) ^ 0x430328E0;
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

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			double result = default(double);
			while (true)
			{
				int num = -1059455569;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA31D44F0u) % 8u)
					{
					case 7u:
						result2 = 0.0;
						num = ((int)num2 * -1580700908) ^ 0x3F13BC41;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = 691031927;
							num4 = 691031927;
						}
						else
						{
							num3 = 633878174;
							num4 = 633878174;
						}
						num = num3 ^ ((int)num2 * -1361403258);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1038915711) ^ -1469252090;
						continue;
					case 3u:
						num = ((int)num2 * -1577797668) ^ 0x5502B7B6;
						continue;
					case 1u:
						result = 0.0;
						num = -1718765612;
						continue;
					case 0u:
						result = result2;
						num = ((int)num2 * -1508421177) ^ -498953357;
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
				int num = 1668794756;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x746B5524u) % 7u)
					{
					case 5u:
						num = (int)((num2 * 23971923) ^ 0x4656AD92);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2107055540;
							num4 = -2107055540;
						}
						else
						{
							num3 = -1893918396;
							num4 = -1893918396;
						}
						num = num3 ^ ((int)num2 * -2038899300);
						continue;
					}
					case 2u:
						flag = bool.TryParse(Value, out result);
						num = (int)((num2 * 1382006247) ^ 0x54A6667C);
						continue;
					case 1u:
						result2 = result;
						num = ((int)num2 * -476167226) ^ 0x7B02E3B5;
						continue;
					case 0u:
						result2 = !JSONNode.smethod_1(Value);
						num = 944509713;
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
				int num = 1611991467;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x33FFCA67u) % 3u)
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
					num = (int)(num2 * 880717929) ^ -1807810464;
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
				int num = -1545759846;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F90D46Au) % 3u)
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
					num = (int)((num2 * 896403361) ^ 0x707E3576);
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
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1190146762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5C23AD4u) % 3u)
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
				num = ((int)num2 * -469206414) ^ 0xFEBAA4E;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -291464591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD925BDF4u) % 4u)
				{
				case 1u:
					result = aNode;
					num = ((int)num2 * -248774051) ^ -82455743;
					continue;
				case 0u:
					num = (int)(num2 * 1811897931) ^ -583717610;
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
			int num = -1475474914;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8B10BA8u) % 3u)
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
				num = ((int)num2 * -1379750456) ^ 0x6F7B7690;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -17420746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85DE18FBu) % 4u)
				{
				case 1u:
					result = "JSONNode";
					num = (int)((num2 * 1012819461) ^ 0x2685390A);
					continue;
				case 0u:
					num = (int)(num2 * 239448160) ^ -1384477532;
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -252915160;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99D5B749u) % 4u)
				{
				case 1u:
					result = new JSONData(s);
					num = ((int)num2 * -1526694372) ^ -76068891;
					continue;
				case 0u:
					num = ((int)num2 * -1118275642) ^ 0x18A3367;
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
			int num = 1950603095;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x2BB54751u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 1385549769) ^ -584525466;
					continue;
				case 2u:
					obj = d.Value;
					goto IL_0018;
				case 1u:
					if (!(d == null))
					{
						num = (int)(num2 * 401488430) ^ -1269195846;
						continue;
					}
					obj = null;
					goto IL_0018;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0018:
					result = (string)obj;
					num = 912339214;
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
			goto IL_0030;
		}
		goto IL_0065;
		IL_0030:
		int num = -119096408;
		goto IL_0035;
		IL_0035:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x819DB9F2u) % 5u)
			{
			case 4u:
				result = (object)a == b;
				num = -1391385776;
				continue;
			case 3u:
				result = true;
				num = (int)(num2 * 307962571) ^ -141920933;
				continue;
			case 2u:
				break;
			case 1u:
				goto IL_005a;
			default:
				return result;
			}
			break;
			IL_005a:
			if (a is JSONLazyCreator)
			{
				num = -2091759565;
				num3 = -2091759565;
				continue;
			}
			goto IL_0065;
		}
		goto IL_0030;
		IL_0065:
		num = -1016435191;
		num3 = -1016435191;
		goto IL_0035;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -912001552;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA50A8A98u) % 3u)
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
				num = ((int)num2 * -793894087) ^ -126320149;
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
		char c2 = default(char);
		char c3 = default(char);
		char c = default(char);
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 686147149;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5314121Au) % 33u)
				{
				case 32u:
					text = JSONNode.smethod_3(text, "\\r");
					num = 2057019229;
					continue;
				case 31u:
					num = ((int)num2 * -1093728422) ^ -1823226408;
					continue;
				case 30u:
					goto IL_0034;
				case 28u:
					c2 = c3;
					num = ((int)num2 * -829054844) ^ 0x62A8F3F7;
					continue;
				case 27u:
					num = ((int)num2 * -175191293) ^ -1220800983;
					continue;
				case 26u:
					c = c2;
					num = ((int)num2 * -1324940647) ^ -1251506539;
					continue;
				case 25u:
				{
					int num6;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 2101991810;
						num6 = 2101991810;
					}
					else
					{
						num = 2116063555;
						num6 = 2116063555;
					}
					continue;
				}
				case 24u:
					num = (int)((num2 * 1927466975) ^ 0x4C42E1F);
					continue;
				case 23u:
					num3++;
					num = (int)(num2 * 2139597126) ^ -400407254;
					continue;
				case 22u:
				{
					int num5;
					if (c != '\\')
					{
						num = 1005786891;
						num5 = 1005786891;
					}
					else
					{
						num = 1246690429;
						num5 = 1246690429;
					}
					continue;
				}
				case 21u:
					goto IL_00fb;
				case 20u:
					c3 = JSONNode.smethod_2(string_, num3);
					num = 696734771;
					continue;
				case 19u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1699538664;
					continue;
				case 18u:
					num = (int)(num2 * 2089112369) ^ -744275258;
					continue;
				case 17u:
					num = ((int)num2 * -1622708778) ^ 0xFCFEF8F;
					continue;
				case 16u:
					num = (int)(num2 * 39728430) ^ -2031472979;
					continue;
				case 15u:
					goto IL_0172;
				case 14u:
					num = 2091297956;
					continue;
				case 13u:
					goto IL_0192;
				case 12u:
					goto IL_01a8;
				case 11u:
					num = ((int)num2 * -184542540) ^ -1981136470;
					continue;
				case 10u:
				{
					int num4;
					if (c != '"')
					{
						num = 1415093775;
						num4 = 1415093775;
					}
					else
					{
						num = 1834113565;
						num4 = 1834113565;
					}
					continue;
				}
				case 9u:
					string_ = aText;
					num = (int)(num2 * 2002643477) ^ -751455370;
					continue;
				case 8u:
					num = (int)(num2 * 2018204920) ^ -582285595;
					continue;
				case 7u:
					num = ((int)num2 * -1571470060) ^ 0x552B5DAD;
					continue;
				case 6u:
					num = (int)((num2 * 871635516) ^ 0x6B8B7801);
					continue;
				case 5u:
					switch (c)
					{
					case '\r':
						break;
					case '\b':
						goto IL_0034;
					case '\f':
						goto IL_00fb;
					case '\n':
						goto IL_0172;
					case '\t':
						goto IL_0192;
					case '\v':
						goto IL_01a8;
					default:
						goto IL_0261;
					}
					goto case 32u;
				case 4u:
					num3 = 0;
					num = (int)((num2 * 471572099) ^ 0x1313C498);
					continue;
				case 3u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1965107877;
					continue;
				case 2u:
					result = text;
					num = ((int)num2 * -1781884930) ^ 0xBB96824;
					continue;
				case 1u:
					num = (int)(num2 * 1954704465) ^ -1317096905;
					continue;
				case 29u:
					break;
				default:
					{
						return result;
					}
					IL_0261:
					num = (int)(num2 * 324305644) ^ -1538927397;
					continue;
					IL_01a8:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1965107877;
					continue;
					IL_0192:
					text = JSONNode.smethod_3(text, "\\t");
					num = 831375296;
					continue;
					IL_0172:
					text = JSONNode.smethod_3(text, "\\n");
					num = 694185886;
					continue;
					IL_00fb:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1428709218;
					continue;
					IL_0034:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1965107877;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag4 = default(bool);
		string text2 = default(string);
		int num12 = default(int);
		char c = default(char);
		bool flag = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag5 = default(bool);
		bool flag11 = default(bool);
		string text = default(string);
		char c4 = default(char);
		bool flag12 = default(bool);
		char c2 = default(char);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag8 = default(bool);
		char c3 = default(char);
		bool flag10 = default(bool);
		string s = default(string);
		bool flag2 = default(bool);
		bool flag7 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1512673973;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB0E4C3Cu) % 153u)
				{
				case 152u:
					num = (int)(num2 * 629464191) ^ -1538504596;
					continue;
				case 151u:
					stack.Push(new JSONClass());
					num = -1901957624;
					continue;
				case 150u:
				{
					int num48;
					int num49;
					if (flag4)
					{
						num48 = 1399985417;
						num49 = 1399985417;
					}
					else
					{
						num48 = 1077221014;
						num49 = 1077221014;
					}
					num = num48 ^ ((int)num2 * -425738163);
					continue;
				}
				case 149u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)(num2 * 440263770) ^ -2030797943;
					continue;
				case 148u:
				{
					int num30;
					if (c == ' ')
					{
						num = -922164007;
						num30 = -922164007;
					}
					else
					{
						num = -1965547068;
						num30 = -1965547068;
					}
					continue;
				}
				case 147u:
				{
					int num59;
					if (!flag)
					{
						num = -1944678969;
						num59 = -1944678969;
					}
					else
					{
						num = -2003184416;
						num59 = -2003184416;
					}
					continue;
				}
				case 146u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 246624631) ^ 0x74E0A803);
					continue;
				case 145u:
				{
					int num14;
					int num15;
					if (flag5)
					{
						num14 = 102314406;
						num15 = 102314406;
					}
					else
					{
						num14 = 821646486;
						num15 = 821646486;
					}
					num = num14 ^ (int)(num2 * 1096210408);
					continue;
				}
				case 144u:
					flag11 = flag;
					num = -586072177;
					continue;
				case 143u:
					text = "";
					num = -96132781;
					continue;
				case 142u:
				{
					int num53;
					int num54;
					if (c4 == 'b')
					{
						num53 = -1753743937;
						num54 = -1753743937;
					}
					else
					{
						num53 = -1579995126;
						num54 = -1579995126;
					}
					num = num53 ^ ((int)num2 * -1850378790);
					continue;
				}
				case 141u:
					num = (int)(num2 * 1508288012) ^ -962707901;
					continue;
				case 140u:
					num = ((int)num2 * -1448256347) ^ -1480030498;
					continue;
				case 139u:
					num = (int)((num2 * 777823366) ^ 0x1C0CAAFB);
					continue;
				case 138u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num12);
					c = c5;
					num = (int)(num2 * 2042005225) ^ -991297692;
					continue;
				}
				case 137u:
					text = "";
					text2 = "";
					num = -1789417150;
					continue;
				case 136u:
				{
					int num9;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -193729863;
						num9 = -193729863;
					}
					else
					{
						num = -324071016;
						num9 = -324071016;
					}
					continue;
				}
				case 135u:
					num = (int)((num2 * 1912359794) ^ 0x292D8F83);
					continue;
				case 134u:
				{
					int num5;
					int num6;
					if ((uint)c > 32u)
					{
						num5 = 913704597;
						num6 = 913704597;
					}
					else
					{
						num5 = 1953068345;
						num6 = 1953068345;
					}
					num = num5 ^ ((int)num2 * -44420231);
					continue;
				}
				case 133u:
				{
					text = JSONNode.smethod_5(text);
					int num56;
					int num57;
					if (jSONNode is JSONArray)
					{
						num56 = -1983226796;
						num57 = -1983226796;
					}
					else
					{
						num56 = -1056096895;
						num57 = -1056096895;
					}
					num = num56 ^ ((int)num2 * -1149584588);
					continue;
				}
				case 132u:
					num = -1348130391;
					continue;
				case 131u:
				{
					int num50;
					int num51;
					if (!flag12)
					{
						num50 = 1995466349;
						num51 = 1995466349;
					}
					else
					{
						num50 = 2054200151;
						num51 = 2054200151;
					}
					num = num50 ^ (int)(num2 * 149060670);
					continue;
				}
				case 130u:
				{
					int num42;
					int num43;
					if ((uint)c4 <= 102u)
					{
						num42 = 68755580;
						num43 = 68755580;
					}
					else
					{
						num42 = 1526214425;
						num43 = 1526214425;
					}
					num = num42 ^ ((int)num2 * -1598658436);
					continue;
				}
				case 129u:
					text2 = JSONNode.smethod_3(text2, c2.ToString());
					num = -1483935347;
					continue;
				case 128u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = ((int)num2 * -169407966) ^ 0x4C8868FF;
					continue;
				case 127u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -411934462) ^ 0x4650FABE;
					continue;
				case 126u:
					text2 = "";
					num = ((int)num2 * -1450766435) ^ 0x655466B;
					continue;
				case 125u:
					num = ((int)num2 * -1770304108) ^ 0x525F1A65;
					continue;
				case 124u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)(num2 * 731909531) ^ -1491729826;
					continue;
				case 123u:
					num = (int)((num2 * 217124467) ^ 0x56DABD44);
					continue;
				case 122u:
					text = "";
					num = ((int)num2 * -575873725) ^ 0x50408C74;
					continue;
				case 121u:
					num = ((int)num2 * -1277349430) ^ -212001649;
					continue;
				case 120u:
					switch (c4)
					{
					case 's':
						break;
					default:
						goto IL_03d0;
					case 'r':
						goto IL_03da;
					case 't':
						goto IL_03f0;
					case 'u':
						goto IL_0406;
					}
					goto case 129u;
				case 68u:
					goto IL_03da;
				case 29u:
					goto IL_03f0;
				case 51u:
					goto IL_0406;
				case 119u:
					switch (c)
					{
					case '[':
						goto IL_043c;
					case '\\':
						goto IL_044a;
					case ']':
						goto IL_0458;
					}
					num = -29892982;
					continue;
				case 115u:
					goto IL_043c;
				case 73u:
					goto IL_044a;
				case 19u:
					goto IL_0458;
				case 118u:
				{
					int num25;
					int num26;
					if (!flag9)
					{
						num25 = 551161765;
						num26 = 551161765;
					}
					else
					{
						num25 = 156887337;
						num26 = 156887337;
					}
					num = num25 ^ (int)(num2 * 1990326122);
					continue;
				}
				case 117u:
					num = ((int)num2 * -1172804720) ^ 0x68FD02EC;
					continue;
				case 116u:
					num = ((int)num2 * -2029539148) ^ 0x9460C35;
					continue;
				case 114u:
					text2 = "";
					num = (int)((num2 * 1077553589) ^ 0x4AAA2DFB);
					continue;
				case 4u:
				case 25u:
				case 77u:
				case 78u:
				case 113u:
					goto IL_04ce;
				case 112u:
					num = -2019702766;
					continue;
				case 111u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -890176234;
					continue;
				case 110u:
					num = ((int)num2 * -902265394) ^ -1314299942;
					continue;
				case 109u:
					num = ((int)num2 * -1455605751) ^ 0x452F6619;
					continue;
				case 108u:
					text = JSONNode.smethod_5(text);
					flag6 = jSONNode is JSONArray;
					num = ((int)num2 * -1302511860) ^ 0x276D1848;
					continue;
				case 107u:
					text = text2;
					text2 = "";
					num = -24617127;
					continue;
				case 106u:
					flag3 = num12 < JSONNode.smethod_4(aJSON);
					num = -1117142536;
					continue;
				case 105u:
					jSONNode.Add(text2);
					num = (int)((num2 * 642554560) ^ 0x279F2AA1);
					continue;
				case 104u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)(num2 * 628813761) ^ -2062414411;
					continue;
				case 103u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 638314467) ^ 0x16F1D1C1);
					continue;
				case 102u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -640025688;
						num11 = -640025688;
					}
					else
					{
						num10 = -394035824;
						num11 = -394035824;
					}
					num = num10 ^ ((int)num2 * -205028386);
					continue;
				}
				case 99u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -363948280) ^ 0x7893C018;
					continue;
				case 98u:
				{
					int num60;
					int num61;
					if (flag6)
					{
						num60 = 34705002;
						num61 = 34705002;
					}
					else
					{
						num60 = 637987186;
						num61 = 637987186;
					}
					num = num60 ^ ((int)num2 * -740912016);
					continue;
				}
				case 97u:
					text = "";
					num = -1045449421;
					continue;
				case 96u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -2088919627;
					continue;
				case 95u:
					flag9 = JSONNode.smethod_6(text2, "");
					num = -1410135406;
					continue;
				case 94u:
					num = ((int)num2 * -551999738) ^ 0x354E9F18;
					continue;
				case 93u:
					num = ((int)num2 * -1366284271) ^ 0x1853984;
					continue;
				case 92u:
					text2 = "";
					num = (int)(num2 * 718722112) ^ -1349237518;
					continue;
				case 91u:
					num12 = 0;
					num = ((int)num2 * -1859374460) ^ -1831695679;
					continue;
				case 90u:
				{
					int num58;
					if (c != '}')
					{
						num = -1962198983;
						num58 = -1962198983;
					}
					else
					{
						num = -1197748860;
						num58 = -1197748860;
					}
					continue;
				}
				case 89u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -790539960) ^ 0x788DD2E;
					continue;
				case 87u:
				{
					int num55;
					if (!flag)
					{
						num = -211753842;
						num55 = -211753842;
					}
					else
					{
						num = -1589190107;
						num55 = -1589190107;
					}
					continue;
				}
				case 86u:
					stack.Push(new JSONArray());
					num = -1770881776;
					continue;
				case 85u:
					num = (int)((num2 * 1643901342) ^ 0x30967899);
					continue;
				case 84u:
					num = -942878679;
					continue;
				case 83u:
				{
					int num52;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -656830634;
						num52 = -656830634;
					}
					else
					{
						num = -975986693;
						num52 = -975986693;
					}
					continue;
				}
				case 82u:
				{
					int num46;
					int num47;
					if (jSONNode is JSONArray)
					{
						num46 = 366510020;
						num47 = 366510020;
					}
					else
					{
						num46 = 582948955;
						num47 = 582948955;
					}
					num = num46 ^ ((int)num2 * -1437501080);
					continue;
				}
				case 81u:
					goto IL_07c3;
				case 80u:
					num = ((int)num2 * -821038139) ^ 0x2FB48937;
					continue;
				case 79u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -1483935347;
					continue;
				case 76u:
					num = (int)(num2 * 933820480) ^ -756996375;
					continue;
				case 75u:
					num = ((int)num2 * -1391160677) ^ 0x6221DB0A;
					continue;
				case 74u:
					text = "";
					num = -1585826565;
					continue;
				case 72u:
					num = (int)((num2 * 1655071955) ^ 0xE6AABE7);
					continue;
				case 71u:
					num = ((int)num2 * -1042342591) ^ 0x24F74944;
					continue;
				case 70u:
					num = (int)(num2 * 1978836415) ^ -1636143809;
					continue;
				case 69u:
					flag8 = jSONNode != null;
					num = ((int)num2 * -535575250) ^ 0x33780470;
					continue;
				case 67u:
				{
					int num44;
					int num45;
					if ((uint)c <= 44u)
					{
						num44 = 2077222615;
						num45 = 2077222615;
					}
					else
					{
						num44 = 1721837423;
						num45 = 1721837423;
					}
					num = num44 ^ ((int)num2 * -70849372);
					continue;
				}
				case 66u:
					num = (int)(num2 * 515556938) ^ -1648632296;
					continue;
				case 65u:
					num = (int)((num2 * 38568552) ^ 0x88A2D21);
					continue;
				case 64u:
				{
					int num40;
					int num41;
					if (!(jSONNode is JSONArray))
					{
						num40 = -372337066;
						num41 = -372337066;
					}
					else
					{
						num40 = -799148123;
						num41 = -799148123;
					}
					num = num40 ^ (int)(num2 * 362737228);
					continue;
				}
				case 63u:
					flag = false;
					num = (int)(num2 * 1811518981) ^ -1286148858;
					continue;
				case 62u:
					flag12 = flag;
					num = -774364602;
					continue;
				case 61u:
					num = ((int)num2 * -1516433986) ^ -1006989725;
					continue;
				case 60u:
					num = (int)((num2 * 102629790) ^ 0x1E5F469F);
					continue;
				case 59u:
					num = ((int)num2 * -1244939038) ^ 0x64770D11;
					continue;
				case 58u:
					num = ((int)num2 * -607588534) ^ -2015174594;
					continue;
				case 57u:
				{
					int num38;
					int num39;
					if (!flag11)
					{
						num38 = -1418942651;
						num39 = -1418942651;
					}
					else
					{
						num38 = -802328697;
						num39 = -802328697;
					}
					num = num38 ^ (int)(num2 * 280840265);
					continue;
				}
				case 56u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -465862391) ^ 0x22618A27;
					continue;
				case 55u:
					num = (int)((num2 * 1829455861) ^ 0x777FC787);
					continue;
				case 54u:
				{
					int num37;
					if (c == '{')
					{
						num = -1018849043;
						num37 = -1018849043;
					}
					else
					{
						num = -1487611081;
						num37 = -1487611081;
					}
					continue;
				}
				case 53u:
				{
					int num35;
					int num36;
					if (flag)
					{
						num35 = -353235312;
						num36 = -353235312;
					}
					else
					{
						num35 = -652904015;
						num36 = -652904015;
					}
					num = num35 ^ (int)(num2 * 1191142558);
					continue;
				}
				case 52u:
				{
					int num34;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -1025572434;
						num34 = -1025572434;
					}
					else
					{
						num = -251855572;
						num34 = -251855572;
					}
					continue;
				}
				case 50u:
					c4 = c3;
					num = (int)(num2 * 562244978) ^ -2120151792;
					continue;
				case 49u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1647174342) ^ 0x122E4196);
					continue;
				case 48u:
					num = (int)(num2 * 2015493662) ^ -1567559661;
					continue;
				case 47u:
				{
					int num33;
					if (c4 != 'f')
					{
						num = -2058482057;
						num33 = -2058482057;
					}
					else
					{
						num = -534200184;
						num33 = -534200184;
					}
					continue;
				}
				case 46u:
					num = ((int)num2 * -311415982) ^ -519569609;
					continue;
				case 45u:
				{
					int num31;
					int num32;
					if (flag10)
					{
						num31 = 1987116242;
						num32 = 1987116242;
					}
					else
					{
						num31 = 1584947011;
						num32 = 1584947011;
					}
					num = num31 ^ (int)(num2 * 1599185038);
					continue;
				}
				case 44u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -610088159) ^ 0x2E6C0243;
					continue;
				case 43u:
					num = -447752022;
					continue;
				case 42u:
					num = ((int)num2 * -59708868) ^ -1993553396;
					continue;
				case 41u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -897900040) ^ -1231586899;
					continue;
				case 39u:
					num = ((int)num2 * -1955546241) ^ 0x431CD06;
					continue;
				case 38u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1968575313) ^ -133152266;
					continue;
				case 37u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num12 += 4;
					num = (int)((num2 * 333370123) ^ 0x2121B7F5);
					continue;
				case 36u:
					flag2 = flag;
					num = (int)(num2 * 813404471) ^ -1189353476;
					continue;
				case 35u:
					num = ((int)num2 * -1341513304) ^ -1069277142;
					continue;
				case 34u:
				{
					int num28;
					int num29;
					if (c == ':')
					{
						num28 = -755486953;
						num29 = -755486953;
					}
					else
					{
						num28 = -181624049;
						num29 = -181624049;
					}
					num = num28 ^ ((int)num2 * -1498046247);
					continue;
				}
				case 33u:
				{
					int num27;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -1573038137;
						num27 = -1573038137;
					}
					else
					{
						num = -822808797;
						num27 = -822808797;
					}
					continue;
				}
				case 32u:
					stack.Pop();
					num = -151549295;
					continue;
				case 31u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1209582969) ^ 0x1C79A2DF;
					continue;
				case 30u:
					num = -1363876365;
					continue;
				case 28u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)(num2 * 78956909) ^ -708162691;
					continue;
				case 27u:
					num = -389189459;
					continue;
				case 26u:
				{
					int num23;
					int num24;
					if (!flag8)
					{
						num23 = 494194114;
						num24 = 494194114;
					}
					else
					{
						num23 = 973982997;
						num24 = 973982997;
					}
					num = num23 ^ ((int)num2 * -486255388);
					continue;
				}
				case 24u:
				{
					int num22;
					if ((uint)c <= 93u)
					{
						num = -982101646;
						num22 = -982101646;
					}
					else
					{
						num = -283672929;
						num22 = -283672929;
					}
					continue;
				}
				case 23u:
				{
					int num20;
					int num21;
					if (!flag7)
					{
						num20 = -192300080;
						num21 = -192300080;
					}
					else
					{
						num20 = -44125143;
						num21 = -44125143;
					}
					num = num20 ^ ((int)num2 * -840969237);
					continue;
				}
				case 22u:
					result = jSONNode;
					num = -1794756704;
					continue;
				case 21u:
				{
					int num18;
					int num19;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num18 = 1381985038;
						num19 = 1381985038;
					}
					else
					{
						num18 = 1230909960;
						num19 = 1230909960;
					}
					num = num18 ^ (int)(num2 * 1350141859);
					continue;
				}
				case 20u:
				{
					int num16;
					int num17;
					if (jSONNode != null)
					{
						num16 = -793793728;
						num17 = -793793728;
					}
					else
					{
						num16 = -575279889;
						num17 = -575279889;
					}
					num = num16 ^ ((int)num2 * -815764363);
					continue;
				}
				case 18u:
					flag5 = stack.Count == 0;
					num = -100210900;
					continue;
				case 17u:
				{
					int num13;
					if (c4 == 'n')
					{
						num = -1742319088;
						num13 = -1742319088;
					}
					else
					{
						num = -1579280506;
						num13 = -1579280506;
					}
					continue;
				}
				case 16u:
					num = (int)(num2 * 1215534259) ^ -1796671829;
					continue;
				case 15u:
					text2 = "";
					flag4 = stack.Count > 0;
					num = ((int)num2 * -652623425) ^ 0x465BEF21;
					continue;
				case 14u:
					num = (int)((num2 * 1540409308) ^ 0x12F6E34D);
					continue;
				case 13u:
					c2 = JSONNode.smethod_2(aJSON, num12);
					c3 = c2;
					num = (int)(num2 * 1270996680) ^ -1368997403;
					continue;
				case 12u:
					num = ((int)num2 * -4585255) ^ 0x437D8D17;
					continue;
				case 11u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = ((int)num2 * -1257645960) ^ -1457595121;
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 1872483740;
						num8 = 1872483740;
					}
					else
					{
						num7 = 1145280074;
						num8 = 1145280074;
					}
					num = num7 ^ (int)(num2 * 24431309);
					continue;
				}
				case 9u:
				{
					int num4;
					if (c != '"')
					{
						num = -2050178556;
						num4 = -2050178556;
					}
					else
					{
						num = -420813359;
						num4 = -420813359;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -2032946141) ^ 0x2FF7546F;
					continue;
				case 7u:
					num = ((int)num2 * -1260714994) ^ 0x38B80968;
					continue;
				case 6u:
					num = ((int)num2 * -1060706471) ^ -163346302;
					continue;
				case 5u:
				{
					int num3;
					if (c != ',')
					{
						num = -236238228;
						num3 = -236238228;
					}
					else
					{
						num = -1454269837;
						num3 = -1454269837;
					}
					continue;
				}
				case 3u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num = (int)((num2 * 576974355) ^ 0xDF061C);
					continue;
				case 2u:
					switch (c)
					{
					case '\t':
						break;
					case '\n':
					case '\r':
						goto IL_04ce;
					case '\v':
					case '\f':
						goto IL_07c3;
					default:
						goto IL_0f48;
					}
					goto case 147u;
				case 1u:
					num = ((int)num2 * -1066814133) ^ 0x4C9FB645;
					continue;
				case 0u:
					flag = !flag;
					num = -765840537;
					continue;
				case 101u:
					break;
				case 40u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 100u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0f48:
					num = (int)((num2 * 1762469401) ^ 0x127463DE);
					continue;
					IL_04ce:
					num12++;
					num = -901394569;
					continue;
					IL_0458:
					flag10 = flag;
					num = -1298094219;
					continue;
					IL_043c:
					flag7 = flag;
					num = -963843519;
					continue;
					IL_044a:
					num12++;
					num = -2142152402;
					continue;
					IL_0406:
					s = JSONNode.smethod_8(aJSON, num12 + 1, 4);
					num = -1093833124;
					continue;
					IL_03f0:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -1483935347;
					continue;
					IL_03da:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -600672055;
					continue;
					IL_03d0:
					num = -1599596404;
					continue;
					IL_07c3:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num12).ToString());
					num = -24617127;
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
				int num = 470962089;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55155F74u) % 3u)
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
					num = ((int)num2 * -831437250) ^ -202098617;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008f:
					int num3 = 602858392;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x55155F74u) % 3u)
						{
						case 1u:
							goto IL_005f;
						default:
							goto end_IL_0072;
						case 2u:
							break;
						case 0u:
							goto end_IL_0072;
						}
						goto IL_008f;
						IL_005f:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = ((int)num2 * -681743396) ^ 0x55D25CD9;
						continue;
						end_IL_0072:
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
				int num = -2130274946;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC78ADEBAu) % 5u)
					{
					case 2u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -117644298) ^ 0x3C9BCB0;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1311979567) ^ -1688074097;
						continue;
					case 0u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 67869047) ^ -1496608044;
						continue;
					case 4u:
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
					IL_00cc:
					int num3 = -1838847635;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xC78ADEBAu) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 1526416262) ^ 0x2EF5912A);
							continue;
						case 2u:
							num3 = ((int)num2 * -194846416) ^ -237404705;
							continue;
						default:
							goto end_IL_00ab;
						case 0u:
							break;
						case 1u:
							goto end_IL_00ab;
						}
						goto IL_00cc;
						continue;
						end_IL_00ab:
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
		int num5 = default(int);
		int num6 = default(int);
		JSONNode result = default(JSONNode);
		int num8 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num9 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		bool flag = default(bool);
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 84219320;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x451730A1u) % 36u)
				{
				case 34u:
				{
					int num7;
					if (num5 >= num6)
					{
						num = 386378198;
						num7 = 386378198;
					}
					else
					{
						num = 958708169;
						num7 = 958708169;
					}
					continue;
				}
				case 33u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -73361866) ^ -710045716;
					continue;
				case 32u:
					num8 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num9 = 0;
					num = 829745810;
					continue;
				case 31u:
					num = (int)((num2 * 1199689790) ^ 0x6EED7A6);
					continue;
				case 30u:
					num = ((int)num2 * -84890354) ^ -2086608412;
					continue;
				case 29u:
					goto IL_0091;
				case 28u:
					goto IL_009b;
				case 26u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 1773691749) ^ 0x17557A14);
					continue;
				}
				case 25u:
					num5++;
					num = ((int)num2 * -1156510166) ^ -942168775;
					continue;
				case 24u:
					goto IL_00ec;
				case 23u:
					num9++;
					num = ((int)num2 * -251026493) ^ 0x23E56D15;
					continue;
				case 22u:
					goto IL_010f;
				case 21u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -1502544871) ^ -201372670;
					continue;
				case 20u:
					num = ((int)num2 * -1633259478) ^ 0x17682A4B;
					continue;
				case 19u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)((num2 * 1719996565) ^ 0x357E9395);
					continue;
				case 18u:
					goto IL_0161;
				case 17u:
					num = 1582180671;
					continue;
				case 16u:
					num = ((int)num2 * -1271707227) ^ -114631186;
					continue;
				case 15u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)(num2 * 290832064) ^ -2090882451;
					continue;
				case 14u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.BoolValue:
						goto IL_0091;
					case JSONBinaryTag.DoubleValue:
						goto IL_009b;
					case JSONBinaryTag.IntValue:
						goto IL_00ec;
					case JSONBinaryTag.FloatValue:
						goto IL_010f;
					case JSONBinaryTag.Array:
						goto IL_0161;
					default:
						goto IL_01ce;
					case JSONBinaryTag.Value:
						goto IL_01e1;
					}
					goto case 32u;
				case 11u:
					goto IL_01e1;
				case 12u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 423692720) ^ 0x19B11892);
					continue;
				case 10u:
					num = 932937816;
					continue;
				case 9u:
					flag = num9 < num8;
					num = 871930673;
					continue;
				case 8u:
					jSONArray.Add(Deserialize(aReader));
					num = 1069969079;
					continue;
				case 7u:
					result = jSONArray;
					num = ((int)num2 * -578955795) ^ 0x5C313066;
					continue;
				case 6u:
					num6 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = ((int)num2 * -1496714637) ^ 0x40BC0F4D;
					continue;
				case 5u:
					result = jSONClass;
					num = ((int)num2 * -1310846034) ^ 0x7B8EF3F4;
					continue;
				case 4u:
					num = ((int)num2 * -1708497982) ^ -1527414518;
					continue;
				case 3u:
					num = (int)(num2 * 1483546006) ^ -428811776;
					continue;
				case 2u:
					num5 = 0;
					num = (int)(num2 * 154777975) ^ -106859598;
					continue;
				case 1u:
					num = (int)(num2 * 1297262719) ^ -1366962604;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1991306384;
						num4 = 1991306384;
					}
					else
					{
						num3 = 1986178520;
						num4 = 1986178520;
					}
					num = num3 ^ ((int)num2 * -814320252);
					continue;
				}
				case 35u:
					break;
				case 13u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_01e1:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 1425089490;
					continue;
					IL_01ce:
					num = (int)((num2 * 1858952536) ^ 0x45CC2C2D);
					continue;
					IL_0161:
					num = 531048591;
					continue;
					IL_010f:
					num = 1823200509;
					continue;
					IL_00ec:
					num = 1772821996;
					continue;
					IL_009b:
					num = 1838461546;
					continue;
					IL_0091:
					num = 409406154;
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
					int num = 1733052502;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x3C53D9BBu) % 4u)
						{
						case 2u:
							num = ((int)num2 * -1255236413) ^ -818612767;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = (int)((num2 * 2081455377) ^ 0x53D1B668);
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

	public static JSONNode LoadFromFile(string aFileName)
	{
		FileStream fileStream = JSONNode.smethod_27(aFileName);
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 459667465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22FC5694u) % 3u)
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
					num = ((int)num2 * -930221243) ^ 0x5BA31876;
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
					int num3 = 381721930;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x22FC5694u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 1743884819) ^ -127394473;
							continue;
						case 1u:
							num3 = ((int)num2 * -933533464) ^ 0x2BD5C118;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1957595994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DDE392Fu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1871396707) ^ 0x1C893FA2);
					continue;
				case 1u:
				{
					MemoryStream memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 21684519) ^ -681718849;
					continue;
				}
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
			int num = -1879146744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83A24278u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1943260510) ^ -214059557;
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
