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
				int num = 1095341924;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC48DC69u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -774569475) ^ 0xEE6D922;
						continue;
					case 1u:
						result = null;
						num = (int)((num2 * 1734081878) ^ 0x6DCBD680);
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
				int num = -1727241062;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8E74C8A7u) % 3u)
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
					num = ((int)num2 * -213388373) ^ 0x2A474DE0;
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
				int num = 1329132007;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7D9C06A4u) % 4u)
					{
					case 3u:
						result = "";
						num = (int)(num2 * 469784681) ^ -1952080899;
						continue;
					case 2u:
						num = ((int)num2 * -1758438219) ^ 0xC414FB7;
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
			int result = 0;
			while (true)
			{
				int num = 1571506484;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x41829EB4u) % 3u)
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
					num = ((int)num2 * -994556993) ^ -877163424;
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
				int num = 1484962289;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4A344534u) % 3u)
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
					num = ((int)num2 * -83183293) ^ 0x35F0F876;
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
			int result = default(int);
			int result2 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num = -1307527304;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8D6FE81Bu) % 8u)
					{
					case 7u:
						result = 0;
						num = -708353750;
						continue;
					case 6u:
						num = (int)(num2 * 502321190) ^ -468845894;
						continue;
					case 4u:
						result = result2;
						num = (int)((num2 * 1457977701) ^ 0x7871DE81);
						continue;
					case 3u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 1637943668) ^ 0xA2C3E27);
						continue;
					case 1u:
						num = (int)(num2 * 1332092127) ^ -850232175;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -363664729;
							num4 = -363664729;
						}
						else
						{
							num3 = -209968124;
							num4 = -209968124;
						}
						num = num3 ^ (int)(num2 * 840523970);
						continue;
					}
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
				int num = -1646525600;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA14DCF63u) % 8u)
					{
					case 6u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)(num2 * 1209791797) ^ -1768896668;
						continue;
					case 5u:
						num = (int)((num2 * 21825876) ^ 0x662C86B8);
						continue;
					case 3u:
						result2 = 0f;
						num = (int)((num2 * 1141673162) ^ 0x323B68AB);
						continue;
					case 2u:
						result = 0f;
						num = -1426846818;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1359840362;
							num4 = 1359840362;
						}
						else
						{
							num3 = 360885248;
							num4 = 360885248;
						}
						num = num3 ^ ((int)num2 * -585177543);
						continue;
					}
					case 0u:
						result = result2;
						num = (int)(num2 * 791793128) ^ -1612588548;
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
				int num = -351360264;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB56526DCu) % 3u)
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
					num = (int)((num2 * 1834378371) ^ 0x416485F8);
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			bool flag = default(bool);
			double result2 = default(double);
			double result = default(double);
			while (true)
			{
				int num = -1388319142;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8DF0E9EBu) % 8u)
					{
					case 7u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -657957045) ^ 0x55F59BCD;
						continue;
					case 6u:
						num = (int)((num2 * 1687362081) ^ 0x3965EF1F);
						continue;
					case 5u:
						result = 0.0;
						num = -2054965775;
						continue;
					case 4u:
						result = result2;
						num = (int)((num2 * 1260307082) ^ 0x6F1DFD4D);
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -274285993;
							num4 = -274285993;
						}
						else
						{
							num3 = -269783666;
							num4 = -269783666;
						}
						num = num3 ^ (int)(num2 * 1892396376);
						continue;
					}
					case 1u:
						result2 = 0.0;
						num = ((int)num2 * -1062323381) ^ -1444428441;
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

	public virtual bool AsBool
	{
		get
		{
			bool result2 = default(bool);
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = 82142171;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5DD7497u) % 8u)
					{
					case 7u:
						num = (int)(num2 * 976824811) ^ -1875441260;
						continue;
					case 4u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -290793595) ^ -1734057743;
						continue;
					case 3u:
						result = !JSONNode.smethod_1(Value);
						num = 463357942;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1760078852;
							num4 = -1760078852;
						}
						else
						{
							num3 = -1830115713;
							num4 = -1830115713;
						}
						num = num3 ^ ((int)num2 * -648461024);
						continue;
					}
					case 1u:
						num = (int)(num2 * 901319355) ^ -602084286;
						continue;
					case 0u:
						result = result2;
						num = ((int)num2 * -833600508) ^ 0x7DF3E9D0;
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
				int num = -1935249456;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ -1734006700) % 3u)
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
					num = -891632344;
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
				int num = 432604231;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x482868EEu) % 3u)
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
					result = this as JSONArray;
					num = ((int)num2 * -640823733) ^ -1107170717;
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
				int num = 1230656909;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA3E473u) % 3u)
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
					result = this as JSONClass;
					num = (int)((num2 * 1871949925) ^ 0x2869A8AE);
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
			int num = -236826198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB1F140CDu) % 3u)
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
				num = ((int)num2 * -1554716576) ^ 0x9B585A9;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = null;
		while (true)
		{
			int num = 1388143079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1E7AA26Du) % 3u)
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
				num = (int)(num2 * 1004250898) ^ -1985489941;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = null;
		while (true)
		{
			int num = -918011513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FA7DC91u) % 3u)
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
				num = ((int)num2 * -1470528250) ^ -297349463;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		while (true)
		{
			int num = -558910838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF41220DCu) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 2u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0004:
				num = (int)((num2 * 1891029154) ^ 0x10D4F233);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1885633828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CCF1EBu) % 3u)
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
				result = "JSONNode";
				num = (int)((num2 * 990008217) ^ 0x4E9C89F1);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1099489380;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0B0B8EDu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1072917644) ^ -1672783311;
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)(num2 * 876623930) ^ -102544167;
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 2078304623;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59E5669Au) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1548246829) ^ 0x58058C61);
					continue;
				case 1u:
					result = new JSONData(s);
					num = (int)((num2 * 340330221) ^ 0x71F7AAD0);
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

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = 1703525777;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x22165CBAu) % 5u)
				{
				case 3u:
					if (!(d == null))
					{
						num = ((int)num2 * -1483118750) ^ 0x22A1358C;
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
					num = ((int)num2 * -1144399335) ^ 0x2D5675D;
					continue;
				case 0u:
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
					num = 1989364771;
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
			int num = -1760123220;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD7D6A712u) % 7u)
				{
				case 6u:
					result = true;
					num = (int)((num2 * 1586575744) ^ 0x2D652C6);
					continue;
				case 5u:
					if (b == null)
					{
						num = ((int)num2 * -1601627526) ^ -17807501;
						continue;
					}
					goto IL_002c;
				case 3u:
					if (a is JSONLazyCreator)
					{
						num = -1347259525;
						num3 = -1347259525;
						continue;
					}
					goto IL_002c;
				case 1u:
					num = (int)((num2 * 762086607) ^ 0x658A5C0A);
					continue;
				case 0u:
					result = (object)a == b;
					num = -199246362;
					continue;
				case 4u:
					break;
				default:
					{
						return result;
					}
					IL_002c:
					num = -1915354559;
					num3 = -1915354559;
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
			int num = -1880366947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD15D718Cu) % 4u)
				{
				case 1u:
					result = !(a == b);
					num = (int)((num2 * 820096598) ^ 0x61E5EEA);
					continue;
				case 0u:
					num = ((int)num2 * -1210313916) ^ 0x1DA0B8EE;
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
			int num = -2139761247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9403507Fu) % 3u)
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
				result = (object)this == obj;
				num = ((int)num2 * -1184356419) ^ 0x49FD68A5;
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
		char c3 = default(char);
		char c2 = default(char);
		string result = default(string);
		string string_ = default(string);
		int num3 = default(int);
		char c = default(char);
		while (true)
		{
			int num = -887341034;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEDE8C8B7u) % 32u)
				{
				case 31u:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1805960377;
					continue;
				case 30u:
					num = (int)((num2 * 1154599283) ^ 0x74DC0C44);
					continue;
				case 29u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1230216207;
					continue;
				case 28u:
					c3 = c2;
					num = ((int)num2 * -601757268) ^ -765719530;
					continue;
				case 27u:
					num = ((int)num2 * -813111032) ^ 0x6149A143;
					continue;
				case 26u:
					goto IL_006e;
				case 25u:
					num = ((int)num2 * -1228637470) ^ -1240390080;
					continue;
				case 24u:
					goto IL_0097;
				case 23u:
					goto IL_00ad;
				case 21u:
					result = text;
					num = (int)((num2 * 1204920789) ^ 0x47C5E70E);
					continue;
				case 20u:
					c2 = JSONNode.smethod_2(string_, num3);
					num = -1696380757;
					continue;
				case 19u:
					switch (c)
					{
					case '\t':
						break;
					case '\n':
						goto IL_006e;
					case '\f':
						goto IL_0097;
					case '\r':
						goto IL_00ad;
					default:
						goto IL_010c;
					case '\b':
						goto IL_011f;
					case '\v':
						goto IL_0135;
					}
					goto case 31u;
				case 10u:
					goto IL_011f;
				case 7u:
					goto IL_0135;
				case 18u:
					num = ((int)num2 * -565454380) ^ -2032229585;
					continue;
				case 17u:
					c = c3;
					num = ((int)num2 * -161201118) ^ 0x11913506;
					continue;
				case 16u:
					num = -2114512999;
					continue;
				case 15u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1805960377;
					continue;
				case 14u:
					num3++;
					num = (int)((num2 * 1022886574) ^ 0x7AB93CF0);
					continue;
				case 13u:
					num = (int)(num2 * 1344917343) ^ -1228348684;
					continue;
				case 12u:
				{
					int num6;
					if (c == '"')
					{
						num = -954175254;
						num6 = -954175254;
					}
					else
					{
						num = -1340191447;
						num6 = -1340191447;
					}
					continue;
				}
				case 11u:
					num = (int)(num2 * 1017210922) ^ -833613751;
					continue;
				case 9u:
				{
					int num5;
					if (c == '\\')
					{
						num = -1634080488;
						num5 = -1634080488;
					}
					else
					{
						num = -1610949805;
						num5 = -1610949805;
					}
					continue;
				}
				case 8u:
					num3 = 0;
					num = (int)((num2 * 690601573) ^ 0x34EB021C);
					continue;
				case 6u:
					num = (int)((num2 * 545972845) ^ 0x1B778389);
					continue;
				case 5u:
					string_ = aText;
					num = (int)((num2 * 623362950) ^ 0x705F11E1);
					continue;
				case 4u:
					num = ((int)num2 * -788770020) ^ -1620809984;
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -1648169566;
						num4 = -1648169566;
					}
					else
					{
						num = -840062269;
						num4 = -840062269;
					}
					continue;
				}
				case 1u:
					text = "";
					num = (int)((num2 * 1342457168) ^ 0x21EAE5BE);
					continue;
				case 0u:
					num = (int)(num2 * 2112512292) ^ -1354241963;
					continue;
				case 22u:
					break;
				default:
					{
						return result;
					}
					IL_006e:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1805960377;
					continue;
					IL_0135:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = -1742096740;
					continue;
					IL_011f:
					text = JSONNode.smethod_3(text, "\\b");
					num = -1805960377;
					continue;
					IL_010c:
					num = ((int)num2 * -1559578862) ^ -437618086;
					continue;
					IL_00ad:
					text = JSONNode.smethod_3(text, "\\r");
					num = -1838837094;
					continue;
					IL_0097:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1622112571;
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
		string text = default(string);
		char c3 = default(char);
		bool flag13 = default(bool);
		bool flag4 = default(bool);
		char c2 = default(char);
		string text2 = default(string);
		bool flag8 = default(bool);
		char c = default(char);
		bool flag14 = default(bool);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		int num5 = default(int);
		bool flag11 = default(bool);
		bool flag6 = default(bool);
		bool flag7 = default(bool);
		bool flag12 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag9 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1495987841;
			while (true)
			{
				uint num2;
				int num17;
				switch ((num2 = (uint)num ^ 0xC68C3B02u) % 156u)
				{
				case 155u:
				{
					int num54;
					int num55;
					if (flag15)
					{
						num54 = 583520763;
						num55 = 583520763;
					}
					else
					{
						num54 = 742617352;
						num55 = 742617352;
					}
					num = num54 ^ ((int)num2 * -2053675457);
					continue;
				}
				case 154u:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -286184769;
					continue;
				case 153u:
					num = (int)(num2 * 805445512) ^ -268420726;
					continue;
				case 151u:
					num = (int)(num2 * 564553851) ^ -1511832546;
					continue;
				case 150u:
					num = (int)((num2 * 2055192521) ^ 0x6249810C);
					continue;
				case 149u:
				{
					int num36;
					int num37;
					if (!flag13)
					{
						num36 = -1127504192;
						num37 = -1127504192;
					}
					else
					{
						num36 = -1029668025;
						num37 = -1029668025;
					}
					num = num36 ^ ((int)num2 * -82720762);
					continue;
				}
				case 148u:
					num = (int)(num2 * 1779651552) ^ -823728068;
					continue;
				case 147u:
					num = ((int)num2 * -1241183095) ^ 0x5D98DBBE;
					continue;
				case 146u:
					num = (int)(num2 * 1134823077) ^ -486083412;
					continue;
				case 145u:
					text = JSONNode.smethod_3(text, "\f");
					num = -152840681;
					continue;
				case 143u:
				{
					int num52;
					int num53;
					if (!flag4)
					{
						num52 = -1541530260;
						num53 = -1541530260;
					}
					else
					{
						num52 = -673754755;
						num53 = -673754755;
					}
					num = num52 ^ (int)(num2 * 310792726);
					continue;
				}
				case 142u:
				{
					int num45;
					if (c2 == 'n')
					{
						num = -1830175614;
						num45 = -1830175614;
					}
					else
					{
						num = -1522254329;
						num45 = -1522254329;
					}
					continue;
				}
				case 141u:
					num = (int)((num2 * 1283142071) ^ 0x5E6A1B75);
					continue;
				case 140u:
					text2 = "";
					text = "";
					num = -1734819134;
					continue;
				case 139u:
					jSONNode.Add(text);
					num = (int)((num2 * 893908442) ^ 0x47DE3275);
					continue;
				case 138u:
				{
					int num25;
					int num26;
					if (flag8)
					{
						num25 = 678629247;
						num26 = 678629247;
					}
					else
					{
						num25 = 1722217728;
						num26 = 1722217728;
					}
					num = num25 ^ (int)(num2 * 1792486053);
					continue;
				}
				case 137u:
				{
					int num22;
					if (c == ',')
					{
						num = -1053652476;
						num22 = -1053652476;
					}
					else
					{
						num = -1734343466;
						num22 = -1734343466;
					}
					continue;
				}
				case 136u:
					switch (c2)
					{
					case 's':
						break;
					default:
						goto IL_01f8;
					case 'r':
						goto IL_0202;
					case 't':
						goto IL_0218;
					case 'u':
						goto IL_022e;
					}
					goto case 154u;
				case 15u:
					goto IL_0202;
				case 8u:
					goto IL_0218;
				case 63u:
					goto IL_022e;
				case 135u:
					num = (int)(num2 * 1724881070) ^ -928735464;
					continue;
				case 134u:
				{
					int num58;
					int num59;
					if ((uint)c2 > 102u)
					{
						num58 = 1135178584;
						num59 = 1135178584;
					}
					else
					{
						num58 = 560747310;
						num59 = 560747310;
					}
					num = num58 ^ ((int)num2 * -254821688);
					continue;
				}
				case 133u:
					flag14 = jSONNode is JSONArray;
					num = (int)((num2 * 2043400813) ^ 0x401705D0);
					continue;
				case 132u:
				{
					int num48;
					int num49;
					if (flag10)
					{
						num48 = 1455513171;
						num49 = 1455513171;
					}
					else
					{
						num48 = 1920189771;
						num49 = 1920189771;
					}
					num = num48 ^ ((int)num2 * -1807248814);
					continue;
				}
				case 131u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1444593931) ^ -190714508;
					continue;
				case 130u:
					jSONNode.Add(text);
					num = (int)(num2 * 194762146) ^ -311509400;
					continue;
				case 129u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 1970032004) ^ -1663102119;
					continue;
				case 128u:
					flag2 = !flag2;
					num = -557245249;
					continue;
				case 127u:
				{
					int num41;
					int num42;
					if (!flag14)
					{
						num41 = 370947595;
						num42 = 370947595;
					}
					else
					{
						num41 = 1051771660;
						num42 = 1051771660;
					}
					num = num41 ^ ((int)num2 * -462309668);
					continue;
				}
				case 126u:
					flag5 = flag2;
					num = -529185173;
					continue;
				case 125u:
				{
					string s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = (int)((num2 * 249262838) ^ 0x4493CDF7);
					continue;
				}
				case 124u:
					text2 = JSONNode.smethod_5(text2);
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -1921806702) ^ 0x4D3DCA5C;
					continue;
				case 123u:
				{
					int num32;
					int num33;
					if (JSONNode.smethod_6(text, ""))
					{
						num32 = -1290335348;
						num33 = -1290335348;
					}
					else
					{
						num32 = -253380737;
						num33 = -253380737;
					}
					num = num32 ^ (int)(num2 * 277433690);
					continue;
				}
				case 122u:
					flag11 = flag2;
					num = -601297331;
					continue;
				case 121u:
					num = (int)((num2 * 1326588757) ^ 0x6FBD94CD);
					continue;
				case 120u:
					flag10 = flag2;
					num = (int)(num2 * 611023969) ^ -190837658;
					continue;
				case 119u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num5);
					c = c5;
					num = (int)(num2 * 1654636333) ^ -1856227269;
					continue;
				}
				case 118u:
					num = ((int)num2 * -1001388882) ^ -970544082;
					continue;
				case 117u:
					num = (int)(num2 * 725388949) ^ -833005157;
					continue;
				case 116u:
				{
					int num24;
					if ((uint)c <= 93u)
					{
						num = -1451927047;
						num24 = -1451927047;
					}
					else
					{
						num = -697942186;
						num24 = -697942186;
					}
					continue;
				}
				case 115u:
				{
					int num18;
					int num19;
					if ((uint)c > 32u)
					{
						num18 = 713067747;
						num19 = 713067747;
					}
					else
					{
						num18 = 2053633762;
						num19 = 2053633762;
					}
					num = num18 ^ ((int)num2 * -1497904174);
					continue;
				}
				case 114u:
					num = (int)((num2 * 1600106678) ^ 0x100FD1BE);
					continue;
				case 113u:
					num = ((int)num2 * -1221518456) ^ 0x72F43D04;
					continue;
				case 112u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -13562490) ^ 0x141D6FE0;
					continue;
				case 111u:
					num = ((int)num2 * -2115503957) ^ 0x33301977;
					continue;
				case 109u:
				{
					int num14;
					if (c2 == 'f')
					{
						num = -620446361;
						num14 = -620446361;
					}
					else
					{
						num = -1125675480;
						num14 = -1125675480;
					}
					continue;
				}
				case 108u:
					num5++;
					num = -1368146138;
					continue;
				case 107u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = -2085258287;
					continue;
				case 106u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1865680222;
					continue;
				case 105u:
					num = ((int)num2 * -1954958014) ^ -713963382;
					continue;
				case 104u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -324419380;
						num8 = -324419380;
					}
					else
					{
						num7 = -429027414;
						num8 = -429027414;
					}
					num = num7 ^ ((int)num2 * -115491180);
					continue;
				}
				case 103u:
				{
					int num60;
					int num61;
					if (flag6)
					{
						num60 = -1087866964;
						num61 = -1087866964;
					}
					else
					{
						num60 = -295383419;
						num61 = -295383419;
					}
					num = num60 ^ ((int)num2 * -722244309);
					continue;
				}
				case 102u:
					goto IL_05ea;
				case 101u:
					num = (int)((num2 * 931381955) ^ 0x32199C6D);
					continue;
				case 100u:
				{
					int num56;
					int num57;
					if (c2 == 'b')
					{
						num56 = -1593973180;
						num57 = -1593973180;
					}
					else
					{
						num56 = -1962517385;
						num57 = -1962517385;
					}
					num = num56 ^ (int)(num2 * 986362024);
					continue;
				}
				case 99u:
					text = "";
					num = ((int)num2 * -878991103) ^ 0x20EE6DA4;
					continue;
				case 98u:
				{
					int num50;
					int num51;
					if (jSONNode is JSONArray)
					{
						num50 = -1927524558;
						num51 = -1927524558;
					}
					else
					{
						num50 = -452141751;
						num51 = -452141751;
					}
					num = num50 ^ (int)(num2 * 332907814);
					continue;
				}
				case 97u:
					text2 = "";
					flag2 = false;
					num = (int)((num2 * 1374739785) ^ 0x77DA7A30);
					continue;
				case 96u:
					flag15 = jSONNode != null;
					num = (int)((num2 * 1430496973) ^ 0xE13C5A5);
					continue;
				case 95u:
				{
					int num47;
					if (num5 >= JSONNode.smethod_4(aJSON))
					{
						num = -2108799082;
						num47 = -2108799082;
					}
					else
					{
						num = -1272874577;
						num47 = -1272874577;
					}
					continue;
				}
				case 94u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = -365726242;
					continue;
				case 93u:
					num5 = 0;
					text = "";
					num = (int)(num2 * 1991296562) ^ -311642859;
					continue;
				case 91u:
					num = ((int)num2 * -1530760489) ^ 0x388B3943;
					continue;
				case 90u:
					num = (int)((num2 * 271235765) ^ 0x14C81ABB);
					continue;
				case 89u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -599256256) ^ 0x326E724F;
					continue;
				case 88u:
				{
					int num46;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -674195736;
						num46 = -674195736;
					}
					else
					{
						num = -1132057414;
						num46 = -1132057414;
					}
					continue;
				}
				case 87u:
					stack.Push(new JSONArray());
					num = -320966939;
					continue;
				case 86u:
					num = (int)(num2 * 1280134990) ^ -985529776;
					continue;
				case 85u:
					num = (int)((num2 * 1052018348) ^ 0x4DC1DC7E);
					continue;
				case 84u:
				{
					int num43;
					int num44;
					if (flag12)
					{
						num43 = -1168090928;
						num44 = -1168090928;
					}
					else
					{
						num43 = -88861191;
						num44 = -88861191;
					}
					num = num43 ^ (int)(num2 * 2053681213);
					continue;
				}
				case 83u:
				{
					int num39;
					int num40;
					if (!flag11)
					{
						num39 = 1068515836;
						num40 = 1068515836;
					}
					else
					{
						num39 = 811761077;
						num40 = 811761077;
					}
					num = num39 ^ (int)(num2 * 1220847532);
					continue;
				}
				case 82u:
					num = -454263032;
					continue;
				case 0u:
				case 48u:
				case 53u:
				case 64u:
				case 81u:
					goto IL_0836;
				case 80u:
					num = -1998596839;
					continue;
				case 79u:
					stack.Push(new JSONClass());
					num = -1201074134;
					continue;
				case 78u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -813914558) ^ 0x5B1ACF6D;
					continue;
				case 77u:
					result = jSONNode;
					num = -686319586;
					continue;
				case 76u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1690128978) ^ 0x4DC04639);
					continue;
				case 75u:
					num = (int)((num2 * 534006689) ^ 0x34BF5DDF);
					continue;
				case 74u:
					num = ((int)num2 * -2073668747) ^ 0x1D7975B0;
					continue;
				case 73u:
				{
					int num38;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1449284657;
						num38 = -1449284657;
					}
					else
					{
						num = -909688339;
						num38 = -909688339;
					}
					continue;
				}
				case 72u:
					c3 = JSONNode.smethod_2(aJSON, num5);
					num = (int)((num2 * 397956388) ^ 0x4C66CA5C);
					continue;
				case 71u:
					num = (int)(num2 * 100803660) ^ -961694802;
					continue;
				case 70u:
					flag13 = JSONNode.smethod_6(text, "");
					num = -1877430393;
					continue;
				case 69u:
					num = ((int)num2 * -1900669053) ^ 0x20CB9275;
					continue;
				case 68u:
					num = ((int)num2 * -653138634) ^ 0x65C8FA02;
					continue;
				case 67u:
				{
					int num34;
					int num35;
					if (c == ':')
					{
						num34 = -917516309;
						num35 = -917516309;
					}
					else
					{
						num34 = -242874675;
						num35 = -242874675;
					}
					num = num34 ^ ((int)num2 * -1392357676);
					continue;
				}
				case 66u:
					flag12 = flag2;
					num = -432832018;
					continue;
				case 65u:
					num = ((int)num2 * -1135098012) ^ 0x4C5E608C;
					continue;
				case 62u:
					flag9 = stack.Count > 0;
					num = (int)((num2 * 677798324) ^ 0x64AB3736);
					continue;
				case 61u:
					num = -618450183;
					continue;
				case 60u:
					num = ((int)num2 * -1697929726) ^ 0x628346B4;
					continue;
				case 59u:
					text2 = "";
					num = -180266145;
					continue;
				case 58u:
				{
					int num30;
					int num31;
					if ((uint)c <= 44u)
					{
						num30 = -963878303;
						num31 = -963878303;
					}
					else
					{
						num30 = -749190706;
						num31 = -749190706;
					}
					num = num30 ^ (int)(num2 * 100645624);
					continue;
				}
				case 57u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1739385756) ^ -2146586993;
					continue;
				case 56u:
					num = (int)((num2 * 1278657053) ^ 0x5DAB5394);
					continue;
				case 55u:
					num = (int)(num2 * 956508059) ^ -1653326153;
					continue;
				case 54u:
					goto IL_0a81;
				case 52u:
				{
					int num28;
					int num29;
					if (flag9)
					{
						num28 = 1407908787;
						num29 = 1407908787;
					}
					else
					{
						num28 = 1399251374;
						num29 = 1399251374;
					}
					num = num28 ^ (int)(num2 * 322046032);
					continue;
				}
				case 51u:
					num = ((int)num2 * -279693960) ^ 0x126FF290;
					continue;
				case 50u:
				{
					int num27;
					if (stack.Count != 0)
					{
						num = -744769712;
						num27 = -744769712;
					}
					else
					{
						num = -626561394;
						num27 = -626561394;
					}
					continue;
				}
				case 49u:
					text = "";
					num = (int)((num2 * 1353486961) ^ 0x221701B3);
					continue;
				case 47u:
					num5 += 4;
					num = ((int)num2 * -1972260468) ^ 0x50882D01;
					continue;
				case 46u:
					num = ((int)num2 * -1479106647) ^ -501907645;
					continue;
				case 45u:
				{
					int num23;
					if (flag2)
					{
						num = -810469005;
						num23 = -810469005;
					}
					else
					{
						num = -2068807315;
						num23 = -2068807315;
					}
					continue;
				}
				case 44u:
				{
					int num20;
					int num21;
					if (!flag7)
					{
						num20 = -118349284;
						num21 = -118349284;
					}
					else
					{
						num20 = -724397242;
						num21 = -724397242;
					}
					num = num20 ^ ((int)num2 * -100892353);
					continue;
				}
				case 43u:
					num = -476854818;
					continue;
				case 42u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -319928345) ^ -295613372;
					continue;
				case 41u:
					switch (c)
					{
					case '\\':
						break;
					case ']':
						goto IL_0a81;
					default:
						goto IL_0bc8;
					case '[':
						goto IL_0bd2;
					}
					goto case 108u;
				case 5u:
					goto IL_0bd2;
				case 40u:
					text = JSONNode.smethod_3(text, "\n");
					num = -1966657144;
					continue;
				case 39u:
					text2 = "";
					num = -174341651;
					continue;
				case 38u:
				{
					char c4 = c3;
					c2 = c4;
					num = ((int)num2 * -60577750) ^ 0x40BB5320;
					continue;
				}
				case 37u:
					text = "";
					num = (int)((num2 * 289554685) ^ 0x50FEC181);
					continue;
				case 36u:
					num = -879513903;
					continue;
				case 35u:
					text = "";
					num = (int)((num2 * 1269953893) ^ 0x26EA0BE7);
					continue;
				case 34u:
					text2 = "";
					num = -1567658557;
					continue;
				case 33u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1528299455) ^ 0x7CB18DDF;
					continue;
				case 32u:
				{
					int num16;
					if (c == '{')
					{
						num = -1413538024;
						num16 = -1413538024;
					}
					else
					{
						num = -642540824;
						num16 = -642540824;
					}
					continue;
				}
				case 31u:
					num = (int)((num2 * 1844715921) ^ 0x402F4888);
					continue;
				case 30u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1508306588) ^ 0x67587BBE;
					continue;
				case 29u:
					num = ((int)num2 * -720133369) ^ -545904247;
					continue;
				case 28u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 635720766) ^ -530022149;
					continue;
				case 27u:
					text2 = JSONNode.smethod_5(text2);
					flag6 = jSONNode is JSONArray;
					num = (int)((num2 * 1287836327) ^ 0x16D425E8);
					continue;
				case 26u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1111171963) ^ -1181497161;
					continue;
				case 25u:
					num = (int)(num2 * 1789383465) ^ -1779462252;
					continue;
				case 24u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1159174399) ^ 0x22FD6E5A;
					continue;
				case 23u:
					flag = jSONNode != null;
					num = ((int)num2 * -649471355) ^ -1945778312;
					continue;
				case 22u:
					switch (c)
					{
					case '\t':
						break;
					case '\v':
					case '\f':
						goto IL_05ea;
					case '\n':
					case '\r':
						goto IL_0836;
					default:
						goto IL_0dcb;
					}
					goto case 126u;
				case 21u:
					num = (int)((num2 * 1158501444) ^ 0x12DB4576);
					continue;
				case 20u:
					num = ((int)num2 * -20320786) ^ -1290173184;
					continue;
				case 19u:
					num = (int)(num2 * 1919494820) ^ -1609354621;
					continue;
				case 18u:
					num = (int)((num2 * 892535801) ^ 0x545FEE01);
					continue;
				case 17u:
					num = ((int)num2 * -1525454685) ^ -676705880;
					continue;
				case 16u:
				{
					int num15;
					if (c != ' ')
					{
						num = -1008912405;
						num15 = -1008912405;
					}
					else
					{
						num = -762423516;
						num15 = -762423516;
					}
					continue;
				}
				case 14u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -924107600) ^ 0x772A5962;
					continue;
				case 13u:
				{
					int num12;
					int num13;
					if (flag5)
					{
						num12 = -2146185129;
						num13 = -2146185129;
					}
					else
					{
						num12 = -1773097042;
						num13 = -1773097042;
					}
					num = num12 ^ ((int)num2 * -1298558995);
					continue;
				}
				case 12u:
					num = -1246588038;
					continue;
				case 11u:
				{
					int num11;
					if (c != '"')
					{
						num = -1975160907;
						num11 = -1975160907;
					}
					else
					{
						num = -511957962;
						num11 = -511957962;
					}
					continue;
				}
				case 10u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1722760616;
						num10 = 1722760616;
					}
					else
					{
						num9 = 1308005251;
						num10 = 1308005251;
					}
					num = num9 ^ ((int)num2 * -740400746);
					continue;
				}
				case 9u:
				{
					int num6;
					if (c == '}')
					{
						num = -1502577052;
						num6 = -1502577052;
					}
					else
					{
						num = -188339731;
						num6 = -188339731;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -1709991796) ^ -731416266;
					continue;
				case 6u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -168770530) ^ -515782368;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -114710274) ^ -348232229;
					continue;
				case 3u:
					text2 = text;
					num = -1151748955;
					continue;
				case 2u:
					stack.Pop();
					num = -1953161967;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1188024306;
						num4 = 1188024306;
					}
					else
					{
						num3 = 947102391;
						num4 = 947102391;
					}
					num = num3 ^ (int)(num2 * 634986570);
					continue;
				}
				case 92u:
					break;
				case 110u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 152u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_022e:
					num = -2019681233;
					continue;
					IL_0218:
					text = JSONNode.smethod_3(text, "\t");
					num = -862018987;
					continue;
					IL_0202:
					text = JSONNode.smethod_3(text, "\r");
					num = -1865680222;
					continue;
					IL_01f8:
					num = -511278826;
					continue;
					IL_0dcb:
					num = ((int)num2 * -669150772) ^ -1271614100;
					continue;
					IL_0bd2:
					if (flag2)
					{
						num = -1187680376;
						num17 = -1187680376;
					}
					else
					{
						num = -1993954295;
						num17 = -1993954295;
					}
					continue;
					IL_0bc8:
					num = -709354886;
					continue;
					IL_0a81:
					flag3 = flag2;
					num = -649903032;
					continue;
					IL_0836:
					num5++;
					num = -282407628;
					continue;
					IL_05ea:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = -992326280;
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
			int num = -945165320;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7364671u) % 5u)
				{
				case 3u:
					Serialize(aWriter);
					num = ((int)num2 * -533708320) ^ -2048399721;
					continue;
				case 1u:
					aWriter = JSONNode.smethod_9(aData);
					num = (int)((num2 * 67995970) ^ 0x16BF2A8E);
					continue;
				case 0u:
					num = (int)(num2 * 1729139009) ^ -889667160;
					continue;
				default:
					return;
				case 4u:
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
				int num = 1747866500;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4F5EBF32u) % 4u)
					{
					case 2u:
						num = (int)(num2 * 1676515421) ^ -561458379;
						continue;
					case 1u:
						num = (int)(num2 * 623686020) ^ -1260199282;
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
					int num3 = 1555116963;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x4F5EBF32u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -2074197415) ^ 0x26C57DF7;
							continue;
						case 0u:
							num3 = (int)((num2 * 27101627) ^ 0x5ECD47F1);
							continue;
						default:
							goto end_IL_0093;
						case 2u:
							break;
						case 3u:
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
			JSONNode.smethod_17((Stream)memoryStream, 0L);
			while (true)
			{
				int num = -515265366;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAEC5E442u) % 3u)
					{
					case 1u:
						goto IL_001e;
					case 2u:
						break;
					default:
						return JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
					}
					break;
					IL_001e:
					num = ((int)num2 * -2000564994) ^ 0x38CA645E;
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
					int num3 = -816182875;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xAEC5E442u) % 3u)
						{
						case 1u:
							goto IL_0062;
						default:
							goto end_IL_0075;
						case 0u:
							break;
						case 2u:
							goto end_IL_0075;
						}
						goto IL_0092;
						IL_0062:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -651405440) ^ 0x39187F40;
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
		bool flag2 = default(bool);
		int num4 = default(int);
		int num8 = default(int);
		JSONArray jSONArray = default(JSONArray);
		int num7 = default(int);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		int num3 = default(int);
		string aKey = default(string);
		JSONClass jSONClass = default(JSONClass);
		JSONNode aItem = default(JSONNode);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		while (true)
		{
			int num = 126449198;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1CEE5ECu) % 38u)
				{
				case 37u:
					num = ((int)num2 * -1162594732) ^ 0x1B3F5F4E;
					continue;
				case 36u:
					num = 777056168;
					continue;
				case 34u:
					flag2 = num4 < num8;
					num = 1409806279;
					continue;
				case 33u:
					num8 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num4 = 0;
					num = ((int)num2 * -258457513) ^ -367092273;
					continue;
				case 32u:
					num7 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1338094247) ^ 0x6D7564F;
					continue;
				case 31u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.BoolValue:
						break;
					default:
						goto IL_009d;
					case JSONBinaryTag.Array:
						goto IL_00b0;
					case JSONBinaryTag.Class:
						goto IL_00ba;
					case JSONBinaryTag.Value:
						goto IL_00c4;
					case JSONBinaryTag.IntValue:
						goto IL_00db;
					case JSONBinaryTag.DoubleValue:
						goto IL_00e5;
					case JSONBinaryTag.FloatValue:
						goto IL_00fc;
					}
					goto case 36u;
				case 25u:
					goto IL_00b0;
				case 5u:
					goto IL_00ba;
				case 28u:
					goto IL_00c4;
				case 21u:
					goto IL_00db;
				case 22u:
					goto IL_00e5;
				case 17u:
					goto IL_00fc;
				case 30u:
					result = jSONArray;
					num = ((int)num2 * -611109676) ^ 0x51C6A77A;
					continue;
				case 29u:
					num = (int)(num2 * 1333647874) ^ -215263728;
					continue;
				case 27u:
					flag = num3 < num7;
					num = 1827277014;
					continue;
				case 24u:
					aKey = JSONNode.smethod_22(aReader);
					num = 1151930101;
					continue;
				case 23u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1667746371;
						num10 = -1667746371;
					}
					else
					{
						num9 = -674482829;
						num10 = -674482829;
					}
					num = num9 ^ ((int)num2 * -1575996703);
					continue;
				}
				case 20u:
					num = (int)(num2 * 1679641458) ^ -1469620888;
					continue;
				case 19u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -2079641773) ^ 0x1360DD12;
					continue;
				case 18u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1884277792;
						num6 = 1884277792;
					}
					else
					{
						num5 = 439885887;
						num6 = 439885887;
					}
					num = num5 ^ (int)(num2 * 1390183806);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1609609591) ^ 0x6FA83EEE;
					continue;
				case 14u:
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -2101053420) ^ -1189409598;
					continue;
				case 13u:
					num3++;
					num = (int)(num2 * 1803416386) ^ -568784419;
					continue;
				case 12u:
					jSONArray.Add(Deserialize(aReader));
					num4++;
					num = 1401582482;
					continue;
				case 11u:
					result = jSONClass;
					num = ((int)num2 * -69978886) ^ -193184724;
					continue;
				case 10u:
					num = (int)((num2 * 375696123) ^ 0x5AC103F2);
					continue;
				case 9u:
					num = ((int)num2 * -1124012771) ^ -206969327;
					continue;
				case 8u:
					num = ((int)num2 * -323463080) ^ -348133574;
					continue;
				case 7u:
					num = (int)((num2 * 1965522953) ^ 0x49E5642E);
					continue;
				case 6u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1159479181) ^ 0x466AF612;
					continue;
				case 4u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -1350669179) ^ -411141553;
					continue;
				case 3u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1228602349) ^ 0x6198821E;
					continue;
				case 2u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = ((int)num2 * -1883140597) ^ 0x71C78395;
					continue;
				case 1u:
					jSONClass = new JSONClass();
					num3 = 0;
					num = (int)(num2 * 1853041578) ^ -1461898193;
					continue;
				case 0u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -1209809779) ^ 0x42165225;
					continue;
				case 35u:
					break;
				case 16u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_009d:
					num = (int)((num2 * 1304886262) ^ 0x4859D758);
					continue;
					IL_00fc:
					num = 1224624272;
					continue;
					IL_00e5:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = 215379601;
					continue;
					IL_00db:
					num = 1545939140;
					continue;
					IL_00c4:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 524520450;
					continue;
					IL_00ba:
					num = 705641416;
					continue;
					IL_00b0:
					num = 757218009;
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
					int num = 2054085201;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x54183ADCu) % 3u)
						{
						case 1u:
							goto IL_0015;
						default:
							goto end_IL_0028;
						case 0u:
							break;
						case 2u:
							goto end_IL_0028;
						}
						goto IL_0045;
						IL_0015:
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = ((int)num2 * -1799533507) ^ -1979045314;
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
					IL_0058:
					int num = 1627021901;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x149C5378u) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = ((int)num2 * -1017290927) ^ -1601569399;
							continue;
						case 0u:
							num = (int)(num2 * 1482063489) ^ -913684810;
							continue;
						default:
							goto end_IL_0037;
						case 3u:
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
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num = -2125258430;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5E701F0u) % 5u)
				{
				case 4u:
					result = LoadFromStream(memoryStream);
					num = (int)(num2 * 134754856) ^ -1211782185;
					continue;
				case 3u:
					memoryStream = JSONNode.smethod_29(byte_);
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1938904706) ^ -412290853;
					continue;
				case 1u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)(num2 * 2091670517) ^ -857286110;
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
