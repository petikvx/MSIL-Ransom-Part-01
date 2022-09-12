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
				int num = -1958344768;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBBAFD48Cu) % 3u)
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
					num = (int)(num2 * 551894786) ^ -196697860;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 6203936;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x791427A2u) % 3u)
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
					num = ((int)num2 * -477120711) ^ -1711465942;
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
			int num = -1184106022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD3D41FEu) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1197244428) ^ 0x54319337);
					continue;
				case 2u:
					num = (int)((num2 * 861149659) ^ 0xC9A3075);
					continue;
				case 1u:
					AsDouble = aData;
					num = (int)((num2 * 272301156) ^ 0x7DC9B75E);
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
			int num = -1242272679;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC47FE2B4u) % 6u)
				{
				case 4u:
					AsBool = aData;
					num = (int)(num2 * 1987952566) ^ -890137806;
					continue;
				case 2u:
					num = ((int)num2 * -1681099997) ^ 0x68804E8B;
					continue;
				case 1u:
					num = (int)((num2 * 1791298565) ^ 0x4A7AACA5);
					continue;
				case 0u:
					num = (int)((num2 * 1183266608) ^ 0x51ACD2E8);
					continue;
				default:
					return;
				case 5u:
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
			int num = -1143222944;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBA82E8Fu) % 3u)
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
				num = ((int)num2 * -1715649257) ^ 0x7311267A;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 804815872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7412F3A1u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -342012847) ^ 0x277CBB6C;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1466930497) ^ -1723270204;
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
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 2103805196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43F0032Du) % 32u)
				{
				case 31u:
					num = (int)((num2 * 147956541) ^ 0x4717C2D0);
					continue;
				case 30u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -802345900) ^ -1045782952;
					continue;
				case 29u:
					num = ((int)num2 * -633978563) ^ 0x5B042DB3;
					continue;
				case 28u:
					num = ((int)num2 * -546926376) ^ 0x4E5E0D54;
					continue;
				case 27u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -474535466) ^ 0x12E3D65F;
					continue;
				case 26u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -777055657) ^ 0x33A472E3;
					continue;
				case 24u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -175396628;
						num6 = -175396628;
					}
					else
					{
						num5 = -79501260;
						num6 = -79501260;
					}
					num = num5 ^ (int)(num2 * 614416043);
					continue;
				}
				case 23u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -256732732) ^ 0x49CCF4E8;
					continue;
				case 22u:
					num = ((int)num2 * -1310398460) ^ 0x7E3AD2C;
					continue;
				case 21u:
					jSONData.AsFloat = AsFloat;
					num = 1927153670;
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1360502633;
						num10 = 1360502633;
					}
					else
					{
						num9 = 1713488898;
						num10 = 1713488898;
					}
					num = num9 ^ ((int)num2 * -796129664);
					continue;
				}
				case 19u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 303452420) ^ 0x6EB46F4F);
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 1802174635) ^ -1440431608;
					continue;
				case 17u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1715926907) ^ 0x7295DEA5;
					continue;
				case 16u:
					num = (int)((num2 * 701804266) ^ 0x24FCD8B);
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 591954335) ^ -1870602658;
					continue;
				case 14u:
					num = (int)((num2 * 924437124) ^ 0x2A91E209);
					continue;
				case 13u:
					num = (int)((num2 * 1700370381) ^ 0x574C7AFD);
					continue;
				case 12u:
					num = ((int)num2 * -1767946506) ^ 0x6BB151BF;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -1102670776;
						num8 = -1102670776;
					}
					else
					{
						num7 = -1285224987;
						num8 = -1285224987;
					}
					num = num7 ^ ((int)num2 * -1659416832);
					continue;
				}
				case 10u:
					JSONData.smethod_32(aWriter, (byte)7);
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1273047455) ^ 0x153E151E;
					continue;
				case 9u:
					jSONData.AsBool = AsBool;
					num = 1369933309;
					continue;
				case 8u:
					jSONData.AsDouble = AsDouble;
					num = 406109121;
					continue;
				case 6u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1076530340) ^ 0x64ECE051;
					continue;
				case 5u:
					num = (int)((num2 * 476198676) ^ 0x56FA91E3);
					continue;
				case 4u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1456503250;
					continue;
				case 3u:
					num = ((int)num2 * -1129740444) ^ -1485594958;
					continue;
				case 2u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1863119267) ^ -487275043;
					continue;
				case 1u:
					jSONData = new JSONData("");
					num = ((int)num2 * -492217657) ^ -851990703;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 1071482360;
						num4 = 1071482360;
					}
					else
					{
						num3 = 92049279;
						num4 = 92049279;
					}
					num = num3 ^ (int)(num2 * 730212510);
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 25u:
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
