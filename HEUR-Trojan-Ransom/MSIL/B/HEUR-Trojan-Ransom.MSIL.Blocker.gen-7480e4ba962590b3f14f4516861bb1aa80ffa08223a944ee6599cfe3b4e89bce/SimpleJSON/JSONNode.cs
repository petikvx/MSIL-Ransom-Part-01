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
				int num = -1954503273;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xACC2C9DEu) % 3u)
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
					num = ((int)num2 * -1081915466) ^ -665571023;
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
				int num = 1019427206;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5CA39035u) % 4u)
					{
					case 3u:
						result = null;
						num = (int)((num2 * 1602211718) ^ 0x328BED9B);
						continue;
					case 0u:
						num = (int)(num2 * 1620257514) ^ -1549611300;
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
			string result = default(string);
			while (true)
			{
				int num = 901780271;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77614E4Du) % 4u)
					{
					case 2u:
						result = "";
						num = (int)(num2 * 546833617) ^ -740554082;
						continue;
					case 1u:
						num = ((int)num2 * -1977341714) ^ -230576745;
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
				int num = 235351072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30469DCu) % 3u)
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
					num = ((int)num2 * -340208673) ^ -1331132443;
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
				int num = 2048988230;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x674E9583u) % 3u)
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
					num = (int)((num2 * 1661089773) ^ 0x722B91AC);
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
				int num = 1089771061;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5FC7539Eu) % 4u)
					{
					case 3u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1543221415) ^ -1475832894;
						continue;
					case 1u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)((num2 * 1942871518) ^ 0x1221B28A);
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
			bool flag = default(bool);
			int result2 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -1563570209;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED9D3275u) % 9u)
					{
					case 8u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -925716131) ^ 0xE33EDBC;
						continue;
					case 7u:
						num = ((int)num2 * -301870581) ^ 0x2938DAE4;
						continue;
					case 5u:
						result = result2;
						num = ((int)num2 * -331190656) ^ -1178709976;
						continue;
					case 4u:
						num = (int)((num2 * 965140734) ^ 0x2224BD63);
						continue;
					case 3u:
						result2 = 0;
						num = (int)((num2 * 393092659) ^ 0x170CD2DE);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 744707527;
							num4 = 744707527;
						}
						else
						{
							num3 = 241574800;
							num4 = 241574800;
						}
						num = num3 ^ (int)(num2 * 89285238);
						continue;
					}
					case 0u:
						result = 0;
						num = -169279082;
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
				int num = -940673835;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8AFCDD4u) % 3u)
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
					num = ((int)num2 * -133330936) ^ 0x70DEFD8B;
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
				int num = -67108321;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC66CDF26u) % 6u)
					{
					case 5u:
						result2 = 0f;
						num = -118127762;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 119711041;
							num4 = 119711041;
						}
						else
						{
							num3 = 1440996858;
							num4 = 1440996858;
						}
						num = num3 ^ (int)(num2 * 1226246763);
						continue;
					}
					case 2u:
						result2 = result;
						num = (int)((num2 * 1872801806) ^ 0x2B045F39);
						continue;
					case 1u:
						num = ((int)num2 * -2109092833) ^ 0x105A7477;
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
				int num = -207397387;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xACDE9A19u) % 3u)
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
					num = (int)((num2 * 854007337) ^ 0x2E054E08);
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
			bool flag = default(bool);
			while (true)
			{
				int num = -2097719972;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0795E71u) % 8u)
					{
					case 6u:
						result = 0.0;
						num = -134307480;
						continue;
					case 5u:
						result2 = 0.0;
						num = (int)((num2 * 1825143551) ^ 0x21B437A1);
						continue;
					case 4u:
						result = result2;
						num = (int)(num2 * 36664074) ^ -1577424730;
						continue;
					case 3u:
						flag = double.TryParse(Value, out result2);
						num = (int)((num2 * 2106430912) ^ 0x79E4D149);
						continue;
					case 1u:
						num = ((int)num2 * -1573174061) ^ -542521243;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1884312303;
							num4 = 1884312303;
						}
						else
						{
							num3 = 1334093;
							num4 = 1334093;
						}
						num = num3 ^ (int)(num2 * 1934491248);
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
		set
		{
			while (true)
			{
				int num = 1148275637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5027FFCu) % 3u)
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
					num = (int)(num2 * 1780180751) ^ -1968298520;
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool flag = default(bool);
			bool result = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = 1693451593;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F3E4ED8u) % 8u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2033984243;
							num4 = -2033984243;
						}
						else
						{
							num3 = -935773684;
							num4 = -935773684;
						}
						num = num3 ^ (int)(num2 * 1507948716);
						continue;
					}
					case 5u:
						result = result2;
						num = (int)((num2 * 241268118) ^ 0x334202F9);
						continue;
					case 4u:
						result = !JSONNode.smethod_1(Value);
						num = 176459930;
						continue;
					case 3u:
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -960435746) ^ -275905660;
						continue;
					case 2u:
						num = (int)((num2 * 632898619) ^ 0x18989CB1);
						continue;
					case 1u:
						result2 = false;
						num = (int)(num2 * 542567890) ^ -476869639;
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
				int num = 276428413;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x3984887A) % 3u)
					{
					case 1u:
						value2 = (value ? "true" : "false");
						goto IL_0013;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0013:
					Value = value2;
					num = 236753977;
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
				int num = -702594477;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF685BC53u) % 3u)
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
					num = (int)((num2 * 1388923190) ^ 0x15D95104);
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
				int num = 16093702;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1BF8DB99u) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = (int)(num2 * 150770758) ^ -1033341877;
						continue;
					case 0u:
						num = ((int)num2 * -1216711568) ^ -1367776352;
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
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1077970145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5AC4818u) % 3u)
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
				num = (int)(num2 * 1188771749) ^ -2116724600;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -531848106;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD6C771Fu) % 3u)
				{
				case 2u:
					goto IL_0004;
				case 0u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0004:
				num = ((int)num2 * -1209635455) ^ 0x144B220B;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 729411748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66545252u) % 3u)
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
				num = (int)((num2 * 772006662) ^ 0x36F904BD);
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
			int num = 870805373;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x230C293Bu) % 3u)
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
				num = ((int)num2 * -1427889312) ^ -1991187766;
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
		IL_0032:
		string result = (string)obj;
		int num = -1164490774;
		goto IL_0011;
		IL_000c:
		num = -1589166011;
		goto IL_0011;
		IL_0011:
		switch ((uint)(num ^ -1824446342) % 3u)
		{
		case 2u:
			break;
		case 1u:
			goto IL_002c;
		default:
			return result;
		}
		goto IL_000c;
		IL_002c:
		obj = d.Value;
		goto IL_0032;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b == null)
		{
			goto IL_0047;
		}
		int num = 0;
		goto IL_007e;
		IL_0075:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_007e;
		IL_0047:
		int num2 = 1463496274;
		goto IL_004c;
		IL_004c:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x77D6BEFCu) % 6u)
			{
			case 5u:
				result = (object)a == b;
				num2 = 932790289;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = -1622192509;
					num5 = -1622192509;
				}
				else
				{
					num4 = -822504005;
					num5 = -822504005;
				}
				num2 = num4 ^ ((int)num3 * -574175762);
				continue;
			}
			case 3u:
				result = true;
				num2 = (int)(num3 * 1406814978) ^ -1686900505;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0075;
			default:
				return result;
			}
			break;
		}
		goto IL_0047;
		IL_007e:
		flag = (byte)num != 0;
		num2 = 1223487470;
		goto IL_004c;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1466554235;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1EC7CA99u) % 3u)
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
				num = ((int)num2 * -1844031928) ^ 0x18B95AF1;
			}
		}
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
			int num = -120140007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9412EF1Eu) % 3u)
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
				num = ((int)num2 * -1848233334) ^ 0x3E56CA39;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = "";
		string string_ = default(string);
		int num4 = default(int);
		char c = default(char);
		string result = default(string);
		char c2 = default(char);
		while (true)
		{
			int num = 1175373254;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x346B621Eu) % 28u)
				{
				case 27u:
					num = ((int)num2 * -1973015168) ^ -1022481219;
					continue;
				case 26u:
					num = (int)((num2 * 525808536) ^ 0x7FBEFEBB);
					continue;
				case 25u:
					num = (int)(num2 * 652045635) ^ -1266775422;
					continue;
				case 24u:
					string_ = aText;
					num4 = 0;
					num = ((int)num2 * -854867546) ^ -814550623;
					continue;
				case 23u:
				{
					int num6;
					if (c != '"')
					{
						num = 1963725224;
						num6 = 1963725224;
					}
					else
					{
						num = 5950182;
						num6 = 5950182;
					}
					continue;
				}
				case 22u:
					text = JSONNode.smethod_3(text, "\\n");
					num = 118078727;
					continue;
				case 21u:
				{
					int num5;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = 1614665025;
						num5 = 1614665025;
					}
					else
					{
						num = 926294701;
						num5 = 926294701;
					}
					continue;
				}
				case 20u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 159134719;
					continue;
				case 19u:
					result = text;
					num = (int)((num2 * 459754799) ^ 0x63B87499);
					continue;
				case 17u:
				{
					char c3 = c2;
					c = c3;
					switch (c)
					{
					case '\n':
						break;
					default:
						goto IL_010c;
					case '\b':
						goto IL_011f;
					case '\t':
						goto IL_0135;
					case '\v':
						goto IL_014b;
					case '\f':
						goto IL_0163;
					case '\r':
						goto IL_0179;
					}
					goto case 22u;
				}
				case 0u:
					goto IL_011f;
				case 14u:
					goto IL_0135;
				case 1u:
					goto IL_014b;
				case 6u:
					goto IL_0163;
				case 2u:
					goto IL_0179;
				case 16u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1646691946;
					continue;
				case 15u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 1005776263;
					continue;
				case 13u:
					num = ((int)num2 * -2064250850) ^ -1868191161;
					continue;
				case 11u:
					num = ((int)num2 * -1118222467) ^ -444562848;
					continue;
				case 10u:
					num = (int)(num2 * 61185702) ^ -610940323;
					continue;
				case 9u:
					num = (int)((num2 * 2069484534) ^ 0x2914473B);
					continue;
				case 8u:
					num = ((int)num2 * -2054252874) ^ -1558915003;
					continue;
				case 7u:
					num = 1233193738;
					continue;
				case 5u:
					num = ((int)num2 * -2087139751) ^ 0x5F87C704;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -8697794) ^ -1932642357;
					continue;
				case 3u:
				{
					int num3;
					if (c != '\\')
					{
						num = 1178161712;
						num3 = 1178161712;
					}
					else
					{
						num = 285980674;
						num3 = 285980674;
					}
					continue;
				}
				case 12u:
					break;
				default:
					{
						return result;
					}
					IL_0179:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1484831293;
					continue;
					IL_0163:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1484831293;
					continue;
					IL_014b:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1531411147;
					continue;
					IL_0135:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1484831293;
					continue;
					IL_011f:
					text = JSONNode.smethod_3(text, "\\b");
					num = 75591945;
					continue;
					IL_010c:
					num = ((int)num2 * -339059623) ^ 0x57F3D646;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		bool flag8 = default(bool);
		string text = default(string);
		char c3 = default(char);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		JSONNode result = default(JSONNode);
		char c = default(char);
		char c2 = default(char);
		int num3 = default(int);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		string text2 = default(string);
		bool flag7 = default(bool);
		bool flag11 = default(bool);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		bool flag12 = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = 1449432963;
			while (true)
			{
				uint num2;
				int num9;
				int num33;
				string s;
				switch ((num2 = (uint)num ^ 0x6A069E2Eu) % 147u)
				{
				case 146u:
				{
					int num20;
					int num21;
					if (!flag8)
					{
						num20 = -1730473516;
						num21 = -1730473516;
					}
					else
					{
						num20 = -1876427254;
						num21 = -1876427254;
					}
					num = num20 ^ (int)(num2 * 1217139583);
					continue;
				}
				case 145u:
					num = (int)((num2 * 480543367) ^ 0x10D493E1);
					continue;
				case 144u:
					text = JSONNode.smethod_3(text, "\t");
					num = 937255549;
					continue;
				case 143u:
				{
					int num11;
					int num12;
					if (c3 != ':')
					{
						num11 = 673641787;
						num12 = 673641787;
					}
					else
					{
						num11 = 1645805903;
						num12 = 1645805903;
					}
					num = num11 ^ (int)(num2 * 544284781);
					continue;
				}
				case 142u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -2131385086) ^ -161090131;
					continue;
				case 141u:
					num = ((int)num2 * -34253296) ^ 0x429B031E;
					continue;
				case 140u:
				{
					int num19;
					if ((uint)c3 <= 93u)
					{
						num = 68233514;
						num19 = 68233514;
					}
					else
					{
						num = 441059751;
						num19 = 441059751;
					}
					continue;
				}
				case 139u:
					result = jSONNode;
					num = 1858482920;
					continue;
				case 138u:
					num = ((int)num2 * -1726821009) ^ -1726230837;
					continue;
				case 137u:
				{
					int num58;
					if (stack.Count != 0)
					{
						num = 1303685688;
						num58 = 1303685688;
					}
					else
					{
						num = 1070921743;
						num58 = 1070921743;
					}
					continue;
				}
				case 136u:
					goto IL_0119;
				case 135u:
					num = ((int)num2 * -124972517) ^ 0x58498E6;
					continue;
				case 134u:
				{
					char c4 = c;
					c2 = c4;
					int num38;
					int num39;
					if ((uint)c2 <= 102u)
					{
						num38 = -2140756665;
						num39 = -2140756665;
					}
					else
					{
						num38 = -844639768;
						num39 = -844639768;
					}
					num = num38 ^ (int)(num2 * 1935555420);
					continue;
				}
				case 133u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = 1667439228;
					continue;
				case 132u:
					num = ((int)num2 * -1117597960) ^ 0x656518EE;
					continue;
				case 131u:
				{
					int num26;
					int num27;
					if (flag10)
					{
						num26 = -2069784540;
						num27 = -2069784540;
					}
					else
					{
						num26 = -2080462081;
						num27 = -2080462081;
					}
					num = num26 ^ (int)(num2 * 1187059759);
					continue;
				}
				case 130u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1121853168;
						num6 = -1121853168;
					}
					else
					{
						num5 = -184119014;
						num6 = -184119014;
					}
					num = num5 ^ (int)(num2 * 2048136387);
					continue;
				}
				case 129u:
					num = 296230132;
					continue;
				case 128u:
					flag10 = jSONNode is JSONArray;
					num = ((int)num2 * -2123572943) ^ -1464243452;
					continue;
				case 127u:
				{
					int num55;
					if (c3 == '"')
					{
						num = 1884755153;
						num55 = 1884755153;
					}
					else
					{
						num = 1400829136;
						num55 = 1400829136;
					}
					continue;
				}
				case 126u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -809805217) ^ -1726073033;
					continue;
				case 125u:
					flag2 = JSONNode.smethod_6(text2, "");
					num = 422497071;
					continue;
				case 124u:
					num = ((int)num2 * -1780378244) ^ 0x4A4D75E0;
					continue;
				case 123u:
					num = (int)(num2 * 1619811859) ^ -1973764418;
					continue;
				case 122u:
					flag7 = jSONNode != null;
					num = (int)((num2 * 212985390) ^ 0x5AF708A4);
					continue;
				case 121u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num3);
					c3 = c5;
					int num49;
					int num50;
					if ((uint)c3 <= 44u)
					{
						num49 = -771631699;
						num50 = -771631699;
					}
					else
					{
						num49 = -427724564;
						num50 = -427724564;
					}
					num = num49 ^ (int)(num2 * 932763370);
					continue;
				}
				case 120u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -685907842) ^ -1935529857;
					continue;
				case 119u:
					num = ((int)num2 * -1824450155) ^ 0xFA736CD;
					continue;
				case 118u:
					num = 392743714;
					continue;
				case 117u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = 1667439228;
					continue;
				case 116u:
					text2 = "";
					text = "";
					num = 1549212053;
					continue;
				case 115u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num3 = 0;
					num = (int)((num2 * 647366308) ^ 0x66115FF8);
					continue;
				case 114u:
					num = ((int)num2 * -1920622547) ^ -468599376;
					continue;
				case 113u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 1806227915) ^ 0x33DB6651);
					continue;
				case 112u:
					num = (int)((num2 * 2015423803) ^ 0x411F49E3);
					continue;
				case 111u:
					num = ((int)num2 * -1515385767) ^ 0x1A0280F5;
					continue;
				case 110u:
					num = ((int)num2 * -507306438) ^ 0x3BCDF6D0;
					continue;
				case 109u:
				{
					int num36;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 191902134;
						num36 = 191902134;
					}
					else
					{
						num = 392743714;
						num36 = 392743714;
					}
					continue;
				}
				case 108u:
					switch (c3)
					{
					case '[':
						goto IL_045d;
					case '\\':
						goto IL_047d;
					case ']':
						goto IL_048f;
					}
					num = 493120979;
					continue;
				case 80u:
					goto IL_045d;
				case 0u:
					goto IL_047d;
				case 91u:
					goto IL_048f;
				case 107u:
					flag11 = flag3;
					num = 1711639282;
					continue;
				case 106u:
					switch (c2)
					{
					case 't':
						break;
					case 'u':
						goto IL_0119;
					default:
						goto IL_04c5;
					case 'r':
						goto IL_04cf;
					case 's':
						goto IL_04e5;
					}
					goto case 144u;
				case 18u:
					goto IL_04cf;
				case 96u:
					goto IL_04e5;
				case 104u:
				{
					int num22;
					int num23;
					if (!flag9)
					{
						num22 = -849970890;
						num23 = -849970890;
					}
					else
					{
						num22 = -1519075324;
						num23 = -1519075324;
					}
					num = num22 ^ ((int)num2 * -1543962357);
					continue;
				}
				case 103u:
					stack.Push(new JSONClass());
					flag6 = jSONNode != null;
					num = 1368976610;
					continue;
				case 102u:
					num = ((int)num2 * -1750804554) ^ -2146552181;
					continue;
				case 101u:
					num = (int)(num2 * 1253845028) ^ -1561785136;
					continue;
				case 100u:
					num = (int)((num2 * 1299956580) ^ 0x629B9E15);
					continue;
				case 5u:
				case 9u:
				case 58u:
				case 92u:
				case 99u:
					goto IL_057d;
				case 98u:
					num = ((int)num2 * -1955979772) ^ -747640442;
					continue;
				case 97u:
					switch (c3)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_057d;
					default:
						goto IL_05bc;
					case '\t':
						goto IL_05cf;
					}
					goto case 133u;
				case 44u:
					goto IL_05cf;
				case 95u:
				{
					int num59;
					int num60;
					if (jSONNode is JSONArray)
					{
						num59 = 2125336278;
						num60 = 2125336278;
					}
					else
					{
						num59 = 700980480;
						num60 = 700980480;
					}
					num = num59 ^ ((int)num2 * -2144601824);
					continue;
				}
				case 94u:
				{
					int num56;
					int num57;
					if ((uint)c3 <= 32u)
					{
						num56 = 1075966264;
						num57 = 1075966264;
					}
					else
					{
						num56 = 489834625;
						num57 = 489834625;
					}
					num = num56 ^ ((int)num2 * -1051762800);
					continue;
				}
				case 93u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -2129423358) ^ -1256045781;
					continue;
				case 90u:
					num = 1471342007;
					continue;
				case 89u:
				{
					int num54;
					if (c3 != ' ')
					{
						num = 1027203009;
						num54 = 1027203009;
					}
					else
					{
						num = 1645812136;
						num54 = 1645812136;
					}
					continue;
				}
				case 88u:
					num = ((int)num2 * -1680659354) ^ -2127407704;
					continue;
				case 87u:
				{
					int num53;
					if (c2 == 'f')
					{
						num = 717967460;
						num53 = 717967460;
					}
					else
					{
						num = 1105177542;
						num53 = 1105177542;
					}
					continue;
				}
				case 86u:
				{
					int num51;
					int num52;
					if (flag12)
					{
						num51 = -1337906598;
						num52 = -1337906598;
					}
					else
					{
						num51 = -232526945;
						num52 = -232526945;
					}
					num = num51 ^ ((int)num2 * -58976155);
					continue;
				}
				case 85u:
					num = ((int)num2 * -1044570478) ^ -1112888914;
					continue;
				case 84u:
				{
					int num47;
					int num48;
					if (!flag)
					{
						num47 = -608913315;
						num48 = -608913315;
					}
					else
					{
						num47 = -1387644111;
						num48 = -1387644111;
					}
					num = num47 ^ ((int)num2 * -2023020136);
					continue;
				}
				case 83u:
					flag12 = flag3;
					num = 882215232;
					continue;
				case 82u:
				{
					int num46;
					if (c3 == ',')
					{
						num = 2132363205;
						num46 = 2132363205;
					}
					else
					{
						num = 1147716916;
						num46 = 1147716916;
					}
					continue;
				}
				case 81u:
					num = (int)((num2 * 690475513) ^ 0x7DD804B7);
					continue;
				case 79u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1513238941) ^ 0x415F2FEC);
					continue;
				case 78u:
					text = JSONNode.smethod_3(text, "\n");
					num = 111286348;
					continue;
				case 77u:
					num = ((int)num2 * -1796691000) ^ 0x7EC77488;
					continue;
				case 76u:
				{
					int num44;
					int num45;
					if (flag6)
					{
						num44 = 499246594;
						num45 = 499246594;
					}
					else
					{
						num44 = 1533655388;
						num45 = 1533655388;
					}
					num = num44 ^ ((int)num2 * -724313618);
					continue;
				}
				case 75u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 2026254448) ^ 0xE6B823D);
					continue;
				case 74u:
					num = ((int)num2 * -2031706160) ^ 0xD6A79B3;
					continue;
				case 73u:
					num = ((int)num2 * -1800096614) ^ 0x6CCFEF25;
					continue;
				case 72u:
					num = (int)((num2 * 308868239) ^ 0x1BED2EC1);
					continue;
				case 71u:
					flag3 = !flag3;
					num = 1500581975;
					continue;
				case 69u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1063720033) ^ -78583434;
					continue;
				case 68u:
					num = 1263337806;
					continue;
				case 67u:
				{
					int num42;
					int num43;
					if (!flag5)
					{
						num42 = -1982285914;
						num43 = -1982285914;
					}
					else
					{
						num42 = -1741188327;
						num43 = -1741188327;
					}
					num = num42 ^ ((int)num2 * -400644493);
					continue;
				}
				case 66u:
				{
					int num40;
					int num41;
					if (!flag11)
					{
						num40 = 1408154688;
						num41 = 1408154688;
					}
					else
					{
						num40 = 213959918;
						num41 = 213959918;
					}
					num = num40 ^ ((int)num2 * -1688409627);
					continue;
				}
				case 65u:
					jSONNode.Add(text);
					num = ((int)num2 * -975409334) ^ -930926893;
					continue;
				case 64u:
					num = ((int)num2 * -1754634148) ^ -2135016487;
					continue;
				case 63u:
				{
					int num37;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1473831718;
						num37 = 1473831718;
					}
					else
					{
						num = 1476480607;
						num37 = 1476480607;
					}
					continue;
				}
				case 62u:
				{
					int num34;
					int num35;
					if (!flag3)
					{
						num34 = -919091802;
						num35 = -919091802;
					}
					else
					{
						num34 = -1902355828;
						num35 = -1902355828;
					}
					num = num34 ^ (int)(num2 * 1601795485);
					continue;
				}
				case 61u:
					num = (int)(num2 * 2118973813) ^ -1851086858;
					continue;
				case 60u:
					num = ((int)num2 * -800644837) ^ -386229792;
					continue;
				case 59u:
					text = "";
					num = ((int)num2 * -1567214660) ^ 0x6146B3C;
					continue;
				case 57u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1163050084) ^ -1780546973;
					continue;
				case 56u:
					num = ((int)num2 * -1021564082) ^ 0x6F99E8DB;
					continue;
				case 55u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -20617267) ^ -1821474409;
					continue;
				case 54u:
					num = ((int)num2 * -1608813724) ^ -1684899099;
					continue;
				case 53u:
					num = ((int)num2 * -2022695440) ^ -137209773;
					continue;
				case 52u:
				{
					int num31;
					int num32;
					if (!flag4)
					{
						num31 = -1334078552;
						num32 = -1334078552;
					}
					else
					{
						num31 = -709026591;
						num32 = -709026591;
					}
					num = num31 ^ ((int)num2 * -274893345);
					continue;
				}
				case 51u:
					stack.Pop();
					num = 284979604;
					continue;
				case 50u:
					num = ((int)num2 * -2144779893) ^ 0x1D0B400A;
					continue;
				case 49u:
				{
					int num30;
					if (c3 == '}')
					{
						num = 1339284018;
						num30 = 1339284018;
					}
					else
					{
						num = 706494698;
						num30 = 706494698;
					}
					continue;
				}
				case 48u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 144085725) ^ 0x1C346B21);
					continue;
				case 47u:
					jSONNode.Add(text);
					num = (int)(num2 * 19233278) ^ -1054022624;
					continue;
				case 46u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num28;
					int num29;
					if (!(jSONNode is JSONArray))
					{
						num28 = 1587616490;
						num29 = 1587616490;
					}
					else
					{
						num28 = 541197838;
						num29 = 541197838;
					}
					num = num28 ^ ((int)num2 * -1670216086);
					continue;
				}
				case 45u:
					num = ((int)num2 * -266614759) ^ -1231812019;
					continue;
				case 43u:
				{
					int num24;
					int num25;
					if (c2 != 'b')
					{
						num24 = -1974818237;
						num25 = -1974818237;
					}
					else
					{
						num24 = -1642444347;
						num25 = -1642444347;
					}
					num = num24 ^ ((int)num2 * -429551698);
					continue;
				}
				case 42u:
					num = ((int)num2 * -608056906) ^ 0x6ED4B30C;
					continue;
				case 41u:
					text2 = text;
					num = 406066846;
					continue;
				case 40u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 2006703573) ^ 0x1B892655);
					continue;
				case 39u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -326218224) ^ -236704605;
					continue;
				case 38u:
				{
					int num17;
					int num18;
					if (flag7)
					{
						num17 = 1486325508;
						num18 = 1486325508;
					}
					else
					{
						num17 = 1437705336;
						num18 = 1437705336;
					}
					num = num17 ^ ((int)num2 * -1542625241);
					continue;
				}
				case 36u:
					num = ((int)num2 * -1495504081) ^ -1254671389;
					continue;
				case 35u:
				{
					int num15;
					int num16;
					if (!JSONNode.smethod_6(text, ""))
					{
						num15 = -1677470373;
						num16 = -1677470373;
					}
					else
					{
						num15 = -1389504904;
						num16 = -1389504904;
					}
					num = num15 ^ (int)(num2 * 1255808542);
					continue;
				}
				case 34u:
					num = (int)(num2 * 1349342655) ^ -1056668142;
					continue;
				case 33u:
				{
					int num14;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 612290560;
						num14 = 612290560;
					}
					else
					{
						num = 1044379408;
						num14 = 1044379408;
					}
					continue;
				}
				case 32u:
				{
					int num13;
					if (c3 == '{')
					{
						num = 255422589;
						num13 = 255422589;
					}
					else
					{
						num = 1321484238;
						num13 = 1321484238;
					}
					continue;
				}
				case 31u:
					text = "";
					num = (int)(num2 * 1217753610) ^ -428814905;
					continue;
				case 30u:
					num = (int)((num2 * 669037943) ^ 0x6B0946A9);
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -478834093) ^ 0x73CE6F98;
					continue;
				case 28u:
					num = (int)((num2 * 1588335892) ^ 0x44ED141A);
					continue;
				case 27u:
				{
					int num10;
					if (num3 >= JSONNode.smethod_4(aJSON))
					{
						num = 1471172430;
						num10 = 1471172430;
					}
					else
					{
						num = 1832242184;
						num10 = 1832242184;
					}
					continue;
				}
				case 26u:
					num = (int)(num2 * 1340039273) ^ -1836481168;
					continue;
				case 25u:
					num = 635451031;
					continue;
				case 24u:
					flag5 = flag3;
					num = 960732044;
					continue;
				case 23u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = 72926374;
					continue;
				case 22u:
					num = ((int)num2 * -162129517) ^ 0x1485063B;
					continue;
				case 21u:
					text = JSONNode.smethod_3(text, "\f");
					num = 1617610531;
					continue;
				case 20u:
					text = "";
					num = ((int)num2 * -607563497) ^ -1245422274;
					continue;
				case 19u:
					num = (int)((num2 * 983460074) ^ 0x5792464F);
					continue;
				case 17u:
					text2 = "";
					text = "";
					num = 1007726908;
					continue;
				case 16u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1270941476) ^ 0x14532995;
					continue;
				case 15u:
					text2 = "";
					flag3 = false;
					num = ((int)num2 * -1933639579) ^ -1219452569;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if (stack.Count > 0)
					{
						num7 = -1325783063;
						num8 = -1325783063;
					}
					else
					{
						num7 = -1316889911;
						num8 = -1316889911;
					}
					num = num7 ^ (int)(num2 * 1846757883);
					continue;
				}
				case 13u:
					num = 1985788382;
					continue;
				case 12u:
					text2 = "";
					num = 1766527568;
					continue;
				case 11u:
					stack.Push(new JSONArray());
					num = 2006510722;
					continue;
				case 10u:
				{
					int num4;
					if (c2 != 'n')
					{
						num = 122632897;
						num4 = 122632897;
					}
					else
					{
						num = 145836587;
						num4 = 145836587;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -863902948) ^ -560511564;
					continue;
				case 7u:
					c = JSONNode.smethod_2(aJSON, num3);
					num = (int)((num2 * 1494643559) ^ 0x7BA23D04);
					continue;
				case 6u:
					text2 = JSONNode.smethod_5(text2);
					flag = jSONNode is JSONArray;
					num = (int)(num2 * 371104504) ^ -1305386136;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, "\b");
					num = 174854686;
					continue;
				case 3u:
					num = ((int)num2 * -1029144593) ^ 0x7AA7B837;
					continue;
				case 2u:
					num = (int)(num2 * 1883891595) ^ -374206077;
					continue;
				case 37u:
					break;
				case 1u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 70u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_05cf:
					if (flag3)
					{
						num = 2008097413;
						num9 = 2008097413;
					}
					else
					{
						num = 1648812897;
						num9 = 1648812897;
					}
					continue;
					IL_05bc:
					num = (int)((num2 * 2145990130) ^ 0x49A1C23);
					continue;
					IL_057d:
					num3++;
					num = 277954941;
					continue;
					IL_04e5:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 492732885;
					continue;
					IL_04c5:
					num = 335815230;
					continue;
					IL_04cf:
					text = JSONNode.smethod_3(text, "\r");
					num = 264978125;
					continue;
					IL_048f:
					flag8 = flag3;
					num = 1810882816;
					continue;
					IL_045d:
					if (flag3)
					{
						num = 1077350270;
						num33 = 1077350270;
					}
					else
					{
						num = 933037636;
						num33 = 933037636;
					}
					continue;
					IL_047d:
					num3++;
					flag9 = flag3;
					num = 1046607373;
					continue;
					IL_0119:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num3 += 4;
					num = 2120377662;
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
			int num = -173735760;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE294571u) % 4u)
				{
				case 3u:
					Serialize(aWriter);
					num = ((int)num2 * -629493466) ^ -444536703;
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = (int)((num2 * 181224616) ^ 0x21FEB7CA);
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
			while (true)
			{
				int num = 1346973298;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5EF0ECD7u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -118448378) ^ -436034019;
						continue;
					case 1u:
						num = (int)(num2 * 508072579) ^ -1364334929;
						continue;
					default:
						return;
					case 2u:
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
					IL_00b4:
					int num3 = 419246190;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x5EF0ECD7u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -322282248) ^ -2056619953;
							continue;
						case 0u:
							num3 = ((int)num2 * -1026962190) ^ 0x35A99541;
							continue;
						default:
							goto end_IL_0093;
						case 3u:
							break;
						case 2u:
							goto end_IL_0093;
						}
						goto IL_00b4;
						continue;
						end_IL_0093:
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
				int num = 431757908;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A0F1B2u) % 4u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)(num2 * 1648604747) ^ -1923034526;
						continue;
					case 2u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -455757180) ^ 0x62EFDCC5;
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
					int num3 = 393415204;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x4A0F1B2u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)(num2 * 712274609) ^ -1794272943;
							continue;
						case 1u:
							num3 = ((int)num2 * -1113694829) ^ 0x5FC19F19;
							continue;
						default:
							goto end_IL_0098;
						case 3u:
							break;
						case 0u:
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
		JSONNode result = default(JSONNode);
		int num5 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		string aKey = default(string);
		JSONClass jSONClass = default(JSONClass);
		int num6 = default(int);
		bool flag = default(bool);
		int num9 = default(int);
		int num8 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		while (true)
		{
			int num = 703453498;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x468D51BEu) % 36u)
				{
				case 35u:
					num = 24307663;
					continue;
				case 34u:
					num = (int)((num2 * 1062220693) ^ 0x32760679);
					continue;
				case 33u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1280854558) ^ 0x737F1CC9;
					continue;
				case 32u:
					num = 1228123272;
					continue;
				case 31u:
					num5++;
					num = ((int)num2 * -2090901095) ^ -404993564;
					continue;
				case 30u:
					goto IL_006c;
				case 29u:
					goto IL_0076;
				case 28u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -46234459) ^ 0x39A3C88E;
					continue;
				case 27u:
					result = jSONArray;
					num = ((int)num2 * -215068091) ^ -1591514092;
					continue;
				case 26u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 2019167667) ^ 0x74AA383F);
					continue;
				case 25u:
					goto IL_00d4;
				case 23u:
					num = ((int)num2 * -1958749210) ^ -703478004;
					continue;
				case 22u:
					jSONArray.Add(Deserialize(aReader));
					num = 306003093;
					continue;
				case 20u:
					num = ((int)num2 * -740735109) ^ -57948425;
					continue;
				case 19u:
					result = jSONClass;
					num = ((int)num2 * -38569675) ^ -409832013;
					continue;
				case 18u:
					num = ((int)num2 * -1652589495) ^ -270394083;
					continue;
				case 17u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1556405174) ^ 0x8E75A38;
					continue;
				case 16u:
					flag = num9 < num8;
					num = 34009801;
					continue;
				case 15u:
					goto IL_0171;
				case 14u:
					num5 = 0;
					num = (int)((num2 * 214092360) ^ 0x2DB778E7);
					continue;
				case 13u:
					goto IL_019e;
				case 12u:
					num = (int)(num2 * 1269411276) ^ -1585056853;
					continue;
				case 11u:
					num9++;
					num = (int)(num2 * 1945401420) ^ -919972182;
					continue;
				case 10u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.FloatValue:
						break;
					case JSONBinaryTag.Value:
						goto IL_006c;
					case JSONBinaryTag.BoolValue:
						goto IL_0076;
					case JSONBinaryTag.Array:
						goto IL_00d4;
					case JSONBinaryTag.IntValue:
						goto IL_0171;
					case JSONBinaryTag.DoubleValue:
						goto IL_019e;
					default:
						goto IL_0205;
					case JSONBinaryTag.Class:
						goto IL_0218;
					}
					goto case 35u;
				case 5u:
					goto IL_0218;
				case 9u:
				{
					int num7;
					if (num5 < num6)
					{
						num = 1750659164;
						num7 = 1750659164;
					}
					else
					{
						num = 1750172845;
						num7 = 1750172845;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -1450043836) ^ -2073294728;
					continue;
				case 7u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1204672100) ^ -1659250499;
					continue;
				}
				case 6u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)(num2 * 520861742) ^ -331995137;
					continue;
				case 4u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -1870415151) ^ 0xD5A9D2C;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1954845145;
						num4 = 1954845145;
					}
					else
					{
						num3 = 627735290;
						num4 = 627735290;
					}
					num = num3 ^ (int)(num2 * 360569940);
					continue;
				}
				case 1u:
					num = ((int)num2 * -741403751) ^ 0x7F9400D6;
					continue;
				case 0u:
					jSONArray = new JSONArray();
					num = (int)(num2 * 340109065) ^ -2117273828;
					continue;
				case 24u:
					break;
				case 2u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0218:
					num8 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num9 = 0;
					num = 506613197;
					continue;
					IL_0205:
					num = ((int)num2 * -822089584) ^ 0x264AC162;
					continue;
					IL_019e:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 808100312;
					continue;
					IL_0171:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 893739718;
					continue;
					IL_00d4:
					num = 789809239;
					continue;
					IL_0076:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = 1026920330;
					continue;
					IL_006c:
					num = 1450009512;
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
				int num = -1052995686;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDDF55964u) % 3u)
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
					result = Deserialize(binaryReader);
					num = (int)((num2 * 274868055) ^ 0x7A60B1C4);
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
					int num3 = -260812766;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xDDF55964u) % 3u)
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
						num3 = (int)((num2 * 1470191008) ^ 0x2B247A1C);
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
					IL_0058:
					int num = -819489159;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xDB1B289Cu) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 2058400723) ^ 0x45694E7);
							continue;
						case 0u:
							num = ((int)num2 * -334850446) ^ 0x3AC2AE46;
							continue;
						default:
							goto end_IL_0037;
						case 3u:
							break;
						case 2u:
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
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 332747928;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x118EFF89u) % 8u)
				{
				case 7u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)(num2 * 131093483) ^ -1739455158;
					continue;
				case 6u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 1240561702) ^ 0x77BD6189);
					continue;
				case 5u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1028243935) ^ 0x130085C9);
					continue;
				case 4u:
					num = ((int)num2 * -1474386960) ^ 0x5F819E34;
					continue;
				case 3u:
					num = (int)((num2 * 1087197010) ^ 0x26627E5F);
					continue;
				case 1u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)(num2 * 2017011097) ^ -713255089;
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
