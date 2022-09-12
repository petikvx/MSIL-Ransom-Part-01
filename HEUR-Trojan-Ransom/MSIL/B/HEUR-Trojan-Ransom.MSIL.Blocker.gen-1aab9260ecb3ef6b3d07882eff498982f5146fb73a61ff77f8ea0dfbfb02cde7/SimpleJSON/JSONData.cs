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
				int num = 483992689;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x23C56AB4u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1113180000) ^ 0x508000E4);
						continue;
					case 1u:
						data = m_Data;
						num = ((int)num2 * -55501357) ^ -875412776;
						continue;
					case 2u:
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
		while (true)
		{
			int num = 267440969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73A0C164u) % 4u)
				{
				case 2u:
					AsFloat = aData;
					num = (int)((num2 * 1612533293) ^ 0x4E6F4221);
					continue;
				case 1u:
					num = ((int)num2 * -688311494) ^ 0x39546BD8;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = -488700839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCC8580Bu) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1960348791) ^ -775167816;
					continue;
				case 1u:
					AsDouble = aData;
					num = (int)(num2 * 161752360) ^ -970660969;
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
		while (true)
		{
			int num = -754308046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4BB17D5u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1081522376) ^ -1486511732;
					continue;
				case 1u:
					AsBool = aData;
					num = ((int)num2 * -468872202) ^ 0x2B128B49;
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -1973886510;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDBDBD1C2u) % 5u)
				{
				case 4u:
					num = (int)((num2 * 2109096850) ^ 0x586D8C07);
					continue;
				case 1u:
					num = ((int)num2 * -793508252) ^ 0x666E47CB;
					continue;
				case 0u:
					AsInt = aData;
					num = (int)((num2 * 1394034237) ^ 0x3190062A);
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

	public override string ToString()
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = -987771583;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8454B468u) % 3u)
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
				num = ((int)num2 * -380206505) ^ 0x2C63ECD7;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1952849138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC914C8C5u) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -2081156042) ^ 0x50433F95;
					continue;
				case 2u:
					num = ((int)num2 * -1632201536) ^ 0x5324A9BC;
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
		bool flag = default(bool);
		while (true)
		{
			int num = 1563762706;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30172004u) % 28u)
				{
				case 27u:
					num = (int)((num2 * 848981601) ^ 0x6AEBE3D7);
					continue;
				case 26u:
					jSONData.AsBool = AsBool;
					num = 553892294;
					continue;
				case 25u:
					num = (int)(num2 * 2061631964) ^ -919596615;
					continue;
				case 24u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -979537620) ^ -90289585;
					continue;
				case 23u:
					num = (int)(num2 * 999056915) ^ -35235209;
					continue;
				case 21u:
				{
					int num7;
					int num8;
					if (flag)
					{
						num7 = 1506439392;
						num8 = 1506439392;
					}
					else
					{
						num7 = 69435036;
						num8 = 69435036;
					}
					num = num7 ^ (int)(num2 * 1855210432);
					continue;
				}
				case 20u:
				{
					int num9;
					int num10;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = 1489577802;
						num10 = 1489577802;
					}
					else
					{
						num9 = 2068506705;
						num10 = 2068506705;
					}
					num = num9 ^ ((int)num2 * -2125616331);
					continue;
				}
				case 19u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 2102939936) ^ -1372042448;
					continue;
				case 18u:
				{
					int num5;
					int num6;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 1051655538;
						num6 = 1051655538;
					}
					else
					{
						num5 = 2051317765;
						num6 = 2051317765;
					}
					num = num5 ^ ((int)num2 * -1637069314);
					continue;
				}
				case 17u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -254110405) ^ -743542756;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = 1693784415;
					continue;
				case 15u:
					num = (int)((num2 * 905908454) ^ 0x10EAE938);
					continue;
				case 14u:
					jSONData.AsFloat = AsFloat;
					num = 1522862438;
					continue;
				case 12u:
					num = (int)((num2 * 724555063) ^ 0x7DCDB976);
					continue;
				case 11u:
					num = ((int)num2 * -1796942335) ^ 0x221EB570;
					continue;
				case 10u:
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 1125045139) ^ 0x6D3CD00B);
					continue;
				case 9u:
					JSONData.smethod_32(aWriter, (byte)5);
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 1855918120) ^ -906565326;
					continue;
				case 8u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 1747101354) ^ 0x25B6FBF3);
					continue;
				case 7u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1524684307) ^ -906768160;
					continue;
				case 6u:
					jSONData.AsDouble = AsDouble;
					num = 1979977844;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -1189187102;
						num4 = -1189187102;
					}
					else
					{
						num3 = -139361845;
						num4 = -139361845;
					}
					num = num3 ^ ((int)num2 * -1277421972);
					continue;
				}
				case 4u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -428502873) ^ -1226225980;
					continue;
				case 3u:
					num = (int)((num2 * 265309244) ^ 0x3114878E);
					continue;
				case 2u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1730455431) ^ 0x1BFD4BD3);
					continue;
				case 1u:
					num = (int)((num2 * 854676010) ^ 0x50E09C27);
					continue;
				case 0u:
					num = (int)(num2 * 1807991628) ^ -1858705348;
					continue;
				default:
					return;
				case 13u:
					break;
				case 22u:
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
