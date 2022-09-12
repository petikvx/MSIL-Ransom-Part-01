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
				int num = -840623573;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDF3A4102u) % 4u)
					{
					case 1u:
						data = m_Data;
						num = ((int)num2 * -1017748954) ^ -245655944;
						continue;
					case 0u:
						num = (int)((num2 * 695338701) ^ 0x616B0D3C);
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
		while (true)
		{
			int num = 1940779399;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x720B950u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1470727751) ^ -1778122349;
					continue;
				case 0u:
					AsFloat = aData;
					num = (int)(num2 * 933749967) ^ -1855891839;
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
		while (true)
		{
			int num = -964813192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94D8BEDDu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -596780709) ^ -308326340;
					continue;
				case 1u:
					AsDouble = aData;
					num = ((int)num2 * -1614271807) ^ 0x340EFB6;
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
			int num = -1348950625;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEF52E46u) % 5u)
				{
				case 2u:
					AsBool = aData;
					num = (int)(num2 * 2074194731) ^ -1284671133;
					continue;
				case 1u:
					num = ((int)num2 * -711027512) ^ 0x2772F85D;
					continue;
				case 0u:
					num = ((int)num2 * -1205014840) ^ 0x11C8134D;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -94766442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99EAA7B1u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -161069796) ^ 0x779091AB;
					continue;
				case 2u:
					num = ((int)num2 * -990697759) ^ -884976318;
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
			int num = 1521376427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x364A059u) % 4u)
				{
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 523496373) ^ -1379697998;
					continue;
				case 1u:
					num = (int)(num2 * 992662774) ^ -843196632;
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
		bool flag = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -548910329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA12577Fu) % 29u)
				{
				case 28u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1964348533;
						num10 = 1964348533;
					}
					else
					{
						num9 = 701849748;
						num10 = 701849748;
					}
					num = num9 ^ (int)(num2 * 388553395);
					continue;
				}
				case 27u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -384443395) ^ -513537395;
					continue;
				case 26u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = -1220753213;
					continue;
				case 25u:
				{
					int num5;
					int num6;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = -238364152;
						num6 = -238364152;
					}
					else
					{
						num5 = -574892223;
						num6 = -574892223;
					}
					num = num5 ^ ((int)num2 * -1307043286);
					continue;
				}
				case 24u:
					jSONData.AsDouble = AsDouble;
					num = -444517935;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1287708602) ^ 0x46442F8F;
					continue;
				case 22u:
					num = (int)((num2 * 1294930850) ^ 0x3C3B80F4);
					continue;
				case 20u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1747853637) ^ -84519904;
					continue;
				case 19u:
					num = (int)(num2 * 1153669593) ^ -1969736282;
					continue;
				case 18u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -254655040;
						num8 = -254655040;
					}
					else
					{
						num7 = -2005428059;
						num8 = -2005428059;
					}
					num = num7 ^ (int)(num2 * 287342518);
					continue;
				}
				case 17u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -44062154) ^ 0x1B10D64E;
					continue;
				case 16u:
					num = (int)((num2 * 1984221586) ^ 0x53A208AF);
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)7);
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1599944273) ^ -113214235;
					continue;
				case 14u:
					num = ((int)num2 * -439548883) ^ 0x2D2A33CE;
					continue;
				case 13u:
					num = (int)(num2 * 513514333) ^ -2065993244;
					continue;
				case 12u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1854895980) ^ 0x349DC354;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 1861485164;
						num4 = 1861485164;
					}
					else
					{
						num3 = 1079889990;
						num4 = 1079889990;
					}
					num = num3 ^ (int)(num2 * 1274708261);
					continue;
				}
				case 10u:
					jSONData.AsFloat = AsFloat;
					num = -865606290;
					continue;
				case 9u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 829868467) ^ 0x79EF4058);
					continue;
				case 8u:
					jSONData.AsBool = AsBool;
					num = -166334041;
					continue;
				case 7u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 772788818) ^ -1810264434;
					continue;
				case 6u:
					num = (int)(num2 * 306772964) ^ -51318481;
					continue;
				case 4u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -630916604) ^ 0x7182158D;
					continue;
				case 3u:
					num = (int)((num2 * 1377187068) ^ 0x2CFDE7F0);
					continue;
				case 2u:
					num = (int)((num2 * 1076536897) ^ 0x1FDE94A5);
					continue;
				case 1u:
					num = (int)(num2 * 735114911) ^ -1095038905;
					continue;
				case 0u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -453726143) ^ -1355478735;
					continue;
				default:
					return;
				case 5u:
					break;
				case 21u:
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
