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
				int num = -156329207;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF19E3D67u) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0009:
					num = ((int)num2 * -94258518) ^ 0x642D40B4;
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
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -789161313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF0288C5u) % 5u)
				{
				case 4u:
					AsFloat = aData;
					num = ((int)num2 * -911480383) ^ 0x7CA6C379;
					continue;
				case 2u:
					num = (int)(num2 * 1385784115) ^ -186244805;
					continue;
				case 1u:
					num = (int)((num2 * 2083320953) ^ 0x36F8FC9D);
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

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -1257591222;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC92D0C8u) % 5u)
				{
				case 2u:
					AsBool = aData;
					num = ((int)num2 * -1583698122) ^ 0x3261A529;
					continue;
				case 1u:
					num = (int)((num2 * 968858392) ^ 0x41B99F13);
					continue;
				case 0u:
					num = (int)(num2 * 1648020023) ^ -118706652;
					continue;
				default:
					return;
				case 3u:
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
		while (true)
		{
			int num = -743320860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCE41F642u) % 4u)
				{
				case 2u:
					num = (int)(num2 * 521570025) ^ -153879659;
					continue;
				case 1u:
					AsInt = aData;
					num = (int)(num2 * 206952192) ^ -1703729390;
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

	public override string ToString()
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 260494805;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C0B11AAu) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1335380812) ^ -1449890673;
					continue;
				case 1u:
					num = (int)(num2 * 468546610) ^ -568823910;
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
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1667819090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3135E0E1u) % 34u)
				{
				case 33u:
					num = (int)((num2 * 72601590) ^ 0x74E9AD2C);
					continue;
				case 32u:
					num = ((int)num2 * -303339876) ^ -1250368462;
					continue;
				case 31u:
					num = (int)((num2 * 1521794676) ^ 0x54E39E59);
					continue;
				case 30u:
					num = (int)((num2 * 391925769) ^ 0x1873019D);
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 413900521) ^ 0x7CD2B2F1);
					continue;
				case 28u:
					jSONData.AsFloat = AsFloat;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 1258047491;
					continue;
				case 27u:
					num = (int)(num2 * 1268722626) ^ -1250223205;
					continue;
				case 26u:
					num = (int)(num2 * 895501146) ^ -1849862571;
					continue;
				case 25u:
					flag4 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 22909511) ^ -507725533;
					continue;
				case 24u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1080232188) ^ -125543297;
					continue;
				case 23u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -244547173) ^ 0x676BDAAE;
					continue;
				case 22u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1295004239;
						num10 = -1295004239;
					}
					else
					{
						num9 = -478775157;
						num10 = -478775157;
					}
					num = num9 ^ ((int)num2 * -1890988891);
					continue;
				}
				case 21u:
					jSONData.AsDouble = AsDouble;
					num = 1602558689;
					continue;
				case 20u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 839051025) ^ 0x1BBF0BF0);
					continue;
				case 19u:
					num = ((int)num2 * -568538052) ^ 0x2D38A083;
					continue;
				case 18u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 509191969) ^ -1382551334;
					continue;
				case 17u:
					num = (int)(num2 * 809691601) ^ -684277613;
					continue;
				case 16u:
					num = ((int)num2 * -1769129866) ^ 0x2446AFEA;
					continue;
				case 15u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -351104008) ^ 0x6EF1C2C9;
					continue;
				case 14u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -104486218) ^ 0x5F38D286;
					continue;
				case 13u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = -2078685377;
						num8 = -2078685377;
					}
					else
					{
						num7 = -83049776;
						num8 = -83049776;
					}
					num = num7 ^ (int)(num2 * 849526850);
					continue;
				}
				case 11u:
					num = (int)((num2 * 136435859) ^ 0x45DE9415);
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 2067899596) ^ 0x5F2E43B2);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 35289756;
						num6 = 35289756;
					}
					else
					{
						num5 = 1597717288;
						num6 = 1597717288;
					}
					num = num5 ^ ((int)num2 * -1507597463);
					continue;
				}
				case 7u:
					num = (int)((num2 * 782207812) ^ 0x6AF48E2A);
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -47335551) ^ -1384415393;
					continue;
				case 5u:
					jSONData.AsBool = AsBool;
					num = 744970510;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 130214894;
						num4 = 130214894;
					}
					else
					{
						num3 = 2104360946;
						num4 = 2104360946;
					}
					num = num3 ^ (int)(num2 * 1781546168);
					continue;
				}
				case 3u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 976819977) ^ 0x6B56A2D8);
					continue;
				case 2u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -285472148) ^ 0x7DB9C0FE;
					continue;
				case 1u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1056980140) ^ -133382752;
					continue;
				case 0u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 890772153;
					continue;
				default:
					return;
				case 12u:
					break;
				case 9u:
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
