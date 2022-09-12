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
				int num = -1152021812;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCE51F0D5u) % 3u)
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
					num = (int)(num2 * 963364295) ^ -1116213526;
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
				int num = 2105101093;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BA7DBu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 862859000) ^ -1969887354;
						continue;
					case 2u:
						result = null;
						num = (int)((num2 * 533883567) ^ 0x79B7BD26);
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

	public virtual string Value
	{
		get
		{
			return "";
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
				int num = -282655551;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF18B6F7u) % 3u)
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
					num = ((int)num2 * -157169514) ^ 0x75237FA0;
				}
			}
		}
	}

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
			bool flag = default(bool);
			int result = default(int);
			int result2 = default(int);
			while (true)
			{
				int num = 1001173072;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC61EE7Cu) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1689978499;
							num4 = 1689978499;
						}
						else
						{
							num3 = 1404660036;
							num4 = 1404660036;
						}
						num = num3 ^ (int)(num2 * 1578599298);
						continue;
					}
					case 6u:
						result = result2;
						num = (int)((num2 * 918037454) ^ 0x7785B928);
						continue;
					case 5u:
						num = (int)(num2 * 1125638395) ^ -442140397;
						continue;
					case 4u:
						result2 = 0;
						num = ((int)num2 * -987287443) ^ 0x3FC63403;
						continue;
					case 3u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -225362700) ^ 0xBAD6147;
						continue;
					case 1u:
						result = 0;
						num = 785692481;
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
			float result = 0f;
			float result2 = default(float);
			while (true)
			{
				int num = 133680874;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A9BC4D6u) % 7u)
					{
					case 6u:
						result2 = 0f;
						num = 2125132200;
						continue;
					case 5u:
						num = (int)(num2 * 1867675535) ^ -1085505464;
						continue;
					case 4u:
						result2 = result;
						num = (int)((num2 * 792885854) ^ 0x3753CE86);
						continue;
					case 3u:
						num = ((int)num2 * -836374905) ^ -1114828112;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
						{
							num3 = -428649283;
							num4 = -428649283;
						}
						else
						{
							num3 = -599823269;
							num4 = -599823269;
						}
						num = num3 ^ (int)(num2 * 317489552);
						continue;
					}
					case 2u:
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
				int num = 2142634152;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E9853AEu) % 8u)
					{
					case 6u:
						result2 = 0.0;
						num = ((int)num2 * -1104779710) ^ -248818442;
						continue;
					case 5u:
						result = result2;
						num = ((int)num2 * -662353717) ^ -1877330541;
						continue;
					case 4u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -2017444367) ^ 0x77E664BA;
						continue;
					case 2u:
						num = (int)(num2 * 897362655) ^ -241694397;
						continue;
					case 1u:
						result = 0.0;
						num = 660039197;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1414334673;
							num4 = -1414334673;
						}
						else
						{
							num3 = -821631213;
							num4 = -821631213;
						}
						num = num3 ^ ((int)num2 * -523369295);
						continue;
					}
					case 7u:
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
				int num = 1086713464;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D2CB71u) % 3u)
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
					num = ((int)num2 * -1156790092) ^ 0x680BE233;
				}
			}
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
				int num = 432320635;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11882255u) % 7u)
					{
					case 6u:
						flag = bool.TryParse(Value, out result);
						num = (int)((num2 * 770534696) ^ 0x6AAEF493);
						continue;
					case 5u:
						num = (int)(num2 * 1954977224) ^ -771788896;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 717718877;
							num4 = 717718877;
						}
						else
						{
							num3 = 683210863;
							num4 = 683210863;
						}
						num = num3 ^ (int)(num2 * 2016008547);
						continue;
					}
					case 2u:
						result2 = result;
						num = ((int)num2 * -2055791283) ^ -681704182;
						continue;
					case 1u:
						result2 = !JSONNode.smethod_1(Value);
						num = 1469450504;
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
			while (true)
			{
				int num = 106316957;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B4A53CBu) % 3u)
					{
					case 1u:
						goto IL_0017;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0017:
					num = ((int)num2 * -626465414) ^ 0x72A117B5;
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
				int num = 2110016458;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x708E2C97u) % 3u)
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
					num = (int)((num2 * 1277387497) ^ 0x180E417C);
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
				int num = -623516304;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9EEC15BDu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1890728151) ^ -1699753694;
						continue;
					case 1u:
						result = this as JSONClass;
						num = ((int)num2 * -895550179) ^ -1550923357;
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
		Add("", aItem);
		while (true)
		{
			int num = 1994805876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CD4DF5Au) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -512457849) ^ 0x30F73E25;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 112916098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A3CD8E8u) % 4u)
				{
				case 2u:
					result = null;
					num = ((int)num2 * -1523499408) ^ 0x451727F1;
					continue;
				case 1u:
					num = (int)((num2 * 23098843) ^ 0x734AD47F);
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

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1275158260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3ABF563u) % 3u)
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
				num = ((int)num2 * -579257093) ^ -2033703502;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -793236438;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB397308Au) % 3u)
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
				num = ((int)num2 * -682773060) ^ -476929190;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -2093781009;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBBA33F6u) % 3u)
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
				num = ((int)num2 * -812285030) ^ 0x239BD355;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -2100012870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE25EAB1Bu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -812262148) ^ -1295389895;
					continue;
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -396498511) ^ 0x27976031;
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = new JSONData(s);
		while (true)
		{
			int num = 1161921045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61A67D6Fu) % 3u)
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
				num = ((int)num2 * -143404655) ^ -289369189;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		if (!(d == null))
		{
			goto IL_001b;
		}
		object obj = null;
		goto IL_0047;
		IL_0041:
		obj = d.Value;
		goto IL_0047;
		IL_001b:
		int num = -487005771;
		goto IL_0020;
		IL_0020:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x85D507F3u) % 4u)
			{
			case 3u:
				num = (int)((num2 * 1990248202) ^ 0x39A19414);
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_001b;
		IL_0047:
		result = (string)obj;
		num = -1818011532;
		goto IL_0020;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -357672225;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xFF0E8D4Fu) % 9u)
				{
				case 7u:
					num = ((int)num2 * -362802795) ^ 0x7C255491;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1659586588;
						num5 = 1659586588;
					}
					else
					{
						num4 = 1531256442;
						num5 = 1531256442;
					}
					num = num4 ^ ((int)num2 * -1473985675);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1867162366) ^ -684967356;
					continue;
				case 4u:
					result = (object)a == b;
					num = -1043095962;
					continue;
				case 3u:
					if (b == null)
					{
						num = (int)((num2 * 1074709552) ^ 0x17C22C2E);
						continue;
					}
					num3 = 0;
					goto IL_0067;
				case 2u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0067;
				case 1u:
					result = true;
					num = (int)(num2 * 353590822) ^ -1756512573;
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_0067:
					flag = (byte)num3 != 0;
					num = -1962079718;
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
		return (object)this == obj;
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = 215343759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40E18334u) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = ((int)num2 * -2127210287) ^ -243041613;
					continue;
				case 0u:
					num = ((int)num2 * -1545613810) ^ -1733351607;
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
		string text = "";
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		char c = default(char);
		string result = default(string);
		while (true)
		{
			int num = -205089413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB61B128u) % 33u)
				{
				case 32u:
				{
					c2 = JSONNode.smethod_2(string_, num3);
					char c3 = c2;
					c = c3;
					num = -550714006;
					continue;
				}
				case 31u:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -1191848943;
					continue;
				case 30u:
				{
					int num5;
					if (c != '"')
					{
						num = -1319989807;
						num5 = -1319989807;
					}
					else
					{
						num = -1027410610;
						num5 = -1027410610;
					}
					continue;
				}
				case 29u:
					goto IL_005e;
				case 28u:
					num = (int)((num2 * 1446113208) ^ 0x6E249584);
					continue;
				case 27u:
					num = ((int)num2 * -1049911086) ^ -814890988;
					continue;
				case 26u:
					goto IL_009a;
				case 25u:
				{
					int num6;
					if (c != '\\')
					{
						num = -641669281;
						num6 = -641669281;
					}
					else
					{
						num = -2056400365;
						num6 = -2056400365;
					}
					continue;
				}
				case 24u:
					result = text;
					num = ((int)num2 * -251169761) ^ 0x71E89B64;
					continue;
				case 23u:
					num = (int)(num2 * 422423191) ^ -1925711429;
					continue;
				case 22u:
					num = (int)(num2 * 23720153) ^ -1898213289;
					continue;
				case 21u:
					goto IL_010e;
				case 20u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -94833023;
					continue;
				case 19u:
					goto IL_013a;
				case 18u:
					num = ((int)num2 * -630644813) ^ -420129605;
					continue;
				case 17u:
					num = (int)(num2 * 1429634508) ^ -1752106632;
					continue;
				case 16u:
					num = ((int)num2 * -213649060) ^ -52423326;
					continue;
				case 15u:
					num = ((int)num2 * -419600414) ^ -723126121;
					continue;
				case 14u:
					switch (c)
					{
					case '\v':
						break;
					case '\n':
						goto IL_005e;
					case '\r':
						goto IL_009a;
					case '\f':
						goto IL_010e;
					case '\t':
						goto IL_013a;
					default:
						goto IL_01bd;
					case '\b':
						goto IL_01d0;
					}
					goto case 31u;
				case 1u:
					goto IL_01d0;
				case 13u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -585252053;
					continue;
				case 12u:
					num = (int)((num2 * 1913269480) ^ 0x4DCCAE54);
					continue;
				case 11u:
					string_ = aText;
					num = ((int)num2 * -1503879450) ^ -1980602716;
					continue;
				case 10u:
					num = (int)(num2 * 1855439212) ^ -210832765;
					continue;
				case 8u:
					num = (int)(num2 * 1475697422) ^ -1720835617;
					continue;
				case 7u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -1895693117;
						num4 = -1895693117;
					}
					else
					{
						num = -2080632176;
						num4 = -2080632176;
					}
					continue;
				}
				case 6u:
					num = ((int)num2 * -80509894) ^ -1919423352;
					continue;
				case 5u:
					num3++;
					num = (int)((num2 * 353661437) ^ 0x4C14670D);
					continue;
				case 4u:
					num = (int)(num2 * 1536742073) ^ -115385025;
					continue;
				case 3u:
					num = -438688121;
					continue;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 2052202198) ^ 0x347D84BD);
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_005e:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1249725802;
					continue;
					IL_01d0:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1698158936;
					continue;
					IL_01bd:
					num = ((int)num2 * -28510800) ^ -1815138875;
					continue;
					IL_013a:
					text = JSONNode.smethod_3(text, "\\t");
					num = -542444448;
					continue;
					IL_010e:
					text = JSONNode.smethod_3(text, "\\f");
					num = -112114093;
					continue;
					IL_009a:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1920879986;
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
		string text2 = default(string);
		char c3 = default(char);
		bool flag5 = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		string text = default(string);
		bool flag8 = default(bool);
		bool flag3 = default(bool);
		int num10 = default(int);
		string s = default(string);
		char c5 = default(char);
		char c = default(char);
		bool flag11 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		char c2 = default(char);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num = 286714949;
			while (true)
			{
				uint num2;
				int num33;
				switch ((num2 = (uint)num ^ 0x457E1DD6u) % 155u)
				{
				case 154u:
					text2 = JSONNode.smethod_3(text2, c3.ToString());
					num = 499297383;
					continue;
				case 153u:
				{
					int num36;
					int num37;
					if (!flag5)
					{
						num36 = -90678;
						num37 = -90678;
					}
					else
					{
						num36 = -411823023;
						num37 = -411823023;
					}
					num = num36 ^ (int)(num2 * 258657464);
					continue;
				}
				case 152u:
				{
					int num41;
					if (!flag7)
					{
						num = 685407617;
						num41 = 685407617;
					}
					else
					{
						num = 1538346055;
						num41 = 1538346055;
					}
					continue;
				}
				case 151u:
					num = (int)(num2 * 2072344388) ^ -818893073;
					continue;
				case 150u:
					num = ((int)num2 * -696923299) ^ -253229349;
					continue;
				case 149u:
					num = ((int)num2 * -905210031) ^ -814740515;
					continue;
				case 147u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 904281823;
						num5 = 904281823;
					}
					else
					{
						num4 = 2122839050;
						num5 = 2122839050;
					}
					num = num4 ^ (int)(num2 * 421249195);
					continue;
				}
				case 146u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 744434070) ^ 0x194E210C);
					continue;
				case 145u:
					num = ((int)num2 * -1980701117) ^ -1280674184;
					continue;
				case 144u:
					num = (int)((num2 * 208289021) ^ 0x1B0FDB19);
					continue;
				case 143u:
					num = ((int)num2 * -1847335763) ^ 0x67A60136;
					continue;
				case 141u:
					num = 748957522;
					continue;
				case 140u:
					num = (int)((num2 * 1291134281) ^ 0x9DD3874);
					continue;
				case 139u:
				{
					int num45;
					int num46;
					if (!flag8)
					{
						num45 = 1845379896;
						num46 = 1845379896;
					}
					else
					{
						num45 = 1065555855;
						num46 = 1065555855;
					}
					num = num45 ^ ((int)num2 * -1735706728);
					continue;
				}
				case 138u:
					num = ((int)num2 * -1181716495) ^ 0x581D463B;
					continue;
				case 137u:
				{
					int num31;
					int num32;
					if (flag3)
					{
						num31 = -943329098;
						num32 = -943329098;
					}
					else
					{
						num31 = -62847178;
						num32 = -62847178;
					}
					num = num31 ^ ((int)num2 * -1981434993);
					continue;
				}
				case 136u:
					num = ((int)num2 * -25537453) ^ -697651141;
					continue;
				case 135u:
					flag5 = num10 < JSONNode.smethod_4(aJSON);
					num = 345371452;
					continue;
				case 134u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 499297383;
					continue;
				case 133u:
				{
					int num8;
					int num9;
					if (!(jSONNode is JSONArray))
					{
						num8 = -325897264;
						num9 = -325897264;
					}
					else
					{
						num8 = -742717414;
						num9 = -742717414;
					}
					num = num8 ^ (int)(num2 * 1430955116);
					continue;
				}
				case 132u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1837976886) ^ 0x2FA97A65;
					continue;
				case 131u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -1034431) ^ -1946786572;
					continue;
				case 130u:
					c5 = JSONNode.smethod_2(aJSON, num10);
					num = ((int)num2 * -522610047) ^ -1101004500;
					continue;
				case 129u:
				{
					int num56;
					int num57;
					if ((uint)c <= 102u)
					{
						num56 = 709830207;
						num57 = 709830207;
					}
					else
					{
						num56 = 2114681041;
						num57 = 2114681041;
					}
					num = num56 ^ ((int)num2 * -1290511791);
					continue;
				}
				case 128u:
					num = (int)((num2 * 1941684705) ^ 0x4323B735);
					continue;
				case 127u:
					stack.Push(new JSONArray());
					num = 508328366;
					continue;
				case 126u:
				{
					int num49;
					int num50;
					if (!flag11)
					{
						num49 = -335924374;
						num50 = -335924374;
					}
					else
					{
						num49 = -352290441;
						num50 = -352290441;
					}
					num = num49 ^ ((int)num2 * -1095764939);
					continue;
				}
				case 125u:
					num = (int)(num2 * 846618205) ^ -569679334;
					continue;
				case 124u:
				{
					int num44;
					if (c == 'f')
					{
						num = 960962622;
						num44 = 960962622;
					}
					else
					{
						num = 1934119368;
						num44 = 1934119368;
					}
					continue;
				}
				case 123u:
					num = ((int)num2 * -180983599) ^ -1772465190;
					continue;
				case 122u:
					num = 1193373989;
					continue;
				case 121u:
					num = (int)(num2 * 501455769) ^ -507886742;
					continue;
				case 120u:
				{
					int num38;
					int num39;
					if (jSONNode is JSONArray)
					{
						num38 = 2100555512;
						num39 = 2100555512;
					}
					else
					{
						num38 = 200533148;
						num39 = 200533148;
					}
					num = num38 ^ ((int)num2 * -1195578833);
					continue;
				}
				case 119u:
					result = jSONNode;
					num = 1652712799;
					continue;
				case 118u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 958042686) ^ -1643040087;
					continue;
				case 117u:
				{
					int num27;
					int num28;
					if (!flag9)
					{
						num27 = 1715690295;
						num28 = 1715690295;
					}
					else
					{
						num27 = 1872420982;
						num28 = 1872420982;
					}
					num = num27 ^ ((int)num2 * -579696444);
					continue;
				}
				case 116u:
					num = ((int)num2 * -804868382) ^ -744650288;
					continue;
				case 115u:
					flag7 = false;
					num = (int)(num2 * 746445408) ^ -1716149961;
					continue;
				case 114u:
					flag4 = JSONNode.smethod_6(text, "");
					num = 165173579;
					continue;
				case 113u:
					num = (int)((num2 * 1869649194) ^ 0x31910670);
					continue;
				case 112u:
					text = "";
					num = 907942646;
					continue;
				case 111u:
					num = (int)((num2 * 2016985525) ^ 0x4FEFB1BC);
					continue;
				case 110u:
					jSONNode.Add(text2);
					num = (int)((num2 * 497802814) ^ 0x5B8DD175);
					continue;
				case 109u:
					switch (c)
					{
					case 's':
						break;
					default:
						goto IL_0496;
					case 'r':
						goto IL_04a0;
					case 't':
						goto IL_04b6;
					case 'u':
						goto IL_04cc;
					}
					goto case 154u;
				case 77u:
					goto IL_04a0;
				case 18u:
					goto IL_04b6;
				case 62u:
					goto IL_04cc;
				case 108u:
					num = (int)((num2 * 1062802963) ^ 0x2CC54691);
					continue;
				case 107u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)(num2 * 968473149) ^ -862111885;
					continue;
				case 106u:
					flag = JSONNode.smethod_6(text2, "");
					num = 1060347870;
					continue;
				case 105u:
					text2 = "";
					jSONNode = stack.Peek();
					num = ((int)num2 * -1591776784) ^ -1401163323;
					continue;
				case 104u:
					num = (int)(num2 * 1576311863) ^ -694596418;
					continue;
				case 103u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 758775983) ^ -545302602;
					continue;
				case 102u:
				{
					int num13;
					int num14;
					if (jSONNode is JSONArray)
					{
						num13 = 1819984881;
						num14 = 1819984881;
					}
					else
					{
						num13 = 304485317;
						num14 = 304485317;
					}
					num = num13 ^ (int)(num2 * 363906443);
					continue;
				}
				case 101u:
					num = (int)((num2 * 312445748) ^ 0x58A643B7);
					continue;
				case 100u:
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -2084589908) ^ -290189806;
					continue;
				case 99u:
				{
					int num60;
					int num61;
					if ((uint)c2 <= 32u)
					{
						num60 = 1262793080;
						num61 = 1262793080;
					}
					else
					{
						num60 = 1450320674;
						num61 = 1450320674;
					}
					num = num60 ^ ((int)num2 * -1034121700);
					continue;
				}
				case 98u:
				{
					int num59;
					if (c2 == '}')
					{
						num = 1433441472;
						num59 = 1433441472;
					}
					else
					{
						num = 112711476;
						num59 = 112711476;
					}
					continue;
				}
				case 10u:
				case 12u:
				case 14u:
				case 95u:
				case 97u:
					num10++;
					num = 997485920;
					continue;
				case 96u:
					num = ((int)num2 * -14233173) ^ -774288745;
					continue;
				case 94u:
				{
					int num58;
					if (!flag7)
					{
						num = 1035539036;
						num58 = 1035539036;
					}
					else
					{
						num = 1740393156;
						num58 = 1740393156;
					}
					continue;
				}
				case 93u:
					num = (int)(num2 * 1337221166) ^ -51030911;
					continue;
				case 92u:
					flag2 = flag7;
					num = 1628746099;
					continue;
				case 91u:
				{
					c2 = c5;
					int num54;
					int num55;
					if ((uint)c2 > 44u)
					{
						num54 = -1826656691;
						num55 = -1826656691;
					}
					else
					{
						num54 = -35148469;
						num55 = -35148469;
					}
					num = num54 ^ ((int)num2 * -536582410);
					continue;
				}
				case 90u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -1806715094) ^ -1987680955;
					continue;
				case 89u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 372904272) ^ 0x1E72ACB6);
					continue;
				case 88u:
				{
					int num53;
					if (c2 != '"')
					{
						num = 1631448934;
						num53 = 1631448934;
					}
					else
					{
						num = 1486513492;
						num53 = 1486513492;
					}
					continue;
				}
				case 87u:
					num = (int)((num2 * 2139505257) ^ 0x2FD3FD67);
					continue;
				case 86u:
					text = "";
					num = 1645752611;
					continue;
				case 85u:
					num = (int)(num2 * 826156206) ^ -1076243954;
					continue;
				case 84u:
				{
					int num51;
					int num52;
					if (!flag10)
					{
						num51 = 1987680323;
						num52 = 1987680323;
					}
					else
					{
						num51 = 830488670;
						num52 = 830488670;
					}
					num = num51 ^ (int)(num2 * 1820799906);
					continue;
				}
				case 83u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 311056467;
					continue;
				case 82u:
					num = ((int)num2 * -13876417) ^ 0x6446D525;
					continue;
				case 81u:
				{
					char c4 = c3;
					c = c4;
					num = ((int)num2 * -1252574416) ^ 0xE06B79;
					continue;
				}
				case 80u:
					goto IL_07d8;
				case 78u:
				{
					int num47;
					int num48;
					if (!flag13)
					{
						num47 = -215583471;
						num48 = -215583471;
					}
					else
					{
						num47 = -441143267;
						num48 = -441143267;
					}
					num = num47 ^ ((int)num2 * -406380724);
					continue;
				}
				case 76u:
				{
					int num43;
					if (c2 != '{')
					{
						num = 949549746;
						num43 = 949549746;
					}
					else
					{
						num = 1472160296;
						num43 = 1472160296;
					}
					continue;
				}
				case 75u:
					text = "";
					num = 342349548;
					continue;
				case 74u:
					num = ((int)num2 * -124502735) ^ 0x282A05F3;
					continue;
				case 73u:
					num = (int)(num2 * 1518795473) ^ -1853121391;
					continue;
				case 72u:
					num = 1841135582;
					continue;
				case 71u:
					text = "";
					num = (int)(num2 * 535274293) ^ -946283129;
					continue;
				case 70u:
				{
					int num42;
					if ((uint)c2 > 93u)
					{
						num = 2086541169;
						num42 = 2086541169;
					}
					else
					{
						num = 2128355502;
						num42 = 2128355502;
					}
					continue;
				}
				case 69u:
					goto IL_08ae;
				case 68u:
					stack.Push(new JSONClass());
					num = 819183330;
					continue;
				case 67u:
					num = (int)((num2 * 539192759) ^ 0x738F274D);
					continue;
				case 66u:
				{
					int num40;
					if (c2 == ',')
					{
						num = 1318402308;
						num40 = 1318402308;
					}
					else
					{
						num = 1084638660;
						num40 = 1084638660;
					}
					continue;
				}
				case 65u:
					stack.Pop();
					flag13 = JSONNode.smethod_6(text2, "");
					num = 2070592073;
					continue;
				case 64u:
				{
					int num34;
					int num35;
					if (flag12)
					{
						num34 = -1157845599;
						num35 = -1157845599;
					}
					else
					{
						num34 = -1841859000;
						num35 = -1841859000;
					}
					num = num34 ^ (int)(num2 * 1633537640);
					continue;
				}
				case 63u:
					num = (int)((num2 * 582890535) ^ 0x31557F0E);
					continue;
				case 61u:
					num = ((int)num2 * -1501735313) ^ -686825989;
					continue;
				case 60u:
					num = 2060539042;
					continue;
				case 59u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 1244713968;
					continue;
				case 58u:
					text = "";
					text2 = "";
					flag11 = stack.Count > 0;
					num = 1908651289;
					continue;
				case 57u:
					flag7 = !flag7;
					num = 1476104718;
					continue;
				case 56u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -89952818) ^ -1890400806;
					continue;
				case 55u:
					c3 = JSONNode.smethod_2(aJSON, num10);
					num = ((int)num2 * -930589850) ^ 0x47698E93;
					continue;
				case 54u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 888547205) ^ 0x22079AD3);
					continue;
				case 53u:
					goto IL_0a26;
				case 52u:
					text2 = "";
					num = (int)((num2 * 2082298921) ^ 0x4FC1CA08);
					continue;
				case 51u:
				{
					int num29;
					int num30;
					if (flag6)
					{
						num29 = 1808838958;
						num30 = 1808838958;
					}
					else
					{
						num29 = 1706501264;
						num30 = 1706501264;
					}
					num = num29 ^ (int)(num2 * 1507661180);
					continue;
				}
				case 50u:
					flag10 = flag7;
					num = (int)(num2 * 232986331) ^ -1173322872;
					continue;
				case 49u:
				{
					int num26;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 576498548;
						num26 = 576498548;
					}
					else
					{
						num = 1442607704;
						num26 = 1442607704;
					}
					continue;
				}
				case 48u:
					flag8 = JSONNode.smethod_6(text, "");
					num = 608289255;
					continue;
				case 47u:
				{
					int num24;
					int num25;
					if (c2 == ':')
					{
						num24 = 270218010;
						num25 = 270218010;
					}
					else
					{
						num24 = 498135179;
						num25 = 498135179;
					}
					num = num24 ^ (int)(num2 * 457703468);
					continue;
				}
				case 45u:
					num = (int)(num2 * 1899856959) ^ -852712579;
					continue;
				case 44u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1184022490) ^ 0x9F536F9;
					continue;
				case 43u:
					num = ((int)num2 * -1320035242) ^ 0x445E0C81;
					continue;
				case 42u:
					num10 += 4;
					num = ((int)num2 * -1703359969) ^ -1785887766;
					continue;
				case 41u:
					num = ((int)num2 * -896726968) ^ -1991286580;
					continue;
				case 40u:
				{
					int num22;
					int num23;
					if (jSONNode != null)
					{
						num22 = 1045865173;
						num23 = 1045865173;
					}
					else
					{
						num22 = 1564337766;
						num23 = 1564337766;
					}
					num = num22 ^ (int)(num2 * 1128855590);
					continue;
				}
				case 39u:
					switch (c2)
					{
					case '[':
						break;
					case ']':
						goto IL_08ae;
					case '\\':
						goto IL_0a26;
					default:
						goto IL_0bc3;
					}
					goto case 94u;
				case 38u:
					num = ((int)num2 * -1829643742) ^ -104796406;
					continue;
				case 37u:
				{
					int num21;
					if (c2 != ' ')
					{
						num = 208332744;
						num21 = 208332744;
					}
					else
					{
						num = 1948460557;
						num21 = 1948460557;
					}
					continue;
				}
				case 36u:
					num = (int)((num2 * 321068082) ^ 0x382841BE);
					continue;
				case 35u:
				{
					int num20;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 1530642388;
						num20 = 1530642388;
					}
					else
					{
						num = 2003442627;
						num20 = 2003442627;
					}
					continue;
				}
				case 34u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					case '\t':
						goto IL_07d8;
					default:
						goto IL_0c5d;
					case '\v':
					case '\f':
						goto IL_0c70;
					}
					goto case 10u;
				case 33u:
					goto IL_0c70;
				case 32u:
					num = ((int)num2 * -1866317218) ^ -1201829496;
					continue;
				case 31u:
					num10 = 0;
					text2 = "";
					num = (int)(num2 * 1246762859) ^ -1362390722;
					continue;
				case 30u:
					text2 = "";
					jSONNode = stack.Peek();
					num = ((int)num2 * -1705132968) ^ 0x7513B2DE;
					continue;
				case 29u:
					num = ((int)num2 * -1316420575) ^ 0x31F01091;
					continue;
				case 28u:
					num = 1747862645;
					continue;
				case 27u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 2006912918) ^ 0x39590247);
					continue;
				case 26u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1155688430) ^ 0x14C4E1C3;
					continue;
				case 25u:
				{
					int num18;
					int num19;
					if (!(jSONNode != null))
					{
						num18 = 1027117592;
						num19 = 1027117592;
					}
					else
					{
						num18 = 729778715;
						num19 = 729778715;
					}
					num = num18 ^ ((int)num2 * -1462021707);
					continue;
				}
				case 24u:
					num = (int)((num2 * 296859395) ^ 0x1EB009CA);
					continue;
				case 23u:
					num = (int)(num2 * 1944245753) ^ -182719686;
					continue;
				case 22u:
				{
					int num17;
					if (!flag7)
					{
						num = 1571243045;
						num17 = 1571243045;
					}
					else
					{
						num = 2039706582;
						num17 = 2039706582;
					}
					continue;
				}
				case 21u:
					flag6 = stack.Count == 0;
					num = 780052443;
					continue;
				case 20u:
				{
					int num15;
					int num16;
					if (c != 'b')
					{
						num15 = 1242849516;
						num16 = 1242849516;
					}
					else
					{
						num15 = 321678771;
						num16 = 321678771;
					}
					num = num15 ^ (int)(num2 * 601166434);
					continue;
				}
				case 19u:
					num = 473392738;
					continue;
				case 17u:
				{
					int num11;
					int num12;
					if (!flag4)
					{
						num11 = 523732691;
						num12 = 523732691;
					}
					else
					{
						num11 = 752802105;
						num12 = 752802105;
					}
					num = num11 ^ (int)(num2 * 1975031789);
					continue;
				}
				case 16u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 227264383) ^ -129657967;
					continue;
				case 15u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -1310669686) ^ -1906835257;
					continue;
				case 13u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -403066131) ^ -1077455568;
					continue;
				case 11u:
					num = (int)(num2 * 176257070) ^ -1388168346;
					continue;
				case 9u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -1640651455) ^ -1232530731;
					continue;
				case 8u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 2051247278) ^ 0x17BD5D3E);
					continue;
				case 7u:
					num = (int)((num2 * 52362075) ^ 0x7A8B3888);
					continue;
				case 6u:
					num = (int)(num2 * 591563504) ^ -294662526;
					continue;
				case 5u:
					text = text2;
					text2 = "";
					num = 988391811;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 2032297554;
						num7 = 2032297554;
					}
					else
					{
						num6 = 696595045;
						num7 = 696595045;
					}
					num = num6 ^ (int)(num2 * 504364622);
					continue;
				}
				case 3u:
					num = ((int)num2 * -2030626732) ^ 0x630F8E3A;
					continue;
				case 2u:
				{
					int num3;
					if (c == 'n')
					{
						num = 1994308330;
						num3 = 1994308330;
					}
					else
					{
						num = 55010302;
						num3 = 55010302;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -728584166) ^ -193094998;
					continue;
				case 0u:
					num = (int)((num2 * 1399621608) ^ 0x247022E4);
					continue;
				case 142u:
					break;
				case 46u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 79u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0c70:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num10).ToString());
					num = 969051650;
					continue;
					IL_0c5d:
					num = (int)((num2 * 674406700) ^ 0x505FD073);
					continue;
					IL_04cc:
					s = JSONNode.smethod_8(aJSON, num10 + 1, 4);
					num = 1810912380;
					continue;
					IL_04b6:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 251736320;
					continue;
					IL_04a0:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 536518329;
					continue;
					IL_0496:
					num = 1073288039;
					continue;
					IL_0bc3:
					num = 308417254;
					continue;
					IL_0a26:
					num10++;
					if (flag7)
					{
						num = 2052239210;
						num33 = 2052239210;
					}
					else
					{
						num = 2060539042;
						num33 = 2060539042;
					}
					continue;
					IL_08ae:
					flag9 = flag7;
					num = 1547426287;
					continue;
					IL_07d8:
					flag12 = flag7;
					num = 531812536;
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
			int num = -1482656002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6E871FCu) % 4u)
				{
				case 3u:
					Serialize(aWriter);
					num = ((int)num2 * -263118295) ^ -1193682694;
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -1530965372) ^ 0x415216F;
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
			int num = 84140292;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF12DF75u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					FileStream fileStream = JSONNode.smethod_14(aFileName);
					try
					{
						while (true)
						{
							int num3 = 1756759664;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF12DF75u) % 4u)
								{
								case 3u:
									num3 = ((int)num2 * -1833717632) ^ 0x4402D209;
									continue;
								case 1u:
									SaveToStream(fileStream);
									num3 = (int)(num2 * 59601760) ^ -1573739530;
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
								IL_00e9:
								int num4 = 1274425843;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xF12DF75u) % 4u)
									{
									case 2u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num4 = (int)((num2 * 577331857) ^ 0x7BB94BF6);
										continue;
									case 1u:
										num4 = ((int)num2 * -896137659) ^ -434187585;
										continue;
									default:
										goto end_IL_00c8;
									case 0u:
										break;
									case 3u:
										goto end_IL_00c8;
									}
									goto IL_00e9;
									continue;
									end_IL_00c8:
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
				num = ((int)num2 * -1140482450) ^ 0x31FD9000;
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
				int num = 45431241;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5CC7F63Fu) % 5u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -706942327) ^ 0x28AC5D0E;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 320922730) ^ -1495592408;
						continue;
					case 0u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -2139535127) ^ -554869346;
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
					IL_00b9:
					int num3 = 667222168;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x5CC7F63Fu) % 3u)
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
						num3 = (int)(num2 * 1396791972) ^ -411336005;
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
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONNode result = default(JSONNode);
		int num3 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		string aKey = default(string);
		JSONClass jSONClass = default(JSONClass);
		JSONNode aItem = default(JSONNode);
		bool flag = default(bool);
		int num7 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num = -2134267729;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9EBFC24u) % 42u)
				{
				case 41u:
					num6++;
					num = ((int)num2 * -1534669368) ^ 0x2DB4913;
					continue;
				case 40u:
					num = ((int)num2 * -799866544) ^ 0x656CEA40;
					continue;
				case 38u:
					num6 = 0;
					num = (int)(num2 * 1731542731) ^ -1965406549;
					continue;
				case 37u:
					num = ((int)num2 * -662932043) ^ -1932853825;
					continue;
				case 36u:
					num = -1271442251;
					continue;
				case 35u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Value:
						break;
					default:
						goto IL_0089;
					case JSONBinaryTag.Array:
						goto IL_009c;
					case JSONBinaryTag.Class:
						goto IL_00a6;
					case JSONBinaryTag.IntValue:
						goto IL_00bf;
					case JSONBinaryTag.DoubleValue:
						goto IL_00c9;
					case JSONBinaryTag.BoolValue:
						goto IL_00d3;
					case JSONBinaryTag.FloatValue:
						goto IL_00ea;
					}
					goto case 36u;
				case 23u:
					goto IL_009c;
				case 6u:
					goto IL_00a6;
				case 10u:
					goto IL_00bf;
				case 29u:
					goto IL_00c9;
				case 18u:
					goto IL_00d3;
				case 2u:
					goto IL_00ea;
				case 34u:
					num = (int)((num2 * 2125248441) ^ 0x445120C1);
					continue;
				case 33u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -945737304) ^ -1374499095;
					continue;
				case 32u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)(num2 * 942484813) ^ -1571015404;
					continue;
				case 31u:
				{
					int num9;
					if (num6 >= num3)
					{
						num = -787122362;
						num9 = -787122362;
					}
					else
					{
						num = -1413383714;
						num9 = -1413383714;
					}
					continue;
				}
				case 30u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -116487583) ^ -1504254040;
					continue;
				case 28u:
					num = (int)((num2 * 90288947) ^ 0x240F7C04);
					continue;
				case 27u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -1586899316) ^ -1022540697;
					continue;
				case 25u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -759786789) ^ -2099514285;
					continue;
				case 24u:
					jSONArray.Add(Deserialize(aReader));
					num = -868103646;
					continue;
				case 22u:
					num = (int)(num2 * 666900068) ^ -848879824;
					continue;
				case 21u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 727544650) ^ 0x36A51A9B);
					continue;
				case 20u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 328509036) ^ 0x1F54AFBC);
					continue;
				case 19u:
					result = jSONClass;
					num = (int)((num2 * 1121043743) ^ 0x6EFDF355);
					continue;
				case 17u:
					aItem = Deserialize(aReader);
					num = (int)(num2 * 70450361) ^ -2071558524;
					continue;
				case 16u:
					num = -1496650417;
					continue;
				case 15u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 1659947397) ^ -1692421758;
					continue;
				case 14u:
					num = (int)(num2 * 1999569789) ^ -343097597;
					continue;
				case 13u:
					num = (int)(num2 * 1919273206) ^ -713697075;
					continue;
				case 12u:
					result = jSONArray;
					num = ((int)num2 * -1607986499) ^ -1896740242;
					continue;
				case 11u:
					num = (int)(num2 * 452738526) ^ -409602334;
					continue;
				case 9u:
					flag = num7 < num8;
					num = -1415056226;
					continue;
				case 8u:
					num7 = 0;
					num = ((int)num2 * -154142576) ^ 0x47E284E;
					continue;
				case 5u:
					num7++;
					num = (int)((num2 * 1528986720) ^ 0x37DEB8A1);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -345763466;
						num5 = -345763466;
					}
					else
					{
						num4 = -1514671069;
						num5 = -1514671069;
					}
					num = num4 ^ ((int)num2 * -1886954402);
					continue;
				}
				case 3u:
					num3 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 1669817491) ^ 0x48B96547);
					continue;
				case 1u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1594215695) ^ -1021230370;
					continue;
				case 0u:
					num = -1064498501;
					continue;
				case 7u:
					break;
				case 39u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_00ea:
					num = -1186810496;
					continue;
					IL_00d3:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1527984320;
					continue;
					IL_00c9:
					num = -681581564;
					continue;
					IL_00bf:
					num = -1781220831;
					continue;
					IL_00a6:
					num8 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = -1086528240;
					continue;
					IL_009c:
					num = -212554089;
					continue;
					IL_0089:
					num = (int)((num2 * 1539500833) ^ 0x3A719428);
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
					int num = 1614753640;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x3B8E0192u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -1345675295) ^ -984225719;
							continue;
						case 1u:
							num = (int)((num2 * 407919415) ^ 0x2CC886B2);
							continue;
						default:
							goto end_IL_0037;
						case 0u:
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1639458777;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCF8CEEDFu) % 3u)
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
					num = (int)(num2 * 1310987477) ^ -978539682;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0079:
					int num3 = -1720785156;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xCF8CEEDFu) % 3u)
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
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)(num2 * 717633968) ^ -824613235;
						continue;
						end_IL_005c:
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
			int num = -1365529581;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5D5DDA3u) % 7u)
				{
				case 6u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1009446030) ^ 0x5CA332D5;
					continue;
				case 5u:
					num = (int)(num2 * 1694892482) ^ -2143029172;
					continue;
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)(num2 * 811552580) ^ -296322458;
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1060872) ^ -928252150;
					continue;
				case 1u:
					num = ((int)num2 * -641936011) ^ -241770691;
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
