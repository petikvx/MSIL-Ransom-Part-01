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
				int num = 125978189;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x69670A21u) % 3u)
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
					num = (int)(num2 * 1635617037) ^ -701662244;
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
				int num = -676498952;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xADDDEB5Du) % 3u)
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
					num = (int)((num2 * 1588096640) ^ 0x50A9A5A2);
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
				int num = 808085384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30112189u) % 3u)
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
					num = ((int)num2 * -1743536592) ^ -1082166275;
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
				int num = -1605006927;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x867CF050u) % 4u)
					{
					case 1u:
						result = 0;
						num = (int)((num2 * 834502547) ^ 0x5A86DA7F);
						continue;
					case 0u:
						num = (int)((num2 * 925840235) ^ 0x69C24507);
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
			_003Cget_Childs_003Ed__17 _003Cget_Childs_003Ed__ = new _003Cget_Childs_003Ed__17(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -2124131372;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD746900Bu) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1788838696) ^ 0x4181C081;
						continue;
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1766303339) ^ 0x7B5355B0;
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

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			while (true)
			{
				int num = 379192344;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55F64AB7u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_DeepChilds_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					num = (int)((num2 * 1813353652) ^ 0x393AA699);
				}
			}
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
				int num = -525886962;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB53E32AFu) % 8u)
					{
					case 7u:
						result = 0;
						num = -1143443926;
						continue;
					case 6u:
						num = (int)(num2 * 189431235) ^ -1501937744;
						continue;
					case 4u:
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 1961488687) ^ 0x52E91858);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1089194740;
							num4 = -1089194740;
						}
						else
						{
							num3 = -272113183;
							num4 = -272113183;
						}
						num = num3 ^ ((int)num2 * -540797597);
						continue;
					}
					case 2u:
						result = result2;
						num = ((int)num2 * -1587187519) ^ -276299429;
						continue;
					case 1u:
						result2 = 0;
						num = ((int)num2 * -1138937112) ^ 0x50D78D2B;
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
			while (true)
			{
				int num = -947402309;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD49AEAE6u) % 3u)
					{
					case 2u:
						goto IL_000f;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_000f:
					num = (int)(num2 * 1871699306) ^ -2122232717;
				}
			}
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
				int num = -1811660711;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEAC0F168u) % 9u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1725373789;
							num4 = 1725373789;
						}
						else
						{
							num3 = 983959538;
							num4 = 983959538;
						}
						num = num3 ^ (int)(num2 * 279687179);
						continue;
					}
					case 5u:
						result2 = 0f;
						num = (int)((num2 * 1791861571) ^ 0x460A8312);
						continue;
					case 4u:
						result = 0f;
						num = -310602284;
						continue;
					case 3u:
						num = ((int)num2 * -1265335391) ^ 0x1902998F;
						continue;
					case 2u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -261258091) ^ 0x7B187903;
						continue;
					case 1u:
						num = ((int)num2 * -1490968023) ^ 0x3528E228;
						continue;
					case 0u:
						result = result2;
						num = (int)(num2 * 1411411720) ^ -1749194893;
						continue;
					case 6u:
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
				int num = 908204911;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13DBDA8u) % 3u)
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
					num = ((int)num2 * -1854724854) ^ 0x1AB77068;
				}
			}
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
				int num = -2119035429;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEC9DBCB1u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = 820247844;
							num4 = 820247844;
						}
						else
						{
							num3 = 1387085708;
							num4 = 1387085708;
						}
						num = num3 ^ ((int)num2 * -637741371);
						continue;
					}
					case 5u:
						result2 = 0.0;
						num = ((int)num2 * -1956419220) ^ 0x1E0C9862;
						continue;
					case 3u:
						result = result2;
						num = (int)(num2 * 1423378255) ^ -1286478985;
						continue;
					case 2u:
						result = 0.0;
						num = -369817668;
						continue;
					case 1u:
						num = (int)(num2 * 521841967) ^ -600463710;
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

	public virtual bool AsBool
	{
		get
		{
			bool result = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -1473474316;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF380AFB6u) % 6u)
					{
					case 5u:
						result = !JSONNode.smethod_1(Value);
						num = -1238379497;
						continue;
					case 3u:
						num = ((int)num2 * -921026909) ^ 0x1245D771;
						continue;
					case 2u:
					{
						result2 = false;
						int num3;
						int num4;
						if (bool.TryParse(Value, out result2))
						{
							num3 = 910181185;
							num4 = 910181185;
						}
						else
						{
							num3 = 1835498467;
							num4 = 1835498467;
						}
						num = num3 ^ ((int)num2 * -105500967);
						continue;
					}
					case 1u:
						result = result2;
						num = (int)(num2 * 1001185908) ^ -1605433674;
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
			while (true)
			{
				int num = -206496286;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE682EFCDu) % 3u)
					{
					case 1u:
						goto IL_0017;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0017:
					num = (int)((num2 * 1441822403) ^ 0x1F10AA1D);
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
				int num = 953638634;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1C8BEE5Du) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = ((int)num2 * -515939810) ^ 0x82D8597;
						continue;
					case 0u:
						num = (int)((num2 * 970403876) ^ 0x71D8F170);
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

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		Add("", aItem);
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1607022343;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA35F6FFu) % 3u)
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
				num = (int)((num2 * 411745510) ^ 0x58B5628);
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
			int num = 978838793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27A622DCu) % 4u)
				{
				case 1u:
					result = aNode;
					num = (int)(num2 * 1568540589) ^ -1081391663;
					continue;
				case 0u:
					num = ((int)num2 * -1592045807) ^ -851912970;
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
		string result = "JSONNode";
		while (true)
		{
			int num = 1981311957;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x75BD588Cu) % 3u)
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
				num = (int)(num2 * 1902429827) ^ -1295232313;
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
			int num = 120401923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33B3157Eu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1496575244) ^ -134098786;
					continue;
				case 1u:
					result = new JSONData(s);
					num = (int)(num2 * 1230040168) ^ -1427053192;
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
			int num = 540942684;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x50EF3789u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 426902140) ^ 0x4EEECEF);
					continue;
				case 1u:
					if (!(d == null))
					{
						num = (int)((num2 * 455431622) ^ 0x31537D24);
						continue;
					}
					obj = null;
					goto IL_002b;
				case 0u:
					obj = d.Value;
					goto IL_002b;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_002b:
					result = (string)obj;
					num = 393395665;
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
		int num = -61340854;
		goto IL_0044;
		IL_0044:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9A10B1B0u) % 6u)
			{
			case 4u:
				result = (object)a == b;
				num = -1475665577;
				continue;
			case 3u:
				result = true;
				num = ((int)num2 * -348455895) ^ -104248438;
				continue;
			case 1u:
				num = (int)((num2 * 2023408215) ^ 0x5255208E);
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_006d;
			default:
				return result;
			}
			break;
			IL_006d:
			if (a is JSONLazyCreator)
			{
				num = -2852387;
				num3 = -2852387;
				continue;
			}
			goto IL_0078;
		}
		goto IL_003f;
		IL_0078:
		num = -270438456;
		num3 = -270438456;
		goto IL_0044;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 394026708;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3368DD2Au) % 4u)
				{
				case 2u:
					result = !(a == b);
					num = (int)((num2 * 468158206) ^ 0x1DC1E593);
					continue;
				case 1u:
					num = ((int)num2 * -1718529974) ^ 0x7EA28E28;
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

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1752453672;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x802D3AB1u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 661237152) ^ -1146528607;
					continue;
				case 1u:
					result = (object)this == obj;
					num = (int)((num2 * 121464898) ^ 0x6944F799);
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
		int result = default(int);
		while (true)
		{
			int num = 481927379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D5E1D96u) % 3u)
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
				result = this.method_0();
				num = ((int)num2 * -956837294) ^ 0x2BD4215;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		char c = default(char);
		string result = default(string);
		while (true)
		{
			int num = -36821003;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2656498u) % 30u)
				{
				case 29u:
					num = (int)((num2 * 1226401055) ^ 0x5FB8275B);
					continue;
				case 28u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -734908168;
					continue;
				case 27u:
					c2 = JSONNode.smethod_2(string_, num3);
					num = -1254888658;
					continue;
				case 26u:
				{
					char c3 = c2;
					c = c3;
					num = (int)((num2 * 1482041348) ^ 0x405C728A);
					continue;
				}
				case 25u:
					text = JSONNode.smethod_3(text, "\\f");
					num = -73123879;
					continue;
				case 24u:
					goto IL_0071;
				case 22u:
				{
					int num6;
					if (c == '\\')
					{
						num = -588014152;
						num6 = -588014152;
					}
					else
					{
						num = -1080329370;
						num6 = -1080329370;
					}
					continue;
				}
				case 21u:
					num = ((int)num2 * -185948404) ^ -1946452236;
					continue;
				case 19u:
					goto IL_00bc;
				case 18u:
					num = ((int)num2 * -76735532) ^ -417099426;
					continue;
				case 17u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -1164486520;
						num5 = -1164486520;
					}
					else
					{
						num = -370291935;
						num5 = -370291935;
					}
					continue;
				}
				case 16u:
					result = text;
					num = ((int)num2 * -1665822155) ^ 0x4291B047;
					continue;
				case 15u:
					num = ((int)num2 * -585741702) ^ -1078410050;
					continue;
				case 14u:
					string_ = aText;
					num3 = 0;
					num = (int)(num2 * 748195577) ^ -1257445703;
					continue;
				case 13u:
					goto IL_014a;
				case 12u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1348963237;
					continue;
				case 11u:
					num = ((int)num2 * -1977824215) ^ -968619284;
					continue;
				case 10u:
					switch (c)
					{
					case '\f':
						break;
					case '\t':
						goto IL_0071;
					case '\n':
						goto IL_00bc;
					case '\b':
						goto IL_014a;
					default:
						goto IL_01aa;
					case '\v':
						goto IL_01bd;
					case '\r':
						goto IL_01d5;
					}
					goto case 25u;
				case 8u:
					goto IL_01bd;
				case 7u:
					goto IL_01d5;
				case 9u:
				{
					int num4;
					if (c != '"')
					{
						num = -218151278;
						num4 = -218151278;
					}
					else
					{
						num = -1977869428;
						num4 = -1977869428;
					}
					continue;
				}
				case 6u:
					num3++;
					num = -742263129;
					continue;
				case 5u:
					num = (int)((num2 * 1336264794) ^ 0x3EDBE41E);
					continue;
				case 4u:
					num = (int)((num2 * 76681504) ^ 0x16222454);
					continue;
				case 3u:
					text = "";
					num = ((int)num2 * -600022394) ^ 0x72963318;
					continue;
				case 2u:
					num = ((int)num2 * -1203230569) ^ 0x12F4138C;
					continue;
				case 1u:
					num = ((int)num2 * -1949036236) ^ -1137546652;
					continue;
				case 0u:
					num = ((int)num2 * -1721249520) ^ 0x1FE9118;
					continue;
				case 23u:
					break;
				default:
					{
						return result;
					}
					IL_0071:
					text = JSONNode.smethod_3(text, "\\t");
					num = -734908168;
					continue;
					IL_01d5:
					text = JSONNode.smethod_3(text, "\\r");
					num = -55809657;
					continue;
					IL_01bd:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -734908168;
					continue;
					IL_01aa:
					num = ((int)num2 * -854309380) ^ -762961627;
					continue;
					IL_014a:
					text = JSONNode.smethod_3(text, "\\b");
					num = -332929882;
					continue;
					IL_00bc:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1003375033;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		char c3 = default(char);
		int num18 = default(int);
		JSONNode jSONNode = default(JSONNode);
		string text2 = default(string);
		string text = default(string);
		bool flag16 = default(bool);
		bool flag4 = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		bool flag19 = default(bool);
		bool flag14 = default(bool);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		char c2 = default(char);
		bool flag6 = default(bool);
		bool flag18 = default(bool);
		bool flag11 = default(bool);
		bool flag5 = default(bool);
		bool flag17 = default(bool);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag7 = default(bool);
		bool flag15 = default(bool);
		bool flag8 = default(bool);
		char c5 = default(char);
		bool flag12 = default(bool);
		char c = default(char);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 686288748;
			while (true)
			{
				uint num2;
				int num46;
				switch ((num2 = (uint)num ^ 0x783BC2A4u) % 156u)
				{
				case 155u:
				{
					int num59;
					int num60;
					if (c3 != ':')
					{
						num59 = -733267034;
						num60 = -733267034;
					}
					else
					{
						num59 = -1100341053;
						num60 = -1100341053;
					}
					num = num59 ^ ((int)num2 * -1863681193);
					continue;
				}
				case 30u:
				case 51u:
				case 134u:
				case 142u:
				case 154u:
					num18++;
					num = 1371452136;
					continue;
				case 153u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -557753749) ^ 0x7EFC7B7D;
					continue;
				case 152u:
					num = 962870825;
					continue;
				case 151u:
					num = 616605448;
					continue;
				case 150u:
					text2 = text;
					num = 529285663;
					continue;
				case 149u:
					num = (int)((num2 * 1454569886) ^ 0x477A6E3F);
					continue;
				case 148u:
					num = ((int)num2 * -1725274112) ^ -1469167016;
					continue;
				case 147u:
					num = (int)((num2 * 1910625260) ^ 0x501B79F1);
					continue;
				case 146u:
					stack.Pop();
					num = 1010626211;
					continue;
				case 145u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = (int)((num2 * 810458379) ^ 0x68C148F2);
					continue;
				case 144u:
					flag16 = JSONNode.smethod_6(text2, "");
					num = 406398588;
					continue;
				case 141u:
					switch (c3)
					{
					case '[':
						goto IL_0130;
					case '\\':
						goto IL_013e;
					case ']':
						goto IL_014c;
					}
					num = 820806044;
					continue;
				case 98u:
					goto IL_0130;
				case 105u:
					goto IL_013e;
				case 103u:
					goto IL_014c;
				case 140u:
				{
					int num42;
					int num43;
					if (jSONNode != null)
					{
						num42 = 1307609259;
						num43 = 1307609259;
					}
					else
					{
						num42 = 262829215;
						num43 = 262829215;
					}
					num = num42 ^ ((int)num2 * -1986612484);
					continue;
				}
				case 139u:
				{
					int num31;
					int num32;
					if (!flag4)
					{
						num31 = -1806017321;
						num32 = -1806017321;
					}
					else
					{
						num31 = -96803894;
						num32 = -96803894;
					}
					num = num31 ^ ((int)num2 * -124638653);
					continue;
				}
				case 137u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 1617057120) ^ -914753669;
					continue;
				case 136u:
					num = (int)(num2 * 1891752303) ^ -1833590696;
					continue;
				case 135u:
					flag10 = flag3;
					num = 2143850595;
					continue;
				case 133u:
					text2 = "";
					num = 1066881732;
					continue;
				case 132u:
				{
					int num14;
					if (c3 == '"')
					{
						num = 866269785;
						num14 = 866269785;
					}
					else
					{
						num = 1225002847;
						num14 = 1225002847;
					}
					continue;
				}
				case 131u:
					stack.Push(new JSONArray());
					num = 1950199897;
					continue;
				case 130u:
					num = ((int)num2 * -1022970319) ^ -602890736;
					continue;
				case 129u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 2092400145) ^ 0x3C41EDA6);
					continue;
				case 128u:
					num = (int)(num2 * 1360747479) ^ -1140922104;
					continue;
				case 127u:
					num = 588040571;
					continue;
				case 126u:
				{
					int num63;
					int num64;
					if (!flag19)
					{
						num63 = 1160288309;
						num64 = 1160288309;
					}
					else
					{
						num63 = 2092855149;
						num64 = 2092855149;
					}
					num = num63 ^ (int)(num2 * 302237581);
					continue;
				}
				case 125u:
					num = (int)(num2 * 1220023691) ^ -858464662;
					continue;
				case 124u:
					num = ((int)num2 * -1184862796) ^ 0x359D78D1;
					continue;
				case 123u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num55;
					int num56;
					if (!(jSONNode is JSONArray))
					{
						num55 = -540242840;
						num56 = -540242840;
					}
					else
					{
						num55 = -966980958;
						num56 = -966980958;
					}
					num = num55 ^ (int)(num2 * 2120235056);
					continue;
				}
				case 122u:
					num = ((int)num2 * -2014638171) ^ 0x21860E7A;
					continue;
				case 121u:
					goto IL_0320;
				case 120u:
					text = "";
					num = (int)(num2 * 589079432) ^ -681584715;
					continue;
				case 119u:
				{
					int num50;
					if (c3 != '{')
					{
						num = 75693910;
						num50 = 75693910;
					}
					else
					{
						num = 1579452363;
						num50 = 1579452363;
					}
					continue;
				}
				case 118u:
					num = (int)(num2 * 1710032429) ^ -1763526546;
					continue;
				case 117u:
					switch (c3)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_03a2;
					case '\t':
						goto IL_03b5;
					case '\v':
					case '\f':
						goto IL_03d5;
					}
					goto case 30u;
				case 33u:
					goto IL_03b5;
				case 4u:
					goto IL_03d5;
				case 116u:
				{
					int num38;
					int num39;
					if ((uint)c3 <= 32u)
					{
						num38 = -1011793955;
						num39 = -1011793955;
					}
					else
					{
						num38 = -1975908612;
						num39 = -1975908612;
					}
					num = num38 ^ ((int)num2 * -1791956725);
					continue;
				}
				case 115u:
					flag14 = flag3;
					num = 26155985;
					continue;
				case 114u:
					goto IL_042f;
				case 113u:
					num = ((int)num2 * -1294240053) ^ -1016941283;
					continue;
				case 112u:
					text = "";
					text2 = "";
					flag3 = false;
					num = (int)(num2 * 1047102219) ^ -667788916;
					continue;
				case 111u:
					num = (int)(num2 * 1948300000) ^ -801614102;
					continue;
				case 110u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = (int)((num2 * 43923179) ^ 0x3D9FE240);
					continue;
				case 109u:
					num = ((int)num2 * -157558346) ^ 0x39376EB1;
					continue;
				case 108u:
				{
					int num27;
					int num28;
					if (!flag)
					{
						num27 = -1276787149;
						num28 = -1276787149;
					}
					else
					{
						num27 = -1480514311;
						num28 = -1480514311;
					}
					num = num27 ^ (int)(num2 * 1881527134);
					continue;
				}
				case 107u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = (int)((num2 * 599389516) ^ 0x6EE99EB6);
					continue;
				case 106u:
					result = jSONNode;
					num = 666974501;
					continue;
				case 104u:
				{
					int num21;
					int num22;
					if (c2 != 'b')
					{
						num21 = 1434776929;
						num22 = 1434776929;
					}
					else
					{
						num21 = 906947978;
						num22 = 906947978;
					}
					num = num21 ^ (int)(num2 * 804830312);
					continue;
				}
				case 102u:
				{
					int num17;
					if (c3 != ' ')
					{
						num = 880928578;
						num17 = 880928578;
					}
					else
					{
						num = 1593292785;
						num17 = 1593292785;
					}
					continue;
				}
				case 101u:
					num = (int)((num2 * 1587922194) ^ 0x58801729);
					continue;
				case 100u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num11;
					int num12;
					if (jSONNode is JSONArray)
					{
						num11 = 1586145857;
						num12 = 1586145857;
					}
					else
					{
						num11 = 1599918439;
						num12 = 1599918439;
					}
					num = num11 ^ (int)(num2 * 930433194);
					continue;
				}
				case 99u:
					num = (int)(num2 * 740442261) ^ -1253706761;
					continue;
				case 97u:
				{
					int num7;
					int num8;
					if (flag6)
					{
						num7 = -540013208;
						num8 = -540013208;
					}
					else
					{
						num7 = -1886781470;
						num8 = -1886781470;
					}
					num = num7 ^ (int)(num2 * 2091312420);
					continue;
				}
				case 96u:
					switch (c2)
					{
					case 'u':
						break;
					case 'r':
						goto IL_0320;
					case 's':
						goto IL_042f;
					default:
						goto IL_061c;
					case 't':
						goto IL_0626;
					}
					goto case 127u;
				case 25u:
					goto IL_0626;
				case 95u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = (int)((num2 * 16387424) ^ 0x6A1EC736);
					continue;
				case 94u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 1697747210) ^ 0x73A4528C);
					continue;
				case 93u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1875651996) ^ -1242423032;
					continue;
				case 92u:
					num = (int)(num2 * 1672176222) ^ -849348374;
					continue;
				case 91u:
					num = (int)(num2 * 1450696868) ^ -1095069074;
					continue;
				case 90u:
					num = ((int)num2 * -1066713774) ^ -217493906;
					continue;
				case 89u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1071007689) ^ 0x30180609;
					continue;
				case 87u:
				{
					int num65;
					int num66;
					if (!flag10)
					{
						num65 = 635268814;
						num66 = 635268814;
					}
					else
					{
						num65 = 679574217;
						num66 = 679574217;
					}
					num = num65 ^ ((int)num2 * -1704859878);
					continue;
				}
				case 86u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 916156455) ^ 0x58428FB0);
					continue;
				case 85u:
					text = JSONNode.smethod_3(text, "\n");
					num = 307782464;
					continue;
				case 84u:
					num = (int)((num2 * 1433650854) ^ 0x755C3B9A);
					continue;
				case 83u:
					text = JSONNode.smethod_3(text, "\f");
					num = 397350689;
					continue;
				case 82u:
					flag18 = flag3;
					num = 1058107664;
					continue;
				case 81u:
					flag3 = !flag3;
					num = 1442239602;
					continue;
				case 80u:
					flag11 = num18 < JSONNode.smethod_4(aJSON);
					num = 119168648;
					continue;
				case 79u:
					num = ((int)num2 * -507135364) ^ 0x772BEA04;
					continue;
				case 78u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = (int)((num2 * 1824599641) ^ 0x10C01434);
					continue;
				case 77u:
					num = (int)(num2 * 1428069159) ^ -1919250523;
					continue;
				case 76u:
					flag5 = flag3;
					num = (int)(num2 * 1457991706) ^ -976119972;
					continue;
				case 75u:
					jSONNode.Add(text);
					num = (int)((num2 * 17117459) ^ 0x11ABD1A8);
					continue;
				case 74u:
					num = 1042681423;
					continue;
				case 73u:
				{
					int num62;
					if (c3 != ',')
					{
						num = 201549452;
						num62 = 201549452;
					}
					else
					{
						num = 1125401051;
						num62 = 1125401051;
					}
					continue;
				}
				case 72u:
					stack.Push(new JSONClass());
					num = 1784617987;
					continue;
				case 71u:
				{
					string s = JSONNode.smethod_8(aJSON, num18 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num18 += 4;
					num = (int)(num2 * 1405529350) ^ -1040372769;
					continue;
				}
				case 70u:
				{
					int num61;
					if (c2 == 'f')
					{
						num = 555786907;
						num61 = 555786907;
					}
					else
					{
						num = 1956015608;
						num61 = 1956015608;
					}
					continue;
				}
				case 69u:
				{
					int num57;
					int num58;
					if (!flag17)
					{
						num57 = -503863385;
						num58 = -503863385;
					}
					else
					{
						num57 = -2060717217;
						num58 = -2060717217;
					}
					num = num57 ^ ((int)num2 * -1418014651);
					continue;
				}
				case 68u:
					num = (int)((num2 * 684624303) ^ 0x7F306C48);
					continue;
				case 67u:
					text = "";
					num = ((int)num2 * -1369197808) ^ -1367490382;
					continue;
				case 66u:
					num = (int)((num2 * 560237701) ^ 0x5F781CFB);
					continue;
				case 65u:
				{
					int num53;
					int num54;
					if (!(jSONNode is JSONArray))
					{
						num53 = -1787888460;
						num54 = -1787888460;
					}
					else
					{
						num53 = -1848229921;
						num54 = -1848229921;
					}
					num = num53 ^ ((int)num2 * -1609172734);
					continue;
				}
				case 64u:
				{
					int num51;
					int num52;
					if (!flag18)
					{
						num51 = 89395758;
						num52 = 89395758;
					}
					else
					{
						num51 = 788482990;
						num52 = 788482990;
					}
					num = num51 ^ ((int)num2 * -2117179135);
					continue;
				}
				case 63u:
					flag13 = JSONNode.smethod_6(text, "");
					num = ((int)num2 * -1367731108) ^ -1321574029;
					continue;
				case 62u:
					num = (int)(num2 * 839233507) ^ -940517201;
					continue;
				case 61u:
					flag9 = jSONNode != null;
					num = ((int)num2 * -1162721960) ^ -1366389357;
					continue;
				case 60u:
					flag17 = stack.Count > 0;
					num = ((int)num2 * -964322259) ^ 0x2BB15755;
					continue;
				case 59u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 1411159464;
					continue;
				case 58u:
					num = ((int)num2 * -256504924) ^ -1214144729;
					continue;
				case 57u:
				{
					int num49;
					if (c2 == 'n')
					{
						num = 131654485;
						num49 = 131654485;
					}
					else
					{
						num = 1441654275;
						num49 = 1441654275;
					}
					continue;
				}
				case 56u:
				{
					int num47;
					int num48;
					if (!flag16)
					{
						num47 = 239348556;
						num48 = 239348556;
					}
					else
					{
						num47 = 688514765;
						num48 = 688514765;
					}
					num = num47 ^ ((int)num2 * -275289527);
					continue;
				}
				case 55u:
					num = (int)(num2 * 997056451) ^ -2073938423;
					continue;
				case 54u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 2096637410) ^ -1482287266;
					continue;
				case 53u:
				{
					int num44;
					int num45;
					if (flag14)
					{
						num44 = 693588453;
						num45 = 693588453;
					}
					else
					{
						num44 = 615208970;
						num45 = 615208970;
					}
					num = num44 ^ ((int)num2 * -733573494);
					continue;
				}
				case 52u:
				{
					int num40;
					int num41;
					if (!flag15)
					{
						num40 = 715643199;
						num41 = 715643199;
					}
					else
					{
						num40 = 787097303;
						num41 = 787097303;
					}
					num = num40 ^ ((int)num2 * -245007505);
					continue;
				}
				case 50u:
				{
					int num36;
					int num37;
					if (flag8)
					{
						num36 = -2099633313;
						num37 = -2099633313;
					}
					else
					{
						num36 = -651082231;
						num37 = -651082231;
					}
					num = num36 ^ ((int)num2 * -2115077746);
					continue;
				}
				case 49u:
					num = (int)((num2 * 1696092976) ^ 0x3F59BF32);
					continue;
				case 48u:
					num = 2063659752;
					continue;
				case 47u:
				{
					int num34;
					int num35;
					if (!flag13)
					{
						num34 = 333738855;
						num35 = 333738855;
					}
					else
					{
						num34 = 435695594;
						num35 = 435695594;
					}
					num = num34 ^ ((int)num2 * -1897493259);
					continue;
				}
				case 46u:
					c5 = JSONNode.smethod_2(aJSON, num18);
					num = (int)(num2 * 1652958939) ^ -1148342808;
					continue;
				case 45u:
				{
					int num33;
					if (c3 != '}')
					{
						num = 297572146;
						num33 = 297572146;
					}
					else
					{
						num = 916261607;
						num33 = 916261607;
					}
					continue;
				}
				case 44u:
					flag12 = JSONNode.smethod_6(text, "");
					num = 1868093685;
					continue;
				case 43u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = ((int)num2 * -484700326) ^ 0x214C3E2C;
					continue;
				case 42u:
					text = JSONNode.smethod_3(text, "\b");
					num = 397350689;
					continue;
				case 41u:
					text = "";
					num = (int)((num2 * 1479555440) ^ 0x345827D8);
					continue;
				case 40u:
					num18 = 0;
					num = (int)(num2 * 1962100131) ^ -470493924;
					continue;
				case 39u:
					num = ((int)num2 * -2146065216) ^ 0x110491A8;
					continue;
				case 38u:
					num = ((int)num2 * -1114090747) ^ -1752224204;
					continue;
				case 37u:
				{
					int num29;
					int num30;
					if (!flag12)
					{
						num29 = 526376330;
						num30 = 526376330;
					}
					else
					{
						num29 = 1169380763;
						num30 = 1169380763;
					}
					num = num29 ^ (int)(num2 * 1401151170);
					continue;
				}
				case 36u:
				{
					int num25;
					int num26;
					if (flag11)
					{
						num25 = 1492303234;
						num26 = 1492303234;
					}
					else
					{
						num25 = 246025280;
						num26 = 246025280;
					}
					num = num25 ^ ((int)num2 * -1923266407);
					continue;
				}
				case 35u:
				{
					int num23;
					int num24;
					if (flag9)
					{
						num23 = 2100287244;
						num24 = 2100287244;
					}
					else
					{
						num23 = 1417334132;
						num24 = 1417334132;
					}
					num = num23 ^ (int)(num2 * 1544602643);
					continue;
				}
				case 34u:
					num = ((int)num2 * -937854876) ^ 0xFC90B98;
					continue;
				case 32u:
					jSONNode = null;
					num = ((int)num2 * -51831981) ^ -568158268;
					continue;
				case 31u:
					text2 = "";
					text = "";
					num = 1034539861;
					continue;
				case 29u:
					num = (int)((num2 * 1738274973) ^ 0x20F6F0FF);
					continue;
				case 28u:
					text2 = "";
					num = 1158888649;
					continue;
				case 27u:
					num = ((int)num2 * -130207702) ^ -1747163817;
					continue;
				case 26u:
					c = c5;
					num = (int)((num2 * 211545020) ^ 0x181D2505);
					continue;
				case 24u:
				{
					char c4 = JSONNode.smethod_2(aJSON, num18);
					c3 = c4;
					int num19;
					int num20;
					if ((uint)c3 > 44u)
					{
						num19 = 1094787769;
						num20 = 1094787769;
					}
					else
					{
						num19 = 1782986796;
						num20 = 1782986796;
					}
					num = num19 ^ (int)(num2 * 231561316);
					continue;
				}
				case 23u:
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -270768567) ^ 0x3B95DCB9;
					continue;
				case 22u:
				{
					int num15;
					int num16;
					if (!flag2)
					{
						num15 = 286640866;
						num16 = 286640866;
					}
					else
					{
						num15 = 1948407068;
						num16 = 1948407068;
					}
					num = num15 ^ ((int)num2 * -1366258799);
					continue;
				}
				case 21u:
				{
					int num13;
					if ((uint)c3 > 93u)
					{
						num = 9963955;
						num13 = 9963955;
					}
					else
					{
						num = 150738127;
						num13 = 150738127;
					}
					continue;
				}
				case 20u:
				{
					int num9;
					int num10;
					if (flag7)
					{
						num9 = -896345847;
						num10 = -896345847;
					}
					else
					{
						num9 = -1640999806;
						num10 = -1640999806;
					}
					num = num9 ^ ((int)num2 * -1495956212);
					continue;
				}
				case 19u:
					flag6 = stack.Count == 0;
					num = 1356183133;
					continue;
				case 18u:
					num = 708238052;
					continue;
				case 17u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 296584577) ^ 0x2E651A51);
					continue;
				case 16u:
				{
					int num5;
					int num6;
					if (!flag5)
					{
						num5 = 26948342;
						num6 = 26948342;
					}
					else
					{
						num5 = 1457607452;
						num6 = 1457607452;
					}
					num = num5 ^ ((int)num2 * -1190492374);
					continue;
				}
				case 15u:
					num = (int)((num2 * 1818843467) ^ 0x39937963);
					continue;
				case 14u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -939306036) ^ 0x3FF1925F;
					continue;
				case 13u:
				{
					c2 = c;
					int num3;
					int num4;
					if ((uint)c2 > 102u)
					{
						num3 = 526603452;
						num4 = 526603452;
					}
					else
					{
						num3 = 157374169;
						num4 = 157374169;
					}
					num = num3 ^ ((int)num2 * -1855414531);
					continue;
				}
				case 12u:
					text2 = "";
					text = "";
					num = 45485058;
					continue;
				case 11u:
					flag4 = flag3;
					num = (int)(num2 * 1416032741) ^ -1636041784;
					continue;
				case 10u:
					flag2 = JSONNode.smethod_6(text2, "");
					num = 1806370046;
					continue;
				case 9u:
					flag = JSONNode.smethod_6(text2, "");
					num = 307720648;
					continue;
				case 7u:
					num = (int)(num2 * 763722315) ^ -1600870448;
					continue;
				case 6u:
					num = (int)((num2 * 1492997724) ^ 0x7E6814EA);
					continue;
				case 5u:
					num = 1798827906;
					continue;
				case 3u:
					num = ((int)num2 * -968204899) ^ 0xB9CA0C;
					continue;
				case 2u:
					num = (int)((num2 * 2135389253) ^ 0x238D3EFC);
					continue;
				case 1u:
					jSONNode.Add(text);
					num = ((int)num2 * -890667139) ^ -1438019185;
					continue;
				case 0u:
					num = (int)(num2 * 1538093055) ^ -2010445507;
					continue;
				case 143u:
					break;
				case 8u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 88u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0626:
					text = JSONNode.smethod_3(text, "\t");
					num = 1326708453;
					continue;
					IL_061c:
					num = 925251042;
					continue;
					IL_042f:
					text = JSONNode.smethod_3(text, c5.ToString());
					num = 1124020424;
					continue;
					IL_03d5:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num18).ToString());
					num = 704472546;
					continue;
					IL_03b5:
					if (flag3)
					{
						num = 1456984254;
						num46 = 1456984254;
					}
					else
					{
						num = 51248030;
						num46 = 51248030;
					}
					continue;
					IL_03a2:
					num = ((int)num2 * -1130397654) ^ 0x740BDC55;
					continue;
					IL_014c:
					flag15 = flag3;
					num = 844115636;
					continue;
					IL_0320:
					text = JSONNode.smethod_3(text, "\r");
					num = 179439934;
					continue;
					IL_013e:
					num18++;
					num = 1629267755;
					continue;
					IL_0130:
					flag19 = flag3;
					num = 1022650698;
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
			int num = 192872986;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3F6FB69Bu) % 4u)
				{
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = (int)((num2 * 216520552) ^ 0x61D83613);
					continue;
				case 0u:
					Serialize(aWriter);
					num = ((int)num2 * -1926770771) ^ 0xE1BA16C;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
				int num = 633846411;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x101E744Du) % 4u)
					{
					case 3u:
						num = (int)((num2 * 367536268) ^ 0x7782ECC0);
						continue;
					case 2u:
						SaveToStream(fileStream);
						num = ((int)num2 * -899329237) ^ 0x6E5B5E84;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00b5:
					int num3 = 455488040;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x101E744Du) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -759813833) ^ 0x5CA47DE2;
							continue;
						case 0u:
							num3 = (int)(num2 * 1508166152) ^ -1373916189;
							continue;
						default:
							goto end_IL_0094;
						case 3u:
							break;
						case 2u:
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
			SaveToStream(memoryStream);
			string result = default(string);
			while (true)
			{
				int num = -1035288620;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF45CDD55u) % 4u)
					{
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 2070299181) ^ 0x40BB88E0);
						continue;
					case 0u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 1064517185) ^ 0x3D4E8AE2);
						continue;
					case 2u:
						break;
					default:
						return result;
					case 3u:
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
					IL_00b8:
					int num3 = -754212540;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xF45CDD55u) % 4u)
						{
						case 2u:
							num3 = ((int)num2 * -1419171462) ^ 0x18693AB2;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -178381250) ^ 0x7DB1EAAD;
							continue;
						default:
							goto end_IL_0097;
						case 0u:
							break;
						case 3u:
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
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num3 = default(int);
		string aKey = default(string);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num4 = default(int);
		JSONClass jSONClass = default(JSONClass);
		while (true)
		{
			int num = 16415056;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4BEA1F39u) % 39u)
				{
				case 38u:
					num = (int)((num2 * 1848624209) ^ 0x26B2372B);
					continue;
				case 37u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = 946858302;
						num10 = 946858302;
					}
					else
					{
						num9 = 1361373345;
						num10 = 1361373345;
					}
					num = num9 ^ (int)(num2 * 1761744191);
					continue;
				}
				case 36u:
					result = jSONArray;
					num = ((int)num2 * -877478619) ^ 0x374AEC07;
					continue;
				case 35u:
					num = (int)(num2 * 1594674329) ^ -1466502118;
					continue;
				case 33u:
					num6 = 0;
					num = (int)((num2 * 205375392) ^ 0x7F65280A);
					continue;
				case 31u:
					num = 1179280030;
					continue;
				case 30u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 694583901) ^ 0x2520A231);
					continue;
				case 29u:
					goto IL_00b2;
				case 28u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)((num2 * 814482733) ^ 0x5DBDAD46);
					continue;
				case 27u:
					goto IL_00d1;
				case 26u:
					num = (int)((num2 * 900235400) ^ 0x618AB492);
					continue;
				case 25u:
					flag2 = num6 < num5;
					num = 76607174;
					continue;
				case 24u:
					num3 = 0;
					num = ((int)num2 * -1781142943) ^ 0x230C82F;
					continue;
				case 23u:
					jSONArray.Add(Deserialize(aReader));
					num = 1696444283;
					continue;
				case 22u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1423177841;
						num8 = -1423177841;
					}
					else
					{
						num7 = -562176600;
						num8 = -562176600;
					}
					num = num7 ^ (int)(num2 * 1766820984);
					continue;
				}
				case 21u:
					num = (int)(num2 * 1669483063) ^ -1537362511;
					continue;
				case 19u:
					num6++;
					num = ((int)num2 * -941656118) ^ 0x74F070B0;
					continue;
				case 18u:
					num = (int)((num2 * 834098579) ^ 0x2452FBD7);
					continue;
				case 17u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)(num2 * 695420872) ^ -1839944367;
					continue;
				case 16u:
					goto IL_01be;
				case 15u:
					num = 416081920;
					continue;
				case 14u:
					goto IL_01d2;
				case 13u:
					num = 659484200;
					continue;
				case 12u:
					num = (int)(num2 * 1482979142) ^ -1080492602;
					continue;
				case 11u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.IntValue:
						break;
					case JSONBinaryTag.BoolValue:
						goto IL_00b2;
					case JSONBinaryTag.Class:
						goto IL_00d1;
					case JSONBinaryTag.Value:
						goto IL_01be;
					case JSONBinaryTag.DoubleValue:
						goto IL_01d2;
					default:
						goto IL_022a;
					case JSONBinaryTag.Array:
						goto IL_023d;
					case JSONBinaryTag.FloatValue:
						goto IL_0255;
					}
					goto case 31u;
				case 10u:
					goto IL_023d;
				case 0u:
					goto IL_0255;
				case 9u:
					num = ((int)num2 * -328217297) ^ 0x4E9E15AE;
					continue;
				case 8u:
					flag = num3 < num4;
					num = 74258754;
					continue;
				case 7u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)(num2 * 881965106) ^ -281523381;
					continue;
				case 6u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 1275707320) ^ 0x21BDD5F4);
					continue;
				case 5u:
					result = jSONClass;
					num = (int)(num2 * 1750886453) ^ -1286467086;
					continue;
				case 4u:
					num = ((int)num2 * -1249877442) ^ -1452730375;
					continue;
				case 3u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 1668187393) ^ -624302368;
					continue;
				}
				case 2u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 1415180240) ^ 0x1AF4DD18);
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -72394886) ^ 0x14C30F9C;
					continue;
				case 34u:
					break;
				case 20u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0255:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = 417231782;
					continue;
					IL_023d:
					num5 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = 2138810636;
					continue;
					IL_022a:
					num = ((int)num2 * -2056585854) ^ 0x4C2E9B85;
					continue;
					IL_01d2:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 1736888730;
					continue;
					IL_01be:
					num = 1719731662;
					continue;
					IL_00d1:
					num4 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = 635539462;
					continue;
					IL_00b2:
					num = 1778065112;
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
					int num = -2093768882;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xFB86A9B7u) % 3u)
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
						num = (int)((num2 * 57773390) ^ 0x75D17CD3);
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
					int num = -1380502142;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x9D644433u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 1054663738) ^ 0xAE80C65);
							continue;
						case 0u:
							num = (int)(num2 * 651712702) ^ -174511332;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		byte[] byte_ = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1945416335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F4B211Bu) % 5u)
				{
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)((num2 * 1234626140) ^ 0x5EF07F87);
					continue;
				case 2u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -630152400) ^ 0x7BDAE4AA;
					continue;
				case 1u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 2002210255) ^ 0x1F497386);
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
