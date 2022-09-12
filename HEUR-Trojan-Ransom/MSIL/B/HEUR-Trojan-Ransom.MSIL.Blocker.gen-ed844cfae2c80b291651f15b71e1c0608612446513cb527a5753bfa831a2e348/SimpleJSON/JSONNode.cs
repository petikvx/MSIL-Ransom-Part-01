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
				int num = -367310202;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEC9A0B97u) % 3u)
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
					num = (int)(num2 * 1873330932) ^ -1440512843;
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
			JSONNode result = null;
			while (true)
			{
				int num = 204232079;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3BB948A9u) % 3u)
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
					num = (int)(num2 * 1187951304) ^ -50032634;
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
				int num = 409294292;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B652BD9u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1111068481) ^ -1423893214;
						continue;
					case 1u:
						result = 0;
						num = (int)((num2 * 1229685726) ^ 0x5A26A924);
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
				int num = 1512349430;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD917B87u) % 3u)
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
					num = ((int)num2 * -972547951) ^ 0x42CCB8D2;
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
			bool flag = default(bool);
			int result = default(int);
			int result2 = default(int);
			while (true)
			{
				int num = 808190623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5539BECEu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -901896817;
							num4 = -901896817;
						}
						else
						{
							num3 = -1764817034;
							num4 = -1764817034;
						}
						num = num3 ^ ((int)num2 * -1982339408);
						continue;
					}
					case 4u:
						result = 0;
						num = 1797997241;
						continue;
					case 3u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = (int)(num2 * 1043607726) ^ -1413766148;
						continue;
					case 1u:
						result = result2;
						num = (int)(num2 * 765749710) ^ -805446385;
						continue;
					case 0u:
						num = (int)((num2 * 1341833165) ^ 0x668846D4);
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
				int num = 3055757;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5620DFF1u) % 9u)
					{
					case 8u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 882768288;
							num4 = 882768288;
						}
						else
						{
							num3 = 1891427411;
							num4 = 1891427411;
						}
						num = num3 ^ (int)(num2 * 975650207);
						continue;
					}
					case 7u:
						result = result2;
						num = (int)(num2 * 263747269) ^ -1197885418;
						continue;
					case 6u:
						result2 = 0f;
						num = ((int)num2 * -1279841651) ^ -371076867;
						continue;
					case 5u:
						num = ((int)num2 * -1237999200) ^ 0x5C8B0EF4;
						continue;
					case 3u:
						num = ((int)num2 * -931229152) ^ -1536668428;
						continue;
					case 2u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -1748236721) ^ -146211278;
						continue;
					case 1u:
						result = 0f;
						num = 852525038;
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

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			double result2 = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = 1997369440;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x23E8617Eu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -2092600378) ^ 0x1B37C74F;
						continue;
					case 5u:
						result2 = result;
						num = (int)((num2 * 371338188) ^ 0x3FC9FC13);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -455056592;
							num4 = -455056592;
						}
						else
						{
							num3 = -141569074;
							num4 = -141569074;
						}
						num = num3 ^ ((int)num2 * -1171016354);
						continue;
					}
					case 3u:
						flag = double.TryParse(Value, out result);
						num = (int)((num2 * 89138333) ^ 0x7A7DF3D6);
						continue;
					case 0u:
						result2 = 0.0;
						num = 1079599436;
						continue;
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
			while (true)
			{
				int num = 1043345135;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6C0B8D70u) % 3u)
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
					num = (int)(num2 * 699119358) ^ -1876140638;
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
				int num = 1118181300;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D4DB957u) % 6u)
					{
					case 5u:
						result = !JSONNode.smethod_1(Value);
						num = 2016075174;
						continue;
					case 4u:
						num = (int)((num2 * 902400836) ^ 0x10A6EA2E);
						continue;
					case 3u:
					{
						result2 = false;
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = -73328195;
							num4 = -73328195;
						}
						else
						{
							num3 = -888779124;
							num4 = -888779124;
						}
						num = num3 ^ ((int)num2 * -802971449);
						continue;
					}
					case 2u:
						result = result2;
						num = (int)((num2 * 2013897072) ^ 0x69440735);
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
				int num = 1325059527;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x747AD45A) % 3u)
					{
					case 2u:
						value2 = (value ? "true" : "false");
						goto IL_0013;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0013:
					Value = value2;
					num = 2034564033;
				}
			}
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
				int num = -2105970984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB89E367u) % 3u)
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
					result = this as JSONClass;
					num = ((int)num2 * -1047119055) ^ 0x4F1A197B;
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -904217723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9390415Eu) % 4u)
				{
				case 3u:
					result = null;
					num = (int)((num2 * 332893212) ^ 0x41689B9C);
					continue;
				case 2u:
					num = (int)((num2 * 2066061815) ^ 0x4FA0CB2D);
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
			int num = 586408607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D2F5775u) % 4u)
				{
				case 2u:
					result = aNode;
					num = (int)(num2 * 766084195) ^ -1922847666;
					continue;
				case 1u:
					num = ((int)num2 * -397138054) ^ -1458523920;
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

	public override string ToString()
	{
		return "JSONNode";
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1740481443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x452564C6u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -845332222) ^ 0x3F3F7E65;
					continue;
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -466934057) ^ 0xAEFB743;
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
		return new JSONData(s);
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 338175463;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x2432B2E0u) % 4u)
				{
				case 3u:
					if (!(d == null))
					{
						num = (int)((num2 * 1633087402) ^ 0x20AD4B3F);
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
					obj = d.Value;
					goto IL_001c;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = 1729101982;
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
			int num = -241705356;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEC788AC2u) % 8u)
				{
				case 6u:
					if (b == null)
					{
						num = ((int)num2 * -1705282746) ^ -254870484;
						continue;
					}
					num3 = 0;
					goto IL_0019;
				case 5u:
					result = true;
					num = ((int)num2 * -1941177165) ^ -102343471;
					continue;
				case 4u:
					num = ((int)num2 * -1083347483) ^ 0x3667A729;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1337460130;
						num5 = 1337460130;
					}
					else
					{
						num4 = 1193283902;
						num5 = 1193283902;
					}
					num = num4 ^ (int)(num2 * 315161239);
					continue;
				}
				case 2u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0019;
				case 1u:
					result = (object)a == b;
					num = -863254691;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0019:
					flag = (byte)num3 != 0;
					num = -391660167;
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
			int num = -1774022197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0AD0001u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2031364178) ^ 0x7A101ED6;
					continue;
				case 2u:
					result = !(a == b);
					num = ((int)num2 * -595836893) ^ -368845328;
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
		bool result = (object)this == obj;
		while (true)
		{
			int num = -1876909597;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD299FCFEu) % 3u)
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
				num = (int)((num2 * 1131137878) ^ 0x7D50EDAC);
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = -601035512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91E3A453u) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = (int)(num2 * 1302426186) ^ -984483977;
					continue;
				case 2u:
					num = (int)((num2 * 668788742) ^ 0x79F33BB6);
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
		char c = default(char);
		char c2 = default(char);
		char c3 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1173557151;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDF040F29u) % 27u)
				{
				case 26u:
				{
					int num6;
					if (c != '\\')
					{
						num = -1780769697;
						num6 = -1780769697;
					}
					else
					{
						num = -982754708;
						num6 = -982754708;
					}
					continue;
				}
				case 25u:
					num = (int)((num2 * 1820168976) ^ 0x542367D9);
					continue;
				case 24u:
					c = c2;
					num = (int)(num2 * 1238066379) ^ -931299831;
					continue;
				case 23u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1622667685;
					continue;
				case 21u:
				{
					int num5;
					if (c == '"')
					{
						num = -478163527;
						num5 = -478163527;
					}
					else
					{
						num = -68078599;
						num5 = -68078599;
					}
					continue;
				}
				case 20u:
					c3 = JSONNode.smethod_2(string_, num3);
					num = -1277203474;
					continue;
				case 19u:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -1622667685;
					continue;
				case 18u:
					result = text;
					num = (int)((num2 * 1645475280) ^ 0x3CD8465D);
					continue;
				case 16u:
					num = ((int)num2 * -1326546894) ^ -381208162;
					continue;
				case 15u:
					goto IL_00e2;
				case 14u:
					goto IL_00f8;
				case 13u:
					goto IL_010e;
				case 12u:
					num = ((int)num2 * -800874184) ^ -1583760631;
					continue;
				case 11u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -200619227) ^ -172485593;
					continue;
				case 10u:
					num = ((int)num2 * -2014048660) ^ 0x5529F5BB;
					continue;
				case 9u:
					num = (int)(num2 * 680060113) ^ -1058492874;
					continue;
				case 8u:
					c2 = c3;
					num = (int)(num2 * 526487019) ^ -1997453899;
					continue;
				case 7u:
					num = ((int)num2 * -1545741926) ^ 0x3263CD9C;
					continue;
				case 6u:
					num = ((int)num2 * -2087201846) ^ -1855698251;
					continue;
				case 5u:
					goto IL_01b0;
				case 4u:
				{
					int num4;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -357095800;
						num4 = -357095800;
					}
					else
					{
						num = -725574438;
						num4 = -725574438;
					}
					continue;
				}
				case 3u:
					num3++;
					num = -240335998;
					continue;
				case 2u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1622667685;
					continue;
				case 1u:
					switch (c)
					{
					case '\v':
						break;
					case '\n':
						goto IL_00e2;
					case '\f':
						goto IL_00f8;
					case '\t':
						goto IL_010e;
					case '\b':
						goto IL_01b0;
					default:
						goto IL_0227;
					case '\r':
						goto IL_0237;
					}
					goto case 19u;
				case 0u:
					goto IL_0237;
				case 17u:
					break;
				default:
					{
						return result;
					}
					IL_0237:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1622667685;
					continue;
					IL_0227:
					num = ((int)num2 * -1547553177) ^ -1933989991;
					continue;
					IL_01b0:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1622667685;
					continue;
					IL_010e:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1622667685;
					continue;
					IL_00f8:
					text = JSONNode.smethod_3(text, "\\f");
					num = -563549694;
					continue;
					IL_00e2:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1622667685;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag4 = default(bool);
		bool flag14 = default(bool);
		string text2 = default(string);
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		char c = default(char);
		char c3 = default(char);
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		bool flag12 = default(bool);
		int num4 = default(int);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		char c5 = default(char);
		char c2 = default(char);
		bool flag5 = default(bool);
		bool flag13 = default(bool);
		JSONNode result = default(JSONNode);
		string s = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 120198084;
			while (true)
			{
				uint num2;
				int num43;
				switch ((num2 = (uint)num ^ 0x54D63287u) % 159u)
				{
				case 158u:
				{
					int num36;
					int num37;
					if (!flag4)
					{
						num36 = 1637001298;
						num37 = 1637001298;
					}
					else
					{
						num36 = 399405519;
						num37 = 399405519;
					}
					num = num36 ^ ((int)num2 * -1243426356);
					continue;
				}
				case 157u:
					flag14 = flag4;
					num = ((int)num2 * -266368046) ^ 0x5C39B3CF;
					continue;
				case 156u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1696766853) ^ -1330262792;
					continue;
				case 155u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1029721219) ^ -946115002;
					continue;
				case 154u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 45510120) ^ 0x4ED5A9F2);
					continue;
				case 153u:
					num = (int)(num2 * 1808551585) ^ -1097594357;
					continue;
				case 152u:
				{
					int num60;
					if (c == '"')
					{
						num = 1541945692;
						num60 = 1541945692;
					}
					else
					{
						num = 1814374292;
						num60 = 1814374292;
					}
					continue;
				}
				case 151u:
					text = "";
					num = (int)((num2 * 833044739) ^ 0x585E2BD2);
					continue;
				case 150u:
					num = (int)(num2 * 932461164) ^ -426992855;
					continue;
				case 149u:
					num = ((int)num2 * -703478223) ^ 0xE840943;
					continue;
				case 148u:
				{
					int num44;
					int num45;
					if ((uint)c > 32u)
					{
						num44 = 210599499;
						num45 = 210599499;
					}
					else
					{
						num44 = 305316921;
						num45 = 305316921;
					}
					num = num44 ^ (int)(num2 * 487912126);
					continue;
				}
				case 147u:
				{
					int num35;
					if (c != ' ')
					{
						num = 836047947;
						num35 = 836047947;
					}
					else
					{
						num = 305158427;
						num35 = 305158427;
					}
					continue;
				}
				case 146u:
					num = ((int)num2 * -212587951) ^ 0x5C68B58;
					continue;
				case 145u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1402647356) ^ -1793759572;
					continue;
				case 143u:
					num = ((int)num2 * -800112169) ^ 0x37F15DEF;
					continue;
				case 142u:
					text = JSONNode.smethod_3(text, "\t");
					num = 714464231;
					continue;
				case 141u:
					num = ((int)num2 * -472573802) ^ -1483364533;
					continue;
				case 140u:
					text = "";
					num = (int)((num2 * 1967215964) ^ 0x1D948B8C);
					continue;
				case 139u:
					switch (c3)
					{
					case 't':
						break;
					default:
						goto IL_020d;
					case 'r':
						goto IL_0217;
					case 's':
						goto IL_022d;
					case 'u':
						goto IL_0245;
					}
					goto case 142u;
				case 86u:
					goto IL_0217;
				case 109u:
					goto IL_022d;
				case 11u:
					goto IL_0245;
				case 138u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1307876310) ^ 0x39862D5F;
					continue;
				case 137u:
					text2 = "";
					num = 1936199395;
					continue;
				case 136u:
				{
					int num57;
					int num58;
					if (c3 == 'b')
					{
						num57 = -19321312;
						num58 = -19321312;
					}
					else
					{
						num57 = -1734076452;
						num58 = -1734076452;
					}
					num = num57 ^ (int)(num2 * 535656928);
					continue;
				}
				case 135u:
					num = 109199286;
					continue;
				case 134u:
					text2 = "";
					num = ((int)num2 * -1173954368) ^ -502711688;
					continue;
				case 133u:
					num = ((int)num2 * -510705577) ^ -80630951;
					continue;
				case 132u:
					text = JSONNode.smethod_3(text, "\b");
					num = 1350385546;
					continue;
				case 131u:
				{
					int num52;
					if (c != ',')
					{
						num = 367457819;
						num52 = 367457819;
					}
					else
					{
						num = 1471130253;
						num52 = 1471130253;
					}
					continue;
				}
				case 130u:
					num = (int)((num2 * 969990768) ^ 0x7DDDCDF7);
					continue;
				case 129u:
					flag9 = stack.Count > 0;
					num = ((int)num2 * -1309227791) ^ 0x37D05DD3;
					continue;
				case 128u:
				{
					int num47;
					if ((uint)c <= 93u)
					{
						num = 571732023;
						num47 = 571732023;
					}
					else
					{
						num = 820765938;
						num47 = 820765938;
					}
					continue;
				}
				case 127u:
				{
					int num41;
					int num42;
					if (c == ':')
					{
						num41 = -679225814;
						num42 = -679225814;
					}
					else
					{
						num41 = -1182756207;
						num42 = -1182756207;
					}
					num = num41 ^ ((int)num2 * -1991796007);
					continue;
				}
				case 126u:
				{
					int num38;
					int num39;
					if (flag11)
					{
						num38 = 290380900;
						num39 = 290380900;
					}
					else
					{
						num38 = 1698111103;
						num39 = 1698111103;
					}
					num = num38 ^ ((int)num2 * -1095017413);
					continue;
				}
				case 125u:
					flag12 = jSONNode != null;
					num = (int)((num2 * 639539488) ^ 0x1D024CC7);
					continue;
				case 124u:
					flag11 = JSONNode.smethod_6(text, "");
					num = (int)(num2 * 1402937698) ^ -479410502;
					continue;
				case 123u:
					num = (int)((num2 * 104878645) ^ 0x1DDED472);
					continue;
				case 122u:
					num = ((int)num2 * -234552960) ^ -222937693;
					continue;
				case 121u:
				{
					int num28;
					int num29;
					if ((uint)c3 <= 102u)
					{
						num28 = -938397705;
						num29 = -938397705;
					}
					else
					{
						num28 = -984410472;
						num29 = -984410472;
					}
					num = num28 ^ (int)(num2 * 1573061490);
					continue;
				}
				case 9u:
				case 45u:
				case 90u:
				case 117u:
				case 120u:
					num4++;
					num = 375053573;
					continue;
				case 119u:
				{
					int num24;
					if (flag4)
					{
						num = 159095308;
						num24 = 159095308;
					}
					else
					{
						num = 856525278;
						num24 = 856525278;
					}
					continue;
				}
				case 118u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -192143900) ^ 0x36CF6B7E;
					continue;
				case 116u:
				{
					int num18;
					int num19;
					if (flag8)
					{
						num18 = -45542776;
						num19 = -45542776;
					}
					else
					{
						num18 = -342726043;
						num19 = -342726043;
					}
					num = num18 ^ (int)(num2 * 2096340300);
					continue;
				}
				case 115u:
					num = ((int)num2 * -1098829462) ^ -1681799291;
					continue;
				case 114u:
					jSONNode = null;
					num = (int)((num2 * 1772498932) ^ 0x64940A41);
					continue;
				case 113u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)((num2 * 1530591429) ^ 0x2A38E989);
					continue;
				case 112u:
				{
					int num13;
					int num14;
					if (flag6)
					{
						num13 = 664925858;
						num14 = 664925858;
					}
					else
					{
						num13 = 1559533728;
						num14 = 1559533728;
					}
					num = num13 ^ ((int)num2 * -1093058765);
					continue;
				}
				case 111u:
					num = (int)((num2 * 1190609735) ^ 0x572B2B49);
					continue;
				case 110u:
				{
					int num9;
					if (c3 == 'n')
					{
						num = 161748577;
						num9 = 161748577;
					}
					else
					{
						num = 316928511;
						num9 = 316928511;
					}
					continue;
				}
				case 108u:
					num = 433825666;
					continue;
				case 107u:
					num = (int)(num2 * 351911340) ^ -364296768;
					continue;
				case 106u:
					num = ((int)num2 * -1219631483) ^ 0x7BD9DC46;
					continue;
				case 105u:
					flag2 = jSONNode is JSONArray;
					num = (int)((num2 * 1641314750) ^ 0x5B2943B4);
					continue;
				case 104u:
					num = ((int)num2 * -1881351873) ^ -1397606300;
					continue;
				case 103u:
					num = (int)(num2 * 769239600) ^ -1006223167;
					continue;
				case 102u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -319354506) ^ 0x14805650;
					continue;
				case 101u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -889694654) ^ -2139577432;
					continue;
				case 100u:
					text2 = text;
					text = "";
					num = 11609395;
					continue;
				case 99u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -277201711) ^ -1028024427;
					continue;
				case 98u:
					flag3 = num4 < JSONNode.smethod_4(aJSON);
					num = 1191301041;
					continue;
				case 97u:
					num = ((int)num2 * -198432295) ^ 0x178CEC84;
					continue;
				case 96u:
					flag10 = JSONNode.smethod_6(text2, "");
					num = 1018479875;
					continue;
				case 95u:
					num = (int)(num2 * 1745549613) ^ -397059634;
					continue;
				case 94u:
				{
					int num59;
					if (flag4)
					{
						num = 1449443845;
						num59 = 1449443845;
					}
					else
					{
						num = 77909202;
						num59 = 77909202;
					}
					continue;
				}
				case 93u:
				{
					int num55;
					int num56;
					if (flag14)
					{
						num55 = -1831350645;
						num56 = -1831350645;
					}
					else
					{
						num55 = -1805236198;
						num56 = -1805236198;
					}
					num = num55 ^ ((int)num2 * -707365409);
					continue;
				}
				case 92u:
				{
					int num53;
					int num54;
					if (flag7)
					{
						num53 = 1373018315;
						num54 = 1373018315;
					}
					else
					{
						num53 = 1798814788;
						num54 = 1798814788;
					}
					num = num53 ^ ((int)num2 * -1781642787);
					continue;
				}
				case 91u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -237704531) ^ -877949997;
					continue;
				case 89u:
					num = (int)((num2 * 1272869823) ^ 0x7E847F09);
					continue;
				case 88u:
					flag4 = false;
					num = ((int)num2 * -1557527263) ^ 0x1941A587;
					continue;
				case 87u:
					num = ((int)num2 * -988095192) ^ -2126286779;
					continue;
				case 85u:
					c5 = c2;
					num = (int)(num2 * 1143656647) ^ -300573542;
					continue;
				case 84u:
				{
					int num50;
					int num51;
					if (flag5)
					{
						num50 = -240846932;
						num51 = -240846932;
					}
					else
					{
						num50 = -1463466829;
						num51 = -1463466829;
					}
					num = num50 ^ (int)(num2 * 995577642);
					continue;
				}
				case 83u:
				{
					int num48;
					int num49;
					if (!flag12)
					{
						num48 = -109832082;
						num49 = -109832082;
					}
					else
					{
						num48 = -263047298;
						num49 = -263047298;
					}
					num = num48 ^ ((int)num2 * -1838687695);
					continue;
				}
				case 82u:
					text2 = "";
					num = 565746153;
					continue;
				case 81u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)(num2 * 1535000961) ^ -324289969;
					continue;
				case 80u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 864177068) ^ 0x78BDFDC6);
					continue;
				case 79u:
					num = 1057513268;
					continue;
				case 78u:
				{
					int num46;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 811191053;
						num46 = 811191053;
					}
					else
					{
						num = 1457811142;
						num46 = 1457811142;
					}
					continue;
				}
				case 77u:
					goto IL_0889;
				case 76u:
					num = ((int)num2 * -422088165) ^ -1347496694;
					continue;
				case 74u:
					text2 = "";
					num = 222162632;
					continue;
				case 73u:
					num = ((int)num2 * -621286163) ^ 0x66090711;
					continue;
				case 72u:
					num = (int)(num2 * 896366553) ^ -1660043038;
					continue;
				case 71u:
				{
					int num40;
					if (c3 != 'f')
					{
						num = 1464580739;
						num40 = 1464580739;
					}
					else
					{
						num = 285713303;
						num40 = 285713303;
					}
					continue;
				}
				case 70u:
					text = "";
					num = (int)((num2 * 1752539460) ^ 0x26D9559E);
					continue;
				case 69u:
					num = (int)((num2 * 879696237) ^ 0x45C2D0AA);
					continue;
				case 68u:
					num = (int)(num2 * 1473303118) ^ -636929319;
					continue;
				case 67u:
					flag6 = JSONNode.smethod_6(text2, "");
					num = 985356940;
					continue;
				case 66u:
					flag13 = jSONNode != null;
					num = (int)((num2 * 1050846424) ^ 0x57F8D1CE);
					continue;
				case 65u:
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -497079321) ^ -222311959;
					continue;
				case 63u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1237015494) ^ 0x3D7E640D);
					continue;
				case 62u:
				{
					int num33;
					int num34;
					if (!flag13)
					{
						num33 = -427709516;
						num34 = -427709516;
					}
					else
					{
						num33 = -1435629179;
						num34 = -1435629179;
					}
					num = num33 ^ (int)(num2 * 1654364288);
					continue;
				}
				case 61u:
					result = jSONNode;
					num = 1883559011;
					continue;
				case 60u:
					num = (int)(num2 * 2025952932) ^ -1563562727;
					continue;
				case 59u:
					text = "";
					num = ((int)num2 * -624627869) ^ -129022757;
					continue;
				case 58u:
					stack.Pop();
					num = 417498906;
					continue;
				case 57u:
					num = ((int)num2 * -625964425) ^ 0x5A989C7C;
					continue;
				case 56u:
					num = (int)((num2 * 1266433808) ^ 0x7C1C6086);
					continue;
				case 55u:
				{
					int num32;
					if (flag4)
					{
						num = 581016077;
						num32 = 581016077;
					}
					else
					{
						num = 1560659723;
						num32 = 1560659723;
					}
					continue;
				}
				case 54u:
				{
					int num30;
					int num31;
					if (jSONNode is JSONArray)
					{
						num30 = 1496714150;
						num31 = 1496714150;
					}
					else
					{
						num30 = 1877345290;
						num31 = 1877345290;
					}
					num = num30 ^ ((int)num2 * -1719636866);
					continue;
				}
				case 53u:
				{
					int num26;
					int num27;
					if (!flag2)
					{
						num26 = -940872870;
						num27 = -940872870;
					}
					else
					{
						num26 = -574022812;
						num27 = -574022812;
					}
					num = num26 ^ ((int)num2 * -1823453364);
					continue;
				}
				case 52u:
					num = (int)(num2 * 765925551) ^ -1181267642;
					continue;
				case 51u:
					num = ((int)num2 * -304106334) ^ 0x6DCB0787;
					continue;
				case 50u:
					s = JSONNode.smethod_8(aJSON, num4 + 1, 4);
					num = (int)(num2 * 2045389471) ^ -2144056966;
					continue;
				case 49u:
					flag = flag4;
					num = 35881996;
					continue;
				case 48u:
					num = ((int)num2 * -1821272922) ^ -465170243;
					continue;
				case 47u:
					c3 = c5;
					num = (int)(num2 * 336530761) ^ -1323283675;
					continue;
				case 46u:
				{
					int num25;
					if (stack.Count != 0)
					{
						num = 1622169802;
						num25 = 1622169802;
					}
					else
					{
						num = 1388060584;
						num25 = 1388060584;
					}
					continue;
				}
				case 44u:
				{
					int num22;
					int num23;
					if (flag10)
					{
						num22 = -1166796917;
						num23 = -1166796917;
					}
					else
					{
						num22 = -466779049;
						num23 = -466779049;
					}
					num = num22 ^ (int)(num2 * 1282104100);
					continue;
				}
				case 43u:
					jSONNode.Add(text);
					num = ((int)num2 * -1373487213) ^ 0x8ACCCAF;
					continue;
				case 42u:
				{
					int num20;
					int num21;
					if (!flag9)
					{
						num20 = 488039911;
						num21 = 488039911;
					}
					else
					{
						num20 = 2054754019;
						num21 = 2054754019;
					}
					num = num20 ^ ((int)num2 * -893244590);
					continue;
				}
				case 41u:
				{
					int num16;
					int num17;
					if (!(jSONNode is JSONArray))
					{
						num16 = 290652935;
						num17 = 290652935;
					}
					else
					{
						num16 = 363447035;
						num17 = 363447035;
					}
					num = num16 ^ (int)(num2 * 508073374);
					continue;
				}
				case 40u:
					num = (int)((num2 * 1595952259) ^ 0x7A94775B);
					continue;
				case 39u:
					num = (int)((num2 * 1073150843) ^ 0x13CFA8D2);
					continue;
				case 38u:
				{
					int num15;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 1785015011;
						num15 = 1785015011;
					}
					else
					{
						num = 732268070;
						num15 = 732268070;
					}
					continue;
				}
				case 37u:
					flag4 = !flag4;
					num = 1150475325;
					continue;
				case 36u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 1096525012;
					continue;
				case 35u:
					text2 = "";
					text = "";
					num = 1114807652;
					continue;
				case 34u:
				{
					char c4 = JSONNode.smethod_2(aJSON, num4);
					c = c4;
					int num11;
					int num12;
					if ((uint)c > 44u)
					{
						num11 = -779807870;
						num12 = -779807870;
					}
					else
					{
						num11 = -1131081728;
						num12 = -1131081728;
					}
					num = num11 ^ ((int)num2 * -1039862965);
					continue;
				}
				case 33u:
				{
					int num10;
					if (c == '{')
					{
						num = 238679626;
						num10 = 238679626;
					}
					else
					{
						num = 1972522657;
						num10 = 1972522657;
					}
					continue;
				}
				case 32u:
					goto IL_0d00;
				case 31u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num4 += 4;
					num = ((int)num2 * -673047081) ^ 0x57F7D01A;
					continue;
				case 30u:
					num = 1649262121;
					continue;
				case 29u:
					num = ((int)num2 * -683453701) ^ -275004138;
					continue;
				case 27u:
					num = (int)(num2 * 1906637786) ^ -1303401111;
					continue;
				case 26u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\t':
						goto IL_0889;
					default:
						goto IL_0d90;
					case '\v':
					case '\f':
						goto IL_0da3;
					}
					goto case 9u;
				case 8u:
					goto IL_0da3;
				case 25u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -588065676) ^ 0x1000DCDD;
					continue;
				case 24u:
					num = (int)(num2 * 1121723779) ^ -203509241;
					continue;
				case 23u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -2002083743) ^ 0x3E59C0E;
					continue;
				case 22u:
					goto IL_0e12;
				case 21u:
					num = 1785015011;
					continue;
				case 20u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1297984860) ^ 0xFF9D720);
					continue;
				case 19u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1458491037) ^ 0x69A0F8E7;
					continue;
				case 18u:
					num = ((int)num2 * -517183591) ^ -697148430;
					continue;
				case 17u:
					stack.Push(new JSONArray());
					num = 2137106175;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 845068602;
						num8 = 845068602;
					}
					else
					{
						num7 = 1882563163;
						num8 = 1882563163;
					}
					num = num7 ^ ((int)num2 * -635630963);
					continue;
				}
				case 15u:
					switch (c)
					{
					case '[':
						break;
					case ']':
						goto IL_0d00;
					case '\\':
						goto IL_0e12;
					default:
						goto IL_0ed5;
					}
					goto case 94u;
				case 14u:
					text = JSONNode.smethod_3(text, "\n");
					num = 603917146;
					continue;
				case 13u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 2034541469;
						num6 = 2034541469;
					}
					else
					{
						num5 = 1289123802;
						num6 = 1289123802;
					}
					num = num5 ^ ((int)num2 * -463375902);
					continue;
				}
				case 12u:
					num = 1470197038;
					continue;
				case 10u:
					stack.Push(new JSONClass());
					num = 1211269618;
					continue;
				case 7u:
					num = ((int)num2 * -796881645) ^ 0xC1D29C0;
					continue;
				case 6u:
					num = (int)((num2 * 774325838) ^ 0x66A11141);
					continue;
				case 5u:
					num4 = 0;
					num = ((int)num2 * -398027563) ^ -749103379;
					continue;
				case 4u:
					c2 = JSONNode.smethod_2(aJSON, num4);
					num = (int)((num2 * 1375059076) ^ 0x1E6B991F);
					continue;
				case 3u:
				{
					int num3;
					if (c != '}')
					{
						num = 1705972975;
						num3 = 1705972975;
					}
					else
					{
						num = 743082242;
						num3 = 743082242;
					}
					continue;
				}
				case 2u:
					jSONNode.Add(text);
					num = (int)(num2 * 1512805033) ^ -1168501074;
					continue;
				case 1u:
					text = JSONNode.smethod_3(text, "\f");
					num = 714464231;
					continue;
				case 0u:
					num = (int)((num2 * 944278769) ^ 0x5132EF24);
					continue;
				case 28u:
					break;
				case 75u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 144u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0ed5:
					num = 1470100690;
					continue;
					IL_0e12:
					num4++;
					num = 276332132;
					continue;
					IL_0da3:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = 622331425;
					continue;
					IL_0d90:
					num = ((int)num2 * -1915081648) ^ 0x20DA2C4F;
					continue;
					IL_0d00:
					flag5 = flag4;
					num = 710930672;
					continue;
					IL_0245:
					num = 1718997517;
					continue;
					IL_020d:
					num = 1231027064;
					continue;
					IL_022d:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 453856611;
					continue;
					IL_0217:
					text = JSONNode.smethod_3(text, "\r");
					num = 714464231;
					continue;
					IL_0889:
					if (flag4)
					{
						num = 651539895;
						num43 = 651539895;
					}
					else
					{
						num = 504493439;
						num43 = 504493439;
					}
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
		while (true)
		{
			int num = 485052866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x221533BDu) % 3u)
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
						SaveToStream(fileStream);
						return;
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00a2:
								int num3 = 1260301971;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x221533BDu) % 4u)
									{
									case 2u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num3 = (int)(num2 * 272476644) ^ -1949230800;
										continue;
									case 1u:
										num3 = (int)((num2 * 1272251622) ^ 0x24950E8C);
										continue;
									default:
										goto end_IL_0081;
									case 0u:
										break;
									case 3u:
										goto end_IL_0081;
									}
									goto IL_00a2;
									continue;
									end_IL_0081:
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
				num = ((int)num2 * -1573407143) ^ -1214640776;
			}
		}
	}

	public string SaveToBase64()
	{
		MemoryStream memoryStream = JSONNode.smethod_16();
		try
		{
			SaveToStream(memoryStream);
			while (true)
			{
				int num = -438668331;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB25FCCE2u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -641401547) ^ -245949104;
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1075777057) ^ -721586077;
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
					IL_00b8:
					int num3 = -800911609;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xB25FCCE2u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -1657260605) ^ 0x53EFB6D;
							continue;
						case 0u:
							num3 = ((int)num2 * -1542151775) ^ 0x16F86F0C;
							continue;
						default:
							goto end_IL_0097;
						case 3u:
							break;
						case 2u:
							goto end_IL_0097;
						}
						goto IL_00b8;
						continue;
						end_IL_0097:
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
		JSONClass jSONClass = default(JSONClass);
		int num5 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		int num9 = default(int);
		bool flag = default(bool);
		int num8 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = 588214338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A05F5F5u) % 36u)
				{
				case 35u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 1190971369;
					continue;
				case 34u:
					num = (int)(num2 * 314483277) ^ -1156492745;
					continue;
				case 33u:
					jSONClass = new JSONClass();
					num5 = 0;
					num = ((int)num2 * -995987361) ^ 0x31F11CAC;
					continue;
				case 32u:
					goto IL_0053;
				case 31u:
					goto IL_006a;
				case 30u:
					num = 1504854364;
					continue;
				case 29u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -1692444442) ^ -623386884;
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1306789998) ^ -637234326;
					continue;
				case 27u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = ((int)num2 * -146524708) ^ -1937983428;
					continue;
				case 26u:
					goto IL_00d0;
				case 24u:
					num = 1799036799;
					continue;
				case 23u:
					goto IL_00e4;
				case 22u:
					goto IL_00fb;
				case 21u:
					num = ((int)num2 * -1097543280) ^ -732602034;
					continue;
				case 20u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 975296217) ^ 0x17288773);
					continue;
				case 19u:
					num = (int)((num2 * 835577543) ^ 0x6CF944F7);
					continue;
				case 18u:
					jSONArray.Add(Deserialize(aReader));
					num9++;
					num = 252129032;
					continue;
				case 17u:
					jSONArray = new JSONArray();
					num9 = 0;
					num = ((int)num2 * -109374989) ^ -252719337;
					continue;
				case 16u:
					num = (int)((num2 * 263516088) ^ 0x68889BE);
					continue;
				case 15u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Value:
						goto IL_0053;
					case JSONBinaryTag.Class:
						goto IL_006a;
					case JSONBinaryTag.FloatValue:
						goto IL_00d0;
					case JSONBinaryTag.IntValue:
						goto IL_00e4;
					case JSONBinaryTag.BoolValue:
						goto IL_00fb;
					default:
						goto IL_01ba;
					case JSONBinaryTag.Array:
						goto IL_01cd;
					}
					goto case 35u;
				case 4u:
					goto IL_01cd;
				case 13u:
					flag = num9 < num8;
					num = 1195601989;
					continue;
				case 12u:
					result = jSONClass;
					num = ((int)num2 * -1859217566) ^ -57084336;
					continue;
				case 11u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1440381875) ^ -392673999;
					continue;
				case 10u:
					num = (int)(num2 * 1790112556) ^ -1801706176;
					continue;
				case 9u:
					result = jSONArray;
					num = (int)((num2 * 1657052758) ^ 0x7FDC8558);
					continue;
				case 8u:
					num8 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 52314496) ^ 0x336C59D0);
					continue;
				case 6u:
				{
					int num7;
					if (num5 >= num6)
					{
						num = 1028901165;
						num7 = 1028901165;
					}
					else
					{
						num = 1744889243;
						num7 = 1744889243;
					}
					continue;
				}
				case 5u:
					num5++;
					num = (int)(num2 * 68789110) ^ -914441743;
					continue;
				case 3u:
					aItem = Deserialize(aReader);
					num = (int)((num2 * 1327617521) ^ 0x58A998E2);
					continue;
				case 2u:
					num = ((int)num2 * -834605172) ^ 0x5E67F8D6;
					continue;
				case 1u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 1511131355) ^ 0x2B1CC111);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 530816675;
						num4 = 530816675;
					}
					else
					{
						num3 = 552862380;
						num4 = 552862380;
					}
					num = num3 ^ (int)(num2 * 1686498365);
					continue;
				}
				case 25u:
					break;
				case 14u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0053:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 1120137459;
					continue;
					IL_006a:
					num6 = JSONNode.smethod_21(aReader);
					num = 1742488296;
					continue;
					IL_01cd:
					num = 1428704397;
					continue;
					IL_01ba:
					num = (int)(num2 * 1577444631) ^ -353776074;
					continue;
					IL_00fb:
					num = 839044894;
					continue;
					IL_00e4:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 1578934686;
					continue;
					IL_00d0:
					num = 260073181;
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
				int num = -642322028;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCBC1EA43u) % 3u)
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
					num = (int)((num2 * 914713900) ^ 0x3F361C30);
				}
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				while (true)
				{
					IL_008c:
					int num3 = -1837124202;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xCBC1EA43u) % 4u)
						{
						case 3u:
							num3 = (int)(num2 * 1002121971) ^ -185058834;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = ((int)num2 * -467965543) ^ 0x3029946D;
							continue;
						default:
							goto end_IL_006b;
						case 2u:
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

	public static JSONNode LoadFromFile(string aFileName)
	{
		FileStream fileStream = JSONNode.smethod_27(aFileName);
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1670998170;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF337DF5u) % 3u)
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
					result = LoadFromStream(fileStream);
					num = (int)((num2 * 178519725) ^ 0x5437915A);
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
					int num3 = -1029583689;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xDF337DF5u) % 3u)
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
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)(num2 * 789767913) ^ -491777689;
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
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num = 2084468280;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20C6616Fu) % 7u)
				{
				case 6u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1104227783) ^ 0x26DFABE0;
					continue;
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -934720512) ^ 0x265B7E0A;
					continue;
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -553682846) ^ -1603987457;
					continue;
				case 3u:
					num = ((int)num2 * -515908552) ^ 0x4761D5EE;
					continue;
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1423031156) ^ 0x11D447F5;
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
			int num = -2009133059;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x908C0DD0u) % 3u)
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
				num = ((int)num2 * -124047932) ^ -382271858;
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
