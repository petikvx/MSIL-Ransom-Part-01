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
				int num = 779100696;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7EBF9BDFu) % 3u)
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
					num = (int)((num2 * 633207566) ^ 0x2BA65956);
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
			int num = 732390489;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFDAFD0u) % 4u)
				{
				case 3u:
					m_Data = aData;
					num = (int)((num2 * 1202256194) ^ 0x17FCB0F6);
					continue;
				case 1u:
					num = ((int)num2 * -1789311489) ^ 0x6AB43B70;
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

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 629346395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1D45A222u) % 4u)
				{
				case 2u:
					AsDouble = aData;
					num = ((int)num2 * -1716969866) ^ -1282897423;
					continue;
				case 1u:
					num = (int)(num2 * 462149328) ^ -638104936;
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
		AsBool = aData;
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
		string result = default(string);
		while (true)
		{
			int num = 245271915;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A9BD6B3u) % 3u)
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
				num = ((int)num2 * -80892557) ^ -202844643;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag3 = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1788258536;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94950CC3u) % 27u)
				{
				case 25u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -141930819;
					continue;
				case 24u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 2117841613;
						num10 = 2117841613;
					}
					else
					{
						num9 = 2032708983;
						num10 = 2032708983;
					}
					num = num9 ^ ((int)num2 * -1207094313);
					continue;
				}
				case 23u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1178486055) ^ -1138453961;
					continue;
				case 22u:
					jSONData.AsDouble = AsDouble;
					num = -1384964441;
					continue;
				case 21u:
					num = (int)(num2 * 1169641176) ^ -286533812;
					continue;
				case 19u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -62534737) ^ -361440046;
					continue;
				case 18u:
					num = (int)((num2 * 1720173535) ^ 0x1555ED2A);
					continue;
				case 17u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 275103123) ^ -1422337914;
					continue;
				case 16u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1664608326) ^ -1198735154;
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 294636413) ^ 0x3D8729B2);
					continue;
				case 14u:
					jSONData.AsBool = AsBool;
					num = -802145949;
					continue;
				case 13u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 69204388) ^ 0x1C6BA376);
					continue;
				case 12u:
					num = (int)(num2 * 480660397) ^ -1989558501;
					continue;
				case 11u:
					num = (int)(num2 * 1445501671) ^ -1906756893;
					continue;
				case 10u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -287349127) ^ 0x1F3B8AA5;
					continue;
				case 9u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = -1996272239;
						num8 = -1996272239;
					}
					else
					{
						num7 = -879727773;
						num8 = -879727773;
					}
					num = num7 ^ (int)(num2 * 1512020071);
					continue;
				}
				case 8u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -766699191) ^ -2062117301;
					continue;
				case 7u:
					num = (int)((num2 * 311661515) ^ 0x42BD7365);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 2013897096;
						num6 = 2013897096;
					}
					else
					{
						num5 = 2038588807;
						num6 = 2038588807;
					}
					num = num5 ^ (int)(num2 * 487523666);
					continue;
				}
				case 5u:
					jSONData.AsFloat = AsFloat;
					num = -98331935;
					continue;
				case 4u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -372235682) ^ -606974864;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -1953317683;
						num4 = -1953317683;
					}
					else
					{
						num3 = -1958073651;
						num4 = -1958073651;
					}
					num = num3 ^ (int)(num2 * 1788265172);
					continue;
				}
				case 2u:
					num = (int)((num2 * 320218345) ^ 0x2B372D45);
					continue;
				case 1u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -803746759) ^ 0x7BE919A2;
					continue;
				case 0u:
					num = ((int)num2 * -545385269) ^ 0x3D3DE2A5;
					continue;
				default:
					return;
				case 20u:
					break;
				case 26u:
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
