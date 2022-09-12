using System.IO;

namespace SimpleJSON;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			return m_Data;
		}
		set
		{
			m_Data = value;
		}
	}

	public JSONData(string aData)
	{
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -1588247545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD72321DEu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -513832488) ^ 0x6EE22A87;
					continue;
				case 3u:
					AsFloat = aData;
					num = (int)((num2 * 2139179490) ^ 0x7D7A7936);
					continue;
				case 2u:
					num = ((int)num2 * -1204921859) ^ -1230104875;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 717492179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x387A8BA6u) % 5u)
				{
				case 2u:
					num = ((int)num2 * -1319510023) ^ 0x2C0C9AC4;
					continue;
				case 1u:
					AsDouble = aData;
					num = (int)(num2 * 1488649756) ^ -988237803;
					continue;
				case 0u:
					num = (int)((num2 * 1767503117) ^ 0xF2B7A6C);
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

	public JSONData(bool aData)
	{
		AsBool = aData;
	}

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 758697571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5AA5591Du) % 4u)
				{
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -570447734) ^ -429078008;
					continue;
				case 1u:
					num = (int)(num2 * 53301843) ^ -21482415;
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1179842452;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69D05CFEu) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1233207835) ^ 0x3B6AE680;
					continue;
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 1172825808) ^ 0x36E16C75);
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
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		while (true)
		{
			int num = -1668621574;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF06DC03u) % 37u)
				{
				case 36u:
					jSONData.AsBool = AsBool;
					num = -1170805847;
					continue;
				case 35u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1734062328;
					continue;
				case 34u:
					num = ((int)num2 * -1854551878) ^ -1621617347;
					continue;
				case 33u:
					num = ((int)num2 * -630186490) ^ 0x2694AB65;
					continue;
				case 32u:
					num = (int)((num2 * 2114675231) ^ 0x7D84DEF7);
					continue;
				case 31u:
					num = (int)((num2 * 72707073) ^ 0x25630341);
					continue;
				case 30u:
					num = (int)(num2 * 1006496706) ^ -1848441474;
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1469985767) ^ 0x5283A369;
					continue;
				case 28u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -2084144885) ^ -1939158693;
					continue;
				case 27u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1543813701) ^ -1455293092;
					continue;
				case 26u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -906580970;
						num10 = -906580970;
					}
					else
					{
						num9 = -1712253419;
						num10 = -1712253419;
					}
					num = num9 ^ (int)(num2 * 310393275);
					continue;
				}
				case 25u:
					num = (int)((num2 * 1296930801) ^ 0x13BBCE7E);
					continue;
				case 24u:
					jSONData.AsFloat = AsFloat;
					num = -1762409251;
					continue;
				case 23u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -81917671) ^ 0x78E7F746;
					continue;
				case 22u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -169444993) ^ -1464044368;
					continue;
				case 21u:
					num = (int)((num2 * 854764220) ^ 0x36203CC4);
					continue;
				case 20u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 1054545840) ^ 0x591EB9B8);
					continue;
				case 19u:
					num = (int)(num2 * 1465469326) ^ -1779891410;
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1948200106) ^ -50984038;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -117613337;
						num8 = -117613337;
					}
					else
					{
						num7 = -32481614;
						num8 = -32481614;
					}
					num = num7 ^ (int)(num2 * 467496957);
					continue;
				}
				case 16u:
					num = (int)(num2 * 1019100931) ^ -1868723409;
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 184666401) ^ -714864435;
					continue;
				case 14u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 49692605) ^ -1603657798;
					continue;
				case 13u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = -1721745080;
						num6 = -1721745080;
					}
					else
					{
						num5 = -830062898;
						num6 = -830062898;
					}
					num = num5 ^ ((int)num2 * -601947009);
					continue;
				}
				case 11u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1823932203;
						num4 = 1823932203;
					}
					else
					{
						num3 = 1980927224;
						num4 = 1980927224;
					}
					num = num3 ^ ((int)num2 * -1159199055);
					continue;
				}
				case 10u:
					jSONData.AsDouble = AsDouble;
					num = -1458964866;
					continue;
				case 9u:
					num = (int)((num2 * 1176593021) ^ 0x77933E8A);
					continue;
				case 8u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -741080184) ^ -1395987421;
					continue;
				case 7u:
					num = (int)(num2 * 414220501) ^ -1452029100;
					continue;
				case 6u:
					num = ((int)num2 * -1743324404) ^ -1731779932;
					continue;
				case 5u:
					num = ((int)num2 * -1594458730) ^ 0x6833DF17;
					continue;
				case 4u:
					num = (int)((num2 * 1763483952) ^ 0x7A7EE8E4);
					continue;
				case 3u:
					num = (int)((num2 * 1966700755) ^ 0x1915C82C);
					continue;
				case 2u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -2037454126) ^ 0x4BBF5371;
					continue;
				case 1u:
					num = ((int)num2 * -1499361952) ^ -410961075;
					continue;
				default:
					return;
				case 12u:
					break;
				case 0u:
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
