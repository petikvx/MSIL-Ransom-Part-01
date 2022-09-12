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
				int num = -2108993498;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFDB713FDu) % 3u)
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
					num = ((int)num2 * -210357407) ^ 0x251466FB;
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
				int num = -2135241412;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFC66C08u) % 3u)
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
					num = (int)(num2 * 1375275858) ^ -1628248239;
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
				int num = -21389709;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8A9DAB58u) % 4u)
					{
					case 3u:
						result = "";
						num = (int)((num2 * 1363711018) ^ 0x25621EEC);
						continue;
					case 2u:
						num = (int)(num2 * 1818774309) ^ -1902641701;
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

	public virtual int Count
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 1388258296;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11D2A38Bu) % 4u)
					{
					case 3u:
						result = 0;
						num = ((int)num2 * -120915917) ^ 0x5AD0B9D4;
						continue;
					case 2u:
						num = (int)((num2 * 1319467133) ^ 0x5D97B2C0);
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
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -228523982;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA86123DFu) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -1484466399) ^ 0xDD40863;
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
				int num = 72098263;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA8C20Eu) % 3u)
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
					num = (int)((num2 * 1609292590) ^ 0x3524ABA3);
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result = 0;
			bool flag = default(bool);
			int result2 = default(int);
			while (true)
			{
				int num = -1645769274;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF101572Au) % 8u)
					{
					case 7u:
						num = (int)(num2 * 1876788378) ^ -1802707730;
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 258663095;
							num4 = 258663095;
						}
						else
						{
							num3 = 2120525867;
							num4 = 2120525867;
						}
						num = num3 ^ ((int)num2 * -1697379622);
						continue;
					}
					case 5u:
						result2 = 0;
						num = -835081739;
						continue;
					case 4u:
						flag = int.TryParse(Value, out result);
						num = (int)(num2 * 1462057284) ^ -359952572;
						continue;
					case 3u:
						num = (int)((num2 * 51129823) ^ 0x30CD0F45);
						continue;
					case 1u:
						result2 = result;
						num = (int)((num2 * 1443141865) ^ 0x6F8AAEC0);
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
				int num = 1383291833;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72EF852Fu) % 3u)
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
					num = (int)((num2 * 1383444170) ^ 0x755EE693);
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
				int num = -1151752123;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB7BC7C2Au) % 7u)
					{
					case 6u:
						result2 = result;
						num = (int)((num2 * 2079570212) ^ 0x650F35B1);
						continue;
					case 4u:
						result2 = 0f;
						num = -1056591931;
						continue;
					case 2u:
						num = ((int)num2 * -1951903828) ^ -1358451903;
						continue;
					case 1u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
						num = (int)((num2 * 1668859997) ^ 0x3A1BFC3);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1386424454;
							num4 = 1386424454;
						}
						else
						{
							num3 = 413431305;
							num4 = 413431305;
						}
						num = num3 ^ (int)(num2 * 517606589);
						continue;
					}
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
				int num = 1377764405;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7E991E48u) % 3u)
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
					num = (int)((num2 * 1198384853) ^ 0x580250B);
				}
			}
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
				int num = -671007955;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC13949C0u) % 8u)
					{
					case 7u:
						result2 = result;
						num = (int)(num2 * 1851874256) ^ -855418885;
						continue;
					case 6u:
						result2 = 0.0;
						num = -198720238;
						continue;
					case 5u:
						flag = double.TryParse(Value, out result);
						num = (int)(num2 * 1266870885) ^ -1453128456;
						continue;
					case 3u:
						num = (int)((num2 * 1111911237) ^ 0x77F9B5BF);
						continue;
					case 2u:
						num = (int)(num2 * 10738073) ^ -1676366390;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2031258029;
							num4 = -2031258029;
						}
						else
						{
							num3 = -1990292414;
							num4 = -1990292414;
						}
						num = num3 ^ (int)(num2 * 1856297861);
						continue;
					}
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
				int num = 2028919720;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x275B3727u) % 3u)
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
					num = (int)(num2 * 411562105) ^ -511121822;
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
			while (true)
			{
				int num = 1628753101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EE2928Au) % 6u)
					{
					case 5u:
						result = result2;
						num = (int)((num2 * 2105620143) ^ 0x6A7A55F8);
						continue;
					case 2u:
						result = !JSONNode.smethod_1(Value);
						num = 795288959;
						continue;
					case 1u:
						result2 = false;
						num = ((int)num2 * -2111365335) ^ 0xF84BA85;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = 1801481020;
							num4 = 1801481020;
						}
						else
						{
							num3 = 1792624835;
							num4 = 1792624835;
						}
						num = num3 ^ ((int)num2 * -1168986394);
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
				int num = 1500747890;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x66966F37u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -754846028) ^ 0x1F1F6D61;
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = 542176968;
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
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 158773510;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3DFB0BE8u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -888052539) ^ 0x71F544AA;
						continue;
					case 2u:
						result = this as JSONArray;
						num = (int)(num2 * 1525643639) ^ -937851779;
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
				int num = 1221937468;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4F0C5EBu) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = ((int)num2 * -1401076886) ^ -562969643;
						continue;
					case 0u:
						num = ((int)num2 * -781048202) ^ -1555336794;
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
			int num = 978421015;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53424D8Fu) % 3u)
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
				num = (int)((num2 * 1294015679) ^ 0xDE3EC3E);
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -1101811941;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4284EF8u) % 3u)
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
				num = (int)(num2 * 1881835545) ^ -869368897;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 115977760;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2620C649u) % 3u)
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
				result = aNode;
				num = ((int)num2 * -87201779) ^ -905592626;
			}
		}
	}

	public override string ToString()
	{
		string result = "JSONNode";
		while (true)
		{
			int num = 1099307442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67C00B30u) % 3u)
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
				num = (int)(num2 * 334874428) ^ -1429097158;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1365660031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61585AC2u) % 4u)
				{
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -517177681) ^ -659089927;
					continue;
				case 0u:
					num = (int)(num2 * 1140902220) ^ -674066167;
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
			int num = 1096163298;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A04EACBu) % 3u)
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
				num = ((int)num2 * -1923607374) ^ 0x52780046;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -1333439072;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xDF729655u) % 4u)
				{
				case 1u:
					if (!(d == null))
					{
						num = ((int)num2 * -202107924) ^ 0x365C885;
						continue;
					}
					obj = null;
					goto IL_001c;
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
					num = -1498929798;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 2016148804;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x4B505ECAu) % 7u)
				{
				case 6u:
					if (b == null)
					{
						num = (int)(num2 * 1680733744) ^ -98121301;
						continue;
					}
					goto IL_001b;
				case 5u:
					result = (object)a == b;
					num = 1410139673;
					continue;
				case 4u:
					if (a is JSONLazyCreator)
					{
						num = 1313930254;
						num3 = 1313930254;
						continue;
					}
					goto IL_001b;
				case 3u:
					num = (int)(num2 * 1789722772) ^ -1041239633;
					continue;
				case 2u:
					result = true;
					num = ((int)num2 * -2005749688) ^ 0x343D2F73;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001b:
					num = 1397981485;
					num3 = 1397981485;
					continue;
				}
				break;
			}
		}
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
			int num = 2025077804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5502B495u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -93472086) ^ -1895966591;
					continue;
				case 1u:
					result = (object)this == obj;
					num = (int)(num2 * 1023146457) ^ -1273431326;
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
			int num = -1055608399;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC83360E7u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 786925464) ^ -1712839766;
					continue;
				case 2u:
					result = this.method_0();
					num = (int)((num2 * 885633632) ^ 0x49A0E20);
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
		string text = "";
		string result = default(string);
		char c2 = default(char);
		string string_ = default(string);
		int num3 = default(int);
		char c3 = default(char);
		char c = default(char);
		while (true)
		{
			int num = -692595861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96D494A7u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -2025671887) ^ 0x337A77EA;
					continue;
				case 28u:
					text = JSONNode.smethod_3(text, "\\f");
					num = -908042564;
					continue;
				case 27u:
					num = ((int)num2 * -1818419907) ^ -1132949897;
					continue;
				case 26u:
					goto IL_0047;
				case 25u:
					num = (int)((num2 * 1043323020) ^ 0x119CA798);
					continue;
				case 24u:
					result = text;
					num = ((int)num2 * -1623689073) ^ 0xF1BA771;
					continue;
				case 23u:
				{
					int num6;
					if (c2 == '"')
					{
						num = -2123856219;
						num6 = -2123856219;
					}
					else
					{
						num = -440082234;
						num6 = -440082234;
					}
					continue;
				}
				case 22u:
					num = ((int)num2 * -217666608) ^ -1329028652;
					continue;
				case 20u:
					num = ((int)num2 * -1650757100) ^ 0x2962B2D4;
					continue;
				case 19u:
					goto IL_00ce;
				case 18u:
					string_ = aText;
					num = ((int)num2 * -367595084) ^ -1627803586;
					continue;
				case 17u:
					num = (int)((num2 * 1211825927) ^ 0x716998E7);
					continue;
				case 16u:
					goto IL_010c;
				case 15u:
					num3 = 0;
					num = (int)(num2 * 896427210) ^ -1700271975;
					continue;
				case 14u:
					c3 = c;
					num = (int)(num2 * 1523330060) ^ -1671401192;
					continue;
				case 13u:
					num3++;
					num = -1283346109;
					continue;
				case 12u:
				{
					int num5;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -230416561;
						num5 = -230416561;
					}
					else
					{
						num = -483143757;
						num5 = -483143757;
					}
					continue;
				}
				case 11u:
					c2 = c3;
					switch (c2)
					{
					case '\f':
						break;
					case '\b':
						goto IL_0047;
					case '\t':
						goto IL_00ce;
					case '\r':
						goto IL_010c;
					default:
						goto IL_01a5;
					case '\n':
						goto IL_01b8;
					case '\v':
						goto IL_01ce;
					}
					goto case 28u;
				case 10u:
					goto IL_01b8;
				case 3u:
					goto IL_01ce;
				case 9u:
					num = ((int)num2 * -1002558722) ^ 0x6B2154AE;
					continue;
				case 8u:
				{
					int num4;
					if (c2 != '\\')
					{
						num = -1769849816;
						num4 = -1769849816;
					}
					else
					{
						num = -588011310;
						num4 = -588011310;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -615279520) ^ -1088449110;
					continue;
				case 6u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -465556538;
					continue;
				case 5u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -596573244;
					continue;
				case 2u:
					num = ((int)num2 * -646676575) ^ -275574095;
					continue;
				case 1u:
					num = (int)((num2 * 139471619) ^ 0x263DC1C5);
					continue;
				case 0u:
					c = JSONNode.smethod_2(string_, num3);
					num = -1213816023;
					continue;
				case 21u:
					break;
				default:
					{
						return result;
					}
					IL_01ce:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -633526636;
					continue;
					IL_01b8:
					text = JSONNode.smethod_3(text, "\\n");
					num = -802066653;
					continue;
					IL_01a5:
					num = (int)((num2 * 1730537160) ^ 0x3D022F58);
					continue;
					IL_0047:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1856818825;
					continue;
					IL_010c:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1848153454;
					continue;
					IL_00ce:
					text = JSONNode.smethod_3(text, "\\t");
					num = -633526636;
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
		bool flag9 = default(bool);
		string text2 = default(string);
		bool flag5 = default(bool);
		int num4 = default(int);
		char c = default(char);
		string text = default(string);
		bool flag8 = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		bool flag11 = default(bool);
		char c4 = default(char);
		bool flag4 = default(bool);
		JSONNode result = default(JSONNode);
		char c2 = default(char);
		bool flag12 = default(bool);
		bool flag2 = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		char c3 = default(char);
		bool flag7 = default(bool);
		while (true)
		{
			int num = -2001600467;
			while (true)
			{
				uint num2;
				int num45;
				int num58;
				switch ((num2 = (uint)num ^ 0xB2A81401u) % 151u)
				{
				case 150u:
					flag9 = JSONNode.smethod_6(text2, "");
					num = -708849079;
					continue;
				case 149u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1597108250) ^ 0x34B4E396;
					continue;
				case 148u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1512568695) ^ -18764219;
					continue;
				case 147u:
					num = ((int)num2 * -1923621385) ^ 0x32FD1A66;
					continue;
				case 146u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -1663914359) ^ 0x114CD7BD;
					continue;
				case 145u:
				{
					int num12;
					int num13;
					if (flag5)
					{
						num12 = 1631921580;
						num13 = 1631921580;
					}
					else
					{
						num12 = 310137471;
						num13 = 310137471;
					}
					num = num12 ^ (int)(num2 * 1747409660);
					continue;
				}
				case 17u:
				case 37u:
				case 75u:
				case 109u:
				case 144u:
					num4++;
					num = -1027758695;
					continue;
				case 143u:
					num = (int)((num2 * 122745009) ^ 0x7091BBA2);
					continue;
				case 142u:
					num = (int)((num2 * 340034237) ^ 0x96A6A1A);
					continue;
				case 141u:
				{
					int num51;
					int num52;
					if (jSONNode != null)
					{
						num51 = 816985809;
						num52 = 816985809;
					}
					else
					{
						num51 = 1283711964;
						num52 = 1283711964;
					}
					num = num51 ^ ((int)num2 * -448239031);
					continue;
				}
				case 140u:
					num = ((int)num2 * -1848553961) ^ 0x787402AE;
					continue;
				case 139u:
					num = (int)(num2 * 885429569) ^ -1520807891;
					continue;
				case 138u:
					switch (c)
					{
					case 'r':
						goto IL_0169;
					case 's':
						goto IL_017f;
					case 't':
						goto IL_0197;
					case 'u':
						goto IL_01ad;
					}
					num = -1464187583;
					continue;
				case 27u:
					goto IL_0169;
				case 55u:
					goto IL_017f;
				case 93u:
					goto IL_0197;
				case 12u:
					goto IL_01ad;
				case 137u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)((num2 * 94597098) ^ 0x631F7EB);
					continue;
				case 136u:
					num = ((int)num2 * -497042894) ^ 0x3CF0C29A;
					continue;
				case 135u:
					num = (int)(num2 * 317983557) ^ -1811125999;
					continue;
				case 134u:
					num = (int)(num2 * 119662646) ^ -1117805494;
					continue;
				case 133u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1762249409) ^ -393953003;
					continue;
				case 132u:
					num4++;
					flag8 = flag;
					num = -306414457;
					continue;
				case 131u:
					num = (int)(num2 * 745225459) ^ -1730535584;
					continue;
				case 130u:
				{
					int num15;
					int num16;
					if (flag6)
					{
						num15 = -2035687680;
						num16 = -2035687680;
					}
					else
					{
						num15 = -14391711;
						num16 = -14391711;
					}
					num = num15 ^ ((int)num2 * -554065626);
					continue;
				}
				case 129u:
				{
					int num59;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -1399459314;
						num59 = -1399459314;
					}
					else
					{
						num = -935530606;
						num59 = -935530606;
					}
					continue;
				}
				case 128u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -530489596) ^ -294879412;
					continue;
				case 127u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 2030076150) ^ -955133389;
					continue;
				case 126u:
				{
					int num54;
					int num55;
					if (!flag)
					{
						num54 = 1137813133;
						num55 = 1137813133;
					}
					else
					{
						num54 = 154777344;
						num55 = 154777344;
					}
					num = num54 ^ ((int)num2 * -1029569556);
					continue;
				}
				case 125u:
					text = JSONNode.smethod_3(text, "\b");
					num = -34117533;
					continue;
				case 124u:
				{
					int num47;
					int num48;
					if (flag11)
					{
						num47 = -491066175;
						num48 = -491066175;
					}
					else
					{
						num47 = -353985159;
						num48 = -353985159;
					}
					num = num47 ^ ((int)num2 * -1162941604);
					continue;
				}
				case 123u:
					switch (c4)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_038a;
					case '\t':
						goto IL_039d;
					case '\v':
					case '\f':
						goto IL_03bd;
					}
					goto case 17u;
				case 113u:
					goto IL_039d;
				case 45u:
					goto IL_03bd;
				case 122u:
					stack.Push(new JSONClass());
					num = -340929834;
					continue;
				case 121u:
					flag11 = JSONNode.smethod_6(text, "");
					num = (int)((num2 * 1726880747) ^ 0x4E12BBC);
					continue;
				case 120u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num37;
					int num38;
					if (!(jSONNode is JSONArray))
					{
						num37 = 1416112730;
						num38 = 1416112730;
					}
					else
					{
						num37 = 650778204;
						num38 = 650778204;
					}
					num = num37 ^ (int)(num2 * 251105391);
					continue;
				}
				case 119u:
				{
					int num32;
					int num33;
					if (c == 'b')
					{
						num32 = -1897151802;
						num33 = -1897151802;
					}
					else
					{
						num32 = -61371264;
						num33 = -61371264;
					}
					num = num32 ^ ((int)num2 * -691422493);
					continue;
				}
				case 118u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1331233701) ^ 0x5642FA3A;
					continue;
				case 117u:
					text = "";
					num = (int)(num2 * 1273041067) ^ -1534579309;
					continue;
				case 115u:
					num4 += 4;
					num = (int)(num2 * 1839717223) ^ -1866948948;
					continue;
				case 114u:
					text = "";
					num = (int)((num2 * 331328595) ^ 0x734B801D);
					continue;
				case 112u:
					num = -851236919;
					continue;
				case 111u:
					text = JSONNode.smethod_3(text, "\f");
					num = -306195477;
					continue;
				case 110u:
					num = (int)(num2 * 1525469563) ^ -1373719596;
					continue;
				case 108u:
					jSONNode.Add(text);
					num = (int)(num2 * 419376770) ^ -1526578519;
					continue;
				case 107u:
				{
					int num23;
					int num24;
					if (flag9)
					{
						num23 = 1037812676;
						num24 = 1037812676;
					}
					else
					{
						num23 = 85979382;
						num24 = 85979382;
					}
					num = num23 ^ ((int)num2 * -1062880098);
					continue;
				}
				case 105u:
					text2 = "";
					num = -1816007953;
					continue;
				case 104u:
				{
					int num18;
					int num19;
					if (c4 != ':')
					{
						num18 = 845567194;
						num19 = 845567194;
					}
					else
					{
						num18 = 2132923797;
						num19 = 2132923797;
					}
					num = num18 ^ (int)(num2 * 1364176447);
					continue;
				}
				case 103u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = 451551528;
						num11 = 451551528;
					}
					else
					{
						num10 = 193321098;
						num11 = 193321098;
					}
					num = num10 ^ (int)(num2 * 1252759695);
					continue;
				}
				case 102u:
					num = ((int)num2 * -1409547018) ^ 0x4401FDD2;
					continue;
				case 101u:
					num = ((int)num2 * -1539920773) ^ 0xBF030F7;
					continue;
				case 100u:
					stack.Pop();
					num = -55503270;
					continue;
				case 99u:
					result = jSONNode;
					num = -1336027498;
					continue;
				case 98u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 1436070291) ^ -609982565;
					continue;
				case 97u:
					num = (int)((num2 * 12595558) ^ 0x6DF9F33A);
					continue;
				case 96u:
				{
					int num60;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1099049515;
						num60 = -1099049515;
					}
					else
					{
						num = -1635951395;
						num60 = -1635951395;
					}
					continue;
				}
				case 95u:
					switch (c4)
					{
					case '\\':
						break;
					default:
						goto IL_0682;
					case '[':
						goto IL_068c;
					case ']':
						goto IL_06ac;
					}
					goto case 132u;
				case 28u:
					goto IL_068c;
				case 9u:
					goto IL_06ac;
				case 94u:
				{
					int num57;
					if (c != 'f')
					{
						num = -1393614017;
						num57 = -1393614017;
					}
					else
					{
						num = -924813528;
						num57 = -924813528;
					}
					continue;
				}
				case 92u:
				{
					int num56;
					if (c4 != '}')
					{
						num = -1246072345;
						num56 = -1246072345;
					}
					else
					{
						num = -2015511639;
						num56 = -2015511639;
					}
					continue;
				}
				case 91u:
				{
					int num53;
					if (c4 != ',')
					{
						num = -1268015501;
						num53 = -1268015501;
					}
					else
					{
						num = -485642261;
						num53 = -485642261;
					}
					continue;
				}
				case 89u:
				{
					int num49;
					int num50;
					if (!flag8)
					{
						num49 = -1053976755;
						num50 = -1053976755;
					}
					else
					{
						num49 = -2042003679;
						num50 = -2042003679;
					}
					num = num49 ^ ((int)num2 * -1267577709);
					continue;
				}
				case 88u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -836158208;
					continue;
				case 87u:
					stack.Push(new JSONArray());
					num = -470147850;
					continue;
				case 86u:
					num = (int)(num2 * 411104680) ^ -429574629;
					continue;
				case 85u:
					flag4 = jSONNode is JSONArray;
					num = ((int)num2 * -1600222617) ^ 0x3D157F16;
					continue;
				case 84u:
					num = (int)((num2 * 508262653) ^ 0x48512B40);
					continue;
				case 83u:
				{
					int num46;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1896172111;
						num46 = -1896172111;
					}
					else
					{
						num = -300290165;
						num46 = -300290165;
					}
					continue;
				}
				case 82u:
					num = (int)((num2 * 711697450) ^ 0x7CD8C27C);
					continue;
				case 81u:
					num = -998744990;
					continue;
				case 80u:
					flag5 = flag;
					num = -1633880737;
					continue;
				case 79u:
					text2 = "";
					text = "";
					flag6 = stack.Count > 0;
					num = -978476282;
					continue;
				case 78u:
					num = (int)(num2 * 1368127563) ^ -785890661;
					continue;
				case 77u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1125270285) ^ 0x51592E4);
					continue;
				case 76u:
					num = (int)(num2 * 183440803) ^ -1986889540;
					continue;
				case 74u:
					num = (int)((num2 * 1637345390) ^ 0x767F5114);
					continue;
				case 73u:
					text = "";
					jSONNode = stack.Peek();
					num = (int)((num2 * 1967163176) ^ 0x10E69A99);
					continue;
				case 72u:
					num = -334415949;
					continue;
				case 71u:
					num = ((int)num2 * -557989597) ^ 0x2D30F84E;
					continue;
				case 70u:
					c2 = JSONNode.smethod_2(aJSON, num4);
					num = ((int)num2 * -63795653) ^ -790210273;
					continue;
				case 69u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num43;
					int num44;
					if (!(jSONNode is JSONArray))
					{
						num43 = -336465273;
						num44 = -336465273;
					}
					else
					{
						num43 = -795850457;
						num44 = -795850457;
					}
					num = num43 ^ (int)(num2 * 1954177783);
					continue;
				}
				case 68u:
				{
					int num41;
					int num42;
					if (flag12)
					{
						num41 = 141762227;
						num42 = 141762227;
					}
					else
					{
						num41 = 1106914063;
						num42 = 1106914063;
					}
					num = num41 ^ (int)(num2 * 705808077);
					continue;
				}
				case 67u:
					num = -955122951;
					continue;
				case 66u:
					num = ((int)num2 * -254131919) ^ -188924077;
					continue;
				case 65u:
				{
					int num39;
					int num40;
					if (!flag2)
					{
						num39 = -1164644836;
						num40 = -1164644836;
					}
					else
					{
						num39 = -1237526134;
						num40 = -1237526134;
					}
					num = num39 ^ ((int)num2 * -1627241193);
					continue;
				}
				case 64u:
					num = ((int)num2 * -1612684882) ^ 0x7E8B6A5C;
					continue;
				case 63u:
					flag10 = flag;
					num = -1680220309;
					continue;
				case 62u:
					num = ((int)num2 * -546605537) ^ 0xAD35F6B;
					continue;
				case 61u:
					text2 = "";
					num = (int)(num2 * 554708146) ^ -1195752711;
					continue;
				case 60u:
					num = ((int)num2 * -1275415167) ^ -1387692039;
					continue;
				case 59u:
					num = ((int)num2 * -1040743701) ^ 0x65382972;
					continue;
				case 58u:
				{
					int num36;
					if ((uint)c4 > 93u)
					{
						num = -330209945;
						num36 = -330209945;
					}
					else
					{
						num = -580102532;
						num36 = -580102532;
					}
					continue;
				}
				case 57u:
				{
					int num34;
					int num35;
					if (!flag10)
					{
						num34 = 1849232150;
						num35 = 1849232150;
					}
					else
					{
						num34 = 1297050640;
						num35 = 1297050640;
					}
					num = num34 ^ ((int)num2 * -2070912195);
					continue;
				}
				case 56u:
					flag = false;
					num = (int)((num2 * 1186207483) ^ 0x9034E20);
					continue;
				case 54u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 517810767) ^ 0x173CAAE0);
					continue;
				case 53u:
					num = ((int)num2 * -1242020682) ^ -180019137;
					continue;
				case 52u:
					jSONNode.Add(text);
					num = ((int)num2 * -1148510774) ^ -1537238701;
					continue;
				case 51u:
				{
					int num30;
					int num31;
					if ((uint)c4 > 32u)
					{
						num30 = 712693223;
						num31 = 712693223;
					}
					else
					{
						num30 = 440235997;
						num31 = 440235997;
					}
					num = num30 ^ ((int)num2 * -1893586023);
					continue;
				}
				case 50u:
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -190831063) ^ -894959588;
					continue;
				case 49u:
					num = ((int)num2 * -1650915004) ^ 0xE423085;
					continue;
				case 48u:
					num = ((int)num2 * -608550572) ^ -63752566;
					continue;
				case 47u:
					text2 = text;
					num = -2091654620;
					continue;
				case 46u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num4);
					c4 = c5;
					num = ((int)num2 * -740236638) ^ -1392889119;
					continue;
				}
				case 44u:
					num = ((int)num2 * -1496096528) ^ 0x17A1B562;
					continue;
				case 43u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)(num2 * 1002175072) ^ -1440549897;
					continue;
				case 42u:
				{
					int num29;
					if (c4 != '{')
					{
						num = -1303046284;
						num29 = -1303046284;
					}
					else
					{
						num = -1764964256;
						num29 = -1764964256;
					}
					continue;
				}
				case 41u:
				{
					c = c3;
					int num27;
					int num28;
					if ((uint)c <= 102u)
					{
						num27 = 1065707410;
						num28 = 1065707410;
					}
					else
					{
						num27 = 868074317;
						num28 = 868074317;
					}
					num = num27 ^ (int)(num2 * 737240852);
					continue;
				}
				case 40u:
					num = ((int)num2 * -1119428916) ^ -191055029;
					continue;
				case 39u:
					num = ((int)num2 * -1532840209) ^ 0x149D2A66;
					continue;
				case 38u:
					num = (int)(num2 * 1650749445) ^ -1000130996;
					continue;
				case 36u:
					num = (int)(num2 * 695315593) ^ -1613724788;
					continue;
				case 35u:
				{
					int num25;
					int num26;
					if (flag7)
					{
						num25 = 1442444584;
						num26 = 1442444584;
					}
					else
					{
						num25 = 200118041;
						num26 = 200118041;
					}
					num = num25 ^ (int)(num2 * 108471850);
					continue;
				}
				case 34u:
					num = -935530606;
					continue;
				case 32u:
					num = ((int)num2 * -395418030) ^ 0x2FE8FEA3;
					continue;
				case 31u:
					num4 = 0;
					num = ((int)num2 * -393093644) ^ -1350635150;
					continue;
				case 30u:
				{
					int num22;
					if (c4 != ' ')
					{
						num = -1050242304;
						num22 = -1050242304;
					}
					else
					{
						num = -882409048;
						num22 = -882409048;
					}
					continue;
				}
				case 29u:
				{
					string s = JSONNode.smethod_8(aJSON, num4 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)(num2 * 237351760) ^ -100212376;
					continue;
				}
				case 26u:
					num = ((int)num2 * -771702322) ^ -296002525;
					continue;
				case 25u:
				{
					int num20;
					int num21;
					if (jSONNode != null)
					{
						num20 = 1183729656;
						num21 = 1183729656;
					}
					else
					{
						num20 = 797264922;
						num21 = 797264922;
					}
					num = num20 ^ (int)(num2 * 517787294);
					continue;
				}
				case 24u:
				{
					int num17;
					if (stack.Count == 0)
					{
						num = -1260930984;
						num17 = -1260930984;
					}
					else
					{
						num = -711082;
						num17 = -711082;
					}
					continue;
				}
				case 23u:
					num = ((int)num2 * -694025342) ^ 0x62EE89BF;
					continue;
				case 22u:
					num = ((int)num2 * -1711828892) ^ -321366574;
					continue;
				case 21u:
					text2 = "";
					text = "";
					num = -978192440;
					continue;
				case 20u:
					num = ((int)num2 * -893475965) ^ 0x3B25829B;
					continue;
				case 19u:
					flag7 = num4 < JSONNode.smethod_4(aJSON);
					num = -1401947439;
					continue;
				case 18u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1051623733) ^ -344348615;
					continue;
				case 16u:
				{
					int num14;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1097830503;
						num14 = -1097830503;
					}
					else
					{
						num = -286015682;
						num14 = -286015682;
					}
					continue;
				}
				case 15u:
				{
					int num8;
					int num9;
					if ((uint)c4 > 44u)
					{
						num8 = 1917420120;
						num9 = 1917420120;
					}
					else
					{
						num8 = 1539971851;
						num9 = 1539971851;
					}
					num = num8 ^ ((int)num2 * -1844923435);
					continue;
				}
				case 14u:
					text = JSONNode.smethod_3(text, "\n");
					num = -475297073;
					continue;
				case 13u:
					num = (int)(num2 * 1762648451) ^ -1628308928;
					continue;
				case 11u:
				{
					int num7;
					if (c4 != '"')
					{
						num = -873770036;
						num7 = -873770036;
					}
					else
					{
						num = -1949955819;
						num7 = -1949955819;
					}
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 2970097;
						num6 = 2970097;
					}
					else
					{
						num5 = 434072480;
						num6 = 434072480;
					}
					num = num5 ^ (int)(num2 * 1235009549);
					continue;
				}
				case 8u:
					c3 = c2;
					num = (int)(num2 * 1664760511) ^ -40067128;
					continue;
				case 7u:
					num = ((int)num2 * -1365925984) ^ -1689058949;
					continue;
				case 6u:
					num = (int)((num2 * 956038986) ^ 0x6CFB5E78);
					continue;
				case 5u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1663086674) ^ -2136377185;
					continue;
				case 4u:
					flag = !flag;
					num = -514242651;
					continue;
				case 3u:
				{
					int num3;
					if (c != 'n')
					{
						num = -1718151508;
						num3 = -1718151508;
					}
					else
					{
						num = -1645325653;
						num3 = -1645325653;
					}
					continue;
				}
				case 2u:
					flag2 = flag;
					num = -49525816;
					continue;
				case 1u:
					num = (int)(num2 * 1345267344) ^ -1929748428;
					continue;
				case 0u:
					num = -1438229569;
					continue;
				case 116u:
					break;
				case 33u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 106u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0197:
					text = JSONNode.smethod_3(text, "\t");
					num = -34117533;
					continue;
					IL_01ad:
					num = -1084066714;
					continue;
					IL_017f:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -330671374;
					continue;
					IL_03bd:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = -188967132;
					continue;
					IL_0169:
					text = JSONNode.smethod_3(text, "\r");
					num = -731878863;
					continue;
					IL_039d:
					if (flag)
					{
						num = -948280947;
						num45 = -948280947;
					}
					else
					{
						num = -804297986;
						num45 = -804297986;
					}
					continue;
					IL_038a:
					num = (int)((num2 * 1600824237) ^ 0x76A4F875);
					continue;
					IL_06ac:
					flag12 = flag;
					num = -61712109;
					continue;
					IL_068c:
					if (flag)
					{
						num = -135459695;
						num58 = -135459695;
					}
					else
					{
						num = -1326442301;
						num58 = -1326442301;
					}
					continue;
					IL_0682:
					num = -1882479762;
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
				int num = -587472565;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFC77AD3Eu) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1002730153) ^ -1178414217;
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = (int)((num2 * 1594641772) ^ 0x8F96F95);
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
					IL_00a2:
					int num3 = -1182198864;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xFC77AD3Eu) % 3u)
						{
						case 1u:
							goto IL_0072;
						default:
							goto end_IL_0085;
						case 2u:
							break;
						case 0u:
							goto end_IL_0085;
						}
						goto IL_00a2;
						IL_0072:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)(num2 * 894235726) ^ -249467166;
						continue;
						end_IL_0085:
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
				int num = -2106418339;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xED006CD8u) % 6u)
					{
					case 5u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -357582543) ^ -1471821408;
						continue;
					case 3u:
						num = (int)((num2 * 2040337156) ^ 0x20D21AB6);
						continue;
					case 2u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 1716023572) ^ 0x2D55719);
						continue;
					case 1u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)(num2 * 493781295) ^ -313974191;
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
					IL_00cf:
					int num3 = -331418288;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xED006CD8u) % 3u)
						{
						case 1u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 2u:
							break;
						case 0u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -803179430) ^ -328993138;
						continue;
						end_IL_00b2:
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
		int num7 = default(int);
		int num6 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num3 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		int num4 = default(int);
		while (true)
		{
			int num = -886676702;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC12D5D6Du) % 34u)
				{
				case 33u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)((num2 * 391218238) ^ 0x80636EA);
					continue;
				case 32u:
					num = (int)((num2 * 882580763) ^ 0x43F2EE31);
					continue;
				case 31u:
					num = ((int)num2 * -1594962960) ^ 0x98038A3;
					continue;
				case 29u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1873193876;
						num9 = -1873193876;
					}
					else
					{
						num8 = -1751830816;
						num9 = -1751830816;
					}
					num = num8 ^ (int)(num2 * 865304047);
					continue;
				}
				case 28u:
					num7 = JSONNode.smethod_21(aReader);
					num = -935587547;
					continue;
				case 27u:
					num = ((int)num2 * -729411853) ^ -2022342984;
					continue;
				case 26u:
					num = (int)((num2 * 1304754265) ^ 0x5A100882);
					continue;
				case 25u:
					goto IL_00ac;
				case 23u:
					flag = num6 < num7;
					num = -2076215648;
					continue;
				case 22u:
					num = -292958077;
					continue;
				case 21u:
					jSONClass = new JSONClass();
					num3 = 0;
					num = ((int)num2 * -1827068825) ^ -2145241782;
					continue;
				case 20u:
					switch (jSONBinaryTag)
					{
					case JSONBinaryTag.Array:
						break;
					case JSONBinaryTag.DoubleValue:
						goto IL_00ac;
					default:
						goto IL_0116;
					case JSONBinaryTag.Class:
						goto IL_0129;
					case JSONBinaryTag.Value:
						goto IL_013b;
					case JSONBinaryTag.IntValue:
						goto IL_0152;
					case JSONBinaryTag.BoolValue:
						goto IL_0169;
					case JSONBinaryTag.FloatValue:
						goto IL_0180;
					}
					goto case 28u;
				case 13u:
					goto IL_0129;
				case 6u:
					goto IL_013b;
				case 3u:
					goto IL_0152;
				case 14u:
					goto IL_0169;
				case 1u:
					goto IL_0180;
				case 19u:
					num = (int)((num2 * 1973492569) ^ 0x3F01BB52);
					continue;
				case 18u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = -903430628;
					continue;
				case 17u:
					num = ((int)num2 * -76504730) ^ -1693306751;
					continue;
				case 16u:
					num3++;
					num = (int)(num2 * 187832600) ^ -1592631845;
					continue;
				case 15u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -731282487) ^ -1207866729;
					continue;
				case 11u:
					num = ((int)num2 * -2048420252) ^ -125768299;
					continue;
				case 10u:
					num = (int)(num2 * 220128850) ^ -1361105509;
					continue;
				case 9u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -1641886276) ^ -1456504521;
					continue;
				case 8u:
					result = jSONArray;
					num = ((int)num2 * -869905497) ^ -1099634617;
					continue;
				case 7u:
					result = jSONClass;
					num = ((int)num2 * -2044875266) ^ 0x5931261;
					continue;
				case 5u:
					jSONClass.Add(aKey, aItem);
					num = (int)((num2 * 886502157) ^ 0xFD90719);
					continue;
				case 4u:
					jSONArray = new JSONArray();
					num6 = 0;
					num = ((int)num2 * -697022435) ^ 0x2DA4E751;
					continue;
				case 2u:
					jSONArray.Add(Deserialize(aReader));
					num6++;
					num = -1375462282;
					continue;
				case 0u:
				{
					int num5;
					if (num3 < num4)
					{
						num = -243945545;
						num5 = -243945545;
					}
					else
					{
						num = -126936010;
						num5 = -126936010;
					}
					continue;
				}
				case 24u:
					break;
				case 12u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0180:
					num = -1392002866;
					continue;
					IL_0169:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -41536098;
					continue;
					IL_0152:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -1081175213;
					continue;
					IL_013b:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1081175213;
					continue;
					IL_0129:
					num4 = JSONNode.smethod_21(aReader);
					num = -1673746310;
					continue;
					IL_0116:
					num = ((int)num2 * -1674602593) ^ -1565508864;
					continue;
					IL_00ac:
					num = -337974780;
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
				int num = 188163579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2BA05A62u) % 3u)
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
					num = (int)(num2 * 1992149444) ^ -1025448003;
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
					int num3 = 759841655;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x2BA05A62u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)(num2 * 240932685) ^ -909916621;
							continue;
						case 0u:
							num3 = ((int)num2 * -771627445) ^ 0x7E3DCAE4;
							continue;
						default:
							goto end_IL_006b;
						case 3u:
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
					int num = 2129160476;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x7D3EB5F6u) % 3u)
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
						num = ((int)num2 * -827753883) ^ 0x6F14DC1E;
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
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = 2083788338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA3F72u) % 6u)
				{
				case 4u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)((num2 * 1244629396) ^ 0x31EB78F6);
					continue;
				case 3u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1412600249) ^ -1923141461;
					continue;
				case 2u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1690657406) ^ 0x50E6661;
					continue;
				case 1u:
					num = (int)((num2 * 1809920516) ^ 0x2B90807B);
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

	public JSONNode()
	{
		while (true)
		{
			int num = -261086039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA2A40CFu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1697794350) ^ -743032319;
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
