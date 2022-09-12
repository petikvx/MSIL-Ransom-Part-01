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
				int num = -1096009173;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC533BDE9u) % 3u)
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
					num = (int)((num2 * 644331205) ^ 0x4F2ABA54);
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
			int num = -2103485640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF384C6A7u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -170089319) ^ 0x19A1A755;
					continue;
				case 1u:
					m_Data = aData;
					num = (int)((num2 * 1859230798) ^ 0xA777B07);
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

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 1942979046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56A39017u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1502481650) ^ 0x5CDC3BCC;
					continue;
				case 1u:
					AsFloat = aData;
					num = ((int)num2 * -1769727712) ^ -1308374827;
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
			int num = 730648966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x52CEF0ABu) % 3u)
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
				num = ((int)num2 * -284461972) ^ -1648752;
			}
		}
	}

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -1420553914;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB11DE38u) % 5u)
				{
				case 4u:
					AsInt = aData;
					num = (int)((num2 * 851681584) ^ 0x257A4FB7);
					continue;
				case 3u:
					num = (int)(num2 * 1682029027) ^ -1345454436;
					continue;
				case 1u:
					num = ((int)num2 * -1632012265) ^ -1943012672;
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -698040207;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD76B5E08u) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 529818236) ^ 0x5DF34580);
					continue;
				case 0u:
					num = ((int)num2 * -1797231157) ^ -1230624421;
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
		string result = default(string);
		while (true)
		{
			int num = 1067399717;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38F1ED62u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 1432881) ^ -820893320;
					continue;
				case 1u:
					num = ((int)num2 * -648584625) ^ -1965455837;
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
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1802063837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B772D77u) % 33u)
				{
				case 32u:
					num = (int)((num2 * 2000773769) ^ 0x31A10109);
					continue;
				case 31u:
					num = ((int)num2 * -228705427) ^ 0x490BF53F;
					continue;
				case 30u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 2001936525) ^ -470609327;
					continue;
				case 29u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1502151353;
						num8 = 1502151353;
					}
					else
					{
						num7 = 760449784;
						num8 = 760449784;
					}
					num = num7 ^ (int)(num2 * 1658457561);
					continue;
				}
				case 28u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -776125942) ^ 0xAD2B484;
					continue;
				case 27u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 468972950) ^ -239723058;
					continue;
				case 25u:
					num = ((int)num2 * -525810874) ^ -922483748;
					continue;
				case 24u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1334022522) ^ -797160487;
					continue;
				case 23u:
					num = (int)((num2 * 929165741) ^ 0x1DAA49E3);
					continue;
				case 22u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1276874238) ^ -733064218;
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 942027348) ^ -569575660;
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1927136407;
						num10 = 1927136407;
					}
					else
					{
						num9 = 953346412;
						num10 = 953346412;
					}
					num = num9 ^ (int)(num2 * 1914817086);
					continue;
				}
				case 19u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1059557534) ^ -1697787768;
					continue;
				case 18u:
					num = ((int)num2 * -1032512640) ^ 0x18652E0C;
					continue;
				case 17u:
					num = ((int)num2 * -843632841) ^ 0x248E7297;
					continue;
				case 16u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 758099091) ^ -730098100;
					continue;
				case 15u:
					jSONData.AsBool = AsBool;
					num = -928038478;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 2076813988) ^ -1057943281;
					continue;
				case 13u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 579367895) ^ -1427856533;
					continue;
				case 12u:
					num = (int)((num2 * 996221082) ^ 0x3B7F9686);
					continue;
				case 11u:
					jSONData.AsFloat = AsFloat;
					num = -1343652772;
					continue;
				case 10u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1406136978) ^ 0x774C560A;
					continue;
				case 9u:
					num = ((int)num2 * -656318492) ^ -2104742854;
					continue;
				case 8u:
					jSONData.AsDouble = AsDouble;
					num = -182620319;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 1532959851;
						num6 = 1532959851;
					}
					else
					{
						num5 = 73675558;
						num6 = 73675558;
					}
					num = num5 ^ (int)(num2 * 513783415);
					continue;
				}
				case 6u:
					num = ((int)num2 * -1840821159) ^ -2022449026;
					continue;
				case 5u:
					num = ((int)num2 * -215223482) ^ 0x296B50FA;
					continue;
				case 4u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 694939467) ^ -1786891152;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -2013558861;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2052135256;
						num4 = -2052135256;
					}
					else
					{
						num3 = -80283338;
						num4 = -80283338;
					}
					num = num3 ^ (int)(num2 * 1547251320);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1112683039) ^ 0x39328ED3;
					continue;
				default:
					return;
				case 26u:
					break;
				case 2u:
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
