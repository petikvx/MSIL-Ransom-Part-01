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
				int num = 1818639316;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4852BD2Du) % 4u)
					{
					case 1u:
						result = null;
						num = (int)((num2 * 1719481954) ^ 0x6A6B21A3);
						continue;
					case 0u:
						num = (int)(num2 * 1555873871) ^ -1954326634;
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
			JSONNode result = null;
			while (true)
			{
				int num = -914210935;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x94FA0FA1u) % 3u)
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
					num = (int)(num2 * 1084891755) ^ -918554786;
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
				int num = -876283347;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x85ACF4D6u) % 4u)
					{
					case 3u:
						result = "";
						num = (int)((num2 * 1446586328) ^ 0x7EE565FE);
						continue;
					case 0u:
						num = ((int)num2 * -179730581) ^ 0x454FA943;
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
			int result = 0;
			while (true)
			{
				int num = -1285118261;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4CDABB2u) % 3u)
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
					num = ((int)num2 * -1915652655) ^ -411896529;
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
				int num = -478815345;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD8D396F0u) % 4u)
					{
					case 3u:
						_003Cget_Childs_003Ed__._003C_003E4__this = this;
						num = (int)(num2 * 1585804051) ^ -1798662491;
						continue;
					case 0u:
						result = _003Cget_Childs_003Ed__;
						num = ((int)num2 * -1235255104) ^ -1028206127;
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

	public IEnumerable<JSONNode> DeepChilds
	{
		get
		{
			_003Cget_DeepChilds_003Ed__19 _003Cget_DeepChilds_003Ed__ = new _003Cget_DeepChilds_003Ed__19(-2);
			_003Cget_DeepChilds_003Ed__._003C_003E4__this = this;
			IEnumerable<JSONNode> result = default(IEnumerable<JSONNode>);
			while (true)
			{
				int num = -1372762639;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE9C700D6u) % 3u)
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
					num = ((int)num2 * -1396374903) ^ 0x46C40F66;
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result2 = default(int);
			int result = default(int);
			while (true)
			{
				int num = -1773376040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB1DB942Au) % 7u)
					{
					case 6u:
						num = (int)((num2 * 1181417162) ^ 0x57700450);
						continue;
					case 4u:
						result2 = 0;
						num = (int)((num2 * 1793565572) ^ 0xBC05BCB);
						continue;
					case 3u:
						result = result2;
						num = ((int)num2 * -1463070675) ^ 0x17CC2DB4;
						continue;
					case 1u:
						result = 0;
						num = -2089535852;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (int.TryParse(Value, out result2))
						{
							num3 = 384047870;
							num4 = 384047870;
						}
						else
						{
							num3 = 1222670247;
							num4 = 1222670247;
						}
						num = num3 ^ (int)(num2 * 528683932);
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
			while (true)
			{
				int num = -1247110999;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCC0E0673u) % 3u)
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
					num = (int)((num2 * 876354295) ^ 0x70B859C3);
				}
			}
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
				int num = -1342946849;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB96B6B4u) % 8u)
					{
					case 7u:
						result = result2;
						num = (int)((num2 * 874072854) ^ 0x40EAD1EA);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2))
						{
							num3 = -435540065;
							num4 = -435540065;
						}
						else
						{
							num3 = -1681539963;
							num4 = -1681539963;
						}
						num = num3 ^ ((int)num2 * -291320926);
						continue;
					}
					case 5u:
						result = 0f;
						num = -1367951596;
						continue;
					case 4u:
						num = (int)(num2 * 465459650) ^ -1958111211;
						continue;
					case 3u:
						result2 = 0f;
						num = (int)((num2 * 2103182345) ^ 0x77799AA9);
						continue;
					case 0u:
						num = ((int)num2 * -1395727612) ^ 0x22E15FDD;
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
			Value = value.ToString();
			while (true)
			{
				int num = 1329815050;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x899A0Bu) % 3u)
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
					num = ((int)num2 * -1822752533) ^ 0x52944A3B;
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
				int num = 1783859603;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x71D65DC3u) % 6u)
					{
					case 4u:
						result2 = 0.0;
						num = 1494594894;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1169277802;
							num4 = -1169277802;
						}
						else
						{
							num3 = -1740929663;
							num4 = -1740929663;
						}
						num = num3 ^ (int)(num2 * 288276787);
						continue;
					}
					case 2u:
						flag = double.TryParse(Value, out result);
						num = ((int)num2 * -1582172771) ^ 0x293A679E;
						continue;
					case 1u:
						result2 = result;
						num = ((int)num2 * -1992129355) ^ -1349569897;
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
				int num = 832397310;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D74191u) % 3u)
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
					num = (int)((num2 * 1260316226) ^ 0x50C7C4DD);
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
				int num = 1839196681;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x76457D1Eu) % 9u)
					{
					case 6u:
						result = result2;
						num = (int)((num2 * 83003924) ^ 0x51E75D1D);
						continue;
					case 5u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -2081942223;
							num4 = -2081942223;
						}
						else
						{
							num3 = -1253048736;
							num4 = -1253048736;
						}
						num = num3 ^ ((int)num2 * -2147096112);
						continue;
					}
					case 4u:
						result = !JSONNode.smethod_1(Value);
						num = 622067079;
						continue;
					case 3u:
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -1427332616) ^ -1646225401;
						continue;
					case 2u:
						result2 = false;
						num = ((int)num2 * -742177510) ^ -422884795;
						continue;
					case 1u:
						num = ((int)num2 * -1953023240) ^ 0x3F79CBC7;
						continue;
					case 0u:
						num = ((int)num2 * -105727226) ^ 0x2041A179;
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
				int num = 887734069;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ 0x3BC867EC) % 3u)
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
					num = 1273842756;
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
				int num = -606169894;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9E59D0D4u) % 4u)
					{
					case 3u:
						num = (int)(num2 * 2107063078) ^ -765626521;
						continue;
					case 2u:
						result = this as JSONArray;
						num = ((int)num2 * -1291472046) ^ 0x2CA2BECB;
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

	public virtual JSONClass AsObject => this as JSONClass;

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 1852470884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x165E092Eu) % 3u)
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
				num = (int)((num2 * 964619129) ^ 0x683B49C);
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1919223612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x260D1BEFu) % 3u)
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
				num = ((int)num2 * -289674381) ^ -796201889;
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 176332685;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF720B2Cu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1436650006) ^ 0x3D926484);
					continue;
				case 1u:
					result = null;
					num = (int)((num2 * 1976719621) ^ 0x362EFA7A);
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
			int num = -1954095651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1619CC6u) % 4u)
				{
				case 3u:
					result = aNode;
					num = (int)(num2 * 67314971) ^ -1774762338;
					continue;
				case 1u:
					num = (int)((num2 * 852777013) ^ 0x7837A1ED);
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
			int num = 188589042;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A5ECC31u) % 3u)
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
				result = "JSONNode";
				num = (int)((num2 * 347790094) ^ 0x76F931BC);
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -716810246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE97C97A5u) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = (int)((num2 * 61151934) ^ 0x2A77EBCB);
					continue;
				case 0u:
					num = ((int)num2 * -509108941) ^ -71122380;
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
			int num = -759421562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A3D205Bu) % 3u)
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
				num = ((int)num2 * -2096132993) ^ 0x5CB5FAB3;
			}
		}
	}

	public static implicit operator string(JSONNode d)
	{
		if (!(d == null))
		{
			goto IL_000c;
		}
		object obj = null;
		goto IL_0032;
		IL_002c:
		obj = d.Value;
		goto IL_0032;
		IL_000c:
		int num = 1481750976;
		goto IL_0011;
		IL_0011:
		string result = default(string);
		switch ((uint)(num ^ 0x71322E1) % 3u)
		{
		case 0u:
			break;
		case 1u:
			goto IL_002c;
		default:
			return result;
		}
		goto IL_000c;
		IL_0032:
		result = (string)obj;
		num = 1310311828;
		goto IL_0011;
	}

	public static bool operator ==(JSONNode a, object b)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -250083945;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x84CA4E2Au) % 7u)
				{
				case 5u:
					result = true;
					num = ((int)num2 * -91823852) ^ -1500635399;
					continue;
				case 4u:
					if (b == null)
					{
						num = ((int)num2 * -1741719298) ^ 0x543956FD;
						continue;
					}
					goto IL_002c;
				case 3u:
					num = (int)((num2 * 1770998616) ^ 0x79D33895);
					continue;
				case 1u:
					result = (object)a == b;
					num = -108002422;
					continue;
				case 0u:
					if (a is JSONLazyCreator)
					{
						num = -1416618955;
						num3 = -1416618955;
						continue;
					}
					goto IL_002c;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_002c:
					num = -219114794;
					num3 = -219114794;
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
			int num = -131571628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86E85ACEu) % 4u)
				{
				case 2u:
					result = !(a == b);
					num = (int)(num2 * 2032173068) ^ -1191293313;
					continue;
				case 1u:
					num = ((int)num2 * -1253747650) ^ 0x34DDAC1C;
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
			int num = 269178852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7BD20E89u) % 4u)
				{
				case 1u:
					result = (object)this == obj;
					num = ((int)num2 * -963905684) ^ 0x75FC4E65;
					continue;
				case 0u:
					num = ((int)num2 * -80138997) ^ -693638226;
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

	public override int GetHashCode()
	{
		int result = default(int);
		while (true)
		{
			int num = 2076420465;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7CDB31F2u) % 4u)
				{
				case 3u:
					result = this.method_0();
					num = (int)((num2 * 1024215789) ^ 0x5E834C84);
					continue;
				case 1u:
					num = ((int)num2 * -1042988443) ^ 0x2DD32F8D;
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
		string string_ = default(string);
		int num3 = default(int);
		char c2 = default(char);
		char c3 = default(char);
		char c = default(char);
		while (true)
		{
			int num = 1650680927;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x477BDC17u) % 33u)
				{
				case 32u:
					text = JSONNode.smethod_3(text, "\\f");
					num = 1823975726;
					continue;
				case 31u:
					num = (int)(num2 * 431381496) ^ -1379599170;
					continue;
				case 30u:
					goto IL_0034;
				case 29u:
					result = text;
					num = ((int)num2 * -21185443) ^ 0x364AB637;
					continue;
				case 28u:
					num = 1196827437;
					continue;
				case 27u:
					num = ((int)num2 * -1467980532) ^ -689588190;
					continue;
				case 26u:
					num = ((int)num2 * -1896865520) ^ -657451186;
					continue;
				case 25u:
					goto IL_0090;
				case 24u:
					goto IL_00a8;
				case 23u:
					num = ((int)num2 * -1813480272) ^ -1064138610;
					continue;
				case 22u:
					num = ((int)num2 * -1358540974) ^ -1048116322;
					continue;
				case 21u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1823975726;
					continue;
				case 20u:
					string_ = aText;
					num3 = 0;
					num = (int)(num2 * 2015978850) ^ -219951942;
					continue;
				case 19u:
					goto IL_0111;
				case 17u:
					num = ((int)num2 * -1516367669) ^ -1649444956;
					continue;
				case 16u:
					num = (int)((num2 * 432464021) ^ 0x5A7DFFAC);
					continue;
				case 15u:
					num = (int)(num2 * 993070248) ^ -1248181066;
					continue;
				case 14u:
					num = (int)((num2 * 179609783) ^ 0x34A44A8C);
					continue;
				case 13u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1717715017;
					continue;
				case 11u:
				{
					int num6;
					if (c2 != '\\')
					{
						num = 1002909880;
						num6 = 1002909880;
					}
					else
					{
						num = 1062185457;
						num6 = 1062185457;
					}
					continue;
				}
				case 10u:
					num = (int)((num2 * 1741596342) ^ 0x43C43300);
					continue;
				case 9u:
					c3 = c;
					num = (int)(num2 * 1241062790) ^ -1179085686;
					continue;
				case 8u:
					switch (c2)
					{
					case '\f':
						break;
					case '\n':
						goto IL_0034;
					case '\v':
						goto IL_0090;
					case '\b':
						goto IL_00a8;
					case '\t':
						goto IL_0111;
					default:
						goto IL_01f5;
					case '\r':
						goto IL_0208;
					}
					goto case 32u;
				case 0u:
					goto IL_0208;
				case 7u:
					num3++;
					num = (int)(num2 * 1798609399) ^ -1929206357;
					continue;
				case 6u:
					c2 = c3;
					num = (int)((num2 * 156795932) ^ 0x89858B5);
					continue;
				case 5u:
				{
					int num5;
					if (c2 != '"')
					{
						num = 1558056634;
						num5 = 1558056634;
					}
					else
					{
						num = 1958748676;
						num5 = 1958748676;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -31671523) ^ -454790430;
					continue;
				case 3u:
					c = JSONNode.smethod_2(string_, num3);
					num = 1515945858;
					continue;
				case 2u:
					num = (int)(num2 * 1757170970) ^ -1765311257;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 838139784;
						num4 = 838139784;
					}
					else
					{
						num = 695230194;
						num4 = 695230194;
					}
					continue;
				}
				case 12u:
					break;
				default:
					{
						return result;
					}
					IL_0034:
					text = JSONNode.smethod_3(text, "\\n");
					num = 2059094617;
					continue;
					IL_0208:
					text = JSONNode.smethod_3(text, "\\r");
					num = 714986265;
					continue;
					IL_01f5:
					num = (int)(num2 * 1219631953) ^ -286644599;
					continue;
					IL_0111:
					text = JSONNode.smethod_3(text, "\\t");
					num = 338045841;
					continue;
					IL_00a8:
					text = JSONNode.smethod_3(text, "\\b");
					num = 749730864;
					continue;
					IL_0090:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 776804834;
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		Stack<JSONNode> stack = new Stack<JSONNode>();
		JSONNode jSONNode = default(JSONNode);
		char c2 = default(char);
		string text = default(string);
		int num5 = default(int);
		char c = default(char);
		bool flag15 = default(bool);
		JSONNode result = default(JSONNode);
		bool flag10 = default(bool);
		string text2 = default(string);
		bool flag6 = default(bool);
		bool flag12 = default(bool);
		bool flag14 = default(bool);
		bool flag3 = default(bool);
		char c4 = default(char);
		char c3 = default(char);
		bool flag11 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag4 = default(bool);
		bool flag16 = default(bool);
		bool flag13 = default(bool);
		bool flag9 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -463687043;
			while (true)
			{
				uint num2;
				int num26;
				string s;
				switch ((num2 = (uint)num ^ 0xCED8F15Bu) % 152u)
				{
				case 151u:
					num = ((int)num2 * -2046009387) ^ -68510752;
					continue;
				case 150u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 1977223105) ^ -255762102;
					continue;
				case 149u:
					num = (int)(num2 * 1852747237) ^ -1291851790;
					continue;
				case 148u:
				{
					int num51;
					int num52;
					if ((uint)c2 <= 102u)
					{
						num51 = -1811380688;
						num52 = -1811380688;
					}
					else
					{
						num51 = -1408337733;
						num52 = -1408337733;
					}
					num = num51 ^ (int)(num2 * 454585475);
					continue;
				}
				case 147u:
					text = JSONNode.smethod_3(text, "\t");
					num = -721519527;
					continue;
				case 146u:
					num = (int)((num2 * 573985220) ^ 0x20D87546);
					continue;
				case 145u:
				{
					char c5 = JSONNode.smethod_2(aJSON, num5);
					c = c5;
					num = -2098772550;
					continue;
				}
				case 144u:
					num = (int)((num2 * 1280438990) ^ 0x5CE3B8FB);
					continue;
				case 143u:
					num = ((int)num2 * -843172718) ^ 0x4FD645BB;
					continue;
				case 142u:
				{
					int num58;
					int num59;
					if (flag15)
					{
						num58 = -722409966;
						num59 = -722409966;
					}
					else
					{
						num58 = -1886616695;
						num59 = -1886616695;
					}
					num = num58 ^ ((int)num2 * -1005123178);
					continue;
				}
				case 141u:
					result = jSONNode;
					num = -2011044460;
					continue;
				case 140u:
				{
					int num45;
					int num46;
					if (!flag10)
					{
						num45 = 30335702;
						num46 = 30335702;
					}
					else
					{
						num45 = 1875010282;
						num46 = 1875010282;
					}
					num = num45 ^ ((int)num2 * -2024721266);
					continue;
				}
				case 138u:
					goto IL_0140;
				case 137u:
					stack.Push(new JSONClass());
					num = -1480368530;
					continue;
				case 136u:
					text = "";
					num = ((int)num2 * -1901198122) ^ -6031091;
					continue;
				case 135u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -2014422508) ^ 0x3D7641F3;
					continue;
				case 134u:
					num = (int)((num2 * 618567637) ^ 0x7B077F93);
					continue;
				case 133u:
				{
					int num21;
					int num22;
					if (stack.Count <= 0)
					{
						num21 = -1800529790;
						num22 = -1800529790;
					}
					else
					{
						num21 = -1387420906;
						num22 = -1387420906;
					}
					num = num21 ^ ((int)num2 * -1422213451);
					continue;
				}
				case 132u:
					num5++;
					num = -1113339500;
					continue;
				case 131u:
					text2 = text;
					num = -440909290;
					continue;
				case 130u:
					num = -227342027;
					continue;
				case 129u:
					num = (int)((num2 * 191841812) ^ 0x60E4B27F);
					continue;
				case 128u:
				{
					int num64;
					if (!flag6)
					{
						num = -2024865696;
						num64 = -2024865696;
					}
					else
					{
						num = -404505153;
						num64 = -404505153;
					}
					continue;
				}
				case 127u:
					num = ((int)num2 * -244675388) ^ -769663804;
					continue;
				case 126u:
				{
					int num56;
					int num57;
					if (flag12)
					{
						num56 = 1477815403;
						num57 = 1477815403;
					}
					else
					{
						num56 = 755098392;
						num57 = 755098392;
					}
					num = num56 ^ (int)(num2 * 1947531771);
					continue;
				}
				case 125u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -473059430;
					continue;
				case 124u:
				{
					int num53;
					if (c == '"')
					{
						num = -1650677469;
						num53 = -1650677469;
					}
					else
					{
						num = -513998391;
						num53 = -513998391;
					}
					continue;
				}
				case 123u:
					flag14 = jSONNode is JSONArray;
					num = (int)((num2 * 1705113128) ^ 0x7400F4AB);
					continue;
				case 122u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)(num2 * 1818252218) ^ -720353274;
					continue;
				case 121u:
					flag15 = JSONNode.smethod_6(text, "");
					num = -603465643;
					continue;
				case 120u:
				{
					int num41;
					int num42;
					if (!flag14)
					{
						num41 = 248755855;
						num42 = 248755855;
					}
					else
					{
						num41 = 1782666133;
						num42 = 1782666133;
					}
					num = num41 ^ (int)(num2 * 1128402270);
					continue;
				}
				case 119u:
				{
					int num38;
					if (c != ' ')
					{
						num = -1144788727;
						num38 = -1144788727;
					}
					else
					{
						num = -1622584040;
						num38 = -1622584040;
					}
					continue;
				}
				case 118u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = -1902088794;
					continue;
				case 117u:
					switch (c)
					{
					case '\\':
						break;
					default:
						goto IL_0394;
					case '[':
						goto IL_039e;
					case ']':
						goto IL_03ac;
					}
					goto case 132u;
				case 51u:
					goto IL_039e;
				case 60u:
					goto IL_03ac;
				case 116u:
				{
					int num33;
					if (c2 == 'n')
					{
						num = -838776072;
						num33 = -838776072;
					}
					else
					{
						num = -87373100;
						num33 = -87373100;
					}
					continue;
				}
				case 115u:
					flag3 = JSONNode.smethod_6(text2, "");
					num = -1591005191;
					continue;
				case 114u:
					num = (int)(num2 * 736681453) ^ -485250479;
					continue;
				case 113u:
					num = (int)((num2 * 511762005) ^ 0x15AF208C);
					continue;
				case 112u:
					switch (c)
					{
					case '\v':
					case '\f':
						break;
					default:
						goto IL_0438;
					case '\t':
						goto IL_044b;
					case '\n':
					case '\r':
						goto IL_046b;
					}
					goto case 118u;
				case 99u:
					goto IL_044b;
				case 2u:
				case 48u:
				case 56u:
				case 70u:
				case 95u:
					goto IL_046b;
				case 111u:
					c4 = c3;
					num = ((int)num2 * -729987189) ^ 0x1D81A57C;
					continue;
				case 110u:
				{
					int num19;
					int num20;
					if (flag11)
					{
						num19 = 436210807;
						num20 = 436210807;
					}
					else
					{
						num19 = 295118128;
						num20 = 295118128;
					}
					num = num19 ^ ((int)num2 * -1011828413);
					continue;
				}
				case 109u:
					num = ((int)num2 * -554363781) ^ 0x15286F34;
					continue;
				case 108u:
					num = (int)(num2 * 1570122790) ^ -1928667935;
					continue;
				case 107u:
					num = (int)(num2 * 177741293) ^ -934072322;
					continue;
				case 106u:
					flag8 = stack.Count == 0;
					num = -480699783;
					continue;
				case 105u:
					flag7 = flag6;
					num = -419865026;
					continue;
				case 104u:
					flag6 = !flag6;
					num = -1372953090;
					continue;
				case 103u:
				{
					int num11;
					int num12;
					if (flag5)
					{
						num11 = 1168894692;
						num12 = 1168894692;
					}
					else
					{
						num11 = 1766697859;
						num12 = 1766697859;
					}
					num = num11 ^ ((int)num2 * -608461281);
					continue;
				}
				case 102u:
					text2 = "";
					num = -205755420;
					continue;
				case 101u:
					num = (int)((num2 * 1886045184) ^ 0x60B4409);
					continue;
				case 98u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1076092673) ^ 0x21A4E58D;
					continue;
				case 97u:
					num = -1988857780;
					continue;
				case 96u:
					num = ((int)num2 * -779482343) ^ 0x2B7DDD62;
					continue;
				case 94u:
					jSONNode = null;
					num = ((int)num2 * -937210920) ^ -347939309;
					continue;
				case 93u:
					jSONNode.Add(text);
					num = (int)(num2 * 1198854109) ^ -235395608;
					continue;
				case 92u:
					num = (int)(num2 * 1029249314) ^ -1210788461;
					continue;
				case 91u:
					num = (int)(num2 * 437503473) ^ -1179464758;
					continue;
				case 90u:
				{
					int num62;
					int num63;
					if (!flag2)
					{
						num62 = 788160723;
						num63 = 788160723;
					}
					else
					{
						num62 = 1536724886;
						num63 = 1536724886;
					}
					num = num62 ^ (int)(num2 * 1712085585);
					continue;
				}
				case 89u:
				{
					int num60;
					int num61;
					if ((uint)c > 44u)
					{
						num60 = 1027093132;
						num61 = 1027093132;
					}
					else
					{
						num60 = 957530662;
						num61 = 957530662;
					}
					num = num60 ^ (int)(num2 * 335340908);
					continue;
				}
				case 88u:
					num5 = 0;
					text = "";
					text2 = "";
					num = (int)(num2 * 644337228) ^ -1223825198;
					continue;
				case 87u:
					num = ((int)num2 * -72772727) ^ -1426500276;
					continue;
				case 86u:
					goto IL_069d;
				case 85u:
					flag4 = jSONNode != null;
					num = ((int)num2 * -1972458591) ^ -52170157;
					continue;
				case 84u:
					flag16 = JSONNode.smethod_6(text2, "");
					num = -1766203698;
					continue;
				case 83u:
					num = (int)((num2 * 1397401273) ^ 0x6855E018);
					continue;
				case 82u:
					c2 = c4;
					num = (int)((num2 * 2035325567) ^ 0x7B5329C9);
					continue;
				case 81u:
					flag6 = false;
					num = ((int)num2 * -558400928) ^ -184495720;
					continue;
				case 80u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1972017793) ^ 0x5FE5819F;
					continue;
				case 79u:
				{
					int num54;
					int num55;
					if (flag6)
					{
						num54 = 1215303220;
						num55 = 1215303220;
					}
					else
					{
						num54 = 1112969214;
						num55 = 1112969214;
					}
					num = num54 ^ (int)(num2 * 462665541);
					continue;
				}
				case 78u:
					goto IL_0792;
				case 77u:
				{
					int num49;
					int num50;
					if (!flag16)
					{
						num49 = -79138395;
						num50 = -79138395;
					}
					else
					{
						num49 = -118644793;
						num50 = -118644793;
					}
					num = num49 ^ ((int)num2 * -1521231372);
					continue;
				}
				case 76u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1794956589) ^ -1411920249;
					continue;
				case 75u:
					flag5 = flag6;
					num = -465324940;
					continue;
				case 74u:
					num = (int)(num2 * 835608108) ^ -1477312115;
					continue;
				case 73u:
				{
					int num47;
					int num48;
					if (c != ':')
					{
						num47 = -1546651303;
						num48 = -1546651303;
					}
					else
					{
						num47 = -1319838958;
						num48 = -1319838958;
					}
					num = num47 ^ (int)(num2 * 439353409);
					continue;
				}
				case 72u:
					num = ((int)num2 * -979510204) ^ -1812870910;
					continue;
				case 71u:
					text2 = "";
					num = -164473669;
					continue;
				case 69u:
				{
					int num43;
					int num44;
					if (flag7)
					{
						num43 = 503532022;
						num44 = 503532022;
					}
					else
					{
						num43 = 559373009;
						num44 = 559373009;
					}
					num = num43 ^ (int)(num2 * 932547759);
					continue;
				}
				case 68u:
					num = (int)((num2 * 704603581) ^ 0x52909DE9);
					continue;
				case 67u:
				{
					int num39;
					int num40;
					if (jSONNode is JSONArray)
					{
						num39 = -1078295640;
						num40 = -1078295640;
					}
					else
					{
						num39 = -566081158;
						num40 = -566081158;
					}
					num = num39 ^ (int)(num2 * 1776377911);
					continue;
				}
				case 66u:
					num = -335952075;
					continue;
				case 65u:
					num = -1057419331;
					continue;
				case 64u:
					flag13 = jSONNode != null;
					num = (int)((num2 * 751306911) ^ 0x53526B3C);
					continue;
				case 63u:
				{
					int num36;
					int num37;
					if (flag13)
					{
						num36 = 737163168;
						num37 = 737163168;
					}
					else
					{
						num36 = 1624613358;
						num37 = 1624613358;
					}
					num = num36 ^ (int)(num2 * 679283598);
					continue;
				}
				case 62u:
					text2 = "";
					text = "";
					num = -1372535879;
					continue;
				case 61u:
				{
					int num34;
					int num35;
					if (flag6)
					{
						num34 = -128644537;
						num35 = -128644537;
					}
					else
					{
						num34 = -1101192898;
						num35 = -1101192898;
					}
					num = num34 ^ (int)(num2 * 492597456);
					continue;
				}
				case 59u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)((num2 * 605586660) ^ 0x291E5BB0);
					continue;
				case 57u:
					c3 = JSONNode.smethod_2(aJSON, num5);
					num = (int)(num2 * 427290143) ^ -747489197;
					continue;
				case 55u:
					jSONNode.Add(text2, text);
					num = (int)((num2 * 1507496176) ^ 0x275C2AE8);
					continue;
				case 54u:
					switch (c2)
					{
					case 't':
						break;
					case 's':
						goto IL_0140;
					case 'u':
						goto IL_069d;
					case 'r':
						goto IL_0792;
					default:
						goto IL_09e1;
					}
					goto case 147u;
				case 53u:
				{
					int num31;
					int num32;
					if (!(jSONNode is JSONArray))
					{
						num31 = -72338022;
						num32 = -72338022;
					}
					else
					{
						num31 = -1279527476;
						num32 = -1279527476;
					}
					num = num31 ^ (int)(num2 * 1154107842);
					continue;
				}
				case 52u:
					flag12 = JSONNode.smethod_6(text2, "");
					num = -1675052555;
					continue;
				case 50u:
				{
					int num29;
					int num30;
					if (!flag8)
					{
						num29 = -412104428;
						num30 = -412104428;
					}
					else
					{
						num29 = -889278215;
						num30 = -889278215;
					}
					num = num29 ^ (int)(num2 * 2133624652);
					continue;
				}
				case 49u:
				{
					int num27;
					int num28;
					if ((uint)c > 32u)
					{
						num27 = 17136057;
						num28 = 17136057;
					}
					else
					{
						num27 = 878810973;
						num28 = 878810973;
					}
					num = num27 ^ ((int)num2 * -784495794);
					continue;
				}
				case 47u:
				{
					int num25;
					if (c == '{')
					{
						num = -2051717616;
						num25 = -2051717616;
					}
					else
					{
						num = -1403423866;
						num25 = -1403423866;
					}
					continue;
				}
				case 46u:
					num = (int)((num2 * 833689747) ^ 0x3150FD4B);
					continue;
				case 45u:
					num = ((int)num2 * -1714583851) ^ 0x6C8793EA;
					continue;
				case 44u:
					num = ((int)num2 * -596120219) ^ -711827802;
					continue;
				case 43u:
					text = JSONNode.smethod_3(text, "\n");
					num = -721519527;
					continue;
				case 42u:
				{
					int num24;
					if (c2 != 'f')
					{
						num = -1926121905;
						num24 = -1926121905;
					}
					else
					{
						num = -1555423261;
						num24 = -1555423261;
					}
					continue;
				}
				case 41u:
					num = (int)((num2 * 630763953) ^ 0xF06FE92);
					continue;
				case 40u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -945954645) ^ -452376248;
					continue;
				case 39u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1088553170) ^ 0x2A80B35);
					continue;
				case 38u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 277670825) ^ -1459612540;
					continue;
				case 37u:
					text = "";
					num = (int)(num2 * 1940952800) ^ -1695795005;
					continue;
				case 36u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1702652636) ^ -456548037;
					continue;
				case 35u:
				{
					int num23;
					if ((uint)c > 93u)
					{
						num = -519710236;
						num23 = -519710236;
					}
					else
					{
						num = -2085344222;
						num23 = -2085344222;
					}
					continue;
				}
				case 34u:
				{
					int num17;
					int num18;
					if (!flag9)
					{
						num17 = 1395173664;
						num18 = 1395173664;
					}
					else
					{
						num17 = 1254928574;
						num18 = 1254928574;
					}
					num = num17 ^ (int)(num2 * 1728373421);
					continue;
				}
				case 33u:
					stack.Push(new JSONArray());
					num = -502935525;
					continue;
				case 32u:
					flag10 = num5 < JSONNode.smethod_4(aJSON);
					num = -651160929;
					continue;
				case 31u:
				{
					stack.Pop();
					int num16;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -2069689732;
						num16 = -2069689732;
					}
					else
					{
						num = -227342027;
						num16 = -227342027;
					}
					continue;
				}
				case 30u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -1559795988) ^ -253722977;
					continue;
				case 29u:
					num = (int)(num2 * 780402980) ^ -1239409042;
					continue;
				case 28u:
					num = ((int)num2 * -969214100) ^ 0x2F17A022;
					continue;
				case 27u:
					num = (int)((num2 * 507959575) ^ 0x7218C2DF);
					continue;
				case 26u:
					flag9 = JSONNode.smethod_6(text2, "");
					num = -367526111;
					continue;
				case 25u:
					text = JSONNode.smethod_3(text, "\b");
					num = -721519527;
					continue;
				case 24u:
					num = (int)((num2 * 452487194) ^ 0x141D47D5);
					continue;
				case 23u:
				{
					int num14;
					int num15;
					if (c2 != 'b')
					{
						num14 = 529059001;
						num15 = 529059001;
					}
					else
					{
						num14 = 1287926037;
						num15 = 1287926037;
					}
					num = num14 ^ (int)(num2 * 1431225969);
					continue;
				}
				case 22u:
				{
					int num13;
					if (c != '}')
					{
						num = -1040676869;
						num13 = -1040676869;
					}
					else
					{
						num = -1449543401;
						num13 = -1449543401;
					}
					continue;
				}
				case 21u:
				{
					int num9;
					int num10;
					if (!flag4)
					{
						num9 = 914619187;
						num10 = 914619187;
					}
					else
					{
						num9 = 134508883;
						num10 = 134508883;
					}
					num = num9 ^ ((int)num2 * -1453706647);
					continue;
				}
				case 20u:
					num = (int)((num2 * 1928052491) ^ 0x23D4AC6F);
					continue;
				case 19u:
					num = (int)(num2 * 358049086) ^ -168665844;
					continue;
				case 18u:
					num = (int)(num2 * 1454699407) ^ -326956880;
					continue;
				case 17u:
					num = -2041118954;
					continue;
				case 16u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 1397809602) ^ -2126476832;
					continue;
				case 15u:
					text = "";
					num = (int)((num2 * 1454505141) ^ 0x5513599D);
					continue;
				case 14u:
					jSONNode.Add(text);
					num = (int)(num2 * 1780709605) ^ -1826245241;
					continue;
				case 13u:
				{
					int num8;
					if (c == ',')
					{
						num = -1431441278;
						num8 = -1431441278;
					}
					else
					{
						num = -1353346185;
						num8 = -1353346185;
					}
					continue;
				}
				case 12u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = (int)(num2 * 493866182) ^ -2090147137;
					continue;
				case 10u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = -1878980714;
						num7 = -1878980714;
					}
					else
					{
						num6 = -1933326472;
						num7 = -1933326472;
					}
					num = num6 ^ (int)(num2 * 530320918);
					continue;
				}
				case 9u:
					num = (int)(num2 * 1120267875) ^ -1701310521;
					continue;
				case 8u:
					text2 = JSONNode.smethod_5(text2);
					flag2 = jSONNode is JSONArray;
					num = ((int)num2 * -61907532) ^ -1016248255;
					continue;
				case 7u:
					num = ((int)num2 * -1900022431) ^ 0x55F42D92;
					continue;
				case 6u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num5).ToString());
					num = ((int)num2 * -1008795079) ^ 0x44F6259D;
					continue;
				case 5u:
					num = (int)((num2 * 1916368089) ^ 0x10AD9950);
					continue;
				case 4u:
					num = ((int)num2 * -393719097) ^ 0x5F783515;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1959946128;
						num4 = 1959946128;
					}
					else
					{
						num3 = 741731014;
						num4 = 741731014;
					}
					num = num3 ^ ((int)num2 * -1431091291);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1075455984) ^ -1389714693;
					continue;
				case 0u:
					text = JSONNode.smethod_3(text, "\f");
					num = -721519527;
					continue;
				case 11u:
					break;
				case 58u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 100u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_046b:
					num5++;
					num = -1183708973;
					continue;
					IL_044b:
					if (flag6)
					{
						num = -1992619264;
						num26 = -1992619264;
					}
					else
					{
						num = -239616324;
						num26 = -239616324;
					}
					continue;
					IL_0438:
					num = (int)(num2 * 393441365) ^ -1542735646;
					continue;
					IL_09e1:
					num = -1178809512;
					continue;
					IL_03ac:
					flag = flag6;
					num = -752618936;
					continue;
					IL_039e:
					flag11 = flag6;
					num = -1271390587;
					continue;
					IL_0394:
					num = -1366890748;
					continue;
					IL_0140:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -1248791078;
					continue;
					IL_0792:
					text = JSONNode.smethod_3(text, "\r");
					num = -2046274504;
					continue;
					IL_069d:
					s = JSONNode.smethod_8(aJSON, num5 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num5 += 4;
					num = -721519527;
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
			int num = 101488600;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CE412D3u) % 5u)
				{
				case 4u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -1664094317) ^ 0x21F45620;
					continue;
				case 2u:
					Serialize(aWriter);
					num = ((int)num2 * -1120146587) ^ -1567525376;
					continue;
				case 1u:
					num = ((int)num2 * -1760989736) ^ 0x7E046AB0;
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
			while (true)
			{
				int num = 474315304;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x42D3A34Cu) % 5u)
					{
					case 2u:
						num = ((int)num2 * -528249424) ^ 0x23406E80;
						continue;
					case 1u:
						SaveToStream(fileStream);
						num = ((int)num2 * -306871804) ^ 0xB1E84C3;
						continue;
					case 0u:
						num = ((int)num2 * -343334941) ^ -1125372101;
						continue;
					default:
						return;
					case 4u:
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
					IL_00c8:
					int num3 = 44535561;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x42D3A34Cu) % 4u)
						{
						case 1u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = ((int)num2 * -1138448983) ^ 0x1D2BADF1;
							continue;
						case 0u:
							num3 = ((int)num2 * -530980025) ^ 0x6ECF5EA6;
							continue;
						default:
							goto end_IL_00a7;
						case 3u:
							break;
						case 2u:
							goto end_IL_00a7;
						}
						goto IL_00c8;
						continue;
						end_IL_00a7:
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
			string result = default(string);
			while (true)
			{
				int num = -902952460;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x971F33F3u) % 4u)
					{
					case 3u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)((num2 * 924472411) ^ 0x33B071B4);
						continue;
					case 2u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 478477605) ^ 0x22911050);
						continue;
					case 0u:
						break;
					default:
						return result;
					case 1u:
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
					IL_00b8:
					int num3 = -1271191923;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x971F33F3u) % 4u)
						{
						case 2u:
							JSONNode.smethod_15((IDisposable)memoryStream);
							num3 = (int)(num2 * 678453588) ^ -1989496026;
							continue;
						case 1u:
							num3 = (int)(num2 * 1609219395) ^ -842733912;
							continue;
						default:
							goto end_IL_0097;
						case 3u:
							break;
						case 0u:
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
		int num4 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		int num8 = default(int);
		bool flag = default(bool);
		JSONNode result = default(JSONNode);
		JSONArray jSONArray = default(JSONArray);
		JSONClass jSONClass = default(JSONClass);
		string aKey = default(string);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		int num3 = default(int);
		while (true)
		{
			int num = -169536019;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C81F536u) % 40u)
				{
				case 39u:
					num = -1212529606;
					continue;
				case 38u:
					num4++;
					num = ((int)num2 * -951566145) ^ -1154530197;
					continue;
				case 37u:
					flag2 = num5 < num8;
					num = -2039334230;
					continue;
				case 36u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1859824378;
						num10 = 1859824378;
					}
					else
					{
						num9 = 536369304;
						num10 = 536369304;
					}
					num = num9 ^ ((int)num2 * -160341408);
					continue;
				}
				case 34u:
					goto IL_0064;
				case 33u:
					goto IL_006e;
				case 32u:
					num = ((int)num2 * -1860215548) ^ -564762377;
					continue;
				case 31u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -692223576;
						num7 = -692223576;
					}
					else
					{
						num6 = -425751498;
						num7 = -425751498;
					}
					num = num6 ^ (int)(num2 * 240810027);
					continue;
				}
				case 30u:
					num5 = 0;
					num = (int)(num2 * 1843831224) ^ -701209269;
					continue;
				case 29u:
					result = jSONArray;
					num = (int)(num2 * 397011404) ^ -1724644679;
					continue;
				case 28u:
					result = jSONClass;
					num = ((int)num2 * -531951066) ^ 0x242927AD;
					continue;
				case 27u:
					goto IL_0100;
				case 26u:
				{
					JSONNode aItem = Deserialize(aReader);
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1324134260) ^ 0x3484519E;
					continue;
				}
				case 25u:
					num5++;
					num = ((int)num2 * -2131725419) ^ 0x25586E8E;
					continue;
				case 24u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = (int)(num2 * 1204226149) ^ -634915819;
					continue;
				case 23u:
					num = (int)((num2 * 1988027443) ^ 0x77A4ACDE);
					continue;
				case 22u:
					num4 = 0;
					num = (int)((num2 * 115792988) ^ 0x36BA9D5C);
					continue;
				case 20u:
					jSONClass = new JSONClass();
					num = (int)((num2 * 2086636212) ^ 0x138A0C10);
					continue;
				case 19u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)(num2 * 1262566565) ^ -181353449;
					continue;
				case 18u:
					num = (int)(num2 * 1413475023) ^ -1207454353;
					continue;
				case 17u:
					switch (jSONBinaryTag3)
					{
					case JSONBinaryTag.IntValue:
						break;
					case JSONBinaryTag.BoolValue:
						goto IL_0064;
					case JSONBinaryTag.Class:
						goto IL_006e;
					case JSONBinaryTag.FloatValue:
						goto IL_0100;
					default:
						goto IL_020c;
					case JSONBinaryTag.Array:
						goto IL_021f;
					case JSONBinaryTag.Value:
						goto IL_0229;
					case JSONBinaryTag.DoubleValue:
						goto IL_0233;
					}
					goto case 39u;
				case 0u:
					goto IL_021f;
				case 8u:
					goto IL_0229;
				case 4u:
					goto IL_0233;
				case 16u:
					num = ((int)num2 * -549914847) ^ -1036825915;
					continue;
				case 15u:
					flag = num4 < num3;
					num = -1597452335;
					continue;
				case 14u:
					jSONBinaryTag3 = jSONBinaryTag2;
					num = (int)((num2 * 1863541152) ^ 0x24BCB22F);
					continue;
				case 13u:
					num = -1143188193;
					continue;
				case 12u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = (int)((num2 * 1646300404) ^ 0x650F6266);
					continue;
				case 11u:
					jSONArray.Add(Deserialize(aReader));
					num = -297561808;
					continue;
				case 10u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = (int)(num2 * 1723230175) ^ -1469929069;
					continue;
				case 7u:
					num3 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1049542402) ^ -1270933667;
					continue;
				case 6u:
					aKey = JSONNode.smethod_22(aReader);
					num = -1552244084;
					continue;
				case 5u:
					num = (int)(num2 * 1145593422) ^ -1149335549;
					continue;
				case 3u:
					num = (int)(num2 * 1437604931) ^ -128361820;
					continue;
				case 2u:
					num = (int)((num2 * 1020057800) ^ 0x731375F5);
					continue;
				case 1u:
					jSONArray = new JSONArray();
					num = ((int)num2 * -84128242) ^ -846604138;
					continue;
				case 21u:
					break;
				case 9u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0233:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -1069307421;
					continue;
					IL_0229:
					num = -1769684220;
					continue;
					IL_021f:
					num = -644137983;
					continue;
					IL_020c:
					num = ((int)num2 * -1678774536) ^ -2104637503;
					continue;
					IL_0100:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = -1859685244;
					continue;
					IL_006e:
					num8 = JSONNode.smethod_21(aReader);
					num = -1591032958;
					continue;
					IL_0064:
					num = -1829157626;
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
					int num = 1864543840;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x79E2574Bu) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num = (int)(num2 * 581266937) ^ -1094772725;
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -803520122;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA5732B84u) % 3u)
					{
					case 2u:
						goto IL_000a;
					case 0u:
						break;
					default:
						return result;
					case 1u:
						return result;
					}
					break;
					IL_000a:
					result = LoadFromStream(fileStream);
					num = (int)((num2 * 1203957483) ^ 0x44A82F37);
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
					int num3 = -1463998890;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xA5732B84u) % 3u)
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
						num3 = (int)((num2 * 762916971) ^ 0x1C2016D1);
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
		MemoryStream memoryStream = JSONNode.smethod_29(byte_);
		JSONNode.smethod_17((Stream)memoryStream, 0L);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 1515504265;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x594BF5BBu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -2083518226) ^ 0x25960FD4;
					continue;
				case 2u:
					result = LoadFromStream(memoryStream);
					num = (int)((num2 * 2134083391) ^ 0x3FAACFFE);
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
			int num = 641854723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C67A20Eu) % 3u)
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
				num = ((int)num2 * -578846269) ^ -551281672;
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
