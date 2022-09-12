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
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -1657692237;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC5EA844u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					AsFloat = aData;
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -550546269) ^ 0x5E53A6FB;
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
			int num = 99850494;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D160170u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -422207496) ^ -1625352058;
					continue;
				case 2u:
					num = ((int)num2 * -2047404713) ^ -607840918;
					continue;
				case 0u:
					AsInt = aData;
					num = ((int)num2 * -574908440) ^ 0x3842CA87;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
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
			int num = -299735274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9648636Bu) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1527127937) ^ 0x70E5C0D8;
					continue;
				case 0u:
					num = (int)(num2 * 510427874) ^ -1361070728;
					continue;
				case 2u:
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
			int num = 1313170276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EF8E501u) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 333776076) ^ 0x641188C9);
					continue;
				case 0u:
					num = ((int)num2 * -152401731) ^ 0x42E0C403;
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
		bool flag = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -662179135;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECD3C0B3u) % 38u)
				{
				case 37u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1149438832) ^ 0x46C3339B);
					continue;
				case 36u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1981407811) ^ 0x433880E6;
					continue;
				case 35u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1110975722) ^ -1082633156;
					continue;
				case 34u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -175042347) ^ -1083321543;
					continue;
				case 33u:
					num = (int)((num2 * 1126574827) ^ 0x2DA9F55E);
					continue;
				case 32u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 994261757) ^ 0x17E2636A);
					continue;
				case 31u:
					num = (int)((num2 * 295277326) ^ 0x12369FCA);
					continue;
				case 30u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1225646456) ^ 0x747BBD4A;
					continue;
				case 29u:
					num = ((int)num2 * -1447674604) ^ 0x37AC34EF;
					continue;
				case 28u:
					num = ((int)num2 * -44577319) ^ 0x6734D18E;
					continue;
				case 27u:
					num = ((int)num2 * -1812034358) ^ -804807346;
					continue;
				case 26u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 530291965) ^ -1875630569;
					continue;
				case 25u:
					jSONData.AsBool = AsBool;
					num = -412384578;
					continue;
				case 24u:
					num = (int)(num2 * 1154641319) ^ -1895139345;
					continue;
				case 23u:
					num = ((int)num2 * -578304453) ^ -1178245485;
					continue;
				case 22u:
					num = (int)((num2 * 850079190) ^ 0x64BC7F57);
					continue;
				case 21u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1126791715) ^ 0x746108AF;
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 36592909) ^ 0x4083EE73);
					continue;
				case 19u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -982437201;
						num10 = -982437201;
					}
					else
					{
						num9 = -1375524937;
						num10 = -1375524937;
					}
					num = num9 ^ ((int)num2 * -841862770);
					continue;
				}
				case 18u:
					jSONData = new JSONData("");
					num = ((int)num2 * -269978032) ^ -1554407168;
					continue;
				case 17u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1741197489;
						num8 = -1741197489;
					}
					else
					{
						num7 = -2026157111;
						num8 = -2026157111;
					}
					num = num7 ^ (int)(num2 * 509888899);
					continue;
				}
				case 15u:
				{
					int num5;
					int num6;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 1394157466;
						num6 = 1394157466;
					}
					else
					{
						num5 = 113916367;
						num6 = 113916367;
					}
					num = num5 ^ ((int)num2 * -240995857);
					continue;
				}
				case 14u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1602910315;
					continue;
				case 13u:
					num = ((int)num2 * -1586490636) ^ 0x5CBDBCDB;
					continue;
				case 12u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -951541090) ^ 0x3A58C4E6;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1974001905;
						num4 = -1974001905;
					}
					else
					{
						num3 = -1778547823;
						num4 = -1778547823;
					}
					num = num3 ^ (int)(num2 * 1631192829);
					continue;
				}
				case 9u:
					jSONData.AsFloat = AsFloat;
					num = -489394393;
					continue;
				case 8u:
					jSONData.AsDouble = AsDouble;
					num = -748166949;
					continue;
				case 7u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1697295932) ^ -580326867;
					continue;
				case 6u:
					num = ((int)num2 * -885018802) ^ 0x5F56086B;
					continue;
				case 5u:
					num = ((int)num2 * -1592624198) ^ -2128539271;
					continue;
				case 4u:
					num = ((int)num2 * -2053542426) ^ -1573574355;
					continue;
				case 3u:
					num = ((int)num2 * -22885978) ^ -1956083699;
					continue;
				case 2u:
					num = (int)((num2 * 860693881) ^ 0x3A19E39);
					continue;
				case 1u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1563267207) ^ -2024169845;
					continue;
				case 0u:
					num = (int)(num2 * 1400723055) ^ -1022485046;
					continue;
				default:
					return;
				case 10u:
					break;
				case 16u:
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
