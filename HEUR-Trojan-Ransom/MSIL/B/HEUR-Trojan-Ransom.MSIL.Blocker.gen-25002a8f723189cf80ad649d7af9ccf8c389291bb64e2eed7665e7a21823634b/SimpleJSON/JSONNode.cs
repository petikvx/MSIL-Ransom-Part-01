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
				int num = 544636651;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1DA0812Eu) % 3u)
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
					num = ((int)num2 * -281332582) ^ -1237574309;
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
				int num = 2118927936;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x289C8524u) % 3u)
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
					num = (int)((num2 * 517571370) ^ 0x1C8500B1);
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
				int num = -1211571577;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C859021u) % 3u)
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
					result = "";
					num = (int)(num2 * 2068148835) ^ -457685;
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
				int num = 1512219955;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FD1E2F4u) % 4u)
					{
					case 3u:
						result = 0;
						num = ((int)num2 * -140002876) ^ -415211719;
						continue;
					case 1u:
						num = ((int)num2 * -858543011) ^ 0x390EE7CB;
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
				int num = -722602987;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF2EECE9Bu) % 3u)
					{
					case 1u:
						goto IL_000a;
					case 2u:
						break;
					default:
						return result;
					}
					break;
					IL_000a:
					_003Cget_Childs_003Ed__._003C_003E4__this = this;
					result = _003Cget_Childs_003Ed__;
					num = ((int)num2 * -396520921) ^ 0x503EFB25;
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
				int num = -1701202107;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE62F7706u) % 9u)
					{
					case 7u:
						result = 0;
						num = -1404458435;
						continue;
					case 6u:
						result = result2;
						num = (int)((num2 * 501234386) ^ 0x55D9D884);
						continue;
					case 5u:
						num = ((int)num2 * -638749068) ^ 0x56F57388;
						continue;
					case 4u:
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 1558368650) ^ 0xE84612D);
						continue;
					case 3u:
						num = ((int)num2 * -1103752832) ^ -2113173504;
						continue;
					case 1u:
						result2 = 0;
						num = ((int)num2 * -6741664) ^ 0x3E8882D1;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -710764512;
							num4 = -710764512;
						}
						else
						{
							num3 = -603984439;
							num4 = -603984439;
						}
						num = num3 ^ ((int)num2 * -60952281);
						continue;
					}
					case 8u:
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
			while (true)
			{
				int num = -1040415847;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDCC2FA21u) % 5u)
					{
					case 4u:
						result2 = 0f;
						num = -1194878843;
						continue;
					case 3u:
						result2 = result;
						num = ((int)num2 * -827770677) ^ 0x5FA8AE12;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result))
						{
							num3 = -181086780;
							num4 = -181086780;
						}
						else
						{
							num3 = -367201808;
							num4 = -367201808;
						}
						num = num3 ^ (int)(num2 * 229797248);
						continue;
					}
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
			Value = value.ToString();
			while (true)
			{
				int num = 914113060;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x437CD814u) % 3u)
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
					num = ((int)num2 * -1455846850) ^ -598552907;
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
			while (true)
			{
				int num = 543074195;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x519C260u) % 6u)
					{
					case 5u:
					{
						result2 = 0.0;
						int num3;
						int num4;
						if (!double.TryParse(Value, out result2))
						{
							num3 = -1208841217;
							num4 = -1208841217;
						}
						else
						{
							num3 = -871654749;
							num4 = -871654749;
						}
						num = num3 ^ (int)(num2 * 484522889);
						continue;
					}
					case 4u:
						result = result2;
						num = (int)(num2 * 2087092015) ^ -723662709;
						continue;
					case 2u:
						num = (int)(num2 * 804059486) ^ -45956121;
						continue;
					case 0u:
						result = 0.0;
						num = 66514774;
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
			Value = value.ToString();
			while (true)
			{
				int num = 755951579;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4B70988Fu) % 3u)
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
					num = ((int)num2 * -1167778319) ^ 0x7AC4A20F;
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
				int num = -1641223218;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC9F62D0Cu) % 8u)
					{
					case 7u:
						result = result2;
						num = ((int)num2 * -1894856681) ^ -644013618;
						continue;
					case 5u:
						num = (int)(num2 * 1063313768) ^ -505437792;
						continue;
					case 3u:
						num = (int)(num2 * 1370094803) ^ -325711823;
						continue;
					case 2u:
						result2 = false;
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -1078838754) ^ 0x35259001;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = -1043701017;
							num4 = -1043701017;
						}
						else
						{
							num3 = -221346200;
							num4 = -221346200;
						}
						num = num3 ^ ((int)num2 * -1190508205);
						continue;
					}
					case 0u:
						result = !JSONNode.smethod_1(Value);
						num = -776049239;
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
				int num = -1061021086;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB532D560u) % 4u)
					{
					case 2u:
						result = this as JSONArray;
						num = ((int)num2 * -1414049838) ^ -2115864547;
						continue;
					case 1u:
						num = ((int)num2 * -899265169) ^ -1991449925;
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

	public virtual JSONClass AsObject
	{
		get
		{
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 1503605403;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x223FE404u) % 4u)
					{
					case 3u:
						result = this as JSONClass;
						num = (int)(num2 * 512687648) ^ -685107582;
						continue;
					case 2u:
						num = (int)(num2 * 589086240) ^ -1621455507;
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

	public virtual void Add(string aKey, JSONNode aItem)
	{
	}

	public virtual void Add(JSONNode aItem)
	{
		while (true)
		{
			int num = 706148248;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7974342u) % 3u)
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
				num = ((int)num2 * -337800865) ^ -91903327;
			}
		}
	}

	public virtual JSONNode Remove(string aKey)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1233091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80A6C4DEu) % 3u)
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
				num = (int)((num2 * 482707120) ^ 0x1E4FF465);
			}
		}
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -555851273;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB0376F4u) % 4u)
				{
				case 3u:
					result = null;
					num = (int)(num2 * 451371644) ^ -715066120;
					continue;
				case 0u:
					num = ((int)num2 * -118523675) ^ 0x5957E32D;
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
		while (true)
		{
			int num = -1560701958;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85AC4D2Fu) % 3u)
				{
				case 1u:
					goto IL_0004;
				case 0u:
					break;
				default:
					return aNode;
				}
				break;
				IL_0004:
				num = (int)((num2 * 1185274508) ^ 0x5B825B24);
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1754669938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA704E16Fu) % 3u)
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
				num = ((int)num2 * -729614160) ^ 0x226A2EBF;
			}
		}
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 526777934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E47159Du) % 4u)
				{
				case 3u:
					result = "JSONNode";
					num = (int)(num2 * 1728907869) ^ -2002042992;
					continue;
				case 2u:
					num = ((int)num2 * -136797322) ^ 0x1BCBCD3C;
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
			int num = -194942914;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA74507FFu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -540136375) ^ 0x72C2E809;
					continue;
				case 1u:
					result = new JSONData(s);
					num = (int)((num2 * 1382686296) ^ 0x465C0D55);
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
			int num = 1304131371;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0x1E5E39DEu) % 4u)
				{
				case 1u:
					if (!(d == null))
					{
						num = ((int)num2 * -1828179182) ^ -218470588;
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
					num = 1406895705;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator ==(JSONNode a, object b)
	{
		if (b != null)
		{
			goto IL_0006;
		}
		goto IL_003f;
		IL_003f:
		int num = -464260749;
		goto IL_0044;
		IL_0044:
		bool result = default(bool);
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xEE384142u) % 6u)
			{
			case 5u:
				result = (object)a == b;
				num = -79939754;
				continue;
			case 2u:
				result = true;
				num = ((int)num2 * -529083252) ^ 0x3B541973;
				continue;
			case 1u:
				num = (int)((num2 * 1974713554) ^ 0x7C4CC94);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_006d;
			default:
				return result;
			}
			break;
			IL_006d:
			if (a is JSONLazyCreator)
			{
				num = -975099340;
				num3 = -975099340;
				continue;
			}
			goto IL_0006;
		}
		goto IL_003f;
		IL_0006:
		num = -1928647315;
		num3 = -1928647315;
		goto IL_0044;
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = 293874464;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x44BAF8FBu) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = ((int)num2 * -1663438199) ^ 0x61B088CE;
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 716672326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6460EC95u) % 3u)
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
				num = ((int)num2 * -824335018) ^ -1950231165;
			}
		}
	}

	public override int GetHashCode()
	{
		int result = this.method_0();
		while (true)
		{
			int num = -1021042722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCAA491A8u) % 3u)
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
				num = (int)((num2 * 729909345) ^ 0x182E0F41);
			}
		}
	}

	internal static string Escape(string aText)
	{
		int num3 = default(int);
		string string_ = default(string);
		string text = default(string);
		char c = default(char);
		char c3 = default(char);
		string result = default(string);
		while (true)
		{
			int num = 2123746838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79B030CDu) % 31u)
				{
				case 30u:
					num = (int)(num2 * 1057435961) ^ -1744565459;
					continue;
				case 29u:
				{
					int num6;
					if (num3 < JSONNode.smethod_4(string_))
					{
						num = 544437883;
						num6 = 544437883;
					}
					else
					{
						num = 1035646612;
						num6 = 1035646612;
					}
					continue;
				}
				case 28u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1851073173;
					continue;
				case 27u:
					text = JSONNode.smethod_3(text, c.ToString());
					num = 1301932572;
					continue;
				case 26u:
				{
					int num5;
					if (c3 == '"')
					{
						num = 1331711950;
						num5 = 1331711950;
					}
					else
					{
						num = 104675126;
						num5 = 104675126;
					}
					continue;
				}
				case 25u:
				{
					int num4;
					if (c3 != '\\')
					{
						num = 1795163214;
						num4 = 1795163214;
					}
					else
					{
						num = 1303492552;
						num4 = 1303492552;
					}
					continue;
				}
				case 24u:
					switch (c3)
					{
					case '\v':
						break;
					default:
						goto IL_00d1;
					case '\b':
						goto IL_00e4;
					case '\t':
						goto IL_00fa;
					case '\n':
						goto IL_0110;
					case '\f':
						goto IL_0126;
					case '\r':
						goto IL_013c;
					}
					goto case 27u;
				case 11u:
					goto IL_00e4;
				case 22u:
					goto IL_00fa;
				case 23u:
					goto IL_0110;
				case 1u:
					goto IL_0126;
				case 8u:
					goto IL_013c;
				case 21u:
					string_ = aText;
					num = (int)(num2 * 1380233494) ^ -218258995;
					continue;
				case 20u:
					num = ((int)num2 * -981047130) ^ 0x185820FE;
					continue;
				case 19u:
					text = "";
					num = ((int)num2 * -117353455) ^ -1918946390;
					continue;
				case 18u:
					num = (int)(num2 * 1639169332) ^ -1948202626;
					continue;
				case 17u:
					num = (int)((num2 * 1562557359) ^ 0x7F6D2EBE);
					continue;
				case 16u:
					num = (int)(num2 * 1068310150) ^ -1077147209;
					continue;
				case 15u:
					num = ((int)num2 * -1421364404) ^ 0x65313B99;
					continue;
				case 14u:
					c = JSONNode.smethod_2(string_, num3);
					num = 121783021;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -958728591) ^ -1119586621;
					continue;
				case 10u:
					num = ((int)num2 * -490950759) ^ -1778526185;
					continue;
				case 9u:
					num = (int)(num2 * 117444006) ^ -1521246307;
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 854948499) ^ -550729113;
					continue;
				case 6u:
					result = text;
					num = ((int)num2 * -1403899486) ^ -1419618856;
					continue;
				case 5u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 1851073173;
					continue;
				case 4u:
					num = 1027710224;
					continue;
				case 3u:
				{
					char c2 = c;
					c3 = c2;
					num = ((int)num2 * -1460932971) ^ 0x6F6BBA22;
					continue;
				}
				case 0u:
					num = ((int)num2 * -796648472) ^ -136474787;
					continue;
				case 12u:
					break;
				default:
					{
						return result;
					}
					IL_013c:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1851073173;
					continue;
					IL_0126:
					text = JSONNode.smethod_3(text, "\\f");
					num = 745375520;
					continue;
					IL_0110:
					text = JSONNode.smethod_3(text, "\\n");
					num = 1442709429;
					continue;
					IL_00fa:
					text = JSONNode.smethod_3(text, "\\t");
					num = 1447262294;
					continue;
					IL_00e4:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1851073173;
					continue;
					IL_00d1:
					num = (int)((num2 * 329959386) ^ 0x5B7BE8D6);
					continue;
				}
				break;
			}
		}
	}

	public static JSONNode Parse(string aJSON)
	{
		string text2 = default(string);
		int num7 = default(int);
		string text = default(string);
		char c2 = default(char);
		bool flag6 = default(bool);
		JSONNode jSONNode = default(JSONNode);
		bool flag13 = default(bool);
		bool flag10 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		char c = default(char);
		Stack<JSONNode> stack = default(Stack<JSONNode>);
		JSONNode result = default(JSONNode);
		bool flag11 = default(bool);
		char c5 = default(char);
		char c3 = default(char);
		bool flag14 = default(bool);
		bool flag2 = default(bool);
		bool flag12 = default(bool);
		bool flag5 = default(bool);
		bool flag15 = default(bool);
		bool flag3 = default(bool);
		bool flag9 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1978771891;
			while (true)
			{
				uint num2;
				string s;
				int num57;
				switch ((num2 = (uint)num ^ 0xA214DF79u) % 155u)
				{
				case 154u:
					text2 = "";
					num = -1514977229;
					continue;
				case 153u:
					num7 = 0;
					text = "";
					num = (int)((num2 * 1326340593) ^ 0x208C22FD);
					continue;
				case 152u:
					num = ((int)num2 * -1725680772) ^ 0x586641CB;
					continue;
				case 151u:
					num = ((int)num2 * -758943233) ^ 0x3C215E49;
					continue;
				case 150u:
				{
					int num40;
					if (c2 == '}')
					{
						num = -1113929874;
						num40 = -1113929874;
					}
					else
					{
						num = -1033804179;
						num40 = -1033804179;
					}
					continue;
				}
				case 149u:
					flag6 = !flag6;
					num = -1483704040;
					continue;
				case 148u:
				{
					char c4 = JSONNode.smethod_2(aJSON, num7);
					c2 = c4;
					num = (int)(num2 * 764923240) ^ -828716317;
					continue;
				}
				case 147u:
					jSONNode.Add(text);
					num = ((int)num2 * -176671842) ^ 0x4627F2AF;
					continue;
				case 146u:
					flag13 = flag6;
					num = -476525578;
					continue;
				case 145u:
					num = (int)((num2 * 875063190) ^ 0x5F2A98B6);
					continue;
				case 144u:
					text2 = "";
					flag6 = false;
					num = (int)((num2 * 1864841512) ^ 0x32BA87E);
					continue;
				case 143u:
					switch (c2)
					{
					case '\t':
						goto IL_0139;
					case '\v':
					case '\f':
						goto IL_0159;
					case '\n':
					case '\r':
						goto IL_017a;
					}
					num = (int)((num2 * 109801701) ^ 0x7F4988E);
					continue;
				case 10u:
					goto IL_0139;
				case 23u:
					goto IL_0159;
				case 6u:
				case 42u:
				case 67u:
				case 88u:
				case 120u:
					goto IL_017a;
				case 142u:
				{
					int num32;
					int num33;
					if (!flag10)
					{
						num32 = 1849494075;
						num33 = 1849494075;
					}
					else
					{
						num32 = 1420266066;
						num33 = 1420266066;
					}
					num = num32 ^ (int)(num2 * 1722156977);
					continue;
				}
				case 141u:
					num = (int)((num2 * 1087877278) ^ 0x6C4BEE00);
					continue;
				case 140u:
				{
					int num10;
					int num11;
					if (flag8)
					{
						num10 = -423568440;
						num11 = -423568440;
					}
					else
					{
						num10 = -927765234;
						num11 = -927765234;
					}
					num = num10 ^ (int)(num2 * 583196655);
					continue;
				}
				case 139u:
					flag7 = flag6;
					num = ((int)num2 * -471902731) ^ -1727330463;
					continue;
				case 138u:
					num = ((int)num2 * -1497950353) ^ -1776524415;
					continue;
				case 137u:
					text2 = "";
					num = -199524671;
					continue;
				case 136u:
				{
					int num62;
					if (c != 'f')
					{
						num = -1198513807;
						num62 = -1198513807;
					}
					else
					{
						num = -589925120;
						num62 = -589925120;
					}
					continue;
				}
				case 135u:
					stack = new Stack<JSONNode>();
					num = ((int)num2 * -1933187995) ^ -665967086;
					continue;
				case 134u:
					text = JSONNode.smethod_3(text, "\b");
					num = -1935966522;
					continue;
				case 133u:
				{
					int num55;
					int num56;
					if (jSONNode is JSONArray)
					{
						num55 = 1548591690;
						num56 = 1548591690;
					}
					else
					{
						num55 = 1626004248;
						num56 = 1626004248;
					}
					num = num55 ^ (int)(num2 * 850670429);
					continue;
				}
				case 132u:
				{
					int num52;
					if (c2 == ' ')
					{
						num = -566396360;
						num52 = -566396360;
					}
					else
					{
						num = -1091308423;
						num52 = -1091308423;
					}
					continue;
				}
				case 131u:
					num = (int)(num2 * 554761323) ^ -228726763;
					continue;
				case 130u:
					result = jSONNode;
					num = -762212192;
					continue;
				case 129u:
					num = (int)((num2 * 1944314096) ^ 0x49AFA131);
					continue;
				case 128u:
					flag11 = flag6;
					num = -983576174;
					continue;
				case 127u:
					jSONNode = null;
					num = ((int)num2 * -1934343192) ^ 0x1017C899;
					continue;
				case 126u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -323855234) ^ 0x60D2B6AA;
					continue;
				case 125u:
					num = (int)((num2 * 1036228060) ^ 0x4262934E);
					continue;
				case 124u:
					c5 = c3;
					num = (int)(num2 * 1120683540) ^ -1012438827;
					continue;
				case 123u:
					num = ((int)num2 * -1506125377) ^ -1776352198;
					continue;
				case 122u:
				{
					int num42;
					int num43;
					if (c != 'b')
					{
						num42 = -1202964292;
						num43 = -1202964292;
					}
					else
					{
						num42 = -1404517363;
						num43 = -1404517363;
					}
					num = num42 ^ (int)(num2 * 1235596679);
					continue;
				}
				case 121u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = ((int)num2 * -1450554272) ^ 0x7D7AB44E;
					continue;
				case 119u:
				{
					int num37;
					if (c2 == '"')
					{
						num = -131139480;
						num37 = -131139480;
					}
					else
					{
						num = -663756046;
						num37 = -663756046;
					}
					continue;
				}
				case 118u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 1178597920) ^ -358246210;
					continue;
				case 117u:
					num = (int)(num2 * 1276800771) ^ -1813926228;
					continue;
				case 116u:
					num = ((int)num2 * -1874965039) ^ 0x57B62B97;
					continue;
				case 115u:
					flag14 = stack.Count == 0;
					num = -1041393695;
					continue;
				case 114u:
				{
					int num28;
					int num29;
					if (!flag2)
					{
						num28 = 1970601342;
						num29 = 1970601342;
					}
					else
					{
						num28 = 1733515855;
						num29 = 1733515855;
					}
					num = num28 ^ ((int)num2 * -1661655821);
					continue;
				}
				case 113u:
					num = ((int)num2 * -868993413) ^ -1455710113;
					continue;
				case 112u:
					text = JSONNode.smethod_3(text, c3.ToString());
					num = -312241920;
					continue;
				case 111u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)(num2 * 953987258) ^ -1621062305;
					continue;
				case 110u:
					text2 = JSONNode.smethod_5(text2);
					flag8 = jSONNode is JSONArray;
					num = ((int)num2 * -1951479575) ^ -557392881;
					continue;
				case 109u:
					num = (int)(num2 * 1577679613) ^ -831202183;
					continue;
				case 108u:
					num = ((int)num2 * -2080981726) ^ 0x170112EA;
					continue;
				case 107u:
					num = (int)((num2 * 1729213657) ^ 0x3C503942);
					continue;
				case 106u:
					num = (int)(num2 * 1487494448) ^ -2052993746;
					continue;
				case 105u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -1438916083) ^ 0x432365BF;
					continue;
				case 104u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)((num2 * 1716246487) ^ 0x40AE93A7);
					continue;
				case 103u:
					goto IL_0587;
				case 102u:
				{
					int num19;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = -690096284;
						num19 = -690096284;
					}
					else
					{
						num = -992373243;
						num19 = -992373243;
					}
					continue;
				}
				case 101u:
					num = (int)((num2 * 147791622) ^ 0x41D93B6A);
					continue;
				case 100u:
					num = ((int)num2 * -352112735) ^ -1297984632;
					continue;
				case 99u:
					num = -420476002;
					continue;
				case 98u:
					num = (int)((num2 * 424934878) ^ 0x6C7D5AC6);
					continue;
				case 97u:
				{
					int num12;
					int num13;
					if (jSONNode is JSONArray)
					{
						num12 = -1001788697;
						num13 = -1001788697;
					}
					else
					{
						num12 = -866488684;
						num13 = -866488684;
					}
					num = num12 ^ (int)(num2 * 1505965868);
					continue;
				}
				case 96u:
					num = -669671911;
					continue;
				case 95u:
					num = ((int)num2 * -746797107) ^ -226820989;
					continue;
				case 94u:
				{
					int num4;
					if (c == 'n')
					{
						num = -579228807;
						num4 = -579228807;
					}
					else
					{
						num = -1252898068;
						num4 = -1252898068;
					}
					continue;
				}
				case 93u:
					text = "";
					num = (int)((num2 * 607563132) ^ 0x2C315A62);
					continue;
				case 92u:
				{
					int num60;
					int num61;
					if (!flag12)
					{
						num60 = -1819961054;
						num61 = -1819961054;
					}
					else
					{
						num60 = -2031422788;
						num61 = -2031422788;
					}
					num = num60 ^ ((int)num2 * -1640848559);
					continue;
				}
				case 91u:
					num = (int)((num2 * 983052385) ^ 0x6B489929);
					continue;
				case 90u:
					num7 += 4;
					num = ((int)num2 * -202761034) ^ -370768864;
					continue;
				case 89u:
					num = ((int)num2 * -918128845) ^ -168300715;
					continue;
				case 87u:
				{
					int num58;
					int num59;
					if ((uint)c2 <= 44u)
					{
						num58 = 45589247;
						num59 = 45589247;
					}
					else
					{
						num58 = 902200153;
						num59 = 902200153;
					}
					num = num58 ^ (int)(num2 * 2084574623);
					continue;
				}
				case 86u:
					num = (int)(num2 * 290906076) ^ -1693824509;
					continue;
				case 85u:
					num = ((int)num2 * -1158860989) ^ -1953612052;
					continue;
				case 84u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1395896920) ^ 0x6A7C4763);
					continue;
				case 83u:
					text2 = text;
					num = -1573821004;
					continue;
				case 82u:
				{
					int num53;
					int num54;
					if (flag14)
					{
						num53 = 492650147;
						num54 = 492650147;
					}
					else
					{
						num53 = 907534676;
						num54 = 907534676;
					}
					num = num53 ^ ((int)num2 * -296557709);
					continue;
				}
				case 81u:
				{
					int num51;
					if ((uint)c2 <= 93u)
					{
						num = -37467608;
						num51 = -37467608;
					}
					else
					{
						num = -308520421;
						num51 = -308520421;
					}
					continue;
				}
				case 80u:
				{
					int num50;
					if (c2 != ',')
					{
						num = -905363215;
						num50 = -905363215;
					}
					else
					{
						num = -318283577;
						num50 = -318283577;
					}
					continue;
				}
				case 79u:
					goto IL_07dc;
				case 78u:
				{
					int num48;
					int num49;
					if (c2 == ':')
					{
						num48 = 633173611;
						num49 = 633173611;
					}
					else
					{
						num48 = 692998580;
						num49 = 692998580;
					}
					num = num48 ^ (int)(num2 * 2112496051);
					continue;
				}
				case 77u:
					num = (int)(num2 * 599392084) ^ -1504036750;
					continue;
				case 76u:
					flag5 = flag6;
					num = (int)(num2 * 360961195) ^ -747586335;
					continue;
				case 75u:
				{
					int num46;
					int num47;
					if (!flag15)
					{
						num46 = 1006287071;
						num47 = 1006287071;
					}
					else
					{
						num46 = 1621103192;
						num47 = 1621103192;
					}
					num = num46 ^ (int)(num2 * 751438437);
					continue;
				}
				case 74u:
					flag15 = flag6;
					num = -540942425;
					continue;
				case 73u:
				{
					int num44;
					int num45;
					if (flag13)
					{
						num44 = -881047822;
						num45 = -881047822;
					}
					else
					{
						num44 = -275850270;
						num45 = -275850270;
					}
					num = num44 ^ (int)(num2 * 371532493);
					continue;
				}
				case 72u:
					jSONNode.Add(stack.Peek());
					num = (int)((num2 * 1826311911) ^ 0x3B58341);
					continue;
				case 71u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)((num2 * 1165288655) ^ 0x24306440);
					continue;
				case 70u:
					num = ((int)num2 * -458500335) ^ 0x535C59D1;
					continue;
				case 69u:
					text2 = "";
					text = "";
					jSONNode = stack.Peek();
					num = -521118162;
					continue;
				case 68u:
					jSONNode.Add(text2, stack.Peek());
					num = ((int)num2 * -523368900) ^ 0x15CC6BAC;
					continue;
				case 66u:
					num = ((int)num2 * -1701410813) ^ 0x5E1E84C5;
					continue;
				case 65u:
					goto IL_0972;
				case 64u:
				{
					int num41;
					if (num7 < JSONNode.smethod_4(aJSON))
					{
						num = -1217013316;
						num41 = -1217013316;
					}
					else
					{
						num = -382952629;
						num41 = -382952629;
					}
					continue;
				}
				case 63u:
				{
					int num38;
					int num39;
					if (flag3)
					{
						num38 = 2025629813;
						num39 = 2025629813;
					}
					else
					{
						num38 = 1194982748;
						num39 = 1194982748;
					}
					num = num38 ^ ((int)num2 * -1949369377);
					continue;
				}
				case 62u:
					num = (int)((num2 * 2053031393) ^ 0x2F0D319D);
					continue;
				case 61u:
					num = -2000408715;
					continue;
				case 60u:
				{
					c = c5;
					int num35;
					int num36;
					if ((uint)c <= 102u)
					{
						num35 = -137956383;
						num36 = -137956383;
					}
					else
					{
						num35 = -2130999443;
						num36 = -2130999443;
					}
					num = num35 ^ (int)(num2 * 1651262978);
					continue;
				}
				case 59u:
					text2 = "";
					text = "";
					num = -1848259226;
					continue;
				case 58u:
				{
					int num34;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = -1567584597;
						num34 = -1567584597;
					}
					else
					{
						num = -635014508;
						num34 = -635014508;
					}
					continue;
				}
				case 57u:
					stack.Pop();
					num = -993959431;
					continue;
				case 56u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)((num2 * 16594072) ^ 0x6506E53B);
					continue;
				case 55u:
					num = (int)(num2 * 555508353) ^ -2127031295;
					continue;
				case 54u:
					text = "";
					num = ((int)num2 * -186099439) ^ -1517696119;
					continue;
				case 52u:
					num = (int)((num2 * 117212254) ^ 0x3322AD32);
					continue;
				case 51u:
					num = (int)((num2 * 273019956) ^ 0x4AF458BF);
					continue;
				case 50u:
					jSONNode.Add(text2, text);
					num = (int)(num2 * 854572186) ^ -857580531;
					continue;
				case 49u:
				{
					int num30;
					int num31;
					if ((uint)c2 > 32u)
					{
						num30 = 863660684;
						num31 = 863660684;
					}
					else
					{
						num30 = 324452537;
						num31 = 324452537;
					}
					num = num30 ^ ((int)num2 * -1748343510);
					continue;
				}
				case 48u:
				{
					int num26;
					int num27;
					if (JSONNode.smethod_6(text, ""))
					{
						num26 = 475318877;
						num27 = 475318877;
					}
					else
					{
						num26 = 205587358;
						num27 = 205587358;
					}
					num = num26 ^ ((int)num2 * -1279596720);
					continue;
				}
				case 47u:
					text = JSONNode.smethod_3(text, "\n");
					num = -1935966522;
					continue;
				case 46u:
					num = (int)(num2 * 658617836) ^ -1751772424;
					continue;
				case 45u:
					num = -1835748330;
					continue;
				case 44u:
					flag12 = flag6;
					num = -340361259;
					continue;
				case 43u:
					stack.Push(new JSONArray());
					num = -670281000;
					continue;
				case 41u:
					text = JSONNode.smethod_3(text, "\f");
					num = -1935966522;
					continue;
				case 40u:
					num = ((int)num2 * -195171533) ^ -247753347;
					continue;
				case 39u:
				{
					int num24;
					int num25;
					if (!(jSONNode != null))
					{
						num24 = 1741743985;
						num25 = 1741743985;
					}
					else
					{
						num24 = 44959507;
						num25 = 44959507;
					}
					num = num24 ^ ((int)num2 * -263196728);
					continue;
				}
				case 38u:
					num = ((int)num2 * -37290379) ^ -1201986470;
					continue;
				case 37u:
				{
					int num22;
					int num23;
					if (!flag11)
					{
						num22 = -13735660;
						num23 = -13735660;
					}
					else
					{
						num22 = -1893783471;
						num23 = -1893783471;
					}
					num = num22 ^ (int)(num2 * 1030413241);
					continue;
				}
				case 36u:
				{
					int num20;
					int num21;
					if (flag7)
					{
						num20 = 1864804114;
						num21 = 1864804114;
					}
					else
					{
						num20 = 356382462;
						num21 = 356382462;
					}
					num = num20 ^ ((int)num2 * -665817448);
					continue;
				}
				case 35u:
					num = (int)((num2 * 1619174023) ^ 0x4AA573FB);
					continue;
				case 34u:
					flag10 = jSONNode is JSONArray;
					num = (int)(num2 * 430279490) ^ -327005919;
					continue;
				case 33u:
					num = ((int)num2 * -2095338659) ^ -864632515;
					continue;
				case 32u:
				{
					int num17;
					int num18;
					if (!flag9)
					{
						num17 = -1843488829;
						num18 = -1843488829;
					}
					else
					{
						num17 = -1465464017;
						num18 = -1465464017;
					}
					num = num17 ^ ((int)num2 * -756655900);
					continue;
				}
				case 31u:
					num = -1332590947;
					continue;
				case 30u:
				{
					int num15;
					int num16;
					if (!flag4)
					{
						num15 = 624637358;
						num16 = 624637358;
					}
					else
					{
						num15 = 1973260447;
						num16 = 1973260447;
					}
					num = num15 ^ ((int)num2 * -586660835);
					continue;
				}
				case 29u:
				{
					int num14;
					if (JSONNode.smethod_6(text, ""))
					{
						num = -2043999628;
						num14 = -2043999628;
					}
					else
					{
						num = -2000408715;
						num14 = -2000408715;
					}
					continue;
				}
				case 28u:
					goto IL_0d35;
				case 27u:
					num = ((int)num2 * -1433556166) ^ 0x5801A262;
					continue;
				case 26u:
					text = "";
					num = (int)((num2 * 597549257) ^ 0x388E8702);
					continue;
				case 25u:
					num = ((int)num2 * -960360399) ^ 0x1EADF2FE;
					continue;
				case 24u:
					c3 = JSONNode.smethod_2(aJSON, num7);
					num = (int)(num2 * 1067587795) ^ -503264821;
					continue;
				case 22u:
				{
					int num8;
					int num9;
					if (flag5)
					{
						num8 = -151501370;
						num9 = -151501370;
					}
					else
					{
						num8 = -1529177758;
						num9 = -1529177758;
					}
					num = num8 ^ (int)(num2 * 1270213019);
					continue;
				}
				case 21u:
					num = -792398081;
					continue;
				case 20u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)((num2 * 1853265887) ^ 0x5FF98425);
					continue;
				case 19u:
					flag4 = JSONNode.smethod_6(text2, "");
					num = -1619835700;
					continue;
				case 18u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = (int)((num2 * 2065561281) ^ 0x4F96DA4F);
					continue;
				case 16u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -765380746;
						num6 = -765380746;
					}
					else
					{
						num5 = -304761307;
						num6 = -304761307;
					}
					num = num5 ^ ((int)num2 * -1522399494);
					continue;
				}
				case 15u:
					flag3 = stack.Count > 0;
					num = (int)(num2 * 1454210752) ^ -1689856986;
					continue;
				case 14u:
					switch (c2)
					{
					case '[':
						break;
					case '\\':
						goto IL_0587;
					case ']':
						goto IL_0972;
					default:
						goto IL_0ea2;
					}
					goto case 128u;
				case 13u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 850842468) ^ -1138675373;
					continue;
				case 12u:
					jSONNode = stack.Peek();
					num = (int)((num2 * 1412974071) ^ 0x3E726956);
					continue;
				case 11u:
					goto IL_0ee0;
				case 8u:
					flag2 = JSONNode.smethod_6(text2, "");
					num = -542254492;
					continue;
				case 7u:
					jSONNode.Add(text);
					num = (int)(num2 * 475157905) ^ -1023620388;
					continue;
				case 5u:
					num = ((int)num2 * -2027506522) ^ 0x575DB506;
					continue;
				case 3u:
					flag = jSONNode != null;
					num = (int)((num2 * 601840704) ^ 0x71B18C49);
					continue;
				case 2u:
					stack.Push(new JSONClass());
					num = -161757012;
					continue;
				case 1u:
				{
					int num3;
					if (c2 == '{')
					{
						num = -509458471;
						num3 = -509458471;
					}
					else
					{
						num = -667052373;
						num3 = -667052373;
					}
					continue;
				}
				case 0u:
					switch (c)
					{
					case 's':
						break;
					case 'u':
						goto IL_07dc;
					case 'r':
						goto IL_0d35;
					case 't':
						goto IL_0ee0;
					default:
						goto IL_0f9e;
					}
					goto case 112u;
				case 17u:
					break;
				case 9u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				case 53u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				default:
					{
						return result;
					}
					IL_0f9e:
					num = -286313350;
					continue;
					IL_0ee0:
					text = JSONNode.smethod_3(text, "\t");
					num = -1935966522;
					continue;
					IL_0ea2:
					num = -1375368774;
					continue;
					IL_0d35:
					text = JSONNode.smethod_3(text, "\r");
					num = -1827707826;
					continue;
					IL_0587:
					num7++;
					num = -256623804;
					continue;
					IL_0972:
					flag9 = flag6;
					num = -392575624;
					continue;
					IL_017a:
					num7++;
					num = -355974808;
					continue;
					IL_07dc:
					s = JSONNode.smethod_8(aJSON, num7 + 1, 4);
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = -1415219280;
					continue;
					IL_0159:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num7).ToString());
					num = -330350568;
					continue;
					IL_0139:
					if (flag6)
					{
						num = -718608588;
						num57 = -718608588;
					}
					else
					{
						num = -743022580;
						num57 = -743022580;
					}
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
			int num = 1591227871;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7860EB1Eu) % 5u)
				{
				case 4u:
					Serialize(aWriter);
					num = (int)((num2 * 1417755752) ^ 0x399F6ADF);
					continue;
				case 2u:
					aWriter = JSONNode.smethod_9(aData);
					num = ((int)num2 * -2107503677) ^ -127186924;
					continue;
				case 1u:
					num = ((int)num2 * -234743663) ^ -50658592;
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
				int num = -577523971;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA27D29B0u) % 3u)
					{
					case 1u:
						goto IL_0020;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0020:
					SaveToStream(fileStream);
					num = (int)((num2 * 114357704) ^ 0x5D2E55DA);
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
					int num3 = -1959543390;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xA27D29B0u) % 4u)
						{
						case 3u:
							num3 = (int)(num2 * 40961284) ^ -998451203;
							continue;
						case 2u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)((num2 * 546538588) ^ 0x786E70BB);
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

	public string SaveToBase64()
	{
		MemoryStream memoryStream = JSONNode.smethod_16();
		try
		{
			while (true)
			{
				int num = 1082088076;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5395B898u) % 3u)
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
					num = (int)(num2 * 732011704) ^ -1690278232;
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0093:
					int num3 = 810005648;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x5395B898u) % 3u)
						{
						case 2u:
							goto IL_0063;
						default:
							goto end_IL_0076;
						case 0u:
							break;
						case 1u:
							goto end_IL_0076;
						}
						goto IL_0093;
						IL_0063:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = ((int)num2 * -1420155319) ^ 0x232CBCA2;
						continue;
						end_IL_0076:
						break;
					}
					break;
				}
			}
		}
	}

	public static JSONNode Deserialize(BinaryReader aReader)
	{
		JSONArray jSONArray = default(JSONArray);
		int num4 = default(int);
		int num6 = default(int);
		JSONNode result = default(JSONNode);
		bool flag = default(bool);
		JSONClass jSONClass = default(JSONClass);
		JSONBinaryTag jSONBinaryTag3 = default(JSONBinaryTag);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		int num5 = default(int);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num3 = default(int);
		string aKey = default(string);
		JSONNode aItem = default(JSONNode);
		while (true)
		{
			int num = -1658017524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF11470B5u) % 40u)
				{
				case 39u:
					num = ((int)num2 * -1147749354) ^ 0x1330FDFC;
					continue;
				case 38u:
					num = (int)((num2 * 820986068) ^ 0x676348BE);
					continue;
				case 37u:
					jSONArray.Add(Deserialize(aReader));
					num = -1459764351;
					continue;
				case 36u:
					num = -1162017097;
					continue;
				case 33u:
					num4 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1904443817) ^ -2011301821;
					continue;
				case 32u:
					num = (int)((num2 * 460076077) ^ 0x4D0F2F46);
					continue;
				case 31u:
					num = (int)(num2 * 719983168) ^ -1209298426;
					continue;
				case 30u:
					num6 = 0;
					num = ((int)num2 * -1899615521) ^ -498265633;
					continue;
				case 29u:
					result = jSONArray;
					num = ((int)num2 * -1331848327) ^ 0x4B8511BF;
					continue;
				case 28u:
					num6++;
					num = ((int)num2 * -637811889) ^ 0x6651241D;
					continue;
				case 27u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -558664481;
						num9 = -558664481;
					}
					else
					{
						num8 = -1254790958;
						num9 = -1254790958;
					}
					num = num8 ^ (int)(num2 * 1682558411);
					continue;
				}
				case 26u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -2047771060) ^ -1915985814;
					continue;
				case 25u:
					jSONClass = new JSONClass();
					num = (int)(num2 * 2012212186) ^ -1891524917;
					continue;
				case 24u:
					num = ((int)num2 * -613684358) ^ -1006171647;
					continue;
				case 23u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = ((int)num2 * -179210043) ^ 0x25EDD669;
					continue;
				case 22u:
					jSONBinaryTag3 = jSONBinaryTag;
					num = ((int)num2 * -225393163) ^ 0x1CFFADA1;
					continue;
				case 21u:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -1388270650;
					continue;
				case 20u:
				{
					int num7;
					if (num6 >= num5)
					{
						num = -164159176;
						num7 = -164159176;
					}
					else
					{
						num = -256333912;
						num7 = -256333912;
					}
					continue;
				}
				case 19u:
					result = jSONClass;
					num = ((int)num2 * -1745006031) ^ 0x61726C0E;
					continue;
				case 18u:
					jSONBinaryTag2 = jSONBinaryTag3;
					num = ((int)num2 * -1425577631) ^ 0xF9DF3DE;
					continue;
				case 17u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.BoolValue:
						break;
					default:
						goto IL_0209;
					case JSONBinaryTag.Array:
						goto IL_021c;
					case JSONBinaryTag.Class:
						goto IL_0234;
					case JSONBinaryTag.Value:
						goto IL_023e;
					case JSONBinaryTag.IntValue:
						goto IL_0248;
					case JSONBinaryTag.DoubleValue:
						goto IL_025f;
					case JSONBinaryTag.FloatValue:
						goto IL_0269;
					}
					goto case 21u;
				case 0u:
					goto IL_021c;
				case 5u:
					goto IL_0234;
				case 9u:
					goto IL_023e;
				case 16u:
					goto IL_0248;
				case 14u:
					goto IL_025f;
				case 3u:
					goto IL_0269;
				case 15u:
					num = ((int)num2 * -498668572) ^ 0x159FDF7A;
					continue;
				case 13u:
					flag = num3 < num4;
					num = -1832660970;
					continue;
				case 12u:
					num = ((int)num2 * -1221254230) ^ 0x78111259;
					continue;
				case 11u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = ((int)num2 * -1461099243) ^ -324750479;
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -2121903005) ^ -436415064;
					continue;
				case 7u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1854097235) ^ 0x68C5FD4C;
					continue;
				case 6u:
					aKey = JSONNode.smethod_22(aReader);
					aItem = Deserialize(aReader);
					num = -1721484262;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -672892211) ^ 0x6C2AC;
					continue;
				case 2u:
					num = ((int)num2 * -293005366) ^ 0x1892D9E1;
					continue;
				case 1u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					num = ((int)num2 * -1729772460) ^ 0x4FA69A0F;
					continue;
				case 10u:
					break;
				case 34u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_0269:
					num = -876311526;
					continue;
					IL_025f:
					num = -355213010;
					continue;
					IL_0248:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = -197157485;
					continue;
					IL_023e:
					num = -1164332369;
					continue;
					IL_0234:
					num = -152016380;
					continue;
					IL_021c:
					num5 = JSONNode.smethod_21(aReader);
					jSONArray = new JSONArray();
					num = -1871125941;
					continue;
					IL_0209:
					num = (int)((num2 * 569517657) ^ 0x1F610F48);
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
				int num = -1692577820;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE07F3975u) % 3u)
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
					num = ((int)num2 * -1503521887) ^ -1997060372;
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
					int num3 = -1784780320;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xE07F3975u) % 3u)
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
						JSONNode.smethod_15((IDisposable)binaryReader);
						num3 = (int)(num2 * 1784317630) ^ -159026588;
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
					IL_0045:
					int num = 424658172;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x1D595A87u) % 3u)
						{
						case 1u:
							goto IL_0015;
						default:
							goto end_IL_0028;
						case 2u:
							break;
						case 0u:
							goto end_IL_0028;
						}
						goto IL_0045;
						IL_0015:
						JSONNode.smethod_15((IDisposable)fileStream);
						num = ((int)num2 * -5446635) ^ 0x1D0419BB;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		JSONNode result = default(JSONNode);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num = -854332432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBD87EC4u) % 7u)
				{
				case 6u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -1307594489) ^ 0x7CD042B0;
					continue;
				case 5u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 2019456017) ^ 0x73B080CD);
					continue;
				case 4u:
					num = ((int)num2 * -1269458678) ^ 0x3B9F53F5;
					continue;
				case 1u:
					num = (int)((num2 * 27834971) ^ 0xE567A69);
					continue;
				case 0u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = ((int)num2 * -11805422) ^ -844345289;
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
			int num = -557737748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9BED732Eu) % 3u)
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
				num = ((int)num2 * -231269525) ^ 0x509F2086;
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
