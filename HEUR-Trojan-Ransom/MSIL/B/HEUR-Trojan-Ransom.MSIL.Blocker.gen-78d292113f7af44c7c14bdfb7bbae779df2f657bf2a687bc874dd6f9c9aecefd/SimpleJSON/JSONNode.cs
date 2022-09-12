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
				int num = 2127258697;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2DD9A6DDu) % 3u)
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
					num = ((int)num2 * -1274009044) ^ -1203276986;
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
				int num = 216334508;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x34199330u) % 3u)
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
					num = ((int)num2 * -563071327) ^ -1465982800;
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
				int num = -937963802;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC0BEF73u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -852779187) ^ 0x28F2106A;
						continue;
					case 1u:
						result = "";
						num = (int)((num2 * 691602876) ^ 0x4E94F1D5);
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
				int num = 831229866;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x12759C38u) % 3u)
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
					result = 0;
					num = (int)((num2 * 1372917169) ^ 0x284BBC48);
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
				int num = 2089284463;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x185354D9u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -139856077) ^ -37025888;
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
				int num = 1607211811;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F5EB55Bu) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_DeepChilds_003Ed__;
					num = (int)(num2 * 454242806) ^ -376040636;
				}
			}
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
				int num = -1260137473;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84DC7514u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 69141252;
							num4 = 69141252;
						}
						else
						{
							num3 = 897148113;
							num4 = 897148113;
						}
						num = num3 ^ (int)(num2 * 1240655703);
						continue;
					}
					case 5u:
						result2 = result;
						num = (int)(num2 * 695314913) ^ -1855089738;
						continue;
					case 3u:
						num = ((int)num2 * -1016802642) ^ -1614872860;
						continue;
					case 2u:
						flag = int.TryParse(Value, out result);
						num = ((int)num2 * -835812863) ^ 0x2D294930;
						continue;
					case 1u:
						result2 = 0;
						num = -179958875;
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
				int num = 1977935992;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46B39661u) % 4u)
					{
					case 1u:
						Value = value.ToString();
						num = ((int)num2 * -1253776961) ^ 0x76D410AE;
						continue;
					case 0u:
						num = ((int)num2 * -1221691043) ^ 0x7857A597;
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
			bool flag = default(bool);
			float result2 = default(float);
			float result = default(float);
			while (true)
			{
				int num = 2094063251;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x587E59C3u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -235161356) ^ 0x23E93315;
						continue;
					case 6u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -344145164) ^ 0x3AD89623;
						continue;
					case 4u:
						num = ((int)num2 * -1078977624) ^ 0x4E746395;
						continue;
					case 3u:
						result = 0f;
						num = 580690588;
						continue;
					case 2u:
						result2 = 0f;
						num = (int)((num2 * 2089167758) ^ 0x29C115E);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 370994031;
							num4 = 370994031;
						}
						else
						{
							num3 = 673420964;
							num4 = 673420964;
						}
						num = num3 ^ (int)(num2 * 2088559002);
						continue;
					}
					case 0u:
						result = result2;
						num = (int)(num2 * 340859822) ^ -870363169;
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
				int num = -1911577821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F2996AAu) % 3u)
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
					num = (int)((num2 * 1366052360) ^ 0x737F13E2);
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			bool flag = default(bool);
			double result2 = default(double);
			while (true)
			{
				int num = 1791951396;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3AA3E0B8u) % 7u)
					{
					case 6u:
						num = (int)(num2 * 1568085725) ^ -1526121824;
						continue;
					case 5u:
						flag = double.TryParse(Value, out result);
						num = (int)((num2 * 1406926179) ^ 0x1D733939);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1451947084;
							num4 = 1451947084;
						}
						else
						{
							num3 = 2002329034;
							num4 = 2002329034;
						}
						num = num3 ^ (int)(num2 * 1697782932);
						continue;
					}
					case 3u:
						result2 = 0.0;
						num = 1935115306;
						continue;
					case 2u:
						result2 = result;
						num = ((int)num2 * -591677807) ^ -1745797860;
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
				int num = 63185979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13F871A0u) % 3u)
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
					num = (int)((num2 * 636980625) ^ 0x769F82E0);
				}
			}
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
				int num = 97190826;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x28B5CC47u) % 7u)
					{
					case 6u:
						result = !JSONNode.smethod_1(Value);
						num = 110550515;
						continue;
					case 4u:
						result2 = false;
						num = ((int)num2 * -1091807211) ^ -344536934;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (bool.TryParse(Value, out result2))
						{
							num3 = 1033944504;
							num4 = 1033944504;
						}
						else
						{
							num3 = 2021295983;
							num4 = 2021295983;
						}
						num = num3 ^ (int)(num2 * 1822706259);
						continue;
					}
					case 1u:
						result = result2;
						num = ((int)num2 * -652197217) ^ -64730995;
						continue;
					case 0u:
						num = ((int)num2 * -1784813726) ^ -1554838336;
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
				int num = -1127118075;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA7752CDCu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1650006951) ^ -1899778975;
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = -1891611614;
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
				int num = -1481889051;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC12E01F6u) % 4u)
					{
					case 3u:
						result = this as JSONArray;
						num = (int)((num2 * 716053599) ^ 0x43A251F9);
						continue;
					case 2u:
						num = (int)(num2 * 997955959) ^ -847667419;
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 1121556318;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41F2F203u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -314712534) ^ -1046728275;
						continue;
					case 1u:
						result = this as JSONClass;
						num = (int)(num2 * 1314472779) ^ -1577246873;
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
		while (true)
		{
			int num = 1149740275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x60DD0E73u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				num = (int)(num2 * 1435410320) ^ -844975638;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1081589742;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBF2019Eu) % 3u)
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
				num = ((int)num2 * -924060820) ^ 0x7A05DA95;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1602477092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x593D43B1u) % 4u)
				{
				case 1u:
					result = null;
					num = (int)(num2 * 1671676827) ^ -1924990906;
					continue;
				case 0u:
					num = ((int)num2 * -2053663614) ^ -180936117;
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

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 2120754146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5156E3DEu) % 3u)
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
				num = (int)(num2 * 1585675481) ^ -201888250;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1450942877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x816ADD6Eu) % 4u)
				{
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -1725862543) ^ -1296938973;
					continue;
				case 0u:
					num = (int)(num2 * 453002005) ^ -1930679663;
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

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -651266856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B71FF98u) % 3u)
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
				num = ((int)num2 * -1411668038) ^ -679605010;
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
			int num = -1356487895;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x8CC628BAu) % 4u)
				{
				case 3u:
					if (!(d == null))
					{
						num = (int)((num2 * 866769348) ^ 0x17734B46);
						continue;
					}
					obj = null;
					goto IL_001c;
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
					num = -962488921;
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
			goto IL_0013;
		}
		goto IL_0078;
		IL_0013:
		int num = -1694645939;
		goto IL_0044;
		IL_0044:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xFA52E3FCu) % 6u)
			{
			case 4u:
				break;
			case 2u:
				num = ((int)num2 * -62210094) ^ 0x6AC3E20D;
				continue;
			case 1u:
				result = true;
				num = ((int)num2 * -1018859541) ^ -2041207309;
				continue;
			case 0u:
				result = (object)a == b;
				num = -1242646015;
				continue;
			case 5u:
				goto IL_006d;
			default:
				return result;
			}
			break;
			IL_006d:
			if (a is JSONLazyCreator)
			{
				num = -62039817;
				num3 = -62039817;
				continue;
			}
			goto IL_0078;
		}
		goto IL_0013;
		IL_0078:
		num = -1567780956;
		num3 = -1567780956;
		goto IL_0044;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -865024992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF48E3DCEu) % 3u)
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
				result = !(a == b);
				num = (int)((num2 * 911662743) ^ 0x25FCB6A5);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -361644711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAA8EF8Cu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 220776221) ^ 0x537C1509);
					continue;
				case 1u:
					result = (object)this == obj;
					num = ((int)num2 * -1182386153) ^ -1307579659;
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

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = 1167884444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14E62A5Cu) % 3u)
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
				num = ((int)num2 * -1581011061) ^ -1361516442;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		char c = default(char);
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1905283189;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1BD6E1C0u) % 29u)
				{
				case 28u:
					text = JSONNode.smethod_3(text, "\\f");
					num = 5503163;
					continue;
				case 27u:
					num = (int)((num2 * 1533145150) ^ 0x2CE528FC);
					continue;
				case 26u:
					num = (int)(num2 * 2140423843) ^ -1331182935;
					continue;
				case 24u:
					num = (int)((num2 * 1751757408) ^ 0x1379AFC5);
					continue;
				case 23u:
					switch (c)
					{
					case '\f':
						break;
					default:
						goto IL_0076;
					case '\b':
						goto IL_0089;
					case '\t':
						goto IL_009f;
					case '\n':
						goto IL_00b5;
					case '\v':
						goto IL_00cb;
					case '\r':
						goto IL_00e3;
					}
					goto case 28u;
				case 13u:
					goto IL_0089;
				case 19u:
					goto IL_009f;
				case 22u:
					goto IL_00b5;
				case 17u:
					goto IL_00cb;
				case 1u:
					goto IL_00e3;
				case 21u:
				{
					c2 = JSONNode.smethod_2(string_, num3);
					char c3 = c2;
					c = c3;
					num = 1920534921;
					continue;
				}
				case 20u:
					num = (int)(num2 * 1126069627) ^ -219464237;
					continue;
				case 18u:
					result = text;
					num = ((int)num2 * -1346171179) ^ -1620983845;
					continue;
				case 16u:
					num3++;
					num = 354521168;
					continue;
				case 14u:
					num = ((int)num2 * -1639493855) ^ -534318316;
					continue;
				case 12u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1482432066;
					continue;
				case 11u:
					num = (int)((num2 * 1042879836) ^ 0x3C3C83E3);
					continue;
				case 10u:
					num = (int)((num2 * 502496330) ^ 0x7573F953);
					continue;
				case 9u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 311053663;
					continue;
				case 8u:
					num = (int)((num2 * 179746922) ^ 0x5AA49778);
					continue;
				case 7u:
					num = ((int)num2 * -2068953634) ^ 0x77209611;
					continue;
				case 6u:
					num = ((int)num2 * -1922206542) ^ 0x9566323;
					continue;
				case 5u:
					text = "";
					num = ((int)num2 * -2094513479) ^ 0x70BE219;
					continue;
				case 4u:
				{
					int num6;
					if (c != '\\')
					{
						num = 1597882885;
						num6 = 1597882885;
					}
					else
					{
						num = 1551553582;
						num6 = 1551553582;
					}
					continue;
				}
				case 3u:
				{
					int num5;
					if (c != '"')
					{
						num = 548279951;
						num5 = 548279951;
					}
					else
					{
						num = 2034597513;
						num5 = 2034597513;
					}
					continue;
				}
				case 2u:
				{
					int num4;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = 48540670;
						num4 = 48540670;
					}
					else
					{
						num = 275616155;
						num4 = 275616155;
					}
					continue;
				}
				case 0u:
					string_ = aText;
					num3 = 0;
					num = (int)((num2 * 1604060407) ^ 0x3FF6C4D3);
					continue;
				case 15u:
					break;
				default:
					{
						return result;
					}
					IL_0089:
					text = JSONNode.smethod_3(text, "\\b");
					num = 52433061;
					continue;
					IL_0076:
					num = ((int)num2 * -1083488488) ^ 0x273857DD;
					continue;
					IL_00e3:
					text = JSONNode.smethod_3(text, "\\r");
					num = 330052433;
					continue;
					IL_00cb:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 52433061;
					continue;
					IL_00b5:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1690083129;
					continue;
					IL_009f:
					text = JSONNode.smethod_3(text, "\\t");
					num = 52433061;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag2 = default(bool);
		string text = default(string);
		JSONNode jSONNode = default(JSONNode);
		char c2 = default(char);
		bool flag12 = default(bool);
		int num8 = default(int);
		string text2 = default(string);
		char c = default(char);
		bool flag18 = default(bool);
		bool flag19 = default(bool);
		bool flag10 = default(bool);
		bool flag = default(bool);
		bool flag14 = default(bool);
		bool flag13 = default(bool);
		bool flag11 = default(bool);
		char c5 = default(char);
		char c3 = default(char);
		bool flag6 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag4 = default(bool);
		string s = default(string);
		bool flag8 = default(bool);
		bool flag15 = default(bool);
		bool flag17 = default(bool);
		bool flag16 = default(bool);
		bool flag5 = default(bool);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -1592855911;
			while (true)
			{
				uint num2;
				int num59;
				switch ((num2 = (uint)num ^ 0xEC648B33u) % 157u)
				{
				case 156u:
				{
					int num55;
					int num56;
					if (!flag2)
					{
						num55 = -734931377;
						num56 = -734931377;
					}
					else
					{
						num55 = -456411082;
						num56 = -456411082;
					}
					num = num55 ^ (int)(num2 * 2144066040);
					continue;
				}
				case 155u:
					num = ((int)num2 * -1770652890) ^ 0x450B7A11;
					continue;
				case 154u:
					num = (int)(num2 * 263776888) ^ -982143663;
					continue;
				case 153u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 300263236) ^ -1179662586;
					continue;
				case 152u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1903114987) ^ 0x6FC94B89;
					continue;
				case 151u:
					num = ((int)num2 * -367223241) ^ -1031765699;
					continue;
				case 150u:
					switch (c2)
					{
					case 'r':
						goto IL_00c7;
					case 's':
						goto IL_00dd;
					case 't':
						goto IL_00f5;
					case 'u':
						goto IL_010b;
					}
					num = -947273016;
					continue;
				case 74u:
					goto IL_00c7;
				case 38u:
					goto IL_00dd;
				case 66u:
					goto IL_00f5;
				case 23u:
					goto IL_010b;
				case 149u:
					num = (int)((num2 * 1908946953) ^ 0x795B5B64);
					continue;
				case 148u:
					num = -605438699;
					continue;
				case 147u:
					num = ((int)num2 * -48856361) ^ 0x5D935277;
					continue;
				case 146u:
					num = (int)((num2 * 17757475) ^ 0x6A25D8AF);
					continue;
				case 145u:
					flag12 = jSONNode is JSONArray;
					num = ((int)num2 * -282230909) ^ 0x2C9910B2;
					continue;
				case 43u:
				case 44u:
				case 79u:
				case 98u:
				case 144u:
					num8++;
					num = -1599626030;
					continue;
				case 143u:
					num = (int)((num2 * 2131847260) ^ 0x368C6E61);
					continue;
				case 142u:
					num8 += 4;
					num = (int)(num2 * 1826556864) ^ -1699035296;
					continue;
				case 141u:
					num = (int)(num2 * 1219516544) ^ -844208396;
					continue;
				case 140u:
					num = ((int)num2 * -1747713378) ^ 0x57F6BA3B;
					continue;
				case 139u:
					stack.Push(new JSONArray());
					num = -387145035;
					continue;
				case 138u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1521281981) ^ 0x688B4DD4;
					continue;
				case 137u:
					num = (int)((num2 * 310014907) ^ 0x30E0A4BF);
					continue;
				case 136u:
				{
					int num21;
					if (c != ' ')
					{
						num = -1487185758;
						num21 = -1487185758;
					}
					else
					{
						num = -789351897;
						num21 = -789351897;
					}
					continue;
				}
				case 135u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 484473863) ^ -1786877967;
					continue;
				case 134u:
					num = (int)((num2 * 795851192) ^ 0x418776F8);
					continue;
				case 133u:
					num = (int)(num2 * 320011503) ^ -1451746810;
					continue;
				case 132u:
				{
					int num61;
					int num62;
					if (flag18)
					{
						num61 = 676444680;
						num62 = 676444680;
					}
					else
					{
						num61 = 1063482893;
						num62 = 1063482893;
					}
					num = num61 ^ ((int)num2 * -410546810);
					continue;
				}
				case 131u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -1895084077;
					continue;
				case 130u:
				{
					int num57;
					int num58;
					if (flag19)
					{
						num57 = -1481765124;
						num58 = -1481765124;
					}
					else
					{
						num57 = -1636775738;
						num58 = -1636775738;
					}
					num = num57 ^ ((int)num2 * -1833523873);
					continue;
				}
				case 129u:
					switch (c)
					{
					case '[':
						goto IL_0309;
					case '\\':
						goto IL_0317;
					case ']':
						goto IL_0325;
					}
					num = -350273848;
					continue;
				case 35u:
					goto IL_0309;
				case 33u:
					goto IL_0317;
				case 108u:
					goto IL_0325;
				case 127u:
				{
					int num47;
					int num48;
					if (!flag10)
					{
						num47 = -1710932389;
						num48 = -1710932389;
					}
					else
					{
						num47 = -2059346092;
						num48 = -2059346092;
					}
					num = num47 ^ ((int)num2 * -835914654);
					continue;
				}
				case 126u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -177507462) ^ -955609409;
					continue;
				case 125u:
				{
					int num42;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1678199777;
						num42 = -1678199777;
					}
					else
					{
						num = -145584612;
						num42 = -145584612;
					}
					continue;
				}
				case 124u:
				{
					int num39;
					if (!flag)
					{
						num = -898726189;
						num39 = -898726189;
					}
					else
					{
						num = -1008119348;
						num39 = -1008119348;
					}
					continue;
				}
				case 123u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -234492840) ^ -2120206163;
					continue;
				case 122u:
				{
					int num37;
					if (c2 != 'n')
					{
						num = -1116424545;
						num37 = -1116424545;
					}
					else
					{
						num = -671660970;
						num37 = -671660970;
					}
					continue;
				}
				case 121u:
				{
					int num31;
					int num32;
					if (flag14)
					{
						num31 = -1584559054;
						num32 = -1584559054;
					}
					else
					{
						num31 = -1044916405;
						num32 = -1044916405;
					}
					num = num31 ^ (int)(num2 * 1720437090);
					continue;
				}
				case 120u:
				{
					int num28;
					int num29;
					if (flag13)
					{
						num28 = 2092044957;
						num29 = 2092044957;
					}
					else
					{
						num28 = 1155189818;
						num29 = 1155189818;
					}
					num = num28 ^ ((int)num2 * -1619402729);
					continue;
				}
				case 119u:
					flag11 = stack.Count == 0;
					num = -1193052665;
					continue;
				case 118u:
					c5 = JSONNode.smethod_2(aJSON, num8);
					c3 = c5;
					num = (int)((num2 * 1688386837) ^ 0xEEC89BF);
					continue;
				case 117u:
					jSONNode = null;
					num = (int)(num2 * 920985147) ^ -1324530982;
					continue;
				case 116u:
					flag10 = jSONNode != null;
					num = (int)((num2 * 1115208475) ^ 0x61116346);
					continue;
				case 115u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -787813866;
					continue;
				case 114u:
					num = ((int)num2 * -1171496483) ^ -1046506327;
					continue;
				case 113u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1698365451) ^ 0x14E7108D);
					continue;
				case 112u:
					num = ((int)num2 * -287550077) ^ 0x3F9A8E0A;
					continue;
				case 111u:
					num = (int)((num2 * 1066385335) ^ 0x5E01D38B);
					continue;
				case 110u:
				{
					int num16;
					int num17;
					if (!flag6)
					{
						num16 = 346942513;
						num17 = 346942513;
					}
					else
					{
						num16 = 2052765132;
						num17 = 2052765132;
					}
					num = num16 ^ ((int)num2 * -1780397314);
					continue;
				}
				case 109u:
					c2 = c3;
					num = ((int)num2 * -2136560736) ^ 0x3DA091E0;
					continue;
				case 107u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -967944975) ^ -31607932;
					continue;
				case 106u:
					result = jSONNode;
					num = -1848953932;
					continue;
				case 105u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = 872340591;
						num12 = 872340591;
					}
					else
					{
						num11 = 933329054;
						num12 = 933329054;
					}
					num = num11 ^ (int)(num2 * 64419652);
					continue;
				}
				case 104u:
					num = ((int)num2 * -904170841) ^ 0x516B73AB;
					continue;
				case 103u:
					num = (int)((num2 * 69468217) ^ 0xBFA6204);
					continue;
				case 102u:
				{
					text = "";
					text2 = "";
					int num5;
					if (stack.Count > 0)
					{
						num = -738157673;
						num5 = -738157673;
					}
					else
					{
						num = -486561919;
						num5 = -486561919;
					}
					continue;
				}
				case 101u:
					num = ((int)num2 * -2035416596) ^ 0x5D246BF9;
					continue;
				case 100u:
				{
					int num60;
					if (c != ',')
					{
						num = -542325712;
						num60 = -542325712;
					}
					else
					{
						num = -1242308986;
						num60 = -1242308986;
					}
					continue;
				}
				case 99u:
					num = ((int)num2 * -413587130) ^ -674690322;
					continue;
				case 97u:
					num = ((int)num2 * -551858635) ^ 0x1CD19C65;
					continue;
				case 96u:
					flag19 = jSONNode != null;
					num = ((int)num2 * -697130319) ^ -593673385;
					continue;
				case 95u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1436704186) ^ 0x55E94489);
					continue;
				case 94u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -1081518200) ^ -699763551;
					continue;
				case 93u:
					text2 = "";
					num = (int)(num2 * 798615250) ^ -655517077;
					continue;
				case 92u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_071f;
					case '\t':
						goto IL_0732;
					case '\v':
					case '\f':
						goto IL_0752;
					}
					goto case 43u;
				case 76u:
					goto IL_0732;
				case 37u:
					goto IL_0752;
				case 91u:
				{
					int num53;
					int num54;
					if (flag8)
					{
						num53 = -54932263;
						num54 = -54932263;
					}
					else
					{
						num53 = -126042902;
						num54 = -126042902;
					}
					num = num53 ^ (int)(num2 * 160255416);
					continue;
				}
				case 90u:
				{
					int num51;
					int num52;
					if ((uint)c2 <= 102u)
					{
						num51 = 774672486;
						num52 = 774672486;
					}
					else
					{
						num51 = 1308790674;
						num52 = 1308790674;
					}
					num = num51 ^ (int)(num2 * 2147081148);
					continue;
				}
				case 89u:
				{
					int num49;
					int num50;
					if ((uint)c > 44u)
					{
						num49 = -2070929534;
						num50 = -2070929534;
					}
					else
					{
						num49 = -1884673855;
						num50 = -1884673855;
					}
					num = num49 ^ ((int)num2 * -1054337062);
					continue;
				}
				case 88u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -1112271608;
					continue;
				case 87u:
					num = ((int)num2 * -1929528052) ^ -656270210;
					continue;
				case 86u:
					num = (int)(num2 * 174117457) ^ -1974109513;
					continue;
				case 85u:
					text2 = "";
					text = "";
					flag = false;
					num = (int)(num2 * 1302119317) ^ -1871233104;
					continue;
				case 84u:
					stack.Pop();
					flag14 = JSONNode.smethod_6(text2, "");
					num = -1409188523;
					continue;
				case 83u:
					num = -145584612;
					continue;
				case 82u:
					flag = !flag;
					num = -1940619368;
					continue;
				case 81u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 1959308888) ^ -824604562;
					continue;
				case 80u:
					num = ((int)num2 * -802306370) ^ -241017329;
					continue;
				case 78u:
					num = ((int)num2 * -1862288394) ^ -1630616353;
					continue;
				case 77u:
					num = (int)(num2 * 721102607) ^ -755302481;
					continue;
				case 75u:
					num = (int)((num2 * 567932316) ^ 0x59B35735);
					continue;
				case 73u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1090633579) ^ -1342502376;
					continue;
				case 72u:
					num = ((int)num2 * -1978327026) ^ -326587888;
					continue;
				case 71u:
					num = ((int)num2 * -1454129512) ^ 0x6ADCD839;
					continue;
				case 70u:
					flag13 = flag;
					num = -1668297081;
					continue;
				case 69u:
					num = (int)((num2 * 612796132) ^ 0x3385F600);
					continue;
				case 68u:
				{
					int num45;
					int num46;
					if ((uint)c > 32u)
					{
						num45 = -1711960443;
						num46 = -1711960443;
					}
					else
					{
						num45 = -40860474;
						num46 = -40860474;
					}
					num = num45 ^ ((int)num2 * -611240394);
					continue;
				}
				case 67u:
					num = (int)((num2 * 204664500) ^ 0x398A5C3B);
					continue;
				case 65u:
					flag15 = flag;
					num = ((int)num2 * -1651951600) ^ -67343083;
					continue;
				case 64u:
					num8 = 0;
					num = (int)(num2 * 1919988704) ^ -538620599;
					continue;
				case 63u:
				{
					int num43;
					int num44;
					if (!flag17)
					{
						num43 = 1756092838;
						num44 = 1756092838;
					}
					else
					{
						num43 = 1019267776;
						num44 = 1019267776;
					}
					num = num43 ^ ((int)num2 * -328038396);
					continue;
				}
				case 62u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 402346691) ^ 0x2C71BA9D);
					continue;
				case 60u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 1450671042) ^ -1266648296;
					continue;
				case 59u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 1715670224) ^ -607276449;
					continue;
				case 58u:
					flag16 = JSONNode.smethod_6(text, "");
					num = -1904509496;
					continue;
				case 57u:
					num = -518577595;
					continue;
				case 56u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)((num2 * 530775207) ^ 0x2FA6C84D);
					continue;
				case 55u:
					num = (int)((num2 * 1187674191) ^ 0x22D352C7);
					continue;
				case 54u:
				{
					int num40;
					int num41;
					if (!flag11)
					{
						num40 = -989717264;
						num41 = -989717264;
					}
					else
					{
						num40 = -1652154402;
						num41 = -1652154402;
					}
					num = num40 ^ (int)(num2 * 918132201);
					continue;
				}
				case 53u:
					num = (int)((num2 * 528506851) ^ 0x3B71E9DA);
					continue;
				case 52u:
					stack.Push(new JSONClass());
					num = -1494557201;
					continue;
				case 51u:
					flag5 = JSONNode.smethod_6(text, "");
					num = -1767299252;
					continue;
				case 50u:
				{
					int num38;
					if (c != '{')
					{
						num = -2112378584;
						num38 = -2112378584;
					}
					else
					{
						num = -753111163;
						num38 = -753111163;
					}
					continue;
				}
				case 48u:
					num = ((int)num2 * -94275618) ^ -300102274;
					continue;
				case 47u:
					flag17 = flag;
					num = -1195664197;
					continue;
				case 46u:
				{
					int num35;
					int num36;
					if (flag16)
					{
						num35 = 1167137923;
						num36 = 1167137923;
					}
					else
					{
						num35 = 1083841319;
						num36 = 1083841319;
					}
					num = num35 ^ (int)(num2 * 1133810019);
					continue;
				}
				case 45u:
				{
					int num33;
					int num34;
					if (!flag15)
					{
						num33 = -900107577;
						num34 = -900107577;
					}
					else
					{
						num33 = -983294168;
						num34 = -983294168;
					}
					num = num33 ^ (int)(num2 * 52496523);
					continue;
				}
				case 42u:
				{
					int num30;
					if ((uint)c > 93u)
					{
						num = -1531887889;
						num30 = -1531887889;
					}
					else
					{
						num = -1630939210;
						num30 = -1630939210;
					}
					continue;
				}
				case 41u:
					flag9 = JSONNode.smethod_6(text, "");
					num = -563418709;
					continue;
				case 40u:
					num = (int)(num2 * 1208971303) ^ -1995384108;
					continue;
				case 39u:
					num = -708247986;
					continue;
				case 36u:
					text2 = "";
					num = (int)((num2 * 1919227012) ^ 0x202774C7);
					continue;
				case 34u:
					num = ((int)num2 * -346665458) ^ -964204031;
					continue;
				case 32u:
					text = "";
					num = -1388878596;
					continue;
				case 31u:
					text = text2;
					text2 = "";
					num = -210235684;
					continue;
				case 30u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1854568872) ^ -275530962;
					continue;
				case 29u:
				{
					int num26;
					int num27;
					if (flag12)
					{
						num26 = -893505513;
						num27 = -893505513;
					}
					else
					{
						num26 = -1164303281;
						num27 = -1164303281;
					}
					num = num26 ^ ((int)num2 * -119503460);
					continue;
				}
				case 28u:
				{
					int num25;
					if (c == '"')
					{
						num = -1359478595;
						num25 = -1359478595;
					}
					else
					{
						num = -2060104381;
						num25 = -2060104381;
					}
					continue;
				}
				case 27u:
				{
					int num24;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -675095697;
						num24 = -675095697;
					}
					else
					{
						num = -1294881246;
						num24 = -1294881246;
					}
					continue;
				}
				case 26u:
					flag4 = num8 < JSONNode.smethod_4(aJSON);
					num = -640274351;
					continue;
				case 25u:
				{
					int num22;
					int num23;
					if (flag9)
					{
						num22 = -506109616;
						num23 = -506109616;
					}
					else
					{
						num22 = -140472234;
						num23 = -140472234;
					}
					num = num22 ^ ((int)num2 * -1162611252);
					continue;
				}
				case 24u:
					num = ((int)num2 * -1135920935) ^ -1081962002;
					continue;
				case 22u:
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -1787271647) ^ 0x2B5CBFB2;
					continue;
				case 21u:
					text = "";
					num = -307536547;
					continue;
				case 20u:
					text = "";
					text2 = "";
					num = -1484176343;
					continue;
				case 19u:
					text = JSONNode.smethod_5(text);
					flag6 = jSONNode is JSONArray;
					num = ((int)num2 * -371001963) ^ -1264470260;
					continue;
				case 17u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 1100435321) ^ -1588626281;
					continue;
				case 16u:
					flag3 = jSONNode is JSONArray;
					num = (int)((num2 * 1437276608) ^ 0x5F15E0D6);
					continue;
				case 15u:
				{
					int num19;
					int num20;
					if (!flag7)
					{
						num19 = -825787607;
						num20 = -825787607;
					}
					else
					{
						num19 = -1514697773;
						num20 = -1514697773;
					}
					num = num19 ^ (int)(num2 * 166440322);
					continue;
				}
				case 14u:
				{
					char c4 = JSONNode.smethod_2(aJSON, num8);
					c = c4;
					num = -1895787838;
					continue;
				}
				case 13u:
				{
					int num18;
					if (c == '}')
					{
						num = -694343829;
						num18 = -694343829;
					}
					else
					{
						num = -1198328209;
						num18 = -1198328209;
					}
					continue;
				}
				case 12u:
					s = JSONNode.smethod_8(aJSON, num8 + 1, 4);
					num = ((int)num2 * -1243786583) ^ 0x25C48CDA;
					continue;
				case 11u:
				{
					int num15;
					if (c2 == 'f')
					{
						num = -2121732783;
						num15 = -2121732783;
					}
					else
					{
						num = -353968603;
						num15 = -353968603;
					}
					continue;
				}
				case 10u:
					num = (int)(num2 * 1778103418) ^ -1886682401;
					continue;
				case 9u:
				{
					int num13;
					int num14;
					if (!flag5)
					{
						num13 = -646214457;
						num14 = -646214457;
					}
					else
					{
						num13 = -1755372184;
						num14 = -1755372184;
					}
					num = num13 ^ ((int)num2 * -1736389439);
					continue;
				}
				case 8u:
				{
					int num9;
					int num10;
					if (c2 != 'b')
					{
						num9 = 1955672810;
						num10 = 1955672810;
					}
					else
					{
						num9 = 1889686194;
						num10 = 1889686194;
					}
					num = num9 ^ (int)(num2 * 1468083462);
					continue;
				}
				case 7u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -586822335) ^ 0x4A5E24F;
					continue;
				case 6u:
					num = (int)((num2 * 1078244748) ^ 0xD93462C);
					continue;
				case 5u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -2024782531) ^ 0x69745A9B;
					continue;
				case 4u:
					num = -480788921;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -18224075;
						num7 = -18224075;
					}
					else
					{
						num6 = -554399761;
						num7 = -554399761;
					}
					num = num6 ^ (int)(num2 * 1723372389);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1699397431) ^ 0x4148DF8E;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (c == ':')
					{
						num3 = 302230637;
						num4 = 302230637;
					}
					else
					{
						num3 = 284400574;
						num4 = 284400574;
					}
					num = num3 ^ ((int)num2 * -125677290);
					continue;
				}
				case 0u:
					flag2 = flag;
					num = ((int)num2 * -608097405) ^ -473646512;
					continue;
				case 49u:
					break;
				case 18u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 61u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_010b:
					num = -1766865206;
					continue;
					IL_0325:
					flag7 = flag;
					num = -200408477;
					continue;
					IL_0309:
					flag18 = flag;
					num = -257978377;
					continue;
					IL_00f5:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -751575449;
					continue;
					IL_0317:
					num8++;
					num = -236562515;
					continue;
					IL_00c7:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -1574132655;
					continue;
					IL_0752:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = -1940619368;
					continue;
					IL_0732:
					if (!flag)
					{
						num = -1206990159;
						num59 = -1206990159;
					}
					else
					{
						num = -1659288032;
						num59 = -1659288032;
					}
					continue;
					IL_00dd:
					text2 = JSONNode.smethod_3(text2, c5.ToString());
					num = -1085566247;
					continue;
					IL_071f:
					num = ((int)num2 * -1602966551) ^ -1319975240;
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
			int num = 388836375;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x178979u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1637557772) ^ -1676928212;
					continue;
				case 2u:
				{
					BinaryWriter aWriter = JSONNode.smethod_9(aData);
					Serialize(aWriter);
					num = ((int)num2 * -2084930402) ^ 0x796ADEF2;
					continue;
				}
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
				int num = 241976052;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x54B139EDu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1573369581) ^ 0x2A8DDDF7);
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = ((int)num2 * -997675482) ^ -1512037291;
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
					int num3 = 1227109168;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x54B139EDu) % 4u)
						{
						case 2u:
							num3 = ((int)num2 * -1836993342) ^ 0x879660E;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 1264656402) ^ -1449065659;
							continue;
						default:
							goto end_IL_0094;
						case 0u:
							break;
						case 3u:
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
			string result = default(string);
			while (true)
			{
				int num = 903430690;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AC5D845u) % 5u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 316264220) ^ 0x6D6F92FB);
						continue;
					case 2u:
						num = ((int)num2 * -495091716) ^ -764684688;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1376914207) ^ -1321053650;
						continue;
					case 4u:
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
					IL_00b9:
					int num3 = 1421053934;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x2AC5D845u) % 3u)
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
						num3 = ((int)num2 * -1219222215) ^ 0x4E01D57F;
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
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		int num5 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		int num7 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num = 1342924607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31720D0u) % 39u)
				{
				case 38u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 39369973;
					continue;
				case 37u:
					num = ((int)num2 * -1150661610) ^ 0x20D76E21;
					continue;
				case 36u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = 312283233;
					continue;
				}
				case 35u:
					jSONClass = new JSONClass();
					num5 = 0;
					num = (int)((num2 * 1711285455) ^ 0x5F49CE1);
					continue;
				case 34u:
					goto IL_0072;
				case 33u:
					num = ((int)num2 * -1598127428) ^ -1391861012;
					continue;
				case 32u:
					num = ((int)num2 * -1007262269) ^ 0x511B87C6;
					continue;
				case 31u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -220290608) ^ -293409547;
					continue;
				case 29u:
					result = jSONArray;
					num = ((int)num2 * -1322323940) ^ 0x7CD2E0E5;
					continue;
				case 28u:
					num = ((int)num2 * -55497873) ^ 0x5FCC2C1B;
					continue;
				case 27u:
					num = (int)((num2 * 691017057) ^ 0x2197991D);
					continue;
				case 26u:
					num = (int)((num2 * 717016521) ^ 0x3A7284BC);
					continue;
				case 25u:
					num = (int)(num2 * 613884147) ^ -1052026479;
					continue;
				case 24u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Class:
						goto IL_0072;
					default:
						goto IL_014f;
					case JSONBinaryTag.Array:
						goto IL_0162;
					case JSONBinaryTag.Value:
						goto IL_0173;
					case JSONBinaryTag.IntValue:
						goto IL_017d;
					case JSONBinaryTag.BoolValue:
						goto IL_0187;
					case JSONBinaryTag.FloatValue:
						goto IL_0191;
					}
					goto case 38u;
				case 18u:
					goto IL_0162;
				case 13u:
					goto IL_0173;
				case 23u:
					goto IL_017d;
				case 6u:
					goto IL_0187;
				case 0u:
					goto IL_0191;
				case 22u:
					num7++;
					num = ((int)num2 * -1735613301) ^ -481544136;
					continue;
				case 21u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -500760143) ^ -1926180944;
					continue;
				case 19u:
					num = ((int)num2 * -751775147) ^ -265332249;
					continue;
				case 17u:
					flag = num5 < num6;
					num = 1813146844;
					continue;
				case 16u:
					num = 622621227;
					continue;
				case 15u:
					num = ((int)num2 * -985057043) ^ -895959552;
					continue;
				case 14u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -949185243) ^ -1913918445;
					continue;
				case 12u:
					result = jSONClass;
					num = ((int)num2 * -1143065504) ^ -443213088;
					continue;
				case 11u:
					num5++;
					num = ((int)num2 * -949682346) ^ -1091674138;
					continue;
				case 10u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1344696527) ^ 0x1AD291B1;
					continue;
				case 9u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 991608299) ^ 0x5C7D58B1);
					continue;
				case 8u:
					num = (int)(num2 * 2077262395) ^ -367036670;
					continue;
				case 5u:
					jSONArray = new JSONArray();
					num7 = 0;
					num = (int)((num2 * 234615370) ^ 0x60EF5FFD);
					continue;
				case 4u:
				{
					int num9;
					if (num7 < num8)
					{
						num = 508154078;
						num9 = 508154078;
					}
					else
					{
						num = 1956724170;
						num9 = 1956724170;
					}
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1322058874;
						num4 = 1322058874;
					}
					else
					{
						num3 = 503912760;
						num4 = 503912760;
					}
					num = num3 ^ ((int)num2 * -988000738);
					continue;
				}
				case 2u:
					jSONArray.Add(Deserialize(aReader));
					num = 1766289144;
					continue;
				case 1u:
					num = ((int)num2 * -1861002823) ^ 0x27911FDB;
					continue;
				case 20u:
					break;
				case 7u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0072:
					num6 = JSONNode.smethod_21(aReader);
					num = 2060245070;
					continue;
					IL_0191:
					num = 605278202;
					continue;
					IL_0187:
					num = 1262496519;
					continue;
					IL_017d:
					num = 956127162;
					continue;
					IL_0173:
					num = 4945703;
					continue;
					IL_0162:
					num8 = JSONNode.smethod_21(aReader);
					num = 540653884;
					continue;
					IL_014f:
					num = ((int)num2 * -1090075806) ^ -1227869226;
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
					int num = 1959404219;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x61EE8CA2u) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = ((int)num2 * -1514858360) ^ -678131836;
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
				int num = -775088982;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC46564Au) % 3u)
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
					num = (int)(num2 * 961679609) ^ -1798385459;
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
					int num3 = -153070143;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xDC46564Au) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1449429351) ^ 0x3F170E6C;
							continue;
						case 1u:
							num3 = (int)(num2 * 406754229) ^ -1806797519;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = JSONNode.smethod_29(byte_);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1038931054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CFBB050u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 1726692867) ^ -526370124;
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1011291541) ^ -1076743749;
					continue;
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 1635310731) ^ 0x26E2C43);
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
