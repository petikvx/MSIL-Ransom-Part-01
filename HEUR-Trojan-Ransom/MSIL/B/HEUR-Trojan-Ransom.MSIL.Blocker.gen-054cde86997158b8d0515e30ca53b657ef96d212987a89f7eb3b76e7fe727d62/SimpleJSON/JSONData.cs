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
				int num = -1815439574;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x80BDFF48u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = (int)((num2 * 1970065549) ^ 0x11D8DA9);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1265149308;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x905CB179u) % 3u)
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
					num = ((int)num2 * -951373899) ^ -1986052798;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 712529833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E516BB4u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -193056849) ^ 0x3E45532F;
					continue;
				case 0u:
					m_Data = aData;
					num = ((int)num2 * -1486587249) ^ 0x6FD52C4F;
					continue;
				default:
					return;
				case 2u:
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
			int num = -1270648734;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4390937u) % 5u)
				{
				case 2u:
					num = (int)(num2 * 314887877) ^ -156939094;
					continue;
				case 1u:
					num = (int)(num2 * 1774077800) ^ -729325943;
					continue;
				case 0u:
					AsFloat = aData;
					num = (int)(num2 * 1206284888) ^ -580438590;
					continue;
				default:
					return;
				case 4u:
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
		while (true)
		{
			int num = -1446944403;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF62C6CFu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					AsDouble = aData;
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -883643095) ^ -680719739;
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
			int num = -1619850397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0C1D437u) % 5u)
				{
				case 2u:
					num = ((int)num2 * -2122616540) ^ 0x74A4BC81;
					continue;
				case 1u:
					AsInt = aData;
					num = (int)(num2 * 30939053) ^ -500822348;
					continue;
				case 0u:
					num = (int)(num2 * 1761271949) ^ -1359536815;
					continue;
				default:
					return;
				case 4u:
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
			int num = 638891829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3EE04060u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -8430463) ^ -1554568478;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -8585768) ^ -185086170;
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
			int num = -1443278730;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91A8215Fu) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -183996263) ^ -981507614;
					continue;
				case 0u:
					num = ((int)num2 * -720936575) ^ 0x57AEB720;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -703176810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC48F693Du) % 37u)
				{
				case 36u:
					num = ((int)num2 * -2019017193) ^ -800281870;
					continue;
				case 35u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -770898003) ^ -406894300;
					continue;
				case 34u:
					num = ((int)num2 * -1034266397) ^ -1749739288;
					continue;
				case 32u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1999314378) ^ 0xCE1702A;
					continue;
				case 31u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 1266958263) ^ -2096075667;
					continue;
				case 30u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 11871676) ^ 0x65C9ED45);
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -2034293269) ^ 0x2B1E76BF;
					continue;
				case 28u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 186379657) ^ 0x62A3FB3);
					continue;
				case 27u:
					num = (int)(num2 * 1284976050) ^ -1388394861;
					continue;
				case 26u:
					num = ((int)num2 * -865999832) ^ -1481388025;
					continue;
				case 25u:
					num = (int)((num2 * 1793460609) ^ 0x44767C56);
					continue;
				case 24u:
					num = ((int)num2 * -694726275) ^ -879705687;
					continue;
				case 23u:
					jSONData.AsDouble = AsDouble;
					num = -542217278;
					continue;
				case 22u:
					num = ((int)num2 * -1144557003) ^ -1991922782;
					continue;
				case 21u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)((num2 * 1162490845) ^ 0x67349ED3);
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = 1050024456;
						num10 = 1050024456;
					}
					else
					{
						num9 = 415340288;
						num10 = 415340288;
					}
					num = num9 ^ ((int)num2 * -1379493516);
					continue;
				}
				case 19u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 561357227;
						num8 = 561357227;
					}
					else
					{
						num7 = 1627942607;
						num8 = 1627942607;
					}
					num = num7 ^ ((int)num2 * -1249040445);
					continue;
				}
				case 18u:
					num = (int)(num2 * 461316244) ^ -852492030;
					continue;
				case 17u:
					num = (int)(num2 * 1037442256) ^ -1602406867;
					continue;
				case 16u:
					num = (int)((num2 * 2078688335) ^ 0x28F2B814);
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -2016513379) ^ -1187210218;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1002104829;
					continue;
				case 13u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 548450997) ^ -1760074485;
					continue;
				case 12u:
					jSONData.AsInt = AsInt;
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -148231685) ^ 0x5D762C80;
					continue;
				case 11u:
					jSONData.AsFloat = AsFloat;
					num = -165392656;
					continue;
				case 10u:
					num = (int)((num2 * 175213702) ^ 0x3794B09A);
					continue;
				case 9u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 846054860) ^ -1679459973;
					continue;
				case 8u:
					num = ((int)num2 * -166896209) ^ 0x51DFE713;
					continue;
				case 7u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 806153276) ^ 0x5917DB9B);
					continue;
				case 6u:
					jSONData.AsBool = AsBool;
					num = -2141040724;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -326489034;
						num6 = -326489034;
					}
					else
					{
						num5 = -177249963;
						num6 = -177249963;
					}
					num = num5 ^ ((int)num2 * -217074378);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1058118366) ^ -1233669879;
					continue;
				case 2u:
					num = ((int)num2 * -636933545) ^ 0x410581C8;
					continue;
				case 1u:
					num = ((int)num2 * -1527188902) ^ -373810193;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 638462874;
						num4 = 638462874;
					}
					else
					{
						num3 = 1727233322;
						num4 = 1727233322;
					}
					num = num3 ^ (int)(num2 * 2046074764);
					continue;
				}
				default:
					return;
				case 33u:
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
