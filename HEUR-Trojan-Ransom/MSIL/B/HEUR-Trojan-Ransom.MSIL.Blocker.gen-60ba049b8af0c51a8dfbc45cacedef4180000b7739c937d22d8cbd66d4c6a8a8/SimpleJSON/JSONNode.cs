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
				int num = -310744198;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4E8C3B8u) % 4u)
					{
					case 2u:
						result = "";
						num = (int)((num2 * 1072426733) ^ 0x5CA8F217);
						continue;
					case 1u:
						num = (int)(num2 * 2003221834) ^ -2062837678;
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

	public virtual int Count
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 759574745;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71D2DC0Du) % 3u)
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
					result = 0;
					num = (int)((num2 * 617680892) ^ 0x77B29663);
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
				int num = 614807980;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F5CC9DBu) % 3u)
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
					num = (int)(num2 * 1405774053) ^ -2060779356;
				}
			}
		}
	}

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1188777765;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFA35702u) % 3u)
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
					result = _003Cget_DeepChilds_003Ed__;
					num = ((int)num2 * -1629289953) ^ 0x76A8DB4E;
				}
			}
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
				int num = 516321164;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4535EECDu) % 8u)
					{
					case 7u:
						num = (int)(num2 * 37826639) ^ -184476633;
						continue;
					case 6u:
						result = 0;
						num = 338906846;
						continue;
					case 4u:
						result = result2;
						num = (int)(num2 * 1570477584) ^ -1031091142;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1301761769;
							num4 = 1301761769;
						}
						else
						{
							num3 = 2016912291;
							num4 = 2016912291;
						}
						num = num3 ^ (int)(num2 * 273524564);
						continue;
					}
					case 1u:
						result2 = 0;
						num = ((int)num2 * -2083177350) ^ -1162680393;
						continue;
					case 0u:
						flag = int.TryParse(Value, out result2);
						num = (int)(num2 * 1499741182) ^ -2064601473;
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
				int num = -1559826718;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA33F2EB4u) % 3u)
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
					num = ((int)num2 * -573729513) ^ 0x5CBCA05;
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
				int num = 1498825571;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5137730u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1578007712) ^ 0x6AC1C1E8;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = 269663998;
							num4 = 269663998;
						}
						else
						{
							num3 = 751540989;
							num4 = 751540989;
						}
						num = num3 ^ (int)(num2 * 1167638114);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1892854037) ^ -247433580;
						continue;
					case 3u:
						result2 = 0f;
						num = (int)((num2 * 2047583588) ^ 0x584F963A);
						continue;
					case 2u:
						result = 0f;
						num = 1947739556;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1049219911) ^ 0x67817A46;
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

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			bool flag = default(bool);
			double result = default(double);
			while (true)
			{
				int num = 365941340;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11419872u) % 9u)
					{
					case 8u:
						result2 = 0.0;
						num = ((int)num2 * -885585126) ^ -864747557;
						continue;
					case 7u:
						flag = double.TryParse(Value, out result2);
						num = (int)(num2 * 1801872393) ^ -304272769;
						continue;
					case 6u:
						result = result2;
						num = ((int)num2 * -1058833639) ^ 0x52D16C10;
						continue;
					case 5u:
						num = (int)((num2 * 870394522) ^ 0x4F15E38D);
						continue;
					case 3u:
						result = 0.0;
						num = 1714552401;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 513866905;
							num4 = 513866905;
						}
						else
						{
							num3 = 1092371055;
							num4 = 1092371055;
						}
						num = num3 ^ (int)(num2 * 1272561282);
						continue;
					}
					case 1u:
						num = (int)(num2 * 828015220) ^ -821448849;
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
			bool result = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -1172140968;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE593438Au) % 7u)
					{
					case 6u:
						result = !JSONNode.smethod_1(Value);
						num = -892675631;
						continue;
					case 5u:
						result = result2;
						num = ((int)num2 * -2013758748) ^ -1116138332;
						continue;
					case 3u:
						result2 = false;
						num = (int)((num2 * 413658274) ^ 0x177F1359);
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = 210489425;
							num4 = 210489425;
						}
						else
						{
							num3 = 1433069397;
							num4 = 1433069397;
						}
						num = num3 ^ ((int)num2 * -1022332176);
						continue;
					}
					case 1u:
						num = (int)(num2 * 1301032147) ^ -1459492359;
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
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -545207730;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB6975872u) % 3u)
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
					num = (int)(num2 * 736579769) ^ -855790931;
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
				int num = 253554008;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D0D7D4Au) % 4u)
					{
					case 2u:
						result = this as JSONClass;
						num = ((int)num2 * -223181464) ^ -1161378969;
						continue;
					case 1u:
						num = (int)((num2 * 26464744) ^ 0x62609475);
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

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 2012318117;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x590A1A14u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 2084086040) ^ -1510452861;
					continue;
				case 1u:
					Add("", aItem);
					num = ((int)num2 * -2009597078) ^ -168140960;
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

	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 574476351;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1DC49C4u) % 3u)
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
				num = ((int)num2 * -1016985361) ^ -990649606;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -164350846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6E21EC8u) % 3u)
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
				num = (int)((num2 * 200415802) ^ 0x6FF9C1A);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -632137452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAF10F29u) % 3u)
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
				num = ((int)num2 * -1425057273) ^ -2011419873;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1514378350;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EAFD2A1u) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = (int)(num2 * 1735732299) ^ -763098464;
					continue;
				case 0u:
					num = (int)((num2 * 625832333) ^ 0x267BFD5C);
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
			int num = 1676766114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7987CB2Cu) % 4u)
				{
				case 2u:
					result = new JSONData(s);
					num = (int)((num2 * 1562944140) ^ 0x5401A231);
					continue;
				case 1u:
					num = ((int)num2 * -1235918806) ^ 0x7BD93BBD;
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
		if (!(d == null))
		{
			goto IL_000c;
		}
		object obj = null;
		goto IL_0047;
		IL_0047:
		string result = (string)obj;
		int num = -176838960;
		goto IL_0020;
		IL_000c:
		num = -1866795809;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x92467868u) % 4u)
			{
			case 2u:
				break;
			case 0u:
				num = ((int)num2 * -2133760248) ^ 0x38C13141;
				continue;
			case 3u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_000c;
		IL_0041:
		obj = d.Value;
		goto IL_0047;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -308075947;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC39D1F95u) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 432094756;
						num5 = 432094756;
					}
					else
					{
						num4 = 1269738542;
						num5 = 1269738542;
					}
					num = num4 ^ ((int)num2 * -1743958553);
					continue;
				}
				case 5u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0033;
				case 4u:
					if (b == null)
					{
						num = ((int)num2 * -376937705) ^ 0x5776A41F;
						continue;
					}
					num3 = 0;
					goto IL_0033;
				case 3u:
					result = (object)a == b;
					num = -1281843714;
					continue;
				case 1u:
					result = true;
					num = (int)(num2 * 505547785) ^ -2146420906;
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0033:
					flag = (byte)num3 != 0;
					num = -670999894;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -296014766;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB96B3351u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = ((int)num2 * -948578306) ^ -2099507885;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 498690117;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E83755Cu) % 3u)
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
				result = (object)this == obj;
				num = (int)(num2 * 2038521947) ^ -1539390611;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = -1291802078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC24EC49u) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = (int)((num2 * 50263770) ^ 0x373B5A36);
					continue;
				case 1u:
					num = (int)(num2 * 30477140) ^ -1574884969;
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

	internal static string Escape(string aText)
	{
		string text = "";
		string result = default(string);
		int num4 = default(int);
		char c2 = default(char);
		char c = default(char);
		char c3 = default(char);
		string string_ = default(string);
		while (true)
		{
			int num = 458430720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5FE88C02u) % 34u)
				{
				case 33u:
					result = text;
					num = ((int)num2 * -582993849) ^ 0x6A31213;
					continue;
				case 32u:
					num = (int)(num2 * 1521996290) ^ -120930344;
					continue;
				case 31u:
					num4 = 0;
					num = ((int)num2 * -1186000120) ^ 0x32EAFF43;
					continue;
				case 30u:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1366740623;
					continue;
				case 29u:
				{
					int num6;
					if (c2 != '"')
					{
						num = 728712584;
						num6 = 728712584;
					}
					else
					{
						num = 1074737567;
						num6 = 1074737567;
					}
					continue;
				}
				case 28u:
					c = c3;
					num = (int)(num2 * 1568094530) ^ -591321116;
					continue;
				case 27u:
					num = 330974066;
					continue;
				case 26u:
					goto IL_00a1;
				case 25u:
					num = ((int)num2 * -1662861956) ^ -294759462;
					continue;
				case 24u:
					num = ((int)num2 * -151643331) ^ 0x4CCE2DB5;
					continue;
				case 23u:
					num = (int)(num2 * 1726445633) ^ -407344493;
					continue;
				case 22u:
					goto IL_00f0;
				case 21u:
					goto IL_0108;
				case 20u:
				{
					int num5;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = 1583185117;
						num5 = 1583185117;
					}
					else
					{
						num = 1111117979;
						num5 = 1111117979;
					}
					continue;
				}
				case 18u:
					num4++;
					num = ((int)num2 * -391561177) ^ -516040746;
					continue;
				case 17u:
					c3 = JSONNode.smethod_2(string_, num4);
					num = 1373743632;
					continue;
				case 16u:
					switch (c2)
					{
					case '\t':
						break;
					case '\f':
						goto IL_00a1;
					case '\v':
						goto IL_00f0;
					case '\r':
						goto IL_0108;
					default:
						goto IL_018d;
					case '\b':
						goto IL_01a0;
					case '\n':
						goto IL_01b6;
					}
					goto case 30u;
				case 8u:
					goto IL_01a0;
				case 0u:
					goto IL_01b6;
				case 15u:
					num = ((int)num2 * -630596557) ^ 0x73E9296A;
					continue;
				case 14u:
					num = ((int)num2 * -1550778167) ^ 0x307AA5D8;
					continue;
				case 13u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 857760747;
					continue;
				case 12u:
					num = ((int)num2 * -1562314621) ^ -1690191747;
					continue;
				case 11u:
				{
					int num3;
					if (c2 == '\\')
					{
						num = 227080060;
						num3 = 227080060;
					}
					else
					{
						num = 176104511;
						num3 = 176104511;
					}
					continue;
				}
				case 10u:
					c2 = c;
					num = ((int)num2 * -1102381619) ^ -2008611058;
					continue;
				case 9u:
					num = ((int)num2 * -251497800) ^ -509254855;
					continue;
				case 7u:
					num = (int)(num2 * 225494151) ^ -888908630;
					continue;
				case 6u:
					string_ = aText;
					num = ((int)num2 * -1756326600) ^ 0x527DF7C1;
					continue;
				case 5u:
					num = ((int)num2 * -776168292) ^ 0xCA657ED;
					continue;
				case 3u:
					num = (int)(num2 * 1232236653) ^ -82408462;
					continue;
				case 2u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 2108803519;
					continue;
				case 1u:
					num = ((int)num2 * -1853587907) ^ 0x2BD6046C;
					continue;
				case 19u:
					break;
				default:
					{
						return result;
					}
					IL_01b6:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1496067585;
					continue;
					IL_01a0:
					text = JSONNode.smethod_3(text, "\\b");
					num = 24396787;
					continue;
					IL_018d:
					num = (int)(num2 * 661758675) ^ -1613322568;
					continue;
					IL_0108:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1496067585;
					continue;
					IL_00f0:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1299300317;
					continue;
					IL_00a1:
					text = JSONNode.smethod_3(text, "\\f");
					num = 404144435;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag14 = default(bool);
		string text = default(string);
		bool flag3 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		string text2 = default(string);
		int num4 = default(int);
		char c4 = default(char);
		bool flag4 = default(bool);
		char c2 = default(char);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag7 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag11 = default(bool);
		char c3 = default(char);
		char c = default(char);
		bool flag15 = default(bool);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = 353098701;
			while (true)
			{
				uint num2;
				string s;
				int num33;
				int num38;
				switch ((num2 = (uint)num ^ 0x52E6BE1Bu) % 154u)
				{
				case 153u:
					num = ((int)num2 * -1056908658) ^ 0x59FB2851;
					continue;
				case 152u:
					flag14 = JSONNode.smethod_6(text, "");
					num = 1465453593;
					continue;
				case 151u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -1358231559;
						num8 = -1358231559;
					}
					else
					{
						num7 = -1181143477;
						num8 = -1181143477;
					}
					num = num7 ^ ((int)num2 * -1752810920);
					continue;
				}
				case 150u:
					num = ((int)num2 * -292973878) ^ -674689128;
					continue;
				case 149u:
					stack.Push(new JSONClass());
					num = 875538160;
					continue;
				case 148u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1772297984) ^ 0x4375D922);
					continue;
				case 147u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -194450987) ^ -1878121429;
					continue;
				case 146u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1628846331) ^ 0x427F73C1;
					continue;
				case 144u:
					text2 = JSONNode.smethod_3(text2, c4.ToString());
					num = 75720005;
					continue;
				case 143u:
					num = (int)(num2 * 1105295040) ^ -84397854;
					continue;
				case 142u:
					num = (int)(num2 * 1113862311) ^ -533618100;
					continue;
				case 141u:
				{
					int num56;
					int num57;
					if (jSONNode != null)
					{
						num56 = 1956129018;
						num57 = 1956129018;
					}
					else
					{
						num56 = 1917760087;
						num57 = 1917760087;
					}
					num = num56 ^ ((int)num2 * -174843784);
					continue;
				}
				case 140u:
				{
					int num47;
					if (num4 < JSONNode.smethod_4(aJSON))
					{
						num = 485229366;
						num47 = 485229366;
					}
					else
					{
						num = 1907489512;
						num47 = 1907489512;
					}
					continue;
				}
				case 139u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1287711959) ^ 0x5B53D037;
					continue;
				case 138u:
					flag4 = !flag4;
					num = 644216837;
					continue;
				case 137u:
					switch (c2)
					{
					case '[':
						goto IL_01c7;
					case '\\':
						goto IL_01e7;
					case ']':
						goto IL_01f9;
					}
					num = 1384320262;
					continue;
				case 33u:
					goto IL_01c7;
				case 14u:
					goto IL_01e7;
				case 131u:
					goto IL_01f9;
				case 136u:
				{
					int num12;
					int num13;
					if ((uint)c2 > 32u)
					{
						num12 = 829758113;
						num13 = 829758113;
					}
					else
					{
						num12 = 1965394871;
						num13 = 1965394871;
					}
					num = num12 ^ ((int)num2 * -1798214460);
					continue;
				}
				case 135u:
				{
					stack.Pop();
					int num61;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1473562283;
						num61 = 1473562283;
					}
					else
					{
						num = 1678242078;
						num61 = 1678242078;
					}
					continue;
				}
				case 134u:
					jSONNode = null;
					num4 = 0;
					num = (int)((num2 * 20571041) ^ 0x6B19D97A);
					continue;
				case 13u:
				case 37u:
				case 53u:
				case 94u:
				case 133u:
					num4++;
					num = 1606842729;
					continue;
				case 132u:
				{
					int num54;
					int num55;
					if (!flag)
					{
						num54 = -1705322797;
						num55 = -1705322797;
					}
					else
					{
						num54 = -1612110759;
						num55 = -1612110759;
					}
					num = num54 ^ ((int)num2 * -1324577721);
					continue;
				}
				case 129u:
					flag2 = flag4;
					num = (int)((num2 * 120805253) ^ 0x5563EDAF);
					continue;
				case 128u:
					num = ((int)num2 * -1560433194) ^ 0x5C43FCC4;
					continue;
				case 127u:
					num = 1936065219;
					continue;
				case 126u:
					flag3 = flag4;
					num = 1654792358;
					continue;
				case 125u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 2103338408) ^ 0x7130B514);
					continue;
				case 124u:
				{
					int num45;
					int num46;
					if (flag7)
					{
						num45 = -1570893509;
						num46 = -1570893509;
					}
					else
					{
						num45 = -1399830477;
						num46 = -1399830477;
					}
					num = num45 ^ ((int)num2 * -680781562);
					continue;
				}
				case 122u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -102372321) ^ -979594710;
					continue;
				case 121u:
					result = jSONNode;
					num = 470067918;
					continue;
				case 120u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -2120226728) ^ -660625990;
					continue;
				case 119u:
					num = ((int)num2 * -1370980124) ^ -1343508474;
					continue;
				case 118u:
					text = "";
					num = 1961076215;
					continue;
				case 117u:
					num = (int)(num2 * 1410368005) ^ -356104906;
					continue;
				case 116u:
					num = (int)((num2 * 1547395149) ^ 0x30476455);
					continue;
				case 115u:
					goto IL_03d7;
				case 114u:
				{
					int num35;
					if (c2 == ',')
					{
						num = 1150063051;
						num35 = 1150063051;
					}
					else
					{
						num = 726084773;
						num35 = 726084773;
					}
					continue;
				}
				case 113u:
				{
					int num29;
					int num30;
					if (!flag11)
					{
						num29 = -357571211;
						num30 = -357571211;
					}
					else
					{
						num29 = -2057329311;
						num30 = -2057329311;
					}
					num = num29 ^ ((int)num2 * -680543180);
					continue;
				}
				case 112u:
					text2 = "";
					num = (int)(num2 * 191208268) ^ -1180575041;
					continue;
				case 111u:
					num = ((int)num2 * -789141477) ^ -264470701;
					continue;
				case 110u:
					num = (int)((num2 * 2083942613) ^ 0xB4988D2);
					continue;
				case 109u:
					text2 = "";
					num = ((int)num2 * -606100937) ^ 0xDAD76D6;
					continue;
				case 108u:
					switch (c3)
					{
					case 's':
						break;
					default:
						goto IL_04b4;
					case 'r':
						goto IL_04be;
					case 't':
						goto IL_04d4;
					case 'u':
						goto IL_04ea;
					}
					goto case 144u;
				case 45u:
					goto IL_04be;
				case 102u:
					goto IL_04d4;
				case 29u:
					goto IL_04ea;
				case 107u:
					num = ((int)num2 * -844017595) ^ -1596544267;
					continue;
				case 106u:
					num = ((int)num2 * -1539065253) ^ -2099849032;
					continue;
				case 105u:
				{
					int num19;
					int num20;
					if ((uint)c3 > 102u)
					{
						num19 = 577107604;
						num20 = 577107604;
					}
					else
					{
						num19 = 932787808;
						num20 = 932787808;
					}
					num = num19 ^ (int)(num2 * 1810119722);
					continue;
				}
				case 104u:
					num = ((int)num2 * -543512405) ^ 0x693A26AA;
					continue;
				case 103u:
					num = 1473562283;
					continue;
				case 101u:
					num = (int)((num2 * 1040749994) ^ 0x36341ED8);
					continue;
				case 100u:
				{
					int num14;
					if (c2 != '"')
					{
						num = 1683361726;
						num14 = 1683361726;
					}
					else
					{
						num = 281896487;
						num14 = 281896487;
					}
					continue;
				}
				case 99u:
				{
					int num9;
					if (flag4)
					{
						num = 1458991104;
						num9 = 1458991104;
					}
					else
					{
						num = 1415732585;
						num9 = 1415732585;
					}
					continue;
				}
				case 98u:
					c = JSONNode.smethod_2(aJSON, num4);
					num = ((int)num2 * -554104440) ^ 0x48C50A44;
					continue;
				case 97u:
					num = ((int)num2 * -1401425576) ^ -1173750760;
					continue;
				case 96u:
				{
					int num60;
					if (c2 != ' ')
					{
						num = 1324848862;
						num60 = 1324848862;
					}
					else
					{
						num = 301351832;
						num60 = 301351832;
					}
					continue;
				}
				case 95u:
				{
					int num58;
					int num59;
					if ((uint)c2 <= 44u)
					{
						num58 = 1864728357;
						num59 = 1864728357;
					}
					else
					{
						num58 = 622943731;
						num59 = 622943731;
					}
					num = num58 ^ (int)(num2 * 958645986);
					continue;
				}
				case 93u:
				{
					int num52;
					int num53;
					if (c3 != 'b')
					{
						num52 = 1278350938;
						num53 = 1278350938;
					}
					else
					{
						num52 = 1795337518;
						num53 = 1795337518;
					}
					num = num52 ^ ((int)num2 * -1343476446);
					continue;
				}
				case 92u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -320184706) ^ 0x76FDB1B;
					continue;
				case 91u:
					num = 466025558;
					continue;
				case 90u:
					num = ((int)num2 * -1745342294) ^ -1948913610;
					continue;
				case 89u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1748843785) ^ 0x270E8069;
					continue;
				case 88u:
					text = text2;
					text2 = "";
					num = 1037178146;
					continue;
				case 87u:
				{
					int num50;
					int num51;
					if (!flag15)
					{
						num50 = 606819092;
						num51 = 606819092;
					}
					else
					{
						num50 = 1403106868;
						num51 = 1403106868;
					}
					num = num50 ^ (int)(num2 * 1263037261);
					continue;
				}
				case 86u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1555392010) ^ 0x6EC209BC;
					continue;
				case 85u:
				{
					int num48;
					int num49;
					if (flag13)
					{
						num48 = 546805739;
						num49 = 546805739;
					}
					else
					{
						num48 = 1921861333;
						num49 = 1921861333;
					}
					num = num48 ^ (int)(num2 * 697569239);
					continue;
				}
				case 84u:
					num = 1357587695;
					continue;
				case 83u:
				{
					int num44;
					if (c3 == 'n')
					{
						num = 1616635472;
						num44 = 1616635472;
					}
					else
					{
						num = 1440539780;
						num44 = 1440539780;
					}
					continue;
				}
				case 82u:
					text = "";
					text2 = "";
					num = 735760225;
					continue;
				case 81u:
					flag8 = stack.Count == 0;
					num = 1562475427;
					continue;
				case 80u:
				{
					int num42;
					int num43;
					if (flag9)
					{
						num42 = 1191103899;
						num43 = 1191103899;
					}
					else
					{
						num42 = 1006682680;
						num43 = 1006682680;
					}
					num = num42 ^ (int)(num2 * 504642637);
					continue;
				}
				case 79u:
				{
					int num41;
					if (c2 != '}')
					{
						num = 432323460;
						num41 = 432323460;
					}
					else
					{
						num = 1227256720;
						num41 = 1227256720;
					}
					continue;
				}
				case 78u:
					num = ((int)num2 * -1440004106) ^ -1226418167;
					continue;
				case 77u:
				{
					char c5 = c4;
					c3 = c5;
					num = ((int)num2 * -728786391) ^ 0x61F7DD35;
					continue;
				}
				case 76u:
					flag15 = jSONNode != null;
					num = ((int)num2 * -823073208) ^ 0x149EAEE8;
					continue;
				case 75u:
					num = (int)((num2 * 1918807714) ^ 0x44C4A3E3);
					continue;
				case 74u:
					num = ((int)num2 * -1435414852) ^ 0x786E5809;
					continue;
				case 73u:
					num = ((int)num2 * -1764529263) ^ 0x23A18FE5;
					continue;
				case 72u:
					num = ((int)num2 * -111026777) ^ -2111836178;
					continue;
				case 71u:
					goto IL_08b9;
				case 70u:
					num = (int)(num2 * 645994865) ^ -1365158822;
					continue;
				case 69u:
					c4 = JSONNode.smethod_2(aJSON, num4);
					num = ((int)num2 * -2146960698) ^ -1780198910;
					continue;
				case 68u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 1501666706) ^ -1491402811;
					continue;
				case 67u:
					text2 = "";
					num = (int)((num2 * 1058886958) ^ 0xE018C3D);
					continue;
				case 66u:
					num = ((int)num2 * -795331764) ^ -1255216358;
					continue;
				case 65u:
				{
					int num39;
					int num40;
					if (!flag12)
					{
						num39 = 323917562;
						num40 = 323917562;
					}
					else
					{
						num39 = 1166736678;
						num40 = 1166736678;
					}
					num = num39 ^ (int)(num2 * 744926532);
					continue;
				}
				case 64u:
					text = "";
					num = ((int)num2 * -1761843064) ^ 0x7E0264F2;
					continue;
				case 63u:
					num = ((int)num2 * -1796839649) ^ -336224279;
					continue;
				case 62u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -991614490) ^ 0x6FBA78D;
					continue;
				case 61u:
					num = ((int)num2 * -859592438) ^ -744749363;
					continue;
				case 60u:
					flag10 = JSONNode.smethod_6(text, "");
					num = 1931436018;
					continue;
				case 59u:
					num = (int)((num2 * 2000669814) ^ 0x5510DA40);
					continue;
				case 58u:
				{
					int num36;
					int num37;
					if (flag14)
					{
						num36 = 1412262542;
						num37 = 1412262542;
					}
					else
					{
						num36 = 1984129886;
						num37 = 1984129886;
					}
					num = num36 ^ ((int)num2 * -844974733);
					continue;
				}
				case 57u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 1271213540;
					continue;
				case 56u:
					flag11 = stack.Count > 0;
					num = ((int)num2 * -589401417) ^ 0x5A296B7C;
					continue;
				case 55u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1535389826) ^ -1138754417;
					continue;
				case 54u:
					text = "";
					text2 = "";
					num = 384299703;
					continue;
				case 52u:
				{
					int num34;
					if (c2 != '{')
					{
						num = 2044226737;
						num34 = 2044226737;
					}
					else
					{
						num = 638786675;
						num34 = 638786675;
					}
					continue;
				}
				case 51u:
					c2 = c;
					num = ((int)num2 * -138605706) ^ 0x7FB93C78;
					continue;
				case 50u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -2036487829) ^ -828976596;
					continue;
				case 49u:
				{
					int num31;
					int num32;
					if (jSONNode is JSONArray)
					{
						num31 = 1300205009;
						num32 = 1300205009;
					}
					else
					{
						num31 = 1918196582;
						num32 = 1918196582;
					}
					num = num31 ^ (int)(num2 * 1970387585);
					continue;
				}
				case 48u:
					jSONNode.Add(text2);
					num = (int)((num2 * 650275150) ^ 0x7D53920E);
					continue;
				case 47u:
				{
					int num27;
					int num28;
					if (!flag10)
					{
						num27 = 1911255607;
						num28 = 1911255607;
					}
					else
					{
						num27 = 972276274;
						num28 = 972276274;
					}
					num = num27 ^ (int)(num2 * 1363372355);
					continue;
				}
				case 46u:
					num = (int)((num2 * 327089517) ^ 0x546F5508);
					continue;
				case 44u:
					stack.Push(new JSONArray());
					num = 1561227187;
					continue;
				case 43u:
					num = (int)(num2 * 515062443) ^ -137996818;
					continue;
				case 42u:
					flag9 = flag4;
					num = 233503847;
					continue;
				case 41u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 1746320899;
					continue;
				case 40u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1899299561) ^ 0x41D2A785;
					continue;
				case 39u:
					flag5 = JSONNode.smethod_6(text, "");
					num = 220848021;
					continue;
				case 38u:
					num = ((int)num2 * -326393719) ^ -1422058336;
					continue;
				case 36u:
					num = (int)(num2 * 1087584217) ^ -2086591729;
					continue;
				case 35u:
					num = ((int)num2 * -326275062) ^ -1094491128;
					continue;
				case 34u:
				{
					int num25;
					int num26;
					if (!flag8)
					{
						num25 = -797742558;
						num26 = -797742558;
					}
					else
					{
						num25 = -2135933354;
						num26 = -2135933354;
					}
					num = num25 ^ (int)(num2 * 1389506677);
					continue;
				}
				case 32u:
				{
					int num24;
					if ((uint)c2 <= 93u)
					{
						num = 1150413027;
						num24 = 1150413027;
					}
					else
					{
						num = 463973095;
						num24 = 463973095;
					}
					continue;
				}
				case 31u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1414716374) ^ -395657275;
					continue;
				case 30u:
					num = (int)((num2 * 1132279310) ^ 0x1B4C3C86);
					continue;
				case 28u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 1249400049;
					continue;
				case 27u:
					num = ((int)num2 * -71120006) ^ 0x2E059C4A;
					continue;
				case 26u:
				{
					int num22;
					int num23;
					if (c2 == ':')
					{
						num22 = -2104236486;
						num23 = -2104236486;
					}
					else
					{
						num22 = -1505137783;
						num23 = -1505137783;
					}
					num = num22 ^ ((int)num2 * -443947259);
					continue;
				}
				case 25u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 1271213540;
					continue;
				case 24u:
					num = ((int)num2 * -1240025609) ^ 0x31F2E73A;
					continue;
				case 23u:
					num = (int)(num2 * 1930827562) ^ -1232419478;
					continue;
				case 22u:
					num = ((int)num2 * -901385002) ^ -2114558252;
					continue;
				case 21u:
					flag4 = false;
					num = ((int)num2 * -901701278) ^ 0x23EB1645;
					continue;
				case 20u:
					num = ((int)num2 * -851908728) ^ -2130616744;
					continue;
				case 19u:
				{
					int num21;
					if (c3 == 'f')
					{
						num = 1446701716;
						num21 = 1446701716;
					}
					else
					{
						num = 2025753467;
						num21 = 2025753467;
					}
					continue;
				}
				case 18u:
					text = "";
					num = 719555228;
					continue;
				case 17u:
					flag6 = jSONNode is JSONArray;
					num = (int)(num2 * 1482162820) ^ -1662301500;
					continue;
				case 16u:
				{
					int num17;
					int num18;
					if (jSONNode is JSONArray)
					{
						num17 = -330321277;
						num18 = -330321277;
					}
					else
					{
						num17 = -2144257316;
						num18 = -2144257316;
					}
					num = num17 ^ (int)(num2 * 616493580);
					continue;
				}
				case 15u:
				{
					int num15;
					int num16;
					if (!flag6)
					{
						num15 = -326117787;
						num16 = -326117787;
					}
					else
					{
						num15 = -986311133;
						num16 = -986311133;
					}
					num = num15 ^ (int)(num2 * 113033332);
					continue;
				}
				case 12u:
					num = (int)((num2 * 1449243166) ^ 0xE74D55F);
					continue;
				case 11u:
					num = 368186191;
					continue;
				case 10u:
				{
					int num10;
					int num11;
					if (flag5)
					{
						num10 = 2056709833;
						num11 = 2056709833;
					}
					else
					{
						num10 = 1255046880;
						num11 = 1255046880;
					}
					num = num10 ^ (int)(num2 * 103320160);
					continue;
				}
				case 9u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1962193212;
						num6 = -1962193212;
					}
					else
					{
						num5 = -989995588;
						num6 = -989995588;
					}
					num = num5 ^ (int)(num2 * 1264895074);
					continue;
				}
				case 8u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					case '\t':
						goto IL_03d7;
					case '\v':
					case '\f':
						goto IL_08b9;
					default:
						goto IL_0ec1;
					}
					goto case 13u;
				case 6u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)((num2 * 346581501) ^ 0x740DAAF2);
					continue;
				case 5u:
					flag = jSONNode is JSONArray;
					num = ((int)num2 * -638866545) ^ -2064551110;
					continue;
				case 4u:
				{
					int num3;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 272414131;
						num3 = 272414131;
					}
					else
					{
						num = 821338132;
						num3 = 821338132;
					}
					continue;
				}
				case 3u:
					num = 55273827;
					continue;
				case 2u:
					jSONNode.Add(text2);
					num = (int)(num2 * 1627040928) ^ -102195272;
					continue;
				case 1u:
					num = (int)((num2 * 1825455435) ^ 0x5720E60D);
					continue;
				case 0u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -2123473483) ^ -1494216189;
					continue;
				case 130u:
					break;
				case 7u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 145u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0ec1:
					num = (int)(num2 * 621558760) ^ -1120170889;
					continue;
					IL_04ea:
					s = JSONNode.smethod_8(aJSON, num4 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num4 += 4;
					num = 1011059965;
					continue;
					IL_04d4:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 1271213540;
					continue;
					IL_04be:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 1360366507;
					continue;
					IL_04b4:
					num = 1068991603;
					continue;
					IL_01c7:
					if (!flag4)
					{
						num = 1177731563;
						num33 = 1177731563;
					}
					else
					{
						num = 266243314;
						num33 = 266243314;
					}
					continue;
					IL_01f9:
					flag12 = flag4;
					num = 798376344;
					continue;
					IL_01e7:
					num4++;
					flag13 = flag4;
					num = 1028291374;
					continue;
					IL_03d7:
					if (flag4)
					{
						num = 1967790233;
						num38 = 1967790233;
					}
					else
					{
						num = 1985591418;
						num38 = 1985591418;
					}
					continue;
					IL_08b9:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = 61060841;
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
				int num = -285431580;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE58C7AA8u) % 3u)
					{
					case 1u:
						goto IL_0020;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0020:
					SaveToStream(fileStream);
					num = (int)(num2 * 908585362) ^ -85737800;
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
					int num3 = -973942232;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE58C7AA8u) % 3u)
						{
						case 1u:
							goto IL_005f;
						default:
							goto end_IL_0072;
						case 0u:
							break;
						case 2u:
							goto end_IL_0072;
						}
						goto IL_008f;
						IL_005f:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)((num2 * 788391947) ^ 0x555C9BC9);
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
			SaveToStream(memoryStream);
			JSONNode.smethod_17((Stream)memoryStream, 0L);
			return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0072:
					int num = 497027252;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x135D27D3u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num = (int)((num2 * 1578142363) ^ 0x545DD49F);
							continue;
						case 1u:
							num = (int)(num2 * 1704942611) ^ -311718578;
							continue;
						default:
							goto end_IL_0051;
						case 0u:
							break;
						case 2u:
							goto end_IL_0051;
						}
						goto IL_0072;
						continue;
						end_IL_0051:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		int num3 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num6 = default(int);
		int num7 = default(int);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		string aKey = default(string);
		JSONClass jSONClass = default(JSONClass);
		int num8 = default(int);
		bool flag = default(bool);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		while (true)
		{
			int num = -682555854;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF07455DEu) % 39u)
				{
				case 38u:
					num = -691327414;
					continue;
				case 37u:
					num3 = 0;
					num = ((int)num2 * -252840652) ^ -2072930957;
					continue;
				case 36u:
					jSONArray.Add(Deserialize(aReader));
					num = -1655790810;
					continue;
				case 35u:
					num = (int)((num2 * 1072347935) ^ 0x3A5A91D9);
					continue;
				case 34u:
					num = (int)((num2 * 1084710459) ^ 0x449A0CA9);
					continue;
				case 33u:
					num = ((int)num2 * -300516756) ^ -565938803;
					continue;
				case 32u:
				{
					int num9;
					if (num3 >= num6)
					{
						num = -1190729281;
						num9 = -1190729281;
					}
					else
					{
						num = -205208611;
						num9 = -205208611;
					}
					continue;
				}
				case 29u:
					num = ((int)num2 * -1551784376) ^ 0x316C52C5;
					continue;
				case 28u:
					num7++;
					num = (int)(num2 * 282309141) ^ -656572287;
					continue;
				case 27u:
					num = -1449374041;
					continue;
				case 26u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -271298790;
					continue;
				case 24u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 895025379) ^ 0x1093904E);
					continue;
				case 23u:
					goto IL_0107;
				case 22u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.IntValue:
						break;
					case JSONBinaryTag.FloatValue:
						goto IL_0107;
					default:
						goto IL_0144;
					case JSONBinaryTag.Array:
						goto IL_0157;
					case JSONBinaryTag.Class:
						goto IL_0161;
					case JSONBinaryTag.Value:
						goto IL_016b;
					case JSONBinaryTag.DoubleValue:
						goto IL_0175;
					case JSONBinaryTag.BoolValue:
						goto IL_018c;
					}
					goto case 26u;
				case 15u:
					goto IL_0157;
				case 4u:
					goto IL_0161;
				case 0u:
					goto IL_016b;
				case 21u:
					goto IL_0175;
				case 16u:
					goto IL_018c;
				case 20u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1608163853) ^ 0x589EF6D4;
					continue;
				case 19u:
					num = (int)((num2 * 1052117601) ^ 0x50D4837D);
					continue;
				case 18u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -2075286881) ^ -1918674313;
					continue;
				}
				case 17u:
					num8 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num7 = 0;
					num = (int)((num2 * 782191734) ^ 0x44149D3B);
					continue;
				case 14u:
					flag = num7 < num8;
					num = -190769595;
					continue;
				case 13u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1776980273) ^ -1855457564;
					continue;
				case 12u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)(num2 * 821847781) ^ -4516575;
					continue;
				case 11u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -359042172) ^ -1905657057;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -1957518703;
						num5 = -1957518703;
					}
					else
					{
						num4 = -251040420;
						num5 = -251040420;
					}
					num = num4 ^ (int)(num2 * 2013025687);
					continue;
				}
				case 9u:
					num3++;
					num = (int)((num2 * 1474726991) ^ 0x2E46E7EA);
					continue;
				case 8u:
					num = (int)(num2 * 1887014328) ^ -375081065;
					continue;
				case 7u:
					result = jSONClass;
					num = (int)(num2 * 1882250881) ^ -1608740976;
					continue;
				case 6u:
					num = ((int)num2 * -1620170401) ^ 0x5FDFF211;
					continue;
				case 5u:
					num = (int)(num2 * 522747348) ^ -50314225;
					continue;
				case 3u:
					num = ((int)num2 * -109298998) ^ -624571831;
					continue;
				case 2u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)(num2 * 972367150) ^ -1141533595;
					continue;
				case 1u:
					result = jSONArray;
					num = ((int)num2 * -1291159354) ^ 0x73BC6BE;
					continue;
				case 25u:
					break;
				case 31u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_018c:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -43044399;
					continue;
					IL_0175:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -185191844;
					continue;
					IL_016b:
					num = -2104218971;
					continue;
					IL_0161:
					num = -1124049501;
					continue;
					IL_0157:
					num = -1354415247;
					continue;
					IL_0144:
					num = (int)(num2 * 1891040705) ^ -256068902;
					continue;
					IL_0107:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1398812244;
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
					int num = 1121359316;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x6B068A02u) % 4u)
						{
						case 3u:
							num = ((int)num2 * -1345656524) ^ -1387930953;
							continue;
						case 2u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = (int)((num2 * 2055965648) ^ 0x1D77323D);
							continue;
						default:
							goto end_IL_0037;
						case 0u:
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
					int num = -1486639849;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x89062E8Fu) % 3u)
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
						JSONNode.smethod_15((IDisposable)fileStream);
						num = ((int)num2 * -1872663364) ^ -1359002049;
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
			int num = 1765711167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD7C4A6u) % 8u)
				{
				case 7u:
					num = ((int)num2 * -46391183) ^ -1577003393;
					continue;
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)(num2 * 588662522) ^ -793479794;
					continue;
				case 4u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 140564614) ^ -1204576719;
					continue;
				case 2u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -646252743) ^ 0x68BFA0F4;
					continue;
				case 1u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)(num2 * 468346885) ^ -1923791018;
					continue;
				case 0u:
					num = ((int)num2 * -1796980488) ^ 0x21F77AAA;
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
