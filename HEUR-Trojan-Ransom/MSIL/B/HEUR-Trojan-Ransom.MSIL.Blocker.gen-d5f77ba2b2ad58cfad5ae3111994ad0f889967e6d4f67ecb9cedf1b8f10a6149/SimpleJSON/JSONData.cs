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
				int num = -2006940026;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAD99687Fu) % 3u)
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
					num = (int)((num2 * 1000533421) ^ 0x4D14EDC3);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 40812877;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x30782EA1u) % 3u)
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
					num = (int)(num2 * 1590202019) ^ -2074422532;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 1094489457;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BAE4B48u) % 4u)
				{
				case 1u:
					num = (int)(num2 * 1532500428) ^ -1292374656;
					continue;
				case 0u:
					num = ((int)num2 * -1428693339) ^ -367433670;
					continue;
				case 3u:
					break;
				default:
					m_Data = aData;
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
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 113869852;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14BCE64Fu) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1885109398) ^ -1621495333;
					continue;
				case 2u:
					AsBool = aData;
					num = ((int)num2 * -1832030889) ^ 0x3B095285;
					continue;
				case 1u:
					num = ((int)num2 * -76550096) ^ -669684540;
					continue;
				case 0u:
					num = (int)(num2 * 1833700649) ^ -893442782;
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
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		jSONData.AsInt = AsInt;
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -6691370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7554223u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -284205368) ^ -1455019121;
					continue;
				case 28u:
					num = ((int)num2 * -2065471377) ^ -1344095339;
					continue;
				case 27u:
					num = ((int)num2 * -1297867917) ^ 0x3AABC177;
					continue;
				case 25u:
					jSONData.AsDouble = AsDouble;
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = -1892553805;
					continue;
				case 24u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -151371232) ^ 0xEE1AC45;
					continue;
				case 23u:
					num = ((int)num2 * -2134512485) ^ 0x150F7DB1;
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1488108898;
					continue;
				case 20u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 802693483) ^ -1993579081;
					continue;
				case 19u:
					jSONData.AsBool = AsBool;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = -589199285;
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 1743948882) ^ -1579270222;
					continue;
				case 17u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1169896134) ^ -683620333;
					continue;
				case 16u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1020374052) ^ 0x441FCD59);
					continue;
				case 15u:
					num = ((int)num2 * -2068979413) ^ -674662764;
					continue;
				case 14u:
					num = ((int)num2 * -1540493648) ^ 0x72ABA6B7;
					continue;
				case 13u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1196029583) ^ -291602352;
					continue;
				case 12u:
					num = ((int)num2 * -1646604333) ^ -1894254078;
					continue;
				case 11u:
					num = ((int)num2 * -1693993314) ^ -20493167;
					continue;
				case 10u:
					num = ((int)num2 * -1990805961) ^ -238088461;
					continue;
				case 9u:
				{
					int num8;
					int num9;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num8 = 2085424124;
						num9 = 2085424124;
					}
					else
					{
						num8 = 160480391;
						num9 = 160480391;
					}
					num = num8 ^ (int)(num2 * 1476831564);
					continue;
				}
				case 8u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = 1271288790;
						num7 = 1271288790;
					}
					else
					{
						num6 = 1486807596;
						num7 = 1486807596;
					}
					num = num6 ^ (int)(num2 * 1501338929);
					continue;
				}
				case 7u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 630585066) ^ -603213367;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -195036069) ^ -518734867;
					continue;
				case 5u:
					num = (int)(num2 * 2077459892) ^ -563305917;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = -2098691094;
						num5 = -2098691094;
					}
					else
					{
						num4 = -1147871176;
						num5 = -1147871176;
					}
					num = num4 ^ (int)(num2 * 2123974634);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1089784982) ^ 0x2DF269E5;
					continue;
				case 2u:
					num = (int)(num2 * 478851333) ^ -1100332614;
					continue;
				case 1u:
				{
					jSONData.AsFloat = AsFloat;
					int num3;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num = -562502020;
						num3 = -562502020;
					}
					else
					{
						num = -601132876;
						num3 = -601132876;
					}
					continue;
				}
				case 0u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 462408684) ^ 0x5C62A510);
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
