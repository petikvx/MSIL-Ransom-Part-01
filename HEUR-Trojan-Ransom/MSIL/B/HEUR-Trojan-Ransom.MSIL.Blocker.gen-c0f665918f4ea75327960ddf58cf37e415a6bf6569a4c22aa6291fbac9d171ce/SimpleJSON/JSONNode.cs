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
				int num = -2078424894;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF24F1E3u) % 3u)
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
					num = ((int)num2 * -473925397) ^ 0x40F0CCAD;
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
				int num = 119890408;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB4F4139u) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1692410526) ^ 0x5F71DCAE);
						continue;
					case 1u:
						result = null;
						num = ((int)num2 * -793689630) ^ 0x2F03AF0D;
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

	public virtual string Value
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = 539079770;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD0147E5u) % 4u)
					{
					case 3u:
						result = "";
						num = ((int)num2 * -497657037) ^ 0x60A85A46;
						continue;
					case 2u:
						num = ((int)num2 * -1261595719) ^ 0x68D05B36;
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
				int num = 1802801805;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49F42782u) % 3u)
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
					num = ((int)num2 * -251661173) ^ -1752379733;
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
				int num = -1785341778;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x81B45A63u) % 3u)
					{
					case 1u:
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
					num = ((int)num2 * -1345427802) ^ 0x6E1F9500;
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
				int num = 244521431;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3B17560Bu) % 3u)
					{
					case 1u:
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
					num = (int)((num2 * 1449455636) ^ 0x3E7237F);
				}
			}
		}
	}

	public virtual int AsInt
	{
		get
		{
			int result2 = default(int);
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num = 1865500464;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4FDEF69Fu) % 6u)
					{
					case 5u:
						result2 = 0;
						flag = int.TryParse(Value, out result2);
						num = (int)((num2 * 41105576) ^ 0x1B079DC7);
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = -1259795844;
							num4 = -1259795844;
						}
						else
						{
							num3 = -128067819;
							num4 = -128067819;
						}
						num = num3 ^ (int)(num2 * 1811803272);
						continue;
					}
					case 3u:
						result = result2;
						num = (int)(num2 * 2119087344) ^ -892749276;
						continue;
					case 0u:
						result = 0;
						num = 979553012;
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
				int num = 1220854260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5883085Bu) % 3u)
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
					num = ((int)num2 * -472727136) ^ -574461072;
				}
			}
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
				int num = -1119592742;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFFBB0207u) % 8u)
					{
					case 7u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 1669506320;
							num4 = 1669506320;
						}
						else
						{
							num3 = 299814866;
							num4 = 299814866;
						}
						num = num3 ^ ((int)num2 * -197629846);
						continue;
					}
					case 6u:
						num = ((int)num2 * -363404365) ^ -451085879;
						continue;
					case 5u:
						result2 = 0f;
						num = ((int)num2 * -1157786639) ^ -1327323310;
						continue;
					case 3u:
						result = 0f;
						num = -1793495959;
						continue;
					case 1u:
						result = result2;
						num = ((int)num2 * -1969907579) ^ -1828934730;
						continue;
					case 0u:
						flag = float.TryParse(Value, NumberStyles.Float, JSONNode.smethod_0(), out result2);
						num = (int)(num2 * 2111974994) ^ -1251720832;
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
				int num = 915165758;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x73F44145u) % 3u)
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
					num = (int)(num2 * 737942416) ^ -15885498;
				}
			}
		}
	}

	public virtual double AsDouble
	{
		get
		{
			double result2 = default(double);
			bool flag = default(bool);
			double result = default(double);
			while (true)
			{
				int num = 1365456063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4611496u) % 7u)
					{
					case 6u:
						result2 = 0.0;
						flag = double.TryParse(Value, out result2);
						num = (int)(num2 * 534099367) ^ -211517381;
						continue;
					case 5u:
						num = (int)((num2 * 672012617) ^ 0x2AF1568B);
						continue;
					case 2u:
						result = 0.0;
						num = 1406156339;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (flag)
						{
							num3 = 704719231;
							num4 = 704719231;
						}
						else
						{
							num3 = 463484066;
							num4 = 463484066;
						}
						num = num3 ^ (int)(num2 * 827112078);
						continue;
					}
					case 0u:
						result = result2;
						num = ((int)num2 * -1412121861) ^ 0x4522BAF9;
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
			while (true)
			{
				int num = 2123141964;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDC2BB95u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -18500281) ^ 0x77340D10;
						continue;
					case 1u:
						Value = value.ToString();
						num = ((int)num2 * -137991130) ^ 0x1AA58C08;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
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
			bool result = default(bool);
			bool flag = default(bool);
			bool result2 = default(bool);
			while (true)
			{
				int num = -1954624778;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x94DE0B62u) % 8u)
					{
					case 7u:
						result = !JSONNode.smethod_1(Value);
						num = -275181248;
						continue;
					case 6u:
						num = (int)(num2 * 1258814398) ^ -1841997500;
						continue;
					case 5u:
						flag = bool.TryParse(Value, out result2);
						num = ((int)num2 * -1709413491) ^ 0x65DB358A;
						continue;
					case 4u:
						result2 = false;
						num = (int)(num2 * 1656053409) ^ -1595868397;
						continue;
					case 3u:
						result = result2;
						num = (int)((num2 * 353548196) ^ 0x7FECD8D0);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 1197283285;
							num4 = 1197283285;
						}
						else
						{
							num3 = 505537553;
							num4 = 505537553;
						}
						num = num3 ^ (int)(num2 * 475567320);
						continue;
					}
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
				int num = -282053386;
				while (true)
				{
					string value2;
					switch ((uint)(num ^ -1630355457) % 3u)
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
					num = -518280895;
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
				int num = -287327212;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE50E526u) % 3u)
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
					num = ((int)num2 * -622733130) ^ -699407567;
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
				int num = 1338063406;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3ABA3E4Fu) % 4u)
					{
					case 1u:
						result = this as JSONClass;
						num = (int)((num2 * 1772703321) ^ 0x77B1299A);
						continue;
					case 0u:
						num = ((int)num2 * -1338499880) ^ -1919511315;
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
			int num = 1136741644;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4089BB95u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 360044865) ^ -2043199813;
					continue;
				case 1u:
					Add("", aItem);
					num = ((int)num2 * -893550382) ^ -1836241727;
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
		return null;
	}

	public virtual JSONNode Remove(int aIndex)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 2112087266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E68AE38u) % 4u)
				{
				case 2u:
					result = null;
					num = (int)((num2 * 539382801) ^ 0x16EB906F);
					continue;
				case 1u:
					num = ((int)num2 * -740104406) ^ 0x64C85B36;
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

	public virtual JSONNode Remove(JSONNode aNode)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -295597575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CAA0408u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 845335554) ^ -182808886;
					continue;
				case 1u:
					result = aNode;
					num = ((int)num2 * -225954428) ^ -546927341;
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
		return "JSONNode";
	}

	public virtual string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 874068704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FBCBF7Fu) % 3u)
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
				num = (int)(num2 * 1777372941) ^ -2029392618;
			}
		}
	}

	public static implicit operator JSONNode(string s)
	{
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 441354927;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C719F76u) % 4u)
				{
				case 1u:
					result = new JSONData(s);
					num = (int)((num2 * 2067128166) ^ 0x2E0DF030);
					continue;
				case 0u:
					num = ((int)num2 * -910137249) ^ -550859792;
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
			int num = -2127101600;
			while (true)
			{
				uint num2;
				object obj;
				switch ((num2 = (uint)num ^ 0xCE0ECCA1u) % 5u)
				{
				case 4u:
					if (!(d == null))
					{
						num = (int)((num2 * 926280440) ^ 0x1A797E4A);
						continue;
					}
					obj = null;
					goto IL_001c;
				case 1u:
					num = (int)(num2 * 1924209247) ^ -833502841;
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
					num = -1920193844;
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
			int num = 2054433130;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6DFCCD39u) % 8u)
				{
				case 7u:
					result = true;
					num = ((int)num2 * -1326415652) ^ 0x33059D84;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1758835873;
						num5 = 1758835873;
					}
					else
					{
						num4 = 238164990;
						num5 = 238164990;
					}
					num = num4 ^ (int)(num2 * 1035834768);
					continue;
				}
				case 4u:
					num3 = ((a is JSONLazyCreator) ? 1 : 0);
					goto IL_0044;
				case 3u:
					if (b == null)
					{
						num = ((int)num2 * -1963557643) ^ -148478838;
						continue;
					}
					num3 = 0;
					goto IL_0044;
				case 1u:
					num = (int)((num2 * 444219354) ^ 0x50C97209);
					continue;
				case 0u:
					result = (object)a == b;
					num = 1416224259;
					continue;
				case 6u:
					break;
				default:
					{
						return result;
					}
					IL_0044:
					flag = (byte)num3 != 0;
					num = 808397100;
					continue;
				}
				break;
			}
		}
	}

	public static bool operator !=(JSONNode a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = 587151015;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x163C313Cu) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 975638162) ^ 0x6C61F1AE);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1671508369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x508D37Cu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 5210393) ^ 0x2EFD9421);
					continue;
				case 1u:
					result = (object)this == obj;
					num = ((int)num2 * -1307143377) ^ -1300598440;
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
			int num = -46054121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF0E14DDu) % 3u)
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
				result = this.method_0();
				num = (int)(num2 * 748687803) ^ -589089971;
			}
		}
	}

	internal static string Escape(string aText)
	{
		string string_ = default(string);
		string text = default(string);
		char c = default(char);
		char c3 = default(char);
		char c2 = default(char);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = 1415264514;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7A93E8A7u) % 31u)
				{
				case 30u:
					string_ = aText;
					num = ((int)num2 * -317236732) ^ 0x1DB859E3;
					continue;
				case 29u:
					num = ((int)num2 * -646723170) ^ -323292830;
					continue;
				case 28u:
					text = "";
					num = ((int)num2 * -663783349) ^ -1150811214;
					continue;
				case 27u:
					num = ((int)num2 * -181126147) ^ 0x62BE0098;
					continue;
				case 26u:
				{
					int num5;
					if (c != '\\')
					{
						num = 738513180;
						num5 = 738513180;
					}
					else
					{
						num = 317393875;
						num5 = 317393875;
					}
					continue;
				}
				case 25u:
				{
					int num6;
					if (c != '"')
					{
						num = 386263534;
						num6 = 386263534;
					}
					else
					{
						num = 1907722331;
						num6 = 1907722331;
					}
					continue;
				}
				case 24u:
					c = c3;
					switch (c)
					{
					case '\b':
						goto IL_00d6;
					case '\t':
						goto IL_00ec;
					case '\n':
						goto IL_0102;
					case '\v':
						goto IL_0118;
					case '\f':
						goto IL_0130;
					case '\r':
						goto IL_0146;
					}
					num = ((int)num2 * -1104377024) ^ -351402296;
					continue;
				case 8u:
					goto IL_00d6;
				case 3u:
					goto IL_00ec;
				case 20u:
					goto IL_0102;
				case 15u:
					goto IL_0118;
				case 19u:
					goto IL_0130;
				case 0u:
					goto IL_0146;
				case 23u:
					text = JSONNode.smethod_3(text, "\\\\");
					num = 1886290779;
					continue;
				case 22u:
					c2 = JSONNode.smethod_2(string_, num3);
					num = 2053425251;
					continue;
				case 21u:
					result = text;
					num = (int)((num2 * 1402194827) ^ 0x3CD95871);
					continue;
				case 18u:
					num = ((int)num2 * -1894070364) ^ -501214758;
					continue;
				case 17u:
					num = (int)(num2 * 1040801546) ^ -1413338648;
					continue;
				case 16u:
					c3 = c2;
					num = (int)((num2 * 71514491) ^ 0x72E89ED0);
					continue;
				case 14u:
					num = (int)(num2 * 1508727045) ^ -421707185;
					continue;
				case 11u:
					num = (int)((num2 * 865011369) ^ 0x2DD71013);
					continue;
				case 10u:
					num = (int)((num2 * 211221690) ^ 0x6F3CBF28);
					continue;
				case 9u:
					num3++;
					num = 1710057626;
					continue;
				case 7u:
					num = ((int)num2 * -330871257) ^ 0x648B1372;
					continue;
				case 6u:
					num3 = 0;
					num = ((int)num2 * -203313512) ^ -532104790;
					continue;
				case 5u:
					num = (int)(num2 * 1914696577) ^ -1969849604;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= JSONNode.smethod_4(string_))
					{
						num = 1414991141;
						num4 = 1414991141;
					}
					else
					{
						num = 1707640384;
						num4 = 1707640384;
					}
					continue;
				}
				case 2u:
					num = (int)(num2 * 408519324) ^ -1119907324;
					continue;
				case 1u:
					text = JSONNode.smethod_3(text, "\\\"");
					num = 251293532;
					continue;
				case 13u:
					break;
				default:
					{
						return result;
					}
					IL_0146:
					text = JSONNode.smethod_3(text, "\\r");
					num = 1122838550;
					continue;
					IL_0130:
					text = JSONNode.smethod_3(text, "\\f");
					num = 97113933;
					continue;
					IL_0118:
					text = JSONNode.smethod_3(text, c2.ToString());
					num = 1122838550;
					continue;
					IL_0102:
					text = JSONNode.smethod_3(text, "\\n");
					num = 764843234;
					continue;
					IL_00ec:
					text = JSONNode.smethod_3(text, "\\t");
					num = 457556609;
					continue;
					IL_00d6:
					text = JSONNode.smethod_3(text, "\\b");
					num = 1122838550;
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
		bool flag8 = default(bool);
		bool flag4 = default(bool);
		bool flag12 = default(bool);
		string text = default(string);
		string text2 = default(string);
		bool flag2 = default(bool);
		int num4 = default(int);
		char c3 = default(char);
		bool flag14 = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		bool flag7 = default(bool);
		bool flag15 = default(bool);
		char c = default(char);
		bool flag13 = default(bool);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		char c5 = default(char);
		bool flag11 = default(bool);
		string s = default(string);
		bool flag = default(bool);
		char c4 = default(char);
		char c2 = default(char);
		bool flag3 = default(bool);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = 518623209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19C7255Cu) % 160u)
				{
				case 159u:
					flag8 = flag4;
					num = 2056404520;
					continue;
				case 158u:
					flag12 = jSONNode != null;
					num = (int)((num2 * 1648940559) ^ 0x5318335B);
					continue;
				case 157u:
					jSONNode.Add(text);
					num = (int)((num2 * 1897127652) ^ 0x4AF47E66);
					continue;
				case 156u:
					num = ((int)num2 * -1293661008) ^ 0x48737980;
					continue;
				case 155u:
					text2 = JSONNode.smethod_5(text2);
					num = (int)(num2 * 163768384) ^ -405871657;
					continue;
				case 154u:
				{
					int num58;
					int num59;
					if (flag2)
					{
						num58 = -2077262874;
						num59 = -2077262874;
					}
					else
					{
						num58 = -866866377;
						num59 = -866866377;
					}
					num = num58 ^ (int)(num2 * 666833934);
					continue;
				}
				case 153u:
					num = (int)((num2 * 1071639698) ^ 0x71C845E8);
					continue;
				case 152u:
				{
					int num19;
					int num20;
					if (!(jSONNode is JSONArray))
					{
						num19 = -1781814570;
						num20 = -1781814570;
					}
					else
					{
						num19 = -1802527167;
						num20 = -1802527167;
					}
					num = num19 ^ ((int)num2 * -1055231460);
					continue;
				}
				case 151u:
					num = ((int)num2 * -958545914) ^ -1237127948;
					continue;
				case 149u:
					num4 = 0;
					num = ((int)num2 * -2121739734) ^ 0x7EF46622;
					continue;
				case 148u:
					goto IL_0119;
				case 147u:
					text2 = "";
					text = "";
					num = 648632448;
					continue;
				case 146u:
				{
					int num51;
					int num52;
					if ((uint)c3 <= 102u)
					{
						num51 = -548310797;
						num52 = -548310797;
					}
					else
					{
						num51 = -12819735;
						num52 = -12819735;
					}
					num = num51 ^ ((int)num2 * -289587903);
					continue;
				}
				case 145u:
				{
					int num45;
					int num46;
					if (!flag14)
					{
						num45 = -551932092;
						num46 = -551932092;
					}
					else
					{
						num45 = -1769857252;
						num46 = -1769857252;
					}
					num = num45 ^ ((int)num2 * -1852313235);
					continue;
				}
				case 144u:
					switch (c3)
					{
					case 'r':
						goto IL_01b6;
					case 's':
						goto IL_01cc;
					case 't':
						goto IL_01e4;
					case 'u':
						goto IL_01fa;
					}
					num = 2004350257;
					continue;
				case 80u:
					goto IL_01b6;
				case 44u:
					goto IL_01cc;
				case 31u:
					goto IL_01e4;
				case 77u:
					goto IL_01fa;
				case 143u:
					flag6 = jSONNode is JSONArray;
					num = ((int)num2 * -341038693) ^ 0x12D1B1E4;
					continue;
				case 142u:
					text = JSONNode.smethod_3(text, "\f");
					num = 737390244;
					continue;
				case 141u:
				{
					int num13;
					int num14;
					if (flag6)
					{
						num13 = 922497459;
						num14 = 922497459;
					}
					else
					{
						num13 = 322610638;
						num14 = 322610638;
					}
					num = num13 ^ ((int)num2 * -406913165);
					continue;
				}
				case 140u:
					num = 123098266;
					continue;
				case 139u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)(num2 * 1390644334) ^ -1280161647;
					continue;
				case 138u:
					flag5 = flag4;
					num = (int)((num2 * 721696839) ^ 0x7E90DA5B);
					continue;
				case 137u:
					num = (int)((num2 * 790623524) ^ 0x3F73B680);
					continue;
				case 136u:
					num = ((int)num2 * -722516382) ^ 0xC14AF72;
					continue;
				case 135u:
				{
					int num61;
					if (c3 == 'n')
					{
						num = 665117583;
						num61 = 665117583;
					}
					else
					{
						num = 1223741053;
						num61 = 1223741053;
					}
					continue;
				}
				case 134u:
				{
					int num55;
					int num56;
					if (!flag7)
					{
						num55 = 1888108651;
						num56 = 1888108651;
					}
					else
					{
						num55 = 409011530;
						num56 = 409011530;
					}
					num = num55 ^ (int)(num2 * 1070258556);
					continue;
				}
				case 133u:
				{
					int num48;
					int num49;
					if (flag15)
					{
						num48 = -871929266;
						num49 = -871929266;
					}
					else
					{
						num48 = -1186055950;
						num49 = -1186055950;
					}
					num = num48 ^ ((int)num2 * -846628129);
					continue;
				}
				case 132u:
				{
					int num42;
					int num43;
					if ((uint)c <= 44u)
					{
						num42 = -1685124504;
						num43 = -1685124504;
					}
					else
					{
						num42 = -1328872476;
						num43 = -1328872476;
					}
					num = num42 ^ ((int)num2 * -1321060121);
					continue;
				}
				case 131u:
					num = ((int)num2 * -611940280) ^ -1402426573;
					continue;
				case 130u:
				{
					int num38;
					int num39;
					if (jSONNode != null)
					{
						num38 = 575901231;
						num39 = 575901231;
					}
					else
					{
						num38 = 1746633366;
						num39 = 1746633366;
					}
					num = num38 ^ (int)(num2 * 1765637530);
					continue;
				}
				case 129u:
					num = (int)((num2 * 1207283209) ^ 0x32AD5045);
					continue;
				case 128u:
				{
					int num33;
					int num34;
					if (!flag13)
					{
						num33 = -291680888;
						num34 = -291680888;
					}
					else
					{
						num33 = -201688625;
						num34 = -201688625;
					}
					num = num33 ^ (int)(num2 * 1782775490);
					continue;
				}
				case 127u:
					num = 1379932078;
					continue;
				case 126u:
					text = "";
					num = ((int)num2 * -312183174) ^ 0xCE26E52;
					continue;
				case 125u:
					flag10 = num4 < JSONNode.smethod_4(aJSON);
					num = 2048567973;
					continue;
				case 124u:
					switch (c)
					{
					case '\t':
						goto IL_0457;
					case '\v':
					case '\f':
						goto IL_0465;
					case '\n':
					case '\r':
						goto IL_0486;
					}
					num = (int)(num2 * 1339373907) ^ -1761375833;
					continue;
				case 66u:
					goto IL_0457;
				case 104u:
					goto IL_0465;
				case 6u:
				case 23u:
				case 48u:
				case 55u:
				case 117u:
					goto IL_0486;
				case 123u:
					num = (int)(num2 * 355718352) ^ -2062164796;
					continue;
				case 122u:
					num = (int)((num2 * 2096649300) ^ 0x7269CA09);
					continue;
				case 121u:
					num = ((int)num2 * -742419604) ^ -986008217;
					continue;
				case 120u:
					jSONNode.Add(stack.Peek());
					num = (int)(num2 * 352377793) ^ -2017568926;
					continue;
				case 119u:
				{
					int num21;
					int num22;
					if (!flag9)
					{
						num21 = -369694634;
						num22 = -369694634;
					}
					else
					{
						num21 = -213436912;
						num22 = -213436912;
					}
					num = num21 ^ (int)(num2 * 68009236);
					continue;
				}
				case 118u:
					num = (int)(num2 * 1224435961) ^ -1849584111;
					continue;
				case 116u:
					flag4 = false;
					num = ((int)num2 * -1430726428) ^ -509067434;
					continue;
				case 115u:
					text = JSONNode.smethod_3(text, "\n");
					num = 2062282064;
					continue;
				case 114u:
					num = ((int)num2 * -1747219063) ^ 0x127F7B7C;
					continue;
				case 113u:
				{
					int num11;
					if (c != '{')
					{
						num = 1522731053;
						num11 = 1522731053;
					}
					else
					{
						num = 1223323381;
						num11 = 1223323381;
					}
					continue;
				}
				case 112u:
				{
					int num7;
					int num8;
					if (!JSONNode.smethod_6(text, ""))
					{
						num7 = -1387111137;
						num8 = -1387111137;
					}
					else
					{
						num7 = -438214923;
						num8 = -438214923;
					}
					num = num7 ^ (int)(num2 * 482714243);
					continue;
				}
				case 111u:
					jSONNode = stack.Peek();
					num = ((int)num2 * -921613060) ^ -855834543;
					continue;
				case 110u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1566497174) ^ 0x4FBF1073;
					continue;
				case 109u:
					flag4 = !flag4;
					num = 724369690;
					continue;
				case 108u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -1304180509) ^ 0x39E7182A;
					continue;
				case 107u:
				{
					int num62;
					if (c3 != 'f')
					{
						num = 1075062393;
						num62 = 1075062393;
					}
					else
					{
						num = 861899858;
						num62 = 861899858;
					}
					continue;
				}
				case 106u:
					c5 = JSONNode.smethod_2(aJSON, num4);
					num = 646824842;
					continue;
				case 105u:
				{
					int num60;
					if (flag4)
					{
						num = 17293138;
						num60 = 17293138;
					}
					else
					{
						num = 344421983;
						num60 = 344421983;
					}
					continue;
				}
				case 103u:
					stack.Pop();
					num = 1873210188;
					continue;
				case 102u:
					num = ((int)num2 * -712640785) ^ -1120747101;
					continue;
				case 101u:
					flag14 = JSONNode.smethod_6(text2, "");
					num = 607444909;
					continue;
				case 100u:
				{
					int num57;
					if ((uint)c <= 93u)
					{
						num = 571306255;
						num57 = 571306255;
					}
					else
					{
						num = 250352205;
						num57 = 250352205;
					}
					continue;
				}
				case 99u:
				{
					int num53;
					int num54;
					if (!flag11)
					{
						num53 = -121580888;
						num54 = -121580888;
					}
					else
					{
						num53 = -203440293;
						num54 = -203440293;
					}
					num = num53 ^ ((int)num2 * -123434133);
					continue;
				}
				case 98u:
					num = 302390601;
					continue;
				case 97u:
					num = (int)(num2 * 1197482245) ^ -1398070219;
					continue;
				case 96u:
				{
					int num50;
					if (flag4)
					{
						num = 145100247;
						num50 = 145100247;
					}
					else
					{
						num = 141348967;
						num50 = 141348967;
					}
					continue;
				}
				case 95u:
					flag15 = JSONNode.smethod_6(text, "");
					num = 1593944569;
					continue;
				case 94u:
					text2 = "";
					num = 145376028;
					continue;
				case 93u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 1726113484) ^ 0x39D07090);
					continue;
				case 92u:
				{
					int num47;
					if (c == ',')
					{
						num = 707203927;
						num47 = 707203927;
					}
					else
					{
						num = 231474631;
						num47 = 231474631;
					}
					continue;
				}
				case 91u:
					num = ((int)num2 * -392696862) ^ -843874938;
					continue;
				case 90u:
				{
					int num44;
					if (!JSONNode.smethod_6(text2, ""))
					{
						num = 1260293706;
						num44 = 1260293706;
					}
					else
					{
						num = 1319467061;
						num44 = 1319467061;
					}
					continue;
				}
				case 89u:
					flag9 = flag4;
					num = ((int)num2 * -145291905) ^ -279347540;
					continue;
				case 88u:
					goto IL_0809;
				case 87u:
				{
					int num41;
					if (c != ' ')
					{
						num = 174634421;
						num41 = 174634421;
					}
					else
					{
						num = 1825735038;
						num41 = 1825735038;
					}
					continue;
				}
				case 86u:
					c = c5;
					num = ((int)num2 * -1093020871) ^ 0x6A58D95E;
					continue;
				case 85u:
				{
					int num40;
					if (c != '}')
					{
						num = 534602591;
						num40 = 534602591;
					}
					else
					{
						num = 324852488;
						num40 = 324852488;
					}
					continue;
				}
				case 84u:
					s = JSONNode.smethod_8(aJSON, num4 + 1, 4);
					num = ((int)num2 * -1310145067) ^ 0x6CADC63C;
					continue;
				case 83u:
				{
					int num36;
					int num37;
					if (c == ':')
					{
						num36 = 1341852259;
						num37 = 1341852259;
					}
					else
					{
						num36 = 802067692;
						num37 = 802067692;
					}
					num = num36 ^ (int)(num2 * 695536485);
					continue;
				}
				case 82u:
					text2 = "";
					text = "";
					num = 2042789555;
					continue;
				case 81u:
					num = ((int)num2 * -1631345192) ^ 0x422B15D8;
					continue;
				case 79u:
					switch (c)
					{
					case '[':
						break;
					case ']':
						goto IL_0119;
					case '\\':
						goto IL_0809;
					default:
						goto IL_08fc;
					}
					goto case 159u;
				case 78u:
					num = (int)((num2 * 1333647634) ^ 0x754AE3BF);
					continue;
				case 76u:
					text = "";
					text2 = "";
					num = (int)((num2 * 2064818110) ^ 0x7F5154E0);
					continue;
				case 75u:
				{
					int num35;
					if (!flag4)
					{
						num = 969565091;
						num35 = 969565091;
					}
					else
					{
						num = 1294141792;
						num35 = 1294141792;
					}
					continue;
				}
				case 74u:
					num = (int)((num2 * 21390203) ^ 0x1144664);
					continue;
				case 73u:
					jSONNode.Add(text2, text);
					num = ((int)num2 * -159403586) ^ 0x51B362A4;
					continue;
				case 72u:
				{
					int num31;
					int num32;
					if (!flag)
					{
						num31 = 866917058;
						num32 = 866917058;
					}
					else
					{
						num31 = 788286942;
						num32 = 788286942;
					}
					num = num31 ^ (int)(num2 * 1074875766);
					continue;
				}
				case 71u:
					num = ((int)num2 * -2047259186) ^ -263318982;
					continue;
				case 70u:
					num = ((int)num2 * -593377563) ^ -700700043;
					continue;
				case 69u:
				{
					int num29;
					int num30;
					if (!flag12)
					{
						num29 = 1321760234;
						num30 = 1321760234;
					}
					else
					{
						num29 = 949453187;
						num30 = 949453187;
					}
					num = num29 ^ (int)(num2 * 2036202228);
					continue;
				}
				case 68u:
					text = JSONNode.smethod_3(text, ((char)int.Parse(s, NumberStyles.AllowHexSpecifier)).ToString());
					num = ((int)num2 * -183669514) ^ -1604130233;
					continue;
				case 67u:
					num4 += 4;
					num = ((int)num2 * -1590913655) ^ 0xF999826;
					continue;
				case 65u:
				{
					int num27;
					int num28;
					if (!flag5)
					{
						num27 = -1519355755;
						num28 = -1519355755;
					}
					else
					{
						num27 = -1694413613;
						num28 = -1694413613;
					}
					num = num27 ^ (int)(num2 * 1378096624);
					continue;
				}
				case 64u:
					c4 = JSONNode.smethod_2(aJSON, num4);
					c2 = c4;
					num = ((int)num2 * -1923474869) ^ -370315450;
					continue;
				case 62u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = (int)((num2 * 1001932751) ^ 0x268083C9);
					continue;
				case 61u:
					text = "";
					num = (int)(num2 * 1947951015) ^ -1173976754;
					continue;
				case 60u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1654478480) ^ 0x6302CCAB;
					continue;
				case 59u:
					stack.Push(new JSONArray());
					num = 1434489067;
					continue;
				case 58u:
					num = ((int)num2 * -779985440) ^ -587609712;
					continue;
				case 57u:
				{
					int num25;
					int num26;
					if (flag10)
					{
						num25 = -1268161040;
						num26 = -1268161040;
					}
					else
					{
						num25 = -34947408;
						num26 = -34947408;
					}
					num = num25 ^ ((int)num2 * -713116490);
					continue;
				}
				case 56u:
				{
					int num23;
					int num24;
					if (flag3)
					{
						num23 = 7249004;
						num24 = 7249004;
					}
					else
					{
						num23 = 1763476315;
						num24 = 1763476315;
					}
					num = num23 ^ ((int)num2 * -363956466);
					continue;
				}
				case 54u:
				{
					text2 = JSONNode.smethod_5(text2);
					int num17;
					int num18;
					if (!(jSONNode is JSONArray))
					{
						num17 = 134814844;
						num18 = 134814844;
					}
					else
					{
						num17 = 614512590;
						num18 = 614512590;
					}
					num = num17 ^ ((int)num2 * -1263815177);
					continue;
				}
				case 53u:
					num = (int)((num2 * 1910399963) ^ 0x4E5E5D9C);
					continue;
				case 52u:
				{
					int num15;
					int num16;
					if (flag8)
					{
						num15 = -545682856;
						num16 = -545682856;
					}
					else
					{
						num15 = -594573173;
						num16 = -594573173;
					}
					num = num15 ^ (int)(num2 * 528083871);
					continue;
				}
				case 51u:
					num = (int)((num2 * 1406770856) ^ 0x4BAE0F68);
					continue;
				case 49u:
					num = ((int)num2 * -138065328) ^ 0x46318D99;
					continue;
				case 47u:
					num = (int)((num2 * 992036538) ^ 0x14425AF5);
					continue;
				case 46u:
					flag7 = JSONNode.smethod_6(text2, "");
					num = 1118040090;
					continue;
				case 43u:
					num = (int)((num2 * 2062743518) ^ 0x273A9FD);
					continue;
				case 42u:
				{
					int num12;
					if (JSONNode.smethod_6(text2, ""))
					{
						num = 1255629072;
						num12 = 1255629072;
					}
					else
					{
						num = 1720856286;
						num12 = 1720856286;
					}
					continue;
				}
				case 41u:
					num = ((int)num2 * -1478401039) ^ -102464659;
					continue;
				case 40u:
				{
					int num9;
					int num10;
					if ((uint)c > 32u)
					{
						num9 = 560747091;
						num10 = 560747091;
					}
					else
					{
						num9 = 801985000;
						num10 = 801985000;
					}
					num = num9 ^ ((int)num2 * -1336948003);
					continue;
				}
				case 39u:
					num = (int)((num2 * 2090926607) ^ 0x46C7F17D);
					continue;
				case 38u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -519432223) ^ 0x1195A9EF;
					continue;
				case 37u:
					num = 414285154;
					continue;
				case 36u:
					text2 = JSONNode.smethod_5(text2);
					num = ((int)num2 * -2038549256) ^ 0x506F3BF3;
					continue;
				case 35u:
					num = (int)((num2 * 168342425) ^ 0x6241F5FF);
					continue;
				case 34u:
					num = (int)(num2 * 414134563) ^ -1161576057;
					continue;
				case 33u:
					num = ((int)num2 * -1822163281) ^ -1059789363;
					continue;
				case 32u:
					text = "";
					jSONNode = stack.Peek();
					num = ((int)num2 * -462105632) ^ -1917156117;
					continue;
				case 30u:
					jSONNode.Add(text2, stack.Peek());
					num = (int)((num2 * 2099290962) ^ 0x41BD57D3);
					continue;
				case 29u:
				{
					int num5;
					int num6;
					if (c3 == 'b')
					{
						num5 = -2042619837;
						num6 = -2042619837;
					}
					else
					{
						num5 = -381513135;
						num6 = -381513135;
					}
					num = num5 ^ ((int)num2 * -827164105);
					continue;
				}
				case 28u:
					flag3 = stack.Count > 0;
					num = ((int)num2 * -322575106) ^ 0x91725EC;
					continue;
				case 27u:
					text2 = text;
					num = 426130498;
					continue;
				case 26u:
					c3 = c2;
					num = ((int)num2 * -653511806) ^ -1774126662;
					continue;
				case 25u:
					result = jSONNode;
					num = 770579277;
					continue;
				case 24u:
					num = (int)(num2 * 1006267125) ^ -595244792;
					continue;
				case 22u:
					num = 1737543471;
					continue;
				case 21u:
					text2 = "";
					num = 938945697;
					continue;
				case 20u:
					flag2 = stack.Count == 0;
					num = 1699074534;
					continue;
				case 19u:
					num = (int)((num2 * 1701111325) ^ 0x2CC85364);
					continue;
				case 18u:
					jSONNode.Add(stack.Peek());
					num = ((int)num2 * -1317281989) ^ 0x4BFF2E74;
					continue;
				case 17u:
					num = (int)(num2 * 1079617644) ^ -1123853726;
					continue;
				case 16u:
					num = (int)(num2 * 2042875143) ^ -398114711;
					continue;
				case 15u:
					num = ((int)num2 * -985186794) ^ 0x1BE22341;
					continue;
				case 14u:
					num = ((int)num2 * -891972446) ^ 0x4D134142;
					continue;
				case 13u:
					num = (int)((num2 * 1728544276) ^ 0x2AA57474);
					continue;
				case 12u:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = ((int)num2 * -1285864687) ^ 0x2B2E17C5;
					continue;
				case 11u:
					flag = jSONNode is JSONArray;
					num = (int)(num2 * 1332785439) ^ -174561727;
					continue;
				case 10u:
					num = ((int)num2 * -392866432) ^ 0x75F5EA50;
					continue;
				case 9u:
					num = (int)(num2 * 128354783) ^ -570521988;
					continue;
				case 8u:
					jSONNode.Add(text);
					num = ((int)num2 * -827384299) ^ 0x214C6B1E;
					continue;
				case 7u:
				{
					int num3;
					if (c == '"')
					{
						num = 128476401;
						num3 = 128476401;
					}
					else
					{
						num = 2004329229;
						num3 = 2004329229;
					}
					continue;
				}
				case 5u:
					num = ((int)num2 * -1011135165) ^ 0x65F7695F;
					continue;
				case 4u:
					text = JSONNode.smethod_3(text, "\b");
					num = 490863943;
					continue;
				case 3u:
					stack.Push(new JSONClass());
					num = 1941037469;
					continue;
				case 2u:
					num = ((int)num2 * -1008304558) ^ 0x250B73CF;
					continue;
				case 1u:
					num = ((int)num2 * -925981830) ^ 0x537D1FEA;
					continue;
				case 0u:
					jSONNode = stack.Peek();
					num = (int)(num2 * 1578288650) ^ -206567285;
					continue;
				case 45u:
					break;
				case 63u:
					throw JSONNode.smethod_7("JSON Parse: Quotation marks seems to be messed up.");
				case 150u:
					throw JSONNode.smethod_7("JSON Parse: Too many closing brackets");
				default:
					{
						return result;
					}
					IL_0465:
					text = JSONNode.smethod_3(text, JSONNode.smethod_2(aJSON, num4).ToString());
					num = 1304083691;
					continue;
					IL_0457:
					flag11 = flag4;
					num = 551989407;
					continue;
					IL_0486:
					num4++;
					num = 379498014;
					continue;
					IL_01fa:
					num = 679947144;
					continue;
					IL_08fc:
					num = 372259195;
					continue;
					IL_01cc:
					text = JSONNode.smethod_3(text, c4.ToString());
					num = 2106788966;
					continue;
					IL_01b6:
					text = JSONNode.smethod_3(text, "\r");
					num = 379621750;
					continue;
					IL_01e4:
					text = JSONNode.smethod_3(text, "\t");
					num = 97046973;
					continue;
					IL_0809:
					num4++;
					num = 695711941;
					continue;
					IL_0119:
					flag13 = flag4;
					num = 1552784060;
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
			int num = -1466325091;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7B84448u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -929084760) ^ -1822165068;
					continue;
				case 1u:
				{
					BinaryWriter aWriter = JSONNode.smethod_9(aData);
					Serialize(aWriter);
					num = (int)((num2 * 521568014) ^ 0x36DC27C4);
					continue;
				}
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
			int num = -566618755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9F170F3u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					FileStream fileStream = JSONNode.smethod_14(aFileName);
					try
					{
						while (true)
						{
							int num3 = -697902924;
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xF9F170F3u) % 4u)
								{
								case 3u:
									SaveToStream(fileStream);
									num3 = (int)(num2 * 1400226009) ^ -29623146;
									continue;
								case 2u:
									num3 = ((int)num2 * -1184472900) ^ -1666929786;
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
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_00d6:
								int num4 = -583588754;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0xF9F170F3u) % 3u)
									{
									case 1u:
										goto IL_00a6;
									default:
										goto end_IL_00b9;
									case 0u:
										break;
									case 2u:
										goto end_IL_00b9;
									}
									goto IL_00d6;
									IL_00a6:
									JSONNode.smethod_15((IDisposable)fileStream);
									num4 = ((int)num2 * -667779088) ^ 0x5D3E9202;
									continue;
									end_IL_00b9:
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
				num = (int)(num2 * 219247900) ^ -1518432637;
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
				int num = 1274812743;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x14E9B41Cu) % 6u)
					{
					case 5u:
						SaveToStream(memoryStream);
						num = (int)(num2 * 1836447011) ^ -664377067;
						continue;
					case 4u:
						JSONNode.smethod_17((Stream)memoryStream, 0L);
						num = (int)(num2 * 1634762408) ^ -1478306566;
						continue;
					case 2u:
						num = (int)((num2 * 666828381) ^ 0x4F37CF1A);
						continue;
					case 0u:
						result = JSONNode.smethod_19(JSONNode.smethod_18(memoryStream));
						num = (int)((num2 * 177872872) ^ 0x10B5CA15);
						continue;
					case 3u:
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
					IL_00cf:
					int num3 = 585307617;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0x14E9B41Cu) % 3u)
						{
						case 1u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 0u:
							break;
						case 2u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						JSONNode.smethod_15((IDisposable)memoryStream);
						num3 = (int)((num2 * 720344370) ^ 0x3C3E3DA4);
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
		JSONArray jSONArray = default(JSONArray);
		int num7 = default(int);
		int num3 = default(int);
		JSONNode result = default(JSONNode);
		JSONClass jSONClass = default(JSONClass);
		JSONNode aItem = default(JSONNode);
		string aKey = default(string);
		bool flag = default(bool);
		JSONBinaryTag jSONBinaryTag2 = default(JSONBinaryTag);
		int num4 = default(int);
		int num6 = default(int);
		JSONBinaryTag jSONBinaryTag = default(JSONBinaryTag);
		while (true)
		{
			int num = -1860075860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93D26E75u) % 39u)
				{
				case 38u:
					num = (int)(num2 * 837319566) ^ -626910531;
					continue;
				case 37u:
					jSONArray = new JSONArray();
					num7 = 0;
					num = (int)((num2 * 237606523) ^ 0x72A02B25);
					continue;
				case 36u:
					num3++;
					num = ((int)num2 * -53139088) ^ -719691785;
					continue;
				case 35u:
					result = jSONClass;
					num = ((int)num2 * -1840752398) ^ -1744511975;
					continue;
				case 34u:
					result = new JSONData(JSONNode.smethod_23(aReader));
					num = -901161127;
					continue;
				case 33u:
					aItem = Deserialize(aReader);
					num = ((int)num2 * -828615909) ^ -474737911;
					continue;
				case 32u:
					jSONArray.Add(Deserialize(aReader));
					num = -1460528839;
					continue;
				case 31u:
					num = (int)((num2 * 1509582580) ^ 0x1A523B15);
					continue;
				case 30u:
					goto IL_00c2;
				case 29u:
					aKey = JSONNode.smethod_22(aReader);
					num = (int)((num2 * 1508915708) ^ 0x46619FC8);
					continue;
				case 28u:
					num7++;
					num = (int)((num2 * 1279587564) ^ 0x2486DAFA);
					continue;
				case 26u:
					goto IL_0100;
				case 24u:
					num3 = 0;
					num = (int)((num2 * 1399451918) ^ 0x3B2A89EF);
					continue;
				case 23u:
					goto IL_0120;
				case 22u:
				{
					int num8;
					int num9;
					if (flag)
					{
						num8 = -474606429;
						num9 = -474606429;
					}
					else
					{
						num8 = -624145688;
						num9 = -624145688;
					}
					num = num8 ^ ((int)num2 * -368241362);
					continue;
				}
				case 21u:
					result = jSONArray;
					num = ((int)num2 * -2077743160) ^ -1332733645;
					continue;
				case 20u:
					num = ((int)num2 * -371738539) ^ -979156194;
					continue;
				case 19u:
					num = ((int)num2 * -530891593) ^ -470004042;
					continue;
				case 18u:
					result = new JSONData(JSONNode.smethod_25(aReader));
					num = (int)((num2 * 585222335) ^ 0x3C1C36A1);
					continue;
				case 17u:
					switch (jSONBinaryTag2)
					{
					case JSONBinaryTag.DoubleValue:
						break;
					case JSONBinaryTag.IntValue:
						goto IL_00c2;
					case JSONBinaryTag.Class:
						goto IL_0100;
					case JSONBinaryTag.BoolValue:
						goto IL_0120;
					default:
						goto IL_01e3;
					case JSONBinaryTag.Array:
						goto IL_01f6;
					case JSONBinaryTag.Value:
						goto IL_0200;
					case JSONBinaryTag.FloatValue:
						goto IL_020a;
					}
					goto case 34u;
				case 7u:
					goto IL_01f6;
				case 1u:
					goto IL_0200;
				case 9u:
					goto IL_020a;
				case 16u:
					num4 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1875033574) ^ 0x5921D8FF;
					continue;
				case 15u:
					flag = num7 < num6;
					num = -526668766;
					continue;
				case 14u:
					jSONClass = new JSONClass();
					num = ((int)num2 * -1824157236) ^ -276320465;
					continue;
				case 13u:
					jSONBinaryTag = (JSONBinaryTag)JSONNode.smethod_20(aReader);
					jSONBinaryTag2 = jSONBinaryTag;
					num = (int)((num2 * 819238911) ^ 0x71733317);
					continue;
				case 12u:
					num = (int)((num2 * 1747763964) ^ 0x45C04DCF);
					continue;
				case 11u:
					num6 = JSONNode.smethod_21(aReader);
					num = ((int)num2 * -1487121344) ^ -419043448;
					continue;
				case 8u:
					jSONClass.Add(aKey, aItem);
					num = ((int)num2 * -1523802531) ^ -103954707;
					continue;
				case 6u:
					result = new JSONData(JSONNode.smethod_21(aReader));
					num = ((int)num2 * -1781367758) ^ -559370284;
					continue;
				case 5u:
					num = (int)(num2 * 1733253564) ^ -1701866959;
					continue;
				case 4u:
					num = -1903638267;
					continue;
				case 3u:
					num = ((int)num2 * -1001817808) ^ 0x6F159409;
					continue;
				case 2u:
				{
					int num5;
					if (num3 < num4)
					{
						num = -692269272;
						num5 = -692269272;
					}
					else
					{
						num = -2126764664;
						num5 = -2126764664;
					}
					continue;
				}
				case 0u:
					result = new JSONData(JSONNode.smethod_22(aReader));
					num = ((int)num2 * -1321880040) ^ 0x15B5D8FA;
					continue;
				case 10u:
					break;
				case 27u:
					throw JSONNode.smethod_7(JSONNode.smethod_3("Error deserializing JSON. Unknown tag: ", jSONBinaryTag.ToString()));
				default:
					{
						return result;
					}
					IL_020a:
					num = -1657818499;
					continue;
					IL_0200:
					num = -68243628;
					continue;
					IL_01f6:
					num = -1202889340;
					continue;
					IL_01e3:
					num = (int)(num2 * 1378315015) ^ -1360893870;
					continue;
					IL_0120:
					result = new JSONData(JSONNode.smethod_24(aReader));
					num = -2043589254;
					continue;
					IL_0100:
					num = -1228864554;
					continue;
					IL_00c2:
					num = -926024968;
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
					int num = 1601089448;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x1E8126F3u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)binaryReader);
							num = ((int)num2 * -58036068) ^ -1869945167;
							continue;
						case 2u:
							num = (int)((num2 * 967674744) ^ 0x6BA41986);
							continue;
						default:
							goto end_IL_0037;
						case 0u:
							break;
						case 1u:
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
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = -61944770;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA36D6073u) % 3u)
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
					num = (int)((num2 * 305989092) ^ 0x664C5BE2);
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
					int num3 = -1613964508;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num3 ^ 0xA36D6073u) % 4u)
						{
						case 3u:
							JSONNode.smethod_15((IDisposable)fileStream);
							num3 = (int)(num2 * 762098761) ^ -991488735;
							continue;
						case 1u:
							num3 = ((int)num2 * -2106525071) ^ 0x6AB81B70;
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
		byte[] byte_ = JSONNode.smethod_28(aBase64);
		MemoryStream memoryStream = default(MemoryStream);
		JSONNode result = default(JSONNode);
		while (true)
		{
			int num = -1886345294;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCAC79933u) % 7u)
				{
				case 5u:
					num = (int)((num2 * 1756634968) ^ 0x12E5F92B);
					continue;
				case 4u:
					memoryStream = JSONNode.smethod_29(byte_);
					num = (int)((num2 * 634487211) ^ 0x5CEED52E);
					continue;
				case 3u:
					num = ((int)num2 * -1659455147) ^ -1204507665;
					continue;
				case 2u:
					JSONNode.smethod_17((Stream)memoryStream, 0L);
					num = (int)(num2 * 2013361195) ^ -129714091;
					continue;
				case 1u:
					result = LoadFromStream(memoryStream);
					num = ((int)num2 * -570917708) ^ 0x6AA29A03;
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

	public JSONNode()
	{
		while (true)
		{
			int num = 321829805;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59C9298Fu) % 3u)
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
				num = ((int)num2 * -830344992) ^ -1172096884;
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
