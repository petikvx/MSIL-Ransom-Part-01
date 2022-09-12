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
				int num = 655868166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x76DAA8F7u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1699874415) ^ 0x5FE4C238);
						continue;
					case 1u:
						data = m_Data;
						num = ((int)num2 * -1779709840) ^ -226328828;
						continue;
					case 0u:
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
			int num = -1012858979;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8EA0286u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					m_Data = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 2028368504) ^ 0x41F0241A);
			}
		}
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 164359383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x694C86D1u) % 6u)
				{
				case 5u:
					AsFloat = aData;
					num = (int)((num2 * 212692628) ^ 0x5B510498);
					continue;
				case 4u:
					num = (int)(num2 * 64317083) ^ -1387705177;
					continue;
				case 3u:
					num = ((int)num2 * -352012521) ^ -261403335;
					continue;
				case 0u:
					num = (int)((num2 * 1820671248) ^ 0x634B98BA);
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

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 1072177098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6418E661u) % 5u)
				{
				case 4u:
					AsBool = aData;
					num = (int)(num2 * 1101150422) ^ -706207522;
					continue;
				case 3u:
					num = ((int)num2 * -330296382) ^ 0x4E08A577;
					continue;
				case 1u:
					num = (int)(num2 * 692281337) ^ -831516517;
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = 285302991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A2B1B14u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 296424132) ^ 0x3773288);
					continue;
				case 3u:
					AsInt = aData;
					num = (int)(num2 * 1710502311) ^ -2115849387;
					continue;
				case 2u:
					num = ((int)num2 * -998662995) ^ 0x7BEE5050;
					continue;
				default:
					return;
				case 0u:
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
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 12615859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52F0A72Cu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = ((int)num2 * -410236076) ^ 0x4AC028F2;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1539902959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2871435u) % 35u)
				{
				case 34u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1839150237;
					continue;
				case 33u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1009349592) ^ -107477526;
					continue;
				case 32u:
					num = ((int)num2 * -134169711) ^ -255721162;
					continue;
				case 31u:
					num = ((int)num2 * -1202454147) ^ -1250200020;
					continue;
				case 30u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -1717807415;
						num8 = -1717807415;
					}
					else
					{
						num7 = -365151149;
						num8 = -365151149;
					}
					num = num7 ^ ((int)num2 * -1017653299);
					continue;
				}
				case 28u:
					num = (int)((num2 * 324433458) ^ 0x2E9430F2);
					continue;
				case 27u:
					num = ((int)num2 * -793207870) ^ -371940462;
					continue;
				case 26u:
					jSONData.AsDouble = AsDouble;
					num = -1097396274;
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 1266149613) ^ 0x145AD3CB);
					continue;
				case 24u:
					num = ((int)num2 * -1284301999) ^ -1850272188;
					continue;
				case 23u:
					num = (int)(num2 * 1372858692) ^ -870596307;
					continue;
				case 22u:
					num = ((int)num2 * -1354753416) ^ 0x7C413F5C;
					continue;
				case 21u:
					jSONData.AsFloat = AsFloat;
					num = -1551088837;
					continue;
				case 20u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -484890107) ^ -1001576425;
					continue;
				case 19u:
					num = ((int)num2 * -754559394) ^ -110043685;
					continue;
				case 18u:
					num = ((int)num2 * -1932407064) ^ -792940835;
					continue;
				case 17u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -8362520) ^ -116950452;
					continue;
				case 16u:
					num = (int)((num2 * 1372134230) ^ 0x7B233921);
					continue;
				case 15u:
					num = (int)((num2 * 932238024) ^ 0x2F821F15);
					continue;
				case 14u:
					jSONData = new JSONData("");
					num = ((int)num2 * -96641311) ^ -560395367;
					continue;
				case 13u:
					jSONData.AsBool = AsBool;
					num = -371382281;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 691317777;
						num10 = 691317777;
					}
					else
					{
						num9 = 1329826159;
						num10 = 1329826159;
					}
					num = num9 ^ (int)(num2 * 783479886);
					continue;
				}
				case 11u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = -1991181933;
						num6 = -1991181933;
					}
					else
					{
						num5 = -421492560;
						num6 = -421492560;
					}
					num = num5 ^ (int)(num2 * 753169422);
					continue;
				}
				case 10u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1670932668) ^ 0x39E2DF71);
					continue;
				case 8u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1969126248) ^ -1961146879;
					continue;
				case 7u:
					num = ((int)num2 * -1202735365) ^ -627652867;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 1917858647) ^ 0x1314DB4D);
					continue;
				case 5u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1560366247) ^ 0x783A619D;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1123465863;
						num4 = 1123465863;
					}
					else
					{
						num3 = 825274686;
						num4 = 825274686;
					}
					num = num3 ^ ((int)num2 * -1337458152);
					continue;
				}
				case 3u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1226641866) ^ -1343838019;
					continue;
				case 2u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 259898576) ^ -562708827;
					continue;
				case 1u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 1476193343) ^ -329018139;
					continue;
				case 0u:
					num = (int)(num2 * 452695773) ^ -1475185360;
					continue;
				default:
					return;
				case 9u:
					break;
				case 29u:
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
