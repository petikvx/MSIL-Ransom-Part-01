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
			while (true)
			{
				int num = -860494666;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x92FD6465u) % 3u)
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
					num = (int)((num2 * 805610976) ^ 0xC8048BB);
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 1177514238;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47F3B471u) % 3u)
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
				num = (int)(num2 * 1706355249) ^ -65836545;
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
			int num = 901131560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36C3EEEDu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1804214627) ^ -886453937;
					continue;
				case 1u:
					AsDouble = aData;
					num = (int)((num2 * 1033809876) ^ 0x7FFE9E3B);
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

	public JSONData(bool aData)
	{
		AsBool = aData;
	}

	public JSONData(int aData)
	{
		while (true)
		{
			int num = 606115730;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x79F14D64u) % 5u)
				{
				case 3u:
					AsInt = aData;
					num = (int)((num2 * 1939031136) ^ 0x2EBD7258);
					continue;
				case 2u:
					num = ((int)num2 * -1315349850) ^ 0x4781B0B;
					continue;
				case 1u:
					num = ((int)num2 * -332149536) ^ -342298934;
					continue;
				default:
					return;
				case 4u:
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
			int num = 877545043;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x441F5C10u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)(num2 * 1705000506) ^ -1789076736;
					continue;
				case 2u:
					num = (int)((num2 * 35029051) ^ 0x3B618A47);
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
			int num = -1767862467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94F6C97Cu) % 3u)
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
				num = (int)((num2 * 1726925561) ^ 0x36AA003C);
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1558851114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA399341Cu) % 37u)
				{
				case 36u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 2034371868) ^ 0x3022BC8B);
					continue;
				case 35u:
					jSONData = new JSONData("");
					num = ((int)num2 * -2075610651) ^ 0xE824A7;
					continue;
				case 34u:
					num = (int)(num2 * 883819881) ^ -1521517674;
					continue;
				case 33u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -1115885649;
						num8 = -1115885649;
					}
					else
					{
						num7 = -2003718858;
						num8 = -2003718858;
					}
					num = num7 ^ ((int)num2 * -637773874);
					continue;
				}
				case 32u:
					num = ((int)num2 * -195327339) ^ 0xCE1C492;
					continue;
				case 31u:
					num = (int)(num2 * 1482586518) ^ -539890148;
					continue;
				case 30u:
					jSONData.AsBool = AsBool;
					num = -1992852391;
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 1703627428) ^ -1308212379;
					continue;
				case 28u:
					num = ((int)num2 * -954427016) ^ -187252589;
					continue;
				case 27u:
					num = (int)(num2 * 1540498295) ^ -453724071;
					continue;
				case 26u:
				{
					int num9;
					int num10;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -801690108;
						num10 = -801690108;
					}
					else
					{
						num9 = -1219402049;
						num10 = -1219402049;
					}
					num = num9 ^ ((int)num2 * -524073471);
					continue;
				}
				case 25u:
					num = ((int)num2 * -1806887769) ^ -1299550345;
					continue;
				case 24u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1436594226) ^ 0x11E344F7;
					continue;
				case 23u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -843632431;
						num6 = -843632431;
					}
					else
					{
						num5 = -1912442370;
						num6 = -1912442370;
					}
					num = num5 ^ (int)(num2 * 2099676558);
					continue;
				}
				case 22u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1710374185) ^ -300378596;
					continue;
				case 19u:
					num = (int)((num2 * 1462591556) ^ 0x6DDD1EF2);
					continue;
				case 18u:
					jSONData.AsDouble = AsDouble;
					num = -1510048756;
					continue;
				case 17u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1574416491) ^ -1490585878;
					continue;
				case 16u:
					num = ((int)num2 * -184278871) ^ 0x753D34CC;
					continue;
				case 15u:
					num = ((int)num2 * -634519487) ^ 0x32FF31F7;
					continue;
				case 14u:
					num = ((int)num2 * -1989344216) ^ -260788875;
					continue;
				case 13u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1302194778) ^ -263852961;
					continue;
				case 12u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 1307001340) ^ -1183792522;
					continue;
				case 11u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1322498448) ^ 0x28F3FCA9;
					continue;
				case 10u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1418081493) ^ 0x6C36BC24;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1489322061;
						num4 = 1489322061;
					}
					else
					{
						num3 = 1826653733;
						num4 = 1826653733;
					}
					num = num3 ^ (int)(num2 * 1457057709);
					continue;
				}
				case 8u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 1274775511) ^ 0x18190624);
					continue;
				case 7u:
					num = (int)(num2 * 636053099) ^ -1274327478;
					continue;
				case 6u:
					num = ((int)num2 * -683668516) ^ 0x1D38E96D;
					continue;
				case 5u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)((num2 * 931256750) ^ 0x7E345D98);
					continue;
				case 4u:
					jSONData.AsFloat = AsFloat;
					num = -1216844584;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -18749374;
					continue;
				case 2u:
					num = (int)((num2 * 934949317) ^ 0x3377698B);
					continue;
				case 1u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -790145904) ^ -1908081208;
					continue;
				case 0u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -2103785360) ^ 0x11286831;
					continue;
				default:
					return;
				case 21u:
					break;
				case 20u:
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
