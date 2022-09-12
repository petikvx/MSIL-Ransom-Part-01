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
				int num = 632661156;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5C0A6777u) % 3u)
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
					num = (int)(num2 * 1415390669) ^ -1310111369;
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
				int num = -140770556;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xABBEF3A6u) % 4u)
					{
					case 2u:
						result = null;
						num = (int)((num2 * 218562398) ^ 0x17BD1467);
						continue;
					case 1u:
						num = (int)(num2 * 317359103) ^ -513169107;
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
				int num = -2060923533;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9ACA2A86u) % 3u)
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
					num = ((int)num2 * -192435577) ^ -972259278;
				}
			}
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			return _003Cget_Childs_003Ed__;
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
			bool flag = int.TryParse(Value, out result);
			int result2 = default(int);
			while (true)
			{
				int num = -2136655300;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC77AE36Du) % 7u)
					{
					case 6u:
						num = (int)(num2 * 1059432669) ^ -1839788776;
						continue;
					case 5u:
						result2 = 0;
						num = -274454595;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 727339628;
							num4 = 727339628;
						}
						else
						{
							num3 = 1204423512;
							num4 = 1204423512;
						}
						num = num3 ^ ((int)num2 * -1849646776);
						continue;
					}
					case 1u:
						num = ((int)num2 * -1294906775) ^ 0x767CF1B;
						continue;
					case 0u:
						result2 = result;
						num = (int)((num2 * 1508471856) ^ 0x5BBD1886);
						continue;
					case 4u:
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
				int num = -544612695;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC7158F15u) % 3u)
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
					num = ((int)num2 * -1755908326) ^ 0x3D60416;
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
				int num = -1157428984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFB7D9CCAu) % 6u)
					{
					case 5u:
						result = result2;
						num = (int)(num2 * 232825186) ^ -1039596817;
						continue;
					case 3u:
						num = (int)(num2 * 369634536) ^ -1290195735;
						continue;
					case 2u:
					{
						result2 = 0f;
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = 1211058233;
							num4 = 1211058233;
						}
						else
						{
							num3 = 786412480;
							num4 = 786412480;
						}
						num = num3 ^ ((int)num2 * -2030294650);
						continue;
					}
					case 0u:
						result = 0f;
						num = -1468740091;
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

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			double result = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = 264923143;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D97FB5Cu) % 9u)
					{
					case 8u:
						result2 = 0.0;
						num = ((int)num2 * -1696024595) ^ 0xD659BE1;
						continue;
					case 6u:
						num = ((int)num2 * -98567491) ^ 0x40CB439A;
						continue;
					case 5u:
						result = result2;
						num = (int)((num2 * 179563232) ^ 0x3E8D02CF);
						continue;
					case 4u:
						result = 0.0;
						num = 1993666079;
						continue;
					case 3u:
						num = ((int)num2 * -1652421189) ^ -1634574452;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1455316367;
							num4 = 1455316367;
						}
						else
						{
							num3 = 225626968;
							num4 = 225626968;
						}
						num = num3 ^ ((int)num2 * -443999855);
						continue;
					}
					case 0u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -327793164) ^ 0x372251F8;
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
				int num = -2074998885;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC859B95Au) % 3u)
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
					num = (int)((num2 * 2132790974) ^ 0x2C43A717);
				}
			}
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
				int num = -1019765158;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1E1E9DDu) % 6u)
					{
					case 5u:
						result2 = !JSONNode.smethod_1(Value);
						num = -411030849;
						continue;
					case 4u:
						result2 = result;
						num = ((int)num2 * -155587462) ^ 0x466718D2;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2020817306;
							num4 = -2020817306;
						}
						else
						{
							num3 = -2079904965;
							num4 = -2079904965;
						}
						num = num3 ^ ((int)num2 * -1088392875);
						continue;
					}
					case 1u:
						num = (int)(num2 * 1177885977) ^ -1196177864;
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
			Value = (value ? "true" : "false");
		}
	}

	public virtual JSONArray AsArray => this as JSONArray;

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 174279151;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x24AD7FA2u) % 4u)
					{
					case 1u:
						result = this as JSONClass;
						num = (int)((num2 * 578987912) ^ 0x65DB8D8E);
						continue;
					case 0u:
						num = (int)((num2 * 1609532890) ^ 0x7588077D);
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
		while (true)
		{
			int num = 975008724;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CF35D10u) % 3u)
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
				Add("", aItem);
				num = (int)(num2 * 1658780781) ^ -1291771612;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2005901041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB279C428u) % 3u)
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
				num = (int)((num2 * 1053831019) ^ 0x5DBF8088);
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1834541477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE141779u) % 4u)
				{
				case 2u:
					result = null;
					num = ((int)num2 * -587449649) ^ 0x78B4D706;
					continue;
				case 1u:
					num = (int)((num2 * 1303268873) ^ 0x68873BD4);
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
			int num = -1501992846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0BC3095u) % 4u)
				{
				case 3u:
					result = aNode;
					num = (int)(num2 * 532309791) ^ -1609006280;
					continue;
				case 0u:
					num = ((int)num2 * -1638627961) ^ 0x102019B8;
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

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -272777395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC74FF470u) % 3u)
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
				num = ((int)num2 * -545877459) ^ -1450448872;
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
			int num = 836538862;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x652C9184u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1074742968) ^ 0x4677ADC9;
					continue;
				case 2u:
					result = new JSONData(s);
					num = (int)(num2 * 112064713) ^ -150798719;
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
			int num = -1528237084;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x930E8B92u) % 5u)
				{
				case 3u:
					if (!(d == null))
					{
						num = (int)(num2 * 1735453049) ^ -1336700535;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					obj = d.Value;
					goto IL_001c;
				case 1u:
					num = ((int)num2 * -321328870) ^ 0x392A02D6;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = -1495949657;
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
			goto IL_0059;
		}
		int num = 0;
		goto IL_00a7;
		IL_009e:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_00a7;
		IL_0059:
		int num2 = -778332386;
		goto IL_006d;
		IL_006d:
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xAF64027Au) % 8u)
			{
			case 7u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 79586349;
					num5 = 79586349;
				}
				else
				{
					num4 = 361418467;
					num5 = 361418467;
				}
				num2 = num4 ^ (int)(num3 * 43794372);
				continue;
			}
			case 6u:
				num2 = (int)(num3 * 245575719) ^ -1208846888;
				continue;
			case 5u:
				result = true;
				num2 = ((int)num3 * -1713590254) ^ 0x7C77F9C1;
				continue;
			case 3u:
				result = (object)a == b;
				num2 = -1071221092;
				continue;
			case 2u:
				break;
			case 1u:
				num2 = (int)(num3 * 1160951454) ^ -1988807924;
				continue;
			case 4u:
				goto IL_009e;
			default:
				return result;
			}
			break;
		}
		goto IL_0059;
		IL_00a7:
		flag = (byte)num != 0;
		num2 = -2058929219;
		goto IL_006d;
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
			int num = -1210253145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB3BD3E1u) % 3u)
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
				num = (int)(num2 * 1796500357) ^ -151941500;
			}
		}
	}

	public override int GetHashCode()
	{
		return this.method_0();
	}

	internal static string Escape(string aText)
	{
		char c2 = default(char);
		int num3 = default(int);
		string text = default(string);
		char c = default(char);
		string string_ = default(string);
		string result = default(string);
		while (true)
		{
			int num = 1122250528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x114BF58Cu) % 30u)
				{
				case 29u:
					num = (int)(num2 * 1109104674) ^ -1476798597;
					continue;
				case 28u:
					switch (c2)
					{
					case '\b':
						goto IL_004d;
					case '\t':
						goto IL_0063;
					case '\n':
						goto IL_0079;
					case '\v':
						goto IL_008f;
					case '\f':
						goto IL_00a7;
					case '\r':
						goto IL_00bd;
					}
					num = ((int)num2 * -899037965) ^ -568552421;
					continue;
				case 5u:
					goto IL_004d;
				case 7u:
					goto IL_0063;
				case 21u:
					goto IL_0079;
				case 22u:
					goto IL_008f;
				case 20u:
					goto IL_00a7;
				case 15u:
					goto IL_00bd;
				case 27u:
				{
					int num6;
					if (c2 != '\\')
					{
						num = 670001110;
						num6 = 670001110;
					}
					else
					{
						num = 120976639;
						num6 = 120976639;
					}
					continue;
				}
				case 26u:
					num = (int)((num2 * 1361421973) ^ 0x503B23AE);
					continue;
				case 25u:
					num = ((int)num2 * -1091488765) ^ -1364548421;
					continue;
				case 24u:
					num3++;
					num = (int)((num2 * 645726690) ^ 0x405F0B0C);
					continue;
				case 23u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1919075288;
					continue;
				case 18u:
					text = "";
					num = ((int)num2 * -2045158053) ^ 0x39AA9FAF;
					continue;
				case 17u:
					num = ((int)num2 * -349241244) ^ 0x6A0EA19A;
					continue;
				case 16u:
					num = (int)(num2 * 1571660157) ^ -1268616080;
					continue;
				case 14u:
				{
					char c3 = c;
					c2 = c3;
					num = ((int)num2 * -1316319033) ^ 0x4940F15A;
					continue;
				}
				case 13u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -503644960) ^ -252496239;
					continue;
				case 12u:
					result = text;
					num = ((int)num2 * -1538573561) ^ 0x12EFCB15;
					continue;
				case 10u:
					num = 2145703390;
					continue;
				case 9u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1892795174;
					continue;
				case 8u:
					num = ((int)num2 * -828688724) ^ -1093403818;
					continue;
				case 6u:
				{
					int num5;
					if (c2 == '"')
					{
						num = 1195132029;
						num5 = 1195132029;
					}
					else
					{
						num = 824371061;
						num5 = 824371061;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -1654177029) ^ 0x737311D8;
					continue;
				case 3u:
					num = ((int)num2 * -12696725) ^ -1206156777;
					continue;
				case 2u:
					c = JSONNode.smethod_2(string_, num3);
					num = 904272264;
					continue;
				case 1u:
					num = ((int)num2 * -1320022354) ^ 0x514DABA0;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 749006948;
						num4 = 749006948;
					}
					else
					{
						num = 1697680204;
						num4 = 1697680204;
					}
					continue;
				}
				case 19u:
					break;
				default:
					{
						return result;
					}
					IL_00a7:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1987803001;
					continue;
					IL_008f:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 1892795174;
					continue;
					IL_0079:
					text = JSONNode.smethod_3(text, "\\n");
					num = 182845698;
					continue;
					IL_0063:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1892795174;
					continue;
					IL_004d:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1632801252;
					continue;
					IL_00bd:
					text = JSONNode.smethod_3(text, "\\r");
					num = 686730635;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		bool flag9 = default(bool);
		bool flag = default(bool);
		char c = default(char);
		char c4 = default(char);
		bool flag12 = default(bool);
		string text2 = default(string);
		int num9 = default(int);
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		char c2 = default(char);
		bool flag6 = default(bool);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag8 = default(bool);
		bool flag13 = default(bool);
		bool flag14 = default(bool);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag5 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag11 = default(bool);
		bool flag3 = default(bool);
		string s = default(string);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -239377956;
			while (true)
			{
				uint num2;
				int num48;
				switch ((num2 = (uint)num ^ 0x8709C773u) % 156u)
				{
				case 155u:
					flag9 = flag;
					num = -789420221;
					continue;
				case 154u:
				{
					int num19;
					int num20;
					if (c != 'b')
					{
						num19 = 1534137878;
						num20 = 1534137878;
					}
					else
					{
						num19 = 1830228601;
						num20 = 1830228601;
					}
					num = num19 ^ (int)(num2 * 988195461);
					continue;
				}
				case 153u:
					switch (c4)
					{
					case '\t':
						goto IL_0070;
					case '\v':
					case '\f':
						goto IL_007e;
					case '\n':
					case '\r':
						goto IL_009f;
					}
					num = (int)(num2 * 20028278) ^ -956894399;
					continue;
				case 72u:
					goto IL_0070;
				case 84u:
					goto IL_007e;
				case 5u:
				case 59u:
				case 92u:
				case 119u:
				case 123u:
					goto IL_009f;
				case 152u:
					flag12 = JSONNode.smethod_6(text2, "");
					num = -1920780578;
					continue;
				case 151u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num9);
					c4 = c5;
					num = -1213073295;
					continue;
				}
				case 150u:
				{
					int num22;
					int num23;
					if (!(jSONNode != null))
					{
						num22 = -823347403;
						num23 = -823347403;
					}
					else
					{
						num22 = -272571;
						num23 = -272571;
					}
					num = num22 ^ ((int)num2 * -231298371);
					continue;
				}
				case 149u:
					num = ((int)num2 * -1497742182) ^ -1719701166;
					continue;
				case 148u:
					jSONNode.Add(text);
					num = (int)(num2 * 812819911) ^ -1416168155;
					continue;
				case 147u:
				{
					int num53;
					if (c4 == '}')
					{
						num = -1510461837;
						num53 = -1510461837;
					}
					else
					{
						num = -1859581213;
						num53 = -1859581213;
					}
					continue;
				}
				case 146u:
					text = JSONNode.smethod_3(text, "\r");
					num = -192355430;
					continue;
				case 145u:
					c2 = JSONNode.smethod_2(aJSON, num9);
					num = ((int)num2 * -514999386) ^ 0x4827A337;
					continue;
				case 144u:
				{
					int num40;
					int num41;
					if (!flag9)
					{
						num40 = -957053938;
						num41 = -957053938;
					}
					else
					{
						num40 = -1894916258;
						num41 = -1894916258;
					}
					num = num40 ^ (int)(num2 * 908225399);
					continue;
				}
				case 143u:
					num = ((int)num2 * -731190582) ^ 0x3F6A1B18;
					continue;
				case 142u:
					num = (int)(num2 * 512239669) ^ -1576367451;
					continue;
				case 141u:
					num = ((int)num2 * -2092318235) ^ 0x16B43E2D;
					continue;
				case 140u:
					num = (int)(num2 * 877435067) ^ -1678235605;
					continue;
				case 139u:
					num = (int)((num2 * 794030394) ^ 0x3A3BCD46);
					continue;
				case 138u:
					num = ((int)num2 * -1611438660) ^ -312347785;
					continue;
				case 137u:
				{
					int num17;
					int num18;
					if (flag6)
					{
						num17 = -1673487981;
						num18 = -1673487981;
					}
					else
					{
						num17 = -2045122002;
						num18 = -2045122002;
					}
					num = num17 ^ (int)(num2 * 10307439);
					continue;
				}
				case 136u:
				{
					int num6;
					if (c4 != ',')
					{
						num = -1858257918;
						num6 = -1858257918;
					}
					else
					{
						num = -1491738808;
						num6 = -1491738808;
					}
					continue;
				}
				case 135u:
					text = "";
					num = ((int)num2 * -381266691) ^ 0x46864205;
					continue;
				case 134u:
					text = "";
					jSONNode = stack.Peek();
					num = ((int)num2 * -1070077658) ^ -87257398;
					continue;
				case 133u:
					stack.Push(new JSONArray());
					num = -485021971;
					continue;
				case 131u:
				{
					int num60;
					if (flag)
					{
						num = -983886774;
						num60 = -983886774;
					}
					else
					{
						num = -661201479;
						num60 = -661201479;
					}
					continue;
				}
				case 130u:
					num = (int)((num2 * 1923623467) ^ 0x7136BCF5);
					continue;
				case 129u:
					flag8 = stack.Count > 0;
					num = (int)((num2 * 770723253) ^ 0x61E092E0);
					continue;
				case 128u:
					flag13 = flag;
					num = -1874082430;
					continue;
				case 127u:
					text = "";
					num = (int)(num2 * 155030160) ^ -1751576817;
					continue;
				case 126u:
					num = -554358465;
					continue;
				case 125u:
				{
					int num51;
					int num52;
					if (flag14)
					{
						num51 = -204689915;
						num52 = -204689915;
					}
					else
					{
						num51 = -957132513;
						num52 = -957132513;
					}
					num = num51 ^ ((int)num2 * -823548512);
					continue;
				}
				case 124u:
					goto IL_036f;
				case 122u:
				{
					int num46;
					if (c != 'n')
					{
						num = -724018236;
						num46 = -724018236;
					}
					else
					{
						num = -1330720853;
						num46 = -1330720853;
					}
					continue;
				}
				case 121u:
					text2 = "";
					text = "";
					num = -1362516722;
					continue;
				case 120u:
					num = ((int)num2 * -225555169) ^ -1373549665;
					continue;
				case 118u:
					stack.Pop();
					num = -1835704115;
					continue;
				case 117u:
				{
					int num36;
					int num37;
					if (!(jSONNode is JSONArray))
					{
						num36 = 1464004147;
						num37 = 1464004147;
					}
					else
					{
						num36 = 1537526039;
						num37 = 1537526039;
					}
					num = num36 ^ ((int)num2 * -385598125);
					continue;
				}
				case 116u:
					text = JSONNode.smethod_3(text, "\n");
					num = -366817705;
					continue;
				case 115u:
				{
					int num31;
					int num32;
					if (jSONNode != null)
					{
						num31 = 763812938;
						num32 = 763812938;
					}
					else
					{
						num31 = 1711499546;
						num32 = 1711499546;
					}
					num = num31 ^ ((int)num2 * -291648903);
					continue;
				}
				case 114u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1743988082) ^ -2124173790;
					continue;
				case 113u:
				{
					int num26;
					int num27;
					if (flag7)
					{
						num26 = -1994392210;
						num27 = -1994392210;
					}
					else
					{
						num26 = -1323257606;
						num27 = -1323257606;
					}
					num = num26 ^ (int)(num2 * 1346504129);
					continue;
				}
				case 112u:
					text2 = "";
					num = -2038432503;
					continue;
				case 111u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -138903442) ^ -2138247338;
					continue;
				case 110u:
					flag = !flag;
					num = -1956348816;
					continue;
				case 109u:
				{
					int num14;
					int num15;
					if (!flag4)
					{
						num14 = -1236353023;
						num15 = -1236353023;
					}
					else
					{
						num14 = -650128426;
						num15 = -650128426;
					}
					num = num14 ^ ((int)num2 * -1965396746);
					continue;
				}
				case 108u:
					flag5 = stack.Count == 0;
					num = -442471065;
					continue;
				case 107u:
					text2 = text;
					num = -1265027108;
					continue;
				case 106u:
					jSONNode = null;
					num = (int)((num2 * 2118043720) ^ 0x3B2C1B9C);
					continue;
				case 105u:
					num = ((int)num2 * -1144594738) ^ -1714158566;
					continue;
				case 104u:
					text2 = "";
					num = -742442439;
					continue;
				case 102u:
				{
					int num7;
					int num8;
					if (!JSONNode.smethod_6(text, ""))
					{
						num7 = 1588741624;
						num8 = 1588741624;
					}
					else
					{
						num7 = 1780189730;
						num8 = 1780189730;
					}
					num = num7 ^ ((int)num2 * -2099628205);
					continue;
				}
				case 101u:
					result = jSONNode;
					num = -398823262;
					continue;
				case 100u:
				{
					int num61;
					int num62;
					if (flag11)
					{
						num61 = -1131264437;
						num62 = -1131264437;
					}
					else
					{
						num61 = -39760042;
						num62 = -39760042;
					}
					num = num61 ^ (int)(num2 * 759421760);
					continue;
				}
				case 99u:
				{
					int num58;
					int num59;
					if ((uint)c <= 102u)
					{
						num58 = 849810588;
						num59 = 849810588;
					}
					else
					{
						num58 = 457552548;
						num59 = 457552548;
					}
					num = num58 ^ ((int)num2 * -1033748953);
					continue;
				}
				case 98u:
					flag14 = JSONNode.smethod_6(text, "");
					num = -5922282;
					continue;
				case 97u:
					stack.Push(new JSONClass());
					num = -760115381;
					continue;
				case 96u:
					num = (int)((num2 * 1820368428) ^ 0xB5662A5);
					continue;
				case 95u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = (int)(num2 * 2001719194) ^ -319698311;
					continue;
				case 94u:
					text2 = "";
					num = -1986413220;
					continue;
				case 93u:
					num = ((int)num2 * -725517711) ^ -218070462;
					continue;
				case 91u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1718625070) ^ -1685942175;
					continue;
				case 90u:
				{
					int num56;
					int num57;
					if ((uint)c4 <= 44u)
					{
						num56 = -835041968;
						num57 = -835041968;
					}
					else
					{
						num56 = -1268988690;
						num57 = -1268988690;
					}
					num = num56 ^ (int)(num2 * 516296912);
					continue;
				}
				case 89u:
				{
					int num54;
					int num55;
					if (flag3)
					{
						num54 = -1269558313;
						num55 = -1269558313;
					}
					else
					{
						num54 = -395923166;
						num55 = -395923166;
					}
					num = num54 ^ ((int)num2 * -501449012);
					continue;
				}
				case 88u:
				{
					int num49;
					int num50;
					if (!flag5)
					{
						num49 = -1859959543;
						num50 = -1859959543;
					}
					else
					{
						num49 = -479611478;
						num50 = -479611478;
					}
					num = num49 ^ (int)(num2 * 1241142767);
					continue;
				}
				case 87u:
				{
					int num47;
					if (num9 < JSONNode.smethod_4(aJSON))
					{
						num = -1396668948;
						num47 = -1396668948;
					}
					else
					{
						num = -822931353;
						num47 = -822931353;
					}
					continue;
				}
				case 86u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -785250347) ^ -272634286;
					continue;
				case 85u:
					num = ((int)num2 * -191670213) ^ -958729936;
					continue;
				case 83u:
				{
					int num44;
					int num45;
					if ((uint)c4 <= 32u)
					{
						num44 = -419505256;
						num45 = -419505256;
					}
					else
					{
						num44 = -622441917;
						num45 = -622441917;
					}
					num = num44 ^ (int)(num2 * 1772887866);
					continue;
				}
				case 82u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 1104950004) ^ 0x6E505F0C);
					continue;
				case 81u:
					goto IL_07e5;
				case 80u:
					num = ((int)num2 * -97268280) ^ -1953509823;
					continue;
				case 79u:
					num = ((int)num2 * -1064034159) ^ 0x211DE5FC;
					continue;
				case 78u:
					num = ((int)num2 * -1273478075) ^ 0x41AC042D;
					continue;
				case 77u:
				{
					int num42;
					int num43;
					if (!flag13)
					{
						num42 = 73721203;
						num43 = 73721203;
					}
					else
					{
						num42 = 1712581861;
						num43 = 1712581861;
					}
					num = num42 ^ (int)(num2 * 1685174899);
					continue;
				}
				case 76u:
					flag6 = JSONNode.smethod_6(text2, "");
					num = -627196814;
					continue;
				case 75u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = (int)((num2 * 722386296) ^ 0x5689433A);
					continue;
				case 74u:
					num = (int)((num2 * 1827966878) ^ 0x662EBDAC);
					continue;
				case 73u:
					num = ((int)num2 * -220686429) ^ 0x202F46A1;
					continue;
				case 71u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 258892478) ^ -1894904751;
					continue;
				case 70u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1253973262) ^ -216358115;
					continue;
				case 69u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1464638491) ^ -1262165768;
					continue;
				case 68u:
					goto IL_091d;
				case 67u:
					num9 += 4;
					num = ((int)num2 * -1781938117) ^ 0x3CD728EA;
					continue;
				case 66u:
					num = (int)(num2 * 493695225) ^ -1804842395;
					continue;
				case 64u:
					num = (int)(num2 * 1912271294) ^ -1465339240;
					continue;
				case 63u:
					num = ((int)num2 * -325341156) ^ -2054904384;
					continue;
				case 62u:
				{
					int num38;
					int num39;
					if (!flag10)
					{
						num38 = -1533426410;
						num39 = -1533426410;
					}
					else
					{
						num38 = -1182515639;
						num39 = -1182515639;
					}
					num = num38 ^ ((int)num2 * -122841420);
					continue;
				}
				case 61u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 220988594) ^ 0x421D2E5A);
					continue;
				case 60u:
					num = -1860187501;
					continue;
				case 58u:
				{
					int num35;
					if (c4 != ' ')
					{
						num = -2073514502;
						num35 = -2073514502;
					}
					else
					{
						num = -590137669;
						num35 = -590137669;
					}
					continue;
				}
				case 57u:
					num = ((int)num2 * -232487992) ^ -1625333505;
					continue;
				case 56u:
					num = -429042520;
					continue;
				case 55u:
					jSONNode.Add(text);
					num = (int)((num2 * 1735872703) ^ 0x70D18E1B);
					continue;
				case 54u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = (int)((num2 * 735226504) ^ 0xB44B543);
					continue;
				case 53u:
					num = ((int)num2 * -1080525321) ^ 0x4991FC63;
					continue;
				case 52u:
					num = (int)((num2 * 1342013834) ^ 0x616BE2A0);
					continue;
				case 51u:
					num9 = 0;
					num = ((int)num2 * -801370688) ^ 0x543FD26B;
					continue;
				case 50u:
					text = "";
					num = (int)((num2 * 270370609) ^ 0x4DA6E587);
					continue;
				case 49u:
				{
					int num33;
					int num34;
					if (flag12)
					{
						num33 = -417128319;
						num34 = -417128319;
					}
					else
					{
						num33 = -26372468;
						num34 = -26372468;
					}
					num = num33 ^ (int)(num2 * 1713664599);
					continue;
				}
				case 48u:
					flag11 = flag;
					num = (int)(num2 * 1082875480) ^ -2060619389;
					continue;
				case 47u:
				{
					int num29;
					int num30;
					if (c4 != ':')
					{
						num29 = 1133344120;
						num30 = 1133344120;
					}
					else
					{
						num29 = 935966863;
						num30 = 935966863;
					}
					num = num29 ^ (int)(num2 * 67505084);
					continue;
				}
				case 46u:
				{
					int num28;
					if (c4 == '"')
					{
						num = -688018367;
						num28 = -688018367;
					}
					else
					{
						num = -425390379;
						num28 = -425390379;
					}
					continue;
				}
				case 45u:
					num = ((int)num2 * -1868169023) ^ -112189954;
					continue;
				case 44u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -16979996) ^ 0x464AB61D;
					continue;
				case 43u:
					switch (c4)
					{
					case '[':
						break;
					case ']':
						goto IL_036f;
					case '\\':
						goto IL_07e5;
					default:
						goto IL_0b95;
					}
					goto case 155u;
				case 42u:
				{
					int num24;
					int num25;
					if (!flag8)
					{
						num24 = 936044502;
						num25 = 936044502;
					}
					else
					{
						num24 = 1653604950;
						num25 = 1653604950;
					}
					num = num24 ^ ((int)num2 * -2132044375);
					continue;
				}
				case 41u:
					num = ((int)num2 * -1784173927) ^ -408510718;
					continue;
				case 40u:
					num = (int)(num2 * 1573903134) ^ -314240445;
					continue;
				case 39u:
					switch (c)
					{
					case 'r':
						break;
					case 's':
						goto IL_091d;
					default:
						goto IL_0c08;
					case 't':
						goto IL_0c12;
					case 'u':
						goto IL_0c28;
					}
					goto case 146u;
				case 16u:
					goto IL_0c12;
				case 18u:
					goto IL_0c28;
				case 38u:
					num = (int)(num2 * 367924272) ^ -518809633;
					continue;
				case 37u:
					num = ((int)num2 * -181679058) ^ 0x67489D19;
					continue;
				case 36u:
				{
					int num21;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -522437539;
						num21 = -522437539;
					}
					else
					{
						num = -1347506591;
						num21 = -1347506591;
					}
					continue;
				}
				case 35u:
					num = ((int)num2 * -787635844) ^ -968360970;
					continue;
				case 34u:
					num = -1559072414;
					continue;
				case 33u:
					text2 = JSONNode.smethod_5(text2);
					flag7 = jSONNode is JSONArray;
					num = ((int)num2 * -73427855) ^ 0x68FDA793;
					continue;
				case 32u:
					text = "";
					num = (int)(num2 * 1699046922) ^ -1188538590;
					continue;
				case 31u:
				{
					int num16;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -586573487;
						num16 = -586573487;
					}
					else
					{
						num = -432361960;
						num16 = -432361960;
					}
					continue;
				}
				case 30u:
					text = JSONNode.smethod_3(text, "\f");
					num = -366817705;
					continue;
				case 29u:
				{
					int num13;
					if ((uint)c4 > 93u)
					{
						num = -1639328080;
						num13 = -1639328080;
					}
					else
					{
						num = -881068588;
						num13 = -881068588;
					}
					continue;
				}
				case 28u:
					num = ((int)num2 * -2129030411) ^ -1639494564;
					continue;
				case 27u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1613945054) ^ 0x5669595F;
					continue;
				case 26u:
					flag4 = jSONNode is JSONArray;
					num = ((int)num2 * -662852659) ^ 0x7B8C470;
					continue;
				case 25u:
					num = ((int)num2 * -975986198) ^ -805992589;
					continue;
				case 24u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num11;
					int num12;
					if (!(jSONNode is JSONArray))
					{
						num11 = 1472590863;
						num12 = 1472590863;
					}
					else
					{
						num11 = 1781103668;
						num12 = 1781103668;
					}
					num = num11 ^ (int)(num2 * 1203633344);
					continue;
				}
				case 23u:
					num = ((int)num2 * -920911725) ^ 0x4EB15DC6;
					continue;
				case 22u:
					num = (int)(num2 * 609692570) ^ -70287823;
					continue;
				case 21u:
					num = ((int)num2 * -838479033) ^ -1785270376;
					continue;
				case 20u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 1771023137) ^ -1351446286;
					continue;
				case 19u:
				{
					int num10;
					if (c4 == '{')
					{
						num = -707227034;
						num10 = -707227034;
					}
					else
					{
						num = -759672534;
						num10 = -759672534;
					}
					continue;
				}
				case 17u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = (int)(num2 * 24833650) ^ -1227802107;
					continue;
				case 15u:
					num = -2093384859;
					continue;
				case 14u:
					num = ((int)num2 * -492833576) ^ -981524391;
					continue;
				case 13u:
					flag3 = flag;
					num = -1470974458;
					continue;
				case 11u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = 2125319609;
						num5 = 2125319609;
					}
					else
					{
						num4 = 258756937;
						num5 = 258756937;
					}
					num = num4 ^ ((int)num2 * -1784008053);
					continue;
				}
				case 10u:
					num = (int)((num2 * 1859862503) ^ 0x6CB93D99);
					continue;
				case 9u:
					text2 = "";
					flag = false;
					num = ((int)num2 * -616047387) ^ 0x3844DFCE;
					continue;
				case 8u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1885754511;
					continue;
				case 7u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -1010957715) ^ 0x479D454E;
					continue;
				case 6u:
					num = ((int)num2 * -1126159895) ^ -1056313379;
					continue;
				case 4u:
					num = ((int)num2 * -1293024641) ^ -1049664999;
					continue;
				case 3u:
					num = (int)(num2 * 1127399869) ^ -1016962976;
					continue;
				case 2u:
				{
					char c3 = c2;
					c = c3;
					num = ((int)num2 * -1349152278) ^ 0x2C3A32E8;
					continue;
				}
				case 1u:
					num = ((int)num2 * -1226976733) ^ 0x6B4F08C0;
					continue;
				case 0u:
				{
					int num3;
					if (c == 'f')
					{
						num = -459446315;
						num3 = -459446315;
					}
					else
					{
						num = -1684722690;
						num3 = -1684722690;
					}
					continue;
				}
				case 132u:
					break;
				case 12u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 65u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0c28:
					s = JSONNode.smethod_8(aJSON, num9 + 1, 4);
					num = -1936933683;
					continue;
					IL_0c12:
					text = JSONNode.smethod_3(text, "\t");
					num = -366817705;
					continue;
					IL_0c08:
					num = -1816160831;
					continue;
					IL_0b95:
					num = -52455502;
					continue;
					IL_0070:
					flag10 = flag;
					num = -1255019431;
					continue;
					IL_091d:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -366817705;
					continue;
					IL_07e5:
					num9++;
					flag2 = flag;
					num = -490560224;
					continue;
					IL_036f:
					if (flag)
					{
						num = -321239850;
						num48 = -321239850;
					}
					else
					{
						num = -110348433;
						num48 = -110348433;
					}
					continue;
					IL_009f:
					num9++;
					num = -1711487375;
					continue;
					IL_007e:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num9).ToString());
					num = -285134611;
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
			int num = -719679622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1F46AC9u) % 4u)
				{
				case 3u:
				{
					BinaryWriter aWriter = JSONNode.smethod_9(aData);
					Serialize(aWriter);
					num = ((int)num2 * -1298978790) ^ -1990389814;
					continue;
				}
				case 1u:
					num = ((int)num2 * -205745112) ^ 0x47F9BDA3;
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
		while (true)
		{
			int num = -1096274597;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB062BF6Bu) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					FileStream fileStream = JSONNode.smethod_14(aFileName);
					try
					{
						while (true)
						{
							int num3 = -338935051;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xB062BF6Bu) % 3u)
								{
								case 1u:
									goto IL_0054;
								default:
									return;
								case 2u:
									break;
								case 0u:
									return;
								}
								break;
								IL_0054:
								SaveToStream(fileStream);
								num3 = (int)(num2 * 2046474237) ^ -1612140252;
							}
						}
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00c3:
								int num4 = -376119666;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xB062BF6Bu) % 3u)
									{
									case 1u:
										goto IL_0093;
									default:
										goto end_IL_00a6;
									case 0u:
										break;
									case 2u:
										goto end_IL_00a6;
									}
									goto IL_00c3;
									IL_0093:
									JSONNode.smethod_15((IDisposable)fileStream);
									num4 = ((int)num2 * -681662265) ^ 0x7E42BFA4;
									continue;
									end_IL_00a6:
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
				num = (int)(num2 * 495369192) ^ -1766924465;
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
				int num = -986014456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEAA5ECCDu) % 6u)
					{
					case 5u:
						num = (int)(num2 * 1809389822) ^ -419094982;
						continue;
					case 3u:
						SaveToStream(memoryStream);
						num = (int)((num2 * 2081754506) ^ 0x67FFE861);
						continue;
					case 1u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 687757141) ^ 0x7EE764FE);
						continue;
					case 0u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -948959313) ^ 0x7F8672D2;
						continue;
					case 2u:
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
					int num3 = -1341429665;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xEAA5ECCDu) % 3u)
						{
						case 2u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 0u:
							break;
						case 1u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -360470750) ^ -929598537;
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
		JSONNode aItem = default(JSONNode);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONClass jSONClass = default(JSONClass);
		JSONArray jSONArray = default(JSONArray);
		int num4 = default(int);
		int num5 = default(int);
		string aKey = default(string);
		int num3 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = 1832252160;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CA4C8FBu) % 39u)
				{
				case 38u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1982369261) ^ 0x556F011C;
					continue;
				case 36u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 881708975) ^ 0x5B31EBBA);
					continue;
				case 35u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -1154061379) ^ 0x2B1A487C;
					continue;
				case 34u:
					num = (int)((num2 * 1181917925) ^ 0x3CE421B2);
					continue;
				case 33u:
					num = ((int)num2 * -470077248) ^ -2133599382;
					continue;
				case 32u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 175791753) ^ 0x75C3365C);
					continue;
				case 31u:
					result = jSONClass;
					num = (int)((num2 * 415707890) ^ 0x69055ABD);
					continue;
				case 30u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 1367792253) ^ 0x6D698A3B);
					continue;
				case 29u:
					jSONArray.Add(Deserialize(aReader));
					num = 1114886774;
					continue;
				case 28u:
					num = 101605941;
					continue;
				case 27u:
				{
					int num8;
					if (num4 < num5)
					{
						num = 917666376;
						num8 = 917666376;
					}
					else
					{
						num = 1888301330;
						num8 = 1888301330;
					}
					continue;
				}
				case 24u:
					num = (int)(num2 * 329530953) ^ -1054694840;
					continue;
				case 23u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Value:
						break;
					default:
						goto IL_0155;
					case JSONBinaryTag.Array:
						goto IL_0168;
					case JSONBinaryTag.Class:
						goto IL_0179;
					case JSONBinaryTag.IntValue:
						goto IL_0183;
					case JSONBinaryTag.DoubleValue:
						goto IL_019a;
					case JSONBinaryTag.BoolValue:
						goto IL_01a4;
					case JSONBinaryTag.FloatValue:
						goto IL_01ae;
					}
					goto case 28u;
				case 0u:
					goto IL_0168;
				case 22u:
					goto IL_0179;
				case 9u:
					goto IL_0183;
				case 14u:
					goto IL_019a;
				case 11u:
					goto IL_01a4;
				case 8u:
					goto IL_01ae;
				case 21u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 1251489189) ^ 0x502B893B);
					continue;
				case 20u:
					num = ((int)num2 * -1044798870) ^ -889758729;
					continue;
				case 19u:
					num4++;
					num = (int)((num2 * 92160190) ^ 0x70CE81A6);
					continue;
				case 18u:
				{
					int num7;
					if (num3 >= num6)
					{
						num = 1826938526;
						num7 = 1826938526;
					}
					else
					{
						num = 606178996;
						num7 = 606178996;
					}
					continue;
				}
				case 17u:
					num = ((int)num2 * -1211970085) ^ 0x3F1C6B10;
					continue;
				case 16u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)((num2 * 1537688429) ^ 0x5CC8184A);
					continue;
				case 15u:
					num5 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = (int)(num2 * 395631028) ^ -372398954;
					continue;
				case 13u:
					num4 = 0;
					num = (int)(num2 * 966536413) ^ -1280600796;
					continue;
				case 12u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -231083773) ^ -483460240;
					continue;
				case 10u:
					num3++;
					num = (int)((num2 * 1176449318) ^ 0x65DB5058);
					continue;
				case 7u:
					num = ((int)num2 * -855900881) ^ 0x1791FAF2;
					continue;
				case 6u:
					aKey = JSONNode.smethod_22(aReader);
					num = 1553230768;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1695435490) ^ -1712685584;
					continue;
				case 4u:
					num = ((int)num2 * -678277604) ^ -1055474621;
					continue;
				case 3u:
					result = jSONArray;
					num = (int)(num2 * 1268936616) ^ -247994441;
					continue;
				case 2u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -1135854025) ^ -1169398019;
					continue;
				case 1u:
					num = ((int)num2 * -1735805136) ^ -767512865;
					continue;
				case 25u:
					break;
				case 37u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_01ae:
					num = 262495554;
					continue;
					IL_01a4:
					num = 1719734919;
					continue;
					IL_019a:
					num = 191175615;
					continue;
					IL_0183:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 1201249023;
					continue;
					IL_0179:
					num = 1416702363;
					continue;
					IL_0168:
					num6 = JSONNode.smethod_21(aReader);
					num = 1827647389;
					continue;
					IL_0155:
					num = ((int)num2 * -433072660) ^ -890028930;
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
					int num = 1289026081;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x4AAB2E32u) % 3u)
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
						num = ((int)num2 * -788608164) ^ -1032063684;
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
					IL_0058:
					int num = -209317162;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xECBB8BFFu) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)(num2 * 139756921) ^ -1622835382;
							continue;
						case 0u:
							num = ((int)num2 * -320069525) ^ -966428728;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
							break;
						case 3u:
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
			int num = -2018466738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC8A6D03u) % 6u)
				{
				case 5u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -366585377) ^ 0xA1604AA;
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1381960175) ^ 0x6D4BF0BE);
					continue;
				case 1u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -76393226) ^ -908183296;
					continue;
				}
				case 0u:
					num = ((int)num2 * -821425776) ^ -1323207384;
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

	public JSONNode()
	{
		while (true)
		{
			int num = -1755007204;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB19F7366u) % 3u)
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
				num = ((int)num2 * -835859067) ^ 0x1FDA12D2;
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
