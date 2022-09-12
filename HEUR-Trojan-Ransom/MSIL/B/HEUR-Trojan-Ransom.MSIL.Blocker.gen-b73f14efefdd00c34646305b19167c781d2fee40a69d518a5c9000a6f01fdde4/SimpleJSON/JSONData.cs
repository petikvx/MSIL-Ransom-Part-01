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
				int num = -2038451727;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC71596DEu) % 4u)
					{
					case 3u:
						data = m_Data;
						num = ((int)num2 * -202156399) ^ 0x1B5AFA40;
						continue;
					case 1u:
						num = ((int)num2 * -651324335) ^ -607889719;
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
			while (true)
			{
				int num = 590936525;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2F4CF476u) % 3u)
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
					num = (int)((num2 * 1507882261) ^ 0x42123842);
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 1344338335;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1196637Eu) % 5u)
				{
				case 4u:
					m_Data = aData;
					num = ((int)num2 * -1334868414) ^ -538661541;
					continue;
				case 2u:
					num = (int)(num2 * 278151579) ^ -1579812136;
					continue;
				case 1u:
					num = (int)(num2 * 1591099977) ^ -1723358718;
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

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -1905078715;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B4112BEu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1072959786) ^ 0x29F776EE);
					continue;
				case 2u:
					num = ((int)num2 * -530785599) ^ -904096847;
					continue;
				case 0u:
					break;
				default:
					AsFloat = aData;
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
			int num = 1144671374;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11FB8AD7u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -1381672156) ^ -711731289;
					continue;
				case 0u:
					AsDouble = aData;
					num = ((int)num2 * -581247840) ^ -1552538396;
					continue;
				default:
					return;
				case 2u:
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
		while (true)
		{
			int num = 338597563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EF32632u) % 4u)
				{
				case 1u:
					num = (int)((num2 * 1971361080) ^ 0x6A1193EE);
					continue;
				case 0u:
					AsInt = aData;
					num = (int)((num2 * 177907578) ^ 0x42F12B8C);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
			int num = -59013108;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3770951u) % 3u)
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
				num = (int)(num2 * 1266052919) ^ -1981311700;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -489519857;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8EF1999u) % 3u)
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
				num = ((int)num2 * -70148202) ^ -1714954666;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		jSONData.AsInt = AsInt;
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 47660794;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19DC6C1Du) % 31u)
				{
				case 30u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 2011108865) ^ 0x6ED78278);
					continue;
				case 29u:
					num = (int)(num2 * 385725061) ^ -108925759;
					continue;
				case 28u:
					num = (int)(num2 * 863513646) ^ -548102474;
					continue;
				case 27u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1606392438) ^ 0x6D51482C);
					continue;
				case 26u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1336289198) ^ 0x18623306);
					continue;
				case 25u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -1682880807;
						num8 = -1682880807;
					}
					else
					{
						num7 = -1513711814;
						num8 = -1513711814;
					}
					num = num7 ^ (int)(num2 * 1996441559);
					continue;
				}
				case 24u:
					num = ((int)num2 * -1670449131) ^ 0x60F44F48;
					continue;
				case 22u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 1976898080) ^ -2095549215;
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1574084217) ^ -1441490792;
					continue;
				case 20u:
					num = (int)((num2 * 1982994929) ^ 0x5CBBD4CB);
					continue;
				case 19u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1737207955) ^ 0x539FAB1E;
					continue;
				case 18u:
					num = ((int)num2 * -669604202) ^ -1104361402;
					continue;
				case 17u:
					jSONData.AsBool = AsBool;
					num = 557596129;
					continue;
				case 16u:
					jSONData.AsDouble = AsDouble;
					num = 46463564;
					continue;
				case 15u:
					num = ((int)num2 * -1330232468) ^ 0x3D33BC23;
					continue;
				case 14u:
					jSONData.AsFloat = AsFloat;
					num = 1984177408;
					continue;
				case 13u:
					num = ((int)num2 * -1723168646) ^ 0x62D700FD;
					continue;
				case 12u:
					num = (int)((num2 * 1413118033) ^ 0x31646C03);
					continue;
				case 11u:
					num = (int)(num2 * 1133013516) ^ -1878444867;
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = 544559557;
					continue;
				case 9u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 205493104) ^ -785110985;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = 629642761;
						num10 = 629642761;
					}
					else
					{
						num9 = 105584983;
						num10 = 105584983;
					}
					num = num9 ^ (int)(num2 * 1911447988);
					continue;
				}
				case 7u:
					num = ((int)num2 * -1439680524) ^ 0x7F088D70;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 672890696;
						num6 = 672890696;
					}
					else
					{
						num5 = 1778375694;
						num6 = 1778375694;
					}
					num = num5 ^ (int)(num2 * 2019606963);
					continue;
				}
				case 4u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -714227115) ^ 0x1FEB56A3;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag2)
					{
						num3 = -96266704;
						num4 = -96266704;
					}
					else
					{
						num3 = -1510861343;
						num4 = -1510861343;
					}
					num = num3 ^ (int)(num2 * 2134119770);
					continue;
				}
				case 2u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1543912295) ^ -1654523919;
					continue;
				case 1u:
					num = ((int)num2 * -877820256) ^ -1874490876;
					continue;
				case 0u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1005455641) ^ -1726844731;
					continue;
				default:
					return;
				case 23u:
					break;
				case 5u:
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
