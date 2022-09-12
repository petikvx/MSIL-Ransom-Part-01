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
				int num = 913587665;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4E9B91C0u) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = (int)(num2 * 598936796) ^ -1014765094;
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
			int num = -2109454709;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6E683CCu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					m_Data = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 1453836700) ^ 0x5AEA8003);
			}
		}
	}

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -1178694453;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8030A27Eu) % 4u)
				{
				case 3u:
					AsBool = aData;
					num = (int)((num2 * 55662985) ^ 0x4BF5CA11);
					continue;
				case 1u:
					num = (int)(num2 * 584604835) ^ -1243299126;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1493692468;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4055D75Au) % 3u)
				{
				case 1u:
					goto IL_001d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_001d:
				num = (int)((num2 * 2061623997) ^ 0x14368725);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1317924875;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B8D5626u) % 36u)
				{
				case 35u:
					num = (int)(num2 * 1159253178) ^ -1124088705;
					continue;
				case 34u:
					num = ((int)num2 * -516277063) ^ 0x2990E9D4;
					continue;
				case 33u:
					jSONData.AsBool = AsBool;
					num = 397679308;
					continue;
				case 32u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1243049968) ^ 0x4DB727FB;
					continue;
				case 31u:
					num = (int)(num2 * 754909445) ^ -1802455608;
					continue;
				case 30u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1701097574) ^ -908330308;
					continue;
				case 28u:
					num = ((int)num2 * -2084168076) ^ 0x24BB7A77;
					continue;
				case 27u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1162269237) ^ 0x10A58A6);
					continue;
				case 26u:
					num = ((int)num2 * -1632393622) ^ 0x20C6FDF2;
					continue;
				case 25u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = -1032751133;
						num10 = -1032751133;
					}
					else
					{
						num9 = -1544524606;
						num10 = -1544524606;
					}
					num = num9 ^ ((int)num2 * -553777578);
					continue;
				}
				case 24u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 328205484) ^ 0x3B0B2A56);
					continue;
				case 23u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 769050440) ^ 0x6188B26);
					continue;
				case 22u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -2121566298) ^ -168618629;
					continue;
				case 21u:
					num = (int)(num2 * 508467704) ^ -1281960775;
					continue;
				case 20u:
					jSONData.AsFloat = AsFloat;
					num = 1496469485;
					continue;
				case 19u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)((num2 * 1358978716) ^ 0x2D9D89A0);
					continue;
				case 18u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -584529811) ^ 0x1D4D8AC8;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 450639522;
						num8 = 450639522;
					}
					else
					{
						num7 = 1113840442;
						num8 = 1113840442;
					}
					num = num7 ^ ((int)num2 * -1283684327);
					continue;
				}
				case 16u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -218221468) ^ 0x3252EBF7;
					continue;
				case 15u:
					num = (int)((num2 * 1184320501) ^ 0x44A15F68);
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 676929083) ^ 0x33161D7C);
					continue;
				case 13u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -1477710285;
						num6 = -1477710285;
					}
					else
					{
						num5 = -1355763855;
						num6 = -1355763855;
					}
					num = num5 ^ ((int)num2 * -808047897);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1247894738) ^ 0x3B15339C;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1482221926;
						num4 = -1482221926;
					}
					else
					{
						num3 = -929910638;
						num4 = -929910638;
					}
					num = num3 ^ ((int)num2 * -1155048006);
					continue;
				}
				case 10u:
					jSONData.AsDouble = AsDouble;
					num = 1695221677;
					continue;
				case 9u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 636947140) ^ 0x5D475906);
					continue;
				case 8u:
					num = ((int)num2 * -2066293244) ^ 0x49413F5;
					continue;
				case 7u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 720494188) ^ -1612966145;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1567320112;
					continue;
				case 4u:
					num = (int)(num2 * 1639698435) ^ -1808546041;
					continue;
				case 3u:
					num = ((int)num2 * -1501283986) ^ -351289947;
					continue;
				case 2u:
					num = (int)((num2 * 2110063314) ^ 0x4DEDB8F5);
					continue;
				case 1u:
					num = (int)(num2 * 72407478) ^ -431237496;
					continue;
				case 0u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 842393814) ^ 0x60D85E5);
					continue;
				default:
					return;
				case 5u:
					break;
				case 29u:
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
