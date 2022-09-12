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
				int num = -1726481103;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE262C898u) % 4u)
					{
					case 1u:
						data = m_Data;
						num = (int)(num2 * 2124200954) ^ -1176968598;
						continue;
					case 0u:
						num = (int)(num2 * 1747521356) ^ -244937482;
						continue;
					case 3u:
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
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 145535642;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DEAB157u) % 4u)
				{
				case 2u:
					AsDouble = aData;
					num = (int)((num2 * 1414943700) ^ 0x5D93A99C);
					continue;
				case 1u:
					num = ((int)num2 * -149475477) ^ -784217050;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -1196078591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E08ABFEu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1884200549) ^ -373416902;
					continue;
				case 2u:
					num = (int)(num2 * 35426198) ^ -63013011;
					continue;
				case 1u:
					AsBool = aData;
					num = (int)(num2 * 655130283) ^ -1252004483;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 512840314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD992EE3u) % 3u)
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
				num = (int)(num2 * 1969041526) ^ -534956713;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 312992743;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C8EBCEEu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1138043227) ^ -1983842893;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 1857593702) ^ 0x1394C5B6);
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
		jSONData.AsInt = AsInt;
		bool flag = default(bool);
		while (true)
		{
			int num = 1341842512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x17842641u) % 29u)
				{
				case 28u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 60724998;
					continue;
				case 27u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 137718040) ^ 0x4044AD6B);
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 575358811) ^ 0x2D6DB8E4);
					continue;
				case 24u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1579658790) ^ -1120008861;
					continue;
				case 23u:
					jSONData.AsFloat = AsFloat;
					num = 1132054625;
					continue;
				case 21u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 499081169) ^ -1672350603;
					continue;
				case 20u:
					num = (int)((num2 * 1320171344) ^ 0x7F5B27A3);
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1195423959;
						num6 = 1195423959;
					}
					else
					{
						num5 = 968915771;
						num6 = 968915771;
					}
					num = num5 ^ (int)(num2 * 259217736);
					continue;
				}
				case 18u:
					num = ((int)num2 * -470823723) ^ -479589845;
					continue;
				case 17u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -538334457) ^ -1551486416;
					continue;
				case 16u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -723504577) ^ 0x141E2AD6;
					continue;
				case 15u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -460799288) ^ 0x72C61EEC;
					continue;
				case 14u:
					jSONData.AsBool = AsBool;
					num = 345805335;
					continue;
				case 13u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -607139030;
						num10 = -607139030;
					}
					else
					{
						num9 = -820293301;
						num10 = -820293301;
					}
					num = num9 ^ ((int)num2 * -474944600);
					continue;
				}
				case 12u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1979320530) ^ -292207951;
					continue;
				case 11u:
					num = (int)(num2 * 1880340380) ^ -1967288919;
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 1493184433) ^ 0x79AF0475);
					continue;
				case 9u:
					num = (int)(num2 * 867160241) ^ -736513670;
					continue;
				case 8u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -880601845;
						num8 = -880601845;
					}
					else
					{
						num7 = -982642846;
						num8 = -982642846;
					}
					num = num7 ^ (int)(num2 * 1929825192);
					continue;
				}
				case 7u:
					num = (int)(num2 * 1991688054) ^ -321578707;
					continue;
				case 6u:
					num = ((int)num2 * -1015770910) ^ 0x2DD84918;
					continue;
				case 5u:
					num = (int)(num2 * 590204126) ^ -1245236315;
					continue;
				case 4u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1534844704) ^ -2112006220;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 850875277;
						num4 = 850875277;
					}
					else
					{
						num3 = 2063509126;
						num4 = 2063509126;
					}
					num = num3 ^ (int)(num2 * 1836267581);
					continue;
				}
				case 2u:
					jSONData.AsDouble = AsDouble;
					num = 645400823;
					continue;
				case 1u:
					num = ((int)num2 * -1716962375) ^ 0x3D98A89C;
					continue;
				case 0u:
					num = ((int)num2 * -1682279832) ^ -1025410733;
					continue;
				default:
					return;
				case 22u:
					break;
				case 26u:
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
