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
				int num = -238195887;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEAAFA0F8u) % 4u)
					{
					case 3u:
						num = ((int)num2 * -1071234920) ^ -1948265172;
						continue;
					case 1u:
						data = m_Data;
						num = ((int)num2 * -872468311) ^ -1935593682;
						continue;
					case 2u:
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
			int num = 1176732870;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x425BC91Au) % 5u)
				{
				case 4u:
					m_Data = aData;
					num = ((int)num2 * -2008099411) ^ -1987502803;
					continue;
				case 2u:
					num = (int)((num2 * 391422720) ^ 0x456EC73);
					continue;
				case 1u:
					num = ((int)num2 * -352230871) ^ 0x351CA48F;
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

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 640997444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DDD5F5Bu) % 6u)
				{
				case 4u:
					AsFloat = aData;
					num = (int)((num2 * 99800505) ^ 0x40CD7339);
					continue;
				case 3u:
					num = ((int)num2 * -1242520196) ^ -635605317;
					continue;
				case 2u:
					num = ((int)num2 * -266538570) ^ -398936189;
					continue;
				case 1u:
					num = ((int)num2 * -1087824418) ^ -1380681554;
					continue;
				default:
					return;
				case 5u:
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
		while (true)
		{
			int num = 1849997135;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BA77816u) % 5u)
				{
				case 4u:
					AsDouble = aData;
					num = (int)(num2 * 2111115219) ^ -812238730;
					continue;
				case 2u:
					num = (int)(num2 * 1698548216) ^ -1003118431;
					continue;
				case 1u:
					num = ((int)num2 * -1386582829) ^ -43641941;
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
			int num = 1746459500;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x68FB68D3u) % 5u)
				{
				case 4u:
					AsBool = aData;
					num = (int)((num2 * 32758453) ^ 0x2215BB20);
					continue;
				case 3u:
					num = ((int)num2 * -852384513) ^ -1334623706;
					continue;
				case 2u:
					num = ((int)num2 * -2109187455) ^ 0x30DB648C;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1545584665;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x369D33DBu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 2039638253) ^ 0x4FA7E8A1);
					continue;
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1650712601) ^ 0x5A532376;
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
			int num = 2141965811;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x200CA70Cu) % 3u)
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
				num = (int)(num2 * 2072393904) ^ -1222227752;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag = default(bool);
		while (true)
		{
			int num = -393746782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFF57E33u) % 28u)
				{
				case 27u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1320760866) ^ -542778861;
					continue;
				case 26u:
					num = ((int)num2 * -818407542) ^ -2021495336;
					continue;
				case 25u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -728021146;
						num10 = -728021146;
					}
					else
					{
						num9 = -2136593045;
						num10 = -2136593045;
					}
					num = num9 ^ ((int)num2 * -873545807);
					continue;
				}
				case 24u:
					num = ((int)num2 * -785456372) ^ 0x4AAF526C;
					continue;
				case 23u:
					num = ((int)num2 * -574029193) ^ -490966885;
					continue;
				case 22u:
					num = ((int)num2 * -92775513) ^ -1769666849;
					continue;
				case 21u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 179326374) ^ -1738287028;
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)5);
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 1660976929) ^ 0x4B81410D);
					continue;
				case 19u:
					num = (int)((num2 * 1896769771) ^ 0x5C717FB5);
					continue;
				case 18u:
					num = (int)(num2 * 743178045) ^ -1312722044;
					continue;
				case 17u:
					num = (int)((num2 * 987073171) ^ 0x12D4ABF8);
					continue;
				case 16u:
					num = (int)(num2 * 998689959) ^ -1783834762;
					continue;
				case 15u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1201410537) ^ 0x7E22C8BB;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -999965906;
					continue;
				case 12u:
					jSONData.AsDouble = AsDouble;
					num = -1052595848;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -563943788;
						num8 = -563943788;
					}
					else
					{
						num7 = -343545174;
						num8 = -343545174;
					}
					num = num7 ^ ((int)num2 * -907722743);
					continue;
				}
				case 10u:
				{
					int num5;
					int num6;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = -1410883992;
						num6 = -1410883992;
					}
					else
					{
						num5 = -2038552013;
						num6 = -2038552013;
					}
					num = num5 ^ (int)(num2 * 1257079386);
					continue;
				}
				case 9u:
					num = ((int)num2 * -999325042) ^ 0x62854E54;
					continue;
				case 8u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1833158789) ^ 0xD334C1C;
					continue;
				case 7u:
					jSONData.AsFloat = AsFloat;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = -444440182;
					continue;
				case 5u:
					num = (int)(num2 * 381051442) ^ -572575420;
					continue;
				case 4u:
					JSONData.smethod_32(aWriter, (byte)7);
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 1645913304) ^ -756780513;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 511790372;
						num4 = 511790372;
					}
					else
					{
						num3 = 2043775944;
						num4 = 2043775944;
					}
					num = num3 ^ (int)(num2 * 1890048697);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1268245104) ^ 0x49C7D1BC;
					continue;
				case 1u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1322442670) ^ -819141969;
					continue;
				case 0u:
					jSONData.AsBool = AsBool;
					num = -848556667;
					continue;
				default:
					return;
				case 6u:
					break;
				case 13u:
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
