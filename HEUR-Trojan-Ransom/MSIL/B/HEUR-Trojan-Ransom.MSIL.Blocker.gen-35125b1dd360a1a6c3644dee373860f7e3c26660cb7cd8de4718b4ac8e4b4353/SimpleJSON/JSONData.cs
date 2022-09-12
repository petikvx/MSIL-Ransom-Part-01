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
				int num = -1816713982;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC480E9C4u) % 3u)
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
					num = ((int)num2 * -610760351) ^ 0xDF4A239;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 800113930;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x62156441u) % 3u)
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
					num = ((int)num2 * -1600514555) ^ -48304649;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 391918428;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4552D616u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 941330234) ^ 0x3CEA03EE);
					continue;
				case 2u:
					m_Data = aData;
					num = ((int)num2 * -757767306) ^ 0x3A30914;
					continue;
				case 1u:
					num = (int)(num2 * 1707906451) ^ -20639767;
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
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = -1193473882;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC1A5CABu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					AsDouble = aData;
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 306157400) ^ -1212302382;
			}
		}
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 1531486671;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x530CD212u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1607711619) ^ 0xDF3976C;
					continue;
				case 2u:
					num = ((int)num2 * -1886725495) ^ -773699785;
					continue;
				case 1u:
					AsBool = aData;
					num = ((int)num2 * -210088229) ^ 0x7A50951E;
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 688561834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51F5DA5Fu) % 3u)
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
				num = ((int)num2 * -1870897853) ^ -1235122916;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1512643191;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x119239D2u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1147688070) ^ -989571382;
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 380447682) ^ 0x578B89EF);
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
		bool flag3 = default(bool);
		while (true)
		{
			int num = -1245172001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB74132F6u) % 34u)
				{
				case 33u:
					jSONData.AsFloat = AsFloat;
					num = -1275368059;
					continue;
				case 32u:
					num = ((int)num2 * -851647596) ^ -1025014994;
					continue;
				case 31u:
					jSONData.AsDouble = AsDouble;
					num = -880167287;
					continue;
				case 30u:
					num = ((int)num2 * -107597834) ^ 0x76182ACD;
					continue;
				case 29u:
					num = ((int)num2 * -2069264270) ^ -344126682;
					continue;
				case 28u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1369617945) ^ 0x3EB362C4);
					continue;
				case 27u:
					jSONData.AsBool = AsBool;
					num = -2007684666;
					continue;
				case 26u:
					num = (int)(num2 * 896173604) ^ -585679443;
					continue;
				case 25u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -635259877) ^ 0x5418DE2B;
					continue;
				case 24u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1820543921;
						num10 = 1820543921;
					}
					else
					{
						num9 = 1107458768;
						num10 = 1107458768;
					}
					num = num9 ^ ((int)num2 * -1510901467);
					continue;
				}
				case 23u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 1280931592) ^ 0x457ED47E);
					continue;
				case 22u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1827668683) ^ 0x3ABE42C1);
					continue;
				case 21u:
					jSONData = new JSONData("");
					num = ((int)num2 * -607217319) ^ 0x4BFE1350;
					continue;
				case 20u:
					num = ((int)num2 * -274429106) ^ 0x5EE7D9E9;
					continue;
				case 19u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 1252020072;
						num8 = 1252020072;
					}
					else
					{
						num7 = 1724786421;
						num8 = 1724786421;
					}
					num = num7 ^ ((int)num2 * -904109904);
					continue;
				}
				case 18u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1235142007) ^ -1092602113;
					continue;
				case 17u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -600944727) ^ -577221743;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -1435678466) ^ 0x26813D4C;
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -1378556010) ^ -1686689811;
					continue;
				case 14u:
					num = (int)(num2 * 275922457) ^ -1019938873;
					continue;
				case 12u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)((num2 * 924757677) ^ 0xA273D8C);
					continue;
				case 11u:
					num = ((int)num2 * -911939622) ^ 0x57759585;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = -1423269977;
						num6 = -1423269977;
					}
					else
					{
						num5 = -1803490766;
						num6 = -1803490766;
					}
					num = num5 ^ (int)(num2 * 596050033);
					continue;
				}
				case 8u:
					num = ((int)num2 * -1753888955) ^ -1702592739;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 482127463;
						num4 = 482127463;
					}
					else
					{
						num3 = 827664249;
						num4 = 827664249;
					}
					num = num3 ^ (int)(num2 * 3191257);
					continue;
				}
				case 6u:
					num = ((int)num2 * -584396938) ^ 0x4854307F;
					continue;
				case 5u:
					num = (int)(num2 * 248881980) ^ -1737528551;
					continue;
				case 4u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)((num2 * 1220318749) ^ 0xFC1BE2F);
					continue;
				case 3u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 1301423459) ^ -2018182698;
					continue;
				case 2u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 778894340) ^ -454272804;
					continue;
				case 1u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -732496947) ^ 0x2484D7DB;
					continue;
				case 0u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1914487541;
					continue;
				default:
					return;
				case 10u:
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
