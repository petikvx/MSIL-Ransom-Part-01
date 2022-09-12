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
				int num = 1994629262;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1DDFD6EFu) % 4u)
					{
					case 2u:
						num = (int)((num2 * 1719691580) ^ 0x19661488);
						continue;
					case 1u:
						data = m_Data;
						num = ((int)num2 * -1945009605) ^ 0x48CFAF8E;
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
		while (true)
		{
			int num = -1920893863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB0980F8u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1119914515) ^ 0x6F702475;
					continue;
				case 1u:
					num = (int)(num2 * 1470036029) ^ -1452236206;
					continue;
				case 0u:
					break;
				default:
					AsFloat = aData;
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
			int num = 923731937;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7D52492Fu) % 4u)
				{
				case 3u:
					AsDouble = aData;
					num = ((int)num2 * -699916901) ^ 0x4CDB3137;
					continue;
				case 2u:
					num = ((int)num2 * -2118745805) ^ -1636502374;
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

	public JSONData(bool aData)
	{
		AsBool = aData;
	}

	public JSONData(int aData)
	{
		while (true)
		{
			int num = -17711599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC709D401u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				AsInt = aData;
				num = ((int)num2 * -1326249546) ^ 0x662C8AA0;
			}
		}
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
			int num = 46516815;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CB768DCu) % 3u)
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
				num = ((int)num2 * -1970369680) ^ -1406663102;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		jSONData.AsInt = AsInt;
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -73015291;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE68DD386u) % 30u)
				{
				case 29u:
					jSONData.AsDouble = AsDouble;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = -594658479;
					continue;
				case 28u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)(num2 * 728855988) ^ -1624021944;
					continue;
				case 27u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1004167564) ^ -1867172433;
					continue;
				case 26u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -198141699) ^ 0x2761C2F;
					continue;
				case 25u:
				{
					int num7;
					int num8;
					if (flag2)
					{
						num7 = -1970761335;
						num8 = -1970761335;
					}
					else
					{
						num7 = -510521244;
						num8 = -510521244;
					}
					num = num7 ^ (int)(num2 * 1408134767);
					continue;
				}
				case 24u:
					jSONData.AsFloat = AsFloat;
					num = -1734629328;
					continue;
				case 23u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -202473786) ^ 0x364F039;
					continue;
				case 22u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 944755653) ^ 0x67DB65C);
					continue;
				case 21u:
					num = ((int)num2 * -643839120) ^ -1802249836;
					continue;
				case 20u:
					num = ((int)num2 * -766388799) ^ -444548486;
					continue;
				case 19u:
					num = (int)(num2 * 437518067) ^ -1123616407;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -407008859;
						num10 = -407008859;
					}
					else
					{
						num9 = -20161245;
						num10 = -20161245;
					}
					num = num9 ^ ((int)num2 * -1556136293);
					continue;
				}
				case 17u:
					num = ((int)num2 * -1448674306) ^ 0x5E7486C;
					continue;
				case 16u:
					num = (int)((num2 * 600429844) ^ 0x3B01FD2C);
					continue;
				case 15u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = -23337372;
					continue;
				case 14u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -631456637) ^ -737501923;
					continue;
				case 13u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -712813279;
						num6 = -712813279;
					}
					else
					{
						num5 = -2045206554;
						num6 = -2045206554;
					}
					num = num5 ^ ((int)num2 * -139137247);
					continue;
				}
				case 12u:
					num = ((int)num2 * -1293441679) ^ -1102404426;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -12943045;
						num4 = -12943045;
					}
					else
					{
						num3 = -710337320;
						num4 = -710337320;
					}
					num = num3 ^ ((int)num2 * -256115709);
					continue;
				}
				case 9u:
					num = ((int)num2 * -44561891) ^ 0x73CE28B3;
					continue;
				case 8u:
					num = ((int)num2 * -1511804594) ^ 0x6654F1B;
					continue;
				case 7u:
					num = (int)((num2 * 1552462579) ^ 0x3E2789AB);
					continue;
				case 6u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 1796175715) ^ -1185911325;
					continue;
				case 5u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -734565659) ^ 0x74B2A746;
					continue;
				case 4u:
					jSONData.AsBool = AsBool;
					num = -1300408592;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 1124107254) ^ 0x2D1F506A);
					continue;
				case 1u:
					num = ((int)num2 * -713531150) ^ -888235717;
					continue;
				case 0u:
					num = (int)(num2 * 985676971) ^ -1975335368;
					continue;
				default:
					return;
				case 2u:
					break;
				case 10u:
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
