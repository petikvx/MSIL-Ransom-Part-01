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
				int num = -258055469;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD308CB70u) % 3u)
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
					num = ((int)num2 * -1231514886) ^ -111567353;
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
			int num = -1193676541;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF4DE6B8u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1353976908) ^ 0x580DBB59;
					continue;
				case 3u:
					m_Data = aData;
					num = ((int)num2 * -1839794417) ^ 0x5BBE7490;
					continue;
				case 2u:
					num = (int)((num2 * 1121409706) ^ 0x49C236B3);
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

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -1150029738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3405B23u) % 5u)
				{
				case 4u:
					AsFloat = aData;
					num = (int)(num2 * 880430295) ^ -1675478330;
					continue;
				case 3u:
					num = ((int)num2 * -903211706) ^ -625308104;
					continue;
				case 2u:
					num = ((int)num2 * -1923722127) ^ -235369292;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = -1592889326;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE27099B3u) % 4u)
				{
				case 1u:
					num = (int)((num2 * 2049686803) ^ 0x4B3BA3B4);
					continue;
				case 0u:
					AsDouble = aData;
					num = ((int)num2 * -1671179205) ^ -1067143928;
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
		while (true)
		{
			int num = -2026036466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD139FFE5u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					AsInt = aData;
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -2027578868) ^ 0x482D43AC;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -132746260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB5213EAu) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1098797698) ^ -481968455;
					continue;
				case 2u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -1254063713) ^ 0x32FCDA1B;
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
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		bool flag2 = default(bool);
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		while (true)
		{
			int num = 359992431;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19E6504Du) % 31u)
				{
				case 30u:
					num = ((int)num2 * -188770810) ^ -1217227938;
					continue;
				case 29u:
					JSONData.smethod_32(aWriter, (byte)3);
					JSONData.smethod_37(aWriter, m_Data);
					num = 1675475796;
					continue;
				case 28u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 124880652) ^ -1779396744;
					continue;
				case 27u:
				{
					int num7;
					int num8;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num7 = 1901993465;
						num8 = 1901993465;
					}
					else
					{
						num7 = 1384072600;
						num8 = 1384072600;
					}
					num = num7 ^ (int)(num2 * 194328562);
					continue;
				}
				case 26u:
					num = (int)(num2 * 300121878) ^ -1185989118;
					continue;
				case 25u:
					jSONData.AsDouble = AsDouble;
					num = 2128637091;
					continue;
				case 24u:
					num = ((int)num2 * -1010376352) ^ -1594423948;
					continue;
				case 23u:
					num = (int)(num2 * 2023658022) ^ -296201726;
					continue;
				case 22u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 2032735469) ^ 0xD74FC83);
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (flag2)
					{
						num9 = -812818455;
						num10 = -812818455;
					}
					else
					{
						num9 = -483581058;
						num10 = -483581058;
					}
					num = num9 ^ ((int)num2 * -2571872);
					continue;
				}
				case 20u:
					jSONData.AsFloat = AsFloat;
					num = 1001137536;
					continue;
				case 19u:
					num = (int)(num2 * 79060570) ^ -501755534;
					continue;
				case 18u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 229695187) ^ -1054550418;
					continue;
				case 17u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -583605945) ^ 0x4E5509A8;
					continue;
				case 16u:
					jSONData = new JSONData("");
					num = ((int)num2 * -491362406) ^ 0xF4376A7;
					continue;
				case 15u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1470339390) ^ -1863023647;
					continue;
				case 14u:
					num = (int)(num2 * 671756065) ^ -680082594;
					continue;
				case 13u:
					num = ((int)num2 * -1746234688) ^ -976280620;
					continue;
				case 12u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -109789759) ^ 0x4574A9C0;
					continue;
				case 11u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1063193962;
						num6 = -1063193962;
					}
					else
					{
						num5 = -1814372808;
						num6 = -1814372808;
					}
					num = num5 ^ ((int)num2 * -1041988118);
					continue;
				}
				case 10u:
					num = ((int)num2 * -961047932) ^ -1294779534;
					continue;
				case 9u:
					num = (int)(num2 * 893392810) ^ -1805178284;
					continue;
				case 8u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -1417963230) ^ 0x7C1A1DD6;
					continue;
				case 6u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1090030078) ^ 0x76183752;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 1961006592;
						num4 = 1961006592;
					}
					else
					{
						num3 = 1614645649;
						num4 = 1614645649;
					}
					num = num3 ^ ((int)num2 * -932765430);
					continue;
				}
				case 4u:
					num = ((int)num2 * -516593817) ^ 0x4E6C9134;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 292176430) ^ 0x69F73F53);
					continue;
				case 2u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1335439621) ^ 0x454452EB;
					continue;
				case 1u:
					jSONData.AsBool = AsBool;
					num = 1232150205;
					continue;
				default:
					return;
				case 0u:
					break;
				case 7u:
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
