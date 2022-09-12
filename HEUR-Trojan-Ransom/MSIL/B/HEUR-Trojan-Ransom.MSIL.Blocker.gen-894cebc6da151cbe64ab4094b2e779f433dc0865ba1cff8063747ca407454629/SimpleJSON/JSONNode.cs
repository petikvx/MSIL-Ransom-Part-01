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
				int num = 477238597;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8722EB9u) % 3u)
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
					num = (int)((num2 * 1117714499) ^ 0x5F098010);
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
				int num = -94184580;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE625ACAu) % 3u)
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
					num = (int)((num2 * 1558454862) ^ 0x2E64007E);
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
				int num = 79567007;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7286D010u) % 3u)
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
					num = ((int)num2 * -1656248472) ^ 0x47C0CB27;
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
				int num = 1619862936;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x139095Au) % 4u)
					{
					case 2u:
						result = 0;
						num = ((int)num2 * -1687477815) ^ 0x3A4DFF81;
						continue;
					case 1u:
						num = (int)(num2 * 1724871018) ^ -1464441365;
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
				int num = -912536832;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83C8A83Cu) % 3u)
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
					num = ((int)num2 * -700741477) ^ -475658905;
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
				int num = -1970162730;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x800317B3u) % 4u)
					{
					case 1u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1027308865) ^ -130366894;
						continue;
					case 0u:
						result = _003Cget_DeepChilds_003Ed__;
						num = ((int)num2 * -1418833876) ^ -435607176;
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

	public virtual int AsInt
	{
		get
		{
			int result = default(int);
			int result2 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -1024840971;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA65620CBu) % 8u)
					{
					case 7u:
						result = result2;
						num = ((int)num2 * -273883638) ^ 0x460F64DF;
						continue;
					case 6u:
						result2 = 0;
						num = (int)((num2 * 1538737306) ^ 0x24B664B2);
						continue;
					case 5u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -1765352805) ^ -1880801769;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1353124026;
							num4 = 1353124026;
						}
						else
						{
							num3 = 1594358677;
							num4 = 1594358677;
						}
						num = num3 ^ ((int)num2 * -1718344293);
						continue;
					}
					case 1u:
						num = ((int)num2 * -7008881) ^ -1597582458;
						continue;
					case 0u:
						result = 0;
						num = -1348269350;
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
		set
		{
			Value = value.ToString();
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = default(float);
			float result2 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = -1373504971;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x99135317u) % 8u)
					{
					case 7u:
						result = 0f;
						num = -1162130906;
						continue;
					case 6u:
						num = (int)(num2 * 830401191) ^ -46941832;
						continue;
					case 4u:
						result = result2;
						num = (int)(num2 * 441629093) ^ -1840411907;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2004708667;
							num4 = -2004708667;
						}
						else
						{
							num3 = -471596210;
							num4 = -471596210;
						}
						num = num3 ^ (int)(num2 * 1162248186);
						continue;
					}
					case 2u:
						result2 = 0f;
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)(num2 * 2123848313) ^ -1965434034;
						continue;
					case 1u:
						num = ((int)num2 * -178969432) ^ -1453602518;
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
				int num = 288060301;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2B01F8F9u) % 7u)
					{
					case 5u:
						result2 = 0.0;
						num = 1736076999;
						continue;
					case 3u:
						num = (int)(num2 * 452328524) ^ -1295259897;
						continue;
					case 2u:
						flag = double.TryParse(Value, out result);
						num = (int)(num2 * 1787913911) ^ -1760167329;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 935505085;
							num4 = 935505085;
						}
						else
						{
							num3 = 1132163651;
							num4 = 1132163651;
						}
						num = num3 ^ ((int)num2 * -96535790);
						continue;
					}
					case 0u:
						result2 = result;
						num = (int)((num2 * 1117397614) ^ 0x76D24709);
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
				int num = 143282101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63DE7A85u) % 3u)
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
					num = (int)((num2 * 1346157265) ^ 0x2EF62A83);
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
				int num = 590659093;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D935A4Cu) % 8u)
					{
					case 7u:
						num = ((int)num2 * -657510209) ^ 0x4446365E;
						continue;
					case 6u:
						num = ((int)num2 * -1285357226) ^ -1071928325;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = 1506685272;
							num4 = 1506685272;
						}
						else
						{
							num3 = 866440102;
							num4 = 866440102;
						}
						num = num3 ^ (int)(num2 * 1877169312);
						continue;
					}
					case 4u:
						result = !JSONNode.smethod_1(Value);
						num = 695563890;
						continue;
					case 2u:
						result = result2;
						num = (int)((num2 * 1867280515) ^ 0x3639F5DD);
						continue;
					case 1u:
						result2 = false;
						num = (int)((num2 * 190314886) ^ 0x706AAE87);
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
			Value = (value ? "true" : "false");
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = this as JSONArray;
			while (true)
			{
				int num = -705328188;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81FF3F54u) % 3u)
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
					num = (int)((num2 * 1291316787) ^ 0x3A037567);
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
			int num = -1220828372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE016466Cu) % 3u)
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
				num = (int)((num2 * 1408846608) ^ 0x35645EC4);
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
			int num = 2035757496;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47020481u) % 3u)
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
				num = (int)(num2 * 1066181115) ^ -860647834;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 59954228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EC159BBu) % 4u)
				{
				case 3u:
					result = aNode;
					num = (int)((num2 * 1472395902) ^ 0x3933CAE4);
					continue;
				case 1u:
					num = (int)((num2 * 1437521542) ^ 0x73718CFB);
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
			int num = 1623839866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A15EC9u) % 3u)
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
				num = ((int)num2 * -1472809172) ^ -584323451;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1798873126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5FA68A57u) % 4u)
				{
				case 1u:
					result = new JSONData(s);
					num = ((int)num2 * -867196489) ^ 0x7EA7A4EC;
					continue;
				case 0u:
					num = (int)(num2 * 158480090) ^ -1680216760;
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

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 1891809848;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x4C4739E6u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1406965854) ^ -74127851;
					continue;
				case 3u:
					obj = d.Value;
					goto IL_0018;
				case 1u:
					if (!(d == null))
					{
						num = (int)((num2 * 17656415) ^ 0x48173DFB);
						continue;
					}
					obj = null;
					goto IL_0018;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0018:
					result = (string)obj;
					num = 607125368;
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
			goto IL_001f;
		}
		goto IL_0078;
		IL_001f:
		int num = 1740709405;
		goto IL_0044;
		IL_0044:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1FA0D4FEu) % 6u)
			{
			case 5u:
				result = (object)a == b;
				num = 111930914;
				continue;
			case 4u:
				break;
			case 3u:
				result = true;
				num = (int)(num2 * 768971488) ^ -2087006370;
				continue;
			case 0u:
				num = (int)(num2 * 1478684417) ^ -875271134;
				continue;
			case 1u:
				goto IL_006d;
			default:
				return result;
			}
			break;
			IL_006d:
			if (a is JSONLazyCreator)
			{
				num = 922128069;
				num3 = 922128069;
				continue;
			}
			goto IL_0078;
		}
		goto IL_001f;
		IL_0078:
		num = 614406931;
		num3 = 614406931;
		goto IL_0044;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = 302707776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x282F92u) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1976256223) ^ 0xF05D807;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 354633654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2165E5E1u) % 3u)
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
				result = (object)this == obj;
				num = ((int)num2 * -910716872) ^ -789306953;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -803054173;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD1287BFu) % 3u)
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
				num = ((int)num2 * -1205303579) ^ -1825083424;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = "";
		char c2 = default(char);
		int num4 = default(int);
		string string_ = default(string);
		char c = default(char);
		string result = default(string);
		char c3 = default(char);
		while (true)
		{
			int num = -1515413439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE5D784Du) % 29u)
				{
				case 28u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -322157864;
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -322157864;
					continue;
				case 26u:
					goto IL_0039;
				case 25u:
					goto IL_004f;
				case 23u:
				{
					int num6;
					if (num4 < JSONNode.smethod_4(string_))
					{
						num = -1603257252;
						num6 = -1603257252;
					}
					else
					{
						num = -1433193259;
						num6 = -1433193259;
					}
					continue;
				}
				case 22u:
				{
					int num5;
					if (c == '\\')
					{
						num = -494688002;
						num5 = -494688002;
					}
					else
					{
						num = -513773886;
						num5 = -513773886;
					}
					continue;
				}
				case 21u:
					string_ = aText;
					num = ((int)num2 * -627183139) ^ -1059471254;
					continue;
				case 20u:
					num = ((int)num2 * -1852007131) ^ -1103421407;
					continue;
				case 19u:
					num = ((int)num2 * -1844024374) ^ -1164166406;
					continue;
				case 18u:
					result = text;
					num = ((int)num2 * -1267649121) ^ -450055283;
					continue;
				case 17u:
					goto IL_00fd;
				case 16u:
					num = (int)((num2 * 280181199) ^ 0x43BABC25);
					continue;
				case 15u:
					num = -659220492;
					continue;
				case 14u:
					num4++;
					num = ((int)num2 * -1163129828) ^ -1605246092;
					continue;
				case 13u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = -1578092453;
					continue;
				case 12u:
					num = ((int)num2 * -2109081830) ^ 0x5A6D09B2;
					continue;
				case 11u:
					goto IL_016c;
				case 10u:
					c3 = c2;
					num = ((int)num2 * -519484124) ^ 0x1660ABE5;
					continue;
				case 9u:
					switch (c)
					{
					case '\v':
						break;
					case '\n':
						goto IL_0039;
					case '\f':
						goto IL_004f;
					case '\b':
						goto IL_00fd;
					case '\r':
						goto IL_016c;
					default:
						goto IL_01b9;
					case '\t':
						goto IL_01cc;
					}
					goto case 27u;
				case 1u:
					goto IL_01cc;
				case 8u:
					num4 = 0;
					num = ((int)num2 * -962440607) ^ 0x6F3C865A;
					continue;
				case 7u:
					num = (int)((num2 * 1386305300) ^ 0x83FD2FC);
					continue;
				case 6u:
					c = c3;
					num = ((int)num2 * -1357197840) ^ 0x5113419A;
					continue;
				case 5u:
					num = ((int)num2 * -1310030188) ^ 0x34C2AA0F;
					continue;
				case 4u:
				{
					int num3;
					if (c == '"')
					{
						num = -1303700309;
						num3 = -1303700309;
					}
					else
					{
						num = -1713838065;
						num3 = -1713838065;
					}
					continue;
				}
				case 3u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -322157864;
					continue;
				case 2u:
					num = ((int)num2 * -14284206) ^ -1278556507;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_01cc:
					text = JSONNode.smethod_3(text, "\\t");
					num = -322157864;
					continue;
					IL_01b9:
					num = (int)((num2 * 1527405800) ^ 0x44285036);
					continue;
					IL_016c:
					text = JSONNode.smethod_3(text, "\\r");
					num = -322157864;
					continue;
					IL_00fd:
					text = JSONNode.smethod_3(text, "\\b");
					num = -699020156;
					continue;
					IL_004f:
					text = JSONNode.smethod_3(text, "\\f");
					num = -322157864;
					continue;
					IL_0039:
					text = JSONNode.smethod_3(text, "\\n");
					num = -322157864;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		char c2 = default(char);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag11 = default(bool);
		bool flag2 = default(bool);
		string text = default(string);
		string text2 = default(string);
		char c = default(char);
		bool flag12 = default(bool);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		bool flag10 = default(bool);
		bool flag13 = default(bool);
		int num5 = default(int);
		bool flag8 = default(bool);
		bool flag5 = default(bool);
		bool flag15 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag14 = default(bool);
		char c5 = default(char);
		bool flag = default(bool);
		bool flag3 = default(bool);
		char c4 = default(char);
		bool flag9 = default(bool);
		string s = default(string);
		while (true)
		{
			int num = -627309300;
			while (true)
			{
				uint num2;
				int num58;
				switch ((num2 = (uint)num ^ 0xC919B3ABu) % 159u)
				{
				case 158u:
					num = (int)((num2 * 1655171921) ^ 0x60921E78);
					continue;
				case 157u:
				{
					int num38;
					if (c2 != 'n')
					{
						num = -491792680;
						num38 = -491792680;
					}
					else
					{
						num = -553316663;
						num38 = -553316663;
					}
					continue;
				}
				case 156u:
					num = ((int)num2 * -1856960647) ^ 0x20DC9F71;
					continue;
				case 155u:
					jSONNode = null;
					num = (int)(num2 * 1175164112) ^ -612602060;
					continue;
				case 154u:
					num = -696032145;
					continue;
				case 153u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -922327134) ^ 0x1247F87E;
					continue;
				case 152u:
					flag11 = flag2;
					num = -1664112542;
					continue;
				case 151u:
					text = "";
					num = -225964175;
					continue;
				case 150u:
					num = -277044348;
					continue;
				case 149u:
					text2 = "";
					num = ((int)num2 * -1371108855) ^ -430758100;
					continue;
				case 148u:
					num = (int)((num2 * 1606636767) ^ 0x5EB54529);
					continue;
				case 147u:
					num = (int)((num2 * 1900374519) ^ 0x447B7F14);
					continue;
				case 146u:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -1897446837;
					continue;
				case 145u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -639970602;
					continue;
				case 144u:
					num = ((int)num2 * -1858090222) ^ 0x7B40DD17;
					continue;
				case 143u:
				{
					int num36;
					int num37;
					if (c == ':')
					{
						num36 = 596680958;
						num37 = 596680958;
					}
					else
					{
						num36 = 249383506;
						num37 = 249383506;
					}
					num = num36 ^ ((int)num2 * -1415557657);
					continue;
				}
				case 142u:
				{
					int num26;
					int num27;
					if (!flag12)
					{
						num26 = 76954660;
						num27 = 76954660;
					}
					else
					{
						num26 = 919180319;
						num27 = 919180319;
					}
					num = num26 ^ ((int)num2 * -514317087);
					continue;
				}
				case 141u:
					num = ((int)num2 * -1388691071) ^ -930677369;
					continue;
				case 140u:
					num = -254720014;
					continue;
				case 139u:
				{
					int num17;
					if ((uint)c <= 93u)
					{
						num = -1801849778;
						num17 = -1801849778;
					}
					else
					{
						num = -2103495448;
						num17 = -2103495448;
					}
					continue;
				}
				case 138u:
					num = ((int)num2 * -1470784033) ^ 0x1F10A599;
					continue;
				case 137u:
					text = JSONNode.smethod_5(text);
					flag7 = jSONNode is JSONArray;
					num = ((int)num2 * -2028729140) ^ -227858040;
					continue;
				case 136u:
					num = (int)((num2 * 547269137) ^ 0x43713AF);
					continue;
				case 135u:
					num = (int)((num2 * 49202107) ^ 0x41F54874);
					continue;
				case 134u:
					flag4 = JSONNode.smethod_6(text, "");
					num = -672450815;
					continue;
				case 133u:
					stack.Push(new JSONArray());
					num = -680860566;
					continue;
				case 132u:
					flag6 = jSONNode is JSONArray;
					num = (int)((num2 * 1971728371) ^ 0x566F417E);
					continue;
				case 131u:
					flag10 = JSONNode.smethod_6(text, "");
					num = -1085931436;
					continue;
				case 130u:
				{
					int num55;
					if (c == ',')
					{
						num = -1518860985;
						num55 = -1518860985;
					}
					else
					{
						num = -824861726;
						num55 = -824861726;
					}
					continue;
				}
				case 129u:
					num = ((int)num2 * -1254415212) ^ 0xDCFB976;
					continue;
				case 128u:
					flag13 = flag2;
					num = -1306405030;
					continue;
				case 127u:
					num = -1657953741;
					continue;
				case 126u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1709162225) ^ -1507207105;
					continue;
				case 125u:
				{
					int num48;
					int num49;
					if ((uint)c2 > 102u)
					{
						num48 = -846981862;
						num49 = -846981862;
					}
					else
					{
						num48 = -2097922394;
						num49 = -2097922394;
					}
					num = num48 ^ ((int)num2 * -973397375);
					continue;
				}
				case 124u:
				{
					int num45;
					if (!flag2)
					{
						num = -956249470;
						num45 = -956249470;
					}
					else
					{
						num = -7525002;
						num45 = -7525002;
					}
					continue;
				}
				case 123u:
				{
					int num42;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -83057118;
						num42 = -83057118;
					}
					else
					{
						num = -1657953741;
						num42 = -1657953741;
					}
					continue;
				}
				case 122u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -1897446837;
					continue;
				case 121u:
					num = -2125812920;
					continue;
				case 120u:
				{
					int num39;
					if (c == '}')
					{
						num = -2140389219;
						num39 = -2140389219;
					}
					else
					{
						num = -1659452455;
						num39 = -1659452455;
					}
					continue;
				}
				case 119u:
				{
					int num30;
					int num31;
					if (!flag8)
					{
						num30 = -275444496;
						num31 = -275444496;
					}
					else
					{
						num30 = -1195572654;
						num31 = -1195572654;
					}
					num = num30 ^ (int)(num2 * 1231925937);
					continue;
				}
				case 118u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -297385728) ^ -1065366535;
					continue;
				case 117u:
					num = (int)(num2 * 1275335876) ^ -159246892;
					continue;
				case 116u:
					num = ((int)num2 * -1726635588) ^ -1327858104;
					continue;
				case 115u:
					num = (int)((num2 * 1226030032) ^ 0x5E196B1C);
					continue;
				case 114u:
				{
					int num23;
					if (!flag2)
					{
						num = -1890944859;
						num23 = -1890944859;
					}
					else
					{
						num = -447581587;
						num23 = -447581587;
					}
					continue;
				}
				case 113u:
				{
					int num20;
					if (num5 < JSONNode.smethod_4(aJSON))
					{
						num = -93014973;
						num20 = -93014973;
					}
					else
					{
						num = -24780945;
						num20 = -24780945;
					}
					continue;
				}
				case 112u:
				{
					int num15;
					int num16;
					if (!flag5)
					{
						num15 = -972103865;
						num16 = -972103865;
					}
					else
					{
						num15 = -115348584;
						num16 = -115348584;
					}
					num = num15 ^ (int)(num2 * 1964686172);
					continue;
				}
				case 111u:
					num = ((int)num2 * -29867884) ^ -1369459844;
					continue;
				case 110u:
					num = ((int)num2 * -1691418109) ^ -1869301342;
					continue;
				case 109u:
					num = ((int)num2 * -681979485) ^ 0x5232D6AD;
					continue;
				case 108u:
					flag8 = jSONNode != null;
					num = (int)((num2 * 198427670) ^ 0x577590A5);
					continue;
				case 107u:
					num = ((int)num2 * -1999537486) ^ 0x226CFB5F;
					continue;
				case 106u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = -413065077;
						num8 = -413065077;
					}
					else
					{
						num7 = -952043091;
						num8 = -952043091;
					}
					num = num7 ^ (int)(num2 * 291880554);
					continue;
				}
				case 8u:
				case 43u:
				case 51u:
				case 92u:
				case 105u:
					goto IL_0533;
				case 104u:
					switch (c)
					{
					case '[':
						break;
					default:
						goto IL_0557;
					case '\\':
						goto IL_0561;
					case ']':
						goto IL_0573;
					}
					goto case 128u;
				case 64u:
					goto IL_0561;
				case 25u:
					goto IL_0573;
				case 103u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -1897446837;
					continue;
				case 102u:
					num = (int)(num2 * 2098022834) ^ -366245275;
					continue;
				case 101u:
					goto IL_05bc;
				case 100u:
					jSONNode.Add(text2);
					num = ((int)num2 * -545064449) ^ -694962809;
					continue;
				case 99u:
					text = text2;
					num = -900238316;
					continue;
				case 97u:
					num = ((int)num2 * -2036175662) ^ -1033374015;
					continue;
				case 96u:
					num = ((int)num2 * -1987062419) ^ -145448351;
					continue;
				case 94u:
					flag15 = JSONNode.smethod_6(text, "");
					num = -1548787755;
					continue;
				case 93u:
					text2 = "";
					num = ((int)num2 * -1114020336) ^ 0x3D1EC6E7;
					continue;
				case 91u:
					text = "";
					text2 = "";
					num = -558745626;
					continue;
				case 90u:
				{
					int num56;
					int num57;
					if (flag7)
					{
						num56 = 1281357650;
						num57 = 1281357650;
					}
					else
					{
						num56 = 1323616218;
						num57 = 1323616218;
					}
					num = num56 ^ ((int)num2 * -1509155653);
					continue;
				}
				case 89u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -2075987522) ^ 0x792CAD82;
					continue;
				case 88u:
					num = ((int)num2 * -781713920) ^ 0x25FACAA0;
					continue;
				case 87u:
					result = jSONNode;
					num = -1787507691;
					continue;
				case 86u:
					num = ((int)num2 * -883439026) ^ -1237318708;
					continue;
				case 85u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -230589793) ^ -840806781;
					continue;
				case 84u:
				{
					int num53;
					int num54;
					if (!flag14)
					{
						num53 = 2042107889;
						num54 = 2042107889;
					}
					else
					{
						num53 = 1487717193;
						num54 = 1487717193;
					}
					num = num53 ^ (int)(num2 * 305965327);
					continue;
				}
				case 83u:
					goto IL_0737;
				case 82u:
					c2 = c5;
					num = ((int)num2 * -1056350203) ^ 0x3F4E3C53;
					continue;
				case 81u:
				{
					int num52;
					if (c == '{')
					{
						num = -2067965878;
						num52 = -2067965878;
					}
					else
					{
						num = -1068610801;
						num52 = -1068610801;
					}
					continue;
				}
				case 80u:
					num = ((int)num2 * -704104045) ^ 0x1A5FDD00;
					continue;
				case 79u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1822811370) ^ -16905289;
					continue;
				case 78u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -2032479409) ^ 0x2733178;
					continue;
				case 77u:
				{
					int num50;
					int num51;
					if (!flag15)
					{
						num50 = 1708467899;
						num51 = 1708467899;
					}
					else
					{
						num50 = 2093832044;
						num51 = 2093832044;
					}
					num = num50 ^ (int)(num2 * 1509143084);
					continue;
				}
				case 76u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1580709967) ^ -2054651110;
					continue;
				case 75u:
					goto IL_0827;
				case 74u:
				{
					int num46;
					int num47;
					if (flag)
					{
						num46 = 170446839;
						num47 = 170446839;
					}
					else
					{
						num46 = 1297646977;
						num47 = 1297646977;
					}
					num = num46 ^ (int)(num2 * 1852666602);
					continue;
				}
				case 73u:
					flag14 = jSONNode is JSONArray;
					num = (int)(num2 * 2094384362) ^ -1364933975;
					continue;
				case 72u:
					num = (int)(num2 * 1161557088) ^ -470194706;
					continue;
				case 71u:
					stack.Push(new JSONClass());
					flag12 = jSONNode != null;
					num = -620019701;
					continue;
				case 70u:
				{
					int num43;
					int num44;
					if (flag13)
					{
						num43 = 259856909;
						num44 = 259856909;
					}
					else
					{
						num43 = 1104774980;
						num44 = 1104774980;
					}
					num = num43 ^ (int)(num2 * 52310030);
					continue;
				}
				case 69u:
				{
					int num41;
					if (c != '"')
					{
						num = -1907402072;
						num41 = -1907402072;
					}
					else
					{
						num = -569137750;
						num41 = -569137750;
					}
					continue;
				}
				case 68u:
				{
					int num40;
					if (flag2)
					{
						num = -71794606;
						num40 = -71794606;
					}
					else
					{
						num = -160909302;
						num40 = -160909302;
					}
					continue;
				}
				case 67u:
					text2 = "";
					num = (int)((num2 * 1695753479) ^ 0x4D59217D);
					continue;
				case 65u:
					num = ((int)num2 * -554190121) ^ 0x68049AC2;
					continue;
				case 63u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 14825509) ^ 0x7180307);
					continue;
				case 61u:
					num = (int)(num2 * 572380029) ^ -173809725;
					continue;
				case 60u:
					jSONNode.Add(text2);
					num = (int)(num2 * 1293704640) ^ -550324682;
					continue;
				case 59u:
				{
					int num34;
					int num35;
					if (!flag11)
					{
						num34 = -409957468;
						num35 = -409957468;
					}
					else
					{
						num34 = -38291258;
						num35 = -38291258;
					}
					num = num34 ^ ((int)num2 * -456620238);
					continue;
				}
				case 58u:
				{
					int num32;
					int num33;
					if (!flag3)
					{
						num32 = 1054429333;
						num33 = 1054429333;
					}
					else
					{
						num32 = 456252003;
						num33 = 456252003;
					}
					num = num32 ^ ((int)num2 * -1056965825);
					continue;
				}
				case 57u:
					num = ((int)num2 * -728626023) ^ 0x2C1CA901;
					continue;
				case 56u:
					text = "";
					num = -1375517312;
					continue;
				case 55u:
					text2 = "";
					num = ((int)num2 * -48991693) ^ -376965903;
					continue;
				case 54u:
					text2 = "";
					text = "";
					num = ((int)num2 * -1402952356) ^ 0xEF77346;
					continue;
				case 53u:
					num5 = 0;
					num = (int)((num2 * 1191782583) ^ 0x215DD754);
					continue;
				case 52u:
				{
					int num28;
					int num29;
					if (c2 != 'b')
					{
						num28 = -1836706224;
						num29 = -1836706224;
					}
					else
					{
						num28 = -1863250814;
						num29 = -1863250814;
					}
					num = num28 ^ ((int)num2 * -1177177846);
					continue;
				}
				case 50u:
					num = (int)((num2 * 1306226226) ^ 0x3F0CF975);
					continue;
				case 49u:
					c4 = JSONNode.smethod_2(aJSON, num5);
					num = ((int)num2 * -373345759) ^ -1735196266;
					continue;
				case 48u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1177466927) ^ 0x6B54FB81);
					continue;
				case 47u:
					text = "";
					num = -97766500;
					continue;
				case 46u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -566822322) ^ -969649654;
					continue;
				case 45u:
					num = ((int)num2 * -138266810) ^ -1058951475;
					continue;
				case 44u:
				{
					int num24;
					int num25;
					if (flag9)
					{
						num24 = -1122630153;
						num25 = -1122630153;
					}
					else
					{
						num24 = -1322021144;
						num25 = -1322021144;
					}
					num = num24 ^ ((int)num2 * -1009453720);
					continue;
				}
				case 42u:
				{
					int num22;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -1949335733;
						num22 = -1949335733;
					}
					else
					{
						num = -2068275594;
						num22 = -2068275594;
					}
					continue;
				}
				case 41u:
					num = (int)(num2 * 418384674) ^ -221124082;
					continue;
				case 40u:
					switch (c2)
					{
					case 'r':
						break;
					case 't':
						goto IL_0737;
					case 's':
						goto IL_0827;
					default:
						goto IL_0b99;
					case 'u':
						goto IL_0ba3;
					}
					goto case 146u;
				case 4u:
					goto IL_0ba3;
				case 39u:
					num = ((int)num2 * -1680394825) ^ 0x459D0DDF;
					continue;
				case 38u:
					num = ((int)num2 * -1999075369) ^ 0xCC63914;
					continue;
				case 37u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num5 += 4;
					num = ((int)num2 * -624873225) ^ 0x6C3B989E;
					continue;
				case 36u:
					num = ((int)num2 * -1739360124) ^ 0xBEDBCD8;
					continue;
				case 35u:
					num = ((int)num2 * -586920434) ^ 0x41E0896F;
					continue;
				case 34u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -878288584) ^ -530173300;
					continue;
				case 33u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 996436124) ^ 0x6ED73835);
					continue;
				case 32u:
					c5 = c4;
					num = (int)(num2 * 2142150916) ^ -1674439436;
					continue;
				case 31u:
					num = ((int)num2 * -1522716621) ^ 0x64F77ADC;
					continue;
				case 30u:
				{
					int num21;
					if (stack.Count == 0)
					{
						num = -1874156929;
						num21 = -1874156929;
					}
					else
					{
						num = -1333122388;
						num21 = -1333122388;
					}
					continue;
				}
				case 29u:
				{
					int num18;
					int num19;
					if (!flag10)
					{
						num18 = 1200217973;
						num19 = 1200217973;
					}
					else
					{
						num18 = 2070290396;
						num19 = 2070290396;
					}
					num = num18 ^ (int)(num2 * 1110340421);
					continue;
				}
				case 28u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1897466528) ^ -281827172;
					continue;
				case 27u:
					num = ((int)num2 * -991788922) ^ -1466786367;
					continue;
				case 26u:
					stack.Pop();
					num = -876876571;
					continue;
				case 24u:
				{
					int num14;
					if (c == ' ')
					{
						num = -2051642163;
						num14 = -2051642163;
					}
					else
					{
						num = -647300142;
						num14 = -647300142;
					}
					continue;
				}
				case 23u:
					switch (c)
					{
					case '\t':
						break;
					case '\n':
					case '\r':
						goto IL_0533;
					case '\v':
					case '\f':
						goto IL_05bc;
					default:
						goto IL_0d8c;
					}
					goto case 114u;
				case 22u:
					flag9 = JSONNode.smethod_6(text2, "");
					num = (int)(num2 * 174177145) ^ -720624527;
					continue;
				case 21u:
					num = (int)((num2 * 1320953717) ^ 0x70A683B0);
					continue;
				case 20u:
					num = (int)((num2 * 1137577047) ^ 0x61570DDB);
					continue;
				case 19u:
					num = (int)((num2 * 579431176) ^ 0x747369C2);
					continue;
				case 18u:
					num = (int)(num2 * 1790132021) ^ -1179136971;
					continue;
				case 17u:
					flag2 = false;
					num = ((int)num2 * -26018604) ^ 0x671A98FF;
					continue;
				case 16u:
					num = (int)(num2 * 658081829) ^ -1995831574;
					continue;
				case 15u:
				{
					char c3 = JSONNode.smethod_2(aJSON, num5);
					c = c3;
					int num13;
					if ((uint)c > 44u)
					{
						num = -890820292;
						num13 = -890820292;
					}
					else
					{
						num = -1289954342;
						num13 = -1289954342;
					}
					continue;
				}
				case 14u:
				{
					int num11;
					int num12;
					if (!flag2)
					{
						num11 = 2067075090;
						num12 = 2067075090;
					}
					else
					{
						num11 = 1678790242;
						num12 = 1678790242;
					}
					num = num11 ^ ((int)num2 * -160917945);
					continue;
				}
				case 13u:
				{
					int num9;
					int num10;
					if (!flag6)
					{
						num9 = 1041006979;
						num10 = 1041006979;
					}
					else
					{
						num9 = 753930504;
						num10 = 753930504;
					}
					num = num9 ^ (int)(num2 * 807474287);
					continue;
				}
				case 12u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1885819070) ^ -1646752030;
					continue;
				case 11u:
					flag2 = !flag2;
					num = -94114261;
					continue;
				case 10u:
				{
					int num6;
					if (c2 == 'f')
					{
						num = -1726381410;
						num6 = -1726381410;
					}
					else
					{
						num = -961313853;
						num6 = -961313853;
					}
					continue;
				}
				case 9u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -1595822440) ^ -783019775;
					continue;
				case 7u:
					num = ((int)num2 * -190143869) ^ 0x48C3D032;
					continue;
				case 6u:
					num = (int)((num2 * 216162709) ^ 0x4069E914);
					continue;
				case 5u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 260583427) ^ 0x121D574E);
					continue;
				case 3u:
					flag5 = jSONNode is JSONArray;
					num = ((int)num2 * -962180044) ^ -1399430388;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if ((uint)c <= 32u)
					{
						num3 = 1789032387;
						num4 = 1789032387;
					}
					else
					{
						num3 = 1984273785;
						num4 = 1984273785;
					}
					num = num3 ^ (int)(num2 * 1662246269);
					continue;
				}
				case 1u:
					flag = stack.Count > 0;
					num = ((int)num2 * -1067083688) ^ 0x2D5CBD1F;
					continue;
				case 0u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 342335086) ^ -1939476843;
					continue;
				case 66u:
					break;
				case 95u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 98u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0561:
					num5++;
					flag3 = flag2;
					num = -1261863635;
					continue;
					IL_0557:
					num = -428621044;
					continue;
					IL_0533:
					num5++;
					num = -793309767;
					continue;
					IL_0d8c:
					num = ((int)num2 * -651679227) ^ 0x1D6B0D8F;
					continue;
					IL_0ba3:
					s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					num = -311192859;
					continue;
					IL_0b99:
					num = -1204687558;
					continue;
					IL_0827:
					text2 = JSONNode.smethod_3(text2, c4.ToString());
					num = -1993296607;
					continue;
					IL_0737:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -1897446837;
					continue;
					IL_05bc:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = -1140877437;
					continue;
					IL_0573:
					if (!flag2)
					{
						num = -335358092;
						num58 = -335358092;
					}
					else
					{
						num = -420485909;
						num58 = -420485909;
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
			int num = -757241397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x889008E8u) % 3u)
				{
				case 2u:
					goto IL_0010;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0010:
				num = ((int)num2 * -2034333541) ^ -659946754;
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
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_006e:
					int num = 1699093458;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x1B82088Fu) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 1360805265) ^ 0x43FB0112);
							continue;
						case 0u:
							num = (int)((num2 * 418423142) ^ 0x4ADC1171);
							continue;
						default:
							goto end_IL_004d;
						case 3u:
							break;
						case 2u:
							goto end_IL_004d;
						}
						goto IL_006e;
						continue;
						end_IL_004d:
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
				int num = -674041622;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9A78B68Bu) % 4u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -850287981) ^ 0x4A5744CC;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1437408724) ^ -576237412;
						continue;
					case 0u:
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
					int num3 = -267002642;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x9A78B68Bu) % 4u)
						{
						case 3u:
							num3 = ((int)num2 * -738239936) ^ 0x4D04B13F;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 947565366) ^ 0x6B6E4EA);
							continue;
						default:
							goto end_IL_0098;
						case 2u:
							break;
						case 0u:
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
		bool flag = default(bool);
		int num5 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		JSONClass jSONClass = default(JSONClass);
		JSONNode result = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		while (true)
		{
			int num = 136714436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x656F6D46u) % 32u)
				{
				case 30u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -450675637;
						num9 = -450675637;
					}
					else
					{
						num8 = -1548579249;
						num9 = -1548579249;
					}
					num = num8 ^ ((int)num2 * -1164742035);
					continue;
				}
				case 29u:
					num = 1898329535;
					continue;
				case 28u:
					num = 367688167;
					continue;
				case 27u:
					num = ((int)num2 * -12311941) ^ 0x5DDBFBE2;
					continue;
				case 26u:
					num = ((int)num2 * -1215654746) ^ 0x28267A8E;
					continue;
				case 24u:
					num = ((int)num2 * -1204691335) ^ 0x23E53249;
					continue;
				case 23u:
				{
					int num7;
					if (num5 >= num6)
					{
						num = 217557132;
						num7 = 217557132;
					}
					else
					{
						num = 1233182798;
						num7 = 1233182798;
					}
					continue;
				}
				case 22u:
					flag = num4 < num3;
					num = 1634343448;
					continue;
				case 21u:
					goto IL_00b1;
				case 19u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 753537633) ^ -1843166885;
					continue;
				}
				case 18u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -316057772) ^ 0x34EED743;
					continue;
				case 17u:
					goto IL_0109;
				case 16u:
					num = (int)(num2 * 2035190398) ^ -1013305998;
					continue;
				case 15u:
					result = jSONArray;
					num = (int)(num2 * 858289587) ^ -1004904725;
					continue;
				case 14u:
					num = (int)((num2 * 1575095602) ^ 0x59190CDE);
					continue;
				case 13u:
					num = (int)((num2 * 1075962921) ^ 0x2A7A8AE7);
					continue;
				case 12u:
					goto IL_0170;
				case 11u:
					jSONArray.Add(Deserialize(aReader));
					num4++;
					num = 1567723952;
					continue;
				case 10u:
					result = jSONClass;
					num = (int)((num2 * 1670578240) ^ 0x16824D92);
					continue;
				case 9u:
					goto IL_01b6;
				case 8u:
					num = 2101610805;
					continue;
				case 7u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 1308580434) ^ 0x64652D02);
					continue;
				case 6u:
					jSONClass = new JSONClass();
					num5 = 0;
					num = ((int)num2 * -2016501319) ^ -703872312;
					continue;
				case 5u:
					goto IL_0214;
				case 4u:
					num5++;
					num = (int)((num2 * 1275420569) ^ 0x5D52A335);
					continue;
				case 3u:
					goto IL_0237;
				case 2u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					switch (jSONBinaryTag)
					{
					case JSONBinaryTag.Array:
						break;
					case JSONBinaryTag.FloatValue:
						goto IL_00b1;
					case JSONBinaryTag.IntValue:
						goto IL_0109;
					case JSONBinaryTag.Class:
						goto IL_0170;
					case JSONBinaryTag.Value:
						goto IL_01b6;
					case JSONBinaryTag.BoolValue:
						goto IL_0214;
					case JSONBinaryTag.DoubleValue:
						goto IL_0237;
					default:
						goto IL_027a;
					}
					goto case 28u;
				case 1u:
					num3 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num4 = 0;
					num = ((int)num2 * -16340944) ^ 0x14321780;
					continue;
				case 0u:
					num = (int)(num2 * 1125151830) ^ -88391854;
					continue;
				case 31u:
					break;
				case 25u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_027a:
					num = (int)((num2 * 882796845) ^ 0x1F967947);
					continue;
					IL_0237:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 2061040934;
					continue;
					IL_0214:
					num = 1530777748;
					continue;
					IL_01b6:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 28131090;
					continue;
					IL_0170:
					num6 = JSONNode.smethod_21(aReader);
					num = 1887589024;
					continue;
					IL_0109:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = 28131090;
					continue;
					IL_00b1:
					num = 474903649;
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
				int num = 1435700045;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x697C9991u) % 3u)
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
					num = ((int)num2 * -1073956815) ^ -489042146;
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
					int num3 = 1029990191;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x697C9991u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)(num2 * 527329859) ^ -97541966;
							continue;
						case 1u:
							num3 = ((int)num2 * -120370944) ^ -962589571;
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
					int num = 1548089837;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x29FF4AC0u) % 4u)
						{
						case 3u:
							num = (int)((num2 * 1319957910) ^ 0x4F4C8CA0);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 450660503) ^ 0x5406FD34);
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = -2024800210;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD328BF74u) % 7u)
				{
				case 5u:
					num = (int)(num2 * 1335180647) ^ -635026779;
					continue;
				case 4u:
					num = (int)((num2 * 2000416388) ^ 0x4A4CEEE9);
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1808485985) ^ 0x2CD808C6;
					continue;
				case 2u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1557405719) ^ 0x5BBAD6A4;
					continue;
				}
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -775666106) ^ -686192256;
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
