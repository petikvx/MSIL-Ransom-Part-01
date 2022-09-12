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
				int num = 132598350;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x140B1570u) % 3u)
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
					num = ((int)num2 * -1532654623) ^ -1859703307;
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
				int num = -1261231989;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4903D76u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 155881647) ^ 0x13B40E04);
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -594710158) ^ 0x5D4FD91A;
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
				int num = 643961265;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x15F2FE10u) % 4u)
					{
					case 1u:
						result = 0;
						num = ((int)num2 * -1711390444) ^ -249254660;
						continue;
					case 0u:
						num = (int)((num2 * 1745928431) ^ 0x278E0D37);
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
				int num = -265281592;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF71B5139u) % 6u)
					{
					case 3u:
					{
						int num3;
						num = ((num3 != 0) ? (-1913501626) : (-1426084563)) ^ ((int)num2 * -821275557);
						continue;
					}
					case 0u:
						num = ((int)num2 * -591458650) ^ -1552663403;
						continue;
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
				int num = -1147968506;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDCB10DCFu) % 4u)
					{
					case 1u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -729883971) ^ 0x2A416F5E;
						continue;
					case 0u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)((num2 * 408890006) ^ 0x7B61E771);
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
			int result = 0;
			if (int.TryParse(Value, out result))
			{
				goto IL_0024;
			}
			goto IL_005d;
			IL_005d:
			int result2 = 0;
			int num = -1030941234;
			goto IL_0038;
			IL_0038:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE867CFEu) % 5u)
				{
				case 3u:
					result2 = result;
					num = ((int)num2 * -41308691) ^ -1382878583;
					continue;
				case 2u:
					break;
				case 0u:
					num = ((int)num2 * -1522521375) ^ 0x10E36570;
					continue;
				case 4u:
					goto IL_005d;
				default:
					return result2;
				}
				break;
			}
			goto IL_0024;
			IL_0024:
			num = -1676340237;
			goto IL_0038;
		}
		set
		{
			Value = value.ToString();
			while (true)
			{
				int num = -1467467003;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x95C68135u) % 3u)
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
					num = (int)(num2 * 447292759) ^ -225353093;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			bool flag = default(bool);
			float result2 = default(float);
			while (true)
			{
				int num = -642707053;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEB0D804u) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1916148479;
							num4 = 1916148479;
						}
						else
						{
							num3 = 674167620;
							num4 = 674167620;
						}
						num = num3 ^ (int)(num2 * 1406120525);
						continue;
					}
					case 3u:
						result2 = 0f;
						num = -2134255726;
						continue;
					case 2u:
						result2 = result;
						num = (int)((num2 * 255991180) ^ 0x1444BACA);
						continue;
					case 1u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
						num = ((int)num2 * -38869529) ^ 0x3E63C828;
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
				int num = 900101750;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x23E5D274u) % 8u)
					{
					case 6u:
						num = ((int)num2 * -1911039516) ^ 0x1A92FF37;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = -1190578954;
							num4 = -1190578954;
						}
						else
						{
							num3 = -1496187942;
							num4 = -1496187942;
						}
						num = num3 ^ ((int)num2 * -501314210);
						continue;
					}
					case 4u:
						result = 0.0;
						num = 1727896570;
						continue;
					case 2u:
						result2 = 0.0;
						num = ((int)num2 * -1648214854) ^ -1991625819;
						continue;
					case 1u:
						num = (int)((num2 * 565340816) ^ 0x1EA9A5DF);
						continue;
					case 0u:
						result = result2;
						num = ((int)num2 * -1754003622) ^ 0xC91FCC5;
						continue;
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
			Value = value.ToString();
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool result2 = default(bool);
			while (true)
			{
				int num = -2005817314;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD8BFCF60u) % 7u)
					{
					case 4u:
						result2 = !JSONNode.smethod_1(Value);
						num = -394298855;
						continue;
					case 3u:
						num = ((int)num2 * -859778886) ^ 0x3F232315;
						continue;
					case 2u:
						result2 = result;
						num = (int)(num2 * 1410528982) ^ -1128084879;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result))
						{
							num3 = 483333919;
							num4 = 483333919;
						}
						else
						{
							num3 = 309892689;
							num4 = 309892689;
						}
						num = num3 ^ ((int)num2 * -872757778);
						continue;
					}
					case 0u:
						num = ((int)num2 * -428561909) ^ 0x7E72C82A;
						continue;
					case 6u:
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
				int num = 1135670519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x64610DEAu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 530238803) ^ 0x1726AB6B);
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = 1246717628;
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
				int num = -431860070;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEE2E095Cu) % 3u)
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
					num = ((int)num2 * -1454773803) ^ 0x2A8D6F77;
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
			int num = 624982595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2450F6CDu) % 3u)
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
				num = ((int)num2 * -1648348301) ^ 0x2AD1AA82;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -469757587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDDFE2D31u) % 3u)
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
				num = (int)(num2 * 1425169297) ^ -601917486;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		return null;
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		return aNode;
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
			int num = 491770829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85F9237u) % 4u)
				{
				case 2u:
					result = "JSONNode";
					num = (int)((num2 * 250028880) ^ 0x6F6EAFD6);
					continue;
				case 1u:
					num = (int)(num2 * 1166623576) ^ -851888212;
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1080177501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECEB0FB2u) % 4u)
				{
				case 1u:
					result = new JSONData(s);
					num = (int)(num2 * 1853454744) ^ -1381999046;
					continue;
				case 0u:
					num = (int)((num2 * 1284146809) ^ 0x14F7E5BC);
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
			int num = 2059660076;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x76AEC4B3u) % 4u)
				{
				case 3u:
					if (!(d == null))
					{
						num = ((int)num2 * -159042053) ^ 0x4B1BE700;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
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
					num = 1303705534;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 103859341;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x2AA581FAu) % 7u)
				{
				case 6u:
					if (a is JSONLazyCreator)
					{
						num = 1048718077;
						num3 = 1048718077;
						continue;
					}
					goto IL_0011;
				case 5u:
					result = true;
					num = (int)((num2 * 1133343491) ^ 0x6825F40D);
					continue;
				case 4u:
					num = (int)(num2 * 2046070812) ^ -2126930808;
					continue;
				case 2u:
					if (b == null)
					{
						num = (int)(num2 * 415107676) ^ -762349904;
						continue;
					}
					goto IL_0011;
				case 0u:
					result = (object)a == b;
					num = 1881526214;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0011:
					num = 1786294119;
					num3 = 1786294119;
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
			int num = -1821782619;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92F6271Fu) % 3u)
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
				num = ((int)num2 * -982839096) ^ 0x4268AFBD;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -743608499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8655820Au) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = (int)((num2 * 561778796) ^ 0x73375080);
					continue;
				case 2u:
					num = ((int)num2 * -707119422) ^ -1700833213;
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
			int num = -2066479711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D47FC5Bu) % 3u)
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
				num = ((int)num2 * -909620340) ^ -1718712256;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string result = default(string);
		string text = default(string);
		char c = default(char);
		char c2 = default(char);
		char c3 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 442010246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DAF3976u) % 32u)
				{
				case 31u:
					num = ((int)num2 * -403994220) ^ 0x43E5E71B;
					continue;
				case 30u:
					result = text;
					num = ((int)num2 * -1977164344) ^ 0x3640EC20;
					continue;
				case 29u:
					num = (int)((num2 * 1359392135) ^ 0x73895E9C);
					continue;
				case 28u:
					c = c2;
					num = ((int)num2 * -602149941) ^ 0x407570F;
					continue;
				case 27u:
					num = ((int)num2 * -1664876946) ^ 0x73AAC8AD;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, "\\n");
					num = 84190583;
					continue;
				case 25u:
					num = ((int)num2 * -1605161923) ^ -83509472;
					continue;
				case 24u:
					goto IL_0095;
				case 22u:
					goto IL_00ab;
				case 21u:
					goto IL_00c1;
				case 20u:
					num = ((int)num2 * -441867978) ^ 0x4FA85E0F;
					continue;
				case 19u:
					c3 = JSONNode.smethod_2(string_, num3);
					num = 861951934;
					continue;
				case 18u:
					goto IL_00fc;
				case 17u:
					num = ((int)num2 * -648587352) ^ 0x534E3A5F;
					continue;
				case 16u:
					text = "";
					num = (int)(num2 * 1607394603) ^ -64556058;
					continue;
				case 15u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 351250306;
					continue;
				case 13u:
					switch (c)
					{
					case '\n':
						break;
					case '\b':
						goto IL_0095;
					case '\f':
						goto IL_00ab;
					case '\r':
						goto IL_00c1;
					case '\v':
						goto IL_00fc;
					default:
						goto IL_0177;
					case '\t':
						goto IL_018a;
					}
					goto case 26u;
				case 12u:
					goto IL_018a;
				case 11u:
				{
					int num6;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 1870472776;
						num6 = 1870472776;
					}
					else
					{
						num = 379066021;
						num6 = 379066021;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -372752885) ^ -1391529270;
					continue;
				case 9u:
					num = (int)((num2 * 724637757) ^ 0xE27AFF2);
					continue;
				case 8u:
					c2 = c3;
					num = (int)(num2 * 2006409476) ^ -1736277462;
					continue;
				case 7u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 84190583;
					continue;
				case 6u:
					num = (int)(num2 * 1866732926) ^ -367947307;
					continue;
				case 5u:
				{
					int num5;
					if (c != '"')
					{
						num = 1200231695;
						num5 = 1200231695;
					}
					else
					{
						num = 1922834097;
						num5 = 1922834097;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -1953453287) ^ -74542121;
					continue;
				case 3u:
				{
					int num4;
					if (c != '\\')
					{
						num = 1141901084;
						num4 = 1141901084;
					}
					else
					{
						num = 12380569;
						num4 = 12380569;
					}
					continue;
				}
				case 2u:
					num3++;
					num = (int)((num2 * 1663953376) ^ 0x1DC8E45D);
					continue;
				case 1u:
					num = 1157883252;
					continue;
				case 0u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -1752991449) ^ 0x51CA85DD;
					continue;
				case 14u:
					break;
				default:
					{
						return result;
					}
					IL_018a:
					text = JSONNode.smethod_3(text, "\\t");
					num = 329047437;
					continue;
					IL_0177:
					num = (int)(num2 * 1805725901) ^ -2078522565;
					continue;
					IL_00fc:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1706463113;
					continue;
					IL_00c1:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1156034207;
					continue;
					IL_00ab:
					text = JSONNode.smethod_3(text, "\\f");
					num = 578369095;
					continue;
					IL_0095:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1444793867;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		string text2 = default(string);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag2 = default(bool);
		bool flag15 = default(bool);
		bool flag7 = default(bool);
		int num5 = default(int);
		char c5 = default(char);
		bool flag10 = default(bool);
		char c2 = default(char);
		bool flag16 = default(bool);
		bool flag = default(bool);
		char c4 = default(char);
		char c = default(char);
		bool flag5 = default(bool);
		bool flag6 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		bool flag17 = default(bool);
		bool flag13 = default(bool);
		bool flag14 = default(bool);
		bool flag4 = default(bool);
		bool flag9 = default(bool);
		bool flag12 = default(bool);
		char c3 = default(char);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -401352274;
			while (true)
			{
				uint num2;
				int num20;
				string s;
				switch ((num2 = (uint)num ^ 0xA275CA02u) % 151u)
				{
				case 150u:
					num = -285085867;
					continue;
				case 149u:
					num = ((int)num2 * -1764731061) ^ -348368084;
					continue;
				case 148u:
				{
					int num52;
					int num53;
					if (jSONNode != null)
					{
						num52 = -793857680;
						num53 = -793857680;
					}
					else
					{
						num52 = -858432465;
						num53 = -858432465;
					}
					num = num52 ^ (int)(num2 * 129134962);
					continue;
				}
				case 147u:
					num = (int)(num2 * 1628898004) ^ -1965147418;
					continue;
				case 146u:
					jSONNode.Add(text);
					num = (int)(num2 * 1643704261) ^ -1499454027;
					continue;
				case 145u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -592035858) ^ -471654169;
					continue;
				case 144u:
					num = ((int)num2 * -1780917868) ^ -637072364;
					continue;
				case 143u:
					num = ((int)num2 * -870678803) ^ 0x53E95755;
					continue;
				case 142u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num34;
					int num35;
					if (jSONNode is JSONArray)
					{
						num34 = 949603790;
						num35 = 949603790;
					}
					else
					{
						num34 = 1932482386;
						num35 = 1932482386;
					}
					num = num34 ^ ((int)num2 * -1471444386);
					continue;
				}
				case 141u:
					num = (int)((num2 * 2076776724) ^ 0x4B166184);
					continue;
				case 140u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -1968095378;
					continue;
				case 139u:
					num = (int)((num2 * 899550561) ^ 0x7218B37);
					continue;
				case 138u:
					text2 = "";
					num = -625091955;
					continue;
				case 136u:
				{
					int num47;
					int num48;
					if (flag2)
					{
						num47 = -835963561;
						num48 = -835963561;
					}
					else
					{
						num47 = -1446925737;
						num48 = -1446925737;
					}
					num = num47 ^ (int)(num2 * 1167622259);
					continue;
				}
				case 135u:
				{
					int num38;
					int num39;
					if (flag15)
					{
						num38 = -1110569341;
						num39 = -1110569341;
					}
					else
					{
						num38 = -396618086;
						num39 = -396618086;
					}
					num = num38 ^ (int)(num2 * 1269580478);
					continue;
				}
				case 134u:
					num = (int)((num2 * 135759708) ^ 0x2B349DD0);
					continue;
				case 133u:
					num = (int)(num2 * 1644951845) ^ -1290165389;
					continue;
				case 132u:
				{
					int num14;
					int num15;
					if (!flag7)
					{
						num14 = 1334484083;
						num15 = 1334484083;
					}
					else
					{
						num14 = 1888320273;
						num15 = 1888320273;
					}
					num = num14 ^ ((int)num2 * -492685906);
					continue;
				}
				case 131u:
					num = ((int)num2 * -100070150) ^ 0x369126E9;
					continue;
				case 130u:
					stack.Push(new JSONClass());
					num = -1081535193;
					continue;
				case 129u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1612901534) ^ 0x161E231F;
					continue;
				case 128u:
				{
					int num60;
					int num61;
					if (c5 != 'b')
					{
						num60 = 252508750;
						num61 = 252508750;
					}
					else
					{
						num60 = 11270611;
						num61 = 11270611;
					}
					num = num60 ^ ((int)num2 * -1814464648);
					continue;
				}
				case 127u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1443272024) ^ -1472659933;
					continue;
				case 126u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -26942831) ^ -774598495;
					continue;
				case 125u:
				{
					int num54;
					int num55;
					if (flag10)
					{
						num54 = -1913975583;
						num55 = -1913975583;
					}
					else
					{
						num54 = -1794242671;
						num55 = -1794242671;
					}
					num = num54 ^ ((int)num2 * -368132146);
					continue;
				}
				case 124u:
				{
					c5 = c2;
					int num49;
					int num50;
					if ((uint)c5 > 102u)
					{
						num49 = -896802432;
						num50 = -896802432;
					}
					else
					{
						num49 = -208869848;
						num50 = -208869848;
					}
					num = num49 ^ (int)(num2 * 719026089);
					continue;
				}
				case 123u:
					num = -1189298739;
					continue;
				case 122u:
					flag16 = flag;
					num = -1706874063;
					continue;
				case 121u:
				{
					int num42;
					if (flag)
					{
						num = -1788664930;
						num42 = -1788664930;
					}
					else
					{
						num = -746279587;
						num42 = -746279587;
					}
					continue;
				}
				case 119u:
				{
					int num40;
					if (c5 == 'n')
					{
						num = -1559399729;
						num40 = -1559399729;
					}
					else
					{
						num = -582060841;
						num40 = -582060841;
					}
					continue;
				}
				case 71u:
				case 76u:
				case 80u:
				case 114u:
				case 118u:
					num5++;
					num = -1344027145;
					continue;
				case 117u:
				{
					int num31;
					if (c4 == '"')
					{
						num = -624611090;
						num31 = -624611090;
					}
					else
					{
						num = -2030832879;
						num31 = -2030832879;
					}
					continue;
				}
				case 116u:
					num = ((int)num2 * -1757494044) ^ 0x5FF8EA79;
					continue;
				case 115u:
					num = ((int)num2 * -1235364187) ^ 0x4BA32342;
					continue;
				case 112u:
					num = (int)((num2 * 557583744) ^ 0xBBAF27D);
					continue;
				case 111u:
					num = -1401178435;
					continue;
				case 110u:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -429975976;
					continue;
				case 109u:
					switch (c5)
					{
					case 's':
						break;
					default:
						goto IL_0416;
					case 'r':
						goto IL_0420;
					case 't':
						goto IL_0436;
					case 'u':
						goto IL_044c;
					}
					goto case 110u;
				case 87u:
					goto IL_0420;
				case 107u:
					goto IL_0436;
				case 103u:
					goto IL_044c;
				case 108u:
					goto IL_047f;
				case 106u:
					num = ((int)num2 * -1290540380) ^ -1752115909;
					continue;
				case 105u:
					goto IL_04a4;
				case 104u:
					switch (c4)
					{
					case '[':
						break;
					case '\\':
						goto IL_047f;
					default:
						goto IL_04db;
					case ']':
						goto IL_04e5;
					}
					goto case 121u;
				case 97u:
					goto IL_04e5;
				case 102u:
				{
					int num16;
					int num17;
					if (flag5)
					{
						num16 = -1072046977;
						num17 = -1072046977;
					}
					else
					{
						num16 = -1453073988;
						num17 = -1453073988;
					}
					num = num16 ^ (int)(num2 * 1495621117);
					continue;
				}
				case 101u:
					num = ((int)num2 * -608209904) ^ -1924613059;
					continue;
				case 100u:
					flag7 = jSONNode is JSONArray;
					num = (int)(num2 * 1436099055) ^ -1611711219;
					continue;
				case 98u:
					flag6 = JSONNode.smethod_6(text2, "");
					num = -2134573053;
					continue;
				case 96u:
					text2 = text;
					text = "";
					num = -1840700204;
					continue;
				case 95u:
					num = ((int)num2 * -1413198981) ^ 0x3ED45922;
					continue;
				case 94u:
					flag = !flag;
					num = -672995711;
					continue;
				case 93u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num = (int)((num2 * 207615867) ^ 0x79DB4D26);
					continue;
				case 92u:
					text = "";
					num = (int)(num2 * 1143359086) ^ -829581515;
					continue;
				case 91u:
					num = (int)((num2 * 1297243336) ^ 0x2BCBA4DA);
					continue;
				case 90u:
					stack.Push(new JSONArray());
					num = -693906749;
					continue;
				case 89u:
				{
					int num62;
					int num63;
					if ((uint)c4 <= 32u)
					{
						num62 = 1775312112;
						num63 = 1775312112;
					}
					else
					{
						num62 = 1826995547;
						num63 = 1826995547;
					}
					num = num62 ^ ((int)num2 * -1275201655);
					continue;
				}
				case 88u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1227853276;
					continue;
				case 86u:
					num = (int)((num2 * 964210955) ^ 0x6A80548E);
					continue;
				case 85u:
					num = (int)((num2 * 1743036926) ^ 0x36DD85D9);
					continue;
				case 84u:
				{
					int num59;
					if (c4 != ',')
					{
						num = -2076888603;
						num59 = -2076888603;
					}
					else
					{
						num = -1792782445;
						num59 = -1792782445;
					}
					continue;
				}
				case 83u:
				{
					int num58;
					if ((uint)c4 <= 93u)
					{
						num = -1198316265;
						num58 = -1198316265;
					}
					else
					{
						num = -948133878;
						num58 = -948133878;
					}
					continue;
				}
				case 82u:
					result = jSONNode;
					num = -359520752;
					continue;
				case 81u:
				{
					int num56;
					int num57;
					if (c4 == ':')
					{
						num56 = -632377171;
						num57 = -632377171;
					}
					else
					{
						num56 = -1759541065;
						num57 = -1759541065;
					}
					num = num56 ^ (int)(num2 * 2110329870);
					continue;
				}
				case 79u:
					num = ((int)num2 * -1565785672) ^ 0x1B51139D;
					continue;
				case 78u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 193804381) ^ 0x78878984);
					continue;
				case 77u:
					flag8 = stack.Count == 0;
					num = -805630109;
					continue;
				case 75u:
					text2 = "";
					num = -1370759938;
					continue;
				case 74u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1697800715) ^ 0x22B06365;
					continue;
				case 73u:
				{
					int num51;
					if (c4 != '}')
					{
						num = -1260202004;
						num51 = -1260202004;
					}
					else
					{
						num = -719293004;
						num51 = -719293004;
					}
					continue;
				}
				case 72u:
					text = "";
					num = (int)(num2 * 1643368099) ^ -1324913493;
					continue;
				case 70u:
					num = ((int)num2 * -216678368) ^ -759250115;
					continue;
				case 69u:
					text = JSONNode.smethod_3(text, "\f");
					num = -1239566189;
					continue;
				case 68u:
					num = (int)((num2 * 2108543574) ^ 0x6FBA2B7D);
					continue;
				case 67u:
					flag11 = JSONNode.smethod_6(text2, "");
					num = -1996129720;
					continue;
				case 66u:
					jSONNode.Add(text);
					num = ((int)num2 * -690196667) ^ 0x4BDEC178;
					continue;
				case 65u:
				{
					int num45;
					int num46;
					if (!flag17)
					{
						num45 = 1972797036;
						num46 = 1972797036;
					}
					else
					{
						num45 = 1328453174;
						num46 = 1328453174;
					}
					num = num45 ^ ((int)num2 * -327361693);
					continue;
				}
				case 64u:
					num = -940520576;
					continue;
				case 63u:
					num = (int)(num2 * 1003898928) ^ -746214485;
					continue;
				case 62u:
					switch (c4)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_04a4;
					default:
						goto IL_0871;
					case '\t':
						goto IL_0884;
					}
					goto case 71u;
				case 60u:
					goto IL_0884;
				case 61u:
					flag15 = flag;
					num = (int)(num2 * 1839668822) ^ -1742694779;
					continue;
				case 59u:
				{
					int num43;
					int num44;
					if (!flag16)
					{
						num43 = -461170807;
						num44 = -461170807;
					}
					else
					{
						num43 = -1952261082;
						num44 = -1952261082;
					}
					num = num43 ^ ((int)num2 * -44524880);
					continue;
				}
				case 58u:
				{
					int num41;
					if (c5 != 'f')
					{
						num = -965362001;
						num41 = -965362001;
					}
					else
					{
						num = -660518104;
						num41 = -660518104;
					}
					continue;
				}
				case 57u:
				{
					int num36;
					int num37;
					if (flag13)
					{
						num36 = -617190598;
						num37 = -617190598;
					}
					else
					{
						num36 = -1954870504;
						num37 = -1954870504;
					}
					num = num36 ^ ((int)num2 * -801017834);
					continue;
				}
				case 56u:
				{
					int num32;
					int num33;
					if ((uint)c4 > 44u)
					{
						num32 = -231959537;
						num33 = -231959537;
					}
					else
					{
						num32 = -1751362339;
						num33 = -1751362339;
					}
					num = num32 ^ (int)(num2 * 1805872455);
					continue;
				}
				case 55u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -457247971) ^ -1757595462;
					continue;
				case 54u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -801357880) ^ -2046061458;
					continue;
				case 53u:
					num = -1790841660;
					continue;
				case 52u:
				{
					int num30;
					if (c4 == '{')
					{
						num = -584251539;
						num30 = -584251539;
					}
					else
					{
						num = -24476134;
						num30 = -24476134;
					}
					continue;
				}
				case 51u:
					num = (int)((num2 * 1681088851) ^ 0x7F7CB48B);
					continue;
				case 50u:
					num = (int)(num2 * 1383088085) ^ -656397492;
					continue;
				case 49u:
					num5 = 0;
					text = "";
					text2 = "";
					flag = false;
					num = (int)(num2 * 1786507078) ^ -1024514313;
					continue;
				case 48u:
				{
					int num29;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -594102523;
						num29 = -594102523;
					}
					else
					{
						num = -1189298739;
						num29 = -1189298739;
					}
					continue;
				}
				case 47u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 1970735334) ^ 0x69D2E645);
					continue;
				case 46u:
					num = (int)(num2 * 4735998) ^ -1594598187;
					continue;
				case 45u:
					text2 = JSONNode.smethod_5(text2);
					flag14 = jSONNode is JSONArray;
					num = (int)((num2 * 567192798) ^ 0x56BD883C);
					continue;
				case 44u:
				{
					int num27;
					int num28;
					if (!flag14)
					{
						num27 = 824339883;
						num28 = 824339883;
					}
					else
					{
						num27 = 553247752;
						num28 = 553247752;
					}
					num = num27 ^ (int)(num2 * 76274409);
					continue;
				}
				case 43u:
					text = JSONNode.smethod_3(text, "\n");
					num = -1239566189;
					continue;
				case 42u:
					stack.Pop();
					num = -592086655;
					continue;
				case 41u:
					num5 += 4;
					num = (int)((num2 * 433285139) ^ 0x202075C2);
					continue;
				case 40u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -686704562) ^ -1211139083;
					continue;
				case 39u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1080727982) ^ -1601471569;
					continue;
				case 38u:
					flag4 = jSONNode != null;
					num = (int)((num2 * 524007308) ^ 0x4EABD585);
					continue;
				case 37u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -675605688) ^ 0x192E3655;
					continue;
				case 36u:
					num = ((int)num2 * -331143776) ^ -127806830;
					continue;
				case 35u:
					c = JSONNode.smethod_2(aJSON, num5);
					num = (int)(num2 * 535313297) ^ -625141036;
					continue;
				case 34u:
					flag9 = stack.Count > 0;
					num = ((int)num2 * -1416271731) ^ -631817374;
					continue;
				case 33u:
					num = ((int)num2 * -753585060) ^ 0x147DCA79;
					continue;
				case 32u:
					num = ((int)num2 * -1044136809) ^ 0x64EBC547;
					continue;
				case 31u:
					num = ((int)num2 * -1413935161) ^ 0x6E76EBA0;
					continue;
				case 30u:
					num = (int)((num2 * 111155030) ^ 0x78EAFE57);
					continue;
				case 29u:
					flag12 = JSONNode.smethod_6(text2, "");
					num = -1146580705;
					continue;
				case 28u:
				{
					int num26;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -313983338;
						num26 = -313983338;
					}
					else
					{
						num = -1602947624;
						num26 = -1602947624;
					}
					continue;
				}
				case 27u:
					num = ((int)num2 * -1059935828) ^ 0x3798FAF9;
					continue;
				case 26u:
					num = ((int)num2 * -1855890435) ^ -1436861193;
					continue;
				case 25u:
				{
					int num24;
					int num25;
					if (flag12)
					{
						num24 = -1424505810;
						num25 = -1424505810;
					}
					else
					{
						num24 = -1613643864;
						num25 = -1613643864;
					}
					num = num24 ^ ((int)num2 * -1810306375);
					continue;
				}
				case 24u:
				{
					int num22;
					int num23;
					if (flag11)
					{
						num22 = 9394032;
						num23 = 9394032;
					}
					else
					{
						num22 = 235320012;
						num23 = 235320012;
					}
					num = num22 ^ (int)(num2 * 2014439472);
					continue;
				}
				case 23u:
					num = (int)(num2 * 1937580892) ^ -459313295;
					continue;
				case 22u:
					c3 = JSONNode.smethod_2(aJSON, num5);
					num = (int)((num2 * 695573289) ^ 0x4EBF67DD);
					continue;
				case 21u:
				{
					int num21;
					if (c4 != ' ')
					{
						num = -1405680696;
						num21 = -1405680696;
					}
					else
					{
						num = -433629654;
						num21 = -433629654;
					}
					continue;
				}
				case 20u:
					num = (int)(num2 * 621901727) ^ -1830239024;
					continue;
				case 19u:
					num = (int)(num2 * 168880808) ^ -1825921144;
					continue;
				case 18u:
					flag3 = num5 < JSONNode.smethod_4(aJSON);
					num = -260645071;
					continue;
				case 17u:
					flag10 = JSONNode.smethod_6(text, "");
					num = ((int)num2 * -1179488490) ^ 0x47086949;
					continue;
				case 16u:
				{
					int num18;
					int num19;
					if (flag9)
					{
						num18 = 1881322234;
						num19 = 1881322234;
					}
					else
					{
						num18 = 1981865864;
						num19 = 1981865864;
					}
					num = num18 ^ ((int)num2 * -44118115);
					continue;
				}
				case 15u:
				{
					int num12;
					int num13;
					if (!flag8)
					{
						num12 = -1017063455;
						num13 = -1017063455;
					}
					else
					{
						num12 = -1887650551;
						num13 = -1887650551;
					}
					num = num12 ^ ((int)num2 * -824242413);
					continue;
				}
				case 14u:
					c4 = c3;
					num = (int)(num2 * 632826796) ^ -120338328;
					continue;
				case 13u:
				{
					int num10;
					int num11;
					if (!flag6)
					{
						num10 = 428711742;
						num11 = 428711742;
					}
					else
					{
						num10 = 1715419062;
						num11 = 1715419062;
					}
					num = num10 ^ (int)(num2 * 838540304);
					continue;
				}
				case 12u:
				{
					int num8;
					int num9;
					if (!(jSONNode is JSONArray))
					{
						num8 = 104014710;
						num9 = 104014710;
					}
					else
					{
						num8 = 70425295;
						num9 = 70425295;
					}
					num = num8 ^ ((int)num2 * -1646821992);
					continue;
				}
				case 11u:
					flag5 = flag;
					num = -502547952;
					continue;
				case 10u:
					num = (int)((num2 * 407876906) ^ 0x63282FFD);
					continue;
				case 9u:
					text2 = "";
					text = "";
					num = -1929997627;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!flag4)
					{
						num6 = 1570011557;
						num7 = 1570011557;
					}
					else
					{
						num6 = 1744875019;
						num7 = 1744875019;
					}
					num = num6 ^ ((int)num2 * -997402753);
					continue;
				}
				case 7u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1689234265) ^ 0x44ACD1A0;
					continue;
				case 6u:
					num = -151725137;
					continue;
				case 5u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -434939141) ^ 0x2A654AA2;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 536550717) ^ -784081343;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag3)
					{
						num3 = 1459686580;
						num4 = 1459686580;
					}
					else
					{
						num3 = 1077056615;
						num4 = 1077056615;
					}
					num = num3 ^ (int)(num2 * 1894914592);
					continue;
				}
				case 2u:
					num = (int)(num2 * 997154659) ^ -685989064;
					continue;
				case 1u:
					flag2 = flag;
					num = -1260226987;
					continue;
				case 0u:
					c2 = c;
					num = (int)(num2 * 1177038069) ^ -666291528;
					continue;
				case 99u:
					break;
				case 113u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 120u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_04e5:
					if (flag)
					{
						num = -848562749;
						num20 = -848562749;
					}
					else
					{
						num = -2028716225;
						num20 = -2028716225;
					}
					continue;
					IL_04a4:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = -1971212010;
					continue;
					IL_04db:
					num = -1892624210;
					continue;
					IL_044c:
					s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = -1839842789;
					continue;
					IL_047f:
					num5++;
					flag13 = flag;
					num = -1096892826;
					continue;
					IL_0436:
					text = JSONNode.smethod_3(text, "\t");
					num = -1239566189;
					continue;
					IL_0420:
					text = JSONNode.smethod_3(text, "\r");
					num = -1239566189;
					continue;
					IL_0416:
					num = -1305364359;
					continue;
					IL_0884:
					flag17 = flag;
					num = -125210533;
					continue;
					IL_0871:
					num = ((int)num2 * -1567637290) ^ 0x65B4B08;
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
			int num = 2001635005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57AC6812u) % 4u)
				{
				case 3u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -1970004460) ^ 0x7E364A3E;
					continue;
				case 0u:
					Serialize(aWriter);
					num = (int)(num2 * 409291059) ^ -633120613;
					continue;
				default:
					return;
				case 2u:
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
			SaveToStream(fileStream);
			while (true)
			{
				int num = -442442386;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE02660EFu) % 3u)
					{
					case 1u:
						goto IL_0026;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0026:
					num = ((int)num2 * -683905085) ^ -1401528031;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00a1:
					int num3 = -1494140723;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE02660EFu) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1366013140) ^ -1661653154;
							continue;
						case 1u:
							num3 = (int)(num2 * 2074702064) ^ -43431549;
							continue;
						default:
							goto end_IL_0080;
						case 3u:
							break;
						case 0u:
							goto end_IL_0080;
						}
						goto IL_00a1;
						continue;
						end_IL_0080:
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
				int num = 655950519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6A3A391Cu) % 7u)
					{
					case 6u:
						num = ((int)num2 * -410204718) ^ -1895682548;
						continue;
					case 5u:
						num = ((int)num2 * -199190890) ^ 0x3E95B2F4;
						continue;
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1880455325) ^ 0x51A4AC91;
						continue;
					case 2u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -496429568) ^ 0x43064667;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)((num2 * 1237550534) ^ 0x580C7A58);
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
					IL_00e2:
					int num3 = 550294510;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x6A3A391Cu) % 3u)
						{
						case 1u:
							goto IL_00b2;
						default:
							goto end_IL_00c5;
						case 0u:
							break;
						case 2u:
							goto end_IL_00c5;
						}
						goto IL_00e2;
						IL_00b2:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -1509276026) ^ -799616872;
						continue;
						end_IL_00c5:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		JSONArray jSONArray = default(JSONArray);
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		int num7 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		bool flag2 = default(bool);
		int num8 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num5 = default(int);
		bool flag = default(bool);
		int num6 = default(int);
		while (true)
		{
			int num = -187705853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9CF6D6A2u) % 38u)
				{
				case 37u:
					jSONArray = new JSONArray();
					num = (int)((num2 * 255760419) ^ 0x33A54B00);
					continue;
				case 36u:
					num = -780831232;
					continue;
				case 35u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 1319200266) ^ 0xA2E767E);
					continue;
				case 34u:
					num = ((int)num2 * -22903139) ^ 0x3E22AF8E;
					continue;
				case 33u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -2023215327) ^ 0x2C0E0D19;
					continue;
				case 32u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -486498407;
					continue;
				case 31u:
					num = ((int)num2 * -341345974) ^ -1513730973;
					continue;
				case 30u:
					goto IL_00a5;
				case 29u:
					goto IL_00af;
				case 28u:
					num7++;
					num = ((int)num2 * -2124732300) ^ -946715118;
					continue;
				case 26u:
					num = -2111172799;
					continue;
				case 25u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.FloatValue:
						break;
					case JSONBinaryTag.BoolValue:
						goto IL_00a5;
					case JSONBinaryTag.DoubleValue:
						goto IL_00af;
					default:
						goto IL_0100;
					case JSONBinaryTag.Array:
						goto IL_0113;
					case JSONBinaryTag.Class:
						goto IL_0124;
					case JSONBinaryTag.Value:
						goto IL_012e;
					case JSONBinaryTag.IntValue:
						goto IL_0145;
					}
					goto case 32u;
				case 9u:
					goto IL_0113;
				case 6u:
					goto IL_0124;
				case 21u:
					goto IL_012e;
				case 7u:
					goto IL_0145;
				case 24u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1640103073;
						num10 = 1640103073;
					}
					else
					{
						num9 = 633650074;
						num10 = 633650074;
					}
					num = num9 ^ (int)(num2 * 1471119008);
					continue;
				}
				case 23u:
					num = (int)((num2 * 2014036467) ^ 0x2F9A8A1C);
					continue;
				case 20u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1251043903) ^ -1217047401;
					continue;
				case 19u:
					result = jSONClass;
					num = ((int)num2 * -1928712840) ^ 0x5D6C5875;
					continue;
				case 17u:
					num = ((int)num2 * -1294225416) ^ 0x79E10DE0;
					continue;
				case 16u:
					flag2 = num7 < num8;
					num = -1180823618;
					continue;
				case 15u:
				{
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)(num2 * 1439419254) ^ -1996969843;
					continue;
				}
				case 14u:
					num = (int)(num2 * 2076619427) ^ -591519077;
					continue;
				case 13u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1039771868) ^ 0x48054BE8;
					continue;
				case 12u:
					num = (int)(num2 * 26825186) ^ -1488391283;
					continue;
				case 11u:
					num5 = 0;
					num = ((int)num2 * -1188004529) ^ 0x44D422FD;
					continue;
				case 10u:
					num8 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = (int)(num2 * 914259128) ^ -1948364062;
					continue;
				case 8u:
					num7 = 0;
					num = (int)(num2 * 852690990) ^ -988251934;
					continue;
				case 5u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)(num2 * 1943223371) ^ -1698776532;
					continue;
				case 4u:
					flag = num5 < num6;
					num = -1501958999;
					continue;
				case 3u:
					jSONArray.Add(Deserialize(aReader));
					num5++;
					num = -492532118;
					continue;
				case 2u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -194811348) ^ 0x3F8D5F12;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1120337887;
						num4 = 1120337887;
					}
					else
					{
						num3 = 136191694;
						num4 = 136191694;
					}
					num = num3 ^ (int)(num2 * 1080861534);
					continue;
				}
				case 0u:
					result = jSONArray;
					num = ((int)num2 * -1452267898) ^ -82586155;
					continue;
				case 18u:
					break;
				case 22u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0145:
					num = -126218415;
					continue;
					IL_012e:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -568364003;
					continue;
					IL_0124:
					num = -1779698792;
					continue;
					IL_0113:
					num6 = JSONNode.smethod_21(aReader);
					num = -578987893;
					continue;
					IL_0100:
					num = ((int)num2 * -89809376) ^ 0x54D5520B;
					continue;
					IL_00af:
					num = -102944479;
					continue;
					IL_00a5:
					num = -796394600;
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
				int num = -2030534910;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82F41304u) % 3u)
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
					num = (int)((num2 * 1552608575) ^ 0x5D6BB344);
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
					int num3 = -1164396597;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x82F41304u) % 3u)
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
						num3 = ((int)num2 * -998141688) ^ 0x267EAB08;
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
					int num = 395461670;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x575E544Du) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)(num2 * 833053625) ^ -1905288636;
							continue;
						case 2u:
							num = ((int)num2 * -610683285) ^ -80220130;
							continue;
						default:
							goto end_IL_0037;
						case 0u:
							break;
						case 1u:
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
			int num = -44982802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0A7E3DFu) % 5u)
				{
				case 4u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 1994962810) ^ -903297089;
					continue;
				case 3u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 1096552338) ^ 0xBF5276D);
					continue;
				}
				case 1u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 523942075) ^ -1327878350;
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
			int num = -630277600;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD88037F0u) % 3u)
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
				num = (int)(num2 * 948555959) ^ -1806722351;
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
