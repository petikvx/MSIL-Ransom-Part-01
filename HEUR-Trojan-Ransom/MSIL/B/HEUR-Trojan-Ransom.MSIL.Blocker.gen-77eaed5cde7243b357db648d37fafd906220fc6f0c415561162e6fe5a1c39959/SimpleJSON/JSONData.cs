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
				int num = -617548938;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA11C2955u) % 3u)
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
					num = (int)(num2 * 698874537) ^ -194788253;
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
			int num = -1258106418;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE29F9561u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1887754404) ^ -1481152015;
					continue;
				case 2u:
					num = (int)((num2 * 1393516427) ^ 0x19A516B7);
					continue;
				case 1u:
					m_Data = aData;
					num = ((int)num2 * -916973276) ^ 0x4AD68F12;
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
			int num = 2038991103;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x76134057u) % 5u)
				{
				case 4u:
					AsFloat = aData;
					num = ((int)num2 * -857123214) ^ -1164161618;
					continue;
				case 3u:
					num = ((int)num2 * -386653163) ^ -1952883288;
					continue;
				case 1u:
					num = ((int)num2 * -1061415830) ^ 0x185A5F18;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
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
			int num = 2118625763;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEA4F9A2u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1835619897) ^ 0x34E831EE);
					continue;
				case 2u:
					num = ((int)num2 * -799982581) ^ 0x3B45D14E;
					continue;
				case 1u:
					AsBool = aData;
					num = (int)((num2 * 1800973532) ^ 0x5379C280);
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
		AsInt = aData;
	}

	public override string ToString()
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1967957500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29CD9EA1u) % 3u)
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
				num = ((int)num2 * -1439791901) ^ 0x233BFFCA;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		jSONData.AsInt = AsInt;
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -958055519;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6772297u) % 27u)
				{
				case 26u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -658136457) ^ -1091361115;
					continue;
				case 25u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 182847651;
						num10 = 182847651;
					}
					else
					{
						num9 = 540700358;
						num10 = 540700358;
					}
					num = num9 ^ ((int)num2 * -623370869);
					continue;
				}
				case 24u:
					num = ((int)num2 * -1340327752) ^ 0x5F83A350;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 6784408) ^ 0x27E9A013);
					continue;
				case 22u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -417626051) ^ -1692615032;
					continue;
				case 21u:
					num = ((int)num2 * -556404120) ^ -838447921;
					continue;
				case 20u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -2082620738) ^ -227701838;
					continue;
				case 19u:
					jSONData.AsFloat = AsFloat;
					num = -257970241;
					continue;
				case 18u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1325779740;
						num8 = 1325779740;
					}
					else
					{
						num7 = 1174504631;
						num8 = 1174504631;
					}
					num = num7 ^ (int)(num2 * 651522436);
					continue;
				}
				case 17u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1645266205) ^ -1483071259;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -2112672883) ^ 0x470C94BD;
					continue;
				case 15u:
					jSONData.AsDouble = AsDouble;
					num = -319879097;
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 1675535285;
						num6 = 1675535285;
					}
					else
					{
						num5 = 1073010751;
						num6 = 1073010751;
					}
					num = num5 ^ ((int)num2 * -1929594996);
					continue;
				}
				case 13u:
					num = ((int)num2 * -313644633) ^ 0x4956272;
					continue;
				case 10u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 494285206) ^ 0x12E61384);
					continue;
				case 9u:
					num = (int)(num2 * 1429519510) ^ -1249030603;
					continue;
				case 8u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 25800288) ^ -373649783;
					continue;
				case 7u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -398443231) ^ -1411989269;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1875678277;
					continue;
				case 5u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 98986299) ^ -343681661;
					continue;
				case 4u:
					num = (int)((num2 * 992322687) ^ 0x5D5C8C20);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1086962275;
						num4 = -1086962275;
					}
					else
					{
						num3 = -439436473;
						num4 = -439436473;
					}
					num = num3 ^ (int)(num2 * 685886771);
					continue;
				}
				case 2u:
					jSONData.AsBool = AsBool;
					num = -397088812;
					continue;
				case 1u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 342187508) ^ 0x6CAFBB3F);
					continue;
				case 0u:
					num = ((int)num2 * -1077949527) ^ -2074243604;
					continue;
				default:
					return;
				case 12u:
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
