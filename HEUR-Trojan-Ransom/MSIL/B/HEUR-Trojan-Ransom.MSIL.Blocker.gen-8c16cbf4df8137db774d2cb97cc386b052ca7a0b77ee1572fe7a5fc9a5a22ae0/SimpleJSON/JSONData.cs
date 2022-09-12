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
				int num = -746154314;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xB444CE7Fu) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 2u:
						break;
					default:
						return data;
					}
					break;
					IL_0009:
					num = (int)(num2 * 61901522) ^ -1207709182;
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
			int num = -80894718;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A5F0B0Fu) % 4u)
				{
				case 2u:
					m_Data = aData;
					num = ((int)num2 * -2135225056) ^ -1461811780;
					continue;
				case 1u:
					num = ((int)num2 * -805599835) ^ 0x28561D6C;
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

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 2145762598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x315DD2F1u) % 5u)
				{
				case 3u:
					num = ((int)num2 * -1146882781) ^ -841942271;
					continue;
				case 1u:
					num = ((int)num2 * -163331675) ^ -1581153908;
					continue;
				case 0u:
					AsDouble = aData;
					num = (int)(num2 * 2044595071) ^ -1607933981;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
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
			int num = 1495784262;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DB9C817u) % 4u)
				{
				case 2u:
					AsBool = aData;
					num = ((int)num2 * -599756695) ^ -74566607;
					continue;
				case 1u:
					num = ((int)num2 * -1975463736) ^ -593115195;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1631261756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0904F62u) % 4u)
				{
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -455360506) ^ -1932590453;
					continue;
				case 1u:
					num = ((int)num2 * -839971211) ^ 0x5EB8E940;
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
			int num = 1059641241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7478145Bu) % 3u)
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
				num = (int)(num2 * 407700865) ^ -1977250275;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag3 = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -317030344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80A48E04u) % 40u)
				{
				case 39u:
					num = (int)(num2 * 2004460275) ^ -952562306;
					continue;
				case 38u:
					num = ((int)num2 * -1743719740) ^ 0x4C17184E;
					continue;
				case 37u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1733488982) ^ 0x679BFC0D;
					continue;
				case 36u:
					jSONData.AsFloat = AsFloat;
					num = -1011620447;
					continue;
				case 35u:
					num = ((int)num2 * -512988952) ^ 0x3E1997FE;
					continue;
				case 34u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 542928385) ^ -1874931585;
					continue;
				case 33u:
					num = ((int)num2 * -882365769) ^ -1518978301;
					continue;
				case 32u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)((num2 * 1266286870) ^ 0x786838FD);
					continue;
				case 30u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 1591366751;
						num6 = 1591366751;
					}
					else
					{
						num5 = 1978187684;
						num6 = 1978187684;
					}
					num = num5 ^ (int)(num2 * 663874481);
					continue;
				}
				case 29u:
					JSONData.smethod_32(aWriter, (byte)7);
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 1830956197) ^ -227162487;
					continue;
				case 28u:
					jSONData = new JSONData("");
					num = ((int)num2 * -514314933) ^ -1059716177;
					continue;
				case 27u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = 1628820981;
						num10 = 1628820981;
					}
					else
					{
						num9 = 1891793220;
						num10 = 1891793220;
					}
					num = num9 ^ (int)(num2 * 1078954078);
					continue;
				}
				case 26u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -449464701) ^ 0x1C60C3B5;
					continue;
				case 25u:
					num = (int)((num2 * 1308908394) ^ 0x212D8159);
					continue;
				case 24u:
					num = (int)((num2 * 361742447) ^ 0x76ADDCE5);
					continue;
				case 23u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -859882586) ^ 0x1D1560A6;
					continue;
				case 22u:
					num = ((int)num2 * -70965378) ^ -1351165851;
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1342177516;
					continue;
				case 20u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1863870432;
						num8 = 1863870432;
					}
					else
					{
						num7 = 1601366895;
						num8 = 1601366895;
					}
					num = num7 ^ (int)(num2 * 1323751606);
					continue;
				}
				case 19u:
					jSONData.AsDouble = AsDouble;
					num = -464845155;
					continue;
				case 18u:
					jSONData.AsBool = AsBool;
					num = -1800567534;
					continue;
				case 16u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 801359562) ^ 0x1998BF47);
					continue;
				case 15u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -180602624) ^ 0x39A6686A;
					continue;
				case 14u:
					num = ((int)num2 * -155180920) ^ 0x2599F140;
					continue;
				case 13u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 827293493) ^ 0x1ABBAF83);
					continue;
				case 12u:
					num = ((int)num2 * -274809030) ^ -1421742645;
					continue;
				case 11u:
					num = (int)(num2 * 852793913) ^ -1040256500;
					continue;
				case 10u:
					num = ((int)num2 * -745842487) ^ 0x29AD3013;
					continue;
				case 9u:
					num = (int)(num2 * 938073809) ^ -1165306070;
					continue;
				case 8u:
					num = (int)((num2 * 343405330) ^ 0x1B621230);
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1533671851;
						num4 = -1533671851;
					}
					else
					{
						num3 = -1860222727;
						num4 = -1860222727;
					}
					num = num3 ^ ((int)num2 * -962120555);
					continue;
				}
				case 6u:
					num = ((int)num2 * -755122510) ^ 0x755FFAB2;
					continue;
				case 5u:
					num = ((int)num2 * -1946281944) ^ 0xAD79D8B;
					continue;
				case 4u:
					num = (int)((num2 * 704281933) ^ 0x2DE55C8D);
					continue;
				case 3u:
					num = ((int)num2 * -1004954560) ^ 0x21C21C03;
					continue;
				case 2u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1672311184) ^ -521140116;
					continue;
				case 1u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1228062340) ^ -323341232;
					continue;
				case 0u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -574453048) ^ -837607605;
					continue;
				default:
					return;
				case 17u:
					break;
				case 31u:
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
