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
				int num = 337815252;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4CDA829u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1572259620) ^ -309797685;
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -314170377) ^ 0x4DCCFDBD;
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

	public virtual JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = null;
			while (true)
			{
				int num = -353387014;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED51D493u) % 3u)
					{
					case 2u:
						goto IL_0004;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0004:
					num = (int)((num2 * 547625129) ^ 0x218196CC);
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
				int num = 1175026176;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5933B9F8u) % 3u)
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
					num = ((int)num2 * -23188635) ^ 0x41590682;
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
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			while (true)
			{
				int num = 1576145182;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5742F97u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_DeepChilds_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -35847429) ^ 0x40BAFB9A;
				}
			}
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
				int num = 970961127;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x27F11D80u) % 6u)
					{
					case 5u:
						result = 0;
						num = 184388590;
						continue;
					case 4u:
						result = result2;
						num = (int)((num2 * 261576873) ^ 0x8D08A32);
						continue;
					case 1u:
					{
						result2 = 0;
						int num3;
						int num4;
						if (!int.TryParse(Value, out result2))
						{
							num3 = -317834090;
							num4 = -317834090;
						}
						else
						{
							num3 = -1917866645;
							num4 = -1917866645;
						}
						num = num3 ^ (int)(num2 * 34779073);
						continue;
					}
					case 0u:
						num = (int)(num2 * 115520660) ^ -2136624970;
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
			float result2 = default(float);
			float result = default(float);
			while (true)
			{
				int num = 1322494460;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x17BFF4E9u) % 6u)
					{
					case 5u:
					{
						result2 = 0f;
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = 1175919813;
							num4 = 1175919813;
						}
						else
						{
							num3 = 2102728616;
							num4 = 2102728616;
						}
						num = num3 ^ ((int)num2 * -1744485329);
						continue;
					}
					case 4u:
						result = 0f;
						num = 798845124;
						continue;
					case 2u:
						num = (int)(num2 * 574934770) ^ -1064984168;
						continue;
					case 1u:
						result = result2;
						num = (int)((num2 * 1080039085) ^ 0x47A4469C);
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
				int num = -708328567;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D1C57D3u) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = ((int)num2 * -1749266820) ^ 0x38931CA;
						continue;
					case 1u:
						num = (int)(num2 * 2045681683) ^ -834574076;
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

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			bool flag = default(bool);
			double result2 = default(double);
			while (true)
			{
				int num = -1915585927;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDD569C8Au) % 7u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1743187870;
							num4 = -1743187870;
						}
						else
						{
							num3 = -454006162;
							num4 = -454006162;
						}
						num = num3 ^ (int)(num2 * 442258791);
						continue;
					}
					case 4u:
						result2 = 0.0;
						num = -120569820;
						continue;
					case 3u:
						result2 = result;
						num = ((int)num2 * -492634011) ^ 0x16E9EF00;
						continue;
					case 2u:
						flag = double.TryParse(Value, out result);
						num = (int)(num2 * 345275584) ^ -1191440800;
						continue;
					case 1u:
						num = (int)(num2 * 1809017029) ^ -160811604;
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

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool result2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = 331333239;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x424ADCD1u) % 7u)
					{
					case 5u:
						result2 = !JSONNode.smethod_1(Value);
						num = 111139161;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 208675362;
							num4 = 208675362;
						}
						else
						{
							num3 = 1851911021;
							num4 = 1851911021;
						}
						num = num3 ^ ((int)num2 * -1005712207);
						continue;
					}
					case 3u:
						result2 = result;
						num = ((int)num2 * -1604011657) ^ 0x2C852F34;
						continue;
					case 2u:
						flag = bool.TryParse(Value, out result);
						num = (int)(num2 * 1502169791) ^ -2042896210;
						continue;
					case 1u:
						num = ((int)num2 * -71332728) ^ 0x15BB42A1;
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
		}
	}

	public virtual JSONArray AsArray => this as JSONArray;

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = this as JSONClass;
			while (true)
			{
				int num = 483884116;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5229AFC6u) % 3u)
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
					num = ((int)num2 * -1944191869) ^ 0x233FB01D;
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
			int num = 32882213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68E3C7E7u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1882791636) ^ 0x14053C6E;
					continue;
				case 2u:
					Add("", aItem);
					num = (int)((num2 * 439592649) ^ 0x7D3761E);
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
			int num = -1035394707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA16C559Au) % 4u)
				{
				case 3u:
					result = null;
					num = (int)(num2 * 1335292945) ^ -882208581;
					continue;
				case 2u:
					num = ((int)num2 * -718466336) ^ 0x6219139B;
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
			int num = 1362032452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x520C1u) % 3u)
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
				num = ((int)num2 * -1291740100) ^ -1328718328;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1294279140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BD10A8Au) % 3u)
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
				num = ((int)num2 * -778245545) ^ -900956369;
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 1212311445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x403269D0u) % 3u)
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
				num = (int)((num2 * 1386648737) ^ 0x38A2B2A8);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -228270590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAEC2670Du) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = (int)((num2 * 947078956) ^ 0x3879A805);
					continue;
				case 0u:
					num = (int)((num2 * 153241452) ^ 0x22038A5C);
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = new JSONData(s);
		while (true)
		{
			int num = 637045443;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71768ABDu) % 3u)
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
				num = (int)(num2 * 1445515555) ^ -1104017421;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		if (!(d == null))
		{
			goto IL_000c;
		}
		object obj = null;
		goto IL_0047;
		IL_0041:
		obj = d.Value;
		goto IL_0047;
		IL_000c:
		int num = -1905438659;
		goto IL_0020;
		IL_0020:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xB9F89288u) % 4u)
			{
			case 3u:
				break;
			case 2u:
				num = (int)(num2 * 778550743) ^ -683789870;
				continue;
			case 1u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_000c;
		IL_0047:
		result = (string)obj;
		num = -2018287606;
		goto IL_0020;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b == null)
		{
			goto IL_0036;
		}
		goto IL_008e;
		IL_0036:
		int num = 418746065;
		goto IL_0056;
		IL_0056:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x68532EC2u) % 7u)
			{
			case 6u:
				num = ((int)num2 * -1706399307) ^ 0x19412598;
				continue;
			case 3u:
				result = true;
				num = (int)((num2 * 1900742308) ^ 0x25DE8A30);
				continue;
			case 2u:
				break;
			case 1u:
				result = (object)a == b;
				num = 37811156;
				continue;
			case 0u:
				num = (int)((num2 * 2060659042) ^ 0x8F831BE);
				continue;
			case 4u:
				goto IL_0083;
			default:
				return result;
			}
			break;
			IL_0083:
			if (a is JSONLazyCreator)
			{
				num = 1182905862;
				num3 = 1182905862;
				continue;
			}
			goto IL_008e;
		}
		goto IL_0036;
		IL_008e:
		num = 1181888320;
		num3 = 1181888320;
		goto IL_0056;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -200388297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB5585C8u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = (int)((num2 * 392789759) ^ 0x565BBA94);
					continue;
				case 1u:
					num = ((int)num2 * -1168005434) ^ -625502756;
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
			int num = -1984507604;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ABB647Cu) % 3u)
				{
				case 1u:
					goto IL_0007;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0007:
				num = (int)((num2 * 1325268800) ^ 0x408868E6);
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -1340483456;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEAD7B18u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = (int)((num2 * 1823545029) ^ 0x2F4218CD);
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		char c2 = default(char);
		char c3 = default(char);
		char c = default(char);
		while (true)
		{
			int num = 705410700;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E110CF2u) % 31u)
				{
				case 30u:
					text = JSONNode.smethod_3(text, "\\f");
					num = 226152024;
					continue;
				case 29u:
					num = (int)((num2 * 1336228245) ^ 0x77382574);
					continue;
				case 28u:
					num3 = 0;
					num = (int)(num2 * 1192793486) ^ -973580223;
					continue;
				case 26u:
					text = "";
					num = ((int)num2 * -1533648774) ^ 0x468A318A;
					continue;
				case 25u:
				{
					int num6;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = 834326405;
						num6 = 834326405;
					}
					else
					{
						num = 1793073287;
						num6 = 1793073287;
					}
					continue;
				}
				case 24u:
					num = (int)(num2 * 1450551109) ^ -1723454038;
					continue;
				case 23u:
					result = text;
					num = ((int)num2 * -1042534849) ^ -1540134719;
					continue;
				case 22u:
					c2 = c3;
					num = (int)((num2 * 427720861) ^ 0x7E68CC1A);
					continue;
				case 21u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 2072535169;
					continue;
				case 20u:
					switch (c2)
					{
					case '\f':
						break;
					default:
						goto IL_00f9;
					case '\b':
						goto IL_010c;
					case '\t':
						goto IL_0122;
					case '\n':
						goto IL_0138;
					case '\v':
						goto IL_014e;
					case '\r':
						goto IL_0166;
					}
					goto case 30u;
				case 4u:
					goto IL_010c;
				case 2u:
					goto IL_0122;
				case 10u:
					goto IL_0138;
				case 14u:
					goto IL_014e;
				case 5u:
					goto IL_0166;
				case 19u:
					num = (int)(num2 * 912780193) ^ -2017894259;
					continue;
				case 18u:
					num = ((int)num2 * -470249427) ^ 0x4D912197;
					continue;
				case 17u:
					num3++;
					num = 1025688816;
					continue;
				case 16u:
				{
					int num5;
					if (c2 != '\\')
					{
						num = 632867320;
						num5 = 632867320;
					}
					else
					{
						num = 704641876;
						num5 = 704641876;
					}
					continue;
				}
				case 15u:
					num = ((int)num2 * -979360257) ^ -136627935;
					continue;
				case 13u:
					num = ((int)num2 * -1558300126) ^ 0x2021D618;
					continue;
				case 12u:
					c3 = c;
					num = ((int)num2 * -1934307563) ^ -1902680753;
					continue;
				case 11u:
				{
					int num4;
					if (c2 == '"')
					{
						num = 1257914099;
						num4 = 1257914099;
					}
					else
					{
						num = 1890926254;
						num4 = 1890926254;
					}
					continue;
				}
				case 9u:
					num = (int)((num2 * 100288949) ^ 0x21CEB617);
					continue;
				case 8u:
					num = ((int)num2 * -1104257027) ^ -551654526;
					continue;
				case 7u:
					c = JSONNode.smethod_2(string_, num3);
					num = 191980974;
					continue;
				case 6u:
					string_ = aText;
					num = (int)(num2 * 698600777) ^ -1430454825;
					continue;
				case 3u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 304236242;
					continue;
				case 0u:
					num = ((int)num2 * -666312944) ^ 0x6BB2BFD8;
					continue;
				case 27u:
					break;
				default:
					{
						return result;
					}
					IL_0166:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1575832682;
					continue;
					IL_014e:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 226152024;
					continue;
					IL_0138:
					text = JSONNode.smethod_3(text, "\\n");
					num = 2123664793;
					continue;
					IL_0122:
					text = JSONNode.smethod_3(text, "\\t");
					num = 226152024;
					continue;
					IL_010c:
					text = JSONNode.smethod_3(text, "\\b");
					num = 226152024;
					continue;
					IL_00f9:
					num = ((int)num2 * -381474996) ^ 0x7F6E01E5;
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
		char c = default(char);
		char c3 = default(char);
		char c2 = default(char);
		bool flag3 = default(bool);
		string text = default(string);
		int num8 = default(int);
		bool flag13 = default(bool);
		char c4 = default(char);
		string text2 = default(string);
		string s = default(string);
		bool flag4 = default(bool);
		bool flag12 = default(bool);
		bool flag9 = default(bool);
		bool flag11 = default(bool);
		bool flag5 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag8 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		while (true)
		{
			int num = 1552337860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26E4D65Du) % 147u)
				{
				case 146u:
				{
					int num29;
					if (c == ' ')
					{
						num = 515286876;
						num29 = 515286876;
					}
					else
					{
						num = 1438228491;
						num29 = 1438228491;
					}
					continue;
				}
				case 145u:
					num = (int)(num2 * 1856833024) ^ -437172074;
					continue;
				case 144u:
					num = (int)((num2 * 744209528) ^ 0x38401615);
					continue;
				case 143u:
					c3 = c2;
					num = (int)((num2 * 2124146320) ^ 0x731B9422);
					continue;
				case 142u:
					num = (int)((num2 * 1637153393) ^ 0x35ED725E);
					continue;
				case 140u:
					num = ((int)num2 * -2132358570) ^ 0x344843D5;
					continue;
				case 139u:
				{
					int num31;
					if (!flag3)
					{
						num = 1911267465;
						num31 = 1911267465;
					}
					else
					{
						num = 786068163;
						num31 = 786068163;
					}
					continue;
				}
				case 138u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -465837535) ^ 0x6B4350B;
					continue;
				case 137u:
					num = (int)((num2 * 1179290356) ^ 0x1A4F535C);
					continue;
				case 73u:
				case 84u:
				case 116u:
				case 122u:
				case 136u:
					num8++;
					num = 630784319;
					continue;
				case 135u:
					text = JSONNode.smethod_5(text);
					flag13 = jSONNode is JSONArray;
					num = (int)(num2 * 755298651) ^ -1642542088;
					continue;
				case 134u:
				{
					int num47;
					if (c4 != 'f')
					{
						num = 1769185163;
						num47 = 1769185163;
					}
					else
					{
						num = 1727207411;
						num47 = 1727207411;
					}
					continue;
				}
				case 133u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -2145444837) ^ -1473703645;
					continue;
				case 132u:
					num = (int)((num2 * 503617239) ^ 0x367C0DCB);
					continue;
				case 131u:
					num = (int)((num2 * 1316801914) ^ 0x2EB26D5A);
					continue;
				case 130u:
					num8 += 4;
					num = (int)(num2 * 1452960341) ^ -2014173900;
					continue;
				case 129u:
				{
					int num32;
					if (c != '}')
					{
						num = 1333053751;
						num32 = 1333053751;
					}
					else
					{
						num = 761350670;
						num32 = 761350670;
					}
					continue;
				}
				case 128u:
				{
					int num26;
					int num27;
					if (!flag4)
					{
						num26 = 38564343;
						num27 = 38564343;
					}
					else
					{
						num26 = 763305423;
						num27 = 763305423;
					}
					num = num26 ^ ((int)num2 * -874715960);
					continue;
				}
				case 127u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1727556796) ^ 0x464BF049);
					continue;
				case 126u:
					stack.Push(new JSONArray());
					num = 1266630625;
					continue;
				case 125u:
					num = (int)((num2 * 463140736) ^ 0x720FCC3D);
					continue;
				case 124u:
					num = ((int)num2 * -1299096380) ^ -672128261;
					continue;
				case 123u:
					num = ((int)num2 * -730563451) ^ 0x2580ECE4;
					continue;
				case 121u:
					text2 = JSONNode.smethod_3(text2, c2.ToString());
					num = 1444260087;
					continue;
				case 120u:
				{
					int num59;
					int num60;
					if (flag12)
					{
						num59 = -1446873053;
						num60 = -1446873053;
					}
					else
					{
						num59 = -1324381009;
						num60 = -1324381009;
					}
					num = num59 ^ (int)(num2 * 1553349613);
					continue;
				}
				case 119u:
				{
					int num57;
					if (num8 >= JSONNode.smethod_4(aJSON))
					{
						num = 399136732;
						num57 = 399136732;
					}
					else
					{
						num = 1054758752;
						num57 = 1054758752;
					}
					continue;
				}
				case 118u:
					goto IL_02ca;
				case 117u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1386224932) ^ -1752654180;
					continue;
				case 115u:
					num = (int)((num2 * 298916982) ^ 0x5F90895C);
					continue;
				case 114u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -328168769) ^ -1590710895;
					continue;
				case 113u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -980063419) ^ -2008287513;
					continue;
				case 112u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -687318632) ^ 0x417114A;
					continue;
				case 111u:
					goto IL_0389;
				case 110u:
					num = 1412954220;
					continue;
				case 109u:
				{
					int num48;
					int num49;
					if (!flag9)
					{
						num48 = 2073958056;
						num49 = 2073958056;
					}
					else
					{
						num48 = 1186886131;
						num49 = 1186886131;
					}
					num = num48 ^ (int)(num2 * 577690940);
					continue;
				}
				case 108u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 1906803277;
					continue;
				case 107u:
					flag12 = flag3;
					num = (int)(num2 * 1573432744) ^ -640462020;
					continue;
				case 106u:
					num = ((int)num2 * -1657923216) ^ 0x7235862D;
					continue;
				case 105u:
					flag11 = flag3;
					num = 1628728383;
					continue;
				case 104u:
					num = ((int)num2 * -355987213) ^ 0x164BFEF;
					continue;
				case 103u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 1938087473) ^ -383569503;
					continue;
				case 102u:
				{
					int num40;
					if ((uint)c > 93u)
					{
						num = 332051097;
						num40 = 332051097;
					}
					else
					{
						num = 394150048;
						num40 = 394150048;
					}
					continue;
				}
				case 101u:
					num = (int)((num2 * 1456619139) ^ 0x488F0D8A);
					continue;
				case 100u:
				{
					c4 = c3;
					int num35;
					int num36;
					if ((uint)c4 > 102u)
					{
						num35 = -400766645;
						num36 = -400766645;
					}
					else
					{
						num35 = -628991502;
						num36 = -628991502;
					}
					num = num35 ^ (int)(num2 * 1151094512);
					continue;
				}
				case 99u:
					goto IL_04c1;
				case 98u:
				{
					stack.Push(new JSONClass());
					int num28;
					if (!(jSONNode != null))
					{
						num = 713044618;
						num28 = 713044618;
					}
					else
					{
						num = 525826209;
						num28 = 525826209;
					}
					continue;
				}
				case 96u:
				{
					int num22;
					int num23;
					if (!flag5)
					{
						num22 = -771605846;
						num23 = -771605846;
					}
					else
					{
						num22 = -1226051577;
						num23 = -1226051577;
					}
					num = num22 ^ ((int)num2 * -172632770);
					continue;
				}
				case 95u:
					flag10 = flag3;
					num = 445790359;
					continue;
				case 94u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 602805738) ^ -585359468;
					continue;
				case 93u:
				{
					int num17;
					int num18;
					if (jSONNode != null)
					{
						num17 = -198136956;
						num18 = -198136956;
					}
					else
					{
						num17 = -259736427;
						num18 = -259736427;
					}
					num = num17 ^ ((int)num2 * -2003463285);
					continue;
				}
				case 92u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 564499336;
					continue;
				case 91u:
				{
					int num11;
					int num12;
					if (flag6)
					{
						num11 = -1554385841;
						num12 = -1554385841;
					}
					else
					{
						num11 = -1860220034;
						num12 = -1860220034;
					}
					num = num11 ^ ((int)num2 * -870089854);
					continue;
				}
				case 90u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1556082393;
						num6 = -1556082393;
					}
					else
					{
						num5 = -906227133;
						num6 = -906227133;
					}
					num = num5 ^ ((int)num2 * -1064978350);
					continue;
				}
				case 89u:
					switch (c)
					{
					case ']':
						break;
					default:
						goto IL_060d;
					case '[':
						goto IL_0617;
					case '\\':
						goto IL_0625;
					}
					goto case 95u;
				case 88u:
					goto IL_0617;
				case 11u:
					goto IL_0625;
				case 87u:
					num = (int)(num2 * 956164283) ^ -977655442;
					continue;
				case 86u:
					num = (int)(num2 * 1636701136) ^ -149423332;
					continue;
				case 85u:
					num = ((int)num2 * -848297505) ^ -1355332656;
					continue;
				case 83u:
				{
					int num58;
					if (c != '{')
					{
						num = 1820897550;
						num58 = 1820897550;
					}
					else
					{
						num = 1057646809;
						num58 = 1057646809;
					}
					continue;
				}
				case 82u:
					num = ((int)num2 * -258774571) ^ -1181300281;
					continue;
				case 81u:
					switch (c4)
					{
					case 's':
						break;
					case 't':
						goto IL_0389;
					default:
						goto IL_06bb;
					case 'r':
						goto IL_06c5;
					case 'u':
						goto IL_06db;
					}
					goto case 121u;
				case 39u:
					goto IL_06c5;
				case 28u:
					goto IL_06db;
				case 80u:
				{
					int num55;
					int num56;
					if (!flag8)
					{
						num55 = 1073979668;
						num56 = 1073979668;
					}
					else
					{
						num55 = 1637260250;
						num56 = 1637260250;
					}
					num = num55 ^ ((int)num2 * -930294918);
					continue;
				}
				case 79u:
				{
					int num53;
					int num54;
					if (!flag13)
					{
						num53 = 734746999;
						num54 = 734746999;
					}
					else
					{
						num53 = 1189144486;
						num54 = 1189144486;
					}
					num = num53 ^ ((int)num2 * -2129555086);
					continue;
				}
				case 78u:
				{
					int num51;
					int num52;
					if (!flag3)
					{
						num51 = 1897606091;
						num52 = 1897606091;
					}
					else
					{
						num51 = 616674571;
						num52 = 616674571;
					}
					num = num51 ^ ((int)num2 * -1785225544);
					continue;
				}
				case 77u:
					num = (int)((num2 * 727550695) ^ 0x15F20673);
					continue;
				case 76u:
					num = 713044618;
					continue;
				case 75u:
					num = (int)(num2 * 74943729) ^ -57658371;
					continue;
				case 74u:
					num = ((int)num2 * -1623665792) ^ 0x66E0DABD;
					continue;
				case 72u:
					text = "";
					text2 = "";
					jSONNode = stack.Peek();
					num = 2098948700;
					continue;
				case 71u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)((num2 * 410636313) ^ 0x7CC9CD33);
					continue;
				case 70u:
				{
					int num50;
					if (c != '"')
					{
						num = 144289992;
						num50 = 144289992;
					}
					else
					{
						num = 372676286;
						num50 = 372676286;
					}
					continue;
				}
				case 69u:
					flag3 = !flag3;
					num = 1444311339;
					continue;
				case 68u:
				{
					int num45;
					int num46;
					if (c4 == 'b')
					{
						num45 = -2051371099;
						num46 = -2051371099;
					}
					else
					{
						num45 = -141461579;
						num46 = -141461579;
					}
					num = num45 ^ (int)(num2 * 1154605613);
					continue;
				}
				case 67u:
				{
					int num44;
					if (flag3)
					{
						num = 857539542;
						num44 = 857539542;
					}
					else
					{
						num = 1331001408;
						num44 = 1331001408;
					}
					continue;
				}
				case 66u:
				{
					int num43;
					if (c4 != 'n')
					{
						num = 1234788477;
						num43 = 1234788477;
					}
					else
					{
						num = 299330845;
						num43 = 299330845;
					}
					continue;
				}
				case 65u:
				{
					int num41;
					int num42;
					if (jSONNode is JSONArray)
					{
						num41 = 194627133;
						num42 = 194627133;
					}
					else
					{
						num41 = 623726672;
						num42 = 623726672;
					}
					num = num41 ^ (int)(num2 * 1459504506);
					continue;
				}
				case 64u:
					flag6 = stack.Count == 0;
					num = 2126209224;
					continue;
				case 63u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 503869832) ^ -1612867236;
					continue;
				case 62u:
					text2 = "";
					num = ((int)num2 * -951720055) ^ 0x46070682;
					continue;
				case 61u:
				{
					int num39;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 1280488252;
						num39 = 1280488252;
					}
					else
					{
						num = 1907711936;
						num39 = 1907711936;
					}
					continue;
				}
				case 60u:
					num = (int)((num2 * 1884446678) ^ 0x119F9A5C);
					continue;
				case 59u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 1516325861) ^ 0x3DC4DC3B);
					continue;
				case 58u:
					num = (int)((num2 * 994531469) ^ 0x16A803EA);
					continue;
				case 57u:
					text = "";
					text2 = "";
					num = 463110393;
					continue;
				case 56u:
				{
					int num37;
					int num38;
					if ((uint)c <= 44u)
					{
						num37 = 1190958503;
						num38 = 1190958503;
					}
					else
					{
						num37 = 689004456;
						num38 = 689004456;
					}
					num = num37 ^ (int)(num2 * 976694598);
					continue;
				}
				case 55u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 1906803277;
					continue;
				case 54u:
					num = (int)(num2 * 889950147) ^ -2007850264;
					continue;
				case 53u:
					num = (int)((num2 * 1168498650) ^ 0x55469412);
					continue;
				case 52u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1027953434) ^ 0x77ABD81D;
					continue;
				case 51u:
					text = "";
					num = 1230038841;
					continue;
				case 50u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num8);
					c = c5;
					num = (int)((num2 * 497243473) ^ 0x69C0300B);
					continue;
				}
				case 49u:
				{
					int num33;
					int num34;
					if (flag11)
					{
						num33 = 1953173087;
						num34 = 1953173087;
					}
					else
					{
						num33 = 1879539605;
						num34 = 1879539605;
					}
					num = num33 ^ ((int)num2 * -447770569);
					continue;
				}
				case 48u:
					text = "";
					num = 250658510;
					continue;
				case 47u:
					num = (int)((num2 * 1346105278) ^ 0x27714509);
					continue;
				case 46u:
				{
					int num30;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 921919870;
						num30 = 921919870;
					}
					else
					{
						num = 691153572;
						num30 = 691153572;
					}
					continue;
				}
				case 45u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_02ca;
					case '\t':
						goto IL_04c1;
					default:
						goto IL_0ae4;
					}
					goto case 73u;
				case 44u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 225788435) ^ -1201036254;
					continue;
				case 43u:
					flag2 = JSONNode.smethod_6(text, "");
					num = 117474456;
					continue;
				case 42u:
					result = jSONNode;
					num = 1811957263;
					continue;
				case 41u:
					num = 1833092555;
					continue;
				case 40u:
				{
					int num24;
					int num25;
					if (jSONNode is JSONArray)
					{
						num24 = -917209377;
						num25 = -917209377;
					}
					else
					{
						num24 = -138222231;
						num25 = -138222231;
					}
					num = num24 ^ (int)(num2 * 2050449074);
					continue;
				}
				case 38u:
					num = ((int)num2 * -154979956) ^ -1864819032;
					continue;
				case 37u:
				{
					int num21;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 326449652;
						num21 = 326449652;
					}
					else
					{
						num = 2078417858;
						num21 = 2078417858;
					}
					continue;
				}
				case 36u:
				{
					int num19;
					int num20;
					if (flag10)
					{
						num19 = 300453084;
						num20 = 300453084;
					}
					else
					{
						num19 = 1065017144;
						num20 = 1065017144;
					}
					num = num19 ^ (int)(num2 * 486002502);
					continue;
				}
				case 35u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 1906803277;
					continue;
				case 34u:
					num = (int)(num2 * 695962416) ^ -1454654698;
					continue;
				case 33u:
					num = ((int)num2 * -403419956) ^ -2121612217;
					continue;
				case 32u:
					text2 = "";
					num = (int)((num2 * 1158028832) ^ 0x3F75E839);
					continue;
				case 31u:
					flag9 = stack.Count > 0;
					num = (int)(num2 * 1400029497) ^ -770216164;
					continue;
				case 29u:
					num = ((int)num2 * -2034621937) ^ 0x61FF2571;
					continue;
				case 27u:
					num8 = 0;
					text2 = "";
					text = "";
					flag3 = false;
					num = (int)(num2 * 1808383580) ^ -558208018;
					continue;
				case 26u:
					text = JSONNode.smethod_5(text);
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -141028719) ^ 0x4CEDA5E1;
					continue;
				case 25u:
					num = (int)(num2 * 1650191608) ^ -440950724;
					continue;
				case 24u:
				{
					int num15;
					int num16;
					if (flag7)
					{
						num15 = -389483907;
						num16 = -389483907;
					}
					else
					{
						num15 = -1486494051;
						num16 = -1486494051;
					}
					num = num15 ^ ((int)num2 * -68756974);
					continue;
				}
				case 23u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1563744306) ^ 0x19491D06;
					continue;
				case 22u:
					num = (int)((num2 * 320487923) ^ 0x606642D7);
					continue;
				case 21u:
					num = (int)((num2 * 565922507) ^ 0x384345A4);
					continue;
				case 20u:
					num = (int)(num2 * 1247676519) ^ -1244510794;
					continue;
				case 19u:
					s = JSONNode.smethod_8(aJSON, num8 + 1, 4);
					num = ((int)num2 * -796579183) ^ 0x37440787;
					continue;
				case 18u:
					num = (int)(num2 * 1218087027) ^ -1864701139;
					continue;
				case 17u:
					num = 2061944454;
					continue;
				case 16u:
					num = 185183335;
					continue;
				case 15u:
					num = (int)(num2 * 1545310882) ^ -208956894;
					continue;
				case 14u:
					num = ((int)num2 * -1059156424) ^ -750495923;
					continue;
				case 13u:
				{
					int num13;
					int num14;
					if ((uint)c <= 32u)
					{
						num13 = -1641566779;
						num14 = -1641566779;
					}
					else
					{
						num13 = -271427845;
						num14 = -271427845;
					}
					num = num13 ^ ((int)num2 * -830885903);
					continue;
				}
				case 12u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 718885413) ^ -225171243;
					continue;
				case 9u:
					num = 529650664;
					continue;
				case 8u:
					jSONNode.Add(text2);
					num = (int)((num2 * 282001325) ^ 0x313F0ECA);
					continue;
				case 7u:
					c2 = JSONNode.smethod_2(aJSON, num8);
					num = ((int)num2 * -696787250) ^ -1213075159;
					continue;
				case 6u:
				{
					int num9;
					int num10;
					if (c == ':')
					{
						num9 = 991267007;
						num10 = 991267007;
					}
					else
					{
						num9 = 2145143564;
						num10 = 2145143564;
					}
					num = num9 ^ (int)(num2 * 1690648993);
					continue;
				}
				case 5u:
					stack.Pop();
					flag5 = JSONNode.smethod_6(text2, "");
					num = 204394210;
					continue;
				case 4u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1768063617) ^ 0x2AF98728);
					continue;
				case 3u:
					text = text2;
					text2 = "";
					num = 38377150;
					continue;
				case 2u:
				{
					int num7;
					if (c != ',')
					{
						num = 2057337513;
						num7 = 2057337513;
					}
					else
					{
						num = 1075693137;
						num7 = 1075693137;
					}
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -413388041;
						num4 = -413388041;
					}
					else
					{
						num3 = -816029813;
						num4 = -816029813;
					}
					num = num3 ^ (int)(num2 * 597170015);
					continue;
				}
				case 0u:
					num = ((int)num2 * -687777476) ^ 0x664CE123;
					continue;
				case 97u:
					break;
				case 10u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 30u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_060d:
					num = 734629437;
					continue;
					IL_0617:
					flag4 = flag3;
					num = 1246869442;
					continue;
					IL_0ae4:
					num = ((int)num2 * -897837) ^ 0x71A28356;
					continue;
					IL_04c1:
					flag = flag3;
					num = 1042774415;
					continue;
					IL_0389:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 776431165;
					continue;
					IL_02ca:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = 1226382697;
					continue;
					IL_06db:
					num = 900133473;
					continue;
					IL_06c5:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 794596943;
					continue;
					IL_06bb:
					num = 1628222864;
					continue;
					IL_0625:
					num8++;
					num = 29240861;
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
			int num = -972015503;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AE3196Cu) % 3u)
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
				num = ((int)num2 * -1552995112) ^ -1491228933;
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
				int num = -943463988;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC59260DDu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 737996433) ^ 0x5AF0BD9F);
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = ((int)num2 * -1171411229) ^ -1425886880;
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
					IL_00b5:
					int num3 = -2094436164;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xC59260DDu) % 4u)
						{
						case 2u:
							num3 = (int)((num2 * 1442856197) ^ 0x112C12AF);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 1010725275) ^ -1345831048;
							continue;
						default:
							goto end_IL_0094;
						case 3u:
							break;
						case 0u:
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
			while (true)
			{
				int num = -1819068653;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC948FA26u) % 5u)
					{
					case 3u:
						num = (int)((num2 * 691717413) ^ 0x78EE3AB5);
						continue;
					case 2u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -2059194980) ^ -1475193159;
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1177270764) ^ 0x5CC13B70;
						continue;
					case 4u:
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
					int num3 = -2003078328;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xC948FA26u) % 3u)
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
						num3 = (int)(num2 * 1642524574) ^ -1466366470;
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
		JSONClass jSONClass = default(JSONClass);
		JSONNode result = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		bool flag2 = default(bool);
		int num3 = default(int);
		int num10 = default(int);
		bool flag = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		while (true)
		{
			int num = -1737570704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1E8B275u) % 38u)
				{
				case 37u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 613355031) ^ 0x234D2BAC);
					continue;
				}
				case 36u:
					result = jSONArray;
					num = (int)(num2 * 2005768174) ^ -610682492;
					continue;
				case 35u:
					num = (int)(num2 * 1041028908) ^ -577639571;
					continue;
				case 34u:
					num = -776702684;
					continue;
				case 33u:
					num = ((int)num2 * -673209240) ^ 0x10978F89;
					continue;
				case 32u:
					goto IL_007b;
				case 31u:
					goto IL_0085;
				case 30u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.Value:
						goto IL_007b;
					case JSONBinaryTag.IntValue:
						goto IL_0085;
					default:
						goto IL_00c0;
					case JSONBinaryTag.Array:
						goto IL_00d3;
					case JSONBinaryTag.DoubleValue:
						goto IL_00eb;
					case JSONBinaryTag.BoolValue:
						goto IL_0102;
					case JSONBinaryTag.FloatValue:
						goto IL_010c;
					}
					goto case 34u;
				case 25u:
					goto IL_00d3;
				case 13u:
					goto IL_00eb;
				case 18u:
					goto IL_0102;
				case 29u:
					goto IL_010c;
				case 28u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -1961992297) ^ -873017646;
					continue;
				case 26u:
					flag2 = num3 < num10;
					num = -1425528270;
					continue;
				case 23u:
					num = ((int)num2 * -1587717484) ^ 0x36529FDD;
					continue;
				case 22u:
					num = ((int)num2 * -235839456) ^ 0x67C3F261;
					continue;
				case 21u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -49250993;
						num9 = -49250993;
					}
					else
					{
						num8 = -1892788385;
						num9 = -1892788385;
					}
					num = num8 ^ ((int)num2 * -1954559792);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1507439593) ^ 0x1E721B21;
					continue;
				case 19u:
					num5 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num4 = 0;
					num = ((int)num2 * -673237661) ^ -590993168;
					continue;
				case 16u:
					num = -1002215274;
					continue;
				case 15u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1836900067) ^ -815342620;
					continue;
				case 14u:
					num = (int)(num2 * 1104319737) ^ -760750284;
					continue;
				case 12u:
					num3 = 0;
					num = (int)((num2 * 1272953176) ^ 0x456F8BD);
					continue;
				case 11u:
					num = ((int)num2 * -1184523734) ^ -70946345;
					continue;
				case 10u:
					num = ((int)num2 * -1098881793) ^ 0x60139459;
					continue;
				case 9u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)(num2 * 418969988) ^ -35789813;
					continue;
				case 8u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)(num2 * 1375347613) ^ -601290919;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -817020253;
						num7 = -817020253;
					}
					else
					{
						num6 = -580495204;
						num7 = -580495204;
					}
					num = num6 ^ (int)(num2 * 9255578);
					continue;
				}
				case 6u:
					num = -108673778;
					continue;
				case 5u:
					flag = num4 < num5;
					num = -1260028770;
					continue;
				case 4u:
					num = (int)((num2 * 1265800837) ^ 0x270D800F);
					continue;
				case 3u:
					num = ((int)num2 * -1895545320) ^ -865788887;
					continue;
				case 2u:
					num4++;
					num = (int)((num2 * 494625671) ^ 0x68C72C80);
					continue;
				case 1u:
					jSONArray.Add(Deserialize(aReader));
					num3++;
					num = -235757215;
					continue;
				case 0u:
					result = jSONClass;
					num = ((int)num2 * -521717827) ^ 0x78DBF414;
					continue;
				case 17u:
					break;
				case 27u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_007b:
					num = -246029417;
					continue;
					IL_010c:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1188602278;
					continue;
					IL_0102:
					num = -602312016;
					continue;
					IL_00eb:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -1334217631;
					continue;
					IL_00d3:
					num10 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = -1014143893;
					continue;
					IL_00c0:
					num = (int)((num2 * 2003985945) ^ 0x67616409);
					continue;
					IL_0085:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -681649802;
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
					int num = 78141051;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x35D67739u) % 3u)
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
						num = (int)(num2 * 1798037066) ^ -892915440;
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
					int num = 1497945597;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x4C0A2F0Bu) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 896936312) ^ 0x146DABB2);
							continue;
						case 1u:
							num = (int)(num2 * 1221918935) ^ -111081276;
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = -971610771;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB02E078u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -760629701) ^ 0xE63D932;
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -737908517) ^ 0x3FDD3E4D;
					continue;
				case 1u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 2074860040) ^ 0x3F2D4D32);
					continue;
				}
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1734571893) ^ -1238067577;
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
