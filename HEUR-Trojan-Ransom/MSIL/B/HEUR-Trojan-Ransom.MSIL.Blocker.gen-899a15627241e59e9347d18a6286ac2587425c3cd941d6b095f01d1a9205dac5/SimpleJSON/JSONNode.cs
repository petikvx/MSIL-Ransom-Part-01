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
				int num = -1306266464;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFDD46C7u) % 3u)
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
					num = ((int)num2 * -1332851428) ^ 0x13770CF9;
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
				int num = -1056843302;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4F529E8u) % 4u)
					{
					case 2u:
						result = null;
						num = ((int)num2 * -1822073535) ^ 0x7C3FD1DB;
						continue;
					case 1u:
						num = (int)((num2 * 265042823) ^ 0x51FD2FB7);
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
				int num = -1483763369;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE975BB7Au) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1756594534) ^ 0x6B863012;
						continue;
					case 1u:
						result = "";
						num = ((int)num2 * -1182124040) ^ 0x150457A8;
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
				int num = 934598141;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5A8F1A22u) % 3u)
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
					num = (int)(num2 * 299670221) ^ -1233743583;
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
				int num = 2073879733;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x184A062Au) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return _003Cget_Childs_003Ed__;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					num = ((int)num2 * -1870408632) ^ 0x2F553371;
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
				int num = -922622756;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x926BCC9Du) % 3u)
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
					num = (int)((num2 * 913392327) ^ 0x1513AD32);
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
			bool flag = default(bool);
			while (true)
			{
				int num = -1610532252;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82F6E2FAu) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1424416926) ^ 0xC5B7EAA);
						continue;
					case 6u:
						result2 = 0;
						num = ((int)num2 * -1813675347) ^ 0x629D28AD;
						continue;
					case 5u:
						result = 0;
						num = -156871795;
						continue;
					case 3u:
						result = result2;
						num = (int)((num2 * 605049563) ^ 0x4E1BFB41);
						continue;
					case 1u:
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 1570938375) ^ 0x5BF55C7D);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1825327279;
							num4 = -1825327279;
						}
						else
						{
							num3 = -1805889313;
							num4 = -1805889313;
						}
						num = num3 ^ (int)(num2 * 282512965);
						continue;
					}
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
			while (true)
			{
				int num = 102352423;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F313082u) % 3u)
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
					num = (int)(num2 * 1229816461) ^ -294764399;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			bool flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
			float result2 = default(float);
			while (true)
			{
				int num = -1791951033;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8EDBE9B3u) % 5u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1277744159;
							num4 = 1277744159;
						}
						else
						{
							num3 = 112914870;
							num4 = 112914870;
						}
						num = num3 ^ ((int)num2 * -1252303281);
						continue;
					}
					case 2u:
						result2 = result;
						num = ((int)num2 * -1241623198) ^ 0x2CA5A1E4;
						continue;
					case 1u:
						result2 = 0f;
						num = -1879542748;
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
			while (true)
			{
				int num = -1247939536;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF81BB269u) % 4u)
					{
					case 1u:
						Value = value.ToString();
						num = (int)(num2 * 932842484) ^ -41408127;
						continue;
					case 0u:
						num = ((int)num2 * -730107630) ^ 0x373BCD4A;
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
	}

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			bool flag = default(bool);
			double result = default(double);
			while (true)
			{
				int num = -770931535;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9F18BB67u) % 8u)
					{
					case 6u:
						result2 = 0.0;
						num = (int)((num2 * 1320663167) ^ 0x4D73F524);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -2132377849;
							num4 = -2132377849;
						}
						else
						{
							num3 = -936568445;
							num4 = -936568445;
						}
						num = num3 ^ (int)(num2 * 342880256);
						continue;
					}
					case 4u:
						result = 0.0;
						num = -1661695275;
						continue;
					case 2u:
						num = ((int)num2 * -472049423) ^ 0x1A1D570E;
						continue;
					case 1u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -320393086) ^ -244403288;
						continue;
					case 0u:
						result = result2;
						num = ((int)num2 * -197546295) ^ 0x30F130FC;
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
			while (true)
			{
				int num = 904777564;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4026D3A6u) % 3u)
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
					num = ((int)num2 * -1457595351) ^ -915160261;
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
			bool flag = default(bool);
			while (true)
			{
				int num = 1032432940;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E4D18E2u) % 6u)
					{
					case 4u:
						result = result2;
						num = (int)(num2 * 1469995989) ^ -1649544027;
						continue;
					case 3u:
						result = !JSONNode.smethod_1(Value);
						num = 2037659431;
						continue;
					case 2u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = (int)((num2 * 1128054807) ^ 0x51F99601);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 796968334;
							num4 = 796968334;
						}
						else
						{
							num3 = 277578421;
							num4 = 277578421;
						}
						num = num3 ^ ((int)num2 * -1473126835);
						continue;
					}
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
				int num = -2082647466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB943275Eu) % 3u)
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
					num = (int)(num2 * 1564833671) ^ -1837201681;
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
				int num = -1110273807;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x98BAF214u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 747349375) ^ 0x5E7807AE);
						continue;
					case 1u:
						result = this as JSONClass;
						num = ((int)num2 * -1908107661) ^ -2096278687;
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
			int num = 288865810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51FBF43Du) % 3u)
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
				num = (int)(num2 * 883055000) ^ -614931936;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -459606144;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x933C26B1u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1851356614) ^ 0x12EED199;
					continue;
				case 1u:
					result = null;
					num = (int)(num2 * 687232856) ^ -462006178;
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
			int num = -1660345287;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE2960DB8u) % 4u)
				{
				case 1u:
					result = aNode;
					num = (int)((num2 * 1111203265) ^ 0x60A914A1);
					continue;
				case 0u:
					num = ((int)num2 * -506836941) ^ -2095700922;
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
			int num = 1854112651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE000210u) % 3u)
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
				num = (int)((num2 * 643508897) ^ 0x42ED231A);
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
			int num = -751392037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0FD5765u) % 3u)
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
				result = new JSONData(s);
				num = (int)(num2 * 1099172260) ^ -471023443;
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
		IL_0047:
		string result = (string)obj;
		int num = -1166094240;
		goto IL_0020;
		IL_001b:
		num = -28373618;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xE2003B0Bu) % 4u)
			{
			case 3u:
				num = ((int)num2 * -1634675269) ^ 0x7208D8B0;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_001b;
		IL_0041:
		obj = d.Value;
		goto IL_0047;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b == null)
		{
			goto IL_0047;
		}
		int num = 0;
		goto IL_007e;
		IL_0075:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_007e;
		IL_0047:
		int num2 = -738524537;
		goto IL_004c;
		IL_004c:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xE174D53Cu) % 6u)
			{
			case 5u:
				result = true;
				num2 = (int)(num3 * 1804072403) ^ -1413907112;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1977150936;
					num5 = 1977150936;
				}
				else
				{
					num4 = 388658463;
					num5 = 388658463;
				}
				num2 = num4 ^ (int)(num3 * 1836092648);
				continue;
			}
			case 2u:
				result = (object)a == b;
				num2 = -1292017007;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0075;
			default:
				return result;
			}
			break;
		}
		goto IL_0047;
		IL_007e:
		flag = (byte)num != 0;
		num2 = -490371090;
		goto IL_004c;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1118099082;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAFDE2D9u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = ((int)num2 * -130108207) ^ -1198183893;
					continue;
				case 1u:
					num = ((int)num2 * -193263285) ^ 0x768F808;
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
			int num = 1170394416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68F1685u) % 3u)
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
				num = ((int)num2 * -405486308) ^ -1217046954;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = 1303952441;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14B6339u) % 3u)
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
				num = ((int)num2 * -1299748714) ^ -23512407;
			}
		}
	}

	internal static string Escape(string aText)
	{
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		char c3 = default(char);
		char c = default(char);
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -1542394382;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9997CFE5u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -568665259) ^ 0x442C8068;
					continue;
				case 28u:
					num = ((int)num2 * -288782381) ^ -946485095;
					continue;
				case 27u:
					num = ((int)num2 * -2019159011) ^ -1293759439;
					continue;
				case 25u:
					c2 = JSONNode.smethod_2(string_, num3);
					c3 = c2;
					num = -1448317673;
					continue;
				case 24u:
					num = ((int)num2 * -1758586129) ^ 0x1D26E8D1;
					continue;
				case 23u:
				{
					int num6;
					if (c == '\\')
					{
						num = -2077760667;
						num6 = -2077760667;
					}
					else
					{
						num = -1823823144;
						num6 = -1823823144;
					}
					continue;
				}
				case 22u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -95210399;
					continue;
				case 21u:
					text = JSONNode.smethod_3(text, "\\t");
					num = -665086701;
					continue;
				case 20u:
					num3++;
					num = -1071862908;
					continue;
				case 19u:
					num = (int)(num2 * 853203060) ^ -1894831433;
					continue;
				case 18u:
					num = (int)(num2 * 1377592716) ^ -918604509;
					continue;
				case 17u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -91447486) ^ -568783309;
					continue;
				case 16u:
					c = c3;
					switch (c)
					{
					case '\t':
						break;
					default:
						goto IL_0125;
					case '\b':
						goto IL_0138;
					case '\n':
						goto IL_014e;
					case '\v':
						goto IL_0164;
					case '\f':
						goto IL_017c;
					case '\r':
						goto IL_0192;
					}
					goto case 21u;
				case 14u:
					goto IL_0138;
				case 9u:
					goto IL_014e;
				case 8u:
					goto IL_0164;
				case 1u:
					goto IL_017c;
				case 7u:
					goto IL_0192;
				case 15u:
					result = text;
					num = ((int)num2 * -1896948501) ^ 0x67FF1FB8;
					continue;
				case 13u:
					text = "";
					num = ((int)num2 * -987740511) ^ 0x394FEDE1;
					continue;
				case 11u:
				{
					int num5;
					if (c != '"')
					{
						num = -1943181348;
						num5 = -1943181348;
					}
					else
					{
						num = -1383508995;
						num5 = -1383508995;
					}
					continue;
				}
				case 10u:
					num = (int)((num2 * 1844749242) ^ 0xFDD54E4);
					continue;
				case 6u:
					num = (int)((num2 * 1216196055) ^ 0x71EAD447);
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -827010894;
						num4 = -827010894;
					}
					else
					{
						num = -550963728;
						num4 = -550963728;
					}
					continue;
				}
				case 4u:
					num = (int)((num2 * 1184934001) ^ 0x4E2D6928);
					continue;
				case 3u:
					num = ((int)num2 * -370512463) ^ 0x680E9398;
					continue;
				case 2u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1101870888;
					continue;
				case 0u:
					num = (int)((num2 * 262245860) ^ 0x2AEC3B8B);
					continue;
				case 26u:
					break;
				default:
					{
						return result;
					}
					IL_0192:
					text = JSONNode.smethod_3(text, "\\r");
					num = -470279895;
					continue;
					IL_017c:
					text = JSONNode.smethod_3(text, "\\f");
					num = -665086701;
					continue;
					IL_0164:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -780492821;
					continue;
					IL_014e:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1676574102;
					continue;
					IL_0138:
					text = JSONNode.smethod_3(text, "\\b");
					num = -622819661;
					continue;
					IL_0125:
					num = (int)((num2 * 602096382) ^ 0x454A25B1);
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		char c2 = default(char);
		char c5 = default(char);
		int num5 = default(int);
		string text = default(string);
		JSONNode jSONNode = default(JSONNode);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		string text2 = default(string);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		char c = default(char);
		bool flag6 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag5 = default(bool);
		char c3 = default(char);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1492399296;
			while (true)
			{
				uint num2;
				int num31;
				int num35;
				switch ((num2 = (uint)num ^ 0x580B0815u) % 139u)
				{
				case 138u:
				{
					int num12;
					if ((uint)c2 > 93u)
					{
						num = 890127229;
						num12 = 890127229;
					}
					else
					{
						num = 2093400801;
						num12 = 2093400801;
					}
					continue;
				}
				case 136u:
				{
					int num27;
					if (c2 == '"')
					{
						num = 1490147196;
						num27 = 1490147196;
					}
					else
					{
						num = 1292937227;
						num27 = 1292937227;
					}
					continue;
				}
				case 135u:
					c5 = JSONNode.smethod_2(aJSON, num5);
					num = ((int)num2 * -1147207279) ^ -1040150068;
					continue;
				case 134u:
					text = "";
					jSONNode = stack.Peek();
					num = (int)(num2 * 1368020891) ^ -1699987426;
					continue;
				case 133u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = 942274839;
					continue;
				case 132u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -1153553816) ^ -755017097;
					continue;
				case 131u:
					num = (int)(num2 * 569143043) ^ -715118638;
					continue;
				case 130u:
					text = JSONNode.smethod_3(text, "\b");
					num = 1660155486;
					continue;
				case 129u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 215111243) ^ 0x45C94F1C);
					continue;
				case 128u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1663880049) ^ 0x14AF511F;
					continue;
				case 127u:
					text2 = "";
					num = 910054183;
					continue;
				case 126u:
				{
					int num57;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 1746644399;
						num57 = 1746644399;
					}
					else
					{
						num = 317212258;
						num57 = 317212258;
					}
					continue;
				}
				case 125u:
				{
					int num46;
					int num47;
					if (flag7)
					{
						num46 = -399274937;
						num47 = -399274937;
					}
					else
					{
						num46 = -1106583229;
						num47 = -1106583229;
					}
					num = num46 ^ ((int)num2 * -682217257);
					continue;
				}
				case 124u:
					num = ((int)num2 * -2052943348) ^ 0x696BD92F;
					continue;
				case 123u:
				{
					int num38;
					if (stack.Count != 0)
					{
						num = 340602561;
						num38 = 340602561;
					}
					else
					{
						num = 1622690741;
						num38 = 1622690741;
					}
					continue;
				}
				case 122u:
					num = (int)((num2 * 811312095) ^ 0x5EE89541);
					continue;
				case 121u:
					num = (int)((num2 * 1095996844) ^ 0x7FAF970A);
					continue;
				case 120u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 2050491350) ^ 0x39632027);
					continue;
				case 119u:
				{
					int num19;
					int num20;
					if (flag4)
					{
						num19 = -1712606214;
						num20 = -1712606214;
					}
					else
					{
						num19 = -1847987789;
						num20 = -1847987789;
					}
					num = num19 ^ ((int)num2 * -1393901501);
					continue;
				}
				case 118u:
					flag3 = JSONNode.smethod_6(text2, "");
					num = 1812044288;
					continue;
				case 117u:
				{
					int num14;
					int num15;
					if (c2 == ':')
					{
						num14 = 525744988;
						num15 = 525744988;
					}
					else
					{
						num14 = 1145925978;
						num15 = 1145925978;
					}
					num = num14 ^ ((int)num2 * -1028903765);
					continue;
				}
				case 116u:
					text = "";
					num = ((int)num2 * -2001462920) ^ 0x5481939F;
					continue;
				case 115u:
					num = 2070684547;
					continue;
				case 114u:
				{
					int num54;
					int num55;
					if (!(jSONNode is JSONArray))
					{
						num54 = 699634879;
						num55 = 699634879;
					}
					else
					{
						num54 = 800857814;
						num55 = 800857814;
					}
					num = num54 ^ ((int)num2 * -625176297);
					continue;
				}
				case 113u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1195006414) ^ -2111144743;
					continue;
				case 112u:
				{
					string s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num5 += 4;
					num = ((int)num2 * -1930245035) ^ -1383586231;
					continue;
				}
				case 111u:
					text = JSONNode.smethod_3(text, "\t");
					num = 134890854;
					continue;
				case 110u:
				{
					int num48;
					int num49;
					if (!flag)
					{
						num48 = 384919966;
						num49 = 384919966;
					}
					else
					{
						num48 = 1311808458;
						num49 = 1311808458;
					}
					num = num48 ^ ((int)num2 * -1162929397);
					continue;
				}
				case 109u:
					num5 = 0;
					num = (int)(num2 * 1009070096) ^ -1066934027;
					continue;
				case 108u:
					num = (int)((num2 * 685401151) ^ 0x7C730D13);
					continue;
				case 34u:
				case 51u:
				case 54u:
				case 72u:
				case 107u:
					goto IL_0399;
				case 106u:
					text2 = "";
					num = ((int)num2 * -953909348) ^ -561760353;
					continue;
				case 105u:
					text2 = "";
					num = 180875238;
					continue;
				case 104u:
				{
					num5++;
					int num39;
					if (!flag)
					{
						num = 2070684547;
						num39 = 2070684547;
					}
					else
					{
						num = 1155955615;
						num39 = 1155955615;
					}
					continue;
				}
				case 103u:
				{
					int num36;
					if (c == 'n')
					{
						num = 126289419;
						num36 = 126289419;
					}
					else
					{
						num = 1912910737;
						num36 = 1912910737;
					}
					continue;
				}
				case 102u:
					stack.Push(new JSONArray());
					num = 745031753;
					continue;
				case 101u:
					num = ((int)num2 * -1436168250) ^ -41962043;
					continue;
				case 100u:
					num = (int)((num2 * 108038566) ^ 0x297699F4);
					continue;
				case 99u:
					stack.Push(new JSONClass());
					num = 615039925;
					continue;
				case 98u:
					goto IL_0468;
				case 97u:
				{
					int num25;
					int num26;
					if (!flag6)
					{
						num25 = 1687514347;
						num26 = 1687514347;
					}
					else
					{
						num25 = 446199155;
						num26 = 446199155;
					}
					num = num25 ^ ((int)num2 * -175514629);
					continue;
				}
				case 96u:
					jSONNode = null;
					num = ((int)num2 * -1976055550) ^ 0x5F2AB1B;
					continue;
				case 95u:
				{
					int num21;
					int num22;
					if (!JSONNode.smethod_6(text, ""))
					{
						num21 = 1056728833;
						num22 = 1056728833;
					}
					else
					{
						num21 = 1689460557;
						num22 = 1689460557;
					}
					num = num21 ^ (int)(num2 * 665057369);
					continue;
				}
				case 94u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -156534520) ^ -553762161;
					continue;
				case 92u:
					text = "";
					num = (int)(num2 * 1938253041) ^ -2085565540;
					continue;
				case 91u:
				{
					int num10;
					int num11;
					if (jSONNode != null)
					{
						num10 = -1591569664;
						num11 = -1591569664;
					}
					else
					{
						num10 = -1181200901;
						num11 = -1181200901;
					}
					num = num10 ^ ((int)num2 * -2049834196);
					continue;
				}
				case 90u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1553982856) ^ -87843088;
					continue;
				case 89u:
				{
					int num6;
					if (num5 >= JSONNode.smethod_4(aJSON))
					{
						num = 2107523184;
						num6 = 2107523184;
					}
					else
					{
						num = 740315922;
						num6 = 740315922;
					}
					continue;
				}
				case 88u:
					jSONNode.Add(text);
					num = ((int)num2 * -2031524814) ^ -953746080;
					continue;
				case 87u:
					text = "";
					num = (int)(num2 * 8419921) ^ -762142652;
					continue;
				case 86u:
					goto IL_05e7;
				case 85u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -487717146) ^ 0x878682B;
					continue;
				case 84u:
					num = 961647227;
					continue;
				case 83u:
					text2 = JSONNode.smethod_5(text2);
					flag6 = jSONNode is JSONArray;
					num = (int)((num2 * 1482419356) ^ 0x35DADFB5);
					continue;
				case 82u:
					goto IL_065a;
				case 81u:
				{
					int num56;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 275247012;
						num56 = 275247012;
					}
					else
					{
						num = 1281527679;
						num56 = 1281527679;
					}
					continue;
				}
				case 80u:
					text2 = "";
					num = 1173832822;
					continue;
				case 79u:
				{
					int num52;
					int num53;
					if (!(jSONNode != null))
					{
						num52 = 559694614;
						num53 = 559694614;
					}
					else
					{
						num52 = 1764503158;
						num53 = 1764503158;
					}
					num = num52 ^ ((int)num2 * -1418504933);
					continue;
				}
				case 78u:
					num = (int)((num2 * 955949792) ^ 0x23383024);
					continue;
				case 77u:
					num = ((int)num2 * -330766435) ^ -1932780521;
					continue;
				case 76u:
					text2 = text;
					num = 657481578;
					continue;
				case 75u:
					flag = !flag;
					num = 942274839;
					continue;
				case 74u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 20303673) ^ -10307327;
					continue;
				case 73u:
				{
					c2 = c5;
					int num50;
					int num51;
					if ((uint)c2 <= 44u)
					{
						num50 = -242470411;
						num51 = -242470411;
					}
					else
					{
						num50 = -1674395457;
						num51 = -1674395457;
					}
					num = num50 ^ (int)(num2 * 611904821);
					continue;
				}
				case 71u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 1987456270) ^ 0x421E57F3);
					continue;
				case 70u:
					goto IL_078d;
				case 69u:
				{
					int num44;
					int num45;
					if (jSONNode is JSONArray)
					{
						num44 = 1305292918;
						num45 = 1305292918;
					}
					else
					{
						num44 = 1103130361;
						num45 = 1103130361;
					}
					num = num44 ^ (int)(num2 * 366689991);
					continue;
				}
				case 68u:
					num = (int)(num2 * 153638046) ^ -661396308;
					continue;
				case 67u:
					num = ((int)num2 * -1535676467) ^ 0x6C53F9B5;
					continue;
				case 66u:
					result = jSONNode;
					num = 1842798927;
					continue;
				case 65u:
					num = ((int)num2 * -922767022) ^ -1077795529;
					continue;
				case 64u:
					num = ((int)num2 * -1305459958) ^ 0x25FBD0;
					continue;
				case 63u:
				{
					int num43;
					if (c2 == '}')
					{
						num = 1666610132;
						num43 = 1666610132;
					}
					else
					{
						num = 1186165255;
						num43 = 1186165255;
					}
					continue;
				}
				case 62u:
					num = (int)(num2 * 150112871) ^ -1815592354;
					continue;
				case 61u:
				{
					int num41;
					int num42;
					if (!flag3)
					{
						num41 = 1264841319;
						num42 = 1264841319;
					}
					else
					{
						num41 = 604072976;
						num42 = 604072976;
					}
					num = num41 ^ ((int)num2 * -1811810520);
					continue;
				}
				case 59u:
				{
					int num40;
					if (c2 == ',')
					{
						num = 1914390038;
						num40 = 1914390038;
					}
					else
					{
						num = 1517931219;
						num40 = 1517931219;
					}
					continue;
				}
				case 58u:
				{
					int num37;
					if (c2 != '{')
					{
						num = 2018043253;
						num37 = 2018043253;
					}
					else
					{
						num = 1846037426;
						num37 = 1846037426;
					}
					continue;
				}
				case 57u:
					flag5 = flag;
					num = 231064376;
					continue;
				case 56u:
					switch (c2)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_0399;
					case '\t':
						goto IL_065a;
					default:
						goto IL_08fa;
					}
					goto case 133u;
				case 55u:
					num = 2141425357;
					continue;
				case 53u:
					num = ((int)num2 * -2106086299) ^ -1583687818;
					continue;
				case 52u:
					num = (int)((num2 * 959498885) ^ 0x29D622C3);
					continue;
				case 50u:
					jSONNode.Add(text);
					num = (int)((num2 * 1894968644) ^ 0x19EC5C80);
					continue;
				case 49u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1692220783) ^ 0x2651B332);
					continue;
				case 48u:
					flag7 = flag;
					num = 247719325;
					continue;
				case 47u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -154151854) ^ -571071582;
					continue;
				case 46u:
					num = (int)((num2 * 326088949) ^ 0x48B0DE47);
					continue;
				case 45u:
					stack.Pop();
					num = 1194139204;
					continue;
				case 44u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1037229766) ^ -1360086181;
					continue;
				case 43u:
					flag = false;
					num = ((int)num2 * -974050123) ^ -1072343834;
					continue;
				case 42u:
					switch (c2)
					{
					case '\\':
						break;
					case '[':
						goto IL_0468;
					default:
						goto IL_0a1f;
					case ']':
						goto IL_0a29;
					}
					goto case 104u;
				case 13u:
					goto IL_0a29;
				case 41u:
					num = ((int)num2 * -169527412) ^ 0x20902FB3;
					continue;
				case 39u:
				{
					int num34;
					if (c2 == ' ')
					{
						num = 1362211656;
						num34 = 1362211656;
					}
					else
					{
						num = 1586254518;
						num34 = 1586254518;
					}
					continue;
				}
				case 38u:
					num = 1823207265;
					continue;
				case 37u:
					num = ((int)num2 * -1157473198) ^ -2791508;
					continue;
				case 36u:
					num = 2022923560;
					continue;
				case 35u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1251536286) ^ 0x2935CF55;
					continue;
				case 33u:
					switch (c)
					{
					case 't':
						break;
					case 's':
						goto IL_05e7;
					case 'r':
						goto IL_078d;
					default:
						goto IL_0ae0;
					case 'u':
						goto IL_0aea;
					}
					goto case 111u;
				case 7u:
					goto IL_0aea;
				case 32u:
					text = JSONNode.smethod_3(text, "\f");
					num = 1660155486;
					continue;
				case 31u:
					num = (int)((num2 * 807397080) ^ 0x74F5EDDD);
					continue;
				case 30u:
					num = (int)(num2 * 2084601046) ^ -1911276812;
					continue;
				case 29u:
					num = 402950194;
					continue;
				case 28u:
					num = ((int)num2 * -1513805388) ^ 0x540057C7;
					continue;
				case 27u:
					num = ((int)num2 * -464941736) ^ -1405527204;
					continue;
				case 26u:
				{
					int num32;
					int num33;
					if (c == 'b')
					{
						num32 = -975716676;
						num33 = -975716676;
					}
					else
					{
						num32 = -1165342184;
						num33 = -1165342184;
					}
					num = num32 ^ (int)(num2 * 2081071449);
					continue;
				}
				case 25u:
					text2 = "";
					text = "";
					num = 1458175610;
					continue;
				case 24u:
				{
					int num29;
					int num30;
					if ((uint)c2 <= 32u)
					{
						num29 = -325350657;
						num30 = -325350657;
					}
					else
					{
						num29 = -1224691853;
						num30 = -1224691853;
					}
					num = num29 ^ ((int)num2 * -1060973966);
					continue;
				}
				case 23u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 1825249317) ^ 0x633F1242);
					continue;
				case 22u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -2037127967) ^ 0x7AFFF62E;
					continue;
				case 21u:
					num = (int)((num2 * 872485139) ^ 0x18F65C80);
					continue;
				case 20u:
				{
					int num28;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 402950194;
						num28 = 402950194;
					}
					else
					{
						num = 1203593902;
						num28 = 1203593902;
					}
					continue;
				}
				case 19u:
					num = ((int)num2 * -1197197813) ^ -967158416;
					continue;
				case 18u:
					num = ((int)num2 * -793572754) ^ -87171446;
					continue;
				case 17u:
				{
					int num23;
					int num24;
					if (!flag5)
					{
						num23 = 861847662;
						num24 = 861847662;
					}
					else
					{
						num23 = 1415103101;
						num24 = 1415103101;
					}
					num = num23 ^ (int)(num2 * 679378490);
					continue;
				}
				case 16u:
					flag4 = jSONNode is JSONArray;
					num = (int)((num2 * 1315774063) ^ 0x65044A1D);
					continue;
				case 15u:
				{
					c3 = JSONNode.smethod_2(aJSON, num5);
					char c4 = c3;
					c = c4;
					num = (int)(num2 * 1815997643) ^ -1313461799;
					continue;
				}
				case 14u:
				{
					int num17;
					int num18;
					if (stack.Count <= 0)
					{
						num17 = 842157867;
						num18 = 842157867;
					}
					else
					{
						num17 = 1372299406;
						num18 = 1372299406;
					}
					num = num17 ^ (int)(num2 * 363150708);
					continue;
				}
				case 12u:
					num = ((int)num2 * -2084237817) ^ 0x579F07EB;
					continue;
				case 11u:
					num = (int)(num2 * 1513089148) ^ -2053178741;
					continue;
				case 10u:
					text = JSONNode.smethod_3(text, "\n");
					num = 1660155486;
					continue;
				case 9u:
				{
					int num16;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 891948210;
						num16 = 891948210;
					}
					else
					{
						num = 1657316312;
						num16 = 1657316312;
					}
					continue;
				}
				case 8u:
				{
					int num13;
					if (c != 'f')
					{
						num = 569441256;
						num13 = 569441256;
					}
					else
					{
						num = 2107651145;
						num13 = 2107651145;
					}
					continue;
				}
				case 6u:
				{
					int num8;
					int num9;
					if (!flag2)
					{
						num8 = 1560277853;
						num9 = 1560277853;
					}
					else
					{
						num8 = 337487980;
						num9 = 337487980;
					}
					num = num8 ^ ((int)num2 * -1339217172);
					continue;
				}
				case 5u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 309075764) ^ -1082085025;
					continue;
				case 4u:
					text = "";
					num = (int)(num2 * 184767154) ^ -1582094321;
					continue;
				case 3u:
					num = (int)((num2 * 1706701179) ^ 0x305424E8);
					continue;
				case 2u:
					num = (int)((num2 * 1447266569) ^ 0x493E437);
					continue;
				case 1u:
				{
					int num7;
					if (flag)
					{
						num = 368831835;
						num7 = 368831835;
					}
					else
					{
						num = 1353607824;
						num7 = 1353607824;
					}
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if ((uint)c <= 102u)
					{
						num3 = -1593523198;
						num4 = -1593523198;
					}
					else
					{
						num3 = -451735138;
						num4 = -451735138;
					}
					num = num3 ^ ((int)num2 * -82414169);
					continue;
				}
				case 93u:
					break;
				case 60u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 137u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0468:
					if (!flag)
					{
						num = 1903367308;
						num31 = 1903367308;
					}
					else
					{
						num = 45068294;
						num31 = 45068294;
					}
					continue;
					IL_0aea:
					num = 126312110;
					continue;
					IL_0ae0:
					num = 1745839055;
					continue;
					IL_0a29:
					if (flag)
					{
						num = 606066887;
						num35 = 606066887;
					}
					else
					{
						num = 1695165007;
						num35 = 1695165007;
					}
					continue;
					IL_0a1f:
					num = 1101816209;
					continue;
					IL_08fa:
					num = (int)((num2 * 1791514516) ^ 0x6733314B);
					continue;
					IL_0399:
					num5++;
					num = 1574059567;
					continue;
					IL_078d:
					text = JSONNode.smethod_3(text, "\r");
					num = 183049078;
					continue;
					IL_065a:
					flag2 = flag;
					num = 574811494;
					continue;
					IL_05e7:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1063769233;
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
			int num = 633057136;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F15AB3u) % 4u)
				{
				case 3u:
					aWriter = JSONNode.smethod_9(aData);
					num = (int)((num2 * 1406819916) ^ 0x441A099E);
					continue;
				case 1u:
					Serialize(aWriter);
					num = (int)((num2 * 946234734) ^ 0x6D42077B);
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
				int num = -1526610683;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81F10720u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1362372348) ^ 0x13AF039A);
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = ((int)num2 * -1057041964) ^ 0x6A583A3;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00b5:
					int num3 = -290422641;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x81F10720u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -961537200) ^ -1691736560;
							continue;
						case 0u:
							num3 = ((int)num2 * -245652388) ^ -1289239487;
							continue;
						default:
							goto end_IL_0094;
						case 2u:
							break;
						case 1u:
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
				int num = -1090834325;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8EE061FAu) % 6u)
					{
					case 5u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -491035642) ^ -1844324643;
						continue;
					case 2u:
						num = (int)(num2 * 860327288) ^ -1289075665;
						continue;
					case 1u:
						num = (int)(num2 * 1914018498) ^ -554794900;
						continue;
					case 0u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)(num2 * 1555496885) ^ -2146744898;
						continue;
					case 4u:
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
					IL_00cb:
					int num3 = -1214415701;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x8EE061FAu) % 3u)
						{
						case 1u:
							goto IL_009b;
						default:
							goto end_IL_00ae;
						case 2u:
							break;
						case 0u:
							goto end_IL_00ae;
						}
						goto IL_00cb;
						IL_009b:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -828717825) ^ 0xD7EBA72;
						continue;
						end_IL_00ae:
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
		bool flag2 = default(bool);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num3 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num8 = default(int);
		int num10 = default(int);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		int num9 = default(int);
		while (true)
		{
			int num = 315173136;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D26C0AFu) % 39u)
				{
				case 38u:
					num = 1656121550;
					continue;
				case 37u:
					goto IL_0016;
				case 36u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1454835242;
						num7 = 1454835242;
					}
					else
					{
						num6 = 1331038891;
						num7 = 1331038891;
					}
					num = num6 ^ ((int)num2 * -506267974);
					continue;
				}
				case 35u:
					num = (int)((num2 * 830770268) ^ 0xC3793D4);
					continue;
				case 34u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 549409429) ^ -1906516239;
					continue;
				case 33u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.BoolValue:
						break;
					case JSONBinaryTag.FloatValue:
						goto IL_0016;
					default:
						goto IL_009e;
					case JSONBinaryTag.Array:
						goto IL_00b1;
					case JSONBinaryTag.Class:
						goto IL_00c2;
					case JSONBinaryTag.Value:
						goto IL_00db;
					case JSONBinaryTag.IntValue:
						goto IL_00e5;
					case JSONBinaryTag.DoubleValue:
						goto IL_00ef;
					}
					goto case 38u;
				case 13u:
					goto IL_00b1;
				case 16u:
					goto IL_00c2;
				case 10u:
					goto IL_00db;
				case 27u:
					goto IL_00e5;
				case 11u:
					goto IL_00ef;
				case 32u:
				{
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)(num2 * 1503943435) ^ -884906144;
					continue;
				}
				case 31u:
					num3 = 0;
					num = (int)(num2 * 146217487) ^ -1498531194;
					continue;
				case 30u:
					jSONArray.Add(Deserialize(aReader));
					num = 1216777150;
					continue;
				case 29u:
					num = ((int)num2 * -813177590) ^ 0x16E451D0;
					continue;
				case 28u:
					flag2 = num8 < num10;
					num = 570305867;
					continue;
				case 26u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 2094529771) ^ 0x10693148);
					continue;
				case 25u:
					flag = num3 < num9;
					num = 1975527968;
					continue;
				case 24u:
					result = jSONArray;
					num = (int)(num2 * 1837642103) ^ -212282608;
					continue;
				case 23u:
					num8++;
					num = ((int)num2 * -899702961) ^ 0x51CB371A;
					continue;
				case 22u:
					num8 = 0;
					num = ((int)num2 * -1302016275) ^ -997764033;
					continue;
				case 21u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1418875989) ^ -2121657313;
					continue;
				case 20u:
					num = (int)(num2 * 544928048) ^ -801743876;
					continue;
				case 19u:
					num = ((int)num2 * -626783286) ^ 0xC568BB0;
					continue;
				case 18u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1022605446;
						num5 = -1022605446;
					}
					else
					{
						num4 = -1303053079;
						num5 = -1303053079;
					}
					num = num4 ^ ((int)num2 * -987770395);
					continue;
				}
				case 17u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)(num2 * 908708305) ^ -1359856205;
					continue;
				case 14u:
					num = (int)(num2 * 1372305531) ^ -576497760;
					continue;
				case 12u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = 1926972756;
					continue;
				case 9u:
					num = (int)(num2 * 1810023210) ^ -529314613;
					continue;
				case 8u:
					num = (int)((num2 * 661298716) ^ 0x42FD2638);
					continue;
				case 7u:
					num = (int)(num2 * 1509791648) ^ -1858806048;
					continue;
				case 6u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -932888645) ^ 0x77D64834;
					continue;
				case 5u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -685465490) ^ -1179663193;
					continue;
				case 4u:
					num = ((int)num2 * -1212694246) ^ 0x79A7631C;
					continue;
				case 2u:
					result = jSONClass;
					num = ((int)num2 * -900405407) ^ -1091778584;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -41439047) ^ -404354271;
					continue;
				case 0u:
					break;
				case 3u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0016:
					num = 1446413848;
					continue;
					IL_00ef:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 188610479;
					continue;
					IL_00e5:
					num = 710139606;
					continue;
					IL_00db:
					num = 831169360;
					continue;
					IL_00c2:
					num10 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = 870411895;
					continue;
					IL_00b1:
					num9 = JSONNode.smethod_21(aReader);
					num = 32475538;
					continue;
					IL_009e:
					num = (int)(num2 * 231558535) ^ -1020276036;
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
					int num = -1789287887;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xAC8622CBu) % 3u)
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
						num = ((int)num2 * -1173150891) ^ 0x59F538EE;
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
					IL_0045:
					int num = 1104343621;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x37EC25C9u) % 3u)
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
						num = ((int)num2 * -355582701) ^ 0x77745D80;
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -708729005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE3FDD614u) % 3u)
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
				byte[] byte_ = JSONNode.smethod_28(aBase64);
				MemoryStream memoryStream = JSONNode.smethod_29(byte_);
				JSONNode.smethod_17((Stream)memoryStream, 0L);
				result = LoadFromStream(memoryStream);
				num = (int)((num2 * 1985817088) ^ 0x4519611A);
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
