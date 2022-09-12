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
				int num = -1722116170;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x82B36897u) % 3u)
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
					num = ((int)num2 * -1209871426) ^ -1198104362;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 859528895;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x49F652Au) % 3u)
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
					num = ((int)num2 * -1693327706) ^ -1923991870;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = -2134934249;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD147B806u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 491163431) ^ -1566598589;
					continue;
				case 1u:
					num = ((int)num2 * -991703249) ^ 0xB62D0E6;
					continue;
				case 2u:
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
		AsBool = aData;
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
			int num = 425910866;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E65B6Du) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -744687289) ^ 0x2D4F1884;
					continue;
				case 0u:
					num = (int)((num2 * 1602098514) ^ 0x73DE0AB8);
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
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1723085272;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7C6F78E5u) % 3u)
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
				num = (int)(num2 * 645014237) ^ -1212378575;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 568195069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0B6494u) % 36u)
				{
				case 34u:
					num = (int)(num2 * 1949134909) ^ -138301009;
					continue;
				case 33u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -1686704962;
						num10 = -1686704962;
					}
					else
					{
						num9 = -342697025;
						num10 = -342697025;
					}
					num = num9 ^ (int)(num2 * 421829545);
					continue;
				}
				case 32u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 993745818) ^ -581953663;
					continue;
				case 31u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1807287452) ^ 0x29279E5A;
					continue;
				case 30u:
					num = ((int)num2 * -473245989) ^ -1300226906;
					continue;
				case 29u:
					num = (int)(num2 * 1466676760) ^ -1288526751;
					continue;
				case 28u:
					num = (int)((num2 * 54926391) ^ 0x666E0533);
					continue;
				case 27u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1351990172) ^ 0x45085D8);
					continue;
				case 26u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -345746727;
						num8 = -345746727;
					}
					else
					{
						num7 = -593187599;
						num8 = -593187599;
					}
					num = num7 ^ ((int)num2 * -1117575350);
					continue;
				}
				case 25u:
					num = ((int)num2 * -1547045502) ^ -954183647;
					continue;
				case 24u:
					num = (int)((num2 * 442188128) ^ 0x614D06F0);
					continue;
				case 23u:
					jSONData.AsFloat = AsFloat;
					num = 735332795;
					continue;
				case 22u:
					num = (int)((num2 * 118610132) ^ 0x2ADE06EE);
					continue;
				case 21u:
					num = ((int)num2 * -490663024) ^ 0x217816B2;
					continue;
				case 20u:
				{
					int num5;
					int num6;
					if (!flag3)
					{
						num5 = 1429264327;
						num6 = 1429264327;
					}
					else
					{
						num5 = 1447826530;
						num6 = 1447826530;
					}
					num = num5 ^ (int)(num2 * 1203864407);
					continue;
				}
				case 19u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1586951957) ^ 0x2CC60F96;
					continue;
				case 18u:
					num = (int)(num2 * 1990137123) ^ -530120242;
					continue;
				case 17u:
					jSONData.AsBool = AsBool;
					num = 1508018538;
					continue;
				case 16u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -988296486) ^ -418477441;
					continue;
				case 15u:
					jSONData.AsDouble = AsDouble;
					num = 122692396;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1033104101) ^ 0x500A95B1;
					continue;
				case 13u:
				{
					jSONData.AsInt = AsInt;
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -1890931492;
						num4 = -1890931492;
					}
					else
					{
						num3 = -758926829;
						num4 = -758926829;
					}
					num = num3 ^ ((int)num2 * -1352557253);
					continue;
				}
				case 11u:
					num = ((int)num2 * -2145470613) ^ -1083710163;
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -848131440) ^ -868234998;
					continue;
				case 9u:
					num = ((int)num2 * -1864795816) ^ 0x8B278C7;
					continue;
				case 8u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 1604257147) ^ 0x71237F05);
					continue;
				case 7u:
					num = ((int)num2 * -1888863045) ^ 0x2CFCFC7E;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1163703598;
					continue;
				case 5u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1695646705) ^ -102769853;
					continue;
				case 4u:
					num = ((int)num2 * -1079373327) ^ 0x76FAB18B;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1421286311) ^ 0x17E15F7A;
					continue;
				case 2u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -46612308) ^ 0x58F6E499;
					continue;
				case 1u:
					num = (int)(num2 * 62109386) ^ -1272017611;
					continue;
				case 0u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -513739835) ^ -1697613722;
					continue;
				default:
					return;
				case 12u:
					break;
				case 35u:
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
