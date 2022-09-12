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
			while (true)
			{
				int num = -1786867059;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x895D73F1u) % 3u)
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
					num = (int)((num2 * 345557802) ^ 0x35B5B014);
				}
			}
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
			int num = 578753952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F11D6A1u) % 5u)
				{
				case 4u:
					AsDouble = aData;
					num = ((int)num2 * -1257088706) ^ -829843731;
					continue;
				case 2u:
					num = ((int)num2 * -1454976397) ^ 0x66EC206F;
					continue;
				case 1u:
					num = (int)(num2 * 475900378) ^ -516848127;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 422580322;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40211D21u) % 5u)
				{
				case 4u:
					AsBool = aData;
					num = (int)(num2 * 1479659919) ^ -2009685001;
					continue;
				case 1u:
					num = (int)((num2 * 29962632) ^ 0x34F9310A);
					continue;
				case 0u:
					num = ((int)num2 * -992780934) ^ -1463568562;
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -1854071112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB79B5F2u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 782516901) ^ 0x541BDD25);
					continue;
				case 1u:
					AsInt = aData;
					num = ((int)num2 * -1793344742) ^ 0x1B0CA72C;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -572533858;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDB8428Eu) % 3u)
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
				num = ((int)num2 * -523178526) ^ -72468176;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 2057564026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4327FE3Fu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1395089619) ^ 0x6631DB2A;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 261772717) ^ 0x37314638);
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
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -798686220;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96C3225Bu) % 34u)
				{
				case 33u:
					num = (int)((num2 * 214473390) ^ 0x30E7812C);
					continue;
				case 32u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1014552570) ^ 0x31E80CF4);
					continue;
				case 31u:
					num = (int)(num2 * 797767633) ^ -1508621632;
					continue;
				case 30u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -923137634) ^ 0x39D2FC3E;
					continue;
				case 29u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -266497499) ^ 0x1866D978;
					continue;
				case 28u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1809574338;
					continue;
				case 27u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 632038056) ^ 0x5F101DC7);
					continue;
				case 26u:
					num = (int)(num2 * 890261542) ^ -1542272082;
					continue;
				case 25u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = -7189404;
						num6 = -7189404;
					}
					else
					{
						num5 = -1314814378;
						num6 = -1314814378;
					}
					num = num5 ^ ((int)num2 * -2106845283);
					continue;
				}
				case 24u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1855983233) ^ 0x638C89E5);
					continue;
				case 23u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -411369986) ^ 0x78889E24;
					continue;
				case 22u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 527126071) ^ -1687374645;
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -304284472) ^ -2119337833;
					continue;
				case 19u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1594274554) ^ -1982540678;
					continue;
				case 18u:
					num = ((int)num2 * -1106211330) ^ 0x3AAA721B;
					continue;
				case 17u:
					jSONData.AsDouble = AsDouble;
					num = -1337948366;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 330960670;
						num10 = 330960670;
					}
					else
					{
						num9 = 641270454;
						num10 = 641270454;
					}
					num = num9 ^ ((int)num2 * -602949369);
					continue;
				}
				case 15u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -1423064411;
						num8 = -1423064411;
					}
					else
					{
						num7 = -2085796105;
						num8 = -2085796105;
					}
					num = num7 ^ (int)(num2 * 597512202);
					continue;
				}
				case 14u:
					num = ((int)num2 * -2981714) ^ 0x597E7AFE;
					continue;
				case 13u:
					jSONData.AsBool = AsBool;
					num = -997269652;
					continue;
				case 12u:
					num = (int)(num2 * 133400970) ^ -2087052353;
					continue;
				case 10u:
					num = ((int)num2 * -2082223297) ^ -595477854;
					continue;
				case 9u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -181512384) ^ -67013836;
					continue;
				case 8u:
					jSONData.AsFloat = AsFloat;
					num = -1349859359;
					continue;
				case 7u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1681694658) ^ -1800133521;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 2144053488;
						num4 = 2144053488;
					}
					else
					{
						num3 = 1433534126;
						num4 = 1433534126;
					}
					num = num3 ^ ((int)num2 * -867255072);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1957218020) ^ 0x433DC362);
					continue;
				case 4u:
					num = ((int)num2 * -877779047) ^ -1576427831;
					continue;
				case 3u:
					num = (int)(num2 * 655300109) ^ -1377510387;
					continue;
				case 2u:
					num = ((int)num2 * -28289820) ^ 0x587556E6;
					continue;
				case 1u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 400156547) ^ -258179132;
					continue;
				case 0u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -962786709) ^ -778874191;
					continue;
				default:
					return;
				case 21u:
					break;
				case 11u:
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
