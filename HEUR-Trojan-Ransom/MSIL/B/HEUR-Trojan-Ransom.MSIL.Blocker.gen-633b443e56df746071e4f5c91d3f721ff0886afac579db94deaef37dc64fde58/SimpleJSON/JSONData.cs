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
				int num = 1242739582;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE2900E3u) % 3u)
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
					num = (int)(num2 * 1032964892) ^ -9667363;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 664728261;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4D03A595u) % 3u)
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
					m_Data = value;
					num = ((int)num2 * -1444488099) ^ 0xAE995;
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
			int num = 1060060045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD90456u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1813585769) ^ -1064032331;
					continue;
				case 0u:
					AsFloat = aData;
					num = (int)(num2 * 1097404223) ^ -353415089;
					continue;
				default:
					return;
				case 2u:
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
		while (true)
		{
			int num = 1351433725;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EFD145Fu) % 4u)
				{
				case 3u:
					AsBool = aData;
					num = (int)((num2 * 378984490) ^ 0x4EBCA11C);
					continue;
				case 2u:
					num = ((int)num2 * -1356065430) ^ 0x5F1D2930;
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = 2116291699;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x561B0EFBu) % 5u)
				{
				case 2u:
					AsInt = aData;
					num = (int)(num2 * 1599251742) ^ -159803006;
					continue;
				case 1u:
					num = ((int)num2 * -1845669255) ^ -140301202;
					continue;
				case 0u:
					num = (int)((num2 * 1606773236) ^ 0x6815C3E5);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -253496434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF66B7F6Bu) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -760718168) ^ 0x44EB179F;
					continue;
				case 0u:
					num = ((int)num2 * -155169860) ^ 0x5929CA75;
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 352357104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7617BEB6u) % 3u)
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
				num = ((int)num2 * -719318809) ^ -610123715;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1474911321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECDC562u) % 34u)
				{
				case 33u:
					num = (int)(num2 * 1984782784) ^ -1521748747;
					continue;
				case 32u:
					num = (int)(num2 * 248413101) ^ -1280694716;
					continue;
				case 31u:
					jSONData = new JSONData("");
					num = (int)((num2 * 234815386) ^ 0x41E21625);
					continue;
				case 30u:
					num = (int)(num2 * 580027665) ^ -356625137;
					continue;
				case 29u:
					num = ((int)num2 * -440116683) ^ -314766197;
					continue;
				case 28u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -1087700393;
						num8 = -1087700393;
					}
					else
					{
						num7 = -1425577389;
						num8 = -1425577389;
					}
					num = num7 ^ ((int)num2 * -2054666678);
					continue;
				}
				case 27u:
					num = ((int)num2 * -783601607) ^ -1055857240;
					continue;
				case 26u:
					num = ((int)num2 * -1387099400) ^ -1233241400;
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 134102405) ^ 0x1CF342);
					continue;
				case 24u:
					num = ((int)num2 * -1699037248) ^ -159502536;
					continue;
				case 23u:
					jSONData.AsBool = AsBool;
					num = 701958513;
					continue;
				case 22u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 711951488;
						num10 = 711951488;
					}
					else
					{
						num9 = 409752785;
						num10 = 409752785;
					}
					num = num9 ^ (int)(num2 * 1443094818);
					continue;
				}
				case 21u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -128587811) ^ -1901310143;
					continue;
				case 20u:
					jSONData.AsDouble = AsDouble;
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 855882236;
					continue;
				case 19u:
					num = ((int)num2 * -87720367) ^ 0x597F3180;
					continue;
				case 18u:
					num = (int)((num2 * 948529590) ^ 0x5FE4620C);
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 2078119441;
						num6 = 2078119441;
					}
					else
					{
						num5 = 1926669624;
						num6 = 1926669624;
					}
					num = num5 ^ ((int)num2 * -1229813720);
					continue;
				}
				case 16u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -91798077) ^ -161927064;
					continue;
				case 15u:
					num = ((int)num2 * -1983973413) ^ 0x34677F4F;
					continue;
				case 14u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -964722647) ^ -2137511576;
					continue;
				case 13u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -291295593) ^ -517223793;
					continue;
				case 12u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 67798923) ^ 0x1D036A6D);
					continue;
				case 11u:
					num = ((int)num2 * -1495100035) ^ -2044872485;
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 857890723) ^ 0x11EE3151);
					continue;
				case 9u:
					jSONData.AsFloat = AsFloat;
					num = 405067551;
					continue;
				case 8u:
					num = (int)(num2 * 1840992069) ^ -2146144178;
					continue;
				case 7u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1131980748) ^ 0x3AEB17AA;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 472152169;
						num4 = 472152169;
					}
					else
					{
						num3 = 275843852;
						num4 = 275843852;
					}
					num = num3 ^ (int)(num2 * 1052319692);
					continue;
				}
				case 5u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -487285900) ^ -805780409;
					continue;
				case 3u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1740916549) ^ -628536411;
					continue;
				case 2u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 856829530;
					continue;
				case 1u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1418877164) ^ -1309458850;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
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
