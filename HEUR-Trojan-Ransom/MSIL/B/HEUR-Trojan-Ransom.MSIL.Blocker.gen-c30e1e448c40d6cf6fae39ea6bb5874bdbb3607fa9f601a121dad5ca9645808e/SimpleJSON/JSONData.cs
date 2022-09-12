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
				int num = 1233929218;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x157A0940u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = ((int)num2 * -208948321) ^ -128921642;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 999141101;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x29E42FC3u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					m_Data = value;
					num = (int)(num2 * 1924663300) ^ -1891863872;
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
		while (true)
		{
			int num = 1076930553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17AF823Au) % 6u)
				{
				case 3u:
					AsFloat = aData;
					num = ((int)num2 * -183892302) ^ 0x5078ABB8;
					continue;
				case 2u:
					num = (int)((num2 * 1845548233) ^ 0x68169757);
					continue;
				case 1u:
					num = ((int)num2 * -1592644615) ^ 0xE8D8141;
					continue;
				case 0u:
					num = (int)((num2 * 2014491325) ^ 0x48BD785E);
					continue;
				default:
					return;
				case 5u:
					break;
				case 4u:
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
			int num = -713719252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8253C37u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 254070944) ^ -1471985543;
					continue;
				case 2u:
					AsDouble = aData;
					num = (int)((num2 * 125415769) ^ 0x74DDB2E0);
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 1141027367;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D11CC2Fu) % 5u)
				{
				case 3u:
					num = (int)((num2 * 1132701340) ^ 0x637968FD);
					continue;
				case 1u:
					AsBool = aData;
					num = (int)((num2 * 599109959) ^ 0x19D40A3D);
					continue;
				case 0u:
					num = (int)((num2 * 1752576992) ^ 0x480E059D);
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
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
			int num = -1474047992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF33FD7B7u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 938245638) ^ -275378473;
					continue;
				case 2u:
					num = ((int)num2 * -771319342) ^ -733473510;
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
			int num = -1235004873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80A6EE8Au) % 3u)
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
				num = (int)((num2 * 1419647414) ^ 0x1870DDB6);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		while (true)
		{
			int num = 1114991673;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x488A4332u) % 35u)
				{
				case 34u:
					num = ((int)num2 * -1829980465) ^ -964832976;
					continue;
				case 33u:
					jSONData = new JSONData("");
					num = ((int)num2 * -2042594649) ^ 0x958CEBB;
					continue;
				case 32u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1444696135) ^ -2044484884;
					continue;
				case 31u:
					num = (int)((num2 * 552864842) ^ 0x38F2CBA0);
					continue;
				case 29u:
					num = ((int)num2 * -1632449211) ^ 0x7DE3A249;
					continue;
				case 28u:
					num = ((int)num2 * -1377443907) ^ 0xF792E37;
					continue;
				case 27u:
					num = ((int)num2 * -369745915) ^ 0xEA60629;
					continue;
				case 26u:
					num = ((int)num2 * -413327969) ^ -1144216837;
					continue;
				case 25u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1843564990) ^ 0x61B8D55D;
					continue;
				case 24u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)((num2 * 1306563494) ^ 0x669B6591);
					continue;
				case 23u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -459133395) ^ 0x75FC88AB;
					continue;
				case 22u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1366990596) ^ -2032126297;
					continue;
				case 21u:
					jSONData.AsDouble = AsDouble;
					num = 1843901689;
					continue;
				case 20u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -680873941) ^ -1139979949;
					continue;
				case 19u:
					num = (int)(num2 * 50815011) ^ -2027395204;
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1682390901) ^ -1713942554;
					continue;
				case 17u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 1975163609) ^ -1797646105;
					continue;
				case 16u:
					jSONData.AsBool = AsBool;
					num = 1423022382;
					continue;
				case 15u:
					num = ((int)num2 * -128073577) ^ 0x3FDF6864;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1362840418;
					continue;
				case 12u:
				{
					jSONData.AsInt = AsInt;
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -1590012616;
						num10 = -1590012616;
					}
					else
					{
						num9 = -226538029;
						num10 = -226538029;
					}
					num = num9 ^ (int)(num2 * 2053611530);
					continue;
				}
				case 11u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1973807323;
						num8 = 1973807323;
					}
					else
					{
						num7 = 26029854;
						num8 = 26029854;
					}
					num = num7 ^ ((int)num2 * -1854860833);
					continue;
				}
				case 10u:
					num = (int)((num2 * 1041370107) ^ 0xD30C4CF);
					continue;
				case 9u:
					num = (int)((num2 * 1082492334) ^ 0x6830CACA);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 801588300;
						num6 = 801588300;
					}
					else
					{
						num5 = 135302432;
						num6 = 135302432;
					}
					num = num5 ^ ((int)num2 * -1735440020);
					continue;
				}
				case 7u:
					num = (int)((num2 * 2045960185) ^ 0x5D3CFE74);
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -1621291394;
						num4 = -1621291394;
					}
					else
					{
						num3 = -1709080592;
						num4 = -1709080592;
					}
					num = num3 ^ (int)(num2 * 852266659);
					continue;
				}
				case 5u:
					num = (int)((num2 * 914464208) ^ 0x425B9E8E);
					continue;
				case 4u:
					num = (int)(num2 * 1265984699) ^ -1444743378;
					continue;
				case 3u:
					jSONData.AsFloat = AsFloat;
					num = 172286732;
					continue;
				case 2u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1551367916) ^ 0x3A63CD1;
					continue;
				case 1u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 927632806) ^ -504865383;
					continue;
				case 0u:
					num = ((int)num2 * -487539675) ^ 0x3D9C7CA3;
					continue;
				default:
					return;
				case 13u:
					break;
				case 30u:
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
