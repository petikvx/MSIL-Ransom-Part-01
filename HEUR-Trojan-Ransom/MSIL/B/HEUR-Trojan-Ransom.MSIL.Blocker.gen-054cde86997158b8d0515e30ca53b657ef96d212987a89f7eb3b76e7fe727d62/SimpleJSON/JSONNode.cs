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
				int num = -499223996;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED45D331u) % 3u)
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
					num = ((int)num2 * -1223210311) ^ -1415240496;
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
				int num = 1517957096;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39175076u) % 4u)
					{
					case 2u:
						result = null;
						num = (int)(num2 * 1346223832) ^ -857830385;
						continue;
					case 1u:
						num = (int)(num2 * 12411710) ^ -1103230672;
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
				int num = 1096576065;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3DE431E4u) % 4u)
					{
					case 1u:
						result = "";
						num = (int)(num2 * 693523252) ^ -332325876;
						continue;
					case 0u:
						num = ((int)num2 * -703398046) ^ 0x33B4E763;
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
		}
	}

	public virtual int Count
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = -161318094;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9B3623Eu) % 3u)
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
					num = (int)((num2 * 1989623170) ^ 0x2CB6C23B);
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
				int num = -1910452887;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE90075Cu) % 8u)
					{
					case 6u:
						num = (int)(num2 * 240112500) ^ -352837693;
						continue;
					case 5u:
					{
						int num3;
						num = ((num3 == 0) ? (-792159733) : (-703997591)) ^ (int)(num2 * 1169894567);
						continue;
					}
					case 2u:
					case 4u:
						num = -910237843;
						continue;
					case 1u:
						num = ((int)num2 * -347350790) ^ -1658054171;
						continue;
					default:
						yield break;
					case 0u:
						break;
					case 7u:
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
			//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
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
			bool flag = int.TryParse(Value, out result);
			int result2 = default(int);
			while (true)
			{
				int num = 1316438917;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7ED006E2u) % 6u)
					{
					case 5u:
						result2 = result;
						num = (int)(num2 * 164880879) ^ -292847713;
						continue;
					case 4u:
						result2 = 0;
						num = 1846020775;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -532999504;
							num4 = -532999504;
						}
						else
						{
							num3 = -1805163365;
							num4 = -1805163365;
						}
						num = num3 ^ ((int)num2 * -1529207001);
						continue;
					}
					case 1u:
						num = ((int)num2 * -1657292903) ^ 0x14B6584F;
						continue;
					case 2u:
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

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
			{
				goto IL_001f;
			}
			goto IL_0069;
			IL_0069:
			float result2 = 0f;
			int num = 1845539560;
			goto IL_0044;
			IL_0044:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D6CC082u) % 5u)
				{
				case 3u:
					break;
				case 1u:
					result2 = result;
					num = ((int)num2 * -1943399018) ^ -587737093;
					continue;
				case 0u:
					num = (int)(num2 * 529403774) ^ -1509465841;
					continue;
				case 4u:
					goto IL_0069;
				default:
					return result2;
				}
				break;
			}
			goto IL_001f;
			IL_001f:
			num = 1065557830;
			goto IL_0044;
		}
		set
		{
			Value = value.ToString();
			while (true)
			{
				int num = -898573563;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x90385763u) % 3u)
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
					num = ((int)num2 * -1444386481) ^ -203424585;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			bool flag = double.TryParse(Value, out result);
			double result2 = default(double);
			while (true)
			{
				int num = -291110271;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF62783Bu) % 5u)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -704476121;
							num4 = -704476121;
						}
						else
						{
							num3 = -2142200423;
							num4 = -2142200423;
						}
						num = num3 ^ (int)(num2 * 580862031);
						continue;
					}
					case 1u:
						result2 = 0.0;
						num = -795985333;
						continue;
					case 0u:
						result2 = result;
						num = (int)((num2 * 765007709) ^ 0x5F207B19);
						continue;
					case 2u:
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
				int num = 1411094469;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x53163A72u) % 3u)
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
					num = ((int)num2 * -1689658949) ^ 0x6BABEBB2;
				}
			}
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
			goto IL_005b;
			IL_005b:
			bool result2 = !JSONNode.smethod_1(Value);
			int num = 2019662499;
			goto IL_0036;
			IL_0036:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1780B4B9u) % 5u)
				{
				case 4u:
					break;
				case 3u:
					num = ((int)num2 * -1516918129) ^ -1140178659;
					continue;
				case 2u:
					result2 = result;
					num = ((int)num2 * -26540055) ^ -1828141337;
					continue;
				case 1u:
					goto IL_005b;
				default:
					return result2;
				}
				break;
			}
			goto IL_0011;
			IL_0011:
			num = 2135294629;
			goto IL_0036;
		}
		set
		{
			while (true)
			{
				int num = -2087773077;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83D1E832u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1684881585) ^ -1873552749;
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = -243964324;
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
				int num = 1214340746;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41CAB6CBu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -569918469) ^ 0x200A3004;
						continue;
					case 1u:
						result = this as JSONArray;
						num = ((int)num2 * -1895123294) ^ -1146542898;
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
				int num = 1962664810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x47BA0AA7u) % 3u)
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
					result = this as JSONClass;
					num = (int)(num2 * 1962885531) ^ -676586622;
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
			int num = 1170575212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31D722B9u) % 4u)
				{
				case 1u:
					Add("", aItem);
					num = (int)((num2 * 689991187) ^ 0x6D298026);
					continue;
				case 0u:
					num = ((int)num2 * -225777600) ^ 0x58426FAE;
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

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -179191191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC2C201Cu) % 3u)
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
				num = (int)(num2 * 601356000) ^ -1930361505;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -2017422068;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D13F187u) % 3u)
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
				num = (int)(num2 * 1373569163) ^ -1673373702;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -1514101489;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF00E22F1u) % 3u)
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
				num = ((int)num2 * -1244305839) ^ -669804279;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1148302426;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E8FE7D1u) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = (int)(num2 * 1273229716) ^ -1792425359;
					continue;
				case 0u:
					num = (int)((num2 * 1775578397) ^ 0x24B846C8);
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

	public virtual string ToString(string aPrefix)
	{
		return "JSONNode";
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 449586445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E976BEDu) % 3u)
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
				num = ((int)num2 * -1203834251) ^ 0x4EAB64F6;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -1124007721;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xA83A125Cu) % 5u)
				{
				case 4u:
					obj = d.Value;
					goto IL_0009;
				case 3u:
					num = ((int)num2 * -1757732188) ^ -1933703714;
					continue;
				case 2u:
					if (!(d == null))
					{
						num = ((int)num2 * -1393514749) ^ 0x4A854FDA;
						continue;
					}
					obj = null;
					goto IL_0009;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = -626713704;
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
			goto IL_0031;
		}
		goto IL_008e;
		IL_0031:
		int num = -1907546667;
		goto IL_0056;
		IL_0056:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDC80BEE6u) % 7u)
			{
			case 6u:
				result = (object)a == b;
				num = -1858307771;
				continue;
			case 5u:
				num = (int)((num2 * 1213463256) ^ 0x744BE953);
				continue;
			case 4u:
				break;
			case 2u:
				result = true;
				num = (int)(num2 * 951749756) ^ -321116014;
				continue;
			case 0u:
				num = (int)((num2 * 577406194) ^ 0x14AE3223);
				continue;
			case 1u:
				goto IL_0083;
			default:
				return result;
			}
			break;
			IL_0083:
			if (a is JSONLazyCreator)
			{
				num = -1187191152;
				num3 = -1187191152;
				continue;
			}
			goto IL_008e;
		}
		goto IL_0031;
		IL_008e:
		num = -68742419;
		num3 = -68742419;
		goto IL_0056;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -712361327;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5B6256Au) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = (int)((num2 * 109789741) ^ 0x1C34DE70);
					continue;
				case 1u:
					num = ((int)num2 * -2139338637) ^ 0x555AC9F7;
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
		return (object)this == obj;
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = -2142059824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB25D640Cu) % 3u)
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
				result = this.method_0();
				num = (int)((num2 * 1988552247) ^ 0x32572E4D);
			}
		}
	}

	internal static string Escape(string aText)
	{
		string text = default(string);
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		char c2 = default(char);
		char c = default(char);
		while (true)
		{
			int num = 2144751116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x662C7C57u) % 28u)
				{
				case 27u:
					num = ((int)num2 * -1968824620) ^ -1490690740;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, "\\t");
					num = 718220743;
					continue;
				case 23u:
					result = text;
					num = (int)((num2 * 2108232281) ^ 0x6825C2E8);
					continue;
				case 22u:
					string_ = aText;
					num3 = 0;
					num = (int)(num2 * 924625663) ^ -1776618496;
					continue;
				case 21u:
					num3++;
					num = ((int)num2 * -424186888) ^ -1497200361;
					continue;
				case 20u:
				{
					int num6;
					if (c2 != '"')
					{
						num = 1044480723;
						num6 = 1044480723;
					}
					else
					{
						num = 1714002794;
						num6 = 1714002794;
					}
					continue;
				}
				case 19u:
					goto IL_0095;
				case 18u:
				{
					char c3 = c;
					c2 = c3;
					switch (c2)
					{
					case '\t':
						break;
					case '\b':
						goto IL_0095;
					default:
						goto IL_00d3;
					case '\n':
						goto IL_00e6;
					case '\v':
						goto IL_00fc;
					case '\f':
						goto IL_0114;
					case '\r':
						goto IL_012a;
					}
					goto case 26u;
				}
				case 17u:
					goto IL_00e6;
				case 2u:
					goto IL_00fc;
				case 10u:
					goto IL_0114;
				case 7u:
					goto IL_012a;
				case 16u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 729820696;
						num5 = 729820696;
					}
					else
					{
						num = 1566241631;
						num5 = 1566241631;
					}
					continue;
				}
				case 15u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 405167056;
					continue;
				case 14u:
					num = (int)((num2 * 259916342) ^ 0x39CE3FA1);
					continue;
				case 13u:
					num = ((int)num2 * -1189369643) ^ -824702691;
					continue;
				case 12u:
					num = ((int)num2 * -1651230002) ^ 0x131267A;
					continue;
				case 11u:
					text = "";
					num = ((int)num2 * -1509253174) ^ -1790066901;
					continue;
				case 9u:
				{
					int num4;
					if (c2 != '\\')
					{
						num = 1775267133;
						num4 = 1775267133;
					}
					else
					{
						num = 1080504160;
						num4 = 1080504160;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -1831713874) ^ 0x4F0E4FC8;
					continue;
				case 6u:
					num = (int)((num2 * 580177872) ^ 0x66A6C9D3);
					continue;
				case 5u:
					num = (int)(num2 * 1715452370) ^ -714549843;
					continue;
				case 4u:
					num = ((int)num2 * -2037341141) ^ -750212896;
					continue;
				case 3u:
					num = 1279939726;
					continue;
				case 1u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 405167056;
					continue;
				case 0u:
					c = JSONNode.smethod_2(string_, num3);
					num = 303845329;
					continue;
				case 25u:
					break;
				default:
					{
						return result;
					}
					IL_012a:
					text = JSONNode.smethod_3(text, "\\r");
					num = 541459022;
					continue;
					IL_0114:
					text = JSONNode.smethod_3(text, "\\f");
					num = 405167056;
					continue;
					IL_00fc:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 405167056;
					continue;
					IL_00e6:
					text = JSONNode.smethod_3(text, "\\n");
					num = 537155900;
					continue;
					IL_00d3:
					num = (int)(num2 * 996908893) ^ -721278877;
					continue;
					IL_0095:
					text = JSONNode.smethod_3(text, "\\b");
					num = 982507651;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag8 = default(bool);
		string text2 = default(string);
		string text = default(string);
		JSONNode jSONNode = default(JSONNode);
		string s = default(string);
		bool flag6 = default(bool);
		int num10 = default(int);
		bool flag12 = default(bool);
		char c = default(char);
		char c2 = default(char);
		bool flag13 = default(bool);
		char c4 = default(char);
		bool flag10 = default(bool);
		bool flag14 = default(bool);
		char c5 = default(char);
		bool flag5 = default(bool);
		char c3 = default(char);
		bool flag3 = default(bool);
		bool flag15 = default(bool);
		bool flag2 = default(bool);
		bool flag9 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag11 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		while (true)
		{
			int num = 1902370401;
			while (true)
			{
				uint num2;
				int num22;
				int num46;
				switch ((num2 = (uint)num ^ 0x25A0100Au) % 156u)
				{
				case 155u:
				{
					int num18;
					int num19;
					if (flag8)
					{
						num18 = -1668520790;
						num19 = -1668520790;
					}
					else
					{
						num18 = -452214757;
						num19 = -452214757;
					}
					num = num18 ^ ((int)num2 * -1906473804);
					continue;
				}
				case 154u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = 538936998;
					continue;
				case 153u:
				{
					int num25;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 834852977;
						num25 = 834852977;
					}
					else
					{
						num = 1698315880;
						num25 = 1698315880;
					}
					continue;
				}
				case 152u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -1061596054) ^ 0x702DA3E9;
					continue;
				case 151u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1892067944) ^ 0x1CE1438);
					continue;
				case 150u:
					text = JSONNode.smethod_3(text, "\b");
					num = 1404116482;
					continue;
				case 149u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -289915416) ^ 0x5BE26906;
					continue;
				case 148u:
					num = ((int)num2 * -985556991) ^ -1516598187;
					continue;
				case 147u:
					num = ((int)num2 * -1707468900) ^ -870384578;
					continue;
				case 146u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 1378914311) ^ 0x58FCF8AD);
					continue;
				case 145u:
					num = (int)((num2 * 1524325291) ^ 0x43E5A472);
					continue;
				case 144u:
					num = ((int)num2 * -1190424169) ^ -1547371455;
					continue;
				case 143u:
					num = ((int)num2 * -1159842703) ^ 0x4456F5FB;
					continue;
				case 142u:
					stack.Push(new JSONArray());
					num = 644944638;
					continue;
				case 141u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -614528765) ^ -1141650883;
					continue;
				case 140u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 1425916769) ^ -1793686453;
					continue;
				case 139u:
					flag6 = !flag6;
					num = 2067958334;
					continue;
				case 138u:
					text2 = "";
					num = 920325177;
					continue;
				case 137u:
					num = ((int)num2 * -924169422) ^ 0x46F1CFC6;
					continue;
				case 136u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -635686226) ^ 0x5CDB6B1E;
					continue;
				case 135u:
					num = ((int)num2 * -1527490175) ^ -472571578;
					continue;
				case 134u:
					flag12 = flag6;
					num = 796608402;
					continue;
				case 133u:
				{
					int num5;
					int num6;
					if (c == 'b')
					{
						num5 = -1918246701;
						num6 = -1918246701;
					}
					else
					{
						num5 = -996384232;
						num6 = -996384232;
					}
					num = num5 ^ ((int)num2 * -122080325);
					continue;
				}
				case 132u:
					num = (int)(num2 * 998416120) ^ -1878287616;
					continue;
				case 131u:
				{
					int num56;
					int num57;
					if ((uint)c2 <= 44u)
					{
						num56 = 709076069;
						num57 = 709076069;
					}
					else
					{
						num56 = 2044294600;
						num57 = 2044294600;
					}
					num = num56 ^ ((int)num2 * -563774133);
					continue;
				}
				case 130u:
				{
					int num53;
					if (flag6)
					{
						num = 738744510;
						num53 = 738744510;
					}
					else
					{
						num = 424341121;
						num53 = 424341121;
					}
					continue;
				}
				case 129u:
					text = JSONNode.smethod_3(text, "\n");
					num = 61627322;
					continue;
				case 34u:
				case 52u:
				case 68u:
				case 75u:
				case 128u:
					num10++;
					num = 1696935834;
					continue;
				case 127u:
					num = (int)(num2 * 886353418) ^ -1457719101;
					continue;
				case 126u:
				{
					int num49;
					if (c == 'f')
					{
						num = 1017652366;
						num49 = 1017652366;
					}
					else
					{
						num = 1949093342;
						num49 = 1949093342;
					}
					continue;
				}
				case 125u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1513725846) ^ 0x7E0D3203);
					continue;
				case 124u:
					flag13 = JSONNode.smethod_6(text2, "");
					num = 1942855235;
					continue;
				case 123u:
					c = c4;
					num = ((int)num2 * -1600876459) ^ -29939779;
					continue;
				case 122u:
					num = ((int)num2 * -433213652) ^ 0x1CB192;
					continue;
				case 121u:
					flag10 = jSONNode is JSONArray;
					num = (int)((num2 * 1295930767) ^ 0xD040A9B);
					continue;
				case 120u:
				{
					int num41;
					int num42;
					if (!flag12)
					{
						num41 = -1765269641;
						num42 = -1765269641;
					}
					else
					{
						num41 = -2071661841;
						num42 = -2071661841;
					}
					num = num41 ^ (int)(num2 * 1590740412);
					continue;
				}
				case 119u:
					text = "";
					num = (int)((num2 * 312156310) ^ 0xDCB6FDC);
					continue;
				case 118u:
					switch (c)
					{
					case 'r':
						goto IL_040f;
					case 's':
						goto IL_0425;
					case 't':
						goto IL_043d;
					case 'u':
						goto IL_0453;
					}
					num = 1255942066;
					continue;
				case 106u:
					goto IL_040f;
				case 108u:
					goto IL_0425;
				case 65u:
					goto IL_043d;
				case 62u:
					goto IL_0453;
				case 116u:
					jSONNode.Add(text);
					num = (int)((num2 * 1065910809) ^ 0x849ACDD);
					continue;
				case 115u:
				{
					int num33;
					int num34;
					if (!flag14)
					{
						num33 = -1193350156;
						num34 = -1193350156;
					}
					else
					{
						num33 = -680694772;
						num34 = -680694772;
					}
					num = num33 ^ ((int)num2 * -1990137191);
					continue;
				}
				case 114u:
					num = (int)((num2 * 1189807860) ^ 0x2AC031D2);
					continue;
				case 113u:
				{
					int num28;
					int num29;
					if (!flag13)
					{
						num28 = 1928066142;
						num29 = 1928066142;
					}
					else
					{
						num28 = 1275640335;
						num29 = 1275640335;
					}
					num = num28 ^ (int)(num2 * 1600196526);
					continue;
				}
				case 112u:
					switch (c2)
					{
					case '[':
						goto IL_0501;
					case '\\':
						goto IL_0521;
					case ']':
						goto IL_0533;
					}
					num = 1347710026;
					continue;
				case 51u:
					goto IL_0501;
				case 97u:
					goto IL_0521;
				case 23u:
					goto IL_0533;
				case 111u:
					c2 = c5;
					num = (int)((num2 * 1148209516) ^ 0x2FEDD285);
					continue;
				case 110u:
				{
					int num15;
					if (flag6)
					{
						num = 161379053;
						num15 = 161379053;
					}
					else
					{
						num = 1344258552;
						num15 = 1344258552;
					}
					continue;
				}
				case 109u:
					flag5 = jSONNode is JSONArray;
					num = ((int)num2 * -1064992040) ^ -1933951341;
					continue;
				case 107u:
					num = (int)((num2 * 1936977623) ^ 0x404B5B0A);
					continue;
				case 105u:
					num = ((int)num2 * -860614461) ^ 0x25B0C0C0;
					continue;
				case 104u:
					num = 2069020248;
					continue;
				case 102u:
					c3 = JSONNode.smethod_2(aJSON, num10);
					c4 = c3;
					num = (int)(num2 * 613194724) ^ -1992939419;
					continue;
				case 101u:
					flag3 = JSONNode.smethod_6(text2, "");
					num = 847147800;
					continue;
				case 100u:
					num = (int)(num2 * 2145801382) ^ -1992051515;
					continue;
				case 99u:
					text2 = "";
					num = 1905187716;
					continue;
				case 98u:
					text = "";
					num = ((int)num2 * -834633864) ^ 0x3C57B57;
					continue;
				case 96u:
					num = ((int)num2 * -1384362595) ^ 0x2A82EF6;
					continue;
				case 95u:
					num = ((int)num2 * -790671214) ^ -652871013;
					continue;
				case 94u:
				{
					int num60;
					if (c == 'n')
					{
						num = 1771770379;
						num60 = 1771770379;
					}
					else
					{
						num = 172656853;
						num60 = 172656853;
					}
					continue;
				}
				case 93u:
					num = ((int)num2 * -309114074) ^ -2019386905;
					continue;
				case 92u:
					num = ((int)num2 * -452363716) ^ -227468514;
					continue;
				case 91u:
					num = (int)(num2 * 1319176202) ^ -1472200794;
					continue;
				case 90u:
					num = (int)((num2 * 338033263) ^ 0x2AA008E4);
					continue;
				case 89u:
				{
					int num58;
					int num59;
					if (!flag5)
					{
						num58 = -1887921558;
						num59 = -1887921558;
					}
					else
					{
						num58 = -1946152341;
						num59 = -1946152341;
					}
					num = num58 ^ (int)(num2 * 1181767756);
					continue;
				}
				case 88u:
					stack.Pop();
					num = 621597223;
					continue;
				case 87u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1765525615) ^ -1722660615;
					continue;
				case 86u:
					num = (int)((num2 * 1259949718) ^ 0x1F125AB9);
					continue;
				case 85u:
				{
					int num54;
					int num55;
					if (!flag15)
					{
						num54 = 1470048519;
						num55 = 1470048519;
					}
					else
					{
						num54 = 106913268;
						num55 = 106913268;
					}
					num = num54 ^ (int)(num2 * 1673562702);
					continue;
				}
				case 84u:
					flag2 = stack.Count > 0;
					num = ((int)num2 * -1142974259) ^ 0x40D135D9;
					continue;
				case 83u:
				{
					int num51;
					int num52;
					if (flag9)
					{
						num51 = 1223606184;
						num52 = 1223606184;
					}
					else
					{
						num51 = 255231281;
						num52 = 255231281;
					}
					num = num51 ^ (int)(num2 * 485802015);
					continue;
				}
				case 82u:
				{
					int num50;
					if (c2 != '{')
					{
						num = 1802364131;
						num50 = 1802364131;
					}
					else
					{
						num = 694821224;
						num50 = 694821224;
					}
					continue;
				}
				case 81u:
					text2 = text;
					num = 1835767200;
					continue;
				case 80u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -961708260) ^ 0x7EA52417;
					continue;
				case 79u:
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -317446784) ^ -1810091059;
					continue;
				case 78u:
					flag14 = flag6;
					num = ((int)num2 * -2111479645) ^ -533360221;
					continue;
				case 77u:
				{
					int num47;
					int num48;
					if (!(jSONNode is JSONArray))
					{
						num47 = -113663918;
						num48 = -113663918;
					}
					else
					{
						num47 = -1254059184;
						num48 = -1254059184;
					}
					num = num47 ^ (int)(num2 * 467472877);
					continue;
				}
				case 76u:
					num10 = 0;
					num = (int)(num2 * 1273387824) ^ -1569764497;
					continue;
				case 74u:
					num = (int)(num2 * 1971583525) ^ -1333289248;
					continue;
				case 73u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 837879138) ^ 0x4302FB55);
					continue;
				case 72u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -1021840185) ^ -1244513262;
					continue;
				case 71u:
					switch (c2)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_08e7;
					case '\t':
						goto IL_08fa;
					case '\v':
					case '\f':
						goto IL_091a;
					}
					goto case 34u;
				case 2u:
					goto IL_08fa;
				case 59u:
					goto IL_091a;
				case 70u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)((num2 * 184525531) ^ 0x26ADA6FB);
					continue;
				case 69u:
					result = jSONNode;
					num = 1351773978;
					continue;
				case 67u:
				{
					int num45;
					if (c2 == ' ')
					{
						num = 1520341628;
						num45 = 1520341628;
					}
					else
					{
						num = 1541472561;
						num45 = 1541472561;
					}
					continue;
				}
				case 66u:
				{
					int num43;
					int num44;
					if ((uint)c2 <= 32u)
					{
						num43 = 1350064943;
						num44 = 1350064943;
					}
					else
					{
						num43 = 1353748385;
						num44 = 1353748385;
					}
					num = num43 ^ ((int)num2 * -1387740657);
					continue;
				}
				case 64u:
					text = JSONNode.smethod_3(text, "\f");
					num = 166466290;
					continue;
				case 63u:
					num = ((int)num2 * -1850142418) ^ -667802604;
					continue;
				case 61u:
				{
					int num39;
					int num40;
					if (!flag11)
					{
						num39 = 2109028493;
						num40 = 2109028493;
					}
					else
					{
						num39 = 517306171;
						num40 = 517306171;
					}
					num = num39 ^ (int)(num2 * 1125677399);
					continue;
				}
				case 60u:
				{
					int num38;
					if (stack.Count != 0)
					{
						num = 1240928414;
						num38 = 1240928414;
					}
					else
					{
						num = 40339812;
						num38 = 40339812;
					}
					continue;
				}
				case 58u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -784486358) ^ -1537738666;
					continue;
				case 57u:
					num = ((int)num2 * -1935712459) ^ -1529727365;
					continue;
				case 56u:
					num = ((int)num2 * -1453805299) ^ 0x597E222F;
					continue;
				case 55u:
				{
					int num37;
					if ((uint)c2 <= 93u)
					{
						num = 1454586360;
						num37 = 1454586360;
					}
					else
					{
						num = 751954480;
						num37 = 751954480;
					}
					continue;
				}
				case 54u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = ((int)num2 * -2115851878) ^ -2130408891;
					continue;
				case 53u:
					num = (int)(num2 * 1751827979) ^ -1917743295;
					continue;
				case 50u:
					num = 42357812;
					continue;
				case 49u:
					num = (int)(num2 * 1818705020) ^ -394187534;
					continue;
				case 48u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = (int)((num2 * 1419288776) ^ 0x67B7255F);
					continue;
				case 47u:
				{
					int num35;
					int num36;
					if (!flag4)
					{
						num35 = 1665684347;
						num36 = 1665684347;
					}
					else
					{
						num35 = 1203837370;
						num36 = 1203837370;
					}
					num = num35 ^ (int)(num2 * 2031596993);
					continue;
				}
				case 46u:
					text = "";
					num = (int)(num2 * 866126884) ^ -1650386258;
					continue;
				case 45u:
					flag15 = JSONNode.smethod_6(text, "");
					num = (int)(num2 * 1316250113) ^ -732503226;
					continue;
				case 43u:
					jSONNode = null;
					num = ((int)num2 * -1930491287) ^ -1733530871;
					continue;
				case 42u:
				{
					int num31;
					int num32;
					if (c2 != ':')
					{
						num31 = -133119117;
						num32 = -133119117;
					}
					else
					{
						num31 = -534976596;
						num32 = -534976596;
					}
					num = num31 ^ ((int)num2 * -1163331780);
					continue;
				}
				case 41u:
				{
					int num30;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 179211146;
						num30 = 179211146;
					}
					else
					{
						num = 10713837;
						num30 = 10713837;
					}
					continue;
				}
				case 40u:
					flag6 = false;
					num = (int)(num2 * 971463520) ^ -2001581185;
					continue;
				case 39u:
					num = (int)((num2 * 171662445) ^ 0x6DEFFF9E);
					continue;
				case 38u:
				{
					int num26;
					int num27;
					if (!flag3)
					{
						num26 = 546217951;
						num27 = 546217951;
					}
					else
					{
						num26 = 1372984020;
						num27 = 1372984020;
					}
					num = num26 ^ (int)(num2 * 289829292);
					continue;
				}
				case 37u:
					text = "";
					text2 = "";
					num = ((int)num2 * -1108831861) ^ 0x54E4D815;
					continue;
				case 36u:
				{
					int num23;
					int num24;
					if ((uint)c > 102u)
					{
						num23 = 601401100;
						num24 = 601401100;
					}
					else
					{
						num23 = 936809387;
						num24 = 936809387;
					}
					num = num23 ^ (int)(num2 * 647689990);
					continue;
				}
				case 35u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -52860407) ^ -1729062297;
					continue;
				case 33u:
					num = ((int)num2 * -1216745723) ^ 0x76304417;
					continue;
				case 32u:
					text2 = "";
					num = 1119807254;
					continue;
				case 31u:
					num10 += 4;
					num = ((int)num2 * -769199817) ^ 0x1EA82A31;
					continue;
				case 29u:
					num = (int)((num2 * 77019954) ^ 0x66D407E2);
					continue;
				case 28u:
					num = (int)((num2 * 2096478629) ^ 0x5A9336DD);
					continue;
				case 27u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -758901822) ^ 0x4ED3305E;
					continue;
				case 26u:
					jSONNode.Add(text);
					num = ((int)num2 * -1964474801) ^ 0x2C4389F5;
					continue;
				case 25u:
					num = ((int)num2 * -543914388) ^ 0x393D9CDC;
					continue;
				case 24u:
					num = (int)(num2 * 1767899552) ^ -1143941714;
					continue;
				case 22u:
				{
					int num20;
					int num21;
					if (!flag10)
					{
						num20 = -318305165;
						num21 = -318305165;
					}
					else
					{
						num20 = -2142233296;
						num21 = -2142233296;
					}
					num = num20 ^ ((int)num2 * -215314458);
					continue;
				}
				case 21u:
					num = 558354569;
					continue;
				case 20u:
					num = ((int)num2 * -1729496313) ^ 0x38C1488A;
					continue;
				case 19u:
					c5 = JSONNode.smethod_2(aJSON, num10);
					num = 1914760609;
					continue;
				case 18u:
					flag9 = JSONNode.smethod_6(text, "");
					num = 1611049553;
					continue;
				case 17u:
					flag = jSONNode != null;
					num = (int)(num2 * 239818539) ^ -64952496;
					continue;
				case 16u:
				{
					int num16;
					int num17;
					if (!flag7)
					{
						num16 = -754121114;
						num17 = -754121114;
					}
					else
					{
						num16 = -1495705724;
						num17 = -1495705724;
					}
					num = num16 ^ (int)(num2 * 313978495);
					continue;
				}
				case 15u:
					stack.Push(new JSONClass());
					num = 634508419;
					continue;
				case 14u:
					num = 1454016094;
					continue;
				case 13u:
					num = (int)((num2 * 2093024470) ^ 0x51D4255D);
					continue;
				case 12u:
				{
					int num14;
					if (c2 == ',')
					{
						num = 321116496;
						num14 = 321116496;
					}
					else
					{
						num = 2024575565;
						num14 = 2024575565;
					}
					continue;
				}
				case 11u:
				{
					int num13;
					if (c2 != '}')
					{
						num = 1323876587;
						num13 = 1323876587;
					}
					else
					{
						num = 1588240665;
						num13 = 1588240665;
					}
					continue;
				}
				case 10u:
					num = (int)(num2 * 37450817) ^ -427790528;
					continue;
				case 9u:
					flag4 = num10 < JSONNode.smethod_4(aJSON);
					num = 1545906133;
					continue;
				case 8u:
				{
					int num11;
					int num12;
					if (!(jSONNode != null))
					{
						num11 = -113125012;
						num12 = -113125012;
					}
					else
					{
						num11 = -1426342005;
						num12 = -1426342005;
					}
					num = num11 ^ (int)(num2 * 208582225);
					continue;
				}
				case 7u:
					num = 502358690;
					continue;
				case 6u:
					s = JSONNode.smethod_8(aJSON, num10 + 1, 4);
					num = (int)(num2 * 916522419) ^ -451747420;
					continue;
				case 5u:
				{
					int num9;
					if (c2 == '"')
					{
						num = 1205189077;
						num9 = 1205189077;
					}
					else
					{
						num = 2136873700;
						num9 = 2136873700;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -1484214509) ^ 0x5A864C35;
					continue;
				case 3u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = 2037634052;
						num8 = 2037634052;
					}
					else
					{
						num7 = 383064321;
						num8 = 383064321;
					}
					num = num7 ^ ((int)num2 * -1119471983);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 454049898;
						num4 = 454049898;
					}
					else
					{
						num3 = 706508152;
						num4 = 706508152;
					}
					num = num3 ^ (int)(num2 * 310381908);
					continue;
				}
				case 0u:
					text = "";
					num = ((int)num2 * -587957281) ^ 0x50FA186F;
					continue;
				case 44u:
					break;
				case 30u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 117u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0521:
					num10++;
					flag11 = flag6;
					num = 727529187;
					continue;
					IL_0501:
					if (!flag6)
					{
						num = 1175810744;
						num22 = 1175810744;
					}
					else
					{
						num = 448726039;
						num22 = 448726039;
					}
					continue;
					IL_0533:
					flag7 = flag6;
					num = 1378907554;
					continue;
					IL_0453:
					num = 736685440;
					continue;
					IL_043d:
					text = JSONNode.smethod_3(text, "\t");
					num = 1117638317;
					continue;
					IL_0425:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1117638317;
					continue;
					IL_040f:
					text = JSONNode.smethod_3(text, "\r");
					num = 799573833;
					continue;
					IL_091a:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num10).ToString());
					num = 2067958334;
					continue;
					IL_08fa:
					if (!flag6)
					{
						num = 1039176773;
						num46 = 1039176773;
					}
					else
					{
						num = 1330983312;
						num46 = 1330983312;
					}
					continue;
					IL_08e7:
					num = (int)(num2 * 1615767447) ^ -782035732;
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
			int num = 115897091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6075D956u) % 4u)
				{
				case 2u:
					Serialize(aWriter);
					num = (int)((num2 * 1480871934) ^ 0x1DEA1E65);
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -478327828) ^ 0x20779D88;
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
					int num = 162093748;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x7F97675Du) % 4u)
						{
						case 3u:
							num = ((int)num2 * -1193800397) ^ 0x4D84AE46;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -2054373336) ^ 0x51088B76;
							continue;
						default:
							goto end_IL_004d;
						case 0u:
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
			while (true)
			{
				int num = -1622611514;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC7D4D293u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1249577082) ^ 0x79EB220F;
						continue;
					case 4u:
						num = ((int)num2 * -709052391) ^ -1744527618;
						continue;
					case 2u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 268838127) ^ 0x71D69CA9);
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = (int)((num2 * 500867783) ^ 0x3FEE863D);
						continue;
					case 0u:
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
					IL_00cc:
					int num3 = -1387165822;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xC7D4D293u) % 3u)
						{
						case 2u:
							goto IL_009c;
						default:
							goto end_IL_00af;
						case 0u:
							break;
						case 1u:
							goto end_IL_00af;
						}
						goto IL_00cc;
						IL_009c:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -514891114) ^ 0x7DC31CF;
						continue;
						end_IL_00af:
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
		JSONNode result = default(JSONNode);
		int num7 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num6 = default(int);
		JSONArray jSONArray = default(JSONArray);
		bool flag = default(bool);
		string aKey = default(string);
		int num3 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num4 = default(int);
		while (true)
		{
			int num = -669013260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD346F847u) % 35u)
				{
				case 34u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -690317749;
					continue;
				case 33u:
					num = ((int)num2 * -1106557452) ^ 0x7AD599CF;
					continue;
				case 32u:
					num7 = 0;
					num = (int)(num2 * 25028946) ^ -1196520390;
					continue;
				case 31u:
				{
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 1288837646) ^ 0x5A520F60);
					continue;
				}
				case 30u:
					num6 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = (int)(num2 * 609767680) ^ -415209303;
					continue;
				case 29u:
					num = ((int)num2 * -1117206264) ^ 0x115027E7;
					continue;
				case 28u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -1563637005;
						num9 = -1563637005;
					}
					else
					{
						num8 = -1176046234;
						num9 = -1176046234;
					}
					num = num8 ^ ((int)num2 * -1984104942);
					continue;
				}
				case 27u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					default:
						goto IL_00e4;
					case JSONBinaryTag.Array:
						goto IL_00f7;
					case JSONBinaryTag.Class:
						goto IL_0101;
					case JSONBinaryTag.Value:
						goto IL_0113;
					case JSONBinaryTag.IntValue:
						goto IL_012a;
					case JSONBinaryTag.BoolValue:
						goto IL_0141;
					case JSONBinaryTag.FloatValue:
						goto IL_014b;
					}
					goto case 34u;
				case 6u:
					goto IL_00f7;
				case 19u:
					goto IL_0101;
				case 26u:
					goto IL_0113;
				case 11u:
					goto IL_012a;
				case 5u:
					goto IL_0141;
				case 4u:
					goto IL_014b;
				case 25u:
					num = (int)((num2 * 573156688) ^ 0x2C60EAD2);
					continue;
				case 23u:
					num = ((int)num2 * -1169214612) ^ -23993530;
					continue;
				case 22u:
					num7++;
					num = ((int)num2 * -1511971213) ^ 0x3F58CE86;
					continue;
				case 21u:
					aKey = JSONNode.smethod_22(aReader);
					num = -191717348;
					continue;
				case 20u:
					num3 = 0;
					num = ((int)num2 * -1191649814) ^ -1945419001;
					continue;
				case 18u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1843081041) ^ -485274463;
					continue;
				case 17u:
					flag = num7 < num6;
					num = -1277180389;
					continue;
				case 16u:
					result = jSONClass;
					num = (int)((num2 * 1034246545) ^ 0x3D065DD4);
					continue;
				case 15u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 1196875690) ^ 0x6015A21C);
					continue;
				case 14u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)(num2 * 2027054623) ^ -829454758;
					continue;
				case 13u:
					num = (int)(num2 * 1310129940) ^ -991158622;
					continue;
				case 10u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -870885716) ^ 0x1E2EA76B;
					continue;
				}
				case 9u:
					num = ((int)num2 * -1572702071) ^ -288810039;
					continue;
				case 8u:
					num3++;
					num = (int)((num2 * 977203543) ^ 0x45726BDA);
					continue;
				case 7u:
					num = (int)(num2 * 1425630414) ^ -1884612774;
					continue;
				case 3u:
					jSONArray.Add(Deserialize(aReader));
					num = -908914195;
					continue;
				case 2u:
				{
					int num5;
					if (num3 >= num4)
					{
						num = -1674986399;
						num5 = -1674986399;
					}
					else
					{
						num = -372943060;
						num5 = -372943060;
					}
					continue;
				}
				case 0u:
					result = jSONArray;
					num = (int)((num2 * 2057285038) ^ 0x2313312C);
					continue;
				case 12u:
					break;
				case 24u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_014b:
					num = -768360811;
					continue;
					IL_0141:
					num = -447487297;
					continue;
					IL_012a:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -1707961774;
					continue;
					IL_0113:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1707961774;
					continue;
					IL_0101:
					num4 = JSONNode.smethod_21(aReader);
					num = -683504978;
					continue;
					IL_00f7:
					num = -963164391;
					continue;
					IL_00e4:
					num = ((int)num2 * -591565408) ^ -2116188997;
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
					int num = 1685607497;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x5A71CFFCu) % 4u)
						{
						case 3u:
							num = (int)((num2 * 1105101816) ^ 0x2FC2F56);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = (int)((num2 * 1233906144) ^ 0x59F9DABF);
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
				int num = -890661250;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB9E93DC3u) % 3u)
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
					num = (int)(num2 * 1757555468) ^ -1210636622;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0079:
					int num3 = -582343889;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xB9E93DC3u) % 3u)
						{
						case 1u:
							goto IL_0049;
						default:
							goto end_IL_005c;
						case 0u:
							break;
						case 2u:
							goto end_IL_005c;
						}
						goto IL_0079;
						IL_0049:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)((num2 * 640990584) ^ 0x1F294DE0);
						continue;
						end_IL_005c:
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
			int num = -121156116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3DD30EBu) % 5u)
				{
				case 4u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -2141615038) ^ -1387038859;
					continue;
				case 3u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -912403380) ^ -756461035;
					continue;
				}
				case 1u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 740209141) ^ -937494287;
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
