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
				int num = 532673357;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x480341F3u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 2u:
						break;
					default:
						return data;
					}
					break;
					IL_0003:
					data = m_Data;
					num = ((int)num2 * -1883820831) ^ 0x2D92E925;
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
			int num = 422685122;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x49402115u) % 4u)
				{
				case 3u:
					AsDouble = aData;
					num = ((int)num2 * -1038420920) ^ -1045062191;
					continue;
				case 0u:
					num = ((int)num2 * -1927221440) ^ -812424804;
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

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -1753579977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB35FFE8u) % 4u)
				{
				case 3u:
					AsBool = aData;
					num = (int)((num2 * 1089581018) ^ 0x2C999CCC);
					continue;
				case 2u:
					num = (int)((num2 * 1718713477) ^ 0x3CF0553B);
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 526063540;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29AC583u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = (int)(num2 * 1198642429) ^ -2126375280;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 300697995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59BCD78Eu) % 33u)
				{
				case 32u:
					num = (int)((num2 * 2009702901) ^ 0x51C4A8);
					continue;
				case 31u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -2065958141) ^ -375724096;
					continue;
				case 30u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = (int)((num2 * 295162947) ^ 0x27FB13B9);
					continue;
				case 29u:
					jSONData.AsFloat = AsFloat;
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 589299160;
					continue;
				case 28u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -162484768) ^ -2035309945;
					continue;
				case 27u:
					num = ((int)num2 * -1634839183) ^ -1622184653;
					continue;
				case 26u:
					num = (int)((num2 * 585502226) ^ 0x35BDD880);
					continue;
				case 25u:
					num = (int)(num2 * 235024297) ^ -1134524098;
					continue;
				case 24u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 1061284155) ^ -1403033211;
					continue;
				case 23u:
				{
					int num9;
					int num10;
					if (flag3)
					{
						num9 = 765436160;
						num10 = 765436160;
					}
					else
					{
						num9 = 252595957;
						num10 = 252595957;
					}
					num = num9 ^ ((int)num2 * -2065127964);
					continue;
				}
				case 21u:
					num = (int)((num2 * 2050008133) ^ 0x5959A8DB);
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1278070024) ^ 0x8FFA891;
					continue;
				case 19u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -555424991) ^ -1822636428;
					continue;
				case 18u:
					num = (int)((num2 * 135077784) ^ 0x41D26478);
					continue;
				case 17u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 456562122) ^ -1100574813;
					continue;
				case 16u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 1398380749) ^ 0x6835286B);
					continue;
				case 15u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -649910728) ^ 0x50E8E206;
					continue;
				case 14u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -388905179) ^ 0x78C18196;
					continue;
				case 13u:
					jSONData.AsDouble = AsDouble;
					num = 766163507;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = -2001664369;
						num8 = -2001664369;
					}
					else
					{
						num7 = -799347487;
						num8 = -799347487;
					}
					num = num7 ^ (int)(num2 * 900145767);
					continue;
				}
				case 11u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -27785278) ^ -1997849310;
					continue;
				case 10u:
					jSONData.AsBool = AsBool;
					num = 793126318;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = 203423036;
						num6 = 203423036;
					}
					else
					{
						num5 = 2020744928;
						num6 = 2020744928;
					}
					num = num5 ^ (int)(num2 * 141454295);
					continue;
				}
				case 8u:
					num = (int)(num2 * 589584674) ^ -1508293152;
					continue;
				case 7u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -343633284) ^ 0x10FF16A2;
					continue;
				case 6u:
					num = (int)((num2 * 334023576) ^ 0x2B8E5D68);
					continue;
				case 5u:
					num = ((int)num2 * -1649310150) ^ 0x3720D869;
					continue;
				case 4u:
					num = (int)(num2 * 490478513) ^ -1143376485;
					continue;
				case 3u:
					num = (int)(num2 * 1620434368) ^ -2045505141;
					continue;
				case 1u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1069446799;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -116464983;
						num4 = -116464983;
					}
					else
					{
						num3 = -2124186246;
						num4 = -2124186246;
					}
					num = num3 ^ (int)(num2 * 946336316);
					continue;
				}
				default:
					return;
				case 22u:
					break;
				case 2u:
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
