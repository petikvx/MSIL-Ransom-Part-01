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
				int num = -49278727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9EC57319u) % 3u)
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
					num = ((int)num2 * -150724023) ^ -1046703223;
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
			string result = "";
			while (true)
			{
				int num = -1982305638;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8547EDE9u) % 3u)
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
					num = (int)((num2 * 1281285540) ^ 0x313B699);
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
				int num = 1030970118;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AF8B6A9u) % 3u)
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
					num = (int)((num2 * 616838342) ^ 0x70E0ACF7);
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
				int num = 1121166951;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x331832Eu) % 3u)
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
					result = _003Cget_Childs_003Ed__;
					num = (int)(num2 * 1613405275) ^ -302611944;
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
				int num = 1009126454;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4F01F804u) % 4u)
					{
					case 2u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 59751767) ^ -1224212593;
						continue;
					case 1u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)(num2 * 1858369577) ^ -1042410143;
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
			bool flag = default(bool);
			int result2 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -771744225;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2676B07u) % 9u)
					{
					case 8u:
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -273150851) ^ 0x1521884E;
						continue;
					case 7u:
						result2 = 0;
						num = ((int)num2 * -1210282430) ^ -1286774018;
						continue;
					case 6u:
						result = result2;
						num = ((int)num2 * -380332684) ^ 0x355C3E5E;
						continue;
					case 5u:
						num = ((int)num2 * -1946479635) ^ -2088187045;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1404946347;
							num4 = 1404946347;
						}
						else
						{
							num3 = 1235274160;
							num4 = 1235274160;
						}
						num = num3 ^ (int)(num2 * 2006203754);
						continue;
					}
					case 1u:
						num = (int)((num2 * 1160920597) ^ 0x3677C8C2);
						continue;
					case 0u:
						result = 0;
						num = -1111729369;
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
			while (true)
			{
				int num = -1377576692;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8667ED4Bu) % 3u)
					{
					case 1u:
						goto IL_000f;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000f:
					num = (int)(num2 * 460972463) ^ -186229408;
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
				int num = 612550323;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3CB812B2u) % 8u)
					{
					case 7u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)((num2 * 887809534) ^ 0x3AB61DD5);
						continue;
					case 6u:
						num = (int)((num2 * 1255707558) ^ 0x64BEE64C);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 70761291;
							num4 = 70761291;
						}
						else
						{
							num3 = 822388111;
							num4 = 822388111;
						}
						num = num3 ^ (int)(num2 * 1087546009);
						continue;
					}
					case 4u:
						result = 0f;
						num = 1498856788;
						continue;
					case 1u:
						result2 = 0f;
						num = (int)(num2 * 1200700424) ^ -126137139;
						continue;
					case 0u:
						result = result2;
						num = ((int)num2 * -2112669989) ^ -610829160;
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
			while (true)
			{
				int num = 1761734883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F9678B1u) % 3u)
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
					num = (int)(num2 * 1560954312) ^ -1395758283;
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
			while (true)
			{
				int num = -2142941833;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA6668899u) % 8u)
					{
					case 7u:
						result = 0.0;
						num = -1736933459;
						continue;
					case 6u:
						result2 = 0.0;
						num = ((int)num2 * -1325864693) ^ 0x26216612;
						continue;
					case 4u:
						num = ((int)num2 * -1635238418) ^ 0x46012B92;
						continue;
					case 2u:
						num = ((int)num2 * -683954104) ^ -1924214694;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = -103016466;
							num4 = -103016466;
						}
						else
						{
							num3 = -1156103063;
							num4 = -1156103063;
						}
						num = num3 ^ (int)(num2 * 778863912);
						continue;
					}
					case 0u:
						result = result2;
						num = (int)((num2 * 428272312) ^ 0x25796F7B);
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
			Value = value.ToString();
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool flag = bool.TryParse(Value, out result);
			bool result2 = default(bool);
			while (true)
			{
				int num = 1111225095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x121E737Du) % 6u)
					{
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1632487542;
							num4 = -1632487542;
						}
						else
						{
							num3 = -606473453;
							num4 = -606473453;
						}
						num = num3 ^ (int)(num2 * 712296589);
						continue;
					}
					case 3u:
						result2 = result;
						num = (int)(num2 * 1346387246) ^ -2071474421;
						continue;
					case 2u:
						result2 = !JSONNode.smethod_1(Value);
						num = 1336805974;
						continue;
					case 1u:
						num = (int)(num2 * 1580255127) ^ -506225616;
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
				int num = -274505982;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ -1402479324) % 3u)
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
					num = -351014192;
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
				int num = 1504975384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x36F03735u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -848418660) ^ -142023279;
						continue;
					case 1u:
						result = this as JSONArray;
						num = (int)((num2 * 2049573806) ^ 0x47C249AD);
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 409400996;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1D10E3B1u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1908287991) ^ 0x8515B60;
						continue;
					case 1u:
						result = this as JSONClass;
						num = ((int)num2 * -998250905) ^ -658462919;
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
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1866121058;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CF8261Eu) % 3u)
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
				num = (int)(num2 * 1636354960) ^ -46376993;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2016633790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB4ABF83u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 641744219) ^ 0x60908BC6);
					continue;
				case 1u:
					result = null;
					num = (int)(num2 * 1929852278) ^ -1166528153;
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

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -306956880;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CCE2122u) % 3u)
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
				result = aNode;
				num = ((int)num2 * -571496852) ^ 0x658C20C5;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 2071663434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E162CDCu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -184238202) ^ -1823345929;
					continue;
				case 2u:
					result = "JSONNode";
					num = ((int)num2 * -1332553425) ^ -813202123;
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

	public virtual string ToString(string aPrefix)
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -342228566;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF498AF88u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1963288683) ^ 0x109C5EE5);
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1429866570;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x888417EFu) % 3u)
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
				num = ((int)num2 * -807834604) ^ 0x307F193D;
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
		int num = 454854735;
		goto IL_0020;
		IL_0020:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x53A839D6u) % 4u)
			{
			case 3u:
				break;
			case 0u:
				num = ((int)num2 * -1611728127) ^ 0x41F634E8;
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
		num = 117933510;
		goto IL_0020;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b == null)
		{
			goto IL_0059;
		}
		int num = 0;
		goto IL_0094;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
		IL_0059:
		int num2 = 834665057;
		goto IL_005e;
		IL_005e:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x9DE8F1Eu) % 7u)
			{
			case 4u:
				result = (object)a == b;
				num2 = 1965492594;
				continue;
			case 3u:
				result = true;
				num2 = ((int)num3 * -1376410029) ^ 0x7FCDC91C;
				continue;
			case 2u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 585304136;
					num5 = 585304136;
				}
				else
				{
					num4 = 298382157;
					num5 = 298382157;
				}
				num2 = num4 ^ ((int)num3 * -1291549869);
				continue;
			}
			case 1u:
				num2 = ((int)num3 * -1501189552) ^ 0x18884202;
				continue;
			case 0u:
				break;
			case 5u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_0059;
		IL_0094:
		flag = (byte)num != 0;
		num2 = 1858690270;
		goto IL_005e;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -591699590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7765F15u) % 3u)
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
				num = ((int)num2 * -1561731101) ^ 0x262027F2;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 197734247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D266735u) % 4u)
				{
				case 2u:
					result = (object)this == obj;
					num = ((int)num2 * -1907563218) ^ 0x6E5D28BC;
					continue;
				case 1u:
					num = (int)((num2 * 1833898958) ^ 0x5853BE77);
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
		string text = default(string);
		char c = default(char);
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -324414790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6F34373u) % 31u)
				{
				case 30u:
					num = -658263080;
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, "\\n");
					num = -777365829;
					continue;
				case 28u:
					text = "";
					num = (int)(num2 * 8120352) ^ -871256991;
					continue;
				case 27u:
				{
					int num5;
					if (c == '\\')
					{
						num = -1048474555;
						num5 = -1048474555;
					}
					else
					{
						num = -1402194253;
						num5 = -1402194253;
					}
					continue;
				}
				case 26u:
					goto IL_0061;
				case 25u:
					num = (int)(num2 * 1617500831) ^ -1410630175;
					continue;
				case 24u:
				{
					c2 = JSONNode.smethod_2(string_, num3);
					char c3 = c2;
					c = c3;
					num = -1754879802;
					continue;
				}
				case 23u:
					goto IL_00a3;
				case 21u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1306942320;
					continue;
				case 20u:
					num = ((int)num2 * -343186261) ^ -1722692251;
					continue;
				case 19u:
					num = (int)(num2 * 324145083) ^ -846417920;
					continue;
				case 18u:
					num3++;
					num = ((int)num2 * -735686051) ^ 0x166D23E7;
					continue;
				case 17u:
					num = ((int)num2 * -1482168139) ^ 0x1C3CAAFB;
					continue;
				case 16u:
					num = ((int)num2 * -674651974) ^ -2125163405;
					continue;
				case 15u:
					num = ((int)num2 * -1443486734) ^ -1588640575;
					continue;
				case 14u:
					result = text;
					num = ((int)num2 * -432875611) ^ -351178419;
					continue;
				case 13u:
				{
					int num6;
					if (c == '"')
					{
						num = -322803706;
						num6 = -322803706;
					}
					else
					{
						num = -420122718;
						num6 = -420122718;
					}
					continue;
				}
				case 12u:
					switch (c)
					{
					case '\n':
						break;
					case '\r':
						goto IL_0061;
					case '\v':
						goto IL_00a3;
					default:
						goto IL_01a0;
					case '\b':
						goto IL_01b3;
					case '\t':
						goto IL_01c9;
					case '\f':
						goto IL_01df;
					}
					goto case 29u;
				case 10u:
					goto IL_01b3;
				case 4u:
					goto IL_01c9;
				case 2u:
					goto IL_01df;
				case 11u:
					num = (int)((num2 * 798775795) ^ 0x15C6320C);
					continue;
				case 9u:
					string_ = aText;
					num = (int)(num2 * 2065994833) ^ -965234946;
					continue;
				case 8u:
					num = (int)(num2 * 709648488) ^ -1505202375;
					continue;
				case 7u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1763177661;
					continue;
				case 6u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -1406915743;
						num4 = -1406915743;
					}
					else
					{
						num = -1979937448;
						num4 = -1979937448;
					}
					continue;
				}
				case 5u:
					num3 = 0;
					num = (int)((num2 * 218235611) ^ 0x2652F0BD);
					continue;
				case 3u:
					num = (int)(num2 * 737826464) ^ -682042859;
					continue;
				case 1u:
					num = (int)(num2 * 1026402669) ^ -1990362275;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_01df:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1938201755;
					continue;
					IL_01c9:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1116850180;
					continue;
					IL_01b3:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1792395915;
					continue;
					IL_01a0:
					num = (int)((num2 * 152650945) ^ 0x1ED2B8BE);
					continue;
					IL_00a3:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -1792395915;
					continue;
					IL_0061:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1349817316;
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
		bool flag15 = default(bool);
		bool flag5 = default(bool);
		char c2 = default(char);
		bool flag4 = default(bool);
		char c = default(char);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		bool flag17 = default(bool);
		bool flag3 = default(bool);
		bool flag13 = default(bool);
		bool flag16 = default(bool);
		char c5 = default(char);
		char c3 = default(char);
		char c4 = default(char);
		JSONNode result = default(JSONNode);
		bool flag8 = default(bool);
		bool flag6 = default(bool);
		bool flag14 = default(bool);
		bool flag18 = default(bool);
		bool flag9 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		while (true)
		{
			int num = -1368569258;
			while (true)
			{
				uint num2;
				string s;
				int num49;
				switch ((num2 = (uint)num ^ 0x8A9D21B7u) % 156u)
				{
				case 155u:
					flag15 = flag5;
					num = -998865098;
					continue;
				case 154u:
				{
					int num50;
					if (c2 == 'n')
					{
						num = -732528850;
						num50 = -732528850;
					}
					else
					{
						num = -1494302860;
						num50 = -1494302860;
					}
					continue;
				}
				case 153u:
				{
					int num59;
					int num60;
					if (!flag4)
					{
						num59 = 1517435677;
						num60 = 1517435677;
					}
					else
					{
						num59 = 751852048;
						num60 = 751852048;
					}
					num = num59 ^ ((int)num2 * -734424482);
					continue;
				}
				case 152u:
					c = JSONNode.smethod_2(aJSON, num5);
					num = ((int)num2 * -1803910166) ^ 0x54727C47;
					continue;
				case 151u:
					text = "";
					text2 = "";
					flag2 = stack.Count > 0;
					num = -676586122;
					continue;
				case 1u:
				case 20u:
				case 43u:
				case 119u:
				case 150u:
					num5++;
					num = -1157157320;
					continue;
				case 149u:
					jSONNode.Add(text2);
					num = ((int)num2 * -794806601) ^ 0x1044AAFD;
					continue;
				case 148u:
				{
					int num41;
					int num42;
					if (flag11)
					{
						num41 = -733454969;
						num42 = -733454969;
					}
					else
					{
						num41 = -90203509;
						num42 = -90203509;
					}
					num = num41 ^ ((int)num2 * -1773600815);
					continue;
				}
				case 147u:
					flag17 = flag5;
					num = -2037902242;
					continue;
				case 146u:
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -303035124) ^ 0x19CFB9C4;
					continue;
				case 145u:
					flag13 = jSONNode != null;
					num = (int)(num2 * 643737040) ^ -1872236509;
					continue;
				case 144u:
					flag16 = JSONNode.smethod_6(text2, "");
					num = -5263877;
					continue;
				case 143u:
					c5 = c3;
					num = (int)(num2 * 603097631) ^ -695165230;
					continue;
				case 142u:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -135058623;
					continue;
				case 141u:
					num = (int)(num2 * 698653109) ^ -1304763005;
					continue;
				case 140u:
					num = (int)(num2 * 481198797) ^ -1724484805;
					continue;
				case 139u:
					num = (int)((num2 * 97255231) ^ 0x5D324DE6);
					continue;
				case 138u:
					num = (int)(num2 * 1165499488) ^ -277108904;
					continue;
				case 137u:
					num5 = 0;
					num = ((int)num2 * -1778358405) ^ -1017494217;
					continue;
				case 136u:
					goto IL_01e7;
				case 135u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -402407029;
					continue;
				case 134u:
					text = JSONNode.smethod_5(text);
					flag11 = jSONNode is JSONArray;
					num = (int)(num2 * 1831092546) ^ -1362269221;
					continue;
				case 133u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1303026361) ^ -233889251;
					continue;
				case 132u:
				{
					c2 = c5;
					int num63;
					int num64;
					if ((uint)c2 > 102u)
					{
						num63 = 3248885;
						num64 = 3248885;
					}
					else
					{
						num63 = 1296115902;
						num64 = 1296115902;
					}
					num = num63 ^ ((int)num2 * -648309937);
					continue;
				}
				case 131u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -798757606) ^ -405126801;
					continue;
				case 130u:
				{
					int num58;
					if (c4 == ' ')
					{
						num = -702928549;
						num58 = -702928549;
					}
					else
					{
						num = -476129965;
						num58 = -476129965;
					}
					continue;
				}
				case 129u:
					num = (int)((num2 * 790797010) ^ 0x7BBB79C8);
					continue;
				case 128u:
					num = (int)(num2 * 1984064959) ^ -531984097;
					continue;
				case 127u:
					text2 = "";
					num = ((int)num2 * -676663658) ^ 0x11202432;
					continue;
				case 126u:
					num = (int)((num2 * 956901744) ^ 0x2153D372);
					continue;
				case 125u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1985395263) ^ 0xECC0D11;
					continue;
				case 124u:
					num = ((int)num2 * -1816749520) ^ -1052773071;
					continue;
				case 123u:
					num = ((int)num2 * -1895167388) ^ 0x6AA3C06;
					continue;
				case 122u:
					switch (c4)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_037e;
					case '\t':
						goto IL_0391;
					case '\v':
					case '\f':
						goto IL_03b1;
					}
					goto case 1u;
				case 12u:
					goto IL_0391;
				case 99u:
					goto IL_03b1;
				case 120u:
					num = -218897643;
					continue;
				case 118u:
					num = (int)((num2 * 637882444) ^ 0x29E2318B);
					continue;
				case 117u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 1706445454) ^ 0x22F5AD91);
					continue;
				case 115u:
					result = jSONNode;
					num = -1701843394;
					continue;
				case 114u:
				{
					int num43;
					if (c4 == '}')
					{
						num = -587241168;
						num43 = -587241168;
					}
					else
					{
						num = -1904633371;
						num43 = -1904633371;
					}
					continue;
				}
				case 113u:
					num = (int)((num2 * 425988542) ^ 0x4A972A96);
					continue;
				case 112u:
				{
					c4 = c;
					int num35;
					int num36;
					if ((uint)c4 <= 44u)
					{
						num35 = -422962204;
						num36 = -422962204;
					}
					else
					{
						num35 = -471228275;
						num36 = -471228275;
					}
					num = num35 ^ (int)(num2 * 1024722244);
					continue;
				}
				case 111u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -433750841;
					continue;
				case 110u:
					num = ((int)num2 * -1408245093) ^ 0x3AA09769;
					continue;
				case 109u:
				{
					int num30;
					int num31;
					if (flag17)
					{
						num30 = -815974905;
						num31 = -815974905;
					}
					else
					{
						num30 = -1594114497;
						num31 = -1594114497;
					}
					num = num30 ^ (int)(num2 * 1620214512);
					continue;
				}
				case 108u:
					num = ((int)num2 * -1490490825) ^ -2115492393;
					continue;
				case 107u:
				{
					int num24;
					int num25;
					if (flag8)
					{
						num24 = -797954508;
						num25 = -797954508;
					}
					else
					{
						num24 = -1098050625;
						num25 = -1098050625;
					}
					num = num24 ^ ((int)num2 * -1627295914);
					continue;
				}
				case 106u:
					num = (int)((num2 * 217589723) ^ 0x54BDB415);
					continue;
				case 105u:
					num = ((int)num2 * -1715678287) ^ -1626230621;
					continue;
				case 104u:
				{
					int num18;
					int num19;
					if (flag13)
					{
						num18 = -1379579795;
						num19 = -1379579795;
					}
					else
					{
						num18 = -1928834527;
						num19 = -1928834527;
					}
					num = num18 ^ ((int)num2 * -1069460484);
					continue;
				}
				case 103u:
				{
					int num15;
					int num16;
					if (flag6)
					{
						num15 = 767061217;
						num16 = 767061217;
					}
					else
					{
						num15 = 978504392;
						num16 = 978504392;
					}
					num = num15 ^ ((int)num2 * -1569971515);
					continue;
				}
				case 102u:
					num = ((int)num2 * -666871986) ^ -633292226;
					continue;
				case 101u:
					num = (int)((num2 * 1218435582) ^ 0xECE44CD);
					continue;
				case 100u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 11794276) ^ 0x5CD3A552);
					continue;
				case 98u:
					num = ((int)num2 * -1920988975) ^ 0x2281914D;
					continue;
				case 97u:
					flag8 = flag5;
					num = -953391860;
					continue;
				case 96u:
					num = ((int)num2 * -252376230) ^ -1574402711;
					continue;
				case 95u:
					num = ((int)num2 * -42636553) ^ -1086362904;
					continue;
				case 94u:
					num = (int)((num2 * 815838100) ^ 0x3133AFC5);
					continue;
				case 93u:
					num = (int)((num2 * 656263820) ^ 0x5A2274E);
					continue;
				case 92u:
				{
					int num6;
					if (c2 == 'f')
					{
						num = -149066752;
						num6 = -149066752;
					}
					else
					{
						num = -681011506;
						num6 = -681011506;
					}
					continue;
				}
				case 91u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -2089713159) ^ -587822699;
					continue;
				case 90u:
				{
					int num61;
					int num62;
					if (!flag14)
					{
						num61 = 1728977215;
						num62 = 1728977215;
					}
					else
					{
						num61 = 607165444;
						num62 = 607165444;
					}
					num = num61 ^ (int)(num2 * 1724250450);
					continue;
				}
				case 89u:
				{
					int num56;
					int num57;
					if (flag2)
					{
						num56 = -540819675;
						num57 = -540819675;
					}
					else
					{
						num56 = -1777410441;
						num57 = -1777410441;
					}
					num = num56 ^ ((int)num2 * -1247730189);
					continue;
				}
				case 88u:
					flag18 = stack.Count == 0;
					num = -1470736275;
					continue;
				case 87u:
					num5 += 4;
					num = (int)(num2 * 1461757852) ^ -1507793758;
					continue;
				case 86u:
					num = (int)(num2 * 1038362521) ^ -1249315427;
					continue;
				case 85u:
				{
					int num54;
					int num55;
					if (flag9)
					{
						num54 = -1147110213;
						num55 = -1147110213;
					}
					else
					{
						num54 = -1384937234;
						num55 = -1384937234;
					}
					num = num54 ^ ((int)num2 * -283518881);
					continue;
				}
				case 84u:
					num = (int)((num2 * 657556504) ^ 0x45113298);
					continue;
				case 83u:
				{
					int num52;
					int num53;
					if ((uint)c4 > 32u)
					{
						num52 = 56363757;
						num53 = 56363757;
					}
					else
					{
						num52 = 1395091328;
						num53 = 1395091328;
					}
					num = num52 ^ (int)(num2 * 1157236467);
					continue;
				}
				case 82u:
					stack.Pop();
					flag = JSONNode.smethod_6(text2, "");
					num = -1392418115;
					continue;
				case 81u:
					num = (int)(num2 * 221729896) ^ -561734557;
					continue;
				case 80u:
					num = -1427653000;
					continue;
				case 79u:
				{
					int num51;
					if (c4 == '"')
					{
						num = -1421738628;
						num51 = -1421738628;
					}
					else
					{
						num = -1242252130;
						num51 = -1242252130;
					}
					continue;
				}
				case 78u:
				{
					int num47;
					int num48;
					if (flag18)
					{
						num47 = -803671676;
						num48 = -803671676;
					}
					else
					{
						num47 = -1804269777;
						num48 = -1804269777;
					}
					num = num47 ^ ((int)num2 * -230527751);
					continue;
				}
				case 77u:
				{
					int num46;
					if (c4 == '{')
					{
						num = -1572847162;
						num46 = -1572847162;
					}
					else
					{
						num = -743405598;
						num46 = -743405598;
					}
					continue;
				}
				case 75u:
				{
					int num44;
					int num45;
					if (c4 == ':')
					{
						num44 = -1489769306;
						num45 = -1489769306;
					}
					else
					{
						num44 = -996152492;
						num45 = -996152492;
					}
					num = num44 ^ ((int)num2 * -2106754200);
					continue;
				}
				case 74u:
					text = text2;
					text2 = "";
					num = -793505902;
					continue;
				case 73u:
				{
					int num39;
					int num40;
					if (c2 == 'b')
					{
						num39 = -145143826;
						num40 = -145143826;
					}
					else
					{
						num39 = -1905199607;
						num40 = -1905199607;
					}
					num = num39 ^ ((int)num2 * -1807735630);
					continue;
				}
				case 72u:
				{
					int num37;
					int num38;
					if (jSONNode is JSONArray)
					{
						num37 = 1685283862;
						num38 = 1685283862;
					}
					else
					{
						num37 = 1606471009;
						num38 = 1606471009;
					}
					num = num37 ^ (int)(num2 * 146000270);
					continue;
				}
				case 71u:
				{
					int num34;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -1870568846;
						num34 = -1870568846;
					}
					else
					{
						num = -1398332201;
						num34 = -1398332201;
					}
					continue;
				}
				case 70u:
					text = "";
					num = -1176949056;
					continue;
				case 69u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1956125422) ^ 0x296DB34E);
					continue;
				case 68u:
					flag7 = JSONNode.smethod_6(text, "");
					num = -239891812;
					continue;
				case 67u:
					text2 = "";
					num = (int)(num2 * 1121815033) ^ -465980833;
					continue;
				case 66u:
					num = (int)((num2 * 1829636908) ^ 0x8930479);
					continue;
				case 65u:
				{
					int num32;
					int num33;
					if (!(jSONNode is JSONArray))
					{
						num32 = 1942478577;
						num33 = 1942478577;
					}
					else
					{
						num32 = 100083302;
						num33 = 100083302;
					}
					num = num32 ^ (int)(num2 * 1790872605);
					continue;
				}
				case 64u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -694370090) ^ -1675240786;
					continue;
				case 63u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 550976568) ^ -265115494;
					continue;
				case 62u:
					num = -1139175727;
					continue;
				case 61u:
					num = ((int)num2 * -934853711) ^ -112543468;
					continue;
				case 60u:
					num = ((int)num2 * -1299352446) ^ 0x1740C2C7;
					continue;
				case 59u:
				{
					int num28;
					int num29;
					if (!flag12)
					{
						num28 = 320541598;
						num29 = 320541598;
					}
					else
					{
						num28 = 1934845813;
						num29 = 1934845813;
					}
					num = num28 ^ (int)(num2 * 2100115782);
					continue;
				}
				case 57u:
					stack.Push(new JSONClass());
					num = -856923635;
					continue;
				case 56u:
				{
					int num26;
					int num27;
					if (!flag16)
					{
						num26 = 1549570755;
						num27 = 1549570755;
					}
					else
					{
						num26 = 188699133;
						num27 = 188699133;
					}
					num = num26 ^ (int)(num2 * 1533955872);
					continue;
				}
				case 55u:
					flag5 = !flag5;
					num = -793505902;
					continue;
				case 54u:
					text2 = "";
					num = (int)((num2 * 1638103409) ^ 0x47C2F5F8);
					continue;
				case 53u:
				{
					int num22;
					int num23;
					if (flag15)
					{
						num22 = -2012727952;
						num23 = -2012727952;
					}
					else
					{
						num22 = -1060555443;
						num23 = -1060555443;
					}
					num = num22 ^ ((int)num2 * -816721545);
					continue;
				}
				case 52u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -566854667) ^ 0x2D7F8131;
					continue;
				case 51u:
					num = ((int)num2 * -1885675093) ^ -235261103;
					continue;
				case 50u:
					num = (int)((num2 * 440402863) ^ 0x29D9A1A1);
					continue;
				case 49u:
				{
					int num21;
					if (c4 != ',')
					{
						num = -834100841;
						num21 = -834100841;
					}
					else
					{
						num = -1103338848;
						num21 = -1103338848;
					}
					continue;
				}
				case 48u:
					num = -2143046091;
					continue;
				case 47u:
				{
					int num20;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -1432159741;
						num20 = -1432159741;
					}
					else
					{
						num = -1100029409;
						num20 = -1100029409;
					}
					continue;
				}
				case 46u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 710925814) ^ 0x6BCB5334);
					continue;
				case 45u:
					num = (int)(num2 * 1561730368) ^ -764265487;
					continue;
				case 44u:
					text = "";
					num = -1329021927;
					continue;
				case 42u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -581437770) ^ 0x660090E;
					continue;
				case 41u:
					switch (c4)
					{
					case '[':
						break;
					case '\\':
						goto IL_01e7;
					default:
						goto IL_0bd2;
					case ']':
						goto IL_0bdc;
					}
					goto case 155u;
				case 19u:
					goto IL_0bdc;
				case 40u:
					c3 = JSONNode.smethod_2(aJSON, num5);
					num = ((int)num2 * -1326912397) ^ -125054916;
					continue;
				case 39u:
					num = ((int)num2 * -37316870) ^ 0x3C7738C4;
					continue;
				case 38u:
				{
					int num17;
					if ((uint)c4 <= 93u)
					{
						num = -1532197544;
						num17 = -1532197544;
					}
					else
					{
						num = -949675530;
						num17 = -949675530;
					}
					continue;
				}
				case 37u:
					num = -34597997;
					continue;
				case 36u:
					flag12 = flag5;
					num = ((int)num2 * -487211326) ^ 0x47D1E360;
					continue;
				case 35u:
					goto IL_0c5c;
				case 34u:
					text = "";
					text2 = "";
					num = -184250943;
					continue;
				case 33u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 1529303364) ^ -204412935;
					continue;
				case 32u:
					num = -803705021;
					continue;
				case 31u:
					num = ((int)num2 * -1344197347) ^ 0x343D4F6E;
					continue;
				case 30u:
				{
					int num13;
					int num14;
					if (flag10)
					{
						num13 = -1687993540;
						num14 = -1687993540;
					}
					else
					{
						num13 = -212122138;
						num14 = -212122138;
					}
					num = num13 ^ ((int)num2 * -1423989082);
					continue;
				}
				case 29u:
					flag10 = flag5;
					num = -948931175;
					continue;
				case 28u:
					flag9 = jSONNode != null;
					num = ((int)num2 * -61208390) ^ -498067766;
					continue;
				case 27u:
					num = (int)(num2 * 1106415751) ^ -1031081970;
					continue;
				case 26u:
					goto IL_0d2d;
				case 25u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -819412685;
					continue;
				case 24u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = -1030280589;
						num12 = -1030280589;
					}
					else
					{
						num11 = -991290939;
						num12 = -991290939;
					}
					num = num11 ^ ((int)num2 * -760040283);
					continue;
				}
				case 23u:
				{
					int num9;
					int num10;
					if (flag7)
					{
						num9 = -280202157;
						num10 = -280202157;
					}
					else
					{
						num9 = -2024569362;
						num10 = -2024569362;
					}
					num = num9 ^ ((int)num2 * -1366350659);
					continue;
				}
				case 22u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -291263893) ^ -1276683444;
					continue;
				case 21u:
					num = ((int)num2 * -1659408842) ^ 0x7777241D;
					continue;
				case 18u:
					flag6 = JSONNode.smethod_6(text, "");
					num = -1341370488;
					continue;
				case 17u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1204784348) ^ -105915599;
					continue;
				case 16u:
					num = (int)(num2 * 543845909) ^ -2083471572;
					continue;
				case 15u:
					num = (int)(num2 * 1094951083) ^ -1509007504;
					continue;
				case 14u:
					num = ((int)num2 * -1606682699) ^ -1543599615;
					continue;
				case 13u:
					stack.Push(new JSONArray());
					num = -1090220690;
					continue;
				case 11u:
					text = "";
					flag5 = false;
					num = (int)(num2 * 1794090784) ^ -89694643;
					continue;
				case 10u:
					goto IL_0eb2;
				case 9u:
					num = ((int)num2 * -117454974) ^ 0x5E6F1057;
					continue;
				case 8u:
					jSONNode.Add(text2);
					num = (int)(num2 * 732722909) ^ -886985189;
					continue;
				case 7u:
					num = ((int)num2 * -1197656820) ^ -1931734902;
					continue;
				case 6u:
					switch (c2)
					{
					case 'r':
						break;
					case 't':
						goto IL_0c5c;
					case 'u':
						goto IL_0d2d;
					case 's':
						goto IL_0eb2;
					default:
						goto IL_0f29;
					}
					goto case 142u;
				case 5u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 552050482) ^ 0x3DB98B45);
					continue;
				case 4u:
					flag4 = num5 < JSONNode.smethod_4(aJSON);
					num = -561065118;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 2024272017;
						num8 = 2024272017;
					}
					else
					{
						num7 = 229793723;
						num8 = 229793723;
					}
					num = num7 ^ ((int)num2 * -1293120965);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2111744149;
						num4 = 2111744149;
					}
					else
					{
						num3 = 1489855186;
						num4 = 1489855186;
					}
					num = num3 ^ (int)(num2 * 1012157073);
					continue;
				}
				case 0u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1446027504) ^ -1417091419;
					continue;
				case 58u:
					break;
				case 116u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 121u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0f29:
					num = -256810936;
					continue;
					IL_0eb2:
					text2 = JSONNode.smethod_3(text2, c3.ToString());
					num = -402407029;
					continue;
					IL_0d2d:
					s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = -895239008;
					continue;
					IL_0c5c:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -94342063;
					continue;
					IL_0bdc:
					flag14 = flag5;
					num = -179457023;
					continue;
					IL_0bd2:
					num = -1725437458;
					continue;
					IL_01e7:
					num5++;
					num = -1306551161;
					continue;
					IL_0391:
					if (flag5)
					{
						num = -1728353982;
						num49 = -1728353982;
					}
					else
					{
						num = -1186462556;
						num49 = -1186462556;
					}
					continue;
					IL_03b1:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = -1699508083;
					continue;
					IL_037e:
					num = ((int)num2 * -1870025624) ^ 0x2EB7302;
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
			int num = -1093221749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8119E89u) % 4u)
				{
				case 3u:
					Serialize(aWriter);
					num = (int)(num2 * 332660694) ^ -404070554;
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -2128225600) ^ -1725697190;
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
				int num = -2004401693;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA426F9E9u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1868440902) ^ 0x7D6719F4;
						continue;
					case 1u:
						num = (int)((num2 * 842794411) ^ 0x5B88BE9E);
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
					int num3 = -87712300;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xA426F9E9u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1602487479) ^ -351557244;
							continue;
						case 0u:
							num3 = ((int)num2 * -145932730) ^ 0x5C4D84A3;
							continue;
						default:
							goto end_IL_0093;
						case 3u:
							break;
						case 2u:
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
			while (true)
			{
				int num = -1837754674;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF18A10A0u) % 6u)
					{
					case 4u:
						num = (int)((num2 * 914219616) ^ 0x372FFDA9);
						continue;
					case 2u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -146543870) ^ 0x6AAF70E9;
						continue;
					case 1u:
						num = ((int)num2 * -762450266) ^ 0x75CA9F60;
						continue;
					case 0u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)(num2 * 1499442755) ^ -126011194;
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
					IL_00df:
					int num3 = -376008687;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xF18A10A0u) % 4u)
						{
						case 2u:
							num3 = (int)(num2 * 1839211122) ^ -1357271077;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -1077452453) ^ -1624138443;
							continue;
						default:
							goto end_IL_00be;
						case 0u:
							break;
						case 3u:
							goto end_IL_00be;
						}
						goto IL_00df;
						continue;
						end_IL_00be:
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
		bool flag = default(bool);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		int num4 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num3 = default(int);
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num5 = default(int);
		while (true)
		{
			int num = -1758395442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94B75193u) % 33u)
				{
				case 32u:
					num = -203822569;
					continue;
				case 31u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 187527860) ^ 0x56D07F6B);
					continue;
				case 30u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1910417504;
						num9 = -1910417504;
					}
					else
					{
						num8 = -1128373431;
						num9 = -1128373431;
					}
					num = num8 ^ (int)(num2 * 1627796733);
					continue;
				}
				case 29u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = -1012867231;
					continue;
				case 28u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 1753398090) ^ 0x25304354);
					continue;
				case 27u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1898448397) ^ 0x4D7AABB6;
					continue;
				case 26u:
					num4++;
					num = (int)((num2 * 1879345573) ^ 0x7727DE87);
					continue;
				case 25u:
					num = ((int)num2 * -482677498) ^ -1367178732;
					continue;
				case 24u:
					num = (int)(num2 * 933625176) ^ -1836146118;
					continue;
				case 23u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 1335772106) ^ 0x47A9A04B);
					continue;
				case 22u:
					jSONArray.Add(Deserialize(aReader));
					num3++;
					num = -389445220;
					continue;
				case 21u:
					goto IL_0127;
				case 20u:
					goto IL_0139;
				case 19u:
				{
					int num7;
					if (num3 < num6)
					{
						num = -1668589805;
						num7 = -1668589805;
					}
					else
					{
						num = -1381898380;
						num7 = -1381898380;
					}
					continue;
				}
				case 18u:
					num = ((int)num2 * -689399622) ^ 0x5B540902;
					continue;
				case 17u:
					result = jSONClass;
					num = (int)((num2 * 1508329232) ^ 0x505432DF);
					continue;
				case 16u:
					switch (jSONBinaryTag)
					{
					case JSONBinaryTag.FloatValue:
						break;
					case JSONBinaryTag.Class:
						goto IL_0127;
					case JSONBinaryTag.Value:
						goto IL_0139;
					default:
						goto IL_01b8;
					case JSONBinaryTag.Array:
						goto IL_01cb;
					case JSONBinaryTag.IntValue:
						goto IL_01d5;
					case JSONBinaryTag.DoubleValue:
						goto IL_01ec;
					case JSONBinaryTag.BoolValue:
						goto IL_01f6;
					}
					goto case 32u;
				case 8u:
					goto IL_01cb;
				case 14u:
					goto IL_01d5;
				case 10u:
					goto IL_01ec;
				case 1u:
					goto IL_01f6;
				case 12u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -74453474) ^ 0xBC266C3;
					continue;
				case 11u:
					num4 = 0;
					num = ((int)num2 * -1769068766) ^ 0x33B98A91;
					continue;
				case 9u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -1549164712) ^ -1908112874;
					continue;
				case 7u:
					num6 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = ((int)num2 * -2074026032) ^ -105088799;
					continue;
				case 6u:
					result = jSONArray;
					num = ((int)num2 * -487970224) ^ 0x7091C9CA;
					continue;
				case 5u:
					num = (int)((num2 * 435222736) ^ 0xB268C1B);
					continue;
				case 4u:
					flag = num4 < num5;
					num = -646865518;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -352416594) ^ -2013807648;
					continue;
				case 0u:
					num = ((int)num2 * -720241524) ^ -1429991158;
					continue;
				case 3u:
					break;
				case 13u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_01f6:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1304246546;
					continue;
					IL_01ec:
					num = -1487452456;
					continue;
					IL_01d5:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -556742662;
					continue;
					IL_01cb:
					num = -951848069;
					continue;
					IL_01b8:
					num = ((int)num2 * -973716170) ^ 0x3AB10BF;
					continue;
					IL_0139:
					num = -280014547;
					continue;
					IL_0127:
					num5 = JSONNode.smethod_21(aReader);
					num = -751811133;
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
					int num = -1344773952;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xE6C0F213u) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = (int)(num2 * 1692133144) ^ -880476353;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1542398832;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6AE5CB0u) % 3u)
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
					num = (int)(num2 * 1961335709) ^ -576265140;
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
					int num3 = -964756211;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xC6AE5CB0u) % 4u)
						{
						case 3u:
							num3 = ((int)num2 * -1115685582) ^ 0x15BECCB0;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)((num2 * 278200499) ^ 0x4BF4A20C);
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
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = -2140164086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD5770C6u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 2138129306) ^ 0x60376867);
					continue;
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)(num2 * 289414484) ^ -80163088;
					continue;
				case 3u:
					num = (int)((num2 * 848880280) ^ 0x5A69F71);
					continue;
				case 2u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -778435835) ^ 0x51E4F4FB;
					continue;
				case 1u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -954637315) ^ 0x692840B4;
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
