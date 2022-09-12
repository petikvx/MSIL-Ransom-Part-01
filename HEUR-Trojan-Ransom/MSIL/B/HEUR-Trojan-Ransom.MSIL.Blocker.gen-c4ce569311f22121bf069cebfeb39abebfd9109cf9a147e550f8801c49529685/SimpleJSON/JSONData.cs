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
			m_Data = value;
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = -476102580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD616E5F2u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				m_Data = aData;
				num = (int)((num2 * 1030910355) ^ 0xC5FC3B9);
			}
		}
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -884293997;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8BA3CA67u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 201188751) ^ -1705065818;
					continue;
				case 3u:
					AsFloat = aData;
					num = ((int)num2 * -188112639) ^ -1329933715;
					continue;
				case 2u:
					num = ((int)num2 * -1247652714) ^ -495871724;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 982721377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2979E90Fu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 61526184) ^ -1293379202;
					continue;
				case 2u:
					num = ((int)num2 * -2103491532) ^ -789999924;
					continue;
				case 0u:
					break;
				default:
					AsDouble = aData;
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
		while (true)
		{
			int num = -1919375629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AF035F1u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 826215433) ^ -1174768088;
					continue;
				case 3u:
					AsInt = aData;
					num = ((int)num2 * -966461506) ^ -1221418838;
					continue;
				case 1u:
					num = (int)((num2 * 1532994249) ^ 0x7FC2FD4C);
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

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1537428077;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC090569u) % 4u)
				{
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 1933516570) ^ -65193892;
					continue;
				case 1u:
					num = (int)(num2 * 1259848886) ^ -649836009;
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

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 2078404304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43FF908Du) % 4u)
				{
				case 3u:
					num = ((int)num2 * -418821422) ^ 0x72E8227D;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 1793749823) ^ -1958308203;
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
			int num = 1437710387;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4FA08B25u) % 30u)
				{
				case 29u:
					num = ((int)num2 * -1268060276) ^ -1962575474;
					continue;
				case 28u:
					num = (int)(num2 * 1377992820) ^ -1596581104;
					continue;
				case 27u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -717498498) ^ -742510255;
					continue;
				case 26u:
					jSONData = new JSONData("");
					num = (int)(num2 * 265196560) ^ -1690255647;
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -908435539) ^ -1585667597;
					continue;
				case 24u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -623342908) ^ 0x6D6EB803;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 969032894) ^ 0x3D64731A);
					continue;
				case 22u:
					num = (int)(num2 * 877987189) ^ -1144832941;
					continue;
				case 21u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1121823904;
						num6 = 1121823904;
					}
					else
					{
						num5 = 295990872;
						num6 = 295990872;
					}
					num = num5 ^ ((int)num2 * -1100365033);
					continue;
				}
				case 20u:
					jSONData.AsBool = AsBool;
					num = 2091749103;
					continue;
				case 19u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = 210861457;
						num10 = 210861457;
					}
					else
					{
						num9 = 1306066468;
						num10 = 1306066468;
					}
					num = num9 ^ ((int)num2 * -2022443853);
					continue;
				}
				case 18u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1688138899) ^ -853749440;
					continue;
				case 17u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1691439163) ^ -2147468895;
					continue;
				case 16u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -1572914528;
						num8 = -1572914528;
					}
					else
					{
						num7 = -1991849473;
						num8 = -1991849473;
					}
					num = num7 ^ (int)(num2 * 1011993079);
					continue;
				}
				case 15u:
					num = ((int)num2 * -404844353) ^ -558524934;
					continue;
				case 14u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -503397773;
						num4 = -503397773;
					}
					else
					{
						num3 = -857057626;
						num4 = -857057626;
					}
					num = num3 ^ ((int)num2 * -1625624808);
					continue;
				}
				case 13u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1706289170) ^ -812436435;
					continue;
				case 12u:
					num = (int)(num2 * 1264667212) ^ -2144598547;
					continue;
				case 11u:
					num = ((int)num2 * -76322013) ^ -539758663;
					continue;
				case 10u:
					num = ((int)num2 * -507804190) ^ -462495494;
					continue;
				case 9u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 314772500) ^ -1383321376;
					continue;
				case 8u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 2063032895;
					continue;
				case 7u:
					num = ((int)num2 * -1548480470) ^ -1268888635;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -96842602) ^ -2468228;
					continue;
				case 5u:
					jSONData.AsDouble = AsDouble;
					num = 314242662;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1569117741) ^ -1910449276;
					continue;
				case 2u:
					jSONData.AsFloat = AsFloat;
					num = 669383553;
					continue;
				case 1u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 443879947) ^ -1370560519;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
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
