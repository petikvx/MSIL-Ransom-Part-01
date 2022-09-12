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
				int num = -307154935;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4857754u) % 3u)
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
					num = (int)((num2 * 1084825866) ^ 0x283C78D3);
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
			return null;
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
				int num = 971289420;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6F2E80CEu) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1734759207) ^ -918294944;
						continue;
					case 2u:
						result = "";
						num = ((int)num2 * -709467021) ^ -1839677077;
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
				int num = -1619893395;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF1B6B996u) % 4u)
					{
					case 3u:
						result = 0;
						num = ((int)num2 * -330007133) ^ 0x5FF0A046;
						continue;
					case 1u:
						num = (int)((num2 * 318333407) ^ 0x70223A5B);
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
				int num = 1408236219;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29AC9F0Du) % 4u)
					{
					case 2u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 2137946609) ^ -7482338;
						continue;
					case 1u:
						result = _003Cget_Childs_003Ed__;
						num = (int)((num2 * 1893433547) ^ 0x2B0CBC21);
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
			bool flag = default(bool);
			int result = default(int);
			int result2 = default(int);
			while (true)
			{
				int num = 390603982;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x78413B85u) % 8u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1212711710;
							num4 = -1212711710;
						}
						else
						{
							num3 = -1174947569;
							num4 = -1174947569;
						}
						num = num3 ^ ((int)num2 * -894200747);
						continue;
					}
					case 5u:
						num = ((int)num2 * -298363142) ^ -1458284209;
						continue;
					case 4u:
						result = result2;
						num = (int)(num2 * 1288233517) ^ -318638012;
						continue;
					case 3u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = ((int)num2 * -93446164) ^ 0x180EBC1F;
						continue;
					case 2u:
						num = ((int)num2 * -1682785442) ^ -2021655407;
						continue;
					case 1u:
						result = 0;
						num = 1503952591;
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
			Value = value.ToString();
			while (true)
			{
				int num = 1632359320;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD9CD70u) % 3u)
					{
					case 1u:
						goto IL_000f;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_000f:
					num = ((int)num2 * -1393562743) ^ 0x34CE407A;
				}
			}
		}
	}

	public virtual float AsFloat
	{
		get
		{
			float result = 0f;
			bool flag = default(bool);
			float result2 = default(float);
			while (true)
			{
				int num = -781828862;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD40A461Bu) % 7u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1551540559;
							num4 = 1551540559;
						}
						else
						{
							num3 = 1102255543;
							num4 = 1102255543;
						}
						num = num3 ^ ((int)num2 * -2122630550);
						continue;
					}
					case 3u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result);
						num = (int)(num2 * 1346282736) ^ -1174402063;
						continue;
					case 2u:
						result2 = result;
						num = ((int)num2 * -1269148824) ^ 0x21D14B8F;
						continue;
					case 1u:
						result2 = 0f;
						num = -1143298218;
						continue;
					case 0u:
						num = ((int)num2 * -1311194409) ^ -206400422;
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
			while (true)
			{
				int num = 2020212384;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6B318414u) % 3u)
					{
					case 1u:
						goto IL_000f;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000f:
					num = (int)(num2 * 28823785) ^ -1090052186;
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
				int num = -967201935;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB452B7FFu) % 7u)
					{
					case 6u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1210361282;
							num4 = -1210361282;
						}
						else
						{
							num3 = -247122906;
							num4 = -247122906;
						}
						num = num3 ^ (int)(num2 * 2019027221);
						continue;
					}
					case 5u:
						result2 = 0.0;
						num = (int)(num2 * 873703117) ^ -742200232;
						continue;
					case 4u:
						flag = double.TryParse(Value, out result2);
						num = ((int)num2 * -1854326906) ^ -1637546640;
						continue;
					case 2u:
						result = result2;
						num = (int)((num2 * 863954027) ^ 0x42635D30);
						continue;
					case 1u:
						result = 0.0;
						num = -2011726244;
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
				int num = 327684729;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5F59E3E8u) % 3u)
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
					num = ((int)num2 * -723627559) ^ 0x6DCCAE6E;
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
				int num = 1885904050;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6AAC11BFu) % 7u)
					{
					case 6u:
						result = result2;
						num = (int)((num2 * 1978773387) ^ 0x765921C7);
						continue;
					case 5u:
						result = !JSONNode.smethod_1(Value);
						num = 1540811308;
						continue;
					case 4u:
						num = (int)(num2 * 1396025139) ^ -459448995;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!bool.TryParse(Value, out result2))
						{
							num3 = 1688964;
							num4 = 1688964;
						}
						else
						{
							num3 = 1169595383;
							num4 = 1169595383;
						}
						num = num3 ^ ((int)num2 * -728681999);
						continue;
					}
					case 1u:
						result2 = false;
						num = (int)((num2 * 22055445) ^ 0x1EDC77EF);
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
				int num = -463255646;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81FD1E2Bu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 454898536) ^ 0x6FB29BB3);
						continue;
					case 1u:
						Value = (value ? "true" : "false");
						num = -1891839267;
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

	public virtual JSONArray AsArray
	{
		get
		{
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1024675702;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6ACE8B24u) % 3u)
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
					num = (int)(num2 * 1615251074) ^ -82005955;
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
				int num = -291350321;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEFDE27CCu) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = (int)((num2 * 2062482002) ^ 0x7420217E);
						continue;
					case 0u:
						num = ((int)num2 * -580260714) ^ -1558050903;
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
			int num = 576850995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C16DABEu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -696526808) ^ -670189744;
					continue;
				case 1u:
					Add("", aItem);
					num = ((int)num2 * -1604415391) ^ 0x5AECD6F8;
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

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -177546125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB363F81Cu) % 4u)
				{
				case 3u:
					result = null;
					num = ((int)num2 * -671526819) ^ 0x37F3388A;
					continue;
				case 1u:
					num = (int)(num2 * 1235210437) ^ -1368125141;
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
			int num = -1150727822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB30D3011u) % 3u)
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
				num = ((int)num2 * -232935284) ^ -246043330;
			}
		}
	}

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1197212171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7713758u) % 4u)
				{
				case 1u:
					result = aNode;
					num = ((int)num2 * -1241932866) ^ 0x593BE066;
					continue;
				case 0u:
					num = ((int)num2 * -313734732) ^ -314437857;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -710710018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBBED37Du) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = ((int)num2 * -1334019898) ^ 0x59E1F6D7;
					continue;
				case 0u:
					num = ((int)num2 * -1198113151) ^ 0x47840644;
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
		string result = default(string);
		while (true)
		{
			int num = 1019714419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x71422626u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 546044592) ^ -208944422;
					continue;
				case 1u:
					result = "JSONNode";
					num = (int)((num2 * 598177063) ^ 0x5F975807);
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
			int num = 1707745085;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x15C9B103u) % 4u)
				{
				case 2u:
					result = new JSONData(s);
					num = ((int)num2 * -213850296) ^ 0x2E3E262E;
					continue;
				case 1u:
					num = (int)((num2 * 1288180991) ^ 0x79EF1293);
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
			int num = -1144294355;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x98005198u) % 5u)
				{
				case 4u:
					obj = d.Value;
					goto IL_0009;
				case 1u:
					if (!(d == null))
					{
						num = (int)((num2 * 1076531831) ^ 0x3B8F7F74);
						continue;
					}
					obj = null;
					goto IL_0009;
				case 0u:
					num = ((int)num2 * -106058646) ^ 0x306C0113;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_0009:
					result = (string)obj;
					num = -1681358704;
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
			goto IL_0059;
		}
		int num = 0;
		goto IL_0094;
		IL_0094:
		bool flag = (byte)num != 0;
		int num2 = 1241082549;
		goto IL_005e;
		IL_0059:
		num2 = 769967513;
		goto IL_005e;
		IL_005e:
		bool result = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x44B7D1AFu) % 7u)
			{
			case 5u:
			{
				int num4;
				int num5;
				if (flag)
				{
					num4 = -1522995008;
					num5 = -1522995008;
				}
				else
				{
					num4 = -2108877557;
					num5 = -2108877557;
				}
				num2 = num4 ^ ((int)num3 * -1225266599);
				continue;
			}
			case 4u:
				num2 = (int)(num3 * 1858849554) ^ -384584190;
				continue;
			case 3u:
				result = (object)a == b;
				num2 = 1207796178;
				continue;
			case 2u:
				result = true;
				num2 = (int)(num3 * 983015453) ^ -1165393034;
				continue;
			case 0u:
				break;
			case 6u:
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
		bool result = (object)this == obj;
		while (true)
		{
			int num = 1189003314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61BF768Bu) % 3u)
				{
				case 2u:
					goto IL_0007;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0007:
				num = ((int)num2 * -1111955243) ^ 0x180BD5DA;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = 1844961926;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53F8B6DFu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -448043210) ^ 0x29222EEF;
					continue;
				case 1u:
					result = this.method_0();
					num = ((int)num2 * -25669730) ^ -1167751846;
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
		string string_ = default(string);
		char c2 = default(char);
		char c3 = default(char);
		char c = default(char);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1949046222;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5470575u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -800810816) ^ 0x2FEF646F;
					continue;
				case 28u:
					num = ((int)num2 * -759046321) ^ 0x46544D76;
					continue;
				case 27u:
					text = "";
					string_ = aText;
					num = ((int)num2 * -1916626361) ^ -252503058;
					continue;
				case 26u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = -1923829654;
					continue;
				case 25u:
					c2 = c3;
					switch (c2)
					{
					case '\b':
						goto IL_0095;
					case '\t':
						goto IL_00ab;
					case '\n':
						goto IL_00c1;
					case '\v':
						goto IL_00d7;
					case '\f':
						goto IL_00ef;
					case '\r':
						goto IL_0105;
					}
					num = (int)((num2 * 940485847) ^ 0x6FB4F639);
					continue;
				case 20u:
					goto IL_0095;
				case 14u:
					goto IL_00ab;
				case 7u:
					goto IL_00c1;
				case 22u:
					goto IL_00d7;
				case 11u:
					goto IL_00ef;
				case 10u:
					goto IL_0105;
				case 24u:
					c3 = c;
					num = ((int)num2 * -365264791) ^ 0x76BAD72C;
					continue;
				case 23u:
				{
					int num6;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = -1497217563;
						num6 = -1497217563;
					}
					else
					{
						num = -82142037;
						num6 = -82142037;
					}
					continue;
				}
				case 21u:
				{
					int num5;
					if (c2 != '\\')
					{
						num = -2062534366;
						num5 = -2062534366;
					}
					else
					{
						num = -1482865771;
						num5 = -1482865771;
					}
					continue;
				}
				case 19u:
					num3++;
					num = -1241316310;
					continue;
				case 18u:
					num = (int)(num2 * 325319525) ^ -1641382788;
					continue;
				case 17u:
					num = (int)((num2 * 1268825740) ^ 0x146F416E);
					continue;
				case 16u:
					num = (int)(num2 * 541019098) ^ -1823633557;
					continue;
				case 15u:
					num = ((int)num2 * -1242982989) ^ -642946403;
					continue;
				case 13u:
					num = (int)((num2 * 700589123) ^ 0x6AC96553);
					continue;
				case 12u:
					num3 = 0;
					num = (int)(num2 * 1687368024) ^ -410728578;
					continue;
				case 9u:
				{
					int num4;
					if (c2 == '"')
					{
						num = -813501744;
						num4 = -813501744;
					}
					else
					{
						num = -157045429;
						num4 = -157045429;
					}
					continue;
				}
				case 6u:
					c = JSONNode.smethod_2(string_, num3);
					num = -1972096713;
					continue;
				case 5u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = -1890840872;
					continue;
				case 4u:
					result = text;
					num = (int)(num2 * 1527201012) ^ -1577797983;
					continue;
				case 2u:
					num = ((int)num2 * -879216329) ^ -204307416;
					continue;
				case 1u:
					num = (int)(num2 * 1282693858) ^ -1136901192;
					continue;
				case 0u:
					num = ((int)num2 * -815598660) ^ 0x2C34A91A;
					continue;
				case 3u:
					break;
				default:
					{
						return result;
					}
					IL_00ab:
					text = JSONNode.smethod_3(text, "\\t");
					num = -1890561519;
					continue;
					IL_0095:
					text = JSONNode.smethod_3(text, "\\b");
					num = -2107360213;
					continue;
					IL_0105:
					text = JSONNode.smethod_3(text, "\\r");
					num = -2060508250;
					continue;
					IL_00ef:
					text = JSONNode.smethod_3(text, "\\f");
					num = -1923829654;
					continue;
					IL_00d7:
					text = JSONNode.smethod_3(text, c.ToString());
					num = -1923829654;
					continue;
					IL_00c1:
					text = JSONNode.smethod_3(text, "\\n");
					num = -494853189;
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
		char c2 = default(char);
		bool flag6 = default(bool);
		char c3 = default(char);
		int num8 = default(int);
		char c4 = default(char);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		string text2 = default(string);
		string text = default(string);
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		char c = default(char);
		bool flag5 = default(bool);
		bool flag14 = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		string s = default(string);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 2107470425;
			while (true)
			{
				uint num2;
				int num24;
				switch ((num2 = (uint)num ^ 0x655E8440u) % 155u)
				{
				case 154u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -584621197) ^ -100233082;
					continue;
				case 153u:
					switch (c2)
					{
					case 'r':
						goto IL_0050;
					case 's':
						goto IL_0066;
					case 't':
						goto IL_007e;
					case 'u':
						goto IL_0094;
					}
					num = 814681088;
					continue;
				case 107u:
					goto IL_0050;
				case 132u:
					goto IL_0066;
				case 60u:
					goto IL_007e;
				case 40u:
					goto IL_0094;
				case 152u:
				{
					int num22;
					int num23;
					if (flag6)
					{
						num22 = -1099107347;
						num23 = -1099107347;
					}
					else
					{
						num22 = -655725597;
						num23 = -655725597;
					}
					num = num22 ^ (int)(num2 * 1634712245);
					continue;
				}
				case 151u:
					c3 = JSONNode.smethod_2(aJSON, num8);
					c4 = c3;
					num = (int)((num2 * 2089491524) ^ 0x313228C2);
					continue;
				case 150u:
				{
					int num46;
					int num47;
					if (flag11)
					{
						num46 = 668036648;
						num47 = 668036648;
					}
					else
					{
						num46 = 1337263979;
						num47 = 1337263979;
					}
					num = num46 ^ ((int)num2 * -1860089697);
					continue;
				}
				case 149u:
					num = (int)((num2 * 898707625) ^ 0x3F935A9C);
					continue;
				case 148u:
				{
					int num30;
					int num31;
					if (!flag8)
					{
						num30 = -1535759268;
						num31 = -1535759268;
					}
					else
					{
						num30 = -287862568;
						num31 = -287862568;
					}
					num = num30 ^ ((int)num2 * -1980338933);
					continue;
				}
				case 147u:
					flag7 = num8 < JSONNode.smethod_4(aJSON);
					num = 442849046;
					continue;
				case 146u:
				{
					int num18;
					if (c2 != 'f')
					{
						num = 1793847536;
						num18 = 1793847536;
					}
					else
					{
						num = 1637643348;
						num18 = 1637643348;
					}
					continue;
				}
				case 145u:
					stack.Push(new JSONArray());
					num = 668936963;
					continue;
				case 144u:
					num = ((int)num2 * -1595918264) ^ -830928592;
					continue;
				case 143u:
				{
					int num5;
					if (c2 == 'n')
					{
						num = 2030984229;
						num5 = 2030984229;
					}
					else
					{
						num = 1379444330;
						num5 = 1379444330;
					}
					continue;
				}
				case 142u:
					num = (int)(num2 * 1180744879) ^ -365858617;
					continue;
				case 141u:
					num = 1086971714;
					continue;
				case 140u:
					num = ((int)num2 * -1409765750) ^ 0x238C1E1F;
					continue;
				case 139u:
					num = (int)((num2 * 975121953) ^ 0x2D604D6);
					continue;
				case 138u:
					text2 = JSONNode.smethod_3(text2, "\b");
					num = 812107945;
					continue;
				case 137u:
					num = ((int)num2 * -597658830) ^ 0x1EFF05DF;
					continue;
				case 136u:
					text = "";
					num = 1145595053;
					continue;
				case 135u:
					flag8 = flag;
					num = 1945436792;
					continue;
				case 0u:
				case 17u:
				case 89u:
				case 97u:
				case 134u:
					num8++;
					num = 441418851;
					continue;
				case 133u:
					flag2 = flag;
					num = 1751680500;
					continue;
				case 131u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -141049689) ^ -253784526;
					continue;
				case 130u:
					jSONNode.Add(text2);
					num = (int)((num2 * 1122978031) ^ 0x76765BA8);
					continue;
				case 129u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -118012159) ^ 0x71ED503;
					continue;
				case 128u:
					num = (int)(num2 * 232507615) ^ -1465335311;
					continue;
				case 127u:
					flag4 = JSONNode.smethod_6(text, "");
					num = 1381529243;
					continue;
				case 126u:
					switch (c)
					{
					case '\n':
					case '\r':
						break;
					default:
						goto IL_0320;
					case '\t':
						goto IL_0333;
					case '\v':
					case '\f':
						goto IL_0341;
					}
					goto case 0u;
				case 15u:
					goto IL_0333;
				case 74u:
					goto IL_0341;
				case 125u:
					num = (int)((num2 * 434793973) ^ 0x30F8A667);
					continue;
				case 124u:
					num = 134647612;
					continue;
				case 123u:
				{
					int num44;
					int num45;
					if ((uint)c2 > 102u)
					{
						num44 = -1958682894;
						num45 = -1958682894;
					}
					else
					{
						num44 = -1524342075;
						num45 = -1524342075;
					}
					num = num44 ^ ((int)num2 * -1447524009);
					continue;
				}
				case 122u:
					num = (int)(num2 * 2075424065) ^ -1976617834;
					continue;
				case 121u:
					text2 = "";
					num = (int)((num2 * 1185419996) ^ 0x75A3335);
					continue;
				case 120u:
					stack.Pop();
					num = 1625433413;
					continue;
				case 119u:
					text2 = "";
					num = (int)((num2 * 196723768) ^ 0x35529115);
					continue;
				case 118u:
					num = ((int)num2 * -1082490397) ^ -217491990;
					continue;
				case 117u:
					text = "";
					num = 723860495;
					continue;
				case 116u:
					num = (int)((num2 * 686430383) ^ 0x1C75D11F);
					continue;
				case 115u:
					num = (int)(num2 * 1759471211) ^ -2020596376;
					continue;
				case 114u:
					num = (int)((num2 * 161962178) ^ 0x48EBDD2B);
					continue;
				case 113u:
					num = ((int)num2 * -2045835399) ^ -1097685752;
					continue;
				case 112u:
				{
					int num35;
					if (c != ' ')
					{
						num = 502670149;
						num35 = 502670149;
					}
					else
					{
						num = 1064239654;
						num35 = 1064239654;
					}
					continue;
				}
				case 111u:
					num = ((int)num2 * -1221081008) ^ -1938264864;
					continue;
				case 109u:
					num = ((int)num2 * -1093622459) ^ 0x3198805F;
					continue;
				case 108u:
				{
					int num29;
					if (c != '{')
					{
						num = 611555590;
						num29 = 611555590;
					}
					else
					{
						num = 2137405450;
						num29 = 2137405450;
					}
					continue;
				}
				case 106u:
					text = "";
					num = 389949323;
					continue;
				case 105u:
					flag = !flag;
					num = 1500358322;
					continue;
				case 104u:
					num = (int)(num2 * 1113681313) ^ -1026137573;
					continue;
				case 103u:
					switch (c)
					{
					case ']':
						break;
					default:
						goto IL_0525;
					case '[':
						goto IL_052f;
					case '\\':
						goto IL_054f;
					}
					goto case 133u;
				case 9u:
					goto IL_052f;
				case 59u:
					goto IL_054f;
				case 102u:
				{
					int num14;
					int num15;
					if (!flag4)
					{
						num14 = 454119951;
						num15 = 454119951;
					}
					else
					{
						num14 = 8720816;
						num15 = 8720816;
					}
					num = num14 ^ (int)(num2 * 1219787178);
					continue;
				}
				case 101u:
				{
					int num11;
					int num12;
					if (c2 != 'b')
					{
						num11 = -1736886898;
						num12 = -1736886898;
					}
					else
					{
						num11 = -1627270896;
						num12 = -1627270896;
					}
					num = num11 ^ (int)(num2 * 1133137584);
					continue;
				}
				case 99u:
					num = (int)((num2 * 1272866246) ^ 0x3B1CFE51);
					continue;
				case 98u:
					text2 = JSONNode.smethod_3(text2, "\f");
					num = 1417438743;
					continue;
				case 96u:
					num = ((int)num2 * -848893513) ^ 0x57DE17DB;
					continue;
				case 95u:
				{
					int num61;
					int num62;
					if (!flag5)
					{
						num61 = 1672887925;
						num62 = 1672887925;
					}
					else
					{
						num61 = 1423046335;
						num62 = 1423046335;
					}
					num = num61 ^ ((int)num2 * -1422507829);
					continue;
				}
				case 94u:
					flag14 = jSONNode != null;
					num = (int)((num2 * 1400010658) ^ 0x1D8E504);
					continue;
				case 93u:
					text = "";
					num = 952354695;
					continue;
				case 92u:
					text = text2;
					num = 1199197507;
					continue;
				case 91u:
				{
					int num59;
					int num60;
					if (flag14)
					{
						num59 = -553293680;
						num60 = -553293680;
					}
					else
					{
						num59 = -585415793;
						num60 = -585415793;
					}
					num = num59 ^ (int)(num2 * 1888776505);
					continue;
				}
				case 90u:
				{
					int num58;
					if (c == '}')
					{
						num = 1510127038;
						num58 = 1510127038;
					}
					else
					{
						num = 576596693;
						num58 = 576596693;
					}
					continue;
				}
				case 88u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -1820502901) ^ -1372038736;
					continue;
				case 87u:
					flag13 = jSONNode is JSONArray;
					num = (int)((num2 * 1614646583) ^ 0x7CED7DB6);
					continue;
				case 86u:
				{
					int num57;
					if (c != '"')
					{
						num = 291590943;
						num57 = 291590943;
					}
					else
					{
						num = 1283431324;
						num57 = 1283431324;
					}
					continue;
				}
				case 85u:
				{
					int num55;
					int num56;
					if (flag12)
					{
						num55 = -1647579206;
						num56 = -1647579206;
					}
					else
					{
						num55 = -1491760517;
						num56 = -1491760517;
					}
					num = num55 ^ ((int)num2 * -84830680);
					continue;
				}
				case 83u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num8);
					c = c5;
					num = (int)(num2 * 151188485) ^ -88025121;
					continue;
				}
				case 82u:
					num = (int)(num2 * 1186522160) ^ -1527675683;
					continue;
				case 81u:
					num = (int)((num2 * 845928761) ^ 0x2A9AECF6);
					continue;
				case 80u:
				{
					int num53;
					int num54;
					if (flag13)
					{
						num53 = -2137788267;
						num54 = -2137788267;
					}
					else
					{
						num53 = -456396860;
						num54 = -456396860;
					}
					num = num53 ^ (int)(num2 * 1900559442);
					continue;
				}
				case 79u:
					num = (int)(num2 * 229909197) ^ -1153849846;
					continue;
				case 78u:
				{
					int num52;
					if ((uint)c <= 93u)
					{
						num = 16623781;
						num52 = 16623781;
					}
					else
					{
						num = 2023217892;
						num52 = 2023217892;
					}
					continue;
				}
				case 77u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -664248660) ^ 0x399ABBCE;
					continue;
				case 76u:
				{
					int num50;
					int num51;
					if (jSONNode is JSONArray)
					{
						num50 = -1024572745;
						num51 = -1024572745;
					}
					else
					{
						num50 = -1703448781;
						num51 = -1703448781;
					}
					num = num50 ^ (int)(num2 * 1632748434);
					continue;
				}
				case 75u:
					num = ((int)num2 * -1305614474) ^ 0x4E800D85;
					continue;
				case 73u:
					num = 1142060592;
					continue;
				case 72u:
				{
					int num48;
					int num49;
					if ((uint)c > 44u)
					{
						num48 = -1509211472;
						num49 = -1509211472;
					}
					else
					{
						num48 = -1122523090;
						num49 = -1122523090;
					}
					num = num48 ^ ((int)num2 * -2010895025);
					continue;
				}
				case 71u:
					flag12 = jSONNode is JSONArray;
					num = (int)(num2 * 1669871660) ^ -1747135132;
					continue;
				case 70u:
					num8 = 0;
					text2 = "";
					num = (int)((num2 * 1256957194) ^ 0x5DE2A333);
					continue;
				case 69u:
					text2 = "";
					num = (int)((num2 * 558980825) ^ 0x150BF8D2);
					continue;
				case 68u:
					jSONNode.Add(text, stack.Peek());
					num = (int)((num2 * 417980278) ^ 0x25EE1B1D);
					continue;
				case 67u:
					num = ((int)num2 * -1914913865) ^ 0x3ACC3FA1;
					continue;
				case 66u:
					stack.Push(new JSONClass());
					num = 193322677;
					continue;
				case 65u:
					num = ((int)num2 * -1626803557) ^ -1079981286;
					continue;
				case 64u:
					num = ((int)num2 * -1253094700) ^ -252371034;
					continue;
				case 63u:
					num = (int)((num2 * 1248909726) ^ 0x3D354DBF);
					continue;
				case 62u:
					text = "";
					flag = false;
					num = (int)(num2 * 1542267216) ^ -464097129;
					continue;
				case 61u:
					num = (int)((num2 * 224771430) ^ 0x73965321);
					continue;
				case 58u:
					num = ((int)num2 * -274320659) ^ 0x7B6D51B4;
					continue;
				case 57u:
					num = (int)((num2 * 248698064) ^ 0x1A4F191D);
					continue;
				case 56u:
					num = (int)((num2 * 803343235) ^ 0x37C7EBAE);
					continue;
				case 55u:
					num = 108788177;
					continue;
				case 54u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = (int)(num2 * 26603912) ^ -1326659460;
					continue;
				case 53u:
					jSONNode.Add(text, stack.Peek());
					num = (int)(num2 * 117662185) ^ -644934167;
					continue;
				case 52u:
					num = (int)(num2 * 1913839709) ^ -657150737;
					continue;
				case 51u:
					text2 = "";
					num = ((int)num2 * -443026869) ^ 0x44D01BB9;
					continue;
				case 50u:
					text2 = JSONNode.smethod_3(text2, "\n");
					num = 356604781;
					continue;
				case 49u:
					jSONNode.Add(text, text2);
					num = ((int)num2 * -1935008893) ^ 0x27751856;
					continue;
				case 48u:
					jSONNode.Add(text2);
					num = ((int)num2 * -799064111) ^ -1426565730;
					continue;
				case 47u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 473715184) ^ -1309654821;
					continue;
				case 46u:
					result = jSONNode;
					num = 2060827400;
					continue;
				case 45u:
					text = JSONNode.smethod_5(text);
					num = ((int)num2 * -1736771409) ^ 0x8EC397F;
					continue;
				case 44u:
				{
					int num42;
					int num43;
					if (JSONNode.smethod_6(text2, ""))
					{
						num42 = -1274472996;
						num43 = -1274472996;
					}
					else
					{
						num42 = -468848986;
						num43 = -468848986;
					}
					num = num42 ^ ((int)num2 * -1872628142);
					continue;
				}
				case 43u:
				{
					int num40;
					int num41;
					if (!flag10)
					{
						num40 = 152556538;
						num41 = 152556538;
					}
					else
					{
						num40 = 89962858;
						num41 = 89962858;
					}
					num = num40 ^ ((int)num2 * -933447341);
					continue;
				}
				case 42u:
				{
					int num39;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 411911022;
						num39 = 411911022;
					}
					else
					{
						num = 1142060592;
						num39 = 1142060592;
					}
					continue;
				}
				case 39u:
				{
					int num38;
					if (flag)
					{
						num = 2094648749;
						num38 = 2094648749;
					}
					else
					{
						num = 870255323;
						num38 = 870255323;
					}
					continue;
				}
				case 38u:
					num = 1439320956;
					continue;
				case 37u:
					num = (int)(num2 * 608884878) ^ -54238386;
					continue;
				case 36u:
					flag9 = stack.Count > 0;
					num = (int)((num2 * 261345098) ^ 0x3F6AB69B);
					continue;
				case 35u:
				{
					text = JSONNode.smethod_5(text);
					int num36;
					int num37;
					if (!(jSONNode is JSONArray))
					{
						num36 = -746883315;
						num37 = -746883315;
					}
					else
					{
						num36 = -1876313567;
						num37 = -1876313567;
					}
					num = num36 ^ (int)(num2 * 1066653487);
					continue;
				}
				case 34u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -334547559) ^ -1694475069;
					continue;
				case 33u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -953894143) ^ -245497205;
					continue;
				case 32u:
					num = ((int)num2 * -779680997) ^ 0x4C5C3F04;
					continue;
				case 31u:
					num = ((int)num2 * -1735659635) ^ -840323929;
					continue;
				case 30u:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = ((int)num2 * -1645064337) ^ -78726671;
					continue;
				case 29u:
					flag10 = flag;
					num = 656276541;
					continue;
				case 28u:
				{
					int num34;
					if (c != ',')
					{
						num = 34574981;
						num34 = 34574981;
					}
					else
					{
						num = 792781804;
						num34 = 792781804;
					}
					continue;
				}
				case 27u:
				{
					int num32;
					int num33;
					if (!flag9)
					{
						num32 = 310994451;
						num33 = 310994451;
					}
					else
					{
						num32 = 1344709202;
						num33 = 1344709202;
					}
					num = num32 ^ (int)(num2 * 1249951483);
					continue;
				}
				case 26u:
					text2 = "";
					num = (int)(num2 * 1749627835) ^ -1828189469;
					continue;
				case 25u:
					c2 = c4;
					num = ((int)num2 * -1211779471) ^ -590136944;
					continue;
				case 24u:
					num = (int)((num2 * 1730381095) ^ 0x17927712);
					continue;
				case 23u:
					text2 = JSONNode.smethod_3(text2, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num8 += 4;
					num = (int)(num2 * 376847902) ^ -1707882381;
					continue;
				case 22u:
				{
					int num27;
					int num28;
					if (!(jSONNode != null))
					{
						num27 = 635222940;
						num28 = 635222940;
					}
					else
					{
						num27 = 244966333;
						num28 = 244966333;
					}
					num = num27 ^ ((int)num2 * -1218978102);
					continue;
				}
				case 21u:
					num = 470532492;
					continue;
				case 20u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1277045381) ^ -498853571;
					continue;
				case 19u:
				{
					int num25;
					int num26;
					if (!flag3)
					{
						num25 = -1262366476;
						num26 = -1262366476;
					}
					else
					{
						num25 = -1730689713;
						num26 = -1730689713;
					}
					num = num25 ^ (int)(num2 * 1972980878);
					continue;
				}
				case 18u:
				{
					int num20;
					int num21;
					if (flag7)
					{
						num20 = -1223509267;
						num21 = -1223509267;
					}
					else
					{
						num20 = -1648289966;
						num21 = -1648289966;
					}
					num = num20 ^ ((int)num2 * -1869431195);
					continue;
				}
				case 16u:
				{
					int num19;
					if (!JSONNode.smethod_6(text, ""))
					{
						num = 330991036;
						num19 = 330991036;
					}
					else
					{
						num = 1675832455;
						num19 = 1675832455;
					}
					continue;
				}
				case 14u:
					flag5 = stack.Count == 0;
					num = 324977215;
					continue;
				case 13u:
					num = (int)(num2 * 108580801) ^ -15914197;
					continue;
				case 12u:
				{
					int num16;
					int num17;
					if (c != ':')
					{
						num16 = -933470555;
						num17 = -933470555;
					}
					else
					{
						num16 = -1460522107;
						num17 = -1460522107;
					}
					num = num16 ^ ((int)num2 * -97745483);
					continue;
				}
				case 11u:
				{
					int num13;
					if (JSONNode.smethod_6(text, ""))
					{
						num = 1249775122;
						num13 = 1249775122;
					}
					else
					{
						num = 432305568;
						num13 = 432305568;
					}
					continue;
				}
				case 10u:
					flag3 = JSONNode.smethod_6(text, "");
					num = 2146436743;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1254544465;
						num10 = -1254544465;
					}
					else
					{
						num9 = -1337271800;
						num10 = -1337271800;
					}
					num = num9 ^ (int)(num2 * 1429761020);
					continue;
				}
				case 7u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -146796423) ^ -810289735;
					continue;
				case 6u:
					s = JSONNode.smethod_8(aJSON, num8 + 1, 4);
					num = ((int)num2 * -732512833) ^ 0x3556E3A9;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -586412793;
						num7 = -586412793;
					}
					else
					{
						num6 = -1817033835;
						num7 = -1817033835;
					}
					num = num6 ^ ((int)num2 * -833991874);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if ((uint)c <= 32u)
					{
						num3 = -1297228485;
						num4 = -1297228485;
					}
					else
					{
						num3 = -1778188066;
						num4 = -1778188066;
					}
					num = num3 ^ (int)(num2 * 2137464106);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1032443280) ^ -740063728;
					continue;
				case 2u:
					jSONNode.Add(text, text2);
					num = (int)(num2 * 1025159888) ^ -1940702769;
					continue;
				case 1u:
					num = ((int)num2 * -45273736) ^ 0x3661314F;
					continue;
				case 41u:
					break;
				case 84u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 100u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_007e:
					text2 = JSONNode.smethod_3(text2, "\t");
					num = 1744942317;
					continue;
					IL_054f:
					num8++;
					flag6 = flag;
					num = 2052552531;
					continue;
					IL_052f:
					if (flag)
					{
						num = 419069625;
						num24 = 419069625;
					}
					else
					{
						num = 229015770;
						num24 = 229015770;
					}
					continue;
					IL_0525:
					num = 1416139379;
					continue;
					IL_0066:
					text2 = JSONNode.smethod_3(text2, c3.ToString());
					num = 812107945;
					continue;
					IL_0050:
					text2 = JSONNode.smethod_3(text2, "\r");
					num = 812107945;
					continue;
					IL_0094:
					num = 2045992429;
					continue;
					IL_0341:
					text2 = JSONNode.smethod_3(text2, JSONNode.smethod_2(aJSON, num8).ToString());
					num = 860870077;
					continue;
					IL_0333:
					flag11 = flag;
					num = 31716912;
					continue;
					IL_0320:
					num = ((int)num2 * -165086244) ^ -1398773873;
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
			int num = -1150099092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1F15B35u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1654556012) ^ -1436806886;
					continue;
				case 1u:
				{
					BinaryWriter aWriter = JSONNode.smethod_9(aData);
					Serialize(aWriter);
					num = ((int)num2 * -1393164478) ^ 0x226730F1;
					continue;
				}
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
			while (true)
			{
				int num = 1901036434;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42345FE4u) % 4u)
					{
					case 2u:
						SaveToStream(fileStream);
						num = (int)((num2 * 1860117614) ^ 0x731E6C69);
						continue;
					case 1u:
						num = (int)(num2 * 884583703) ^ -708736741;
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
					IL_00b5:
					int num3 = 485700083;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x42345FE4u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)((num2 * 927035235) ^ 0x49DA5E29);
							continue;
						case 0u:
							num3 = ((int)num2 * -857430119) ^ 0x1E1B161D;
							continue;
						default:
							goto end_IL_0094;
						case 2u:
							break;
						case 1u:
							goto end_IL_0094;
						}
						goto IL_00b5;
						continue;
						end_IL_0094:
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
				int num = -1955545446;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD9E3159Cu) % 5u)
					{
					case 4u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = ((int)num2 * -1596493412) ^ 0x1C05D412;
						continue;
					case 2u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = ((int)num2 * -752044398) ^ 0x7750BE93;
						continue;
					case 1u:
						SaveToStream(memoryStream);
						num = ((int)num2 * -559964293) ^ 0x599E369B;
						continue;
					case 3u:
						break;
					default:
						return result;
					case 0u:
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
					int num3 = -1150844925;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xD9E3159Cu) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)((num2 * 741185800) ^ 0x7F964AD6);
							continue;
						case 2u:
							num3 = ((int)num2 * -1695483129) ^ -1569692581;
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
		int num7 = default(int);
		bool flag2 = default(bool);
		int num10 = default(int);
		JSONNode aItem = default(JSONNode);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		bool flag = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		JSONArray jSONArray = default(JSONArray);
		while (true)
		{
			int num = -1187624870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E010498u) % 38u)
				{
				case 37u:
					num = -1155927820;
					continue;
				case 36u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = ((int)num2 * -514850054) ^ 0x12ECD86D;
					continue;
				case 33u:
					num7 = 0;
					num = ((int)num2 * -2084825694) ^ 0x5F8FBC1F;
					continue;
				case 32u:
					goto IL_004e;
				case 31u:
					num = (int)(num2 * 1241772923) ^ -826935766;
					continue;
				case 30u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1178895956) ^ -2097447827;
					continue;
				case 29u:
					goto IL_008b;
				case 28u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -658793917) ^ -1107102985;
					continue;
				case 27u:
					flag2 = num7 < num10;
					num = -195413907;
					continue;
				case 26u:
					aItem = Deserialize(aReader);
					num = (int)(num2 * 1271119446) ^ -553687654;
					continue;
				case 25u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = -434140413;
						num9 = -434140413;
					}
					else
					{
						num8 = -350417690;
						num9 = -350417690;
					}
					num = num8 ^ ((int)num2 * -123275950);
					continue;
				}
				case 24u:
					goto IL_011a;
				case 23u:
					num = ((int)num2 * -651256616) ^ 0x4F1950A2;
					continue;
				case 21u:
					num = -506998528;
					continue;
				case 20u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 432083346) ^ 0x6FA52931);
					continue;
				case 19u:
					num = (int)(num2 * 1814490509) ^ -175515150;
					continue;
				case 18u:
					jSONClass.Add(aKey, aItem);
					num = (int)(num2 * 563334234) ^ -1682235301;
					continue;
				case 17u:
					goto IL_0194;
				case 16u:
					num7++;
					num = ((int)num2 * -1687561149) ^ 0x2ADDFE17;
					continue;
				case 15u:
					num = ((int)num2 * -532381758) ^ -1402689952;
					continue;
				case 14u:
					flag = num4 < num3;
					num = -2139161005;
					continue;
				case 13u:
					jSONArray.Add(Deserialize(aReader));
					num = -692535703;
					continue;
				case 12u:
					goto IL_01f2;
				case 11u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -548112327;
						num6 = -548112327;
					}
					else
					{
						num5 = -2138362774;
						num6 = -2138362774;
					}
					num = num5 ^ ((int)num2 * -940726371);
					continue;
				}
				case 10u:
					num = (int)(num2 * 1320039612) ^ -334271927;
					continue;
				case 9u:
					num4++;
					num = (int)(num2 * 1483443794) ^ -1902803600;
					continue;
				case 8u:
					num = (int)((num2 * 213316476) ^ 0x75EFFF5);
					continue;
				case 7u:
					goto IL_0264;
				case 6u:
					result = jSONArray;
					num = (int)((num2 * 2103502773) ^ 0x3A7A21F0);
					continue;
				case 5u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.Array:
						break;
					case JSONBinaryTag.IntValue:
						goto IL_004e;
					case JSONBinaryTag.Class:
						goto IL_008b;
					case JSONBinaryTag.FloatValue:
						goto IL_011a;
					case JSONBinaryTag.DoubleValue:
						goto IL_0194;
					case JSONBinaryTag.BoolValue:
						goto IL_01f2;
					case JSONBinaryTag.Value:
						goto IL_0264;
					default:
						goto IL_02b6;
					}
					goto case 37u;
				case 4u:
					num3 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num4 = 0;
					num = ((int)num2 * -1523110381) ^ -689258149;
					continue;
				case 3u:
					aKey = JSONNode.smethod_22(aReader);
					num = -762785670;
					continue;
				case 2u:
					result = jSONClass;
					num = (int)((num2 * 1846437123) ^ 0x73E4B071);
					continue;
				case 1u:
					num = (int)(num2 * 1848779991) ^ -745269662;
					continue;
				case 0u:
					num = (int)(num2 * 1725107551) ^ -1755142387;
					continue;
				case 22u:
					break;
				case 34u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_02b6:
					num = (int)((num2 * 553064020) ^ 0x342C9C28);
					continue;
					IL_0264:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = -1417432312;
					continue;
					IL_004e:
					num = -1720216492;
					continue;
					IL_01f2:
					num = -1623075128;
					continue;
					IL_0194:
					num = -1673806294;
					continue;
					IL_011a:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1108948611;
					continue;
					IL_008b:
					num10 = JSONNode.smethod_21(aReader);
					jSONClass = new JSONClass();
					num = -1907720201;
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
				int num = 122362141;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x114B1C51u) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					case 2u:
						return result;
					}
					break;
					IL_000a:
					result = Deserialize(binaryReader);
					num = ((int)num2 * -2007799212) ^ 0x5B457D52;
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
					int num3 = 1872216648;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x114B1C51u) % 4u)
						{
						case 2u:
							num3 = (int)(num2 * 554907202) ^ -490043319;
							continue;
						case 1u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num3 = (int)(num2 * 2043755425) ^ -2025389270;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 826066191;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x54C794B2u) % 3u)
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
					num = (int)((num2 * 1652135692) ^ 0x17D19591);
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_008c:
					int num3 = 1056786453;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x54C794B2u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 1016001380) ^ -889550165;
							continue;
						case 1u:
							num3 = (int)((num2 * 2074479754) ^ 0x7081AF2);
							continue;
						default:
							goto end_IL_006b;
						case 0u:
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

	public static JSONNode LoadFromBase64(string aBase64)
	{
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num = -86593215;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8529CDC9u) % 7u)
				{
				case 6u:
					num = (int)((num2 * 383979211) ^ 0x3720714B);
					continue;
				case 4u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 490883158) ^ 0xD4279BF);
					continue;
				case 2u:
					byte_ = JSONNode.smethod_28(aBase64);
					num = (int)(num2 * 2030024698) ^ -2104424733;
					continue;
				case 1u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = ((int)num2 * -1811399908) ^ 0x577EE1CB;
					continue;
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -1990366687) ^ -773349742;
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
			int num = -460178094;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB95B1059u) % 3u)
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
				num = ((int)num2 * -1949788677) ^ -530307298;
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
