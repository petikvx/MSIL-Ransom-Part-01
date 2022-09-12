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
				int num = 789688242;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x614CE2Bu) % 3u)
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
					num = (int)(num2 * 1965553120) ^ -1451467342;
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
				int num = 1658451947;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x556B0BD5u) % 3u)
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
					num = ((int)num2 * -1292924551) ^ -597634726;
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
				int num = -422036364;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x94FB8EFDu) % 4u)
					{
					case 1u:
						result = "";
						num = (int)(num2 * 940524637) ^ -1175537260;
						continue;
					case 0u:
						num = (int)((num2 * 2110050670) ^ 0x433DC883);
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
			int result = default(int);
			while (true)
			{
				int num = 660896311;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x44F82379u) % 3u)
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
					num = (int)(num2 * 495615498) ^ -76762339;
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
				int num = 1683779766;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x24FF88F8u) % 3u)
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
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -522055466) ^ -1365831312;
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
				int num = 1997418989;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x479A6E2Cu) % 3u)
					{
					case 1u:
						goto IL_0011;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0011:
					result = _003Cget_DeepChilds_003Ed__;
					num = ((int)num2 * -1122011603) ^ 0x5C99DA32;
				}
			}
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
				int num = 1802131148;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1ADF49BBu) % 7u)
					{
					case 6u:
						result2 = 0;
						num = 1338507643;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 30637636;
							num4 = 30637636;
						}
						else
						{
							num3 = 391140104;
							num4 = 391140104;
						}
						num = num3 ^ (int)(num2 * 534124178);
						continue;
					}
					case 2u:
						num = ((int)num2 * -549722822) ^ 0x24F09331;
						continue;
					case 1u:
						num = ((int)num2 * -1243728087) ^ 0xA9FF6AD;
						continue;
					case 0u:
						result2 = result;
						num = (int)((num2 * 743518195) ^ 0x4BD7D870);
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
				int num = -2140832198;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA223E0FCu) % 4u)
					{
					case 2u:
						Value = value.ToString();
						num = ((int)num2 * -1438097912) ^ -2126908127;
						continue;
					case 1u:
						num = ((int)num2 * -464725514) ^ -1252657002;
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

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			float result2 = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num = -1462009717;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA9FB976Cu) % 7u)
					{
					case 6u:
						result2 = result;
						num = ((int)num2 * -1942352464) ^ 0x18DD303;
						continue;
					case 5u:
						num = (int)(num2 * 1728130982) ^ -1146640763;
						continue;
					case 3u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
						num = ((int)num2 * -347297148) ^ -1223607597;
						continue;
					case 1u:
						result2 = 0f;
						num = -348241723;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 272048257;
							num4 = 272048257;
						}
						else
						{
							num3 = 291357979;
							num4 = 291357979;
						}
						num = num3 ^ ((int)num2 * -763364132);
						continue;
					}
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
				int num = 380764785;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x66600D9Au) % 3u)
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
					num = ((int)num2 * -1414046426) ^ 0x469936A1;
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
				int num = 807682989;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6D6DD2ACu) % 7u)
					{
					case 6u:
						result = result2;
						num = (int)(num2 * 469401667) ^ -1513104398;
						continue;
					case 5u:
						num = ((int)num2 * -802748082) ^ -74300565;
						continue;
					case 3u:
						num = ((int)num2 * -1195961335) ^ -455388112;
						continue;
					case 2u:
						result = 0.0;
						num = 1076910339;
						continue;
					case 1u:
					{
						result2 = 0.0;
						int num3;
						int num4;
						if (double.TryParse(Value, out result2))
						{
							num3 = -151235000;
							num4 = -151235000;
						}
						else
						{
							num3 = -1107236760;
							num4 = -1107236760;
						}
						num = num3 ^ (int)(num2 * 308772512);
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
				int num = -1852795871;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA257F72u) % 4u)
					{
					case 3u:
						Value = value.ToString();
						num = (int)((num2 * 893127144) ^ 0x46C16050);
						continue;
					case 2u:
						num = (int)((num2 * 304170334) ^ 0x58C6AB9B);
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
				int num = 1892859808;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x20D4E4F8u) % 7u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 845335405;
							num4 = 845335405;
						}
						else
						{
							num3 = 1012606806;
							num4 = 1012606806;
						}
						num = num3 ^ (int)(num2 * 637613375);
						continue;
					}
					case 4u:
						num = (int)(num2 * 1048610311) ^ -129165654;
						continue;
					case 3u:
						result2 = result;
						num = ((int)num2 * -1694922641) ^ -1959901884;
						continue;
					case 1u:
						num = (int)(num2 * 1566255848) ^ -285965728;
						continue;
					case 0u:
						result2 = !JSONNode.smethod_1(Value);
						num = 2042120544;
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
			Value = (value ? "true" : "false");
			while (true)
			{
				int num = -304637070;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8175D55Du) % 3u)
					{
					case 2u:
						goto IL_0017;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0017:
					num = ((int)num2 * -1343921034) ^ 0x3295E63;
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
				int num = 1302699555;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77533CF8u) % 4u)
					{
					case 3u:
						result = this as JSONArray;
						num = ((int)num2 * -892067724) ^ 0x54753FAA;
						continue;
					case 2u:
						num = ((int)num2 * -978049803) ^ -1271508965;
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
			JSONClass result = this as JSONClass;
			while (true)
			{
				int num = 680321644;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x409D7926u) % 3u)
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
					num = ((int)num2 * -1950830933) ^ 0x5CDDC0A4;
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
			int num = 6087774;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x301DD1D1u) % 4u)
				{
				case 3u:
					Add("", aItem);
					num = (int)(num2 * 198786572) ^ -146560611;
					continue;
				case 0u:
					num = (int)((num2 * 1291182841) ^ 0x5DB34DC);
					continue;
				default:
					return;
				case 2u:
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
		JSONNode result = null;
		while (true)
		{
			int num = 2025818305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CA8351Fu) % 3u)
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
				num = (int)(num2 * 52318600) ^ -1121454945;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2054147256;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDAC782Au) % 3u)
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
				num = (int)(num2 * 764845218) ^ -858121653;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -105569666;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD780BB64u) % 4u)
				{
				case 2u:
					result = aNode;
					num = (int)(num2 * 1501157458) ^ -1518815919;
					continue;
				case 1u:
					num = ((int)num2 * -354710213) ^ -173082504;
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
			int num = -1880438227;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FDFDFF0u) % 3u)
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
				num = ((int)num2 * -689355863) ^ -1311049876;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1233460016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D84FA0Du) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1337821016) ^ 0x63B7B3A9);
					continue;
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -402185373) ^ -871356163;
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
			int num = 283592859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F77658Eu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 45727650) ^ 0x23A5060A);
					continue;
				case 1u:
					result = new JSONData(s);
					num = ((int)num2 * -743735827) ^ 0x4FC7C91D;
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
			int num = -236398433;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xE870BF73u) % 5u)
				{
				case 4u:
					obj = d.Value;
					goto IL_0009;
				case 2u:
					num = ((int)num2 * -58381011) ^ 0x1555BE4E;
					continue;
				case 1u:
					if (!(d == null))
					{
						num = (int)(num2 * 76367825) ^ -1527947565;
						continue;
					}
					obj = null;
					goto IL_0009;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = -1494423782;
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
			int num = 939089271;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x7D953664u) % 8u)
				{
				case 5u:
					num5 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_000f;
				case 4u:
					result = (object)a == b;
					num = 1321893076;
					continue;
				case 3u:
					if (b == null)
					{
						num = (int)(num2 * 610716943) ^ -2052093452;
						continue;
					}
					num5 = 0;
					goto IL_000f;
				case 2u:
					result = true;
					num = (int)((num2 * 1793758516) ^ 0x283909BB);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 206719463;
						num4 = 206719463;
					}
					else
					{
						num3 = 1053396961;
						num4 = 1053396961;
					}
					num = num3 ^ (int)(num2 * 1065720529);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1390202224) ^ 0x1B681FB3);
					continue;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_000f:
					flag = (byte)num5 != 0;
					num = 498479261;
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
			int num = 1008522440;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78E156D1u) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = (int)(num2 * 1409547722) ^ -1637407277;
					continue;
				case 0u:
					num = ((int)num2 * -1043203445) ^ -649902497;
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
			int num = 1176323039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33D7C244u) % 4u)
				{
				case 3u:
					result = (object)this == obj;
					num = (int)(num2 * 980722012) ^ -2094941378;
					continue;
				case 2u:
					num = ((int)num2 * -1976490588) ^ -1414407571;
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
		int result = default(int);
		while (true)
		{
			int num = -1148007934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD5C4555u) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = (int)(num2 * 2068595455) ^ -410624382;
					continue;
				case 2u:
					num = ((int)num2 * -1034129896) ^ -129755312;
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

	internal static string Escape(string aText)
	{
		string text = default(string);
		int num4 = default(int);
		char c3 = default(char);
		string string_ = default(string);
		string result = default(string);
		char c = default(char);
		while (true)
		{
			int num = -178904018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB063661Cu) % 30u)
				{
				case 29u:
					num = ((int)num2 * -2056691469) ^ -1628984555;
					continue;
				case 28u:
					text = "";
					num = (int)((num2 * 39536444) ^ 0x52343D87);
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, "\\b");
					num = -2079766967;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -319702349;
					continue;
				case 25u:
					num = (int)(num2 * 162592034) ^ -1101645440;
					continue;
				case 24u:
					num = (int)((num2 * 1246387235) ^ 0x7A58E519);
					continue;
				case 23u:
					num4++;
					num = -308975084;
					continue;
				case 22u:
				{
					int num6;
					if (c3 == '\\')
					{
						num = -994949336;
						num6 = -994949336;
					}
					else
					{
						num = -723240907;
						num6 = -723240907;
					}
					continue;
				}
				case 21u:
					string_ = aText;
					num4 = 0;
					num = (int)((num2 * 1405964218) ^ 0x2625AA87);
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1519278510;
					continue;
				case 19u:
					goto IL_00e1;
				case 18u:
					goto IL_00f7;
				case 17u:
					goto IL_010f;
				case 16u:
					num = ((int)num2 * -394765191) ^ -393468136;
					continue;
				case 15u:
					num = ((int)num2 * -1716964283) ^ 0x349B32AE;
					continue;
				case 14u:
				{
					int num5;
					if (num4 >= JSONNode.smethod_4(string_))
					{
						num = -571929980;
						num5 = -571929980;
					}
					else
					{
						num = -1881179732;
						num5 = -1881179732;
					}
					continue;
				}
				case 12u:
					result = text;
					num = (int)((num2 * 551675065) ^ 0x35C37CFE);
					continue;
				case 11u:
					switch (c3)
					{
					case '\b':
						break;
					case '\n':
						goto IL_00e1;
					case '\v':
						goto IL_00f7;
					case '\r':
						goto IL_010f;
					default:
						goto IL_01a7;
					case '\t':
						goto IL_01ba;
					case '\f':
						goto IL_01d0;
					}
					goto case 27u;
				case 0u:
					goto IL_01ba;
				case 10u:
					goto IL_01d0;
				case 8u:
					c = JSONNode.smethod_2(string_, num4);
					num = -1587605272;
					continue;
				case 7u:
					num = (int)(num2 * 1899255693) ^ -734484752;
					continue;
				case 6u:
				{
					int num3;
					if (c3 == '"')
					{
						num = -1053369892;
						num3 = -1053369892;
					}
					else
					{
						num = -1171279002;
						num3 = -1171279002;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -248129178) ^ 0x3529596D;
					continue;
				case 4u:
				{
					char c2 = c;
					c3 = c2;
					num = (int)((num2 * 774863778) ^ 0x57BE1E2D);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1674090186) ^ -1786242139;
					continue;
				case 2u:
					num = (int)((num2 * 1619734407) ^ 0x42DAEF59);
					continue;
				case 1u:
					num = ((int)num2 * -1248876210) ^ 0x3BA31B2;
					continue;
				case 9u:
					break;
				default:
					{
						return result;
					}
					IL_01d0:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1399990765;
					continue;
					IL_01ba:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1151289421;
					continue;
					IL_01a7:
					num = (int)(num2 * 694587755) ^ -203298498;
					continue;
					IL_010f:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1151289421;
					continue;
					IL_00f7:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -1151289421;
					continue;
					IL_00e1:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1336037147;
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
		int num3 = default(int);
		bool flag2 = default(bool);
		char c2 = default(char);
		char c5 = default(char);
		bool flag = default(bool);
		string text = default(string);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		string text2 = default(string);
		bool flag5 = default(bool);
		char c3 = default(char);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		char c4 = default(char);
		bool flag8 = default(bool);
		string s = default(string);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -2038729435;
			while (true)
			{
				uint num2;
				int num6;
				int num13;
				int num46;
				switch ((num2 = (uint)num ^ 0xFFB11EE3u) % 143u)
				{
				case 142u:
				{
					int num44;
					int num45;
					if ((uint)c <= 32u)
					{
						num44 = -344803717;
						num45 = -344803717;
					}
					else
					{
						num44 = -491279441;
						num45 = -491279441;
					}
					num = num44 ^ (int)(num2 * 1608282012);
					continue;
				}
				case 3u:
				case 32u:
				case 110u:
				case 127u:
				case 141u:
					num3++;
					num = -75696971;
					continue;
				case 139u:
					flag2 = stack.Count > 0;
					num = (int)((num2 * 2021494236) ^ 0x1AF841D5);
					continue;
				case 138u:
					c2 = JSONNode.smethod_2(aJSON, num3);
					c5 = c2;
					num = ((int)num2 * -948472588) ^ 0xA0EDDBF;
					continue;
				case 137u:
				{
					int num22;
					if (flag)
					{
						num = -1113008900;
						num22 = -1113008900;
					}
					else
					{
						num = -405842124;
						num22 = -405842124;
					}
					continue;
				}
				case 136u:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -1828504437;
					continue;
				case 135u:
					num = (int)((num2 * 1645124616) ^ 0x5889CA5F);
					continue;
				case 134u:
					num = (int)((num2 * 1775470589) ^ 0x749ABF2C);
					continue;
				case 133u:
				{
					int num29;
					int num30;
					if (flag6)
					{
						num29 = -357268946;
						num30 = -357268946;
					}
					else
					{
						num29 = -840278708;
						num30 = -840278708;
					}
					num = num29 ^ (int)(num2 * 387380479);
					continue;
				}
				case 132u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = -1914157935;
					continue;
				case 131u:
				{
					int num20;
					if (c != '{')
					{
						num = -1485995229;
						num20 = -1485995229;
					}
					else
					{
						num = -1738260349;
						num20 = -1738260349;
					}
					continue;
				}
				case 130u:
				{
					int num54;
					int num55;
					if (!(jSONNode is JSONArray))
					{
						num54 = 225749893;
						num55 = 225749893;
					}
					else
					{
						num54 = 1962143306;
						num55 = 1962143306;
					}
					num = num54 ^ ((int)num2 * -930592536);
					continue;
				}
				case 129u:
					goto IL_0175;
				case 128u:
				{
					int num35;
					int num36;
					if (flag5)
					{
						num35 = -1275659472;
						num36 = -1275659472;
					}
					else
					{
						num35 = -1410091690;
						num36 = -1410091690;
					}
					num = num35 ^ (int)(num2 * 901186717);
					continue;
				}
				case 126u:
				{
					c3 = c5;
					int num31;
					int num32;
					if ((uint)c3 <= 102u)
					{
						num31 = 1325989334;
						num32 = 1325989334;
					}
					else
					{
						num31 = 306099377;
						num32 = 306099377;
					}
					num = num31 ^ (int)(num2 * 1034037843);
					continue;
				}
				case 125u:
				{
					int num16;
					if (c3 != 'n')
					{
						num = -1798491891;
						num16 = -1798491891;
					}
					else
					{
						num = -1053624494;
						num16 = -1053624494;
					}
					continue;
				}
				case 123u:
					num = ((int)num2 * -610646455) ^ -1162016581;
					continue;
				case 122u:
					num = ((int)num2 * -192794147) ^ 0x5BB1FC4;
					continue;
				case 121u:
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -1388606223) ^ -1761561074;
					continue;
				case 120u:
				{
					int num58;
					if (c != '}')
					{
						num = -686650750;
						num58 = -686650750;
					}
					else
					{
						num = -1677931498;
						num58 = -1677931498;
					}
					continue;
				}
				case 119u:
				{
					int num52;
					int num53;
					if (flag)
					{
						num52 = -292992310;
						num53 = -292992310;
					}
					else
					{
						num52 = -316417132;
						num53 = -316417132;
					}
					num = num52 ^ (int)(num2 * 1489585578);
					continue;
				}
				case 118u:
					switch (c3)
					{
					case 's':
						break;
					default:
						goto IL_02b9;
					case 'r':
						goto IL_02c3;
					case 't':
						goto IL_02d9;
					case 'u':
						goto IL_02ef;
					}
					goto case 136u;
				case 109u:
					goto IL_02c3;
				case 50u:
					goto IL_02d9;
				case 26u:
					goto IL_02ef;
				case 117u:
					num = ((int)num2 * -842021862) ^ -1397261809;
					continue;
				case 116u:
				{
					int num42;
					int num43;
					if (!flag)
					{
						num42 = -1000993085;
						num43 = -1000993085;
					}
					else
					{
						num42 = -1530582896;
						num43 = -1530582896;
					}
					num = num42 ^ ((int)num2 * -1879697769);
					continue;
				}
				case 115u:
					num = ((int)num2 * -375953594) ^ 0x1FCD6EE2;
					continue;
				case 114u:
					num = -2050350224;
					continue;
				case 113u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1842740542) ^ -1161792726;
					continue;
				case 112u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 2015042784) ^ -1929893580;
					continue;
				case 111u:
				{
					int num37;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1502031315;
						num37 = -1502031315;
					}
					else
					{
						num = -1297388387;
						num37 = -1297388387;
					}
					continue;
				}
				case 108u:
				{
					int num25;
					int num26;
					if (JSONNode.smethod_6(text, ""))
					{
						num25 = 895438753;
						num26 = 895438753;
					}
					else
					{
						num25 = 295677145;
						num26 = 295677145;
					}
					num = num25 ^ ((int)num2 * -1721766416);
					continue;
				}
				case 107u:
					num3++;
					num = -1617619087;
					continue;
				case 106u:
					num = ((int)num2 * -1824646913) ^ -1355231234;
					continue;
				case 105u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = -1863164550;
					continue;
				case 104u:
					stack.Push(new JSONClass());
					num = -927314823;
					continue;
				case 103u:
				{
					int num19;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = -94727731;
						num19 = -94727731;
					}
					else
					{
						num = -510448888;
						num19 = -510448888;
					}
					continue;
				}
				case 102u:
					num = ((int)num2 * -1903981003) ^ 0x7E233358;
					continue;
				case 101u:
				{
					int num14;
					if ((uint)c > 93u)
					{
						num = -412110250;
						num14 = -412110250;
					}
					else
					{
						num = -634834713;
						num14 = -634834713;
					}
					continue;
				}
				case 100u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = (int)(num2 * 512444353) ^ -427651823;
					continue;
				case 99u:
					text = "";
					num = ((int)num2 * -1548401286) ^ 0x601E2408;
					continue;
				case 98u:
					jSONNode.Add(text);
					num = ((int)num2 * -428356723) ^ -1542029993;
					continue;
				case 97u:
					text2 = text;
					num = -1849254251;
					continue;
				case 96u:
				{
					int num10;
					if (c == '"')
					{
						num = -2101497811;
						num10 = -2101497811;
					}
					else
					{
						num = -413276247;
						num10 = -413276247;
					}
					continue;
				}
				case 95u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					case '\v':
					case '\f':
						goto IL_0175;
					default:
						goto IL_0554;
					case '\t':
						goto IL_0567;
					}
					goto case 3u;
				case 17u:
					goto IL_0567;
				case 94u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1870325804) ^ -1617351835;
					continue;
				case 93u:
				{
					int num56;
					int num57;
					if (flag4)
					{
						num56 = -439695720;
						num57 = -439695720;
					}
					else
					{
						num56 = -1403422340;
						num57 = -1403422340;
					}
					num = num56 ^ ((int)num2 * -1628738400);
					continue;
				}
				case 92u:
					num = ((int)num2 * -1937441163) ^ 0x5001D69A;
					continue;
				case 91u:
					num = ((int)num2 * -28600820) ^ -646941206;
					continue;
				case 90u:
				{
					int num51;
					if (stack.Count == 0)
					{
						num = -1556463517;
						num51 = -1556463517;
					}
					else
					{
						num = -573068174;
						num51 = -573068174;
					}
					continue;
				}
				case 89u:
					num = ((int)num2 * -1225072169) ^ 0x7573A87;
					continue;
				case 88u:
					flag = false;
					num = ((int)num2 * -1608899734) ^ -1948517400;
					continue;
				case 87u:
					num = (int)((num2 * 740067397) ^ 0x7AE03E09);
					continue;
				case 86u:
				{
					c = c4;
					int num49;
					int num50;
					if ((uint)c <= 44u)
					{
						num49 = 446659453;
						num50 = 446659453;
					}
					else
					{
						num49 = 1603433382;
						num50 = 1603433382;
					}
					num = num49 ^ ((int)num2 * -1384638533);
					continue;
				}
				case 85u:
					num3 += 4;
					num = (int)((num2 * 1997057274) ^ 0x6A20AA39);
					continue;
				case 84u:
					flag8 = jSONNode is JSONArray;
					num = (int)(num2 * 867494361) ^ -9092814;
					continue;
				case 83u:
				{
					int num47;
					int num48;
					if (flag7)
					{
						num47 = 871751367;
						num48 = 871751367;
					}
					else
					{
						num47 = 251477383;
						num48 = 251477383;
					}
					num = num47 ^ ((int)num2 * -8866324);
					continue;
				}
				case 82u:
					goto IL_06e5;
				case 81u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 1037645538) ^ 0x24AAFA1D);
					continue;
				case 80u:
					num = ((int)num2 * -1693399151) ^ -287548474;
					continue;
				case 79u:
				{
					int num40;
					int num41;
					if (!flag3)
					{
						num40 = -1298745401;
						num41 = -1298745401;
					}
					else
					{
						num40 = -1562123456;
						num41 = -1562123456;
					}
					num = num40 ^ ((int)num2 * -1443942489);
					continue;
				}
				case 78u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1259359747) ^ -1504438462;
					continue;
				case 77u:
					text = JSONNode.smethod_3(text, "\n");
					num = -1828504437;
					continue;
				case 76u:
				{
					int num38;
					int num39;
					if (flag8)
					{
						num38 = -1403123974;
						num39 = -1403123974;
					}
					else
					{
						num38 = -373069709;
						num39 = -373069709;
					}
					num = num38 ^ (int)(num2 * 1627772937);
					continue;
				}
				case 75u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -803344429) ^ 0x2D7B7CCA;
					continue;
				case 74u:
					num = ((int)num2 * -1452429220) ^ -1125578822;
					continue;
				case 73u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num33;
					int num34;
					if (jSONNode is JSONArray)
					{
						num33 = -150129319;
						num34 = -150129319;
					}
					else
					{
						num33 = -1534398911;
						num34 = -1534398911;
					}
					num = num33 ^ ((int)num2 * -961342690);
					continue;
				}
				case 72u:
					text2 = "";
					num = ((int)num2 * -968985211) ^ 0x2353C13C;
					continue;
				case 71u:
					num = (int)((num2 * 500117806) ^ 0x1BF9BE65);
					continue;
				case 70u:
				{
					int num27;
					int num28;
					if (jSONNode != null)
					{
						num27 = 395622263;
						num28 = 395622263;
					}
					else
					{
						num27 = 1562558268;
						num28 = 1562558268;
					}
					num = num27 ^ ((int)num2 * -2005000733);
					continue;
				}
				case 69u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1857486472) ^ 0x4C5464C6;
					continue;
				case 68u:
					flag6 = num3 < JSONNode.smethod_4(aJSON);
					num = -380926561;
					continue;
				case 67u:
					result = jSONNode;
					num = -1982794389;
					continue;
				case 66u:
					num = (int)((num2 * 1161879661) ^ 0x3710A5F3);
					continue;
				case 65u:
					s = JSONNode.smethod_8(aJSON, num3 + 1, 4);
					num = ((int)num2 * -1023202972) ^ -729493376;
					continue;
				case 64u:
					num = ((int)num2 * -688333065) ^ 0x4E9EC8D9;
					continue;
				case 63u:
					flag5 = flag;
					num = -1521178944;
					continue;
				case 62u:
				{
					int num24;
					if (c != ',')
					{
						num = -910969980;
						num24 = -910969980;
					}
					else
					{
						num = -111251390;
						num24 = -111251390;
					}
					continue;
				}
				case 61u:
					num = (int)(num2 * 1216510878) ^ -2014670283;
					continue;
				case 59u:
					num = ((int)num2 * -237673832) ^ -1620247996;
					continue;
				case 58u:
					num = ((int)num2 * -123937281) ^ 0x5CE9BC12;
					continue;
				case 57u:
					num = ((int)num2 * -674405311) ^ 0x74C757C9;
					continue;
				case 56u:
					text2 = "";
					num = -96353074;
					continue;
				case 55u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -295346614) ^ -846683449;
					continue;
				case 54u:
				{
					int num23;
					if (flag)
					{
						num = -439956208;
						num23 = -439956208;
					}
					else
					{
						num = -505419922;
						num23 = -505419922;
					}
					continue;
				}
				case 52u:
					jSONNode.Add(text);
					num = ((int)num2 * -993264347) ^ -129752518;
					continue;
				case 51u:
					num = ((int)num2 * -1608466298) ^ 0x7EAEA494;
					continue;
				case 49u:
					num = ((int)num2 * -1906176780) ^ 0xDBCF57F;
					continue;
				case 48u:
					num = ((int)num2 * -1648168482) ^ -1759890964;
					continue;
				case 47u:
					num = (int)((num2 * 1744109492) ^ 0x1730D0D7);
					continue;
				case 46u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 1425603660) ^ -1547672753;
					continue;
				case 45u:
				{
					int num21;
					if (c3 == 'f')
					{
						num = -1899351673;
						num21 = -1899351673;
					}
					else
					{
						num = -1199838422;
						num21 = -1199838422;
					}
					continue;
				}
				case 44u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -188952385) ^ 0x613EFCA8;
					continue;
				case 43u:
					text = JSONNode.smethod_3(text, "\f");
					num = -1828504437;
					continue;
				case 42u:
					num = (int)(num2 * 564886203) ^ -940352708;
					continue;
				case 41u:
					text2 = "";
					text = "";
					num = -2115617193;
					continue;
				case 40u:
					num = (int)((num2 * 244339538) ^ 0x5E857C23);
					continue;
				case 39u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1828504437;
					continue;
				case 38u:
					num = -1358467232;
					continue;
				case 37u:
					num = (int)((num2 * 1061242218) ^ 0x58CF251);
					continue;
				case 36u:
				{
					int num17;
					int num18;
					if (jSONNode != null)
					{
						num17 = 940346367;
						num18 = 940346367;
					}
					else
					{
						num17 = 265855968;
						num18 = 265855968;
					}
					num = num17 ^ (int)(num2 * 736463124);
					continue;
				}
				case 35u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 1835973651) ^ 0xA9EB933);
					continue;
				case 34u:
					num = -94727731;
					continue;
				case 33u:
					num = ((int)num2 * -757023359) ^ -713800864;
					continue;
				case 31u:
				{
					int num15;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -1353180860;
						num15 = -1353180860;
					}
					else
					{
						num = -199758373;
						num15 = -199758373;
					}
					continue;
				}
				case 30u:
					num = ((int)num2 * -336582746) ^ 0x41FD483D;
					continue;
				case 29u:
					c4 = JSONNode.smethod_2(aJSON, num3);
					num = (int)(num2 * 1455829981) ^ -283847341;
					continue;
				case 28u:
					num = -1335082366;
					continue;
				case 27u:
					num = -514771703;
					continue;
				case 25u:
					num = ((int)num2 * -1425076205) ^ 0x15D6C752;
					continue;
				case 24u:
					num = (int)((num2 * 1610088859) ^ 0x6E5C720A);
					continue;
				case 23u:
					num = ((int)num2 * -1519403535) ^ 0x3069746F;
					continue;
				case 22u:
					goto IL_0c5f;
				case 21u:
				{
					int num11;
					int num12;
					if (c3 == 'b')
					{
						num11 = 1550680738;
						num12 = 1550680738;
					}
					else
					{
						num11 = 2059400463;
						num12 = 2059400463;
					}
					num = num11 ^ (int)(num2 * 1763842296);
					continue;
				}
				case 20u:
					num = -770502734;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 1111943067;
						num9 = 1111943067;
					}
					else
					{
						num8 = 512807598;
						num9 = 512807598;
					}
					num = num8 ^ ((int)num2 * -1065390401);
					continue;
				}
				case 18u:
					num = (int)((num2 * 1007970762) ^ 0x7BC7394);
					continue;
				case 16u:
					num3 = 0;
					text = "";
					num = (int)((num2 * 1409391231) ^ 0x57F7F11E);
					continue;
				case 15u:
				{
					int num7;
					if (c == ' ')
					{
						num = -1840697715;
						num7 = -1840697715;
					}
					else
					{
						num = -1006721805;
						num7 = -1006721805;
					}
					continue;
				}
				case 14u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -802506274) ^ 0x9A574B8;
					continue;
				case 13u:
					stack.Push(new JSONArray());
					num = -75190985;
					continue;
				case 12u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 593881818) ^ -1023891079;
					continue;
				case 11u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -1594753935;
					continue;
				case 10u:
					text2 = "";
					text = "";
					num = -1549490172;
					continue;
				case 9u:
					flag = !flag;
					num = -2115617193;
					continue;
				case 8u:
					num = (int)((num2 * 1384534148) ^ 0x536BBF3);
					continue;
				case 7u:
					stack.Pop();
					num = -1120227872;
					continue;
				case 6u:
					num = ((int)num2 * -503596877) ^ -567639022;
					continue;
				case 5u:
					switch (c)
					{
					case '\\':
						break;
					case '[':
						goto IL_06e5;
					case ']':
						goto IL_0c5f;
					default:
						goto IL_0e0d;
					}
					goto case 107u;
				case 4u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -699903201) ^ -1934131659;
					continue;
				case 2u:
					text = "";
					jSONNode = stack.Peek();
					num = (int)(num2 * 1661351465) ^ -661639664;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (c != ':')
					{
						num4 = -1344954144;
						num5 = -1344954144;
					}
					else
					{
						num4 = -62012527;
						num5 = -62012527;
					}
					num = num4 ^ (int)(num2 * 1890353360);
					continue;
				}
				case 0u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = ((int)num2 * -365152861) ^ -8769203;
					continue;
				case 140u:
					break;
				case 53u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 124u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0567:
					if (flag)
					{
						num = -1775840435;
						num6 = -1775840435;
					}
					else
					{
						num = -528090485;
						num6 = -528090485;
					}
					continue;
					IL_0e0d:
					num = -396556828;
					continue;
					IL_0554:
					num = ((int)num2 * -1852726302) ^ 0x48BA75CD;
					continue;
					IL_0c5f:
					if (!flag)
					{
						num = -1374242287;
						num13 = -1374242287;
					}
					else
					{
						num = -788926626;
						num13 = -788926626;
					}
					continue;
					IL_06e5:
					if (flag)
					{
						num = -1925688083;
						num46 = -1925688083;
					}
					else
					{
						num = -1813138913;
						num46 = -1813138913;
					}
					continue;
					IL_02ef:
					num = -1687276051;
					continue;
					IL_02c3:
					text = JSONNode.smethod_3(text, "\r");
					num = -1748906108;
					continue;
					IL_02b9:
					num = -1329237019;
					continue;
					IL_02d9:
					text = JSONNode.smethod_3(text, "\t");
					num = -2006000965;
					continue;
					IL_0175:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num3).ToString());
					num = -90917406;
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
			int num = 1630261432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x337DB429u) % 4u)
				{
				case 2u:
					Serialize(aWriter);
					num = (int)((num2 * 1608172097) ^ 0x43E13A2C);
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -739220060) ^ -802695105;
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
					int num = 653582592;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x6E5C666Du) % 4u)
						{
						case 2u:
							num = ((int)num2 * -1251036635) ^ 0x42B1E2B0;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)(num2 * 123526283) ^ -777471876;
							continue;
						default:
							goto end_IL_004d;
						case 0u:
							break;
						case 3u:
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
				int num = 438422757;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7404B990u) % 5u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -1108984525) ^ 0x56A610B9;
						continue;
					case 2u:
						num = ((int)num2 * -326242305) ^ 0x8712ABD;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -1707811780) ^ 0x71425F82;
						continue;
					case 0u:
						break;
					default:
						return result;
					case 4u:
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
					IL_00cc:
					int num3 = 1969661902;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x7404B990u) % 4u)
						{
						case 3u:
							num3 = (int)((num2 * 1497913996) ^ 0x1EA624B5);
							continue;
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -979233987) ^ 0x5FF07185;
							continue;
						default:
							goto end_IL_00ab;
						case 0u:
							break;
						case 1u:
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
		JSONBinaryTag jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
		JSONBinaryTag jSONBinaryTag2 = jSONBinaryTag;
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num10 = default(int);
		string aKey = default(string);
		bool flag2 = default(bool);
		int num5 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num6 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = -865913553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF616751u) % 38u)
				{
				case 37u:
					num = ((int)num2 * -351871181) ^ 0x481510C9;
					continue;
				case 36u:
					num = ((int)num2 * -267761216) ^ 0x529E5614;
					continue;
				case 35u:
					result = jSONClass;
					num = (int)(num2 * 1669384109) ^ -1501124822;
					continue;
				case 34u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Array:
						goto IL_0082;
					case JSONBinaryTag.Class:
						goto IL_008c;
					case JSONBinaryTag.Value:
						goto IL_009e;
					case JSONBinaryTag.IntValue:
						goto IL_00a8;
					case JSONBinaryTag.DoubleValue:
						goto IL_00bf;
					case JSONBinaryTag.BoolValue:
						goto IL_00d6;
					case JSONBinaryTag.FloatValue:
						goto IL_00ed;
					}
					num = (int)((num2 * 309410960) ^ 0x54E11AD3);
					continue;
				case 5u:
					goto IL_0082;
				case 33u:
					goto IL_008c;
				case 13u:
					goto IL_009e;
				case 14u:
					goto IL_00a8;
				case 29u:
					goto IL_00bf;
				case 21u:
					goto IL_00d6;
				case 19u:
					goto IL_00ed;
				case 32u:
					num10++;
					num = (int)(num2 * 279464992) ^ -449398796;
					continue;
				case 30u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1643420584) ^ 0x5C69FB0;
					continue;
				}
				case 28u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 150564217) ^ 0x16104D79);
					continue;
				case 27u:
					jSONClass = new JSONClass();
					num10 = 0;
					num = (int)(num2 * 256623448) ^ -298231620;
					continue;
				case 26u:
					num = (int)((num2 * 1919584266) ^ 0x3F278A0);
					continue;
				case 25u:
					flag2 = num10 < num5;
					num = -585808937;
					continue;
				case 24u:
					num = ((int)num2 * -1705635899) ^ -303987264;
					continue;
				case 23u:
					result = jSONArray;
					num = ((int)num2 * -700376646) ^ 0xC5DFCEA;
					continue;
				case 22u:
					num6++;
					num = (int)((num2 * 1399694817) ^ 0x57C7A2C0);
					continue;
				case 20u:
					num6 = 0;
					num = (int)((num2 * 1142411797) ^ 0x1D73EBFB);
					continue;
				case 17u:
					num = -1998902613;
					continue;
				case 16u:
					num = (int)((num2 * 2097544413) ^ 0x2D12E250);
					continue;
				case 12u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -309154484;
						num9 = -309154484;
					}
					else
					{
						num8 = -1957586328;
						num9 = -1957586328;
					}
					num = num8 ^ ((int)num2 * -1298407117);
					continue;
				}
				case 11u:
					num = -1399026651;
					continue;
				case 10u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)(num2 * 584219667) ^ -1486827781;
					continue;
				case 9u:
					num7 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = (int)((num2 * 931664007) ^ 0x7828253E);
					continue;
				case 8u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -589514674) ^ 0xA4F17B6;
					continue;
				case 7u:
					flag = num6 < num7;
					num = -318548547;
					continue;
				case 6u:
					jSONArray.Add(Deserialize(aReader));
					num = -893167813;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1650060594;
						num4 = -1650060594;
					}
					else
					{
						num3 = -1525948617;
						num4 = -1525948617;
					}
					num = num3 ^ (int)(num2 * 1134677999);
					continue;
				}
				case 3u:
					num = ((int)num2 * -248914342) ^ -701423827;
					continue;
				case 2u:
					aKey = JSONNode.smethod_22(aReader);
					num = ((int)num2 * -161955824) ^ -46829967;
					continue;
				case 1u:
					num = (int)(num2 * 994639205) ^ -255044057;
					continue;
				case 0u:
					num = ((int)num2 * -258025303) ^ -422543554;
					continue;
				case 15u:
					break;
				case 18u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_008c:
					num5 = JSONNode.smethod_21(aReader);
					num = -985529998;
					continue;
					IL_0082:
					num = -1892629762;
					continue;
					IL_009e:
					num = -283378003;
					continue;
					IL_00ed:
					num = -310713819;
					continue;
					IL_00d6:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1804358123;
					continue;
					IL_00bf:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -101295980;
					continue;
					IL_00a8:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -101295980;
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
				int num = -63521343;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB072C4C8u) % 3u)
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
					num = (int)((num2 * 1947222436) ^ 0x43543265);
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
					int num3 = -1100305404;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xB072C4C8u) % 3u)
						{
						case 1u:
							goto IL_0049;
						default:
							goto end_IL_005c;
						case 2u:
							break;
						case 0u:
							goto end_IL_005c;
						}
						goto IL_0079;
						IL_0049:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = ((int)num2 * -228135291) ^ 0x1F0EFCC0;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 316552382;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7F798C41u) % 3u)
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
					num = ((int)num2 * -63960923) ^ -1701678412;
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
					int num3 = 369470782;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x7F798C41u) % 3u)
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
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)(num2 * 1898010468) ^ -1247378413;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 582065666;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F5A4A07u) % 7u)
				{
				case 6u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -36817396) ^ -693127785;
					continue;
				case 5u:
					num = (int)((num2 * 1675910972) ^ 0x238CCE6B);
					continue;
				case 4u:
					num = (int)((num2 * 962263077) ^ 0x662FF44);
					continue;
				case 1u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 52148309) ^ 0x741075D8);
					continue;
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -803864638) ^ 0x359EC6A9;
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
