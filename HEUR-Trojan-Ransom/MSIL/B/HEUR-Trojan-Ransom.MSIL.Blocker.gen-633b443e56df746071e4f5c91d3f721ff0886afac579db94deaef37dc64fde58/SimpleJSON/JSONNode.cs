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
				int num = -1994576485;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE2CCC652u) % 4u)
					{
					case 1u:
						result = null;
						num = ((int)num2 * -336208799) ^ -882592125;
						continue;
					case 0u:
						num = ((int)num2 * -314857460) ^ 0x51B6A76D;
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

	public virtual JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -1643113854;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x84EFAE64u) % 4u)
					{
					case 2u:
						result = null;
						num = ((int)num2 * -151053052) ^ 0x37696C89;
						continue;
					case 1u:
						num = ((int)num2 * -724390048) ^ -1815835149;
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
				int num = 2067953258;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x65FBB24Bu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1329853093) ^ 0x4232AA24);
						continue;
					case 1u:
						result = 0;
						num = (int)((num2 * 2077056779) ^ 0x734AEBD7);
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
			while (true)
			{
				int num = -1799135551;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB248E7FAu) % 3u)
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
					num = (int)((num2 * 647127324) ^ 0x9089E47);
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
				int num = 217075917;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7708D346u) % 4u)
					{
					case 3u:
						_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -1373119766) ^ 0x1BEC87A5;
						continue;
					case 1u:
						result = _003Cget_DeepChilds_003Ed__;
						num = (int)((num2 * 632669449) ^ 0x1E7EE339);
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

	public virtual int AsInt
	{
		get
		{
			int result = 0;
			if (int.TryParse(Value, out result))
			{
				goto IL_0011;
			}
			goto IL_006e;
			IL_006e:
			int result2 = 0;
			int num = -568650697;
			goto IL_0045;
			IL_0045:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAED94CC9u) % 6u)
				{
				case 4u:
					break;
				case 2u:
					num = ((int)num2 * -1029474500) ^ -117760688;
					continue;
				case 1u:
					result2 = result;
					num = ((int)num2 * -2129864849) ^ -233075202;
					continue;
				case 0u:
					num = ((int)num2 * -672772224) ^ 0x5DBE2738;
					continue;
				case 5u:
					goto IL_006e;
				default:
					return result2;
				}
				break;
			}
			goto IL_0011;
			IL_0011:
			num = -351688298;
			goto IL_0045;
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
			while (true)
			{
				int num = 1815293878;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5661E2Du) % 6u)
					{
					case 3u:
						num = ((int)num2 * -219789688) ^ 0x25CC7E0C;
						continue;
					case 2u:
						result = result2;
						num = (int)(num2 * 720051740) ^ -1722961980;
						continue;
					case 1u:
					{
						result2 = 0f;
						int num3;
						int num4;
						if (!float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = -1396279376;
							num4 = -1396279376;
						}
						else
						{
							num3 = -1305437534;
							num4 = -1305437534;
						}
						num = num3 ^ (int)(num2 * 1811656737);
						continue;
					}
					case 0u:
						result = 0f;
						num = 29894994;
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

	public virtual double AsDouble
	{
		get
		{
			double result = default(double);
			double result2 = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = 98297536;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2CF9C514u) % 9u)
					{
					case 8u:
						result = result2;
						num = (int)((num2 * 1125137017) ^ 0x511EB871);
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -378465869;
							num4 = -378465869;
						}
						else
						{
							num3 = -1914721583;
							num4 = -1914721583;
						}
						num = num3 ^ (int)(num2 * 1256379849);
						continue;
					}
					case 6u:
						num = (int)((num2 * 530517884) ^ 0x134453AD);
						continue;
					case 3u:
						num = ((int)num2 * -77520888) ^ -455340975;
						continue;
					case 2u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -1658262971) ^ 0x38FA4B3D;
						continue;
					case 1u:
						result2 = 0.0;
						num = ((int)num2 * -970161830) ^ -750666389;
						continue;
					case 0u:
						result = 0.0;
						num = 1991179317;
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
			while (true)
			{
				int num = 2026582171;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13AA88DDu) % 3u)
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
					num = (int)((num2 * 1848654242) ^ 0x1319CA86);
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
				int num = 68496984;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D31EC89u) % 8u)
					{
					case 7u:
						result = result2;
						num = ((int)num2 * -252130004) ^ 0x41985595;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1826612722;
							num4 = -1826612722;
						}
						else
						{
							num3 = -1361964293;
							num4 = -1361964293;
						}
						num = num3 ^ ((int)num2 * -335095348);
						continue;
					}
					case 4u:
						num = (int)(num2 * 597020892) ^ -226515663;
						continue;
					case 3u:
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -1055681503) ^ -1012931780;
						continue;
					case 2u:
						result = !JSONNode.smethod_1(Value);
						num = 1786913981;
						continue;
					case 1u:
						result2 = false;
						num = ((int)num2 * -1485518328) ^ 0x5C28626A;
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
				int num = 782828873;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2465F1CAu) % 3u)
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
					result = this as JSONArray;
					num = (int)((num2 * 196603997) ^ 0x35823293);
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
				int num = -389274381;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE078601Eu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1328554593) ^ 0x73016233;
						continue;
					case 1u:
						result = this as JSONClass;
						num = (int)(num2 * 1142661508) ^ -316561303;
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
		while (true)
		{
			int num = -2048257810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA43620ABu) % 3u)
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
				num = ((int)num2 * -352964915) ^ -1556711100;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1422235031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C99779Au) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1919005047) ^ -1611741629;
					continue;
				case 1u:
					result = null;
					num = (int)(num2 * 912360510) ^ -925527514;
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
			int num = -1742855045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEB98718u) % 3u)
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
				num = (int)((num2 * 1770365567) ^ 0x20B3B76);
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		return aNode;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1499606506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCD5FDEF7u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 452739249) ^ -334225590;
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)((num2 * 1710910625) ^ 0x25415C01);
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
		string result = default(string);
		while (true)
		{
			int num = -1233712692;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE4FABACu) % 3u)
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
				num = ((int)num2 * -161282041) ^ 0xED476B;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 237682533;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D17715Au) % 3u)
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
				num = ((int)num2 * -1269375015) ^ 0x45967B0C;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 524256676;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x73C6EC0Fu) % 5u)
				{
				case 3u:
					if (!(d == null))
					{
						num = ((int)num2 * -975091793) ^ 0x561FD69B;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 2u:
					num = ((int)num2 * -1285480404) ^ -2040246815;
					continue;
				case 1u:
					obj = d.Value;
					goto IL_001c;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = 589737492;
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
			goto IL_0035;
		}
		int num = 0;
		goto IL_0094;
		IL_0094:
		bool flag = (byte)num != 0;
		int num2 = -737640445;
		goto IL_005e;
		IL_0035:
		num2 = -60713836;
		goto IL_005e;
		IL_005e:
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xEDE0E6E1u) % 7u)
			{
			case 6u:
				result = (object)a == b;
				num2 = -721293393;
				continue;
			case 5u:
				result = true;
				num2 = (int)(num3 * 1395476045) ^ -1132995739;
				continue;
			case 4u:
				num2 = (int)((num3 * 519921249) ^ 0x43E8D237);
				continue;
			case 3u:
				break;
			case 0u:
			{
				int num4;
				int num5;
				if (!flag)
				{
					num4 = 1419903474;
					num5 = 1419903474;
				}
				else
				{
					num4 = 1392192159;
					num5 = 1392192159;
				}
				num2 = num4 ^ (int)(num3 * 456091049);
				continue;
			}
			case 1u:
				goto IL_008b;
			default:
				return result;
			}
			break;
		}
		goto IL_0035;
		IL_008b:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_0094;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1182872256;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6FB9ED71u) % 3u)
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
				result = !(a == b);
				num = (int)((num2 * 781244636) ^ 0x31516D6F);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1423104021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A70BA78u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 688975349) ^ 0x23998A4D);
					continue;
				case 1u:
					result = (object)this == obj;
					num = ((int)num2 * -1400795221) ^ 0x4D1828D8;
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
			int num = 184904668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51545192u) % 3u)
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
				num = (int)((num2 * 1603987736) ^ 0x5B69E1E);
			}
		}
	}

	internal static string Escape(string aText)
	{
		int num3 = default(int);
		char c2 = default(char);
		string text = default(string);
		string string_ = default(string);
		char c = default(char);
		char c3 = default(char);
		string result = default(string);
		while (true)
		{
			int num = -347732719;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC9CE4FB1u) % 31u)
				{
				case 30u:
					num3++;
					num = (int)((num2 * 1041889066) ^ 0x5F3533C4);
					continue;
				case 29u:
					switch (c2)
					{
					case '\b':
						goto IL_0051;
					case '\t':
						goto IL_0067;
					case '\n':
						goto IL_007d;
					case '\v':
						goto IL_0093;
					case '\f':
						goto IL_00ab;
					case '\r':
						goto IL_00c1;
					}
					num = (int)(num2 * 283818192) ^ -1882374718;
					continue;
				case 22u:
					goto IL_0051;
				case 9u:
					goto IL_0067;
				case 2u:
					goto IL_007d;
				case 13u:
					goto IL_0093;
				case 7u:
					goto IL_00ab;
				case 12u:
					goto IL_00c1;
				case 28u:
					num = ((int)num2 * -425748967) ^ 0x50AF5FBA;
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1566469473;
					continue;
				case 26u:
					num = (int)(num2 * 400046035) ^ -403422711;
					continue;
				case 25u:
					string_ = aText;
					num3 = 0;
					num = (int)((num2 * 2145801748) ^ 0x4EC911AF);
					continue;
				case 24u:
					num = (int)(num2 * 628374536) ^ -591046572;
					continue;
				case 23u:
				{
					int num6;
					if (c2 == '\\')
					{
						num = -210772799;
						num6 = -210772799;
					}
					else
					{
						num = -621522991;
						num6 = -621522991;
					}
					continue;
				}
				case 21u:
				{
					int num5;
					if (c2 != '"')
					{
						num = -2023508793;
						num5 = -2023508793;
					}
					else
					{
						num = -2021175406;
						num5 = -2021175406;
					}
					continue;
				}
				case 20u:
					num = ((int)num2 * -545484685) ^ -441400507;
					continue;
				case 19u:
					num = ((int)num2 * -944918636) ^ 0x258A61F9;
					continue;
				case 18u:
					text = "";
					num = ((int)num2 * -120177250) ^ -1675446159;
					continue;
				case 16u:
					num = ((int)num2 * -315280580) ^ 0x7BF22CD4;
					continue;
				case 15u:
					num = -242650225;
					continue;
				case 14u:
					c = c3;
					num = ((int)num2 * -1453454265) ^ 0x2E82FBF7;
					continue;
				case 10u:
					num = (int)((num2 * 1908267856) ^ 0x175A5488);
					continue;
				case 8u:
					num = (int)((num2 * 1030927392) ^ 0x7ABC8524);
					continue;
				case 6u:
					c3 = JSONNode.smethod_2(string_, num3);
					num = -1371815811;
					continue;
				case 5u:
					result = text;
					num = ((int)num2 * -1245450890) ^ 0x61252E81;
					continue;
				case 4u:
				{
					int num4;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -752608772;
						num4 = -752608772;
					}
					else
					{
						num = -1480760910;
						num4 = -1480760910;
					}
					continue;
				}
				case 3u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -306654524;
					continue;
				case 1u:
					c2 = c;
					num = ((int)num2 * -1472449129) ^ -20653211;
					continue;
				case 0u:
					num = ((int)num2 * -232908508) ^ -412697872;
					continue;
				case 17u:
					break;
				default:
					{
						return result;
					}
					IL_00ab:
					text = JSONNode.smethod_3(text, "\\f");
					num = -931438963;
					continue;
					IL_0093:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -306654524;
					continue;
					IL_007d:
					text = JSONNode.smethod_3(text, "\\n");
					num = -151511186;
					continue;
					IL_0067:
					text = JSONNode.smethod_3(text, "\\t");
					num = -306654524;
					continue;
					IL_0051:
					text = JSONNode.smethod_3(text, "\\b");
					num = -799865373;
					continue;
					IL_00c1:
					text = JSONNode.smethod_3(text, "\\r");
					num = -689941522;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		string text2 = default(string);
		int num5 = default(int);
		char c4 = default(char);
		bool flag4 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag11 = default(bool);
		bool flag5 = default(bool);
		string text = default(string);
		bool flag2 = default(bool);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		char c3 = default(char);
		bool flag7 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		string s = default(string);
		char c = default(char);
		char c2 = default(char);
		JSONNode result = default(JSONNode);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = -1703769373;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2C4A8EBu) % 153u)
				{
				case 152u:
				{
					int num40;
					if (stack.Count == 0)
					{
						num = -5566623;
						num40 = -5566623;
					}
					else
					{
						num = -972534148;
						num40 = -972534148;
					}
					continue;
				}
				case 151u:
					num = -2103622271;
					continue;
				case 150u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = -1649356433;
					continue;
				case 149u:
					num = -1219087377;
					continue;
				case 148u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 1056984597) ^ 0x6F99F09);
					continue;
				case 147u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num5);
					c4 = c5;
					int num49;
					int num50;
					if ((uint)c4 <= 44u)
					{
						num49 = -64281526;
						num50 = -64281526;
					}
					else
					{
						num49 = -918203161;
						num50 = -918203161;
					}
					num = num49 ^ ((int)num2 * -392526046);
					continue;
				}
				case 146u:
					num = ((int)num2 * -1353807170) ^ -1243755262;
					continue;
				case 145u:
					flag4 = !flag4;
					num = -416939260;
					continue;
				case 144u:
					num = (int)((num2 * 2116875687) ^ 0x29CD3286);
					continue;
				case 143u:
					jSONNode.Add(text2);
					num = ((int)num2 * -1535119337) ^ 0x13488255;
					continue;
				case 142u:
				{
					int num46;
					int num47;
					if (flag11)
					{
						num46 = 1637667998;
						num47 = 1637667998;
					}
					else
					{
						num46 = 230224541;
						num47 = 230224541;
					}
					num = num46 ^ (int)(num2 * 23698063);
					continue;
				}
				case 141u:
					num5 += 4;
					num = (int)((num2 * 1140520143) ^ 0x729176DF);
					continue;
				case 140u:
				{
					int num36;
					int num37;
					if (!flag5)
					{
						num36 = 2102457167;
						num37 = 2102457167;
					}
					else
					{
						num36 = 1477864963;
						num37 = 1477864963;
					}
					num = num36 ^ ((int)num2 * -977025041);
					continue;
				}
				case 139u:
					num = ((int)num2 * -1496627710) ^ -745000406;
					continue;
				case 138u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 1818814893) ^ -423472957;
					continue;
				case 137u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 803337521) ^ -86308239;
					continue;
				case 136u:
					text2 = "";
					num = ((int)num2 * -8012632) ^ 0x4CAEF319;
					continue;
				case 135u:
					num = (int)((num2 * 23973661) ^ 0x268055A0);
					continue;
				case 134u:
					num = (int)((num2 * 800088015) ^ 0x50FB218C);
					continue;
				case 132u:
					text2 = "";
					num = (int)(num2 * 1715957961) ^ -178923145;
					continue;
				case 131u:
					num = ((int)num2 * -2092566141) ^ -892167422;
					continue;
				case 130u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 1760302786;
						num9 = 1760302786;
					}
					else
					{
						num8 = 1366009154;
						num9 = 1366009154;
					}
					num = num8 ^ (int)(num2 * 1876977620);
					continue;
				}
				case 129u:
				{
					int num60;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -1661807617;
						num60 = -1661807617;
					}
					else
					{
						num = -1648172070;
						num60 = -1648172070;
					}
					continue;
				}
				case 128u:
				{
					num5++;
					int num57;
					if (flag4)
					{
						num = -892142911;
						num57 = -892142911;
					}
					else
					{
						num = -696919978;
						num57 = -696919978;
					}
					continue;
				}
				case 127u:
					switch (c4)
					{
					case '\\':
						break;
					default:
						goto IL_02d9;
					case '[':
						goto IL_02e3;
					case ']':
						goto IL_02f1;
					}
					goto case 128u;
				case 7u:
					goto IL_02e3;
				case 50u:
					goto IL_02f1;
				case 126u:
					num = ((int)num2 * -765575227) ^ 0x6AD653A1;
					continue;
				case 125u:
					num = -504538531;
					continue;
				case 124u:
					stack.Pop();
					flag9 = JSONNode.smethod_6(text2, "");
					num = -447966482;
					continue;
				case 123u:
					flag6 = flag4;
					num = -2118082294;
					continue;
				case 122u:
				{
					int num43;
					int num44;
					if ((uint)c4 > 32u)
					{
						num43 = -327413603;
						num44 = -327413603;
					}
					else
					{
						num43 = -1333236884;
						num44 = -1333236884;
					}
					num = num43 ^ (int)(num2 * 1508848693);
					continue;
				}
				case 121u:
					num = (int)(num2 * 506139185) ^ -306710153;
					continue;
				case 120u:
				{
					int num41;
					if (c3 == 'f')
					{
						num = -169830658;
						num41 = -169830658;
					}
					else
					{
						num = -1024440354;
						num41 = -1024440354;
					}
					continue;
				}
				case 119u:
				{
					int num32;
					int num33;
					if (c4 != ':')
					{
						num32 = -538213393;
						num33 = -538213393;
					}
					else
					{
						num32 = -1714308142;
						num33 = -1714308142;
					}
					num = num32 ^ (int)(num2 * 246792077);
					continue;
				}
				case 118u:
					num = -1244982181;
					continue;
				case 117u:
				{
					int num27;
					int num28;
					if (!flag9)
					{
						num27 = 1763093620;
						num28 = 1763093620;
					}
					else
					{
						num27 = 1260992351;
						num28 = 1260992351;
					}
					num = num27 ^ ((int)num2 * -1502351147);
					continue;
				}
				case 116u:
					num = (int)((num2 * 1762594097) ^ 0x49ABE486);
					continue;
				case 115u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 1402722460) ^ 0xA24998F);
					continue;
				case 114u:
					num = (int)(num2 * 282634447) ^ -869208147;
					continue;
				case 113u:
				{
					int num21;
					int num22;
					if (!flag7)
					{
						num21 = 874544688;
						num22 = 874544688;
					}
					else
					{
						num21 = 1141896643;
						num22 = 1141896643;
					}
					num = num21 ^ ((int)num2 * -1987163335);
					continue;
				}
				case 112u:
					num = ((int)num2 * -1057207641) ^ 0x5F6DE284;
					continue;
				case 111u:
					text2 = "";
					num = ((int)num2 * -2054069184) ^ -980480209;
					continue;
				case 110u:
					flag = jSONNode != null;
					num = ((int)num2 * -1565564003) ^ -1783124782;
					continue;
				case 109u:
				{
					int num15;
					int num16;
					if (!flag3)
					{
						num15 = 1591615852;
						num16 = 1591615852;
					}
					else
					{
						num15 = 496235301;
						num16 = 496235301;
					}
					num = num15 ^ ((int)num2 * -147232996);
					continue;
				}
				case 108u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1982225344) ^ 0x6C2EB8B1);
					continue;
				case 107u:
					s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					num = (int)((num2 * 456171307) ^ 0x6CFA9D9E);
					continue;
				case 106u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 872181590) ^ 0x3499E762);
					continue;
				case 105u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 510334943) ^ -1319475426;
					continue;
				case 104u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -336074486;
					continue;
				case 103u:
					goto IL_057f;
				case 102u:
				{
					int num10;
					if (c4 != '"')
					{
						num = -54028813;
						num10 = -54028813;
					}
					else
					{
						num = -2046699734;
						num10 = -2046699734;
					}
					continue;
				}
				case 100u:
					text = "";
					num = -35967102;
					continue;
				case 24u:
				case 36u:
				case 84u:
				case 98u:
				case 99u:
					goto IL_05c8;
				case 97u:
					c = JSONNode.smethod_2(aJSON, num5);
					c2 = c;
					num = (int)((num2 * 554615419) ^ 0x63B47C45);
					continue;
				case 96u:
					result = jSONNode;
					num = -635093203;
					continue;
				case 95u:
					flag13 = jSONNode is JSONArray;
					num = (int)(num2 * 1695600494) ^ -2088240686;
					continue;
				case 94u:
				{
					int num58;
					int num59;
					if (flag13)
					{
						num58 = 955932192;
						num59 = 955932192;
					}
					else
					{
						num58 = 822926283;
						num59 = 822926283;
					}
					num = num58 ^ ((int)num2 * -1542358995);
					continue;
				}
				case 93u:
					num = (int)(num2 * 1712107908) ^ -520091846;
					continue;
				case 92u:
					num = (int)(num2 * 884507927) ^ -1819650683;
					continue;
				case 91u:
					num = (int)(num2 * 774120355) ^ -879658795;
					continue;
				case 90u:
					num = (int)(num2 * 232552112) ^ -483962646;
					continue;
				case 89u:
					text = "";
					flag4 = false;
					num = (int)(num2 * 1234062913) ^ -2061025569;
					continue;
				case 88u:
				{
					int num55;
					int num56;
					if (jSONNode is JSONArray)
					{
						num55 = -1868141867;
						num56 = -1868141867;
					}
					else
					{
						num55 = -865012597;
						num56 = -865012597;
					}
					num = num55 ^ (int)(num2 * 1283585528);
					continue;
				}
				case 87u:
					num = (int)(num2 * 1921665291) ^ -1090092729;
					continue;
				case 86u:
					num = ((int)num2 * -1592634161) ^ -1231239760;
					continue;
				case 85u:
				{
					int num53;
					int num54;
					if (c3 == 'b')
					{
						num53 = -1757196993;
						num54 = -1757196993;
					}
					else
					{
						num53 = -897721444;
						num54 = -897721444;
					}
					num = num53 ^ (int)(num2 * 1483480472);
					continue;
				}
				case 83u:
					num = ((int)num2 * -1935865344) ^ 0x1035BBF5;
					continue;
				case 82u:
				{
					int num51;
					int num52;
					if (jSONNode != null)
					{
						num51 = 1910999787;
						num52 = 1910999787;
					}
					else
					{
						num51 = 1178390277;
						num52 = 1178390277;
					}
					num = num51 ^ ((int)num2 * -291845653);
					continue;
				}
				case 81u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 2076875739) ^ -1676185817;
					continue;
				case 80u:
				{
					int num48;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -1589083978;
						num48 = -1589083978;
					}
					else
					{
						num = -1606611508;
						num48 = -1606611508;
					}
					continue;
				}
				case 79u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 1921766532) ^ 0x5E1607A);
					continue;
				case 78u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 327373693) ^ 0x5E65FA2C);
					continue;
				case 77u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -336074486;
					continue;
				case 76u:
				{
					int num45;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1057588786;
						num45 = -1057588786;
					}
					else
					{
						num = -1225526174;
						num45 = -1225526174;
					}
					continue;
				}
				case 75u:
					num = (int)(num2 * 339129550) ^ -217467532;
					continue;
				case 74u:
					goto IL_0859;
				case 73u:
					text = "";
					text2 = "";
					num = -1130189037;
					continue;
				case 72u:
				{
					int num42;
					if (flag4)
					{
						num = -1397461593;
						num42 = -1397461593;
					}
					else
					{
						num = -669063933;
						num42 = -669063933;
					}
					continue;
				}
				case 71u:
				{
					int num38;
					int num39;
					if (flag12)
					{
						num38 = 144138687;
						num39 = 144138687;
					}
					else
					{
						num38 = 940219153;
						num39 = 940219153;
					}
					num = num38 ^ ((int)num2 * -1935072578);
					continue;
				}
				case 70u:
					num = (int)(num2 * 1076884236) ^ -2052594905;
					continue;
				case 69u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 967480492) ^ 0x62B95F8F);
					continue;
				case 68u:
					num5 = 0;
					num = (int)(num2 * 862533531) ^ -1967714318;
					continue;
				case 67u:
					text = text2;
					num = -1729646099;
					continue;
				case 66u:
					num = ((int)num2 * -1413834704) ^ -1725700193;
					continue;
				case 65u:
				{
					int num34;
					int num35;
					if ((uint)c3 <= 102u)
					{
						num34 = -897794803;
						num35 = -897794803;
					}
					else
					{
						num34 = -1478823731;
						num35 = -1478823731;
					}
					num = num34 ^ (int)(num2 * 1790623276);
					continue;
				}
				case 64u:
					num = (int)((num2 * 1929742936) ^ 0x7A609737);
					continue;
				case 63u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -907118415;
					continue;
				case 62u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 485666280) ^ -638854019;
					continue;
				case 61u:
					num = (int)(num2 * 794631617) ^ -234798209;
					continue;
				case 60u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -759427443) ^ 0x6A4BA598;
					continue;
				case 59u:
					stack.Push(new JSONArray());
					num = -618231419;
					continue;
				case 58u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 830638571) ^ -1007967893;
					continue;
				case 57u:
					num = -1992506625;
					continue;
				case 56u:
					num = (int)(num2 * 1714895447) ^ -246842139;
					continue;
				case 54u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 764102078) ^ -1546696716;
					continue;
				case 53u:
					num = (int)(num2 * 340582992) ^ -506305473;
					continue;
				case 52u:
					num = (int)(num2 * 1660428304) ^ -628976935;
					continue;
				case 51u:
					flag11 = num5 < JSONNode.smethod_4(aJSON);
					num = -626043071;
					continue;
				case 49u:
				{
					int num30;
					int num31;
					if (flag10)
					{
						num30 = -540498614;
						num31 = -540498614;
					}
					else
					{
						num30 = -805252677;
						num31 = -805252677;
					}
					num = num30 ^ ((int)num2 * -1753366560);
					continue;
				}
				case 48u:
				{
					int num29;
					if (c3 == 'n')
					{
						num = -1497134528;
						num29 = -1497134528;
					}
					else
					{
						num = -1498324353;
						num29 = -1498324353;
					}
					continue;
				}
				case 47u:
					switch (c4)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_05c8;
					default:
						goto IL_0afa;
					case '\t':
						goto IL_0b0d;
					}
					goto case 150u;
				case 43u:
					goto IL_0b0d;
				case 46u:
					num = ((int)num2 * -1081027664) ^ 0x4E46C89E;
					continue;
				case 45u:
					flag7 = JSONNode.smethod_6(text, "");
					num = -1606428020;
					continue;
				case 44u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 1218054521) ^ 0x17DB71);
					continue;
				case 42u:
					num = (int)((num2 * 101511790) ^ 0x4980E16C);
					continue;
				case 41u:
				{
					int num25;
					int num26;
					if (!flag8)
					{
						num25 = -1038955418;
						num26 = -1038955418;
					}
					else
					{
						num25 = -721972406;
						num26 = -721972406;
					}
					num = num25 ^ (int)(num2 * 1231406261);
					continue;
				}
				case 40u:
					num = -1225526174;
					continue;
				case 39u:
					num = ((int)num2 * -1271576052) ^ -1169143536;
					continue;
				case 38u:
				{
					int num24;
					if (c4 == ' ')
					{
						num = -1986924932;
						num24 = -1986924932;
					}
					else
					{
						num = -1480931993;
						num24 = -1480931993;
					}
					continue;
				}
				case 37u:
					stack.Push(new JSONClass());
					num = -549097499;
					continue;
				case 35u:
					num = (int)(num2 * 189440188) ^ -1379460454;
					continue;
				case 34u:
				{
					int num23;
					if ((uint)c4 > 93u)
					{
						num = -846361325;
						num23 = -846361325;
					}
					else
					{
						num = -1243061796;
						num23 = -1243061796;
					}
					continue;
				}
				case 33u:
				{
					int num20;
					if (c4 == '}')
					{
						num = -183230101;
						num20 = -183230101;
					}
					else
					{
						num = -831957925;
						num20 = -831957925;
					}
					continue;
				}
				case 32u:
					goto IL_0c5d;
				case 30u:
				{
					int num18;
					int num19;
					if (stack.Count <= 0)
					{
						num18 = -1490151865;
						num19 = -1490151865;
					}
					else
					{
						num18 = -1260095892;
						num19 = -1260095892;
					}
					num = num18 ^ (int)(num2 * 172787897);
					continue;
				}
				case 29u:
					num = ((int)num2 * -951411631) ^ 0x51A51DE7;
					continue;
				case 28u:
					num = ((int)num2 * -551937064) ^ -1925861142;
					continue;
				case 27u:
				{
					int num17;
					if (c4 == ',')
					{
						num = -1827001692;
						num17 = -1827001692;
					}
					else
					{
						num = -1061635210;
						num17 = -1061635210;
					}
					continue;
				}
				case 26u:
				{
					int num14;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -852332769;
						num14 = -852332769;
					}
					else
					{
						num = -1538910590;
						num14 = -1538910590;
					}
					continue;
				}
				case 25u:
					stack = new Stack<JSONNode>();
					num = (int)((num2 * 809548417) ^ 0x312B0A7D);
					continue;
				case 23u:
					num = ((int)num2 * -245724679) ^ -1871415118;
					continue;
				case 22u:
					text2 = "";
					num = (int)((num2 * 544671821) ^ 0x1908BE23);
					continue;
				case 21u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 628717011) ^ -539899797;
					continue;
				case 20u:
					text = "";
					num = -865319666;
					continue;
				case 19u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -534645854) ^ -1995091973;
					continue;
				case 18u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = -829474783;
						num13 = -829474783;
					}
					else
					{
						num12 = -1489355271;
						num13 = -1489355271;
					}
					num = num12 ^ ((int)num2 * -300117477);
					continue;
				}
				case 17u:
					flag2 = flag4;
					num = ((int)num2 * -1538459556) ^ -349845250;
					continue;
				case 16u:
					flag5 = flag4;
					num = -665049042;
					continue;
				case 15u:
					jSONNode = null;
					num = (int)(num2 * 1652901697) ^ -449059565;
					continue;
				case 14u:
					text = JSONNode.smethod_5(text);
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -944439273) ^ -1122619126;
					continue;
				case 13u:
					switch (c3)
					{
					case 'u':
						break;
					case 'r':
						goto IL_057f;
					case 't':
						goto IL_0859;
					case 's':
						goto IL_0c5d;
					default:
						goto IL_0e4c;
					}
					goto case 151u;
				case 12u:
					num = ((int)num2 * -1738729962) ^ 0x49070788;
					continue;
				case 11u:
					num = (int)(num2 * 1134923789) ^ -2052399919;
					continue;
				case 10u:
				{
					int num11;
					if (c4 != '{')
					{
						num = -1364721739;
						num11 = -1364721739;
					}
					else
					{
						num = -849875314;
						num11 = -849875314;
					}
					continue;
				}
				case 9u:
					text = "";
					text2 = "";
					num = -1196445648;
					continue;
				case 8u:
					num = (int)(num2 * 893762809) ^ -383821176;
					continue;
				case 6u:
					num = -696919978;
					continue;
				case 5u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -675788734) ^ -1294075964;
					continue;
				case 4u:
					num = (int)((num2 * 173308147) ^ 0x258BCC6F);
					continue;
				case 3u:
				{
					int num6;
					int num7;
					if (!(jSONNode is JSONArray))
					{
						num6 = 2140028713;
						num7 = 2140028713;
					}
					else
					{
						num6 = 432838573;
						num7 = 432838573;
					}
					num = num6 ^ ((int)num2 * -768644615);
					continue;
				}
				case 2u:
					c3 = c2;
					num = (int)((num2 * 1807328022) ^ 0xAE1A242);
					continue;
				case 1u:
					num = (int)(num2 * 980051448) ^ -886288756;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 624800822;
						num4 = 624800822;
					}
					else
					{
						num3 = 696464364;
						num4 = 696464364;
					}
					num = num3 ^ (int)(num2 * 360478701);
					continue;
				}
				case 133u:
					break;
				case 55u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 101u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_05c8:
					num5++;
					num = -1983589912;
					continue;
					IL_057f:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -2092466558;
					continue;
					IL_0e4c:
					num = -2050593678;
					continue;
					IL_0c5d:
					text2 = JSONNode.smethod_3(text2, c.ToString());
					num = -1997974927;
					continue;
					IL_0b0d:
					flag8 = flag4;
					num = -2006776015;
					continue;
					IL_0afa:
					num = (int)(num2 * 1400815779) ^ -1274824420;
					continue;
					IL_0859:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -1878362327;
					continue;
					IL_02f1:
					flag10 = flag4;
					num = -137371458;
					continue;
					IL_02e3:
					flag12 = flag4;
					num = -1084949183;
					continue;
					IL_02d9:
					num = -2056683936;
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
			int num = -952000804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB13BA93Du) % 4u)
				{
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = (int)((num2 * 119239668) ^ 0xBF8DBFD);
					continue;
				case 0u:
					Serialize(aWriter);
					num = (int)((num2 * 102907228) ^ 0x5F36FD53);
					continue;
				default:
					return;
				case 3u:
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
			SaveToStream(fileStream);
			while (true)
			{
				int num = 47376387;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x55FB8E1Du) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1249873897) ^ -1122979314;
						continue;
					case 1u:
						num = (int)(num2 * 785553614) ^ -499629768;
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_00b4:
					int num3 = 504926891;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x55FB8E1Du) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 146034374) ^ -1666823332;
							continue;
						case 1u:
							num3 = (int)((num2 * 462329330) ^ 0x614418AB);
							continue;
						default:
							goto end_IL_0093;
						case 3u:
							break;
						case 0u:
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
			SaveToStream(memoryStream);
			while (true)
			{
				int num = 265034654;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22918D70u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1674114170) ^ -1621626029;
						continue;
					case 2u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1233918180) ^ 0x1E2D3B6B;
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
					IL_00b8:
					int num3 = 116391378;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x22918D70u) % 4u)
						{
						case 3u:
							num3 = ((int)num2 * -341152999) ^ -1312103334;
							continue;
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -642144761) ^ -1912787275;
							continue;
						default:
							goto end_IL_0097;
						case 0u:
							break;
						case 1u:
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
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num5 = default(int);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		int num8 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		JSONArray jSONArray = default(JSONArray);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2017118118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA73D07BFu) % 38u)
				{
				case 37u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					switch (jSONBinaryTag)
					{
					case JSONBinaryTag.Array:
						goto IL_0048;
					case JSONBinaryTag.Class:
						goto IL_0060;
					case JSONBinaryTag.Value:
						goto IL_006a;
					case JSONBinaryTag.IntValue:
						goto IL_0081;
					case JSONBinaryTag.DoubleValue:
						goto IL_008b;
					case JSONBinaryTag.BoolValue:
						goto IL_00a2;
					case JSONBinaryTag.FloatValue:
						goto IL_00b9;
					}
					num = ((int)num2 * -1649807441) ^ 0x77508A80;
					continue;
				case 35u:
					goto IL_0048;
				case 24u:
					goto IL_0060;
				case 12u:
					goto IL_006a;
				case 22u:
					goto IL_0081;
				case 8u:
					goto IL_008b;
				case 25u:
					goto IL_00a2;
				case 1u:
					goto IL_00b9;
				case 36u:
					num5++;
					num = (int)(num2 * 308308880) ^ -1777823862;
					continue;
				case 34u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -196129414) ^ 0x71A1E930;
					continue;
				case 33u:
				{
					int num9;
					if (num5 >= num8)
					{
						num = -1833477163;
						num9 = -1833477163;
					}
					else
					{
						num = -1088913088;
						num9 = -1088913088;
					}
					continue;
				}
				case 32u:
					num = ((int)num2 * -2092244429) ^ 0x74335DE2;
					continue;
				case 31u:
					num = (int)((num2 * 1022034942) ^ 0x7B578EF0);
					continue;
				case 28u:
					num4 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = (int)(num2 * 754579111) ^ -198729254;
					continue;
				case 27u:
					num = ((int)num2 * -358611461) ^ 0x2D0EF0AB;
					continue;
				case 26u:
					num = (int)((num2 * 2064389207) ^ 0x57AFCBF3);
					continue;
				case 23u:
					num3 = 0;
					num = (int)(num2 * 842261642) ^ -120603991;
					continue;
				case 21u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -452402474) ^ -953693449;
					continue;
				case 20u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = 422746176;
						num7 = 422746176;
					}
					else
					{
						num6 = 682611812;
						num7 = 682611812;
					}
					num = num6 ^ ((int)num2 * -1982996805);
					continue;
				}
				case 19u:
					num = (int)((num2 * 2119926888) ^ 0x7C195473);
					continue;
				case 18u:
					num = (int)(num2 * 1667647730) ^ -157402402;
					continue;
				case 17u:
					num = -1257345631;
					continue;
				case 16u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)(num2 * 2136033017) ^ -2007249906;
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -1046515398) ^ 0x7EED1913;
					continue;
				case 13u:
					num = ((int)num2 * -1368616807) ^ -1791023811;
					continue;
				case 11u:
					num = ((int)num2 * -1248899240) ^ -1292788291;
					continue;
				case 10u:
					num5 = 0;
					num = ((int)num2 * -1738528747) ^ -915305154;
					continue;
				case 9u:
					jSONArray.Add(Deserialize(aReader));
					num = -542635850;
					continue;
				case 7u:
					result = jSONClass;
					num = (int)(num2 * 1601910881) ^ -950747515;
					continue;
				case 6u:
					num = ((int)num2 * -828208010) ^ -1650276318;
					continue;
				case 5u:
					num = -1592117118;
					continue;
				case 4u:
					num = (int)(num2 * 491505510) ^ -1495339542;
					continue;
				case 3u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 160237988) ^ 0x5B6229AE);
					continue;
				case 2u:
					flag = num3 < num4;
					num = -324051433;
					continue;
				case 0u:
					result = jSONArray;
					num = (int)((num2 * 733896710) ^ 0x5CD8B674);
					continue;
				case 30u:
					break;
				case 29u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0081:
					num = -734272700;
					continue;
					IL_006a:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1139218721;
					continue;
					IL_008b:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -96860920;
					continue;
					IL_0060:
					num = -669019213;
					continue;
					IL_0048:
					num8 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = -864323403;
					continue;
					IL_00b9:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -175723201;
					continue;
					IL_00a2:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -768171919;
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
					int num = -1891789453;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xDBD32925u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -1666228599) ^ -1442374542;
							continue;
						case 1u:
							num = ((int)num2 * -1731689616) ^ -1594314490;
							continue;
						default:
							goto end_IL_0037;
						case 0u:
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
					int num = 2022819805;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x4CD0BF76u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -504641689) ^ -1373967146;
							continue;
						case 1u:
							num = (int)(num2 * 666341026) ^ -929948294;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = JSONNode.smethod_29(byte_);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1127701347;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7474389u) % 5u)
				{
				case 4u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -2629329) ^ -1596731813;
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1008263677) ^ -1861594006;
					continue;
				case 1u:
					num = ((int)num2 * -616479864) ^ -2022462745;
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
			int num = 736054255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7509545Fu) % 3u)
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
				num = (int)(num2 * 239179725) ^ -176496938;
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
