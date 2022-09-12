using System.IO;

namespace SimpleJSON;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			string data = m_Data;
			while (true)
			{
				int num = 245510302;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x68B7B5EBu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return data;
					}
					break;
					IL_0009:
					num = (int)((num2 * 2141010396) ^ 0x6025D1A0);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 193116519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4EF731CEu) % 3u)
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
					m_Data = value;
					num = ((int)num2 * -492412643) ^ 0x11DF6B07;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		AsBool = aData;
	}

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -595323815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB00DD8F0u) % 4u)
				{
				case 2u:
					AsInt = aData;
					num = (int)((num2 * 1465187602) ^ 0x447D79BF);
					continue;
				case 1u:
					num = ((int)num2 * -331084769) ^ 0x4041439D;
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

	public override string ToString()
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1900948024;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82E4642Bu) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 776611913) ^ -1921695727;
					continue;
				case 1u:
					num = (int)((num2 * 796452076) ^ 0x7481F8D9);
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag4 = default(bool);
		while (true)
		{
			int num = -785457111;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5EFC1ABu) % 33u)
				{
				case 32u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1560225674) ^ -1304717793;
					continue;
				case 31u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1380723254) ^ -297138536;
					continue;
				case 30u:
					num = (int)((num2 * 1100460374) ^ 0x15E8AA7C);
					continue;
				case 29u:
					num = ((int)num2 * -500262096) ^ 0xFDA5224;
					continue;
				case 28u:
					num = ((int)num2 * -413061720) ^ 0x6D0A2BB4;
					continue;
				case 27u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 20611493;
						num8 = 20611493;
					}
					else
					{
						num7 = 1234053907;
						num8 = 1234053907;
					}
					num = num7 ^ (int)(num2 * 1661251989);
					continue;
				}
				case 26u:
					num = (int)(num2 * 1667785454) ^ -1992769642;
					continue;
				case 25u:
					jSONData.AsBool = AsBool;
					num = -1479368586;
					continue;
				case 24u:
					num = (int)(num2 * 231428031) ^ -1242950790;
					continue;
				case 23u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1361974986) ^ 0x5BF37627;
					continue;
				case 22u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 528186692) ^ 0x59BAB7C4);
					continue;
				case 21u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -204292748) ^ -1869144415;
					continue;
				case 20u:
					num = ((int)num2 * -370289664) ^ 0x57E894FB;
					continue;
				case 19u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1128839065) ^ -1350750940;
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1918741690) ^ 0x64F5184D;
					continue;
				case 16u:
					num = (int)((num2 * 1696555811) ^ 0x38B93511);
					continue;
				case 15u:
					jSONData.AsInt = AsInt;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 955367980) ^ -247381598;
					continue;
				case 14u:
					num = (int)((num2 * 536519336) ^ 0x3B0EC39A);
					continue;
				case 13u:
					num = ((int)num2 * -469038578) ^ -718792652;
					continue;
				case 12u:
					num = (int)(num2 * 2017796895) ^ -626068372;
					continue;
				case 11u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1340700738) ^ 0x59DDBD5;
					continue;
				case 10u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -818537920) ^ 0x4C240944;
					continue;
				case 9u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = 1119345128;
						num10 = 1119345128;
					}
					else
					{
						num9 = 1611936317;
						num10 = 1611936317;
					}
					num = num9 ^ ((int)num2 * -1494545483);
					continue;
				}
				case 8u:
					flag4 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -76274899) ^ -1747204817;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1904950225;
						num6 = 1904950225;
					}
					else
					{
						num5 = 2086199444;
						num6 = 2086199444;
					}
					num = num5 ^ (int)(num2 * 2115184314);
					continue;
				}
				case 5u:
					jSONData.AsFloat = AsFloat;
					num = -2267580;
					continue;
				case 4u:
					jSONData.AsDouble = AsDouble;
					num = -178736333;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1426664522;
					continue;
				case 2u:
					num = ((int)num2 * -140806085) ^ 0x43D61E6C;
					continue;
				case 1u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 20624614) ^ 0x73FEED13);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -569653675;
						num4 = -569653675;
					}
					else
					{
						num3 = -1783804814;
						num4 = -1783804814;
					}
					num = num3 ^ ((int)num2 * -761125177);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 17u:
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
