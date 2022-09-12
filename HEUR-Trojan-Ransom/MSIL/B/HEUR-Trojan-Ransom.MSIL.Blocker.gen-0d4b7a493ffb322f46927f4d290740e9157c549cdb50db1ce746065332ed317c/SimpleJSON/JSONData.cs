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
		while (true)
		{
			int num = 1622297211;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5ED5A9D5u) % 5u)
				{
				case 3u:
					m_Data = aData;
					num = ((int)num2 * -289935700) ^ -1083916322;
					continue;
				case 1u:
					num = ((int)num2 * -1989911724) ^ 0x4D9490EB;
					continue;
				case 0u:
					num = ((int)num2 * -1725704028) ^ -1848982245;
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

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -1414432525;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE836759u) % 4u)
				{
				case 3u:
					AsFloat = aData;
					num = (int)((num2 * 260609706) ^ 0x4AFBD702);
					continue;
				case 2u:
					num = ((int)num2 * -1778166551) ^ 0x5F663EF8;
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
			int num = -1467735338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA9179BFu) % 6u)
				{
				case 4u:
					num = (int)((num2 * 28384680) ^ 0x2C904C11);
					continue;
				case 2u:
					AsInt = aData;
					num = ((int)num2 * -1606219326) ^ -1066723423;
					continue;
				case 1u:
					num = (int)(num2 * 1528119963) ^ -817545946;
					continue;
				case 0u:
					num = (int)(num2 * 689809025) ^ -314042986;
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

	public override string ToString()
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 734940877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x25C2158u) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1650800399) ^ 0x1209C04D;
					continue;
				case 0u:
					num = (int)((num2 * 2124006949) ^ 0x336BEA86);
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1725277955;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5988F72u) % 33u)
				{
				case 32u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 410670118;
					continue;
				case 31u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1903767215) ^ -1008453106;
					continue;
				case 30u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 551474786;
						num6 = 551474786;
					}
					else
					{
						num5 = 1159364474;
						num6 = 1159364474;
					}
					num = num5 ^ ((int)num2 * -994441677);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1923220992) ^ 0x4A26B0A4;
					continue;
				case 27u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)((num2 * 1368444491) ^ 0x3C5C8538);
					continue;
				case 26u:
					JSONData.smethod_32(aWriter, (byte)5);
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -540527791) ^ 0x5ED2C10E;
					continue;
				case 25u:
					num = (int)(num2 * 1142928087) ^ -1913790465;
					continue;
				case 24u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -1618876014;
						num10 = -1618876014;
					}
					else
					{
						num9 = -1664637722;
						num10 = -1664637722;
					}
					num = num9 ^ ((int)num2 * -1496378297);
					continue;
				}
				case 23u:
					num = (int)(num2 * 1953459687) ^ -838600931;
					continue;
				case 22u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -940938442) ^ 0x7B514723;
					continue;
				case 21u:
					num = ((int)num2 * -1575306602) ^ -2094398154;
					continue;
				case 20u:
					num = ((int)num2 * -1369005498) ^ -1941262995;
					continue;
				case 19u:
					jSONData.AsBool = AsBool;
					num = 1865079471;
					continue;
				case 17u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1119123231) ^ 0x3A0BC194);
					continue;
				case 16u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -204909602) ^ -1461450764;
					continue;
				case 15u:
					jSONData.AsDouble = AsDouble;
					num = 685146037;
					continue;
				case 14u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -901368188) ^ 0x755A056E;
					continue;
				case 13u:
					num = (int)(num2 * 1689184873) ^ -211072969;
					continue;
				case 12u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 1670377432) ^ -1370474831;
					continue;
				case 11u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -522142629) ^ 0x6613BCA5;
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -848789933) ^ 0x175D3283;
					continue;
				case 9u:
					num = (int)(num2 * 1784024063) ^ -1992410582;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -847036095;
						num8 = -847036095;
					}
					else
					{
						num7 = -1209613244;
						num8 = -1209613244;
					}
					num = num7 ^ (int)(num2 * 2112352372);
					continue;
				}
				case 7u:
					num = ((int)num2 * -291053941) ^ -1323142750;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -47581871;
						num4 = -47581871;
					}
					else
					{
						num3 = -185540594;
						num4 = -185540594;
					}
					num = num3 ^ (int)(num2 * 1789552841);
					continue;
				}
				case 5u:
					jSONData.AsFloat = AsFloat;
					num = 1414659377;
					continue;
				case 4u:
					num = ((int)num2 * -1596408877) ^ -1026486353;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -610956442) ^ -839446897;
					continue;
				case 2u:
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 155919772) ^ 0x10E32CA3);
					continue;
				case 1u:
					num = ((int)num2 * -1454155135) ^ -1954153081;
					continue;
				case 0u:
					num = ((int)num2 * -1357562769) ^ -1711250031;
					continue;
				default:
					return;
				case 29u:
					break;
				case 18u:
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
