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
				int num = 605504777;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x54D4C0E4u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -419127602) ^ 0x39B3AEB0;
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -980658964) ^ -1970507486;
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
				int num = -1938789878;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC348F1F9u) % 3u)
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
					result = "";
					num = (int)((num2 * 252713452) ^ 0x6E5DF040);
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
				int num = 922076700;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73853223u) % 4u)
					{
					case 3u:
						result = 0;
						num = (int)(num2 * 46787770) ^ -1584121648;
						continue;
					case 1u:
						num = (int)((num2 * 1478238507) ^ 0x1628AA);
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
			while (true)
			{
				int num = -452181036;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8069608u) % 7u)
					{
					case 6u:
						num = (int)(num2 * 161415419) ^ -653571241;
						continue;
					case 2u:
					case 3u:
						num = -982442523;
						continue;
					case 1u:
					{
						int num3;
						num = ((num3 == 0) ? (-2048686433) : (-488193155)) ^ ((int)num2 * -1057895097);
						continue;
					}
					default:
						yield break;
					case 5u:
						break;
					case 4u:
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
				int num = 1156933255;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x612B7A66u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					result = _003Cget_DeepChilds_003Ed__;
					num = (int)((num2 * 585406246) ^ 0x4868FAB4);
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
				int num = 1361928956;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69B4385Du) % 7u)
					{
					case 6u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -787825820) ^ -1941131531;
						continue;
					case 5u:
						result = 0;
						num = 773843201;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1346417630;
							num4 = 1346417630;
						}
						else
						{
							num3 = 1157448795;
							num4 = 1157448795;
						}
						num = num3 ^ (int)(num2 * 1613808403);
						continue;
					}
					case 2u:
						result = result2;
						num = (int)(num2 * 1971857585) ^ -76696573;
						continue;
					case 1u:
						result2 = 0;
						num = (int)(num2 * 767023110) ^ -1872566150;
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
				int num = 419156895;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7C679D7Eu) % 3u)
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
					num = ((int)num2 * -544946815) ^ -722262463;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
			{
				goto IL_0050;
			}
			goto IL_007e;
			IL_007e:
			float result2 = 0f;
			int num = 1955153923;
			goto IL_0055;
			IL_0055:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7788C02u) % 6u)
				{
				case 4u:
					num = (int)((num2 * 1219286254) ^ 0x21A62B18);
					continue;
				case 3u:
					result2 = result;
					num = (int)(num2 * 1309623771) ^ -1254825777;
					continue;
				case 1u:
					num = ((int)num2 * -1665886552) ^ 0x3663CBD8;
					continue;
				case 0u:
					break;
				case 5u:
					goto IL_007e;
				default:
					return result2;
				}
				break;
			}
			goto IL_0050;
			IL_0050:
			num = 575938353;
			goto IL_0055;
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
			bool flag = default(bool);
			double result = default(double);
			double result2 = default(double);
			while (true)
			{
				int num = -189147750;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D232C9Eu) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 644775252;
							num4 = 644775252;
						}
						else
						{
							num3 = 1013597216;
							num4 = 1013597216;
						}
						num = num3 ^ ((int)num2 * -2122935559);
						continue;
					}
					case 5u:
						result = 0.0;
						num = -297323388;
						continue;
					case 4u:
						result2 = 0.0;
						num = (int)(num2 * 1857218720) ^ -458904971;
						continue;
					case 3u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -1867811216) ^ -1839959247;
						continue;
					case 2u:
						num = ((int)num2 * -1394386888) ^ 0x7B49C82E;
						continue;
					case 1u:
						result = result2;
						num = (int)(num2 * 447853666) ^ -2023168948;
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
				int num = -1177361413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE8A9CB5u) % 3u)
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
					num = ((int)num2 * -2017328766) ^ 0xE7A52C;
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
				int num = -2923704;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD7B56EAFu) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1718223003;
							num4 = -1718223003;
						}
						else
						{
							num3 = -344549423;
							num4 = -344549423;
						}
						num = num3 ^ ((int)num2 * -2041416402);
						continue;
					}
					case 4u:
						result2 = result;
						num = (int)((num2 * 1827384247) ^ 0x170A90AA);
						continue;
					case 3u:
						num = (int)((num2 * 512573901) ^ 0x127A3E11);
						continue;
					case 2u:
						result2 = !JSONNode.smethod_1(Value);
						num = -1264203340;
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
				int num = -224782881;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ -1684345535) % 3u)
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
					num = -975892886;
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
				int num = 1296902889;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68D464Cu) % 4u)
					{
					case 1u:
						result = this as JSONArray;
						num = (int)((num2 * 32923881) ^ 0x4AC08BF5);
						continue;
					case 0u:
						num = (int)((num2 * 677459417) ^ 0x221C389F);
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -1139974126;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9AAF02A5u) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = ((int)num2 * -27262083) ^ -1827521072;
						continue;
					case 2u:
						num = (int)((num2 * 42868149) ^ 0x4F911EE2);
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
			int num = -250294109;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEB42850u) % 3u)
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
				num = ((int)num2 * -1519016272) ^ 0x463CA5CF;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 524283049;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37CAC4C3u) % 3u)
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
				num = (int)((num2 * 1549782228) ^ 0x33B8D2A9);
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -332207561;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCCD1030u) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0004:
				num = (int)(num2 * 1084175501) ^ -649740271;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -144131046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE249EB1Bu) % 3u)
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
				num = (int)(num2 * 1076076016) ^ -2089952881;
			}
		}
	}

	public override string ToString()
	{
		return "JSONNode";
	}

	public virtual string ToString(string aPrefix)
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 683501499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5426FF43u) % 3u)
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
				num = ((int)num2 * -474537592) ^ -2073798985;
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
			int num = 1682894237;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x5A9EAC0u) % 4u)
				{
				case 3u:
					obj = d.Value;
					goto IL_0009;
				case 1u:
					if (!(d == null))
					{
						num = ((int)num2 * -365499118) ^ 0x5222D42D;
						continue;
					}
					obj = null;
					goto IL_0009;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = 715588792;
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
			int num = 1363616251;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x6F0F2550u) % 9u)
				{
				case 8u:
					result = true;
					num = (int)((num2 * 1105636627) ^ 0x45C01530);
					continue;
				case 6u:
					if (b == null)
					{
						num = ((int)num2 * -981625480) ^ -1204005900;
						continue;
					}
					num5 = 0;
					goto IL_002a;
				case 5u:
					result = (object)a == b;
					num = 1643509982;
					continue;
				case 3u:
					num = ((int)num2 * -1646109969) ^ -472308167;
					continue;
				case 2u:
					num5 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_002a;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1806498765;
						num4 = -1806498765;
					}
					else
					{
						num3 = -345103829;
						num4 = -345103829;
					}
					num = num3 ^ ((int)num2 * -1059684135);
					continue;
				}
				case 0u:
					num = (int)((num2 * 428049147) ^ 0x6E2FE226);
					continue;
				case 7u:
					break;
				default:
					{
						return result;
					}
					IL_002a:
					flag = (byte)num5 != 0;
					num = 2143974602;
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
			int num = 1110595463;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12FFDD82u) % 3u)
				{
				case 2u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = ((int)num2 * -378373175) ^ 0x5307CAF6;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -582258194;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DC8C161u) % 3u)
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
				result = (object)this == obj;
				num = (int)((num2 * 1212891107) ^ 0x78749EB3);
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = 2001504547;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7486B7E6u) % 4u)
				{
				case 1u:
					result = this.method_0();
					num = ((int)num2 * -1961143904) ^ -1317675414;
					continue;
				case 0u:
					num = ((int)num2 * -2068063603) ^ -1908473880;
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
		char c = default(char);
		string result = default(string);
		char c2 = default(char);
		char c3 = default(char);
		int num3 = default(int);
		string string_ = default(string);
		while (true)
		{
			int num = -633869816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC84B29ADu) % 34u)
				{
				case 33u:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -334674104;
					continue;
				case 32u:
					goto IL_001e;
				case 31u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -963340801;
					continue;
				case 30u:
					num = (int)((num2 * 1103029023) ^ 0x32B71758);
					continue;
				case 29u:
					result = text;
					num = (int)(num2 * 1647362632) ^ -1144965971;
					continue;
				case 27u:
					num = (int)(num2 * 521953923) ^ -1714158802;
					continue;
				case 26u:
					num = ((int)num2 * -1704524532) ^ 0x3A2C0DB4;
					continue;
				case 25u:
					goto IL_0099;
				case 24u:
					goto IL_00af;
				case 23u:
					num = ((int)num2 * -227519801) ^ 0x450FF1E1;
					continue;
				case 22u:
					goto IL_00d8;
				case 20u:
				{
					int num6;
					if (c2 != '\\')
					{
						num = -236619645;
						num6 = -236619645;
					}
					else
					{
						num = -1316542770;
						num6 = -1316542770;
					}
					continue;
				}
				case 19u:
					c3 = c;
					num = ((int)num2 * -469458949) ^ -19710240;
					continue;
				case 18u:
					num = (int)((num2 * 1342156772) ^ 0x138F1248);
					continue;
				case 17u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -1620162278;
						num5 = -1620162278;
					}
					else
					{
						num = -274394396;
						num5 = -274394396;
					}
					continue;
				}
				case 16u:
					c2 = c3;
					num = ((int)num2 * -684564673) ^ 0x3438C819;
					continue;
				case 15u:
					num = -315935717;
					continue;
				case 14u:
					num = ((int)num2 * -1723000425) ^ -1337458398;
					continue;
				case 13u:
					num = ((int)num2 * -651754732) ^ -1007788456;
					continue;
				case 12u:
					switch (c2)
					{
					case '\v':
						break;
					case '\b':
						goto IL_001e;
					case '\t':
						goto IL_0099;
					case '\f':
						goto IL_00af;
					case '\r':
						goto IL_00d8;
					default:
						goto IL_01c6;
					case '\n':
						goto IL_01d9;
					}
					goto case 33u;
				case 2u:
					goto IL_01d9;
				case 11u:
					num3 = 0;
					num = ((int)num2 * -825950407) ^ -2068272602;
					continue;
				case 10u:
				{
					int num4;
					if (c2 == '"')
					{
						num = -2051995463;
						num4 = -2051995463;
					}
					else
					{
						num = -876053556;
						num4 = -876053556;
					}
					continue;
				}
				case 9u:
					text = "";
					string_ = aText;
					num = ((int)num2 * -1351822948) ^ -1701876440;
					continue;
				case 8u:
					num = ((int)num2 * -1406621441) ^ -1615082558;
					continue;
				case 7u:
					num = ((int)num2 * -2112710552) ^ -644163439;
					continue;
				case 6u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1822884138;
					continue;
				case 5u:
					num = ((int)num2 * -1170083147) ^ 0x7269947F;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -288635122) ^ 0x34B97B1A;
					continue;
				case 3u:
					num = ((int)num2 * -348906851) ^ -709405939;
					continue;
				case 1u:
					c = JSONNode.smethod_2(string_, num3);
					num = -740175027;
					continue;
				case 0u:
					num = (int)(num2 * 1158250049) ^ -2009759738;
					continue;
				case 21u:
					break;
				default:
					{
						return result;
					}
					IL_01d9:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1330617001;
					continue;
					IL_01c6:
					num = ((int)num2 * -919779827) ^ -1807776466;
					continue;
					IL_001e:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1644549173;
					continue;
					IL_00d8:
					text = JSONNode.smethod_3(text, "\\r");
					num = -10669544;
					continue;
					IL_00af:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1155125126;
					continue;
					IL_0099:
					text = JSONNode.smethod_3(text, "\\t");
					num = -162654340;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		bool flag16 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		string text2 = default(string);
		bool flag3 = default(bool);
		int num13 = default(int);
		bool flag5 = default(bool);
		char c2 = default(char);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		char c = default(char);
		bool flag7 = default(bool);
		char c5 = default(char);
		char c4 = default(char);
		bool flag9 = default(bool);
		char c3 = default(char);
		bool flag10 = default(bool);
		bool flag11 = default(bool);
		bool flag15 = default(bool);
		bool flag12 = default(bool);
		bool flag17 = default(bool);
		bool flag14 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1013050169;
			while (true)
			{
				uint num2;
				int num8;
				int num49;
				string s;
				switch ((num2 = (uint)num ^ 0xB110E194u) % 158u)
				{
				case 157u:
				{
					int num45;
					int num46;
					if (!flag16)
					{
						num45 = 681432735;
						num46 = 681432735;
					}
					else
					{
						num45 = 1186672991;
						num46 = 1186672991;
					}
					num = num45 ^ ((int)num2 * -987178833);
					continue;
				}
				case 156u:
					num = ((int)num2 * -1684121506) ^ 0x34922A3C;
					continue;
				case 155u:
					jSONNode = null;
					num = (int)((num2 * 232747202) ^ 0x3BE6B89A);
					continue;
				case 154u:
					text = "";
					text2 = "";
					num = -2140651078;
					continue;
				case 153u:
				{
					int num5;
					int num6;
					if (flag3)
					{
						num5 = 996405802;
						num6 = 996405802;
					}
					else
					{
						num5 = 1556961479;
						num6 = 1556961479;
					}
					num = num5 ^ ((int)num2 * -1839988762);
					continue;
				}
				case 152u:
					num13 += 4;
					num = ((int)num2 * -770349186) ^ -790458281;
					continue;
				case 151u:
				{
					int num11;
					int num12;
					if (!flag5)
					{
						num11 = 473255652;
						num12 = 473255652;
					}
					else
					{
						num11 = 1966697128;
						num12 = 1966697128;
					}
					num = num11 ^ (int)(num2 * 1293406381);
					continue;
				}
				case 150u:
					num = ((int)num2 * -862118148) ^ -2140098428;
					continue;
				case 149u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = ((int)num2 * -1515601272) ^ -885931946;
					continue;
				case 148u:
				{
					int num57;
					if (c2 != 'f')
					{
						num = -712227953;
						num57 = -712227953;
					}
					else
					{
						num = -499943908;
						num57 = -499943908;
					}
					continue;
				}
				case 147u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = ((int)num2 * -1519299321) ^ -328466175;
					continue;
				case 146u:
					flag8 = flag2;
					num = -974661395;
					continue;
				case 145u:
					num = -400353830;
					continue;
				case 144u:
				{
					int num34;
					int num35;
					if (stack.Count > 0)
					{
						num34 = 1074089287;
						num35 = 1074089287;
					}
					else
					{
						num34 = 1248334903;
						num35 = 1248334903;
					}
					num = num34 ^ ((int)num2 * -548225317);
					continue;
				}
				case 143u:
					flag13 = jSONNode is JSONArray;
					num = (int)((num2 * 1531346689) ^ 0x3A6A6AB5);
					continue;
				case 142u:
					flag6 = num13 < JSONNode.smethod_4(aJSON);
					num = -1600667294;
					continue;
				case 141u:
					num = (int)((num2 * 763664631) ^ 0x5C877D62);
					continue;
				case 3u:
				case 13u:
				case 69u:
				case 84u:
				case 140u:
					num13++;
					num = -1892512228;
					continue;
				case 139u:
					num = (int)((num2 * 1668643016) ^ 0x74938E04);
					continue;
				case 138u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 492405001) ^ -1619308656;
					continue;
				case 137u:
					num = ((int)num2 * -963239338) ^ -661610637;
					continue;
				case 136u:
					num = (int)(num2 * 1538512250) ^ -973522000;
					continue;
				case 135u:
					text2 = "";
					jSONNode = stack.Peek();
					num = (int)((num2 * 1501246680) ^ 0x5FA1AA68);
					continue;
				case 134u:
				{
					int num14;
					int num15;
					if (!flag6)
					{
						num14 = -1582331251;
						num15 = -1582331251;
					}
					else
					{
						num14 = -1075290278;
						num15 = -1075290278;
					}
					num = num14 ^ (int)(num2 * 433025089);
					continue;
				}
				case 133u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1395054503) ^ 0x2E9DCFB5);
					continue;
				case 132u:
				{
					int num61;
					int num62;
					if ((uint)c > 32u)
					{
						num61 = -1723093218;
						num62 = -1723093218;
					}
					else
					{
						num61 = -436799938;
						num62 = -436799938;
					}
					num = num61 ^ ((int)num2 * -844660114);
					continue;
				}
				case 131u:
					stack = new Stack<JSONNode>();
					num = (int)((num2 * 438191543) ^ 0x24CE6FEE);
					continue;
				case 130u:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -846196111;
					continue;
				case 129u:
					flag7 = jSONNode != null;
					num = ((int)num2 * -642923648) ^ 0x2B05ACAF;
					continue;
				case 128u:
					num = -1712221549;
					continue;
				case 127u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1494293904) ^ 0x7651EC46;
					continue;
				case 126u:
				{
					stack.Pop();
					int num54;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -188775731;
						num54 = -188775731;
					}
					else
					{
						num = -76902080;
						num54 = -76902080;
					}
					continue;
				}
				case 125u:
					c5 = JSONNode.smethod_2(aJSON, num13);
					c4 = c5;
					num = (int)(num2 * 54300624) ^ -666177267;
					continue;
				case 124u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -1468469511;
					continue;
				case 123u:
					num = (int)((num2 * 1834851588) ^ 0x40A82B38);
					continue;
				case 122u:
					stack.Push(new JSONArray());
					num = -1994482809;
					continue;
				case 121u:
					goto IL_03eb;
				case 120u:
				{
					int num42;
					int num43;
					if (flag9)
					{
						num42 = 156234915;
						num43 = 156234915;
					}
					else
					{
						num42 = 936085864;
						num43 = 936085864;
					}
					num = num42 ^ ((int)num2 * -652538123);
					continue;
				}
				case 119u:
					num = ((int)num2 * -1503862017) ^ -1610225124;
					continue;
				case 118u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 1591849450) ^ -1075234773;
					continue;
				case 117u:
					num = (int)(num2 * 1183603884) ^ -841371803;
					continue;
				case 116u:
					num = ((int)num2 * -1103701229) ^ -226511276;
					continue;
				case 115u:
				{
					c = c3;
					int num36;
					int num37;
					if ((uint)c <= 44u)
					{
						num36 = 1772336624;
						num37 = 1772336624;
					}
					else
					{
						num36 = 1829964886;
						num37 = 1829964886;
					}
					num = num36 ^ (int)(num2 * 1524018274);
					continue;
				}
				case 114u:
				{
					int num29;
					int num30;
					if (!flag13)
					{
						num29 = -1143863301;
						num30 = -1143863301;
					}
					else
					{
						num29 = -152585233;
						num30 = -152585233;
					}
					num = num29 ^ ((int)num2 * -1056236959);
					continue;
				}
				case 113u:
					num = -1288175271;
					continue;
				case 111u:
				{
					int num23;
					int num24;
					if (flag10)
					{
						num23 = -854012117;
						num24 = -854012117;
					}
					else
					{
						num23 = -1791157255;
						num24 = -1791157255;
					}
					num = num23 ^ (int)(num2 * 2050490571);
					continue;
				}
				case 110u:
					num13 = 0;
					text2 = "";
					text = "";
					flag2 = false;
					num = ((int)num2 * -1560776687) ^ -184687029;
					continue;
				case 109u:
				{
					int num18;
					int num19;
					if (flag8)
					{
						num18 = -1528042964;
						num19 = -1528042964;
					}
					else
					{
						num18 = -1798304377;
						num19 = -1798304377;
					}
					num = num18 ^ (int)(num2 * 24020372);
					continue;
				}
				case 108u:
					switch (c)
					{
					case '[':
						goto IL_0582;
					case '\\':
						goto IL_0590;
					case ']':
						goto IL_059e;
					}
					num = -853621753;
					continue;
				case 49u:
					goto IL_0582;
				case 78u:
					goto IL_0590;
				case 9u:
					goto IL_059e;
				case 107u:
					num = (int)(num2 * 1913711736) ^ -1735013223;
					continue;
				case 106u:
					num = ((int)num2 * -2011704383) ^ 0x1EBD5576;
					continue;
				case 105u:
				{
					int num63;
					if (c != '{')
					{
						num = -1716250036;
						num63 = -1716250036;
					}
					else
					{
						num = -241035354;
						num63 = -241035354;
					}
					continue;
				}
				case 104u:
				{
					int num60;
					if (c != '"')
					{
						num = -27186913;
						num60 = -27186913;
					}
					else
					{
						num = -1611339636;
						num60 = -1611339636;
					}
					continue;
				}
				case 103u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 587720518) ^ 0x1EFCE4D);
					continue;
				case 102u:
				{
					int num58;
					int num59;
					if (flag11)
					{
						num58 = 489963865;
						num59 = 489963865;
					}
					else
					{
						num58 = 1946960842;
						num59 = 1946960842;
					}
					num = num58 ^ ((int)num2 * -565830568);
					continue;
				}
				case 101u:
					num = ((int)num2 * -1612190164) ^ 0x2EA1B48B;
					continue;
				case 100u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -1173153625;
					continue;
				case 99u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = ((int)num2 * -1107370651) ^ 0x346BB4A5;
					continue;
				case 98u:
				{
					int num55;
					int num56;
					if (flag15)
					{
						num55 = -2130910921;
						num56 = -2130910921;
					}
					else
					{
						num55 = -1490878904;
						num56 = -1490878904;
					}
					num = num55 ^ ((int)num2 * -2013792667);
					continue;
				}
				case 97u:
					num = ((int)num2 * -817953055) ^ -23328417;
					continue;
				case 96u:
					num = ((int)num2 * -466017955) ^ -2120854948;
					continue;
				case 94u:
					flag2 = !flag2;
					num = -1203783396;
					continue;
				case 93u:
					num = (int)((num2 * 1586394388) ^ 0x64BFB730);
					continue;
				case 92u:
					num = -1312514473;
					continue;
				case 91u:
					num = (int)((num2 * 1043900061) ^ 0x55317B80);
					continue;
				case 90u:
					goto IL_074e;
				case 89u:
					flag12 = jSONNode != null;
					num = (int)((num2 * 893575359) ^ 0x661D1DC1);
					continue;
				case 88u:
					goto IL_079d;
				case 87u:
					switch (c2)
					{
					case 'r':
						break;
					case 'u':
						goto IL_074e;
					default:
						goto IL_07d8;
					case 's':
						goto IL_07e2;
					case 't':
						goto IL_07fa;
					}
					goto case 130u;
				case 33u:
					goto IL_07e2;
				case 74u:
					goto IL_07fa;
				case 86u:
				{
					int num52;
					int num53;
					if (c != ':')
					{
						num52 = -644566758;
						num53 = -644566758;
					}
					else
					{
						num52 = -2119656554;
						num53 = -2119656554;
					}
					num = num52 ^ ((int)num2 * -966136224);
					continue;
				}
				case 85u:
					flag17 = stack.Count == 0;
					num = -415381100;
					continue;
				case 83u:
					num = (int)((num2 * 351028878) ^ 0x17A2A9A5);
					continue;
				case 82u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1316492084) ^ 0x5B9743A3);
					continue;
				case 81u:
				{
					int num50;
					int num51;
					if (jSONNode is JSONArray)
					{
						num50 = -1242127040;
						num51 = -1242127040;
					}
					else
					{
						num50 = -879190571;
						num51 = -879190571;
					}
					num = num50 ^ (int)(num2 * 19427000);
					continue;
				}
				case 80u:
				{
					int num47;
					int num48;
					if (!flag17)
					{
						num47 = 1999977326;
						num48 = 1999977326;
					}
					else
					{
						num47 = 246176745;
						num48 = 246176745;
					}
					num = num47 ^ (int)(num2 * 380846815);
					continue;
				}
				case 79u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = ((int)num2 * -859056694) ^ 0x1DA5AFDE;
					continue;
				case 77u:
					num = ((int)num2 * -1782831915) ^ -1749674707;
					continue;
				case 76u:
				{
					int num44;
					if (c == ',')
					{
						num = -1949950196;
						num44 = -1949950196;
					}
					else
					{
						num = -748199383;
						num44 = -748199383;
					}
					continue;
				}
				case 75u:
					num = ((int)num2 * -1136253947) ^ 0x69CF5093;
					continue;
				case 73u:
				{
					int num40;
					int num41;
					if (flag14)
					{
						num40 = 783979997;
						num41 = 783979997;
					}
					else
					{
						num40 = 167603484;
						num41 = 167603484;
					}
					num = num40 ^ (int)(num2 * 1676203615);
					continue;
				}
				case 72u:
					flag4 = JSONNode.smethod_6(text, "");
					num = -619395525;
					continue;
				case 71u:
					text = "";
					num = -1492531211;
					continue;
				case 70u:
					num = ((int)num2 * -1297036682) ^ -1278232310;
					continue;
				case 68u:
					flag16 = jSONNode is JSONArray;
					num = ((int)num2 * -1537016401) ^ -1344600405;
					continue;
				case 67u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = (int)(num2 * 1265566719) ^ -70353060;
					continue;
				case 66u:
				{
					int num39;
					if (c == ' ')
					{
						num = -1873389065;
						num39 = -1873389065;
					}
					else
					{
						num = -84148423;
						num39 = -84148423;
					}
					continue;
				}
				case 65u:
					c3 = JSONNode.smethod_2(aJSON, num13);
					num = (int)(num2 * 1188151712) ^ -1458831005;
					continue;
				case 64u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\t':
						goto IL_03eb;
					case '\v':
					case '\f':
						goto IL_079d;
					default:
						goto IL_0a56;
					}
					goto case 3u;
				case 63u:
					num = (int)((num2 * 1122607028) ^ 0x1BDEEE73);
					continue;
				case 62u:
					num = (int)(num2 * 2083544239) ^ -1000614901;
					continue;
				case 61u:
					text = "";
					text2 = "";
					jSONNode = stack.Peek();
					num = -453719279;
					continue;
				case 60u:
					num = ((int)num2 * -434037251) ^ 0x2775C474;
					continue;
				case 59u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -41842047) ^ 0x28766058;
					continue;
				case 58u:
					num = (int)(num2 * 1315451391) ^ -859839794;
					continue;
				case 57u:
					num = ((int)num2 * -624349178) ^ -604644588;
					continue;
				case 56u:
					flag10 = jSONNode is JSONArray;
					num = ((int)num2 * -1242618381) ^ 0x4C5448E3;
					continue;
				case 55u:
					c2 = c4;
					num = ((int)num2 * -1144262072) ^ -899901402;
					continue;
				case 54u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1944432976) ^ 0x5C935228;
					continue;
				case 53u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 1040283295) ^ -1312975003;
					continue;
				case 52u:
					flag5 = JSONNode.smethod_6(text, "");
					num = -1089949659;
					continue;
				case 51u:
					num = ((int)num2 * -1616829238) ^ 0x228AB716;
					continue;
				case 50u:
					flag15 = flag2;
					num = -1700818402;
					continue;
				case 48u:
					num = ((int)num2 * -1985273749) ^ -762220373;
					continue;
				case 47u:
					num = (int)(num2 * 150582305) ^ -1147910599;
					continue;
				case 46u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = (int)(num2 * 1456142328) ^ -992563460;
					continue;
				case 45u:
					flag3 = JSONNode.smethod_6(text, "");
					num = -826665507;
					continue;
				case 44u:
					num = (int)(num2 * 1537111003) ^ -166523440;
					continue;
				case 43u:
					stack.Push(new JSONClass());
					num = -1448250989;
					continue;
				case 42u:
				{
					int num38;
					if (!flag2)
					{
						num = -1621223080;
						num38 = -1621223080;
					}
					else
					{
						num = -1955678121;
						num38 = -1955678121;
					}
					continue;
				}
				case 41u:
				{
					int num32;
					int num33;
					if (c2 == 'b')
					{
						num32 = 201853697;
						num33 = 201853697;
					}
					else
					{
						num32 = 393627523;
						num33 = 393627523;
					}
					num = num32 ^ ((int)num2 * -130393971);
					continue;
				}
				case 40u:
					text = text2;
					text2 = "";
					num = -997572738;
					continue;
				case 39u:
					num = (int)(num2 * 534107558) ^ -1709128635;
					continue;
				case 38u:
				{
					int num31;
					if (c != '}')
					{
						num = -2008521707;
						num31 = -2008521707;
					}
					else
					{
						num = -427104669;
						num31 = -427104669;
					}
					continue;
				}
				case 37u:
					flag14 = flag2;
					num = ((int)num2 * -482848087) ^ -1884212496;
					continue;
				case 36u:
				{
					int num27;
					int num28;
					if (flag12)
					{
						num27 = 149164381;
						num28 = 149164381;
					}
					else
					{
						num27 = 2036722365;
						num28 = 2036722365;
					}
					num = num27 ^ (int)(num2 * 1618278459);
					continue;
				}
				case 35u:
					num = ((int)num2 * -259850060) ^ -1785311299;
					continue;
				case 34u:
					num = (int)(num2 * 842506214) ^ -570072158;
					continue;
				case 32u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1166852575) ^ -1268258982;
					continue;
				case 31u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1218723095) ^ 0x364AD4DA);
					continue;
				case 30u:
					num = -76902080;
					continue;
				case 29u:
					num = (int)((num2 * 309953005) ^ 0x5F822B2);
					continue;
				case 28u:
					num = ((int)num2 * -1904784338) ^ 0x30BF3780;
					continue;
				case 27u:
					num = ((int)num2 * -35145264) ^ 0x7596F474;
					continue;
				case 25u:
					num = (int)(num2 * 1445442627) ^ -1191603541;
					continue;
				case 24u:
					flag11 = JSONNode.smethod_6(text2, "");
					num = -1760538350;
					continue;
				case 23u:
					num = (int)((num2 * 1139967974) ^ 0x501BAD05);
					continue;
				case 22u:
				{
					int num25;
					int num26;
					if ((uint)c2 > 102u)
					{
						num25 = -1698042908;
						num26 = -1698042908;
					}
					else
					{
						num25 = -1188376155;
						num26 = -1188376155;
					}
					num = num25 ^ ((int)num2 * -791114972);
					continue;
				}
				case 21u:
					num = ((int)num2 * -1945336666) ^ -392118387;
					continue;
				case 20u:
				{
					int num22;
					if (c2 == 'n')
					{
						num = -573791145;
						num22 = -573791145;
					}
					else
					{
						num = -253286737;
						num22 = -253286737;
					}
					continue;
				}
				case 19u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -713907063;
					continue;
				case 18u:
				{
					int num20;
					int num21;
					if (!flag)
					{
						num20 = 1128156370;
						num21 = 1128156370;
					}
					else
					{
						num20 = 1659325367;
						num21 = 1659325367;
					}
					num = num20 ^ ((int)num2 * -903632127);
					continue;
				}
				case 17u:
					num = -1268730027;
					continue;
				case 16u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -999457202) ^ 0x19C89943;
					continue;
				case 15u:
					result = jSONNode;
					num = -617358914;
					continue;
				case 14u:
					text2 = "";
					num = (int)(num2 * 532484530) ^ -713236344;
					continue;
				case 11u:
				{
					int num16;
					int num17;
					if (flag7)
					{
						num16 = 633567606;
						num17 = 633567606;
					}
					else
					{
						num16 = 1359617217;
						num17 = 1359617217;
					}
					num = num16 ^ ((int)num2 * -501831838);
					continue;
				}
				case 10u:
					num = (int)((num2 * 540969638) ^ 0x7F25C56C);
					continue;
				case 8u:
					num = (int)(num2 * 1894249249) ^ -244508194;
					continue;
				case 7u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = -452221351;
						num10 = -452221351;
					}
					else
					{
						num9 = -1769992336;
						num10 = -1769992336;
					}
					num = num9 ^ (int)(num2 * 711886330);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1784961656) ^ -1527378330;
					continue;
				case 5u:
					num = ((int)num2 * -1454820646) ^ 0x3E59E165;
					continue;
				case 4u:
				{
					int num7;
					if ((uint)c > 93u)
					{
						num = -431462329;
						num7 = -431462329;
					}
					else
					{
						num = -72035040;
						num7 = -72035040;
					}
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = 2086052661;
						num4 = 2086052661;
					}
					else
					{
						num3 = 797104265;
						num4 = 797104265;
					}
					num = num3 ^ (int)(num2 * 26465462);
					continue;
				}
				case 1u:
					flag = JSONNode.smethod_6(text, "");
					num = -993274656;
					continue;
				case 0u:
					text = "";
					num = -1639518402;
					continue;
				case 112u:
					break;
				case 26u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 95u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_059e:
					if (flag2)
					{
						num = -1554590119;
						num8 = -1554590119;
					}
					else
					{
						num = -1683832899;
						num8 = -1683832899;
					}
					continue;
					IL_0590:
					num13++;
					num = -1999913282;
					continue;
					IL_0582:
					flag9 = flag2;
					num = -773828570;
					continue;
					IL_0a56:
					num = (int)((num2 * 1859361196) ^ 0x742789EA);
					continue;
					IL_03eb:
					if (!flag2)
					{
						num = -506142120;
						num49 = -506142120;
					}
					else
					{
						num = -1407318995;
						num49 = -1407318995;
					}
					continue;
					IL_07fa:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -1336523797;
					continue;
					IL_07e2:
					text2 = JSONNode.smethod_3(text2, c5.ToString());
					num = -497677333;
					continue;
					IL_07d8:
					num = -464178175;
					continue;
					IL_079d:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num13).ToString());
					num = -742585578;
					continue;
					IL_074e:
					s = JSONNode.smethod_8(aJSON, num13 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = -265300780;
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
			int num = 1256790934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78DCD8E0u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -2005737616) ^ 0xC6F5314;
					continue;
				case 3u:
					Serialize(aWriter);
					num = (int)((num2 * 1387946911) ^ 0xAEBB83D);
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = (int)((num2 * 284931896) ^ 0xC7E317A);
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
			while (true)
			{
				int num = 137247022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40F610E8u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 119650086) ^ 0x47DCC17);
						continue;
					case 2u:
						SaveToStream(fileStream);
						num = (int)(num2 * 1915202009) ^ -1362317275;
						continue;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00a2:
					int num3 = 2045021084;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x40F610E8u) % 3u)
						{
						case 1u:
							goto IL_0072;
						default:
							goto end_IL_0085;
						case 0u:
							break;
						case 2u:
							goto end_IL_0085;
						}
						goto IL_00a2;
						IL_0072:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = ((int)num2 * -43547796) ^ -137321245;
						continue;
						end_IL_0085:
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
				int num = -1167520227;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB8CA50BFu) % 5u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 255269302) ^ -387435462;
						continue;
					case 2u:
						num = ((int)num2 * -591404825) ^ -1232293150;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -20335633) ^ 0x3FC5CC3E;
						continue;
					case 0u:
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
					IL_00b9:
					int num3 = -799164863;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xB8CA50BFu) % 3u)
						{
						case 1u:
							goto IL_0089;
						default:
							goto end_IL_009c;
						case 0u:
							break;
						case 2u:
							goto end_IL_009c;
						}
						goto IL_00b9;
						IL_0089:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -2011929984) ^ -222897241;
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
		JSONBinaryTag jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
		JSONNode result = default(JSONNode);
		string aKey = default(string);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONClass jSONClass = default(JSONClass);
		JSONArray jSONArray = default(JSONArray);
		int num5 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -743900059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB67CAA29u) % 38u)
				{
				case 37u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -2010705595;
					continue;
				case 36u:
					goto IL_0023;
				case 35u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)(num2 * 846826337) ^ -642751791;
					continue;
				case 34u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.BoolValue:
						break;
					case JSONBinaryTag.IntValue:
						goto IL_0023;
					default:
						goto IL_006c;
					case JSONBinaryTag.Array:
						goto IL_007f;
					case JSONBinaryTag.Class:
						goto IL_0089;
					case JSONBinaryTag.Value:
						goto IL_0093;
					case JSONBinaryTag.DoubleValue:
						goto IL_00aa;
					case JSONBinaryTag.FloatValue:
						goto IL_00c1;
					}
					goto case 37u;
				case 33u:
					goto IL_007f;
				case 18u:
					goto IL_0089;
				case 7u:
					goto IL_0093;
				case 27u:
					goto IL_00aa;
				case 16u:
					goto IL_00c1;
				case 32u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 327288326) ^ -692863252;
					continue;
				case 31u:
					num = ((int)num2 * -310666068) ^ -1133221915;
					continue;
				case 30u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1458308612) ^ 0x79C93897;
					continue;
				case 29u:
					result = jSONClass;
					num = ((int)num2 * -853945143) ^ -1551233039;
					continue;
				case 28u:
					jSONArray.Add(Deserialize(aReader));
					num5++;
					num = -583373476;
					continue;
				case 26u:
					num = ((int)num2 * -490782972) ^ -477058776;
					continue;
				case 25u:
					num = ((int)num2 * -1391487440) ^ -1707291207;
					continue;
				case 24u:
					num7++;
					num = (int)(num2 * 112089158) ^ -1547024731;
					continue;
				case 21u:
					num8 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 912605561) ^ -479154949;
					continue;
				case 20u:
					num = ((int)num2 * -647657297) ^ 0x8501144;
					continue;
				case 19u:
					result = jSONArray;
					num = (int)(num2 * 546970549) ^ -1534726312;
					continue;
				case 17u:
					num7 = 0;
					num = ((int)num2 * -1741063057) ^ 0x6514D62D;
					continue;
				case 15u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 363989817) ^ 0x6946940B);
					continue;
				case 14u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -577296304) ^ 0x5F1C2BD;
					continue;
				case 13u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 376734213) ^ -1600231786;
					continue;
				}
				case 11u:
					num = -559502616;
					continue;
				case 10u:
					num = (int)(num2 * 1061496909) ^ -1441351316;
					continue;
				case 9u:
					num = (int)(num2 * 214810977) ^ -1872620427;
					continue;
				case 8u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 940250218) ^ 0x5BB72B4E);
					continue;
				case 6u:
				{
					int num9;
					if (num7 >= num8)
					{
						num = -197568272;
						num9 = -197568272;
					}
					else
					{
						num = -1568761358;
						num9 = -1568761358;
					}
					continue;
				}
				case 5u:
					flag = num5 < num6;
					num = -1971710197;
					continue;
				case 4u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 1818606402) ^ 0x28702739);
					continue;
				case 3u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -972811897) ^ -511375186;
					continue;
				case 2u:
					num = (int)((num2 * 402317186) ^ 0x3ABE8238);
					continue;
				case 1u:
					num5 = 0;
					num = (int)((num2 * 469788889) ^ 0x5C3E1B54);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1717790780;
						num4 = 1717790780;
					}
					else
					{
						num3 = 1446717831;
						num4 = 1446717831;
					}
					num = num3 ^ ((int)num2 * -350469938);
					continue;
				}
				case 12u:
					break;
				case 22u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_006c:
					num = ((int)num2 * -302875778) ^ -1528573156;
					continue;
					IL_007f:
					num = -449258328;
					continue;
					IL_0023:
					num = -902688061;
					continue;
					IL_00c1:
					num = -937609163;
					continue;
					IL_00aa:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -36012244;
					continue;
					IL_0093:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -776835184;
					continue;
					IL_0089:
					num = -2115435856;
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
					int num = -1937000534;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xDF1DF427u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -1747355452) ^ 0x426A2D73;
							continue;
						case 0u:
							num = ((int)num2 * -338067809) ^ 0x44B9EAA8;
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
					int num = -1715120732;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x88481EA5u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -370669829) ^ -1829351082;
							continue;
						case 0u:
							num = ((int)num2 * -839226936) ^ 0x3662FA43;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = JSONNode.smethod_29(byte_);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1404892599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6447F5BBu) % 5u)
				{
				case 3u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -320243552) ^ -1456958004;
					continue;
				case 1u:
					num = (int)((num2 * 1960690841) ^ 0x684F659B);
					continue;
				case 0u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1774197481) ^ -335292637;
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
