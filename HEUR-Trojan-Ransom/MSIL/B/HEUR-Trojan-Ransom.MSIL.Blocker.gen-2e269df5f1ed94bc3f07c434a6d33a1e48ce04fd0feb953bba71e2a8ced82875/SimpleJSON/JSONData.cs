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
				int num = 407274332;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1B04F5B1u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = (int)((num2 * 339131552) ^ 0x6B563F99);
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
			int num = 944431285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E4A30F0u) % 5u)
				{
				case 4u:
					AsFloat = aData;
					num = (int)(num2 * 1958638867) ^ -551813424;
					continue;
				case 3u:
					num = (int)((num2 * 9931269) ^ 0x4DB88C5F);
					continue;
				case 1u:
					num = ((int)num2 * -1723639544) ^ -1939572964;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			int num = 1339887257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x713AC0E4u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 1153825089) ^ -460495613;
					continue;
				case 2u:
					num = (int)((num2 * 197934735) ^ 0xF90FB79);
					continue;
				case 1u:
					AsDouble = aData;
					num = ((int)num2 * -768523392) ^ 0x6200473F;
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
			int num = 969807863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1CA8B991u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					AsBool = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1200050529) ^ -1277495801;
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
			int num = 1521759356;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A2D9F70u) % 3u)
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
				num = (int)(num2 * 1727548179) ^ -1009444564;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = -1139391802;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE410C6E1u) % 3u)
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
				num = (int)((num2 * 1532308401) ^ 0x19DFB55C);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 630764711;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5132ADB2u) % 34u)
				{
				case 33u:
					jSONData.AsFloat = AsFloat;
					num = 1753875701;
					continue;
				case 32u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1379204778) ^ 0x26651E0B;
					continue;
				case 31u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 705748902) ^ 0x21FB4E3D);
					continue;
				case 30u:
					num = ((int)num2 * -321035936) ^ -563486632;
					continue;
				case 29u:
					num = ((int)num2 * -387874504) ^ 0x755AB922;
					continue;
				case 28u:
					num = (int)((num2 * 1303510298) ^ 0x104A1F79);
					continue;
				case 27u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1021887302) ^ -1947842154;
					continue;
				case 26u:
					jSONData.AsBool = AsBool;
					num = 999983586;
					continue;
				case 25u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -569134828;
						num6 = -569134828;
					}
					else
					{
						num5 = -374638372;
						num6 = -374638372;
					}
					num = num5 ^ ((int)num2 * -1186681916);
					continue;
				}
				case 24u:
					jSONData.AsDouble = AsDouble;
					num = 695082095;
					continue;
				case 23u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -1117361779;
						num10 = -1117361779;
					}
					else
					{
						num9 = -294987586;
						num10 = -294987586;
					}
					num = num9 ^ (int)(num2 * 877352803);
					continue;
				}
				case 22u:
					num = (int)((num2 * 1437450653) ^ 0x1676F63);
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 1667481475) ^ -884602161;
					continue;
				case 20u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 326288002) ^ -1693292698;
					continue;
				case 18u:
					num = ((int)num2 * -1093531200) ^ -395547235;
					continue;
				case 17u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1381049851) ^ 0x58AB5DD1;
					continue;
				case 16u:
					num = ((int)num2 * -1690789839) ^ -2000590279;
					continue;
				case 15u:
					num = (int)((num2 * 2129959439) ^ 0x7EEFAA5A);
					continue;
				case 14u:
					num = (int)(num2 * 1157956872) ^ -967926019;
					continue;
				case 13u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 508604705;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -743800654;
						num8 = -743800654;
					}
					else
					{
						num7 = -1159650927;
						num8 = -1159650927;
					}
					num = num7 ^ (int)(num2 * 309337988);
					continue;
				}
				case 11u:
					num = (int)(num2 * 880539882) ^ -1101247444;
					continue;
				case 10u:
					num = ((int)num2 * -1454472871) ^ -268062407;
					continue;
				case 9u:
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 1724763069) ^ 0x7FFF7D90);
					continue;
				case 8u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 782255712) ^ -1484911203;
					continue;
				case 7u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -700049903) ^ 0x3B6A212D;
					continue;
				case 6u:
					num = ((int)num2 * -657269416) ^ 0x39365C07;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -225522157;
						num4 = -225522157;
					}
					else
					{
						num3 = -117868489;
						num4 = -117868489;
					}
					num = num3 ^ (int)(num2 * 248140041);
					continue;
				}
				case 4u:
					num = ((int)num2 * -922901203) ^ 0x1DB5E6C1;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -91780863) ^ -2032960009;
					continue;
				case 2u:
					JSONData.smethod_32(aWriter, (byte)5);
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 1162427374) ^ 0x3F582E2D);
					continue;
				case 1u:
					num = ((int)num2 * -1603918966) ^ 0x7463B243;
					continue;
				default:
					return;
				case 0u:
					break;
				case 19u:
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
