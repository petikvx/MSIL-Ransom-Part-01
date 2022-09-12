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
				int num = -1801548545;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B032408u) % 3u)
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
					num = ((int)num2 * -1147107587) ^ 0x6B6A8724;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -1077936602;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xBE46F43Cu) % 3u)
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
					num = ((int)num2 * -1613848978) ^ 0x10D7AD3B;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = -496141524;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE2DBB0Cu) % 3u)
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
				num = ((int)num2 * -1337868951) ^ -175272664;
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
			int num = 1675086005;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x32FBB3CFu) % 6u)
				{
				case 4u:
					num = ((int)num2 * -204615101) ^ 0x32E70041;
					continue;
				case 3u:
					num = ((int)num2 * -1049694874) ^ -178672198;
					continue;
				case 2u:
					num = (int)(num2 * 83625316) ^ -773220910;
					continue;
				case 1u:
					AsDouble = aData;
					num = ((int)num2 * -1215639463) ^ 0x3354EFAB;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
		string result = default(string);
		while (true)
		{
			int num = 1894854781;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4D6FF60Cu) % 3u)
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
				num = ((int)num2 * -290010692) ^ 0x332BD73E;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = -1515136936;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C687C93u) % 3u)
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
				num = ((int)num2 * -754496831) ^ -1900144976;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -163409513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86F4659Fu) % 34u)
				{
				case 33u:
					num = (int)(num2 * 194379369) ^ -940574262;
					continue;
				case 32u:
					num = ((int)num2 * -1476625874) ^ 0x7D800979;
					continue;
				case 31u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 243466598) ^ -1210095936;
					continue;
				case 30u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -807430000) ^ -1744343644;
					continue;
				case 29u:
					jSONData.AsBool = AsBool;
					num = -741445732;
					continue;
				case 28u:
					num = ((int)num2 * -1504518153) ^ 0x783232E7;
					continue;
				case 27u:
					jSONData.AsDouble = AsDouble;
					num = -1285379507;
					continue;
				case 26u:
					num = (int)(num2 * 2138586090) ^ -825314434;
					continue;
				case 25u:
					JSONData.smethod_32(aWriter, (byte)5);
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1380597539) ^ 0x172CB3FC;
					continue;
				case 23u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -902461539) ^ 0x1FAE4730;
					continue;
				case 22u:
					JSONData.smethod_32(aWriter, (byte)7);
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 2081572655) ^ -1951099612;
					continue;
				case 21u:
					jSONData.AsFloat = AsFloat;
					num = -1498724207;
					continue;
				case 20u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = 589148931;
						num10 = 589148931;
					}
					else
					{
						num9 = 1706845478;
						num10 = 1706845478;
					}
					num = num9 ^ ((int)num2 * -145154989);
					continue;
				}
				case 18u:
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 1976500613) ^ 0x5CE73DB6);
					continue;
				case 17u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1972720824;
					continue;
				case 16u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -491234113) ^ -1063977051;
					continue;
				case 15u:
					num = (int)((num2 * 1259146431) ^ 0x26BBB33F);
					continue;
				case 14u:
					flag4 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -707991845) ^ 0x69A44FD9;
					continue;
				case 13u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 1032142199) ^ -2045996068;
					continue;
				case 12u:
					num = ((int)num2 * -554666550) ^ 0x56D62AC1;
					continue;
				case 11u:
					num = (int)((num2 * 2075736225) ^ 0x64DF6CFC);
					continue;
				case 10u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -422672076;
						num8 = -422672076;
					}
					else
					{
						num7 = -259014992;
						num8 = -259014992;
					}
					num = num7 ^ (int)(num2 * 781786649);
					continue;
				}
				case 9u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -880253209) ^ -836386866;
					continue;
				case 8u:
					num = (int)(num2 * 1612919384) ^ -1537580971;
					continue;
				case 7u:
					num = (int)((num2 * 360179681) ^ 0x4E189A50);
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -939246136;
						num6 = -939246136;
					}
					else
					{
						num5 = -307269776;
						num6 = -307269776;
					}
					num = num5 ^ ((int)num2 * -2073648916);
					continue;
				}
				case 5u:
					num = (int)((num2 * 1916818330) ^ 0x2544C2D7);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1473858321;
						num4 = 1473858321;
					}
					else
					{
						num3 = 870453382;
						num4 = 870453382;
					}
					num = num3 ^ (int)(num2 * 693780057);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1447928222) ^ 0x317644FC;
					continue;
				case 2u:
					jSONData = new JSONData("");
					num = ((int)num2 * -792063201) ^ -1807973749;
					continue;
				case 1u:
					num = (int)(num2 * 1710658462) ^ -572731973;
					continue;
				case 0u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 1071730048) ^ -569620896;
					continue;
				default:
					return;
				case 19u:
					break;
				case 24u:
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
