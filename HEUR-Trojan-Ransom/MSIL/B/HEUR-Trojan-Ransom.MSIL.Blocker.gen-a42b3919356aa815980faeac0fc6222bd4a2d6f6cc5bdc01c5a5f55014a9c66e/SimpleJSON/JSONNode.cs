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
				int num = -472608931;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA7026DC4u) % 4u)
					{
					case 1u:
						result = null;
						num = (int)((num2 * 2007676994) ^ 0x38F77632);
						continue;
					case 0u:
						num = ((int)num2 * -1359672333) ^ 0x3168F937;
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
				int num = 198785328;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6AFF9D9Du) % 4u)
					{
					case 2u:
						num = (int)((num2 * 714674005) ^ 0x778EC38B);
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -1691388204) ^ 0x72E5726F;
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
				int num = 439976733;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x482A6598u) % 4u)
					{
					case 1u:
						result = "";
						num = (int)((num2 * 1242977418) ^ 0x6E8DA91A);
						continue;
					case 0u:
						num = (int)((num2 * 413353851) ^ 0x24EE4E1E);
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
				int num = 1156186839;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5881D7D2u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -853217223) ^ 0x75B43868;
						continue;
					case 1u:
						result = 0;
						num = (int)((num2 * 179610673) ^ 0x66C7FE69);
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

	public virtual IEnumerable<JSONNode> Childs
	{
		get
		{
			while (true)
			{
				int num = 352933534;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5DDCD1D7u) % 6u)
					{
					case 1u:
					{
						int num3;
						num = ((num3 != 0) ? 165439196 : 1301887961) ^ (int)(num2 * 1168472315);
						continue;
					}
					case 0u:
						num = (int)((num2 * 1053498353) ^ 0x77B308C2);
						continue;
					default:
						yield break;
					case 4u:
						break;
					case 5u:
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
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -369340214;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCEA4AD43u) % 3u)
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
					num = ((int)num2 * -1636599067) ^ -1211636009;
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
			int num = 972590873;
			goto IL_0045;
			IL_0045:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B51F145u) % 6u)
				{
				case 5u:
					break;
				case 4u:
					num = ((int)num2 * -817931207) ^ -1532881347;
					continue;
				case 3u:
					num = ((int)num2 * -643440241) ^ 0x5ED4978;
					continue;
				case 1u:
					result2 = result;
					num = (int)((num2 * 1627424982) ^ 0x1D347604);
					continue;
				case 2u:
					goto IL_006e;
				default:
					return result2;
				}
				break;
			}
			goto IL_0011;
			IL_0011:
			num = 1361243124;
			goto IL_0045;
		}
		set
		{
			while (true)
			{
				int num = 1220387444;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x70917ACBu) % 4u)
					{
					case 3u:
						Value = value.ToString();
						num = (int)(num2 * 995540656) ^ -808976591;
						continue;
					case 2u:
						num = (int)((num2 * 356728181) ^ 0x7187491C);
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

	public virtual float AsFloat
	{
		get
		{
			bool flag = default(bool);
			float result = default(float);
			float result2 = default(float);
			while (true)
			{
				int num = 1053855527;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4C362FF8u) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 769317615;
							num4 = 769317615;
						}
						else
						{
							num3 = 1796529999;
							num4 = 1796529999;
						}
						num = num3 ^ ((int)num2 * -150998403);
						continue;
					}
					case 5u:
						result = 0f;
						num = 1702541038;
						continue;
					case 3u:
						num = (int)(num2 * 888988878) ^ -364598602;
						continue;
					case 2u:
						result2 = 0f;
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = ((int)num2 * -1535700339) ^ 0x63CBA14E;
						continue;
					case 0u:
						result = result2;
						num = ((int)num2 * -784580487) ^ 0x7C71BEBA;
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
			while (true)
			{
				int num = 1169249739;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2B21E78Fu) % 3u)
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
					num = ((int)num2 * -1242737621) ^ 0x11D1E665;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			double result = default(double);
			bool flag = default(bool);
			while (true)
			{
				int num = -1306179991;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD3EA83A6u) % 8u)
					{
					case 7u:
						result2 = 0.0;
						num = ((int)num2 * -1302472479) ^ -68871871;
						continue;
					case 5u:
						result = 0.0;
						num = -1247354558;
						continue;
					case 4u:
						num = ((int)num2 * -1879758702) ^ -1224201483;
						continue;
					case 2u:
						result = result2;
						num = ((int)num2 * -944393465) ^ -1763238541;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 93200935;
							num4 = 93200935;
						}
						else
						{
							num3 = 398182744;
							num4 = 398182744;
						}
						num = num3 ^ ((int)num2 * -186542564);
						continue;
					}
					case 0u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -1408394156) ^ 0x5D92272F;
						continue;
					case 6u:
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
			bool flag = default(bool);
			bool result2 = default(bool);
			bool result = default(bool);
			while (true)
			{
				int num = -584089822;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC2EE9991u) % 8u)
					{
					case 5u:
						num = ((int)num2 * -361365877) ^ 0x5FF42358;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 505964548;
							num4 = 505964548;
						}
						else
						{
							num3 = 387922943;
							num4 = 387922943;
						}
						num = num3 ^ ((int)num2 * -34459013);
						continue;
					}
					case 3u:
						result2 = false;
						num = (int)(num2 * 540938786) ^ -266602785;
						continue;
					case 2u:
						result = !JSONNode.smethod_1(Value);
						num = -1722720012;
						continue;
					case 1u:
						result = result2;
						num = (int)(num2 * 2102904325) ^ -1399860038;
						continue;
					case 0u:
						flag = bool.TryParse(Value, out result2);
						num = (int)(num2 * 1857841742) ^ -484890995;
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
			Value = (value ? "true" : "false");
			while (true)
			{
				int num = -358975527;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8923DE3Cu) % 3u)
					{
					case 1u:
						goto IL_0017;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0017:
					num = (int)(num2 * 1061807459) ^ -673702398;
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
				int num = 1830027372;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x741DBE0Du) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1124311743) ^ 0x34CDC706);
						continue;
					case 1u:
						result = this as JSONArray;
						num = ((int)num2 * -826574428) ^ -1848125202;
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
				int num = -1818520672;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA0151CBAu) % 4u)
					{
					case 2u:
						result = this as JSONClass;
						num = ((int)num2 * -123559932) ^ 0x724B45D3;
						continue;
					case 1u:
						num = (int)(num2 * 1601390672) ^ -1460569254;
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
			int num = -1165023257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8361E47Au) % 4u)
				{
				case 2u:
					num = (int)((num2 * 2145223185) ^ 0x567339D3);
					continue;
				case 1u:
					Add("", aItem);
					num = (int)((num2 * 994580662) ^ 0x71CEAB3E);
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

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1110554012;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF8C89B95u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 2529581) ^ 0xF2AAB8);
					continue;
				case 1u:
					result = null;
					num = ((int)num2 * -559438608) ^ -1448110781;
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
		JSONNode result = null;
		while (true)
		{
			int num = 452561836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x104EFC0Fu) % 3u)
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
				num = ((int)num2 * -499170135) ^ 0x11185CC0;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -577792765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF9521C8u) % 4u)
				{
				case 3u:
					result = aNode;
					num = (int)((num2 * 2012112776) ^ 0x727398EA);
					continue;
				case 2u:
					num = ((int)num2 * -1568399236) ^ 0x16DE1EC5;
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
		string result = default(string);
		while (true)
		{
			int num = 694820837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FEB2890u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1748760246) ^ 0x2F6A3533;
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)((num2 * 443076462) ^ 0x5C77E59C);
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
			int num = -1290041307;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC95744Cu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1633279688) ^ -1493424038;
					continue;
				case 1u:
					result = "JSONNode";
					num = ((int)num2 * -1413539011) ^ -1095765858;
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

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -147460447;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4BC9330u) % 3u)
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
				num = ((int)num2 * -1400492853) ^ 0xA75582A;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		string result = default(string);
		while (true)
		{
			int num = -1031378970;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xDEE8B45Au) % 5u)
				{
				case 4u:
					obj = d.Value;
					goto IL_0009;
				case 2u:
					if (!(d == null))
					{
						num = ((int)num2 * -58974905) ^ -1642332574;
						continue;
					}
					obj = null;
					goto IL_0009;
				case 0u:
					num = ((int)num2 * -575984549) ^ -2095098082;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = -1710953625;
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
		goto IL_00a7;
		IL_009e:
		num = ((a is JSONLazyCreator) ? 1 : 0);
		goto IL_00a7;
		IL_0035:
		int num2 = -816940951;
		goto IL_006d;
		IL_006d:
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0xA995ACF0u) % 8u)
			{
			case 6u:
				num2 = ((int)num3 * -1813271498) ^ 0x789C16B;
				continue;
			case 5u:
				result = true;
				num2 = ((int)num3 * -631004692) ^ -1444287854;
				continue;
			case 4u:
				result = (object)a == b;
				num2 = -1691099616;
				continue;
			case 3u:
				break;
			case 2u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1131978511;
					num5 = -1131978511;
				}
				else
				{
					num4 = -1072772504;
					num5 = -1072772504;
				}
				num2 = num4 ^ (int)(num3 * 1567812046);
				continue;
			}
			case 0u:
				num2 = (int)((num3 * 614565720) ^ 0xD76A43F);
				continue;
			case 1u:
				goto IL_009e;
			default:
				return result;
			}
			break;
		}
		goto IL_0035;
		IL_00a7:
		flag = (byte)num != 0;
		num2 = -970936558;
		goto IL_006d;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1491755992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD83EC054u) % 3u)
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
				num = ((int)num2 * -771272640) ^ 0x1ABE1E52;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1094016954;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A39C079u) % 3u)
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
				num = (int)((num2 * 1547331791) ^ 0x745680C);
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = -1941390181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86B0732Cu) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = (int)(num2 * 647914703) ^ -1375636248;
					continue;
				case 1u:
					num = (int)((num2 * 490346748) ^ 0x34765466);
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
		int num3 = default(int);
		string result = default(string);
		char c2 = default(char);
		char c3 = default(char);
		string string_ = default(string);
		char c = default(char);
		while (true)
		{
			int num = -1419346062;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD31BE98u) % 26u)
				{
				case 25u:
					num = ((int)num2 * -2022802141) ^ -522227150;
					continue;
				case 24u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -985531101;
					continue;
				case 23u:
					text = JSONNode.smethod_3(text, "\\b");
					num = -551885917;
					continue;
				case 21u:
					num = ((int)num2 * -2035868194) ^ -1126717847;
					continue;
				case 20u:
					num = (int)((num2 * 1488467605) ^ 0x7EECA497);
					continue;
				case 19u:
					num3++;
					num = -1955846936;
					continue;
				case 18u:
					result = text;
					num = (int)((num2 * 793832474) ^ 0x234C07B6);
					continue;
				case 17u:
				{
					int num6;
					if (c2 != '\\')
					{
						num = -1798357903;
						num6 = -1798357903;
					}
					else
					{
						num = -1646704725;
						num6 = -1646704725;
					}
					continue;
				}
				case 16u:
					num = ((int)num2 * -58071770) ^ 0x4995DC4E;
					continue;
				case 15u:
					goto IL_00c4;
				case 14u:
					goto IL_00dc;
				case 13u:
					num = ((int)num2 * -1239063089) ^ 0x2CCA166E;
					continue;
				case 12u:
					goto IL_0105;
				case 11u:
					c3 = JSONNode.smethod_2(string_, num3);
					c = c3;
					num = -1781499827;
					continue;
				case 10u:
				{
					int num5;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = -458559362;
						num5 = -458559362;
					}
					else
					{
						num = -889968133;
						num5 = -889968133;
					}
					continue;
				}
				case 9u:
					num = ((int)num2 * -946694540) ^ -1521251585;
					continue;
				case 7u:
				{
					int num4;
					if (c2 == '"')
					{
						num = -1264839474;
						num4 = -1264839474;
					}
					else
					{
						num = -1412611230;
						num4 = -1412611230;
					}
					continue;
				}
				case 6u:
					goto IL_018a;
				case 5u:
					c2 = c;
					switch (c2)
					{
					case '\b':
						break;
					case '\v':
						goto IL_00c4;
					case '\t':
						goto IL_00dc;
					case '\f':
						goto IL_0105;
					case '\n':
						goto IL_018a;
					default:
						goto IL_01c5;
					case '\r':
						goto IL_01d5;
					}
					goto case 23u;
				case 0u:
					goto IL_01d5;
				case 4u:
					text = "";
					string_ = aText;
					num3 = 0;
					num = (int)((num2 * 1624302021) ^ 0x6A7AC7FA);
					continue;
				case 3u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -551885917;
					continue;
				case 2u:
					num = (int)(num2 * 1037397939) ^ -952257661;
					continue;
				case 1u:
					num = (int)(num2 * 1379377369) ^ -514553236;
					continue;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_01d5:
					text = JSONNode.smethod_3(text, "\\r");
					num = -722873541;
					continue;
					IL_01c5:
					num = ((int)num2 * -1963466050) ^ 0xDB5A3C7;
					continue;
					IL_018a:
					text = JSONNode.smethod_3(text, "\\n");
					num = -1157945061;
					continue;
					IL_0105:
					text = JSONNode.smethod_3(text, "\\f");
					num = -551885917;
					continue;
					IL_00dc:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1831247876;
					continue;
					IL_00c4:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -551885917;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		char c = default(char);
		bool flag6 = default(bool);
		int num12 = default(int);
		char c2 = default(char);
		bool flag3 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag17 = default(bool);
		string text = default(string);
		string text2 = default(string);
		bool flag13 = default(bool);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		bool flag2 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		char c3 = default(char);
		bool flag14 = default(bool);
		bool flag9 = default(bool);
		bool flag15 = default(bool);
		bool flag11 = default(bool);
		bool flag16 = default(bool);
		bool flag12 = default(bool);
		bool flag = default(bool);
		bool flag8 = default(bool);
		while (true)
		{
			int num = 1281760208;
			while (true)
			{
				uint num2;
				int num36;
				int num39;
				switch ((num2 = (uint)num ^ 0x7C31AE9u) % 156u)
				{
				case 155u:
					flag5 = flag4;
					num = 1962079673;
					continue;
				case 154u:
				{
					int num6;
					if (c != 'f')
					{
						num = 2119851683;
						num6 = 2119851683;
					}
					else
					{
						num = 1242990618;
						num6 = 1242990618;
					}
					continue;
				}
				case 153u:
					num = ((int)num2 * -965767436) ^ 0x63D695DD;
					continue;
				case 152u:
					flag4 = false;
					num = ((int)num2 * -1974340761) ^ -269166836;
					continue;
				case 151u:
					num = (int)(num2 * 1880919917) ^ -532885949;
					continue;
				case 150u:
					num = (int)(num2 * 1880371132) ^ -1958795993;
					continue;
				case 148u:
					flag6 = num12 < JSONNode.smethod_4(aJSON);
					num = 800060562;
					continue;
				case 147u:
					num = (int)((num2 * 255484961) ^ 0x40D4C42);
					continue;
				case 146u:
				{
					int num5;
					if (c != 'n')
					{
						num = 204206610;
						num5 = 204206610;
					}
					else
					{
						num = 989300372;
						num5 = 989300372;
					}
					continue;
				}
				case 145u:
					switch (c2)
					{
					case '\t':
						break;
					default:
						goto IL_00ed;
					case '\v':
					case '\f':
						goto IL_0100;
					case '\n':
					case '\r':
						goto IL_0121;
					}
					goto case 155u;
				case 41u:
					goto IL_0100;
				case 18u:
				case 46u:
				case 66u:
				case 116u:
				case 125u:
					goto IL_0121;
				case 144u:
					num = 690176542;
					continue;
				case 143u:
					flag3 = jSONNode is JSONArray;
					num = ((int)num2 * -629277291) ^ -687642967;
					continue;
				case 142u:
					flag17 = JSONNode.smethod_6(text, "");
					num = (int)((num2 * 527433132) ^ 0x731965F);
					continue;
				case 141u:
					num = ((int)num2 * -1866329008) ^ 0x423726EC;
					continue;
				case 140u:
				{
					int num49;
					if (c2 != '}')
					{
						num = 1325766074;
						num49 = 1325766074;
					}
					else
					{
						num = 1571501777;
						num49 = 1571501777;
					}
					continue;
				}
				case 139u:
					text = JSONNode.smethod_3(text, "\r");
					num = 850562470;
					continue;
				case 138u:
					text2 = text;
					num = 1277034600;
					continue;
				case 137u:
					jSONNode.Add(text);
					num = ((int)num2 * -1457672686) ^ 0x32B953E8;
					continue;
				case 136u:
					num = ((int)num2 * -1771974135) ^ -911877771;
					continue;
				case 135u:
				{
					int num28;
					int num29;
					if (flag13)
					{
						num28 = -710432279;
						num29 = -710432279;
					}
					else
					{
						num28 = -1277493886;
						num29 = -1277493886;
					}
					num = num28 ^ ((int)num2 * -140920841);
					continue;
				}
				case 134u:
					stack.Push(new JSONClass());
					num = 1407019350;
					continue;
				case 133u:
					stack.Pop();
					num = 531906063;
					continue;
				case 132u:
				{
					int num15;
					if (c2 == ',')
					{
						num = 642153965;
						num15 = 642153965;
					}
					else
					{
						num = 1978158270;
						num15 = 1978158270;
					}
					continue;
				}
				case 131u:
				{
					int num10;
					int num11;
					if (flag2)
					{
						num10 = 773750683;
						num11 = 773750683;
					}
					else
					{
						num10 = 2055228824;
						num11 = 2055228824;
					}
					num = num10 ^ ((int)num2 * -378296533);
					continue;
				}
				case 130u:
					num = (int)(num2 * 71553927) ^ -2114585341;
					continue;
				case 129u:
					text = "";
					text2 = "";
					num = (int)(num2 * 812218354) ^ -54928557;
					continue;
				case 128u:
					result = jSONNode;
					num = 383435292;
					continue;
				case 127u:
				{
					int num59;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 52645225;
						num59 = 52645225;
					}
					else
					{
						num = 1464801808;
						num59 = 1464801808;
					}
					continue;
				}
				case 126u:
				{
					int num56;
					if (flag4)
					{
						num = 1714845643;
						num56 = 1714845643;
					}
					else
					{
						num = 57343403;
						num56 = 57343403;
					}
					continue;
				}
				case 124u:
				{
					int num50;
					int num51;
					if ((uint)c2 > 32u)
					{
						num50 = -917316613;
						num51 = -917316613;
					}
					else
					{
						num50 = -125945176;
						num51 = -125945176;
					}
					num = num50 ^ ((int)num2 * -390410801);
					continue;
				}
				case 123u:
				{
					int num45;
					int num46;
					if (c != 'b')
					{
						num45 = -1065241903;
						num46 = -1065241903;
					}
					else
					{
						num45 = -410955194;
						num46 = -410955194;
					}
					num = num45 ^ ((int)num2 * -73480771);
					continue;
				}
				case 122u:
					num = ((int)num2 * -985714413) ^ 0x2A8D78BB;
					continue;
				case 121u:
					text = JSONNode.smethod_3(text, "\n");
					num = 1969860072;
					continue;
				case 120u:
					goto IL_03a4;
				case 119u:
					text2 = "";
					text = "";
					num = 1360470911;
					continue;
				case 118u:
					num = (int)((num2 * 1050681035) ^ 0x74B39FCF);
					continue;
				case 117u:
					switch (c2)
					{
					case '[':
						goto IL_0404;
					case '\\':
						goto IL_0424;
					case ']':
						goto IL_0436;
					}
					num = 535682979;
					continue;
				case 40u:
					goto IL_0404;
				case 1u:
					goto IL_0424;
				case 48u:
					goto IL_0436;
				case 115u:
					text = JSONNode.smethod_3(text, "\f");
					num = 2020699945;
					continue;
				case 114u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 799945338) ^ -485827637;
					continue;
				case 113u:
					num = ((int)num2 * -1168183866) ^ -1666254155;
					continue;
				case 112u:
					num = ((int)num2 * -1664052555) ^ 0x444AFEA5;
					continue;
				case 111u:
					num = (int)((num2 * 814858416) ^ 0x604D782F);
					continue;
				case 110u:
				{
					int num25;
					int num26;
					if (flag10)
					{
						num25 = -1226158933;
						num26 = -1226158933;
					}
					else
					{
						num25 = -102323350;
						num26 = -102323350;
					}
					num = num25 ^ (int)(num2 * 1745721559);
					continue;
				}
				case 109u:
					text2 = JSONNode.smethod_5(text2);
					flag10 = jSONNode is JSONArray;
					num = ((int)num2 * -1724131070) ^ 0x6AC28AA9;
					continue;
				case 108u:
				{
					int num19;
					int num20;
					if (flag7)
					{
						num19 = -538064476;
						num20 = -538064476;
					}
					else
					{
						num19 = -1440202829;
						num20 = -1440202829;
					}
					num = num19 ^ (int)(num2 * 1538695999);
					continue;
				}
				case 107u:
				{
					int num16;
					int num17;
					if (flag6)
					{
						num16 = -1789542479;
						num17 = -1789542479;
					}
					else
					{
						num16 = -161164159;
						num17 = -161164159;
					}
					num = num16 ^ (int)(num2 * 841338170);
					continue;
				}
				case 106u:
					num = (int)((num2 * 148212642) ^ 0x3963BD51);
					continue;
				case 105u:
				{
					int num7;
					int num8;
					if (!(jSONNode != null))
					{
						num7 = -2020716639;
						num8 = -2020716639;
					}
					else
					{
						num7 = -1962554889;
						num8 = -1962554889;
					}
					num = num7 ^ (int)(num2 * 614289219);
					continue;
				}
				case 104u:
					c3 = JSONNode.smethod_2(aJSON, num12);
					num = (int)(num2 * 1737426991) ^ -1355457730;
					continue;
				case 103u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)(num2 * 1619465869) ^ -1573845872;
					continue;
				case 102u:
					flag14 = jSONNode is JSONArray;
					num = (int)(num2 * 1533719957) ^ -1911184745;
					continue;
				case 101u:
					stack.Push(new JSONArray());
					num = 2031862120;
					continue;
				case 100u:
					num = ((int)num2 * -48465275) ^ -413082523;
					continue;
				case 99u:
					num = (int)(num2 * 1554336093) ^ -1447772414;
					continue;
				case 98u:
					num = (int)((num2 * 1981506658) ^ 0x7254C340);
					continue;
				case 97u:
					num = ((int)num2 * -1829563339) ^ -785284972;
					continue;
				case 96u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)(num2 * 284142839) ^ -318441865;
					continue;
				case 95u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -939427399) ^ -1660581231;
					continue;
				case 94u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -390152979) ^ -1139518928;
					continue;
				case 93u:
				{
					int num60;
					int num61;
					if (c2 != ':')
					{
						num60 = -1153554321;
						num61 = -1153554321;
					}
					else
					{
						num60 = -1185753341;
						num61 = -1185753341;
					}
					num = num60 ^ ((int)num2 * -319653001);
					continue;
				}
				case 92u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 1491272974) ^ 0x21BFFBD7);
					continue;
				case 91u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1995382466) ^ -1193038486;
					continue;
				case 90u:
					num = ((int)num2 * -1865188316) ^ -1269824735;
					continue;
				case 89u:
					flag9 = jSONNode is JSONArray;
					num = (int)(num2 * 2058227662) ^ -2120343074;
					continue;
				case 88u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 958497247) ^ -754837799;
					continue;
				case 87u:
					num = ((int)num2 * -2000783410) ^ 0x656BE015;
					continue;
				case 86u:
					flag2 = jSONNode != null;
					num = (int)((num2 * 1739372136) ^ 0x36FDC2E);
					continue;
				case 85u:
					num = ((int)num2 * -1449200602) ^ -1846661005;
					continue;
				case 84u:
					num = ((int)num2 * -1089891489) ^ 0x560EA783;
					continue;
				case 83u:
				{
					int num57;
					int num58;
					if ((uint)c > 102u)
					{
						num57 = 325137720;
						num58 = 325137720;
					}
					else
					{
						num57 = 970230169;
						num58 = 970230169;
					}
					num = num57 ^ (int)(num2 * 1898422421);
					continue;
				}
				case 82u:
					num = 462882013;
					continue;
				case 81u:
					goto IL_0818;
				case 80u:
					flag4 = !flag4;
					num = 944844105;
					continue;
				case 78u:
				{
					int num54;
					int num55;
					if (flag17)
					{
						num54 = 863052974;
						num55 = 863052974;
					}
					else
					{
						num54 = 32485392;
						num55 = 32485392;
					}
					num = num54 ^ (int)(num2 * 600030533);
					continue;
				}
				case 77u:
					flag15 = JSONNode.smethod_6(text2, "");
					num = 250876990;
					continue;
				case 76u:
					goto IL_0874;
				case 75u:
					num = (int)(num2 * 1361457291) ^ -1112237876;
					continue;
				case 74u:
					num = (int)(num2 * 1496927926) ^ -679074559;
					continue;
				case 73u:
					num = 320866982;
					continue;
				case 72u:
					switch (c)
					{
					case 'r':
						break;
					case 't':
						goto IL_03a4;
					case 'u':
						goto IL_0818;
					case 's':
						goto IL_0874;
					default:
						goto IL_08d6;
					}
					goto case 139u;
				case 71u:
					num = ((int)num2 * -1171113292) ^ 0x6634DB0;
					continue;
				case 70u:
				{
					int num52;
					int num53;
					if (!flag11)
					{
						num52 = -991376223;
						num53 = -991376223;
					}
					else
					{
						num52 = -1874943813;
						num53 = -1874943813;
					}
					num = num52 ^ ((int)num2 * -2010369450);
					continue;
				}
				case 69u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 380335662) ^ 0x6B8861FD);
					continue;
				case 68u:
					num = 1882261093;
					continue;
				case 67u:
				{
					int num48;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1517771645;
						num48 = 1517771645;
					}
					else
					{
						num = 1022854114;
						num48 = 1022854114;
					}
					continue;
				}
				case 65u:
				{
					int num47;
					if (c2 == ' ')
					{
						num = 665818242;
						num47 = 665818242;
					}
					else
					{
						num = 1841635300;
						num47 = 1841635300;
					}
					continue;
				}
				case 64u:
					num = (int)((num2 * 1960690486) ^ 0x1F41B8BF);
					continue;
				case 63u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = ((int)num2 * -810823883) ^ -1048240316;
					continue;
				case 62u:
				{
					int num44;
					if (c2 == '"')
					{
						num = 715241901;
						num44 = 715241901;
					}
					else
					{
						num = 1577479115;
						num44 = 1577479115;
					}
					continue;
				}
				case 61u:
					text = "";
					num = (int)(num2 * 1174247405) ^ -1608767557;
					continue;
				case 60u:
					num = ((int)num2 * -1126770512) ^ -1523669371;
					continue;
				case 59u:
					num = (int)(num2 * 1626366193) ^ -32543246;
					continue;
				case 58u:
					num = ((int)num2 * -1367736480) ^ 0x5A2DC350;
					continue;
				case 57u:
					num = (int)(num2 * 729224864) ^ -1459692787;
					continue;
				case 56u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num12);
					c2 = c5;
					int num42;
					int num43;
					if ((uint)c2 > 44u)
					{
						num42 = 2001870155;
						num43 = 2001870155;
					}
					else
					{
						num42 = 784403917;
						num43 = 784403917;
					}
					num = num42 ^ (int)(num2 * 1503975144);
					continue;
				}
				case 54u:
					jSONNode.Add(text);
					num = ((int)num2 * -869155678) ^ -2091042332;
					continue;
				case 53u:
				{
					int num40;
					int num41;
					if (flag16)
					{
						num40 = -193299076;
						num41 = -193299076;
					}
					else
					{
						num40 = -1540125527;
						num41 = -1540125527;
					}
					num = num40 ^ (int)(num2 * 818538197);
					continue;
				}
				case 52u:
				{
					int num37;
					int num38;
					if (flag12)
					{
						num37 = -1415029886;
						num38 = -1415029886;
					}
					else
					{
						num37 = -564177740;
						num38 = -564177740;
					}
					num = num37 ^ (int)(num2 * 132382381);
					continue;
				}
				case 51u:
					num = (int)((num2 * 320112644) ^ 0x1C53C48);
					continue;
				case 50u:
					flag = JSONNode.smethod_6(text2, "");
					num = 290020575;
					continue;
				case 49u:
					num = (int)(num2 * 1053697502) ^ -1142491905;
					continue;
				case 47u:
				{
					int num34;
					int num35;
					if (!flag15)
					{
						num34 = -38141546;
						num35 = -38141546;
					}
					else
					{
						num34 = -1605695319;
						num35 = -1605695319;
					}
					num = num34 ^ (int)(num2 * 321224849);
					continue;
				}
				case 45u:
					flag13 = flag4;
					num = 483999514;
					continue;
				case 44u:
					num = 1729433186;
					continue;
				case 43u:
					text2 = "";
					num = 1742053053;
					continue;
				case 42u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 860860525) ^ 0x3C10D01C);
					continue;
				case 39u:
					num = ((int)num2 * -1151905162) ^ -1037447594;
					continue;
				case 38u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = ((int)num2 * -1419971055) ^ 0x7034F60F;
					continue;
				case 37u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 605518236) ^ -307791228;
					continue;
				case 36u:
				{
					int num32;
					int num33;
					if (!flag5)
					{
						num32 = 145389513;
						num33 = 145389513;
					}
					else
					{
						num32 = 971907727;
						num33 = 971907727;
					}
					num = num32 ^ ((int)num2 * -2094371327);
					continue;
				}
				case 35u:
					num = ((int)num2 * -165374252) ^ 0x6B0DDDCF;
					continue;
				case 34u:
					num = ((int)num2 * -46031872) ^ 0x1007009E;
					continue;
				case 33u:
					flag8 = JSONNode.smethod_6(text, "");
					num = 2122873929;
					continue;
				case 32u:
				{
					int num30;
					int num31;
					if (flag14)
					{
						num30 = 2042654584;
						num31 = 2042654584;
					}
					else
					{
						num30 = 279722542;
						num31 = 279722542;
					}
					num = num30 ^ ((int)num2 * -638816431);
					continue;
				}
				case 31u:
				{
					char c4 = c3;
					c = c4;
					num = (int)((num2 * 2105677014) ^ 0x258660F4);
					continue;
				}
				case 29u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 861390334) ^ 0xF5CD0F1);
					continue;
				case 28u:
					text2 = "";
					text = "";
					num = 1047628752;
					continue;
				case 27u:
					text2 = "";
					num = 74582654;
					continue;
				case 26u:
				{
					int num27;
					if ((uint)c2 > 93u)
					{
						num = 238714789;
						num27 = 238714789;
					}
					else
					{
						num = 575998996;
						num27 = 575998996;
					}
					continue;
				}
				case 25u:
					stack = new Stack<JSONNode>();
					jSONNode = null;
					num12 = 0;
					num = ((int)num2 * -555977940) ^ -1892284280;
					continue;
				case 24u:
					flag12 = flag4;
					num = 152138121;
					continue;
				case 23u:
					text = "";
					flag7 = stack.Count > 0;
					num = ((int)num2 * -2072698489) ^ 0x7D236850;
					continue;
				case 22u:
					flag11 = flag4;
					num = (int)(num2 * 728439145) ^ -1071580259;
					continue;
				case 21u:
				{
					int num23;
					int num24;
					if (flag9)
					{
						num23 = 331096027;
						num24 = 331096027;
					}
					else
					{
						num23 = 703668159;
						num24 = 703668159;
					}
					num = num23 ^ (int)(num2 * 1029499288);
					continue;
				}
				case 20u:
				{
					int num21;
					int num22;
					if (flag8)
					{
						num21 = -1342394769;
						num22 = -1342394769;
					}
					else
					{
						num21 = -127166530;
						num22 = -127166530;
					}
					num = num21 ^ ((int)num2 * -1759038311);
					continue;
				}
				case 19u:
					num = ((int)num2 * -123154417) ^ -1868726134;
					continue;
				case 17u:
					num = (int)((num2 * 852175543) ^ 0x4BD983C9);
					continue;
				case 16u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = (int)((num2 * 413937816) ^ 0x69537DBF);
					continue;
				case 15u:
					num = ((int)num2 * -1400257525) ^ -257573966;
					continue;
				case 14u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = ((int)num2 * -879901223) ^ -136989508;
					continue;
				case 13u:
					num = (int)((num2 * 550316584) ^ 0x3ABF411C);
					continue;
				case 12u:
				{
					int num18;
					if (c2 != '{')
					{
						num = 759683339;
						num18 = 759683339;
					}
					else
					{
						num = 76930247;
						num18 = 76930247;
					}
					continue;
				}
				case 11u:
				{
					int num13;
					int num14;
					if (flag3)
					{
						num13 = -66690926;
						num14 = -66690926;
					}
					else
					{
						num13 = -1005767649;
						num14 = -1005767649;
					}
					num = num13 ^ ((int)num2 * -249944325);
					continue;
				}
				case 10u:
				{
					string s = JSONNode.smethod_8(aJSON, num12 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num12 += 4;
					num = ((int)num2 * -219446063) ^ 0x4986C78F;
					continue;
				}
				case 9u:
					num = (int)(num2 * 1202655907) ^ -650165666;
					continue;
				case 8u:
					num = 1926075780;
					continue;
				case 7u:
					num = ((int)num2 * -2070060957) ^ 0x1EE83E87;
					continue;
				case 6u:
					num = ((int)num2 * -1735717088) ^ -1697404448;
					continue;
				case 5u:
				{
					int num9;
					if (stack.Count != 0)
					{
						num = 153850320;
						num9 = 153850320;
					}
					else
					{
						num = 494305487;
						num9 = 494305487;
					}
					continue;
				}
				case 4u:
					text = "";
					num = (int)((num2 * 1386652124) ^ 0x73B259BB);
					continue;
				case 3u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -65067177) ^ 0x33B74B11;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 36274214;
						num4 = 36274214;
					}
					else
					{
						num3 = 1254661433;
						num4 = 1254661433;
					}
					num = num3 ^ ((int)num2 * -1560508738);
					continue;
				}
				case 0u:
					text = JSONNode.smethod_3(text, "\b");
					num = 154570549;
					continue;
				case 79u:
					break;
				case 30u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 55u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_00ed:
					num = (int)(num2 * 239093753) ^ -731126034;
					continue;
					IL_0436:
					if (!flag4)
					{
						num = 142124708;
						num36 = 142124708;
					}
					else
					{
						num = 764314158;
						num36 = 764314158;
					}
					continue;
					IL_0404:
					if (!flag4)
					{
						num = 1763546252;
						num39 = 1763546252;
					}
					else
					{
						num = 285728740;
						num39 = 285728740;
					}
					continue;
					IL_0424:
					num12++;
					flag16 = flag4;
					num = 2111790608;
					continue;
					IL_03a4:
					text = JSONNode.smethod_3(text, "\t");
					num = 1890758805;
					continue;
					IL_08d6:
					num = 424802197;
					continue;
					IL_0874:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = 1961696155;
					continue;
					IL_0818:
					num = 298100015;
					continue;
					IL_0121:
					num12++;
					num = 2117055213;
					continue;
					IL_0100:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num12).ToString());
					num = 1360470911;
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
			int num = 1366852087;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62D2FA5Du) % 5u)
				{
				case 4u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -286960284) ^ 0x65F623CF;
					continue;
				case 3u:
					num = (int)((num2 * 1251104226) ^ 0x41308AEB);
					continue;
				case 2u:
					Serialize(aWriter);
					num = ((int)num2 * -159112605) ^ 0x72E6A26C;
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
			int num = -1658838426;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A45C6F2u) % 3u)
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
						SaveToStream(fileStream);
						return;
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00a2:
								int num3 = -188762739;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x9A45C6F2u) % 4u)
									{
									case 3u:
										JSONNode.smethod_15((IDisposable)fileStream);
										num3 = ((int)num2 * -342726635) ^ -158839981;
										continue;
									case 2u:
										num3 = ((int)num2 * -1939797476) ^ 0x74E90BD7;
										continue;
									default:
										goto end_IL_0081;
									case 0u:
										break;
									case 1u:
										goto end_IL_0081;
									}
									goto IL_00a2;
									continue;
									end_IL_0081:
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
				num = ((int)num2 * -76626850) ^ -1101728515;
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
				int num = -1501661276;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF3898B9Du) % 4u)
					{
					case 2u:
						num = ((int)num2 * -767408229) ^ 0x3370AFC8;
						continue;
					case 1u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)(num2 * 2008698115) ^ -312632764;
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
					IL_00a5:
					int num3 = -1703573550;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xF3898B9Du) % 3u)
						{
						case 1u:
							goto IL_0075;
						default:
							goto end_IL_0088;
						case 2u:
							break;
						case 0u:
							goto end_IL_0088;
						}
						goto IL_00a5;
						IL_0075:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = (int)((num2 * 1536002251) ^ 0x5AE5C79A);
						continue;
						end_IL_0088:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		int num5 = default(int);
		int num6 = default(int);
		JSONNode result = default(JSONNode);
		int num9 = default(int);
		JSONClass jSONClass = default(JSONClass);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONArray jSONArray = default(JSONArray);
		JSONNode aItem = default(JSONNode);
		string aKey = default(string);
		bool flag = default(bool);
		int num7 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		while (true)
		{
			int num = 2117473693;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2ECA76B3u) % 38u)
				{
				case 37u:
					num5 = 0;
					num = (int)((num2 * 1154037284) ^ 0x74C399AD);
					continue;
				case 35u:
					num6++;
					num = ((int)num2 * -944955462) ^ -3083727;
					continue;
				case 34u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 1772652489) ^ 0x1F365F87);
					continue;
				case 33u:
					num = ((int)num2 * -1272855356) ^ -364142124;
					continue;
				case 32u:
					num = 1829765566;
					continue;
				case 31u:
					goto IL_0072;
				case 30u:
					num = 1870856962;
					continue;
				case 29u:
					goto IL_0086;
				case 28u:
					num = (int)(num2 * 2134697767) ^ -1241990949;
					continue;
				case 26u:
					num6 = 0;
					num = (int)(num2 * 1862649439) ^ -606852355;
					continue;
				case 25u:
					num9 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = (int)(num2 * 1028349308) ^ -2105067268;
					continue;
				case 24u:
					num = ((int)num2 * -2076026009) ^ -681091226;
					continue;
				case 23u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.IntValue:
						goto IL_0072;
					case JSONBinaryTag.FloatValue:
						goto IL_0086;
					default:
						goto IL_0121;
					case JSONBinaryTag.Array:
						goto IL_0134;
					case JSONBinaryTag.Class:
						goto IL_014c;
					case JSONBinaryTag.Value:
						goto IL_0156;
					case JSONBinaryTag.BoolValue:
						goto IL_016d;
					}
					goto case 32u;
				case 3u:
					goto IL_0134;
				case 15u:
					goto IL_014c;
				case 19u:
					goto IL_0156;
				case 12u:
					goto IL_016d;
				case 22u:
					result = jSONArray;
					num = (int)((num2 * 598968692) ^ 0x5A746D28);
					continue;
				case 21u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = (int)(num2 * 1303081307) ^ -756970286;
					continue;
				case 20u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -1207514812) ^ -1232466755;
					continue;
				case 18u:
					jSONArray.Add(Deserialize(aReader));
					num = 223181806;
					continue;
				case 17u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 1499205603) ^ 0x1308EC38);
					continue;
				case 16u:
					flag = num5 < num9;
					num = 1021043769;
					continue;
				case 14u:
				{
					int num8;
					if (num6 >= num7)
					{
						num = 2037740101;
						num8 = 2037740101;
					}
					else
					{
						num = 826982003;
						num8 = 826982003;
					}
					continue;
				}
				case 13u:
					num5++;
					num = ((int)num2 * -2059393337) ^ -719835670;
					continue;
				case 11u:
					num = ((int)num2 * -1042904806) ^ 0x5230FA5E;
					continue;
				case 10u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -331751614;
						num4 = -331751614;
					}
					else
					{
						num3 = -354536139;
						num4 = -354536139;
					}
					num = num3 ^ (int)(num2 * 146247057);
					continue;
				}
				case 9u:
					num = ((int)num2 * -755412298) ^ -137568930;
					continue;
				case 7u:
					num = ((int)num2 * -1522290247) ^ 0x26C6C675;
					continue;
				case 6u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 427684448) ^ -2044763231;
					continue;
				case 5u:
					num = ((int)num2 * -1256618206) ^ -1347632717;
					continue;
				case 4u:
					num = ((int)num2 * -1464355355) ^ 0x3944EAB4;
					continue;
				case 2u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = ((int)num2 * -915469950) ^ 0x14F5298A;
					continue;
				case 1u:
					result = jSONClass;
					num = (int)((num2 * 149544413) ^ 0x47227D8D);
					continue;
				case 0u:
					num = (int)(num2 * 1069631916) ^ -1907326728;
					continue;
				case 8u:
					break;
				case 36u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_016d:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = 1279494224;
					continue;
					IL_0156:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = 503845758;
					continue;
					IL_014c:
					num = 197502148;
					continue;
					IL_0134:
					num7 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = 1968474429;
					continue;
					IL_0121:
					num = ((int)num2 * -1493221314) ^ 0x2672C2E6;
					continue;
					IL_0086:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = 149800528;
					continue;
					IL_0072:
					num = 596090701;
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
					int num = -892053013;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xA2D7088Au) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -481679158) ^ -469712336;
							continue;
						case 0u:
							num = (int)(num2 * 2023231554) ^ -798430211;
							continue;
						default:
							goto end_IL_0037;
						case 2u:
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
					int num = -481284536;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xD7EF46A5u) % 4u)
						{
						case 2u:
							num = (int)(num2 * 1204003886) ^ -2137485431;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num = (int)((num2 * 34802) ^ 0x5C03AC5);
							continue;
						default:
							goto end_IL_0037;
						case 3u:
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
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 228930002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x66A533C3u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -375883127) ^ -1571849804;
					continue;
				case 4u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)((num2 * 1642694899) ^ 0x4CA23DE0);
					continue;
				case 3u:
				{
					byte[] byte_ = JSONNode.smethod_28(aBase64);
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -79621897) ^ 0x484A1A86;
					continue;
				}
				case 1u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 1774260180) ^ 0x7727D57E);
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
