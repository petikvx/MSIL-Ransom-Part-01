using System.IO;

namespace SimpleJSON;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			string data = default(string);
			while (true)
			{
				int num = -406448635;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFE31A7A1u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = (int)((num2 * 1502910749) ^ 0x62258A3);
				}
			}
		}
		set
		{
			m_Data = value;
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = -2120767192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x821122ECu) % 3u)
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
				m_Data = aData;
				num = ((int)num2 * -894864227) ^ -95113890;
			}
		}
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 1357809609;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5AB5C292u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 1044611394) ^ -146635124;
					continue;
				case 3u:
					AsFloat = aData;
					num = (int)((num2 * 1620089417) ^ 0x23A0F2B0);
					continue;
				case 1u:
					num = ((int)num2 * -2136800618) ^ 0x5068F6B2;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 1083833628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x577C9E49u) % 5u)
				{
				case 3u:
					AsDouble = aData;
					num = (int)(num2 * 1315067585) ^ -1886281476;
					continue;
				case 1u:
					num = ((int)num2 * -58064755) ^ 0x6CE9EA13;
					continue;
				case 0u:
					num = ((int)num2 * -210896960) ^ -1218663049;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -104957679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B1710AFu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1016568335) ^ -1985226119;
					continue;
				case 3u:
					num = (int)(num2 * 459976001) ^ -1310771720;
					continue;
				case 1u:
					AsBool = aData;
					num = (int)((num2 * 1104855164) ^ 0x42DA660D);
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -544578482;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFB9FF61u) % 6u)
				{
				case 4u:
					num = (int)(num2 * 1043078964) ^ -1947449749;
					continue;
				case 3u:
					AsInt = aData;
					num = ((int)num2 * -866869299) ^ -2010234302;
					continue;
				case 2u:
					num = (int)((num2 * 1708864320) ^ 0x14289C3E);
					continue;
				case 1u:
					num = ((int)num2 * -58579938) ^ 0x539AD005;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
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
			int num = 660731149;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4B2E2045u) % 3u)
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
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = (int)(num2 * 374579490) ^ -1610144334;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = -2143266822;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED7F8819u) % 3u)
				{
				case 1u:
					goto IL_001d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_001d:
				num = ((int)num2 * -39322139) ^ -632032522;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1475450362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x534D45C8u) % 38u)
				{
				case 37u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1126876522) ^ -1224373558;
					continue;
				case 35u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -710809794) ^ 0x2C959525;
					continue;
				case 34u:
				{
					int num9;
					int num10;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = 1227563163;
						num10 = 1227563163;
					}
					else
					{
						num9 = 927064356;
						num10 = 927064356;
					}
					num = num9 ^ ((int)num2 * -259466189);
					continue;
				}
				case 33u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1577129091) ^ 0x53550598);
					continue;
				case 32u:
					num = (int)((num2 * 842137140) ^ 0x5934A3FD);
					continue;
				case 31u:
					num = ((int)num2 * -884997877) ^ -871481422;
					continue;
				case 30u:
					num = (int)((num2 * 94923425) ^ 0x3177CD37);
					continue;
				case 29u:
					num = (int)(num2 * 445947955) ^ -289544150;
					continue;
				case 28u:
					num = ((int)num2 * -545546249) ^ -1645847276;
					continue;
				case 27u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)((num2 * 1978755517) ^ 0x7ABD9C52);
					continue;
				case 26u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 205887516;
						num8 = 205887516;
					}
					else
					{
						num7 = 1669953278;
						num8 = 1669953278;
					}
					num = num7 ^ (int)(num2 * 111524502);
					continue;
				}
				case 25u:
					jSONData.AsDouble = AsDouble;
					num = 1578127540;
					continue;
				case 24u:
					num = (int)(num2 * 756075544) ^ -1147462275;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1614350680) ^ 0x329A8BAF;
					continue;
				case 22u:
					jSONData.AsBool = AsBool;
					num = 1438991172;
					continue;
				case 21u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 1734459644) ^ -1987060978;
					continue;
				case 20u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1113854204;
						num6 = 1113854204;
					}
					else
					{
						num5 = 1713699396;
						num6 = 1713699396;
					}
					num = num5 ^ (int)(num2 * 338005901);
					continue;
				}
				case 19u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -884717255;
						num4 = -884717255;
					}
					else
					{
						num3 = -2126007976;
						num4 = -2126007976;
					}
					num = num3 ^ ((int)num2 * -1867860958);
					continue;
				}
				case 18u:
					num = ((int)num2 * -1234221624) ^ -619417587;
					continue;
				case 17u:
					num = ((int)num2 * -1037965522) ^ 0x6AF5C6D8;
					continue;
				case 16u:
					num = (int)(num2 * 1544359587) ^ -693471215;
					continue;
				case 14u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1727414809) ^ 0x3B1251F6);
					continue;
				case 13u:
					num = (int)((num2 * 1988089022) ^ 0x7E0CFA2A);
					continue;
				case 12u:
					num = ((int)num2 * -1833020571) ^ 0x6F6BADAD;
					continue;
				case 11u:
					num = (int)(num2 * 791330124) ^ -1641006841;
					continue;
				case 10u:
					jSONData.AsFloat = AsFloat;
					num = 785782184;
					continue;
				case 9u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1372641104) ^ 0x37532B69);
					continue;
				case 8u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 2105571041) ^ 0x58FA8B8E);
					continue;
				case 7u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 1368117075) ^ -975514706;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 655841133;
					continue;
				case 5u:
					num = ((int)num2 * -1212266455) ^ 0x21ACD37C;
					continue;
				case 4u:
					num = ((int)num2 * -1410011205) ^ -908748887;
					continue;
				case 3u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -2004384839) ^ -302034185;
					continue;
				case 2u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -652637202) ^ -286781543;
					continue;
				case 1u:
					num = ((int)num2 * -359141853) ^ 0x3D8D21DA;
					continue;
				case 0u:
					num = (int)((num2 * 1137330268) ^ 0x7B15CF4D);
					continue;
				default:
					return;
				case 36u:
					break;
				case 15u:
					return;
				}
				break;
			}
		}
	}

	static string smethod_30(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static bool smethod_31(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_32(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_33(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	static void smethod_34(BinaryWriter binaryWriter_0, float float_0)
	{
		binaryWriter_0.Write(float_0);
	}

	static void smethod_35(BinaryWriter binaryWriter_0, double double_0)
	{
		binaryWriter_0.Write(double_0);
	}

	static void smethod_36(BinaryWriter binaryWriter_0, bool bool_0)
	{
		binaryWriter_0.Write(bool_0);
	}

	static void smethod_37(BinaryWriter binaryWriter_0, string string_0)
	{
		binaryWriter_0.Write(string_0);
	}
}
