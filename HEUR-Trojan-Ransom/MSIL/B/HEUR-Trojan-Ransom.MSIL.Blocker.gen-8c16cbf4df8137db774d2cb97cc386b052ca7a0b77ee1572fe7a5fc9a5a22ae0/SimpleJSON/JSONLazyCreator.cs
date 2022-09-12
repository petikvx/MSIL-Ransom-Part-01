namespace SimpleJSON;

internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node = null;

	private string m_Key = null;

	public override JSONNode this[int aIndex]
	{
		get
		{
			JSONNode result = new JSONLazyCreator(this);
			while (true)
			{
				int num = 1554060023;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x22C50CB4u) % 3u)
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
					num = ((int)num2 * -1668571724) ^ -1390202238;
				}
			}
		}
		set
		{
			JSONArray jSONArray = new JSONArray();
			while (true)
			{
				int num = -1098621381;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8C03FF62u) % 4u)
					{
					case 1u:
						jSONArray.Add(value);
						num = (int)(num2 * 55349090) ^ -1458396140;
						continue;
					case 0u:
						Set(jSONArray);
						num = (int)(num2 * 92019534) ^ -487052591;
						continue;
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			JSONNode result = default(JSONNode);
			while (true)
			{
				int num = 1897727275;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3381F496u) % 3u)
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
					result = new JSONLazyCreator(this, aKey);
					num = ((int)num2 * -896188228) ^ -282091035;
				}
			}
		}
		set
		{
			JSONClass jSONClass = default(JSONClass);
			while (true)
			{
				int num = 983311746;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1ED9547Cu) % 4u)
					{
					case 3u:
						num = (int)((num2 * 101406423) ^ 0x6DC41E50);
						continue;
					case 2u:
						jSONClass = new JSONClass();
						jSONClass.Add(aKey, value);
						num = ((int)num2 * -1431008775) ^ 0x54E99C11;
						continue;
					case 0u:
						break;
					default:
						Set(jSONClass);
						return;
					}
					break;
				}
			}
		}
	}

	public override int AsInt
	{
		get
		{
			int result = default(int);
			while (true)
			{
				int num = 233857837;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3E536ED6u) % 6u)
					{
					case 5u:
						num = ((int)num2 * -1780041764) ^ 0x676CEEBA;
						continue;
					case 4u:
						num = (int)(num2 * 483702251) ^ -1514780526;
						continue;
					case 2u:
						result = 0;
						num = ((int)num2 * -1907751093) ^ 0x7CA147;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(0);
						Set(aVal);
						num = ((int)num2 * -1134381257) ^ 0x3AC4967D;
						continue;
					}
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
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 2076538573;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7570D322u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						Set(aVal);
						return;
					}
					break;
					IL_0003:
					aVal = new JSONData(value);
					num = ((int)num2 * -364072640) ^ -427714187;
				}
			}
		}
	}

	public override float AsFloat
	{
		get
		{
			float result = default(float);
			JSONData aVal = default(JSONData);
			while (true)
			{
				int num = 1182177821;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x325BC8C2u) % 7u)
					{
					case 5u:
						result = 0f;
						num = (int)(num2 * 425109889) ^ -1900231338;
						continue;
					case 4u:
						num = ((int)num2 * -1084374802) ^ -1609664784;
						continue;
					case 3u:
						Set(aVal);
						num = ((int)num2 * -430332493) ^ 0x1454EEA2;
						continue;
					case 2u:
						num = ((int)num2 * -755313366) ^ 0x3EAD00E2;
						continue;
					case 1u:
						aVal = new JSONData(0f);
						num = (int)(num2 * 417033004) ^ -1292269909;
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
				int num = -217911334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA88C0E83u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1545573086) ^ 0x2CFAC909;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)(num2 * 308205291) ^ -1032750145;
						continue;
					}
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

	public override double AsDouble
	{
		get
		{
			JSONData aVal = default(JSONData);
			double result = default(double);
			while (true)
			{
				int num = -67265928;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDB90298Cu) % 5u)
					{
					case 4u:
						aVal = new JSONData(0.0);
						num = ((int)num2 * -1195612108) ^ 0x3D72C3E8;
						continue;
					case 1u:
						result = 0.0;
						num = ((int)num2 * -101588331) ^ 0x982977D;
						continue;
					case 0u:
						Set(aVal);
						num = ((int)num2 * -417605749) ^ -923608514;
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
				int num = 2114006749;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x760F42B4u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -961388633) ^ -805829534;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = (int)(num2 * 54325082) ^ -187887524;
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
	}

	public override bool AsBool
	{
		get
		{
			JSONData aVal = default(JSONData);
			bool result = default(bool);
			while (true)
			{
				int num = -1105750490;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBBCA76Cu) % 7u)
					{
					case 6u:
						aVal = new JSONData(aData: false);
						num = ((int)num2 * -1313858240) ^ 0x1CE31561;
						continue;
					case 5u:
						num = (int)(num2 * 753761944) ^ -439242378;
						continue;
					case 3u:
						num = (int)(num2 * 628896669) ^ -1444976092;
						continue;
					case 2u:
						result = false;
						num = (int)((num2 * 1202378087) ^ 0x2221B037);
						continue;
					case 0u:
						Set(aVal);
						num = (int)((num2 * 1725381578) ^ 0x43AB000A);
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
				int num = 1703182040;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5AED5D8Du) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1960910577) ^ -398775656;
						continue;
					case 1u:
					{
						JSONData aVal = new JSONData(value);
						Set(aVal);
						num = ((int)num2 * -325710808) ^ -585796578;
						continue;
					}
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

	public override JSONArray AsArray
	{
		get
		{
			JSONArray jSONArray = new JSONArray();
			JSONArray result = default(JSONArray);
			while (true)
			{
				int num = 1234198836;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x11127092u) % 5u)
					{
					case 2u:
						num = ((int)num2 * -117836959) ^ -1087853522;
						continue;
					case 1u:
						Set(jSONArray);
						num = ((int)num2 * -721624288) ^ 0x4A3AD2F0;
						continue;
					case 0u:
						result = jSONArray;
						num = (int)(num2 * 2077241345) ^ -759481107;
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

	public override JSONClass AsObject
	{
		get
		{
			JSONClass jSONClass = new JSONClass();
			Set(jSONClass);
			JSONClass result = default(JSONClass);
			while (true)
			{
				int num = 554354932;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7054BE3u) % 4u)
					{
					case 3u:
						result = jSONClass;
						num = (int)((num2 * 94613893) ^ 0x58C129E);
						continue;
					case 2u:
						num = ((int)num2 * -721001243) ^ -607682060;
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

	public JSONLazyCreator(JSONNode aNode)
	{
		while (true)
		{
			int num = 1250722280;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x318F7A94u) % 5u)
				{
				case 4u:
					m_Node = aNode;
					m_Key = null;
					num = (int)(num2 * 997993013) ^ -541301274;
					continue;
				case 2u:
					num = ((int)num2 * -1020533366) ^ -618158430;
					continue;
				case 1u:
					num = (int)(num2 * 1225132959) ^ -2142458567;
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

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		while (true)
		{
			int num = 5366090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x352CA341u) % 4u)
				{
				case 3u:
					m_Node = aNode;
					num = ((int)num2 * -1390009595) ^ 0x6921FD87;
					continue;
				case 1u:
					m_Key = aKey;
					num = ((int)num2 * -660713555) ^ 0x66A4C0D2;
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

	private void Set(JSONNode aVal)
	{
		while (true)
		{
			int num = -1903074074;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0AB16F3u) % 10u)
				{
				case 9u:
				{
					int num3;
					int num4;
					if (m_Key != null)
					{
						num3 = -1041750166;
						num4 = -1041750166;
					}
					else
					{
						num3 = -396031227;
						num4 = -396031227;
					}
					num = num3 ^ (int)(num2 * 1767226405);
					continue;
				}
				case 8u:
					m_Node = null;
					num = -58486662;
					continue;
				case 7u:
					num = (int)((num2 * 1430440285) ^ 0x2FA3D462);
					continue;
				case 6u:
					m_Node.Add(m_Key, aVal);
					num = (int)((num2 * 798254131) ^ 0x16FC7477);
					continue;
				case 4u:
					num = -28012929;
					continue;
				case 2u:
					num = ((int)num2 * -449966880) ^ -2031190437;
					continue;
				case 1u:
					m_Node.Add(aVal);
					num = (int)(num2 * 716169907) ^ -538960945;
					continue;
				case 0u:
					num = ((int)num2 * -1500091795) ^ -2060437193;
					continue;
				default:
					return;
				case 5u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void Add(JSONNode aItem)
	{
		JSONArray jSONArray = new JSONArray();
		jSONArray.Add(aItem);
		while (true)
		{
			int num = -132929575;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA03AAB19u) % 5u)
				{
				case 4u:
					Set(jSONArray);
					num = ((int)num2 * -608290823) ^ -759863330;
					continue;
				case 3u:
					num = (int)((num2 * 57130211) ^ 0x3C0E5111);
					continue;
				case 2u:
					num = ((int)num2 * -950821347) ^ -1916047830;
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

	public override void Add(string aKey, JSONNode aItem)
	{
		while (true)
		{
			int num = -98648539;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB789EFAFu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1819638514) ^ 0x43A6F7AC);
					continue;
				case 2u:
				{
					JSONClass jSONClass = new JSONClass();
					jSONClass.Add(aKey, aItem);
					Set(jSONClass);
					num = (int)((num2 * 1636890888) ^ 0x2B197CD8);
					continue;
				}
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

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1746074739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EB610u) % 7u)
				{
				case 4u:
					result = (object)a == b;
					num = 2099719486;
					continue;
				case 3u:
					num = (int)(num2 * 1212852763) ^ -1604209764;
					continue;
				case 2u:
					result = true;
					num = (int)((num2 * 14387419) ^ 0x4F946631);
					continue;
				case 1u:
					flag = b == null;
					num = ((int)num2 * -1621260821) ^ -753969253;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1417131832;
						num4 = -1417131832;
					}
					else
					{
						num3 = -913266463;
						num4 = -913266463;
					}
					num = num3 ^ (int)(num2 * 2041121322);
					continue;
				}
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		bool result = !(a == b);
		while (true)
		{
			int num = -16900537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3188558u) % 3u)
				{
				case 2u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000d:
				num = (int)((num2 * 1394291203) ^ 0x66B8ACAC);
			}
		}
	}

	public override bool Equals(object obj)
	{
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1200618859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D14857Au) % 7u)
				{
				case 6u:
					result = true;
					num = (int)(num2 * 774272527) ^ -552995901;
					continue;
				case 5u:
					flag = obj == null;
					num = (int)((num2 * 521591291) ^ 0x4DA17FB7);
					continue;
				case 4u:
					result = (object)this == obj;
					num = 838964337;
					continue;
				case 3u:
					num = (int)((num2 * 1261410496) ^ 0x24DBB1EB);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1860776720;
						num4 = 1860776720;
					}
					else
					{
						num3 = 229879211;
						num4 = 229879211;
					}
					num = num3 ^ ((int)num2 * -1755120157);
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

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1688657522;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CF215B4u) % 3u)
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
				result = "";
				num = (int)(num2 * 366776745) ^ -1330148509;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		return "";
	}
}
