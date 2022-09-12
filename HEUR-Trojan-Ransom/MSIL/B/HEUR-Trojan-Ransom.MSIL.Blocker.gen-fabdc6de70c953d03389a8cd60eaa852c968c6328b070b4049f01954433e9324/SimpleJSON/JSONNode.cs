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
				int num = 959420692;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FD1F323u) % 3u)
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
					num = ((int)num2 * -2065518423) ^ -2103830887;
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
				int num = 664559804;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42535931u) % 3u)
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
					num = (int)((num2 * 1175844294) ^ 0x5A7BC39D);
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
				int num = 1523351695;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5313C478u) % 3u)
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
					num = ((int)num2 * -1109799126) ^ -1947200656;
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
				int num = 16048356;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x713924B2u) % 4u)
					{
					case 2u:
						result = 0;
						num = (int)((num2 * 191442760) ^ 0x772EFA3);
						continue;
					case 1u:
						num = ((int)num2 * -1089151284) ^ -1969753915;
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
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			while (true)
			{
				int num = 593236492;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5672AB10u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = (int)((num2 * 419370012) ^ 0xE3E62F9);
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
			bool flag = default(bool);
			int result2 = default(int);
			while (true)
			{
				int num = 392080262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x430F7BF7u) % 8u)
					{
					case 7u:
						result = 0;
						num = 215415324;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2044869914;
							num4 = -2044869914;
						}
						else
						{
							num3 = -829141980;
							num4 = -829141980;
						}
						num = num3 ^ ((int)num2 * -1167750063);
						continue;
					}
					case 5u:
						result = result2;
						num = ((int)num2 * -569301023) ^ 0x4212B056;
						continue;
					case 4u:
						num = ((int)num2 * -128385761) ^ -114597648;
						continue;
					case 1u:
						result2 = 0;
						num = (int)(num2 * 542838075) ^ -1596758628;
						continue;
					case 0u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -1307381222) ^ -1072555759;
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
			Value = value.ToString();
		}
	}

	public virtual float AsFloat
	{
		get
		{
			bool flag = default(bool);
			float result = default(float);
			float result2 = default(float);
			while (true)
			{
				int num = -373457474;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81127764u) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -463757031;
							num4 = -463757031;
						}
						else
						{
							num3 = -1605243073;
							num4 = -1605243073;
						}
						num = num3 ^ ((int)num2 * -2053544001);
						continue;
					}
					case 7u:
						num = ((int)num2 * -44886218) ^ -1493070408;
						continue;
					case 6u:
						result = result2;
						num = ((int)num2 * -580037464) ^ 0x542D6B62;
						continue;
					case 4u:
						result = 0f;
						num = -90889448;
						continue;
					case 3u:
						result2 = 0f;
						num = ((int)num2 * -1958438032) ^ -838722485;
						continue;
					case 1u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)(num2 * 1434766693) ^ -2145866497;
						continue;
					case 0u:
						num = ((int)num2 * -2106781747) ^ -2131739338;
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
				int num = -1564147151;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2BD00C7u) % 3u)
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
					num = (int)((num2 * 1082210180) ^ 0x1B07DAC3);
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
			while (true)
			{
				int num = 1793123132;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x44845BA1u) % 6u)
					{
					case 4u:
						result2 = 0.0;
						num = 1468442114;
						continue;
					case 2u:
						num = (int)(num2 * 1113269465) ^ -1767530744;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (double.TryParse(Value, out result))
						{
							num3 = -1371849016;
							num4 = -1371849016;
						}
						else
						{
							num3 = -624343610;
							num4 = -624343610;
						}
						num = num3 ^ (int)(num2 * 671628943);
						continue;
					}
					case 0u:
						result2 = result;
						num = (int)(num2 * 1886911787) ^ -1833796059;
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
				int num = 1815877369;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22E19669u) % 3u)
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
					num = (int)(num2 * 8979062) ^ -1713115357;
				}
			}
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
				int num = -2108462139;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA464DBBu) % 8u)
					{
					case 7u:
						num = (int)((num2 * 398820183) ^ 0x697D1930);
						continue;
					case 6u:
						result2 = false;
						num = ((int)num2 * -944852780) ^ -12875430;
						continue;
					case 5u:
						result = result2;
						num = (int)((num2 * 244404365) ^ 0x2B5C3F31);
						continue;
					case 4u:
						result = !JSONNode.smethod_1(Value);
						num = -1874670756;
						continue;
					case 3u:
						num = ((int)num2 * -1336965058) ^ 0x6A801E0B;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = 1253121315;
							num4 = 1253121315;
						}
						else
						{
							num3 = 1538177410;
							num4 = 1538177410;
						}
						num = num3 ^ (int)(num2 * 1044650100);
						continue;
					}
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
			Value = (value ? "true" : "false");
			while (true)
			{
				int num = 1165123948;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x47D84BF1u) % 3u)
					{
					case 2u:
						goto IL_0017;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0017:
					num = (int)((num2 * 768993655) ^ 0x122D0DA5);
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
				int num = -1917026117;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81FEAA6Cu) % 3u)
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
					num = (int)(num2 * 879169748) ^ -231163045;
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
				int num = 788628130;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E6C5788u) % 4u)
					{
					case 2u:
						result = this as JSONClass;
						num = (int)((num2 * 329723985) ^ 0x5FC26423);
						continue;
					case 1u:
						num = ((int)num2 * -1237430085) ^ -1002885548;
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
			int num = -266650855;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1C37F82u) % 4u)
				{
				case 3u:
					Add("", aItem);
					num = ((int)num2 * -1516941604) ^ -1394494684;
					continue;
				case 2u:
					num = (int)(num2 * 1938204635) ^ -164253171;
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

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1528331424;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBAA6B46u) % 4u)
				{
				case 2u:
					result = null;
					num = (int)(num2 * 1690774654) ^ -253248297;
					continue;
				case 1u:
					num = ((int)num2 * -1745553614) ^ -143288041;
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
		return null;
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1669111175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA20741CCu) % 4u)
				{
				case 1u:
					result = aNode;
					num = (int)(num2 * 1658858664) ^ -1480896740;
					continue;
				case 0u:
					num = ((int)num2 * -1520342469) ^ -873236782;
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
		string result = default(string);
		while (true)
		{
			int num = -883590522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89A67E37u) % 4u)
				{
				case 1u:
					result = "JSONNode";
					num = (int)((num2 * 1898846429) ^ 0x51390AFA);
					continue;
				case 0u:
					num = (int)(num2 * 176041088) ^ -1808836655;
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

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1171978983;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9553D580u) % 3u)
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
				num = ((int)num2 * -1034183204) ^ 0x461AB9AF;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		return new JSONData(s);
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
		int num = 975511542;
		goto IL_0011;
		IL_000c:
		num = 508890069;
		goto IL_0011;
		IL_0011:
		switch ((uint)(num ^ 0x7B95FB1C) % 3u)
		{
		case 0u:
			break;
		case 2u:
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
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1751443464;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x58BF7EA9u) % 8u)
				{
				case 7u:
					result = true;
					num = (int)((num2 * 810215922) ^ 0x320C496D);
					continue;
				case 5u:
					num5 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0020;
				case 4u:
					result = (object)a == b;
					num = 1496146530;
					continue;
				case 3u:
					num = ((int)num2 * -996752095) ^ -1879543032;
					continue;
				case 1u:
					if (b == null)
					{
						num = ((int)num2 * -1531115781) ^ 0x2AB1E24F;
						continue;
					}
					num5 = 0;
					goto IL_0020;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1883472362;
						num4 = -1883472362;
					}
					else
					{
						num3 = -251845259;
						num4 = -251845259;
					}
					num = num3 ^ ((int)num2 * -1680954852);
					continue;
				}
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0020:
					flag = (byte)num5 != 0;
					num = 953998033;
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
			int num = -101113279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC27B28Bu) % 4u)
				{
				case 2u:
					result = !(a == b);
					num = ((int)num2 * -757602516) ^ 0x4D6DD166;
					continue;
				case 1u:
					num = (int)(num2 * 827481750) ^ -425725630;
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

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1199240996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79BC2B0Fu) % 3u)
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
				num = (int)((num2 * 2113718093) ^ 0x76B457E5);
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = -1160593963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE254BCAu) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = (int)(num2 * 1587422293) ^ -2044788327;
					continue;
				case 0u:
					num = (int)(num2 * 559244461) ^ -2014132629;
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

	internal static string Escape(string aText)
	{
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		string text = default(string);
		char c = default(char);
		char c3 = default(char);
		string result = default(string);
		while (true)
		{
			int num = 168646079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x651E3C5Cu) % 33u)
				{
				case 31u:
				{
					int num6;
					if (c2 != '"')
					{
						num = 575128776;
						num6 = 575128776;
					}
					else
					{
						num = 848621439;
						num6 = 848621439;
					}
					continue;
				}
				case 30u:
				{
					int num5;
					if (c2 == '\\')
					{
						num = 1296341256;
						num5 = 1296341256;
					}
					else
					{
						num = 1096132266;
						num5 = 1096132266;
					}
					continue;
				}
				case 29u:
					num = (int)((num2 * 442349323) ^ 0x1432292B);
					continue;
				case 28u:
					string_ = aText;
					num = ((int)num2 * -429781586) ^ 0x3E7428F7;
					continue;
				case 27u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 161514939;
						num4 = 161514939;
					}
					else
					{
						num = 979511672;
						num4 = 979511672;
					}
					continue;
				}
				case 26u:
					num = ((int)num2 * -1251973439) ^ 0x2D5C23C1;
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1690579326;
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1050260021;
					continue;
				case 23u:
					num3++;
					num = 1016948182;
					continue;
				case 22u:
					c = c3;
					num = ((int)num2 * -561670801) ^ 0x2B8E1937;
					continue;
				case 21u:
					num = (int)(num2 * 2132890498) ^ -220220276;
					continue;
				case 20u:
					goto IL_010d;
				case 19u:
					goto IL_0123;
				case 18u:
					c3 = JSONNode.smethod_2(string_, num3);
					num = 682163926;
					continue;
				case 16u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 509520729;
					continue;
				case 15u:
					num = (int)(num2 * 459890764) ^ -310378024;
					continue;
				case 14u:
					goto IL_0174;
				case 13u:
					num = (int)((num2 * 268251419) ^ 0x10795E02);
					continue;
				case 12u:
					goto IL_019d;
				case 11u:
					num = ((int)num2 * -1836156332) ^ 0x69F1839;
					continue;
				case 10u:
					num = ((int)num2 * -1285542380) ^ 0x63970051;
					continue;
				case 9u:
					goto IL_01d9;
				case 8u:
					c2 = c;
					switch (c2)
					{
					case '\b':
						break;
					case '\n':
						goto IL_010d;
					case '\r':
						goto IL_0123;
					case '\t':
						goto IL_0174;
					case '\f':
						goto IL_019d;
					case '\v':
						goto IL_01d9;
					default:
						goto IL_0216;
					}
					goto case 25u;
				case 7u:
					num = (int)((num2 * 1356508062) ^ 0x7C22FB13);
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -984542280) ^ -239099639;
					continue;
				case 5u:
					num = ((int)num2 * -1117699278) ^ -1083063151;
					continue;
				case 4u:
					num = ((int)num2 * -1029098621) ^ 0x4D169332;
					continue;
				case 3u:
					text = "";
					num = (int)((num2 * 847412521) ^ 0x3186E7CD);
					continue;
				case 2u:
					num = ((int)num2 * -1857627110) ^ 0x44581337;
					continue;
				case 1u:
					num = (int)(num2 * 775905959) ^ -352920067;
					continue;
				case 0u:
					result = text;
					num = ((int)num2 * -726601125) ^ 0x5570CF02;
					continue;
				case 32u:
					break;
				default:
					{
						return result;
					}
					IL_0216:
					num = ((int)num2 * -42437494) ^ -2030636030;
					continue;
					IL_01d9:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1202470681;
					continue;
					IL_019d:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1698237809;
					continue;
					IL_0174:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1050260021;
					continue;
					IL_0123:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1851371590;
					continue;
					IL_010d:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1050260021;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		JSONNode jSONNode = default(JSONNode);
		bool flag9 = default(bool);
		bool flag = default(bool);
		int num11 = default(int);
		string text = default(string);
		bool flag2 = default(bool);
		string text2 = default(string);
		char c = default(char);
		bool flag10 = default(bool);
		bool flag11 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		char c3 = default(char);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		char c4 = default(char);
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		char c2 = default(char);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1348839935;
			while (true)
			{
				uint num2;
				int num20;
				int num25;
				switch ((num2 = (uint)num ^ 0x2561BD7Au) % 150u)
				{
				case 149u:
				{
					int num30;
					int num31;
					if (!(jSONNode is JSONArray))
					{
						num30 = -34996207;
						num31 = -34996207;
					}
					else
					{
						num30 = -1472806328;
						num31 = -1472806328;
					}
					num = num30 ^ ((int)num2 * -1562634909);
					continue;
				}
				case 148u:
					flag9 = flag;
					num = 1619155499;
					continue;
				case 147u:
					num = ((int)num2 * -94533230) ^ -612239084;
					continue;
				case 4u:
				case 31u:
				case 52u:
				case 56u:
				case 146u:
					num11++;
					num = 1003615111;
					continue;
				case 145u:
					num = ((int)num2 * -174508678) ^ 0x648AB7C;
					continue;
				case 144u:
					text = "";
					num = 2065913106;
					continue;
				case 143u:
				{
					int num57;
					int num58;
					if (flag9)
					{
						num57 = -602491504;
						num58 = -602491504;
					}
					else
					{
						num57 = -1186610731;
						num58 = -1186610731;
					}
					num = num57 ^ (int)(num2 * 847067239);
					continue;
				}
				case 142u:
				{
					int num35;
					int num36;
					if (!flag2)
					{
						num35 = 855089664;
						num36 = 855089664;
					}
					else
					{
						num35 = 2127745761;
						num36 = 2127745761;
					}
					num = num35 ^ ((int)num2 * -466748264);
					continue;
				}
				case 141u:
					jSONNode.Add(text2);
					num = ((int)num2 * -692411424) ^ 0x1DF53B19;
					continue;
				case 140u:
				{
					text = JSONNode.smethod_5(text);
					int num15;
					int num16;
					if (jSONNode is JSONArray)
					{
						num15 = -1857975753;
						num16 = -1857975753;
					}
					else
					{
						num15 = -1299170156;
						num16 = -1299170156;
					}
					num = num15 ^ ((int)num2 * -417864071);
					continue;
				}
				case 139u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1852191364) ^ 0x59832C67);
					continue;
				case 138u:
					num = (int)(num2 * 1487494027) ^ -1717850349;
					continue;
				case 137u:
					num = ((int)num2 * -1160468912) ^ 0x6395271C;
					continue;
				case 136u:
				{
					int num47;
					int num48;
					if ((uint)c <= 32u)
					{
						num47 = 1864272228;
						num48 = 1864272228;
					}
					else
					{
						num47 = 1370685530;
						num48 = 1370685530;
					}
					num = num47 ^ (int)(num2 * 927272214);
					continue;
				}
				case 135u:
					flag10 = flag;
					num = 1228713666;
					continue;
				case 134u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -779082979) ^ 0x4C24B108;
					continue;
				case 133u:
				{
					int num41;
					int num42;
					if (flag11)
					{
						num41 = -1510717076;
						num42 = -1510717076;
					}
					else
					{
						num41 = -1811208883;
						num42 = -1811208883;
					}
					num = num41 ^ (int)(num2 * 1907674239);
					continue;
				}
				case 132u:
				{
					int num21;
					int num22;
					if (!flag6)
					{
						num21 = -588292020;
						num22 = -588292020;
					}
					else
					{
						num21 = -109954381;
						num22 = -109954381;
					}
					num = num21 ^ (int)(num2 * 122019971);
					continue;
				}
				case 131u:
					num = ((int)num2 * -604615769) ^ 0x7641212D;
					continue;
				case 130u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = 493945181;
						num10 = 493945181;
					}
					else
					{
						num9 = 1190337054;
						num10 = 1190337054;
					}
					num = num9 ^ (int)(num2 * 1301801050);
					continue;
				}
				case 129u:
					flag = !flag;
					num = 1384340786;
					continue;
				case 128u:
					stack.Push(new JSONArray());
					num = 856053091;
					continue;
				case 127u:
					num = (int)((num2 * 1354527323) ^ 0x40B0A90B);
					continue;
				case 126u:
				{
					int num53;
					int num54;
					if ((uint)c3 <= 102u)
					{
						num53 = 1708426691;
						num54 = 1708426691;
					}
					else
					{
						num53 = 443940206;
						num54 = 443940206;
					}
					num = num53 ^ (int)(num2 * 1551014527);
					continue;
				}
				case 124u:
					num = ((int)num2 * -1452102705) ^ 0x665B1A0D;
					continue;
				case 123u:
					text = text2;
					text2 = "";
					num = 1364343350;
					continue;
				case 122u:
					num = 1255931334;
					continue;
				case 121u:
					num = (int)((num2 * 1568787956) ^ 0x546F8866);
					continue;
				case 120u:
				{
					int num46;
					if (c != ' ')
					{
						num = 839746756;
						num46 = 839746756;
					}
					else
					{
						num = 1558318525;
						num46 = 1558318525;
					}
					continue;
				}
				case 119u:
				{
					int num39;
					int num40;
					if (jSONNode is JSONArray)
					{
						num39 = 998047472;
						num40 = 998047472;
					}
					else
					{
						num39 = 686805723;
						num40 = 686805723;
					}
					num = num39 ^ ((int)num2 * -1288274537);
					continue;
				}
				case 118u:
					text = "";
					num = 897609421;
					continue;
				case 117u:
				{
					int num32;
					int num33;
					if (flag5)
					{
						num32 = 1531280554;
						num33 = 1531280554;
					}
					else
					{
						num32 = 2127109759;
						num33 = 2127109759;
					}
					num = num32 ^ (int)(num2 * 1893720981);
					continue;
				}
				case 116u:
				{
					int num28;
					if (!flag)
					{
						num = 1588210852;
						num28 = 1588210852;
					}
					else
					{
						num = 702473080;
						num28 = 702473080;
					}
					continue;
				}
				case 115u:
					flag3 = flag;
					num = ((int)num2 * -1398759544) ^ 0x501AB34A;
					continue;
				case 114u:
					num = ((int)num2 * -964134180) ^ -1568050122;
					continue;
				case 113u:
					num = ((int)num2 * -649754928) ^ -2013430815;
					continue;
				case 112u:
					switch (c)
					{
					case '[':
						goto IL_0416;
					case '\\':
						goto IL_0424;
					case ']':
						goto IL_0432;
					}
					num = 1655721240;
					continue;
				case 15u:
					goto IL_0416;
				case 41u:
					goto IL_0424;
				case 47u:
					goto IL_0432;
				case 111u:
					num = 1703302400;
					continue;
				case 110u:
				{
					int num14;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 2031024584;
						num14 = 2031024584;
					}
					else
					{
						num = 655020219;
						num14 = 655020219;
					}
					continue;
				}
				case 109u:
					goto IL_0486;
				case 108u:
				{
					int num8;
					if (c != '}')
					{
						num = 2132412781;
						num8 = 2132412781;
					}
					else
					{
						num = 1788954171;
						num8 = 1788954171;
					}
					continue;
				}
				case 107u:
					num = ((int)num2 * -681520442) ^ -1759364760;
					continue;
				case 106u:
				{
					int num5;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 2083584597;
						num5 = 2083584597;
					}
					else
					{
						num = 753485276;
						num5 = 753485276;
					}
					continue;
				}
				case 105u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)((num2 * 1253624131) ^ 0x396C4F16);
					continue;
				case 104u:
					num = 1885939827;
					continue;
				case 103u:
				{
					char c5 = c4;
					c3 = c5;
					num = (int)(num2 * 362791886) ^ -1799282188;
					continue;
				}
				case 102u:
				{
					int num55;
					int num56;
					if (!flag7)
					{
						num55 = -352687423;
						num56 = -352687423;
					}
					else
					{
						num55 = -821497318;
						num56 = -821497318;
					}
					num = num55 ^ (int)(num2 * 1561586990);
					continue;
				}
				case 101u:
					text = "";
					num = 1330049746;
					continue;
				case 100u:
				{
					int num52;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 203750266;
						num52 = 203750266;
					}
					else
					{
						num = 339464207;
						num52 = 339464207;
					}
					continue;
				}
				case 99u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -368292710) ^ 0x6C41A150;
					continue;
				case 98u:
				{
					int num50;
					int num51;
					if (!flag8)
					{
						num50 = 1675724252;
						num51 = 1675724252;
					}
					else
					{
						num50 = 261553758;
						num51 = 261553758;
					}
					num = num50 ^ (int)(num2 * 1878401117);
					continue;
				}
				case 97u:
					num = ((int)num2 * -1017480303) ^ 0x8D2224C;
					continue;
				case 95u:
					num = 917579016;
					continue;
				case 94u:
					num = 1751808230;
					continue;
				case 93u:
					num = ((int)num2 * -1071682310) ^ 0x1A38C871;
					continue;
				case 92u:
					text2 = "";
					num = (int)((num2 * 1097557886) ^ 0x43A010E1);
					continue;
				case 91u:
					num = ((int)num2 * -1931012734) ^ 0x241DBA52;
					continue;
				case 90u:
					num = (int)(num2 * 235599964) ^ -1442197308;
					continue;
				case 89u:
				{
					int num49;
					if ((uint)c <= 93u)
					{
						num = 1289676694;
						num49 = 1289676694;
					}
					else
					{
						num = 601690776;
						num49 = 601690776;
					}
					continue;
				}
				case 88u:
					num = (int)((num2 * 1482041321) ^ 0x1F0F3144);
					continue;
				case 87u:
					num = ((int)num2 * -1486370043) ^ 0x4D2F5D2A;
					continue;
				case 86u:
					c = c2;
					num = (int)((num2 * 956444725) ^ 0x49896492);
					continue;
				case 85u:
					num = ((int)num2 * -573112972) ^ -555175550;
					continue;
				case 84u:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 1238023625;
					continue;
				case 83u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)((num2 * 1782270376) ^ 0x6032B9DA);
					continue;
				case 82u:
				{
					int num44;
					int num45;
					if (c == ':')
					{
						num44 = 331548737;
						num45 = 331548737;
					}
					else
					{
						num44 = 1529162550;
						num45 = 1529162550;
					}
					num = num44 ^ ((int)num2 * -1663865464);
					continue;
				}
				case 81u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 210137370) ^ 0x506FAF52);
					continue;
				case 80u:
				{
					int num43;
					if (c != ',')
					{
						num = 1625675888;
						num43 = 1625675888;
					}
					else
					{
						num = 267918912;
						num43 = 267918912;
					}
					continue;
				}
				case 79u:
					num = ((int)num2 * -762012661) ^ 0x1B316465;
					continue;
				case 78u:
					num = (int)((num2 * 42796566) ^ 0x1CF635BA);
					continue;
				case 77u:
					num = ((int)num2 * -925836922) ^ 0x5498B6B2;
					continue;
				case 76u:
					text2 = "";
					flag11 = stack.Count > 0;
					num = (int)(num2 * 1807828748) ^ -654491093;
					continue;
				case 75u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -917108184) ^ 0x5CCE813D;
					continue;
				case 74u:
				{
					int num37;
					int num38;
					if (!flag10)
					{
						num37 = -1683739165;
						num38 = -1683739165;
					}
					else
					{
						num37 = -1809639454;
						num38 = -1809639454;
					}
					num = num37 ^ (int)(num2 * 1335867829);
					continue;
				}
				case 73u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 2058154487;
					continue;
				case 72u:
					num = (int)((num2 * 1363150302) ^ 0x4C649B95);
					continue;
				case 71u:
					num = ((int)num2 * -259058513) ^ -1437160320;
					continue;
				case 70u:
				{
					int num34;
					if (c != '"')
					{
						num = 260108104;
						num34 = 260108104;
					}
					else
					{
						num = 137830609;
						num34 = 137830609;
					}
					continue;
				}
				case 68u:
					num = ((int)num2 * -1224893812) ^ 0x78E1BD1B;
					continue;
				case 67u:
					num = (int)((num2 * 797081395) ^ 0x7744F44);
					continue;
				case 66u:
					text = "";
					text2 = "";
					num = 1832111119;
					continue;
				case 65u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 763613038) ^ -1904726321;
					continue;
				case 64u:
					switch (c3)
					{
					case 'r':
						break;
					default:
						goto IL_091b;
					case 's':
						goto IL_0925;
					case 't':
						goto IL_093d;
					case 'u':
						goto IL_0953;
					}
					goto case 84u;
				case 46u:
					goto IL_0925;
				case 20u:
					goto IL_093d;
				case 34u:
					goto IL_0953;
				case 63u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 283374628) ^ 0x391A8B40);
					continue;
				case 62u:
					num = ((int)num2 * -1499047569) ^ -1873940594;
					continue;
				case 61u:
				{
					int num29;
					if (stack.Count == 0)
					{
						num = 333986521;
						num29 = 333986521;
					}
					else
					{
						num = 104484521;
						num29 = 104484521;
					}
					continue;
				}
				case 60u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 1806337150) ^ -1878285297;
					continue;
				case 59u:
				{
					string s = JSONNode.smethod_8(aJSON, num11 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num11 += 4;
					num = ((int)num2 * -325491422) ^ 0x324C2E8D;
					continue;
				}
				case 58u:
				{
					int num26;
					int num27;
					if ((uint)c > 44u)
					{
						num26 = 1411084675;
						num27 = 1411084675;
					}
					else
					{
						num26 = 477830604;
						num27 = 477830604;
					}
					num = num26 ^ (int)(num2 * 936398423);
					continue;
				}
				case 57u:
					goto IL_0a44;
				case 55u:
					stack.Pop();
					flag8 = JSONNode.smethod_6(text2, "");
					num = 154313624;
					continue;
				case 54u:
					flag4 = jSONNode != null;
					num = ((int)num2 * -790041484) ^ -2070931522;
					continue;
				case 53u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 584348077;
					continue;
				case 51u:
					c4 = JSONNode.smethod_2(aJSON, num11);
					num = ((int)num2 * -309753770) ^ 0x8CE3FE7;
					continue;
				case 50u:
					result = jSONNode;
					num = 1809315748;
					continue;
				case 49u:
					flag7 = num11 < JSONNode.smethod_4(aJSON);
					num = 256315370;
					continue;
				case 48u:
					num = (int)(num2 * 1394167162) ^ -1715453043;
					continue;
				case 45u:
					num = ((int)num2 * -1635024128) ^ 0x7E3FE991;
					continue;
				case 44u:
					num = ((int)num2 * -169968084) ^ 0x505979FC;
					continue;
				case 43u:
					num = ((int)num2 * -986581702) ^ -2123343362;
					continue;
				case 42u:
				{
					stack.Push(new JSONClass());
					int num24;
					if (jSONNode != null)
					{
						num = 1831020487;
						num24 = 1831020487;
					}
					else
					{
						num = 1885939827;
						num24 = 1885939827;
					}
					continue;
				}
				case 40u:
				{
					int num23;
					if (c != '{')
					{
						num = 1987886609;
						num23 = 1987886609;
					}
					else
					{
						num = 37466378;
						num23 = 37466378;
					}
					continue;
				}
				case 39u:
					flag = false;
					num = (int)((num2 * 1728764885) ^ 0x2FA3FD1B);
					continue;
				case 38u:
					num11 = 0;
					text2 = "";
					num = ((int)num2 * -20587382) ^ 0x5741A1CE;
					continue;
				case 37u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1876248324) ^ 0x574607E6);
					continue;
				case 36u:
					num = (int)((num2 * 1974146111) ^ 0x22A6646C);
					continue;
				case 35u:
					num = ((int)num2 * -708876539) ^ 0x356E2AEA;
					continue;
				case 33u:
				{
					int num18;
					int num19;
					if (c3 == 'b')
					{
						num18 = -1407256299;
						num19 = -1407256299;
					}
					else
					{
						num18 = -1250666442;
						num19 = -1250666442;
					}
					num = num18 ^ (int)(num2 * 1420476391);
					continue;
				}
				case 32u:
				{
					int num17;
					if (c3 != 'n')
					{
						num = 2030767443;
						num17 = 2030767443;
					}
					else
					{
						num = 2020827049;
						num17 = 2020827049;
					}
					continue;
				}
				case 30u:
					num = (int)(num2 * 1978686534) ^ -1786162737;
					continue;
				case 29u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 604314957) ^ -1729634893;
					continue;
				case 28u:
					flag5 = JSONNode.smethod_6(text, "");
					num = 1896544523;
					continue;
				case 27u:
					num = (int)(num2 * 1342525891) ^ -1672376577;
					continue;
				case 26u:
					num = (int)(num2 * 1171177231) ^ -1059218947;
					continue;
				case 25u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -2048912766) ^ 0x3D998EF3;
					continue;
				case 24u:
				{
					int num13;
					if (c3 == 'f')
					{
						num = 1009296301;
						num13 = 1009296301;
					}
					else
					{
						num = 295589434;
						num13 = 295589434;
					}
					continue;
				}
				case 23u:
					num = (int)(num2 * 1385438445) ^ -917429476;
					continue;
				case 22u:
					c2 = JSONNode.smethod_2(aJSON, num11);
					num = 1545372160;
					continue;
				case 21u:
					num = ((int)num2 * -1928627076) ^ -1625280383;
					continue;
				case 19u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num = (int)(num2 * 500639299) ^ -1641878667;
					continue;
				case 18u:
				{
					int num12;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 321163904;
						num12 = 321163904;
					}
					else
					{
						num = 917579016;
						num12 = 917579016;
					}
					continue;
				}
				case 17u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -1910584517) ^ 0x76520311;
					continue;
				case 14u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_0486;
					case '\t':
						goto IL_0a44;
					default:
						goto IL_0dc4;
					}
					goto case 4u;
				case 13u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -1752808029) ^ -1076436478;
					continue;
				case 12u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = 1396105558;
						num7 = 1396105558;
					}
					else
					{
						num6 = 471690338;
						num7 = 471690338;
					}
					num = num6 ^ (int)(num2 * 633356844);
					continue;
				}
				case 11u:
					num = ((int)num2 * -662395081) ^ 0x14DB18CA;
					continue;
				case 10u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 1334081029;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (!(jSONNode is JSONArray))
					{
						num3 = -972028846;
						num4 = -972028846;
					}
					else
					{
						num3 = -1243613357;
						num4 = -1243613357;
					}
					num = num3 ^ (int)(num2 * 377821378);
					continue;
				}
				case 8u:
					flag2 = flag;
					num = (int)(num2 * 1370942528) ^ -521524134;
					continue;
				case 7u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1929909544) ^ 0x6B362B37;
					continue;
				case 6u:
					num = (int)((num2 * 833963843) ^ 0x7CCB27E);
					continue;
				case 5u:
					text2 = "";
					num = (int)(num2 * 1521413684) ^ -1309950318;
					continue;
				case 3u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -2105391756) ^ 0x3301B863;
					continue;
				case 2u:
					text = "";
					num = (int)((num2 * 1254031220) ^ 0x268D06C5);
					continue;
				case 1u:
					num = (int)((num2 * 1431070070) ^ 0x4BE81138);
					continue;
				case 0u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1938447984) ^ 0x88BD5FD);
					continue;
				case 125u:
					break;
				case 69u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 96u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0dc4:
					num = ((int)num2 * -2043075803) ^ -1005401327;
					continue;
					IL_0486:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = 1028881859;
					continue;
					IL_0432:
					if (flag)
					{
						num = 1761363508;
						num20 = 1761363508;
					}
					else
					{
						num = 51831097;
						num20 = 51831097;
					}
					continue;
					IL_0424:
					num11++;
					num = 1822200024;
					continue;
					IL_0416:
					flag6 = flag;
					num = 668380472;
					continue;
					IL_0a44:
					if (!flag)
					{
						num = 1486125675;
						num25 = 1486125675;
					}
					else
					{
						num = 894644217;
						num25 = 894644217;
					}
					continue;
					IL_0953:
					num = 451049793;
					continue;
					IL_093d:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 1664421473;
					continue;
					IL_0925:
					text2 = JSONNode.smethod_3(text2, c4.ToString());
					num = 1064319121;
					continue;
					IL_091b:
					num = 687111717;
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
			int num = 1601053313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B6F0493u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					Serialize(aWriter);
					return;
				}
				break;
				IL_0003:
				aWriter = JSONNode.smethod_9(aData);
				num = (int)((num2 * 525625488) ^ 0x60D28550);
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
				int num = 616173557;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6706D96u) % 4u)
					{
					case 3u:
						SaveToStream(fileStream);
						num = (int)(num2 * 160144653) ^ -1359264004;
						continue;
					case 1u:
						num = ((int)num2 * -1253601675) ^ -1394207255;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00b5:
					int num3 = 32276900;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x6706D96u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -61959478) ^ -1749341397;
							continue;
						case 1u:
							num3 = (int)((num2 * 2019291644) ^ 0x569279FD);
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
				int num = 1617633600;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x248A1F73u) % 6u)
					{
					case 5u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 646261889) ^ 0x471FBAEE);
						continue;
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -2124228604) ^ 0x58126D36;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -966382911) ^ 0x3E2FDF92;
						continue;
					case 0u:
						num = ((int)num2 * -1817753388) ^ 0x6057904C;
						continue;
					case 4u:
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
					IL_00cf:
					int num3 = 1134341554;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x248A1F73u) % 3u)
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
						num3 = (int)((num2 * 1729241443) ^ 0x74054525);
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
		int num5 = default(int);
		bool flag2 = default(bool);
		int num6 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num7 = default(int);
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		bool flag = default(bool);
		int num8 = default(int);
		while (true)
		{
			int num = 58732454;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D5C2A76u) % 35u)
				{
				case 34u:
					num5++;
					num = (int)(num2 * 1113915858) ^ -1184469499;
					continue;
				case 33u:
					num = 883109797;
					continue;
				case 32u:
					flag2 = num5 < num6;
					num = 1976976106;
					continue;
				case 31u:
					jSONArray.Add(Deserialize(aReader));
					num = 1630132498;
					continue;
				case 30u:
					goto IL_0057;
				case 29u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 1995310937;
						num10 = 1995310937;
					}
					else
					{
						num9 = 1896074346;
						num10 = 1896074346;
					}
					num = num9 ^ ((int)num2 * -189494008);
					continue;
				}
				case 27u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -381140820) ^ 0x1282066E;
					continue;
				case 26u:
					goto IL_00a4;
				case 25u:
					num7++;
					num = (int)((num2 * 631461588) ^ 0x53AC2FF7);
					continue;
				case 24u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -1202189186) ^ -2052155195;
					continue;
				case 23u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 19371152) ^ -431038835;
					continue;
				case 22u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -559585086) ^ -671396203;
					continue;
				case 21u:
					result = jSONArray;
					num = (int)((num2 * 1963544172) ^ 0x1BCB2F5F);
					continue;
				case 20u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = 1162830173;
					continue;
				}
				case 19u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Array:
						break;
					case JSONBinaryTag.FloatValue:
						goto IL_0057;
					case JSONBinaryTag.Class:
						goto IL_00a4;
					default:
						goto IL_0190;
					case JSONBinaryTag.Value:
						goto IL_01a3;
					case JSONBinaryTag.IntValue:
						goto IL_01ba;
					case JSONBinaryTag.DoubleValue:
						goto IL_01c4;
					case JSONBinaryTag.BoolValue:
						goto IL_01ce;
					}
					goto case 33u;
				case 10u:
					goto IL_01a3;
				case 14u:
					goto IL_01ba;
				case 4u:
					goto IL_01c4;
				case 13u:
					goto IL_01ce;
				case 18u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)(num2 * 1898682791) ^ -379066400;
					continue;
				case 17u:
					num7 = 0;
					num = (int)((num2 * 1897200646) ^ 0x4306C2C1);
					continue;
				case 16u:
					num = ((int)num2 * -938994804) ^ 0x69E48361;
					continue;
				case 15u:
					num = ((int)num2 * -1598591553) ^ -285790250;
					continue;
				case 11u:
				{
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -625815874) ^ -786679697;
					continue;
				}
				case 9u:
					result = jSONClass;
					num = (int)((num2 * 1635717434) ^ 0x3BA65D7F);
					continue;
				case 8u:
					flag = num7 < num8;
					num = 1329249809;
					continue;
				case 7u:
					num5 = 0;
					num = (int)((num2 * 875843382) ^ 0x729FF607);
					continue;
				case 6u:
					num = ((int)num2 * -1374776222) ^ -1831730179;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -114819348;
						num4 = -114819348;
					}
					else
					{
						num3 = -1283907934;
						num4 = -1283907934;
					}
					num = num3 ^ (int)(num2 * 895712161);
					continue;
				}
				case 3u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)(num2 * 825302801) ^ -1385123096;
					continue;
				case 2u:
					num = ((int)num2 * -254868957) ^ 0x49D266E6;
					continue;
				case 1u:
					num = ((int)num2 * -1392336964) ^ 0x7328D4B5;
					continue;
				case 12u:
					break;
				case 28u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0057:
					num = 871879746;
					continue;
					IL_01ce:
					num = 1559645917;
					continue;
					IL_01c4:
					num = 1207429210;
					continue;
					IL_01ba:
					num = 344920824;
					continue;
					IL_01a3:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 1665639539;
					continue;
					IL_0190:
					num = ((int)num2 * -2142287734) ^ -1815487956;
					continue;
					IL_00a4:
					num8 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = 955782321;
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
				int num = 1247667249;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x121BB71Au) % 3u)
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
					num = (int)(num2 * 491812145) ^ -1727979483;
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
					int num3 = 776911688;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x121BB71Au) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = (int)((num2 * 1094085491) ^ 0x62EB0600);
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
					int num = -1005396450;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xF80E8173u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)(num2 * 1347934621) ^ -1028908566;
							continue;
						case 0u:
							num = ((int)num2 * -2090328500) ^ 0x20DDC42D;
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
		JSONNode.smethod_17((Stream)memoryStream, 0L);
		return LoadFromStream(memoryStream);
	}

	public JSONNode()
	{
		while (true)
		{
			int num = -367339794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x815F4AC9u) % 3u)
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
				num = (int)((num2 * 1271279064) ^ 0x1B9F9384);
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
