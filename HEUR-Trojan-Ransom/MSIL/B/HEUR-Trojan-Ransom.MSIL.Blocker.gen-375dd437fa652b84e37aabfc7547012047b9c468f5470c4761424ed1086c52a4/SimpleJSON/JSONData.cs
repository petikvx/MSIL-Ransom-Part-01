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
				int num = 1026543322;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x77D96CD3u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -1435728393) ^ 0x3BF7DA9E;
						continue;
					case 1u:
						data = m_Data;
						num = ((int)num2 * -153877621) ^ 0x7CB6BF26;
						continue;
					case 0u:
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
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = -1487943346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B14D0AFu) % 5u)
				{
				case 4u:
					AsDouble = aData;
					num = ((int)num2 * -1573945104) ^ 0xC8B45C7;
					continue;
				case 1u:
					num = ((int)num2 * -1935453660) ^ -1129229659;
					continue;
				case 0u:
					num = ((int)num2 * -1791371870) ^ 0xE868BE3;
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
		AsBool = aData;
	}

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 1380919549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49E6D9E9u) % 3u)
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
				num = ((int)num2 * -1603927781) ^ 0x6BBA55CC;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = 1931006260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x10510CD8u) % 3u)
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
				num = ((int)num2 * -1533268695) ^ 0x1BFD85BA;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag4 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 1006133386;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2354884Bu) % 32u)
				{
				case 31u:
					num = ((int)num2 * -2037500545) ^ -1653325186;
					continue;
				case 30u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1139849324) ^ 0x7E97ED4B;
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 288300107) ^ -996214267;
					continue;
				case 28u:
					num = (int)(num2 * 634838260) ^ -1390093473;
					continue;
				case 27u:
					jSONData.AsFloat = AsFloat;
					num = 501414974;
					continue;
				case 26u:
				{
					int num7;
					int num8;
					if (!flag4)
					{
						num7 = -354138781;
						num8 = -354138781;
					}
					else
					{
						num7 = -1271138513;
						num8 = -1271138513;
					}
					num = num7 ^ (int)(num2 * 286517060);
					continue;
				}
				case 25u:
					num = ((int)num2 * -2141161691) ^ 0x40ED3352;
					continue;
				case 24u:
					num = (int)(num2 * 656355922) ^ -821545505;
					continue;
				case 23u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -41570930) ^ 0x6B0D16EA;
					continue;
				case 22u:
					num = ((int)num2 * -1521883857) ^ 0x6F343F84;
					continue;
				case 21u:
					flag4 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1649742936) ^ -202206951;
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)4);
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1816084955) ^ 0x13888B9D);
					continue;
				case 19u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1687244696) ^ 0x2179074A;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!flag3)
					{
						num9 = -1861606210;
						num10 = -1861606210;
					}
					else
					{
						num9 = -972999846;
						num10 = -972999846;
					}
					num = num9 ^ ((int)num2 * -1145075201);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1035035249) ^ -732510902;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1733036824;
					continue;
				case 15u:
					num = (int)(num2 * 6175763) ^ -1334630966;
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1595118896;
						num6 = 1595118896;
					}
					else
					{
						num5 = 1894195597;
						num6 = 1894195597;
					}
					num = num5 ^ (int)(num2 * 498792461);
					continue;
				}
				case 13u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)((num2 * 1127812253) ^ 0x455DE3A4);
					continue;
				case 12u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1608786648) ^ -1386349687;
					continue;
				case 11u:
					num = ((int)num2 * -1776246971) ^ -2028203112;
					continue;
				case 10u:
					num = (int)((num2 * 1031448621) ^ 0x210CA96D);
					continue;
				case 9u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -644642240) ^ -1621014343;
					continue;
				case 7u:
					jSONData.AsBool = AsBool;
					num = 1109580045;
					continue;
				case 6u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1845403025) ^ 0x12D92583);
					continue;
				case 5u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 831811806) ^ 0x647A2CD6);
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 129157861;
						num4 = 129157861;
					}
					else
					{
						num3 = 800343935;
						num4 = 800343935;
					}
					num = num3 ^ ((int)num2 * -1379820015);
					continue;
				}
				case 2u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 206726741) ^ -2032042162;
					continue;
				case 1u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 105346655) ^ -794470499;
					continue;
				case 0u:
					jSONData.AsDouble = AsDouble;
					num = 129285436;
					continue;
				default:
					return;
				case 8u:
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
