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
				int num = -1643760981;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC3306D0Au) % 3u)
					{
					case 1u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0009:
					num = (int)(num2 * 1534651236) ^ -1436652650;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -630430707;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92FBF1E3u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					m_Data = value;
					num = (int)(num2 * 624070639) ^ -1888009190;
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
		while (true)
		{
			int num = 498389492;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x207BF626u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1108934701) ^ 0x1F0A0691;
					continue;
				case 1u:
					AsFloat = aData;
					num = ((int)num2 * -260985019) ^ -1180099364;
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

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 1789553153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF319C43u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1805040816) ^ -742994670;
					continue;
				case 1u:
					AsBool = aData;
					num = ((int)num2 * -1200998538) ^ 0x1CE010D2;
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -2022488183;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE8F15E60u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -768779507) ^ 0x2CECE422;
					continue;
				case 3u:
					num = ((int)num2 * -1433743486) ^ -878501974;
					continue;
				case 0u:
					AsInt = aData;
					num = (int)((num2 * 133184843) ^ 0x634243B0);
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

	public override string ToString()
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 916178512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x683E2CA3u) % 3u)
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
				num = (int)(num2 * 1873142327) ^ -317544542;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 169664004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x186C2341u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -554371550) ^ -295057787;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -699489891) ^ 0x14271762;
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
		JSONData jSONData = new JSONData("");
		jSONData.AsInt = AsInt;
		bool flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1472776628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED5FA3E1u) % 27u)
				{
				case 26u:
					num = ((int)num2 * -943462936) ^ -1376388336;
					continue;
				case 25u:
					jSONData.AsDouble = AsDouble;
					num = -533100794;
					continue;
				case 24u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -589054091) ^ -525508877;
					continue;
				case 23u:
					num = (int)(num2 * 787132826) ^ -492570473;
					continue;
				case 22u:
					num = ((int)num2 * -1405051014) ^ -1782255175;
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1530994660) ^ -1789630717;
					continue;
				case 19u:
					jSONData.AsBool = AsBool;
					num = -1778774242;
					continue;
				case 18u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 18198463;
						num6 = 18198463;
					}
					else
					{
						num5 = 1694595934;
						num6 = 1694595934;
					}
					num = num5 ^ (int)(num2 * 1342095587);
					continue;
				}
				case 17u:
					num = ((int)num2 * -442613119) ^ -237542127;
					continue;
				case 16u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -2056772924;
						num10 = -2056772924;
					}
					else
					{
						num9 = -1425767739;
						num10 = -1425767739;
					}
					num = num9 ^ ((int)num2 * -1143439104);
					continue;
				}
				case 15u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1348590970) ^ -215237105;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1267387422) ^ 0x467CF9F4;
					continue;
				case 13u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1176365977) ^ 0x167E7077);
					continue;
				case 12u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1455276128) ^ 0x5B907CD3;
					continue;
				case 11u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 1796891143) ^ -1627611375;
					continue;
				case 10u:
					jSONData.AsFloat = AsFloat;
					num = -1240226990;
					continue;
				case 9u:
					num = ((int)num2 * -1948087532) ^ -1253816686;
					continue;
				case 8u:
					num = ((int)num2 * -894614739) ^ 0xC2E7452;
					continue;
				case 7u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1709643468) ^ 0x508E62AA;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1859955710;
					continue;
				case 5u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 767743297) ^ -878357600;
					continue;
				case 4u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -1351305110;
						num8 = -1351305110;
					}
					else
					{
						num7 = -2093203340;
						num8 = -2093203340;
					}
					num = num7 ^ ((int)num2 * -1676618738);
					continue;
				}
				case 3u:
					num = (int)((num2 * 1309966513) ^ 0x26B2720);
					continue;
				case 2u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 330113597) ^ -344815605;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -730072689;
						num4 = -730072689;
					}
					else
					{
						num3 = -1329865145;
						num4 = -1329865145;
					}
					num = num3 ^ ((int)num2 * -843145973);
					continue;
				}
				default:
					return;
				case 0u:
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
