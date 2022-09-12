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
				int num = 593437607;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A483A1Eu) % 3u)
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
					num = ((int)num2 * -1640331579) ^ -1014233315;
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
				int num = 1832657339;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B301DA6u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -806085516) ^ 0x71F955FA;
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -1061250340) ^ -1041983596;
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
			string result = "";
			while (true)
			{
				int num = -2089708821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD9E47D3Du) % 3u)
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
					num = (int)(num2 * 399183650) ^ -2019724327;
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
				int num = -2138085266;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81090F45u) % 4u)
					{
					case 3u:
						result = 0;
						num = ((int)num2 * -1316264743) ^ 0x4916F75A;
						continue;
					case 0u:
						num = ((int)num2 * -907818073) ^ 0x163084F0;
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
				int num = 1448331022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x13BD5283u) % 4u)
					{
					case 2u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -2130090866) ^ 0x495F9BFF;
						continue;
					case 1u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)((num2 * 1811602455) ^ 0x17EA85E);
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

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1664675505;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4D08C0Du) % 3u)
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
					_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
					result = _003Cget_DeepChilds_003Ed__;
					num = ((int)num2 * -1795059353) ^ -1432258516;
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result = default(int);
			int result2 = default(int);
			while (true)
			{
				int num = 17882463;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x70234046u) % 6u)
					{
					case 3u:
						num = (int)((num2 * 1552241303) ^ 0x3CF332C2);
						continue;
					case 2u:
						result = result2;
						num = (int)(num2 * 717757947) ^ -1879678041;
						continue;
					case 1u:
					{
						result2 = 0;
						int num3;
						int num4;
						if (int.TryParse(Value, out result2))
						{
							num3 = 748752465;
							num4 = 748752465;
						}
						else
						{
							num3 = 1463425829;
							num4 = 1463425829;
						}
						num = num3 ^ (int)(num2 * 1669430139);
						continue;
					}
					case 0u:
						result = 0;
						num = 1015350441;
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
				int num = 529951306;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6CBE1519u) % 4u)
					{
					case 3u:
						Value = value.ToString();
						num = (int)(num2 * 1488617015) ^ -864232124;
						continue;
					case 0u:
						num = (int)(num2 * 1130317427) ^ -1841124088;
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
				int num = -1979700157;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD453F3F8u) % 7u)
					{
					case 6u:
						num = ((int)num2 * -1773141671) ^ -1458589876;
						continue;
					case 4u:
						result2 = 0f;
						num = -1711509572;
						continue;
					case 3u:
						num = (int)(num2 * 921708474) ^ -645871706;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1963524837;
							num4 = 1963524837;
						}
						else
						{
							num3 = 1495428022;
							num4 = 1495428022;
						}
						num = num3 ^ (int)(num2 * 1437789642);
						continue;
					}
					case 1u:
						result2 = result;
						num = (int)(num2 * 2082890424) ^ -1513839957;
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
				int num = -1807273184;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9137B8EFu) % 4u)
					{
					case 3u:
						Value = value.ToString();
						num = (int)((num2 * 482297007) ^ 0x1F8016E3);
						continue;
					case 1u:
						num = (int)((num2 * 1750555722) ^ 0x54626BEF);
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

	public virtual double AsDouble
	{
		get
		{
			double result = 0.0;
			bool flag = double.TryParse(Value, out result);
			double result2 = default(double);
			while (true)
			{
				int num = -1778375135;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x87C1F47Du) % 7u)
					{
					case 6u:
						result2 = result;
						num = ((int)num2 * -423729745) ^ -219315254;
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1775984399;
							num4 = -1775984399;
						}
						else
						{
							num3 = -1130205349;
							num4 = -1130205349;
						}
						num = num3 ^ (int)(num2 * 685194784);
						continue;
					}
					case 3u:
						num = (int)((num2 * 1137172436) ^ 0x6EE3CF49);
						continue;
					case 2u:
						result2 = 0.0;
						num = -1383180625;
						continue;
					case 1u:
						num = (int)((num2 * 712269852) ^ 0x22F43D75);
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

	public virtual bool AsBool
	{
		get
		{
			bool result = default(bool);
			bool flag = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -2066630739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA3FBC686u) % 8u)
					{
					case 7u:
						result = !JSONNode.smethod_1(Value);
						num = -1130259824;
						continue;
					case 6u:
						num = (int)((num2 * 528612466) ^ 0x765F6218);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -378094662;
							num4 = -378094662;
						}
						else
						{
							num3 = -129944711;
							num4 = -129944711;
						}
						num = num3 ^ ((int)num2 * -511244809);
						continue;
					}
					case 4u:
						result = result2;
						num = (int)(num2 * 1309087956) ^ -1008458737;
						continue;
					case 3u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = (int)((num2 * 1722182808) ^ 0x79DDEAFB);
						continue;
					case 1u:
						num = (int)((num2 * 2015523679) ^ 0x37232373);
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
				int num = 737573117;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x67C2D173) % 3u)
					{
					case 1u:
						value2 = (value ? "true" : "false");
						goto IL_0013;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0013:
					Value = value2;
					num = 2142363306;
				}
			}
		}
	}

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = this as JSONArray;
			while (true)
			{
				int num = 649618257;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x740FCC0Cu) % 3u)
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
					num = (int)(num2 * 828697539) ^ -1799566423;
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
				int num = -41297413;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA7CECD02u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 1336476330) ^ -94327984;
						continue;
					case 1u:
						result = this as JSONClass;
						num = (int)(num2 * 580140370) ^ -517140169;
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
		while (true)
		{
			int num = -869028166;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDBBAD9Au) % 3u)
				{
				case 2u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000e:
				num = ((int)num2 * -485559733) ^ -239804681;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = null;
		while (true)
		{
			int num = 618138340;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39B568FFu) % 3u)
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
				num = (int)((num2 * 2065925604) ^ 0x525C86A4);
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -198028095;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD3D74582u) % 3u)
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
				num = (int)(num2 * 1024940391) ^ -2096247250;
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
			int num = -198417988;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x981B624Du) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1025690454) ^ -195774887;
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)(num2 * 1094239402) ^ -729687159;
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

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1135110876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB3A5B75u) % 3u)
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
				num = ((int)num2 * -859649409) ^ 0x7F0B900;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1403600066;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x78396489u) % 4u)
				{
				case 3u:
					result = new JSONData(s);
					num = ((int)num2 * -1124936179) ^ 0x2859BA93;
					continue;
				case 1u:
					num = ((int)num2 * -918114571) ^ -102378922;
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

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 58177210;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x47F963AFu) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = ((int)num2 * -814142196) ^ 0x24D5D0AF;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 3u:
					obj = d.Value;
					goto IL_001c;
				case 1u:
					num = ((int)num2 * -1842778692) ^ -1923279704;
					continue;
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_001c:
					result = (string)obj;
					num = 1144794765;
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
			int num = 436685988;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x9089A78u) % 7u)
				{
				case 6u:
					num5 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_000f;
				case 5u:
					if (b == null)
					{
						num = (int)((num2 * 1364461002) ^ 0x38CA81F8);
						continue;
					}
					num5 = 0;
					goto IL_000f;
				case 4u:
					result = (object)a == b;
					num = 2131272033;
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -1148778571) ^ 0x71EBB3AD;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 350223090;
						num4 = 350223090;
					}
					else
					{
						num3 = 1444481820;
						num4 = 1444481820;
					}
					num = num3 ^ (int)(num2 * 562725897);
					continue;
				}
				case 0u:
					break;
				default:
					{
						return result;
					}
					IL_000f:
					flag = (byte)num5 != 0;
					num = 350126784;
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
			int num = -771510740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E03C1E0u) % 3u)
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
				num = ((int)num2 * -1914093697) ^ 0x5794FD04;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 327978029;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3307A105u) % 3u)
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
				result = (object)this == obj;
				num = (int)(num2 * 676361595) ^ -1745431163;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = 1386983885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A750DEAu) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = ((int)num2 * -639857506) ^ -994334412;
					continue;
				case 0u:
					num = (int)((num2 * 1123380448) ^ 0x2FF7B183);
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
		string text = default(string);
		char c3 = default(char);
		int num3 = default(int);
		string string_ = default(string);
		string result = default(string);
		char c = default(char);
		while (true)
		{
			int num = -1777803549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84CF5BB2u) % 30u)
				{
				case 28u:
					num = ((int)num2 * -35113298) ^ 0x7D6B2A27;
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -724601535;
					continue;
				case 26u:
					num = (int)((num2 * 1499825622) ^ 0x799C5413);
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -892252300;
					continue;
				case 24u:
					num = (int)((num2 * 1451217967) ^ 0x68951427);
					continue;
				case 23u:
				{
					int num6;
					if (c3 == '"')
					{
						num = -1358530769;
						num6 = -1358530769;
					}
					else
					{
						num = -1867058118;
						num6 = -1867058118;
					}
					continue;
				}
				case 22u:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1886228585;
					continue;
				case 21u:
					num = ((int)num2 * -1554946946) ^ 0x3F7E897F;
					continue;
				case 20u:
					num = (int)((num2 * 1341876580) ^ 0x4D281333);
					continue;
				case 19u:
				{
					int num5;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -603149496;
						num5 = -603149496;
					}
					else
					{
						num = -2047803560;
						num5 = -2047803560;
					}
					continue;
				}
				case 18u:
					goto IL_00ee;
				case 17u:
				{
					int num4;
					if (c3 != '\\')
					{
						num = -1028039402;
						num4 = -1028039402;
					}
					else
					{
						num = -1193795685;
						num4 = -1193795685;
					}
					continue;
				}
				case 16u:
					num3++;
					num = (int)((num2 * 1473488628) ^ 0x587FF595);
					continue;
				case 15u:
					goto IL_013d;
				case 14u:
					goto IL_0155;
				case 13u:
					num = -1333417542;
					continue;
				case 12u:
					result = text;
					num = (int)(num2 * 610466971) ^ -2009533417;
					continue;
				case 11u:
					text = "";
					num = ((int)num2 * -593092504) ^ 0x3E73D7A1;
					continue;
				case 10u:
					switch (c3)
					{
					case '\t':
						break;
					case '\f':
						goto IL_00ee;
					case '\v':
						goto IL_013d;
					case '\r':
						goto IL_0155;
					default:
						goto IL_01c5;
					case '\b':
						goto IL_01d8;
					case '\n':
						goto IL_01ee;
					}
					goto case 22u;
				case 0u:
					goto IL_01d8;
				case 4u:
					goto IL_01ee;
				case 9u:
					num = (int)(num2 * 1133833656) ^ -427369921;
					continue;
				case 8u:
					c = JSONNode.smethod_2(string_, num3);
					num = -1392606548;
					continue;
				case 7u:
				{
					char c2 = c;
					c3 = c2;
					num = ((int)num2 * -2062425504) ^ -773731268;
					continue;
				}
				case 6u:
					num = (int)((num2 * 1198964939) ^ 0x7BE631D1);
					continue;
				case 3u:
					string_ = aText;
					num3 = 0;
					num = ((int)num2 * -1710480669) ^ -446027100;
					continue;
				case 2u:
					num = (int)(num2 * 904793340) ^ -2016128289;
					continue;
				case 1u:
					num = (int)((num2 * 1164306445) ^ 0x4FC0362E);
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_01ee:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1886228585;
					continue;
					IL_01d8:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1886228585;
					continue;
					IL_01c5:
					num = ((int)num2 * -1226057029) ^ -932655232;
					continue;
					IL_0155:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1886228585;
					continue;
					IL_013d:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -1218037534;
					continue;
					IL_00ee:
					text = JSONNode.smethod_3(text, "\\f");
					num = -76129553;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		string text2 = default(string);
		int num11 = default(int);
		string text = default(string);
		bool flag6 = default(bool);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		JSONNode jSONNode = default(JSONNode);
		bool flag5 = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		char c = default(char);
		char c5 = default(char);
		bool flag9 = default(bool);
		char c2 = default(char);
		bool flag10 = default(bool);
		char c3 = default(char);
		bool flag = default(bool);
		bool flag4 = default(bool);
		string s = default(string);
		bool flag8 = default(bool);
		bool flag2 = default(bool);
		bool flag11 = default(bool);
		bool flag7 = default(bool);
		bool flag3 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1416444819;
			while (true)
			{
				uint num2;
				int num50;
				switch ((num2 = (uint)num ^ 0xD953E960u) % 154u)
				{
				case 153u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = -470711067;
					continue;
				case 152u:
					text = "";
					text2 = "";
					flag6 = stack.Count > 0;
					num = -1135346379;
					continue;
				case 151u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = -1223992007;
					continue;
				case 150u:
					num = (int)(num2 * 1010002338) ^ -769976859;
					continue;
				case 149u:
				{
					int num23;
					int num24;
					if (!(jSONNode is JSONArray))
					{
						num23 = 1972915523;
						num24 = 1972915523;
					}
					else
					{
						num23 = 1026035144;
						num24 = 1026035144;
					}
					num = num23 ^ ((int)num2 * -212457002);
					continue;
				}
				case 148u:
					num = ((int)num2 * -1710140455) ^ 0x3AB8841D;
					continue;
				case 147u:
					flag5 = stack.Count == 0;
					num = -945168371;
					continue;
				case 146u:
				{
					int num37;
					int num38;
					if (!flag13)
					{
						num37 = -783539068;
						num38 = -783539068;
					}
					else
					{
						num37 = -998180513;
						num38 = -998180513;
					}
					num = num37 ^ ((int)num2 * -1590480593);
					continue;
				}
				case 145u:
					flag12 = JSONNode.smethod_6(text, "");
					num = -1584377513;
					continue;
				case 144u:
				{
					int num7;
					int num8;
					if (c != ':')
					{
						num7 = -458906325;
						num8 = -458906325;
					}
					else
					{
						num7 = -1141510879;
						num8 = -1141510879;
					}
					num = num7 ^ (int)(num2 * 872993481);
					continue;
				}
				case 143u:
					num = ((int)num2 * -1675359162) ^ -1569748247;
					continue;
				case 142u:
					num = (int)((num2 * 707483151) ^ 0x64025CAB);
					continue;
				case 141u:
					c = c5;
					num = (int)(num2 * 2138451807) ^ -581778550;
					continue;
				case 140u:
					num = (int)(num2 * 825945680) ^ -604373364;
					continue;
				case 139u:
					num = (int)((num2 * 208755768) ^ 0x32319735);
					continue;
				case 138u:
					switch (c)
					{
					case '\v':
					case '\f':
						break;
					default:
						goto IL_01b7;
					case '\t':
						goto IL_01ca;
					case '\n':
					case '\r':
						goto IL_01d8;
					}
					goto case 153u;
				case 29u:
					goto IL_01ca;
				case 8u:
				case 24u:
				case 59u:
				case 67u:
				case 108u:
					goto IL_01d8;
				case 137u:
				{
					int num47;
					int num48;
					if (jSONNode is JSONArray)
					{
						num47 = -1367652696;
						num48 = -1367652696;
					}
					else
					{
						num47 = -268301548;
						num48 = -268301548;
					}
					num = num47 ^ ((int)num2 * -497361727);
					continue;
				}
				case 136u:
				{
					int num30;
					int num31;
					if (!flag9)
					{
						num30 = -312407579;
						num31 = -312407579;
					}
					else
					{
						num30 = -526675224;
						num31 = -526675224;
					}
					num = num30 ^ (int)(num2 * 1115277148);
					continue;
				}
				case 135u:
					jSONNode.Add(text2);
					num = (int)(num2 * 177657696) ^ -1163961399;
					continue;
				case 134u:
				{
					int num17;
					int num18;
					if (c2 == 'b')
					{
						num17 = -515589198;
						num18 = -515589198;
					}
					else
					{
						num17 = -1613227735;
						num18 = -1613227735;
					}
					num = num17 ^ (int)(num2 * 830935114);
					continue;
				}
				case 133u:
				{
					int num59;
					int num60;
					if (flag6)
					{
						num59 = -1902074523;
						num60 = -1902074523;
					}
					else
					{
						num59 = -779948903;
						num60 = -779948903;
					}
					num = num59 ^ (int)(num2 * 1404225679);
					continue;
				}
				case 132u:
				{
					text = JSONNode.smethod_5(text);
					int num55;
					int num56;
					if (!(jSONNode is JSONArray))
					{
						num55 = 282680408;
						num56 = 282680408;
					}
					else
					{
						num55 = 498289215;
						num56 = 498289215;
					}
					num = num55 ^ (int)(num2 * 1019013191);
					continue;
				}
				case 131u:
					text2 = "";
					num = (int)((num2 * 316201757) ^ 0x3E7FD709);
					continue;
				case 130u:
				{
					int num51;
					if (c2 != 'n')
					{
						num = -1061705679;
						num51 = -1061705679;
					}
					else
					{
						num = -702142103;
						num51 = -702142103;
					}
					continue;
				}
				case 129u:
				{
					int num45;
					int num46;
					if ((uint)c <= 44u)
					{
						num45 = -1931755894;
						num46 = -1931755894;
					}
					else
					{
						num45 = -390630655;
						num46 = -390630655;
					}
					num = num45 ^ (int)(num2 * 187725934);
					continue;
				}
				case 127u:
					num = ((int)num2 * -560881764) ^ 0x149C8FFC;
					continue;
				case 126u:
				{
					int num41;
					int num42;
					if (jSONNode != null)
					{
						num41 = 1441318918;
						num42 = 1441318918;
					}
					else
					{
						num41 = 1213827248;
						num42 = 1213827248;
					}
					num = num41 ^ ((int)num2 * -977120710);
					continue;
				}
				case 125u:
				{
					int num33;
					int num34;
					if (flag10)
					{
						num33 = 1111312789;
						num34 = 1111312789;
					}
					else
					{
						num33 = 1593243666;
						num34 = 1593243666;
					}
					num = num33 ^ (int)(num2 * 1071824694);
					continue;
				}
				case 124u:
					text = "";
					num = -716710337;
					continue;
				case 123u:
					text2 = JSONNode.smethod_3(text2, c3.ToString());
					num = -1223992007;
					continue;
				case 122u:
					num = (int)((num2 * 764195392) ^ 0x3C5F951B);
					continue;
				case 121u:
				{
					int num27;
					if (c != '}')
					{
						num = -192777388;
						num27 = -192777388;
					}
					else
					{
						num = -943107974;
						num27 = -943107974;
					}
					continue;
				}
				case 120u:
				{
					int num25;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1733117024;
						num25 = -1733117024;
					}
					else
					{
						num = -1039055193;
						num25 = -1039055193;
					}
					continue;
				}
				case 119u:
					goto IL_0442;
				case 118u:
					flag = JSONNode.smethod_6(text, "");
					num = -634273860;
					continue;
				case 117u:
				{
					int num16;
					if (flag4)
					{
						num = -1492085042;
						num16 = -1492085042;
					}
					else
					{
						num = -938283940;
						num16 = -938283940;
					}
					continue;
				}
				case 116u:
					num = ((int)num2 * -1829443351) ^ -423622783;
					continue;
				case 115u:
					text2 = "";
					num = (int)(num2 * 1474839964) ^ -460523559;
					continue;
				case 114u:
					num = ((int)num2 * -1473023728) ^ -251916999;
					continue;
				case 113u:
					num = -326772424;
					continue;
				case 112u:
					num = (int)((num2 * 1328184173) ^ 0x4EA4612E);
					continue;
				case 111u:
					jSONNode.Add(text, stack.Peek());
					num = ((int)num2 * -1831205507) ^ 0x4103062A;
					continue;
				case 110u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num11 += 4;
					num = (int)((num2 * 829653940) ^ 0x992589F);
					continue;
				case 107u:
				{
					int num6;
					if (c2 != 'f')
					{
						num = -1821380774;
						num6 = -1821380774;
					}
					else
					{
						num = -894125933;
						num6 = -894125933;
					}
					continue;
				}
				case 106u:
					num = (int)((num2 * 48007972) ^ 0x3EFF7A6E);
					continue;
				case 105u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 463142374) ^ 0x10466D50);
					continue;
				case 104u:
					num = (int)(num2 * 1330753225) ^ -1313995431;
					continue;
				case 103u:
					num = -1039055193;
					continue;
				case 102u:
				{
					int num58;
					if (c == ' ')
					{
						num = -1700291585;
						num58 = -1700291585;
					}
					else
					{
						num = -1734906664;
						num58 = -1734906664;
					}
					continue;
				}
				case 101u:
					num = -1451082404;
					continue;
				case 100u:
					num = -174456916;
					continue;
				case 99u:
					switch (c2)
					{
					case 's':
						break;
					case 'r':
						goto IL_0442;
					default:
						goto IL_05fd;
					case 't':
						goto IL_0607;
					case 'u':
						goto IL_061d;
					}
					goto case 123u;
				case 98u:
					goto IL_0607;
				case 21u:
					goto IL_061d;
				case 97u:
					num = (int)(num2 * 420756851) ^ -754356528;
					continue;
				case 96u:
					stack.Push(new JSONClass());
					num = -151953932;
					continue;
				case 95u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -2103428068) ^ 0xBED5019;
					continue;
				case 94u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 1509572947) ^ -261507053;
					continue;
				case 93u:
					flag8 = jSONNode is JSONArray;
					num = (int)((num2 * 884708854) ^ 0x40773511);
					continue;
				case 92u:
					num = (int)(num2 * 438086694) ^ -2053990755;
					continue;
				case 91u:
					jSONNode = null;
					num = (int)((num2 * 85969733) ^ 0x54201116);
					continue;
				case 90u:
					flag13 = flag4;
					num = -28802422;
					continue;
				case 89u:
					text2 = "";
					jSONNode = stack.Peek();
					num = ((int)num2 * -1025441237) ^ -1148775725;
					continue;
				case 88u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -187519320) ^ 0x1E5B99CD;
					continue;
				case 87u:
				{
					int num57;
					if (c != '{')
					{
						num = -1997069028;
						num57 = -1997069028;
					}
					else
					{
						num = -585131540;
						num57 = -585131540;
					}
					continue;
				}
				case 86u:
					num = ((int)num2 * -578106144) ^ 0x20D80C51;
					continue;
				case 85u:
					num = ((int)num2 * -928956641) ^ -1443296586;
					continue;
				case 84u:
				{
					int num53;
					int num54;
					if ((uint)c2 > 102u)
					{
						num53 = 1582732114;
						num54 = 1582732114;
					}
					else
					{
						num53 = 899898510;
						num54 = 899898510;
					}
					num = num53 ^ (int)(num2 * 1471436350);
					continue;
				}
				case 83u:
				{
					int num52;
					if (num11 >= JSONNode.smethod_4(aJSON))
					{
						num = -362977490;
						num52 = -362977490;
					}
					else
					{
						num = -1805033548;
						num52 = -1805033548;
					}
					continue;
				}
				case 82u:
					goto IL_07c2;
				case 81u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)((num2 * 1846258864) ^ 0x6D141757);
					continue;
				case 80u:
					num = ((int)num2 * -2013348399) ^ -290612868;
					continue;
				case 79u:
				{
					int num49;
					if (flag4)
					{
						num = -1234141603;
						num49 = -1234141603;
					}
					else
					{
						num = -1656324768;
						num49 = -1656324768;
					}
					continue;
				}
				case 78u:
					num = ((int)num2 * -178316823) ^ 0x4C786C45;
					continue;
				case 77u:
					num = ((int)num2 * -672336238) ^ 0x8B3B870;
					continue;
				case 76u:
					text = "";
					flag4 = false;
					num = ((int)num2 * -794139587) ^ 0x3C1020F1;
					continue;
				case 75u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = -1643074490;
					continue;
				case 74u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 152174619) ^ -20733885;
					continue;
				case 73u:
					flag2 = JSONNode.smethod_6(text, "");
					num = -492082750;
					continue;
				case 72u:
					num = ((int)num2 * -798247983) ^ 0x94EC74F;
					continue;
				case 71u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)((num2 * 1636437306) ^ 0x5B7FDBA6);
					continue;
				case 70u:
					flag4 = !flag4;
					num = -1391751710;
					continue;
				case 69u:
				{
					int num43;
					int num44;
					if (flag12)
					{
						num43 = -822387474;
						num44 = -822387474;
					}
					else
					{
						num43 = -966606641;
						num44 = -966606641;
					}
					num = num43 ^ ((int)num2 * -944185582);
					continue;
				}
				case 68u:
					goto IL_0948;
				case 66u:
				{
					int num39;
					int num40;
					if ((uint)c > 32u)
					{
						num39 = 385788364;
						num40 = 385788364;
					}
					else
					{
						num39 = 1327296948;
						num40 = 1327296948;
					}
					num = num39 ^ ((int)num2 * -1543729719);
					continue;
				}
				case 65u:
					num = ((int)num2 * -173903726) ^ 0x6124F4F7;
					continue;
				case 64u:
					s = JSONNode.smethod_8(aJSON, num11 + 1, 4);
					num = ((int)num2 * -1551704857) ^ 0x248F897C;
					continue;
				case 63u:
					num = (int)((num2 * 1584840978) ^ 0x4436A85);
					continue;
				case 62u:
				{
					int num35;
					int num36;
					if (flag11)
					{
						num35 = -697430664;
						num36 = -697430664;
					}
					else
					{
						num35 = -1702135924;
						num36 = -1702135924;
					}
					num = num35 ^ ((int)num2 * -637141594);
					continue;
				}
				case 61u:
					text = JSONNode.smethod_5(text);
					num = (int)(num2 * 843847777) ^ -1434487450;
					continue;
				case 60u:
					flag11 = flag4;
					num = (int)(num2 * 934631242) ^ -1532366686;
					continue;
				case 58u:
				{
					int num32;
					if (!flag4)
					{
						num = -1136678094;
						num32 = -1136678094;
					}
					else
					{
						num = -1707274553;
						num32 = -1707274553;
					}
					continue;
				}
				case 57u:
					num = -1998504971;
					continue;
				case 56u:
					num = (int)(num2 * 1656920468) ^ -1919197734;
					continue;
				case 55u:
					num = (int)((num2 * 304149656) ^ 0x578F7A4A);
					continue;
				case 54u:
					num = (int)(num2 * 477128338) ^ -1587868457;
					continue;
				case 52u:
					stack.Push(new JSONArray());
					flag9 = jSONNode != null;
					num = -688658820;
					continue;
				case 51u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -1699151720) ^ 0x2A1385CE;
					continue;
				case 50u:
					jSONNode.Add(text, text2);
					num = (int)((num2 * 1332789126) ^ 0x7835F35B);
					continue;
				case 49u:
					num = (int)((num2 * 1590788955) ^ 0x7C77D562);
					continue;
				case 48u:
					num = -1678798702;
					continue;
				case 47u:
					text = "";
					num = -1931703437;
					continue;
				case 46u:
					num = ((int)num2 * -190928740) ^ -2049936085;
					continue;
				case 45u:
				{
					int num28;
					int num29;
					if (!flag8)
					{
						num28 = -182921705;
						num29 = -182921705;
					}
					else
					{
						num28 = -2005963584;
						num29 = -2005963584;
					}
					num = num28 ^ (int)(num2 * 2052080191);
					continue;
				}
				case 44u:
					num = (int)(num2 * 220070889) ^ -1855696449;
					continue;
				case 43u:
					num = ((int)num2 * -1128862439) ^ -1021278100;
					continue;
				case 42u:
					flag7 = JSONNode.smethod_6(text, "");
					num = -263269842;
					continue;
				case 41u:
					num = (int)(num2 * 725156720) ^ -352389934;
					continue;
				case 39u:
				{
					int num26;
					if (c == ',')
					{
						num = -840522676;
						num26 = -840522676;
					}
					else
					{
						num = -1066313586;
						num26 = -1066313586;
					}
					continue;
				}
				case 38u:
					num = (int)((num2 * 1946845064) ^ 0x64AF2F42);
					continue;
				case 37u:
					num = (int)(num2 * 2036977193) ^ -66336227;
					continue;
				case 36u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 153437851) ^ 0x732EEF24);
					continue;
				case 35u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -557742953) ^ 0xBCD5766;
					continue;
				case 34u:
					num = ((int)num2 * -930598519) ^ 0x2D0F350D;
					continue;
				case 33u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = (int)(num2 * 1245331300) ^ -1958754389;
					continue;
				case 32u:
					num = (int)((num2 * 844188443) ^ 0x72CB60F3);
					continue;
				case 31u:
					num11 = 0;
					text2 = "";
					num = ((int)num2 * -1370409031) ^ 0x77C66E5B;
					continue;
				case 30u:
					num = ((int)num2 * -1341045220) ^ 0x1220752A;
					continue;
				case 28u:
				{
					int num21;
					int num22;
					if (flag7)
					{
						num21 = 83492859;
						num22 = 83492859;
					}
					else
					{
						num21 = 742263685;
						num22 = 742263685;
					}
					num = num21 ^ (int)(num2 * 1717384585);
					continue;
				}
				case 27u:
					num = ((int)num2 * -1163081501) ^ 0x68CDDECC;
					continue;
				case 26u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1651142981) ^ -631955777;
					continue;
				case 25u:
					switch (c)
					{
					case '[':
						break;
					case ']':
						goto IL_07c2;
					case '\\':
						goto IL_0948;
					default:
						goto IL_0d1e;
					}
					goto case 117u;
				case 23u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num11).ToString());
					num = ((int)num2 * -1602661424) ^ 0x48153772;
					continue;
				case 22u:
					num = (int)(num2 * 1345395379) ^ -1146293927;
					continue;
				case 20u:
					c5 = JSONNode.smethod_2(aJSON, num11);
					num = ((int)num2 * -1699395848) ^ 0x4B7CFA6F;
					continue;
				case 19u:
					num = (int)(num2 * 570527821) ^ -1936331494;
					continue;
				case 18u:
					num = ((int)num2 * -1844499556) ^ -792381218;
					continue;
				case 17u:
				{
					int num19;
					int num20;
					if (!flag5)
					{
						num19 = 707840378;
						num20 = 707840378;
					}
					else
					{
						num19 = 1189462905;
						num20 = 1189462905;
					}
					num = num19 ^ ((int)num2 * -1042349639);
					continue;
				}
				case 16u:
					text = text2;
					num = -250947207;
					continue;
				case 15u:
					text2 = "";
					num = (int)(num2 * 580240261) ^ -1721711863;
					continue;
				case 14u:
				{
					int num14;
					int num15;
					if (flag3)
					{
						num14 = -1845021468;
						num15 = -1845021468;
					}
					else
					{
						num14 = -1049838691;
						num15 = -1049838691;
					}
					num = num14 ^ (int)(num2 * 723939634);
					continue;
				}
				case 13u:
				{
					int num13;
					if ((uint)c > 93u)
					{
						num = -1046235595;
						num13 = -1046235595;
					}
					else
					{
						num = -172068018;
						num13 = -172068018;
					}
					continue;
				}
				case 12u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = -13591562;
					continue;
				case 11u:
				{
					stack.Pop();
					int num12;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -174456916;
						num12 = -174456916;
					}
					else
					{
						num = -1876303900;
						num12 = -1876303900;
					}
					continue;
				}
				case 10u:
					result = jSONNode;
					num = -954776748;
					continue;
				case 9u:
				{
					char c4 = c3;
					c2 = c4;
					num = (int)(num2 * 458863844) ^ -905471932;
					continue;
				}
				case 7u:
					jSONNode.Add(text2);
					num = ((int)num2 * -103649467) ^ -1421903638;
					continue;
				case 6u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 491597721) ^ 0x2DE2CBAC);
					continue;
				case 5u:
					c3 = JSONNode.smethod_2(aJSON, num11);
					num = (int)(num2 * 791741509) ^ -2120101546;
					continue;
				case 4u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -1473322989;
						num10 = -1473322989;
					}
					else
					{
						num9 = -1166261882;
						num10 = -1166261882;
					}
					num = num9 ^ ((int)num2 * -1029323378);
					continue;
				}
				case 3u:
					num = (int)(num2 * 983285652) ^ -2009164833;
					continue;
				case 2u:
				{
					int num5;
					if (c == '"')
					{
						num = -374952574;
						num5 = -374952574;
					}
					else
					{
						num = -1077872764;
						num5 = -1077872764;
					}
					continue;
				}
				case 1u:
					text = "";
					num = -2095067449;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1527664776;
						num4 = -1527664776;
					}
					else
					{
						num3 = -392164206;
						num4 = -392164206;
					}
					num = num3 ^ ((int)num2 * -867836715);
					continue;
				}
				case 53u:
					break;
				case 40u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 128u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0442:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = -1223992007;
					continue;
					IL_0d1e:
					num = -59184634;
					continue;
					IL_0948:
					num11++;
					flag10 = flag4;
					num = -746451323;
					continue;
					IL_01d8:
					num11++;
					num = -1266457870;
					continue;
					IL_07c2:
					if (flag4)
					{
						num = -1910986424;
						num50 = -1910986424;
					}
					else
					{
						num = -1418617453;
						num50 = -1418617453;
					}
					continue;
					IL_01ca:
					flag3 = flag4;
					num = -1143520104;
					continue;
					IL_01b7:
					num = ((int)num2 * -1317050676) ^ 0x296F73E;
					continue;
					IL_061d:
					num = -17933176;
					continue;
					IL_0607:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = -1223992007;
					continue;
					IL_05fd:
					num = -669550008;
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
			int num = -1422607531;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91BFB73Eu) % 5u)
				{
				case 4u:
					Serialize(aWriter);
					num = ((int)num2 * -2021397102) ^ 0x4A7500FB;
					continue;
				case 2u:
					num = ((int)num2 * -1231402005) ^ 0x76A0F617;
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -1074130073) ^ 0x72F325B5;
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
			while (true)
			{
				int num = 1680880076;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x27B8036Cu) % 3u)
					{
					case 2u:
						goto IL_0026;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0026:
					num = (int)(num2 * 1635396588) ^ -1499159768;
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008e:
					int num3 = 886373332;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x27B8036Cu) % 3u)
						{
						case 1u:
							goto IL_005e;
						default:
							goto end_IL_0071;
						case 2u:
							break;
						case 0u:
							goto end_IL_0071;
						}
						goto IL_008e;
						IL_005e:
						JSONNode.smethod_15((IDisposable)fileStream);
						num3 = (int)((num2 * 672155623) ^ 0x61718E75);
						continue;
						end_IL_0071:
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
				int num = 1801942223;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x76126F31u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
					}
					break;
					IL_0009:
					SaveToStream(memoryStream);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 1732731358) ^ -1588006580;
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
					int num3 = 365101822;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x76126F31u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = ((int)num2 * -1348669715) ^ -1686378093;
							continue;
						case 1u:
							num3 = (int)(num2 * 153098877) ^ -25930098;
							continue;
						default:
							goto end_IL_0085;
						case 0u:
							break;
						case 2u:
							goto end_IL_0085;
						}
						goto IL_00a6;
						continue;
						end_IL_0085:
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
		JSONArray jSONArray = default(JSONArray);
		int num3 = default(int);
		JSONClass jSONClass = default(JSONClass);
		int num5 = default(int);
		bool flag = default(bool);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num4 = default(int);
		while (true)
		{
			int num = -1475704118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8738B735u) % 38u)
				{
				case 37u:
					result = jSONArray;
					num = ((int)num2 * -182394671) ^ -1317865689;
					continue;
				case 36u:
					num = -1683515166;
					continue;
				case 35u:
					num3++;
					num = ((int)num2 * -1767683819) ^ -1579208520;
					continue;
				case 34u:
					goto IL_0040;
				case 33u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -254654655) ^ -1103316271;
					continue;
				case 32u:
					goto IL_0077;
				case 31u:
					num = (int)((num2 * 1540351386) ^ 0x6A3C348C);
					continue;
				case 30u:
					num = ((int)num2 * -1579465828) ^ 0x7E52DF12;
					continue;
				case 29u:
					num = (int)((num2 * 1360250404) ^ 0x69B2D380);
					continue;
				case 28u:
				{
					string aKey = JSONNode.smethod_22(aReader);
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = -1395520096;
					continue;
				}
				case 27u:
					num5 = 0;
					num = (int)(num2 * 1492383009) ^ -2110781095;
					continue;
				case 26u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = 1655681231;
						num9 = 1655681231;
					}
					else
					{
						num8 = 1401214174;
						num9 = 1401214174;
					}
					num = num8 ^ (int)(num2 * 1149970375);
					continue;
				}
				case 25u:
					goto IL_012b;
				case 24u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.IntValue:
						break;
					case JSONBinaryTag.BoolValue:
						goto IL_0040;
					case JSONBinaryTag.Value:
						goto IL_0077;
					case JSONBinaryTag.DoubleValue:
						goto IL_012b;
					default:
						goto IL_0166;
					case JSONBinaryTag.Array:
						goto IL_0179;
					case JSONBinaryTag.Class:
						goto IL_0183;
					case JSONBinaryTag.FloatValue:
						goto IL_018d;
					}
					goto case 36u;
				case 2u:
					goto IL_0179;
				case 16u:
					goto IL_0183;
				case 9u:
					goto IL_018d;
				case 23u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -448408573) ^ -1221478934;
					continue;
				case 21u:
					num = ((int)num2 * -1904845184) ^ -639077155;
					continue;
				case 20u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -1635698199) ^ -1828897765;
					continue;
				case 19u:
				{
					int num7;
					if (num5 < num6)
					{
						num = -1691223827;
						num7 = -1691223827;
					}
					else
					{
						num = -1006622318;
						num7 = -1006622318;
					}
					continue;
				}
				case 18u:
					num3 = 0;
					num = (int)((num2 * 1590658696) ^ 0x39735216);
					continue;
				case 17u:
					num = ((int)num2 * -79155933) ^ 0x5C915A54;
					continue;
				case 15u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)(num2 * 1662682423) ^ -166884416;
					continue;
				case 14u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 261257435) ^ 0x49C2C02);
					continue;
				case 12u:
					num4 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -309281208) ^ 0x47218303;
					continue;
				case 11u:
					num = (int)((num2 * 457151776) ^ 0x12A94E2A);
					continue;
				case 10u:
					num5++;
					num = ((int)num2 * -980947297) ^ -944063402;
					continue;
				case 8u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -958339528) ^ -1983830385;
					continue;
				case 7u:
					num = (int)(num2 * 2137727967) ^ -2098213960;
					continue;
				case 6u:
					num = (int)(num2 * 2064029071) ^ -977060502;
					continue;
				case 4u:
					flag = num3 < num4;
					num = -1282230225;
					continue;
				case 3u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 177277222) ^ 0x57B196BC);
					continue;
				case 1u:
					result = jSONClass;
					num = ((int)num2 * -2027105585) ^ -259199012;
					continue;
				case 0u:
					jSONArray.Add(Deserialize(aReader));
					num = -1592244060;
					continue;
				case 13u:
					break;
				case 22u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0040:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1740938161;
					continue;
					IL_018d:
					num = -923678772;
					continue;
					IL_0183:
					num = -1680790728;
					continue;
					IL_0179:
					num = -366972859;
					continue;
					IL_0166:
					num = ((int)num2 * -2007956238) ^ 0x605BADF0;
					continue;
					IL_012b:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -195488950;
					continue;
					IL_0077:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1571080614;
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
				int num = -309382019;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCAB119E5u) % 3u)
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
					num = ((int)num2 * -432300652) ^ 0x2A9CEDF5;
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
					int num3 = -1925915075;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xCAB119E5u) % 3u)
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
						num3 = ((int)num2 * -689645471) ^ 0x1670A8A8;
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
					int num = 739191747;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x31935FD2u) % 4u)
						{
						case 3u:
							num = (int)((num2 * 1400576181) ^ 0x2CFEE7CD);
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -1648381854) ^ -1743880593;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
							break;
						case 0u:
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
		byte[] byte_ = default(byte[]);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1943008549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC9B0004u) % 6u)
				{
				case 4u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -2139120531) ^ -1287481196;
					continue;
				case 3u:
					num = (int)((num2 * 971842632) ^ 0x31BD44E6);
					continue;
				case 1u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = ((int)num2 * -424865951) ^ -293871365;
					continue;
				case 0u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 1662176722) ^ -2031855707;
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
