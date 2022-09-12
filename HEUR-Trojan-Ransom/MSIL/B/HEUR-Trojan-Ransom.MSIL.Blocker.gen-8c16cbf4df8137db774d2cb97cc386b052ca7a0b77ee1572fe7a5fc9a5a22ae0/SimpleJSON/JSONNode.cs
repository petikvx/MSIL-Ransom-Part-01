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
				int num = 1463162384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7083E11Eu) % 4u)
					{
					case 2u:
						result = null;
						num = (int)((num2 * 1395427982) ^ 0xC78D573);
						continue;
					case 1u:
						num = ((int)num2 * -1549679084) ^ -1345292494;
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

	public virtual JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = null;
			while (true)
			{
				int num = 636558633;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x45565DD8u) % 3u)
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
					num = ((int)num2 * -644388196) ^ -1096832266;
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
				int num = 670613913;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BD7F686u) % 4u)
					{
					case 3u:
						result = 0;
						num = ((int)num2 * -2133512585) ^ -352139173;
						continue;
					case 0u:
						num = ((int)num2 * -1127307795) ^ -1002708241;
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
				int num = -1235947376;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x83EB3EB9u) % 3u)
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
					num = ((int)num2 * -2065322986) ^ -1437180237;
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
			int result2 = default(int);
			int result = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -78668279;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x800AFADEu) % 8u)
					{
					case 7u:
						result2 = 0;
						num = (int)((num2 * 1017436617) ^ 0x3C77C379);
						continue;
					case 6u:
						result = 0;
						num = -1385432497;
						continue;
					case 5u:
						num = ((int)num2 * -1392133790) ^ -1488672011;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -682669216;
							num4 = -682669216;
						}
						else
						{
							num3 = -1270693683;
							num4 = -1270693683;
						}
						num = num3 ^ ((int)num2 * -322501930);
						continue;
					}
					case 3u:
						result = result2;
						num = ((int)num2 * -1220369319) ^ 0x71A203D0;
						continue;
					case 0u:
						flag = int.TryParse(Value, out result2);
						num = (int)(num2 * 393686850) ^ -996633982;
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
			while (true)
			{
				int num = -1625039548;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81A68F3Au) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = (int)((num2 * 1871534027) ^ 0x7F73528D);
						continue;
					case 1u:
						num = (int)((num2 * 670222396) ^ 0x4B0B08F5);
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

	public virtual float AsFloat
	{
		get
		{
			float result2 = default(float);
			float result = default(float);
			while (true)
			{
				int num = 1140980944;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x722BFFAEu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = -1306850282;
							num4 = -1306850282;
						}
						else
						{
							num3 = -1463859084;
							num4 = -1463859084;
						}
						num = num3 ^ ((int)num2 * -1945965470);
						continue;
					}
					case 3u:
						result2 = 0f;
						num = (int)((num2 * 163677611) ^ 0x79D3B118);
						continue;
					case 2u:
						result = 0f;
						num = 1384076648;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1592755411) ^ -711598645;
						continue;
					case 0u:
						num = ((int)num2 * -37727817) ^ -1516919429;
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
			while (true)
			{
				int num = -2059850199;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF056AD4Bu) % 3u)
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
					num = (int)((num2 * 1150054651) ^ 0x63FBF55E);
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			bool flag = default(bool);
			double result = default(double);
			double result2 = default(double);
			while (true)
			{
				int num = -1294075166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAF95E1F9u) % 9u)
					{
					case 8u:
						num = ((int)num2 * -203283633) ^ -1591502710;
						continue;
					case 6u:
						num = ((int)num2 * -545329116) ^ 0x3C529B7A;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1534054563;
							num4 = -1534054563;
						}
						else
						{
							num3 = -983788545;
							num4 = -983788545;
						}
						num = num3 ^ (int)(num2 * 918983309);
						continue;
					}
					case 4u:
						result = 0.0;
						num = -1145158445;
						continue;
					case 3u:
						result = result2;
						num = ((int)num2 * -1199284645) ^ 0x62626E21;
						continue;
					case 2u:
						result2 = 0.0;
						num = (int)((num2 * 1520437861) ^ 0x57BB9445);
						continue;
					case 1u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -598432544) ^ -1706024739;
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
				int num = 1354629515;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x39141074u) % 3u)
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
					num = ((int)num2 * -2096603353) ^ 0x57775BF5;
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
				int num = 1068766079;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x727B5C01u) % 8u)
					{
					case 7u:
						result = !JSONNode.smethod_1(Value);
						num = 2009625765;
						continue;
					case 6u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = (int)((num2 * 1910104925) ^ 0x7C1C1372);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -832103566;
							num4 = -832103566;
						}
						else
						{
							num3 = -5058266;
							num4 = -5058266;
						}
						num = num3 ^ (int)(num2 * 602626844);
						continue;
					}
					case 4u:
						num = (int)((num2 * 942277818) ^ 0x1C141B69);
						continue;
					case 3u:
						result = result2;
						num = ((int)num2 * -1507732944) ^ -608471256;
						continue;
					case 1u:
						num = (int)(num2 * 1711031338) ^ -105518309;
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
			while (true)
			{
				int num = 1203569863;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5D3F2C09u) % 4u)
					{
					case 2u:
						Value = (value ? "true" : "false");
						num = 1190195268;
						continue;
					case 1u:
						num = (int)(num2 * 232528995) ^ -1096734967;
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
				int num = -2088696095;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE26D791Cu) % 3u)
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
					result = this as JSONArray;
					num = ((int)num2 * -109089651) ^ -1672060455;
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
				int num = 530870776;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BD26771u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 620310453) ^ -1478426126;
						continue;
					case 1u:
						result = this as JSONClass;
						num = ((int)num2 * -1646597001) ^ 0x7DC09B05;
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
			int num = 463571687;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47A0CF94u) % 4u)
				{
				case 3u:
					Add("", aItem);
					num = (int)((num2 * 1969973532) ^ 0x6563CD02);
					continue;
				case 2u:
					num = (int)((num2 * 1226443905) ^ 0x31BB805B);
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
			int num = 383459689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28A7D1F0u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 2117787952) ^ 0x520D0120);
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -736698511) ^ -505408818;
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

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -447014277;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE00A1C3Au) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1519263578) ^ -1548963420;
					continue;
				case 1u:
					result = null;
					num = (int)(num2 * 131787018) ^ -136033997;
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
		return aNode;
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = -481410749;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE70BEDAFu) % 3u)
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
				num = (int)(num2 * 83078230) ^ -822128509;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1902037256;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAEB63AFFu) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = ((int)num2 * -734668128) ^ 0x6591D9D7;
					continue;
				case 0u:
					num = ((int)num2 * -306450007) ^ -1142737666;
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1333829400;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E23E154u) % 3u)
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
				num = ((int)num2 * -1294352884) ^ 0x6AB67A30;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -2021025855;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xB77533ECu) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = (int)(num2 * 226487729) ^ -1517448424;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
					num = ((int)num2 * -1631321623) ^ -843371630;
					continue;
				case 0u:
					obj = d.Value;
					goto IL_001c;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = -1029896583;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -427352549;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x839269A6u) % 9u)
				{
				case 8u:
					result = true;
					num = (int)((num2 * 480826426) ^ 0xEABBD16);
					continue;
				case 6u:
					result = (object)a == b;
					num = -1428181880;
					continue;
				case 4u:
					if (b == null)
					{
						num = ((int)num2 * -483527223) ^ 0x7E464A43;
						continue;
					}
					num3 = 0;
					goto IL_0036;
				case 3u:
					num = (int)((num2 * 1119210269) ^ 0x153621A5);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 984849606;
						num5 = 984849606;
					}
					else
					{
						num4 = 1691619951;
						num5 = 1691619951;
					}
					num = num4 ^ ((int)num2 * -843857484);
					continue;
				}
				case 1u:
					num = ((int)num2 * -2028383250) ^ -1085769509;
					continue;
				case 0u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0036;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0036:
					flag = (byte)num3 != 0;
					num = -341965893;
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
			int num = -762232763;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF1C7E6CCu) % 3u)
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
				result = !(a == b);
				num = (int)(num2 * 1147309164) ^ -506338416;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -57203911;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2560F50u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 578233113) ^ -1619006190;
					continue;
				case 1u:
					result = (object)this == obj;
					num = ((int)num2 * -1749666854) ^ -1556523928;
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
			int num = -861342475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF8F4DAB4u) % 4u)
				{
				case 1u:
					result = this.method_0();
					num = ((int)num2 * -989110686) ^ 0x5004241A;
					continue;
				case 0u:
					num = (int)(num2 * 481708664) ^ -1441621209;
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

	internal static string Escape(string aText)
	{
		string text = "";
		int num4 = default(int);
		string string_ = default(string);
		string result = default(string);
		char c = default(char);
		char c2 = default(char);
		while (true)
		{
			int num = 677224436;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6826C14Du) % 29u)
				{
				case 28u:
					num = ((int)num2 * -107969909) ^ -124315686;
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1538161539;
					continue;
				case 26u:
				{
					int num5;
					if (num4 < JSONNode.smethod_4(string_))
					{
						num = 1725929488;
						num5 = 1725929488;
					}
					else
					{
						num = 883975047;
						num5 = 883975047;
					}
					continue;
				}
				case 25u:
					text = JSONNode.smethod_3(text, "\\b");
					num = 896809664;
					continue;
				case 24u:
					num4++;
					num = 1154901070;
					continue;
				case 23u:
					result = text;
					num = ((int)num2 * -520267899) ^ -937940467;
					continue;
				case 22u:
					num = ((int)num2 * -891381084) ^ -785963830;
					continue;
				case 21u:
					num4 = 0;
					num = ((int)num2 * -633832450) ^ -1256804599;
					continue;
				case 20u:
				{
					int num6;
					if (c == '\\')
					{
						num = 1263368552;
						num6 = 1263368552;
					}
					else
					{
						num = 1794708098;
						num6 = 1794708098;
					}
					continue;
				}
				case 19u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1198161402;
					continue;
				case 17u:
					num = ((int)num2 * -1535600242) ^ -1130012815;
					continue;
				case 16u:
					goto IL_0106;
				case 15u:
					num = (int)(num2 * 363803228) ^ -491981462;
					continue;
				case 14u:
					goto IL_0131;
				case 13u:
					num = ((int)num2 * -613125575) ^ 0x7C932E24;
					continue;
				case 12u:
					num = ((int)num2 * -2374406) ^ 0x172AE648;
					continue;
				case 11u:
					num = (int)(num2 * 681126744) ^ -312105467;
					continue;
				case 10u:
					string_ = aText;
					num = ((int)num2 * -217297602) ^ -1024318015;
					continue;
				case 9u:
					num = ((int)num2 * -1654099867) ^ 0x60DC2FBE;
					continue;
				case 8u:
					goto IL_01a8;
				case 7u:
				{
					char c3 = c2;
					c = c3;
					switch (c)
					{
					case '\b':
						break;
					case '\v':
						goto IL_0106;
					case '\f':
						goto IL_0131;
					case '\r':
						goto IL_01a8;
					default:
						goto IL_01e6;
					case '\t':
						goto IL_01f6;
					case '\n':
						goto IL_0209;
					}
					goto case 25u;
				}
				case 2u:
					goto IL_01f6;
				case 1u:
					goto IL_0209;
				case 5u:
					c2 = JSONNode.smethod_2(string_, num4);
					num = 1917896812;
					continue;
				case 4u:
					num = (int)(num2 * 289612036) ^ -44154706;
					continue;
				case 3u:
					num = ((int)num2 * -1255584280) ^ -68036861;
					continue;
				case 0u:
				{
					int num3;
					if (c != '"')
					{
						num = 268015756;
						num3 = 268015756;
					}
					else
					{
						num = 690908596;
						num3 = 690908596;
					}
					continue;
				}
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0209:
					text = JSONNode.smethod_3(text, "\\n");
					num = 2091314721;
					continue;
					IL_01f6:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1867718193;
					continue;
					IL_01e6:
					num = ((int)num2 * -871462772) ^ -53269335;
					continue;
					IL_01a8:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1198161402;
					continue;
					IL_0131:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1395690425;
					continue;
					IL_0106:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1308943149;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		bool flag11 = default(bool);
		string text = default(string);
		bool flag9 = default(bool);
		string text2 = default(string);
		char c = default(char);
		string s = default(string);
		JSONNode jSONNode = default(JSONNode);
		int num3 = default(int);
		char c3 = default(char);
		bool flag13 = default(bool);
		bool flag2 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag14 = default(bool);
		bool flag4 = default(bool);
		char c2 = default(char);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag15 = default(bool);
		char c4 = default(char);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 292623310;
			while (true)
			{
				uint num2;
				int num44;
				switch ((num2 = (uint)num ^ 0x3FA69DB8u) % 153u)
				{
				case 152u:
					num = ((int)num2 * -172844055) ^ -1404054267;
					continue;
				case 151u:
					num = ((int)num2 * -686195112) ^ -1274973811;
					continue;
				case 150u:
				{
					int num46;
					int num47;
					if (flag11)
					{
						num46 = 459794558;
						num47 = 459794558;
					}
					else
					{
						num46 = 1511878283;
						num47 = 1511878283;
					}
					num = num46 ^ (int)(num2 * 1926713377);
					continue;
				}
				case 149u:
					num = 2111040122;
					continue;
				case 148u:
					text = JSONNode.smethod_3(text, "\t");
					num = 293394945;
					continue;
				case 147u:
					flag11 = flag9;
					num = 895966140;
					continue;
				case 146u:
					num = (int)(num2 * 57130121) ^ -1092379343;
					continue;
				case 145u:
					num = (int)((num2 * 330971708) ^ 0x2E568905);
					continue;
				case 144u:
					text2 = "";
					num = ((int)num2 * -1291419799) ^ 0x72027DCD;
					continue;
				case 143u:
				{
					int num48;
					if (c != '{')
					{
						num = 374769381;
						num48 = 374769381;
					}
					else
					{
						num = 1949608566;
						num48 = 1949608566;
					}
					continue;
				}
				case 142u:
				{
					int num41;
					if (stack.Count == 0)
					{
						num = 1609878814;
						num41 = 1609878814;
					}
					else
					{
						num = 837524816;
						num41 = 837524816;
					}
					continue;
				}
				case 141u:
					stack.Push(new JSONArray());
					num = 1889406123;
					continue;
				case 140u:
					num = 1272112071;
					continue;
				case 139u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -466805100) ^ 0x15EC70FA;
					continue;
				case 138u:
					num = ((int)num2 * -2142705997) ^ 0xB58CE2F;
					continue;
				case 137u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -104176085) ^ -485237053;
					continue;
				case 136u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1618561349) ^ 0x18DEEA26;
					continue;
				case 135u:
				{
					int num23;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 326000362;
						num23 = 326000362;
					}
					else
					{
						num = 1242627803;
						num23 = 1242627803;
					}
					continue;
				}
				case 134u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -81203372) ^ -375075745;
					continue;
				case 133u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 416651216) ^ 0x69E90EFD);
					continue;
				case 132u:
					num = ((int)num2 * -803554244) ^ -1559040770;
					continue;
				case 131u:
					num = ((int)num2 * -730196232) ^ -966700288;
					continue;
				case 130u:
					c3 = JSONNode.smethod_2(aJSON, num3);
					num = (int)(num2 * 816974908) ^ -894035231;
					continue;
				case 129u:
					num = (int)(num2 * 826660148) ^ -2101505889;
					continue;
				case 128u:
					text2 = "";
					num = 874193283;
					continue;
				case 6u:
				case 16u:
				case 94u:
				case 110u:
				case 127u:
					goto IL_0287;
				case 126u:
					num = ((int)num2 * -961920626) ^ -2025368903;
					continue;
				case 125u:
				{
					int num60;
					if ((uint)c <= 93u)
					{
						num = 915225990;
						num60 = 915225990;
					}
					else
					{
						num = 1026123136;
						num60 = 1026123136;
					}
					continue;
				}
				case 123u:
					flag13 = jSONNode is JSONArray;
					num = (int)(num2 * 1870815618) ^ -770952212;
					continue;
				case 122u:
					num = ((int)num2 * -692871962) ^ -1533971032;
					continue;
				case 121u:
				{
					int num54;
					int num55;
					if (c == ':')
					{
						num54 = 1238953817;
						num55 = 1238953817;
					}
					else
					{
						num54 = 1529020935;
						num55 = 1529020935;
					}
					num = num54 ^ ((int)num2 * -338296176);
					continue;
				}
				case 120u:
					flag2 = jSONNode is JSONArray;
					num = ((int)num2 * -516650693) ^ -749725176;
					continue;
				case 119u:
					stack.Pop();
					num = 1240417396;
					continue;
				case 118u:
					num = (int)(num2 * 1257726300) ^ -862516279;
					continue;
				case 117u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -2020951539) ^ 0x2873A655;
					continue;
				case 116u:
					result = jSONNode;
					num = 40185106;
					continue;
				case 115u:
					switch (c)
					{
					case '[':
						goto IL_03bf;
					case '\\':
						goto IL_03df;
					case ']':
						goto IL_03f1;
					}
					num = 1217015550;
					continue;
				case 68u:
					goto IL_03bf;
				case 109u:
					goto IL_03df;
				case 50u:
					goto IL_03f1;
				case 114u:
				{
					int num37;
					int num38;
					if (flag14)
					{
						num37 = -1870856580;
						num38 = -1870856580;
					}
					else
					{
						num37 = -352733142;
						num38 = -352733142;
					}
					num = num37 ^ ((int)num2 * -1971187013);
					continue;
				}
				case 113u:
					jSONNode = null;
					num = (int)((num2 * 2077739125) ^ 0x7EE2BF18);
					continue;
				case 112u:
					flag4 = jSONNode is JSONArray;
					num = ((int)num2 * -1711570579) ^ -1639764818;
					continue;
				case 111u:
					num = (int)((num2 * 1629518267) ^ 0x78406E4C);
					continue;
				case 108u:
					goto IL_046e;
				case 107u:
				{
					int num30;
					int num31;
					if (c2 == 'b')
					{
						num30 = 894376672;
						num31 = 894376672;
					}
					else
					{
						num30 = 478073283;
						num31 = 478073283;
					}
					num = num30 ^ (int)(num2 * 1700677721);
					continue;
				}
				case 106u:
					num = (int)((num2 * 660286851) ^ 0x3A540C4A);
					continue;
				case 105u:
					flag8 = jSONNode != null;
					num = ((int)num2 * -836322695) ^ 0x1BC2ECE7;
					continue;
				case 104u:
				{
					int num26;
					if (num3 < JSONNode.smethod_4(aJSON))
					{
						num = 993680281;
						num26 = 993680281;
					}
					else
					{
						num = 486007944;
						num26 = 486007944;
					}
					continue;
				}
				case 103u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -1958641534) ^ 0xAA53F47;
					continue;
				case 102u:
				{
					int num22;
					if (c == '"')
					{
						num = 2133071602;
						num22 = 2133071602;
					}
					else
					{
						num = 694490026;
						num22 = 694490026;
					}
					continue;
				}
				case 101u:
					flag9 = !flag9;
					num = 1767426381;
					continue;
				case 100u:
					num = ((int)num2 * -1619326622) ^ -1000761633;
					continue;
				case 99u:
					num = ((int)num2 * -1886096989) ^ 0x776DC327;
					continue;
				case 98u:
				{
					int num16;
					int num17;
					if (flag7)
					{
						num16 = -884742111;
						num17 = -884742111;
					}
					else
					{
						num16 = -510010247;
						num17 = -510010247;
					}
					num = num16 ^ (int)(num2 * 973793846);
					continue;
				}
				case 97u:
				{
					int num10;
					int num11;
					if (!flag5)
					{
						num10 = -1641263913;
						num11 = -1641263913;
					}
					else
					{
						num10 = -1014728356;
						num11 = -1014728356;
					}
					num = num10 ^ (int)(num2 * 703754484);
					continue;
				}
				case 95u:
					num = ((int)num2 * -736429102) ^ -1266053006;
					continue;
				case 93u:
				{
					int num6;
					int num7;
					if (flag3)
					{
						num6 = 1193982681;
						num7 = 1193982681;
					}
					else
					{
						num6 = 747855668;
						num7 = 747855668;
					}
					num = num6 ^ (int)(num2 * 1887866074);
					continue;
				}
				case 92u:
				{
					int num58;
					int num59;
					if (!flag6)
					{
						num58 = 1077088445;
						num59 = 1077088445;
					}
					else
					{
						num58 = 429092256;
						num59 = 429092256;
					}
					num = num58 ^ ((int)num2 * -702058082);
					continue;
				}
				case 91u:
					num = (int)(num2 * 1566064214) ^ -1963549373;
					continue;
				case 90u:
					num = ((int)num2 * -248449730) ^ -1362943701;
					continue;
				case 89u:
					num = ((int)num2 * -168110532) ^ 0x4F0B34FC;
					continue;
				case 88u:
					text2 = "";
					text = "";
					num = 2067984257;
					continue;
				case 87u:
					text2 = "";
					text = "";
					num = 1767426381;
					continue;
				case 86u:
					num = 952951329;
					continue;
				case 85u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num3);
					c = c5;
					num = 1916100501;
					continue;
				}
				case 84u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 1316708281) ^ 0x72050E6);
					continue;
				case 83u:
					num = (int)(num2 * 111474659) ^ -1850284327;
					continue;
				case 82u:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = ((int)num2 * -529341819) ^ -1608412558;
					continue;
				case 81u:
					flag15 = flag9;
					num = (int)((num2 * 588449576) ^ 0x1183BEEE);
					continue;
				case 80u:
					num = (int)((num2 * 450339660) ^ 0xC7E5EEA);
					continue;
				case 79u:
					text = JSONNode.smethod_3(text, "\n");
					num = 442625985;
					continue;
				case 78u:
					flag3 = JSONNode.smethod_6(text2, "");
					num = 797517704;
					continue;
				case 77u:
					num = 300258327;
					continue;
				case 76u:
				{
					int num57;
					if (c2 == 'n')
					{
						num = 1384888046;
						num57 = 1384888046;
					}
					else
					{
						num = 600200931;
						num57 = 600200931;
					}
					continue;
				}
				case 75u:
				{
					int num56;
					if (flag9)
					{
						num = 245360688;
						num56 = 245360688;
					}
					else
					{
						num = 1993142433;
						num56 = 1993142433;
					}
					continue;
				}
				case 74u:
					flag14 = flag9;
					num = 517147584;
					continue;
				case 73u:
				{
					int num52;
					int num53;
					if (!(jSONNode is JSONArray))
					{
						num52 = 1661886575;
						num53 = 1661886575;
					}
					else
					{
						num52 = 783559440;
						num53 = 783559440;
					}
					num = num52 ^ (int)(num2 * 1361573754);
					continue;
				}
				case 72u:
				{
					int num50;
					int num51;
					if (flag15)
					{
						num50 = -1391212371;
						num51 = -1391212371;
					}
					else
					{
						num50 = -524263516;
						num51 = -524263516;
					}
					num = num50 ^ ((int)num2 * -957870939);
					continue;
				}
				case 71u:
					flag9 = false;
					num = ((int)num2 * -1834139766) ^ 0x3470E565;
					continue;
				case 70u:
				{
					int num49;
					if (c == ',')
					{
						num = 769636896;
						num49 = 769636896;
					}
					else
					{
						num = 2057031725;
						num49 = 2057031725;
					}
					continue;
				}
				case 69u:
					switch (c2)
					{
					case 't':
						break;
					case 's':
						goto IL_046e;
					default:
						goto IL_0882;
					case 'r':
						goto IL_088c;
					case 'u':
						goto IL_08a2;
					}
					goto case 148u;
				case 22u:
					goto IL_088c;
				case 57u:
					goto IL_08a2;
				case 66u:
				{
					int num45;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1269400422;
						num45 = 1269400422;
					}
					else
					{
						num = 1044262615;
						num45 = 1044262615;
					}
					continue;
				}
				case 65u:
					num = ((int)num2 * -1841204296) ^ -982171571;
					continue;
				case 64u:
					c2 = c4;
					num = (int)(num2 * 1274670976) ^ -319062172;
					continue;
				case 63u:
					num = 618275661;
					continue;
				case 62u:
					num3 += 4;
					num = (int)(num2 * 1012675966) ^ -769990793;
					continue;
				case 61u:
					num = (int)(num2 * 610076239) ^ -1084319786;
					continue;
				case 60u:
					text = JSONNode.smethod_3(text, "\b");
					num = 442625985;
					continue;
				case 59u:
					stack.Push(new JSONClass());
					num = 1083715063;
					continue;
				case 58u:
					text2 = text;
					num = 909743047;
					continue;
				case 56u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1240340175) ^ 0x19455F50;
					continue;
				case 55u:
				{
					int num42;
					int num43;
					if ((uint)c > 44u)
					{
						num42 = -810274033;
						num43 = -810274033;
					}
					else
					{
						num42 = -1048770947;
						num43 = -1048770947;
					}
					num = num42 ^ (int)(num2 * 1405215197);
					continue;
				}
				case 54u:
					text = "";
					num = (int)(num2 * 109062290) ^ -115157725;
					continue;
				case 53u:
					num = (int)((num2 * 596649671) ^ 0x49EC4222);
					continue;
				case 52u:
				{
					int num39;
					int num40;
					if ((uint)c > 32u)
					{
						num39 = 546032721;
						num40 = 546032721;
					}
					else
					{
						num39 = 845170716;
						num40 = 845170716;
					}
					num = num39 ^ (int)(num2 * 1496127754);
					continue;
				}
				case 51u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 1727751596) ^ -704232531;
					continue;
				case 49u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)((num2 * 259227564) ^ 0x79DDCAC8);
					continue;
				case 48u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -527912343) ^ 0x71EBFD7F;
					continue;
				case 47u:
				{
					int num36;
					if (c == ' ')
					{
						num = 1899229434;
						num36 = 1899229434;
					}
					else
					{
						num = 189762287;
						num36 = 189762287;
					}
					continue;
				}
				case 46u:
					num = ((int)num2 * -1745355733) ^ 0x4FAC8A6D;
					continue;
				case 45u:
				{
					int num35;
					if (flag9)
					{
						num = 1937582091;
						num35 = 1937582091;
					}
					else
					{
						num = 1897310314;
						num35 = 1897310314;
					}
					continue;
				}
				case 44u:
					flag5 = jSONNode != null;
					num = ((int)num2 * -719794882) ^ -519109166;
					continue;
				case 43u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 905690825) ^ -532722431;
					continue;
				case 42u:
					text2 = "";
					text = "";
					num = 1233679087;
					continue;
				case 40u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 495778061) ^ 0x1FC7D50C);
					continue;
				case 39u:
					text = "";
					jSONNode = stack.Peek();
					num = (int)(num2 * 372198443) ^ -2066880348;
					continue;
				case 38u:
					num = ((int)num2 * -1514234916) ^ -1132255879;
					continue;
				case 37u:
					num = (int)((num2 * 532228619) ^ 0x58C30E5B);
					continue;
				case 36u:
				{
					int num33;
					int num34;
					if (!flag13)
					{
						num33 = 207237809;
						num34 = 207237809;
					}
					else
					{
						num33 = 1104504411;
						num34 = 1104504411;
					}
					num = num33 ^ (int)(num2 * 1465956353);
					continue;
				}
				case 35u:
				{
					int num32;
					if (c != '}')
					{
						num = 285342485;
						num32 = 285342485;
					}
					else
					{
						num = 846535236;
						num32 = 846535236;
					}
					continue;
				}
				case 34u:
					num = (int)(num2 * 1507787782) ^ -1295565799;
					continue;
				case 33u:
					num = (int)(num2 * 9381389) ^ -2058660261;
					continue;
				case 32u:
					num = (int)((num2 * 886093879) ^ 0x6CE9DD14);
					continue;
				case 31u:
				{
					int num29;
					if (c2 != 'f')
					{
						num = 1499941124;
						num29 = 1499941124;
					}
					else
					{
						num = 1662901563;
						num29 = 1662901563;
					}
					continue;
				}
				case 30u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 908015154) ^ -2074512447;
					continue;
				case 29u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 8374759) ^ 0x23459B3);
					continue;
				case 28u:
				{
					int num27;
					int num28;
					if (!flag12)
					{
						num27 = 680782773;
						num28 = 680782773;
					}
					else
					{
						num27 = 571149693;
						num28 = 571149693;
					}
					num = num27 ^ ((int)num2 * -1411422568);
					continue;
				}
				case 27u:
				{
					int num24;
					int num25;
					if (flag10)
					{
						num24 = 992648250;
						num25 = 992648250;
					}
					else
					{
						num24 = 29306173;
						num25 = 29306173;
					}
					num = num24 ^ (int)(num2 * 6173434);
					continue;
				}
				case 26u:
					jSONNode.Add(text);
					num = (int)(num2 * 1571016205) ^ -721086418;
					continue;
				case 25u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 723181302;
					continue;
				case 24u:
					goto IL_0cef;
				case 23u:
					num = ((int)num2 * -1584111969) ^ -1941698574;
					continue;
				case 21u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -433767795) ^ -2041399242;
					continue;
				case 20u:
					num = (int)(num2 * 1600632350) ^ -918637277;
					continue;
				case 19u:
					c4 = c3;
					num = (int)(num2 * 775982779) ^ -1983814261;
					continue;
				case 18u:
					num = ((int)num2 * -115763332) ^ -178302619;
					continue;
				case 17u:
					jSONNode.Add(text);
					num = (int)(num2 * 1050358908) ^ -101481472;
					continue;
				case 15u:
					text = JSONNode.smethod_3(text, "\f");
					num = 1114260156;
					continue;
				case 14u:
					num = (int)((num2 * 318281989) ^ 0x58118393);
					continue;
				case 13u:
				{
					int num20;
					int num21;
					if (flag)
					{
						num20 = 872067121;
						num21 = 872067121;
					}
					else
					{
						num20 = 1752998931;
						num21 = 1752998931;
					}
					num = num20 ^ ((int)num2 * -1479119595);
					continue;
				}
				case 12u:
				{
					int num18;
					int num19;
					if (!flag8)
					{
						num18 = 664995502;
						num19 = 664995502;
					}
					else
					{
						num18 = 2135196004;
						num19 = 2135196004;
					}
					num = num18 ^ ((int)num2 * -786134507);
					continue;
				}
				case 11u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -641495605) ^ 0xD268228;
					continue;
				case 10u:
					num = ((int)num2 * -1550335256) ^ -1052135811;
					continue;
				case 9u:
					num = (int)((num2 * 538188621) ^ 0x444434CF);
					continue;
				case 8u:
				{
					int num14;
					int num15;
					if (stack.Count <= 0)
					{
						num14 = 472645146;
						num15 = 472645146;
					}
					else
					{
						num14 = 1853863627;
						num15 = 1853863627;
					}
					num = num14 ^ ((int)num2 * -1179643290);
					continue;
				}
				case 7u:
					flag6 = JSONNode.smethod_6(text, "");
					num = 1151210730;
					continue;
				case 5u:
				{
					int num12;
					int num13;
					if ((uint)c2 > 102u)
					{
						num12 = 553902430;
						num13 = 553902430;
					}
					else
					{
						num12 = 798697924;
						num13 = 798697924;
					}
					num = num12 ^ ((int)num2 * -783787115);
					continue;
				}
				case 4u:
					switch (c)
					{
					case '\t':
						break;
					case '\n':
					case '\r':
						goto IL_0287;
					case '\v':
					case '\f':
						goto IL_0cef;
					default:
						goto IL_0ef0;
					}
					goto case 147u;
				case 3u:
				{
					int num8;
					int num9;
					if (flag4)
					{
						num8 = -960018372;
						num9 = -960018372;
					}
					else
					{
						num8 = -1813612936;
						num9 = -1813612936;
					}
					num = num8 ^ ((int)num2 * -1899159891);
					continue;
				}
				case 2u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -1504551157;
						num5 = -1504551157;
					}
					else
					{
						num4 = -98293533;
						num5 = -98293533;
					}
					num = num4 ^ ((int)num2 * -1738739936);
					continue;
				}
				case 1u:
					num3 = 0;
					text = "";
					num = ((int)num2 * -1339475887) ^ 0x1D446E1;
					continue;
				case 0u:
					flag = JSONNode.smethod_6(text, "");
					num = (int)(num2 * 1173749056) ^ -1628951619;
					continue;
				case 96u:
					break;
				case 67u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 124u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0287:
					num3++;
					num = 335860775;
					continue;
					IL_0ef0:
					num = ((int)num2 * -998936733) ^ 0x4650717F;
					continue;
					IL_0cef:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = 1767426381;
					continue;
					IL_046e:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 442625985;
					continue;
					IL_03df:
					num3++;
					flag12 = flag9;
					num = 1694432957;
					continue;
					IL_03bf:
					if (flag9)
					{
						num = 1860371618;
						num44 = 1860371618;
					}
					else
					{
						num = 1752929221;
						num44 = 1752929221;
					}
					continue;
					IL_03f1:
					flag10 = flag9;
					num = 27592805;
					continue;
					IL_08a2:
					num = 1399080132;
					continue;
					IL_088c:
					text = JSONNode.smethod_3(text, "\r");
					num = 2096782866;
					continue;
					IL_0882:
					num = 1899892300;
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
			int num = 1939725702;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x625A1BF4u) % 4u)
				{
				case 3u:
					Serialize(aWriter);
					num = (int)((num2 * 1738584464) ^ 0x5CFE0A01);
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -2074693012) ^ -440212833;
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
		while (true)
		{
			int num = 28243011;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5628DFBEu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
				{
					FileStream fileStream = JSONNode.smethod_14(aFileName);
					try
					{
						while (true)
						{
							int num3 = 1394546074;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5628DFBEu) % 5u)
								{
								case 4u:
									num3 = (int)((num2 * 1047081494) ^ 0x831A128);
									continue;
								case 3u:
									SaveToStream(fileStream);
									num3 = (int)((num2 * 202315253) ^ 0x3A6E18B1);
									continue;
								case 1u:
									num3 = (int)(num2 * 299650050) ^ -1436241009;
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
								IL_00fc:
								int num4 = 1858132055;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0x5628DFBEu) % 4u)
									{
									case 3u:
										num4 = ((int)num2 * -1823093386) ^ 0xC21E850;
										continue;
									case 1u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num4 = ((int)num2 * -1946297013) ^ 0x6E2FFBD2;
										continue;
									default:
										goto end_IL_00db;
									case 2u:
										break;
									case 0u:
										goto end_IL_00db;
									}
									goto IL_00fc;
									continue;
									end_IL_00db:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0003:
				JSONNode.smethod_13(JSONNode.smethod_12((FileSystemInfo)JSONNode.smethod_11(JSONNode.smethod_10(aFileName))));
				num = (int)((num2 * 1161630281) ^ 0x7F42D412);
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
				int num = -1579262209;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEB43AEF7u) % 3u)
					{
					case 2u:
						goto IL_000f;
					case 0u:
						break;
					default:
						return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
					}
					break;
					IL_000f:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1569338123) ^ -1396584871;
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0092:
					int num3 = -82091473;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xEB43AEF7u) % 3u)
						{
						case 2u:
							goto IL_0062;
						default:
							goto end_IL_0075;
						case 0u:
							break;
						case 1u:
							goto end_IL_0075;
						}
						goto IL_0092;
						IL_0062:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -206704816) ^ -647089741;
						continue;
						end_IL_0075:
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
		int num3 = default(int);
		JSONArray jSONArray = default(JSONArray);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num9 = default(int);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		bool flag2 = default(bool);
		int num10 = default(int);
		int num4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -1810218234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DF000C8u) % 40u)
				{
				case 39u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 124120207) ^ 0x48798C6C);
					continue;
				case 38u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -333569790;
					continue;
				case 37u:
					num = ((int)num2 * -1034118658) ^ -487358338;
					continue;
				case 36u:
					num3 = 0;
					num = (int)((num2 * 1218492347) ^ 0x2CC58705);
					continue;
				case 35u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -159536318) ^ 0x2221ECDE;
					continue;
				case 34u:
					num = (int)(num2 * 1725812100) ^ -960302211;
					continue;
				case 33u:
					jSONArray.Add(Deserialize(aReader));
					num = -1953932710;
					continue;
				case 32u:
					num = (int)(num2 * 1633079421) ^ -1054953754;
					continue;
				case 31u:
					result = jSONArray;
					num = (int)((num2 * 1837275147) ^ 0x39531D10);
					continue;
				case 30u:
					num = -924308710;
					continue;
				case 29u:
					goto IL_00ea;
				case 28u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.BoolValue:
						break;
					case JSONBinaryTag.Value:
						goto IL_00ea;
					default:
						goto IL_0118;
					case JSONBinaryTag.Array:
						goto IL_012b;
					case JSONBinaryTag.Class:
						goto IL_0135;
					case JSONBinaryTag.IntValue:
						goto IL_0147;
					case JSONBinaryTag.DoubleValue:
						goto IL_0151;
					case JSONBinaryTag.FloatValue:
						goto IL_015b;
					}
					goto case 38u;
				case 8u:
					goto IL_012b;
				case 4u:
					goto IL_0135;
				case 18u:
					goto IL_0147;
				case 23u:
					goto IL_0151;
				case 3u:
					goto IL_015b;
				case 27u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -1604812940) ^ 0x24B05353;
					continue;
				case 26u:
					num = ((int)num2 * -579989870) ^ 0x678FFBAC;
					continue;
				case 25u:
					num = -99362975;
					continue;
				case 22u:
					num9 = 0;
					num = ((int)num2 * -334154299) ^ -340912954;
					continue;
				case 21u:
					num = (int)((num2 * 432054948) ^ 0x34379E8C);
					continue;
				case 20u:
					num9++;
					num = ((int)num2 * -1886481805) ^ 0x6D24DAEA;
					continue;
				case 19u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -367947599) ^ -1418413049;
					continue;
				}
				case 17u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -985189135) ^ 0x5AC64BFF;
					continue;
				case 16u:
					num = (int)((num2 * 1299991147) ^ 0x14F5E931);
					continue;
				case 14u:
					flag2 = num9 < num10;
					num = -1385755518;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -1820063827) ^ -47712608;
					continue;
				case 12u:
					num4 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = (int)(num2 * 979296659) ^ -1258922768;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 641076369;
						num8 = 641076369;
					}
					else
					{
						num7 = 2025250247;
						num8 = 2025250247;
					}
					num = num7 ^ ((int)num2 * -410185856);
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -622004908;
						num6 = -622004908;
					}
					else
					{
						num5 = -808044030;
						num6 = -808044030;
					}
					num = num5 ^ ((int)num2 * -1185111507);
					continue;
				}
				case 7u:
					num = (int)(num2 * 1763411766) ^ -1677197854;
					continue;
				case 6u:
				{
					JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)(num2 * 1383431783) ^ -247661834;
					continue;
				}
				case 5u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)((num2 * 1498362600) ^ 0x55AD3B50);
					continue;
				case 2u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -1282282161) ^ -1152783819;
					continue;
				case 1u:
					flag = num3 < num4;
					num = -1917216973;
					continue;
				case 0u:
					result = jSONClass;
					num = (int)(num2 * 2135252904) ^ -454166056;
					continue;
				case 15u:
					break;
				case 9u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_015b:
					num = -469351409;
					continue;
					IL_0151:
					num = -1949740293;
					continue;
					IL_0147:
					num = -1280509301;
					continue;
					IL_0135:
					num10 = JSONNode.smethod_21(aReader);
					num = -2071969087;
					continue;
					IL_012b:
					num = -1980262740;
					continue;
					IL_0118:
					num = (int)((num2 * 87450870) ^ 0x4A68AD00);
					continue;
					IL_00ea:
					num = -1999526587;
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
				int num = -1892652069;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE841ADCBu) % 3u)
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
					num = ((int)num2 * -2012654644) ^ 0x752083D4;
				}
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				while (true)
				{
					IL_0079:
					int num3 = -1894788613;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE841ADCBu) % 3u)
						{
						case 2u:
							goto IL_0049;
						default:
							goto end_IL_005c;
						case 0u:
							break;
						case 1u:
							goto end_IL_005c;
						}
						goto IL_0079;
						IL_0049:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = ((int)num2 * -1461399546) ^ -908543583;
						continue;
						end_IL_005c:
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
					int num = -216830098;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xDC1AC5E5u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -969016135) ^ 0x5BCACF7B;
							continue;
						case 1u:
							num = ((int)num2 * -2001062773) ^ 0x33933E04;
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
			int num = -209435701;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF351459Au) % 4u)
				{
				case 2u:
					num = (int)((num2 * 602248929) ^ 0x3C5B2330);
					continue;
				case 1u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1246704619) ^ -480804755;
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

	public JSONNode()
	{
		while (true)
		{
			int num = -1755126748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF641D206u) % 3u)
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
				num = ((int)num2 * -1697892742) ^ -1779062564;
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
