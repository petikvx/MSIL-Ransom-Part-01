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
				int num = -108204705;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA626309Bu) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = (int)((num2 * 208682916) ^ 0x1CA12A9F);
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
			int num = 934066516;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16AD28E3u) % 5u)
				{
				case 2u:
					num = ((int)num2 * -939157757) ^ 0x64BF8299;
					continue;
				case 1u:
					num = (int)((num2 * 1055906308) ^ 0x27F7C4FC);
					continue;
				case 0u:
					m_Data = aData;
					num = (int)(num2 * 1171018999) ^ -55686451;
					continue;
				default:
					return;
				case 3u:
					break;
				case 4u:
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
			int num = 2032904426;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64DCDA2Du) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					AsFloat = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)((num2 * 71784211) ^ 0xA730F97);
			}
		}
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = 757688474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D6C7007u) % 4u)
				{
				case 1u:
					num = ((int)num2 * -762685164) ^ 0x6C4EE723;
					continue;
				case 0u:
					AsDouble = aData;
					num = (int)(num2 * 796736935) ^ -1621263664;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -1483894449;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB878D40u) % 6u)
				{
				case 3u:
					num = (int)((num2 * 419894749) ^ 0x2272A2A5);
					continue;
				case 2u:
					AsBool = aData;
					num = ((int)num2 * -865890529) ^ -1134721606;
					continue;
				case 1u:
					num = (int)((num2 * 799104313) ^ 0x648FFC94);
					continue;
				case 0u:
					num = (int)((num2 * 1475340587) ^ 0x6D95B711);
					continue;
				default:
					return;
				case 4u:
					break;
				case 5u:
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
			int num = -1528061632;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xECFF6781u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -821943725) ^ 0x387A48BE;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1543890552) ^ -2074777094;
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
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = -682825065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5104517u) % 3u)
				{
				case 1u:
					goto IL_001d;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_001d:
				num = (int)(num2 * 2103577853) ^ -583606372;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 884694338;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69C3B6DCu) % 31u)
				{
				case 30u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1473981946;
						num10 = 1473981946;
					}
					else
					{
						num9 = 1514956474;
						num10 = 1514956474;
					}
					num = num9 ^ ((int)num2 * -621830263);
					continue;
				}
				case 29u:
					num = ((int)num2 * -1356729740) ^ 0x529FAA62;
					continue;
				case 28u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -56928547) ^ 0x4C066B37;
					continue;
				case 27u:
					num = ((int)num2 * -328766840) ^ -853770157;
					continue;
				case 26u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -672978485;
						num6 = -672978485;
					}
					else
					{
						num5 = -80608694;
						num6 = -80608694;
					}
					num = num5 ^ (int)(num2 * 522606922);
					continue;
				}
				case 25u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 1569573972) ^ 0x3E9ABCF3);
					continue;
				case 24u:
					num = ((int)num2 * -703458120) ^ -465957301;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1051056536;
					continue;
				case 22u:
					num = (int)(num2 * 94723938) ^ -1161353987;
					continue;
				case 21u:
					num = ((int)num2 * -1240631874) ^ -732537989;
					continue;
				case 20u:
					num = ((int)num2 * -467821365) ^ -1011822704;
					continue;
				case 19u:
					num = (int)((num2 * 169944376) ^ 0x73798595);
					continue;
				case 18u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1166784851;
						num8 = 1166784851;
					}
					else
					{
						num7 = 1270488869;
						num8 = 1270488869;
					}
					num = num7 ^ (int)(num2 * 505960481);
					continue;
				}
				case 17u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -552192558) ^ 0x74916EC1;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1885623088) ^ -1301839067;
					continue;
				case 15u:
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 1526016256) ^ 0x651DEA5F);
					continue;
				case 13u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 61478846) ^ 0x2134430A);
					continue;
				case 12u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -2050113840;
						num4 = -2050113840;
					}
					else
					{
						num3 = -1972407460;
						num4 = -1972407460;
					}
					num = num3 ^ ((int)num2 * -1079800305);
					continue;
				}
				case 11u:
					jSONData.AsDouble = AsDouble;
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 791352544;
					continue;
				case 10u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 1075420659) ^ -1783672089;
					continue;
				case 8u:
					num = ((int)num2 * -1398112650) ^ 0x6D3E4D09;
					continue;
				case 7u:
					jSONData.AsFloat = AsFloat;
					num = 1947594930;
					continue;
				case 6u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1633188669) ^ -1265372038;
					continue;
				case 5u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 576121068) ^ -1729827225;
					continue;
				case 4u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1716650564) ^ 0x7ED9F04F;
					continue;
				case 3u:
					num = ((int)num2 * -1333013721) ^ -732391718;
					continue;
				case 2u:
					jSONData.AsBool = AsBool;
					num = 1664798487;
					continue;
				case 1u:
					num = ((int)num2 * -475230000) ^ -113310069;
					continue;
				case 0u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1161094375) ^ -1888639754;
					continue;
				default:
					return;
				case 14u:
					break;
				case 9u:
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
