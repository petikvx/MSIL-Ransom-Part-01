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
				int num = -547809829;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCD83E80Bu) % 3u)
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
					num = ((int)num2 * -182293488) ^ -1936280912;
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
				int num = 402563339;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3F4BD98u) % 3u)
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
					num = (int)((num2 * 1175322250) ^ 0x238E3EA2);
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
				int num = -1629234288;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF3F4ADE9u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1464839988) ^ 0x63E180CD);
						continue;
					case 1u:
						result = "";
						num = (int)((num2 * 1500416261) ^ 0x57D8A957);
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
				int num = 720527012;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B7FF83Fu) % 3u)
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
					num = (int)((num2 * 2138409119) ^ 0x58DF5E09);
				}
			}
		}
	}

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			while (true)
			{
				int num = 1208000062;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EB5C4D5u) % 6u)
					{
					case 4u:
						num = 1196890350;
						continue;
					case 1u:
						num = ((int)num2 * -1649120707) ^ -1933787124;
						continue;
					default:
						yield break;
					case 0u:
					case 3u:
						break;
					case 2u:
						yield break;
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
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 999414634;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42FAB7Bu) % 4u)
					{
					case 2u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)((num2 * 127298915) ^ 0x17B83079);
						continue;
					case 1u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1185796817) ^ 0xA4AC3CE;
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
			bool flag = default(bool);
			int result = default(int);
			int result2 = default(int);
			while (true)
			{
				int num = -949350031;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE4B7602Au) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -372715797;
							num4 = -372715797;
						}
						else
						{
							num3 = -340000373;
							num4 = -340000373;
						}
						num = num3 ^ (int)(num2 * 179610014);
						continue;
					}
					case 6u:
						result = 0;
						num = -1563845982;
						continue;
					case 4u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -156878198) ^ 0x3EA527E9;
						continue;
					case 3u:
						result = result2;
						num = ((int)num2 * -1967485871) ^ -838963307;
						continue;
					case 2u:
						num = ((int)num2 * -1196139638) ^ -1713138196;
						continue;
					case 1u:
						result2 = 0;
						num = ((int)num2 * -1512886651) ^ 0x307BB184;
						continue;
					case 0u:
						num = (int)((num2 * 289386789) ^ 0x7C8294C4);
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

	public virtual float AsFloat
	{
		get
		{
			float result = default(float);
			float result2 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = -2144549420;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB87FE6A7u) % 8u)
					{
					case 7u:
						result = 0f;
						num = -975678813;
						continue;
					case 6u:
						num = (int)(num2 * 47633245) ^ -1255524813;
						continue;
					case 4u:
						num = ((int)num2 * -982128965) ^ 0x75405D99;
						continue;
					case 3u:
						result2 = 0f;
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -226863804) ^ -2000445877;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -718309793) ^ 0x27939576;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -582569824;
							num4 = -582569824;
						}
						else
						{
							num3 = -1775214314;
							num4 = -1775214314;
						}
						num = num3 ^ (int)(num2 * 445635060);
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
			while (true)
			{
				int num = -209077101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8AE8479Du) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = (int)(num2 * 1290994227) ^ -1721787898;
						continue;
					case 1u:
						num = ((int)num2 * -196438229) ^ 0x4809D0BD;
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
			double result = 0.0;
			double result2 = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = -1697099355;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2F359B7u) % 7u)
					{
					case 6u:
						result2 = 0.0;
						num = -1197163289;
						continue;
					case 5u:
						num = ((int)num2 * -834190168) ^ -940991756;
						continue;
					case 4u:
						result2 = result;
						num = ((int)num2 * -1423915915) ^ -1984868516;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1238277858;
							num4 = 1238277858;
						}
						else
						{
							num3 = 346036707;
							num4 = 346036707;
						}
						num = num3 ^ (int)(num2 * 597770020);
						continue;
					}
					case 2u:
						flag = double.TryParse(Value, out result);
						num = (int)(num2 * 548438965) ^ -219090254;
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
				int num = -1707051794;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9FED4987u) % 4u)
					{
					case 1u:
						Value = value.ToString();
						num = (int)((num2 * 1005317866) ^ 0x1B52B7D1);
						continue;
					case 0u:
						num = (int)((num2 * 1335214104) ^ 0x6182E678);
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool flag = default(bool);
			bool result2 = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = -1923460722;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9ED1C5Du) % 9u)
					{
					case 8u:
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -2017395668) ^ -1957912216;
						continue;
					case 7u:
						result = !JSONNode.smethod_1(Value);
						num = -976022504;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1345803003;
							num4 = 1345803003;
						}
						else
						{
							num3 = 292212392;
							num4 = 292212392;
						}
						num = num3 ^ ((int)num2 * -1774595747);
						continue;
					}
					case 4u:
						result = result2;
						num = ((int)num2 * -269995384) ^ 0x75CDA232;
						continue;
					case 3u:
						num = ((int)num2 * -168310145) ^ 0x2C1D4587;
						continue;
					case 1u:
						result2 = false;
						num = ((int)num2 * -1724178854) ^ 0x10C1948B;
						continue;
					case 0u:
						num = (int)(num2 * 1126950914) ^ -1877817838;
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
				int num = -1426122132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96E10659u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 479837233) ^ -904460493;
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = -919516997;
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

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = -1867264722;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEDDC8A1u) % 3u)
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
					num = ((int)num2 * -446364781) ^ 0x2E4ADEB7;
				}
			}
		}
	}

	public virtual JSONClass AsObject => this as JSONClass;

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 53836082;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56CF808u) % 4u)
				{
				case 2u:
					Add("", aItem);
					num = (int)((num2 * 1406619072) ^ 0x1B9E2771);
					continue;
				case 1u:
					num = ((int)num2 * -899725775) ^ -1881176470;
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1193602580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C0BE59Bu) % 4u)
				{
				case 3u:
					result = null;
					num = ((int)num2 * -1244996585) ^ 0x7E787BDB;
					continue;
				case 1u:
					num = ((int)num2 * -1609268963) ^ -392561684;
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
			int num = -469964062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9510DD7Cu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1214731996) ^ -1028816963;
					continue;
				case 2u:
					result = null;
					num = (int)((num2 * 1644776504) ^ 0x19899427);
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

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -293975148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEEDE050u) % 3u)
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
				num = (int)((num2 * 2109716137) ^ 0x3607CCDE);
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -1990464881;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDACF232Fu) % 3u)
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
				num = (int)(num2 * 1746434513) ^ -1414857238;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		return "JSONNode";
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
			int num = -522918103;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xB2D59127u) % 4u)
				{
				case 3u:
					obj = d.Value;
					goto IL_0009;
				case 2u:
					if (!(d == null))
					{
						num = (int)((num2 * 1267262551) ^ 0xC727FE2);
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
					num = -1362357642;
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
			int num = -221554611;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xF4DC5A1Fu) % 7u)
				{
				case 6u:
					num5 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_000f;
				case 4u:
					result = (object)a == b;
					num = -182606235;
					continue;
				case 2u:
					if (b == null)
					{
						num = (int)(num2 * 896389318) ^ -558504496;
						continue;
					}
					num5 = 0;
					goto IL_000f;
				case 1u:
					result = true;
					num = (int)((num2 * 1671219966) ^ 0x3AF559F1);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1926632678;
						num4 = 1926632678;
					}
					else
					{
						num3 = 1724682583;
						num4 = 1724682583;
					}
					num = num3 ^ (int)(num2 * 309113519);
					continue;
				}
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_000f:
					flag = (byte)num5 != 0;
					num = -1293287682;
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
			int num = -169246814;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD9E7DDBu) % 3u)
				{
				case 1u:
					goto IL_0007;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0007:
				num = ((int)num2 * -1938041360) ^ -312277852;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -478564228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBB417F7u) % 3u)
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
				num = ((int)num2 * -837373009) ^ 0x325B24E7;
			}
		}
	}

	internal static string Escape(string aText)
	{
		char c3 = default(char);
		char c2 = default(char);
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		char c = default(char);
		string string_ = default(string);
		while (true)
		{
			int num = -2114147470;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAC10E97u) % 33u)
				{
				case 32u:
					c3 = c2;
					num = (int)((num2 * 1324499522) ^ 0x7981E660);
					continue;
				case 31u:
					num3++;
					num = -1104134984;
					continue;
				case 30u:
					switch (c3)
					{
					case '\b':
						goto IL_005f;
					case '\t':
						goto IL_0075;
					case '\n':
						goto IL_008b;
					case '\v':
						goto IL_00a1;
					case '\f':
						goto IL_00b9;
					case '\r':
						goto IL_00cf;
					}
					num = ((int)num2 * -1091406622) ^ 0xFB8298A;
					continue;
				case 1u:
					goto IL_005f;
				case 24u:
					goto IL_0075;
				case 27u:
					goto IL_008b;
				case 26u:
					goto IL_00a1;
				case 4u:
					goto IL_00b9;
				case 3u:
					goto IL_00cf;
				case 29u:
					num = (int)((num2 * 1763191323) ^ 0x7AED334E);
					continue;
				case 28u:
				{
					int num6;
					if (c3 == '\\')
					{
						num = -287288184;
						num6 = -287288184;
					}
					else
					{
						num = -2040009258;
						num6 = -2040009258;
					}
					continue;
				}
				case 25u:
					result = text;
					num = ((int)num2 * -1203452823) ^ 0x19EB00E9;
					continue;
				case 23u:
					num = (int)(num2 * 1173276807) ^ -77956038;
					continue;
				case 22u:
					num3 = 0;
					num = (int)(num2 * 985924700) ^ -178657887;
					continue;
				case 21u:
				{
					int num5;
					if (c3 != '"')
					{
						num = -402081490;
						num5 = -402081490;
					}
					else
					{
						num = -1277113645;
						num5 = -1277113645;
					}
					continue;
				}
				case 20u:
					num = (int)(num2 * 513841362) ^ -2011314773;
					continue;
				case 19u:
					num = (int)(num2 * 212037574) ^ -1954450020;
					continue;
				case 17u:
					num = (int)(num2 * 1936253646) ^ -452215718;
					continue;
				case 16u:
					num = ((int)num2 * -1421624835) ^ -1125533248;
					continue;
				case 15u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1014524589;
					continue;
				case 14u:
					num = (int)(num2 * 1268499044) ^ -956586377;
					continue;
				case 12u:
					text = "";
					num = (int)(num2 * 433340806) ^ -592658144;
					continue;
				case 11u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -876401983;
					continue;
				case 10u:
					num = ((int)num2 * -1691849659) ^ 0x5A44C017;
					continue;
				case 9u:
					c2 = c;
					num = (int)(num2 * 1856886078) ^ -2010898781;
					continue;
				case 8u:
					num = ((int)num2 * -2094547988) ^ 0xE5239FF;
					continue;
				case 7u:
					string_ = aText;
					num = ((int)num2 * -361109243) ^ 0x58D1F571;
					continue;
				case 6u:
				{
					int num4;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -1522950792;
						num4 = -1522950792;
					}
					else
					{
						num = -800535030;
						num4 = -800535030;
					}
					continue;
				}
				case 5u:
					c = JSONNode.smethod_2(string_, num3);
					num = -406213828;
					continue;
				case 2u:
					num = ((int)num2 * -1324491479) ^ -1735901618;
					continue;
				case 0u:
					num = ((int)num2 * -558588300) ^ -835422281;
					continue;
				case 13u:
					break;
				default:
					{
						return result;
					}
					IL_00a1:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -1736376396;
					continue;
					IL_008b:
					text = JSONNode.smethod_3(text, "\\n");
					num = -831882187;
					continue;
					IL_0075:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1041754994;
					continue;
					IL_005f:
					text = JSONNode.smethod_3(text, "\\b");
					num = -370541233;
					continue;
					IL_00cf:
					text = JSONNode.smethod_3(text, "\\r");
					num = -370541233;
					continue;
					IL_00b9:
					text = JSONNode.smethod_3(text, "\\f");
					num = -2066204311;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		JSONNode jSONNode = null;
		int num = 0;
		string text2 = default(string);
		string text = default(string);
		char c2 = default(char);
		char c = default(char);
		char c4 = default(char);
		char c3 = default(char);
		bool flag12 = default(bool);
		bool flag14 = default(bool);
		bool flag5 = default(bool);
		bool flag8 = default(bool);
		bool flag18 = default(bool);
		bool flag7 = default(bool);
		bool flag2 = default(bool);
		bool flag16 = default(bool);
		bool flag17 = default(bool);
		bool flag = default(bool);
		bool flag13 = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		bool flag15 = default(bool);
		bool flag9 = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num2 = 399463353;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x769B06A4u) % 150u)
				{
				case 149u:
					jSONNode.Add(text2, text);
					num2 = ((int)num3 * -606810921) ^ -626965413;
					continue;
				case 148u:
					num2 = ((int)num3 * -1373614139) ^ 0x6EB9A3AA;
					continue;
				case 147u:
				{
					int num53;
					if (c2 == 'f')
					{
						num2 = 836616525;
						num53 = 836616525;
					}
					else
					{
						num2 = 1720883649;
						num53 = 1720883649;
					}
					continue;
				}
				case 146u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num);
					c = c5;
					int num51;
					if ((uint)c <= 44u)
					{
						num2 = 64988341;
						num51 = 64988341;
					}
					else
					{
						num2 = 705089059;
						num51 = 705089059;
					}
					continue;
				}
				case 145u:
					c2 = c4;
					num2 = (int)((num3 * 571511551) ^ 0x3E3129FB);
					continue;
				case 144u:
					text2 = JSONNode.smethod_5(text2);
					num2 = (int)((num3 * 1249330408) ^ 0x35E32002);
					continue;
				case 143u:
					c3 = JSONNode.smethod_2(aJSON, num);
					c4 = c3;
					num2 = (int)((num3 * 1876108324) ^ 0x58CFD063);
					continue;
				case 142u:
					num2 = (int)((num3 * 882967634) ^ 0x7033966E);
					continue;
				case 141u:
					flag12 = JSONNode.smethod_6(text, "");
					num2 = (int)(num3 * 897002324) ^ -260717316;
					continue;
				case 28u:
				case 55u:
				case 83u:
				case 136u:
				case 140u:
					num++;
					num2 = 1093326457;
					continue;
				case 139u:
					num2 = 485525544;
					continue;
				case 138u:
				{
					int num54;
					if (c2 == 'n')
					{
						num2 = 483132317;
						num54 = 483132317;
					}
					else
					{
						num2 = 700679691;
						num54 = 700679691;
					}
					continue;
				}
				case 137u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num39;
					int num40;
					if (jSONNode is JSONArray)
					{
						num39 = 356470084;
						num40 = 356470084;
					}
					else
					{
						num39 = 233365632;
						num40 = 233365632;
					}
					num2 = num39 ^ ((int)num3 * -866129750);
					continue;
				}
				case 135u:
					num2 = ((int)num3 * -921517200) ^ -1100538075;
					continue;
				case 134u:
				{
					int num34;
					if (c != '"')
					{
						num2 = 717953614;
						num34 = 717953614;
					}
					else
					{
						num2 = 473803856;
						num34 = 473803856;
					}
					continue;
				}
				case 133u:
					flag14 = flag5;
					num2 = (int)(num3 * 1103269139) ^ -480917220;
					continue;
				case 132u:
					num2 = (int)((num3 * 1610777247) ^ 0x612F32D3);
					continue;
				case 131u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)((num3 * 2089233170) ^ 0x3F45890A);
					continue;
				case 130u:
				{
					int num12;
					if (c == ',')
					{
						num2 = 1985052036;
						num12 = 1985052036;
					}
					else
					{
						num2 = 1957681921;
						num12 = 1957681921;
					}
					continue;
				}
				case 129u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_0256;
					case '\t':
						goto IL_0269;
					case '\v':
					case '\f':
						goto IL_0277;
					}
					goto case 28u;
				case 126u:
					goto IL_0269;
				case 122u:
					goto IL_0277;
				case 128u:
					flag8 = JSONNode.smethod_6(text2, "");
					num2 = 919036427;
					continue;
				case 127u:
					num2 = (int)((num3 * 1861008797) ^ 0x75104D1C);
					continue;
				case 125u:
					num2 = (int)((num3 * 1484177598) ^ 0x2F02F072);
					continue;
				case 124u:
					num2 = ((int)num3 * -2125091241) ^ 0x2BE56F3E;
					continue;
				case 123u:
				{
					int num57;
					if (!flag5)
					{
						num2 = 1573212284;
						num57 = 1573212284;
					}
					else
					{
						num2 = 996123503;
						num57 = 996123503;
					}
					continue;
				}
				case 121u:
					num2 = (int)(num3 * 1424621835) ^ -912953074;
					continue;
				case 120u:
					flag18 = JSONNode.smethod_6(text2, "");
					num2 = 2145940306;
					continue;
				case 119u:
				{
					int num49;
					int num50;
					if (!flag7)
					{
						num49 = -1526668481;
						num50 = -1526668481;
					}
					else
					{
						num49 = -1436219049;
						num50 = -1436219049;
					}
					num2 = num49 ^ (int)(num3 * 1972219101);
					continue;
				}
				case 118u:
				{
					int num45;
					int num46;
					if (flag2)
					{
						num45 = -2035410862;
						num46 = -2035410862;
					}
					else
					{
						num45 = -290023977;
						num46 = -290023977;
					}
					num2 = num45 ^ ((int)num3 * -1632832917);
					continue;
				}
				case 117u:
					jSONNode.Add(stack.Peek());
					num2 = (int)((num3 * 29087561) ^ 0x35F195A3);
					continue;
				case 116u:
					num2 = ((int)num3 * -49758702) ^ 0x7054561C;
					continue;
				case 115u:
					text = "";
					text2 = "";
					flag5 = false;
					num2 = (int)(num3 * 1044888948) ^ -1151031906;
					continue;
				case 114u:
				{
					int num37;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num2 = 231482884;
						num37 = 231482884;
					}
					else
					{
						num2 = 1376796871;
						num37 = 1376796871;
					}
					continue;
				}
				case 113u:
					stack.Pop();
					num2 = 670918541;
					continue;
				case 112u:
					flag16 = jSONNode is JSONArray;
					num2 = ((int)num3 * -2125580034) ^ -1578896643;
					continue;
				case 111u:
					num2 = ((int)num3 * -1576951400) ^ 0x5D6D7606;
					continue;
				case 110u:
					jSONNode.Add(text2, stack.Peek());
					num2 = ((int)num3 * -11531943) ^ 0xF3655BB;
					continue;
				case 109u:
				{
					int num30;
					int num31;
					if ((uint)c > 32u)
					{
						num30 = -805032537;
						num31 = -805032537;
					}
					else
					{
						num30 = -1807901818;
						num31 = -1807901818;
					}
					num2 = num30 ^ ((int)num3 * -474658937);
					continue;
				}
				case 108u:
					num2 = (int)(num3 * 213628570) ^ -590512581;
					continue;
				case 107u:
					num2 = ((int)num3 * -178797284) ^ -1229810183;
					continue;
				case 106u:
					num2 = 1141198500;
					continue;
				case 105u:
					num2 = (int)(num3 * 1940333652) ^ -658224823;
					continue;
				case 104u:
					num2 = ((int)num3 * -1320451403) ^ 0x75A2F0A2;
					continue;
				case 103u:
				{
					int num21;
					int num22;
					if (!flag14)
					{
						num21 = 74983306;
						num22 = 74983306;
					}
					else
					{
						num21 = 1790289585;
						num22 = 1790289585;
					}
					num2 = num21 ^ ((int)num3 * -633752558);
					continue;
				}
				case 102u:
					num2 = 461627595;
					continue;
				case 101u:
					num2 = ((int)num3 * -75365093) ^ -933680701;
					continue;
				case 100u:
				{
					int num17;
					if (c == '}')
					{
						num2 = 170653272;
						num17 = 170653272;
					}
					else
					{
						num2 = 1035248711;
						num17 = 1035248711;
					}
					continue;
				}
				case 99u:
					text2 = "";
					num2 = 1140079777;
					continue;
				case 98u:
					num2 = (int)((num3 * 828769814) ^ 0x4B62D6B8);
					continue;
				case 97u:
					flag7 = jSONNode is JSONArray;
					num2 = ((int)num3 * -649787463) ^ 0x58C68CA6;
					continue;
				case 96u:
					num2 = (int)((num3 * 1026267648) ^ 0x1ACF904C);
					continue;
				case 95u:
					num2 = (int)((num3 * 1102929801) ^ 0x51D412CF);
					continue;
				case 94u:
				{
					int num8;
					int num9;
					if ((uint)c2 > 102u)
					{
						num8 = 2056381204;
						num9 = 2056381204;
					}
					else
					{
						num8 = 1852866130;
						num9 = 1852866130;
					}
					num2 = num8 ^ ((int)num3 * -1133801674);
					continue;
				}
				case 93u:
					num2 = ((int)num3 * -1320374447) ^ -232986359;
					continue;
				case 92u:
					jSONNode.Add(stack.Peek());
					num2 = (int)((num3 * 1263434693) ^ 0xBF3864A);
					continue;
				case 91u:
					num2 = (int)(num3 * 1361281466) ^ -1137282708;
					continue;
				case 90u:
				{
					string s = JSONNode.smethod_8(aJSON, num + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num2 = ((int)num3 * -893708072) ^ 0x1C5A66AF;
					continue;
				}
				case 89u:
					flag2 = jSONNode != null;
					num2 = (int)((num3 * 1776410642) ^ 0x76FDC060);
					continue;
				case 88u:
					num2 = (int)((num3 * 1754048679) ^ 0x1DA732A2);
					continue;
				case 87u:
					num2 = ((int)num3 * -1209074704) ^ 0x1299B42B;
					continue;
				case 86u:
					flag5 = !flag5;
					num2 = 815110885;
					continue;
				case 85u:
				{
					int num61;
					int num62;
					if (!flag17)
					{
						num61 = -1771844075;
						num62 = -1771844075;
					}
					else
					{
						num61 = -463813026;
						num62 = -463813026;
					}
					num2 = num61 ^ ((int)num3 * -1873280389);
					continue;
				}
				case 84u:
					num2 = (int)(num3 * 1597639310) ^ -1647861778;
					continue;
				case 82u:
				{
					int num59;
					int num60;
					if (!flag18)
					{
						num59 = -1957594600;
						num60 = -1957594600;
					}
					else
					{
						num59 = -10264671;
						num60 = -10264671;
					}
					num2 = num59 ^ (int)(num3 * 2091452174);
					continue;
				}
				case 81u:
					num2 = ((int)num3 * -182383462) ^ -1798133077;
					continue;
				case 79u:
				{
					int num58;
					if (flag5)
					{
						num2 = 1896029355;
						num58 = 1896029355;
					}
					else
					{
						num2 = 384066415;
						num58 = 384066415;
					}
					continue;
				}
				case 78u:
					jSONNode.Add(text);
					num2 = ((int)num3 * -1548065939) ^ -1815114784;
					continue;
				case 77u:
					num += 4;
					num2 = ((int)num3 * -1658637797) ^ 0x21FF1711;
					continue;
				case 75u:
				{
					int num55;
					int num56;
					if (!flag16)
					{
						num55 = 1002029767;
						num56 = 1002029767;
					}
					else
					{
						num55 = 1041299273;
						num56 = 1041299273;
					}
					num2 = num55 ^ ((int)num3 * -178409921);
					continue;
				}
				case 74u:
					flag = stack.Count == 0;
					num2 = 1452307858;
					continue;
				case 73u:
					flag13 = JSONNode.smethod_6(text, "");
					num2 = 1193829029;
					continue;
				case 72u:
					num2 = 451196553;
					continue;
				case 71u:
					jSONNode = stack.Peek();
					num2 = (int)((num3 * 291948593) ^ 0x45352EB6);
					continue;
				case 70u:
				{
					text2 = "";
					text = "";
					int num52;
					if (stack.Count > 0)
					{
						num2 = 2112751055;
						num52 = 2112751055;
					}
					else
					{
						num2 = 1442151735;
						num52 = 1442151735;
					}
					continue;
				}
				case 69u:
					jSONNode.Add(text2, text);
					num2 = ((int)num3 * -343244778) ^ 0x61AE7A3E;
					continue;
				case 68u:
				{
					int num47;
					int num48;
					if (!flag10)
					{
						num47 = -1076958253;
						num48 = -1076958253;
					}
					else
					{
						num47 = -405720687;
						num48 = -405720687;
					}
					num2 = num47 ^ ((int)num3 * -240179723);
					continue;
				}
				case 67u:
					goto IL_087d;
				case 66u:
				{
					int num43;
					int num44;
					if (!flag5)
					{
						num43 = 1723096543;
						num44 = 1723096543;
					}
					else
					{
						num43 = 417214837;
						num44 = 417214837;
					}
					num2 = num43 ^ ((int)num3 * -1087207992);
					continue;
				}
				case 65u:
					goto IL_08be;
				case 64u:
					num2 = (int)((num3 * 1590465292) ^ 0x4CD0D91C);
					continue;
				case 63u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num2 = 2130462796;
					continue;
				case 62u:
					text2 = JSONNode.smethod_5(text2);
					flag17 = jSONNode is JSONArray;
					num2 = (int)((num3 * 1345752889) ^ 0x502851C9);
					continue;
				case 61u:
					switch (c2)
					{
					case 'u':
						break;
					case 's':
						goto IL_087d;
					case 'r':
						goto IL_08be;
					default:
						goto IL_0946;
					case 't':
						goto IL_0950;
					}
					goto case 139u;
				case 27u:
					goto IL_0950;
				case 60u:
				{
					int num41;
					int num42;
					if (flag6)
					{
						num41 = 1587590364;
						num42 = 1587590364;
					}
					else
					{
						num41 = 1482114850;
						num42 = 1482114850;
					}
					num2 = num41 ^ (int)(num3 * 275863792);
					continue;
				}
				case 59u:
				{
					int num38;
					if ((uint)c <= 93u)
					{
						num2 = 348562826;
						num38 = 348562826;
					}
					else
					{
						num2 = 1134557633;
						num38 = 1134557633;
					}
					continue;
				}
				case 58u:
					num2 = (int)((num3 * 580890075) ^ 0x549C4F86);
					continue;
				case 57u:
					stack.Push(new JSONArray());
					num2 = 1382812213;
					continue;
				case 56u:
				{
					int num35;
					int num36;
					if (flag15)
					{
						num35 = 1562497311;
						num36 = 1562497311;
					}
					else
					{
						num35 = 1859192006;
						num36 = 1859192006;
					}
					num2 = num35 ^ (int)(num3 * 28837866);
					continue;
				}
				case 54u:
					flag15 = JSONNode.smethod_6(text2, "");
					num2 = 1079231236;
					continue;
				case 53u:
					num++;
					num2 = 619637577;
					continue;
				case 52u:
					num2 = (int)((num3 * 1091574737) ^ 0x479B9962);
					continue;
				case 51u:
					text2 = "";
					text = "";
					num2 = 274614811;
					continue;
				case 50u:
				{
					int num32;
					int num33;
					if (flag12)
					{
						num32 = 940526672;
						num33 = 940526672;
					}
					else
					{
						num32 = 13486808;
						num33 = 13486808;
					}
					num2 = num32 ^ ((int)num3 * -87480003);
					continue;
				}
				case 48u:
					num2 = (int)(num3 * 246472746) ^ -475544968;
					continue;
				case 47u:
					text = "";
					num2 = (int)(num3 * 1457955787) ^ -2124515141;
					continue;
				case 46u:
				{
					int num28;
					int num29;
					if (!flag9)
					{
						num28 = 1155020224;
						num29 = 1155020224;
					}
					else
					{
						num28 = 1893287476;
						num29 = 1893287476;
					}
					num2 = num28 ^ ((int)num3 * -1768824463);
					continue;
				}
				case 45u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)(num3 * 1030758134) ^ -2115194128;
					continue;
				case 44u:
				{
					int num27;
					if (c != ' ')
					{
						num2 = 1764645007;
						num27 = 1764645007;
					}
					else
					{
						num2 = 1173382628;
						num27 = 1173382628;
					}
					continue;
				}
				case 43u:
					flag3 = num < JSONNode.smethod_4(aJSON);
					num2 = 436590583;
					continue;
				case 42u:
					flag4 = flag5;
					num2 = 1218537484;
					continue;
				case 41u:
					num2 = (int)(num3 * 2069670589) ^ -1039024999;
					continue;
				case 40u:
				{
					int num25;
					int num26;
					if (c == ':')
					{
						num25 = 597278573;
						num26 = 597278573;
					}
					else
					{
						num25 = 1004176090;
						num26 = 1004176090;
					}
					num2 = num25 ^ ((int)num3 * -1397215842);
					continue;
				}
				case 38u:
				{
					int num23;
					int num24;
					if (!flag11)
					{
						num23 = 296998753;
						num24 = 296998753;
					}
					else
					{
						num23 = 995144248;
						num24 = 995144248;
					}
					num2 = num23 ^ ((int)num3 * -1506834833);
					continue;
				}
				case 37u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)((num3 * 1158885005) ^ 0x6F3E56B);
					continue;
				case 36u:
					num2 = (int)((num3 * 1440116142) ^ 0x2263BE9F);
					continue;
				case 35u:
					num2 = (int)(num3 * 1447916173) ^ -522285426;
					continue;
				case 34u:
					text = JSONNode.smethod_3(text, "\b");
					num2 = 1048881310;
					continue;
				case 33u:
					text = JSONNode.smethod_3(text, "\f");
					num2 = 1048881310;
					continue;
				case 32u:
					jSONNode.Add(text);
					num2 = ((int)num3 * -1091201046) ^ 0x27D323C6;
					continue;
				case 31u:
					num2 = (int)((num3 * 1755618936) ^ 0x69236BAB);
					continue;
				case 30u:
					num2 = (int)(num3 * 744927198) ^ -866390779;
					continue;
				case 29u:
				{
					int num19;
					int num20;
					if (flag13)
					{
						num19 = -1799279176;
						num20 = -1799279176;
					}
					else
					{
						num19 = -1305919316;
						num20 = -1305919316;
					}
					num2 = num19 ^ (int)(num3 * 57500775);
					continue;
				}
				case 26u:
					num2 = ((int)num3 * -2069938458) ^ 0x553217B;
					continue;
				case 25u:
					jSONNode.Add(text2, stack.Peek());
					num2 = (int)((num3 * 1068666614) ^ 0x32ABC3B0);
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)(num3 * 1442083771) ^ -1471773622;
					continue;
				case 23u:
				{
					int num18;
					if (c != '{')
					{
						num2 = 1424994930;
						num18 = 1424994930;
					}
					else
					{
						num2 = 904990921;
						num18 = 904990921;
					}
					continue;
				}
				case 22u:
					text = "";
					num2 = (int)((num3 * 1562349264) ^ 0x75A413F6);
					continue;
				case 21u:
					result = jSONNode;
					num2 = 1243472666;
					continue;
				case 20u:
					num2 = 694799556;
					continue;
				case 19u:
					num2 = (int)((num3 * 2043915866) ^ 0x59BA9F9C);
					continue;
				case 18u:
					num2 = (int)((num3 * 1011774408) ^ 0x1A4C5FA9);
					continue;
				case 17u:
					stack.Push(new JSONClass());
					flag11 = jSONNode != null;
					num2 = 424898336;
					continue;
				case 16u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = (int)(num3 * 951731376) ^ -1632802740;
					continue;
				case 15u:
					text = JSONNode.smethod_3(text, "\n");
					num2 = 1048881310;
					continue;
				case 14u:
					goto IL_0dc4;
				case 13u:
					jSONNode = stack.Peek();
					num2 = (int)((num3 * 1505388681) ^ 0xC353174);
					continue;
				case 12u:
					goto IL_0dec;
				case 11u:
				{
					int num15;
					int num16;
					if (flag8)
					{
						num15 = -1366330843;
						num16 = -1366330843;
					}
					else
					{
						num15 = -1800128250;
						num16 = -1800128250;
					}
					num2 = num15 ^ ((int)num3 * -369099891);
					continue;
				}
				case 10u:
				{
					int num13;
					int num14;
					if (c2 == 'b')
					{
						num13 = -455304154;
						num14 = -455304154;
					}
					else
					{
						num13 = -920289733;
						num14 = -920289733;
					}
					num2 = num13 ^ (int)(num3 * 319356928);
					continue;
				}
				case 9u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = ((int)num3 * -1429788758) ^ 0x22302C52;
					continue;
				case 8u:
				{
					int num10;
					int num11;
					if (!flag4)
					{
						num10 = -660532977;
						num11 = -660532977;
					}
					else
					{
						num10 = -1218388840;
						num11 = -1218388840;
					}
					num2 = num10 ^ ((int)num3 * -1465839525);
					continue;
				}
				case 7u:
					num2 = 1206849373;
					continue;
				case 6u:
					num2 = (int)(num3 * 246061775) ^ -697833818;
					continue;
				case 5u:
					num2 = (int)(num3 * 1695328619) ^ -1632748575;
					continue;
				case 4u:
					text2 = text;
					num2 = 746025338;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = -1713828952;
						num7 = -1713828952;
					}
					else
					{
						num6 = -687051470;
						num7 = -687051470;
					}
					num2 = num6 ^ ((int)num3 * -60130744);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -459113924;
						num5 = -459113924;
					}
					else
					{
						num4 = -581513087;
						num5 = -581513087;
					}
					num2 = num4 ^ ((int)num3 * -152608211);
					continue;
				}
				case 1u:
					switch (c)
					{
					case '\\':
						break;
					case '[':
						goto IL_0dc4;
					case ']':
						goto IL_0dec;
					default:
						goto IL_0f3d;
					}
					goto case 53u;
				case 0u:
					num2 = ((int)num3 * -1286589695) ^ 0x102B3773;
					continue;
				case 39u:
					break;
				case 49u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 76u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0f3d:
					num2 = 1032209186;
					continue;
					IL_0269:
					flag6 = flag5;
					num2 = 541147138;
					continue;
					IL_0256:
					num2 = (int)((num3 * 427575852) ^ 0x73C032BD);
					continue;
					IL_0dec:
					flag9 = flag5;
					num2 = 191693004;
					continue;
					IL_0dc4:
					flag10 = flag5;
					num2 = 325138090;
					continue;
					IL_0950:
					text = JSONNode.smethod_3(text, "\t");
					num2 = 1048881310;
					continue;
					IL_0946:
					num2 = 2037510025;
					continue;
					IL_08be:
					text = JSONNode.smethod_3(text, "\r");
					num2 = 1795867692;
					continue;
					IL_087d:
					text = JSONNode.smethod_3(text, c3.ToString());
					num2 = 1598766917;
					continue;
					IL_0277:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num).ToString());
					num2 = 1497502520;
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
			int num = -760220163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x98A83456u) % 3u)
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
				num = (int)(num2 * 280667633) ^ -864471071;
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
			int num = -889555981;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7340BE5u) % 3u)
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
							int num3 = -692432192;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xD7340BE5u) % 3u)
								{
								case 2u:
									goto IL_0054;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_0054:
								SaveToStream(fileStream);
								num3 = ((int)num2 * -752050940) ^ -548047745;
							}
						}
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00d6:
								int num4 = -50353020;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xD7340BE5u) % 4u)
									{
									case 1u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num4 = (int)((num2 * 1829583242) ^ 0x2F2B38BB);
										continue;
									case 0u:
										num4 = ((int)num2 * -2101700704) ^ 0x2EF4B16A;
										continue;
									default:
										goto end_IL_00b5;
									case 2u:
										break;
									case 3u:
										goto end_IL_00b5;
									}
									goto IL_00d6;
									continue;
									end_IL_00b5:
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
				num = (int)(num2 * 1597695493) ^ -1606734719;
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
				int num = 1513120859;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19DBFD11u) % 6u)
					{
					case 5u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 1609204501) ^ 0x40173EDD);
						continue;
					case 4u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -1882849881) ^ 0x3AF333;
						continue;
					case 2u:
						num = ((int)num2 * -948335028) ^ -1562955306;
						continue;
					case 1u:
						num = ((int)num2 * -200635705) ^ 0x3C2B7967;
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
					IL_00cc:
					int num3 = 1045120100;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x19DBFD11u) % 3u)
						{
						case 2u:
							goto IL_009c;
						default:
							goto end_IL_00af;
						case 0u:
							break;
						case 1u:
							goto end_IL_00af;
						}
						goto IL_00cc;
						IL_009c:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = (int)(num2 * 1473999675) ^ -563881339;
						continue;
						end_IL_00af:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		int num6 = default(int);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		string aKey = default(string);
		int num3 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num4 = default(int);
		JSONNode aItem = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num5 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		while (true)
		{
			int num = -1213584362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95990A35u) % 40u)
				{
				case 39u:
					num = -325833355;
					continue;
				case 38u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1433479463) ^ 0x728142FC;
					continue;
				case 37u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = 1878058530;
						num9 = 1878058530;
					}
					else
					{
						num8 = 1152503568;
						num9 = 1152503568;
					}
					num = num8 ^ ((int)num2 * -287042534);
					continue;
				}
				case 36u:
					num = (int)((num2 * 1997830107) ^ 0x6C06570F);
					continue;
				case 35u:
					num = (int)(num2 * 1378766258) ^ -1421529395;
					continue;
				case 34u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 2054844694) ^ 0x2A408132);
					continue;
				case 33u:
					num = ((int)num2 * -73281790) ^ -1715544135;
					continue;
				case 32u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 1431761340) ^ 0x65BCBBBF);
					continue;
				case 31u:
				{
					int num7;
					if (num3 < num6)
					{
						num = -994863328;
						num7 = -994863328;
					}
					else
					{
						num = -1397493001;
						num7 = -1397493001;
					}
					continue;
				}
				case 28u:
					num = (int)((num2 * 1435874963) ^ 0x35394C37);
					continue;
				case 27u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -916811204;
					continue;
				case 26u:
					result = jSONArray;
					num = (int)(num2 * 1416937067) ^ -488874563;
					continue;
				case 25u:
					num4 = 0;
					num = ((int)num2 * -179470948) ^ 0x2BE933A0;
					continue;
				case 23u:
					num4++;
					num = (int)(num2 * 1106393682) ^ -1235704735;
					continue;
				case 22u:
					num = (int)((num2 * 1590774332) ^ 0x305D436A);
					continue;
				case 21u:
					jSONArray.Add(Deserialize(aReader));
					num = -1505160287;
					continue;
				case 20u:
					goto IL_0184;
				case 19u:
					goto IL_018e;
				case 18u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1962187525) ^ -1182465515;
					continue;
				case 17u:
					num = (int)((num2 * 394807972) ^ 0x3532737B);
					continue;
				case 16u:
					num = (int)((num2 * 693321715) ^ 0x595D7783);
					continue;
				case 15u:
					goto IL_01d9;
				case 14u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1667421440) ^ -2025999807;
					continue;
				case 13u:
					goto IL_0210;
				case 12u:
					num = ((int)num2 * -726042939) ^ 0x7276D870;
					continue;
				case 11u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.FloatValue:
						break;
					case JSONBinaryTag.DoubleValue:
						goto IL_0184;
					case JSONBinaryTag.Array:
						goto IL_018e;
					case JSONBinaryTag.Class:
						goto IL_01d9;
					case JSONBinaryTag.BoolValue:
						goto IL_0210;
					default:
						goto IL_0260;
					case JSONBinaryTag.Value:
						goto IL_0273;
					case JSONBinaryTag.IntValue:
						goto IL_028a;
					}
					goto case 27u;
				case 0u:
					goto IL_0273;
				case 9u:
					goto IL_028a;
				case 10u:
					flag = num4 < num5;
					num = -1571569512;
					continue;
				case 8u:
					num = (int)((num2 * 1417910991) ^ 0x5AC939BD);
					continue;
				case 7u:
					jSONArray = new JSONArray();
					num3 = 0;
					num = ((int)num2 * -948846138) ^ -537240757;
					continue;
				case 6u:
					num = ((int)num2 * -1439290863) ^ -46487363;
					continue;
				case 5u:
					result = jSONClass;
					num = (int)(num2 * 1649832051) ^ -1886625114;
					continue;
				case 4u:
					num = (int)(num2 * 1033279346) ^ -116558342;
					continue;
				case 3u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)((num2 * 807442808) ^ 0x401D4C5F);
					continue;
				case 2u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)(num2 * 98727135) ^ -2057259336;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 14514431) ^ 0x60F7AA6D);
					continue;
				case 29u:
					break;
				case 24u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_028a:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -1481207165;
					continue;
					IL_0273:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -878597973;
					continue;
					IL_0260:
					num = (int)((num2 * 689432675) ^ 0x78A5B4B4);
					continue;
					IL_0210:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1509876723;
					continue;
					IL_01d9:
					num5 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = -942142108;
					continue;
					IL_018e:
					num = -92374349;
					continue;
					IL_0184:
					num = -1515114089;
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
					int num = 1913935114;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x5AA0527Bu) % 3u)
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
						num = ((int)num2 * -321471733) ^ -1854496887;
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
					int num = -1811531939;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xC980CAEAu) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -1294019356) ^ -1523700533;
							continue;
						case 1u:
							num = (int)((num2 * 556946642) ^ 0x7FD5B7FE);
							continue;
						default:
							goto end_IL_0037;
						case 0u:
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1721783640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DC16133u) % 4u)
				{
				case 3u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 2104057214) ^ 0x5E676349);
					continue;
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1994284830) ^ -1383333334;
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
