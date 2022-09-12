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
				int num = 710904679;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x351C21A1u) % 3u)
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
					num = (int)((num2 * 1976294428) ^ 0x316580B4);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 62007469;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4588B06u) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					m_Data = value;
					num = (int)((num2 * 1003144514) ^ 0x2C11FF7E);
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = -208077369;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA276AD1Eu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					m_Data = aData;
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -794982876) ^ -48425048;
			}
		}
	}

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -1632339804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8702FD48u) % 5u)
				{
				case 4u:
					AsBool = aData;
					num = (int)(num2 * 2019285825) ^ -689865235;
					continue;
				case 2u:
					num = (int)(num2 * 1030244527) ^ -1794371274;
					continue;
				case 1u:
					num = (int)((num2 * 403439658) ^ 0x4F97AEEC);
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

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
		while (true)
		{
			int num = 955652612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A0EE9ADu) % 3u)
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
				num = ((int)num2 * -2089125960) ^ 0x2C16BC0A;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -1200784917;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3DDC476u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1745170996) ^ 0x5274CF74);
					continue;
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 1891971062) ^ 0x4269FBD3);
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
		bool flag = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -1448385336;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE89E3516u) % 31u)
				{
				case 30u:
					num = (int)(num2 * 157100985) ^ -1975658211;
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -1856604645;
					continue;
				case 28u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1665711188;
						num10 = 1665711188;
					}
					else
					{
						num9 = 1997403993;
						num10 = 1997403993;
					}
					num = num9 ^ ((int)num2 * -1911362517);
					continue;
				}
				case 27u:
					JSONData.smethod_32(aWriter, (byte)7);
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -618827932) ^ -1231855939;
					continue;
				case 26u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1631424217) ^ 0x28D1C102);
					continue;
				case 25u:
					jSONData.AsFloat = AsFloat;
					num = -508961164;
					continue;
				case 24u:
					num = ((int)num2 * -1732755657) ^ -1357919411;
					continue;
				case 23u:
					num = (int)(num2 * 994025434) ^ -823399151;
					continue;
				case 22u:
					JSONData.smethod_32(aWriter, (byte)5);
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 942252158) ^ -1236786058;
					continue;
				case 21u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1770676987) ^ 0x5E38B643;
					continue;
				case 19u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -2004995347) ^ -1331810820;
					continue;
				case 18u:
					num = ((int)num2 * -698481426) ^ -54653900;
					continue;
				case 17u:
					jSONData.AsBool = AsBool;
					num = -845453858;
					continue;
				case 16u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -2008488123) ^ 0x59593296;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag2)
					{
						num7 = -983815933;
						num8 = -983815933;
					}
					else
					{
						num7 = -889326058;
						num8 = -889326058;
					}
					num = num7 ^ ((int)num2 * -1450091685);
					continue;
				}
				case 14u:
					num = ((int)num2 * -961210873) ^ -1301595044;
					continue;
				case 12u:
					num = ((int)num2 * -480902819) ^ 0x6FBF32F1;
					continue;
				case 11u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1964567408) ^ 0x183967F);
					continue;
				case 10u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 371292941) ^ -1905787419;
					continue;
				case 9u:
					num = (int)(num2 * 1557659627) ^ -1351250794;
					continue;
				case 8u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -219162523) ^ -500875514;
					continue;
				case 7u:
					jSONData.AsDouble = AsDouble;
					num = -44132786;
					continue;
				case 6u:
					num = ((int)num2 * -211832233) ^ 0x7617A1C8;
					continue;
				case 5u:
					num = (int)(num2 * 1442983335) ^ -1021135492;
					continue;
				case 4u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 2129852635) ^ 0x2A7F123E);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 1426425965;
						num6 = 1426425965;
					}
					else
					{
						num5 = 1760796999;
						num6 = 1760796999;
					}
					num = num5 ^ (int)(num2 * 2143416226);
					continue;
				}
				case 2u:
					num = (int)(num2 * 1112815559) ^ -1447422321;
					continue;
				case 1u:
					jSONData = new JSONData("");
					num = (int)(num2 * 1376749705) ^ -943810575;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 859129555;
						num4 = 859129555;
					}
					else
					{
						num3 = 710508052;
						num4 = 710508052;
					}
					num = num3 ^ (int)(num2 * 1739987441);
					continue;
				}
				default:
					return;
				case 13u:
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
