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
				int num = -517830753;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x80748F5Du) % 4u)
					{
					case 3u:
						num = (int)(num2 * 2123455089) ^ -365598437;
						continue;
					case 2u:
						data = m_Data;
						num = (int)((num2 * 65589991) ^ 0x7EC8B30C);
						continue;
					case 0u:
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
			int num = -1378293910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBEE8F1A4u) % 3u)
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
				num = ((int)num2 * -1309611285) ^ -2063876454;
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
			int num = 1068519794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C45C885u) % 6u)
				{
				case 4u:
					AsDouble = aData;
					num = ((int)num2 * -786736996) ^ 0x73BA8689;
					continue;
				case 3u:
					num = ((int)num2 * -2007976655) ^ 0x18B5C8D7;
					continue;
				case 2u:
					num = ((int)num2 * -1707769219) ^ 0x462E1FC1;
					continue;
				case 1u:
					num = ((int)num2 * -1621257735) ^ 0x7DA7263E;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 1551954248;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20FE18A6u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 160754400) ^ -500469941;
					continue;
				case 1u:
					AsBool = aData;
					num = ((int)num2 * -158524733) ^ 0x646E1045;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1889324513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56055E1Eu) % 3u)
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
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = (int)(num2 * 308319236) ^ -553483566;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1424185810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E5E82F5u) % 3u)
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
				num = (int)((num2 * 393567769) ^ 0xF331DEA);
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
			int num = -900144505;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF73BBAF4u) % 28u)
				{
				case 27u:
					num = (int)((num2 * 1316289933) ^ 0x2856FF79);
					continue;
				case 26u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 1479533246) ^ 0x6CC20B7);
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = -2016532483;
					continue;
				case 24u:
				{
					int num8;
					int num9;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num8 = 663331499;
						num9 = 663331499;
					}
					else
					{
						num8 = 1471894790;
						num9 = 1471894790;
					}
					num = num8 ^ (int)(num2 * 1688721793);
					continue;
				}
				case 23u:
					jSONData.AsBool = AsBool;
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = -1774142149;
					continue;
				case 22u:
				{
					jSONData.AsFloat = AsFloat;
					int num5;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num = -1691937716;
						num5 = -1691937716;
					}
					else
					{
						num = -789558492;
						num5 = -789558492;
					}
					continue;
				}
				case 21u:
					num = (int)(num2 * 1903412008) ^ -1638212525;
					continue;
				case 20u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 281978068) ^ -1635439413;
					continue;
				case 19u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 192220907) ^ -104542980;
					continue;
				case 18u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -559386541) ^ 0xA6E163C;
					continue;
				case 17u:
					num = (int)((num2 * 940157946) ^ 0x5EB8CBA4);
					continue;
				case 16u:
					num = (int)((num2 * 1590105812) ^ 0x15AC090B);
					continue;
				case 14u:
					num = ((int)num2 * -1394605856) ^ 0x25F707FB;
					continue;
				case 13u:
					num = (int)(num2 * 1283439367) ^ -73305117;
					continue;
				case 12u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1188782977) ^ -314099179;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -825904096;
						num7 = -825904096;
					}
					else
					{
						num6 = -1889847933;
						num7 = -1889847933;
					}
					num = num6 ^ (int)(num2 * 1075901719);
					continue;
				}
				case 10u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -2147275917) ^ -1647366910;
					continue;
				case 9u:
					num = ((int)num2 * -739862393) ^ -1847273404;
					continue;
				case 8u:
					jSONData.AsDouble = AsDouble;
					num = -1061643827;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 785303167;
						num4 = 785303167;
					}
					else
					{
						num3 = 2046243525;
						num4 = 2046243525;
					}
					num = num3 ^ (int)(num2 * 599477619);
					continue;
				}
				case 5u:
					num = ((int)num2 * -1500539421) ^ -1797013885;
					continue;
				case 4u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -2105774494) ^ -352748994;
					continue;
				case 3u:
					num = ((int)num2 * -1147200944) ^ -477795112;
					continue;
				case 2u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -137310331) ^ 0x36A690DB;
					continue;
				case 1u:
					num = ((int)num2 * -2073833298) ^ -688584328;
					continue;
				case 0u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 941599597) ^ 0x1F5A9DF0);
					continue;
				default:
					return;
				case 7u:
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
