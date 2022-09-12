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
				int num = -488600456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC829C9CDu) % 3u)
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
					num = (int)((num2 * 1992839699) ^ 0x3988934D);
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
				int num = -267251684;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF0FA1629u) % 4u)
					{
					case 1u:
						result = null;
						num = ((int)num2 * -157981834) ^ 0x240E5DD3;
						continue;
					case 0u:
						num = ((int)num2 * -1860781880) ^ -1881613929;
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
				int num = 1645769550;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A8CAA87u) % 4u)
					{
					case 1u:
						result = "";
						num = (int)((num2 * 697519520) ^ 0x1CE5C6B);
						continue;
					case 0u:
						num = ((int)num2 * -1211250938) ^ 0x67C9A9;
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
			int result = 0;
			while (true)
			{
				int num = -446226251;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA5DBD35u) % 3u)
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
					num = (int)(num2 * 830054099) ^ -387029803;
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
				int num = -2056399882;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD470D377u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 1935333401) ^ -1318844760;
						continue;
					case 4u:
					case 5u:
						num = -1784850324;
						continue;
					case 3u:
						num = (int)((num2 * 420379363) ^ 0x39B20F20);
						continue;
					case 1u:
					{
						int num3;
						num = ((num3 == 0) ? (-835552889) : (-2083022795)) ^ (int)(num2 * 1968761157);
						continue;
					}
					default:
						yield break;
					case 2u:
						break;
					case 0u:
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
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			return _003Cget_DeepChilds_003Ed__;
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result2 = default(int);
			int result = default(int);
			while (true)
			{
				int num = 1034219681;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x25BDF3F0u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (int.TryParse(Value, out result2))
						{
							num3 = -1819670133;
							num4 = -1819670133;
						}
						else
						{
							num3 = -217526063;
							num4 = -217526063;
						}
						num = num3 ^ ((int)num2 * -248908499);
						continue;
					}
					case 6u:
						num = ((int)num2 * -1471266694) ^ 0x376F7218;
						continue;
					case 5u:
						num = ((int)num2 * -205489627) ^ 0x6DA9605;
						continue;
					case 2u:
						result = 0;
						num = 1132902398;
						continue;
					case 1u:
						result2 = 0;
						num = ((int)num2 * -1328937284) ^ -1944951269;
						continue;
					case 0u:
						result = result2;
						num = (int)(num2 * 378441286) ^ -2144664883;
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
			Value = value.ToString();
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
			int num = 1966714301;
			goto IL_0055;
			IL_0055:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15451E73u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 1708626524) ^ -582415989;
					continue;
				case 3u:
					result2 = result;
					num = (int)((num2 * 252020484) ^ 0x5842A1DE);
					continue;
				case 2u:
					num = ((int)num2 * -444792020) ^ 0x2FF8E1FF;
					continue;
				case 0u:
					break;
				case 1u:
					goto IL_007e;
				default:
					return result2;
				}
				break;
			}
			goto IL_0050;
			IL_0050:
			num = 149641516;
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
			double result = default(double);
			double result2 = default(double);
			while (true)
			{
				int num = 277660127;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40790A0Eu) % 7u)
					{
					case 4u:
						result = result2;
						num = ((int)num2 * -945899954) ^ 0x19DF420B;
						continue;
					case 3u:
						result = 0.0;
						num = 1375569676;
						continue;
					case 2u:
					{
						result2 = 0.0;
						int num3;
						int num4;
						if (double.TryParse(Value, out result2))
						{
							num3 = 531240476;
							num4 = 531240476;
						}
						else
						{
							num3 = 1100050504;
							num4 = 1100050504;
						}
						num = num3 ^ (int)(num2 * 776320244);
						continue;
					}
					case 1u:
						num = ((int)num2 * -298878290) ^ -1759457070;
						continue;
					case 0u:
						num = ((int)num2 * -1441660695) ^ 0x1204EC8E;
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
				int num = -1190152082;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA1412BCAu) % 3u)
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
					num = ((int)num2 * -867076688) ^ -1945011989;
				}
			}
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
				int num = 67445208;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E2DE11Cu) % 7u)
					{
					case 6u:
						num = (int)(num2 * 983008130) ^ -1571148874;
						continue;
					case 4u:
						result2 = !JSONNode.smethod_1(Value);
						num = 815484932;
						continue;
					case 3u:
						num = ((int)num2 * -1939382595) ^ -338688086;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result))
						{
							num3 = -133476333;
							num4 = -133476333;
						}
						else
						{
							num3 = -1167201611;
							num4 = -1167201611;
						}
						num = num3 ^ (int)(num2 * 1449737697);
						continue;
					}
					case 0u:
						result2 = result;
						num = (int)((num2 * 1217953922) ^ 0x5B4964DA);
						continue;
					case 5u:
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
				int num = 1173919235;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x39C6BC88) % 3u)
					{
					case 1u:
						value2 = (value ? "true" : "false");
						goto IL_0013;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0013:
					Value = value2;
					num = 819496375;
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
				int num = -947337065;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB030C733u) % 3u)
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
					num = ((int)num2 * -948398776) ^ 0x7B58D3B9;
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
				int num = -409143252;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB7115CABu) % 3u)
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
					result = this as JSONClass;
					num = ((int)num2 * -1147800977) ^ -1543259400;
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
			int num = 1962118922;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53255E5Fu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1370149387) ^ 0x6461100A;
					continue;
				case 1u:
					Add("", aItem);
					num = ((int)num2 * -795757048) ^ -1239703392;
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

	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1460217374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2EE06D5u) % 3u)
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
				num = (int)((num2 * 524403914) ^ 0x3E6A3858);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1841430487;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DFF26F4u) % 4u)
				{
				case 3u:
					result = aNode;
					num = ((int)num2 * -2034636122) ^ -2032710832;
					continue;
				case 2u:
					num = (int)((num2 * 1297583543) ^ 0x11CE0AD7);
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
		string result = default(string);
		while (true)
		{
			int num = 1898927091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C6DAB2Fu) % 3u)
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
				result = "JSONNode";
				num = (int)((num2 * 162618856) ^ 0x587B7B17);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1452542346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85BCF50Au) % 3u)
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
				num = ((int)num2 * -1503267885) ^ 0x47DFB3B9;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1716005469;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x420E686Du) % 3u)
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
				result = new JSONData(s);
				num = (int)(num2 * 471856674) ^ -370563849;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 403092116;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x283A3D73u) % 5u)
				{
				case 4u:
					obj = d.Value;
					goto IL_0009;
				case 2u:
					if (!(d == null))
					{
						num = (int)(num2 * 211560771) ^ -1925457439;
						continue;
					}
					obj = null;
					goto IL_0009;
				case 1u:
					num = ((int)num2 * -1631267719) ^ 0x3C2A94BB;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = 1185235799;
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
			goto IL_002a;
		}
		int num = 0;
		goto IL_007e;
		IL_0075:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_007e;
		IL_002a:
		int num2 = -1797390846;
		goto IL_004c;
		IL_004c:
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x9F213F44u) % 6u)
			{
			case 5u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -160359559;
					num5 = -160359559;
				}
				else
				{
					num4 = -1460709574;
					num5 = -1460709574;
				}
				num2 = num4 ^ (int)(num3 * 1609396317);
				continue;
			}
			case 3u:
				break;
			case 1u:
				result = (object)a == b;
				num2 = -918011342;
				continue;
			case 0u:
				result = true;
				num2 = ((int)num3 * -870510626) ^ -2022285698;
				continue;
			case 4u:
				goto IL_0075;
			default:
				return result;
			}
			break;
		}
		goto IL_002a;
		IL_007e:
		flag = (byte)num != 0;
		num2 = -316259593;
		goto IL_004c;
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
			int num = -870031348;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF879E397u) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = ((int)num2 * -552625722) ^ -1386272761;
					continue;
				case 2u:
					num = (int)((num2 * 1666063576) ^ 0x2764E842);
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
			int num = -2023662108;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x906276FEu) % 3u)
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
				num = ((int)num2 * -196484107) ^ 0x6616152D;
			}
		}
	}

	internal static string Escape(string aText)
	{
		char c = default(char);
		char c3 = default(char);
		char c2 = default(char);
		string text = default(string);
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 496288502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4128427Eu) % 32u)
				{
				case 31u:
				{
					int num6;
					if (c != '"')
					{
						num = 1925327814;
						num6 = 1925327814;
					}
					else
					{
						num = 281278206;
						num6 = 281278206;
					}
					continue;
				}
				case 30u:
					c3 = c2;
					num = ((int)num2 * -1455387850) ^ 0x5F98F3A1;
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, "\\b");
					num = 668570861;
					continue;
				case 28u:
					num = (int)(num2 * 1469647554) ^ -1919966743;
					continue;
				case 27u:
					goto IL_0067;
				case 26u:
					num = ((int)num2 * -1367508293) ^ -315659457;
					continue;
				case 24u:
					num = (int)((num2 * 1643292893) ^ 0x66DB3801);
					continue;
				case 23u:
					goto IL_00a3;
				case 22u:
					num = ((int)num2 * -1119403006) ^ -1229545578;
					continue;
				case 21u:
					num = (int)(num2 * 562373022) ^ -339646681;
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 880131042;
					continue;
				case 19u:
					num = (int)((num2 * 527531305) ^ 0x54D8C55A);
					continue;
				case 18u:
					result = text;
					num = ((int)num2 * -1564870252) ^ -1631484230;
					continue;
				case 17u:
					switch (c)
					{
					case '\b':
						break;
					case '\r':
						goto IL_0067;
					case '\t':
						goto IL_00a3;
					default:
						goto IL_013f;
					case '\n':
						goto IL_0152;
					case '\v':
						goto IL_0168;
					case '\f':
						goto IL_0180;
					}
					goto case 29u;
				case 5u:
					goto IL_0152;
				case 4u:
					goto IL_0168;
				case 13u:
					goto IL_0180;
				case 16u:
					num = (int)((num2 * 1157997439) ^ 0x6245C288);
					continue;
				case 15u:
					num = 341874420;
					continue;
				case 14u:
					c2 = JSONNode.smethod_2(string_, num3);
					num = 1852546112;
					continue;
				case 11u:
					c = c3;
					num = (int)((num2 * 1648916136) ^ 0x66FCF57);
					continue;
				case 10u:
					num3++;
					num = (int)((num2 * 80906706) ^ 0x72E6B168);
					continue;
				case 9u:
					num = (int)(num2 * 1810377728) ^ -1834684975;
					continue;
				case 8u:
					text = "";
					num = (int)((num2 * 1207079224) ^ 0x3FB0684E);
					continue;
				case 7u:
				{
					int num5;
					if (c != '\\')
					{
						num = 320406024;
						num5 = 320406024;
					}
					else
					{
						num = 88458794;
						num5 = 88458794;
					}
					continue;
				}
				case 6u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -869813038) ^ 0x413AE6F0;
					continue;
				case 3u:
					num = ((int)num2 * -1811720817) ^ -2083392996;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 1074805420;
						num4 = 1074805420;
					}
					else
					{
						num = 703361136;
						num4 = 703361136;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -754783046) ^ -379261653;
					continue;
				case 0u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1522848919;
					continue;
				case 25u:
					break;
				default:
					{
						return result;
					}
					IL_0180:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1475160221;
					continue;
					IL_0168:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1119674833;
					continue;
					IL_0152:
					text = JSONNode.smethod_3(text, "\\n");
					num = 878761963;
					continue;
					IL_013f:
					num = ((int)num2 * -280958208) ^ -681858332;
					continue;
					IL_00a3:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1119674833;
					continue;
					IL_0067:
					text = JSONNode.smethod_3(text, "\\r");
					num = 981847263;
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
		JSONNode result = default(JSONNode);
		int num3 = default(int);
		string text = default(string);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		char c2 = default(char);
		bool flag = default(bool);
		string text2 = default(string);
		char c3 = default(char);
		bool flag9 = default(bool);
		bool flag12 = default(bool);
		bool flag3 = default(bool);
		bool flag13 = default(bool);
		bool flag6 = default(bool);
		bool flag10 = default(bool);
		string s = default(string);
		bool flag5 = default(bool);
		char c5 = default(char);
		char c = default(char);
		char c4 = default(char);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = -1094934117;
			while (true)
			{
				uint num2;
				int num54;
				switch ((num2 = (uint)num ^ 0xC7C6A5FBu) % 150u)
				{
				case 149u:
					result = jSONNode;
					num = -960030441;
					continue;
				case 148u:
					num3 = 0;
					text = "";
					num = (int)(num2 * 1472997260) ^ -1675947413;
					continue;
				case 147u:
					text = JSONNode.smethod_3(text, "\n");
					num = -2112035733;
					continue;
				case 146u:
				{
					int num6;
					int num7;
					if (!flag4)
					{
						num6 = -1892930204;
						num7 = -1892930204;
					}
					else
					{
						num6 = -722612916;
						num7 = -722612916;
					}
					num = num6 ^ ((int)num2 * -830655492);
					continue;
				}
				case 145u:
				{
					int num41;
					if (!flag7)
					{
						num = -156412402;
						num41 = -156412402;
					}
					else
					{
						num = -1932609422;
						num41 = -1932609422;
					}
					continue;
				}
				case 144u:
				{
					int num58;
					int num59;
					if (c2 != ':')
					{
						num58 = 914480197;
						num59 = 914480197;
					}
					else
					{
						num58 = 1899455219;
						num59 = 1899455219;
					}
					num = num58 ^ (int)(num2 * 1674182409);
					continue;
				}
				case 143u:
				{
					int num26;
					int num27;
					if (!flag)
					{
						num26 = -1510336694;
						num27 = -1510336694;
					}
					else
					{
						num26 = -1882164546;
						num27 = -1882164546;
					}
					num = num26 ^ (int)(num2 * 846780550);
					continue;
				}
				case 142u:
					num = (int)(num2 * 2013651605) ^ -1076047286;
					continue;
				case 141u:
				{
					int num57;
					if (c2 != ',')
					{
						num = -1852325731;
						num57 = -1852325731;
					}
					else
					{
						num = -334725355;
						num57 = -334725355;
					}
					continue;
				}
				case 140u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -664505574) ^ 0x38A81E00;
					continue;
				case 139u:
				{
					int num53;
					if (c3 == 'f')
					{
						num = -272157901;
						num53 = -272157901;
					}
					else
					{
						num = -1956158970;
						num53 = -1956158970;
					}
					continue;
				}
				case 138u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1062831608) ^ 0x1F5D95E0;
					continue;
				case 137u:
					num = ((int)num2 * -49279626) ^ 0x413A8EBC;
					continue;
				case 136u:
					num = ((int)num2 * -934749785) ^ 0x4D53EFA6;
					continue;
				case 134u:
				{
					int num42;
					if (c2 == '}')
					{
						num = -2010856968;
						num42 = -2010856968;
					}
					else
					{
						num = -1364361960;
						num42 = -1364361960;
					}
					continue;
				}
				case 133u:
					num = -353078858;
					continue;
				case 132u:
					num = ((int)num2 * -1245701418) ^ -1406466014;
					continue;
				case 131u:
					num = -709719202;
					continue;
				case 130u:
				{
					int num18;
					int num19;
					if (flag9)
					{
						num18 = 556943543;
						num19 = 556943543;
					}
					else
					{
						num18 = 1218738571;
						num19 = 1218738571;
					}
					num = num18 ^ ((int)num2 * -518249673);
					continue;
				}
				case 129u:
					num = (int)((num2 * 1974915215) ^ 0x9EB4833);
					continue;
				case 128u:
					num = (int)((num2 * 1873872650) ^ 0x5500D45A);
					continue;
				case 127u:
					num = (int)((num2 * 1711982648) ^ 0x5AE3784E);
					continue;
				case 126u:
					num = (int)(num2 * 700286197) ^ -814862506;
					continue;
				case 125u:
					flag = jSONNode is JSONArray;
					num = (int)((num2 * 1451231158) ^ 0x2FDD5742);
					continue;
				case 124u:
				{
					int num55;
					int num56;
					if (flag12)
					{
						num55 = -692145730;
						num56 = -692145730;
					}
					else
					{
						num55 = -178836528;
						num56 = -178836528;
					}
					num = num55 ^ ((int)num2 * -1254270807);
					continue;
				}
				case 123u:
				{
					int num52;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -68115706;
						num52 = -68115706;
					}
					else
					{
						num = -919733627;
						num52 = -919733627;
					}
					continue;
				}
				case 122u:
				{
					int num49;
					if (flag7)
					{
						num = -160404056;
						num49 = -160404056;
					}
					else
					{
						num = -2108383480;
						num49 = -2108383480;
					}
					continue;
				}
				case 121u:
				{
					int num45;
					int num46;
					if (flag3)
					{
						num45 = -28316493;
						num46 = -28316493;
					}
					else
					{
						num45 = -1628595688;
						num46 = -1628595688;
					}
					num = num45 ^ ((int)num2 * -832558376);
					continue;
				}
				case 120u:
				{
					int num37;
					int num38;
					if (!flag13)
					{
						num37 = -346358288;
						num38 = -346358288;
					}
					else
					{
						num37 = -233360179;
						num38 = -233360179;
					}
					num = num37 ^ (int)(num2 * 193903628);
					continue;
				}
				case 119u:
					flag6 = num3 < JSONNode.smethod_4(aJSON);
					num = -21888233;
					continue;
				case 118u:
				{
					int num33;
					int num34;
					if (!flag7)
					{
						num33 = 56397406;
						num34 = 56397406;
					}
					else
					{
						num33 = 1884325056;
						num34 = 1884325056;
					}
					num = num33 ^ ((int)num2 * -1227145631);
					continue;
				}
				case 116u:
					text2 = "";
					text = "";
					num = -1441543189;
					continue;
				case 115u:
					num = ((int)num2 * -1646460542) ^ -28985749;
					continue;
				case 114u:
					goto IL_03ae;
				case 113u:
					num3 += 4;
					num = (int)(num2 * 2015128331) ^ -515046895;
					continue;
				case 67u:
				case 70u:
				case 91u:
				case 92u:
				case 112u:
					num3++;
					num = -1428951019;
					continue;
				case 111u:
					text2 = "";
					num = -1521099909;
					continue;
				case 110u:
				{
					int num23;
					if (c2 != '{')
					{
						num = -90451236;
						num23 = -90451236;
					}
					else
					{
						num = -1246698078;
						num23 = -1246698078;
					}
					continue;
				}
				case 109u:
					flag10 = JSONNode.smethod_6(text2, "");
					num = -1799108520;
					continue;
				case 108u:
					flag7 = !flag7;
					num = -906695450;
					continue;
				case 107u:
					text2 = "";
					text = "";
					num = -447766708;
					continue;
				case 106u:
					num = (int)((num2 * 1104795121) ^ 0x2E16309A);
					continue;
				case 105u:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = (int)((num2 * 1131277139) ^ 0x677095CA);
					continue;
				case 104u:
				{
					int num16;
					if (c2 != ' ')
					{
						num = -134755176;
						num16 = -134755176;
					}
					else
					{
						num = -1420373809;
						num16 = -1420373809;
					}
					continue;
				}
				case 102u:
					jSONNode.Add(text);
					num = ((int)num2 * -1315728509) ^ -212620226;
					continue;
				case 101u:
					num = ((int)num2 * -1081125449) ^ 0xFB0541;
					continue;
				case 100u:
					num = ((int)num2 * -1443446029) ^ -468674851;
					continue;
				case 99u:
					num = ((int)num2 * -1737641658) ^ -734984587;
					continue;
				case 98u:
				{
					int num8;
					int num9;
					if (flag5)
					{
						num8 = 602324043;
						num9 = 602324043;
					}
					else
					{
						num8 = 1120797424;
						num9 = 1120797424;
					}
					num = num8 ^ ((int)num2 * -93602737);
					continue;
				}
				case 97u:
				{
					int num60;
					int num61;
					if (JSONNode.smethod_6(text, ""))
					{
						num60 = -1033771633;
						num61 = -1033771633;
					}
					else
					{
						num60 = -383161259;
						num61 = -383161259;
					}
					num = num60 ^ (int)(num2 * 1961713720);
					continue;
				}
				case 96u:
					num = ((int)num2 * -704009394) ^ -118903022;
					continue;
				case 95u:
					switch (c2)
					{
					case '[':
						goto IL_0596;
					case '\\':
						goto IL_05b6;
					case ']':
						goto IL_05c4;
					}
					num = -1730338397;
					continue;
				case 21u:
					goto IL_0596;
				case 29u:
					goto IL_05b6;
				case 3u:
					goto IL_05c4;
				case 94u:
					text = "";
					jSONNode = stack.Peek();
					num = (int)((num2 * 536422406) ^ 0x672CB40B);
					continue;
				case 93u:
				{
					c3 = c5;
					int num50;
					int num51;
					if ((uint)c3 <= 102u)
					{
						num50 = 1843751274;
						num51 = 1843751274;
					}
					else
					{
						num50 = 1372061392;
						num51 = 1372061392;
					}
					num = num50 ^ ((int)num2 * -480514691);
					continue;
				}
				case 90u:
				{
					int num47;
					int num48;
					if (jSONNode != null)
					{
						num47 = -883197531;
						num48 = -883197531;
					}
					else
					{
						num47 = -476252554;
						num48 = -476252554;
					}
					num = num47 ^ (int)(num2 * 1775938730);
					continue;
				}
				case 89u:
					stack.Push(new JSONClass());
					num = -672881568;
					continue;
				case 88u:
					flag9 = stack.Count > 0;
					num = (int)(num2 * 498612314) ^ -1441702977;
					continue;
				case 87u:
					text2 = JSONNode.smethod_5(text2);
					flag5 = jSONNode is JSONArray;
					num = ((int)num2 * -1781978269) ^ 0x9D9F09E;
					continue;
				case 86u:
					flag7 = false;
					num = (int)((num2 * 1387164991) ^ 0x55740328);
					continue;
				case 85u:
					c = JSONNode.smethod_2(aJSON, num3);
					num = -2133919413;
					continue;
				case 84u:
					goto IL_06d2;
				case 83u:
					c4 = JSONNode.smethod_2(aJSON, num3);
					c5 = c4;
					num = ((int)num2 * -919148151) ^ -537248505;
					continue;
				case 82u:
					num = (int)((num2 * 355288548) ^ 0x1DC72876);
					continue;
				case 81u:
					num = (int)(num2 * 634799169) ^ -580165131;
					continue;
				case 80u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -105233740) ^ -531037282;
					continue;
				case 79u:
					num = (int)((num2 * 12587838) ^ 0x2EA8CEFC);
					continue;
				case 78u:
					num = ((int)num2 * -386759180) ^ 0x1D2A623E;
					continue;
				case 77u:
					num = ((int)num2 * -1472219067) ^ -1397633837;
					continue;
				case 76u:
					text = JSONNode.smethod_3(text, "\f");
					num = -836748458;
					continue;
				case 75u:
				{
					int num43;
					int num44;
					if (flag10)
					{
						num43 = -761246964;
						num44 = -761246964;
					}
					else
					{
						num43 = -1759471195;
						num44 = -1759471195;
					}
					num = num43 ^ ((int)num2 * -646366525);
					continue;
				}
				case 74u:
					text = JSONNode.smethod_3(text, "\b");
					num = -185636489;
					continue;
				case 73u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 2024468541) ^ -1411036772;
					continue;
				case 72u:
					num = ((int)num2 * -1085261346) ^ 0x1DDA415F;
					continue;
				case 71u:
					flag13 = JSONNode.smethod_6(text2, "");
					num = -642111989;
					continue;
				case 69u:
					text2 = "";
					num = -1936493508;
					continue;
				case 68u:
				{
					int num39;
					int num40;
					if ((uint)c2 <= 44u)
					{
						num39 = 505210635;
						num40 = 505210635;
					}
					else
					{
						num39 = 206180373;
						num40 = 206180373;
					}
					num = num39 ^ ((int)num2 * -912270299);
					continue;
				}
				case 66u:
					num = ((int)num2 * -206670309) ^ -1193323692;
					continue;
				case 65u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1413228744) ^ -787395784;
					continue;
				case 64u:
					num = ((int)num2 * -607535502) ^ -288862767;
					continue;
				case 63u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1271311792) ^ -1220803978;
					continue;
				case 62u:
					goto IL_08da;
				case 61u:
					num = (int)((num2 * 775620817) ^ 0x777D3CDC);
					continue;
				case 60u:
					jSONNode.Add(text);
					num = ((int)num2 * -381538052) ^ -803463021;
					continue;
				case 59u:
					num = ((int)num2 * -290574449) ^ 0x54832B86;
					continue;
				case 58u:
					text2 = "";
					num = (int)(num2 * 1094259385) ^ -818572351;
					continue;
				case 57u:
				{
					int num35;
					int num36;
					if (!flag2)
					{
						num35 = 230108846;
						num36 = 230108846;
					}
					else
					{
						num35 = 2044311278;
						num36 = 2044311278;
					}
					num = num35 ^ ((int)num2 * -2030374685);
					continue;
				}
				case 56u:
					flag4 = flag7;
					num = -1507961527;
					continue;
				case 55u:
					num = ((int)num2 * -1991980165) ^ -1021891810;
					continue;
				case 54u:
					num = -1765227571;
					continue;
				case 53u:
				{
					int num31;
					int num32;
					if (flag7)
					{
						num31 = -1481886027;
						num32 = -1481886027;
					}
					else
					{
						num31 = -1074828651;
						num32 = -1074828651;
					}
					num = num31 ^ ((int)num2 * -141658649);
					continue;
				}
				case 52u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1211348074) ^ 0x485F5993;
					continue;
				case 51u:
					text2 = text;
					text = "";
					num = -255552391;
					continue;
				case 50u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -205699981) ^ -1260574036;
					continue;
				case 49u:
					switch (c3)
					{
					case 'u':
						break;
					case 'r':
						goto IL_03ae;
					case 't':
						goto IL_08da;
					default:
						goto IL_0a3b;
					case 's':
						goto IL_0a45;
					}
					goto case 131u;
				case 24u:
					goto IL_0a45;
				case 48u:
					num = (int)((num2 * 977208457) ^ 0x56A8F7EE);
					continue;
				case 47u:
					num = ((int)num2 * -469208949) ^ -28106049;
					continue;
				case 46u:
				{
					int num29;
					int num30;
					if ((uint)c2 > 32u)
					{
						num29 = 253931214;
						num30 = 253931214;
					}
					else
					{
						num29 = 799439969;
						num30 = 799439969;
					}
					num = num29 ^ (int)(num2 * 894846696);
					continue;
				}
				case 45u:
					num = -1538974376;
					continue;
				case 44u:
				{
					int num28;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -1273161845;
						num28 = -1273161845;
					}
					else
					{
						num = -1864364407;
						num28 = -1864364407;
					}
					continue;
				}
				case 43u:
					num = -1321065264;
					continue;
				case 42u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1801741891) ^ -36093902;
					continue;
				case 41u:
					flag12 = jSONNode != null;
					num = ((int)num2 * -2026025035) ^ -1678380476;
					continue;
				case 40u:
					num = ((int)num2 * -720173714) ^ 0x229657B2;
					continue;
				case 39u:
				{
					int num24;
					int num25;
					if (!flag11)
					{
						num24 = 1653028052;
						num25 = 1653028052;
					}
					else
					{
						num24 = 154092445;
						num25 = 154092445;
					}
					num = num24 ^ ((int)num2 * -1467930148);
					continue;
				}
				case 38u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1617445504) ^ 0x2CD27CCC;
					continue;
				case 37u:
				{
					int num21;
					int num22;
					if (flag8)
					{
						num21 = 887543567;
						num22 = 887543567;
					}
					else
					{
						num21 = 1859168891;
						num22 = 1859168891;
					}
					num = num21 ^ (int)(num2 * 1971441470);
					continue;
				}
				case 36u:
				{
					int num20;
					if ((uint)c2 <= 93u)
					{
						num = -1133786605;
						num20 = -1133786605;
					}
					else
					{
						num = -849988303;
						num20 = -849988303;
					}
					continue;
				}
				case 35u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -762938079) ^ 0x2AE418EE;
					continue;
				case 34u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 367311017) ^ 0x6D84FF6C);
					continue;
				case 33u:
				{
					int num17;
					if (c2 != '"')
					{
						num = -556485278;
						num17 = -556485278;
					}
					else
					{
						num = -1089271481;
						num17 = -1089271481;
					}
					continue;
				}
				case 32u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_06d2;
					default:
						goto IL_0c59;
					case '\t':
						goto IL_0c6c;
					}
					goto case 67u;
				case 16u:
					goto IL_0c6c;
				case 31u:
					num = (int)(num2 * 1155267354) ^ -631134399;
					continue;
				case 30u:
				{
					int num14;
					int num15;
					if (!(jSONNode is JSONArray))
					{
						num14 = -890694928;
						num15 = -890694928;
					}
					else
					{
						num14 = -389207021;
						num15 = -389207021;
					}
					num = num14 ^ (int)(num2 * 251752561);
					continue;
				}
				case 28u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -1407993157) ^ 0x55579DC0;
					continue;
				case 27u:
					num = ((int)num2 * -1872019673) ^ -1867379538;
					continue;
				case 26u:
					num = ((int)num2 * -54881832) ^ 0x51AC8B56;
					continue;
				case 25u:
					num = (int)((num2 * 1745637944) ^ 0x516D8B3);
					continue;
				case 23u:
					num = (int)(num2 * 424952058) ^ -374640494;
					continue;
				case 22u:
				{
					int num12;
					int num13;
					if (c3 != 'b')
					{
						num12 = -753944752;
						num13 = -753944752;
					}
					else
					{
						num12 = -448600037;
						num13 = -448600037;
					}
					num = num12 ^ (int)(num2 * 263586100);
					continue;
				}
				case 20u:
				{
					int num10;
					int num11;
					if (flag6)
					{
						num10 = -402637422;
						num11 = -402637422;
					}
					else
					{
						num10 = -537814376;
						num11 = -537814376;
					}
					num = num10 ^ ((int)num2 * -1040635842);
					continue;
				}
				case 19u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -543433480) ^ 0x3DC03C40;
					continue;
				case 18u:
				{
					int num5;
					if (c3 != 'n')
					{
						num = -922747177;
						num5 = -922747177;
					}
					else
					{
						num = -478301762;
						num5 = -478301762;
					}
					continue;
				}
				case 15u:
					stack.Pop();
					num = -370137522;
					continue;
				case 14u:
					stack.Push(new JSONArray());
					num = -98111077;
					continue;
				case 13u:
					text = "";
					num = ((int)num2 * -1528180784) ^ -357198768;
					continue;
				case 12u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 479002320) ^ -1424218695;
					continue;
				case 11u:
					flag3 = JSONNode.smethod_6(text, "");
					num = -1526186976;
					continue;
				case 10u:
					flag2 = jSONNode is JSONArray;
					num = ((int)num2 * -56977529) ^ 0x695A24EC;
					continue;
				case 9u:
					num = -1764404808;
					continue;
				case 8u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -436768906) ^ 0x41D5DD57;
					continue;
				case 7u:
					num = (int)(num2 * 764128388) ^ -949561670;
					continue;
				case 6u:
					num = (int)(num2 * 1405954563) ^ -1682575532;
					continue;
				case 5u:
				{
					int num4;
					if (stack.Count == 0)
					{
						num = -2110305196;
						num4 = -2110305196;
					}
					else
					{
						num = -943853544;
						num4 = -943853544;
					}
					continue;
				}
				case 4u:
					num = (int)(num2 * 755354160) ^ -1120152225;
					continue;
				case 2u:
					c2 = c;
					num = (int)((num2 * 240396199) ^ 0x7E5217E9);
					continue;
				case 1u:
					num = ((int)num2 * -825431726) ^ 0x6876956;
					continue;
				case 0u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -491507464) ^ 0x43C92EC6;
					continue;
				case 135u:
					break;
				case 103u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 117u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0c6c:
					flag8 = flag7;
					num = -1803479372;
					continue;
					IL_0c59:
					num = (int)((num2 * 290301896) ^ 0x4059AA50);
					continue;
					IL_03ae:
					text = JSONNode.smethod_3(text, "\r");
					num = -836748458;
					continue;
					IL_0a45:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = -180826306;
					continue;
					IL_0a3b:
					num = -1774156695;
					continue;
					IL_08da:
					text = JSONNode.smethod_3(text, "\t");
					num = -1805006603;
					continue;
					IL_06d2:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = -1119760193;
					continue;
					IL_05c4:
					flag11 = flag7;
					num = -1832041572;
					continue;
					IL_05b6:
					num3++;
					num = -1745260227;
					continue;
					IL_0596:
					if (flag7)
					{
						num = -1333587885;
						num54 = -1333587885;
					}
					else
					{
						num = -1753281963;
						num54 = -1753281963;
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
		while (true)
		{
			int num = -1226831809;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92298760u) % 3u)
				{
				case 1u:
					goto IL_0010;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0010:
				num = ((int)num2 * -1226241487) ^ 0x1AD02C8F;
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
				int num = 1309098133;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20CF528Eu) % 3u)
					{
					case 1u:
						goto IL_0020;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0020:
					SaveToStream(fileStream);
					num = ((int)num2 * -1189291225) ^ -469185372;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008f:
					int num3 = 630184424;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x20CF528Eu) % 3u)
						{
						case 1u:
							goto IL_005f;
						default:
							goto end_IL_0072;
						case 0u:
							break;
						case 2u:
							goto end_IL_0072;
						}
						goto IL_008f;
						IL_005f:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = ((int)num2 * -636192773) ^ -1115036330;
						continue;
						end_IL_0072:
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
				int num = 480480371;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EAB827Cu) % 6u)
					{
					case 4u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 1922270440) ^ 0x1E0545EA);
						continue;
					case 3u:
						SaveToStream(memoryStream);
						num = (int)((num2 * 320880408) ^ 0x2D296B61);
						continue;
					case 2u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 203979304) ^ 0x272E8FD0);
						continue;
					case 1u:
						num = (int)((num2 * 1850950991) ^ 0x17AEB719);
						continue;
					case 5u:
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
					IL_00cf:
					int num3 = 605376989;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x7EAB827Cu) % 3u)
						{
						case 1u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 0u:
							break;
						case 2u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -734516328) ^ -900513964;
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
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		int num4 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num7 = default(int);
		JSONNode result = default(JSONNode);
		int num3 = default(int);
		while (true)
		{
			int num = -1693674670;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE714BA08u) % 39u)
				{
				case 38u:
					num6++;
					num = ((int)num2 * -422300577) ^ -768984929;
					continue;
				case 37u:
					num = ((int)num2 * -1769823792) ^ 0x3D1ABF15;
					continue;
				case 36u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -1691632325) ^ -1624960781;
					continue;
				case 35u:
					num = -2028096766;
					continue;
				case 33u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Array:
						break;
					default:
						goto IL_0075;
					case JSONBinaryTag.Class:
						goto IL_0088;
					case JSONBinaryTag.Value:
						goto IL_009a;
					case JSONBinaryTag.IntValue:
						goto IL_00a4;
					case JSONBinaryTag.DoubleValue:
						goto IL_00bb;
					case JSONBinaryTag.BoolValue:
						goto IL_00c5;
					case JSONBinaryTag.FloatValue:
						goto IL_00cf;
					}
					goto case 35u;
				case 17u:
					goto IL_0088;
				case 32u:
					goto IL_009a;
				case 25u:
					goto IL_00a4;
				case 4u:
					goto IL_00bb;
				case 26u:
					goto IL_00c5;
				case 27u:
					goto IL_00cf;
				case 31u:
					num = ((int)num2 * -1067214070) ^ 0x72186E9;
					continue;
				case 30u:
					jSONArray.Add(Deserialize(aReader));
					num = -502630260;
					continue;
				case 29u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1799394524) ^ 0x4006DE01);
					continue;
				case 28u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -135040479) ^ -1257955373;
					continue;
				}
				case 24u:
					num = (int)(num2 * 1989886972) ^ -1047798395;
					continue;
				case 23u:
					aKey = JSONNode.smethod_22(aReader);
					num = -215742950;
					continue;
				case 21u:
					num = (int)(num2 * 373962449) ^ -92910021;
					continue;
				case 20u:
					num = ((int)num2 * -1875889859) ^ -1350678464;
					continue;
				case 19u:
					num4 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 397338679) ^ 0x34DECB62);
					continue;
				case 18u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)((num2 * 1867468213) ^ 0x5EAEF387);
					continue;
				case 16u:
				{
					int num8;
					if (num6 < num7)
					{
						num = -2046921169;
						num8 = -2046921169;
					}
					else
					{
						num = -1919630044;
						num8 = -1919630044;
					}
					continue;
				}
				case 15u:
					num = ((int)num2 * -1330708235) ^ 0x24D12052;
					continue;
				case 14u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)(num2 * 1640283326) ^ -470330024;
					continue;
				case 13u:
					num = (int)((num2 * 1454136136) ^ 0x531A45D5);
					continue;
				case 12u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -760833138) ^ -350286906;
					continue;
				case 11u:
					jSONArray = new JSONArray();
					num3 = 0;
					num = ((int)num2 * -505261031) ^ -1592645271;
					continue;
				case 10u:
					num3++;
					num = (int)((num2 * 989426311) ^ 0x7F569599);
					continue;
				case 9u:
					num = ((int)num2 * -269935309) ^ -2062119748;
					continue;
				case 8u:
					result = jSONArray;
					num = ((int)num2 * -582197272) ^ -736225589;
					continue;
				case 7u:
					num = ((int)num2 * -9185505) ^ 0x704858A7;
					continue;
				case 6u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -754260666) ^ 0x326A1E6;
					continue;
				case 5u:
					num = (int)((num2 * 1351546952) ^ 0x45C1E254);
					continue;
				case 2u:
					num6 = 0;
					num = (int)((num2 * 780039848) ^ 0x172CB96F);
					continue;
				case 1u:
				{
					int num5;
					if (num3 >= num4)
					{
						num = -2120917081;
						num5 = -2120917081;
					}
					else
					{
						num = -1076603503;
						num5 = -1076603503;
					}
					continue;
				}
				case 0u:
					result = jSONClass;
					num = (int)((num2 * 468282354) ^ 0x3EB7C432);
					continue;
				case 3u:
					break;
				case 22u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_00cf:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -152619183;
					continue;
					IL_00c5:
					num = -639343200;
					continue;
					IL_00bb:
					num = -702653167;
					continue;
					IL_00a4:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -1667285717;
					continue;
					IL_009a:
					num = -577497839;
					continue;
					IL_0088:
					num7 = JSONNode.smethod_21(aReader);
					num = -2028605629;
					continue;
					IL_0075:
					num = ((int)num2 * -1013460902) ^ -1502526379;
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
					int num = 1550600355;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x61A366F8u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -1173759555) ^ -118549445;
							continue;
						case 0u:
							num = (int)((num2 * 553712023) ^ 0x673F3B85);
							continue;
						default:
							goto end_IL_0037;
						case 2u:
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
					int num = 1410501249;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x39A48D1Du) % 3u)
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
						JSONNode.smethod_15((IDisposable)fileStream);
						num = (int)(num2 * 1245251708) ^ -1729136383;
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
		byte[] byte_ = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 526124843;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC31EEB5u) % 7u)
				{
				case 6u:
					num = ((int)num2 * -813571038) ^ 0x5645D644;
					continue;
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -1662168000) ^ 0x7A170D53;
					continue;
				case 3u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1912302544) ^ 0x6E1A63F0;
					continue;
				case 1u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1624320300) ^ 0x13E3F859;
					continue;
				case 0u:
					num = (int)(num2 * 1461956732) ^ -148296347;
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
