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
				int num = -1671609747;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC0DC89C4u) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0009:
					num = (int)((num2 * 659068017) ^ 0x29653756);
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
			int num = -1051552959;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5B5E478u) % 4u)
				{
				case 2u:
					m_Data = aData;
					num = (int)((num2 * 1931380148) ^ 0x42C6C523);
					continue;
				case 1u:
					num = (int)((num2 * 122958602) ^ 0x1ACDBC4C);
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
			int num = 203691300;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43824AE7u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -633615299) ^ -936681932;
					continue;
				case 0u:
					AsFloat = aData;
					num = ((int)num2 * -1096120105) ^ -167154866;
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
			int num = -753758349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0AABB3Eu) % 4u)
				{
				case 3u:
					AsBool = aData;
					num = ((int)num2 * -282716885) ^ 0xED75843;
					continue;
				case 1u:
					num = (int)(num2 * 1817740202) ^ -77006605;
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
			int num = -1671420712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8913AEECu) % 3u)
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
				num = ((int)num2 * -2145177205) ^ 0x3D79EF68;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		bool flag = default(bool);
		while (true)
		{
			int num = 424631187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5A675D62u) % 31u)
				{
				case 30u:
					num = (int)((num2 * 2101893830) ^ 0x4F1AD630);
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 2119251130) ^ -1060299754;
					continue;
				case 28u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 1208186966) ^ -982006705;
					continue;
				case 26u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 358321740) ^ 0x68E8FD7C);
					continue;
				case 25u:
					jSONData.AsFloat = AsFloat;
					num = 1539680792;
					continue;
				case 24u:
					num = ((int)num2 * -1248605414) ^ -1583746539;
					continue;
				case 23u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1711204075;
						num6 = 1711204075;
					}
					else
					{
						num5 = 1502353298;
						num6 = 1502353298;
					}
					num = num5 ^ ((int)num2 * -1085516799);
					continue;
				}
				case 22u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 546978882) ^ 0x2E262BF1);
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = 118902565;
						num10 = 118902565;
					}
					else
					{
						num9 = 756601055;
						num10 = 756601055;
					}
					num = num9 ^ (int)(num2 * 758065811);
					continue;
				}
				case 20u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1185007362;
						num8 = 1185007362;
					}
					else
					{
						num7 = 484940064;
						num8 = 484940064;
					}
					num = num7 ^ (int)(num2 * 1795125074);
					continue;
				}
				case 19u:
					num = (int)(num2 * 1175885572) ^ -2062055296;
					continue;
				case 18u:
					num = ((int)num2 * -878542529) ^ 0x2677A3AA;
					continue;
				case 17u:
					jSONData.AsDouble = AsDouble;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 1741038177;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -2039518809) ^ 0x395530CD;
					continue;
				case 15u:
				{
					jSONData.AsInt = AsInt;
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -1661058714;
						num4 = -1661058714;
					}
					else
					{
						num3 = -1699164145;
						num4 = -1699164145;
					}
					num = num3 ^ (int)(num2 * 1515448615);
					continue;
				}
				case 14u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1553140686;
					continue;
				case 13u:
					num = ((int)num2 * -1491635661) ^ 0x3C29A65A;
					continue;
				case 12u:
					num = ((int)num2 * -1358921626) ^ 0x473CDC2C;
					continue;
				case 11u:
					num = (int)(num2 * 865118016) ^ -2053146367;
					continue;
				case 10u:
					jSONData.AsBool = AsBool;
					num = 1738479189;
					continue;
				case 9u:
					num = ((int)num2 * -497566630) ^ 0x7FEC8AFD;
					continue;
				case 7u:
					num = ((int)num2 * -2064582748) ^ -1884884898;
					continue;
				case 6u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 800324335) ^ 0x7CC46B56);
					continue;
				case 5u:
					num = ((int)num2 * -1398476185) ^ 0x7DC9A1EA;
					continue;
				case 4u:
					num = (int)((num2 * 2029548789) ^ 0x382EB099);
					continue;
				case 3u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 686132551) ^ -1736397739;
					continue;
				case 2u:
					num = (int)((num2 * 1864199878) ^ 0x54FEDA8C);
					continue;
				case 1u:
					num = ((int)num2 * -1167335907) ^ 0x299ECDA1;
					continue;
				case 0u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 355951521) ^ -662449651;
					continue;
				default:
					return;
				case 8u:
					break;
				case 27u:
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
