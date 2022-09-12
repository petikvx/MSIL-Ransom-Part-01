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
				int num = 1573607063;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4DF31102u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = (int)((num2 * 1272653867) ^ 0x416EB53D);
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
			int num = 1712025610;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A62A795u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1774429373) ^ 0x2AF07F23;
					continue;
				case 1u:
					num = (int)((num2 * 256586908) ^ 0x5D698E8F);
					continue;
				case 0u:
					AsFloat = aData;
					num = ((int)num2 * -1846932955) ^ 0x7CAE54E4;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 558218813;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C18BB1Bu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 377381059) ^ 0x70E1A64);
					continue;
				case 1u:
					AsDouble = aData;
					num = (int)(num2 * 1667519702) ^ -441238322;
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
		AsBool = aData;
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
			int num = -941156279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAD079CD4u) % 3u)
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
				num = (int)(num2 * 872219371) ^ -87821594;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -862280603;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEA0B149u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = (int)((num2 * 656215846) ^ 0x6EDAF63);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag2 = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		while (true)
		{
			int num = -1733363277;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEC2AD468u) % 32u)
				{
				case 31u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -444869239) ^ 0x1DDDB5CA;
					continue;
				case 30u:
					num = (int)(num2 * 239765725) ^ -1304534433;
					continue;
				case 29u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1443193185) ^ 0x36B9017D;
					continue;
				case 28u:
					num = (int)(num2 * 1390982432) ^ -105958439;
					continue;
				case 27u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -2004544027) ^ -1632103729;
					continue;
				case 26u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 660300011) ^ -1922928961;
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 209015618) ^ 0x5F98274E);
					continue;
				case 24u:
				{
					int num5;
					int num6;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 1316062250;
						num6 = 1316062250;
					}
					else
					{
						num5 = 1408428674;
						num6 = 1408428674;
					}
					num = num5 ^ (int)(num2 * 132360891);
					continue;
				}
				case 23u:
					num = (int)((num2 * 880755639) ^ 0x75A5A83);
					continue;
				case 22u:
					num = (int)(num2 * 598294705) ^ -1626202976;
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1583549510;
						num10 = 1583549510;
					}
					else
					{
						num9 = 1256599107;
						num10 = 1256599107;
					}
					num = num9 ^ (int)(num2 * 313776753);
					continue;
				}
				case 20u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 1758811696) ^ -564495564;
					continue;
				case 19u:
					jSONData.AsBool = AsBool;
					num = -530830384;
					continue;
				case 18u:
					num = ((int)num2 * -6404637) ^ 0x61502BE3;
					continue;
				case 16u:
					num = ((int)num2 * -855387249) ^ -1903539831;
					continue;
				case 15u:
					num = ((int)num2 * -2085391831) ^ -1881697334;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 2033651446) ^ -300979346;
					continue;
				case 13u:
					num = (int)((num2 * 775447526) ^ 0x305520C1);
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = -2036171815;
						num8 = -2036171815;
					}
					else
					{
						num7 = -1792050829;
						num8 = -1792050829;
					}
					num = num7 ^ ((int)num2 * -364720354);
					continue;
				}
				case 11u:
					jSONData.AsFloat = AsFloat;
					num = -720049845;
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1516230295;
					continue;
				case 9u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -2052154778) ^ 0x76C19531;
					continue;
				case 8u:
					jSONData.AsDouble = AsDouble;
					num = -1321372155;
					continue;
				case 7u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1118337886) ^ -66184810;
					continue;
				case 6u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 2101396983) ^ -987368718;
					continue;
				case 5u:
					num = (int)(num2 * 1166760834) ^ -1828935469;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -2021161935;
						num4 = -2021161935;
					}
					else
					{
						num3 = -1473917106;
						num4 = -1473917106;
					}
					num = num3 ^ ((int)num2 * -236688229);
					continue;
				}
				case 2u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -437660175) ^ 0x1A95753B;
					continue;
				case 1u:
					num = ((int)num2 * -1878497588) ^ -1989615230;
					continue;
				case 0u:
					num = (int)(num2 * 784409204) ^ -651645673;
					continue;
				default:
					return;
				case 4u:
					break;
				case 17u:
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
