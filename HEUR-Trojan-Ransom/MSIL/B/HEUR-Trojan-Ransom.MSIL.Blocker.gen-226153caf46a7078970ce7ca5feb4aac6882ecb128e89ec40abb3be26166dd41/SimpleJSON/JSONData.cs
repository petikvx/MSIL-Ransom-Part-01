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
				int num = -1037519442;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA5BBC2Cu) % 4u)
					{
					case 2u:
						data = m_Data;
						num = (int)(num2 * 1766033950) ^ -752670147;
						continue;
					case 1u:
						num = ((int)num2 * -583769320) ^ -244611312;
						continue;
					case 3u:
						break;
					default:
						return data;
					}
					break;
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
			int num = 1468240797;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE6A53Bu) % 5u)
				{
				case 4u:
					m_Data = aData;
					num = ((int)num2 * -368435706) ^ -819193551;
					continue;
				case 2u:
					num = ((int)num2 * -1642997969) ^ 0x6F5F347;
					continue;
				case 1u:
					num = ((int)num2 * -891759833) ^ 0x1D50B076;
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
		while (true)
		{
			int num = -1123188752;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB15C1552u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					AsFloat = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 545717446) ^ 0x788FD8DE);
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
			int num = 752920593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74941441u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -499682622) ^ -1518107586;
					continue;
				case 4u:
					num = (int)(num2 * 1477312477) ^ -1118614850;
					continue;
				case 2u:
					AsInt = aData;
					num = ((int)num2 * -342641873) ^ 0x77F618AE;
					continue;
				case 1u:
					num = ((int)num2 * -515978216) ^ -777880279;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -862289641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAAE4C994u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 1276708887) ^ -2085797088;
					continue;
				case 1u:
					num = ((int)num2 * -1038459643) ^ -2018576509;
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
			int num = 383892284;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CC79ED7u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 306145714) ^ -651979704;
					continue;
				case 1u:
					num = (int)(num2 * 363289734) ^ -1433221629;
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
		while (true)
		{
			int num = -513747449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96DF39F9u) % 27u)
				{
				case 26u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -453598223) ^ -1516000344;
					continue;
				case 25u:
					num = ((int)num2 * -575281285) ^ 0x3BCF8373;
					continue;
				case 24u:
					jSONData.AsBool = AsBool;
					num = -1127900298;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1373334211) ^ -2145712025;
					continue;
				case 22u:
					num = ((int)num2 * -864649745) ^ -700244096;
					continue;
				case 21u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1874337633) ^ -2020050002;
					continue;
				case 20u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 819532645) ^ -1072200823;
					continue;
				case 18u:
				{
					jSONData.AsFloat = AsFloat;
					int num5;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num = -537781090;
						num5 = -537781090;
					}
					else
					{
						num = -1475213873;
						num5 = -1475213873;
					}
					continue;
				}
				case 17u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1845892269) ^ -2101525241;
					continue;
				case 16u:
					num = (int)((num2 * 1603001366) ^ 0x561C78E4);
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1909451283;
					continue;
				case 13u:
					num = ((int)num2 * -363306763) ^ 0x254AFE82;
					continue;
				case 12u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1895237552) ^ -1650228126;
					continue;
				case 11u:
					num = ((int)num2 * -402110182) ^ 0x7F490A80;
					continue;
				case 10u:
				{
					int num8;
					int num9;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num8 = 1041992506;
						num9 = 1041992506;
					}
					else
					{
						num8 = 848325695;
						num9 = 848325695;
					}
					num = num8 ^ ((int)num2 * -664848951);
					continue;
				}
				case 9u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -614572086) ^ -1502170874;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (flag)
					{
						num6 = -1148504039;
						num7 = -1148504039;
					}
					else
					{
						num6 = -463641840;
						num7 = -463641840;
					}
					num = num6 ^ ((int)num2 * -148164414);
					continue;
				}
				case 7u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 857019420) ^ -311335409;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 1379986017) ^ -721598383;
					continue;
				case 5u:
					num = (int)((num2 * 1587487899) ^ 0x1E296304);
					continue;
				case 4u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1016560697) ^ 0x61AF2745;
					continue;
				case 3u:
					num = ((int)num2 * -239493731) ^ -1925128130;
					continue;
				case 2u:
					jSONData = new JSONData("");
					num = ((int)num2 * -67328799) ^ -756688148;
					continue;
				case 1u:
				{
					jSONData.AsInt = AsInt;
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -676770137;
						num4 = -676770137;
					}
					else
					{
						num3 = -1304770962;
						num4 = -1304770962;
					}
					num = num3 ^ (int)(num2 * 1824556363);
					continue;
				}
				case 0u:
					jSONData.AsDouble = AsDouble;
					num = -649581429;
					continue;
				default:
					return;
				case 19u:
					break;
				case 15u:
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
