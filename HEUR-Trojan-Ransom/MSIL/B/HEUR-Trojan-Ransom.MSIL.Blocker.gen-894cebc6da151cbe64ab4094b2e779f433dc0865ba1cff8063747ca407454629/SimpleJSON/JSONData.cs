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
				int num = 611169317;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xCF891C2u) % 3u)
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
					num = (int)((num2 * 1702012186) ^ 0x64CBFCF8);
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
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 361301747;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E61EF0Du) % 5u)
				{
				case 4u:
					num = (int)((num2 * 1973783966) ^ 0x10D18B4A);
					continue;
				case 3u:
					AsFloat = aData;
					num = ((int)num2 * -557114273) ^ 0x536D12AC;
					continue;
				case 2u:
					num = (int)(num2 * 1309573486) ^ -371214644;
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
			int num = 1274840765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x384F83BDu) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					AsDouble = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1987138920) ^ -1179242787;
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
			int num = 2107700333;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x50D0E5B1u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				AsInt = aData;
				num = (int)(num2 * 1247957201) ^ -62825925;
			}
		}
	}

	public override string ToString()
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 625322754;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6C7680u) % 3u)
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
				num = (int)((num2 * 1007931961) ^ 0x6258425E);
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 262847746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x275D0D6Bu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1401052106) ^ 0x4975DB4C;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -929654319) ^ -439125652;
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
		JSONData jSONData = new JSONData("");
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1092454512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4EABBAEu) % 36u)
				{
				case 35u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1585839668) ^ -1256244610;
					continue;
				case 34u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -926087645) ^ 0x5124FB91;
					continue;
				case 32u:
					num = (int)(num2 * 566459961) ^ -549158676;
					continue;
				case 31u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)((num2 * 1033906501) ^ 0x26264EB1);
					continue;
				case 30u:
					num = ((int)num2 * -909257822) ^ 0x3704D35F;
					continue;
				case 29u:
					jSONData.AsFloat = AsFloat;
					num = -641934687;
					continue;
				case 28u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1698039564) ^ 0x6A678D63;
					continue;
				case 27u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1304719524;
						num6 = -1304719524;
					}
					else
					{
						num5 = -1170048314;
						num6 = -1170048314;
					}
					num = num5 ^ (int)(num2 * 102519865);
					continue;
				}
				case 26u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -1437760170) ^ 0x11A8B86A;
					continue;
				case 25u:
					num = (int)((num2 * 1787338658) ^ 0x4BCD66BD);
					continue;
				case 24u:
					num = ((int)num2 * -59313610) ^ 0x5EEA48C4;
					continue;
				case 23u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 143238172) ^ -534063755;
					continue;
				case 22u:
					num = (int)(num2 * 1844783271) ^ -45988775;
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1657231746;
					continue;
				case 20u:
					jSONData.AsBool = AsBool;
					num = -1812417851;
					continue;
				case 19u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1123755860) ^ -345079398;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -518677605;
						num10 = -518677605;
					}
					else
					{
						num9 = -1696119052;
						num10 = -1696119052;
					}
					num = num9 ^ (int)(num2 * 169519694);
					continue;
				}
				case 17u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 640861173) ^ 0x5005959F);
					continue;
				case 16u:
					jSONData.AsDouble = AsDouble;
					num = -1005170732;
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 1085778810) ^ -1639036229;
					continue;
				case 14u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -974204822) ^ -1785507340;
					continue;
				case 13u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1510122079) ^ 0x720F4511;
					continue;
				case 12u:
					num = (int)((num2 * 774100499) ^ 0x7390035B);
					continue;
				case 11u:
					num = ((int)num2 * -1713361295) ^ 0x1462F8F2;
					continue;
				case 10u:
					num = (int)(num2 * 727647031) ^ -822987943;
					continue;
				case 9u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1032133352) ^ 0x69E82CD0;
					continue;
				case 8u:
					num = (int)((num2 * 1727060457) ^ 0x578D9C49);
					continue;
				case 7u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1515313913) ^ -1029971531;
					continue;
				case 6u:
					num = (int)(num2 * 416499858) ^ -1185781909;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 504737997;
						num8 = 504737997;
					}
					else
					{
						num7 = 1255965310;
						num8 = 1255965310;
					}
					num = num7 ^ (int)(num2 * 2076961860);
					continue;
				}
				case 4u:
					num = (int)(num2 * 2139389839) ^ -1710860429;
					continue;
				case 3u:
					num = (int)((num2 * 2012346153) ^ 0x4A609A3C);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1276949915;
						num4 = 1276949915;
					}
					else
					{
						num3 = 396730988;
						num4 = 396730988;
					}
					num = num3 ^ (int)(num2 * 1450244169);
					continue;
				}
				case 1u:
					num = (int)((num2 * 481569986) ^ 0x152B913D);
					continue;
				default:
					return;
				case 0u:
					break;
				case 33u:
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
