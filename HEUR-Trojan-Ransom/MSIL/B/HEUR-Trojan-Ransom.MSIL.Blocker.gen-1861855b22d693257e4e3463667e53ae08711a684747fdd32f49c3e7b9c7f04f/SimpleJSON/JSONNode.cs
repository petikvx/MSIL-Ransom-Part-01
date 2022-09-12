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
				int num = -483090530;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9E00B5B7u) % 3u)
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
					num = ((int)num2 * -1481208965) ^ -404139256;
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
				int num = 8320297;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x62F3C9ECu) % 3u)
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
					num = (int)((num2 * 945837617) ^ 0x4C237B54);
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
				int num = 658268859;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x10804F37u) % 3u)
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
					num = ((int)num2 * -2125964449) ^ -1317800752;
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
				int num = 1165029747;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30AB972u) % 4u)
					{
					case 1u:
						result = 0;
						num = ((int)num2 * -1387243967) ^ 0x1F90C10F;
						continue;
					case 0u:
						num = (int)((num2 * 1589581609) ^ 0x3E3D9455);
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
				int num = -1335099291;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82B2255Fu) % 4u)
					{
					case 3u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -264467261) ^ 0x5B5CAE47;
						continue;
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = ((int)num2 * -592690301) ^ -160817850;
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
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1115606379;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFBCF6041u) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_DeepChilds_003Ed__;
					num = (int)(num2 * 389644207) ^ -1505092455;
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
				int num = 532563155;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A20855Du) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1708406503;
							num4 = 1708406503;
						}
						else
						{
							num3 = 1120194696;
							num4 = 1120194696;
						}
						num = num3 ^ ((int)num2 * -414222442);
						continue;
					}
					case 4u:
						num = ((int)num2 * -1746489234) ^ -1458631415;
						continue;
					case 3u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 1431714683) ^ 0x4E4F73C0);
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1714020847) ^ 0x20BD1012;
						continue;
					case 0u:
						result = 0;
						num = 1123377833;
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

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			float result2 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = -1562079807;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA6F8001Eu) % 6u)
					{
					case 5u:
						result2 = 0f;
						num = -2060027300;
						continue;
					case 3u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
						num = (int)(num2 * 607608318) ^ -192948026;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1827038277;
							num4 = 1827038277;
						}
						else
						{
							num3 = 460987445;
							num4 = 460987445;
						}
						num = num3 ^ (int)(num2 * 140678896);
						continue;
					}
					case 1u:
						result2 = result;
						num = (int)(num2 * 351664918) ^ -517253842;
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
			Value = value.ToString();
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result = default(double);
			bool flag = default(bool);
			double result2 = default(double);
			while (true)
			{
				int num = -1951818907;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83BFB756u) % 8u)
					{
					case 6u:
						num = ((int)num2 * -287632815) ^ 0x5202F6CA;
						continue;
					case 5u:
						result = 0.0;
						num = -1072709424;
						continue;
					case 4u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -896075625) ^ -1798428509;
						continue;
					case 3u:
						result2 = 0.0;
						num = ((int)num2 * -1043218868) ^ -1514080058;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -412824728;
							num4 = -412824728;
						}
						else
						{
							num3 = -1458724275;
							num4 = -1458724275;
						}
						num = num3 ^ (int)(num2 * 1887588734);
						continue;
					}
					case 0u:
						result = result2;
						num = (int)(num2 * 932013168) ^ -1687072084;
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
				int num = -1868810559;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x97EFB1B6u) % 3u)
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
					num = (int)(num2 * 1664806374) ^ -418542588;
				}
			}
		}
	}

	public virtual bool AsBool
	{
		get
		{
			bool result = false;
			bool result2 = default(bool);
			while (true)
			{
				int num = 731220125;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A6CC01Cu) % 6u)
					{
					case 4u:
						result2 = result;
						num = (int)((num2 * 835354103) ^ 0x33F46E10);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (bool.TryParse(Value, out result))
						{
							num3 = 1723099285;
							num4 = 1723099285;
						}
						else
						{
							num3 = 1182544851;
							num4 = 1182544851;
						}
						num = num3 ^ ((int)num2 * -789995811);
						continue;
					}
					case 2u:
						result2 = !JSONNode.smethod_1(Value);
						num = 80343289;
						continue;
					case 1u:
						num = (int)((num2 * 407730458) ^ 0x407C91DE);
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
				int num = -1469265202;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ -633408640) % 3u)
					{
					case 1u:
						value2 = (value ? "true" : "false");
						goto IL_0013;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0013:
					Value = value2;
					num = -1079958920;
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
				int num = -213769583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9DF0CDCCu) % 4u)
					{
					case 2u:
						num = ((int)num2 * -64145187) ^ 0x1758A2D9;
						continue;
					case 1u:
						result = this as JSONArray;
						num = (int)(num2 * 1646252571) ^ -2045539707;
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
				int num = 1948128080;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F32A04Du) % 4u)
					{
					case 1u:
						result = this as JSONClass;
						num = (int)(num2 * 1270616974) ^ -480204209;
						continue;
					case 0u:
						num = (int)(num2 * 1917420356) ^ -1053672593;
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
		while (true)
		{
			int num = 712205197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x747D09F8u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -477415875) ^ 0x47A29636;
					continue;
				case 1u:
					Add("", aItem);
					num = ((int)num2 * -600834681) ^ -1035034747;
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

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 373228864;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33DABB9Fu) % 3u)
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
				num = (int)(num2 * 1404934274) ^ -1435242991;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1900768430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9253C8F8u) % 4u)
				{
				case 2u:
					result = null;
					num = ((int)num2 * -1473624212) ^ 0x7F65A6C1;
					continue;
				case 1u:
					num = (int)(num2 * 1704658312) ^ -1280855669;
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
			int num = 1218300938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14D6C778u) % 4u)
				{
				case 2u:
					result = aNode;
					num = ((int)num2 * -235572844) ^ -1433981183;
					continue;
				case 1u:
					num = (int)((num2 * 1254235623) ^ 0x747A87B0);
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
			int num = 951965403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15FE6580u) % 3u)
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
				num = (int)(num2 * 1107245516) ^ -1400125559;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 177710900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C1F246Bu) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = ((int)num2 * -1001569213) ^ 0x5117CFFA;
					continue;
				case 0u:
					num = ((int)num2 * -1411146994) ^ 0x5048428E;
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
			int num = -627306350;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1C7CDCCu) % 3u)
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
				num = (int)(num2 * 2074095692) ^ -1252785134;
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
		IL_0041:
		obj = d.Value;
		goto IL_0047;
		IL_001b:
		int num = -1315726688;
		goto IL_0020;
		IL_0020:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF848F61Eu) % 4u)
			{
			case 3u:
				num = ((int)num2 * -1757158213) ^ 0x50A8A552;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0041;
			default:
				return result;
			}
			break;
		}
		goto IL_001b;
		IL_0047:
		result = (string)obj;
		num = -1743038111;
		goto IL_0020;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1314259061;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0xA8DC91EEu) % 8u)
				{
				case 7u:
					num = (int)((num2 * 1457090183) ^ 0x7DC2BA81);
					continue;
				case 5u:
					if (b == null)
					{
						num = (int)(num2 * 94660265) ^ -735131817;
						continue;
					}
					num5 = 0;
					goto IL_0028;
				case 4u:
					num5 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0028;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -421721486;
						num4 = -421721486;
					}
					else
					{
						num3 = -1829175485;
						num4 = -1829175485;
					}
					num = num3 ^ ((int)num2 * -1643049842);
					continue;
				}
				case 1u:
					result = (object)a == b;
					num = -719391912;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 1866302438) ^ 0x2EF24F11);
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0028:
					flag = (byte)num5 != 0;
					num = -1643785756;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1304940175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2718956u) % 4u)
				{
				case 3u:
					result = !(a == b);
					num = ((int)num2 * -1194609165) ^ 0x4123F0E5;
					continue;
				case 2u:
					num = (int)(num2 * 2111615283) ^ -117078143;
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
			int num = 536523380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78BEE291u) % 4u)
				{
				case 1u:
					result = (object)this == obj;
					num = ((int)num2 * -1233851086) ^ -283902697;
					continue;
				case 0u:
					num = (int)((num2 * 1049938824) ^ 0x669E09B);
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
		int num3 = default(int);
		string result = default(string);
		string string_ = default(string);
		char c2 = default(char);
		while (true)
		{
			int num = 1039945511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BF39A52u) % 29u)
				{
				case 28u:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 1875857015;
					continue;
				case 27u:
					num3++;
					num = 248206435;
					continue;
				case 26u:
					num = (int)((num2 * 1055514268) ^ 0x73F6DC2A);
					continue;
				case 25u:
					num = ((int)num2 * -1531631322) ^ 0x5018368A;
					continue;
				case 24u:
					result = text;
					num = ((int)num2 * -542929698) ^ 0x4D5B2FAF;
					continue;
				case 23u:
					c = JSONNode.smethod_2(string_, num3);
					num = 1404983040;
					continue;
				case 22u:
					goto IL_007a;
				case 21u:
					goto IL_0090;
				case 19u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 619115821;
					continue;
				case 18u:
					num = (int)((num2 * 999842940) ^ 0x79B43A91);
					continue;
				case 17u:
					text = "";
					num = ((int)num2 * -658389938) ^ -1085398608;
					continue;
				case 16u:
				{
					int num6;
					if (c2 == '"')
					{
						num = 212054688;
						num6 = 212054688;
					}
					else
					{
						num = 1882692232;
						num6 = 1882692232;
					}
					continue;
				}
				case 15u:
					num = (int)((num2 * 507328696) ^ 0x2FA84B98);
					continue;
				case 13u:
					num = ((int)num2 * -910349455) ^ -309635186;
					continue;
				case 12u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 619115821;
					continue;
				case 11u:
				{
					char c3 = c;
					c2 = c3;
					num = (int)(num2 * 2093414185) ^ -2023342231;
					continue;
				}
				case 10u:
					goto IL_0160;
				case 9u:
					num = (int)(num2 * 688040814) ^ -1916326965;
					continue;
				case 8u:
					goto IL_0189;
				case 7u:
					num = (int)((num2 * 457010191) ^ 0xD4E0012);
					continue;
				case 6u:
					goto IL_01b2;
				case 5u:
					switch (c2)
					{
					case '\v':
						break;
					case '\b':
						goto IL_007a;
					case '\f':
						goto IL_0090;
					case '\n':
						goto IL_0160;
					case '\t':
						goto IL_0189;
					case '\r':
						goto IL_01b2;
					default:
						goto IL_01e9;
					}
					goto case 28u;
				case 4u:
					num = (int)((num2 * 2121709187) ^ 0x681F6EE1);
					continue;
				case 3u:
				{
					int num5;
					if (c2 == '\\')
					{
						num = 1861074599;
						num5 = 1861074599;
					}
					else
					{
						num = 1500058639;
						num5 = 1500058639;
					}
					continue;
				}
				case 2u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 694095137;
						num4 = 694095137;
					}
					else
					{
						num = 524067526;
						num4 = 524067526;
					}
					continue;
				}
				case 1u:
					string_ = aText;
					num = ((int)num2 * -1828253143) ^ -647984899;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 1191459786) ^ 0x178665F1);
					continue;
				case 20u:
					break;
				default:
					{
						return result;
					}
					IL_01e9:
					num = (int)((num2 * 1762090580) ^ 0x8203F52);
					continue;
					IL_01b2:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1245438307;
					continue;
					IL_0189:
					text = JSONNode.smethod_3(text, "\\t");
					num = 619115821;
					continue;
					IL_0160:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1542145793;
					continue;
					IL_0090:
					text = JSONNode.smethod_3(text, "\\f");
					num = 619115821;
					continue;
					IL_007a:
					text = JSONNode.smethod_3(text, "\\b");
					num = 495249795;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		char c = default(char);
		string s = default(string);
		int num3 = default(int);
		bool flag = default(bool);
		char c4 = default(char);
		char c3 = default(char);
		bool flag20 = default(bool);
		bool flag5 = default(bool);
		string text2 = default(string);
		bool flag7 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		string text = default(string);
		bool flag12 = default(bool);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag14 = default(bool);
		bool flag15 = default(bool);
		char c2 = default(char);
		bool flag10 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag4 = default(bool);
		bool flag18 = default(bool);
		bool flag2 = default(bool);
		bool flag19 = default(bool);
		bool flag17 = default(bool);
		bool flag16 = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag8 = default(bool);
		bool flag11 = default(bool);
		while (true)
		{
			int num = 1645739553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49BC31A7u) % 163u)
				{
				case 162u:
					num = (int)(num2 * 1498059154) ^ -545784144;
					continue;
				case 161u:
					num = 1966576220;
					continue;
				case 160u:
				{
					int num58;
					int num59;
					if ((uint)c <= 32u)
					{
						num58 = -1569491569;
						num59 = -1569491569;
					}
					else
					{
						num58 = -961273343;
						num59 = -961273343;
					}
					num = num58 ^ ((int)num2 * -438899997);
					continue;
				}
				case 159u:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = 892052887;
					continue;
				case 158u:
					flag = !flag;
					num = 1127252750;
					continue;
				case 157u:
					num = 1873601640;
					continue;
				case 156u:
					num = (int)(num2 * 1804540354) ^ -100196408;
					continue;
				case 155u:
					c4 = c3;
					num = (int)(num2 * 531125678) ^ -1081913914;
					continue;
				case 154u:
					flag20 = flag;
					num = 1100925786;
					continue;
				case 153u:
					flag5 = JSONNode.smethod_6(text2, "");
					num = 1599260875;
					continue;
				case 152u:
					flag7 = flag;
					num = 1087900217;
					continue;
				case 151u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1214216238) ^ 0x44362166;
					continue;
				case 150u:
				{
					int num51;
					int num52;
					if (!flag20)
					{
						num51 = 525294429;
						num52 = 525294429;
					}
					else
					{
						num51 = 1338810330;
						num52 = 1338810330;
					}
					num = num51 ^ ((int)num2 * -268660004);
					continue;
				}
				case 149u:
					num = ((int)num2 * -792435622) ^ 0xCB88F31;
					continue;
				case 148u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 2073510739;
					continue;
				case 147u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 1028456440) ^ 0x6BF26E89);
					continue;
				case 146u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -83730424) ^ 0x702E3323;
					continue;
				case 145u:
					goto IL_0193;
				case 144u:
					text = "";
					text2 = "";
					num = 1038688734;
					continue;
				case 143u:
				{
					int num23;
					if (c == ',')
					{
						num = 1600137439;
						num23 = 1600137439;
					}
					else
					{
						num = 1254971091;
						num23 = 1254971091;
					}
					continue;
				}
				case 142u:
					text = "";
					num = ((int)num2 * -1099389619) ^ 0x7D7D4939;
					continue;
				case 141u:
					flag12 = jSONNode != null;
					num = (int)((num2 * 844892426) ^ 0x5EC6678E);
					continue;
				case 140u:
					goto IL_0210;
				case 139u:
				{
					int num8;
					int num9;
					if (!flag5)
					{
						num8 = 1150444220;
						num9 = 1150444220;
					}
					else
					{
						num8 = 1140723083;
						num9 = 1140723083;
					}
					num = num8 ^ ((int)num2 * -1951122129);
					continue;
				}
				case 138u:
				{
					int num62;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 968570697;
						num62 = 968570697;
					}
					else
					{
						num = 1960515875;
						num62 = 1960515875;
					}
					continue;
				}
				case 137u:
				{
					int num55;
					int num56;
					if (!flag13)
					{
						num55 = 358060062;
						num56 = 358060062;
					}
					else
					{
						num55 = 1089800600;
						num56 = 1089800600;
					}
					num = num55 ^ (int)(num2 * 912340814);
					continue;
				}
				case 136u:
					num = (int)(num2 * 239835488) ^ -15320802;
					continue;
				case 135u:
					text = text2;
					num = 1767677695;
					continue;
				case 134u:
				{
					int num47;
					int num48;
					if (flag9)
					{
						num47 = -2044417960;
						num48 = -2044417960;
					}
					else
					{
						num47 = -1031816321;
						num48 = -1031816321;
					}
					num = num47 ^ ((int)num2 * -1943627187);
					continue;
				}
				case 133u:
					jSONNode.Add(text2);
					num = ((int)num2 * -888278977) ^ -767181248;
					continue;
				case 132u:
					num = (int)(num2 * 1957923791) ^ -2002494502;
					continue;
				case 131u:
					num = (int)(num2 * 542651612) ^ -1737024407;
					continue;
				case 130u:
					num = ((int)num2 * -18391912) ^ -641679029;
					continue;
				case 129u:
				{
					int num40;
					int num41;
					if (flag14)
					{
						num40 = 1284178325;
						num41 = 1284178325;
					}
					else
					{
						num40 = 1994949147;
						num41 = 1994949147;
					}
					num = num40 ^ ((int)num2 * -1327256887);
					continue;
				}
				case 128u:
					num = (int)((num2 * 1685601243) ^ 0x7277A3E1);
					continue;
				case 127u:
				{
					int num37;
					if (c == '}')
					{
						num = 380455742;
						num37 = 380455742;
					}
					else
					{
						num = 515187302;
						num37 = 515187302;
					}
					continue;
				}
				case 126u:
					num = ((int)num2 * -1251054514) ^ -328349828;
					continue;
				case 125u:
					num = (int)((num2 * 256989166) ^ 0x711F22FD);
					continue;
				case 124u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 407269481;
					continue;
				case 123u:
					jSONNode = null;
					num = (int)((num2 * 1953845388) ^ 0xDAC58AA);
					continue;
				case 122u:
					num = (int)((num2 * 2110853871) ^ 0x779D898C);
					continue;
				case 121u:
					flag = false;
					num = (int)(num2 * 1558447454) ^ -306706093;
					continue;
				case 120u:
					text = "";
					text2 = "";
					num = 1590912278;
					continue;
				case 119u:
					num = ((int)num2 * -195838334) ^ 0x81E54CA;
					continue;
				case 118u:
					num = (int)(num2 * 1844860273) ^ -1663057379;
					continue;
				case 117u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 1791489510) ^ 0x3CF8B383);
					continue;
				case 116u:
					num = ((int)num2 * -946170615) ^ -1570209430;
					continue;
				case 115u:
					text2 = "";
					num = ((int)num2 * -132926873) ^ -936432660;
					continue;
				case 114u:
				{
					int num25;
					int num26;
					if (flag15)
					{
						num25 = -1039148663;
						num26 = -1039148663;
					}
					else
					{
						num25 = -2055938322;
						num26 = -2055938322;
					}
					num = num25 ^ ((int)num2 * -2101181455);
					continue;
				}
				case 113u:
				{
					int num19;
					int num20;
					if (c2 != 'b')
					{
						num19 = 912368270;
						num20 = 912368270;
					}
					else
					{
						num19 = 940618637;
						num20 = 940618637;
					}
					num = num19 ^ (int)(num2 * 1610079273);
					continue;
				}
				case 112u:
					num = ((int)num2 * -1761889617) ^ 0x9FDABE0;
					continue;
				case 111u:
					num = 1725332409;
					continue;
				case 110u:
					stack.Pop();
					flag10 = JSONNode.smethod_6(text2, "");
					num = 914877052;
					continue;
				case 109u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1308322109) ^ 0x44D06127;
					continue;
				case 108u:
					goto IL_0560;
				case 107u:
					num = (int)((num2 * 1169131642) ^ 0x243CE39);
					continue;
				case 106u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 482194956) ^ -2057350196;
					continue;
				case 105u:
					result = jSONNode;
					num = 1343171624;
					continue;
				case 104u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 56677079) ^ 0x3CBDF31B);
					continue;
				case 103u:
					num = (int)((num2 * 611938902) ^ 0x4277BCA);
					continue;
				case 102u:
				{
					int num6;
					int num7;
					if (flag4)
					{
						num6 = 2070765760;
						num7 = 2070765760;
					}
					else
					{
						num6 = 1133071209;
						num7 = 1133071209;
					}
					num = num6 ^ (int)(num2 * 61221406);
					continue;
				}
				case 101u:
				{
					int num63;
					if (c == '{')
					{
						num = 1358501111;
						num63 = 1358501111;
					}
					else
					{
						num = 1087581978;
						num63 = 1087581978;
					}
					continue;
				}
				case 100u:
					goto IL_0634;
				case 99u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = 602135472;
					continue;
				case 6u:
				case 11u:
				case 48u:
				case 75u:
				case 98u:
					goto IL_0663;
				case 97u:
					num = (int)(num2 * 253261272) ^ -738196582;
					continue;
				case 96u:
					text = "";
					num = 1415872196;
					continue;
				case 95u:
				{
					int num60;
					int num61;
					if (!flag18)
					{
						num60 = 34367814;
						num61 = 34367814;
					}
					else
					{
						num60 = 638156098;
						num61 = 638156098;
					}
					num = num60 ^ ((int)num2 * -1048217399);
					continue;
				}
				case 93u:
				{
					int num57;
					if (c2 == 'n')
					{
						num = 56060208;
						num57 = 56060208;
					}
					else
					{
						num = 1628864297;
						num57 = 1628864297;
					}
					continue;
				}
				case 92u:
					num = ((int)num2 * -2131318931) ^ -664287829;
					continue;
				case 91u:
					stack.Push(new JSONClass());
					num = 1473707979;
					continue;
				case 90u:
				{
					int num53;
					int num54;
					if (flag2)
					{
						num53 = 1315939220;
						num54 = 1315939220;
					}
					else
					{
						num53 = 83462135;
						num54 = 83462135;
					}
					num = num53 ^ ((int)num2 * -793921568);
					continue;
				}
				case 89u:
					num = ((int)num2 * -445601) ^ -1466898791;
					continue;
				case 88u:
					num3 = 0;
					num = ((int)num2 * -1968604305) ^ 0x5C95A62D;
					continue;
				case 87u:
					num = ((int)num2 * -1200007510) ^ -1792814193;
					continue;
				case 86u:
					num = (int)(num2 * 1406268087) ^ -905292442;
					continue;
				case 85u:
					num = 239786936;
					continue;
				case 84u:
				{
					int num49;
					int num50;
					if (!flag10)
					{
						num49 = -1116712034;
						num50 = -1116712034;
					}
					else
					{
						num49 = -546169145;
						num50 = -546169145;
					}
					num = num49 ^ ((int)num2 * -2008342042);
					continue;
				}
				case 83u:
					text = JSONNode.smethod_5(text);
					num = (int)((num2 * 1834888628) ^ 0x4B340E6C);
					continue;
				case 82u:
					num = (int)((num2 * 1778210838) ^ 0x7D47AD3A);
					continue;
				case 81u:
				{
					int num46;
					if ((uint)c <= 93u)
					{
						num = 1303562469;
						num46 = 1303562469;
					}
					else
					{
						num = 1428173560;
						num46 = 1428173560;
					}
					continue;
				}
				case 80u:
				{
					int num44;
					int num45;
					if (flag19)
					{
						num44 = 31844973;
						num45 = 31844973;
					}
					else
					{
						num44 = 1031457813;
						num45 = 1031457813;
					}
					num = num44 ^ (int)(num2 * 99540788);
					continue;
				}
				case 79u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 1264105519) ^ -872283276;
					continue;
				case 78u:
				{
					int num42;
					int num43;
					if (!flag17)
					{
						num42 = -514538845;
						num43 = -514538845;
					}
					else
					{
						num42 = -547923835;
						num43 = -547923835;
					}
					num = num42 ^ (int)(num2 * 1209938580);
					continue;
				}
				case 77u:
				{
					int num39;
					if (!flag)
					{
						num = 1737773352;
						num39 = 1737773352;
					}
					else
					{
						num = 820579449;
						num39 = 820579449;
					}
					continue;
				}
				case 76u:
					num = ((int)num2 * -1541213209) ^ -1380415556;
					continue;
				case 74u:
					num = ((int)num2 * -464186168) ^ 0x34602CFE;
					continue;
				case 73u:
				{
					int num38;
					if (c == '"')
					{
						num = 459738606;
						num38 = 459738606;
					}
					else
					{
						num = 47836241;
						num38 = 47836241;
					}
					continue;
				}
				case 72u:
					jSONNode.Add(text2);
					num = ((int)num2 * -2113031003) ^ -903782005;
					continue;
				case 71u:
					num = (int)(num2 * 1245279805) ^ -1237471118;
					continue;
				case 70u:
					num = (int)((num2 * 1363698649) ^ 0x2468B302);
					continue;
				case 69u:
					num = (int)((num2 * 1497336255) ^ 0x5284937D);
					continue;
				case 68u:
				{
					int num36;
					if (c == ' ')
					{
						num = 943954147;
						num36 = 943954147;
					}
					else
					{
						num = 1710099019;
						num36 = 1710099019;
					}
					continue;
				}
				case 67u:
					c3 = JSONNode.smethod_2(aJSON, num3);
					num = ((int)num2 * -191583734) ^ 0x268FC677;
					continue;
				case 66u:
					switch (c)
					{
					case '[':
						break;
					case '\\':
						goto IL_0193;
					case ']':
						goto IL_0634;
					default:
						goto IL_0999;
					}
					goto case 154u;
				case 65u:
					text = "";
					text2 = "";
					flag16 = stack.Count > 0;
					num = 569358701;
					continue;
				case 64u:
					text2 = "";
					num = (int)(num2 * 427209998) ^ -113573338;
					continue;
				case 63u:
					flag4 = jSONNode is JSONArray;
					num = (int)(num2 * 1354940926) ^ -1197655858;
					continue;
				case 62u:
					num = (int)(num2 * 1329151817) ^ -1902518903;
					continue;
				case 61u:
					flag18 = JSONNode.smethod_6(text, "");
					num = 2087528226;
					continue;
				case 60u:
					flag17 = JSONNode.smethod_6(text, "");
					num = 1569459640;
					continue;
				case 59u:
					c2 = c4;
					num = ((int)num2 * -481343013) ^ 0x6C9465E8;
					continue;
				case 58u:
				{
					int num34;
					int num35;
					if (flag12)
					{
						num34 = 1484453193;
						num35 = 1484453193;
					}
					else
					{
						num34 = 1624237084;
						num35 = 1624237084;
					}
					num = num34 ^ ((int)num2 * -1740210443);
					continue;
				}
				case 57u:
					num = (int)(num2 * 1992437153) ^ -116305549;
					continue;
				case 56u:
					num = ((int)num2 * -796818501) ^ -424447010;
					continue;
				case 55u:
					switch (c2)
					{
					case 'u':
						break;
					case 's':
						goto IL_0210;
					case 'r':
						goto IL_0560;
					default:
						goto IL_0abf;
					case 't':
						goto IL_0ac9;
					}
					goto case 159u;
				case 27u:
					goto IL_0ac9;
				case 54u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 789769681) ^ 0x41BB3596);
					continue;
				case 53u:
				{
					int num32;
					int num33;
					if (flag3)
					{
						num32 = -337998549;
						num33 = -337998549;
					}
					else
					{
						num32 = -689694417;
						num33 = -689694417;
					}
					num = num32 ^ ((int)num2 * -1392909445);
					continue;
				}
				case 52u:
				{
					int num30;
					int num31;
					if (!flag6)
					{
						num30 = -696686045;
						num31 = -696686045;
					}
					else
					{
						num30 = -2136084503;
						num31 = -2136084503;
					}
					num = num30 ^ (int)(num2 * 2053168109);
					continue;
				}
				case 51u:
					flag15 = flag;
					num = (int)((num2 * 912681158) ^ 0x1D4AA43C);
					continue;
				case 49u:
				{
					int num28;
					int num29;
					if (flag16)
					{
						num28 = 1159651600;
						num29 = 1159651600;
					}
					else
					{
						num28 = 1065137797;
						num29 = 1065137797;
					}
					num = num28 ^ (int)(num2 * 1235423782);
					continue;
				}
				case 46u:
				{
					int num27;
					if (num3 < JSONNode.smethod_4(aJSON))
					{
						num = 933460292;
						num27 = 933460292;
					}
					else
					{
						num = 593094532;
						num27 = 593094532;
					}
					continue;
				}
				case 45u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 780470158;
					continue;
				case 44u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num3);
					c = c5;
					int num24;
					if ((uint)c <= 44u)
					{
						num = 1954233654;
						num24 = 1954233654;
					}
					else
					{
						num = 1053418040;
						num24 = 1053418040;
					}
					continue;
				}
				case 43u:
					num = (int)(num2 * 59760758) ^ -783330602;
					continue;
				case 42u:
					num = (int)(num2 * 1233212339) ^ -1524259118;
					continue;
				case 41u:
					flag14 = jSONNode != null;
					num = ((int)num2 * -624119437) ^ 0x400562B6;
					continue;
				case 40u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1318160389) ^ 0x73A01BC1;
					continue;
				case 39u:
					num = (int)(num2 * 1652204733) ^ -277709175;
					continue;
				case 38u:
					num3 += 4;
					num = (int)(num2 * 1608180720) ^ -1387035463;
					continue;
				case 37u:
					num = (int)(num2 * 1749123304) ^ -1429837962;
					continue;
				case 36u:
					num = 786326617;
					continue;
				case 35u:
					num = ((int)num2 * -294133146) ^ -1491733063;
					continue;
				case 34u:
					goto IL_0cbb;
				case 33u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 1259127109) ^ 0x49B70152);
					continue;
				case 32u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 494738374) ^ 0x5CB63FDC);
					continue;
				case 31u:
					num = ((int)num2 * -299137628) ^ 0x49AEDD95;
					continue;
				case 30u:
					num = (int)((num2 * 1358426450) ^ 0x5CEE9312);
					continue;
				case 29u:
				{
					int num21;
					int num22;
					if (!flag8)
					{
						num21 = 392273337;
						num22 = 392273337;
					}
					else
					{
						num21 = 767036939;
						num22 = 767036939;
					}
					num = num21 ^ (int)(num2 * 642056418);
					continue;
				}
				case 28u:
					flag11 = jSONNode is JSONArray;
					num = (int)((num2 * 2106494543) ^ 0x6B3B9420);
					continue;
				case 26u:
				{
					int num17;
					int num18;
					if (!flag11)
					{
						num17 = 1354352094;
						num18 = 1354352094;
					}
					else
					{
						num17 = 257356366;
						num18 = 257356366;
					}
					num = num17 ^ ((int)num2 * -2055831328);
					continue;
				}
				case 25u:
				{
					int num15;
					int num16;
					if (c != ':')
					{
						num15 = 100844375;
						num16 = 100844375;
					}
					else
					{
						num15 = 1162484822;
						num16 = 1162484822;
					}
					num = num15 ^ ((int)num2 * -569897645);
					continue;
				}
				case 24u:
					flag9 = flag;
					num = (int)(num2 * 1856059542) ^ -1474488855;
					continue;
				case 23u:
					text2 = "";
					num = (int)((num2 * 978932222) ^ 0x4E234703);
					continue;
				case 22u:
				{
					int num13;
					int num14;
					if (jSONNode is JSONArray)
					{
						num13 = -1634202735;
						num14 = -1634202735;
					}
					else
					{
						num13 = -1013902648;
						num14 = -1013902648;
					}
					num = num13 ^ ((int)num2 * -496423146);
					continue;
				}
				case 21u:
					num = (int)(num2 * 1962183537) ^ -550837048;
					continue;
				case 20u:
					flag8 = JSONNode.smethod_6(text, "");
					num = 1855720097;
					continue;
				case 19u:
				{
					int num11;
					int num12;
					if (flag7)
					{
						num11 = 1754209160;
						num12 = 1754209160;
					}
					else
					{
						num11 = 1149754049;
						num12 = 1149754049;
					}
					num = num11 ^ ((int)num2 * -799151273);
					continue;
				}
				case 18u:
					flag6 = stack.Count == 0;
					num = 1251908871;
					continue;
				case 17u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1398299905) ^ -332269687;
					continue;
				case 16u:
				{
					int num10;
					if (c2 != 'f')
					{
						num = 1564160298;
						num10 = 1564160298;
					}
					else
					{
						num = 1149438936;
						num10 = 1149438936;
					}
					continue;
				}
				case 15u:
					num = ((int)num2 * -2032584491) ^ 0x65948C36;
					continue;
				case 14u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1355198935) ^ 0x7A51784);
					continue;
				case 13u:
				{
					int num4;
					int num5;
					if ((uint)c2 > 102u)
					{
						num4 = 427343139;
						num5 = 427343139;
					}
					else
					{
						num4 = 1128929003;
						num5 = 1128929003;
					}
					num = num4 ^ ((int)num2 * -591462476);
					continue;
				}
				case 12u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1962535968) ^ -83946403;
					continue;
				case 10u:
					text = JSONNode.smethod_5(text);
					flag3 = jSONNode is JSONArray;
					num = (int)(num2 * 516778386) ^ -1554560066;
					continue;
				case 9u:
					num = (int)(num2 * 626519273) ^ -1781821914;
					continue;
				case 8u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -58111746) ^ 0x32AC9BD2;
					continue;
				case 7u:
					num = ((int)num2 * -1778084327) ^ -431982360;
					continue;
				case 5u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 954138133) ^ 0x14E10521);
					continue;
				case 4u:
					num = ((int)num2 * -305530296) ^ -1252231683;
					continue;
				case 3u:
					flag2 = flag;
					num = 1678104268;
					continue;
				case 2u:
					stack.Push(new JSONArray());
					num = 1832126809;
					continue;
				case 0u:
					switch (c)
					{
					case '\v':
					case '\f':
						break;
					case '\n':
					case '\r':
						goto IL_0663;
					case '\t':
						goto IL_0cbb;
					default:
						goto IL_1040;
					}
					goto case 99u;
				case 47u:
					break;
				case 1u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 50u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_1040:
					num = (int)((num2 * 105192735) ^ 0x46D52E29);
					continue;
					IL_0210:
					text2 = JSONNode.smethod_3(text2, c3.ToString());
					num = 630256222;
					continue;
					IL_0560:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 114826737;
					continue;
					IL_0cbb:
					flag13 = flag;
					num = 327994331;
					continue;
					IL_0ac9:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 630256222;
					continue;
					IL_0abf:
					num = 2069854515;
					continue;
					IL_0999:
					num = 1377496864;
					continue;
					IL_0193:
					num3++;
					num = 232979165;
					continue;
					IL_0663:
					num3++;
					num = 381241106;
					continue;
					IL_0634:
					flag19 = flag;
					num = 474005791;
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
			int num = 1184422411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x630C6EB7u) % 3u)
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
				num = ((int)num2 * -371813689) ^ 0x58F43550;
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
				int num = 1848829275;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4911DB51u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 622156051) ^ -461683114;
						continue;
					case 1u:
						num = (int)((num2 * 882494937) ^ 0x6D3447B3);
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
					int num3 = 1445695476;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x4911DB51u) % 4u)
						{
						case 3u:
							num3 = (int)((num2 * 2141964837) ^ 0x40CBCEBA);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1716135596) ^ 0x7847C9AA;
							continue;
						default:
							goto end_IL_0093;
						case 2u:
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
			while (true)
			{
				int num = 982286362;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFF258Fu) % 5u)
					{
					case 2u:
						SaveToStream(memoryStream);
						num = (int)((num2 * 1171142120) ^ 0x7DFF7245);
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -835324370) ^ -32659147;
						continue;
					case 0u:
						num = ((int)num2 * -170963570) ^ 0x20B79F0C;
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
					IL_00cc:
					int num3 = 834578578;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xFF258Fu) % 4u)
						{
						case 3u:
							num3 = ((int)num2 * -1199826664) ^ -427145771;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 451156952) ^ 0x2AAF29CC);
							continue;
						default:
							goto end_IL_00ab;
						case 0u:
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
		JSONClass jSONClass = default(JSONClass);
		int num5 = default(int);
		JSONNode result = default(JSONNode);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		bool flag2 = default(bool);
		int num4 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		bool flag = default(bool);
		int num3 = default(int);
		int num6 = default(int);
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = -88360968;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8EFD777u) % 38u)
				{
				case 37u:
					num = ((int)num2 * -1094006371) ^ 0x29FED80C;
					continue;
				case 36u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num5++;
					num = ((int)num2 * -2046563199) ^ -1591837618;
					continue;
				}
				case 35u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -686790046;
					continue;
				case 34u:
					goto IL_0064;
				case 33u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = (int)(num2 * 520506013) ^ -1193740166;
					continue;
				case 32u:
					num = (int)((num2 * 1926076835) ^ 0xBFCCA7);
					continue;
				case 31u:
					num = (int)(num2 * 384545578) ^ -954018345;
					continue;
				case 30u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -970778468;
						num10 = -970778468;
					}
					else
					{
						num9 = -1105711896;
						num10 = -1105711896;
					}
					num = num9 ^ (int)(num2 * 314694865);
					continue;
				}
				case 29u:
					num = (int)(num2 * 100694587) ^ -825546802;
					continue;
				case 27u:
					flag2 = num5 < num4;
					num = -2119758195;
					continue;
				case 26u:
					num = (int)((num2 * 18609625) ^ 0x18393518);
					continue;
				case 25u:
					num = ((int)num2 * -619797328) ^ 0x577BDD1D;
					continue;
				case 24u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -1124476426) ^ 0xB5C1CAF;
					continue;
				case 23u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)(num2 * 1212161430) ^ -1800649483;
					continue;
				case 22u:
					num = ((int)num2 * -548508058) ^ 0x549F9D0D;
					continue;
				case 21u:
					num = -1259737453;
					continue;
				case 20u:
					flag = num3 < num6;
					num = -1518613067;
					continue;
				case 19u:
					result = jSONClass;
					num = ((int)num2 * -1656091032) ^ 0x403EEF82;
					continue;
				case 18u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.IntValue:
						break;
					case JSONBinaryTag.DoubleValue:
						goto IL_0064;
					default:
						goto IL_01c2;
					case JSONBinaryTag.Array:
						goto IL_01d5;
					case JSONBinaryTag.Class:
						goto IL_01df;
					case JSONBinaryTag.Value:
						goto IL_01e9;
					case JSONBinaryTag.BoolValue:
						goto IL_01f3;
					case JSONBinaryTag.FloatValue:
						goto IL_020a;
					}
					goto case 35u;
				case 17u:
					goto IL_01d5;
				case 6u:
					goto IL_01df;
				case 2u:
					goto IL_01e9;
				case 14u:
					goto IL_01f3;
				case 12u:
					goto IL_020a;
				case 16u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1220643671;
						num8 = -1220643671;
					}
					else
					{
						num7 = -52248639;
						num8 = -52248639;
					}
					num = num7 ^ (int)(num2 * 1108389441);
					continue;
				}
				case 15u:
					num6 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num3 = 0;
					num = ((int)num2 * -67836669) ^ -196994966;
					continue;
				case 13u:
					jSONClass = new JSONClass();
					num5 = 0;
					num = (int)(num2 * 1412128953) ^ -1672255109;
					continue;
				case 11u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -1122581279) ^ 0x5F2352BD;
					continue;
				case 10u:
					jSONArray.Add(Deserialize(aReader));
					num = -1475253605;
					continue;
				case 9u:
					num = -61115617;
					continue;
				case 7u:
					num4 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -442774417) ^ -227950711;
					continue;
				case 4u:
					result = jSONArray;
					num = ((int)num2 * -1538542966) ^ -895983883;
					continue;
				case 3u:
					num3++;
					num = ((int)num2 * -45907215) ^ -4377710;
					continue;
				case 1u:
					num = ((int)num2 * -867588693) ^ -890414143;
					continue;
				case 0u:
					num = ((int)num2 * -1630914467) ^ 0x58D6E5E1;
					continue;
				case 5u:
					break;
				case 28u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0064:
					num = -69965076;
					continue;
					IL_020a:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1580053346;
					continue;
					IL_01f3:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -2067632551;
					continue;
					IL_01e9:
					num = -1761516508;
					continue;
					IL_01df:
					num = -413400958;
					continue;
					IL_01d5:
					num = -1255529880;
					continue;
					IL_01c2:
					num = ((int)num2 * -1538311522) ^ 0x16539272;
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
				int num = 286069743;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x40EC37B4u) % 3u)
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
					result = Deserialize(binaryReader);
					num = (int)((num2 * 1837595955) ^ 0x35165C8B);
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
					int num3 = 814887527;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x40EC37B4u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)((num2 * 512209521) ^ 0x57EA82B5);
							continue;
						case 2u:
							num3 = ((int)num2 * -1820093291) ^ -1551840545;
							continue;
						default:
							goto end_IL_006b;
						case 0u:
							break;
						case 1u:
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
					int num = -422290311;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x8DAD52CEu) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 1662152552) ^ 0x21019197);
							continue;
						case 1u:
							num = (int)(num2 * 859750129) ^ -74122299;
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
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1857821089;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58B380FFu) % 5u)
				{
				case 3u:
					num = ((int)num2 * -1795347563) ^ 0x32946A97;
					continue;
				case 1u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1996182259) ^ -2019226023;
					continue;
				}
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1824585204) ^ 0x4C7D607D);
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

	public JSONNode()
	{
		while (true)
		{
			int num = 2128541279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x929C7FDu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1801553869) ^ 0x750F881B;
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
