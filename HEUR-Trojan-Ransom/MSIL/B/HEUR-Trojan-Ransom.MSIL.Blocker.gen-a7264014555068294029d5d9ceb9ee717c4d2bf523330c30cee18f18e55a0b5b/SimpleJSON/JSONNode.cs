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
				int num = -363310792;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFDCAD778u) % 3u)
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
					num = ((int)num2 * -597695790) ^ 0x3ADC1FD5;
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
				int num = 742970085;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30BB717Bu) % 3u)
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
					num = ((int)num2 * -2125632004) ^ 0x59B342C4;
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
			string result = "";
			while (true)
			{
				int num = -1652427911;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC46A0285u) % 3u)
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
					num = ((int)num2 * -1306320835) ^ -1267833015;
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
				int num = 77959279;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x773E8E97u) % 3u)
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
					num = ((int)num2 * -1935765503) ^ 0x2D6CD114;
				}
			}
		}
	}

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			_003Cget_Childs_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = 1700619964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x91B8300u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_Childs_003Ed__;
					num = (int)((num2 * 1321869907) ^ 0x6CC34E04);
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
				int num = 1574757470;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x472E1DD0u) % 3u)
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
					num = (int)((num2 * 1767483103) ^ 0xD5004F3);
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
				int num = -512814690;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B3C94D5u) % 6u)
					{
					case 5u:
					{
						result2 = 0;
						int num3;
						int num4;
						if (!int.TryParse(Value, out result2))
						{
							num3 = 1471804117;
							num4 = 1471804117;
						}
						else
						{
							num3 = 124661987;
							num4 = 124661987;
						}
						num = num3 ^ ((int)num2 * -1450918246);
						continue;
					}
					case 4u:
						result = 0;
						num = -2098743036;
						continue;
					case 3u:
						num = ((int)num2 * -589217256) ^ 0x7B62262E;
						continue;
					case 2u:
						result = result2;
						num = (int)(num2 * 1784031827) ^ -449894322;
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
			bool flag = default(bool);
			float result2 = default(float);
			float result = default(float);
			while (true)
			{
				int num = -449484107;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDDD91CA8u) % 8u)
					{
					case 7u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)((num2 * 1849806803) ^ 0x1E6BE685);
						continue;
					case 5u:
						result2 = 0f;
						num = ((int)num2 * -1133880860) ^ -763561661;
						continue;
					case 4u:
						result = result2;
						num = ((int)num2 * -661972310) ^ -1189102058;
						continue;
					case 3u:
						num = ((int)num2 * -1759696878) ^ 0x113925C8;
						continue;
					case 1u:
						result = 0f;
						num = -297282781;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1618869580;
							num4 = -1618869580;
						}
						else
						{
							num3 = -700037367;
							num4 = -700037367;
						}
						num = num3 ^ ((int)num2 * -1121894623);
						continue;
					}
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

	public virtual double AsDouble
	{
		get
		{
			bool flag = default(bool);
			double result2 = default(double);
			double result = default(double);
			while (true)
			{
				int num = -1713338821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC1EC6943u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1731669875;
							num4 = 1731669875;
						}
						else
						{
							num3 = 1815674410;
							num4 = 1815674410;
						}
						num = num3 ^ ((int)num2 * -1233837304);
						continue;
					}
					case 5u:
						result2 = 0.0;
						flag = double.TryParse(Value, out result2);
						num = (int)((num2 * 596381462) ^ 0x1152D39);
						continue;
					case 3u:
						result = result2;
						num = (int)(num2 * 75237761) ^ -492994703;
						continue;
					case 2u:
						num = ((int)num2 * -1971176124) ^ 0x5AB3335B;
						continue;
					case 1u:
						result = 0.0;
						num = -304055113;
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
				int num = 1768185477;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74D88D03u) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = (int)(num2 * 1495153544) ^ -2058827802;
						continue;
					case 1u:
						num = ((int)num2 * -1758231477) ^ 0x325A5633;
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

	public virtual bool AsBool
	{
		get
		{
			bool result = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -1994308871;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87433AAEu) % 6u)
					{
					case 5u:
						result = !JSONNode.smethod_1(Value);
						num = -832642734;
						continue;
					case 4u:
						result = result2;
						num = (int)((num2 * 826407880) ^ 0xA097CB4);
						continue;
					case 1u:
					{
						result2 = false;
						int num3;
						int num4;
						if (bool.TryParse(Value, out result2))
						{
							num3 = -1400481049;
							num4 = -1400481049;
						}
						else
						{
							num3 = -862097892;
							num4 = -862097892;
						}
						num = num3 ^ ((int)num2 * -1039387957);
						continue;
					}
					case 0u:
						num = ((int)num2 * -171243659) ^ 0x386CA38;
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
				int num = -1586843193;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x946EA30Au) % 4u)
					{
					case 1u:
						result = this as JSONArray;
						num = ((int)num2 * -831891477) ^ 0x6DB81C41;
						continue;
					case 0u:
						num = (int)((num2 * 702548730) ^ 0x500D7555);
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
			JSONClass result = this as JSONClass;
			while (true)
			{
				int num = -1802793483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA5F728Du) % 3u)
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
					num = ((int)num2 * -1046610352) ^ -1530102398;
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
			int num = -1776680185;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94E02B86u) % 3u)
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
				Add("", aItem);
				num = (int)(num2 * 371676574) ^ -264293163;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1393946855;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x615CCCA6u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1141261032) ^ 0x731D05B0);
					continue;
				case 1u:
					result = null;
					num = (int)((num2 * 920543746) ^ 0x394BE8BB);
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
		JSONNode result = null;
		while (true)
		{
			int num = 1359780527;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1915389Fu) % 3u)
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
				num = ((int)num2 * -1757345531) ^ -1420320902;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -448922583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CA9A40Eu) % 3u)
				{
				case 2u:
					goto IL_0004;
				case 0u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0004:
				num = (int)(num2 * 1976617537) ^ -1094566147;
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 551417273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D942919u) % 3u)
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
				num = (int)((num2 * 429769241) ^ 0x419F9E90);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -991659965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84FBFED5u) % 3u)
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
				num = ((int)num2 * -1539921044) ^ 0x7C2A5889;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -929225925;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9B8EDBEu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 17984491) ^ 0x27928470);
					continue;
				case 1u:
					result = new JSONData(s);
					num = ((int)num2 * -573358050) ^ -156196774;
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
			int num = -1889878638;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xC8E7D12Fu) % 5u)
				{
				case 3u:
					num = (int)(num2 * 658138658) ^ -1264793641;
					continue;
				case 2u:
					if (!(d == null))
					{
						num = (int)(num2 * 573874117) ^ -796505758;
						continue;
					}
					obj = null;
					goto IL_002b;
				case 1u:
					obj = d.Value;
					goto IL_002b;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_002b:
					result = (string)obj;
					num = -1935922980;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = 1798291848;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6B35C8C9u) % 8u)
				{
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1396097835;
						num5 = -1396097835;
					}
					else
					{
						num4 = -1804553919;
						num5 = -1804553919;
					}
					num = num4 ^ ((int)num2 * -1252057898);
					continue;
				}
				case 6u:
					result = (object)a == b;
					num = 351368773;
					continue;
				case 4u:
					num = ((int)num2 * -1569052806) ^ 0x2DF27671;
					continue;
				case 3u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_004e;
				case 2u:
					result = true;
					num = ((int)num2 * -1495015260) ^ 0x301971C1;
					continue;
				case 1u:
					if (b == null)
					{
						num = (int)((num2 * 1144736918) ^ 0x1EA32F9C);
						continue;
					}
					num3 = 0;
					goto IL_004e;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_004e:
					flag = (byte)num3 != 0;
					num = 1237237630;
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
			int num = -736468485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1BAD43Au) % 3u)
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
				num = (int)((num2 * 1885677829) ^ 0x2F96FA96);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -413386700;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x875F870Du) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1406931534) ^ -842798689;
					continue;
				case 1u:
					result = (object)this == obj;
					num = (int)((num2 * 182760377) ^ 0x688C1A6B);
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

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = 573202366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19B0D668u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2108839962) ^ 0x27E50B27;
					continue;
				case 2u:
					result = this.method_0();
					num = (int)((num2 * 971680909) ^ 0x33ECE569);
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
		char c2 = default(char);
		char c = default(char);
		string result = default(string);
		char c3 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1151140548;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF286340Eu) % 32u)
				{
				case 31u:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1652439202;
					continue;
				case 30u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1231191935;
					continue;
				case 29u:
					num = ((int)num2 * -418326819) ^ -1856544265;
					continue;
				case 28u:
					goto IL_004a;
				case 27u:
					c2 = c;
					num = (int)((num2 * 10232452) ^ 0x418EC105);
					continue;
				case 26u:
					num = ((int)num2 * -935969462) ^ 0x4527CB9A;
					continue;
				case 25u:
				{
					int num6;
					if (c2 == '"')
					{
						num = -9038800;
						num6 = -9038800;
					}
					else
					{
						num = -1232747996;
						num6 = -1232747996;
					}
					continue;
				}
				case 24u:
					goto IL_00ac;
				case 23u:
				{
					int num5;
					if (c2 == '\\')
					{
						num = -2040395508;
						num5 = -2040395508;
					}
					else
					{
						num = -710830246;
						num5 = -710830246;
					}
					continue;
				}
				case 22u:
					num = (int)(num2 * 823834555) ^ -107875918;
					continue;
				case 21u:
					result = text;
					num = (int)(num2 * 1388845774) ^ -2020896834;
					continue;
				case 20u:
					num = (int)(num2 * 2003652079) ^ -1459501021;
					continue;
				case 19u:
					c = c3;
					num = (int)(num2 * 1317167067) ^ -1670368908;
					continue;
				case 18u:
					string_ = aText;
					num = ((int)num2 * -362578914) ^ 0x51E7013E;
					continue;
				case 17u:
					num = (int)(num2 * 1904917968) ^ -1787587186;
					continue;
				case 16u:
					num = -1972899645;
					continue;
				case 15u:
					num = (int)(num2 * 959955609) ^ -929202135;
					continue;
				case 13u:
					num3++;
					num = (int)(num2 * 652855968) ^ -1904215027;
					continue;
				case 12u:
					num3 = 0;
					num = ((int)num2 * -1567766530) ^ 0x37B45C05;
					continue;
				case 11u:
					num = ((int)num2 * -543875399) ^ -2011186546;
					continue;
				case 10u:
					num = ((int)num2 * -503877356) ^ -815379151;
					continue;
				case 9u:
					goto IL_01cd;
				case 8u:
					goto IL_01e3;
				case 7u:
					switch (c2)
					{
					case '\n':
						break;
					case '\t':
						goto IL_004a;
					case '\r':
						goto IL_00ac;
					case '\b':
						goto IL_01cd;
					case '\f':
						goto IL_01e3;
					default:
						goto IL_021a;
					case '\v':
						goto IL_022a;
					}
					goto case 31u;
				case 1u:
					goto IL_022a;
				case 6u:
					num = (int)(num2 * 1601889164) ^ -1131247338;
					continue;
				case 4u:
					c3 = JSONNode.smethod_2(string_, num3);
					num = -1667936155;
					continue;
				case 3u:
				{
					int num4;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -1612175318;
						num4 = -1612175318;
					}
					else
					{
						num = -532969125;
						num4 = -532969125;
					}
					continue;
				}
				case 2u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1034014669;
					continue;
				case 0u:
					num = ((int)num2 * -1065321739) ^ 0x399E7C77;
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_022a:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -1652439202;
					continue;
					IL_021a:
					num = (int)((num2 * 1855945007) ^ 0x29D6B427);
					continue;
					IL_01e3:
					text = JSONNode.smethod_3(text, "\\f");
					num = -2128575180;
					continue;
					IL_01cd:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1652439202;
					continue;
					IL_004a:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1909684833;
					continue;
					IL_00ac:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1595594552;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag9 = default(bool);
		bool flag5 = default(bool);
		string text2 = default(string);
		int num4 = default(int);
		bool flag7 = default(bool);
		char c3 = default(char);
		bool flag10 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		char c = default(char);
		char c4 = default(char);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		bool flag6 = default(bool);
		bool flag8 = default(bool);
		bool flag3 = default(bool);
		bool flag13 = default(bool);
		bool flag4 = default(bool);
		char c2 = default(char);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = -591639176;
			while (true)
			{
				uint num2;
				int num23;
				switch ((num2 = (uint)num ^ 0xE75FC4DEu) % 153u)
				{
				case 152u:
					num = ((int)num2 * -1343959432) ^ 0x1473B4BE;
					continue;
				case 151u:
					flag9 = flag5;
					num = -1537273255;
					continue;
				case 150u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = -9710631;
					continue;
				case 149u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)(num2 * 1592012837) ^ -1820340028;
					continue;
				case 148u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -1022926885;
					continue;
				case 147u:
					text2 = "";
					num = (int)(num2 * 1577478522) ^ -2131470160;
					continue;
				case 146u:
				{
					int num24;
					int num25;
					if (!flag7)
					{
						num24 = -1657136588;
						num25 = -1657136588;
					}
					else
					{
						num24 = -393857791;
						num25 = -393857791;
					}
					num = num24 ^ ((int)num2 * -1827440013);
					continue;
				}
				case 145u:
					text2 = "";
					num = ((int)num2 * -2077472831) ^ -1267176495;
					continue;
				case 144u:
				{
					int num56;
					if (c3 == 'n')
					{
						num = -875430311;
						num56 = -875430311;
					}
					else
					{
						num = -1261888697;
						num56 = -1261888697;
					}
					continue;
				}
				case 143u:
					num = -1192765335;
					continue;
				case 142u:
				{
					int num36;
					int num37;
					if (!flag10)
					{
						num36 = 1582788033;
						num37 = 1582788033;
					}
					else
					{
						num36 = 1312637642;
						num37 = 1312637642;
					}
					num = num36 ^ ((int)num2 * -1971891213);
					continue;
				}
				case 141u:
					flag5 = false;
					num = (int)(num2 * 1098343005) ^ -52390521;
					continue;
				case 140u:
					num = ((int)num2 * -1928742214) ^ 0x1AD0EC31;
					continue;
				case 139u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 1366737385) ^ 0x4F516497);
					continue;
				case 138u:
					num = ((int)num2 * -571697197) ^ -868758792;
					continue;
				case 137u:
					num = (int)(num2 * 691469221) ^ -2010089551;
					continue;
				case 136u:
				{
					int num19;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -1004356665;
						num19 = -1004356665;
					}
					else
					{
						num = -2139344762;
						num19 = -2139344762;
					}
					continue;
				}
				case 135u:
					num = (int)((num2 * 1708497858) ^ 0x3CD168F6);
					continue;
				case 134u:
					num = (int)(num2 * 941475003) ^ -1961874;
					continue;
				case 133u:
				{
					stack.Push(new JSONArray());
					int num10;
					if (jSONNode != null)
					{
						num = -86651027;
						num10 = -86651027;
					}
					else
					{
						num = -1192765335;
						num10 = -1192765335;
					}
					continue;
				}
				case 132u:
					num = (int)((num2 * 295438929) ^ 0x789061C6);
					continue;
				case 131u:
					switch (c3)
					{
					case 'r':
						goto IL_0264;
					case 's':
						goto IL_027a;
					case 't':
						goto IL_0292;
					case 'u':
						goto IL_02a8;
					}
					num = -1992797857;
					continue;
				case 50u:
					goto IL_0264;
				case 34u:
					goto IL_027a;
				case 91u:
					goto IL_0292;
				case 111u:
					goto IL_02a8;
				case 130u:
					jSONNode = null;
					num = ((int)num2 * -324925110) ^ -17984809;
					continue;
				case 129u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1906859608) ^ 0x2B0DFA25;
					continue;
				case 128u:
				{
					int num54;
					if (c == '}')
					{
						num = -802575473;
						num54 = -802575473;
					}
					else
					{
						num = -469203183;
						num54 = -469203183;
					}
					continue;
				}
				case 127u:
				{
					char c5 = c4;
					c3 = c5;
					num = (int)((num2 * 1400674244) ^ 0x70990FEC);
					continue;
				}
				case 126u:
				{
					int num49;
					int num50;
					if (JSONNode.smethod_6(text2, ""))
					{
						num49 = -1299436687;
						num50 = -1299436687;
					}
					else
					{
						num49 = -241958617;
						num50 = -241958617;
					}
					num = num49 ^ (int)(num2 * 1815709307);
					continue;
				}
				case 125u:
					num = ((int)num2 * -2133565929) ^ -806192192;
					continue;
				case 86u:
				case 92u:
				case 101u:
				case 122u:
				case 124u:
					goto IL_0368;
				case 123u:
					switch (c)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_0368;
					default:
						goto IL_0394;
					case '\t':
						goto IL_03a7;
					}
					goto case 150u;
				case 2u:
					goto IL_03a7;
				case 121u:
					num = ((int)num2 * -821836117) ^ 0x799995E9;
					continue;
				case 120u:
					num = ((int)num2 * -1440819877) ^ 0x686B730D;
					continue;
				case 119u:
					flag12 = flag5;
					num = ((int)num2 * -431812724) ^ 0x13757DC5;
					continue;
				case 118u:
					flag2 = stack.Count == 0;
					num = -1981634342;
					continue;
				case 117u:
					flag11 = jSONNode is JSONArray;
					num = (int)((num2 * 212493431) ^ 0x4F5CDF2F);
					continue;
				case 116u:
					num = (int)(num2 * 912143676) ^ -1031333861;
					continue;
				case 115u:
				{
					int num38;
					int num39;
					if (!flag6)
					{
						num38 = -1633201644;
						num39 = -1633201644;
					}
					else
					{
						num38 = -1478037273;
						num39 = -1478037273;
					}
					num = num38 ^ (int)(num2 * 1263711295);
					continue;
				}
				case 114u:
				{
					int num30;
					int num31;
					if (flag8)
					{
						num30 = 1770624129;
						num31 = 1770624129;
					}
					else
					{
						num30 = 1651745641;
						num31 = 1651745641;
					}
					num = num30 ^ ((int)num2 * -805260603);
					continue;
				}
				case 113u:
					num = (int)(num2 * 774279658) ^ -1851551440;
					continue;
				case 112u:
					num = ((int)num2 * -2035405475) ^ 0x6041454C;
					continue;
				case 110u:
					flag8 = flag5;
					num = -261260323;
					continue;
				case 109u:
					switch (c)
					{
					case ']':
						break;
					default:
						goto IL_04d4;
					case '[':
						goto IL_04de;
					case '\\':
						goto IL_04fe;
					}
					goto case 110u;
				case 47u:
					goto IL_04de;
				case 49u:
					goto IL_04fe;
				case 108u:
					flag6 = flag5;
					num = -326706990;
					continue;
				case 107u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1537962280) ^ 0x39AA74FF);
					continue;
				case 106u:
				{
					int num17;
					if (c != ',')
					{
						num = -654270923;
						num17 = -654270923;
					}
					else
					{
						num = -2008548096;
						num17 = -2008548096;
					}
					continue;
				}
				case 105u:
				{
					int num13;
					int num14;
					if (flag2)
					{
						num13 = -762082440;
						num14 = -762082440;
					}
					else
					{
						num13 = -925888479;
						num14 = -925888479;
					}
					num = num13 ^ ((int)num2 * -55386936);
					continue;
				}
				case 104u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)(num2 * 897499406) ^ -1719432357;
					continue;
				case 103u:
				{
					int num7;
					if (c != '"')
					{
						num = -1993612452;
						num7 = -1993612452;
					}
					else
					{
						num = -1164727004;
						num7 = -1164727004;
					}
					continue;
				}
				case 102u:
					num = (int)(num2 * 843991794) ^ -2003563455;
					continue;
				case 100u:
					num = (int)(num2 * 1904587257) ^ -244409365;
					continue;
				case 99u:
					num = (int)(num2 * 501698180) ^ -2112448576;
					continue;
				case 98u:
					num = (int)(num2 * 1718768713) ^ -1125331275;
					continue;
				case 97u:
				{
					stack.Push(new JSONClass());
					int num60;
					if (jSONNode != null)
					{
						num = -2048967007;
						num60 = -2048967007;
					}
					else
					{
						num = -835571759;
						num60 = -835571759;
					}
					continue;
				}
				case 96u:
				{
					int num58;
					int num59;
					if (stack.Count > 0)
					{
						num58 = -569250828;
						num59 = -569250828;
					}
					else
					{
						num58 = -541539829;
						num59 = -541539829;
					}
					num = num58 ^ ((int)num2 * -1287140724);
					continue;
				}
				case 94u:
					text = "";
					num = -1652593626;
					continue;
				case 93u:
				{
					int num57;
					if (c == ' ')
					{
						num = -804270981;
						num57 = -804270981;
					}
					else
					{
						num = -585487882;
						num57 = -585487882;
					}
					continue;
				}
				case 90u:
				{
					int num55;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -2040829314;
						num55 = -2040829314;
					}
					else
					{
						num = -1155969262;
						num55 = -1155969262;
					}
					continue;
				}
				case 89u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1262085027) ^ -285796231;
					continue;
				case 88u:
				{
					int num52;
					int num53;
					if (flag3)
					{
						num52 = -88432444;
						num53 = -88432444;
					}
					else
					{
						num52 = -378587756;
						num53 = -378587756;
					}
					num = num52 ^ (int)(num2 * 656679596);
					continue;
				}
				case 87u:
				{
					string s = JSONNode.smethod_8(aJSON, num4 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -15591874) ^ -1191464533;
					continue;
				}
				case 85u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -664683969) ^ -1419707498;
					continue;
				case 84u:
					text2 = "";
					text = "";
					num = (int)((num2 * 865015562) ^ 0x3C4C080);
					continue;
				case 82u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 71833445) ^ 0x10A8E9BC);
					continue;
				case 81u:
					num = ((int)num2 * -1241693695) ^ -115603174;
					continue;
				case 80u:
					num = -323516774;
					continue;
				case 79u:
					num = (int)((num2 * 401792165) ^ 0x10DE696B);
					continue;
				case 78u:
					num = -1005876669;
					continue;
				case 77u:
				{
					int num51;
					if (c3 == 'f')
					{
						num = -2109912061;
						num51 = -2109912061;
					}
					else
					{
						num = -1454197628;
						num51 = -1454197628;
					}
					continue;
				}
				case 76u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1644109971) ^ -1255121932;
					continue;
				case 75u:
					flag13 = JSONNode.smethod_6(text, "");
					num = -1265141371;
					continue;
				case 74u:
				{
					int num47;
					int num48;
					if ((uint)c3 > 102u)
					{
						num47 = -1641524646;
						num48 = -1641524646;
					}
					else
					{
						num47 = -1425948285;
						num48 = -1425948285;
					}
					num = num47 ^ (int)(num2 * 389199647);
					continue;
				}
				case 73u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -747645908;
					continue;
				case 72u:
					flag4 = flag5;
					num = -1405673308;
					continue;
				case 70u:
					c4 = JSONNode.smethod_2(aJSON, num4);
					num = (int)((num2 * 1551359744) ^ 0x18D6FA6D);
					continue;
				case 69u:
					num4 = 0;
					num = (int)(num2 * 536089383) ^ -241844739;
					continue;
				case 68u:
					num = (int)((num2 * 1283615864) ^ 0x70959455);
					continue;
				case 67u:
					text = text2;
					num = -565906314;
					continue;
				case 66u:
				{
					int num45;
					int num46;
					if (jSONNode is JSONArray)
					{
						num45 = -1401058985;
						num46 = -1401058985;
					}
					else
					{
						num45 = -1544409155;
						num46 = -1544409155;
					}
					num = num45 ^ ((int)num2 * -61688587);
					continue;
				}
				case 65u:
					num = ((int)num2 * -734745569) ^ 0x130731E7;
					continue;
				case 64u:
					num = (int)(num2 * 1727358169) ^ -900988156;
					continue;
				case 63u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -892329960) ^ 0x6FA072BC;
					continue;
				case 62u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1158577719) ^ -737047841;
					continue;
				case 61u:
				{
					int num43;
					int num44;
					if ((uint)c <= 32u)
					{
						num43 = -790580536;
						num44 = -790580536;
					}
					else
					{
						num43 = -92851430;
						num44 = -92851430;
					}
					num = num43 ^ (int)(num2 * 1185735404);
					continue;
				}
				case 60u:
					text2 = "";
					num = (int)((num2 * 1943924019) ^ 0x2BC95D07);
					continue;
				case 59u:
				{
					int num41;
					int num42;
					if (flag9)
					{
						num41 = -1874534292;
						num42 = -1874534292;
					}
					else
					{
						num41 = -310053629;
						num42 = -310053629;
					}
					num = num41 ^ (int)(num2 * 1946288129);
					continue;
				}
				case 58u:
				{
					int num40;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -1005876669;
						num40 = -1005876669;
					}
					else
					{
						num = -2008740115;
						num40 = -2008740115;
					}
					continue;
				}
				case 57u:
					num = -835571759;
					continue;
				case 56u:
					flag7 = flag5;
					num = ((int)num2 * -898714807) ^ -1544090662;
					continue;
				case 55u:
					num = ((int)num2 * -797402287) ^ 0x58A0E152;
					continue;
				case 54u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -98489776;
					continue;
				case 53u:
				{
					int num34;
					int num35;
					if (flag13)
					{
						num34 = 1983722282;
						num35 = 1983722282;
					}
					else
					{
						num34 = 1321524556;
						num35 = 1321524556;
					}
					num = num34 ^ ((int)num2 * -1036876818);
					continue;
				}
				case 52u:
					c2 = JSONNode.smethod_2(aJSON, num4);
					num = (int)((num2 * 1805489416) ^ 0x475CAE1E);
					continue;
				case 51u:
				{
					int num32;
					int num33;
					if (flag12)
					{
						num32 = -418065099;
						num33 = -418065099;
					}
					else
					{
						num32 = -1501406150;
						num33 = -1501406150;
					}
					num = num32 ^ (int)(num2 * 1493797472);
					continue;
				}
				case 48u:
					text = "";
					text2 = "";
					num = -183212187;
					continue;
				case 46u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 749756361) ^ 0x4BDF1D52);
					continue;
				case 45u:
					num = ((int)num2 * -1186582722) ^ -377338678;
					continue;
				case 44u:
					num = ((int)num2 * -168636863) ^ -634533796;
					continue;
				case 43u:
					num = -1232356783;
					continue;
				case 42u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1422242100) ^ -422179231;
					continue;
				case 41u:
					num = ((int)num2 * -267959148) ^ 0x7F03EE79;
					continue;
				case 40u:
					flag5 = !flag5;
					num = -183212187;
					continue;
				case 39u:
					num = ((int)num2 * -107088439) ^ -1469787522;
					continue;
				case 38u:
					num = ((int)num2 * -2086970878) ^ -991381657;
					continue;
				case 37u:
					result = jSONNode;
					num = -1299897303;
					continue;
				case 36u:
					text = "";
					num = -855907318;
					continue;
				case 35u:
					num = ((int)num2 * -1151037309) ^ -1016481385;
					continue;
				case 32u:
					num = (int)(num2 * 545168635) ^ -1492566151;
					continue;
				case 31u:
					text = "";
					text2 = "";
					num = -1278970496;
					continue;
				case 30u:
				{
					int num28;
					int num29;
					if (flag11)
					{
						num28 = 455572575;
						num29 = 455572575;
					}
					else
					{
						num28 = 449709688;
						num29 = 449709688;
					}
					num = num28 ^ (int)(num2 * 1727334961);
					continue;
				}
				case 29u:
					num = (int)((num2 * 1283407517) ^ 0x29F4683A);
					continue;
				case 28u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -570753765) ^ -1034330464;
					continue;
				case 27u:
					num = -512151598;
					continue;
				case 26u:
					flag10 = JSONNode.smethod_6(text, "");
					num = -1897270720;
					continue;
				case 25u:
					num = (int)((num2 * 889608999) ^ 0x59718E79);
					continue;
				case 24u:
					num4 += 4;
					num = (int)(num2 * 1330453020) ^ -444326486;
					continue;
				case 23u:
					num = (int)((num2 * 1500296521) ^ 0x631B317E);
					continue;
				case 22u:
				{
					int num26;
					int num27;
					if (c3 == 'b')
					{
						num26 = 725239573;
						num27 = 725239573;
					}
					else
					{
						num26 = 662951477;
						num27 = 662951477;
					}
					num = num26 ^ ((int)num2 * -2314177);
					continue;
				}
				case 21u:
				{
					int num22;
					if (num4 >= JSONNode.smethod_4(aJSON))
					{
						num = -1531844450;
						num22 = -1531844450;
					}
					else
					{
						num = -1576082768;
						num22 = -1576082768;
					}
					continue;
				}
				case 20u:
					num = ((int)num2 * -424631693) ^ -1461517065;
					continue;
				case 19u:
				{
					int num20;
					int num21;
					if (!flag4)
					{
						num20 = 1393431704;
						num21 = 1393431704;
					}
					else
					{
						num20 = 68679048;
						num21 = 68679048;
					}
					num = num20 ^ (int)(num2 * 1554385173);
					continue;
				}
				case 18u:
				{
					int num18;
					if ((uint)c <= 93u)
					{
						num = -1545735564;
						num18 = -1545735564;
					}
					else
					{
						num = -1965260734;
						num18 = -1965260734;
					}
					continue;
				}
				case 17u:
					stack.Pop();
					num = -1358325359;
					continue;
				case 16u:
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -265837675) ^ 0x77566E32;
					continue;
				case 15u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1310575466) ^ 0x5ECCC86B;
					continue;
				case 14u:
				{
					int num15;
					int num16;
					if (c != ':')
					{
						num15 = 2023741945;
						num16 = 2023741945;
					}
					else
					{
						num15 = 1517038830;
						num16 = 1517038830;
					}
					num = num15 ^ ((int)num2 * -277082032);
					continue;
				}
				case 13u:
					c = c2;
					num = (int)(num2 * 1818369286) ^ -2111108388;
					continue;
				case 12u:
				{
					int num11;
					int num12;
					if (flag)
					{
						num11 = 910982609;
						num12 = 910982609;
					}
					else
					{
						num11 = 304602535;
						num12 = 304602535;
					}
					num = num11 ^ ((int)num2 * -482849686);
					continue;
				}
				case 11u:
				{
					int num8;
					int num9;
					if (!(jSONNode is JSONArray))
					{
						num8 = 2043139325;
						num9 = 2043139325;
					}
					else
					{
						num8 = 730159161;
						num9 = 730159161;
					}
					num = num8 ^ (int)(num2 * 1782986908);
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if ((uint)c > 44u)
					{
						num5 = 1591901548;
						num6 = 1591901548;
					}
					else
					{
						num5 = 788062076;
						num6 = 788062076;
					}
					num = num5 ^ ((int)num2 * -1891695229);
					continue;
				}
				case 9u:
					num = ((int)num2 * -1428588147) ^ -1462407264;
					continue;
				case 8u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)(num2 * 610384899) ^ -844671806;
					continue;
				case 7u:
					num = (int)(num2 * 1810313226) ^ -1785366325;
					continue;
				case 6u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 26639278) ^ 0x3084E640);
					continue;
				case 5u:
				{
					int num3;
					if (c == '{')
					{
						num = -1001229661;
						num3 = -1001229661;
					}
					else
					{
						num = -255322148;
						num3 = -255322148;
					}
					continue;
				}
				case 4u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -882279221) ^ 0x4821F73E;
					continue;
				case 3u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1832317022) ^ 0x5C51FEA3;
					continue;
				case 1u:
					num = ((int)num2 * -1399446254) ^ -525896481;
					continue;
				case 0u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 322961023) ^ -431085881;
					continue;
				case 83u:
					break;
				case 71u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 95u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_04fe:
					num4++;
					num = -1646435353;
					continue;
					IL_04de:
					if (flag5)
					{
						num = -829080631;
						num23 = -829080631;
					}
					else
					{
						num = -2143657922;
						num23 = -2143657922;
					}
					continue;
					IL_04d4:
					num = -1983927137;
					continue;
					IL_0394:
					num = ((int)num2 * -65651635) ^ -527435025;
					continue;
					IL_0368:
					num4++;
					num = -544006532;
					continue;
					IL_03a7:
					flag = flag5;
					num = -38399929;
					continue;
					IL_0292:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -596287837;
					continue;
					IL_027a:
					text2 = JSONNode.smethod_3(text2, c4.ToString());
					num = -1022926885;
					continue;
					IL_02a8:
					num = -1117089067;
					continue;
					IL_0264:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -1073986372;
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
		while (true)
		{
			int num = -1094897493;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84843DD6u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				Serialize(aWriter);
				num = ((int)num2 * -56155071) ^ 0x2AB3AF15;
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
				int num = -277456309;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD01CD86Cu) % 3u)
					{
					case 2u:
						goto IL_0026;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0026:
					num = (int)(num2 * 2050225848) ^ -748591336;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008e:
					int num3 = -1540192485;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xD01CD86Cu) % 3u)
						{
						case 1u:
							goto IL_005e;
						default:
							goto end_IL_0071;
						case 0u:
							break;
						case 2u:
							goto end_IL_0071;
						}
						goto IL_008e;
						IL_005e:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)((num2 * 766843221) ^ 0x179EFA8B);
						continue;
						end_IL_0071:
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
			while (true)
			{
				int num = 1612512657;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CE3E8Bu) % 4u)
					{
					case 2u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -1535168924) ^ -848510182;
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1619842757) ^ 0x176EC020;
						continue;
					case 3u:
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
					IL_00b9:
					int num3 = 682460002;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x2CE3E8Bu) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 718259122) ^ 0x3A070959);
							continue;
						case 0u:
							num3 = ((int)num2 * -1312994238) ^ 0xAA62E2D;
							continue;
						default:
							goto end_IL_0098;
						case 3u:
							break;
						case 2u:
							goto end_IL_0098;
						}
						goto IL_00b9;
						continue;
						end_IL_0098:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		bool flag2 = default(bool);
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		int num9 = default(int);
		JSONNode aItem = default(JSONNode);
		int num10 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		int num3 = default(int);
		bool flag = default(bool);
		string aKey = default(string);
		int num4 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		while (true)
		{
			int num = -690671145;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB54C071u) % 35u)
				{
				case 34u:
					num = ((int)num2 * -1227814061) ^ 0x3D02C0B2;
					continue;
				case 33u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1961555239;
						num8 = 1961555239;
					}
					else
					{
						num7 = 957858887;
						num8 = 957858887;
					}
					num = num7 ^ (int)(num2 * 1986309700);
					continue;
				}
				case 32u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -118066386;
					continue;
				case 31u:
					jSONClass = new JSONClass();
					num9 = 0;
					num = ((int)num2 * -830507191) ^ 0x553E9172;
					continue;
				case 30u:
					num = (int)((num2 * 936896963) ^ 0x66B1E57F);
					continue;
				case 29u:
					num = (int)((num2 * 765637257) ^ 0x28691F7F);
					continue;
				case 28u:
					goto IL_009c;
				case 27u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -2039120088) ^ -587318572;
					continue;
				case 26u:
					goto IL_00c6;
				case 25u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -508806390) ^ 0x29A54218;
					continue;
				case 24u:
					num9++;
					num = ((int)num2 * -1212953141) ^ 0x45734EAC;
					continue;
				case 23u:
					num = ((int)num2 * -931707176) ^ 0x16B52C76;
					continue;
				case 22u:
					num10 = JSONNode.smethod_21(aReader);
					num = (int)((num2 * 2074549381) ^ 0x519F75ED);
					continue;
				case 21u:
					flag2 = num9 < num10;
					num = -817881215;
					continue;
				case 20u:
					goto IL_0151;
				case 19u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.Class:
						goto IL_009c;
					case JSONBinaryTag.IntValue:
						goto IL_00c6;
					case JSONBinaryTag.FloatValue:
						goto IL_0151;
					default:
						goto IL_018c;
					case JSONBinaryTag.Array:
						goto IL_019f;
					case JSONBinaryTag.Value:
						goto IL_01ba;
					case JSONBinaryTag.BoolValue:
						goto IL_01d1;
					}
					goto case 32u;
				case 13u:
					goto IL_019f;
				case 6u:
					goto IL_01ba;
				case 17u:
					goto IL_01d1;
				case 18u:
					result = jSONArray;
					num = ((int)num2 * -1550989435) ^ 0x5C46BECB;
					continue;
				case 15u:
					jSONArray.Add(Deserialize(aReader));
					num3++;
					num = -338547031;
					continue;
				case 12u:
					num = -215029234;
					continue;
				case 11u:
					result = jSONClass;
					num = ((int)num2 * -627193776) ^ 0x6827E718;
					continue;
				case 9u:
					num = (int)((num2 * 1289255002) ^ 0x2ECC3A1);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1699173198;
						num6 = 1699173198;
					}
					else
					{
						num5 = 229080446;
						num6 = 229080446;
					}
					num = num5 ^ (int)(num2 * 85063170);
					continue;
				}
				case 7u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1425219899) ^ -762559520;
					continue;
				case 5u:
					num = (int)(num2 * 1655778209) ^ -88412869;
					continue;
				case 4u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1825824141) ^ -460407605;
					continue;
				case 3u:
					num = (int)(num2 * 2115670493) ^ -155562905;
					continue;
				case 2u:
					flag = num3 < num4;
					num = -1294862664;
					continue;
				case 1u:
				{
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -1794853576) ^ 0x5DD3110A;
					continue;
				}
				case 0u:
					num = ((int)num2 * -1239163987) ^ -294762804;
					continue;
				case 16u:
					break;
				case 10u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_01d1:
					num = -47072830;
					continue;
					IL_01ba:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1784713664;
					continue;
					IL_019f:
					num4 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num3 = 0;
					num = -338547031;
					continue;
					IL_018c:
					num = (int)((num2 * 604922789) ^ 0x5771A129);
					continue;
					IL_0151:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1076068988;
					continue;
					IL_00c6:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -118066386;
					continue;
					IL_009c:
					num = -531547882;
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
					int num = -1572997888;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xA152BDABu) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -1967525968) ^ 0x79598D4E;
							continue;
						case 1u:
							num = (int)((num2 * 860204211) ^ 0x20094AC6);
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

	public static JSONNode LoadFromFile(string aFileName)
	{
		FileStream fileStream = JSONNode.smethod_27(aFileName);
		try
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 536918181;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFF904DEu) % 3u)
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
					num = ((int)num2 * -436900879) ^ -1086413259;
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
					int num3 = 1106542091;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xFF904DEu) % 4u)
						{
						case 3u:
							num3 = ((int)num2 * -2099977203) ^ 0x6021F807;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 189021275) ^ -476768654;
							continue;
						default:
							goto end_IL_006b;
						case 0u:
							break;
						case 2u:
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = JSONNode.smethod_29(byte_);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -820558721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC55866Bu) % 5u)
				{
				case 2u:
					num = (int)((num2 * 1639479570) ^ 0x4D8BD11D);
					continue;
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1987533544) ^ 0xE0ECF74;
					continue;
				case 0u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1470092015) ^ 0x5B00CC09);
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
