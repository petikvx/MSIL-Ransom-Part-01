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
				int num = -1354461581;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3F6ADE6u) % 4u)
					{
					case 1u:
						result = null;
						num = ((int)num2 * -1207733293) ^ 0x1BE498A5;
						continue;
					case 0u:
						num = (int)((num2 * 1426758034) ^ 0x175CDF5C);
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
				int num = -211641924;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC65106C1u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 679953041) ^ -1627773926;
						continue;
					case 1u:
						result = "";
						num = (int)((num2 * 1278830045) ^ 0x2452D30F);
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
				int num = -747896578;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8125B009u) % 3u)
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
					num = ((int)num2 * -7556127) ^ 0x443A6CA4;
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
				int num = -1806858434;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBD140328u) % 3u)
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
					num = ((int)num2 * -2074799752) ^ 0x76D53629;
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
				int num = -1999024802;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE7BBF783u) % 4u)
					{
					case 2u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)((num2 * 1761290588) ^ 0x726B46E7);
						continue;
					case 1u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 471405116) ^ -1706797731;
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

	public virtual int AsInt
	{
		get
		{
			int result = default(int);
			int result2 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -2036476968;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFD3992Du) % 6u)
					{
					case 4u:
						result = result2;
						num = (int)(num2 * 1573687923) ^ -96670671;
						continue;
					case 3u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -1296448891) ^ -1942607966;
						continue;
					case 1u:
						result = 0;
						num = -1045982225;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1980286382;
							num4 = -1980286382;
						}
						else
						{
							num3 = -73067781;
							num4 = -73067781;
						}
						num = num3 ^ ((int)num2 * -1220846614);
						continue;
					}
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
			float result = default(float);
			float result2 = default(float);
			while (true)
			{
				int num = 1406950531;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6EC751F1u) % 8u)
					{
					case 7u:
						result = 0f;
						num = 2118582778;
						continue;
					case 5u:
						num = ((int)num2 * -780403328) ^ -1288255403;
						continue;
					case 3u:
						num = ((int)num2 * -65566832) ^ -397815579;
						continue;
					case 2u:
						result2 = 0f;
						num = ((int)num2 * -562102924) ^ -1023014360;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = 1140579283;
							num4 = 1140579283;
						}
						else
						{
							num3 = 67597956;
							num4 = 67597956;
						}
						num = num3 ^ ((int)num2 * -117800526);
						continue;
					}
					case 0u:
						result = result2;
						num = ((int)num2 * -1999033664) ^ 0xD7AEBE4;
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

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			double result = default(double);
			while (true)
			{
				int num = -168843400;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE69117Du) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1319917320) ^ 0x7363E31B);
						continue;
					case 4u:
						result2 = 0.0;
						num = (int)(num2 * 1602841959) ^ -1150420662;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (double.TryParse(Value, out result2))
						{
							num3 = -1905318275;
							num4 = -1905318275;
						}
						else
						{
							num3 = -156159798;
							num4 = -156159798;
						}
						num = num3 ^ (int)(num2 * 663032014);
						continue;
					}
					case 1u:
						result = result2;
						num = (int)((num2 * 1666748349) ^ 0x10A4975C);
						continue;
					case 0u:
						result = 0.0;
						num = -448140589;
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
				int num = -2081890468;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C3F6C06u) % 3u)
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
					num = (int)(num2 * 601381757) ^ -1464360088;
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
				int num = 204714813;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C7EF23Du) % 6u)
					{
					case 5u:
						result = result2;
						num = (int)(num2 * 831152620) ^ -1845759325;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = -1360260176;
							num4 = -1360260176;
						}
						else
						{
							num3 = -251781092;
							num4 = -251781092;
						}
						num = num3 ^ (int)(num2 * 1105173543);
						continue;
					}
					case 2u:
						result2 = false;
						num = (int)(num2 * 793537376) ^ -1539695549;
						continue;
					case 1u:
						result = !JSONNode.smethod_1(Value);
						num = 1258973735;
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
				int num = -221581492;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ -1343715713) % 3u)
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
					num = -1400169273;
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
				int num = -1238914163;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFE2424Bu) % 3u)
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
					num = ((int)num2 * -705659362) ^ 0x47DC8613;
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
				int num = -1870267219;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x80F6E3C0u) % 3u)
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
					result = this as JSONClass;
					num = (int)(num2 * 1472921713) ^ -764194712;
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
			int num = -953582703;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2186497u) % 4u)
				{
				case 2u:
					Add("", aItem);
					num = (int)(num2 * 1838323100) ^ -131339222;
					continue;
				case 1u:
					num = (int)(num2 * 1565986333) ^ -796926174;
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

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 2105674494;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3900A652u) % 3u)
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
				num = (int)((num2 * 1506598208) ^ 0x65B51A8F);
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = 22797739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7180CAu) % 3u)
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
				num = ((int)num2 * -1288620348) ^ 0x69E9D912;
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
			int num = 942709615;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F353CA7u) % 3u)
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
				num = ((int)num2 * -1047332487) ^ -535574371;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -74522995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB33AFB48u) % 4u)
				{
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -996552958) ^ 0x549BE3FA;
					continue;
				case 0u:
					num = (int)(num2 * 1777972101) ^ -1246623461;
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
			int num = 678864029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5FAA4788u) % 4u)
				{
				case 1u:
					result = new JSONData(s);
					num = ((int)num2 * -1394540822) ^ -1037163458;
					continue;
				case 0u:
					num = (int)(num2 * 560897476) ^ -2074668462;
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
			int num = -164097323;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xEFBCBABFu) % 4u)
				{
				case 2u:
					if (!(d == null))
					{
						num = (int)((num2 * 988943815) ^ 0x9DCCF38);
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
					obj = d.Value;
					goto IL_001c;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = -873416801;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 368816086;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6F792464u) % 7u)
				{
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 688706313;
						num5 = 688706313;
					}
					else
					{
						num4 = 1476991513;
						num5 = 1476991513;
					}
					num = num4 ^ (int)(num2 * 2124355144);
					continue;
				}
				case 5u:
					result = (object)a == b;
					num = 2083223733;
					continue;
				case 3u:
					if (b == null)
					{
						num = ((int)num2 * -1291625233) ^ 0x5A0DF342;
						continue;
					}
					num3 = 0;
					goto IL_0049;
				case 2u:
					result = true;
					num = ((int)num2 * -30037975) ^ -481848672;
					continue;
				case 1u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0049;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0049:
					flag = (byte)num3 != 0;
					num = 1356673594;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator !=(JSONNode a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		bool result = (object)this == obj;
		while (true)
		{
			int num = -1049470403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87F2DE14u) % 3u)
				{
				case 2u:
					goto IL_0007;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0007:
				num = ((int)num2 * -1243079229) ^ -224241831;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -1728339519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF76AD866u) % 3u)
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
				num = (int)((num2 * 1085567919) ^ 0x454200C5);
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = "";
		string result = default(string);
		char c2 = default(char);
		string string_ = default(string);
		int num4 = default(int);
		char c = default(char);
		while (true)
		{
			int num = 429412697;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x142B3A91u) % 29u)
				{
				case 28u:
					result = text;
					num = ((int)num2 * -1614342823) ^ 0x70FBE703;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1750188972;
					continue;
				case 25u:
					num = ((int)num2 * -1811272527) ^ 0x31266479;
					continue;
				case 24u:
					num = ((int)num2 * -1502074528) ^ -867322128;
					continue;
				case 23u:
					num = ((int)num2 * -1390140250) ^ -1056948834;
					continue;
				case 22u:
					num = ((int)num2 * -1512531192) ^ 0x589D741C;
					continue;
				case 21u:
					string_ = aText;
					num4 = 0;
					num = (int)(num2 * 1347435420) ^ -1277240733;
					continue;
				case 20u:
					num = (int)(num2 * 186397002) ^ -693926800;
					continue;
				case 19u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 152454936;
					continue;
				case 17u:
					num = ((int)num2 * -662050698) ^ -2035907800;
					continue;
				case 16u:
					switch (c)
					{
					case '\v':
						break;
					default:
						goto IL_00f9;
					case '\b':
						goto IL_010c;
					case '\t':
						goto IL_0122;
					case '\n':
						goto IL_0138;
					case '\f':
						goto IL_014e;
					case '\r':
						goto IL_0164;
					}
					goto case 26u;
				case 12u:
					goto IL_010c;
				case 9u:
					goto IL_0122;
				case 2u:
					goto IL_0138;
				case 6u:
					goto IL_014e;
				case 4u:
					goto IL_0164;
				case 15u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 677612872;
					continue;
				case 14u:
					num4++;
					num = 1636063020;
					continue;
				case 13u:
					num = (int)(num2 * 476231027) ^ -395818044;
					continue;
				case 11u:
				{
					char c3 = c2;
					c = c3;
					num = (int)(num2 * 1810868014) ^ -1543371785;
					continue;
				}
				case 10u:
				{
					int num6;
					if (c != '"')
					{
						num = 1292077390;
						num6 = 1292077390;
					}
					else
					{
						num = 268886741;
						num6 = 268886741;
					}
					continue;
				}
				case 8u:
				{
					int num5;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = 711146481;
						num5 = 711146481;
					}
					else
					{
						num = 1474726661;
						num5 = 1474726661;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -1089456886) ^ -1832092776;
					continue;
				case 5u:
					num = ((int)num2 * -1190636159) ^ -1530496694;
					continue;
				case 3u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 85502804;
					continue;
				case 1u:
				{
					int num3;
					if (c == '\\')
					{
						num = 1511812621;
						num3 = 1511812621;
					}
					else
					{
						num = 1265246049;
						num3 = 1265246049;
					}
					continue;
				}
				case 0u:
					num = ((int)num2 * -1799356446) ^ -1722081591;
					continue;
				case 18u:
					break;
				default:
					{
						return result;
					}
					IL_0164:
					text = JSONNode.smethod_3(text, "\\r");
					num = 85502804;
					continue;
					IL_014e:
					text = JSONNode.smethod_3(text, "\\f");
					num = 271488075;
					continue;
					IL_0138:
					text = JSONNode.smethod_3(text, "\\n");
					num = 381476598;
					continue;
					IL_0122:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1032222607;
					continue;
					IL_010c:
					text = JSONNode.smethod_3(text, "\\b");
					num = 85502804;
					continue;
					IL_00f9:
					num = (int)(num2 * 244444083) ^ -427349803;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		string text2 = default(string);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag7 = default(bool);
		int num9 = default(int);
		char c3 = default(char);
		string text = default(string);
		bool flag15 = default(bool);
		bool flag17 = default(bool);
		bool flag5 = default(bool);
		bool flag16 = default(bool);
		char c = default(char);
		bool flag = default(bool);
		bool flag11 = default(bool);
		char c2 = default(char);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag10 = default(bool);
		bool flag14 = default(bool);
		bool flag13 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1355113984;
			while (true)
			{
				uint num2;
				string s;
				switch ((num2 = (uint)num ^ 0x33253135u) % 149u)
				{
				case 148u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 1869407446) ^ -2067324881;
					continue;
				case 147u:
					num = (int)((num2 * 951289095) ^ 0x8483726);
					continue;
				case 146u:
					text2 = "";
					num = 45621495;
					continue;
				case 145u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1359687218) ^ -1471580853;
					continue;
				case 144u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 2116180928;
					continue;
				case 29u:
				case 58u:
				case 59u:
				case 79u:
				case 143u:
					num9++;
					num = 257495917;
					continue;
				case 142u:
				{
					int num34;
					if (c3 != 'n')
					{
						num = 567445652;
						num34 = 567445652;
					}
					else
					{
						num = 1341417659;
						num34 = 1341417659;
					}
					continue;
				}
				case 141u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -167121012) ^ -1104752660;
					continue;
				case 140u:
					flag15 = num9 < JSONNode.smethod_4(aJSON);
					num = 637508884;
					continue;
				case 139u:
					num = (int)(num2 * 45078068) ^ -2017299118;
					continue;
				case 138u:
				{
					int num59;
					int num60;
					if (!flag17)
					{
						num59 = 1530418639;
						num60 = 1530418639;
					}
					else
					{
						num59 = 1427889345;
						num60 = 1427889345;
					}
					num = num59 ^ (int)(num2 * 334838380);
					continue;
				}
				case 137u:
					num = ((int)num2 * -572358017) ^ 0x371046CE;
					continue;
				case 136u:
				{
					int num44;
					int num45;
					if (flag5)
					{
						num44 = 769519388;
						num45 = 769519388;
					}
					else
					{
						num44 = 77611597;
						num45 = 77611597;
					}
					num = num44 ^ (int)(num2 * 730191584);
					continue;
				}
				case 135u:
					flag16 = jSONNode is JSONArray;
					num = (int)((num2 * 1486533664) ^ 0x45B282A9);
					continue;
				case 134u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -989673693) ^ -335907932;
					continue;
				case 133u:
					num = ((int)num2 * -677963386) ^ 0x2EDFCC4D;
					continue;
				case 132u:
					num = (int)((num2 * 949690528) ^ 0x448B9FA7);
					continue;
				case 131u:
				{
					int num22;
					int num23;
					if (c == ':')
					{
						num22 = 630221816;
						num23 = 630221816;
					}
					else
					{
						num22 = 1613999152;
						num23 = 1613999152;
					}
					num = num22 ^ (int)(num2 * 1735351250);
					continue;
				}
				case 130u:
					jSONNode.Add(text);
					num = ((int)num2 * -300497810) ^ -445272391;
					continue;
				case 129u:
					num = ((int)num2 * -1708998377) ^ -1102720817;
					continue;
				case 128u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -204662818) ^ 0x36150597;
					continue;
				case 127u:
				{
					int num11;
					int num12;
					if (c3 != 'b')
					{
						num11 = -1390293350;
						num12 = -1390293350;
					}
					else
					{
						num11 = -1442080768;
						num12 = -1442080768;
					}
					num = num11 ^ (int)(num2 * 672451806);
					continue;
				}
				case 126u:
				{
					int num55;
					int num56;
					if (!flag)
					{
						num55 = -1477189925;
						num56 = -1477189925;
					}
					else
					{
						num55 = -2030191273;
						num56 = -2030191273;
					}
					num = num55 ^ (int)(num2 * 1792672464);
					continue;
				}
				case 125u:
					num = ((int)num2 * -1416404480) ^ -284487558;
					continue;
				case 124u:
					stack.Push(new JSONArray());
					num = 634564822;
					continue;
				case 123u:
					flag17 = stack.Count > 0;
					num = ((int)num2 * -294707140) ^ -1021338014;
					continue;
				case 122u:
					num = ((int)num2 * -929965803) ^ 0x6CBB048D;
					continue;
				case 121u:
				{
					int num51;
					if (c == '{')
					{
						num = 1514421280;
						num51 = 1514421280;
					}
					else
					{
						num = 506031786;
						num51 = 506031786;
					}
					continue;
				}
				case 120u:
					num = ((int)num2 * -990998969) ^ -1133831693;
					continue;
				case 119u:
				{
					int num46;
					int num47;
					if (!flag11)
					{
						num46 = 1882528638;
						num47 = 1882528638;
					}
					else
					{
						num46 = 781944297;
						num47 = 781944297;
					}
					num = num46 ^ (int)(num2 * 38830430);
					continue;
				}
				case 118u:
				{
					int num41;
					if (!flag5)
					{
						num = 389584294;
						num41 = 389584294;
					}
					else
					{
						num = 1544392894;
						num41 = 1544392894;
					}
					continue;
				}
				case 117u:
					num = ((int)num2 * -364680766) ^ -1883627003;
					continue;
				case 116u:
					num = ((int)num2 * -164280676) ^ 0x70678861;
					continue;
				case 115u:
					jSONNode = null;
					num9 = 0;
					num = ((int)num2 * -115580723) ^ 0x4871111E;
					continue;
				case 114u:
				{
					int num35;
					if (c == '"')
					{
						num = 2057713705;
						num35 = 2057713705;
					}
					else
					{
						num = 2056811640;
						num35 = 2056811640;
					}
					continue;
				}
				case 113u:
				{
					int num31;
					if (stack.Count == 0)
					{
						num = 623569733;
						num31 = 623569733;
					}
					else
					{
						num = 849507849;
						num31 = 849507849;
					}
					continue;
				}
				case 112u:
					num = (int)((num2 * 873427379) ^ 0x2B012C6A);
					continue;
				case 111u:
					goto IL_03ff;
				case 110u:
					goto IL_040d;
				case 109u:
					text = JSONNode.smethod_3(text, "\t");
					num = 950887594;
					continue;
				case 108u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1953282088) ^ -1707508463;
					continue;
				case 106u:
					text = "";
					num = ((int)num2 * -849518336) ^ 0x5C185F1;
					continue;
				case 105u:
				{
					c2 = JSONNode.smethod_2(aJSON, num9);
					char c4 = c2;
					c3 = c4;
					int num24;
					int num25;
					if ((uint)c3 > 102u)
					{
						num24 = 2084268126;
						num25 = 2084268126;
					}
					else
					{
						num24 = 1960798350;
						num25 = 1960798350;
					}
					num = num24 ^ ((int)num2 * -558358323);
					continue;
				}
				case 104u:
					num = (int)(num2 * 1676973445) ^ -16809285;
					continue;
				case 103u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\t':
						goto IL_03ff;
					case '\v':
					case '\f':
						goto IL_040d;
					default:
						goto IL_04f4;
					}
					goto case 29u;
				case 102u:
				{
					int num16;
					int num17;
					if (!flag12)
					{
						num16 = 1264954090;
						num17 = 1264954090;
					}
					else
					{
						num16 = 318670775;
						num17 = 318670775;
					}
					num = num16 ^ ((int)num2 * -1038795691);
					continue;
				}
				case 101u:
					num = ((int)num2 * -1008784644) ^ 0x36D41B31;
					continue;
				case 100u:
					flag11 = flag5;
					num = ((int)num2 * -964664615) ^ 0x72D44700;
					continue;
				case 99u:
				{
					int num8;
					if (c3 != 'f')
					{
						num = 102527281;
						num8 = 102527281;
					}
					else
					{
						num = 1580044519;
						num8 = 1580044519;
					}
					continue;
				}
				case 97u:
					flag6 = flag5;
					num = 98161699;
					continue;
				case 96u:
					num = (int)((num2 * 441433712) ^ 0x589B5141);
					continue;
				case 95u:
					goto IL_059d;
				case 94u:
					flag2 = JSONNode.smethod_6(text, "");
					num = 283772501;
					continue;
				case 93u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1146536291) ^ 0x629260C;
					continue;
				case 92u:
					num = ((int)num2 * -249401794) ^ 0x4175ACF8;
					continue;
				case 91u:
					num = (int)((num2 * 726301540) ^ 0x35AAB547);
					continue;
				case 90u:
					num = (int)(num2 * 276699726) ^ -348429895;
					continue;
				case 89u:
					num = ((int)num2 * -1346722115) ^ -922485998;
					continue;
				case 88u:
				{
					int num57;
					int num58;
					if (!flag16)
					{
						num57 = 1475516130;
						num58 = 1475516130;
					}
					else
					{
						num57 = 1365985343;
						num58 = 1365985343;
					}
					num = num57 ^ (int)(num2 * 837043221);
					continue;
				}
				case 87u:
					stack.Push(new JSONClass());
					num = 434101604;
					continue;
				case 86u:
				{
					int num53;
					int num54;
					if (!flag2)
					{
						num53 = -1121922708;
						num54 = -1121922708;
					}
					else
					{
						num53 = -1265919774;
						num54 = -1265919774;
					}
					num = num53 ^ (int)(num2 * 1836308566);
					continue;
				}
				case 85u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num9);
					c = c5;
					int num52;
					if ((uint)c <= 44u)
					{
						num = 176633019;
						num52 = 176633019;
					}
					else
					{
						num = 1067119846;
						num52 = 1067119846;
					}
					continue;
				}
				case 84u:
					goto IL_06cd;
				case 83u:
					num = ((int)num2 * -1103913334) ^ 0x15CEF832;
					continue;
				case 82u:
				{
					int num49;
					int num50;
					if (flag7)
					{
						num49 = -1590553739;
						num50 = -1590553739;
					}
					else
					{
						num49 = -1602313353;
						num50 = -1602313353;
					}
					num = num49 ^ (int)(num2 * 736579164);
					continue;
				}
				case 81u:
				{
					int num48;
					if (c != '}')
					{
						num = 741587412;
						num48 = 741587412;
					}
					else
					{
						num = 1689875288;
						num48 = 1689875288;
					}
					continue;
				}
				case 80u:
				{
					int num42;
					int num43;
					if (flag3)
					{
						num42 = -1319074081;
						num43 = -1319074081;
					}
					else
					{
						num42 = -294011366;
						num43 = -294011366;
					}
					num = num42 ^ ((int)num2 * -188489014);
					continue;
				}
				case 78u:
					num = ((int)num2 * -403182177) ^ -952731645;
					continue;
				case 77u:
					goto IL_0775;
				case 76u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 164608703) ^ 0x3D8FC997);
					continue;
				case 75u:
					text = "";
					text2 = "";
					flag5 = false;
					num = (int)(num2 * 189256917) ^ -1951468566;
					continue;
				case 74u:
					stack = new Stack<JSONNode>();
					num = (int)(num2 * 959899479) ^ -237038602;
					continue;
				case 73u:
					flag4 = jSONNode is JSONArray;
					num = ((int)num2 * -539865701) ^ 0x13CCCA6;
					continue;
				case 72u:
				{
					int num39;
					int num40;
					if (!flag10)
					{
						num39 = 2050552679;
						num40 = 2050552679;
					}
					else
					{
						num39 = 1923568264;
						num40 = 1923568264;
					}
					num = num39 ^ ((int)num2 * -146013731);
					continue;
				}
				case 71u:
					num = (int)((num2 * 61367979) ^ 0x39B79F63);
					continue;
				case 70u:
					num = ((int)num2 * -536063551) ^ 0x7CB11DB8;
					continue;
				case 69u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1574532795) ^ 0x19A5FBC3;
					continue;
				case 68u:
				{
					int num37;
					int num38;
					if (!flag15)
					{
						num37 = 1796517845;
						num38 = 1796517845;
					}
					else
					{
						num37 = 1531387522;
						num38 = 1531387522;
					}
					num = num37 ^ (int)(num2 * 1782421098);
					continue;
				}
				case 67u:
					num = ((int)num2 * -55926272) ^ -158470335;
					continue;
				case 65u:
					num = 723417249;
					continue;
				case 64u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1716692709) ^ 0x69243E3E);
					continue;
				case 63u:
					num = 256069508;
					continue;
				case 62u:
					text = JSONNode.smethod_3(text, "\b");
					num = 748200570;
					continue;
				case 61u:
					stack.Pop();
					flag14 = JSONNode.smethod_6(text, "");
					num = 65095702;
					continue;
				case 60u:
					flag5 = !flag5;
					num = 239093755;
					continue;
				case 57u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1711771658) ^ 0x64039409;
					continue;
				case 56u:
					num = (int)((num2 * 1941546223) ^ 0x217C0D4);
					continue;
				case 55u:
					num = 898118466;
					continue;
				case 54u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -398757469) ^ -1021600216;
					continue;
				case 53u:
					num = (int)(num2 * 1973036453) ^ -467609424;
					continue;
				case 52u:
					num = ((int)num2 * -1968242244) ^ -822981213;
					continue;
				case 51u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1920797176) ^ 0x2BD82ABE;
					continue;
				case 50u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1716451605) ^ 0x5323DB62;
					continue;
				case 49u:
				{
					int num36;
					if (flag5)
					{
						num = 604702394;
						num36 = 604702394;
					}
					else
					{
						num = 1282409321;
						num36 = 1282409321;
					}
					continue;
				}
				case 48u:
				{
					int num32;
					int num33;
					if (flag6)
					{
						num32 = -528897573;
						num33 = -528897573;
					}
					else
					{
						num32 = -1771863388;
						num33 = -1771863388;
					}
					num = num32 ^ ((int)num2 * -1929327937);
					continue;
				}
				case 47u:
					switch (c)
					{
					case '[':
						break;
					case ']':
						goto IL_06cd;
					default:
						goto IL_0a83;
					case '\\':
						goto IL_0a8d;
					}
					goto case 97u;
				case 30u:
					goto IL_0a8d;
				case 46u:
					num = (int)(num2 * 385397853) ^ -549816384;
					continue;
				case 45u:
				{
					int num30;
					if ((uint)c > 93u)
					{
						num = 395329219;
						num30 = 395329219;
					}
					else
					{
						num = 220944409;
						num30 = 220944409;
					}
					continue;
				}
				case 44u:
					num = 592792364;
					continue;
				case 43u:
					switch (c3)
					{
					case 't':
						break;
					case 's':
						goto IL_059d;
					case 'u':
						goto IL_0775;
					default:
						goto IL_0af4;
					case 'r':
						goto IL_0afe;
					}
					goto case 109u;
				case 4u:
					goto IL_0afe;
				case 42u:
				{
					int num28;
					int num29;
					if (flag14)
					{
						num28 = 727684419;
						num29 = 727684419;
					}
					else
					{
						num28 = 1325801630;
						num29 = 1325801630;
					}
					num = num28 ^ ((int)num2 * -144560395);
					continue;
				}
				case 41u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = 1425344497;
					continue;
				case 40u:
				{
					int num26;
					int num27;
					if (!flag13)
					{
						num26 = -7263183;
						num27 = -7263183;
					}
					else
					{
						num26 = -94341689;
						num27 = -94341689;
					}
					num = num26 ^ ((int)num2 * -515065720);
					continue;
				}
				case 39u:
				{
					int num20;
					int num21;
					if (!flag8)
					{
						num20 = -498065703;
						num21 = -498065703;
					}
					else
					{
						num20 = -1400044517;
						num21 = -1400044517;
					}
					num = num20 ^ (int)(num2 * 1934174792);
					continue;
				}
				case 38u:
					num = (int)(num2 * 1627588926) ^ -399427283;
					continue;
				case 37u:
				{
					int num19;
					if (c == ',')
					{
						num = 1155038652;
						num19 = 1155038652;
					}
					else
					{
						num = 1685980416;
						num19 = 1685980416;
					}
					continue;
				}
				case 36u:
				{
					int num18;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 705725529;
						num18 = 705725529;
					}
					else
					{
						num = 2055316932;
						num18 = 2055316932;
					}
					continue;
				}
				case 35u:
					jSONNode.Add(text);
					num = ((int)num2 * -550877315) ^ 0x429602B6;
					continue;
				case 34u:
				{
					int num14;
					int num15;
					if (!flag9)
					{
						num14 = -1880781033;
						num15 = -1880781033;
					}
					else
					{
						num14 = -122541738;
						num15 = -122541738;
					}
					num = num14 ^ ((int)num2 * -843684067);
					continue;
				}
				case 33u:
					num = ((int)num2 * -9897851) ^ 0x7A2A6026;
					continue;
				case 32u:
				{
					int num13;
					if (c != ' ')
					{
						num = 1633144467;
						num13 = 1633144467;
					}
					else
					{
						num = 1349324543;
						num13 = 1349324543;
					}
					continue;
				}
				case 31u:
					flag10 = jSONNode != null;
					num = ((int)num2 * -549777631) ^ 0x53A497C9;
					continue;
				case 28u:
					flag9 = flag5;
					num = 28011285;
					continue;
				case 27u:
					flag8 = jSONNode != null;
					num = ((int)num2 * -1458319074) ^ 0x750277BE;
					continue;
				case 26u:
					num = (int)(num2 * 808474498) ^ -1617591178;
					continue;
				case 25u:
				{
					int num10;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 731212348;
						num10 = 731212348;
					}
					else
					{
						num = 1554777923;
						num10 = 1554777923;
					}
					continue;
				}
				case 24u:
					num = (int)(num2 * 587317938) ^ -978989012;
					continue;
				case 23u:
					num9 += 4;
					num = ((int)num2 * -888630630) ^ 0x69870D92;
					continue;
				case 22u:
					text2 = "";
					num = 423219836;
					continue;
				case 21u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1685369496) ^ -1045792943;
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, "\f");
					num = 402905546;
					continue;
				case 19u:
					text = "";
					num = (int)((num2 * 954857785) ^ 0x5985E753);
					continue;
				case 18u:
					num = ((int)num2 * -927777853) ^ -1131953549;
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (!flag4)
					{
						num6 = -570755460;
						num7 = -570755460;
					}
					else
					{
						num6 = -1962430376;
						num7 = -1962430376;
					}
					num = num6 ^ ((int)num2 * -1696228847);
					continue;
				}
				case 16u:
					text2 = "";
					text = "";
					num = 1850256616;
					continue;
				case 15u:
					num = ((int)num2 * -2129024790) ^ 0x6145A51E;
					continue;
				case 14u:
					num = ((int)num2 * -2012752083) ^ 0x36E6BFA9;
					continue;
				case 12u:
					text2 = JSONNode.smethod_5(text2);
					flag3 = jSONNode is JSONArray;
					num = (int)(num2 * 72324677) ^ -212748690;
					continue;
				case 11u:
					text = JSONNode.smethod_3(text, "\n");
					num = 406717496;
					continue;
				case 10u:
				{
					int num5;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 821320291;
						num5 = 821320291;
					}
					else
					{
						num = 1568860166;
						num5 = 1568860166;
					}
					continue;
				}
				case 9u:
				{
					int num3;
					int num4;
					if ((uint)c > 32u)
					{
						num3 = 1093519585;
						num4 = 1093519585;
					}
					else
					{
						num3 = 373269790;
						num4 = 373269790;
					}
					num = num3 ^ ((int)num2 * -1343507523);
					continue;
				}
				case 8u:
					flag = jSONNode is JSONArray;
					num = (int)(num2 * 1929394080) ^ -3738682;
					continue;
				case 7u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 155872288) ^ -80762931;
					continue;
				case 6u:
					num = (int)(num2 * 1019261575) ^ -2064207537;
					continue;
				case 5u:
					num = (int)(num2 * 1113834711) ^ -1753198711;
					continue;
				case 3u:
					num = 1362368737;
					continue;
				case 2u:
					num = ((int)num2 * -118944303) ^ -2136853851;
					continue;
				case 1u:
					result = jSONNode;
					num = 139352545;
					continue;
				case 0u:
					text2 = text;
					text = "";
					num = 1425344497;
					continue;
				case 66u:
					break;
				case 13u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 107u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_059d:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1950589734;
					continue;
					IL_04f4:
					num = (int)((num2 * 1992809333) ^ 0x32C7AEFC);
					continue;
					IL_040d:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = 634275301;
					continue;
					IL_03ff:
					flag13 = flag5;
					num = 1308702503;
					continue;
					IL_0afe:
					text = JSONNode.smethod_3(text, "\r");
					num = 748200570;
					continue;
					IL_0af4:
					num = 1020608859;
					continue;
					IL_0a8d:
					num9++;
					num = 1863160826;
					continue;
					IL_0a83:
					num = 1572438917;
					continue;
					IL_0775:
					s = JSONNode.smethod_8(aJSON, num9 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = 1934094742;
					continue;
					IL_06cd:
					flag12 = flag5;
					num = 649219675;
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
			int num = 408614271;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21F25E47u) % 5u)
				{
				case 3u:
					num = ((int)num2 * -2038912593) ^ 0x3F3F85DE;
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -101191137) ^ 0x49C03A62;
					continue;
				case 1u:
					Serialize(aWriter);
					num = (int)(num2 * 2129817105) ^ -1875062669;
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
		while (true)
		{
			int num = -935966639;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBF073940u) % 3u)
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
							int num3 = -1433152286;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xBF073940u) % 3u)
								{
								case 1u:
									goto IL_005a;
								default:
									return;
								case 0u:
									break;
								case 2u:
									return;
								}
								break;
								IL_005a:
								num3 = ((int)num2 * -1410735553) ^ -7975150;
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
								int num4 = -942143834;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xBF073940u) % 4u)
									{
									case 2u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num4 = (int)((num2 * 539579207) ^ 0x324924BB);
										continue;
									case 1u:
										num4 = ((int)num2 * -1256941240) ^ 0x653FAB5B;
										continue;
									default:
										goto end_IL_00b4;
									case 0u:
										break;
									case 3u:
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
				num = ((int)num2 * -806982949) ^ 0x3A6D58C1;
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
				int num = -328866343;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB07C456Au) % 4u)
					{
					case 3u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -1611642504) ^ -82941593;
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -2018088648) ^ 0x10EF56A8;
						continue;
					case 0u:
						break;
					default:
						return result;
					case 2u:
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
					IL_00a6:
					int num3 = -1677832249;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xB07C456Au) % 3u)
						{
						case 2u:
							goto IL_0076;
						default:
							goto end_IL_0089;
						case 0u:
							break;
						case 1u:
							goto end_IL_0089;
						}
						goto IL_00a6;
						IL_0076:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -690895502) ^ 0xC01D1DD;
						continue;
						end_IL_0089:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num6 = default(int);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		JSONClass jSONClass = default(JSONClass);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 1118158705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F5975BAu) % 43u)
				{
				case 42u:
					num = ((int)num2 * -434861912) ^ -1552872299;
					continue;
				case 40u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = (int)((num2 * 334002916) ^ 0x6F369938);
					continue;
				case 39u:
					num6++;
					num = ((int)num2 * -935980520) ^ 0x3484ED67;
					continue;
				case 38u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)(num2 * 349736702) ^ -1819779794;
					continue;
				case 37u:
					num = 1924556539;
					continue;
				case 36u:
					num = 1587895880;
					continue;
				case 35u:
					num = ((int)num2 * -1347909331) ^ -2107419568;
					continue;
				case 34u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = (int)((num2 * 158918858) ^ 0x62CBE198);
					continue;
				case 33u:
					goto IL_00a3;
				case 32u:
					jSONArray.Add(Deserialize(aReader));
					num = 772693341;
					continue;
				case 31u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -864546588) ^ -746591484;
					continue;
				}
				case 30u:
					num = 1065940568;
					continue;
				case 29u:
					num = (int)(num2 * 1154497709) ^ -1129780741;
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -320433044) ^ -283859367;
					continue;
				case 27u:
					num = (int)(num2 * 257564791) ^ -1182388460;
					continue;
				case 26u:
					num4 = 0;
					num = (int)((num2 * 1523965024) ^ 0x47CC0B2E);
					continue;
				case 25u:
				{
					int num8;
					if (num6 >= num3)
					{
						num = 1806175291;
						num8 = 1806175291;
					}
					else
					{
						num = 1354019406;
						num8 = 1354019406;
					}
					continue;
				}
				case 24u:
				{
					int num7;
					if (num4 >= num5)
					{
						num = 50387599;
						num7 = 50387599;
					}
					else
					{
						num = 1516563249;
						num7 = 1516563249;
					}
					continue;
				}
				case 23u:
					num6 = 0;
					num = ((int)num2 * -1889531336) ^ 0x19565347;
					continue;
				case 22u:
					num = ((int)num2 * -1570416483) ^ 0x4584F9BE;
					continue;
				case 21u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -667182634) ^ 0x7111D9D;
					continue;
				case 20u:
					num5 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = ((int)num2 * -69822624) ^ 0x51F8A7CC;
					continue;
				case 19u:
					num = (int)((num2 * 397176722) ^ 0x5465E6D9);
					continue;
				case 18u:
					num = (int)((num2 * 1900100125) ^ 0x4B8F7DB7);
					continue;
				case 17u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)((num2 * 995655137) ^ 0x1067E6D0);
					continue;
				case 16u:
					num4++;
					num = ((int)num2 * -1138713492) ^ -190177897;
					continue;
				case 15u:
					goto IL_0263;
				case 14u:
					num = (int)(num2 * 1895885355) ^ -1307329909;
					continue;
				case 13u:
					goto IL_0280;
				case 12u:
					result = jSONClass;
					num = (int)((num2 * 1788117838) ^ 0x2FDEB2BD);
					continue;
				case 10u:
					num = ((int)num2 * -1307295338) ^ 0x1D9129EC;
					continue;
				case 9u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.IntValue:
						goto IL_00a3;
					case JSONBinaryTag.Value:
						goto IL_0263;
					case JSONBinaryTag.FloatValue:
						goto IL_0280;
					default:
						goto IL_02d8;
					case JSONBinaryTag.Array:
						goto IL_02eb;
					case JSONBinaryTag.DoubleValue:
						goto IL_0300;
					case JSONBinaryTag.BoolValue:
						goto IL_0314;
					}
					goto case 37u;
				case 1u:
					goto IL_02eb;
				case 0u:
					goto IL_0300;
				case 7u:
					goto IL_0314;
				case 6u:
					num = (int)(num2 * 1057065156) ^ -433330903;
					continue;
				case 5u:
					num = ((int)num2 * -982172113) ^ -107358521;
					continue;
				case 4u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1993272969) ^ -1244249724;
					continue;
				case 3u:
					num = (int)((num2 * 2074577433) ^ 0x611237FA);
					continue;
				case 2u:
					result = jSONArray;
					num = (int)(num2 * 211386444) ^ -176892804;
					continue;
				case 11u:
					break;
				case 41u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0314:
					num = 1281545765;
					continue;
					IL_0300:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 1134144788;
					continue;
					IL_02eb:
					num3 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = 257195890;
					continue;
					IL_02d8:
					num = (int)((num2 * 802099880) ^ 0x61F84437);
					continue;
					IL_0280:
					num = 819563482;
					continue;
					IL_0263:
					num = 1994775967;
					continue;
					IL_00a3:
					num = 1268146118;
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
					int num = -458459024;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xCA05FA01u) % 3u)
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
						num = ((int)num2 * -73184744) ^ -264029000;
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
			return LoadFromStream(fileStream);
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0045:
					int num = 1177837123;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x434929F8u) % 3u)
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
						num = ((int)num2 * -535314092) ^ -1974927525;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = 1524559890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6AEE455Eu) % 6u)
				{
				case 4u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1491223193) ^ 0x50B2C8D3);
					continue;
				case 3u:
					num = (int)(num2 * 1840813255) ^ -272544952;
					continue;
				case 2u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 1882409917) ^ 0x743B0DCF);
					continue;
				case 1u:
					num = ((int)num2 * -1367612117) ^ 0x5A8D6B81;
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

	public JSONNode()
	{
		while (true)
		{
			int num = -222250483;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B0F100Du) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 972305005) ^ 0x70FC110D);
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
