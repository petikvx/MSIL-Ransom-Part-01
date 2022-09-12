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
				int num = -1844309232;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA58200E2u) % 3u)
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
					num = ((int)num2 * -12518869) ^ -1897328282;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 911307801;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2D69EB53u) % 3u)
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
					num = (int)((num2 * 2102526331) ^ 0x644C0E9);
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 290585977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C613724u) % 4u)
				{
				case 3u:
					m_Data = aData;
					num = ((int)num2 * -436195557) ^ -1402814449;
					continue;
				case 1u:
					num = (int)(num2 * 2089037301) ^ -321304518;
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
		AsFloat = aData;
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
			int num = -165916488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDCC64EC9u) % 4u)
				{
				case 2u:
					AsInt = aData;
					num = (int)(num2 * 1666058963) ^ -1085997457;
					continue;
				case 1u:
					num = ((int)num2 * -85587518) ^ 0x2E2CD681;
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
			int num = 1877120964;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6920FBD6u) % 3u)
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
				num = ((int)num2 * -21713740) ^ 0x3B120F8B;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1221073090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB64E732u) % 3u)
				{
				case 2u:
					goto IL_001d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_001d:
				num = (int)((num2 * 838800267) ^ 0x1E44FE7);
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
			int num = 2118377236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30F11FFAu) % 33u)
				{
				case 32u:
					jSONData.AsBool = AsBool;
					num = 796478224;
					continue;
				case 30u:
					num = ((int)num2 * -1440055785) ^ 0x6E66DEB9;
					continue;
				case 29u:
					num = ((int)num2 * -2135073060) ^ -370624967;
					continue;
				case 28u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 311649889) ^ -1788031229;
					continue;
				case 27u:
					num = ((int)num2 * -767379067) ^ -98236996;
					continue;
				case 26u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1457984339) ^ 0x3FEC705D);
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -174966085) ^ -1807495840;
					continue;
				case 24u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1505669696;
						num6 = 1505669696;
					}
					else
					{
						num5 = 113841220;
						num6 = 113841220;
					}
					num = num5 ^ ((int)num2 * -650281766);
					continue;
				}
				case 23u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1474530987) ^ -267754743;
					continue;
				case 22u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 901828115) ^ -2139213529;
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -962561187;
						num10 = -962561187;
					}
					else
					{
						num9 = -1961334695;
						num10 = -1961334695;
					}
					num = num9 ^ (int)(num2 * 884149521);
					continue;
				}
				case 19u:
					jSONData.AsDouble = AsDouble;
					num = 852497002;
					continue;
				case 18u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 2112212491;
						num8 = 2112212491;
					}
					else
					{
						num7 = 1923327785;
						num8 = 1923327785;
					}
					num = num7 ^ ((int)num2 * -97936688);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1560162081) ^ -1917668803;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 1947069433) ^ 0x403241F6);
					continue;
				case 15u:
					num = (int)(num2 * 998266025) ^ -1037496221;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -21537318) ^ -519838535;
					continue;
				case 13u:
					num = (int)((num2 * 1854584031) ^ 0x7A18561D);
					continue;
				case 12u:
					num = (int)((num2 * 1299655494) ^ 0x15AF845D);
					continue;
				case 11u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1259349482) ^ -263195568;
					continue;
				case 10u:
					num = (int)(num2 * 1955109381) ^ -766494078;
					continue;
				case 9u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = 1266147834;
					continue;
				case 8u:
					num = (int)(num2 * 1750068820) ^ -1871843158;
					continue;
				case 7u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 798855985) ^ 0x1B74D071);
					continue;
				case 6u:
					num = (int)((num2 * 1883830684) ^ 0x6F1BCE10);
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -636798531;
						num4 = -636798531;
					}
					else
					{
						num3 = -1035170270;
						num4 = -1035170270;
					}
					num = num3 ^ (int)(num2 * 1538464816);
					continue;
				}
				case 4u:
					num = ((int)num2 * -447613549) ^ -2123033082;
					continue;
				case 3u:
					jSONData.AsFloat = AsFloat;
					num = 554489718;
					continue;
				case 2u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1954642916) ^ 0x6216153B;
					continue;
				case 1u:
					num = (int)(num2 * 81939202) ^ -876976124;
					continue;
				case 0u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1604109324) ^ 0x4983DA94;
					continue;
				default:
					return;
				case 20u:
					break;
				case 31u:
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
