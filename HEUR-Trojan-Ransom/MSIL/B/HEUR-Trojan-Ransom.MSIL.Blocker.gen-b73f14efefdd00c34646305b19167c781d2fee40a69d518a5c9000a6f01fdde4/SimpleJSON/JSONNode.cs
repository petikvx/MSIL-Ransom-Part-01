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
				int num = -2028790596;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x96A07E61u) % 4u)
					{
					case 1u:
						result = null;
						num = ((int)num2 * -970419077) ^ 0x27E8B142;
						continue;
					case 0u:
						num = ((int)num2 * -2034150467) ^ -1959078489;
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
				int num = -860410763;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB0D5ACC4u) % 4u)
					{
					case 1u:
						result = "";
						num = ((int)num2 * -982532698) ^ -1496561910;
						continue;
					case 0u:
						num = (int)(num2 * 1083128572) ^ -1423521301;
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
				int num = -370984985;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF6B5CBBAu) % 4u)
					{
					case 1u:
						result = 0;
						num = ((int)num2 * -660740680) ^ 0x65114EE2;
						continue;
					case 0u:
						num = ((int)num2 * -1400487579) ^ -1150533899;
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

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			while (true)
			{
				int num = -1499156877;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0E023FFu) % 7u)
					{
					case 6u:
					{
						int num3;
						num = ((num3 != 0) ? 1503753221 : 845300842) ^ ((int)num2 * -1055905108);
						continue;
					}
					case 5u:
						num = ((int)num2 * -823362500) ^ 0x6D1D890F;
						continue;
					case 3u:
					case 4u:
						num = -1575770757;
						continue;
					default:
						yield break;
					case 0u:
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
			while (true)
			{
				int num = 1178704054;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D5B90A7u) % 6u)
					{
					case 5u:
						result = result2;
						num = (int)(num2 * 94537365) ^ -518538750;
						continue;
					case 3u:
						result2 = 0;
						num = ((int)num2 * -1771276281) ^ 0x46E411C0;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (int.TryParse(Value, out result2))
						{
							num3 = -1912964158;
							num4 = -1912964158;
						}
						else
						{
							num3 = -303362996;
							num4 = -303362996;
						}
						num = num3 ^ ((int)num2 * -1928292783);
						continue;
					}
					case 1u:
						result = 0;
						num = 67053851;
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

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			bool flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
			float result2 = default(float);
			while (true)
			{
				int num = -295021358;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE4194162u) % 7u)
					{
					case 5u:
						num = (int)(num2 * 1082565710) ^ -886122971;
						continue;
					case 4u:
						num = ((int)num2 * -1217163624) ^ 0x492F5A25;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1878739724;
							num4 = 1878739724;
						}
						else
						{
							num3 = 1673913736;
							num4 = 1673913736;
						}
						num = num3 ^ (int)(num2 * 1325481752);
						continue;
					}
					case 2u:
						result2 = 0f;
						num = -1371305058;
						continue;
					case 1u:
						result2 = result;
						num = ((int)num2 * -2051823487) ^ 0x69335C6B;
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
				int num = -352550090;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F7D3CE0u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1719573517) ^ -1035085602;
						continue;
					case 2u:
						Value = value.ToString();
						num = (int)((num2 * 86486934) ^ 0x44F2855F);
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
				int num = 677982025;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AB814E5u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -577270559) ^ -583766456;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1439034192;
							num4 = 1439034192;
						}
						else
						{
							num3 = 1451546938;
							num4 = 1451546938;
						}
						num = num3 ^ ((int)num2 * -739550454);
						continue;
					}
					case 3u:
						result2 = 0.0;
						num = 313013552;
						continue;
					case 2u:
						flag = double.TryParse(Value, out result);
						num = ((int)num2 * -823622431) ^ -1956857482;
						continue;
					case 0u:
						result2 = result;
						num = (int)((num2 * 1370705328) ^ 0x3602CF4D);
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
				int num = -1289435819;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB832FE20u) % 3u)
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
					num = ((int)num2 * -943831380) ^ 0x1AAD1417;
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
				int num = -1549903899;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90B5F5E5u) % 7u)
					{
					case 6u:
						flag = bool.TryParse(Value, out result2);
						num = (int)(num2 * 308575293) ^ -1172245817;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 29005740;
							num4 = 29005740;
						}
						else
						{
							num3 = 70425981;
							num4 = 70425981;
						}
						num = num3 ^ ((int)num2 * -1991133971);
						continue;
					}
					case 4u:
						result = !JSONNode.smethod_1(Value);
						num = -212725507;
						continue;
					case 2u:
						result = result2;
						num = (int)((num2 * 343157916) ^ 0x59DD8665);
						continue;
					case 1u:
						result2 = false;
						num = (int)(num2 * 309171500) ^ -52422764;
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
				int num = 324794136;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x703DE68D) % 3u)
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
					num = 1982589350;
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
				int num = 325187550;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D1EB6B0u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 574236983) ^ 0x20330C80);
						continue;
					case 2u:
						result = this as JSONArray;
						num = (int)(num2 * 2122191651) ^ -1592704691;
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
				int num = 1925622538;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55DF2FA1u) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = ((int)num2 * -277050088) ^ -1709928852;
						continue;
					case 1u:
						num = ((int)num2 * -570552691) ^ -1509717322;
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
			int num = -1754631383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3791AE9u) % 3u)
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
				Add("", aItem);
				num = ((int)num2 * -2040296634) ^ -1266667628;
			}
		}
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
			int num = -1963204588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5FB9BF7u) % 3u)
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
				num = ((int)num2 * -843946374) ^ 0x98E44B4;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1651850542;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43D30F14u) % 3u)
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
				num = ((int)num2 * -1264519759) ^ 0x15ED4531;
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 1460808748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E586BEFu) % 3u)
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
				num = (int)(num2 * 1943824109) ^ -1190870005;
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
			int num = 421840681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x779333A4u) % 4u)
				{
				case 1u:
					result = new JSONData(s);
					num = (int)((num2 * 99433645) ^ 0x13C35555);
					continue;
				case 0u:
					num = (int)((num2 * 686389450) ^ 0x559A3196);
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
			int num = -1657385487;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x8445BB48u) % 4u)
				{
				case 3u:
					obj = d.Value;
					goto IL_0009;
				case 1u:
					if (!(d == null))
					{
						num = ((int)num2 * -1478403984) ^ 0x20F40D2B;
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
					num = -1888515354;
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
			goto IL_0039;
		}
		int num = 0;
		goto IL_0094;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
		IL_0039:
		int num2 = 304437270;
		goto IL_005e;
		IL_005e:
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x3357724Cu) % 7u)
			{
			case 6u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1183366060;
					num5 = 1183366060;
				}
				else
				{
					num4 = 1485504730;
					num5 = 1485504730;
				}
				num2 = num4 ^ ((int)num3 * -1911109365);
				continue;
			}
			case 5u:
				result = (object)a == b;
				num2 = 449730788;
				continue;
			case 3u:
				break;
			case 2u:
				result = true;
				num2 = ((int)num3 * -1645231302) ^ 0x3402ECAD;
				continue;
			case 0u:
				num2 = (int)(num3 * 2061637358) ^ -1810311654;
				continue;
			case 1u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_0039;
		IL_0094:
		flag = (byte)num != 0;
		num2 = 1897281746;
		goto IL_005e;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 520947100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12A4B332u) % 3u)
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
				result = !(a == b);
				num = (int)((num2 * 1821785392) ^ 0x16363B09);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -2145551344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x970582F1u) % 3u)
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
				num = ((int)num2 * -508067149) ^ 0x192C51E7;
			}
		}
	}

	public override int GetHashCode()
	{
		return this.method_0();
	}

	internal static string Escape(string aText)
	{
		string text = "";
		char c3 = default(char);
		string result = default(string);
		char c = default(char);
		string string_ = default(string);
		int num3 = default(int);
		char c2 = default(char);
		while (true)
		{
			int num = 1272011074;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4612A382u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -1979993556) ^ 0x5E42086B;
					continue;
				case 28u:
					num = ((int)num2 * -1160463951) ^ 0x6FBA3211;
					continue;
				case 27u:
				{
					int num5;
					if (c3 == '"')
					{
						num = 1239207115;
						num5 = 1239207115;
					}
					else
					{
						num = 99747511;
						num5 = 99747511;
					}
					continue;
				}
				case 26u:
					result = text;
					num = ((int)num2 * -1626978274) ^ 0x2F58A662;
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 2021273717;
					continue;
				case 23u:
					num = (int)((num2 * 2067821737) ^ 0x27F4DBCE);
					continue;
				case 22u:
					goto IL_0094;
				case 21u:
					switch (c3)
					{
					case '\v':
						break;
					case '\n':
						goto IL_0094;
					default:
						goto IL_00cb;
					case '\b':
						goto IL_00de;
					case '\t':
						goto IL_00f4;
					case '\f':
						goto IL_010a;
					case '\r':
						goto IL_0120;
					}
					goto case 25u;
				case 13u:
					goto IL_00de;
				case 17u:
					goto IL_00f4;
				case 16u:
					goto IL_010a;
				case 9u:
					goto IL_0120;
				case 20u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -1829389842) ^ -139649050;
					continue;
				case 18u:
					num3++;
					num = (int)(num2 * 1327407921) ^ -188290858;
					continue;
				case 15u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1811734969;
					continue;
				case 14u:
					c3 = c2;
					num = ((int)num2 * -1230507115) ^ -1640356329;
					continue;
				case 12u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 839161485;
					continue;
				case 11u:
					num = ((int)num2 * -1852359152) ^ 0x156FC285;
					continue;
				case 10u:
				{
					int num6;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = 489304746;
						num6 = 489304746;
					}
					else
					{
						num = 1308100764;
						num6 = 1308100764;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -1285952149) ^ 0x15BB375B;
					continue;
				case 7u:
				{
					int num4;
					if (c3 != '\\')
					{
						num = 142965096;
						num4 = 142965096;
					}
					else
					{
						num = 414916130;
						num4 = 414916130;
					}
					continue;
				}
				case 6u:
					num = (int)(num2 * 621425370) ^ -1615501341;
					continue;
				case 5u:
					num = 677370674;
					continue;
				case 4u:
					num = ((int)num2 * -1750384250) ^ 0x4ABFE2DC;
					continue;
				case 3u:
					num = ((int)num2 * -1199682994) ^ -1497560177;
					continue;
				case 2u:
					c = JSONNode.smethod_2(string_, num3);
					c2 = c;
					num = 104802844;
					continue;
				case 1u:
					num = (int)(num2 * 1608773947) ^ -196507112;
					continue;
				case 0u:
					num = (int)(num2 * 75877556) ^ -604273251;
					continue;
				case 19u:
					break;
				default:
					{
						return result;
					}
					IL_0120:
					text = JSONNode.smethod_3(text, "\\r");
					num = 559030408;
					continue;
					IL_010a:
					text = JSONNode.smethod_3(text, "\\f");
					num = 59520032;
					continue;
					IL_00f4:
					text = JSONNode.smethod_3(text, "\\t");
					num = 2021273717;
					continue;
					IL_00de:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1495094337;
					continue;
					IL_00cb:
					num = ((int)num2 * -1092626469) ^ 0x5173C04B;
					continue;
					IL_0094:
					text = JSONNode.smethod_3(text, "\\n");
					num = 130083829;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		int num13 = default(int);
		char c = default(char);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		JSONNode jSONNode = default(JSONNode);
		char c4 = default(char);
		char c2 = default(char);
		string text2 = default(string);
		bool flag = default(bool);
		string text = default(string);
		bool flag6 = default(bool);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		string s = default(string);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		char c3 = default(char);
		bool flag2 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1739483245;
			while (true)
			{
				uint num2;
				int num31;
				int num35;
				switch ((num2 = (uint)num ^ 0x715BEFD2u) % 144u)
				{
				case 143u:
					num13++;
					num = 2085653289;
					continue;
				case 142u:
					switch (c)
					{
					case '\\':
						break;
					default:
						goto IL_002a;
					case '[':
						goto IL_0034;
					case ']':
						goto IL_0054;
					}
					goto case 143u;
				case 49u:
					goto IL_0034;
				case 103u:
					goto IL_0054;
				case 141u:
				{
					stack.Push(new JSONArray());
					int num8;
					if (jSONNode != null)
					{
						num = 1253333888;
						num8 = 1253333888;
					}
					else
					{
						num = 556482040;
						num8 = 556482040;
					}
					continue;
				}
				case 140u:
					num = (int)((num2 * 1121098424) ^ 0x1C61BCE8);
					continue;
				case 139u:
				{
					c4 = JSONNode.smethod_2(aJSON, num13);
					char c5 = c4;
					c2 = c5;
					int num47;
					int num48;
					if ((uint)c2 <= 102u)
					{
						num47 = 354810499;
						num48 = 354810499;
					}
					else
					{
						num47 = 48806717;
						num48 = 48806717;
					}
					num = num47 ^ (int)(num2 * 280862317);
					continue;
				}
				case 138u:
				{
					int num15;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 202016120;
						num15 = 202016120;
					}
					else
					{
						num = 432100681;
						num15 = 432100681;
					}
					continue;
				}
				case 137u:
				{
					int num6;
					int num7;
					if (jSONNode is JSONArray)
					{
						num6 = 397902982;
						num7 = 397902982;
					}
					else
					{
						num6 = 1280794955;
						num7 = 1280794955;
					}
					num = num6 ^ (int)(num2 * 1809435499);
					continue;
				}
				case 136u:
					flag = num13 < JSONNode.smethod_4(aJSON);
					num = 1757151460;
					continue;
				case 135u:
					num = (int)(num2 * 978537226) ^ -2079050014;
					continue;
				case 134u:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = 1504177317;
					continue;
				case 133u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = ((int)num2 * -1721934947) ^ -1852497034;
					continue;
				case 4u:
				case 30u:
				case 58u:
				case 85u:
				case 132u:
					num13++;
					num = 1707514650;
					continue;
				case 130u:
				{
					int num36;
					int num37;
					if (flag6)
					{
						num36 = 930703246;
						num37 = 930703246;
					}
					else
					{
						num36 = 1423797705;
						num37 = 1423797705;
					}
					num = num36 ^ (int)(num2 * 1435137078);
					continue;
				}
				case 129u:
					num = ((int)num2 * -2053816289) ^ 0x32147F9B;
					continue;
				case 128u:
				{
					int num26;
					if (c2 != 'n')
					{
						num = 319205344;
						num26 = 319205344;
					}
					else
					{
						num = 1408194528;
						num26 = 1408194528;
					}
					continue;
				}
				case 127u:
				{
					int num18;
					if (flag3)
					{
						num = 1031084529;
						num18 = 1031084529;
					}
					else
					{
						num = 286041345;
						num18 = 286041345;
					}
					continue;
				}
				case 126u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = (int)(num2 * 803164012) ^ -193774560;
					continue;
				case 125u:
				{
					int num56;
					int num57;
					if ((uint)c > 44u)
					{
						num56 = 1598046306;
						num57 = 1598046306;
					}
					else
					{
						num56 = 1412918809;
						num57 = 1412918809;
					}
					num = num56 ^ ((int)num2 * -121603017);
					continue;
				}
				case 124u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1896516982) ^ 0x4B2BDD1F;
					continue;
				case 123u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = (int)((num2 * 328739563) ^ 0x2C5CFEE1);
					continue;
				case 122u:
				{
					int num51;
					int num52;
					if (!flag9)
					{
						num51 = -410060488;
						num52 = -410060488;
					}
					else
					{
						num51 = -318192803;
						num52 = -318192803;
					}
					num = num51 ^ (int)(num2 * 1206450987);
					continue;
				}
				case 121u:
					num = (int)(num2 * 925520413) ^ -1192071592;
					continue;
				case 120u:
				{
					int num43;
					int num44;
					if (flag8)
					{
						num43 = 1796549286;
						num44 = 1796549286;
					}
					else
					{
						num43 = 1661735801;
						num44 = 1661735801;
					}
					num = num43 ^ (int)(num2 * 1938567030);
					continue;
				}
				case 119u:
					text2 = "";
					text = "";
					num = 1681786324;
					continue;
				case 118u:
					num = 185898662;
					continue;
				case 117u:
					num = 556482040;
					continue;
				case 116u:
					num = ((int)num2 * -1478141171) ^ 0x582985FF;
					continue;
				case 115u:
					num = ((int)num2 * -2142931304) ^ 0x7C50BE8C;
					continue;
				case 114u:
					flag8 = flag3;
					num = 221839210;
					continue;
				case 113u:
					num = ((int)num2 * -2081004209) ^ -1576732269;
					continue;
				case 112u:
				{
					int num32;
					int num33;
					if ((uint)c > 32u)
					{
						num32 = 1685310140;
						num33 = 1685310140;
					}
					else
					{
						num32 = 402746168;
						num33 = 402746168;
					}
					num = num32 ^ (int)(num2 * 1772711204);
					continue;
				}
				case 111u:
					num = (int)(num2 * 99648060) ^ -1719530587;
					continue;
				case 109u:
				{
					int num29;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 19037677;
						num29 = 19037677;
					}
					else
					{
						num = 1904561269;
						num29 = 1904561269;
					}
					continue;
				}
				case 108u:
				{
					int num25;
					if (c != '{')
					{
						num = 970374881;
						num25 = 970374881;
					}
					else
					{
						num = 1531416411;
						num25 = 1531416411;
					}
					continue;
				}
				case 107u:
					text = JSONNode.smethod_3(text, "\f");
					num = 2033714776;
					continue;
				case 106u:
					num = (int)(num2 * 1900285396) ^ -131751668;
					continue;
				case 105u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 235189362) ^ -1873223911;
					continue;
				case 104u:
					num = (int)((num2 * 624626275) ^ 0x4CD19268);
					continue;
				case 102u:
					num = ((int)num2 * -1119197571) ^ 0x6BB3E624;
					continue;
				case 101u:
					num = (int)((num2 * 585606107) ^ 0x6BEE2F9A);
					continue;
				case 100u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = (int)(num2 * 763337957) ^ -1230562932;
					continue;
				case 99u:
					num = ((int)num2 * -1326379890) ^ -2019948266;
					continue;
				case 98u:
					goto IL_04eb;
				case 97u:
					num = (int)(num2 * 2019941564) ^ -1058026009;
					continue;
				case 96u:
				{
					int num11;
					int num12;
					if (!(jSONNode is JSONArray))
					{
						num11 = -2081984323;
						num12 = -2081984323;
					}
					else
					{
						num11 = -121592137;
						num12 = -121592137;
					}
					num = num11 ^ ((int)num2 * -2038310232);
					continue;
				}
				case 95u:
					num = 902259909;
					continue;
				case 94u:
				{
					int num5;
					if (c != '"')
					{
						num = 2027487527;
						num5 = 2027487527;
					}
					else
					{
						num = 292064607;
						num5 = 292064607;
					}
					continue;
				}
				case 93u:
				{
					int num58;
					if (c == ',')
					{
						num = 444112989;
						num58 = 444112989;
					}
					else
					{
						num = 687901766;
						num58 = 687901766;
					}
					continue;
				}
				case 92u:
					num = ((int)num2 * -439753969) ^ -522662414;
					continue;
				case 91u:
				{
					int num55;
					if ((uint)c <= 93u)
					{
						num = 1745440163;
						num55 = 1745440163;
					}
					else
					{
						num = 2126627854;
						num55 = 2126627854;
					}
					continue;
				}
				case 90u:
					text2 = "";
					text = "";
					num = 2770155;
					continue;
				case 89u:
					num = (int)((num2 * 136502276) ^ 0x2201D513);
					continue;
				case 88u:
					num13 = 0;
					text = "";
					num = ((int)num2 * -1528824051) ^ 0x3D2A4957;
					continue;
				case 87u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 707974376) ^ -2067077451;
					continue;
				case 86u:
					num = (int)((num2 * 677375271) ^ 0x8B82322);
					continue;
				case 84u:
					num = (int)(num2 * 1691757847) ^ -804611624;
					continue;
				case 83u:
					num = ((int)num2 * -190471515) ^ -697979265;
					continue;
				case 82u:
					text = JSONNode.smethod_3(text, "\n");
					num = 6605124;
					continue;
				case 81u:
					text2 = "";
					text = "";
					flag9 = stack.Count > 0;
					num = 1699204728;
					continue;
				case 80u:
					goto IL_06a9;
				case 79u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num13 += 4;
					num = (int)((num2 * 1369408852) ^ 0x672742A9);
					continue;
				case 78u:
				{
					int num53;
					int num54;
					if (c2 != 'b')
					{
						num53 = 791722520;
						num54 = 791722520;
					}
					else
					{
						num53 = 885906950;
						num54 = 885906950;
					}
					num = num53 ^ (int)(num2 * 337631020);
					continue;
				}
				case 77u:
					flag3 = !flag3;
					num = 1825576904;
					continue;
				case 76u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = 1581806830;
					continue;
				case 75u:
				{
					int num49;
					int num50;
					if (flag3)
					{
						num49 = -1893482366;
						num50 = -1893482366;
					}
					else
					{
						num49 = -1190240211;
						num50 = -1190240211;
					}
					num = num49 ^ (int)(num2 * 1651728305);
					continue;
				}
				case 74u:
				{
					int num45;
					int num46;
					if (!(jSONNode != null))
					{
						num45 = 591342418;
						num46 = 591342418;
					}
					else
					{
						num45 = 1790610448;
						num46 = 1790610448;
					}
					num = num45 ^ (int)(num2 * 651157582);
					continue;
				}
				case 73u:
				{
					int num41;
					int num42;
					if (!flag3)
					{
						num41 = 908660952;
						num42 = 908660952;
					}
					else
					{
						num41 = 641067783;
						num42 = 641067783;
					}
					num = num41 ^ (int)(num2 * 1196548330);
					continue;
				}
				case 72u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -643390316) ^ -38470501;
					continue;
				case 71u:
					jSONNode.Add(text);
					num = (int)((num2 * 584006052) ^ 0x4CD0C9C4);
					continue;
				case 69u:
					goto IL_0801;
				case 68u:
				{
					int num39;
					int num40;
					if (flag7)
					{
						num39 = 329991271;
						num40 = 329991271;
					}
					else
					{
						num39 = 1717877360;
						num40 = 1717877360;
					}
					num = num39 ^ ((int)num2 * -2051931555);
					continue;
				}
				case 67u:
					num = ((int)num2 * -1688421257) ^ -776071049;
					continue;
				case 66u:
					jSONNode = null;
					num = ((int)num2 * -867109686) ^ -2044682402;
					continue;
				case 65u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -905426737) ^ -1004555399;
					continue;
				case 64u:
					num = (int)((num2 * 1861765746) ^ 0x458C5F97);
					continue;
				case 63u:
				{
					int num38;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 943614111;
						num38 = 943614111;
					}
					else
					{
						num = 127906551;
						num38 = 127906551;
					}
					continue;
				}
				case 62u:
					num = ((int)num2 * -481181966) ^ -778371647;
					continue;
				case 61u:
					stack.Pop();
					flag5 = JSONNode.smethod_6(text, "");
					num = 1091591987;
					continue;
				case 60u:
					num = (int)(num2 * 1040576856) ^ -579963768;
					continue;
				case 59u:
					s = JSONNode.smethod_8(aJSON, num13 + 1, 4);
					num = (int)(num2 * 817970660) ^ -732363135;
					continue;
				case 57u:
				{
					int num34;
					if (!flag3)
					{
						num = 1040888236;
						num34 = 1040888236;
					}
					else
					{
						num = 1672539523;
						num34 = 1672539523;
					}
					continue;
				}
				case 56u:
					goto IL_0942;
				case 54u:
					num = (int)(num2 * 533972175) ^ -1986156515;
					continue;
				case 53u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 443714445) ^ 0x715BF192);
					continue;
				case 52u:
					num = (int)(num2 * 1387387806) ^ -514457647;
					continue;
				case 51u:
					flag6 = JSONNode.smethod_6(text, "");
					num = 299784736;
					continue;
				case 50u:
					num = (int)((num2 * 601469118) ^ 0x2008C406);
					continue;
				case 48u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = ((int)num2 * -431361717) ^ -883944805;
					continue;
				case 47u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -89296334) ^ 0x68F5151E;
					continue;
				case 46u:
					text2 = JSONNode.smethod_5(text2);
					flag4 = jSONNode is JSONArray;
					num = (int)((num2 * 1144362877) ^ 0x573013B4);
					continue;
				case 45u:
					text2 = "";
					flag3 = false;
					num = ((int)num2 * -1379158064) ^ 0x5821FBD4;
					continue;
				case 44u:
					num = (int)(num2 * 108896662) ^ -133262484;
					continue;
				case 43u:
					c3 = JSONNode.smethod_2(aJSON, num13);
					num = ((int)num2 * -1037877674) ^ -372212145;
					continue;
				case 42u:
					flag2 = JSONNode.smethod_6(text2, "");
					num = 1636606010;
					continue;
				case 41u:
					num = ((int)num2 * -819064246) ^ 0x3798C892;
					continue;
				case 40u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 966230632) ^ -474972574;
					continue;
				case 39u:
					num = (int)((num2 * 778756452) ^ 0x1D1865B8);
					continue;
				case 38u:
				{
					int num30;
					if (stack.Count == 0)
					{
						num = 1004827685;
						num30 = 1004827685;
					}
					else
					{
						num = 1241023263;
						num30 = 1241023263;
					}
					continue;
				}
				case 37u:
					num = ((int)num2 * -1786796185) ^ 0x1950522C;
					continue;
				case 36u:
					num = (int)((num2 * 1133712216) ^ 0x2B9E530);
					continue;
				case 35u:
					num = (int)(num2 * 1208255367) ^ -1808393051;
					continue;
				case 34u:
					num = (int)((num2 * 50640443) ^ 0x65C630CA);
					continue;
				case 33u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = (int)(num2 * 1114253123) ^ -647945484;
					continue;
				case 32u:
					jSONNode.Add(text);
					num = ((int)num2 * -105680155) ^ -1041066591;
					continue;
				case 31u:
					num = 1038171006;
					continue;
				case 29u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 689153780) ^ 0x4BB964F);
					continue;
				case 28u:
					text = JSONNode.smethod_3(text, "\b");
					num = 540836374;
					continue;
				case 27u:
					text2 = text;
					text = "";
					num = 551660654;
					continue;
				case 26u:
					num = 1753947939;
					continue;
				case 25u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -58646614) ^ 0x10208D12;
					continue;
				case 24u:
					num = (int)((num2 * 1930668243) ^ 0x204109C);
					continue;
				case 23u:
					num = 1032157561;
					continue;
				case 22u:
					num = ((int)num2 * -675145365) ^ -991610074;
					continue;
				case 21u:
				{
					int num27;
					int num28;
					if (jSONNode is JSONArray)
					{
						num27 = 799711237;
						num28 = 799711237;
					}
					else
					{
						num27 = 147076927;
						num28 = 147076927;
					}
					num = num27 ^ (int)(num2 * 175208171);
					continue;
				}
				case 20u:
					goto IL_0c75;
				case 19u:
				{
					int num24;
					if (c2 != 'f')
					{
						num = 614265380;
						num24 = 614265380;
					}
					else
					{
						num = 877416041;
						num24 = 877416041;
					}
					continue;
				}
				case 18u:
					num = (int)(num2 * 1670037662) ^ -677856195;
					continue;
				case 17u:
				{
					int num22;
					int num23;
					if (flag5)
					{
						num22 = 2031171967;
						num23 = 2031171967;
					}
					else
					{
						num22 = 1813611839;
						num23 = 1813611839;
					}
					num = num22 ^ (int)(num2 * 802156956);
					continue;
				}
				case 16u:
				{
					int num20;
					int num21;
					if (!flag4)
					{
						num20 = -598937585;
						num21 = -598937585;
					}
					else
					{
						num20 = -34473874;
						num21 = -34473874;
					}
					num = num20 ^ ((int)num2 * -33058968);
					continue;
				}
				case 15u:
					c = c3;
					num = (int)(num2 * 3608283) ^ -316341078;
					continue;
				case 14u:
					stack.Push(new JSONClass());
					num = 1766056398;
					continue;
				case 13u:
					switch (c2)
					{
					case 's':
						break;
					case 'u':
						goto IL_06a9;
					case 'r':
						goto IL_0801;
					case 't':
						goto IL_0c75;
					default:
						goto IL_0d58;
					}
					goto case 134u;
				case 12u:
					num = ((int)num2 * -1747705687) ^ 0x54CE20D4;
					continue;
				case 11u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 586018464) ^ -1650114664;
					continue;
				case 10u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_04eb;
					case '\t':
						goto IL_0942;
					default:
						goto IL_0db4;
					}
					goto case 4u;
				case 9u:
				{
					int num19;
					if (c == ' ')
					{
						num = 1603521690;
						num19 = 1603521690;
					}
					else
					{
						num = 615343089;
						num19 = 615343089;
					}
					continue;
				}
				case 8u:
				{
					int num16;
					int num17;
					if (flag2)
					{
						num16 = 1128408802;
						num17 = 1128408802;
					}
					else
					{
						num16 = 1013432341;
						num17 = 1013432341;
					}
					num = num16 ^ ((int)num2 * -1942906287);
					continue;
				}
				case 7u:
				{
					int num14;
					if (c == '}')
					{
						num = 849879557;
						num14 = 849879557;
					}
					else
					{
						num = 328727825;
						num14 = 328727825;
					}
					continue;
				}
				case 6u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1767680677;
						num10 = 1767680677;
					}
					else
					{
						num9 = 632205163;
						num10 = 632205163;
					}
					num = num9 ^ (int)(num2 * 607533240);
					continue;
				}
				case 5u:
					num = (int)(num2 * 715756225) ^ -1938448611;
					continue;
				case 3u:
					num = (int)(num2 * 381021952) ^ -2115435227;
					continue;
				case 2u:
					num = ((int)num2 * -1471356126) ^ -1985529221;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (c != ':')
					{
						num3 = 1843302289;
						num4 = 1843302289;
					}
					else
					{
						num3 = 369966017;
						num4 = 369966017;
					}
					num = num3 ^ (int)(num2 * 1429622497);
					continue;
				}
				case 0u:
					result = jSONNode;
					num = 532090860;
					continue;
				case 70u:
					break;
				case 55u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 131u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_04eb:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num13).ToString());
					num = 1825576904;
					continue;
					IL_0db4:
					num = ((int)num2 * -656468329) ^ -1892681376;
					continue;
					IL_0d58:
					num = 66122538;
					continue;
					IL_0c75:
					text = JSONNode.smethod_3(text, "\t");
					num = 2095778897;
					continue;
					IL_002a:
					num = 1054648122;
					continue;
					IL_0942:
					if (!flag3)
					{
						num = 325521479;
						num31 = 325521479;
					}
					else
					{
						num = 725384311;
						num31 = 725384311;
					}
					continue;
					IL_0054:
					flag7 = flag3;
					num = 2136226966;
					continue;
					IL_0034:
					if (flag3)
					{
						num = 738133054;
						num35 = 738133054;
					}
					else
					{
						num = 393376783;
						num35 = 393376783;
					}
					continue;
					IL_0801:
					text = JSONNode.smethod_3(text, "\r");
					num = 1696819054;
					continue;
					IL_06a9:
					num = 1364009001;
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
			int num = -722667801;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC5256F8u) % 4u)
				{
				case 3u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -223943051) ^ -1799938162;
					continue;
				case 1u:
					Serialize(aWriter);
					num = (int)((num2 * 837882181) ^ 0x71EBEDB3);
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
				int num = -667781637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x95D46142u) % 4u)
					{
					case 1u:
						SaveToStream(fileStream);
						num = (int)(num2 * 44200870) ^ -1471716404;
						continue;
					case 0u:
						num = (int)((num2 * 692219128) ^ 0x31320268);
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00b5:
					int num3 = -1973931479;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x95D46142u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 847367417) ^ -518902151;
							continue;
						case 0u:
							num3 = (int)(num2 * 2036240472) ^ -120598025;
							continue;
						default:
							goto end_IL_0094;
						case 2u:
							break;
						case 1u:
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
				int num = 1936019387;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x107940F7u) % 7u)
					{
					case 6u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -1990099780) ^ -1146363435;
						continue;
					case 4u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 979505077) ^ -202067620;
						continue;
					case 3u:
						num = (int)((num2 * 957889602) ^ 0x612041DA);
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1162725294) ^ 0x739BCA78;
						continue;
					case 0u:
						num = ((int)num2 * -1222728327) ^ 0x1C60528E;
						continue;
					case 5u:
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
					IL_00f5:
					int num3 = 1982435897;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x107940F7u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)(num2 * 1998913067) ^ -166178876;
							continue;
						case 1u:
							num3 = ((int)num2 * -545498716) ^ -1264319193;
							continue;
						default:
							goto end_IL_00d4;
						case 3u:
							break;
						case 0u:
							goto end_IL_00d4;
						}
						goto IL_00f5;
						continue;
						end_IL_00d4:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		int num7 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num5 = default(int);
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		JSONNode aItem = default(JSONNode);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num8 = default(int);
		int num6 = default(int);
		string aKey = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -389251821;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85F6A29Bu) % 41u)
				{
				case 40u:
					num7 = 0;
					num = (int)((num2 * 1289968894) ^ 0x3089FA14);
					continue;
				case 39u:
					jSONArray = new JSONArray();
					num5 = 0;
					num = ((int)num2 * -521804707) ^ 0x1D62FDF8;
					continue;
				case 38u:
					result = jSONClass;
					num = ((int)num2 * -795707975) ^ -283006607;
					continue;
				case 37u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1954915859) ^ -827183021;
					continue;
				case 36u:
					result = jSONArray;
					num = (int)((num2 * 1584110901) ^ 0x154189E9);
					continue;
				case 35u:
					num = -1626053502;
					continue;
				case 34u:
					num = -1019397044;
					continue;
				case 33u:
					aItem = Deserialize(aReader);
					num = (int)((num2 * 1177586645) ^ 0x721D3D82);
					continue;
				case 32u:
					jSONArray.Add(Deserialize(aReader));
					num = -1319909138;
					continue;
				case 30u:
					num = (int)(num2 * 150321725) ^ -1831616731;
					continue;
				case 29u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)((num2 * 1540460745) ^ 0x1BE19F97);
					continue;
				case 28u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.IntValue:
						break;
					default:
						goto IL_011a;
					case JSONBinaryTag.Array:
						goto IL_012d;
					case JSONBinaryTag.Class:
						goto IL_0137;
					case JSONBinaryTag.Value:
						goto IL_0141;
					case JSONBinaryTag.DoubleValue:
						goto IL_014b;
					case JSONBinaryTag.BoolValue:
						goto IL_0162;
					case JSONBinaryTag.FloatValue:
						goto IL_016c;
					}
					goto case 34u;
				case 16u:
					goto IL_012d;
				case 24u:
					goto IL_0137;
				case 12u:
					goto IL_0141;
				case 17u:
					goto IL_014b;
				case 5u:
					goto IL_0162;
				case 1u:
					goto IL_016c;
				case 27u:
					num = (int)((num2 * 897659442) ^ 0x28F322F9);
					continue;
				case 26u:
				{
					int num9;
					if (num7 >= num8)
					{
						num = -37240295;
						num9 = -37240295;
					}
					else
					{
						num = -377133733;
						num9 = -377133733;
					}
					continue;
				}
				case 25u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -487504813) ^ -959480353;
					continue;
				case 22u:
					num = -423132988;
					continue;
				case 21u:
					num = (int)((num2 * 1599362206) ^ 0x4D3D83C6);
					continue;
				case 19u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -1695454874) ^ 0x3FD01EB4;
					continue;
				case 18u:
					num5++;
					num = ((int)num2 * -1045090810) ^ -273327878;
					continue;
				case 15u:
					num = ((int)num2 * -1998375268) ^ -755728732;
					continue;
				case 14u:
					num6 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 777396785) ^ 0x6163BF50);
					continue;
				case 13u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)(num2 * 631266330) ^ -968354768;
					continue;
				case 11u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1684415607) ^ 0x2972610;
					continue;
				case 10u:
					num8 = JSONNode.smethod_21(aReader);
					num = (int)(num2 * 253968496) ^ -922123283;
					continue;
				case 9u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1281770084) ^ 0x244D809D;
					continue;
				case 8u:
					num = (int)(num2 * 135844502) ^ -1549072809;
					continue;
				case 7u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)((num2 * 400426200) ^ 0x11F926ED);
					continue;
				case 6u:
					num7++;
					num = (int)((num2 * 137809431) ^ 0x6A227743);
					continue;
				case 4u:
					num = ((int)num2 * -1591983119) ^ 0x237EF459;
					continue;
				case 3u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1927653574) ^ -86511284;
					continue;
				case 2u:
					flag = num5 < num6;
					num = -1371075378;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 775906314;
						num4 = 775906314;
					}
					else
					{
						num3 = 762590714;
						num4 = 762590714;
					}
					num = num3 ^ ((int)num2 * -1799849247);
					continue;
				}
				case 23u:
					break;
				case 31u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_016c:
					num = -1840155155;
					continue;
					IL_0162:
					num = -1711216751;
					continue;
					IL_014b:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -2072818019;
					continue;
					IL_0141:
					num = -832447317;
					continue;
					IL_0137:
					num = -1538628178;
					continue;
					IL_012d:
					num = -302603657;
					continue;
					IL_011a:
					num = ((int)num2 * -1525940533) ^ -790388574;
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
				int num = 1374879197;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x32C70C4Au) % 3u)
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
					result = Deserialize(binaryReader);
					num = (int)(num2 * 845146467) ^ -1991301236;
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
					int num3 = 1223825215;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x32C70C4Au) % 3u)
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
						num3 = (int)(num2 * 1539107869) ^ -1218926337;
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
				int num = -641602912;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C2CCE6Cu) % 3u)
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
					num = ((int)num2 * -1906395878) ^ -1976311654;
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
					int num3 = -895393950;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x8C2CCE6Cu) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 1194553171) ^ -1336432729;
							continue;
						case 1u:
							num3 = ((int)num2 * -802424603) ^ 0x28718319;
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
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1547273784;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x699FD8DAu) % 6u)
				{
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1905511546) ^ -2147317095;
					continue;
				case 4u:
					num = (int)((num2 * 211236088) ^ 0x5016C145);
					continue;
				case 3u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 857079260) ^ 0x2710F780);
					continue;
				case 2u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -1743504732) ^ -932147907;
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
			int num = 188858848;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1358126u) % 3u)
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
				num = ((int)num2 * -139580251) ^ -957382273;
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
