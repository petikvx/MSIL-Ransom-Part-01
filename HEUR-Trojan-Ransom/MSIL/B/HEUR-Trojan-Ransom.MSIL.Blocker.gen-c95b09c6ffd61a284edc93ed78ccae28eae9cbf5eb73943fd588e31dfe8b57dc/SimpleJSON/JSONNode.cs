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
				int num = -189790266;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA4FD5F26u) % 3u)
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
					num = (int)((num2 * 358547444) ^ 0x56D7092B);
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
				int num = -1799374094;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x89181567u) % 3u)
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
					num = ((int)num2 * -912174882) ^ 0x77F7FFE3;
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
				int num = 273561007;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x37063D61u) % 4u)
					{
					case 2u:
						result = 0;
						num = (int)(num2 * 1954603601) ^ -846427042;
						continue;
					case 1u:
						num = (int)(num2 * 1235083082) ^ -1326737533;
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

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			while (true)
			{
				int num = -1152133418;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1FC0E92u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -1017861181) ^ -549911945;
				}
			}
		}
	}

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -17444106;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9741F81u) % 3u)
					{
					case 2u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_DeepChilds_003Ed__;
					num = ((int)num2 * -284148302) ^ -1190019292;
				}
			}
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
				int num = -1814051039;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCFB82B3Eu) % 8u)
					{
					case 7u:
						result2 = 0;
						num = (int)((num2 * 158941841) ^ 0x7D8A361D);
						continue;
					case 6u:
						result = 0;
						num = -980213914;
						continue;
					case 5u:
						result = result2;
						num = (int)((num2 * 42204520) ^ 0x154C2D47);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (int.TryParse(Value, out result2))
						{
							num3 = -942700101;
							num4 = -942700101;
						}
						else
						{
							num3 = -1240713272;
							num4 = -1240713272;
						}
						num = num3 ^ (int)(num2 * 1616548130);
						continue;
					}
					case 1u:
						num = ((int)num2 * -567451173) ^ 0x16EF837;
						continue;
					case 0u:
						num = ((int)num2 * -3809634) ^ 0x8E3460C;
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
			bool flag = default(bool);
			float result = default(float);
			float result2 = default(float);
			while (true)
			{
				int num = -754636136;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87617909u) % 8u)
					{
					case 6u:
						num = (int)(num2 * 821094239) ^ -1493795308;
						continue;
					case 5u:
						num = (int)(num2 * 913137234) ^ -434657548;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -845757322;
							num4 = -845757322;
						}
						else
						{
							num3 = -699416625;
							num4 = -699416625;
						}
						num = num3 ^ (int)(num2 * 282114479);
						continue;
					}
					case 3u:
						result = 0f;
						num = -1696385764;
						continue;
					case 2u:
						result = result2;
						num = (int)((num2 * 1962234017) ^ 0x407FEEDD);
						continue;
					case 1u:
						result2 = 0f;
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -1468457473) ^ -1709655702;
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
				int num = 361016165;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11EA78D2u) % 3u)
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
					num = ((int)num2 * -1584319203) ^ 0x7DBBFA2B;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = default(double);
			double result2 = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = -2139624269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA812C729u) % 7u)
					{
					case 6u:
						result = result2;
						num = ((int)num2 * -1537413149) ^ -1904714928;
						continue;
					case 5u:
						flag = double.TryParse(Value, out result2);
						num = (int)((num2 * 1485047540) ^ 0x310F29ED);
						continue;
					case 2u:
						result = 0.0;
						num = -37869831;
						continue;
					case 1u:
						result2 = 0.0;
						num = ((int)num2 * -88903107) ^ 0x512FFD37;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1785235214;
							num4 = 1785235214;
						}
						else
						{
							num3 = 1917542825;
							num4 = 1917542825;
						}
						num = num3 ^ (int)(num2 * 1113632045);
						continue;
					}
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

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			if (bool.TryParse(Value, out result))
			{
				goto IL_0011;
			}
			goto IL_006e;
			IL_006e:
			bool result2 = !JSONNode.smethod_1(Value);
			int num = -988768124;
			goto IL_0045;
			IL_0045:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4220634u) % 6u)
				{
				case 5u:
					break;
				case 4u:
					num = (int)((num2 * 1446904690) ^ 0x182F7DA5);
					continue;
				case 2u:
					num = ((int)num2 * -1804215372) ^ -482800419;
					continue;
				case 1u:
					result2 = result;
					num = ((int)num2 * -1384945962) ^ 0x15E1135E;
					continue;
				case 0u:
					goto IL_006e;
				default:
					return result2;
				}
				break;
			}
			goto IL_0011;
			IL_0011:
			num = -90872075;
			goto IL_0045;
		}
		set
		{
			Value = (value ? "true" : "false");
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1185180413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x208E5494u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1847237808) ^ 0x8F67098;
						continue;
					case 1u:
						result = this as JSONArray;
						num = (int)(num2 * 1671715507) ^ -782465736;
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
				int num = 1845732886;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63AC405Bu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 373273168) ^ 0x5AF95499);
						continue;
					case 1u:
						result = this as JSONClass;
						num = (int)(num2 * 1658670005) ^ -312611391;
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
			int num = -1691309039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE73C336u) % 3u)
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
				num = (int)((num2 * 159301103) ^ 0x5DDA361D);
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 696663287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94EA245u) % 4u)
				{
				case 2u:
					result = null;
					num = (int)((num2 * 749125628) ^ 0x400D2AA8);
					continue;
				case 1u:
					num = (int)((num2 * 1101340456) ^ 0x76E5CC59);
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
		JSONNode result = null;
		while (true)
		{
			int num = -413092302;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E4E16DEu) % 3u)
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
				num = ((int)num2 * -388998694) ^ -676519695;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 879991868;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FC319CFu) % 4u)
				{
				case 3u:
					result = aNode;
					num = (int)((num2 * 6303665) ^ 0x2B317FF1);
					continue;
				case 1u:
					num = ((int)num2 * -472555243) ^ -1702286184;
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
			int num = 114998591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67F2ED3Bu) % 3u)
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
				num = (int)((num2 * 582653358) ^ 0x4CF9528B);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -283191276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85DB26F0u) % 3u)
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
				num = ((int)num2 * -6641831) ^ 0x74904D2C;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 371246304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x70436871u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 224597039) ^ -246152208;
					continue;
				case 1u:
					result = new JSONData(s);
					num = (int)(num2 * 1927182985) ^ -344973702;
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
			int num = 287541924;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x747109B0u) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = ((int)num2 * -1149911940) ^ 0xA6A08A4;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					num = ((int)num2 * -194080496) ^ -965923673;
					continue;
				case 0u:
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
					num = 1987912805;
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
			goto IL_003f;
		}
		goto IL_0078;
		IL_003f:
		int num = -2075940355;
		goto IL_0044;
		IL_0044:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB995F134u) % 6u)
			{
			case 4u:
				num = (int)((num2 * 447957591) ^ 0x4ED07809);
				continue;
			case 2u:
				result = true;
				num = ((int)num2 * -1511571129) ^ -725375420;
				continue;
			case 1u:
				result = (object)a == b;
				num = -1076728855;
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_006d;
			default:
				return result;
			}
			break;
			IL_006d:
			if (a is JSONLazyCreator)
			{
				num = -792581116;
				num3 = -792581116;
				continue;
			}
			goto IL_0078;
		}
		goto IL_003f;
		IL_0078:
		num = -196562283;
		num3 = -196562283;
		goto IL_0044;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -845967376;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAC86F75u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -180145032) ^ -332002566;
					continue;
				case 1u:
					result = !(a == b);
					num = ((int)num2 * -1139606351) ^ -54381322;
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
			int num = 601623771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x394523D1u) % 4u)
				{
				case 2u:
					result = (object)this == obj;
					num = (int)(num2 * 1946196174) ^ -444287284;
					continue;
				case 1u:
					num = ((int)num2 * -661190031) ^ 0x55544E1C;
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

	public override int GetHashCode()
	{
		return this.method_0();
	}

	internal static string Escape(string aText)
	{
		string text = "";
		int num4 = default(int);
		string string_ = default(string);
		string result = default(string);
		char c = default(char);
		char c2 = default(char);
		while (true)
		{
			int num = 908436468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x369969DAu) % 29u)
				{
				case 28u:
				{
					int num6;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = 1373211828;
						num6 = 1373211828;
					}
					else
					{
						num = 2092714951;
						num6 = 2092714951;
					}
					continue;
				}
				case 27u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1168583493;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1441099008;
					continue;
				case 25u:
					num = (int)(num2 * 290940082) ^ -1690036677;
					continue;
				case 24u:
					string_ = aText;
					num4 = 0;
					num = (int)((num2 * 1695333708) ^ 0x3F5AD8A);
					continue;
				case 23u:
					num = (int)((num2 * 141809071) ^ 0xE9B389F);
					continue;
				case 22u:
					goto IL_0099;
				case 21u:
					goto IL_00af;
				case 20u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1229648415;
					continue;
				case 18u:
					num = (int)((num2 * 22954261) ^ 0x7E35B14A);
					continue;
				case 16u:
					num = (int)((num2 * 419879903) ^ 0x7E294F2E);
					continue;
				case 15u:
					result = text;
					num = ((int)num2 * -872521959) ^ 0x1F4396D5;
					continue;
				case 14u:
					goto IL_0117;
				case 13u:
					goto IL_012d;
				case 12u:
				{
					int num5;
					if (c != '"')
					{
						num = 1846809463;
						num5 = 1846809463;
					}
					else
					{
						num = 1171353301;
						num5 = 1171353301;
					}
					continue;
				}
				case 11u:
				{
					char c3 = c2;
					c = c3;
					switch (c)
					{
					case '\b':
						break;
					case '\t':
						goto IL_0099;
					case '\r':
						goto IL_00af;
					case '\f':
						goto IL_0117;
					case '\v':
						goto IL_012d;
					default:
						goto IL_018f;
					case '\n':
						goto IL_01a2;
					}
					goto case 26u;
				}
				case 6u:
					goto IL_01a2;
				case 10u:
					num = (int)(num2 * 205752732) ^ -262383279;
					continue;
				case 9u:
					num = ((int)num2 * -1545737898) ^ 0x7E92F4DF;
					continue;
				case 8u:
					num4++;
					num = 1577089860;
					continue;
				case 7u:
					num = (int)(num2 * 1862776171) ^ -983142420;
					continue;
				case 5u:
					num = (int)((num2 * 79858654) ^ 0x6165C3F0);
					continue;
				case 4u:
					num = ((int)num2 * -1031813470) ^ 0x18E6BCE7;
					continue;
				case 3u:
					num = ((int)num2 * -534117669) ^ 0x4ED0E281;
					continue;
				case 2u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 200743916;
					continue;
				case 1u:
				{
					int num3;
					if (c != '\\')
					{
						num = 1118223155;
						num3 = 1118223155;
					}
					else
					{
						num = 1886133340;
						num3 = 1886133340;
					}
					continue;
				}
				case 0u:
					num = ((int)num2 * -1836588472) ^ 0x6702A9E5;
					continue;
				case 19u:
					break;
				default:
					{
						return result;
					}
					IL_01a2:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1025341621;
					continue;
					IL_018f:
					num = ((int)num2 * -1651190557) ^ -1736733115;
					continue;
					IL_012d:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1025341621;
					continue;
					IL_0117:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1025341621;
					continue;
					IL_00af:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1058632217;
					continue;
					IL_0099:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1301027781;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		char c4 = default(char);
		int num9 = default(int);
		string text2 = default(string);
		char c = default(char);
		JSONNode jSONNode = default(JSONNode);
		bool flag12 = default(bool);
		bool flag14 = default(bool);
		bool flag2 = default(bool);
		char c2 = default(char);
		bool flag13 = default(bool);
		string text = default(string);
		bool flag11 = default(bool);
		char c3 = default(char);
		bool flag15 = default(bool);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		JSONNode result = default(JSONNode);
		string s = default(string);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 554411163;
			while (true)
			{
				uint num2;
				int num45;
				switch ((num2 = (uint)num ^ 0x14B047D8u) % 156u)
				{
				case 155u:
					c4 = JSONNode.smethod_2(aJSON, num9);
					num = (int)(num2 * 1529025908) ^ -1837741028;
					continue;
				case 154u:
					num = ((int)num2 * -1721471151) ^ -46221170;
					continue;
				case 153u:
					num = ((int)num2 * -1038691657) ^ -82274853;
					continue;
				case 152u:
					num = 573328022;
					continue;
				case 151u:
					num = ((int)num2 * -475298494) ^ -1684094424;
					continue;
				case 150u:
					num = 1138783852;
					continue;
				case 149u:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 1202970541;
					continue;
				case 148u:
				{
					int num8;
					if ((uint)c > 93u)
					{
						num = 440325984;
						num8 = 440325984;
					}
					else
					{
						num = 661325230;
						num8 = 661325230;
					}
					continue;
				}
				case 147u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -2022498467) ^ -1643859962;
					continue;
				case 146u:
				{
					int num57;
					int num58;
					if (flag12)
					{
						num57 = 865731801;
						num58 = 865731801;
					}
					else
					{
						num57 = 373459602;
						num58 = 373459602;
					}
					num = num57 ^ ((int)num2 * -466725902);
					continue;
				}
				case 145u:
					flag14 = flag2;
					num = 1145597984;
					continue;
				case 144u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = 133143647;
					continue;
				case 143u:
				{
					int num42;
					if (c2 != 'n')
					{
						num = 2062683468;
						num42 = 2062683468;
					}
					else
					{
						num = 1864514681;
						num42 = 1864514681;
					}
					continue;
				}
				case 142u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -918204230) ^ 0xB48DAE1;
					continue;
				case 141u:
					flag13 = flag2;
					num = 716861444;
					continue;
				case 140u:
					num = (int)((num2 * 842502009) ^ 0x22F602C1);
					continue;
				case 139u:
					num = ((int)num2 * -1236940751) ^ 0x3AF09C60;
					continue;
				case 138u:
					num = (int)((num2 * 1282575310) ^ 0x6C0DC581);
					continue;
				case 137u:
					flag2 = false;
					num = ((int)num2 * -441750185) ^ -601515962;
					continue;
				case 136u:
					num = (int)((num2 * 433924183) ^ 0x193A736D);
					continue;
				case 135u:
					num = (int)((num2 * 1118762997) ^ 0x216C816E);
					continue;
				case 134u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 1807257303) ^ 0x64CE05F3);
					continue;
				case 133u:
				{
					int num15;
					if (num9 < JSONNode.smethod_4(aJSON))
					{
						num = 296986044;
						num15 = 296986044;
					}
					else
					{
						num = 633892791;
						num15 = 633892791;
					}
					continue;
				}
				case 132u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1727686888) ^ 0x3D85CD60);
					continue;
				case 131u:
					num = (int)(num2 * 1323029062) ^ -15498113;
					continue;
				case 130u:
				{
					text = JSONNode.smethod_5(text);
					int num61;
					int num62;
					if (jSONNode is JSONArray)
					{
						num61 = 1841989773;
						num62 = 1841989773;
					}
					else
					{
						num61 = 404425980;
						num62 = 404425980;
					}
					num = num61 ^ ((int)num2 * -762369878);
					continue;
				}
				case 129u:
					num = (int)((num2 * 1920159833) ^ 0x671A659B);
					continue;
				case 128u:
				{
					int num53;
					int num54;
					if (flag11)
					{
						num53 = 207053456;
						num54 = 207053456;
					}
					else
					{
						num53 = 1402217398;
						num54 = 1402217398;
					}
					num = num53 ^ (int)(num2 * 387275670);
					continue;
				}
				case 127u:
					num = (int)((num2 * 1063577151) ^ 0x3F35DFD7);
					continue;
				case 126u:
					c = c3;
					num = (int)((num2 * 1673582912) ^ 0x149EB947);
					continue;
				case 125u:
					flag15 = flag2;
					num = 221714439;
					continue;
				case 124u:
				{
					int num48;
					int num49;
					if (!flag14)
					{
						num48 = 2128335566;
						num49 = 2128335566;
					}
					else
					{
						num48 = 209040862;
						num49 = 209040862;
					}
					num = num48 ^ ((int)num2 * -176566687);
					continue;
				}
				case 123u:
					num = (int)(num2 * 328398762) ^ -1045878834;
					continue;
				case 122u:
					num = ((int)num2 * -1723036923) ^ 0x5659F57F;
					continue;
				case 121u:
					num = 1779783635;
					continue;
				case 119u:
				{
					int num40;
					int num41;
					if (!flag10)
					{
						num40 = -1722064985;
						num41 = -1722064985;
					}
					else
					{
						num40 = -609154933;
						num41 = -609154933;
					}
					num = num40 ^ ((int)num2 * -2137386541);
					continue;
				}
				case 118u:
					num = ((int)num2 * -328655895) ^ 0x35F00E8F;
					continue;
				case 117u:
					num = ((int)num2 * -1661373054) ^ 0x1F5A442F;
					continue;
				case 31u:
				case 52u:
				case 87u:
				case 101u:
				case 116u:
					goto IL_03b9;
				case 115u:
					num = ((int)num2 * -1326526587) ^ 0xDBE0575;
					continue;
				case 114u:
					text = "";
					num = (int)(num2 * 741840356) ^ -542069827;
					continue;
				case 113u:
				{
					int num33;
					if (flag2)
					{
						num = 931192622;
						num33 = 931192622;
					}
					else
					{
						num = 584618833;
						num33 = 584618833;
					}
					continue;
				}
				case 112u:
					text = JSONNode.smethod_5(text);
					flag12 = jSONNode is JSONArray;
					num = ((int)num2 * -1560925134) ^ -658280950;
					continue;
				case 111u:
					jSONNode = null;
					num9 = 0;
					text2 = "";
					num = (int)((num2 * 830679335) ^ 0x6637B72F);
					continue;
				case 110u:
					goto IL_0458;
				case 109u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1613390204) ^ 0x45D4CC37);
					continue;
				case 108u:
					num = ((int)num2 * -2087193308) ^ -1267327889;
					continue;
				case 107u:
				{
					int num25;
					int num26;
					if (flag9)
					{
						num25 = 1028339736;
						num26 = 1028339736;
					}
					else
					{
						num25 = 1459482720;
						num26 = 1459482720;
					}
					num = num25 ^ (int)(num2 * 922248393);
					continue;
				}
				case 106u:
					text = "";
					num = 966210445;
					continue;
				case 105u:
				{
					int num21;
					int num22;
					if (flag8)
					{
						num21 = 829807175;
						num22 = 829807175;
					}
					else
					{
						num21 = 1409437588;
						num22 = 1409437588;
					}
					num = num21 ^ (int)(num2 * 1210300106);
					continue;
				}
				case 104u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 581387873;
					continue;
				case 103u:
				{
					int num17;
					if (c == '"')
					{
						num = 1507718054;
						num17 = 1507718054;
					}
					else
					{
						num = 1471665221;
						num17 = 1471665221;
					}
					continue;
				}
				case 102u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = (int)((num2 * 1923738236) ^ 0x7A4540F9);
					continue;
				case 100u:
				{
					int num13;
					if (c == '{')
					{
						num = 1473395213;
						num13 = 1473395213;
					}
					else
					{
						num = 998631984;
						num13 = 998631984;
					}
					continue;
				}
				case 99u:
					stack.Pop();
					num = 1518184878;
					continue;
				case 97u:
					goto IL_059a;
				case 96u:
					result = jSONNode;
					num = 1463732886;
					continue;
				case 95u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1489975512) ^ -1822046597;
					continue;
				case 94u:
				{
					int num4;
					int num5;
					if (c == ':')
					{
						num4 = 963287631;
						num5 = 963287631;
					}
					else
					{
						num4 = 1488650657;
						num5 = 1488650657;
					}
					num = num4 ^ (int)(num2 * 1883957089);
					continue;
				}
				case 93u:
					flag9 = stack.Count == 0;
					num = 950399279;
					continue;
				case 92u:
				{
					int num59;
					int num60;
					if (flag13)
					{
						num59 = -1525732812;
						num60 = -1525732812;
					}
					else
					{
						num59 = -1321605804;
						num60 = -1321605804;
					}
					num = num59 ^ (int)(num2 * 983823615);
					continue;
				}
				case 91u:
				{
					int num55;
					int num56;
					if (flag15)
					{
						num55 = -494064535;
						num56 = -494064535;
					}
					else
					{
						num55 = -1068364692;
						num56 = -1068364692;
					}
					num = num55 ^ (int)(num2 * 1750064822);
					continue;
				}
				case 89u:
					text = "";
					num = 892792382;
					continue;
				case 88u:
				{
					int num52;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 592592142;
						num52 = 592592142;
					}
					else
					{
						num = 811489644;
						num52 = 811489644;
					}
					continue;
				}
				case 86u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -923973838) ^ 0x12C45438;
					continue;
				case 85u:
					s = JSONNode.smethod_8(aJSON, num9 + 1, 4);
					num = ((int)num2 * -1317084685) ^ 0x7B982C77;
					continue;
				case 84u:
				{
					int num50;
					int num51;
					if (jSONNode is JSONArray)
					{
						num50 = -387088839;
						num51 = -387088839;
					}
					else
					{
						num50 = -1724347463;
						num51 = -1724347463;
					}
					num = num50 ^ (int)(num2 * 535589298);
					continue;
				}
				case 83u:
					num = (int)((num2 * 480131697) ^ 0x396318A0);
					continue;
				case 82u:
					num = (int)((num2 * 1892304864) ^ 0x23744D68);
					continue;
				case 81u:
					num = (int)(num2 * 871317090) ^ -275805153;
					continue;
				case 80u:
					num = (int)((num2 * 237035796) ^ 0x69087953);
					continue;
				case 79u:
				{
					int num46;
					int num47;
					if ((uint)c > 44u)
					{
						num46 = 470969046;
						num47 = 470969046;
					}
					else
					{
						num46 = 1912574219;
						num47 = 1912574219;
					}
					num = num46 ^ ((int)num2 * -908561878);
					continue;
				}
				case 78u:
					goto IL_0798;
				case 77u:
					text2 = "";
					num = (int)(num2 * 1356159972) ^ -1831997034;
					continue;
				case 76u:
				{
					int num43;
					int num44;
					if (!(jSONNode != null))
					{
						num43 = -1787690740;
						num44 = -1787690740;
					}
					else
					{
						num43 = -2005305659;
						num44 = -2005305659;
					}
					num = num43 ^ ((int)num2 * -1174585849);
					continue;
				}
				case 75u:
					num = ((int)num2 * -1527511983) ^ -1187351691;
					continue;
				case 74u:
					num = (int)(num2 * 1892459510) ^ -645805286;
					continue;
				case 73u:
					goto IL_0825;
				case 72u:
				{
					char c5 = c4;
					c2 = c5;
					num = (int)(num2 * 392508408) ^ -1251269321;
					continue;
				}
				case 71u:
					num = ((int)num2 * -2117984530) ^ -1895562045;
					continue;
				case 70u:
					num = ((int)num2 * -2099988933) ^ 0x3F7DF009;
					continue;
				case 69u:
					text2 = "";
					flag = stack.Count > 0;
					num = (int)((num2 * 1687988294) ^ 0x6BDDA299);
					continue;
				case 68u:
				{
					int num38;
					int num39;
					if (flag6)
					{
						num38 = -797524762;
						num39 = -797524762;
					}
					else
					{
						num38 = -240445356;
						num39 = -240445356;
					}
					num = num38 ^ ((int)num2 * -1013087451);
					continue;
				}
				case 67u:
					num = 1558113841;
					continue;
				case 66u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 1932714474) ^ 0x26573460);
					continue;
				case 65u:
				{
					int num36;
					int num37;
					if (!flag4)
					{
						num36 = 21873640;
						num37 = 21873640;
					}
					else
					{
						num36 = 167527755;
						num37 = 167527755;
					}
					num = num36 ^ ((int)num2 * -365017471);
					continue;
				}
				case 64u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 738601800;
					continue;
				case 63u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = ((int)num2 * -1158561215) ^ 0x5D41F419;
					continue;
				case 62u:
					text = text2;
					num = 531684373;
					continue;
				case 61u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 1202970541;
					continue;
				case 60u:
				{
					int num34;
					int num35;
					if (flag7)
					{
						num34 = -854086425;
						num35 = -854086425;
					}
					else
					{
						num34 = -483377997;
						num35 = -483377997;
					}
					num = num34 ^ ((int)num2 * -1586433837);
					continue;
				}
				case 58u:
					text = "";
					text2 = "";
					num = 706926685;
					continue;
				case 57u:
				{
					int num31;
					int num32;
					if (flag5)
					{
						num31 = 1571398448;
						num32 = 1571398448;
					}
					else
					{
						num31 = 1384061744;
						num32 = 1384061744;
					}
					num = num31 ^ ((int)num2 * -628239701);
					continue;
				}
				case 56u:
					num = (int)(num2 * 1080279001) ^ -2045872824;
					continue;
				case 55u:
					num = ((int)num2 * -1951003489) ^ 0x6D24740;
					continue;
				case 54u:
					flag8 = JSONNode.smethod_6(text2, "");
					num = ((int)num2 * -1464355622) ^ -409362103;
					continue;
				case 53u:
					num = ((int)num2 * -995708270) ^ -1271528938;
					continue;
				case 51u:
				{
					int num29;
					int num30;
					if (!(jSONNode is JSONArray))
					{
						num29 = 855512327;
						num30 = 855512327;
					}
					else
					{
						num29 = 1664692825;
						num30 = 1664692825;
					}
					num = num29 ^ (int)(num2 * 2015840065);
					continue;
				}
				case 50u:
					flag11 = JSONNode.smethod_6(text, "");
					num = 1448554880;
					continue;
				case 49u:
				{
					int num27;
					int num28;
					if ((uint)c <= 32u)
					{
						num27 = -1154955190;
						num28 = -1154955190;
					}
					else
					{
						num27 = -1730469273;
						num28 = -1730469273;
					}
					num = num27 ^ ((int)num2 * -2007786140);
					continue;
				}
				case 48u:
					flag10 = JSONNode.smethod_6(text2, "");
					num = 314352015;
					continue;
				case 47u:
				{
					int num23;
					int num24;
					if (flag3)
					{
						num23 = 1322092486;
						num24 = 1322092486;
					}
					else
					{
						num23 = 2073448033;
						num24 = 2073448033;
					}
					num = num23 ^ ((int)num2 * -392792272);
					continue;
				}
				case 46u:
					switch (c)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_03b9;
					case '\t':
						goto IL_0798;
					default:
						goto IL_0b13;
					}
					goto case 144u;
				case 45u:
					stack.Push(new JSONClass());
					num = 2090876120;
					continue;
				case 44u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 1113391502) ^ 0x1415439E);
					continue;
				case 43u:
				{
					int num19;
					int num20;
					if (c2 != 'b')
					{
						num19 = -1757451904;
						num20 = -1757451904;
					}
					else
					{
						num19 = -1256973124;
						num20 = -1256973124;
					}
					num = num19 ^ ((int)num2 * -1829904096);
					continue;
				}
				case 42u:
					num = ((int)num2 * -818229308) ^ 0x308982D8;
					continue;
				case 41u:
					num = ((int)num2 * -621788761) ^ 0x1EC23B1B;
					continue;
				case 40u:
				{
					int num18;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 1413399212;
						num18 = 1413399212;
					}
					else
					{
						num = 316969430;
						num18 = 316969430;
					}
					continue;
				}
				case 39u:
					num = ((int)num2 * -783042739) ^ 0x37AD6B3F;
					continue;
				case 38u:
					jSONNode.Add(text2);
					num = ((int)num2 * -608110071) ^ -944944721;
					continue;
				case 37u:
					flag7 = JSONNode.smethod_6(text, "");
					num = 1377966584;
					continue;
				case 36u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1510841264) ^ -545491238;
					continue;
				case 35u:
					flag6 = flag2;
					num = ((int)num2 * -1060056065) ^ 0x786FB62D;
					continue;
				case 34u:
					num = ((int)num2 * -2072294467) ^ -1578196561;
					continue;
				case 33u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num9).ToString());
					num = (int)((num2 * 865467128) ^ 0x4FB91B08);
					continue;
				case 32u:
					num = (int)(num2 * 1537985098) ^ -1949976379;
					continue;
				case 30u:
					num = ((int)num2 * -1810131251) ^ -323683468;
					continue;
				case 29u:
				{
					int num16;
					if (c == '}')
					{
						num = 1204144787;
						num16 = 1204144787;
					}
					else
					{
						num = 561662499;
						num16 = 561662499;
					}
					continue;
				}
				case 28u:
					num = ((int)num2 * -885292122) ^ 0x12BBCACD;
					continue;
				case 27u:
					switch (c)
					{
					case '[':
						break;
					default:
						goto IL_0d0f;
					case '\\':
						goto IL_0d19;
					case ']':
						goto IL_0d2b;
					}
					goto case 145u;
				case 15u:
					goto IL_0d19;
				case 23u:
					goto IL_0d2b;
				case 26u:
					num = ((int)num2 * -1566595812) ^ -856796784;
					continue;
				case 25u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 843967156) ^ -1108068929;
					continue;
				case 24u:
					flag3 = jSONNode != null;
					num = ((int)num2 * -1283168422) ^ -546421889;
					continue;
				case 22u:
					num9 += 4;
					num = ((int)num2 * -1737417800) ^ -2120307843;
					continue;
				case 21u:
					num = ((int)num2 * -1483900148) ^ -771454373;
					continue;
				case 20u:
					switch (c2)
					{
					case 't':
						break;
					case 's':
						goto IL_0458;
					case 'u':
						goto IL_059a;
					case 'r':
						goto IL_0825;
					default:
						goto IL_0dcb;
					}
					goto case 149u;
				case 19u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 1924874793) ^ 0x32544CE4);
					continue;
				case 18u:
					flag2 = !flag2;
					num = 1326053659;
					continue;
				case 17u:
					num = (int)(num2 * 393276875) ^ -278618729;
					continue;
				case 16u:
					num = 326426238;
					continue;
				case 14u:
					stack.Push(new JSONArray());
					num = 604330990;
					continue;
				case 13u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1530177586) ^ -1649022358;
					continue;
				case 12u:
					text = "";
					text2 = "";
					num = 1357088760;
					continue;
				case 11u:
				{
					int num14;
					if (c == ',')
					{
						num = 1310137357;
						num14 = 1310137357;
					}
					else
					{
						num = 1347143155;
						num14 = 1347143155;
					}
					continue;
				}
				case 10u:
					num = ((int)num2 * -64542707) ^ -836402745;
					continue;
				case 9u:
				{
					int num12;
					if (c2 != 'f')
					{
						num = 178726763;
						num12 = 178726763;
					}
					else
					{
						num = 1447798220;
						num12 = 1447798220;
					}
					continue;
				}
				case 8u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1017893900) ^ 0x6356FD78);
					continue;
				case 7u:
				{
					int num10;
					int num11;
					if (!flag)
					{
						num10 = 1558042926;
						num11 = 1558042926;
					}
					else
					{
						num10 = 1482415666;
						num11 = 1482415666;
					}
					num = num10 ^ ((int)num2 * -1746227014);
					continue;
				}
				case 6u:
					c3 = JSONNode.smethod_2(aJSON, num9);
					num = (int)(num2 * 823998885) ^ -1448105728;
					continue;
				case 5u:
					num = (int)(num2 * 848434269) ^ -676082792;
					continue;
				case 4u:
					num = 1897463570;
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if ((uint)c2 > 102u)
					{
						num6 = -1732113338;
						num7 = -1732113338;
					}
					else
					{
						num6 = -49138642;
						num7 = -49138642;
					}
					num = num6 ^ ((int)num2 * -958132901);
					continue;
				}
				case 2u:
					text2 = "";
					num = (int)((num2 * 1555610010) ^ 0x6903AE93);
					continue;
				case 1u:
				{
					int num3;
					if (c != ' ')
					{
						num = 2105113014;
						num3 = 2105113014;
					}
					else
					{
						num = 1914783322;
						num3 = 1914783322;
					}
					continue;
				}
				case 0u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -242410711) ^ 0x5E03BBE7;
					continue;
				case 120u:
					break;
				case 59u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 90u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_059a:
					num = 1766851941;
					continue;
					IL_0dcb:
					num = 917823675;
					continue;
					IL_0d2b:
					flag4 = flag2;
					num = 1687555029;
					continue;
					IL_0d19:
					num9++;
					flag5 = flag2;
					num = 108980593;
					continue;
					IL_0d0f:
					num = 2033845598;
					continue;
					IL_0b13:
					num = (int)(num2 * 1835312549) ^ -1766186148;
					continue;
					IL_0458:
					text2 = JSONNode.smethod_3(text2, c4.ToString());
					num = 1546902769;
					continue;
					IL_03b9:
					num9++;
					num = 551065997;
					continue;
					IL_0825:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 242023586;
					continue;
					IL_0798:
					if (flag2)
					{
						num = 908195437;
						num45 = 908195437;
					}
					else
					{
						num = 230617680;
						num45 = 230617680;
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
		BinaryWriter aWriter = default(BinaryWriter);
		while (true)
		{
			int num = 893160766;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1BAED54Eu) % 5u)
				{
				case 4u:
					Serialize(aWriter);
					num = ((int)num2 * -589662269) ^ -857552887;
					continue;
				case 3u:
					num = (int)(num2 * 1876679959) ^ -1271837800;
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -820726177) ^ -393047272;
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
		JSONNode.smethod_13(JSONNode.smethod_12((FileSystemInfo)JSONNode.smethod_11(JSONNode.smethod_10(aFileName))));
		FileStream fileStream = JSONNode.smethod_14(aFileName);
		try
		{
			SaveToStream(fileStream);
			while (true)
			{
				int num = -1490016370;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF5478668u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1104931532) ^ -1186550363;
						continue;
					case 1u:
						num = ((int)num2 * -88811756) ^ -1720797580;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00b4:
					int num3 = -596912243;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xF5478668u) % 4u)
						{
						case 2u:
							num3 = (int)(num2 * 1111088573) ^ -1983479451;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -744322855) ^ -2141109317;
							continue;
						default:
							goto end_IL_0093;
						case 0u:
							break;
						case 3u:
							goto end_IL_0093;
						}
						goto IL_00b4;
						continue;
						end_IL_0093:
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
				int num = 644899852;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4837EAD1u) % 5u)
					{
					case 4u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -983568958) ^ -171470749;
						continue;
					case 3u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -1808396362) ^ -1923542106;
						continue;
					case 0u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1087471030) ^ -1982264110;
						continue;
					case 2u:
						break;
					default:
						return result;
					case 1u:
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
					IL_00cc:
					int num3 = 265136972;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x4837EAD1u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -1514747496) ^ 0x15F9B19D;
							continue;
						case 0u:
							num3 = ((int)num2 * -37267097) ^ 0x7C24B54F;
							continue;
						default:
							goto end_IL_00ab;
						case 3u:
							break;
						case 2u:
							goto end_IL_00ab;
						}
						goto IL_00cc;
						continue;
						end_IL_00ab:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		JSONNode result = default(JSONNode);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		int num3 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num9 = default(int);
		bool flag = default(bool);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num4 = default(int);
		while (true)
		{
			int num = 509421520;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51DEA9ACu) % 39u)
				{
				case 38u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -1979901029) ^ -1702085117;
					continue;
				case 37u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = (int)(num2 * 483860402) ^ -821338292;
					continue;
				case 36u:
					num = ((int)num2 * -1574702239) ^ 0x7C54BE77;
					continue;
				case 35u:
					num6 = JSONNode.smethod_21(aReader);
					num = 1469623100;
					continue;
				case 34u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 548837165) ^ 0x480C21C6);
					continue;
				case 33u:
					num = ((int)num2 * -82824950) ^ -187188257;
					continue;
				case 32u:
					jSONArray = new JSONArray();
					num3 = 0;
					num = ((int)num2 * -680364278) ^ -988415498;
					continue;
				case 31u:
					num3++;
					num = ((int)num2 * -2058101165) ^ 0x76CC6725;
					continue;
				case 30u:
					num = ((int)num2 * -717714315) ^ 0xE9583AC;
					continue;
				case 29u:
					num = (int)((num2 * 2096672217) ^ 0x1B1F4AB);
					continue;
				case 28u:
					num = 804353717;
					continue;
				case 27u:
					jSONClass = new JSONClass();
					num9 = 0;
					num = ((int)num2 * -1873014989) ^ 0x396C48E5;
					continue;
				case 26u:
					flag = num9 < num6;
					num = 417798386;
					continue;
				case 25u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 2126780707) ^ 0x1ED0CD51);
					continue;
				case 24u:
					num = ((int)num2 * -1544804067) ^ -2115064664;
					continue;
				case 23u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1654404997) ^ 0x47160522;
					continue;
				case 22u:
					num9++;
					num = (int)((num2 * 1815689536) ^ 0x54FB09FA);
					continue;
				case 21u:
					goto IL_0197;
				case 20u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1124210565;
						num8 = 1124210565;
					}
					else
					{
						num7 = 599591668;
						num8 = 599591668;
					}
					num = num7 ^ ((int)num2 * -801135808);
					continue;
				}
				case 19u:
					goto IL_01ca;
				case 18u:
					goto IL_01d4;
				case 16u:
					goto IL_01eb;
				case 15u:
					num = ((int)num2 * -2142627451) ^ 0x4722E47F;
					continue;
				case 14u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -1582100224) ^ -70403293;
					continue;
				case 13u:
					num = (int)((num2 * 1719969374) ^ 0x5186DBAB);
					continue;
				case 11u:
					goto IL_0237;
				case 10u:
					jSONArray.Add(Deserialize(aReader));
					num = 1008051524;
					continue;
				case 8u:
					goto IL_0258;
				case 7u:
					num = ((int)num2 * -858339238) ^ -1729296307;
					continue;
				case 6u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.Value:
						goto IL_0197;
					case JSONBinaryTag.FloatValue:
						goto IL_01ca;
					case JSONBinaryTag.BoolValue:
						goto IL_01d4;
					case JSONBinaryTag.Array:
						goto IL_01eb;
					case JSONBinaryTag.IntValue:
						goto IL_0237;
					case JSONBinaryTag.DoubleValue:
						goto IL_0258;
					default:
						goto IL_02a6;
					}
					goto case 35u;
				case 5u:
					result = jSONArray;
					num = ((int)num2 * -1977276001) ^ 0x5F42DD3D;
					continue;
				case 4u:
					result = jSONClass;
					num = (int)((num2 * 1328172263) ^ 0x35B078F7);
					continue;
				case 3u:
				{
					int num5;
					if (num3 >= num4)
					{
						num = 756524676;
						num5 = 756524676;
					}
					else
					{
						num = 1342933088;
						num5 = 1342933088;
					}
					continue;
				}
				case 2u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)(num2 * 854415197) ^ -1818687451;
					continue;
				case 1u:
					num = (int)((num2 * 1853522047) ^ 0x6411308C);
					continue;
				case 0u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -2050449728) ^ -1246966616;
					continue;
				case 9u:
					break;
				case 17u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_02a6:
					num = (int)(num2 * 1376751576) ^ -805341041;
					continue;
					IL_0258:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 710348005;
					continue;
					IL_0237:
					num = 914659721;
					continue;
					IL_01eb:
					num4 = JSONNode.smethod_21(aReader);
					num = 1017777148;
					continue;
					IL_01d4:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = 746350267;
					continue;
					IL_01ca:
					num = 1893526224;
					continue;
					IL_0197:
					num = 2009123670;
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
					int num = 1838490427;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x811D56Au) % 4u)
						{
						case 2u:
							num = (int)(num2 * 202499518) ^ -1757769146;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = (int)(num2 * 418547479) ^ -1666768321;
							continue;
						default:
							goto end_IL_0037;
						case 3u:
							break;
						case 0u:
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
					int num = 748923348;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xAEEB675u) % 3u)
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
						num = ((int)num2 * -209019679) ^ -1759252206;
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
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -398596485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0BAF287u) % 6u)
				{
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 1210642672) ^ 0x6B5C30B2);
					continue;
				case 4u:
					num = ((int)num2 * -1470405494) ^ -1275607140;
					continue;
				case 2u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)((num2 * 1907419674) ^ 0x39F9E1A6);
					continue;
				case 1u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1324995511) ^ -2100594600;
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
			int num = -1168720493;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A3251E8u) % 3u)
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
				num = ((int)num2 * -1810679953) ^ -88277598;
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
