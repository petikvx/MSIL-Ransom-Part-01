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
				int num = -1897448991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA652A4BAu) % 3u)
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
					num = (int)((num2 * 2127472503) ^ 0x6F8ADA7E);
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
				int num = -888638562;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8F13A987u) % 3u)
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
					num = ((int)num2 * -260610230) ^ 0x147EE361;
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
				int num = 31343338;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x470CFF13u) % 3u)
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
					num = (int)(num2 * 1710738487) ^ -1667908961;
				}
			}
		}
		set
		{
		}
	}

	public virtual int Count => 0;

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			while (true)
			{
				int num = -1361092453;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF9D169ADu) % 6u)
					{
					case 4u:
						num = -853140832;
						continue;
					case 1u:
						num = ((int)num2 * -245727012) ^ 0x1171B2C4;
						continue;
					default:
						yield break;
					case 0u:
					case 5u:
						break;
					case 3u:
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
			int result = 0;
			int result2 = default(int);
			while (true)
			{
				int num = -1362166074;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E2C935Cu) % 5u)
					{
					case 3u:
						result2 = 0;
						num = -1901004351;
						continue;
					case 2u:
						result2 = result;
						num = (int)((num2 * 2019642358) ^ 0x413E2B21);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (int.TryParse(Value, out result))
						{
							num3 = -657588938;
							num4 = -657588938;
						}
						else
						{
							num3 = -1146661424;
							num4 = -1146661424;
						}
						num = num3 ^ ((int)num2 * -757597167);
						continue;
					}
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
				int num = -758642446;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAE418DFEu) % 3u)
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
					num = (int)((num2 * 743680015) ^ 0x6C7DB6C);
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
				int num = 1724996971;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x529B0Au) % 8u)
					{
					case 7u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -714524552) ^ -1848939760;
						continue;
					case 6u:
						result = 0f;
						num = 1689182073;
						continue;
					case 5u:
						result = result2;
						num = ((int)num2 * -840283908) ^ 0x39BA61CA;
						continue;
					case 3u:
						num = ((int)num2 * -620471433) ^ 0x5EFC7213;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1247067523;
							num4 = 1247067523;
						}
						else
						{
							num3 = 815864976;
							num4 = 815864976;
						}
						num = num3 ^ ((int)num2 * -1604845442);
						continue;
					}
					case 1u:
						result2 = 0f;
						num = (int)((num2 * 565511386) ^ 0x18F5D177);
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
			while (true)
			{
				int num = -130838851;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83865CBFu) % 5u)
					{
					case 2u:
						result2 = result;
						num = (int)((num2 * 1705101267) ^ 0x5F0C9A0);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (double.TryParse(Value, out result))
						{
							num3 = 1696510066;
							num4 = 1696510066;
						}
						else
						{
							num3 = 2031439547;
							num4 = 2031439547;
						}
						num = num3 ^ (int)(num2 * 1974857813);
						continue;
					}
					case 0u:
						result2 = 0.0;
						num = -1952944571;
						continue;
					case 4u:
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
				int num = -1097297678;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB36FA543u) % 3u)
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
					num = (int)((num2 * 842477902) ^ 0xDB54093);
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool flag = default(bool);
			bool result2 = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 971744424;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B7A1F4Fu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1966826459;
							num4 = -1966826459;
						}
						else
						{
							num3 = -487901213;
							num4 = -487901213;
						}
						num = num3 ^ (int)(num2 * 513899732);
						continue;
					}
					case 5u:
						num = ((int)num2 * -1085206570) ^ 0x1080D7AC;
						continue;
					case 4u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -1109890732) ^ 0x748C9696;
						continue;
					case 1u:
						result = !JSONNode.smethod_1(Value);
						num = 189507129;
						continue;
					case 0u:
						result = result2;
						num = (int)((num2 * 1977608795) ^ 0x4F041BF2);
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
				int num = -1191302466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9010CFFDu) % 4u)
					{
					case 3u:
						result = this as JSONArray;
						num = (int)((num2 * 1082659394) ^ 0x49984E2E);
						continue;
					case 1u:
						num = (int)((num2 * 1766915891) ^ 0xDD1EA8C);
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = -1165341576;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC6E9434u) % 3u)
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
					num = ((int)num2 * -478518596) ^ 0x4BB59DE4;
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
			int num = -1839408132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x972EA17Eu) % 3u)
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
				num = ((int)num2 * -1468460619) ^ 0x731D3F89;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 126285529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5256A420u) % 4u)
				{
				case 1u:
					result = null;
					num = ((int)num2 * -55535448) ^ 0x6A7318E8;
					continue;
				case 0u:
					num = ((int)num2 * -915953155) ^ -1019768589;
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

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1773699047;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC4E2332u) % 4u)
				{
				case 3u:
					result = aNode;
					num = ((int)num2 * -176124967) ^ -1947261288;
					continue;
				case 1u:
					num = (int)((num2 * 1021088576) ^ 0x6885DDB0);
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
		string result = "JSONNode";
		while (true)
		{
			int num = -236860280;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8D5B0BAu) % 3u)
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
				num = ((int)num2 * -1352096176) ^ 0x57840030;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1528868830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BBDC73Fu) % 3u)
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
				num = (int)(num2 * 270613928) ^ -969078106;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		return new JSONData(s);
	}

	public static implicit operator string(JSONNode d)
	{
		if (!(d == null))
		{
			goto IL_000c;
		}
		object obj = null;
		goto IL_0047;
		IL_0047:
		string result = (string)obj;
		int num = -561926070;
		goto IL_0020;
		IL_000c:
		num = -1879789935;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xA05D6B03u) % 4u)
			{
			case 3u:
				break;
			case 1u:
				num = (int)((num2 * 1695637735) ^ 0x243CA978);
				continue;
			case 2u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_000c;
		IL_0041:
		obj = d.Value;
		goto IL_0047;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b == null)
		{
			goto IL_0059;
		}
		int num = 0;
		goto IL_0094;
		IL_0094:
		bool flag = (byte)num != 0;
		int num2 = -342550366;
		goto IL_005e;
		IL_0059:
		num2 = -111776023;
		goto IL_005e;
		IL_005e:
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xDF9F0D86u) % 7u)
			{
			case 6u:
				num2 = (int)((num3 * 1937701520) ^ 0x7436F535);
				continue;
			case 4u:
				result = (object)a == b;
				num2 = -548407724;
				continue;
			case 3u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = 1055856412;
					num5 = 1055856412;
				}
				else
				{
					num4 = 1043709059;
					num5 = 1043709059;
				}
				num2 = num4 ^ ((int)num3 * -1966488837);
				continue;
			}
			case 1u:
				result = true;
				num2 = (int)(num3 * 760754131) ^ -52064905;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_0059;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
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
			int num = 1738288970;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x148248C5u) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = ((int)num2 * -2088599569) ^ 0x49E69928;
					continue;
				case 0u:
					num = (int)((num2 * 229551060) ^ 0x2B169C94);
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
			int num = -1985791668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCECB5B1Cu) % 3u)
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
				num = ((int)num2 * -904172053) ^ -1789893799;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		char c3 = default(char);
		string string_ = default(string);
		int num5 = default(int);
		char c2 = default(char);
		char c = default(char);
		string result = default(string);
		while (true)
		{
			int num = -689078802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB0113F6u) % 34u)
				{
				case 33u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -170632232;
					continue;
				case 32u:
					num = (int)((num2 * 441884260) ^ 0x648871B1);
					continue;
				case 31u:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -480666512;
					continue;
				case 29u:
					num = (int)((num2 * 956064933) ^ 0x24FF4C1B);
					continue;
				case 28u:
					num = (int)(num2 * 1499182122) ^ -790026419;
					continue;
				case 27u:
					string_ = aText;
					num = ((int)num2 * -794540774) ^ -1489645975;
					continue;
				case 26u:
					num = ((int)num2 * -1973842496) ^ -694411123;
					continue;
				case 25u:
					num5++;
					num = -905607501;
					continue;
				case 23u:
					num = ((int)num2 * -813756509) ^ 0x75D28CEE;
					continue;
				case 22u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1813357970;
					continue;
				case 21u:
					goto IL_00cc;
				case 20u:
					num = ((int)num2 * -1371052294) ^ -961627693;
					continue;
				case 19u:
				{
					int num6;
					if (num5 < JSONNode.smethod_4(string_))
					{
						num = -612616973;
						num6 = -612616973;
					}
					else
					{
						num = -1627831964;
						num6 = -1627831964;
					}
					continue;
				}
				case 18u:
					goto IL_011a;
				case 17u:
					num = ((int)num2 * -269333485) ^ 0x715F1D4A;
					continue;
				case 16u:
					num = ((int)num2 * -1754675486) ^ -680868135;
					continue;
				case 15u:
					c3 = JSONNode.smethod_2(string_, num5);
					num = -1816271707;
					continue;
				case 14u:
					num = (int)(num2 * 550598775) ^ -1319960989;
					continue;
				case 13u:
					num5 = 0;
					num = ((int)num2 * -54584969) ^ -42764223;
					continue;
				case 12u:
					goto IL_0190;
				case 11u:
					c2 = c3;
					num = ((int)num2 * -1926276084) ^ -796167225;
					continue;
				case 10u:
					num = (int)(num2 * 675551183) ^ -389325615;
					continue;
				case 9u:
					goto IL_01cf;
				case 8u:
					text = "";
					num = (int)(num2 * 772035460) ^ -903157019;
					continue;
				case 7u:
				{
					int num4;
					if (c == '"')
					{
						num = -1483484648;
						num4 = -1483484648;
					}
					else
					{
						num = -12742754;
						num4 = -12742754;
					}
					continue;
				}
				case 6u:
					goto IL_0220;
				case 5u:
					c = c2;
					num = ((int)num2 * -1719398429) ^ -98187852;
					continue;
				case 4u:
					num = ((int)num2 * -1695709790) ^ -1839336679;
					continue;
				case 3u:
				{
					int num3;
					if (c == '\\')
					{
						num = -1243201477;
						num3 = -1243201477;
					}
					else
					{
						num = -2054697550;
						num3 = -2054697550;
					}
					continue;
				}
				case 2u:
					num = ((int)num2 * -1004183458) ^ 0x3582B9CD;
					continue;
				case 1u:
					switch (c)
					{
					case '\v':
						break;
					case '\b':
						goto IL_00cc;
					case '\t':
						goto IL_011a;
					case '\n':
						goto IL_0190;
					case '\r':
						goto IL_01cf;
					case '\f':
						goto IL_0220;
					default:
						goto IL_02ad;
					}
					goto case 31u;
				case 0u:
					result = text;
					num = (int)((num2 * 683668027) ^ 0x43B0BEE1);
					continue;
				case 24u:
					break;
				default:
					{
						return result;
					}
					IL_02ad:
					num = (int)((num2 * 1710744231) ^ 0x70C35AAE);
					continue;
					IL_0220:
					text = JSONNode.smethod_3(text, "\\f");
					num = -69672818;
					continue;
					IL_01cf:
					text = JSONNode.smethod_3(text, "\\r");
					num = -502895844;
					continue;
					IL_0190:
					text = JSONNode.smethod_3(text, "\\n");
					num = -684539781;
					continue;
					IL_011a:
					text = JSONNode.smethod_3(text, "\\t");
					num = -2121959127;
					continue;
					IL_00cc:
					text = JSONNode.smethod_3(text, "\\b");
					num = -324562050;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		int num3 = default(int);
		char c5 = default(char);
		string text2 = default(string);
		string text = default(string);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag6 = default(bool);
		bool flag = default(bool);
		bool flag12 = default(bool);
		bool flag3 = default(bool);
		bool flag10 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag11 = default(bool);
		char c4 = default(char);
		JSONNode result = default(JSONNode);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		char c2 = default(char);
		char c = default(char);
		bool flag13 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		string s = default(string);
		char c3 = default(char);
		while (true)
		{
			int num = 2066642353;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1856F59Cu) % 149u)
				{
				case 20u:
				case 21u:
				case 120u:
				case 146u:
				case 148u:
					num3++;
					num = 29620313;
					continue;
				case 147u:
				{
					int num23;
					if (c5 == '{')
					{
						num = 2036431928;
						num23 = 2036431928;
					}
					else
					{
						num = 1685258518;
						num23 = 1685258518;
					}
					continue;
				}
				case 145u:
					num = (int)(num2 * 550932468) ^ -1594050503;
					continue;
				case 144u:
					num = (int)(num2 * 453716962) ^ -1647618375;
					continue;
				case 143u:
					num = ((int)num2 * -230564489) ^ -1175391331;
					continue;
				case 142u:
					text2 = "";
					text = "";
					num = 609533368;
					continue;
				case 141u:
					num = ((int)num2 * -56794152) ^ 0x7556E17B;
					continue;
				case 140u:
				{
					stack.Pop();
					int num22;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 2142506835;
						num22 = 2142506835;
					}
					else
					{
						num = 524474660;
						num22 = 524474660;
					}
					continue;
				}
				case 139u:
				{
					int num17;
					int num18;
					if (!flag6)
					{
						num17 = 1027395213;
						num18 = 1027395213;
					}
					else
					{
						num17 = 1886685978;
						num18 = 1886685978;
					}
					num = num17 ^ ((int)num2 * -1370501679);
					continue;
				}
				case 138u:
					num = (int)(num2 * 277040791) ^ -1800188476;
					continue;
				case 137u:
					text = JSONNode.smethod_3(text, "\r");
					num = 835261755;
					continue;
				case 136u:
					flag = !flag;
					num = 1836989359;
					continue;
				case 135u:
				{
					int num50;
					int num51;
					if (flag12)
					{
						num50 = -1226555086;
						num51 = -1226555086;
					}
					else
					{
						num50 = -1530724282;
						num51 = -1530724282;
					}
					num = num50 ^ ((int)num2 * -106624955);
					continue;
				}
				case 134u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 689719766) ^ 0x4CD37B6B);
					continue;
				case 133u:
				{
					int num27;
					int num28;
					if ((uint)c5 <= 32u)
					{
						num27 = 1583796869;
						num28 = 1583796869;
					}
					else
					{
						num27 = 29144116;
						num28 = 29144116;
					}
					num = num27 ^ (int)(num2 * 271178196);
					continue;
				}
				case 132u:
					num = (int)(num2 * 663877499) ^ -1584848677;
					continue;
				case 131u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = 1570150879;
						num14 = 1570150879;
					}
					else
					{
						num13 = 1519386683;
						num14 = 1519386683;
					}
					num = num13 ^ (int)(num2 * 1163191283);
					continue;
				}
				case 130u:
				{
					int num59;
					if ((uint)c5 <= 93u)
					{
						num = 124523516;
						num59 = 124523516;
					}
					else
					{
						num = 748162249;
						num59 = 748162249;
					}
					continue;
				}
				case 129u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1958110640) ^ -1724932328;
					continue;
				case 128u:
					num3++;
					num = 340571991;
					continue;
				case 127u:
					num = 933302572;
					continue;
				case 126u:
					goto IL_024a;
				case 125u:
				{
					int num54;
					if (!flag)
					{
						num = 2070792148;
						num54 = 2070792148;
					}
					else
					{
						num = 466224545;
						num54 = 466224545;
					}
					continue;
				}
				case 124u:
				{
					int num46;
					int num47;
					if (flag10)
					{
						num46 = -1820665316;
						num47 = -1820665316;
					}
					else
					{
						num46 = -1637891984;
						num47 = -1637891984;
					}
					num = num46 ^ (int)(num2 * 1924811037);
					continue;
				}
				case 123u:
					num = (int)(num2 * 291727271) ^ -1369621404;
					continue;
				case 122u:
				{
					int num44;
					if (c5 == ' ')
					{
						num = 1837559337;
						num44 = 1837559337;
					}
					else
					{
						num = 916080316;
						num44 = 916080316;
					}
					continue;
				}
				case 121u:
					switch (c5)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_024a;
					default:
						goto IL_0307;
					case '\t':
						goto IL_031a;
					}
					goto case 20u;
				case 92u:
					goto IL_031a;
				case 119u:
					jSONNode = null;
					num = (int)((num2 * 1365005465) ^ 0x428FA85C);
					continue;
				case 118u:
					num = ((int)num2 * -1878349557) ^ -1723048121;
					continue;
				case 117u:
					flag11 = num3 < JSONNode.smethod_4(aJSON);
					num = 1746671809;
					continue;
				case 116u:
					switch (c5)
					{
					case '\\':
						break;
					default:
						goto IL_037b;
					case '[':
						goto IL_0385;
					case ']':
						goto IL_0393;
					}
					goto case 128u;
				case 1u:
					goto IL_0385;
				case 39u:
					goto IL_0393;
				case 115u:
					flag = false;
					num = (int)(num2 * 668179051) ^ -57724247;
					continue;
				case 114u:
					num = ((int)num2 * -686888017) ^ -1140161148;
					continue;
				case 113u:
					goto IL_03ca;
				case 112u:
					flag10 = flag;
					num = (int)(num2 * 1792227578) ^ -716544860;
					continue;
				case 111u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -278434595) ^ 0x513CC4AE;
					continue;
				case 110u:
					num = 2002501086;
					continue;
				case 109u:
					c4 = JSONNode.smethod_2(aJSON, num3);
					num = ((int)num2 * -1399140147) ^ -379225421;
					continue;
				case 108u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -761112714) ^ -524185146;
					continue;
				case 107u:
					num = (int)((num2 * 624281509) ^ 0x2E11BF3C);
					continue;
				case 106u:
					num = ((int)num2 * -644207197) ^ 0x4CD20D94;
					continue;
				case 105u:
					text2 = JSONNode.smethod_5(text2);
					flag6 = jSONNode is JSONArray;
					num = (int)((num2 * 1324387431) ^ 0x7D793582);
					continue;
				case 104u:
					text = JSONNode.smethod_3(text, "\f");
					num = 1102871684;
					continue;
				case 103u:
					result = jSONNode;
					num = 1532193386;
					continue;
				case 102u:
				{
					int num24;
					int num25;
					if (flag7)
					{
						num24 = -1513950940;
						num25 = -1513950940;
					}
					else
					{
						num24 = -1103866144;
						num25 = -1103866144;
					}
					num = num24 ^ (int)(num2 * 1998239742);
					continue;
				}
				case 101u:
				{
					int num19;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 1731723316;
						num19 = 1731723316;
					}
					else
					{
						num = 730395725;
						num19 = 730395725;
					}
					continue;
				}
				case 100u:
					num = 2142506835;
					continue;
				case 99u:
				{
					int num10;
					int num11;
					if (!flag5)
					{
						num10 = -725970319;
						num11 = -725970319;
					}
					else
					{
						num10 = -1051139300;
						num11 = -1051139300;
					}
					num = num10 ^ (int)(num2 * 1219471400);
					continue;
				}
				case 98u:
					num = (int)((num2 * 1019757154) ^ 0x7BA6D132);
					continue;
				case 97u:
					c2 = JSONNode.smethod_2(aJSON, num3);
					num = 2002058100;
					continue;
				case 96u:
					num = ((int)num2 * -2017266903) ^ 0x52C7443C;
					continue;
				case 95u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -1595947953) ^ -1300856608;
					continue;
				case 94u:
					stack.Push(new JSONClass());
					flag3 = jSONNode != null;
					num = 930026706;
					continue;
				case 91u:
					text2 = "";
					num = 136572730;
					continue;
				case 90u:
					text = "";
					num = ((int)num2 * -1261500554) ^ -855242945;
					continue;
				case 89u:
					num = (int)(num2 * 953214053) ^ -84349351;
					continue;
				case 88u:
				{
					int num57;
					int num58;
					if (flag11)
					{
						num57 = 1015897058;
						num58 = 1015897058;
					}
					else
					{
						num57 = 1341383990;
						num58 = 1341383990;
					}
					num = num57 ^ ((int)num2 * -904380277);
					continue;
				}
				case 87u:
					switch (c)
					{
					case 'r':
						break;
					case 's':
						goto IL_03ca;
					default:
						goto IL_064b;
					case 't':
						goto IL_0655;
					case 'u':
						goto IL_066b;
					}
					goto case 137u;
				case 30u:
					goto IL_0655;
				case 82u:
					goto IL_066b;
				case 86u:
					num = (int)(num2 * 1090239090) ^ -501720707;
					continue;
				case 85u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -212627744) ^ 0x48895248;
					continue;
				case 84u:
				{
					int num56;
					if (c == 'n')
					{
						num = 902603535;
						num56 = 902603535;
					}
					else
					{
						num = 1025103152;
						num56 = 1025103152;
					}
					continue;
				}
				case 83u:
					flag7 = stack.Count == 0;
					num = 1984144626;
					continue;
				case 81u:
				{
					int num55;
					if (c != 'f')
					{
						num = 877371318;
						num55 = 877371318;
					}
					else
					{
						num = 744164398;
						num55 = 744164398;
					}
					continue;
				}
				case 80u:
					num = (int)(num2 * 999542543) ^ -309718404;
					continue;
				case 79u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1311308183) ^ -1640619269;
					continue;
				case 78u:
					num = (int)(num2 * 1444199439) ^ -486301388;
					continue;
				case 77u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 871570227) ^ -1762436043;
					continue;
				case 76u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -3801924) ^ -1121657267;
					continue;
				case 75u:
				{
					int num52;
					int num53;
					if (flag13)
					{
						num52 = -726352683;
						num53 = -726352683;
					}
					else
					{
						num52 = -833135560;
						num53 = -833135560;
					}
					num = num52 ^ ((int)num2 * -1076041982);
					continue;
				}
				case 74u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = 465309099;
					continue;
				case 73u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1782238823) ^ -1412886869;
					continue;
				case 72u:
					flag13 = jSONNode != null;
					num = ((int)num2 * -1269200845) ^ 0x4403EB82;
					continue;
				case 71u:
					num = (int)(num2 * 400272935) ^ -2095299132;
					continue;
				case 70u:
				{
					int num48;
					int num49;
					if (stack.Count > 0)
					{
						num48 = 608493084;
						num49 = 608493084;
					}
					else
					{
						num48 = 1495774131;
						num49 = 1495774131;
					}
					num = num48 ^ ((int)num2 * -878055693);
					continue;
				}
				case 69u:
				{
					int num45;
					if (!flag)
					{
						num = 477206012;
						num45 = 477206012;
					}
					else
					{
						num = 1289768617;
						num45 = 1289768617;
					}
					continue;
				}
				case 68u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 154337100) ^ 0x6DE101AF);
					continue;
				case 67u:
				{
					int num42;
					int num43;
					if (jSONNode is JSONArray)
					{
						num42 = -650451935;
						num43 = -650451935;
					}
					else
					{
						num42 = -722047496;
						num43 = -722047496;
					}
					num = num42 ^ (int)(num2 * 2089673450);
					continue;
				}
				case 66u:
				{
					int num41;
					if (c5 != ',')
					{
						num = 1473403932;
						num41 = 1473403932;
					}
					else
					{
						num = 328602791;
						num41 = 328602791;
					}
					continue;
				}
				case 65u:
					num = (int)((num2 * 424593354) ^ 0x67251823);
					continue;
				case 64u:
					num = (int)(num2 * 1459433313) ^ -1158157067;
					continue;
				case 63u:
				{
					int num40;
					if (c5 != '"')
					{
						num = 1548129691;
						num40 = 1548129691;
					}
					else
					{
						num = 1355326604;
						num40 = 1355326604;
					}
					continue;
				}
				case 62u:
				{
					int num39;
					if (!flag)
					{
						num = 1884915496;
						num39 = 1884915496;
					}
					else
					{
						num = 1424412969;
						num39 = 1424412969;
					}
					continue;
				}
				case 61u:
				{
					int num37;
					int num38;
					if (flag2)
					{
						num37 = -2103669389;
						num38 = -2103669389;
					}
					else
					{
						num37 = -1855867016;
						num38 = -1855867016;
					}
					num = num37 ^ ((int)num2 * -1540482096);
					continue;
				}
				case 60u:
					num = (int)(num2 * 474439226) ^ -292546089;
					continue;
				case 59u:
					num = (int)((num2 * 1760271150) ^ 0x4269BE25);
					continue;
				case 57u:
					num = 1086392113;
					continue;
				case 56u:
					text = JSONNode.smethod_3(text, "\b");
					num = 1514319155;
					continue;
				case 55u:
					text = JSONNode.smethod_3(text, "\n");
					num = 835261755;
					continue;
				case 54u:
				{
					int num36;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 1974313522;
						num36 = 1974313522;
					}
					else
					{
						num = 1852097869;
						num36 = 1852097869;
					}
					continue;
				}
				case 53u:
				{
					int num34;
					int num35;
					if (c != 'b')
					{
						num34 = 561119220;
						num35 = 561119220;
					}
					else
					{
						num34 = 1163499475;
						num35 = 1163499475;
					}
					num = num34 ^ ((int)num2 * -1794115105);
					continue;
				}
				case 52u:
					num = ((int)num2 * -1251653557) ^ 0x33D82C37;
					continue;
				case 51u:
				{
					int num32;
					int num33;
					if (!flag9)
					{
						num32 = -406427081;
						num33 = -406427081;
					}
					else
					{
						num32 = -692166266;
						num33 = -692166266;
					}
					num = num32 ^ ((int)num2 * -1864583192);
					continue;
				}
				case 50u:
					num = ((int)num2 * -336120058) ^ -15934906;
					continue;
				case 49u:
					num = 1974313522;
					continue;
				case 48u:
					text2 = "";
					num = 444356723;
					continue;
				case 47u:
					text = "";
					num = ((int)num2 * -1320597424) ^ 0x2ED2255B;
					continue;
				case 46u:
					num = ((int)num2 * -170684278) ^ 0xF44C757;
					continue;
				case 45u:
					jSONNode.Add(text);
					num = (int)(num2 * 1463694482) ^ -667032899;
					continue;
				case 44u:
				{
					int num31;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 11380013;
						num31 = 11380013;
					}
					else
					{
						num = 707932196;
						num31 = 707932196;
					}
					continue;
				}
				case 43u:
					num = (int)(num2 * 814367515) ^ -1734260882;
					continue;
				case 42u:
					num3 = 0;
					text = "";
					text2 = "";
					num = ((int)num2 * -1692119391) ^ 0x77463071;
					continue;
				case 41u:
				{
					int num29;
					int num30;
					if (!flag8)
					{
						num29 = 533548287;
						num30 = 533548287;
					}
					else
					{
						num29 = 2029749234;
						num30 = 2029749234;
					}
					num = num29 ^ (int)(num2 * 1801442107);
					continue;
				}
				case 40u:
					num = ((int)num2 * -1156700669) ^ 0x51C6B8EC;
					continue;
				case 38u:
				{
					int num26;
					if (c5 == '}')
					{
						num = 786247709;
						num26 = 786247709;
					}
					else
					{
						num = 737508665;
						num26 = 737508665;
					}
					continue;
				}
				case 37u:
					num = ((int)num2 * -358448505) ^ 0x3C68AAC6;
					continue;
				case 36u:
					num = ((int)num2 * -1117031214) ^ -1848631712;
					continue;
				case 35u:
					num = ((int)num2 * -1829835310) ^ 0x22A0F99;
					continue;
				case 34u:
					text2 = text;
					num = 172131675;
					continue;
				case 33u:
					num = ((int)num2 * -1180877232) ^ 0x2BDB13F6;
					continue;
				case 32u:
				{
					c5 = c2;
					int num20;
					int num21;
					if ((uint)c5 <= 44u)
					{
						num20 = 1154814125;
						num21 = 1154814125;
					}
					else
					{
						num20 = 2095943429;
						num21 = 2095943429;
					}
					num = num20 ^ ((int)num2 * -224373061);
					continue;
				}
				case 31u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -398232421) ^ -272163695;
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num3 += 4;
					num = ((int)num2 * -1962831464) ^ 0x534BA9B3;
					continue;
				case 28u:
				{
					int num15;
					int num16;
					if (c5 == ':')
					{
						num15 = -1570692923;
						num16 = -1570692923;
					}
					else
					{
						num15 = -1433862898;
						num16 = -1433862898;
					}
					num = num15 ^ (int)(num2 * 81638057);
					continue;
				}
				case 27u:
					text = "";
					num = ((int)num2 * -1818540306) ^ -1016871278;
					continue;
				case 26u:
					c3 = c4;
					num = ((int)num2 * -1455816496) ^ -1206783618;
					continue;
				case 25u:
					num = ((int)num2 * -1912078526) ^ -556941842;
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 914480306) ^ -679316298;
					continue;
				case 23u:
				{
					int num12;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1917768871;
						num12 = 1917768871;
					}
					else
					{
						num = 845033457;
						num12 = 845033457;
					}
					continue;
				}
				case 22u:
					c = c3;
					num = (int)(num2 * 990615663) ^ -1412703120;
					continue;
				case 19u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -165881359) ^ -922444972;
					continue;
				case 17u:
					num = ((int)num2 * -739115482) ^ -505402980;
					continue;
				case 16u:
					num = ((int)num2 * -1328316593) ^ -133765838;
					continue;
				case 15u:
					num = (int)(num2 * 969506265) ^ -1673191837;
					continue;
				case 14u:
					num = (int)((num2 * 202665940) ^ 0x53F44857);
					continue;
				case 13u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = 234694236;
					continue;
				case 12u:
					flag5 = jSONNode is JSONArray;
					num = (int)(num2 * 1227382820) ^ -1241028300;
					continue;
				case 11u:
					jSONNode.Add(text);
					num = (int)(num2 * 1330345252) ^ -1384559645;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = 745270084;
						num9 = 745270084;
					}
					else
					{
						num8 = 1002569413;
						num9 = 1002569413;
					}
					num = num8 ^ ((int)num2 * -112630705);
					continue;
				}
				case 9u:
					num = (int)((num2 * 853178457) ^ 0x6CF3F43F);
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (jSONNode is JSONArray)
					{
						num6 = -44722386;
						num7 = -44722386;
					}
					else
					{
						num6 = -1220693564;
						num7 = -1220693564;
					}
					num = num6 ^ ((int)num2 * -1776179839);
					continue;
				}
				case 7u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -2020391233) ^ -924344576;
					continue;
				case 6u:
				{
					int num4;
					int num5;
					if ((uint)c <= 102u)
					{
						num4 = -2095414273;
						num5 = -2095414273;
					}
					else
					{
						num4 = -1325913528;
						num5 = -1325913528;
					}
					num = num4 ^ (int)(num2 * 369942897);
					continue;
				}
				case 5u:
					flag2 = flag;
					num = ((int)num2 * -891399304) ^ -2087564597;
					continue;
				case 4u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -645751687) ^ -2070096002;
					continue;
				case 3u:
					stack.Push(new JSONArray());
					num = 436993408;
					continue;
				case 0u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 28211151) ^ -1410610421;
					continue;
				case 18u:
					break;
				case 58u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 93u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_03ca:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = 470056349;
					continue;
					IL_0385:
					flag8 = flag;
					num = 1099164876;
					continue;
					IL_037b:
					num = 2094279169;
					continue;
					IL_0393:
					flag9 = flag;
					num = 1019250817;
					continue;
					IL_031a:
					flag12 = flag;
					num = 1613211947;
					continue;
					IL_0307:
					num = (int)(num2 * 864460569) ^ -1703396404;
					continue;
					IL_024a:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = 97119430;
					continue;
					IL_066b:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = 900695735;
					continue;
					IL_0655:
					text = JSONNode.smethod_3(text, "\t");
					num = 835261755;
					continue;
					IL_064b:
					num = 1159385384;
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
		while (true)
		{
			int num = 26887816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E8C3148u) % 3u)
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
				BinaryWriter aWriter = JSONNode.smethod_9(aData);
				Serialize(aWriter);
				num = (int)(num2 * 1265762233) ^ -63162606;
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
				int num = -2100399473;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0A22A65u) % 5u)
					{
					case 2u:
						num = (int)(num2 * 1132091650) ^ -1122712869;
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = (int)((num2 * 435853927) ^ 0x38A494B5);
						continue;
					case 0u:
						num = ((int)num2 * -1946383795) ^ 0x76DED37E;
						continue;
					default:
						return;
					case 4u:
						break;
					case 3u:
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
					IL_00c8:
					int num3 = -253867856;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xC0A22A65u) % 4u)
						{
						case 2u:
							num3 = (int)((num2 * 45509048) ^ 0x45334D81);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 2012849693) ^ -607351946;
							continue;
						default:
							goto end_IL_00a7;
						case 3u:
							break;
						case 0u:
							goto end_IL_00a7;
						}
						goto IL_00c8;
						continue;
						end_IL_00a7:
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
				int num = 1280958964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2AB377B9u) % 4u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 608056218) ^ -85896135;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -965361204) ^ 0x2C48BC96;
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
					IL_00a6:
					int num3 = 300377187;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x2AB377B9u) % 3u)
						{
						case 2u:
							goto IL_0076;
						default:
							goto end_IL_0089;
						case 0u:
							break;
						case 1u:
							goto end_IL_0089;
						}
						goto IL_00a6;
						IL_0076:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = (int)((num2 * 1319884271) ^ 0xE716747);
						continue;
						end_IL_0089:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		int num7 = default(int);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num4 = default(int);
		int num3 = default(int);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num5 = default(int);
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = 1395826337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2AAF52u) % 37u)
				{
				case 36u:
					num7 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1775153835) ^ -783892341;
					continue;
				case 35u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -523477778) ^ 0x58541BCE;
					continue;
				case 34u:
					num = 870831202;
					continue;
				case 33u:
					goto IL_0049;
				case 32u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -2116526272) ^ 0x10D1DF1E;
					continue;
				case 30u:
					num = (int)((num2 * 1635945978) ^ 0x1344AE40);
					continue;
				case 29u:
					num4++;
					num = (int)(num2 * 348981259) ^ -1700488456;
					continue;
				case 28u:
					num = ((int)num2 * -1911354225) ^ 0x720B02E2;
					continue;
				case 27u:
					num = ((int)num2 * -751144986) ^ 0x6A366B8A;
					continue;
				case 26u:
					num = ((int)num2 * -635560156) ^ -795198324;
					continue;
				case 25u:
				{
					int num8;
					if (num3 >= num7)
					{
						num = 604841596;
						num8 = 604841596;
					}
					else
					{
						num = 135331344;
						num8 = 135331344;
					}
					continue;
				}
				case 24u:
					num = (int)((num2 * 179019955) ^ 0x2F44776D);
					continue;
				case 23u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 1307761080) ^ 0x561D0445);
					continue;
				case 20u:
					num3++;
					num = ((int)num2 * -1464877098) ^ 0x16F209B6;
					continue;
				case 19u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -2047658256) ^ -1344544372;
					continue;
				case 18u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = 301099494;
					continue;
				case 17u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = (int)(num2 * 703539593) ^ -774837576;
					continue;
				case 16u:
					goto IL_0186;
				case 15u:
					goto IL_019e;
				case 14u:
				{
					int num6;
					if (num4 >= num5)
					{
						num = 132426743;
						num6 = 132426743;
					}
					else
					{
						num = 966376780;
						num6 = 966376780;
					}
					continue;
				}
				case 13u:
					result = jSONClass;
					num = ((int)num2 * -279626253) ^ 0x2516581C;
					continue;
				case 12u:
					num = (int)(num2 * 279465954) ^ -1361860128;
					continue;
				case 11u:
					jSONArray.Add(Deserialize(aReader));
					num = 2142313053;
					continue;
				case 10u:
					goto IL_0219;
				case 9u:
					num = (int)((num2 * 248297233) ^ 0x6C9961B7);
					continue;
				case 8u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)(num2 * 766804384) ^ -223444331;
					continue;
				case 7u:
					goto IL_0256;
				case 6u:
					num4 = 0;
					num = (int)(num2 * 522453994) ^ -458330841;
					continue;
				case 5u:
					result = jSONArray;
					num = ((int)num2 * -1543785374) ^ 0x202F91B9;
					continue;
				case 4u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.Class:
						break;
					case JSONBinaryTag.DoubleValue:
						goto IL_0049;
					case JSONBinaryTag.Array:
						goto IL_0186;
					case JSONBinaryTag.FloatValue:
						goto IL_019e;
					case JSONBinaryTag.IntValue:
						goto IL_0219;
					case JSONBinaryTag.Value:
						goto IL_0256;
					default:
						goto IL_02b1;
					case JSONBinaryTag.BoolValue:
						goto IL_02c1;
					}
					goto case 34u;
				case 1u:
					goto IL_02c1;
				case 3u:
					jSONClass = new JSONClass();
					num3 = 0;
					num = (int)(num2 * 1686869460) ^ -1904186016;
					continue;
				case 2u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -7064597) ^ -180283944;
					continue;
				case 0u:
					num = 1225950085;
					continue;
				case 31u:
					break;
				case 22u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_02c1:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = 944558760;
					continue;
					IL_02b1:
					num = (int)(num2 * 694597497) ^ -2142522932;
					continue;
					IL_0256:
					num = 903535459;
					continue;
					IL_0219:
					num = 21071106;
					continue;
					IL_0049:
					num = 407658605;
					continue;
					IL_019e:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = 944558760;
					continue;
					IL_0186:
					num5 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = 305785432;
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
				int num = -2112344388;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDFBAEB4Cu) % 3u)
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
					num = ((int)num2 * -1642577373) ^ -2122793442;
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
					int num3 = -80689451;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xDFBAEB4Cu) % 4u)
						{
						case 2u:
							num3 = ((int)num2 * -1528717727) ^ 0x6A412456;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)((num2 * 1233208658) ^ 0x64663BD4);
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
					IL_0045:
					int num = -1340239582;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x90BED2D8u) % 3u)
						{
						case 2u:
							goto IL_0015;
						default:
							goto end_IL_0028;
						case 0u:
							break;
						case 1u:
							goto end_IL_0028;
						}
						goto IL_0045;
						IL_0015:
						JSONNode.smethod_15((IDisposable)fileStream);
						num = ((int)num2 * -236945826) ^ -1971246120;
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
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = -1262752369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC8DF2EEu) % 5u)
				{
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1546153397) ^ 0x3CC4E524);
					continue;
				case 2u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1582540723) ^ -2034542042;
					continue;
				case 1u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)(num2 * 947014054) ^ -1468488164;
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
