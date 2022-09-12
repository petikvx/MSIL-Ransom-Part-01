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
				int num = 1216199067;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5FFDDA4u) % 4u)
					{
					case 3u:
						data = m_Data;
						num = ((int)num2 * -380431570) ^ 0x7CC3197A;
						continue;
					case 0u:
						num = (int)(num2 * 1021581777) ^ -141991331;
						continue;
					case 2u:
						break;
					default:
						return data;
					}
					break;
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
			int num = -1324300384;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDE19C51u) % 4u)
				{
				case 3u:
					m_Data = aData;
					num = (int)((num2 * 1340860984) ^ 0x1AB8DB2D);
					continue;
				case 1u:
					num = ((int)num2 * -110228592) ^ 0x290BC9A;
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

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 261123468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC5501Au) % 4u)
				{
				case 2u:
					AsDouble = aData;
					num = ((int)num2 * -470835577) ^ -357080659;
					continue;
				case 1u:
					num = (int)(num2 * 2052321634) ^ -712979452;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 748636759;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33822D1Cu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					AsBool = aData;
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -1950243256) ^ 0x786DE217;
			}
		}
	}

	public JSONData(int aData)
	{
		while (true)
		{
			int num = 1373830236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4467A801u) % 3u)
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
				AsInt = aData;
				num = ((int)num2 * -1871752292) ^ 0x39B933DF;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 264627990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EDC4307u) % 3u)
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
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = (int)((num2 * 1569220107) ^ 0x16D9E153);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1226473741;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x558BB03Au) % 3u)
				{
				case 1u:
					goto IL_001d;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_001d:
				num = ((int)num2 * -1459759605) ^ 0x27C28395;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag2 = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		while (true)
		{
			int num = 1906575318;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B8D7437u) % 35u)
				{
				case 34u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 280063098;
					continue;
				case 33u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -2091560798) ^ -653238672;
					continue;
				case 32u:
					num = ((int)num2 * -1755062447) ^ -2081254755;
					continue;
				case 31u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 2094557463) ^ 0x4F659D4F);
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = 1542076154;
						num8 = 1542076154;
					}
					else
					{
						num7 = 2134727166;
						num8 = 2134727166;
					}
					num = num7 ^ ((int)num2 * -39108315);
					continue;
				}
				case 28u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1433455293) ^ -120844060;
					continue;
				case 27u:
					num = (int)(num2 * 1957253139) ^ -943596124;
					continue;
				case 26u:
					jSONData.AsBool = AsBool;
					num = 1359152203;
					continue;
				case 25u:
					num = (int)((num2 * 1336997397) ^ 0x7938CA8B);
					continue;
				case 24u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = 697294402;
						num10 = 697294402;
					}
					else
					{
						num9 = 890159187;
						num10 = 890159187;
					}
					num = num9 ^ (int)(num2 * 802177513);
					continue;
				}
				case 22u:
					num = (int)((num2 * 1165091018) ^ 0x35DF8B49);
					continue;
				case 21u:
					num = (int)(num2 * 1893249391) ^ -1303305026;
					continue;
				case 20u:
					num = ((int)num2 * -1690104968) ^ 0x25DBC071;
					continue;
				case 19u:
					jSONData.AsDouble = AsDouble;
					num = 71854815;
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1556940792) ^ 0x69BE4BD7;
					continue;
				case 17u:
					num = (int)(num2 * 1742215825) ^ -1126612740;
					continue;
				case 16u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1583356002;
						num6 = 1583356002;
					}
					else
					{
						num5 = 158902256;
						num6 = 158902256;
					}
					num = num5 ^ ((int)num2 * -469199287);
					continue;
				}
				case 15u:
					jSONData = new JSONData("");
					num = ((int)num2 * -292293735) ^ 0x5BAEF814;
					continue;
				case 14u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)((num2 * 324958780) ^ 0x154B83BF);
					continue;
				case 13u:
					num = ((int)num2 * -127262438) ^ 0x4CC8B3F3;
					continue;
				case 12u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -382959466) ^ -667547318;
					continue;
				case 11u:
					num = (int)((num2 * 2078783560) ^ 0x6A5F27F3);
					continue;
				case 10u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1901876345) ^ -2067434659;
					continue;
				case 9u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -738423307) ^ 0x5553CB0A;
					continue;
				case 8u:
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 1302951541) ^ 0x55697C71);
					continue;
				case 7u:
					num = (int)((num2 * 1958032159) ^ 0x63C05B94);
					continue;
				case 6u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1078308104) ^ 0x5A542D3F;
					continue;
				case 5u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 788595284) ^ -1628736639;
					continue;
				case 4u:
					num = (int)((num2 * 554743116) ^ 0x14A2EA9B);
					continue;
				case 3u:
					jSONData.AsFloat = AsFloat;
					num = 891761306;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 6614808;
						num4 = 6614808;
					}
					else
					{
						num3 = 745385061;
						num4 = 745385061;
					}
					num = num3 ^ (int)(num2 * 899914082);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1703102858) ^ -1655002484;
					continue;
				case 0u:
					num = ((int)num2 * -1870317473) ^ 0x504F6A43;
					continue;
				default:
					return;
				case 29u:
					break;
				case 23u:
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
